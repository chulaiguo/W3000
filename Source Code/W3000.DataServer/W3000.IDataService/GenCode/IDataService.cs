using System;
using Cheke;
using Cheke.BusinessEntity;
using W3000.Data;

namespace W3000.IDataService
{
	public partial interface IACIntvalHolidayMapDataService
	{
		Result Purge(ACIntvalHolidayMapData entity);
		Result Save(ACIntvalHolidayMapData entity);
		Result Save(ACIntvalHolidayMapDataCollection list);
	}

	public partial interface IACAccessLevelDetailDataService
	{
		Result Purge(ACAccessLevelDetailData entity);
		Result Save(ACAccessLevelDetailData entity);
		Result Save(ACAccessLevelDetailDataCollection list);
	}

	public partial interface IUsrAccountBuildingMapDataService
	{
		Result Purge(UsrAccountBuildingMapData entity);
		Result Save(UsrAccountBuildingMapData entity);
		Result Save(UsrAccountBuildingMapDataCollection list);
	}

	public partial interface IBDBuildingDataService
	{
		Result Purge(BDBuildingData entity);
		Result Save(BDBuildingData entity);
		Result Save(BDBuildingDataCollection list);
	}

	public partial interface IBDTenantDataService
	{
		Result Purge(BDTenantData entity);
		Result Save(BDTenantData entity);
		Result Save(BDTenantDataCollection list);
	}

	public partial interface IUtilSettingCategoryDataService
	{
		Result Purge(UtilSettingCategoryData entity);
		Result Save(UtilSettingCategoryData entity);
		Result Save(UtilSettingCategoryDataCollection list);
	}

	public partial interface IUtilSettingDetailDataService
	{
		Result Purge(UtilSettingDetailData entity);
		Result Save(UtilSettingDetailData entity);
		Result Save(UtilSettingDetailDataCollection list);
	}

	public partial interface IACOutputGroupMainZoneMapDataService
	{
		Result Purge(ACOutputGroupMainZoneMapData entity);
		Result Save(ACOutputGroupMainZoneMapData entity);
		Result Save(ACOutputGroupMainZoneMapDataCollection list);
	}

	public partial interface IACCardHolderDataService
	{
		Result Purge(ACCardHolderData entity);
		Result Save(ACCardHolderData entity);
		Result Save(ACCardHolderDataCollection list);
	}

	public partial interface IACMainZoneDataService
	{
		Result Purge(ACMainZoneData entity);
		Result Save(ACMainZoneData entity);
		Result Save(ACMainZoneDataCollection list);
	}

	public partial interface IACIntervalDataService
	{
		Result Purge(ACIntervalData entity);
		Result Save(ACIntervalData entity);
		Result Save(ACIntervalDataCollection list);
	}

	public partial interface IACPanelHolidayMapDataService
	{
		Result Purge(ACPanelHolidayMapData entity);
		Result Save(ACPanelHolidayMapData entity);
		Result Save(ACPanelHolidayMapDataCollection list);
	}

	public partial interface IACTimecodeDataService
	{
		Result Purge(ACTimecodeData entity);
		Result Save(ACTimecodeData entity);
		Result Save(ACTimecodeDataCollection list);
	}

	public partial interface IACTimecodeIntervalMapDataService
	{
		Result Purge(ACTimecodeIntervalMapData entity);
		Result Save(ACTimecodeIntervalMapData entity);
		Result Save(ACTimecodeIntervalMapDataCollection list);
	}

	public partial interface IACAMFormatDataService
	{
		Result Purge(ACAMFormatData entity);
		Result Save(ACAMFormatData entity);
		Result Save(ACAMFormatDataCollection list);
	}

	public partial interface IBDBuildingHolidayMapDataService
	{
		Result Purge(BDBuildingHolidayMapData entity);
		Result Save(BDBuildingHolidayMapData entity);
		Result Save(BDBuildingHolidayMapDataCollection list);
	}

	public partial interface IACOutputGroupDataService
	{
		Result Purge(ACOutputGroupData entity);
		Result Save(ACOutputGroupData entity);
		Result Save(ACOutputGroupDataCollection list);
	}

	public partial interface IBDTenantHolidayMapDataService
	{
		Result Purge(BDTenantHolidayMapData entity);
		Result Save(BDTenantHolidayMapData entity);
		Result Save(BDTenantHolidayMapDataCollection list);
	}

	public partial interface ILogRowsCountDataService
	{
		Result Purge(LogRowsCountData entity);
		Result Save(LogRowsCountData entity);
		Result Save(LogRowsCountDataCollection list);
	}

