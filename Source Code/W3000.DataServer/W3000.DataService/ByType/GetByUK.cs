using System;
using System.Data;
using W3000.Data;
using W3000.Schema;
using System.Data.SqlClient;

namespace W3000.DataService
{
	public partial class ACIntvalHolidayMapDataService
	{
		public ACIntvalHolidayMapData GetByUK( System.Guid ACIntervalPK, System.Guid UtilHolidayPK)
		{
			string sqlACIntervalPK = string.Format(" WHERE  [{0}].[{1}] = @{1}", ACIntvalHolidayMapSchema.TableAlias, ACIntvalHolidayMapSchema.ACIntervalPK); 
			string sqlUtilHolidayPK = string.Format(" AND  [{0}].[{1}] = @{1}", ACIntvalHolidayMapSchema.TableAlias, ACIntvalHolidayMapSchema.UtilHolidayPK); 

			SqlParameter[] paras = new SqlParameter[2];
			paras[0] = new SqlParameter(string.Format("@{0}", ACIntvalHolidayMapSchema.ACIntervalPK), SqlDbType.UniqueIdentifier);
			paras[0].Value = ACIntervalPK;
			paras[1] = new SqlParameter(string.Format("@{0}", ACIntvalHolidayMapSchema.UtilHolidayPK), SqlDbType.UniqueIdentifier);
			paras[1].Value = UtilHolidayPK;

			return this.GetEntity(sqlACIntervalPK + sqlUtilHolidayPK , paras);
		}
	}

	public partial class ACAccessLevelDetailDataService
	{
		public ACAccessLevelDetailData GetByUK( System.Guid ACAccessLevelPK, System.Guid ACMainZonePK)
		{
			string sqlACAccessLevelPK = string.Format(" WHERE  [{0}].[{1}] = @{1}", ACAccessLevelDetailSchema.TableAlias, ACAccessLevelDetailSchema.ACAccessLevelPK); 
			string sqlACMainZonePK = string.Format(" AND  [{0}].[{1}] = @{1}", ACAccessLevelDetailSchema.TableAlias, ACAccessLevelDetailSchema.ACMainZonePK); 

			SqlParameter[] paras = new SqlParameter[2];
			paras[0] = new SqlParameter(string.Format("@{0}", ACAccessLevelDetailSchema.ACAccessLevelPK), SqlDbType.UniqueIdentifier);
			paras[0].Value = ACAccessLevelPK;
			paras[1] = new SqlParameter(string.Format("@{0}", ACAccessLevelDetailSchema.ACMainZonePK), SqlDbType.UniqueIdentifier);
			paras[1].Value = ACMainZonePK;

			return this.GetEntity(sqlACAccessLevelPK + sqlACMainZonePK , paras);
		}
	}

	public partial class UsrAccountBuildingMapDataService
	{
		public UsrAccountBuildingMapData GetByUK( System.Guid UsrAccountPK, System.Guid BDBuildingPK)
		{
			string sqlUsrAccountPK = string.Format(" WHERE  [{0}].[{1}] = @{1}", UsrAccountBuildingMapSchema.TableAlias, UsrAccountBuildingMapSchema.UsrAccountPK); 
			string sqlBDBuildingPK = string.Format(" AND  [{0}].[{1}] = @{1}", UsrAccountBuildingMapSchema.TableAlias, UsrAccountBuildingMapSchema.BDBuildingPK); 

			SqlParameter[] paras = new SqlParameter[2];
			paras[0] = new SqlParameter(string.Format("@{0}", UsrAccountBuildingMapSchema.UsrAccountPK), SqlDbType.UniqueIdentifier);
			paras[0].Value = UsrAccountPK;
			paras[1] = new SqlParameter(string.Format("@{0}", UsrAccountBuildingMapSchema.BDBuildingPK), SqlDbType.UniqueIdentifier);
			paras[1].Value = BDBuildingPK;

			return this.GetEntity(sqlUsrAccountPK + sqlBDBuildingPK , paras);
		}
	}

	public partial class BDBuildingDataService
	{
		public BDBuildingData GetByAddress1( System.String Address1)
		{
			string sqlAddress1 = string.Format(" WHERE  [{0}].[{1}] = @{1}", BDBuildingSchema.TableAlias, BDBuildingSchema.Address1); 

			SqlParameter[] paras = new SqlParameter[1];
			paras[0] = new SqlParameter(string.Format("@{0}", BDBuildingSchema.Address1), SqlDbType.VarChar);
			paras[0].Value = Address1;

			return this.GetEntity(sqlAddress1 , paras);
		}
		public BDBuildingData GetByBuildingID( System.Int32 BuildingID)
		{
			string sqlBuildingID = string.Format(" WHERE  [{0}].[{1}] = @{1}", BDBuildingSchema.TableAlias, BDBuildingSchema.BuildingID); 

			SqlParameter[] paras = new SqlParameter[1];
			paras[0] = new SqlParameter(string.Format("@{0}", BDBuildingSchema.BuildingID), SqlDbType.Int);
			paras[0].Value = BuildingID;

			return this.GetEntity(sqlBuildingID , paras);
		}
	}

	public partial class BDTenantDataService
	{
		public BDTenantData GetByUK( System.Guid BDBuildingPK, System.String Tenant)
		{
			string sqlBDBuildingPK = string.Format(" WHERE  [{0}].[{1}] = @{1}", BDTenantSchema.TableAlias, BDTenantSchema.BDBuildingPK); 
			string sqlTenant = string.Format(" AND  [{0}].[{1}] = @{1}", BDTenantSchema.TableAlias, BDTenantSchema.Tenant); 

			SqlParameter[] paras = new SqlParameter[2];
			paras[0] = new SqlParameter(string.Format("@{0}", BDTenantSchema.BDBuildingPK), SqlDbType.UniqueIdentifier);
			paras[0].Value = BDBuildingPK;
			paras[1] = new SqlParameter(string.Format("@{0}", BDTenantSchema.Tenant), SqlDbType.VarChar);
			paras[1].Value = Tenant;

			return this.GetEntity(sqlBDBuildingPK + sqlTenant , paras);
		}
	}

