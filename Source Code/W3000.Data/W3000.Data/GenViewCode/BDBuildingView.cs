using System;

namespace W3000.Data
{
	[Serializable]
	public partial class BDBuildingView
	{
		private System.Guid _bDBuildingPK = Guid.Empty;
		private System.Int32 _buildingID = 0;
		//private System.String _buildingName = string.Empty;
		private System.String _address1 = string.Empty;
		//private System.String _streetNumb = string.Empty;
		//private System.String _streetName = string.Empty;
		//private System.String _address2 = string.Empty;
		private System.String _city = string.Empty;
		private System.String _state = string.Empty;
		private System.String _zipcode = string.Empty;
		//private System.String _county = string.Empty;
		//private System.Int32 _timezoneID = 0;
		//private System.Boolean _federal = false;
		//private System.String _phone = string.Empty;
		//private System.String _fax = string.Empty;
		//private System.String _bldgNotes = string.Empty;
		//private System.String _cardNotes = string.Empty;
		//private System.String _elevTrapNotes = string.Empty;
		//private System.String _visitorNotes = string.Empty;
		//private System.Int32 _systemTypeID = 0;
		private System.Int32 _countryID = 0;
		//private System.DateTime _createdOn = new DateTime(1900, 1, 1);
		//private System.String _createdBy = string.Empty;
		//private System.DateTime _modifiedOn = new DateTime(1900, 1, 1);
		//private System.String _modifiedBy = string.Empty;
		//private System.Int32 _visitorSiteCode = 0;
		//private System.Int32 _winUITypeID = 0;
		//private System.DateTime _lastExportParkingTag = new DateTime(1900, 1, 1);
		//private System.String _autoIssueNotifyEmail = string.Empty;
		//private System.Byte _cardKeyMode = 0;
		//private System.String _accessLevelMode = string.Empty;
		//private System.Boolean _hotClient = false;
		//private System.DateTime _hotExpire = new DateTime(1900, 1, 1);

		public System.Guid BDBuildingPK
		{
			get{ return this._bDBuildingPK; }
			set{ this._bDBuildingPK = value; }
		}

		public System.Int32 BuildingID
		{
			get{ return this._buildingID; }
			set{ this._buildingID = value; }
		}

//		public System.String BuildingName
//		{
//			get{ return this._buildingName; }
//			set{ this._buildingName = value; }
//		}

		public System.String Address1
		{
			get{ return this._address1; }
			set{ this._address1 = value; }
		}

//		public System.String StreetNumb
//		{
//			get{ return this._streetNumb; }
//			set{ this._streetNumb = value; }
//		}

//		public System.String StreetName
//		{
//			get{ return this._streetName; }
//			set{ this._streetName = value; }
//		}

//		public System.String Address2
//		{
//			get{ return this._address2; }
//			set{ this._address2 = value; }
//		}

		public System.String City
		{
			get{ return this._city; }
			set{ this._city = value; }
		}

		public System.String State
		{
			get{ return this._state; }
			set{ this._state = value; }
		}

		public System.String Zipcode
		{
			get{ return this._zipcode; }
			set{ this._zipcode = value; }
		}

//		public System.String County
//		{
//			get{ return this._county; }
//			set{ this._county = value; }
//		}

//		public System.Int32 TimezoneID
//		{
//			get{ return this._timezoneID; }
//			set{ this._timezoneID = value; }
//		}

//		public System.Boolean Federal
//		{
//			get{ return this._federal; }
//			set{ this._federal = value; }
//		}

//		public System.String Phone
//		{
//			get{ return this._phone; }
//			set{ this._phone = value; }
//		}

//		public System.String Fax
//		{
//			get{ return this._fax; }
//			set{ this._fax = value; }
//		}

//		public System.String BldgNotes
//		{
//			get{ return this._bldgNotes; }
//			set{ this._bldgNotes = value; }
//		}

//		public System.String CardNotes
//		{
//			get{ return this._cardNotes; }
//			set{ this._cardNotes = value; }
//		}

//		public System.String ElevTrapNotes
//		{
//			get{ return this._elevTrapNotes; }
//			set{ this._elevTrapNotes = value; }
//		}

//		public System.String VisitorNotes
//		{
//			get{ return this._visitorNotes; }
//			set{ this._visitorNotes = value; }
//		}

//		public System.Int32 SystemTypeID
//		{
//			get{ return this._systemTypeID; }
//			set{ this._systemTypeID = value; }
//		}

