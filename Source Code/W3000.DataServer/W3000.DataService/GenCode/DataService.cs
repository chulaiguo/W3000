using System;
using System.Configuration;
using System.Security.Authentication;
using Cheke;
using Cheke.BusinessEntity;
using W3000.Data;
using W3000.DataServiceBase;
using W3000.IDataService;

namespace W3000.DataService
{
	public partial class ACIntvalHolidayMapDataService : ACIntvalHolidayMapDataServiceBase, IACIntvalHolidayMapDataService
	{
		public ACIntvalHolidayMapDataService(string connectionString, SecurityToken token)
			: base(connectionString, token)
		{
		}

		#region Override Children Services
		#endregion
	}
	public partial class ACAccessLevelDetailDataService : ACAccessLevelDetailDataServiceBase, IACAccessLevelDetailDataService
	{
		public ACAccessLevelDetailDataService(string connectionString, SecurityToken token)
			: base(connectionString, token)
		{
		}

		#region Override Children Services
		#endregion
	}
	public partial class UsrAccountBuildingMapDataService : UsrAccountBuildingMapDataServiceBase, IUsrAccountBuildingMapDataService
	{
		public UsrAccountBuildingMapDataService(string connectionString, SecurityToken token)
			: base(connectionString, token)
		{
		}

		#region Override Children Services
		#endregion
	}
	public partial class BDBuildingDataService : BDBuildingDataServiceBase, IBDBuildingDataService
	{
		public BDBuildingDataService(string connectionString, SecurityToken token)
			: base(connectionString, token)
		{
		}

		#region Override Children Services
		protected override UsrAccountBuildingMapDataServiceBase GetUsrAccountBuildingMapDataServiceBase(SecurityToken token)
		{
			return DataServiceFactory.CreateUsrAccountBuildingMapDataService(token, true);
		}

		protected override ACPanelDataServiceBase GetACPanelDataServiceBase(SecurityToken token)
		{
			return DataServiceFactory.CreateACPanelDataService(token, true);
		}

		protected override BDTenantDataServiceBase GetBDTenantDataServiceBase(SecurityToken token)
		{
			return DataServiceFactory.CreateBDTenantDataService(token, true);
		}

		protected override BDBuildingHolidayMapDataServiceBase GetBDBuildingHolidayMapDataServiceBase(SecurityToken token)
		{
			return DataServiceFactory.CreateBDBuildingHolidayMapDataService(token, true);
		}

		protected override ACIntervalDataServiceBase GetACIntervalDataServiceBase(SecurityToken token)
		{
			return DataServiceFactory.CreateACIntervalDataService(token, true);
		}

		protected override ACTimecodeDataServiceBase GetACTimecodeDataServiceBase(SecurityToken token)
		{
			return DataServiceFactory.CreateACTimecodeDataService(token, true);
		}

		protected override ACAMFormatDataServiceBase GetACAMFormatDataServiceBase(SecurityToken token)
		{
			return DataServiceFactory.CreateACAMFormatDataService(token, true);
		}

		protected override ACAccessLevelDataServiceBase GetACAccessLevelDataServiceBase(SecurityToken token)
		{
			return DataServiceFactory.CreateACAccessLevelDataService(token, true);
		}

		protected override ACCardHolderBuildingMapDataServiceBase GetACCardHolderBuildingMapDataServiceBase(SecurityToken token)
		{
			return DataServiceFactory.CreateACCardHolderBuildingMapDataService(token, true);
		}

		#endregion
	}
	public partial class BDTenantDataService : BDTenantDataServiceBase, IBDTenantDataService
	{
		public BDTenantDataService(string connectionString, SecurityToken token)
			: base(connectionString, token)
		{
		}

		#region Override Children Services
		protected override UsrAccountTenantMapDataServiceBase GetUsrAccountTenantMapDataServiceBase(SecurityToken token)
		{
			return DataServiceFactory.CreateUsrAccountTenantMapDataService(token, true);
		}

		protected override UsrAccountDataServiceBase GetUsrAccountDataServiceBase(SecurityToken token)
		{
			return DataServiceFactory.CreateUsrAccountDataService(token, true);
		}

		protected override ACFunctionCardDataServiceBase GetACFunctionCardDataServiceBase(SecurityToken token)
		{
			return DataServiceFactory.CreateACFunctionCardDataService(token, true);
		}

		protected override BDTenantHolidayMapDataServiceBase GetBDTenantHolidayMapDataServiceBase(SecurityToken token)
		{
			return DataServiceFactory.CreateBDTenantHolidayMapDataService(token, true);
		}

