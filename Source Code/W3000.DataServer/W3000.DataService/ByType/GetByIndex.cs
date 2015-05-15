using System;
using System.Data;
using W3000.Data;
using W3000.Schema;
using System.Data.SqlClient;

namespace W3000.DataService
{
	public partial class ACIntvalHolidayMapDataService
	{
		public ACIntvalHolidayMapDataCollection GetByModifiedOn(DateTime begin, DateTime end)
		{
			string sql = string.Format(" WHERE [{0}].[{1}] >= @Min{1} AND [{0}].[{1}] <= @Max{1}", ACIntvalHolidayMapSchema.TableAlias, ACIntvalHolidayMapSchema.ModifiedOn); 

			SqlParameter[] paras = new SqlParameter[2];
			paras[0] = new SqlParameter(string.Format("@Min{0}", ACIntvalHolidayMapSchema.ModifiedOn), SqlDbType.DateTime);
			paras[0].Value = begin;
			paras[1] = new SqlParameter(string.Format("@Max{0}", ACIntvalHolidayMapSchema.ModifiedOn), SqlDbType.DateTime);
			paras[1].Value = end;

			this._dal.ClearSortBy();
			this._dal.AddSortBy(ACIntvalHolidayMapSchema.ModifiedOn, false);
			return this.GetCollection(sql, paras);
		}
	}

	public partial class ACAccessLevelDetailDataService
	{
		public ACAccessLevelDetailDataCollection GetByModifiedOn(DateTime begin, DateTime end)
		{
			string sql = string.Format(" WHERE [{0}].[{1}] >= @Min{1} AND [{0}].[{1}] <= @Max{1}", ACAccessLevelDetailSchema.TableAlias, ACAccessLevelDetailSchema.ModifiedOn); 

			SqlParameter[] paras = new SqlParameter[2];
			paras[0] = new SqlParameter(string.Format("@Min{0}", ACAccessLevelDetailSchema.ModifiedOn), SqlDbType.DateTime);
			paras[0].Value = begin;
			paras[1] = new SqlParameter(string.Format("@Max{0}", ACAccessLevelDetailSchema.ModifiedOn), SqlDbType.DateTime);
			paras[1].Value = end;

			this._dal.ClearSortBy();
			this._dal.AddSortBy(ACAccessLevelDetailSchema.ModifiedOn, false);
			return this.GetCollection(sql, paras);
		}
	}

	public partial class UsrAccountBuildingMapDataService
	{
		public UsrAccountBuildingMapDataCollection GetByModifiedOn(DateTime begin, DateTime end)
		{
			string sql = string.Format(" WHERE [{0}].[{1}] >= @Min{1} AND [{0}].[{1}] <= @Max{1}", UsrAccountBuildingMapSchema.TableAlias, UsrAccountBuildingMapSchema.ModifiedOn); 

			SqlParameter[] paras = new SqlParameter[2];
			paras[0] = new SqlParameter(string.Format("@Min{0}", UsrAccountBuildingMapSchema.ModifiedOn), SqlDbType.DateTime);
			paras[0].Value = begin;
			paras[1] = new SqlParameter(string.Format("@Max{0}", UsrAccountBuildingMapSchema.ModifiedOn), SqlDbType.DateTime);
			paras[1].Value = end;

			this._dal.ClearSortBy();
			this._dal.AddSortBy(UsrAccountBuildingMapSchema.ModifiedOn, false);
			return this.GetCollection(sql, paras);
		}
	}

	public partial class BDBuildingDataService
	{
		public BDBuildingDataCollection GetBySystemTypeID(System.Int32 SystemTypeID)
		{
			string sql = string.Format(" WHERE [{0}].[{1}] = @{1} ", BDBuildingSchema.TableAlias, BDBuildingSchema.SystemTypeID); 

			SqlParameter[] paras = new SqlParameter[1];
			paras[0] = new SqlParameter(string.Format("@{0}", BDBuildingSchema.SystemTypeID), SqlDbType.Int);
			paras[0].Value = SystemTypeID;

			return this.GetCollection(sql, paras);
		}
		public BDBuildingDataCollection GetByCountryID(System.Int32 CountryID)
		{
			string sql = string.Format(" WHERE [{0}].[{1}] = @{1} ", BDBuildingSchema.TableAlias, BDBuildingSchema.CountryID); 

			SqlParameter[] paras = new SqlParameter[1];
			paras[0] = new SqlParameter(string.Format("@{0}", BDBuildingSchema.CountryID), SqlDbType.Int);
			paras[0].Value = CountryID;

			return this.GetCollection(sql, paras);
		}
		public BDBuildingDataCollection GetByLikeStreetNumb(System.String StreetNumb)
		{
			string sql = string.Format(" WHERE [{0}].[{1}] LIKE @{1} ", BDBuildingSchema.TableAlias, BDBuildingSchema.StreetNumb); 

			SqlParameter[] paras = new SqlParameter[1];
			paras[0] = new SqlParameter(string.Format("@{0}", BDBuildingSchema.StreetNumb), SqlDbType.VarChar);
			paras[0].Value = string.Format("{0}%", StreetNumb);

			return this.GetCollection(sql, paras);
		}
		public BDBuildingDataCollection GetByLikeStreetName(System.String StreetName)
		{
			string sql = string.Format(" WHERE [{0}].[{1}] LIKE @{1} ", BDBuildingSchema.TableAlias, BDBuildingSchema.StreetName); 

			SqlParameter[] paras = new SqlParameter[1];
			paras[0] = new SqlParameter(string.Format("@{0}", BDBuildingSchema.StreetName), SqlDbType.VarChar);
			paras[0].Value = string.Format("{0}%", StreetName);

			return this.GetCollection(sql, paras);
		}
	}

