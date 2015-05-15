using System;
using Cheke;
using Cheke.Log;

namespace W3000.ScheduleService
{
    public static class Utils
    {
        private static readonly ApplicationLog _SysLog = new ApplicationLog();
        private static readonly SecurityToken _Token = new SecurityToken("anonymous", "anonymous", "HelloDataServiceEx");

        public static SecurityToken Token
        {
            get { return _Token; }
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