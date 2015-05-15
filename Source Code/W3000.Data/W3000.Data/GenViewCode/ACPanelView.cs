using System;

namespace W3000.Data
{
	[Serializable]
	public partial class ACPanelView
	{
		private System.Guid _aCPanelPK = Guid.Empty;
		private System.Int32 _unitID = 0;
		private System.Guid _bDBuildingPK = Guid.Empty;
		//private System.String _serialNumber = string.Empty;
		private System.String _panelName = string.Empty;
		//private System.Int16 _bufferSize = 0;
		//private System.Boolean _dialUp = false;
		//private System.String _unitPhone = string.Empty;
		//private System.String _unitPhoneCallerID = string.Empty;
		//private System.String _unitExt = string.Empty;
		//private System.Boolean _longDistance = false;
		//private System.String _modemInitString = string.Empty;
		//private System.Int32 _baudRate = 0;
		//private System.String _historyPhone = string.Empty;
		//private System.String _alarmPhone1 = string.Empty;
		//private System.String _alarmPhone2 = string.Empty;
		//private System.String _dialingPrefixPanel = string.Empty;
		//private System.String _dialingSuffixPanel = string.Empty;
		//private System.Boolean _dialOutEnabled = false;
		//private System.Boolean _dayLightSaving = false;
		//private System.Boolean _onSiteMonitor = false;
		//private System.Byte _centralDelay = 0;
		//private System.Byte _elevPulse = 0;
		//private System.Int32 _panelTypeID = 0;
		//private System.Int16 _unbufferTC = 0;
		//private System.Int16 _mandatoryUnbufferTC = 0;
		//private System.Int16 _swingerCount = 0;
		//private System.Int16 _swingerTime = 0;
		//private System.Byte _loopNumb = 0;
		//private System.Byte _portNumb = 0;
		//private System.String _notes = string.Empty;
		//private System.Boolean _trouble = false;
		//private System.Boolean _noVersionCheck = false;
		//private System.DateTime _createdOn = new DateTime(1900, 1, 1);
		//private System.String _createdBy = string.Empty;
		//private System.DateTime _modifiedOn = new DateTime(1900, 1, 1);
		//private System.String _modifiedBy = string.Empty;
		//private System.Guid _deviceId = Guid.Empty;
		//private System.Int32 _dBSyncSeconds = 0;
		//private System.Int32 _dBSaveMinutes = 0;
		//private System.Boolean _isE150 = false;
		//private System.Byte _groupID = 0;
		//private System.Boolean _noAutoDownload = false;
		//private System.DateTime _noAutoDownloadStart = new DateTime(1900, 1, 1);
		//private System.Boolean _locked = false;
		//private System.Boolean _inDebug = false;
		private System.String _address1 = string.Empty;
		private System.Int32 _buildingID = 0;

		public System.Guid ACPanelPK
		{
			get{ return this._aCPanelPK; }
			set{ this._aCPanelPK = value; }
		}

		public System.Int32 UnitID
		{
			get{ return this._unitID; }
			set{ this._unitID = value; }
		}

		public System.Guid BDBuildingPK
		{
			get{ return this._bDBuildingPK; }
			set{ this._bDBuildingPK = value; }
		}

//		public System.String SerialNumber
//		{
//			get{ return this._serialNumber; }
//			set{ this._serialNumber = value; }
//		}