	public partial class UtilSettingCategoryDataService
	{
		public UtilSettingCategoryData GetByUK( System.Int32 SettingCategoryID, System.String InstanceName)
		{
			string sqlSettingCategoryID = string.Format(" WHERE  [{0}].[{1}] = @{1}", UtilSettingCategorySchema.TableAlias, UtilSettingCategorySchema.SettingCategoryID); 
			string sqlInstanceName = string.Format(" AND  [{0}].[{1}] = @{1}", UtilSettingCategorySchema.TableAlias, UtilSettingCategorySchema.InstanceName); 

			SqlParameter[] paras = new SqlParameter[2];
			paras[0] = new SqlParameter(string.Format("@{0}", UtilSettingCategorySchema.SettingCategoryID), SqlDbType.Int);
			paras[0].Value = SettingCategoryID;
			paras[1] = new SqlParameter(string.Format("@{0}", UtilSettingCategorySchema.InstanceName), SqlDbType.VarChar);
			paras[1].Value = InstanceName;

			return this.GetEntity(sqlSettingCategoryID + sqlInstanceName , paras);
		}
	}

	public partial class UtilSettingDetailDataService
	{
		public UtilSettingDetailData GetByUK( System.Guid UtilSettingCategoryPK, System.String FieldName)
		{
			string sqlUtilSettingCategoryPK = string.Format(" WHERE  [{0}].[{1}] = @{1}", UtilSettingDetailSchema.TableAlias, UtilSettingDetailSchema.UtilSettingCategoryPK); 
			string sqlFieldName = string.Format(" AND  [{0}].[{1}] = @{1}", UtilSettingDetailSchema.TableAlias, UtilSettingDetailSchema.FieldName); 

			SqlParameter[] paras = new SqlParameter[2];
			paras[0] = new SqlParameter(string.Format("@{0}", UtilSettingDetailSchema.UtilSettingCategoryPK), SqlDbType.UniqueIdentifier);
			paras[0].Value = UtilSettingCategoryPK;
			paras[1] = new SqlParameter(string.Format("@{0}", UtilSettingDetailSchema.FieldName), SqlDbType.VarChar);
			paras[1].Value = FieldName;

			return this.GetEntity(sqlUtilSettingCategoryPK + sqlFieldName , paras);
		}
	}

	public partial class ACOutputGroupMainZoneMapDataService
	{
		public ACOutputGroupMainZoneMapData GetByUK( System.Guid ACOutputGroupPK, System.Guid ACMainZonePK)
		{
			string sqlACOutputGroupPK = string.Format(" WHERE  [{0}].[{1}] = @{1}", ACOutputGroupMainZoneMapSchema.TableAlias, ACOutputGroupMainZoneMapSchema.ACOutputGroupPK); 
			string sqlACMainZonePK = string.Format(" AND  [{0}].[{1}] = @{1}", ACOutputGroupMainZoneMapSchema.TableAlias, ACOutputGroupMainZoneMapSchema.ACMainZonePK); 

			SqlParameter[] paras = new SqlParameter[2];
			paras[0] = new SqlParameter(string.Format("@{0}", ACOutputGroupMainZoneMapSchema.ACOutputGroupPK), SqlDbType.UniqueIdentifier);
			paras[0].Value = ACOutputGroupPK;
			paras[1] = new SqlParameter(string.Format("@{0}", ACOutputGroupMainZoneMapSchema.ACMainZonePK), SqlDbType.UniqueIdentifier);
			paras[1].Value = ACMainZonePK;

			return this.GetEntity(sqlACOutputGroupPK + sqlACMainZonePK , paras);
		}
	}

	public partial class ACCardHolderDataService
	{
		public ACCardHolderData GetByUK( System.Int32 Sitecode, System.Int32 Embossed, System.Int32 CardTypeID)
		{
			string sqlSitecode = string.Format(" WHERE  [{0}].[{1}] = @{1}", ACCardHolderSchema.TableAlias, ACCardHolderSchema.Sitecode); 
			string sqlEmbossed = string.Format(" AND  [{0}].[{1}] = @{1}", ACCardHolderSchema.TableAlias, ACCardHolderSchema.Embossed); 
			string sqlCardTypeID = string.Format(" AND  [{0}].[{1}] = @{1}", ACCardHolderSchema.TableAlias, ACCardHolderSchema.CardTypeID); 

			SqlParameter[] paras = new SqlParameter[3];
			paras[0] = new SqlParameter(string.Format("@{0}", ACCardHolderSchema.Sitecode), SqlDbType.Int);
			paras[0].Value = Sitecode;
			paras[1] = new SqlParameter(string.Format("@{0}", ACCardHolderSchema.Embossed), SqlDbType.Int);
			paras[1].Value = Embossed;
			paras[2] = new SqlParameter(string.Format("@{0}", ACCardHolderSchema.CardTypeID), SqlDbType.Int);
			paras[2].Value = CardTypeID;

			return this.GetEntity(sqlSitecode + sqlEmbossed + sqlCardTypeID , paras);
		}
		public ACCardHolderData GetByUK1( System.Int32 Sitecode, System.Int32 Encoded, System.Int32 CardTypeID)
		{
			string sqlSitecode = string.Format(" WHERE  [{0}].[{1}] = @{1}", ACCardHolderSchema.TableAlias, ACCardHolderSchema.Sitecode); 
			string sqlEncoded = string.Format(" AND  [{0}].[{1}] = @{1}", ACCardHolderSchema.TableAlias, ACCardHolderSchema.Encoded); 
			string sqlCardTypeID = string.Format(" AND  [{0}].[{1}] = @{1}", ACCardHolderSchema.TableAlias, ACCardHolderSchema.CardTypeID); 

			SqlParameter[] paras = new SqlParameter[3];
			paras[0] = new SqlParameter(string.Format("@{0}", ACCardHolderSchema.Sitecode), SqlDbType.Int);
			paras[0].Value = Sitecode;
			paras[1] = new SqlParameter(string.Format("@{0}", ACCardHolderSchema.Encoded), SqlDbType.Int);
			paras[1].Value = Encoded;
			paras[2] = new SqlParameter(string.Format("@{0}", ACCardHolderSchema.CardTypeID), SqlDbType.Int);
			paras[2].Value = CardTypeID;

			return this.GetEntity(sqlSitecode + sqlEncoded + sqlCardTypeID , paras);
		}
	}

