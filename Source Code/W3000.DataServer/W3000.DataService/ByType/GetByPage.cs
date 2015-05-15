using System;
using System.Text;
using W3000.Data;
using W3000.Schema;

namespace W3000.DataService
{
	public partial class ACIntvalHolidayMapDataService
	{
		public int GetAllCount()
		{
			string sql = string.Format("SELECT COUNT(*) FROM [{0}]", ACIntvalHolidayMapSchema.TableName);

			object obj = this._dal.ExecuteScalar(sql, null);
			if (obj == null)
				return 0;

			int count;
			if (!int.TryParse(obj.ToString(), out count))
			{
				return 0;
			}

			return count;
		}

		public ACIntvalHolidayMapDataCollection GetAllPage(int pageIndex, int pageSize)
		{
			StringBuilder builder = new StringBuilder();
			builder.Append("SELECT * FROM ( ");
			builder.AppendFormat("SELECT ROW_NUMBER() OVER( ORDER BY [{0}].[{1}]) as rowid, {2} FROM [{3}] [{4}] {5} ",
				ACIntvalHolidayMapSchema.TableAlias, ACIntvalHolidayMapSchema.ModifiedOn,
				this._dal.SQLColumns, ACIntvalHolidayMapSchema.TableName,
				ACIntvalHolidayMapSchema.TableAlias, this._dal.SQLLeftJoins);

			builder.Append(") T ");
			builder.AppendFormat("WHERE rowid BETWEEN {0} AND {1}", pageIndex * pageSize + 1, (pageIndex + 1) * pageSize);

			return this.Processing(this._dal.GetCollectionExBy(builder.ToString(), null));
		}
	}
	public partial class ACAccessLevelDetailDataService
	{
		public int GetAllCount()
		{
			string sql = string.Format("SELECT COUNT(*) FROM [{0}]", ACAccessLevelDetailSchema.TableName);

			object obj = this._dal.ExecuteScalar(sql, null);
			if (obj == null)
				return 0;

			int count;
			if (!int.TryParse(obj.ToString(), out count))
			{
				return 0;
			}

			return count;
		}

		public ACAccessLevelDetailDataCollection GetAllPage(int pageIndex, int pageSize)
		{
			StringBuilder builder = new StringBuilder();
			builder.Append("SELECT * FROM ( ");
			builder.AppendFormat("SELECT ROW_NUMBER() OVER( ORDER BY [{0}].[{1}]) as rowid, {2} FROM [{3}] [{4}] {5} ",
				ACAccessLevelDetailSchema.TableAlias, ACAccessLevelDetailSchema.ModifiedOn,
				this._dal.SQLColumns, ACAccessLevelDetailSchema.TableName,
				ACAccessLevelDetailSchema.TableAlias, this._dal.SQLLeftJoins);

			builder.Append(") T ");
			builder.AppendFormat("WHERE rowid BETWEEN {0} AND {1}", pageIndex * pageSize + 1, (pageIndex + 1) * pageSize);

			return this.Processing(this._dal.GetCollectionExBy(builder.ToString(), null));
		}
	}
	public partial class UsrAccountBuildingMapDataService
	{
		public int GetAllCount()
		{
			string sql = string.Format("SELECT COUNT(*) FROM [{0}]", UsrAccountBuildingMapSchema.TableName);

			object obj = this._dal.ExecuteScalar(sql, null);
			if (obj == null)
				return 0;

			int count;
			if (!int.TryParse(obj.ToString(), out count))
			{
				return 0;
			}

			return count;
		}

		public UsrAccountBuildingMapDataCollection GetAllPage(int pageIndex, int pageSize)
		{
			StringBuilder builder = new StringBuilder();
			builder.Append("SELECT * FROM ( ");
			builder.AppendFormat("SELECT ROW_NUMBER() OVER( ORDER BY [{0}].[{1}]) as rowid, {2} FROM [{3}] [{4}] {5} ",
				UsrAccountBuildingMapSchema.TableAlias, UsrAccountBuildingMapSchema.ModifiedOn,
				this._dal.SQLColumns, UsrAccountBuildingMapSchema.TableName,
				UsrAccountBuildingMapSchema.TableAlias, this._dal.SQLLeftJoins);

			builder.Append(") T ");
			builder.AppendFormat("WHERE rowid BETWEEN {0} AND {1}", pageIndex * pageSize + 1, (pageIndex + 1) * pageSize);

			return this.Processing(this._dal.GetCollectionExBy(builder.ToString(), null));
		}
	}
	public partial class BDBuildingDataService
	{
		public int GetAllCount()
		{
			string sql = string.Format("SELECT COUNT(*) FROM [{0}]", BDBuildingSchema.TableName);

			object obj = this._dal.ExecuteScalar(sql, null);
			if (obj == null)
				return 0;

			int count;
			if (!int.TryParse(obj.ToString(), out count))
			{
				return 0;
			}

			return count;
		}

		public BDBuildingDataCollection GetAllPage(int pageIndex, int pageSize)
		{
			StringBuilder builder = new StringBuilder();
			builder.Append("SELECT * FROM ( ");
			builder.AppendFormat("SELECT ROW_NUMBER() OVER( ORDER BY [{0}].[{1}]) as rowid, {2} FROM [{3}] [{4}] {5} ",
				BDBuildingSchema.TableAlias, BDBuildingSchema.ModifiedOn,
				this._dal.SQLColumns, BDBuildingSchema.TableName,
				BDBuildingSchema.TableAlias, this._dal.SQLLeftJoins);

			builder.Append(") T ");
			builder.AppendFormat("WHERE rowid BETWEEN {0} AND {1}", pageIndex * pageSize + 1, (pageIndex + 1) * pageSize);

			return this.Processing(this._dal.GetCollectionExBy(builder.ToString(), null));
		}
	}
	public partial class BDTenantDataService
	{
		public int GetAllCount()
		{
			string sql = string.Format("SELECT COUNT(*) FROM [{0}]", BDTenantSchema.TableName);

			object obj = this._dal.ExecuteScalar(sql, null);
			if (obj == null)
				return 0;

			int count;
			if (!int.TryParse(obj.ToString(), out count))
			{
				return 0;
			}

			return count;
		}

