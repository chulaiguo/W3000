using System;

namespace W3000.Data
{
	[Serializable]
	public partial class ACMainZoneView
	{
		private System.Guid _aCMainZonePK = Guid.Empty;
		private System.Guid _aCPanelPK = Guid.Empty;
		private System.Byte _mainZoneID = 0;
		private System.Int32 _mainZoneTypeID = 0;
		private System.String _description = string.Empty;
		//private System.String _readerName = string.Empty;
		//private System.Int32 _readerTypeID = 0;
		//private System.Boolean _reverseColor = false;
		//private System.Byte _outputGroup = 0;
		//private System.Boolean _needPin = false;
		//private System.String _antiPassback = string.Empty;
		//private System.Boolean _softAntiPassback = false;
		//private System.Int16 _unlockTimecode = 0;
		//private System.Boolean _unlockOn1stRead = false;
		//private System.Boolean _rexShuntOnly = false;
		//private System.Int16 _pulseTime = 0;
		//private System.Boolean _relockByTimeout = false;
		//private System.Int16 _forceAMFormat = 0;
		//private System.Int16 _propAMFFormat = 0;
		//private System.Int16 _debounce = 0;
		//private System.Int16 _allowOpenTime = 0;
		//private System.Boolean _noPreAlarm = false;
		//private System.String _postPreAlarm = string.Empty;
		//private System.Int16 _postDuration = 0;
		//private System.String _notes = string.Empty;
		//private System.String _eventNotifyEmail = string.Empty;
		//private System.Boolean _isPulsed = false;
		//private System.Boolean _alwaysToMAS = false;
		//private System.Boolean _commentBeforePulse = false;
		//private System.DateTime _createdOn = new DateTime(1900, 1, 1);
		//private System.String _createdBy = string.Empty;
		//private System.DateTime _modifiedOn = new DateTime(1900, 1, 1);
		//private System.String _modifiedBy = string.Empty;
		//private System.Boolean _degrade = false;
		//private System.String _readerPassMode = string.Empty;
		//private System.Byte _panelZoneID = 0;
		//private System.Int32 _lockTypeID = 0;
		//private System.Boolean _locked = false;
		//private System.Byte _inputGroup = 0;
		//private System.Int16 _unlockTempTC = 0;
		//private System.DateTime _unlockTempBegin = new DateTime(1900, 1, 1);
		//private System.DateTime _unlockTempEnd = new DateTime(1900, 1, 1);
		private System.Guid _bDBuildingPK = Guid.Empty;
		private System.Int32 _unitID = 0;
		private System.String _address1 = string.Empty;
		private System.Int32 _buildingID = 0;

		public System.Guid ACMainZonePK
		{
			get{ return this._aCMainZonePK; }
			set{ this._aCMainZonePK = value; }
		}

		public System.Guid ACPanelPK
		{
			get{ return this._aCPanelPK; }
			set{ this._aCPanelPK = value; }
		}

		public System.Byte MainZoneID
		{
			get{ return this._mainZoneID; }
			set{ this._mainZoneID = value; }
		}

		public System.Int32 MainZoneTypeID
		{
			get{ return this._mainZoneTypeID; }
			set{ this._mainZoneTypeID = value; }
		}