		protected override ACCardHolderDataServiceBase GetACCardHolderDataServiceBase(SecurityToken token)
		{
			return DataServiceFactory.CreateACCardHolderDataService(token, true);
		}

		protected override BDVisitorDataServiceBase GetBDVisitorDataServiceBase(SecurityToken token)
		{
			return DataServiceFactory.CreateBDVisitorDataService(token, true);
		}

		#endregion
	}
	public partial class UtilSettingCategoryDataService : UtilSettingCategoryDataServiceBase, IUtilSettingCategoryDataService
	{
		public UtilSettingCategoryDataService(string connectionString, SecurityToken token)
			: base(connectionString, token)
		{
		}

		#region Override Children Services
		protected override UtilSettingDetailDataServiceBase GetUtilSettingDetailDataServiceBase(SecurityToken token)
		{
			return DataServiceFactory.CreateUtilSettingDetailDataService(token, true);
		}

		#endregion
	}
	public partial class UtilSettingDetailDataService : UtilSettingDetailDataServiceBase, IUtilSettingDetailDataService
	{
		public UtilSettingDetailDataService(string connectionString, SecurityToken token)
			: base(connectionString, token)
		{
		}

		#region Override Children Services
		#endregion
	}
	public partial class ACOutputGroupMainZoneMapDataService : ACOutputGroupMainZoneMapDataServiceBase, IACOutputGroupMainZoneMapDataService
	{
		public ACOutputGroupMainZoneMapDataService(string connectionString, SecurityToken token)
			: base(connectionString, token)
		{
		}

		#region Override Children Services
		#endregion
	}
	public partial class ACCardHolderDataService : ACCardHolderDataServiceBase, IACCardHolderDataService
	{
		public ACCardHolderDataService(string connectionString, SecurityToken token)
			: base(connectionString, token)
		{
		}

		#region Override Children Services
		protected override ACCardHolderBuildingMapDataServiceBase GetACCardHolderBuildingMapDataServiceBase(SecurityToken token)
		{
			return DataServiceFactory.CreateACCardHolderBuildingMapDataService(token, true);
		}

		#endregion
	}
	public partial class ACMainZoneDataService : ACMainZoneDataServiceBase, IACMainZoneDataService
	{
		public ACMainZoneDataService(string connectionString, SecurityToken token)
			: base(connectionString, token)
		{
		}

		#region Override Children Services
		protected override ACOutputGroupMainZoneMapDataServiceBase GetACOutputGroupMainZoneMapDataServiceBase(SecurityToken token)
		{
			return DataServiceFactory.CreateACOutputGroupMainZoneMapDataService(token, true);
		}

		protected override ACAccessLevelDetailDataServiceBase GetACAccessLevelDetailDataServiceBase(SecurityToken token)
		{
			return DataServiceFactory.CreateACAccessLevelDetailDataService(token, true);
		}

		#endregion
	}
	public partial class ACIntervalDataService : ACIntervalDataServiceBase, IACIntervalDataService
	{
		public ACIntervalDataService(string connectionString, SecurityToken token)
			: base(connectionString, token)
		{
		}

		#region Override Children Services
		protected override ACIntvalHolidayMapDataServiceBase GetACIntvalHolidayMapDataServiceBase(SecurityToken token)
		{
			return DataServiceFactory.CreateACIntvalHolidayMapDataService(token, true);
		}

		protected override ACTimecodeIntervalMapDataServiceBase GetACTimecodeIntervalMapDataServiceBase(SecurityToken token)
		{
			return DataServiceFactory.CreateACTimecodeIntervalMapDataService(token, true);
		}

		#endregion
	}
	public partial class ACPanelHolidayMapDataService : ACPanelHolidayMapDataServiceBase, IACPanelHolidayMapDataService
	{
		public ACPanelHolidayMapDataService(string connectionString, SecurityToken token)
			: base(connectionString, token)
		{
		}

		#region Override Children Services
		#endregion
	}
	public partial class ACTimecodeDataService : ACTimecodeDataServiceBase, IACTimecodeDataService
	{
		public ACTimecodeDataService(string connectionString, SecurityToken token)
			: base(connectionString, token)
		{
		}

		#region Override Children Services
		protected override ACAccessLevelDetailDataServiceBase GetACAccessLevelDetailDataServiceBase(SecurityToken token)
		{
			return DataServiceFactory.CreateACAccessLevelDetailDataService(token, true);
		}