	public partial class ACMainZoneDataService
	{
		public ACMainZoneData GetByUK( System.Guid ACPanelPK, System.Byte PanelZoneID)
		{
			string sqlACPanelPK = string.Format(" WHERE  [{0}].[{1}] = @{1}", ACMainZoneSchema.TableAlias, ACMainZoneSchema.ACPanelPK); 
			string sqlPanelZoneID = string.Format(" AND  [{0}].[{1}] = @{1}", ACMainZoneSchema.TableAlias, ACMainZoneSchema.PanelZoneID); 

			SqlParameter[] paras = new SqlParameter[2];
			paras[0] = new SqlParameter(string.Format("@{0}", ACMainZoneSchema.ACPanelPK), SqlDbType.UniqueIdentifier);
			paras[0].Value = ACPanelPK;
			paras[1] = new SqlParameter(string.Format("@{0}", ACMainZoneSchema.PanelZoneID), SqlDbType.TinyInt);
			paras[1].Value = PanelZoneID;

			return this.GetEntity(sqlACPanelPK + sqlPanelZoneID , paras);
		}
	}

	public partial class ACIntervalDataService
	{
		public ACIntervalData GetByUK( System.Guid BDBuildingPK, System.Int16 IVID)
		{
			string sqlBDBuildingPK = string.Format(" WHERE  [{0}].[{1}] = @{1}", ACIntervalSchema.TableAlias, ACIntervalSchema.BDBuildingPK); 
			string sqlIVID = string.Format(" AND  [{0}].[{1}] = @{1}", ACIntervalSchema.TableAlias, ACIntervalSchema.IVID); 

			SqlParameter[] paras = new SqlParameter[2];
			paras[0] = new SqlParameter(string.Format("@{0}", ACIntervalSchema.BDBuildingPK), SqlDbType.UniqueIdentifier);
			paras[0].Value = BDBuildingPK;
			paras[1] = new SqlParameter(string.Format("@{0}", ACIntervalSchema.IVID), SqlDbType.SmallInt);
			paras[1].Value = IVID;

			return this.GetEntity(sqlBDBuildingPK + sqlIVID , paras);
		}
	}

	public partial class ACPanelHolidayMapDataService
	{
		public ACPanelHolidayMapData GetByUK( System.Guid ACPanelPK, System.Guid UtilHolidayPK)
		{
			string sqlACPanelPK = string.Format(" WHERE  [{0}].[{1}] = @{1}", ACPanelHolidayMapSchema.TableAlias, ACPanelHolidayMapSchema.ACPanelPK); 
			string sqlUtilHolidayPK = string.Format(" AND  [{0}].[{1}] = @{1}", ACPanelHolidayMapSchema.TableAlias, ACPanelHolidayMapSchema.UtilHolidayPK); 

			SqlParameter[] paras = new SqlParameter[2];
			paras[0] = new SqlParameter(string.Format("@{0}", ACPanelHolidayMapSchema.ACPanelPK), SqlDbType.UniqueIdentifier);
			paras[0].Value = ACPanelPK;
			paras[1] = new SqlParameter(string.Format("@{0}", ACPanelHolidayMapSchema.UtilHolidayPK), SqlDbType.UniqueIdentifier);
			paras[1].Value = UtilHolidayPK;

			return this.GetEntity(sqlACPanelPK + sqlUtilHolidayPK , paras);
		}
	}

	public partial class ACTimecodeDataService
	{
		public ACTimecodeData GetByUK( System.Guid BDBuildingPK, System.Int16 TCID)
		{
			string sqlBDBuildingPK = string.Format(" WHERE  [{0}].[{1}] = @{1}", ACTimecodeSchema.TableAlias, ACTimecodeSchema.BDBuildingPK); 
			string sqlTCID = string.Format(" AND  [{0}].[{1}] = @{1}", ACTimecodeSchema.TableAlias, ACTimecodeSchema.TCID); 

			SqlParameter[] paras = new SqlParameter[2];
			paras[0] = new SqlParameter(string.Format("@{0}", ACTimecodeSchema.BDBuildingPK), SqlDbType.UniqueIdentifier);
			paras[0].Value = BDBuildingPK;
			paras[1] = new SqlParameter(string.Format("@{0}", ACTimecodeSchema.TCID), SqlDbType.SmallInt);
			paras[1].Value = TCID;

			return this.GetEntity(sqlBDBuildingPK + sqlTCID , paras);
		}
	}

