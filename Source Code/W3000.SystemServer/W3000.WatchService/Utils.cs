using System;
using System.Collections.Generic;
using System.IO;
using Cheke.Installer;
using Cheke.Log;

namespace W3000.WatchService
{
    public static class Utils
    {
        private static readonly ApplicationLog _SysLog = new ApplicationLog();

        public static void WatchService(string serviceName)
        {
            if (!UpdateServiceExecutableFile(serviceName))
                return;

            if (ServiceHelper.IsDisabledStartMode(serviceName))
                return;

            ServiceHelper.WatchRunningService(serviceName);
        }

        private static bool UpdateServiceExecutableFile(string serviceName)
        {
            try
            {
                const string updateExtension = ".update";

                string startupPath = GetServiceFolder(serviceName);
                DirectoryInfo dir = new DirectoryInfo(startupPath);
                if (dir.Exists)
                {
                    Dictionary<string, FileInfo> updateFiles = new Dictionary<string, FileInfo>();
                    foreach (FileInfo item in dir.GetFiles())
                    {
                        if (item.Extension.ToLower() != updateExtension)
                            continue;

                        string oldFilePath = item.FullName.Substring(0, item.FullName.Length - updateExtension.Length);
                        FileInfo oldFile = new FileInfo(oldFilePath);
                        if (oldFile.Exists && item.LastWriteTime.Ticks == oldFile.LastWriteTime.Ticks)
                            continue;

                        updateFiles.Add(oldFilePath, item);
                    }

                    if (updateFiles.Count > 0)
                    {
                        ServiceHelper.StopService(serviceName);

                        foreach (KeyValuePair<string, FileInfo> pair in updateFiles)
                        {
                            byte[] buffer = File.ReadAllBytes(pair.Value.FullName);
                            using (FileStream stream = new FileStream(pair.Key, FileMode.Create))
                            {
                                stream.Write(buffer, 0, buffer.Length);
                            }

                            FileInfo info = new FileInfo(pair.Key);
                            info.LastWriteTime = new DateTime(pair.Value.LastWriteTime.Ticks);
                        }
                    }
                }

                return true;
            }
            catch (Exception ex)
            {
                WriteError(ex.Message);
                return false;
            }
        }

        private static string GetServiceFolder(string serviceName)
        {
            int index = serviceName.IndexOf('.');
            if (index >= 0)
            {
                serviceName = serviceName.Substring(index + 1);
            }

            string path = AppDomain.CurrentDomain.BaseDirectory.TrimEnd('\\');
            index = path.LastIndexOf('\\');
            if (index >= 0)
            {
                path = path.Substring(0, index);
            }

            return string.Format(@"{0}\{1}", path, serviceName);
        }

        #region Log
        public static void WriteError(string error)
        {
            _SysLog.WriteError(error);
        }

        public static void WriteError(string error, Exception ex)
        {
            _SysLog.WriteError(error, ex);
        }

        public static void WriteDebug(string message)
        {
            _SysLog.WriteDebug(message);
        }

        public static void WriteInfo(string info)
        {
            _SysLog.WriteInfo(info);
        }

        #endregion
    }
}