		protected override ACTimecodeIntervalMapDataServiceBase GetACTimecodeIntervalMapDataServiceBase(SecurityToken token)
		{
			return DataServiceFactory.CreateACTimecodeIntervalMapDataService(token, true);
		}

		#endregion
	}
	public partial class ACTimecodeIntervalMapDataService : ACTimecodeIntervalMapDataServiceBase, IACTimecodeIntervalMapDataService
	{
		public ACTimecodeIntervalMapDataService(string connectionString, SecurityToken token)
			: base(connectionString, token)
		{
		}

		#region Override Children Services
		#endregion
	}
	public partial class ACAMFormatDataService : ACAMFormatDataServiceBase, IACAMFormatDataService
	{
		public ACAMFormatDataService(string connectionString, SecurityToken token)
			: base(connectionString, token)
		{
		}

		#region Override Children Services
		#endregion
	}
	public partial class BDBuildingHolidayMapDataService : BDBuildingHolidayMapDataServiceBase, IBDBuildingHolidayMapDataService
	{
		public BDBuildingHolidayMapDataService(string connectionString, SecurityToken token)
			: base(connectionString, token)
		{
		}

		#region Override Children Services
		#endregion
	}
	public partial class ACOutputGroupDataService : ACOutputGroupDataServiceBase, IACOutputGroupDataService
	{
		public ACOutputGroupDataService(string connectionString, SecurityToken token)
			: base(connectionString, token)
		{
		}

		#region Override Children Services
		protected override ACOutputGroupMainZoneMapDataServiceBase GetACOutputGroupMainZoneMapDataServiceBase(SecurityToken token)
		{
			return DataServiceFactory.CreateACOutputGroupMainZoneMapDataService(token, true);
		}

		#endregion
	}
	public partial class BDTenantHolidayMapDataService : BDTenantHolidayMapDataServiceBase, IBDTenantHolidayMapDataService
	{
		public BDTenantHolidayMapDataService(string connectionString, SecurityToken token)
			: base(connectionString, token)
		{
		}

		#region Override Children Services
		#endregion
	}
	public partial class LogRowsCountDataService : LogRowsCountDataServiceBase, ILogRowsCountDataService
	{
		public LogRowsCountDataService(string connectionString, SecurityToken token)
			: base(connectionString, token)
		{
		}

		#region Override Children Services
		#endregion
	}
	public partial class ACInputGroupDataService : ACInputGroupDataServiceBase, IACInputGroupDataService
	{
		public ACInputGroupDataService(string connectionString, SecurityToken token)
			: base(connectionString, token)
		{
		}

		#region Override Children Services
		protected override ACInputGroupInputMapDataServiceBase GetACInputGroupInputMapDataServiceBase(SecurityToken token)
		{
			return DataServiceFactory.CreateACInputGroupInputMapDataService(token, true);
		}

		#endregion
	}
	public partial class ACInputDataService : ACInputDataServiceBase, IACInputDataService
	{
		public ACInputDataService(string connectionString, SecurityToken token)
			: base(connectionString, token)
		{
		}

		#region Override Children Services
		protected override ACInputGroupInputMapDataServiceBase GetACInputGroupInputMapDataServiceBase(SecurityToken token)
		{
			return DataServiceFactory.CreateACInputGroupInputMapDataService(token, true);
		}

		#endregion
	}
	public partial class ACFunctionCardDataService : ACFunctionCardDataServiceBase, IACFunctionCardDataService
	{
		public ACFunctionCardDataService(string connectionString, SecurityToken token)
			: base(connectionString, token)
		{
		}

		#region Override Children Services
		protected override ACPanelFunctionCardMapDataServiceBase GetACPanelFunctionCardMapDataServiceBase(SecurityToken token)
		{
			return DataServiceFactory.CreateACPanelFunctionCardMapDataService(token, true);
		}

		#endregion
	}
	public partial class ACAccessLevelDataService : ACAccessLevelDataServiceBase, IACAccessLevelDataService
	{
		public ACAccessLevelDataService(string connectionString, SecurityToken token)
			: base(connectionString, token)
		{
		}

		#region Override Children Services
		protected override ACAccessLevelDetailDataServiceBase GetACAccessLevelDetailDataServiceBase(SecurityToken token)
		{
			return DataServiceFactory.CreateACAccessLevelDetailDataService(token, true);
		}

		#endregion
	}
	public partial class ACPanelFunctionCardMapDataService : ACPanelFunctionCardMapDataServiceBase, IACPanelFunctionCardMapDataService
	{
		public ACPanelFunctionCardMapDataService(string connectionString, SecurityToken token)
			: base(connectionString, token)
		{
		}