		public BDTenantDataCollection GetAllPage(int pageIndex, int pageSize)
		{
			StringBuilder builder = new StringBuilder();
			builder.Append("SELECT * FROM ( ");
			builder.AppendFormat("SELECT ROW_NUMBER() OVER( ORDER BY [{0}].[{1}]) as rowid, {2} FROM [{3}] [{4}] {5} ",
				BDTenantSchema.TableAlias, BDTenantSchema.ModifiedOn,
				this._dal.SQLColumns, BDTenantSchema.TableName,
				BDTenantSchema.TableAlias, this._dal.SQLLeftJoins);

			builder.Append(") T ");
			builder.AppendFormat("WHERE rowid BETWEEN {0} AND {1}", pageIndex * pageSize + 1, (pageIndex + 1) * pageSize);

			return this.Processing(this._dal.GetCollectionExBy(builder.ToString(), null));
		}
	}
	public partial class UtilSettingCategoryDataService
	{
		public int GetAllCount()
		{
			string sql = string.Format("SELECT COUNT(*) FROM [{0}]", UtilSettingCategorySchema.TableName);

			object obj = this._dal.ExecuteScalar(sql, null);
			if (obj == null)
				return 0;

			int count;
			if (!int.TryParse(obj.ToString(), out count))
			{
				return 0;
			}

			return count;
		}

		public UtilSettingCategoryDataCollection GetAllPage(int pageIndex, int pageSize)
		{
			StringBuilder builder = new StringBuilder();
			builder.Append("SELECT * FROM ( ");
			builder.AppendFormat("SELECT ROW_NUMBER() OVER( ORDER BY [{0}].[{1}]) as rowid, {2} FROM [{3}] [{4}] {5} ",
				UtilSettingCategorySchema.TableAlias, UtilSettingCategorySchema.ModifiedOn,
				this._dal.SQLColumns, UtilSettingCategorySchema.TableName,
				UtilSettingCategorySchema.TableAlias, this._dal.SQLLeftJoins);

			builder.Append(") T ");
			builder.AppendFormat("WHERE rowid BETWEEN {0} AND {1}", pageIndex * pageSize + 1, (pageIndex + 1) * pageSize);

			return this.Processing(this._dal.GetCollectionExBy(builder.ToString(), null));
		}
	}
	public partial class UtilSettingDetailDataService
	{
		public int GetAllCount()
		{
			string sql = string.Format("SELECT COUNT(*) FROM [{0}]", UtilSettingDetailSchema.TableName);

			object obj = this._dal.ExecuteScalar(sql, null);
			if (obj == null)
				return 0;

			int count;
			if (!int.TryParse(obj.ToString(), out count))
			{
				return 0;
			}

			return count;
		}

		public UtilSettingDetailDataCollection GetAllPage(int pageIndex, int pageSize)
		{
			StringBuilder builder = new StringBuilder();
			builder.Append("SELECT * FROM ( ");
			builder.AppendFormat("SELECT ROW_NUMBER() OVER( ORDER BY [{0}].[{1}]) as rowid, {2} FROM [{3}] [{4}] {5} ",
				UtilSettingDetailSchema.TableAlias, UtilSettingDetailSchema.ModifiedOn,
				this._dal.SQLColumns, UtilSettingDetailSchema.TableName,
				UtilSettingDetailSchema.TableAlias, this._dal.SQLLeftJoins);

			builder.Append(") T ");
			builder.AppendFormat("WHERE rowid BETWEEN {0} AND {1}", pageIndex * pageSize + 1, (pageIndex + 1) * pageSize);

			return this.Processing(this._dal.GetCollectionExBy(builder.ToString(), null));
		}
	}
	public partial class ACOutputGroupMainZoneMapDataService
	{
		public int GetAllCount()
		{
			string sql = string.Format("SELECT COUNT(*) FROM [{0}]", ACOutputGroupMainZoneMapSchema.TableName);

			object obj = this._dal.ExecuteScalar(sql, null);
			if (obj == null)
				return 0;

			int count;
			if (!int.TryParse(obj.ToString(), out count))
			{
				return 0;
			}

			return count;
		}

		public ACOutputGroupMainZoneMapDataCollection GetAllPage(int pageIndex, int pageSize)
		{
			StringBuilder builder = new StringBuilder();
			builder.Append("SELECT * FROM ( ");
			builder.AppendFormat("SELECT ROW_NUMBER() OVER( ORDER BY [{0}].[{1}]) as rowid, {2} FROM [{3}] [{4}] {5} ",
				ACOutputGroupMainZoneMapSchema.TableAlias, ACOutputGroupMainZoneMapSchema.ModifiedOn,
				this._dal.SQLColumns, ACOutputGroupMainZoneMapSchema.TableName,
				ACOutputGroupMainZoneMapSchema.TableAlias, this._dal.SQLLeftJoins);

			builder.Append(") T ");
			builder.AppendFormat("WHERE rowid BETWEEN {0} AND {1}", pageIndex * pageSize + 1, (pageIndex + 1) * pageSize);

			return this.Processing(this._dal.GetCollectionExBy(builder.ToString(), null));
		}
	}
	public partial class ACCardHolderDataService
	{
		public int GetAllCount()
		{
			string sql = string.Format("SELECT COUNT(*) FROM [{0}]", ACCardHolderSchema.TableName);

			object obj = this._dal.ExecuteScalar(sql, null);
			if (obj == null)
				return 0;

			int count;
			if (!int.TryParse(obj.ToString(), out count))
			{
				return 0;
			}

			return count;
		}

		public ACCardHolderDataCollection GetAllPage(int pageIndex, int pageSize)
		{
			StringBuilder builder = new StringBuilder();
			builder.Append("SELECT * FROM ( ");
			builder.AppendFormat("SELECT ROW_NUMBER() OVER( ORDER BY [{0}].[{1}]) as rowid, {2} FROM [{3}] [{4}] {5} ",
				ACCardHolderSchema.TableAlias, ACCardHolderSchema.ModifiedOn,
				this._dal.SQLColumns, ACCardHolderSchema.TableName,
				ACCardHolderSchema.TableAlias, this._dal.SQLLeftJoins);

			builder.Append(") T ");
			builder.AppendFormat("WHERE rowid BETWEEN {0} AND {1}", pageIndex * pageSize + 1, (pageIndex + 1) * pageSize);

			return this.Processing(this._dal.GetCollectionExBy(builder.ToString(), null));
		}
	}
	public partial class ACMainZoneDataService
	{
		public int GetAllCount()
		{
			string sql = string.Format("SELECT COUNT(*) FROM [{0}]", ACMainZoneSchema.TableName);

			object obj = this._dal.ExecuteScalar(sql, null);
			if (obj == null)
				return 0;

			int count;
			if (!int.TryParse(obj.ToString(), out count))
			{
				return 0;
			}

			return count;
		}

