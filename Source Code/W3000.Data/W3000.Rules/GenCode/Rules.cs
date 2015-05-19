using System;
using System.Text;

namespace W3000.Rules
{
	[Serializable]
	public class ACIntvalHolidayMapRuleData
	{
		private System.Guid _aCIntvalHolidayMapPK;
		private System.Guid _aCIntervalPK;
		private System.Guid _utilHolidayPK;
		private System.DateTime _createdOn;
		private System.String _createdBy;
		private System.DateTime _modifiedOn;
		private System.String _modifiedBy;
		private System.String _end;
		private System.String _begin;
		private System.Int16 _iVID;
		private System.Guid _bDBuildingPK;
		private System.DateTime _date;
		private System.String _holiday;
		private System.String _address1;
		private System.Int32 _buildingID;

		public System.Guid ACIntvalHolidayMapPK
		{
			get { return this._aCIntvalHolidayMapPK; }
			set { this._aCIntvalHolidayMapPK = value; }
		}

		public System.Guid ACIntervalPK
		{
			get { return this._aCIntervalPK; }
			set { this._aCIntervalPK = value; }
		}

		public System.Guid UtilHolidayPK
		{
			get { return this._utilHolidayPK; }
			set { this._utilHolidayPK = value; }
		}

		public System.DateTime CreatedOn
		{
			get { return this._createdOn; }
			set { this._createdOn = value; }
		}

		public System.String CreatedBy
		{
			get { return this._createdBy; }
			set { this._createdBy = value; }
		}

		public System.DateTime ModifiedOn
		{
			get { return this._modifiedOn; }
			set { this._modifiedOn = value; }
		}

		public System.String ModifiedBy
		{
			get { return this._modifiedBy; }
			set { this._modifiedBy = value; }
		}

		public System.String End
		{
			get { return this._end; }
			set { this._end = value; }
		}

		public System.String Begin
		{
			get { return this._begin; }
			set { this._begin = value; }
		}

		public System.Int16 IVID
		{
			get { return this._iVID; }
			set { this._iVID = value; }
		}

		public System.Guid BDBuildingPK
		{
			get { return this._bDBuildingPK; }
			set { this._bDBuildingPK = value; }
		}

		public System.DateTime Date
		{
			get { return this._date; }
			set { this._date = value; }
		}

		public System.String Holiday
		{
			get { return this._holiday; }
			set { this._holiday = value; }
		}

		public System.String Address1
		{
			get { return this._address1; }
			set { this._address1 = value; }
		}

		public System.Int32 BuildingID
		{
			get { return this._buildingID; }
			set { this._buildingID = value; }
		}

	}
	[Serializable]
	public class ACAccessLevelDetailRuleData
	{
		private System.Guid _aCAccessLevelDetailPK;
		private System.Guid _aCAccessLevelPK;
		private System.Guid _aCMainZonePK;
		private System.Guid _aCTimecodePK;
		private System.Guid _fromACAccessLevelPK;
		private System.DateTime _createdOn;
		private System.String _createdBy;
		private System.DateTime _modifiedOn;
		private System.String _modifiedBy;
		private System.String _mainZoneDescription;
		private System.Byte _mainZoneID;
		private System.Guid _aCPanelPK;
		private System.String _timecodeSummary;
		private System.Int16 _tCID;
		private System.String _aLSummary;
		private System.Int16 _accessLevelID;
		private System.Guid _bDBuildingPK;
		private System.Int32 _unitID;
		private System.String _address1;
		private System.Int32 _buildingID;

		public System.Guid ACAccessLevelDetailPK
		{
			get { return this._aCAccessLevelDetailPK; }
			set { this._aCAccessLevelDetailPK = value; }
		}

		public System.Guid ACAccessLevelPK
		{
			get { return this._aCAccessLevelPK; }
			set { this._aCAccessLevelPK = value; }
		}

		public System.Guid ACMainZonePK
		{
			get { return this._aCMainZonePK; }
			set { this._aCMainZonePK = value; }
		}

		public System.Guid ACTimecodePK
		{
			get { return this._aCTimecodePK; }
			set { this._aCTimecodePK = value; }
		}

		public System.Guid FromACAccessLevelPK
		{
			get { return this._fromACAccessLevelPK; }
			set { this._fromACAccessLevelPK = value; }
		}

		public System.DateTime CreatedOn
		{
			get { return this._createdOn; }
			set { this._createdOn = value; }
		}

		public System.String CreatedBy
		{
			get { return this._createdBy; }
			set { this._createdBy = value; }
		}

		public System.DateTime ModifiedOn
		{
			get { return this._modifiedOn; }
			set { this._modifiedOn = value; }
		}

		public System.String ModifiedBy
		{
			get { return this._modifiedBy; }
			set { this._modifiedBy = value; }
		}

		public System.String MainZoneDescription
		{
			get { return this._mainZoneDescription; }
			set { this._mainZoneDescription = value; }
		}

		public System.Byte MainZoneID
		{
			get { return this._mainZoneID; }
			set { this._mainZoneID = value; }
		}

		public System.Guid ACPanelPK
		{
			get { return this._aCPanelPK; }
			set { this._aCPanelPK = value; }
		}

		public System.String TimecodeSummary
		{
			get { return this._timecodeSummary; }
			set { this._timecodeSummary = value; }
		}

		public System.Int16 TCID
		{
			get { return this._tCID; }
			set { this._tCID = value; }
		}

		public System.String ALSummary
		{
			get { return this._aLSummary; }
			set { this._aLSummary = value; }
		}

		public System.Int16 AccessLevelID
		{
			get { return this._accessLevelID; }
			set { this._accessLevelID = value; }
		}

		public System.Guid BDBuildingPK
		{
			get { return this._bDBuildingPK; }
			set { this._bDBuildingPK = value; }
		}

		public System.Int32 UnitID
		{
			get { return this._unitID; }
			set { this._unitID = value; }
		}

		public System.String Address1
		{
			get { return this._address1; }
			set { this._address1 = value; }
		}

		public System.Int32 BuildingID
		{
			get { return this._buildingID; }
			set { this._buildingID = value; }
		}

	}
	[Serializable]
	public class UsrAccountBuildingMapRuleData
	{
		private System.Guid _usrAccountBuildingMapPK;
		private System.Guid _usrAccountPK;
		private System.Guid _bDBuildingPK;
		private System.Boolean _buildingWide;
		private System.DateTime _createdOn;
		private System.String _createdBy;
		private System.DateTime _modifiedOn;
		private System.String _modifiedBy;
		private System.Int16 _accessTC;
		private System.Int32 _permission;
		private System.Boolean _primary;
		private System.String _address1;
		private System.Int32 _buildingID;
		private System.String _userID;

		public System.Guid UsrAccountBuildingMapPK
		{
			get { return this._usrAccountBuildingMapPK; }
			set { this._usrAccountBuildingMapPK = value; }
		}

		public System.Guid UsrAccountPK
		{
			get { return this._usrAccountPK; }
			set { this._usrAccountPK = value; }
		}

		public System.Guid BDBuildingPK
		{
			get { return this._bDBuildingPK; }
			set { this._bDBuildingPK = value; }
		}

		public System.Boolean BuildingWide
		{
			get { return this._buildingWide; }
			set { this._buildingWide = value; }
		}

		public System.DateTime CreatedOn
		{
			get { return this._createdOn; }
			set { this._createdOn = value; }
		}

		public System.String CreatedBy
		{
			get { return this._createdBy; }
			set { this._createdBy = value; }
		}

		public System.DateTime ModifiedOn
		{
			get { return this._modifiedOn; }
			set { this._modifiedOn = value; }
		}

		public System.String ModifiedBy
		{
			get { return this._modifiedBy; }
			set { this._modifiedBy = value; }
		}

		public System.Int16 AccessTC
		{
			get { return this._accessTC; }
			set { this._accessTC = value; }
		}

		public System.Int32 Permission
		{
			get { return this._permission; }
			set { this._permission = value; }
		}

		public System.Boolean Primary
		{
			get { return this._primary; }
			set { this._primary = value; }
		}

		public System.String Address1
		{
			get { return this._address1; }
			set { this._address1 = value; }
		}

		public System.Int32 BuildingID
		{
			get { return this._buildingID; }
			set { this._buildingID = value; }
		}

		public System.String UserID
		{
			get { return this._userID; }
			set { this._userID = value; }
		}

	}
	[Serializable]
	public class BDBuildingRuleData
	{
		private System.Guid _bDBuildingPK;
		private System.Int32 _buildingID;
		private System.String _buildingName;
		private System.String _address1;
		private System.String _streetNumb;
		private System.String _streetName;
		private System.String _address2;
		private System.String _city;
		private System.String _state;
		private System.String _zipcode;
		private System.String _county;
		private System.Int32 _timezoneID;
		private System.Boolean _federal;
		private System.String _phone;
		private System.String _fax;
		private System.String _bldgNotes;
		private System.String _cardNotes;
		private System.String _elevTrapNotes;
		private System.String _visitorNotes;
		private System.Int32 _systemTypeID;
		private System.Int32 _countryID;
		private System.DateTime _createdOn;
		private System.String _createdBy;
		private System.DateTime _modifiedOn;
		private System.String _modifiedBy;
		private System.Int32 _visitorSiteCode;
		private System.Int32 _winUITypeID;
		private System.DateTime _lastExportParkingTag;
		private System.String _autoIssueNotifyEmail;
		private System.Byte _cardKeyMode;
		private System.String _accessLevelMode;
		private System.Boolean _hotClient;
		private System.DateTime _hotExpire;

		public System.Guid BDBuildingPK
		{
			get { return this._bDBuildingPK; }
			set { this._bDBuildingPK = value; }
		}

		public System.Int32 BuildingID
		{
			get { return this._buildingID; }
			set { this._buildingID = value; }
		}

		public System.String BuildingName
		{
			get { return this._buildingName; }
			set { this._buildingName = value; }
		}

		public System.String Address1
		{
			get { return this._address1; }
			set { this._address1 = value; }
		}

		public System.String StreetNumb
		{
			get { return this._streetNumb; }
			set { this._streetNumb = value; }
		}

		public System.String StreetName
		{
			get { return this._streetName; }
			set { this._streetName = value; }
		}

		public System.String Address2
		{
			get { return this._address2; }
			set { this._address2 = value; }
		}

		public System.String City
		{
			get { return this._city; }
			set { this._city = value; }
		}

		public System.String State
		{
			get { return this._state; }
			set { this._state = value; }
		}

		public System.String Zipcode
		{
			get { return this._zipcode; }
			set { this._zipcode = value; }
		}

		public System.String County
		{
			get { return this._county; }
			set { this._county = value; }
		}

		public System.Int32 TimezoneID
		{
			get { return this._timezoneID; }
			set { this._timezoneID = value; }
		}

		public System.Boolean Federal
		{
			get { return this._federal; }
			set { this._federal = value; }
		}

		public System.String Phone
		{
			get { return this._phone; }
			set { this._phone = value; }
		}

		public System.String Fax
		{
			get { return this._fax; }
			set { this._fax = value; }
		}

		public System.String BldgNotes
		{
			get { return this._bldgNotes; }
			set { this._bldgNotes = value; }
		}

		public System.String CardNotes
		{
			get { return this._cardNotes; }
			set { this._cardNotes = value; }
		}

		public System.String ElevTrapNotes
		{
			get { return this._elevTrapNotes; }
			set { this._elevTrapNotes = value; }
		}

		public System.String VisitorNotes
		{
			get { return this._visitorNotes; }
			set { this._visitorNotes = value; }
		}

		public System.Int32 SystemTypeID
		{
			get { return this._systemTypeID; }
			set { this._systemTypeID = value; }
		}

		public System.Int32 CountryID
		{
			get { return this._countryID; }
			set { this._countryID = value; }
		}

		public System.DateTime CreatedOn
		{
			get { return this._createdOn; }
			set { this._createdOn = value; }
		}

		public System.String CreatedBy
		{
			get { return this._createdBy; }
			set { this._createdBy = value; }
		}

		public System.DateTime ModifiedOn
		{
			get { return this._modifiedOn; }
			set { this._modifiedOn = value; }
		}

		public System.String ModifiedBy
		{
			get { return this._modifiedBy; }
			set { this._modifiedBy = value; }
		}

		public System.Int32 VisitorSiteCode
		{
			get { return this._visitorSiteCode; }
			set { this._visitorSiteCode = value; }
		}

		public System.Int32 WinUITypeID
		{
			get { return this._winUITypeID; }
			set { this._winUITypeID = value; }
		}

		public System.DateTime LastExportParkingTag
		{
			get { return this._lastExportParkingTag; }
			set { this._lastExportParkingTag = value; }
		}

		public System.String AutoIssueNotifyEmail
		{
			get { return this._autoIssueNotifyEmail; }
			set { this._autoIssueNotifyEmail = value; }
		}

		public System.Byte CardKeyMode
		{
			get { return this._cardKeyMode; }
			set { this._cardKeyMode = value; }
		}

		public System.String AccessLevelMode
		{
			get { return this._accessLevelMode; }
			set { this._accessLevelMode = value; }
		}

		public System.Boolean HotClient
		{
			get { return this._hotClient; }
			set { this._hotClient = value; }
		}

		public System.DateTime HotExpire
		{
			get { return this._hotExpire; }
			set { this._hotExpire = value; }
		}

	}
	[Serializable]
	public class BDTenantRuleData
	{
		private System.Guid _bDTenantPK;
		private System.Guid _bDBuildingPK;
		private System.String _tenant;
		private System.String _suite;
		private System.String _phone;
		private System.String _fax;
		private System.Boolean _blocked;
		private System.Boolean _federal;
		private System.String _tentNotes;
		private System.String _cardNotes;
		private System.String _visitorNotes;
		private System.Boolean _isManagement;
		private System.String _type;
		private System.Boolean _noRecycleCard;
		private System.Int32 _systemTypeID;
		private System.DateTime _createdOn;
		private System.String _createdBy;
		private System.DateTime _modifiedOn;
		private System.String _modifiedBy;
		private System.String _parkingAccount;
		private System.String _custInfo1;
		private System.String _custInfo2;
		private System.String _custInfo3;
		private System.String _custInfo4;
		private System.String _custInfo5;
		private System.String _custInfo6;
		private System.String _custInfo7;
		private System.String _custInfo8;
		private System.Boolean _delExpiredCard;
		private System.Boolean _hotClient;
		private System.DateTime _hotExpire;
		private System.String _email;
		private System.String _address1;
		private System.Int32 _buildingID;

		public System.Guid BDTenantPK
		{
			get { return this._bDTenantPK; }
			set { this._bDTenantPK = value; }
		}

		public System.Guid BDBuildingPK
		{
			get { return this._bDBuildingPK; }
			set { this._bDBuildingPK = value; }
		}

		public System.String Tenant
		{
			get { return this._tenant; }
			set { this._tenant = value; }
		}

		public System.String Suite
		{
			get { return this._suite; }
			set { this._suite = value; }
		}

		public System.String Phone
		{
			get { return this._phone; }
			set { this._phone = value; }
		}

		public System.String Fax
		{
			get { return this._fax; }
			set { this._fax = value; }
		}

		public System.Boolean Blocked
		{
			get { return this._blocked; }
			set { this._blocked = value; }
		}

		public System.Boolean Federal
		{
			get { return this._federal; }
			set { this._federal = value; }
		}

		public System.String TentNotes
		{
			get { return this._tentNotes; }
			set { this._tentNotes = value; }
		}

		public System.String CardNotes
		{
			get { return this._cardNotes; }
			set { this._cardNotes = value; }
		}

		public System.String VisitorNotes
		{
			get { return this._visitorNotes; }
			set { this._visitorNotes = value; }
		}

		public System.Boolean IsManagement
		{
			get { return this._isManagement; }
			set { this._isManagement = value; }
		}

		public System.String Type
		{
			get { return this._type; }
			set { this._type = value; }
		}

		public System.Boolean NoRecycleCard
		{
			get { return this._noRecycleCard; }
			set { this._noRecycleCard = value; }
		}

		public System.Int32 SystemTypeID
		{
			get { return this._systemTypeID; }
			set { this._systemTypeID = value; }
		}

		public System.DateTime CreatedOn
		{
			get { return this._createdOn; }
			set { this._createdOn = value; }
		}

		public System.String CreatedBy
		{
			get { return this._createdBy; }
			set { this._createdBy = value; }
		}

		public System.DateTime ModifiedOn
		{
			get { return this._modifiedOn; }
			set { this._modifiedOn = value; }
		}

		public System.String ModifiedBy
		{
			get { return this._modifiedBy; }
			set { this._modifiedBy = value; }
		}

		public System.String ParkingAccount
		{
			get { return this._parkingAccount; }
			set { this._parkingAccount = value; }
		}

		public System.String CustInfo1
		{
			get { return this._custInfo1; }
			set { this._custInfo1 = value; }
		}

		public System.String CustInfo2
		{
			get { return this._custInfo2; }
			set { this._custInfo2 = value; }
		}

		public System.String CustInfo3
		{
			get { return this._custInfo3; }
			set { this._custInfo3 = value; }
		}

		public System.String CustInfo4
		{
			get { return this._custInfo4; }
			set { this._custInfo4 = value; }
		}

		public System.String CustInfo5
		{
			get { return this._custInfo5; }
			set { this._custInfo5 = value; }
		}

		public System.String CustInfo6
		{
			get { return this._custInfo6; }
			set { this._custInfo6 = value; }
		}

		public System.String CustInfo7
		{
			get { return this._custInfo7; }
			set { this._custInfo7 = value; }
		}

		public System.String CustInfo8
		{
			get { return this._custInfo8; }
			set { this._custInfo8 = value; }
		}

		public System.Boolean DelExpiredCard
		{
			get { return this._delExpiredCard; }
			set { this._delExpiredCard = value; }
		}

		public System.Boolean HotClient
		{
			get { return this._hotClient; }
			set { this._hotClient = value; }
		}

		public System.DateTime HotExpire
		{
			get { return this._hotExpire; }
			set { this._hotExpire = value; }
		}

		public System.String Email
		{
			get { return this._email; }
			set { this._email = value; }
		}

		public System.String Address1
		{
			get { return this._address1; }
			set { this._address1 = value; }
		}

		public System.Int32 BuildingID
		{
			get { return this._buildingID; }
			set { this._buildingID = value; }
		}

	}
	[Serializable]
	public class UtilSettingCategoryRuleData
	{
		private System.Guid _utilSettingCategoryPK;
		private System.Int32 _settingCategoryID;
		private System.String _settingCategory;
		private System.String _instanceName;
		private System.DateTime _createdOn;
		private System.String _createdBy;
		private System.DateTime _modifiedOn;
		private System.String _modifiedBy;
		private System.Guid _bDBuildingPK;

		public System.Guid UtilSettingCategoryPK
		{
			get { return this._utilSettingCategoryPK; }
			set { this._utilSettingCategoryPK = value; }
		}

		public System.Int32 SettingCategoryID
		{
			get { return this._settingCategoryID; }
			set { this._settingCategoryID = value; }
		}

		public System.String SettingCategory
		{
			get { return this._settingCategory; }
			set { this._settingCategory = value; }
		}

		public System.String InstanceName
		{
			get { return this._instanceName; }
			set { this._instanceName = value; }
		}

		public System.DateTime CreatedOn
		{
			get { return this._createdOn; }
			set { this._createdOn = value; }
		}

		public System.String CreatedBy
		{
			get { return this._createdBy; }
			set { this._createdBy = value; }
		}

		public System.DateTime ModifiedOn
		{
			get { return this._modifiedOn; }
			set { this._modifiedOn = value; }
		}

		public System.String ModifiedBy
		{
			get { return this._modifiedBy; }
			set { this._modifiedBy = value; }
		}

		public System.Guid BDBuildingPK
		{
			get { return this._bDBuildingPK; }
			set { this._bDBuildingPK = value; }
		}

	}
	[Serializable]
	public class UtilSettingDetailRuleData
	{
		private System.Guid _utilSettingDetailPK;
		private System.Guid _utilSettingCategoryPK;
		private System.String _fieldName;
		private System.String _fieldValue;
		private System.DateTime _createdOn;
		private System.String _createdBy;
		private System.DateTime _modifiedOn;
		private System.String _modifiedBy;
		private System.String _settingCategory;
		private System.Int32 _settingCategoryID;

		public System.Guid UtilSettingDetailPK
		{
			get { return this._utilSettingDetailPK; }
			set { this._utilSettingDetailPK = value; }
		}

		public System.Guid UtilSettingCategoryPK
		{
			get { return this._utilSettingCategoryPK; }
			set { this._utilSettingCategoryPK = value; }
		}

		public System.String FieldName
		{
			get { return this._fieldName; }
			set { this._fieldName = value; }
		}

		public System.String FieldValue
		{
			get { return this._fieldValue; }
			set { this._fieldValue = value; }
		}

		public System.DateTime CreatedOn
		{
			get { return this._createdOn; }
			set { this._createdOn = value; }
		}

		public System.String CreatedBy
		{
			get { return this._createdBy; }
			set { this._createdBy = value; }
		}

		public System.DateTime ModifiedOn
		{
			get { return this._modifiedOn; }
			set { this._modifiedOn = value; }
		}

		public System.String ModifiedBy
		{
			get { return this._modifiedBy; }
			set { this._modifiedBy = value; }
		}

		public System.String SettingCategory
		{
			get { return this._settingCategory; }
			set { this._settingCategory = value; }
		}

		public System.Int32 SettingCategoryID
		{
			get { return this._settingCategoryID; }
			set { this._settingCategoryID = value; }
		}

	}
	[Serializable]
	public class ACOutputGroupMainZoneMapRuleData
	{
		private System.Guid _aCOutputGroupMainZoneMapPK;
		private System.Guid _aCOutputGroupPK;
		private System.Guid _aCMainZonePK;
		private System.DateTime _createdOn;
		private System.String _createdBy;
		private System.DateTime _modifiedOn;
		private System.String _modifiedBy;
		private System.Byte _mainZoneID;
		private System.Guid _aCPanelPK;
		private System.Byte _groupID;
		private System.Int32 _unitID;
		private System.String _address1;
		private System.Int32 _buildingID;
		private System.Guid _bDBuildingPK;

		public System.Guid ACOutputGroupMainZoneMapPK
		{
			get { return this._aCOutputGroupMainZoneMapPK; }
			set { this._aCOutputGroupMainZoneMapPK = value; }
		}

		public System.Guid ACOutputGroupPK
		{
			get { return this._aCOutputGroupPK; }
			set { this._aCOutputGroupPK = value; }
		}

		public System.Guid ACMainZonePK
		{
			get { return this._aCMainZonePK; }
			set { this._aCMainZonePK = value; }
		}

		public System.DateTime CreatedOn
		{
			get { return this._createdOn; }
			set { this._createdOn = value; }
		}

		public System.String CreatedBy
		{
			get { return this._createdBy; }
			set { this._createdBy = value; }
		}

		public System.DateTime ModifiedOn
		{
			get { return this._modifiedOn; }
			set { this._modifiedOn = value; }
		}

		public System.String ModifiedBy
		{
			get { return this._modifiedBy; }
			set { this._modifiedBy = value; }
		}

		public System.Byte MainZoneID
		{
			get { return this._mainZoneID; }
			set { this._mainZoneID = value; }
		}

		public System.Guid ACPanelPK
		{
			get { return this._aCPanelPK; }
			set { this._aCPanelPK = value; }
		}

		public System.Byte GroupID
		{
			get { return this._groupID; }
			set { this._groupID = value; }
		}

		public System.Int32 UnitID
		{
			get { return this._unitID; }
			set { this._unitID = value; }
		}

		public System.String Address1
		{
			get { return this._address1; }
			set { this._address1 = value; }
		}

		public System.Int32 BuildingID
		{
			get { return this._buildingID; }
			set { this._buildingID = value; }
		}

		public System.Guid BDBuildingPK
		{
			get { return this._bDBuildingPK; }
			set { this._bDBuildingPK = value; }
		}

	}
	[Serializable]
	public class ACCardHolderRuleData
	{
		private System.Guid _aCCardHolderPK;
		private System.Int32 _sitecode;
		private System.Int32 _embossed;
		private System.Int32 _encoded;
		private System.Int32 _cardTypeID;
		private System.String _firstName;
		private System.String _lastName;
		private System.DateTime _validFrom;
		private System.DateTime _validThru;
		private System.Boolean _fIPS;
		private System.Int32 _pin;
		private System.Guid _bDTenantPK;
		private System.String _notes;
		private System.String _eventNotifyEmail;
		private System.Boolean _fireWarden;
		private System.String _custInfo1;
		private System.String _custInfo2;
		private System.String _custInfo3;
		private System.String _custInfo4;
		private System.String _custInfo5;
		private System.String _custInfo6;
		private System.String _custInfo7;
		private System.String _custInfo8;
		private System.DateTime _createdOn;
		private System.String _createdBy;
		private System.DateTime _modifiedOn;
		private System.String _modifiedBy;
		private System.String _suite;
		private System.String _tenant;
		private System.Guid _bDBuildingPK;
		private System.String _address1;
		private System.Int32 _buildingID;

		public System.Guid ACCardHolderPK
		{
			get { return this._aCCardHolderPK; }
			set { this._aCCardHolderPK = value; }
		}

		public System.Int32 Sitecode
		{
			get { return this._sitecode; }
			set { this._sitecode = value; }
		}

		public System.Int32 Embossed
		{
			get { return this._embossed; }
			set { this._embossed = value; }
		}

		public System.Int32 Encoded
		{
			get { return this._encoded; }
			set { this._encoded = value; }
		}

		public System.Int32 CardTypeID
		{
			get { return this._cardTypeID; }
			set { this._cardTypeID = value; }
		}

		public System.String FirstName
		{
			get { return this._firstName; }
			set { this._firstName = value; }
		}

		public System.String LastName
		{
			get { return this._lastName; }
			set { this._lastName = value; }
		}

		public System.DateTime ValidFrom
		{
			get { return this._validFrom; }
			set { this._validFrom = value; }
		}

		public System.DateTime ValidThru
		{
			get { return this._validThru; }
			set { this._validThru = value; }
		}

		public System.Boolean FIPS
		{
			get { return this._fIPS; }
			set { this._fIPS = value; }
		}

		public System.Int32 Pin
		{
			get { return this._pin; }
			set { this._pin = value; }
		}

		public System.Guid BDTenantPK
		{
			get { return this._bDTenantPK; }
			set { this._bDTenantPK = value; }
		}

		public System.String Notes
		{
			get { return this._notes; }
			set { this._notes = value; }
		}

		public System.String EventNotifyEmail
		{
			get { return this._eventNotifyEmail; }
			set { this._eventNotifyEmail = value; }
		}

		public System.Boolean FireWarden
		{
			get { return this._fireWarden; }
			set { this._fireWarden = value; }
		}

		public System.String CustInfo1
		{
			get { return this._custInfo1; }
			set { this._custInfo1 = value; }
		}

		public System.String CustInfo2
		{
			get { return this._custInfo2; }
			set { this._custInfo2 = value; }
		}

		public System.String CustInfo3
		{
			get { return this._custInfo3; }
			set { this._custInfo3 = value; }
		}

		public System.String CustInfo4
		{
			get { return this._custInfo4; }
			set { this._custInfo4 = value; }
		}

		public System.String CustInfo5
		{
			get { return this._custInfo5; }
			set { this._custInfo5 = value; }
		}

		public System.String CustInfo6
		{
			get { return this._custInfo6; }
			set { this._custInfo6 = value; }
		}

		public System.String CustInfo7
		{
			get { return this._custInfo7; }
			set { this._custInfo7 = value; }
		}

		public System.String CustInfo8
		{
			get { return this._custInfo8; }
			set { this._custInfo8 = value; }
		}

		public System.DateTime CreatedOn
		{
			get { return this._createdOn; }
			set { this._createdOn = value; }
		}

		public System.String CreatedBy
		{
			get { return this._createdBy; }
			set { this._createdBy = value; }
		}

		public System.DateTime ModifiedOn
		{
			get { return this._modifiedOn; }
			set { this._modifiedOn = value; }
		}

		public System.String ModifiedBy
		{
			get { return this._modifiedBy; }
			set { this._modifiedBy = value; }
		}

		public System.String Suite
		{
			get { return this._suite; }
			set { this._suite = value; }
		}

		public System.String Tenant
		{
			get { return this._tenant; }
			set { this._tenant = value; }
		}

		public System.Guid BDBuildingPK
		{
			get { return this._bDBuildingPK; }
			set { this._bDBuildingPK = value; }
		}

		public System.String Address1
		{
			get { return this._address1; }
			set { this._address1 = value; }
		}

		public System.Int32 BuildingID
		{
			get { return this._buildingID; }
			set { this._buildingID = value; }
		}

	}
	[Serializable]
	public class ACMainZoneRuleData
	{
		private System.Guid _aCMainZonePK;
		private System.Guid _aCPanelPK;
		private System.Byte _mainZoneID;
		private System.Int32 _mainZoneTypeID;
		private System.String _description;
		private System.String _readerName;
		private System.Int32 _readerTypeID;
		private System.Boolean _reverseColor;
		private System.Byte _outputGroup;
		private System.Boolean _needPin;
		private System.String _antiPassback;
		private System.Boolean _softAntiPassback;
		private System.Int16 _unlockTimecode;
		private System.Boolean _unlockOn1stRead;
		private System.Boolean _rexShuntOnly;
		private System.Int16 _pulseTime;
		private System.Boolean _relockByTimeout;
		private System.Int16 _forceAMFormat;
		private System.Int16 _propAMFFormat;
		private System.Int16 _debounce;
		private System.Int16 _allowOpenTime;
		private System.Boolean _noPreAlarm;
		private System.String _postPreAlarm;
		private System.Int16 _postDuration;
		private System.String _notes;
		private System.String _eventNotifyEmail;
		private System.Boolean _isPulsed;
		private System.Boolean _alwaysToMAS;
		private System.Boolean _commentBeforePulse;
		private System.DateTime _createdOn;
		private System.String _createdBy;
		private System.DateTime _modifiedOn;
		private System.String _modifiedBy;
		private System.Boolean _degrade;
		private System.String _readerPassMode;
		private System.Byte _panelZoneID;
		private System.Int32 _lockTypeID;
		private System.Boolean _locked;
		private System.Byte _inputGroup;
		private System.Int16 _unlockTempTC;
		private System.DateTime _unlockTempBegin;
		private System.DateTime _unlockTempEnd;
		private System.Guid _bDBuildingPK;
		private System.Int32 _unitID;
		private System.String _address1;
		private System.Int32 _buildingID;

		public System.Guid ACMainZonePK
		{
			get { return this._aCMainZonePK; }
			set { this._aCMainZonePK = value; }
		}

		public System.Guid ACPanelPK
		{
			get { return this._aCPanelPK; }
			set { this._aCPanelPK = value; }
		}

		public System.Byte MainZoneID
		{
			get { return this._mainZoneID; }
			set { this._mainZoneID = value; }
		}

		public System.Int32 MainZoneTypeID
		{
			get { return this._mainZoneTypeID; }
			set { this._mainZoneTypeID = value; }
		}

		public System.String Description
		{
			get { return this._description; }
			set { this._description = value; }
		}

		public System.String ReaderName
		{
			get { return this._readerName; }
			set { this._readerName = value; }
		}

		public System.Int32 ReaderTypeID
		{
			get { return this._readerTypeID; }
			set { this._readerTypeID = value; }
		}

		public System.Boolean ReverseColor
		{
			get { return this._reverseColor; }
			set { this._reverseColor = value; }
		}

		public System.Byte OutputGroup
		{
			get { return this._outputGroup; }
			set { this._outputGroup = value; }
		}

		public System.Boolean NeedPin
		{
			get { return this._needPin; }
			set { this._needPin = value; }
		}

		public System.String AntiPassback
		{
			get { return this._antiPassback; }
			set { this._antiPassback = value; }
		}

		public System.Boolean SoftAntiPassback
		{
			get { return this._softAntiPassback; }
			set { this._softAntiPassback = value; }
		}

		public System.Int16 UnlockTimecode
		{
			get { return this._unlockTimecode; }
			set { this._unlockTimecode = value; }
		}

		public System.Boolean UnlockOn1stRead
		{
			get { return this._unlockOn1stRead; }
			set { this._unlockOn1stRead = value; }
		}

		public System.Boolean RexShuntOnly
		{
			get { return this._rexShuntOnly; }
			set { this._rexShuntOnly = value; }
		}

		public System.Int16 PulseTime
		{
			get { return this._pulseTime; }
			set { this._pulseTime = value; }
		}

		public System.Boolean RelockByTimeout
		{
			get { return this._relockByTimeout; }
			set { this._relockByTimeout = value; }
		}

		public System.Int16 ForceAMFormat
		{
			get { return this._forceAMFormat; }
			set { this._forceAMFormat = value; }
		}

		public System.Int16 PropAMFFormat
		{
			get { return this._propAMFFormat; }
			set { this._propAMFFormat = value; }
		}

		public System.Int16 Debounce
		{
			get { return this._debounce; }
			set { this._debounce = value; }
		}

		public System.Int16 AllowOpenTime
		{
			get { return this._allowOpenTime; }
			set { this._allowOpenTime = value; }
		}

		public System.Boolean NoPreAlarm
		{
			get { return this._noPreAlarm; }
			set { this._noPreAlarm = value; }
		}

		public System.String PostPreAlarm
		{
			get { return this._postPreAlarm; }
			set { this._postPreAlarm = value; }
		}

		public System.Int16 PostDuration
		{
			get { return this._postDuration; }
			set { this._postDuration = value; }
		}

		public System.String Notes
		{
			get { return this._notes; }
			set { this._notes = value; }
		}

		public System.String EventNotifyEmail
		{
			get { return this._eventNotifyEmail; }
			set { this._eventNotifyEmail = value; }
		}

		public System.Boolean IsPulsed
		{
			get { return this._isPulsed; }
			set { this._isPulsed = value; }
		}

		public System.Boolean AlwaysToMAS
		{
			get { return this._alwaysToMAS; }
			set { this._alwaysToMAS = value; }
		}

		public System.Boolean CommentBeforePulse
		{
			get { return this._commentBeforePulse; }
			set { this._commentBeforePulse = value; }
		}

		public System.DateTime CreatedOn
		{
			get { return this._createdOn; }
			set { this._createdOn = value; }
		}

		public System.String CreatedBy
		{
			get { return this._createdBy; }
			set { this._createdBy = value; }
		}

		public System.DateTime ModifiedOn
		{
			get { return this._modifiedOn; }
			set { this._modifiedOn = value; }
		}

		public System.String ModifiedBy
		{
			get { return this._modifiedBy; }
			set { this._modifiedBy = value; }
		}

		public System.Boolean Degrade
		{
			get { return this._degrade; }
			set { this._degrade = value; }
		}

		public System.String ReaderPassMode
		{
			get { return this._readerPassMode; }
			set { this._readerPassMode = value; }
		}

		public System.Byte PanelZoneID
		{
			get { return this._panelZoneID; }
			set { this._panelZoneID = value; }
		}

		public System.Int32 LockTypeID
		{
			get { return this._lockTypeID; }
			set { this._lockTypeID = value; }
		}

		public System.Boolean Locked
		{
			get { return this._locked; }
			set { this._locked = value; }
		}

		public System.Byte InputGroup
		{
			get { return this._inputGroup; }
			set { this._inputGroup = value; }
		}

		public System.Int16 UnlockTempTC
		{
			get { return this._unlockTempTC; }
			set { this._unlockTempTC = value; }
		}

		public System.DateTime UnlockTempBegin
		{
			get { return this._unlockTempBegin; }
			set { this._unlockTempBegin = value; }
		}

		public System.DateTime UnlockTempEnd
		{
			get { return this._unlockTempEnd; }
			set { this._unlockTempEnd = value; }
		}

		public System.Guid BDBuildingPK
		{
			get { return this._bDBuildingPK; }
			set { this._bDBuildingPK = value; }
		}

		public System.Int32 UnitID
		{
			get { return this._unitID; }
			set { this._unitID = value; }
		}

		public System.String Address1
		{
			get { return this._address1; }
			set { this._address1 = value; }
		}

		public System.Int32 BuildingID
		{
			get { return this._buildingID; }
			set { this._buildingID = value; }
		}

	}
	[Serializable]
	public class ACIntervalRuleData
	{
		private System.Guid _aCIntervalPK;
		private System.Guid _bDBuildingPK;
		private System.Int16 _iVID;
		private System.String _begin;
		private System.String _end;
		private System.Boolean _sun;
		private System.Boolean _mon;
		private System.Boolean _tue;
		private System.Boolean _wed;
		private System.Boolean _thu;
		private System.Boolean _fri;
		private System.Boolean _sat;
		private System.Boolean _hol;
		private System.DateTime _createdOn;
		private System.String _createdBy;
		private System.DateTime _modifiedOn;
		private System.String _modifiedBy;
		private System.String _address1;
		private System.Int32 _buildingID;

		public System.Guid ACIntervalPK
		{
			get { return this._aCIntervalPK; }
			set { this._aCIntervalPK = value; }
		}

		public System.Guid BDBuildingPK
		{
			get { return this._bDBuildingPK; }
			set { this._bDBuildingPK = value; }
		}

		public System.Int16 IVID
		{
			get { return this._iVID; }
			set { this._iVID = value; }
		}

		public System.String Begin
		{
			get { return this._begin; }
			set { this._begin = value; }
		}

		public System.String End
		{
			get { return this._end; }
			set { this._end = value; }
		}

		public System.Boolean Sun
		{
			get { return this._sun; }
			set { this._sun = value; }
		}

		public System.Boolean Mon
		{
			get { return this._mon; }
			set { this._mon = value; }
		}

		public System.Boolean Tue
		{
			get { return this._tue; }
			set { this._tue = value; }
		}

		public System.Boolean Wed
		{
			get { return this._wed; }
			set { this._wed = value; }
		}

		public System.Boolean Thu
		{
			get { return this._thu; }
			set { this._thu = value; }
		}

		public System.Boolean Fri
		{
			get { return this._fri; }
			set { this._fri = value; }
		}

