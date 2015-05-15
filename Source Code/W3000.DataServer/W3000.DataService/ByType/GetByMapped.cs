using System;
using System.Data;
using W3000.Data;
using W3000.Schema;
using System.Data.SqlClient;

namespace W3000.DataService
{
	public partial class BDBuildingDataService
	{
		public BDBuildingDataCollection GetByMappedUsrAccount(Guid UsrAccountPK)
		{
			string sql = string.Format(" WHERE [{0}].[{1}] IN (SELECT [{2}] FROM [{3}] WHERE [{4}] = @{4})", BDBuildingSchema.TableAlias, BDBuildingSchema.BDBuildingPK, UsrAccountBuildingMapSchema.BDBuildingPK, UsrAccountBuildingMapSchema.TableName, UsrAccountBuildingMapSchema.UsrAccountPK);

			SqlParameter[] paras = new SqlParameter[1];
			paras[0] = new SqlParameter(string.Format("@{0}", UsrAccountBuildingMapSchema.UsrAccountPK), SqlDbType.UniqueIdentifier);
			paras[0].Value = UsrAccountPK;

			return this.GetCollection(sql, paras);
		}

		public BDBuildingDataCollection GetByMappedUtilHoliday(Guid UtilHolidayPK)
		{
			string sql = string.Format(" WHERE [{0}].[{1}] IN (SELECT [{2}] FROM [{3}] WHERE [{4}] = @{4})", BDBuildingSchema.TableAlias, BDBuildingSchema.BDBuildingPK, BDBuildingHolidayMapSchema.BDBuildingPK, BDBuildingHolidayMapSchema.TableName, BDBuildingHolidayMapSchema.UtilHolidayPK);

			SqlParameter[] paras = new SqlParameter[1];
			paras[0] = new SqlParameter(string.Format("@{0}", BDBuildingHolidayMapSchema.UtilHolidayPK), SqlDbType.UniqueIdentifier);
			paras[0].Value = UtilHolidayPK;

			return this.GetCollection(sql, paras);
		}

		public BDBuildingDataCollection GetByMappedACCardHolder(Guid ACCardHolderPK)
		{
			string sql = string.Format(" WHERE [{0}].[{1}] IN (SELECT [{2}] FROM [{3}] WHERE [{4}] = @{4})", BDBuildingSchema.TableAlias, BDBuildingSchema.BDBuildingPK, ACCardHolderBuildingMapSchema.BDBuildingPK, ACCardHolderBuildingMapSchema.TableName, ACCardHolderBuildingMapSchema.ACCardHolderPK);

			SqlParameter[] paras = new SqlParameter[1];
			paras[0] = new SqlParameter(string.Format("@{0}", ACCardHolderBuildingMapSchema.ACCardHolderPK), SqlDbType.UniqueIdentifier);
			paras[0].Value = ACCardHolderPK;

			return this.GetCollection(sql, paras);
		}

	}

	public partial class BDTenantDataService
	{
		public BDTenantDataCollection GetByMappedUsrAccount(Guid UsrAccountPK)
		{
			string sql = string.Format(" WHERE [{0}].[{1}] IN (SELECT [{2}] FROM [{3}] WHERE [{4}] = @{4})", BDTenantSchema.TableAlias, BDTenantSchema.BDTenantPK, UsrAccountTenantMapSchema.BDTenantPK, UsrAccountTenantMapSchema.TableName, UsrAccountTenantMapSchema.UsrAccountPK);

			SqlParameter[] paras = new SqlParameter[1];
			paras[0] = new SqlParameter(string.Format("@{0}", UsrAccountTenantMapSchema.UsrAccountPK), SqlDbType.UniqueIdentifier);
			paras[0].Value = UsrAccountPK;

			return this.GetCollection(sql, paras);
		}

		public BDTenantDataCollection GetByMappedUtilHoliday(Guid UtilHolidayPK)
		{
			string sql = string.Format(" WHERE [{0}].[{1}] IN (SELECT [{2}] FROM [{3}] WHERE [{4}] = @{4})", BDTenantSchema.TableAlias, BDTenantSchema.BDTenantPK, BDTenantHolidayMapSchema.BDTenantPK, BDTenantHolidayMapSchema.TableName, BDTenantHolidayMapSchema.UtilHolidayPK);

			SqlParameter[] paras = new SqlParameter[1];
			paras[0] = new SqlParameter(string.Format("@{0}", BDTenantHolidayMapSchema.UtilHolidayPK), SqlDbType.UniqueIdentifier);
			paras[0].Value = UtilHolidayPK;

			return this.GetCollection(sql, paras);
		}

	}