		#region Override Children Services
		#endregion
	}
	public partial class UtilHolidayDataService : UtilHolidayDataServiceBase, IUtilHolidayDataService
	{
		public UtilHolidayDataService(string connectionString, SecurityToken token)
			: base(connectionString, token)
		{
		}

		#region Override Children Services
		protected override ACIntvalHolidayMapDataServiceBase GetACIntvalHolidayMapDataServiceBase(SecurityToken token)
		{
			return DataServiceFactory.CreateACIntvalHolidayMapDataService(token, true);
		}

		protected override ACPanelHolidayMapDataServiceBase GetACPanelHolidayMapDataServiceBase(SecurityToken token)
		{
			return DataServiceFactory.CreateACPanelHolidayMapDataService(token, true);
		}

		protected override BDBuildingHolidayMapDataServiceBase GetBDBuildingHolidayMapDataServiceBase(SecurityToken token)
		{
			return DataServiceFactory.CreateBDBuildingHolidayMapDataService(token, true);
		}

		protected override BDTenantHolidayMapDataServiceBase GetBDTenantHolidayMapDataServiceBase(SecurityToken token)
		{
			return DataServiceFactory.CreateBDTenantHolidayMapDataService(token, true);
		}

		#endregion
	}
	public partial class LogDBDeleteActivityDataService : LogDBDeleteActivityDataServiceBase, ILogDBDeleteActivityDataService
	{
		public LogDBDeleteActivityDataService(string connectionString, SecurityToken token)
			: base(connectionString, token)
		{
		}

		#region Override Children Services
		#endregion
	}
	public partial class UsrAccountDataService : UsrAccountDataServiceBase, IUsrAccountDataService
	{
		public UsrAccountDataService(string connectionString, SecurityToken token)
			: base(connectionString, token)
		{
		}

		#region Override Children Services
		protected override UsrAccountBuildingMapDataServiceBase GetUsrAccountBuildingMapDataServiceBase(SecurityToken token)
		{
			return DataServiceFactory.CreateUsrAccountBuildingMapDataService(token, true);
		}

		protected override UsrAccountBRRuleDataServiceBase GetUsrAccountBRRuleDataServiceBase(SecurityToken token)
		{
			return DataServiceFactory.CreateUsrAccountBRRuleDataService(token, true);
		}

		protected override UsrAccountDBRuleDataServiceBase GetUsrAccountDBRuleDataServiceBase(SecurityToken token)
		{
			return DataServiceFactory.CreateUsrAccountDBRuleDataService(token, true);
		}

		protected override UsrAccountTenantMapDataServiceBase GetUsrAccountTenantMapDataServiceBase(SecurityToken token)
		{
			return DataServiceFactory.CreateUsrAccountTenantMapDataService(token, true);
		}

		#endregion
	}
	public partial class LogDBEditActivityDataService : LogDBEditActivityDataServiceBase, ILogDBEditActivityDataService
	{
		public LogDBEditActivityDataService(string connectionString, SecurityToken token)
			: base(connectionString, token)
		{
		}

		#region Override Children Services
		#endregion
	}
	public partial class ACMasterCardDataService : ACMasterCardDataServiceBase, IACMasterCardDataService
	{
		public ACMasterCardDataService(string connectionString, SecurityToken token)
			: base(connectionString, token)
		{
		}

		#region Override Children Services
		#endregion
	}
	public partial class ACSupervisoryDataService : ACSupervisoryDataServiceBase, IACSupervisoryDataService
	{
		public ACSupervisoryDataService(string connectionString, SecurityToken token)
			: base(connectionString, token)
		{
		}

		#region Override Children Services
		#endregion
	}
	public partial class UsrGroupDataService : UsrGroupDataServiceBase, IUsrGroupDataService
	{
		public UsrGroupDataService(string connectionString, SecurityToken token)
			: base(connectionString, token)
		{
		}

		#region Override Children Services
		protected override UsrGroupDBRuleDataServiceBase GetUsrGroupDBRuleDataServiceBase(SecurityToken token)
		{
			return DataServiceFactory.CreateUsrGroupDBRuleDataService(token, true);
		}

		protected override UsrGroupBRRuleDataServiceBase GetUsrGroupBRRuleDataServiceBase(SecurityToken token)
		{
			return DataServiceFactory.CreateUsrGroupBRRuleDataService(token, true);
		}