		public System.Boolean Sat
		{
			get { return this._sat; }
			set { this._sat = value; }
		}

		public System.Boolean Hol
		{
			get { return this._hol; }
			set { this._hol = value; }
		}

		public System.DateTime CreatedOn
		{
			get { return this._createdOn; }
			set { this._createdOn = value; }
		}

		public System.String CreatedBy
		{
			get { return this._createdBy; }
			set { this._createdBy = value; }
		}

		public System.DateTime ModifiedOn
		{
			get { return this._modifiedOn; }
			set { this._modifiedOn = value; }
		}

		public System.String ModifiedBy
		{
			get { return this._modifiedBy; }
			set { this._modifiedBy = value; }
		}

		public System.String Address1
		{
			get { return this._address1; }
			set { this._address1 = value; }
		}

		public System.Int32 BuildingID
		{
			get { return this._buildingID; }
			set { this._buildingID = value; }
		}

	}
	[Serializable]
	public class ACPanelHolidayMapRuleData
	{
		private System.Guid _aCPanelHolidayMapPK;
		private System.Guid _aCPanelPK;
		private System.Guid _utilHolidayPK;
		private System.DateTime _createdOn;
		private System.String _createdBy;
		private System.DateTime _modifiedOn;
		private System.String _modifiedBy;
		private System.DateTime _date;
		private System.String _holiday;
		private System.Guid _bDBuildingPK;
		private System.Int32 _unitID;

		public System.Guid ACPanelHolidayMapPK
		{
			get { return this._aCPanelHolidayMapPK; }
			set { this._aCPanelHolidayMapPK = value; }
		}

		public System.Guid ACPanelPK
		{
			get { return this._aCPanelPK; }
			set { this._aCPanelPK = value; }
		}

		public System.Guid UtilHolidayPK
		{
			get { return this._utilHolidayPK; }
			set { this._utilHolidayPK = value; }
		}

		public System.DateTime CreatedOn
		{
			get { return this._createdOn; }
			set { this._createdOn = value; }
		}

		public System.String CreatedBy
		{
			get { return this._createdBy; }
			set { this._createdBy = value; }
		}

		public System.DateTime ModifiedOn
		{
			get { return this._modifiedOn; }
			set { this._modifiedOn = value; }
		}

		public System.String ModifiedBy
		{
			get { return this._modifiedBy; }
			set { this._modifiedBy = value; }
		}

		public System.DateTime Date
		{
			get { return this._date; }
			set { this._date = value; }
		}

		public System.String Holiday
		{
			get { return this._holiday; }
			set { this._holiday = value; }
		}

		public System.Guid BDBuildingPK
		{
			get { return this._bDBuildingPK; }
			set { this._bDBuildingPK = value; }
		}

		public System.Int32 UnitID
		{
			get { return this._unitID; }
			set { this._unitID = value; }
		}

	}
	[Serializable]
	public class ACTimecodeRuleData
	{
		private System.Guid _aCTimecodePK;
		private System.Guid _bDBuildingPK;
		private System.Int16 _tCID;
		private System.String _summary;
		private System.String _notes;
		private System.DateTime _createdOn;
		private System.String _createdBy;
		private System.DateTime _modifiedOn;
		private System.String _modifiedBy;
		private System.String _address1;
		private System.Int32 _buildingID;

		public System.Guid ACTimecodePK
		{
			get { return this._aCTimecodePK; }
			set { this._aCTimecodePK = value; }
		}

		public System.Guid BDBuildingPK
		{
			get { return this._bDBuildingPK; }
			set { this._bDBuildingPK = value; }
		}

		public System.Int16 TCID
		{
			get { return this._tCID; }
			set { this._tCID = value; }
		}

		public System.String Summary
		{
			get { return this._summary; }
			set { this._summary = value; }
		}

		public System.String Notes
		{
			get { return this._notes; }
			set { this._notes = value; }
		}

		public System.DateTime CreatedOn
		{
			get { return this._createdOn; }
			set { this._createdOn = value; }
		}

		public System.String CreatedBy
		{
			get { return this._createdBy; }
			set { this._createdBy = value; }
		}

		public System.DateTime ModifiedOn
		{
			get { return this._modifiedOn; }
			set { this._modifiedOn = value; }
		}

		public System.String ModifiedBy
		{
			get { return this._modifiedBy; }
			set { this._modifiedBy = value; }
		}

		public System.String Address1
		{
			get { return this._address1; }
			set { this._address1 = value; }
		}

		public System.Int32 BuildingID
		{
			get { return this._buildingID; }
			set { this._buildingID = value; }
		}

	}
	[Serializable]
	public class ACTimecodeIntervalMapRuleData
	{
		private System.Guid _aCTimecodeIntervalMapPK;
		private System.Guid _aCTimecodePK;
		private System.Guid _aCIntervalPK;
		private System.DateTime _createdOn;
		private System.String _createdBy;
		private System.DateTime _modifiedOn;
		private System.String _modifiedBy;
		private System.String _end;
		private System.String _begin;
		private System.Int16 _iVID;
		private System.Int16 _tCID;
		private System.Guid _bDBuildingPK;
		private System.String _address1;
		private System.Int32 _buildingID;

		public System.Guid ACTimecodeIntervalMapPK
		{
			get { return this._aCTimecodeIntervalMapPK; }
			set { this._aCTimecodeIntervalMapPK = value; }
		}

		public System.Guid ACTimecodePK
		{
			get { return this._aCTimecodePK; }
			set { this._aCTimecodePK = value; }
		}

		public System.Guid ACIntervalPK
		{
			get { return this._aCIntervalPK; }
			set { this._aCIntervalPK = value; }
		}

		public System.DateTime CreatedOn
		{
			get { return this._createdOn; }
			set { this._createdOn = value; }
		}

		public System.String CreatedBy
		{
			get { return this._createdBy; }
			set { this._createdBy = value; }
		}

		public System.DateTime ModifiedOn
		{
			get { return this._modifiedOn; }
			set { this._modifiedOn = value; }
		}

		public System.String ModifiedBy
		{
			get { return this._modifiedBy; }
			set { this._modifiedBy = value; }
		}

		public System.String End
		{
			get { return this._end; }
			set { this._end = value; }
		}

		public System.String Begin
		{
			get { return this._begin; }
			set { this._begin = value; }
		}

		public System.Int16 IVID
		{
			get { return this._iVID; }
			set { this._iVID = value; }
		}

		public System.Int16 TCID
		{
			get { return this._tCID; }
			set { this._tCID = value; }
		}

		public System.Guid BDBuildingPK
		{
			get { return this._bDBuildingPK; }
			set { this._bDBuildingPK = value; }
		}

		public System.String Address1
		{
			get { return this._address1; }
			set { this._address1 = value; }
		}

		public System.Int32 BuildingID
		{
			get { return this._buildingID; }
			set { this._buildingID = value; }
		}

	}
	[Serializable]
	public class ACAMFormatRuleData
	{
		private System.Guid _aCAMFormatPK;
		private System.Guid _bDBuildingPK;
		private System.Int16 _aMFID;
		private System.String _summary;
		private System.String _notes;
		private System.Int16 _reportTC;
		private System.Int16 _alarmTC;
		private System.Int16 _preAlarmTC;
		private System.DateTime _createdOn;
		private System.String _createdBy;
		private System.DateTime _modifiedOn;
		private System.String _modifiedBy;
		private System.String _address1;
		private System.Int32 _buildingID;

		public System.Guid ACAMFormatPK
		{
			get { return this._aCAMFormatPK; }
			set { this._aCAMFormatPK = value; }
		}

		public System.Guid BDBuildingPK
		{
			get { return this._bDBuildingPK; }
			set { this._bDBuildingPK = value; }
		}

		public System.Int16 AMFID
		{
			get { return this._aMFID; }
			set { this._aMFID = value; }
		}

		public System.String Summary
		{
			get { return this._summary; }
			set { this._summary = value; }
		}

		public System.String Notes
		{
			get { return this._notes; }
			set { this._notes = value; }
		}

		public System.Int16 ReportTC
		{
			get { return this._reportTC; }
			set { this._reportTC = value; }
		}

		public System.Int16 AlarmTC
		{
			get { return this._alarmTC; }
			set { this._alarmTC = value; }
		}

		public System.Int16 PreAlarmTC
		{
			get { return this._preAlarmTC; }
			set { this._preAlarmTC = value; }
		}

		public System.DateTime CreatedOn
		{
			get { return this._createdOn; }
			set { this._createdOn = value; }
		}

		public System.String CreatedBy
		{
			get { return this._createdBy; }
			set { this._createdBy = value; }
		}

		public System.DateTime ModifiedOn
		{
			get { return this._modifiedOn; }
			set { this._modifiedOn = value; }
		}

		public System.String ModifiedBy
		{
			get { return this._modifiedBy; }
			set { this._modifiedBy = value; }
		}

		public System.String Address1
		{
			get { return this._address1; }
			set { this._address1 = value; }
		}

		public System.Int32 BuildingID
		{
			get { return this._buildingID; }
			set { this._buildingID = value; }
		}

	}
	[Serializable]
	public class BDBuildingHolidayMapRuleData
	{
		private System.Guid _bDBuildingHolidayMapPK;
		private System.Guid _bDBuildingPK;
		private System.Guid _utilHolidayPK;
		private System.Int32 _actionID;
		private System.String _notes;
		private System.DateTime _createdOn;
		private System.String _createdBy;
		private System.DateTime _modifiedOn;
		private System.String _modifiedBy;
		private System.String _address1;
		private System.Int32 _buildingID;
		private System.DateTime _date;
		private System.String _holiday;

		public System.Guid BDBuildingHolidayMapPK
		{
			get { return this._bDBuildingHolidayMapPK; }
			set { this._bDBuildingHolidayMapPK = value; }
		}

		public System.Guid BDBuildingPK
		{
			get { return this._bDBuildingPK; }
			set { this._bDBuildingPK = value; }
		}

		public System.Guid UtilHolidayPK
		{
			get { return this._utilHolidayPK; }
			set { this._utilHolidayPK = value; }
		}

		public System.Int32 ActionID
		{
			get { return this._actionID; }
			set { this._actionID = value; }
		}

		public System.String Notes
		{
			get { return this._notes; }
			set { this._notes = value; }
		}

		public System.DateTime CreatedOn
		{
			get { return this._createdOn; }
			set { this._createdOn = value; }
		}

		public System.String CreatedBy
		{
			get { return this._createdBy; }
			set { this._createdBy = value; }
		}

		public System.DateTime ModifiedOn
		{
			get { return this._modifiedOn; }
			set { this._modifiedOn = value; }
		}

		public System.String ModifiedBy
		{
			get { return this._modifiedBy; }
			set { this._modifiedBy = value; }
		}

		public System.String Address1
		{
			get { return this._address1; }
			set { this._address1 = value; }
		}

		public System.Int32 BuildingID
		{
			get { return this._buildingID; }
			set { this._buildingID = value; }
		}

		public System.DateTime Date
		{
			get { return this._date; }
			set { this._date = value; }
		}

		public System.String Holiday
		{
			get { return this._holiday; }
			set { this._holiday = value; }
		}

	}
	[Serializable]
	public class ACOutputGroupRuleData
	{
		private System.Guid _aCOutputGroupPK;
		private System.Guid _aCPanelPK;
		private System.Byte _groupID;
		private System.String _summary;
		private System.DateTime _createdOn;
		private System.String _createdBy;
		private System.DateTime _modifiedOn;
		private System.String _modifiedBy;
		private System.Guid _bDBuildingPK;
		private System.Int32 _unitID;
		private System.String _address1;
		private System.Int32 _buildingID;

		public System.Guid ACOutputGroupPK
		{
			get { return this._aCOutputGroupPK; }
			set { this._aCOutputGroupPK = value; }
		}

		public System.Guid ACPanelPK
		{
			get { return this._aCPanelPK; }
			set { this._aCPanelPK = value; }
		}

		public System.Byte GroupID
		{
			get { return this._groupID; }
			set { this._groupID = value; }
		}

		public System.String Summary
		{
			get { return this._summary; }
			set { this._summary = value; }
		}

		public System.DateTime CreatedOn
		{
			get { return this._createdOn; }
			set { this._createdOn = value; }
		}

		public System.String CreatedBy
		{
			get { return this._createdBy; }
			set { this._createdBy = value; }
		}

		public System.DateTime ModifiedOn
		{
			get { return this._modifiedOn; }
			set { this._modifiedOn = value; }
		}

		public System.String ModifiedBy
		{
			get { return this._modifiedBy; }
			set { this._modifiedBy = value; }
		}

		public System.Guid BDBuildingPK
		{
			get { return this._bDBuildingPK; }
			set { this._bDBuildingPK = value; }
		}

		public System.Int32 UnitID
		{
			get { return this._unitID; }
			set { this._unitID = value; }
		}

		public System.String Address1
		{
			get { return this._address1; }
			set { this._address1 = value; }
		}

		public System.Int32 BuildingID
		{
			get { return this._buildingID; }
			set { this._buildingID = value; }
		}

	}
	[Serializable]
	public class BDTenantHolidayMapRuleData
	{
		private System.Guid _bDTenantHolidayMapPK;
		private System.Guid _bDTenantPK;
		private System.Guid _utilHolidayPK;
		private System.Int32 _actionID;
		private System.String _notes;
		private System.DateTime _createdOn;
		private System.String _createdBy;
		private System.DateTime _modifiedOn;
		private System.String _modifiedBy;
		private System.String _tenant;
		private System.Guid _bDBuildingPK;
		private System.DateTime _date;
		private System.String _holiday;
		private System.String _address1;
		private System.Int32 _buildingID;

		public System.Guid BDTenantHolidayMapPK
		{
			get { return this._bDTenantHolidayMapPK; }
			set { this._bDTenantHolidayMapPK = value; }
		}

		public System.Guid BDTenantPK
		{
			get { return this._bDTenantPK; }
			set { this._bDTenantPK = value; }
		}

		public System.Guid UtilHolidayPK
		{
			get { return this._utilHolidayPK; }
			set { this._utilHolidayPK = value; }
		}

		public System.Int32 ActionID
		{
			get { return this._actionID; }
			set { this._actionID = value; }
		}

		public System.String Notes
		{
			get { return this._notes; }
			set { this._notes = value; }
		}

		public System.DateTime CreatedOn
		{
			get { return this._createdOn; }
			set { this._createdOn = value; }
		}

		public System.String CreatedBy
		{
			get { return this._createdBy; }
			set { this._createdBy = value; }
		}

		public System.DateTime ModifiedOn
		{
			get { return this._modifiedOn; }
			set { this._modifiedOn = value; }
		}

		public System.String ModifiedBy
		{
			get { return this._modifiedBy; }
			set { this._modifiedBy = value; }
		}

		public System.String Tenant
		{
			get { return this._tenant; }
			set { this._tenant = value; }
		}

		public System.Guid BDBuildingPK
		{
			get { return this._bDBuildingPK; }
			set { this._bDBuildingPK = value; }
		}

		public System.DateTime Date
		{
			get { return this._date; }
			set { this._date = value; }
		}

		public System.String Holiday
		{
			get { return this._holiday; }
			set { this._holiday = value; }
		}

		public System.String Address1
		{
			get { return this._address1; }
			set { this._address1 = value; }
		}

		public System.Int32 BuildingID
		{
			get { return this._buildingID; }
			set { this._buildingID = value; }
		}

	}
	[Serializable]
	public class LogRowsCountRuleData
	{
		private System.Guid _logRowsCountPK;
		private System.Guid _sessionID;
		private System.DateTime _sessionDateTime;
		private System.String _dBTableName;
		private System.Int32 _sequenceID;
		private System.Int32 _rowsCount;
		private System.DateTime _createdOn;
		private System.String _createdBy;
		private System.DateTime _modifiedOn;
		private System.String _modifiedBy;

		public System.Guid LogRowsCountPK
		{
			get { return this._logRowsCountPK; }
			set { this._logRowsCountPK = value; }
		}

		public System.Guid SessionID
		{
			get { return this._sessionID; }
			set { this._sessionID = value; }
		}

		public System.DateTime SessionDateTime
		{
			get { return this._sessionDateTime; }
			set { this._sessionDateTime = value; }
		}

		public System.String DBTableName
		{
			get { return this._dBTableName; }
			set { this._dBTableName = value; }
		}

		public System.Int32 SequenceID
		{
			get { return this._sequenceID; }
			set { this._sequenceID = value; }
		}

		public System.Int32 RowsCount
		{
			get { return this._rowsCount; }
			set { this._rowsCount = value; }
		}

		public System.DateTime CreatedOn
		{
			get { return this._createdOn; }
			set { this._createdOn = value; }
		}

		public System.String CreatedBy
		{
			get { return this._createdBy; }
			set { this._createdBy = value; }
		}

		public System.DateTime ModifiedOn
		{
			get { return this._modifiedOn; }
			set { this._modifiedOn = value; }
		}

		public System.String ModifiedBy
		{
			get { return this._modifiedBy; }
			set { this._modifiedBy = value; }
		}

	}
	[Serializable]
	public class ACInputGroupRuleData
	{
		private System.Guid _aCInputGroupPK;
		private System.Guid _aCPanelPK;
		private System.Byte _groupID;
		private System.String _summary;
		private System.DateTime _createdOn;
		private System.String _createdBy;
		private System.DateTime _modifiedOn;
		private System.String _modifiedBy;
		private System.Guid _bDBuildingPK;
		private System.Int32 _unitID;
		private System.String _address1;
		private System.Int32 _buildingID;

		public System.Guid ACInputGroupPK
		{
			get { return this._aCInputGroupPK; }
			set { this._aCInputGroupPK = value; }
		}

		public System.Guid ACPanelPK
		{
			get { return this._aCPanelPK; }
			set { this._aCPanelPK = value; }
		}

		public System.Byte GroupID
		{
			get { return this._groupID; }
			set { this._groupID = value; }
		}

		public System.String Summary
		{
			get { return this._summary; }
			set { this._summary = value; }
		}

		public System.DateTime CreatedOn
		{
			get { return this._createdOn; }
			set { this._createdOn = value; }
		}

		public System.String CreatedBy
		{
			get { return this._createdBy; }
			set { this._createdBy = value; }
		}

		public System.DateTime ModifiedOn
		{
			get { return this._modifiedOn; }
			set { this._modifiedOn = value; }
		}

		public System.String ModifiedBy
		{
			get { return this._modifiedBy; }
			set { this._modifiedBy = value; }
		}

		public System.Guid BDBuildingPK
		{
			get { return this._bDBuildingPK; }
			set { this._bDBuildingPK = value; }
		}

		public System.Int32 UnitID
		{
			get { return this._unitID; }
			set { this._unitID = value; }
		}

		public System.String Address1
		{
			get { return this._address1; }
			set { this._address1 = value; }
		}

		public System.Int32 BuildingID
		{
			get { return this._buildingID; }
			set { this._buildingID = value; }
		}

	}
	[Serializable]
	public class ACInputRuleData
	{
		private System.Guid _aCInputPK;
		private System.Guid _aCPanelPK;
		private System.Byte _inputID;
		private System.String _description;
		private System.Int16 _debounce;
		private System.Boolean _reverse;
		private System.Int16 _forceAMFormat;
		private System.Boolean _offOnRestore;
		private System.Boolean _external;
		private System.String _notes;
		private System.DateTime _createdOn;
		private System.String _createdBy;
		private System.DateTime _modifiedOn;
		private System.String _modifiedBy;
		private System.Boolean _alwaysToMAS;
		private System.Byte _panelZoneID;
		private System.Boolean _locked;
		private System.Guid _bDBuildingPK;
		private System.Int32 _unitID;
		private System.String _address1;
		private System.Int32 _buildingID;

		public System.Guid ACInputPK
		{
			get { return this._aCInputPK; }
			set { this._aCInputPK = value; }
		}

		public System.Guid ACPanelPK
		{
			get { return this._aCPanelPK; }
			set { this._aCPanelPK = value; }
		}

		public System.Byte InputID
		{
			get { return this._inputID; }
			set { this._inputID = value; }
		}

		public System.String Description
		{
			get { return this._description; }
			set { this._description = value; }
		}

		public System.Int16 Debounce
		{
			get { return this._debounce; }
			set { this._debounce = value; }
		}

		public System.Boolean Reverse
		{
			get { return this._reverse; }
			set { this._reverse = value; }
		}

		public System.Int16 ForceAMFormat
		{
			get { return this._forceAMFormat; }
			set { this._forceAMFormat = value; }
		}

		public System.Boolean OffOnRestore
		{
			get { return this._offOnRestore; }
			set { this._offOnRestore = value; }
		}

		public System.Boolean External
		{
			get { return this._external; }
			set { this._external = value; }
		}

		public System.String Notes
		{
			get { return this._notes; }
			set { this._notes = value; }
		}

		public System.DateTime CreatedOn
		{
			get { return this._createdOn; }
			set { this._createdOn = value; }
		}

		public System.String CreatedBy
		{
			get { return this._createdBy; }
			set { this._createdBy = value; }
		}

		public System.DateTime ModifiedOn
		{
			get { return this._modifiedOn; }
			set { this._modifiedOn = value; }
		}

		public System.String ModifiedBy
		{
			get { return this._modifiedBy; }
			set { this._modifiedBy = value; }
		}

		public System.Boolean AlwaysToMAS
		{
			get { return this._alwaysToMAS; }
			set { this._alwaysToMAS = value; }
		}

		public System.Byte PanelZoneID
		{
			get { return this._panelZoneID; }
			set { this._panelZoneID = value; }
		}

		public System.Boolean Locked
		{
			get { return this._locked; }
			set { this._locked = value; }
		}

		public System.Guid BDBuildingPK
		{
			get { return this._bDBuildingPK; }
			set { this._bDBuildingPK = value; }
		}

		public System.Int32 UnitID
		{
			get { return this._unitID; }
			set { this._unitID = value; }
		}

		public System.String Address1
		{
			get { return this._address1; }
			set { this._address1 = value; }
		}

		public System.Int32 BuildingID
		{
			get { return this._buildingID; }
			set { this._buildingID = value; }
		}

	}
	[Serializable]
	public class ACFunctionCardRuleData
	{
		private System.Guid _aCFunctionCardPK;
		private System.Int32 _sitecode;
		private System.Int32 _embossed;
		private System.Int32 _encoded;
		private System.Int32 _cardTypeID;
		private System.Guid _bDTenantPK;
		private System.Int32 _functionID;
		private System.String _firstName;
		private System.String _lastName;
		private System.Boolean _fIPS;
		private System.Int32 _pin;
		private System.DateTime _validFrom;
		private System.DateTime _validThru;
		private System.DateTime _createdOn;
		private System.String _createdBy;
		private System.DateTime _modifiedOn;
		private System.String _modifiedBy;
		private System.String _suite;
		private System.String _tenant;
		private System.Guid _bDBuildingPK;
		private System.String _address1;
		private System.Int32 _buildingID;

		public System.Guid ACFunctionCardPK
		{
			get { return this._aCFunctionCardPK; }
			set { this._aCFunctionCardPK = value; }
		}

		public System.Int32 Sitecode
		{
			get { return this._sitecode; }
			set { this._sitecode = value; }
		}

		public System.Int32 Embossed
		{
			get { return this._embossed; }
			set { this._embossed = value; }
		}

		public System.Int32 Encoded
		{
			get { return this._encoded; }
			set { this._encoded = value; }
		}

		public System.Int32 CardTypeID
		{
			get { return this._cardTypeID; }
			set { this._cardTypeID = value; }
		}

		public System.Guid BDTenantPK
		{
			get { return this._bDTenantPK; }
			set { this._bDTenantPK = value; }
		}

		public System.Int32 FunctionID
		{
			get { return this._functionID; }
			set { this._functionID = value; }
		}

		public System.String FirstName
		{
			get { return this._firstName; }
			set { this._firstName = value; }
		}

		public System.String LastName
		{
			get { return this._lastName; }
			set { this._lastName = value; }
		}

		public System.Boolean FIPS
		{
			get { return this._fIPS; }
			set { this._fIPS = value; }
		}

		public System.Int32 Pin
		{
			get { return this._pin; }
			set { this._pin = value; }
		}

		public System.DateTime ValidFrom
		{
			get { return this._validFrom; }
			set { this._validFrom = value; }
		}

		public System.DateTime ValidThru
		{
			get { return this._validThru; }
			set { this._validThru = value; }
		}

		public System.DateTime CreatedOn
		{
			get { return this._createdOn; }
			set { this._createdOn = value; }
		}

		public System.String CreatedBy
		{
			get { return this._createdBy; }
			set { this._createdBy = value; }
		}

		public System.DateTime ModifiedOn
		{
			get { return this._modifiedOn; }
			set { this._modifiedOn = value; }
		}

		public System.String ModifiedBy
		{
			get { return this._modifiedBy; }
			set { this._modifiedBy = value; }
		}

		public System.String Suite
		{
			get { return this._suite; }
			set { this._suite = value; }
		}

		public System.String Tenant
		{
			get { return this._tenant; }
			set { this._tenant = value; }
		}

		public System.Guid BDBuildingPK
		{
			get { return this._bDBuildingPK; }
			set { this._bDBuildingPK = value; }
		}

		public System.String Address1
		{
			get { return this._address1; }
			set { this._address1 = value; }
		}

		public System.Int32 BuildingID
		{
			get { return this._buildingID; }
			set { this._buildingID = value; }
		}

	}
	[Serializable]
	public class UtilHolidayRuleData
	{
		private System.Guid _utilHolidayPK;
		private System.Int32 _countryID;
		private System.String _holiday;
		private System.DateTime _date;
		private System.Boolean _major;
		private System.Boolean _federal;
		private System.DateTime _createdOn;
		private System.String _createdBy;
		private System.DateTime _modifiedOn;
		private System.String _modifiedBy;
		private System.Boolean _default;
		private System.Int32 _actionID;

		public System.Guid UtilHolidayPK
		{
			get { return this._utilHolidayPK; }
			set { this._utilHolidayPK = value; }
		}

		public System.Int32 CountryID
		{
			get { return this._countryID; }
			set { this._countryID = value; }
		}

		public System.String Holiday
		{
			get { return this._holiday; }
			set { this._holiday = value; }
		}

		public System.DateTime Date
		{
			get { return this._date; }
			set { this._date = value; }
		}

		public System.Boolean Major
		{
			get { return this._major; }
			set { this._major = value; }
		}

		public System.Boolean Federal
		{
			get { return this._federal; }
			set { this._federal = value; }
		}

		public System.DateTime CreatedOn
		{
			get { return this._createdOn; }
			set { this._createdOn = value; }
		}

		public System.String CreatedBy
		{
			get { return this._createdBy; }
			set { this._createdBy = value; }
		}

		public System.DateTime ModifiedOn
		{
			get { return this._modifiedOn; }
			set { this._modifiedOn = value; }
		}

		public System.String ModifiedBy
		{
			get { return this._modifiedBy; }
			set { this._modifiedBy = value; }
		}

		public System.Boolean Default
		{
			get { return this._default; }
			set { this._default = value; }
		}

		public System.Int32 ActionID
		{
			get { return this._actionID; }
			set { this._actionID = value; }
		}

	}
	[Serializable]
	public class ACAccessLevelRuleData
	{
		private System.Guid _aCAccessLevelPK;
		private System.Guid _bDBuildingPK;
		private System.Int16 _accessLevelID;
		private System.String _summary;
		private System.Boolean _asAL2;
		private System.String _notes;
		private System.DateTime _createdOn;
		private System.String _createdBy;
		private System.DateTime _modifiedOn;
		private System.String _modifiedBy;
		private System.String _address1;
		private System.Int32 _buildingID;

		public System.Guid ACAccessLevelPK
		{
			get { return this._aCAccessLevelPK; }
			set { this._aCAccessLevelPK = value; }
		}

		public System.Guid BDBuildingPK
		{
			get { return this._bDBuildingPK; }
			set { this._bDBuildingPK = value; }
		}

		public System.Int16 AccessLevelID
		{
			get { return this._accessLevelID; }
			set { this._accessLevelID = value; }
		}

		public System.String Summary
		{
			get { return this._summary; }
			set { this._summary = value; }
		}

		public System.Boolean AsAL2
		{
			get { return this._asAL2; }
			set { this._asAL2 = value; }
		}

		public System.String Notes
		{
			get { return this._notes; }
			set { this._notes = value; }
		}

		public System.DateTime CreatedOn
		{
			get { return this._createdOn; }
			set { this._createdOn = value; }
		}

		public System.String CreatedBy
		{
			get { return this._createdBy; }
			set { this._createdBy = value; }
		}

		public System.DateTime ModifiedOn
		{
			get { return this._modifiedOn; }
			set { this._modifiedOn = value; }
		}

		public System.String ModifiedBy
		{
			get { return this._modifiedBy; }
			set { this._modifiedBy = value; }
		}

		public System.String Address1
		{
			get { return this._address1; }
			set { this._address1 = value; }
		}

		public System.Int32 BuildingID
		{
			get { return this._buildingID; }
			set { this._buildingID = value; }
		}

	}
	[Serializable]
	public class ACPanelFunctionCardMapRuleData
	{
		private System.Guid _aCPanelFunctionCardMapPK;
		private System.Guid _aCPanelPK;
		private System.Guid _aCFunctionCardPK;
		private System.DateTime _createdOn;
		private System.String _createdBy;
		private System.DateTime _modifiedOn;
		private System.String _modifiedBy;
		private System.Int32 _cardTypeID;
		private System.Int32 _encoded;
		private System.Int32 _embossed;
		private System.Int32 _sitecode;
		private System.Guid _bDBuildingPK;
		private System.Int32 _unitID;

		public System.Guid ACPanelFunctionCardMapPK
		{
			get { return this._aCPanelFunctionCardMapPK; }
			set { this._aCPanelFunctionCardMapPK = value; }
		}

		public System.Guid ACPanelPK
		{
			get { return this._aCPanelPK; }
			set { this._aCPanelPK = value; }
		}

		public System.Guid ACFunctionCardPK
		{
			get { return this._aCFunctionCardPK; }
			set { this._aCFunctionCardPK = value; }
		}

		public System.DateTime CreatedOn
		{
			get { return this._createdOn; }
			set { this._createdOn = value; }
		}

		public System.String CreatedBy
		{
			get { return this._createdBy; }
			set { this._createdBy = value; }
		}

		public System.DateTime ModifiedOn
		{
			get { return this._modifiedOn; }
			set { this._modifiedOn = value; }
		}

		public System.String ModifiedBy
		{
			get { return this._modifiedBy; }
			set { this._modifiedBy = value; }
		}

		public System.Int32 CardTypeID
		{
			get { return this._cardTypeID; }
			set { this._cardTypeID = value; }
		}

		public System.Int32 Encoded
		{
			get { return this._encoded; }
			set { this._encoded = value; }
		}

		public System.Int32 Embossed
		{
			get { return this._embossed; }
			set { this._embossed = value; }
		}

		public System.Int32 Sitecode
		{
			get { return this._sitecode; }
			set { this._sitecode = value; }
		}

		public System.Guid BDBuildingPK
		{
			get { return this._bDBuildingPK; }
			set { this._bDBuildingPK = value; }
		}

		public System.Int32 UnitID
		{
			get { return this._unitID; }
			set { this._unitID = value; }
		}

	}
	[Serializable]
	public class LogDBDeleteActivityRuleData
	{
		private System.Guid _logDBDeleteActivityPK;
		private System.DateTime _logDateTime;
		private System.String _dBTableName;
		private System.Guid _recordPK;
		private System.DateTime _lastUpdated;
		private System.DateTime _createdOn;
		private System.String _createdBy;
		private System.DateTime _modifiedOn;
		private System.String _modifiedBy;

		public System.Guid LogDBDeleteActivityPK
		{
			get { return this._logDBDeleteActivityPK; }
			set { this._logDBDeleteActivityPK = value; }
		}

		public System.DateTime LogDateTime
		{
			get { return this._logDateTime; }
			set { this._logDateTime = value; }
		}

		public System.String DBTableName
		{
			get { return this._dBTableName; }
			set { this._dBTableName = value; }
		}

		public System.Guid RecordPK
		{
			get { return this._recordPK; }
			set { this._recordPK = value; }
		}

		public System.DateTime LastUpdated
		{
			get { return this._lastUpdated; }
			set { this._lastUpdated = value; }
		}

		public System.DateTime CreatedOn
		{
			get { return this._createdOn; }
			set { this._createdOn = value; }
		}

		public System.String CreatedBy
		{
			get { return this._createdBy; }
			set { this._createdBy = value; }
		}

		public System.DateTime ModifiedOn
		{
			get { return this._modifiedOn; }
			set { this._modifiedOn = value; }
		}

		public System.String ModifiedBy
		{
			get { return this._modifiedBy; }
			set { this._modifiedBy = value; }
		}

	}
	[Serializable]
	public class UsrAccountRuleData
	{
		private System.Guid _usrAccountPK;
		private System.String _userID;
		private System.Boolean _isAdmin;
		private System.Boolean _isCentral;
		private System.String _firstName;
		private System.String _lastName;
		private System.String _password;
		private System.DateTime _pwdExpireDate;
		private System.Guid _usrGroupPK;
		private System.Guid _bDTenantPK;
		private System.String _cellPhone;
		private System.String _homePhone;
		private System.String _officePhone;
		private System.String _email;
		private System.DateTime _lastLogin;
		private System.Int32 _totalUsage;
		private System.String _startScreen;
		private System.Int32 _popupExtension;
		private System.DateTime _createdOn;
		private System.String _createdBy;
		private System.DateTime _modifiedOn;
		private System.String _modifiedBy;
		private System.String _suite;
		private System.String _tenant;
		private System.Guid _bDBuildingPK;
		private System.String _usrGroupName;
		private System.String _address1;
		private System.Int32 _buildingID;

		public System.Guid UsrAccountPK
		{
			get { return this._usrAccountPK; }
			set { this._usrAccountPK = value; }
		}

		public System.String UserID
		{
			get { return this._userID; }
			set { this._userID = value; }
		}

		public System.Boolean IsAdmin
		{
			get { return this._isAdmin; }
			set { this._isAdmin = value; }
		}

		public System.Boolean IsCentral
		{
			get { return this._isCentral; }
			set { this._isCentral = value; }
		}

		public System.String FirstName
		{
			get { return this._firstName; }
			set { this._firstName = value; }
		}

		public System.String LastName
		{
			get { return this._lastName; }
			set { this._lastName = value; }
		}

		public System.String Password
		{
			get { return this._password; }
			set { this._password = value; }
		}

		public System.DateTime PwdExpireDate
		{
			get { return this._pwdExpireDate; }
			set { this._pwdExpireDate = value; }
		}

		public System.Guid UsrGroupPK
		{
			get { return this._usrGroupPK; }
			set { this._usrGroupPK = value; }
		}

		public System.Guid BDTenantPK
		{
			get { return this._bDTenantPK; }
			set { this._bDTenantPK = value; }
		}

		public System.String CellPhone
		{
			get { return this._cellPhone; }
			set { this._cellPhone = value; }
		}

		public System.String HomePhone
		{
			get { return this._homePhone; }
			set { this._homePhone = value; }
		}

		public System.String OfficePhone
		{
			get { return this._officePhone; }
			set { this._officePhone = value; }
		}

		public System.String Email
		{
			get { return this._email; }
			set { this._email = value; }
		}

		public System.DateTime LastLogin
		{
			get { return this._lastLogin; }
			set { this._lastLogin = value; }
		}

		public System.Int32 TotalUsage
		{
			get { return this._totalUsage; }
			set { this._totalUsage = value; }
		}

		public System.String StartScreen
		{
			get { return this._startScreen; }
			set { this._startScreen = value; }
		}

		public System.Int32 PopupExtension
		{
			get { return this._popupExtension; }
			set { this._popupExtension = value; }
		}

		public System.DateTime CreatedOn
		{
			get { return this._createdOn; }
			set { this._createdOn = value; }
		}

		public System.String CreatedBy
		{
			get { return this._createdBy; }
			set { this._createdBy = value; }
		}

		public System.DateTime ModifiedOn
		{
			get { return this._modifiedOn; }
			set { this._modifiedOn = value; }
		}

		public System.String ModifiedBy
		{
			get { return this._modifiedBy; }
			set { this._modifiedBy = value; }
		}

		public System.String Suite
		{
			get { return this._suite; }
			set { this._suite = value; }
		}

		public System.String Tenant
		{
			get { return this._tenant; }
			set { this._tenant = value; }
		}

		public System.Guid BDBuildingPK
		{
			get { return this._bDBuildingPK; }
			set { this._bDBuildingPK = value; }
		}

		public System.String UsrGroupName
		{
			get { return this._usrGroupName; }
			set { this._usrGroupName = value; }
		}

		public System.String Address1
		{
			get { return this._address1; }
			set { this._address1 = value; }
		}

		public System.Int32 BuildingID
		{
			get { return this._buildingID; }
			set { this._buildingID = value; }
		}

	}
	[Serializable]
	public class LogDBEditActivityRuleData
	{
		private System.Guid _logDBEditActivityPK;
		private System.DateTime _logDateTime;
		private System.String _dBTableName;
		private System.Guid _recordPK;
		private System.String _category;
		private System.DateTime _createdOn;
		private System.String _createdBy;
		private System.DateTime _modifiedOn;
		private System.String _modifiedBy;

		public System.Guid LogDBEditActivityPK
		{
			get { return this._logDBEditActivityPK; }
			set { this._logDBEditActivityPK = value; }
		}

		public System.DateTime LogDateTime
		{
			get { return this._logDateTime; }
			set { this._logDateTime = value; }
		}

		public System.String DBTableName
		{
			get { return this._dBTableName; }
			set { this._dBTableName = value; }
		}

		public System.Guid RecordPK
		{
			get { return this._recordPK; }
			set { this._recordPK = value; }
		}

		public System.String Category
		{
			get { return this._category; }
			set { this._category = value; }
		}

		public System.DateTime CreatedOn
		{
			get { return this._createdOn; }
			set { this._createdOn = value; }
		}

		public System.String CreatedBy
		{
			get { return this._createdBy; }
			set { this._createdBy = value; }
		}