	public partial class ACCardHolderDataService
	{
		public ACCardHolderDataCollection GetByMappedBDBuilding(Guid BDBuildingPK)
		{
			string sql = string.Format(" WHERE [{0}].[{1}] IN (SELECT [{2}] FROM [{3}] WHERE [{4}] = @{4})", ACCardHolderSchema.TableAlias, ACCardHolderSchema.ACCardHolderPK, ACCardHolderBuildingMapSchema.ACCardHolderPK, ACCardHolderBuildingMapSchema.TableName, ACCardHolderBuildingMapSchema.BDBuildingPK);

			SqlParameter[] paras = new SqlParameter[1];
			paras[0] = new SqlParameter(string.Format("@{0}", ACCardHolderBuildingMapSchema.BDBuildingPK), SqlDbType.UniqueIdentifier);
			paras[0].Value = BDBuildingPK;

			return this.GetCollection(sql, paras);
		}

	}

	public partial class ACMainZoneDataService
	{
		public ACMainZoneDataCollection GetByMappedACOutputGroup(Guid ACOutputGroupPK)
		{
			string sql = string.Format(" WHERE [{0}].[{1}] IN (SELECT [{2}] FROM [{3}] WHERE [{4}] = @{4})", ACMainZoneSchema.TableAlias, ACMainZoneSchema.ACMainZonePK, ACOutputGroupMainZoneMapSchema.ACMainZonePK, ACOutputGroupMainZoneMapSchema.TableName, ACOutputGroupMainZoneMapSchema.ACOutputGroupPK);

			SqlParameter[] paras = new SqlParameter[1];
			paras[0] = new SqlParameter(string.Format("@{0}", ACOutputGroupMainZoneMapSchema.ACOutputGroupPK), SqlDbType.UniqueIdentifier);
			paras[0].Value = ACOutputGroupPK;

			return this.GetCollection(sql, paras);
		}

		public ACMainZoneDataCollection GetByMappedACTimecode(Guid ACTimecodePK)
		{
			string sql = string.Format(" WHERE [{0}].[{1}] IN (SELECT [{2}] FROM [{3}] WHERE [{4}] = @{4})", ACMainZoneSchema.TableAlias, ACMainZoneSchema.ACMainZonePK, ACAccessLevelDetailSchema.ACMainZonePK, ACAccessLevelDetailSchema.TableName, ACAccessLevelDetailSchema.ACTimecodePK);

			SqlParameter[] paras = new SqlParameter[1];
			paras[0] = new SqlParameter(string.Format("@{0}", ACAccessLevelDetailSchema.ACTimecodePK), SqlDbType.UniqueIdentifier);
			paras[0].Value = ACTimecodePK;

			return this.GetCollection(sql, paras);
		}

	}

	public partial class ACIntervalDataService
	{
		public ACIntervalDataCollection GetByMappedUtilHoliday(Guid UtilHolidayPK)
		{
			string sql = string.Format(" WHERE [{0}].[{1}] IN (SELECT [{2}] FROM [{3}] WHERE [{4}] = @{4})", ACIntervalSchema.TableAlias, ACIntervalSchema.ACIntervalPK, ACIntvalHolidayMapSchema.ACIntervalPK, ACIntvalHolidayMapSchema.TableName, ACIntvalHolidayMapSchema.UtilHolidayPK);

			SqlParameter[] paras = new SqlParameter[1];
			paras[0] = new SqlParameter(string.Format("@{0}", ACIntvalHolidayMapSchema.UtilHolidayPK), SqlDbType.UniqueIdentifier);
			paras[0].Value = UtilHolidayPK;

			return this.GetCollection(sql, paras);
		}

		public ACIntervalDataCollection GetByMappedACTimecode(Guid ACTimecodePK)
		{
			string sql = string.Format(" WHERE [{0}].[{1}] IN (SELECT [{2}] FROM [{3}] WHERE [{4}] = @{4})", ACIntervalSchema.TableAlias, ACIntervalSchema.ACIntervalPK, ACTimecodeIntervalMapSchema.ACIntervalPK, ACTimecodeIntervalMapSchema.TableName, ACTimecodeIntervalMapSchema.ACTimecodePK);

			SqlParameter[] paras = new SqlParameter[1];
			paras[0] = new SqlParameter(string.Format("@{0}", ACTimecodeIntervalMapSchema.ACTimecodePK), SqlDbType.UniqueIdentifier);
			paras[0].Value = ACTimecodePK;

			return this.GetCollection(sql, paras);
		}

	}

