namespace W3000.Schema
{
	public partial class CriteriaACCardHolderViewSchema
	{
		public const string Sitecode = "Sitecode";
		public const string Embossed = "Embossed";
		public const string Encoded = "Encoded";
		public const string BDBuildingPK = "BDBuildingPK";
		public const string BDTenantPK = "BDTenantPK";
		public const string FirstName = "FirstName";
		public const string LastName = "LastName";
		public const string Tenant = "Tenant";
	}

	public partial class CriteriaBDBuildingViewSchema
	{
		public const string StreetNumber = "StreetNumber";
		public const string StreetName = "StreetName";
		public const string BuildingName = "BuildingName";
		public const string City = "City";
		public const string Zipcode = "Zipcode";
		public const string State = "State";
	}

	public partial class ACIntvalHolidayMapSchema
	{
		public const string ACIntvalHolidayMapPK = "ACIntvalHolidayMapPK";
		public const string ACIntervalPK = "ACIntervalPK";
		public const string UtilHolidayPK = "UtilHolidayPK";
		public const string End = "End";
		public const string Begin = "Begin";
		public const string IVID = "IVID";
		public const string BDBuildingPK = "BDBuildingPK";
		public const string Date = "Date";
		public const string Holiday = "Holiday";
		public const string Address1 = "Address1";
		public const string BuildingID = "BuildingID";
		public const string ACInterval = "ACInterval";
		public const string UtilHoliday = "UtilHoliday";
		public const string TableName = "ACIntvalHolidayMap";
		public const string TableAlias = "ACIntvalHolidayMap";
		public const string CreatedOn = "CreatedOn";
		public const string CreatedBy = "CreatedBy";
		public const string ModifiedOn = "ModifiedOn";
		public const string ModifiedBy = "ModifiedBy";
	}

	public partial class ACAccessLevelDetailSchema
	{
		public const string ACAccessLevelDetailPK = "ACAccessLevelDetailPK";
		public const string ACAccessLevelPK = "ACAccessLevelPK";
		public const string ACMainZonePK = "ACMainZonePK";
		public const string ACTimecodePK = "ACTimecodePK";
		public const string FromACAccessLevelPK = "FromACAccessLevelPK";
		public const string MainZoneDescription = "MainZoneDescription";
		public const string MainZoneID = "MainZoneID";
		public const string ACPanelPK = "ACPanelPK";
		public const string TimecodeSummary = "TimecodeSummary";
		public const string TCID = "TCID";
		public const string ALSummary = "ALSummary";
		public const string AccessLevelID = "AccessLevelID";
		public const string BDBuildingPK = "BDBuildingPK";
		public const string UnitID = "UnitID";
		public const string Address1 = "Address1";
		public const string BuildingID = "BuildingID";
		public const string ACMainZone = "ACMainZone";
		public const string ACTimecode = "ACTimecode";
		public const string ACAccessLevel = "ACAccessLevel";
		public const string TableName = "ACAccessLevelDetail";
		public const string TableAlias = "ACAccessLevelDetail";
		public const string CreatedOn = "CreatedOn";
		public const string CreatedBy = "CreatedBy";
		public const string ModifiedOn = "ModifiedOn";
		public const string ModifiedBy = "ModifiedBy";
	}

	public partial class UsrAccountBuildingMapSchema
	{
		public const string UsrAccountBuildingMapPK = "UsrAccountBuildingMapPK";
		public const string UsrAccountPK = "UsrAccountPK";
		public const string BDBuildingPK = "BDBuildingPK";
		public const string BuildingWide = "BuildingWide";
		public const string AccessTC = "AccessTC";
		public const string Permission = "Permission";
		public const string Primary = "Primary";
		public const string Address1 = "Address1";
		public const string BuildingID = "BuildingID";
		public const string UserID = "UserID";
		public const string BDBuilding = "BDBuilding";
		public const string UsrAccount = "UsrAccount";
		public const string TableName = "UsrAccountBuildingMap";
		public const string TableAlias = "UsrAccountBuildingMap";
		public const string CreatedOn = "CreatedOn";
		public const string CreatedBy = "CreatedBy";
		public const string ModifiedOn = "ModifiedOn";
		public const string ModifiedBy = "ModifiedBy";
	}

	public partial class BDBuildingSchema
	{
		public const string BDBuildingPK = "BDBuildingPK";
		public const string BuildingID = "BuildingID";
		public const string BuildingName = "BuildingName";
		public const string Address1 = "Address1";
		public const string StreetNumb = "StreetNumb";
		public const string StreetName = "StreetName";
		public const string Address2 = "Address2";
		public const string City = "City";
		public const string State = "State";
		public const string Zipcode = "Zipcode";
		public const string County = "County";
		public const string TimezoneID = "TimezoneID";
		public const string Federal = "Federal";
		public const string Phone = "Phone";
		public const string Fax = "Fax";
		public const string BldgNotes = "BldgNotes";
		public const string CardNotes = "CardNotes";
		public const string ElevTrapNotes = "ElevTrapNotes";
		public const string VisitorNotes = "VisitorNotes";
		public const string SystemTypeID = "SystemTypeID";
		public const string CountryID = "CountryID";
		public const string VisitorSiteCode = "VisitorSiteCode";
		public const string WinUITypeID = "WinUITypeID";
		public const string LastExportParkingTag = "LastExportParkingTag";
		public const string AutoIssueNotifyEmail = "AutoIssueNotifyEmail";
		public const string CardKeyMode = "CardKeyMode";
		public const string AccessLevelMode = "AccessLevelMode";
		public const string HotClient = "HotClient";
		public const string HotExpire = "HotExpire";
		public const string UsrAccountBuildingMapList = "UsrAccountBuildingMapList";
		public const string ACPanelList = "ACPanelList";
		public const string BDTenantList = "BDTenantList";
		public const string BDBuildingHolidayMapList = "BDBuildingHolidayMapList";
		public const string ACIntervalList = "ACIntervalList";
		public const string ACTimecodeList = "ACTimecodeList";
		public const string ACAMFormatList = "ACAMFormatList";
		public const string ACAccessLevelList = "ACAccessLevelList";
		public const string ACCardHolderBuildingMapList = "ACCardHolderBuildingMapList";
		public const string TableName = "BDBuilding";
		public const string TableAlias = "BDBuilding";
		public const string CreatedOn = "CreatedOn";
		public const string CreatedBy = "CreatedBy";
		public const string ModifiedOn = "ModifiedOn";
		public const string ModifiedBy = "ModifiedBy";
	}

	public partial class BDTenantSchema
	{
		public const string BDTenantPK = "BDTenantPK";
		public const string BDBuildingPK = "BDBuildingPK";
		public const string Tenant = "Tenant";
		public const string Suite = "Suite";
		public const string Phone = "Phone";
		public const string Fax = "Fax";
		public const string Blocked = "Blocked";
		public const string Federal = "Federal";
		public const string TentNotes = "TentNotes";
		public const string CardNotes = "CardNotes";
		public const string VisitorNotes = "VisitorNotes";
		public const string IsManagement = "IsManagement";
		public const string Type = "Type";
		public const string NoRecycleCard = "NoRecycleCard";
		public const string SystemTypeID = "SystemTypeID";
		public const string ParkingAccount = "ParkingAccount";
		public const string CustInfo1 = "CustInfo1";
		public const string CustInfo2 = "CustInfo2";
		public const string CustInfo3 = "CustInfo3";
		public const string CustInfo4 = "CustInfo4";
		public const string CustInfo5 = "CustInfo5";
		public const string CustInfo6 = "CustInfo6";
		public const string CustInfo7 = "CustInfo7";
		public const string CustInfo8 = "CustInfo8";
		public const string DelExpiredCard = "DelExpiredCard";
		public const string HotClient = "HotClient";
		public const string HotExpire = "HotExpire";
		public const string Email = "Email";
		public const string Address1 = "Address1";
		public const string BuildingID = "BuildingID";
		public const string UsrAccountTenantMapList = "UsrAccountTenantMapList";
		public const string UsrAccountList = "UsrAccountList";
		public const string ACFunctionCardList = "ACFunctionCardList";
		public const string BDTenantHolidayMapList = "BDTenantHolidayMapList";
		public const string ACCardHolderList = "ACCardHolderList";
		public const string BDVisitorList = "BDVisitorList";
		public const string BDBuilding = "BDBuilding";
		public const string TableName = "BDTenant";
		public const string TableAlias = "BDTenant";
		public const string CreatedOn = "CreatedOn";
		public const string CreatedBy = "CreatedBy";
		public const string ModifiedOn = "ModifiedOn";
		public const string ModifiedBy = "ModifiedBy";
	}