		public System.DateTime ModifiedOn
		{
			get { return this._modifiedOn; }
			set { this._modifiedOn = value; }
		}

		public System.String ModifiedBy
		{
			get { return this._modifiedBy; }
			set { this._modifiedBy = value; }
		}

	}
	[Serializable]
	public class ACMasterCardRuleData
	{
		private System.Guid _aCMasterCardPK;
		private System.Int32 _sitecode;
		private System.Int32 _embossed;
		private System.Int32 _encoded;
		private System.Int32 _cardTypeID;
		private System.String _firstName;
		private System.String _lastName;
		private System.Boolean _fIPS;
		private System.Int32 _pin;
		private System.DateTime _createdOn;
		private System.String _createdBy;
		private System.DateTime _modifiedOn;
		private System.String _modifiedBy;

		public System.Guid ACMasterCardPK
		{
			get { return this._aCMasterCardPK; }
			set { this._aCMasterCardPK = value; }
		}

		public System.Int32 Sitecode
		{
			get { return this._sitecode; }
			set { this._sitecode = value; }
		}

		public System.Int32 Embossed
		{
			get { return this._embossed; }
			set { this._embossed = value; }
		}

		public System.Int32 Encoded
		{
			get { return this._encoded; }
			set { this._encoded = value; }
		}

		public System.Int32 CardTypeID
		{
			get { return this._cardTypeID; }
			set { this._cardTypeID = value; }
		}

		public System.String FirstName
		{
			get { return this._firstName; }
			set { this._firstName = value; }
		}

		public System.String LastName
		{
			get { return this._lastName; }
			set { this._lastName = value; }
		}

		public System.Boolean FIPS
		{
			get { return this._fIPS; }
			set { this._fIPS = value; }
		}

		public System.Int32 Pin
		{
			get { return this._pin; }
			set { this._pin = value; }
		}

		public System.DateTime CreatedOn
		{
			get { return this._createdOn; }
			set { this._createdOn = value; }
		}

		public System.String CreatedBy
		{
			get { return this._createdBy; }
			set { this._createdBy = value; }
		}

		public System.DateTime ModifiedOn
		{
			get { return this._modifiedOn; }
			set { this._modifiedOn = value; }
		}

		public System.String ModifiedBy
		{
			get { return this._modifiedBy; }
			set { this._modifiedBy = value; }
		}

	}
	[Serializable]
	public class ACSupervisoryRuleData
	{
		private System.Guid _aCSupervisoryPK;
		private System.Guid _aCPanelPK;
		private System.Byte _supervisoryID;
		private System.String _description;
		private System.Int16 _debounce;
		private System.Int16 _forceAMFormat;
		private System.Boolean _external;
		private System.String _notes;
		private System.DateTime _createdOn;
		private System.String _createdBy;
		private System.DateTime _modifiedOn;
		private System.String _modifiedBy;
		private System.Byte _panelZoneID;
		private System.Boolean _locked;
		private System.Guid _bDBuildingPK;
		private System.Int32 _unitID;
		private System.String _address1;
		private System.Int32 _buildingID;

		public System.Guid ACSupervisoryPK
		{
			get { return this._aCSupervisoryPK; }
			set { this._aCSupervisoryPK = value; }
		}

		public System.Guid ACPanelPK
		{
			get { return this._aCPanelPK; }
			set { this._aCPanelPK = value; }
		}

		public System.Byte SupervisoryID
		{
			get { return this._supervisoryID; }
			set { this._supervisoryID = value; }
		}

		public System.String Description
		{
			get { return this._description; }
			set { this._description = value; }
		}

		public System.Int16 Debounce
		{
			get { return this._debounce; }
			set { this._debounce = value; }
		}

		public System.Int16 ForceAMFormat
		{
			get { return this._forceAMFormat; }
			set { this._forceAMFormat = value; }
		}

		public System.Boolean External
		{
			get { return this._external; }
			set { this._external = value; }
		}

		public System.String Notes
		{
			get { return this._notes; }
			set { this._notes = value; }
		}

		public System.DateTime CreatedOn
		{
			get { return this._createdOn; }
			set { this._createdOn = value; }
		}

		public System.String CreatedBy
		{
			get { return this._createdBy; }
			set { this._createdBy = value; }
		}

		public System.DateTime ModifiedOn
		{
			get { return this._modifiedOn; }
			set { this._modifiedOn = value; }
		}

		public System.String ModifiedBy
		{
			get { return this._modifiedBy; }
			set { this._modifiedBy = value; }
		}

		public System.Byte PanelZoneID
		{
			get { return this._panelZoneID; }
			set { this._panelZoneID = value; }
		}

		public System.Boolean Locked
		{
			get { return this._locked; }
			set { this._locked = value; }
		}

		public System.Guid BDBuildingPK
		{
			get { return this._bDBuildingPK; }
			set { this._bDBuildingPK = value; }
		}

		public System.Int32 UnitID
		{
			get { return this._unitID; }
			set { this._unitID = value; }
		}

		public System.String Address1
		{
			get { return this._address1; }
			set { this._address1 = value; }
		}

		public System.Int32 BuildingID
		{
			get { return this._buildingID; }
			set { this._buildingID = value; }
		}

	}
	[Serializable]
	public class UsrGroupRuleData
	{
		private System.Guid _usrGroupPK;
		private System.String _usrGroupName;
		private System.String _description;
		private System.DateTime _createdOn;
		private System.String _createdBy;
		private System.DateTime _modifiedOn;
		private System.String _modifiedBy;

		public System.Guid UsrGroupPK
		{
			get { return this._usrGroupPK; }
			set { this._usrGroupPK = value; }
		}

		public System.String UsrGroupName
		{
			get { return this._usrGroupName; }
			set { this._usrGroupName = value; }
		}

		public System.String Description
		{
			get { return this._description; }
			set { this._description = value; }
		}

		public System.DateTime CreatedOn
		{
			get { return this._createdOn; }
			set { this._createdOn = value; }
		}

		public System.String CreatedBy
		{
			get { return this._createdBy; }
			set { this._createdBy = value; }
		}

		public System.DateTime ModifiedOn
		{
			get { return this._modifiedOn; }
			set { this._modifiedOn = value; }
		}

		public System.String ModifiedBy
		{
			get { return this._modifiedBy; }
			set { this._modifiedBy = value; }
		}

	}
	[Serializable]
	public class ACCardHolderBuildingMapRuleData
	{
		private System.Guid _aCCardHolderBuildingMapPK;
		private System.Guid _aCCardHolderPK;
		private System.Guid _bDBuildingPK;
		private System.Int16 _aL1st;
		private System.Int16 _aL2nd;
		private System.DateTime _createdOn;
		private System.String _createdBy;
		private System.DateTime _modifiedOn;
		private System.String _modifiedBy;
		private System.String _address1;
		private System.Int32 _buildingID;
		private System.String _lastName;
		private System.String _firstName;
		private System.Int32 _cardTypeID;
		private System.Int32 _encoded;
		private System.Int32 _embossed;
		private System.Int32 _sitecode;

		public System.Guid ACCardHolderBuildingMapPK
		{
			get { return this._aCCardHolderBuildingMapPK; }
			set { this._aCCardHolderBuildingMapPK = value; }
		}

		public System.Guid ACCardHolderPK
		{
			get { return this._aCCardHolderPK; }
			set { this._aCCardHolderPK = value; }
		}

		public System.Guid BDBuildingPK
		{
			get { return this._bDBuildingPK; }
			set { this._bDBuildingPK = value; }
		}

		public System.Int16 AL1st
		{
			get { return this._aL1st; }
			set { this._aL1st = value; }
		}

		public System.Int16 AL2nd
		{
			get { return this._aL2nd; }
			set { this._aL2nd = value; }
		}

		public System.DateTime CreatedOn
		{
			get { return this._createdOn; }
			set { this._createdOn = value; }
		}

		public System.String CreatedBy
		{
			get { return this._createdBy; }
			set { this._createdBy = value; }
		}

		public System.DateTime ModifiedOn
		{
			get { return this._modifiedOn; }
			set { this._modifiedOn = value; }
		}

		public System.String ModifiedBy
		{
			get { return this._modifiedBy; }
			set { this._modifiedBy = value; }
		}

		public System.String Address1
		{
			get { return this._address1; }
			set { this._address1 = value; }
		}

		public System.Int32 BuildingID
		{
			get { return this._buildingID; }
			set { this._buildingID = value; }
		}

		public System.String LastName
		{
			get { return this._lastName; }
			set { this._lastName = value; }
		}

		public System.String FirstName
		{
			get { return this._firstName; }
			set { this._firstName = value; }
		}

		public System.Int32 CardTypeID
		{
			get { return this._cardTypeID; }
			set { this._cardTypeID = value; }
		}

		public System.Int32 Encoded
		{
			get { return this._encoded; }
			set { this._encoded = value; }
		}

		public System.Int32 Embossed
		{
			get { return this._embossed; }
			set { this._embossed = value; }
		}

		public System.Int32 Sitecode
		{
			get { return this._sitecode; }
			set { this._sitecode = value; }
		}

	}
	[Serializable]
	public class BDVisitorRuleData
	{
		private System.Guid _bDVisitorPK;
		private System.Guid _bDTenantPK;
		private System.String _firstName;
		private System.String _lastName;
		private System.String _authorizedBy;
		private System.String _authorizedArea;
		private System.String _authorEmail;
		private System.Boolean _emailNotify;
		private System.DateTime _validFrom;
		private System.DateTime _validThru;
		private System.String _password;
		private System.String _special;
		private System.String _begin;
		private System.String _end;
		private System.Int32 _siteCode;
		private System.Int32 _encoded;
		private System.Boolean _scheduled;
		private System.DateTime _arrivedTime;
		private System.Int64 _turnstileAccess;
		private System.Boolean _badgePrinted;
		private System.DateTime _createdOn;
		private System.String _createdBy;
		private System.DateTime _modifiedOn;
		private System.String _modifiedBy;
		private System.String _suite;
		private System.String _tenant;
		private System.Guid _bDBuildingPK;
		private System.String _address1;
		private System.Int32 _buildingID;

		public System.Guid BDVisitorPK
		{
			get { return this._bDVisitorPK; }
			set { this._bDVisitorPK = value; }
		}

		public System.Guid BDTenantPK
		{
			get { return this._bDTenantPK; }
			set { this._bDTenantPK = value; }
		}

		public System.String FirstName
		{
			get { return this._firstName; }
			set { this._firstName = value; }
		}

		public System.String LastName
		{
			get { return this._lastName; }
			set { this._lastName = value; }
		}

		public System.String AuthorizedBy
		{
			get { return this._authorizedBy; }
			set { this._authorizedBy = value; }
		}

		public System.String AuthorizedArea
		{
			get { return this._authorizedArea; }
			set { this._authorizedArea = value; }
		}

		public System.String AuthorEmail
		{
			get { return this._authorEmail; }
			set { this._authorEmail = value; }
		}

		public System.Boolean EmailNotify
		{
			get { return this._emailNotify; }
			set { this._emailNotify = value; }
		}

		public System.DateTime ValidFrom
		{
			get { return this._validFrom; }
			set { this._validFrom = value; }
		}

		public System.DateTime ValidThru
		{
			get { return this._validThru; }
			set { this._validThru = value; }
		}

		public System.String Password
		{
			get { return this._password; }
			set { this._password = value; }
		}

		public System.String Special
		{
			get { return this._special; }
			set { this._special = value; }
		}

		public System.String Begin
		{
			get { return this._begin; }
			set { this._begin = value; }
		}

		public System.String End
		{
			get { return this._end; }
			set { this._end = value; }
		}

		public System.Int32 SiteCode
		{
			get { return this._siteCode; }
			set { this._siteCode = value; }
		}

		public System.Int32 Encoded
		{
			get { return this._encoded; }
			set { this._encoded = value; }
		}

		public System.Boolean Scheduled
		{
			get { return this._scheduled; }
			set { this._scheduled = value; }
		}

		public System.DateTime ArrivedTime
		{
			get { return this._arrivedTime; }
			set { this._arrivedTime = value; }
		}

		public System.Int64 TurnstileAccess
		{
			get { return this._turnstileAccess; }
			set { this._turnstileAccess = value; }
		}

		public System.Boolean BadgePrinted
		{
			get { return this._badgePrinted; }
			set { this._badgePrinted = value; }
		}

		public System.DateTime CreatedOn
		{
			get { return this._createdOn; }
			set { this._createdOn = value; }
		}

		public System.String CreatedBy
		{
			get { return this._createdBy; }
			set { this._createdBy = value; }
		}

		public System.DateTime ModifiedOn
		{
			get { return this._modifiedOn; }
			set { this._modifiedOn = value; }
		}

		public System.String ModifiedBy
		{
			get { return this._modifiedBy; }
			set { this._modifiedBy = value; }
		}

		public System.String Suite
		{
			get { return this._suite; }
			set { this._suite = value; }
		}

		public System.String Tenant
		{
			get { return this._tenant; }
			set { this._tenant = value; }
		}

		public System.Guid BDBuildingPK
		{
			get { return this._bDBuildingPK; }
			set { this._bDBuildingPK = value; }
		}

		public System.String Address1
		{
			get { return this._address1; }
			set { this._address1 = value; }
		}

		public System.Int32 BuildingID
		{
			get { return this._buildingID; }
			set { this._buildingID = value; }
		}

	}
	[Serializable]
	public class UsrGroupDBRuleRuleData
	{
		private System.Guid _usrGroupDBRulePK;
		private System.Guid _usrGroupPK;
		private System.Int32 _dBRuleID;
		private System.Boolean _selectable;
		private System.Boolean _insertable;
		private System.Boolean _editable;
		private System.Boolean _deletable;
		private System.DateTime _createdOn;
		private System.String _createdBy;
		private System.DateTime _modifiedOn;
		private System.String _modifiedBy;
		private System.String _usrGroupName;

		public System.Guid UsrGroupDBRulePK
		{
			get { return this._usrGroupDBRulePK; }
			set { this._usrGroupDBRulePK = value; }
		}

		public System.Guid UsrGroupPK
		{
			get { return this._usrGroupPK; }
			set { this._usrGroupPK = value; }
		}

		public System.Int32 DBRuleID
		{
			get { return this._dBRuleID; }
			set { this._dBRuleID = value; }
		}

		public System.Boolean Selectable
		{
			get { return this._selectable; }
			set { this._selectable = value; }
		}

		public System.Boolean Insertable
		{
			get { return this._insertable; }
			set { this._insertable = value; }
		}

		public System.Boolean Editable
		{
			get { return this._editable; }
			set { this._editable = value; }
		}

		public System.Boolean Deletable
		{
			get { return this._deletable; }
			set { this._deletable = value; }
		}

		public System.DateTime CreatedOn
		{
			get { return this._createdOn; }
			set { this._createdOn = value; }
		}

		public System.String CreatedBy
		{
			get { return this._createdBy; }
			set { this._createdBy = value; }
		}

		public System.DateTime ModifiedOn
		{
			get { return this._modifiedOn; }
			set { this._modifiedOn = value; }
		}

		public System.String ModifiedBy
		{
			get { return this._modifiedBy; }
			set { this._modifiedBy = value; }
		}

		public System.String UsrGroupName
		{
			get { return this._usrGroupName; }
			set { this._usrGroupName = value; }
		}

	}
	[Serializable]
	public class ACPanelRuleData
	{
		private System.Guid _aCPanelPK;
		private System.Int32 _unitID;
		private System.Guid _bDBuildingPK;
		private System.String _serialNumber;
		private System.String _panelName;
		private System.Int16 _bufferSize;
		private System.Boolean _dialUp;
		private System.String _unitPhone;
		private System.String _unitPhoneCallerID;
		private System.String _unitExt;
		private System.Boolean _longDistance;
		private System.String _modemInitString;
		private System.Int32 _baudRate;
		private System.String _historyPhone;
		private System.String _alarmPhone1;
		private System.String _alarmPhone2;
		private System.String _dialingPrefixPanel;
		private System.String _dialingSuffixPanel;
		private System.Boolean _dialOutEnabled;
		private System.Boolean _dayLightSaving;
		private System.Boolean _onSiteMonitor;
		private System.Byte _centralDelay;
		private System.Byte _elevPulse;
		private System.Int32 _panelTypeID;
		private System.Int16 _unbufferTC;
		private System.Int16 _mandatoryUnbufferTC;
		private System.Int16 _swingerCount;
		private System.Int16 _swingerTime;
		private System.Byte _loopNumb;
		private System.Byte _portNumb;
		private System.String _notes;
		private System.Boolean _trouble;
		private System.Boolean _noVersionCheck;
		private System.DateTime _createdOn;
		private System.String _createdBy;
		private System.DateTime _modifiedOn;
		private System.String _modifiedBy;
		private System.Guid _deviceId;
		private System.Int32 _dBSyncSeconds;
		private System.Int32 _dBSaveMinutes;
		private System.Boolean _isE150;
		private System.Byte _groupID;
		private System.Boolean _noAutoDownload;
		private System.DateTime _noAutoDownloadStart;
		private System.Boolean _locked;
		private System.Boolean _inDebug;
		private System.String _address1;
		private System.Int32 _buildingID;

		public System.Guid ACPanelPK
		{
			get { return this._aCPanelPK; }
			set { this._aCPanelPK = value; }
		}

		public System.Int32 UnitID
		{
			get { return this._unitID; }
			set { this._unitID = value; }
		}

		public System.Guid BDBuildingPK
		{
			get { return this._bDBuildingPK; }
			set { this._bDBuildingPK = value; }
		}

		public System.String SerialNumber
		{
			get { return this._serialNumber; }
			set { this._serialNumber = value; }
		}

		public System.String PanelName
		{
			get { return this._panelName; }
			set { this._panelName = value; }
		}

		public System.Int16 BufferSize
		{
			get { return this._bufferSize; }
			set { this._bufferSize = value; }
		}

		public System.Boolean DialUp
		{
			get { return this._dialUp; }
			set { this._dialUp = value; }
		}

		public System.String UnitPhone
		{
			get { return this._unitPhone; }
			set { this._unitPhone = value; }
		}

		public System.String UnitPhoneCallerID
		{
			get { return this._unitPhoneCallerID; }
			set { this._unitPhoneCallerID = value; }
		}

		public System.String UnitExt
		{
			get { return this._unitExt; }
			set { this._unitExt = value; }
		}

		public System.Boolean LongDistance
		{
			get { return this._longDistance; }
			set { this._longDistance = value; }
		}

		public System.String ModemInitString
		{
			get { return this._modemInitString; }
			set { this._modemInitString = value; }
		}

		public System.Int32 BaudRate
		{
			get { return this._baudRate; }
			set { this._baudRate = value; }
		}

		public System.String HistoryPhone
		{
			get { return this._historyPhone; }
			set { this._historyPhone = value; }
		}

		public System.String AlarmPhone1
		{
			get { return this._alarmPhone1; }
			set { this._alarmPhone1 = value; }
		}

		public System.String AlarmPhone2
		{
			get { return this._alarmPhone2; }
			set { this._alarmPhone2 = value; }
		}

		public System.String DialingPrefixPanel
		{
			get { return this._dialingPrefixPanel; }
			set { this._dialingPrefixPanel = value; }
		}

		public System.String DialingSuffixPanel
		{
			get { return this._dialingSuffixPanel; }
			set { this._dialingSuffixPanel = value; }
		}

		public System.Boolean DialOutEnabled
		{
			get { return this._dialOutEnabled; }
			set { this._dialOutEnabled = value; }
		}

		public System.Boolean DayLightSaving
		{
			get { return this._dayLightSaving; }
			set { this._dayLightSaving = value; }
		}

		public System.Boolean OnSiteMonitor
		{
			get { return this._onSiteMonitor; }
			set { this._onSiteMonitor = value; }
		}

		public System.Byte CentralDelay
		{
			get { return this._centralDelay; }
			set { this._centralDelay = value; }
		}

		public System.Byte ElevPulse
		{
			get { return this._elevPulse; }
			set { this._elevPulse = value; }
		}

		public System.Int32 PanelTypeID
		{
			get { return this._panelTypeID; }
			set { this._panelTypeID = value; }
		}

		public System.Int16 UnbufferTC
		{
			get { return this._unbufferTC; }
			set { this._unbufferTC = value; }
		}

		public System.Int16 MandatoryUnbufferTC
		{
			get { return this._mandatoryUnbufferTC; }
			set { this._mandatoryUnbufferTC = value; }
		}

		public System.Int16 SwingerCount
		{
			get { return this._swingerCount; }
			set { this._swingerCount = value; }
		}

		public System.Int16 SwingerTime
		{
			get { return this._swingerTime; }
			set { this._swingerTime = value; }
		}

		public System.Byte LoopNumb
		{
			get { return this._loopNumb; }
			set { this._loopNumb = value; }
		}

		public System.Byte PortNumb
		{
			get { return this._portNumb; }
			set { this._portNumb = value; }
		}

		public System.String Notes
		{
			get { return this._notes; }
			set { this._notes = value; }
		}

		public System.Boolean Trouble
		{
			get { return this._trouble; }
			set { this._trouble = value; }
		}

		public System.Boolean NoVersionCheck
		{
			get { return this._noVersionCheck; }
			set { this._noVersionCheck = value; }
		}

		public System.DateTime CreatedOn
		{
			get { return this._createdOn; }
			set { this._createdOn = value; }
		}

		public System.String CreatedBy
		{
			get { return this._createdBy; }
			set { this._createdBy = value; }
		}

		public System.DateTime ModifiedOn
		{
			get { return this._modifiedOn; }
			set { this._modifiedOn = value; }
		}

		public System.String ModifiedBy
		{
			get { return this._modifiedBy; }
			set { this._modifiedBy = value; }
		}

		public System.Guid DeviceId
		{
			get { return this._deviceId; }
			set { this._deviceId = value; }
		}

		public System.Int32 DBSyncSeconds
		{
			get { return this._dBSyncSeconds; }
			set { this._dBSyncSeconds = value; }
		}

		public System.Int32 DBSaveMinutes
		{
			get { return this._dBSaveMinutes; }
			set { this._dBSaveMinutes = value; }
		}

		public System.Boolean IsE150
		{
			get { return this._isE150; }
			set { this._isE150 = value; }
		}

		public System.Byte GroupID
		{
			get { return this._groupID; }
			set { this._groupID = value; }
		}

		public System.Boolean NoAutoDownload
		{
			get { return this._noAutoDownload; }
			set { this._noAutoDownload = value; }
		}

		public System.DateTime NoAutoDownloadStart
		{
			get { return this._noAutoDownloadStart; }
			set { this._noAutoDownloadStart = value; }
		}

		public System.Boolean Locked
		{
			get { return this._locked; }
			set { this._locked = value; }
		}

		public System.Boolean InDebug
		{
			get { return this._inDebug; }
			set { this._inDebug = value; }
		}

		public System.String Address1
		{
			get { return this._address1; }
			set { this._address1 = value; }
		}

		public System.Int32 BuildingID
		{
			get { return this._buildingID; }
			set { this._buildingID = value; }
		}

	}
	[Serializable]
	public class UsrAccountDBRuleRuleData
	{
		private System.Guid _usrAccountDBRulePK;
		private System.Guid _usrAccountPK;
		private System.Int32 _dBRuleID;
		private System.Boolean _selectable;
		private System.Boolean _insertable;
		private System.Boolean _editable;
		private System.Boolean _deletable;
		private System.DateTime _createdOn;
		private System.String _createdBy;
		private System.DateTime _modifiedOn;
		private System.String _modifiedBy;
		private System.String _userID;

		public System.Guid UsrAccountDBRulePK
		{
			get { return this._usrAccountDBRulePK; }
			set { this._usrAccountDBRulePK = value; }
		}

		public System.Guid UsrAccountPK
		{
			get { return this._usrAccountPK; }
			set { this._usrAccountPK = value; }
		}

		public System.Int32 DBRuleID
		{
			get { return this._dBRuleID; }
			set { this._dBRuleID = value; }
		}

		public System.Boolean Selectable
		{
			get { return this._selectable; }
			set { this._selectable = value; }
		}

		public System.Boolean Insertable
		{
			get { return this._insertable; }
			set { this._insertable = value; }
		}

		public System.Boolean Editable
		{
			get { return this._editable; }
			set { this._editable = value; }
		}

		public System.Boolean Deletable
		{
			get { return this._deletable; }
			set { this._deletable = value; }
		}

		public System.DateTime CreatedOn
		{
			get { return this._createdOn; }
			set { this._createdOn = value; }
		}

		public System.String CreatedBy
		{
			get { return this._createdBy; }
			set { this._createdBy = value; }
		}

		public System.DateTime ModifiedOn
		{
			get { return this._modifiedOn; }
			set { this._modifiedOn = value; }
		}

		public System.String ModifiedBy
		{
			get { return this._modifiedBy; }
			set { this._modifiedBy = value; }
		}

		public System.String UserID
		{
			get { return this._userID; }
			set { this._userID = value; }
		}

	}
	[Serializable]
	public class UsrGroupBRRuleRuleData
	{
		private System.Guid _usrGroupBRRule;
		private System.Guid _usrGroupPK;
		private System.Int32 _bRRuleID;
		private System.Boolean _denied;
		private System.DateTime _createdOn;
		private System.String _createdBy;
		private System.DateTime _modifiedOn;
		private System.String _modifiedBy;
		private System.String _usrGroupName;

		public System.Guid UsrGroupBRRule
		{
			get { return this._usrGroupBRRule; }
			set { this._usrGroupBRRule = value; }
		}

		public System.Guid UsrGroupPK
		{
			get { return this._usrGroupPK; }
			set { this._usrGroupPK = value; }
		}

		public System.Int32 BRRuleID
		{
			get { return this._bRRuleID; }
			set { this._bRRuleID = value; }
		}

		public System.Boolean Denied
		{
			get { return this._denied; }
			set { this._denied = value; }
		}

		public System.DateTime CreatedOn
		{
			get { return this._createdOn; }
			set { this._createdOn = value; }
		}

		public System.String CreatedBy
		{
			get { return this._createdBy; }
			set { this._createdBy = value; }
		}

		public System.DateTime ModifiedOn
		{
			get { return this._modifiedOn; }
			set { this._modifiedOn = value; }
		}

		public System.String ModifiedBy
		{
			get { return this._modifiedBy; }
			set { this._modifiedBy = value; }
		}

		public System.String UsrGroupName
		{
			get { return this._usrGroupName; }
			set { this._usrGroupName = value; }
		}

	}
	[Serializable]
	public class ACInputGroupInputMapRuleData
	{
		private System.Guid _aCInputGroupInputMapPK;
		private System.Guid _aCInputGroupPK;
		private System.Guid _aCInputPK;
		private System.DateTime _createdOn;
		private System.String _createdBy;
		private System.DateTime _modifiedOn;
		private System.String _modifiedBy;
		private System.Byte _groupID;
		private System.Guid _aCPanelPK;
		private System.Byte _inputID;
		private System.Int32 _unitID;
		private System.String _address1;
		private System.Int32 _buildingID;
		private System.Guid _bDBuildingPK;

		public System.Guid ACInputGroupInputMapPK
		{
			get { return this._aCInputGroupInputMapPK; }
			set { this._aCInputGroupInputMapPK = value; }
		}

		public System.Guid ACInputGroupPK
		{
			get { return this._aCInputGroupPK; }
			set { this._aCInputGroupPK = value; }
		}

		public System.Guid ACInputPK
		{
			get { return this._aCInputPK; }
			set { this._aCInputPK = value; }
		}

		public System.DateTime CreatedOn
		{
			get { return this._createdOn; }
			set { this._createdOn = value; }
		}

		public System.String CreatedBy
		{
			get { return this._createdBy; }
			set { this._createdBy = value; }
		}

		public System.DateTime ModifiedOn
		{
			get { return this._modifiedOn; }
			set { this._modifiedOn = value; }
		}

		public System.String ModifiedBy
		{
			get { return this._modifiedBy; }
			set { this._modifiedBy = value; }
		}

		public System.Byte GroupID
		{
			get { return this._groupID; }
			set { this._groupID = value; }
		}

		public System.Guid ACPanelPK
		{
			get { return this._aCPanelPK; }
			set { this._aCPanelPK = value; }
		}

		public System.Byte InputID
		{
			get { return this._inputID; }
			set { this._inputID = value; }
		}

		public System.Int32 UnitID
		{
			get { return this._unitID; }
			set { this._unitID = value; }
		}

		public System.String Address1
		{
			get { return this._address1; }
			set { this._address1 = value; }
		}

		public System.Int32 BuildingID
		{
			get { return this._buildingID; }
			set { this._buildingID = value; }
		}

		public System.Guid BDBuildingPK
		{
			get { return this._bDBuildingPK; }
			set { this._bDBuildingPK = value; }
		}

	}
	[Serializable]
	public class UsrAccountBRRuleRuleData
	{
		private System.Guid _usrAccountBRRulePK;
		private System.Guid _usrAccountPK;
		private System.Int32 _bRRuleID;
		private System.Boolean _denied;
		private System.DateTime _createdOn;
		private System.String _createdBy;
		private System.DateTime _modifiedOn;
		private System.String _modifiedBy;
		private System.String _userID;

		public System.Guid UsrAccountBRRulePK
		{
			get { return this._usrAccountBRRulePK; }
			set { this._usrAccountBRRulePK = value; }
		}

		public System.Guid UsrAccountPK
		{
			get { return this._usrAccountPK; }
			set { this._usrAccountPK = value; }
		}

		public System.Int32 BRRuleID
		{
			get { return this._bRRuleID; }
			set { this._bRRuleID = value; }
		}

		public System.Boolean Denied
		{
			get { return this._denied; }
			set { this._denied = value; }
		}

		public System.DateTime CreatedOn
		{
			get { return this._createdOn; }
			set { this._createdOn = value; }
		}

		public System.String CreatedBy
		{
			get { return this._createdBy; }
			set { this._createdBy = value; }
		}

		public System.DateTime ModifiedOn
		{
			get { return this._modifiedOn; }
			set { this._modifiedOn = value; }
		}

		public System.String ModifiedBy
		{
			get { return this._modifiedBy; }
			set { this._modifiedBy = value; }
		}

		public System.String UserID
		{
			get { return this._userID; }
			set { this._userID = value; }
		}

	}
	[Serializable]
	public class UsrAccountTenantMapRuleData
	{
		private System.Guid _usrAccountTenantMapPK;
		private System.Guid _usrAccountPK;
		private System.Guid _bDTenantPK;
		private System.DateTime _createdOn;
		private System.String _createdBy;
		private System.DateTime _modifiedOn;
		private System.String _modifiedBy;
		private System.String _tenant;
		private System.Guid _bDBuildingPK;
		private System.String _userID;
		private System.String _address1;
		private System.Int32 _buildingID;

		public System.Guid UsrAccountTenantMapPK
		{
			get { return this._usrAccountTenantMapPK; }
			set { this._usrAccountTenantMapPK = value; }
		}

		public System.Guid UsrAccountPK
		{
			get { return this._usrAccountPK; }
			set { this._usrAccountPK = value; }
		}

		public System.Guid BDTenantPK
		{
			get { return this._bDTenantPK; }
			set { this._bDTenantPK = value; }
		}

		public System.DateTime CreatedOn
		{
			get { return this._createdOn; }
			set { this._createdOn = value; }
		}

		public System.String CreatedBy
		{
			get { return this._createdBy; }
			set { this._createdBy = value; }
		}

		public System.DateTime ModifiedOn
		{
			get { return this._modifiedOn; }
			set { this._modifiedOn = value; }
		}

		public System.String ModifiedBy
		{
			get { return this._modifiedBy; }
			set { this._modifiedBy = value; }
		}

		public System.String Tenant
		{
			get { return this._tenant; }
			set { this._tenant = value; }
		}

		public System.Guid BDBuildingPK
		{
			get { return this._bDBuildingPK; }
			set { this._bDBuildingPK = value; }
		}

		public System.String UserID
		{
			get { return this._userID; }
			set { this._userID = value; }
		}

		public System.String Address1
		{
			get { return this._address1; }
			set { this._address1 = value; }
		}

		public System.Int32 BuildingID
		{
			get { return this._buildingID; }
			set { this._buildingID = value; }
		}

	}

	public partial class RuleBase
	{
		protected virtual string CreateRule(string key, string rule)
		{
			return string.Format("[{0}]: {1};", key, rule);
		}

		protected virtual string BrokenNotEmptyRule(string key, string value)
		{
			if(string.IsNullOrEmpty(value))
				return this.CreateRule(key, "It can't be empty");

			return string.Empty;
		}

		protected virtual string BrokenNotEmptyRule(string key, Guid value)
		{
			if(value == Guid.Empty)
				return this.CreateRule(key, "It can't be empty");

			return string.Empty;
		}

		protected virtual string BrokenMaxLengthRule(string key, int maxLength, string value)
		{
			if(value.Length > maxLength)
				return this.CreateRule(key, string.Format("It was too long, the maximum length is {0} characters", maxLength));

			return string.Empty;
		}

		protected virtual string BrokenLengthEqualRule(string key, int length, string value)
		{
			if(value.Length > 0 && value.Length != length)
				return this.CreateRule(key, string.Format("The length is not equal to {0}", length));

			return string.Empty;
		}

		protected virtual string BrokenGreaterThanOrEqualToRule(string key, int value, int target)
		{
			return value < target ? this.CreateRule(key, String.Format("It can't be less than {0}.", target)) : string.Empty;
		}

		protected virtual string BrokenGreaterThanOrEqualToRule(string key, decimal value, int target)
		{
			return value < target ? this.CreateRule(key, String.Format("It can't be less than {0}.", target)) : string.Empty;
		}

		protected virtual string BrokenGreaterThanRule(string key, int value, int target)
		{
			return value <= target ? this.CreateRule(key, String.Format("It can't be less than or equal to {0}.", target)) : string.Empty;
		}

		protected virtual string BrokenGreaterThanRule(string key, decimal value, int target)
		{
			return value <= target ? this.CreateRule(key, String.Format("It can't be less than or equal to {0}.", target)) : string.Empty;
		}

		protected virtual string BrokenLessThanOrEqualToRule(string key, decimal value, int target)
		{
			return value > target ? this.CreateRule(key, String.Format("It can't be greater than {0}.", target)) : string.Empty;
		}

		protected virtual string BrokenLessThanOrEqualToRule(string key, int value, int target)
		{
			return value > target ? this.CreateRule(key, String.Format("It can't be greater than {0}.", target)) : string.Empty;
		}

		protected virtual string BrokenLessThanRule(string key, int value, int target)
		{
			return value >= target ? this.CreateRule(key, String.Format("It can't be greater than or equal to {0}.", target)) : string.Empty;
		}

		protected virtual string BrokenLessThanRule(string key, decimal value, int target)
		{
			return value >= target ? this.CreateRule(key, String.Format("It can't be greater than or equal to {0}.", target)) : string.Empty;
		}

		protected virtual string BrokenBeginTimeBeforeEndTimeRule(string key, DateTime begin, DateTime end)
		{
			return begin > end ? this.CreateRule(key, "The beginning date must be before the end date.") : string.Empty;
		}
		protected virtual string BrokenGreaterThanOrEqualToRule(string key, string value, int target)
		{
			string rule = this.BrokenDigitsOnlyRule(key, value);
			if (rule.Length > 0)
				return rule;

			return int.Parse(value) < target ? this.CreateRule(key, String.Format("It can't be less than {0}.", target)) : string.Empty;
		}

		protected virtual string BrokenGreaterThanRule(string key, string value, int target)
		{
			string rule = this.BrokenDigitsOnlyRule(key, value);
			if (rule.Length > 0)
				return rule;

			return int.Parse(value) <= target ? this.CreateRule(key, String.Format("It can't be less than or equal to {0}.", target)) : string.Empty;
		}

		protected virtual string BrokenLessThanOrEqualToRule(string key, string value, int target)
		{
			string rule = this.BrokenDigitsOnlyRule(key, value);
			if (rule.Length > 0)
				return rule;

			return int.Parse(value) > target ? this.CreateRule(key, String.Format("It can't be greater than {0}.", target)) : string.Empty;
		}

		protected virtual string BrokenLessThanRule(string key, string value, int target)
		{
			string rule = this.BrokenDigitsOnlyRule(key, value);
			if (rule.Length > 0)
				return rule;

			return int.Parse(value) >= target ? this.CreateRule(key, String.Format("It can't be greater than or equal to {0}.", target)) : string.Empty;
		}

		protected virtual string BrokenBeginTimeBeforeEndTimeRule(string key, string begin, string end)
		{
			int beginTime = this.TimeToMinute(begin);
			int endTime = this.TimeToMinute(end);

			if (beginTime == -1 || endTime == -1)
				return this.CreateRule(key, "The begin time and end time must be between 0000 and 2359");

			return beginTime > endTime ? this.CreateRule(key, "The begin time must be before the end time.") : string.Empty;
		}

		protected virtual string BrokenValidTimeRule(string key, string time)
		{
			return this.TimeToMinute(time) == -1 ? this.CreateRule(key, "It must be between 0000 and 2359.") : string.Empty;
		}

		protected virtual string BrokenDigitsOnlyRule(string key, string value)
		{
			return this.IsDigits(value) ? this.CreateRule(key, "It can only contain digits.") : string.Empty;
		}

		#region Helper Function

		protected int TimeToMinute(string time)
		{
			if (time.Length != 4)
				return -1;

			int hour;
			if (!int.TryParse(time.Substring(0, 2), out hour))
				return -1;

			if (hour < 0 || hour > 24)
				return -1;

			int minute;
			if (!int.TryParse(time.Substring(2), out minute))
				return -1;

			if (minute < 0 || minute > 59)
				return -1;

			if (hour == 24 && minute != 0)
				return -1;

			return hour * 60 + minute;
		}

		protected bool IsDigits(string value)
		{
			for (int i = 0; i < value.Length; i++)
			{
				if (!char.IsDigit(value[i]))
					return false;
			}

			return true;
		}

		#endregion
	}