	public partial class BDTenantDataService
	{
		public BDTenantDataCollection GetBySystemTypeID(System.Int32 SystemTypeID)
		{
			string sql = string.Format(" WHERE [{0}].[{1}] = @{1} ", BDTenantSchema.TableAlias, BDTenantSchema.SystemTypeID); 

			SqlParameter[] paras = new SqlParameter[1];
			paras[0] = new SqlParameter(string.Format("@{0}", BDTenantSchema.SystemTypeID), SqlDbType.Int);
			paras[0].Value = SystemTypeID;

			return this.GetCollection(sql, paras);
		}
		public BDTenantDataCollection GetByModifiedOn(DateTime begin, DateTime end)
		{
			string sql = string.Format(" WHERE [{0}].[{1}] >= @Min{1} AND [{0}].[{1}] <= @Max{1}", BDTenantSchema.TableAlias, BDTenantSchema.ModifiedOn); 

			SqlParameter[] paras = new SqlParameter[2];
			paras[0] = new SqlParameter(string.Format("@Min{0}", BDTenantSchema.ModifiedOn), SqlDbType.DateTime);
			paras[0].Value = begin;
			paras[1] = new SqlParameter(string.Format("@Max{0}", BDTenantSchema.ModifiedOn), SqlDbType.DateTime);
			paras[1].Value = end;

			this._dal.ClearSortBy();
			this._dal.AddSortBy(BDTenantSchema.ModifiedOn, false);
			return this.GetCollection(sql, paras);
		}
	}

	public partial class UtilSettingCategoryDataService
	{
		public UtilSettingCategoryDataCollection GetBySettingCategoryID(System.Int32 SettingCategoryID)
		{
			string sql = string.Format(" WHERE [{0}].[{1}] = @{1} ", UtilSettingCategorySchema.TableAlias, UtilSettingCategorySchema.SettingCategoryID); 

			SqlParameter[] paras = new SqlParameter[1];
			paras[0] = new SqlParameter(string.Format("@{0}", UtilSettingCategorySchema.SettingCategoryID), SqlDbType.Int);
			paras[0].Value = SettingCategoryID;

			return this.GetCollection(sql, paras);
		}
		public UtilSettingCategoryDataCollection GetByModifiedOn(DateTime begin, DateTime end)
		{
			string sql = string.Format(" WHERE [{0}].[{1}] >= @Min{1} AND [{0}].[{1}] <= @Max{1}", UtilSettingCategorySchema.TableAlias, UtilSettingCategorySchema.ModifiedOn); 

			SqlParameter[] paras = new SqlParameter[2];
			paras[0] = new SqlParameter(string.Format("@Min{0}", UtilSettingCategorySchema.ModifiedOn), SqlDbType.DateTime);
			paras[0].Value = begin;
			paras[1] = new SqlParameter(string.Format("@Max{0}", UtilSettingCategorySchema.ModifiedOn), SqlDbType.DateTime);
			paras[1].Value = end;

			this._dal.ClearSortBy();
			this._dal.AddSortBy(UtilSettingCategorySchema.ModifiedOn, false);
			return this.GetCollection(sql, paras);
		}
	}

	public partial class UtilSettingDetailDataService
	{
		public UtilSettingDetailDataCollection GetByModifiedOn(DateTime begin, DateTime end)
		{
			string sql = string.Format(" WHERE [{0}].[{1}] >= @Min{1} AND [{0}].[{1}] <= @Max{1}", UtilSettingDetailSchema.TableAlias, UtilSettingDetailSchema.ModifiedOn); 

			SqlParameter[] paras = new SqlParameter[2];
			paras[0] = new SqlParameter(string.Format("@Min{0}", UtilSettingDetailSchema.ModifiedOn), SqlDbType.DateTime);
			paras[0].Value = begin;
			paras[1] = new SqlParameter(string.Format("@Max{0}", UtilSettingDetailSchema.ModifiedOn), SqlDbType.DateTime);
			paras[1].Value = end;

			this._dal.ClearSortBy();
			this._dal.AddSortBy(UtilSettingDetailSchema.ModifiedOn, false);
			return this.GetCollection(sql, paras);
		}
	}

	public partial class ACOutputGroupMainZoneMapDataService
	{
		public ACOutputGroupMainZoneMapDataCollection GetByModifiedOn(DateTime begin, DateTime end)
		{
			string sql = string.Format(" WHERE [{0}].[{1}] >= @Min{1} AND [{0}].[{1}] <= @Max{1}", ACOutputGroupMainZoneMapSchema.TableAlias, ACOutputGroupMainZoneMapSchema.ModifiedOn); 

			SqlParameter[] paras = new SqlParameter[2];
			paras[0] = new SqlParameter(string.Format("@Min{0}", ACOutputGroupMainZoneMapSchema.ModifiedOn), SqlDbType.DateTime);
			paras[0].Value = begin;
			paras[1] = new SqlParameter(string.Format("@Max{0}", ACOutputGroupMainZoneMapSchema.ModifiedOn), SqlDbType.DateTime);
			paras[1].Value = end;

			this._dal.ClearSortBy();
			this._dal.AddSortBy(ACOutputGroupMainZoneMapSchema.ModifiedOn, false);
			return this.GetCollection(sql, paras);
		}
	}