	public partial class UtilSettingCategorySchema
	{
		public const string UtilSettingCategoryPK = "UtilSettingCategoryPK";
		public const string SettingCategoryID = "SettingCategoryID";
		public const string SettingCategory = "SettingCategory";
		public const string InstanceName = "InstanceName";
		public const string BDBuildingPK = "BDBuildingPK";
		public const string UtilSettingDetailList = "UtilSettingDetailList";
		public const string TableName = "UtilSettingCategory";
		public const string TableAlias = "UtilSettingCategory";
		public const string CreatedOn = "CreatedOn";
		public const string CreatedBy = "CreatedBy";
		public const string ModifiedOn = "ModifiedOn";
		public const string ModifiedBy = "ModifiedBy";
	}

	public partial class UtilSettingDetailSchema
	{
		public const string UtilSettingDetailPK = "UtilSettingDetailPK";
		public const string UtilSettingCategoryPK = "UtilSettingCategoryPK";
		public const string FieldName = "FieldName";
		public const string FieldValue = "FieldValue";
		public const string Picture = "Picture";
		public const string SettingCategory = "SettingCategory";
		public const string SettingCategoryID = "SettingCategoryID";
		public const string UtilSettingCategory = "UtilSettingCategory";
		public const string TableName = "UtilSettingDetail";
		public const string TableAlias = "UtilSettingDetail";
		public const string CreatedOn = "CreatedOn";
		public const string CreatedBy = "CreatedBy";
		public const string ModifiedOn = "ModifiedOn";
		public const string ModifiedBy = "ModifiedBy";
	}

	public partial class ACOutputGroupMainZoneMapSchema
	{
		public const string ACOutputGroupMainZoneMapPK = "ACOutputGroupMainZoneMapPK";
		public const string ACOutputGroupPK = "ACOutputGroupPK";
		public const string ACMainZonePK = "ACMainZonePK";
		public const string MainZoneID = "MainZoneID";
		public const string ACPanelPK = "ACPanelPK";
		public const string GroupID = "GroupID";
		public const string UnitID = "UnitID";
		public const string Address1 = "Address1";
		public const string BuildingID = "BuildingID";
		public const string BDBuildingPK = "BDBuildingPK";
		public const string ACMainZone = "ACMainZone";
		public const string ACOutputGroup = "ACOutputGroup";
		public const string TableName = "ACOutputGroupMainZoneMap";
		public const string TableAlias = "ACOutputGroupMainZoneMap";
		public const string CreatedOn = "CreatedOn";
		public const string CreatedBy = "CreatedBy";
		public const string ModifiedOn = "ModifiedOn";
		public const string ModifiedBy = "ModifiedBy";
	}

	public partial class ACCardHolderSchema
	{
		public const string ACCardHolderPK = "ACCardHolderPK";
		public const string Sitecode = "Sitecode";
		public const string Embossed = "Embossed";
		public const string Encoded = "Encoded";
		public const string CardTypeID = "CardTypeID";
		public const string FirstName = "FirstName";
		public const string LastName = "LastName";
		public const string Photo = "Photo";
		public const string ValidFrom = "ValidFrom";
		public const string ValidThru = "ValidThru";
		public const string FIPS = "FIPS";
		public const string Pin = "Pin";
		public const string BDTenantPK = "BDTenantPK";
		public const string Notes = "Notes";
		public const string EventNotifyEmail = "EventNotifyEmail";
		public const string FireWarden = "FireWarden";
		public const string CustInfo1 = "CustInfo1";
		public const string CustInfo2 = "CustInfo2";
		public const string CustInfo3 = "CustInfo3";
		public const string CustInfo4 = "CustInfo4";
		public const string CustInfo5 = "CustInfo5";
		public const string CustInfo6 = "CustInfo6";
		public const string CustInfo7 = "CustInfo7";
		public const string CustInfo8 = "CustInfo8";
		public const string Suite = "Suite";
		public const string Tenant = "Tenant";
		public const string BDBuildingPK = "BDBuildingPK";
		public const string Address1 = "Address1";
		public const string BuildingID = "BuildingID";
		public const string ACCardHolderBuildingMapList = "ACCardHolderBuildingMapList";
		public const string BDTenant = "BDTenant";
		public const string FullName = "FullName";
		public const string TableName = "ACCardHolder";
		public const string TableAlias = "ACCardHolder";
		public const string CreatedOn = "CreatedOn";
		public const string CreatedBy = "CreatedBy";
		public const string ModifiedOn = "ModifiedOn";
		public const string ModifiedBy = "ModifiedBy";
	}

	public partial class ACMainZoneSchema
	{
		public const string ACMainZonePK = "ACMainZonePK";
		public const string ACPanelPK = "ACPanelPK";
		public const string MainZoneID = "MainZoneID";
		public const string MainZoneTypeID = "MainZoneTypeID";
		public const string Description = "Description";
		public const string ReaderName = "ReaderName";
		public const string ReaderTypeID = "ReaderTypeID";
		public const string ReverseColor = "ReverseColor";
		public const string OutputGroup = "OutputGroup";
		public const string NeedPin = "NeedPin";
		public const string AntiPassback = "AntiPassback";
		public const string SoftAntiPassback = "SoftAntiPassback";
		public const string UnlockTimecode = "UnlockTimecode";
		public const string UnlockOn1stRead = "UnlockOn1stRead";
		public const string RexShuntOnly = "RexShuntOnly";
		public const string PulseTime = "PulseTime";
		public const string RelockByTimeout = "RelockByTimeout";
		public const string ForceAMFormat = "ForceAMFormat";
		public const string PropAMFFormat = "PropAMFFormat";
		public const string Debounce = "Debounce";
		public const string AllowOpenTime = "AllowOpenTime";
		public const string NoPreAlarm = "NoPreAlarm";
		public const string PostPreAlarm = "PostPreAlarm";
		public const string PostDuration = "PostDuration";
		public const string Notes = "Notes";
		public const string EventNotifyEmail = "EventNotifyEmail";
		public const string IsPulsed = "IsPulsed";
		public const string AlwaysToMAS = "AlwaysToMAS";
		public const string CommentBeforePulse = "CommentBeforePulse";
		public const string Degrade = "Degrade";
		public const string ReaderPassMode = "ReaderPassMode";
		public const string PanelZoneID = "PanelZoneID";
		public const string LockTypeID = "LockTypeID";
		public const string Locked = "Locked";
		public const string InputGroup = "InputGroup";
		public const string UnlockTempTC = "UnlockTempTC";
		public const string UnlockTempBegin = "UnlockTempBegin";
		public const string UnlockTempEnd = "UnlockTempEnd";
		public const string BDBuildingPK = "BDBuildingPK";
		public const string UnitID = "UnitID";
		public const string Address1 = "Address1";
		public const string BuildingID = "BuildingID";
		public const string ACOutputGroupMainZoneMapList = "ACOutputGroupMainZoneMapList";
		public const string ACAccessLevelDetailList = "ACAccessLevelDetailList";
		public const string ACPanel = "ACPanel";
		public const string TableName = "ACMainZone";
		public const string TableAlias = "ACMainZone";
		public const string CreatedOn = "CreatedOn";
		public const string CreatedBy = "CreatedBy";
		public const string ModifiedOn = "ModifiedOn";
		public const string ModifiedBy = "ModifiedBy";
	}

