using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.Remoting;
using System.ServiceModel;
using System.Threading;
using AppsUpdate.Data;
using AppsUpdate.IUpdateService;
using Cheke.ClassFactory;
using Cheke.Installer;

namespace W3000.HostJsonService
{
    public partial class HostService : System.ServiceProcess.ServiceBase
    {
        private ServiceHost _host = null;

        public HostService()
        {
            InitializeComponent();

            this.ServiceName = "W3000.JsonService";
        }

        protected override void OnStart(string[] args)
        {
            //Waiting for update server starting
            //this.RequestAdditionalTime(3000);
            Thread.Sleep(5000);
            
            RemotingConfiguration.Configure(AppDomain.CurrentDomain.SetupInformation.ConfigurationFile, false);
            this.UpdateSelf();

            Thread work = new Thread(WorkHandle);
            work.IsBackground = true;
            work.Start();
        }

        private void WorkHandle()
        {
            try
            {
                Thread.Sleep(5000);
                this._host = new ServiceHost(typeof(W3000.JsonService.ServiceFactory));
                this._host.Open();
            }
            catch (Exception ex)
            {
                this.WriteError(ex.Message);
            }
        }

        protected override void OnStop()
        {
            if(this._host != null)
            {
                this._host.Close();
            }
        }

        #region UpdateSelf

        private void UpdateSelf()
        {
            try
            {
                const string projectName = "W3000.RemotingService";
                string localDirectory = AppDomain.CurrentDomain.BaseDirectory;
                UpdateInfoCollection list = (UpdateInfoCollection)Compression.DecompressToObject(this.UpdateService.GetUpdateInfo(projectName));
                foreach (UpdateInfo item in list)
                {
                    this.UpdateFile(item, projectName, localDirectory);
                }
            }
            catch (Exception ex)
            {
                this.WriteLog(ex.Message, EventLogEntryType.Error);
            }
        }

        private void UpdateFile(UpdateInfo item, string projectName, string localDirectory)
        {
            try
            {
                string destFileName = string.Format(@"{0}\{1}", localDirectory, item.FileName);
                FileInfo local = new FileInfo(destFileName);
                if (local.Exists && local.LastWriteTime.Ticks == item.LastWriteTime)
                    return;

                if (string.Compare(item.FileName, "AppsUpdate.ClientSide.dll", StringComparison.OrdinalIgnoreCase) == 0)
                    return;

                if (string.Compare(item.FileName, "AppsUpdate.Data.dll", StringComparison.OrdinalIgnoreCase) == 0)
                    return;

                if (string.Compare(item.FileName, "AppsUpdate.IUpdateService.dll", StringComparison.OrdinalIgnoreCase) == 0)
                    return;

                if (string.Compare(item.FileName, "Cheke.ClassFactory.dll", StringComparison.OrdinalIgnoreCase) == 0)
                    return;

                if (string.Compare(item.FileName, "Cheke.Configuration.dll", StringComparison.OrdinalIgnoreCase) == 0)
                    return;

                if (string.Compare(item.FileName, "Cheke.Installer.dll", StringComparison.OrdinalIgnoreCase) == 0)
                    return;

                byte[] buffer = Compression.DecompressToByteArray(this.UpdateService.GetUpdateFile(projectName, item.FileName));
                if (buffer == null)
                    return;

                using (FileStream stream = new FileStream(destFileName, FileMode.Create))
                {
                    stream.Write(buffer, 0, buffer.Length);
                }

                FileInfo info = new FileInfo(destFileName);
                info.LastWriteTime = new DateTime(item.LastWriteTime);

            }
            catch (Exception ex)
            {
                this.WriteLog(ex.Message, EventLogEntryType.Error);
            }
        }

        private ICompressionDownloadService UpdateService
        {
            get { return (ICompressionDownloadService)ClassBuilder.GetFactory("UpdateServiceFactory"); }
        }
        #endregion

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