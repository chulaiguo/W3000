using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.Remoting;
using System.ServiceProcess;
using System.Threading;
using AppsUpdate.Data;
using AppsUpdate.IUpdateService;
using Cheke.ClassFactory;
using Cheke.Installer;

namespace W3000.HostUpdatingService
{
    public partial class HostService : ServiceBase
    {
        private bool _isStopped = false;

        public HostService()
        {
            InitializeComponent();

            this.ServiceName = "W3000.UpdatingService";
        }

        protected override void OnStart(string[] args)
        {
            RemotingConfiguration.Configure(AppDomain.CurrentDomain.SetupInformation.ConfigurationFile, false);

            Thread update = new Thread(UpdateHandle);
            update.IsBackground = true;
            update.Start();
        }

        protected override void OnStop()
        {
            this._isStopped = true;
        }

        private void UpdateHandle()
        {
            try
            {
                Thread.Sleep(5000);

                const int interval = 3 * 60 * 1000;
                while (!this._isStopped)
                {
                    this.UpdateFile();
                    Thread.Sleep(interval);
                }
            }
            catch (Exception ex)
            {
                this.WriteError(ex.Message);
            }
        }

        private void UpdateFile()
        {
            try
            {
                string localDirectory = AppDomain.CurrentDomain.BaseDirectory;
                this.UpdateFileHandle(localDirectory, this.ServiceName);

                bool isUpdate = this.UpdateFileHandle(localDirectory, "W3000.RemotingService");
                if (isUpdate)
                {
                    this.RestartService("W3000.DataService");
                    this.RestartService("W3000.FacadeService");
                    this.RestartService("W3000.ScheduleService");
                    this.RestartService("W3000.JsonService");
                }

                isUpdate = this.UpdateFileHandle(localDirectory, "W3000.ExcelService");
                if (isUpdate)
                {
                    this.RestartService("W3000.ExcelService");
                }

                isUpdate = this.UpdateFileHandle(localDirectory, "W3000.WatchService");
                if (isUpdate)
                {
                    this.RestartService("W3000.WatchService");
                }
            }
            catch (Exception ex)
            {
                this.WriteError(ex.Message);
            }
        }

        private bool UpdateFileHandle(string localDirectory, string projectName)
        {
            try
            {
                if (projectName != this.ServiceName)
                {
                    localDirectory = string.Format(@"{0}\{1}", localDirectory, projectName);
                }
                
                ICompressionDownloadService update = this.UpdateService;
                if (update == null)
                    return false;

                bool isUpdate = false;
                UpdateInfoCollection list = (UpdateInfoCollection)Compression.DecompressToObject(update.GetUpdateInfo(projectName));
                foreach (UpdateInfo item in list)
                {
                    string destFileName = string.Format(@"{0}\{1}", localDirectory, item.FileName);
                    FileInfo local = new FileInfo(destFileName);
                    if (local.Exists && local.LastWriteTime.Ticks == item.LastWriteTime)
                        continue;

                    byte[] buffer = Compression.DecompressToByteArray(this.UpdateService.GetUpdateFile(projectName, item.FileName));
                    if (buffer == null)
                        continue;

                    using (FileStream stream = new FileStream(destFileName, FileMode.Create))
                    {
                        stream.Write(buffer, 0, buffer.Length);
                    }

                    FileInfo info = new FileInfo(destFileName);
                    info.LastWriteTime = new DateTime(item.LastWriteTime);
                    isUpdate = true;
                }

                return isUpdate;
            }
            catch (Exception ex)
            {
                this.WriteError(ex.Message);
                return false;
            }
        }

        private ICompressionDownloadService UpdateService
        {
            get { return (ICompressionDownloadService)ClassBuilder.GetFactory("UpdateServiceFactory"); }
        }

        private void RestartService(string serviceName)
        {
            try
            {
                ServiceController service = new ServiceController(serviceName);
                TimeSpan timeout = TimeSpan.FromSeconds(30);

                if (service.Status == ServiceControllerStatus.Running)
                {
                    service.Stop();
                    service.WaitForStatus(ServiceControllerStatus.Stopped, timeout);
                }

                if (service.Status == ServiceControllerStatus.Stopped)
                {
                    service.Start();
                    service.WaitForStatus(ServiceControllerStatus.Running, timeout);
                }
            }
            catch (Exception ex)
            {
                this.WriteError(ex.Message);
            }
        }

        #region Log
        private void WriteError(string message)
        {
            this.WriteLog(message, EventLogEntryType.Error);
        }

        private void WriteLog(string message, EventLogEntryType type)
        {
            try
            {
                if (!EventLog.SourceExists(this.ServiceName))
                {
                    EventLog.CreateEventSource(this.ServiceName, this.ServiceName);
                }

                EventLog log = new EventLog();
                log.Source = this.ServiceName;
                log.ModifyOverflowPolicy(OverflowAction.OverwriteAsNeeded, 30);
                log.WriteEntry(string.Format("[{0}] at [{1:yyyy-MM-ddHH:mm:ss}]", message, DateTime.Now), type);
            }
            catch
            { }
        }
        #endregion
    }
}