	public partial class ACIntervalSchema
	{
		public const string ACIntervalPK = "ACIntervalPK";
		public const string BDBuildingPK = "BDBuildingPK";
		public const string IVID = "IVID";
		public const string Begin = "Begin";
		public const string End = "End";
		public const string Sun = "Sun";
		public const string Mon = "Mon";
		public const string Tue = "Tue";
		public const string Wed = "Wed";
		public const string Thu = "Thu";
		public const string Fri = "Fri";
		public const string Sat = "Sat";
		public const string Hol = "Hol";
		public const string Address1 = "Address1";
		public const string BuildingID = "BuildingID";
		public const string ACIntvalHolidayMapList = "ACIntvalHolidayMapList";
		public const string ACTimecodeIntervalMapList = "ACTimecodeIntervalMapList";
		public const string BDBuilding = "BDBuilding";
		public const string TableName = "ACInterval";
		public const string TableAlias = "ACInterval";
		public const string CreatedOn = "CreatedOn";
		public const string CreatedBy = "CreatedBy";
		public const string ModifiedOn = "ModifiedOn";
		public const string ModifiedBy = "ModifiedBy";
	}

	public partial class ACPanelHolidayMapSchema
	{
		public const string ACPanelHolidayMapPK = "ACPanelHolidayMapPK";
		public const string ACPanelPK = "ACPanelPK";
		public const string UtilHolidayPK = "UtilHolidayPK";
		public const string Date = "Date";
		public const string Holiday = "Holiday";
		public const string BDBuildingPK = "BDBuildingPK";
		public const string UnitID = "UnitID";
		public const string Address1 = "Address1";
		public const string BuildingID = "BuildingID";
		public const string UtilHoliday = "UtilHoliday";
		public const string ACPanel = "ACPanel";
		public const string TableName = "ACPanelHolidayMap";
		public const string TableAlias = "ACPanelHolidayMap";
		public const string CreatedOn = "CreatedOn";
		public const string CreatedBy = "CreatedBy";
		public const string ModifiedOn = "ModifiedOn";
		public const string ModifiedBy = "ModifiedBy";
	}

	public partial class ACTimecodeSchema
	{
		public const string ACTimecodePK = "ACTimecodePK";
		public const string BDBuildingPK = "BDBuildingPK";
		public const string TCID = "TCID";
		public const string Summary = "Summary";
		public const string Notes = "Notes";
		public const string Address1 = "Address1";
		public const string BuildingID = "BuildingID";
		public const string ACAccessLevelDetailList = "ACAccessLevelDetailList";
		public const string ACTimecodeIntervalMapList = "ACTimecodeIntervalMapList";
		public const string BDBuilding = "BDBuilding";
		public const string TableName = "ACTimecode";
		public const string TableAlias = "ACTimecode";
		public const string CreatedOn = "CreatedOn";
		public const string CreatedBy = "CreatedBy";
		public const string ModifiedOn = "ModifiedOn";
		public const string ModifiedBy = "ModifiedBy";
	}

	public partial class ACTimecodeIntervalMapSchema
	{
		public const string ACTimecodeIntervalMapPK = "ACTimecodeIntervalMapPK";
		public const string ACTimecodePK = "ACTimecodePK";
		public const string ACIntervalPK = "ACIntervalPK";
		public const string End = "End";
		public const string Begin = "Begin";
		public const string IVID = "IVID";
		public const string TCID = "TCID";
		public const string BDBuildingPK = "BDBuildingPK";
		public const string Address1 = "Address1";
		public const string BuildingID = "BuildingID";
		public const string ACInterval = "ACInterval";
		public const string ACTimecode = "ACTimecode";
		public const string TableName = "ACTimecodeIntervalMap";
		public const string TableAlias = "ACTimecodeIntervalMap";
		public const string CreatedOn = "CreatedOn";
		public const string CreatedBy = "CreatedBy";
		public const string ModifiedOn = "ModifiedOn";
		public const string ModifiedBy = "ModifiedBy";
	}

	public partial class ACAMFormatSchema
	{
		public const string ACAMFormatPK = "ACAMFormatPK";
		public const string BDBuildingPK = "BDBuildingPK";
		public const string AMFID = "AMFID";
		public const string Summary = "Summary";
		public const string Notes = "Notes";
		public const string ReportTC = "ReportTC";
		public const string AlarmTC = "AlarmTC";
		public const string PreAlarmTC = "PreAlarmTC";
		public const string Address1 = "Address1";
		public const string BuildingID = "BuildingID";
		public const string BDBuilding = "BDBuilding";
		public const string TableName = "ACAMFormat";
		public const string TableAlias = "ACAMFormat";
		public const string CreatedOn = "CreatedOn";
		public const string CreatedBy = "CreatedBy";
		public const string ModifiedOn = "ModifiedOn";
		public const string ModifiedBy = "ModifiedBy";
	}

	public partial class BDBuildingHolidayMapSchema
	{
		public const string BDBuildingHolidayMapPK = "BDBuildingHolidayMapPK";
		public const string BDBuildingPK = "BDBuildingPK";
		public const string UtilHolidayPK = "UtilHolidayPK";
		public const string ActionID = "ActionID";
		public const string Notes = "Notes";
		public const string Address1 = "Address1";
		public const string BuildingID = "BuildingID";
		public const string Date = "Date";
		public const string Holiday = "Holiday";
		public const string BDBuilding = "BDBuilding";
		public const string UtilHoliday = "UtilHoliday";
		public const string TableName = "BDBuildingHolidayMap";
		public const string TableAlias = "BDBuildingHolidayMap";
		public const string CreatedOn = "CreatedOn";
		public const string CreatedBy = "CreatedBy";
		public const string ModifiedOn = "ModifiedOn";
		public const string ModifiedBy = "ModifiedBy";
	}

	public partial class ACOutputGroupSchema
	{
		public const string ACOutputGroupPK = "ACOutputGroupPK";
		public const string ACPanelPK = "ACPanelPK";
		public const string GroupID = "GroupID";
		public const string Summary = "Summary";
		public const string BDBuildingPK = "BDBuildingPK";
		public const string UnitID = "UnitID";
		public const string Address1 = "Address1";
		public const string BuildingID = "BuildingID";
		public const string ACOutputGroupMainZoneMapList = "ACOutputGroupMainZoneMapList";
		public const string ACPanel = "ACPanel";
		public const string TableName = "ACOutputGroup";
		public const string TableAlias = "ACOutputGroup";
		public const string CreatedOn = "CreatedOn";
		public const string CreatedBy = "CreatedBy";
		public const string ModifiedOn = "ModifiedOn";
		public const string ModifiedBy = "ModifiedBy";
	}

	public partial class BDTenantHolidayMapSchema
	{
		public const string BDTenantHolidayMapPK = "BDTenantHolidayMapPK";
		public const string BDTenantPK = "BDTenantPK";
		public const string UtilHolidayPK = "UtilHolidayPK";
		public const string ActionID = "ActionID";
		public const string Notes = "Notes";
		public const string Tenant = "Tenant";
		public const string BDBuildingPK = "BDBuildingPK";
		public const string Date = "Date";
		public const string Holiday = "Holiday";
		public const string Address1 = "Address1";
		public const string BuildingID = "BuildingID";
		public const string BDTenant = "BDTenant";
		public const string UtilHoliday = "UtilHoliday";
		public const string TableName = "BDTenantHolidayMap";
		public const string TableAlias = "BDTenantHolidayMap";
		public const string CreatedOn = "CreatedOn";
		public const string CreatedBy = "CreatedBy";
		public const string ModifiedOn = "ModifiedOn";
		public const string ModifiedBy = "ModifiedBy";
	}