		public System.String Description
		{
			get{ return this._description; }
			set{ this._description = value; }
		}

//		public System.String ReaderName
//		{
//			get{ return this._readerName; }
//			set{ this._readerName = value; }
//		}

//		public System.Int32 ReaderTypeID
//		{
//			get{ return this._readerTypeID; }
//			set{ this._readerTypeID = value; }
//		}

//		public System.Boolean ReverseColor
//		{
//			get{ return this._reverseColor; }
//			set{ this._reverseColor = value; }
//		}

//		public System.Byte OutputGroup
//		{
//			get{ return this._outputGroup; }
//			set{ this._outputGroup = value; }
//		}

//		public System.Boolean NeedPin
//		{
//			get{ return this._needPin; }
//			set{ this._needPin = value; }
//		}

//		public System.String AntiPassback
//		{
//			get{ return this._antiPassback; }
//			set{ this._antiPassback = value; }
//		}

//		public System.Boolean SoftAntiPassback
//		{
//			get{ return this._softAntiPassback; }
//			set{ this._softAntiPassback = value; }
//		}

//		public System.Int16 UnlockTimecode
//		{
//			get{ return this._unlockTimecode; }
//			set{ this._unlockTimecode = value; }
//		}

//		public System.Boolean UnlockOn1stRead
//		{
//			get{ return this._unlockOn1stRead; }
//			set{ this._unlockOn1stRead = value; }
//		}

//		public System.Boolean RexShuntOnly
//		{
//			get{ return this._rexShuntOnly; }
//			set{ this._rexShuntOnly = value; }
//		}

//		public System.Int16 PulseTime
//		{
//			get{ return this._pulseTime; }
//			set{ this._pulseTime = value; }
//		}

//		public System.Boolean RelockByTimeout
//		{
//			get{ return this._relockByTimeout; }
//			set{ this._relockByTimeout = value; }
//		}

//		public System.Int16 ForceAMFormat
//		{
//			get{ return this._forceAMFormat; }
//			set{ this._forceAMFormat = value; }
//		}

//		public System.Int16 PropAMFFormat
//		{
//			get{ return this._propAMFFormat; }
//			set{ this._propAMFFormat = value; }
//		}

//		public System.Int16 Debounce
//		{
//			get{ return this._debounce; }
//			set{ this._debounce = value; }
//		}

//		public System.Int16 AllowOpenTime
//		{
//			get{ return this._allowOpenTime; }
//			set{ this._allowOpenTime = value; }
//		}

//		public System.Boolean NoPreAlarm
//		{
//			get{ return this._noPreAlarm; }
//			set{ this._noPreAlarm = value; }
//		}

//		public System.String PostPreAlarm
//		{
//			get{ return this._postPreAlarm; }
//			set{ this._postPreAlarm = value; }
//		}

//		public System.Int16 PostDuration
//		{
//			get{ return this._postDuration; }
//			set{ this._postDuration = value; }
//		}

//		public System.String Notes
//		{
//			get{ return this._notes; }
//			set{ this._notes = value; }
//		}

//		public System.String EventNotifyEmail
//		{
//			get{ return this._eventNotifyEmail; }
//			set{ this._eventNotifyEmail = value; }
//		}

//		public System.Boolean IsPulsed
//		{
//			get{ return this._isPulsed; }
//			set{ this._isPulsed = value; }
//		}

//		public System.Boolean AlwaysToMAS
//		{
//			get{ return this._alwaysToMAS; }
//			set{ this._alwaysToMAS = value; }
//		}

//		public System.Boolean CommentBeforePulse
//		{
//			get{ return this._commentBeforePulse; }
//			set{ this._commentBeforePulse = value; }
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

//		public System.Boolean Degrade
//		{
//			get{ return this._degrade; }
//			set{ this._degrade = value; }
//		}

//		public System.String ReaderPassMode
//		{
//			get{ return this._readerPassMode; }
//			set{ this._readerPassMode = value; }
//		}

//		public System.Byte PanelZoneID
//		{
//			get{ return this._panelZoneID; }
//			set{ this._panelZoneID = value; }
//		}

//		public System.Int32 LockTypeID
//		{
//			get{ return this._lockTypeID; }
//			set{ this._lockTypeID = value; }
//		}

//		public System.Boolean Locked
//		{
//			get{ return this._locked; }
//			set{ this._locked = value; }
//		}

//		public System.Byte InputGroup
//		{
//			get{ return this._inputGroup; }
//			set{ this._inputGroup = value; }
//		}

//		public System.Int16 UnlockTempTC
//		{
//			get{ return this._unlockTempTC; }
//			set{ this._unlockTempTC = value; }
//		}

//		public System.DateTime UnlockTempBegin
//		{
//			get{ return this._unlockTempBegin.ToLocalTime(); }
//			set{ this._unlockTempBegin = value.ToUniversalTime(); }
//		}

//		public System.DateTime UnlockTempEnd
//		{
//			get{ return this._unlockTempEnd.ToLocalTime(); }
//			set{ this._unlockTempEnd = value.ToUniversalTime(); }
//		}

		public System.Guid BDBuildingPK
		{
			get{ return this._bDBuildingPK; }
			set{ this._bDBuildingPK = value; }
		}

		public System.Int32 UnitID
		{
			get{ return this._unitID; }
			set{ this._unitID = value; }
		}

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

		public ACMainZoneView()
		{
		}