		protected override UsrAccountDataServiceBase GetUsrAccountDataServiceBase(SecurityToken token)
		{
			return DataServiceFactory.CreateUsrAccountDataService(token, true);
		}

		#endregion
	}
	public partial class ACCardHolderBuildingMapDataService : ACCardHolderBuildingMapDataServiceBase, IACCardHolderBuildingMapDataService
	{
		public ACCardHolderBuildingMapDataService(string connectionString, SecurityToken token)
			: base(connectionString, token)
		{
		}

		#region Override Children Services
		#endregion
	}
	public partial class BDVisitorDataService : BDVisitorDataServiceBase, IBDVisitorDataService
	{
		public BDVisitorDataService(string connectionString, SecurityToken token)
			: base(connectionString, token)
		{
		}

		#region Override Children Services
		#endregion
	}
	public partial class UsrGroupDBRuleDataService : UsrGroupDBRuleDataServiceBase, IUsrGroupDBRuleDataService
	{
		public UsrGroupDBRuleDataService(string connectionString, SecurityToken token)
			: base(connectionString, token)
		{
		}

		#region Override Children Services
		#endregion
	}
	public partial class ACPanelDataService : ACPanelDataServiceBase, IACPanelDataService
	{
		public ACPanelDataService(string connectionString, SecurityToken token)
			: base(connectionString, token)
		{
		}

		#region Override Children Services
		protected override ACInputDataServiceBase GetACInputDataServiceBase(SecurityToken token)
		{
			return DataServiceFactory.CreateACInputDataService(token, true);
		}

		protected override ACSupervisoryDataServiceBase GetACSupervisoryDataServiceBase(SecurityToken token)
		{
			return DataServiceFactory.CreateACSupervisoryDataService(token, true);
		}

		protected override ACPanelHolidayMapDataServiceBase GetACPanelHolidayMapDataServiceBase(SecurityToken token)
		{
			return DataServiceFactory.CreateACPanelHolidayMapDataService(token, true);
		}

		protected override ACMainZoneDataServiceBase GetACMainZoneDataServiceBase(SecurityToken token)
		{
			return DataServiceFactory.CreateACMainZoneDataService(token, true);
		}

		protected override ACPanelFunctionCardMapDataServiceBase GetACPanelFunctionCardMapDataServiceBase(SecurityToken token)
		{
			return DataServiceFactory.CreateACPanelFunctionCardMapDataService(token, true);
		}

		protected override ACOutputGroupDataServiceBase GetACOutputGroupDataServiceBase(SecurityToken token)
		{
			return DataServiceFactory.CreateACOutputGroupDataService(token, true);
		}

		protected override ACInputGroupDataServiceBase GetACInputGroupDataServiceBase(SecurityToken token)
		{
			return DataServiceFactory.CreateACInputGroupDataService(token, true);
		}

		#endregion
	}
	public partial class UsrAccountDBRuleDataService : UsrAccountDBRuleDataServiceBase, IUsrAccountDBRuleDataService
	{
		public UsrAccountDBRuleDataService(string connectionString, SecurityToken token)
			: base(connectionString, token)
		{
		}

		#region Override Children Services
		#endregion
	}
	public partial class UsrGroupBRRuleDataService : UsrGroupBRRuleDataServiceBase, IUsrGroupBRRuleDataService
	{
		public UsrGroupBRRuleDataService(string connectionString, SecurityToken token)
			: base(connectionString, token)
		{
		}

		#region Override Children Services
		#endregion
	}
	public partial class ACInputGroupInputMapDataService : ACInputGroupInputMapDataServiceBase, IACInputGroupInputMapDataService
	{
		public ACInputGroupInputMapDataService(string connectionString, SecurityToken token)
			: base(connectionString, token)
		{
		}

		#region Override Children Services
		#endregion
	}
	public partial class UsrAccountBRRuleDataService : UsrAccountBRRuleDataServiceBase, IUsrAccountBRRuleDataService
	{
		public UsrAccountBRRuleDataService(string connectionString, SecurityToken token)
			: base(connectionString, token)
		{
		}

		#region Override Children Services
		#endregion
	}
	public partial class UsrAccountTenantMapDataService : UsrAccountTenantMapDataServiceBase, IUsrAccountTenantMapDataService
	{
		public UsrAccountTenantMapDataService(string connectionString, SecurityToken token)
			: base(connectionString, token)
		{
		}

		#region Override Children Services
		#endregion
	}

	public static class DataServiceFactory
	{
		private static readonly string _ConnectionString = ConfigurationManager.AppSettings["DB:W3000"];