		public System.String PanelName
		{
			get{ return this._panelName; }
			set{ this._panelName = value; }
		}

//		public System.Int16 BufferSize
//		{
//			get{ return this._bufferSize; }
//			set{ this._bufferSize = value; }
//		}

//		public System.Boolean DialUp
//		{
//			get{ return this._dialUp; }
//			set{ this._dialUp = value; }
//		}

//		public System.String UnitPhone
//		{
//			get{ return this._unitPhone; }
//			set{ this._unitPhone = value; }
//		}

//		public System.String UnitPhoneCallerID
//		{
//			get{ return this._unitPhoneCallerID; }
//			set{ this._unitPhoneCallerID = value; }
//		}

//		public System.String UnitExt
//		{
//			get{ return this._unitExt; }
//			set{ this._unitExt = value; }
//		}

//		public System.Boolean LongDistance
//		{
//			get{ return this._longDistance; }
//			set{ this._longDistance = value; }
//		}

//		public System.String ModemInitString
//		{
//			get{ return this._modemInitString; }
//			set{ this._modemInitString = value; }
//		}

//		public System.Int32 BaudRate
//		{
//			get{ return this._baudRate; }
//			set{ this._baudRate = value; }
//		}

//		public System.String HistoryPhone
//		{
//			get{ return this._historyPhone; }
//			set{ this._historyPhone = value; }
//		}

//		public System.String AlarmPhone1
//		{
//			get{ return this._alarmPhone1; }
//			set{ this._alarmPhone1 = value; }
//		}

//		public System.String AlarmPhone2
//		{
//			get{ return this._alarmPhone2; }
//			set{ this._alarmPhone2 = value; }
//		}

//		public System.String DialingPrefixPanel
//		{
//			get{ return this._dialingPrefixPanel; }
//			set{ this._dialingPrefixPanel = value; }
//		}

//		public System.String DialingSuffixPanel
//		{
//			get{ return this._dialingSuffixPanel; }
//			set{ this._dialingSuffixPanel = value; }
//		}

//		public System.Boolean DialOutEnabled
//		{
//			get{ return this._dialOutEnabled; }
//			set{ this._dialOutEnabled = value; }
//		}

//		public System.Boolean DayLightSaving
//		{
//			get{ return this._dayLightSaving; }
//			set{ this._dayLightSaving = value; }
//		}

//		public System.Boolean OnSiteMonitor
//		{
//			get{ return this._onSiteMonitor; }
//			set{ this._onSiteMonitor = value; }
//		}

//		public System.Byte CentralDelay
//		{
//			get{ return this._centralDelay; }
//			set{ this._centralDelay = value; }
//		}

//		public System.Byte ElevPulse
//		{
//			get{ return this._elevPulse; }
//			set{ this._elevPulse = value; }
//		}

//		public System.Int32 PanelTypeID
//		{
//			get{ return this._panelTypeID; }
//			set{ this._panelTypeID = value; }
//		}

//		public System.Int16 UnbufferTC
//		{
//			get{ return this._unbufferTC; }
//			set{ this._unbufferTC = value; }
//		}

//		public System.Int16 MandatoryUnbufferTC
//		{
//			get{ return this._mandatoryUnbufferTC; }
//			set{ this._mandatoryUnbufferTC = value; }
//		}

//		public System.Int16 SwingerCount
//		{
//			get{ return this._swingerCount; }
//			set{ this._swingerCount = value; }
//		}

//		public System.Int16 SwingerTime
//		{
//			get{ return this._swingerTime; }
//			set{ this._swingerTime = value; }
//		}

//		public System.Byte LoopNumb
//		{
//			get{ return this._loopNumb; }
//			set{ this._loopNumb = value; }
//		}

//		public System.Byte PortNumb
//		{
//			get{ return this._portNumb; }
//			set{ this._portNumb = value; }
//		}

//		public System.String Notes
//		{
//			get{ return this._notes; }
//			set{ this._notes = value; }
//		}

//		public System.Boolean Trouble
//		{
//			get{ return this._trouble; }
//			set{ this._trouble = value; }
//		}

//		public System.Boolean NoVersionCheck
//		{
//			get{ return this._noVersionCheck; }
//			set{ this._noVersionCheck = value; }
//		}

//		public System.DateTime CreatedOn
//		{
//			get{ return this._createdOn.ToLocalTime(); }
//			set{ this._createdOn = value.ToUniversalTime(); }
//		}

//		public System.String CreatedBy
//		{
//			get{ return this._createdBy; }
//			set{ this._createdBy = value; }
//		}

//		public System.DateTime ModifiedOn
//		{
//			get{ return this._modifiedOn.ToLocalTime(); }
//			set{ this._modifiedOn = value.ToUniversalTime(); }
//		}

//		public System.String ModifiedBy
//		{
//			get{ return this._modifiedBy; }
//			set{ this._modifiedBy = value; }
//		}

//		public System.Guid DeviceId
//		{
//			get{ return this._deviceId; }
//			set{ this._deviceId = value; }
//		}

//		public System.Int32 DBSyncSeconds
//		{
//			get{ return this._dBSyncSeconds; }
//			set{ this._dBSyncSeconds = value; }
//		}

//		public System.Int32 DBSaveMinutes
//		{
//			get{ return this._dBSaveMinutes; }
//			set{ this._dBSaveMinutes = value; }
//		}

//		public System.Boolean IsE150
//		{
//			get{ return this._isE150; }
//			set{ this._isE150 = value; }
//		}

//		public System.Byte GroupID
//		{
//			get{ return this._groupID; }
//			set{ this._groupID = value; }
//		}

//		public System.Boolean NoAutoDownload
//		{
//			get{ return this._noAutoDownload; }
//			set{ this._noAutoDownload = value; }
//		}

//		public System.DateTime NoAutoDownloadStart
//		{
//			get{ return this._noAutoDownloadStart.ToLocalTime(); }
//			set{ this._noAutoDownloadStart = value.ToUniversalTime(); }
//		}

//		public System.Boolean Locked
//		{
//			get{ return this._locked; }
//			set{ this._locked = value; }
//		}

//		public System.Boolean InDebug
//		{
//			get{ return this._inDebug; }
//			set{ this._inDebug = value; }
//		}