	public partial class ACTimecodeIntervalMapDataService
	{
		public ACTimecodeIntervalMapData GetByUK( System.Guid ACTimecodePK, System.Guid ACIntervalPK)
		{
			string sqlACTimecodePK = string.Format(" WHERE  [{0}].[{1}] = @{1}", ACTimecodeIntervalMapSchema.TableAlias, ACTimecodeIntervalMapSchema.ACTimecodePK); 
			string sqlACIntervalPK = string.Format(" AND  [{0}].[{1}] = @{1}", ACTimecodeIntervalMapSchema.TableAlias, ACTimecodeIntervalMapSchema.ACIntervalPK); 

			SqlParameter[] paras = new SqlParameter[2];
			paras[0] = new SqlParameter(string.Format("@{0}", ACTimecodeIntervalMapSchema.ACTimecodePK), SqlDbType.UniqueIdentifier);
			paras[0].Value = ACTimecodePK;
			paras[1] = new SqlParameter(string.Format("@{0}", ACTimecodeIntervalMapSchema.ACIntervalPK), SqlDbType.UniqueIdentifier);
			paras[1].Value = ACIntervalPK;

			return this.GetEntity(sqlACTimecodePK + sqlACIntervalPK , paras);
		}
	}

	public partial class ACAMFormatDataService
	{
		public ACAMFormatData GetByUK( System.Guid BDBuildingPK, System.Int16 AMFID)
		{
			string sqlBDBuildingPK = string.Format(" WHERE  [{0}].[{1}] = @{1}", ACAMFormatSchema.TableAlias, ACAMFormatSchema.BDBuildingPK); 
			string sqlAMFID = string.Format(" AND  [{0}].[{1}] = @{1}", ACAMFormatSchema.TableAlias, ACAMFormatSchema.AMFID); 

			SqlParameter[] paras = new SqlParameter[2];
			paras[0] = new SqlParameter(string.Format("@{0}", ACAMFormatSchema.BDBuildingPK), SqlDbType.UniqueIdentifier);
			paras[0].Value = BDBuildingPK;
			paras[1] = new SqlParameter(string.Format("@{0}", ACAMFormatSchema.AMFID), SqlDbType.SmallInt);
			paras[1].Value = AMFID;

			return this.GetEntity(sqlBDBuildingPK + sqlAMFID , paras);
		}
	}

	public partial class BDBuildingHolidayMapDataService
	{
		public BDBuildingHolidayMapData GetByUK( System.Guid BDBuildingPK, System.Guid UtilHolidayPK)
		{
			string sqlBDBuildingPK = string.Format(" WHERE  [{0}].[{1}] = @{1}", BDBuildingHolidayMapSchema.TableAlias, BDBuildingHolidayMapSchema.BDBuildingPK); 
			string sqlUtilHolidayPK = string.Format(" AND  [{0}].[{1}] = @{1}", BDBuildingHolidayMapSchema.TableAlias, BDBuildingHolidayMapSchema.UtilHolidayPK); 

			SqlParameter[] paras = new SqlParameter[2];
			paras[0] = new SqlParameter(string.Format("@{0}", BDBuildingHolidayMapSchema.BDBuildingPK), SqlDbType.UniqueIdentifier);
			paras[0].Value = BDBuildingPK;
			paras[1] = new SqlParameter(string.Format("@{0}", BDBuildingHolidayMapSchema.UtilHolidayPK), SqlDbType.UniqueIdentifier);
			paras[1].Value = UtilHolidayPK;

			return this.GetEntity(sqlBDBuildingPK + sqlUtilHolidayPK , paras);
		}
	}

	public partial class ACOutputGroupDataService
	{
		public ACOutputGroupData GetByUK( System.Guid ACPanelPK, System.Byte GroupID)
		{
			string sqlACPanelPK = string.Format(" WHERE  [{0}].[{1}] = @{1}", ACOutputGroupSchema.TableAlias, ACOutputGroupSchema.ACPanelPK); 
			string sqlGroupID = string.Format(" AND  [{0}].[{1}] = @{1}", ACOutputGroupSchema.TableAlias, ACOutputGroupSchema.GroupID); 

			SqlParameter[] paras = new SqlParameter[2];
			paras[0] = new SqlParameter(string.Format("@{0}", ACOutputGroupSchema.ACPanelPK), SqlDbType.UniqueIdentifier);
			paras[0].Value = ACPanelPK;
			paras[1] = new SqlParameter(string.Format("@{0}", ACOutputGroupSchema.GroupID), SqlDbType.TinyInt);
			paras[1].Value = GroupID;

			return this.GetEntity(sqlACPanelPK + sqlGroupID , paras);
		}
	}

	public partial class BDTenantHolidayMapDataService
	{
		public BDTenantHolidayMapData GetByUK( System.Guid BDTenantPK, System.Guid UtilHolidayPK)
		{
			string sqlBDTenantPK = string.Format(" WHERE  [{0}].[{1}] = @{1}", BDTenantHolidayMapSchema.TableAlias, BDTenantHolidayMapSchema.BDTenantPK); 
			string sqlUtilHolidayPK = string.Format(" AND  [{0}].[{1}] = @{1}", BDTenantHolidayMapSchema.TableAlias, BDTenantHolidayMapSchema.UtilHolidayPK); 

			SqlParameter[] paras = new SqlParameter[2];
			paras[0] = new SqlParameter(string.Format("@{0}", BDTenantHolidayMapSchema.BDTenantPK), SqlDbType.UniqueIdentifier);
			paras[0].Value = BDTenantPK;
			paras[1] = new SqlParameter(string.Format("@{0}", BDTenantHolidayMapSchema.UtilHolidayPK), SqlDbType.UniqueIdentifier);
			paras[1].Value = UtilHolidayPK;

			return this.GetEntity(sqlBDTenantPK + sqlUtilHolidayPK , paras);
		}
	}