		public ACMainZoneDataCollection GetAllPage(int pageIndex, int pageSize)
		{
			StringBuilder builder = new StringBuilder();
			builder.Append("SELECT * FROM ( ");
			builder.AppendFormat("SELECT ROW_NUMBER() OVER( ORDER BY [{0}].[{1}]) as rowid, {2} FROM [{3}] [{4}] {5} ",
				ACMainZoneSchema.TableAlias, ACMainZoneSchema.ModifiedOn,
				this._dal.SQLColumns, ACMainZoneSchema.TableName,
				ACMainZoneSchema.TableAlias, this._dal.SQLLeftJoins);

			builder.Append(") T ");
			builder.AppendFormat("WHERE rowid BETWEEN {0} AND {1}", pageIndex * pageSize + 1, (pageIndex + 1) * pageSize);

			return this.Processing(this._dal.GetCollectionExBy(builder.ToString(), null));
		}
	}
	public partial class ACIntervalDataService
	{
		public int GetAllCount()
		{
			string sql = string.Format("SELECT COUNT(*) FROM [{0}]", ACIntervalSchema.TableName);

			object obj = this._dal.ExecuteScalar(sql, null);
			if (obj == null)
				return 0;

			int count;
			if (!int.TryParse(obj.ToString(), out count))
			{
				return 0;
			}

			return count;
		}

		public ACIntervalDataCollection GetAllPage(int pageIndex, int pageSize)
		{
			StringBuilder builder = new StringBuilder();
			builder.Append("SELECT * FROM ( ");
			builder.AppendFormat("SELECT ROW_NUMBER() OVER( ORDER BY [{0}].[{1}]) as rowid, {2} FROM [{3}] [{4}] {5} ",
				ACIntervalSchema.TableAlias, ACIntervalSchema.ModifiedOn,
				this._dal.SQLColumns, ACIntervalSchema.TableName,
				ACIntervalSchema.TableAlias, this._dal.SQLLeftJoins);

			builder.Append(") T ");
			builder.AppendFormat("WHERE rowid BETWEEN {0} AND {1}", pageIndex * pageSize + 1, (pageIndex + 1) * pageSize);

			return this.Processing(this._dal.GetCollectionExBy(builder.ToString(), null));
		}
	}
	public partial class ACPanelHolidayMapDataService
	{
		public int GetAllCount()
		{
			string sql = string.Format("SELECT COUNT(*) FROM [{0}]", ACPanelHolidayMapSchema.TableName);

			object obj = this._dal.ExecuteScalar(sql, null);
			if (obj == null)
				return 0;

			int count;
			if (!int.TryParse(obj.ToString(), out count))
			{
				return 0;
			}

			return count;
		}

		public ACPanelHolidayMapDataCollection GetAllPage(int pageIndex, int pageSize)
		{
			StringBuilder builder = new StringBuilder();
			builder.Append("SELECT * FROM ( ");
			builder.AppendFormat("SELECT ROW_NUMBER() OVER( ORDER BY [{0}].[{1}]) as rowid, {2} FROM [{3}] [{4}] {5} ",
				ACPanelHolidayMapSchema.TableAlias, ACPanelHolidayMapSchema.ModifiedOn,
				this._dal.SQLColumns, ACPanelHolidayMapSchema.TableName,
				ACPanelHolidayMapSchema.TableAlias, this._dal.SQLLeftJoins);

			builder.Append(") T ");
			builder.AppendFormat("WHERE rowid BETWEEN {0} AND {1}", pageIndex * pageSize + 1, (pageIndex + 1) * pageSize);

			return this.Processing(this._dal.GetCollectionExBy(builder.ToString(), null));
		}
	}
	public partial class ACTimecodeDataService
	{
		public int GetAllCount()
		{
			string sql = string.Format("SELECT COUNT(*) FROM [{0}]", ACTimecodeSchema.TableName);

			object obj = this._dal.ExecuteScalar(sql, null);
			if (obj == null)
				return 0;

			int count;
			if (!int.TryParse(obj.ToString(), out count))
			{
				return 0;
			}

			return count;
		}

		public ACTimecodeDataCollection GetAllPage(int pageIndex, int pageSize)
		{
			StringBuilder builder = new StringBuilder();
			builder.Append("SELECT * FROM ( ");
			builder.AppendFormat("SELECT ROW_NUMBER() OVER( ORDER BY [{0}].[{1}]) as rowid, {2} FROM [{3}] [{4}] {5} ",
				ACTimecodeSchema.TableAlias, ACTimecodeSchema.ModifiedOn,
				this._dal.SQLColumns, ACTimecodeSchema.TableName,
				ACTimecodeSchema.TableAlias, this._dal.SQLLeftJoins);

			builder.Append(") T ");
			builder.AppendFormat("WHERE rowid BETWEEN {0} AND {1}", pageIndex * pageSize + 1, (pageIndex + 1) * pageSize);

			return this.Processing(this._dal.GetCollectionExBy(builder.ToString(), null));
		}
	}
	public partial class ACTimecodeIntervalMapDataService
	{
		public int GetAllCount()
		{
			string sql = string.Format("SELECT COUNT(*) FROM [{0}]", ACTimecodeIntervalMapSchema.TableName);

			object obj = this._dal.ExecuteScalar(sql, null);
			if (obj == null)
				return 0;

			int count;
			if (!int.TryParse(obj.ToString(), out count))
			{
				return 0;
			}

			return count;
		}