		public System.String Address1
		{
			get{ return this._address1; }
			set{ this._address1 = value; }
		}

		public System.Int32 BuildingID
		{
			get{ return this._buildingID; }
			set{ this._buildingID = value; }
		}

		public ACPanelView()
		{
		}

		public ACPanelView(ACPanelData data)
		{
			this.ACPanelPK = data.ACPanelPK;
			this.UnitID = data.UnitID;
			this.BDBuildingPK = data.BDBuildingPK;
			//this.SerialNumber = data.SerialNumber;
			this.PanelName = data.PanelName;
			//this.BufferSize = data.BufferSize;
			//this.DialUp = data.DialUp;
			//this.UnitPhone = data.UnitPhone;
			//this.UnitPhoneCallerID = data.UnitPhoneCallerID;
			//this.UnitExt = data.UnitExt;
			//this.LongDistance = data.LongDistance;
			//this.ModemInitString = data.ModemInitString;
			//this.BaudRate = data.BaudRate;
			//this.HistoryPhone = data.HistoryPhone;
			//this.AlarmPhone1 = data.AlarmPhone1;
			//this.AlarmPhone2 = data.AlarmPhone2;
			//this.DialingPrefixPanel = data.DialingPrefixPanel;
			//this.DialingSuffixPanel = data.DialingSuffixPanel;
			//this.DialOutEnabled = data.DialOutEnabled;
			//this.DayLightSaving = data.DayLightSaving;
			//this.OnSiteMonitor = data.OnSiteMonitor;
			//this.CentralDelay = data.CentralDelay;
			//this.ElevPulse = data.ElevPulse;
			//this.PanelTypeID = data.PanelTypeID;
			//this.UnbufferTC = data.UnbufferTC;
			//this.MandatoryUnbufferTC = data.MandatoryUnbufferTC;
			//this.SwingerCount = data.SwingerCount;
			//this.SwingerTime = data.SwingerTime;
			//this.LoopNumb = data.LoopNumb;
			//this.PortNumb = data.PortNumb;
			//this.Notes = data.Notes;
			//this.Trouble = data.Trouble;
			//this.NoVersionCheck = data.NoVersionCheck;
			//this.CreatedOn = data.CreatedOn;
			//this.CreatedBy = data.CreatedBy;
			//this.ModifiedOn = data.ModifiedOn;
			//this.ModifiedBy = data.ModifiedBy;
			//this.DeviceId = data.DeviceId;
			//this.DBSyncSeconds = data.DBSyncSeconds;
			//this.DBSaveMinutes = data.DBSaveMinutes;
			//this.IsE150 = data.IsE150;
			//this.GroupID = data.GroupID;
			//this.NoAutoDownload = data.NoAutoDownload;
			//this.NoAutoDownloadStart = data.NoAutoDownloadStart;
			//this.Locked = data.Locked;
			//this.InDebug = data.InDebug;
			this.Address1 = data.Address1;
			this.BuildingID = data.BuildingID;
		}


