namespace W3000.IBasicService
{
	public interface IBasicServiceFactory
	{
		byte[] GetACAccessLevelResult(string actionName, byte[] paras);
		byte[] GetACAccessLevelDetailResult(string actionName, byte[] paras);
		byte[] GetACAMFormatResult(string actionName, byte[] paras);
		byte[] GetACCardHolderBuildingMapResult(string actionName, byte[] paras);
		byte[] GetACCardHolderResult(string actionName, byte[] paras);
		byte[] GetACFunctionCardResult(string actionName, byte[] paras);
		byte[] GetACInputResult(string actionName, byte[] paras);
		byte[] GetACInputGroupResult(string actionName, byte[] paras);
		byte[] GetACInputGroupInputMapResult(string actionName, byte[] paras);
		byte[] GetACIntervalResult(string actionName, byte[] paras);
		byte[] GetACIntvalHolidayMapResult(string actionName, byte[] paras);
		byte[] GetACMainZoneResult(string actionName, byte[] paras);
		byte[] GetACMasterCardResult(string actionName, byte[] paras);
		byte[] GetACOutputGroupResult(string actionName, byte[] paras);
		byte[] GetACOutputGroupMainZoneMapResult(string actionName, byte[] paras);
		byte[] GetACPanelResult(string actionName, byte[] paras);
		byte[] GetACPanelFunctionCardMapResult(string actionName, byte[] paras);
		byte[] GetACPanelHolidayMapResult(string actionName, byte[] paras);
		byte[] GetACSupervisoryResult(string actionName, byte[] paras);
		byte[] GetACTimecodeResult(string actionName, byte[] paras);
		byte[] GetACTimecodeIntervalMapResult(string actionName, byte[] paras);
		byte[] GetBDBuildingResult(string actionName, byte[] paras);
		byte[] GetBDBuildingHolidayMapResult(string actionName, byte[] paras);
		byte[] GetBDTenantResult(string actionName, byte[] paras);
		byte[] GetBDTenantHolidayMapResult(string actionName, byte[] paras);
		byte[] GetBDVisitorResult(string actionName, byte[] paras);
		byte[] GetLogDBDeleteActivityResult(string actionName, byte[] paras);
		byte[] GetLogDBEditActivityResult(string actionName, byte[] paras);
		byte[] GetLogRowsCountResult(string actionName, byte[] paras);
		byte[] GetUsrAccountBRRuleResult(string actionName, byte[] paras);
		byte[] GetUsrAccountBuildingMapResult(string actionName, byte[] paras);
		byte[] GetUsrAccountResult(string actionName, byte[] paras);
		byte[] GetUsrAccountDBRuleResult(string actionName, byte[] paras);
		byte[] GetUsrAccountTenantMapResult(string actionName, byte[] paras);
		byte[] GetUsrGroupBRRuleResult(string actionName, byte[] paras);
		byte[] GetUsrGroupResult(string actionName, byte[] paras);
		byte[] GetUsrGroupDBRuleResult(string actionName, byte[] paras);
		byte[] GetUtilHolidayResult(string actionName, byte[] paras);
		byte[] GetUtilSettingCategoryResult(string actionName, byte[] paras);
		byte[] GetUtilSettingDetailResult(string actionName, byte[] paras);
	}
}