		public ACTimecodeIntervalMapDataCollection GetAllPage(int pageIndex, int pageSize)
		{
			StringBuilder builder = new StringBuilder();
			builder.Append("SELECT * FROM ( ");
			builder.AppendFormat("SELECT ROW_NUMBER() OVER( ORDER BY [{0}].[{1}]) as rowid, {2} FROM [{3}] [{4}] {5} ",
				ACTimecodeIntervalMapSchema.TableAlias, ACTimecodeIntervalMapSchema.ModifiedOn,
				this._dal.SQLColumns, ACTimecodeIntervalMapSchema.TableName,
				ACTimecodeIntervalMapSchema.TableAlias, this._dal.SQLLeftJoins);

			builder.Append(") T ");
			builder.AppendFormat("WHERE rowid BETWEEN {0} AND {1}", pageIndex * pageSize + 1, (pageIndex + 1) * pageSize);

			return this.Processing(this._dal.GetCollectionExBy(builder.ToString(), null));
		}
	}
	public partial class ACAMFormatDataService
	{
		public int GetAllCount()
		{
			string sql = string.Format("SELECT COUNT(*) FROM [{0}]", ACAMFormatSchema.TableName);

			object obj = this._dal.ExecuteScalar(sql, null);
			if (obj == null)
				return 0;

			int count;
			if (!int.TryParse(obj.ToString(), out count))
			{
				return 0;
			}

			return count;
		}

		public ACAMFormatDataCollection GetAllPage(int pageIndex, int pageSize)
		{
			StringBuilder builder = new StringBuilder();
			builder.Append("SELECT * FROM ( ");
			builder.AppendFormat("SELECT ROW_NUMBER() OVER( ORDER BY [{0}].[{1}]) as rowid, {2} FROM [{3}] [{4}] {5} ",
				ACAMFormatSchema.TableAlias, ACAMFormatSchema.ModifiedOn,
				this._dal.SQLColumns, ACAMFormatSchema.TableName,
				ACAMFormatSchema.TableAlias, this._dal.SQLLeftJoins);

			builder.Append(") T ");
			builder.AppendFormat("WHERE rowid BETWEEN {0} AND {1}", pageIndex * pageSize + 1, (pageIndex + 1) * pageSize);

			return this.Processing(this._dal.GetCollectionExBy(builder.ToString(), null));
		}
	}
	public partial class BDBuildingHolidayMapDataService
	{
		public int GetAllCount()
		{
			string sql = string.Format("SELECT COUNT(*) FROM [{0}]", BDBuildingHolidayMapSchema.TableName);

			object obj = this._dal.ExecuteScalar(sql, null);
			if (obj == null)
				return 0;

			int count;
			if (!int.TryParse(obj.ToString(), out count))
			{
				return 0;
			}

			return count;
		}

		public BDBuildingHolidayMapDataCollection GetAllPage(int pageIndex, int pageSize)
		{
			StringBuilder builder = new StringBuilder();
			builder.Append("SELECT * FROM ( ");
			builder.AppendFormat("SELECT ROW_NUMBER() OVER( ORDER BY [{0}].[{1}]) as rowid, {2} FROM [{3}] [{4}] {5} ",
				BDBuildingHolidayMapSchema.TableAlias, BDBuildingHolidayMapSchema.ModifiedOn,
				this._dal.SQLColumns, BDBuildingHolidayMapSchema.TableName,
				BDBuildingHolidayMapSchema.TableAlias, this._dal.SQLLeftJoins);

			builder.Append(") T ");
			builder.AppendFormat("WHERE rowid BETWEEN {0} AND {1}", pageIndex * pageSize + 1, (pageIndex + 1) * pageSize);

			return this.Processing(this._dal.GetCollectionExBy(builder.ToString(), null));
		}
	}
	public partial class ACOutputGroupDataService
	{
		public int GetAllCount()
		{
			string sql = string.Format("SELECT COUNT(*) FROM [{0}]", ACOutputGroupSchema.TableName);

			object obj = this._dal.ExecuteScalar(sql, null);
			if (obj == null)
				return 0;

			int count;
			if (!int.TryParse(obj.ToString(), out count))
			{
				return 0;
			}

			return count;
		}

		public ACOutputGroupDataCollection GetAllPage(int pageIndex, int pageSize)
		{
			StringBuilder builder = new StringBuilder();
			builder.Append("SELECT * FROM ( ");
			builder.AppendFormat("SELECT ROW_NUMBER() OVER( ORDER BY [{0}].[{1}]) as rowid, {2} FROM [{3}] [{4}] {5} ",
				ACOutputGroupSchema.TableAlias, ACOutputGroupSchema.ModifiedOn,
				this._dal.SQLColumns, ACOutputGroupSchema.TableName,
				ACOutputGroupSchema.TableAlias, this._dal.SQLLeftJoins);

			builder.Append(") T ");
			builder.AppendFormat("WHERE rowid BETWEEN {0} AND {1}", pageIndex * pageSize + 1, (pageIndex + 1) * pageSize);

			return this.Processing(this._dal.GetCollectionExBy(builder.ToString(), null));
		}
	}
	public partial class BDTenantHolidayMapDataService
	{
		public int GetAllCount()
		{
			string sql = string.Format("SELECT COUNT(*) FROM [{0}]", BDTenantHolidayMapSchema.TableName);

			object obj = this._dal.ExecuteScalar(sql, null);
			if (obj == null)
				return 0;

			int count;
			if (!int.TryParse(obj.ToString(), out count))
			{
				return 0;
			}

			return count;
		}

		public BDTenantHolidayMapDataCollection GetAllPage(int pageIndex, int pageSize)
		{
			StringBuilder builder = new StringBuilder();
			builder.Append("SELECT * FROM ( ");
			builder.AppendFormat("SELECT ROW_NUMBER() OVER( ORDER BY [{0}].[{1}]) as rowid, {2} FROM [{3}] [{4}] {5} ",
				BDTenantHolidayMapSchema.TableAlias, BDTenantHolidayMapSchema.ModifiedOn,
				this._dal.SQLColumns, BDTenantHolidayMapSchema.TableName,
				BDTenantHolidayMapSchema.TableAlias, this._dal.SQLLeftJoins);

			builder.Append(") T ");
			builder.AppendFormat("WHERE rowid BETWEEN {0} AND {1}", pageIndex * pageSize + 1, (pageIndex + 1) * pageSize);

			return this.Processing(this._dal.GetCollectionExBy(builder.ToString(), null));
		}
	}
	public partial class ACInputGroupDataService
	{
		public int GetAllCount()
		{
			string sql = string.Format("SELECT COUNT(*) FROM [{0}]", ACInputGroupSchema.TableName);

			object obj = this._dal.ExecuteScalar(sql, null);
			if (obj == null)
				return 0;

			int count;
			if (!int.TryParse(obj.ToString(), out count))
			{
				return 0;
			}

			return count;
		}