	public partial class ACInputGroupDataService
	{
		public ACInputGroupData GetByUK( System.Guid ACPanelPK, System.Byte GroupID)
		{
			string sqlACPanelPK = string.Format(" WHERE  [{0}].[{1}] = @{1}", ACInputGroupSchema.TableAlias, ACInputGroupSchema.ACPanelPK); 
			string sqlGroupID = string.Format(" AND  [{0}].[{1}] = @{1}", ACInputGroupSchema.TableAlias, ACInputGroupSchema.GroupID); 

			SqlParameter[] paras = new SqlParameter[2];
			paras[0] = new SqlParameter(string.Format("@{0}", ACInputGroupSchema.ACPanelPK), SqlDbType.UniqueIdentifier);
			paras[0].Value = ACPanelPK;
			paras[1] = new SqlParameter(string.Format("@{0}", ACInputGroupSchema.GroupID), SqlDbType.TinyInt);
			paras[1].Value = GroupID;

			return this.GetEntity(sqlACPanelPK + sqlGroupID , paras);
		}
	}

	public partial class ACInputDataService
	{
		public ACInputData GetByUK( System.Guid ACPanelPK, System.Byte PanelZoneID)
		{
			string sqlACPanelPK = string.Format(" WHERE  [{0}].[{1}] = @{1}", ACInputSchema.TableAlias, ACInputSchema.ACPanelPK); 
			string sqlPanelZoneID = string.Format(" AND  [{0}].[{1}] = @{1}", ACInputSchema.TableAlias, ACInputSchema.PanelZoneID); 

			SqlParameter[] paras = new SqlParameter[2];
			paras[0] = new SqlParameter(string.Format("@{0}", ACInputSchema.ACPanelPK), SqlDbType.UniqueIdentifier);
			paras[0].Value = ACPanelPK;
			paras[1] = new SqlParameter(string.Format("@{0}", ACInputSchema.PanelZoneID), SqlDbType.TinyInt);
			paras[1].Value = PanelZoneID;

			return this.GetEntity(sqlACPanelPK + sqlPanelZoneID , paras);
		}
	}

	public partial class ACFunctionCardDataService
	{
		public ACFunctionCardData GetByUK( System.Int32 Sitecode, System.Int32 Embossed, System.Int32 CardTypeID)
		{
			string sqlSitecode = string.Format(" WHERE  [{0}].[{1}] = @{1}", ACFunctionCardSchema.TableAlias, ACFunctionCardSchema.Sitecode); 
			string sqlEmbossed = string.Format(" AND  [{0}].[{1}] = @{1}", ACFunctionCardSchema.TableAlias, ACFunctionCardSchema.Embossed); 
			string sqlCardTypeID = string.Format(" AND  [{0}].[{1}] = @{1}", ACFunctionCardSchema.TableAlias, ACFunctionCardSchema.CardTypeID); 

			SqlParameter[] paras = new SqlParameter[3];
			paras[0] = new SqlParameter(string.Format("@{0}", ACFunctionCardSchema.Sitecode), SqlDbType.Int);
			paras[0].Value = Sitecode;
			paras[1] = new SqlParameter(string.Format("@{0}", ACFunctionCardSchema.Embossed), SqlDbType.Int);
			paras[1].Value = Embossed;
			paras[2] = new SqlParameter(string.Format("@{0}", ACFunctionCardSchema.CardTypeID), SqlDbType.Int);
			paras[2].Value = CardTypeID;

			return this.GetEntity(sqlSitecode + sqlEmbossed + sqlCardTypeID , paras);
		}
		public ACFunctionCardData GetByUK1( System.Int32 Sitecode, System.Int32 Encoded, System.Int32 CardTypeID)
		{
			string sqlSitecode = string.Format(" WHERE  [{0}].[{1}] = @{1}", ACFunctionCardSchema.TableAlias, ACFunctionCardSchema.Sitecode); 
			string sqlEncoded = string.Format(" AND  [{0}].[{1}] = @{1}", ACFunctionCardSchema.TableAlias, ACFunctionCardSchema.Encoded); 
			string sqlCardTypeID = string.Format(" AND  [{0}].[{1}] = @{1}", ACFunctionCardSchema.TableAlias, ACFunctionCardSchema.CardTypeID); 

			SqlParameter[] paras = new SqlParameter[3];
			paras[0] = new SqlParameter(string.Format("@{0}", ACFunctionCardSchema.Sitecode), SqlDbType.Int);
			paras[0].Value = Sitecode;
			paras[1] = new SqlParameter(string.Format("@{0}", ACFunctionCardSchema.Encoded), SqlDbType.Int);
			paras[1].Value = Encoded;
			paras[2] = new SqlParameter(string.Format("@{0}", ACFunctionCardSchema.CardTypeID), SqlDbType.Int);
			paras[2].Value = CardTypeID;

			return this.GetEntity(sqlSitecode + sqlEncoded + sqlCardTypeID , paras);
		}
	}

	public partial class ACAccessLevelDataService
	{
		public ACAccessLevelData GetByUK( System.Guid BDBuildingPK, System.Int16 AccessLevelID)
		{
			string sqlBDBuildingPK = string.Format(" WHERE  [{0}].[{1}] = @{1}", ACAccessLevelSchema.TableAlias, ACAccessLevelSchema.BDBuildingPK); 
			string sqlAccessLevelID = string.Format(" AND  [{0}].[{1}] = @{1}", ACAccessLevelSchema.TableAlias, ACAccessLevelSchema.AccessLevelID); 

			SqlParameter[] paras = new SqlParameter[2];
			paras[0] = new SqlParameter(string.Format("@{0}", ACAccessLevelSchema.BDBuildingPK), SqlDbType.UniqueIdentifier);
			paras[0].Value = BDBuildingPK;
			paras[1] = new SqlParameter(string.Format("@{0}", ACAccessLevelSchema.AccessLevelID), SqlDbType.SmallInt);
			paras[1].Value = AccessLevelID;

			return this.GetEntity(sqlBDBuildingPK + sqlAccessLevelID , paras);
		}
	}