		public static string ConnectionString
		{
			get { return _ConnectionString; }
		}

		public static void CheckAuthorize(SecurityToken token)
		{
			if(token.IsAnonymous || Utils.Authentication.IsAuthenticated(token))
				return;

			throw new AuthenticationException(string.Format("The UserId/Password(UserID={0}) is not valid", token.UserId));
		}

		public static ACIntvalHolidayMapDataService CreateACIntvalHolidayMapDataService(SecurityToken token, bool isUsedByOtherService)
		{
			if (isUsedByOtherService)
			{
				token = SecurityToken.CreateDuplicateToken(token, false);
			}
			return new ACIntvalHolidayMapDataService(_ConnectionString, token);
		}

		public static ACAccessLevelDetailDataService CreateACAccessLevelDetailDataService(SecurityToken token, bool isUsedByOtherService)
		{
			if (isUsedByOtherService)
			{
				token = SecurityToken.CreateDuplicateToken(token, false);
			}
			return new ACAccessLevelDetailDataService(_ConnectionString, token);
		}

		public static UsrAccountBuildingMapDataService CreateUsrAccountBuildingMapDataService(SecurityToken token, bool isUsedByOtherService)
		{
			if (isUsedByOtherService)
			{
				token = SecurityToken.CreateDuplicateToken(token, false);
			}
			return new UsrAccountBuildingMapDataService(_ConnectionString, token);
		}

		public static BDBuildingDataService CreateBDBuildingDataService(SecurityToken token, bool isUsedByOtherService)
		{
			if (isUsedByOtherService)
			{
				token = SecurityToken.CreateDuplicateToken(token, false);
			}
			return new BDBuildingDataService(_ConnectionString, token);
		}

		public static BDTenantDataService CreateBDTenantDataService(SecurityToken token, bool isUsedByOtherService)
		{
			if (isUsedByOtherService)
			{
				token = SecurityToken.CreateDuplicateToken(token, false);
			}
			return new BDTenantDataService(_ConnectionString, token);
		}

		public static UtilSettingCategoryDataService CreateUtilSettingCategoryDataService(SecurityToken token, bool isUsedByOtherService)
		{
			if (isUsedByOtherService)
			{
				token = SecurityToken.CreateDuplicateToken(token, false);
			}
			return new UtilSettingCategoryDataService(_ConnectionString, token);
		}

		public static UtilSettingDetailDataService CreateUtilSettingDetailDataService(SecurityToken token, bool isUsedByOtherService)
		{
			if (isUsedByOtherService)
			{
				token = SecurityToken.CreateDuplicateToken(token, false);
			}
			return new UtilSettingDetailDataService(_ConnectionString, token);
		}

		public static ACOutputGroupMainZoneMapDataService CreateACOutputGroupMainZoneMapDataService(SecurityToken token, bool isUsedByOtherService)
		{
			if (isUsedByOtherService)
			{
				token = SecurityToken.CreateDuplicateToken(token, false);
			}
			return new ACOutputGroupMainZoneMapDataService(_ConnectionString, token);
		}

		public static ACCardHolderDataService CreateACCardHolderDataService(SecurityToken token, bool isUsedByOtherService)
		{
			if (isUsedByOtherService)
			{
				token = SecurityToken.CreateDuplicateToken(token, false);
			}
			return new ACCardHolderDataService(_ConnectionString, token);
		}

		public static ACMainZoneDataService CreateACMainZoneDataService(SecurityToken token, bool isUsedByOtherService)
		{
			if (isUsedByOtherService)
			{
				token = SecurityToken.CreateDuplicateToken(token, false);
			}
			return new ACMainZoneDataService(_ConnectionString, token);
		}

		public static ACIntervalDataService CreateACIntervalDataService(SecurityToken token, bool isUsedByOtherService)
		{
			if (isUsedByOtherService)
			{
				token = SecurityToken.CreateDuplicateToken(token, false);
			}
			return new ACIntervalDataService(_ConnectionString, token);
		}

		public static ACPanelHolidayMapDataService CreateACPanelHolidayMapDataService(SecurityToken token, bool isUsedByOtherService)
		{
			if (isUsedByOtherService)
			{
				token = SecurityToken.CreateDuplicateToken(token, false);
			}
			return new ACPanelHolidayMapDataService(_ConnectionString, token);
		}

		public static ACTimecodeDataService CreateACTimecodeDataService(SecurityToken token, bool isUsedByOtherService)
		{
			if (isUsedByOtherService)
			{
				token = SecurityToken.CreateDuplicateToken(token, false);
			}
			return new ACTimecodeDataService(_ConnectionString, token);
		}