		public ACInputGroupDataCollection GetAllPage(int pageIndex, int pageSize)
		{
			StringBuilder builder = new StringBuilder();
			builder.Append("SELECT * FROM ( ");
			builder.AppendFormat("SELECT ROW_NUMBER() OVER( ORDER BY [{0}].[{1}]) as rowid, {2} FROM [{3}] [{4}] {5} ",
				ACInputGroupSchema.TableAlias, ACInputGroupSchema.ModifiedOn,
				this._dal.SQLColumns, ACInputGroupSchema.TableName,
				ACInputGroupSchema.TableAlias, this._dal.SQLLeftJoins);

			builder.Append(") T ");
			builder.AppendFormat("WHERE rowid BETWEEN {0} AND {1}", pageIndex * pageSize + 1, (pageIndex + 1) * pageSize);

			return this.Processing(this._dal.GetCollectionExBy(builder.ToString(), null));
		}
	}
	public partial class ACInputDataService
	{
		public int GetAllCount()
		{
			string sql = string.Format("SELECT COUNT(*) FROM [{0}]", ACInputSchema.TableName);

			object obj = this._dal.ExecuteScalar(sql, null);
			if (obj == null)
				return 0;

			int count;
			if (!int.TryParse(obj.ToString(), out count))
			{
				return 0;
			}

			return count;
		}

		public ACInputDataCollection GetAllPage(int pageIndex, int pageSize)
		{
			StringBuilder builder = new StringBuilder();
			builder.Append("SELECT * FROM ( ");
			builder.AppendFormat("SELECT ROW_NUMBER() OVER( ORDER BY [{0}].[{1}]) as rowid, {2} FROM [{3}] [{4}] {5} ",
				ACInputSchema.TableAlias, ACInputSchema.ModifiedOn,
				this._dal.SQLColumns, ACInputSchema.TableName,
				ACInputSchema.TableAlias, this._dal.SQLLeftJoins);

			builder.Append(") T ");
			builder.AppendFormat("WHERE rowid BETWEEN {0} AND {1}", pageIndex * pageSize + 1, (pageIndex + 1) * pageSize);

			return this.Processing(this._dal.GetCollectionExBy(builder.ToString(), null));
		}
	}
	public partial class ACFunctionCardDataService
	{
		public int GetAllCount()
		{
			string sql = string.Format("SELECT COUNT(*) FROM [{0}]", ACFunctionCardSchema.TableName);

			object obj = this._dal.ExecuteScalar(sql, null);
			if (obj == null)
				return 0;

			int count;
			if (!int.TryParse(obj.ToString(), out count))
			{
				return 0;
			}

			return count;
		}

		public ACFunctionCardDataCollection GetAllPage(int pageIndex, int pageSize)
		{
			StringBuilder builder = new StringBuilder();
			builder.Append("SELECT * FROM ( ");
			builder.AppendFormat("SELECT ROW_NUMBER() OVER( ORDER BY [{0}].[{1}]) as rowid, {2} FROM [{3}] [{4}] {5} ",
				ACFunctionCardSchema.TableAlias, ACFunctionCardSchema.ModifiedOn,
				this._dal.SQLColumns, ACFunctionCardSchema.TableName,
				ACFunctionCardSchema.TableAlias, this._dal.SQLLeftJoins);

			builder.Append(") T ");
			builder.AppendFormat("WHERE rowid BETWEEN {0} AND {1}", pageIndex * pageSize + 1, (pageIndex + 1) * pageSize);

			return this.Processing(this._dal.GetCollectionExBy(builder.ToString(), null));
		}
	}
	public partial class ACAccessLevelDataService
	{
		public int GetAllCount()
		{
			string sql = string.Format("SELECT COUNT(*) FROM [{0}]", ACAccessLevelSchema.TableName);

			object obj = this._dal.ExecuteScalar(sql, null);
			if (obj == null)
				return 0;

			int count;
			if (!int.TryParse(obj.ToString(), out count))
			{
				return 0;
			}

			return count;
		}

		public ACAccessLevelDataCollection GetAllPage(int pageIndex, int pageSize)
		{
			StringBuilder builder = new StringBuilder();
			builder.Append("SELECT * FROM ( ");
			builder.AppendFormat("SELECT ROW_NUMBER() OVER( ORDER BY [{0}].[{1}]) as rowid, {2} FROM [{3}] [{4}] {5} ",
				ACAccessLevelSchema.TableAlias, ACAccessLevelSchema.ModifiedOn,
				this._dal.SQLColumns, ACAccessLevelSchema.TableName,
				ACAccessLevelSchema.TableAlias, this._dal.SQLLeftJoins);

			builder.Append(") T ");
			builder.AppendFormat("WHERE rowid BETWEEN {0} AND {1}", pageIndex * pageSize + 1, (pageIndex + 1) * pageSize);

			return this.Processing(this._dal.GetCollectionExBy(builder.ToString(), null));
		}
	}
	public partial class ACPanelFunctionCardMapDataService
	{
		public int GetAllCount()
		{
			string sql = string.Format("SELECT COUNT(*) FROM [{0}]", ACPanelFunctionCardMapSchema.TableName);

			object obj = this._dal.ExecuteScalar(sql, null);
			if (obj == null)
				return 0;

			int count;
			if (!int.TryParse(obj.ToString(), out count))
			{
				return 0;
			}

			return count;
		}

		public ACPanelFunctionCardMapDataCollection GetAllPage(int pageIndex, int pageSize)
		{
			StringBuilder builder = new StringBuilder();
			builder.Append("SELECT * FROM ( ");
			builder.AppendFormat("SELECT ROW_NUMBER() OVER( ORDER BY [{0}].[{1}]) as rowid, {2} FROM [{3}] [{4}] {5} ",
				ACPanelFunctionCardMapSchema.TableAlias, ACPanelFunctionCardMapSchema.ModifiedOn,
				this._dal.SQLColumns, ACPanelFunctionCardMapSchema.TableName,
				ACPanelFunctionCardMapSchema.TableAlias, this._dal.SQLLeftJoins);

			builder.Append(") T ");
			builder.AppendFormat("WHERE rowid BETWEEN {0} AND {1}", pageIndex * pageSize + 1, (pageIndex + 1) * pageSize);

			return this.Processing(this._dal.GetCollectionExBy(builder.ToString(), null));
		}
	}
	public partial class UtilHolidayDataService
	{
		public int GetAllCount()
		{
			string sql = string.Format("SELECT COUNT(*) FROM [{0}]", UtilHolidaySchema.TableName);

			object obj = this._dal.ExecuteScalar(sql, null);
			if (obj == null)
				return 0;

			int count;
			if (!int.TryParse(obj.ToString(), out count))
			{
				return 0;
			}

			return count;
		}