	public partial class ACTimecodeDataService
	{
		public ACTimecodeDataCollection GetByMappedACMainZone(Guid ACMainZonePK)
		{
			string sql = string.Format(" WHERE [{0}].[{1}] IN (SELECT [{2}] FROM [{3}] WHERE [{4}] = @{4})", ACTimecodeSchema.TableAlias, ACTimecodeSchema.ACTimecodePK, ACAccessLevelDetailSchema.ACTimecodePK, ACAccessLevelDetailSchema.TableName, ACAccessLevelDetailSchema.ACMainZonePK);

			SqlParameter[] paras = new SqlParameter[1];
			paras[0] = new SqlParameter(string.Format("@{0}", ACAccessLevelDetailSchema.ACMainZonePK), SqlDbType.UniqueIdentifier);
			paras[0].Value = ACMainZonePK;

			return this.GetCollection(sql, paras);
		}

		public ACTimecodeDataCollection GetByMappedACInterval(Guid ACIntervalPK)
		{
			string sql = string.Format(" WHERE [{0}].[{1}] IN (SELECT [{2}] FROM [{3}] WHERE [{4}] = @{4})", ACTimecodeSchema.TableAlias, ACTimecodeSchema.ACTimecodePK, ACTimecodeIntervalMapSchema.ACTimecodePK, ACTimecodeIntervalMapSchema.TableName, ACTimecodeIntervalMapSchema.ACIntervalPK);

			SqlParameter[] paras = new SqlParameter[1];
			paras[0] = new SqlParameter(string.Format("@{0}", ACTimecodeIntervalMapSchema.ACIntervalPK), SqlDbType.UniqueIdentifier);
			paras[0].Value = ACIntervalPK;

			return this.GetCollection(sql, paras);
		}

	}

	public partial class ACOutputGroupDataService
	{
		public ACOutputGroupDataCollection GetByMappedACMainZone(Guid ACMainZonePK)
		{
			string sql = string.Format(" WHERE [{0}].[{1}] IN (SELECT [{2}] FROM [{3}] WHERE [{4}] = @{4})", ACOutputGroupSchema.TableAlias, ACOutputGroupSchema.ACOutputGroupPK, ACOutputGroupMainZoneMapSchema.ACOutputGroupPK, ACOutputGroupMainZoneMapSchema.TableName, ACOutputGroupMainZoneMapSchema.ACMainZonePK);

			SqlParameter[] paras = new SqlParameter[1];
			paras[0] = new SqlParameter(string.Format("@{0}", ACOutputGroupMainZoneMapSchema.ACMainZonePK), SqlDbType.UniqueIdentifier);
			paras[0].Value = ACMainZonePK;

			return this.GetCollection(sql, paras);
		}

	}

	public partial class ACInputGroupDataService
	{
		public ACInputGroupDataCollection GetByMappedACInput(Guid ACInputPK)
		{
			string sql = string.Format(" WHERE [{0}].[{1}] IN (SELECT [{2}] FROM [{3}] WHERE [{4}] = @{4})", ACInputGroupSchema.TableAlias, ACInputGroupSchema.ACInputGroupPK, ACInputGroupInputMapSchema.ACInputGroupPK, ACInputGroupInputMapSchema.TableName, ACInputGroupInputMapSchema.ACInputPK);

			SqlParameter[] paras = new SqlParameter[1];
			paras[0] = new SqlParameter(string.Format("@{0}", ACInputGroupInputMapSchema.ACInputPK), SqlDbType.UniqueIdentifier);
			paras[0].Value = ACInputPK;

			return this.GetCollection(sql, paras);
		}

	}

	public partial class ACInputDataService
	{
		public ACInputDataCollection GetByMappedACInputGroup(Guid ACInputGroupPK)
		{
			string sql = string.Format(" WHERE [{0}].[{1}] IN (SELECT [{2}] FROM [{3}] WHERE [{4}] = @{4})", ACInputSchema.TableAlias, ACInputSchema.ACInputPK, ACInputGroupInputMapSchema.ACInputPK, ACInputGroupInputMapSchema.TableName, ACInputGroupInputMapSchema.ACInputGroupPK);

			SqlParameter[] paras = new SqlParameter[1];
			paras[0] = new SqlParameter(string.Format("@{0}", ACInputGroupInputMapSchema.ACInputGroupPK), SqlDbType.UniqueIdentifier);
			paras[0].Value = ACInputGroupPK;

			return this.GetCollection(sql, paras);
		}

	}

