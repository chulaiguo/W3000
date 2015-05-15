using System;
using System.Collections.Generic;
using System.Threading;

namespace W3000.WatchService
{
    public static class Startup
    {
        private static bool _IsStopped = false;

        public static void Start()
        {
            List<WatchItem> list = new List<WatchItem>();
            list.Add(new WatchItem("W3000.UpdatingService", 1 * 60));

            list.Add(new WatchItem("W3000.DataService", 1 * 60));
            list.Add(new WatchItem("W3000.FacadeService", 1 * 60));

            list.Add(new WatchItem("W3000.ExcelService", 1 * 60));

            list.Add(new WatchItem("W3000.ScheduleService", 1 * 60));

            Thread watch = new Thread(WatchHandle);
            watch.IsBackground = true;
            watch.Start(list);
        }

        public static void Stop()
        {
            _IsStopped = true;
        }

        private static void WatchHandle(object state)
        {
            try
            {
                List<WatchItem> list = state as List<WatchItem>;
                if (list == null || list.Count == 0)
                    return;

                Utils.WatchService("W3000.UpdatingService");
                Thread.Sleep(1000 * 30);

                const int interval = 1000 * 10;
                while (!_IsStopped)
                {
                    foreach (WatchItem item in list)
                    {
                        if (item.IsNeedWatch())
                        {
                            Utils.WatchService(item.ServiceName);
                        }
                    }

                    Thread.Sleep(interval);
                }
            }
            catch (Exception ex)
            {
                Utils.WriteError(ex.Message);
            }
        }
    }

    public class WatchItem
    {
        private readonly string _serviceName = string.Empty;
        private readonly int _seconds = 0;

        private DateTime _lastWatchTime = new DateTime(1900, 1, 1);

        public WatchItem(string serviceName, int seconds)
        {
            this._serviceName = serviceName;
            this._seconds = seconds;
        }

        public string ServiceName
        {
            get { return _serviceName; }
        }

        public bool IsNeedWatch()
        {
            TimeSpan span = DateTime.Now - this._lastWatchTime;
            if (span.TotalSeconds >= this._seconds)
            {
                this._lastWatchTime = DateTime.Now;
                return true;
            }

            return false;
        }
    }
}