	public partial class LogRowsCountSchema
	{
		public const string LogRowsCountPK = "LogRowsCountPK";
		public const string SessionID = "SessionID";
		public const string SessionDateTime = "SessionDateTime";
		public const string DBTableName = "DBTableName";
		public const string SequenceID = "SequenceID";
		public const string RowsCount = "RowsCount";
		public const string TableName = "LogRowsCount";
		public const string TableAlias = "LogRowsCount";
		public const string CreatedOn = "CreatedOn";
		public const string CreatedBy = "CreatedBy";
		public const string ModifiedOn = "ModifiedOn";
		public const string ModifiedBy = "ModifiedBy";
	}

	public partial class ACInputGroupSchema
	{
		public const string ACInputGroupPK = "ACInputGroupPK";
		public const string ACPanelPK = "ACPanelPK";
		public const string GroupID = "GroupID";
		public const string Summary = "Summary";
		public const string BDBuildingPK = "BDBuildingPK";
		public const string UnitID = "UnitID";
		public const string Address1 = "Address1";
		public const string BuildingID = "BuildingID";
		public const string ACInputGroupInputMapList = "ACInputGroupInputMapList";
		public const string ACPanel = "ACPanel";
		public const string TableName = "ACInputGroup";
		public const string TableAlias = "ACInputGroup";
		public const string CreatedOn = "CreatedOn";
		public const string CreatedBy = "CreatedBy";
		public const string ModifiedOn = "ModifiedOn";
		public const string ModifiedBy = "ModifiedBy";
	}

	public partial class ACInputSchema
	{
		public const string ACInputPK = "ACInputPK";
		public const string ACPanelPK = "ACPanelPK";
		public const string InputID = "InputID";
		public const string Description = "Description";
		public const string Debounce = "Debounce";
		public const string Reverse = "Reverse";
		public const string ForceAMFormat = "ForceAMFormat";
		public const string OffOnRestore = "OffOnRestore";
		public const string External = "External";
		public const string Notes = "Notes";
		public const string AlwaysToMAS = "AlwaysToMAS";
		public const string PanelZoneID = "PanelZoneID";
		public const string Locked = "Locked";
		public const string BDBuildingPK = "BDBuildingPK";
		public const string UnitID = "UnitID";
		public const string Address1 = "Address1";
		public const string BuildingID = "BuildingID";
		public const string ACInputGroupInputMapList = "ACInputGroupInputMapList";
		public const string ACPanel = "ACPanel";
		public const string TableName = "ACInput";
		public const string TableAlias = "ACInput";
		public const string CreatedOn = "CreatedOn";
		public const string CreatedBy = "CreatedBy";
		public const string ModifiedOn = "ModifiedOn";
		public const string ModifiedBy = "ModifiedBy";
	}

	public partial class ACFunctionCardSchema
	{
		public const string ACFunctionCardPK = "ACFunctionCardPK";
		public const string Sitecode = "Sitecode";
		public const string Embossed = "Embossed";
		public const string Encoded = "Encoded";
		public const string CardTypeID = "CardTypeID";
		public const string BDTenantPK = "BDTenantPK";
		public const string FunctionID = "FunctionID";
		public const string FirstName = "FirstName";
		public const string LastName = "LastName";
		public const string FIPS = "FIPS";
		public const string Pin = "Pin";
		public const string ValidFrom = "ValidFrom";
		public const string ValidThru = "ValidThru";
		public const string Suite = "Suite";
		public const string Tenant = "Tenant";
		public const string BDBuildingPK = "BDBuildingPK";
		public const string Address1 = "Address1";
		public const string BuildingID = "BuildingID";
		public const string ACPanelFunctionCardMapList = "ACPanelFunctionCardMapList";
		public const string BDTenant = "BDTenant";
		public const string FullName = "FullName";
		public const string TableName = "ACFunctionCard";
		public const string TableAlias = "ACFunctionCard";
		public const string CreatedOn = "CreatedOn";
		public const string CreatedBy = "CreatedBy";
		public const string ModifiedOn = "ModifiedOn";
		public const string ModifiedBy = "ModifiedBy";
	}

	public partial class UtilHolidaySchema
	{
		public const string UtilHolidayPK = "UtilHolidayPK";
		public const string CountryID = "CountryID";
		public const string Holiday = "Holiday";
		public const string Date = "Date";
		public const string Major = "Major";
		public const string Federal = "Federal";
		public const string Default = "Default";
		public const string ActionID = "ActionID";
		public const string BDTenantHolidayMapList = "BDTenantHolidayMapList";
		public const string BDBuildingHolidayMapList = "BDBuildingHolidayMapList";
		public const string ACPanelHolidayMapList = "ACPanelHolidayMapList";
		public const string ACIntvalHolidayMapList = "ACIntvalHolidayMapList";
		public const string TableName = "UtilHoliday";
		public const string TableAlias = "UtilHoliday";
		public const string CreatedOn = "CreatedOn";
		public const string CreatedBy = "CreatedBy";
		public const string ModifiedOn = "ModifiedOn";
		public const string ModifiedBy = "ModifiedBy";
	}

	public partial class ACAccessLevelSchema
	{
		public const string ACAccessLevelPK = "ACAccessLevelPK";
		public const string BDBuildingPK = "BDBuildingPK";
		public const string AccessLevelID = "AccessLevelID";
		public const string Summary = "Summary";
		public const string AsAL2 = "AsAL2";
		public const string Notes = "Notes";
		public const string Address1 = "Address1";
		public const string BuildingID = "BuildingID";
		public const string ACAccessLevelDetailList = "ACAccessLevelDetailList";
		public const string BDBuilding = "BDBuilding";
		public const string TableName = "ACAccessLevel";
		public const string TableAlias = "ACAccessLevel";
		public const string CreatedOn = "CreatedOn";
		public const string CreatedBy = "CreatedBy";
		public const string ModifiedOn = "ModifiedOn";
		public const string ModifiedBy = "ModifiedBy";
	}

	public partial class ACPanelFunctionCardMapSchema
	{
		public const string ACPanelFunctionCardMapPK = "ACPanelFunctionCardMapPK";
		public const string ACPanelPK = "ACPanelPK";
		public const string ACFunctionCardPK = "ACFunctionCardPK";
		public const string CardTypeID = "CardTypeID";
		public const string Encoded = "Encoded";
		public const string Embossed = "Embossed";
		public const string Sitecode = "Sitecode";
		public const string BDBuildingPK = "BDBuildingPK";
		public const string UnitID = "UnitID";
		public const string Address1 = "Address1";
		public const string BuildingID = "BuildingID";
		public const string ACFunctionCard = "ACFunctionCard";
		public const string ACPanel = "ACPanel";
		public const string TableName = "ACPanelFunctionCardMap";
		public const string TableAlias = "ACPanelFunctionCardMap";
		public const string CreatedOn = "CreatedOn";
		public const string CreatedBy = "CreatedBy";
		public const string ModifiedOn = "ModifiedOn";
		public const string ModifiedBy = "ModifiedBy";
	}

	public partial class LogDBDeleteActivitySchema
	{
		public const string LogDBDeleteActivityPK = "LogDBDeleteActivityPK";
		public const string LogDateTime = "LogDateTime";
		public const string DBTableName = "DBTableName";
		public const string RecordPK = "RecordPK";
		public const string LastUpdated = "LastUpdated";
		public const string TableName = "LogDBDeleteActivity";
		public const string TableAlias = "LogDBDeleteActivity";
		public const string CreatedOn = "CreatedOn";
		public const string CreatedBy = "CreatedBy";
		public const string ModifiedOn = "ModifiedOn";
		public const string ModifiedBy = "ModifiedBy";
	}