	public partial class ACFunctionCardDataService
	{
		public ACFunctionCardDataCollection GetByMappedACPanel(Guid ACPanelPK)
		{
			string sql = string.Format(" WHERE [{0}].[{1}] IN (SELECT [{2}] FROM [{3}] WHERE [{4}] = @{4})", ACFunctionCardSchema.TableAlias, ACFunctionCardSchema.ACFunctionCardPK, ACPanelFunctionCardMapSchema.ACFunctionCardPK, ACPanelFunctionCardMapSchema.TableName, ACPanelFunctionCardMapSchema.ACPanelPK);

			SqlParameter[] paras = new SqlParameter[1];
			paras[0] = new SqlParameter(string.Format("@{0}", ACPanelFunctionCardMapSchema.ACPanelPK), SqlDbType.UniqueIdentifier);
			paras[0].Value = ACPanelPK;

			return this.GetCollection(sql, paras);
		}

	}

	public partial class ACAccessLevelDataService
	{
		public ACAccessLevelDataCollection GetByMappedACMainZone(Guid ACMainZonePK)
		{
			string sql = string.Format(" WHERE [{0}].[{1}] IN (SELECT [{2}] FROM [{3}] WHERE [{4}] = @{4})", ACAccessLevelSchema.TableAlias, ACAccessLevelSchema.ACAccessLevelPK, ACAccessLevelDetailSchema.ACAccessLevelPK, ACAccessLevelDetailSchema.TableName, ACAccessLevelDetailSchema.ACMainZonePK);

			SqlParameter[] paras = new SqlParameter[1];
			paras[0] = new SqlParameter(string.Format("@{0}", ACAccessLevelDetailSchema.ACMainZonePK), SqlDbType.UniqueIdentifier);
			paras[0].Value = ACMainZonePK;

			return this.GetCollection(sql, paras);
		}

	}

	public partial class UtilHolidayDataService
	{
		public UtilHolidayDataCollection GetByMappedACInterval(Guid ACIntervalPK)
		{
			string sql = string.Format(" WHERE [{0}].[{1}] IN (SELECT [{2}] FROM [{3}] WHERE [{4}] = @{4})", UtilHolidaySchema.TableAlias, UtilHolidaySchema.UtilHolidayPK, ACIntvalHolidayMapSchema.UtilHolidayPK, ACIntvalHolidayMapSchema.TableName, ACIntvalHolidayMapSchema.ACIntervalPK);

			SqlParameter[] paras = new SqlParameter[1];
			paras[0] = new SqlParameter(string.Format("@{0}", ACIntvalHolidayMapSchema.ACIntervalPK), SqlDbType.UniqueIdentifier);
			paras[0].Value = ACIntervalPK;

			return this.GetCollection(sql, paras);
		}

		public UtilHolidayDataCollection GetByMappedACPanel(Guid ACPanelPK)
		{
			string sql = string.Format(" WHERE [{0}].[{1}] IN (SELECT [{2}] FROM [{3}] WHERE [{4}] = @{4})", UtilHolidaySchema.TableAlias, UtilHolidaySchema.UtilHolidayPK, ACPanelHolidayMapSchema.UtilHolidayPK, ACPanelHolidayMapSchema.TableName, ACPanelHolidayMapSchema.ACPanelPK);

			SqlParameter[] paras = new SqlParameter[1];
			paras[0] = new SqlParameter(string.Format("@{0}", ACPanelHolidayMapSchema.ACPanelPK), SqlDbType.UniqueIdentifier);
			paras[0].Value = ACPanelPK;

			return this.GetCollection(sql, paras);
		}

		public UtilHolidayDataCollection GetByMappedBDBuilding(Guid BDBuildingPK)
		{
			string sql = string.Format(" WHERE [{0}].[{1}] IN (SELECT [{2}] FROM [{3}] WHERE [{4}] = @{4})", UtilHolidaySchema.TableAlias, UtilHolidaySchema.UtilHolidayPK, BDBuildingHolidayMapSchema.UtilHolidayPK, BDBuildingHolidayMapSchema.TableName, BDBuildingHolidayMapSchema.BDBuildingPK);

			SqlParameter[] paras = new SqlParameter[1];
			paras[0] = new SqlParameter(string.Format("@{0}", BDBuildingHolidayMapSchema.BDBuildingPK), SqlDbType.UniqueIdentifier);
			paras[0].Value = BDBuildingPK;

			return this.GetCollection(sql, paras);
		}