	public partial class ACCardHolderDataService
	{
		public ACCardHolderDataCollection GetByLikeFirstName(System.String FirstName)
		{
			string sql = string.Format(" WHERE [{0}].[{1}] LIKE @{1} ", ACCardHolderSchema.TableAlias, ACCardHolderSchema.FirstName); 

			SqlParameter[] paras = new SqlParameter[1];
			paras[0] = new SqlParameter(string.Format("@{0}", ACCardHolderSchema.FirstName), SqlDbType.VarChar);
			paras[0].Value = string.Format("{0}%", FirstName);

			return this.GetCollection(sql, paras);
		}
		public ACCardHolderDataCollection GetByLikeLastName(System.String LastName)
		{
			string sql = string.Format(" WHERE [{0}].[{1}] LIKE @{1} ", ACCardHolderSchema.TableAlias, ACCardHolderSchema.LastName); 

			SqlParameter[] paras = new SqlParameter[1];
			paras[0] = new SqlParameter(string.Format("@{0}", ACCardHolderSchema.LastName), SqlDbType.VarChar);
			paras[0].Value = string.Format("{0}%", LastName);

			return this.GetCollection(sql, paras);
		}
		public ACCardHolderDataCollection GetByValidThru(DateTime begin, DateTime end)
		{
			string sql = string.Format(" WHERE [{0}].[{1}] >= @Min{1} AND [{0}].[{1}] <= @Max{1}", ACCardHolderSchema.TableAlias, ACCardHolderSchema.ValidThru); 

			SqlParameter[] paras = new SqlParameter[2];
			paras[0] = new SqlParameter(string.Format("@Min{0}", ACCardHolderSchema.ValidThru), SqlDbType.DateTime);
			paras[0].Value = begin;
			paras[1] = new SqlParameter(string.Format("@Max{0}", ACCardHolderSchema.ValidThru), SqlDbType.DateTime);
			paras[1].Value = end;

			this._dal.ClearSortBy();
			this._dal.AddSortBy(ACCardHolderSchema.ValidThru, false);
			return this.GetCollection(sql, paras);
		}
		public ACCardHolderDataCollection GetByModifiedOn(DateTime begin, DateTime end)
		{
			string sql = string.Format(" WHERE [{0}].[{1}] >= @Min{1} AND [{0}].[{1}] <= @Max{1}", ACCardHolderSchema.TableAlias, ACCardHolderSchema.ModifiedOn); 

			SqlParameter[] paras = new SqlParameter[2];
			paras[0] = new SqlParameter(string.Format("@Min{0}", ACCardHolderSchema.ModifiedOn), SqlDbType.DateTime);
			paras[0].Value = begin;
			paras[1] = new SqlParameter(string.Format("@Max{0}", ACCardHolderSchema.ModifiedOn), SqlDbType.DateTime);
			paras[1].Value = end;

			this._dal.ClearSortBy();
			this._dal.AddSortBy(ACCardHolderSchema.ModifiedOn, false);
			return this.GetCollection(sql, paras);
		}
	}

	public partial class ACMainZoneDataService
	{
		public ACMainZoneDataCollection GetByReaderTypeID(System.Int32 ReaderTypeID)
		{
			string sql = string.Format(" WHERE [{0}].[{1}] = @{1} ", ACMainZoneSchema.TableAlias, ACMainZoneSchema.ReaderTypeID); 

			SqlParameter[] paras = new SqlParameter[1];
			paras[0] = new SqlParameter(string.Format("@{0}", ACMainZoneSchema.ReaderTypeID), SqlDbType.Int);
			paras[0].Value = ReaderTypeID;

			return this.GetCollection(sql, paras);
		}
		public ACMainZoneDataCollection GetByMainZoneTypeID(System.Int32 MainZoneTypeID)
		{
			string sql = string.Format(" WHERE [{0}].[{1}] = @{1} ", ACMainZoneSchema.TableAlias, ACMainZoneSchema.MainZoneTypeID); 

			SqlParameter[] paras = new SqlParameter[1];
			paras[0] = new SqlParameter(string.Format("@{0}", ACMainZoneSchema.MainZoneTypeID), SqlDbType.Int);
			paras[0].Value = MainZoneTypeID;

			return this.GetCollection(sql, paras);
		}
		public ACMainZoneDataCollection GetByModifiedOn(DateTime begin, DateTime end)
		{
			string sql = string.Format(" WHERE [{0}].[{1}] >= @Min{1} AND [{0}].[{1}] <= @Max{1}", ACMainZoneSchema.TableAlias, ACMainZoneSchema.ModifiedOn); 

			SqlParameter[] paras = new SqlParameter[2];
			paras[0] = new SqlParameter(string.Format("@Min{0}", ACMainZoneSchema.ModifiedOn), SqlDbType.DateTime);
			paras[0].Value = begin;
			paras[1] = new SqlParameter(string.Format("@Max{0}", ACMainZoneSchema.ModifiedOn), SqlDbType.DateTime);
			paras[1].Value = end;

			this._dal.ClearSortBy();
			this._dal.AddSortBy(ACMainZoneSchema.ModifiedOn, false);
			return this.GetCollection(sql, paras);
		}
	}

	public partial class ACIntervalDataService
	{
		public ACIntervalDataCollection GetByModifiedOn(DateTime begin, DateTime end)
		{
			string sql = string.Format(" WHERE [{0}].[{1}] >= @Min{1} AND [{0}].[{1}] <= @Max{1}", ACIntervalSchema.TableAlias, ACIntervalSchema.ModifiedOn); 

			SqlParameter[] paras = new SqlParameter[2];
			paras[0] = new SqlParameter(string.Format("@Min{0}", ACIntervalSchema.ModifiedOn), SqlDbType.DateTime);
			paras[0].Value = begin;
			paras[1] = new SqlParameter(string.Format("@Max{0}", ACIntervalSchema.ModifiedOn), SqlDbType.DateTime);
			paras[1].Value = end;

			this._dal.ClearSortBy();
			this._dal.AddSortBy(ACIntervalSchema.ModifiedOn, false);
			return this.GetCollection(sql, paras);
		}
	}