	public partial class UsrAccountSchema
	{
		public const string UsrAccountPK = "UsrAccountPK";
		public const string UserID = "UserID";
		public const string IsAdmin = "IsAdmin";
		public const string IsCentral = "IsCentral";
		public const string FirstName = "FirstName";
		public const string LastName = "LastName";
		public const string Password = "Password";
		public const string PwdExpireDate = "PwdExpireDate";
		public const string UsrGroupPK = "UsrGroupPK";
		public const string BDTenantPK = "BDTenantPK";
		public const string CellPhone = "CellPhone";
		public const string HomePhone = "HomePhone";
		public const string OfficePhone = "OfficePhone";
		public const string Email = "Email";
		public const string LastLogin = "LastLogin";
		public const string TotalUsage = "TotalUsage";
		public const string StartScreen = "StartScreen";
		public const string PopupExtension = "PopupExtension";
		public const string Suite = "Suite";
		public const string Tenant = "Tenant";
		public const string BDBuildingPK = "BDBuildingPK";
		public const string UsrGroupName = "UsrGroupName";
		public const string Address1 = "Address1";
		public const string BuildingID = "BuildingID";
		public const string UsrAccountBuildingMapList = "UsrAccountBuildingMapList";
		public const string UsrAccountBRRuleList = "UsrAccountBRRuleList";
		public const string UsrAccountDBRuleList = "UsrAccountDBRuleList";
		public const string UsrAccountTenantMapList = "UsrAccountTenantMapList";
		public const string BDTenant = "BDTenant";
		public const string UsrGroup = "UsrGroup";
		public const string FullName = "FullName";
		public const string TableName = "UsrAccount";
		public const string TableAlias = "UsrAccount";
		public const string CreatedOn = "CreatedOn";
		public const string CreatedBy = "CreatedBy";
		public const string ModifiedOn = "ModifiedOn";
		public const string ModifiedBy = "ModifiedBy";
	}

	public partial class LogDBEditActivitySchema
	{
		public const string LogDBEditActivityPK = "LogDBEditActivityPK";
		public const string LogDateTime = "LogDateTime";
		public const string DBTableName = "DBTableName";
		public const string RecordPK = "RecordPK";
		public const string Category = "Category";
		public const string RecordDetail = "RecordDetail";
		public const string TableName = "LogDBEditActivity";
		public const string TableAlias = "LogDBEditActivity";
		public const string CreatedOn = "CreatedOn";
		public const string CreatedBy = "CreatedBy";
		public const string ModifiedOn = "ModifiedOn";
		public const string ModifiedBy = "ModifiedBy";
	}

	public partial class ACMasterCardSchema
	{
		public const string ACMasterCardPK = "ACMasterCardPK";
		public const string Sitecode = "Sitecode";
		public const string Embossed = "Embossed";
		public const string Encoded = "Encoded";
		public const string CardTypeID = "CardTypeID";
		public const string FirstName = "FirstName";
		public const string LastName = "LastName";
		public const string Photo = "Photo";
		public const string FIPS = "FIPS";
		public const string Pin = "Pin";
		public const string FullName = "FullName";
		public const string TableName = "ACMasterCard";
		public const string TableAlias = "ACMasterCard";
		public const string CreatedOn = "CreatedOn";
		public const string CreatedBy = "CreatedBy";
		public const string ModifiedOn = "ModifiedOn";
		public const string ModifiedBy = "ModifiedBy";
	}

	public partial class ACSupervisorySchema
	{
		public const string ACSupervisoryPK = "ACSupervisoryPK";
		public const string ACPanelPK = "ACPanelPK";
		public const string SupervisoryID = "SupervisoryID";
		public const string Description = "Description";
		public const string Debounce = "Debounce";
		public const string ForceAMFormat = "ForceAMFormat";
		public const string External = "External";
		public const string Notes = "Notes";
		public const string PanelZoneID = "PanelZoneID";
		public const string Locked = "Locked";
		public const string BDBuildingPK = "BDBuildingPK";
		public const string UnitID = "UnitID";
		public const string Address1 = "Address1";
		public const string BuildingID = "BuildingID";
		public const string ACPanel = "ACPanel";
		public const string TableName = "ACSupervisory";
		public const string TableAlias = "ACSupervisory";
		public const string CreatedOn = "CreatedOn";
		public const string CreatedBy = "CreatedBy";
		public const string ModifiedOn = "ModifiedOn";
		public const string ModifiedBy = "ModifiedBy";
	}

	public partial class UsrGroupSchema
	{
		public const string UsrGroupPK = "UsrGroupPK";
		public const string UsrGroupName = "UsrGroupName";
		public const string Description = "Description";
		public const string UsrGroupDBRuleList = "UsrGroupDBRuleList";
		public const string UsrGroupBRRuleList = "UsrGroupBRRuleList";
		public const string UsrAccountList = "UsrAccountList";
		public const string TableName = "UsrGroup";
		public const string TableAlias = "UsrGroup";
		public const string CreatedOn = "CreatedOn";
		public const string CreatedBy = "CreatedBy";
		public const string ModifiedOn = "ModifiedOn";
		public const string ModifiedBy = "ModifiedBy";
	}

	public partial class ACCardHolderBuildingMapSchema
	{
		public const string ACCardHolderBuildingMapPK = "ACCardHolderBuildingMapPK";
		public const string ACCardHolderPK = "ACCardHolderPK";
		public const string BDBuildingPK = "BDBuildingPK";
		public const string AL1st = "AL1st";
		public const string AL2nd = "AL2nd";
		public const string Address1 = "Address1";
		public const string BuildingID = "BuildingID";
		public const string LastName = "LastName";
		public const string FirstName = "FirstName";
		public const string CardTypeID = "CardTypeID";
		public const string Encoded = "Encoded";
		public const string Embossed = "Embossed";
		public const string Sitecode = "Sitecode";
		public const string BDBuilding = "BDBuilding";
		public const string ACCardHolder = "ACCardHolder";
		public const string FullName = "FullName";
		public const string TableName = "ACCardHolderBuildingMap";
		public const string TableAlias = "ACCardHolderBuildingMap";
		public const string CreatedOn = "CreatedOn";
		public const string CreatedBy = "CreatedBy";
		public const string ModifiedOn = "ModifiedOn";
		public const string ModifiedBy = "ModifiedBy";
	}

	public partial class BDVisitorSchema
	{
		public const string BDVisitorPK = "BDVisitorPK";
		public const string BDTenantPK = "BDTenantPK";
		public const string FirstName = "FirstName";
		public const string LastName = "LastName";
		public const string AuthorizedBy = "AuthorizedBy";
		public const string AuthorizedArea = "AuthorizedArea";
		public const string AuthorEmail = "AuthorEmail";
		public const string EmailNotify = "EmailNotify";
		public const string ValidFrom = "ValidFrom";
		public const string ValidThru = "ValidThru";
		public const string Password = "Password";
		public const string Special = "Special";
		public const string Photo = "Photo";
		public const string Begin = "Begin";
		public const string End = "End";
		public const string SiteCode = "SiteCode";
		public const string Encoded = "Encoded";
		public const string Scheduled = "Scheduled";
		public const string ArrivedTime = "ArrivedTime";
		public const string TurnstileAccess = "TurnstileAccess";
		public const string BadgePrinted = "BadgePrinted";
		public const string Suite = "Suite";
		public const string Tenant = "Tenant";
		public const string BDBuildingPK = "BDBuildingPK";
		public const string Address1 = "Address1";
		public const string BuildingID = "BuildingID";
		public const string BDTenant = "BDTenant";
		public const string FullName = "FullName";
		public const string TableName = "BDVisitor";
		public const string TableAlias = "BDVisitor";
		public const string CreatedOn = "CreatedOn";
		public const string CreatedBy = "CreatedBy";
		public const string ModifiedOn = "ModifiedOn";
		public const string ModifiedBy = "ModifiedBy";
	}

