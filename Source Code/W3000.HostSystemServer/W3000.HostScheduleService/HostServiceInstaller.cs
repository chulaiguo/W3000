using System.ComponentModel;
using System.Configuration.Install;
using System.IO;
using System.Reflection;
using System.ServiceProcess;
using System.Xml;
using Cheke.Installer;

namespace W3000.HostScheduleService
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
            // from System.ServiceProcess.ServiceBase 
            this.serviceInstaller.ServiceName = "W3000.ScheduleService";
            this.serviceInstaller.DisplayName = "Workcode W3000 Schedule Service";

            Installers.Add(this.serviceInstaller);

            // Create the process installer.
            this.processInstaller = new ServiceProcessInstaller();
            this.processInstaller.Account = ServiceAccount.LocalSystem;

            Installers.Add(this.processInstaller);
        }

        protected override void OnAfterInstall(System.Collections.IDictionary savedState)
        {
            base.OnAfterInstall(savedState);

            string targetdir = this.Context.Parameters["targetdir"].TrimEnd('\\') + @"\ScheduleService\";

            //Firewall
            string exeFile = string.Format(@"{0}\{1}", targetdir, "W3000.HostScheduleService.exe");
            if (File.Exists(exeFile))
            {
                FirewallHelper.AuthorizeProgram("W3000.ScheduleService", exeFile);
            }
        }

        protected override void OnAfterUninstall(System.Collections.IDictionary savedState)
        {
            base.OnAfterUninstall(savedState);

            try
            {
                //Firewall
                string targetdir = this.Context.Parameters["targetdir"].TrimEnd('\\');
                string exeFile = targetdir + @"\ScheduleService\W3000.HostScheduleService.exe";
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