	public partial class ACPanelHolidayMapDataService
	{
		public ACPanelHolidayMapDataCollection GetByModifiedOn(DateTime begin, DateTime end)
		{
			string sql = string.Format(" WHERE [{0}].[{1}] >= @Min{1} AND [{0}].[{1}] <= @Max{1}", ACPanelHolidayMapSchema.TableAlias, ACPanelHolidayMapSchema.ModifiedOn); 

			SqlParameter[] paras = new SqlParameter[2];
			paras[0] = new SqlParameter(string.Format("@Min{0}", ACPanelHolidayMapSchema.ModifiedOn), SqlDbType.DateTime);
			paras[0].Value = begin;
			paras[1] = new SqlParameter(string.Format("@Max{0}", ACPanelHolidayMapSchema.ModifiedOn), SqlDbType.DateTime);
			paras[1].Value = end;

			this._dal.ClearSortBy();
			this._dal.AddSortBy(ACPanelHolidayMapSchema.ModifiedOn, false);
			return this.GetCollection(sql, paras);
		}
	}

	public partial class ACTimecodeDataService
	{
		public ACTimecodeDataCollection GetByModifiedOn(DateTime begin, DateTime end)
		{
			string sql = string.Format(" WHERE [{0}].[{1}] >= @Min{1} AND [{0}].[{1}] <= @Max{1}", ACTimecodeSchema.TableAlias, ACTimecodeSchema.ModifiedOn); 

			SqlParameter[] paras = new SqlParameter[2];
			paras[0] = new SqlParameter(string.Format("@Min{0}", ACTimecodeSchema.ModifiedOn), SqlDbType.DateTime);
			paras[0].Value = begin;
			paras[1] = new SqlParameter(string.Format("@Max{0}", ACTimecodeSchema.ModifiedOn), SqlDbType.DateTime);
			paras[1].Value = end;

			this._dal.ClearSortBy();
			this._dal.AddSortBy(ACTimecodeSchema.ModifiedOn, false);
			return this.GetCollection(sql, paras);
		}
	}

	public partial class ACTimecodeIntervalMapDataService
	{
		public ACTimecodeIntervalMapDataCollection GetByModifiedOn(DateTime begin, DateTime end)
		{
			string sql = string.Format(" WHERE [{0}].[{1}] >= @Min{1} AND [{0}].[{1}] <= @Max{1}", ACTimecodeIntervalMapSchema.TableAlias, ACTimecodeIntervalMapSchema.ModifiedOn); 

			SqlParameter[] paras = new SqlParameter[2];
			paras[0] = new SqlParameter(string.Format("@Min{0}", ACTimecodeIntervalMapSchema.ModifiedOn), SqlDbType.DateTime);
			paras[0].Value = begin;
			paras[1] = new SqlParameter(string.Format("@Max{0}", ACTimecodeIntervalMapSchema.ModifiedOn), SqlDbType.DateTime);
			paras[1].Value = end;

			this._dal.ClearSortBy();
			this._dal.AddSortBy(ACTimecodeIntervalMapSchema.ModifiedOn, false);
			return this.GetCollection(sql, paras);
		}
	}

	public partial class ACAMFormatDataService
	{
		public ACAMFormatDataCollection GetByModifiedOn(DateTime begin, DateTime end)
		{
			string sql = string.Format(" WHERE [{0}].[{1}] >= @Min{1} AND [{0}].[{1}] <= @Max{1}", ACAMFormatSchema.TableAlias, ACAMFormatSchema.ModifiedOn); 

			SqlParameter[] paras = new SqlParameter[2];
			paras[0] = new SqlParameter(string.Format("@Min{0}", ACAMFormatSchema.ModifiedOn), SqlDbType.DateTime);
			paras[0].Value = begin;
			paras[1] = new SqlParameter(string.Format("@Max{0}", ACAMFormatSchema.ModifiedOn), SqlDbType.DateTime);
			paras[1].Value = end;

			this._dal.ClearSortBy();
			this._dal.AddSortBy(ACAMFormatSchema.ModifiedOn, false);
			return this.GetCollection(sql, paras);
		}
	}

	public partial class ACOutputGroupDataService
	{
		public ACOutputGroupDataCollection GetByModifiedOn(DateTime begin, DateTime end)
		{
			string sql = string.Format(" WHERE [{0}].[{1}] >= @Min{1} AND [{0}].[{1}] <= @Max{1}", ACOutputGroupSchema.TableAlias, ACOutputGroupSchema.ModifiedOn); 

			SqlParameter[] paras = new SqlParameter[2];
			paras[0] = new SqlParameter(string.Format("@Min{0}", ACOutputGroupSchema.ModifiedOn), SqlDbType.DateTime);
			paras[0].Value = begin;
			paras[1] = new SqlParameter(string.Format("@Max{0}", ACOutputGroupSchema.ModifiedOn), SqlDbType.DateTime);
			paras[1].Value = end;

			this._dal.ClearSortBy();
			this._dal.AddSortBy(ACOutputGroupSchema.ModifiedOn, false);
			return this.GetCollection(sql, paras);
		}
	}

	public partial class LogRowsCountDataService
	{
		public LogRowsCountDataCollection GetBySessionDateTime(DateTime begin, DateTime end)
		{
			string sql = string.Format(" WHERE [{0}].[{1}] >= @Min{1} AND [{0}].[{1}] <= @Max{1}", LogRowsCountSchema.TableAlias, LogRowsCountSchema.SessionDateTime); 

			SqlParameter[] paras = new SqlParameter[2];
			paras[0] = new SqlParameter(string.Format("@Min{0}", LogRowsCountSchema.SessionDateTime), SqlDbType.DateTime);
			paras[0].Value = begin;
			paras[1] = new SqlParameter(string.Format("@Max{0}", LogRowsCountSchema.SessionDateTime), SqlDbType.DateTime);
			paras[1].Value = end;

			this._dal.ClearSortBy();
			this._dal.AddSortBy(LogRowsCountSchema.SessionDateTime, false);
			return this.GetCollection(sql, paras);
		}
	}

