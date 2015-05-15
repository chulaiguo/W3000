using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Runtime.Remoting;
using System.Security.AccessControl;
using System.Security.Principal;
using System.Windows.Forms;
using AppsUpdate.ClientSide;
using AppsUpdate.Data;

namespace W3000.Host
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            const string projectName = "W3000.Manager";
            try
            {
                RemotingConfiguration.Configure(string.Format("{0}.config", Application.ExecutablePath), true);

                SplashScreen splash = new SplashScreen();
                splash.Show();
                splash.Refresh();

                UpdateDirectoryCollection list = new UpdateDirectoryCollection();
                list.Add(new UpdateDirectory(Application.StartupPath, "W3000.Manager"));
                list.Add(new UpdateDirectory(string.Format("{0}\\Styles", Application.StartupPath), "W3000.Manager.Style"));
                list.Add(new UpdateDirectory(string.Format("{0}\\BackgroundImages", Application.StartupPath), "W3000.Manager.BackgroundImages"));

                if (args.Length == 0)
                {
                    Initiate(projectName, list);
                }
                else
                {
                    if (args[0] == "RunAsAdministrator")
                    {
                        AddEveryoneFullControl();
                    }
                    UpdateFiles(projectName, list);
                }

                splash.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, projectName, MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private static string StartupExecutableFile
        {
            get { return string.Format("{0}\\W3000.Startup.exe", Application.StartupPath); }
        }

        private static void Startup()
        {
            Process.Start(StartupExecutableFile);
        }

        private static void Initiate(string projectName, UpdateDirectoryCollection list)
        {
            int updateFiles = AutoUpdate.GetUpdateFiles(projectName, list);
            if (updateFiles == -1)
                return;

            if (updateFiles == 0)
            {
                Startup();
            }
            else
            {
                try
                {
                    if (!HasEveryoneFullControl())
                    {
                        string verb = string.Empty;
                        OperatingSystem osInfo = Environment.OSVersion;
                        if (osInfo.Platform == PlatformID.Win32NT && osInfo.Version.Major >= 6)
                        {
                            verb = "runas";
                        }

                        ProcessStartInfo processInfo = new ProcessStartInfo();
                        processInfo.FileName = string.Format("{0}", Application.ExecutablePath);
                        processInfo.Verb = verb;
                        processInfo.CreateNoWindow = false;
                        processInfo.Arguments = "RunAsAdministrator";
                        Process.Start(processInfo);
                    }
                    else
                    {
                        ProcessStartInfo processInfo = new ProcessStartInfo();
                        processInfo.FileName = string.Format("{0}", Application.ExecutablePath);
                        processInfo.CreateNoWindow = false;
                        processInfo.Arguments = "RunAsEveryone";
                        Process.Start(processInfo);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, projectName, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
        }

        private static void UpdateFiles(string projectName, UpdateDirectoryCollection list)
        {
            if (!AutoUpdate.Update(projectName, list))
                return;

            Dictionary<string, string> rebootFiles = GetRebootFiles(Application.StartupPath);
            if (rebootFiles.Count > 0)
            {
                ProcessStartInfo processInfo = new ProcessStartInfo();
                processInfo.FileName = string.Format("{0}\\Cheke.Update.exe", Application.StartupPath);
                processInfo.Arguments = String.Format("\"{0}\"", Application.ExecutablePath);
                processInfo.Verb = Process.GetCurrentProcess().StartInfo.Verb;
                processInfo.CreateNoWindow = false;
                Process.Start(processInfo);
            }
            else
            {
                Startup();
            }
        }

        private static void AddEveryoneFullControl()
        {
            string path = GetParentFolder(Application.ExecutablePath);
            path = GetParentFolder(path);

            DirectorySecurity dSecurity = Directory.GetAccessControl(path);
            SecurityIdentifier everyone = new SecurityIdentifier(WellKnownSidType.WorldSid, null);
            dSecurity.AddAccessRule(new FileSystemAccessRule(everyone, FileSystemRights.FullControl | FileSystemRights.Synchronize, InheritanceFlags.ContainerInherit | InheritanceFlags.ObjectInherit, PropagationFlags.InheritOnly, AccessControlType.Allow));
            Directory.SetAccessControl(path, dSecurity);
        }

        private static bool HasEveryoneFullControl()
        {
            string path = GetParentFolder(Application.ExecutablePath);
            path = GetParentFolder(path);

            DirectorySecurity dSecurity = Directory.GetAccessControl(path);
            foreach (FileSystemAccessRule acr in dSecurity.GetAccessRules(true, true, typeof(NTAccount)))
            {
                if (acr.IdentityReference.Value == "Everyone"
                    && acr.FileSystemRights == FileSystemRights.FullControl)
                {
                    return true;
                }
            }

            return false;
        }

        private static string GetParentFolder(string path)
        {
            int index = path.LastIndexOf('\\');
            if (index >= 0)
            {
                path = path.Substring(0, index);
            }

            return path;
        }

        private static Dictionary<string, string> GetRebootFiles(string startupPath)
        {
            const string updateExtension = ".update";

            Dictionary<string, string> rebootFiles = new Dictionary<string, string>();
            DirectoryInfo dirUpdate = new DirectoryInfo(startupPath);
            foreach (FileInfo item in dirUpdate.GetFiles())
            {
                if (item.Extension.ToLower() != updateExtension)
                    continue;

                string oldFilePath = item.FullName.Substring(0, item.FullName.Length - updateExtension.Length);
                FileInfo oldFile = new FileInfo(oldFilePath);
                if (oldFile.Exists && item.LastWriteTime.Ticks == oldFile.LastWriteTime.Ticks)
                    continue;

                rebootFiles.Add(item.FullName, oldFilePath);
            }

            return rebootFiles;
        }
    }
}