		public UtilHolidayDataCollection GetAllPage(int pageIndex, int pageSize)
		{
			StringBuilder builder = new StringBuilder();
			builder.Append("SELECT * FROM ( ");
			builder.AppendFormat("SELECT ROW_NUMBER() OVER( ORDER BY [{0}].[{1}]) as rowid, {2} FROM [{3}] [{4}] {5} ",
				UtilHolidaySchema.TableAlias, UtilHolidaySchema.ModifiedOn,
				this._dal.SQLColumns, UtilHolidaySchema.TableName,
				UtilHolidaySchema.TableAlias, this._dal.SQLLeftJoins);

			builder.Append(") T ");
			builder.AppendFormat("WHERE rowid BETWEEN {0} AND {1}", pageIndex * pageSize + 1, (pageIndex + 1) * pageSize);

			return this.Processing(this._dal.GetCollectionExBy(builder.ToString(), null));
		}
	}
	public partial class UsrAccountDataService
	{
		public int GetAllCount()
		{
			string sql = string.Format("SELECT COUNT(*) FROM [{0}]", UsrAccountSchema.TableName);

			object obj = this._dal.ExecuteScalar(sql, null);
			if (obj == null)
				return 0;

			int count;
			if (!int.TryParse(obj.ToString(), out count))
			{
				return 0;
			}

			return count;
		}

		public UsrAccountDataCollection GetAllPage(int pageIndex, int pageSize)
		{
			StringBuilder builder = new StringBuilder();
			builder.Append("SELECT * FROM ( ");
			builder.AppendFormat("SELECT ROW_NUMBER() OVER( ORDER BY [{0}].[{1}]) as rowid, {2} FROM [{3}] [{4}] {5} ",
				UsrAccountSchema.TableAlias, UsrAccountSchema.ModifiedOn,
				this._dal.SQLColumns, UsrAccountSchema.TableName,
				UsrAccountSchema.TableAlias, this._dal.SQLLeftJoins);

			builder.Append(") T ");
			builder.AppendFormat("WHERE rowid BETWEEN {0} AND {1}", pageIndex * pageSize + 1, (pageIndex + 1) * pageSize);

			return this.Processing(this._dal.GetCollectionExBy(builder.ToString(), null));
		}
	}
	public partial class ACMasterCardDataService
	{
		public int GetAllCount()
		{
			string sql = string.Format("SELECT COUNT(*) FROM [{0}]", ACMasterCardSchema.TableName);

			object obj = this._dal.ExecuteScalar(sql, null);
			if (obj == null)
				return 0;

			int count;
			if (!int.TryParse(obj.ToString(), out count))
			{
				return 0;
			}

			return count;
		}

		public ACMasterCardDataCollection GetAllPage(int pageIndex, int pageSize)
		{
			StringBuilder builder = new StringBuilder();
			builder.Append("SELECT * FROM ( ");
			builder.AppendFormat("SELECT ROW_NUMBER() OVER( ORDER BY [{0}].[{1}]) as rowid, {2} FROM [{3}] [{4}] {5} ",
				ACMasterCardSchema.TableAlias, ACMasterCardSchema.ModifiedOn,
				this._dal.SQLColumns, ACMasterCardSchema.TableName,
				ACMasterCardSchema.TableAlias, this._dal.SQLLeftJoins);

			builder.Append(") T ");
			builder.AppendFormat("WHERE rowid BETWEEN {0} AND {1}", pageIndex * pageSize + 1, (pageIndex + 1) * pageSize);

			return this.Processing(this._dal.GetCollectionExBy(builder.ToString(), null));
		}
	}
	public partial class ACSupervisoryDataService
	{
		public int GetAllCount()
		{
			string sql = string.Format("SELECT COUNT(*) FROM [{0}]", ACSupervisorySchema.TableName);

			object obj = this._dal.ExecuteScalar(sql, null);
			if (obj == null)
				return 0;

			int count;
			if (!int.TryParse(obj.ToString(), out count))
			{
				return 0;
			}

			return count;
		}

		public ACSupervisoryDataCollection GetAllPage(int pageIndex, int pageSize)
		{
			StringBuilder builder = new StringBuilder();
			builder.Append("SELECT * FROM ( ");
			builder.AppendFormat("SELECT ROW_NUMBER() OVER( ORDER BY [{0}].[{1}]) as rowid, {2} FROM [{3}] [{4}] {5} ",
				ACSupervisorySchema.TableAlias, ACSupervisorySchema.ModifiedOn,
				this._dal.SQLColumns, ACSupervisorySchema.TableName,
				ACSupervisorySchema.TableAlias, this._dal.SQLLeftJoins);

			builder.Append(") T ");
			builder.AppendFormat("WHERE rowid BETWEEN {0} AND {1}", pageIndex * pageSize + 1, (pageIndex + 1) * pageSize);

			return this.Processing(this._dal.GetCollectionExBy(builder.ToString(), null));
		}
	}
	public partial class UsrGroupDataService
	{
		public int GetAllCount()
		{
			string sql = string.Format("SELECT COUNT(*) FROM [{0}]", UsrGroupSchema.TableName);

			object obj = this._dal.ExecuteScalar(sql, null);
			if (obj == null)
				return 0;

			int count;
			if (!int.TryParse(obj.ToString(), out count))
			{
				return 0;
			}

			return count;
		}