	public partial class ACPanelFunctionCardMapDataService
	{
		public ACPanelFunctionCardMapData GetByUK( System.Guid ACPanelPK, System.Guid ACFunctionCardPK)
		{
			string sqlACPanelPK = string.Format(" WHERE  [{0}].[{1}] = @{1}", ACPanelFunctionCardMapSchema.TableAlias, ACPanelFunctionCardMapSchema.ACPanelPK); 
			string sqlACFunctionCardPK = string.Format(" AND  [{0}].[{1}] = @{1}", ACPanelFunctionCardMapSchema.TableAlias, ACPanelFunctionCardMapSchema.ACFunctionCardPK); 

			SqlParameter[] paras = new SqlParameter[2];
			paras[0] = new SqlParameter(string.Format("@{0}", ACPanelFunctionCardMapSchema.ACPanelPK), SqlDbType.UniqueIdentifier);
			paras[0].Value = ACPanelPK;
			paras[1] = new SqlParameter(string.Format("@{0}", ACPanelFunctionCardMapSchema.ACFunctionCardPK), SqlDbType.UniqueIdentifier);
			paras[1].Value = ACFunctionCardPK;

			return this.GetEntity(sqlACPanelPK + sqlACFunctionCardPK , paras);
		}
	}

	public partial class UtilHolidayDataService
	{
		public UtilHolidayData GetByUK( System.Int32 CountryID, System.String Holiday)
		{
			string sqlCountryID = string.Format(" WHERE  [{0}].[{1}] = @{1}", UtilHolidaySchema.TableAlias, UtilHolidaySchema.CountryID); 
			string sqlHoliday = string.Format(" AND  [{0}].[{1}] = @{1}", UtilHolidaySchema.TableAlias, UtilHolidaySchema.Holiday); 

			SqlParameter[] paras = new SqlParameter[2];
			paras[0] = new SqlParameter(string.Format("@{0}", UtilHolidaySchema.CountryID), SqlDbType.Int);
			paras[0].Value = CountryID;
			paras[1] = new SqlParameter(string.Format("@{0}", UtilHolidaySchema.Holiday), SqlDbType.VarChar);
			paras[1].Value = Holiday;

			return this.GetEntity(sqlCountryID + sqlHoliday , paras);
		}
		public UtilHolidayData GetByUK1( System.DateTime Date, System.Int32 CountryID)
		{
			string sqlDate = string.Format(" WHERE  [{0}].[{1}] = @{1}", UtilHolidaySchema.TableAlias, UtilHolidaySchema.Date); 
			string sqlCountryID = string.Format(" AND  [{0}].[{1}] = @{1}", UtilHolidaySchema.TableAlias, UtilHolidaySchema.CountryID); 

			SqlParameter[] paras = new SqlParameter[2];
			paras[0] = new SqlParameter(string.Format("@{0}", UtilHolidaySchema.Date), SqlDbType.DateTime);
			paras[0].Value = Date;
			paras[1] = new SqlParameter(string.Format("@{0}", UtilHolidaySchema.CountryID), SqlDbType.Int);
			paras[1].Value = CountryID;

			return this.GetEntity(sqlDate + sqlCountryID , paras);
		}
	}

	public partial class UsrAccountDataService
	{
		public UsrAccountData GetByUserID( System.String UserID)
		{
			string sqlUserID = string.Format(" WHERE  [{0}].[{1}] = @{1}", UsrAccountSchema.TableAlias, UsrAccountSchema.UserID); 

			SqlParameter[] paras = new SqlParameter[1];
			paras[0] = new SqlParameter(string.Format("@{0}", UsrAccountSchema.UserID), SqlDbType.VarChar);
			paras[0].Value = UserID;

			return this.GetEntity(sqlUserID , paras);
		}
	}

	public partial class ACMasterCardDataService
	{
		public ACMasterCardData GetByUK( System.Int32 Sitecode, System.Int32 Embossed, System.Int32 CardTypeID)
		{
			string sqlSitecode = string.Format(" WHERE  [{0}].[{1}] = @{1}", ACMasterCardSchema.TableAlias, ACMasterCardSchema.Sitecode); 
			string sqlEmbossed = string.Format(" AND  [{0}].[{1}] = @{1}", ACMasterCardSchema.TableAlias, ACMasterCardSchema.Embossed); 
			string sqlCardTypeID = string.Format(" AND  [{0}].[{1}] = @{1}", ACMasterCardSchema.TableAlias, ACMasterCardSchema.CardTypeID); 

			SqlParameter[] paras = new SqlParameter[3];
			paras[0] = new SqlParameter(string.Format("@{0}", ACMasterCardSchema.Sitecode), SqlDbType.Int);
			paras[0].Value = Sitecode;
			paras[1] = new SqlParameter(string.Format("@{0}", ACMasterCardSchema.Embossed), SqlDbType.Int);
			paras[1].Value = Embossed;
			paras[2] = new SqlParameter(string.Format("@{0}", ACMasterCardSchema.CardTypeID), SqlDbType.Int);
			paras[2].Value = CardTypeID;

			return this.GetEntity(sqlSitecode + sqlEmbossed + sqlCardTypeID , paras);
		}
		public ACMasterCardData GetByUK1( System.Int32 Sitecode, System.Int32 Encoded, System.Int32 CardTypeID)
		{
			string sqlSitecode = string.Format(" WHERE  [{0}].[{1}] = @{1}", ACMasterCardSchema.TableAlias, ACMasterCardSchema.Sitecode); 
			string sqlEncoded = string.Format(" AND  [{0}].[{1}] = @{1}", ACMasterCardSchema.TableAlias, ACMasterCardSchema.Encoded); 
			string sqlCardTypeID = string.Format(" AND  [{0}].[{1}] = @{1}", ACMasterCardSchema.TableAlias, ACMasterCardSchema.CardTypeID); 

			SqlParameter[] paras = new SqlParameter[3];
			paras[0] = new SqlParameter(string.Format("@{0}", ACMasterCardSchema.Sitecode), SqlDbType.Int);
			paras[0].Value = Sitecode;
			paras[1] = new SqlParameter(string.Format("@{0}", ACMasterCardSchema.Encoded), SqlDbType.Int);
			paras[1].Value = Encoded;
			paras[2] = new SqlParameter(string.Format("@{0}", ACMasterCardSchema.CardTypeID), SqlDbType.Int);
			paras[2].Value = CardTypeID;

			return this.GetEntity(sqlSitecode + sqlEncoded + sqlCardTypeID , paras);
		}
	}