		public UtilHolidayDataCollection GetByMappedBDTenant(Guid BDTenantPK)
		{
			string sql = string.Format(" WHERE [{0}].[{1}] IN (SELECT [{2}] FROM [{3}] WHERE [{4}] = @{4})", UtilHolidaySchema.TableAlias, UtilHolidaySchema.UtilHolidayPK, BDTenantHolidayMapSchema.UtilHolidayPK, BDTenantHolidayMapSchema.TableName, BDTenantHolidayMapSchema.BDTenantPK);

			SqlParameter[] paras = new SqlParameter[1];
			paras[0] = new SqlParameter(string.Format("@{0}", BDTenantHolidayMapSchema.BDTenantPK), SqlDbType.UniqueIdentifier);
			paras[0].Value = BDTenantPK;

			return this.GetCollection(sql, paras);
		}

	}

	public partial class UsrAccountDataService
	{
		public UsrAccountDataCollection GetByMappedBDBuilding(Guid BDBuildingPK)
		{
			string sql = string.Format(" WHERE [{0}].[{1}] IN (SELECT [{2}] FROM [{3}] WHERE [{4}] = @{4})", UsrAccountSchema.TableAlias, UsrAccountSchema.UsrAccountPK, UsrAccountBuildingMapSchema.UsrAccountPK, UsrAccountBuildingMapSchema.TableName, UsrAccountBuildingMapSchema.BDBuildingPK);

			SqlParameter[] paras = new SqlParameter[1];
			paras[0] = new SqlParameter(string.Format("@{0}", UsrAccountBuildingMapSchema.BDBuildingPK), SqlDbType.UniqueIdentifier);
			paras[0].Value = BDBuildingPK;

			return this.GetCollection(sql, paras);
		}

		public UsrAccountDataCollection GetByMappedBDTenant(Guid BDTenantPK)
		{
			string sql = string.Format(" WHERE [{0}].[{1}] IN (SELECT [{2}] FROM [{3}] WHERE [{4}] = @{4})", UsrAccountSchema.TableAlias, UsrAccountSchema.UsrAccountPK, UsrAccountTenantMapSchema.UsrAccountPK, UsrAccountTenantMapSchema.TableName, UsrAccountTenantMapSchema.BDTenantPK);

			SqlParameter[] paras = new SqlParameter[1];
			paras[0] = new SqlParameter(string.Format("@{0}", UsrAccountTenantMapSchema.BDTenantPK), SqlDbType.UniqueIdentifier);
			paras[0].Value = BDTenantPK;

			return this.GetCollection(sql, paras);
		}

	}

	public partial class ACPanelDataService
	{
		public ACPanelDataCollection GetByMappedUtilHoliday(Guid UtilHolidayPK)
		{
			string sql = string.Format(" WHERE [{0}].[{1}] IN (SELECT [{2}] FROM [{3}] WHERE [{4}] = @{4})", ACPanelSchema.TableAlias, ACPanelSchema.ACPanelPK, ACPanelHolidayMapSchema.ACPanelPK, ACPanelHolidayMapSchema.TableName, ACPanelHolidayMapSchema.UtilHolidayPK);

			SqlParameter[] paras = new SqlParameter[1];
			paras[0] = new SqlParameter(string.Format("@{0}", ACPanelHolidayMapSchema.UtilHolidayPK), SqlDbType.UniqueIdentifier);
			paras[0].Value = UtilHolidayPK;

			return this.GetCollection(sql, paras);
		}

		public ACPanelDataCollection GetByMappedACFunctionCard(Guid ACFunctionCardPK)
		{
			string sql = string.Format(" WHERE [{0}].[{1}] IN (SELECT [{2}] FROM [{3}] WHERE [{4}] = @{4})", ACPanelSchema.TableAlias, ACPanelSchema.ACPanelPK, ACPanelFunctionCardMapSchema.ACPanelPK, ACPanelFunctionCardMapSchema.TableName, ACPanelFunctionCardMapSchema.ACFunctionCardPK);

			SqlParameter[] paras = new SqlParameter[1];
			paras[0] = new SqlParameter(string.Format("@{0}", ACPanelFunctionCardMapSchema.ACFunctionCardPK), SqlDbType.UniqueIdentifier);
			paras[0].Value = ACFunctionCardPK;

			return this.GetCollection(sql, paras);
		}

	}

}