		public UsrGroupDataCollection GetAllPage(int pageIndex, int pageSize)
		{
			StringBuilder builder = new StringBuilder();
			builder.Append("SELECT * FROM ( ");
			builder.AppendFormat("SELECT ROW_NUMBER() OVER( ORDER BY [{0}].[{1}]) as rowid, {2} FROM [{3}] [{4}] {5} ",
				UsrGroupSchema.TableAlias, UsrGroupSchema.ModifiedOn,
				this._dal.SQLColumns, UsrGroupSchema.TableName,
				UsrGroupSchema.TableAlias, this._dal.SQLLeftJoins);

			builder.Append(") T ");
			builder.AppendFormat("WHERE rowid BETWEEN {0} AND {1}", pageIndex * pageSize + 1, (pageIndex + 1) * pageSize);

			return this.Processing(this._dal.GetCollectionExBy(builder.ToString(), null));
		}
	}
	public partial class ACCardHolderBuildingMapDataService
	{
		public int GetAllCount()
		{
			string sql = string.Format("SELECT COUNT(*) FROM [{0}]", ACCardHolderBuildingMapSchema.TableName);

			object obj = this._dal.ExecuteScalar(sql, null);
			if (obj == null)
				return 0;

			int count;
			if (!int.TryParse(obj.ToString(), out count))
			{
				return 0;
			}

			return count;
		}

		public ACCardHolderBuildingMapDataCollection GetAllPage(int pageIndex, int pageSize)
		{
			StringBuilder builder = new StringBuilder();
			builder.Append("SELECT * FROM ( ");
			builder.AppendFormat("SELECT ROW_NUMBER() OVER( ORDER BY [{0}].[{1}]) as rowid, {2} FROM [{3}] [{4}] {5} ",
				ACCardHolderBuildingMapSchema.TableAlias, ACCardHolderBuildingMapSchema.ModifiedOn,
				this._dal.SQLColumns, ACCardHolderBuildingMapSchema.TableName,
				ACCardHolderBuildingMapSchema.TableAlias, this._dal.SQLLeftJoins);

			builder.Append(") T ");
			builder.AppendFormat("WHERE rowid BETWEEN {0} AND {1}", pageIndex * pageSize + 1, (pageIndex + 1) * pageSize);

			return this.Processing(this._dal.GetCollectionExBy(builder.ToString(), null));
		}
	}
	public partial class BDVisitorDataService
	{
		public int GetAllCount()
		{
			string sql = string.Format("SELECT COUNT(*) FROM [{0}]", BDVisitorSchema.TableName);

			object obj = this._dal.ExecuteScalar(sql, null);
			if (obj == null)
				return 0;

			int count;
			if (!int.TryParse(obj.ToString(), out count))
			{
				return 0;
			}

			return count;
		}

		public BDVisitorDataCollection GetAllPage(int pageIndex, int pageSize)
		{
			StringBuilder builder = new StringBuilder();
			builder.Append("SELECT * FROM ( ");
			builder.AppendFormat("SELECT ROW_NUMBER() OVER( ORDER BY [{0}].[{1}]) as rowid, {2} FROM [{3}] [{4}] {5} ",
				BDVisitorSchema.TableAlias, BDVisitorSchema.ModifiedOn,
				this._dal.SQLColumns, BDVisitorSchema.TableName,
				BDVisitorSchema.TableAlias, this._dal.SQLLeftJoins);

			builder.Append(") T ");
			builder.AppendFormat("WHERE rowid BETWEEN {0} AND {1}", pageIndex * pageSize + 1, (pageIndex + 1) * pageSize);

			return this.Processing(this._dal.GetCollectionExBy(builder.ToString(), null));
		}
	}
	public partial class UsrGroupDBRuleDataService
	{
		public int GetAllCount()
		{
			string sql = string.Format("SELECT COUNT(*) FROM [{0}]", UsrGroupDBRuleSchema.TableName);

			object obj = this._dal.ExecuteScalar(sql, null);
			if (obj == null)
				return 0;

			int count;
			if (!int.TryParse(obj.ToString(), out count))
			{
				return 0;
			}

			return count;
		}

		public UsrGroupDBRuleDataCollection GetAllPage(int pageIndex, int pageSize)
		{
			StringBuilder builder = new StringBuilder();
			builder.Append("SELECT * FROM ( ");
			builder.AppendFormat("SELECT ROW_NUMBER() OVER( ORDER BY [{0}].[{1}]) as rowid, {2} FROM [{3}] [{4}] {5} ",
				UsrGroupDBRuleSchema.TableAlias, UsrGroupDBRuleSchema.ModifiedOn,
				this._dal.SQLColumns, UsrGroupDBRuleSchema.TableName,
				UsrGroupDBRuleSchema.TableAlias, this._dal.SQLLeftJoins);

			builder.Append(") T ");
			builder.AppendFormat("WHERE rowid BETWEEN {0} AND {1}", pageIndex * pageSize + 1, (pageIndex + 1) * pageSize);

			return this.Processing(this._dal.GetCollectionExBy(builder.ToString(), null));
		}
	}
	public partial class ACPanelDataService
	{
		public int GetAllCount()
		{
			string sql = string.Format("SELECT COUNT(*) FROM [{0}]", ACPanelSchema.TableName);

			object obj = this._dal.ExecuteScalar(sql, null);
			if (obj == null)
				return 0;

			int count;
			if (!int.TryParse(obj.ToString(), out count))
			{
				return 0;
			}

			return count;
		}

		public ACPanelDataCollection GetAllPage(int pageIndex, int pageSize)
		{
			StringBuilder builder = new StringBuilder();
			builder.Append("SELECT * FROM ( ");
			builder.AppendFormat("SELECT ROW_NUMBER() OVER( ORDER BY [{0}].[{1}]) as rowid, {2} FROM [{3}] [{4}] {5} ",
				ACPanelSchema.TableAlias, ACPanelSchema.ModifiedOn,
				this._dal.SQLColumns, ACPanelSchema.TableName,
				ACPanelSchema.TableAlias, this._dal.SQLLeftJoins);

			builder.Append(") T ");
			builder.AppendFormat("WHERE rowid BETWEEN {0} AND {1}", pageIndex * pageSize + 1, (pageIndex + 1) * pageSize);

			return this.Processing(this._dal.GetCollectionExBy(builder.ToString(), null));
		}
	}
	public partial class UsrAccountDBRuleDataService
	{
		public int GetAllCount()
		{
			string sql = string.Format("SELECT COUNT(*) FROM [{0}]", UsrAccountDBRuleSchema.TableName);

			object obj = this._dal.ExecuteScalar(sql, null);
			if (obj == null)
				return 0;

			int count;
			if (!int.TryParse(obj.ToString(), out count))
			{
				return 0;
			}

			return count;
		}

