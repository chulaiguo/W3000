namespace W3000.IDataService
{
	public partial interface IACCardHolderDataService
	{
		W3000.Data.ACCardHolderDataCollection GetByCriteria(W3000.Data.CriteriaACCardHolderView criteria);
		W3000.Data.ACCardHolderDataCollection GetByCriteria(W3000.Data.CriteriaACCardHolderView criteria, System.Int32 pageIndex, System.Int32 pageSize);
		System.Int32 GetCountByCriteria(W3000.Data.CriteriaACCardHolderView criteria);
		W3000.Data.ACCardHolderDataCollection GetByLikeFirstName(System.String FirstName);
		W3000.Data.ACCardHolderDataCollection GetByLikeLastName(System.String LastName);
		W3000.Data.ACCardHolderDataCollection GetByValidThru(System.DateTime begin, System.DateTime end);
		W3000.Data.ACCardHolderDataCollection GetByModifiedOn(System.DateTime begin, System.DateTime end);
		W3000.Data.ACCardHolderDataCollection GetByMappedBDBuilding(System.Guid BDBuildingPK);
		System.Int32 GetAllCount();
		W3000.Data.ACCardHolderDataCollection GetAllPage(System.Int32 pageIndex, System.Int32 pageSize);
		W3000.Data.ACCardHolderData GetByUK(System.Int32 Sitecode, System.Int32 Embossed, System.Int32 CardTypeID);
		W3000.Data.ACCardHolderData GetByUK1(System.Int32 Sitecode, System.Int32 Encoded, System.Int32 CardTypeID);
		W3000.Data.ACCardHolderData GetByPK(System.Guid ACCardHolderPK);
		W3000.Data.ACCardHolderDataCollection GetAll();
		W3000.Data.ACCardHolderViewCollection GetViewAll();
		W3000.Data.ACCardHolderDataCollection GetByBDTenant(System.Guid BDTenantPK);
		W3000.Data.ACCardHolderViewCollection GetViewByBDTenant(System.Guid BDTenantPK);
	}

	public partial interface IBDBuildingDataService
	{
		W3000.Data.BDBuildingDataCollection GetByCriteria(W3000.Data.CriteriaBDBuildingView criteria);
		W3000.Data.BDBuildingDataCollection GetByCriteria(W3000.Data.CriteriaBDBuildingView criteria, System.Int32 pageIndex, System.Int32 pageSize);
		System.Int32 GetCountByCriteria(W3000.Data.CriteriaBDBuildingView criteria);
		W3000.Data.BDBuildingDataCollection GetBySystemTypeID(System.Int32 SystemTypeID);
		W3000.Data.BDBuildingDataCollection GetByCountryID(System.Int32 CountryID);
		W3000.Data.BDBuildingDataCollection GetByLikeStreetNumb(System.String StreetNumb);
		W3000.Data.BDBuildingDataCollection GetByLikeStreetName(System.String StreetName);
		W3000.Data.BDBuildingDataCollection GetByMappedUsrAccount(System.Guid UsrAccountPK);
		W3000.Data.BDBuildingDataCollection GetByMappedUtilHoliday(System.Guid UtilHolidayPK);
		W3000.Data.BDBuildingDataCollection GetByMappedACCardHolder(System.Guid ACCardHolderPK);
		System.Int32 GetAllCount();
		W3000.Data.BDBuildingDataCollection GetAllPage(System.Int32 pageIndex, System.Int32 pageSize);
		W3000.Data.BDBuildingData GetByAddress1(System.String Address1);
		W3000.Data.BDBuildingData GetByBuildingID(System.Int32 BuildingID);
		W3000.Data.BDBuildingData GetByPK(System.Guid BDBuildingPK);
		W3000.Data.BDBuildingDataCollection GetAll();
		W3000.Data.BDBuildingViewCollection GetViewAll();
	}

	public partial interface IACIntvalHolidayMapDataService
	{
		W3000.Data.ACIntvalHolidayMapDataCollection GetByModifiedOn(System.DateTime begin, System.DateTime end);
		System.Int32 GetAllCount();
		W3000.Data.ACIntvalHolidayMapDataCollection GetAllPage(System.Int32 pageIndex, System.Int32 pageSize);
		W3000.Data.ACIntvalHolidayMapData GetByUK(System.Guid ACIntervalPK, System.Guid UtilHolidayPK);
		W3000.Data.ACIntvalHolidayMapData GetByPK(System.Guid ACIntvalHolidayMapPK);
		W3000.Data.ACIntvalHolidayMapDataCollection GetAll();
		W3000.Data.ACIntvalHolidayMapViewCollection GetViewAll();
		W3000.Data.ACIntvalHolidayMapDataCollection GetByACInterval(System.Guid ACIntervalPK);
		W3000.Data.ACIntvalHolidayMapViewCollection GetViewByACInterval(System.Guid ACIntervalPK);
		W3000.Data.ACIntvalHolidayMapDataCollection GetByUtilHoliday(System.Guid UtilHolidayPK);
		W3000.Data.ACIntvalHolidayMapViewCollection GetViewByUtilHoliday(System.Guid UtilHolidayPK);
	}

	public partial interface IACAccessLevelDetailDataService
	{
		W3000.Data.ACAccessLevelDetailDataCollection GetByModifiedOn(System.DateTime begin, System.DateTime end);
		System.Int32 GetAllCount();
		W3000.Data.ACAccessLevelDetailDataCollection GetAllPage(System.Int32 pageIndex, System.Int32 pageSize);
		W3000.Data.ACAccessLevelDetailData GetByUK(System.Guid ACAccessLevelPK, System.Guid ACMainZonePK);
		W3000.Data.ACAccessLevelDetailData GetByPK(System.Guid ACAccessLevelDetailPK);
		W3000.Data.ACAccessLevelDetailDataCollection GetAll();
		W3000.Data.ACAccessLevelDetailViewCollection GetViewAll();
		W3000.Data.ACAccessLevelDetailDataCollection GetByACMainZone(System.Guid ACMainZonePK);
		W3000.Data.ACAccessLevelDetailViewCollection GetViewByACMainZone(System.Guid ACMainZonePK);
		W3000.Data.ACAccessLevelDetailDataCollection GetByACTimecode(System.Guid ACTimecodePK);
		W3000.Data.ACAccessLevelDetailViewCollection GetViewByACTimecode(System.Guid ACTimecodePK);
		W3000.Data.ACAccessLevelDetailDataCollection GetByACAccessLevel(System.Guid ACAccessLevelPK);
		W3000.Data.ACAccessLevelDetailViewCollection GetViewByACAccessLevel(System.Guid ACAccessLevelPK);
	}

	public partial interface IUsrAccountBuildingMapDataService
	{
		W3000.Data.UsrAccountBuildingMapDataCollection GetByModifiedOn(System.DateTime begin, System.DateTime end);
		System.Int32 GetAllCount();
		W3000.Data.UsrAccountBuildingMapDataCollection GetAllPage(System.Int32 pageIndex, System.Int32 pageSize);
		W3000.Data.UsrAccountBuildingMapData GetByUK(System.Guid UsrAccountPK, System.Guid BDBuildingPK);
		W3000.Data.UsrAccountBuildingMapData GetByPK(System.Guid UsrAccountBuildingMapPK);
		W3000.Data.UsrAccountBuildingMapDataCollection GetAll();
		W3000.Data.UsrAccountBuildingMapViewCollection GetViewAll();
		W3000.Data.UsrAccountBuildingMapDataCollection GetByBDBuilding(System.Guid BDBuildingPK);
		W3000.Data.UsrAccountBuildingMapViewCollection GetViewByBDBuilding(System.Guid BDBuildingPK);
		W3000.Data.UsrAccountBuildingMapDataCollection GetByUsrAccount(System.Guid UsrAccountPK);
		W3000.Data.UsrAccountBuildingMapViewCollection GetViewByUsrAccount(System.Guid UsrAccountPK);
	}

	public partial interface IBDTenantDataService
	{
		W3000.Data.BDTenantDataCollection GetBySystemTypeID(System.Int32 SystemTypeID);
		W3000.Data.BDTenantDataCollection GetByModifiedOn(System.DateTime begin, System.DateTime end);
		W3000.Data.BDTenantDataCollection GetByMappedUsrAccount(System.Guid UsrAccountPK);
		W3000.Data.BDTenantDataCollection GetByMappedUtilHoliday(System.Guid UtilHolidayPK);
		System.Int32 GetAllCount();
		W3000.Data.BDTenantDataCollection GetAllPage(System.Int32 pageIndex, System.Int32 pageSize);
		W3000.Data.BDTenantData GetByUK(System.Guid BDBuildingPK, System.String Tenant);
		W3000.Data.BDTenantData GetByPK(System.Guid BDTenantPK);
		W3000.Data.BDTenantDataCollection GetAll();
		W3000.Data.BDTenantViewCollection GetViewAll();
		W3000.Data.BDTenantDataCollection GetByBDBuilding(System.Guid BDBuildingPK);
		W3000.Data.BDTenantViewCollection GetViewByBDBuilding(System.Guid BDBuildingPK);
	}

	public partial interface IUtilSettingCategoryDataService
	{
		W3000.Data.UtilSettingCategoryDataCollection GetBySettingCategoryID(System.Int32 SettingCategoryID);
		W3000.Data.UtilSettingCategoryDataCollection GetByModifiedOn(System.DateTime begin, System.DateTime end);
		System.Int32 GetAllCount();
		W3000.Data.UtilSettingCategoryDataCollection GetAllPage(System.Int32 pageIndex, System.Int32 pageSize);
		W3000.Data.UtilSettingCategoryData GetByUK(System.Int32 SettingCategoryID, System.String InstanceName);
		W3000.Data.UtilSettingCategoryData GetByPK(System.Guid UtilSettingCategoryPK);
		W3000.Data.UtilSettingCategoryDataCollection GetAll();
		W3000.Data.UtilSettingCategoryViewCollection GetViewAll();
	}

	public partial interface IUtilSettingDetailDataService
	{
		W3000.Data.UtilSettingDetailDataCollection GetByModifiedOn(System.DateTime begin, System.DateTime end);
		System.Int32 GetAllCount();
		W3000.Data.UtilSettingDetailDataCollection GetAllPage(System.Int32 pageIndex, System.Int32 pageSize);
		W3000.Data.UtilSettingDetailData GetByUK(System.Guid UtilSettingCategoryPK, System.String FieldName);
		W3000.Data.UtilSettingDetailData GetByPK(System.Guid UtilSettingDetailPK);
		W3000.Data.UtilSettingDetailDataCollection GetAll();
		W3000.Data.UtilSettingDetailViewCollection GetViewAll();
		W3000.Data.UtilSettingDetailDataCollection GetByUtilSettingCategory(System.Guid UtilSettingCategoryPK);
		W3000.Data.UtilSettingDetailViewCollection GetViewByUtilSettingCategory(System.Guid UtilSettingCategoryPK);
	}

	public partial interface IACOutputGroupMainZoneMapDataService
	{
		W3000.Data.ACOutputGroupMainZoneMapDataCollection GetByModifiedOn(System.DateTime begin, System.DateTime end);
		System.Int32 GetAllCount();
		W3000.Data.ACOutputGroupMainZoneMapDataCollection GetAllPage(System.Int32 pageIndex, System.Int32 pageSize);
		W3000.Data.ACOutputGroupMainZoneMapData GetByUK(System.Guid ACOutputGroupPK, System.Guid ACMainZonePK);
		W3000.Data.ACOutputGroupMainZoneMapData GetByPK(System.Guid ACOutputGroupMainZoneMapPK);
		W3000.Data.ACOutputGroupMainZoneMapDataCollection GetAll();
		W3000.Data.ACOutputGroupMainZoneMapViewCollection GetViewAll();
		W3000.Data.ACOutputGroupMainZoneMapDataCollection GetByACMainZone(System.Guid ACMainZonePK);
		W3000.Data.ACOutputGroupMainZoneMapViewCollection GetViewByACMainZone(System.Guid ACMainZonePK);
		W3000.Data.ACOutputGroupMainZoneMapDataCollection GetByACOutputGroup(System.Guid ACOutputGroupPK);
		W3000.Data.ACOutputGroupMainZoneMapViewCollection GetViewByACOutputGroup(System.Guid ACOutputGroupPK);
	}

	public partial interface IACMainZoneDataService
	{
		W3000.Data.ACMainZoneDataCollection GetByReaderTypeID(System.Int32 ReaderTypeID);
		W3000.Data.ACMainZoneDataCollection GetByMainZoneTypeID(System.Int32 MainZoneTypeID);
		W3000.Data.ACMainZoneDataCollection GetByModifiedOn(System.DateTime begin, System.DateTime end);
		W3000.Data.ACMainZoneDataCollection GetByMappedACOutputGroup(System.Guid ACOutputGroupPK);
		W3000.Data.ACMainZoneDataCollection GetByMappedACTimecode(System.Guid ACTimecodePK);
		System.Int32 GetAllCount();
		W3000.Data.ACMainZoneDataCollection GetAllPage(System.Int32 pageIndex, System.Int32 pageSize);
		W3000.Data.ACMainZoneData GetByUK(System.Guid ACPanelPK, System.Byte PanelZoneID);
		W3000.Data.ACMainZoneData GetByPK(System.Guid ACMainZonePK);
		W3000.Data.ACMainZoneDataCollection GetAll();
		W3000.Data.ACMainZoneViewCollection GetViewAll();
		W3000.Data.ACMainZoneDataCollection GetByACPanel(System.Guid ACPanelPK);
		W3000.Data.ACMainZoneViewCollection GetViewByACPanel(System.Guid ACPanelPK);
	}

	public partial interface IACIntervalDataService
	{
		W3000.Data.ACIntervalDataCollection GetByModifiedOn(System.DateTime begin, System.DateTime end);
		W3000.Data.ACIntervalDataCollection GetByMappedUtilHoliday(System.Guid UtilHolidayPK);
		W3000.Data.ACIntervalDataCollection GetByMappedACTimecode(System.Guid ACTimecodePK);
		System.Int32 GetAllCount();
		W3000.Data.ACIntervalDataCollection GetAllPage(System.Int32 pageIndex, System.Int32 pageSize);
		W3000.Data.ACIntervalData GetByUK(System.Guid BDBuildingPK, System.Int16 IVID);
		W3000.Data.ACIntervalData GetByPK(System.Guid ACIntervalPK);
		W3000.Data.ACIntervalDataCollection GetAll();
		W3000.Data.ACIntervalViewCollection GetViewAll();
		W3000.Data.ACIntervalDataCollection GetByBDBuilding(System.Guid BDBuildingPK);
		W3000.Data.ACIntervalViewCollection GetViewByBDBuilding(System.Guid BDBuildingPK);
	}

	public partial interface IACPanelHolidayMapDataService
	{
		W3000.Data.ACPanelHolidayMapDataCollection GetByModifiedOn(System.DateTime begin, System.DateTime end);
		System.Int32 GetAllCount();
		W3000.Data.ACPanelHolidayMapDataCollection GetAllPage(System.Int32 pageIndex, System.Int32 pageSize);
		W3000.Data.ACPanelHolidayMapData GetByUK(System.Guid ACPanelPK, System.Guid UtilHolidayPK);
		W3000.Data.ACPanelHolidayMapData GetByPK(System.Guid ACPanelHolidayMapPK);
		W3000.Data.ACPanelHolidayMapDataCollection GetAll();
		W3000.Data.ACPanelHolidayMapViewCollection GetViewAll();
		W3000.Data.ACPanelHolidayMapDataCollection GetByUtilHoliday(System.Guid UtilHolidayPK);
		W3000.Data.ACPanelHolidayMapViewCollection GetViewByUtilHoliday(System.Guid UtilHolidayPK);
		W3000.Data.ACPanelHolidayMapDataCollection GetByACPanel(System.Guid ACPanelPK);
		W3000.Data.ACPanelHolidayMapViewCollection GetViewByACPanel(System.Guid ACPanelPK);
	}

	public partial interface IACTimecodeDataService
	{
		W3000.Data.ACTimecodeDataCollection GetByModifiedOn(System.DateTime begin, System.DateTime end);
		W3000.Data.ACTimecodeDataCollection GetByMappedACMainZone(System.Guid ACMainZonePK);
		W3000.Data.ACTimecodeDataCollection GetByMappedACInterval(System.Guid ACIntervalPK);
		System.Int32 GetAllCount();
		W3000.Data.ACTimecodeDataCollection GetAllPage(System.Int32 pageIndex, System.Int32 pageSize);
		W3000.Data.ACTimecodeData GetByUK(System.Guid BDBuildingPK, System.Int16 TCID);
		W3000.Data.ACTimecodeData GetByPK(System.Guid ACTimecodePK);
		W3000.Data.ACTimecodeDataCollection GetAll();
		W3000.Data.ACTimecodeViewCollection GetViewAll();
		W3000.Data.ACTimecodeDataCollection GetByBDBuilding(System.Guid BDBuildingPK);
		W3000.Data.ACTimecodeViewCollection GetViewByBDBuilding(System.Guid BDBuildingPK);
	}

	public partial interface IACTimecodeIntervalMapDataService
	{
		W3000.Data.ACTimecodeIntervalMapDataCollection GetByModifiedOn(System.DateTime begin, System.DateTime end);
		System.Int32 GetAllCount();
		W3000.Data.ACTimecodeIntervalMapDataCollection GetAllPage(System.Int32 pageIndex, System.Int32 pageSize);
		W3000.Data.ACTimecodeIntervalMapData GetByUK(System.Guid ACTimecodePK, System.Guid ACIntervalPK);
		W3000.Data.ACTimecodeIntervalMapData GetByPK(System.Guid ACTimecodeIntervalMapPK);
		W3000.Data.ACTimecodeIntervalMapDataCollection GetAll();
		W3000.Data.ACTimecodeIntervalMapViewCollection GetViewAll();
		W3000.Data.ACTimecodeIntervalMapDataCollection GetByACInterval(System.Guid ACIntervalPK);
		W3000.Data.ACTimecodeIntervalMapViewCollection GetViewByACInterval(System.Guid ACIntervalPK);
		W3000.Data.ACTimecodeIntervalMapDataCollection GetByACTimecode(System.Guid ACTimecodePK);
		W3000.Data.ACTimecodeIntervalMapViewCollection GetViewByACTimecode(System.Guid ACTimecodePK);
	}

	public partial interface IACAMFormatDataService
	{
		W3000.Data.ACAMFormatDataCollection GetByModifiedOn(System.DateTime begin, System.DateTime end);
		System.Int32 GetAllCount();
		W3000.Data.ACAMFormatDataCollection GetAllPage(System.Int32 pageIndex, System.Int32 pageSize);
		W3000.Data.ACAMFormatData GetByUK(System.Guid BDBuildingPK, System.Int16 AMFID);
		W3000.Data.ACAMFormatData GetByPK(System.Guid ACAMFormatPK);
		W3000.Data.ACAMFormatDataCollection GetAll();
		W3000.Data.ACAMFormatViewCollection GetViewAll();
		W3000.Data.ACAMFormatDataCollection GetByBDBuilding(System.Guid BDBuildingPK);
		W3000.Data.ACAMFormatViewCollection GetViewByBDBuilding(System.Guid BDBuildingPK);
	}

	public partial interface IACOutputGroupDataService
	{
		W3000.Data.ACOutputGroupDataCollection GetByModifiedOn(System.DateTime begin, System.DateTime end);
		W3000.Data.ACOutputGroupDataCollection GetByMappedACMainZone(System.Guid ACMainZonePK);
		System.Int32 GetAllCount();
		W3000.Data.ACOutputGroupDataCollection GetAllPage(System.Int32 pageIndex, System.Int32 pageSize);
		W3000.Data.ACOutputGroupData GetByUK(System.Guid ACPanelPK, System.Byte GroupID);
		W3000.Data.ACOutputGroupData GetByPK(System.Guid ACOutputGroupPK);
		W3000.Data.ACOutputGroupDataCollection GetAll();
		W3000.Data.ACOutputGroupViewCollection GetViewAll();
		W3000.Data.ACOutputGroupDataCollection GetByACPanel(System.Guid ACPanelPK);
		W3000.Data.ACOutputGroupViewCollection GetViewByACPanel(System.Guid ACPanelPK);
	}

	public partial interface ILogRowsCountDataService
	{
		W3000.Data.LogRowsCountDataCollection GetBySessionDateTime(System.DateTime begin, System.DateTime end);
		W3000.Data.LogRowsCountDataCollection GetBySessionID(System.Guid SessionID);
		System.Int32 DeleteBySessionDateTime(System.DateTime begin, System.DateTime end);
		W3000.Data.LogRowsCountData GetByPK(System.Guid LogRowsCountPK);
		W3000.Data.LogRowsCountDataCollection GetAll();
		W3000.Data.LogRowsCountViewCollection GetViewAll();
	}

	public partial interface IACInputGroupDataService
	{
		W3000.Data.ACInputGroupDataCollection GetByModifiedOn(System.DateTime begin, System.DateTime end);
		W3000.Data.ACInputGroupDataCollection GetByMappedACInput(System.Guid ACInputPK);
		System.Int32 GetAllCount();
		W3000.Data.ACInputGroupDataCollection GetAllPage(System.Int32 pageIndex, System.Int32 pageSize);
		W3000.Data.ACInputGroupData GetByUK(System.Guid ACPanelPK, System.Byte GroupID);
		W3000.Data.ACInputGroupData GetByPK(System.Guid ACInputGroupPK);
		W3000.Data.ACInputGroupDataCollection GetAll();
		W3000.Data.ACInputGroupViewCollection GetViewAll();
		W3000.Data.ACInputGroupDataCollection GetByACPanel(System.Guid ACPanelPK);
		W3000.Data.ACInputGroupViewCollection GetViewByACPanel(System.Guid ACPanelPK);
	}

	public partial interface IACInputDataService
	{
		W3000.Data.ACInputDataCollection GetByModifiedOn(System.DateTime begin, System.DateTime end);
		W3000.Data.ACInputDataCollection GetByMappedACInputGroup(System.Guid ACInputGroupPK);
		System.Int32 GetAllCount();
		W3000.Data.ACInputDataCollection GetAllPage(System.Int32 pageIndex, System.Int32 pageSize);
		W3000.Data.ACInputData GetByUK(System.Guid ACPanelPK, System.Byte PanelZoneID);
		W3000.Data.ACInputData GetByPK(System.Guid ACInputPK);
		W3000.Data.ACInputDataCollection GetAll();
		W3000.Data.ACInputViewCollection GetViewAll();
		W3000.Data.ACInputDataCollection GetByACPanel(System.Guid ACPanelPK);
		W3000.Data.ACInputViewCollection GetViewByACPanel(System.Guid ACPanelPK);
	}

	public partial interface IACFunctionCardDataService
	{
		W3000.Data.ACFunctionCardDataCollection GetByLikeFirstName(System.String FirstName);
		W3000.Data.ACFunctionCardDataCollection GetByLikeLastName(System.String LastName);
		W3000.Data.ACFunctionCardDataCollection GetByCardTypeID(System.Int32 CardTypeID);
		W3000.Data.ACFunctionCardDataCollection GetByModifiedOn(System.DateTime begin, System.DateTime end);
		W3000.Data.ACFunctionCardDataCollection GetByMappedACPanel(System.Guid ACPanelPK);
		System.Int32 GetAllCount();
		W3000.Data.ACFunctionCardDataCollection GetAllPage(System.Int32 pageIndex, System.Int32 pageSize);
		W3000.Data.ACFunctionCardData GetByUK(System.Int32 Sitecode, System.Int32 Embossed, System.Int32 CardTypeID);
		W3000.Data.ACFunctionCardData GetByUK1(System.Int32 Sitecode, System.Int32 Encoded, System.Int32 CardTypeID);
		W3000.Data.ACFunctionCardData GetByPK(System.Guid ACFunctionCardPK);
		W3000.Data.ACFunctionCardDataCollection GetAll();
		W3000.Data.ACFunctionCardViewCollection GetViewAll();
		W3000.Data.ACFunctionCardDataCollection GetByBDTenant(System.Guid BDTenantPK);
		W3000.Data.ACFunctionCardViewCollection GetViewByBDTenant(System.Guid BDTenantPK);
	}

	public partial interface IACAccessLevelDataService
	{
		W3000.Data.ACAccessLevelDataCollection GetByModifiedOn(System.DateTime begin, System.DateTime end);
		W3000.Data.ACAccessLevelDataCollection GetByMappedACMainZone(System.Guid ACMainZonePK);
		System.Int32 GetAllCount();
		W3000.Data.ACAccessLevelDataCollection GetAllPage(System.Int32 pageIndex, System.Int32 pageSize);
		W3000.Data.ACAccessLevelData GetByUK(System.Guid BDBuildingPK, System.Int16 AccessLevelID);
		W3000.Data.ACAccessLevelData GetByPK(System.Guid ACAccessLevelPK);
		W3000.Data.ACAccessLevelDataCollection GetAll();
		W3000.Data.ACAccessLevelViewCollection GetViewAll();
		W3000.Data.ACAccessLevelDataCollection GetByBDBuilding(System.Guid BDBuildingPK);
		W3000.Data.ACAccessLevelViewCollection GetViewByBDBuilding(System.Guid BDBuildingPK);
	}

	public partial interface IACPanelFunctionCardMapDataService
	{
		W3000.Data.ACPanelFunctionCardMapDataCollection GetByModifiedOn(System.DateTime begin, System.DateTime end);
		System.Int32 GetAllCount();
		W3000.Data.ACPanelFunctionCardMapDataCollection GetAllPage(System.Int32 pageIndex, System.Int32 pageSize);
		W3000.Data.ACPanelFunctionCardMapData GetByUK(System.Guid ACPanelPK, System.Guid ACFunctionCardPK);
		W3000.Data.ACPanelFunctionCardMapData GetByPK(System.Guid ACPanelFunctionCardMapPK);
		W3000.Data.ACPanelFunctionCardMapDataCollection GetAll();
		W3000.Data.ACPanelFunctionCardMapViewCollection GetViewAll();
		W3000.Data.ACPanelFunctionCardMapDataCollection GetByACFunctionCard(System.Guid ACFunctionCardPK);
		W3000.Data.ACPanelFunctionCardMapViewCollection GetViewByACFunctionCard(System.Guid ACFunctionCardPK);
		W3000.Data.ACPanelFunctionCardMapDataCollection GetByACPanel(System.Guid ACPanelPK);
		W3000.Data.ACPanelFunctionCardMapViewCollection GetViewByACPanel(System.Guid ACPanelPK);
	}

	public partial interface IUtilHolidayDataService
	{
		W3000.Data.UtilHolidayDataCollection GetByCountryID(System.Int32 CountryID);
		W3000.Data.UtilHolidayDataCollection GetByModifiedOn(System.DateTime begin, System.DateTime end);
		W3000.Data.UtilHolidayDataCollection GetByMappedACInterval(System.Guid ACIntervalPK);
		W3000.Data.UtilHolidayDataCollection GetByMappedACPanel(System.Guid ACPanelPK);
		W3000.Data.UtilHolidayDataCollection GetByMappedBDBuilding(System.Guid BDBuildingPK);
		W3000.Data.UtilHolidayDataCollection GetByMappedBDTenant(System.Guid BDTenantPK);
		System.Int32 GetAllCount();
		W3000.Data.UtilHolidayDataCollection GetAllPage(System.Int32 pageIndex, System.Int32 pageSize);
		W3000.Data.UtilHolidayData GetByUK(System.Int32 CountryID, System.String Holiday);
		W3000.Data.UtilHolidayData GetByUK1(System.DateTime Date, System.Int32 CountryID);
		W3000.Data.UtilHolidayData GetByPK(System.Guid UtilHolidayPK);
		W3000.Data.UtilHolidayDataCollection GetAll();
		W3000.Data.UtilHolidayViewCollection GetViewAll();
	}

	public partial interface IACMasterCardDataService
	{
		W3000.Data.ACMasterCardDataCollection GetByCardTypeID(System.Int32 CardTypeID);
		W3000.Data.ACMasterCardDataCollection GetByLikeFirstName(System.String FirstName);
		W3000.Data.ACMasterCardDataCollection GetByLikeLastName(System.String LastName);
		W3000.Data.ACMasterCardDataCollection GetByModifiedOn(System.DateTime begin, System.DateTime end);
		System.Int32 GetAllCount();
		W3000.Data.ACMasterCardDataCollection GetAllPage(System.Int32 pageIndex, System.Int32 pageSize);
		W3000.Data.ACMasterCardData GetByUK(System.Int32 Sitecode, System.Int32 Embossed, System.Int32 CardTypeID);
		W3000.Data.ACMasterCardData GetByUK1(System.Int32 Sitecode, System.Int32 Encoded, System.Int32 CardTypeID);
		W3000.Data.ACMasterCardData GetByPK(System.Guid ACMasterCardPK);
		W3000.Data.ACMasterCardDataCollection GetAll();
		W3000.Data.ACMasterCardViewCollection GetViewAll();
	}

	public partial interface IACSupervisoryDataService
	{
		W3000.Data.ACSupervisoryDataCollection GetByModifiedOn(System.DateTime begin, System.DateTime end);
		System.Int32 GetAllCount();
		W3000.Data.ACSupervisoryDataCollection GetAllPage(System.Int32 pageIndex, System.Int32 pageSize);
		W3000.Data.ACSupervisoryData GetByUK(System.Guid ACPanelPK, System.Byte PanelZoneID);
		W3000.Data.ACSupervisoryData GetByPK(System.Guid ACSupervisoryPK);
		W3000.Data.ACSupervisoryDataCollection GetAll();
		W3000.Data.ACSupervisoryViewCollection GetViewAll();
		W3000.Data.ACSupervisoryDataCollection GetByACPanel(System.Guid ACPanelPK);
		W3000.Data.ACSupervisoryViewCollection GetViewByACPanel(System.Guid ACPanelPK);
	}

	public partial interface IACCardHolderBuildingMapDataService
	{
		W3000.Data.ACCardHolderBuildingMapDataCollection GetByModifiedOn(System.DateTime begin, System.DateTime end);
		System.Int32 GetAllCount();
		W3000.Data.ACCardHolderBuildingMapDataCollection GetAllPage(System.Int32 pageIndex, System.Int32 pageSize);
		W3000.Data.ACCardHolderBuildingMapData GetByUK(System.Guid ACCardHolderPK, System.Guid BDBuildingPK);
		W3000.Data.ACCardHolderBuildingMapData GetByPK(System.Guid ACCardHolderBuildingMapPK);
		W3000.Data.ACCardHolderBuildingMapDataCollection GetAll();
		W3000.Data.ACCardHolderBuildingMapViewCollection GetViewAll();
		W3000.Data.ACCardHolderBuildingMapDataCollection GetByBDBuilding(System.Guid BDBuildingPK);
		W3000.Data.ACCardHolderBuildingMapViewCollection GetViewByBDBuilding(System.Guid BDBuildingPK);
		W3000.Data.ACCardHolderBuildingMapDataCollection GetByACCardHolder(System.Guid ACCardHolderPK);
		W3000.Data.ACCardHolderBuildingMapViewCollection GetViewByACCardHolder(System.Guid ACCardHolderPK);
	}

	public partial interface IBDVisitorDataService
	{
		W3000.Data.BDVisitorDataCollection GetByValidThru(System.DateTime begin, System.DateTime end);
		W3000.Data.BDVisitorDataCollection GetByLikeLastName(System.String LastName);
		W3000.Data.BDVisitorDataCollection GetByModifiedOn(System.DateTime begin, System.DateTime end);
		System.Int32 GetAllCount();
		W3000.Data.BDVisitorDataCollection GetAllPage(System.Int32 pageIndex, System.Int32 pageSize);
		W3000.Data.BDVisitorData GetByPK(System.Guid BDVisitorPK);
		W3000.Data.BDVisitorDataCollection GetAll();
		W3000.Data.BDVisitorViewCollection GetViewAll();
		W3000.Data.BDVisitorDataCollection GetByBDTenant(System.Guid BDTenantPK);
		W3000.Data.BDVisitorViewCollection GetViewByBDTenant(System.Guid BDTenantPK);
	}

	public partial interface IUsrGroupDBRuleDataService
	{
		W3000.Data.UsrGroupDBRuleDataCollection GetByDBRuleID(System.Int32 DBRuleID);
		System.Int32 GetAllCount();
		W3000.Data.UsrGroupDBRuleDataCollection GetAllPage(System.Int32 pageIndex, System.Int32 pageSize);
		W3000.Data.UsrGroupDBRuleData GetByUK(System.Guid UsrGroupPK, System.Int32 DBRuleID);
		W3000.Data.UsrGroupDBRuleData GetByPK(System.Guid UsrGroupDBRulePK);
		W3000.Data.UsrGroupDBRuleDataCollection GetAll();
		W3000.Data.UsrGroupDBRuleViewCollection GetViewAll();
		W3000.Data.UsrGroupDBRuleDataCollection GetByUsrGroup(System.Guid UsrGroupPK);
		W3000.Data.UsrGroupDBRuleViewCollection GetViewByUsrGroup(System.Guid UsrGroupPK);
	}

	public partial interface IACPanelDataService
	{
		W3000.Data.ACPanelDataCollection GetByPanelTypeID(System.Int32 PanelTypeID);
		W3000.Data.ACPanelDataCollection GetByLikeUnitPhone(System.String UnitPhone);
		W3000.Data.ACPanelDataCollection GetByLikeUnitPhoneCallerID(System.String UnitPhoneCallerID);
		W3000.Data.ACPanelDataCollection GetByModifiedOn(System.DateTime begin, System.DateTime end);
		W3000.Data.ACPanelDataCollection GetByMappedUtilHoliday(System.Guid UtilHolidayPK);
		W3000.Data.ACPanelDataCollection GetByMappedACFunctionCard(System.Guid ACFunctionCardPK);
		System.Int32 GetAllCount();
		W3000.Data.ACPanelDataCollection GetAllPage(System.Int32 pageIndex, System.Int32 pageSize);
		W3000.Data.ACPanelData GetByUnitID(System.Int32 UnitID);
		W3000.Data.ACPanelData GetByPK(System.Guid ACPanelPK);
		W3000.Data.ACPanelDataCollection GetAll();
		W3000.Data.ACPanelViewCollection GetViewAll();
		W3000.Data.ACPanelDataCollection GetByBDBuilding(System.Guid BDBuildingPK);
		W3000.Data.ACPanelViewCollection GetViewByBDBuilding(System.Guid BDBuildingPK);
	}

	public partial interface IUsrAccountDBRuleDataService
	{
		W3000.Data.UsrAccountDBRuleDataCollection GetByDBRuleID(System.Int32 DBRuleID);
		System.Int32 GetAllCount();
		W3000.Data.UsrAccountDBRuleDataCollection GetAllPage(System.Int32 pageIndex, System.Int32 pageSize);
		W3000.Data.UsrAccountDBRuleData GetByUK(System.Guid UsrAccountPK, System.Int32 DBRuleID);
		W3000.Data.UsrAccountDBRuleData GetByPK(System.Guid UsrAccountDBRulePK);
		W3000.Data.UsrAccountDBRuleDataCollection GetAll();
		W3000.Data.UsrAccountDBRuleViewCollection GetViewAll();
		W3000.Data.UsrAccountDBRuleDataCollection GetByUsrAccount(System.Guid UsrAccountPK);
		W3000.Data.UsrAccountDBRuleViewCollection GetViewByUsrAccount(System.Guid UsrAccountPK);
	}

	public partial interface IUsrGroupBRRuleDataService
	{
		W3000.Data.UsrGroupBRRuleDataCollection GetByBRRuleID(System.Int32 BRRuleID);
		System.Int32 GetAllCount();
		W3000.Data.UsrGroupBRRuleDataCollection GetAllPage(System.Int32 pageIndex, System.Int32 pageSize);
		W3000.Data.UsrGroupBRRuleData GetByUK(System.Guid UsrGroupPK, System.Int32 BRRuleID);
		W3000.Data.UsrGroupBRRuleData GetByBRRuleID(System.Int32 BRRuleID, System.String UsrGroupName);
		W3000.Data.UsrGroupBRRuleData GetByBRRuleID(System.Int32 BRRuleID, System.Guid UsrGroupPK);
		W3000.Data.UsrGroupBRRuleData GetByPK(System.Guid UsrGroupBRRule);
		W3000.Data.UsrGroupBRRuleDataCollection GetAll();
		W3000.Data.UsrGroupBRRuleViewCollection GetViewAll();
		W3000.Data.UsrGroupBRRuleDataCollection GetByUsrGroup(System.Guid UsrGroupPK);
		W3000.Data.UsrGroupBRRuleViewCollection GetViewByUsrGroup(System.Guid UsrGroupPK);
	}

	public partial interface IACInputGroupInputMapDataService
	{
		W3000.Data.ACInputGroupInputMapDataCollection GetByModifiedOn(System.DateTime begin, System.DateTime end);
		System.Int32 GetAllCount();
		W3000.Data.ACInputGroupInputMapDataCollection GetAllPage(System.Int32 pageIndex, System.Int32 pageSize);
		W3000.Data.ACInputGroupInputMapData GetByUK(System.Guid ACInputGroupPK, System.Guid ACInputPK);
		W3000.Data.ACInputGroupInputMapData GetByPK(System.Guid ACInputGroupInputMapPK);
		W3000.Data.ACInputGroupInputMapDataCollection GetAll();
		W3000.Data.ACInputGroupInputMapViewCollection GetViewAll();
		W3000.Data.ACInputGroupInputMapDataCollection GetByACInputGroup(System.Guid ACInputGroupPK);
		W3000.Data.ACInputGroupInputMapViewCollection GetViewByACInputGroup(System.Guid ACInputGroupPK);
		W3000.Data.ACInputGroupInputMapDataCollection GetByACInput(System.Guid ACInputPK);
		W3000.Data.ACInputGroupInputMapViewCollection GetViewByACInput(System.Guid ACInputPK);
	}

	public partial interface IUsrAccountBRRuleDataService
	{
		W3000.Data.UsrAccountBRRuleDataCollection GetByBRRuleID(System.Int32 BRRuleID);
		System.Int32 GetAllCount();
		W3000.Data.UsrAccountBRRuleDataCollection GetAllPage(System.Int32 pageIndex, System.Int32 pageSize);
		W3000.Data.UsrAccountBRRuleData GetByUK(System.Guid UsrAccountPK, System.Int32 BRRuleID);
		W3000.Data.UsrAccountBRRuleData GetByBRRuleID(System.Int32 BRRuleID, System.String userID);
		W3000.Data.UsrAccountBRRuleData GetByBRRuleID(System.Int32 BRRuleID, System.Guid UsrAccountPK);
		W3000.Data.UsrAccountBRRuleData GetByPK(System.Guid UsrAccountBRRulePK);
		W3000.Data.UsrAccountBRRuleDataCollection GetAll();
		W3000.Data.UsrAccountBRRuleViewCollection GetViewAll();
		W3000.Data.UsrAccountBRRuleDataCollection GetByUsrAccount(System.Guid UsrAccountPK);
		W3000.Data.UsrAccountBRRuleViewCollection GetViewByUsrAccount(System.Guid UsrAccountPK);
	}

	public partial interface IUsrAccountTenantMapDataService
	{
		W3000.Data.UsrAccountTenantMapDataCollection GetByModifiedOn(System.DateTime begin, System.DateTime end);
		System.Int32 GetAllCount();
		W3000.Data.UsrAccountTenantMapDataCollection GetAllPage(System.Int32 pageIndex, System.Int32 pageSize);
		W3000.Data.UsrAccountTenantMapData GetByUK(System.Guid UsrAccountPK, System.Guid BDTenantPK);
		W3000.Data.UsrAccountTenantMapData GetByPK(System.Guid UsrAccountTenantMapPK);
		W3000.Data.UsrAccountTenantMapDataCollection GetAll();
		W3000.Data.UsrAccountTenantMapViewCollection GetViewAll();
		W3000.Data.UsrAccountTenantMapDataCollection GetByBDTenant(System.Guid BDTenantPK);
		W3000.Data.UsrAccountTenantMapViewCollection GetViewByBDTenant(System.Guid BDTenantPK);
		W3000.Data.UsrAccountTenantMapDataCollection GetByUsrAccount(System.Guid UsrAccountPK);
		W3000.Data.UsrAccountTenantMapViewCollection GetViewByUsrAccount(System.Guid UsrAccountPK);
	}

	public partial interface IUsrAccountDataService
	{
		W3000.Data.UsrAccountDataCollection GetByMappedBDBuilding(System.Guid BDBuildingPK);
		W3000.Data.UsrAccountDataCollection GetByMappedBDTenant(System.Guid BDTenantPK);
		System.Int32 GetAllCount();
		W3000.Data.UsrAccountDataCollection GetAllPage(System.Int32 pageIndex, System.Int32 pageSize);
		W3000.Data.UsrAccountData GetByUserID(System.String UserID);
		W3000.Data.UsrAccountDataCollection GetByUsrGroupName(System.String UsrGroupName);
		W3000.Data.UsrAccountDataCollection GetCentralUser();
		W3000.Data.UsrAccountDataCollection GetWebUser();
		W3000.Data.UsrAccountDataCollection GetByModifiedOn(System.Boolean IsCentral, System.DateTime begin, System.DateTime end);
		System.Boolean IsTableExist(System.String tableName);
		System.String ExecuteNonQuery(System.String sql);
		System.String ExecuteScalar(System.String sql);
		System.Data.DataTable ExecuteDataTable(System.String sql);
		W3000.Data.UsrAccountData GetByPK(System.Guid UsrAccountPK);
		W3000.Data.UsrAccountDataCollection GetAll();
		W3000.Data.UsrAccountViewCollection GetViewAll();
		W3000.Data.UsrAccountDataCollection GetByBDTenant(System.Guid BDTenantPK);
		W3000.Data.UsrAccountViewCollection GetViewByBDTenant(System.Guid BDTenantPK);
		W3000.Data.UsrAccountDataCollection GetByUsrGroup(System.Guid UsrGroupPK);
		W3000.Data.UsrAccountViewCollection GetViewByUsrGroup(System.Guid UsrGroupPK);
	}

	public partial interface IBDBuildingHolidayMapDataService
	{
		System.Int32 GetAllCount();
		W3000.Data.BDBuildingHolidayMapDataCollection GetAllPage(System.Int32 pageIndex, System.Int32 pageSize);
		W3000.Data.BDBuildingHolidayMapData GetByUK(System.Guid BDBuildingPK, System.Guid UtilHolidayPK);
		W3000.Data.BDBuildingHolidayMapData GetByPK(System.Guid BDBuildingHolidayMapPK);
		W3000.Data.BDBuildingHolidayMapDataCollection GetAll();
		W3000.Data.BDBuildingHolidayMapViewCollection GetViewAll();
		W3000.Data.BDBuildingHolidayMapDataCollection GetByBDBuilding(System.Guid BDBuildingPK);
		W3000.Data.BDBuildingHolidayMapViewCollection GetViewByBDBuilding(System.Guid BDBuildingPK);
		W3000.Data.BDBuildingHolidayMapDataCollection GetByUtilHoliday(System.Guid UtilHolidayPK);
		W3000.Data.BDBuildingHolidayMapViewCollection GetViewByUtilHoliday(System.Guid UtilHolidayPK);
	}

	public partial interface IBDTenantHolidayMapDataService
	{
		System.Int32 GetAllCount();
		W3000.Data.BDTenantHolidayMapDataCollection GetAllPage(System.Int32 pageIndex, System.Int32 pageSize);
		W3000.Data.BDTenantHolidayMapData GetByUK(System.Guid BDTenantPK, System.Guid UtilHolidayPK);
		W3000.Data.BDTenantHolidayMapData GetByPK(System.Guid BDTenantHolidayMapPK);
		W3000.Data.BDTenantHolidayMapDataCollection GetAll();
		W3000.Data.BDTenantHolidayMapViewCollection GetViewAll();
		W3000.Data.BDTenantHolidayMapDataCollection GetByBDTenant(System.Guid BDTenantPK);
		W3000.Data.BDTenantHolidayMapViewCollection GetViewByBDTenant(System.Guid BDTenantPK);
		W3000.Data.BDTenantHolidayMapDataCollection GetByUtilHoliday(System.Guid UtilHolidayPK);
		W3000.Data.BDTenantHolidayMapViewCollection GetViewByUtilHoliday(System.Guid UtilHolidayPK);
	}

	public partial interface IUsrGroupDataService
	{
		System.Int32 GetAllCount();
		W3000.Data.UsrGroupDataCollection GetAllPage(System.Int32 pageIndex, System.Int32 pageSize);
		W3000.Data.UsrGroupData GetByUsrGroupName(System.String UsrGroupName);
		W3000.Data.UsrGroupData GetByPK(System.Guid UsrGroupPK);
		W3000.Data.UsrGroupDataCollection GetAll();
		W3000.Data.UsrGroupViewCollection GetViewAll();
	}

	public partial interface ILogDBDeleteActivityDataService
	{
		W3000.Data.LogDBDeleteActivityDataCollection GetByLogDateTime(System.DateTime begin, System.DateTime end);
		W3000.Data.LogDBDeleteActivityDataCollection GetByLogDateTime(System.DateTime begin, System.DateTime end, System.String tableName);
		W3000.Data.LogDBDeleteActivityData GetByPK(System.Guid LogDBDeleteActivityPK);
		W3000.Data.LogDBDeleteActivityDataCollection GetAll();
		W3000.Data.LogDBDeleteActivityViewCollection GetViewAll();
	}

	public partial interface ILogDBEditActivityDataService
	{
		W3000.Data.LogDBEditActivityDataCollection GetByLogDateTime(System.DateTime begin, System.DateTime end);
		W3000.Data.LogDBEditActivityDataCollection GetByLogDateTime(System.DateTime begin, System.DateTime end, System.Guid recordPK);
		W3000.Data.LogDBEditActivityDataCollection GetByLogDateTime(System.DateTime begin, System.DateTime end, System.String tableName);
		W3000.Data.LogDBEditActivityDataCollection GetByDeleteRecords(System.DateTime begin, System.DateTime end, System.String tableName);
		W3000.Data.LogDBEditActivityData GetDeletedRecord(System.DateTime lastUpdated, System.Guid recordPK);
		W3000.Data.LogDBEditActivityData GetByPK(System.Guid LogDBEditActivityPK);
		W3000.Data.LogDBEditActivityDataCollection GetAll();
		W3000.Data.LogDBEditActivityViewCollection GetViewAll();
	}

}