	public class ACIntvalHolidayMapDataRule : RuleBase
	{
		public string CheckRules(ACIntvalHolidayMapRuleData data)
		{
			StringBuilder builder = new StringBuilder();

			string rule;
			rule = this.CheckACIntvalHolidayMapPK(data.ACIntvalHolidayMapPK);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckACIntervalPK(data.ACIntervalPK);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckUtilHolidayPK(data.UtilHolidayPK);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckEnd(data.End);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckBegin(data.Begin);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckIVID(data.IVID);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckBDBuildingPK(data.BDBuildingPK);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckDate(data.Date);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckHoliday(data.Holiday);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckAddress1(data.Address1);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckBuildingID(data.BuildingID);
			if (rule.Length > 0)
				builder.AppendLine(rule);


			rule = this.CheckComprehensiveRules(data);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			return builder.ToString();
		}

		protected virtual string CheckComprehensiveRules(ACIntvalHolidayMapRuleData data)
		{
			return string.Empty;
		}

		#region Property Rules
		public virtual string CheckACIntvalHolidayMapPK(System.Guid value)
		{
			string rule;
			rule = this.BrokenNotEmptyRule(this.ACIntvalHolidayMapPK, value);
			if(rule.Length > 0)
				return rule;

			return string.Empty;
		}

		public virtual string CheckACIntervalPK(System.Guid value)
		{
			string rule;
			rule = this.BrokenNotEmptyRule(this.ACIntervalPK, value);
			if(rule.Length > 0)
				return rule;

			return string.Empty;
		}

		public virtual string CheckUtilHolidayPK(System.Guid value)
		{
			string rule;
			rule = this.BrokenNotEmptyRule(this.UtilHolidayPK, value);
			if(rule.Length > 0)
				return rule;

			return string.Empty;
		}

		public virtual string CheckEnd(System.String value)
		{
			string rule;
			rule = this.BrokenLengthEqualRule(this.End, 4, value);
			if(rule.Length > 0)
				return rule;

			rule = this.BrokenMaxLengthRule(this.End, 4, value);
			if(rule.Length > 0)
				return rule;

			return string.Empty;
		}

		public virtual string CheckBegin(System.String value)
		{
			string rule;
			rule = this.BrokenLengthEqualRule(this.Begin, 4, value);
			if(rule.Length > 0)
				return rule;

			rule = this.BrokenMaxLengthRule(this.Begin, 4, value);
			if(rule.Length > 0)
				return rule;

			return string.Empty;
		}

		public virtual string CheckIVID(System.Int16 value)
		{
			return string.Empty;
		}

		public virtual string CheckBDBuildingPK(System.Guid value)
		{
			string rule;
			rule = this.BrokenNotEmptyRule(this.BDBuildingPK, value);
			if(rule.Length > 0)
				return rule;

			return string.Empty;
		}

		public virtual string CheckDate(System.DateTime value)
		{
			return string.Empty;
		}

		public virtual string CheckHoliday(System.String value)
		{
			string rule;
			rule = this.BrokenNotEmptyRule(this.Holiday, value);
			if(rule.Length > 0)
				return rule;

			rule = this.BrokenMaxLengthRule(this.Holiday, 30, value);
			if(rule.Length > 0)
				return rule;

			return string.Empty;
		}

		public virtual string CheckAddress1(System.String value)
		{
			string rule;
			rule = this.BrokenNotEmptyRule(this.Address1, value);
			if(rule.Length > 0)
				return rule;

			rule = this.BrokenMaxLengthRule(this.Address1, 55, value);
			if(rule.Length > 0)
				return rule;

			return string.Empty;
		}

		public virtual string CheckBuildingID(System.Int32 value)
		{
			return string.Empty;
		}

		#endregion

		#region Property Names
		protected virtual string ACIntvalHolidayMapPK
		{
			get { return "ACIntvalHolidayMapPK"; }
		}

		protected virtual string ACIntervalPK
		{
			get { return "ACIntervalPK"; }
		}

		protected virtual string UtilHolidayPK
		{
			get { return "UtilHolidayPK"; }
		}

		protected virtual string End
		{
			get { return "End"; }
		}

		protected virtual string Begin
		{
			get { return "Begin"; }
		}

		protected virtual string IVID
		{
			get { return "IVID"; }
		}

		protected virtual string BDBuildingPK
		{
			get { return "BDBuildingPK"; }
		}

		protected virtual string Date
		{
			get { return "Date"; }
		}

		protected virtual string Holiday
		{
			get { return "Holiday"; }
		}

		protected virtual string Address1
		{
			get { return "Address1"; }
		}

		protected virtual string BuildingID
		{
			get { return "BuildingID"; }
		}

		#endregion
	}

	public class ACAccessLevelDetailDataRule : RuleBase
	{
		public string CheckRules(ACAccessLevelDetailRuleData data)
		{
			StringBuilder builder = new StringBuilder();

			string rule;
			rule = this.CheckACAccessLevelDetailPK(data.ACAccessLevelDetailPK);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckACAccessLevelPK(data.ACAccessLevelPK);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckACMainZonePK(data.ACMainZonePK);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckACTimecodePK(data.ACTimecodePK);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckFromACAccessLevelPK(data.FromACAccessLevelPK);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckMainZoneDescription(data.MainZoneDescription);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckMainZoneID(data.MainZoneID);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckACPanelPK(data.ACPanelPK);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckTimecodeSummary(data.TimecodeSummary);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckTCID(data.TCID);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckALSummary(data.ALSummary);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckAccessLevelID(data.AccessLevelID);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckBDBuildingPK(data.BDBuildingPK);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckUnitID(data.UnitID);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckAddress1(data.Address1);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckBuildingID(data.BuildingID);
			if (rule.Length > 0)
				builder.AppendLine(rule);


			rule = this.CheckComprehensiveRules(data);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			return builder.ToString();
		}

		protected virtual string CheckComprehensiveRules(ACAccessLevelDetailRuleData data)
		{
			return string.Empty;
		}

		#region Property Rules
		public virtual string CheckACAccessLevelDetailPK(System.Guid value)
		{
			string rule;
			rule = this.BrokenNotEmptyRule(this.ACAccessLevelDetailPK, value);
			if(rule.Length > 0)
				return rule;

			return string.Empty;
		}

		public virtual string CheckACAccessLevelPK(System.Guid value)
		{
			string rule;
			rule = this.BrokenNotEmptyRule(this.ACAccessLevelPK, value);
			if(rule.Length > 0)
				return rule;

			return string.Empty;
		}

		public virtual string CheckACMainZonePK(System.Guid value)
		{
			string rule;
			rule = this.BrokenNotEmptyRule(this.ACMainZonePK, value);
			if(rule.Length > 0)
				return rule;

			return string.Empty;
		}

		public virtual string CheckACTimecodePK(System.Guid value)
		{
			string rule;
			rule = this.BrokenNotEmptyRule(this.ACTimecodePK, value);
			if(rule.Length > 0)
				return rule;

			return string.Empty;
		}

		public virtual string CheckFromACAccessLevelPK(System.Guid value)
		{
			string rule;
			return string.Empty;
		}

		public virtual string CheckMainZoneDescription(System.String value)
		{
			string rule;
			rule = this.BrokenNotEmptyRule(this.MainZoneDescription, value);
			if(rule.Length > 0)
				return rule;

			rule = this.BrokenMaxLengthRule(this.MainZoneDescription, 30, value);
			if(rule.Length > 0)
				return rule;

			return string.Empty;
		}

		public virtual string CheckMainZoneID(System.Byte value)
		{
			return string.Empty;
		}

		public virtual string CheckACPanelPK(System.Guid value)
		{
			string rule;
			rule = this.BrokenNotEmptyRule(this.ACPanelPK, value);
			if(rule.Length > 0)
				return rule;

			return string.Empty;
		}

		public virtual string CheckTimecodeSummary(System.String value)
		{
			string rule;
			rule = this.BrokenNotEmptyRule(this.TimecodeSummary, value);
			if(rule.Length > 0)
				return rule;

			rule = this.BrokenMaxLengthRule(this.TimecodeSummary, 256, value);
			if(rule.Length > 0)
				return rule;

			return string.Empty;
		}

		public virtual string CheckTCID(System.Int16 value)
		{
			return string.Empty;
		}

		public virtual string CheckALSummary(System.String value)
		{
			string rule;
			rule = this.BrokenNotEmptyRule(this.ALSummary, value);
			if(rule.Length > 0)
				return rule;

			rule = this.BrokenMaxLengthRule(this.ALSummary, 256, value);
			if(rule.Length > 0)
				return rule;

			return string.Empty;
		}

		public virtual string CheckAccessLevelID(System.Int16 value)
		{
			return string.Empty;
		}

		public virtual string CheckBDBuildingPK(System.Guid value)
		{
			string rule;
			rule = this.BrokenNotEmptyRule(this.BDBuildingPK, value);
			if(rule.Length > 0)
				return rule;

			return string.Empty;
		}

		public virtual string CheckUnitID(System.Int32 value)
		{
			return string.Empty;
		}

		public virtual string CheckAddress1(System.String value)
		{
			string rule;
			rule = this.BrokenNotEmptyRule(this.Address1, value);
			if(rule.Length > 0)
				return rule;

			rule = this.BrokenMaxLengthRule(this.Address1, 55, value);
			if(rule.Length > 0)
				return rule;

			return string.Empty;
		}

		public virtual string CheckBuildingID(System.Int32 value)
		{
			return string.Empty;
		}

		#endregion

		#region Property Names
		protected virtual string ACAccessLevelDetailPK
		{
			get { return "ACAccessLevelDetailPK"; }
		}

		protected virtual string ACAccessLevelPK
		{
			get { return "ACAccessLevelPK"; }
		}

		protected virtual string ACMainZonePK
		{
			get { return "ACMainZonePK"; }
		}

		protected virtual string ACTimecodePK
		{
			get { return "ACTimecodePK"; }
		}

		protected virtual string FromACAccessLevelPK
		{
			get { return "FromACAccessLevelPK"; }
		}

		protected virtual string MainZoneDescription
		{
			get { return "MainZoneDescription"; }
		}

		protected virtual string MainZoneID
		{
			get { return "MainZoneID"; }
		}

		protected virtual string ACPanelPK
		{
			get { return "ACPanelPK"; }
		}

		protected virtual string TimecodeSummary
		{
			get { return "TimecodeSummary"; }
		}

		protected virtual string TCID
		{
			get { return "TCID"; }
		}

		protected virtual string ALSummary
		{
			get { return "ALSummary"; }
		}

		protected virtual string AccessLevelID
		{
			get { return "AccessLevelID"; }
		}

		protected virtual string BDBuildingPK
		{
			get { return "BDBuildingPK"; }
		}

		protected virtual string UnitID
		{
			get { return "UnitID"; }
		}

		protected virtual string Address1
		{
			get { return "Address1"; }
		}

		protected virtual string BuildingID
		{
			get { return "BuildingID"; }
		}

		#endregion
	}

	public class UsrAccountBuildingMapDataRule : RuleBase
	{
		public string CheckRules(UsrAccountBuildingMapRuleData data)
		{
			StringBuilder builder = new StringBuilder();

			string rule;
			rule = this.CheckUsrAccountBuildingMapPK(data.UsrAccountBuildingMapPK);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckUsrAccountPK(data.UsrAccountPK);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckBDBuildingPK(data.BDBuildingPK);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckBuildingWide(data.BuildingWide);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckAccessTC(data.AccessTC);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckPermission(data.Permission);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckPrimary(data.Primary);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckAddress1(data.Address1);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckBuildingID(data.BuildingID);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckUserID(data.UserID);
			if (rule.Length > 0)
				builder.AppendLine(rule);


			rule = this.CheckComprehensiveRules(data);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			return builder.ToString();
		}

		protected virtual string CheckComprehensiveRules(UsrAccountBuildingMapRuleData data)
		{
			return string.Empty;
		}

		#region Property Rules
		public virtual string CheckUsrAccountBuildingMapPK(System.Guid value)
		{
			string rule;
			rule = this.BrokenNotEmptyRule(this.UsrAccountBuildingMapPK, value);
			if(rule.Length > 0)
				return rule;

			return string.Empty;
		}

		public virtual string CheckUsrAccountPK(System.Guid value)
		{
			string rule;
			rule = this.BrokenNotEmptyRule(this.UsrAccountPK, value);
			if(rule.Length > 0)
				return rule;

			return string.Empty;
		}

		public virtual string CheckBDBuildingPK(System.Guid value)
		{
			string rule;
			rule = this.BrokenNotEmptyRule(this.BDBuildingPK, value);
			if(rule.Length > 0)
				return rule;

			return string.Empty;
		}

		public virtual string CheckBuildingWide(System.Boolean value)
		{
			return string.Empty;
		}

		public virtual string CheckAccessTC(System.Int16 value)
		{
			return string.Empty;
		}

		public virtual string CheckPermission(System.Int32 value)
		{
			return string.Empty;
		}

		public virtual string CheckPrimary(System.Boolean value)
		{
			return string.Empty;
		}

		public virtual string CheckAddress1(System.String value)
		{
			string rule;
			rule = this.BrokenNotEmptyRule(this.Address1, value);
			if(rule.Length > 0)
				return rule;

			rule = this.BrokenMaxLengthRule(this.Address1, 55, value);
			if(rule.Length > 0)
				return rule;

			return string.Empty;
		}

		public virtual string CheckBuildingID(System.Int32 value)
		{
			return string.Empty;
		}

		public virtual string CheckUserID(System.String value)
		{
			string rule;
			rule = this.BrokenNotEmptyRule(this.UserID, value);
			if(rule.Length > 0)
				return rule;

			rule = this.BrokenMaxLengthRule(this.UserID, 30, value);
			if(rule.Length > 0)
				return rule;

			return string.Empty;
		}

		#endregion

		#region Property Names
		protected virtual string UsrAccountBuildingMapPK
		{
			get { return "UsrAccountBuildingMapPK"; }
		}

		protected virtual string UsrAccountPK
		{
			get { return "UsrAccountPK"; }
		}

		protected virtual string BDBuildingPK
		{
			get { return "BDBuildingPK"; }
		}

		protected virtual string BuildingWide
		{
			get { return "BuildingWide"; }
		}

		protected virtual string AccessTC
		{
			get { return "AccessTC"; }
		}

		protected virtual string Permission
		{
			get { return "Permission"; }
		}

		protected virtual string Primary
		{
			get { return "Primary"; }
		}

		protected virtual string Address1
		{
			get { return "Address1"; }
		}

		protected virtual string BuildingID
		{
			get { return "BuildingID"; }
		}

		protected virtual string UserID
		{
			get { return "UserID"; }
		}

		#endregion
	}

	public class BDBuildingDataRule : RuleBase
	{
		public string CheckRules(BDBuildingRuleData data)
		{
			StringBuilder builder = new StringBuilder();

			string rule;
			rule = this.CheckBDBuildingPK(data.BDBuildingPK);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckBuildingID(data.BuildingID);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckBuildingName(data.BuildingName);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckAddress1(data.Address1);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckStreetNumb(data.StreetNumb);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckStreetName(data.StreetName);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckAddress2(data.Address2);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckCity(data.City);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckState(data.State);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckZipcode(data.Zipcode);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckCounty(data.County);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckTimezoneID(data.TimezoneID);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckFederal(data.Federal);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckPhone(data.Phone);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckFax(data.Fax);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckBldgNotes(data.BldgNotes);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckCardNotes(data.CardNotes);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckElevTrapNotes(data.ElevTrapNotes);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckVisitorNotes(data.VisitorNotes);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckSystemTypeID(data.SystemTypeID);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckCountryID(data.CountryID);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckVisitorSiteCode(data.VisitorSiteCode);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckWinUITypeID(data.WinUITypeID);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckLastExportParkingTag(data.LastExportParkingTag);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckAutoIssueNotifyEmail(data.AutoIssueNotifyEmail);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckCardKeyMode(data.CardKeyMode);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckAccessLevelMode(data.AccessLevelMode);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckHotClient(data.HotClient);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckHotExpire(data.HotExpire);
			if (rule.Length > 0)
				builder.AppendLine(rule);


			rule = this.CheckComprehensiveRules(data);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			return builder.ToString();
		}

		protected virtual string CheckComprehensiveRules(BDBuildingRuleData data)
		{
			return string.Empty;
		}

		#region Property Rules
		public virtual string CheckBDBuildingPK(System.Guid value)
		{
			string rule;
			rule = this.BrokenNotEmptyRule(this.BDBuildingPK, value);
			if(rule.Length > 0)
				return rule;

			return string.Empty;
		}

		public virtual string CheckBuildingID(System.Int32 value)
		{
			return string.Empty;
		}

		public virtual string CheckBuildingName(System.String value)
		{
			string rule;
			rule = this.BrokenMaxLengthRule(this.BuildingName, 60, value);
			if(rule.Length > 0)
				return rule;

			return string.Empty;
		}

		public virtual string CheckAddress1(System.String value)
		{
			string rule;
			rule = this.BrokenNotEmptyRule(this.Address1, value);
			if(rule.Length > 0)
				return rule;

			rule = this.BrokenMaxLengthRule(this.Address1, 55, value);
			if(rule.Length > 0)
				return rule;

			return string.Empty;
		}

		public virtual string CheckStreetNumb(System.String value)
		{
			string rule;
			rule = this.BrokenMaxLengthRule(this.StreetNumb, 50, value);
			if(rule.Length > 0)
				return rule;

			return string.Empty;
		}

		public virtual string CheckStreetName(System.String value)
		{
			string rule;
			rule = this.BrokenMaxLengthRule(this.StreetName, 50, value);
			if(rule.Length > 0)
				return rule;

			return string.Empty;
		}

		public virtual string CheckAddress2(System.String value)
		{
			string rule;
			rule = this.BrokenMaxLengthRule(this.Address2, 30, value);
			if(rule.Length > 0)
				return rule;

			return string.Empty;
		}

		public virtual string CheckCity(System.String value)
		{
			string rule;
			rule = this.BrokenNotEmptyRule(this.City, value);
			if(rule.Length > 0)
				return rule;

			rule = this.BrokenMaxLengthRule(this.City, 35, value);
			if(rule.Length > 0)
				return rule;

			return string.Empty;
		}

		public virtual string CheckState(System.String value)
		{
			string rule;
			rule = this.BrokenNotEmptyRule(this.State, value);
			if(rule.Length > 0)
				return rule;

			rule = this.BrokenLengthEqualRule(this.State, 2, value);
			if(rule.Length > 0)
				return rule;

			rule = this.BrokenMaxLengthRule(this.State, 2, value);
			if(rule.Length > 0)
				return rule;

			return string.Empty;
		}

		public virtual string CheckZipcode(System.String value)
		{
			string rule;
			rule = this.BrokenNotEmptyRule(this.Zipcode, value);
			if(rule.Length > 0)
				return rule;

			rule = this.BrokenMaxLengthRule(this.Zipcode, 10, value);
			if(rule.Length > 0)
				return rule;

			return string.Empty;
		}

		public virtual string CheckCounty(System.String value)
		{
			string rule;
			rule = this.BrokenMaxLengthRule(this.County, 35, value);
			if(rule.Length > 0)
				return rule;

			return string.Empty;
		}

		public virtual string CheckTimezoneID(System.Int32 value)
		{
			return string.Empty;
		}

		public virtual string CheckFederal(System.Boolean value)
		{
			return string.Empty;
		}

		public virtual string CheckPhone(System.String value)
		{
			string rule;
			rule = this.BrokenMaxLengthRule(this.Phone, 20, value);
			if(rule.Length > 0)
				return rule;

			return string.Empty;
		}

		public virtual string CheckFax(System.String value)
		{
			string rule;
			rule = this.BrokenMaxLengthRule(this.Fax, 20, value);
			if(rule.Length > 0)
				return rule;

			return string.Empty;
		}

		public virtual string CheckBldgNotes(System.String value)
		{
			string rule;
			rule = this.BrokenMaxLengthRule(this.BldgNotes, 2048, value);
			if(rule.Length > 0)
				return rule;

			return string.Empty;
		}

		public virtual string CheckCardNotes(System.String value)
		{
			string rule;
			rule = this.BrokenMaxLengthRule(this.CardNotes, 2048, value);
			if(rule.Length > 0)
				return rule;

			return string.Empty;
		}

		public virtual string CheckElevTrapNotes(System.String value)
		{
			string rule;
			rule = this.BrokenMaxLengthRule(this.ElevTrapNotes, 3072, value);
			if(rule.Length > 0)
				return rule;

			return string.Empty;
		}

		public virtual string CheckVisitorNotes(System.String value)
		{
			string rule;
			rule = this.BrokenMaxLengthRule(this.VisitorNotes, 2048, value);
			if(rule.Length > 0)
				return rule;

			return string.Empty;
		}

		public virtual string CheckSystemTypeID(System.Int32 value)
		{
			return string.Empty;
		}

		public virtual string CheckCountryID(System.Int32 value)
		{
			return string.Empty;
		}

		public virtual string CheckVisitorSiteCode(System.Int32 value)
		{
			return string.Empty;
		}

		public virtual string CheckWinUITypeID(System.Int32 value)
		{
			return string.Empty;
		}

		public virtual string CheckLastExportParkingTag(System.DateTime value)
		{
			return string.Empty;
		}

		public virtual string CheckAutoIssueNotifyEmail(System.String value)
		{
			string rule;
			rule = this.BrokenMaxLengthRule(this.AutoIssueNotifyEmail, 256, value);
			if(rule.Length > 0)
				return rule;

			return string.Empty;
		}

		public virtual string CheckCardKeyMode(System.Byte value)
		{
			return string.Empty;
		}

		public virtual string CheckAccessLevelMode(System.String value)
		{
			string rule;
			rule = this.BrokenMaxLengthRule(this.AccessLevelMode, 512, value);
			if(rule.Length > 0)
				return rule;

			return string.Empty;
		}

		public virtual string CheckHotClient(System.Boolean value)
		{
			return string.Empty;
		}

		public virtual string CheckHotExpire(System.DateTime value)
		{
			return string.Empty;
		}

		#endregion

		#region Property Names
		protected virtual string BDBuildingPK
		{
			get { return "BDBuildingPK"; }
		}

		protected virtual string BuildingID
		{
			get { return "BuildingID"; }
		}

		protected virtual string BuildingName
		{
			get { return "BuildingName"; }
		}

		protected virtual string Address1
		{
			get { return "Address1"; }
		}

		protected virtual string StreetNumb
		{
			get { return "StreetNumb"; }
		}

		protected virtual string StreetName
		{
			get { return "StreetName"; }
		}

		protected virtual string Address2
		{
			get { return "Address2"; }
		}

		protected virtual string City
		{
			get { return "City"; }
		}

		protected virtual string State
		{
			get { return "State"; }
		}

		protected virtual string Zipcode
		{
			get { return "Zipcode"; }
		}

		protected virtual string County
		{
			get { return "County"; }
		}

		protected virtual string TimezoneID
		{
			get { return "TimezoneID"; }
		}

		protected virtual string Federal
		{
			get { return "Federal"; }
		}

		protected virtual string Phone
		{
			get { return "Phone"; }
		}

		protected virtual string Fax
		{
			get { return "Fax"; }
		}

		protected virtual string BldgNotes
		{
			get { return "BldgNotes"; }
		}

		protected virtual string CardNotes
		{
			get { return "CardNotes"; }
		}

		protected virtual string ElevTrapNotes
		{
			get { return "ElevTrapNotes"; }
		}

		protected virtual string VisitorNotes
		{
			get { return "VisitorNotes"; }
		}

		protected virtual string SystemTypeID
		{
			get { return "SystemTypeID"; }
		}

		protected virtual string CountryID
		{
			get { return "CountryID"; }
		}

		protected virtual string VisitorSiteCode
		{
			get { return "VisitorSiteCode"; }
		}

		protected virtual string WinUITypeID
		{
			get { return "WinUITypeID"; }
		}

		protected virtual string LastExportParkingTag
		{
			get { return "LastExportParkingTag"; }
		}

		protected virtual string AutoIssueNotifyEmail
		{
			get { return "AutoIssueNotifyEmail"; }
		}

		protected virtual string CardKeyMode
		{
			get { return "CardKeyMode"; }
		}

		protected virtual string AccessLevelMode
		{
			get { return "AccessLevelMode"; }
		}

		protected virtual string HotClient
		{
			get { return "HotClient"; }
		}

		protected virtual string HotExpire
		{
			get { return "HotExpire"; }
		}

		#endregion
	}

	public class BDTenantDataRule : RuleBase
	{
		public string CheckRules(BDTenantRuleData data)
		{
			StringBuilder builder = new StringBuilder();

			string rule;
			rule = this.CheckBDTenantPK(data.BDTenantPK);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckBDBuildingPK(data.BDBuildingPK);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckTenant(data.Tenant);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckSuite(data.Suite);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckPhone(data.Phone);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckFax(data.Fax);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckBlocked(data.Blocked);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckFederal(data.Federal);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckTentNotes(data.TentNotes);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckCardNotes(data.CardNotes);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckVisitorNotes(data.VisitorNotes);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckIsManagement(data.IsManagement);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckType(data.Type);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckNoRecycleCard(data.NoRecycleCard);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckSystemTypeID(data.SystemTypeID);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckParkingAccount(data.ParkingAccount);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckCustInfo1(data.CustInfo1);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckCustInfo2(data.CustInfo2);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckCustInfo3(data.CustInfo3);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckCustInfo4(data.CustInfo4);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckCustInfo5(data.CustInfo5);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckCustInfo6(data.CustInfo6);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckCustInfo7(data.CustInfo7);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckCustInfo8(data.CustInfo8);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckDelExpiredCard(data.DelExpiredCard);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckHotClient(data.HotClient);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckHotExpire(data.HotExpire);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckEmail(data.Email);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckAddress1(data.Address1);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckBuildingID(data.BuildingID);
			if (rule.Length > 0)
				builder.AppendLine(rule);


			rule = this.CheckComprehensiveRules(data);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			return builder.ToString();
		}

		protected virtual string CheckComprehensiveRules(BDTenantRuleData data)
		{
			return string.Empty;
		}

		#region Property Rules
		public virtual string CheckBDTenantPK(System.Guid value)
		{
			string rule;
			rule = this.BrokenNotEmptyRule(this.BDTenantPK, value);
			if(rule.Length > 0)
				return rule;

			return string.Empty;
		}

		public virtual string CheckBDBuildingPK(System.Guid value)
		{
			string rule;
			rule = this.BrokenNotEmptyRule(this.BDBuildingPK, value);
			if(rule.Length > 0)
				return rule;

			return string.Empty;
		}

		public virtual string CheckTenant(System.String value)
		{
			string rule;
			rule = this.BrokenMaxLengthRule(this.Tenant, 60, value);
			if(rule.Length > 0)
				return rule;

			return string.Empty;
		}

		public virtual string CheckSuite(System.String value)
		{
			string rule;
			rule = this.BrokenNotEmptyRule(this.Suite, value);
			if(rule.Length > 0)
				return rule;

			rule = this.BrokenMaxLengthRule(this.Suite, 30, value);
			if(rule.Length > 0)
				return rule;

			return string.Empty;
		}

		public virtual string CheckPhone(System.String value)
		{
			string rule;
			rule = this.BrokenMaxLengthRule(this.Phone, 20, value);
			if(rule.Length > 0)
				return rule;

			return string.Empty;
		}

		public virtual string CheckFax(System.String value)
		{
			string rule;
			rule = this.BrokenMaxLengthRule(this.Fax, 20, value);
			if(rule.Length > 0)
				return rule;

			return string.Empty;
		}

		public virtual string CheckBlocked(System.Boolean value)
		{
			return string.Empty;
		}

		public virtual string CheckFederal(System.Boolean value)
		{
			return string.Empty;
		}

		public virtual string CheckTentNotes(System.String value)
		{
			string rule;
			rule = this.BrokenMaxLengthRule(this.TentNotes, 2048, value);
			if(rule.Length > 0)
				return rule;

			return string.Empty;
		}

		public virtual string CheckCardNotes(System.String value)
		{
			string rule;
			rule = this.BrokenMaxLengthRule(this.CardNotes, 2048, value);
			if(rule.Length > 0)
				return rule;

			return string.Empty;
		}

		public virtual string CheckVisitorNotes(System.String value)
		{
			string rule;
			rule = this.BrokenMaxLengthRule(this.VisitorNotes, 2048, value);
			if(rule.Length > 0)
				return rule;

			return string.Empty;
		}

		public virtual string CheckIsManagement(System.Boolean value)
		{
			return string.Empty;
		}

		public virtual string CheckType(System.String value)
		{
			string rule;
			rule = this.BrokenLengthEqualRule(this.Type, 1, value);
			if(rule.Length > 0)
				return rule;

			rule = this.BrokenMaxLengthRule(this.Type, 1, value);
			if(rule.Length > 0)
				return rule;

			return string.Empty;
		}

		public virtual string CheckNoRecycleCard(System.Boolean value)
		{
			return string.Empty;
		}

		public virtual string CheckSystemTypeID(System.Int32 value)
		{
			return string.Empty;
		}

		public virtual string CheckParkingAccount(System.String value)
		{
			string rule;
			rule = this.BrokenMaxLengthRule(this.ParkingAccount, 30, value);
			if(rule.Length > 0)
				return rule;

			return string.Empty;
		}

		public virtual string CheckCustInfo1(System.String value)
		{
			string rule;
			rule = this.BrokenMaxLengthRule(this.CustInfo1, 50, value);
			if(rule.Length > 0)
				return rule;

			return string.Empty;
		}

		public virtual string CheckCustInfo2(System.String value)
		{
			string rule;
			rule = this.BrokenMaxLengthRule(this.CustInfo2, 50, value);
			if(rule.Length > 0)
				return rule;

			return string.Empty;
		}

		public virtual string CheckCustInfo3(System.String value)
		{
			string rule;
			rule = this.BrokenMaxLengthRule(this.CustInfo3, 50, value);
			if(rule.Length > 0)
				return rule;

			return string.Empty;
		}

		public virtual string CheckCustInfo4(System.String value)
		{
			string rule;
			rule = this.BrokenMaxLengthRule(this.CustInfo4, 50, value);
			if(rule.Length > 0)
				return rule;

			return string.Empty;
		}

		public virtual string CheckCustInfo5(System.String value)
		{
			string rule;
			rule = this.BrokenMaxLengthRule(this.CustInfo5, 50, value);
			if(rule.Length > 0)
				return rule;

			return string.Empty;
		}

		public virtual string CheckCustInfo6(System.String value)
		{
			string rule;
			rule = this.BrokenMaxLengthRule(this.CustInfo6, 50, value);
			if(rule.Length > 0)
				return rule;

			return string.Empty;
		}

		public virtual string CheckCustInfo7(System.String value)
		{
			string rule;
			rule = this.BrokenMaxLengthRule(this.CustInfo7, 50, value);
			if(rule.Length > 0)
				return rule;

			return string.Empty;
		}

		public virtual string CheckCustInfo8(System.String value)
		{
			string rule;
			rule = this.BrokenMaxLengthRule(this.CustInfo8, 50, value);
			if(rule.Length > 0)
				return rule;

			return string.Empty;
		}

		public virtual string CheckDelExpiredCard(System.Boolean value)
		{
			return string.Empty;
		}

		public virtual string CheckHotClient(System.Boolean value)
		{
			return string.Empty;
		}

		public virtual string CheckHotExpire(System.DateTime value)
		{
			return string.Empty;
		}

		public virtual string CheckEmail(System.String value)
		{
			string rule;
			rule = this.BrokenMaxLengthRule(this.Email, 128, value);
			if(rule.Length > 0)
				return rule;

			return string.Empty;
		}

		public virtual string CheckAddress1(System.String value)
		{
			string rule;
			rule = this.BrokenNotEmptyRule(this.Address1, value);
			if(rule.Length > 0)
				return rule;

			rule = this.BrokenMaxLengthRule(this.Address1, 55, value);
			if(rule.Length > 0)
				return rule;

			return string.Empty;
		}

		public virtual string CheckBuildingID(System.Int32 value)
		{
			return string.Empty;
		}

		#endregion

		#region Property Names
		protected virtual string BDTenantPK
		{
			get { return "BDTenantPK"; }
		}

		protected virtual string BDBuildingPK
		{
			get { return "BDBuildingPK"; }
		}

		protected virtual string Tenant
		{
			get { return "Tenant"; }
		}

		protected virtual string Suite
		{
			get { return "Suite"; }
		}

		protected virtual string Phone
		{
			get { return "Phone"; }
		}

		protected virtual string Fax
		{
			get { return "Fax"; }
		}

		protected virtual string Blocked
		{
			get { return "Blocked"; }
		}

		protected virtual string Federal
		{
			get { return "Federal"; }
		}

		protected virtual string TentNotes
		{
			get { return "TentNotes"; }
		}

		protected virtual string CardNotes
		{
			get { return "CardNotes"; }
		}

		protected virtual string VisitorNotes
		{
			get { return "VisitorNotes"; }
		}

		protected virtual string IsManagement
		{
			get { return "IsManagement"; }
		}

		protected virtual string Type
		{
			get { return "Type"; }
		}

		protected virtual string NoRecycleCard
		{
			get { return "NoRecycleCard"; }
		}

		protected virtual string SystemTypeID
		{
			get { return "SystemTypeID"; }
		}

		protected virtual string ParkingAccount
		{
			get { return "ParkingAccount"; }
		}

		protected virtual string CustInfo1
		{
			get { return "CustInfo1"; }
		}

		protected virtual string CustInfo2
		{
			get { return "CustInfo2"; }
		}

		protected virtual string CustInfo3
		{
			get { return "CustInfo3"; }
		}

		protected virtual string CustInfo4
		{
			get { return "CustInfo4"; }
		}

		protected virtual string CustInfo5
		{
			get { return "CustInfo5"; }
		}

		protected virtual string CustInfo6
		{
			get { return "CustInfo6"; }
		}

		protected virtual string CustInfo7
		{
			get { return "CustInfo7"; }
		}

		protected virtual string CustInfo8
		{
			get { return "CustInfo8"; }
		}

		protected virtual string DelExpiredCard
		{
			get { return "DelExpiredCard"; }
		}

		protected virtual string HotClient
		{
			get { return "HotClient"; }
		}

		protected virtual string HotExpire
		{
			get { return "HotExpire"; }
		}

		protected virtual string Email
		{
			get { return "Email"; }
		}

		protected virtual string Address1
		{
			get { return "Address1"; }
		}

		protected virtual string BuildingID
		{
			get { return "BuildingID"; }
		}

		#endregion
	}

	public class UtilSettingCategoryDataRule : RuleBase
	{
		public string CheckRules(UtilSettingCategoryRuleData data)
		{
			StringBuilder builder = new StringBuilder();

			string rule;
			rule = this.CheckUtilSettingCategoryPK(data.UtilSettingCategoryPK);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckSettingCategoryID(data.SettingCategoryID);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckSettingCategory(data.SettingCategory);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckInstanceName(data.InstanceName);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckBDBuildingPK(data.BDBuildingPK);
			if (rule.Length > 0)
				builder.AppendLine(rule);


			rule = this.CheckComprehensiveRules(data);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			return builder.ToString();
		}

		protected virtual string CheckComprehensiveRules(UtilSettingCategoryRuleData data)
		{
			return string.Empty;
		}

		#region Property Rules
		public virtual string CheckUtilSettingCategoryPK(System.Guid value)
		{
			string rule;
			rule = this.BrokenNotEmptyRule(this.UtilSettingCategoryPK, value);
			if(rule.Length > 0)
				return rule;

			return string.Empty;
		}

		public virtual string CheckSettingCategoryID(System.Int32 value)
		{
			return string.Empty;
		}

		public virtual string CheckSettingCategory(System.String value)
		{
			string rule;
			rule = this.BrokenNotEmptyRule(this.SettingCategory, value);
			if(rule.Length > 0)
				return rule;

			rule = this.BrokenMaxLengthRule(this.SettingCategory, 128, value);
			if(rule.Length > 0)
				return rule;

			return string.Empty;
		}

		public virtual string CheckInstanceName(System.String value)
		{
			string rule;
			rule = this.BrokenMaxLengthRule(this.InstanceName, 128, value);
			if(rule.Length > 0)
				return rule;

			return string.Empty;
		}

		public virtual string CheckBDBuildingPK(System.Guid value)
		{
			string rule;
			return string.Empty;
		}

		#endregion

		#region Property Names
		protected virtual string UtilSettingCategoryPK
		{
			get { return "UtilSettingCategoryPK"; }
		}

		protected virtual string SettingCategoryID
		{
			get { return "SettingCategoryID"; }
		}

		protected virtual string SettingCategory
		{
			get { return "SettingCategory"; }
		}

		protected virtual string InstanceName
		{
			get { return "InstanceName"; }
		}

		protected virtual string BDBuildingPK
		{
			get { return "BDBuildingPK"; }
		}

		#endregion
	}

	public class UtilSettingDetailDataRule : RuleBase
	{
		public string CheckRules(UtilSettingDetailRuleData data)
		{
			StringBuilder builder = new StringBuilder();

			string rule;
			rule = this.CheckUtilSettingDetailPK(data.UtilSettingDetailPK);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckUtilSettingCategoryPK(data.UtilSettingCategoryPK);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckFieldName(data.FieldName);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckFieldValue(data.FieldValue);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckSettingCategory(data.SettingCategory);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckSettingCategoryID(data.SettingCategoryID);
			if (rule.Length > 0)
				builder.AppendLine(rule);


			rule = this.CheckComprehensiveRules(data);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			return builder.ToString();
		}

		protected virtual string CheckComprehensiveRules(UtilSettingDetailRuleData data)
		{
			return string.Empty;
		}

		#region Property Rules
		public virtual string CheckUtilSettingDetailPK(System.Guid value)
		{
			string rule;
			rule = this.BrokenNotEmptyRule(this.UtilSettingDetailPK, value);
			if(rule.Length > 0)
				return rule;

			return string.Empty;
		}

