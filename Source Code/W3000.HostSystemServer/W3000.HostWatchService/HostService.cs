﻿using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.Remoting;
using System.Threading;
using AppsUpdate.Data;
using AppsUpdate.IUpdateService;
using Cheke.ClassFactory;
using Cheke.Installer;
using W3000.WatchService;

namespace W3000.HostWatchService
{
    public partial class HostService : System.ServiceProcess.ServiceBase
    {
        public HostService()
        {
            InitializeComponent();

            this.ServiceName = "W3000.WatchService";
        }

        protected override void OnStart(string[] args)
        {
            //Waiting for update server starting
            //this.RequestAdditionalTime(3000);
            Thread.Sleep(3000);
            
            RemotingConfiguration.Configure(AppDomain.CurrentDomain.SetupInformation.ConfigurationFile, false);
            this.UpdateSelf();

            this.Start();
        }

        private void Start()
        {
            Startup.Start();
        }

        protected override void OnStop()
        {
            Startup.Stop();
        }

        #region UpdateSelf
     
        private void UpdateSelf()
        {
            try
            {
                const string projectName = "W3000.WatchService";
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