	public partial class ACInputGroupDataService
	{
		public ACInputGroupDataCollection GetByModifiedOn(DateTime begin, DateTime end)
		{
			string sql = string.Format(" WHERE [{0}].[{1}] >= @Min{1} AND [{0}].[{1}] <= @Max{1}", ACInputGroupSchema.TableAlias, ACInputGroupSchema.ModifiedOn); 

			SqlParameter[] paras = new SqlParameter[2];
			paras[0] = new SqlParameter(string.Format("@Min{0}", ACInputGroupSchema.ModifiedOn), SqlDbType.DateTime);
			paras[0].Value = begin;
			paras[1] = new SqlParameter(string.Format("@Max{0}", ACInputGroupSchema.ModifiedOn), SqlDbType.DateTime);
			paras[1].Value = end;

			this._dal.ClearSortBy();
			this._dal.AddSortBy(ACInputGroupSchema.ModifiedOn, false);
			return this.GetCollection(sql, paras);
		}
	}

	public partial class ACInputDataService
	{
		public ACInputDataCollection GetByModifiedOn(DateTime begin, DateTime end)
		{
			string sql = string.Format(" WHERE [{0}].[{1}] >= @Min{1} AND [{0}].[{1}] <= @Max{1}", ACInputSchema.TableAlias, ACInputSchema.ModifiedOn); 

			SqlParameter[] paras = new SqlParameter[2];
			paras[0] = new SqlParameter(string.Format("@Min{0}", ACInputSchema.ModifiedOn), SqlDbType.DateTime);
			paras[0].Value = begin;
			paras[1] = new SqlParameter(string.Format("@Max{0}", ACInputSchema.ModifiedOn), SqlDbType.DateTime);
			paras[1].Value = end;

			this._dal.ClearSortBy();
			this._dal.AddSortBy(ACInputSchema.ModifiedOn, false);
			return this.GetCollection(sql, paras);
		}
	}

	public partial class ACFunctionCardDataService
	{
		public ACFunctionCardDataCollection GetByLikeFirstName(System.String FirstName)
		{
			string sql = string.Format(" WHERE [{0}].[{1}] LIKE @{1} ", ACFunctionCardSchema.TableAlias, ACFunctionCardSchema.FirstName); 

			SqlParameter[] paras = new SqlParameter[1];
			paras[0] = new SqlParameter(string.Format("@{0}", ACFunctionCardSchema.FirstName), SqlDbType.VarChar);
			paras[0].Value = string.Format("{0}%", FirstName);

			return this.GetCollection(sql, paras);
		}
		public ACFunctionCardDataCollection GetByLikeLastName(System.String LastName)
		{
			string sql = string.Format(" WHERE [{0}].[{1}] LIKE @{1} ", ACFunctionCardSchema.TableAlias, ACFunctionCardSchema.LastName); 

			SqlParameter[] paras = new SqlParameter[1];
			paras[0] = new SqlParameter(string.Format("@{0}", ACFunctionCardSchema.LastName), SqlDbType.VarChar);
			paras[0].Value = string.Format("{0}%", LastName);

			return this.GetCollection(sql, paras);
		}
		public ACFunctionCardDataCollection GetByCardTypeID(System.Int32 CardTypeID)
		{
			string sql = string.Format(" WHERE [{0}].[{1}] = @{1} ", ACFunctionCardSchema.TableAlias, ACFunctionCardSchema.CardTypeID); 

			SqlParameter[] paras = new SqlParameter[1];
			paras[0] = new SqlParameter(string.Format("@{0}", ACFunctionCardSchema.CardTypeID), SqlDbType.Int);
			paras[0].Value = CardTypeID;

			return this.GetCollection(sql, paras);
		}
		public ACFunctionCardDataCollection GetByModifiedOn(DateTime begin, DateTime end)
		{
			string sql = string.Format(" WHERE [{0}].[{1}] >= @Min{1} AND [{0}].[{1}] <= @Max{1}", ACFunctionCardSchema.TableAlias, ACFunctionCardSchema.ModifiedOn); 

			SqlParameter[] paras = new SqlParameter[2];
			paras[0] = new SqlParameter(string.Format("@Min{0}", ACFunctionCardSchema.ModifiedOn), SqlDbType.DateTime);
			paras[0].Value = begin;
			paras[1] = new SqlParameter(string.Format("@Max{0}", ACFunctionCardSchema.ModifiedOn), SqlDbType.DateTime);
			paras[1].Value = end;

			this._dal.ClearSortBy();
			this._dal.AddSortBy(ACFunctionCardSchema.ModifiedOn, false);
			return this.GetCollection(sql, paras);
		}
	}

	public partial class ACAccessLevelDataService
	{
		public ACAccessLevelDataCollection GetByModifiedOn(DateTime begin, DateTime end)
		{
			string sql = string.Format(" WHERE [{0}].[{1}] >= @Min{1} AND [{0}].[{1}] <= @Max{1}", ACAccessLevelSchema.TableAlias, ACAccessLevelSchema.ModifiedOn); 

			SqlParameter[] paras = new SqlParameter[2];
			paras[0] = new SqlParameter(string.Format("@Min{0}", ACAccessLevelSchema.ModifiedOn), SqlDbType.DateTime);
			paras[0].Value = begin;
			paras[1] = new SqlParameter(string.Format("@Max{0}", ACAccessLevelSchema.ModifiedOn), SqlDbType.DateTime);
			paras[1].Value = end;

			this._dal.ClearSortBy();
			this._dal.AddSortBy(ACAccessLevelSchema.ModifiedOn, false);
			return this.GetCollection(sql, paras);
		}
	}