		public virtual string CheckUtilSettingCategoryPK(System.Guid value)
		{
			string rule;
			rule = this.BrokenNotEmptyRule(this.UtilSettingCategoryPK, value);
			if(rule.Length > 0)
				return rule;

			return string.Empty;
		}

		public virtual string CheckFieldName(System.String value)
		{
			string rule;
			rule = this.BrokenMaxLengthRule(this.FieldName, 128, value);
			if(rule.Length > 0)
				return rule;

			return string.Empty;
		}

		public virtual string CheckFieldValue(System.String value)
		{
			string rule;
			rule = this.BrokenMaxLengthRule(this.FieldValue, 4096, value);
			if(rule.Length > 0)
				return rule;

			return string.Empty;
		}

		public virtual string CheckSettingCategory(System.String value)
		{
			string rule;
			rule = this.BrokenNotEmptyRule(this.SettingCategory, value);
			if(rule.Length > 0)
				return rule;

			rule = this.BrokenMaxLengthRule(this.SettingCategory, 128, value);
			if(rule.Length > 0)
				return rule;

			return string.Empty;
		}

		public virtual string CheckSettingCategoryID(System.Int32 value)
		{
			return string.Empty;
		}

		#endregion

		#region Property Names
		protected virtual string UtilSettingDetailPK
		{
			get { return "UtilSettingDetailPK"; }
		}

		protected virtual string UtilSettingCategoryPK
		{
			get { return "UtilSettingCategoryPK"; }
		}

		protected virtual string FieldName
		{
			get { return "FieldName"; }
		}

		protected virtual string FieldValue
		{
			get { return "FieldValue"; }
		}

		protected virtual string SettingCategory
		{
			get { return "SettingCategory"; }
		}

		protected virtual string SettingCategoryID
		{
			get { return "SettingCategoryID"; }
		}

		#endregion
	}

	public class ACOutputGroupMainZoneMapDataRule : RuleBase
	{
		public string CheckRules(ACOutputGroupMainZoneMapRuleData data)
		{
			StringBuilder builder = new StringBuilder();

			string rule;
			rule = this.CheckACOutputGroupMainZoneMapPK(data.ACOutputGroupMainZoneMapPK);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckACOutputGroupPK(data.ACOutputGroupPK);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckACMainZonePK(data.ACMainZonePK);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckMainZoneID(data.MainZoneID);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckACPanelPK(data.ACPanelPK);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckGroupID(data.GroupID);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckUnitID(data.UnitID);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckAddress1(data.Address1);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckBuildingID(data.BuildingID);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckBDBuildingPK(data.BDBuildingPK);
			if (rule.Length > 0)
				builder.AppendLine(rule);


			rule = this.CheckComprehensiveRules(data);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			return builder.ToString();
		}

		protected virtual string CheckComprehensiveRules(ACOutputGroupMainZoneMapRuleData data)
		{
			return string.Empty;
		}

		#region Property Rules
		public virtual string CheckACOutputGroupMainZoneMapPK(System.Guid value)
		{
			string rule;
			rule = this.BrokenNotEmptyRule(this.ACOutputGroupMainZoneMapPK, value);
			if(rule.Length > 0)
				return rule;

			return string.Empty;
		}

		public virtual string CheckACOutputGroupPK(System.Guid value)
		{
			string rule;
			rule = this.BrokenNotEmptyRule(this.ACOutputGroupPK, value);
			if(rule.Length > 0)
				return rule;

			return string.Empty;
		}

		public virtual string CheckACMainZonePK(System.Guid value)
		{
			string rule;
			rule = this.BrokenNotEmptyRule(this.ACMainZonePK, value);
			if(rule.Length > 0)
				return rule;

			return string.Empty;
		}

		public virtual string CheckMainZoneID(System.Byte value)
		{
			return string.Empty;
		}

		public virtual string CheckACPanelPK(System.Guid value)
		{
			string rule;
			rule = this.BrokenNotEmptyRule(this.ACPanelPK, value);
			if(rule.Length > 0)
				return rule;

			return string.Empty;
		}

		public virtual string CheckGroupID(System.Byte value)
		{
			return string.Empty;
		}

		public virtual string CheckUnitID(System.Int32 value)
		{
			return string.Empty;
		}

		public virtual string CheckAddress1(System.String value)
		{
			string rule;
			rule = this.BrokenNotEmptyRule(this.Address1, value);
			if(rule.Length > 0)
				return rule;

			rule = this.BrokenMaxLengthRule(this.Address1, 55, value);
			if(rule.Length > 0)
				return rule;

			return string.Empty;
		}

		public virtual string CheckBuildingID(System.Int32 value)
		{
			return string.Empty;
		}

		public virtual string CheckBDBuildingPK(System.Guid value)
		{
			string rule;
			rule = this.BrokenNotEmptyRule(this.BDBuildingPK, value);
			if(rule.Length > 0)
				return rule;

			return string.Empty;
		}

		#endregion

		#region Property Names
		protected virtual string ACOutputGroupMainZoneMapPK
		{
			get { return "ACOutputGroupMainZoneMapPK"; }
		}

		protected virtual string ACOutputGroupPK
		{
			get { return "ACOutputGroupPK"; }
		}

		protected virtual string ACMainZonePK
		{
			get { return "ACMainZonePK"; }
		}

		protected virtual string MainZoneID
		{
			get { return "MainZoneID"; }
		}

		protected virtual string ACPanelPK
		{
			get { return "ACPanelPK"; }
		}

		protected virtual string GroupID
		{
			get { return "GroupID"; }
		}

		protected virtual string UnitID
		{
			get { return "UnitID"; }
		}

		protected virtual string Address1
		{
			get { return "Address1"; }
		}

		protected virtual string BuildingID
		{
			get { return "BuildingID"; }
		}

		protected virtual string BDBuildingPK
		{
			get { return "BDBuildingPK"; }
		}

		#endregion
	}

	public class ACCardHolderDataRule : RuleBase
	{
		public string CheckRules(ACCardHolderRuleData data)
		{
			StringBuilder builder = new StringBuilder();

			string rule;
			rule = this.CheckACCardHolderPK(data.ACCardHolderPK);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckSitecode(data.Sitecode);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckEmbossed(data.Embossed);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckEncoded(data.Encoded);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckCardTypeID(data.CardTypeID);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckFirstName(data.FirstName);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckLastName(data.LastName);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckValidFrom(data.ValidFrom);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckValidThru(data.ValidThru);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckFIPS(data.FIPS);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckPin(data.Pin);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckBDTenantPK(data.BDTenantPK);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckNotes(data.Notes);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckEventNotifyEmail(data.EventNotifyEmail);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckFireWarden(data.FireWarden);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckCustInfo1(data.CustInfo1);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckCustInfo2(data.CustInfo2);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckCustInfo3(data.CustInfo3);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckCustInfo4(data.CustInfo4);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckCustInfo5(data.CustInfo5);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckCustInfo6(data.CustInfo6);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckCustInfo7(data.CustInfo7);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckCustInfo8(data.CustInfo8);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckSuite(data.Suite);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckTenant(data.Tenant);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckBDBuildingPK(data.BDBuildingPK);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckAddress1(data.Address1);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckBuildingID(data.BuildingID);
			if (rule.Length > 0)
				builder.AppendLine(rule);


			rule = this.CheckComprehensiveRules(data);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			return builder.ToString();
		}

		protected virtual string CheckComprehensiveRules(ACCardHolderRuleData data)
		{
			return string.Empty;
		}

		#region Property Rules
		public virtual string CheckACCardHolderPK(System.Guid value)
		{
			string rule;
			rule = this.BrokenNotEmptyRule(this.ACCardHolderPK, value);
			if(rule.Length > 0)
				return rule;

			return string.Empty;
		}

		public virtual string CheckSitecode(System.Int32 value)
		{
			return string.Empty;
		}

		public virtual string CheckEmbossed(System.Int32 value)
		{
			return string.Empty;
		}

		public virtual string CheckEncoded(System.Int32 value)
		{
			return string.Empty;
		}

		public virtual string CheckCardTypeID(System.Int32 value)
		{
			return string.Empty;
		}

		public virtual string CheckFirstName(System.String value)
		{
			string rule;
			rule = this.BrokenMaxLengthRule(this.FirstName, 30, value);
			if(rule.Length > 0)
				return rule;

			return string.Empty;
		}

		public virtual string CheckLastName(System.String value)
		{
			string rule;
			rule = this.BrokenMaxLengthRule(this.LastName, 50, value);
			if(rule.Length > 0)
				return rule;

			return string.Empty;
		}

		public virtual string CheckValidFrom(System.DateTime value)
		{
			return string.Empty;
		}

		public virtual string CheckValidThru(System.DateTime value)
		{
			return string.Empty;
		}

		public virtual string CheckFIPS(System.Boolean value)
		{
			return string.Empty;
		}

		public virtual string CheckPin(System.Int32 value)
		{
			return string.Empty;
		}

		public virtual string CheckBDTenantPK(System.Guid value)
		{
			string rule;
			rule = this.BrokenNotEmptyRule(this.BDTenantPK, value);
			if(rule.Length > 0)
				return rule;

			return string.Empty;
		}

		public virtual string CheckNotes(System.String value)
		{
			string rule;
			rule = this.BrokenMaxLengthRule(this.Notes, 2048, value);
			if(rule.Length > 0)
				return rule;

			return string.Empty;
		}

		public virtual string CheckEventNotifyEmail(System.String value)
		{
			string rule;
			rule = this.BrokenMaxLengthRule(this.EventNotifyEmail, 1024, value);
			if(rule.Length > 0)
				return rule;

			return string.Empty;
		}

		public virtual string CheckFireWarden(System.Boolean value)
		{
			return string.Empty;
		}

		public virtual string CheckCustInfo1(System.String value)
		{
			string rule;
			rule = this.BrokenMaxLengthRule(this.CustInfo1, 50, value);
			if(rule.Length > 0)
				return rule;

			return string.Empty;
		}

		public virtual string CheckCustInfo2(System.String value)
		{
			string rule;
			rule = this.BrokenMaxLengthRule(this.CustInfo2, 50, value);
			if(rule.Length > 0)
				return rule;

			return string.Empty;
		}

		public virtual string CheckCustInfo3(System.String value)
		{
			string rule;
			rule = this.BrokenMaxLengthRule(this.CustInfo3, 50, value);
			if(rule.Length > 0)
				return rule;

			return string.Empty;
		}

		public virtual string CheckCustInfo4(System.String value)
		{
			string rule;
			rule = this.BrokenMaxLengthRule(this.CustInfo4, 50, value);
			if(rule.Length > 0)
				return rule;

			return string.Empty;
		}

		public virtual string CheckCustInfo5(System.String value)
		{
			string rule;
			rule = this.BrokenMaxLengthRule(this.CustInfo5, 50, value);
			if(rule.Length > 0)
				return rule;

			return string.Empty;
		}

		public virtual string CheckCustInfo6(System.String value)
		{
			string rule;
			rule = this.BrokenMaxLengthRule(this.CustInfo6, 50, value);
			if(rule.Length > 0)
				return rule;

			return string.Empty;
		}

		public virtual string CheckCustInfo7(System.String value)
		{
			string rule;
			rule = this.BrokenMaxLengthRule(this.CustInfo7, 50, value);
			if(rule.Length > 0)
				return rule;

			return string.Empty;
		}

		public virtual string CheckCustInfo8(System.String value)
		{
			string rule;
			rule = this.BrokenMaxLengthRule(this.CustInfo8, 50, value);
			if(rule.Length > 0)
				return rule;

			return string.Empty;
		}

		public virtual string CheckSuite(System.String value)
		{
			string rule;
			rule = this.BrokenNotEmptyRule(this.Suite, value);
			if(rule.Length > 0)
				return rule;

			rule = this.BrokenMaxLengthRule(this.Suite, 30, value);
			if(rule.Length > 0)
				return rule;

			return string.Empty;
		}

		public virtual string CheckTenant(System.String value)
		{
			string rule;
			rule = this.BrokenNotEmptyRule(this.Tenant, value);
			if(rule.Length > 0)
				return rule;

			rule = this.BrokenMaxLengthRule(this.Tenant, 60, value);
			if(rule.Length > 0)
				return rule;

			return string.Empty;
		}

		public virtual string CheckBDBuildingPK(System.Guid value)
		{
			string rule;
			rule = this.BrokenNotEmptyRule(this.BDBuildingPK, value);
			if(rule.Length > 0)
				return rule;

			return string.Empty;
		}

		public virtual string CheckAddress1(System.String value)
		{
			string rule;
			rule = this.BrokenNotEmptyRule(this.Address1, value);
			if(rule.Length > 0)
				return rule;

			rule = this.BrokenMaxLengthRule(this.Address1, 55, value);
			if(rule.Length > 0)
				return rule;

			return string.Empty;
		}

		public virtual string CheckBuildingID(System.Int32 value)
		{
			return string.Empty;
		}

		#endregion

		#region Property Names
		protected virtual string ACCardHolderPK
		{
			get { return "ACCardHolderPK"; }
		}

		protected virtual string Sitecode
		{
			get { return "Sitecode"; }
		}

		protected virtual string Embossed
		{
			get { return "Embossed"; }
		}

		protected virtual string Encoded
		{
			get { return "Encoded"; }
		}

		protected virtual string CardTypeID
		{
			get { return "CardTypeID"; }
		}

		protected virtual string FirstName
		{
			get { return "FirstName"; }
		}

		protected virtual string LastName
		{
			get { return "LastName"; }
		}

		protected virtual string ValidFrom
		{
			get { return "ValidFrom"; }
		}

		protected virtual string ValidThru
		{
			get { return "ValidThru"; }
		}

		protected virtual string FIPS
		{
			get { return "FIPS"; }
		}

		protected virtual string Pin
		{
			get { return "Pin"; }
		}

		protected virtual string BDTenantPK
		{
			get { return "BDTenantPK"; }
		}

		protected virtual string Notes
		{
			get { return "Notes"; }
		}

		protected virtual string EventNotifyEmail
		{
			get { return "EventNotifyEmail"; }
		}

		protected virtual string FireWarden
		{
			get { return "FireWarden"; }
		}

		protected virtual string CustInfo1
		{
			get { return "CustInfo1"; }
		}

		protected virtual string CustInfo2
		{
			get { return "CustInfo2"; }
		}

		protected virtual string CustInfo3
		{
			get { return "CustInfo3"; }
		}

		protected virtual string CustInfo4
		{
			get { return "CustInfo4"; }
		}

		protected virtual string CustInfo5
		{
			get { return "CustInfo5"; }
		}

		protected virtual string CustInfo6
		{
			get { return "CustInfo6"; }
		}

		protected virtual string CustInfo7
		{
			get { return "CustInfo7"; }
		}

		protected virtual string CustInfo8
		{
			get { return "CustInfo8"; }
		}

		protected virtual string Suite
		{
			get { return "Suite"; }
		}

		protected virtual string Tenant
		{
			get { return "Tenant"; }
		}

		protected virtual string BDBuildingPK
		{
			get { return "BDBuildingPK"; }
		}

		protected virtual string Address1
		{
			get { return "Address1"; }
		}

		protected virtual string BuildingID
		{
			get { return "BuildingID"; }
		}

		#endregion
	}

	public class ACMainZoneDataRule : RuleBase
	{
		public string CheckRules(ACMainZoneRuleData data)
		{
			StringBuilder builder = new StringBuilder();

			string rule;
			rule = this.CheckACMainZonePK(data.ACMainZonePK);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckACPanelPK(data.ACPanelPK);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckMainZoneID(data.MainZoneID);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckMainZoneTypeID(data.MainZoneTypeID);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckDescription(data.Description);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckReaderName(data.ReaderName);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckReaderTypeID(data.ReaderTypeID);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckReverseColor(data.ReverseColor);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckOutputGroup(data.OutputGroup);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckNeedPin(data.NeedPin);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckAntiPassback(data.AntiPassback);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckSoftAntiPassback(data.SoftAntiPassback);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckUnlockTimecode(data.UnlockTimecode);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckUnlockOn1stRead(data.UnlockOn1stRead);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckRexShuntOnly(data.RexShuntOnly);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckPulseTime(data.PulseTime);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckRelockByTimeout(data.RelockByTimeout);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckForceAMFormat(data.ForceAMFormat);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckPropAMFFormat(data.PropAMFFormat);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckDebounce(data.Debounce);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckAllowOpenTime(data.AllowOpenTime);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckNoPreAlarm(data.NoPreAlarm);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckPostPreAlarm(data.PostPreAlarm);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckPostDuration(data.PostDuration);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckNotes(data.Notes);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckEventNotifyEmail(data.EventNotifyEmail);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckIsPulsed(data.IsPulsed);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckAlwaysToMAS(data.AlwaysToMAS);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckCommentBeforePulse(data.CommentBeforePulse);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckDegrade(data.Degrade);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckReaderPassMode(data.ReaderPassMode);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckPanelZoneID(data.PanelZoneID);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckLockTypeID(data.LockTypeID);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckLocked(data.Locked);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckInputGroup(data.InputGroup);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckUnlockTempTC(data.UnlockTempTC);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckUnlockTempBegin(data.UnlockTempBegin);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckUnlockTempEnd(data.UnlockTempEnd);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckBDBuildingPK(data.BDBuildingPK);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckUnitID(data.UnitID);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckAddress1(data.Address1);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckBuildingID(data.BuildingID);
			if (rule.Length > 0)
				builder.AppendLine(rule);


			rule = this.CheckComprehensiveRules(data);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			return builder.ToString();
		}

		protected virtual string CheckComprehensiveRules(ACMainZoneRuleData data)
		{
			return string.Empty;
		}

		#region Property Rules
		public virtual string CheckACMainZonePK(System.Guid value)
		{
			string rule;
			rule = this.BrokenNotEmptyRule(this.ACMainZonePK, value);
			if(rule.Length > 0)
				return rule;

			return string.Empty;
		}

		public virtual string CheckACPanelPK(System.Guid value)
		{
			string rule;
			rule = this.BrokenNotEmptyRule(this.ACPanelPK, value);
			if(rule.Length > 0)
				return rule;

			return string.Empty;
		}

		public virtual string CheckMainZoneID(System.Byte value)
		{
			return string.Empty;
		}

		public virtual string CheckMainZoneTypeID(System.Int32 value)
		{
			return string.Empty;
		}

		public virtual string CheckDescription(System.String value)
		{
			string rule;
			rule = this.BrokenNotEmptyRule(this.Description, value);
			if(rule.Length > 0)
				return rule;

			rule = this.BrokenMaxLengthRule(this.Description, 30, value);
			if(rule.Length > 0)
				return rule;

			return string.Empty;
		}

		public virtual string CheckReaderName(System.String value)
		{
			string rule;
			rule = this.BrokenMaxLengthRule(this.ReaderName, 30, value);
			if(rule.Length > 0)
				return rule;

			return string.Empty;
		}

		public virtual string CheckReaderTypeID(System.Int32 value)
		{
			return string.Empty;
		}

		public virtual string CheckReverseColor(System.Boolean value)
		{
			return string.Empty;
		}

		public virtual string CheckOutputGroup(System.Byte value)
		{
			return string.Empty;
		}

		public virtual string CheckNeedPin(System.Boolean value)
		{
			return string.Empty;
		}

		public virtual string CheckAntiPassback(System.String value)
		{
			string rule;
			rule = this.BrokenLengthEqualRule(this.AntiPassback, 1, value);
			if(rule.Length > 0)
				return rule;

			rule = this.BrokenMaxLengthRule(this.AntiPassback, 1, value);
			if(rule.Length > 0)
				return rule;

			return string.Empty;
		}

		public virtual string CheckSoftAntiPassback(System.Boolean value)
		{
			return string.Empty;
		}

		public virtual string CheckUnlockTimecode(System.Int16 value)
		{
			return string.Empty;
		}

		public virtual string CheckUnlockOn1stRead(System.Boolean value)
		{
			return string.Empty;
		}

		public virtual string CheckRexShuntOnly(System.Boolean value)
		{
			return string.Empty;
		}

		public virtual string CheckPulseTime(System.Int16 value)
		{
			return string.Empty;
		}

		public virtual string CheckRelockByTimeout(System.Boolean value)
		{
			return string.Empty;
		}

		public virtual string CheckForceAMFormat(System.Int16 value)
		{
			return string.Empty;
		}

		public virtual string CheckPropAMFFormat(System.Int16 value)
		{
			return string.Empty;
		}

		public virtual string CheckDebounce(System.Int16 value)
		{
			return string.Empty;
		}

		public virtual string CheckAllowOpenTime(System.Int16 value)
		{
			return string.Empty;
		}

		public virtual string CheckNoPreAlarm(System.Boolean value)
		{
			return string.Empty;
		}

		public virtual string CheckPostPreAlarm(System.String value)
		{
			string rule;
			rule = this.BrokenLengthEqualRule(this.PostPreAlarm, 1, value);
			if(rule.Length > 0)
				return rule;

			rule = this.BrokenMaxLengthRule(this.PostPreAlarm, 1, value);
			if(rule.Length > 0)
				return rule;

			return string.Empty;
		}

		public virtual string CheckPostDuration(System.Int16 value)
		{
			return string.Empty;
		}

		public virtual string CheckNotes(System.String value)
		{
			string rule;
			rule = this.BrokenMaxLengthRule(this.Notes, 1024, value);
			if(rule.Length > 0)
				return rule;

			return string.Empty;
		}

		public virtual string CheckEventNotifyEmail(System.String value)
		{
			string rule;
			rule = this.BrokenMaxLengthRule(this.EventNotifyEmail, 1024, value);
			if(rule.Length > 0)
				return rule;

			return string.Empty;
		}

		public virtual string CheckIsPulsed(System.Boolean value)
		{
			return string.Empty;
		}

		public virtual string CheckAlwaysToMAS(System.Boolean value)
		{
			return string.Empty;
		}

		public virtual string CheckCommentBeforePulse(System.Boolean value)
		{
			return string.Empty;
		}

		public virtual string CheckDegrade(System.Boolean value)
		{
			return string.Empty;
		}

		public virtual string CheckReaderPassMode(System.String value)
		{
			string rule;
			rule = this.BrokenLengthEqualRule(this.ReaderPassMode, 1, value);
			if(rule.Length > 0)
				return rule;

			rule = this.BrokenMaxLengthRule(this.ReaderPassMode, 1, value);
			if(rule.Length > 0)
				return rule;

			return string.Empty;
		}

		public virtual string CheckPanelZoneID(System.Byte value)
		{
			return string.Empty;
		}

		public virtual string CheckLockTypeID(System.Int32 value)
		{
			return string.Empty;
		}

		public virtual string CheckLocked(System.Boolean value)
		{
			return string.Empty;
		}

		public virtual string CheckInputGroup(System.Byte value)
		{
			return string.Empty;
		}

		public virtual string CheckUnlockTempTC(System.Int16 value)
		{
			return string.Empty;
		}

		public virtual string CheckUnlockTempBegin(System.DateTime value)
		{
			return string.Empty;
		}

		public virtual string CheckUnlockTempEnd(System.DateTime value)
		{
			return string.Empty;
		}

		public virtual string CheckBDBuildingPK(System.Guid value)
		{
			string rule;
			rule = this.BrokenNotEmptyRule(this.BDBuildingPK, value);
			if(rule.Length > 0)
				return rule;

			return string.Empty;
		}

		public virtual string CheckUnitID(System.Int32 value)
		{
			return string.Empty;
		}

		public virtual string CheckAddress1(System.String value)
		{
			string rule;
			rule = this.BrokenNotEmptyRule(this.Address1, value);
			if(rule.Length > 0)
				return rule;

			rule = this.BrokenMaxLengthRule(this.Address1, 55, value);
			if(rule.Length > 0)
				return rule;

			return string.Empty;
		}

		public virtual string CheckBuildingID(System.Int32 value)
		{
			return string.Empty;
		}

		#endregion

		#region Property Names
		protected virtual string ACMainZonePK
		{
			get { return "ACMainZonePK"; }
		}

		protected virtual string ACPanelPK
		{
			get { return "ACPanelPK"; }
		}

		protected virtual string MainZoneID
		{
			get { return "MainZoneID"; }
		}

		protected virtual string MainZoneTypeID
		{
			get { return "MainZoneTypeID"; }
		}

		protected virtual string Description
		{
			get { return "Description"; }
		}

		protected virtual string ReaderName
		{
			get { return "ReaderName"; }
		}

		protected virtual string ReaderTypeID
		{
			get { return "ReaderTypeID"; }
		}

		protected virtual string ReverseColor
		{
			get { return "ReverseColor"; }
		}

		protected virtual string OutputGroup
		{
			get { return "OutputGroup"; }
		}

		protected virtual string NeedPin
		{
			get { return "NeedPin"; }
		}

		protected virtual string AntiPassback
		{
			get { return "AntiPassback"; }
		}

		protected virtual string SoftAntiPassback
		{
			get { return "SoftAntiPassback"; }
		}

		protected virtual string UnlockTimecode
		{
			get { return "UnlockTimecode"; }
		}

		protected virtual string UnlockOn1stRead
		{
			get { return "UnlockOn1stRead"; }
		}

		protected virtual string RexShuntOnly
		{
			get { return "RexShuntOnly"; }
		}

		protected virtual string PulseTime
		{
			get { return "PulseTime"; }
		}

		protected virtual string RelockByTimeout
		{
			get { return "RelockByTimeout"; }
		}

		protected virtual string ForceAMFormat
		{
			get { return "ForceAMFormat"; }
		}

		protected virtual string PropAMFFormat
		{
			get { return "PropAMFFormat"; }
		}

		protected virtual string Debounce
		{
			get { return "Debounce"; }
		}

		protected virtual string AllowOpenTime
		{
			get { return "AllowOpenTime"; }
		}

		protected virtual string NoPreAlarm
		{
			get { return "NoPreAlarm"; }
		}

		protected virtual string PostPreAlarm
		{
			get { return "PostPreAlarm"; }
		}

		protected virtual string PostDuration
		{
			get { return "PostDuration"; }
		}

		protected virtual string Notes
		{
			get { return "Notes"; }
		}

		protected virtual string EventNotifyEmail
		{
			get { return "EventNotifyEmail"; }
		}

		protected virtual string IsPulsed
		{
			get { return "IsPulsed"; }
		}

		protected virtual string AlwaysToMAS
		{
			get { return "AlwaysToMAS"; }
		}

		protected virtual string CommentBeforePulse
		{
			get { return "CommentBeforePulse"; }
		}

		protected virtual string Degrade
		{
			get { return "Degrade"; }
		}

		protected virtual string ReaderPassMode
		{
			get { return "ReaderPassMode"; }
		}

		protected virtual string PanelZoneID
		{
			get { return "PanelZoneID"; }
		}

		protected virtual string LockTypeID
		{
			get { return "LockTypeID"; }
		}

		protected virtual string Locked
		{
			get { return "Locked"; }
		}

		protected virtual string InputGroup
		{
			get { return "InputGroup"; }
		}

		protected virtual string UnlockTempTC
		{
			get { return "UnlockTempTC"; }
		}

		protected virtual string UnlockTempBegin
		{
			get { return "UnlockTempBegin"; }
		}

		protected virtual string UnlockTempEnd
		{
			get { return "UnlockTempEnd"; }
		}

		protected virtual string BDBuildingPK
		{
			get { return "BDBuildingPK"; }
		}

		protected virtual string UnitID
		{
			get { return "UnitID"; }
		}

		protected virtual string Address1
		{
			get { return "Address1"; }
		}

		protected virtual string BuildingID
		{
			get { return "BuildingID"; }
		}

		#endregion
	}

	public class ACIntervalDataRule : RuleBase
	{
		public string CheckRules(ACIntervalRuleData data)
		{
			StringBuilder builder = new StringBuilder();

			string rule;
			rule = this.CheckACIntervalPK(data.ACIntervalPK);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckBDBuildingPK(data.BDBuildingPK);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckIVID(data.IVID);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckBegin(data.Begin);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckEnd(data.End);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckSun(data.Sun);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckMon(data.Mon);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckTue(data.Tue);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckWed(data.Wed);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckThu(data.Thu);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckFri(data.Fri);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckSat(data.Sat);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckHol(data.Hol);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckAddress1(data.Address1);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckBuildingID(data.BuildingID);
			if (rule.Length > 0)
				builder.AppendLine(rule);


			rule = this.CheckComprehensiveRules(data);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			return builder.ToString();
		}

		protected virtual string CheckComprehensiveRules(ACIntervalRuleData data)
		{
			return string.Empty;
		}

		#region Property Rules
		public virtual string CheckACIntervalPK(System.Guid value)
		{
			string rule;
			rule = this.BrokenNotEmptyRule(this.ACIntervalPK, value);
			if(rule.Length > 0)
				return rule;

			return string.Empty;
		}

		public virtual string CheckBDBuildingPK(System.Guid value)
		{
			string rule;
			rule = this.BrokenNotEmptyRule(this.BDBuildingPK, value);
			if(rule.Length > 0)
				return rule;

			return string.Empty;
		}

		public virtual string CheckIVID(System.Int16 value)
		{
			return string.Empty;
		}

		public virtual string CheckBegin(System.String value)
		{
			string rule;
			rule = this.BrokenLengthEqualRule(this.Begin, 4, value);
			if(rule.Length > 0)
				return rule;

			rule = this.BrokenMaxLengthRule(this.Begin, 4, value);
			if(rule.Length > 0)
				return rule;

			return string.Empty;
		}

		public virtual string CheckEnd(System.String value)
		{
			string rule;
			rule = this.BrokenLengthEqualRule(this.End, 4, value);
			if(rule.Length > 0)
				return rule;

			rule = this.BrokenMaxLengthRule(this.End, 4, value);
			if(rule.Length > 0)
				return rule;

			return string.Empty;
		}

		public virtual string CheckSun(System.Boolean value)
		{
			return string.Empty;
		}

		public virtual string CheckMon(System.Boolean value)
		{
			return string.Empty;
		}

		public virtual string CheckTue(System.Boolean value)
		{
			return string.Empty;
		}

		public virtual string CheckWed(System.Boolean value)
		{
			return string.Empty;
		}

		public virtual string CheckThu(System.Boolean value)
		{
			return string.Empty;
		}

		public virtual string CheckFri(System.Boolean value)
		{
			return string.Empty;
		}

		public virtual string CheckSat(System.Boolean value)
		{
			return string.Empty;
		}

		public virtual string CheckHol(System.Boolean value)
		{
			return string.Empty;
		}

		public virtual string CheckAddress1(System.String value)
		{
			string rule;
			rule = this.BrokenNotEmptyRule(this.Address1, value);
			if(rule.Length > 0)
				return rule;

			rule = this.BrokenMaxLengthRule(this.Address1, 55, value);
			if(rule.Length > 0)
				return rule;

			return string.Empty;
		}

		public virtual string CheckBuildingID(System.Int32 value)
		{
			return string.Empty;
		}

		#endregion

		#region Property Names
		protected virtual string ACIntervalPK
		{
			get { return "ACIntervalPK"; }
		}

		protected virtual string BDBuildingPK
		{
			get { return "BDBuildingPK"; }
		}

		protected virtual string IVID
		{
			get { return "IVID"; }
		}

		protected virtual string Begin
		{
			get { return "Begin"; }
		}

		protected virtual string End
		{
			get { return "End"; }
		}

		protected virtual string Sun
		{
			get { return "Sun"; }
		}

		protected virtual string Mon
		{
			get { return "Mon"; }
		}

		protected virtual string Tue
		{
			get { return "Tue"; }
		}

		protected virtual string Wed
		{
			get { return "Wed"; }
		}

		protected virtual string Thu
		{
			get { return "Thu"; }
		}

		protected virtual string Fri
		{
			get { return "Fri"; }
		}

		protected virtual string Sat
		{
			get { return "Sat"; }
		}

		protected virtual string Hol
		{
			get { return "Hol"; }
		}

		protected virtual string Address1
		{
			get { return "Address1"; }
		}

		protected virtual string BuildingID
		{
			get { return "BuildingID"; }
		}

		#endregion
	}

	public class ACPanelHolidayMapDataRule : RuleBase
	{
		public string CheckRules(ACPanelHolidayMapRuleData data)
		{
			StringBuilder builder = new StringBuilder();

			string rule;
			rule = this.CheckACPanelHolidayMapPK(data.ACPanelHolidayMapPK);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckACPanelPK(data.ACPanelPK);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckUtilHolidayPK(data.UtilHolidayPK);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckDate(data.Date);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckHoliday(data.Holiday);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckBDBuildingPK(data.BDBuildingPK);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckUnitID(data.UnitID);
			if (rule.Length > 0)
				builder.AppendLine(rule);


			rule = this.CheckComprehensiveRules(data);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			return builder.ToString();
		}

		protected virtual string CheckComprehensiveRules(ACPanelHolidayMapRuleData data)
		{
			return string.Empty;
		}

		#region Property Rules
		public virtual string CheckACPanelHolidayMapPK(System.Guid value)
		{
			string rule;
			rule = this.BrokenNotEmptyRule(this.ACPanelHolidayMapPK, value);
			if(rule.Length > 0)
				return rule;

			return string.Empty;
		}

		public virtual string CheckACPanelPK(System.Guid value)
		{
			string rule;
			rule = this.BrokenNotEmptyRule(this.ACPanelPK, value);
			if(rule.Length > 0)
				return rule;

			return string.Empty;
		}

		public virtual string CheckUtilHolidayPK(System.Guid value)
		{
			string rule;
			rule = this.BrokenNotEmptyRule(this.UtilHolidayPK, value);
			if(rule.Length > 0)
				return rule;

			return string.Empty;
		}

		public virtual string CheckDate(System.DateTime value)
		{
			return string.Empty;
		}

		public virtual string CheckHoliday(System.String value)
		{
			string rule;
			rule = this.BrokenNotEmptyRule(this.Holiday, value);
			if(rule.Length > 0)
				return rule;

			rule = this.BrokenMaxLengthRule(this.Holiday, 30, value);
			if(rule.Length > 0)
				return rule;

			return string.Empty;
		}

		public virtual string CheckBDBuildingPK(System.Guid value)
		{
			string rule;
			rule = this.BrokenNotEmptyRule(this.BDBuildingPK, value);
			if(rule.Length > 0)
				return rule;

			return string.Empty;
		}

		public virtual string CheckUnitID(System.Int32 value)
		{
			return string.Empty;
		}

		#endregion

		#region Property Names
		protected virtual string ACPanelHolidayMapPK
		{
			get { return "ACPanelHolidayMapPK"; }
		}

		protected virtual string ACPanelPK
		{
			get { return "ACPanelPK"; }
		}

		protected virtual string UtilHolidayPK
		{
			get { return "UtilHolidayPK"; }
		}

		protected virtual string Date
		{
			get { return "Date"; }
		}

		protected virtual string Holiday
		{
			get { return "Holiday"; }
		}

		protected virtual string BDBuildingPK
		{
			get { return "BDBuildingPK"; }
		}

		protected virtual string UnitID
		{
			get { return "UnitID"; }
		}

		#endregion
	}

	public class ACTimecodeDataRule : RuleBase
	{
		public string CheckRules(ACTimecodeRuleData data)
		{
			StringBuilder builder = new StringBuilder();

			string rule;
			rule = this.CheckACTimecodePK(data.ACTimecodePK);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckBDBuildingPK(data.BDBuildingPK);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckTCID(data.TCID);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckSummary(data.Summary);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckNotes(data.Notes);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckAddress1(data.Address1);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckBuildingID(data.BuildingID);
			if (rule.Length > 0)
				builder.AppendLine(rule);


			rule = this.CheckComprehensiveRules(data);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			return builder.ToString();
		}

		protected virtual string CheckComprehensiveRules(ACTimecodeRuleData data)
		{
			return string.Empty;
		}

		#region Property Rules
		public virtual string CheckACTimecodePK(System.Guid value)
		{
			string rule;
			rule = this.BrokenNotEmptyRule(this.ACTimecodePK, value);
			if(rule.Length > 0)
				return rule;

			return string.Empty;
		}

		public virtual string CheckBDBuildingPK(System.Guid value)
		{
			string rule;
			rule = this.BrokenNotEmptyRule(this.BDBuildingPK, value);
			if(rule.Length > 0)
				return rule;

			return string.Empty;
		}

		public virtual string CheckTCID(System.Int16 value)
		{
			return string.Empty;
		}

		public virtual string CheckSummary(System.String value)
		{
			string rule;
			rule = this.BrokenNotEmptyRule(this.Summary, value);
			if(rule.Length > 0)
				return rule;

			rule = this.BrokenMaxLengthRule(this.Summary, 256, value);
			if(rule.Length > 0)
				return rule;

			return string.Empty;
		}

		public virtual string CheckNotes(System.String value)
		{
			string rule;
			rule = this.BrokenMaxLengthRule(this.Notes, 512, value);
			if(rule.Length > 0)
				return rule;

			return string.Empty;
		}

		public virtual string CheckAddress1(System.String value)
		{
			string rule;
			rule = this.BrokenNotEmptyRule(this.Address1, value);
			if(rule.Length > 0)
				return rule;

			rule = this.BrokenMaxLengthRule(this.Address1, 55, value);
			if(rule.Length > 0)
				return rule;

			return string.Empty;
		}

		public virtual string CheckBuildingID(System.Int32 value)
		{
			return string.Empty;
		}

		#endregion

		#region Property Names
		protected virtual string ACTimecodePK
		{
			get { return "ACTimecodePK"; }
		}

		protected virtual string BDBuildingPK
		{
			get { return "BDBuildingPK"; }
		}

		protected virtual string TCID
		{
			get { return "TCID"; }
		}

		protected virtual string Summary
		{
			get { return "Summary"; }
		}

		protected virtual string Notes
		{
			get { return "Notes"; }
		}

		protected virtual string Address1
		{
			get { return "Address1"; }
		}