		public ACMainZoneView(ACMainZoneData data)
		{
			this.ACMainZonePK = data.ACMainZonePK;
			this.ACPanelPK = data.ACPanelPK;
			this.MainZoneID = data.MainZoneID;
			this.MainZoneTypeID = data.MainZoneTypeID;
			this.Description = data.Description;
			//this.ReaderName = data.ReaderName;
			//this.ReaderTypeID = data.ReaderTypeID;
			//this.ReverseColor = data.ReverseColor;
			//this.OutputGroup = data.OutputGroup;
			//this.NeedPin = data.NeedPin;
			//this.AntiPassback = data.AntiPassback;
			//this.SoftAntiPassback = data.SoftAntiPassback;
			//this.UnlockTimecode = data.UnlockTimecode;
			//this.UnlockOn1stRead = data.UnlockOn1stRead;
			//this.RexShuntOnly = data.RexShuntOnly;
			//this.PulseTime = data.PulseTime;
			//this.RelockByTimeout = data.RelockByTimeout;
			//this.ForceAMFormat = data.ForceAMFormat;
			//this.PropAMFFormat = data.PropAMFFormat;
			//this.Debounce = data.Debounce;
			//this.AllowOpenTime = data.AllowOpenTime;
			//this.NoPreAlarm = data.NoPreAlarm;
			//this.PostPreAlarm = data.PostPreAlarm;
			//this.PostDuration = data.PostDuration;
			//this.Notes = data.Notes;
			//this.EventNotifyEmail = data.EventNotifyEmail;
			//this.IsPulsed = data.IsPulsed;
			//this.AlwaysToMAS = data.AlwaysToMAS;
			//this.CommentBeforePulse = data.CommentBeforePulse;
			//this.CreatedOn = data.CreatedOn;
			//this.CreatedBy = data.CreatedBy;
			//this.ModifiedOn = data.ModifiedOn;
			//this.ModifiedBy = data.ModifiedBy;
			//this.Degrade = data.Degrade;
			//this.ReaderPassMode = data.ReaderPassMode;
			//this.PanelZoneID = data.PanelZoneID;
			//this.LockTypeID = data.LockTypeID;
			//this.Locked = data.Locked;
			//this.InputGroup = data.InputGroup;
			//this.UnlockTempTC = data.UnlockTempTC;
			//this.UnlockTempBegin = data.UnlockTempBegin;
			//this.UnlockTempEnd = data.UnlockTempEnd;
			this.BDBuildingPK = data.BDBuildingPK;
			this.UnitID = data.UnitID;
			this.Address1 = data.Address1;
			this.BuildingID = data.BuildingID;
		}


		public ACMainZoneData ToACMainZoneData()
		{
			ACMainZoneData entity = new ACMainZoneData();
			entity.ACMainZonePK = this.ACMainZonePK;
			entity.ACPanelPK = this.ACPanelPK;
			entity.MainZoneID = this.MainZoneID;
			entity.MainZoneTypeID = this.MainZoneTypeID;
			entity.Description = this.Description;
			//entity.ReaderName = this.ReaderName;
			//entity.ReaderTypeID = this.ReaderTypeID;
			//entity.ReverseColor = this.ReverseColor;
			//entity.OutputGroup = this.OutputGroup;
			//entity.NeedPin = this.NeedPin;
			//entity.AntiPassback = this.AntiPassback;
			//entity.SoftAntiPassback = this.SoftAntiPassback;
			//entity.UnlockTimecode = this.UnlockTimecode;
			//entity.UnlockOn1stRead = this.UnlockOn1stRead;
			//entity.RexShuntOnly = this.RexShuntOnly;
			//entity.PulseTime = this.PulseTime;
			//entity.RelockByTimeout = this.RelockByTimeout;
			//entity.ForceAMFormat = this.ForceAMFormat;
			//entity.PropAMFFormat = this.PropAMFFormat;
			//entity.Debounce = this.Debounce;
			//entity.AllowOpenTime = this.AllowOpenTime;
			//entity.NoPreAlarm = this.NoPreAlarm;
			//entity.PostPreAlarm = this.PostPreAlarm;
			//entity.PostDuration = this.PostDuration;
			//entity.Notes = this.Notes;
			//entity.EventNotifyEmail = this.EventNotifyEmail;
			//entity.IsPulsed = this.IsPulsed;
			//entity.AlwaysToMAS = this.AlwaysToMAS;
			//entity.CommentBeforePulse = this.CommentBeforePulse;
			//entity.CreatedOn = this.CreatedOn;
			//entity.CreatedBy = this.CreatedBy;
			//entity.ModifiedOn = this.ModifiedOn;
			//entity.ModifiedBy = this.ModifiedBy;
			//entity.Degrade = this.Degrade;
			//entity.ReaderPassMode = this.ReaderPassMode;
			//entity.PanelZoneID = this.PanelZoneID;
			//entity.LockTypeID = this.LockTypeID;
			//entity.Locked = this.Locked;
			//entity.InputGroup = this.InputGroup;
			//entity.UnlockTempTC = this.UnlockTempTC;
			//entity.UnlockTempBegin = this.UnlockTempBegin;
			//entity.UnlockTempEnd = this.UnlockTempEnd;
			entity.BDBuildingPK = this.BDBuildingPK;
			entity.UnitID = this.UnitID;
			entity.Address1 = this.Address1;
			entity.BuildingID = this.BuildingID;

			return entity;
		}
	}
}