	public partial class ACSupervisoryDataService
	{
		public ACSupervisoryData GetByUK( System.Guid ACPanelPK, System.Byte PanelZoneID)
		{
			string sqlACPanelPK = string.Format(" WHERE  [{0}].[{1}] = @{1}", ACSupervisorySchema.TableAlias, ACSupervisorySchema.ACPanelPK); 
			string sqlPanelZoneID = string.Format(" AND  [{0}].[{1}] = @{1}", ACSupervisorySchema.TableAlias, ACSupervisorySchema.PanelZoneID); 

			SqlParameter[] paras = new SqlParameter[2];
			paras[0] = new SqlParameter(string.Format("@{0}", ACSupervisorySchema.ACPanelPK), SqlDbType.UniqueIdentifier);
			paras[0].Value = ACPanelPK;
			paras[1] = new SqlParameter(string.Format("@{0}", ACSupervisorySchema.PanelZoneID), SqlDbType.TinyInt);
			paras[1].Value = PanelZoneID;

			return this.GetEntity(sqlACPanelPK + sqlPanelZoneID , paras);
		}
	}

	public partial class UsrGroupDataService
	{
		public UsrGroupData GetByUsrGroupName( System.String UsrGroupName)
		{
			string sqlUsrGroupName = string.Format(" WHERE  [{0}].[{1}] = @{1}", UsrGroupSchema.TableAlias, UsrGroupSchema.UsrGroupName); 

			SqlParameter[] paras = new SqlParameter[1];
			paras[0] = new SqlParameter(string.Format("@{0}", UsrGroupSchema.UsrGroupName), SqlDbType.VarChar);
			paras[0].Value = UsrGroupName;

			return this.GetEntity(sqlUsrGroupName , paras);
		}
	}

	public partial class ACCardHolderBuildingMapDataService
	{
		public ACCardHolderBuildingMapData GetByUK( System.Guid ACCardHolderPK, System.Guid BDBuildingPK)
		{
			string sqlACCardHolderPK = string.Format(" WHERE  [{0}].[{1}] = @{1}", ACCardHolderBuildingMapSchema.TableAlias, ACCardHolderBuildingMapSchema.ACCardHolderPK); 
			string sqlBDBuildingPK = string.Format(" AND  [{0}].[{1}] = @{1}", ACCardHolderBuildingMapSchema.TableAlias, ACCardHolderBuildingMapSchema.BDBuildingPK); 

			SqlParameter[] paras = new SqlParameter[2];
			paras[0] = new SqlParameter(string.Format("@{0}", ACCardHolderBuildingMapSchema.ACCardHolderPK), SqlDbType.UniqueIdentifier);
			paras[0].Value = ACCardHolderPK;
			paras[1] = new SqlParameter(string.Format("@{0}", ACCardHolderBuildingMapSchema.BDBuildingPK), SqlDbType.UniqueIdentifier);
			paras[1].Value = BDBuildingPK;

			return this.GetEntity(sqlACCardHolderPK + sqlBDBuildingPK , paras);
		}
	}

	public partial class UsrGroupDBRuleDataService
	{
		public UsrGroupDBRuleData GetByUK( System.Guid UsrGroupPK, System.Int32 DBRuleID)
		{
			string sqlUsrGroupPK = string.Format(" WHERE  [{0}].[{1}] = @{1}", UsrGroupDBRuleSchema.TableAlias, UsrGroupDBRuleSchema.UsrGroupPK); 
			string sqlDBRuleID = string.Format(" AND  [{0}].[{1}] = @{1}", UsrGroupDBRuleSchema.TableAlias, UsrGroupDBRuleSchema.DBRuleID); 

			SqlParameter[] paras = new SqlParameter[2];
			paras[0] = new SqlParameter(string.Format("@{0}", UsrGroupDBRuleSchema.UsrGroupPK), SqlDbType.UniqueIdentifier);
			paras[0].Value = UsrGroupPK;
			paras[1] = new SqlParameter(string.Format("@{0}", UsrGroupDBRuleSchema.DBRuleID), SqlDbType.Int);
			paras[1].Value = DBRuleID;

			return this.GetEntity(sqlUsrGroupPK + sqlDBRuleID , paras);
		}
	}

	public partial class ACPanelDataService
	{
		public ACPanelData GetByUnitID( System.Int32 UnitID)
		{
			string sqlUnitID = string.Format(" WHERE  [{0}].[{1}] = @{1}", ACPanelSchema.TableAlias, ACPanelSchema.UnitID); 

			SqlParameter[] paras = new SqlParameter[1];
			paras[0] = new SqlParameter(string.Format("@{0}", ACPanelSchema.UnitID), SqlDbType.Int);
			paras[0].Value = UnitID;

			return this.GetEntity(sqlUnitID , paras);
		}
	}