		protected virtual string BuildingID
		{
			get { return "BuildingID"; }
		}

		#endregion
	}

	public class ACTimecodeIntervalMapDataRule : RuleBase
	{
		public string CheckRules(ACTimecodeIntervalMapRuleData data)
		{
			StringBuilder builder = new StringBuilder();

			string rule;
			rule = this.CheckACTimecodeIntervalMapPK(data.ACTimecodeIntervalMapPK);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckACTimecodePK(data.ACTimecodePK);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckACIntervalPK(data.ACIntervalPK);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckEnd(data.End);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckBegin(data.Begin);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckIVID(data.IVID);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckTCID(data.TCID);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckBDBuildingPK(data.BDBuildingPK);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckAddress1(data.Address1);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckBuildingID(data.BuildingID);
			if (rule.Length > 0)
				builder.AppendLine(rule);


			rule = this.CheckComprehensiveRules(data);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			return builder.ToString();
		}

		protected virtual string CheckComprehensiveRules(ACTimecodeIntervalMapRuleData data)
		{
			return string.Empty;
		}

		#region Property Rules
		public virtual string CheckACTimecodeIntervalMapPK(System.Guid value)
		{
			string rule;
			rule = this.BrokenNotEmptyRule(this.ACTimecodeIntervalMapPK, value);
			if(rule.Length > 0)
				return rule;

			return string.Empty;
		}

		public virtual string CheckACTimecodePK(System.Guid value)
		{
			string rule;
			rule = this.BrokenNotEmptyRule(this.ACTimecodePK, value);
			if(rule.Length > 0)
				return rule;

			return string.Empty;
		}

		public virtual string CheckACIntervalPK(System.Guid value)
		{
			string rule;
			rule = this.BrokenNotEmptyRule(this.ACIntervalPK, value);
			if(rule.Length > 0)
				return rule;

			return string.Empty;
		}

		public virtual string CheckEnd(System.String value)
		{
			string rule;
			rule = this.BrokenLengthEqualRule(this.End, 4, value);
			if(rule.Length > 0)
				return rule;

			rule = this.BrokenMaxLengthRule(this.End, 4, value);
			if(rule.Length > 0)
				return rule;

			return string.Empty;
		}

		public virtual string CheckBegin(System.String value)
		{
			string rule;
			rule = this.BrokenLengthEqualRule(this.Begin, 4, value);
			if(rule.Length > 0)
				return rule;

			rule = this.BrokenMaxLengthRule(this.Begin, 4, value);
			if(rule.Length > 0)
				return rule;

			return string.Empty;
		}

		public virtual string CheckIVID(System.Int16 value)
		{
			return string.Empty;
		}

		public virtual string CheckTCID(System.Int16 value)
		{
			return string.Empty;
		}

		public virtual string CheckBDBuildingPK(System.Guid value)
		{
			string rule;
			rule = this.BrokenNotEmptyRule(this.BDBuildingPK, value);
			if(rule.Length > 0)
				return rule;

			return string.Empty;
		}

		public virtual string CheckAddress1(System.String value)
		{
			string rule;
			rule = this.BrokenNotEmptyRule(this.Address1, value);
			if(rule.Length > 0)
				return rule;

			rule = this.BrokenMaxLengthRule(this.Address1, 55, value);
			if(rule.Length > 0)
				return rule;

			return string.Empty;
		}

		public virtual string CheckBuildingID(System.Int32 value)
		{
			return string.Empty;
		}

		#endregion

		#region Property Names
		protected virtual string ACTimecodeIntervalMapPK
		{
			get { return "ACTimecodeIntervalMapPK"; }
		}

		protected virtual string ACTimecodePK
		{
			get { return "ACTimecodePK"; }
		}

		protected virtual string ACIntervalPK
		{
			get { return "ACIntervalPK"; }
		}

		protected virtual string End
		{
			get { return "End"; }
		}

		protected virtual string Begin
		{
			get { return "Begin"; }
		}

		protected virtual string IVID
		{
			get { return "IVID"; }
		}

		protected virtual string TCID
		{
			get { return "TCID"; }
		}

		protected virtual string BDBuildingPK
		{
			get { return "BDBuildingPK"; }
		}

		protected virtual string Address1
		{
			get { return "Address1"; }
		}

		protected virtual string BuildingID
		{
			get { return "BuildingID"; }
		}

		#endregion
	}

	public class ACAMFormatDataRule : RuleBase
	{
		public string CheckRules(ACAMFormatRuleData data)
		{
			StringBuilder builder = new StringBuilder();

			string rule;
			rule = this.CheckACAMFormatPK(data.ACAMFormatPK);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckBDBuildingPK(data.BDBuildingPK);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckAMFID(data.AMFID);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckSummary(data.Summary);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckNotes(data.Notes);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckReportTC(data.ReportTC);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckAlarmTC(data.AlarmTC);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckPreAlarmTC(data.PreAlarmTC);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckAddress1(data.Address1);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckBuildingID(data.BuildingID);
			if (rule.Length > 0)
				builder.AppendLine(rule);


			rule = this.CheckComprehensiveRules(data);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			return builder.ToString();
		}

		protected virtual string CheckComprehensiveRules(ACAMFormatRuleData data)
		{
			return string.Empty;
		}

		#region Property Rules
		public virtual string CheckACAMFormatPK(System.Guid value)
		{
			string rule;
			rule = this.BrokenNotEmptyRule(this.ACAMFormatPK, value);
			if(rule.Length > 0)
				return rule;

			return string.Empty;
		}

		public virtual string CheckBDBuildingPK(System.Guid value)
		{
			string rule;
			rule = this.BrokenNotEmptyRule(this.BDBuildingPK, value);
			if(rule.Length > 0)
				return rule;

			return string.Empty;
		}

		public virtual string CheckAMFID(System.Int16 value)
		{
			return string.Empty;
		}

		public virtual string CheckSummary(System.String value)
		{
			string rule;
			rule = this.BrokenNotEmptyRule(this.Summary, value);
			if(rule.Length > 0)
				return rule;

			rule = this.BrokenMaxLengthRule(this.Summary, 256, value);
			if(rule.Length > 0)
				return rule;

			return string.Empty;
		}

		public virtual string CheckNotes(System.String value)
		{
			string rule;
			rule = this.BrokenMaxLengthRule(this.Notes, 512, value);
			if(rule.Length > 0)
				return rule;

			return string.Empty;
		}

		public virtual string CheckReportTC(System.Int16 value)
		{
			return string.Empty;
		}

		public virtual string CheckAlarmTC(System.Int16 value)
		{
			return string.Empty;
		}

		public virtual string CheckPreAlarmTC(System.Int16 value)
		{
			return string.Empty;
		}

		public virtual string CheckAddress1(System.String value)
		{
			string rule;
			rule = this.BrokenNotEmptyRule(this.Address1, value);
			if(rule.Length > 0)
				return rule;

			rule = this.BrokenMaxLengthRule(this.Address1, 55, value);
			if(rule.Length > 0)
				return rule;

			return string.Empty;
		}

		public virtual string CheckBuildingID(System.Int32 value)
		{
			return string.Empty;
		}

		#endregion

		#region Property Names
		protected virtual string ACAMFormatPK
		{
			get { return "ACAMFormatPK"; }
		}

		protected virtual string BDBuildingPK
		{
			get { return "BDBuildingPK"; }
		}

		protected virtual string AMFID
		{
			get { return "AMFID"; }
		}

		protected virtual string Summary
		{
			get { return "Summary"; }
		}

		protected virtual string Notes
		{
			get { return "Notes"; }
		}

		protected virtual string ReportTC
		{
			get { return "ReportTC"; }
		}

		protected virtual string AlarmTC
		{
			get { return "AlarmTC"; }
		}

		protected virtual string PreAlarmTC
		{
			get { return "PreAlarmTC"; }
		}

		protected virtual string Address1
		{
			get { return "Address1"; }
		}

		protected virtual string BuildingID
		{
			get { return "BuildingID"; }
		}

		#endregion
	}

	public class BDBuildingHolidayMapDataRule : RuleBase
	{
		public string CheckRules(BDBuildingHolidayMapRuleData data)
		{
			StringBuilder builder = new StringBuilder();

			string rule;
			rule = this.CheckBDBuildingHolidayMapPK(data.BDBuildingHolidayMapPK);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckBDBuildingPK(data.BDBuildingPK);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckUtilHolidayPK(data.UtilHolidayPK);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckActionID(data.ActionID);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckNotes(data.Notes);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckAddress1(data.Address1);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckBuildingID(data.BuildingID);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckDate(data.Date);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckHoliday(data.Holiday);
			if (rule.Length > 0)
				builder.AppendLine(rule);


			rule = this.CheckComprehensiveRules(data);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			return builder.ToString();
		}

		protected virtual string CheckComprehensiveRules(BDBuildingHolidayMapRuleData data)
		{
			return string.Empty;
		}

		#region Property Rules
		public virtual string CheckBDBuildingHolidayMapPK(System.Guid value)
		{
			string rule;
			rule = this.BrokenNotEmptyRule(this.BDBuildingHolidayMapPK, value);
			if(rule.Length > 0)
				return rule;

			return string.Empty;
		}

		public virtual string CheckBDBuildingPK(System.Guid value)
		{
			string rule;
			rule = this.BrokenNotEmptyRule(this.BDBuildingPK, value);
			if(rule.Length > 0)
				return rule;

			return string.Empty;
		}

		public virtual string CheckUtilHolidayPK(System.Guid value)
		{
			string rule;
			rule = this.BrokenNotEmptyRule(this.UtilHolidayPK, value);
			if(rule.Length > 0)
				return rule;

			return string.Empty;
		}

		public virtual string CheckActionID(System.Int32 value)
		{
			return string.Empty;
		}

		public virtual string CheckNotes(System.String value)
		{
			string rule;
			rule = this.BrokenMaxLengthRule(this.Notes, 256, value);
			if(rule.Length > 0)
				return rule;

			return string.Empty;
		}

		public virtual string CheckAddress1(System.String value)
		{
			string rule;
			rule = this.BrokenNotEmptyRule(this.Address1, value);
			if(rule.Length > 0)
				return rule;

			rule = this.BrokenMaxLengthRule(this.Address1, 55, value);
			if(rule.Length > 0)
				return rule;

			return string.Empty;
		}

		public virtual string CheckBuildingID(System.Int32 value)
		{
			return string.Empty;
		}

		public virtual string CheckDate(System.DateTime value)
		{
			return string.Empty;
		}

		public virtual string CheckHoliday(System.String value)
		{
			string rule;
			rule = this.BrokenNotEmptyRule(this.Holiday, value);
			if(rule.Length > 0)
				return rule;

			rule = this.BrokenMaxLengthRule(this.Holiday, 30, value);
			if(rule.Length > 0)
				return rule;

			return string.Empty;
		}

		#endregion

		#region Property Names
		protected virtual string BDBuildingHolidayMapPK
		{
			get { return "BDBuildingHolidayMapPK"; }
		}

		protected virtual string BDBuildingPK
		{
			get { return "BDBuildingPK"; }
		}

		protected virtual string UtilHolidayPK
		{
			get { return "UtilHolidayPK"; }
		}

		protected virtual string ActionID
		{
			get { return "ActionID"; }
		}

		protected virtual string Notes
		{
			get { return "Notes"; }
		}

		protected virtual string Address1
		{
			get { return "Address1"; }
		}

		protected virtual string BuildingID
		{
			get { return "BuildingID"; }
		}

		protected virtual string Date
		{
			get { return "Date"; }
		}

		protected virtual string Holiday
		{
			get { return "Holiday"; }
		}

		#endregion
	}

	public class ACOutputGroupDataRule : RuleBase
	{
		public string CheckRules(ACOutputGroupRuleData data)
		{
			StringBuilder builder = new StringBuilder();

			string rule;
			rule = this.CheckACOutputGroupPK(data.ACOutputGroupPK);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckACPanelPK(data.ACPanelPK);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckGroupID(data.GroupID);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckSummary(data.Summary);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckBDBuildingPK(data.BDBuildingPK);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckUnitID(data.UnitID);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckAddress1(data.Address1);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckBuildingID(data.BuildingID);
			if (rule.Length > 0)
				builder.AppendLine(rule);


			rule = this.CheckComprehensiveRules(data);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			return builder.ToString();
		}

		protected virtual string CheckComprehensiveRules(ACOutputGroupRuleData data)
		{
			return string.Empty;
		}

		#region Property Rules
		public virtual string CheckACOutputGroupPK(System.Guid value)
		{
			string rule;
			rule = this.BrokenNotEmptyRule(this.ACOutputGroupPK, value);
			if(rule.Length > 0)
				return rule;

			return string.Empty;
		}

		public virtual string CheckACPanelPK(System.Guid value)
		{
			string rule;
			rule = this.BrokenNotEmptyRule(this.ACPanelPK, value);
			if(rule.Length > 0)
				return rule;

			return string.Empty;
		}

		public virtual string CheckGroupID(System.Byte value)
		{
			return string.Empty;
		}

		public virtual string CheckSummary(System.String value)
		{
			string rule;
			rule = this.BrokenNotEmptyRule(this.Summary, value);
			if(rule.Length > 0)
				return rule;

			rule = this.BrokenMaxLengthRule(this.Summary, 256, value);
			if(rule.Length > 0)
				return rule;

			return string.Empty;
		}

		public virtual string CheckBDBuildingPK(System.Guid value)
		{
			string rule;
			rule = this.BrokenNotEmptyRule(this.BDBuildingPK, value);
			if(rule.Length > 0)
				return rule;

			return string.Empty;
		}

		public virtual string CheckUnitID(System.Int32 value)
		{
			return string.Empty;
		}

		public virtual string CheckAddress1(System.String value)
		{
			string rule;
			rule = this.BrokenNotEmptyRule(this.Address1, value);
			if(rule.Length > 0)
				return rule;

			rule = this.BrokenMaxLengthRule(this.Address1, 55, value);
			if(rule.Length > 0)
				return rule;

			return string.Empty;
		}

		public virtual string CheckBuildingID(System.Int32 value)
		{
			return string.Empty;
		}

		#endregion

		#region Property Names
		protected virtual string ACOutputGroupPK
		{
			get { return "ACOutputGroupPK"; }
		}

		protected virtual string ACPanelPK
		{
			get { return "ACPanelPK"; }
		}

		protected virtual string GroupID
		{
			get { return "GroupID"; }
		}

		protected virtual string Summary
		{
			get { return "Summary"; }
		}

		protected virtual string BDBuildingPK
		{
			get { return "BDBuildingPK"; }
		}

		protected virtual string UnitID
		{
			get { return "UnitID"; }
		}

		protected virtual string Address1
		{
			get { return "Address1"; }
		}

		protected virtual string BuildingID
		{
			get { return "BuildingID"; }
		}

		#endregion
	}

	public class BDTenantHolidayMapDataRule : RuleBase
	{
		public string CheckRules(BDTenantHolidayMapRuleData data)
		{
			StringBuilder builder = new StringBuilder();

			string rule;
			rule = this.CheckBDTenantHolidayMapPK(data.BDTenantHolidayMapPK);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckBDTenantPK(data.BDTenantPK);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckUtilHolidayPK(data.UtilHolidayPK);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckActionID(data.ActionID);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckNotes(data.Notes);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckTenant(data.Tenant);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckBDBuildingPK(data.BDBuildingPK);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckDate(data.Date);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckHoliday(data.Holiday);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckAddress1(data.Address1);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckBuildingID(data.BuildingID);
			if (rule.Length > 0)
				builder.AppendLine(rule);


			rule = this.CheckComprehensiveRules(data);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			return builder.ToString();
		}

		protected virtual string CheckComprehensiveRules(BDTenantHolidayMapRuleData data)
		{
			return string.Empty;
		}

		#region Property Rules
		public virtual string CheckBDTenantHolidayMapPK(System.Guid value)
		{
			string rule;
			rule = this.BrokenNotEmptyRule(this.BDTenantHolidayMapPK, value);
			if(rule.Length > 0)
				return rule;

			return string.Empty;
		}

		public virtual string CheckBDTenantPK(System.Guid value)
		{
			string rule;
			rule = this.BrokenNotEmptyRule(this.BDTenantPK, value);
			if(rule.Length > 0)
				return rule;

			return string.Empty;
		}

		public virtual string CheckUtilHolidayPK(System.Guid value)
		{
			string rule;
			rule = this.BrokenNotEmptyRule(this.UtilHolidayPK, value);
			if(rule.Length > 0)
				return rule;

			return string.Empty;
		}

		public virtual string CheckActionID(System.Int32 value)
		{
			return string.Empty;
		}

		public virtual string CheckNotes(System.String value)
		{
			string rule;
			rule = this.BrokenMaxLengthRule(this.Notes, 256, value);
			if(rule.Length > 0)
				return rule;

			return string.Empty;
		}

		public virtual string CheckTenant(System.String value)
		{
			string rule;
			rule = this.BrokenNotEmptyRule(this.Tenant, value);
			if(rule.Length > 0)
				return rule;

			rule = this.BrokenMaxLengthRule(this.Tenant, 60, value);
			if(rule.Length > 0)
				return rule;

			return string.Empty;
		}

		public virtual string CheckBDBuildingPK(System.Guid value)
		{
			string rule;
			rule = this.BrokenNotEmptyRule(this.BDBuildingPK, value);
			if(rule.Length > 0)
				return rule;

			return string.Empty;
		}

		public virtual string CheckDate(System.DateTime value)
		{
			return string.Empty;
		}

		public virtual string CheckHoliday(System.String value)
		{
			string rule;
			rule = this.BrokenNotEmptyRule(this.Holiday, value);
			if(rule.Length > 0)
				return rule;

			rule = this.BrokenMaxLengthRule(this.Holiday, 30, value);
			if(rule.Length > 0)
				return rule;

			return string.Empty;
		}

		public virtual string CheckAddress1(System.String value)
		{
			string rule;
			rule = this.BrokenNotEmptyRule(this.Address1, value);
			if(rule.Length > 0)
				return rule;

			rule = this.BrokenMaxLengthRule(this.Address1, 55, value);
			if(rule.Length > 0)
				return rule;

			return string.Empty;
		}

		public virtual string CheckBuildingID(System.Int32 value)
		{
			return string.Empty;
		}

		#endregion

		#region Property Names
		protected virtual string BDTenantHolidayMapPK
		{
			get { return "BDTenantHolidayMapPK"; }
		}

		protected virtual string BDTenantPK
		{
			get { return "BDTenantPK"; }
		}

		protected virtual string UtilHolidayPK
		{
			get { return "UtilHolidayPK"; }
		}

		protected virtual string ActionID
		{
			get { return "ActionID"; }
		}

		protected virtual string Notes
		{
			get { return "Notes"; }
		}

		protected virtual string Tenant
		{
			get { return "Tenant"; }
		}

		protected virtual string BDBuildingPK
		{
			get { return "BDBuildingPK"; }
		}

		protected virtual string Date
		{
			get { return "Date"; }
		}

		protected virtual string Holiday
		{
			get { return "Holiday"; }
		}

		protected virtual string Address1
		{
			get { return "Address1"; }
		}

		protected virtual string BuildingID
		{
			get { return "BuildingID"; }
		}

		#endregion
	}

	public class LogRowsCountDataRule : RuleBase
	{
		public string CheckRules(LogRowsCountRuleData data)
		{
			StringBuilder builder = new StringBuilder();

			string rule;
			rule = this.CheckLogRowsCountPK(data.LogRowsCountPK);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckSessionID(data.SessionID);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckSessionDateTime(data.SessionDateTime);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckDBTableName(data.DBTableName);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckSequenceID(data.SequenceID);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckRowsCount(data.RowsCount);
			if (rule.Length > 0)
				builder.AppendLine(rule);


			rule = this.CheckComprehensiveRules(data);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			return builder.ToString();
		}

		protected virtual string CheckComprehensiveRules(LogRowsCountRuleData data)
		{
			return string.Empty;
		}

		#region Property Rules
		public virtual string CheckLogRowsCountPK(System.Guid value)
		{
			string rule;
			rule = this.BrokenNotEmptyRule(this.LogRowsCountPK, value);
			if(rule.Length > 0)
				return rule;

			return string.Empty;
		}

		public virtual string CheckSessionID(System.Guid value)
		{
			string rule;
			rule = this.BrokenNotEmptyRule(this.SessionID, value);
			if(rule.Length > 0)
				return rule;

			return string.Empty;
		}

		public virtual string CheckSessionDateTime(System.DateTime value)
		{
			return string.Empty;
		}

		public virtual string CheckDBTableName(System.String value)
		{
			string rule;
			rule = this.BrokenMaxLengthRule(this.DBTableName, 128, value);
			if(rule.Length > 0)
				return rule;

			return string.Empty;
		}

		public virtual string CheckSequenceID(System.Int32 value)
		{
			return string.Empty;
		}

		public virtual string CheckRowsCount(System.Int32 value)
		{
			return string.Empty;
		}

		#endregion

		#region Property Names
		protected virtual string LogRowsCountPK
		{
			get { return "LogRowsCountPK"; }
		}

		protected virtual string SessionID
		{
			get { return "SessionID"; }
		}

		protected virtual string SessionDateTime
		{
			get { return "SessionDateTime"; }
		}

		protected virtual string DBTableName
		{
			get { return "DBTableName"; }
		}

		protected virtual string SequenceID
		{
			get { return "SequenceID"; }
		}

		protected virtual string RowsCount
		{
			get { return "RowsCount"; }
		}

		#endregion
	}

	public class ACInputGroupDataRule : RuleBase
	{
		public string CheckRules(ACInputGroupRuleData data)
		{
			StringBuilder builder = new StringBuilder();

			string rule;
			rule = this.CheckACInputGroupPK(data.ACInputGroupPK);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckACPanelPK(data.ACPanelPK);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckGroupID(data.GroupID);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckSummary(data.Summary);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckBDBuildingPK(data.BDBuildingPK);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckUnitID(data.UnitID);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckAddress1(data.Address1);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckBuildingID(data.BuildingID);
			if (rule.Length > 0)
				builder.AppendLine(rule);


			rule = this.CheckComprehensiveRules(data);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			return builder.ToString();
		}

		protected virtual string CheckComprehensiveRules(ACInputGroupRuleData data)
		{
			return string.Empty;
		}

		#region Property Rules
		public virtual string CheckACInputGroupPK(System.Guid value)
		{
			string rule;
			rule = this.BrokenNotEmptyRule(this.ACInputGroupPK, value);
			if(rule.Length > 0)
				return rule;

			return string.Empty;
		}

		public virtual string CheckACPanelPK(System.Guid value)
		{
			string rule;
			rule = this.BrokenNotEmptyRule(this.ACPanelPK, value);
			if(rule.Length > 0)
				return rule;

			return string.Empty;
		}

		public virtual string CheckGroupID(System.Byte value)
		{
			return string.Empty;
		}

		public virtual string CheckSummary(System.String value)
		{
			string rule;
			rule = this.BrokenNotEmptyRule(this.Summary, value);
			if(rule.Length > 0)
				return rule;

			rule = this.BrokenMaxLengthRule(this.Summary, 256, value);
			if(rule.Length > 0)
				return rule;

			return string.Empty;
		}

		public virtual string CheckBDBuildingPK(System.Guid value)
		{
			string rule;
			rule = this.BrokenNotEmptyRule(this.BDBuildingPK, value);
			if(rule.Length > 0)
				return rule;

			return string.Empty;
		}

		public virtual string CheckUnitID(System.Int32 value)
		{
			return string.Empty;
		}

		public virtual string CheckAddress1(System.String value)
		{
			string rule;
			rule = this.BrokenNotEmptyRule(this.Address1, value);
			if(rule.Length > 0)
				return rule;

			rule = this.BrokenMaxLengthRule(this.Address1, 55, value);
			if(rule.Length > 0)
				return rule;

			return string.Empty;
		}

		public virtual string CheckBuildingID(System.Int32 value)
		{
			return string.Empty;
		}

		#endregion

		#region Property Names
		protected virtual string ACInputGroupPK
		{
			get { return "ACInputGroupPK"; }
		}

		protected virtual string ACPanelPK
		{
			get { return "ACPanelPK"; }
		}

		protected virtual string GroupID
		{
			get { return "GroupID"; }
		}

		protected virtual string Summary
		{
			get { return "Summary"; }
		}

		protected virtual string BDBuildingPK
		{
			get { return "BDBuildingPK"; }
		}

		protected virtual string UnitID
		{
			get { return "UnitID"; }
		}

		protected virtual string Address1
		{
			get { return "Address1"; }
		}

		protected virtual string BuildingID
		{
			get { return "BuildingID"; }
		}

		#endregion
	}

	public class ACInputDataRule : RuleBase
	{
		public string CheckRules(ACInputRuleData data)
		{
			StringBuilder builder = new StringBuilder();

			string rule;
			rule = this.CheckACInputPK(data.ACInputPK);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckACPanelPK(data.ACPanelPK);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckInputID(data.InputID);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckDescription(data.Description);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckDebounce(data.Debounce);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckReverse(data.Reverse);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckForceAMFormat(data.ForceAMFormat);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckOffOnRestore(data.OffOnRestore);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckExternal(data.External);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckNotes(data.Notes);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckAlwaysToMAS(data.AlwaysToMAS);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckPanelZoneID(data.PanelZoneID);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckLocked(data.Locked);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckBDBuildingPK(data.BDBuildingPK);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckUnitID(data.UnitID);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckAddress1(data.Address1);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckBuildingID(data.BuildingID);
			if (rule.Length > 0)
				builder.AppendLine(rule);


			rule = this.CheckComprehensiveRules(data);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			return builder.ToString();
		}

		protected virtual string CheckComprehensiveRules(ACInputRuleData data)
		{
			return string.Empty;
		}

		#region Property Rules
		public virtual string CheckACInputPK(System.Guid value)
		{
			string rule;
			rule = this.BrokenNotEmptyRule(this.ACInputPK, value);
			if(rule.Length > 0)
				return rule;

			return string.Empty;
		}

		public virtual string CheckACPanelPK(System.Guid value)
		{
			string rule;
			rule = this.BrokenNotEmptyRule(this.ACPanelPK, value);
			if(rule.Length > 0)
				return rule;

			return string.Empty;
		}

		public virtual string CheckInputID(System.Byte value)
		{
			return string.Empty;
		}

		public virtual string CheckDescription(System.String value)
		{
			string rule;
			rule = this.BrokenNotEmptyRule(this.Description, value);
			if(rule.Length > 0)
				return rule;

			rule = this.BrokenMaxLengthRule(this.Description, 30, value);
			if(rule.Length > 0)
				return rule;

			return string.Empty;
		}

		public virtual string CheckDebounce(System.Int16 value)
		{
			return string.Empty;
		}

		public virtual string CheckReverse(System.Boolean value)
		{
			return string.Empty;
		}

		public virtual string CheckForceAMFormat(System.Int16 value)
		{
			return string.Empty;
		}

		public virtual string CheckOffOnRestore(System.Boolean value)
		{
			return string.Empty;
		}

		public virtual string CheckExternal(System.Boolean value)
		{
			return string.Empty;
		}

		public virtual string CheckNotes(System.String value)
		{
			string rule;
			rule = this.BrokenMaxLengthRule(this.Notes, 512, value);
			if(rule.Length > 0)
				return rule;

			return string.Empty;
		}

		public virtual string CheckAlwaysToMAS(System.Boolean value)
		{
			return string.Empty;
		}

		public virtual string CheckPanelZoneID(System.Byte value)
		{
			return string.Empty;
		}

		public virtual string CheckLocked(System.Boolean value)
		{
			return string.Empty;
		}

		public virtual string CheckBDBuildingPK(System.Guid value)
		{
			string rule;
			rule = this.BrokenNotEmptyRule(this.BDBuildingPK, value);
			if(rule.Length > 0)
				return rule;

			return string.Empty;
		}

		public virtual string CheckUnitID(System.Int32 value)
		{
			return string.Empty;
		}

		public virtual string CheckAddress1(System.String value)
		{
			string rule;
			rule = this.BrokenNotEmptyRule(this.Address1, value);
			if(rule.Length > 0)
				return rule;

			rule = this.BrokenMaxLengthRule(this.Address1, 55, value);
			if(rule.Length > 0)
				return rule;

			return string.Empty;
		}

		public virtual string CheckBuildingID(System.Int32 value)
		{
			return string.Empty;
		}

		#endregion

		#region Property Names
		protected virtual string ACInputPK
		{
			get { return "ACInputPK"; }
		}

		protected virtual string ACPanelPK
		{
			get { return "ACPanelPK"; }
		}

		protected virtual string InputID
		{
			get { return "InputID"; }
		}

		protected virtual string Description
		{
			get { return "Description"; }
		}

		protected virtual string Debounce
		{
			get { return "Debounce"; }
		}

		protected virtual string Reverse
		{
			get { return "Reverse"; }
		}

		protected virtual string ForceAMFormat
		{
			get { return "ForceAMFormat"; }
		}

		protected virtual string OffOnRestore
		{
			get { return "OffOnRestore"; }
		}

		protected virtual string External
		{
			get { return "External"; }
		}

		protected virtual string Notes
		{
			get { return "Notes"; }
		}

		protected virtual string AlwaysToMAS
		{
			get { return "AlwaysToMAS"; }
		}

		protected virtual string PanelZoneID
		{
			get { return "PanelZoneID"; }
		}

		protected virtual string Locked
		{
			get { return "Locked"; }
		}

		protected virtual string BDBuildingPK
		{
			get { return "BDBuildingPK"; }
		}

		protected virtual string UnitID
		{
			get { return "UnitID"; }
		}

		protected virtual string Address1
		{
			get { return "Address1"; }
		}

		protected virtual string BuildingID
		{
			get { return "BuildingID"; }
		}

		#endregion
	}

	public class ACFunctionCardDataRule : RuleBase
	{
		public string CheckRules(ACFunctionCardRuleData data)
		{
			StringBuilder builder = new StringBuilder();

			string rule;
			rule = this.CheckACFunctionCardPK(data.ACFunctionCardPK);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckSitecode(data.Sitecode);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckEmbossed(data.Embossed);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckEncoded(data.Encoded);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckCardTypeID(data.CardTypeID);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckBDTenantPK(data.BDTenantPK);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckFunctionID(data.FunctionID);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckFirstName(data.FirstName);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckLastName(data.LastName);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckFIPS(data.FIPS);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckPin(data.Pin);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckValidFrom(data.ValidFrom);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckValidThru(data.ValidThru);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckSuite(data.Suite);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckTenant(data.Tenant);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckBDBuildingPK(data.BDBuildingPK);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckAddress1(data.Address1);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckBuildingID(data.BuildingID);
			if (rule.Length > 0)
				builder.AppendLine(rule);


			rule = this.CheckComprehensiveRules(data);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			return builder.ToString();
		}

		protected virtual string CheckComprehensiveRules(ACFunctionCardRuleData data)
		{
			return string.Empty;
		}

		#region Property Rules
		public virtual string CheckACFunctionCardPK(System.Guid value)
		{
			string rule;
			rule = this.BrokenNotEmptyRule(this.ACFunctionCardPK, value);
			if(rule.Length > 0)
				return rule;

			return string.Empty;
		}

		public virtual string CheckSitecode(System.Int32 value)
		{
			return string.Empty;
		}

		public virtual string CheckEmbossed(System.Int32 value)
		{
			return string.Empty;
		}

		public virtual string CheckEncoded(System.Int32 value)
		{
			return string.Empty;
		}

		public virtual string CheckCardTypeID(System.Int32 value)
		{
			return string.Empty;
		}

		public virtual string CheckBDTenantPK(System.Guid value)
		{
			string rule;
			rule = this.BrokenNotEmptyRule(this.BDTenantPK, value);
			if(rule.Length > 0)
				return rule;

			return string.Empty;
		}

		public virtual string CheckFunctionID(System.Int32 value)
		{
			return string.Empty;
		}

		public virtual string CheckFirstName(System.String value)
		{
			string rule;
			rule = this.BrokenMaxLengthRule(this.FirstName, 30, value);
			if(rule.Length > 0)
				return rule;

			return string.Empty;
		}

		public virtual string CheckLastName(System.String value)
		{
			string rule;
			rule = this.BrokenMaxLengthRule(this.LastName, 50, value);
			if(rule.Length > 0)
				return rule;

			return string.Empty;
		}

		public virtual string CheckFIPS(System.Boolean value)
		{
			return string.Empty;
		}

		public virtual string CheckPin(System.Int32 value)
		{
			return string.Empty;
		}

		public virtual string CheckValidFrom(System.DateTime value)
		{
			return string.Empty;
		}

		public virtual string CheckValidThru(System.DateTime value)
		{
			return string.Empty;
		}

		public virtual string CheckSuite(System.String value)
		{
			string rule;
			rule = this.BrokenNotEmptyRule(this.Suite, value);
			if(rule.Length > 0)
				return rule;

			rule = this.BrokenMaxLengthRule(this.Suite, 30, value);
			if(rule.Length > 0)
				return rule;

			return string.Empty;
		}

		public virtual string CheckTenant(System.String value)
		{
			string rule;
			rule = this.BrokenNotEmptyRule(this.Tenant, value);
			if(rule.Length > 0)
				return rule;

			rule = this.BrokenMaxLengthRule(this.Tenant, 60, value);
			if(rule.Length > 0)
				return rule;

			return string.Empty;
		}

		public virtual string CheckBDBuildingPK(System.Guid value)
		{
			string rule;
			rule = this.BrokenNotEmptyRule(this.BDBuildingPK, value);
			if(rule.Length > 0)
				return rule;

			return string.Empty;
		}

		public virtual string CheckAddress1(System.String value)
		{
			string rule;
			rule = this.BrokenNotEmptyRule(this.Address1, value);
			if(rule.Length > 0)
				return rule;

			rule = this.BrokenMaxLengthRule(this.Address1, 55, value);
			if(rule.Length > 0)
				return rule;

			return string.Empty;
		}

		public virtual string CheckBuildingID(System.Int32 value)
		{
			return string.Empty;
		}

		#endregion

		#region Property Names
		protected virtual string ACFunctionCardPK
		{
			get { return "ACFunctionCardPK"; }
		}

		protected virtual string Sitecode
		{
			get { return "Sitecode"; }
		}

		protected virtual string Embossed
		{
			get { return "Embossed"; }
		}

		protected virtual string Encoded
		{
			get { return "Encoded"; }
		}

		protected virtual string CardTypeID
		{
			get { return "CardTypeID"; }
		}

		protected virtual string BDTenantPK
		{
			get { return "BDTenantPK"; }
		}

		protected virtual string FunctionID
		{
			get { return "FunctionID"; }
		}

		protected virtual string FirstName
		{
			get { return "FirstName"; }
		}

		protected virtual string LastName
		{
			get { return "LastName"; }
		}

		protected virtual string FIPS
		{
			get { return "FIPS"; }
		}

		protected virtual string Pin
		{
			get { return "Pin"; }
		}

		protected virtual string ValidFrom
		{
			get { return "ValidFrom"; }
		}

		protected virtual string ValidThru
		{
			get { return "ValidThru"; }
		}

		protected virtual string Suite
		{
			get { return "Suite"; }
		}

		protected virtual string Tenant
		{
			get { return "Tenant"; }
		}

		protected virtual string BDBuildingPK
		{
			get { return "BDBuildingPK"; }
		}

		protected virtual string Address1
		{
			get { return "Address1"; }
		}

		protected virtual string BuildingID
		{
			get { return "BuildingID"; }
		}

		#endregion
	}

	public class UtilHolidayDataRule : RuleBase
	{
		public string CheckRules(UtilHolidayRuleData data)
		{
			StringBuilder builder = new StringBuilder();

			string rule;
			rule = this.CheckUtilHolidayPK(data.UtilHolidayPK);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckCountryID(data.CountryID);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckHoliday(data.Holiday);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckDate(data.Date);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckMajor(data.Major);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckFederal(data.Federal);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckDefault(data.Default);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckActionID(data.ActionID);
			if (rule.Length > 0)
				builder.AppendLine(rule);


			rule = this.CheckComprehensiveRules(data);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			return builder.ToString();
		}

		protected virtual string CheckComprehensiveRules(UtilHolidayRuleData data)
		{
			return string.Empty;
		}

		#region Property Rules
		public virtual string CheckUtilHolidayPK(System.Guid value)
		{
			string rule;
			rule = this.BrokenNotEmptyRule(this.UtilHolidayPK, value);
			if(rule.Length > 0)
				return rule;

			return string.Empty;
		}

		public virtual string CheckCountryID(System.Int32 value)
		{
			return string.Empty;
		}

		public virtual string CheckHoliday(System.String value)
		{
			string rule;
			rule = this.BrokenMaxLengthRule(this.Holiday, 30, value);
			if(rule.Length > 0)
				return rule;

			return string.Empty;
		}

		public virtual string CheckDate(System.DateTime value)
		{
			return string.Empty;
		}

		public virtual string CheckMajor(System.Boolean value)
		{
			return string.Empty;
		}

		public virtual string CheckFederal(System.Boolean value)
		{
			return string.Empty;
		}

		public virtual string CheckDefault(System.Boolean value)
		{
			return string.Empty;
		}

		public virtual string CheckActionID(System.Int32 value)
		{
			return string.Empty;
		}

		#endregion

		#region Property Names
		protected virtual string UtilHolidayPK
		{
			get { return "UtilHolidayPK"; }
		}

		protected virtual string CountryID
		{
			get { return "CountryID"; }
		}

		protected virtual string Holiday
		{
			get { return "Holiday"; }
		}

		protected virtual string Date
		{
			get { return "Date"; }
		}

		protected virtual string Major
		{
			get { return "Major"; }
		}

		protected virtual string Federal
		{
			get { return "Federal"; }
		}

		protected virtual string Default
		{
			get { return "Default"; }
		}

		protected virtual string ActionID
		{
			get { return "ActionID"; }
		}