		public static ACTimecodeIntervalMapDataService CreateACTimecodeIntervalMapDataService(SecurityToken token, bool isUsedByOtherService)
		{
			if (isUsedByOtherService)
			{
				token = SecurityToken.CreateDuplicateToken(token, false);
			}
			return new ACTimecodeIntervalMapDataService(_ConnectionString, token);
		}

		public static ACAMFormatDataService CreateACAMFormatDataService(SecurityToken token, bool isUsedByOtherService)
		{
			if (isUsedByOtherService)
			{
				token = SecurityToken.CreateDuplicateToken(token, false);
			}
			return new ACAMFormatDataService(_ConnectionString, token);
		}

		public static BDBuildingHolidayMapDataService CreateBDBuildingHolidayMapDataService(SecurityToken token, bool isUsedByOtherService)
		{
			if (isUsedByOtherService)
			{
				token = SecurityToken.CreateDuplicateToken(token, false);
			}
			return new BDBuildingHolidayMapDataService(_ConnectionString, token);
		}

		public static ACOutputGroupDataService CreateACOutputGroupDataService(SecurityToken token, bool isUsedByOtherService)
		{
			if (isUsedByOtherService)
			{
				token = SecurityToken.CreateDuplicateToken(token, false);
			}
			return new ACOutputGroupDataService(_ConnectionString, token);
		}

		public static BDTenantHolidayMapDataService CreateBDTenantHolidayMapDataService(SecurityToken token, bool isUsedByOtherService)
		{
			if (isUsedByOtherService)
			{
				token = SecurityToken.CreateDuplicateToken(token, false);
			}
			return new BDTenantHolidayMapDataService(_ConnectionString, token);
		}

		public static LogRowsCountDataService CreateLogRowsCountDataService(SecurityToken token, bool isUsedByOtherService)
		{
			if (isUsedByOtherService)
			{
				token = SecurityToken.CreateDuplicateToken(token, false);
			}
			return new LogRowsCountDataService(_ConnectionString, token);
		}

		public static ACInputGroupDataService CreateACInputGroupDataService(SecurityToken token, bool isUsedByOtherService)
		{
			if (isUsedByOtherService)
			{
				token = SecurityToken.CreateDuplicateToken(token, false);
			}
			return new ACInputGroupDataService(_ConnectionString, token);
		}

		public static ACInputDataService CreateACInputDataService(SecurityToken token, bool isUsedByOtherService)
		{
			if (isUsedByOtherService)
			{
				token = SecurityToken.CreateDuplicateToken(token, false);
			}
			return new ACInputDataService(_ConnectionString, token);
		}

		public static ACFunctionCardDataService CreateACFunctionCardDataService(SecurityToken token, bool isUsedByOtherService)
		{
			if (isUsedByOtherService)
			{
				token = SecurityToken.CreateDuplicateToken(token, false);
			}
			return new ACFunctionCardDataService(_ConnectionString, token);
		}

		public static ACAccessLevelDataService CreateACAccessLevelDataService(SecurityToken token, bool isUsedByOtherService)
		{
			if (isUsedByOtherService)
			{
				token = SecurityToken.CreateDuplicateToken(token, false);
			}
			return new ACAccessLevelDataService(_ConnectionString, token);
		}

		public static ACPanelFunctionCardMapDataService CreateACPanelFunctionCardMapDataService(SecurityToken token, bool isUsedByOtherService)
		{
			if (isUsedByOtherService)
			{
				token = SecurityToken.CreateDuplicateToken(token, false);
			}
			return new ACPanelFunctionCardMapDataService(_ConnectionString, token);
		}

		public static UtilHolidayDataService CreateUtilHolidayDataService(SecurityToken token, bool isUsedByOtherService)
		{
			if (isUsedByOtherService)
			{
				token = SecurityToken.CreateDuplicateToken(token, false);
			}
			return new UtilHolidayDataService(_ConnectionString, token);
		}

		public static LogDBDeleteActivityDataService CreateLogDBDeleteActivityDataService(SecurityToken token, bool isUsedByOtherService)
		{
			if (isUsedByOtherService)
			{
				token = SecurityToken.CreateDuplicateToken(token, false);
			}
			return new LogDBDeleteActivityDataService(_ConnectionString, token);
		}