	public partial interface IACInputGroupDataService
	{
		Result Purge(ACInputGroupData entity);
		Result Save(ACInputGroupData entity);
		Result Save(ACInputGroupDataCollection list);
	}

	public partial interface IACInputDataService
	{
		Result Purge(ACInputData entity);
		Result Save(ACInputData entity);
		Result Save(ACInputDataCollection list);
	}

	public partial interface IACFunctionCardDataService
	{
		Result Purge(ACFunctionCardData entity);
		Result Save(ACFunctionCardData entity);
		Result Save(ACFunctionCardDataCollection list);
	}

	public partial interface IACAccessLevelDataService
	{
		Result Purge(ACAccessLevelData entity);
		Result Save(ACAccessLevelData entity);
		Result Save(ACAccessLevelDataCollection list);
	}

	public partial interface IACPanelFunctionCardMapDataService
	{
		Result Purge(ACPanelFunctionCardMapData entity);
		Result Save(ACPanelFunctionCardMapData entity);
		Result Save(ACPanelFunctionCardMapDataCollection list);
	}

	public partial interface IUtilHolidayDataService
	{
		Result Purge(UtilHolidayData entity);
		Result Save(UtilHolidayData entity);
		Result Save(UtilHolidayDataCollection list);
	}

	public partial interface ILogDBDeleteActivityDataService
	{
		Result Purge(LogDBDeleteActivityData entity);
		Result Save(LogDBDeleteActivityData entity);
		Result Save(LogDBDeleteActivityDataCollection list);
	}

	public partial interface IUsrAccountDataService
	{
		Result Purge(UsrAccountData entity);
		Result Save(UsrAccountData entity);
		Result Save(UsrAccountDataCollection list);
	}

	public partial interface ILogDBEditActivityDataService
	{
		Result Purge(LogDBEditActivityData entity);
		Result Save(LogDBEditActivityData entity);
		Result Save(LogDBEditActivityDataCollection list);
	}

	public partial interface IACMasterCardDataService
	{
		Result Purge(ACMasterCardData entity);
		Result Save(ACMasterCardData entity);
		Result Save(ACMasterCardDataCollection list);
	}

	public partial interface IACSupervisoryDataService
	{
		Result Purge(ACSupervisoryData entity);
		Result Save(ACSupervisoryData entity);
		Result Save(ACSupervisoryDataCollection list);
	}

	public partial interface IUsrGroupDataService
	{
		Result Purge(UsrGroupData entity);
		Result Save(UsrGroupData entity);
		Result Save(UsrGroupDataCollection list);
	}

	public partial interface IACCardHolderBuildingMapDataService
	{
		Result Purge(ACCardHolderBuildingMapData entity);
		Result Save(ACCardHolderBuildingMapData entity);
		Result Save(ACCardHolderBuildingMapDataCollection list);
	}

	public partial interface IBDVisitorDataService
	{
		Result Purge(BDVisitorData entity);
		Result Save(BDVisitorData entity);
		Result Save(BDVisitorDataCollection list);
	}

	public partial interface IUsrGroupDBRuleDataService
	{
		Result Purge(UsrGroupDBRuleData entity);
		Result Save(UsrGroupDBRuleData entity);
		Result Save(UsrGroupDBRuleDataCollection list);
	}

	public partial interface IACPanelDataService
	{
		Result Purge(ACPanelData entity);
		Result Save(ACPanelData entity);
		Result Save(ACPanelDataCollection list);
	}

	public partial interface IUsrAccountDBRuleDataService
	{
		Result Purge(UsrAccountDBRuleData entity);
		Result Save(UsrAccountDBRuleData entity);
		Result Save(UsrAccountDBRuleDataCollection list);
	}

	public partial interface IUsrGroupBRRuleDataService
	{
		Result Purge(UsrGroupBRRuleData entity);
		Result Save(UsrGroupBRRuleData entity);
		Result Save(UsrGroupBRRuleDataCollection list);
	}

	public partial interface IACInputGroupInputMapDataService
	{
		Result Purge(ACInputGroupInputMapData entity);
		Result Save(ACInputGroupInputMapData entity);
		Result Save(ACInputGroupInputMapDataCollection list);
	}

	public partial interface IUsrAccountBRRuleDataService
	{
		Result Purge(UsrAccountBRRuleData entity);
		Result Save(UsrAccountBRRuleData entity);
		Result Save(UsrAccountBRRuleDataCollection list);
	}

	public partial interface IUsrAccountTenantMapDataService
	{
		Result Purge(UsrAccountTenantMapData entity);
		Result Save(UsrAccountTenantMapData entity);
		Result Save(UsrAccountTenantMapDataCollection list);
	}

}