	public partial class UsrGroupDBRuleSchema
	{
		public const string UsrGroupDBRulePK = "UsrGroupDBRulePK";
		public const string UsrGroupPK = "UsrGroupPK";
		public const string DBRuleID = "DBRuleID";
		public const string Selectable = "Selectable";
		public const string Insertable = "Insertable";
		public const string Editable = "Editable";
		public const string Deletable = "Deletable";
		public const string UsrGroupName = "UsrGroupName";
		public const string UsrGroup = "UsrGroup";
		public const string TableName = "UsrGroupDBRule";
		public const string TableAlias = "UsrGroupDBRule";
		public const string CreatedOn = "CreatedOn";
		public const string CreatedBy = "CreatedBy";
		public const string ModifiedOn = "ModifiedOn";
		public const string ModifiedBy = "ModifiedBy";
	}

	public partial class ACPanelSchema
	{
		public const string ACPanelPK = "ACPanelPK";
		public const string UnitID = "UnitID";
		public const string BDBuildingPK = "BDBuildingPK";
		public const string SerialNumber = "SerialNumber";
		public const string PanelName = "PanelName";
		public const string BufferSize = "BufferSize";
		public const string DialUp = "DialUp";
		public const string UnitPhone = "UnitPhone";
		public const string UnitPhoneCallerID = "UnitPhoneCallerID";
		public const string UnitExt = "UnitExt";
		public const string LongDistance = "LongDistance";
		public const string ModemInitString = "ModemInitString";
		public const string BaudRate = "BaudRate";
		public const string HistoryPhone = "HistoryPhone";
		public const string AlarmPhone1 = "AlarmPhone1";
		public const string AlarmPhone2 = "AlarmPhone2";
		public const string DialingPrefixPanel = "DialingPrefixPanel";
		public const string DialingSuffixPanel = "DialingSuffixPanel";
		public const string DialOutEnabled = "DialOutEnabled";
		public const string DayLightSaving = "DayLightSaving";
		public const string OnSiteMonitor = "OnSiteMonitor";
		public const string CentralDelay = "CentralDelay";
		public const string ElevPulse = "ElevPulse";
		public const string PanelTypeID = "PanelTypeID";
		public const string UnbufferTC = "UnbufferTC";
		public const string MandatoryUnbufferTC = "MandatoryUnbufferTC";
		public const string SwingerCount = "SwingerCount";
		public const string SwingerTime = "SwingerTime";
		public const string LoopNumb = "LoopNumb";
		public const string PortNumb = "PortNumb";
		public const string Notes = "Notes";
		public const string Trouble = "Trouble";
		public const string NoVersionCheck = "NoVersionCheck";
		public const string DeviceId = "DeviceId";
		public const string DBSyncSeconds = "DBSyncSeconds";
		public const string DBSaveMinutes = "DBSaveMinutes";
		public const string IsE150 = "IsE150";
		public const string GroupID = "GroupID";
		public const string NoAutoDownload = "NoAutoDownload";
		public const string NoAutoDownloadStart = "NoAutoDownloadStart";
		public const string Locked = "Locked";
		public const string InDebug = "InDebug";
		public const string Address1 = "Address1";
		public const string BuildingID = "BuildingID";
		public const string ACInputList = "ACInputList";
		public const string ACSupervisoryList = "ACSupervisoryList";
		public const string ACPanelHolidayMapList = "ACPanelHolidayMapList";
		public const string ACMainZoneList = "ACMainZoneList";
		public const string ACPanelFunctionCardMapList = "ACPanelFunctionCardMapList";
		public const string ACOutputGroupList = "ACOutputGroupList";
		public const string ACInputGroupList = "ACInputGroupList";
		public const string BDBuilding = "BDBuilding";
		public const string TableName = "ACPanel";
		public const string TableAlias = "ACPanel";
		public const string CreatedOn = "CreatedOn";
		public const string CreatedBy = "CreatedBy";
		public const string ModifiedOn = "ModifiedOn";
		public const string ModifiedBy = "ModifiedBy";
	}

	public partial class UsrAccountDBRuleSchema
	{
		public const string UsrAccountDBRulePK = "UsrAccountDBRulePK";
		public const string UsrAccountPK = "UsrAccountPK";
		public const string DBRuleID = "DBRuleID";
		public const string Selectable = "Selectable";
		public const string Insertable = "Insertable";
		public const string Editable = "Editable";
		public const string Deletable = "Deletable";
		public const string UserID = "UserID";
		public const string UsrAccount = "UsrAccount";
		public const string TableName = "UsrAccountDBRule";
		public const string TableAlias = "UsrAccountDBRule";
		public const string CreatedOn = "CreatedOn";
		public const string CreatedBy = "CreatedBy";
		public const string ModifiedOn = "ModifiedOn";
		public const string ModifiedBy = "ModifiedBy";
	}

	public partial class UsrGroupBRRuleSchema
	{
		public const string UsrGroupBRRule = "UsrGroupBRRule";
		public const string UsrGroupPK = "UsrGroupPK";
		public const string BRRuleID = "BRRuleID";
		public const string Denied = "Denied";
		public const string UsrGroupName = "UsrGroupName";
		public const string UsrGroup = "UsrGroup";
		public const string TableName = "UsrGroupBRRule";
		public const string TableAlias = "UsrGroupBRRule";
		public const string CreatedOn = "CreatedOn";
		public const string CreatedBy = "CreatedBy";
		public const string ModifiedOn = "ModifiedOn";
		public const string ModifiedBy = "ModifiedBy";
	}

	public partial class ACInputGroupInputMapSchema
	{
		public const string ACInputGroupInputMapPK = "ACInputGroupInputMapPK";
		public const string ACInputGroupPK = "ACInputGroupPK";
		public const string ACInputPK = "ACInputPK";
		public const string GroupID = "GroupID";
		public const string ACPanelPK = "ACPanelPK";
		public const string InputID = "InputID";
		public const string UnitID = "UnitID";
		public const string Address1 = "Address1";
		public const string BuildingID = "BuildingID";
		public const string BDBuildingPK = "BDBuildingPK";
		public const string ACInputGroup = "ACInputGroup";
		public const string ACInput = "ACInput";
		public const string TableName = "ACInputGroupInputMap";
		public const string TableAlias = "ACInputGroupInputMap";
		public const string CreatedOn = "CreatedOn";
		public const string CreatedBy = "CreatedBy";
		public const string ModifiedOn = "ModifiedOn";
		public const string ModifiedBy = "ModifiedBy";
	}

	public partial class UsrAccountBRRuleSchema
	{
		public const string UsrAccountBRRulePK = "UsrAccountBRRulePK";
		public const string UsrAccountPK = "UsrAccountPK";
		public const string BRRuleID = "BRRuleID";
		public const string Denied = "Denied";
		public const string UserID = "UserID";
		public const string UsrAccount = "UsrAccount";
		public const string TableName = "UsrAccountBRRule";
		public const string TableAlias = "UsrAccountBRRule";
		public const string CreatedOn = "CreatedOn";
		public const string CreatedBy = "CreatedBy";
		public const string ModifiedOn = "ModifiedOn";
		public const string ModifiedBy = "ModifiedBy";
	}

	public partial class UsrAccountTenantMapSchema
	{
		public const string UsrAccountTenantMapPK = "UsrAccountTenantMapPK";
		public const string UsrAccountPK = "UsrAccountPK";
		public const string BDTenantPK = "BDTenantPK";
		public const string Tenant = "Tenant";
		public const string BDBuildingPK = "BDBuildingPK";
		public const string UserID = "UserID";
		public const string Address1 = "Address1";
		public const string BuildingID = "BuildingID";
		public const string BDTenant = "BDTenant";
		public const string UsrAccount = "UsrAccount";
		public const string TableName = "UsrAccountTenantMap";
		public const string TableAlias = "UsrAccountTenantMap";
		public const string CreatedOn = "CreatedOn";
		public const string CreatedBy = "CreatedBy";
		public const string ModifiedOn = "ModifiedOn";
		public const string ModifiedBy = "ModifiedBy";
	}

