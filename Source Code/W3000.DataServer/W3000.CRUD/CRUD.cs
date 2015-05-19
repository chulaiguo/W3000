using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Cheke.DataAccess;
using Cheke.BusinessEntity;
using W3000.Data;

namespace W3000.CRUD
{
	public class ACIntvalHolidayMapCRUD : DataAccessBase
	{
		private string _tableName = "ACIntvalHolidayMap";

		public ACIntvalHolidayMapCRUD(string connectionString) : base(connectionString)
		{
		}

		public virtual string TableName
		{
			get { return this._tableName; }
			set { this._tableName = value; }
		}

		public string SQLColumns
		{
			get
			{
				return "[ACIntvalHolidayMap].[ACIntvalHolidayMapPK] AS [ACIntvalHolidayMapPK],[ACIntvalHolidayMap].[ACIntervalPK] AS [ACIntervalPK],[ACIntvalHolidayMap].[UtilHolidayPK] AS [UtilHolidayPK],[ACIntvalHolidayMap].[RowVersion] AS [RowVersion],[ACIntvalHolidayMap].[CreatedOn] AS [CreatedOn],[ACIntvalHolidayMap].[CreatedBy] AS [CreatedBy],[ACIntvalHolidayMap].[ModifiedOn] AS [ModifiedOn],[ACIntvalHolidayMap].[ModifiedBy] AS [ModifiedBy],[ACInterval].[End] AS [End],[ACInterval].[Begin] AS [Begin],[ACInterval].[IVID] AS [IVID],[ACInterval].[BDBuildingPK] AS [BDBuildingPK],[UtilHoliday].[Date] AS [Date],[UtilHoliday].[Holiday] AS [Holiday],[BDBuilding].[Address1] AS [Address1],[BDBuilding].[BuildingID] AS [BuildingID]";
			}
		}

		public string SQLLeftJoins
		{
			get
			{
				return "LEFT JOIN [ACInterval] [ACInterval] ON [ACIntvalHolidayMap].[ACIntervalPK] = [ACInterval].[ACIntervalPK] LEFT JOIN [UtilHoliday] [UtilHoliday] ON [ACIntvalHolidayMap].[UtilHolidayPK] = [UtilHoliday].[UtilHolidayPK] LEFT JOIN [BDBuilding] [BDBuilding] ON [ACInterval].[BDBuildingPK] = [BDBuilding].[BDBuildingPK]";
			}
		}

		protected override string SQLSelect
		{
			get
			{
				return string.Format("SELECT [ACIntvalHolidayMap].[ACIntvalHolidayMapPK] AS [ACIntvalHolidayMapPK],[ACIntvalHolidayMap].[ACIntervalPK] AS [ACIntervalPK],[ACIntvalHolidayMap].[UtilHolidayPK] AS [UtilHolidayPK],[ACIntvalHolidayMap].[RowVersion] AS [RowVersion],[ACIntvalHolidayMap].[CreatedOn] AS [CreatedOn],[ACIntvalHolidayMap].[CreatedBy] AS [CreatedBy],[ACIntvalHolidayMap].[ModifiedOn] AS [ModifiedOn],[ACIntvalHolidayMap].[ModifiedBy] AS [ModifiedBy],[ACInterval].[End] AS [End],[ACInterval].[Begin] AS [Begin],[ACInterval].[IVID] AS [IVID],[ACInterval].[BDBuildingPK] AS [BDBuildingPK],[UtilHoliday].[Date] AS [Date],[UtilHoliday].[Holiday] AS [Holiday],[BDBuilding].[Address1] AS [Address1],[BDBuilding].[BuildingID] AS [BuildingID] FROM [{0}] [ACIntvalHolidayMap] LEFT JOIN [ACInterval] [ACInterval] ON [ACIntvalHolidayMap].[ACIntervalPK] = [ACInterval].[ACIntervalPK] LEFT JOIN [UtilHoliday] [UtilHoliday] ON [ACIntvalHolidayMap].[UtilHolidayPK] = [UtilHoliday].[UtilHolidayPK] LEFT JOIN [BDBuilding] [BDBuilding] ON [ACInterval].[BDBuildingPK] = [BDBuilding].[BDBuildingPK]", this.TableName);
			}
		}

		protected override string SQLCount
		{
			get
			{
				return string.Format("SELECT COUNT(*) FROM [{0}] [ACIntvalHolidayMap] LEFT JOIN [ACInterval] [ACInterval] ON [ACIntvalHolidayMap].[ACIntervalPK] = [ACInterval].[ACIntervalPK] LEFT JOIN [UtilHoliday] [UtilHoliday] ON [ACIntvalHolidayMap].[UtilHolidayPK] = [UtilHoliday].[UtilHolidayPK] LEFT JOIN [BDBuilding] [BDBuilding] ON [ACInterval].[BDBuildingPK] = [BDBuilding].[BDBuildingPK]", this.TableName);
			}
		}

		public int Insert(ACIntvalHolidayMapData entity)
		{
			string sql = string.Format("INSERT INTO [{0}] ([ACIntvalHolidayMapPK],[ACIntervalPK],[UtilHolidayPK],[CreatedOn],[CreatedBy],[ModifiedOn],[ModifiedBy]) VALUES(@ACIntvalHolidayMapPK,@ACIntervalPK,@UtilHolidayPK,@CreatedOn,@CreatedBy,@ModifiedOn,@ModifiedBy)", this.TableName);
			SqlParameter[] paras = new SqlParameter[7];
			paras[0] = new SqlParameter("@ACIntvalHolidayMapPK", SqlDbType.UniqueIdentifier);
			if (entity.ACIntvalHolidayMapPK == Guid.Empty)
			{
				paras[0].Value = DBNull.Value;
			}
			else
			{
				paras[0].Value = entity.ACIntvalHolidayMapPK;
			}
			paras[1] = new SqlParameter("@ACIntervalPK", SqlDbType.UniqueIdentifier);
			if (entity.ACIntervalPK == Guid.Empty)
			{
				paras[1].Value = DBNull.Value;
			}
			else
			{
				paras[1].Value = entity.ACIntervalPK;
			}
			paras[2] = new SqlParameter("@UtilHolidayPK", SqlDbType.UniqueIdentifier);
			if (entity.UtilHolidayPK == Guid.Empty)
			{
				paras[2].Value = DBNull.Value;
			}
			else
			{
				paras[2].Value = entity.UtilHolidayPK;
			}
			paras[3] = new SqlParameter("@CreatedOn", SqlDbType.DateTime);
			paras[3].Value = entity.CreatedOn;
			paras[4] = new SqlParameter("@CreatedBy", SqlDbType.VarChar, 30);
			paras[4].Value = entity.CreatedBy;
			paras[5] = new SqlParameter("@ModifiedOn", SqlDbType.DateTime);
			paras[5].Value = entity.ModifiedOn;
			paras[6] = new SqlParameter("@ModifiedBy", SqlDbType.VarChar, 30);
			paras[6].Value = entity.ModifiedBy;
			return base.ExecuteNonQuery(sql, paras);
		}

		public int Update(ACIntvalHolidayMapData entity)
		{
			string sql = string.Format("UPDATE [{0}] SET [ACIntervalPK] = @ACIntervalPK,[UtilHolidayPK] = @UtilHolidayPK,[CreatedOn] = @CreatedOn,[CreatedBy] = @CreatedBy,[ModifiedOn] = @ModifiedOn,[ModifiedBy] = @ModifiedBy  WHERE [ACIntvalHolidayMapPK] = @ACIntvalHolidayMapPK AND [RowVersion] = @RowVersion", this.TableName);
			SqlParameter[] paras = new SqlParameter[8];
			paras[0] = new SqlParameter("@ACIntvalHolidayMapPK", SqlDbType.UniqueIdentifier);
			if (entity.ACIntvalHolidayMapPK == Guid.Empty)
			{
				paras[0].Value = DBNull.Value;
			}
			else
			{
				paras[0].Value = entity.ACIntvalHolidayMapPK;
			}
			paras[1] = new SqlParameter("@ACIntervalPK", SqlDbType.UniqueIdentifier);
			if (entity.ACIntervalPK == Guid.Empty)
			{
				paras[1].Value = DBNull.Value;
			}
			else
			{
				paras[1].Value = entity.ACIntervalPK;
			}
			paras[2] = new SqlParameter("@UtilHolidayPK", SqlDbType.UniqueIdentifier);
			if (entity.UtilHolidayPK == Guid.Empty)
			{
				paras[2].Value = DBNull.Value;
			}
			else
			{
				paras[2].Value = entity.UtilHolidayPK;
			}
			paras[3] = new SqlParameter("@RowVersion", SqlDbType.Timestamp);
			paras[3].Value = entity.RowVersion;
			paras[4] = new SqlParameter("@CreatedOn", SqlDbType.DateTime);
			paras[4].Value = entity.CreatedOn;
			paras[5] = new SqlParameter("@CreatedBy", SqlDbType.VarChar, 30);
			paras[5].Value = entity.CreatedBy;
			paras[6] = new SqlParameter("@ModifiedOn", SqlDbType.DateTime);
			paras[6].Value = entity.ModifiedOn;
			paras[7] = new SqlParameter("@ModifiedBy", SqlDbType.VarChar, 30);
			paras[7].Value = entity.ModifiedBy;
			return base.ExecuteNonQuery(sql, paras);
		}

		private ACIntvalHolidayMapData CreateDataByReader(SafeDataReader reader)
		{
			ACIntvalHolidayMapData data = new ACIntvalHolidayMapData {
				ACIntvalHolidayMapPK = (Guid) reader["ACIntvalHolidayMapPK"],
				ACIntervalPK = (Guid) reader["ACIntervalPK"],
				UtilHolidayPK = (Guid) reader["UtilHolidayPK"],
				RowVersion = (Byte[]) reader["RowVersion"],
				CreatedOn = (DateTime) reader["CreatedOn"],
				CreatedBy = (String) reader["CreatedBy"],
				ModifiedOn = (DateTime) reader["ModifiedOn"],
				ModifiedBy = (String) reader["ModifiedBy"],
				End = (String) reader["End"],
				Begin = (String) reader["Begin"],
				IVID = (Int16) reader["IVID"],
				BDBuildingPK = (Guid) reader["BDBuildingPK"],
				Date = (DateTime) reader["Date"],
				Holiday = (String) reader["Holiday"],
				Address1 = (String) reader["Address1"],
				BuildingID = (Int32) reader["BuildingID"]
			};
			data.AcceptChanges();
			return data;
		}

		private ACIntvalHolidayMapData FetchEntity(string where, SqlParameter[] paras)
		{
			ACIntvalHolidayMapData data = null;
			using (SafeDataReader reader = base.ExecuteDataReader(where, paras))
			{
				if (reader.Read())
				{
					data = this.CreateDataByReader(reader);
				}
				reader.Close();
			}
			return data;
		}

		private ACIntvalHolidayMapData FetchEntityEx(string sql, SqlParameter[] paras)
		{
			ACIntvalHolidayMapData data = null;
			using (SafeDataReader reader = base.ExecuteDataReaderEx(sql, paras))
			{
				if (reader.Read())
				{
					data = this.CreateDataByReader(reader);
				}
				reader.Close();
			}
			return data;
		}

		private ACIntvalHolidayMapDataCollection FetchCollection(string where, SqlParameter[] paras)
		{
			ACIntvalHolidayMapDataCollection list = new ACIntvalHolidayMapDataCollection();
			using (SafeDataReader reader = base.ExecuteDataReader(where, paras))
			{
				while(reader.Read())
				{
					ACIntvalHolidayMapData data = this.CreateDataByReader(reader);
					list.Add(data);
				}
				reader.Close();
			}
			return list;
		}

		private ACIntvalHolidayMapDataCollection FetchCollectionEx(string sql, SqlParameter[] paras)
		{
			ACIntvalHolidayMapDataCollection list = new ACIntvalHolidayMapDataCollection();
			using (SafeDataReader reader = base.ExecuteDataReaderEx(sql, paras))
			{
				while(reader.Read())
				{
					ACIntvalHolidayMapData data = this.CreateDataByReader(reader);
					list.Add(data);
				}
				reader.Close();
			}
			return list;
		}

		public ACIntvalHolidayMapData GetEntityBy(string sqlWhere, SqlParameter[] paras)
		{
			return this.FetchEntity(sqlWhere, paras);
		}

		public ACIntvalHolidayMapData GetEntityExBy(string sql, SqlParameter[] paras)
		{
			return this.FetchEntityEx(sql, paras);
		}

		public ACIntvalHolidayMapDataCollection GetCollectionBy(string sqlWhere, SqlParameter[] paras)
		{
			return this.FetchCollection(sqlWhere, paras);
		}

		public ACIntvalHolidayMapDataCollection GetCollectionExBy(string sql, SqlParameter[] paras)
		{
			return this.FetchCollectionEx(sql, paras);
		}

		public byte[] GetRowVersion( System.Guid ACIntvalHolidayMapPK)
		{
			string sql = string.Format("SELECT [RowVersion] AS [RowVersion] FROM [{0}] WHERE  [ACIntvalHolidayMapPK] = @ACIntvalHolidayMapPK ", this.TableName);
			SqlParameter[] paras = new SqlParameter[1];
			paras[0] = new SqlParameter("@ACIntvalHolidayMapPK", SqlDbType.UniqueIdentifier, 16);
			paras[0].Value = ACIntvalHolidayMapPK;
			return (byte[]) base.ExecuteScalar(sql, paras);
		}

		public ACIntvalHolidayMapData GetByPK( System.Guid ACIntvalHolidayMapPK)
		{
			string sql = " WHERE  [ACIntvalHolidayMap].[ACIntvalHolidayMapPK] = @ACIntvalHolidayMapPK ";
			SqlParameter[] paras = new SqlParameter[1];
			paras[0] = new SqlParameter("@ACIntvalHolidayMapPK", SqlDbType.UniqueIdentifier);
			paras[0].Value = ACIntvalHolidayMapPK;
			return this.FetchEntity(sql, paras);
		}

		public ACIntvalHolidayMapDataCollection GetAll()
		{
			return this.FetchCollection("", null);
		}

		public ACIntvalHolidayMapDataCollection GetByACInterval(System.Guid ACIntervalPK)
		{
			string sqlWhere = " WHERE [ACIntvalHolidayMap].[ACIntervalPK] = @ACIntervalPK";
			SqlParameter[] paras = new SqlParameter[1];
			paras[0] = new SqlParameter("@ACIntervalPK", SqlDbType.UniqueIdentifier);
			paras[0].Value = ACIntervalPK;
			return this.FetchCollection(sqlWhere, paras);
		}

		public ACIntvalHolidayMapDataCollection GetByUtilHoliday(System.Guid UtilHolidayPK)
		{
			string sqlWhere = " WHERE [ACIntvalHolidayMap].[UtilHolidayPK] = @UtilHolidayPK";
			SqlParameter[] paras = new SqlParameter[1];
			paras[0] = new SqlParameter("@UtilHolidayPK", SqlDbType.UniqueIdentifier);
			paras[0].Value = UtilHolidayPK;
			return this.FetchCollection(sqlWhere, paras);
		}

		public DataTable GetLogByPK( System.Guid ACIntvalHolidayMapPK)
		{
			string sql = string.Format("SELECT  [ACIntvalHolidayMap].[ACIntvalHolidayMapPK] AS [ACIntvalHolidayMapPK], [ACIntvalHolidayMap].[ModifiedOn] AS [ModifiedOn] FROM [{0}] WHERE  [ACIntvalHolidayMap].[ACIntvalHolidayMapPK] = @ACIntvalHolidayMapPK ", this.TableName);
			SqlParameter[] paras = new SqlParameter[1];
			paras[0] = new SqlParameter("@ACIntvalHolidayMapPK", SqlDbType.UniqueIdentifier);
			paras[0].Value = ACIntvalHolidayMapPK;
			return this.ExecuteDataTable(sql, paras);
		}

		public DataTable GetLogByACInterval(System.Guid aCIntervalPK)
		{
			string sql = string.Format("DELETE [{0}] FROM [{0}] [ACIntvalHolidayMap] INNER JOIN [ACInterval] ON [ACIntvalHolidayMap].[ACIntervalPK] = [ACInterval].[ACIntervalPK] WHERE [ACInterval].[ACIntervalPK] = @ACIntervalPK;", this.TableName);
			string oldValue = string.Format("DELETE [{0}]", this.TableName);
			string newValue = "SELECT  [ACIntvalHolidayMap].[ACIntvalHolidayMapPK] AS [ACIntvalHolidayMapPK], [ACIntvalHolidayMap].[ModifiedOn] AS [ModifiedOn]";
			sql = sql.Replace(oldValue, newValue).TrimEnd().TrimEnd(';').Replace(";", " UNION ");
			SqlParameter[] paras = new SqlParameter[1];
			paras[0] = new SqlParameter("@ACIntervalPK", SqlDbType.UniqueIdentifier);
			paras[0].Value = aCIntervalPK;
			return base.ExecuteDataTable(sql, paras);
		}

		public DataTable GetLogByBDBuilding(System.Guid bDBuildingPK)
		{
			string sql = string.Format("DELETE [{0}] FROM [{0}] [ACIntvalHolidayMap] INNER JOIN [ACInterval] ON [ACIntvalHolidayMap].[ACIntervalPK] = [ACInterval].[ACIntervalPK] INNER JOIN [BDBuilding] ON [ACInterval].[BDBuildingPK] = [BDBuilding].[BDBuildingPK] WHERE [BDBuilding].[BDBuildingPK] = @BDBuildingPK;", this.TableName);
			string oldValue = string.Format("DELETE [{0}]", this.TableName);
			string newValue = "SELECT  [ACIntvalHolidayMap].[ACIntvalHolidayMapPK] AS [ACIntvalHolidayMapPK], [ACIntvalHolidayMap].[ModifiedOn] AS [ModifiedOn]";
			sql = sql.Replace(oldValue, newValue).TrimEnd().TrimEnd(';').Replace(";", " UNION ");
			SqlParameter[] paras = new SqlParameter[1];
			paras[0] = new SqlParameter("@BDBuildingPK", SqlDbType.UniqueIdentifier);
			paras[0].Value = bDBuildingPK;
			return base.ExecuteDataTable(sql, paras);
		}

		public DataTable GetLogByUtilHoliday(System.Guid utilHolidayPK)
		{
			string sql = string.Format("DELETE [{0}] FROM [{0}] [ACIntvalHolidayMap] INNER JOIN [UtilHoliday] ON [ACIntvalHolidayMap].[UtilHolidayPK] = [UtilHoliday].[UtilHolidayPK] WHERE [UtilHoliday].[UtilHolidayPK] = @UtilHolidayPK;", this.TableName);
			string oldValue = string.Format("DELETE [{0}]", this.TableName);
			string newValue = "SELECT  [ACIntvalHolidayMap].[ACIntvalHolidayMapPK] AS [ACIntvalHolidayMapPK], [ACIntvalHolidayMap].[ModifiedOn] AS [ModifiedOn]";
			sql = sql.Replace(oldValue, newValue).TrimEnd().TrimEnd(';').Replace(";", " UNION ");
			SqlParameter[] paras = new SqlParameter[1];
			paras[0] = new SqlParameter("@UtilHolidayPK", SqlDbType.UniqueIdentifier);
			paras[0].Value = utilHolidayPK;
			return base.ExecuteDataTable(sql, paras);
		}

		public int DeleteByPK( System.Guid ACIntvalHolidayMapPK, byte[] RowVersion)
		{
			string sql = string.Format("DELETE FROM [{0}] WHERE  [ACIntvalHolidayMapPK] = @ACIntvalHolidayMapPK AND [RowVersion] = @RowVersion", this.TableName);
			SqlParameter[] paras = new SqlParameter[2];
			paras[0] = new SqlParameter("@ACIntvalHolidayMapPK", SqlDbType.UniqueIdentifier);
			paras[0].Value = ACIntvalHolidayMapPK;
			paras[1] = new SqlParameter("@RowVersion", SqlDbType.Timestamp, 8);
			paras[1].Value = RowVersion;
			return base.ExecuteNonQuery(sql, paras);
		}

		public int DeleteAll()
		{
			string sql = string.Format("DELETE FROM [{0}]", this.TableName);
			return base.ExecuteNonQuery(sql, null);
		}

		public int DeleteByACInterval(System.Guid aCIntervalPK)
		{
			string sql = string.Format("DELETE [{0}] FROM [{0}] [ACIntvalHolidayMap] INNER JOIN [ACInterval] ON [ACIntvalHolidayMap].[ACIntervalPK] = [ACInterval].[ACIntervalPK] WHERE [ACInterval].[ACIntervalPK] = @ACIntervalPK;", this.TableName);
			SqlParameter[] paras = new SqlParameter[1];
			paras[0] = new SqlParameter("@ACIntervalPK", SqlDbType.UniqueIdentifier);
			paras[0].Value = aCIntervalPK;
			return base.ExecuteNonQuery(sql, paras);
		}

		public int DeleteByBDBuilding(System.Guid bDBuildingPK)
		{
			string sql = string.Format("DELETE [{0}] FROM [{0}] [ACIntvalHolidayMap] INNER JOIN [ACInterval] ON [ACIntvalHolidayMap].[ACIntervalPK] = [ACInterval].[ACIntervalPK] INNER JOIN [BDBuilding] ON [ACInterval].[BDBuildingPK] = [BDBuilding].[BDBuildingPK] WHERE [BDBuilding].[BDBuildingPK] = @BDBuildingPK;", this.TableName);
			SqlParameter[] paras = new SqlParameter[1];
			paras[0] = new SqlParameter("@BDBuildingPK", SqlDbType.UniqueIdentifier);
			paras[0].Value = bDBuildingPK;
			return base.ExecuteNonQuery(sql, paras);
		}

		public int DeleteByUtilHoliday(System.Guid utilHolidayPK)
		{
			string sql = string.Format("DELETE [{0}] FROM [{0}] [ACIntvalHolidayMap] INNER JOIN [UtilHoliday] ON [ACIntvalHolidayMap].[UtilHolidayPK] = [UtilHoliday].[UtilHolidayPK] WHERE [UtilHoliday].[UtilHolidayPK] = @UtilHolidayPK;", this.TableName);
			SqlParameter[] paras = new SqlParameter[1];
			paras[0] = new SqlParameter("@UtilHolidayPK", SqlDbType.UniqueIdentifier);
			paras[0].Value = utilHolidayPK;
			return base.ExecuteNonQuery(sql, paras);
		}


	}
	public class ACAccessLevelDetailCRUD : DataAccessBase
	{
		private string _tableName = "ACAccessLevelDetail";

		public ACAccessLevelDetailCRUD(string connectionString) : base(connectionString)
		{
		}

		public virtual string TableName
		{
			get { return this._tableName; }
			set { this._tableName = value; }
		}

		public string SQLColumns
		{
			get
			{
				return "[ACAccessLevelDetail].[ACAccessLevelDetailPK] AS [ACAccessLevelDetailPK],[ACAccessLevelDetail].[ACAccessLevelPK] AS [ACAccessLevelPK],[ACAccessLevelDetail].[ACMainZonePK] AS [ACMainZonePK],[ACAccessLevelDetail].[ACTimecodePK] AS [ACTimecodePK],[ACAccessLevelDetail].[FromACAccessLevelPK] AS [FromACAccessLevelPK],[ACAccessLevelDetail].[RowVersion] AS [RowVersion],[ACAccessLevelDetail].[CreatedOn] AS [CreatedOn],[ACAccessLevelDetail].[CreatedBy] AS [CreatedBy],[ACAccessLevelDetail].[ModifiedOn] AS [ModifiedOn],[ACAccessLevelDetail].[ModifiedBy] AS [ModifiedBy],[ACMainZone].[Description] AS [MainZoneDescription],[ACMainZone].[MainZoneID] AS [MainZoneID],[ACMainZone].[ACPanelPK] AS [ACPanelPK],[ACTimecode].[Summary] AS [TimecodeSummary],[ACTimecode].[TCID] AS [TCID],[ACAccessLevel].[Summary] AS [ALSummary],[ACAccessLevel].[AccessLevelID] AS [AccessLevelID],[ACAccessLevel].[BDBuildingPK] AS [BDBuildingPK],[ACPanel].[UnitID] AS [UnitID],[BDBuilding].[Address1] AS [Address1],[BDBuilding].[BuildingID] AS [BuildingID]";
			}
		}

		public string SQLLeftJoins
		{
			get
			{
				return "LEFT JOIN [ACMainZone] [ACMainZone] ON [ACAccessLevelDetail].[ACMainZonePK] = [ACMainZone].[ACMainZonePK] LEFT JOIN [ACTimecode] [ACTimecode] ON [ACAccessLevelDetail].[ACTimecodePK] = [ACTimecode].[ACTimecodePK] LEFT JOIN [ACAccessLevel] [ACAccessLevel] ON [ACAccessLevelDetail].[ACAccessLevelPK] = [ACAccessLevel].[ACAccessLevelPK] LEFT JOIN [ACPanel] [ACPanel] ON [ACMainZone].[ACPanelPK] = [ACPanel].[ACPanelPK] LEFT JOIN [BDBuilding] [BDBuilding] ON [ACAccessLevel].[BDBuildingPK] = [BDBuilding].[BDBuildingPK]";
			}
		}

		protected override string SQLSelect
		{
			get
			{
				return string.Format("SELECT [ACAccessLevelDetail].[ACAccessLevelDetailPK] AS [ACAccessLevelDetailPK],[ACAccessLevelDetail].[ACAccessLevelPK] AS [ACAccessLevelPK],[ACAccessLevelDetail].[ACMainZonePK] AS [ACMainZonePK],[ACAccessLevelDetail].[ACTimecodePK] AS [ACTimecodePK],[ACAccessLevelDetail].[FromACAccessLevelPK] AS [FromACAccessLevelPK],[ACAccessLevelDetail].[RowVersion] AS [RowVersion],[ACAccessLevelDetail].[CreatedOn] AS [CreatedOn],[ACAccessLevelDetail].[CreatedBy] AS [CreatedBy],[ACAccessLevelDetail].[ModifiedOn] AS [ModifiedOn],[ACAccessLevelDetail].[ModifiedBy] AS [ModifiedBy],[ACMainZone].[Description] AS [MainZoneDescription],[ACMainZone].[MainZoneID] AS [MainZoneID],[ACMainZone].[ACPanelPK] AS [ACPanelPK],[ACTimecode].[Summary] AS [TimecodeSummary],[ACTimecode].[TCID] AS [TCID],[ACAccessLevel].[Summary] AS [ALSummary],[ACAccessLevel].[AccessLevelID] AS [AccessLevelID],[ACAccessLevel].[BDBuildingPK] AS [BDBuildingPK],[ACPanel].[UnitID] AS [UnitID],[BDBuilding].[Address1] AS [Address1],[BDBuilding].[BuildingID] AS [BuildingID] FROM [{0}] [ACAccessLevelDetail] LEFT JOIN [ACMainZone] [ACMainZone] ON [ACAccessLevelDetail].[ACMainZonePK] = [ACMainZone].[ACMainZonePK] LEFT JOIN [ACTimecode] [ACTimecode] ON [ACAccessLevelDetail].[ACTimecodePK] = [ACTimecode].[ACTimecodePK] LEFT JOIN [ACAccessLevel] [ACAccessLevel] ON [ACAccessLevelDetail].[ACAccessLevelPK] = [ACAccessLevel].[ACAccessLevelPK] LEFT JOIN [ACPanel] [ACPanel] ON [ACMainZone].[ACPanelPK] = [ACPanel].[ACPanelPK] LEFT JOIN [BDBuilding] [BDBuilding] ON [ACAccessLevel].[BDBuildingPK] = [BDBuilding].[BDBuildingPK]", this.TableName);
			}
		}

		protected override string SQLCount
		{
			get
			{
				return string.Format("SELECT COUNT(*) FROM [{0}] [ACAccessLevelDetail] LEFT JOIN [ACMainZone] [ACMainZone] ON [ACAccessLevelDetail].[ACMainZonePK] = [ACMainZone].[ACMainZonePK] LEFT JOIN [ACTimecode] [ACTimecode] ON [ACAccessLevelDetail].[ACTimecodePK] = [ACTimecode].[ACTimecodePK] LEFT JOIN [ACAccessLevel] [ACAccessLevel] ON [ACAccessLevelDetail].[ACAccessLevelPK] = [ACAccessLevel].[ACAccessLevelPK] LEFT JOIN [ACPanel] [ACPanel] ON [ACMainZone].[ACPanelPK] = [ACPanel].[ACPanelPK] LEFT JOIN [BDBuilding] [BDBuilding] ON [ACAccessLevel].[BDBuildingPK] = [BDBuilding].[BDBuildingPK]", this.TableName);
			}
		}

		public int Insert(ACAccessLevelDetailData entity)
		{
			string sql = string.Format("INSERT INTO [{0}] ([ACAccessLevelDetailPK],[ACAccessLevelPK],[ACMainZonePK],[ACTimecodePK],[FromACAccessLevelPK],[CreatedOn],[CreatedBy],[ModifiedOn],[ModifiedBy]) VALUES(@ACAccessLevelDetailPK,@ACAccessLevelPK,@ACMainZonePK,@ACTimecodePK,@FromACAccessLevelPK,@CreatedOn,@CreatedBy,@ModifiedOn,@ModifiedBy)", this.TableName);
			SqlParameter[] paras = new SqlParameter[9];
			paras[0] = new SqlParameter("@ACAccessLevelDetailPK", SqlDbType.UniqueIdentifier);
			if (entity.ACAccessLevelDetailPK == Guid.Empty)
			{
				paras[0].Value = DBNull.Value;
			}
			else
			{
				paras[0].Value = entity.ACAccessLevelDetailPK;
			}
			paras[1] = new SqlParameter("@ACAccessLevelPK", SqlDbType.UniqueIdentifier);
			if (entity.ACAccessLevelPK == Guid.Empty)
			{
				paras[1].Value = DBNull.Value;
			}
			else
			{
				paras[1].Value = entity.ACAccessLevelPK;
			}
			paras[2] = new SqlParameter("@ACMainZonePK", SqlDbType.UniqueIdentifier);
			if (entity.ACMainZonePK == Guid.Empty)
			{
				paras[2].Value = DBNull.Value;
			}
			else
			{
				paras[2].Value = entity.ACMainZonePK;
			}
			paras[3] = new SqlParameter("@ACTimecodePK", SqlDbType.UniqueIdentifier);
			if (entity.ACTimecodePK == Guid.Empty)
			{
				paras[3].Value = DBNull.Value;
			}
			else
			{
				paras[3].Value = entity.ACTimecodePK;
			}
			paras[4] = new SqlParameter("@FromACAccessLevelPK", SqlDbType.UniqueIdentifier);
			if (entity.FromACAccessLevelPK == Guid.Empty)
			{
				paras[4].Value = DBNull.Value;
			}
			else
			{
				paras[4].Value = entity.FromACAccessLevelPK;
			}
			paras[5] = new SqlParameter("@CreatedOn", SqlDbType.DateTime);
			paras[5].Value = entity.CreatedOn;
			paras[6] = new SqlParameter("@CreatedBy", SqlDbType.VarChar, 30);
			paras[6].Value = entity.CreatedBy;
			paras[7] = new SqlParameter("@ModifiedOn", SqlDbType.DateTime);
			paras[7].Value = entity.ModifiedOn;
			paras[8] = new SqlParameter("@ModifiedBy", SqlDbType.VarChar, 30);
			paras[8].Value = entity.ModifiedBy;
			return base.ExecuteNonQuery(sql, paras);
		}

		public int Update(ACAccessLevelDetailData entity)
		{
			string sql = string.Format("UPDATE [{0}] SET [ACAccessLevelPK] = @ACAccessLevelPK,[ACMainZonePK] = @ACMainZonePK,[ACTimecodePK] = @ACTimecodePK,[FromACAccessLevelPK] = @FromACAccessLevelPK,[CreatedOn] = @CreatedOn,[CreatedBy] = @CreatedBy,[ModifiedOn] = @ModifiedOn,[ModifiedBy] = @ModifiedBy  WHERE [ACAccessLevelDetailPK] = @ACAccessLevelDetailPK AND [RowVersion] = @RowVersion", this.TableName);
			SqlParameter[] paras = new SqlParameter[10];
			paras[0] = new SqlParameter("@ACAccessLevelDetailPK", SqlDbType.UniqueIdentifier);
			if (entity.ACAccessLevelDetailPK == Guid.Empty)
			{
				paras[0].Value = DBNull.Value;
			}
			else
			{
				paras[0].Value = entity.ACAccessLevelDetailPK;
			}
			paras[1] = new SqlParameter("@ACAccessLevelPK", SqlDbType.UniqueIdentifier);
			if (entity.ACAccessLevelPK == Guid.Empty)
			{
				paras[1].Value = DBNull.Value;
			}
			else
			{
				paras[1].Value = entity.ACAccessLevelPK;
			}
			paras[2] = new SqlParameter("@ACMainZonePK", SqlDbType.UniqueIdentifier);
			if (entity.ACMainZonePK == Guid.Empty)
			{
				paras[2].Value = DBNull.Value;
			}
			else
			{
				paras[2].Value = entity.ACMainZonePK;
			}
			paras[3] = new SqlParameter("@ACTimecodePK", SqlDbType.UniqueIdentifier);
			if (entity.ACTimecodePK == Guid.Empty)
			{
				paras[3].Value = DBNull.Value;
			}
			else
			{
				paras[3].Value = entity.ACTimecodePK;
			}
			paras[4] = new SqlParameter("@FromACAccessLevelPK", SqlDbType.UniqueIdentifier);
			if (entity.FromACAccessLevelPK == Guid.Empty)
			{
				paras[4].Value = DBNull.Value;
			}
			else
			{
				paras[4].Value = entity.FromACAccessLevelPK;
			}
			paras[5] = new SqlParameter("@RowVersion", SqlDbType.Timestamp);
			paras[5].Value = entity.RowVersion;
			paras[6] = new SqlParameter("@CreatedOn", SqlDbType.DateTime);
			paras[6].Value = entity.CreatedOn;
			paras[7] = new SqlParameter("@CreatedBy", SqlDbType.VarChar, 30);
			paras[7].Value = entity.CreatedBy;
			paras[8] = new SqlParameter("@ModifiedOn", SqlDbType.DateTime);
			paras[8].Value = entity.ModifiedOn;
			paras[9] = new SqlParameter("@ModifiedBy", SqlDbType.VarChar, 30);
			paras[9].Value = entity.ModifiedBy;
			return base.ExecuteNonQuery(sql, paras);
		}

		private ACAccessLevelDetailData CreateDataByReader(SafeDataReader reader)
		{
			ACAccessLevelDetailData data = new ACAccessLevelDetailData {
				ACAccessLevelDetailPK = (Guid) reader["ACAccessLevelDetailPK"],
				ACAccessLevelPK = (Guid) reader["ACAccessLevelPK"],
				ACMainZonePK = (Guid) reader["ACMainZonePK"],
				ACTimecodePK = (Guid) reader["ACTimecodePK"],
				FromACAccessLevelPK = (Guid) reader["FromACAccessLevelPK"],
				RowVersion = (Byte[]) reader["RowVersion"],
				CreatedOn = (DateTime) reader["CreatedOn"],
				CreatedBy = (String) reader["CreatedBy"],
				ModifiedOn = (DateTime) reader["ModifiedOn"],
				ModifiedBy = (String) reader["ModifiedBy"],
				MainZoneDescription = (String) reader["MainZoneDescription"],
				MainZoneID = (Byte) reader["MainZoneID"],
				ACPanelPK = (Guid) reader["ACPanelPK"],
				TimecodeSummary = (String) reader["TimecodeSummary"],
				TCID = (Int16) reader["TCID"],
				ALSummary = (String) reader["ALSummary"],
				AccessLevelID = (Int16) reader["AccessLevelID"],
				BDBuildingPK = (Guid) reader["BDBuildingPK"],
				UnitID = (Int32) reader["UnitID"],
				Address1 = (String) reader["Address1"],
				BuildingID = (Int32) reader["BuildingID"]
			};
			data.AcceptChanges();
			return data;
		}

		private ACAccessLevelDetailData FetchEntity(string where, SqlParameter[] paras)
		{
			ACAccessLevelDetailData data = null;
			using (SafeDataReader reader = base.ExecuteDataReader(where, paras))
			{
				if (reader.Read())
				{
					data = this.CreateDataByReader(reader);
				}
				reader.Close();
			}
			return data;
		}

		private ACAccessLevelDetailData FetchEntityEx(string sql, SqlParameter[] paras)
		{
			ACAccessLevelDetailData data = null;
			using (SafeDataReader reader = base.ExecuteDataReaderEx(sql, paras))
			{
				if (reader.Read())
				{
					data = this.CreateDataByReader(reader);
				}
				reader.Close();
			}
			return data;
		}

		private ACAccessLevelDetailDataCollection FetchCollection(string where, SqlParameter[] paras)
		{
			ACAccessLevelDetailDataCollection list = new ACAccessLevelDetailDataCollection();
			using (SafeDataReader reader = base.ExecuteDataReader(where, paras))
			{
				while(reader.Read())
				{
					ACAccessLevelDetailData data = this.CreateDataByReader(reader);
					list.Add(data);
				}
				reader.Close();
			}
			return list;
		}

		private ACAccessLevelDetailDataCollection FetchCollectionEx(string sql, SqlParameter[] paras)
		{
			ACAccessLevelDetailDataCollection list = new ACAccessLevelDetailDataCollection();
			using (SafeDataReader reader = base.ExecuteDataReaderEx(sql, paras))
			{
				while(reader.Read())
				{
					ACAccessLevelDetailData data = this.CreateDataByReader(reader);
					list.Add(data);
				}
				reader.Close();
			}
			return list;
		}

		public ACAccessLevelDetailData GetEntityBy(string sqlWhere, SqlParameter[] paras)
		{
			return this.FetchEntity(sqlWhere, paras);
		}

		public ACAccessLevelDetailData GetEntityExBy(string sql, SqlParameter[] paras)
		{
			return this.FetchEntityEx(sql, paras);
		}

		public ACAccessLevelDetailDataCollection GetCollectionBy(string sqlWhere, SqlParameter[] paras)
		{
			return this.FetchCollection(sqlWhere, paras);
		}

		public ACAccessLevelDetailDataCollection GetCollectionExBy(string sql, SqlParameter[] paras)
		{
			return this.FetchCollectionEx(sql, paras);
		}

		public byte[] GetRowVersion( System.Guid ACAccessLevelDetailPK)
		{
			string sql = string.Format("SELECT [RowVersion] AS [RowVersion] FROM [{0}] WHERE  [ACAccessLevelDetailPK] = @ACAccessLevelDetailPK ", this.TableName);
			SqlParameter[] paras = new SqlParameter[1];
			paras[0] = new SqlParameter("@ACAccessLevelDetailPK", SqlDbType.UniqueIdentifier, 16);
			paras[0].Value = ACAccessLevelDetailPK;
			return (byte[]) base.ExecuteScalar(sql, paras);
		}

		public ACAccessLevelDetailData GetByPK( System.Guid ACAccessLevelDetailPK)
		{
			string sql = " WHERE  [ACAccessLevelDetail].[ACAccessLevelDetailPK] = @ACAccessLevelDetailPK ";
			SqlParameter[] paras = new SqlParameter[1];
			paras[0] = new SqlParameter("@ACAccessLevelDetailPK", SqlDbType.UniqueIdentifier);
			paras[0].Value = ACAccessLevelDetailPK;
			return this.FetchEntity(sql, paras);
		}

		public ACAccessLevelDetailDataCollection GetAll()
		{
			return this.FetchCollection("", null);
		}

		public ACAccessLevelDetailDataCollection GetByACMainZone(System.Guid ACMainZonePK)
		{
			string sqlWhere = " WHERE [ACAccessLevelDetail].[ACMainZonePK] = @ACMainZonePK";
			SqlParameter[] paras = new SqlParameter[1];
			paras[0] = new SqlParameter("@ACMainZonePK", SqlDbType.UniqueIdentifier);
			paras[0].Value = ACMainZonePK;
			return this.FetchCollection(sqlWhere, paras);
		}

		public ACAccessLevelDetailDataCollection GetByACTimecode(System.Guid ACTimecodePK)
		{
			string sqlWhere = " WHERE [ACAccessLevelDetail].[ACTimecodePK] = @ACTimecodePK";
			SqlParameter[] paras = new SqlParameter[1];
			paras[0] = new SqlParameter("@ACTimecodePK", SqlDbType.UniqueIdentifier);
			paras[0].Value = ACTimecodePK;
			return this.FetchCollection(sqlWhere, paras);
		}

		public ACAccessLevelDetailDataCollection GetByACAccessLevel(System.Guid ACAccessLevelPK)
		{
			string sqlWhere = " WHERE [ACAccessLevelDetail].[ACAccessLevelPK] = @ACAccessLevelPK";
			SqlParameter[] paras = new SqlParameter[1];
			paras[0] = new SqlParameter("@ACAccessLevelPK", SqlDbType.UniqueIdentifier);
			paras[0].Value = ACAccessLevelPK;
			return this.FetchCollection(sqlWhere, paras);
		}

		public DataTable GetLogByPK( System.Guid ACAccessLevelDetailPK)
		{
			string sql = string.Format("SELECT  [ACAccessLevelDetail].[ACAccessLevelDetailPK] AS [ACAccessLevelDetailPK], [ACAccessLevelDetail].[ModifiedOn] AS [ModifiedOn] FROM [{0}] WHERE  [ACAccessLevelDetail].[ACAccessLevelDetailPK] = @ACAccessLevelDetailPK ", this.TableName);
			SqlParameter[] paras = new SqlParameter[1];
			paras[0] = new SqlParameter("@ACAccessLevelDetailPK", SqlDbType.UniqueIdentifier);
			paras[0].Value = ACAccessLevelDetailPK;
			return this.ExecuteDataTable(sql, paras);
		}

		public DataTable GetLogByACMainZone(System.Guid aCMainZonePK)
		{
			string sql = string.Format("DELETE [{0}] FROM [{0}] [ACAccessLevelDetail] INNER JOIN [ACMainZone] ON [ACAccessLevelDetail].[ACMainZonePK] = [ACMainZone].[ACMainZonePK] WHERE [ACMainZone].[ACMainZonePK] = @ACMainZonePK;", this.TableName);
			string oldValue = string.Format("DELETE [{0}]", this.TableName);
			string newValue = "SELECT  [ACAccessLevelDetail].[ACAccessLevelDetailPK] AS [ACAccessLevelDetailPK], [ACAccessLevelDetail].[ModifiedOn] AS [ModifiedOn]";
			sql = sql.Replace(oldValue, newValue).TrimEnd().TrimEnd(';').Replace(";", " UNION ");
			SqlParameter[] paras = new SqlParameter[1];
			paras[0] = new SqlParameter("@ACMainZonePK", SqlDbType.UniqueIdentifier);
			paras[0].Value = aCMainZonePK;
			return base.ExecuteDataTable(sql, paras);
		}

		public DataTable GetLogByACPanel(System.Guid aCPanelPK)
		{
			string sql = string.Format("DELETE [{0}] FROM [{0}] [ACAccessLevelDetail] INNER JOIN [ACMainZone] ON [ACAccessLevelDetail].[ACMainZonePK] = [ACMainZone].[ACMainZonePK] INNER JOIN [ACPanel] ON [ACMainZone].[ACPanelPK] = [ACPanel].[ACPanelPK] WHERE [ACPanel].[ACPanelPK] = @ACPanelPK;", this.TableName);
			string oldValue = string.Format("DELETE [{0}]", this.TableName);
			string newValue = "SELECT  [ACAccessLevelDetail].[ACAccessLevelDetailPK] AS [ACAccessLevelDetailPK], [ACAccessLevelDetail].[ModifiedOn] AS [ModifiedOn]";
			sql = sql.Replace(oldValue, newValue).TrimEnd().TrimEnd(';').Replace(";", " UNION ");
			SqlParameter[] paras = new SqlParameter[1];
			paras[0] = new SqlParameter("@ACPanelPK", SqlDbType.UniqueIdentifier);
			paras[0].Value = aCPanelPK;
			return base.ExecuteDataTable(sql, paras);
		}

		public DataTable GetLogByBDBuilding(System.Guid bDBuildingPK)
		{
			string sql = string.Format("DELETE [{0}] FROM [{0}] [ACAccessLevelDetail] INNER JOIN [ACMainZone] ON [ACAccessLevelDetail].[ACMainZonePK] = [ACMainZone].[ACMainZonePK] INNER JOIN [ACPanel] ON [ACMainZone].[ACPanelPK] = [ACPanel].[ACPanelPK] INNER JOIN [BDBuilding] ON [ACPanel].[BDBuildingPK] = [BDBuilding].[BDBuildingPK] WHERE [BDBuilding].[BDBuildingPK] = @BDBuildingPK;DELETE [{0}] FROM [{0}] [ACAccessLevelDetail] INNER JOIN [ACTimecode] ON [ACAccessLevelDetail].[ACTimecodePK] = [ACTimecode].[ACTimecodePK] INNER JOIN [BDBuilding] ON [ACTimecode].[BDBuildingPK] = [BDBuilding].[BDBuildingPK] WHERE [BDBuilding].[BDBuildingPK] = @BDBuildingPK;DELETE [{0}] FROM [{0}] [ACAccessLevelDetail] INNER JOIN [ACAccessLevel] ON [ACAccessLevelDetail].[ACAccessLevelPK] = [ACAccessLevel].[ACAccessLevelPK] INNER JOIN [BDBuilding] ON [ACAccessLevel].[BDBuildingPK] = [BDBuilding].[BDBuildingPK] WHERE [BDBuilding].[BDBuildingPK] = @BDBuildingPK;", this.TableName);
			string oldValue = string.Format("DELETE [{0}]", this.TableName);
			string newValue = "SELECT  [ACAccessLevelDetail].[ACAccessLevelDetailPK] AS [ACAccessLevelDetailPK], [ACAccessLevelDetail].[ModifiedOn] AS [ModifiedOn]";
			sql = sql.Replace(oldValue, newValue).TrimEnd().TrimEnd(';').Replace(";", " UNION ");
			SqlParameter[] paras = new SqlParameter[1];
			paras[0] = new SqlParameter("@BDBuildingPK", SqlDbType.UniqueIdentifier);
			paras[0].Value = bDBuildingPK;
			return base.ExecuteDataTable(sql, paras);
		}

		public DataTable GetLogByACTimecode(System.Guid aCTimecodePK)
		{
			string sql = string.Format("DELETE [{0}] FROM [{0}] [ACAccessLevelDetail] INNER JOIN [ACTimecode] ON [ACAccessLevelDetail].[ACTimecodePK] = [ACTimecode].[ACTimecodePK] WHERE [ACTimecode].[ACTimecodePK] = @ACTimecodePK;", this.TableName);
			string oldValue = string.Format("DELETE [{0}]", this.TableName);
			string newValue = "SELECT  [ACAccessLevelDetail].[ACAccessLevelDetailPK] AS [ACAccessLevelDetailPK], [ACAccessLevelDetail].[ModifiedOn] AS [ModifiedOn]";
			sql = sql.Replace(oldValue, newValue).TrimEnd().TrimEnd(';').Replace(";", " UNION ");
			SqlParameter[] paras = new SqlParameter[1];
			paras[0] = new SqlParameter("@ACTimecodePK", SqlDbType.UniqueIdentifier);
			paras[0].Value = aCTimecodePK;
			return base.ExecuteDataTable(sql, paras);
		}

		public DataTable GetLogByACAccessLevel(System.Guid aCAccessLevelPK)
		{
			string sql = string.Format("DELETE [{0}] FROM [{0}] [ACAccessLevelDetail] INNER JOIN [ACAccessLevel] ON [ACAccessLevelDetail].[ACAccessLevelPK] = [ACAccessLevel].[ACAccessLevelPK] WHERE [ACAccessLevel].[ACAccessLevelPK] = @ACAccessLevelPK;", this.TableName);
			string oldValue = string.Format("DELETE [{0}]", this.TableName);
			string newValue = "SELECT  [ACAccessLevelDetail].[ACAccessLevelDetailPK] AS [ACAccessLevelDetailPK], [ACAccessLevelDetail].[ModifiedOn] AS [ModifiedOn]";
			sql = sql.Replace(oldValue, newValue).TrimEnd().TrimEnd(';').Replace(";", " UNION ");
			SqlParameter[] paras = new SqlParameter[1];
			paras[0] = new SqlParameter("@ACAccessLevelPK", SqlDbType.UniqueIdentifier);
			paras[0].Value = aCAccessLevelPK;
			return base.ExecuteDataTable(sql, paras);
		}

		public int DeleteByPK( System.Guid ACAccessLevelDetailPK, byte[] RowVersion)
		{
			string sql = string.Format("DELETE FROM [{0}] WHERE  [ACAccessLevelDetailPK] = @ACAccessLevelDetailPK AND [RowVersion] = @RowVersion", this.TableName);
			SqlParameter[] paras = new SqlParameter[2];
			paras[0] = new SqlParameter("@ACAccessLevelDetailPK", SqlDbType.UniqueIdentifier);
			paras[0].Value = ACAccessLevelDetailPK;
			paras[1] = new SqlParameter("@RowVersion", SqlDbType.Timestamp, 8);
			paras[1].Value = RowVersion;
			return base.ExecuteNonQuery(sql, paras);
		}

		public int DeleteAll()
		{
			string sql = string.Format("DELETE FROM [{0}]", this.TableName);
			return base.ExecuteNonQuery(sql, null);
		}

		public int DeleteByACMainZone(System.Guid aCMainZonePK)
		{
			string sql = string.Format("DELETE [{0}] FROM [{0}] [ACAccessLevelDetail] INNER JOIN [ACMainZone] ON [ACAccessLevelDetail].[ACMainZonePK] = [ACMainZone].[ACMainZonePK] WHERE [ACMainZone].[ACMainZonePK] = @ACMainZonePK;", this.TableName);
			SqlParameter[] paras = new SqlParameter[1];
			paras[0] = new SqlParameter("@ACMainZonePK", SqlDbType.UniqueIdentifier);
			paras[0].Value = aCMainZonePK;
			return base.ExecuteNonQuery(sql, paras);
		}

		public int DeleteByACPanel(System.Guid aCPanelPK)
		{
			string sql = string.Format("DELETE [{0}] FROM [{0}] [ACAccessLevelDetail] INNER JOIN [ACMainZone] ON [ACAccessLevelDetail].[ACMainZonePK] = [ACMainZone].[ACMainZonePK] INNER JOIN [ACPanel] ON [ACMainZone].[ACPanelPK] = [ACPanel].[ACPanelPK] WHERE [ACPanel].[ACPanelPK] = @ACPanelPK;", this.TableName);
			SqlParameter[] paras = new SqlParameter[1];
			paras[0] = new SqlParameter("@ACPanelPK", SqlDbType.UniqueIdentifier);
			paras[0].Value = aCPanelPK;
			return base.ExecuteNonQuery(sql, paras);
		}

		public int DeleteByBDBuilding(System.Guid bDBuildingPK)
		{
			string sql = string.Format("DELETE [{0}] FROM [{0}] [ACAccessLevelDetail] INNER JOIN [ACMainZone] ON [ACAccessLevelDetail].[ACMainZonePK] = [ACMainZone].[ACMainZonePK] INNER JOIN [ACPanel] ON [ACMainZone].[ACPanelPK] = [ACPanel].[ACPanelPK] INNER JOIN [BDBuilding] ON [ACPanel].[BDBuildingPK] = [BDBuilding].[BDBuildingPK] WHERE [BDBuilding].[BDBuildingPK] = @BDBuildingPK;DELETE [{0}] FROM [{0}] [ACAccessLevelDetail] INNER JOIN [ACTimecode] ON [ACAccessLevelDetail].[ACTimecodePK] = [ACTimecode].[ACTimecodePK] INNER JOIN [BDBuilding] ON [ACTimecode].[BDBuildingPK] = [BDBuilding].[BDBuildingPK] WHERE [BDBuilding].[BDBuildingPK] = @BDBuildingPK;DELETE [{0}] FROM [{0}] [ACAccessLevelDetail] INNER JOIN [ACAccessLevel] ON [ACAccessLevelDetail].[ACAccessLevelPK] = [ACAccessLevel].[ACAccessLevelPK] INNER JOIN [BDBuilding] ON [ACAccessLevel].[BDBuildingPK] = [BDBuilding].[BDBuildingPK] WHERE [BDBuilding].[BDBuildingPK] = @BDBuildingPK;", this.TableName);
			SqlParameter[] paras = new SqlParameter[1];
			paras[0] = new SqlParameter("@BDBuildingPK", SqlDbType.UniqueIdentifier);
			paras[0].Value = bDBuildingPK;
			return base.ExecuteNonQuery(sql, paras);
		}

		public int DeleteByACTimecode(System.Guid aCTimecodePK)
		{
			string sql = string.Format("DELETE [{0}] FROM [{0}] [ACAccessLevelDetail] INNER JOIN [ACTimecode] ON [ACAccessLevelDetail].[ACTimecodePK] = [ACTimecode].[ACTimecodePK] WHERE [ACTimecode].[ACTimecodePK] = @ACTimecodePK;", this.TableName);
			SqlParameter[] paras = new SqlParameter[1];
			paras[0] = new SqlParameter("@ACTimecodePK", SqlDbType.UniqueIdentifier);
			paras[0].Value = aCTimecodePK;
			return base.ExecuteNonQuery(sql, paras);
		}

		public int DeleteByACAccessLevel(System.Guid aCAccessLevelPK)
		{
			string sql = string.Format("DELETE [{0}] FROM [{0}] [ACAccessLevelDetail] INNER JOIN [ACAccessLevel] ON [ACAccessLevelDetail].[ACAccessLevelPK] = [ACAccessLevel].[ACAccessLevelPK] WHERE [ACAccessLevel].[ACAccessLevelPK] = @ACAccessLevelPK;", this.TableName);
			SqlParameter[] paras = new SqlParameter[1];
			paras[0] = new SqlParameter("@ACAccessLevelPK", SqlDbType.UniqueIdentifier);
			paras[0].Value = aCAccessLevelPK;
			return base.ExecuteNonQuery(sql, paras);
		}


	}
	public class UsrAccountBuildingMapCRUD : DataAccessBase
	{
		private string _tableName = "UsrAccountBuildingMap";

		public UsrAccountBuildingMapCRUD(string connectionString) : base(connectionString)
		{
		}

		public virtual string TableName
		{
			get { return this._tableName; }
			set { this._tableName = value; }
		}

		public string SQLColumns
		{
			get
			{
				return "[UsrAccountBuildingMap].[UsrAccountBuildingMapPK] AS [UsrAccountBuildingMapPK],[UsrAccountBuildingMap].[UsrAccountPK] AS [UsrAccountPK],[UsrAccountBuildingMap].[BDBuildingPK] AS [BDBuildingPK],[UsrAccountBuildingMap].[BuildingWide] AS [BuildingWide],[UsrAccountBuildingMap].[RowVersion] AS [RowVersion],[UsrAccountBuildingMap].[CreatedOn] AS [CreatedOn],[UsrAccountBuildingMap].[CreatedBy] AS [CreatedBy],[UsrAccountBuildingMap].[ModifiedOn] AS [ModifiedOn],[UsrAccountBuildingMap].[ModifiedBy] AS [ModifiedBy],[UsrAccountBuildingMap].[AccessTC] AS [AccessTC],[UsrAccountBuildingMap].[Permission] AS [Permission],[UsrAccountBuildingMap].[Primary] AS [Primary],[BDBuilding].[Address1] AS [Address1],[BDBuilding].[BuildingID] AS [BuildingID],[UsrAccount].[UserID] AS [UserID]";
			}
		}

		public string SQLLeftJoins
		{
			get
			{
				return "LEFT JOIN [BDBuilding] [BDBuilding] ON [UsrAccountBuildingMap].[BDBuildingPK] = [BDBuilding].[BDBuildingPK] LEFT JOIN [UsrAccount] [UsrAccount] ON [UsrAccountBuildingMap].[UsrAccountPK] = [UsrAccount].[UsrAccountPK]";
			}
		}

		protected override string SQLSelect
		{
			get
			{
				return string.Format("SELECT [UsrAccountBuildingMap].[UsrAccountBuildingMapPK] AS [UsrAccountBuildingMapPK],[UsrAccountBuildingMap].[UsrAccountPK] AS [UsrAccountPK],[UsrAccountBuildingMap].[BDBuildingPK] AS [BDBuildingPK],[UsrAccountBuildingMap].[BuildingWide] AS [BuildingWide],[UsrAccountBuildingMap].[RowVersion] AS [RowVersion],[UsrAccountBuildingMap].[CreatedOn] AS [CreatedOn],[UsrAccountBuildingMap].[CreatedBy] AS [CreatedBy],[UsrAccountBuildingMap].[ModifiedOn] AS [ModifiedOn],[UsrAccountBuildingMap].[ModifiedBy] AS [ModifiedBy],[UsrAccountBuildingMap].[AccessTC] AS [AccessTC],[UsrAccountBuildingMap].[Permission] AS [Permission],[UsrAccountBuildingMap].[Primary] AS [Primary],[BDBuilding].[Address1] AS [Address1],[BDBuilding].[BuildingID] AS [BuildingID],[UsrAccount].[UserID] AS [UserID] FROM [{0}] [UsrAccountBuildingMap] LEFT JOIN [BDBuilding] [BDBuilding] ON [UsrAccountBuildingMap].[BDBuildingPK] = [BDBuilding].[BDBuildingPK] LEFT JOIN [UsrAccount] [UsrAccount] ON [UsrAccountBuildingMap].[UsrAccountPK] = [UsrAccount].[UsrAccountPK]", this.TableName);
			}
		}

		protected override string SQLCount
		{
			get
			{
				return string.Format("SELECT COUNT(*) FROM [{0}] [UsrAccountBuildingMap] LEFT JOIN [BDBuilding] [BDBuilding] ON [UsrAccountBuildingMap].[BDBuildingPK] = [BDBuilding].[BDBuildingPK] LEFT JOIN [UsrAccount] [UsrAccount] ON [UsrAccountBuildingMap].[UsrAccountPK] = [UsrAccount].[UsrAccountPK]", this.TableName);
			}
		}

		public int Insert(UsrAccountBuildingMapData entity)
		{
			string sql = string.Format("INSERT INTO [{0}] ([UsrAccountBuildingMapPK],[UsrAccountPK],[BDBuildingPK],[BuildingWide],[CreatedOn],[CreatedBy],[ModifiedOn],[ModifiedBy],[AccessTC],[Permission],[Primary]) VALUES(@UsrAccountBuildingMapPK,@UsrAccountPK,@BDBuildingPK,@BuildingWide,@CreatedOn,@CreatedBy,@ModifiedOn,@ModifiedBy,@AccessTC,@Permission,@Primary)", this.TableName);
			SqlParameter[] paras = new SqlParameter[11];
			paras[0] = new SqlParameter("@UsrAccountBuildingMapPK", SqlDbType.UniqueIdentifier);
			if (entity.UsrAccountBuildingMapPK == Guid.Empty)
			{
				paras[0].Value = DBNull.Value;
			}
			else
			{
				paras[0].Value = entity.UsrAccountBuildingMapPK;
			}
			paras[1] = new SqlParameter("@UsrAccountPK", SqlDbType.UniqueIdentifier);
			if (entity.UsrAccountPK == Guid.Empty)
			{
				paras[1].Value = DBNull.Value;
			}
			else
			{
				paras[1].Value = entity.UsrAccountPK;
			}
			paras[2] = new SqlParameter("@BDBuildingPK", SqlDbType.UniqueIdentifier);
			if (entity.BDBuildingPK == Guid.Empty)
			{
				paras[2].Value = DBNull.Value;
			}
			else
			{
				paras[2].Value = entity.BDBuildingPK;
			}
			paras[3] = new SqlParameter("@BuildingWide", SqlDbType.Bit);
			paras[3].Value = entity.BuildingWide;
			paras[4] = new SqlParameter("@CreatedOn", SqlDbType.DateTime);
			paras[4].Value = entity.CreatedOn;
			paras[5] = new SqlParameter("@CreatedBy", SqlDbType.VarChar, 30);
			paras[5].Value = entity.CreatedBy;
			paras[6] = new SqlParameter("@ModifiedOn", SqlDbType.DateTime);
			paras[6].Value = entity.ModifiedOn;
			paras[7] = new SqlParameter("@ModifiedBy", SqlDbType.VarChar, 30);
			paras[7].Value = entity.ModifiedBy;
			paras[8] = new SqlParameter("@AccessTC", SqlDbType.SmallInt);
			paras[8].Value = entity.AccessTC;
			paras[9] = new SqlParameter("@Permission", SqlDbType.Int);
			paras[9].Value = entity.Permission;
			paras[10] = new SqlParameter("@Primary", SqlDbType.Bit);
			paras[10].Value = entity.Primary;
			return base.ExecuteNonQuery(sql, paras);
		}

		public int Update(UsrAccountBuildingMapData entity)
		{
			string sql = string.Format("UPDATE [{0}] SET [UsrAccountPK] = @UsrAccountPK,[BDBuildingPK] = @BDBuildingPK,[BuildingWide] = @BuildingWide,[CreatedOn] = @CreatedOn,[CreatedBy] = @CreatedBy,[ModifiedOn] = @ModifiedOn,[ModifiedBy] = @ModifiedBy,[AccessTC] = @AccessTC,[Permission] = @Permission,[Primary] = @Primary  WHERE [UsrAccountBuildingMapPK] = @UsrAccountBuildingMapPK AND [RowVersion] = @RowVersion", this.TableName);
			SqlParameter[] paras = new SqlParameter[12];
			paras[0] = new SqlParameter("@UsrAccountBuildingMapPK", SqlDbType.UniqueIdentifier);
			if (entity.UsrAccountBuildingMapPK == Guid.Empty)
			{
				paras[0].Value = DBNull.Value;
			}
			else
			{
				paras[0].Value = entity.UsrAccountBuildingMapPK;
			}
			paras[1] = new SqlParameter("@UsrAccountPK", SqlDbType.UniqueIdentifier);
			if (entity.UsrAccountPK == Guid.Empty)
			{
				paras[1].Value = DBNull.Value;
			}
			else
			{
				paras[1].Value = entity.UsrAccountPK;
			}
			paras[2] = new SqlParameter("@BDBuildingPK", SqlDbType.UniqueIdentifier);
			if (entity.BDBuildingPK == Guid.Empty)
			{
				paras[2].Value = DBNull.Value;
			}
			else
			{
				paras[2].Value = entity.BDBuildingPK;
			}
			paras[3] = new SqlParameter("@BuildingWide", SqlDbType.Bit);
			paras[3].Value = entity.BuildingWide;
			paras[4] = new SqlParameter("@RowVersion", SqlDbType.Timestamp);
			paras[4].Value = entity.RowVersion;
			paras[5] = new SqlParameter("@CreatedOn", SqlDbType.DateTime);
			paras[5].Value = entity.CreatedOn;
			paras[6] = new SqlParameter("@CreatedBy", SqlDbType.VarChar, 30);
			paras[6].Value = entity.CreatedBy;
			paras[7] = new SqlParameter("@ModifiedOn", SqlDbType.DateTime);
			paras[7].Value = entity.ModifiedOn;
			paras[8] = new SqlParameter("@ModifiedBy", SqlDbType.VarChar, 30);
			paras[8].Value = entity.ModifiedBy;
			paras[9] = new SqlParameter("@AccessTC", SqlDbType.SmallInt);
			paras[9].Value = entity.AccessTC;
			paras[10] = new SqlParameter("@Permission", SqlDbType.Int);
			paras[10].Value = entity.Permission;
			paras[11] = new SqlParameter("@Primary", SqlDbType.Bit);
			paras[11].Value = entity.Primary;
			return base.ExecuteNonQuery(sql, paras);
		}

		private UsrAccountBuildingMapData CreateDataByReader(SafeDataReader reader)
		{
			UsrAccountBuildingMapData data = new UsrAccountBuildingMapData {
				UsrAccountBuildingMapPK = (Guid) reader["UsrAccountBuildingMapPK"],
				UsrAccountPK = (Guid) reader["UsrAccountPK"],
				BDBuildingPK = (Guid) reader["BDBuildingPK"],
				BuildingWide = (Boolean) reader["BuildingWide"],
				RowVersion = (Byte[]) reader["RowVersion"],
				CreatedOn = (DateTime) reader["CreatedOn"],
				CreatedBy = (String) reader["CreatedBy"],
				ModifiedOn = (DateTime) reader["ModifiedOn"],
				ModifiedBy = (String) reader["ModifiedBy"],
				AccessTC = (Int16) reader["AccessTC"],
				Permission = (Int32) reader["Permission"],
				Primary = (Boolean) reader["Primary"],
				Address1 = (String) reader["Address1"],
				BuildingID = (Int32) reader["BuildingID"],
				UserID = (String) reader["UserID"]
			};
			data.AcceptChanges();
			return data;
		}

		private UsrAccountBuildingMapData FetchEntity(string where, SqlParameter[] paras)
		{
			UsrAccountBuildingMapData data = null;
			using (SafeDataReader reader = base.ExecuteDataReader(where, paras))
			{
				if (reader.Read())
				{
					data = this.CreateDataByReader(reader);
				}
				reader.Close();
			}
			return data;
		}

		private UsrAccountBuildingMapData FetchEntityEx(string sql, SqlParameter[] paras)
		{
			UsrAccountBuildingMapData data = null;
			using (SafeDataReader reader = base.ExecuteDataReaderEx(sql, paras))
			{
				if (reader.Read())
				{
					data = this.CreateDataByReader(reader);
				}
				reader.Close();
			}
			return data;
		}

		private UsrAccountBuildingMapDataCollection FetchCollection(string where, SqlParameter[] paras)
		{
			UsrAccountBuildingMapDataCollection list = new UsrAccountBuildingMapDataCollection();
			using (SafeDataReader reader = base.ExecuteDataReader(where, paras))
			{
				while(reader.Read())
				{
					UsrAccountBuildingMapData data = this.CreateDataByReader(reader);
					list.Add(data);
				}
				reader.Close();
			}
			return list;
		}

		private UsrAccountBuildingMapDataCollection FetchCollectionEx(string sql, SqlParameter[] paras)
		{
			UsrAccountBuildingMapDataCollection list = new UsrAccountBuildingMapDataCollection();
			using (SafeDataReader reader = base.ExecuteDataReaderEx(sql, paras))
			{
				while(reader.Read())
				{
					UsrAccountBuildingMapData data = this.CreateDataByReader(reader);
					list.Add(data);
				}
				reader.Close();
			}
			return list;
		}

		public UsrAccountBuildingMapData GetEntityBy(string sqlWhere, SqlParameter[] paras)
		{
			return this.FetchEntity(sqlWhere, paras);
		}

		public UsrAccountBuildingMapData GetEntityExBy(string sql, SqlParameter[] paras)
		{
			return this.FetchEntityEx(sql, paras);
		}

		public UsrAccountBuildingMapDataCollection GetCollectionBy(string sqlWhere, SqlParameter[] paras)
		{
			return this.FetchCollection(sqlWhere, paras);
		}

		public UsrAccountBuildingMapDataCollection GetCollectionExBy(string sql, SqlParameter[] paras)
		{
			return this.FetchCollectionEx(sql, paras);
		}

		public byte[] GetRowVersion( System.Guid UsrAccountBuildingMapPK)
		{
			string sql = string.Format("SELECT [RowVersion] AS [RowVersion] FROM [{0}] WHERE  [UsrAccountBuildingMapPK] = @UsrAccountBuildingMapPK ", this.TableName);
			SqlParameter[] paras = new SqlParameter[1];
			paras[0] = new SqlParameter("@UsrAccountBuildingMapPK", SqlDbType.UniqueIdentifier, 16);
			paras[0].Value = UsrAccountBuildingMapPK;
			return (byte[]) base.ExecuteScalar(sql, paras);
		}

		public UsrAccountBuildingMapData GetByPK( System.Guid UsrAccountBuildingMapPK)
		{
			string sql = " WHERE  [UsrAccountBuildingMap].[UsrAccountBuildingMapPK] = @UsrAccountBuildingMapPK ";
			SqlParameter[] paras = new SqlParameter[1];
			paras[0] = new SqlParameter("@UsrAccountBuildingMapPK", SqlDbType.UniqueIdentifier);
			paras[0].Value = UsrAccountBuildingMapPK;
			return this.FetchEntity(sql, paras);
		}

		public UsrAccountBuildingMapDataCollection GetAll()
		{
			return this.FetchCollection("", null);
		}

		public UsrAccountBuildingMapDataCollection GetByBDBuilding(System.Guid BDBuildingPK)
		{
			string sqlWhere = " WHERE [UsrAccountBuildingMap].[BDBuildingPK] = @BDBuildingPK";
			SqlParameter[] paras = new SqlParameter[1];
			paras[0] = new SqlParameter("@BDBuildingPK", SqlDbType.UniqueIdentifier);
			paras[0].Value = BDBuildingPK;
			return this.FetchCollection(sqlWhere, paras);
		}

		public UsrAccountBuildingMapDataCollection GetByUsrAccount(System.Guid UsrAccountPK)
		{
			string sqlWhere = " WHERE [UsrAccountBuildingMap].[UsrAccountPK] = @UsrAccountPK";
			SqlParameter[] paras = new SqlParameter[1];
			paras[0] = new SqlParameter("@UsrAccountPK", SqlDbType.UniqueIdentifier);
			paras[0].Value = UsrAccountPK;
			return this.FetchCollection(sqlWhere, paras);
		}

		public DataTable GetLogByPK( System.Guid UsrAccountBuildingMapPK)
		{
			string sql = string.Format("SELECT  [UsrAccountBuildingMap].[UsrAccountBuildingMapPK] AS [UsrAccountBuildingMapPK], [UsrAccountBuildingMap].[ModifiedOn] AS [ModifiedOn] FROM [{0}] WHERE  [UsrAccountBuildingMap].[UsrAccountBuildingMapPK] = @UsrAccountBuildingMapPK ", this.TableName);
			SqlParameter[] paras = new SqlParameter[1];
			paras[0] = new SqlParameter("@UsrAccountBuildingMapPK", SqlDbType.UniqueIdentifier);
			paras[0].Value = UsrAccountBuildingMapPK;
			return this.ExecuteDataTable(sql, paras);
		}

		public DataTable GetLogByBDBuilding(System.Guid bDBuildingPK)
		{
			string sql = string.Format("DELETE [{0}] FROM [{0}] [UsrAccountBuildingMap] INNER JOIN [BDBuilding] ON [UsrAccountBuildingMap].[BDBuildingPK] = [BDBuilding].[BDBuildingPK] WHERE [BDBuilding].[BDBuildingPK] = @BDBuildingPK;DELETE [{0}] FROM [{0}] [UsrAccountBuildingMap] INNER JOIN [UsrAccount] ON [UsrAccountBuildingMap].[UsrAccountPK] = [UsrAccount].[UsrAccountPK] INNER JOIN [BDTenant] ON [UsrAccount].[BDTenantPK] = [BDTenant].[BDTenantPK] INNER JOIN [BDBuilding] ON [BDTenant].[BDBuildingPK] = [BDBuilding].[BDBuildingPK] WHERE [BDBuilding].[BDBuildingPK] = @BDBuildingPK;", this.TableName);
			string oldValue = string.Format("DELETE [{0}]", this.TableName);
			string newValue = "SELECT  [UsrAccountBuildingMap].[UsrAccountBuildingMapPK] AS [UsrAccountBuildingMapPK], [UsrAccountBuildingMap].[ModifiedOn] AS [ModifiedOn]";
			sql = sql.Replace(oldValue, newValue).TrimEnd().TrimEnd(';').Replace(";", " UNION ");
			SqlParameter[] paras = new SqlParameter[1];
			paras[0] = new SqlParameter("@BDBuildingPK", SqlDbType.UniqueIdentifier);
			paras[0].Value = bDBuildingPK;
			return base.ExecuteDataTable(sql, paras);
		}

		public DataTable GetLogByUsrAccount(System.Guid usrAccountPK)
		{
			string sql = string.Format("DELETE [{0}] FROM [{0}] [UsrAccountBuildingMap] INNER JOIN [UsrAccount] ON [UsrAccountBuildingMap].[UsrAccountPK] = [UsrAccount].[UsrAccountPK] WHERE [UsrAccount].[UsrAccountPK] = @UsrAccountPK;", this.TableName);
			string oldValue = string.Format("DELETE [{0}]", this.TableName);
			string newValue = "SELECT  [UsrAccountBuildingMap].[UsrAccountBuildingMapPK] AS [UsrAccountBuildingMapPK], [UsrAccountBuildingMap].[ModifiedOn] AS [ModifiedOn]";
			sql = sql.Replace(oldValue, newValue).TrimEnd().TrimEnd(';').Replace(";", " UNION ");
			SqlParameter[] paras = new SqlParameter[1];
			paras[0] = new SqlParameter("@UsrAccountPK", SqlDbType.UniqueIdentifier);
			paras[0].Value = usrAccountPK;
			return base.ExecuteDataTable(sql, paras);
		}

		public DataTable GetLogByBDTenant(System.Guid bDTenantPK)
		{
			string sql = string.Format("DELETE [{0}] FROM [{0}] [UsrAccountBuildingMap] INNER JOIN [UsrAccount] ON [UsrAccountBuildingMap].[UsrAccountPK] = [UsrAccount].[UsrAccountPK] INNER JOIN [BDTenant] ON [UsrAccount].[BDTenantPK] = [BDTenant].[BDTenantPK] WHERE [BDTenant].[BDTenantPK] = @BDTenantPK;", this.TableName);
			string oldValue = string.Format("DELETE [{0}]", this.TableName);
			string newValue = "SELECT  [UsrAccountBuildingMap].[UsrAccountBuildingMapPK] AS [UsrAccountBuildingMapPK], [UsrAccountBuildingMap].[ModifiedOn] AS [ModifiedOn]";
			sql = sql.Replace(oldValue, newValue).TrimEnd().TrimEnd(';').Replace(";", " UNION ");
			SqlParameter[] paras = new SqlParameter[1];
			paras[0] = new SqlParameter("@BDTenantPK", SqlDbType.UniqueIdentifier);
			paras[0].Value = bDTenantPK;
			return base.ExecuteDataTable(sql, paras);
		}

		public DataTable GetLogByUsrGroup(System.Guid usrGroupPK)
		{
			string sql = string.Format("DELETE [{0}] FROM [{0}] [UsrAccountBuildingMap] INNER JOIN [UsrAccount] ON [UsrAccountBuildingMap].[UsrAccountPK] = [UsrAccount].[UsrAccountPK] INNER JOIN [UsrGroup] ON [UsrAccount].[UsrGroupPK] = [UsrGroup].[UsrGroupPK] WHERE [UsrGroup].[UsrGroupPK] = @UsrGroupPK;", this.TableName);
			string oldValue = string.Format("DELETE [{0}]", this.TableName);
			string newValue = "SELECT  [UsrAccountBuildingMap].[UsrAccountBuildingMapPK] AS [UsrAccountBuildingMapPK], [UsrAccountBuildingMap].[ModifiedOn] AS [ModifiedOn]";
			sql = sql.Replace(oldValue, newValue).TrimEnd().TrimEnd(';').Replace(";", " UNION ");
			SqlParameter[] paras = new SqlParameter[1];
			paras[0] = new SqlParameter("@UsrGroupPK", SqlDbType.UniqueIdentifier);
			paras[0].Value = usrGroupPK;
			return base.ExecuteDataTable(sql, paras);
		}

		public int DeleteByPK( System.Guid UsrAccountBuildingMapPK, byte[] RowVersion)
		{
			string sql = string.Format("DELETE FROM [{0}] WHERE  [UsrAccountBuildingMapPK] = @UsrAccountBuildingMapPK AND [RowVersion] = @RowVersion", this.TableName);
			SqlParameter[] paras = new SqlParameter[2];
			paras[0] = new SqlParameter("@UsrAccountBuildingMapPK", SqlDbType.UniqueIdentifier);
			paras[0].Value = UsrAccountBuildingMapPK;
			paras[1] = new SqlParameter("@RowVersion", SqlDbType.Timestamp, 8);
			paras[1].Value = RowVersion;
			return base.ExecuteNonQuery(sql, paras);
		}

		public int DeleteAll()
		{
			string sql = string.Format("DELETE FROM [{0}]", this.TableName);
			return base.ExecuteNonQuery(sql, null);
		}

		public int DeleteByBDBuilding(System.Guid bDBuildingPK)
		{
			string sql = string.Format("DELETE [{0}] FROM [{0}] [UsrAccountBuildingMap] INNER JOIN [BDBuilding] ON [UsrAccountBuildingMap].[BDBuildingPK] = [BDBuilding].[BDBuildingPK] WHERE [BDBuilding].[BDBuildingPK] = @BDBuildingPK;DELETE [{0}] FROM [{0}] [UsrAccountBuildingMap] INNER JOIN [UsrAccount] ON [UsrAccountBuildingMap].[UsrAccountPK] = [UsrAccount].[UsrAccountPK] INNER JOIN [BDTenant] ON [UsrAccount].[BDTenantPK] = [BDTenant].[BDTenantPK] INNER JOIN [BDBuilding] ON [BDTenant].[BDBuildingPK] = [BDBuilding].[BDBuildingPK] WHERE [BDBuilding].[BDBuildingPK] = @BDBuildingPK;", this.TableName);
			SqlParameter[] paras = new SqlParameter[1];
			paras[0] = new SqlParameter("@BDBuildingPK", SqlDbType.UniqueIdentifier);
			paras[0].Value = bDBuildingPK;
			return base.ExecuteNonQuery(sql, paras);
		}

		public int DeleteByUsrAccount(System.Guid usrAccountPK)
		{
			string sql = string.Format("DELETE [{0}] FROM [{0}] [UsrAccountBuildingMap] INNER JOIN [UsrAccount] ON [UsrAccountBuildingMap].[UsrAccountPK] = [UsrAccount].[UsrAccountPK] WHERE [UsrAccount].[UsrAccountPK] = @UsrAccountPK;", this.TableName);
			SqlParameter[] paras = new SqlParameter[1];
			paras[0] = new SqlParameter("@UsrAccountPK", SqlDbType.UniqueIdentifier);
			paras[0].Value = usrAccountPK;
			return base.ExecuteNonQuery(sql, paras);
		}

		public int DeleteByBDTenant(System.Guid bDTenantPK)
		{
			string sql = string.Format("DELETE [{0}] FROM [{0}] [UsrAccountBuildingMap] INNER JOIN [UsrAccount] ON [UsrAccountBuildingMap].[UsrAccountPK] = [UsrAccount].[UsrAccountPK] INNER JOIN [BDTenant] ON [UsrAccount].[BDTenantPK] = [BDTenant].[BDTenantPK] WHERE [BDTenant].[BDTenantPK] = @BDTenantPK;", this.TableName);
			SqlParameter[] paras = new SqlParameter[1];
			paras[0] = new SqlParameter("@BDTenantPK", SqlDbType.UniqueIdentifier);
			paras[0].Value = bDTenantPK;
			return base.ExecuteNonQuery(sql, paras);
		}

		public int DeleteByUsrGroup(System.Guid usrGroupPK)
		{
			string sql = string.Format("DELETE [{0}] FROM [{0}] [UsrAccountBuildingMap] INNER JOIN [UsrAccount] ON [UsrAccountBuildingMap].[UsrAccountPK] = [UsrAccount].[UsrAccountPK] INNER JOIN [UsrGroup] ON [UsrAccount].[UsrGroupPK] = [UsrGroup].[UsrGroupPK] WHERE [UsrGroup].[UsrGroupPK] = @UsrGroupPK;", this.TableName);
			SqlParameter[] paras = new SqlParameter[1];
			paras[0] = new SqlParameter("@UsrGroupPK", SqlDbType.UniqueIdentifier);
			paras[0].Value = usrGroupPK;
			return base.ExecuteNonQuery(sql, paras);
		}


	}
	public class BDBuildingCRUD : DataAccessBase
	{
		private string _tableName = "BDBuilding";

		public BDBuildingCRUD(string connectionString) : base(connectionString)
		{
		}

		public virtual string TableName
		{
			get { return this._tableName; }
			set { this._tableName = value; }
		}

		public string SQLColumns
		{
			get
			{
				return "[BDBuilding].[BDBuildingPK] AS [BDBuildingPK],[BDBuilding].[BuildingID] AS [BuildingID],[BDBuilding].[BuildingName] AS [BuildingName],[BDBuilding].[Address1] AS [Address1],[BDBuilding].[StreetNumb] AS [StreetNumb],[BDBuilding].[StreetName] AS [StreetName],[BDBuilding].[Address2] AS [Address2],[BDBuilding].[City] AS [City],[BDBuilding].[State] AS [State],[BDBuilding].[Zipcode] AS [Zipcode],[BDBuilding].[County] AS [County],[BDBuilding].[TimezoneID] AS [TimezoneID],[BDBuilding].[Federal] AS [Federal],[BDBuilding].[Phone] AS [Phone],[BDBuilding].[Fax] AS [Fax],[BDBuilding].[BldgNotes] AS [BldgNotes],[BDBuilding].[CardNotes] AS [CardNotes],[BDBuilding].[ElevTrapNotes] AS [ElevTrapNotes],[BDBuilding].[VisitorNotes] AS [VisitorNotes],[BDBuilding].[SystemTypeID] AS [SystemTypeID],[BDBuilding].[CountryID] AS [CountryID],[BDBuilding].[RowVersion] AS [RowVersion],[BDBuilding].[CreatedOn] AS [CreatedOn],[BDBuilding].[CreatedBy] AS [CreatedBy],[BDBuilding].[ModifiedOn] AS [ModifiedOn],[BDBuilding].[ModifiedBy] AS [ModifiedBy],[BDBuilding].[VisitorSiteCode] AS [VisitorSiteCode],[BDBuilding].[WinUITypeID] AS [WinUITypeID],[BDBuilding].[LastExportParkingTag] AS [LastExportParkingTag],[BDBuilding].[AutoIssueNotifyEmail] AS [AutoIssueNotifyEmail],[BDBuilding].[CardKeyMode] AS [CardKeyMode],[BDBuilding].[AccessLevelMode] AS [AccessLevelMode],[BDBuilding].[HotClient] AS [HotClient],[BDBuilding].[HotExpire] AS [HotExpire]";
			}
		}

		public string SQLLeftJoins
		{
			get
			{
				return "";
			}
		}

		protected override string SQLSelect
		{
			get
			{
				return string.Format("SELECT [BDBuilding].[BDBuildingPK] AS [BDBuildingPK],[BDBuilding].[BuildingID] AS [BuildingID],[BDBuilding].[BuildingName] AS [BuildingName],[BDBuilding].[Address1] AS [Address1],[BDBuilding].[StreetNumb] AS [StreetNumb],[BDBuilding].[StreetName] AS [StreetName],[BDBuilding].[Address2] AS [Address2],[BDBuilding].[City] AS [City],[BDBuilding].[State] AS [State],[BDBuilding].[Zipcode] AS [Zipcode],[BDBuilding].[County] AS [County],[BDBuilding].[TimezoneID] AS [TimezoneID],[BDBuilding].[Federal] AS [Federal],[BDBuilding].[Phone] AS [Phone],[BDBuilding].[Fax] AS [Fax],[BDBuilding].[BldgNotes] AS [BldgNotes],[BDBuilding].[CardNotes] AS [CardNotes],[BDBuilding].[ElevTrapNotes] AS [ElevTrapNotes],[BDBuilding].[VisitorNotes] AS [VisitorNotes],[BDBuilding].[SystemTypeID] AS [SystemTypeID],[BDBuilding].[CountryID] AS [CountryID],[BDBuilding].[RowVersion] AS [RowVersion],[BDBuilding].[CreatedOn] AS [CreatedOn],[BDBuilding].[CreatedBy] AS [CreatedBy],[BDBuilding].[ModifiedOn] AS [ModifiedOn],[BDBuilding].[ModifiedBy] AS [ModifiedBy],[BDBuilding].[VisitorSiteCode] AS [VisitorSiteCode],[BDBuilding].[WinUITypeID] AS [WinUITypeID],[BDBuilding].[LastExportParkingTag] AS [LastExportParkingTag],[BDBuilding].[AutoIssueNotifyEmail] AS [AutoIssueNotifyEmail],[BDBuilding].[CardKeyMode] AS [CardKeyMode],[BDBuilding].[AccessLevelMode] AS [AccessLevelMode],[BDBuilding].[HotClient] AS [HotClient],[BDBuilding].[HotExpire] AS [HotExpire] FROM [{0}] [BDBuilding] ", this.TableName);
			}
		}

		protected override string SQLCount
		{
			get
			{
				return string.Format("SELECT COUNT(*) FROM [{0}] [BDBuilding] ", this.TableName);
			}
		}

		public int Insert(BDBuildingData entity)
		{
			string sql = string.Format("INSERT INTO [{0}] ([BDBuildingPK],[BuildingID],[BuildingName],[Address1],[StreetNumb],[StreetName],[Address2],[City],[State],[Zipcode],[County],[TimezoneID],[Federal],[Phone],[Fax],[BldgNotes],[CardNotes],[ElevTrapNotes],[VisitorNotes],[SystemTypeID],[CountryID],[CreatedOn],[CreatedBy],[ModifiedOn],[ModifiedBy],[VisitorSiteCode],[WinUITypeID],[LastExportParkingTag],[AutoIssueNotifyEmail],[CardKeyMode],[AccessLevelMode],[HotClient],[HotExpire]) VALUES(@BDBuildingPK,@BuildingID,@BuildingName,@Address1,@StreetNumb,@StreetName,@Address2,@City,@State,@Zipcode,@County,@TimezoneID,@Federal,@Phone,@Fax,@BldgNotes,@CardNotes,@ElevTrapNotes,@VisitorNotes,@SystemTypeID,@CountryID,@CreatedOn,@CreatedBy,@ModifiedOn,@ModifiedBy,@VisitorSiteCode,@WinUITypeID,@LastExportParkingTag,@AutoIssueNotifyEmail,@CardKeyMode,@AccessLevelMode,@HotClient,@HotExpire)", this.TableName);
			SqlParameter[] paras = new SqlParameter[33];
			paras[0] = new SqlParameter("@BDBuildingPK", SqlDbType.UniqueIdentifier);
			if (entity.BDBuildingPK == Guid.Empty)
			{
				paras[0].Value = DBNull.Value;
			}
			else
			{
				paras[0].Value = entity.BDBuildingPK;
			}
			paras[1] = new SqlParameter("@BuildingID", SqlDbType.Int);
			paras[1].Value = entity.BuildingID;
			paras[2] = new SqlParameter("@BuildingName", SqlDbType.VarChar, 60);
			paras[2].Value = entity.BuildingName;
			paras[3] = new SqlParameter("@Address1", SqlDbType.VarChar, 55);
			paras[3].Value = entity.Address1;
			paras[4] = new SqlParameter("@StreetNumb", SqlDbType.VarChar, 50);
			paras[4].Value = entity.StreetNumb;
			paras[5] = new SqlParameter("@StreetName", SqlDbType.VarChar, 50);
			paras[5].Value = entity.StreetName;
			paras[6] = new SqlParameter("@Address2", SqlDbType.VarChar, 30);
			paras[6].Value = entity.Address2;
			paras[7] = new SqlParameter("@City", SqlDbType.VarChar, 35);
			paras[7].Value = entity.City;
			paras[8] = new SqlParameter("@State", SqlDbType.Char, 2);
			paras[8].Value = entity.State;
			paras[9] = new SqlParameter("@Zipcode", SqlDbType.VarChar, 10);
			paras[9].Value = entity.Zipcode;
			paras[10] = new SqlParameter("@County", SqlDbType.VarChar, 35);
			paras[10].Value = entity.County;
			paras[11] = new SqlParameter("@TimezoneID", SqlDbType.Int);
			paras[11].Value = entity.TimezoneID;
			paras[12] = new SqlParameter("@Federal", SqlDbType.Bit);
			paras[12].Value = entity.Federal;
			paras[13] = new SqlParameter("@Phone", SqlDbType.VarChar, 20);
			paras[13].Value = entity.Phone;
			paras[14] = new SqlParameter("@Fax", SqlDbType.VarChar, 20);
			paras[14].Value = entity.Fax;
			paras[15] = new SqlParameter("@BldgNotes", SqlDbType.VarChar, 2048);
			paras[15].Value = entity.BldgNotes;
			paras[16] = new SqlParameter("@CardNotes", SqlDbType.VarChar, 2048);
			paras[16].Value = entity.CardNotes;
			paras[17] = new SqlParameter("@ElevTrapNotes", SqlDbType.VarChar, 3072);
			paras[17].Value = entity.ElevTrapNotes;
			paras[18] = new SqlParameter("@VisitorNotes", SqlDbType.VarChar, 2048);
			paras[18].Value = entity.VisitorNotes;
			paras[19] = new SqlParameter("@SystemTypeID", SqlDbType.Int);
			paras[19].Value = entity.SystemTypeID;
			paras[20] = new SqlParameter("@CountryID", SqlDbType.Int);
			paras[20].Value = entity.CountryID;
			paras[21] = new SqlParameter("@CreatedOn", SqlDbType.DateTime);
			paras[21].Value = entity.CreatedOn;
			paras[22] = new SqlParameter("@CreatedBy", SqlDbType.VarChar, 30);
			paras[22].Value = entity.CreatedBy;
			paras[23] = new SqlParameter("@ModifiedOn", SqlDbType.DateTime);
			paras[23].Value = entity.ModifiedOn;
			paras[24] = new SqlParameter("@ModifiedBy", SqlDbType.VarChar, 30);
			paras[24].Value = entity.ModifiedBy;
			paras[25] = new SqlParameter("@VisitorSiteCode", SqlDbType.Int);
			paras[25].Value = entity.VisitorSiteCode;
			paras[26] = new SqlParameter("@WinUITypeID", SqlDbType.Int);
			paras[26].Value = entity.WinUITypeID;
			paras[27] = new SqlParameter("@LastExportParkingTag", SqlDbType.DateTime);
			paras[27].Value = entity.LastExportParkingTag;
			paras[28] = new SqlParameter("@AutoIssueNotifyEmail", SqlDbType.VarChar, 256);
			paras[28].Value = entity.AutoIssueNotifyEmail;
			paras[29] = new SqlParameter("@CardKeyMode", SqlDbType.TinyInt);
			paras[29].Value = entity.CardKeyMode;
			paras[30] = new SqlParameter("@AccessLevelMode", SqlDbType.VarChar, 512);
			paras[30].Value = entity.AccessLevelMode;
			paras[31] = new SqlParameter("@HotClient", SqlDbType.Bit);
			paras[31].Value = entity.HotClient;
			paras[32] = new SqlParameter("@HotExpire", SqlDbType.DateTime);
			paras[32].Value = entity.HotExpire;
			return base.ExecuteNonQuery(sql, paras);
		}

		public int Update(BDBuildingData entity)
		{
			string sql = string.Format("UPDATE [{0}] SET [BuildingID] = @BuildingID,[BuildingName] = @BuildingName,[Address1] = @Address1,[StreetNumb] = @StreetNumb,[StreetName] = @StreetName,[Address2] = @Address2,[City] = @City,[State] = @State,[Zipcode] = @Zipcode,[County] = @County,[TimezoneID] = @TimezoneID,[Federal] = @Federal,[Phone] = @Phone,[Fax] = @Fax,[BldgNotes] = @BldgNotes,[CardNotes] = @CardNotes,[ElevTrapNotes] = @ElevTrapNotes,[VisitorNotes] = @VisitorNotes,[SystemTypeID] = @SystemTypeID,[CountryID] = @CountryID,[CreatedOn] = @CreatedOn,[CreatedBy] = @CreatedBy,[ModifiedOn] = @ModifiedOn,[ModifiedBy] = @ModifiedBy,[VisitorSiteCode] = @VisitorSiteCode,[WinUITypeID] = @WinUITypeID,[LastExportParkingTag] = @LastExportParkingTag,[AutoIssueNotifyEmail] = @AutoIssueNotifyEmail,[CardKeyMode] = @CardKeyMode,[AccessLevelMode] = @AccessLevelMode,[HotClient] = @HotClient,[HotExpire] = @HotExpire  WHERE [BDBuildingPK] = @BDBuildingPK AND [RowVersion] = @RowVersion", this.TableName);
			SqlParameter[] paras = new SqlParameter[34];
			paras[0] = new SqlParameter("@BDBuildingPK", SqlDbType.UniqueIdentifier);
			if (entity.BDBuildingPK == Guid.Empty)
			{
				paras[0].Value = DBNull.Value;
			}
			else
			{
				paras[0].Value = entity.BDBuildingPK;
			}
			paras[1] = new SqlParameter("@BuildingID", SqlDbType.Int);
			paras[1].Value = entity.BuildingID;
			paras[2] = new SqlParameter("@BuildingName", SqlDbType.VarChar, 60);
			paras[2].Value = entity.BuildingName;
			paras[3] = new SqlParameter("@Address1", SqlDbType.VarChar, 55);
			paras[3].Value = entity.Address1;
			paras[4] = new SqlParameter("@StreetNumb", SqlDbType.VarChar, 50);
			paras[4].Value = entity.StreetNumb;
			paras[5] = new SqlParameter("@StreetName", SqlDbType.VarChar, 50);
			paras[5].Value = entity.StreetName;
			paras[6] = new SqlParameter("@Address2", SqlDbType.VarChar, 30);
			paras[6].Value = entity.Address2;
			paras[7] = new SqlParameter("@City", SqlDbType.VarChar, 35);
			paras[7].Value = entity.City;
			paras[8] = new SqlParameter("@State", SqlDbType.Char, 2);
			paras[8].Value = entity.State;
			paras[9] = new SqlParameter("@Zipcode", SqlDbType.VarChar, 10);
			paras[9].Value = entity.Zipcode;
			paras[10] = new SqlParameter("@County", SqlDbType.VarChar, 35);
			paras[10].Value = entity.County;
			paras[11] = new SqlParameter("@TimezoneID", SqlDbType.Int);
			paras[11].Value = entity.TimezoneID;
			paras[12] = new SqlParameter("@Federal", SqlDbType.Bit);
			paras[12].Value = entity.Federal;
			paras[13] = new SqlParameter("@Phone", SqlDbType.VarChar, 20);
			paras[13].Value = entity.Phone;
			paras[14] = new SqlParameter("@Fax", SqlDbType.VarChar, 20);
			paras[14].Value = entity.Fax;
			paras[15] = new SqlParameter("@BldgNotes", SqlDbType.VarChar, 2048);
			paras[15].Value = entity.BldgNotes;
			paras[16] = new SqlParameter("@CardNotes", SqlDbType.VarChar, 2048);
			paras[16].Value = entity.CardNotes;
			paras[17] = new SqlParameter("@ElevTrapNotes", SqlDbType.VarChar, 3072);
			paras[17].Value = entity.ElevTrapNotes;
			paras[18] = new SqlParameter("@VisitorNotes", SqlDbType.VarChar, 2048);
			paras[18].Value = entity.VisitorNotes;
			paras[19] = new SqlParameter("@SystemTypeID", SqlDbType.Int);
			paras[19].Value = entity.SystemTypeID;
			paras[20] = new SqlParameter("@CountryID", SqlDbType.Int);
			paras[20].Value = entity.CountryID;
			paras[21] = new SqlParameter("@RowVersion", SqlDbType.Timestamp);
			paras[21].Value = entity.RowVersion;
			paras[22] = new SqlParameter("@CreatedOn", SqlDbType.DateTime);
			paras[22].Value = entity.CreatedOn;
			paras[23] = new SqlParameter("@CreatedBy", SqlDbType.VarChar, 30);
			paras[23].Value = entity.CreatedBy;
			paras[24] = new SqlParameter("@ModifiedOn", SqlDbType.DateTime);
			paras[24].Value = entity.ModifiedOn;
			paras[25] = new SqlParameter("@ModifiedBy", SqlDbType.VarChar, 30);
			paras[25].Value = entity.ModifiedBy;
			paras[26] = new SqlParameter("@VisitorSiteCode", SqlDbType.Int);
			paras[26].Value = entity.VisitorSiteCode;
			paras[27] = new SqlParameter("@WinUITypeID", SqlDbType.Int);
			paras[27].Value = entity.WinUITypeID;
			paras[28] = new SqlParameter("@LastExportParkingTag", SqlDbType.DateTime);
			paras[28].Value = entity.LastExportParkingTag;
			paras[29] = new SqlParameter("@AutoIssueNotifyEmail", SqlDbType.VarChar, 256);
			paras[29].Value = entity.AutoIssueNotifyEmail;
			paras[30] = new SqlParameter("@CardKeyMode", SqlDbType.TinyInt);
			paras[30].Value = entity.CardKeyMode;
			paras[31] = new SqlParameter("@AccessLevelMode", SqlDbType.VarChar, 512);
			paras[31].Value = entity.AccessLevelMode;
			paras[32] = new SqlParameter("@HotClient", SqlDbType.Bit);
			paras[32].Value = entity.HotClient;
			paras[33] = new SqlParameter("@HotExpire", SqlDbType.DateTime);
			paras[33].Value = entity.HotExpire;
			return base.ExecuteNonQuery(sql, paras);
		}

		private BDBuildingData CreateDataByReader(SafeDataReader reader)
		{
			BDBuildingData data = new BDBuildingData {
				BDBuildingPK = (Guid) reader["BDBuildingPK"],
				BuildingID = (Int32) reader["BuildingID"],
				BuildingName = (String) reader["BuildingName"],
				Address1 = (String) reader["Address1"],
				StreetNumb = (String) reader["StreetNumb"],
				StreetName = (String) reader["StreetName"],
				Address2 = (String) reader["Address2"],
				City = (String) reader["City"],
				State = (String) reader["State"],
				Zipcode = (String) reader["Zipcode"],
				County = (String) reader["County"],
				TimezoneID = (Int32) reader["TimezoneID"],
				Federal = (Boolean) reader["Federal"],
				Phone = (String) reader["Phone"],
				Fax = (String) reader["Fax"],
				BldgNotes = (String) reader["BldgNotes"],
				CardNotes = (String) reader["CardNotes"],
				ElevTrapNotes = (String) reader["ElevTrapNotes"],
				VisitorNotes = (String) reader["VisitorNotes"],
				SystemTypeID = (Int32) reader["SystemTypeID"],
				CountryID = (Int32) reader["CountryID"],
				RowVersion = (Byte[]) reader["RowVersion"],
				CreatedOn = (DateTime) reader["CreatedOn"],
				CreatedBy = (String) reader["CreatedBy"],
				ModifiedOn = (DateTime) reader["ModifiedOn"],
				ModifiedBy = (String) reader["ModifiedBy"],
				VisitorSiteCode = (Int32) reader["VisitorSiteCode"],
				WinUITypeID = (Int32) reader["WinUITypeID"],
				LastExportParkingTag = (DateTime) reader["LastExportParkingTag"],
				AutoIssueNotifyEmail = (String) reader["AutoIssueNotifyEmail"],
				CardKeyMode = (Byte) reader["CardKeyMode"],
				AccessLevelMode = (String) reader["AccessLevelMode"],
				HotClient = (Boolean) reader["HotClient"],
				HotExpire = (DateTime) reader["HotExpire"]
			};
			data.AcceptChanges();
			return data;
		}

		private BDBuildingData FetchEntity(string where, SqlParameter[] paras)
		{
			BDBuildingData data = null;
			using (SafeDataReader reader = base.ExecuteDataReader(where, paras))
			{
				if (reader.Read())
				{
					data = this.CreateDataByReader(reader);
				}
				reader.Close();
			}
			return data;
		}

		private BDBuildingData FetchEntityEx(string sql, SqlParameter[] paras)
		{
			BDBuildingData data = null;
			using (SafeDataReader reader = base.ExecuteDataReaderEx(sql, paras))
			{
				if (reader.Read())
				{
					data = this.CreateDataByReader(reader);
				}
				reader.Close();
			}
			return data;
		}

		private BDBuildingDataCollection FetchCollection(string where, SqlParameter[] paras)
		{
			BDBuildingDataCollection list = new BDBuildingDataCollection();
			using (SafeDataReader reader = base.ExecuteDataReader(where, paras))
			{
				while(reader.Read())
				{
					BDBuildingData data = this.CreateDataByReader(reader);
					list.Add(data);
				}
				reader.Close();
			}
			return list;
		}

		private BDBuildingDataCollection FetchCollectionEx(string sql, SqlParameter[] paras)
		{
			BDBuildingDataCollection list = new BDBuildingDataCollection();
			using (SafeDataReader reader = base.ExecuteDataReaderEx(sql, paras))
			{
				while(reader.Read())
				{
					BDBuildingData data = this.CreateDataByReader(reader);
					list.Add(data);
				}
				reader.Close();
			}
			return list;
		}

		public BDBuildingData GetEntityBy(string sqlWhere, SqlParameter[] paras)
		{
			return this.FetchEntity(sqlWhere, paras);
		}

		public BDBuildingData GetEntityExBy(string sql, SqlParameter[] paras)
		{
			return this.FetchEntityEx(sql, paras);
		}

		public BDBuildingDataCollection GetCollectionBy(string sqlWhere, SqlParameter[] paras)
		{
			return this.FetchCollection(sqlWhere, paras);
		}

		public BDBuildingDataCollection GetCollectionExBy(string sql, SqlParameter[] paras)
		{
			return this.FetchCollectionEx(sql, paras);
		}

		public byte[] GetRowVersion( System.Guid BDBuildingPK)
		{
			string sql = string.Format("SELECT [RowVersion] AS [RowVersion] FROM [{0}] WHERE  [BDBuildingPK] = @BDBuildingPK ", this.TableName);
			SqlParameter[] paras = new SqlParameter[1];
			paras[0] = new SqlParameter("@BDBuildingPK", SqlDbType.UniqueIdentifier, 16);
			paras[0].Value = BDBuildingPK;
			return (byte[]) base.ExecuteScalar(sql, paras);
		}

		public BDBuildingData GetByPK( System.Guid BDBuildingPK)
		{
			string sql = " WHERE  [BDBuilding].[BDBuildingPK] = @BDBuildingPK ";
			SqlParameter[] paras = new SqlParameter[1];
			paras[0] = new SqlParameter("@BDBuildingPK", SqlDbType.UniqueIdentifier);
			paras[0].Value = BDBuildingPK;
			return this.FetchEntity(sql, paras);
		}

		public BDBuildingDataCollection GetAll()
		{
			return this.FetchCollection("", null);
		}

		public DataTable GetLogByPK( System.Guid BDBuildingPK)
		{
			string sql = string.Format("SELECT  [BDBuilding].[BDBuildingPK] AS [BDBuildingPK], [BDBuilding].[ModifiedOn] AS [ModifiedOn] FROM [{0}] WHERE  [BDBuilding].[BDBuildingPK] = @BDBuildingPK ", this.TableName);
			SqlParameter[] paras = new SqlParameter[1];
			paras[0] = new SqlParameter("@BDBuildingPK", SqlDbType.UniqueIdentifier);
			paras[0].Value = BDBuildingPK;
			return this.ExecuteDataTable(sql, paras);
		}

		public int DeleteByPK( System.Guid BDBuildingPK, byte[] RowVersion)
		{
			string sql = string.Format("DELETE FROM [{0}] WHERE  [BDBuildingPK] = @BDBuildingPK AND [RowVersion] = @RowVersion", this.TableName);
			SqlParameter[] paras = new SqlParameter[2];
			paras[0] = new SqlParameter("@BDBuildingPK", SqlDbType.UniqueIdentifier);
			paras[0].Value = BDBuildingPK;
			paras[1] = new SqlParameter("@RowVersion", SqlDbType.Timestamp, 8);
			paras[1].Value = RowVersion;
			return base.ExecuteNonQuery(sql, paras);
		}

		public int DeleteAll()
		{
			string sql = string.Format("DELETE FROM [{0}]", this.TableName);
			return base.ExecuteNonQuery(sql, null);
		}


	}
	public class BDTenantCRUD : DataAccessBase
	{
		private string _tableName = "BDTenant";

		public BDTenantCRUD(string connectionString) : base(connectionString)
		{
		}

		public virtual string TableName
		{
			get { return this._tableName; }
			set { this._tableName = value; }
		}

		public string SQLColumns
		{
			get
			{
				return "[BDTenant].[BDTenantPK] AS [BDTenantPK],[BDTenant].[BDBuildingPK] AS [BDBuildingPK],[BDTenant].[Tenant] AS [Tenant],[BDTenant].[Suite] AS [Suite],[BDTenant].[Phone] AS [Phone],[BDTenant].[Fax] AS [Fax],[BDTenant].[Blocked] AS [Blocked],[BDTenant].[Federal] AS [Federal],[BDTenant].[TentNotes] AS [TentNotes],[BDTenant].[CardNotes] AS [CardNotes],[BDTenant].[VisitorNotes] AS [VisitorNotes],[BDTenant].[IsManagement] AS [IsManagement],[BDTenant].[Type] AS [Type],[BDTenant].[NoRecycleCard] AS [NoRecycleCard],[BDTenant].[SystemTypeID] AS [SystemTypeID],[BDTenant].[RowVersion] AS [RowVersion],[BDTenant].[CreatedOn] AS [CreatedOn],[BDTenant].[CreatedBy] AS [CreatedBy],[BDTenant].[ModifiedOn] AS [ModifiedOn],[BDTenant].[ModifiedBy] AS [ModifiedBy],[BDTenant].[ParkingAccount] AS [ParkingAccount],[BDTenant].[CustInfo1] AS [CustInfo1],[BDTenant].[CustInfo2] AS [CustInfo2],[BDTenant].[CustInfo3] AS [CustInfo3],[BDTenant].[CustInfo4] AS [CustInfo4],[BDTenant].[CustInfo5] AS [CustInfo5],[BDTenant].[CustInfo6] AS [CustInfo6],[BDTenant].[CustInfo7] AS [CustInfo7],[BDTenant].[CustInfo8] AS [CustInfo8],[BDTenant].[DelExpiredCard] AS [DelExpiredCard],[BDTenant].[HotClient] AS [HotClient],[BDTenant].[HotExpire] AS [HotExpire],[BDTenant].[Email] AS [Email],[BDBuilding].[Address1] AS [Address1],[BDBuilding].[BuildingID] AS [BuildingID]";
			}
		}

		public string SQLLeftJoins
		{
			get
			{
				return "LEFT JOIN [BDBuilding] [BDBuilding] ON [BDTenant].[BDBuildingPK] = [BDBuilding].[BDBuildingPK]";
			}
		}

		protected override string SQLSelect
		{
			get
			{
				return string.Format("SELECT [BDTenant].[BDTenantPK] AS [BDTenantPK],[BDTenant].[BDBuildingPK] AS [BDBuildingPK],[BDTenant].[Tenant] AS [Tenant],[BDTenant].[Suite] AS [Suite],[BDTenant].[Phone] AS [Phone],[BDTenant].[Fax] AS [Fax],[BDTenant].[Blocked] AS [Blocked],[BDTenant].[Federal] AS [Federal],[BDTenant].[TentNotes] AS [TentNotes],[BDTenant].[CardNotes] AS [CardNotes],[BDTenant].[VisitorNotes] AS [VisitorNotes],[BDTenant].[IsManagement] AS [IsManagement],[BDTenant].[Type] AS [Type],[BDTenant].[NoRecycleCard] AS [NoRecycleCard],[BDTenant].[SystemTypeID] AS [SystemTypeID],[BDTenant].[RowVersion] AS [RowVersion],[BDTenant].[CreatedOn] AS [CreatedOn],[BDTenant].[CreatedBy] AS [CreatedBy],[BDTenant].[ModifiedOn] AS [ModifiedOn],[BDTenant].[ModifiedBy] AS [ModifiedBy],[BDTenant].[ParkingAccount] AS [ParkingAccount],[BDTenant].[CustInfo1] AS [CustInfo1],[BDTenant].[CustInfo2] AS [CustInfo2],[BDTenant].[CustInfo3] AS [CustInfo3],[BDTenant].[CustInfo4] AS [CustInfo4],[BDTenant].[CustInfo5] AS [CustInfo5],[BDTenant].[CustInfo6] AS [CustInfo6],[BDTenant].[CustInfo7] AS [CustInfo7],[BDTenant].[CustInfo8] AS [CustInfo8],[BDTenant].[DelExpiredCard] AS [DelExpiredCard],[BDTenant].[HotClient] AS [HotClient],[BDTenant].[HotExpire] AS [HotExpire],[BDTenant].[Email] AS [Email],[BDBuilding].[Address1] AS [Address1],[BDBuilding].[BuildingID] AS [BuildingID] FROM [{0}] [BDTenant] LEFT JOIN [BDBuilding] [BDBuilding] ON [BDTenant].[BDBuildingPK] = [BDBuilding].[BDBuildingPK]", this.TableName);
			}
		}

		protected override string SQLCount
		{
			get
			{
				return string.Format("SELECT COUNT(*) FROM [{0}] [BDTenant] LEFT JOIN [BDBuilding] [BDBuilding] ON [BDTenant].[BDBuildingPK] = [BDBuilding].[BDBuildingPK]", this.TableName);
			}
		}

		public int Insert(BDTenantData entity)
		{
			string sql = string.Format("INSERT INTO [{0}] ([BDTenantPK],[BDBuildingPK],[Tenant],[Suite],[Phone],[Fax],[Blocked],[Federal],[TentNotes],[CardNotes],[VisitorNotes],[IsManagement],[Type],[NoRecycleCard],[SystemTypeID],[CreatedOn],[CreatedBy],[ModifiedOn],[ModifiedBy],[ParkingAccount],[CustInfo1],[CustInfo2],[CustInfo3],[CustInfo4],[CustInfo5],[CustInfo6],[CustInfo7],[CustInfo8],[DelExpiredCard],[HotClient],[HotExpire],[Email]) VALUES(@BDTenantPK,@BDBuildingPK,@Tenant,@Suite,@Phone,@Fax,@Blocked,@Federal,@TentNotes,@CardNotes,@VisitorNotes,@IsManagement,@Type,@NoRecycleCard,@SystemTypeID,@CreatedOn,@CreatedBy,@ModifiedOn,@ModifiedBy,@ParkingAccount,@CustInfo1,@CustInfo2,@CustInfo3,@CustInfo4,@CustInfo5,@CustInfo6,@CustInfo7,@CustInfo8,@DelExpiredCard,@HotClient,@HotExpire,@Email)", this.TableName);
			SqlParameter[] paras = new SqlParameter[32];
			paras[0] = new SqlParameter("@BDTenantPK", SqlDbType.UniqueIdentifier);
			if (entity.BDTenantPK == Guid.Empty)
			{
				paras[0].Value = DBNull.Value;
			}
			else
			{
				paras[0].Value = entity.BDTenantPK;
			}
			paras[1] = new SqlParameter("@BDBuildingPK", SqlDbType.UniqueIdentifier);
			if (entity.BDBuildingPK == Guid.Empty)
			{
				paras[1].Value = DBNull.Value;
			}
			else
			{
				paras[1].Value = entity.BDBuildingPK;
			}
			paras[2] = new SqlParameter("@Tenant", SqlDbType.VarChar, 60);
			paras[2].Value = entity.Tenant;
			paras[3] = new SqlParameter("@Suite", SqlDbType.VarChar, 30);
			paras[3].Value = entity.Suite;
			paras[4] = new SqlParameter("@Phone", SqlDbType.VarChar, 20);
			paras[4].Value = entity.Phone;
			paras[5] = new SqlParameter("@Fax", SqlDbType.VarChar, 20);
			paras[5].Value = entity.Fax;
			paras[6] = new SqlParameter("@Blocked", SqlDbType.Bit);
			paras[6].Value = entity.Blocked;
			paras[7] = new SqlParameter("@Federal", SqlDbType.Bit);
			paras[7].Value = entity.Federal;
			paras[8] = new SqlParameter("@TentNotes", SqlDbType.VarChar, 2048);
			paras[8].Value = entity.TentNotes;
			paras[9] = new SqlParameter("@CardNotes", SqlDbType.VarChar, 2048);
			paras[9].Value = entity.CardNotes;
			paras[10] = new SqlParameter("@VisitorNotes", SqlDbType.VarChar, 2048);
			paras[10].Value = entity.VisitorNotes;
			paras[11] = new SqlParameter("@IsManagement", SqlDbType.Bit);
			paras[11].Value = entity.IsManagement;
			paras[12] = new SqlParameter("@Type", SqlDbType.Char, 1);
			paras[12].Value = entity.Type;
			paras[13] = new SqlParameter("@NoRecycleCard", SqlDbType.Bit);
			paras[13].Value = entity.NoRecycleCard;
			paras[14] = new SqlParameter("@SystemTypeID", SqlDbType.Int);
			paras[14].Value = entity.SystemTypeID;
			paras[15] = new SqlParameter("@CreatedOn", SqlDbType.DateTime);
			paras[15].Value = entity.CreatedOn;
			paras[16] = new SqlParameter("@CreatedBy", SqlDbType.VarChar, 30);
			paras[16].Value = entity.CreatedBy;
			paras[17] = new SqlParameter("@ModifiedOn", SqlDbType.DateTime);
			paras[17].Value = entity.ModifiedOn;
			paras[18] = new SqlParameter("@ModifiedBy", SqlDbType.VarChar, 30);
			paras[18].Value = entity.ModifiedBy;
			paras[19] = new SqlParameter("@ParkingAccount", SqlDbType.VarChar, 30);
			paras[19].Value = entity.ParkingAccount;
			paras[20] = new SqlParameter("@CustInfo1", SqlDbType.VarChar, 50);
			paras[20].Value = entity.CustInfo1;
			paras[21] = new SqlParameter("@CustInfo2", SqlDbType.VarChar, 50);
			paras[21].Value = entity.CustInfo2;
			paras[22] = new SqlParameter("@CustInfo3", SqlDbType.VarChar, 50);
			paras[22].Value = entity.CustInfo3;
			paras[23] = new SqlParameter("@CustInfo4", SqlDbType.VarChar, 50);
			paras[23].Value = entity.CustInfo4;
			paras[24] = new SqlParameter("@CustInfo5", SqlDbType.VarChar, 50);
			paras[24].Value = entity.CustInfo5;
			paras[25] = new SqlParameter("@CustInfo6", SqlDbType.VarChar, 50);
			paras[25].Value = entity.CustInfo6;
			paras[26] = new SqlParameter("@CustInfo7", SqlDbType.VarChar, 50);
			paras[26].Value = entity.CustInfo7;
			paras[27] = new SqlParameter("@CustInfo8", SqlDbType.VarChar, 50);
			paras[27].Value = entity.CustInfo8;
			paras[28] = new SqlParameter("@DelExpiredCard", SqlDbType.Bit);
			paras[28].Value = entity.DelExpiredCard;
			paras[29] = new SqlParameter("@HotClient", SqlDbType.Bit);
			paras[29].Value = entity.HotClient;
			paras[30] = new SqlParameter("@HotExpire", SqlDbType.DateTime);
			paras[30].Value = entity.HotExpire;
			paras[31] = new SqlParameter("@Email", SqlDbType.VarChar, 128);
			paras[31].Value = entity.Email;
			return base.ExecuteNonQuery(sql, paras);
		}

		public int Update(BDTenantData entity)
		{
			string sql = string.Format("UPDATE [{0}] SET [BDBuildingPK] = @BDBuildingPK,[Tenant] = @Tenant,[Suite] = @Suite,[Phone] = @Phone,[Fax] = @Fax,[Blocked] = @Blocked,[Federal] = @Federal,[TentNotes] = @TentNotes,[CardNotes] = @CardNotes,[VisitorNotes] = @VisitorNotes,[IsManagement] = @IsManagement,[Type] = @Type,[NoRecycleCard] = @NoRecycleCard,[SystemTypeID] = @SystemTypeID,[CreatedOn] = @CreatedOn,[CreatedBy] = @CreatedBy,[ModifiedOn] = @ModifiedOn,[ModifiedBy] = @ModifiedBy,[ParkingAccount] = @ParkingAccount,[CustInfo1] = @CustInfo1,[CustInfo2] = @CustInfo2,[CustInfo3] = @CustInfo3,[CustInfo4] = @CustInfo4,[CustInfo5] = @CustInfo5,[CustInfo6] = @CustInfo6,[CustInfo7] = @CustInfo7,[CustInfo8] = @CustInfo8,[DelExpiredCard] = @DelExpiredCard,[HotClient] = @HotClient,[HotExpire] = @HotExpire,[Email] = @Email  WHERE [BDTenantPK] = @BDTenantPK AND [RowVersion] = @RowVersion", this.TableName);
			SqlParameter[] paras = new SqlParameter[33];
			paras[0] = new SqlParameter("@BDTenantPK", SqlDbType.UniqueIdentifier);
			if (entity.BDTenantPK == Guid.Empty)
			{
				paras[0].Value = DBNull.Value;
			}
			else
			{
				paras[0].Value = entity.BDTenantPK;
			}
			paras[1] = new SqlParameter("@BDBuildingPK", SqlDbType.UniqueIdentifier);
			if (entity.BDBuildingPK == Guid.Empty)
			{
				paras[1].Value = DBNull.Value;
			}
			else
			{
				paras[1].Value = entity.BDBuildingPK;
			}
			paras[2] = new SqlParameter("@Tenant", SqlDbType.VarChar, 60);
			paras[2].Value = entity.Tenant;
			paras[3] = new SqlParameter("@Suite", SqlDbType.VarChar, 30);
			paras[3].Value = entity.Suite;
			paras[4] = new SqlParameter("@Phone", SqlDbType.VarChar, 20);
			paras[4].Value = entity.Phone;
			paras[5] = new SqlParameter("@Fax", SqlDbType.VarChar, 20);
			paras[5].Value = entity.Fax;
			paras[6] = new SqlParameter("@Blocked", SqlDbType.Bit);
			paras[6].Value = entity.Blocked;
			paras[7] = new SqlParameter("@Federal", SqlDbType.Bit);
			paras[7].Value = entity.Federal;
			paras[8] = new SqlParameter("@TentNotes", SqlDbType.VarChar, 2048);
			paras[8].Value = entity.TentNotes;
			paras[9] = new SqlParameter("@CardNotes", SqlDbType.VarChar, 2048);
			paras[9].Value = entity.CardNotes;
			paras[10] = new SqlParameter("@VisitorNotes", SqlDbType.VarChar, 2048);
			paras[10].Value = entity.VisitorNotes;
			paras[11] = new SqlParameter("@IsManagement", SqlDbType.Bit);
			paras[11].Value = entity.IsManagement;
			paras[12] = new SqlParameter("@Type", SqlDbType.Char, 1);
			paras[12].Value = entity.Type;
			paras[13] = new SqlParameter("@NoRecycleCard", SqlDbType.Bit);
			paras[13].Value = entity.NoRecycleCard;
			paras[14] = new SqlParameter("@SystemTypeID", SqlDbType.Int);
			paras[14].Value = entity.SystemTypeID;
			paras[15] = new SqlParameter("@RowVersion", SqlDbType.Timestamp);
			paras[15].Value = entity.RowVersion;
			paras[16] = new SqlParameter("@CreatedOn", SqlDbType.DateTime);
			paras[16].Value = entity.CreatedOn;
			paras[17] = new SqlParameter("@CreatedBy", SqlDbType.VarChar, 30);
			paras[17].Value = entity.CreatedBy;
			paras[18] = new SqlParameter("@ModifiedOn", SqlDbType.DateTime);
			paras[18].Value = entity.ModifiedOn;
			paras[19] = new SqlParameter("@ModifiedBy", SqlDbType.VarChar, 30);
			paras[19].Value = entity.ModifiedBy;
			paras[20] = new SqlParameter("@ParkingAccount", SqlDbType.VarChar, 30);
			paras[20].Value = entity.ParkingAccount;
			paras[21] = new SqlParameter("@CustInfo1", SqlDbType.VarChar, 50);
			paras[21].Value = entity.CustInfo1;
			paras[22] = new SqlParameter("@CustInfo2", SqlDbType.VarChar, 50);
			paras[22].Value = entity.CustInfo2;
			paras[23] = new SqlParameter("@CustInfo3", SqlDbType.VarChar, 50);
			paras[23].Value = entity.CustInfo3;
			paras[24] = new SqlParameter("@CustInfo4", SqlDbType.VarChar, 50);
			paras[24].Value = entity.CustInfo4;
			paras[25] = new SqlParameter("@CustInfo5", SqlDbType.VarChar, 50);
			paras[25].Value = entity.CustInfo5;
			paras[26] = new SqlParameter("@CustInfo6", SqlDbType.VarChar, 50);
			paras[26].Value = entity.CustInfo6;
			paras[27] = new SqlParameter("@CustInfo7", SqlDbType.VarChar, 50);
			paras[27].Value = entity.CustInfo7;
			paras[28] = new SqlParameter("@CustInfo8", SqlDbType.VarChar, 50);
			paras[28].Value = entity.CustInfo8;
			paras[29] = new SqlParameter("@DelExpiredCard", SqlDbType.Bit);
			paras[29].Value = entity.DelExpiredCard;
			paras[30] = new SqlParameter("@HotClient", SqlDbType.Bit);
			paras[30].Value = entity.HotClient;
			paras[31] = new SqlParameter("@HotExpire", SqlDbType.DateTime);
			paras[31].Value = entity.HotExpire;
			paras[32] = new SqlParameter("@Email", SqlDbType.VarChar, 128);
			paras[32].Value = entity.Email;
			return base.ExecuteNonQuery(sql, paras);
		}

		private BDTenantData CreateDataByReader(SafeDataReader reader)
		{
			BDTenantData data = new BDTenantData {
				BDTenantPK = (Guid) reader["BDTenantPK"],
				BDBuildingPK = (Guid) reader["BDBuildingPK"],
				Tenant = (String) reader["Tenant"],
				Suite = (String) reader["Suite"],
				Phone = (String) reader["Phone"],
				Fax = (String) reader["Fax"],
				Blocked = (Boolean) reader["Blocked"],
				Federal = (Boolean) reader["Federal"],
				TentNotes = (String) reader["TentNotes"],
				CardNotes = (String) reader["CardNotes"],
				VisitorNotes = (String) reader["VisitorNotes"],
				IsManagement = (Boolean) reader["IsManagement"],
				Type = (String) reader["Type"],
				NoRecycleCard = (Boolean) reader["NoRecycleCard"],
				SystemTypeID = (Int32) reader["SystemTypeID"],
				RowVersion = (Byte[]) reader["RowVersion"],
				CreatedOn = (DateTime) reader["CreatedOn"],
				CreatedBy = (String) reader["CreatedBy"],
				ModifiedOn = (DateTime) reader["ModifiedOn"],
				ModifiedBy = (String) reader["ModifiedBy"],
				ParkingAccount = (String) reader["ParkingAccount"],
				CustInfo1 = (String) reader["CustInfo1"],
				CustInfo2 = (String) reader["CustInfo2"],
				CustInfo3 = (String) reader["CustInfo3"],
				CustInfo4 = (String) reader["CustInfo4"],
				CustInfo5 = (String) reader["CustInfo5"],
				CustInfo6 = (String) reader["CustInfo6"],
				CustInfo7 = (String) reader["CustInfo7"],
				CustInfo8 = (String) reader["CustInfo8"],
				DelExpiredCard = (Boolean) reader["DelExpiredCard"],
				HotClient = (Boolean) reader["HotClient"],
				HotExpire = (DateTime) reader["HotExpire"],
				Email = (String) reader["Email"],
				Address1 = (String) reader["Address1"],
				BuildingID = (Int32) reader["BuildingID"]
			};
			data.AcceptChanges();
			return data;
		}

		private BDTenantData FetchEntity(string where, SqlParameter[] paras)
		{
			BDTenantData data = null;
			using (SafeDataReader reader = base.ExecuteDataReader(where, paras))
			{
				if (reader.Read())
				{
					data = this.CreateDataByReader(reader);
				}
				reader.Close();
			}
			return data;
		}

		private BDTenantData FetchEntityEx(string sql, SqlParameter[] paras)
		{
			BDTenantData data = null;
			using (SafeDataReader reader = base.ExecuteDataReaderEx(sql, paras))
			{
				if (reader.Read())
				{
					data = this.CreateDataByReader(reader);
				}
				reader.Close();
			}
			return data;
		}

		private BDTenantDataCollection FetchCollection(string where, SqlParameter[] paras)
		{
			BDTenantDataCollection list = new BDTenantDataCollection();
			using (SafeDataReader reader = base.ExecuteDataReader(where, paras))
			{
				while(reader.Read())
				{
					BDTenantData data = this.CreateDataByReader(reader);
					list.Add(data);
				}
				reader.Close();
			}
			return list;
		}

		private BDTenantDataCollection FetchCollectionEx(string sql, SqlParameter[] paras)
		{
			BDTenantDataCollection list = new BDTenantDataCollection();
			using (SafeDataReader reader = base.ExecuteDataReaderEx(sql, paras))
			{
				while(reader.Read())
				{
					BDTenantData data = this.CreateDataByReader(reader);
					list.Add(data);
				}
				reader.Close();
			}
			return list;
		}

		public BDTenantData GetEntityBy(string sqlWhere, SqlParameter[] paras)
		{
			return this.FetchEntity(sqlWhere, paras);
		}

		public BDTenantData GetEntityExBy(string sql, SqlParameter[] paras)
		{
			return this.FetchEntityEx(sql, paras);
		}

		public BDTenantDataCollection GetCollectionBy(string sqlWhere, SqlParameter[] paras)
		{
			return this.FetchCollection(sqlWhere, paras);
		}

		public BDTenantDataCollection GetCollectionExBy(string sql, SqlParameter[] paras)
		{
			return this.FetchCollectionEx(sql, paras);
		}

		public byte[] GetRowVersion( System.Guid BDTenantPK)
		{
			string sql = string.Format("SELECT [RowVersion] AS [RowVersion] FROM [{0}] WHERE  [BDTenantPK] = @BDTenantPK ", this.TableName);
			SqlParameter[] paras = new SqlParameter[1];
			paras[0] = new SqlParameter("@BDTenantPK", SqlDbType.UniqueIdentifier, 16);
			paras[0].Value = BDTenantPK;
			return (byte[]) base.ExecuteScalar(sql, paras);
		}

		public BDTenantData GetByPK( System.Guid BDTenantPK)
		{
			string sql = " WHERE  [BDTenant].[BDTenantPK] = @BDTenantPK ";
			SqlParameter[] paras = new SqlParameter[1];
			paras[0] = new SqlParameter("@BDTenantPK", SqlDbType.UniqueIdentifier);
			paras[0].Value = BDTenantPK;
			return this.FetchEntity(sql, paras);
		}

		public BDTenantDataCollection GetAll()
		{
			return this.FetchCollection("", null);
		}

		public BDTenantDataCollection GetByBDBuilding(System.Guid BDBuildingPK)
		{
			string sqlWhere = " WHERE [BDTenant].[BDBuildingPK] = @BDBuildingPK";
			SqlParameter[] paras = new SqlParameter[1];
			paras[0] = new SqlParameter("@BDBuildingPK", SqlDbType.UniqueIdentifier);
			paras[0].Value = BDBuildingPK;
			return this.FetchCollection(sqlWhere, paras);
		}

		public DataTable GetLogByPK( System.Guid BDTenantPK)
		{
			string sql = string.Format("SELECT  [BDTenant].[BDTenantPK] AS [BDTenantPK], [BDTenant].[ModifiedOn] AS [ModifiedOn] FROM [{0}] WHERE  [BDTenant].[BDTenantPK] = @BDTenantPK ", this.TableName);
			SqlParameter[] paras = new SqlParameter[1];
			paras[0] = new SqlParameter("@BDTenantPK", SqlDbType.UniqueIdentifier);
			paras[0].Value = BDTenantPK;
			return this.ExecuteDataTable(sql, paras);
		}

		public DataTable GetLogByBDBuilding(System.Guid bDBuildingPK)
		{
			string sql = string.Format("DELETE [{0}] FROM [{0}] [BDTenant] INNER JOIN [BDBuilding] ON [BDTenant].[BDBuildingPK] = [BDBuilding].[BDBuildingPK] WHERE [BDBuilding].[BDBuildingPK] = @BDBuildingPK;", this.TableName);
			string oldValue = string.Format("DELETE [{0}]", this.TableName);
			string newValue = "SELECT  [BDTenant].[BDTenantPK] AS [BDTenantPK], [BDTenant].[ModifiedOn] AS [ModifiedOn]";
			sql = sql.Replace(oldValue, newValue).TrimEnd().TrimEnd(';').Replace(";", " UNION ");
			SqlParameter[] paras = new SqlParameter[1];
			paras[0] = new SqlParameter("@BDBuildingPK", SqlDbType.UniqueIdentifier);
			paras[0].Value = bDBuildingPK;
			return base.ExecuteDataTable(sql, paras);
		}

		public int DeleteByPK( System.Guid BDTenantPK, byte[] RowVersion)
		{
			string sql = string.Format("DELETE FROM [{0}] WHERE  [BDTenantPK] = @BDTenantPK AND [RowVersion] = @RowVersion", this.TableName);
			SqlParameter[] paras = new SqlParameter[2];
			paras[0] = new SqlParameter("@BDTenantPK", SqlDbType.UniqueIdentifier);
			paras[0].Value = BDTenantPK;
			paras[1] = new SqlParameter("@RowVersion", SqlDbType.Timestamp, 8);
			paras[1].Value = RowVersion;
			return base.ExecuteNonQuery(sql, paras);
		}

		public int DeleteAll()
		{
			string sql = string.Format("DELETE FROM [{0}]", this.TableName);
			return base.ExecuteNonQuery(sql, null);
		}

		public int DeleteByBDBuilding(System.Guid bDBuildingPK)
		{
			string sql = string.Format("DELETE [{0}] FROM [{0}] [BDTenant] INNER JOIN [BDBuilding] ON [BDTenant].[BDBuildingPK] = [BDBuilding].[BDBuildingPK] WHERE [BDBuilding].[BDBuildingPK] = @BDBuildingPK;", this.TableName);
			SqlParameter[] paras = new SqlParameter[1];
			paras[0] = new SqlParameter("@BDBuildingPK", SqlDbType.UniqueIdentifier);
			paras[0].Value = bDBuildingPK;
			return base.ExecuteNonQuery(sql, paras);
		}


	}
	public class UtilSettingCategoryCRUD : DataAccessBase
	{
		private string _tableName = "UtilSettingCategory";

		public UtilSettingCategoryCRUD(string connectionString) : base(connectionString)
		{
		}

		public virtual string TableName
		{
			get { return this._tableName; }
			set { this._tableName = value; }
		}

		public string SQLColumns
		{
			get
			{
				return "[UtilSettingCategory].[UtilSettingCategoryPK] AS [UtilSettingCategoryPK],[UtilSettingCategory].[SettingCategoryID] AS [SettingCategoryID],[UtilSettingCategory].[SettingCategory] AS [SettingCategory],[UtilSettingCategory].[InstanceName] AS [InstanceName],[UtilSettingCategory].[RowVersion] AS [RowVersion],[UtilSettingCategory].[CreatedOn] AS [CreatedOn],[UtilSettingCategory].[CreatedBy] AS [CreatedBy],[UtilSettingCategory].[ModifiedOn] AS [ModifiedOn],[UtilSettingCategory].[ModifiedBy] AS [ModifiedBy],[UtilSettingCategory].[BDBuildingPK] AS [BDBuildingPK]";
			}
		}

		public string SQLLeftJoins
		{
			get
			{
				return "";
			}
		}

		protected override string SQLSelect
		{
			get
			{
				return string.Format("SELECT [UtilSettingCategory].[UtilSettingCategoryPK] AS [UtilSettingCategoryPK],[UtilSettingCategory].[SettingCategoryID] AS [SettingCategoryID],[UtilSettingCategory].[SettingCategory] AS [SettingCategory],[UtilSettingCategory].[InstanceName] AS [InstanceName],[UtilSettingCategory].[RowVersion] AS [RowVersion],[UtilSettingCategory].[CreatedOn] AS [CreatedOn],[UtilSettingCategory].[CreatedBy] AS [CreatedBy],[UtilSettingCategory].[ModifiedOn] AS [ModifiedOn],[UtilSettingCategory].[ModifiedBy] AS [ModifiedBy],[UtilSettingCategory].[BDBuildingPK] AS [BDBuildingPK] FROM [{0}] [UtilSettingCategory] ", this.TableName);
			}
		}

		protected override string SQLCount
		{
			get
			{
				return string.Format("SELECT COUNT(*) FROM [{0}] [UtilSettingCategory] ", this.TableName);
			}
		}

		public int Insert(UtilSettingCategoryData entity)
		{
			string sql = string.Format("INSERT INTO [{0}] ([UtilSettingCategoryPK],[SettingCategoryID],[SettingCategory],[InstanceName],[CreatedOn],[CreatedBy],[ModifiedOn],[ModifiedBy],[BDBuildingPK]) VALUES(@UtilSettingCategoryPK,@SettingCategoryID,@SettingCategory,@InstanceName,@CreatedOn,@CreatedBy,@ModifiedOn,@ModifiedBy,@BDBuildingPK)", this.TableName);
			SqlParameter[] paras = new SqlParameter[9];
			paras[0] = new SqlParameter("@UtilSettingCategoryPK", SqlDbType.UniqueIdentifier);
			if (entity.UtilSettingCategoryPK == Guid.Empty)
			{
				paras[0].Value = DBNull.Value;
			}
			else
			{
				paras[0].Value = entity.UtilSettingCategoryPK;
			}
			paras[1] = new SqlParameter("@SettingCategoryID", SqlDbType.Int);
			paras[1].Value = entity.SettingCategoryID;
			paras[2] = new SqlParameter("@SettingCategory", SqlDbType.VarChar, 128);
			paras[2].Value = entity.SettingCategory;
			paras[3] = new SqlParameter("@InstanceName", SqlDbType.VarChar, 128);
			paras[3].Value = entity.InstanceName;
			paras[4] = new SqlParameter("@CreatedOn", SqlDbType.DateTime);
			paras[4].Value = entity.CreatedOn;
			paras[5] = new SqlParameter("@CreatedBy", SqlDbType.VarChar, 30);
			paras[5].Value = entity.CreatedBy;
			paras[6] = new SqlParameter("@ModifiedOn", SqlDbType.DateTime);
			paras[6].Value = entity.ModifiedOn;
			paras[7] = new SqlParameter("@ModifiedBy", SqlDbType.VarChar, 30);
			paras[7].Value = entity.ModifiedBy;
			paras[8] = new SqlParameter("@BDBuildingPK", SqlDbType.UniqueIdentifier);
			if (entity.BDBuildingPK == Guid.Empty)
			{
				paras[8].Value = DBNull.Value;
			}
			else
			{
				paras[8].Value = entity.BDBuildingPK;
			}
			return base.ExecuteNonQuery(sql, paras);
		}

		public int Update(UtilSettingCategoryData entity)
		{
			string sql = string.Format("UPDATE [{0}] SET [SettingCategoryID] = @SettingCategoryID,[SettingCategory] = @SettingCategory,[InstanceName] = @InstanceName,[CreatedOn] = @CreatedOn,[CreatedBy] = @CreatedBy,[ModifiedOn] = @ModifiedOn,[ModifiedBy] = @ModifiedBy,[BDBuildingPK] = @BDBuildingPK  WHERE [UtilSettingCategoryPK] = @UtilSettingCategoryPK AND [RowVersion] = @RowVersion", this.TableName);
			SqlParameter[] paras = new SqlParameter[10];
			paras[0] = new SqlParameter("@UtilSettingCategoryPK", SqlDbType.UniqueIdentifier);
			if (entity.UtilSettingCategoryPK == Guid.Empty)
			{
				paras[0].Value = DBNull.Value;
			}
			else
			{
				paras[0].Value = entity.UtilSettingCategoryPK;
			}
			paras[1] = new SqlParameter("@SettingCategoryID", SqlDbType.Int);
			paras[1].Value = entity.SettingCategoryID;
			paras[2] = new SqlParameter("@SettingCategory", SqlDbType.VarChar, 128);
			paras[2].Value = entity.SettingCategory;
			paras[3] = new SqlParameter("@InstanceName", SqlDbType.VarChar, 128);
			paras[3].Value = entity.InstanceName;
			paras[4] = new SqlParameter("@RowVersion", SqlDbType.Timestamp);
			paras[4].Value = entity.RowVersion;
			paras[5] = new SqlParameter("@CreatedOn", SqlDbType.DateTime);
			paras[5].Value = entity.CreatedOn;
			paras[6] = new SqlParameter("@CreatedBy", SqlDbType.VarChar, 30);
			paras[6].Value = entity.CreatedBy;
			paras[7] = new SqlParameter("@ModifiedOn", SqlDbType.DateTime);
			paras[7].Value = entity.ModifiedOn;
			paras[8] = new SqlParameter("@ModifiedBy", SqlDbType.VarChar, 30);
			paras[8].Value = entity.ModifiedBy;
			paras[9] = new SqlParameter("@BDBuildingPK", SqlDbType.UniqueIdentifier);
			if (entity.BDBuildingPK == Guid.Empty)
			{
				paras[9].Value = DBNull.Value;
			}
			else
			{
				paras[9].Value = entity.BDBuildingPK;
			}
			return base.ExecuteNonQuery(sql, paras);
		}

		private UtilSettingCategoryData CreateDataByReader(SafeDataReader reader)
		{
			UtilSettingCategoryData data = new UtilSettingCategoryData {
				UtilSettingCategoryPK = (Guid) reader["UtilSettingCategoryPK"],
				SettingCategoryID = (Int32) reader["SettingCategoryID"],
				SettingCategory = (String) reader["SettingCategory"],
				InstanceName = (String) reader["InstanceName"],
				RowVersion = (Byte[]) reader["RowVersion"],
				CreatedOn = (DateTime) reader["CreatedOn"],
				CreatedBy = (String) reader["CreatedBy"],
				ModifiedOn = (DateTime) reader["ModifiedOn"],
				ModifiedBy = (String) reader["ModifiedBy"],
				BDBuildingPK = (Guid) reader["BDBuildingPK"]
			};
			data.AcceptChanges();
			return data;
		}

		private UtilSettingCategoryData FetchEntity(string where, SqlParameter[] paras)
		{
			UtilSettingCategoryData data = null;
			using (SafeDataReader reader = base.ExecuteDataReader(where, paras))
			{
				if (reader.Read())
				{
					data = this.CreateDataByReader(reader);
				}
				reader.Close();
			}
			return data;
		}

		private UtilSettingCategoryData FetchEntityEx(string sql, SqlParameter[] paras)
		{
			UtilSettingCategoryData data = null;
			using (SafeDataReader reader = base.ExecuteDataReaderEx(sql, paras))
			{
				if (reader.Read())
				{
					data = this.CreateDataByReader(reader);
				}
				reader.Close();
			}
			return data;
		}

		private UtilSettingCategoryDataCollection FetchCollection(string where, SqlParameter[] paras)
		{
			UtilSettingCategoryDataCollection list = new UtilSettingCategoryDataCollection();
			using (SafeDataReader reader = base.ExecuteDataReader(where, paras))
			{
				while(reader.Read())
				{
					UtilSettingCategoryData data = this.CreateDataByReader(reader);
					list.Add(data);
				}
				reader.Close();
			}
			return list;
		}

		private UtilSettingCategoryDataCollection FetchCollectionEx(string sql, SqlParameter[] paras)
		{
			UtilSettingCategoryDataCollection list = new UtilSettingCategoryDataCollection();
			using (SafeDataReader reader = base.ExecuteDataReaderEx(sql, paras))
			{
				while(reader.Read())
				{
					UtilSettingCategoryData data = this.CreateDataByReader(reader);
					list.Add(data);
				}
				reader.Close();
			}
			return list;
		}

		public UtilSettingCategoryData GetEntityBy(string sqlWhere, SqlParameter[] paras)
		{
			return this.FetchEntity(sqlWhere, paras);
		}

		public UtilSettingCategoryData GetEntityExBy(string sql, SqlParameter[] paras)
		{
			return this.FetchEntityEx(sql, paras);
		}

		public UtilSettingCategoryDataCollection GetCollectionBy(string sqlWhere, SqlParameter[] paras)
		{
			return this.FetchCollection(sqlWhere, paras);
		}

		public UtilSettingCategoryDataCollection GetCollectionExBy(string sql, SqlParameter[] paras)
		{
			return this.FetchCollectionEx(sql, paras);
		}

		public byte[] GetRowVersion( System.Guid UtilSettingCategoryPK)
		{
			string sql = string.Format("SELECT [RowVersion] AS [RowVersion] FROM [{0}] WHERE  [UtilSettingCategoryPK] = @UtilSettingCategoryPK ", this.TableName);
			SqlParameter[] paras = new SqlParameter[1];
			paras[0] = new SqlParameter("@UtilSettingCategoryPK", SqlDbType.UniqueIdentifier, 16);
			paras[0].Value = UtilSettingCategoryPK;
			return (byte[]) base.ExecuteScalar(sql, paras);
		}

		public UtilSettingCategoryData GetByPK( System.Guid UtilSettingCategoryPK)
		{
			string sql = " WHERE  [UtilSettingCategory].[UtilSettingCategoryPK] = @UtilSettingCategoryPK ";
			SqlParameter[] paras = new SqlParameter[1];
			paras[0] = new SqlParameter("@UtilSettingCategoryPK", SqlDbType.UniqueIdentifier);
			paras[0].Value = UtilSettingCategoryPK;
			return this.FetchEntity(sql, paras);
		}

		public UtilSettingCategoryDataCollection GetAll()
		{
			return this.FetchCollection("", null);
		}

		public DataTable GetLogByPK( System.Guid UtilSettingCategoryPK)
		{
			string sql = string.Format("SELECT  [UtilSettingCategory].[UtilSettingCategoryPK] AS [UtilSettingCategoryPK], [UtilSettingCategory].[ModifiedOn] AS [ModifiedOn] FROM [{0}] WHERE  [UtilSettingCategory].[UtilSettingCategoryPK] = @UtilSettingCategoryPK ", this.TableName);
			SqlParameter[] paras = new SqlParameter[1];
			paras[0] = new SqlParameter("@UtilSettingCategoryPK", SqlDbType.UniqueIdentifier);
			paras[0].Value = UtilSettingCategoryPK;
			return this.ExecuteDataTable(sql, paras);
		}

		public int DeleteByPK( System.Guid UtilSettingCategoryPK, byte[] RowVersion)
		{
			string sql = string.Format("DELETE FROM [{0}] WHERE  [UtilSettingCategoryPK] = @UtilSettingCategoryPK AND [RowVersion] = @RowVersion", this.TableName);
			SqlParameter[] paras = new SqlParameter[2];
			paras[0] = new SqlParameter("@UtilSettingCategoryPK", SqlDbType.UniqueIdentifier);
			paras[0].Value = UtilSettingCategoryPK;
			paras[1] = new SqlParameter("@RowVersion", SqlDbType.Timestamp, 8);
			paras[1].Value = RowVersion;
			return base.ExecuteNonQuery(sql, paras);
		}

		public int DeleteAll()
		{
			string sql = string.Format("DELETE FROM [{0}]", this.TableName);
			return base.ExecuteNonQuery(sql, null);
		}


	}
	public class UtilSettingDetailCRUD : DataAccessBase
	{
		private string _tableName = "UtilSettingDetail";

		public UtilSettingDetailCRUD(string connectionString) : base(connectionString)
		{
		}

		public virtual string TableName
		{
			get { return this._tableName; }
			set { this._tableName = value; }
		}

		public string SQLColumns
		{
			get
			{
				return "[UtilSettingDetail].[UtilSettingDetailPK] AS [UtilSettingDetailPK],[UtilSettingDetail].[UtilSettingCategoryPK] AS [UtilSettingCategoryPK],[UtilSettingDetail].[FieldName] AS [FieldName],[UtilSettingDetail].[FieldValue] AS [FieldValue],[UtilSettingDetail].[Picture] AS [Picture],[UtilSettingDetail].[RowVersion] AS [RowVersion],[UtilSettingDetail].[CreatedOn] AS [CreatedOn],[UtilSettingDetail].[CreatedBy] AS [CreatedBy],[UtilSettingDetail].[ModifiedOn] AS [ModifiedOn],[UtilSettingDetail].[ModifiedBy] AS [ModifiedBy],[UtilSettingCategory].[SettingCategory] AS [SettingCategory],[UtilSettingCategory].[SettingCategoryID] AS [SettingCategoryID]";
			}
		}

		public string SQLLeftJoins
		{
			get
			{
				return "LEFT JOIN [UtilSettingCategory] [UtilSettingCategory] ON [UtilSettingDetail].[UtilSettingCategoryPK] = [UtilSettingCategory].[UtilSettingCategoryPK]";
			}
		}

		protected override string SQLSelect
		{
			get
			{
				return string.Format("SELECT [UtilSettingDetail].[UtilSettingDetailPK] AS [UtilSettingDetailPK],[UtilSettingDetail].[UtilSettingCategoryPK] AS [UtilSettingCategoryPK],[UtilSettingDetail].[FieldName] AS [FieldName],[UtilSettingDetail].[FieldValue] AS [FieldValue],[UtilSettingDetail].[Picture] AS [Picture],[UtilSettingDetail].[RowVersion] AS [RowVersion],[UtilSettingDetail].[CreatedOn] AS [CreatedOn],[UtilSettingDetail].[CreatedBy] AS [CreatedBy],[UtilSettingDetail].[ModifiedOn] AS [ModifiedOn],[UtilSettingDetail].[ModifiedBy] AS [ModifiedBy],[UtilSettingCategory].[SettingCategory] AS [SettingCategory],[UtilSettingCategory].[SettingCategoryID] AS [SettingCategoryID] FROM [{0}] [UtilSettingDetail] LEFT JOIN [UtilSettingCategory] [UtilSettingCategory] ON [UtilSettingDetail].[UtilSettingCategoryPK] = [UtilSettingCategory].[UtilSettingCategoryPK]", this.TableName);
			}
		}

		protected override string SQLCount
		{
			get
			{
				return string.Format("SELECT COUNT(*) FROM [{0}] [UtilSettingDetail] LEFT JOIN [UtilSettingCategory] [UtilSettingCategory] ON [UtilSettingDetail].[UtilSettingCategoryPK] = [UtilSettingCategory].[UtilSettingCategoryPK]", this.TableName);
			}
		}

		public int Insert(UtilSettingDetailData entity)
		{
			string sql = string.Format("INSERT INTO [{0}] ([UtilSettingDetailPK],[UtilSettingCategoryPK],[FieldName],[FieldValue],[Picture],[CreatedOn],[CreatedBy],[ModifiedOn],[ModifiedBy]) VALUES(@UtilSettingDetailPK,@UtilSettingCategoryPK,@FieldName,@FieldValue,@Picture,@CreatedOn,@CreatedBy,@ModifiedOn,@ModifiedBy)", this.TableName);
			SqlParameter[] paras = new SqlParameter[9];
			paras[0] = new SqlParameter("@UtilSettingDetailPK", SqlDbType.UniqueIdentifier);
			if (entity.UtilSettingDetailPK == Guid.Empty)
			{
				paras[0].Value = DBNull.Value;
			}
			else
			{
				paras[0].Value = entity.UtilSettingDetailPK;
			}
			paras[1] = new SqlParameter("@UtilSettingCategoryPK", SqlDbType.UniqueIdentifier);
			if (entity.UtilSettingCategoryPK == Guid.Empty)
			{
				paras[1].Value = DBNull.Value;
			}
			else
			{
				paras[1].Value = entity.UtilSettingCategoryPK;
			}
			paras[2] = new SqlParameter("@FieldName", SqlDbType.VarChar, 128);
			paras[2].Value = entity.FieldName;
			paras[3] = new SqlParameter("@FieldValue", SqlDbType.VarChar, 4096);
			paras[3].Value = entity.FieldValue;
			paras[4] = new SqlParameter("@Picture", SqlDbType.Image);
			paras[4].Value = entity.Picture;
			paras[5] = new SqlParameter("@CreatedOn", SqlDbType.DateTime);
			paras[5].Value = entity.CreatedOn;
			paras[6] = new SqlParameter("@CreatedBy", SqlDbType.VarChar, 30);
			paras[6].Value = entity.CreatedBy;
			paras[7] = new SqlParameter("@ModifiedOn", SqlDbType.DateTime);
			paras[7].Value = entity.ModifiedOn;
			paras[8] = new SqlParameter("@ModifiedBy", SqlDbType.VarChar, 30);
			paras[8].Value = entity.ModifiedBy;
			return base.ExecuteNonQuery(sql, paras);
		}

		public int Update(UtilSettingDetailData entity)
		{
			string sql = string.Format("UPDATE [{0}] SET [UtilSettingCategoryPK] = @UtilSettingCategoryPK,[FieldName] = @FieldName,[FieldValue] = @FieldValue,[Picture] = @Picture,[CreatedOn] = @CreatedOn,[CreatedBy] = @CreatedBy,[ModifiedOn] = @ModifiedOn,[ModifiedBy] = @ModifiedBy  WHERE [UtilSettingDetailPK] = @UtilSettingDetailPK AND [RowVersion] = @RowVersion", this.TableName);
			SqlParameter[] paras = new SqlParameter[10];
			paras[0] = new SqlParameter("@UtilSettingDetailPK", SqlDbType.UniqueIdentifier);
			if (entity.UtilSettingDetailPK == Guid.Empty)
			{
				paras[0].Value = DBNull.Value;
			}
			else
			{
				paras[0].Value = entity.UtilSettingDetailPK;
			}
			paras[1] = new SqlParameter("@UtilSettingCategoryPK", SqlDbType.UniqueIdentifier);
			if (entity.UtilSettingCategoryPK == Guid.Empty)
			{
				paras[1].Value = DBNull.Value;
			}
			else
			{
				paras[1].Value = entity.UtilSettingCategoryPK;
			}
			paras[2] = new SqlParameter("@FieldName", SqlDbType.VarChar, 128);
			paras[2].Value = entity.FieldName;
			paras[3] = new SqlParameter("@FieldValue", SqlDbType.VarChar, 4096);
			paras[3].Value = entity.FieldValue;
			paras[4] = new SqlParameter("@Picture", SqlDbType.Image);
			paras[4].Value = entity.Picture;
			paras[5] = new SqlParameter("@RowVersion", SqlDbType.Timestamp);
			paras[5].Value = entity.RowVersion;
			paras[6] = new SqlParameter("@CreatedOn", SqlDbType.DateTime);
			paras[6].Value = entity.CreatedOn;
			paras[7] = new SqlParameter("@CreatedBy", SqlDbType.VarChar, 30);
			paras[7].Value = entity.CreatedBy;
			paras[8] = new SqlParameter("@ModifiedOn", SqlDbType.DateTime);
			paras[8].Value = entity.ModifiedOn;
			paras[9] = new SqlParameter("@ModifiedBy", SqlDbType.VarChar, 30);
			paras[9].Value = entity.ModifiedBy;
			return base.ExecuteNonQuery(sql, paras);
		}

		private UtilSettingDetailData CreateDataByReader(SafeDataReader reader)
		{
			UtilSettingDetailData data = new UtilSettingDetailData {
				UtilSettingDetailPK = (Guid) reader["UtilSettingDetailPK"],
				UtilSettingCategoryPK = (Guid) reader["UtilSettingCategoryPK"],
				FieldName = (String) reader["FieldName"],
				FieldValue = (String) reader["FieldValue"],
				Picture = (Byte[]) reader["Picture"],
				RowVersion = (Byte[]) reader["RowVersion"],
				CreatedOn = (DateTime) reader["CreatedOn"],
				CreatedBy = (String) reader["CreatedBy"],
				ModifiedOn = (DateTime) reader["ModifiedOn"],
				ModifiedBy = (String) reader["ModifiedBy"],
				SettingCategory = (String) reader["SettingCategory"],
				SettingCategoryID = (Int32) reader["SettingCategoryID"]
			};
			data.AcceptChanges();
			return data;
		}

		private UtilSettingDetailData FetchEntity(string where, SqlParameter[] paras)
		{
			UtilSettingDetailData data = null;
			using (SafeDataReader reader = base.ExecuteDataReader(where, paras))
			{
				if (reader.Read())
				{
					data = this.CreateDataByReader(reader);
				}
				reader.Close();
			}
			return data;
		}

		private UtilSettingDetailData FetchEntityEx(string sql, SqlParameter[] paras)
		{
			UtilSettingDetailData data = null;
			using (SafeDataReader reader = base.ExecuteDataReaderEx(sql, paras))
			{
				if (reader.Read())
				{
					data = this.CreateDataByReader(reader);
				}
				reader.Close();
			}
			return data;
		}

		private UtilSettingDetailDataCollection FetchCollection(string where, SqlParameter[] paras)
		{
			UtilSettingDetailDataCollection list = new UtilSettingDetailDataCollection();
			using (SafeDataReader reader = base.ExecuteDataReader(where, paras))
			{
				while(reader.Read())
				{
					UtilSettingDetailData data = this.CreateDataByReader(reader);
					list.Add(data);
				}
				reader.Close();
			}
			return list;
		}

		private UtilSettingDetailDataCollection FetchCollectionEx(string sql, SqlParameter[] paras)
		{
			UtilSettingDetailDataCollection list = new UtilSettingDetailDataCollection();
			using (SafeDataReader reader = base.ExecuteDataReaderEx(sql, paras))
			{
				while(reader.Read())
				{
					UtilSettingDetailData data = this.CreateDataByReader(reader);
					list.Add(data);
				}
				reader.Close();
			}
			return list;
		}

		public UtilSettingDetailData GetEntityBy(string sqlWhere, SqlParameter[] paras)
		{
			return this.FetchEntity(sqlWhere, paras);
		}

		public UtilSettingDetailData GetEntityExBy(string sql, SqlParameter[] paras)
		{
			return this.FetchEntityEx(sql, paras);
		}

		public UtilSettingDetailDataCollection GetCollectionBy(string sqlWhere, SqlParameter[] paras)
		{
			return this.FetchCollection(sqlWhere, paras);
		}

		public UtilSettingDetailDataCollection GetCollectionExBy(string sql, SqlParameter[] paras)
		{
			return this.FetchCollectionEx(sql, paras);
		}

		public byte[] GetRowVersion( System.Guid UtilSettingDetailPK)
		{
			string sql = string.Format("SELECT [RowVersion] AS [RowVersion] FROM [{0}] WHERE  [UtilSettingDetailPK] = @UtilSettingDetailPK ", this.TableName);
			SqlParameter[] paras = new SqlParameter[1];
			paras[0] = new SqlParameter("@UtilSettingDetailPK", SqlDbType.UniqueIdentifier, 16);
			paras[0].Value = UtilSettingDetailPK;
			return (byte[]) base.ExecuteScalar(sql, paras);
		}

		public UtilSettingDetailData GetByPK( System.Guid UtilSettingDetailPK)
		{
			string sql = " WHERE  [UtilSettingDetail].[UtilSettingDetailPK] = @UtilSettingDetailPK ";
			SqlParameter[] paras = new SqlParameter[1];
			paras[0] = new SqlParameter("@UtilSettingDetailPK", SqlDbType.UniqueIdentifier);
			paras[0].Value = UtilSettingDetailPK;
			return this.FetchEntity(sql, paras);
		}

		public UtilSettingDetailDataCollection GetAll()
		{
			return this.FetchCollection("", null);
		}

		public UtilSettingDetailDataCollection GetByUtilSettingCategory(System.Guid UtilSettingCategoryPK)
		{
			string sqlWhere = " WHERE [UtilSettingDetail].[UtilSettingCategoryPK] = @UtilSettingCategoryPK";
			SqlParameter[] paras = new SqlParameter[1];
			paras[0] = new SqlParameter("@UtilSettingCategoryPK", SqlDbType.UniqueIdentifier);
			paras[0].Value = UtilSettingCategoryPK;
			return this.FetchCollection(sqlWhere, paras);
		}

		public DataTable GetLogByPK( System.Guid UtilSettingDetailPK)
		{
			string sql = string.Format("SELECT  [UtilSettingDetail].[UtilSettingDetailPK] AS [UtilSettingDetailPK], [UtilSettingDetail].[ModifiedOn] AS [ModifiedOn] FROM [{0}] WHERE  [UtilSettingDetail].[UtilSettingDetailPK] = @UtilSettingDetailPK ", this.TableName);
			SqlParameter[] paras = new SqlParameter[1];
			paras[0] = new SqlParameter("@UtilSettingDetailPK", SqlDbType.UniqueIdentifier);
			paras[0].Value = UtilSettingDetailPK;
			return this.ExecuteDataTable(sql, paras);
		}

		public DataTable GetLogByUtilSettingCategory(System.Guid utilSettingCategoryPK)
		{
			string sql = string.Format("DELETE [{0}] FROM [{0}] [UtilSettingDetail] INNER JOIN [UtilSettingCategory] ON [UtilSettingDetail].[UtilSettingCategoryPK] = [UtilSettingCategory].[UtilSettingCategoryPK] WHERE [UtilSettingCategory].[UtilSettingCategoryPK] = @UtilSettingCategoryPK;", this.TableName);
			string oldValue = string.Format("DELETE [{0}]", this.TableName);
			string newValue = "SELECT  [UtilSettingDetail].[UtilSettingDetailPK] AS [UtilSettingDetailPK], [UtilSettingDetail].[ModifiedOn] AS [ModifiedOn]";
			sql = sql.Replace(oldValue, newValue).TrimEnd().TrimEnd(';').Replace(";", " UNION ");
			SqlParameter[] paras = new SqlParameter[1];
			paras[0] = new SqlParameter("@UtilSettingCategoryPK", SqlDbType.UniqueIdentifier);
			paras[0].Value = utilSettingCategoryPK;
			return base.ExecuteDataTable(sql, paras);
		}

		public int DeleteByPK( System.Guid UtilSettingDetailPK, byte[] RowVersion)
		{
			string sql = string.Format("DELETE FROM [{0}] WHERE  [UtilSettingDetailPK] = @UtilSettingDetailPK AND [RowVersion] = @RowVersion", this.TableName);
			SqlParameter[] paras = new SqlParameter[2];
			paras[0] = new SqlParameter("@UtilSettingDetailPK", SqlDbType.UniqueIdentifier);
			paras[0].Value = UtilSettingDetailPK;
			paras[1] = new SqlParameter("@RowVersion", SqlDbType.Timestamp, 8);
			paras[1].Value = RowVersion;
			return base.ExecuteNonQuery(sql, paras);
		}

		public int DeleteAll()
		{
			string sql = string.Format("DELETE FROM [{0}]", this.TableName);
			return base.ExecuteNonQuery(sql, null);
		}

		public int DeleteByUtilSettingCategory(System.Guid utilSettingCategoryPK)
		{
			string sql = string.Format("DELETE [{0}] FROM [{0}] [UtilSettingDetail] INNER JOIN [UtilSettingCategory] ON [UtilSettingDetail].[UtilSettingCategoryPK] = [UtilSettingCategory].[UtilSettingCategoryPK] WHERE [UtilSettingCategory].[UtilSettingCategoryPK] = @UtilSettingCategoryPK;", this.TableName);
			SqlParameter[] paras = new SqlParameter[1];
			paras[0] = new SqlParameter("@UtilSettingCategoryPK", SqlDbType.UniqueIdentifier);
			paras[0].Value = utilSettingCategoryPK;
			return base.ExecuteNonQuery(sql, paras);
		}


	}
	public class ACOutputGroupMainZoneMapCRUD : DataAccessBase
	{
		private string _tableName = "ACOutputGroupMainZoneMap";

		public ACOutputGroupMainZoneMapCRUD(string connectionString) : base(connectionString)
		{
		}

		public virtual string TableName
		{
			get { return this._tableName; }
			set { this._tableName = value; }
		}

		public string SQLColumns
		{
			get
			{
				return "[ACOutputGroupMainZoneMap].[ACOutputGroupMainZoneMapPK] AS [ACOutputGroupMainZoneMapPK],[ACOutputGroupMainZoneMap].[ACOutputGroupPK] AS [ACOutputGroupPK],[ACOutputGroupMainZoneMap].[ACMainZonePK] AS [ACMainZonePK],[ACOutputGroupMainZoneMap].[RowVersion] AS [RowVersion],[ACOutputGroupMainZoneMap].[CreatedOn] AS [CreatedOn],[ACOutputGroupMainZoneMap].[CreatedBy] AS [CreatedBy],[ACOutputGroupMainZoneMap].[ModifiedOn] AS [ModifiedOn],[ACOutputGroupMainZoneMap].[ModifiedBy] AS [ModifiedBy],[ACMainZone].[MainZoneID] AS [MainZoneID],[ACMainZone].[ACPanelPK] AS [ACPanelPK],[ACOutputGroup].[GroupID] AS [GroupID],[ACPanel].[UnitID] AS [UnitID],[BDBuilding].[Address1] AS [Address1],[BDBuilding].[BuildingID] AS [BuildingID],[BDBuilding].[BDBuildingPK] AS [BDBuildingPK]";
			}
		}

		public string SQLLeftJoins
		{
			get
			{
				return "LEFT JOIN [ACMainZone] [ACMainZone] ON [ACOutputGroupMainZoneMap].[ACMainZonePK] = [ACMainZone].[ACMainZonePK] LEFT JOIN [ACOutputGroup] [ACOutputGroup] ON [ACOutputGroupMainZoneMap].[ACOutputGroupPK] = [ACOutputGroup].[ACOutputGroupPK] LEFT JOIN [ACPanel] [ACPanel] ON [ACMainZone].[ACPanelPK] = [ACPanel].[ACPanelPK] LEFT JOIN [BDBuilding] [BDBuilding] ON [ACPanel].[BDBuildingPK] = [BDBuilding].[BDBuildingPK]";
			}
		}

		protected override string SQLSelect
		{
			get
			{
				return string.Format("SELECT [ACOutputGroupMainZoneMap].[ACOutputGroupMainZoneMapPK] AS [ACOutputGroupMainZoneMapPK],[ACOutputGroupMainZoneMap].[ACOutputGroupPK] AS [ACOutputGroupPK],[ACOutputGroupMainZoneMap].[ACMainZonePK] AS [ACMainZonePK],[ACOutputGroupMainZoneMap].[RowVersion] AS [RowVersion],[ACOutputGroupMainZoneMap].[CreatedOn] AS [CreatedOn],[ACOutputGroupMainZoneMap].[CreatedBy] AS [CreatedBy],[ACOutputGroupMainZoneMap].[ModifiedOn] AS [ModifiedOn],[ACOutputGroupMainZoneMap].[ModifiedBy] AS [ModifiedBy],[ACMainZone].[MainZoneID] AS [MainZoneID],[ACMainZone].[ACPanelPK] AS [ACPanelPK],[ACOutputGroup].[GroupID] AS [GroupID],[ACPanel].[UnitID] AS [UnitID],[BDBuilding].[Address1] AS [Address1],[BDBuilding].[BuildingID] AS [BuildingID],[BDBuilding].[BDBuildingPK] AS [BDBuildingPK] FROM [{0}] [ACOutputGroupMainZoneMap] LEFT JOIN [ACMainZone] [ACMainZone] ON [ACOutputGroupMainZoneMap].[ACMainZonePK] = [ACMainZone].[ACMainZonePK] LEFT JOIN [ACOutputGroup] [ACOutputGroup] ON [ACOutputGroupMainZoneMap].[ACOutputGroupPK] = [ACOutputGroup].[ACOutputGroupPK] LEFT JOIN [ACPanel] [ACPanel] ON [ACMainZone].[ACPanelPK] = [ACPanel].[ACPanelPK] LEFT JOIN [BDBuilding] [BDBuilding] ON [ACPanel].[BDBuildingPK] = [BDBuilding].[BDBuildingPK]", this.TableName);
			}
		}

		protected override string SQLCount
		{
			get
			{
				return string.Format("SELECT COUNT(*) FROM [{0}] [ACOutputGroupMainZoneMap] LEFT JOIN [ACMainZone] [ACMainZone] ON [ACOutputGroupMainZoneMap].[ACMainZonePK] = [ACMainZone].[ACMainZonePK] LEFT JOIN [ACOutputGroup] [ACOutputGroup] ON [ACOutputGroupMainZoneMap].[ACOutputGroupPK] = [ACOutputGroup].[ACOutputGroupPK] LEFT JOIN [ACPanel] [ACPanel] ON [ACMainZone].[ACPanelPK] = [ACPanel].[ACPanelPK] LEFT JOIN [BDBuilding] [BDBuilding] ON [ACPanel].[BDBuildingPK] = [BDBuilding].[BDBuildingPK]", this.TableName);
			}
		}

		public int Insert(ACOutputGroupMainZoneMapData entity)
		{
			string sql = string.Format("INSERT INTO [{0}] ([ACOutputGroupMainZoneMapPK],[ACOutputGroupPK],[ACMainZonePK],[CreatedOn],[CreatedBy],[ModifiedOn],[ModifiedBy]) VALUES(@ACOutputGroupMainZoneMapPK,@ACOutputGroupPK,@ACMainZonePK,@CreatedOn,@CreatedBy,@ModifiedOn,@ModifiedBy)", this.TableName);
			SqlParameter[] paras = new SqlParameter[7];
			paras[0] = new SqlParameter("@ACOutputGroupMainZoneMapPK", SqlDbType.UniqueIdentifier);
			if (entity.ACOutputGroupMainZoneMapPK == Guid.Empty)
			{
				paras[0].Value = DBNull.Value;
			}
			else
			{
				paras[0].Value = entity.ACOutputGroupMainZoneMapPK;
			}
			paras[1] = new SqlParameter("@ACOutputGroupPK", SqlDbType.UniqueIdentifier);
			if (entity.ACOutputGroupPK == Guid.Empty)
			{
				paras[1].Value = DBNull.Value;
			}
			else
			{
				paras[1].Value = entity.ACOutputGroupPK;
			}
			paras[2] = new SqlParameter("@ACMainZonePK", SqlDbType.UniqueIdentifier);
			if (entity.ACMainZonePK == Guid.Empty)
			{
				paras[2].Value = DBNull.Value;
			}
			else
			{
				paras[2].Value = entity.ACMainZonePK;
			}
			paras[3] = new SqlParameter("@CreatedOn", SqlDbType.DateTime);
			paras[3].Value = entity.CreatedOn;
			paras[4] = new SqlParameter("@CreatedBy", SqlDbType.VarChar, 30);
			paras[4].Value = entity.CreatedBy;
			paras[5] = new SqlParameter("@ModifiedOn", SqlDbType.DateTime);
			paras[5].Value = entity.ModifiedOn;
			paras[6] = new SqlParameter("@ModifiedBy", SqlDbType.VarChar, 30);
			paras[6].Value = entity.ModifiedBy;
			return base.ExecuteNonQuery(sql, paras);
		}

		public int Update(ACOutputGroupMainZoneMapData entity)
		{
			string sql = string.Format("UPDATE [{0}] SET [ACOutputGroupPK] = @ACOutputGroupPK,[ACMainZonePK] = @ACMainZonePK,[CreatedOn] = @CreatedOn,[CreatedBy] = @CreatedBy,[ModifiedOn] = @ModifiedOn,[ModifiedBy] = @ModifiedBy  WHERE [ACOutputGroupMainZoneMapPK] = @ACOutputGroupMainZoneMapPK AND [RowVersion] = @RowVersion", this.TableName);
			SqlParameter[] paras = new SqlParameter[8];
			paras[0] = new SqlParameter("@ACOutputGroupMainZoneMapPK", SqlDbType.UniqueIdentifier);
			if (entity.ACOutputGroupMainZoneMapPK == Guid.Empty)
			{
				paras[0].Value = DBNull.Value;
			}
			else
			{
				paras[0].Value = entity.ACOutputGroupMainZoneMapPK;
			}
			paras[1] = new SqlParameter("@ACOutputGroupPK", SqlDbType.UniqueIdentifier);
			if (entity.ACOutputGroupPK == Guid.Empty)
			{
				paras[1].Value = DBNull.Value;
			}
			else
			{
				paras[1].Value = entity.ACOutputGroupPK;
			}
			paras[2] = new SqlParameter("@ACMainZonePK", SqlDbType.UniqueIdentifier);
			if (entity.ACMainZonePK == Guid.Empty)
			{
				paras[2].Value = DBNull.Value;
			}
			else
			{
				paras[2].Value = entity.ACMainZonePK;
			}
			paras[3] = new SqlParameter("@RowVersion", SqlDbType.Timestamp);
			paras[3].Value = entity.RowVersion;
			paras[4] = new SqlParameter("@CreatedOn", SqlDbType.DateTime);
			paras[4].Value = entity.CreatedOn;
			paras[5] = new SqlParameter("@CreatedBy", SqlDbType.VarChar, 30);
			paras[5].Value = entity.CreatedBy;
			paras[6] = new SqlParameter("@ModifiedOn", SqlDbType.DateTime);
			paras[6].Value = entity.ModifiedOn;
			paras[7] = new SqlParameter("@ModifiedBy", SqlDbType.VarChar, 30);
			paras[7].Value = entity.ModifiedBy;
			return base.ExecuteNonQuery(sql, paras);
		}

		private ACOutputGroupMainZoneMapData CreateDataByReader(SafeDataReader reader)
		{
			ACOutputGroupMainZoneMapData data = new ACOutputGroupMainZoneMapData {
				ACOutputGroupMainZoneMapPK = (Guid) reader["ACOutputGroupMainZoneMapPK"],
				ACOutputGroupPK = (Guid) reader["ACOutputGroupPK"],
				ACMainZonePK = (Guid) reader["ACMainZonePK"],
				RowVersion = (Byte[]) reader["RowVersion"],
				CreatedOn = (DateTime) reader["CreatedOn"],
				CreatedBy = (String) reader["CreatedBy"],
				ModifiedOn = (DateTime) reader["ModifiedOn"],
				ModifiedBy = (String) reader["ModifiedBy"],
				MainZoneID = (Byte) reader["MainZoneID"],
				ACPanelPK = (Guid) reader["ACPanelPK"],
				GroupID = (Byte) reader["GroupID"],
				UnitID = (Int32) reader["UnitID"],
				Address1 = (String) reader["Address1"],
				BuildingID = (Int32) reader["BuildingID"],
				BDBuildingPK = (Guid) reader["BDBuildingPK"]
			};
			data.AcceptChanges();
			return data;
		}

		private ACOutputGroupMainZoneMapData FetchEntity(string where, SqlParameter[] paras)
		{
			ACOutputGroupMainZoneMapData data = null;
			using (SafeDataReader reader = base.ExecuteDataReader(where, paras))
			{
				if (reader.Read())
				{
					data = this.CreateDataByReader(reader);
				}
				reader.Close();
			}
			return data;
		}

		private ACOutputGroupMainZoneMapData FetchEntityEx(string sql, SqlParameter[] paras)
		{
			ACOutputGroupMainZoneMapData data = null;
			using (SafeDataReader reader = base.ExecuteDataReaderEx(sql, paras))
			{
				if (reader.Read())
				{
					data = this.CreateDataByReader(reader);
				}
				reader.Close();
			}
			return data;
		}

		private ACOutputGroupMainZoneMapDataCollection FetchCollection(string where, SqlParameter[] paras)
		{
			ACOutputGroupMainZoneMapDataCollection list = new ACOutputGroupMainZoneMapDataCollection();
			using (SafeDataReader reader = base.ExecuteDataReader(where, paras))
			{
				while(reader.Read())
				{
					ACOutputGroupMainZoneMapData data = this.CreateDataByReader(reader);
					list.Add(data);
				}
				reader.Close();
			}
			return list;
		}

		private ACOutputGroupMainZoneMapDataCollection FetchCollectionEx(string sql, SqlParameter[] paras)
		{
			ACOutputGroupMainZoneMapDataCollection list = new ACOutputGroupMainZoneMapDataCollection();
			using (SafeDataReader reader = base.ExecuteDataReaderEx(sql, paras))
			{
				while(reader.Read())
				{
					ACOutputGroupMainZoneMapData data = this.CreateDataByReader(reader);
					list.Add(data);
				}
				reader.Close();
			}
			return list;
		}

		public ACOutputGroupMainZoneMapData GetEntityBy(string sqlWhere, SqlParameter[] paras)
		{
			return this.FetchEntity(sqlWhere, paras);
		}

		public ACOutputGroupMainZoneMapData GetEntityExBy(string sql, SqlParameter[] paras)
		{
			return this.FetchEntityEx(sql, paras);
		}

		public ACOutputGroupMainZoneMapDataCollection GetCollectionBy(string sqlWhere, SqlParameter[] paras)
		{
			return this.FetchCollection(sqlWhere, paras);
		}

		public ACOutputGroupMainZoneMapDataCollection GetCollectionExBy(string sql, SqlParameter[] paras)
		{
			return this.FetchCollectionEx(sql, paras);
		}

		public byte[] GetRowVersion( System.Guid ACOutputGroupMainZoneMapPK)
		{
			string sql = string.Format("SELECT [RowVersion] AS [RowVersion] FROM [{0}] WHERE  [ACOutputGroupMainZoneMapPK] = @ACOutputGroupMainZoneMapPK ", this.TableName);
			SqlParameter[] paras = new SqlParameter[1];
			paras[0] = new SqlParameter("@ACOutputGroupMainZoneMapPK", SqlDbType.UniqueIdentifier, 16);
			paras[0].Value = ACOutputGroupMainZoneMapPK;
			return (byte[]) base.ExecuteScalar(sql, paras);
		}

		public ACOutputGroupMainZoneMapData GetByPK( System.Guid ACOutputGroupMainZoneMapPK)
		{
			string sql = " WHERE  [ACOutputGroupMainZoneMap].[ACOutputGroupMainZoneMapPK] = @ACOutputGroupMainZoneMapPK ";
			SqlParameter[] paras = new SqlParameter[1];
			paras[0] = new SqlParameter("@ACOutputGroupMainZoneMapPK", SqlDbType.UniqueIdentifier);
			paras[0].Value = ACOutputGroupMainZoneMapPK;
			return this.FetchEntity(sql, paras);
		}

		public ACOutputGroupMainZoneMapDataCollection GetAll()
		{
			return this.FetchCollection("", null);
		}

		public ACOutputGroupMainZoneMapDataCollection GetByACMainZone(System.Guid ACMainZonePK)
		{
			string sqlWhere = " WHERE [ACOutputGroupMainZoneMap].[ACMainZonePK] = @ACMainZonePK";
			SqlParameter[] paras = new SqlParameter[1];
			paras[0] = new SqlParameter("@ACMainZonePK", SqlDbType.UniqueIdentifier);
			paras[0].Value = ACMainZonePK;
			return this.FetchCollection(sqlWhere, paras);
		}

		public ACOutputGroupMainZoneMapDataCollection GetByACOutputGroup(System.Guid ACOutputGroupPK)
		{
			string sqlWhere = " WHERE [ACOutputGroupMainZoneMap].[ACOutputGroupPK] = @ACOutputGroupPK";
			SqlParameter[] paras = new SqlParameter[1];
			paras[0] = new SqlParameter("@ACOutputGroupPK", SqlDbType.UniqueIdentifier);
			paras[0].Value = ACOutputGroupPK;
			return this.FetchCollection(sqlWhere, paras);
		}

		public DataTable GetLogByPK( System.Guid ACOutputGroupMainZoneMapPK)
		{
			string sql = string.Format("SELECT  [ACOutputGroupMainZoneMap].[ACOutputGroupMainZoneMapPK] AS [ACOutputGroupMainZoneMapPK], [ACOutputGroupMainZoneMap].[ModifiedOn] AS [ModifiedOn] FROM [{0}] WHERE  [ACOutputGroupMainZoneMap].[ACOutputGroupMainZoneMapPK] = @ACOutputGroupMainZoneMapPK ", this.TableName);
			SqlParameter[] paras = new SqlParameter[1];
			paras[0] = new SqlParameter("@ACOutputGroupMainZoneMapPK", SqlDbType.UniqueIdentifier);
			paras[0].Value = ACOutputGroupMainZoneMapPK;
			return this.ExecuteDataTable(sql, paras);
		}

		public DataTable GetLogByACMainZone(System.Guid aCMainZonePK)
		{
			string sql = string.Format("DELETE [{0}] FROM [{0}] [ACOutputGroupMainZoneMap] INNER JOIN [ACMainZone] ON [ACOutputGroupMainZoneMap].[ACMainZonePK] = [ACMainZone].[ACMainZonePK] WHERE [ACMainZone].[ACMainZonePK] = @ACMainZonePK;", this.TableName);
			string oldValue = string.Format("DELETE [{0}]", this.TableName);
			string newValue = "SELECT  [ACOutputGroupMainZoneMap].[ACOutputGroupMainZoneMapPK] AS [ACOutputGroupMainZoneMapPK], [ACOutputGroupMainZoneMap].[ModifiedOn] AS [ModifiedOn]";
			sql = sql.Replace(oldValue, newValue).TrimEnd().TrimEnd(';').Replace(";", " UNION ");
			SqlParameter[] paras = new SqlParameter[1];
			paras[0] = new SqlParameter("@ACMainZonePK", SqlDbType.UniqueIdentifier);
			paras[0].Value = aCMainZonePK;
			return base.ExecuteDataTable(sql, paras);
		}

		public DataTable GetLogByACPanel(System.Guid aCPanelPK)
		{
			string sql = string.Format("DELETE [{0}] FROM [{0}] [ACOutputGroupMainZoneMap] INNER JOIN [ACMainZone] ON [ACOutputGroupMainZoneMap].[ACMainZonePK] = [ACMainZone].[ACMainZonePK] INNER JOIN [ACPanel] ON [ACMainZone].[ACPanelPK] = [ACPanel].[ACPanelPK] WHERE [ACPanel].[ACPanelPK] = @ACPanelPK;DELETE [{0}] FROM [{0}] [ACOutputGroupMainZoneMap] INNER JOIN [ACOutputGroup] ON [ACOutputGroupMainZoneMap].[ACOutputGroupPK] = [ACOutputGroup].[ACOutputGroupPK] INNER JOIN [ACPanel] ON [ACOutputGroup].[ACPanelPK] = [ACPanel].[ACPanelPK] WHERE [ACPanel].[ACPanelPK] = @ACPanelPK;", this.TableName);
			string oldValue = string.Format("DELETE [{0}]", this.TableName);
			string newValue = "SELECT  [ACOutputGroupMainZoneMap].[ACOutputGroupMainZoneMapPK] AS [ACOutputGroupMainZoneMapPK], [ACOutputGroupMainZoneMap].[ModifiedOn] AS [ModifiedOn]";
			sql = sql.Replace(oldValue, newValue).TrimEnd().TrimEnd(';').Replace(";", " UNION ");
			SqlParameter[] paras = new SqlParameter[1];
			paras[0] = new SqlParameter("@ACPanelPK", SqlDbType.UniqueIdentifier);
			paras[0].Value = aCPanelPK;
			return base.ExecuteDataTable(sql, paras);
		}

		public DataTable GetLogByBDBuilding(System.Guid bDBuildingPK)
		{
			string sql = string.Format("DELETE [{0}] FROM [{0}] [ACOutputGroupMainZoneMap] INNER JOIN [ACMainZone] ON [ACOutputGroupMainZoneMap].[ACMainZonePK] = [ACMainZone].[ACMainZonePK] INNER JOIN [ACPanel] ON [ACMainZone].[ACPanelPK] = [ACPanel].[ACPanelPK] INNER JOIN [BDBuilding] ON [ACPanel].[BDBuildingPK] = [BDBuilding].[BDBuildingPK] WHERE [BDBuilding].[BDBuildingPK] = @BDBuildingPK;DELETE [{0}] FROM [{0}] [ACOutputGroupMainZoneMap] INNER JOIN [ACOutputGroup] ON [ACOutputGroupMainZoneMap].[ACOutputGroupPK] = [ACOutputGroup].[ACOutputGroupPK] INNER JOIN [ACPanel] ON [ACOutputGroup].[ACPanelPK] = [ACPanel].[ACPanelPK] INNER JOIN [BDBuilding] ON [ACPanel].[BDBuildingPK] = [BDBuilding].[BDBuildingPK] WHERE [BDBuilding].[BDBuildingPK] = @BDBuildingPK;", this.TableName);
			string oldValue = string.Format("DELETE [{0}]", this.TableName);
			string newValue = "SELECT  [ACOutputGroupMainZoneMap].[ACOutputGroupMainZoneMapPK] AS [ACOutputGroupMainZoneMapPK], [ACOutputGroupMainZoneMap].[ModifiedOn] AS [ModifiedOn]";
			sql = sql.Replace(oldValue, newValue).TrimEnd().TrimEnd(';').Replace(";", " UNION ");
			SqlParameter[] paras = new SqlParameter[1];
			paras[0] = new SqlParameter("@BDBuildingPK", SqlDbType.UniqueIdentifier);
			paras[0].Value = bDBuildingPK;
			return base.ExecuteDataTable(sql, paras);
		}

		public DataTable GetLogByACOutputGroup(System.Guid aCOutputGroupPK)
		{
			string sql = string.Format("DELETE [{0}] FROM [{0}] [ACOutputGroupMainZoneMap] INNER JOIN [ACOutputGroup] ON [ACOutputGroupMainZoneMap].[ACOutputGroupPK] = [ACOutputGroup].[ACOutputGroupPK] WHERE [ACOutputGroup].[ACOutputGroupPK] = @ACOutputGroupPK;", this.TableName);
			string oldValue = string.Format("DELETE [{0}]", this.TableName);
			string newValue = "SELECT  [ACOutputGroupMainZoneMap].[ACOutputGroupMainZoneMapPK] AS [ACOutputGroupMainZoneMapPK], [ACOutputGroupMainZoneMap].[ModifiedOn] AS [ModifiedOn]";
			sql = sql.Replace(oldValue, newValue).TrimEnd().TrimEnd(';').Replace(";", " UNION ");
			SqlParameter[] paras = new SqlParameter[1];
			paras[0] = new SqlParameter("@ACOutputGroupPK", SqlDbType.UniqueIdentifier);
			paras[0].Value = aCOutputGroupPK;
			return base.ExecuteDataTable(sql, paras);
		}

		public int DeleteByPK( System.Guid ACOutputGroupMainZoneMapPK, byte[] RowVersion)
		{
			string sql = string.Format("DELETE FROM [{0}] WHERE  [ACOutputGroupMainZoneMapPK] = @ACOutputGroupMainZoneMapPK AND [RowVersion] = @RowVersion", this.TableName);
			SqlParameter[] paras = new SqlParameter[2];
			paras[0] = new SqlParameter("@ACOutputGroupMainZoneMapPK", SqlDbType.UniqueIdentifier);
			paras[0].Value = ACOutputGroupMainZoneMapPK;
			paras[1] = new SqlParameter("@RowVersion", SqlDbType.Timestamp, 8);
			paras[1].Value = RowVersion;
			return base.ExecuteNonQuery(sql, paras);
		}

		public int DeleteAll()
		{
			string sql = string.Format("DELETE FROM [{0}]", this.TableName);
			return base.ExecuteNonQuery(sql, null);
		}

		public int DeleteByACMainZone(System.Guid aCMainZonePK)
		{
			string sql = string.Format("DELETE [{0}] FROM [{0}] [ACOutputGroupMainZoneMap] INNER JOIN [ACMainZone] ON [ACOutputGroupMainZoneMap].[ACMainZonePK] = [ACMainZone].[ACMainZonePK] WHERE [ACMainZone].[ACMainZonePK] = @ACMainZonePK;", this.TableName);
			SqlParameter[] paras = new SqlParameter[1];
			paras[0] = new SqlParameter("@ACMainZonePK", SqlDbType.UniqueIdentifier);
			paras[0].Value = aCMainZonePK;
			return base.ExecuteNonQuery(sql, paras);
		}

		public int DeleteByACPanel(System.Guid aCPanelPK)
		{
			string sql = string.Format("DELETE [{0}] FROM [{0}] [ACOutputGroupMainZoneMap] INNER JOIN [ACMainZone] ON [ACOutputGroupMainZoneMap].[ACMainZonePK] = [ACMainZone].[ACMainZonePK] INNER JOIN [ACPanel] ON [ACMainZone].[ACPanelPK] = [ACPanel].[ACPanelPK] WHERE [ACPanel].[ACPanelPK] = @ACPanelPK;DELETE [{0}] FROM [{0}] [ACOutputGroupMainZoneMap] INNER JOIN [ACOutputGroup] ON [ACOutputGroupMainZoneMap].[ACOutputGroupPK] = [ACOutputGroup].[ACOutputGroupPK] INNER JOIN [ACPanel] ON [ACOutputGroup].[ACPanelPK] = [ACPanel].[ACPanelPK] WHERE [ACPanel].[ACPanelPK] = @ACPanelPK;", this.TableName);
			SqlParameter[] paras = new SqlParameter[1];
			paras[0] = new SqlParameter("@ACPanelPK", SqlDbType.UniqueIdentifier);
			paras[0].Value = aCPanelPK;
			return base.ExecuteNonQuery(sql, paras);
		}

		public int DeleteByBDBuilding(System.Guid bDBuildingPK)
		{
			string sql = string.Format("DELETE [{0}] FROM [{0}] [ACOutputGroupMainZoneMap] INNER JOIN [ACMainZone] ON [ACOutputGroupMainZoneMap].[ACMainZonePK] = [ACMainZone].[ACMainZonePK] INNER JOIN [ACPanel] ON [ACMainZone].[ACPanelPK] = [ACPanel].[ACPanelPK] INNER JOIN [BDBuilding] ON [ACPanel].[BDBuildingPK] = [BDBuilding].[BDBuildingPK] WHERE [BDBuilding].[BDBuildingPK] = @BDBuildingPK;DELETE [{0}] FROM [{0}] [ACOutputGroupMainZoneMap] INNER JOIN [ACOutputGroup] ON [ACOutputGroupMainZoneMap].[ACOutputGroupPK] = [ACOutputGroup].[ACOutputGroupPK] INNER JOIN [ACPanel] ON [ACOutputGroup].[ACPanelPK] = [ACPanel].[ACPanelPK] INNER JOIN [BDBuilding] ON [ACPanel].[BDBuildingPK] = [BDBuilding].[BDBuildingPK] WHERE [BDBuilding].[BDBuildingPK] = @BDBuildingPK;", this.TableName);
			SqlParameter[] paras = new SqlParameter[1];
			paras[0] = new SqlParameter("@BDBuildingPK", SqlDbType.UniqueIdentifier);
			paras[0].Value = bDBuildingPK;
			return base.ExecuteNonQuery(sql, paras);
		}

		public int DeleteByACOutputGroup(System.Guid aCOutputGroupPK)
		{
			string sql = string.Format("DELETE [{0}] FROM [{0}] [ACOutputGroupMainZoneMap] INNER JOIN [ACOutputGroup] ON [ACOutputGroupMainZoneMap].[ACOutputGroupPK] = [ACOutputGroup].[ACOutputGroupPK] WHERE [ACOutputGroup].[ACOutputGroupPK] = @ACOutputGroupPK;", this.TableName);
			SqlParameter[] paras = new SqlParameter[1];
			paras[0] = new SqlParameter("@ACOutputGroupPK", SqlDbType.UniqueIdentifier);
			paras[0].Value = aCOutputGroupPK;
			return base.ExecuteNonQuery(sql, paras);
		}


	}
	public class ACCardHolderCRUD : DataAccessBase
	{
		private string _tableName = "ACCardHolder";

		public ACCardHolderCRUD(string connectionString) : base(connectionString)
		{
		}

		public virtual string TableName
		{
			get { return this._tableName; }
			set { this._tableName = value; }
		}

		public string SQLColumns
		{
			get
			{
				return "[ACCardHolder].[ACCardHolderPK] AS [ACCardHolderPK],[ACCardHolder].[Sitecode] AS [Sitecode],[ACCardHolder].[Embossed] AS [Embossed],[ACCardHolder].[Encoded] AS [Encoded],[ACCardHolder].[CardTypeID] AS [CardTypeID],[ACCardHolder].[FirstName] AS [FirstName],[ACCardHolder].[LastName] AS [LastName],[ACCardHolder].[Photo] AS [Photo],[ACCardHolder].[ValidFrom] AS [ValidFrom],[ACCardHolder].[ValidThru] AS [ValidThru],[ACCardHolder].[FIPS] AS [FIPS],[ACCardHolder].[Pin] AS [Pin],[ACCardHolder].[BDTenantPK] AS [BDTenantPK],[ACCardHolder].[Notes] AS [Notes],[ACCardHolder].[EventNotifyEmail] AS [EventNotifyEmail],[ACCardHolder].[FireWarden] AS [FireWarden],[ACCardHolder].[CustInfo1] AS [CustInfo1],[ACCardHolder].[CustInfo2] AS [CustInfo2],[ACCardHolder].[CustInfo3] AS [CustInfo3],[ACCardHolder].[CustInfo4] AS [CustInfo4],[ACCardHolder].[CustInfo5] AS [CustInfo5],[ACCardHolder].[CustInfo6] AS [CustInfo6],[ACCardHolder].[CustInfo7] AS [CustInfo7],[ACCardHolder].[CustInfo8] AS [CustInfo8],[ACCardHolder].[RowVersion] AS [RowVersion],[ACCardHolder].[CreatedOn] AS [CreatedOn],[ACCardHolder].[CreatedBy] AS [CreatedBy],[ACCardHolder].[ModifiedOn] AS [ModifiedOn],[ACCardHolder].[ModifiedBy] AS [ModifiedBy],[BDTenant].[Suite] AS [Suite],[BDTenant].[Tenant] AS [Tenant],[BDTenant].[BDBuildingPK] AS [BDBuildingPK],[BDBuilding].[Address1] AS [Address1],[BDBuilding].[BuildingID] AS [BuildingID]";
			}
		}

		public string SQLLeftJoins
		{
			get
			{
				return "LEFT JOIN [BDTenant] [BDTenant] ON [ACCardHolder].[BDTenantPK] = [BDTenant].[BDTenantPK] LEFT JOIN [BDBuilding] [BDBuilding] ON [BDTenant].[BDBuildingPK] = [BDBuilding].[BDBuildingPK]";
			}
		}

		protected override string SQLSelect
		{
			get
			{
				return string.Format("SELECT [ACCardHolder].[ACCardHolderPK] AS [ACCardHolderPK],[ACCardHolder].[Sitecode] AS [Sitecode],[ACCardHolder].[Embossed] AS [Embossed],[ACCardHolder].[Encoded] AS [Encoded],[ACCardHolder].[CardTypeID] AS [CardTypeID],[ACCardHolder].[FirstName] AS [FirstName],[ACCardHolder].[LastName] AS [LastName],[ACCardHolder].[Photo] AS [Photo],[ACCardHolder].[ValidFrom] AS [ValidFrom],[ACCardHolder].[ValidThru] AS [ValidThru],[ACCardHolder].[FIPS] AS [FIPS],[ACCardHolder].[Pin] AS [Pin],[ACCardHolder].[BDTenantPK] AS [BDTenantPK],[ACCardHolder].[Notes] AS [Notes],[ACCardHolder].[EventNotifyEmail] AS [EventNotifyEmail],[ACCardHolder].[FireWarden] AS [FireWarden],[ACCardHolder].[CustInfo1] AS [CustInfo1],[ACCardHolder].[CustInfo2] AS [CustInfo2],[ACCardHolder].[CustInfo3] AS [CustInfo3],[ACCardHolder].[CustInfo4] AS [CustInfo4],[ACCardHolder].[CustInfo5] AS [CustInfo5],[ACCardHolder].[CustInfo6] AS [CustInfo6],[ACCardHolder].[CustInfo7] AS [CustInfo7],[ACCardHolder].[CustInfo8] AS [CustInfo8],[ACCardHolder].[RowVersion] AS [RowVersion],[ACCardHolder].[CreatedOn] AS [CreatedOn],[ACCardHolder].[CreatedBy] AS [CreatedBy],[ACCardHolder].[ModifiedOn] AS [ModifiedOn],[ACCardHolder].[ModifiedBy] AS [ModifiedBy],[BDTenant].[Suite] AS [Suite],[BDTenant].[Tenant] AS [Tenant],[BDTenant].[BDBuildingPK] AS [BDBuildingPK],[BDBuilding].[Address1] AS [Address1],[BDBuilding].[BuildingID] AS [BuildingID] FROM [{0}] [ACCardHolder] LEFT JOIN [BDTenant] [BDTenant] ON [ACCardHolder].[BDTenantPK] = [BDTenant].[BDTenantPK] LEFT JOIN [BDBuilding] [BDBuilding] ON [BDTenant].[BDBuildingPK] = [BDBuilding].[BDBuildingPK]", this.TableName);
			}
		}

		protected override string SQLCount
		{
			get
			{
				return string.Format("SELECT COUNT(*) FROM [{0}] [ACCardHolder] LEFT JOIN [BDTenant] [BDTenant] ON [ACCardHolder].[BDTenantPK] = [BDTenant].[BDTenantPK] LEFT JOIN [BDBuilding] [BDBuilding] ON [BDTenant].[BDBuildingPK] = [BDBuilding].[BDBuildingPK]", this.TableName);
			}
		}

		public int Insert(ACCardHolderData entity)
		{
			string sql = string.Format("INSERT INTO [{0}] ([ACCardHolderPK],[Sitecode],[Embossed],[Encoded],[CardTypeID],[FirstName],[LastName],[Photo],[ValidFrom],[ValidThru],[FIPS],[Pin],[BDTenantPK],[Notes],[EventNotifyEmail],[FireWarden],[CustInfo1],[CustInfo2],[CustInfo3],[CustInfo4],[CustInfo5],[CustInfo6],[CustInfo7],[CustInfo8],[CreatedOn],[CreatedBy],[ModifiedOn],[ModifiedBy]) VALUES(@ACCardHolderPK,@Sitecode,@Embossed,@Encoded,@CardTypeID,@FirstName,@LastName,@Photo,@ValidFrom,@ValidThru,@FIPS,@Pin,@BDTenantPK,@Notes,@EventNotifyEmail,@FireWarden,@CustInfo1,@CustInfo2,@CustInfo3,@CustInfo4,@CustInfo5,@CustInfo6,@CustInfo7,@CustInfo8,@CreatedOn,@CreatedBy,@ModifiedOn,@ModifiedBy)", this.TableName);
			SqlParameter[] paras = new SqlParameter[28];
			paras[0] = new SqlParameter("@ACCardHolderPK", SqlDbType.UniqueIdentifier);
			if (entity.ACCardHolderPK == Guid.Empty)
			{
				paras[0].Value = DBNull.Value;
			}
			else
			{
				paras[0].Value = entity.ACCardHolderPK;
			}
			paras[1] = new SqlParameter("@Sitecode", SqlDbType.Int);
			paras[1].Value = entity.Sitecode;
			paras[2] = new SqlParameter("@Embossed", SqlDbType.Int);
			paras[2].Value = entity.Embossed;
			paras[3] = new SqlParameter("@Encoded", SqlDbType.Int);
			paras[3].Value = entity.Encoded;
			paras[4] = new SqlParameter("@CardTypeID", SqlDbType.Int);
			paras[4].Value = entity.CardTypeID;
			paras[5] = new SqlParameter("@FirstName", SqlDbType.VarChar, 30);
			paras[5].Value = entity.FirstName;
			paras[6] = new SqlParameter("@LastName", SqlDbType.VarChar, 50);
			paras[6].Value = entity.LastName;
			paras[7] = new SqlParameter("@Photo", SqlDbType.Image);
			paras[7].Value = entity.Photo;
			paras[8] = new SqlParameter("@ValidFrom", SqlDbType.DateTime);
			paras[8].Value = entity.ValidFrom;
			paras[9] = new SqlParameter("@ValidThru", SqlDbType.DateTime);
			paras[9].Value = entity.ValidThru;
			paras[10] = new SqlParameter("@FIPS", SqlDbType.Bit);
			paras[10].Value = entity.FIPS;
			paras[11] = new SqlParameter("@Pin", SqlDbType.Int);
			paras[11].Value = entity.Pin;
			paras[12] = new SqlParameter("@BDTenantPK", SqlDbType.UniqueIdentifier);
			if (entity.BDTenantPK == Guid.Empty)
			{
				paras[12].Value = DBNull.Value;
			}
			else
			{
				paras[12].Value = entity.BDTenantPK;
			}
			paras[13] = new SqlParameter("@Notes", SqlDbType.VarChar, 2048);
			paras[13].Value = entity.Notes;
			paras[14] = new SqlParameter("@EventNotifyEmail", SqlDbType.VarChar, 1024);
			paras[14].Value = entity.EventNotifyEmail;
			paras[15] = new SqlParameter("@FireWarden", SqlDbType.Bit);
			paras[15].Value = entity.FireWarden;
			paras[16] = new SqlParameter("@CustInfo1", SqlDbType.VarChar, 50);
			paras[16].Value = entity.CustInfo1;
			paras[17] = new SqlParameter("@CustInfo2", SqlDbType.VarChar, 50);
			paras[17].Value = entity.CustInfo2;
			paras[18] = new SqlParameter("@CustInfo3", SqlDbType.VarChar, 50);
			paras[18].Value = entity.CustInfo3;
			paras[19] = new SqlParameter("@CustInfo4", SqlDbType.VarChar, 50);
			paras[19].Value = entity.CustInfo4;
			paras[20] = new SqlParameter("@CustInfo5", SqlDbType.VarChar, 50);
			paras[20].Value = entity.CustInfo5;
			paras[21] = new SqlParameter("@CustInfo6", SqlDbType.VarChar, 50);
			paras[21].Value = entity.CustInfo6;
			paras[22] = new SqlParameter("@CustInfo7", SqlDbType.VarChar, 50);
			paras[22].Value = entity.CustInfo7;
			paras[23] = new SqlParameter("@CustInfo8", SqlDbType.VarChar, 50);
			paras[23].Value = entity.CustInfo8;
			paras[24] = new SqlParameter("@CreatedOn", SqlDbType.DateTime);
			paras[24].Value = entity.CreatedOn;
			paras[25] = new SqlParameter("@CreatedBy", SqlDbType.VarChar, 30);
			paras[25].Value = entity.CreatedBy;
			paras[26] = new SqlParameter("@ModifiedOn", SqlDbType.DateTime);
			paras[26].Value = entity.ModifiedOn;
			paras[27] = new SqlParameter("@ModifiedBy", SqlDbType.VarChar, 30);
			paras[27].Value = entity.ModifiedBy;
			return base.ExecuteNonQuery(sql, paras);
		}

		public int Update(ACCardHolderData entity)
		{
			string sql = string.Format("UPDATE [{0}] SET [Sitecode] = @Sitecode,[Embossed] = @Embossed,[Encoded] = @Encoded,[CardTypeID] = @CardTypeID,[FirstName] = @FirstName,[LastName] = @LastName,[Photo] = @Photo,[ValidFrom] = @ValidFrom,[ValidThru] = @ValidThru,[FIPS] = @FIPS,[Pin] = @Pin,[BDTenantPK] = @BDTenantPK,[Notes] = @Notes,[EventNotifyEmail] = @EventNotifyEmail,[FireWarden] = @FireWarden,[CustInfo1] = @CustInfo1,[CustInfo2] = @CustInfo2,[CustInfo3] = @CustInfo3,[CustInfo4] = @CustInfo4,[CustInfo5] = @CustInfo5,[CustInfo6] = @CustInfo6,[CustInfo7] = @CustInfo7,[CustInfo8] = @CustInfo8,[CreatedOn] = @CreatedOn,[CreatedBy] = @CreatedBy,[ModifiedOn] = @ModifiedOn,[ModifiedBy] = @ModifiedBy  WHERE [ACCardHolderPK] = @ACCardHolderPK AND [RowVersion] = @RowVersion", this.TableName);
			SqlParameter[] paras = new SqlParameter[29];
			paras[0] = new SqlParameter("@ACCardHolderPK", SqlDbType.UniqueIdentifier);
			if (entity.ACCardHolderPK == Guid.Empty)
			{
				paras[0].Value = DBNull.Value;
			}
			else
			{
				paras[0].Value = entity.ACCardHolderPK;
			}
			paras[1] = new SqlParameter("@Sitecode", SqlDbType.Int);
			paras[1].Value = entity.Sitecode;
			paras[2] = new SqlParameter("@Embossed", SqlDbType.Int);
			paras[2].Value = entity.Embossed;
			paras[3] = new SqlParameter("@Encoded", SqlDbType.Int);
			paras[3].Value = entity.Encoded;
			paras[4] = new SqlParameter("@CardTypeID", SqlDbType.Int);
			paras[4].Value = entity.CardTypeID;
			paras[5] = new SqlParameter("@FirstName", SqlDbType.VarChar, 30);
			paras[5].Value = entity.FirstName;
			paras[6] = new SqlParameter("@LastName", SqlDbType.VarChar, 50);
			paras[6].Value = entity.LastName;
			paras[7] = new SqlParameter("@Photo", SqlDbType.Image);
			paras[7].Value = entity.Photo;
			paras[8] = new SqlParameter("@ValidFrom", SqlDbType.DateTime);
			paras[8].Value = entity.ValidFrom;
			paras[9] = new SqlParameter("@ValidThru", SqlDbType.DateTime);
			paras[9].Value = entity.ValidThru;
			paras[10] = new SqlParameter("@FIPS", SqlDbType.Bit);
			paras[10].Value = entity.FIPS;
			paras[11] = new SqlParameter("@Pin", SqlDbType.Int);
			paras[11].Value = entity.Pin;
			paras[12] = new SqlParameter("@BDTenantPK", SqlDbType.UniqueIdentifier);
			if (entity.BDTenantPK == Guid.Empty)
			{
				paras[12].Value = DBNull.Value;
			}
			else
			{
				paras[12].Value = entity.BDTenantPK;
			}
			paras[13] = new SqlParameter("@Notes", SqlDbType.VarChar, 2048);
			paras[13].Value = entity.Notes;
			paras[14] = new SqlParameter("@EventNotifyEmail", SqlDbType.VarChar, 1024);
			paras[14].Value = entity.EventNotifyEmail;
			paras[15] = new SqlParameter("@FireWarden", SqlDbType.Bit);
			paras[15].Value = entity.FireWarden;
			paras[16] = new SqlParameter("@CustInfo1", SqlDbType.VarChar, 50);
			paras[16].Value = entity.CustInfo1;
			paras[17] = new SqlParameter("@CustInfo2", SqlDbType.VarChar, 50);
			paras[17].Value = entity.CustInfo2;
			paras[18] = new SqlParameter("@CustInfo3", SqlDbType.VarChar, 50);
			paras[18].Value = entity.CustInfo3;
			paras[19] = new SqlParameter("@CustInfo4", SqlDbType.VarChar, 50);
			paras[19].Value = entity.CustInfo4;
			paras[20] = new SqlParameter("@CustInfo5", SqlDbType.VarChar, 50);
			paras[20].Value = entity.CustInfo5;
			paras[21] = new SqlParameter("@CustInfo6", SqlDbType.VarChar, 50);
			paras[21].Value = entity.CustInfo6;
			paras[22] = new SqlParameter("@CustInfo7", SqlDbType.VarChar, 50);
			paras[22].Value = entity.CustInfo7;
			paras[23] = new SqlParameter("@CustInfo8", SqlDbType.VarChar, 50);
			paras[23].Value = entity.CustInfo8;
			paras[24] = new SqlParameter("@RowVersion", SqlDbType.Timestamp);
			paras[24].Value = entity.RowVersion;
			paras[25] = new SqlParameter("@CreatedOn", SqlDbType.DateTime);
			paras[25].Value = entity.CreatedOn;
			paras[26] = new SqlParameter("@CreatedBy", SqlDbType.VarChar, 30);
			paras[26].Value = entity.CreatedBy;
			paras[27] = new SqlParameter("@ModifiedOn", SqlDbType.DateTime);
			paras[27].Value = entity.ModifiedOn;
			paras[28] = new SqlParameter("@ModifiedBy", SqlDbType.VarChar, 30);
			paras[28].Value = entity.ModifiedBy;
			return base.ExecuteNonQuery(sql, paras);
		}

		private ACCardHolderData CreateDataByReader(SafeDataReader reader)
		{
			ACCardHolderData data = new ACCardHolderData {
				ACCardHolderPK = (Guid) reader["ACCardHolderPK"],
				Sitecode = (Int32) reader["Sitecode"],
				Embossed = (Int32) reader["Embossed"],
				Encoded = (Int32) reader["Encoded"],
				CardTypeID = (Int32) reader["CardTypeID"],
				FirstName = (String) reader["FirstName"],
				LastName = (String) reader["LastName"],
				Photo = (Byte[]) reader["Photo"],
				ValidFrom = (DateTime) reader["ValidFrom"],
				ValidThru = (DateTime) reader["ValidThru"],
				FIPS = (Boolean) reader["FIPS"],
				Pin = (Int32) reader["Pin"],
				BDTenantPK = (Guid) reader["BDTenantPK"],
				Notes = (String) reader["Notes"],
				EventNotifyEmail = (String) reader["EventNotifyEmail"],
				FireWarden = (Boolean) reader["FireWarden"],
				CustInfo1 = (String) reader["CustInfo1"],
				CustInfo2 = (String) reader["CustInfo2"],
				CustInfo3 = (String) reader["CustInfo3"],
				CustInfo4 = (String) reader["CustInfo4"],
				CustInfo5 = (String) reader["CustInfo5"],
				CustInfo6 = (String) reader["CustInfo6"],
				CustInfo7 = (String) reader["CustInfo7"],
				CustInfo8 = (String) reader["CustInfo8"],
				RowVersion = (Byte[]) reader["RowVersion"],
				CreatedOn = (DateTime) reader["CreatedOn"],
				CreatedBy = (String) reader["CreatedBy"],
				ModifiedOn = (DateTime) reader["ModifiedOn"],
				ModifiedBy = (String) reader["ModifiedBy"],
				Suite = (String) reader["Suite"],
				Tenant = (String) reader["Tenant"],
				BDBuildingPK = (Guid) reader["BDBuildingPK"],
				Address1 = (String) reader["Address1"],
				BuildingID = (Int32) reader["BuildingID"]
			};
			data.AcceptChanges();
			return data;
		}

		private ACCardHolderData FetchEntity(string where, SqlParameter[] paras)
		{
			ACCardHolderData data = null;
			using (SafeDataReader reader = base.ExecuteDataReader(where, paras))
			{
				if (reader.Read())
				{
					data = this.CreateDataByReader(reader);
				}
				reader.Close();
			}
			return data;
		}

		private ACCardHolderData FetchEntityEx(string sql, SqlParameter[] paras)
		{
			ACCardHolderData data = null;
			using (SafeDataReader reader = base.ExecuteDataReaderEx(sql, paras))
			{
				if (reader.Read())
				{
					data = this.CreateDataByReader(reader);
				}
				reader.Close();
			}
			return data;
		}

		private ACCardHolderDataCollection FetchCollection(string where, SqlParameter[] paras)
		{
			ACCardHolderDataCollection list = new ACCardHolderDataCollection();
			using (SafeDataReader reader = base.ExecuteDataReader(where, paras))
			{
				while(reader.Read())
				{
					ACCardHolderData data = this.CreateDataByReader(reader);
					list.Add(data);
				}
				reader.Close();
			}
			return list;
		}

		private ACCardHolderDataCollection FetchCollectionEx(string sql, SqlParameter[] paras)
		{
			ACCardHolderDataCollection list = new ACCardHolderDataCollection();
			using (SafeDataReader reader = base.ExecuteDataReaderEx(sql, paras))
			{
				while(reader.Read())
				{
					ACCardHolderData data = this.CreateDataByReader(reader);
					list.Add(data);
				}
				reader.Close();
			}
			return list;
		}

		public ACCardHolderData GetEntityBy(string sqlWhere, SqlParameter[] paras)
		{
			return this.FetchEntity(sqlWhere, paras);
		}

		public ACCardHolderData GetEntityExBy(string sql, SqlParameter[] paras)
		{
			return this.FetchEntityEx(sql, paras);
		}

		public ACCardHolderDataCollection GetCollectionBy(string sqlWhere, SqlParameter[] paras)
		{
			return this.FetchCollection(sqlWhere, paras);
		}

		public ACCardHolderDataCollection GetCollectionExBy(string sql, SqlParameter[] paras)
		{
			return this.FetchCollectionEx(sql, paras);
		}

		public byte[] GetRowVersion( System.Guid ACCardHolderPK)
		{
			string sql = string.Format("SELECT [RowVersion] AS [RowVersion] FROM [{0}] WHERE  [ACCardHolderPK] = @ACCardHolderPK ", this.TableName);
			SqlParameter[] paras = new SqlParameter[1];
			paras[0] = new SqlParameter("@ACCardHolderPK", SqlDbType.UniqueIdentifier, 16);
			paras[0].Value = ACCardHolderPK;
			return (byte[]) base.ExecuteScalar(sql, paras);
		}

		public ACCardHolderData GetByPK( System.Guid ACCardHolderPK)
		{
			string sql = " WHERE  [ACCardHolder].[ACCardHolderPK] = @ACCardHolderPK ";
			SqlParameter[] paras = new SqlParameter[1];
			paras[0] = new SqlParameter("@ACCardHolderPK", SqlDbType.UniqueIdentifier);
			paras[0].Value = ACCardHolderPK;
			return this.FetchEntity(sql, paras);
		}

		public ACCardHolderDataCollection GetAll()
		{
			return this.FetchCollection("", null);
		}

		public ACCardHolderDataCollection GetByBDTenant(System.Guid BDTenantPK)
		{
			string sqlWhere = " WHERE [ACCardHolder].[BDTenantPK] = @BDTenantPK";
			SqlParameter[] paras = new SqlParameter[1];
			paras[0] = new SqlParameter("@BDTenantPK", SqlDbType.UniqueIdentifier);
			paras[0].Value = BDTenantPK;
			return this.FetchCollection(sqlWhere, paras);
		}

		public DataTable GetLogByPK( System.Guid ACCardHolderPK)
		{
			string sql = string.Format("SELECT  [ACCardHolder].[ACCardHolderPK] AS [ACCardHolderPK], [ACCardHolder].[ModifiedOn] AS [ModifiedOn] FROM [{0}] WHERE  [ACCardHolder].[ACCardHolderPK] = @ACCardHolderPK ", this.TableName);
			SqlParameter[] paras = new SqlParameter[1];
			paras[0] = new SqlParameter("@ACCardHolderPK", SqlDbType.UniqueIdentifier);
			paras[0].Value = ACCardHolderPK;
			return this.ExecuteDataTable(sql, paras);
		}

		public DataTable GetLogByBDTenant(System.Guid bDTenantPK)
		{
			string sql = string.Format("DELETE [{0}] FROM [{0}] [ACCardHolder] INNER JOIN [BDTenant] ON [ACCardHolder].[BDTenantPK] = [BDTenant].[BDTenantPK] WHERE [BDTenant].[BDTenantPK] = @BDTenantPK;", this.TableName);
			string oldValue = string.Format("DELETE [{0}]", this.TableName);
			string newValue = "SELECT  [ACCardHolder].[ACCardHolderPK] AS [ACCardHolderPK], [ACCardHolder].[ModifiedOn] AS [ModifiedOn]";
			sql = sql.Replace(oldValue, newValue).TrimEnd().TrimEnd(';').Replace(";", " UNION ");
			SqlParameter[] paras = new SqlParameter[1];
			paras[0] = new SqlParameter("@BDTenantPK", SqlDbType.UniqueIdentifier);
			paras[0].Value = bDTenantPK;
			return base.ExecuteDataTable(sql, paras);
		}

		public DataTable GetLogByBDBuilding(System.Guid bDBuildingPK)
		{
			string sql = string.Format("DELETE [{0}] FROM [{0}] [ACCardHolder] INNER JOIN [BDTenant] ON [ACCardHolder].[BDTenantPK] = [BDTenant].[BDTenantPK] INNER JOIN [BDBuilding] ON [BDTenant].[BDBuildingPK] = [BDBuilding].[BDBuildingPK] WHERE [BDBuilding].[BDBuildingPK] = @BDBuildingPK;", this.TableName);
			string oldValue = string.Format("DELETE [{0}]", this.TableName);
			string newValue = "SELECT  [ACCardHolder].[ACCardHolderPK] AS [ACCardHolderPK], [ACCardHolder].[ModifiedOn] AS [ModifiedOn]";
			sql = sql.Replace(oldValue, newValue).TrimEnd().TrimEnd(';').Replace(";", " UNION ");
			SqlParameter[] paras = new SqlParameter[1];
			paras[0] = new SqlParameter("@BDBuildingPK", SqlDbType.UniqueIdentifier);
			paras[0].Value = bDBuildingPK;
			return base.ExecuteDataTable(sql, paras);
		}

		public int DeleteByPK( System.Guid ACCardHolderPK, byte[] RowVersion)
		{
			string sql = string.Format("DELETE FROM [{0}] WHERE  [ACCardHolderPK] = @ACCardHolderPK AND [RowVersion] = @RowVersion", this.TableName);
			SqlParameter[] paras = new SqlParameter[2];
			paras[0] = new SqlParameter("@ACCardHolderPK", SqlDbType.UniqueIdentifier);
			paras[0].Value = ACCardHolderPK;
			paras[1] = new SqlParameter("@RowVersion", SqlDbType.Timestamp, 8);
			paras[1].Value = RowVersion;
			return base.ExecuteNonQuery(sql, paras);
		}

		public int DeleteAll()
		{
			string sql = string.Format("DELETE FROM [{0}]", this.TableName);
			return base.ExecuteNonQuery(sql, null);
		}

		public int DeleteByBDTenant(System.Guid bDTenantPK)
		{
			string sql = string.Format("DELETE [{0}] FROM [{0}] [ACCardHolder] INNER JOIN [BDTenant] ON [ACCardHolder].[BDTenantPK] = [BDTenant].[BDTenantPK] WHERE [BDTenant].[BDTenantPK] = @BDTenantPK;", this.TableName);
			SqlParameter[] paras = new SqlParameter[1];
			paras[0] = new SqlParameter("@BDTenantPK", SqlDbType.UniqueIdentifier);
			paras[0].Value = bDTenantPK;
			return base.ExecuteNonQuery(sql, paras);
		}

		public int DeleteByBDBuilding(System.Guid bDBuildingPK)
		{
			string sql = string.Format("DELETE [{0}] FROM [{0}] [ACCardHolder] INNER JOIN [BDTenant] ON [ACCardHolder].[BDTenantPK] = [BDTenant].[BDTenantPK] INNER JOIN [BDBuilding] ON [BDTenant].[BDBuildingPK] = [BDBuilding].[BDBuildingPK] WHERE [BDBuilding].[BDBuildingPK] = @BDBuildingPK;", this.TableName);
			SqlParameter[] paras = new SqlParameter[1];
			paras[0] = new SqlParameter("@BDBuildingPK", SqlDbType.UniqueIdentifier);
			paras[0].Value = bDBuildingPK;
			return base.ExecuteNonQuery(sql, paras);
		}


	}
	public class ACMainZoneCRUD : DataAccessBase
	{
		private string _tableName = "ACMainZone";

		public ACMainZoneCRUD(string connectionString) : base(connectionString)
		{
		}

		public virtual string TableName
		{
			get { return this._tableName; }
			set { this._tableName = value; }
		}

		public string SQLColumns
		{
			get
			{
				return "[ACMainZone].[ACMainZonePK] AS [ACMainZonePK],[ACMainZone].[ACPanelPK] AS [ACPanelPK],[ACMainZone].[MainZoneID] AS [MainZoneID],[ACMainZone].[MainZoneTypeID] AS [MainZoneTypeID],[ACMainZone].[Description] AS [Description],[ACMainZone].[ReaderName] AS [ReaderName],[ACMainZone].[ReaderTypeID] AS [ReaderTypeID],[ACMainZone].[ReverseColor] AS [ReverseColor],[ACMainZone].[OutputGroup] AS [OutputGroup],[ACMainZone].[NeedPin] AS [NeedPin],[ACMainZone].[AntiPassback] AS [AntiPassback],[ACMainZone].[SoftAntiPassback] AS [SoftAntiPassback],[ACMainZone].[UnlockTimecode] AS [UnlockTimecode],[ACMainZone].[UnlockOn1stRead] AS [UnlockOn1stRead],[ACMainZone].[RexShuntOnly] AS [RexShuntOnly],[ACMainZone].[PulseTime] AS [PulseTime],[ACMainZone].[RelockByTimeout] AS [RelockByTimeout],[ACMainZone].[ForceAMFormat] AS [ForceAMFormat],[ACMainZone].[PropAMFFormat] AS [PropAMFFormat],[ACMainZone].[Debounce] AS [Debounce],[ACMainZone].[AllowOpenTime] AS [AllowOpenTime],[ACMainZone].[NoPreAlarm] AS [NoPreAlarm],[ACMainZone].[PostPreAlarm] AS [PostPreAlarm],[ACMainZone].[PostDuration] AS [PostDuration],[ACMainZone].[Notes] AS [Notes],[ACMainZone].[EventNotifyEmail] AS [EventNotifyEmail],[ACMainZone].[IsPulsed] AS [IsPulsed],[ACMainZone].[AlwaysToMAS] AS [AlwaysToMAS],[ACMainZone].[CommentBeforePulse] AS [CommentBeforePulse],[ACMainZone].[RowVersion] AS [RowVersion],[ACMainZone].[CreatedOn] AS [CreatedOn],[ACMainZone].[CreatedBy] AS [CreatedBy],[ACMainZone].[ModifiedOn] AS [ModifiedOn],[ACMainZone].[ModifiedBy] AS [ModifiedBy],[ACMainZone].[Degrade] AS [Degrade],[ACMainZone].[ReaderPassMode] AS [ReaderPassMode],[ACMainZone].[PanelZoneID] AS [PanelZoneID],[ACMainZone].[LockTypeID] AS [LockTypeID],[ACMainZone].[Locked] AS [Locked],[ACMainZone].[InputGroup] AS [InputGroup],[ACMainZone].[UnlockTempTC] AS [UnlockTempTC],[ACMainZone].[UnlockTempBegin] AS [UnlockTempBegin],[ACMainZone].[UnlockTempEnd] AS [UnlockTempEnd],[ACPanel].[BDBuildingPK] AS [BDBuildingPK],[ACPanel].[UnitID] AS [UnitID],[BDBuilding].[Address1] AS [Address1],[BDBuilding].[BuildingID] AS [BuildingID]";
			}
		}

		public string SQLLeftJoins
		{
			get
			{
				return "LEFT JOIN [ACPanel] [ACPanel] ON [ACMainZone].[ACPanelPK] = [ACPanel].[ACPanelPK] LEFT JOIN [BDBuilding] [BDBuilding] ON [ACPanel].[BDBuildingPK] = [BDBuilding].[BDBuildingPK]";
			}
		}

		protected override string SQLSelect
		{
			get
			{
				return string.Format("SELECT [ACMainZone].[ACMainZonePK] AS [ACMainZonePK],[ACMainZone].[ACPanelPK] AS [ACPanelPK],[ACMainZone].[MainZoneID] AS [MainZoneID],[ACMainZone].[MainZoneTypeID] AS [MainZoneTypeID],[ACMainZone].[Description] AS [Description],[ACMainZone].[ReaderName] AS [ReaderName],[ACMainZone].[ReaderTypeID] AS [ReaderTypeID],[ACMainZone].[ReverseColor] AS [ReverseColor],[ACMainZone].[OutputGroup] AS [OutputGroup],[ACMainZone].[NeedPin] AS [NeedPin],[ACMainZone].[AntiPassback] AS [AntiPassback],[ACMainZone].[SoftAntiPassback] AS [SoftAntiPassback],[ACMainZone].[UnlockTimecode] AS [UnlockTimecode],[ACMainZone].[UnlockOn1stRead] AS [UnlockOn1stRead],[ACMainZone].[RexShuntOnly] AS [RexShuntOnly],[ACMainZone].[PulseTime] AS [PulseTime],[ACMainZone].[RelockByTimeout] AS [RelockByTimeout],[ACMainZone].[ForceAMFormat] AS [ForceAMFormat],[ACMainZone].[PropAMFFormat] AS [PropAMFFormat],[ACMainZone].[Debounce] AS [Debounce],[ACMainZone].[AllowOpenTime] AS [AllowOpenTime],[ACMainZone].[NoPreAlarm] AS [NoPreAlarm],[ACMainZone].[PostPreAlarm] AS [PostPreAlarm],[ACMainZone].[PostDuration] AS [PostDuration],[ACMainZone].[Notes] AS [Notes],[ACMainZone].[EventNotifyEmail] AS [EventNotifyEmail],[ACMainZone].[IsPulsed] AS [IsPulsed],[ACMainZone].[AlwaysToMAS] AS [AlwaysToMAS],[ACMainZone].[CommentBeforePulse] AS [CommentBeforePulse],[ACMainZone].[RowVersion] AS [RowVersion],[ACMainZone].[CreatedOn] AS [CreatedOn],[ACMainZone].[CreatedBy] AS [CreatedBy],[ACMainZone].[ModifiedOn] AS [ModifiedOn],[ACMainZone].[ModifiedBy] AS [ModifiedBy],[ACMainZone].[Degrade] AS [Degrade],[ACMainZone].[ReaderPassMode] AS [ReaderPassMode],[ACMainZone].[PanelZoneID] AS [PanelZoneID],[ACMainZone].[LockTypeID] AS [LockTypeID],[ACMainZone].[Locked] AS [Locked],[ACMainZone].[InputGroup] AS [InputGroup],[ACMainZone].[UnlockTempTC] AS [UnlockTempTC],[ACMainZone].[UnlockTempBegin] AS [UnlockTempBegin],[ACMainZone].[UnlockTempEnd] AS [UnlockTempEnd],[ACPanel].[BDBuildingPK] AS [BDBuildingPK],[ACPanel].[UnitID] AS [UnitID],[BDBuilding].[Address1] AS [Address1],[BDBuilding].[BuildingID] AS [BuildingID] FROM [{0}] [ACMainZone] LEFT JOIN [ACPanel] [ACPanel] ON [ACMainZone].[ACPanelPK] = [ACPanel].[ACPanelPK] LEFT JOIN [BDBuilding] [BDBuilding] ON [ACPanel].[BDBuildingPK] = [BDBuilding].[BDBuildingPK]", this.TableName);
			}
		}

		protected override string SQLCount
		{
			get
			{
				return string.Format("SELECT COUNT(*) FROM [{0}] [ACMainZone] LEFT JOIN [ACPanel] [ACPanel] ON [ACMainZone].[ACPanelPK] = [ACPanel].[ACPanelPK] LEFT JOIN [BDBuilding] [BDBuilding] ON [ACPanel].[BDBuildingPK] = [BDBuilding].[BDBuildingPK]", this.TableName);
			}
		}

		public int Insert(ACMainZoneData entity)
		{
			string sql = string.Format("INSERT INTO [{0}] ([ACMainZonePK],[ACPanelPK],[MainZoneID],[MainZoneTypeID],[Description],[ReaderName],[ReaderTypeID],[ReverseColor],[OutputGroup],[NeedPin],[AntiPassback],[SoftAntiPassback],[UnlockTimecode],[UnlockOn1stRead],[RexShuntOnly],[PulseTime],[RelockByTimeout],[ForceAMFormat],[PropAMFFormat],[Debounce],[AllowOpenTime],[NoPreAlarm],[PostPreAlarm],[PostDuration],[Notes],[EventNotifyEmail],[IsPulsed],[AlwaysToMAS],[CommentBeforePulse],[CreatedOn],[CreatedBy],[ModifiedOn],[ModifiedBy],[Degrade],[ReaderPassMode],[PanelZoneID],[LockTypeID],[Locked],[InputGroup],[UnlockTempTC],[UnlockTempBegin],[UnlockTempEnd]) VALUES(@ACMainZonePK,@ACPanelPK,@MainZoneID,@MainZoneTypeID,@Description,@ReaderName,@ReaderTypeID,@ReverseColor,@OutputGroup,@NeedPin,@AntiPassback,@SoftAntiPassback,@UnlockTimecode,@UnlockOn1stRead,@RexShuntOnly,@PulseTime,@RelockByTimeout,@ForceAMFormat,@PropAMFFormat,@Debounce,@AllowOpenTime,@NoPreAlarm,@PostPreAlarm,@PostDuration,@Notes,@EventNotifyEmail,@IsPulsed,@AlwaysToMAS,@CommentBeforePulse,@CreatedOn,@CreatedBy,@ModifiedOn,@ModifiedBy,@Degrade,@ReaderPassMode,@PanelZoneID,@LockTypeID,@Locked,@InputGroup,@UnlockTempTC,@UnlockTempBegin,@UnlockTempEnd)", this.TableName);
			SqlParameter[] paras = new SqlParameter[42];
			paras[0] = new SqlParameter("@ACMainZonePK", SqlDbType.UniqueIdentifier);
			if (entity.ACMainZonePK == Guid.Empty)
			{
				paras[0].Value = DBNull.Value;
			}
			else
			{
				paras[0].Value = entity.ACMainZonePK;
			}
			paras[1] = new SqlParameter("@ACPanelPK", SqlDbType.UniqueIdentifier);
			if (entity.ACPanelPK == Guid.Empty)
			{
				paras[1].Value = DBNull.Value;
			}
			else
			{
				paras[1].Value = entity.ACPanelPK;
			}
			paras[2] = new SqlParameter("@MainZoneID", SqlDbType.TinyInt);
			paras[2].Value = entity.MainZoneID;
			paras[3] = new SqlParameter("@MainZoneTypeID", SqlDbType.Int);
			paras[3].Value = entity.MainZoneTypeID;
			paras[4] = new SqlParameter("@Description", SqlDbType.VarChar, 30);
			paras[4].Value = entity.Description;
			paras[5] = new SqlParameter("@ReaderName", SqlDbType.VarChar, 30);
			paras[5].Value = entity.ReaderName;
			paras[6] = new SqlParameter("@ReaderTypeID", SqlDbType.Int);
			paras[6].Value = entity.ReaderTypeID;
			paras[7] = new SqlParameter("@ReverseColor", SqlDbType.Bit);
			paras[7].Value = entity.ReverseColor;
			paras[8] = new SqlParameter("@OutputGroup", SqlDbType.TinyInt);
			paras[8].Value = entity.OutputGroup;
			paras[9] = new SqlParameter("@NeedPin", SqlDbType.Bit);
			paras[9].Value = entity.NeedPin;
			paras[10] = new SqlParameter("@AntiPassback", SqlDbType.Char, 1);
			paras[10].Value = entity.AntiPassback;
			paras[11] = new SqlParameter("@SoftAntiPassback", SqlDbType.Bit);
			paras[11].Value = entity.SoftAntiPassback;
			paras[12] = new SqlParameter("@UnlockTimecode", SqlDbType.SmallInt);
			paras[12].Value = entity.UnlockTimecode;
			paras[13] = new SqlParameter("@UnlockOn1stRead", SqlDbType.Bit);
			paras[13].Value = entity.UnlockOn1stRead;
			paras[14] = new SqlParameter("@RexShuntOnly", SqlDbType.Bit);
			paras[14].Value = entity.RexShuntOnly;
			paras[15] = new SqlParameter("@PulseTime", SqlDbType.SmallInt);
			paras[15].Value = entity.PulseTime;
			paras[16] = new SqlParameter("@RelockByTimeout", SqlDbType.Bit);
			paras[16].Value = entity.RelockByTimeout;
			paras[17] = new SqlParameter("@ForceAMFormat", SqlDbType.SmallInt);
			paras[17].Value = entity.ForceAMFormat;
			paras[18] = new SqlParameter("@PropAMFFormat", SqlDbType.SmallInt);
			paras[18].Value = entity.PropAMFFormat;
			paras[19] = new SqlParameter("@Debounce", SqlDbType.SmallInt);
			paras[19].Value = entity.Debounce;
			paras[20] = new SqlParameter("@AllowOpenTime", SqlDbType.SmallInt);
			paras[20].Value = entity.AllowOpenTime;
			paras[21] = new SqlParameter("@NoPreAlarm", SqlDbType.Bit);
			paras[21].Value = entity.NoPreAlarm;
			paras[22] = new SqlParameter("@PostPreAlarm", SqlDbType.Char, 1);
			paras[22].Value = entity.PostPreAlarm;
			paras[23] = new SqlParameter("@PostDuration", SqlDbType.SmallInt);
			paras[23].Value = entity.PostDuration;
			paras[24] = new SqlParameter("@Notes", SqlDbType.VarChar, 1024);
			paras[24].Value = entity.Notes;
			paras[25] = new SqlParameter("@EventNotifyEmail", SqlDbType.VarChar, 1024);
			paras[25].Value = entity.EventNotifyEmail;
			paras[26] = new SqlParameter("@IsPulsed", SqlDbType.Bit);
			paras[26].Value = entity.IsPulsed;
			paras[27] = new SqlParameter("@AlwaysToMAS", SqlDbType.Bit);
			paras[27].Value = entity.AlwaysToMAS;
			paras[28] = new SqlParameter("@CommentBeforePulse", SqlDbType.Bit);
			paras[28].Value = entity.CommentBeforePulse;
			paras[29] = new SqlParameter("@CreatedOn", SqlDbType.DateTime);
			paras[29].Value = entity.CreatedOn;
			paras[30] = new SqlParameter("@CreatedBy", SqlDbType.VarChar, 30);
			paras[30].Value = entity.CreatedBy;
			paras[31] = new SqlParameter("@ModifiedOn", SqlDbType.DateTime);
			paras[31].Value = entity.ModifiedOn;
			paras[32] = new SqlParameter("@ModifiedBy", SqlDbType.VarChar, 30);
			paras[32].Value = entity.ModifiedBy;
			paras[33] = new SqlParameter("@Degrade", SqlDbType.Bit);
			paras[33].Value = entity.Degrade;
			paras[34] = new SqlParameter("@ReaderPassMode", SqlDbType.Char, 1);
			paras[34].Value = entity.ReaderPassMode;
			paras[35] = new SqlParameter("@PanelZoneID", SqlDbType.TinyInt);
			paras[35].Value = entity.PanelZoneID;
			paras[36] = new SqlParameter("@LockTypeID", SqlDbType.Int);
			paras[36].Value = entity.LockTypeID;
			paras[37] = new SqlParameter("@Locked", SqlDbType.Bit);
			paras[37].Value = entity.Locked;
			paras[38] = new SqlParameter("@InputGroup", SqlDbType.TinyInt);
			paras[38].Value = entity.InputGroup;
			paras[39] = new SqlParameter("@UnlockTempTC", SqlDbType.SmallInt);
			paras[39].Value = entity.UnlockTempTC;
			paras[40] = new SqlParameter("@UnlockTempBegin", SqlDbType.DateTime);
			paras[40].Value = entity.UnlockTempBegin;
			paras[41] = new SqlParameter("@UnlockTempEnd", SqlDbType.DateTime);
			paras[41].Value = entity.UnlockTempEnd;
			return base.ExecuteNonQuery(sql, paras);
		}

		public int Update(ACMainZoneData entity)
		{
			string sql = string.Format("UPDATE [{0}] SET [ACPanelPK] = @ACPanelPK,[MainZoneID] = @MainZoneID,[MainZoneTypeID] = @MainZoneTypeID,[Description] = @Description,[ReaderName] = @ReaderName,[ReaderTypeID] = @ReaderTypeID,[ReverseColor] = @ReverseColor,[OutputGroup] = @OutputGroup,[NeedPin] = @NeedPin,[AntiPassback] = @AntiPassback,[SoftAntiPassback] = @SoftAntiPassback,[UnlockTimecode] = @UnlockTimecode,[UnlockOn1stRead] = @UnlockOn1stRead,[RexShuntOnly] = @RexShuntOnly,[PulseTime] = @PulseTime,[RelockByTimeout] = @RelockByTimeout,[ForceAMFormat] = @ForceAMFormat,[PropAMFFormat] = @PropAMFFormat,[Debounce] = @Debounce,[AllowOpenTime] = @AllowOpenTime,[NoPreAlarm] = @NoPreAlarm,[PostPreAlarm] = @PostPreAlarm,[PostDuration] = @PostDuration,[Notes] = @Notes,[EventNotifyEmail] = @EventNotifyEmail,[IsPulsed] = @IsPulsed,[AlwaysToMAS] = @AlwaysToMAS,[CommentBeforePulse] = @CommentBeforePulse,[CreatedOn] = @CreatedOn,[CreatedBy] = @CreatedBy,[ModifiedOn] = @ModifiedOn,[ModifiedBy] = @ModifiedBy,[Degrade] = @Degrade,[ReaderPassMode] = @ReaderPassMode,[PanelZoneID] = @PanelZoneID,[LockTypeID] = @LockTypeID,[Locked] = @Locked,[InputGroup] = @InputGroup,[UnlockTempTC] = @UnlockTempTC,[UnlockTempBegin] = @UnlockTempBegin,[UnlockTempEnd] = @UnlockTempEnd  WHERE [ACMainZonePK] = @ACMainZonePK AND [RowVersion] = @RowVersion", this.TableName);
			SqlParameter[] paras = new SqlParameter[43];
			paras[0] = new SqlParameter("@ACMainZonePK", SqlDbType.UniqueIdentifier);
			if (entity.ACMainZonePK == Guid.Empty)
			{
				paras[0].Value = DBNull.Value;
			}
			else
			{
				paras[0].Value = entity.ACMainZonePK;
			}
			paras[1] = new SqlParameter("@ACPanelPK", SqlDbType.UniqueIdentifier);
			if (entity.ACPanelPK == Guid.Empty)
			{
				paras[1].Value = DBNull.Value;
			}
			else
			{
				paras[1].Value = entity.ACPanelPK;
			}
			paras[2] = new SqlParameter("@MainZoneID", SqlDbType.TinyInt);
			paras[2].Value = entity.MainZoneID;
			paras[3] = new SqlParameter("@MainZoneTypeID", SqlDbType.Int);
			paras[3].Value = entity.MainZoneTypeID;
			paras[4] = new SqlParameter("@Description", SqlDbType.VarChar, 30);
			paras[4].Value = entity.Description;
			paras[5] = new SqlParameter("@ReaderName", SqlDbType.VarChar, 30);
			paras[5].Value = entity.ReaderName;
			paras[6] = new SqlParameter("@ReaderTypeID", SqlDbType.Int);
			paras[6].Value = entity.ReaderTypeID;
			paras[7] = new SqlParameter("@ReverseColor", SqlDbType.Bit);
			paras[7].Value = entity.ReverseColor;
			paras[8] = new SqlParameter("@OutputGroup", SqlDbType.TinyInt);
			paras[8].Value = entity.OutputGroup;
			paras[9] = new SqlParameter("@NeedPin", SqlDbType.Bit);
			paras[9].Value = entity.NeedPin;
			paras[10] = new SqlParameter("@AntiPassback", SqlDbType.Char, 1);
			paras[10].Value = entity.AntiPassback;
			paras[11] = new SqlParameter("@SoftAntiPassback", SqlDbType.Bit);
			paras[11].Value = entity.SoftAntiPassback;
			paras[12] = new SqlParameter("@UnlockTimecode", SqlDbType.SmallInt);
			paras[12].Value = entity.UnlockTimecode;
			paras[13] = new SqlParameter("@UnlockOn1stRead", SqlDbType.Bit);
			paras[13].Value = entity.UnlockOn1stRead;
			paras[14] = new SqlParameter("@RexShuntOnly", SqlDbType.Bit);
			paras[14].Value = entity.RexShuntOnly;
			paras[15] = new SqlParameter("@PulseTime", SqlDbType.SmallInt);
			paras[15].Value = entity.PulseTime;
			paras[16] = new SqlParameter("@RelockByTimeout", SqlDbType.Bit);
			paras[16].Value = entity.RelockByTimeout;
			paras[17] = new SqlParameter("@ForceAMFormat", SqlDbType.SmallInt);
			paras[17].Value = entity.ForceAMFormat;
			paras[18] = new SqlParameter("@PropAMFFormat", SqlDbType.SmallInt);
			paras[18].Value = entity.PropAMFFormat;
			paras[19] = new SqlParameter("@Debounce", SqlDbType.SmallInt);
			paras[19].Value = entity.Debounce;
			paras[20] = new SqlParameter("@AllowOpenTime", SqlDbType.SmallInt);
			paras[20].Value = entity.AllowOpenTime;
			paras[21] = new SqlParameter("@NoPreAlarm", SqlDbType.Bit);
			paras[21].Value = entity.NoPreAlarm;
			paras[22] = new SqlParameter("@PostPreAlarm", SqlDbType.Char, 1);
			paras[22].Value = entity.PostPreAlarm;
			paras[23] = new SqlParameter("@PostDuration", SqlDbType.SmallInt);
			paras[23].Value = entity.PostDuration;
			paras[24] = new SqlParameter("@Notes", SqlDbType.VarChar, 1024);
			paras[24].Value = entity.Notes;
			paras[25] = new SqlParameter("@EventNotifyEmail", SqlDbType.VarChar, 1024);
			paras[25].Value = entity.EventNotifyEmail;
			paras[26] = new SqlParameter("@IsPulsed", SqlDbType.Bit);
			paras[26].Value = entity.IsPulsed;
			paras[27] = new SqlParameter("@AlwaysToMAS", SqlDbType.Bit);
			paras[27].Value = entity.AlwaysToMAS;
			paras[28] = new SqlParameter("@CommentBeforePulse", SqlDbType.Bit);
			paras[28].Value = entity.CommentBeforePulse;
			paras[29] = new SqlParameter("@RowVersion", SqlDbType.Timestamp);
			paras[29].Value = entity.RowVersion;
			paras[30] = new SqlParameter("@CreatedOn", SqlDbType.DateTime);
			paras[30].Value = entity.CreatedOn;
			paras[31] = new SqlParameter("@CreatedBy", SqlDbType.VarChar, 30);
			paras[31].Value = entity.CreatedBy;
			paras[32] = new SqlParameter("@ModifiedOn", SqlDbType.DateTime);
			paras[32].Value = entity.ModifiedOn;
			paras[33] = new SqlParameter("@ModifiedBy", SqlDbType.VarChar, 30);
			paras[33].Value = entity.ModifiedBy;
			paras[34] = new SqlParameter("@Degrade", SqlDbType.Bit);
			paras[34].Value = entity.Degrade;
			paras[35] = new SqlParameter("@ReaderPassMode", SqlDbType.Char, 1);
			paras[35].Value = entity.ReaderPassMode;
			paras[36] = new SqlParameter("@PanelZoneID", SqlDbType.TinyInt);
			paras[36].Value = entity.PanelZoneID;
			paras[37] = new SqlParameter("@LockTypeID", SqlDbType.Int);
			paras[37].Value = entity.LockTypeID;
			paras[38] = new SqlParameter("@Locked", SqlDbType.Bit);
			paras[38].Value = entity.Locked;
			paras[39] = new SqlParameter("@InputGroup", SqlDbType.TinyInt);
			paras[39].Value = entity.InputGroup;
			paras[40] = new SqlParameter("@UnlockTempTC", SqlDbType.SmallInt);
			paras[40].Value = entity.UnlockTempTC;
			paras[41] = new SqlParameter("@UnlockTempBegin", SqlDbType.DateTime);
			paras[41].Value = entity.UnlockTempBegin;
			paras[42] = new SqlParameter("@UnlockTempEnd", SqlDbType.DateTime);
			paras[42].Value = entity.UnlockTempEnd;
			return base.ExecuteNonQuery(sql, paras);
		}

		private ACMainZoneData CreateDataByReader(SafeDataReader reader)
		{
			ACMainZoneData data = new ACMainZoneData {
				ACMainZonePK = (Guid) reader["ACMainZonePK"],
				ACPanelPK = (Guid) reader["ACPanelPK"],
				MainZoneID = (Byte) reader["MainZoneID"],
				MainZoneTypeID = (Int32) reader["MainZoneTypeID"],
				Description = (String) reader["Description"],
				ReaderName = (String) reader["ReaderName"],
				ReaderTypeID = (Int32) reader["ReaderTypeID"],
				ReverseColor = (Boolean) reader["ReverseColor"],
				OutputGroup = (Byte) reader["OutputGroup"],
				NeedPin = (Boolean) reader["NeedPin"],
				AntiPassback = (String) reader["AntiPassback"],
				SoftAntiPassback = (Boolean) reader["SoftAntiPassback"],
				UnlockTimecode = (Int16) reader["UnlockTimecode"],
				UnlockOn1stRead = (Boolean) reader["UnlockOn1stRead"],
				RexShuntOnly = (Boolean) reader["RexShuntOnly"],
				PulseTime = (Int16) reader["PulseTime"],
				RelockByTimeout = (Boolean) reader["RelockByTimeout"],
				ForceAMFormat = (Int16) reader["ForceAMFormat"],
				PropAMFFormat = (Int16) reader["PropAMFFormat"],
				Debounce = (Int16) reader["Debounce"],
				AllowOpenTime = (Int16) reader["AllowOpenTime"],
				NoPreAlarm = (Boolean) reader["NoPreAlarm"],
				PostPreAlarm = (String) reader["PostPreAlarm"],
				PostDuration = (Int16) reader["PostDuration"],
				Notes = (String) reader["Notes"],
				EventNotifyEmail = (String) reader["EventNotifyEmail"],
				IsPulsed = (Boolean) reader["IsPulsed"],
				AlwaysToMAS = (Boolean) reader["AlwaysToMAS"],
				CommentBeforePulse = (Boolean) reader["CommentBeforePulse"],
				RowVersion = (Byte[]) reader["RowVersion"],
				CreatedOn = (DateTime) reader["CreatedOn"],
				CreatedBy = (String) reader["CreatedBy"],
				ModifiedOn = (DateTime) reader["ModifiedOn"],
				ModifiedBy = (String) reader["ModifiedBy"],
				Degrade = (Boolean) reader["Degrade"],
				ReaderPassMode = (String) reader["ReaderPassMode"],
				PanelZoneID = (Byte) reader["PanelZoneID"],
				LockTypeID = (Int32) reader["LockTypeID"],
				Locked = (Boolean) reader["Locked"],
				InputGroup = (Byte) reader["InputGroup"],
				UnlockTempTC = (Int16) reader["UnlockTempTC"],
				UnlockTempBegin = (DateTime) reader["UnlockTempBegin"],
				UnlockTempEnd = (DateTime) reader["UnlockTempEnd"],
				BDBuildingPK = (Guid) reader["BDBuildingPK"],
				UnitID = (Int32) reader["UnitID"],
				Address1 = (String) reader["Address1"],
				BuildingID = (Int32) reader["BuildingID"]
			};
			data.AcceptChanges();
			return data;
		}

		private ACMainZoneData FetchEntity(string where, SqlParameter[] paras)
		{
			ACMainZoneData data = null;
			using (SafeDataReader reader = base.ExecuteDataReader(where, paras))
			{
				if (reader.Read())
				{
					data = this.CreateDataByReader(reader);
				}
				reader.Close();
			}
			return data;
		}

		private ACMainZoneData FetchEntityEx(string sql, SqlParameter[] paras)
		{
			ACMainZoneData data = null;
			using (SafeDataReader reader = base.ExecuteDataReaderEx(sql, paras))
			{
				if (reader.Read())
				{
					data = this.CreateDataByReader(reader);
				}
				reader.Close();
			}
			return data;
		}

		private ACMainZoneDataCollection FetchCollection(string where, SqlParameter[] paras)
		{
			ACMainZoneDataCollection list = new ACMainZoneDataCollection();
			using (SafeDataReader reader = base.ExecuteDataReader(where, paras))
			{
				while(reader.Read())
				{
					ACMainZoneData data = this.CreateDataByReader(reader);
					list.Add(data);
				}
				reader.Close();
			}
			return list;
		}

		private ACMainZoneDataCollection FetchCollectionEx(string sql, SqlParameter[] paras)
		{
			ACMainZoneDataCollection list = new ACMainZoneDataCollection();
			using (SafeDataReader reader = base.ExecuteDataReaderEx(sql, paras))
			{
				while(reader.Read())
				{
					ACMainZoneData data = this.CreateDataByReader(reader);
					list.Add(data);
				}
				reader.Close();
			}
			return list;
		}

		public ACMainZoneData GetEntityBy(string sqlWhere, SqlParameter[] paras)
		{
			return this.FetchEntity(sqlWhere, paras);
		}

		public ACMainZoneData GetEntityExBy(string sql, SqlParameter[] paras)
		{
			return this.FetchEntityEx(sql, paras);
		}

		public ACMainZoneDataCollection GetCollectionBy(string sqlWhere, SqlParameter[] paras)
		{
			return this.FetchCollection(sqlWhere, paras);
		}

		public ACMainZoneDataCollection GetCollectionExBy(string sql, SqlParameter[] paras)
		{
			return this.FetchCollectionEx(sql, paras);
		}

		public byte[] GetRowVersion( System.Guid ACMainZonePK)
		{
			string sql = string.Format("SELECT [RowVersion] AS [RowVersion] FROM [{0}] WHERE  [ACMainZonePK] = @ACMainZonePK ", this.TableName);
			SqlParameter[] paras = new SqlParameter[1];
			paras[0] = new SqlParameter("@ACMainZonePK", SqlDbType.UniqueIdentifier, 16);
			paras[0].Value = ACMainZonePK;
			return (byte[]) base.ExecuteScalar(sql, paras);
		}

		public ACMainZoneData GetByPK( System.Guid ACMainZonePK)
		{
			string sql = " WHERE  [ACMainZone].[ACMainZonePK] = @ACMainZonePK ";
			SqlParameter[] paras = new SqlParameter[1];
			paras[0] = new SqlParameter("@ACMainZonePK", SqlDbType.UniqueIdentifier);
			paras[0].Value = ACMainZonePK;
			return this.FetchEntity(sql, paras);
		}

		public ACMainZoneDataCollection GetAll()
		{
			return this.FetchCollection("", null);
		}

		public ACMainZoneDataCollection GetByACPanel(System.Guid ACPanelPK)
		{
			string sqlWhere = " WHERE [ACMainZone].[ACPanelPK] = @ACPanelPK";
			SqlParameter[] paras = new SqlParameter[1];
			paras[0] = new SqlParameter("@ACPanelPK", SqlDbType.UniqueIdentifier);
			paras[0].Value = ACPanelPK;
			return this.FetchCollection(sqlWhere, paras);
		}

		public DataTable GetLogByPK( System.Guid ACMainZonePK)
		{
			string sql = string.Format("SELECT  [ACMainZone].[ACMainZonePK] AS [ACMainZonePK], [ACMainZone].[ModifiedOn] AS [ModifiedOn] FROM [{0}] WHERE  [ACMainZone].[ACMainZonePK] = @ACMainZonePK ", this.TableName);
			SqlParameter[] paras = new SqlParameter[1];
			paras[0] = new SqlParameter("@ACMainZonePK", SqlDbType.UniqueIdentifier);
			paras[0].Value = ACMainZonePK;
			return this.ExecuteDataTable(sql, paras);
		}

		public DataTable GetLogByACPanel(System.Guid aCPanelPK)
		{
			string sql = string.Format("DELETE [{0}] FROM [{0}] [ACMainZone] INNER JOIN [ACPanel] ON [ACMainZone].[ACPanelPK] = [ACPanel].[ACPanelPK] WHERE [ACPanel].[ACPanelPK] = @ACPanelPK;", this.TableName);
			string oldValue = string.Format("DELETE [{0}]", this.TableName);
			string newValue = "SELECT  [ACMainZone].[ACMainZonePK] AS [ACMainZonePK], [ACMainZone].[ModifiedOn] AS [ModifiedOn]";
			sql = sql.Replace(oldValue, newValue).TrimEnd().TrimEnd(';').Replace(";", " UNION ");
			SqlParameter[] paras = new SqlParameter[1];
			paras[0] = new SqlParameter("@ACPanelPK", SqlDbType.UniqueIdentifier);
			paras[0].Value = aCPanelPK;
			return base.ExecuteDataTable(sql, paras);
		}

		public DataTable GetLogByBDBuilding(System.Guid bDBuildingPK)
		{
			string sql = string.Format("DELETE [{0}] FROM [{0}] [ACMainZone] INNER JOIN [ACPanel] ON [ACMainZone].[ACPanelPK] = [ACPanel].[ACPanelPK] INNER JOIN [BDBuilding] ON [ACPanel].[BDBuildingPK] = [BDBuilding].[BDBuildingPK] WHERE [BDBuilding].[BDBuildingPK] = @BDBuildingPK;", this.TableName);
			string oldValue = string.Format("DELETE [{0}]", this.TableName);
			string newValue = "SELECT  [ACMainZone].[ACMainZonePK] AS [ACMainZonePK], [ACMainZone].[ModifiedOn] AS [ModifiedOn]";
			sql = sql.Replace(oldValue, newValue).TrimEnd().TrimEnd(';').Replace(";", " UNION ");
			SqlParameter[] paras = new SqlParameter[1];
			paras[0] = new SqlParameter("@BDBuildingPK", SqlDbType.UniqueIdentifier);
			paras[0].Value = bDBuildingPK;
			return base.ExecuteDataTable(sql, paras);
		}

		public int DeleteByPK( System.Guid ACMainZonePK, byte[] RowVersion)
		{
			string sql = string.Format("DELETE FROM [{0}] WHERE  [ACMainZonePK] = @ACMainZonePK AND [RowVersion] = @RowVersion", this.TableName);
			SqlParameter[] paras = new SqlParameter[2];
			paras[0] = new SqlParameter("@ACMainZonePK", SqlDbType.UniqueIdentifier);
			paras[0].Value = ACMainZonePK;
			paras[1] = new SqlParameter("@RowVersion", SqlDbType.Timestamp, 8);
			paras[1].Value = RowVersion;
			return base.ExecuteNonQuery(sql, paras);
		}

		public int DeleteAll()
		{
			string sql = string.Format("DELETE FROM [{0}]", this.TableName);
			return base.ExecuteNonQuery(sql, null);
		}

		public int DeleteByACPanel(System.Guid aCPanelPK)
		{
			string sql = string.Format("DELETE [{0}] FROM [{0}] [ACMainZone] INNER JOIN [ACPanel] ON [ACMainZone].[ACPanelPK] = [ACPanel].[ACPanelPK] WHERE [ACPanel].[ACPanelPK] = @ACPanelPK;", this.TableName);
			SqlParameter[] paras = new SqlParameter[1];
			paras[0] = new SqlParameter("@ACPanelPK", SqlDbType.UniqueIdentifier);
			paras[0].Value = aCPanelPK;
			return base.ExecuteNonQuery(sql, paras);
		}

		public int DeleteByBDBuilding(System.Guid bDBuildingPK)
		{
			string sql = string.Format("DELETE [{0}] FROM [{0}] [ACMainZone] INNER JOIN [ACPanel] ON [ACMainZone].[ACPanelPK] = [ACPanel].[ACPanelPK] INNER JOIN [BDBuilding] ON [ACPanel].[BDBuildingPK] = [BDBuilding].[BDBuildingPK] WHERE [BDBuilding].[BDBuildingPK] = @BDBuildingPK;", this.TableName);
			SqlParameter[] paras = new SqlParameter[1];
			paras[0] = new SqlParameter("@BDBuildingPK", SqlDbType.UniqueIdentifier);
			paras[0].Value = bDBuildingPK;
			return base.ExecuteNonQuery(sql, paras);
		}


	}
	public class ACIntervalCRUD : DataAccessBase
	{
		private string _tableName = "ACInterval";

		public ACIntervalCRUD(string connectionString) : base(connectionString)
		{
		}

		public virtual string TableName
		{
			get { return this._tableName; }
			set { this._tableName = value; }
		}

		public string SQLColumns
		{
			get
			{
				return "[ACInterval].[ACIntervalPK] AS [ACIntervalPK],[ACInterval].[BDBuildingPK] AS [BDBuildingPK],[ACInterval].[IVID] AS [IVID],[ACInterval].[Begin] AS [Begin],[ACInterval].[End] AS [End],[ACInterval].[Sun] AS [Sun],[ACInterval].[Mon] AS [Mon],[ACInterval].[Tue] AS [Tue],[ACInterval].[Wed] AS [Wed],[ACInterval].[Thu] AS [Thu],[ACInterval].[Fri] AS [Fri],[ACInterval].[Sat] AS [Sat],[ACInterval].[Hol] AS [Hol],[ACInterval].[RowVersion] AS [RowVersion],[ACInterval].[CreatedOn] AS [CreatedOn],[ACInterval].[CreatedBy] AS [CreatedBy],[ACInterval].[ModifiedOn] AS [ModifiedOn],[ACInterval].[ModifiedBy] AS [ModifiedBy],[BDBuilding].[Address1] AS [Address1],[BDBuilding].[BuildingID] AS [BuildingID]";
			}
		}

		public string SQLLeftJoins
		{
			get
			{
				return "LEFT JOIN [BDBuilding] [BDBuilding] ON [ACInterval].[BDBuildingPK] = [BDBuilding].[BDBuildingPK]";
			}
		}

		protected override string SQLSelect
		{
			get
			{
				return string.Format("SELECT [ACInterval].[ACIntervalPK] AS [ACIntervalPK],[ACInterval].[BDBuildingPK] AS [BDBuildingPK],[ACInterval].[IVID] AS [IVID],[ACInterval].[Begin] AS [Begin],[ACInterval].[End] AS [End],[ACInterval].[Sun] AS [Sun],[ACInterval].[Mon] AS [Mon],[ACInterval].[Tue] AS [Tue],[ACInterval].[Wed] AS [Wed],[ACInterval].[Thu] AS [Thu],[ACInterval].[Fri] AS [Fri],[ACInterval].[Sat] AS [Sat],[ACInterval].[Hol] AS [Hol],[ACInterval].[RowVersion] AS [RowVersion],[ACInterval].[CreatedOn] AS [CreatedOn],[ACInterval].[CreatedBy] AS [CreatedBy],[ACInterval].[ModifiedOn] AS [ModifiedOn],[ACInterval].[ModifiedBy] AS [ModifiedBy],[BDBuilding].[Address1] AS [Address1],[BDBuilding].[BuildingID] AS [BuildingID] FROM [{0}] [ACInterval] LEFT JOIN [BDBuilding] [BDBuilding] ON [ACInterval].[BDBuildingPK] = [BDBuilding].[BDBuildingPK]", this.TableName);
			}
		}

		protected override string SQLCount
		{
			get
			{
				return string.Format("SELECT COUNT(*) FROM [{0}] [ACInterval] LEFT JOIN [BDBuilding] [BDBuilding] ON [ACInterval].[BDBuildingPK] = [BDBuilding].[BDBuildingPK]", this.TableName);
			}
		}

		public int Insert(ACIntervalData entity)
		{
			string sql = string.Format("INSERT INTO [{0}] ([ACIntervalPK],[BDBuildingPK],[IVID],[Begin],[End],[Sun],[Mon],[Tue],[Wed],[Thu],[Fri],[Sat],[Hol],[CreatedOn],[CreatedBy],[ModifiedOn],[ModifiedBy]) VALUES(@ACIntervalPK,@BDBuildingPK,@IVID,@Begin,@End,@Sun,@Mon,@Tue,@Wed,@Thu,@Fri,@Sat,@Hol,@CreatedOn,@CreatedBy,@ModifiedOn,@ModifiedBy)", this.TableName);
			SqlParameter[] paras = new SqlParameter[17];
			paras[0] = new SqlParameter("@ACIntervalPK", SqlDbType.UniqueIdentifier);
			if (entity.ACIntervalPK == Guid.Empty)
			{
				paras[0].Value = DBNull.Value;
			}
			else
			{
				paras[0].Value = entity.ACIntervalPK;
			}
			paras[1] = new SqlParameter("@BDBuildingPK", SqlDbType.UniqueIdentifier);
			if (entity.BDBuildingPK == Guid.Empty)
			{
				paras[1].Value = DBNull.Value;
			}
			else
			{
				paras[1].Value = entity.BDBuildingPK;
			}
			paras[2] = new SqlParameter("@IVID", SqlDbType.SmallInt);
			paras[2].Value = entity.IVID;
			paras[3] = new SqlParameter("@Begin", SqlDbType.Char, 4);
			paras[3].Value = entity.Begin;
			paras[4] = new SqlParameter("@End", SqlDbType.Char, 4);
			paras[4].Value = entity.End;
			paras[5] = new SqlParameter("@Sun", SqlDbType.Bit);
			paras[5].Value = entity.Sun;
			paras[6] = new SqlParameter("@Mon", SqlDbType.Bit);
			paras[6].Value = entity.Mon;
			paras[7] = new SqlParameter("@Tue", SqlDbType.Bit);
			paras[7].Value = entity.Tue;
			paras[8] = new SqlParameter("@Wed", SqlDbType.Bit);
			paras[8].Value = entity.Wed;
			paras[9] = new SqlParameter("@Thu", SqlDbType.Bit);
			paras[9].Value = entity.Thu;
			paras[10] = new SqlParameter("@Fri", SqlDbType.Bit);
			paras[10].Value = entity.Fri;
			paras[11] = new SqlParameter("@Sat", SqlDbType.Bit);
			paras[11].Value = entity.Sat;
			paras[12] = new SqlParameter("@Hol", SqlDbType.Bit);
			paras[12].Value = entity.Hol;
			paras[13] = new SqlParameter("@CreatedOn", SqlDbType.DateTime);
			paras[13].Value = entity.CreatedOn;
			paras[14] = new SqlParameter("@CreatedBy", SqlDbType.VarChar, 30);
			paras[14].Value = entity.CreatedBy;
			paras[15] = new SqlParameter("@ModifiedOn", SqlDbType.DateTime);
			paras[15].Value = entity.ModifiedOn;
			paras[16] = new SqlParameter("@ModifiedBy", SqlDbType.VarChar, 30);
			paras[16].Value = entity.ModifiedBy;
			return base.ExecuteNonQuery(sql, paras);
		}

		public int Update(ACIntervalData entity)
		{
			string sql = string.Format("UPDATE [{0}] SET [BDBuildingPK] = @BDBuildingPK,[IVID] = @IVID,[Begin] = @Begin,[End] = @End,[Sun] = @Sun,[Mon] = @Mon,[Tue] = @Tue,[Wed] = @Wed,[Thu] = @Thu,[Fri] = @Fri,[Sat] = @Sat,[Hol] = @Hol,[CreatedOn] = @CreatedOn,[CreatedBy] = @CreatedBy,[ModifiedOn] = @ModifiedOn,[ModifiedBy] = @ModifiedBy  WHERE [ACIntervalPK] = @ACIntervalPK AND [RowVersion] = @RowVersion", this.TableName);
			SqlParameter[] paras = new SqlParameter[18];
			paras[0] = new SqlParameter("@ACIntervalPK", SqlDbType.UniqueIdentifier);
			if (entity.ACIntervalPK == Guid.Empty)
			{
				paras[0].Value = DBNull.Value;
			}
			else
			{
				paras[0].Value = entity.ACIntervalPK;
			}
			paras[1] = new SqlParameter("@BDBuildingPK", SqlDbType.UniqueIdentifier);
			if (entity.BDBuildingPK == Guid.Empty)
			{
				paras[1].Value = DBNull.Value;
			}
			else
			{
				paras[1].Value = entity.BDBuildingPK;
			}
			paras[2] = new SqlParameter("@IVID", SqlDbType.SmallInt);
			paras[2].Value = entity.IVID;
			paras[3] = new SqlParameter("@Begin", SqlDbType.Char, 4);
			paras[3].Value = entity.Begin;
			paras[4] = new SqlParameter("@End", SqlDbType.Char, 4);
			paras[4].Value = entity.End;
			paras[5] = new SqlParameter("@Sun", SqlDbType.Bit);
			paras[5].Value = entity.Sun;
			paras[6] = new SqlParameter("@Mon", SqlDbType.Bit);
			paras[6].Value = entity.Mon;
			paras[7] = new SqlParameter("@Tue", SqlDbType.Bit);
			paras[7].Value = entity.Tue;
			paras[8] = new SqlParameter("@Wed", SqlDbType.Bit);
			paras[8].Value = entity.Wed;
			paras[9] = new SqlParameter("@Thu", SqlDbType.Bit);
			paras[9].Value = entity.Thu;
			paras[10] = new SqlParameter("@Fri", SqlDbType.Bit);
			paras[10].Value = entity.Fri;
			paras[11] = new SqlParameter("@Sat", SqlDbType.Bit);
			paras[11].Value = entity.Sat;
			paras[12] = new SqlParameter("@Hol", SqlDbType.Bit);
			paras[12].Value = entity.Hol;
			paras[13] = new SqlParameter("@RowVersion", SqlDbType.Timestamp);
			paras[13].Value = entity.RowVersion;
			paras[14] = new SqlParameter("@CreatedOn", SqlDbType.DateTime);
			paras[14].Value = entity.CreatedOn;
			paras[15] = new SqlParameter("@CreatedBy", SqlDbType.VarChar, 30);
			paras[15].Value = entity.CreatedBy;
			paras[16] = new SqlParameter("@ModifiedOn", SqlDbType.DateTime);
			paras[16].Value = entity.ModifiedOn;
			paras[17] = new SqlParameter("@ModifiedBy", SqlDbType.VarChar, 30);
			paras[17].Value = entity.ModifiedBy;
			return base.ExecuteNonQuery(sql, paras);
		}

		private ACIntervalData CreateDataByReader(SafeDataReader reader)
		{
			ACIntervalData data = new ACIntervalData {
				ACIntervalPK = (Guid) reader["ACIntervalPK"],
				BDBuildingPK = (Guid) reader["BDBuildingPK"],
				IVID = (Int16) reader["IVID"],
				Begin = (String) reader["Begin"],
				End = (String) reader["End"],
				Sun = (Boolean) reader["Sun"],
				Mon = (Boolean) reader["Mon"],
				Tue = (Boolean) reader["Tue"],
				Wed = (Boolean) reader["Wed"],
				Thu = (Boolean) reader["Thu"],
				Fri = (Boolean) reader["Fri"],
				Sat = (Boolean) reader["Sat"],
				Hol = (Boolean) reader["Hol"],
				RowVersion = (Byte[]) reader["RowVersion"],
				CreatedOn = (DateTime) reader["CreatedOn"],
				CreatedBy = (String) reader["CreatedBy"],
				ModifiedOn = (DateTime) reader["ModifiedOn"],
				ModifiedBy = (String) reader["ModifiedBy"],
				Address1 = (String) reader["Address1"],
				BuildingID = (Int32) reader["BuildingID"]
			};
			data.AcceptChanges();
			return data;
		}

		private ACIntervalData FetchEntity(string where, SqlParameter[] paras)
		{
			ACIntervalData data = null;
			using (SafeDataReader reader = base.ExecuteDataReader(where, paras))
			{
				if (reader.Read())
				{
					data = this.CreateDataByReader(reader);
				}
				reader.Close();
			}
			return data;
		}

		private ACIntervalData FetchEntityEx(string sql, SqlParameter[] paras)
		{
			ACIntervalData data = null;
			using (SafeDataReader reader = base.ExecuteDataReaderEx(sql, paras))
			{
				if (reader.Read())
				{
					data = this.CreateDataByReader(reader);
				}
				reader.Close();
			}
			return data;
		}

		private ACIntervalDataCollection FetchCollection(string where, SqlParameter[] paras)
		{
			ACIntervalDataCollection list = new ACIntervalDataCollection();
			using (SafeDataReader reader = base.ExecuteDataReader(where, paras))
			{
				while(reader.Read())
				{
					ACIntervalData data = this.CreateDataByReader(reader);
					list.Add(data);
				}
				reader.Close();
			}
			return list;
		}

		private ACIntervalDataCollection FetchCollectionEx(string sql, SqlParameter[] paras)
		{
			ACIntervalDataCollection list = new ACIntervalDataCollection();
			using (SafeDataReader reader = base.ExecuteDataReaderEx(sql, paras))
			{
				while(reader.Read())
				{
					ACIntervalData data = this.CreateDataByReader(reader);
					list.Add(data);
				}
				reader.Close();
			}
			return list;
		}

		public ACIntervalData GetEntityBy(string sqlWhere, SqlParameter[] paras)
		{
			return this.FetchEntity(sqlWhere, paras);
		}

		public ACIntervalData GetEntityExBy(string sql, SqlParameter[] paras)
		{
			return this.FetchEntityEx(sql, paras);
		}

		public ACIntervalDataCollection GetCollectionBy(string sqlWhere, SqlParameter[] paras)
		{
			return this.FetchCollection(sqlWhere, paras);
		}

		public ACIntervalDataCollection GetCollectionExBy(string sql, SqlParameter[] paras)
		{
			return this.FetchCollectionEx(sql, paras);
		}

		public byte[] GetRowVersion( System.Guid ACIntervalPK)
		{
			string sql = string.Format("SELECT [RowVersion] AS [RowVersion] FROM [{0}] WHERE  [ACIntervalPK] = @ACIntervalPK ", this.TableName);
			SqlParameter[] paras = new SqlParameter[1];
			paras[0] = new SqlParameter("@ACIntervalPK", SqlDbType.UniqueIdentifier, 16);
			paras[0].Value = ACIntervalPK;
			return (byte[]) base.ExecuteScalar(sql, paras);
		}

		public ACIntervalData GetByPK( System.Guid ACIntervalPK)
		{
			string sql = " WHERE  [ACInterval].[ACIntervalPK] = @ACIntervalPK ";
			SqlParameter[] paras = new SqlParameter[1];
			paras[0] = new SqlParameter("@ACIntervalPK", SqlDbType.UniqueIdentifier);
			paras[0].Value = ACIntervalPK;
			return this.FetchEntity(sql, paras);
		}

		public ACIntervalDataCollection GetAll()
		{
			return this.FetchCollection("", null);
		}

		public ACIntervalDataCollection GetByBDBuilding(System.Guid BDBuildingPK)
		{
			string sqlWhere = " WHERE [ACInterval].[BDBuildingPK] = @BDBuildingPK";
			SqlParameter[] paras = new SqlParameter[1];
			paras[0] = new SqlParameter("@BDBuildingPK", SqlDbType.UniqueIdentifier);
			paras[0].Value = BDBuildingPK;
			return this.FetchCollection(sqlWhere, paras);
		}

		public DataTable GetLogByPK( System.Guid ACIntervalPK)
		{
			string sql = string.Format("SELECT  [ACInterval].[ACIntervalPK] AS [ACIntervalPK], [ACInterval].[ModifiedOn] AS [ModifiedOn] FROM [{0}] WHERE  [ACInterval].[ACIntervalPK] = @ACIntervalPK ", this.TableName);
			SqlParameter[] paras = new SqlParameter[1];
			paras[0] = new SqlParameter("@ACIntervalPK", SqlDbType.UniqueIdentifier);
			paras[0].Value = ACIntervalPK;
			return this.ExecuteDataTable(sql, paras);
		}

		public DataTable GetLogByBDBuilding(System.Guid bDBuildingPK)
		{
			string sql = string.Format("DELETE [{0}] FROM [{0}] [ACInterval] INNER JOIN [BDBuilding] ON [ACInterval].[BDBuildingPK] = [BDBuilding].[BDBuildingPK] WHERE [BDBuilding].[BDBuildingPK] = @BDBuildingPK;", this.TableName);
			string oldValue = string.Format("DELETE [{0}]", this.TableName);
			string newValue = "SELECT  [ACInterval].[ACIntervalPK] AS [ACIntervalPK], [ACInterval].[ModifiedOn] AS [ModifiedOn]";
			sql = sql.Replace(oldValue, newValue).TrimEnd().TrimEnd(';').Replace(";", " UNION ");
			SqlParameter[] paras = new SqlParameter[1];
			paras[0] = new SqlParameter("@BDBuildingPK", SqlDbType.UniqueIdentifier);
			paras[0].Value = bDBuildingPK;
			return base.ExecuteDataTable(sql, paras);
		}

		public int DeleteByPK( System.Guid ACIntervalPK, byte[] RowVersion)
		{
			string sql = string.Format("DELETE FROM [{0}] WHERE  [ACIntervalPK] = @ACIntervalPK AND [RowVersion] = @RowVersion", this.TableName);
			SqlParameter[] paras = new SqlParameter[2];
			paras[0] = new SqlParameter("@ACIntervalPK", SqlDbType.UniqueIdentifier);
			paras[0].Value = ACIntervalPK;
			paras[1] = new SqlParameter("@RowVersion", SqlDbType.Timestamp, 8);
			paras[1].Value = RowVersion;
			return base.ExecuteNonQuery(sql, paras);
		}

		public int DeleteAll()
		{
			string sql = string.Format("DELETE FROM [{0}]", this.TableName);
			return base.ExecuteNonQuery(sql, null);
		}

		public int DeleteByBDBuilding(System.Guid bDBuildingPK)
		{
			string sql = string.Format("DELETE [{0}] FROM [{0}] [ACInterval] INNER JOIN [BDBuilding] ON [ACInterval].[BDBuildingPK] = [BDBuilding].[BDBuildingPK] WHERE [BDBuilding].[BDBuildingPK] = @BDBuildingPK;", this.TableName);
			SqlParameter[] paras = new SqlParameter[1];
			paras[0] = new SqlParameter("@BDBuildingPK", SqlDbType.UniqueIdentifier);
			paras[0].Value = bDBuildingPK;
			return base.ExecuteNonQuery(sql, paras);
		}


	}
	public class ACPanelHolidayMapCRUD : DataAccessBase
	{
		private string _tableName = "ACPanelHolidayMap";

		public ACPanelHolidayMapCRUD(string connectionString) : base(connectionString)
		{
		}

		public virtual string TableName
		{
			get { return this._tableName; }
			set { this._tableName = value; }
		}

		public string SQLColumns
		{
			get
			{
				return "[ACPanelHolidayMap].[ACPanelHolidayMapPK] AS [ACPanelHolidayMapPK],[ACPanelHolidayMap].[ACPanelPK] AS [ACPanelPK],[ACPanelHolidayMap].[UtilHolidayPK] AS [UtilHolidayPK],[ACPanelHolidayMap].[RowVersion] AS [RowVersion],[ACPanelHolidayMap].[CreatedOn] AS [CreatedOn],[ACPanelHolidayMap].[CreatedBy] AS [CreatedBy],[ACPanelHolidayMap].[ModifiedOn] AS [ModifiedOn],[ACPanelHolidayMap].[ModifiedBy] AS [ModifiedBy],[UtilHoliday].[Date] AS [Date],[UtilHoliday].[Holiday] AS [Holiday],[ACPanel].[BDBuildingPK] AS [BDBuildingPK],[ACPanel].[UnitID] AS [UnitID],[BDBuilding].[Address1] AS [Address1],[BDBuilding].[BuildingID] AS [BuildingID]";
			}
		}

		public string SQLLeftJoins
		{
			get
			{
				return "LEFT JOIN [UtilHoliday] [UtilHoliday] ON [ACPanelHolidayMap].[UtilHolidayPK] = [UtilHoliday].[UtilHolidayPK] LEFT JOIN [ACPanel] [ACPanel] ON [ACPanelHolidayMap].[ACPanelPK] = [ACPanel].[ACPanelPK] LEFT JOIN [BDBuilding] [BDBuilding] ON [ACPanel].[BDBuildingPK] = [BDBuilding].[BDBuildingPK]";
			}
		}

		protected override string SQLSelect
		{
			get
			{
				return string.Format("SELECT [ACPanelHolidayMap].[ACPanelHolidayMapPK] AS [ACPanelHolidayMapPK],[ACPanelHolidayMap].[ACPanelPK] AS [ACPanelPK],[ACPanelHolidayMap].[UtilHolidayPK] AS [UtilHolidayPK],[ACPanelHolidayMap].[RowVersion] AS [RowVersion],[ACPanelHolidayMap].[CreatedOn] AS [CreatedOn],[ACPanelHolidayMap].[CreatedBy] AS [CreatedBy],[ACPanelHolidayMap].[ModifiedOn] AS [ModifiedOn],[ACPanelHolidayMap].[ModifiedBy] AS [ModifiedBy],[UtilHoliday].[Date] AS [Date],[UtilHoliday].[Holiday] AS [Holiday],[ACPanel].[BDBuildingPK] AS [BDBuildingPK],[ACPanel].[UnitID] AS [UnitID],[BDBuilding].[Address1] AS [Address1],[BDBuilding].[BuildingID] AS [BuildingID] FROM [{0}] [ACPanelHolidayMap] LEFT JOIN [UtilHoliday] [UtilHoliday] ON [ACPanelHolidayMap].[UtilHolidayPK] = [UtilHoliday].[UtilHolidayPK] LEFT JOIN [ACPanel] [ACPanel] ON [ACPanelHolidayMap].[ACPanelPK] = [ACPanel].[ACPanelPK] LEFT JOIN [BDBuilding] [BDBuilding] ON [ACPanel].[BDBuildingPK] = [BDBuilding].[BDBuildingPK]", this.TableName);
			}
		}

		protected override string SQLCount
		{
			get
			{
				return string.Format("SELECT COUNT(*) FROM [{0}] [ACPanelHolidayMap] LEFT JOIN [UtilHoliday] [UtilHoliday] ON [ACPanelHolidayMap].[UtilHolidayPK] = [UtilHoliday].[UtilHolidayPK] LEFT JOIN [ACPanel] [ACPanel] ON [ACPanelHolidayMap].[ACPanelPK] = [ACPanel].[ACPanelPK] LEFT JOIN [BDBuilding] [BDBuilding] ON [ACPanel].[BDBuildingPK] = [BDBuilding].[BDBuildingPK]", this.TableName);
			}
		}

		public int Insert(ACPanelHolidayMapData entity)
		{
			string sql = string.Format("INSERT INTO [{0}] ([ACPanelHolidayMapPK],[ACPanelPK],[UtilHolidayPK],[CreatedOn],[CreatedBy],[ModifiedOn],[ModifiedBy]) VALUES(@ACPanelHolidayMapPK,@ACPanelPK,@UtilHolidayPK,@CreatedOn,@CreatedBy,@ModifiedOn,@ModifiedBy)", this.TableName);
			SqlParameter[] paras = new SqlParameter[7];
			paras[0] = new SqlParameter("@ACPanelHolidayMapPK", SqlDbType.UniqueIdentifier);
			if (entity.ACPanelHolidayMapPK == Guid.Empty)
			{
				paras[0].Value = DBNull.Value;
			}
			else
			{
				paras[0].Value = entity.ACPanelHolidayMapPK;
			}
			paras[1] = new SqlParameter("@ACPanelPK", SqlDbType.UniqueIdentifier);
			if (entity.ACPanelPK == Guid.Empty)
			{
				paras[1].Value = DBNull.Value;
			}
			else
			{
				paras[1].Value = entity.ACPanelPK;
			}
			paras[2] = new SqlParameter("@UtilHolidayPK", SqlDbType.UniqueIdentifier);
			if (entity.UtilHolidayPK == Guid.Empty)
			{
				paras[2].Value = DBNull.Value;
			}
			else
			{
				paras[2].Value = entity.UtilHolidayPK;
			}
			paras[3] = new SqlParameter("@CreatedOn", SqlDbType.DateTime);
			paras[3].Value = entity.CreatedOn;
			paras[4] = new SqlParameter("@CreatedBy", SqlDbType.VarChar, 30);
			paras[4].Value = entity.CreatedBy;
			paras[5] = new SqlParameter("@ModifiedOn", SqlDbType.DateTime);
			paras[5].Value = entity.ModifiedOn;
			paras[6] = new SqlParameter("@ModifiedBy", SqlDbType.VarChar, 30);
			paras[6].Value = entity.ModifiedBy;
			return base.ExecuteNonQuery(sql, paras);
		}

		public int Update(ACPanelHolidayMapData entity)
		{
			string sql = string.Format("UPDATE [{0}] SET [ACPanelPK] = @ACPanelPK,[UtilHolidayPK] = @UtilHolidayPK,[CreatedOn] = @CreatedOn,[CreatedBy] = @CreatedBy,[ModifiedOn] = @ModifiedOn,[ModifiedBy] = @ModifiedBy  WHERE [ACPanelHolidayMapPK] = @ACPanelHolidayMapPK AND [RowVersion] = @RowVersion", this.TableName);
			SqlParameter[] paras = new SqlParameter[8];
			paras[0] = new SqlParameter("@ACPanelHolidayMapPK", SqlDbType.UniqueIdentifier);
			if (entity.ACPanelHolidayMapPK == Guid.Empty)
			{
				paras[0].Value = DBNull.Value;
			}
			else
			{
				paras[0].Value = entity.ACPanelHolidayMapPK;
			}
			paras[1] = new SqlParameter("@ACPanelPK", SqlDbType.UniqueIdentifier);
			if (entity.ACPanelPK == Guid.Empty)
			{
				paras[1].Value = DBNull.Value;
			}
			else
			{
				paras[1].Value = entity.ACPanelPK;
			}
			paras[2] = new SqlParameter("@UtilHolidayPK", SqlDbType.UniqueIdentifier);
			if (entity.UtilHolidayPK == Guid.Empty)
			{
				paras[2].Value = DBNull.Value;
			}
			else
			{
				paras[2].Value = entity.UtilHolidayPK;
			}
			paras[3] = new SqlParameter("@RowVersion", SqlDbType.Timestamp);
			paras[3].Value = entity.RowVersion;
			paras[4] = new SqlParameter("@CreatedOn", SqlDbType.DateTime);
			paras[4].Value = entity.CreatedOn;
			paras[5] = new SqlParameter("@CreatedBy", SqlDbType.VarChar, 30);
			paras[5].Value = entity.CreatedBy;
			paras[6] = new SqlParameter("@ModifiedOn", SqlDbType.DateTime);
			paras[6].Value = entity.ModifiedOn;
			paras[7] = new SqlParameter("@ModifiedBy", SqlDbType.VarChar, 30);
			paras[7].Value = entity.ModifiedBy;
			return base.ExecuteNonQuery(sql, paras);
		}

		private ACPanelHolidayMapData CreateDataByReader(SafeDataReader reader)
		{
			ACPanelHolidayMapData data = new ACPanelHolidayMapData {
				ACPanelHolidayMapPK = (Guid) reader["ACPanelHolidayMapPK"],
				ACPanelPK = (Guid) reader["ACPanelPK"],
				UtilHolidayPK = (Guid) reader["UtilHolidayPK"],
				RowVersion = (Byte[]) reader["RowVersion"],
				CreatedOn = (DateTime) reader["CreatedOn"],
				CreatedBy = (String) reader["CreatedBy"],
				ModifiedOn = (DateTime) reader["ModifiedOn"],
				ModifiedBy = (String) reader["ModifiedBy"],
				Date = (DateTime) reader["Date"],
				Holiday = (String) reader["Holiday"],
				BDBuildingPK = (Guid) reader["BDBuildingPK"],
				UnitID = (Int32) reader["UnitID"],
				Address1 = (String) reader["Address1"],
				BuildingID = (Int32) reader["BuildingID"]
			};
			data.AcceptChanges();
			return data;
		}

		private ACPanelHolidayMapData FetchEntity(string where, SqlParameter[] paras)
		{
			ACPanelHolidayMapData data = null;
			using (SafeDataReader reader = base.ExecuteDataReader(where, paras))
			{
				if (reader.Read())
				{
					data = this.CreateDataByReader(reader);
				}
				reader.Close();
			}
			return data;
		}

		private ACPanelHolidayMapData FetchEntityEx(string sql, SqlParameter[] paras)
		{
			ACPanelHolidayMapData data = null;
			using (SafeDataReader reader = base.ExecuteDataReaderEx(sql, paras))
			{
				if (reader.Read())
				{
					data = this.CreateDataByReader(reader);
				}
				reader.Close();
			}
			return data;
		}

		private ACPanelHolidayMapDataCollection FetchCollection(string where, SqlParameter[] paras)
		{
			ACPanelHolidayMapDataCollection list = new ACPanelHolidayMapDataCollection();
			using (SafeDataReader reader = base.ExecuteDataReader(where, paras))
			{
				while(reader.Read())
				{
					ACPanelHolidayMapData data = this.CreateDataByReader(reader);
					list.Add(data);
				}
				reader.Close();
			}
			return list;
		}

		private ACPanelHolidayMapDataCollection FetchCollectionEx(string sql, SqlParameter[] paras)
		{
			ACPanelHolidayMapDataCollection list = new ACPanelHolidayMapDataCollection();
			using (SafeDataReader reader = base.ExecuteDataReaderEx(sql, paras))
			{
				while(reader.Read())
				{
					ACPanelHolidayMapData data = this.CreateDataByReader(reader);
					list.Add(data);
				}
				reader.Close();
			}
			return list;
		}

		public ACPanelHolidayMapData GetEntityBy(string sqlWhere, SqlParameter[] paras)
		{
			return this.FetchEntity(sqlWhere, paras);
		}

		public ACPanelHolidayMapData GetEntityExBy(string sql, SqlParameter[] paras)
		{
			return this.FetchEntityEx(sql, paras);
		}

		public ACPanelHolidayMapDataCollection GetCollectionBy(string sqlWhere, SqlParameter[] paras)
		{
			return this.FetchCollection(sqlWhere, paras);
		}

		public ACPanelHolidayMapDataCollection GetCollectionExBy(string sql, SqlParameter[] paras)
		{
			return this.FetchCollectionEx(sql, paras);
		}

		public byte[] GetRowVersion( System.Guid ACPanelHolidayMapPK)
		{
			string sql = string.Format("SELECT [RowVersion] AS [RowVersion] FROM [{0}] WHERE  [ACPanelHolidayMapPK] = @ACPanelHolidayMapPK ", this.TableName);
			SqlParameter[] paras = new SqlParameter[1];
			paras[0] = new SqlParameter("@ACPanelHolidayMapPK", SqlDbType.UniqueIdentifier, 16);
			paras[0].Value = ACPanelHolidayMapPK;
			return (byte[]) base.ExecuteScalar(sql, paras);
		}

		public ACPanelHolidayMapData GetByPK( System.Guid ACPanelHolidayMapPK)
		{
			string sql = " WHERE  [ACPanelHolidayMap].[ACPanelHolidayMapPK] = @ACPanelHolidayMapPK ";
			SqlParameter[] paras = new SqlParameter[1];
			paras[0] = new SqlParameter("@ACPanelHolidayMapPK", SqlDbType.UniqueIdentifier);
			paras[0].Value = ACPanelHolidayMapPK;
			return this.FetchEntity(sql, paras);
		}

		public ACPanelHolidayMapDataCollection GetAll()
		{
			return this.FetchCollection("", null);
		}

		public ACPanelHolidayMapDataCollection GetByUtilHoliday(System.Guid UtilHolidayPK)
		{
			string sqlWhere = " WHERE [ACPanelHolidayMap].[UtilHolidayPK] = @UtilHolidayPK";
			SqlParameter[] paras = new SqlParameter[1];
			paras[0] = new SqlParameter("@UtilHolidayPK", SqlDbType.UniqueIdentifier);
			paras[0].Value = UtilHolidayPK;
			return this.FetchCollection(sqlWhere, paras);
		}

		public ACPanelHolidayMapDataCollection GetByACPanel(System.Guid ACPanelPK)
		{
			string sqlWhere = " WHERE [ACPanelHolidayMap].[ACPanelPK] = @ACPanelPK";
			SqlParameter[] paras = new SqlParameter[1];
			paras[0] = new SqlParameter("@ACPanelPK", SqlDbType.UniqueIdentifier);
			paras[0].Value = ACPanelPK;
			return this.FetchCollection(sqlWhere, paras);
		}

		public DataTable GetLogByPK( System.Guid ACPanelHolidayMapPK)
		{
			string sql = string.Format("SELECT  [ACPanelHolidayMap].[ACPanelHolidayMapPK] AS [ACPanelHolidayMapPK], [ACPanelHolidayMap].[ModifiedOn] AS [ModifiedOn] FROM [{0}] WHERE  [ACPanelHolidayMap].[ACPanelHolidayMapPK] = @ACPanelHolidayMapPK ", this.TableName);
			SqlParameter[] paras = new SqlParameter[1];
			paras[0] = new SqlParameter("@ACPanelHolidayMapPK", SqlDbType.UniqueIdentifier);
			paras[0].Value = ACPanelHolidayMapPK;
			return this.ExecuteDataTable(sql, paras);
		}

		public DataTable GetLogByUtilHoliday(System.Guid utilHolidayPK)
		{
			string sql = string.Format("DELETE [{0}] FROM [{0}] [ACPanelHolidayMap] INNER JOIN [UtilHoliday] ON [ACPanelHolidayMap].[UtilHolidayPK] = [UtilHoliday].[UtilHolidayPK] WHERE [UtilHoliday].[UtilHolidayPK] = @UtilHolidayPK;", this.TableName);
			string oldValue = string.Format("DELETE [{0}]", this.TableName);
			string newValue = "SELECT  [ACPanelHolidayMap].[ACPanelHolidayMapPK] AS [ACPanelHolidayMapPK], [ACPanelHolidayMap].[ModifiedOn] AS [ModifiedOn]";
			sql = sql.Replace(oldValue, newValue).TrimEnd().TrimEnd(';').Replace(";", " UNION ");
			SqlParameter[] paras = new SqlParameter[1];
			paras[0] = new SqlParameter("@UtilHolidayPK", SqlDbType.UniqueIdentifier);
			paras[0].Value = utilHolidayPK;
			return base.ExecuteDataTable(sql, paras);
		}

		public DataTable GetLogByACPanel(System.Guid aCPanelPK)
		{
			string sql = string.Format("DELETE [{0}] FROM [{0}] [ACPanelHolidayMap] INNER JOIN [ACPanel] ON [ACPanelHolidayMap].[ACPanelPK] = [ACPanel].[ACPanelPK] WHERE [ACPanel].[ACPanelPK] = @ACPanelPK;", this.TableName);
			string oldValue = string.Format("DELETE [{0}]", this.TableName);
			string newValue = "SELECT  [ACPanelHolidayMap].[ACPanelHolidayMapPK] AS [ACPanelHolidayMapPK], [ACPanelHolidayMap].[ModifiedOn] AS [ModifiedOn]";
			sql = sql.Replace(oldValue, newValue).TrimEnd().TrimEnd(';').Replace(";", " UNION ");
			SqlParameter[] paras = new SqlParameter[1];
			paras[0] = new SqlParameter("@ACPanelPK", SqlDbType.UniqueIdentifier);
			paras[0].Value = aCPanelPK;
			return base.ExecuteDataTable(sql, paras);
		}

		public DataTable GetLogByBDBuilding(System.Guid bDBuildingPK)
		{
			string sql = string.Format("DELETE [{0}] FROM [{0}] [ACPanelHolidayMap] INNER JOIN [ACPanel] ON [ACPanelHolidayMap].[ACPanelPK] = [ACPanel].[ACPanelPK] INNER JOIN [BDBuilding] ON [ACPanel].[BDBuildingPK] = [BDBuilding].[BDBuildingPK] WHERE [BDBuilding].[BDBuildingPK] = @BDBuildingPK;", this.TableName);
			string oldValue = string.Format("DELETE [{0}]", this.TableName);
			string newValue = "SELECT  [ACPanelHolidayMap].[ACPanelHolidayMapPK] AS [ACPanelHolidayMapPK], [ACPanelHolidayMap].[ModifiedOn] AS [ModifiedOn]";
			sql = sql.Replace(oldValue, newValue).TrimEnd().TrimEnd(';').Replace(";", " UNION ");
			SqlParameter[] paras = new SqlParameter[1];
			paras[0] = new SqlParameter("@BDBuildingPK", SqlDbType.UniqueIdentifier);
			paras[0].Value = bDBuildingPK;
			return base.ExecuteDataTable(sql, paras);
		}

		public int DeleteByPK( System.Guid ACPanelHolidayMapPK, byte[] RowVersion)
		{
			string sql = string.Format("DELETE FROM [{0}] WHERE  [ACPanelHolidayMapPK] = @ACPanelHolidayMapPK AND [RowVersion] = @RowVersion", this.TableName);
			SqlParameter[] paras = new SqlParameter[2];
			paras[0] = new SqlParameter("@ACPanelHolidayMapPK", SqlDbType.UniqueIdentifier);
			paras[0].Value = ACPanelHolidayMapPK;
			paras[1] = new SqlParameter("@RowVersion", SqlDbType.Timestamp, 8);
			paras[1].Value = RowVersion;
			return base.ExecuteNonQuery(sql, paras);
		}

		public int DeleteAll()
		{
			string sql = string.Format("DELETE FROM [{0}]", this.TableName);
			return base.ExecuteNonQuery(sql, null);
		}

		public int DeleteByUtilHoliday(System.Guid utilHolidayPK)
		{
			string sql = string.Format("DELETE [{0}] FROM [{0}] [ACPanelHolidayMap] INNER JOIN [UtilHoliday] ON [ACPanelHolidayMap].[UtilHolidayPK] = [UtilHoliday].[UtilHolidayPK] WHERE [UtilHoliday].[UtilHolidayPK] = @UtilHolidayPK;", this.TableName);
			SqlParameter[] paras = new SqlParameter[1];
			paras[0] = new SqlParameter("@UtilHolidayPK", SqlDbType.UniqueIdentifier);
			paras[0].Value = utilHolidayPK;
			return base.ExecuteNonQuery(sql, paras);
		}

		public int DeleteByACPanel(System.Guid aCPanelPK)
		{
			string sql = string.Format("DELETE [{0}] FROM [{0}] [ACPanelHolidayMap] INNER JOIN [ACPanel] ON [ACPanelHolidayMap].[ACPanelPK] = [ACPanel].[ACPanelPK] WHERE [ACPanel].[ACPanelPK] = @ACPanelPK;", this.TableName);
			SqlParameter[] paras = new SqlParameter[1];
			paras[0] = new SqlParameter("@ACPanelPK", SqlDbType.UniqueIdentifier);
			paras[0].Value = aCPanelPK;
			return base.ExecuteNonQuery(sql, paras);
		}

		public int DeleteByBDBuilding(System.Guid bDBuildingPK)
		{
			string sql = string.Format("DELETE [{0}] FROM [{0}] [ACPanelHolidayMap] INNER JOIN [ACPanel] ON [ACPanelHolidayMap].[ACPanelPK] = [ACPanel].[ACPanelPK] INNER JOIN [BDBuilding] ON [ACPanel].[BDBuildingPK] = [BDBuilding].[BDBuildingPK] WHERE [BDBuilding].[BDBuildingPK] = @BDBuildingPK;", this.TableName);
			SqlParameter[] paras = new SqlParameter[1];
			paras[0] = new SqlParameter("@BDBuildingPK", SqlDbType.UniqueIdentifier);
			paras[0].Value = bDBuildingPK;
			return base.ExecuteNonQuery(sql, paras);
		}


	}
	public class ACTimecodeCRUD : DataAccessBase
	{
		private string _tableName = "ACTimecode";

		public ACTimecodeCRUD(string connectionString) : base(connectionString)
		{
		}

		public virtual string TableName
		{
			get { return this._tableName; }
			set { this._tableName = value; }
		}

		public string SQLColumns
		{
			get
			{
				return "[ACTimecode].[ACTimecodePK] AS [ACTimecodePK],[ACTimecode].[BDBuildingPK] AS [BDBuildingPK],[ACTimecode].[TCID] AS [TCID],[ACTimecode].[Summary] AS [Summary],[ACTimecode].[Notes] AS [Notes],[ACTimecode].[RowVersion] AS [RowVersion],[ACTimecode].[CreatedOn] AS [CreatedOn],[ACTimecode].[CreatedBy] AS [CreatedBy],[ACTimecode].[ModifiedOn] AS [ModifiedOn],[ACTimecode].[ModifiedBy] AS [ModifiedBy],[BDBuilding].[Address1] AS [Address1],[BDBuilding].[BuildingID] AS [BuildingID]";
			}
		}

		public string SQLLeftJoins
		{
			get
			{
				return "LEFT JOIN [BDBuilding] [BDBuilding] ON [ACTimecode].[BDBuildingPK] = [BDBuilding].[BDBuildingPK]";
			}
		}

		protected override string SQLSelect
		{
			get
			{
				return string.Format("SELECT [ACTimecode].[ACTimecodePK] AS [ACTimecodePK],[ACTimecode].[BDBuildingPK] AS [BDBuildingPK],[ACTimecode].[TCID] AS [TCID],[ACTimecode].[Summary] AS [Summary],[ACTimecode].[Notes] AS [Notes],[ACTimecode].[RowVersion] AS [RowVersion],[ACTimecode].[CreatedOn] AS [CreatedOn],[ACTimecode].[CreatedBy] AS [CreatedBy],[ACTimecode].[ModifiedOn] AS [ModifiedOn],[ACTimecode].[ModifiedBy] AS [ModifiedBy],[BDBuilding].[Address1] AS [Address1],[BDBuilding].[BuildingID] AS [BuildingID] FROM [{0}] [ACTimecode] LEFT JOIN [BDBuilding] [BDBuilding] ON [ACTimecode].[BDBuildingPK] = [BDBuilding].[BDBuildingPK]", this.TableName);
			}
		}

		protected override string SQLCount
		{
			get
			{
				return string.Format("SELECT COUNT(*) FROM [{0}] [ACTimecode] LEFT JOIN [BDBuilding] [BDBuilding] ON [ACTimecode].[BDBuildingPK] = [BDBuilding].[BDBuildingPK]", this.TableName);
			}
		}

		public int Insert(ACTimecodeData entity)
		{
			string sql = string.Format("INSERT INTO [{0}] ([ACTimecodePK],[BDBuildingPK],[TCID],[Summary],[Notes],[CreatedOn],[CreatedBy],[ModifiedOn],[ModifiedBy]) VALUES(@ACTimecodePK,@BDBuildingPK,@TCID,@Summary,@Notes,@CreatedOn,@CreatedBy,@ModifiedOn,@ModifiedBy)", this.TableName);
			SqlParameter[] paras = new SqlParameter[9];
			paras[0] = new SqlParameter("@ACTimecodePK", SqlDbType.UniqueIdentifier);
			if (entity.ACTimecodePK == Guid.Empty)
			{
				paras[0].Value = DBNull.Value;
			}
			else
			{
				paras[0].Value = entity.ACTimecodePK;
			}
			paras[1] = new SqlParameter("@BDBuildingPK", SqlDbType.UniqueIdentifier);
			if (entity.BDBuildingPK == Guid.Empty)
			{
				paras[1].Value = DBNull.Value;
			}
			else
			{
				paras[1].Value = entity.BDBuildingPK;
			}
			paras[2] = new SqlParameter("@TCID", SqlDbType.SmallInt);
			paras[2].Value = entity.TCID;
			paras[3] = new SqlParameter("@Summary", SqlDbType.VarChar, 256);
			paras[3].Value = entity.Summary;
			paras[4] = new SqlParameter("@Notes", SqlDbType.VarChar, 512);
			paras[4].Value = entity.Notes;
			paras[5] = new SqlParameter("@CreatedOn", SqlDbType.DateTime);
			paras[5].Value = entity.CreatedOn;
			paras[6] = new SqlParameter("@CreatedBy", SqlDbType.VarChar, 30);
			paras[6].Value = entity.CreatedBy;
			paras[7] = new SqlParameter("@ModifiedOn", SqlDbType.DateTime);
			paras[7].Value = entity.ModifiedOn;
			paras[8] = new SqlParameter("@ModifiedBy", SqlDbType.VarChar, 30);
			paras[8].Value = entity.ModifiedBy;
			return base.ExecuteNonQuery(sql, paras);
		}

		public int Update(ACTimecodeData entity)
		{
			string sql = string.Format("UPDATE [{0}] SET [BDBuildingPK] = @BDBuildingPK,[TCID] = @TCID,[Summary] = @Summary,[Notes] = @Notes,[CreatedOn] = @CreatedOn,[CreatedBy] = @CreatedBy,[ModifiedOn] = @ModifiedOn,[ModifiedBy] = @ModifiedBy  WHERE [ACTimecodePK] = @ACTimecodePK AND [RowVersion] = @RowVersion", this.TableName);
			SqlParameter[] paras = new SqlParameter[10];
			paras[0] = new SqlParameter("@ACTimecodePK", SqlDbType.UniqueIdentifier);
			if (entity.ACTimecodePK == Guid.Empty)
			{
				paras[0].Value = DBNull.Value;
			}
			else
			{
				paras[0].Value = entity.ACTimecodePK;
			}
			paras[1] = new SqlParameter("@BDBuildingPK", SqlDbType.UniqueIdentifier);
			if (entity.BDBuildingPK == Guid.Empty)
			{
				paras[1].Value = DBNull.Value;
			}
			else
			{
				paras[1].Value = entity.BDBuildingPK;
			}
			paras[2] = new SqlParameter("@TCID", SqlDbType.SmallInt);
			paras[2].Value = entity.TCID;
			paras[3] = new SqlParameter("@Summary", SqlDbType.VarChar, 256);
			paras[3].Value = entity.Summary;
			paras[4] = new SqlParameter("@Notes", SqlDbType.VarChar, 512);
			paras[4].Value = entity.Notes;
			paras[5] = new SqlParameter("@RowVersion", SqlDbType.Timestamp);
			paras[5].Value = entity.RowVersion;
			paras[6] = new SqlParameter("@CreatedOn", SqlDbType.DateTime);
			paras[6].Value = entity.CreatedOn;
			paras[7] = new SqlParameter("@CreatedBy", SqlDbType.VarChar, 30);
			paras[7].Value = entity.CreatedBy;
			paras[8] = new SqlParameter("@ModifiedOn", SqlDbType.DateTime);
			paras[8].Value = entity.ModifiedOn;
			paras[9] = new SqlParameter("@ModifiedBy", SqlDbType.VarChar, 30);
			paras[9].Value = entity.ModifiedBy;
			return base.ExecuteNonQuery(sql, paras);
		}

		private ACTimecodeData CreateDataByReader(SafeDataReader reader)
		{
			ACTimecodeData data = new ACTimecodeData {
				ACTimecodePK = (Guid) reader["ACTimecodePK"],
				BDBuildingPK = (Guid) reader["BDBuildingPK"],
				TCID = (Int16) reader["TCID"],
				Summary = (String) reader["Summary"],
				Notes = (String) reader["Notes"],
				RowVersion = (Byte[]) reader["RowVersion"],
				CreatedOn = (DateTime) reader["CreatedOn"],
				CreatedBy = (String) reader["CreatedBy"],
				ModifiedOn = (DateTime) reader["ModifiedOn"],
				ModifiedBy = (String) reader["ModifiedBy"],
				Address1 = (String) reader["Address1"],
				BuildingID = (Int32) reader["BuildingID"]
			};
			data.AcceptChanges();
			return data;
		}

		private ACTimecodeData FetchEntity(string where, SqlParameter[] paras)
		{
			ACTimecodeData data = null;
			using (SafeDataReader reader = base.ExecuteDataReader(where, paras))
			{
				if (reader.Read())
				{
					data = this.CreateDataByReader(reader);
				}
				reader.Close();
			}
			return data;
		}

		private ACTimecodeData FetchEntityEx(string sql, SqlParameter[] paras)
		{
			ACTimecodeData data = null;
			using (SafeDataReader reader = base.ExecuteDataReaderEx(sql, paras))
			{
				if (reader.Read())
				{
					data = this.CreateDataByReader(reader);
				}
				reader.Close();
			}
			return data;
		}

		private ACTimecodeDataCollection FetchCollection(string where, SqlParameter[] paras)
		{
			ACTimecodeDataCollection list = new ACTimecodeDataCollection();
			using (SafeDataReader reader = base.ExecuteDataReader(where, paras))
			{
				while(reader.Read())
				{
					ACTimecodeData data = this.CreateDataByReader(reader);
					list.Add(data);
				}
				reader.Close();
			}
			return list;
		}

		private ACTimecodeDataCollection FetchCollectionEx(string sql, SqlParameter[] paras)
		{
			ACTimecodeDataCollection list = new ACTimecodeDataCollection();
			using (SafeDataReader reader = base.ExecuteDataReaderEx(sql, paras))
			{
				while(reader.Read())
				{
					ACTimecodeData data = this.CreateDataByReader(reader);
					list.Add(data);
				}
				reader.Close();
			}
			return list;
		}

		public ACTimecodeData GetEntityBy(string sqlWhere, SqlParameter[] paras)
		{
			return this.FetchEntity(sqlWhere, paras);
		}

		public ACTimecodeData GetEntityExBy(string sql, SqlParameter[] paras)
		{
			return this.FetchEntityEx(sql, paras);
		}

		public ACTimecodeDataCollection GetCollectionBy(string sqlWhere, SqlParameter[] paras)
		{
			return this.FetchCollection(sqlWhere, paras);
		}

		public ACTimecodeDataCollection GetCollectionExBy(string sql, SqlParameter[] paras)
		{
			return this.FetchCollectionEx(sql, paras);
		}

		public byte[] GetRowVersion( System.Guid ACTimecodePK)
		{
			string sql = string.Format("SELECT [RowVersion] AS [RowVersion] FROM [{0}] WHERE  [ACTimecodePK] = @ACTimecodePK ", this.TableName);
			SqlParameter[] paras = new SqlParameter[1];
			paras[0] = new SqlParameter("@ACTimecodePK", SqlDbType.UniqueIdentifier, 16);
			paras[0].Value = ACTimecodePK;
			return (byte[]) base.ExecuteScalar(sql, paras);
		}

		public ACTimecodeData GetByPK( System.Guid ACTimecodePK)
		{
			string sql = " WHERE  [ACTimecode].[ACTimecodePK] = @ACTimecodePK ";
			SqlParameter[] paras = new SqlParameter[1];
			paras[0] = new SqlParameter("@ACTimecodePK", SqlDbType.UniqueIdentifier);
			paras[0].Value = ACTimecodePK;
			return this.FetchEntity(sql, paras);
		}

		public ACTimecodeDataCollection GetAll()
		{
			return this.FetchCollection("", null);
		}

		public ACTimecodeDataCollection GetByBDBuilding(System.Guid BDBuildingPK)
		{
			string sqlWhere = " WHERE [ACTimecode].[BDBuildingPK] = @BDBuildingPK";
			SqlParameter[] paras = new SqlParameter[1];
			paras[0] = new SqlParameter("@BDBuildingPK", SqlDbType.UniqueIdentifier);
			paras[0].Value = BDBuildingPK;
			return this.FetchCollection(sqlWhere, paras);
		}

		public DataTable GetLogByPK( System.Guid ACTimecodePK)
		{
			string sql = string.Format("SELECT  [ACTimecode].[ACTimecodePK] AS [ACTimecodePK], [ACTimecode].[ModifiedOn] AS [ModifiedOn] FROM [{0}] WHERE  [ACTimecode].[ACTimecodePK] = @ACTimecodePK ", this.TableName);
			SqlParameter[] paras = new SqlParameter[1];
			paras[0] = new SqlParameter("@ACTimecodePK", SqlDbType.UniqueIdentifier);
			paras[0].Value = ACTimecodePK;
			return this.ExecuteDataTable(sql, paras);
		}

		public DataTable GetLogByBDBuilding(System.Guid bDBuildingPK)
		{
			string sql = string.Format("DELETE [{0}] FROM [{0}] [ACTimecode] INNER JOIN [BDBuilding] ON [ACTimecode].[BDBuildingPK] = [BDBuilding].[BDBuildingPK] WHERE [BDBuilding].[BDBuildingPK] = @BDBuildingPK;", this.TableName);
			string oldValue = string.Format("DELETE [{0}]", this.TableName);
			string newValue = "SELECT  [ACTimecode].[ACTimecodePK] AS [ACTimecodePK], [ACTimecode].[ModifiedOn] AS [ModifiedOn]";
			sql = sql.Replace(oldValue, newValue).TrimEnd().TrimEnd(';').Replace(";", " UNION ");
			SqlParameter[] paras = new SqlParameter[1];
			paras[0] = new SqlParameter("@BDBuildingPK", SqlDbType.UniqueIdentifier);
			paras[0].Value = bDBuildingPK;
			return base.ExecuteDataTable(sql, paras);
		}

		public int DeleteByPK( System.Guid ACTimecodePK, byte[] RowVersion)
		{
			string sql = string.Format("DELETE FROM [{0}] WHERE  [ACTimecodePK] = @ACTimecodePK AND [RowVersion] = @RowVersion", this.TableName);
			SqlParameter[] paras = new SqlParameter[2];
			paras[0] = new SqlParameter("@ACTimecodePK", SqlDbType.UniqueIdentifier);
			paras[0].Value = ACTimecodePK;
			paras[1] = new SqlParameter("@RowVersion", SqlDbType.Timestamp, 8);
			paras[1].Value = RowVersion;
			return base.ExecuteNonQuery(sql, paras);
		}

		public int DeleteAll()
		{
			string sql = string.Format("DELETE FROM [{0}]", this.TableName);
			return base.ExecuteNonQuery(sql, null);
		}

		public int DeleteByBDBuilding(System.Guid bDBuildingPK)
		{
			string sql = string.Format("DELETE [{0}] FROM [{0}] [ACTimecode] INNER JOIN [BDBuilding] ON [ACTimecode].[BDBuildingPK] = [BDBuilding].[BDBuildingPK] WHERE [BDBuilding].[BDBuildingPK] = @BDBuildingPK;", this.TableName);
			SqlParameter[] paras = new SqlParameter[1];
			paras[0] = new SqlParameter("@BDBuildingPK", SqlDbType.UniqueIdentifier);
			paras[0].Value = bDBuildingPK;
			return base.ExecuteNonQuery(sql, paras);
		}


	}
	public class ACTimecodeIntervalMapCRUD : DataAccessBase
	{
		private string _tableName = "ACTimecodeIntervalMap";

		public ACTimecodeIntervalMapCRUD(string connectionString) : base(connectionString)
		{
		}

		public virtual string TableName
		{
			get { return this._tableName; }
			set { this._tableName = value; }
		}

		public string SQLColumns
		{
			get
			{
				return "[ACTimecodeIntervalMap].[ACTimecodeIntervalMapPK] AS [ACTimecodeIntervalMapPK],[ACTimecodeIntervalMap].[ACTimecodePK] AS [ACTimecodePK],[ACTimecodeIntervalMap].[ACIntervalPK] AS [ACIntervalPK],[ACTimecodeIntervalMap].[RowVersion] AS [RowVersion],[ACTimecodeIntervalMap].[CreatedOn] AS [CreatedOn],[ACTimecodeIntervalMap].[CreatedBy] AS [CreatedBy],[ACTimecodeIntervalMap].[ModifiedOn] AS [ModifiedOn],[ACTimecodeIntervalMap].[ModifiedBy] AS [ModifiedBy],[ACInterval].[End] AS [End],[ACInterval].[Begin] AS [Begin],[ACInterval].[IVID] AS [IVID],[ACTimecode].[TCID] AS [TCID],[ACTimecode].[BDBuildingPK] AS [BDBuildingPK],[BDBuilding].[Address1] AS [Address1],[BDBuilding].[BuildingID] AS [BuildingID]";
			}
		}

		public string SQLLeftJoins
		{
			get
			{
				return "LEFT JOIN [ACInterval] [ACInterval] ON [ACTimecodeIntervalMap].[ACIntervalPK] = [ACInterval].[ACIntervalPK] LEFT JOIN [ACTimecode] [ACTimecode] ON [ACTimecodeIntervalMap].[ACTimecodePK] = [ACTimecode].[ACTimecodePK] LEFT JOIN [BDBuilding] [BDBuilding] ON [ACTimecode].[BDBuildingPK] = [BDBuilding].[BDBuildingPK]";
			}
		}

		protected override string SQLSelect
		{
			get
			{
				return string.Format("SELECT [ACTimecodeIntervalMap].[ACTimecodeIntervalMapPK] AS [ACTimecodeIntervalMapPK],[ACTimecodeIntervalMap].[ACTimecodePK] AS [ACTimecodePK],[ACTimecodeIntervalMap].[ACIntervalPK] AS [ACIntervalPK],[ACTimecodeIntervalMap].[RowVersion] AS [RowVersion],[ACTimecodeIntervalMap].[CreatedOn] AS [CreatedOn],[ACTimecodeIntervalMap].[CreatedBy] AS [CreatedBy],[ACTimecodeIntervalMap].[ModifiedOn] AS [ModifiedOn],[ACTimecodeIntervalMap].[ModifiedBy] AS [ModifiedBy],[ACInterval].[End] AS [End],[ACInterval].[Begin] AS [Begin],[ACInterval].[IVID] AS [IVID],[ACTimecode].[TCID] AS [TCID],[ACTimecode].[BDBuildingPK] AS [BDBuildingPK],[BDBuilding].[Address1] AS [Address1],[BDBuilding].[BuildingID] AS [BuildingID] FROM [{0}] [ACTimecodeIntervalMap] LEFT JOIN [ACInterval] [ACInterval] ON [ACTimecodeIntervalMap].[ACIntervalPK] = [ACInterval].[ACIntervalPK] LEFT JOIN [ACTimecode] [ACTimecode] ON [ACTimecodeIntervalMap].[ACTimecodePK] = [ACTimecode].[ACTimecodePK] LEFT JOIN [BDBuilding] [BDBuilding] ON [ACTimecode].[BDBuildingPK] = [BDBuilding].[BDBuildingPK]", this.TableName);
			}
		}

		protected override string SQLCount
		{
			get
			{
				return string.Format("SELECT COUNT(*) FROM [{0}] [ACTimecodeIntervalMap] LEFT JOIN [ACInterval] [ACInterval] ON [ACTimecodeIntervalMap].[ACIntervalPK] = [ACInterval].[ACIntervalPK] LEFT JOIN [ACTimecode] [ACTimecode] ON [ACTimecodeIntervalMap].[ACTimecodePK] = [ACTimecode].[ACTimecodePK] LEFT JOIN [BDBuilding] [BDBuilding] ON [ACTimecode].[BDBuildingPK] = [BDBuilding].[BDBuildingPK]", this.TableName);
			}
		}

		public int Insert(ACTimecodeIntervalMapData entity)
		{
			string sql = string.Format("INSERT INTO [{0}] ([ACTimecodeIntervalMapPK],[ACTimecodePK],[ACIntervalPK],[CreatedOn],[CreatedBy],[ModifiedOn],[ModifiedBy]) VALUES(@ACTimecodeIntervalMapPK,@ACTimecodePK,@ACIntervalPK,@CreatedOn,@CreatedBy,@ModifiedOn,@ModifiedBy)", this.TableName);
			SqlParameter[] paras = new SqlParameter[7];
			paras[0] = new SqlParameter("@ACTimecodeIntervalMapPK", SqlDbType.UniqueIdentifier);
			if (entity.ACTimecodeIntervalMapPK == Guid.Empty)
			{
				paras[0].Value = DBNull.Value;
			}
			else
			{
				paras[0].Value = entity.ACTimecodeIntervalMapPK;
			}
			paras[1] = new SqlParameter("@ACTimecodePK", SqlDbType.UniqueIdentifier);
			if (entity.ACTimecodePK == Guid.Empty)
			{
				paras[1].Value = DBNull.Value;
			}
			else
			{
				paras[1].Value = entity.ACTimecodePK;
			}
			paras[2] = new SqlParameter("@ACIntervalPK", SqlDbType.UniqueIdentifier);
			if (entity.ACIntervalPK == Guid.Empty)
			{
				paras[2].Value = DBNull.Value;
			}
			else
			{
				paras[2].Value = entity.ACIntervalPK;
			}
			paras[3] = new SqlParameter("@CreatedOn", SqlDbType.DateTime);
			paras[3].Value = entity.CreatedOn;
			paras[4] = new SqlParameter("@CreatedBy", SqlDbType.VarChar, 30);
			paras[4].Value = entity.CreatedBy;
			paras[5] = new SqlParameter("@ModifiedOn", SqlDbType.DateTime);
			paras[5].Value = entity.ModifiedOn;
			paras[6] = new SqlParameter("@ModifiedBy", SqlDbType.VarChar, 30);
			paras[6].Value = entity.ModifiedBy;
			return base.ExecuteNonQuery(sql, paras);
		}

		public int Update(ACTimecodeIntervalMapData entity)
		{
			string sql = string.Format("UPDATE [{0}] SET [ACTimecodePK] = @ACTimecodePK,[ACIntervalPK] = @ACIntervalPK,[CreatedOn] = @CreatedOn,[CreatedBy] = @CreatedBy,[ModifiedOn] = @ModifiedOn,[ModifiedBy] = @ModifiedBy  WHERE [ACTimecodeIntervalMapPK] = @ACTimecodeIntervalMapPK AND [RowVersion] = @RowVersion", this.TableName);
			SqlParameter[] paras = new SqlParameter[8];
			paras[0] = new SqlParameter("@ACTimecodeIntervalMapPK", SqlDbType.UniqueIdentifier);
			if (entity.ACTimecodeIntervalMapPK == Guid.Empty)
			{
				paras[0].Value = DBNull.Value;
			}
			else
			{
				paras[0].Value = entity.ACTimecodeIntervalMapPK;
			}
			paras[1] = new SqlParameter("@ACTimecodePK", SqlDbType.UniqueIdentifier);
			if (entity.ACTimecodePK == Guid.Empty)
			{
				paras[1].Value = DBNull.Value;
			}
			else
			{
				paras[1].Value = entity.ACTimecodePK;
			}
			paras[2] = new SqlParameter("@ACIntervalPK", SqlDbType.UniqueIdentifier);
			if (entity.ACIntervalPK == Guid.Empty)
			{
				paras[2].Value = DBNull.Value;
			}
			else
			{
				paras[2].Value = entity.ACIntervalPK;
			}
			paras[3] = new SqlParameter("@RowVersion", SqlDbType.Timestamp);
			paras[3].Value = entity.RowVersion;
			paras[4] = new SqlParameter("@CreatedOn", SqlDbType.DateTime);
			paras[4].Value = entity.CreatedOn;
			paras[5] = new SqlParameter("@CreatedBy", SqlDbType.VarChar, 30);
			paras[5].Value = entity.CreatedBy;
			paras[6] = new SqlParameter("@ModifiedOn", SqlDbType.DateTime);
			paras[6].Value = entity.ModifiedOn;
			paras[7] = new SqlParameter("@ModifiedBy", SqlDbType.VarChar, 30);
			paras[7].Value = entity.ModifiedBy;
			return base.ExecuteNonQuery(sql, paras);
		}

		private ACTimecodeIntervalMapData CreateDataByReader(SafeDataReader reader)
		{
			ACTimecodeIntervalMapData data = new ACTimecodeIntervalMapData {
				ACTimecodeIntervalMapPK = (Guid) reader["ACTimecodeIntervalMapPK"],
				ACTimecodePK = (Guid) reader["ACTimecodePK"],
				ACIntervalPK = (Guid) reader["ACIntervalPK"],
				RowVersion = (Byte[]) reader["RowVersion"],
				CreatedOn = (DateTime) reader["CreatedOn"],
				CreatedBy = (String) reader["CreatedBy"],
				ModifiedOn = (DateTime) reader["ModifiedOn"],
				ModifiedBy = (String) reader["ModifiedBy"],
				End = (String) reader["End"],
				Begin = (String) reader["Begin"],
				IVID = (Int16) reader["IVID"],
				TCID = (Int16) reader["TCID"],
				BDBuildingPK = (Guid) reader["BDBuildingPK"],
				Address1 = (String) reader["Address1"],
				BuildingID = (Int32) reader["BuildingID"]
			};
			data.AcceptChanges();
			return data;
		}

		private ACTimecodeIntervalMapData FetchEntity(string where, SqlParameter[] paras)
		{
			ACTimecodeIntervalMapData data = null;
			using (SafeDataReader reader = base.ExecuteDataReader(where, paras))
			{
				if (reader.Read())
				{
					data = this.CreateDataByReader(reader);
				}
				reader.Close();
			}
			return data;
		}

		private ACTimecodeIntervalMapData FetchEntityEx(string sql, SqlParameter[] paras)
		{
			ACTimecodeIntervalMapData data = null;
			using (SafeDataReader reader = base.ExecuteDataReaderEx(sql, paras))
			{
				if (reader.Read())
				{
					data = this.CreateDataByReader(reader);
				}
				reader.Close();
			}
			return data;
		}

		private ACTimecodeIntervalMapDataCollection FetchCollection(string where, SqlParameter[] paras)
		{
			ACTimecodeIntervalMapDataCollection list = new ACTimecodeIntervalMapDataCollection();
			using (SafeDataReader reader = base.ExecuteDataReader(where, paras))
			{
				while(reader.Read())
				{
					ACTimecodeIntervalMapData data = this.CreateDataByReader(reader);
					list.Add(data);
				}
				reader.Close();
			}
			return list;
		}

		private ACTimecodeIntervalMapDataCollection FetchCollectionEx(string sql, SqlParameter[] paras)
		{
			ACTimecodeIntervalMapDataCollection list = new ACTimecodeIntervalMapDataCollection();
			using (SafeDataReader reader = base.ExecuteDataReaderEx(sql, paras))
			{
				while(reader.Read())
				{
					ACTimecodeIntervalMapData data = this.CreateDataByReader(reader);
					list.Add(data);
				}
				reader.Close();
			}
			return list;
		}

		public ACTimecodeIntervalMapData GetEntityBy(string sqlWhere, SqlParameter[] paras)
		{
			return this.FetchEntity(sqlWhere, paras);
		}

		public ACTimecodeIntervalMapData GetEntityExBy(string sql, SqlParameter[] paras)
		{
			return this.FetchEntityEx(sql, paras);
		}

		public ACTimecodeIntervalMapDataCollection GetCollectionBy(string sqlWhere, SqlParameter[] paras)
		{
			return this.FetchCollection(sqlWhere, paras);
		}

		public ACTimecodeIntervalMapDataCollection GetCollectionExBy(string sql, SqlParameter[] paras)
		{
			return this.FetchCollectionEx(sql, paras);
		}

		public byte[] GetRowVersion( System.Guid ACTimecodeIntervalMapPK)
		{
			string sql = string.Format("SELECT [RowVersion] AS [RowVersion] FROM [{0}] WHERE  [ACTimecodeIntervalMapPK] = @ACTimecodeIntervalMapPK ", this.TableName);
			SqlParameter[] paras = new SqlParameter[1];
			paras[0] = new SqlParameter("@ACTimecodeIntervalMapPK", SqlDbType.UniqueIdentifier, 16);
			paras[0].Value = ACTimecodeIntervalMapPK;
			return (byte[]) base.ExecuteScalar(sql, paras);
		}

		public ACTimecodeIntervalMapData GetByPK( System.Guid ACTimecodeIntervalMapPK)
		{
			string sql = " WHERE  [ACTimecodeIntervalMap].[ACTimecodeIntervalMapPK] = @ACTimecodeIntervalMapPK ";
			SqlParameter[] paras = new SqlParameter[1];
			paras[0] = new SqlParameter("@ACTimecodeIntervalMapPK", SqlDbType.UniqueIdentifier);
			paras[0].Value = ACTimecodeIntervalMapPK;
			return this.FetchEntity(sql, paras);
		}

		public ACTimecodeIntervalMapDataCollection GetAll()
		{
			return this.FetchCollection("", null);
		}

		public ACTimecodeIntervalMapDataCollection GetByACInterval(System.Guid ACIntervalPK)
		{
			string sqlWhere = " WHERE [ACTimecodeIntervalMap].[ACIntervalPK] = @ACIntervalPK";
			SqlParameter[] paras = new SqlParameter[1];
			paras[0] = new SqlParameter("@ACIntervalPK", SqlDbType.UniqueIdentifier);
			paras[0].Value = ACIntervalPK;
			return this.FetchCollection(sqlWhere, paras);
		}

		public ACTimecodeIntervalMapDataCollection GetByACTimecode(System.Guid ACTimecodePK)
		{
			string sqlWhere = " WHERE [ACTimecodeIntervalMap].[ACTimecodePK] = @ACTimecodePK";
			SqlParameter[] paras = new SqlParameter[1];
			paras[0] = new SqlParameter("@ACTimecodePK", SqlDbType.UniqueIdentifier);
			paras[0].Value = ACTimecodePK;
			return this.FetchCollection(sqlWhere, paras);
		}

		public DataTable GetLogByPK( System.Guid ACTimecodeIntervalMapPK)
		{
			string sql = string.Format("SELECT  [ACTimecodeIntervalMap].[ACTimecodeIntervalMapPK] AS [ACTimecodeIntervalMapPK], [ACTimecodeIntervalMap].[ModifiedOn] AS [ModifiedOn] FROM [{0}] WHERE  [ACTimecodeIntervalMap].[ACTimecodeIntervalMapPK] = @ACTimecodeIntervalMapPK ", this.TableName);
			SqlParameter[] paras = new SqlParameter[1];
			paras[0] = new SqlParameter("@ACTimecodeIntervalMapPK", SqlDbType.UniqueIdentifier);
			paras[0].Value = ACTimecodeIntervalMapPK;
			return this.ExecuteDataTable(sql, paras);
		}

		public DataTable GetLogByACInterval(System.Guid aCIntervalPK)
		{
			string sql = string.Format("DELETE [{0}] FROM [{0}] [ACTimecodeIntervalMap] INNER JOIN [ACInterval] ON [ACTimecodeIntervalMap].[ACIntervalPK] = [ACInterval].[ACIntervalPK] WHERE [ACInterval].[ACIntervalPK] = @ACIntervalPK;", this.TableName);
			string oldValue = string.Format("DELETE [{0}]", this.TableName);
			string newValue = "SELECT  [ACTimecodeIntervalMap].[ACTimecodeIntervalMapPK] AS [ACTimecodeIntervalMapPK], [ACTimecodeIntervalMap].[ModifiedOn] AS [ModifiedOn]";
			sql = sql.Replace(oldValue, newValue).TrimEnd().TrimEnd(';').Replace(";", " UNION ");
			SqlParameter[] paras = new SqlParameter[1];
			paras[0] = new SqlParameter("@ACIntervalPK", SqlDbType.UniqueIdentifier);
			paras[0].Value = aCIntervalPK;
			return base.ExecuteDataTable(sql, paras);
		}

		public DataTable GetLogByBDBuilding(System.Guid bDBuildingPK)
		{
			string sql = string.Format("DELETE [{0}] FROM [{0}] [ACTimecodeIntervalMap] INNER JOIN [ACInterval] ON [ACTimecodeIntervalMap].[ACIntervalPK] = [ACInterval].[ACIntervalPK] INNER JOIN [BDBuilding] ON [ACInterval].[BDBuildingPK] = [BDBuilding].[BDBuildingPK] WHERE [BDBuilding].[BDBuildingPK] = @BDBuildingPK;DELETE [{0}] FROM [{0}] [ACTimecodeIntervalMap] INNER JOIN [ACTimecode] ON [ACTimecodeIntervalMap].[ACTimecodePK] = [ACTimecode].[ACTimecodePK] INNER JOIN [BDBuilding] ON [ACTimecode].[BDBuildingPK] = [BDBuilding].[BDBuildingPK] WHERE [BDBuilding].[BDBuildingPK] = @BDBuildingPK;", this.TableName);
			string oldValue = string.Format("DELETE [{0}]", this.TableName);
			string newValue = "SELECT  [ACTimecodeIntervalMap].[ACTimecodeIntervalMapPK] AS [ACTimecodeIntervalMapPK], [ACTimecodeIntervalMap].[ModifiedOn] AS [ModifiedOn]";
			sql = sql.Replace(oldValue, newValue).TrimEnd().TrimEnd(';').Replace(";", " UNION ");
			SqlParameter[] paras = new SqlParameter[1];
			paras[0] = new SqlParameter("@BDBuildingPK", SqlDbType.UniqueIdentifier);
			paras[0].Value = bDBuildingPK;
			return base.ExecuteDataTable(sql, paras);
		}

		public DataTable GetLogByACTimecode(System.Guid aCTimecodePK)
		{
			string sql = string.Format("DELETE [{0}] FROM [{0}] [ACTimecodeIntervalMap] INNER JOIN [ACTimecode] ON [ACTimecodeIntervalMap].[ACTimecodePK] = [ACTimecode].[ACTimecodePK] WHERE [ACTimecode].[ACTimecodePK] = @ACTimecodePK;", this.TableName);
			string oldValue = string.Format("DELETE [{0}]", this.TableName);
			string newValue = "SELECT  [ACTimecodeIntervalMap].[ACTimecodeIntervalMapPK] AS [ACTimecodeIntervalMapPK], [ACTimecodeIntervalMap].[ModifiedOn] AS [ModifiedOn]";
			sql = sql.Replace(oldValue, newValue).TrimEnd().TrimEnd(';').Replace(";", " UNION ");
			SqlParameter[] paras = new SqlParameter[1];
			paras[0] = new SqlParameter("@ACTimecodePK", SqlDbType.UniqueIdentifier);
			paras[0].Value = aCTimecodePK;
			return base.ExecuteDataTable(sql, paras);
		}

		public int DeleteByPK( System.Guid ACTimecodeIntervalMapPK, byte[] RowVersion)
		{
			string sql = string.Format("DELETE FROM [{0}] WHERE  [ACTimecodeIntervalMapPK] = @ACTimecodeIntervalMapPK AND [RowVersion] = @RowVersion", this.TableName);
			SqlParameter[] paras = new SqlParameter[2];
			paras[0] = new SqlParameter("@ACTimecodeIntervalMapPK", SqlDbType.UniqueIdentifier);
			paras[0].Value = ACTimecodeIntervalMapPK;
			paras[1] = new SqlParameter("@RowVersion", SqlDbType.Timestamp, 8);
			paras[1].Value = RowVersion;
			return base.ExecuteNonQuery(sql, paras);
		}

		public int DeleteAll()
		{
			string sql = string.Format("DELETE FROM [{0}]", this.TableName);
			return base.ExecuteNonQuery(sql, null);
		}

		public int DeleteByACInterval(System.Guid aCIntervalPK)
		{
			string sql = string.Format("DELETE [{0}] FROM [{0}] [ACTimecodeIntervalMap] INNER JOIN [ACInterval] ON [ACTimecodeIntervalMap].[ACIntervalPK] = [ACInterval].[ACIntervalPK] WHERE [ACInterval].[ACIntervalPK] = @ACIntervalPK;", this.TableName);
			SqlParameter[] paras = new SqlParameter[1];
			paras[0] = new SqlParameter("@ACIntervalPK", SqlDbType.UniqueIdentifier);
			paras[0].Value = aCIntervalPK;
			return base.ExecuteNonQuery(sql, paras);
		}

		public int DeleteByBDBuilding(System.Guid bDBuildingPK)
		{
			string sql = string.Format("DELETE [{0}] FROM [{0}] [ACTimecodeIntervalMap] INNER JOIN [ACInterval] ON [ACTimecodeIntervalMap].[ACIntervalPK] = [ACInterval].[ACIntervalPK] INNER JOIN [BDBuilding] ON [ACInterval].[BDBuildingPK] = [BDBuilding].[BDBuildingPK] WHERE [BDBuilding].[BDBuildingPK] = @BDBuildingPK;DELETE [{0}] FROM [{0}] [ACTimecodeIntervalMap] INNER JOIN [ACTimecode] ON [ACTimecodeIntervalMap].[ACTimecodePK] = [ACTimecode].[ACTimecodePK] INNER JOIN [BDBuilding] ON [ACTimecode].[BDBuildingPK] = [BDBuilding].[BDBuildingPK] WHERE [BDBuilding].[BDBuildingPK] = @BDBuildingPK;", this.TableName);
			SqlParameter[] paras = new SqlParameter[1];
			paras[0] = new SqlParameter("@BDBuildingPK", SqlDbType.UniqueIdentifier);
			paras[0].Value = bDBuildingPK;
			return base.ExecuteNonQuery(sql, paras);
		}

		public int DeleteByACTimecode(System.Guid aCTimecodePK)
		{
			string sql = string.Format("DELETE [{0}] FROM [{0}] [ACTimecodeIntervalMap] INNER JOIN [ACTimecode] ON [ACTimecodeIntervalMap].[ACTimecodePK] = [ACTimecode].[ACTimecodePK] WHERE [ACTimecode].[ACTimecodePK] = @ACTimecodePK;", this.TableName);
			SqlParameter[] paras = new SqlParameter[1];
			paras[0] = new SqlParameter("@ACTimecodePK", SqlDbType.UniqueIdentifier);
			paras[0].Value = aCTimecodePK;
			return base.ExecuteNonQuery(sql, paras);
		}


	}
	public class ACAMFormatCRUD : DataAccessBase
	{
		private string _tableName = "ACAMFormat";

		public ACAMFormatCRUD(string connectionString) : base(connectionString)
		{
		}

		public virtual string TableName
		{
			get { return this._tableName; }
			set { this._tableName = value; }
		}

		public string SQLColumns
		{
			get
			{
				return "[ACAMFormat].[ACAMFormatPK] AS [ACAMFormatPK],[ACAMFormat].[BDBuildingPK] AS [BDBuildingPK],[ACAMFormat].[AMFID] AS [AMFID],[ACAMFormat].[Summary] AS [Summary],[ACAMFormat].[Notes] AS [Notes],[ACAMFormat].[ReportTC] AS [ReportTC],[ACAMFormat].[AlarmTC] AS [AlarmTC],[ACAMFormat].[PreAlarmTC] AS [PreAlarmTC],[ACAMFormat].[RowVersion] AS [RowVersion],[ACAMFormat].[CreatedOn] AS [CreatedOn],[ACAMFormat].[CreatedBy] AS [CreatedBy],[ACAMFormat].[ModifiedOn] AS [ModifiedOn],[ACAMFormat].[ModifiedBy] AS [ModifiedBy],[BDBuilding].[Address1] AS [Address1],[BDBuilding].[BuildingID] AS [BuildingID]";
			}
		}

		public string SQLLeftJoins
		{
			get
			{
				return "LEFT JOIN [BDBuilding] [BDBuilding] ON [ACAMFormat].[BDBuildingPK] = [BDBuilding].[BDBuildingPK]";
			}
		}

		protected override string SQLSelect
		{
			get
			{
				return string.Format("SELECT [ACAMFormat].[ACAMFormatPK] AS [ACAMFormatPK],[ACAMFormat].[BDBuildingPK] AS [BDBuildingPK],[ACAMFormat].[AMFID] AS [AMFID],[ACAMFormat].[Summary] AS [Summary],[ACAMFormat].[Notes] AS [Notes],[ACAMFormat].[ReportTC] AS [ReportTC],[ACAMFormat].[AlarmTC] AS [AlarmTC],[ACAMFormat].[PreAlarmTC] AS [PreAlarmTC],[ACAMFormat].[RowVersion] AS [RowVersion],[ACAMFormat].[CreatedOn] AS [CreatedOn],[ACAMFormat].[CreatedBy] AS [CreatedBy],[ACAMFormat].[ModifiedOn] AS [ModifiedOn],[ACAMFormat].[ModifiedBy] AS [ModifiedBy],[BDBuilding].[Address1] AS [Address1],[BDBuilding].[BuildingID] AS [BuildingID] FROM [{0}] [ACAMFormat] LEFT JOIN [BDBuilding] [BDBuilding] ON [ACAMFormat].[BDBuildingPK] = [BDBuilding].[BDBuildingPK]", this.TableName);
			}
		}

		protected override string SQLCount
		{
			get
			{
				return string.Format("SELECT COUNT(*) FROM [{0}] [ACAMFormat] LEFT JOIN [BDBuilding] [BDBuilding] ON [ACAMFormat].[BDBuildingPK] = [BDBuilding].[BDBuildingPK]", this.TableName);
			}
		}

		public int Insert(ACAMFormatData entity)
		{
			string sql = string.Format("INSERT INTO [{0}] ([ACAMFormatPK],[BDBuildingPK],[AMFID],[Summary],[Notes],[ReportTC],[AlarmTC],[PreAlarmTC],[CreatedOn],[CreatedBy],[ModifiedOn],[ModifiedBy]) VALUES(@ACAMFormatPK,@BDBuildingPK,@AMFID,@Summary,@Notes,@ReportTC,@AlarmTC,@PreAlarmTC,@CreatedOn,@CreatedBy,@ModifiedOn,@ModifiedBy)", this.TableName);
			SqlParameter[] paras = new SqlParameter[12];
			paras[0] = new SqlParameter("@ACAMFormatPK", SqlDbType.UniqueIdentifier);
			if (entity.ACAMFormatPK == Guid.Empty)
			{
				paras[0].Value = DBNull.Value;
			}
			else
			{
				paras[0].Value = entity.ACAMFormatPK;
			}
			paras[1] = new SqlParameter("@BDBuildingPK", SqlDbType.UniqueIdentifier);
			if (entity.BDBuildingPK == Guid.Empty)
			{
				paras[1].Value = DBNull.Value;
			}
			else
			{
				paras[1].Value = entity.BDBuildingPK;
			}
			paras[2] = new SqlParameter("@AMFID", SqlDbType.SmallInt);
			paras[2].Value = entity.AMFID;
			paras[3] = new SqlParameter("@Summary", SqlDbType.VarChar, 256);
			paras[3].Value = entity.Summary;
			paras[4] = new SqlParameter("@Notes", SqlDbType.VarChar, 512);
			paras[4].Value = entity.Notes;
			paras[5] = new SqlParameter("@ReportTC", SqlDbType.SmallInt);
			paras[5].Value = entity.ReportTC;
			paras[6] = new SqlParameter("@AlarmTC", SqlDbType.SmallInt);
			paras[6].Value = entity.AlarmTC;
			paras[7] = new SqlParameter("@PreAlarmTC", SqlDbType.SmallInt);
			paras[7].Value = entity.PreAlarmTC;
			paras[8] = new SqlParameter("@CreatedOn", SqlDbType.DateTime);
			paras[8].Value = entity.CreatedOn;
			paras[9] = new SqlParameter("@CreatedBy", SqlDbType.VarChar, 30);
			paras[9].Value = entity.CreatedBy;
			paras[10] = new SqlParameter("@ModifiedOn", SqlDbType.DateTime);
			paras[10].Value = entity.ModifiedOn;
			paras[11] = new SqlParameter("@ModifiedBy", SqlDbType.VarChar, 30);
			paras[11].Value = entity.ModifiedBy;
			return base.ExecuteNonQuery(sql, paras);
		}

		public int Update(ACAMFormatData entity)
		{
			string sql = string.Format("UPDATE [{0}] SET [BDBuildingPK] = @BDBuildingPK,[AMFID] = @AMFID,[Summary] = @Summary,[Notes] = @Notes,[ReportTC] = @ReportTC,[AlarmTC] = @AlarmTC,[PreAlarmTC] = @PreAlarmTC,[CreatedOn] = @CreatedOn,[CreatedBy] = @CreatedBy,[ModifiedOn] = @ModifiedOn,[ModifiedBy] = @ModifiedBy  WHERE [ACAMFormatPK] = @ACAMFormatPK AND [RowVersion] = @RowVersion", this.TableName);
			SqlParameter[] paras = new SqlParameter[13];
			paras[0] = new SqlParameter("@ACAMFormatPK", SqlDbType.UniqueIdentifier);
			if (entity.ACAMFormatPK == Guid.Empty)
			{
				paras[0].Value = DBNull.Value;
			}
			else
			{
				paras[0].Value = entity.ACAMFormatPK;
			}
			paras[1] = new SqlParameter("@BDBuildingPK", SqlDbType.UniqueIdentifier);
			if (entity.BDBuildingPK == Guid.Empty)
			{
				paras[1].Value = DBNull.Value;
			}
			else
			{
				paras[1].Value = entity.BDBuildingPK;
			}
			paras[2] = new SqlParameter("@AMFID", SqlDbType.SmallInt);
			paras[2].Value = entity.AMFID;
			paras[3] = new SqlParameter("@Summary", SqlDbType.VarChar, 256);
			paras[3].Value = entity.Summary;
			paras[4] = new SqlParameter("@Notes", SqlDbType.VarChar, 512);
			paras[4].Value = entity.Notes;
			paras[5] = new SqlParameter("@ReportTC", SqlDbType.SmallInt);
			paras[5].Value = entity.ReportTC;
			paras[6] = new SqlParameter("@AlarmTC", SqlDbType.SmallInt);
			paras[6].Value = entity.AlarmTC;
			paras[7] = new SqlParameter("@PreAlarmTC", SqlDbType.SmallInt);
			paras[7].Value = entity.PreAlarmTC;
			paras[8] = new SqlParameter("@RowVersion", SqlDbType.Timestamp);
			paras[8].Value = entity.RowVersion;
			paras[9] = new SqlParameter("@CreatedOn", SqlDbType.DateTime);
			paras[9].Value = entity.CreatedOn;
			paras[10] = new SqlParameter("@CreatedBy", SqlDbType.VarChar, 30);
			paras[10].Value = entity.CreatedBy;
			paras[11] = new SqlParameter("@ModifiedOn", SqlDbType.DateTime);
			paras[11].Value = entity.ModifiedOn;
			paras[12] = new SqlParameter("@ModifiedBy", SqlDbType.VarChar, 30);
			paras[12].Value = entity.ModifiedBy;
			return base.ExecuteNonQuery(sql, paras);
		}

		private ACAMFormatData CreateDataByReader(SafeDataReader reader)
		{
			ACAMFormatData data = new ACAMFormatData {
				ACAMFormatPK = (Guid) reader["ACAMFormatPK"],
				BDBuildingPK = (Guid) reader["BDBuildingPK"],
				AMFID = (Int16) reader["AMFID"],
				Summary = (String) reader["Summary"],
				Notes = (String) reader["Notes"],
				ReportTC = (Int16) reader["ReportTC"],
				AlarmTC = (Int16) reader["AlarmTC"],
				PreAlarmTC = (Int16) reader["PreAlarmTC"],
				RowVersion = (Byte[]) reader["RowVersion"],
				CreatedOn = (DateTime) reader["CreatedOn"],
				CreatedBy = (String) reader["CreatedBy"],
				ModifiedOn = (DateTime) reader["ModifiedOn"],
				ModifiedBy = (String) reader["ModifiedBy"],
				Address1 = (String) reader["Address1"],
				BuildingID = (Int32) reader["BuildingID"]
			};
			data.AcceptChanges();
			return data;
		}

		private ACAMFormatData FetchEntity(string where, SqlParameter[] paras)
		{
			ACAMFormatData data = null;
			using (SafeDataReader reader = base.ExecuteDataReader(where, paras))
			{
				if (reader.Read())
				{
					data = this.CreateDataByReader(reader);
				}
				reader.Close();
			}
			return data;
		}

		private ACAMFormatData FetchEntityEx(string sql, SqlParameter[] paras)
		{
			ACAMFormatData data = null;
			using (SafeDataReader reader = base.ExecuteDataReaderEx(sql, paras))
			{
				if (reader.Read())
				{
					data = this.CreateDataByReader(reader);
				}
				reader.Close();
			}
			return data;
		}

		private ACAMFormatDataCollection FetchCollection(string where, SqlParameter[] paras)
		{
			ACAMFormatDataCollection list = new ACAMFormatDataCollection();
			using (SafeDataReader reader = base.ExecuteDataReader(where, paras))
			{
				while(reader.Read())
				{
					ACAMFormatData data = this.CreateDataByReader(reader);
					list.Add(data);
				}
				reader.Close();
			}
			return list;
		}

		private ACAMFormatDataCollection FetchCollectionEx(string sql, SqlParameter[] paras)
		{
			ACAMFormatDataCollection list = new ACAMFormatDataCollection();
			using (SafeDataReader reader = base.ExecuteDataReaderEx(sql, paras))
			{
				while(reader.Read())
				{
					ACAMFormatData data = this.CreateDataByReader(reader);
					list.Add(data);
				}
				reader.Close();
			}
			return list;
		}

		public ACAMFormatData GetEntityBy(string sqlWhere, SqlParameter[] paras)
		{
			return this.FetchEntity(sqlWhere, paras);
		}

		public ACAMFormatData GetEntityExBy(string sql, SqlParameter[] paras)
		{
			return this.FetchEntityEx(sql, paras);
		}

		public ACAMFormatDataCollection GetCollectionBy(string sqlWhere, SqlParameter[] paras)
		{
			return this.FetchCollection(sqlWhere, paras);
		}

		public ACAMFormatDataCollection GetCollectionExBy(string sql, SqlParameter[] paras)
		{
			return this.FetchCollectionEx(sql, paras);
		}

		public byte[] GetRowVersion( System.Guid ACAMFormatPK)
		{
			string sql = string.Format("SELECT [RowVersion] AS [RowVersion] FROM [{0}] WHERE  [ACAMFormatPK] = @ACAMFormatPK ", this.TableName);
			SqlParameter[] paras = new SqlParameter[1];
			paras[0] = new SqlParameter("@ACAMFormatPK", SqlDbType.UniqueIdentifier, 16);
			paras[0].Value = ACAMFormatPK;
			return (byte[]) base.ExecuteScalar(sql, paras);
		}

		public ACAMFormatData GetByPK( System.Guid ACAMFormatPK)
		{
			string sql = " WHERE  [ACAMFormat].[ACAMFormatPK] = @ACAMFormatPK ";
			SqlParameter[] paras = new SqlParameter[1];
			paras[0] = new SqlParameter("@ACAMFormatPK", SqlDbType.UniqueIdentifier);
			paras[0].Value = ACAMFormatPK;
			return this.FetchEntity(sql, paras);
		}

		public ACAMFormatDataCollection GetAll()
		{
			return this.FetchCollection("", null);
		}

		public ACAMFormatDataCollection GetByBDBuilding(System.Guid BDBuildingPK)
		{
			string sqlWhere = " WHERE [ACAMFormat].[BDBuildingPK] = @BDBuildingPK";
			SqlParameter[] paras = new SqlParameter[1];
			paras[0] = new SqlParameter("@BDBuildingPK", SqlDbType.UniqueIdentifier);
			paras[0].Value = BDBuildingPK;
			return this.FetchCollection(sqlWhere, paras);
		}

		public DataTable GetLogByPK( System.Guid ACAMFormatPK)
		{
			string sql = string.Format("SELECT  [ACAMFormat].[ACAMFormatPK] AS [ACAMFormatPK], [ACAMFormat].[ModifiedOn] AS [ModifiedOn] FROM [{0}] WHERE  [ACAMFormat].[ACAMFormatPK] = @ACAMFormatPK ", this.TableName);
			SqlParameter[] paras = new SqlParameter[1];
			paras[0] = new SqlParameter("@ACAMFormatPK", SqlDbType.UniqueIdentifier);
			paras[0].Value = ACAMFormatPK;
			return this.ExecuteDataTable(sql, paras);
		}

		public DataTable GetLogByBDBuilding(System.Guid bDBuildingPK)
		{
			string sql = string.Format("DELETE [{0}] FROM [{0}] [ACAMFormat] INNER JOIN [BDBuilding] ON [ACAMFormat].[BDBuildingPK] = [BDBuilding].[BDBuildingPK] WHERE [BDBuilding].[BDBuildingPK] = @BDBuildingPK;", this.TableName);
			string oldValue = string.Format("DELETE [{0}]", this.TableName);
			string newValue = "SELECT  [ACAMFormat].[ACAMFormatPK] AS [ACAMFormatPK], [ACAMFormat].[ModifiedOn] AS [ModifiedOn]";
			sql = sql.Replace(oldValue, newValue).TrimEnd().TrimEnd(';').Replace(";", " UNION ");
			SqlParameter[] paras = new SqlParameter[1];
			paras[0] = new SqlParameter("@BDBuildingPK", SqlDbType.UniqueIdentifier);
			paras[0].Value = bDBuildingPK;
			return base.ExecuteDataTable(sql, paras);
		}

		public int DeleteByPK( System.Guid ACAMFormatPK, byte[] RowVersion)
		{
			string sql = string.Format("DELETE FROM [{0}] WHERE  [ACAMFormatPK] = @ACAMFormatPK AND [RowVersion] = @RowVersion", this.TableName);
			SqlParameter[] paras = new SqlParameter[2];
			paras[0] = new SqlParameter("@ACAMFormatPK", SqlDbType.UniqueIdentifier);
			paras[0].Value = ACAMFormatPK;
			paras[1] = new SqlParameter("@RowVersion", SqlDbType.Timestamp, 8);
			paras[1].Value = RowVersion;
			return base.ExecuteNonQuery(sql, paras);
		}

		public int DeleteAll()
		{
			string sql = string.Format("DELETE FROM [{0}]", this.TableName);
			return base.ExecuteNonQuery(sql, null);
		}

		public int DeleteByBDBuilding(System.Guid bDBuildingPK)
		{
			string sql = string.Format("DELETE [{0}] FROM [{0}] [ACAMFormat] INNER JOIN [BDBuilding] ON [ACAMFormat].[BDBuildingPK] = [BDBuilding].[BDBuildingPK] WHERE [BDBuilding].[BDBuildingPK] = @BDBuildingPK;", this.TableName);
			SqlParameter[] paras = new SqlParameter[1];
			paras[0] = new SqlParameter("@BDBuildingPK", SqlDbType.UniqueIdentifier);
			paras[0].Value = bDBuildingPK;
			return base.ExecuteNonQuery(sql, paras);
		}


	}
	public class BDBuildingHolidayMapCRUD : DataAccessBase
	{
		private string _tableName = "BDBuildingHolidayMap";

		public BDBuildingHolidayMapCRUD(string connectionString) : base(connectionString)
		{
		}

		public virtual string TableName
		{
			get { return this._tableName; }
			set { this._tableName = value; }
		}

		public string SQLColumns
		{
			get
			{
				return "[BDBuildingHolidayMap].[BDBuildingHolidayMapPK] AS [BDBuildingHolidayMapPK],[BDBuildingHolidayMap].[BDBuildingPK] AS [BDBuildingPK],[BDBuildingHolidayMap].[UtilHolidayPK] AS [UtilHolidayPK],[BDBuildingHolidayMap].[ActionID] AS [ActionID],[BDBuildingHolidayMap].[Notes] AS [Notes],[BDBuildingHolidayMap].[RowVersion] AS [RowVersion],[BDBuildingHolidayMap].[CreatedOn] AS [CreatedOn],[BDBuildingHolidayMap].[CreatedBy] AS [CreatedBy],[BDBuildingHolidayMap].[ModifiedOn] AS [ModifiedOn],[BDBuildingHolidayMap].[ModifiedBy] AS [ModifiedBy],[BDBuilding].[Address1] AS [Address1],[BDBuilding].[BuildingID] AS [BuildingID],[UtilHoliday].[Date] AS [Date],[UtilHoliday].[Holiday] AS [Holiday]";
			}
		}

		public string SQLLeftJoins
		{
			get
			{
				return "LEFT JOIN [BDBuilding] [BDBuilding] ON [BDBuildingHolidayMap].[BDBuildingPK] = [BDBuilding].[BDBuildingPK] LEFT JOIN [UtilHoliday] [UtilHoliday] ON [BDBuildingHolidayMap].[UtilHolidayPK] = [UtilHoliday].[UtilHolidayPK]";
			}
		}

		protected override string SQLSelect
		{
			get
			{
				return string.Format("SELECT [BDBuildingHolidayMap].[BDBuildingHolidayMapPK] AS [BDBuildingHolidayMapPK],[BDBuildingHolidayMap].[BDBuildingPK] AS [BDBuildingPK],[BDBuildingHolidayMap].[UtilHolidayPK] AS [UtilHolidayPK],[BDBuildingHolidayMap].[ActionID] AS [ActionID],[BDBuildingHolidayMap].[Notes] AS [Notes],[BDBuildingHolidayMap].[RowVersion] AS [RowVersion],[BDBuildingHolidayMap].[CreatedOn] AS [CreatedOn],[BDBuildingHolidayMap].[CreatedBy] AS [CreatedBy],[BDBuildingHolidayMap].[ModifiedOn] AS [ModifiedOn],[BDBuildingHolidayMap].[ModifiedBy] AS [ModifiedBy],[BDBuilding].[Address1] AS [Address1],[BDBuilding].[BuildingID] AS [BuildingID],[UtilHoliday].[Date] AS [Date],[UtilHoliday].[Holiday] AS [Holiday] FROM [{0}] [BDBuildingHolidayMap] LEFT JOIN [BDBuilding] [BDBuilding] ON [BDBuildingHolidayMap].[BDBuildingPK] = [BDBuilding].[BDBuildingPK] LEFT JOIN [UtilHoliday] [UtilHoliday] ON [BDBuildingHolidayMap].[UtilHolidayPK] = [UtilHoliday].[UtilHolidayPK]", this.TableName);
			}
		}

		protected override string SQLCount
		{
			get
			{
				return string.Format("SELECT COUNT(*) FROM [{0}] [BDBuildingHolidayMap] LEFT JOIN [BDBuilding] [BDBuilding] ON [BDBuildingHolidayMap].[BDBuildingPK] = [BDBuilding].[BDBuildingPK] LEFT JOIN [UtilHoliday] [UtilHoliday] ON [BDBuildingHolidayMap].[UtilHolidayPK] = [UtilHoliday].[UtilHolidayPK]", this.TableName);
			}
		}

		public int Insert(BDBuildingHolidayMapData entity)
		{
			string sql = string.Format("INSERT INTO [{0}] ([BDBuildingHolidayMapPK],[BDBuildingPK],[UtilHolidayPK],[ActionID],[Notes],[CreatedOn],[CreatedBy],[ModifiedOn],[ModifiedBy]) VALUES(@BDBuildingHolidayMapPK,@BDBuildingPK,@UtilHolidayPK,@ActionID,@Notes,@CreatedOn,@CreatedBy,@ModifiedOn,@ModifiedBy)", this.TableName);
			SqlParameter[] paras = new SqlParameter[9];
			paras[0] = new SqlParameter("@BDBuildingHolidayMapPK", SqlDbType.UniqueIdentifier);
			if (entity.BDBuildingHolidayMapPK == Guid.Empty)
			{
				paras[0].Value = DBNull.Value;
			}
			else
			{
				paras[0].Value = entity.BDBuildingHolidayMapPK;
			}
			paras[1] = new SqlParameter("@BDBuildingPK", SqlDbType.UniqueIdentifier);
			if (entity.BDBuildingPK == Guid.Empty)
			{
				paras[1].Value = DBNull.Value;
			}
			else
			{
				paras[1].Value = entity.BDBuildingPK;
			}
			paras[2] = new SqlParameter("@UtilHolidayPK", SqlDbType.UniqueIdentifier);
			if (entity.UtilHolidayPK == Guid.Empty)
			{
				paras[2].Value = DBNull.Value;
			}
			else
			{
				paras[2].Value = entity.UtilHolidayPK;
			}
			paras[3] = new SqlParameter("@ActionID", SqlDbType.Int);
			paras[3].Value = entity.ActionID;
			paras[4] = new SqlParameter("@Notes", SqlDbType.VarChar, 256);
			paras[4].Value = entity.Notes;
			paras[5] = new SqlParameter("@CreatedOn", SqlDbType.DateTime);
			paras[5].Value = entity.CreatedOn;
			paras[6] = new SqlParameter("@CreatedBy", SqlDbType.VarChar, 30);
			paras[6].Value = entity.CreatedBy;
			paras[7] = new SqlParameter("@ModifiedOn", SqlDbType.DateTime);
			paras[7].Value = entity.ModifiedOn;
			paras[8] = new SqlParameter("@ModifiedBy", SqlDbType.VarChar, 30);
			paras[8].Value = entity.ModifiedBy;
			return base.ExecuteNonQuery(sql, paras);
		}

		public int Update(BDBuildingHolidayMapData entity)
		{
			string sql = string.Format("UPDATE [{0}] SET [BDBuildingPK] = @BDBuildingPK,[UtilHolidayPK] = @UtilHolidayPK,[ActionID] = @ActionID,[Notes] = @Notes,[CreatedOn] = @CreatedOn,[CreatedBy] = @CreatedBy,[ModifiedOn] = @ModifiedOn,[ModifiedBy] = @ModifiedBy  WHERE [BDBuildingHolidayMapPK] = @BDBuildingHolidayMapPK AND [RowVersion] = @RowVersion", this.TableName);
			SqlParameter[] paras = new SqlParameter[10];
			paras[0] = new SqlParameter("@BDBuildingHolidayMapPK", SqlDbType.UniqueIdentifier);
			if (entity.BDBuildingHolidayMapPK == Guid.Empty)
			{
				paras[0].Value = DBNull.Value;
			}
			else
			{
				paras[0].Value = entity.BDBuildingHolidayMapPK;
			}
			paras[1] = new SqlParameter("@BDBuildingPK", SqlDbType.UniqueIdentifier);
			if (entity.BDBuildingPK == Guid.Empty)
			{
				paras[1].Value = DBNull.Value;
			}
			else
			{
				paras[1].Value = entity.BDBuildingPK;
			}
			paras[2] = new SqlParameter("@UtilHolidayPK", SqlDbType.UniqueIdentifier);
			if (entity.UtilHolidayPK == Guid.Empty)
			{
				paras[2].Value = DBNull.Value;
			}
			else
			{
				paras[2].Value = entity.UtilHolidayPK;
			}
			paras[3] = new SqlParameter("@ActionID", SqlDbType.Int);
			paras[3].Value = entity.ActionID;
			paras[4] = new SqlParameter("@Notes", SqlDbType.VarChar, 256);
			paras[4].Value = entity.Notes;
			paras[5] = new SqlParameter("@RowVersion", SqlDbType.Timestamp);
			paras[5].Value = entity.RowVersion;
			paras[6] = new SqlParameter("@CreatedOn", SqlDbType.DateTime);
			paras[6].Value = entity.CreatedOn;
			paras[7] = new SqlParameter("@CreatedBy", SqlDbType.VarChar, 30);
			paras[7].Value = entity.CreatedBy;
			paras[8] = new SqlParameter("@ModifiedOn", SqlDbType.DateTime);
			paras[8].Value = entity.ModifiedOn;
			paras[9] = new SqlParameter("@ModifiedBy", SqlDbType.VarChar, 30);
			paras[9].Value = entity.ModifiedBy;
			return base.ExecuteNonQuery(sql, paras);
		}

		private BDBuildingHolidayMapData CreateDataByReader(SafeDataReader reader)
		{
			BDBuildingHolidayMapData data = new BDBuildingHolidayMapData {
				BDBuildingHolidayMapPK = (Guid) reader["BDBuildingHolidayMapPK"],
				BDBuildingPK = (Guid) reader["BDBuildingPK"],
				UtilHolidayPK = (Guid) reader["UtilHolidayPK"],
				ActionID = (Int32) reader["ActionID"],
				Notes = (String) reader["Notes"],
				RowVersion = (Byte[]) reader["RowVersion"],
				CreatedOn = (DateTime) reader["CreatedOn"],
				CreatedBy = (String) reader["CreatedBy"],
				ModifiedOn = (DateTime) reader["ModifiedOn"],
				ModifiedBy = (String) reader["ModifiedBy"],
				Address1 = (String) reader["Address1"],
				BuildingID = (Int32) reader["BuildingID"],
				Date = (DateTime) reader["Date"],
				Holiday = (String) reader["Holiday"]
			};
			data.AcceptChanges();
			return data;
		}

		private BDBuildingHolidayMapData FetchEntity(string where, SqlParameter[] paras)
		{
			BDBuildingHolidayMapData data = null;
			using (SafeDataReader reader = base.ExecuteDataReader(where, paras))
			{
				if (reader.Read())
				{
					data = this.CreateDataByReader(reader);
				}
				reader.Close();
			}
			return data;
		}

		private BDBuildingHolidayMapData FetchEntityEx(string sql, SqlParameter[] paras)
		{
			BDBuildingHolidayMapData data = null;
			using (SafeDataReader reader = base.ExecuteDataReaderEx(sql, paras))
			{
				if (reader.Read())
				{
					data = this.CreateDataByReader(reader);
				}
				reader.Close();
			}
			return data;
		}

		private BDBuildingHolidayMapDataCollection FetchCollection(string where, SqlParameter[] paras)
		{
			BDBuildingHolidayMapDataCollection list = new BDBuildingHolidayMapDataCollection();
			using (SafeDataReader reader = base.ExecuteDataReader(where, paras))
			{
				while(reader.Read())
				{
					BDBuildingHolidayMapData data = this.CreateDataByReader(reader);
					list.Add(data);
				}
				reader.Close();
			}
			return list;
		}

		private BDBuildingHolidayMapDataCollection FetchCollectionEx(string sql, SqlParameter[] paras)
		{
			BDBuildingHolidayMapDataCollection list = new BDBuildingHolidayMapDataCollection();
			using (SafeDataReader reader = base.ExecuteDataReaderEx(sql, paras))
			{
				while(reader.Read())
				{
					BDBuildingHolidayMapData data = this.CreateDataByReader(reader);
					list.Add(data);
				}
				reader.Close();
			}
			return list;
		}

		public BDBuildingHolidayMapData GetEntityBy(string sqlWhere, SqlParameter[] paras)
		{
			return this.FetchEntity(sqlWhere, paras);
		}

		public BDBuildingHolidayMapData GetEntityExBy(string sql, SqlParameter[] paras)
		{
			return this.FetchEntityEx(sql, paras);
		}

		public BDBuildingHolidayMapDataCollection GetCollectionBy(string sqlWhere, SqlParameter[] paras)
		{
			return this.FetchCollection(sqlWhere, paras);
		}

		public BDBuildingHolidayMapDataCollection GetCollectionExBy(string sql, SqlParameter[] paras)
		{
			return this.FetchCollectionEx(sql, paras);
		}

		public byte[] GetRowVersion( System.Guid BDBuildingHolidayMapPK)
		{
			string sql = string.Format("SELECT [RowVersion] AS [RowVersion] FROM [{0}] WHERE  [BDBuildingHolidayMapPK] = @BDBuildingHolidayMapPK ", this.TableName);
			SqlParameter[] paras = new SqlParameter[1];
			paras[0] = new SqlParameter("@BDBuildingHolidayMapPK", SqlDbType.UniqueIdentifier, 16);
			paras[0].Value = BDBuildingHolidayMapPK;
			return (byte[]) base.ExecuteScalar(sql, paras);
		}

		public BDBuildingHolidayMapData GetByPK( System.Guid BDBuildingHolidayMapPK)
		{
			string sql = " WHERE  [BDBuildingHolidayMap].[BDBuildingHolidayMapPK] = @BDBuildingHolidayMapPK ";
			SqlParameter[] paras = new SqlParameter[1];
			paras[0] = new SqlParameter("@BDBuildingHolidayMapPK", SqlDbType.UniqueIdentifier);
			paras[0].Value = BDBuildingHolidayMapPK;
			return this.FetchEntity(sql, paras);
		}

		public BDBuildingHolidayMapDataCollection GetAll()
		{
			return this.FetchCollection("", null);
		}

		public BDBuildingHolidayMapDataCollection GetByBDBuilding(System.Guid BDBuildingPK)
		{
			string sqlWhere = " WHERE [BDBuildingHolidayMap].[BDBuildingPK] = @BDBuildingPK";
			SqlParameter[] paras = new SqlParameter[1];
			paras[0] = new SqlParameter("@BDBuildingPK", SqlDbType.UniqueIdentifier);
			paras[0].Value = BDBuildingPK;
			return this.FetchCollection(sqlWhere, paras);
		}

		public BDBuildingHolidayMapDataCollection GetByUtilHoliday(System.Guid UtilHolidayPK)
		{
			string sqlWhere = " WHERE [BDBuildingHolidayMap].[UtilHolidayPK] = @UtilHolidayPK";
			SqlParameter[] paras = new SqlParameter[1];
			paras[0] = new SqlParameter("@UtilHolidayPK", SqlDbType.UniqueIdentifier);
			paras[0].Value = UtilHolidayPK;
			return this.FetchCollection(sqlWhere, paras);
		}

		public DataTable GetLogByPK( System.Guid BDBuildingHolidayMapPK)
		{
			string sql = string.Format("SELECT  [BDBuildingHolidayMap].[BDBuildingHolidayMapPK] AS [BDBuildingHolidayMapPK], [BDBuildingHolidayMap].[ModifiedOn] AS [ModifiedOn] FROM [{0}] WHERE  [BDBuildingHolidayMap].[BDBuildingHolidayMapPK] = @BDBuildingHolidayMapPK ", this.TableName);
			SqlParameter[] paras = new SqlParameter[1];
			paras[0] = new SqlParameter("@BDBuildingHolidayMapPK", SqlDbType.UniqueIdentifier);
			paras[0].Value = BDBuildingHolidayMapPK;
			return this.ExecuteDataTable(sql, paras);
		}

		public DataTable GetLogByBDBuilding(System.Guid bDBuildingPK)
		{
			string sql = string.Format("DELETE [{0}] FROM [{0}] [BDBuildingHolidayMap] INNER JOIN [BDBuilding] ON [BDBuildingHolidayMap].[BDBuildingPK] = [BDBuilding].[BDBuildingPK] WHERE [BDBuilding].[BDBuildingPK] = @BDBuildingPK;", this.TableName);
			string oldValue = string.Format("DELETE [{0}]", this.TableName);
			string newValue = "SELECT  [BDBuildingHolidayMap].[BDBuildingHolidayMapPK] AS [BDBuildingHolidayMapPK], [BDBuildingHolidayMap].[ModifiedOn] AS [ModifiedOn]";
			sql = sql.Replace(oldValue, newValue).TrimEnd().TrimEnd(';').Replace(";", " UNION ");
			SqlParameter[] paras = new SqlParameter[1];
			paras[0] = new SqlParameter("@BDBuildingPK", SqlDbType.UniqueIdentifier);
			paras[0].Value = bDBuildingPK;
			return base.ExecuteDataTable(sql, paras);
		}

		public DataTable GetLogByUtilHoliday(System.Guid utilHolidayPK)
		{
			string sql = string.Format("DELETE [{0}] FROM [{0}] [BDBuildingHolidayMap] INNER JOIN [UtilHoliday] ON [BDBuildingHolidayMap].[UtilHolidayPK] = [UtilHoliday].[UtilHolidayPK] WHERE [UtilHoliday].[UtilHolidayPK] = @UtilHolidayPK;", this.TableName);
			string oldValue = string.Format("DELETE [{0}]", this.TableName);
			string newValue = "SELECT  [BDBuildingHolidayMap].[BDBuildingHolidayMapPK] AS [BDBuildingHolidayMapPK], [BDBuildingHolidayMap].[ModifiedOn] AS [ModifiedOn]";
			sql = sql.Replace(oldValue, newValue).TrimEnd().TrimEnd(';').Replace(";", " UNION ");
			SqlParameter[] paras = new SqlParameter[1];
			paras[0] = new SqlParameter("@UtilHolidayPK", SqlDbType.UniqueIdentifier);
			paras[0].Value = utilHolidayPK;
			return base.ExecuteDataTable(sql, paras);
		}

		public int DeleteByPK( System.Guid BDBuildingHolidayMapPK, byte[] RowVersion)
		{
			string sql = string.Format("DELETE FROM [{0}] WHERE  [BDBuildingHolidayMapPK] = @BDBuildingHolidayMapPK AND [RowVersion] = @RowVersion", this.TableName);
			SqlParameter[] paras = new SqlParameter[2];
			paras[0] = new SqlParameter("@BDBuildingHolidayMapPK", SqlDbType.UniqueIdentifier);
			paras[0].Value = BDBuildingHolidayMapPK;
			paras[1] = new SqlParameter("@RowVersion", SqlDbType.Timestamp, 8);
			paras[1].Value = RowVersion;
			return base.ExecuteNonQuery(sql, paras);
		}

		public int DeleteAll()
		{
			string sql = string.Format("DELETE FROM [{0}]", this.TableName);
			return base.ExecuteNonQuery(sql, null);
		}

		public int DeleteByBDBuilding(System.Guid bDBuildingPK)
		{
			string sql = string.Format("DELETE [{0}] FROM [{0}] [BDBuildingHolidayMap] INNER JOIN [BDBuilding] ON [BDBuildingHolidayMap].[BDBuildingPK] = [BDBuilding].[BDBuildingPK] WHERE [BDBuilding].[BDBuildingPK] = @BDBuildingPK;", this.TableName);
			SqlParameter[] paras = new SqlParameter[1];
			paras[0] = new SqlParameter("@BDBuildingPK", SqlDbType.UniqueIdentifier);
			paras[0].Value = bDBuildingPK;
			return base.ExecuteNonQuery(sql, paras);
		}

		public int DeleteByUtilHoliday(System.Guid utilHolidayPK)
		{
			string sql = string.Format("DELETE [{0}] FROM [{0}] [BDBuildingHolidayMap] INNER JOIN [UtilHoliday] ON [BDBuildingHolidayMap].[UtilHolidayPK] = [UtilHoliday].[UtilHolidayPK] WHERE [UtilHoliday].[UtilHolidayPK] = @UtilHolidayPK;", this.TableName);
			SqlParameter[] paras = new SqlParameter[1];
			paras[0] = new SqlParameter("@UtilHolidayPK", SqlDbType.UniqueIdentifier);
			paras[0].Value = utilHolidayPK;
			return base.ExecuteNonQuery(sql, paras);
		}


	}
	public class ACOutputGroupCRUD : DataAccessBase
	{
		private string _tableName = "ACOutputGroup";

		public ACOutputGroupCRUD(string connectionString) : base(connectionString)
		{
		}

		public virtual string TableName
		{
			get { return this._tableName; }
			set { this._tableName = value; }
		}

		public string SQLColumns
		{
			get
			{
				return "[ACOutputGroup].[ACOutputGroupPK] AS [ACOutputGroupPK],[ACOutputGroup].[ACPanelPK] AS [ACPanelPK],[ACOutputGroup].[GroupID] AS [GroupID],[ACOutputGroup].[Summary] AS [Summary],[ACOutputGroup].[RowVersion] AS [RowVersion],[ACOutputGroup].[CreatedOn] AS [CreatedOn],[ACOutputGroup].[CreatedBy] AS [CreatedBy],[ACOutputGroup].[ModifiedOn] AS [ModifiedOn],[ACOutputGroup].[ModifiedBy] AS [ModifiedBy],[ACPanel].[BDBuildingPK] AS [BDBuildingPK],[ACPanel].[UnitID] AS [UnitID],[BDBuilding].[Address1] AS [Address1],[BDBuilding].[BuildingID] AS [BuildingID]";
			}
		}

		public string SQLLeftJoins
		{
			get
			{
				return "LEFT JOIN [ACPanel] [ACPanel] ON [ACOutputGroup].[ACPanelPK] = [ACPanel].[ACPanelPK] LEFT JOIN [BDBuilding] [BDBuilding] ON [ACPanel].[BDBuildingPK] = [BDBuilding].[BDBuildingPK]";
			}
		}

		protected override string SQLSelect
		{
			get
			{
				return string.Format("SELECT [ACOutputGroup].[ACOutputGroupPK] AS [ACOutputGroupPK],[ACOutputGroup].[ACPanelPK] AS [ACPanelPK],[ACOutputGroup].[GroupID] AS [GroupID],[ACOutputGroup].[Summary] AS [Summary],[ACOutputGroup].[RowVersion] AS [RowVersion],[ACOutputGroup].[CreatedOn] AS [CreatedOn],[ACOutputGroup].[CreatedBy] AS [CreatedBy],[ACOutputGroup].[ModifiedOn] AS [ModifiedOn],[ACOutputGroup].[ModifiedBy] AS [ModifiedBy],[ACPanel].[BDBuildingPK] AS [BDBuildingPK],[ACPanel].[UnitID] AS [UnitID],[BDBuilding].[Address1] AS [Address1],[BDBuilding].[BuildingID] AS [BuildingID] FROM [{0}] [ACOutputGroup] LEFT JOIN [ACPanel] [ACPanel] ON [ACOutputGroup].[ACPanelPK] = [ACPanel].[ACPanelPK] LEFT JOIN [BDBuilding] [BDBuilding] ON [ACPanel].[BDBuildingPK] = [BDBuilding].[BDBuildingPK]", this.TableName);
			}
		}

		protected override string SQLCount
		{
			get
			{
				return string.Format("SELECT COUNT(*) FROM [{0}] [ACOutputGroup] LEFT JOIN [ACPanel] [ACPanel] ON [ACOutputGroup].[ACPanelPK] = [ACPanel].[ACPanelPK] LEFT JOIN [BDBuilding] [BDBuilding] ON [ACPanel].[BDBuildingPK] = [BDBuilding].[BDBuildingPK]", this.TableName);
			}
		}

		public int Insert(ACOutputGroupData entity)
		{
			string sql = string.Format("INSERT INTO [{0}] ([ACOutputGroupPK],[ACPanelPK],[GroupID],[Summary],[CreatedOn],[CreatedBy],[ModifiedOn],[ModifiedBy]) VALUES(@ACOutputGroupPK,@ACPanelPK,@GroupID,@Summary,@CreatedOn,@CreatedBy,@ModifiedOn,@ModifiedBy)", this.TableName);
			SqlParameter[] paras = new SqlParameter[8];
			paras[0] = new SqlParameter("@ACOutputGroupPK", SqlDbType.UniqueIdentifier);
			if (entity.ACOutputGroupPK == Guid.Empty)
			{
				paras[0].Value = DBNull.Value;
			}
			else
			{
				paras[0].Value = entity.ACOutputGroupPK;
			}
			paras[1] = new SqlParameter("@ACPanelPK", SqlDbType.UniqueIdentifier);
			if (entity.ACPanelPK == Guid.Empty)
			{
				paras[1].Value = DBNull.Value;
			}
			else
			{
				paras[1].Value = entity.ACPanelPK;
			}
			paras[2] = new SqlParameter("@GroupID", SqlDbType.TinyInt);
			paras[2].Value = entity.GroupID;
			paras[3] = new SqlParameter("@Summary", SqlDbType.VarChar, 256);
			paras[3].Value = entity.Summary;
			paras[4] = new SqlParameter("@CreatedOn", SqlDbType.DateTime);
			paras[4].Value = entity.CreatedOn;
			paras[5] = new SqlParameter("@CreatedBy", SqlDbType.VarChar, 30);
			paras[5].Value = entity.CreatedBy;
			paras[6] = new SqlParameter("@ModifiedOn", SqlDbType.DateTime);
			paras[6].Value = entity.ModifiedOn;
			paras[7] = new SqlParameter("@ModifiedBy", SqlDbType.VarChar, 30);
			paras[7].Value = entity.ModifiedBy;
			return base.ExecuteNonQuery(sql, paras);
		}

		public int Update(ACOutputGroupData entity)
		{
			string sql = string.Format("UPDATE [{0}] SET [ACPanelPK] = @ACPanelPK,[GroupID] = @GroupID,[Summary] = @Summary,[CreatedOn] = @CreatedOn,[CreatedBy] = @CreatedBy,[ModifiedOn] = @ModifiedOn,[ModifiedBy] = @ModifiedBy  WHERE [ACOutputGroupPK] = @ACOutputGroupPK AND [RowVersion] = @RowVersion", this.TableName);
			SqlParameter[] paras = new SqlParameter[9];
			paras[0] = new SqlParameter("@ACOutputGroupPK", SqlDbType.UniqueIdentifier);
			if (entity.ACOutputGroupPK == Guid.Empty)
			{
				paras[0].Value = DBNull.Value;
			}
			else
			{
				paras[0].Value = entity.ACOutputGroupPK;
			}
			paras[1] = new SqlParameter("@ACPanelPK", SqlDbType.UniqueIdentifier);
			if (entity.ACPanelPK == Guid.Empty)
			{
				paras[1].Value = DBNull.Value;
			}
			else
			{
				paras[1].Value = entity.ACPanelPK;
			}
			paras[2] = new SqlParameter("@GroupID", SqlDbType.TinyInt);
			paras[2].Value = entity.GroupID;
			paras[3] = new SqlParameter("@Summary", SqlDbType.VarChar, 256);
			paras[3].Value = entity.Summary;
			paras[4] = new SqlParameter("@RowVersion", SqlDbType.Timestamp);
			paras[4].Value = entity.RowVersion;
			paras[5] = new SqlParameter("@CreatedOn", SqlDbType.DateTime);
			paras[5].Value = entity.CreatedOn;
			paras[6] = new SqlParameter("@CreatedBy", SqlDbType.VarChar, 30);
			paras[6].Value = entity.CreatedBy;
			paras[7] = new SqlParameter("@ModifiedOn", SqlDbType.DateTime);
			paras[7].Value = entity.ModifiedOn;
			paras[8] = new SqlParameter("@ModifiedBy", SqlDbType.VarChar, 30);
			paras[8].Value = entity.ModifiedBy;
			return base.ExecuteNonQuery(sql, paras);
		}

		private ACOutputGroupData CreateDataByReader(SafeDataReader reader)
		{
			ACOutputGroupData data = new ACOutputGroupData {
				ACOutputGroupPK = (Guid) reader["ACOutputGroupPK"],
				ACPanelPK = (Guid) reader["ACPanelPK"],
				GroupID = (Byte) reader["GroupID"],
				Summary = (String) reader["Summary"],
				RowVersion = (Byte[]) reader["RowVersion"],
				CreatedOn = (DateTime) reader["CreatedOn"],
				CreatedBy = (String) reader["CreatedBy"],
				ModifiedOn = (DateTime) reader["ModifiedOn"],
				ModifiedBy = (String) reader["ModifiedBy"],
				BDBuildingPK = (Guid) reader["BDBuildingPK"],
				UnitID = (Int32) reader["UnitID"],
				Address1 = (String) reader["Address1"],
				BuildingID = (Int32) reader["BuildingID"]
			};
			data.AcceptChanges();
			return data;
		}

		private ACOutputGroupData FetchEntity(string where, SqlParameter[] paras)
		{
			ACOutputGroupData data = null;
			using (SafeDataReader reader = base.ExecuteDataReader(where, paras))
			{
				if (reader.Read())
				{
					data = this.CreateDataByReader(reader);
				}
				reader.Close();
			}
			return data;
		}

		private ACOutputGroupData FetchEntityEx(string sql, SqlParameter[] paras)
		{
			ACOutputGroupData data = null;
			using (SafeDataReader reader = base.ExecuteDataReaderEx(sql, paras))
			{
				if (reader.Read())
				{
					data = this.CreateDataByReader(reader);
				}
				reader.Close();
			}
			return data;
		}

		private ACOutputGroupDataCollection FetchCollection(string where, SqlParameter[] paras)
		{
			ACOutputGroupDataCollection list = new ACOutputGroupDataCollection();
			using (SafeDataReader reader = base.ExecuteDataReader(where, paras))
			{
				while(reader.Read())
				{
					ACOutputGroupData data = this.CreateDataByReader(reader);
					list.Add(data);
				}
				reader.Close();
			}
			return list;
		}

		private ACOutputGroupDataCollection FetchCollectionEx(string sql, SqlParameter[] paras)
		{
			ACOutputGroupDataCollection list = new ACOutputGroupDataCollection();
			using (SafeDataReader reader = base.ExecuteDataReaderEx(sql, paras))
			{
				while(reader.Read())
				{
					ACOutputGroupData data = this.CreateDataByReader(reader);
					list.Add(data);
				}
				reader.Close();
			}
			return list;
		}

		public ACOutputGroupData GetEntityBy(string sqlWhere, SqlParameter[] paras)
		{
			return this.FetchEntity(sqlWhere, paras);
		}

		public ACOutputGroupData GetEntityExBy(string sql, SqlParameter[] paras)
		{
			return this.FetchEntityEx(sql, paras);
		}

		public ACOutputGroupDataCollection GetCollectionBy(string sqlWhere, SqlParameter[] paras)
		{
			return this.FetchCollection(sqlWhere, paras);
		}

		public ACOutputGroupDataCollection GetCollectionExBy(string sql, SqlParameter[] paras)
		{
			return this.FetchCollectionEx(sql, paras);
		}

		public byte[] GetRowVersion( System.Guid ACOutputGroupPK)
		{
			string sql = string.Format("SELECT [RowVersion] AS [RowVersion] FROM [{0}] WHERE  [ACOutputGroupPK] = @ACOutputGroupPK ", this.TableName);
			SqlParameter[] paras = new SqlParameter[1];
			paras[0] = new SqlParameter("@ACOutputGroupPK", SqlDbType.UniqueIdentifier, 16);
			paras[0].Value = ACOutputGroupPK;
			return (byte[]) base.ExecuteScalar(sql, paras);
		}

		public ACOutputGroupData GetByPK( System.Guid ACOutputGroupPK)
		{
			string sql = " WHERE  [ACOutputGroup].[ACOutputGroupPK] = @ACOutputGroupPK ";
			SqlParameter[] paras = new SqlParameter[1];
			paras[0] = new SqlParameter("@ACOutputGroupPK", SqlDbType.UniqueIdentifier);
			paras[0].Value = ACOutputGroupPK;
			return this.FetchEntity(sql, paras);
		}

		public ACOutputGroupDataCollection GetAll()
		{
			return this.FetchCollection("", null);
		}

		public ACOutputGroupDataCollection GetByACPanel(System.Guid ACPanelPK)
		{
			string sqlWhere = " WHERE [ACOutputGroup].[ACPanelPK] = @ACPanelPK";
			SqlParameter[] paras = new SqlParameter[1];
			paras[0] = new SqlParameter("@ACPanelPK", SqlDbType.UniqueIdentifier);
			paras[0].Value = ACPanelPK;
			return this.FetchCollection(sqlWhere, paras);
		}

		public DataTable GetLogByPK( System.Guid ACOutputGroupPK)
		{
			string sql = string.Format("SELECT  [ACOutputGroup].[ACOutputGroupPK] AS [ACOutputGroupPK], [ACOutputGroup].[ModifiedOn] AS [ModifiedOn] FROM [{0}] WHERE  [ACOutputGroup].[ACOutputGroupPK] = @ACOutputGroupPK ", this.TableName);
			SqlParameter[] paras = new SqlParameter[1];
			paras[0] = new SqlParameter("@ACOutputGroupPK", SqlDbType.UniqueIdentifier);
			paras[0].Value = ACOutputGroupPK;
			return this.ExecuteDataTable(sql, paras);
		}

		public DataTable GetLogByACPanel(System.Guid aCPanelPK)
		{
			string sql = string.Format("DELETE [{0}] FROM [{0}] [ACOutputGroup] INNER JOIN [ACPanel] ON [ACOutputGroup].[ACPanelPK] = [ACPanel].[ACPanelPK] WHERE [ACPanel].[ACPanelPK] = @ACPanelPK;", this.TableName);
			string oldValue = string.Format("DELETE [{0}]", this.TableName);
			string newValue = "SELECT  [ACOutputGroup].[ACOutputGroupPK] AS [ACOutputGroupPK], [ACOutputGroup].[ModifiedOn] AS [ModifiedOn]";
			sql = sql.Replace(oldValue, newValue).TrimEnd().TrimEnd(';').Replace(";", " UNION ");
			SqlParameter[] paras = new SqlParameter[1];
			paras[0] = new SqlParameter("@ACPanelPK", SqlDbType.UniqueIdentifier);
			paras[0].Value = aCPanelPK;
			return base.ExecuteDataTable(sql, paras);
		}

		public DataTable GetLogByBDBuilding(System.Guid bDBuildingPK)
		{
			string sql = string.Format("DELETE [{0}] FROM [{0}] [ACOutputGroup] INNER JOIN [ACPanel] ON [ACOutputGroup].[ACPanelPK] = [ACPanel].[ACPanelPK] INNER JOIN [BDBuilding] ON [ACPanel].[BDBuildingPK] = [BDBuilding].[BDBuildingPK] WHERE [BDBuilding].[BDBuildingPK] = @BDBuildingPK;", this.TableName);
			string oldValue = string.Format("DELETE [{0}]", this.TableName);
			string newValue = "SELECT  [ACOutputGroup].[ACOutputGroupPK] AS [ACOutputGroupPK], [ACOutputGroup].[ModifiedOn] AS [ModifiedOn]";
			sql = sql.Replace(oldValue, newValue).TrimEnd().TrimEnd(';').Replace(";", " UNION ");
			SqlParameter[] paras = new SqlParameter[1];
			paras[0] = new SqlParameter("@BDBuildingPK", SqlDbType.UniqueIdentifier);
			paras[0].Value = bDBuildingPK;
			return base.ExecuteDataTable(sql, paras);
		}

		public int DeleteByPK( System.Guid ACOutputGroupPK, byte[] RowVersion)
		{
			string sql = string.Format("DELETE FROM [{0}] WHERE  [ACOutputGroupPK] = @ACOutputGroupPK AND [RowVersion] = @RowVersion", this.TableName);
			SqlParameter[] paras = new SqlParameter[2];
			paras[0] = new SqlParameter("@ACOutputGroupPK", SqlDbType.UniqueIdentifier);
			paras[0].Value = ACOutputGroupPK;
			paras[1] = new SqlParameter("@RowVersion", SqlDbType.Timestamp, 8);
			paras[1].Value = RowVersion;
			return base.ExecuteNonQuery(sql, paras);
		}

		public int DeleteAll()
		{
			string sql = string.Format("DELETE FROM [{0}]", this.TableName);
			return base.ExecuteNonQuery(sql, null);
		}

		public int DeleteByACPanel(System.Guid aCPanelPK)
		{
			string sql = string.Format("DELETE [{0}] FROM [{0}] [ACOutputGroup] INNER JOIN [ACPanel] ON [ACOutputGroup].[ACPanelPK] = [ACPanel].[ACPanelPK] WHERE [ACPanel].[ACPanelPK] = @ACPanelPK;", this.TableName);
			SqlParameter[] paras = new SqlParameter[1];
			paras[0] = new SqlParameter("@ACPanelPK", SqlDbType.UniqueIdentifier);
			paras[0].Value = aCPanelPK;
			return base.ExecuteNonQuery(sql, paras);
		}

		public int DeleteByBDBuilding(System.Guid bDBuildingPK)
		{
			string sql = string.Format("DELETE [{0}] FROM [{0}] [ACOutputGroup] INNER JOIN [ACPanel] ON [ACOutputGroup].[ACPanelPK] = [ACPanel].[ACPanelPK] INNER JOIN [BDBuilding] ON [ACPanel].[BDBuildingPK] = [BDBuilding].[BDBuildingPK] WHERE [BDBuilding].[BDBuildingPK] = @BDBuildingPK;", this.TableName);
			SqlParameter[] paras = new SqlParameter[1];
			paras[0] = new SqlParameter("@BDBuildingPK", SqlDbType.UniqueIdentifier);
			paras[0].Value = bDBuildingPK;
			return base.ExecuteNonQuery(sql, paras);
		}


	}
	public class BDTenantHolidayMapCRUD : DataAccessBase
	{
		private string _tableName = "BDTenantHolidayMap";

		public BDTenantHolidayMapCRUD(string connectionString) : base(connectionString)
		{
		}

		public virtual string TableName
		{
			get { return this._tableName; }
			set { this._tableName = value; }
		}

		public string SQLColumns
		{
			get
			{
				return "[BDTenantHolidayMap].[BDTenantHolidayMapPK] AS [BDTenantHolidayMapPK],[BDTenantHolidayMap].[BDTenantPK] AS [BDTenantPK],[BDTenantHolidayMap].[UtilHolidayPK] AS [UtilHolidayPK],[BDTenantHolidayMap].[ActionID] AS [ActionID],[BDTenantHolidayMap].[Notes] AS [Notes],[BDTenantHolidayMap].[RowVersion] AS [RowVersion],[BDTenantHolidayMap].[CreatedOn] AS [CreatedOn],[BDTenantHolidayMap].[CreatedBy] AS [CreatedBy],[BDTenantHolidayMap].[ModifiedOn] AS [ModifiedOn],[BDTenantHolidayMap].[ModifiedBy] AS [ModifiedBy],[BDTenant].[Tenant] AS [Tenant],[BDTenant].[BDBuildingPK] AS [BDBuildingPK],[UtilHoliday].[Date] AS [Date],[UtilHoliday].[Holiday] AS [Holiday],[BDBuilding].[Address1] AS [Address1],[BDBuilding].[BuildingID] AS [BuildingID]";
			}
		}

		public string SQLLeftJoins
		{
			get
			{
				return "LEFT JOIN [BDTenant] [BDTenant] ON [BDTenantHolidayMap].[BDTenantPK] = [BDTenant].[BDTenantPK] LEFT JOIN [UtilHoliday] [UtilHoliday] ON [BDTenantHolidayMap].[UtilHolidayPK] = [UtilHoliday].[UtilHolidayPK] LEFT JOIN [BDBuilding] [BDBuilding] ON [BDTenant].[BDBuildingPK] = [BDBuilding].[BDBuildingPK]";
			}
		}

		protected override string SQLSelect
		{
			get
			{
				return string.Format("SELECT [BDTenantHolidayMap].[BDTenantHolidayMapPK] AS [BDTenantHolidayMapPK],[BDTenantHolidayMap].[BDTenantPK] AS [BDTenantPK],[BDTenantHolidayMap].[UtilHolidayPK] AS [UtilHolidayPK],[BDTenantHolidayMap].[ActionID] AS [ActionID],[BDTenantHolidayMap].[Notes] AS [Notes],[BDTenantHolidayMap].[RowVersion] AS [RowVersion],[BDTenantHolidayMap].[CreatedOn] AS [CreatedOn],[BDTenantHolidayMap].[CreatedBy] AS [CreatedBy],[BDTenantHolidayMap].[ModifiedOn] AS [ModifiedOn],[BDTenantHolidayMap].[ModifiedBy] AS [ModifiedBy],[BDTenant].[Tenant] AS [Tenant],[BDTenant].[BDBuildingPK] AS [BDBuildingPK],[UtilHoliday].[Date] AS [Date],[UtilHoliday].[Holiday] AS [Holiday],[BDBuilding].[Address1] AS [Address1],[BDBuilding].[BuildingID] AS [BuildingID] FROM [{0}] [BDTenantHolidayMap] LEFT JOIN [BDTenant] [BDTenant] ON [BDTenantHolidayMap].[BDTenantPK] = [BDTenant].[BDTenantPK] LEFT JOIN [UtilHoliday] [UtilHoliday] ON [BDTenantHolidayMap].[UtilHolidayPK] = [UtilHoliday].[UtilHolidayPK] LEFT JOIN [BDBuilding] [BDBuilding] ON [BDTenant].[BDBuildingPK] = [BDBuilding].[BDBuildingPK]", this.TableName);
			}
		}

		protected override string SQLCount
		{
			get
			{
				return string.Format("SELECT COUNT(*) FROM [{0}] [BDTenantHolidayMap] LEFT JOIN [BDTenant] [BDTenant] ON [BDTenantHolidayMap].[BDTenantPK] = [BDTenant].[BDTenantPK] LEFT JOIN [UtilHoliday] [UtilHoliday] ON [BDTenantHolidayMap].[UtilHolidayPK] = [UtilHoliday].[UtilHolidayPK] LEFT JOIN [BDBuilding] [BDBuilding] ON [BDTenant].[BDBuildingPK] = [BDBuilding].[BDBuildingPK]", this.TableName);
			}
		}

		public int Insert(BDTenantHolidayMapData entity)
		{
			string sql = string.Format("INSERT INTO [{0}] ([BDTenantHolidayMapPK],[BDTenantPK],[UtilHolidayPK],[ActionID],[Notes],[CreatedOn],[CreatedBy],[ModifiedOn],[ModifiedBy]) VALUES(@BDTenantHolidayMapPK,@BDTenantPK,@UtilHolidayPK,@ActionID,@Notes,@CreatedOn,@CreatedBy,@ModifiedOn,@ModifiedBy)", this.TableName);
			SqlParameter[] paras = new SqlParameter[9];
			paras[0] = new SqlParameter("@BDTenantHolidayMapPK", SqlDbType.UniqueIdentifier);
			if (entity.BDTenantHolidayMapPK == Guid.Empty)
			{
				paras[0].Value = DBNull.Value;
			}
			else
			{
				paras[0].Value = entity.BDTenantHolidayMapPK;
			}
			paras[1] = new SqlParameter("@BDTenantPK", SqlDbType.UniqueIdentifier);
			if (entity.BDTenantPK == Guid.Empty)
			{
				paras[1].Value = DBNull.Value;
			}
			else
			{
				paras[1].Value = entity.BDTenantPK;
			}
			paras[2] = new SqlParameter("@UtilHolidayPK", SqlDbType.UniqueIdentifier);
			if (entity.UtilHolidayPK == Guid.Empty)
			{
				paras[2].Value = DBNull.Value;
			}
			else
			{
				paras[2].Value = entity.UtilHolidayPK;
			}
			paras[3] = new SqlParameter("@ActionID", SqlDbType.Int);
			paras[3].Value = entity.ActionID;
			paras[4] = new SqlParameter("@Notes", SqlDbType.VarChar, 256);
			paras[4].Value = entity.Notes;
			paras[5] = new SqlParameter("@CreatedOn", SqlDbType.DateTime);
			paras[5].Value = entity.CreatedOn;
			paras[6] = new SqlParameter("@CreatedBy", SqlDbType.VarChar, 30);
			paras[6].Value = entity.CreatedBy;
			paras[7] = new SqlParameter("@ModifiedOn", SqlDbType.DateTime);
			paras[7].Value = entity.ModifiedOn;
			paras[8] = new SqlParameter("@ModifiedBy", SqlDbType.VarChar, 30);
			paras[8].Value = entity.ModifiedBy;
			return base.ExecuteNonQuery(sql, paras);
		}

		public int Update(BDTenantHolidayMapData entity)
		{
			string sql = string.Format("UPDATE [{0}] SET [BDTenantPK] = @BDTenantPK,[UtilHolidayPK] = @UtilHolidayPK,[ActionID] = @ActionID,[Notes] = @Notes,[CreatedOn] = @CreatedOn,[CreatedBy] = @CreatedBy,[ModifiedOn] = @ModifiedOn,[ModifiedBy] = @ModifiedBy  WHERE [BDTenantHolidayMapPK] = @BDTenantHolidayMapPK AND [RowVersion] = @RowVersion", this.TableName);
			SqlParameter[] paras = new SqlParameter[10];
			paras[0] = new SqlParameter("@BDTenantHolidayMapPK", SqlDbType.UniqueIdentifier);
			if (entity.BDTenantHolidayMapPK == Guid.Empty)
			{
				paras[0].Value = DBNull.Value;
			}
			else
			{
				paras[0].Value = entity.BDTenantHolidayMapPK;
			}
			paras[1] = new SqlParameter("@BDTenantPK", SqlDbType.UniqueIdentifier);
			if (entity.BDTenantPK == Guid.Empty)
			{
				paras[1].Value = DBNull.Value;
			}
			else
			{
				paras[1].Value = entity.BDTenantPK;
			}
			paras[2] = new SqlParameter("@UtilHolidayPK", SqlDbType.UniqueIdentifier);
			if (entity.UtilHolidayPK == Guid.Empty)
			{
				paras[2].Value = DBNull.Value;
			}
			else
			{
				paras[2].Value = entity.UtilHolidayPK;
			}
			paras[3] = new SqlParameter("@ActionID", SqlDbType.Int);
			paras[3].Value = entity.ActionID;
			paras[4] = new SqlParameter("@Notes", SqlDbType.VarChar, 256);
			paras[4].Value = entity.Notes;
			paras[5] = new SqlParameter("@RowVersion", SqlDbType.Timestamp);
			paras[5].Value = entity.RowVersion;
			paras[6] = new SqlParameter("@CreatedOn", SqlDbType.DateTime);
			paras[6].Value = entity.CreatedOn;
			paras[7] = new SqlParameter("@CreatedBy", SqlDbType.VarChar, 30);
			paras[7].Value = entity.CreatedBy;
			paras[8] = new SqlParameter("@ModifiedOn", SqlDbType.DateTime);
			paras[8].Value = entity.ModifiedOn;
			paras[9] = new SqlParameter("@ModifiedBy", SqlDbType.VarChar, 30);
			paras[9].Value = entity.ModifiedBy;
			return base.ExecuteNonQuery(sql, paras);
		}

		private BDTenantHolidayMapData CreateDataByReader(SafeDataReader reader)
		{
			BDTenantHolidayMapData data = new BDTenantHolidayMapData {
				BDTenantHolidayMapPK = (Guid) reader["BDTenantHolidayMapPK"],
				BDTenantPK = (Guid) reader["BDTenantPK"],
				UtilHolidayPK = (Guid) reader["UtilHolidayPK"],
				ActionID = (Int32) reader["ActionID"],
				Notes = (String) reader["Notes"],
				RowVersion = (Byte[]) reader["RowVersion"],
				CreatedOn = (DateTime) reader["CreatedOn"],
				CreatedBy = (String) reader["CreatedBy"],
				ModifiedOn = (DateTime) reader["ModifiedOn"],
				ModifiedBy = (String) reader["ModifiedBy"],
				Tenant = (String) reader["Tenant"],
				BDBuildingPK = (Guid) reader["BDBuildingPK"],
				Date = (DateTime) reader["Date"],
				Holiday = (String) reader["Holiday"],
				Address1 = (String) reader["Address1"],
				BuildingID = (Int32) reader["BuildingID"]
			};
			data.AcceptChanges();
			return data;
		}

		private BDTenantHolidayMapData FetchEntity(string where, SqlParameter[] paras)
		{
			BDTenantHolidayMapData data = null;
			using (SafeDataReader reader = base.ExecuteDataReader(where, paras))
			{
				if (reader.Read())
				{
					data = this.CreateDataByReader(reader);
				}
				reader.Close();
			}
			return data;
		}

		private BDTenantHolidayMapData FetchEntityEx(string sql, SqlParameter[] paras)
		{
			BDTenantHolidayMapData data = null;
			using (SafeDataReader reader = base.ExecuteDataReaderEx(sql, paras))
			{
				if (reader.Read())
				{
					data = this.CreateDataByReader(reader);
				}
				reader.Close();
			}
			return data;
		}

		private BDTenantHolidayMapDataCollection FetchCollection(string where, SqlParameter[] paras)
		{
			BDTenantHolidayMapDataCollection list = new BDTenantHolidayMapDataCollection();
			using (SafeDataReader reader = base.ExecuteDataReader(where, paras))
			{
				while(reader.Read())
				{
					BDTenantHolidayMapData data = this.CreateDataByReader(reader);
					list.Add(data);
				}
				reader.Close();
			}
			return list;
		}

		private BDTenantHolidayMapDataCollection FetchCollectionEx(string sql, SqlParameter[] paras)
		{
			BDTenantHolidayMapDataCollection list = new BDTenantHolidayMapDataCollection();
			using (SafeDataReader reader = base.ExecuteDataReaderEx(sql, paras))
			{
				while(reader.Read())
				{
					BDTenantHolidayMapData data = this.CreateDataByReader(reader);
					list.Add(data);
				}
				reader.Close();
			}
			return list;
		}

		public BDTenantHolidayMapData GetEntityBy(string sqlWhere, SqlParameter[] paras)
		{
			return this.FetchEntity(sqlWhere, paras);
		}

		public BDTenantHolidayMapData GetEntityExBy(string sql, SqlParameter[] paras)
		{
			return this.FetchEntityEx(sql, paras);
		}

		public BDTenantHolidayMapDataCollection GetCollectionBy(string sqlWhere, SqlParameter[] paras)
		{
			return this.FetchCollection(sqlWhere, paras);
		}

		public BDTenantHolidayMapDataCollection GetCollectionExBy(string sql, SqlParameter[] paras)
		{
			return this.FetchCollectionEx(sql, paras);
		}

		public byte[] GetRowVersion( System.Guid BDTenantHolidayMapPK)
		{
			string sql = string.Format("SELECT [RowVersion] AS [RowVersion] FROM [{0}] WHERE  [BDTenantHolidayMapPK] = @BDTenantHolidayMapPK ", this.TableName);
			SqlParameter[] paras = new SqlParameter[1];
			paras[0] = new SqlParameter("@BDTenantHolidayMapPK", SqlDbType.UniqueIdentifier, 16);
			paras[0].Value = BDTenantHolidayMapPK;
			return (byte[]) base.ExecuteScalar(sql, paras);
		}

		public BDTenantHolidayMapData GetByPK( System.Guid BDTenantHolidayMapPK)
		{
			string sql = " WHERE  [BDTenantHolidayMap].[BDTenantHolidayMapPK] = @BDTenantHolidayMapPK ";
			SqlParameter[] paras = new SqlParameter[1];
			paras[0] = new SqlParameter("@BDTenantHolidayMapPK", SqlDbType.UniqueIdentifier);
			paras[0].Value = BDTenantHolidayMapPK;
			return this.FetchEntity(sql, paras);
		}

		public BDTenantHolidayMapDataCollection GetAll()
		{
			return this.FetchCollection("", null);
		}

		public BDTenantHolidayMapDataCollection GetByBDTenant(System.Guid BDTenantPK)
		{
			string sqlWhere = " WHERE [BDTenantHolidayMap].[BDTenantPK] = @BDTenantPK";
			SqlParameter[] paras = new SqlParameter[1];
			paras[0] = new SqlParameter("@BDTenantPK", SqlDbType.UniqueIdentifier);
			paras[0].Value = BDTenantPK;
			return this.FetchCollection(sqlWhere, paras);
		}

		public BDTenantHolidayMapDataCollection GetByUtilHoliday(System.Guid UtilHolidayPK)
		{
			string sqlWhere = " WHERE [BDTenantHolidayMap].[UtilHolidayPK] = @UtilHolidayPK";
			SqlParameter[] paras = new SqlParameter[1];
			paras[0] = new SqlParameter("@UtilHolidayPK", SqlDbType.UniqueIdentifier);
			paras[0].Value = UtilHolidayPK;
			return this.FetchCollection(sqlWhere, paras);
		}

		public DataTable GetLogByPK( System.Guid BDTenantHolidayMapPK)
		{
			string sql = string.Format("SELECT  [BDTenantHolidayMap].[BDTenantHolidayMapPK] AS [BDTenantHolidayMapPK], [BDTenantHolidayMap].[ModifiedOn] AS [ModifiedOn] FROM [{0}] WHERE  [BDTenantHolidayMap].[BDTenantHolidayMapPK] = @BDTenantHolidayMapPK ", this.TableName);
			SqlParameter[] paras = new SqlParameter[1];
			paras[0] = new SqlParameter("@BDTenantHolidayMapPK", SqlDbType.UniqueIdentifier);
			paras[0].Value = BDTenantHolidayMapPK;
			return this.ExecuteDataTable(sql, paras);
		}

		public DataTable GetLogByBDTenant(System.Guid bDTenantPK)
		{
			string sql = string.Format("DELETE [{0}] FROM [{0}] [BDTenantHolidayMap] INNER JOIN [BDTenant] ON [BDTenantHolidayMap].[BDTenantPK] = [BDTenant].[BDTenantPK] WHERE [BDTenant].[BDTenantPK] = @BDTenantPK;", this.TableName);
			string oldValue = string.Format("DELETE [{0}]", this.TableName);
			string newValue = "SELECT  [BDTenantHolidayMap].[BDTenantHolidayMapPK] AS [BDTenantHolidayMapPK], [BDTenantHolidayMap].[ModifiedOn] AS [ModifiedOn]";
			sql = sql.Replace(oldValue, newValue).TrimEnd().TrimEnd(';').Replace(";", " UNION ");
			SqlParameter[] paras = new SqlParameter[1];
			paras[0] = new SqlParameter("@BDTenantPK", SqlDbType.UniqueIdentifier);
			paras[0].Value = bDTenantPK;
			return base.ExecuteDataTable(sql, paras);
		}

		public DataTable GetLogByBDBuilding(System.Guid bDBuildingPK)
		{
			string sql = string.Format("DELETE [{0}] FROM [{0}] [BDTenantHolidayMap] INNER JOIN [BDTenant] ON [BDTenantHolidayMap].[BDTenantPK] = [BDTenant].[BDTenantPK] INNER JOIN [BDBuilding] ON [BDTenant].[BDBuildingPK] = [BDBuilding].[BDBuildingPK] WHERE [BDBuilding].[BDBuildingPK] = @BDBuildingPK;", this.TableName);
			string oldValue = string.Format("DELETE [{0}]", this.TableName);
			string newValue = "SELECT  [BDTenantHolidayMap].[BDTenantHolidayMapPK] AS [BDTenantHolidayMapPK], [BDTenantHolidayMap].[ModifiedOn] AS [ModifiedOn]";
			sql = sql.Replace(oldValue, newValue).TrimEnd().TrimEnd(';').Replace(";", " UNION ");
			SqlParameter[] paras = new SqlParameter[1];
			paras[0] = new SqlParameter("@BDBuildingPK", SqlDbType.UniqueIdentifier);
			paras[0].Value = bDBuildingPK;
			return base.ExecuteDataTable(sql, paras);
		}

		public DataTable GetLogByUtilHoliday(System.Guid utilHolidayPK)
		{
			string sql = string.Format("DELETE [{0}] FROM [{0}] [BDTenantHolidayMap] INNER JOIN [UtilHoliday] ON [BDTenantHolidayMap].[UtilHolidayPK] = [UtilHoliday].[UtilHolidayPK] WHERE [UtilHoliday].[UtilHolidayPK] = @UtilHolidayPK;", this.TableName);
			string oldValue = string.Format("DELETE [{0}]", this.TableName);
			string newValue = "SELECT  [BDTenantHolidayMap].[BDTenantHolidayMapPK] AS [BDTenantHolidayMapPK], [BDTenantHolidayMap].[ModifiedOn] AS [ModifiedOn]";
			sql = sql.Replace(oldValue, newValue).TrimEnd().TrimEnd(';').Replace(";", " UNION ");
			SqlParameter[] paras = new SqlParameter[1];
			paras[0] = new SqlParameter("@UtilHolidayPK", SqlDbType.UniqueIdentifier);
			paras[0].Value = utilHolidayPK;
			return base.ExecuteDataTable(sql, paras);
		}

		public int DeleteByPK( System.Guid BDTenantHolidayMapPK, byte[] RowVersion)
		{
			string sql = string.Format("DELETE FROM [{0}] WHERE  [BDTenantHolidayMapPK] = @BDTenantHolidayMapPK AND [RowVersion] = @RowVersion", this.TableName);
			SqlParameter[] paras = new SqlParameter[2];
			paras[0] = new SqlParameter("@BDTenantHolidayMapPK", SqlDbType.UniqueIdentifier);
			paras[0].Value = BDTenantHolidayMapPK;
			paras[1] = new SqlParameter("@RowVersion", SqlDbType.Timestamp, 8);
			paras[1].Value = RowVersion;
			return base.ExecuteNonQuery(sql, paras);
		}

		public int DeleteAll()
		{
			string sql = string.Format("DELETE FROM [{0}]", this.TableName);
			return base.ExecuteNonQuery(sql, null);
		}

		public int DeleteByBDTenant(System.Guid bDTenantPK)
		{
			string sql = string.Format("DELETE [{0}] FROM [{0}] [BDTenantHolidayMap] INNER JOIN [BDTenant] ON [BDTenantHolidayMap].[BDTenantPK] = [BDTenant].[BDTenantPK] WHERE [BDTenant].[BDTenantPK] = @BDTenantPK;", this.TableName);
			SqlParameter[] paras = new SqlParameter[1];
			paras[0] = new SqlParameter("@BDTenantPK", SqlDbType.UniqueIdentifier);
			paras[0].Value = bDTenantPK;
			return base.ExecuteNonQuery(sql, paras);
		}

		public int DeleteByBDBuilding(System.Guid bDBuildingPK)
		{
			string sql = string.Format("DELETE [{0}] FROM [{0}] [BDTenantHolidayMap] INNER JOIN [BDTenant] ON [BDTenantHolidayMap].[BDTenantPK] = [BDTenant].[BDTenantPK] INNER JOIN [BDBuilding] ON [BDTenant].[BDBuildingPK] = [BDBuilding].[BDBuildingPK] WHERE [BDBuilding].[BDBuildingPK] = @BDBuildingPK;", this.TableName);
			SqlParameter[] paras = new SqlParameter[1];
			paras[0] = new SqlParameter("@BDBuildingPK", SqlDbType.UniqueIdentifier);
			paras[0].Value = bDBuildingPK;
			return base.ExecuteNonQuery(sql, paras);
		}

		public int DeleteByUtilHoliday(System.Guid utilHolidayPK)
		{
			string sql = string.Format("DELETE [{0}] FROM [{0}] [BDTenantHolidayMap] INNER JOIN [UtilHoliday] ON [BDTenantHolidayMap].[UtilHolidayPK] = [UtilHoliday].[UtilHolidayPK] WHERE [UtilHoliday].[UtilHolidayPK] = @UtilHolidayPK;", this.TableName);
			SqlParameter[] paras = new SqlParameter[1];
			paras[0] = new SqlParameter("@UtilHolidayPK", SqlDbType.UniqueIdentifier);
			paras[0].Value = utilHolidayPK;
			return base.ExecuteNonQuery(sql, paras);
		}


	}
	public class LogRowsCountCRUD : DataAccessBase
	{
		private string _tableName = "LogRowsCount";

		public LogRowsCountCRUD(string connectionString) : base(connectionString)
		{
		}

		public virtual string TableName
		{
			get { return this._tableName; }
			set { this._tableName = value; }
		}

		public string SQLColumns
		{
			get
			{
				return "[LogRowsCount].[LogRowsCountPK] AS [LogRowsCountPK],[LogRowsCount].[SessionID] AS [SessionID],[LogRowsCount].[SessionDateTime] AS [SessionDateTime],[LogRowsCount].[DBTableName] AS [DBTableName],[LogRowsCount].[SequenceID] AS [SequenceID],[LogRowsCount].[RowsCount] AS [RowsCount],[LogRowsCount].[RowVersion] AS [RowVersion],[LogRowsCount].[CreatedOn] AS [CreatedOn],[LogRowsCount].[CreatedBy] AS [CreatedBy],[LogRowsCount].[ModifiedOn] AS [ModifiedOn],[LogRowsCount].[ModifiedBy] AS [ModifiedBy]";
			}
		}

		public string SQLLeftJoins
		{
			get
			{
				return "";
			}
		}

		protected override string SQLSelect
		{
			get
			{
				return string.Format("SELECT [LogRowsCount].[LogRowsCountPK] AS [LogRowsCountPK],[LogRowsCount].[SessionID] AS [SessionID],[LogRowsCount].[SessionDateTime] AS [SessionDateTime],[LogRowsCount].[DBTableName] AS [DBTableName],[LogRowsCount].[SequenceID] AS [SequenceID],[LogRowsCount].[RowsCount] AS [RowsCount],[LogRowsCount].[RowVersion] AS [RowVersion],[LogRowsCount].[CreatedOn] AS [CreatedOn],[LogRowsCount].[CreatedBy] AS [CreatedBy],[LogRowsCount].[ModifiedOn] AS [ModifiedOn],[LogRowsCount].[ModifiedBy] AS [ModifiedBy] FROM [{0}] [LogRowsCount] ", this.TableName);
			}
		}

		protected override string SQLCount
		{
			get
			{
				return string.Format("SELECT COUNT(*) FROM [{0}] [LogRowsCount] ", this.TableName);
			}
		}

		public int Insert(LogRowsCountData entity)
		{
			string sql = string.Format("INSERT INTO [{0}] ([LogRowsCountPK],[SessionID],[SessionDateTime],[DBTableName],[SequenceID],[RowsCount],[CreatedOn],[CreatedBy],[ModifiedOn],[ModifiedBy]) VALUES(@LogRowsCountPK,@SessionID,@SessionDateTime,@DBTableName,@SequenceID,@RowsCount,@CreatedOn,@CreatedBy,@ModifiedOn,@ModifiedBy)", this.TableName);
			SqlParameter[] paras = new SqlParameter[10];
			paras[0] = new SqlParameter("@LogRowsCountPK", SqlDbType.UniqueIdentifier);
			if (entity.LogRowsCountPK == Guid.Empty)
			{
				paras[0].Value = DBNull.Value;
			}
			else
			{
				paras[0].Value = entity.LogRowsCountPK;
			}
			paras[1] = new SqlParameter("@SessionID", SqlDbType.UniqueIdentifier);
			if (entity.SessionID == Guid.Empty)
			{
				paras[1].Value = DBNull.Value;
			}
			else
			{
				paras[1].Value = entity.SessionID;
			}
			paras[2] = new SqlParameter("@SessionDateTime", SqlDbType.DateTime);
			paras[2].Value = entity.SessionDateTime;
			paras[3] = new SqlParameter("@DBTableName", SqlDbType.VarChar, 128);
			paras[3].Value = entity.DBTableName;
			paras[4] = new SqlParameter("@SequenceID", SqlDbType.Int);
			paras[4].Value = entity.SequenceID;
			paras[5] = new SqlParameter("@RowsCount", SqlDbType.Int);
			paras[5].Value = entity.RowsCount;
			paras[6] = new SqlParameter("@CreatedOn", SqlDbType.DateTime);
			paras[6].Value = entity.CreatedOn;
			paras[7] = new SqlParameter("@CreatedBy", SqlDbType.VarChar, 30);
			paras[7].Value = entity.CreatedBy;
			paras[8] = new SqlParameter("@ModifiedOn", SqlDbType.DateTime);
			paras[8].Value = entity.ModifiedOn;
			paras[9] = new SqlParameter("@ModifiedBy", SqlDbType.VarChar, 30);
			paras[9].Value = entity.ModifiedBy;
			return base.ExecuteNonQuery(sql, paras);
		}

		public int Update(LogRowsCountData entity)
		{
			string sql = string.Format("UPDATE [{0}] SET [SessionID] = @SessionID,[SessionDateTime] = @SessionDateTime,[DBTableName] = @DBTableName,[SequenceID] = @SequenceID,[RowsCount] = @RowsCount,[CreatedOn] = @CreatedOn,[CreatedBy] = @CreatedBy,[ModifiedOn] = @ModifiedOn,[ModifiedBy] = @ModifiedBy  WHERE [LogRowsCountPK] = @LogRowsCountPK AND [RowVersion] = @RowVersion", this.TableName);
			SqlParameter[] paras = new SqlParameter[11];
			paras[0] = new SqlParameter("@LogRowsCountPK", SqlDbType.UniqueIdentifier);
			if (entity.LogRowsCountPK == Guid.Empty)
			{
				paras[0].Value = DBNull.Value;
			}
			else
			{
				paras[0].Value = entity.LogRowsCountPK;
			}
			paras[1] = new SqlParameter("@SessionID", SqlDbType.UniqueIdentifier);
			if (entity.SessionID == Guid.Empty)
			{
				paras[1].Value = DBNull.Value;
			}
			else
			{
				paras[1].Value = entity.SessionID;
			}
			paras[2] = new SqlParameter("@SessionDateTime", SqlDbType.DateTime);
			paras[2].Value = entity.SessionDateTime;
			paras[3] = new SqlParameter("@DBTableName", SqlDbType.VarChar, 128);
			paras[3].Value = entity.DBTableName;
			paras[4] = new SqlParameter("@SequenceID", SqlDbType.Int);
			paras[4].Value = entity.SequenceID;
			paras[5] = new SqlParameter("@RowsCount", SqlDbType.Int);
			paras[5].Value = entity.RowsCount;
			paras[6] = new SqlParameter("@RowVersion", SqlDbType.Timestamp);
			paras[6].Value = entity.RowVersion;
			paras[7] = new SqlParameter("@CreatedOn", SqlDbType.DateTime);
			paras[7].Value = entity.CreatedOn;
			paras[8] = new SqlParameter("@CreatedBy", SqlDbType.VarChar, 30);
			paras[8].Value = entity.CreatedBy;
			paras[9] = new SqlParameter("@ModifiedOn", SqlDbType.DateTime);
			paras[9].Value = entity.ModifiedOn;
			paras[10] = new SqlParameter("@ModifiedBy", SqlDbType.VarChar, 30);
			paras[10].Value = entity.ModifiedBy;
			return base.ExecuteNonQuery(sql, paras);
		}

		private LogRowsCountData CreateDataByReader(SafeDataReader reader)
		{
			LogRowsCountData data = new LogRowsCountData {
				LogRowsCountPK = (Guid) reader["LogRowsCountPK"],
				SessionID = (Guid) reader["SessionID"],
				SessionDateTime = (DateTime) reader["SessionDateTime"],
				DBTableName = (String) reader["DBTableName"],
				SequenceID = (Int32) reader["SequenceID"],
				RowsCount = (Int32) reader["RowsCount"],
				RowVersion = (Byte[]) reader["RowVersion"],
				CreatedOn = (DateTime) reader["CreatedOn"],
				CreatedBy = (String) reader["CreatedBy"],
				ModifiedOn = (DateTime) reader["ModifiedOn"],
				ModifiedBy = (String) reader["ModifiedBy"]
			};
			data.AcceptChanges();
			return data;
		}

		private LogRowsCountData FetchEntity(string where, SqlParameter[] paras)
		{
			LogRowsCountData data = null;
			using (SafeDataReader reader = base.ExecuteDataReader(where, paras))
			{
				if (reader.Read())
				{
					data = this.CreateDataByReader(reader);
				}
				reader.Close();
			}
			return data;
		}

		private LogRowsCountData FetchEntityEx(string sql, SqlParameter[] paras)
		{
			LogRowsCountData data = null;
			using (SafeDataReader reader = base.ExecuteDataReaderEx(sql, paras))
			{
				if (reader.Read())
				{
					data = this.CreateDataByReader(reader);
				}
				reader.Close();
			}
			return data;
		}

		private LogRowsCountDataCollection FetchCollection(string where, SqlParameter[] paras)
		{
			LogRowsCountDataCollection list = new LogRowsCountDataCollection();
			using (SafeDataReader reader = base.ExecuteDataReader(where, paras))
			{
				while(reader.Read())
				{
					LogRowsCountData data = this.CreateDataByReader(reader);
					list.Add(data);
				}
				reader.Close();
			}
			return list;
		}

		private LogRowsCountDataCollection FetchCollectionEx(string sql, SqlParameter[] paras)
		{
			LogRowsCountDataCollection list = new LogRowsCountDataCollection();
			using (SafeDataReader reader = base.ExecuteDataReaderEx(sql, paras))
			{
				while(reader.Read())
				{
					LogRowsCountData data = this.CreateDataByReader(reader);
					list.Add(data);
				}
				reader.Close();
			}
			return list;
		}

		public LogRowsCountData GetEntityBy(string sqlWhere, SqlParameter[] paras)
		{
			return this.FetchEntity(sqlWhere, paras);
		}

		public LogRowsCountData GetEntityExBy(string sql, SqlParameter[] paras)
		{
			return this.FetchEntityEx(sql, paras);
		}

		public LogRowsCountDataCollection GetCollectionBy(string sqlWhere, SqlParameter[] paras)
		{
			return this.FetchCollection(sqlWhere, paras);
		}

		public LogRowsCountDataCollection GetCollectionExBy(string sql, SqlParameter[] paras)
		{
			return this.FetchCollectionEx(sql, paras);
		}

		public byte[] GetRowVersion( System.Guid LogRowsCountPK)
		{
			string sql = string.Format("SELECT [RowVersion] AS [RowVersion] FROM [{0}] WHERE  [LogRowsCountPK] = @LogRowsCountPK ", this.TableName);
			SqlParameter[] paras = new SqlParameter[1];
			paras[0] = new SqlParameter("@LogRowsCountPK", SqlDbType.UniqueIdentifier, 16);
			paras[0].Value = LogRowsCountPK;
			return (byte[]) base.ExecuteScalar(sql, paras);
		}

		public LogRowsCountData GetByPK( System.Guid LogRowsCountPK)
		{
			string sql = " WHERE  [LogRowsCount].[LogRowsCountPK] = @LogRowsCountPK ";
			SqlParameter[] paras = new SqlParameter[1];
			paras[0] = new SqlParameter("@LogRowsCountPK", SqlDbType.UniqueIdentifier);
			paras[0].Value = LogRowsCountPK;
			return this.FetchEntity(sql, paras);
		}

		public LogRowsCountDataCollection GetAll()
		{
			return this.FetchCollection("", null);
		}

		public DataTable GetLogByPK( System.Guid LogRowsCountPK)
		{
			string sql = string.Format("SELECT  [LogRowsCount].[LogRowsCountPK] AS [LogRowsCountPK], [LogRowsCount].[ModifiedOn] AS [ModifiedOn] FROM [{0}] WHERE  [LogRowsCount].[LogRowsCountPK] = @LogRowsCountPK ", this.TableName);
			SqlParameter[] paras = new SqlParameter[1];
			paras[0] = new SqlParameter("@LogRowsCountPK", SqlDbType.UniqueIdentifier);
			paras[0].Value = LogRowsCountPK;
			return this.ExecuteDataTable(sql, paras);
		}

		public int DeleteByPK( System.Guid LogRowsCountPK, byte[] RowVersion)
		{
			string sql = string.Format("DELETE FROM [{0}] WHERE  [LogRowsCountPK] = @LogRowsCountPK AND [RowVersion] = @RowVersion", this.TableName);
			SqlParameter[] paras = new SqlParameter[2];
			paras[0] = new SqlParameter("@LogRowsCountPK", SqlDbType.UniqueIdentifier);
			paras[0].Value = LogRowsCountPK;
			paras[1] = new SqlParameter("@RowVersion", SqlDbType.Timestamp, 8);
			paras[1].Value = RowVersion;
			return base.ExecuteNonQuery(sql, paras);
		}

		public int DeleteAll()
		{
			string sql = string.Format("DELETE FROM [{0}]", this.TableName);
			return base.ExecuteNonQuery(sql, null);
		}


	}
	public class ACInputGroupCRUD : DataAccessBase
	{
		private string _tableName = "ACInputGroup";

		public ACInputGroupCRUD(string connectionString) : base(connectionString)
		{
		}

		public virtual string TableName
		{
			get { return this._tableName; }
			set { this._tableName = value; }
		}

		public string SQLColumns
		{
			get
			{
				return "[ACInputGroup].[ACInputGroupPK] AS [ACInputGroupPK],[ACInputGroup].[ACPanelPK] AS [ACPanelPK],[ACInputGroup].[GroupID] AS [GroupID],[ACInputGroup].[Summary] AS [Summary],[ACInputGroup].[RowVersion] AS [RowVersion],[ACInputGroup].[CreatedOn] AS [CreatedOn],[ACInputGroup].[CreatedBy] AS [CreatedBy],[ACInputGroup].[ModifiedOn] AS [ModifiedOn],[ACInputGroup].[ModifiedBy] AS [ModifiedBy],[ACPanel].[BDBuildingPK] AS [BDBuildingPK],[ACPanel].[UnitID] AS [UnitID],[BDBuilding].[Address1] AS [Address1],[BDBuilding].[BuildingID] AS [BuildingID]";
			}
		}

		public string SQLLeftJoins
		{
			get
			{
				return "LEFT JOIN [ACPanel] [ACPanel] ON [ACInputGroup].[ACPanelPK] = [ACPanel].[ACPanelPK] LEFT JOIN [BDBuilding] [BDBuilding] ON [ACPanel].[BDBuildingPK] = [BDBuilding].[BDBuildingPK]";
			}
		}

		protected override string SQLSelect
		{
			get
			{
				return string.Format("SELECT [ACInputGroup].[ACInputGroupPK] AS [ACInputGroupPK],[ACInputGroup].[ACPanelPK] AS [ACPanelPK],[ACInputGroup].[GroupID] AS [GroupID],[ACInputGroup].[Summary] AS [Summary],[ACInputGroup].[RowVersion] AS [RowVersion],[ACInputGroup].[CreatedOn] AS [CreatedOn],[ACInputGroup].[CreatedBy] AS [CreatedBy],[ACInputGroup].[ModifiedOn] AS [ModifiedOn],[ACInputGroup].[ModifiedBy] AS [ModifiedBy],[ACPanel].[BDBuildingPK] AS [BDBuildingPK],[ACPanel].[UnitID] AS [UnitID],[BDBuilding].[Address1] AS [Address1],[BDBuilding].[BuildingID] AS [BuildingID] FROM [{0}] [ACInputGroup] LEFT JOIN [ACPanel] [ACPanel] ON [ACInputGroup].[ACPanelPK] = [ACPanel].[ACPanelPK] LEFT JOIN [BDBuilding] [BDBuilding] ON [ACPanel].[BDBuildingPK] = [BDBuilding].[BDBuildingPK]", this.TableName);
			}
		}

		protected override string SQLCount
		{
			get
			{
				return string.Format("SELECT COUNT(*) FROM [{0}] [ACInputGroup] LEFT JOIN [ACPanel] [ACPanel] ON [ACInputGroup].[ACPanelPK] = [ACPanel].[ACPanelPK] LEFT JOIN [BDBuilding] [BDBuilding] ON [ACPanel].[BDBuildingPK] = [BDBuilding].[BDBuildingPK]", this.TableName);
			}
		}

		public int Insert(ACInputGroupData entity)
		{
			string sql = string.Format("INSERT INTO [{0}] ([ACInputGroupPK],[ACPanelPK],[GroupID],[Summary],[CreatedOn],[CreatedBy],[ModifiedOn],[ModifiedBy]) VALUES(@ACInputGroupPK,@ACPanelPK,@GroupID,@Summary,@CreatedOn,@CreatedBy,@ModifiedOn,@ModifiedBy)", this.TableName);
			SqlParameter[] paras = new SqlParameter[8];
			paras[0] = new SqlParameter("@ACInputGroupPK", SqlDbType.UniqueIdentifier);
			if (entity.ACInputGroupPK == Guid.Empty)
			{
				paras[0].Value = DBNull.Value;
			}
			else
			{
				paras[0].Value = entity.ACInputGroupPK;
			}
			paras[1] = new SqlParameter("@ACPanelPK", SqlDbType.UniqueIdentifier);
			if (entity.ACPanelPK == Guid.Empty)
			{
				paras[1].Value = DBNull.Value;
			}
			else
			{
				paras[1].Value = entity.ACPanelPK;
			}
			paras[2] = new SqlParameter("@GroupID", SqlDbType.TinyInt);
			paras[2].Value = entity.GroupID;
			paras[3] = new SqlParameter("@Summary", SqlDbType.VarChar, 256);
			paras[3].Value = entity.Summary;
			paras[4] = new SqlParameter("@CreatedOn", SqlDbType.DateTime);
			paras[4].Value = entity.CreatedOn;
			paras[5] = new SqlParameter("@CreatedBy", SqlDbType.VarChar, 30);
			paras[5].Value = entity.CreatedBy;
			paras[6] = new SqlParameter("@ModifiedOn", SqlDbType.DateTime);
			paras[6].Value = entity.ModifiedOn;
			paras[7] = new SqlParameter("@ModifiedBy", SqlDbType.VarChar, 30);
			paras[7].Value = entity.ModifiedBy;
			return base.ExecuteNonQuery(sql, paras);
		}

		public int Update(ACInputGroupData entity)
		{
			string sql = string.Format("UPDATE [{0}] SET [ACPanelPK] = @ACPanelPK,[GroupID] = @GroupID,[Summary] = @Summary,[CreatedOn] = @CreatedOn,[CreatedBy] = @CreatedBy,[ModifiedOn] = @ModifiedOn,[ModifiedBy] = @ModifiedBy  WHERE [ACInputGroupPK] = @ACInputGroupPK AND [RowVersion] = @RowVersion", this.TableName);
			SqlParameter[] paras = new SqlParameter[9];
			paras[0] = new SqlParameter("@ACInputGroupPK", SqlDbType.UniqueIdentifier);
			if (entity.ACInputGroupPK == Guid.Empty)
			{
				paras[0].Value = DBNull.Value;
			}
			else
			{
				paras[0].Value = entity.ACInputGroupPK;
			}
			paras[1] = new SqlParameter("@ACPanelPK", SqlDbType.UniqueIdentifier);
			if (entity.ACPanelPK == Guid.Empty)
			{
				paras[1].Value = DBNull.Value;
			}
			else
			{
				paras[1].Value = entity.ACPanelPK;
			}
			paras[2] = new SqlParameter("@GroupID", SqlDbType.TinyInt);
			paras[2].Value = entity.GroupID;
			paras[3] = new SqlParameter("@Summary", SqlDbType.VarChar, 256);
			paras[3].Value = entity.Summary;
			paras[4] = new SqlParameter("@RowVersion", SqlDbType.Timestamp);
			paras[4].Value = entity.RowVersion;
			paras[5] = new SqlParameter("@CreatedOn", SqlDbType.DateTime);
			paras[5].Value = entity.CreatedOn;
			paras[6] = new SqlParameter("@CreatedBy", SqlDbType.VarChar, 30);
			paras[6].Value = entity.CreatedBy;
			paras[7] = new SqlParameter("@ModifiedOn", SqlDbType.DateTime);
			paras[7].Value = entity.ModifiedOn;
			paras[8] = new SqlParameter("@ModifiedBy", SqlDbType.VarChar, 30);
			paras[8].Value = entity.ModifiedBy;
			return base.ExecuteNonQuery(sql, paras);
		}

		private ACInputGroupData CreateDataByReader(SafeDataReader reader)
		{
			ACInputGroupData data = new ACInputGroupData {
				ACInputGroupPK = (Guid) reader["ACInputGroupPK"],
				ACPanelPK = (Guid) reader["ACPanelPK"],
				GroupID = (Byte) reader["GroupID"],
				Summary = (String) reader["Summary"],
				RowVersion = (Byte[]) reader["RowVersion"],
				CreatedOn = (DateTime) reader["CreatedOn"],
				CreatedBy = (String) reader["CreatedBy"],
				ModifiedOn = (DateTime) reader["ModifiedOn"],
				ModifiedBy = (String) reader["ModifiedBy"],
				BDBuildingPK = (Guid) reader["BDBuildingPK"],
				UnitID = (Int32) reader["UnitID"],
				Address1 = (String) reader["Address1"],
				BuildingID = (Int32) reader["BuildingID"]
			};
			data.AcceptChanges();
			return data;
		}

		private ACInputGroupData FetchEntity(string where, SqlParameter[] paras)
		{
			ACInputGroupData data = null;
			using (SafeDataReader reader = base.ExecuteDataReader(where, paras))
			{
				if (reader.Read())
				{
					data = this.CreateDataByReader(reader);
				}
				reader.Close();
			}
			return data;
		}

		private ACInputGroupData FetchEntityEx(string sql, SqlParameter[] paras)
		{
			ACInputGroupData data = null;
			using (SafeDataReader reader = base.ExecuteDataReaderEx(sql, paras))
			{
				if (reader.Read())
				{
					data = this.CreateDataByReader(reader);
				}
				reader.Close();
			}
			return data;
		}

		private ACInputGroupDataCollection FetchCollection(string where, SqlParameter[] paras)
		{
			ACInputGroupDataCollection list = new ACInputGroupDataCollection();
			using (SafeDataReader reader = base.ExecuteDataReader(where, paras))
			{
				while(reader.Read())
				{
					ACInputGroupData data = this.CreateDataByReader(reader);
					list.Add(data);
				}
				reader.Close();
			}
			return list;
		}

		private ACInputGroupDataCollection FetchCollectionEx(string sql, SqlParameter[] paras)
		{
			ACInputGroupDataCollection list = new ACInputGroupDataCollection();
			using (SafeDataReader reader = base.ExecuteDataReaderEx(sql, paras))
			{
				while(reader.Read())
				{
					ACInputGroupData data = this.CreateDataByReader(reader);
					list.Add(data);
				}
				reader.Close();
			}
			return list;
		}

		public ACInputGroupData GetEntityBy(string sqlWhere, SqlParameter[] paras)
		{
			return this.FetchEntity(sqlWhere, paras);
		}

		public ACInputGroupData GetEntityExBy(string sql, SqlParameter[] paras)
		{
			return this.FetchEntityEx(sql, paras);
		}

		public ACInputGroupDataCollection GetCollectionBy(string sqlWhere, SqlParameter[] paras)
		{
			return this.FetchCollection(sqlWhere, paras);
		}

		public ACInputGroupDataCollection GetCollectionExBy(string sql, SqlParameter[] paras)
		{
			return this.FetchCollectionEx(sql, paras);
		}

		public byte[] GetRowVersion( System.Guid ACInputGroupPK)
		{
			string sql = string.Format("SELECT [RowVersion] AS [RowVersion] FROM [{0}] WHERE  [ACInputGroupPK] = @ACInputGroupPK ", this.TableName);
			SqlParameter[] paras = new SqlParameter[1];
			paras[0] = new SqlParameter("@ACInputGroupPK", SqlDbType.UniqueIdentifier, 16);
			paras[0].Value = ACInputGroupPK;
			return (byte[]) base.ExecuteScalar(sql, paras);
		}

		public ACInputGroupData GetByPK( System.Guid ACInputGroupPK)
		{
			string sql = " WHERE  [ACInputGroup].[ACInputGroupPK] = @ACInputGroupPK ";
			SqlParameter[] paras = new SqlParameter[1];
			paras[0] = new SqlParameter("@ACInputGroupPK", SqlDbType.UniqueIdentifier);
			paras[0].Value = ACInputGroupPK;
			return this.FetchEntity(sql, paras);
		}

		public ACInputGroupDataCollection GetAll()
		{
			return this.FetchCollection("", null);
		}

		public ACInputGroupDataCollection GetByACPanel(System.Guid ACPanelPK)
		{
			string sqlWhere = " WHERE [ACInputGroup].[ACPanelPK] = @ACPanelPK";
			SqlParameter[] paras = new SqlParameter[1];
			paras[0] = new SqlParameter("@ACPanelPK", SqlDbType.UniqueIdentifier);
			paras[0].Value = ACPanelPK;
			return this.FetchCollection(sqlWhere, paras);
		}

		public DataTable GetLogByPK( System.Guid ACInputGroupPK)
		{
			string sql = string.Format("SELECT  [ACInputGroup].[ACInputGroupPK] AS [ACInputGroupPK], [ACInputGroup].[ModifiedOn] AS [ModifiedOn] FROM [{0}] WHERE  [ACInputGroup].[ACInputGroupPK] = @ACInputGroupPK ", this.TableName);
			SqlParameter[] paras = new SqlParameter[1];
			paras[0] = new SqlParameter("@ACInputGroupPK", SqlDbType.UniqueIdentifier);
			paras[0].Value = ACInputGroupPK;
			return this.ExecuteDataTable(sql, paras);
		}

		public DataTable GetLogByACPanel(System.Guid aCPanelPK)
		{
			string sql = string.Format("DELETE [{0}] FROM [{0}] [ACInputGroup] INNER JOIN [ACPanel] ON [ACInputGroup].[ACPanelPK] = [ACPanel].[ACPanelPK] WHERE [ACPanel].[ACPanelPK] = @ACPanelPK;", this.TableName);
			string oldValue = string.Format("DELETE [{0}]", this.TableName);
			string newValue = "SELECT  [ACInputGroup].[ACInputGroupPK] AS [ACInputGroupPK], [ACInputGroup].[ModifiedOn] AS [ModifiedOn]";
			sql = sql.Replace(oldValue, newValue).TrimEnd().TrimEnd(';').Replace(";", " UNION ");
			SqlParameter[] paras = new SqlParameter[1];
			paras[0] = new SqlParameter("@ACPanelPK", SqlDbType.UniqueIdentifier);
			paras[0].Value = aCPanelPK;
			return base.ExecuteDataTable(sql, paras);
		}

		public DataTable GetLogByBDBuilding(System.Guid bDBuildingPK)
		{
			string sql = string.Format("DELETE [{0}] FROM [{0}] [ACInputGroup] INNER JOIN [ACPanel] ON [ACInputGroup].[ACPanelPK] = [ACPanel].[ACPanelPK] INNER JOIN [BDBuilding] ON [ACPanel].[BDBuildingPK] = [BDBuilding].[BDBuildingPK] WHERE [BDBuilding].[BDBuildingPK] = @BDBuildingPK;", this.TableName);
			string oldValue = string.Format("DELETE [{0}]", this.TableName);
			string newValue = "SELECT  [ACInputGroup].[ACInputGroupPK] AS [ACInputGroupPK], [ACInputGroup].[ModifiedOn] AS [ModifiedOn]";
			sql = sql.Replace(oldValue, newValue).TrimEnd().TrimEnd(';').Replace(";", " UNION ");
			SqlParameter[] paras = new SqlParameter[1];
			paras[0] = new SqlParameter("@BDBuildingPK", SqlDbType.UniqueIdentifier);
			paras[0].Value = bDBuildingPK;
			return base.ExecuteDataTable(sql, paras);
		}

		public int DeleteByPK( System.Guid ACInputGroupPK, byte[] RowVersion)
		{
			string sql = string.Format("DELETE FROM [{0}] WHERE  [ACInputGroupPK] = @ACInputGroupPK AND [RowVersion] = @RowVersion", this.TableName);
			SqlParameter[] paras = new SqlParameter[2];
			paras[0] = new SqlParameter("@ACInputGroupPK", SqlDbType.UniqueIdentifier);
			paras[0].Value = ACInputGroupPK;
			paras[1] = new SqlParameter("@RowVersion", SqlDbType.Timestamp, 8);
			paras[1].Value = RowVersion;
			return base.ExecuteNonQuery(sql, paras);
		}

		public int DeleteAll()
		{
			string sql = string.Format("DELETE FROM [{0}]", this.TableName);
			return base.ExecuteNonQuery(sql, null);
		}

		public int DeleteByACPanel(System.Guid aCPanelPK)
		{
			string sql = string.Format("DELETE [{0}] FROM [{0}] [ACInputGroup] INNER JOIN [ACPanel] ON [ACInputGroup].[ACPanelPK] = [ACPanel].[ACPanelPK] WHERE [ACPanel].[ACPanelPK] = @ACPanelPK;", this.TableName);
			SqlParameter[] paras = new SqlParameter[1];
			paras[0] = new SqlParameter("@ACPanelPK", SqlDbType.UniqueIdentifier);
			paras[0].Value = aCPanelPK;
			return base.ExecuteNonQuery(sql, paras);
		}

		public int DeleteByBDBuilding(System.Guid bDBuildingPK)
		{
			string sql = string.Format("DELETE [{0}] FROM [{0}] [ACInputGroup] INNER JOIN [ACPanel] ON [ACInputGroup].[ACPanelPK] = [ACPanel].[ACPanelPK] INNER JOIN [BDBuilding] ON [ACPanel].[BDBuildingPK] = [BDBuilding].[BDBuildingPK] WHERE [BDBuilding].[BDBuildingPK] = @BDBuildingPK;", this.TableName);
			SqlParameter[] paras = new SqlParameter[1];
			paras[0] = new SqlParameter("@BDBuildingPK", SqlDbType.UniqueIdentifier);
			paras[0].Value = bDBuildingPK;
			return base.ExecuteNonQuery(sql, paras);
		}


	}
	public class ACInputCRUD : DataAccessBase
	{
		private string _tableName = "ACInput";

		public ACInputCRUD(string connectionString) : base(connectionString)
		{
		}

		public virtual string TableName
		{
			get { return this._tableName; }
			set { this._tableName = value; }
		}

		public string SQLColumns
		{
			get
			{
				return "[ACInput].[ACInputPK] AS [ACInputPK],[ACInput].[ACPanelPK] AS [ACPanelPK],[ACInput].[InputID] AS [InputID],[ACInput].[Description] AS [Description],[ACInput].[Debounce] AS [Debounce],[ACInput].[Reverse] AS [Reverse],[ACInput].[ForceAMFormat] AS [ForceAMFormat],[ACInput].[OffOnRestore] AS [OffOnRestore],[ACInput].[External] AS [External],[ACInput].[Notes] AS [Notes],[ACInput].[RowVersion] AS [RowVersion],[ACInput].[CreatedOn] AS [CreatedOn],[ACInput].[CreatedBy] AS [CreatedBy],[ACInput].[ModifiedOn] AS [ModifiedOn],[ACInput].[ModifiedBy] AS [ModifiedBy],[ACInput].[AlwaysToMAS] AS [AlwaysToMAS],[ACInput].[PanelZoneID] AS [PanelZoneID],[ACInput].[Locked] AS [Locked],[ACPanel].[BDBuildingPK] AS [BDBuildingPK],[ACPanel].[UnitID] AS [UnitID],[BDBuilding].[Address1] AS [Address1],[BDBuilding].[BuildingID] AS [BuildingID]";
			}
		}

		public string SQLLeftJoins
		{
			get
			{
				return "LEFT JOIN [ACPanel] [ACPanel] ON [ACInput].[ACPanelPK] = [ACPanel].[ACPanelPK] LEFT JOIN [BDBuilding] [BDBuilding] ON [ACPanel].[BDBuildingPK] = [BDBuilding].[BDBuildingPK]";
			}
		}

		protected override string SQLSelect
		{
			get
			{
				return string.Format("SELECT [ACInput].[ACInputPK] AS [ACInputPK],[ACInput].[ACPanelPK] AS [ACPanelPK],[ACInput].[InputID] AS [InputID],[ACInput].[Description] AS [Description],[ACInput].[Debounce] AS [Debounce],[ACInput].[Reverse] AS [Reverse],[ACInput].[ForceAMFormat] AS [ForceAMFormat],[ACInput].[OffOnRestore] AS [OffOnRestore],[ACInput].[External] AS [External],[ACInput].[Notes] AS [Notes],[ACInput].[RowVersion] AS [RowVersion],[ACInput].[CreatedOn] AS [CreatedOn],[ACInput].[CreatedBy] AS [CreatedBy],[ACInput].[ModifiedOn] AS [ModifiedOn],[ACInput].[ModifiedBy] AS [ModifiedBy],[ACInput].[AlwaysToMAS] AS [AlwaysToMAS],[ACInput].[PanelZoneID] AS [PanelZoneID],[ACInput].[Locked] AS [Locked],[ACPanel].[BDBuildingPK] AS [BDBuildingPK],[ACPanel].[UnitID] AS [UnitID],[BDBuilding].[Address1] AS [Address1],[BDBuilding].[BuildingID] AS [BuildingID] FROM [{0}] [ACInput] LEFT JOIN [ACPanel] [ACPanel] ON [ACInput].[ACPanelPK] = [ACPanel].[ACPanelPK] LEFT JOIN [BDBuilding] [BDBuilding] ON [ACPanel].[BDBuildingPK] = [BDBuilding].[BDBuildingPK]", this.TableName);
			}
		}

		protected override string SQLCount
		{
			get
			{
				return string.Format("SELECT COUNT(*) FROM [{0}] [ACInput] LEFT JOIN [ACPanel] [ACPanel] ON [ACInput].[ACPanelPK] = [ACPanel].[ACPanelPK] LEFT JOIN [BDBuilding] [BDBuilding] ON [ACPanel].[BDBuildingPK] = [BDBuilding].[BDBuildingPK]", this.TableName);
			}
		}

		public int Insert(ACInputData entity)
		{
			string sql = string.Format("INSERT INTO [{0}] ([ACInputPK],[ACPanelPK],[InputID],[Description],[Debounce],[Reverse],[ForceAMFormat],[OffOnRestore],[External],[Notes],[CreatedOn],[CreatedBy],[ModifiedOn],[ModifiedBy],[AlwaysToMAS],[PanelZoneID],[Locked]) VALUES(@ACInputPK,@ACPanelPK,@InputID,@Description,@Debounce,@Reverse,@ForceAMFormat,@OffOnRestore,@External,@Notes,@CreatedOn,@CreatedBy,@ModifiedOn,@ModifiedBy,@AlwaysToMAS,@PanelZoneID,@Locked)", this.TableName);
			SqlParameter[] paras = new SqlParameter[17];
			paras[0] = new SqlParameter("@ACInputPK", SqlDbType.UniqueIdentifier);
			if (entity.ACInputPK == Guid.Empty)
			{
				paras[0].Value = DBNull.Value;
			}
			else
			{
				paras[0].Value = entity.ACInputPK;
			}
			paras[1] = new SqlParameter("@ACPanelPK", SqlDbType.UniqueIdentifier);
			if (entity.ACPanelPK == Guid.Empty)
			{
				paras[1].Value = DBNull.Value;
			}
			else
			{
				paras[1].Value = entity.ACPanelPK;
			}
			paras[2] = new SqlParameter("@InputID", SqlDbType.TinyInt);
			paras[2].Value = entity.InputID;
			paras[3] = new SqlParameter("@Description", SqlDbType.VarChar, 30);
			paras[3].Value = entity.Description;
			paras[4] = new SqlParameter("@Debounce", SqlDbType.SmallInt);
			paras[4].Value = entity.Debounce;
			paras[5] = new SqlParameter("@Reverse", SqlDbType.Bit);
			paras[5].Value = entity.Reverse;
			paras[6] = new SqlParameter("@ForceAMFormat", SqlDbType.SmallInt);
			paras[6].Value = entity.ForceAMFormat;
			paras[7] = new SqlParameter("@OffOnRestore", SqlDbType.Bit);
			paras[7].Value = entity.OffOnRestore;
			paras[8] = new SqlParameter("@External", SqlDbType.Bit);
			paras[8].Value = entity.External;
			paras[9] = new SqlParameter("@Notes", SqlDbType.VarChar, 512);
			paras[9].Value = entity.Notes;
			paras[10] = new SqlParameter("@CreatedOn", SqlDbType.DateTime);
			paras[10].Value = entity.CreatedOn;
			paras[11] = new SqlParameter("@CreatedBy", SqlDbType.VarChar, 30);
			paras[11].Value = entity.CreatedBy;
			paras[12] = new SqlParameter("@ModifiedOn", SqlDbType.DateTime);
			paras[12].Value = entity.ModifiedOn;
			paras[13] = new SqlParameter("@ModifiedBy", SqlDbType.VarChar, 30);
			paras[13].Value = entity.ModifiedBy;
			paras[14] = new SqlParameter("@AlwaysToMAS", SqlDbType.Bit);
			paras[14].Value = entity.AlwaysToMAS;
			paras[15] = new SqlParameter("@PanelZoneID", SqlDbType.TinyInt);
			paras[15].Value = entity.PanelZoneID;
			paras[16] = new SqlParameter("@Locked", SqlDbType.Bit);
			paras[16].Value = entity.Locked;
			return base.ExecuteNonQuery(sql, paras);
		}

		public int Update(ACInputData entity)
		{
			string sql = string.Format("UPDATE [{0}] SET [ACPanelPK] = @ACPanelPK,[InputID] = @InputID,[Description] = @Description,[Debounce] = @Debounce,[Reverse] = @Reverse,[ForceAMFormat] = @ForceAMFormat,[OffOnRestore] = @OffOnRestore,[External] = @External,[Notes] = @Notes,[CreatedOn] = @CreatedOn,[CreatedBy] = @CreatedBy,[ModifiedOn] = @ModifiedOn,[ModifiedBy] = @ModifiedBy,[AlwaysToMAS] = @AlwaysToMAS,[PanelZoneID] = @PanelZoneID,[Locked] = @Locked  WHERE [ACInputPK] = @ACInputPK AND [RowVersion] = @RowVersion", this.TableName);
			SqlParameter[] paras = new SqlParameter[18];
			paras[0] = new SqlParameter("@ACInputPK", SqlDbType.UniqueIdentifier);
			if (entity.ACInputPK == Guid.Empty)
			{
				paras[0].Value = DBNull.Value;
			}
			else
			{
				paras[0].Value = entity.ACInputPK;
			}
			paras[1] = new SqlParameter("@ACPanelPK", SqlDbType.UniqueIdentifier);
			if (entity.ACPanelPK == Guid.Empty)
			{
				paras[1].Value = DBNull.Value;
			}
			else
			{
				paras[1].Value = entity.ACPanelPK;
			}
			paras[2] = new SqlParameter("@InputID", SqlDbType.TinyInt);
			paras[2].Value = entity.InputID;
			paras[3] = new SqlParameter("@Description", SqlDbType.VarChar, 30);
			paras[3].Value = entity.Description;
			paras[4] = new SqlParameter("@Debounce", SqlDbType.SmallInt);
			paras[4].Value = entity.Debounce;
			paras[5] = new SqlParameter("@Reverse", SqlDbType.Bit);
			paras[5].Value = entity.Reverse;
			paras[6] = new SqlParameter("@ForceAMFormat", SqlDbType.SmallInt);
			paras[6].Value = entity.ForceAMFormat;
			paras[7] = new SqlParameter("@OffOnRestore", SqlDbType.Bit);
			paras[7].Value = entity.OffOnRestore;
			paras[8] = new SqlParameter("@External", SqlDbType.Bit);
			paras[8].Value = entity.External;
			paras[9] = new SqlParameter("@Notes", SqlDbType.VarChar, 512);
			paras[9].Value = entity.Notes;
			paras[10] = new SqlParameter("@RowVersion", SqlDbType.Timestamp);
			paras[10].Value = entity.RowVersion;
			paras[11] = new SqlParameter("@CreatedOn", SqlDbType.DateTime);
			paras[11].Value = entity.CreatedOn;
			paras[12] = new SqlParameter("@CreatedBy", SqlDbType.VarChar, 30);
			paras[12].Value = entity.CreatedBy;
			paras[13] = new SqlParameter("@ModifiedOn", SqlDbType.DateTime);
			paras[13].Value = entity.ModifiedOn;
			paras[14] = new SqlParameter("@ModifiedBy", SqlDbType.VarChar, 30);
			paras[14].Value = entity.ModifiedBy;
			paras[15] = new SqlParameter("@AlwaysToMAS", SqlDbType.Bit);
			paras[15].Value = entity.AlwaysToMAS;
			paras[16] = new SqlParameter("@PanelZoneID", SqlDbType.TinyInt);
			paras[16].Value = entity.PanelZoneID;
			paras[17] = new SqlParameter("@Locked", SqlDbType.Bit);
			paras[17].Value = entity.Locked;
			return base.ExecuteNonQuery(sql, paras);
		}

		private ACInputData CreateDataByReader(SafeDataReader reader)
		{
			ACInputData data = new ACInputData {
				ACInputPK = (Guid) reader["ACInputPK"],
				ACPanelPK = (Guid) reader["ACPanelPK"],
				InputID = (Byte) reader["InputID"],
				Description = (String) reader["Description"],
				Debounce = (Int16) reader["Debounce"],
				Reverse = (Boolean) reader["Reverse"],
				ForceAMFormat = (Int16) reader["ForceAMFormat"],
				OffOnRestore = (Boolean) reader["OffOnRestore"],
				External = (Boolean) reader["External"],
				Notes = (String) reader["Notes"],
				RowVersion = (Byte[]) reader["RowVersion"],
				CreatedOn = (DateTime) reader["CreatedOn"],
				CreatedBy = (String) reader["CreatedBy"],
				ModifiedOn = (DateTime) reader["ModifiedOn"],
				ModifiedBy = (String) reader["ModifiedBy"],
				AlwaysToMAS = (Boolean) reader["AlwaysToMAS"],
				PanelZoneID = (Byte) reader["PanelZoneID"],
				Locked = (Boolean) reader["Locked"],
				BDBuildingPK = (Guid) reader["BDBuildingPK"],
				UnitID = (Int32) reader["UnitID"],
				Address1 = (String) reader["Address1"],
				BuildingID = (Int32) reader["BuildingID"]
			};
			data.AcceptChanges();
			return data;
		}

		private ACInputData FetchEntity(string where, SqlParameter[] paras)
		{
			ACInputData data = null;
			using (SafeDataReader reader = base.ExecuteDataReader(where, paras))
			{
				if (reader.Read())
				{
					data = this.CreateDataByReader(reader);
				}
				reader.Close();
			}
			return data;
		}

		private ACInputData FetchEntityEx(string sql, SqlParameter[] paras)
		{
			ACInputData data = null;
			using (SafeDataReader reader = base.ExecuteDataReaderEx(sql, paras))
			{
				if (reader.Read())
				{
					data = this.CreateDataByReader(reader);
				}
				reader.Close();
			}
			return data;
		}

		private ACInputDataCollection FetchCollection(string where, SqlParameter[] paras)
		{
			ACInputDataCollection list = new ACInputDataCollection();
			using (SafeDataReader reader = base.ExecuteDataReader(where, paras))
			{
				while(reader.Read())
				{
					ACInputData data = this.CreateDataByReader(reader);
					list.Add(data);
				}
				reader.Close();
			}
			return list;
		}

		private ACInputDataCollection FetchCollectionEx(string sql, SqlParameter[] paras)
		{
			ACInputDataCollection list = new ACInputDataCollection();
			using (SafeDataReader reader = base.ExecuteDataReaderEx(sql, paras))
			{
				while(reader.Read())
				{
					ACInputData data = this.CreateDataByReader(reader);
					list.Add(data);
				}
				reader.Close();
			}
			return list;
		}

		public ACInputData GetEntityBy(string sqlWhere, SqlParameter[] paras)
		{
			return this.FetchEntity(sqlWhere, paras);
		}

		public ACInputData GetEntityExBy(string sql, SqlParameter[] paras)
		{
			return this.FetchEntityEx(sql, paras);
		}

		public ACInputDataCollection GetCollectionBy(string sqlWhere, SqlParameter[] paras)
		{
			return this.FetchCollection(sqlWhere, paras);
		}

		public ACInputDataCollection GetCollectionExBy(string sql, SqlParameter[] paras)
		{
			return this.FetchCollectionEx(sql, paras);
		}

		public byte[] GetRowVersion( System.Guid ACInputPK)
		{
			string sql = string.Format("SELECT [RowVersion] AS [RowVersion] FROM [{0}] WHERE  [ACInputPK] = @ACInputPK ", this.TableName);
			SqlParameter[] paras = new SqlParameter[1];
			paras[0] = new SqlParameter("@ACInputPK", SqlDbType.UniqueIdentifier, 16);
			paras[0].Value = ACInputPK;
			return (byte[]) base.ExecuteScalar(sql, paras);
		}

		public ACInputData GetByPK( System.Guid ACInputPK)
		{
			string sql = " WHERE  [ACInput].[ACInputPK] = @ACInputPK ";
			SqlParameter[] paras = new SqlParameter[1];
			paras[0] = new SqlParameter("@ACInputPK", SqlDbType.UniqueIdentifier);
			paras[0].Value = ACInputPK;
			return this.FetchEntity(sql, paras);
		}

		public ACInputDataCollection GetAll()
		{
			return this.FetchCollection("", null);
		}

		public ACInputDataCollection GetByACPanel(System.Guid ACPanelPK)
		{
			string sqlWhere = " WHERE [ACInput].[ACPanelPK] = @ACPanelPK";
			SqlParameter[] paras = new SqlParameter[1];
			paras[0] = new SqlParameter("@ACPanelPK", SqlDbType.UniqueIdentifier);
			paras[0].Value = ACPanelPK;
			return this.FetchCollection(sqlWhere, paras);
		}

		public DataTable GetLogByPK( System.Guid ACInputPK)
		{
			string sql = string.Format("SELECT  [ACInput].[ACInputPK] AS [ACInputPK], [ACInput].[ModifiedOn] AS [ModifiedOn] FROM [{0}] WHERE  [ACInput].[ACInputPK] = @ACInputPK ", this.TableName);
			SqlParameter[] paras = new SqlParameter[1];
			paras[0] = new SqlParameter("@ACInputPK", SqlDbType.UniqueIdentifier);
			paras[0].Value = ACInputPK;
			return this.ExecuteDataTable(sql, paras);
		}

		public DataTable GetLogByACPanel(System.Guid aCPanelPK)
		{
			string sql = string.Format("DELETE [{0}] FROM [{0}] [ACInput] INNER JOIN [ACPanel] ON [ACInput].[ACPanelPK] = [ACPanel].[ACPanelPK] WHERE [ACPanel].[ACPanelPK] = @ACPanelPK;", this.TableName);
			string oldValue = string.Format("DELETE [{0}]", this.TableName);
			string newValue = "SELECT  [ACInput].[ACInputPK] AS [ACInputPK], [ACInput].[ModifiedOn] AS [ModifiedOn]";
			sql = sql.Replace(oldValue, newValue).TrimEnd().TrimEnd(';').Replace(";", " UNION ");
			SqlParameter[] paras = new SqlParameter[1];
			paras[0] = new SqlParameter("@ACPanelPK", SqlDbType.UniqueIdentifier);
			paras[0].Value = aCPanelPK;
			return base.ExecuteDataTable(sql, paras);
		}

		public DataTable GetLogByBDBuilding(System.Guid bDBuildingPK)
		{
			string sql = string.Format("DELETE [{0}] FROM [{0}] [ACInput] INNER JOIN [ACPanel] ON [ACInput].[ACPanelPK] = [ACPanel].[ACPanelPK] INNER JOIN [BDBuilding] ON [ACPanel].[BDBuildingPK] = [BDBuilding].[BDBuildingPK] WHERE [BDBuilding].[BDBuildingPK] = @BDBuildingPK;", this.TableName);
			string oldValue = string.Format("DELETE [{0}]", this.TableName);
			string newValue = "SELECT  [ACInput].[ACInputPK] AS [ACInputPK], [ACInput].[ModifiedOn] AS [ModifiedOn]";
			sql = sql.Replace(oldValue, newValue).TrimEnd().TrimEnd(';').Replace(";", " UNION ");
			SqlParameter[] paras = new SqlParameter[1];
			paras[0] = new SqlParameter("@BDBuildingPK", SqlDbType.UniqueIdentifier);
			paras[0].Value = bDBuildingPK;
			return base.ExecuteDataTable(sql, paras);
		}

		public int DeleteByPK( System.Guid ACInputPK, byte[] RowVersion)
		{
			string sql = string.Format("DELETE FROM [{0}] WHERE  [ACInputPK] = @ACInputPK AND [RowVersion] = @RowVersion", this.TableName);
			SqlParameter[] paras = new SqlParameter[2];
			paras[0] = new SqlParameter("@ACInputPK", SqlDbType.UniqueIdentifier);
			paras[0].Value = ACInputPK;
			paras[1] = new SqlParameter("@RowVersion", SqlDbType.Timestamp, 8);
			paras[1].Value = RowVersion;
			return base.ExecuteNonQuery(sql, paras);
		}

		public int DeleteAll()
		{
			string sql = string.Format("DELETE FROM [{0}]", this.TableName);
			return base.ExecuteNonQuery(sql, null);
		}

		public int DeleteByACPanel(System.Guid aCPanelPK)
		{
			string sql = string.Format("DELETE [{0}] FROM [{0}] [ACInput] INNER JOIN [ACPanel] ON [ACInput].[ACPanelPK] = [ACPanel].[ACPanelPK] WHERE [ACPanel].[ACPanelPK] = @ACPanelPK;", this.TableName);
			SqlParameter[] paras = new SqlParameter[1];
			paras[0] = new SqlParameter("@ACPanelPK", SqlDbType.UniqueIdentifier);
			paras[0].Value = aCPanelPK;
			return base.ExecuteNonQuery(sql, paras);
		}

		public int DeleteByBDBuilding(System.Guid bDBuildingPK)
		{
			string sql = string.Format("DELETE [{0}] FROM [{0}] [ACInput] INNER JOIN [ACPanel] ON [ACInput].[ACPanelPK] = [ACPanel].[ACPanelPK] INNER JOIN [BDBuilding] ON [ACPanel].[BDBuildingPK] = [BDBuilding].[BDBuildingPK] WHERE [BDBuilding].[BDBuildingPK] = @BDBuildingPK;", this.TableName);
			SqlParameter[] paras = new SqlParameter[1];
			paras[0] = new SqlParameter("@BDBuildingPK", SqlDbType.UniqueIdentifier);
			paras[0].Value = bDBuildingPK;
			return base.ExecuteNonQuery(sql, paras);
		}


	}
	public class ACFunctionCardCRUD : DataAccessBase
	{
		private string _tableName = "ACFunctionCard";

		public ACFunctionCardCRUD(string connectionString) : base(connectionString)
		{
		}

		public virtual string TableName
		{
			get { return this._tableName; }
			set { this._tableName = value; }
		}

		public string SQLColumns
		{
			get
			{
				return "[ACFunctionCard].[ACFunctionCardPK] AS [ACFunctionCardPK],[ACFunctionCard].[Sitecode] AS [Sitecode],[ACFunctionCard].[Embossed] AS [Embossed],[ACFunctionCard].[Encoded] AS [Encoded],[ACFunctionCard].[CardTypeID] AS [CardTypeID],[ACFunctionCard].[BDTenantPK] AS [BDTenantPK],[ACFunctionCard].[FunctionID] AS [FunctionID],[ACFunctionCard].[FirstName] AS [FirstName],[ACFunctionCard].[LastName] AS [LastName],[ACFunctionCard].[FIPS] AS [FIPS],[ACFunctionCard].[Pin] AS [Pin],[ACFunctionCard].[ValidFrom] AS [ValidFrom],[ACFunctionCard].[ValidThru] AS [ValidThru],[ACFunctionCard].[RowVersion] AS [RowVersion],[ACFunctionCard].[CreatedOn] AS [CreatedOn],[ACFunctionCard].[CreatedBy] AS [CreatedBy],[ACFunctionCard].[ModifiedOn] AS [ModifiedOn],[ACFunctionCard].[ModifiedBy] AS [ModifiedBy],[BDTenant].[Suite] AS [Suite],[BDTenant].[Tenant] AS [Tenant],[BDTenant].[BDBuildingPK] AS [BDBuildingPK],[BDBuilding].[Address1] AS [Address1],[BDBuilding].[BuildingID] AS [BuildingID]";
			}
		}

		public string SQLLeftJoins
		{
			get
			{
				return "LEFT JOIN [BDTenant] [BDTenant] ON [ACFunctionCard].[BDTenantPK] = [BDTenant].[BDTenantPK] LEFT JOIN [BDBuilding] [BDBuilding] ON [BDTenant].[BDBuildingPK] = [BDBuilding].[BDBuildingPK]";
			}
		}

		protected override string SQLSelect
		{
			get
			{
				return string.Format("SELECT [ACFunctionCard].[ACFunctionCardPK] AS [ACFunctionCardPK],[ACFunctionCard].[Sitecode] AS [Sitecode],[ACFunctionCard].[Embossed] AS [Embossed],[ACFunctionCard].[Encoded] AS [Encoded],[ACFunctionCard].[CardTypeID] AS [CardTypeID],[ACFunctionCard].[BDTenantPK] AS [BDTenantPK],[ACFunctionCard].[FunctionID] AS [FunctionID],[ACFunctionCard].[FirstName] AS [FirstName],[ACFunctionCard].[LastName] AS [LastName],[ACFunctionCard].[FIPS] AS [FIPS],[ACFunctionCard].[Pin] AS [Pin],[ACFunctionCard].[ValidFrom] AS [ValidFrom],[ACFunctionCard].[ValidThru] AS [ValidThru],[ACFunctionCard].[RowVersion] AS [RowVersion],[ACFunctionCard].[CreatedOn] AS [CreatedOn],[ACFunctionCard].[CreatedBy] AS [CreatedBy],[ACFunctionCard].[ModifiedOn] AS [ModifiedOn],[ACFunctionCard].[ModifiedBy] AS [ModifiedBy],[BDTenant].[Suite] AS [Suite],[BDTenant].[Tenant] AS [Tenant],[BDTenant].[BDBuildingPK] AS [BDBuildingPK],[BDBuilding].[Address1] AS [Address1],[BDBuilding].[BuildingID] AS [BuildingID] FROM [{0}] [ACFunctionCard] LEFT JOIN [BDTenant] [BDTenant] ON [ACFunctionCard].[BDTenantPK] = [BDTenant].[BDTenantPK] LEFT JOIN [BDBuilding] [BDBuilding] ON [BDTenant].[BDBuildingPK] = [BDBuilding].[BDBuildingPK]", this.TableName);
			}
		}

		protected override string SQLCount
		{
			get
			{
				return string.Format("SELECT COUNT(*) FROM [{0}] [ACFunctionCard] LEFT JOIN [BDTenant] [BDTenant] ON [ACFunctionCard].[BDTenantPK] = [BDTenant].[BDTenantPK] LEFT JOIN [BDBuilding] [BDBuilding] ON [BDTenant].[BDBuildingPK] = [BDBuilding].[BDBuildingPK]", this.TableName);
			}
		}

		public int Insert(ACFunctionCardData entity)
		{
			string sql = string.Format("INSERT INTO [{0}] ([ACFunctionCardPK],[Sitecode],[Embossed],[Encoded],[CardTypeID],[BDTenantPK],[FunctionID],[FirstName],[LastName],[FIPS],[Pin],[ValidFrom],[ValidThru],[CreatedOn],[CreatedBy],[ModifiedOn],[ModifiedBy]) VALUES(@ACFunctionCardPK,@Sitecode,@Embossed,@Encoded,@CardTypeID,@BDTenantPK,@FunctionID,@FirstName,@LastName,@FIPS,@Pin,@ValidFrom,@ValidThru,@CreatedOn,@CreatedBy,@ModifiedOn,@ModifiedBy)", this.TableName);
			SqlParameter[] paras = new SqlParameter[17];
			paras[0] = new SqlParameter("@ACFunctionCardPK", SqlDbType.UniqueIdentifier);
			if (entity.ACFunctionCardPK == Guid.Empty)
			{
				paras[0].Value = DBNull.Value;
			}
			else
			{
				paras[0].Value = entity.ACFunctionCardPK;
			}
			paras[1] = new SqlParameter("@Sitecode", SqlDbType.Int);
			paras[1].Value = entity.Sitecode;
			paras[2] = new SqlParameter("@Embossed", SqlDbType.Int);
			paras[2].Value = entity.Embossed;
			paras[3] = new SqlParameter("@Encoded", SqlDbType.Int);
			paras[3].Value = entity.Encoded;
			paras[4] = new SqlParameter("@CardTypeID", SqlDbType.Int);
			paras[4].Value = entity.CardTypeID;
			paras[5] = new SqlParameter("@BDTenantPK", SqlDbType.UniqueIdentifier);
			if (entity.BDTenantPK == Guid.Empty)
			{
				paras[5].Value = DBNull.Value;
			}
			else
			{
				paras[5].Value = entity.BDTenantPK;
			}
			paras[6] = new SqlParameter("@FunctionID", SqlDbType.Int);
			paras[6].Value = entity.FunctionID;
			paras[7] = new SqlParameter("@FirstName", SqlDbType.VarChar, 30);
			paras[7].Value = entity.FirstName;
			paras[8] = new SqlParameter("@LastName", SqlDbType.VarChar, 50);
			paras[8].Value = entity.LastName;
			paras[9] = new SqlParameter("@FIPS", SqlDbType.Bit);
			paras[9].Value = entity.FIPS;
			paras[10] = new SqlParameter("@Pin", SqlDbType.Int);
			paras[10].Value = entity.Pin;
			paras[11] = new SqlParameter("@ValidFrom", SqlDbType.DateTime);
			paras[11].Value = entity.ValidFrom;
			paras[12] = new SqlParameter("@ValidThru", SqlDbType.DateTime);
			paras[12].Value = entity.ValidThru;
			paras[13] = new SqlParameter("@CreatedOn", SqlDbType.DateTime);
			paras[13].Value = entity.CreatedOn;
			paras[14] = new SqlParameter("@CreatedBy", SqlDbType.VarChar, 30);
			paras[14].Value = entity.CreatedBy;
			paras[15] = new SqlParameter("@ModifiedOn", SqlDbType.DateTime);
			paras[15].Value = entity.ModifiedOn;
			paras[16] = new SqlParameter("@ModifiedBy", SqlDbType.VarChar, 30);
			paras[16].Value = entity.ModifiedBy;
			return base.ExecuteNonQuery(sql, paras);
		}

		public int Update(ACFunctionCardData entity)
		{
			string sql = string.Format("UPDATE [{0}] SET [Sitecode] = @Sitecode,[Embossed] = @Embossed,[Encoded] = @Encoded,[CardTypeID] = @CardTypeID,[BDTenantPK] = @BDTenantPK,[FunctionID] = @FunctionID,[FirstName] = @FirstName,[LastName] = @LastName,[FIPS] = @FIPS,[Pin] = @Pin,[ValidFrom] = @ValidFrom,[ValidThru] = @ValidThru,[CreatedOn] = @CreatedOn,[CreatedBy] = @CreatedBy,[ModifiedOn] = @ModifiedOn,[ModifiedBy] = @ModifiedBy  WHERE [ACFunctionCardPK] = @ACFunctionCardPK AND [RowVersion] = @RowVersion", this.TableName);
			SqlParameter[] paras = new SqlParameter[18];
			paras[0] = new SqlParameter("@ACFunctionCardPK", SqlDbType.UniqueIdentifier);
			if (entity.ACFunctionCardPK == Guid.Empty)
			{
				paras[0].Value = DBNull.Value;
			}
			else
			{
				paras[0].Value = entity.ACFunctionCardPK;
			}
			paras[1] = new SqlParameter("@Sitecode", SqlDbType.Int);
			paras[1].Value = entity.Sitecode;
			paras[2] = new SqlParameter("@Embossed", SqlDbType.Int);
			paras[2].Value = entity.Embossed;
			paras[3] = new SqlParameter("@Encoded", SqlDbType.Int);
			paras[3].Value = entity.Encoded;
			paras[4] = new SqlParameter("@CardTypeID", SqlDbType.Int);
			paras[4].Value = entity.CardTypeID;
			paras[5] = new SqlParameter("@BDTenantPK", SqlDbType.UniqueIdentifier);
			if (entity.BDTenantPK == Guid.Empty)
			{
				paras[5].Value = DBNull.Value;
			}
			else
			{
				paras[5].Value = entity.BDTenantPK;
			}
			paras[6] = new SqlParameter("@FunctionID", SqlDbType.Int);
			paras[6].Value = entity.FunctionID;
			paras[7] = new SqlParameter("@FirstName", SqlDbType.VarChar, 30);
			paras[7].Value = entity.FirstName;
			paras[8] = new SqlParameter("@LastName", SqlDbType.VarChar, 50);
			paras[8].Value = entity.LastName;
			paras[9] = new SqlParameter("@FIPS", SqlDbType.Bit);
			paras[9].Value = entity.FIPS;
			paras[10] = new SqlParameter("@Pin", SqlDbType.Int);
			paras[10].Value = entity.Pin;
			paras[11] = new SqlParameter("@ValidFrom", SqlDbType.DateTime);
			paras[11].Value = entity.ValidFrom;
			paras[12] = new SqlParameter("@ValidThru", SqlDbType.DateTime);
			paras[12].Value = entity.ValidThru;
			paras[13] = new SqlParameter("@RowVersion", SqlDbType.Timestamp);
			paras[13].Value = entity.RowVersion;
			paras[14] = new SqlParameter("@CreatedOn", SqlDbType.DateTime);
			paras[14].Value = entity.CreatedOn;
			paras[15] = new SqlParameter("@CreatedBy", SqlDbType.VarChar, 30);
			paras[15].Value = entity.CreatedBy;
			paras[16] = new SqlParameter("@ModifiedOn", SqlDbType.DateTime);
			paras[16].Value = entity.ModifiedOn;
			paras[17] = new SqlParameter("@ModifiedBy", SqlDbType.VarChar, 30);
			paras[17].Value = entity.ModifiedBy;
			return base.ExecuteNonQuery(sql, paras);
		}

		private ACFunctionCardData CreateDataByReader(SafeDataReader reader)
		{
			ACFunctionCardData data = new ACFunctionCardData {
				ACFunctionCardPK = (Guid) reader["ACFunctionCardPK"],
				Sitecode = (Int32) reader["Sitecode"],
				Embossed = (Int32) reader["Embossed"],
				Encoded = (Int32) reader["Encoded"],
				CardTypeID = (Int32) reader["CardTypeID"],
				BDTenantPK = (Guid) reader["BDTenantPK"],
				FunctionID = (Int32) reader["FunctionID"],
				FirstName = (String) reader["FirstName"],
				LastName = (String) reader["LastName"],
				FIPS = (Boolean) reader["FIPS"],
				Pin = (Int32) reader["Pin"],
				ValidFrom = (DateTime) reader["ValidFrom"],
				ValidThru = (DateTime) reader["ValidThru"],
				RowVersion = (Byte[]) reader["RowVersion"],
				CreatedOn = (DateTime) reader["CreatedOn"],
				CreatedBy = (String) reader["CreatedBy"],
				ModifiedOn = (DateTime) reader["ModifiedOn"],
				ModifiedBy = (String) reader["ModifiedBy"],
				Suite = (String) reader["Suite"],
				Tenant = (String) reader["Tenant"],
				BDBuildingPK = (Guid) reader["BDBuildingPK"],
				Address1 = (String) reader["Address1"],
				BuildingID = (Int32) reader["BuildingID"]
			};
			data.AcceptChanges();
			return data;
		}

		private ACFunctionCardData FetchEntity(string where, SqlParameter[] paras)
		{
			ACFunctionCardData data = null;
			using (SafeDataReader reader = base.ExecuteDataReader(where, paras))
			{
				if (reader.Read())
				{
					data = this.CreateDataByReader(reader);
				}
				reader.Close();
			}
			return data;
		}

		private ACFunctionCardData FetchEntityEx(string sql, SqlParameter[] paras)
		{
			ACFunctionCardData data = null;
			using (SafeDataReader reader = base.ExecuteDataReaderEx(sql, paras))
			{
				if (reader.Read())
				{
					data = this.CreateDataByReader(reader);
				}
				reader.Close();
			}
			return data;
		}

		private ACFunctionCardDataCollection FetchCollection(string where, SqlParameter[] paras)
		{
			ACFunctionCardDataCollection list = new ACFunctionCardDataCollection();
			using (SafeDataReader reader = base.ExecuteDataReader(where, paras))
			{
				while(reader.Read())
				{
					ACFunctionCardData data = this.CreateDataByReader(reader);
					list.Add(data);
				}
				reader.Close();
			}
			return list;
		}

		private ACFunctionCardDataCollection FetchCollectionEx(string sql, SqlParameter[] paras)
		{
			ACFunctionCardDataCollection list = new ACFunctionCardDataCollection();
			using (SafeDataReader reader = base.ExecuteDataReaderEx(sql, paras))
			{
				while(reader.Read())
				{
					ACFunctionCardData data = this.CreateDataByReader(reader);
					list.Add(data);
				}
				reader.Close();
			}
			return list;
		}

		public ACFunctionCardData GetEntityBy(string sqlWhere, SqlParameter[] paras)
		{
			return this.FetchEntity(sqlWhere, paras);
		}

		public ACFunctionCardData GetEntityExBy(string sql, SqlParameter[] paras)
		{
			return this.FetchEntityEx(sql, paras);
		}

		public ACFunctionCardDataCollection GetCollectionBy(string sqlWhere, SqlParameter[] paras)
		{
			return this.FetchCollection(sqlWhere, paras);
		}

		public ACFunctionCardDataCollection GetCollectionExBy(string sql, SqlParameter[] paras)
		{
			return this.FetchCollectionEx(sql, paras);
		}

		public byte[] GetRowVersion( System.Guid ACFunctionCardPK)
		{
			string sql = string.Format("SELECT [RowVersion] AS [RowVersion] FROM [{0}] WHERE  [ACFunctionCardPK] = @ACFunctionCardPK ", this.TableName);
			SqlParameter[] paras = new SqlParameter[1];
			paras[0] = new SqlParameter("@ACFunctionCardPK", SqlDbType.UniqueIdentifier, 16);
			paras[0].Value = ACFunctionCardPK;
			return (byte[]) base.ExecuteScalar(sql, paras);
		}

		public ACFunctionCardData GetByPK( System.Guid ACFunctionCardPK)
		{
			string sql = " WHERE  [ACFunctionCard].[ACFunctionCardPK] = @ACFunctionCardPK ";
			SqlParameter[] paras = new SqlParameter[1];
			paras[0] = new SqlParameter("@ACFunctionCardPK", SqlDbType.UniqueIdentifier);
			paras[0].Value = ACFunctionCardPK;
			return this.FetchEntity(sql, paras);
		}

		public ACFunctionCardDataCollection GetAll()
		{
			return this.FetchCollection("", null);
		}

		public ACFunctionCardDataCollection GetByBDTenant(System.Guid BDTenantPK)
		{
			string sqlWhere = " WHERE [ACFunctionCard].[BDTenantPK] = @BDTenantPK";
			SqlParameter[] paras = new SqlParameter[1];
			paras[0] = new SqlParameter("@BDTenantPK", SqlDbType.UniqueIdentifier);
			paras[0].Value = BDTenantPK;
			return this.FetchCollection(sqlWhere, paras);
		}

		public DataTable GetLogByPK( System.Guid ACFunctionCardPK)
		{
			string sql = string.Format("SELECT  [ACFunctionCard].[ACFunctionCardPK] AS [ACFunctionCardPK], [ACFunctionCard].[ModifiedOn] AS [ModifiedOn] FROM [{0}] WHERE  [ACFunctionCard].[ACFunctionCardPK] = @ACFunctionCardPK ", this.TableName);
			SqlParameter[] paras = new SqlParameter[1];
			paras[0] = new SqlParameter("@ACFunctionCardPK", SqlDbType.UniqueIdentifier);
			paras[0].Value = ACFunctionCardPK;
			return this.ExecuteDataTable(sql, paras);
		}

		public DataTable GetLogByBDTenant(System.Guid bDTenantPK)
		{
			string sql = string.Format("DELETE [{0}] FROM [{0}] [ACFunctionCard] INNER JOIN [BDTenant] ON [ACFunctionCard].[BDTenantPK] = [BDTenant].[BDTenantPK] WHERE [BDTenant].[BDTenantPK] = @BDTenantPK;", this.TableName);
			string oldValue = string.Format("DELETE [{0}]", this.TableName);
			string newValue = "SELECT  [ACFunctionCard].[ACFunctionCardPK] AS [ACFunctionCardPK], [ACFunctionCard].[ModifiedOn] AS [ModifiedOn]";
			sql = sql.Replace(oldValue, newValue).TrimEnd().TrimEnd(';').Replace(";", " UNION ");
			SqlParameter[] paras = new SqlParameter[1];
			paras[0] = new SqlParameter("@BDTenantPK", SqlDbType.UniqueIdentifier);
			paras[0].Value = bDTenantPK;
			return base.ExecuteDataTable(sql, paras);
		}

		public DataTable GetLogByBDBuilding(System.Guid bDBuildingPK)
		{
			string sql = string.Format("DELETE [{0}] FROM [{0}] [ACFunctionCard] INNER JOIN [BDTenant] ON [ACFunctionCard].[BDTenantPK] = [BDTenant].[BDTenantPK] INNER JOIN [BDBuilding] ON [BDTenant].[BDBuildingPK] = [BDBuilding].[BDBuildingPK] WHERE [BDBuilding].[BDBuildingPK] = @BDBuildingPK;", this.TableName);
			string oldValue = string.Format("DELETE [{0}]", this.TableName);
			string newValue = "SELECT  [ACFunctionCard].[ACFunctionCardPK] AS [ACFunctionCardPK], [ACFunctionCard].[ModifiedOn] AS [ModifiedOn]";
			sql = sql.Replace(oldValue, newValue).TrimEnd().TrimEnd(';').Replace(";", " UNION ");
			SqlParameter[] paras = new SqlParameter[1];
			paras[0] = new SqlParameter("@BDBuildingPK", SqlDbType.UniqueIdentifier);
			paras[0].Value = bDBuildingPK;
			return base.ExecuteDataTable(sql, paras);
		}

		public int DeleteByPK( System.Guid ACFunctionCardPK, byte[] RowVersion)
		{
			string sql = string.Format("DELETE FROM [{0}] WHERE  [ACFunctionCardPK] = @ACFunctionCardPK AND [RowVersion] = @RowVersion", this.TableName);
			SqlParameter[] paras = new SqlParameter[2];
			paras[0] = new SqlParameter("@ACFunctionCardPK", SqlDbType.UniqueIdentifier);
			paras[0].Value = ACFunctionCardPK;
			paras[1] = new SqlParameter("@RowVersion", SqlDbType.Timestamp, 8);
			paras[1].Value = RowVersion;
			return base.ExecuteNonQuery(sql, paras);
		}

		public int DeleteAll()
		{
			string sql = string.Format("DELETE FROM [{0}]", this.TableName);
			return base.ExecuteNonQuery(sql, null);
		}

		public int DeleteByBDTenant(System.Guid bDTenantPK)
		{
			string sql = string.Format("DELETE [{0}] FROM [{0}] [ACFunctionCard] INNER JOIN [BDTenant] ON [ACFunctionCard].[BDTenantPK] = [BDTenant].[BDTenantPK] WHERE [BDTenant].[BDTenantPK] = @BDTenantPK;", this.TableName);
			SqlParameter[] paras = new SqlParameter[1];
			paras[0] = new SqlParameter("@BDTenantPK", SqlDbType.UniqueIdentifier);
			paras[0].Value = bDTenantPK;
			return base.ExecuteNonQuery(sql, paras);
		}

		public int DeleteByBDBuilding(System.Guid bDBuildingPK)
		{
			string sql = string.Format("DELETE [{0}] FROM [{0}] [ACFunctionCard] INNER JOIN [BDTenant] ON [ACFunctionCard].[BDTenantPK] = [BDTenant].[BDTenantPK] INNER JOIN [BDBuilding] ON [BDTenant].[BDBuildingPK] = [BDBuilding].[BDBuildingPK] WHERE [BDBuilding].[BDBuildingPK] = @BDBuildingPK;", this.TableName);
			SqlParameter[] paras = new SqlParameter[1];
			paras[0] = new SqlParameter("@BDBuildingPK", SqlDbType.UniqueIdentifier);
			paras[0].Value = bDBuildingPK;
			return base.ExecuteNonQuery(sql, paras);
		}


	}
	public class UtilHolidayCRUD : DataAccessBase
	{
		private string _tableName = "UtilHoliday";

		public UtilHolidayCRUD(string connectionString) : base(connectionString)
		{
		}

		public virtual string TableName
		{
			get { return this._tableName; }
			set { this._tableName = value; }
		}

		public string SQLColumns
		{
			get
			{
				return "[UtilHoliday].[UtilHolidayPK] AS [UtilHolidayPK],[UtilHoliday].[CountryID] AS [CountryID],[UtilHoliday].[Holiday] AS [Holiday],[UtilHoliday].[Date] AS [Date],[UtilHoliday].[Major] AS [Major],[UtilHoliday].[Federal] AS [Federal],[UtilHoliday].[RowVersion] AS [RowVersion],[UtilHoliday].[CreatedOn] AS [CreatedOn],[UtilHoliday].[CreatedBy] AS [CreatedBy],[UtilHoliday].[ModifiedOn] AS [ModifiedOn],[UtilHoliday].[ModifiedBy] AS [ModifiedBy],[UtilHoliday].[Default] AS [Default],[UtilHoliday].[ActionID] AS [ActionID]";
			}
		}

		public string SQLLeftJoins
		{
			get
			{
				return "";
			}
		}

		protected override string SQLSelect
		{
			get
			{
				return string.Format("SELECT [UtilHoliday].[UtilHolidayPK] AS [UtilHolidayPK],[UtilHoliday].[CountryID] AS [CountryID],[UtilHoliday].[Holiday] AS [Holiday],[UtilHoliday].[Date] AS [Date],[UtilHoliday].[Major] AS [Major],[UtilHoliday].[Federal] AS [Federal],[UtilHoliday].[RowVersion] AS [RowVersion],[UtilHoliday].[CreatedOn] AS [CreatedOn],[UtilHoliday].[CreatedBy] AS [CreatedBy],[UtilHoliday].[ModifiedOn] AS [ModifiedOn],[UtilHoliday].[ModifiedBy] AS [ModifiedBy],[UtilHoliday].[Default] AS [Default],[UtilHoliday].[ActionID] AS [ActionID] FROM [{0}] [UtilHoliday] ", this.TableName);
			}
		}

		protected override string SQLCount
		{
			get
			{
				return string.Format("SELECT COUNT(*) FROM [{0}] [UtilHoliday] ", this.TableName);
			}
		}

		public int Insert(UtilHolidayData entity)
		{
			string sql = string.Format("INSERT INTO [{0}] ([UtilHolidayPK],[CountryID],[Holiday],[Date],[Major],[Federal],[CreatedOn],[CreatedBy],[ModifiedOn],[ModifiedBy],[Default],[ActionID]) VALUES(@UtilHolidayPK,@CountryID,@Holiday,@Date,@Major,@Federal,@CreatedOn,@CreatedBy,@ModifiedOn,@ModifiedBy,@Default,@ActionID)", this.TableName);
			SqlParameter[] paras = new SqlParameter[12];
			paras[0] = new SqlParameter("@UtilHolidayPK", SqlDbType.UniqueIdentifier);
			if (entity.UtilHolidayPK == Guid.Empty)
			{
				paras[0].Value = DBNull.Value;
			}
			else
			{
				paras[0].Value = entity.UtilHolidayPK;
			}
			paras[1] = new SqlParameter("@CountryID", SqlDbType.Int);
			paras[1].Value = entity.CountryID;
			paras[2] = new SqlParameter("@Holiday", SqlDbType.VarChar, 30);
			paras[2].Value = entity.Holiday;
			paras[3] = new SqlParameter("@Date", SqlDbType.DateTime);
			paras[3].Value = entity.Date;
			paras[4] = new SqlParameter("@Major", SqlDbType.Bit);
			paras[4].Value = entity.Major;
			paras[5] = new SqlParameter("@Federal", SqlDbType.Bit);
			paras[5].Value = entity.Federal;
			paras[6] = new SqlParameter("@CreatedOn", SqlDbType.DateTime);
			paras[6].Value = entity.CreatedOn;
			paras[7] = new SqlParameter("@CreatedBy", SqlDbType.VarChar, 30);
			paras[7].Value = entity.CreatedBy;
			paras[8] = new SqlParameter("@ModifiedOn", SqlDbType.DateTime);
			paras[8].Value = entity.ModifiedOn;
			paras[9] = new SqlParameter("@ModifiedBy", SqlDbType.VarChar, 30);
			paras[9].Value = entity.ModifiedBy;
			paras[10] = new SqlParameter("@Default", SqlDbType.Bit);
			paras[10].Value = entity.Default;
			paras[11] = new SqlParameter("@ActionID", SqlDbType.Int);
			paras[11].Value = entity.ActionID;
			return base.ExecuteNonQuery(sql, paras);
		}

		public int Update(UtilHolidayData entity)
		{
			string sql = string.Format("UPDATE [{0}] SET [CountryID] = @CountryID,[Holiday] = @Holiday,[Date] = @Date,[Major] = @Major,[Federal] = @Federal,[CreatedOn] = @CreatedOn,[CreatedBy] = @CreatedBy,[ModifiedOn] = @ModifiedOn,[ModifiedBy] = @ModifiedBy,[Default] = @Default,[ActionID] = @ActionID  WHERE [UtilHolidayPK] = @UtilHolidayPK AND [RowVersion] = @RowVersion", this.TableName);
			SqlParameter[] paras = new SqlParameter[13];
			paras[0] = new SqlParameter("@UtilHolidayPK", SqlDbType.UniqueIdentifier);
			if (entity.UtilHolidayPK == Guid.Empty)
			{
				paras[0].Value = DBNull.Value;
			}
			else
			{
				paras[0].Value = entity.UtilHolidayPK;
			}
			paras[1] = new SqlParameter("@CountryID", SqlDbType.Int);
			paras[1].Value = entity.CountryID;
			paras[2] = new SqlParameter("@Holiday", SqlDbType.VarChar, 30);
			paras[2].Value = entity.Holiday;
			paras[3] = new SqlParameter("@Date", SqlDbType.DateTime);
			paras[3].Value = entity.Date;
			paras[4] = new SqlParameter("@Major", SqlDbType.Bit);
			paras[4].Value = entity.Major;
			paras[5] = new SqlParameter("@Federal", SqlDbType.Bit);
			paras[5].Value = entity.Federal;
			paras[6] = new SqlParameter("@RowVersion", SqlDbType.Timestamp);
			paras[6].Value = entity.RowVersion;
			paras[7] = new SqlParameter("@CreatedOn", SqlDbType.DateTime);
			paras[7].Value = entity.CreatedOn;
			paras[8] = new SqlParameter("@CreatedBy", SqlDbType.VarChar, 30);
			paras[8].Value = entity.CreatedBy;
			paras[9] = new SqlParameter("@ModifiedOn", SqlDbType.DateTime);
			paras[9].Value = entity.ModifiedOn;
			paras[10] = new SqlParameter("@ModifiedBy", SqlDbType.VarChar, 30);
			paras[10].Value = entity.ModifiedBy;
			paras[11] = new SqlParameter("@Default", SqlDbType.Bit);
			paras[11].Value = entity.Default;
			paras[12] = new SqlParameter("@ActionID", SqlDbType.Int);
			paras[12].Value = entity.ActionID;
			return base.ExecuteNonQuery(sql, paras);
		}

		private UtilHolidayData CreateDataByReader(SafeDataReader reader)
		{
			UtilHolidayData data = new UtilHolidayData {
				UtilHolidayPK = (Guid) reader["UtilHolidayPK"],
				CountryID = (Int32) reader["CountryID"],
				Holiday = (String) reader["Holiday"],
				Date = (DateTime) reader["Date"],
				Major = (Boolean) reader["Major"],
				Federal = (Boolean) reader["Federal"],
				RowVersion = (Byte[]) reader["RowVersion"],
				CreatedOn = (DateTime) reader["CreatedOn"],
				CreatedBy = (String) reader["CreatedBy"],
				ModifiedOn = (DateTime) reader["ModifiedOn"],
				ModifiedBy = (String) reader["ModifiedBy"],
				Default = (Boolean) reader["Default"],
				ActionID = (Int32) reader["ActionID"]
			};
			data.AcceptChanges();
			return data;
		}

		private UtilHolidayData FetchEntity(string where, SqlParameter[] paras)
		{
			UtilHolidayData data = null;
			using (SafeDataReader reader = base.ExecuteDataReader(where, paras))
			{
				if (reader.Read())
				{
					data = this.CreateDataByReader(reader);
				}
				reader.Close();
			}
			return data;
		}

		private UtilHolidayData FetchEntityEx(string sql, SqlParameter[] paras)
		{
			UtilHolidayData data = null;
			using (SafeDataReader reader = base.ExecuteDataReaderEx(sql, paras))
			{
				if (reader.Read())
				{
					data = this.CreateDataByReader(reader);
				}
				reader.Close();
			}
			return data;
		}

		private UtilHolidayDataCollection FetchCollection(string where, SqlParameter[] paras)
		{
			UtilHolidayDataCollection list = new UtilHolidayDataCollection();
			using (SafeDataReader reader = base.ExecuteDataReader(where, paras))
			{
				while(reader.Read())
				{
					UtilHolidayData data = this.CreateDataByReader(reader);
					list.Add(data);
				}
				reader.Close();
			}
			return list;
		}

		private UtilHolidayDataCollection FetchCollectionEx(string sql, SqlParameter[] paras)
		{
			UtilHolidayDataCollection list = new UtilHolidayDataCollection();
			using (SafeDataReader reader = base.ExecuteDataReaderEx(sql, paras))
			{
				while(reader.Read())
				{
					UtilHolidayData data = this.CreateDataByReader(reader);
					list.Add(data);
				}
				reader.Close();
			}
			return list;
		}

		public UtilHolidayData GetEntityBy(string sqlWhere, SqlParameter[] paras)
		{
			return this.FetchEntity(sqlWhere, paras);
		}

		public UtilHolidayData GetEntityExBy(string sql, SqlParameter[] paras)
		{
			return this.FetchEntityEx(sql, paras);
		}

		public UtilHolidayDataCollection GetCollectionBy(string sqlWhere, SqlParameter[] paras)
		{
			return this.FetchCollection(sqlWhere, paras);
		}

		public UtilHolidayDataCollection GetCollectionExBy(string sql, SqlParameter[] paras)
		{
			return this.FetchCollectionEx(sql, paras);
		}

		public byte[] GetRowVersion( System.Guid UtilHolidayPK)
		{
			string sql = string.Format("SELECT [RowVersion] AS [RowVersion] FROM [{0}] WHERE  [UtilHolidayPK] = @UtilHolidayPK ", this.TableName);
			SqlParameter[] paras = new SqlParameter[1];
			paras[0] = new SqlParameter("@UtilHolidayPK", SqlDbType.UniqueIdentifier, 16);
			paras[0].Value = UtilHolidayPK;
			return (byte[]) base.ExecuteScalar(sql, paras);
		}

		public UtilHolidayData GetByPK( System.Guid UtilHolidayPK)
		{
			string sql = " WHERE  [UtilHoliday].[UtilHolidayPK] = @UtilHolidayPK ";
			SqlParameter[] paras = new SqlParameter[1];
			paras[0] = new SqlParameter("@UtilHolidayPK", SqlDbType.UniqueIdentifier);
			paras[0].Value = UtilHolidayPK;
			return this.FetchEntity(sql, paras);
		}

		public UtilHolidayDataCollection GetAll()
		{
			return this.FetchCollection("", null);
		}

		public DataTable GetLogByPK( System.Guid UtilHolidayPK)
		{
			string sql = string.Format("SELECT  [UtilHoliday].[UtilHolidayPK] AS [UtilHolidayPK], [UtilHoliday].[ModifiedOn] AS [ModifiedOn] FROM [{0}] WHERE  [UtilHoliday].[UtilHolidayPK] = @UtilHolidayPK ", this.TableName);
			SqlParameter[] paras = new SqlParameter[1];
			paras[0] = new SqlParameter("@UtilHolidayPK", SqlDbType.UniqueIdentifier);
			paras[0].Value = UtilHolidayPK;
			return this.ExecuteDataTable(sql, paras);
		}

		public int DeleteByPK( System.Guid UtilHolidayPK, byte[] RowVersion)
		{
			string sql = string.Format("DELETE FROM [{0}] WHERE  [UtilHolidayPK] = @UtilHolidayPK AND [RowVersion] = @RowVersion", this.TableName);
			SqlParameter[] paras = new SqlParameter[2];
			paras[0] = new SqlParameter("@UtilHolidayPK", SqlDbType.UniqueIdentifier);
			paras[0].Value = UtilHolidayPK;
			paras[1] = new SqlParameter("@RowVersion", SqlDbType.Timestamp, 8);
			paras[1].Value = RowVersion;
			return base.ExecuteNonQuery(sql, paras);
		}

		public int DeleteAll()
		{
			string sql = string.Format("DELETE FROM [{0}]", this.TableName);
			return base.ExecuteNonQuery(sql, null);
		}


	}
	public class ACAccessLevelCRUD : DataAccessBase
	{
		private string _tableName = "ACAccessLevel";

		public ACAccessLevelCRUD(string connectionString) : base(connectionString)
		{
		}

		public virtual string TableName
		{
			get { return this._tableName; }
			set { this._tableName = value; }
		}

		public string SQLColumns
		{
			get
			{
				return "[ACAccessLevel].[ACAccessLevelPK] AS [ACAccessLevelPK],[ACAccessLevel].[BDBuildingPK] AS [BDBuildingPK],[ACAccessLevel].[AccessLevelID] AS [AccessLevelID],[ACAccessLevel].[Summary] AS [Summary],[ACAccessLevel].[AsAL2] AS [AsAL2],[ACAccessLevel].[Notes] AS [Notes],[ACAccessLevel].[RowVersion] AS [RowVersion],[ACAccessLevel].[CreatedOn] AS [CreatedOn],[ACAccessLevel].[CreatedBy] AS [CreatedBy],[ACAccessLevel].[ModifiedOn] AS [ModifiedOn],[ACAccessLevel].[ModifiedBy] AS [ModifiedBy],[BDBuilding].[Address1] AS [Address1],[BDBuilding].[BuildingID] AS [BuildingID]";
			}
		}

		public string SQLLeftJoins
		{
			get
			{
				return "LEFT JOIN [BDBuilding] [BDBuilding] ON [ACAccessLevel].[BDBuildingPK] = [BDBuilding].[BDBuildingPK]";
			}
		}

		protected override string SQLSelect
		{
			get
			{
				return string.Format("SELECT [ACAccessLevel].[ACAccessLevelPK] AS [ACAccessLevelPK],[ACAccessLevel].[BDBuildingPK] AS [BDBuildingPK],[ACAccessLevel].[AccessLevelID] AS [AccessLevelID],[ACAccessLevel].[Summary] AS [Summary],[ACAccessLevel].[AsAL2] AS [AsAL2],[ACAccessLevel].[Notes] AS [Notes],[ACAccessLevel].[RowVersion] AS [RowVersion],[ACAccessLevel].[CreatedOn] AS [CreatedOn],[ACAccessLevel].[CreatedBy] AS [CreatedBy],[ACAccessLevel].[ModifiedOn] AS [ModifiedOn],[ACAccessLevel].[ModifiedBy] AS [ModifiedBy],[BDBuilding].[Address1] AS [Address1],[BDBuilding].[BuildingID] AS [BuildingID] FROM [{0}] [ACAccessLevel] LEFT JOIN [BDBuilding] [BDBuilding] ON [ACAccessLevel].[BDBuildingPK] = [BDBuilding].[BDBuildingPK]", this.TableName);
			}
		}

		protected override string SQLCount
		{
			get
			{
				return string.Format("SELECT COUNT(*) FROM [{0}] [ACAccessLevel] LEFT JOIN [BDBuilding] [BDBuilding] ON [ACAccessLevel].[BDBuildingPK] = [BDBuilding].[BDBuildingPK]", this.TableName);
			}
		}

		public int Insert(ACAccessLevelData entity)
		{
			string sql = string.Format("INSERT INTO [{0}] ([ACAccessLevelPK],[BDBuildingPK],[AccessLevelID],[Summary],[AsAL2],[Notes],[CreatedOn],[CreatedBy],[ModifiedOn],[ModifiedBy]) VALUES(@ACAccessLevelPK,@BDBuildingPK,@AccessLevelID,@Summary,@AsAL2,@Notes,@CreatedOn,@CreatedBy,@ModifiedOn,@ModifiedBy)", this.TableName);
			SqlParameter[] paras = new SqlParameter[10];
			paras[0] = new SqlParameter("@ACAccessLevelPK", SqlDbType.UniqueIdentifier);
			if (entity.ACAccessLevelPK == Guid.Empty)
			{
				paras[0].Value = DBNull.Value;
			}
			else
			{
				paras[0].Value = entity.ACAccessLevelPK;
			}
			paras[1] = new SqlParameter("@BDBuildingPK", SqlDbType.UniqueIdentifier);
			if (entity.BDBuildingPK == Guid.Empty)
			{
				paras[1].Value = DBNull.Value;
			}
			else
			{
				paras[1].Value = entity.BDBuildingPK;
			}
			paras[2] = new SqlParameter("@AccessLevelID", SqlDbType.SmallInt);
			paras[2].Value = entity.AccessLevelID;
			paras[3] = new SqlParameter("@Summary", SqlDbType.VarChar, 256);
			paras[3].Value = entity.Summary;
			paras[4] = new SqlParameter("@AsAL2", SqlDbType.Bit);
			paras[4].Value = entity.AsAL2;
			paras[5] = new SqlParameter("@Notes", SqlDbType.VarChar, 512);
			paras[5].Value = entity.Notes;
			paras[6] = new SqlParameter("@CreatedOn", SqlDbType.DateTime);
			paras[6].Value = entity.CreatedOn;
			paras[7] = new SqlParameter("@CreatedBy", SqlDbType.VarChar, 30);
			paras[7].Value = entity.CreatedBy;
			paras[8] = new SqlParameter("@ModifiedOn", SqlDbType.DateTime);
			paras[8].Value = entity.ModifiedOn;
			paras[9] = new SqlParameter("@ModifiedBy", SqlDbType.VarChar, 30);
			paras[9].Value = entity.ModifiedBy;
			return base.ExecuteNonQuery(sql, paras);
		}

		public int Update(ACAccessLevelData entity)
		{
			string sql = string.Format("UPDATE [{0}] SET [BDBuildingPK] = @BDBuildingPK,[AccessLevelID] = @AccessLevelID,[Summary] = @Summary,[AsAL2] = @AsAL2,[Notes] = @Notes,[CreatedOn] = @CreatedOn,[CreatedBy] = @CreatedBy,[ModifiedOn] = @ModifiedOn,[ModifiedBy] = @ModifiedBy  WHERE [ACAccessLevelPK] = @ACAccessLevelPK AND [RowVersion] = @RowVersion", this.TableName);
			SqlParameter[] paras = new SqlParameter[11];
			paras[0] = new SqlParameter("@ACAccessLevelPK", SqlDbType.UniqueIdentifier);
			if (entity.ACAccessLevelPK == Guid.Empty)
			{
				paras[0].Value = DBNull.Value;
			}
			else
			{
				paras[0].Value = entity.ACAccessLevelPK;
			}
			paras[1] = new SqlParameter("@BDBuildingPK", SqlDbType.UniqueIdentifier);
			if (entity.BDBuildingPK == Guid.Empty)
			{
				paras[1].Value = DBNull.Value;
			}
			else
			{
				paras[1].Value = entity.BDBuildingPK;
			}
			paras[2] = new SqlParameter("@AccessLevelID", SqlDbType.SmallInt);
			paras[2].Value = entity.AccessLevelID;
			paras[3] = new SqlParameter("@Summary", SqlDbType.VarChar, 256);
			paras[3].Value = entity.Summary;
			paras[4] = new SqlParameter("@AsAL2", SqlDbType.Bit);
			paras[4].Value = entity.AsAL2;
			paras[5] = new SqlParameter("@Notes", SqlDbType.VarChar, 512);
			paras[5].Value = entity.Notes;
			paras[6] = new SqlParameter("@RowVersion", SqlDbType.Timestamp);
			paras[6].Value = entity.RowVersion;
			paras[7] = new SqlParameter("@CreatedOn", SqlDbType.DateTime);
			paras[7].Value = entity.CreatedOn;
			paras[8] = new SqlParameter("@CreatedBy", SqlDbType.VarChar, 30);
			paras[8].Value = entity.CreatedBy;
			paras[9] = new SqlParameter("@ModifiedOn", SqlDbType.DateTime);
			paras[9].Value = entity.ModifiedOn;
			paras[10] = new SqlParameter("@ModifiedBy", SqlDbType.VarChar, 30);
			paras[10].Value = entity.ModifiedBy;
			return base.ExecuteNonQuery(sql, paras);
		}

		private ACAccessLevelData CreateDataByReader(SafeDataReader reader)
		{
			ACAccessLevelData data = new ACAccessLevelData {
				ACAccessLevelPK = (Guid) reader["ACAccessLevelPK"],
				BDBuildingPK = (Guid) reader["BDBuildingPK"],
				AccessLevelID = (Int16) reader["AccessLevelID"],
				Summary = (String) reader["Summary"],
				AsAL2 = (Boolean) reader["AsAL2"],
				Notes = (String) reader["Notes"],
				RowVersion = (Byte[]) reader["RowVersion"],
				CreatedOn = (DateTime) reader["CreatedOn"],
				CreatedBy = (String) reader["CreatedBy"],
				ModifiedOn = (DateTime) reader["ModifiedOn"],
				ModifiedBy = (String) reader["ModifiedBy"],
				Address1 = (String) reader["Address1"],
				BuildingID = (Int32) reader["BuildingID"]
			};
			data.AcceptChanges();
			return data;
		}

		private ACAccessLevelData FetchEntity(string where, SqlParameter[] paras)
		{
			ACAccessLevelData data = null;
			using (SafeDataReader reader = base.ExecuteDataReader(where, paras))
			{
				if (reader.Read())
				{
					data = this.CreateDataByReader(reader);
				}
				reader.Close();
			}
			return data;
		}

		private ACAccessLevelData FetchEntityEx(string sql, SqlParameter[] paras)
		{
			ACAccessLevelData data = null;
			using (SafeDataReader reader = base.ExecuteDataReaderEx(sql, paras))
			{
				if (reader.Read())
				{
					data = this.CreateDataByReader(reader);
				}
				reader.Close();
			}
			return data;
		}

		private ACAccessLevelDataCollection FetchCollection(string where, SqlParameter[] paras)
		{
			ACAccessLevelDataCollection list = new ACAccessLevelDataCollection();
			using (SafeDataReader reader = base.ExecuteDataReader(where, paras))
			{
				while(reader.Read())
				{
					ACAccessLevelData data = this.CreateDataByReader(reader);
					list.Add(data);
				}
				reader.Close();
			}
			return list;
		}

		private ACAccessLevelDataCollection FetchCollectionEx(string sql, SqlParameter[] paras)
		{
			ACAccessLevelDataCollection list = new ACAccessLevelDataCollection();
			using (SafeDataReader reader = base.ExecuteDataReaderEx(sql, paras))
			{
				while(reader.Read())
				{
					ACAccessLevelData data = this.CreateDataByReader(reader);
					list.Add(data);
				}
				reader.Close();
			}
			return list;
		}

		public ACAccessLevelData GetEntityBy(string sqlWhere, SqlParameter[] paras)
		{
			return this.FetchEntity(sqlWhere, paras);
		}

		public ACAccessLevelData GetEntityExBy(string sql, SqlParameter[] paras)
		{
			return this.FetchEntityEx(sql, paras);
		}

		public ACAccessLevelDataCollection GetCollectionBy(string sqlWhere, SqlParameter[] paras)
		{
			return this.FetchCollection(sqlWhere, paras);
		}

		public ACAccessLevelDataCollection GetCollectionExBy(string sql, SqlParameter[] paras)
		{
			return this.FetchCollectionEx(sql, paras);
		}

		public byte[] GetRowVersion( System.Guid ACAccessLevelPK)
		{
			string sql = string.Format("SELECT [RowVersion] AS [RowVersion] FROM [{0}] WHERE  [ACAccessLevelPK] = @ACAccessLevelPK ", this.TableName);
			SqlParameter[] paras = new SqlParameter[1];
			paras[0] = new SqlParameter("@ACAccessLevelPK", SqlDbType.UniqueIdentifier, 16);
			paras[0].Value = ACAccessLevelPK;
			return (byte[]) base.ExecuteScalar(sql, paras);
		}

		public ACAccessLevelData GetByPK( System.Guid ACAccessLevelPK)
		{
			string sql = " WHERE  [ACAccessLevel].[ACAccessLevelPK] = @ACAccessLevelPK ";
			SqlParameter[] paras = new SqlParameter[1];
			paras[0] = new SqlParameter("@ACAccessLevelPK", SqlDbType.UniqueIdentifier);
			paras[0].Value = ACAccessLevelPK;
			return this.FetchEntity(sql, paras);
		}

		public ACAccessLevelDataCollection GetAll()
		{
			return this.FetchCollection("", null);
		}

		public ACAccessLevelDataCollection GetByBDBuilding(System.Guid BDBuildingPK)
		{
			string sqlWhere = " WHERE [ACAccessLevel].[BDBuildingPK] = @BDBuildingPK";
			SqlParameter[] paras = new SqlParameter[1];
			paras[0] = new SqlParameter("@BDBuildingPK", SqlDbType.UniqueIdentifier);
			paras[0].Value = BDBuildingPK;
			return this.FetchCollection(sqlWhere, paras);
		}

		public DataTable GetLogByPK( System.Guid ACAccessLevelPK)
		{
			string sql = string.Format("SELECT  [ACAccessLevel].[ACAccessLevelPK] AS [ACAccessLevelPK], [ACAccessLevel].[ModifiedOn] AS [ModifiedOn] FROM [{0}] WHERE  [ACAccessLevel].[ACAccessLevelPK] = @ACAccessLevelPK ", this.TableName);
			SqlParameter[] paras = new SqlParameter[1];
			paras[0] = new SqlParameter("@ACAccessLevelPK", SqlDbType.UniqueIdentifier);
			paras[0].Value = ACAccessLevelPK;
			return this.ExecuteDataTable(sql, paras);
		}

		public DataTable GetLogByBDBuilding(System.Guid bDBuildingPK)
		{
			string sql = string.Format("DELETE [{0}] FROM [{0}] [ACAccessLevel] INNER JOIN [BDBuilding] ON [ACAccessLevel].[BDBuildingPK] = [BDBuilding].[BDBuildingPK] WHERE [BDBuilding].[BDBuildingPK] = @BDBuildingPK;", this.TableName);
			string oldValue = string.Format("DELETE [{0}]", this.TableName);
			string newValue = "SELECT  [ACAccessLevel].[ACAccessLevelPK] AS [ACAccessLevelPK], [ACAccessLevel].[ModifiedOn] AS [ModifiedOn]";
			sql = sql.Replace(oldValue, newValue).TrimEnd().TrimEnd(';').Replace(";", " UNION ");
			SqlParameter[] paras = new SqlParameter[1];
			paras[0] = new SqlParameter("@BDBuildingPK", SqlDbType.UniqueIdentifier);
			paras[0].Value = bDBuildingPK;
			return base.ExecuteDataTable(sql, paras);
		}

		public int DeleteByPK( System.Guid ACAccessLevelPK, byte[] RowVersion)
		{
			string sql = string.Format("DELETE FROM [{0}] WHERE  [ACAccessLevelPK] = @ACAccessLevelPK AND [RowVersion] = @RowVersion", this.TableName);
			SqlParameter[] paras = new SqlParameter[2];
			paras[0] = new SqlParameter("@ACAccessLevelPK", SqlDbType.UniqueIdentifier);
			paras[0].Value = ACAccessLevelPK;
			paras[1] = new SqlParameter("@RowVersion", SqlDbType.Timestamp, 8);
			paras[1].Value = RowVersion;
			return base.ExecuteNonQuery(sql, paras);
		}

		public int DeleteAll()
		{
			string sql = string.Format("DELETE FROM [{0}]", this.TableName);
			return base.ExecuteNonQuery(sql, null);
		}

		public int DeleteByBDBuilding(System.Guid bDBuildingPK)
		{
			string sql = string.Format("DELETE [{0}] FROM [{0}] [ACAccessLevel] INNER JOIN [BDBuilding] ON [ACAccessLevel].[BDBuildingPK] = [BDBuilding].[BDBuildingPK] WHERE [BDBuilding].[BDBuildingPK] = @BDBuildingPK;", this.TableName);
			SqlParameter[] paras = new SqlParameter[1];
			paras[0] = new SqlParameter("@BDBuildingPK", SqlDbType.UniqueIdentifier);
			paras[0].Value = bDBuildingPK;
			return base.ExecuteNonQuery(sql, paras);
		}


	}
	public class ACPanelFunctionCardMapCRUD : DataAccessBase
	{
		private string _tableName = "ACPanelFunctionCardMap";

		public ACPanelFunctionCardMapCRUD(string connectionString) : base(connectionString)
		{
		}

		public virtual string TableName
		{
			get { return this._tableName; }
			set { this._tableName = value; }
		}

		public string SQLColumns
		{
			get
			{
				return "[ACPanelFunctionCardMap].[ACPanelFunctionCardMapPK] AS [ACPanelFunctionCardMapPK],[ACPanelFunctionCardMap].[ACPanelPK] AS [ACPanelPK],[ACPanelFunctionCardMap].[ACFunctionCardPK] AS [ACFunctionCardPK],[ACPanelFunctionCardMap].[RowVersion] AS [RowVersion],[ACPanelFunctionCardMap].[CreatedOn] AS [CreatedOn],[ACPanelFunctionCardMap].[CreatedBy] AS [CreatedBy],[ACPanelFunctionCardMap].[ModifiedOn] AS [ModifiedOn],[ACPanelFunctionCardMap].[ModifiedBy] AS [ModifiedBy],[ACFunctionCard].[CardTypeID] AS [CardTypeID],[ACFunctionCard].[Encoded] AS [Encoded],[ACFunctionCard].[Embossed] AS [Embossed],[ACFunctionCard].[Sitecode] AS [Sitecode],[ACPanel].[BDBuildingPK] AS [BDBuildingPK],[ACPanel].[UnitID] AS [UnitID],[BDBuilding].[Address1] AS [Address1],[BDBuilding].[BuildingID] AS [BuildingID]";
			}
		}

		public string SQLLeftJoins
		{
			get
			{
				return "LEFT JOIN [ACFunctionCard] [ACFunctionCard] ON [ACPanelFunctionCardMap].[ACFunctionCardPK] = [ACFunctionCard].[ACFunctionCardPK] LEFT JOIN [ACPanel] [ACPanel] ON [ACPanelFunctionCardMap].[ACPanelPK] = [ACPanel].[ACPanelPK] LEFT JOIN [BDBuilding] [BDBuilding] ON [ACPanel].[BDBuildingPK] = [BDBuilding].[BDBuildingPK]";
			}
		}

		protected override string SQLSelect
		{
			get
			{
				return string.Format("SELECT [ACPanelFunctionCardMap].[ACPanelFunctionCardMapPK] AS [ACPanelFunctionCardMapPK],[ACPanelFunctionCardMap].[ACPanelPK] AS [ACPanelPK],[ACPanelFunctionCardMap].[ACFunctionCardPK] AS [ACFunctionCardPK],[ACPanelFunctionCardMap].[RowVersion] AS [RowVersion],[ACPanelFunctionCardMap].[CreatedOn] AS [CreatedOn],[ACPanelFunctionCardMap].[CreatedBy] AS [CreatedBy],[ACPanelFunctionCardMap].[ModifiedOn] AS [ModifiedOn],[ACPanelFunctionCardMap].[ModifiedBy] AS [ModifiedBy],[ACFunctionCard].[CardTypeID] AS [CardTypeID],[ACFunctionCard].[Encoded] AS [Encoded],[ACFunctionCard].[Embossed] AS [Embossed],[ACFunctionCard].[Sitecode] AS [Sitecode],[ACPanel].[BDBuildingPK] AS [BDBuildingPK],[ACPanel].[UnitID] AS [UnitID],[BDBuilding].[Address1] AS [Address1],[BDBuilding].[BuildingID] AS [BuildingID] FROM [{0}] [ACPanelFunctionCardMap] LEFT JOIN [ACFunctionCard] [ACFunctionCard] ON [ACPanelFunctionCardMap].[ACFunctionCardPK] = [ACFunctionCard].[ACFunctionCardPK] LEFT JOIN [ACPanel] [ACPanel] ON [ACPanelFunctionCardMap].[ACPanelPK] = [ACPanel].[ACPanelPK] LEFT JOIN [BDBuilding] [BDBuilding] ON [ACPanel].[BDBuildingPK] = [BDBuilding].[BDBuildingPK]", this.TableName);
			}
		}

		protected override string SQLCount
		{
			get
			{
				return string.Format("SELECT COUNT(*) FROM [{0}] [ACPanelFunctionCardMap] LEFT JOIN [ACFunctionCard] [ACFunctionCard] ON [ACPanelFunctionCardMap].[ACFunctionCardPK] = [ACFunctionCard].[ACFunctionCardPK] LEFT JOIN [ACPanel] [ACPanel] ON [ACPanelFunctionCardMap].[ACPanelPK] = [ACPanel].[ACPanelPK] LEFT JOIN [BDBuilding] [BDBuilding] ON [ACPanel].[BDBuildingPK] = [BDBuilding].[BDBuildingPK]", this.TableName);
			}
		}

		public int Insert(ACPanelFunctionCardMapData entity)
		{
			string sql = string.Format("INSERT INTO [{0}] ([ACPanelFunctionCardMapPK],[ACPanelPK],[ACFunctionCardPK],[CreatedOn],[CreatedBy],[ModifiedOn],[ModifiedBy]) VALUES(@ACPanelFunctionCardMapPK,@ACPanelPK,@ACFunctionCardPK,@CreatedOn,@CreatedBy,@ModifiedOn,@ModifiedBy)", this.TableName);
			SqlParameter[] paras = new SqlParameter[7];
			paras[0] = new SqlParameter("@ACPanelFunctionCardMapPK", SqlDbType.UniqueIdentifier);
			if (entity.ACPanelFunctionCardMapPK == Guid.Empty)
			{
				paras[0].Value = DBNull.Value;
			}
			else
			{
				paras[0].Value = entity.ACPanelFunctionCardMapPK;
			}
			paras[1] = new SqlParameter("@ACPanelPK", SqlDbType.UniqueIdentifier);
			if (entity.ACPanelPK == Guid.Empty)
			{
				paras[1].Value = DBNull.Value;
			}
			else
			{
				paras[1].Value = entity.ACPanelPK;
			}
			paras[2] = new SqlParameter("@ACFunctionCardPK", SqlDbType.UniqueIdentifier);
			if (entity.ACFunctionCardPK == Guid.Empty)
			{
				paras[2].Value = DBNull.Value;
			}
			else
			{
				paras[2].Value = entity.ACFunctionCardPK;
			}
			paras[3] = new SqlParameter("@CreatedOn", SqlDbType.DateTime);
			paras[3].Value = entity.CreatedOn;
			paras[4] = new SqlParameter("@CreatedBy", SqlDbType.VarChar, 30);
			paras[4].Value = entity.CreatedBy;
			paras[5] = new SqlParameter("@ModifiedOn", SqlDbType.DateTime);
			paras[5].Value = entity.ModifiedOn;
			paras[6] = new SqlParameter("@ModifiedBy", SqlDbType.VarChar, 30);
			paras[6].Value = entity.ModifiedBy;
			return base.ExecuteNonQuery(sql, paras);
		}

		public int Update(ACPanelFunctionCardMapData entity)
		{
			string sql = string.Format("UPDATE [{0}] SET [ACPanelPK] = @ACPanelPK,[ACFunctionCardPK] = @ACFunctionCardPK,[CreatedOn] = @CreatedOn,[CreatedBy] = @CreatedBy,[ModifiedOn] = @ModifiedOn,[ModifiedBy] = @ModifiedBy  WHERE [ACPanelFunctionCardMapPK] = @ACPanelFunctionCardMapPK AND [RowVersion] = @RowVersion", this.TableName);
			SqlParameter[] paras = new SqlParameter[8];
			paras[0] = new SqlParameter("@ACPanelFunctionCardMapPK", SqlDbType.UniqueIdentifier);
			if (entity.ACPanelFunctionCardMapPK == Guid.Empty)
			{
				paras[0].Value = DBNull.Value;
			}
			else
			{
				paras[0].Value = entity.ACPanelFunctionCardMapPK;
			}
			paras[1] = new SqlParameter("@ACPanelPK", SqlDbType.UniqueIdentifier);
			if (entity.ACPanelPK == Guid.Empty)
			{
				paras[1].Value = DBNull.Value;
			}
			else
			{
				paras[1].Value = entity.ACPanelPK;
			}
			paras[2] = new SqlParameter("@ACFunctionCardPK", SqlDbType.UniqueIdentifier);
			if (entity.ACFunctionCardPK == Guid.Empty)
			{
				paras[2].Value = DBNull.Value;
			}
			else
			{
				paras[2].Value = entity.ACFunctionCardPK;
			}
			paras[3] = new SqlParameter("@RowVersion", SqlDbType.Timestamp);
			paras[3].Value = entity.RowVersion;
			paras[4] = new SqlParameter("@CreatedOn", SqlDbType.DateTime);
			paras[4].Value = entity.CreatedOn;
			paras[5] = new SqlParameter("@CreatedBy", SqlDbType.VarChar, 30);
			paras[5].Value = entity.CreatedBy;
			paras[6] = new SqlParameter("@ModifiedOn", SqlDbType.DateTime);
			paras[6].Value = entity.ModifiedOn;
			paras[7] = new SqlParameter("@ModifiedBy", SqlDbType.VarChar, 30);
			paras[7].Value = entity.ModifiedBy;
			return base.ExecuteNonQuery(sql, paras);
		}

		private ACPanelFunctionCardMapData CreateDataByReader(SafeDataReader reader)
		{
			ACPanelFunctionCardMapData data = new ACPanelFunctionCardMapData {
				ACPanelFunctionCardMapPK = (Guid) reader["ACPanelFunctionCardMapPK"],
				ACPanelPK = (Guid) reader["ACPanelPK"],
				ACFunctionCardPK = (Guid) reader["ACFunctionCardPK"],
				RowVersion = (Byte[]) reader["RowVersion"],
				CreatedOn = (DateTime) reader["CreatedOn"],
				CreatedBy = (String) reader["CreatedBy"],
				ModifiedOn = (DateTime) reader["ModifiedOn"],
				ModifiedBy = (String) reader["ModifiedBy"],
				CardTypeID = (Int32) reader["CardTypeID"],
				Encoded = (Int32) reader["Encoded"],
				Embossed = (Int32) reader["Embossed"],
				Sitecode = (Int32) reader["Sitecode"],
				BDBuildingPK = (Guid) reader["BDBuildingPK"],
				UnitID = (Int32) reader["UnitID"],
				Address1 = (String) reader["Address1"],
				BuildingID = (Int32) reader["BuildingID"]
			};
			data.AcceptChanges();
			return data;
		}

		private ACPanelFunctionCardMapData FetchEntity(string where, SqlParameter[] paras)
		{
			ACPanelFunctionCardMapData data = null;
			using (SafeDataReader reader = base.ExecuteDataReader(where, paras))
			{
				if (reader.Read())
				{
					data = this.CreateDataByReader(reader);
				}
				reader.Close();
			}
			return data;
		}

		private ACPanelFunctionCardMapData FetchEntityEx(string sql, SqlParameter[] paras)
		{
			ACPanelFunctionCardMapData data = null;
			using (SafeDataReader reader = base.ExecuteDataReaderEx(sql, paras))
			{
				if (reader.Read())
				{
					data = this.CreateDataByReader(reader);
				}
				reader.Close();
			}
			return data;
		}

		private ACPanelFunctionCardMapDataCollection FetchCollection(string where, SqlParameter[] paras)
		{
			ACPanelFunctionCardMapDataCollection list = new ACPanelFunctionCardMapDataCollection();
			using (SafeDataReader reader = base.ExecuteDataReader(where, paras))
			{
				while(reader.Read())
				{
					ACPanelFunctionCardMapData data = this.CreateDataByReader(reader);
					list.Add(data);
				}
				reader.Close();
			}
			return list;
		}

		private ACPanelFunctionCardMapDataCollection FetchCollectionEx(string sql, SqlParameter[] paras)
		{
			ACPanelFunctionCardMapDataCollection list = new ACPanelFunctionCardMapDataCollection();
			using (SafeDataReader reader = base.ExecuteDataReaderEx(sql, paras))
			{
				while(reader.Read())
				{
					ACPanelFunctionCardMapData data = this.CreateDataByReader(reader);
					list.Add(data);
				}
				reader.Close();
			}
			return list;
		}

		public ACPanelFunctionCardMapData GetEntityBy(string sqlWhere, SqlParameter[] paras)
		{
			return this.FetchEntity(sqlWhere, paras);
		}

		public ACPanelFunctionCardMapData GetEntityExBy(string sql, SqlParameter[] paras)
		{
			return this.FetchEntityEx(sql, paras);
		}

		public ACPanelFunctionCardMapDataCollection GetCollectionBy(string sqlWhere, SqlParameter[] paras)
		{
			return this.FetchCollection(sqlWhere, paras);
		}

		public ACPanelFunctionCardMapDataCollection GetCollectionExBy(string sql, SqlParameter[] paras)
		{
			return this.FetchCollectionEx(sql, paras);
		}

		public byte[] GetRowVersion( System.Guid ACPanelFunctionCardMapPK)
		{
			string sql = string.Format("SELECT [RowVersion] AS [RowVersion] FROM [{0}] WHERE  [ACPanelFunctionCardMapPK] = @ACPanelFunctionCardMapPK ", this.TableName);
			SqlParameter[] paras = new SqlParameter[1];
			paras[0] = new SqlParameter("@ACPanelFunctionCardMapPK", SqlDbType.UniqueIdentifier, 16);
			paras[0].Value = ACPanelFunctionCardMapPK;
			return (byte[]) base.ExecuteScalar(sql, paras);
		}

		public ACPanelFunctionCardMapData GetByPK( System.Guid ACPanelFunctionCardMapPK)
		{
			string sql = " WHERE  [ACPanelFunctionCardMap].[ACPanelFunctionCardMapPK] = @ACPanelFunctionCardMapPK ";
			SqlParameter[] paras = new SqlParameter[1];
			paras[0] = new SqlParameter("@ACPanelFunctionCardMapPK", SqlDbType.UniqueIdentifier);
			paras[0].Value = ACPanelFunctionCardMapPK;
			return this.FetchEntity(sql, paras);
		}

		public ACPanelFunctionCardMapDataCollection GetAll()
		{
			return this.FetchCollection("", null);
		}

		public ACPanelFunctionCardMapDataCollection GetByACFunctionCard(System.Guid ACFunctionCardPK)
		{
			string sqlWhere = " WHERE [ACPanelFunctionCardMap].[ACFunctionCardPK] = @ACFunctionCardPK";
			SqlParameter[] paras = new SqlParameter[1];
			paras[0] = new SqlParameter("@ACFunctionCardPK", SqlDbType.UniqueIdentifier);
			paras[0].Value = ACFunctionCardPK;
			return this.FetchCollection(sqlWhere, paras);
		}

		public ACPanelFunctionCardMapDataCollection GetByACPanel(System.Guid ACPanelPK)
		{
			string sqlWhere = " WHERE [ACPanelFunctionCardMap].[ACPanelPK] = @ACPanelPK";
			SqlParameter[] paras = new SqlParameter[1];
			paras[0] = new SqlParameter("@ACPanelPK", SqlDbType.UniqueIdentifier);
			paras[0].Value = ACPanelPK;
			return this.FetchCollection(sqlWhere, paras);
		}

		public DataTable GetLogByPK( System.Guid ACPanelFunctionCardMapPK)
		{
			string sql = string.Format("SELECT  [ACPanelFunctionCardMap].[ACPanelFunctionCardMapPK] AS [ACPanelFunctionCardMapPK], [ACPanelFunctionCardMap].[ModifiedOn] AS [ModifiedOn] FROM [{0}] WHERE  [ACPanelFunctionCardMap].[ACPanelFunctionCardMapPK] = @ACPanelFunctionCardMapPK ", this.TableName);
			SqlParameter[] paras = new SqlParameter[1];
			paras[0] = new SqlParameter("@ACPanelFunctionCardMapPK", SqlDbType.UniqueIdentifier);
			paras[0].Value = ACPanelFunctionCardMapPK;
			return this.ExecuteDataTable(sql, paras);
		}

		public DataTable GetLogByACFunctionCard(System.Guid aCFunctionCardPK)
		{
			string sql = string.Format("DELETE [{0}] FROM [{0}] [ACPanelFunctionCardMap] INNER JOIN [ACFunctionCard] ON [ACPanelFunctionCardMap].[ACFunctionCardPK] = [ACFunctionCard].[ACFunctionCardPK] WHERE [ACFunctionCard].[ACFunctionCardPK] = @ACFunctionCardPK;", this.TableName);
			string oldValue = string.Format("DELETE [{0}]", this.TableName);
			string newValue = "SELECT  [ACPanelFunctionCardMap].[ACPanelFunctionCardMapPK] AS [ACPanelFunctionCardMapPK], [ACPanelFunctionCardMap].[ModifiedOn] AS [ModifiedOn]";
			sql = sql.Replace(oldValue, newValue).TrimEnd().TrimEnd(';').Replace(";", " UNION ");
			SqlParameter[] paras = new SqlParameter[1];
			paras[0] = new SqlParameter("@ACFunctionCardPK", SqlDbType.UniqueIdentifier);
			paras[0].Value = aCFunctionCardPK;
			return base.ExecuteDataTable(sql, paras);
		}

		public DataTable GetLogByBDTenant(System.Guid bDTenantPK)
		{
			string sql = string.Format("DELETE [{0}] FROM [{0}] [ACPanelFunctionCardMap] INNER JOIN [ACFunctionCard] ON [ACPanelFunctionCardMap].[ACFunctionCardPK] = [ACFunctionCard].[ACFunctionCardPK] INNER JOIN [BDTenant] ON [ACFunctionCard].[BDTenantPK] = [BDTenant].[BDTenantPK] WHERE [BDTenant].[BDTenantPK] = @BDTenantPK;", this.TableName);
			string oldValue = string.Format("DELETE [{0}]", this.TableName);
			string newValue = "SELECT  [ACPanelFunctionCardMap].[ACPanelFunctionCardMapPK] AS [ACPanelFunctionCardMapPK], [ACPanelFunctionCardMap].[ModifiedOn] AS [ModifiedOn]";
			sql = sql.Replace(oldValue, newValue).TrimEnd().TrimEnd(';').Replace(";", " UNION ");
			SqlParameter[] paras = new SqlParameter[1];
			paras[0] = new SqlParameter("@BDTenantPK", SqlDbType.UniqueIdentifier);
			paras[0].Value = bDTenantPK;
			return base.ExecuteDataTable(sql, paras);
		}

		public DataTable GetLogByBDBuilding(System.Guid bDBuildingPK)
		{
			string sql = string.Format("DELETE [{0}] FROM [{0}] [ACPanelFunctionCardMap] INNER JOIN [ACFunctionCard] ON [ACPanelFunctionCardMap].[ACFunctionCardPK] = [ACFunctionCard].[ACFunctionCardPK] INNER JOIN [BDTenant] ON [ACFunctionCard].[BDTenantPK] = [BDTenant].[BDTenantPK] INNER JOIN [BDBuilding] ON [BDTenant].[BDBuildingPK] = [BDBuilding].[BDBuildingPK] WHERE [BDBuilding].[BDBuildingPK] = @BDBuildingPK;DELETE [{0}] FROM [{0}] [ACPanelFunctionCardMap] INNER JOIN [ACPanel] ON [ACPanelFunctionCardMap].[ACPanelPK] = [ACPanel].[ACPanelPK] INNER JOIN [BDBuilding] ON [ACPanel].[BDBuildingPK] = [BDBuilding].[BDBuildingPK] WHERE [BDBuilding].[BDBuildingPK] = @BDBuildingPK;", this.TableName);
			string oldValue = string.Format("DELETE [{0}]", this.TableName);
			string newValue = "SELECT  [ACPanelFunctionCardMap].[ACPanelFunctionCardMapPK] AS [ACPanelFunctionCardMapPK], [ACPanelFunctionCardMap].[ModifiedOn] AS [ModifiedOn]";
			sql = sql.Replace(oldValue, newValue).TrimEnd().TrimEnd(';').Replace(";", " UNION ");
			SqlParameter[] paras = new SqlParameter[1];
			paras[0] = new SqlParameter("@BDBuildingPK", SqlDbType.UniqueIdentifier);
			paras[0].Value = bDBuildingPK;
			return base.ExecuteDataTable(sql, paras);
		}

		public DataTable GetLogByACPanel(System.Guid aCPanelPK)
		{
			string sql = string.Format("DELETE [{0}] FROM [{0}] [ACPanelFunctionCardMap] INNER JOIN [ACPanel] ON [ACPanelFunctionCardMap].[ACPanelPK] = [ACPanel].[ACPanelPK] WHERE [ACPanel].[ACPanelPK] = @ACPanelPK;", this.TableName);
			string oldValue = string.Format("DELETE [{0}]", this.TableName);
			string newValue = "SELECT  [ACPanelFunctionCardMap].[ACPanelFunctionCardMapPK] AS [ACPanelFunctionCardMapPK], [ACPanelFunctionCardMap].[ModifiedOn] AS [ModifiedOn]";
			sql = sql.Replace(oldValue, newValue).TrimEnd().TrimEnd(';').Replace(";", " UNION ");
			SqlParameter[] paras = new SqlParameter[1];
			paras[0] = new SqlParameter("@ACPanelPK", SqlDbType.UniqueIdentifier);
			paras[0].Value = aCPanelPK;
			return base.ExecuteDataTable(sql, paras);
		}

		public int DeleteByPK( System.Guid ACPanelFunctionCardMapPK, byte[] RowVersion)
		{
			string sql = string.Format("DELETE FROM [{0}] WHERE  [ACPanelFunctionCardMapPK] = @ACPanelFunctionCardMapPK AND [RowVersion] = @RowVersion", this.TableName);
			SqlParameter[] paras = new SqlParameter[2];
			paras[0] = new SqlParameter("@ACPanelFunctionCardMapPK", SqlDbType.UniqueIdentifier);
			paras[0].Value = ACPanelFunctionCardMapPK;
			paras[1] = new SqlParameter("@RowVersion", SqlDbType.Timestamp, 8);
			paras[1].Value = RowVersion;
			return base.ExecuteNonQuery(sql, paras);
		}

		public int DeleteAll()
		{
			string sql = string.Format("DELETE FROM [{0}]", this.TableName);
			return base.ExecuteNonQuery(sql, null);
		}

		public int DeleteByACFunctionCard(System.Guid aCFunctionCardPK)
		{
			string sql = string.Format("DELETE [{0}] FROM [{0}] [ACPanelFunctionCardMap] INNER JOIN [ACFunctionCard] ON [ACPanelFunctionCardMap].[ACFunctionCardPK] = [ACFunctionCard].[ACFunctionCardPK] WHERE [ACFunctionCard].[ACFunctionCardPK] = @ACFunctionCardPK;", this.TableName);
			SqlParameter[] paras = new SqlParameter[1];
			paras[0] = new SqlParameter("@ACFunctionCardPK", SqlDbType.UniqueIdentifier);
			paras[0].Value = aCFunctionCardPK;
			return base.ExecuteNonQuery(sql, paras);
		}

		public int DeleteByBDTenant(System.Guid bDTenantPK)
		{
			string sql = string.Format("DELETE [{0}] FROM [{0}] [ACPanelFunctionCardMap] INNER JOIN [ACFunctionCard] ON [ACPanelFunctionCardMap].[ACFunctionCardPK] = [ACFunctionCard].[ACFunctionCardPK] INNER JOIN [BDTenant] ON [ACFunctionCard].[BDTenantPK] = [BDTenant].[BDTenantPK] WHERE [BDTenant].[BDTenantPK] = @BDTenantPK;", this.TableName);
			SqlParameter[] paras = new SqlParameter[1];
			paras[0] = new SqlParameter("@BDTenantPK", SqlDbType.UniqueIdentifier);
			paras[0].Value = bDTenantPK;
			return base.ExecuteNonQuery(sql, paras);
		}

		public int DeleteByBDBuilding(System.Guid bDBuildingPK)
		{
			string sql = string.Format("DELETE [{0}] FROM [{0}] [ACPanelFunctionCardMap] INNER JOIN [ACFunctionCard] ON [ACPanelFunctionCardMap].[ACFunctionCardPK] = [ACFunctionCard].[ACFunctionCardPK] INNER JOIN [BDTenant] ON [ACFunctionCard].[BDTenantPK] = [BDTenant].[BDTenantPK] INNER JOIN [BDBuilding] ON [BDTenant].[BDBuildingPK] = [BDBuilding].[BDBuildingPK] WHERE [BDBuilding].[BDBuildingPK] = @BDBuildingPK;DELETE [{0}] FROM [{0}] [ACPanelFunctionCardMap] INNER JOIN [ACPanel] ON [ACPanelFunctionCardMap].[ACPanelPK] = [ACPanel].[ACPanelPK] INNER JOIN [BDBuilding] ON [ACPanel].[BDBuildingPK] = [BDBuilding].[BDBuildingPK] WHERE [BDBuilding].[BDBuildingPK] = @BDBuildingPK;", this.TableName);
			SqlParameter[] paras = new SqlParameter[1];
			paras[0] = new SqlParameter("@BDBuildingPK", SqlDbType.UniqueIdentifier);
			paras[0].Value = bDBuildingPK;
			return base.ExecuteNonQuery(sql, paras);
		}

		public int DeleteByACPanel(System.Guid aCPanelPK)
		{
			string sql = string.Format("DELETE [{0}] FROM [{0}] [ACPanelFunctionCardMap] INNER JOIN [ACPanel] ON [ACPanelFunctionCardMap].[ACPanelPK] = [ACPanel].[ACPanelPK] WHERE [ACPanel].[ACPanelPK] = @ACPanelPK;", this.TableName);
			SqlParameter[] paras = new SqlParameter[1];
			paras[0] = new SqlParameter("@ACPanelPK", SqlDbType.UniqueIdentifier);
			paras[0].Value = aCPanelPK;
			return base.ExecuteNonQuery(sql, paras);
		}


	}
	public class LogDBDeleteActivityCRUD : DataAccessBase
	{
		private string _tableName = "LogDBDeleteActivity";

		public LogDBDeleteActivityCRUD(string connectionString) : base(connectionString)
		{
		}

		public virtual string TableName
		{
			get { return this._tableName; }
			set { this._tableName = value; }
		}

		public string SQLColumns
		{
			get
			{
				return "[LogDBDeleteActivity].[LogDBDeleteActivityPK] AS [LogDBDeleteActivityPK],[LogDBDeleteActivity].[LogDateTime] AS [LogDateTime],[LogDBDeleteActivity].[DBTableName] AS [DBTableName],[LogDBDeleteActivity].[RecordPK] AS [RecordPK],[LogDBDeleteActivity].[LastUpdated] AS [LastUpdated],[LogDBDeleteActivity].[RowVersion] AS [RowVersion],[LogDBDeleteActivity].[CreatedOn] AS [CreatedOn],[LogDBDeleteActivity].[CreatedBy] AS [CreatedBy],[LogDBDeleteActivity].[ModifiedOn] AS [ModifiedOn],[LogDBDeleteActivity].[ModifiedBy] AS [ModifiedBy]";
			}
		}

		public string SQLLeftJoins
		{
			get
			{
				return "";
			}
		}

		protected override string SQLSelect
		{
			get
			{
				return string.Format("SELECT [LogDBDeleteActivity].[LogDBDeleteActivityPK] AS [LogDBDeleteActivityPK],[LogDBDeleteActivity].[LogDateTime] AS [LogDateTime],[LogDBDeleteActivity].[DBTableName] AS [DBTableName],[LogDBDeleteActivity].[RecordPK] AS [RecordPK],[LogDBDeleteActivity].[LastUpdated] AS [LastUpdated],[LogDBDeleteActivity].[RowVersion] AS [RowVersion],[LogDBDeleteActivity].[CreatedOn] AS [CreatedOn],[LogDBDeleteActivity].[CreatedBy] AS [CreatedBy],[LogDBDeleteActivity].[ModifiedOn] AS [ModifiedOn],[LogDBDeleteActivity].[ModifiedBy] AS [ModifiedBy] FROM [{0}] [LogDBDeleteActivity] ", this.TableName);
			}
		}

		protected override string SQLCount
		{
			get
			{
				return string.Format("SELECT COUNT(*) FROM [{0}] [LogDBDeleteActivity] ", this.TableName);
			}
		}

		public int Insert(LogDBDeleteActivityData entity)
		{
			string sql = string.Format("INSERT INTO [{0}] ([LogDBDeleteActivityPK],[LogDateTime],[DBTableName],[RecordPK],[LastUpdated],[CreatedOn],[CreatedBy],[ModifiedOn],[ModifiedBy]) VALUES(@LogDBDeleteActivityPK,@LogDateTime,@DBTableName,@RecordPK,@LastUpdated,@CreatedOn,@CreatedBy,@ModifiedOn,@ModifiedBy)", this.TableName);
			SqlParameter[] paras = new SqlParameter[9];
			paras[0] = new SqlParameter("@LogDBDeleteActivityPK", SqlDbType.UniqueIdentifier);
			if (entity.LogDBDeleteActivityPK == Guid.Empty)
			{
				paras[0].Value = DBNull.Value;
			}
			else
			{
				paras[0].Value = entity.LogDBDeleteActivityPK;
			}
			paras[1] = new SqlParameter("@LogDateTime", SqlDbType.DateTime);
			paras[1].Value = entity.LogDateTime;
			paras[2] = new SqlParameter("@DBTableName", SqlDbType.VarChar, 128);
			paras[2].Value = entity.DBTableName;
			paras[3] = new SqlParameter("@RecordPK", SqlDbType.UniqueIdentifier);
			if (entity.RecordPK == Guid.Empty)
			{
				paras[3].Value = DBNull.Value;
			}
			else
			{
				paras[3].Value = entity.RecordPK;
			}
			paras[4] = new SqlParameter("@LastUpdated", SqlDbType.DateTime);
			paras[4].Value = entity.LastUpdated;
			paras[5] = new SqlParameter("@CreatedOn", SqlDbType.DateTime);
			paras[5].Value = entity.CreatedOn;
			paras[6] = new SqlParameter("@CreatedBy", SqlDbType.VarChar, 30);
			paras[6].Value = entity.CreatedBy;
			paras[7] = new SqlParameter("@ModifiedOn", SqlDbType.DateTime);
			paras[7].Value = entity.ModifiedOn;
			paras[8] = new SqlParameter("@ModifiedBy", SqlDbType.VarChar, 30);
			paras[8].Value = entity.ModifiedBy;
			return base.ExecuteNonQuery(sql, paras);
		}

		public int Update(LogDBDeleteActivityData entity)
		{
			string sql = string.Format("UPDATE [{0}] SET [LogDateTime] = @LogDateTime,[DBTableName] = @DBTableName,[RecordPK] = @RecordPK,[LastUpdated] = @LastUpdated,[CreatedOn] = @CreatedOn,[CreatedBy] = @CreatedBy,[ModifiedOn] = @ModifiedOn,[ModifiedBy] = @ModifiedBy  WHERE [LogDBDeleteActivityPK] = @LogDBDeleteActivityPK AND [RowVersion] = @RowVersion", this.TableName);
			SqlParameter[] paras = new SqlParameter[10];
			paras[0] = new SqlParameter("@LogDBDeleteActivityPK", SqlDbType.UniqueIdentifier);
			if (entity.LogDBDeleteActivityPK == Guid.Empty)
			{
				paras[0].Value = DBNull.Value;
			}
			else
			{
				paras[0].Value = entity.LogDBDeleteActivityPK;
			}
			paras[1] = new SqlParameter("@LogDateTime", SqlDbType.DateTime);
			paras[1].Value = entity.LogDateTime;
			paras[2] = new SqlParameter("@DBTableName", SqlDbType.VarChar, 128);
			paras[2].Value = entity.DBTableName;
			paras[3] = new SqlParameter("@RecordPK", SqlDbType.UniqueIdentifier);
			if (entity.RecordPK == Guid.Empty)
			{
				paras[3].Value = DBNull.Value;
			}
			else
			{
				paras[3].Value = entity.RecordPK;
			}
			paras[4] = new SqlParameter("@LastUpdated", SqlDbType.DateTime);
			paras[4].Value = entity.LastUpdated;
			paras[5] = new SqlParameter("@RowVersion", SqlDbType.Timestamp);
			paras[5].Value = entity.RowVersion;
			paras[6] = new SqlParameter("@CreatedOn", SqlDbType.DateTime);
			paras[6].Value = entity.CreatedOn;
			paras[7] = new SqlParameter("@CreatedBy", SqlDbType.VarChar, 30);
			paras[7].Value = entity.CreatedBy;
			paras[8] = new SqlParameter("@ModifiedOn", SqlDbType.DateTime);
			paras[8].Value = entity.ModifiedOn;
			paras[9] = new SqlParameter("@ModifiedBy", SqlDbType.VarChar, 30);
			paras[9].Value = entity.ModifiedBy;
			return base.ExecuteNonQuery(sql, paras);
		}

		private LogDBDeleteActivityData CreateDataByReader(SafeDataReader reader)
		{
			LogDBDeleteActivityData data = new LogDBDeleteActivityData {
				LogDBDeleteActivityPK = (Guid) reader["LogDBDeleteActivityPK"],
				LogDateTime = (DateTime) reader["LogDateTime"],
				DBTableName = (String) reader["DBTableName"],
				RecordPK = (Guid) reader["RecordPK"],
				LastUpdated = (DateTime) reader["LastUpdated"],
				RowVersion = (Byte[]) reader["RowVersion"],
				CreatedOn = (DateTime) reader["CreatedOn"],
				CreatedBy = (String) reader["CreatedBy"],
				ModifiedOn = (DateTime) reader["ModifiedOn"],
				ModifiedBy = (String) reader["ModifiedBy"]
			};
			data.AcceptChanges();
			return data;
		}

		private LogDBDeleteActivityData FetchEntity(string where, SqlParameter[] paras)
		{
			LogDBDeleteActivityData data = null;
			using (SafeDataReader reader = base.ExecuteDataReader(where, paras))
			{
				if (reader.Read())
				{
					data = this.CreateDataByReader(reader);
				}
				reader.Close();
			}
			return data;
		}

		private LogDBDeleteActivityData FetchEntityEx(string sql, SqlParameter[] paras)
		{
			LogDBDeleteActivityData data = null;
			using (SafeDataReader reader = base.ExecuteDataReaderEx(sql, paras))
			{
				if (reader.Read())
				{
					data = this.CreateDataByReader(reader);
				}
				reader.Close();
			}
			return data;
		}

		private LogDBDeleteActivityDataCollection FetchCollection(string where, SqlParameter[] paras)
		{
			LogDBDeleteActivityDataCollection list = new LogDBDeleteActivityDataCollection();
			using (SafeDataReader reader = base.ExecuteDataReader(where, paras))
			{
				while(reader.Read())
				{
					LogDBDeleteActivityData data = this.CreateDataByReader(reader);
					list.Add(data);
				}
				reader.Close();
			}
			return list;
		}

		private LogDBDeleteActivityDataCollection FetchCollectionEx(string sql, SqlParameter[] paras)
		{
			LogDBDeleteActivityDataCollection list = new LogDBDeleteActivityDataCollection();
			using (SafeDataReader reader = base.ExecuteDataReaderEx(sql, paras))
			{
				while(reader.Read())
				{
					LogDBDeleteActivityData data = this.CreateDataByReader(reader);
					list.Add(data);
				}
				reader.Close();
			}
			return list;
		}

		public LogDBDeleteActivityData GetEntityBy(string sqlWhere, SqlParameter[] paras)
		{
			return this.FetchEntity(sqlWhere, paras);
		}

		public LogDBDeleteActivityData GetEntityExBy(string sql, SqlParameter[] paras)
		{
			return this.FetchEntityEx(sql, paras);
		}

		public LogDBDeleteActivityDataCollection GetCollectionBy(string sqlWhere, SqlParameter[] paras)
		{
			return this.FetchCollection(sqlWhere, paras);
		}

		public LogDBDeleteActivityDataCollection GetCollectionExBy(string sql, SqlParameter[] paras)
		{
			return this.FetchCollectionEx(sql, paras);
		}

		public byte[] GetRowVersion( System.Guid LogDBDeleteActivityPK)
		{
			string sql = string.Format("SELECT [RowVersion] AS [RowVersion] FROM [{0}] WHERE  [LogDBDeleteActivityPK] = @LogDBDeleteActivityPK ", this.TableName);
			SqlParameter[] paras = new SqlParameter[1];
			paras[0] = new SqlParameter("@LogDBDeleteActivityPK", SqlDbType.UniqueIdentifier, 16);
			paras[0].Value = LogDBDeleteActivityPK;
			return (byte[]) base.ExecuteScalar(sql, paras);
		}

		public LogDBDeleteActivityData GetByPK( System.Guid LogDBDeleteActivityPK)
		{
			string sql = " WHERE  [LogDBDeleteActivity].[LogDBDeleteActivityPK] = @LogDBDeleteActivityPK ";
			SqlParameter[] paras = new SqlParameter[1];
			paras[0] = new SqlParameter("@LogDBDeleteActivityPK", SqlDbType.UniqueIdentifier);
			paras[0].Value = LogDBDeleteActivityPK;
			return this.FetchEntity(sql, paras);
		}

		public LogDBDeleteActivityDataCollection GetAll()
		{
			return this.FetchCollection("", null);
		}

		public DataTable GetLogByPK( System.Guid LogDBDeleteActivityPK)
		{
			string sql = string.Format("SELECT  [LogDBDeleteActivity].[LogDBDeleteActivityPK] AS [LogDBDeleteActivityPK], [LogDBDeleteActivity].[ModifiedOn] AS [ModifiedOn] FROM [{0}] WHERE  [LogDBDeleteActivity].[LogDBDeleteActivityPK] = @LogDBDeleteActivityPK ", this.TableName);
			SqlParameter[] paras = new SqlParameter[1];
			paras[0] = new SqlParameter("@LogDBDeleteActivityPK", SqlDbType.UniqueIdentifier);
			paras[0].Value = LogDBDeleteActivityPK;
			return this.ExecuteDataTable(sql, paras);
		}

		public int DeleteByPK( System.Guid LogDBDeleteActivityPK, byte[] RowVersion)
		{
			string sql = string.Format("DELETE FROM [{0}] WHERE  [LogDBDeleteActivityPK] = @LogDBDeleteActivityPK AND [RowVersion] = @RowVersion", this.TableName);
			SqlParameter[] paras = new SqlParameter[2];
			paras[0] = new SqlParameter("@LogDBDeleteActivityPK", SqlDbType.UniqueIdentifier);
			paras[0].Value = LogDBDeleteActivityPK;
			paras[1] = new SqlParameter("@RowVersion", SqlDbType.Timestamp, 8);
			paras[1].Value = RowVersion;
			return base.ExecuteNonQuery(sql, paras);
		}

		public int DeleteAll()
		{
			string sql = string.Format("DELETE FROM [{0}]", this.TableName);
			return base.ExecuteNonQuery(sql, null);
		}


	}
	public class UsrAccountCRUD : DataAccessBase
	{
		private string _tableName = "UsrAccount";

		public UsrAccountCRUD(string connectionString) : base(connectionString)
		{
		}

		public virtual string TableName
		{
			get { return this._tableName; }
			set { this._tableName = value; }
		}

		public string SQLColumns
		{
			get
			{
				return "[UsrAccount].[UsrAccountPK] AS [UsrAccountPK],[UsrAccount].[UserID] AS [UserID],[UsrAccount].[IsAdmin] AS [IsAdmin],[UsrAccount].[IsCentral] AS [IsCentral],[UsrAccount].[FirstName] AS [FirstName],[UsrAccount].[LastName] AS [LastName],[UsrAccount].[Password] AS [Password],[UsrAccount].[PwdExpireDate] AS [PwdExpireDate],[UsrAccount].[UsrGroupPK] AS [UsrGroupPK],[UsrAccount].[BDTenantPK] AS [BDTenantPK],[UsrAccount].[CellPhone] AS [CellPhone],[UsrAccount].[HomePhone] AS [HomePhone],[UsrAccount].[OfficePhone] AS [OfficePhone],[UsrAccount].[Email] AS [Email],[UsrAccount].[LastLogin] AS [LastLogin],[UsrAccount].[TotalUsage] AS [TotalUsage],[UsrAccount].[StartScreen] AS [StartScreen],[UsrAccount].[PopupExtension] AS [PopupExtension],[UsrAccount].[RowVersion] AS [RowVersion],[UsrAccount].[CreatedOn] AS [CreatedOn],[UsrAccount].[CreatedBy] AS [CreatedBy],[UsrAccount].[ModifiedOn] AS [ModifiedOn],[UsrAccount].[ModifiedBy] AS [ModifiedBy],[BDTenant].[Suite] AS [Suite],[BDTenant].[Tenant] AS [Tenant],[BDTenant].[BDBuildingPK] AS [BDBuildingPK],[UsrGroup].[UsrGroupName] AS [UsrGroupName],[BDBuilding].[Address1] AS [Address1],[BDBuilding].[BuildingID] AS [BuildingID]";
			}
		}

		public string SQLLeftJoins
		{
			get
			{
				return "LEFT JOIN [BDTenant] [BDTenant] ON [UsrAccount].[BDTenantPK] = [BDTenant].[BDTenantPK] LEFT JOIN [UsrGroup] [UsrGroup] ON [UsrAccount].[UsrGroupPK] = [UsrGroup].[UsrGroupPK] LEFT JOIN [BDBuilding] [BDBuilding] ON [BDTenant].[BDBuildingPK] = [BDBuilding].[BDBuildingPK]";
			}
		}

		protected override string SQLSelect
		{
			get
			{
				return string.Format("SELECT [UsrAccount].[UsrAccountPK] AS [UsrAccountPK],[UsrAccount].[UserID] AS [UserID],[UsrAccount].[IsAdmin] AS [IsAdmin],[UsrAccount].[IsCentral] AS [IsCentral],[UsrAccount].[FirstName] AS [FirstName],[UsrAccount].[LastName] AS [LastName],[UsrAccount].[Password] AS [Password],[UsrAccount].[PwdExpireDate] AS [PwdExpireDate],[UsrAccount].[UsrGroupPK] AS [UsrGroupPK],[UsrAccount].[BDTenantPK] AS [BDTenantPK],[UsrAccount].[CellPhone] AS [CellPhone],[UsrAccount].[HomePhone] AS [HomePhone],[UsrAccount].[OfficePhone] AS [OfficePhone],[UsrAccount].[Email] AS [Email],[UsrAccount].[LastLogin] AS [LastLogin],[UsrAccount].[TotalUsage] AS [TotalUsage],[UsrAccount].[StartScreen] AS [StartScreen],[UsrAccount].[PopupExtension] AS [PopupExtension],[UsrAccount].[RowVersion] AS [RowVersion],[UsrAccount].[CreatedOn] AS [CreatedOn],[UsrAccount].[CreatedBy] AS [CreatedBy],[UsrAccount].[ModifiedOn] AS [ModifiedOn],[UsrAccount].[ModifiedBy] AS [ModifiedBy],[BDTenant].[Suite] AS [Suite],[BDTenant].[Tenant] AS [Tenant],[BDTenant].[BDBuildingPK] AS [BDBuildingPK],[UsrGroup].[UsrGroupName] AS [UsrGroupName],[BDBuilding].[Address1] AS [Address1],[BDBuilding].[BuildingID] AS [BuildingID] FROM [{0}] [UsrAccount] LEFT JOIN [BDTenant] [BDTenant] ON [UsrAccount].[BDTenantPK] = [BDTenant].[BDTenantPK] LEFT JOIN [UsrGroup] [UsrGroup] ON [UsrAccount].[UsrGroupPK] = [UsrGroup].[UsrGroupPK] LEFT JOIN [BDBuilding] [BDBuilding] ON [BDTenant].[BDBuildingPK] = [BDBuilding].[BDBuildingPK]", this.TableName);
			}
		}

		protected override string SQLCount
		{
			get
			{
				return string.Format("SELECT COUNT(*) FROM [{0}] [UsrAccount] LEFT JOIN [BDTenant] [BDTenant] ON [UsrAccount].[BDTenantPK] = [BDTenant].[BDTenantPK] LEFT JOIN [UsrGroup] [UsrGroup] ON [UsrAccount].[UsrGroupPK] = [UsrGroup].[UsrGroupPK] LEFT JOIN [BDBuilding] [BDBuilding] ON [BDTenant].[BDBuildingPK] = [BDBuilding].[BDBuildingPK]", this.TableName);
			}
		}

		public int Insert(UsrAccountData entity)
		{
			string sql = string.Format("INSERT INTO [{0}] ([UsrAccountPK],[UserID],[IsAdmin],[IsCentral],[FirstName],[LastName],[Password],[PwdExpireDate],[UsrGroupPK],[BDTenantPK],[CellPhone],[HomePhone],[OfficePhone],[Email],[LastLogin],[TotalUsage],[StartScreen],[PopupExtension],[CreatedOn],[CreatedBy],[ModifiedOn],[ModifiedBy]) VALUES(@UsrAccountPK,@UserID,@IsAdmin,@IsCentral,@FirstName,@LastName,@Password,@PwdExpireDate,@UsrGroupPK,@BDTenantPK,@CellPhone,@HomePhone,@OfficePhone,@Email,@LastLogin,@TotalUsage,@StartScreen,@PopupExtension,@CreatedOn,@CreatedBy,@ModifiedOn,@ModifiedBy)", this.TableName);
			SqlParameter[] paras = new SqlParameter[22];
			paras[0] = new SqlParameter("@UsrAccountPK", SqlDbType.UniqueIdentifier);
			if (entity.UsrAccountPK == Guid.Empty)
			{
				paras[0].Value = DBNull.Value;
			}
			else
			{
				paras[0].Value = entity.UsrAccountPK;
			}
			paras[1] = new SqlParameter("@UserID", SqlDbType.VarChar, 30);
			paras[1].Value = entity.UserID;
			paras[2] = new SqlParameter("@IsAdmin", SqlDbType.Bit);
			paras[2].Value = entity.IsAdmin;
			paras[3] = new SqlParameter("@IsCentral", SqlDbType.Bit);
			paras[3].Value = entity.IsCentral;
			paras[4] = new SqlParameter("@FirstName", SqlDbType.VarChar, 30);
			paras[4].Value = entity.FirstName;
			paras[5] = new SqlParameter("@LastName", SqlDbType.VarChar, 50);
			paras[5].Value = entity.LastName;
			paras[6] = new SqlParameter("@Password", SqlDbType.VarChar, 30);
			paras[6].Value = entity.Password;
			paras[7] = new SqlParameter("@PwdExpireDate", SqlDbType.DateTime);
			paras[7].Value = entity.PwdExpireDate;
			paras[8] = new SqlParameter("@UsrGroupPK", SqlDbType.UniqueIdentifier);
			if (entity.UsrGroupPK == Guid.Empty)
			{
				paras[8].Value = DBNull.Value;
			}
			else
			{
				paras[8].Value = entity.UsrGroupPK;
			}
			paras[9] = new SqlParameter("@BDTenantPK", SqlDbType.UniqueIdentifier);
			if (entity.BDTenantPK == Guid.Empty)
			{
				paras[9].Value = DBNull.Value;
			}
			else
			{
				paras[9].Value = entity.BDTenantPK;
			}
			paras[10] = new SqlParameter("@CellPhone", SqlDbType.VarChar, 20);
			paras[10].Value = entity.CellPhone;
			paras[11] = new SqlParameter("@HomePhone", SqlDbType.VarChar, 20);
			paras[11].Value = entity.HomePhone;
			paras[12] = new SqlParameter("@OfficePhone", SqlDbType.VarChar, 20);
			paras[12].Value = entity.OfficePhone;
			paras[13] = new SqlParameter("@Email", SqlDbType.VarChar, 50);
			paras[13].Value = entity.Email;
			paras[14] = new SqlParameter("@LastLogin", SqlDbType.DateTime);
			paras[14].Value = entity.LastLogin;
			paras[15] = new SqlParameter("@TotalUsage", SqlDbType.Int);
			paras[15].Value = entity.TotalUsage;
			paras[16] = new SqlParameter("@StartScreen", SqlDbType.VarChar, 512);
			paras[16].Value = entity.StartScreen;
			paras[17] = new SqlParameter("@PopupExtension", SqlDbType.Int);
			paras[17].Value = entity.PopupExtension;
			paras[18] = new SqlParameter("@CreatedOn", SqlDbType.DateTime);
			paras[18].Value = entity.CreatedOn;
			paras[19] = new SqlParameter("@CreatedBy", SqlDbType.VarChar, 30);
			paras[19].Value = entity.CreatedBy;
			paras[20] = new SqlParameter("@ModifiedOn", SqlDbType.DateTime);
			paras[20].Value = entity.ModifiedOn;
			paras[21] = new SqlParameter("@ModifiedBy", SqlDbType.VarChar, 30);
			paras[21].Value = entity.ModifiedBy;
			return base.ExecuteNonQuery(sql, paras);
		}

		public int Update(UsrAccountData entity)
		{
			string sql = string.Format("UPDATE [{0}] SET [UserID] = @UserID,[IsAdmin] = @IsAdmin,[IsCentral] = @IsCentral,[FirstName] = @FirstName,[LastName] = @LastName,[Password] = @Password,[PwdExpireDate] = @PwdExpireDate,[UsrGroupPK] = @UsrGroupPK,[BDTenantPK] = @BDTenantPK,[CellPhone] = @CellPhone,[HomePhone] = @HomePhone,[OfficePhone] = @OfficePhone,[Email] = @Email,[LastLogin] = @LastLogin,[TotalUsage] = @TotalUsage,[StartScreen] = @StartScreen,[PopupExtension] = @PopupExtension,[CreatedOn] = @CreatedOn,[CreatedBy] = @CreatedBy,[ModifiedOn] = @ModifiedOn,[ModifiedBy] = @ModifiedBy  WHERE [UsrAccountPK] = @UsrAccountPK AND [RowVersion] = @RowVersion", this.TableName);
			SqlParameter[] paras = new SqlParameter[23];
			paras[0] = new SqlParameter("@UsrAccountPK", SqlDbType.UniqueIdentifier);
			if (entity.UsrAccountPK == Guid.Empty)
			{
				paras[0].Value = DBNull.Value;
			}
			else
			{
				paras[0].Value = entity.UsrAccountPK;
			}
			paras[1] = new SqlParameter("@UserID", SqlDbType.VarChar, 30);
			paras[1].Value = entity.UserID;
			paras[2] = new SqlParameter("@IsAdmin", SqlDbType.Bit);
			paras[2].Value = entity.IsAdmin;
			paras[3] = new SqlParameter("@IsCentral", SqlDbType.Bit);
			paras[3].Value = entity.IsCentral;
			paras[4] = new SqlParameter("@FirstName", SqlDbType.VarChar, 30);
			paras[4].Value = entity.FirstName;
			paras[5] = new SqlParameter("@LastName", SqlDbType.VarChar, 50);
			paras[5].Value = entity.LastName;
			paras[6] = new SqlParameter("@Password", SqlDbType.VarChar, 30);
			paras[6].Value = entity.Password;
			paras[7] = new SqlParameter("@PwdExpireDate", SqlDbType.DateTime);
			paras[7].Value = entity.PwdExpireDate;
			paras[8] = new SqlParameter("@UsrGroupPK", SqlDbType.UniqueIdentifier);
			if (entity.UsrGroupPK == Guid.Empty)
			{
				paras[8].Value = DBNull.Value;
			}
			else
			{
				paras[8].Value = entity.UsrGroupPK;
			}
			paras[9] = new SqlParameter("@BDTenantPK", SqlDbType.UniqueIdentifier);
			if (entity.BDTenantPK == Guid.Empty)
			{
				paras[9].Value = DBNull.Value;
			}
			else
			{
				paras[9].Value = entity.BDTenantPK;
			}
			paras[10] = new SqlParameter("@CellPhone", SqlDbType.VarChar, 20);
			paras[10].Value = entity.CellPhone;
			paras[11] = new SqlParameter("@HomePhone", SqlDbType.VarChar, 20);
			paras[11].Value = entity.HomePhone;
			paras[12] = new SqlParameter("@OfficePhone", SqlDbType.VarChar, 20);
			paras[12].Value = entity.OfficePhone;
			paras[13] = new SqlParameter("@Email", SqlDbType.VarChar, 50);
			paras[13].Value = entity.Email;
			paras[14] = new SqlParameter("@LastLogin", SqlDbType.DateTime);
			paras[14].Value = entity.LastLogin;
			paras[15] = new SqlParameter("@TotalUsage", SqlDbType.Int);
			paras[15].Value = entity.TotalUsage;
			paras[16] = new SqlParameter("@StartScreen", SqlDbType.VarChar, 512);
			paras[16].Value = entity.StartScreen;
			paras[17] = new SqlParameter("@PopupExtension", SqlDbType.Int);
			paras[17].Value = entity.PopupExtension;
			paras[18] = new SqlParameter("@RowVersion", SqlDbType.Timestamp);
			paras[18].Value = entity.RowVersion;
			paras[19] = new SqlParameter("@CreatedOn", SqlDbType.DateTime);
			paras[19].Value = entity.CreatedOn;
			paras[20] = new SqlParameter("@CreatedBy", SqlDbType.VarChar, 30);
			paras[20].Value = entity.CreatedBy;
			paras[21] = new SqlParameter("@ModifiedOn", SqlDbType.DateTime);
			paras[21].Value = entity.ModifiedOn;
			paras[22] = new SqlParameter("@ModifiedBy", SqlDbType.VarChar, 30);
			paras[22].Value = entity.ModifiedBy;
			return base.ExecuteNonQuery(sql, paras);
		}

		private UsrAccountData CreateDataByReader(SafeDataReader reader)
		{
			UsrAccountData data = new UsrAccountData {
				UsrAccountPK = (Guid) reader["UsrAccountPK"],
				UserID = (String) reader["UserID"],
				IsAdmin = (Boolean) reader["IsAdmin"],
				IsCentral = (Boolean) reader["IsCentral"],
				FirstName = (String) reader["FirstName"],
				LastName = (String) reader["LastName"],
				Password = (String) reader["Password"],
				PwdExpireDate = (DateTime) reader["PwdExpireDate"],
				UsrGroupPK = (Guid) reader["UsrGroupPK"],
				BDTenantPK = (Guid) reader["BDTenantPK"],
				CellPhone = (String) reader["CellPhone"],
				HomePhone = (String) reader["HomePhone"],
				OfficePhone = (String) reader["OfficePhone"],
				Email = (String) reader["Email"],
				LastLogin = (DateTime) reader["LastLogin"],
				TotalUsage = (Int32) reader["TotalUsage"],
				StartScreen = (String) reader["StartScreen"],
				PopupExtension = (Int32) reader["PopupExtension"],
				RowVersion = (Byte[]) reader["RowVersion"],
				CreatedOn = (DateTime) reader["CreatedOn"],
				CreatedBy = (String) reader["CreatedBy"],
				ModifiedOn = (DateTime) reader["ModifiedOn"],
				ModifiedBy = (String) reader["ModifiedBy"],
				Suite = (String) reader["Suite"],
				Tenant = (String) reader["Tenant"],
				BDBuildingPK = (Guid) reader["BDBuildingPK"],
				UsrGroupName = (String) reader["UsrGroupName"],
				Address1 = (String) reader["Address1"],
				BuildingID = (Int32) reader["BuildingID"]
			};
			data.AcceptChanges();
			return data;
		}

		private UsrAccountData FetchEntity(string where, SqlParameter[] paras)
		{
			UsrAccountData data = null;
			using (SafeDataReader reader = base.ExecuteDataReader(where, paras))
			{
				if (reader.Read())
				{
					data = this.CreateDataByReader(reader);
				}
				reader.Close();
			}
			return data;
		}

		private UsrAccountData FetchEntityEx(string sql, SqlParameter[] paras)
		{
			UsrAccountData data = null;
			using (SafeDataReader reader = base.ExecuteDataReaderEx(sql, paras))
			{
				if (reader.Read())
				{
					data = this.CreateDataByReader(reader);
				}
				reader.Close();
			}
			return data;
		}

		private UsrAccountDataCollection FetchCollection(string where, SqlParameter[] paras)
		{
			UsrAccountDataCollection list = new UsrAccountDataCollection();
			using (SafeDataReader reader = base.ExecuteDataReader(where, paras))
			{
				while(reader.Read())
				{
					UsrAccountData data = this.CreateDataByReader(reader);
					list.Add(data);
				}
				reader.Close();
			}
			return list;
		}

		private UsrAccountDataCollection FetchCollectionEx(string sql, SqlParameter[] paras)
		{
			UsrAccountDataCollection list = new UsrAccountDataCollection();
			using (SafeDataReader reader = base.ExecuteDataReaderEx(sql, paras))
			{
				while(reader.Read())
				{
					UsrAccountData data = this.CreateDataByReader(reader);
					list.Add(data);
				}
				reader.Close();
			}
			return list;
		}

		public UsrAccountData GetEntityBy(string sqlWhere, SqlParameter[] paras)
		{
			return this.FetchEntity(sqlWhere, paras);
		}

		public UsrAccountData GetEntityExBy(string sql, SqlParameter[] paras)
		{
			return this.FetchEntityEx(sql, paras);
		}

		public UsrAccountDataCollection GetCollectionBy(string sqlWhere, SqlParameter[] paras)
		{
			return this.FetchCollection(sqlWhere, paras);
		}

		public UsrAccountDataCollection GetCollectionExBy(string sql, SqlParameter[] paras)
		{
			return this.FetchCollectionEx(sql, paras);
		}

		public byte[] GetRowVersion( System.Guid UsrAccountPK)
		{
			string sql = string.Format("SELECT [RowVersion] AS [RowVersion] FROM [{0}] WHERE  [UsrAccountPK] = @UsrAccountPK ", this.TableName);
			SqlParameter[] paras = new SqlParameter[1];
			paras[0] = new SqlParameter("@UsrAccountPK", SqlDbType.UniqueIdentifier, 16);
			paras[0].Value = UsrAccountPK;
			return (byte[]) base.ExecuteScalar(sql, paras);
		}

		public UsrAccountData GetByPK( System.Guid UsrAccountPK)
		{
			string sql = " WHERE  [UsrAccount].[UsrAccountPK] = @UsrAccountPK ";
			SqlParameter[] paras = new SqlParameter[1];
			paras[0] = new SqlParameter("@UsrAccountPK", SqlDbType.UniqueIdentifier);
			paras[0].Value = UsrAccountPK;
			return this.FetchEntity(sql, paras);
		}

		public UsrAccountDataCollection GetAll()
		{
			return this.FetchCollection("", null);
		}

		public UsrAccountDataCollection GetByBDTenant(System.Guid BDTenantPK)
		{
			string sqlWhere = " WHERE [UsrAccount].[BDTenantPK] = @BDTenantPK";
			SqlParameter[] paras = new SqlParameter[1];
			paras[0] = new SqlParameter("@BDTenantPK", SqlDbType.UniqueIdentifier);
			paras[0].Value = BDTenantPK;
			return this.FetchCollection(sqlWhere, paras);
		}

		public UsrAccountDataCollection GetByUsrGroup(System.Guid UsrGroupPK)
		{
			string sqlWhere = " WHERE [UsrAccount].[UsrGroupPK] = @UsrGroupPK";
			SqlParameter[] paras = new SqlParameter[1];
			paras[0] = new SqlParameter("@UsrGroupPK", SqlDbType.UniqueIdentifier);
			paras[0].Value = UsrGroupPK;
			return this.FetchCollection(sqlWhere, paras);
		}

		public DataTable GetLogByPK( System.Guid UsrAccountPK)
		{
			string sql = string.Format("SELECT  [UsrAccount].[UsrAccountPK] AS [UsrAccountPK], [UsrAccount].[ModifiedOn] AS [ModifiedOn] FROM [{0}] WHERE  [UsrAccount].[UsrAccountPK] = @UsrAccountPK ", this.TableName);
			SqlParameter[] paras = new SqlParameter[1];
			paras[0] = new SqlParameter("@UsrAccountPK", SqlDbType.UniqueIdentifier);
			paras[0].Value = UsrAccountPK;
			return this.ExecuteDataTable(sql, paras);
		}

		public DataTable GetLogByBDTenant(System.Guid bDTenantPK)
		{
			string sql = string.Format("DELETE [{0}] FROM [{0}] [UsrAccount] INNER JOIN [BDTenant] ON [UsrAccount].[BDTenantPK] = [BDTenant].[BDTenantPK] WHERE [BDTenant].[BDTenantPK] = @BDTenantPK;", this.TableName);
			string oldValue = string.Format("DELETE [{0}]", this.TableName);
			string newValue = "SELECT  [UsrAccount].[UsrAccountPK] AS [UsrAccountPK], [UsrAccount].[ModifiedOn] AS [ModifiedOn]";
			sql = sql.Replace(oldValue, newValue).TrimEnd().TrimEnd(';').Replace(";", " UNION ");
			SqlParameter[] paras = new SqlParameter[1];
			paras[0] = new SqlParameter("@BDTenantPK", SqlDbType.UniqueIdentifier);
			paras[0].Value = bDTenantPK;
			return base.ExecuteDataTable(sql, paras);
		}

		public DataTable GetLogByBDBuilding(System.Guid bDBuildingPK)
		{
			string sql = string.Format("DELETE [{0}] FROM [{0}] [UsrAccount] INNER JOIN [BDTenant] ON [UsrAccount].[BDTenantPK] = [BDTenant].[BDTenantPK] INNER JOIN [BDBuilding] ON [BDTenant].[BDBuildingPK] = [BDBuilding].[BDBuildingPK] WHERE [BDBuilding].[BDBuildingPK] = @BDBuildingPK;", this.TableName);
			string oldValue = string.Format("DELETE [{0}]", this.TableName);
			string newValue = "SELECT  [UsrAccount].[UsrAccountPK] AS [UsrAccountPK], [UsrAccount].[ModifiedOn] AS [ModifiedOn]";
			sql = sql.Replace(oldValue, newValue).TrimEnd().TrimEnd(';').Replace(";", " UNION ");
			SqlParameter[] paras = new SqlParameter[1];
			paras[0] = new SqlParameter("@BDBuildingPK", SqlDbType.UniqueIdentifier);
			paras[0].Value = bDBuildingPK;
			return base.ExecuteDataTable(sql, paras);
		}

		public DataTable GetLogByUsrGroup(System.Guid usrGroupPK)
		{
			string sql = string.Format("DELETE [{0}] FROM [{0}] [UsrAccount] INNER JOIN [UsrGroup] ON [UsrAccount].[UsrGroupPK] = [UsrGroup].[UsrGroupPK] WHERE [UsrGroup].[UsrGroupPK] = @UsrGroupPK;", this.TableName);
			string oldValue = string.Format("DELETE [{0}]", this.TableName);
			string newValue = "SELECT  [UsrAccount].[UsrAccountPK] AS [UsrAccountPK], [UsrAccount].[ModifiedOn] AS [ModifiedOn]";
			sql = sql.Replace(oldValue, newValue).TrimEnd().TrimEnd(';').Replace(";", " UNION ");
			SqlParameter[] paras = new SqlParameter[1];
			paras[0] = new SqlParameter("@UsrGroupPK", SqlDbType.UniqueIdentifier);
			paras[0].Value = usrGroupPK;
			return base.ExecuteDataTable(sql, paras);
		}

		public int DeleteByPK( System.Guid UsrAccountPK, byte[] RowVersion)
		{
			string sql = string.Format("DELETE FROM [{0}] WHERE  [UsrAccountPK] = @UsrAccountPK AND [RowVersion] = @RowVersion", this.TableName);
			SqlParameter[] paras = new SqlParameter[2];
			paras[0] = new SqlParameter("@UsrAccountPK", SqlDbType.UniqueIdentifier);
			paras[0].Value = UsrAccountPK;
			paras[1] = new SqlParameter("@RowVersion", SqlDbType.Timestamp, 8);
			paras[1].Value = RowVersion;
			return base.ExecuteNonQuery(sql, paras);
		}

		public int DeleteAll()
		{
			string sql = string.Format("DELETE FROM [{0}]", this.TableName);
			return base.ExecuteNonQuery(sql, null);
		}

		public int DeleteByBDTenant(System.Guid bDTenantPK)
		{
			string sql = string.Format("DELETE [{0}] FROM [{0}] [UsrAccount] INNER JOIN [BDTenant] ON [UsrAccount].[BDTenantPK] = [BDTenant].[BDTenantPK] WHERE [BDTenant].[BDTenantPK] = @BDTenantPK;", this.TableName);
			SqlParameter[] paras = new SqlParameter[1];
			paras[0] = new SqlParameter("@BDTenantPK", SqlDbType.UniqueIdentifier);
			paras[0].Value = bDTenantPK;
			return base.ExecuteNonQuery(sql, paras);
		}

		public int DeleteByBDBuilding(System.Guid bDBuildingPK)
		{
			string sql = string.Format("DELETE [{0}] FROM [{0}] [UsrAccount] INNER JOIN [BDTenant] ON [UsrAccount].[BDTenantPK] = [BDTenant].[BDTenantPK] INNER JOIN [BDBuilding] ON [BDTenant].[BDBuildingPK] = [BDBuilding].[BDBuildingPK] WHERE [BDBuilding].[BDBuildingPK] = @BDBuildingPK;", this.TableName);
			SqlParameter[] paras = new SqlParameter[1];
			paras[0] = new SqlParameter("@BDBuildingPK", SqlDbType.UniqueIdentifier);
			paras[0].Value = bDBuildingPK;
			return base.ExecuteNonQuery(sql, paras);
		}

		public int DeleteByUsrGroup(System.Guid usrGroupPK)
		{
			string sql = string.Format("DELETE [{0}] FROM [{0}] [UsrAccount] INNER JOIN [UsrGroup] ON [UsrAccount].[UsrGroupPK] = [UsrGroup].[UsrGroupPK] WHERE [UsrGroup].[UsrGroupPK] = @UsrGroupPK;", this.TableName);
			SqlParameter[] paras = new SqlParameter[1];
			paras[0] = new SqlParameter("@UsrGroupPK", SqlDbType.UniqueIdentifier);
			paras[0].Value = usrGroupPK;
			return base.ExecuteNonQuery(sql, paras);
		}


	}
	public class LogDBEditActivityCRUD : DataAccessBase
	{
		private string _tableName = "LogDBEditActivity";

		public LogDBEditActivityCRUD(string connectionString) : base(connectionString)
		{
		}

		public virtual string TableName
		{
			get { return this._tableName; }
			set { this._tableName = value; }
		}

		public string SQLColumns
		{
			get
			{
				return "[LogDBEditActivity].[LogDBEditActivityPK] AS [LogDBEditActivityPK],[LogDBEditActivity].[LogDateTime] AS [LogDateTime],[LogDBEditActivity].[DBTableName] AS [DBTableName],[LogDBEditActivity].[RecordPK] AS [RecordPK],[LogDBEditActivity].[Category] AS [Category],[LogDBEditActivity].[RecordDetail] AS [RecordDetail],[LogDBEditActivity].[RowVersion] AS [RowVersion],[LogDBEditActivity].[CreatedOn] AS [CreatedOn],[LogDBEditActivity].[CreatedBy] AS [CreatedBy],[LogDBEditActivity].[ModifiedOn] AS [ModifiedOn],[LogDBEditActivity].[ModifiedBy] AS [ModifiedBy]";
			}
		}

		public string SQLLeftJoins
		{
			get
			{
				return "";
			}
		}

		protected override string SQLSelect
		{
			get
			{
				return string.Format("SELECT [LogDBEditActivity].[LogDBEditActivityPK] AS [LogDBEditActivityPK],[LogDBEditActivity].[LogDateTime] AS [LogDateTime],[LogDBEditActivity].[DBTableName] AS [DBTableName],[LogDBEditActivity].[RecordPK] AS [RecordPK],[LogDBEditActivity].[Category] AS [Category],[LogDBEditActivity].[RecordDetail] AS [RecordDetail],[LogDBEditActivity].[RowVersion] AS [RowVersion],[LogDBEditActivity].[CreatedOn] AS [CreatedOn],[LogDBEditActivity].[CreatedBy] AS [CreatedBy],[LogDBEditActivity].[ModifiedOn] AS [ModifiedOn],[LogDBEditActivity].[ModifiedBy] AS [ModifiedBy] FROM [{0}] [LogDBEditActivity] ", this.TableName);
			}
		}

		protected override string SQLCount
		{
			get
			{
				return string.Format("SELECT COUNT(*) FROM [{0}] [LogDBEditActivity] ", this.TableName);
			}
		}

		public int Insert(LogDBEditActivityData entity)
		{
			string sql = string.Format("INSERT INTO [{0}] ([LogDBEditActivityPK],[LogDateTime],[DBTableName],[RecordPK],[Category],[RecordDetail],[CreatedOn],[CreatedBy],[ModifiedOn],[ModifiedBy]) VALUES(@LogDBEditActivityPK,@LogDateTime,@DBTableName,@RecordPK,@Category,@RecordDetail,@CreatedOn,@CreatedBy,@ModifiedOn,@ModifiedBy)", this.TableName);
			SqlParameter[] paras = new SqlParameter[10];
			paras[0] = new SqlParameter("@LogDBEditActivityPK", SqlDbType.UniqueIdentifier);
			if (entity.LogDBEditActivityPK == Guid.Empty)
			{
				paras[0].Value = DBNull.Value;
			}
			else
			{
				paras[0].Value = entity.LogDBEditActivityPK;
			}
			paras[1] = new SqlParameter("@LogDateTime", SqlDbType.DateTime);
			paras[1].Value = entity.LogDateTime;
			paras[2] = new SqlParameter("@DBTableName", SqlDbType.VarChar, 128);
			paras[2].Value = entity.DBTableName;
			paras[3] = new SqlParameter("@RecordPK", SqlDbType.UniqueIdentifier);
			if (entity.RecordPK == Guid.Empty)
			{
				paras[3].Value = DBNull.Value;
			}
			else
			{
				paras[3].Value = entity.RecordPK;
			}
			paras[4] = new SqlParameter("@Category", SqlDbType.VarChar, 20);
			paras[4].Value = entity.Category;
			paras[5] = new SqlParameter("@RecordDetail", SqlDbType.Image);
			paras[5].Value = entity.RecordDetail;
			paras[6] = new SqlParameter("@CreatedOn", SqlDbType.DateTime);
			paras[6].Value = entity.CreatedOn;
			paras[7] = new SqlParameter("@CreatedBy", SqlDbType.VarChar, 30);
			paras[7].Value = entity.CreatedBy;
			paras[8] = new SqlParameter("@ModifiedOn", SqlDbType.DateTime);
			paras[8].Value = entity.ModifiedOn;
			paras[9] = new SqlParameter("@ModifiedBy", SqlDbType.VarChar, 30);
			paras[9].Value = entity.ModifiedBy;
			return base.ExecuteNonQuery(sql, paras);
		}

		public int Update(LogDBEditActivityData entity)
		{
			string sql = string.Format("UPDATE [{0}] SET [LogDateTime] = @LogDateTime,[DBTableName] = @DBTableName,[RecordPK] = @RecordPK,[Category] = @Category,[RecordDetail] = @RecordDetail,[CreatedOn] = @CreatedOn,[CreatedBy] = @CreatedBy,[ModifiedOn] = @ModifiedOn,[ModifiedBy] = @ModifiedBy  WHERE [LogDBEditActivityPK] = @LogDBEditActivityPK AND [RowVersion] = @RowVersion", this.TableName);
			SqlParameter[] paras = new SqlParameter[11];
			paras[0] = new SqlParameter("@LogDBEditActivityPK", SqlDbType.UniqueIdentifier);
			if (entity.LogDBEditActivityPK == Guid.Empty)
			{
				paras[0].Value = DBNull.Value;
			}
			else
			{
				paras[0].Value = entity.LogDBEditActivityPK;
			}
			paras[1] = new SqlParameter("@LogDateTime", SqlDbType.DateTime);
			paras[1].Value = entity.LogDateTime;
			paras[2] = new SqlParameter("@DBTableName", SqlDbType.VarChar, 128);
			paras[2].Value = entity.DBTableName;
			paras[3] = new SqlParameter("@RecordPK", SqlDbType.UniqueIdentifier);
			if (entity.RecordPK == Guid.Empty)
			{
				paras[3].Value = DBNull.Value;
			}
			else
			{
				paras[3].Value = entity.RecordPK;
			}
			paras[4] = new SqlParameter("@Category", SqlDbType.VarChar, 20);
			paras[4].Value = entity.Category;
			paras[5] = new SqlParameter("@RecordDetail", SqlDbType.Image);
			paras[5].Value = entity.RecordDetail;
			paras[6] = new SqlParameter("@RowVersion", SqlDbType.Timestamp);
			paras[6].Value = entity.RowVersion;
			paras[7] = new SqlParameter("@CreatedOn", SqlDbType.DateTime);
			paras[7].Value = entity.CreatedOn;
			paras[8] = new SqlParameter("@CreatedBy", SqlDbType.VarChar, 30);
			paras[8].Value = entity.CreatedBy;
			paras[9] = new SqlParameter("@ModifiedOn", SqlDbType.DateTime);
			paras[9].Value = entity.ModifiedOn;
			paras[10] = new SqlParameter("@ModifiedBy", SqlDbType.VarChar, 30);
			paras[10].Value = entity.ModifiedBy;
			return base.ExecuteNonQuery(sql, paras);
		}

		private LogDBEditActivityData CreateDataByReader(SafeDataReader reader)
		{
			LogDBEditActivityData data = new LogDBEditActivityData {
				LogDBEditActivityPK = (Guid) reader["LogDBEditActivityPK"],
				LogDateTime = (DateTime) reader["LogDateTime"],
				DBTableName = (String) reader["DBTableName"],
				RecordPK = (Guid) reader["RecordPK"],
				Category = (String) reader["Category"],
				RecordDetail = (Byte[]) reader["RecordDetail"],
				RowVersion = (Byte[]) reader["RowVersion"],
				CreatedOn = (DateTime) reader["CreatedOn"],
				CreatedBy = (String) reader["CreatedBy"],
				ModifiedOn = (DateTime) reader["ModifiedOn"],
				ModifiedBy = (String) reader["ModifiedBy"]
			};
			data.AcceptChanges();
			return data;
		}

		private LogDBEditActivityData FetchEntity(string where, SqlParameter[] paras)
		{
			LogDBEditActivityData data = null;
			using (SafeDataReader reader = base.ExecuteDataReader(where, paras))
			{
				if (reader.Read())
				{
					data = this.CreateDataByReader(reader);
				}
				reader.Close();
			}
			return data;
		}

		private LogDBEditActivityData FetchEntityEx(string sql, SqlParameter[] paras)
		{
			LogDBEditActivityData data = null;
			using (SafeDataReader reader = base.ExecuteDataReaderEx(sql, paras))
			{
				if (reader.Read())
				{
					data = this.CreateDataByReader(reader);
				}
				reader.Close();
			}
			return data;
		}

		private LogDBEditActivityDataCollection FetchCollection(string where, SqlParameter[] paras)
		{
			LogDBEditActivityDataCollection list = new LogDBEditActivityDataCollection();
			using (SafeDataReader reader = base.ExecuteDataReader(where, paras))
			{
				while(reader.Read())
				{
					LogDBEditActivityData data = this.CreateDataByReader(reader);
					list.Add(data);
				}
				reader.Close();
			}
			return list;
		}

		private LogDBEditActivityDataCollection FetchCollectionEx(string sql, SqlParameter[] paras)
		{
			LogDBEditActivityDataCollection list = new LogDBEditActivityDataCollection();
			using (SafeDataReader reader = base.ExecuteDataReaderEx(sql, paras))
			{
				while(reader.Read())
				{
					LogDBEditActivityData data = this.CreateDataByReader(reader);
					list.Add(data);
				}
				reader.Close();
			}
			return list;
		}

		public LogDBEditActivityData GetEntityBy(string sqlWhere, SqlParameter[] paras)
		{
			return this.FetchEntity(sqlWhere, paras);
		}

		public LogDBEditActivityData GetEntityExBy(string sql, SqlParameter[] paras)
		{
			return this.FetchEntityEx(sql, paras);
		}

		public LogDBEditActivityDataCollection GetCollectionBy(string sqlWhere, SqlParameter[] paras)
		{
			return this.FetchCollection(sqlWhere, paras);
		}

		public LogDBEditActivityDataCollection GetCollectionExBy(string sql, SqlParameter[] paras)
		{
			return this.FetchCollectionEx(sql, paras);
		}

		public byte[] GetRowVersion( System.Guid LogDBEditActivityPK)
		{
			string sql = string.Format("SELECT [RowVersion] AS [RowVersion] FROM [{0}] WHERE  [LogDBEditActivityPK] = @LogDBEditActivityPK ", this.TableName);
			SqlParameter[] paras = new SqlParameter[1];
			paras[0] = new SqlParameter("@LogDBEditActivityPK", SqlDbType.UniqueIdentifier, 16);
			paras[0].Value = LogDBEditActivityPK;
			return (byte[]) base.ExecuteScalar(sql, paras);
		}

		public LogDBEditActivityData GetByPK( System.Guid LogDBEditActivityPK)
		{
			string sql = " WHERE  [LogDBEditActivity].[LogDBEditActivityPK] = @LogDBEditActivityPK ";
			SqlParameter[] paras = new SqlParameter[1];
			paras[0] = new SqlParameter("@LogDBEditActivityPK", SqlDbType.UniqueIdentifier);
			paras[0].Value = LogDBEditActivityPK;
			return this.FetchEntity(sql, paras);
		}

		public LogDBEditActivityDataCollection GetAll()
		{
			return this.FetchCollection("", null);
		}

		public DataTable GetLogByPK( System.Guid LogDBEditActivityPK)
		{
			string sql = string.Format("SELECT  [LogDBEditActivity].[LogDBEditActivityPK] AS [LogDBEditActivityPK], [LogDBEditActivity].[ModifiedOn] AS [ModifiedOn] FROM [{0}] WHERE  [LogDBEditActivity].[LogDBEditActivityPK] = @LogDBEditActivityPK ", this.TableName);
			SqlParameter[] paras = new SqlParameter[1];
			paras[0] = new SqlParameter("@LogDBEditActivityPK", SqlDbType.UniqueIdentifier);
			paras[0].Value = LogDBEditActivityPK;
			return this.ExecuteDataTable(sql, paras);
		}

		public int DeleteByPK( System.Guid LogDBEditActivityPK, byte[] RowVersion)
		{
			string sql = string.Format("DELETE FROM [{0}] WHERE  [LogDBEditActivityPK] = @LogDBEditActivityPK AND [RowVersion] = @RowVersion", this.TableName);
			SqlParameter[] paras = new SqlParameter[2];
			paras[0] = new SqlParameter("@LogDBEditActivityPK", SqlDbType.UniqueIdentifier);
			paras[0].Value = LogDBEditActivityPK;
			paras[1] = new SqlParameter("@RowVersion", SqlDbType.Timestamp, 8);
			paras[1].Value = RowVersion;
			return base.ExecuteNonQuery(sql, paras);
		}

		public int DeleteAll()
		{
			string sql = string.Format("DELETE FROM [{0}]", this.TableName);
			return base.ExecuteNonQuery(sql, null);
		}


	}
	public class ACMasterCardCRUD : DataAccessBase
	{
		private string _tableName = "ACMasterCard";

		public ACMasterCardCRUD(string connectionString) : base(connectionString)
		{
		}

		public virtual string TableName
		{
			get { return this._tableName; }
			set { this._tableName = value; }
		}

		public string SQLColumns
		{
			get
			{
				return "[ACMasterCard].[ACMasterCardPK] AS [ACMasterCardPK],[ACMasterCard].[Sitecode] AS [Sitecode],[ACMasterCard].[Embossed] AS [Embossed],[ACMasterCard].[Encoded] AS [Encoded],[ACMasterCard].[CardTypeID] AS [CardTypeID],[ACMasterCard].[FirstName] AS [FirstName],[ACMasterCard].[LastName] AS [LastName],[ACMasterCard].[Photo] AS [Photo],[ACMasterCard].[FIPS] AS [FIPS],[ACMasterCard].[Pin] AS [Pin],[ACMasterCard].[RowVersion] AS [RowVersion],[ACMasterCard].[CreatedOn] AS [CreatedOn],[ACMasterCard].[CreatedBy] AS [CreatedBy],[ACMasterCard].[ModifiedOn] AS [ModifiedOn],[ACMasterCard].[ModifiedBy] AS [ModifiedBy]";
			}
		}

		public string SQLLeftJoins
		{
			get
			{
				return "";
			}
		}

		protected override string SQLSelect
		{
			get
			{
				return string.Format("SELECT [ACMasterCard].[ACMasterCardPK] AS [ACMasterCardPK],[ACMasterCard].[Sitecode] AS [Sitecode],[ACMasterCard].[Embossed] AS [Embossed],[ACMasterCard].[Encoded] AS [Encoded],[ACMasterCard].[CardTypeID] AS [CardTypeID],[ACMasterCard].[FirstName] AS [FirstName],[ACMasterCard].[LastName] AS [LastName],[ACMasterCard].[Photo] AS [Photo],[ACMasterCard].[FIPS] AS [FIPS],[ACMasterCard].[Pin] AS [Pin],[ACMasterCard].[RowVersion] AS [RowVersion],[ACMasterCard].[CreatedOn] AS [CreatedOn],[ACMasterCard].[CreatedBy] AS [CreatedBy],[ACMasterCard].[ModifiedOn] AS [ModifiedOn],[ACMasterCard].[ModifiedBy] AS [ModifiedBy] FROM [{0}] [ACMasterCard] ", this.TableName);
			}
		}

		protected override string SQLCount
		{
			get
			{
				return string.Format("SELECT COUNT(*) FROM [{0}] [ACMasterCard] ", this.TableName);
			}
		}

		public int Insert(ACMasterCardData entity)
		{
			string sql = string.Format("INSERT INTO [{0}] ([ACMasterCardPK],[Sitecode],[Embossed],[Encoded],[CardTypeID],[FirstName],[LastName],[Photo],[FIPS],[Pin],[CreatedOn],[CreatedBy],[ModifiedOn],[ModifiedBy]) VALUES(@ACMasterCardPK,@Sitecode,@Embossed,@Encoded,@CardTypeID,@FirstName,@LastName,@Photo,@FIPS,@Pin,@CreatedOn,@CreatedBy,@ModifiedOn,@ModifiedBy)", this.TableName);
			SqlParameter[] paras = new SqlParameter[14];
			paras[0] = new SqlParameter("@ACMasterCardPK", SqlDbType.UniqueIdentifier);
			if (entity.ACMasterCardPK == Guid.Empty)
			{
				paras[0].Value = DBNull.Value;
			}
			else
			{
				paras[0].Value = entity.ACMasterCardPK;
			}
			paras[1] = new SqlParameter("@Sitecode", SqlDbType.Int);
			paras[1].Value = entity.Sitecode;
			paras[2] = new SqlParameter("@Embossed", SqlDbType.Int);
			paras[2].Value = entity.Embossed;
			paras[3] = new SqlParameter("@Encoded", SqlDbType.Int);
			paras[3].Value = entity.Encoded;
			paras[4] = new SqlParameter("@CardTypeID", SqlDbType.Int);
			paras[4].Value = entity.CardTypeID;
			paras[5] = new SqlParameter("@FirstName", SqlDbType.VarChar, 30);
			paras[5].Value = entity.FirstName;
			paras[6] = new SqlParameter("@LastName", SqlDbType.VarChar, 50);
			paras[6].Value = entity.LastName;
			paras[7] = new SqlParameter("@Photo", SqlDbType.Image);
			paras[7].Value = entity.Photo;
			paras[8] = new SqlParameter("@FIPS", SqlDbType.Bit);
			paras[8].Value = entity.FIPS;
			paras[9] = new SqlParameter("@Pin", SqlDbType.Int);
			paras[9].Value = entity.Pin;
			paras[10] = new SqlParameter("@CreatedOn", SqlDbType.DateTime);
			paras[10].Value = entity.CreatedOn;
			paras[11] = new SqlParameter("@CreatedBy", SqlDbType.VarChar, 30);
			paras[11].Value = entity.CreatedBy;
			paras[12] = new SqlParameter("@ModifiedOn", SqlDbType.DateTime);
			paras[12].Value = entity.ModifiedOn;
			paras[13] = new SqlParameter("@ModifiedBy", SqlDbType.VarChar, 30);
			paras[13].Value = entity.ModifiedBy;
			return base.ExecuteNonQuery(sql, paras);
		}

		public int Update(ACMasterCardData entity)
		{
			string sql = string.Format("UPDATE [{0}] SET [Sitecode] = @Sitecode,[Embossed] = @Embossed,[Encoded] = @Encoded,[CardTypeID] = @CardTypeID,[FirstName] = @FirstName,[LastName] = @LastName,[Photo] = @Photo,[FIPS] = @FIPS,[Pin] = @Pin,[CreatedOn] = @CreatedOn,[CreatedBy] = @CreatedBy,[ModifiedOn] = @ModifiedOn,[ModifiedBy] = @ModifiedBy  WHERE [ACMasterCardPK] = @ACMasterCardPK AND [RowVersion] = @RowVersion", this.TableName);
			SqlParameter[] paras = new SqlParameter[15];
			paras[0] = new SqlParameter("@ACMasterCardPK", SqlDbType.UniqueIdentifier);
			if (entity.ACMasterCardPK == Guid.Empty)
			{
				paras[0].Value = DBNull.Value;
			}
			else
			{
				paras[0].Value = entity.ACMasterCardPK;
			}
			paras[1] = new SqlParameter("@Sitecode", SqlDbType.Int);
			paras[1].Value = entity.Sitecode;
			paras[2] = new SqlParameter("@Embossed", SqlDbType.Int);
			paras[2].Value = entity.Embossed;
			paras[3] = new SqlParameter("@Encoded", SqlDbType.Int);
			paras[3].Value = entity.Encoded;
			paras[4] = new SqlParameter("@CardTypeID", SqlDbType.Int);
			paras[4].Value = entity.CardTypeID;
			paras[5] = new SqlParameter("@FirstName", SqlDbType.VarChar, 30);
			paras[5].Value = entity.FirstName;
			paras[6] = new SqlParameter("@LastName", SqlDbType.VarChar, 50);
			paras[6].Value = entity.LastName;
			paras[7] = new SqlParameter("@Photo", SqlDbType.Image);
			paras[7].Value = entity.Photo;
			paras[8] = new SqlParameter("@FIPS", SqlDbType.Bit);
			paras[8].Value = entity.FIPS;
			paras[9] = new SqlParameter("@Pin", SqlDbType.Int);
			paras[9].Value = entity.Pin;
			paras[10] = new SqlParameter("@RowVersion", SqlDbType.Timestamp);
			paras[10].Value = entity.RowVersion;
			paras[11] = new SqlParameter("@CreatedOn", SqlDbType.DateTime);
			paras[11].Value = entity.CreatedOn;
			paras[12] = new SqlParameter("@CreatedBy", SqlDbType.VarChar, 30);
			paras[12].Value = entity.CreatedBy;
			paras[13] = new SqlParameter("@ModifiedOn", SqlDbType.DateTime);
			paras[13].Value = entity.ModifiedOn;
			paras[14] = new SqlParameter("@ModifiedBy", SqlDbType.VarChar, 30);
			paras[14].Value = entity.ModifiedBy;
			return base.ExecuteNonQuery(sql, paras);
		}

		private ACMasterCardData CreateDataByReader(SafeDataReader reader)
		{
			ACMasterCardData data = new ACMasterCardData {
				ACMasterCardPK = (Guid) reader["ACMasterCardPK"],
				Sitecode = (Int32) reader["Sitecode"],
				Embossed = (Int32) reader["Embossed"],
				Encoded = (Int32) reader["Encoded"],
				CardTypeID = (Int32) reader["CardTypeID"],
				FirstName = (String) reader["FirstName"],
				LastName = (String) reader["LastName"],
				Photo = (Byte[]) reader["Photo"],
				FIPS = (Boolean) reader["FIPS"],
				Pin = (Int32) reader["Pin"],
				RowVersion = (Byte[]) reader["RowVersion"],
				CreatedOn = (DateTime) reader["CreatedOn"],
				CreatedBy = (String) reader["CreatedBy"],
				ModifiedOn = (DateTime) reader["ModifiedOn"],
				ModifiedBy = (String) reader["ModifiedBy"]
			};
			data.AcceptChanges();
			return data;
		}

		private ACMasterCardData FetchEntity(string where, SqlParameter[] paras)
		{
			ACMasterCardData data = null;
			using (SafeDataReader reader = base.ExecuteDataReader(where, paras))
			{
				if (reader.Read())
				{
					data = this.CreateDataByReader(reader);
				}
				reader.Close();
			}
			return data;
		}

		private ACMasterCardData FetchEntityEx(string sql, SqlParameter[] paras)
		{
			ACMasterCardData data = null;
			using (SafeDataReader reader = base.ExecuteDataReaderEx(sql, paras))
			{
				if (reader.Read())
				{
					data = this.CreateDataByReader(reader);
				}
				reader.Close();
			}
			return data;
		}

		private ACMasterCardDataCollection FetchCollection(string where, SqlParameter[] paras)
		{
			ACMasterCardDataCollection list = new ACMasterCardDataCollection();
			using (SafeDataReader reader = base.ExecuteDataReader(where, paras))
			{
				while(reader.Read())
				{
					ACMasterCardData data = this.CreateDataByReader(reader);
					list.Add(data);
				}
				reader.Close();
			}
			return list;
		}

		private ACMasterCardDataCollection FetchCollectionEx(string sql, SqlParameter[] paras)
		{
			ACMasterCardDataCollection list = new ACMasterCardDataCollection();
			using (SafeDataReader reader = base.ExecuteDataReaderEx(sql, paras))
			{
				while(reader.Read())
				{
					ACMasterCardData data = this.CreateDataByReader(reader);
					list.Add(data);
				}
				reader.Close();
			}
			return list;
		}

		public ACMasterCardData GetEntityBy(string sqlWhere, SqlParameter[] paras)
		{
			return this.FetchEntity(sqlWhere, paras);
		}

		public ACMasterCardData GetEntityExBy(string sql, SqlParameter[] paras)
		{
			return this.FetchEntityEx(sql, paras);
		}

		public ACMasterCardDataCollection GetCollectionBy(string sqlWhere, SqlParameter[] paras)
		{
			return this.FetchCollection(sqlWhere, paras);
		}

		public ACMasterCardDataCollection GetCollectionExBy(string sql, SqlParameter[] paras)
		{
			return this.FetchCollectionEx(sql, paras);
		}

		public byte[] GetRowVersion( System.Guid ACMasterCardPK)
		{
			string sql = string.Format("SELECT [RowVersion] AS [RowVersion] FROM [{0}] WHERE  [ACMasterCardPK] = @ACMasterCardPK ", this.TableName);
			SqlParameter[] paras = new SqlParameter[1];
			paras[0] = new SqlParameter("@ACMasterCardPK", SqlDbType.UniqueIdentifier, 16);
			paras[0].Value = ACMasterCardPK;
			return (byte[]) base.ExecuteScalar(sql, paras);
		}

		public ACMasterCardData GetByPK( System.Guid ACMasterCardPK)
		{
			string sql = " WHERE  [ACMasterCard].[ACMasterCardPK] = @ACMasterCardPK ";
			SqlParameter[] paras = new SqlParameter[1];
			paras[0] = new SqlParameter("@ACMasterCardPK", SqlDbType.UniqueIdentifier);
			paras[0].Value = ACMasterCardPK;
			return this.FetchEntity(sql, paras);
		}

		public ACMasterCardDataCollection GetAll()
		{
			return this.FetchCollection("", null);
		}

		public DataTable GetLogByPK( System.Guid ACMasterCardPK)
		{
			string sql = string.Format("SELECT  [ACMasterCard].[ACMasterCardPK] AS [ACMasterCardPK], [ACMasterCard].[ModifiedOn] AS [ModifiedOn] FROM [{0}] WHERE  [ACMasterCard].[ACMasterCardPK] = @ACMasterCardPK ", this.TableName);
			SqlParameter[] paras = new SqlParameter[1];
			paras[0] = new SqlParameter("@ACMasterCardPK", SqlDbType.UniqueIdentifier);
			paras[0].Value = ACMasterCardPK;
			return this.ExecuteDataTable(sql, paras);
		}

		public int DeleteByPK( System.Guid ACMasterCardPK, byte[] RowVersion)
		{
			string sql = string.Format("DELETE FROM [{0}] WHERE  [ACMasterCardPK] = @ACMasterCardPK AND [RowVersion] = @RowVersion", this.TableName);
			SqlParameter[] paras = new SqlParameter[2];
			paras[0] = new SqlParameter("@ACMasterCardPK", SqlDbType.UniqueIdentifier);
			paras[0].Value = ACMasterCardPK;
			paras[1] = new SqlParameter("@RowVersion", SqlDbType.Timestamp, 8);
			paras[1].Value = RowVersion;
			return base.ExecuteNonQuery(sql, paras);
		}

		public int DeleteAll()
		{
			string sql = string.Format("DELETE FROM [{0}]", this.TableName);
			return base.ExecuteNonQuery(sql, null);
		}


	}
	public class ACSupervisoryCRUD : DataAccessBase
	{
		private string _tableName = "ACSupervisory";

		public ACSupervisoryCRUD(string connectionString) : base(connectionString)
		{
		}

		public virtual string TableName
		{
			get { return this._tableName; }
			set { this._tableName = value; }
		}

		public string SQLColumns
		{
			get
			{
				return "[ACSupervisory].[ACSupervisoryPK] AS [ACSupervisoryPK],[ACSupervisory].[ACPanelPK] AS [ACPanelPK],[ACSupervisory].[SupervisoryID] AS [SupervisoryID],[ACSupervisory].[Description] AS [Description],[ACSupervisory].[Debounce] AS [Debounce],[ACSupervisory].[ForceAMFormat] AS [ForceAMFormat],[ACSupervisory].[External] AS [External],[ACSupervisory].[Notes] AS [Notes],[ACSupervisory].[RowVersion] AS [RowVersion],[ACSupervisory].[CreatedOn] AS [CreatedOn],[ACSupervisory].[CreatedBy] AS [CreatedBy],[ACSupervisory].[ModifiedOn] AS [ModifiedOn],[ACSupervisory].[ModifiedBy] AS [ModifiedBy],[ACSupervisory].[PanelZoneID] AS [PanelZoneID],[ACSupervisory].[Locked] AS [Locked],[ACPanel].[BDBuildingPK] AS [BDBuildingPK],[ACPanel].[UnitID] AS [UnitID],[BDBuilding].[Address1] AS [Address1],[BDBuilding].[BuildingID] AS [BuildingID]";
			}
		}

		public string SQLLeftJoins
		{
			get
			{
				return "LEFT JOIN [ACPanel] [ACPanel] ON [ACSupervisory].[ACPanelPK] = [ACPanel].[ACPanelPK] LEFT JOIN [BDBuilding] [BDBuilding] ON [ACPanel].[BDBuildingPK] = [BDBuilding].[BDBuildingPK]";
			}
		}

		protected override string SQLSelect
		{
			get
			{
				return string.Format("SELECT [ACSupervisory].[ACSupervisoryPK] AS [ACSupervisoryPK],[ACSupervisory].[ACPanelPK] AS [ACPanelPK],[ACSupervisory].[SupervisoryID] AS [SupervisoryID],[ACSupervisory].[Description] AS [Description],[ACSupervisory].[Debounce] AS [Debounce],[ACSupervisory].[ForceAMFormat] AS [ForceAMFormat],[ACSupervisory].[External] AS [External],[ACSupervisory].[Notes] AS [Notes],[ACSupervisory].[RowVersion] AS [RowVersion],[ACSupervisory].[CreatedOn] AS [CreatedOn],[ACSupervisory].[CreatedBy] AS [CreatedBy],[ACSupervisory].[ModifiedOn] AS [ModifiedOn],[ACSupervisory].[ModifiedBy] AS [ModifiedBy],[ACSupervisory].[PanelZoneID] AS [PanelZoneID],[ACSupervisory].[Locked] AS [Locked],[ACPanel].[BDBuildingPK] AS [BDBuildingPK],[ACPanel].[UnitID] AS [UnitID],[BDBuilding].[Address1] AS [Address1],[BDBuilding].[BuildingID] AS [BuildingID] FROM [{0}] [ACSupervisory] LEFT JOIN [ACPanel] [ACPanel] ON [ACSupervisory].[ACPanelPK] = [ACPanel].[ACPanelPK] LEFT JOIN [BDBuilding] [BDBuilding] ON [ACPanel].[BDBuildingPK] = [BDBuilding].[BDBuildingPK]", this.TableName);
			}
		}

		protected override string SQLCount
		{
			get
			{
				return string.Format("SELECT COUNT(*) FROM [{0}] [ACSupervisory] LEFT JOIN [ACPanel] [ACPanel] ON [ACSupervisory].[ACPanelPK] = [ACPanel].[ACPanelPK] LEFT JOIN [BDBuilding] [BDBuilding] ON [ACPanel].[BDBuildingPK] = [BDBuilding].[BDBuildingPK]", this.TableName);
			}
		}

		public int Insert(ACSupervisoryData entity)
		{
			string sql = string.Format("INSERT INTO [{0}] ([ACSupervisoryPK],[ACPanelPK],[SupervisoryID],[Description],[Debounce],[ForceAMFormat],[External],[Notes],[CreatedOn],[CreatedBy],[ModifiedOn],[ModifiedBy],[PanelZoneID],[Locked]) VALUES(@ACSupervisoryPK,@ACPanelPK,@SupervisoryID,@Description,@Debounce,@ForceAMFormat,@External,@Notes,@CreatedOn,@CreatedBy,@ModifiedOn,@ModifiedBy,@PanelZoneID,@Locked)", this.TableName);
			SqlParameter[] paras = new SqlParameter[14];
			paras[0] = new SqlParameter("@ACSupervisoryPK", SqlDbType.UniqueIdentifier);
			if (entity.ACSupervisoryPK == Guid.Empty)
			{
				paras[0].Value = DBNull.Value;
			}
			else
			{
				paras[0].Value = entity.ACSupervisoryPK;
			}
			paras[1] = new SqlParameter("@ACPanelPK", SqlDbType.UniqueIdentifier);
			if (entity.ACPanelPK == Guid.Empty)
			{
				paras[1].Value = DBNull.Value;
			}
			else
			{
				paras[1].Value = entity.ACPanelPK;
			}
			paras[2] = new SqlParameter("@SupervisoryID", SqlDbType.TinyInt);
			paras[2].Value = entity.SupervisoryID;
			paras[3] = new SqlParameter("@Description", SqlDbType.VarChar, 30);
			paras[3].Value = entity.Description;
			paras[4] = new SqlParameter("@Debounce", SqlDbType.SmallInt);
			paras[4].Value = entity.Debounce;
			paras[5] = new SqlParameter("@ForceAMFormat", SqlDbType.SmallInt);
			paras[5].Value = entity.ForceAMFormat;
			paras[6] = new SqlParameter("@External", SqlDbType.Bit);
			paras[6].Value = entity.External;
			paras[7] = new SqlParameter("@Notes", SqlDbType.VarChar, 512);
			paras[7].Value = entity.Notes;
			paras[8] = new SqlParameter("@CreatedOn", SqlDbType.DateTime);
			paras[8].Value = entity.CreatedOn;
			paras[9] = new SqlParameter("@CreatedBy", SqlDbType.VarChar, 30);
			paras[9].Value = entity.CreatedBy;
			paras[10] = new SqlParameter("@ModifiedOn", SqlDbType.DateTime);
			paras[10].Value = entity.ModifiedOn;
			paras[11] = new SqlParameter("@ModifiedBy", SqlDbType.VarChar, 30);
			paras[11].Value = entity.ModifiedBy;
			paras[12] = new SqlParameter("@PanelZoneID", SqlDbType.TinyInt);
			paras[12].Value = entity.PanelZoneID;
			paras[13] = new SqlParameter("@Locked", SqlDbType.Bit);
			paras[13].Value = entity.Locked;
			return base.ExecuteNonQuery(sql, paras);
		}

		public int Update(ACSupervisoryData entity)
		{
			string sql = string.Format("UPDATE [{0}] SET [ACPanelPK] = @ACPanelPK,[SupervisoryID] = @SupervisoryID,[Description] = @Description,[Debounce] = @Debounce,[ForceAMFormat] = @ForceAMFormat,[External] = @External,[Notes] = @Notes,[CreatedOn] = @CreatedOn,[CreatedBy] = @CreatedBy,[ModifiedOn] = @ModifiedOn,[ModifiedBy] = @ModifiedBy,[PanelZoneID] = @PanelZoneID,[Locked] = @Locked  WHERE [ACSupervisoryPK] = @ACSupervisoryPK AND [RowVersion] = @RowVersion", this.TableName);
			SqlParameter[] paras = new SqlParameter[15];
			paras[0] = new SqlParameter("@ACSupervisoryPK", SqlDbType.UniqueIdentifier);
			if (entity.ACSupervisoryPK == Guid.Empty)
			{
				paras[0].Value = DBNull.Value;
			}
			else
			{
				paras[0].Value = entity.ACSupervisoryPK;
			}
			paras[1] = new SqlParameter("@ACPanelPK", SqlDbType.UniqueIdentifier);
			if (entity.ACPanelPK == Guid.Empty)
			{
				paras[1].Value = DBNull.Value;
			}
			else
			{
				paras[1].Value = entity.ACPanelPK;
			}
			paras[2] = new SqlParameter("@SupervisoryID", SqlDbType.TinyInt);
			paras[2].Value = entity.SupervisoryID;
			paras[3] = new SqlParameter("@Description", SqlDbType.VarChar, 30);
			paras[3].Value = entity.Description;
			paras[4] = new SqlParameter("@Debounce", SqlDbType.SmallInt);
			paras[4].Value = entity.Debounce;
			paras[5] = new SqlParameter("@ForceAMFormat", SqlDbType.SmallInt);
			paras[5].Value = entity.ForceAMFormat;
			paras[6] = new SqlParameter("@External", SqlDbType.Bit);
			paras[6].Value = entity.External;
			paras[7] = new SqlParameter("@Notes", SqlDbType.VarChar, 512);
			paras[7].Value = entity.Notes;
			paras[8] = new SqlParameter("@RowVersion", SqlDbType.Timestamp);
			paras[8].Value = entity.RowVersion;
			paras[9] = new SqlParameter("@CreatedOn", SqlDbType.DateTime);
			paras[9].Value = entity.CreatedOn;
			paras[10] = new SqlParameter("@CreatedBy", SqlDbType.VarChar, 30);
			paras[10].Value = entity.CreatedBy;
			paras[11] = new SqlParameter("@ModifiedOn", SqlDbType.DateTime);
			paras[11].Value = entity.ModifiedOn;
			paras[12] = new SqlParameter("@ModifiedBy", SqlDbType.VarChar, 30);
			paras[12].Value = entity.ModifiedBy;
			paras[13] = new SqlParameter("@PanelZoneID", SqlDbType.TinyInt);
			paras[13].Value = entity.PanelZoneID;
			paras[14] = new SqlParameter("@Locked", SqlDbType.Bit);
			paras[14].Value = entity.Locked;
			return base.ExecuteNonQuery(sql, paras);
		}

		private ACSupervisoryData CreateDataByReader(SafeDataReader reader)
		{
			ACSupervisoryData data = new ACSupervisoryData {
				ACSupervisoryPK = (Guid) reader["ACSupervisoryPK"],
				ACPanelPK = (Guid) reader["ACPanelPK"],
				SupervisoryID = (Byte) reader["SupervisoryID"],
				Description = (String) reader["Description"],
				Debounce = (Int16) reader["Debounce"],
				ForceAMFormat = (Int16) reader["ForceAMFormat"],
				External = (Boolean) reader["External"],
				Notes = (String) reader["Notes"],
				RowVersion = (Byte[]) reader["RowVersion"],
				CreatedOn = (DateTime) reader["CreatedOn"],
				CreatedBy = (String) reader["CreatedBy"],
				ModifiedOn = (DateTime) reader["ModifiedOn"],
				ModifiedBy = (String) reader["ModifiedBy"],
				PanelZoneID = (Byte) reader["PanelZoneID"],
				Locked = (Boolean) reader["Locked"],
				BDBuildingPK = (Guid) reader["BDBuildingPK"],
				UnitID = (Int32) reader["UnitID"],
				Address1 = (String) reader["Address1"],
				BuildingID = (Int32) reader["BuildingID"]
			};
			data.AcceptChanges();
			return data;
		}

		private ACSupervisoryData FetchEntity(string where, SqlParameter[] paras)
		{
			ACSupervisoryData data = null;
			using (SafeDataReader reader = base.ExecuteDataReader(where, paras))
			{
				if (reader.Read())
				{
					data = this.CreateDataByReader(reader);
				}
				reader.Close();
			}
			return data;
		}

		private ACSupervisoryData FetchEntityEx(string sql, SqlParameter[] paras)
		{
			ACSupervisoryData data = null;
			using (SafeDataReader reader = base.ExecuteDataReaderEx(sql, paras))
			{
				if (reader.Read())
				{
					data = this.CreateDataByReader(reader);
				}
				reader.Close();
			}
			return data;
		}

		private ACSupervisoryDataCollection FetchCollection(string where, SqlParameter[] paras)
		{
			ACSupervisoryDataCollection list = new ACSupervisoryDataCollection();
			using (SafeDataReader reader = base.ExecuteDataReader(where, paras))
			{
				while(reader.Read())
				{
					ACSupervisoryData data = this.CreateDataByReader(reader);
					list.Add(data);
				}
				reader.Close();
			}
			return list;
		}

		private ACSupervisoryDataCollection FetchCollectionEx(string sql, SqlParameter[] paras)
		{
			ACSupervisoryDataCollection list = new ACSupervisoryDataCollection();
			using (SafeDataReader reader = base.ExecuteDataReaderEx(sql, paras))
			{
				while(reader.Read())
				{
					ACSupervisoryData data = this.CreateDataByReader(reader);
					list.Add(data);
				}
				reader.Close();
			}
			return list;
		}

		public ACSupervisoryData GetEntityBy(string sqlWhere, SqlParameter[] paras)
		{
			return this.FetchEntity(sqlWhere, paras);
		}

		public ACSupervisoryData GetEntityExBy(string sql, SqlParameter[] paras)
		{
			return this.FetchEntityEx(sql, paras);
		}

		public ACSupervisoryDataCollection GetCollectionBy(string sqlWhere, SqlParameter[] paras)
		{
			return this.FetchCollection(sqlWhere, paras);
		}

		public ACSupervisoryDataCollection GetCollectionExBy(string sql, SqlParameter[] paras)
		{
			return this.FetchCollectionEx(sql, paras);
		}

		public byte[] GetRowVersion( System.Guid ACSupervisoryPK)
		{
			string sql = string.Format("SELECT [RowVersion] AS [RowVersion] FROM [{0}] WHERE  [ACSupervisoryPK] = @ACSupervisoryPK ", this.TableName);
			SqlParameter[] paras = new SqlParameter[1];
			paras[0] = new SqlParameter("@ACSupervisoryPK", SqlDbType.UniqueIdentifier, 16);
			paras[0].Value = ACSupervisoryPK;
			return (byte[]) base.ExecuteScalar(sql, paras);
		}

		public ACSupervisoryData GetByPK( System.Guid ACSupervisoryPK)
		{
			string sql = " WHERE  [ACSupervisory].[ACSupervisoryPK] = @ACSupervisoryPK ";
			SqlParameter[] paras = new SqlParameter[1];
			paras[0] = new SqlParameter("@ACSupervisoryPK", SqlDbType.UniqueIdentifier);
			paras[0].Value = ACSupervisoryPK;
			return this.FetchEntity(sql, paras);
		}

		public ACSupervisoryDataCollection GetAll()
		{
			return this.FetchCollection("", null);
		}

		public ACSupervisoryDataCollection GetByACPanel(System.Guid ACPanelPK)
		{
			string sqlWhere = " WHERE [ACSupervisory].[ACPanelPK] = @ACPanelPK";
			SqlParameter[] paras = new SqlParameter[1];
			paras[0] = new SqlParameter("@ACPanelPK", SqlDbType.UniqueIdentifier);
			paras[0].Value = ACPanelPK;
			return this.FetchCollection(sqlWhere, paras);
		}

		public DataTable GetLogByPK( System.Guid ACSupervisoryPK)
		{
			string sql = string.Format("SELECT  [ACSupervisory].[ACSupervisoryPK] AS [ACSupervisoryPK], [ACSupervisory].[ModifiedOn] AS [ModifiedOn] FROM [{0}] WHERE  [ACSupervisory].[ACSupervisoryPK] = @ACSupervisoryPK ", this.TableName);
			SqlParameter[] paras = new SqlParameter[1];
			paras[0] = new SqlParameter("@ACSupervisoryPK", SqlDbType.UniqueIdentifier);
			paras[0].Value = ACSupervisoryPK;
			return this.ExecuteDataTable(sql, paras);
		}

		public DataTable GetLogByACPanel(System.Guid aCPanelPK)
		{
			string sql = string.Format("DELETE [{0}] FROM [{0}] [ACSupervisory] INNER JOIN [ACPanel] ON [ACSupervisory].[ACPanelPK] = [ACPanel].[ACPanelPK] WHERE [ACPanel].[ACPanelPK] = @ACPanelPK;", this.TableName);
			string oldValue = string.Format("DELETE [{0}]", this.TableName);
			string newValue = "SELECT  [ACSupervisory].[ACSupervisoryPK] AS [ACSupervisoryPK], [ACSupervisory].[ModifiedOn] AS [ModifiedOn]";
			sql = sql.Replace(oldValue, newValue).TrimEnd().TrimEnd(';').Replace(";", " UNION ");
			SqlParameter[] paras = new SqlParameter[1];
			paras[0] = new SqlParameter("@ACPanelPK", SqlDbType.UniqueIdentifier);
			paras[0].Value = aCPanelPK;
			return base.ExecuteDataTable(sql, paras);
		}

		public DataTable GetLogByBDBuilding(System.Guid bDBuildingPK)
		{
			string sql = string.Format("DELETE [{0}] FROM [{0}] [ACSupervisory] INNER JOIN [ACPanel] ON [ACSupervisory].[ACPanelPK] = [ACPanel].[ACPanelPK] INNER JOIN [BDBuilding] ON [ACPanel].[BDBuildingPK] = [BDBuilding].[BDBuildingPK] WHERE [BDBuilding].[BDBuildingPK] = @BDBuildingPK;", this.TableName);
			string oldValue = string.Format("DELETE [{0}]", this.TableName);
			string newValue = "SELECT  [ACSupervisory].[ACSupervisoryPK] AS [ACSupervisoryPK], [ACSupervisory].[ModifiedOn] AS [ModifiedOn]";
			sql = sql.Replace(oldValue, newValue).TrimEnd().TrimEnd(';').Replace(";", " UNION ");
			SqlParameter[] paras = new SqlParameter[1];
			paras[0] = new SqlParameter("@BDBuildingPK", SqlDbType.UniqueIdentifier);
			paras[0].Value = bDBuildingPK;
			return base.ExecuteDataTable(sql, paras);
		}

		public int DeleteByPK( System.Guid ACSupervisoryPK, byte[] RowVersion)
		{
			string sql = string.Format("DELETE FROM [{0}] WHERE  [ACSupervisoryPK] = @ACSupervisoryPK AND [RowVersion] = @RowVersion", this.TableName);
			SqlParameter[] paras = new SqlParameter[2];
			paras[0] = new SqlParameter("@ACSupervisoryPK", SqlDbType.UniqueIdentifier);
			paras[0].Value = ACSupervisoryPK;
			paras[1] = new SqlParameter("@RowVersion", SqlDbType.Timestamp, 8);
			paras[1].Value = RowVersion;
			return base.ExecuteNonQuery(sql, paras);
		}

		public int DeleteAll()
		{
			string sql = string.Format("DELETE FROM [{0}]", this.TableName);
			return base.ExecuteNonQuery(sql, null);
		}

		public int DeleteByACPanel(System.Guid aCPanelPK)
		{
			string sql = string.Format("DELETE [{0}] FROM [{0}] [ACSupervisory] INNER JOIN [ACPanel] ON [ACSupervisory].[ACPanelPK] = [ACPanel].[ACPanelPK] WHERE [ACPanel].[ACPanelPK] = @ACPanelPK;", this.TableName);
			SqlParameter[] paras = new SqlParameter[1];
			paras[0] = new SqlParameter("@ACPanelPK", SqlDbType.UniqueIdentifier);
			paras[0].Value = aCPanelPK;
			return base.ExecuteNonQuery(sql, paras);
		}

		public int DeleteByBDBuilding(System.Guid bDBuildingPK)
		{
			string sql = string.Format("DELETE [{0}] FROM [{0}] [ACSupervisory] INNER JOIN [ACPanel] ON [ACSupervisory].[ACPanelPK] = [ACPanel].[ACPanelPK] INNER JOIN [BDBuilding] ON [ACPanel].[BDBuildingPK] = [BDBuilding].[BDBuildingPK] WHERE [BDBuilding].[BDBuildingPK] = @BDBuildingPK;", this.TableName);
			SqlParameter[] paras = new SqlParameter[1];
			paras[0] = new SqlParameter("@BDBuildingPK", SqlDbType.UniqueIdentifier);
			paras[0].Value = bDBuildingPK;
			return base.ExecuteNonQuery(sql, paras);
		}


	}
	public class UsrGroupCRUD : DataAccessBase
	{
		private string _tableName = "UsrGroup";

		public UsrGroupCRUD(string connectionString) : base(connectionString)
		{
		}

		public virtual string TableName
		{
			get { return this._tableName; }
			set { this._tableName = value; }
		}

		public string SQLColumns
		{
			get
			{
				return "[UsrGroup].[UsrGroupPK] AS [UsrGroupPK],[UsrGroup].[UsrGroupName] AS [UsrGroupName],[UsrGroup].[Description] AS [Description],[UsrGroup].[RowVersion] AS [RowVersion],[UsrGroup].[CreatedOn] AS [CreatedOn],[UsrGroup].[CreatedBy] AS [CreatedBy],[UsrGroup].[ModifiedOn] AS [ModifiedOn],[UsrGroup].[ModifiedBy] AS [ModifiedBy]";
			}
		}

		public string SQLLeftJoins
		{
			get
			{
				return "";
			}
		}

		protected override string SQLSelect
		{
			get
			{
				return string.Format("SELECT [UsrGroup].[UsrGroupPK] AS [UsrGroupPK],[UsrGroup].[UsrGroupName] AS [UsrGroupName],[UsrGroup].[Description] AS [Description],[UsrGroup].[RowVersion] AS [RowVersion],[UsrGroup].[CreatedOn] AS [CreatedOn],[UsrGroup].[CreatedBy] AS [CreatedBy],[UsrGroup].[ModifiedOn] AS [ModifiedOn],[UsrGroup].[ModifiedBy] AS [ModifiedBy] FROM [{0}] [UsrGroup] ", this.TableName);
			}
		}

		protected override string SQLCount
		{
			get
			{
				return string.Format("SELECT COUNT(*) FROM [{0}] [UsrGroup] ", this.TableName);
			}
		}

		public int Insert(UsrGroupData entity)
		{
			string sql = string.Format("INSERT INTO [{0}] ([UsrGroupPK],[UsrGroupName],[Description],[CreatedOn],[CreatedBy],[ModifiedOn],[ModifiedBy]) VALUES(@UsrGroupPK,@UsrGroupName,@Description,@CreatedOn,@CreatedBy,@ModifiedOn,@ModifiedBy)", this.TableName);
			SqlParameter[] paras = new SqlParameter[7];
			paras[0] = new SqlParameter("@UsrGroupPK", SqlDbType.UniqueIdentifier);
			if (entity.UsrGroupPK == Guid.Empty)
			{
				paras[0].Value = DBNull.Value;
			}
			else
			{
				paras[0].Value = entity.UsrGroupPK;
			}
			paras[1] = new SqlParameter("@UsrGroupName", SqlDbType.VarChar, 50);
			paras[1].Value = entity.UsrGroupName;
			paras[2] = new SqlParameter("@Description", SqlDbType.VarChar, 256);
			paras[2].Value = entity.Description;
			paras[3] = new SqlParameter("@CreatedOn", SqlDbType.DateTime);
			paras[3].Value = entity.CreatedOn;
			paras[4] = new SqlParameter("@CreatedBy", SqlDbType.VarChar, 30);
			paras[4].Value = entity.CreatedBy;
			paras[5] = new SqlParameter("@ModifiedOn", SqlDbType.DateTime);
			paras[5].Value = entity.ModifiedOn;
			paras[6] = new SqlParameter("@ModifiedBy", SqlDbType.VarChar, 30);
			paras[6].Value = entity.ModifiedBy;
			return base.ExecuteNonQuery(sql, paras);
		}

		public int Update(UsrGroupData entity)
		{
			string sql = string.Format("UPDATE [{0}] SET [UsrGroupName] = @UsrGroupName,[Description] = @Description,[CreatedOn] = @CreatedOn,[CreatedBy] = @CreatedBy,[ModifiedOn] = @ModifiedOn,[ModifiedBy] = @ModifiedBy  WHERE [UsrGroupPK] = @UsrGroupPK AND [RowVersion] = @RowVersion", this.TableName);
			SqlParameter[] paras = new SqlParameter[8];
			paras[0] = new SqlParameter("@UsrGroupPK", SqlDbType.UniqueIdentifier);
			if (entity.UsrGroupPK == Guid.Empty)
			{
				paras[0].Value = DBNull.Value;
			}
			else
			{
				paras[0].Value = entity.UsrGroupPK;
			}
			paras[1] = new SqlParameter("@UsrGroupName", SqlDbType.VarChar, 50);
			paras[1].Value = entity.UsrGroupName;
			paras[2] = new SqlParameter("@Description", SqlDbType.VarChar, 256);
			paras[2].Value = entity.Description;
			paras[3] = new SqlParameter("@RowVersion", SqlDbType.Timestamp);
			paras[3].Value = entity.RowVersion;
			paras[4] = new SqlParameter("@CreatedOn", SqlDbType.DateTime);
			paras[4].Value = entity.CreatedOn;
			paras[5] = new SqlParameter("@CreatedBy", SqlDbType.VarChar, 30);
			paras[5].Value = entity.CreatedBy;
			paras[6] = new SqlParameter("@ModifiedOn", SqlDbType.DateTime);
			paras[6].Value = entity.ModifiedOn;
			paras[7] = new SqlParameter("@ModifiedBy", SqlDbType.VarChar, 30);
			paras[7].Value = entity.ModifiedBy;
			return base.ExecuteNonQuery(sql, paras);
		}

		private UsrGroupData CreateDataByReader(SafeDataReader reader)
		{
			UsrGroupData data = new UsrGroupData {
				UsrGroupPK = (Guid) reader["UsrGroupPK"],
				UsrGroupName = (String) reader["UsrGroupName"],
				Description = (String) reader["Description"],
				RowVersion = (Byte[]) reader["RowVersion"],
				CreatedOn = (DateTime) reader["CreatedOn"],
				CreatedBy = (String) reader["CreatedBy"],
				ModifiedOn = (DateTime) reader["ModifiedOn"],
				ModifiedBy = (String) reader["ModifiedBy"]
			};
			data.AcceptChanges();
			return data;
		}

		private UsrGroupData FetchEntity(string where, SqlParameter[] paras)
		{
			UsrGroupData data = null;
			using (SafeDataReader reader = base.ExecuteDataReader(where, paras))
			{
				if (reader.Read())
				{
					data = this.CreateDataByReader(reader);
				}
				reader.Close();
			}
			return data;
		}

		private UsrGroupData FetchEntityEx(string sql, SqlParameter[] paras)
		{
			UsrGroupData data = null;
			using (SafeDataReader reader = base.ExecuteDataReaderEx(sql, paras))
			{
				if (reader.Read())
				{
					data = this.CreateDataByReader(reader);
				}
				reader.Close();
			}
			return data;
		}

		private UsrGroupDataCollection FetchCollection(string where, SqlParameter[] paras)
		{
			UsrGroupDataCollection list = new UsrGroupDataCollection();
			using (SafeDataReader reader = base.ExecuteDataReader(where, paras))
			{
				while(reader.Read())
				{
					UsrGroupData data = this.CreateDataByReader(reader);
					list.Add(data);
				}
				reader.Close();
			}
			return list;
		}

		private UsrGroupDataCollection FetchCollectionEx(string sql, SqlParameter[] paras)
		{
			UsrGroupDataCollection list = new UsrGroupDataCollection();
			using (SafeDataReader reader = base.ExecuteDataReaderEx(sql, paras))
			{
				while(reader.Read())
				{
					UsrGroupData data = this.CreateDataByReader(reader);
					list.Add(data);
				}
				reader.Close();
			}
			return list;
		}

		public UsrGroupData GetEntityBy(string sqlWhere, SqlParameter[] paras)
		{
			return this.FetchEntity(sqlWhere, paras);
		}

		public UsrGroupData GetEntityExBy(string sql, SqlParameter[] paras)
		{
			return this.FetchEntityEx(sql, paras);
		}

		public UsrGroupDataCollection GetCollectionBy(string sqlWhere, SqlParameter[] paras)
		{
			return this.FetchCollection(sqlWhere, paras);
		}

		public UsrGroupDataCollection GetCollectionExBy(string sql, SqlParameter[] paras)
		{
			return this.FetchCollectionEx(sql, paras);
		}

		public byte[] GetRowVersion( System.Guid UsrGroupPK)
		{
			string sql = string.Format("SELECT [RowVersion] AS [RowVersion] FROM [{0}] WHERE  [UsrGroupPK] = @UsrGroupPK ", this.TableName);
			SqlParameter[] paras = new SqlParameter[1];
			paras[0] = new SqlParameter("@UsrGroupPK", SqlDbType.UniqueIdentifier, 16);
			paras[0].Value = UsrGroupPK;
			return (byte[]) base.ExecuteScalar(sql, paras);
		}

		public UsrGroupData GetByPK( System.Guid UsrGroupPK)
		{
			string sql = " WHERE  [UsrGroup].[UsrGroupPK] = @UsrGroupPK ";
			SqlParameter[] paras = new SqlParameter[1];
			paras[0] = new SqlParameter("@UsrGroupPK", SqlDbType.UniqueIdentifier);
			paras[0].Value = UsrGroupPK;
			return this.FetchEntity(sql, paras);
		}

		public UsrGroupDataCollection GetAll()
		{
			return this.FetchCollection("", null);
		}

		public DataTable GetLogByPK( System.Guid UsrGroupPK)
		{
			string sql = string.Format("SELECT  [UsrGroup].[UsrGroupPK] AS [UsrGroupPK], [UsrGroup].[ModifiedOn] AS [ModifiedOn] FROM [{0}] WHERE  [UsrGroup].[UsrGroupPK] = @UsrGroupPK ", this.TableName);
			SqlParameter[] paras = new SqlParameter[1];
			paras[0] = new SqlParameter("@UsrGroupPK", SqlDbType.UniqueIdentifier);
			paras[0].Value = UsrGroupPK;
			return this.ExecuteDataTable(sql, paras);
		}

		public int DeleteByPK( System.Guid UsrGroupPK, byte[] RowVersion)
		{
			string sql = string.Format("DELETE FROM [{0}] WHERE  [UsrGroupPK] = @UsrGroupPK AND [RowVersion] = @RowVersion", this.TableName);
			SqlParameter[] paras = new SqlParameter[2];
			paras[0] = new SqlParameter("@UsrGroupPK", SqlDbType.UniqueIdentifier);
			paras[0].Value = UsrGroupPK;
			paras[1] = new SqlParameter("@RowVersion", SqlDbType.Timestamp, 8);
			paras[1].Value = RowVersion;
			return base.ExecuteNonQuery(sql, paras);
		}

		public int DeleteAll()
		{
			string sql = string.Format("DELETE FROM [{0}]", this.TableName);
			return base.ExecuteNonQuery(sql, null);
		}


	}
	public class ACCardHolderBuildingMapCRUD : DataAccessBase
	{
		private string _tableName = "ACCardHolderBuildingMap";

		public ACCardHolderBuildingMapCRUD(string connectionString) : base(connectionString)
		{
		}

		public virtual string TableName
		{
			get { return this._tableName; }
			set { this._tableName = value; }
		}

		public string SQLColumns
		{
			get
			{
				return "[ACCardHolderBuildingMap].[ACCardHolderBuildingMapPK] AS [ACCardHolderBuildingMapPK],[ACCardHolderBuildingMap].[ACCardHolderPK] AS [ACCardHolderPK],[ACCardHolderBuildingMap].[BDBuildingPK] AS [BDBuildingPK],[ACCardHolderBuildingMap].[AL1st] AS [AL1st],[ACCardHolderBuildingMap].[AL2nd] AS [AL2nd],[ACCardHolderBuildingMap].[RowVersion] AS [RowVersion],[ACCardHolderBuildingMap].[CreatedOn] AS [CreatedOn],[ACCardHolderBuildingMap].[CreatedBy] AS [CreatedBy],[ACCardHolderBuildingMap].[ModifiedOn] AS [ModifiedOn],[ACCardHolderBuildingMap].[ModifiedBy] AS [ModifiedBy],[BDBuilding].[Address1] AS [Address1],[BDBuilding].[BuildingID] AS [BuildingID],[ACCardHolder].[LastName] AS [LastName],[ACCardHolder].[FirstName] AS [FirstName],[ACCardHolder].[CardTypeID] AS [CardTypeID],[ACCardHolder].[Encoded] AS [Encoded],[ACCardHolder].[Embossed] AS [Embossed],[ACCardHolder].[Sitecode] AS [Sitecode]";
			}
		}

		public string SQLLeftJoins
		{
			get
			{
				return "LEFT JOIN [BDBuilding] [BDBuilding] ON [ACCardHolderBuildingMap].[BDBuildingPK] = [BDBuilding].[BDBuildingPK] LEFT JOIN [ACCardHolder] [ACCardHolder] ON [ACCardHolderBuildingMap].[ACCardHolderPK] = [ACCardHolder].[ACCardHolderPK]";
			}
		}

		protected override string SQLSelect
		{
			get
			{
				return string.Format("SELECT [ACCardHolderBuildingMap].[ACCardHolderBuildingMapPK] AS [ACCardHolderBuildingMapPK],[ACCardHolderBuildingMap].[ACCardHolderPK] AS [ACCardHolderPK],[ACCardHolderBuildingMap].[BDBuildingPK] AS [BDBuildingPK],[ACCardHolderBuildingMap].[AL1st] AS [AL1st],[ACCardHolderBuildingMap].[AL2nd] AS [AL2nd],[ACCardHolderBuildingMap].[RowVersion] AS [RowVersion],[ACCardHolderBuildingMap].[CreatedOn] AS [CreatedOn],[ACCardHolderBuildingMap].[CreatedBy] AS [CreatedBy],[ACCardHolderBuildingMap].[ModifiedOn] AS [ModifiedOn],[ACCardHolderBuildingMap].[ModifiedBy] AS [ModifiedBy],[BDBuilding].[Address1] AS [Address1],[BDBuilding].[BuildingID] AS [BuildingID],[ACCardHolder].[LastName] AS [LastName],[ACCardHolder].[FirstName] AS [FirstName],[ACCardHolder].[CardTypeID] AS [CardTypeID],[ACCardHolder].[Encoded] AS [Encoded],[ACCardHolder].[Embossed] AS [Embossed],[ACCardHolder].[Sitecode] AS [Sitecode] FROM [{0}] [ACCardHolderBuildingMap] LEFT JOIN [BDBuilding] [BDBuilding] ON [ACCardHolderBuildingMap].[BDBuildingPK] = [BDBuilding].[BDBuildingPK] LEFT JOIN [ACCardHolder] [ACCardHolder] ON [ACCardHolderBuildingMap].[ACCardHolderPK] = [ACCardHolder].[ACCardHolderPK]", this.TableName);
			}
		}

		protected override string SQLCount
		{
			get
			{
				return string.Format("SELECT COUNT(*) FROM [{0}] [ACCardHolderBuildingMap] LEFT JOIN [BDBuilding] [BDBuilding] ON [ACCardHolderBuildingMap].[BDBuildingPK] = [BDBuilding].[BDBuildingPK] LEFT JOIN [ACCardHolder] [ACCardHolder] ON [ACCardHolderBuildingMap].[ACCardHolderPK] = [ACCardHolder].[ACCardHolderPK]", this.TableName);
			}
		}

		public int Insert(ACCardHolderBuildingMapData entity)
		{
			string sql = string.Format("INSERT INTO [{0}] ([ACCardHolderBuildingMapPK],[ACCardHolderPK],[BDBuildingPK],[AL1st],[AL2nd],[CreatedOn],[CreatedBy],[ModifiedOn],[ModifiedBy]) VALUES(@ACCardHolderBuildingMapPK,@ACCardHolderPK,@BDBuildingPK,@AL1st,@AL2nd,@CreatedOn,@CreatedBy,@ModifiedOn,@ModifiedBy)", this.TableName);
			SqlParameter[] paras = new SqlParameter[9];
			paras[0] = new SqlParameter("@ACCardHolderBuildingMapPK", SqlDbType.UniqueIdentifier);
			if (entity.ACCardHolderBuildingMapPK == Guid.Empty)
			{
				paras[0].Value = DBNull.Value;
			}
			else
			{
				paras[0].Value = entity.ACCardHolderBuildingMapPK;
			}
			paras[1] = new SqlParameter("@ACCardHolderPK", SqlDbType.UniqueIdentifier);
			if (entity.ACCardHolderPK == Guid.Empty)
			{
				paras[1].Value = DBNull.Value;
			}
			else
			{
				paras[1].Value = entity.ACCardHolderPK;
			}
			paras[2] = new SqlParameter("@BDBuildingPK", SqlDbType.UniqueIdentifier);
			if (entity.BDBuildingPK == Guid.Empty)
			{
				paras[2].Value = DBNull.Value;
			}
			else
			{
				paras[2].Value = entity.BDBuildingPK;
			}
			paras[3] = new SqlParameter("@AL1st", SqlDbType.SmallInt);
			paras[3].Value = entity.AL1st;
			paras[4] = new SqlParameter("@AL2nd", SqlDbType.SmallInt);
			paras[4].Value = entity.AL2nd;
			paras[5] = new SqlParameter("@CreatedOn", SqlDbType.DateTime);
			paras[5].Value = entity.CreatedOn;
			paras[6] = new SqlParameter("@CreatedBy", SqlDbType.VarChar, 30);
			paras[6].Value = entity.CreatedBy;
			paras[7] = new SqlParameter("@ModifiedOn", SqlDbType.DateTime);
			paras[7].Value = entity.ModifiedOn;
			paras[8] = new SqlParameter("@ModifiedBy", SqlDbType.VarChar, 30);
			paras[8].Value = entity.ModifiedBy;
			return base.ExecuteNonQuery(sql, paras);
		}

		public int Update(ACCardHolderBuildingMapData entity)
		{
			string sql = string.Format("UPDATE [{0}] SET [ACCardHolderPK] = @ACCardHolderPK,[BDBuildingPK] = @BDBuildingPK,[AL1st] = @AL1st,[AL2nd] = @AL2nd,[CreatedOn] = @CreatedOn,[CreatedBy] = @CreatedBy,[ModifiedOn] = @ModifiedOn,[ModifiedBy] = @ModifiedBy  WHERE [ACCardHolderBuildingMapPK] = @ACCardHolderBuildingMapPK AND [RowVersion] = @RowVersion", this.TableName);
			SqlParameter[] paras = new SqlParameter[10];
			paras[0] = new SqlParameter("@ACCardHolderBuildingMapPK", SqlDbType.UniqueIdentifier);
			if (entity.ACCardHolderBuildingMapPK == Guid.Empty)
			{
				paras[0].Value = DBNull.Value;
			}
			else
			{
				paras[0].Value = entity.ACCardHolderBuildingMapPK;
			}
			paras[1] = new SqlParameter("@ACCardHolderPK", SqlDbType.UniqueIdentifier);
			if (entity.ACCardHolderPK == Guid.Empty)
			{
				paras[1].Value = DBNull.Value;
			}
			else
			{
				paras[1].Value = entity.ACCardHolderPK;
			}
			paras[2] = new SqlParameter("@BDBuildingPK", SqlDbType.UniqueIdentifier);
			if (entity.BDBuildingPK == Guid.Empty)
			{
				paras[2].Value = DBNull.Value;
			}
			else
			{
				paras[2].Value = entity.BDBuildingPK;
			}
			paras[3] = new SqlParameter("@AL1st", SqlDbType.SmallInt);
			paras[3].Value = entity.AL1st;
			paras[4] = new SqlParameter("@AL2nd", SqlDbType.SmallInt);
			paras[4].Value = entity.AL2nd;
			paras[5] = new SqlParameter("@RowVersion", SqlDbType.Timestamp);
			paras[5].Value = entity.RowVersion;
			paras[6] = new SqlParameter("@CreatedOn", SqlDbType.DateTime);
			paras[6].Value = entity.CreatedOn;
			paras[7] = new SqlParameter("@CreatedBy", SqlDbType.VarChar, 30);
			paras[7].Value = entity.CreatedBy;
			paras[8] = new SqlParameter("@ModifiedOn", SqlDbType.DateTime);
			paras[8].Value = entity.ModifiedOn;
			paras[9] = new SqlParameter("@ModifiedBy", SqlDbType.VarChar, 30);
			paras[9].Value = entity.ModifiedBy;
			return base.ExecuteNonQuery(sql, paras);
		}

		private ACCardHolderBuildingMapData CreateDataByReader(SafeDataReader reader)
		{
			ACCardHolderBuildingMapData data = new ACCardHolderBuildingMapData {
				ACCardHolderBuildingMapPK = (Guid) reader["ACCardHolderBuildingMapPK"],
				ACCardHolderPK = (Guid) reader["ACCardHolderPK"],
				BDBuildingPK = (Guid) reader["BDBuildingPK"],
				AL1st = (Int16) reader["AL1st"],
				AL2nd = (Int16) reader["AL2nd"],
				RowVersion = (Byte[]) reader["RowVersion"],
				CreatedOn = (DateTime) reader["CreatedOn"],
				CreatedBy = (String) reader["CreatedBy"],
				ModifiedOn = (DateTime) reader["ModifiedOn"],
				ModifiedBy = (String) reader["ModifiedBy"],
				Address1 = (String) reader["Address1"],
				BuildingID = (Int32) reader["BuildingID"],
				LastName = (String) reader["LastName"],
				FirstName = (String) reader["FirstName"],
				CardTypeID = (Int32) reader["CardTypeID"],
				Encoded = (Int32) reader["Encoded"],
				Embossed = (Int32) reader["Embossed"],
				Sitecode = (Int32) reader["Sitecode"]
			};
			data.AcceptChanges();
			return data;
		}

		private ACCardHolderBuildingMapData FetchEntity(string where, SqlParameter[] paras)
		{
			ACCardHolderBuildingMapData data = null;
			using (SafeDataReader reader = base.ExecuteDataReader(where, paras))
			{
				if (reader.Read())
				{
					data = this.CreateDataByReader(reader);
				}
				reader.Close();
			}
			return data;
		}

		private ACCardHolderBuildingMapData FetchEntityEx(string sql, SqlParameter[] paras)
		{
			ACCardHolderBuildingMapData data = null;
			using (SafeDataReader reader = base.ExecuteDataReaderEx(sql, paras))
			{
				if (reader.Read())
				{
					data = this.CreateDataByReader(reader);
				}
				reader.Close();
			}
			return data;
		}

		private ACCardHolderBuildingMapDataCollection FetchCollection(string where, SqlParameter[] paras)
		{
			ACCardHolderBuildingMapDataCollection list = new ACCardHolderBuildingMapDataCollection();
			using (SafeDataReader reader = base.ExecuteDataReader(where, paras))
			{
				while(reader.Read())
				{
					ACCardHolderBuildingMapData data = this.CreateDataByReader(reader);
					list.Add(data);
				}
				reader.Close();
			}
			return list;
		}

		private ACCardHolderBuildingMapDataCollection FetchCollectionEx(string sql, SqlParameter[] paras)
		{
			ACCardHolderBuildingMapDataCollection list = new ACCardHolderBuildingMapDataCollection();
			using (SafeDataReader reader = base.ExecuteDataReaderEx(sql, paras))
			{
				while(reader.Read())
				{
					ACCardHolderBuildingMapData data = this.CreateDataByReader(reader);
					list.Add(data);
				}
				reader.Close();
			}
			return list;
		}

		public ACCardHolderBuildingMapData GetEntityBy(string sqlWhere, SqlParameter[] paras)
		{
			return this.FetchEntity(sqlWhere, paras);
		}

		public ACCardHolderBuildingMapData GetEntityExBy(string sql, SqlParameter[] paras)
		{
			return this.FetchEntityEx(sql, paras);
		}

		public ACCardHolderBuildingMapDataCollection GetCollectionBy(string sqlWhere, SqlParameter[] paras)
		{
			return this.FetchCollection(sqlWhere, paras);
		}

		public ACCardHolderBuildingMapDataCollection GetCollectionExBy(string sql, SqlParameter[] paras)
		{
			return this.FetchCollectionEx(sql, paras);
		}

		public byte[] GetRowVersion( System.Guid ACCardHolderBuildingMapPK)
		{
			string sql = string.Format("SELECT [RowVersion] AS [RowVersion] FROM [{0}] WHERE  [ACCardHolderBuildingMapPK] = @ACCardHolderBuildingMapPK ", this.TableName);
			SqlParameter[] paras = new SqlParameter[1];
			paras[0] = new SqlParameter("@ACCardHolderBuildingMapPK", SqlDbType.UniqueIdentifier, 16);
			paras[0].Value = ACCardHolderBuildingMapPK;
			return (byte[]) base.ExecuteScalar(sql, paras);
		}

		public ACCardHolderBuildingMapData GetByPK( System.Guid ACCardHolderBuildingMapPK)
		{
			string sql = " WHERE  [ACCardHolderBuildingMap].[ACCardHolderBuildingMapPK] = @ACCardHolderBuildingMapPK ";
			SqlParameter[] paras = new SqlParameter[1];
			paras[0] = new SqlParameter("@ACCardHolderBuildingMapPK", SqlDbType.UniqueIdentifier);
			paras[0].Value = ACCardHolderBuildingMapPK;
			return this.FetchEntity(sql, paras);
		}

		public ACCardHolderBuildingMapDataCollection GetAll()
		{
			return this.FetchCollection("", null);
		}

		public ACCardHolderBuildingMapDataCollection GetByBDBuilding(System.Guid BDBuildingPK)
		{
			string sqlWhere = " WHERE [ACCardHolderBuildingMap].[BDBuildingPK] = @BDBuildingPK";
			SqlParameter[] paras = new SqlParameter[1];
			paras[0] = new SqlParameter("@BDBuildingPK", SqlDbType.UniqueIdentifier);
			paras[0].Value = BDBuildingPK;
			return this.FetchCollection(sqlWhere, paras);
		}

		public ACCardHolderBuildingMapDataCollection GetByACCardHolder(System.Guid ACCardHolderPK)
		{
			string sqlWhere = " WHERE [ACCardHolderBuildingMap].[ACCardHolderPK] = @ACCardHolderPK";
			SqlParameter[] paras = new SqlParameter[1];
			paras[0] = new SqlParameter("@ACCardHolderPK", SqlDbType.UniqueIdentifier);
			paras[0].Value = ACCardHolderPK;
			return this.FetchCollection(sqlWhere, paras);
		}

		public DataTable GetLogByPK( System.Guid ACCardHolderBuildingMapPK)
		{
			string sql = string.Format("SELECT  [ACCardHolderBuildingMap].[ACCardHolderBuildingMapPK] AS [ACCardHolderBuildingMapPK], [ACCardHolderBuildingMap].[ModifiedOn] AS [ModifiedOn] FROM [{0}] WHERE  [ACCardHolderBuildingMap].[ACCardHolderBuildingMapPK] = @ACCardHolderBuildingMapPK ", this.TableName);
			SqlParameter[] paras = new SqlParameter[1];
			paras[0] = new SqlParameter("@ACCardHolderBuildingMapPK", SqlDbType.UniqueIdentifier);
			paras[0].Value = ACCardHolderBuildingMapPK;
			return this.ExecuteDataTable(sql, paras);
		}

		public DataTable GetLogByBDBuilding(System.Guid bDBuildingPK)
		{
			string sql = string.Format("DELETE [{0}] FROM [{0}] [ACCardHolderBuildingMap] INNER JOIN [BDBuilding] ON [ACCardHolderBuildingMap].[BDBuildingPK] = [BDBuilding].[BDBuildingPK] WHERE [BDBuilding].[BDBuildingPK] = @BDBuildingPK;DELETE [{0}] FROM [{0}] [ACCardHolderBuildingMap] INNER JOIN [ACCardHolder] ON [ACCardHolderBuildingMap].[ACCardHolderPK] = [ACCardHolder].[ACCardHolderPK] INNER JOIN [BDTenant] ON [ACCardHolder].[BDTenantPK] = [BDTenant].[BDTenantPK] INNER JOIN [BDBuilding] ON [BDTenant].[BDBuildingPK] = [BDBuilding].[BDBuildingPK] WHERE [BDBuilding].[BDBuildingPK] = @BDBuildingPK;", this.TableName);
			string oldValue = string.Format("DELETE [{0}]", this.TableName);
			string newValue = "SELECT  [ACCardHolderBuildingMap].[ACCardHolderBuildingMapPK] AS [ACCardHolderBuildingMapPK], [ACCardHolderBuildingMap].[ModifiedOn] AS [ModifiedOn]";
			sql = sql.Replace(oldValue, newValue).TrimEnd().TrimEnd(';').Replace(";", " UNION ");
			SqlParameter[] paras = new SqlParameter[1];
			paras[0] = new SqlParameter("@BDBuildingPK", SqlDbType.UniqueIdentifier);
			paras[0].Value = bDBuildingPK;
			return base.ExecuteDataTable(sql, paras);
		}

		public DataTable GetLogByACCardHolder(System.Guid aCCardHolderPK)
		{
			string sql = string.Format("DELETE [{0}] FROM [{0}] [ACCardHolderBuildingMap] INNER JOIN [ACCardHolder] ON [ACCardHolderBuildingMap].[ACCardHolderPK] = [ACCardHolder].[ACCardHolderPK] WHERE [ACCardHolder].[ACCardHolderPK] = @ACCardHolderPK;", this.TableName);
			string oldValue = string.Format("DELETE [{0}]", this.TableName);
			string newValue = "SELECT  [ACCardHolderBuildingMap].[ACCardHolderBuildingMapPK] AS [ACCardHolderBuildingMapPK], [ACCardHolderBuildingMap].[ModifiedOn] AS [ModifiedOn]";
			sql = sql.Replace(oldValue, newValue).TrimEnd().TrimEnd(';').Replace(";", " UNION ");
			SqlParameter[] paras = new SqlParameter[1];
			paras[0] = new SqlParameter("@ACCardHolderPK", SqlDbType.UniqueIdentifier);
			paras[0].Value = aCCardHolderPK;
			return base.ExecuteDataTable(sql, paras);
		}

		public DataTable GetLogByBDTenant(System.Guid bDTenantPK)
		{
			string sql = string.Format("DELETE [{0}] FROM [{0}] [ACCardHolderBuildingMap] INNER JOIN [ACCardHolder] ON [ACCardHolderBuildingMap].[ACCardHolderPK] = [ACCardHolder].[ACCardHolderPK] INNER JOIN [BDTenant] ON [ACCardHolder].[BDTenantPK] = [BDTenant].[BDTenantPK] WHERE [BDTenant].[BDTenantPK] = @BDTenantPK;", this.TableName);
			string oldValue = string.Format("DELETE [{0}]", this.TableName);
			string newValue = "SELECT  [ACCardHolderBuildingMap].[ACCardHolderBuildingMapPK] AS [ACCardHolderBuildingMapPK], [ACCardHolderBuildingMap].[ModifiedOn] AS [ModifiedOn]";
			sql = sql.Replace(oldValue, newValue).TrimEnd().TrimEnd(';').Replace(";", " UNION ");
			SqlParameter[] paras = new SqlParameter[1];
			paras[0] = new SqlParameter("@BDTenantPK", SqlDbType.UniqueIdentifier);
			paras[0].Value = bDTenantPK;
			return base.ExecuteDataTable(sql, paras);
		}

		public int DeleteByPK( System.Guid ACCardHolderBuildingMapPK, byte[] RowVersion)
		{
			string sql = string.Format("DELETE FROM [{0}] WHERE  [ACCardHolderBuildingMapPK] = @ACCardHolderBuildingMapPK AND [RowVersion] = @RowVersion", this.TableName);
			SqlParameter[] paras = new SqlParameter[2];
			paras[0] = new SqlParameter("@ACCardHolderBuildingMapPK", SqlDbType.UniqueIdentifier);
			paras[0].Value = ACCardHolderBuildingMapPK;
			paras[1] = new SqlParameter("@RowVersion", SqlDbType.Timestamp, 8);
			paras[1].Value = RowVersion;
			return base.ExecuteNonQuery(sql, paras);
		}

		public int DeleteAll()
		{
			string sql = string.Format("DELETE FROM [{0}]", this.TableName);
			return base.ExecuteNonQuery(sql, null);
		}

		public int DeleteByBDBuilding(System.Guid bDBuildingPK)
		{
			string sql = string.Format("DELETE [{0}] FROM [{0}] [ACCardHolderBuildingMap] INNER JOIN [BDBuilding] ON [ACCardHolderBuildingMap].[BDBuildingPK] = [BDBuilding].[BDBuildingPK] WHERE [BDBuilding].[BDBuildingPK] = @BDBuildingPK;DELETE [{0}] FROM [{0}] [ACCardHolderBuildingMap] INNER JOIN [ACCardHolder] ON [ACCardHolderBuildingMap].[ACCardHolderPK] = [ACCardHolder].[ACCardHolderPK] INNER JOIN [BDTenant] ON [ACCardHolder].[BDTenantPK] = [BDTenant].[BDTenantPK] INNER JOIN [BDBuilding] ON [BDTenant].[BDBuildingPK] = [BDBuilding].[BDBuildingPK] WHERE [BDBuilding].[BDBuildingPK] = @BDBuildingPK;", this.TableName);
			SqlParameter[] paras = new SqlParameter[1];
			paras[0] = new SqlParameter("@BDBuildingPK", SqlDbType.UniqueIdentifier);
			paras[0].Value = bDBuildingPK;
			return base.ExecuteNonQuery(sql, paras);
		}

		public int DeleteByACCardHolder(System.Guid aCCardHolderPK)
		{
			string sql = string.Format("DELETE [{0}] FROM [{0}] [ACCardHolderBuildingMap] INNER JOIN [ACCardHolder] ON [ACCardHolderBuildingMap].[ACCardHolderPK] = [ACCardHolder].[ACCardHolderPK] WHERE [ACCardHolder].[ACCardHolderPK] = @ACCardHolderPK;", this.TableName);
			SqlParameter[] paras = new SqlParameter[1];
			paras[0] = new SqlParameter("@ACCardHolderPK", SqlDbType.UniqueIdentifier);
			paras[0].Value = aCCardHolderPK;
			return base.ExecuteNonQuery(sql, paras);
		}

		public int DeleteByBDTenant(System.Guid bDTenantPK)
		{
			string sql = string.Format("DELETE [{0}] FROM [{0}] [ACCardHolderBuildingMap] INNER JOIN [ACCardHolder] ON [ACCardHolderBuildingMap].[ACCardHolderPK] = [ACCardHolder].[ACCardHolderPK] INNER JOIN [BDTenant] ON [ACCardHolder].[BDTenantPK] = [BDTenant].[BDTenantPK] WHERE [BDTenant].[BDTenantPK] = @BDTenantPK;", this.TableName);
			SqlParameter[] paras = new SqlParameter[1];
			paras[0] = new SqlParameter("@BDTenantPK", SqlDbType.UniqueIdentifier);
			paras[0].Value = bDTenantPK;
			return base.ExecuteNonQuery(sql, paras);
		}


	}
	public class BDVisitorCRUD : DataAccessBase
	{
		private string _tableName = "BDVisitor";

		public BDVisitorCRUD(string connectionString) : base(connectionString)
		{
		}

		public virtual string TableName
		{
			get { return this._tableName; }
			set { this._tableName = value; }
		}

		public string SQLColumns
		{
			get
			{
				return "[BDVisitor].[BDVisitorPK] AS [BDVisitorPK],[BDVisitor].[BDTenantPK] AS [BDTenantPK],[BDVisitor].[FirstName] AS [FirstName],[BDVisitor].[LastName] AS [LastName],[BDVisitor].[AuthorizedBy] AS [AuthorizedBy],[BDVisitor].[AuthorizedArea] AS [AuthorizedArea],[BDVisitor].[AuthorEmail] AS [AuthorEmail],[BDVisitor].[EmailNotify] AS [EmailNotify],[BDVisitor].[ValidFrom] AS [ValidFrom],[BDVisitor].[ValidThru] AS [ValidThru],[BDVisitor].[Password] AS [Password],[BDVisitor].[Special] AS [Special],[BDVisitor].[Photo] AS [Photo],[BDVisitor].[Begin] AS [Begin],[BDVisitor].[End] AS [End],[BDVisitor].[SiteCode] AS [SiteCode],[BDVisitor].[Encoded] AS [Encoded],[BDVisitor].[Scheduled] AS [Scheduled],[BDVisitor].[ArrivedTime] AS [ArrivedTime],[BDVisitor].[TurnstileAccess] AS [TurnstileAccess],[BDVisitor].[BadgePrinted] AS [BadgePrinted],[BDVisitor].[RowVersion] AS [RowVersion],[BDVisitor].[CreatedOn] AS [CreatedOn],[BDVisitor].[CreatedBy] AS [CreatedBy],[BDVisitor].[ModifiedOn] AS [ModifiedOn],[BDVisitor].[ModifiedBy] AS [ModifiedBy],[BDTenant].[Suite] AS [Suite],[BDTenant].[Tenant] AS [Tenant],[BDTenant].[BDBuildingPK] AS [BDBuildingPK],[BDBuilding].[Address1] AS [Address1],[BDBuilding].[BuildingID] AS [BuildingID]";
			}
		}

		public string SQLLeftJoins
		{
			get
			{
				return "LEFT JOIN [BDTenant] [BDTenant] ON [BDVisitor].[BDTenantPK] = [BDTenant].[BDTenantPK] LEFT JOIN [BDBuilding] [BDBuilding] ON [BDTenant].[BDBuildingPK] = [BDBuilding].[BDBuildingPK]";
			}
		}

		protected override string SQLSelect
		{
			get
			{
				return string.Format("SELECT [BDVisitor].[BDVisitorPK] AS [BDVisitorPK],[BDVisitor].[BDTenantPK] AS [BDTenantPK],[BDVisitor].[FirstName] AS [FirstName],[BDVisitor].[LastName] AS [LastName],[BDVisitor].[AuthorizedBy] AS [AuthorizedBy],[BDVisitor].[AuthorizedArea] AS [AuthorizedArea],[BDVisitor].[AuthorEmail] AS [AuthorEmail],[BDVisitor].[EmailNotify] AS [EmailNotify],[BDVisitor].[ValidFrom] AS [ValidFrom],[BDVisitor].[ValidThru] AS [ValidThru],[BDVisitor].[Password] AS [Password],[BDVisitor].[Special] AS [Special],[BDVisitor].[Photo] AS [Photo],[BDVisitor].[Begin] AS [Begin],[BDVisitor].[End] AS [End],[BDVisitor].[SiteCode] AS [SiteCode],[BDVisitor].[Encoded] AS [Encoded],[BDVisitor].[Scheduled] AS [Scheduled],[BDVisitor].[ArrivedTime] AS [ArrivedTime],[BDVisitor].[TurnstileAccess] AS [TurnstileAccess],[BDVisitor].[BadgePrinted] AS [BadgePrinted],[BDVisitor].[RowVersion] AS [RowVersion],[BDVisitor].[CreatedOn] AS [CreatedOn],[BDVisitor].[CreatedBy] AS [CreatedBy],[BDVisitor].[ModifiedOn] AS [ModifiedOn],[BDVisitor].[ModifiedBy] AS [ModifiedBy],[BDTenant].[Suite] AS [Suite],[BDTenant].[Tenant] AS [Tenant],[BDTenant].[BDBuildingPK] AS [BDBuildingPK],[BDBuilding].[Address1] AS [Address1],[BDBuilding].[BuildingID] AS [BuildingID] FROM [{0}] [BDVisitor] LEFT JOIN [BDTenant] [BDTenant] ON [BDVisitor].[BDTenantPK] = [BDTenant].[BDTenantPK] LEFT JOIN [BDBuilding] [BDBuilding] ON [BDTenant].[BDBuildingPK] = [BDBuilding].[BDBuildingPK]", this.TableName);
			}
		}

		protected override string SQLCount
		{
			get
			{
				return string.Format("SELECT COUNT(*) FROM [{0}] [BDVisitor] LEFT JOIN [BDTenant] [BDTenant] ON [BDVisitor].[BDTenantPK] = [BDTenant].[BDTenantPK] LEFT JOIN [BDBuilding] [BDBuilding] ON [BDTenant].[BDBuildingPK] = [BDBuilding].[BDBuildingPK]", this.TableName);
			}
		}

		public int Insert(BDVisitorData entity)
		{
			string sql = string.Format("INSERT INTO [{0}] ([BDVisitorPK],[BDTenantPK],[FirstName],[LastName],[AuthorizedBy],[AuthorizedArea],[AuthorEmail],[EmailNotify],[ValidFrom],[ValidThru],[Password],[Special],[Photo],[Begin],[End],[SiteCode],[Encoded],[Scheduled],[ArrivedTime],[TurnstileAccess],[BadgePrinted],[CreatedOn],[CreatedBy],[ModifiedOn],[ModifiedBy]) VALUES(@BDVisitorPK,@BDTenantPK,@FirstName,@LastName,@AuthorizedBy,@AuthorizedArea,@AuthorEmail,@EmailNotify,@ValidFrom,@ValidThru,@Password,@Special,@Photo,@Begin,@End,@SiteCode,@Encoded,@Scheduled,@ArrivedTime,@TurnstileAccess,@BadgePrinted,@CreatedOn,@CreatedBy,@ModifiedOn,@ModifiedBy)", this.TableName);
			SqlParameter[] paras = new SqlParameter[25];
			paras[0] = new SqlParameter("@BDVisitorPK", SqlDbType.UniqueIdentifier);
			if (entity.BDVisitorPK == Guid.Empty)
			{
				paras[0].Value = DBNull.Value;
			}
			else
			{
				paras[0].Value = entity.BDVisitorPK;
			}
			paras[1] = new SqlParameter("@BDTenantPK", SqlDbType.UniqueIdentifier);
			if (entity.BDTenantPK == Guid.Empty)
			{
				paras[1].Value = DBNull.Value;
			}
			else
			{
				paras[1].Value = entity.BDTenantPK;
			}
			paras[2] = new SqlParameter("@FirstName", SqlDbType.VarChar, 30);
			paras[2].Value = entity.FirstName;
			paras[3] = new SqlParameter("@LastName", SqlDbType.VarChar, 50);
			paras[3].Value = entity.LastName;
			paras[4] = new SqlParameter("@AuthorizedBy", SqlDbType.VarChar, 40);
			paras[4].Value = entity.AuthorizedBy;
			paras[5] = new SqlParameter("@AuthorizedArea", SqlDbType.VarChar, 128);
			paras[5].Value = entity.AuthorizedArea;
			paras[6] = new SqlParameter("@AuthorEmail", SqlDbType.VarChar, 50);
			paras[6].Value = entity.AuthorEmail;
			paras[7] = new SqlParameter("@EmailNotify", SqlDbType.Bit);
			paras[7].Value = entity.EmailNotify;
			paras[8] = new SqlParameter("@ValidFrom", SqlDbType.DateTime);
			paras[8].Value = entity.ValidFrom;
			paras[9] = new SqlParameter("@ValidThru", SqlDbType.DateTime);
			paras[9].Value = entity.ValidThru;
			paras[10] = new SqlParameter("@Password", SqlDbType.VarChar, 30);
			paras[10].Value = entity.Password;
			paras[11] = new SqlParameter("@Special", SqlDbType.VarChar, 1024);
			paras[11].Value = entity.Special;
			paras[12] = new SqlParameter("@Photo", SqlDbType.Image);
			paras[12].Value = entity.Photo;
			paras[13] = new SqlParameter("@Begin", SqlDbType.Char, 4);
			paras[13].Value = entity.Begin;
			paras[14] = new SqlParameter("@End", SqlDbType.Char, 4);
			paras[14].Value = entity.End;
			paras[15] = new SqlParameter("@SiteCode", SqlDbType.Int);
			paras[15].Value = entity.SiteCode;
			paras[16] = new SqlParameter("@Encoded", SqlDbType.Int);
			paras[16].Value = entity.Encoded;
			paras[17] = new SqlParameter("@Scheduled", SqlDbType.Bit);
			paras[17].Value = entity.Scheduled;
			paras[18] = new SqlParameter("@ArrivedTime", SqlDbType.DateTime);
			paras[18].Value = entity.ArrivedTime;
			paras[19] = new SqlParameter("@TurnstileAccess", SqlDbType.BigInt);
			paras[19].Value = entity.TurnstileAccess;
			paras[20] = new SqlParameter("@BadgePrinted", SqlDbType.Bit);
			paras[20].Value = entity.BadgePrinted;
			paras[21] = new SqlParameter("@CreatedOn", SqlDbType.DateTime);
			paras[21].Value = entity.CreatedOn;
			paras[22] = new SqlParameter("@CreatedBy", SqlDbType.VarChar, 30);
			paras[22].Value = entity.CreatedBy;
			paras[23] = new SqlParameter("@ModifiedOn", SqlDbType.DateTime);
			paras[23].Value = entity.ModifiedOn;
			paras[24] = new SqlParameter("@ModifiedBy", SqlDbType.VarChar, 30);
			paras[24].Value = entity.ModifiedBy;
			return base.ExecuteNonQuery(sql, paras);
		}

		public int Update(BDVisitorData entity)
		{
			string sql = string.Format("UPDATE [{0}] SET [BDTenantPK] = @BDTenantPK,[FirstName] = @FirstName,[LastName] = @LastName,[AuthorizedBy] = @AuthorizedBy,[AuthorizedArea] = @AuthorizedArea,[AuthorEmail] = @AuthorEmail,[EmailNotify] = @EmailNotify,[ValidFrom] = @ValidFrom,[ValidThru] = @ValidThru,[Password] = @Password,[Special] = @Special,[Photo] = @Photo,[Begin] = @Begin,[End] = @End,[SiteCode] = @SiteCode,[Encoded] = @Encoded,[Scheduled] = @Scheduled,[ArrivedTime] = @ArrivedTime,[TurnstileAccess] = @TurnstileAccess,[BadgePrinted] = @BadgePrinted,[CreatedOn] = @CreatedOn,[CreatedBy] = @CreatedBy,[ModifiedOn] = @ModifiedOn,[ModifiedBy] = @ModifiedBy  WHERE [BDVisitorPK] = @BDVisitorPK AND [RowVersion] = @RowVersion", this.TableName);
			SqlParameter[] paras = new SqlParameter[26];
			paras[0] = new SqlParameter("@BDVisitorPK", SqlDbType.UniqueIdentifier);
			if (entity.BDVisitorPK == Guid.Empty)
			{
				paras[0].Value = DBNull.Value;
			}
			else
			{
				paras[0].Value = entity.BDVisitorPK;
			}
			paras[1] = new SqlParameter("@BDTenantPK", SqlDbType.UniqueIdentifier);
			if (entity.BDTenantPK == Guid.Empty)
			{
				paras[1].Value = DBNull.Value;
			}
			else
			{
				paras[1].Value = entity.BDTenantPK;
			}
			paras[2] = new SqlParameter("@FirstName", SqlDbType.VarChar, 30);
			paras[2].Value = entity.FirstName;
			paras[3] = new SqlParameter("@LastName", SqlDbType.VarChar, 50);
			paras[3].Value = entity.LastName;
			paras[4] = new SqlParameter("@AuthorizedBy", SqlDbType.VarChar, 40);
			paras[4].Value = entity.AuthorizedBy;
			paras[5] = new SqlParameter("@AuthorizedArea", SqlDbType.VarChar, 128);
			paras[5].Value = entity.AuthorizedArea;
			paras[6] = new SqlParameter("@AuthorEmail", SqlDbType.VarChar, 50);
			paras[6].Value = entity.AuthorEmail;
			paras[7] = new SqlParameter("@EmailNotify", SqlDbType.Bit);
			paras[7].Value = entity.EmailNotify;
			paras[8] = new SqlParameter("@ValidFrom", SqlDbType.DateTime);
			paras[8].Value = entity.ValidFrom;
			paras[9] = new SqlParameter("@ValidThru", SqlDbType.DateTime);
			paras[9].Value = entity.ValidThru;
			paras[10] = new SqlParameter("@Password", SqlDbType.VarChar, 30);
			paras[10].Value = entity.Password;
			paras[11] = new SqlParameter("@Special", SqlDbType.VarChar, 1024);
			paras[11].Value = entity.Special;
			paras[12] = new SqlParameter("@Photo", SqlDbType.Image);
			paras[12].Value = entity.Photo;
			paras[13] = new SqlParameter("@Begin", SqlDbType.Char, 4);
			paras[13].Value = entity.Begin;
			paras[14] = new SqlParameter("@End", SqlDbType.Char, 4);
			paras[14].Value = entity.End;
			paras[15] = new SqlParameter("@SiteCode", SqlDbType.Int);
			paras[15].Value = entity.SiteCode;
			paras[16] = new SqlParameter("@Encoded", SqlDbType.Int);
			paras[16].Value = entity.Encoded;
			paras[17] = new SqlParameter("@Scheduled", SqlDbType.Bit);
			paras[17].Value = entity.Scheduled;
			paras[18] = new SqlParameter("@ArrivedTime", SqlDbType.DateTime);
			paras[18].Value = entity.ArrivedTime;
			paras[19] = new SqlParameter("@TurnstileAccess", SqlDbType.BigInt);
			paras[19].Value = entity.TurnstileAccess;
			paras[20] = new SqlParameter("@BadgePrinted", SqlDbType.Bit);
			paras[20].Value = entity.BadgePrinted;
			paras[21] = new SqlParameter("@RowVersion", SqlDbType.Timestamp);
			paras[21].Value = entity.RowVersion;
			paras[22] = new SqlParameter("@CreatedOn", SqlDbType.DateTime);
			paras[22].Value = entity.CreatedOn;
			paras[23] = new SqlParameter("@CreatedBy", SqlDbType.VarChar, 30);
			paras[23].Value = entity.CreatedBy;
			paras[24] = new SqlParameter("@ModifiedOn", SqlDbType.DateTime);
			paras[24].Value = entity.ModifiedOn;
			paras[25] = new SqlParameter("@ModifiedBy", SqlDbType.VarChar, 30);
			paras[25].Value = entity.ModifiedBy;
			return base.ExecuteNonQuery(sql, paras);
		}

		private BDVisitorData CreateDataByReader(SafeDataReader reader)
		{
			BDVisitorData data = new BDVisitorData {
				BDVisitorPK = (Guid) reader["BDVisitorPK"],
				BDTenantPK = (Guid) reader["BDTenantPK"],
				FirstName = (String) reader["FirstName"],
				LastName = (String) reader["LastName"],
				AuthorizedBy = (String) reader["AuthorizedBy"],
				AuthorizedArea = (String) reader["AuthorizedArea"],
				AuthorEmail = (String) reader["AuthorEmail"],
				EmailNotify = (Boolean) reader["EmailNotify"],
				ValidFrom = (DateTime) reader["ValidFrom"],
				ValidThru = (DateTime) reader["ValidThru"],
				Password = (String) reader["Password"],
				Special = (String) reader["Special"],
				Photo = (Byte[]) reader["Photo"],
				Begin = (String) reader["Begin"],
				End = (String) reader["End"],
				SiteCode = (Int32) reader["SiteCode"],
				Encoded = (Int32) reader["Encoded"],
				Scheduled = (Boolean) reader["Scheduled"],
				ArrivedTime = (DateTime) reader["ArrivedTime"],
				TurnstileAccess = (Int64) reader["TurnstileAccess"],
				BadgePrinted = (Boolean) reader["BadgePrinted"],
				RowVersion = (Byte[]) reader["RowVersion"],
				CreatedOn = (DateTime) reader["CreatedOn"],
				CreatedBy = (String) reader["CreatedBy"],
				ModifiedOn = (DateTime) reader["ModifiedOn"],
				ModifiedBy = (String) reader["ModifiedBy"],
				Suite = (String) reader["Suite"],
				Tenant = (String) reader["Tenant"],
				BDBuildingPK = (Guid) reader["BDBuildingPK"],
				Address1 = (String) reader["Address1"],
				BuildingID = (Int32) reader["BuildingID"]
			};
			data.AcceptChanges();
			return data;
		}

		private BDVisitorData FetchEntity(string where, SqlParameter[] paras)
		{
			BDVisitorData data = null;
			using (SafeDataReader reader = base.ExecuteDataReader(where, paras))
			{
				if (reader.Read())
				{
					data = this.CreateDataByReader(reader);
				}
				reader.Close();
			}
			return data;
		}

		private BDVisitorData FetchEntityEx(string sql, SqlParameter[] paras)
		{
			BDVisitorData data = null;
			using (SafeDataReader reader = base.ExecuteDataReaderEx(sql, paras))
			{
				if (reader.Read())
				{
					data = this.CreateDataByReader(reader);
				}
				reader.Close();
			}
			return data;
		}

		private BDVisitorDataCollection FetchCollection(string where, SqlParameter[] paras)
		{
			BDVisitorDataCollection list = new BDVisitorDataCollection();
			using (SafeDataReader reader = base.ExecuteDataReader(where, paras))
			{
				while(reader.Read())
				{
					BDVisitorData data = this.CreateDataByReader(reader);
					list.Add(data);
				}
				reader.Close();
			}
			return list;
		}

		private BDVisitorDataCollection FetchCollectionEx(string sql, SqlParameter[] paras)
		{
			BDVisitorDataCollection list = new BDVisitorDataCollection();
			using (SafeDataReader reader = base.ExecuteDataReaderEx(sql, paras))
			{
				while(reader.Read())
				{
					BDVisitorData data = this.CreateDataByReader(reader);
					list.Add(data);
				}
				reader.Close();
			}
			return list;
		}

		public BDVisitorData GetEntityBy(string sqlWhere, SqlParameter[] paras)
		{
			return this.FetchEntity(sqlWhere, paras);
		}

		public BDVisitorData GetEntityExBy(string sql, SqlParameter[] paras)
		{
			return this.FetchEntityEx(sql, paras);
		}

		public BDVisitorDataCollection GetCollectionBy(string sqlWhere, SqlParameter[] paras)
		{
			return this.FetchCollection(sqlWhere, paras);
		}

		public BDVisitorDataCollection GetCollectionExBy(string sql, SqlParameter[] paras)
		{
			return this.FetchCollectionEx(sql, paras);
		}

		public byte[] GetRowVersion( System.Guid BDVisitorPK)
		{
			string sql = string.Format("SELECT [RowVersion] AS [RowVersion] FROM [{0}] WHERE  [BDVisitorPK] = @BDVisitorPK ", this.TableName);
			SqlParameter[] paras = new SqlParameter[1];
			paras[0] = new SqlParameter("@BDVisitorPK", SqlDbType.UniqueIdentifier, 16);
			paras[0].Value = BDVisitorPK;
			return (byte[]) base.ExecuteScalar(sql, paras);
		}

		public BDVisitorData GetByPK( System.Guid BDVisitorPK)
		{
			string sql = " WHERE  [BDVisitor].[BDVisitorPK] = @BDVisitorPK ";
			SqlParameter[] paras = new SqlParameter[1];
			paras[0] = new SqlParameter("@BDVisitorPK", SqlDbType.UniqueIdentifier);
			paras[0].Value = BDVisitorPK;
			return this.FetchEntity(sql, paras);
		}

		public BDVisitorDataCollection GetAll()
		{
			return this.FetchCollection("", null);
		}

		public BDVisitorDataCollection GetByBDTenant(System.Guid BDTenantPK)
		{
			string sqlWhere = " WHERE [BDVisitor].[BDTenantPK] = @BDTenantPK";
			SqlParameter[] paras = new SqlParameter[1];
			paras[0] = new SqlParameter("@BDTenantPK", SqlDbType.UniqueIdentifier);
			paras[0].Value = BDTenantPK;
			return this.FetchCollection(sqlWhere, paras);
		}

		public DataTable GetLogByPK( System.Guid BDVisitorPK)
		{
			string sql = string.Format("SELECT  [BDVisitor].[BDVisitorPK] AS [BDVisitorPK], [BDVisitor].[ModifiedOn] AS [ModifiedOn] FROM [{0}] WHERE  [BDVisitor].[BDVisitorPK] = @BDVisitorPK ", this.TableName);
			SqlParameter[] paras = new SqlParameter[1];
			paras[0] = new SqlParameter("@BDVisitorPK", SqlDbType.UniqueIdentifier);
			paras[0].Value = BDVisitorPK;
			return this.ExecuteDataTable(sql, paras);
		}

		public DataTable GetLogByBDTenant(System.Guid bDTenantPK)
		{
			string sql = string.Format("DELETE [{0}] FROM [{0}] [BDVisitor] INNER JOIN [BDTenant] ON [BDVisitor].[BDTenantPK] = [BDTenant].[BDTenantPK] WHERE [BDTenant].[BDTenantPK] = @BDTenantPK;", this.TableName);
			string oldValue = string.Format("DELETE [{0}]", this.TableName);
			string newValue = "SELECT  [BDVisitor].[BDVisitorPK] AS [BDVisitorPK], [BDVisitor].[ModifiedOn] AS [ModifiedOn]";
			sql = sql.Replace(oldValue, newValue).TrimEnd().TrimEnd(';').Replace(";", " UNION ");
			SqlParameter[] paras = new SqlParameter[1];
			paras[0] = new SqlParameter("@BDTenantPK", SqlDbType.UniqueIdentifier);
			paras[0].Value = bDTenantPK;
			return base.ExecuteDataTable(sql, paras);
		}

		public DataTable GetLogByBDBuilding(System.Guid bDBuildingPK)
		{
			string sql = string.Format("DELETE [{0}] FROM [{0}] [BDVisitor] INNER JOIN [BDTenant] ON [BDVisitor].[BDTenantPK] = [BDTenant].[BDTenantPK] INNER JOIN [BDBuilding] ON [BDTenant].[BDBuildingPK] = [BDBuilding].[BDBuildingPK] WHERE [BDBuilding].[BDBuildingPK] = @BDBuildingPK;", this.TableName);
			string oldValue = string.Format("DELETE [{0}]", this.TableName);
			string newValue = "SELECT  [BDVisitor].[BDVisitorPK] AS [BDVisitorPK], [BDVisitor].[ModifiedOn] AS [ModifiedOn]";
			sql = sql.Replace(oldValue, newValue).TrimEnd().TrimEnd(';').Replace(";", " UNION ");
			SqlParameter[] paras = new SqlParameter[1];
			paras[0] = new SqlParameter("@BDBuildingPK", SqlDbType.UniqueIdentifier);
			paras[0].Value = bDBuildingPK;
			return base.ExecuteDataTable(sql, paras);
		}

		public int DeleteByPK( System.Guid BDVisitorPK, byte[] RowVersion)
		{
			string sql = string.Format("DELETE FROM [{0}] WHERE  [BDVisitorPK] = @BDVisitorPK AND [RowVersion] = @RowVersion", this.TableName);
			SqlParameter[] paras = new SqlParameter[2];
			paras[0] = new SqlParameter("@BDVisitorPK", SqlDbType.UniqueIdentifier);
			paras[0].Value = BDVisitorPK;
			paras[1] = new SqlParameter("@RowVersion", SqlDbType.Timestamp, 8);
			paras[1].Value = RowVersion;
			return base.ExecuteNonQuery(sql, paras);
		}

		public int DeleteAll()
		{
			string sql = string.Format("DELETE FROM [{0}]", this.TableName);
			return base.ExecuteNonQuery(sql, null);
		}

		public int DeleteByBDTenant(System.Guid bDTenantPK)
		{
			string sql = string.Format("DELETE [{0}] FROM [{0}] [BDVisitor] INNER JOIN [BDTenant] ON [BDVisitor].[BDTenantPK] = [BDTenant].[BDTenantPK] WHERE [BDTenant].[BDTenantPK] = @BDTenantPK;", this.TableName);
			SqlParameter[] paras = new SqlParameter[1];
			paras[0] = new SqlParameter("@BDTenantPK", SqlDbType.UniqueIdentifier);
			paras[0].Value = bDTenantPK;
			return base.ExecuteNonQuery(sql, paras);
		}

		public int DeleteByBDBuilding(System.Guid bDBuildingPK)
		{
			string sql = string.Format("DELETE [{0}] FROM [{0}] [BDVisitor] INNER JOIN [BDTenant] ON [BDVisitor].[BDTenantPK] = [BDTenant].[BDTenantPK] INNER JOIN [BDBuilding] ON [BDTenant].[BDBuildingPK] = [BDBuilding].[BDBuildingPK] WHERE [BDBuilding].[BDBuildingPK] = @BDBuildingPK;", this.TableName);
			SqlParameter[] paras = new SqlParameter[1];
			paras[0] = new SqlParameter("@BDBuildingPK", SqlDbType.UniqueIdentifier);
			paras[0].Value = bDBuildingPK;
			return base.ExecuteNonQuery(sql, paras);
		}


	}
	public class UsrGroupDBRuleCRUD : DataAccessBase
	{
		private string _tableName = "UsrGroupDBRule";

		public UsrGroupDBRuleCRUD(string connectionString) : base(connectionString)
		{
		}

		public virtual string TableName
		{
			get { return this._tableName; }
			set { this._tableName = value; }
		}

		public string SQLColumns
		{
			get
			{
				return "[UsrGroupDBRule].[UsrGroupDBRulePK] AS [UsrGroupDBRulePK],[UsrGroupDBRule].[UsrGroupPK] AS [UsrGroupPK],[UsrGroupDBRule].[DBRuleID] AS [DBRuleID],[UsrGroupDBRule].[Selectable] AS [Selectable],[UsrGroupDBRule].[Insertable] AS [Insertable],[UsrGroupDBRule].[Editable] AS [Editable],[UsrGroupDBRule].[Deletable] AS [Deletable],[UsrGroupDBRule].[RowVersion] AS [RowVersion],[UsrGroupDBRule].[CreatedOn] AS [CreatedOn],[UsrGroupDBRule].[CreatedBy] AS [CreatedBy],[UsrGroupDBRule].[ModifiedOn] AS [ModifiedOn],[UsrGroupDBRule].[ModifiedBy] AS [ModifiedBy],[UsrGroup].[UsrGroupName] AS [UsrGroupName]";
			}
		}

		public string SQLLeftJoins
		{
			get
			{
				return "LEFT JOIN [UsrGroup] [UsrGroup] ON [UsrGroupDBRule].[UsrGroupPK] = [UsrGroup].[UsrGroupPK]";
			}
		}

		protected override string SQLSelect
		{
			get
			{
				return string.Format("SELECT [UsrGroupDBRule].[UsrGroupDBRulePK] AS [UsrGroupDBRulePK],[UsrGroupDBRule].[UsrGroupPK] AS [UsrGroupPK],[UsrGroupDBRule].[DBRuleID] AS [DBRuleID],[UsrGroupDBRule].[Selectable] AS [Selectable],[UsrGroupDBRule].[Insertable] AS [Insertable],[UsrGroupDBRule].[Editable] AS [Editable],[UsrGroupDBRule].[Deletable] AS [Deletable],[UsrGroupDBRule].[RowVersion] AS [RowVersion],[UsrGroupDBRule].[CreatedOn] AS [CreatedOn],[UsrGroupDBRule].[CreatedBy] AS [CreatedBy],[UsrGroupDBRule].[ModifiedOn] AS [ModifiedOn],[UsrGroupDBRule].[ModifiedBy] AS [ModifiedBy],[UsrGroup].[UsrGroupName] AS [UsrGroupName] FROM [{0}] [UsrGroupDBRule] LEFT JOIN [UsrGroup] [UsrGroup] ON [UsrGroupDBRule].[UsrGroupPK] = [UsrGroup].[UsrGroupPK]", this.TableName);
			}
		}

		protected override string SQLCount
		{
			get
			{
				return string.Format("SELECT COUNT(*) FROM [{0}] [UsrGroupDBRule] LEFT JOIN [UsrGroup] [UsrGroup] ON [UsrGroupDBRule].[UsrGroupPK] = [UsrGroup].[UsrGroupPK]", this.TableName);
			}
		}

		public int Insert(UsrGroupDBRuleData entity)
		{
			string sql = string.Format("INSERT INTO [{0}] ([UsrGroupDBRulePK],[UsrGroupPK],[DBRuleID],[Selectable],[Insertable],[Editable],[Deletable],[CreatedOn],[CreatedBy],[ModifiedOn],[ModifiedBy]) VALUES(@UsrGroupDBRulePK,@UsrGroupPK,@DBRuleID,@Selectable,@Insertable,@Editable,@Deletable,@CreatedOn,@CreatedBy,@ModifiedOn,@ModifiedBy)", this.TableName);
			SqlParameter[] paras = new SqlParameter[11];
			paras[0] = new SqlParameter("@UsrGroupDBRulePK", SqlDbType.UniqueIdentifier);
			if (entity.UsrGroupDBRulePK == Guid.Empty)
			{
				paras[0].Value = DBNull.Value;
			}
			else
			{
				paras[0].Value = entity.UsrGroupDBRulePK;
			}
			paras[1] = new SqlParameter("@UsrGroupPK", SqlDbType.UniqueIdentifier);
			if (entity.UsrGroupPK == Guid.Empty)
			{
				paras[1].Value = DBNull.Value;
			}
			else
			{
				paras[1].Value = entity.UsrGroupPK;
			}
			paras[2] = new SqlParameter("@DBRuleID", SqlDbType.Int);
			paras[2].Value = entity.DBRuleID;
			paras[3] = new SqlParameter("@Selectable", SqlDbType.Bit);
			paras[3].Value = entity.Selectable;
			paras[4] = new SqlParameter("@Insertable", SqlDbType.Bit);
			paras[4].Value = entity.Insertable;
			paras[5] = new SqlParameter("@Editable", SqlDbType.Bit);
			paras[5].Value = entity.Editable;
			paras[6] = new SqlParameter("@Deletable", SqlDbType.Bit);
			paras[6].Value = entity.Deletable;
			paras[7] = new SqlParameter("@CreatedOn", SqlDbType.DateTime);
			paras[7].Value = entity.CreatedOn;
			paras[8] = new SqlParameter("@CreatedBy", SqlDbType.VarChar, 30);
			paras[8].Value = entity.CreatedBy;
			paras[9] = new SqlParameter("@ModifiedOn", SqlDbType.DateTime);
			paras[9].Value = entity.ModifiedOn;
			paras[10] = new SqlParameter("@ModifiedBy", SqlDbType.VarChar, 30);
			paras[10].Value = entity.ModifiedBy;
			return base.ExecuteNonQuery(sql, paras);
		}

		public int Update(UsrGroupDBRuleData entity)
		{
			string sql = string.Format("UPDATE [{0}] SET [UsrGroupPK] = @UsrGroupPK,[DBRuleID] = @DBRuleID,[Selectable] = @Selectable,[Insertable] = @Insertable,[Editable] = @Editable,[Deletable] = @Deletable,[CreatedOn] = @CreatedOn,[CreatedBy] = @CreatedBy,[ModifiedOn] = @ModifiedOn,[ModifiedBy] = @ModifiedBy  WHERE [UsrGroupDBRulePK] = @UsrGroupDBRulePK AND [RowVersion] = @RowVersion", this.TableName);
			SqlParameter[] paras = new SqlParameter[12];
			paras[0] = new SqlParameter("@UsrGroupDBRulePK", SqlDbType.UniqueIdentifier);
			if (entity.UsrGroupDBRulePK == Guid.Empty)
			{
				paras[0].Value = DBNull.Value;
			}
			else
			{
				paras[0].Value = entity.UsrGroupDBRulePK;
			}
			paras[1] = new SqlParameter("@UsrGroupPK", SqlDbType.UniqueIdentifier);
			if (entity.UsrGroupPK == Guid.Empty)
			{
				paras[1].Value = DBNull.Value;
			}
			else
			{
				paras[1].Value = entity.UsrGroupPK;
			}
			paras[2] = new SqlParameter("@DBRuleID", SqlDbType.Int);
			paras[2].Value = entity.DBRuleID;
			paras[3] = new SqlParameter("@Selectable", SqlDbType.Bit);
			paras[3].Value = entity.Selectable;
			paras[4] = new SqlParameter("@Insertable", SqlDbType.Bit);
			paras[4].Value = entity.Insertable;
			paras[5] = new SqlParameter("@Editable", SqlDbType.Bit);
			paras[5].Value = entity.Editable;
			paras[6] = new SqlParameter("@Deletable", SqlDbType.Bit);
			paras[6].Value = entity.Deletable;
			paras[7] = new SqlParameter("@RowVersion", SqlDbType.Timestamp);
			paras[7].Value = entity.RowVersion;
			paras[8] = new SqlParameter("@CreatedOn", SqlDbType.DateTime);
			paras[8].Value = entity.CreatedOn;
			paras[9] = new SqlParameter("@CreatedBy", SqlDbType.VarChar, 30);
			paras[9].Value = entity.CreatedBy;
			paras[10] = new SqlParameter("@ModifiedOn", SqlDbType.DateTime);
			paras[10].Value = entity.ModifiedOn;
			paras[11] = new SqlParameter("@ModifiedBy", SqlDbType.VarChar, 30);
			paras[11].Value = entity.ModifiedBy;
			return base.ExecuteNonQuery(sql, paras);
		}

		private UsrGroupDBRuleData CreateDataByReader(SafeDataReader reader)
		{
			UsrGroupDBRuleData data = new UsrGroupDBRuleData {
				UsrGroupDBRulePK = (Guid) reader["UsrGroupDBRulePK"],
				UsrGroupPK = (Guid) reader["UsrGroupPK"],
				DBRuleID = (Int32) reader["DBRuleID"],
				Selectable = (Boolean) reader["Selectable"],
				Insertable = (Boolean) reader["Insertable"],
				Editable = (Boolean) reader["Editable"],
				Deletable = (Boolean) reader["Deletable"],
				RowVersion = (Byte[]) reader["RowVersion"],
				CreatedOn = (DateTime) reader["CreatedOn"],
				CreatedBy = (String) reader["CreatedBy"],
				ModifiedOn = (DateTime) reader["ModifiedOn"],
				ModifiedBy = (String) reader["ModifiedBy"],
				UsrGroupName = (String) reader["UsrGroupName"]
			};
			data.AcceptChanges();
			return data;
		}

		private UsrGroupDBRuleData FetchEntity(string where, SqlParameter[] paras)
		{
			UsrGroupDBRuleData data = null;
			using (SafeDataReader reader = base.ExecuteDataReader(where, paras))
			{
				if (reader.Read())
				{
					data = this.CreateDataByReader(reader);
				}
				reader.Close();
			}
			return data;
		}

		private UsrGroupDBRuleData FetchEntityEx(string sql, SqlParameter[] paras)
		{
			UsrGroupDBRuleData data = null;
			using (SafeDataReader reader = base.ExecuteDataReaderEx(sql, paras))
			{
				if (reader.Read())
				{
					data = this.CreateDataByReader(reader);
				}
				reader.Close();
			}
			return data;
		}

		private UsrGroupDBRuleDataCollection FetchCollection(string where, SqlParameter[] paras)
		{
			UsrGroupDBRuleDataCollection list = new UsrGroupDBRuleDataCollection();
			using (SafeDataReader reader = base.ExecuteDataReader(where, paras))
			{
				while(reader.Read())
				{
					UsrGroupDBRuleData data = this.CreateDataByReader(reader);
					list.Add(data);
				}
				reader.Close();
			}
			return list;
		}

		private UsrGroupDBRuleDataCollection FetchCollectionEx(string sql, SqlParameter[] paras)
		{
			UsrGroupDBRuleDataCollection list = new UsrGroupDBRuleDataCollection();
			using (SafeDataReader reader = base.ExecuteDataReaderEx(sql, paras))
			{
				while(reader.Read())
				{
					UsrGroupDBRuleData data = this.CreateDataByReader(reader);
					list.Add(data);
				}
				reader.Close();
			}
			return list;
		}

		public UsrGroupDBRuleData GetEntityBy(string sqlWhere, SqlParameter[] paras)
		{
			return this.FetchEntity(sqlWhere, paras);
		}

		public UsrGroupDBRuleData GetEntityExBy(string sql, SqlParameter[] paras)
		{
			return this.FetchEntityEx(sql, paras);
		}

		public UsrGroupDBRuleDataCollection GetCollectionBy(string sqlWhere, SqlParameter[] paras)
		{
			return this.FetchCollection(sqlWhere, paras);
		}

		public UsrGroupDBRuleDataCollection GetCollectionExBy(string sql, SqlParameter[] paras)
		{
			return this.FetchCollectionEx(sql, paras);
		}

		public byte[] GetRowVersion( System.Guid UsrGroupDBRulePK)
		{
			string sql = string.Format("SELECT [RowVersion] AS [RowVersion] FROM [{0}] WHERE  [UsrGroupDBRulePK] = @UsrGroupDBRulePK ", this.TableName);
			SqlParameter[] paras = new SqlParameter[1];
			paras[0] = new SqlParameter("@UsrGroupDBRulePK", SqlDbType.UniqueIdentifier, 16);
			paras[0].Value = UsrGroupDBRulePK;
			return (byte[]) base.ExecuteScalar(sql, paras);
		}

		public UsrGroupDBRuleData GetByPK( System.Guid UsrGroupDBRulePK)
		{
			string sql = " WHERE  [UsrGroupDBRule].[UsrGroupDBRulePK] = @UsrGroupDBRulePK ";
			SqlParameter[] paras = new SqlParameter[1];
			paras[0] = new SqlParameter("@UsrGroupDBRulePK", SqlDbType.UniqueIdentifier);
			paras[0].Value = UsrGroupDBRulePK;
			return this.FetchEntity(sql, paras);
		}

		public UsrGroupDBRuleDataCollection GetAll()
		{
			return this.FetchCollection("", null);
		}

		public UsrGroupDBRuleDataCollection GetByUsrGroup(System.Guid UsrGroupPK)
		{
			string sqlWhere = " WHERE [UsrGroupDBRule].[UsrGroupPK] = @UsrGroupPK";
			SqlParameter[] paras = new SqlParameter[1];
			paras[0] = new SqlParameter("@UsrGroupPK", SqlDbType.UniqueIdentifier);
			paras[0].Value = UsrGroupPK;
			return this.FetchCollection(sqlWhere, paras);
		}

		public DataTable GetLogByPK( System.Guid UsrGroupDBRulePK)
		{
			string sql = string.Format("SELECT  [UsrGroupDBRule].[UsrGroupDBRulePK] AS [UsrGroupDBRulePK], [UsrGroupDBRule].[ModifiedOn] AS [ModifiedOn] FROM [{0}] WHERE  [UsrGroupDBRule].[UsrGroupDBRulePK] = @UsrGroupDBRulePK ", this.TableName);
			SqlParameter[] paras = new SqlParameter[1];
			paras[0] = new SqlParameter("@UsrGroupDBRulePK", SqlDbType.UniqueIdentifier);
			paras[0].Value = UsrGroupDBRulePK;
			return this.ExecuteDataTable(sql, paras);
		}

		public DataTable GetLogByUsrGroup(System.Guid usrGroupPK)
		{
			string sql = string.Format("DELETE [{0}] FROM [{0}] [UsrGroupDBRule] INNER JOIN [UsrGroup] ON [UsrGroupDBRule].[UsrGroupPK] = [UsrGroup].[UsrGroupPK] WHERE [UsrGroup].[UsrGroupPK] = @UsrGroupPK;", this.TableName);
			string oldValue = string.Format("DELETE [{0}]", this.TableName);
			string newValue = "SELECT  [UsrGroupDBRule].[UsrGroupDBRulePK] AS [UsrGroupDBRulePK], [UsrGroupDBRule].[ModifiedOn] AS [ModifiedOn]";
			sql = sql.Replace(oldValue, newValue).TrimEnd().TrimEnd(';').Replace(";", " UNION ");
			SqlParameter[] paras = new SqlParameter[1];
			paras[0] = new SqlParameter("@UsrGroupPK", SqlDbType.UniqueIdentifier);
			paras[0].Value = usrGroupPK;
			return base.ExecuteDataTable(sql, paras);
		}

		public int DeleteByPK( System.Guid UsrGroupDBRulePK, byte[] RowVersion)
		{
			string sql = string.Format("DELETE FROM [{0}] WHERE  [UsrGroupDBRulePK] = @UsrGroupDBRulePK AND [RowVersion] = @RowVersion", this.TableName);
			SqlParameter[] paras = new SqlParameter[2];
			paras[0] = new SqlParameter("@UsrGroupDBRulePK", SqlDbType.UniqueIdentifier);
			paras[0].Value = UsrGroupDBRulePK;
			paras[1] = new SqlParameter("@RowVersion", SqlDbType.Timestamp, 8);
			paras[1].Value = RowVersion;
			return base.ExecuteNonQuery(sql, paras);
		}

		public int DeleteAll()
		{
			string sql = string.Format("DELETE FROM [{0}]", this.TableName);
			return base.ExecuteNonQuery(sql, null);
		}

		public int DeleteByUsrGroup(System.Guid usrGroupPK)
		{
			string sql = string.Format("DELETE [{0}] FROM [{0}] [UsrGroupDBRule] INNER JOIN [UsrGroup] ON [UsrGroupDBRule].[UsrGroupPK] = [UsrGroup].[UsrGroupPK] WHERE [UsrGroup].[UsrGroupPK] = @UsrGroupPK;", this.TableName);
			SqlParameter[] paras = new SqlParameter[1];
			paras[0] = new SqlParameter("@UsrGroupPK", SqlDbType.UniqueIdentifier);
			paras[0].Value = usrGroupPK;
			return base.ExecuteNonQuery(sql, paras);
		}


	}
	public class ACPanelCRUD : DataAccessBase
	{
		private string _tableName = "ACPanel";

		public ACPanelCRUD(string connectionString) : base(connectionString)
		{
		}

		public virtual string TableName
		{
			get { return this._tableName; }
			set { this._tableName = value; }
		}

		public string SQLColumns
		{
			get
			{
				return "[ACPanel].[ACPanelPK] AS [ACPanelPK],[ACPanel].[UnitID] AS [UnitID],[ACPanel].[BDBuildingPK] AS [BDBuildingPK],[ACPanel].[SerialNumber] AS [SerialNumber],[ACPanel].[PanelName] AS [PanelName],[ACPanel].[BufferSize] AS [BufferSize],[ACPanel].[DialUp] AS [DialUp],[ACPanel].[UnitPhone] AS [UnitPhone],[ACPanel].[UnitPhoneCallerID] AS [UnitPhoneCallerID],[ACPanel].[UnitExt] AS [UnitExt],[ACPanel].[LongDistance] AS [LongDistance],[ACPanel].[ModemInitString] AS [ModemInitString],[ACPanel].[BaudRate] AS [BaudRate],[ACPanel].[HistoryPhone] AS [HistoryPhone],[ACPanel].[AlarmPhone1] AS [AlarmPhone1],[ACPanel].[AlarmPhone2] AS [AlarmPhone2],[ACPanel].[DialingPrefixPanel] AS [DialingPrefixPanel],[ACPanel].[DialingSuffixPanel] AS [DialingSuffixPanel],[ACPanel].[DialOutEnabled] AS [DialOutEnabled],[ACPanel].[DayLightSaving] AS [DayLightSaving],[ACPanel].[OnSiteMonitor] AS [OnSiteMonitor],[ACPanel].[CentralDelay] AS [CentralDelay],[ACPanel].[ElevPulse] AS [ElevPulse],[ACPanel].[PanelTypeID] AS [PanelTypeID],[ACPanel].[UnbufferTC] AS [UnbufferTC],[ACPanel].[MandatoryUnbufferTC] AS [MandatoryUnbufferTC],[ACPanel].[SwingerCount] AS [SwingerCount],[ACPanel].[SwingerTime] AS [SwingerTime],[ACPanel].[LoopNumb] AS [LoopNumb],[ACPanel].[PortNumb] AS [PortNumb],[ACPanel].[Notes] AS [Notes],[ACPanel].[Trouble] AS [Trouble],[ACPanel].[NoVersionCheck] AS [NoVersionCheck],[ACPanel].[RowVersion] AS [RowVersion],[ACPanel].[CreatedOn] AS [CreatedOn],[ACPanel].[CreatedBy] AS [CreatedBy],[ACPanel].[ModifiedOn] AS [ModifiedOn],[ACPanel].[ModifiedBy] AS [ModifiedBy],[ACPanel].[DeviceId] AS [DeviceId],[ACPanel].[DBSyncSeconds] AS [DBSyncSeconds],[ACPanel].[DBSaveMinutes] AS [DBSaveMinutes],[ACPanel].[IsE150] AS [IsE150],[ACPanel].[GroupID] AS [GroupID],[ACPanel].[NoAutoDownload] AS [NoAutoDownload],[ACPanel].[NoAutoDownloadStart] AS [NoAutoDownloadStart],[ACPanel].[Locked] AS [Locked],[ACPanel].[InDebug] AS [InDebug],[BDBuilding].[Address1] AS [Address1],[BDBuilding].[BuildingID] AS [BuildingID]";
			}
		}

		public string SQLLeftJoins
		{
			get
			{
				return "LEFT JOIN [BDBuilding] [BDBuilding] ON [ACPanel].[BDBuildingPK] = [BDBuilding].[BDBuildingPK]";
			}
		}

		protected override string SQLSelect
		{
			get
			{
				return string.Format("SELECT [ACPanel].[ACPanelPK] AS [ACPanelPK],[ACPanel].[UnitID] AS [UnitID],[ACPanel].[BDBuildingPK] AS [BDBuildingPK],[ACPanel].[SerialNumber] AS [SerialNumber],[ACPanel].[PanelName] AS [PanelName],[ACPanel].[BufferSize] AS [BufferSize],[ACPanel].[DialUp] AS [DialUp],[ACPanel].[UnitPhone] AS [UnitPhone],[ACPanel].[UnitPhoneCallerID] AS [UnitPhoneCallerID],[ACPanel].[UnitExt] AS [UnitExt],[ACPanel].[LongDistance] AS [LongDistance],[ACPanel].[ModemInitString] AS [ModemInitString],[ACPanel].[BaudRate] AS [BaudRate],[ACPanel].[HistoryPhone] AS [HistoryPhone],[ACPanel].[AlarmPhone1] AS [AlarmPhone1],[ACPanel].[AlarmPhone2] AS [AlarmPhone2],[ACPanel].[DialingPrefixPanel] AS [DialingPrefixPanel],[ACPanel].[DialingSuffixPanel] AS [DialingSuffixPanel],[ACPanel].[DialOutEnabled] AS [DialOutEnabled],[ACPanel].[DayLightSaving] AS [DayLightSaving],[ACPanel].[OnSiteMonitor] AS [OnSiteMonitor],[ACPanel].[CentralDelay] AS [CentralDelay],[ACPanel].[ElevPulse] AS [ElevPulse],[ACPanel].[PanelTypeID] AS [PanelTypeID],[ACPanel].[UnbufferTC] AS [UnbufferTC],[ACPanel].[MandatoryUnbufferTC] AS [MandatoryUnbufferTC],[ACPanel].[SwingerCount] AS [SwingerCount],[ACPanel].[SwingerTime] AS [SwingerTime],[ACPanel].[LoopNumb] AS [LoopNumb],[ACPanel].[PortNumb] AS [PortNumb],[ACPanel].[Notes] AS [Notes],[ACPanel].[Trouble] AS [Trouble],[ACPanel].[NoVersionCheck] AS [NoVersionCheck],[ACPanel].[RowVersion] AS [RowVersion],[ACPanel].[CreatedOn] AS [CreatedOn],[ACPanel].[CreatedBy] AS [CreatedBy],[ACPanel].[ModifiedOn] AS [ModifiedOn],[ACPanel].[ModifiedBy] AS [ModifiedBy],[ACPanel].[DeviceId] AS [DeviceId],[ACPanel].[DBSyncSeconds] AS [DBSyncSeconds],[ACPanel].[DBSaveMinutes] AS [DBSaveMinutes],[ACPanel].[IsE150] AS [IsE150],[ACPanel].[GroupID] AS [GroupID],[ACPanel].[NoAutoDownload] AS [NoAutoDownload],[ACPanel].[NoAutoDownloadStart] AS [NoAutoDownloadStart],[ACPanel].[Locked] AS [Locked],[ACPanel].[InDebug] AS [InDebug],[BDBuilding].[Address1] AS [Address1],[BDBuilding].[BuildingID] AS [BuildingID] FROM [{0}] [ACPanel] LEFT JOIN [BDBuilding] [BDBuilding] ON [ACPanel].[BDBuildingPK] = [BDBuilding].[BDBuildingPK]", this.TableName);
			}
		}

		protected override string SQLCount
		{
			get
			{
				return string.Format("SELECT COUNT(*) FROM [{0}] [ACPanel] LEFT JOIN [BDBuilding] [BDBuilding] ON [ACPanel].[BDBuildingPK] = [BDBuilding].[BDBuildingPK]", this.TableName);
			}
		}

		public int Insert(ACPanelData entity)
		{
			string sql = string.Format("INSERT INTO [{0}] ([ACPanelPK],[UnitID],[BDBuildingPK],[SerialNumber],[PanelName],[BufferSize],[DialUp],[UnitPhone],[UnitPhoneCallerID],[UnitExt],[LongDistance],[ModemInitString],[BaudRate],[HistoryPhone],[AlarmPhone1],[AlarmPhone2],[DialingPrefixPanel],[DialingSuffixPanel],[DialOutEnabled],[DayLightSaving],[OnSiteMonitor],[CentralDelay],[ElevPulse],[PanelTypeID],[UnbufferTC],[MandatoryUnbufferTC],[SwingerCount],[SwingerTime],[LoopNumb],[PortNumb],[Notes],[Trouble],[NoVersionCheck],[CreatedOn],[CreatedBy],[ModifiedOn],[ModifiedBy],[DeviceId],[DBSyncSeconds],[DBSaveMinutes],[IsE150],[GroupID],[NoAutoDownload],[NoAutoDownloadStart],[Locked],[InDebug]) VALUES(@ACPanelPK,@UnitID,@BDBuildingPK,@SerialNumber,@PanelName,@BufferSize,@DialUp,@UnitPhone,@UnitPhoneCallerID,@UnitExt,@LongDistance,@ModemInitString,@BaudRate,@HistoryPhone,@AlarmPhone1,@AlarmPhone2,@DialingPrefixPanel,@DialingSuffixPanel,@DialOutEnabled,@DayLightSaving,@OnSiteMonitor,@CentralDelay,@ElevPulse,@PanelTypeID,@UnbufferTC,@MandatoryUnbufferTC,@SwingerCount,@SwingerTime,@LoopNumb,@PortNumb,@Notes,@Trouble,@NoVersionCheck,@CreatedOn,@CreatedBy,@ModifiedOn,@ModifiedBy,@DeviceId,@DBSyncSeconds,@DBSaveMinutes,@IsE150,@GroupID,@NoAutoDownload,@NoAutoDownloadStart,@Locked,@InDebug)", this.TableName);
			SqlParameter[] paras = new SqlParameter[46];
			paras[0] = new SqlParameter("@ACPanelPK", SqlDbType.UniqueIdentifier);
			if (entity.ACPanelPK == Guid.Empty)
			{
				paras[0].Value = DBNull.Value;
			}
			else
			{
				paras[0].Value = entity.ACPanelPK;
			}
			paras[1] = new SqlParameter("@UnitID", SqlDbType.Int);
			paras[1].Value = entity.UnitID;
			paras[2] = new SqlParameter("@BDBuildingPK", SqlDbType.UniqueIdentifier);
			if (entity.BDBuildingPK == Guid.Empty)
			{
				paras[2].Value = DBNull.Value;
			}
			else
			{
				paras[2].Value = entity.BDBuildingPK;
			}
			paras[3] = new SqlParameter("@SerialNumber", SqlDbType.VarChar, 30);
			paras[3].Value = entity.SerialNumber;
			paras[4] = new SqlParameter("@PanelName", SqlDbType.VarChar, 50);
			paras[4].Value = entity.PanelName;
			paras[5] = new SqlParameter("@BufferSize", SqlDbType.SmallInt);
			paras[5].Value = entity.BufferSize;
			paras[6] = new SqlParameter("@DialUp", SqlDbType.Bit);
			paras[6].Value = entity.DialUp;
			paras[7] = new SqlParameter("@UnitPhone", SqlDbType.VarChar, 35);
			paras[7].Value = entity.UnitPhone;
			paras[8] = new SqlParameter("@UnitPhoneCallerID", SqlDbType.VarChar, 35);
			paras[8].Value = entity.UnitPhoneCallerID;
			paras[9] = new SqlParameter("@UnitExt", SqlDbType.VarChar, 10);
			paras[9].Value = entity.UnitExt;
			paras[10] = new SqlParameter("@LongDistance", SqlDbType.Bit);
			paras[10].Value = entity.LongDistance;
			paras[11] = new SqlParameter("@ModemInitString", SqlDbType.VarChar, 256);
			paras[11].Value = entity.ModemInitString;
			paras[12] = new SqlParameter("@BaudRate", SqlDbType.Int);
			paras[12].Value = entity.BaudRate;
			paras[13] = new SqlParameter("@HistoryPhone", SqlDbType.VarChar, 25);
			paras[13].Value = entity.HistoryPhone;
			paras[14] = new SqlParameter("@AlarmPhone1", SqlDbType.VarChar, 25);
			paras[14].Value = entity.AlarmPhone1;
			paras[15] = new SqlParameter("@AlarmPhone2", SqlDbType.VarChar, 25);
			paras[15].Value = entity.AlarmPhone2;
			paras[16] = new SqlParameter("@DialingPrefixPanel", SqlDbType.VarChar, 5);
			paras[16].Value = entity.DialingPrefixPanel;
			paras[17] = new SqlParameter("@DialingSuffixPanel", SqlDbType.VarChar, 10);
			paras[17].Value = entity.DialingSuffixPanel;
			paras[18] = new SqlParameter("@DialOutEnabled", SqlDbType.Bit);
			paras[18].Value = entity.DialOutEnabled;
			paras[19] = new SqlParameter("@DayLightSaving", SqlDbType.Bit);
			paras[19].Value = entity.DayLightSaving;
			paras[20] = new SqlParameter("@OnSiteMonitor", SqlDbType.Bit);
			paras[20].Value = entity.OnSiteMonitor;
			paras[21] = new SqlParameter("@CentralDelay", SqlDbType.TinyInt);
			paras[21].Value = entity.CentralDelay;
			paras[22] = new SqlParameter("@ElevPulse", SqlDbType.TinyInt);
			paras[22].Value = entity.ElevPulse;
			paras[23] = new SqlParameter("@PanelTypeID", SqlDbType.Int);
			paras[23].Value = entity.PanelTypeID;
			paras[24] = new SqlParameter("@UnbufferTC", SqlDbType.SmallInt);
			paras[24].Value = entity.UnbufferTC;
			paras[25] = new SqlParameter("@MandatoryUnbufferTC", SqlDbType.SmallInt);
			paras[25].Value = entity.MandatoryUnbufferTC;
			paras[26] = new SqlParameter("@SwingerCount", SqlDbType.SmallInt);
			paras[26].Value = entity.SwingerCount;
			paras[27] = new SqlParameter("@SwingerTime", SqlDbType.SmallInt);
			paras[27].Value = entity.SwingerTime;
			paras[28] = new SqlParameter("@LoopNumb", SqlDbType.TinyInt);
			paras[28].Value = entity.LoopNumb;
			paras[29] = new SqlParameter("@PortNumb", SqlDbType.TinyInt);
			paras[29].Value = entity.PortNumb;
			paras[30] = new SqlParameter("@Notes", SqlDbType.VarChar, 4096);
			paras[30].Value = entity.Notes;
			paras[31] = new SqlParameter("@Trouble", SqlDbType.Bit);
			paras[31].Value = entity.Trouble;
			paras[32] = new SqlParameter("@NoVersionCheck", SqlDbType.Bit);
			paras[32].Value = entity.NoVersionCheck;
			paras[33] = new SqlParameter("@CreatedOn", SqlDbType.DateTime);
			paras[33].Value = entity.CreatedOn;
			paras[34] = new SqlParameter("@CreatedBy", SqlDbType.VarChar, 30);
			paras[34].Value = entity.CreatedBy;
			paras[35] = new SqlParameter("@ModifiedOn", SqlDbType.DateTime);
			paras[35].Value = entity.ModifiedOn;
			paras[36] = new SqlParameter("@ModifiedBy", SqlDbType.VarChar, 30);
			paras[36].Value = entity.ModifiedBy;
			paras[37] = new SqlParameter("@DeviceId", SqlDbType.UniqueIdentifier);
			if (entity.DeviceId == Guid.Empty)
			{
				paras[37].Value = DBNull.Value;
			}
			else
			{
				paras[37].Value = entity.DeviceId;
			}
			paras[38] = new SqlParameter("@DBSyncSeconds", SqlDbType.Int);
			paras[38].Value = entity.DBSyncSeconds;
			paras[39] = new SqlParameter("@DBSaveMinutes", SqlDbType.Int);
			paras[39].Value = entity.DBSaveMinutes;
			paras[40] = new SqlParameter("@IsE150", SqlDbType.Bit);
			paras[40].Value = entity.IsE150;
			paras[41] = new SqlParameter("@GroupID", SqlDbType.TinyInt);
			paras[41].Value = entity.GroupID;
			paras[42] = new SqlParameter("@NoAutoDownload", SqlDbType.Bit);
			paras[42].Value = entity.NoAutoDownload;
			paras[43] = new SqlParameter("@NoAutoDownloadStart", SqlDbType.DateTime);
			paras[43].Value = entity.NoAutoDownloadStart;
			paras[44] = new SqlParameter("@Locked", SqlDbType.Bit);
			paras[44].Value = entity.Locked;
			paras[45] = new SqlParameter("@InDebug", SqlDbType.Bit);
			paras[45].Value = entity.InDebug;
			return base.ExecuteNonQuery(sql, paras);
		}

		public int Update(ACPanelData entity)
		{
			string sql = string.Format("UPDATE [{0}] SET [UnitID] = @UnitID,[BDBuildingPK] = @BDBuildingPK,[SerialNumber] = @SerialNumber,[PanelName] = @PanelName,[BufferSize] = @BufferSize,[DialUp] = @DialUp,[UnitPhone] = @UnitPhone,[UnitPhoneCallerID] = @UnitPhoneCallerID,[UnitExt] = @UnitExt,[LongDistance] = @LongDistance,[ModemInitString] = @ModemInitString,[BaudRate] = @BaudRate,[HistoryPhone] = @HistoryPhone,[AlarmPhone1] = @AlarmPhone1,[AlarmPhone2] = @AlarmPhone2,[DialingPrefixPanel] = @DialingPrefixPanel,[DialingSuffixPanel] = @DialingSuffixPanel,[DialOutEnabled] = @DialOutEnabled,[DayLightSaving] = @DayLightSaving,[OnSiteMonitor] = @OnSiteMonitor,[CentralDelay] = @CentralDelay,[ElevPulse] = @ElevPulse,[PanelTypeID] = @PanelTypeID,[UnbufferTC] = @UnbufferTC,[MandatoryUnbufferTC] = @MandatoryUnbufferTC,[SwingerCount] = @SwingerCount,[SwingerTime] = @SwingerTime,[LoopNumb] = @LoopNumb,[PortNumb] = @PortNumb,[Notes] = @Notes,[Trouble] = @Trouble,[NoVersionCheck] = @NoVersionCheck,[CreatedOn] = @CreatedOn,[CreatedBy] = @CreatedBy,[ModifiedOn] = @ModifiedOn,[ModifiedBy] = @ModifiedBy,[DeviceId] = @DeviceId,[DBSyncSeconds] = @DBSyncSeconds,[DBSaveMinutes] = @DBSaveMinutes,[IsE150] = @IsE150,[GroupID] = @GroupID,[NoAutoDownload] = @NoAutoDownload,[NoAutoDownloadStart] = @NoAutoDownloadStart,[Locked] = @Locked,[InDebug] = @InDebug  WHERE [ACPanelPK] = @ACPanelPK AND [RowVersion] = @RowVersion", this.TableName);
			SqlParameter[] paras = new SqlParameter[47];
			paras[0] = new SqlParameter("@ACPanelPK", SqlDbType.UniqueIdentifier);
			if (entity.ACPanelPK == Guid.Empty)
			{
				paras[0].Value = DBNull.Value;
			}
			else
			{
				paras[0].Value = entity.ACPanelPK;
			}
			paras[1] = new SqlParameter("@UnitID", SqlDbType.Int);
			paras[1].Value = entity.UnitID;
			paras[2] = new SqlParameter("@BDBuildingPK", SqlDbType.UniqueIdentifier);
			if (entity.BDBuildingPK == Guid.Empty)
			{
				paras[2].Value = DBNull.Value;
			}
			else
			{
				paras[2].Value = entity.BDBuildingPK;
			}
			paras[3] = new SqlParameter("@SerialNumber", SqlDbType.VarChar, 30);
			paras[3].Value = entity.SerialNumber;
			paras[4] = new SqlParameter("@PanelName", SqlDbType.VarChar, 50);
			paras[4].Value = entity.PanelName;
			paras[5] = new SqlParameter("@BufferSize", SqlDbType.SmallInt);
			paras[5].Value = entity.BufferSize;
			paras[6] = new SqlParameter("@DialUp", SqlDbType.Bit);
			paras[6].Value = entity.DialUp;
			paras[7] = new SqlParameter("@UnitPhone", SqlDbType.VarChar, 35);
			paras[7].Value = entity.UnitPhone;
			paras[8] = new SqlParameter("@UnitPhoneCallerID", SqlDbType.VarChar, 35);
			paras[8].Value = entity.UnitPhoneCallerID;
			paras[9] = new SqlParameter("@UnitExt", SqlDbType.VarChar, 10);
			paras[9].Value = entity.UnitExt;
			paras[10] = new SqlParameter("@LongDistance", SqlDbType.Bit);
			paras[10].Value = entity.LongDistance;
			paras[11] = new SqlParameter("@ModemInitString", SqlDbType.VarChar, 256);
			paras[11].Value = entity.ModemInitString;
			paras[12] = new SqlParameter("@BaudRate", SqlDbType.Int);
			paras[12].Value = entity.BaudRate;
			paras[13] = new SqlParameter("@HistoryPhone", SqlDbType.VarChar, 25);
			paras[13].Value = entity.HistoryPhone;
			paras[14] = new SqlParameter("@AlarmPhone1", SqlDbType.VarChar, 25);
			paras[14].Value = entity.AlarmPhone1;
			paras[15] = new SqlParameter("@AlarmPhone2", SqlDbType.VarChar, 25);
			paras[15].Value = entity.AlarmPhone2;
			paras[16] = new SqlParameter("@DialingPrefixPanel", SqlDbType.VarChar, 5);
			paras[16].Value = entity.DialingPrefixPanel;
			paras[17] = new SqlParameter("@DialingSuffixPanel", SqlDbType.VarChar, 10);
			paras[17].Value = entity.DialingSuffixPanel;
			paras[18] = new SqlParameter("@DialOutEnabled", SqlDbType.Bit);
			paras[18].Value = entity.DialOutEnabled;
			paras[19] = new SqlParameter("@DayLightSaving", SqlDbType.Bit);
			paras[19].Value = entity.DayLightSaving;
			paras[20] = new SqlParameter("@OnSiteMonitor", SqlDbType.Bit);
			paras[20].Value = entity.OnSiteMonitor;
			paras[21] = new SqlParameter("@CentralDelay", SqlDbType.TinyInt);
			paras[21].Value = entity.CentralDelay;
			paras[22] = new SqlParameter("@ElevPulse", SqlDbType.TinyInt);
			paras[22].Value = entity.ElevPulse;
			paras[23] = new SqlParameter("@PanelTypeID", SqlDbType.Int);
			paras[23].Value = entity.PanelTypeID;
			paras[24] = new SqlParameter("@UnbufferTC", SqlDbType.SmallInt);
			paras[24].Value = entity.UnbufferTC;
			paras[25] = new SqlParameter("@MandatoryUnbufferTC", SqlDbType.SmallInt);
			paras[25].Value = entity.MandatoryUnbufferTC;
			paras[26] = new SqlParameter("@SwingerCount", SqlDbType.SmallInt);
			paras[26].Value = entity.SwingerCount;
			paras[27] = new SqlParameter("@SwingerTime", SqlDbType.SmallInt);
			paras[27].Value = entity.SwingerTime;
			paras[28] = new SqlParameter("@LoopNumb", SqlDbType.TinyInt);
			paras[28].Value = entity.LoopNumb;
			paras[29] = new SqlParameter("@PortNumb", SqlDbType.TinyInt);
			paras[29].Value = entity.PortNumb;
			paras[30] = new SqlParameter("@Notes", SqlDbType.VarChar, 4096);
			paras[30].Value = entity.Notes;
			paras[31] = new SqlParameter("@Trouble", SqlDbType.Bit);
			paras[31].Value = entity.Trouble;
			paras[32] = new SqlParameter("@NoVersionCheck", SqlDbType.Bit);
			paras[32].Value = entity.NoVersionCheck;
			paras[33] = new SqlParameter("@RowVersion", SqlDbType.Timestamp);
			paras[33].Value = entity.RowVersion;
			paras[34] = new SqlParameter("@CreatedOn", SqlDbType.DateTime);
			paras[34].Value = entity.CreatedOn;
			paras[35] = new SqlParameter("@CreatedBy", SqlDbType.VarChar, 30);
			paras[35].Value = entity.CreatedBy;
			paras[36] = new SqlParameter("@ModifiedOn", SqlDbType.DateTime);
			paras[36].Value = entity.ModifiedOn;
			paras[37] = new SqlParameter("@ModifiedBy", SqlDbType.VarChar, 30);
			paras[37].Value = entity.ModifiedBy;
			paras[38] = new SqlParameter("@DeviceId", SqlDbType.UniqueIdentifier);
			if (entity.DeviceId == Guid.Empty)
			{
				paras[38].Value = DBNull.Value;
			}
			else
			{
				paras[38].Value = entity.DeviceId;
			}
			paras[39] = new SqlParameter("@DBSyncSeconds", SqlDbType.Int);
			paras[39].Value = entity.DBSyncSeconds;
			paras[40] = new SqlParameter("@DBSaveMinutes", SqlDbType.Int);
			paras[40].Value = entity.DBSaveMinutes;
			paras[41] = new SqlParameter("@IsE150", SqlDbType.Bit);
			paras[41].Value = entity.IsE150;
			paras[42] = new SqlParameter("@GroupID", SqlDbType.TinyInt);
			paras[42].Value = entity.GroupID;
			paras[43] = new SqlParameter("@NoAutoDownload", SqlDbType.Bit);
			paras[43].Value = entity.NoAutoDownload;
			paras[44] = new SqlParameter("@NoAutoDownloadStart", SqlDbType.DateTime);
			paras[44].Value = entity.NoAutoDownloadStart;
			paras[45] = new SqlParameter("@Locked", SqlDbType.Bit);
			paras[45].Value = entity.Locked;
			paras[46] = new SqlParameter("@InDebug", SqlDbType.Bit);
			paras[46].Value = entity.InDebug;
			return base.ExecuteNonQuery(sql, paras);
		}

		private ACPanelData CreateDataByReader(SafeDataReader reader)
		{
			ACPanelData data = new ACPanelData {
				ACPanelPK = (Guid) reader["ACPanelPK"],
				UnitID = (Int32) reader["UnitID"],
				BDBuildingPK = (Guid) reader["BDBuildingPK"],
				SerialNumber = (String) reader["SerialNumber"],
				PanelName = (String) reader["PanelName"],
				BufferSize = (Int16) reader["BufferSize"],
				DialUp = (Boolean) reader["DialUp"],
				UnitPhone = (String) reader["UnitPhone"],
				UnitPhoneCallerID = (String) reader["UnitPhoneCallerID"],
				UnitExt = (String) reader["UnitExt"],
				LongDistance = (Boolean) reader["LongDistance"],
				ModemInitString = (String) reader["ModemInitString"],
				BaudRate = (Int32) reader["BaudRate"],
				HistoryPhone = (String) reader["HistoryPhone"],
				AlarmPhone1 = (String) reader["AlarmPhone1"],
				AlarmPhone2 = (String) reader["AlarmPhone2"],
				DialingPrefixPanel = (String) reader["DialingPrefixPanel"],
				DialingSuffixPanel = (String) reader["DialingSuffixPanel"],
				DialOutEnabled = (Boolean) reader["DialOutEnabled"],
				DayLightSaving = (Boolean) reader["DayLightSaving"],
				OnSiteMonitor = (Boolean) reader["OnSiteMonitor"],
				CentralDelay = (Byte) reader["CentralDelay"],
				ElevPulse = (Byte) reader["ElevPulse"],
				PanelTypeID = (Int32) reader["PanelTypeID"],
				UnbufferTC = (Int16) reader["UnbufferTC"],
				MandatoryUnbufferTC = (Int16) reader["MandatoryUnbufferTC"],
				SwingerCount = (Int16) reader["SwingerCount"],
				SwingerTime = (Int16) reader["SwingerTime"],
				LoopNumb = (Byte) reader["LoopNumb"],
				PortNumb = (Byte) reader["PortNumb"],
				Notes = (String) reader["Notes"],
				Trouble = (Boolean) reader["Trouble"],
				NoVersionCheck = (Boolean) reader["NoVersionCheck"],
				RowVersion = (Byte[]) reader["RowVersion"],
				CreatedOn = (DateTime) reader["CreatedOn"],
				CreatedBy = (String) reader["CreatedBy"],
				ModifiedOn = (DateTime) reader["ModifiedOn"],
				ModifiedBy = (String) reader["ModifiedBy"],
				DeviceId = (Guid) reader["DeviceId"],
				DBSyncSeconds = (Int32) reader["DBSyncSeconds"],
				DBSaveMinutes = (Int32) reader["DBSaveMinutes"],
				IsE150 = (Boolean) reader["IsE150"],
				GroupID = (Byte) reader["GroupID"],
				NoAutoDownload = (Boolean) reader["NoAutoDownload"],
				NoAutoDownloadStart = (DateTime) reader["NoAutoDownloadStart"],
				Locked = (Boolean) reader["Locked"],
				InDebug = (Boolean) reader["InDebug"],
				Address1 = (String) reader["Address1"],
				BuildingID = (Int32) reader["BuildingID"]
			};
			data.AcceptChanges();
			return data;
		}

		private ACPanelData FetchEntity(string where, SqlParameter[] paras)
		{
			ACPanelData data = null;
			using (SafeDataReader reader = base.ExecuteDataReader(where, paras))
			{
				if (reader.Read())
				{
					data = this.CreateDataByReader(reader);
				}
				reader.Close();
			}
			return data;
		}

		private ACPanelData FetchEntityEx(string sql, SqlParameter[] paras)
		{
			ACPanelData data = null;
			using (SafeDataReader reader = base.ExecuteDataReaderEx(sql, paras))
			{
				if (reader.Read())
				{
					data = this.CreateDataByReader(reader);
				}
				reader.Close();
			}
			return data;
		}

		private ACPanelDataCollection FetchCollection(string where, SqlParameter[] paras)
		{
			ACPanelDataCollection list = new ACPanelDataCollection();
			using (SafeDataReader reader = base.ExecuteDataReader(where, paras))
			{
				while(reader.Read())
				{
					ACPanelData data = this.CreateDataByReader(reader);
					list.Add(data);
				}
				reader.Close();
			}
			return list;
		}

		private ACPanelDataCollection FetchCollectionEx(string sql, SqlParameter[] paras)
		{
			ACPanelDataCollection list = new ACPanelDataCollection();
			using (SafeDataReader reader = base.ExecuteDataReaderEx(sql, paras))
			{
				while(reader.Read())
				{
					ACPanelData data = this.CreateDataByReader(reader);
					list.Add(data);
				}
				reader.Close();
			}
			return list;
		}

		public ACPanelData GetEntityBy(string sqlWhere, SqlParameter[] paras)
		{
			return this.FetchEntity(sqlWhere, paras);
		}

		public ACPanelData GetEntityExBy(string sql, SqlParameter[] paras)
		{
			return this.FetchEntityEx(sql, paras);
		}

		public ACPanelDataCollection GetCollectionBy(string sqlWhere, SqlParameter[] paras)
		{
			return this.FetchCollection(sqlWhere, paras);
		}

		public ACPanelDataCollection GetCollectionExBy(string sql, SqlParameter[] paras)
		{
			return this.FetchCollectionEx(sql, paras);
		}

		public byte[] GetRowVersion( System.Guid ACPanelPK)
		{
			string sql = string.Format("SELECT [RowVersion] AS [RowVersion] FROM [{0}] WHERE  [ACPanelPK] = @ACPanelPK ", this.TableName);
			SqlParameter[] paras = new SqlParameter[1];
			paras[0] = new SqlParameter("@ACPanelPK", SqlDbType.UniqueIdentifier, 16);
			paras[0].Value = ACPanelPK;
			return (byte[]) base.ExecuteScalar(sql, paras);
		}

		public ACPanelData GetByPK( System.Guid ACPanelPK)
		{
			string sql = " WHERE  [ACPanel].[ACPanelPK] = @ACPanelPK ";
			SqlParameter[] paras = new SqlParameter[1];
			paras[0] = new SqlParameter("@ACPanelPK", SqlDbType.UniqueIdentifier);
			paras[0].Value = ACPanelPK;
			return this.FetchEntity(sql, paras);
		}

		public ACPanelDataCollection GetAll()
		{
			return this.FetchCollection("", null);
		}

		public ACPanelDataCollection GetByBDBuilding(System.Guid BDBuildingPK)
		{
			string sqlWhere = " WHERE [ACPanel].[BDBuildingPK] = @BDBuildingPK";
			SqlParameter[] paras = new SqlParameter[1];
			paras[0] = new SqlParameter("@BDBuildingPK", SqlDbType.UniqueIdentifier);
			paras[0].Value = BDBuildingPK;
			return this.FetchCollection(sqlWhere, paras);
		}

		public DataTable GetLogByPK( System.Guid ACPanelPK)
		{
			string sql = string.Format("SELECT  [ACPanel].[ACPanelPK] AS [ACPanelPK], [ACPanel].[ModifiedOn] AS [ModifiedOn] FROM [{0}] WHERE  [ACPanel].[ACPanelPK] = @ACPanelPK ", this.TableName);
			SqlParameter[] paras = new SqlParameter[1];
			paras[0] = new SqlParameter("@ACPanelPK", SqlDbType.UniqueIdentifier);
			paras[0].Value = ACPanelPK;
			return this.ExecuteDataTable(sql, paras);
		}

		public DataTable GetLogByBDBuilding(System.Guid bDBuildingPK)
		{
			string sql = string.Format("DELETE [{0}] FROM [{0}] [ACPanel] INNER JOIN [BDBuilding] ON [ACPanel].[BDBuildingPK] = [BDBuilding].[BDBuildingPK] WHERE [BDBuilding].[BDBuildingPK] = @BDBuildingPK;", this.TableName);
			string oldValue = string.Format("DELETE [{0}]", this.TableName);
			string newValue = "SELECT  [ACPanel].[ACPanelPK] AS [ACPanelPK], [ACPanel].[ModifiedOn] AS [ModifiedOn]";
			sql = sql.Replace(oldValue, newValue).TrimEnd().TrimEnd(';').Replace(";", " UNION ");
			SqlParameter[] paras = new SqlParameter[1];
			paras[0] = new SqlParameter("@BDBuildingPK", SqlDbType.UniqueIdentifier);
			paras[0].Value = bDBuildingPK;
			return base.ExecuteDataTable(sql, paras);
		}

		public int DeleteByPK( System.Guid ACPanelPK, byte[] RowVersion)
		{
			string sql = string.Format("DELETE FROM [{0}] WHERE  [ACPanelPK] = @ACPanelPK AND [RowVersion] = @RowVersion", this.TableName);
			SqlParameter[] paras = new SqlParameter[2];
			paras[0] = new SqlParameter("@ACPanelPK", SqlDbType.UniqueIdentifier);
			paras[0].Value = ACPanelPK;
			paras[1] = new SqlParameter("@RowVersion", SqlDbType.Timestamp, 8);
			paras[1].Value = RowVersion;
			return base.ExecuteNonQuery(sql, paras);
		}

		public int DeleteAll()
		{
			string sql = string.Format("DELETE FROM [{0}]", this.TableName);
			return base.ExecuteNonQuery(sql, null);
		}

		public int DeleteByBDBuilding(System.Guid bDBuildingPK)
		{
			string sql = string.Format("DELETE [{0}] FROM [{0}] [ACPanel] INNER JOIN [BDBuilding] ON [ACPanel].[BDBuildingPK] = [BDBuilding].[BDBuildingPK] WHERE [BDBuilding].[BDBuildingPK] = @BDBuildingPK;", this.TableName);
			SqlParameter[] paras = new SqlParameter[1];
			paras[0] = new SqlParameter("@BDBuildingPK", SqlDbType.UniqueIdentifier);
			paras[0].Value = bDBuildingPK;
			return base.ExecuteNonQuery(sql, paras);
		}


	}
	public class UsrAccountDBRuleCRUD : DataAccessBase
	{
		private string _tableName = "UsrAccountDBRule";

		public UsrAccountDBRuleCRUD(string connectionString) : base(connectionString)
		{
		}

		public virtual string TableName
		{
			get { return this._tableName; }
			set { this._tableName = value; }
		}

		public string SQLColumns
		{
			get
			{
				return "[UsrAccountDBRule].[UsrAccountDBRulePK] AS [UsrAccountDBRulePK],[UsrAccountDBRule].[UsrAccountPK] AS [UsrAccountPK],[UsrAccountDBRule].[DBRuleID] AS [DBRuleID],[UsrAccountDBRule].[Selectable] AS [Selectable],[UsrAccountDBRule].[Insertable] AS [Insertable],[UsrAccountDBRule].[Editable] AS [Editable],[UsrAccountDBRule].[Deletable] AS [Deletable],[UsrAccountDBRule].[RowVersion] AS [RowVersion],[UsrAccountDBRule].[CreatedOn] AS [CreatedOn],[UsrAccountDBRule].[CreatedBy] AS [CreatedBy],[UsrAccountDBRule].[ModifiedOn] AS [ModifiedOn],[UsrAccountDBRule].[ModifiedBy] AS [ModifiedBy],[UsrAccount].[UserID] AS [UserID]";
			}
		}

		public string SQLLeftJoins
		{
			get
			{
				return "LEFT JOIN [UsrAccount] [UsrAccount] ON [UsrAccountDBRule].[UsrAccountPK] = [UsrAccount].[UsrAccountPK]";
			}
		}

		protected override string SQLSelect
		{
			get
			{
				return string.Format("SELECT [UsrAccountDBRule].[UsrAccountDBRulePK] AS [UsrAccountDBRulePK],[UsrAccountDBRule].[UsrAccountPK] AS [UsrAccountPK],[UsrAccountDBRule].[DBRuleID] AS [DBRuleID],[UsrAccountDBRule].[Selectable] AS [Selectable],[UsrAccountDBRule].[Insertable] AS [Insertable],[UsrAccountDBRule].[Editable] AS [Editable],[UsrAccountDBRule].[Deletable] AS [Deletable],[UsrAccountDBRule].[RowVersion] AS [RowVersion],[UsrAccountDBRule].[CreatedOn] AS [CreatedOn],[UsrAccountDBRule].[CreatedBy] AS [CreatedBy],[UsrAccountDBRule].[ModifiedOn] AS [ModifiedOn],[UsrAccountDBRule].[ModifiedBy] AS [ModifiedBy],[UsrAccount].[UserID] AS [UserID] FROM [{0}] [UsrAccountDBRule] LEFT JOIN [UsrAccount] [UsrAccount] ON [UsrAccountDBRule].[UsrAccountPK] = [UsrAccount].[UsrAccountPK]", this.TableName);
			}
		}

		protected override string SQLCount
		{
			get
			{
				return string.Format("SELECT COUNT(*) FROM [{0}] [UsrAccountDBRule] LEFT JOIN [UsrAccount] [UsrAccount] ON [UsrAccountDBRule].[UsrAccountPK] = [UsrAccount].[UsrAccountPK]", this.TableName);
			}
		}

		public int Insert(UsrAccountDBRuleData entity)
		{
			string sql = string.Format("INSERT INTO [{0}] ([UsrAccountDBRulePK],[UsrAccountPK],[DBRuleID],[Selectable],[Insertable],[Editable],[Deletable],[CreatedOn],[CreatedBy],[ModifiedOn],[ModifiedBy]) VALUES(@UsrAccountDBRulePK,@UsrAccountPK,@DBRuleID,@Selectable,@Insertable,@Editable,@Deletable,@CreatedOn,@CreatedBy,@ModifiedOn,@ModifiedBy)", this.TableName);
			SqlParameter[] paras = new SqlParameter[11];
			paras[0] = new SqlParameter("@UsrAccountDBRulePK", SqlDbType.UniqueIdentifier);
			if (entity.UsrAccountDBRulePK == Guid.Empty)
			{
				paras[0].Value = DBNull.Value;
			}
			else
			{
				paras[0].Value = entity.UsrAccountDBRulePK;
			}
			paras[1] = new SqlParameter("@UsrAccountPK", SqlDbType.UniqueIdentifier);
			if (entity.UsrAccountPK == Guid.Empty)
			{
				paras[1].Value = DBNull.Value;
			}
			else
			{
				paras[1].Value = entity.UsrAccountPK;
			}
			paras[2] = new SqlParameter("@DBRuleID", SqlDbType.Int);
			paras[2].Value = entity.DBRuleID;
			paras[3] = new SqlParameter("@Selectable", SqlDbType.Bit);
			paras[3].Value = entity.Selectable;
			paras[4] = new SqlParameter("@Insertable", SqlDbType.Bit);
			paras[4].Value = entity.Insertable;
			paras[5] = new SqlParameter("@Editable", SqlDbType.Bit);
			paras[5].Value = entity.Editable;
			paras[6] = new SqlParameter("@Deletable", SqlDbType.Bit);
			paras[6].Value = entity.Deletable;
			paras[7] = new SqlParameter("@CreatedOn", SqlDbType.DateTime);
			paras[7].Value = entity.CreatedOn;
			paras[8] = new SqlParameter("@CreatedBy", SqlDbType.VarChar, 30);
			paras[8].Value = entity.CreatedBy;
			paras[9] = new SqlParameter("@ModifiedOn", SqlDbType.DateTime);
			paras[9].Value = entity.ModifiedOn;
			paras[10] = new SqlParameter("@ModifiedBy", SqlDbType.VarChar, 30);
			paras[10].Value = entity.ModifiedBy;
			return base.ExecuteNonQuery(sql, paras);
		}

		public int Update(UsrAccountDBRuleData entity)
		{
			string sql = string.Format("UPDATE [{0}] SET [UsrAccountPK] = @UsrAccountPK,[DBRuleID] = @DBRuleID,[Selectable] = @Selectable,[Insertable] = @Insertable,[Editable] = @Editable,[Deletable] = @Deletable,[CreatedOn] = @CreatedOn,[CreatedBy] = @CreatedBy,[ModifiedOn] = @ModifiedOn,[ModifiedBy] = @ModifiedBy  WHERE [UsrAccountDBRulePK] = @UsrAccountDBRulePK AND [RowVersion] = @RowVersion", this.TableName);
			SqlParameter[] paras = new SqlParameter[12];
			paras[0] = new SqlParameter("@UsrAccountDBRulePK", SqlDbType.UniqueIdentifier);
			if (entity.UsrAccountDBRulePK == Guid.Empty)
			{
				paras[0].Value = DBNull.Value;
			}
			else
			{
				paras[0].Value = entity.UsrAccountDBRulePK;
			}
			paras[1] = new SqlParameter("@UsrAccountPK", SqlDbType.UniqueIdentifier);
			if (entity.UsrAccountPK == Guid.Empty)
			{
				paras[1].Value = DBNull.Value;
			}
			else
			{
				paras[1].Value = entity.UsrAccountPK;
			}
			paras[2] = new SqlParameter("@DBRuleID", SqlDbType.Int);
			paras[2].Value = entity.DBRuleID;
			paras[3] = new SqlParameter("@Selectable", SqlDbType.Bit);
			paras[3].Value = entity.Selectable;
			paras[4] = new SqlParameter("@Insertable", SqlDbType.Bit);
			paras[4].Value = entity.Insertable;
			paras[5] = new SqlParameter("@Editable", SqlDbType.Bit);
			paras[5].Value = entity.Editable;
			paras[6] = new SqlParameter("@Deletable", SqlDbType.Bit);
			paras[6].Value = entity.Deletable;
			paras[7] = new SqlParameter("@RowVersion", SqlDbType.Timestamp);
			paras[7].Value = entity.RowVersion;
			paras[8] = new SqlParameter("@CreatedOn", SqlDbType.DateTime);
			paras[8].Value = entity.CreatedOn;
			paras[9] = new SqlParameter("@CreatedBy", SqlDbType.VarChar, 30);
			paras[9].Value = entity.CreatedBy;
			paras[10] = new SqlParameter("@ModifiedOn", SqlDbType.DateTime);
			paras[10].Value = entity.ModifiedOn;
			paras[11] = new SqlParameter("@ModifiedBy", SqlDbType.VarChar, 30);
			paras[11].Value = entity.ModifiedBy;
			return base.ExecuteNonQuery(sql, paras);
		}

		private UsrAccountDBRuleData CreateDataByReader(SafeDataReader reader)
		{
			UsrAccountDBRuleData data = new UsrAccountDBRuleData {
				UsrAccountDBRulePK = (Guid) reader["UsrAccountDBRulePK"],
				UsrAccountPK = (Guid) reader["UsrAccountPK"],
				DBRuleID = (Int32) reader["DBRuleID"],
				Selectable = (Boolean) reader["Selectable"],
				Insertable = (Boolean) reader["Insertable"],
				Editable = (Boolean) reader["Editable"],
				Deletable = (Boolean) reader["Deletable"],
				RowVersion = (Byte[]) reader["RowVersion"],
				CreatedOn = (DateTime) reader["CreatedOn"],
				CreatedBy = (String) reader["CreatedBy"],
				ModifiedOn = (DateTime) reader["ModifiedOn"],
				ModifiedBy = (String) reader["ModifiedBy"],
				UserID = (String) reader["UserID"]
			};
			data.AcceptChanges();
			return data;
		}

		private UsrAccountDBRuleData FetchEntity(string where, SqlParameter[] paras)
		{
			UsrAccountDBRuleData data = null;
			using (SafeDataReader reader = base.ExecuteDataReader(where, paras))
			{
				if (reader.Read())
				{
					data = this.CreateDataByReader(reader);
				}
				reader.Close();
			}
			return data;
		}

		private UsrAccountDBRuleData FetchEntityEx(string sql, SqlParameter[] paras)
		{
			UsrAccountDBRuleData data = null;
			using (SafeDataReader reader = base.ExecuteDataReaderEx(sql, paras))
			{
				if (reader.Read())
				{
					data = this.CreateDataByReader(reader);
				}
				reader.Close();
			}
			return data;
		}

		private UsrAccountDBRuleDataCollection FetchCollection(string where, SqlParameter[] paras)
		{
			UsrAccountDBRuleDataCollection list = new UsrAccountDBRuleDataCollection();
			using (SafeDataReader reader = base.ExecuteDataReader(where, paras))
			{
				while(reader.Read())
				{
					UsrAccountDBRuleData data = this.CreateDataByReader(reader);
					list.Add(data);
				}
				reader.Close();
			}
			return list;
		}

		private UsrAccountDBRuleDataCollection FetchCollectionEx(string sql, SqlParameter[] paras)
		{
			UsrAccountDBRuleDataCollection list = new UsrAccountDBRuleDataCollection();
			using (SafeDataReader reader = base.ExecuteDataReaderEx(sql, paras))
			{
				while(reader.Read())
				{
					UsrAccountDBRuleData data = this.CreateDataByReader(reader);
					list.Add(data);
				}
				reader.Close();
			}
			return list;
		}

		public UsrAccountDBRuleData GetEntityBy(string sqlWhere, SqlParameter[] paras)
		{
			return this.FetchEntity(sqlWhere, paras);
		}

		public UsrAccountDBRuleData GetEntityExBy(string sql, SqlParameter[] paras)
		{
			return this.FetchEntityEx(sql, paras);
		}

		public UsrAccountDBRuleDataCollection GetCollectionBy(string sqlWhere, SqlParameter[] paras)
		{
			return this.FetchCollection(sqlWhere, paras);
		}

		public UsrAccountDBRuleDataCollection GetCollectionExBy(string sql, SqlParameter[] paras)
		{
			return this.FetchCollectionEx(sql, paras);
		}

		public byte[] GetRowVersion( System.Guid UsrAccountDBRulePK)
		{
			string sql = string.Format("SELECT [RowVersion] AS [RowVersion] FROM [{0}] WHERE  [UsrAccountDBRulePK] = @UsrAccountDBRulePK ", this.TableName);
			SqlParameter[] paras = new SqlParameter[1];
			paras[0] = new SqlParameter("@UsrAccountDBRulePK", SqlDbType.UniqueIdentifier, 16);
			paras[0].Value = UsrAccountDBRulePK;
			return (byte[]) base.ExecuteScalar(sql, paras);
		}

		public UsrAccountDBRuleData GetByPK( System.Guid UsrAccountDBRulePK)
		{
			string sql = " WHERE  [UsrAccountDBRule].[UsrAccountDBRulePK] = @UsrAccountDBRulePK ";
			SqlParameter[] paras = new SqlParameter[1];
			paras[0] = new SqlParameter("@UsrAccountDBRulePK", SqlDbType.UniqueIdentifier);
			paras[0].Value = UsrAccountDBRulePK;
			return this.FetchEntity(sql, paras);
		}

		public UsrAccountDBRuleDataCollection GetAll()
		{
			return this.FetchCollection("", null);
		}

		public UsrAccountDBRuleDataCollection GetByUsrAccount(System.Guid UsrAccountPK)
		{
			string sqlWhere = " WHERE [UsrAccountDBRule].[UsrAccountPK] = @UsrAccountPK";
			SqlParameter[] paras = new SqlParameter[1];
			paras[0] = new SqlParameter("@UsrAccountPK", SqlDbType.UniqueIdentifier);
			paras[0].Value = UsrAccountPK;
			return this.FetchCollection(sqlWhere, paras);
		}

		public DataTable GetLogByPK( System.Guid UsrAccountDBRulePK)
		{
			string sql = string.Format("SELECT  [UsrAccountDBRule].[UsrAccountDBRulePK] AS [UsrAccountDBRulePK], [UsrAccountDBRule].[ModifiedOn] AS [ModifiedOn] FROM [{0}] WHERE  [UsrAccountDBRule].[UsrAccountDBRulePK] = @UsrAccountDBRulePK ", this.TableName);
			SqlParameter[] paras = new SqlParameter[1];
			paras[0] = new SqlParameter("@UsrAccountDBRulePK", SqlDbType.UniqueIdentifier);
			paras[0].Value = UsrAccountDBRulePK;
			return this.ExecuteDataTable(sql, paras);
		}

		public DataTable GetLogByUsrAccount(System.Guid usrAccountPK)
		{
			string sql = string.Format("DELETE [{0}] FROM [{0}] [UsrAccountDBRule] INNER JOIN [UsrAccount] ON [UsrAccountDBRule].[UsrAccountPK] = [UsrAccount].[UsrAccountPK] WHERE [UsrAccount].[UsrAccountPK] = @UsrAccountPK;", this.TableName);
			string oldValue = string.Format("DELETE [{0}]", this.TableName);
			string newValue = "SELECT  [UsrAccountDBRule].[UsrAccountDBRulePK] AS [UsrAccountDBRulePK], [UsrAccountDBRule].[ModifiedOn] AS [ModifiedOn]";
			sql = sql.Replace(oldValue, newValue).TrimEnd().TrimEnd(';').Replace(";", " UNION ");
			SqlParameter[] paras = new SqlParameter[1];
			paras[0] = new SqlParameter("@UsrAccountPK", SqlDbType.UniqueIdentifier);
			paras[0].Value = usrAccountPK;
			return base.ExecuteDataTable(sql, paras);
		}

		public DataTable GetLogByBDTenant(System.Guid bDTenantPK)
		{
			string sql = string.Format("DELETE [{0}] FROM [{0}] [UsrAccountDBRule] INNER JOIN [UsrAccount] ON [UsrAccountDBRule].[UsrAccountPK] = [UsrAccount].[UsrAccountPK] INNER JOIN [BDTenant] ON [UsrAccount].[BDTenantPK] = [BDTenant].[BDTenantPK] WHERE [BDTenant].[BDTenantPK] = @BDTenantPK;", this.TableName);
			string oldValue = string.Format("DELETE [{0}]", this.TableName);
			string newValue = "SELECT  [UsrAccountDBRule].[UsrAccountDBRulePK] AS [UsrAccountDBRulePK], [UsrAccountDBRule].[ModifiedOn] AS [ModifiedOn]";
			sql = sql.Replace(oldValue, newValue).TrimEnd().TrimEnd(';').Replace(";", " UNION ");
			SqlParameter[] paras = new SqlParameter[1];
			paras[0] = new SqlParameter("@BDTenantPK", SqlDbType.UniqueIdentifier);
			paras[0].Value = bDTenantPK;
			return base.ExecuteDataTable(sql, paras);
		}

		public DataTable GetLogByBDBuilding(System.Guid bDBuildingPK)
		{
			string sql = string.Format("DELETE [{0}] FROM [{0}] [UsrAccountDBRule] INNER JOIN [UsrAccount] ON [UsrAccountDBRule].[UsrAccountPK] = [UsrAccount].[UsrAccountPK] INNER JOIN [BDTenant] ON [UsrAccount].[BDTenantPK] = [BDTenant].[BDTenantPK] INNER JOIN [BDBuilding] ON [BDTenant].[BDBuildingPK] = [BDBuilding].[BDBuildingPK] WHERE [BDBuilding].[BDBuildingPK] = @BDBuildingPK;", this.TableName);
			string oldValue = string.Format("DELETE [{0}]", this.TableName);
			string newValue = "SELECT  [UsrAccountDBRule].[UsrAccountDBRulePK] AS [UsrAccountDBRulePK], [UsrAccountDBRule].[ModifiedOn] AS [ModifiedOn]";
			sql = sql.Replace(oldValue, newValue).TrimEnd().TrimEnd(';').Replace(";", " UNION ");
			SqlParameter[] paras = new SqlParameter[1];
			paras[0] = new SqlParameter("@BDBuildingPK", SqlDbType.UniqueIdentifier);
			paras[0].Value = bDBuildingPK;
			return base.ExecuteDataTable(sql, paras);
		}

		public DataTable GetLogByUsrGroup(System.Guid usrGroupPK)
		{
			string sql = string.Format("DELETE [{0}] FROM [{0}] [UsrAccountDBRule] INNER JOIN [UsrAccount] ON [UsrAccountDBRule].[UsrAccountPK] = [UsrAccount].[UsrAccountPK] INNER JOIN [UsrGroup] ON [UsrAccount].[UsrGroupPK] = [UsrGroup].[UsrGroupPK] WHERE [UsrGroup].[UsrGroupPK] = @UsrGroupPK;", this.TableName);
			string oldValue = string.Format("DELETE [{0}]", this.TableName);
			string newValue = "SELECT  [UsrAccountDBRule].[UsrAccountDBRulePK] AS [UsrAccountDBRulePK], [UsrAccountDBRule].[ModifiedOn] AS [ModifiedOn]";
			sql = sql.Replace(oldValue, newValue).TrimEnd().TrimEnd(';').Replace(";", " UNION ");
			SqlParameter[] paras = new SqlParameter[1];
			paras[0] = new SqlParameter("@UsrGroupPK", SqlDbType.UniqueIdentifier);
			paras[0].Value = usrGroupPK;
			return base.ExecuteDataTable(sql, paras);
		}

		public int DeleteByPK( System.Guid UsrAccountDBRulePK, byte[] RowVersion)
		{
			string sql = string.Format("DELETE FROM [{0}] WHERE  [UsrAccountDBRulePK] = @UsrAccountDBRulePK AND [RowVersion] = @RowVersion", this.TableName);
			SqlParameter[] paras = new SqlParameter[2];
			paras[0] = new SqlParameter("@UsrAccountDBRulePK", SqlDbType.UniqueIdentifier);
			paras[0].Value = UsrAccountDBRulePK;
			paras[1] = new SqlParameter("@RowVersion", SqlDbType.Timestamp, 8);
			paras[1].Value = RowVersion;
			return base.ExecuteNonQuery(sql, paras);
		}

		public int DeleteAll()
		{
			string sql = string.Format("DELETE FROM [{0}]", this.TableName);
			return base.ExecuteNonQuery(sql, null);
		}

		public int DeleteByUsrAccount(System.Guid usrAccountPK)
		{
			string sql = string.Format("DELETE [{0}] FROM [{0}] [UsrAccountDBRule] INNER JOIN [UsrAccount] ON [UsrAccountDBRule].[UsrAccountPK] = [UsrAccount].[UsrAccountPK] WHERE [UsrAccount].[UsrAccountPK] = @UsrAccountPK;", this.TableName);
			SqlParameter[] paras = new SqlParameter[1];
			paras[0] = new SqlParameter("@UsrAccountPK", SqlDbType.UniqueIdentifier);
			paras[0].Value = usrAccountPK;
			return base.ExecuteNonQuery(sql, paras);
		}

		public int DeleteByBDTenant(System.Guid bDTenantPK)
		{
			string sql = string.Format("DELETE [{0}] FROM [{0}] [UsrAccountDBRule] INNER JOIN [UsrAccount] ON [UsrAccountDBRule].[UsrAccountPK] = [UsrAccount].[UsrAccountPK] INNER JOIN [BDTenant] ON [UsrAccount].[BDTenantPK] = [BDTenant].[BDTenantPK] WHERE [BDTenant].[BDTenantPK] = @BDTenantPK;", this.TableName);
			SqlParameter[] paras = new SqlParameter[1];
			paras[0] = new SqlParameter("@BDTenantPK", SqlDbType.UniqueIdentifier);
			paras[0].Value = bDTenantPK;
			return base.ExecuteNonQuery(sql, paras);
		}

		public int DeleteByBDBuilding(System.Guid bDBuildingPK)
		{
			string sql = string.Format("DELETE [{0}] FROM [{0}] [UsrAccountDBRule] INNER JOIN [UsrAccount] ON [UsrAccountDBRule].[UsrAccountPK] = [UsrAccount].[UsrAccountPK] INNER JOIN [BDTenant] ON [UsrAccount].[BDTenantPK] = [BDTenant].[BDTenantPK] INNER JOIN [BDBuilding] ON [BDTenant].[BDBuildingPK] = [BDBuilding].[BDBuildingPK] WHERE [BDBuilding].[BDBuildingPK] = @BDBuildingPK;", this.TableName);
			SqlParameter[] paras = new SqlParameter[1];
			paras[0] = new SqlParameter("@BDBuildingPK", SqlDbType.UniqueIdentifier);
			paras[0].Value = bDBuildingPK;
			return base.ExecuteNonQuery(sql, paras);
		}

		public int DeleteByUsrGroup(System.Guid usrGroupPK)
		{
			string sql = string.Format("DELETE [{0}] FROM [{0}] [UsrAccountDBRule] INNER JOIN [UsrAccount] ON [UsrAccountDBRule].[UsrAccountPK] = [UsrAccount].[UsrAccountPK] INNER JOIN [UsrGroup] ON [UsrAccount].[UsrGroupPK] = [UsrGroup].[UsrGroupPK] WHERE [UsrGroup].[UsrGroupPK] = @UsrGroupPK;", this.TableName);
			SqlParameter[] paras = new SqlParameter[1];
			paras[0] = new SqlParameter("@UsrGroupPK", SqlDbType.UniqueIdentifier);
			paras[0].Value = usrGroupPK;
			return base.ExecuteNonQuery(sql, paras);
		}


	}
	public class UsrGroupBRRuleCRUD : DataAccessBase
	{
		private string _tableName = "UsrGroupBRRule";

		public UsrGroupBRRuleCRUD(string connectionString) : base(connectionString)
		{
		}

		public virtual string TableName
		{
			get { return this._tableName; }
			set { this._tableName = value; }
		}

		public string SQLColumns
		{
			get
			{
				return "[UsrGroupBRRule].[UsrGroupBRRule] AS [UsrGroupBRRule],[UsrGroupBRRule].[UsrGroupPK] AS [UsrGroupPK],[UsrGroupBRRule].[BRRuleID] AS [BRRuleID],[UsrGroupBRRule].[Denied] AS [Denied],[UsrGroupBRRule].[RowVersion] AS [RowVersion],[UsrGroupBRRule].[CreatedOn] AS [CreatedOn],[UsrGroupBRRule].[CreatedBy] AS [CreatedBy],[UsrGroupBRRule].[ModifiedOn] AS [ModifiedOn],[UsrGroupBRRule].[ModifiedBy] AS [ModifiedBy],[UsrGroup].[UsrGroupName] AS [UsrGroupName]";
			}
		}

		public string SQLLeftJoins
		{
			get
			{
				return "LEFT JOIN [UsrGroup] [UsrGroup] ON [UsrGroupBRRule].[UsrGroupPK] = [UsrGroup].[UsrGroupPK]";
			}
		}

		protected override string SQLSelect
		{
			get
			{
				return string.Format("SELECT [UsrGroupBRRule].[UsrGroupBRRule] AS [UsrGroupBRRule],[UsrGroupBRRule].[UsrGroupPK] AS [UsrGroupPK],[UsrGroupBRRule].[BRRuleID] AS [BRRuleID],[UsrGroupBRRule].[Denied] AS [Denied],[UsrGroupBRRule].[RowVersion] AS [RowVersion],[UsrGroupBRRule].[CreatedOn] AS [CreatedOn],[UsrGroupBRRule].[CreatedBy] AS [CreatedBy],[UsrGroupBRRule].[ModifiedOn] AS [ModifiedOn],[UsrGroupBRRule].[ModifiedBy] AS [ModifiedBy],[UsrGroup].[UsrGroupName] AS [UsrGroupName] FROM [{0}] [UsrGroupBRRule] LEFT JOIN [UsrGroup] [UsrGroup] ON [UsrGroupBRRule].[UsrGroupPK] = [UsrGroup].[UsrGroupPK]", this.TableName);
			}
		}

		protected override string SQLCount
		{
			get
			{
				return string.Format("SELECT COUNT(*) FROM [{0}] [UsrGroupBRRule] LEFT JOIN [UsrGroup] [UsrGroup] ON [UsrGroupBRRule].[UsrGroupPK] = [UsrGroup].[UsrGroupPK]", this.TableName);
			}
		}

		public int Insert(UsrGroupBRRuleData entity)
		{
			string sql = string.Format("INSERT INTO [{0}] ([UsrGroupBRRule],[UsrGroupPK],[BRRuleID],[Denied],[CreatedOn],[CreatedBy],[ModifiedOn],[ModifiedBy]) VALUES(@UsrGroupBRRule,@UsrGroupPK,@BRRuleID,@Denied,@CreatedOn,@CreatedBy,@ModifiedOn,@ModifiedBy)", this.TableName);
			SqlParameter[] paras = new SqlParameter[8];
			paras[0] = new SqlParameter("@UsrGroupBRRule", SqlDbType.UniqueIdentifier);
			if (entity.UsrGroupBRRule == Guid.Empty)
			{
				paras[0].Value = DBNull.Value;
			}
			else
			{
				paras[0].Value = entity.UsrGroupBRRule;
			}
			paras[1] = new SqlParameter("@UsrGroupPK", SqlDbType.UniqueIdentifier);
			if (entity.UsrGroupPK == Guid.Empty)
			{
				paras[1].Value = DBNull.Value;
			}
			else
			{
				paras[1].Value = entity.UsrGroupPK;
			}
			paras[2] = new SqlParameter("@BRRuleID", SqlDbType.Int);
			paras[2].Value = entity.BRRuleID;
			paras[3] = new SqlParameter("@Denied", SqlDbType.Bit);
			paras[3].Value = entity.Denied;
			paras[4] = new SqlParameter("@CreatedOn", SqlDbType.DateTime);
			paras[4].Value = entity.CreatedOn;
			paras[5] = new SqlParameter("@CreatedBy", SqlDbType.VarChar, 30);
			paras[5].Value = entity.CreatedBy;
			paras[6] = new SqlParameter("@ModifiedOn", SqlDbType.DateTime);
			paras[6].Value = entity.ModifiedOn;
			paras[7] = new SqlParameter("@ModifiedBy", SqlDbType.VarChar, 30);
			paras[7].Value = entity.ModifiedBy;
			return base.ExecuteNonQuery(sql, paras);
		}

		public int Update(UsrGroupBRRuleData entity)
		{
			string sql = string.Format("UPDATE [{0}] SET [UsrGroupPK] = @UsrGroupPK,[BRRuleID] = @BRRuleID,[Denied] = @Denied,[CreatedOn] = @CreatedOn,[CreatedBy] = @CreatedBy,[ModifiedOn] = @ModifiedOn,[ModifiedBy] = @ModifiedBy  WHERE [UsrGroupBRRule] = @UsrGroupBRRule AND [RowVersion] = @RowVersion", this.TableName);
			SqlParameter[] paras = new SqlParameter[9];
			paras[0] = new SqlParameter("@UsrGroupBRRule", SqlDbType.UniqueIdentifier);
			if (entity.UsrGroupBRRule == Guid.Empty)
			{
				paras[0].Value = DBNull.Value;
			}
			else
			{
				paras[0].Value = entity.UsrGroupBRRule;
			}
			paras[1] = new SqlParameter("@UsrGroupPK", SqlDbType.UniqueIdentifier);
			if (entity.UsrGroupPK == Guid.Empty)
			{
				paras[1].Value = DBNull.Value;
			}
			else
			{
				paras[1].Value = entity.UsrGroupPK;
			}
			paras[2] = new SqlParameter("@BRRuleID", SqlDbType.Int);
			paras[2].Value = entity.BRRuleID;
			paras[3] = new SqlParameter("@Denied", SqlDbType.Bit);
			paras[3].Value = entity.Denied;
			paras[4] = new SqlParameter("@RowVersion", SqlDbType.Timestamp);
			paras[4].Value = entity.RowVersion;
			paras[5] = new SqlParameter("@CreatedOn", SqlDbType.DateTime);
			paras[5].Value = entity.CreatedOn;
			paras[6] = new SqlParameter("@CreatedBy", SqlDbType.VarChar, 30);
			paras[6].Value = entity.CreatedBy;
			paras[7] = new SqlParameter("@ModifiedOn", SqlDbType.DateTime);
			paras[7].Value = entity.ModifiedOn;
			paras[8] = new SqlParameter("@ModifiedBy", SqlDbType.VarChar, 30);
			paras[8].Value = entity.ModifiedBy;
			return base.ExecuteNonQuery(sql, paras);
		}

		private UsrGroupBRRuleData CreateDataByReader(SafeDataReader reader)
		{
			UsrGroupBRRuleData data = new UsrGroupBRRuleData {
				UsrGroupBRRule = (Guid) reader["UsrGroupBRRule"],
				UsrGroupPK = (Guid) reader["UsrGroupPK"],
				BRRuleID = (Int32) reader["BRRuleID"],
				Denied = (Boolean) reader["Denied"],
				RowVersion = (Byte[]) reader["RowVersion"],
				CreatedOn = (DateTime) reader["CreatedOn"],
				CreatedBy = (String) reader["CreatedBy"],
				ModifiedOn = (DateTime) reader["ModifiedOn"],
				ModifiedBy = (String) reader["ModifiedBy"],
				UsrGroupName = (String) reader["UsrGroupName"]
			};
			data.AcceptChanges();
			return data;
		}

		private UsrGroupBRRuleData FetchEntity(string where, SqlParameter[] paras)
		{
			UsrGroupBRRuleData data = null;
			using (SafeDataReader reader = base.ExecuteDataReader(where, paras))
			{
				if (reader.Read())
				{
					data = this.CreateDataByReader(reader);
				}
				reader.Close();
			}
			return data;
		}

		private UsrGroupBRRuleData FetchEntityEx(string sql, SqlParameter[] paras)
		{
			UsrGroupBRRuleData data = null;
			using (SafeDataReader reader = base.ExecuteDataReaderEx(sql, paras))
			{
				if (reader.Read())
				{
					data = this.CreateDataByReader(reader);
				}
				reader.Close();
			}
			return data;
		}

		private UsrGroupBRRuleDataCollection FetchCollection(string where, SqlParameter[] paras)
		{
			UsrGroupBRRuleDataCollection list = new UsrGroupBRRuleDataCollection();
			using (SafeDataReader reader = base.ExecuteDataReader(where, paras))
			{
				while(reader.Read())
				{
					UsrGroupBRRuleData data = this.CreateDataByReader(reader);
					list.Add(data);
				}
				reader.Close();
			}
			return list;
		}

		private UsrGroupBRRuleDataCollection FetchCollectionEx(string sql, SqlParameter[] paras)
		{
			UsrGroupBRRuleDataCollection list = new UsrGroupBRRuleDataCollection();
			using (SafeDataReader reader = base.ExecuteDataReaderEx(sql, paras))
			{
				while(reader.Read())
				{
					UsrGroupBRRuleData data = this.CreateDataByReader(reader);
					list.Add(data);
				}
				reader.Close();
			}
			return list;
		}

		public UsrGroupBRRuleData GetEntityBy(string sqlWhere, SqlParameter[] paras)
		{
			return this.FetchEntity(sqlWhere, paras);
		}

		public UsrGroupBRRuleData GetEntityExBy(string sql, SqlParameter[] paras)
		{
			return this.FetchEntityEx(sql, paras);
		}

		public UsrGroupBRRuleDataCollection GetCollectionBy(string sqlWhere, SqlParameter[] paras)
		{
			return this.FetchCollection(sqlWhere, paras);
		}

		public UsrGroupBRRuleDataCollection GetCollectionExBy(string sql, SqlParameter[] paras)
		{
			return this.FetchCollectionEx(sql, paras);
		}

		public byte[] GetRowVersion( System.Guid UsrGroupBRRule)
		{
			string sql = string.Format("SELECT [RowVersion] AS [RowVersion] FROM [{0}] WHERE  [UsrGroupBRRule] = @UsrGroupBRRule ", this.TableName);
			SqlParameter[] paras = new SqlParameter[1];
			paras[0] = new SqlParameter("@UsrGroupBRRule", SqlDbType.UniqueIdentifier, 16);
			paras[0].Value = UsrGroupBRRule;
			return (byte[]) base.ExecuteScalar(sql, paras);
		}

		public UsrGroupBRRuleData GetByPK( System.Guid UsrGroupBRRule)
		{
			string sql = " WHERE  [UsrGroupBRRule].[UsrGroupBRRule] = @UsrGroupBRRule ";
			SqlParameter[] paras = new SqlParameter[1];
			paras[0] = new SqlParameter("@UsrGroupBRRule", SqlDbType.UniqueIdentifier);
			paras[0].Value = UsrGroupBRRule;
			return this.FetchEntity(sql, paras);
		}

		public UsrGroupBRRuleDataCollection GetAll()
		{
			return this.FetchCollection("", null);
		}

		public UsrGroupBRRuleDataCollection GetByUsrGroup(System.Guid UsrGroupPK)
		{
			string sqlWhere = " WHERE [UsrGroupBRRule].[UsrGroupPK] = @UsrGroupPK";
			SqlParameter[] paras = new SqlParameter[1];
			paras[0] = new SqlParameter("@UsrGroupPK", SqlDbType.UniqueIdentifier);
			paras[0].Value = UsrGroupPK;
			return this.FetchCollection(sqlWhere, paras);
		}

		public DataTable GetLogByPK( System.Guid UsrGroupBRRule)
		{
			string sql = string.Format("SELECT  [UsrGroupBRRule].[UsrGroupBRRule] AS [UsrGroupBRRule], [UsrGroupBRRule].[ModifiedOn] AS [ModifiedOn] FROM [{0}] WHERE  [UsrGroupBRRule].[UsrGroupBRRule] = @UsrGroupBRRule ", this.TableName);
			SqlParameter[] paras = new SqlParameter[1];
			paras[0] = new SqlParameter("@UsrGroupBRRule", SqlDbType.UniqueIdentifier);
			paras[0].Value = UsrGroupBRRule;
			return this.ExecuteDataTable(sql, paras);
		}

		public DataTable GetLogByUsrGroup(System.Guid usrGroupPK)
		{
			string sql = string.Format("DELETE [{0}] FROM [{0}] [UsrGroupBRRule] INNER JOIN [UsrGroup] ON [UsrGroupBRRule].[UsrGroupPK] = [UsrGroup].[UsrGroupPK] WHERE [UsrGroup].[UsrGroupPK] = @UsrGroupPK;", this.TableName);
			string oldValue = string.Format("DELETE [{0}]", this.TableName);
			string newValue = "SELECT  [UsrGroupBRRule].[UsrGroupBRRule] AS [UsrGroupBRRule], [UsrGroupBRRule].[ModifiedOn] AS [ModifiedOn]";
			sql = sql.Replace(oldValue, newValue).TrimEnd().TrimEnd(';').Replace(";", " UNION ");
			SqlParameter[] paras = new SqlParameter[1];
			paras[0] = new SqlParameter("@UsrGroupPK", SqlDbType.UniqueIdentifier);
			paras[0].Value = usrGroupPK;
			return base.ExecuteDataTable(sql, paras);
		}

		public int DeleteByPK( System.Guid UsrGroupBRRule, byte[] RowVersion)
		{
			string sql = string.Format("DELETE FROM [{0}] WHERE  [UsrGroupBRRule] = @UsrGroupBRRule AND [RowVersion] = @RowVersion", this.TableName);
			SqlParameter[] paras = new SqlParameter[2];
			paras[0] = new SqlParameter("@UsrGroupBRRule", SqlDbType.UniqueIdentifier);
			paras[0].Value = UsrGroupBRRule;
			paras[1] = new SqlParameter("@RowVersion", SqlDbType.Timestamp, 8);
			paras[1].Value = RowVersion;
			return base.ExecuteNonQuery(sql, paras);
		}

		public int DeleteAll()
		{
			string sql = string.Format("DELETE FROM [{0}]", this.TableName);
			return base.ExecuteNonQuery(sql, null);
		}

		public int DeleteByUsrGroup(System.Guid usrGroupPK)
		{
			string sql = string.Format("DELETE [{0}] FROM [{0}] [UsrGroupBRRule] INNER JOIN [UsrGroup] ON [UsrGroupBRRule].[UsrGroupPK] = [UsrGroup].[UsrGroupPK] WHERE [UsrGroup].[UsrGroupPK] = @UsrGroupPK;", this.TableName);
			SqlParameter[] paras = new SqlParameter[1];
			paras[0] = new SqlParameter("@UsrGroupPK", SqlDbType.UniqueIdentifier);
			paras[0].Value = usrGroupPK;
			return base.ExecuteNonQuery(sql, paras);
		}


	}
	public class ACInputGroupInputMapCRUD : DataAccessBase
	{
		private string _tableName = "ACInputGroupInputMap";

		public ACInputGroupInputMapCRUD(string connectionString) : base(connectionString)
		{
		}

		public virtual string TableName
		{
			get { return this._tableName; }
			set { this._tableName = value; }
		}

		public string SQLColumns
		{
			get
			{
				return "[ACInputGroupInputMap].[ACInputGroupInputMapPK] AS [ACInputGroupInputMapPK],[ACInputGroupInputMap].[ACInputGroupPK] AS [ACInputGroupPK],[ACInputGroupInputMap].[ACInputPK] AS [ACInputPK],[ACInputGroupInputMap].[RowVersion] AS [RowVersion],[ACInputGroupInputMap].[CreatedOn] AS [CreatedOn],[ACInputGroupInputMap].[CreatedBy] AS [CreatedBy],[ACInputGroupInputMap].[ModifiedOn] AS [ModifiedOn],[ACInputGroupInputMap].[ModifiedBy] AS [ModifiedBy],[ACInputGroup].[GroupID] AS [GroupID],[ACInputGroup].[ACPanelPK] AS [ACPanelPK],[ACInput].[InputID] AS [InputID],[ACPanel].[UnitID] AS [UnitID],[BDBuilding].[Address1] AS [Address1],[BDBuilding].[BuildingID] AS [BuildingID],[BDBuilding].[BDBuildingPK] AS [BDBuildingPK]";
			}
		}

		public string SQLLeftJoins
		{
			get
			{
				return "LEFT JOIN [ACInputGroup] [ACInputGroup] ON [ACInputGroupInputMap].[ACInputGroupPK] = [ACInputGroup].[ACInputGroupPK] LEFT JOIN [ACInput] [ACInput] ON [ACInputGroupInputMap].[ACInputPK] = [ACInput].[ACInputPK] LEFT JOIN [ACPanel] [ACPanel] ON [ACInput].[ACPanelPK] = [ACPanel].[ACPanelPK] LEFT JOIN [BDBuilding] [BDBuilding] ON [ACPanel].[BDBuildingPK] = [BDBuilding].[BDBuildingPK]";
			}
		}

		protected override string SQLSelect
		{
			get
			{
				return string.Format("SELECT [ACInputGroupInputMap].[ACInputGroupInputMapPK] AS [ACInputGroupInputMapPK],[ACInputGroupInputMap].[ACInputGroupPK] AS [ACInputGroupPK],[ACInputGroupInputMap].[ACInputPK] AS [ACInputPK],[ACInputGroupInputMap].[RowVersion] AS [RowVersion],[ACInputGroupInputMap].[CreatedOn] AS [CreatedOn],[ACInputGroupInputMap].[CreatedBy] AS [CreatedBy],[ACInputGroupInputMap].[ModifiedOn] AS [ModifiedOn],[ACInputGroupInputMap].[ModifiedBy] AS [ModifiedBy],[ACInputGroup].[GroupID] AS [GroupID],[ACInputGroup].[ACPanelPK] AS [ACPanelPK],[ACInput].[InputID] AS [InputID],[ACPanel].[UnitID] AS [UnitID],[BDBuilding].[Address1] AS [Address1],[BDBuilding].[BuildingID] AS [BuildingID],[BDBuilding].[BDBuildingPK] AS [BDBuildingPK] FROM [{0}] [ACInputGroupInputMap] LEFT JOIN [ACInputGroup] [ACInputGroup] ON [ACInputGroupInputMap].[ACInputGroupPK] = [ACInputGroup].[ACInputGroupPK] LEFT JOIN [ACInput] [ACInput] ON [ACInputGroupInputMap].[ACInputPK] = [ACInput].[ACInputPK] LEFT JOIN [ACPanel] [ACPanel] ON [ACInput].[ACPanelPK] = [ACPanel].[ACPanelPK] LEFT JOIN [BDBuilding] [BDBuilding] ON [ACPanel].[BDBuildingPK] = [BDBuilding].[BDBuildingPK]", this.TableName);
			}
		}

		protected override string SQLCount
		{
			get
			{
				return string.Format("SELECT COUNT(*) FROM [{0}] [ACInputGroupInputMap] LEFT JOIN [ACInputGroup] [ACInputGroup] ON [ACInputGroupInputMap].[ACInputGroupPK] = [ACInputGroup].[ACInputGroupPK] LEFT JOIN [ACInput] [ACInput] ON [ACInputGroupInputMap].[ACInputPK] = [ACInput].[ACInputPK] LEFT JOIN [ACPanel] [ACPanel] ON [ACInput].[ACPanelPK] = [ACPanel].[ACPanelPK] LEFT JOIN [BDBuilding] [BDBuilding] ON [ACPanel].[BDBuildingPK] = [BDBuilding].[BDBuildingPK]", this.TableName);
			}
		}

		public int Insert(ACInputGroupInputMapData entity)
		{
			string sql = string.Format("INSERT INTO [{0}] ([ACInputGroupInputMapPK],[ACInputGroupPK],[ACInputPK],[CreatedOn],[CreatedBy],[ModifiedOn],[ModifiedBy]) VALUES(@ACInputGroupInputMapPK,@ACInputGroupPK,@ACInputPK,@CreatedOn,@CreatedBy,@ModifiedOn,@ModifiedBy)", this.TableName);
			SqlParameter[] paras = new SqlParameter[7];
			paras[0] = new SqlParameter("@ACInputGroupInputMapPK", SqlDbType.UniqueIdentifier);
			if (entity.ACInputGroupInputMapPK == Guid.Empty)
			{
				paras[0].Value = DBNull.Value;
			}
			else
			{
				paras[0].Value = entity.ACInputGroupInputMapPK;
			}
			paras[1] = new SqlParameter("@ACInputGroupPK", SqlDbType.UniqueIdentifier);
			if (entity.ACInputGroupPK == Guid.Empty)
			{
				paras[1].Value = DBNull.Value;
			}
			else
			{
				paras[1].Value = entity.ACInputGroupPK;
			}
			paras[2] = new SqlParameter("@ACInputPK", SqlDbType.UniqueIdentifier);
			if (entity.ACInputPK == Guid.Empty)
			{
				paras[2].Value = DBNull.Value;
			}
			else
			{
				paras[2].Value = entity.ACInputPK;
			}
			paras[3] = new SqlParameter("@CreatedOn", SqlDbType.DateTime);
			paras[3].Value = entity.CreatedOn;
			paras[4] = new SqlParameter("@CreatedBy", SqlDbType.VarChar, 30);
			paras[4].Value = entity.CreatedBy;
			paras[5] = new SqlParameter("@ModifiedOn", SqlDbType.DateTime);
			paras[5].Value = entity.ModifiedOn;
			paras[6] = new SqlParameter("@ModifiedBy", SqlDbType.VarChar, 30);
			paras[6].Value = entity.ModifiedBy;
			return base.ExecuteNonQuery(sql, paras);
		}

		public int Update(ACInputGroupInputMapData entity)
		{
			string sql = string.Format("UPDATE [{0}] SET [ACInputGroupPK] = @ACInputGroupPK,[ACInputPK] = @ACInputPK,[CreatedOn] = @CreatedOn,[CreatedBy] = @CreatedBy,[ModifiedOn] = @ModifiedOn,[ModifiedBy] = @ModifiedBy  WHERE [ACInputGroupInputMapPK] = @ACInputGroupInputMapPK AND [RowVersion] = @RowVersion", this.TableName);
			SqlParameter[] paras = new SqlParameter[8];
			paras[0] = new SqlParameter("@ACInputGroupInputMapPK", SqlDbType.UniqueIdentifier);
			if (entity.ACInputGroupInputMapPK == Guid.Empty)
			{
				paras[0].Value = DBNull.Value;
			}
			else
			{
				paras[0].Value = entity.ACInputGroupInputMapPK;
			}
			paras[1] = new SqlParameter("@ACInputGroupPK", SqlDbType.UniqueIdentifier);
			if (entity.ACInputGroupPK == Guid.Empty)
			{
				paras[1].Value = DBNull.Value;
			}
			else
			{
				paras[1].Value = entity.ACInputGroupPK;
			}
			paras[2] = new SqlParameter("@ACInputPK", SqlDbType.UniqueIdentifier);
			if (entity.ACInputPK == Guid.Empty)
			{
				paras[2].Value = DBNull.Value;
			}
			else
			{
				paras[2].Value = entity.ACInputPK;
			}
			paras[3] = new SqlParameter("@RowVersion", SqlDbType.Timestamp);
			paras[3].Value = entity.RowVersion;
			paras[4] = new SqlParameter("@CreatedOn", SqlDbType.DateTime);
			paras[4].Value = entity.CreatedOn;
			paras[5] = new SqlParameter("@CreatedBy", SqlDbType.VarChar, 30);
			paras[5].Value = entity.CreatedBy;
			paras[6] = new SqlParameter("@ModifiedOn", SqlDbType.DateTime);
			paras[6].Value = entity.ModifiedOn;
			paras[7] = new SqlParameter("@ModifiedBy", SqlDbType.VarChar, 30);
			paras[7].Value = entity.ModifiedBy;
			return base.ExecuteNonQuery(sql, paras);
		}

		private ACInputGroupInputMapData CreateDataByReader(SafeDataReader reader)
		{
			ACInputGroupInputMapData data = new ACInputGroupInputMapData {
				ACInputGroupInputMapPK = (Guid) reader["ACInputGroupInputMapPK"],
				ACInputGroupPK = (Guid) reader["ACInputGroupPK"],
				ACInputPK = (Guid) reader["ACInputPK"],
				RowVersion = (Byte[]) reader["RowVersion"],
				CreatedOn = (DateTime) reader["CreatedOn"],
				CreatedBy = (String) reader["CreatedBy"],
				ModifiedOn = (DateTime) reader["ModifiedOn"],
				ModifiedBy = (String) reader["ModifiedBy"],
				GroupID = (Byte) reader["GroupID"],
				ACPanelPK = (Guid) reader["ACPanelPK"],
				InputID = (Byte) reader["InputID"],
				UnitID = (Int32) reader["UnitID"],
				Address1 = (String) reader["Address1"],
				BuildingID = (Int32) reader["BuildingID"],
				BDBuildingPK = (Guid) reader["BDBuildingPK"]
			};
			data.AcceptChanges();
			return data;
		}

		private ACInputGroupInputMapData FetchEntity(string where, SqlParameter[] paras)
		{
			ACInputGroupInputMapData data = null;
			using (SafeDataReader reader = base.ExecuteDataReader(where, paras))
			{
				if (reader.Read())
				{
					data = this.CreateDataByReader(reader);
				}
				reader.Close();
			}
			return data;
		}

		private ACInputGroupInputMapData FetchEntityEx(string sql, SqlParameter[] paras)
		{
			ACInputGroupInputMapData data = null;
			using (SafeDataReader reader = base.ExecuteDataReaderEx(sql, paras))
			{
				if (reader.Read())
				{
					data = this.CreateDataByReader(reader);
				}
				reader.Close();
			}
			return data;
		}

		private ACInputGroupInputMapDataCollection FetchCollection(string where, SqlParameter[] paras)
		{
			ACInputGroupInputMapDataCollection list = new ACInputGroupInputMapDataCollection();
			using (SafeDataReader reader = base.ExecuteDataReader(where, paras))
			{
				while(reader.Read())
				{
					ACInputGroupInputMapData data = this.CreateDataByReader(reader);
					list.Add(data);
				}
				reader.Close();
			}
			return list;
		}

		private ACInputGroupInputMapDataCollection FetchCollectionEx(string sql, SqlParameter[] paras)
		{
			ACInputGroupInputMapDataCollection list = new ACInputGroupInputMapDataCollection();
			using (SafeDataReader reader = base.ExecuteDataReaderEx(sql, paras))
			{
				while(reader.Read())
				{
					ACInputGroupInputMapData data = this.CreateDataByReader(reader);
					list.Add(data);
				}
				reader.Close();
			}
			return list;
		}

		public ACInputGroupInputMapData GetEntityBy(string sqlWhere, SqlParameter[] paras)
		{
			return this.FetchEntity(sqlWhere, paras);
		}

		public ACInputGroupInputMapData GetEntityExBy(string sql, SqlParameter[] paras)
		{
			return this.FetchEntityEx(sql, paras);
		}

		public ACInputGroupInputMapDataCollection GetCollectionBy(string sqlWhere, SqlParameter[] paras)
		{
			return this.FetchCollection(sqlWhere, paras);
		}

		public ACInputGroupInputMapDataCollection GetCollectionExBy(string sql, SqlParameter[] paras)
		{
			return this.FetchCollectionEx(sql, paras);
		}

		public byte[] GetRowVersion( System.Guid ACInputGroupInputMapPK)
		{
			string sql = string.Format("SELECT [RowVersion] AS [RowVersion] FROM [{0}] WHERE  [ACInputGroupInputMapPK] = @ACInputGroupInputMapPK ", this.TableName);
			SqlParameter[] paras = new SqlParameter[1];
			paras[0] = new SqlParameter("@ACInputGroupInputMapPK", SqlDbType.UniqueIdentifier, 16);
			paras[0].Value = ACInputGroupInputMapPK;
			return (byte[]) base.ExecuteScalar(sql, paras);
		}

		public ACInputGroupInputMapData GetByPK( System.Guid ACInputGroupInputMapPK)
		{
			string sql = " WHERE  [ACInputGroupInputMap].[ACInputGroupInputMapPK] = @ACInputGroupInputMapPK ";
			SqlParameter[] paras = new SqlParameter[1];
			paras[0] = new SqlParameter("@ACInputGroupInputMapPK", SqlDbType.UniqueIdentifier);
			paras[0].Value = ACInputGroupInputMapPK;
			return this.FetchEntity(sql, paras);
		}

		public ACInputGroupInputMapDataCollection GetAll()
		{
			return this.FetchCollection("", null);
		}

		public ACInputGroupInputMapDataCollection GetByACInputGroup(System.Guid ACInputGroupPK)
		{
			string sqlWhere = " WHERE [ACInputGroupInputMap].[ACInputGroupPK] = @ACInputGroupPK";
			SqlParameter[] paras = new SqlParameter[1];
			paras[0] = new SqlParameter("@ACInputGroupPK", SqlDbType.UniqueIdentifier);
			paras[0].Value = ACInputGroupPK;
			return this.FetchCollection(sqlWhere, paras);
		}

		public ACInputGroupInputMapDataCollection GetByACInput(System.Guid ACInputPK)
		{
			string sqlWhere = " WHERE [ACInputGroupInputMap].[ACInputPK] = @ACInputPK";
			SqlParameter[] paras = new SqlParameter[1];
			paras[0] = new SqlParameter("@ACInputPK", SqlDbType.UniqueIdentifier);
			paras[0].Value = ACInputPK;
			return this.FetchCollection(sqlWhere, paras);
		}

		public DataTable GetLogByPK( System.Guid ACInputGroupInputMapPK)
		{
			string sql = string.Format("SELECT  [ACInputGroupInputMap].[ACInputGroupInputMapPK] AS [ACInputGroupInputMapPK], [ACInputGroupInputMap].[ModifiedOn] AS [ModifiedOn] FROM [{0}] WHERE  [ACInputGroupInputMap].[ACInputGroupInputMapPK] = @ACInputGroupInputMapPK ", this.TableName);
			SqlParameter[] paras = new SqlParameter[1];
			paras[0] = new SqlParameter("@ACInputGroupInputMapPK", SqlDbType.UniqueIdentifier);
			paras[0].Value = ACInputGroupInputMapPK;
			return this.ExecuteDataTable(sql, paras);
		}

		public DataTable GetLogByACInputGroup(System.Guid aCInputGroupPK)
		{
			string sql = string.Format("DELETE [{0}] FROM [{0}] [ACInputGroupInputMap] INNER JOIN [ACInputGroup] ON [ACInputGroupInputMap].[ACInputGroupPK] = [ACInputGroup].[ACInputGroupPK] WHERE [ACInputGroup].[ACInputGroupPK] = @ACInputGroupPK;", this.TableName);
			string oldValue = string.Format("DELETE [{0}]", this.TableName);
			string newValue = "SELECT  [ACInputGroupInputMap].[ACInputGroupInputMapPK] AS [ACInputGroupInputMapPK], [ACInputGroupInputMap].[ModifiedOn] AS [ModifiedOn]";
			sql = sql.Replace(oldValue, newValue).TrimEnd().TrimEnd(';').Replace(";", " UNION ");
			SqlParameter[] paras = new SqlParameter[1];
			paras[0] = new SqlParameter("@ACInputGroupPK", SqlDbType.UniqueIdentifier);
			paras[0].Value = aCInputGroupPK;
			return base.ExecuteDataTable(sql, paras);
		}

		public DataTable GetLogByACPanel(System.Guid aCPanelPK)
		{
			string sql = string.Format("DELETE [{0}] FROM [{0}] [ACInputGroupInputMap] INNER JOIN [ACInputGroup] ON [ACInputGroupInputMap].[ACInputGroupPK] = [ACInputGroup].[ACInputGroupPK] INNER JOIN [ACPanel] ON [ACInputGroup].[ACPanelPK] = [ACPanel].[ACPanelPK] WHERE [ACPanel].[ACPanelPK] = @ACPanelPK;DELETE [{0}] FROM [{0}] [ACInputGroupInputMap] INNER JOIN [ACInput] ON [ACInputGroupInputMap].[ACInputPK] = [ACInput].[ACInputPK] INNER JOIN [ACPanel] ON [ACInput].[ACPanelPK] = [ACPanel].[ACPanelPK] WHERE [ACPanel].[ACPanelPK] = @ACPanelPK;", this.TableName);
			string oldValue = string.Format("DELETE [{0}]", this.TableName);
			string newValue = "SELECT  [ACInputGroupInputMap].[ACInputGroupInputMapPK] AS [ACInputGroupInputMapPK], [ACInputGroupInputMap].[ModifiedOn] AS [ModifiedOn]";
			sql = sql.Replace(oldValue, newValue).TrimEnd().TrimEnd(';').Replace(";", " UNION ");
			SqlParameter[] paras = new SqlParameter[1];
			paras[0] = new SqlParameter("@ACPanelPK", SqlDbType.UniqueIdentifier);
			paras[0].Value = aCPanelPK;
			return base.ExecuteDataTable(sql, paras);
		}

		public DataTable GetLogByBDBuilding(System.Guid bDBuildingPK)
		{
			string sql = string.Format("DELETE [{0}] FROM [{0}] [ACInputGroupInputMap] INNER JOIN [ACInputGroup] ON [ACInputGroupInputMap].[ACInputGroupPK] = [ACInputGroup].[ACInputGroupPK] INNER JOIN [ACPanel] ON [ACInputGroup].[ACPanelPK] = [ACPanel].[ACPanelPK] INNER JOIN [BDBuilding] ON [ACPanel].[BDBuildingPK] = [BDBuilding].[BDBuildingPK] WHERE [BDBuilding].[BDBuildingPK] = @BDBuildingPK;DELETE [{0}] FROM [{0}] [ACInputGroupInputMap] INNER JOIN [ACInput] ON [ACInputGroupInputMap].[ACInputPK] = [ACInput].[ACInputPK] INNER JOIN [ACPanel] ON [ACInput].[ACPanelPK] = [ACPanel].[ACPanelPK] INNER JOIN [BDBuilding] ON [ACPanel].[BDBuildingPK] = [BDBuilding].[BDBuildingPK] WHERE [BDBuilding].[BDBuildingPK] = @BDBuildingPK;", this.TableName);
			string oldValue = string.Format("DELETE [{0}]", this.TableName);
			string newValue = "SELECT  [ACInputGroupInputMap].[ACInputGroupInputMapPK] AS [ACInputGroupInputMapPK], [ACInputGroupInputMap].[ModifiedOn] AS [ModifiedOn]";
			sql = sql.Replace(oldValue, newValue).TrimEnd().TrimEnd(';').Replace(";", " UNION ");
			SqlParameter[] paras = new SqlParameter[1];
			paras[0] = new SqlParameter("@BDBuildingPK", SqlDbType.UniqueIdentifier);
			paras[0].Value = bDBuildingPK;
			return base.ExecuteDataTable(sql, paras);
		}

		public DataTable GetLogByACInput(System.Guid aCInputPK)
		{
			string sql = string.Format("DELETE [{0}] FROM [{0}] [ACInputGroupInputMap] INNER JOIN [ACInput] ON [ACInputGroupInputMap].[ACInputPK] = [ACInput].[ACInputPK] WHERE [ACInput].[ACInputPK] = @ACInputPK;", this.TableName);
			string oldValue = string.Format("DELETE [{0}]", this.TableName);
			string newValue = "SELECT  [ACInputGroupInputMap].[ACInputGroupInputMapPK] AS [ACInputGroupInputMapPK], [ACInputGroupInputMap].[ModifiedOn] AS [ModifiedOn]";
			sql = sql.Replace(oldValue, newValue).TrimEnd().TrimEnd(';').Replace(";", " UNION ");
			SqlParameter[] paras = new SqlParameter[1];
			paras[0] = new SqlParameter("@ACInputPK", SqlDbType.UniqueIdentifier);
			paras[0].Value = aCInputPK;
			return base.ExecuteDataTable(sql, paras);
		}

		public int DeleteByPK( System.Guid ACInputGroupInputMapPK, byte[] RowVersion)
		{
			string sql = string.Format("DELETE FROM [{0}] WHERE  [ACInputGroupInputMapPK] = @ACInputGroupInputMapPK AND [RowVersion] = @RowVersion", this.TableName);
			SqlParameter[] paras = new SqlParameter[2];
			paras[0] = new SqlParameter("@ACInputGroupInputMapPK", SqlDbType.UniqueIdentifier);
			paras[0].Value = ACInputGroupInputMapPK;
			paras[1] = new SqlParameter("@RowVersion", SqlDbType.Timestamp, 8);
			paras[1].Value = RowVersion;
			return base.ExecuteNonQuery(sql, paras);
		}

		public int DeleteAll()
		{
			string sql = string.Format("DELETE FROM [{0}]", this.TableName);
			return base.ExecuteNonQuery(sql, null);
		}

		public int DeleteByACInputGroup(System.Guid aCInputGroupPK)
		{
			string sql = string.Format("DELETE [{0}] FROM [{0}] [ACInputGroupInputMap] INNER JOIN [ACInputGroup] ON [ACInputGroupInputMap].[ACInputGroupPK] = [ACInputGroup].[ACInputGroupPK] WHERE [ACInputGroup].[ACInputGroupPK] = @ACInputGroupPK;", this.TableName);
			SqlParameter[] paras = new SqlParameter[1];
			paras[0] = new SqlParameter("@ACInputGroupPK", SqlDbType.UniqueIdentifier);
			paras[0].Value = aCInputGroupPK;
			return base.ExecuteNonQuery(sql, paras);
		}

		public int DeleteByACPanel(System.Guid aCPanelPK)
		{
			string sql = string.Format("DELETE [{0}] FROM [{0}] [ACInputGroupInputMap] INNER JOIN [ACInputGroup] ON [ACInputGroupInputMap].[ACInputGroupPK] = [ACInputGroup].[ACInputGroupPK] INNER JOIN [ACPanel] ON [ACInputGroup].[ACPanelPK] = [ACPanel].[ACPanelPK] WHERE [ACPanel].[ACPanelPK] = @ACPanelPK;DELETE [{0}] FROM [{0}] [ACInputGroupInputMap] INNER JOIN [ACInput] ON [ACInputGroupInputMap].[ACInputPK] = [ACInput].[ACInputPK] INNER JOIN [ACPanel] ON [ACInput].[ACPanelPK] = [ACPanel].[ACPanelPK] WHERE [ACPanel].[ACPanelPK] = @ACPanelPK;", this.TableName);
			SqlParameter[] paras = new SqlParameter[1];
			paras[0] = new SqlParameter("@ACPanelPK", SqlDbType.UniqueIdentifier);
			paras[0].Value = aCPanelPK;
			return base.ExecuteNonQuery(sql, paras);
		}

		public int DeleteByBDBuilding(System.Guid bDBuildingPK)
		{
			string sql = string.Format("DELETE [{0}] FROM [{0}] [ACInputGroupInputMap] INNER JOIN [ACInputGroup] ON [ACInputGroupInputMap].[ACInputGroupPK] = [ACInputGroup].[ACInputGroupPK] INNER JOIN [ACPanel] ON [ACInputGroup].[ACPanelPK] = [ACPanel].[ACPanelPK] INNER JOIN [BDBuilding] ON [ACPanel].[BDBuildingPK] = [BDBuilding].[BDBuildingPK] WHERE [BDBuilding].[BDBuildingPK] = @BDBuildingPK;DELETE [{0}] FROM [{0}] [ACInputGroupInputMap] INNER JOIN [ACInput] ON [ACInputGroupInputMap].[ACInputPK] = [ACInput].[ACInputPK] INNER JOIN [ACPanel] ON [ACInput].[ACPanelPK] = [ACPanel].[ACPanelPK] INNER JOIN [BDBuilding] ON [ACPanel].[BDBuildingPK] = [BDBuilding].[BDBuildingPK] WHERE [BDBuilding].[BDBuildingPK] = @BDBuildingPK;", this.TableName);
			SqlParameter[] paras = new SqlParameter[1];
			paras[0] = new SqlParameter("@BDBuildingPK", SqlDbType.UniqueIdentifier);
			paras[0].Value = bDBuildingPK;
			return base.ExecuteNonQuery(sql, paras);
		}

		public int DeleteByACInput(System.Guid aCInputPK)
		{
			string sql = string.Format("DELETE [{0}] FROM [{0}] [ACInputGroupInputMap] INNER JOIN [ACInput] ON [ACInputGroupInputMap].[ACInputPK] = [ACInput].[ACInputPK] WHERE [ACInput].[ACInputPK] = @ACInputPK;", this.TableName);
			SqlParameter[] paras = new SqlParameter[1];
			paras[0] = new SqlParameter("@ACInputPK", SqlDbType.UniqueIdentifier);
			paras[0].Value = aCInputPK;
			return base.ExecuteNonQuery(sql, paras);
		}


	}
	public class UsrAccountBRRuleCRUD : DataAccessBase
	{
		private string _tableName = "UsrAccountBRRule";

		public UsrAccountBRRuleCRUD(string connectionString) : base(connectionString)
		{
		}

		public virtual string TableName
		{
			get { return this._tableName; }
			set { this._tableName = value; }
		}

		public string SQLColumns
		{
			get
			{
				return "[UsrAccountBRRule].[UsrAccountBRRulePK] AS [UsrAccountBRRulePK],[UsrAccountBRRule].[UsrAccountPK] AS [UsrAccountPK],[UsrAccountBRRule].[BRRuleID] AS [BRRuleID],[UsrAccountBRRule].[Denied] AS [Denied],[UsrAccountBRRule].[RowVersion] AS [RowVersion],[UsrAccountBRRule].[CreatedOn] AS [CreatedOn],[UsrAccountBRRule].[CreatedBy] AS [CreatedBy],[UsrAccountBRRule].[ModifiedOn] AS [ModifiedOn],[UsrAccountBRRule].[ModifiedBy] AS [ModifiedBy],[UsrAccount].[UserID] AS [UserID]";
			}
		}

		public string SQLLeftJoins
		{
			get
			{
				return "LEFT JOIN [UsrAccount] [UsrAccount] ON [UsrAccountBRRule].[UsrAccountPK] = [UsrAccount].[UsrAccountPK]";
			}
		}

		protected override string SQLSelect
		{
			get
			{
				return string.Format("SELECT [UsrAccountBRRule].[UsrAccountBRRulePK] AS [UsrAccountBRRulePK],[UsrAccountBRRule].[UsrAccountPK] AS [UsrAccountPK],[UsrAccountBRRule].[BRRuleID] AS [BRRuleID],[UsrAccountBRRule].[Denied] AS [Denied],[UsrAccountBRRule].[RowVersion] AS [RowVersion],[UsrAccountBRRule].[CreatedOn] AS [CreatedOn],[UsrAccountBRRule].[CreatedBy] AS [CreatedBy],[UsrAccountBRRule].[ModifiedOn] AS [ModifiedOn],[UsrAccountBRRule].[ModifiedBy] AS [ModifiedBy],[UsrAccount].[UserID] AS [UserID] FROM [{0}] [UsrAccountBRRule] LEFT JOIN [UsrAccount] [UsrAccount] ON [UsrAccountBRRule].[UsrAccountPK] = [UsrAccount].[UsrAccountPK]", this.TableName);
			}
		}

		protected override string SQLCount
		{
			get
			{
				return string.Format("SELECT COUNT(*) FROM [{0}] [UsrAccountBRRule] LEFT JOIN [UsrAccount] [UsrAccount] ON [UsrAccountBRRule].[UsrAccountPK] = [UsrAccount].[UsrAccountPK]", this.TableName);
			}
		}

		public int Insert(UsrAccountBRRuleData entity)
		{
			string sql = string.Format("INSERT INTO [{0}] ([UsrAccountBRRulePK],[UsrAccountPK],[BRRuleID],[Denied],[CreatedOn],[CreatedBy],[ModifiedOn],[ModifiedBy]) VALUES(@UsrAccountBRRulePK,@UsrAccountPK,@BRRuleID,@Denied,@CreatedOn,@CreatedBy,@ModifiedOn,@ModifiedBy)", this.TableName);
			SqlParameter[] paras = new SqlParameter[8];
			paras[0] = new SqlParameter("@UsrAccountBRRulePK", SqlDbType.UniqueIdentifier);
			if (entity.UsrAccountBRRulePK == Guid.Empty)
			{
				paras[0].Value = DBNull.Value;
			}
			else
			{
				paras[0].Value = entity.UsrAccountBRRulePK;
			}
			paras[1] = new SqlParameter("@UsrAccountPK", SqlDbType.UniqueIdentifier);
			if (entity.UsrAccountPK == Guid.Empty)
			{
				paras[1].Value = DBNull.Value;
			}
			else
			{
				paras[1].Value = entity.UsrAccountPK;
			}
			paras[2] = new SqlParameter("@BRRuleID", SqlDbType.Int);
			paras[2].Value = entity.BRRuleID;
			paras[3] = new SqlParameter("@Denied", SqlDbType.Bit);
			paras[3].Value = entity.Denied;
			paras[4] = new SqlParameter("@CreatedOn", SqlDbType.DateTime);
			paras[4].Value = entity.CreatedOn;
			paras[5] = new SqlParameter("@CreatedBy", SqlDbType.VarChar, 30);
			paras[5].Value = entity.CreatedBy;
			paras[6] = new SqlParameter("@ModifiedOn", SqlDbType.DateTime);
			paras[6].Value = entity.ModifiedOn;
			paras[7] = new SqlParameter("@ModifiedBy", SqlDbType.VarChar, 30);
			paras[7].Value = entity.ModifiedBy;
			return base.ExecuteNonQuery(sql, paras);
		}

		public int Update(UsrAccountBRRuleData entity)
		{
			string sql = string.Format("UPDATE [{0}] SET [UsrAccountPK] = @UsrAccountPK,[BRRuleID] = @BRRuleID,[Denied] = @Denied,[CreatedOn] = @CreatedOn,[CreatedBy] = @CreatedBy,[ModifiedOn] = @ModifiedOn,[ModifiedBy] = @ModifiedBy  WHERE [UsrAccountBRRulePK] = @UsrAccountBRRulePK AND [RowVersion] = @RowVersion", this.TableName);
			SqlParameter[] paras = new SqlParameter[9];
			paras[0] = new SqlParameter("@UsrAccountBRRulePK", SqlDbType.UniqueIdentifier);
			if (entity.UsrAccountBRRulePK == Guid.Empty)
			{
				paras[0].Value = DBNull.Value;
			}
			else
			{
				paras[0].Value = entity.UsrAccountBRRulePK;
			}
			paras[1] = new SqlParameter("@UsrAccountPK", SqlDbType.UniqueIdentifier);
			if (entity.UsrAccountPK == Guid.Empty)
			{
				paras[1].Value = DBNull.Value;
			}
			else
			{
				paras[1].Value = entity.UsrAccountPK;
			}
			paras[2] = new SqlParameter("@BRRuleID", SqlDbType.Int);
			paras[2].Value = entity.BRRuleID;
			paras[3] = new SqlParameter("@Denied", SqlDbType.Bit);
			paras[3].Value = entity.Denied;
			paras[4] = new SqlParameter("@RowVersion", SqlDbType.Timestamp);
			paras[4].Value = entity.RowVersion;
			paras[5] = new SqlParameter("@CreatedOn", SqlDbType.DateTime);
			paras[5].Value = entity.CreatedOn;
			paras[6] = new SqlParameter("@CreatedBy", SqlDbType.VarChar, 30);
			paras[6].Value = entity.CreatedBy;
			paras[7] = new SqlParameter("@ModifiedOn", SqlDbType.DateTime);
			paras[7].Value = entity.ModifiedOn;
			paras[8] = new SqlParameter("@ModifiedBy", SqlDbType.VarChar, 30);
			paras[8].Value = entity.ModifiedBy;
			return base.ExecuteNonQuery(sql, paras);
		}

		private UsrAccountBRRuleData CreateDataByReader(SafeDataReader reader)
		{
			UsrAccountBRRuleData data = new UsrAccountBRRuleData {
				UsrAccountBRRulePK = (Guid) reader["UsrAccountBRRulePK"],
				UsrAccountPK = (Guid) reader["UsrAccountPK"],
				BRRuleID = (Int32) reader["BRRuleID"],
				Denied = (Boolean) reader["Denied"],
				RowVersion = (Byte[]) reader["RowVersion"],
				CreatedOn = (DateTime) reader["CreatedOn"],
				CreatedBy = (String) reader["CreatedBy"],
				ModifiedOn = (DateTime) reader["ModifiedOn"],
				ModifiedBy = (String) reader["ModifiedBy"],
				UserID = (String) reader["UserID"]
			};
			data.AcceptChanges();
			return data;
		}

		private UsrAccountBRRuleData FetchEntity(string where, SqlParameter[] paras)
		{
			UsrAccountBRRuleData data = null;
			using (SafeDataReader reader = base.ExecuteDataReader(where, paras))
			{
				if (reader.Read())
				{
					data = this.CreateDataByReader(reader);
				}
				reader.Close();
			}
			return data;
		}

		private UsrAccountBRRuleData FetchEntityEx(string sql, SqlParameter[] paras)
		{
			UsrAccountBRRuleData data = null;
			using (SafeDataReader reader = base.ExecuteDataReaderEx(sql, paras))
			{
				if (reader.Read())
				{
					data = this.CreateDataByReader(reader);
				}
				reader.Close();
			}
			return data;
		}

		private UsrAccountBRRuleDataCollection FetchCollection(string where, SqlParameter[] paras)
		{
			UsrAccountBRRuleDataCollection list = new UsrAccountBRRuleDataCollection();
			using (SafeDataReader reader = base.ExecuteDataReader(where, paras))
			{
				while(reader.Read())
				{
					UsrAccountBRRuleData data = this.CreateDataByReader(reader);
					list.Add(data);
				}
				reader.Close();
			}
			return list;
		}

		private UsrAccountBRRuleDataCollection FetchCollectionEx(string sql, SqlParameter[] paras)
		{
			UsrAccountBRRuleDataCollection list = new UsrAccountBRRuleDataCollection();
			using (SafeDataReader reader = base.ExecuteDataReaderEx(sql, paras))
			{
				while(reader.Read())
				{
					UsrAccountBRRuleData data = this.CreateDataByReader(reader);
					list.Add(data);
				}
				reader.Close();
			}
			return list;
		}

		public UsrAccountBRRuleData GetEntityBy(string sqlWhere, SqlParameter[] paras)
		{
			return this.FetchEntity(sqlWhere, paras);
		}

		public UsrAccountBRRuleData GetEntityExBy(string sql, SqlParameter[] paras)
		{
			return this.FetchEntityEx(sql, paras);
		}

		public UsrAccountBRRuleDataCollection GetCollectionBy(string sqlWhere, SqlParameter[] paras)
		{
			return this.FetchCollection(sqlWhere, paras);
		}

		public UsrAccountBRRuleDataCollection GetCollectionExBy(string sql, SqlParameter[] paras)
		{
			return this.FetchCollectionEx(sql, paras);
		}

		public byte[] GetRowVersion( System.Guid UsrAccountBRRulePK)
		{
			string sql = string.Format("SELECT [RowVersion] AS [RowVersion] FROM [{0}] WHERE  [UsrAccountBRRulePK] = @UsrAccountBRRulePK ", this.TableName);
			SqlParameter[] paras = new SqlParameter[1];
			paras[0] = new SqlParameter("@UsrAccountBRRulePK", SqlDbType.UniqueIdentifier, 16);
			paras[0].Value = UsrAccountBRRulePK;
			return (byte[]) base.ExecuteScalar(sql, paras);
		}

		public UsrAccountBRRuleData GetByPK( System.Guid UsrAccountBRRulePK)
		{
			string sql = " WHERE  [UsrAccountBRRule].[UsrAccountBRRulePK] = @UsrAccountBRRulePK ";
			SqlParameter[] paras = new SqlParameter[1];
			paras[0] = new SqlParameter("@UsrAccountBRRulePK", SqlDbType.UniqueIdentifier);
			paras[0].Value = UsrAccountBRRulePK;
			return this.FetchEntity(sql, paras);
		}

		public UsrAccountBRRuleDataCollection GetAll()
		{
			return this.FetchCollection("", null);
		}

		public UsrAccountBRRuleDataCollection GetByUsrAccount(System.Guid UsrAccountPK)
		{
			string sqlWhere = " WHERE [UsrAccountBRRule].[UsrAccountPK] = @UsrAccountPK";
			SqlParameter[] paras = new SqlParameter[1];
			paras[0] = new SqlParameter("@UsrAccountPK", SqlDbType.UniqueIdentifier);
			paras[0].Value = UsrAccountPK;
			return this.FetchCollection(sqlWhere, paras);
		}

		public DataTable GetLogByPK( System.Guid UsrAccountBRRulePK)
		{
			string sql = string.Format("SELECT  [UsrAccountBRRule].[UsrAccountBRRulePK] AS [UsrAccountBRRulePK], [UsrAccountBRRule].[ModifiedOn] AS [ModifiedOn] FROM [{0}] WHERE  [UsrAccountBRRule].[UsrAccountBRRulePK] = @UsrAccountBRRulePK ", this.TableName);
			SqlParameter[] paras = new SqlParameter[1];
			paras[0] = new SqlParameter("@UsrAccountBRRulePK", SqlDbType.UniqueIdentifier);
			paras[0].Value = UsrAccountBRRulePK;
			return this.ExecuteDataTable(sql, paras);
		}

		public DataTable GetLogByUsrAccount(System.Guid usrAccountPK)
		{
			string sql = string.Format("DELETE [{0}] FROM [{0}] [UsrAccountBRRule] INNER JOIN [UsrAccount] ON [UsrAccountBRRule].[UsrAccountPK] = [UsrAccount].[UsrAccountPK] WHERE [UsrAccount].[UsrAccountPK] = @UsrAccountPK;", this.TableName);
			string oldValue = string.Format("DELETE [{0}]", this.TableName);
			string newValue = "SELECT  [UsrAccountBRRule].[UsrAccountBRRulePK] AS [UsrAccountBRRulePK], [UsrAccountBRRule].[ModifiedOn] AS [ModifiedOn]";
			sql = sql.Replace(oldValue, newValue).TrimEnd().TrimEnd(';').Replace(";", " UNION ");
			SqlParameter[] paras = new SqlParameter[1];
			paras[0] = new SqlParameter("@UsrAccountPK", SqlDbType.UniqueIdentifier);
			paras[0].Value = usrAccountPK;
			return base.ExecuteDataTable(sql, paras);
		}

		public DataTable GetLogByBDTenant(System.Guid bDTenantPK)
		{
			string sql = string.Format("DELETE [{0}] FROM [{0}] [UsrAccountBRRule] INNER JOIN [UsrAccount] ON [UsrAccountBRRule].[UsrAccountPK] = [UsrAccount].[UsrAccountPK] INNER JOIN [BDTenant] ON [UsrAccount].[BDTenantPK] = [BDTenant].[BDTenantPK] WHERE [BDTenant].[BDTenantPK] = @BDTenantPK;", this.TableName);
			string oldValue = string.Format("DELETE [{0}]", this.TableName);
			string newValue = "SELECT  [UsrAccountBRRule].[UsrAccountBRRulePK] AS [UsrAccountBRRulePK], [UsrAccountBRRule].[ModifiedOn] AS [ModifiedOn]";
			sql = sql.Replace(oldValue, newValue).TrimEnd().TrimEnd(';').Replace(";", " UNION ");
			SqlParameter[] paras = new SqlParameter[1];
			paras[0] = new SqlParameter("@BDTenantPK", SqlDbType.UniqueIdentifier);
			paras[0].Value = bDTenantPK;
			return base.ExecuteDataTable(sql, paras);
		}

		public DataTable GetLogByBDBuilding(System.Guid bDBuildingPK)
		{
			string sql = string.Format("DELETE [{0}] FROM [{0}] [UsrAccountBRRule] INNER JOIN [UsrAccount] ON [UsrAccountBRRule].[UsrAccountPK] = [UsrAccount].[UsrAccountPK] INNER JOIN [BDTenant] ON [UsrAccount].[BDTenantPK] = [BDTenant].[BDTenantPK] INNER JOIN [BDBuilding] ON [BDTenant].[BDBuildingPK] = [BDBuilding].[BDBuildingPK] WHERE [BDBuilding].[BDBuildingPK] = @BDBuildingPK;", this.TableName);
			string oldValue = string.Format("DELETE [{0}]", this.TableName);
			string newValue = "SELECT  [UsrAccountBRRule].[UsrAccountBRRulePK] AS [UsrAccountBRRulePK], [UsrAccountBRRule].[ModifiedOn] AS [ModifiedOn]";
			sql = sql.Replace(oldValue, newValue).TrimEnd().TrimEnd(';').Replace(";", " UNION ");
			SqlParameter[] paras = new SqlParameter[1];
			paras[0] = new SqlParameter("@BDBuildingPK", SqlDbType.UniqueIdentifier);
			paras[0].Value = bDBuildingPK;
			return base.ExecuteDataTable(sql, paras);
		}

		public DataTable GetLogByUsrGroup(System.Guid usrGroupPK)
		{
			string sql = string.Format("DELETE [{0}] FROM [{0}] [UsrAccountBRRule] INNER JOIN [UsrAccount] ON [UsrAccountBRRule].[UsrAccountPK] = [UsrAccount].[UsrAccountPK] INNER JOIN [UsrGroup] ON [UsrAccount].[UsrGroupPK] = [UsrGroup].[UsrGroupPK] WHERE [UsrGroup].[UsrGroupPK] = @UsrGroupPK;", this.TableName);
			string oldValue = string.Format("DELETE [{0}]", this.TableName);
			string newValue = "SELECT  [UsrAccountBRRule].[UsrAccountBRRulePK] AS [UsrAccountBRRulePK], [UsrAccountBRRule].[ModifiedOn] AS [ModifiedOn]";
			sql = sql.Replace(oldValue, newValue).TrimEnd().TrimEnd(';').Replace(";", " UNION ");
			SqlParameter[] paras = new SqlParameter[1];
			paras[0] = new SqlParameter("@UsrGroupPK", SqlDbType.UniqueIdentifier);
			paras[0].Value = usrGroupPK;
			return base.ExecuteDataTable(sql, paras);
		}

		public int DeleteByPK( System.Guid UsrAccountBRRulePK, byte[] RowVersion)
		{
			string sql = string.Format("DELETE FROM [{0}] WHERE  [UsrAccountBRRulePK] = @UsrAccountBRRulePK AND [RowVersion] = @RowVersion", this.TableName);
			SqlParameter[] paras = new SqlParameter[2];
			paras[0] = new SqlParameter("@UsrAccountBRRulePK", SqlDbType.UniqueIdentifier);
			paras[0].Value = UsrAccountBRRulePK;
			paras[1] = new SqlParameter("@RowVersion", SqlDbType.Timestamp, 8);
			paras[1].Value = RowVersion;
			return base.ExecuteNonQuery(sql, paras);
		}

		public int DeleteAll()
		{
			string sql = string.Format("DELETE FROM [{0}]", this.TableName);
			return base.ExecuteNonQuery(sql, null);
		}

		public int DeleteByUsrAccount(System.Guid usrAccountPK)
		{
			string sql = string.Format("DELETE [{0}] FROM [{0}] [UsrAccountBRRule] INNER JOIN [UsrAccount] ON [UsrAccountBRRule].[UsrAccountPK] = [UsrAccount].[UsrAccountPK] WHERE [UsrAccount].[UsrAccountPK] = @UsrAccountPK;", this.TableName);
			SqlParameter[] paras = new SqlParameter[1];
			paras[0] = new SqlParameter("@UsrAccountPK", SqlDbType.UniqueIdentifier);
			paras[0].Value = usrAccountPK;
			return base.ExecuteNonQuery(sql, paras);
		}

		public int DeleteByBDTenant(System.Guid bDTenantPK)
		{
			string sql = string.Format("DELETE [{0}] FROM [{0}] [UsrAccountBRRule] INNER JOIN [UsrAccount] ON [UsrAccountBRRule].[UsrAccountPK] = [UsrAccount].[UsrAccountPK] INNER JOIN [BDTenant] ON [UsrAccount].[BDTenantPK] = [BDTenant].[BDTenantPK] WHERE [BDTenant].[BDTenantPK] = @BDTenantPK;", this.TableName);
			SqlParameter[] paras = new SqlParameter[1];
			paras[0] = new SqlParameter("@BDTenantPK", SqlDbType.UniqueIdentifier);
			paras[0].Value = bDTenantPK;
			return base.ExecuteNonQuery(sql, paras);
		}

		public int DeleteByBDBuilding(System.Guid bDBuildingPK)
		{
			string sql = string.Format("DELETE [{0}] FROM [{0}] [UsrAccountBRRule] INNER JOIN [UsrAccount] ON [UsrAccountBRRule].[UsrAccountPK] = [UsrAccount].[UsrAccountPK] INNER JOIN [BDTenant] ON [UsrAccount].[BDTenantPK] = [BDTenant].[BDTenantPK] INNER JOIN [BDBuilding] ON [BDTenant].[BDBuildingPK] = [BDBuilding].[BDBuildingPK] WHERE [BDBuilding].[BDBuildingPK] = @BDBuildingPK;", this.TableName);
			SqlParameter[] paras = new SqlParameter[1];
			paras[0] = new SqlParameter("@BDBuildingPK", SqlDbType.UniqueIdentifier);
			paras[0].Value = bDBuildingPK;
			return base.ExecuteNonQuery(sql, paras);
		}

		public int DeleteByUsrGroup(System.Guid usrGroupPK)
		{
			string sql = string.Format("DELETE [{0}] FROM [{0}] [UsrAccountBRRule] INNER JOIN [UsrAccount] ON [UsrAccountBRRule].[UsrAccountPK] = [UsrAccount].[UsrAccountPK] INNER JOIN [UsrGroup] ON [UsrAccount].[UsrGroupPK] = [UsrGroup].[UsrGroupPK] WHERE [UsrGroup].[UsrGroupPK] = @UsrGroupPK;", this.TableName);
			SqlParameter[] paras = new SqlParameter[1];
			paras[0] = new SqlParameter("@UsrGroupPK", SqlDbType.UniqueIdentifier);
			paras[0].Value = usrGroupPK;
			return base.ExecuteNonQuery(sql, paras);
		}


	}
	public class UsrAccountTenantMapCRUD : DataAccessBase
	{
		private string _tableName = "UsrAccountTenantMap";

		public UsrAccountTenantMapCRUD(string connectionString) : base(connectionString)
		{
		}

		public virtual string TableName
		{
			get { return this._tableName; }
			set { this._tableName = value; }
		}

		public string SQLColumns
		{
			get
			{
				return "[UsrAccountTenantMap].[UsrAccountTenantMapPK] AS [UsrAccountTenantMapPK],[UsrAccountTenantMap].[UsrAccountPK] AS [UsrAccountPK],[UsrAccountTenantMap].[BDTenantPK] AS [BDTenantPK],[UsrAccountTenantMap].[RowVersion] AS [RowVersion],[UsrAccountTenantMap].[CreatedOn] AS [CreatedOn],[UsrAccountTenantMap].[CreatedBy] AS [CreatedBy],[UsrAccountTenantMap].[ModifiedOn] AS [ModifiedOn],[UsrAccountTenantMap].[ModifiedBy] AS [ModifiedBy],[BDTenant].[Tenant] AS [Tenant],[BDTenant].[BDBuildingPK] AS [BDBuildingPK],[UsrAccount].[UserID] AS [UserID],[BDBuilding].[Address1] AS [Address1],[BDBuilding].[BuildingID] AS [BuildingID]";
			}
		}

		public string SQLLeftJoins
		{
			get
			{
				return "LEFT JOIN [BDTenant] [BDTenant] ON [UsrAccountTenantMap].[BDTenantPK] = [BDTenant].[BDTenantPK] LEFT JOIN [UsrAccount] [UsrAccount] ON [UsrAccountTenantMap].[UsrAccountPK] = [UsrAccount].[UsrAccountPK] LEFT JOIN [BDBuilding] [BDBuilding] ON [BDTenant].[BDBuildingPK] = [BDBuilding].[BDBuildingPK]";
			}
		}

		protected override string SQLSelect
		{
			get
			{
				return string.Format("SELECT [UsrAccountTenantMap].[UsrAccountTenantMapPK] AS [UsrAccountTenantMapPK],[UsrAccountTenantMap].[UsrAccountPK] AS [UsrAccountPK],[UsrAccountTenantMap].[BDTenantPK] AS [BDTenantPK],[UsrAccountTenantMap].[RowVersion] AS [RowVersion],[UsrAccountTenantMap].[CreatedOn] AS [CreatedOn],[UsrAccountTenantMap].[CreatedBy] AS [CreatedBy],[UsrAccountTenantMap].[ModifiedOn] AS [ModifiedOn],[UsrAccountTenantMap].[ModifiedBy] AS [ModifiedBy],[BDTenant].[Tenant] AS [Tenant],[BDTenant].[BDBuildingPK] AS [BDBuildingPK],[UsrAccount].[UserID] AS [UserID],[BDBuilding].[Address1] AS [Address1],[BDBuilding].[BuildingID] AS [BuildingID] FROM [{0}] [UsrAccountTenantMap] LEFT JOIN [BDTenant] [BDTenant] ON [UsrAccountTenantMap].[BDTenantPK] = [BDTenant].[BDTenantPK] LEFT JOIN [UsrAccount] [UsrAccount] ON [UsrAccountTenantMap].[UsrAccountPK] = [UsrAccount].[UsrAccountPK] LEFT JOIN [BDBuilding] [BDBuilding] ON [BDTenant].[BDBuildingPK] = [BDBuilding].[BDBuildingPK]", this.TableName);
			}
		}

		protected override string SQLCount
		{
			get
			{
				return string.Format("SELECT COUNT(*) FROM [{0}] [UsrAccountTenantMap] LEFT JOIN [BDTenant] [BDTenant] ON [UsrAccountTenantMap].[BDTenantPK] = [BDTenant].[BDTenantPK] LEFT JOIN [UsrAccount] [UsrAccount] ON [UsrAccountTenantMap].[UsrAccountPK] = [UsrAccount].[UsrAccountPK] LEFT JOIN [BDBuilding] [BDBuilding] ON [BDTenant].[BDBuildingPK] = [BDBuilding].[BDBuildingPK]", this.TableName);
			}
		}

		public int Insert(UsrAccountTenantMapData entity)
		{
			string sql = string.Format("INSERT INTO [{0}] ([UsrAccountTenantMapPK],[UsrAccountPK],[BDTenantPK],[CreatedOn],[CreatedBy],[ModifiedOn],[ModifiedBy]) VALUES(@UsrAccountTenantMapPK,@UsrAccountPK,@BDTenantPK,@CreatedOn,@CreatedBy,@ModifiedOn,@ModifiedBy)", this.TableName);
			SqlParameter[] paras = new SqlParameter[7];
			paras[0] = new SqlParameter("@UsrAccountTenantMapPK", SqlDbType.UniqueIdentifier);
			if (entity.UsrAccountTenantMapPK == Guid.Empty)
			{
				paras[0].Value = DBNull.Value;
			}
			else
			{
				paras[0].Value = entity.UsrAccountTenantMapPK;
			}
			paras[1] = new SqlParameter("@UsrAccountPK", SqlDbType.UniqueIdentifier);
			if (entity.UsrAccountPK == Guid.Empty)
			{
				paras[1].Value = DBNull.Value;
			}
			else
			{
				paras[1].Value = entity.UsrAccountPK;
			}
			paras[2] = new SqlParameter("@BDTenantPK", SqlDbType.UniqueIdentifier);
			if (entity.BDTenantPK == Guid.Empty)
			{
				paras[2].Value = DBNull.Value;
			}
			else
			{
				paras[2].Value = entity.BDTenantPK;
			}
			paras[3] = new SqlParameter("@CreatedOn", SqlDbType.DateTime);
			paras[3].Value = entity.CreatedOn;
			paras[4] = new SqlParameter("@CreatedBy", SqlDbType.VarChar, 30);
			paras[4].Value = entity.CreatedBy;
			paras[5] = new SqlParameter("@ModifiedOn", SqlDbType.DateTime);
			paras[5].Value = entity.ModifiedOn;
			paras[6] = new SqlParameter("@ModifiedBy", SqlDbType.VarChar, 30);
			paras[6].Value = entity.ModifiedBy;
			return base.ExecuteNonQuery(sql, paras);
		}

		public int Update(UsrAccountTenantMapData entity)
		{
			string sql = string.Format("UPDATE [{0}] SET [UsrAccountPK] = @UsrAccountPK,[BDTenantPK] = @BDTenantPK,[CreatedOn] = @CreatedOn,[CreatedBy] = @CreatedBy,[ModifiedOn] = @ModifiedOn,[ModifiedBy] = @ModifiedBy  WHERE [UsrAccountTenantMapPK] = @UsrAccountTenantMapPK AND [RowVersion] = @RowVersion", this.TableName);
			SqlParameter[] paras = new SqlParameter[8];
			paras[0] = new SqlParameter("@UsrAccountTenantMapPK", SqlDbType.UniqueIdentifier);
			if (entity.UsrAccountTenantMapPK == Guid.Empty)
			{
				paras[0].Value = DBNull.Value;
			}
			else
			{
				paras[0].Value = entity.UsrAccountTenantMapPK;
			}
			paras[1] = new SqlParameter("@UsrAccountPK", SqlDbType.UniqueIdentifier);
			if (entity.UsrAccountPK == Guid.Empty)
			{
				paras[1].Value = DBNull.Value;
			}
			else
			{
				paras[1].Value = entity.UsrAccountPK;
			}
			paras[2] = new SqlParameter("@BDTenantPK", SqlDbType.UniqueIdentifier);
			if (entity.BDTenantPK == Guid.Empty)
			{
				paras[2].Value = DBNull.Value;
			}
			else
			{
				paras[2].Value = entity.BDTenantPK;
			}
			paras[3] = new SqlParameter("@RowVersion", SqlDbType.Timestamp);
			paras[3].Value = entity.RowVersion;
			paras[4] = new SqlParameter("@CreatedOn", SqlDbType.DateTime);
			paras[4].Value = entity.CreatedOn;
			paras[5] = new SqlParameter("@CreatedBy", SqlDbType.VarChar, 30);
			paras[5].Value = entity.CreatedBy;
			paras[6] = new SqlParameter("@ModifiedOn", SqlDbType.DateTime);
			paras[6].Value = entity.ModifiedOn;
			paras[7] = new SqlParameter("@ModifiedBy", SqlDbType.VarChar, 30);
			paras[7].Value = entity.ModifiedBy;
			return base.ExecuteNonQuery(sql, paras);
		}

		private UsrAccountTenantMapData CreateDataByReader(SafeDataReader reader)
		{
			UsrAccountTenantMapData data = new UsrAccountTenantMapData {
				UsrAccountTenantMapPK = (Guid) reader["UsrAccountTenantMapPK"],
				UsrAccountPK = (Guid) reader["UsrAccountPK"],
				BDTenantPK = (Guid) reader["BDTenantPK"],
				RowVersion = (Byte[]) reader["RowVersion"],
				CreatedOn = (DateTime) reader["CreatedOn"],
				CreatedBy = (String) reader["CreatedBy"],
				ModifiedOn = (DateTime) reader["ModifiedOn"],
				ModifiedBy = (String) reader["ModifiedBy"],
				Tenant = (String) reader["Tenant"],
				BDBuildingPK = (Guid) reader["BDBuildingPK"],
				UserID = (String) reader["UserID"],
				Address1 = (String) reader["Address1"],
				BuildingID = (Int32) reader["BuildingID"]
			};
			data.AcceptChanges();
			return data;
		}

		private UsrAccountTenantMapData FetchEntity(string where, SqlParameter[] paras)
		{
			UsrAccountTenantMapData data = null;
			using (SafeDataReader reader = base.ExecuteDataReader(where, paras))
			{
				if (reader.Read())
				{
					data = this.CreateDataByReader(reader);
				}
				reader.Close();
			}
			return data;
		}

		private UsrAccountTenantMapData FetchEntityEx(string sql, SqlParameter[] paras)
		{
			UsrAccountTenantMapData data = null;
			using (SafeDataReader reader = base.ExecuteDataReaderEx(sql, paras))
			{
				if (reader.Read())
				{
					data = this.CreateDataByReader(reader);
				}
				reader.Close();
			}
			return data;
		}

		private UsrAccountTenantMapDataCollection FetchCollection(string where, SqlParameter[] paras)
		{
			UsrAccountTenantMapDataCollection list = new UsrAccountTenantMapDataCollection();
			using (SafeDataReader reader = base.ExecuteDataReader(where, paras))
			{
				while(reader.Read())
				{
					UsrAccountTenantMapData data = this.CreateDataByReader(reader);
					list.Add(data);
				}
				reader.Close();
			}
			return list;
		}

		private UsrAccountTenantMapDataCollection FetchCollectionEx(string sql, SqlParameter[] paras)
		{
			UsrAccountTenantMapDataCollection list = new UsrAccountTenantMapDataCollection();
			using (SafeDataReader reader = base.ExecuteDataReaderEx(sql, paras))
			{
				while(reader.Read())
				{
					UsrAccountTenantMapData data = this.CreateDataByReader(reader);
					list.Add(data);
				}
				reader.Close();
			}
			return list;
		}

		public UsrAccountTenantMapData GetEntityBy(string sqlWhere, SqlParameter[] paras)
		{
			return this.FetchEntity(sqlWhere, paras);
		}

		public UsrAccountTenantMapData GetEntityExBy(string sql, SqlParameter[] paras)
		{
			return this.FetchEntityEx(sql, paras);
		}

		public UsrAccountTenantMapDataCollection GetCollectionBy(string sqlWhere, SqlParameter[] paras)
		{
			return this.FetchCollection(sqlWhere, paras);
		}

		public UsrAccountTenantMapDataCollection GetCollectionExBy(string sql, SqlParameter[] paras)
		{
			return this.FetchCollectionEx(sql, paras);
		}

		public byte[] GetRowVersion( System.Guid UsrAccountTenantMapPK)
		{
			string sql = string.Format("SELECT [RowVersion] AS [RowVersion] FROM [{0}] WHERE  [UsrAccountTenantMapPK] = @UsrAccountTenantMapPK ", this.TableName);
			SqlParameter[] paras = new SqlParameter[1];
			paras[0] = new SqlParameter("@UsrAccountTenantMapPK", SqlDbType.UniqueIdentifier, 16);
			paras[0].Value = UsrAccountTenantMapPK;
			return (byte[]) base.ExecuteScalar(sql, paras);
		}

		public UsrAccountTenantMapData GetByPK( System.Guid UsrAccountTenantMapPK)
		{
			string sql = " WHERE  [UsrAccountTenantMap].[UsrAccountTenantMapPK] = @UsrAccountTenantMapPK ";
			SqlParameter[] paras = new SqlParameter[1];
			paras[0] = new SqlParameter("@UsrAccountTenantMapPK", SqlDbType.UniqueIdentifier);
			paras[0].Value = UsrAccountTenantMapPK;
			return this.FetchEntity(sql, paras);
		}

		public UsrAccountTenantMapDataCollection GetAll()
		{
			return this.FetchCollection("", null);
		}

		public UsrAccountTenantMapDataCollection GetByBDTenant(System.Guid BDTenantPK)
		{
			string sqlWhere = " WHERE [UsrAccountTenantMap].[BDTenantPK] = @BDTenantPK";
			SqlParameter[] paras = new SqlParameter[1];
			paras[0] = new SqlParameter("@BDTenantPK", SqlDbType.UniqueIdentifier);
			paras[0].Value = BDTenantPK;
			return this.FetchCollection(sqlWhere, paras);
		}

		public UsrAccountTenantMapDataCollection GetByUsrAccount(System.Guid UsrAccountPK)
		{
			string sqlWhere = " WHERE [UsrAccountTenantMap].[UsrAccountPK] = @UsrAccountPK";
			SqlParameter[] paras = new SqlParameter[1];
			paras[0] = new SqlParameter("@UsrAccountPK", SqlDbType.UniqueIdentifier);
			paras[0].Value = UsrAccountPK;
			return this.FetchCollection(sqlWhere, paras);
		}

		public DataTable GetLogByPK( System.Guid UsrAccountTenantMapPK)
		{
			string sql = string.Format("SELECT  [UsrAccountTenantMap].[UsrAccountTenantMapPK] AS [UsrAccountTenantMapPK], [UsrAccountTenantMap].[ModifiedOn] AS [ModifiedOn] FROM [{0}] WHERE  [UsrAccountTenantMap].[UsrAccountTenantMapPK] = @UsrAccountTenantMapPK ", this.TableName);
			SqlParameter[] paras = new SqlParameter[1];
			paras[0] = new SqlParameter("@UsrAccountTenantMapPK", SqlDbType.UniqueIdentifier);
			paras[0].Value = UsrAccountTenantMapPK;
			return this.ExecuteDataTable(sql, paras);
		}

		public DataTable GetLogByBDTenant(System.Guid bDTenantPK)
		{
			string sql = string.Format("DELETE [{0}] FROM [{0}] [UsrAccountTenantMap] INNER JOIN [BDTenant] ON [UsrAccountTenantMap].[BDTenantPK] = [BDTenant].[BDTenantPK] WHERE [BDTenant].[BDTenantPK] = @BDTenantPK;DELETE [{0}] FROM [{0}] [UsrAccountTenantMap] INNER JOIN [UsrAccount] ON [UsrAccountTenantMap].[UsrAccountPK] = [UsrAccount].[UsrAccountPK] INNER JOIN [BDTenant] ON [UsrAccount].[BDTenantPK] = [BDTenant].[BDTenantPK] WHERE [BDTenant].[BDTenantPK] = @BDTenantPK;", this.TableName);
			string oldValue = string.Format("DELETE [{0}]", this.TableName);
			string newValue = "SELECT  [UsrAccountTenantMap].[UsrAccountTenantMapPK] AS [UsrAccountTenantMapPK], [UsrAccountTenantMap].[ModifiedOn] AS [ModifiedOn]";
			sql = sql.Replace(oldValue, newValue).TrimEnd().TrimEnd(';').Replace(";", " UNION ");
			SqlParameter[] paras = new SqlParameter[1];
			paras[0] = new SqlParameter("@BDTenantPK", SqlDbType.UniqueIdentifier);
			paras[0].Value = bDTenantPK;
			return base.ExecuteDataTable(sql, paras);
		}

		public DataTable GetLogByBDBuilding(System.Guid bDBuildingPK)
		{
			string sql = string.Format("DELETE [{0}] FROM [{0}] [UsrAccountTenantMap] INNER JOIN [BDTenant] ON [UsrAccountTenantMap].[BDTenantPK] = [BDTenant].[BDTenantPK] INNER JOIN [BDBuilding] ON [BDTenant].[BDBuildingPK] = [BDBuilding].[BDBuildingPK] WHERE [BDBuilding].[BDBuildingPK] = @BDBuildingPK;DELETE [{0}] FROM [{0}] [UsrAccountTenantMap] INNER JOIN [UsrAccount] ON [UsrAccountTenantMap].[UsrAccountPK] = [UsrAccount].[UsrAccountPK] INNER JOIN [BDTenant] ON [UsrAccount].[BDTenantPK] = [BDTenant].[BDTenantPK] INNER JOIN [BDBuilding] ON [BDTenant].[BDBuildingPK] = [BDBuilding].[BDBuildingPK] WHERE [BDBuilding].[BDBuildingPK] = @BDBuildingPK;", this.TableName);
			string oldValue = string.Format("DELETE [{0}]", this.TableName);
			string newValue = "SELECT  [UsrAccountTenantMap].[UsrAccountTenantMapPK] AS [UsrAccountTenantMapPK], [UsrAccountTenantMap].[ModifiedOn] AS [ModifiedOn]";
			sql = sql.Replace(oldValue, newValue).TrimEnd().TrimEnd(';').Replace(";", " UNION ");
			SqlParameter[] paras = new SqlParameter[1];
			paras[0] = new SqlParameter("@BDBuildingPK", SqlDbType.UniqueIdentifier);
			paras[0].Value = bDBuildingPK;
			return base.ExecuteDataTable(sql, paras);
		}

		public DataTable GetLogByUsrAccount(System.Guid usrAccountPK)
		{
			string sql = string.Format("DELETE [{0}] FROM [{0}] [UsrAccountTenantMap] INNER JOIN [UsrAccount] ON [UsrAccountTenantMap].[UsrAccountPK] = [UsrAccount].[UsrAccountPK] WHERE [UsrAccount].[UsrAccountPK] = @UsrAccountPK;", this.TableName);
			string oldValue = string.Format("DELETE [{0}]", this.TableName);
			string newValue = "SELECT  [UsrAccountTenantMap].[UsrAccountTenantMapPK] AS [UsrAccountTenantMapPK], [UsrAccountTenantMap].[ModifiedOn] AS [ModifiedOn]";
			sql = sql.Replace(oldValue, newValue).TrimEnd().TrimEnd(';').Replace(";", " UNION ");
			SqlParameter[] paras = new SqlParameter[1];
			paras[0] = new SqlParameter("@UsrAccountPK", SqlDbType.UniqueIdentifier);
			paras[0].Value = usrAccountPK;
			return base.ExecuteDataTable(sql, paras);
		}

		public DataTable GetLogByUsrGroup(System.Guid usrGroupPK)
		{
			string sql = string.Format("DELETE [{0}] FROM [{0}] [UsrAccountTenantMap] INNER JOIN [UsrAccount] ON [UsrAccountTenantMap].[UsrAccountPK] = [UsrAccount].[UsrAccountPK] INNER JOIN [UsrGroup] ON [UsrAccount].[UsrGroupPK] = [UsrGroup].[UsrGroupPK] WHERE [UsrGroup].[UsrGroupPK] = @UsrGroupPK;", this.TableName);
			string oldValue = string.Format("DELETE [{0}]", this.TableName);
			string newValue = "SELECT  [UsrAccountTenantMap].[UsrAccountTenantMapPK] AS [UsrAccountTenantMapPK], [UsrAccountTenantMap].[ModifiedOn] AS [ModifiedOn]";
			sql = sql.Replace(oldValue, newValue).TrimEnd().TrimEnd(';').Replace(";", " UNION ");
			SqlParameter[] paras = new SqlParameter[1];
			paras[0] = new SqlParameter("@UsrGroupPK", SqlDbType.UniqueIdentifier);
			paras[0].Value = usrGroupPK;
			return base.ExecuteDataTable(sql, paras);
		}

		public int DeleteByPK( System.Guid UsrAccountTenantMapPK, byte[] RowVersion)
		{
			string sql = string.Format("DELETE FROM [{0}] WHERE  [UsrAccountTenantMapPK] = @UsrAccountTenantMapPK AND [RowVersion] = @RowVersion", this.TableName);
			SqlParameter[] paras = new SqlParameter[2];
			paras[0] = new SqlParameter("@UsrAccountTenantMapPK", SqlDbType.UniqueIdentifier);
			paras[0].Value = UsrAccountTenantMapPK;
			paras[1] = new SqlParameter("@RowVersion", SqlDbType.Timestamp, 8);
			paras[1].Value = RowVersion;
			return base.ExecuteNonQuery(sql, paras);
		}

		public int DeleteAll()
		{
			string sql = string.Format("DELETE FROM [{0}]", this.TableName);
			return base.ExecuteNonQuery(sql, null);
		}

		public int DeleteByBDTenant(System.Guid bDTenantPK)
		{
			string sql = string.Format("DELETE [{0}] FROM [{0}] [UsrAccountTenantMap] INNER JOIN [BDTenant] ON [UsrAccountTenantMap].[BDTenantPK] = [BDTenant].[BDTenantPK] WHERE [BDTenant].[BDTenantPK] = @BDTenantPK;DELETE [{0}] FROM [{0}] [UsrAccountTenantMap] INNER JOIN [UsrAccount] ON [UsrAccountTenantMap].[UsrAccountPK] = [UsrAccount].[UsrAccountPK] INNER JOIN [BDTenant] ON [UsrAccount].[BDTenantPK] = [BDTenant].[BDTenantPK] WHERE [BDTenant].[BDTenantPK] = @BDTenantPK;", this.TableName);
			SqlParameter[] paras = new SqlParameter[1];
			paras[0] = new SqlParameter("@BDTenantPK", SqlDbType.UniqueIdentifier);
			paras[0].Value = bDTenantPK;
			return base.ExecuteNonQuery(sql, paras);
		}

		public int DeleteByBDBuilding(System.Guid bDBuildingPK)
		{
			string sql = string.Format("DELETE [{0}] FROM [{0}] [UsrAccountTenantMap] INNER JOIN [BDTenant] ON [UsrAccountTenantMap].[BDTenantPK] = [BDTenant].[BDTenantPK] INNER JOIN [BDBuilding] ON [BDTenant].[BDBuildingPK] = [BDBuilding].[BDBuildingPK] WHERE [BDBuilding].[BDBuildingPK] = @BDBuildingPK;DELETE [{0}] FROM [{0}] [UsrAccountTenantMap] INNER JOIN [UsrAccount] ON [UsrAccountTenantMap].[UsrAccountPK] = [UsrAccount].[UsrAccountPK] INNER JOIN [BDTenant] ON [UsrAccount].[BDTenantPK] = [BDTenant].[BDTenantPK] INNER JOIN [BDBuilding] ON [BDTenant].[BDBuildingPK] = [BDBuilding].[BDBuildingPK] WHERE [BDBuilding].[BDBuildingPK] = @BDBuildingPK;", this.TableName);
			SqlParameter[] paras = new SqlParameter[1];
			paras[0] = new SqlParameter("@BDBuildingPK", SqlDbType.UniqueIdentifier);
			paras[0].Value = bDBuildingPK;
			return base.ExecuteNonQuery(sql, paras);
		}

		public int DeleteByUsrAccount(System.Guid usrAccountPK)
		{
			string sql = string.Format("DELETE [{0}] FROM [{0}] [UsrAccountTenantMap] INNER JOIN [UsrAccount] ON [UsrAccountTenantMap].[UsrAccountPK] = [UsrAccount].[UsrAccountPK] WHERE [UsrAccount].[UsrAccountPK] = @UsrAccountPK;", this.TableName);
			SqlParameter[] paras = new SqlParameter[1];
			paras[0] = new SqlParameter("@UsrAccountPK", SqlDbType.UniqueIdentifier);
			paras[0].Value = usrAccountPK;
			return base.ExecuteNonQuery(sql, paras);
		}

		public int DeleteByUsrGroup(System.Guid usrGroupPK)
		{
			string sql = string.Format("DELETE [{0}] FROM [{0}] [UsrAccountTenantMap] INNER JOIN [UsrAccount] ON [UsrAccountTenantMap].[UsrAccountPK] = [UsrAccount].[UsrAccountPK] INNER JOIN [UsrGroup] ON [UsrAccount].[UsrGroupPK] = [UsrGroup].[UsrGroupPK] WHERE [UsrGroup].[UsrGroupPK] = @UsrGroupPK;", this.TableName);
			SqlParameter[] paras = new SqlParameter[1];
			paras[0] = new SqlParameter("@UsrGroupPK", SqlDbType.UniqueIdentifier);
			paras[0].Value = usrGroupPK;
			return base.ExecuteNonQuery(sql, paras);
		}


	}
}