	public partial class ACPanelFunctionCardMapDataService
	{
		public ACPanelFunctionCardMapDataCollection GetByModifiedOn(DateTime begin, DateTime end)
		{
			string sql = string.Format(" WHERE [{0}].[{1}] >= @Min{1} AND [{0}].[{1}] <= @Max{1}", ACPanelFunctionCardMapSchema.TableAlias, ACPanelFunctionCardMapSchema.ModifiedOn); 

			SqlParameter[] paras = new SqlParameter[2];
			paras[0] = new SqlParameter(string.Format("@Min{0}", ACPanelFunctionCardMapSchema.ModifiedOn), SqlDbType.DateTime);
			paras[0].Value = begin;
			paras[1] = new SqlParameter(string.Format("@Max{0}", ACPanelFunctionCardMapSchema.ModifiedOn), SqlDbType.DateTime);
			paras[1].Value = end;

			this._dal.ClearSortBy();
			this._dal.AddSortBy(ACPanelFunctionCardMapSchema.ModifiedOn, false);
			return this.GetCollection(sql, paras);
		}
	}

	public partial class UtilHolidayDataService
	{
		public UtilHolidayDataCollection GetByCountryID(System.Int32 CountryID)
		{
			string sql = string.Format(" WHERE [{0}].[{1}] = @{1} ", UtilHolidaySchema.TableAlias, UtilHolidaySchema.CountryID); 

			SqlParameter[] paras = new SqlParameter[1];
			paras[0] = new SqlParameter(string.Format("@{0}", UtilHolidaySchema.CountryID), SqlDbType.Int);
			paras[0].Value = CountryID;

			return this.GetCollection(sql, paras);
		}
		public UtilHolidayDataCollection GetByModifiedOn(DateTime begin, DateTime end)
		{
			string sql = string.Format(" WHERE [{0}].[{1}] >= @Min{1} AND [{0}].[{1}] <= @Max{1}", UtilHolidaySchema.TableAlias, UtilHolidaySchema.ModifiedOn); 

			SqlParameter[] paras = new SqlParameter[2];
			paras[0] = new SqlParameter(string.Format("@Min{0}", UtilHolidaySchema.ModifiedOn), SqlDbType.DateTime);
			paras[0].Value = begin;
			paras[1] = new SqlParameter(string.Format("@Max{0}", UtilHolidaySchema.ModifiedOn), SqlDbType.DateTime);
			paras[1].Value = end;

			this._dal.ClearSortBy();
			this._dal.AddSortBy(UtilHolidaySchema.ModifiedOn, false);
			return this.GetCollection(sql, paras);
		}
	}

	public partial class ACMasterCardDataService
	{
		public ACMasterCardDataCollection GetByCardTypeID(System.Int32 CardTypeID)
		{
			string sql = string.Format(" WHERE [{0}].[{1}] = @{1} ", ACMasterCardSchema.TableAlias, ACMasterCardSchema.CardTypeID); 

			SqlParameter[] paras = new SqlParameter[1];
			paras[0] = new SqlParameter(string.Format("@{0}", ACMasterCardSchema.CardTypeID), SqlDbType.Int);
			paras[0].Value = CardTypeID;

			return this.GetCollection(sql, paras);
		}
		public ACMasterCardDataCollection GetByLikeFirstName(System.String FirstName)
		{
			string sql = string.Format(" WHERE [{0}].[{1}] LIKE @{1} ", ACMasterCardSchema.TableAlias, ACMasterCardSchema.FirstName); 

			SqlParameter[] paras = new SqlParameter[1];
			paras[0] = new SqlParameter(string.Format("@{0}", ACMasterCardSchema.FirstName), SqlDbType.VarChar);
			paras[0].Value = string.Format("{0}%", FirstName);

			return this.GetCollection(sql, paras);
		}
		public ACMasterCardDataCollection GetByLikeLastName(System.String LastName)
		{
			string sql = string.Format(" WHERE [{0}].[{1}] LIKE @{1} ", ACMasterCardSchema.TableAlias, ACMasterCardSchema.LastName); 

			SqlParameter[] paras = new SqlParameter[1];
			paras[0] = new SqlParameter(string.Format("@{0}", ACMasterCardSchema.LastName), SqlDbType.VarChar);
			paras[0].Value = string.Format("{0}%", LastName);

			return this.GetCollection(sql, paras);
		}
		public ACMasterCardDataCollection GetByModifiedOn(DateTime begin, DateTime end)
		{
			string sql = string.Format(" WHERE [{0}].[{1}] >= @Min{1} AND [{0}].[{1}] <= @Max{1}", ACMasterCardSchema.TableAlias, ACMasterCardSchema.ModifiedOn); 

			SqlParameter[] paras = new SqlParameter[2];
			paras[0] = new SqlParameter(string.Format("@Min{0}", ACMasterCardSchema.ModifiedOn), SqlDbType.DateTime);
			paras[0].Value = begin;
			paras[1] = new SqlParameter(string.Format("@Max{0}", ACMasterCardSchema.ModifiedOn), SqlDbType.DateTime);
			paras[1].Value = end;

			this._dal.ClearSortBy();
			this._dal.AddSortBy(ACMasterCardSchema.ModifiedOn, false);
			return this.GetCollection(sql, paras);
		}
	}