	public partial class ACAccessLevelDetailViewSchema
	{
		public const string ACAccessLevelDetailPK = "ACAccessLevelDetailPK";
		public const string ACAccessLevelPK = "ACAccessLevelPK";
		public const string ACMainZonePK = "ACMainZonePK";
		public const string ACTimecodePK = "ACTimecodePK";
		public const string MainZoneID = "MainZoneID";
		public const string ACPanelPK = "ACPanelPK";
		public const string TCID = "TCID";
		public const string AccessLevelID = "AccessLevelID";
		public const string BDBuildingPK = "BDBuildingPK";
		public const string UnitID = "UnitID";
		public const string Address1 = "Address1";
		public const string BuildingID = "BuildingID";
	}

	public partial class ACAccessLevelViewSchema
	{
		public const string ACAccessLevelPK = "ACAccessLevelPK";
		public const string BDBuildingPK = "BDBuildingPK";
		public const string AccessLevelID = "AccessLevelID";
		public const string Summary = "Summary";
		public const string Address1 = "Address1";
		public const string BuildingID = "BuildingID";
	}

	public partial class ACAMFormatViewSchema
	{
		public const string ACAMFormatPK = "ACAMFormatPK";
		public const string BDBuildingPK = "BDBuildingPK";
		public const string AMFID = "AMFID";
		public const string Summary = "Summary";
		public const string Address1 = "Address1";
		public const string BuildingID = "BuildingID";
	}

	public partial class ACCardHolderBuildingMapViewSchema
	{
		public const string ACCardHolderBuildingMapPK = "ACCardHolderBuildingMapPK";
		public const string ACCardHolderPK = "ACCardHolderPK";
		public const string BDBuildingPK = "BDBuildingPK";
		public const string Address1 = "Address1";
		public const string BuildingID = "BuildingID";
		public const string CardTypeID = "CardTypeID";
		public const string Encoded = "Encoded";
		public const string Embossed = "Embossed";
		public const string Sitecode = "Sitecode";
	}

	public partial class ACCardHolderViewSchema
	{
		public const string ACCardHolderPK = "ACCardHolderPK";
		public const string Sitecode = "Sitecode";
		public const string Embossed = "Embossed";
		public const string Encoded = "Encoded";
		public const string CardTypeID = "CardTypeID";
		public const string BDTenantPK = "BDTenantPK";
		public const string Suite = "Suite";
		public const string Tenant = "Tenant";
		public const string BDBuildingPK = "BDBuildingPK";
		public const string Address1 = "Address1";
		public const string BuildingID = "BuildingID";
	}

	public partial class ACFunctionCardViewSchema
	{
		public const string ACFunctionCardPK = "ACFunctionCardPK";
		public const string Sitecode = "Sitecode";
		public const string Embossed = "Embossed";
		public const string Encoded = "Encoded";
		public const string CardTypeID = "CardTypeID";
		public const string BDTenantPK = "BDTenantPK";
		public const string Suite = "Suite";
		public const string Tenant = "Tenant";
		public const string BDBuildingPK = "BDBuildingPK";
		public const string Address1 = "Address1";
		public const string BuildingID = "BuildingID";
	}

	public partial class ACInputGroupInputMapViewSchema
	{
		public const string ACInputGroupInputMapPK = "ACInputGroupInputMapPK";
		public const string ACInputGroupPK = "ACInputGroupPK";
		public const string ACInputPK = "ACInputPK";
		public const string GroupID = "GroupID";
		public const string ACPanelPK = "ACPanelPK";
		public const string InputID = "InputID";
		public const string UnitID = "UnitID";
		public const string Address1 = "Address1";
		public const string BuildingID = "BuildingID";
		public const string BDBuildingPK = "BDBuildingPK";
	}

	public partial class ACInputGroupViewSchema
	{
		public const string ACInputGroupPK = "ACInputGroupPK";
		public const string ACPanelPK = "ACPanelPK";
		public const string GroupID = "GroupID";
		public const string Summary = "Summary";
		public const string BDBuildingPK = "BDBuildingPK";
		public const string UnitID = "UnitID";
		public const string Address1 = "Address1";
		public const string BuildingID = "BuildingID";
	}

	public partial class ACInputViewSchema
	{
		public const string ACInputPK = "ACInputPK";
		public const string ACPanelPK = "ACPanelPK";
		public const string InputID = "InputID";
		public const string Description = "Description";
		public const string BDBuildingPK = "BDBuildingPK";
		public const string UnitID = "UnitID";
		public const string Address1 = "Address1";
		public const string BuildingID = "BuildingID";
	}

	public partial class ACIntervalViewSchema
	{
		public const string ACIntervalPK = "ACIntervalPK";
		public const string BDBuildingPK = "BDBuildingPK";
		public const string IVID = "IVID";
		public const string Address1 = "Address1";
		public const string BuildingID = "BuildingID";
	}

	public partial class ACIntvalHolidayMapViewSchema
	{
		public const string ACIntvalHolidayMapPK = "ACIntvalHolidayMapPK";
		public const string ACIntervalPK = "ACIntervalPK";
		public const string UtilHolidayPK = "UtilHolidayPK";
		public const string IVID = "IVID";
		public const string BDBuildingPK = "BDBuildingPK";
		public const string Date = "Date";
		public const string Holiday = "Holiday";
		public const string Address1 = "Address1";
		public const string BuildingID = "BuildingID";
	}

	public partial class ACMainZoneViewSchema
	{
		public const string ACMainZonePK = "ACMainZonePK";
		public const string ACPanelPK = "ACPanelPK";
		public const string MainZoneID = "MainZoneID";
		public const string MainZoneTypeID = "MainZoneTypeID";
		public const string Description = "Description";
		public const string BDBuildingPK = "BDBuildingPK";
		public const string UnitID = "UnitID";
		public const string Address1 = "Address1";
		public const string BuildingID = "BuildingID";
	}

	public partial class ACMasterCardViewSchema
	{
		public const string ACMasterCardPK = "ACMasterCardPK";
		public const string Sitecode = "Sitecode";
		public const string Embossed = "Embossed";
		public const string Encoded = "Encoded";
		public const string CardTypeID = "CardTypeID";
	}

	public partial class ACOutputGroupMainZoneMapViewSchema
	{
		public const string ACOutputGroupMainZoneMapPK = "ACOutputGroupMainZoneMapPK";
		public const string ACOutputGroupPK = "ACOutputGroupPK";
		public const string ACMainZonePK = "ACMainZonePK";
		public const string MainZoneID = "MainZoneID";
		public const string ACPanelPK = "ACPanelPK";
		public const string GroupID = "GroupID";
		public const string UnitID = "UnitID";
		public const string Address1 = "Address1";
		public const string BuildingID = "BuildingID";
		public const string BDBuildingPK = "BDBuildingPK";
	}

	public partial class ACOutputGroupViewSchema
	{
		public const string ACOutputGroupPK = "ACOutputGroupPK";
		public const string ACPanelPK = "ACPanelPK";
		public const string GroupID = "GroupID";
		public const string Summary = "Summary";
		public const string BDBuildingPK = "BDBuildingPK";
		public const string UnitID = "UnitID";
		public const string Address1 = "Address1";
		public const string BuildingID = "BuildingID";
	}

	public partial class ACPanelFunctionCardMapViewSchema
	{
		public const string ACPanelFunctionCardMapPK = "ACPanelFunctionCardMapPK";
		public const string ACPanelPK = "ACPanelPK";
		public const string ACFunctionCardPK = "ACFunctionCardPK";
		public const string CardTypeID = "CardTypeID";
		public const string Encoded = "Encoded";
		public const string Embossed = "Embossed";
		public const string Sitecode = "Sitecode";
		public const string BDBuildingPK = "BDBuildingPK";
		public const string UnitID = "UnitID";
	}

	public partial class ACPanelHolidayMapViewSchema
	{
		public const string ACPanelHolidayMapPK = "ACPanelHolidayMapPK";
		public const string ACPanelPK = "ACPanelPK";
		public const string UtilHolidayPK = "UtilHolidayPK";
		public const string Date = "Date";
		public const string Holiday = "Holiday";
		public const string BDBuildingPK = "BDBuildingPK";
		public const string UnitID = "UnitID";
	}