		public UsrAccountDBRuleDataCollection GetAllPage(int pageIndex, int pageSize)
		{
			StringBuilder builder = new StringBuilder();
			builder.Append("SELECT * FROM ( ");
			builder.AppendFormat("SELECT ROW_NUMBER() OVER( ORDER BY [{0}].[{1}]) as rowid, {2} FROM [{3}] [{4}] {5} ",
				UsrAccountDBRuleSchema.TableAlias, UsrAccountDBRuleSchema.ModifiedOn,
				this._dal.SQLColumns, UsrAccountDBRuleSchema.TableName,
				UsrAccountDBRuleSchema.TableAlias, this._dal.SQLLeftJoins);

			builder.Append(") T ");
			builder.AppendFormat("WHERE rowid BETWEEN {0} AND {1}", pageIndex * pageSize + 1, (pageIndex + 1) * pageSize);

			return this.Processing(this._dal.GetCollectionExBy(builder.ToString(), null));
		}
	}
	public partial class UsrGroupBRRuleDataService
	{
		public int GetAllCount()
		{
			string sql = string.Format("SELECT COUNT(*) FROM [{0}]", UsrGroupBRRuleSchema.TableName);

			object obj = this._dal.ExecuteScalar(sql, null);
			if (obj == null)
				return 0;

			int count;
			if (!int.TryParse(obj.ToString(), out count))
			{
				return 0;
			}

			return count;
		}

		public UsrGroupBRRuleDataCollection GetAllPage(int pageIndex, int pageSize)
		{
			StringBuilder builder = new StringBuilder();
			builder.Append("SELECT * FROM ( ");
			builder.AppendFormat("SELECT ROW_NUMBER() OVER( ORDER BY [{0}].[{1}]) as rowid, {2} FROM [{3}] [{4}] {5} ",
				UsrGroupBRRuleSchema.TableAlias, UsrGroupBRRuleSchema.ModifiedOn,
				this._dal.SQLColumns, UsrGroupBRRuleSchema.TableName,
				UsrGroupBRRuleSchema.TableAlias, this._dal.SQLLeftJoins);

			builder.Append(") T ");
			builder.AppendFormat("WHERE rowid BETWEEN {0} AND {1}", pageIndex * pageSize + 1, (pageIndex + 1) * pageSize);

			return this.Processing(this._dal.GetCollectionExBy(builder.ToString(), null));
		}
	}
	public partial class ACInputGroupInputMapDataService
	{
		public int GetAllCount()
		{
			string sql = string.Format("SELECT COUNT(*) FROM [{0}]", ACInputGroupInputMapSchema.TableName);

			object obj = this._dal.ExecuteScalar(sql, null);
			if (obj == null)
				return 0;

			int count;
			if (!int.TryParse(obj.ToString(), out count))
			{
				return 0;
			}

			return count;
		}

		public ACInputGroupInputMapDataCollection GetAllPage(int pageIndex, int pageSize)
		{
			StringBuilder builder = new StringBuilder();
			builder.Append("SELECT * FROM ( ");
			builder.AppendFormat("SELECT ROW_NUMBER() OVER( ORDER BY [{0}].[{1}]) as rowid, {2} FROM [{3}] [{4}] {5} ",
				ACInputGroupInputMapSchema.TableAlias, ACInputGroupInputMapSchema.ModifiedOn,
				this._dal.SQLColumns, ACInputGroupInputMapSchema.TableName,
				ACInputGroupInputMapSchema.TableAlias, this._dal.SQLLeftJoins);

			builder.Append(") T ");
			builder.AppendFormat("WHERE rowid BETWEEN {0} AND {1}", pageIndex * pageSize + 1, (pageIndex + 1) * pageSize);

			return this.Processing(this._dal.GetCollectionExBy(builder.ToString(), null));
		}
	}
	public partial class UsrAccountBRRuleDataService
	{
		public int GetAllCount()
		{
			string sql = string.Format("SELECT COUNT(*) FROM [{0}]", UsrAccountBRRuleSchema.TableName);

			object obj = this._dal.ExecuteScalar(sql, null);
			if (obj == null)
				return 0;

			int count;
			if (!int.TryParse(obj.ToString(), out count))
			{
				return 0;
			}

			return count;
		}

		public UsrAccountBRRuleDataCollection GetAllPage(int pageIndex, int pageSize)
		{
			StringBuilder builder = new StringBuilder();
			builder.Append("SELECT * FROM ( ");
			builder.AppendFormat("SELECT ROW_NUMBER() OVER( ORDER BY [{0}].[{1}]) as rowid, {2} FROM [{3}] [{4}] {5} ",
				UsrAccountBRRuleSchema.TableAlias, UsrAccountBRRuleSchema.ModifiedOn,
				this._dal.SQLColumns, UsrAccountBRRuleSchema.TableName,
				UsrAccountBRRuleSchema.TableAlias, this._dal.SQLLeftJoins);

			builder.Append(") T ");
			builder.AppendFormat("WHERE rowid BETWEEN {0} AND {1}", pageIndex * pageSize + 1, (pageIndex + 1) * pageSize);

			return this.Processing(this._dal.GetCollectionExBy(builder.ToString(), null));
		}
	}
	public partial class UsrAccountTenantMapDataService
	{
		public int GetAllCount()
		{
			string sql = string.Format("SELECT COUNT(*) FROM [{0}]", UsrAccountTenantMapSchema.TableName);

			object obj = this._dal.ExecuteScalar(sql, null);
			if (obj == null)
				return 0;

			int count;
			if (!int.TryParse(obj.ToString(), out count))
			{
				return 0;
			}

			return count;
		}

		public UsrAccountTenantMapDataCollection GetAllPage(int pageIndex, int pageSize)
		{
			StringBuilder builder = new StringBuilder();
			builder.Append("SELECT * FROM ( ");
			builder.AppendFormat("SELECT ROW_NUMBER() OVER( ORDER BY [{0}].[{1}]) as rowid, {2} FROM [{3}] [{4}] {5} ",
				UsrAccountTenantMapSchema.TableAlias, UsrAccountTenantMapSchema.ModifiedOn,
				this._dal.SQLColumns, UsrAccountTenantMapSchema.TableName,
				UsrAccountTenantMapSchema.TableAlias, this._dal.SQLLeftJoins);

			builder.Append(") T ");
			builder.AppendFormat("WHERE rowid BETWEEN {0} AND {1}", pageIndex * pageSize + 1, (pageIndex + 1) * pageSize);

			return this.Processing(this._dal.GetCollectionExBy(builder.ToString(), null));
		}
	}
}