	public partial class ACSupervisoryDataService
	{
		public ACSupervisoryDataCollection GetByModifiedOn(DateTime begin, DateTime end)
		{
			string sql = string.Format(" WHERE [{0}].[{1}] >= @Min{1} AND [{0}].[{1}] <= @Max{1}", ACSupervisorySchema.TableAlias, ACSupervisorySchema.ModifiedOn); 

			SqlParameter[] paras = new SqlParameter[2];
			paras[0] = new SqlParameter(string.Format("@Min{0}", ACSupervisorySchema.ModifiedOn), SqlDbType.DateTime);
			paras[0].Value = begin;
			paras[1] = new SqlParameter(string.Format("@Max{0}", ACSupervisorySchema.ModifiedOn), SqlDbType.DateTime);
			paras[1].Value = end;

			this._dal.ClearSortBy();
			this._dal.AddSortBy(ACSupervisorySchema.ModifiedOn, false);
			return this.GetCollection(sql, paras);
		}
	}

	public partial class ACCardHolderBuildingMapDataService
	{
		public ACCardHolderBuildingMapDataCollection GetByModifiedOn(DateTime begin, DateTime end)
		{
			string sql = string.Format(" WHERE [{0}].[{1}] >= @Min{1} AND [{0}].[{1}] <= @Max{1}", ACCardHolderBuildingMapSchema.TableAlias, ACCardHolderBuildingMapSchema.ModifiedOn); 

			SqlParameter[] paras = new SqlParameter[2];
			paras[0] = new SqlParameter(string.Format("@Min{0}", ACCardHolderBuildingMapSchema.ModifiedOn), SqlDbType.DateTime);
			paras[0].Value = begin;
			paras[1] = new SqlParameter(string.Format("@Max{0}", ACCardHolderBuildingMapSchema.ModifiedOn), SqlDbType.DateTime);
			paras[1].Value = end;

			this._dal.ClearSortBy();
			this._dal.AddSortBy(ACCardHolderBuildingMapSchema.ModifiedOn, false);
			return this.GetCollection(sql, paras);
		}
	}

	public partial class BDVisitorDataService
	{
		public BDVisitorDataCollection GetByValidThru(DateTime begin, DateTime end)
		{
			string sql = string.Format(" WHERE [{0}].[{1}] >= @Min{1} AND [{0}].[{1}] <= @Max{1}", BDVisitorSchema.TableAlias, BDVisitorSchema.ValidThru); 

			SqlParameter[] paras = new SqlParameter[2];
			paras[0] = new SqlParameter(string.Format("@Min{0}", BDVisitorSchema.ValidThru), SqlDbType.DateTime);
			paras[0].Value = begin;
			paras[1] = new SqlParameter(string.Format("@Max{0}", BDVisitorSchema.ValidThru), SqlDbType.DateTime);
			paras[1].Value = end;

			this._dal.ClearSortBy();
			this._dal.AddSortBy(BDVisitorSchema.ValidThru, false);
			return this.GetCollection(sql, paras);
		}
		public BDVisitorDataCollection GetByLikeLastName(System.String LastName)
		{
			string sql = string.Format(" WHERE [{0}].[{1}] LIKE @{1} ", BDVisitorSchema.TableAlias, BDVisitorSchema.LastName); 

			SqlParameter[] paras = new SqlParameter[1];
			paras[0] = new SqlParameter(string.Format("@{0}", BDVisitorSchema.LastName), SqlDbType.VarChar);
			paras[0].Value = string.Format("{0}%", LastName);

			return this.GetCollection(sql, paras);
		}
		public BDVisitorDataCollection GetByModifiedOn(DateTime begin, DateTime end)
		{
			string sql = string.Format(" WHERE [{0}].[{1}] >= @Min{1} AND [{0}].[{1}] <= @Max{1}", BDVisitorSchema.TableAlias, BDVisitorSchema.ModifiedOn); 

			SqlParameter[] paras = new SqlParameter[2];
			paras[0] = new SqlParameter(string.Format("@Min{0}", BDVisitorSchema.ModifiedOn), SqlDbType.DateTime);
			paras[0].Value = begin;
			paras[1] = new SqlParameter(string.Format("@Max{0}", BDVisitorSchema.ModifiedOn), SqlDbType.DateTime);
			paras[1].Value = end;

			this._dal.ClearSortBy();
			this._dal.AddSortBy(BDVisitorSchema.ModifiedOn, false);
			return this.GetCollection(sql, paras);
		}
	}

	public partial class UsrGroupDBRuleDataService
	{
		public UsrGroupDBRuleDataCollection GetByDBRuleID(System.Int32 DBRuleID)
		{
			string sql = string.Format(" WHERE [{0}].[{1}] = @{1} ", UsrGroupDBRuleSchema.TableAlias, UsrGroupDBRuleSchema.DBRuleID); 

			SqlParameter[] paras = new SqlParameter[1];
			paras[0] = new SqlParameter(string.Format("@{0}", UsrGroupDBRuleSchema.DBRuleID), SqlDbType.Int);
			paras[0].Value = DBRuleID;

			return this.GetCollection(sql, paras);
		}
	}