		public ACPanelData ToACPanelData()
		{
			ACPanelData entity = new ACPanelData();
			entity.ACPanelPK = this.ACPanelPK;
			entity.UnitID = this.UnitID;
			entity.BDBuildingPK = this.BDBuildingPK;
			//entity.SerialNumber = this.SerialNumber;
			entity.PanelName = this.PanelName;
			//entity.BufferSize = this.BufferSize;
			//entity.DialUp = this.DialUp;
			//entity.UnitPhone = this.UnitPhone;
			//entity.UnitPhoneCallerID = this.UnitPhoneCallerID;
			//entity.UnitExt = this.UnitExt;
			//entity.LongDistance = this.LongDistance;
			//entity.ModemInitString = this.ModemInitString;
			//entity.BaudRate = this.BaudRate;
			//entity.HistoryPhone = this.HistoryPhone;
			//entity.AlarmPhone1 = this.AlarmPhone1;
			//entity.AlarmPhone2 = this.AlarmPhone2;
			//entity.DialingPrefixPanel = this.DialingPrefixPanel;
			//entity.DialingSuffixPanel = this.DialingSuffixPanel;
			//entity.DialOutEnabled = this.DialOutEnabled;
			//entity.DayLightSaving = this.DayLightSaving;
			//entity.OnSiteMonitor = this.OnSiteMonitor;
			//entity.CentralDelay = this.CentralDelay;
			//entity.ElevPulse = this.ElevPulse;
			//entity.PanelTypeID = this.PanelTypeID;
			//entity.UnbufferTC = this.UnbufferTC;
			//entity.MandatoryUnbufferTC = this.MandatoryUnbufferTC;
			//entity.SwingerCount = this.SwingerCount;
			//entity.SwingerTime = this.SwingerTime;
			//entity.LoopNumb = this.LoopNumb;
			//entity.PortNumb = this.PortNumb;
			//entity.Notes = this.Notes;
			//entity.Trouble = this.Trouble;
			//entity.NoVersionCheck = this.NoVersionCheck;
			//entity.CreatedOn = this.CreatedOn;
			//entity.CreatedBy = this.CreatedBy;
			//entity.ModifiedOn = this.ModifiedOn;
			//entity.ModifiedBy = this.ModifiedBy;
			//entity.DeviceId = this.DeviceId;
			//entity.DBSyncSeconds = this.DBSyncSeconds;
			//entity.DBSaveMinutes = this.DBSaveMinutes;
			//entity.IsE150 = this.IsE150;
			//entity.GroupID = this.GroupID;
			//entity.NoAutoDownload = this.NoAutoDownload;
			//entity.NoAutoDownloadStart = this.NoAutoDownloadStart;
			//entity.Locked = this.Locked;
			//entity.InDebug = this.InDebug;
			entity.Address1 = this.Address1;
			entity.BuildingID = this.BuildingID;

			return entity;
		}
	}
}