		#endregion
	}

	public class ACAccessLevelDataRule : RuleBase
	{
		public string CheckRules(ACAccessLevelRuleData data)
		{
			StringBuilder builder = new StringBuilder();

			string rule;
			rule = this.CheckACAccessLevelPK(data.ACAccessLevelPK);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckBDBuildingPK(data.BDBuildingPK);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckAccessLevelID(data.AccessLevelID);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckSummary(data.Summary);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckAsAL2(data.AsAL2);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckNotes(data.Notes);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckAddress1(data.Address1);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckBuildingID(data.BuildingID);
			if (rule.Length > 0)
				builder.AppendLine(rule);


			rule = this.CheckComprehensiveRules(data);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			return builder.ToString();
		}

		protected virtual string CheckComprehensiveRules(ACAccessLevelRuleData data)
		{
			return string.Empty;
		}

		#region Property Rules
		public virtual string CheckACAccessLevelPK(System.Guid value)
		{
			string rule;
			rule = this.BrokenNotEmptyRule(this.ACAccessLevelPK, value);
			if(rule.Length > 0)
				return rule;

			return string.Empty;
		}

		public virtual string CheckBDBuildingPK(System.Guid value)
		{
			string rule;
			rule = this.BrokenNotEmptyRule(this.BDBuildingPK, value);
			if(rule.Length > 0)
				return rule;

			return string.Empty;
		}

		public virtual string CheckAccessLevelID(System.Int16 value)
		{
			return string.Empty;
		}

		public virtual string CheckSummary(System.String value)
		{
			string rule;
			rule = this.BrokenNotEmptyRule(this.Summary, value);
			if(rule.Length > 0)
				return rule;

			rule = this.BrokenMaxLengthRule(this.Summary, 256, value);
			if(rule.Length > 0)
				return rule;

			return string.Empty;
		}

		public virtual string CheckAsAL2(System.Boolean value)
		{
			return string.Empty;
		}

		public virtual string CheckNotes(System.String value)
		{
			string rule;
			rule = this.BrokenMaxLengthRule(this.Notes, 512, value);
			if(rule.Length > 0)
				return rule;

			return string.Empty;
		}

		public virtual string CheckAddress1(System.String value)
		{
			string rule;
			rule = this.BrokenNotEmptyRule(this.Address1, value);
			if(rule.Length > 0)
				return rule;

			rule = this.BrokenMaxLengthRule(this.Address1, 55, value);
			if(rule.Length > 0)
				return rule;

			return string.Empty;
		}

		public virtual string CheckBuildingID(System.Int32 value)
		{
			return string.Empty;
		}

		#endregion

		#region Property Names
		protected virtual string ACAccessLevelPK
		{
			get { return "ACAccessLevelPK"; }
		}

		protected virtual string BDBuildingPK
		{
			get { return "BDBuildingPK"; }
		}

		protected virtual string AccessLevelID
		{
			get { return "AccessLevelID"; }
		}

		protected virtual string Summary
		{
			get { return "Summary"; }
		}

		protected virtual string AsAL2
		{
			get { return "AsAL2"; }
		}

		protected virtual string Notes
		{
			get { return "Notes"; }
		}

		protected virtual string Address1
		{
			get { return "Address1"; }
		}

		protected virtual string BuildingID
		{
			get { return "BuildingID"; }
		}

		#endregion
	}

	public class ACPanelFunctionCardMapDataRule : RuleBase
	{
		public string CheckRules(ACPanelFunctionCardMapRuleData data)
		{
			StringBuilder builder = new StringBuilder();

			string rule;
			rule = this.CheckACPanelFunctionCardMapPK(data.ACPanelFunctionCardMapPK);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckACPanelPK(data.ACPanelPK);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckACFunctionCardPK(data.ACFunctionCardPK);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckCardTypeID(data.CardTypeID);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckEncoded(data.Encoded);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckEmbossed(data.Embossed);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckSitecode(data.Sitecode);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckBDBuildingPK(data.BDBuildingPK);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckUnitID(data.UnitID);
			if (rule.Length > 0)
				builder.AppendLine(rule);


			rule = this.CheckComprehensiveRules(data);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			return builder.ToString();
		}

		protected virtual string CheckComprehensiveRules(ACPanelFunctionCardMapRuleData data)
		{
			return string.Empty;
		}

		#region Property Rules
		public virtual string CheckACPanelFunctionCardMapPK(System.Guid value)
		{
			string rule;
			rule = this.BrokenNotEmptyRule(this.ACPanelFunctionCardMapPK, value);
			if(rule.Length > 0)
				return rule;

			return string.Empty;
		}

		public virtual string CheckACPanelPK(System.Guid value)
		{
			string rule;
			rule = this.BrokenNotEmptyRule(this.ACPanelPK, value);
			if(rule.Length > 0)
				return rule;

			return string.Empty;
		}

		public virtual string CheckACFunctionCardPK(System.Guid value)
		{
			string rule;
			rule = this.BrokenNotEmptyRule(this.ACFunctionCardPK, value);
			if(rule.Length > 0)
				return rule;

			return string.Empty;
		}

		public virtual string CheckCardTypeID(System.Int32 value)
		{
			return string.Empty;
		}

		public virtual string CheckEncoded(System.Int32 value)
		{
			return string.Empty;
		}

		public virtual string CheckEmbossed(System.Int32 value)
		{
			return string.Empty;
		}

		public virtual string CheckSitecode(System.Int32 value)
		{
			return string.Empty;
		}

		public virtual string CheckBDBuildingPK(System.Guid value)
		{
			string rule;
			rule = this.BrokenNotEmptyRule(this.BDBuildingPK, value);
			if(rule.Length > 0)
				return rule;

			return string.Empty;
		}

		public virtual string CheckUnitID(System.Int32 value)
		{
			return string.Empty;
		}

		#endregion

		#region Property Names
		protected virtual string ACPanelFunctionCardMapPK
		{
			get { return "ACPanelFunctionCardMapPK"; }
		}

		protected virtual string ACPanelPK
		{
			get { return "ACPanelPK"; }
		}

		protected virtual string ACFunctionCardPK
		{
			get { return "ACFunctionCardPK"; }
		}

		protected virtual string CardTypeID
		{
			get { return "CardTypeID"; }
		}

		protected virtual string Encoded
		{
			get { return "Encoded"; }
		}

		protected virtual string Embossed
		{
			get { return "Embossed"; }
		}

		protected virtual string Sitecode
		{
			get { return "Sitecode"; }
		}

		protected virtual string BDBuildingPK
		{
			get { return "BDBuildingPK"; }
		}

		protected virtual string UnitID
		{
			get { return "UnitID"; }
		}

		#endregion
	}

	public class LogDBDeleteActivityDataRule : RuleBase
	{
		public string CheckRules(LogDBDeleteActivityRuleData data)
		{
			StringBuilder builder = new StringBuilder();

			string rule;
			rule = this.CheckLogDBDeleteActivityPK(data.LogDBDeleteActivityPK);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckLogDateTime(data.LogDateTime);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckDBTableName(data.DBTableName);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckRecordPK(data.RecordPK);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckLastUpdated(data.LastUpdated);
			if (rule.Length > 0)
				builder.AppendLine(rule);


			rule = this.CheckComprehensiveRules(data);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			return builder.ToString();
		}

		protected virtual string CheckComprehensiveRules(LogDBDeleteActivityRuleData data)
		{
			return string.Empty;
		}

		#region Property Rules
		public virtual string CheckLogDBDeleteActivityPK(System.Guid value)
		{
			string rule;
			rule = this.BrokenNotEmptyRule(this.LogDBDeleteActivityPK, value);
			if(rule.Length > 0)
				return rule;

			return string.Empty;
		}

		public virtual string CheckLogDateTime(System.DateTime value)
		{
			return string.Empty;
		}

		public virtual string CheckDBTableName(System.String value)
		{
			string rule;
			rule = this.BrokenNotEmptyRule(this.DBTableName, value);
			if(rule.Length > 0)
				return rule;

			rule = this.BrokenMaxLengthRule(this.DBTableName, 128, value);
			if(rule.Length > 0)
				return rule;

			return string.Empty;
		}

		public virtual string CheckRecordPK(System.Guid value)
		{
			string rule;
			return string.Empty;
		}

		public virtual string CheckLastUpdated(System.DateTime value)
		{
			return string.Empty;
		}

		#endregion

		#region Property Names
		protected virtual string LogDBDeleteActivityPK
		{
			get { return "LogDBDeleteActivityPK"; }
		}

		protected virtual string LogDateTime
		{
			get { return "LogDateTime"; }
		}

		protected virtual string DBTableName
		{
			get { return "DBTableName"; }
		}

		protected virtual string RecordPK
		{
			get { return "RecordPK"; }
		}

		protected virtual string LastUpdated
		{
			get { return "LastUpdated"; }
		}

		#endregion
	}

	public class UsrAccountDataRule : RuleBase
	{
		public string CheckRules(UsrAccountRuleData data)
		{
			StringBuilder builder = new StringBuilder();

			string rule;
			rule = this.CheckUsrAccountPK(data.UsrAccountPK);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckUserID(data.UserID);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckIsAdmin(data.IsAdmin);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckIsCentral(data.IsCentral);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckFirstName(data.FirstName);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckLastName(data.LastName);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckPassword(data.Password);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckPwdExpireDate(data.PwdExpireDate);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckUsrGroupPK(data.UsrGroupPK);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckBDTenantPK(data.BDTenantPK);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckCellPhone(data.CellPhone);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckHomePhone(data.HomePhone);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckOfficePhone(data.OfficePhone);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckEmail(data.Email);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckLastLogin(data.LastLogin);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckTotalUsage(data.TotalUsage);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckStartScreen(data.StartScreen);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckPopupExtension(data.PopupExtension);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckSuite(data.Suite);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckTenant(data.Tenant);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckBDBuildingPK(data.BDBuildingPK);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckUsrGroupName(data.UsrGroupName);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckAddress1(data.Address1);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckBuildingID(data.BuildingID);
			if (rule.Length > 0)
				builder.AppendLine(rule);


			rule = this.CheckComprehensiveRules(data);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			return builder.ToString();
		}

		protected virtual string CheckComprehensiveRules(UsrAccountRuleData data)
		{
			return string.Empty;
		}

		#region Property Rules
		public virtual string CheckUsrAccountPK(System.Guid value)
		{
			string rule;
			rule = this.BrokenNotEmptyRule(this.UsrAccountPK, value);
			if(rule.Length > 0)
				return rule;

			return string.Empty;
		}

		public virtual string CheckUserID(System.String value)
		{
			string rule;
			rule = this.BrokenNotEmptyRule(this.UserID, value);
			if(rule.Length > 0)
				return rule;

			rule = this.BrokenMaxLengthRule(this.UserID, 30, value);
			if(rule.Length > 0)
				return rule;

			return string.Empty;
		}

		public virtual string CheckIsAdmin(System.Boolean value)
		{
			return string.Empty;
		}

		public virtual string CheckIsCentral(System.Boolean value)
		{
			return string.Empty;
		}

		public virtual string CheckFirstName(System.String value)
		{
			string rule;
			rule = this.BrokenMaxLengthRule(this.FirstName, 30, value);
			if(rule.Length > 0)
				return rule;

			return string.Empty;
		}

		public virtual string CheckLastName(System.String value)
		{
			string rule;
			rule = this.BrokenMaxLengthRule(this.LastName, 50, value);
			if(rule.Length > 0)
				return rule;

			return string.Empty;
		}

		public virtual string CheckPassword(System.String value)
		{
			string rule;
			rule = this.BrokenMaxLengthRule(this.Password, 30, value);
			if(rule.Length > 0)
				return rule;

			return string.Empty;
		}

		public virtual string CheckPwdExpireDate(System.DateTime value)
		{
			return string.Empty;
		}

		public virtual string CheckUsrGroupPK(System.Guid value)
		{
			string rule;
			return string.Empty;
		}

		public virtual string CheckBDTenantPK(System.Guid value)
		{
			string rule;
			return string.Empty;
		}

		public virtual string CheckCellPhone(System.String value)
		{
			string rule;
			rule = this.BrokenMaxLengthRule(this.CellPhone, 20, value);
			if(rule.Length > 0)
				return rule;

			return string.Empty;
		}

		public virtual string CheckHomePhone(System.String value)
		{
			string rule;
			rule = this.BrokenMaxLengthRule(this.HomePhone, 20, value);
			if(rule.Length > 0)
				return rule;

			return string.Empty;
		}

		public virtual string CheckOfficePhone(System.String value)
		{
			string rule;
			rule = this.BrokenMaxLengthRule(this.OfficePhone, 20, value);
			if(rule.Length > 0)
				return rule;

			return string.Empty;
		}

		public virtual string CheckEmail(System.String value)
		{
			string rule;
			rule = this.BrokenMaxLengthRule(this.Email, 50, value);
			if(rule.Length > 0)
				return rule;

			return string.Empty;
		}

		public virtual string CheckLastLogin(System.DateTime value)
		{
			return string.Empty;
		}

		public virtual string CheckTotalUsage(System.Int32 value)
		{
			return string.Empty;
		}

		public virtual string CheckStartScreen(System.String value)
		{
			string rule;
			rule = this.BrokenMaxLengthRule(this.StartScreen, 512, value);
			if(rule.Length > 0)
				return rule;

			return string.Empty;
		}

		public virtual string CheckPopupExtension(System.Int32 value)
		{
			return string.Empty;
		}

		public virtual string CheckSuite(System.String value)
		{
			string rule;
			rule = this.BrokenNotEmptyRule(this.Suite, value);
			if(rule.Length > 0)
				return rule;

			rule = this.BrokenMaxLengthRule(this.Suite, 30, value);
			if(rule.Length > 0)
				return rule;

			return string.Empty;
		}

		public virtual string CheckTenant(System.String value)
		{
			string rule;
			rule = this.BrokenNotEmptyRule(this.Tenant, value);
			if(rule.Length > 0)
				return rule;

			rule = this.BrokenMaxLengthRule(this.Tenant, 60, value);
			if(rule.Length > 0)
				return rule;

			return string.Empty;
		}

		public virtual string CheckBDBuildingPK(System.Guid value)
		{
			string rule;
			rule = this.BrokenNotEmptyRule(this.BDBuildingPK, value);
			if(rule.Length > 0)
				return rule;

			return string.Empty;
		}

		public virtual string CheckUsrGroupName(System.String value)
		{
			string rule;
			rule = this.BrokenNotEmptyRule(this.UsrGroupName, value);
			if(rule.Length > 0)
				return rule;

			rule = this.BrokenMaxLengthRule(this.UsrGroupName, 50, value);
			if(rule.Length > 0)
				return rule;

			return string.Empty;
		}

		public virtual string CheckAddress1(System.String value)
		{
			string rule;
			rule = this.BrokenNotEmptyRule(this.Address1, value);
			if(rule.Length > 0)
				return rule;

			rule = this.BrokenMaxLengthRule(this.Address1, 55, value);
			if(rule.Length > 0)
				return rule;

			return string.Empty;
		}

		public virtual string CheckBuildingID(System.Int32 value)
		{
			return string.Empty;
		}

		#endregion

		#region Property Names
		protected virtual string UsrAccountPK
		{
			get { return "UsrAccountPK"; }
		}

		protected virtual string UserID
		{
			get { return "UserID"; }
		}

		protected virtual string IsAdmin
		{
			get { return "IsAdmin"; }
		}

		protected virtual string IsCentral
		{
			get { return "IsCentral"; }
		}

		protected virtual string FirstName
		{
			get { return "FirstName"; }
		}

		protected virtual string LastName
		{
			get { return "LastName"; }
		}

		protected virtual string Password
		{
			get { return "Password"; }
		}

		protected virtual string PwdExpireDate
		{
			get { return "PwdExpireDate"; }
		}

		protected virtual string UsrGroupPK
		{
			get { return "UsrGroupPK"; }
		}

		protected virtual string BDTenantPK
		{
			get { return "BDTenantPK"; }
		}

		protected virtual string CellPhone
		{
			get { return "CellPhone"; }
		}

		protected virtual string HomePhone
		{
			get { return "HomePhone"; }
		}

		protected virtual string OfficePhone
		{
			get { return "OfficePhone"; }
		}

		protected virtual string Email
		{
			get { return "Email"; }
		}

		protected virtual string LastLogin
		{
			get { return "LastLogin"; }
		}

		protected virtual string TotalUsage
		{
			get { return "TotalUsage"; }
		}

		protected virtual string StartScreen
		{
			get { return "StartScreen"; }
		}

		protected virtual string PopupExtension
		{
			get { return "PopupExtension"; }
		}

		protected virtual string Suite
		{
			get { return "Suite"; }
		}

		protected virtual string Tenant
		{
			get { return "Tenant"; }
		}

		protected virtual string BDBuildingPK
		{
			get { return "BDBuildingPK"; }
		}

		protected virtual string UsrGroupName
		{
			get { return "UsrGroupName"; }
		}

		protected virtual string Address1
		{
			get { return "Address1"; }
		}

		protected virtual string BuildingID
		{
			get { return "BuildingID"; }
		}

		#endregion
	}

	public class LogDBEditActivityDataRule : RuleBase
	{
		public string CheckRules(LogDBEditActivityRuleData data)
		{
			StringBuilder builder = new StringBuilder();

			string rule;
			rule = this.CheckLogDBEditActivityPK(data.LogDBEditActivityPK);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckLogDateTime(data.LogDateTime);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckDBTableName(data.DBTableName);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckRecordPK(data.RecordPK);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckCategory(data.Category);
			if (rule.Length > 0)
				builder.AppendLine(rule);


			rule = this.CheckComprehensiveRules(data);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			return builder.ToString();
		}

		protected virtual string CheckComprehensiveRules(LogDBEditActivityRuleData data)
		{
			return string.Empty;
		}

		#region Property Rules
		public virtual string CheckLogDBEditActivityPK(System.Guid value)
		{
			string rule;
			rule = this.BrokenNotEmptyRule(this.LogDBEditActivityPK, value);
			if(rule.Length > 0)
				return rule;

			return string.Empty;
		}

		public virtual string CheckLogDateTime(System.DateTime value)
		{
			return string.Empty;
		}

		public virtual string CheckDBTableName(System.String value)
		{
			string rule;
			rule = this.BrokenNotEmptyRule(this.DBTableName, value);
			if(rule.Length > 0)
				return rule;

			rule = this.BrokenMaxLengthRule(this.DBTableName, 128, value);
			if(rule.Length > 0)
				return rule;

			return string.Empty;
		}

		public virtual string CheckRecordPK(System.Guid value)
		{
			string rule;
			return string.Empty;
		}

		public virtual string CheckCategory(System.String value)
		{
			string rule;
			rule = this.BrokenMaxLengthRule(this.Category, 20, value);
			if(rule.Length > 0)
				return rule;

			return string.Empty;
		}

		#endregion

		#region Property Names
		protected virtual string LogDBEditActivityPK
		{
			get { return "LogDBEditActivityPK"; }
		}

		protected virtual string LogDateTime
		{
			get { return "LogDateTime"; }
		}

		protected virtual string DBTableName
		{
			get { return "DBTableName"; }
		}

		protected virtual string RecordPK
		{
			get { return "RecordPK"; }
		}

		protected virtual string Category
		{
			get { return "Category"; }
		}

		#endregion
	}

	public class ACMasterCardDataRule : RuleBase
	{
		public string CheckRules(ACMasterCardRuleData data)
		{
			StringBuilder builder = new StringBuilder();

			string rule;
			rule = this.CheckACMasterCardPK(data.ACMasterCardPK);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckSitecode(data.Sitecode);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckEmbossed(data.Embossed);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckEncoded(data.Encoded);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckCardTypeID(data.CardTypeID);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckFirstName(data.FirstName);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckLastName(data.LastName);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckFIPS(data.FIPS);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckPin(data.Pin);
			if (rule.Length > 0)
				builder.AppendLine(rule);


			rule = this.CheckComprehensiveRules(data);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			return builder.ToString();
		}

		protected virtual string CheckComprehensiveRules(ACMasterCardRuleData data)
		{
			return string.Empty;
		}

		#region Property Rules
		public virtual string CheckACMasterCardPK(System.Guid value)
		{
			string rule;
			rule = this.BrokenNotEmptyRule(this.ACMasterCardPK, value);
			if(rule.Length > 0)
				return rule;

			return string.Empty;
		}

		public virtual string CheckSitecode(System.Int32 value)
		{
			return string.Empty;
		}

		public virtual string CheckEmbossed(System.Int32 value)
		{
			return string.Empty;
		}

		public virtual string CheckEncoded(System.Int32 value)
		{
			return string.Empty;
		}

		public virtual string CheckCardTypeID(System.Int32 value)
		{
			return string.Empty;
		}

		public virtual string CheckFirstName(System.String value)
		{
			string rule;
			rule = this.BrokenMaxLengthRule(this.FirstName, 30, value);
			if(rule.Length > 0)
				return rule;

			return string.Empty;
		}

		public virtual string CheckLastName(System.String value)
		{
			string rule;
			rule = this.BrokenMaxLengthRule(this.LastName, 50, value);
			if(rule.Length > 0)
				return rule;

			return string.Empty;
		}

		public virtual string CheckFIPS(System.Boolean value)
		{
			return string.Empty;
		}

		public virtual string CheckPin(System.Int32 value)
		{
			return string.Empty;
		}

		#endregion

		#region Property Names
		protected virtual string ACMasterCardPK
		{
			get { return "ACMasterCardPK"; }
		}

		protected virtual string Sitecode
		{
			get { return "Sitecode"; }
		}

		protected virtual string Embossed
		{
			get { return "Embossed"; }
		}

		protected virtual string Encoded
		{
			get { return "Encoded"; }
		}

		protected virtual string CardTypeID
		{
			get { return "CardTypeID"; }
		}

		protected virtual string FirstName
		{
			get { return "FirstName"; }
		}

		protected virtual string LastName
		{
			get { return "LastName"; }
		}

		protected virtual string FIPS
		{
			get { return "FIPS"; }
		}

		protected virtual string Pin
		{
			get { return "Pin"; }
		}

		#endregion
	}

	public class ACSupervisoryDataRule : RuleBase
	{
		public string CheckRules(ACSupervisoryRuleData data)
		{
			StringBuilder builder = new StringBuilder();

			string rule;
			rule = this.CheckACSupervisoryPK(data.ACSupervisoryPK);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckACPanelPK(data.ACPanelPK);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckSupervisoryID(data.SupervisoryID);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckDescription(data.Description);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckDebounce(data.Debounce);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckForceAMFormat(data.ForceAMFormat);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckExternal(data.External);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckNotes(data.Notes);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckPanelZoneID(data.PanelZoneID);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckLocked(data.Locked);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckBDBuildingPK(data.BDBuildingPK);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckUnitID(data.UnitID);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckAddress1(data.Address1);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckBuildingID(data.BuildingID);
			if (rule.Length > 0)
				builder.AppendLine(rule);


			rule = this.CheckComprehensiveRules(data);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			return builder.ToString();
		}

		protected virtual string CheckComprehensiveRules(ACSupervisoryRuleData data)
		{
			return string.Empty;
		}

		#region Property Rules
		public virtual string CheckACSupervisoryPK(System.Guid value)
		{
			string rule;
			rule = this.BrokenNotEmptyRule(this.ACSupervisoryPK, value);
			if(rule.Length > 0)
				return rule;

			return string.Empty;
		}

		public virtual string CheckACPanelPK(System.Guid value)
		{
			string rule;
			rule = this.BrokenNotEmptyRule(this.ACPanelPK, value);
			if(rule.Length > 0)
				return rule;

			return string.Empty;
		}

		public virtual string CheckSupervisoryID(System.Byte value)
		{
			return string.Empty;
		}

		public virtual string CheckDescription(System.String value)
		{
			string rule;
			rule = this.BrokenNotEmptyRule(this.Description, value);
			if(rule.Length > 0)
				return rule;

			rule = this.BrokenMaxLengthRule(this.Description, 30, value);
			if(rule.Length > 0)
				return rule;

			return string.Empty;
		}

		public virtual string CheckDebounce(System.Int16 value)
		{
			return string.Empty;
		}

		public virtual string CheckForceAMFormat(System.Int16 value)
		{
			return string.Empty;
		}

		public virtual string CheckExternal(System.Boolean value)
		{
			return string.Empty;
		}

		public virtual string CheckNotes(System.String value)
		{
			string rule;
			rule = this.BrokenMaxLengthRule(this.Notes, 512, value);
			if(rule.Length > 0)
				return rule;

			return string.Empty;
		}

		public virtual string CheckPanelZoneID(System.Byte value)
		{
			return string.Empty;
		}

		public virtual string CheckLocked(System.Boolean value)
		{
			return string.Empty;
		}

		public virtual string CheckBDBuildingPK(System.Guid value)
		{
			string rule;
			rule = this.BrokenNotEmptyRule(this.BDBuildingPK, value);
			if(rule.Length > 0)
				return rule;

			return string.Empty;
		}

		public virtual string CheckUnitID(System.Int32 value)
		{
			return string.Empty;
		}

		public virtual string CheckAddress1(System.String value)
		{
			string rule;
			rule = this.BrokenNotEmptyRule(this.Address1, value);
			if(rule.Length > 0)
				return rule;

			rule = this.BrokenMaxLengthRule(this.Address1, 55, value);
			if(rule.Length > 0)
				return rule;

			return string.Empty;
		}

		public virtual string CheckBuildingID(System.Int32 value)
		{
			return string.Empty;
		}

		#endregion

		#region Property Names
		protected virtual string ACSupervisoryPK
		{
			get { return "ACSupervisoryPK"; }
		}

		protected virtual string ACPanelPK
		{
			get { return "ACPanelPK"; }
		}

		protected virtual string SupervisoryID
		{
			get { return "SupervisoryID"; }
		}

		protected virtual string Description
		{
			get { return "Description"; }
		}

		protected virtual string Debounce
		{
			get { return "Debounce"; }
		}

		protected virtual string ForceAMFormat
		{
			get { return "ForceAMFormat"; }
		}

		protected virtual string External
		{
			get { return "External"; }
		}

		protected virtual string Notes
		{
			get { return "Notes"; }
		}

		protected virtual string PanelZoneID
		{
			get { return "PanelZoneID"; }
		}

		protected virtual string Locked
		{
			get { return "Locked"; }
		}

		protected virtual string BDBuildingPK
		{
			get { return "BDBuildingPK"; }
		}

		protected virtual string UnitID
		{
			get { return "UnitID"; }
		}

		protected virtual string Address1
		{
			get { return "Address1"; }
		}

		protected virtual string BuildingID
		{
			get { return "BuildingID"; }
		}

		#endregion
	}

	public class UsrGroupDataRule : RuleBase
	{
		public string CheckRules(UsrGroupRuleData data)
		{
			StringBuilder builder = new StringBuilder();

			string rule;
			rule = this.CheckUsrGroupPK(data.UsrGroupPK);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckUsrGroupName(data.UsrGroupName);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckDescription(data.Description);
			if (rule.Length > 0)
				builder.AppendLine(rule);


			rule = this.CheckComprehensiveRules(data);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			return builder.ToString();
		}

		protected virtual string CheckComprehensiveRules(UsrGroupRuleData data)
		{
			return string.Empty;
		}

		#region Property Rules
		public virtual string CheckUsrGroupPK(System.Guid value)
		{
			string rule;
			rule = this.BrokenNotEmptyRule(this.UsrGroupPK, value);
			if(rule.Length > 0)
				return rule;

			return string.Empty;
		}

		public virtual string CheckUsrGroupName(System.String value)
		{
			string rule;
			rule = this.BrokenNotEmptyRule(this.UsrGroupName, value);
			if(rule.Length > 0)
				return rule;

			rule = this.BrokenMaxLengthRule(this.UsrGroupName, 50, value);
			if(rule.Length > 0)
				return rule;

			return string.Empty;
		}

		public virtual string CheckDescription(System.String value)
		{
			string rule;
			rule = this.BrokenMaxLengthRule(this.Description, 256, value);
			if(rule.Length > 0)
				return rule;

			return string.Empty;
		}

		#endregion

		#region Property Names
		protected virtual string UsrGroupPK
		{
			get { return "UsrGroupPK"; }
		}

		protected virtual string UsrGroupName
		{
			get { return "UsrGroupName"; }
		}

		protected virtual string Description
		{
			get { return "Description"; }
		}

		#endregion
	}

	public class ACCardHolderBuildingMapDataRule : RuleBase
	{
		public string CheckRules(ACCardHolderBuildingMapRuleData data)
		{
			StringBuilder builder = new StringBuilder();

			string rule;
			rule = this.CheckACCardHolderBuildingMapPK(data.ACCardHolderBuildingMapPK);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckACCardHolderPK(data.ACCardHolderPK);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckBDBuildingPK(data.BDBuildingPK);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckAL1st(data.AL1st);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckAL2nd(data.AL2nd);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckAddress1(data.Address1);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckBuildingID(data.BuildingID);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckLastName(data.LastName);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckFirstName(data.FirstName);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckCardTypeID(data.CardTypeID);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckEncoded(data.Encoded);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckEmbossed(data.Embossed);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckSitecode(data.Sitecode);
			if (rule.Length > 0)
				builder.AppendLine(rule);


			rule = this.CheckComprehensiveRules(data);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			return builder.ToString();
		}

		protected virtual string CheckComprehensiveRules(ACCardHolderBuildingMapRuleData data)
		{
			return string.Empty;
		}

		#region Property Rules
		public virtual string CheckACCardHolderBuildingMapPK(System.Guid value)
		{
			string rule;
			rule = this.BrokenNotEmptyRule(this.ACCardHolderBuildingMapPK, value);
			if(rule.Length > 0)
				return rule;

			return string.Empty;
		}

		public virtual string CheckACCardHolderPK(System.Guid value)
		{
			string rule;
			rule = this.BrokenNotEmptyRule(this.ACCardHolderPK, value);
			if(rule.Length > 0)
				return rule;

			return string.Empty;
		}

		public virtual string CheckBDBuildingPK(System.Guid value)
		{
			string rule;
			rule = this.BrokenNotEmptyRule(this.BDBuildingPK, value);
			if(rule.Length > 0)
				return rule;

			return string.Empty;
		}

		public virtual string CheckAL1st(System.Int16 value)
		{
			return string.Empty;
		}

		public virtual string CheckAL2nd(System.Int16 value)
		{
			return string.Empty;
		}

		public virtual string CheckAddress1(System.String value)
		{
			string rule;
			rule = this.BrokenNotEmptyRule(this.Address1, value);
			if(rule.Length > 0)
				return rule;

			rule = this.BrokenMaxLengthRule(this.Address1, 55, value);
			if(rule.Length > 0)
				return rule;

			return string.Empty;
		}

		public virtual string CheckBuildingID(System.Int32 value)
		{
			return string.Empty;
		}

		public virtual string CheckLastName(System.String value)
		{
			string rule;
			rule = this.BrokenMaxLengthRule(this.LastName, 50, value);
			if(rule.Length > 0)
				return rule;

			return string.Empty;
		}

		public virtual string CheckFirstName(System.String value)
		{
			string rule;
			rule = this.BrokenMaxLengthRule(this.FirstName, 30, value);
			if(rule.Length > 0)
				return rule;

			return string.Empty;
		}

		public virtual string CheckCardTypeID(System.Int32 value)
		{
			return string.Empty;
		}

		public virtual string CheckEncoded(System.Int32 value)
		{
			return string.Empty;
		}

		public virtual string CheckEmbossed(System.Int32 value)
		{
			return string.Empty;
		}

		public virtual string CheckSitecode(System.Int32 value)
		{
			return string.Empty;
		}

		#endregion

		#region Property Names
		protected virtual string ACCardHolderBuildingMapPK
		{
			get { return "ACCardHolderBuildingMapPK"; }
		}

		protected virtual string ACCardHolderPK
		{
			get { return "ACCardHolderPK"; }
		}

		protected virtual string BDBuildingPK
		{
			get { return "BDBuildingPK"; }
		}

		protected virtual string AL1st
		{
			get { return "AL1st"; }
		}

		protected virtual string AL2nd
		{
			get { return "AL2nd"; }
		}

		protected virtual string Address1
		{
			get { return "Address1"; }
		}

		protected virtual string BuildingID
		{
			get { return "BuildingID"; }
		}

		protected virtual string LastName
		{
			get { return "LastName"; }
		}

		protected virtual string FirstName
		{
			get { return "FirstName"; }
		}

		protected virtual string CardTypeID
		{
			get { return "CardTypeID"; }
		}

		protected virtual string Encoded
		{
			get { return "Encoded"; }
		}

		protected virtual string Embossed
		{
			get { return "Embossed"; }
		}

		protected virtual string Sitecode
		{
			get { return "Sitecode"; }
		}

		#endregion
	}

	public class BDVisitorDataRule : RuleBase
	{
		public string CheckRules(BDVisitorRuleData data)
		{
			StringBuilder builder = new StringBuilder();

			string rule;
			rule = this.CheckBDVisitorPK(data.BDVisitorPK);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckBDTenantPK(data.BDTenantPK);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckFirstName(data.FirstName);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckLastName(data.LastName);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckAuthorizedBy(data.AuthorizedBy);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckAuthorizedArea(data.AuthorizedArea);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckAuthorEmail(data.AuthorEmail);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckEmailNotify(data.EmailNotify);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckValidFrom(data.ValidFrom);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckValidThru(data.ValidThru);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckPassword(data.Password);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckSpecial(data.Special);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckBegin(data.Begin);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckEnd(data.End);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckSiteCode(data.SiteCode);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckEncoded(data.Encoded);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckScheduled(data.Scheduled);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckArrivedTime(data.ArrivedTime);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckTurnstileAccess(data.TurnstileAccess);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckBadgePrinted(data.BadgePrinted);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckSuite(data.Suite);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckTenant(data.Tenant);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckBDBuildingPK(data.BDBuildingPK);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckAddress1(data.Address1);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckBuildingID(data.BuildingID);
			if (rule.Length > 0)
				builder.AppendLine(rule);


			rule = this.CheckComprehensiveRules(data);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			return builder.ToString();
		}

		protected virtual string CheckComprehensiveRules(BDVisitorRuleData data)
		{
			return string.Empty;
		}

		#region Property Rules
		public virtual string CheckBDVisitorPK(System.Guid value)
		{
			string rule;
			rule = this.BrokenNotEmptyRule(this.BDVisitorPK, value);
			if(rule.Length > 0)
				return rule;

			return string.Empty;
		}

		public virtual string CheckBDTenantPK(System.Guid value)
		{
			string rule;
			rule = this.BrokenNotEmptyRule(this.BDTenantPK, value);
			if(rule.Length > 0)
				return rule;

			return string.Empty;
		}

		public virtual string CheckFirstName(System.String value)
		{
			string rule;
			rule = this.BrokenMaxLengthRule(this.FirstName, 30, value);
			if(rule.Length > 0)
				return rule;

			return string.Empty;
		}

		public virtual string CheckLastName(System.String value)
		{
			string rule;
			rule = this.BrokenMaxLengthRule(this.LastName, 50, value);
			if(rule.Length > 0)
				return rule;

			return string.Empty;
		}

		public virtual string CheckAuthorizedBy(System.String value)
		{
			string rule;
			rule = this.BrokenMaxLengthRule(this.AuthorizedBy, 40, value);
			if(rule.Length > 0)
				return rule;

			return string.Empty;
		}

		public virtual string CheckAuthorizedArea(System.String value)
		{
			string rule;
			rule = this.BrokenMaxLengthRule(this.AuthorizedArea, 128, value);
			if(rule.Length > 0)
				return rule;

			return string.Empty;
		}

		public virtual string CheckAuthorEmail(System.String value)
		{
			string rule;
			rule = this.BrokenMaxLengthRule(this.AuthorEmail, 50, value);
			if(rule.Length > 0)
				return rule;

			return string.Empty;
		}

		public virtual string CheckEmailNotify(System.Boolean value)
		{
			return string.Empty;
		}

		public virtual string CheckValidFrom(System.DateTime value)
		{
			return string.Empty;
		}

		public virtual string CheckValidThru(System.DateTime value)
		{
			return string.Empty;
		}

		public virtual string CheckPassword(System.String value)
		{
			string rule;
			rule = this.BrokenMaxLengthRule(this.Password, 30, value);
			if(rule.Length > 0)
				return rule;

			return string.Empty;
		}

		public virtual string CheckSpecial(System.String value)
		{
			string rule;
			rule = this.BrokenMaxLengthRule(this.Special, 1024, value);
			if(rule.Length > 0)
				return rule;

			return string.Empty;
		}

		public virtual string CheckBegin(System.String value)
		{
			string rule;
			rule = this.BrokenLengthEqualRule(this.Begin, 4, value);
			if(rule.Length > 0)
				return rule;

			rule = this.BrokenMaxLengthRule(this.Begin, 4, value);
			if(rule.Length > 0)
				return rule;

			return string.Empty;
		}

		public virtual string CheckEnd(System.String value)
		{
			string rule;
			rule = this.BrokenLengthEqualRule(this.End, 4, value);
			if(rule.Length > 0)
				return rule;

			rule = this.BrokenMaxLengthRule(this.End, 4, value);
			if(rule.Length > 0)
				return rule;

			return string.Empty;
		}

		public virtual string CheckSiteCode(System.Int32 value)
		{
			return string.Empty;
		}

		public virtual string CheckEncoded(System.Int32 value)
		{
			return string.Empty;
		}

		public virtual string CheckScheduled(System.Boolean value)
		{
			return string.Empty;
		}

		public virtual string CheckArrivedTime(System.DateTime value)
		{
			return string.Empty;
		}

		public virtual string CheckTurnstileAccess(System.Int64 value)
		{
			return string.Empty;
		}

		public virtual string CheckBadgePrinted(System.Boolean value)
		{
			return string.Empty;
		}