	public partial class ACPanelDataService
	{
		public ACPanelDataCollection GetByPanelTypeID(System.Int32 PanelTypeID)
		{
			string sql = string.Format(" WHERE [{0}].[{1}] = @{1} ", ACPanelSchema.TableAlias, ACPanelSchema.PanelTypeID); 

			SqlParameter[] paras = new SqlParameter[1];
			paras[0] = new SqlParameter(string.Format("@{0}", ACPanelSchema.PanelTypeID), SqlDbType.Int);
			paras[0].Value = PanelTypeID;

			return this.GetCollection(sql, paras);
		}
		public ACPanelDataCollection GetByLikeUnitPhone(System.String UnitPhone)
		{
			string sql = string.Format(" WHERE [{0}].[{1}] LIKE @{1} ", ACPanelSchema.TableAlias, ACPanelSchema.UnitPhone); 

			SqlParameter[] paras = new SqlParameter[1];
			paras[0] = new SqlParameter(string.Format("@{0}", ACPanelSchema.UnitPhone), SqlDbType.VarChar);
			paras[0].Value = string.Format("{0}%", UnitPhone);

			return this.GetCollection(sql, paras);
		}
		public ACPanelDataCollection GetByLikeUnitPhoneCallerID(System.String UnitPhoneCallerID)
		{
			string sql = string.Format(" WHERE [{0}].[{1}] LIKE @{1} ", ACPanelSchema.TableAlias, ACPanelSchema.UnitPhoneCallerID); 

			SqlParameter[] paras = new SqlParameter[1];
			paras[0] = new SqlParameter(string.Format("@{0}", ACPanelSchema.UnitPhoneCallerID), SqlDbType.VarChar);
			paras[0].Value = string.Format("{0}%", UnitPhoneCallerID);

			return this.GetCollection(sql, paras);
		}
		public ACPanelDataCollection GetByModifiedOn(DateTime begin, DateTime end)
		{
			string sql = string.Format(" WHERE [{0}].[{1}] >= @Min{1} AND [{0}].[{1}] <= @Max{1}", ACPanelSchema.TableAlias, ACPanelSchema.ModifiedOn); 

			SqlParameter[] paras = new SqlParameter[2];
			paras[0] = new SqlParameter(string.Format("@Min{0}", ACPanelSchema.ModifiedOn), SqlDbType.DateTime);
			paras[0].Value = begin;
			paras[1] = new SqlParameter(string.Format("@Max{0}", ACPanelSchema.ModifiedOn), SqlDbType.DateTime);
			paras[1].Value = end;

			this._dal.ClearSortBy();
			this._dal.AddSortBy(ACPanelSchema.ModifiedOn, false);
			return this.GetCollection(sql, paras);
		}
	}

	public partial class UsrAccountDBRuleDataService
	{
		public UsrAccountDBRuleDataCollection GetByDBRuleID(System.Int32 DBRuleID)
		{
			string sql = string.Format(" WHERE [{0}].[{1}] = @{1} ", UsrAccountDBRuleSchema.TableAlias, UsrAccountDBRuleSchema.DBRuleID); 

			SqlParameter[] paras = new SqlParameter[1];
			paras[0] = new SqlParameter(string.Format("@{0}", UsrAccountDBRuleSchema.DBRuleID), SqlDbType.Int);
			paras[0].Value = DBRuleID;

			return this.GetCollection(sql, paras);
		}
	}

	public partial class UsrGroupBRRuleDataService
	{
		public UsrGroupBRRuleDataCollection GetByBRRuleID(System.Int32 BRRuleID)
		{
			string sql = string.Format(" WHERE [{0}].[{1}] = @{1} ", UsrGroupBRRuleSchema.TableAlias, UsrGroupBRRuleSchema.BRRuleID); 

			SqlParameter[] paras = new SqlParameter[1];
			paras[0] = new SqlParameter(string.Format("@{0}", UsrGroupBRRuleSchema.BRRuleID), SqlDbType.Int);
			paras[0].Value = BRRuleID;

			return this.GetCollection(sql, paras);
		}
	}

	public partial class ACInputGroupInputMapDataService
	{
		public ACInputGroupInputMapDataCollection GetByModifiedOn(DateTime begin, DateTime end)
		{
			string sql = string.Format(" WHERE [{0}].[{1}] >= @Min{1} AND [{0}].[{1}] <= @Max{1}", ACInputGroupInputMapSchema.TableAlias, ACInputGroupInputMapSchema.ModifiedOn); 

			SqlParameter[] paras = new SqlParameter[2];
			paras[0] = new SqlParameter(string.Format("@Min{0}", ACInputGroupInputMapSchema.ModifiedOn), SqlDbType.DateTime);
			paras[0].Value = begin;
			paras[1] = new SqlParameter(string.Format("@Max{0}", ACInputGroupInputMapSchema.ModifiedOn), SqlDbType.DateTime);
			paras[1].Value = end;

			this._dal.ClearSortBy();
			this._dal.AddSortBy(ACInputGroupInputMapSchema.ModifiedOn, false);
			return this.GetCollection(sql, paras);
		}
	}

	public partial class UsrAccountBRRuleDataService
	{
		public UsrAccountBRRuleDataCollection GetByBRRuleID(System.Int32 BRRuleID)
		{
			string sql = string.Format(" WHERE [{0}].[{1}] = @{1} ", UsrAccountBRRuleSchema.TableAlias, UsrAccountBRRuleSchema.BRRuleID); 

			SqlParameter[] paras = new SqlParameter[1];
			paras[0] = new SqlParameter(string.Format("@{0}", UsrAccountBRRuleSchema.BRRuleID), SqlDbType.Int);
			paras[0].Value = BRRuleID;

			return this.GetCollection(sql, paras);
		}
	}

	public partial class UsrAccountTenantMapDataService
	{
		public UsrAccountTenantMapDataCollection GetByModifiedOn(DateTime begin, DateTime end)
		{
			string sql = string.Format(" WHERE [{0}].[{1}] >= @Min{1} AND [{0}].[{1}] <= @Max{1}", UsrAccountTenantMapSchema.TableAlias, UsrAccountTenantMapSchema.ModifiedOn); 

			SqlParameter[] paras = new SqlParameter[2];
			paras[0] = new SqlParameter(string.Format("@Min{0}", UsrAccountTenantMapSchema.ModifiedOn), SqlDbType.DateTime);
			paras[0].Value = begin;
			paras[1] = new SqlParameter(string.Format("@Max{0}", UsrAccountTenantMapSchema.ModifiedOn), SqlDbType.DateTime);
			paras[1].Value = end;

			this._dal.ClearSortBy();
			this._dal.AddSortBy(UsrAccountTenantMapSchema.ModifiedOn, false);
			return this.GetCollection(sql, paras);
		}
	}

}