		public System.Int32 CountryID
		{
			get{ return this._countryID; }
			set{ this._countryID = value; }
		}

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

//		public System.Int32 VisitorSiteCode
//		{
//			get{ return this._visitorSiteCode; }
//			set{ this._visitorSiteCode = value; }
//		}

//		public System.Int32 WinUITypeID
//		{
//			get{ return this._winUITypeID; }
//			set{ this._winUITypeID = value; }
//		}

//		public System.DateTime LastExportParkingTag
//		{
//			get{ return this._lastExportParkingTag.ToLocalTime(); }
//			set{ this._lastExportParkingTag = value.ToUniversalTime(); }
//		}

//		public System.String AutoIssueNotifyEmail
//		{
//			get{ return this._autoIssueNotifyEmail; }
//			set{ this._autoIssueNotifyEmail = value; }
//		}

//		public System.Byte CardKeyMode
//		{
//			get{ return this._cardKeyMode; }
//			set{ this._cardKeyMode = value; }
//		}

//		public System.String AccessLevelMode
//		{
//			get{ return this._accessLevelMode; }
//			set{ this._accessLevelMode = value; }
//		}

//		public System.Boolean HotClient
//		{
//			get{ return this._hotClient; }
//			set{ this._hotClient = value; }
//		}

//		public System.DateTime HotExpire
//		{
//			get{ return this._hotExpire.ToLocalTime(); }
//			set{ this._hotExpire = value.ToUniversalTime(); }
//		}

		public BDBuildingView()
		{
		}

		public BDBuildingView(BDBuildingData data)
		{
			this.BDBuildingPK = data.BDBuildingPK;
			this.BuildingID = data.BuildingID;
			//this.BuildingName = data.BuildingName;
			this.Address1 = data.Address1;
			//this.StreetNumb = data.StreetNumb;
			//this.StreetName = data.StreetName;
			//this.Address2 = data.Address2;
			this.City = data.City;
			this.State = data.State;
			this.Zipcode = data.Zipcode;
			//this.County = data.County;
			//this.TimezoneID = data.TimezoneID;
			//this.Federal = data.Federal;
			//this.Phone = data.Phone;
			//this.Fax = data.Fax;
			//this.BldgNotes = data.BldgNotes;
			//this.CardNotes = data.CardNotes;
			//this.ElevTrapNotes = data.ElevTrapNotes;
			//this.VisitorNotes = data.VisitorNotes;
			//this.SystemTypeID = data.SystemTypeID;
			this.CountryID = data.CountryID;
			//this.CreatedOn = data.CreatedOn;
			//this.CreatedBy = data.CreatedBy;
			//this.ModifiedOn = data.ModifiedOn;
			//this.ModifiedBy = data.ModifiedBy;
			//this.VisitorSiteCode = data.VisitorSiteCode;
			//this.WinUITypeID = data.WinUITypeID;
			//this.LastExportParkingTag = data.LastExportParkingTag;
			//this.AutoIssueNotifyEmail = data.AutoIssueNotifyEmail;
			//this.CardKeyMode = data.CardKeyMode;
			//this.AccessLevelMode = data.AccessLevelMode;
			//this.HotClient = data.HotClient;
			//this.HotExpire = data.HotExpire;
		}


		public BDBuildingData ToBDBuildingData()
		{
			BDBuildingData entity = new BDBuildingData();
			entity.BDBuildingPK = this.BDBuildingPK;
			entity.BuildingID = this.BuildingID;
			//entity.BuildingName = this.BuildingName;
			entity.Address1 = this.Address1;
			//entity.StreetNumb = this.StreetNumb;
			//entity.StreetName = this.StreetName;
			//entity.Address2 = this.Address2;
			entity.City = this.City;
			entity.State = this.State;
			entity.Zipcode = this.Zipcode;
			//entity.County = this.County;
			//entity.TimezoneID = this.TimezoneID;
			//entity.Federal = this.Federal;
			//entity.Phone = this.Phone;
			//entity.Fax = this.Fax;
			//entity.BldgNotes = this.BldgNotes;
			//entity.CardNotes = this.CardNotes;
			//entity.ElevTrapNotes = this.ElevTrapNotes;
			//entity.VisitorNotes = this.VisitorNotes;
			//entity.SystemTypeID = this.SystemTypeID;
			entity.CountryID = this.CountryID;
			//entity.CreatedOn = this.CreatedOn;
			//entity.CreatedBy = this.CreatedBy;
			//entity.ModifiedOn = this.ModifiedOn;
			//entity.ModifiedBy = this.ModifiedBy;
			//entity.VisitorSiteCode = this.VisitorSiteCode;
			//entity.WinUITypeID = this.WinUITypeID;
			//entity.LastExportParkingTag = this.LastExportParkingTag;
			//entity.AutoIssueNotifyEmail = this.AutoIssueNotifyEmail;
			//entity.CardKeyMode = this.CardKeyMode;
			//entity.AccessLevelMode = this.AccessLevelMode;
			//entity.HotClient = this.HotClient;
			//entity.HotExpire = this.HotExpire;

			return entity;
		}
	}
}