		public static UsrAccountDataService CreateUsrAccountDataService(SecurityToken token, bool isUsedByOtherService)
		{
			if (isUsedByOtherService)
			{
				token = SecurityToken.CreateDuplicateToken(token, false);
			}
			return new UsrAccountDataService(_ConnectionString, token);
		}

		public static LogDBEditActivityDataService CreateLogDBEditActivityDataService(SecurityToken token, bool isUsedByOtherService)
		{
			if (isUsedByOtherService)
			{
				token = SecurityToken.CreateDuplicateToken(token, false);
			}
			return new LogDBEditActivityDataService(_ConnectionString, token);
		}

		public static ACMasterCardDataService CreateACMasterCardDataService(SecurityToken token, bool isUsedByOtherService)
		{
			if (isUsedByOtherService)
			{
				token = SecurityToken.CreateDuplicateToken(token, false);
			}
			return new ACMasterCardDataService(_ConnectionString, token);
		}

		public static ACSupervisoryDataService CreateACSupervisoryDataService(SecurityToken token, bool isUsedByOtherService)
		{
			if (isUsedByOtherService)
			{
				token = SecurityToken.CreateDuplicateToken(token, false);
			}
			return new ACSupervisoryDataService(_ConnectionString, token);
		}

		public static UsrGroupDataService CreateUsrGroupDataService(SecurityToken token, bool isUsedByOtherService)
		{
			if (isUsedByOtherService)
			{
				token = SecurityToken.CreateDuplicateToken(token, false);
			}
			return new UsrGroupDataService(_ConnectionString, token);
		}

		public static ACCardHolderBuildingMapDataService CreateACCardHolderBuildingMapDataService(SecurityToken token, bool isUsedByOtherService)
		{
			if (isUsedByOtherService)
			{
				token = SecurityToken.CreateDuplicateToken(token, false);
			}
			return new ACCardHolderBuildingMapDataService(_ConnectionString, token);
		}

		public static BDVisitorDataService CreateBDVisitorDataService(SecurityToken token, bool isUsedByOtherService)
		{
			if (isUsedByOtherService)
			{
				token = SecurityToken.CreateDuplicateToken(token, false);
			}
			return new BDVisitorDataService(_ConnectionString, token);
		}

		public static UsrGroupDBRuleDataService CreateUsrGroupDBRuleDataService(SecurityToken token, bool isUsedByOtherService)
		{
			if (isUsedByOtherService)
			{
				token = SecurityToken.CreateDuplicateToken(token, false);
			}
			return new UsrGroupDBRuleDataService(_ConnectionString, token);
		}

		public static ACPanelDataService CreateACPanelDataService(SecurityToken token, bool isUsedByOtherService)
		{
			if (isUsedByOtherService)
			{
				token = SecurityToken.CreateDuplicateToken(token, false);
			}
			return new ACPanelDataService(_ConnectionString, token);
		}

		public static UsrAccountDBRuleDataService CreateUsrAccountDBRuleDataService(SecurityToken token, bool isUsedByOtherService)
		{
			if (isUsedByOtherService)
			{
				token = SecurityToken.CreateDuplicateToken(token, false);
			}
			return new UsrAccountDBRuleDataService(_ConnectionString, token);
		}

		public static UsrGroupBRRuleDataService CreateUsrGroupBRRuleDataService(SecurityToken token, bool isUsedByOtherService)
		{
			if (isUsedByOtherService)
			{
				token = SecurityToken.CreateDuplicateToken(token, false);
			}
			return new UsrGroupBRRuleDataService(_ConnectionString, token);
		}

		public static ACInputGroupInputMapDataService CreateACInputGroupInputMapDataService(SecurityToken token, bool isUsedByOtherService)
		{
			if (isUsedByOtherService)
			{
				token = SecurityToken.CreateDuplicateToken(token, false);
			}
			return new ACInputGroupInputMapDataService(_ConnectionString, token);
		}

		public static UsrAccountBRRuleDataService CreateUsrAccountBRRuleDataService(SecurityToken token, bool isUsedByOtherService)
		{
			if (isUsedByOtherService)
			{
				token = SecurityToken.CreateDuplicateToken(token, false);
			}
			return new UsrAccountBRRuleDataService(_ConnectionString, token);
		}

		public static UsrAccountTenantMapDataService CreateUsrAccountTenantMapDataService(SecurityToken token, bool isUsedByOtherService)
		{
			if (isUsedByOtherService)
			{
				token = SecurityToken.CreateDuplicateToken(token, false);
			}
			return new UsrAccountTenantMapDataService(_ConnectionString, token);
		}

	}
}
