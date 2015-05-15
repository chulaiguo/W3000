using System.ComponentModel;
using System.Configuration.Install;
using System.IO;
using System.Reflection;
using System.ServiceProcess;
using System.Xml;
using Cheke.Installer;

namespace W3000.HostUpdatingService
{
    [RunInstaller(true)]
    public partial class HostServiceInstaller : Installer
    {
        private ServiceInstaller serviceInstaller;
        private ServiceProcessInstaller processInstaller;

        public HostServiceInstaller()
        {
            InitializeComponent();

            // Create new service installer.
            this.serviceInstaller = new ServiceInstaller();

            // Set the attributes for the installer.
            this.serviceInstaller.StartType = ServiceStartMode.Automatic;

            // Set name used by the system to identify this service. This
            // name should be same as the one used in the class derived
            // from System.ServiceProcess.ServiceBase which in our case
            // is "W3000PrintingService".
            this.serviceInstaller.ServiceName = "W3000.UpdatingService";
            this.serviceInstaller.DisplayName = "Workcode W3000 Updating Service";

            Installers.Add(this.serviceInstaller);

            // Create the process installer.
            this.processInstaller = new ServiceProcessInstaller();
            this.processInstaller.Account = ServiceAccount.LocalSystem;

            Installers.Add(this.processInstaller);
        }

        protected override void OnAfterInstall(System.Collections.IDictionary savedState)
        {
            base.OnAfterInstall(savedState);

            string targetdir = this.Context.Parameters["targetdir"].TrimEnd('\\') + @"\UpdatingService\";
            this.CreateUpdateFolderFile(targetdir);

            //Firewall
            string exeFile = string.Format("{0}{1}", targetdir, "W3000.HostUpdatingService.exe");
            if (File.Exists(exeFile))
            {
                FirewallHelper.AuthorizeProgram("W3000.UpdatingService", exeFile);
            }
        }

        private void CreateUpdateFolderFile(string targetdir)
        {
            //Update Updating Service Configure
            string configFile = string.Format("{0}{1}", targetdir, "W3000.HostUpdatingService.exe.config");
            if (File.Exists(configFile))
            {
                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.Load(configFile);
                this.UpdateServiceConfigure(xmlDoc, targetdir);
                xmlDoc.Save(configFile);
            }
        }

        private void UpdateServiceConfigure(XmlDocument xmlDoc, string targetdir)
        {
            //W3000.RemotingService
            string path = string.Format("{0}W3000.RemotingService", targetdir);
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
            XmlNode node = xmlDoc.SelectSingleNode("configuration/appSettings/add[@key='W3000.RemotingService']");
            if (node != null && node.Attributes != null)
            {
                node.Attributes["value"].InnerText = path;
            }

            //W3000.ExcelService
            path = string.Format("{0}W3000.ExcelService", targetdir);
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
            node = xmlDoc.SelectSingleNode("configuration/appSettings/add[@key='W3000.ExcelService']");
            if (node != null && node.Attributes != null)
            {
                node.Attributes["value"].InnerText = path;
            }

            //W3000.WatchService
            path = string.Format("{0}W3000.WatchService", targetdir);
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
            node = xmlDoc.SelectSingleNode("configuration/appSettings/add[@key='W3000.WatchService']");
            if (node != null && node.Attributes != null)
            {
                node.Attributes["value"].InnerText = path;
            }
        }

        protected override void OnAfterUninstall(System.Collections.IDictionary savedState)
        {
            base.OnAfterUninstall(savedState);

            try
            {
                //Firewall
                string targetdir = this.Context.Parameters["targetdir"].TrimEnd('\\');
                string exeFile = targetdir + @"\UpdatingService\W3000.HostUpdatingService.exe";
                FirewallHelper.DeleteProgram(exeFile);

                Assembly thisAssembly = Assembly.GetAssembly(this.GetType());
                if (thisAssembly == null)
                    return;

                int index = thisAssembly.Location.LastIndexOf('\\');
                string appPath = thisAssembly.Location.Substring(0, index);

                string[] dirs = Directory.GetDirectories(appPath);
                foreach (string dir in dirs)
                {
                    Directory.Delete(dir, true);
                }

                string[] files = Directory.GetFiles(appPath);
                foreach (string file in files)
                {
                    if (file == thisAssembly.Location)
                        continue;

                    File.Delete(file);
                }
            }
            catch
            {
            }
        }
    }
}