		public virtual string CheckSuite(System.String value)
		{
			string rule;
			rule = this.BrokenNotEmptyRule(this.Suite, value);
			if(rule.Length > 0)
				return rule;

			rule = this.BrokenMaxLengthRule(this.Suite, 30, value);
			if(rule.Length > 0)
				return rule;

			return string.Empty;
		}

		public virtual string CheckTenant(System.String value)
		{
			string rule;
			rule = this.BrokenNotEmptyRule(this.Tenant, value);
			if(rule.Length > 0)
				return rule;

			rule = this.BrokenMaxLengthRule(this.Tenant, 60, value);
			if(rule.Length > 0)
				return rule;

			return string.Empty;
		}

		public virtual string CheckBDBuildingPK(System.Guid value)
		{
			string rule;
			rule = this.BrokenNotEmptyRule(this.BDBuildingPK, value);
			if(rule.Length > 0)
				return rule;

			return string.Empty;
		}

		public virtual string CheckAddress1(System.String value)
		{
			string rule;
			rule = this.BrokenNotEmptyRule(this.Address1, value);
			if(rule.Length > 0)
				return rule;

			rule = this.BrokenMaxLengthRule(this.Address1, 55, value);
			if(rule.Length > 0)
				return rule;

			return string.Empty;
		}

		public virtual string CheckBuildingID(System.Int32 value)
		{
			return string.Empty;
		}

		#endregion

		#region Property Names
		protected virtual string BDVisitorPK
		{
			get { return "BDVisitorPK"; }
		}

		protected virtual string BDTenantPK
		{
			get { return "BDTenantPK"; }
		}

		protected virtual string FirstName
		{
			get { return "FirstName"; }
		}

		protected virtual string LastName
		{
			get { return "LastName"; }
		}

		protected virtual string AuthorizedBy
		{
			get { return "AuthorizedBy"; }
		}

		protected virtual string AuthorizedArea
		{
			get { return "AuthorizedArea"; }
		}

		protected virtual string AuthorEmail
		{
			get { return "AuthorEmail"; }
		}

		protected virtual string EmailNotify
		{
			get { return "EmailNotify"; }
		}

		protected virtual string ValidFrom
		{
			get { return "ValidFrom"; }
		}

		protected virtual string ValidThru
		{
			get { return "ValidThru"; }
		}

		protected virtual string Password
		{
			get { return "Password"; }
		}

		protected virtual string Special
		{
			get { return "Special"; }
		}

		protected virtual string Begin
		{
			get { return "Begin"; }
		}

		protected virtual string End
		{
			get { return "End"; }
		}

		protected virtual string SiteCode
		{
			get { return "SiteCode"; }
		}

		protected virtual string Encoded
		{
			get { return "Encoded"; }
		}

		protected virtual string Scheduled
		{
			get { return "Scheduled"; }
		}

		protected virtual string ArrivedTime
		{
			get { return "ArrivedTime"; }
		}

		protected virtual string TurnstileAccess
		{
			get { return "TurnstileAccess"; }
		}

		protected virtual string BadgePrinted
		{
			get { return "BadgePrinted"; }
		}

		protected virtual string Suite
		{
			get { return "Suite"; }
		}

		protected virtual string Tenant
		{
			get { return "Tenant"; }
		}

		protected virtual string BDBuildingPK
		{
			get { return "BDBuildingPK"; }
		}

		protected virtual string Address1
		{
			get { return "Address1"; }
		}

		protected virtual string BuildingID
		{
			get { return "BuildingID"; }
		}

		#endregion
	}

	public class UsrGroupDBRuleDataRule : RuleBase
	{
		public string CheckRules(UsrGroupDBRuleRuleData data)
		{
			StringBuilder builder = new StringBuilder();

			string rule;
			rule = this.CheckUsrGroupDBRulePK(data.UsrGroupDBRulePK);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckUsrGroupPK(data.UsrGroupPK);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckDBRuleID(data.DBRuleID);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckSelectable(data.Selectable);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckInsertable(data.Insertable);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckEditable(data.Editable);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckDeletable(data.Deletable);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckUsrGroupName(data.UsrGroupName);
			if (rule.Length > 0)
				builder.AppendLine(rule);


			rule = this.CheckComprehensiveRules(data);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			return builder.ToString();
		}

		protected virtual string CheckComprehensiveRules(UsrGroupDBRuleRuleData data)
		{
			return string.Empty;
		}

		#region Property Rules
		public virtual string CheckUsrGroupDBRulePK(System.Guid value)
		{
			string rule;
			rule = this.BrokenNotEmptyRule(this.UsrGroupDBRulePK, value);
			if(rule.Length > 0)
				return rule;

			return string.Empty;
		}

		public virtual string CheckUsrGroupPK(System.Guid value)
		{
			string rule;
			rule = this.BrokenNotEmptyRule(this.UsrGroupPK, value);
			if(rule.Length > 0)
				return rule;

			return string.Empty;
		}

		public virtual string CheckDBRuleID(System.Int32 value)
		{
			return string.Empty;
		}

		public virtual string CheckSelectable(System.Boolean value)
		{
			return string.Empty;
		}

		public virtual string CheckInsertable(System.Boolean value)
		{
			return string.Empty;
		}

		public virtual string CheckEditable(System.Boolean value)
		{
			return string.Empty;
		}

		public virtual string CheckDeletable(System.Boolean value)
		{
			return string.Empty;
		}

		public virtual string CheckUsrGroupName(System.String value)
		{
			string rule;
			rule = this.BrokenNotEmptyRule(this.UsrGroupName, value);
			if(rule.Length > 0)
				return rule;

			rule = this.BrokenMaxLengthRule(this.UsrGroupName, 50, value);
			if(rule.Length > 0)
				return rule;

			return string.Empty;
		}

		#endregion

		#region Property Names
		protected virtual string UsrGroupDBRulePK
		{
			get { return "UsrGroupDBRulePK"; }
		}

		protected virtual string UsrGroupPK
		{
			get { return "UsrGroupPK"; }
		}

		protected virtual string DBRuleID
		{
			get { return "DBRuleID"; }
		}

		protected virtual string Selectable
		{
			get { return "Selectable"; }
		}

		protected virtual string Insertable
		{
			get { return "Insertable"; }
		}

		protected virtual string Editable
		{
			get { return "Editable"; }
		}

		protected virtual string Deletable
		{
			get { return "Deletable"; }
		}

		protected virtual string UsrGroupName
		{
			get { return "UsrGroupName"; }
		}

		#endregion
	}

	public class ACPanelDataRule : RuleBase
	{
		public string CheckRules(ACPanelRuleData data)
		{
			StringBuilder builder = new StringBuilder();

			string rule;
			rule = this.CheckACPanelPK(data.ACPanelPK);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckUnitID(data.UnitID);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckBDBuildingPK(data.BDBuildingPK);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckSerialNumber(data.SerialNumber);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckPanelName(data.PanelName);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckBufferSize(data.BufferSize);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckDialUp(data.DialUp);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckUnitPhone(data.UnitPhone);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckUnitPhoneCallerID(data.UnitPhoneCallerID);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckUnitExt(data.UnitExt);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckLongDistance(data.LongDistance);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckModemInitString(data.ModemInitString);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckBaudRate(data.BaudRate);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckHistoryPhone(data.HistoryPhone);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckAlarmPhone1(data.AlarmPhone1);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckAlarmPhone2(data.AlarmPhone2);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckDialingPrefixPanel(data.DialingPrefixPanel);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckDialingSuffixPanel(data.DialingSuffixPanel);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckDialOutEnabled(data.DialOutEnabled);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckDayLightSaving(data.DayLightSaving);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckOnSiteMonitor(data.OnSiteMonitor);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckCentralDelay(data.CentralDelay);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckElevPulse(data.ElevPulse);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckPanelTypeID(data.PanelTypeID);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckUnbufferTC(data.UnbufferTC);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckMandatoryUnbufferTC(data.MandatoryUnbufferTC);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckSwingerCount(data.SwingerCount);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckSwingerTime(data.SwingerTime);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckLoopNumb(data.LoopNumb);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckPortNumb(data.PortNumb);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckNotes(data.Notes);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckTrouble(data.Trouble);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckNoVersionCheck(data.NoVersionCheck);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckDeviceId(data.DeviceId);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckDBSyncSeconds(data.DBSyncSeconds);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckDBSaveMinutes(data.DBSaveMinutes);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckIsE150(data.IsE150);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckGroupID(data.GroupID);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckNoAutoDownload(data.NoAutoDownload);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckNoAutoDownloadStart(data.NoAutoDownloadStart);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckLocked(data.Locked);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckInDebug(data.InDebug);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckAddress1(data.Address1);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckBuildingID(data.BuildingID);
			if (rule.Length > 0)
				builder.AppendLine(rule);


			rule = this.CheckComprehensiveRules(data);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			return builder.ToString();
		}

		protected virtual string CheckComprehensiveRules(ACPanelRuleData data)
		{
			return string.Empty;
		}

		#region Property Rules
		public virtual string CheckACPanelPK(System.Guid value)
		{
			string rule;
			rule = this.BrokenNotEmptyRule(this.ACPanelPK, value);
			if(rule.Length > 0)
				return rule;

			return string.Empty;
		}

		public virtual string CheckUnitID(System.Int32 value)
		{
			return string.Empty;
		}

		public virtual string CheckBDBuildingPK(System.Guid value)
		{
			string rule;
			rule = this.BrokenNotEmptyRule(this.BDBuildingPK, value);
			if(rule.Length > 0)
				return rule;

			return string.Empty;
		}

		public virtual string CheckSerialNumber(System.String value)
		{
			string rule;
			rule = this.BrokenMaxLengthRule(this.SerialNumber, 30, value);
			if(rule.Length > 0)
				return rule;

			return string.Empty;
		}

		public virtual string CheckPanelName(System.String value)
		{
			string rule;
			rule = this.BrokenNotEmptyRule(this.PanelName, value);
			if(rule.Length > 0)
				return rule;

			rule = this.BrokenMaxLengthRule(this.PanelName, 50, value);
			if(rule.Length > 0)
				return rule;

			return string.Empty;
		}

		public virtual string CheckBufferSize(System.Int16 value)
		{
			return string.Empty;
		}

		public virtual string CheckDialUp(System.Boolean value)
		{
			return string.Empty;
		}

		public virtual string CheckUnitPhone(System.String value)
		{
			string rule;
			rule = this.BrokenMaxLengthRule(this.UnitPhone, 35, value);
			if(rule.Length > 0)
				return rule;

			return string.Empty;
		}

		public virtual string CheckUnitPhoneCallerID(System.String value)
		{
			string rule;
			rule = this.BrokenMaxLengthRule(this.UnitPhoneCallerID, 35, value);
			if(rule.Length > 0)
				return rule;

			return string.Empty;
		}

		public virtual string CheckUnitExt(System.String value)
		{
			string rule;
			rule = this.BrokenMaxLengthRule(this.UnitExt, 10, value);
			if(rule.Length > 0)
				return rule;

			return string.Empty;
		}

		public virtual string CheckLongDistance(System.Boolean value)
		{
			return string.Empty;
		}

		public virtual string CheckModemInitString(System.String value)
		{
			string rule;
			rule = this.BrokenMaxLengthRule(this.ModemInitString, 256, value);
			if(rule.Length > 0)
				return rule;

			return string.Empty;
		}

		public virtual string CheckBaudRate(System.Int32 value)
		{
			return string.Empty;
		}

		public virtual string CheckHistoryPhone(System.String value)
		{
			string rule;
			rule = this.BrokenMaxLengthRule(this.HistoryPhone, 25, value);
			if(rule.Length > 0)
				return rule;

			return string.Empty;
		}

		public virtual string CheckAlarmPhone1(System.String value)
		{
			string rule;
			rule = this.BrokenMaxLengthRule(this.AlarmPhone1, 25, value);
			if(rule.Length > 0)
				return rule;

			return string.Empty;
		}

		public virtual string CheckAlarmPhone2(System.String value)
		{
			string rule;
			rule = this.BrokenMaxLengthRule(this.AlarmPhone2, 25, value);
			if(rule.Length > 0)
				return rule;

			return string.Empty;
		}

		public virtual string CheckDialingPrefixPanel(System.String value)
		{
			string rule;
			rule = this.BrokenMaxLengthRule(this.DialingPrefixPanel, 5, value);
			if(rule.Length > 0)
				return rule;

			return string.Empty;
		}

		public virtual string CheckDialingSuffixPanel(System.String value)
		{
			string rule;
			rule = this.BrokenMaxLengthRule(this.DialingSuffixPanel, 10, value);
			if(rule.Length > 0)
				return rule;

			return string.Empty;
		}

		public virtual string CheckDialOutEnabled(System.Boolean value)
		{
			return string.Empty;
		}

		public virtual string CheckDayLightSaving(System.Boolean value)
		{
			return string.Empty;
		}

		public virtual string CheckOnSiteMonitor(System.Boolean value)
		{
			return string.Empty;
		}

		public virtual string CheckCentralDelay(System.Byte value)
		{
			return string.Empty;
		}

		public virtual string CheckElevPulse(System.Byte value)
		{
			return string.Empty;
		}

		public virtual string CheckPanelTypeID(System.Int32 value)
		{
			return string.Empty;
		}

		public virtual string CheckUnbufferTC(System.Int16 value)
		{
			return string.Empty;
		}

		public virtual string CheckMandatoryUnbufferTC(System.Int16 value)
		{
			return string.Empty;
		}

		public virtual string CheckSwingerCount(System.Int16 value)
		{
			return string.Empty;
		}

		public virtual string CheckSwingerTime(System.Int16 value)
		{
			return string.Empty;
		}

		public virtual string CheckLoopNumb(System.Byte value)
		{
			return string.Empty;
		}

		public virtual string CheckPortNumb(System.Byte value)
		{
			return string.Empty;
		}

		public virtual string CheckNotes(System.String value)
		{
			string rule;
			rule = this.BrokenMaxLengthRule(this.Notes, 4096, value);
			if(rule.Length > 0)
				return rule;

			return string.Empty;
		}

		public virtual string CheckTrouble(System.Boolean value)
		{
			return string.Empty;
		}

		public virtual string CheckNoVersionCheck(System.Boolean value)
		{
			return string.Empty;
		}

		public virtual string CheckDeviceId(System.Guid value)
		{
			string rule;
			return string.Empty;
		}

		public virtual string CheckDBSyncSeconds(System.Int32 value)
		{
			return string.Empty;
		}

		public virtual string CheckDBSaveMinutes(System.Int32 value)
		{
			return string.Empty;
		}

		public virtual string CheckIsE150(System.Boolean value)
		{
			return string.Empty;
		}

		public virtual string CheckGroupID(System.Byte value)
		{
			return string.Empty;
		}

		public virtual string CheckNoAutoDownload(System.Boolean value)
		{
			return string.Empty;
		}

		public virtual string CheckNoAutoDownloadStart(System.DateTime value)
		{
			return string.Empty;
		}

		public virtual string CheckLocked(System.Boolean value)
		{
			return string.Empty;
		}

		public virtual string CheckInDebug(System.Boolean value)
		{
			return string.Empty;
		}

		public virtual string CheckAddress1(System.String value)
		{
			string rule;
			rule = this.BrokenNotEmptyRule(this.Address1, value);
			if(rule.Length > 0)
				return rule;

			rule = this.BrokenMaxLengthRule(this.Address1, 55, value);
			if(rule.Length > 0)
				return rule;

			return string.Empty;
		}

		public virtual string CheckBuildingID(System.Int32 value)
		{
			return string.Empty;
		}

		#endregion

		#region Property Names
		protected virtual string ACPanelPK
		{
			get { return "ACPanelPK"; }
		}

		protected virtual string UnitID
		{
			get { return "UnitID"; }
		}

		protected virtual string BDBuildingPK
		{
			get { return "BDBuildingPK"; }
		}

		protected virtual string SerialNumber
		{
			get { return "SerialNumber"; }
		}

		protected virtual string PanelName
		{
			get { return "PanelName"; }
		}

		protected virtual string BufferSize
		{
			get { return "BufferSize"; }
		}

		protected virtual string DialUp
		{
			get { return "DialUp"; }
		}

		protected virtual string UnitPhone
		{
			get { return "UnitPhone"; }
		}

		protected virtual string UnitPhoneCallerID
		{
			get { return "UnitPhoneCallerID"; }
		}

		protected virtual string UnitExt
		{
			get { return "UnitExt"; }
		}

		protected virtual string LongDistance
		{
			get { return "LongDistance"; }
		}

		protected virtual string ModemInitString
		{
			get { return "ModemInitString"; }
		}

		protected virtual string BaudRate
		{
			get { return "BaudRate"; }
		}

		protected virtual string HistoryPhone
		{
			get { return "HistoryPhone"; }
		}

		protected virtual string AlarmPhone1
		{
			get { return "AlarmPhone1"; }
		}

		protected virtual string AlarmPhone2
		{
			get { return "AlarmPhone2"; }
		}

		protected virtual string DialingPrefixPanel
		{
			get { return "DialingPrefixPanel"; }
		}

		protected virtual string DialingSuffixPanel
		{
			get { return "DialingSuffixPanel"; }
		}

		protected virtual string DialOutEnabled
		{
			get { return "DialOutEnabled"; }
		}

		protected virtual string DayLightSaving
		{
			get { return "DayLightSaving"; }
		}

		protected virtual string OnSiteMonitor
		{
			get { return "OnSiteMonitor"; }
		}

		protected virtual string CentralDelay
		{
			get { return "CentralDelay"; }
		}

		protected virtual string ElevPulse
		{
			get { return "ElevPulse"; }
		}

		protected virtual string PanelTypeID
		{
			get { return "PanelTypeID"; }
		}

		protected virtual string UnbufferTC
		{
			get { return "UnbufferTC"; }
		}

		protected virtual string MandatoryUnbufferTC
		{
			get { return "MandatoryUnbufferTC"; }
		}

		protected virtual string SwingerCount
		{
			get { return "SwingerCount"; }
		}

		protected virtual string SwingerTime
		{
			get { return "SwingerTime"; }
		}

		protected virtual string LoopNumb
		{
			get { return "LoopNumb"; }
		}

		protected virtual string PortNumb
		{
			get { return "PortNumb"; }
		}

		protected virtual string Notes
		{
			get { return "Notes"; }
		}

		protected virtual string Trouble
		{
			get { return "Trouble"; }
		}

		protected virtual string NoVersionCheck
		{
			get { return "NoVersionCheck"; }
		}

		protected virtual string DeviceId
		{
			get { return "DeviceId"; }
		}

		protected virtual string DBSyncSeconds
		{
			get { return "DBSyncSeconds"; }
		}

		protected virtual string DBSaveMinutes
		{
			get { return "DBSaveMinutes"; }
		}

		protected virtual string IsE150
		{
			get { return "IsE150"; }
		}

		protected virtual string GroupID
		{
			get { return "GroupID"; }
		}

		protected virtual string NoAutoDownload
		{
			get { return "NoAutoDownload"; }
		}

		protected virtual string NoAutoDownloadStart
		{
			get { return "NoAutoDownloadStart"; }
		}

		protected virtual string Locked
		{
			get { return "Locked"; }
		}

		protected virtual string InDebug
		{
			get { return "InDebug"; }
		}

		protected virtual string Address1
		{
			get { return "Address1"; }
		}

		protected virtual string BuildingID
		{
			get { return "BuildingID"; }
		}

		#endregion
	}

	public class UsrAccountDBRuleDataRule : RuleBase
	{
		public string CheckRules(UsrAccountDBRuleRuleData data)
		{
			StringBuilder builder = new StringBuilder();

			string rule;
			rule = this.CheckUsrAccountDBRulePK(data.UsrAccountDBRulePK);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckUsrAccountPK(data.UsrAccountPK);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckDBRuleID(data.DBRuleID);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckSelectable(data.Selectable);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckInsertable(data.Insertable);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckEditable(data.Editable);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckDeletable(data.Deletable);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckUserID(data.UserID);
			if (rule.Length > 0)
				builder.AppendLine(rule);


			rule = this.CheckComprehensiveRules(data);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			return builder.ToString();
		}

		protected virtual string CheckComprehensiveRules(UsrAccountDBRuleRuleData data)
		{
			return string.Empty;
		}

		#region Property Rules
		public virtual string CheckUsrAccountDBRulePK(System.Guid value)
		{
			string rule;
			rule = this.BrokenNotEmptyRule(this.UsrAccountDBRulePK, value);
			if(rule.Length > 0)
				return rule;

			return string.Empty;
		}

		public virtual string CheckUsrAccountPK(System.Guid value)
		{
			string rule;
			rule = this.BrokenNotEmptyRule(this.UsrAccountPK, value);
			if(rule.Length > 0)
				return rule;

			return string.Empty;
		}

		public virtual string CheckDBRuleID(System.Int32 value)
		{
			return string.Empty;
		}

		public virtual string CheckSelectable(System.Boolean value)
		{
			return string.Empty;
		}

		public virtual string CheckInsertable(System.Boolean value)
		{
			return string.Empty;
		}

		public virtual string CheckEditable(System.Boolean value)
		{
			return string.Empty;
		}

		public virtual string CheckDeletable(System.Boolean value)
		{
			return string.Empty;
		}

		public virtual string CheckUserID(System.String value)
		{
			string rule;
			rule = this.BrokenNotEmptyRule(this.UserID, value);
			if(rule.Length > 0)
				return rule;

			rule = this.BrokenMaxLengthRule(this.UserID, 30, value);
			if(rule.Length > 0)
				return rule;

			return string.Empty;
		}

		#endregion

		#region Property Names
		protected virtual string UsrAccountDBRulePK
		{
			get { return "UsrAccountDBRulePK"; }
		}

		protected virtual string UsrAccountPK
		{
			get { return "UsrAccountPK"; }
		}

		protected virtual string DBRuleID
		{
			get { return "DBRuleID"; }
		}

		protected virtual string Selectable
		{
			get { return "Selectable"; }
		}

		protected virtual string Insertable
		{
			get { return "Insertable"; }
		}

		protected virtual string Editable
		{
			get { return "Editable"; }
		}

		protected virtual string Deletable
		{
			get { return "Deletable"; }
		}

		protected virtual string UserID
		{
			get { return "UserID"; }
		}

		#endregion
	}

	public class UsrGroupBRRuleDataRule : RuleBase
	{
		public string CheckRules(UsrGroupBRRuleRuleData data)
		{
			StringBuilder builder = new StringBuilder();

			string rule;
			rule = this.CheckUsrGroupBRRule(data.UsrGroupBRRule);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckUsrGroupPK(data.UsrGroupPK);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckBRRuleID(data.BRRuleID);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckDenied(data.Denied);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckUsrGroupName(data.UsrGroupName);
			if (rule.Length > 0)
				builder.AppendLine(rule);


			rule = this.CheckComprehensiveRules(data);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			return builder.ToString();
		}

		protected virtual string CheckComprehensiveRules(UsrGroupBRRuleRuleData data)
		{
			return string.Empty;
		}

		#region Property Rules
		public virtual string CheckUsrGroupBRRule(System.Guid value)
		{
			string rule;
			rule = this.BrokenNotEmptyRule(this.UsrGroupBRRule, value);
			if(rule.Length > 0)
				return rule;

			return string.Empty;
		}

		public virtual string CheckUsrGroupPK(System.Guid value)
		{
			string rule;
			rule = this.BrokenNotEmptyRule(this.UsrGroupPK, value);
			if(rule.Length > 0)
				return rule;

			return string.Empty;
		}

		public virtual string CheckBRRuleID(System.Int32 value)
		{
			return string.Empty;
		}

		public virtual string CheckDenied(System.Boolean value)
		{
			return string.Empty;
		}

		public virtual string CheckUsrGroupName(System.String value)
		{
			string rule;
			rule = this.BrokenNotEmptyRule(this.UsrGroupName, value);
			if(rule.Length > 0)
				return rule;

			rule = this.BrokenMaxLengthRule(this.UsrGroupName, 50, value);
			if(rule.Length > 0)
				return rule;

			return string.Empty;
		}

		#endregion

		#region Property Names
		protected virtual string UsrGroupBRRule
		{
			get { return "UsrGroupBRRule"; }
		}

		protected virtual string UsrGroupPK
		{
			get { return "UsrGroupPK"; }
		}

		protected virtual string BRRuleID
		{
			get { return "BRRuleID"; }
		}

		protected virtual string Denied
		{
			get { return "Denied"; }
		}

		protected virtual string UsrGroupName
		{
			get { return "UsrGroupName"; }
		}

		#endregion
	}

	public class ACInputGroupInputMapDataRule : RuleBase
	{
		public string CheckRules(ACInputGroupInputMapRuleData data)
		{
			StringBuilder builder = new StringBuilder();

			string rule;
			rule = this.CheckACInputGroupInputMapPK(data.ACInputGroupInputMapPK);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckACInputGroupPK(data.ACInputGroupPK);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckACInputPK(data.ACInputPK);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckGroupID(data.GroupID);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckACPanelPK(data.ACPanelPK);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckInputID(data.InputID);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckUnitID(data.UnitID);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckAddress1(data.Address1);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckBuildingID(data.BuildingID);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckBDBuildingPK(data.BDBuildingPK);
			if (rule.Length > 0)
				builder.AppendLine(rule);


			rule = this.CheckComprehensiveRules(data);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			return builder.ToString();
		}

		protected virtual string CheckComprehensiveRules(ACInputGroupInputMapRuleData data)
		{
			return string.Empty;
		}

		#region Property Rules
		public virtual string CheckACInputGroupInputMapPK(System.Guid value)
		{
			string rule;
			rule = this.BrokenNotEmptyRule(this.ACInputGroupInputMapPK, value);
			if(rule.Length > 0)
				return rule;

			return string.Empty;
		}

		public virtual string CheckACInputGroupPK(System.Guid value)
		{
			string rule;
			rule = this.BrokenNotEmptyRule(this.ACInputGroupPK, value);
			if(rule.Length > 0)
				return rule;

			return string.Empty;
		}

		public virtual string CheckACInputPK(System.Guid value)
		{
			string rule;
			rule = this.BrokenNotEmptyRule(this.ACInputPK, value);
			if(rule.Length > 0)
				return rule;

			return string.Empty;
		}

		public virtual string CheckGroupID(System.Byte value)
		{
			return string.Empty;
		}

		public virtual string CheckACPanelPK(System.Guid value)
		{
			string rule;
			rule = this.BrokenNotEmptyRule(this.ACPanelPK, value);
			if(rule.Length > 0)
				return rule;

			return string.Empty;
		}

		public virtual string CheckInputID(System.Byte value)
		{
			return string.Empty;
		}

		public virtual string CheckUnitID(System.Int32 value)
		{
			return string.Empty;
		}

		public virtual string CheckAddress1(System.String value)
		{
			string rule;
			rule = this.BrokenNotEmptyRule(this.Address1, value);
			if(rule.Length > 0)
				return rule;

			rule = this.BrokenMaxLengthRule(this.Address1, 55, value);
			if(rule.Length > 0)
				return rule;

			return string.Empty;
		}

		public virtual string CheckBuildingID(System.Int32 value)
		{
			return string.Empty;
		}

		public virtual string CheckBDBuildingPK(System.Guid value)
		{
			string rule;
			rule = this.BrokenNotEmptyRule(this.BDBuildingPK, value);
			if(rule.Length > 0)
				return rule;

			return string.Empty;
		}

		#endregion

		#region Property Names
		protected virtual string ACInputGroupInputMapPK
		{
			get { return "ACInputGroupInputMapPK"; }
		}

		protected virtual string ACInputGroupPK
		{
			get { return "ACInputGroupPK"; }
		}

		protected virtual string ACInputPK
		{
			get { return "ACInputPK"; }
		}

		protected virtual string GroupID
		{
			get { return "GroupID"; }
		}

		protected virtual string ACPanelPK
		{
			get { return "ACPanelPK"; }
		}

		protected virtual string InputID
		{
			get { return "InputID"; }
		}

		protected virtual string UnitID
		{
			get { return "UnitID"; }
		}

		protected virtual string Address1
		{
			get { return "Address1"; }
		}

		protected virtual string BuildingID
		{
			get { return "BuildingID"; }
		}

		protected virtual string BDBuildingPK
		{
			get { return "BDBuildingPK"; }
		}

		#endregion
	}

	public class UsrAccountBRRuleDataRule : RuleBase
	{
		public string CheckRules(UsrAccountBRRuleRuleData data)
		{
			StringBuilder builder = new StringBuilder();

			string rule;
			rule = this.CheckUsrAccountBRRulePK(data.UsrAccountBRRulePK);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckUsrAccountPK(data.UsrAccountPK);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckBRRuleID(data.BRRuleID);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckDenied(data.Denied);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckUserID(data.UserID);
			if (rule.Length > 0)
				builder.AppendLine(rule);


			rule = this.CheckComprehensiveRules(data);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			return builder.ToString();
		}

		protected virtual string CheckComprehensiveRules(UsrAccountBRRuleRuleData data)
		{
			return string.Empty;
		}

		#region Property Rules
		public virtual string CheckUsrAccountBRRulePK(System.Guid value)
		{
			string rule;
			rule = this.BrokenNotEmptyRule(this.UsrAccountBRRulePK, value);
			if(rule.Length > 0)
				return rule;

			return string.Empty;
		}

		public virtual string CheckUsrAccountPK(System.Guid value)
		{
			string rule;
			rule = this.BrokenNotEmptyRule(this.UsrAccountPK, value);
			if(rule.Length > 0)
				return rule;

			return string.Empty;
		}

		public virtual string CheckBRRuleID(System.Int32 value)
		{
			return string.Empty;
		}

		public virtual string CheckDenied(System.Boolean value)
		{
			return string.Empty;
		}

		public virtual string CheckUserID(System.String value)
		{
			string rule;
			rule = this.BrokenNotEmptyRule(this.UserID, value);
			if(rule.Length > 0)
				return rule;

			rule = this.BrokenMaxLengthRule(this.UserID, 30, value);
			if(rule.Length > 0)
				return rule;

			return string.Empty;
		}

		#endregion

		#region Property Names
		protected virtual string UsrAccountBRRulePK
		{
			get { return "UsrAccountBRRulePK"; }
		}

		protected virtual string UsrAccountPK
		{
			get { return "UsrAccountPK"; }
		}

		protected virtual string BRRuleID
		{
			get { return "BRRuleID"; }
		}

		protected virtual string Denied
		{
			get { return "Denied"; }
		}

		protected virtual string UserID
		{
			get { return "UserID"; }
		}

		#endregion
	}

	public class UsrAccountTenantMapDataRule : RuleBase
	{
		public string CheckRules(UsrAccountTenantMapRuleData data)
		{
			StringBuilder builder = new StringBuilder();

			string rule;
			rule = this.CheckUsrAccountTenantMapPK(data.UsrAccountTenantMapPK);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckUsrAccountPK(data.UsrAccountPK);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckBDTenantPK(data.BDTenantPK);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckTenant(data.Tenant);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckBDBuildingPK(data.BDBuildingPK);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckUserID(data.UserID);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckAddress1(data.Address1);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			rule = this.CheckBuildingID(data.BuildingID);
			if (rule.Length > 0)
				builder.AppendLine(rule);


			rule = this.CheckComprehensiveRules(data);
			if (rule.Length > 0)
				builder.AppendLine(rule);

			return builder.ToString();
		}

		protected virtual string CheckComprehensiveRules(UsrAccountTenantMapRuleData data)
		{
			return string.Empty;
		}

		#region Property Rules
		public virtual string CheckUsrAccountTenantMapPK(System.Guid value)
		{
			string rule;
			rule = this.BrokenNotEmptyRule(this.UsrAccountTenantMapPK, value);
			if(rule.Length > 0)
				return rule;

			return string.Empty;
		}

		public virtual string CheckUsrAccountPK(System.Guid value)
		{
			string rule;
			rule = this.BrokenNotEmptyRule(this.UsrAccountPK, value);
			if(rule.Length > 0)
				return rule;

			return string.Empty;
		}

		public virtual string CheckBDTenantPK(System.Guid value)
		{
			string rule;
			rule = this.BrokenNotEmptyRule(this.BDTenantPK, value);
			if(rule.Length > 0)
				return rule;

			return string.Empty;
		}

		public virtual string CheckTenant(System.String value)
		{
			string rule;
			rule = this.BrokenNotEmptyRule(this.Tenant, value);
			if(rule.Length > 0)
				return rule;

			rule = this.BrokenMaxLengthRule(this.Tenant, 60, value);
			if(rule.Length > 0)
				return rule;

			return string.Empty;
		}

		public virtual string CheckBDBuildingPK(System.Guid value)
		{
			string rule;
			rule = this.BrokenNotEmptyRule(this.BDBuildingPK, value);
			if(rule.Length > 0)
				return rule;

			return string.Empty;
		}

		public virtual string CheckUserID(System.String value)
		{
			string rule;
			rule = this.BrokenNotEmptyRule(this.UserID, value);
			if(rule.Length > 0)
				return rule;

			rule = this.BrokenMaxLengthRule(this.UserID, 30, value);
			if(rule.Length > 0)
				return rule;

			return string.Empty;
		}

		public virtual string CheckAddress1(System.String value)
		{
			string rule;
			rule = this.BrokenNotEmptyRule(this.Address1, value);
			if(rule.Length > 0)
				return rule;

			rule = this.BrokenMaxLengthRule(this.Address1, 55, value);
			if(rule.Length > 0)
				return rule;

			return string.Empty;
		}

		public virtual string CheckBuildingID(System.Int32 value)
		{
			return string.Empty;
		}

		#endregion

		#region Property Names
		protected virtual string UsrAccountTenantMapPK
		{
			get { return "UsrAccountTenantMapPK"; }
		}

		protected virtual string UsrAccountPK
		{
			get { return "UsrAccountPK"; }
		}

		protected virtual string BDTenantPK
		{
			get { return "BDTenantPK"; }
		}

		protected virtual string Tenant
		{
			get { return "Tenant"; }
		}

		protected virtual string BDBuildingPK
		{
			get { return "BDBuildingPK"; }
		}

		protected virtual string UserID
		{
			get { return "UserID"; }
		}

		protected virtual string Address1
		{
			get { return "Address1"; }
		}

		protected virtual string BuildingID
		{
			get { return "BuildingID"; }
		}

		#endregion
	}


	public partial class ACIntvalHolidayMapRule : ACIntvalHolidayMapDataRule
	{
	}

	public partial class ACAccessLevelDetailRule : ACAccessLevelDetailDataRule
	{
	}

	public partial class UsrAccountBuildingMapRule : UsrAccountBuildingMapDataRule
	{
	}

	public partial class BDBuildingRule : BDBuildingDataRule
	{
	}

	public partial class BDTenantRule : BDTenantDataRule
	{
	}

	public partial class UtilSettingCategoryRule : UtilSettingCategoryDataRule
	{
	}

	public partial class UtilSettingDetailRule : UtilSettingDetailDataRule
	{
	}

	public partial class ACOutputGroupMainZoneMapRule : ACOutputGroupMainZoneMapDataRule
	{
	}

	public partial class ACCardHolderRule : ACCardHolderDataRule
	{
	}

	public partial class ACMainZoneRule : ACMainZoneDataRule
	{
	}

	public partial class ACIntervalRule : ACIntervalDataRule
	{
	}

	public partial class ACPanelHolidayMapRule : ACPanelHolidayMapDataRule
	{
	}

	public partial class ACTimecodeRule : ACTimecodeDataRule
	{
	}

	public partial class ACTimecodeIntervalMapRule : ACTimecodeIntervalMapDataRule
	{
	}

	public partial class ACAMFormatRule : ACAMFormatDataRule
	{
	}

	public partial class BDBuildingHolidayMapRule : BDBuildingHolidayMapDataRule
	{
	}

	public partial class ACOutputGroupRule : ACOutputGroupDataRule
	{
	}

	public partial class BDTenantHolidayMapRule : BDTenantHolidayMapDataRule
	{
	}

	public partial class LogRowsCountRule : LogRowsCountDataRule
	{
	}

	public partial class ACInputGroupRule : ACInputGroupDataRule
	{
	}

	public partial class ACInputRule : ACInputDataRule
	{
	}

	public partial class ACFunctionCardRule : ACFunctionCardDataRule
	{
	}

	public partial class UtilHolidayRule : UtilHolidayDataRule
	{
	}

	public partial class ACAccessLevelRule : ACAccessLevelDataRule
	{
	}

	public partial class ACPanelFunctionCardMapRule : ACPanelFunctionCardMapDataRule
	{
	}

	public partial class LogDBDeleteActivityRule : LogDBDeleteActivityDataRule
	{
	}

	public partial class UsrAccountRule : UsrAccountDataRule
	{
	}

	public partial class LogDBEditActivityRule : LogDBEditActivityDataRule
	{
	}

	public partial class ACMasterCardRule : ACMasterCardDataRule
	{
	}

	public partial class ACSupervisoryRule : ACSupervisoryDataRule
	{
	}

	public partial class UsrGroupRule : UsrGroupDataRule
	{
	}

	public partial class ACCardHolderBuildingMapRule : ACCardHolderBuildingMapDataRule
	{
	}

	public partial class BDVisitorRule : BDVisitorDataRule
	{
	}

	public partial class UsrGroupDBRuleRule : UsrGroupDBRuleDataRule
	{
	}

	public partial class ACPanelRule : ACPanelDataRule
	{
	}

	public partial class UsrAccountDBRuleRule : UsrAccountDBRuleDataRule
	{
	}

	public partial class UsrGroupBRRuleRule : UsrGroupBRRuleDataRule
	{
	}

	public partial class ACInputGroupInputMapRule : ACInputGroupInputMapDataRule
	{
	}

	public partial class UsrAccountBRRuleRule : UsrAccountBRRuleDataRule
	{
	}

	public partial class UsrAccountTenantMapRule : UsrAccountTenantMapDataRule
	{
	}

}