	public partial class ACPanelViewSchema
	{
		public const string ACPanelPK = "ACPanelPK";
		public const string UnitID = "UnitID";
		public const string BDBuildingPK = "BDBuildingPK";
		public const string PanelName = "PanelName";
		public const string Address1 = "Address1";
		public const string BuildingID = "BuildingID";
	}

	public partial class ACSupervisoryViewSchema
	{
		public const string ACSupervisoryPK = "ACSupervisoryPK";
		public const string ACPanelPK = "ACPanelPK";
		public const string SupervisoryID = "SupervisoryID";
		public const string Description = "Description";
		public const string BDBuildingPK = "BDBuildingPK";
		public const string UnitID = "UnitID";
		public const string Address1 = "Address1";
		public const string BuildingID = "BuildingID";
	}

	public partial class ACTimecodeIntervalMapViewSchema
	{
		public const string ACTimecodeIntervalMapPK = "ACTimecodeIntervalMapPK";
		public const string ACTimecodePK = "ACTimecodePK";
		public const string ACIntervalPK = "ACIntervalPK";
		public const string IVID = "IVID";
		public const string TCID = "TCID";
		public const string BDBuildingPK = "BDBuildingPK";
		public const string Address1 = "Address1";
		public const string BuildingID = "BuildingID";
	}

	public partial class ACTimecodeViewSchema
	{
		public const string ACTimecodePK = "ACTimecodePK";
		public const string BDBuildingPK = "BDBuildingPK";
		public const string TCID = "TCID";
		public const string Summary = "Summary";
		public const string Address1 = "Address1";
		public const string BuildingID = "BuildingID";
	}

	public partial class BDBuildingHolidayMapViewSchema
	{
		public const string BDBuildingHolidayMapPK = "BDBuildingHolidayMapPK";
		public const string BDBuildingPK = "BDBuildingPK";
		public const string UtilHolidayPK = "UtilHolidayPK";
		public const string Address1 = "Address1";
		public const string BuildingID = "BuildingID";
		public const string Date = "Date";
		public const string Holiday = "Holiday";
	}

	public partial class BDBuildingViewSchema
	{
		public const string BDBuildingPK = "BDBuildingPK";
		public const string BuildingID = "BuildingID";
		public const string Address1 = "Address1";
		public const string City = "City";
		public const string State = "State";
		public const string Zipcode = "Zipcode";
		public const string CountryID = "CountryID";
	}

	public partial class BDTenantHolidayMapViewSchema
	{
		public const string BDTenantHolidayMapPK = "BDTenantHolidayMapPK";
		public const string BDTenantPK = "BDTenantPK";
		public const string UtilHolidayPK = "UtilHolidayPK";
		public const string Tenant = "Tenant";
		public const string BDBuildingPK = "BDBuildingPK";
		public const string Date = "Date";
		public const string Holiday = "Holiday";
		public const string Address1 = "Address1";
		public const string BuildingID = "BuildingID";
	}

	public partial class BDTenantViewSchema
	{
		public const string BDTenantPK = "BDTenantPK";
		public const string BDBuildingPK = "BDBuildingPK";
		public const string Tenant = "Tenant";
		public const string Suite = "Suite";
		public const string Address1 = "Address1";
		public const string BuildingID = "BuildingID";
	}

	public partial class BDVisitorViewSchema
	{
		public const string BDVisitorPK = "BDVisitorPK";
		public const string BDTenantPK = "BDTenantPK";
		public const string Suite = "Suite";
		public const string Tenant = "Tenant";
		public const string BDBuildingPK = "BDBuildingPK";
		public const string Address1 = "Address1";
		public const string BuildingID = "BuildingID";
	}

	public partial class LogDBDeleteActivityViewSchema
	{
		public const string LogDBDeleteActivityPK = "LogDBDeleteActivityPK";
		public const string LogDateTime = "LogDateTime";
		public const string DBTableName = "DBTableName";
	}

	public partial class LogDBEditActivityViewSchema
	{
		public const string LogDBEditActivityPK = "LogDBEditActivityPK";
		public const string LogDateTime = "LogDateTime";
		public const string DBTableName = "DBTableName";
	}

	public partial class LogRowsCountViewSchema
	{
		public const string LogRowsCountPK = "LogRowsCountPK";
		public const string SessionID = "SessionID";
		public const string SessionDateTime = "SessionDateTime";
	}

	public partial class UsrAccountBRRuleViewSchema
	{
		public const string UsrAccountBRRulePK = "UsrAccountBRRulePK";
		public const string UsrAccountPK = "UsrAccountPK";
		public const string BRRuleID = "BRRuleID";
		public const string UserID = "UserID";
	}

	public partial class UsrAccountBuildingMapViewSchema
	{
		public const string UsrAccountBuildingMapPK = "UsrAccountBuildingMapPK";
		public const string UsrAccountPK = "UsrAccountPK";
		public const string BDBuildingPK = "BDBuildingPK";
		public const string Address1 = "Address1";
		public const string BuildingID = "BuildingID";
		public const string UserID = "UserID";
	}

	public partial class UsrAccountDBRuleViewSchema
	{
		public const string UsrAccountDBRulePK = "UsrAccountDBRulePK";
		public const string UsrAccountPK = "UsrAccountPK";
		public const string DBRuleID = "DBRuleID";
		public const string UserID = "UserID";
	}

	public partial class UsrAccountTenantMapViewSchema
	{
		public const string UsrAccountTenantMapPK = "UsrAccountTenantMapPK";
		public const string UsrAccountPK = "UsrAccountPK";
		public const string BDTenantPK = "BDTenantPK";
		public const string Tenant = "Tenant";
		public const string BDBuildingPK = "BDBuildingPK";
		public const string UserID = "UserID";
		public const string Address1 = "Address1";
		public const string BuildingID = "BuildingID";
	}

	public partial class UsrAccountViewSchema
	{
		public const string UsrAccountPK = "UsrAccountPK";
		public const string UserID = "UserID";
		public const string Suite = "Suite";
		public const string Tenant = "Tenant";
		public const string BDBuildingPK = "BDBuildingPK";
		public const string UsrGroupName = "UsrGroupName";
		public const string Address1 = "Address1";
		public const string BuildingID = "BuildingID";
	}

	public partial class UsrGroupBRRuleViewSchema
	{
		public const string UsrGroupBRRule = "UsrGroupBRRule";
		public const string UsrGroupPK = "UsrGroupPK";
		public const string BRRuleID = "BRRuleID";
		public const string UsrGroupName = "UsrGroupName";
	}

	public partial class UsrGroupDBRuleViewSchema
	{
		public const string UsrGroupDBRulePK = "UsrGroupDBRulePK";
		public const string UsrGroupPK = "UsrGroupPK";
		public const string DBRuleID = "DBRuleID";
		public const string UsrGroupName = "UsrGroupName";
	}

	public partial class UsrGroupViewSchema
	{
		public const string UsrGroupPK = "UsrGroupPK";
		public const string UsrGroupName = "UsrGroupName";
	}

	public partial class UtilHolidayViewSchema
	{
		public const string UtilHolidayPK = "UtilHolidayPK";
		public const string Holiday = "Holiday";
		public const string Date = "Date";
	}

	public partial class UtilSettingCategoryViewSchema
	{
		public const string UtilSettingCategoryPK = "UtilSettingCategoryPK";
		public const string SettingCategoryID = "SettingCategoryID";
		public const string SettingCategory = "SettingCategory";
		public const string InstanceName = "InstanceName";
	}

	public partial class UtilSettingDetailViewSchema
	{
		public const string UtilSettingDetailPK = "UtilSettingDetailPK";
		public const string UtilSettingCategoryPK = "UtilSettingCategoryPK";
		public const string FieldName = "FieldName";
		public const string SettingCategory = "SettingCategory";
		public const string SettingCategoryID = "SettingCategoryID";
	}

}
