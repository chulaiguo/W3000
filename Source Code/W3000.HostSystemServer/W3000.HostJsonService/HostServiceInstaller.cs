using System.ComponentModel;
using System.Configuration.Install;
using System.IO;
using System.Reflection;
using System.ServiceProcess;
using Cheke.Installer;

namespace W3000.HostJsonService
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
            this.serviceInstaller.ServiceName = "W3000.JsonService";
            this.serviceInstaller.DisplayName = "Workcode W3000 Json Service";

            Installers.Add(this.serviceInstaller);

            // Create the process installer.
            this.processInstaller = new ServiceProcessInstaller();
            this.processInstaller.Account = ServiceAccount.LocalSystem;

            Installers.Add(this.processInstaller);
        }

        protected override void OnAfterInstall(System.Collections.IDictionary savedState)
        {
            base.OnAfterInstall(savedState);

            string targetdir = this.Context.Parameters["targetdir"].TrimEnd('\\') + @"\JsonService\"; ;

            //Firewall
            string exeFile = string.Format("{0}{1}", targetdir, "W3000.HostJsonService.exe");
            if (File.Exists(exeFile))
            {
                FirewallHelper.AuthorizeProgram("W3000.JsonService", exeFile);
                FirewallHelper.AuthorizePort("W3000.JsonService", 31086, "TCP");
                FirewallHelper.AuthorizePort("W3000.JsonService", 31086, "UDP");
            }
        }

        protected override void OnAfterUninstall(System.Collections.IDictionary savedState)
        {
            base.OnAfterUninstall(savedState);

            try
            {
                //Firewall
                string targetdir = this.Context.Parameters["targetdir"].TrimEnd('\\');
                string exeFile = targetdir + @"\JsonService\W3000.HostJsonService.exe";
                FirewallHelper.DeleteProgram(exeFile);
                FirewallHelper.DeletePort(31086, "TCP");
                FirewallHelper.DeletePort(31086, "UDP");

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
