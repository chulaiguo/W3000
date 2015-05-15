using System;
using System.Threading;

namespace W3000.ScheduleService
{
    public static class Startup
    {
        private static DateTime _LastProcessTime = new DateTime(1900, 1, 1);

        private static bool _IsStopped = false;

        public static void Start()
        {
            Thread process = new Thread(ProcessHandle);
            process.IsBackground = true;
            process.Start();
        }

        public static void Stop()
        {
            _IsStopped = true;
        }

        private static void ProcessHandle()
        {
            try
            {
                Thread.Sleep(3000);

                const int interval = 1000*10;
                while (!_IsStopped)
                {
                    TimeSpan span = DateTime.Now - _LastProcessTime;
                    if (span.TotalMinutes >= 10)
                    {
                        ProcessData();

                        _LastProcessTime = DateTime.Now;
                    }

                    Thread.Sleep(interval);
                }
            }
            catch (Exception ex)
            {
                Utils.WriteError(ex.Message);
            }
        }

        private static void ProcessData()
        {
            try
            {
            }
            catch (Exception ex)
            {
                Utils.WriteError(ex.Message);
            }
        }
    }
}
