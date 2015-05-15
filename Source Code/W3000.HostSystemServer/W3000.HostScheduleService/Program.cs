using System.ServiceProcess;

namespace W3000.HostScheduleService
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        static void Main()
        {
            ServiceBase[] ServicesToRun;
            ServicesToRun = new ServiceBase[] 
                                { 
                                    new HostService() 
                                };
            ServiceBase.Run(ServicesToRun);
        }
    }
}