	public partial class UsrAccountDBRuleDataService
	{
		public UsrAccountDBRuleData GetByUK( System.Guid UsrAccountPK, System.Int32 DBRuleID)
		{
			string sqlUsrAccountPK = string.Format(" WHERE  [{0}].[{1}] = @{1}", UsrAccountDBRuleSchema.TableAlias, UsrAccountDBRuleSchema.UsrAccountPK); 
			string sqlDBRuleID = string.Format(" AND  [{0}].[{1}] = @{1}", UsrAccountDBRuleSchema.TableAlias, UsrAccountDBRuleSchema.DBRuleID); 

			SqlParameter[] paras = new SqlParameter[2];
			paras[0] = new SqlParameter(string.Format("@{0}", UsrAccountDBRuleSchema.UsrAccountPK), SqlDbType.UniqueIdentifier);
			paras[0].Value = UsrAccountPK;
			paras[1] = new SqlParameter(string.Format("@{0}", UsrAccountDBRuleSchema.DBRuleID), SqlDbType.Int);
			paras[1].Value = DBRuleID;

			return this.GetEntity(sqlUsrAccountPK + sqlDBRuleID , paras);
		}
	}

	public partial class UsrGroupBRRuleDataService
	{
		public UsrGroupBRRuleData GetByUK( System.Guid UsrGroupPK, System.Int32 BRRuleID)
		{
			string sqlUsrGroupPK = string.Format(" WHERE  [{0}].[{1}] = @{1}", UsrGroupBRRuleSchema.TableAlias, UsrGroupBRRuleSchema.UsrGroupPK); 
			string sqlBRRuleID = string.Format(" AND  [{0}].[{1}] = @{1}", UsrGroupBRRuleSchema.TableAlias, UsrGroupBRRuleSchema.BRRuleID); 

			SqlParameter[] paras = new SqlParameter[2];
			paras[0] = new SqlParameter(string.Format("@{0}", UsrGroupBRRuleSchema.UsrGroupPK), SqlDbType.UniqueIdentifier);
			paras[0].Value = UsrGroupPK;
			paras[1] = new SqlParameter(string.Format("@{0}", UsrGroupBRRuleSchema.BRRuleID), SqlDbType.Int);
			paras[1].Value = BRRuleID;

			return this.GetEntity(sqlUsrGroupPK + sqlBRRuleID , paras);
		}
	}

	public partial class ACInputGroupInputMapDataService
	{
		public ACInputGroupInputMapData GetByUK( System.Guid ACInputGroupPK, System.Guid ACInputPK)
		{
			string sqlACInputGroupPK = string.Format(" WHERE  [{0}].[{1}] = @{1}", ACInputGroupInputMapSchema.TableAlias, ACInputGroupInputMapSchema.ACInputGroupPK); 
			string sqlACInputPK = string.Format(" AND  [{0}].[{1}] = @{1}", ACInputGroupInputMapSchema.TableAlias, ACInputGroupInputMapSchema.ACInputPK); 

			SqlParameter[] paras = new SqlParameter[2];
			paras[0] = new SqlParameter(string.Format("@{0}", ACInputGroupInputMapSchema.ACInputGroupPK), SqlDbType.UniqueIdentifier);
			paras[0].Value = ACInputGroupPK;
			paras[1] = new SqlParameter(string.Format("@{0}", ACInputGroupInputMapSchema.ACInputPK), SqlDbType.UniqueIdentifier);
			paras[1].Value = ACInputPK;

			return this.GetEntity(sqlACInputGroupPK + sqlACInputPK , paras);
		}
	}

	public partial class UsrAccountBRRuleDataService
	{
		public UsrAccountBRRuleData GetByUK( System.Guid UsrAccountPK, System.Int32 BRRuleID)
		{
			string sqlUsrAccountPK = string.Format(" WHERE  [{0}].[{1}] = @{1}", UsrAccountBRRuleSchema.TableAlias, UsrAccountBRRuleSchema.UsrAccountPK); 
			string sqlBRRuleID = string.Format(" AND  [{0}].[{1}] = @{1}", UsrAccountBRRuleSchema.TableAlias, UsrAccountBRRuleSchema.BRRuleID); 

			SqlParameter[] paras = new SqlParameter[2];
			paras[0] = new SqlParameter(string.Format("@{0}", UsrAccountBRRuleSchema.UsrAccountPK), SqlDbType.UniqueIdentifier);
			paras[0].Value = UsrAccountPK;
			paras[1] = new SqlParameter(string.Format("@{0}", UsrAccountBRRuleSchema.BRRuleID), SqlDbType.Int);
			paras[1].Value = BRRuleID;

			return this.GetEntity(sqlUsrAccountPK + sqlBRRuleID , paras);
		}
	}

	public partial class UsrAccountTenantMapDataService
	{
		public UsrAccountTenantMapData GetByUK( System.Guid UsrAccountPK, System.Guid BDTenantPK)
		{
			string sqlUsrAccountPK = string.Format(" WHERE  [{0}].[{1}] = @{1}", UsrAccountTenantMapSchema.TableAlias, UsrAccountTenantMapSchema.UsrAccountPK); 
			string sqlBDTenantPK = string.Format(" AND  [{0}].[{1}] = @{1}", UsrAccountTenantMapSchema.TableAlias, UsrAccountTenantMapSchema.BDTenantPK); 

			SqlParameter[] paras = new SqlParameter[2];
			paras[0] = new SqlParameter(string.Format("@{0}", UsrAccountTenantMapSchema.UsrAccountPK), SqlDbType.UniqueIdentifier);
			paras[0].Value = UsrAccountPK;
			paras[1] = new SqlParameter(string.Format("@{0}", UsrAccountTenantMapSchema.BDTenantPK), SqlDbType.UniqueIdentifier);
			paras[1].Value = BDTenantPK;

			return this.GetEntity(sqlUsrAccountPK + sqlBDTenantPK , paras);
		}
	}

}
