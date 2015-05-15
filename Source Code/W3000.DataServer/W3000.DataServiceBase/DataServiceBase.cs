using System;
using System.Data;
using System.Data.SqlClient;
using Cheke;
using Cheke.BusinessEntity;
using Cheke.BusinessService;
using Cheke.DataAccess;
using W3000.Data;
using W3000.CRUD;

namespace W3000.DataServiceBase
{
	public abstract class ACIntvalHolidayMapDataServiceBase : ServiceBase
	{
		protected ACIntvalHolidayMapCRUD _dal;

		public ACIntvalHolidayMapDataServiceBase(string connectionString, SecurityToken token) : base(connectionString, token)
		{
			this._dal = new ACIntvalHolidayMapCRUD(connectionString);
			for (int i = 0; i < token.GetSortFields().Count; i++)
			{
				SortField field = token.GetSortFields()[i];
				this._dal.AddSortBy(field.FieldAlias, field.ASC);
			}
		}

		protected override string TableName
		{
			get
			{
				return "ACIntvalHolidayMap";
			}
		}


		protected override int DeleteEntity(BusinessBase entity)
		{
			ACIntvalHolidayMapData data = (ACIntvalHolidayMapData) entity;
			if(data == null)
				return 0;

			return this._dal.DeleteByPK( data.ACIntvalHolidayMapPK, data.RowVersion);
		}

		internal int DeleteByACInterval(BusinessBase entity)
		{
			ACIntervalData data = (ACIntervalData) entity;
			if(data == null)
				return 0;

			bool isLogDeleteEnabled = ServiceBase._DBLog.IsLogDeleteEnabled;
			bool isLinkDBDeleteEnabled = ServiceBase._DBLink.IsLinkDBDeleteEnabled;
			if (!isLogDeleteEnabled && !isLinkDBDeleteEnabled)
			{
				return this._dal.DeleteByACInterval(data. ACIntervalPK);
			}

			DataTable list = this._dal.GetLogByACInterval(data. ACIntervalPK);
			list.TableName = this._dal.TableName;
			int ret = this._dal.DeleteByACInterval(data. ACIntervalPK);
			if (isLogDeleteEnabled)
			{
				ServiceBase._DBLog.LogDelete(list, base.SecurityToken);
			}

			if (isLinkDBDeleteEnabled)
			{
				ServiceBase._DBLink.LinkDBDelete(list, base.TrustedToken);
			}

			return ret;
		}

		internal int DeleteByBDBuilding(BusinessBase entity)
		{
			BDBuildingData data = (BDBuildingData) entity;
			if(data == null)
				return 0;

			bool isLogDeleteEnabled = ServiceBase._DBLog.IsLogDeleteEnabled;
			bool isLinkDBDeleteEnabled = ServiceBase._DBLink.IsLinkDBDeleteEnabled;
			if (!isLogDeleteEnabled && !isLinkDBDeleteEnabled)
			{
				return this._dal.DeleteByBDBuilding(data. BDBuildingPK);
			}

			DataTable list = this._dal.GetLogByBDBuilding(data. BDBuildingPK);
			list.TableName = this._dal.TableName;
			int ret = this._dal.DeleteByBDBuilding(data. BDBuildingPK);
			if (isLogDeleteEnabled)
			{
				ServiceBase._DBLog.LogDelete(list, base.SecurityToken);
			}

			if (isLinkDBDeleteEnabled)
			{
				ServiceBase._DBLink.LinkDBDelete(list, base.TrustedToken);
			}

			return ret;
		}

		internal int DeleteByUtilHoliday(BusinessBase entity)
		{
			UtilHolidayData data = (UtilHolidayData) entity;
			if(data == null)
				return 0;

			bool isLogDeleteEnabled = ServiceBase._DBLog.IsLogDeleteEnabled;
			bool isLinkDBDeleteEnabled = ServiceBase._DBLink.IsLinkDBDeleteEnabled;
			if (!isLogDeleteEnabled && !isLinkDBDeleteEnabled)
			{
				return this._dal.DeleteByUtilHoliday(data. UtilHolidayPK);
			}

			DataTable list = this._dal.GetLogByUtilHoliday(data. UtilHolidayPK);
			list.TableName = this._dal.TableName;
			int ret = this._dal.DeleteByUtilHoliday(data. UtilHolidayPK);
			if (isLogDeleteEnabled)
			{
				ServiceBase._DBLog.LogDelete(list, base.SecurityToken);
			}

			if (isLinkDBDeleteEnabled)
			{
				ServiceBase._DBLink.LinkDBDelete(list, base.TrustedToken);
			}

			return ret;
		}

		public virtual Result Purge(ACIntvalHolidayMapData entity)
		{
			return base.Purge(entity);
		}

		protected override int PurgeEntity(BusinessBase entity)
		{
			ACIntvalHolidayMapData data = (ACIntvalHolidayMapData) entity;
			if(data == null)
				return 0;

			return this._dal.DeleteByPK( data.ACIntvalHolidayMapPK, data.RowVersion);
		}

		internal int PurgeByACInterval(BusinessBase entity)
		{
			ACIntervalData data = (ACIntervalData) entity;
			if(data == null)
				return 0;

			return this._dal.DeleteByACInterval(data. ACIntervalPK);
		}

		internal int PurgeByBDBuilding(BusinessBase entity)
		{
			BDBuildingData data = (BDBuildingData) entity;
			if(data == null)
				return 0;

			return this._dal.DeleteByBDBuilding(data. BDBuildingPK);
		}

		internal int PurgeByUtilHoliday(BusinessBase entity)
		{
			UtilHolidayData data = (UtilHolidayData) entity;
			if(data == null)
				return 0;

			return this._dal.DeleteByUtilHoliday(data. UtilHolidayPK);
		}

		protected override int InsertEntity(BusinessBase entity)
		{
			ACIntvalHolidayMapData data = (ACIntvalHolidayMapData) entity;
			if(data == null)
				return 0;

			return this._dal.Insert(data);
		}

		protected override int UpdateEntity(BusinessBase entity)
		{
			ACIntvalHolidayMapData data = (ACIntvalHolidayMapData) entity;
			if(data == null)
				return 0;

			return this._dal.Update(data);
		}

		protected override void UpdateChildren(BusinessBase entity)
		{
			ACIntvalHolidayMapData data = (ACIntvalHolidayMapData) entity;
			if(data == null)
				return;

		}

		internal Result GetRowVersion(ACIntvalHolidayMapDataCollection list)
		{
			return base.GetRowVersion(list);
		}

		protected override Result GetRowVersion(BusinessBase entity)
		{
			ACIntvalHolidayMapData data = (ACIntvalHolidayMapData) entity;
			if(data == null || !data.IsDirty)
				return new Result(true);

			Result result = new Result(true);
			if (entity.IsDeleted)
			{
				result.Add(data.ObjectID, new byte[0]);
				return result;
			}

			if (entity.IsSelfDirty)
			{
				result.Add(data.ObjectID, this._dal.GetRowVersion( data.ACIntvalHolidayMapPK));
			}
			return result;
		}

		public virtual ACIntvalHolidayMapData GetByPK( System.Guid ACIntvalHolidayMapPK)
		{
			if (base.IsTrusted)
			{
				return this.Processing(this._dal.GetByPK( ACIntvalHolidayMapPK));
			}

			if (!base.IsAuthorizedSelect)
			{
				return null;
			}

			return this.Processing((ACIntvalHolidayMapData) base.Filter(this._dal.GetByPK( ACIntvalHolidayMapPK)));
		}

		protected virtual ACIntvalHolidayMapData GetEntity(string sqlWhere, SqlParameter[] paras)
		{
			if (base.IsTrusted)
			{
				return this.Processing(this._dal.GetEntityBy(sqlWhere, paras));
			}

			if (!base.IsAuthorizedSelect)
			{
				return null;
			}

			return this.Processing((ACIntvalHolidayMapData) base.Filter(this._dal.GetEntityBy(sqlWhere, paras)));
		}

		public virtual ACIntvalHolidayMapDataCollection GetAll()
		{
			if (base.IsTrusted)
			{
				return this.Processing(this._dal.GetAll());
			}

			if (!base.IsAuthorizedSelect)
			{
				return new ACIntvalHolidayMapDataCollection();
			}

			return this.Processing((ACIntvalHolidayMapDataCollection) base.Filter(this._dal.GetAll()));
		}

		public ACIntvalHolidayMapViewCollection GetViewAll()
		{
			return new ACIntvalHolidayMapViewCollection(this.GetAll());
		}

		protected virtual ACIntvalHolidayMapDataCollection GetCollection(string sqlWhere, SqlParameter[] paras)
		{
			if (base.IsTrusted)
			{
				return this.Processing(this._dal.GetCollectionBy(sqlWhere, paras));
			}

			if (!base.IsAuthorizedSelect)
			{
				return new ACIntvalHolidayMapDataCollection();
			}

			 return this.Processing((ACIntvalHolidayMapDataCollection) base.Filter(this._dal.GetCollectionBy(sqlWhere, paras)));
		}

		public virtual ACIntvalHolidayMapDataCollection GetByACInterval(System.Guid ACIntervalPK)
		{
			if (base.IsTrusted)
			{
				return this.Processing(this._dal.GetByACInterval(ACIntervalPK));
			}

			if (!base.IsAuthorizedSelect)
			{
				return null;
			}

			return this.Processing((ACIntvalHolidayMapDataCollection) base.Filter(this._dal.GetByACInterval(ACIntervalPK)));
		}

		public ACIntvalHolidayMapViewCollection GetViewByACInterval(System.Guid ACIntervalPK)
		{
			return new ACIntvalHolidayMapViewCollection(this.GetByACInterval(ACIntervalPK));
		}

		public virtual ACIntvalHolidayMapDataCollection GetByUtilHoliday(System.Guid UtilHolidayPK)
		{
			if (base.IsTrusted)
			{
				return this.Processing(this._dal.GetByUtilHoliday(UtilHolidayPK));
			}

			if (!base.IsAuthorizedSelect)
			{
				return null;
			}

			return this.Processing((ACIntvalHolidayMapDataCollection) base.Filter(this._dal.GetByUtilHoliday(UtilHolidayPK)));
		}

		public ACIntvalHolidayMapViewCollection GetViewByUtilHoliday(System.Guid UtilHolidayPK)
		{
			return new ACIntvalHolidayMapViewCollection(this.GetByUtilHoliday(UtilHolidayPK));
		}

		protected virtual ACIntvalHolidayMapData Processing(ACIntvalHolidayMapData entity)
		{
			return entity;
		}

		protected virtual ACIntvalHolidayMapDataCollection Processing(ACIntvalHolidayMapDataCollection list)
		{
			ACIntvalHolidayMapDataCollection retList = new ACIntvalHolidayMapDataCollection();
			foreach(ACIntvalHolidayMapData item in list)
			{
				ACIntvalHolidayMapData data = this.Processing(item);
				if(data != null)
				{
					retList.Add(data);
				}
			}

			return retList;
		}

		public virtual Result Save(ACIntvalHolidayMapData entity)
		{
			return base.Save(entity);
		}

		public virtual void SaveUnderTransaction(ACIntvalHolidayMapData entity)
		{
			base.SaveUnderTransaction(entity);
		}

		public virtual Result Save(ACIntvalHolidayMapDataCollection list)
		{
			return base.Save(list);
		}

		public virtual void SaveUnderTransaction(ACIntvalHolidayMapDataCollection list)
		{
			base.SaveUnderTransaction(list);
		}


	}
	public abstract class ACAccessLevelDetailDataServiceBase : ServiceBase
	{
		protected ACAccessLevelDetailCRUD _dal;

		public ACAccessLevelDetailDataServiceBase(string connectionString, SecurityToken token) : base(connectionString, token)
		{
			this._dal = new ACAccessLevelDetailCRUD(connectionString);
			for (int i = 0; i < token.GetSortFields().Count; i++)
			{
				SortField field = token.GetSortFields()[i];
				this._dal.AddSortBy(field.FieldAlias, field.ASC);
			}
		}

		protected override string TableName
		{
			get
			{
				return "ACAccessLevelDetail";
			}
		}


		protected override int DeleteEntity(BusinessBase entity)
		{
			ACAccessLevelDetailData data = (ACAccessLevelDetailData) entity;
			if(data == null)
				return 0;

			return this._dal.DeleteByPK( data.ACAccessLevelDetailPK, data.RowVersion);
		}

		internal int DeleteByACMainZone(BusinessBase entity)
		{
			ACMainZoneData data = (ACMainZoneData) entity;
			if(data == null)
				return 0;

			bool isLogDeleteEnabled = ServiceBase._DBLog.IsLogDeleteEnabled;
			bool isLinkDBDeleteEnabled = ServiceBase._DBLink.IsLinkDBDeleteEnabled;
			if (!isLogDeleteEnabled && !isLinkDBDeleteEnabled)
			{
				return this._dal.DeleteByACMainZone(data. ACMainZonePK);
			}

			DataTable list = this._dal.GetLogByACMainZone(data. ACMainZonePK);
			list.TableName = this._dal.TableName;
			int ret = this._dal.DeleteByACMainZone(data. ACMainZonePK);
			if (isLogDeleteEnabled)
			{
				ServiceBase._DBLog.LogDelete(list, base.SecurityToken);
			}

			if (isLinkDBDeleteEnabled)
			{
				ServiceBase._DBLink.LinkDBDelete(list, base.TrustedToken);
			}

			return ret;
		}

		internal int DeleteByACPanel(BusinessBase entity)
		{
			ACPanelData data = (ACPanelData) entity;
			if(data == null)
				return 0;

			bool isLogDeleteEnabled = ServiceBase._DBLog.IsLogDeleteEnabled;
			bool isLinkDBDeleteEnabled = ServiceBase._DBLink.IsLinkDBDeleteEnabled;
			if (!isLogDeleteEnabled && !isLinkDBDeleteEnabled)
			{
				return this._dal.DeleteByACPanel(data. ACPanelPK);
			}

			DataTable list = this._dal.GetLogByACPanel(data. ACPanelPK);
			list.TableName = this._dal.TableName;
			int ret = this._dal.DeleteByACPanel(data. ACPanelPK);
			if (isLogDeleteEnabled)
			{
				ServiceBase._DBLog.LogDelete(list, base.SecurityToken);
			}

			if (isLinkDBDeleteEnabled)
			{
				ServiceBase._DBLink.LinkDBDelete(list, base.TrustedToken);
			}

			return ret;
		}

		internal int DeleteByBDBuilding(BusinessBase entity)
		{
			BDBuildingData data = (BDBuildingData) entity;
			if(data == null)
				return 0;

			bool isLogDeleteEnabled = ServiceBase._DBLog.IsLogDeleteEnabled;
			bool isLinkDBDeleteEnabled = ServiceBase._DBLink.IsLinkDBDeleteEnabled;
			if (!isLogDeleteEnabled && !isLinkDBDeleteEnabled)
			{
				return this._dal.DeleteByBDBuilding(data. BDBuildingPK);
			}

			DataTable list = this._dal.GetLogByBDBuilding(data. BDBuildingPK);
			list.TableName = this._dal.TableName;
			int ret = this._dal.DeleteByBDBuilding(data. BDBuildingPK);
			if (isLogDeleteEnabled)
			{
				ServiceBase._DBLog.LogDelete(list, base.SecurityToken);
			}

			if (isLinkDBDeleteEnabled)
			{
				ServiceBase._DBLink.LinkDBDelete(list, base.TrustedToken);
			}

			return ret;
		}

		internal int DeleteByACTimecode(BusinessBase entity)
		{
			ACTimecodeData data = (ACTimecodeData) entity;
			if(data == null)
				return 0;

			bool isLogDeleteEnabled = ServiceBase._DBLog.IsLogDeleteEnabled;
			bool isLinkDBDeleteEnabled = ServiceBase._DBLink.IsLinkDBDeleteEnabled;
			if (!isLogDeleteEnabled && !isLinkDBDeleteEnabled)
			{
				return this._dal.DeleteByACTimecode(data. ACTimecodePK);
			}

			DataTable list = this._dal.GetLogByACTimecode(data. ACTimecodePK);
			list.TableName = this._dal.TableName;
			int ret = this._dal.DeleteByACTimecode(data. ACTimecodePK);
			if (isLogDeleteEnabled)
			{
				ServiceBase._DBLog.LogDelete(list, base.SecurityToken);
			}

			if (isLinkDBDeleteEnabled)
			{
				ServiceBase._DBLink.LinkDBDelete(list, base.TrustedToken);
			}

			return ret;
		}

		internal int DeleteByACAccessLevel(BusinessBase entity)
		{
			ACAccessLevelData data = (ACAccessLevelData) entity;
			if(data == null)
				return 0;

			bool isLogDeleteEnabled = ServiceBase._DBLog.IsLogDeleteEnabled;
			bool isLinkDBDeleteEnabled = ServiceBase._DBLink.IsLinkDBDeleteEnabled;
			if (!isLogDeleteEnabled && !isLinkDBDeleteEnabled)
			{
				return this._dal.DeleteByACAccessLevel(data. ACAccessLevelPK);
			}

			DataTable list = this._dal.GetLogByACAccessLevel(data. ACAccessLevelPK);
			list.TableName = this._dal.TableName;
			int ret = this._dal.DeleteByACAccessLevel(data. ACAccessLevelPK);
			if (isLogDeleteEnabled)
			{
				ServiceBase._DBLog.LogDelete(list, base.SecurityToken);
			}

			if (isLinkDBDeleteEnabled)
			{
				ServiceBase._DBLink.LinkDBDelete(list, base.TrustedToken);
			}

			return ret;
		}

		public virtual Result Purge(ACAccessLevelDetailData entity)
		{
			return base.Purge(entity);
		}

		protected override int PurgeEntity(BusinessBase entity)
		{
			ACAccessLevelDetailData data = (ACAccessLevelDetailData) entity;
			if(data == null)
				return 0;

			return this._dal.DeleteByPK( data.ACAccessLevelDetailPK, data.RowVersion);
		}

		internal int PurgeByACMainZone(BusinessBase entity)
		{
			ACMainZoneData data = (ACMainZoneData) entity;
			if(data == null)
				return 0;

			return this._dal.DeleteByACMainZone(data. ACMainZonePK);
		}

		internal int PurgeByACPanel(BusinessBase entity)
		{
			ACPanelData data = (ACPanelData) entity;
			if(data == null)
				return 0;

			return this._dal.DeleteByACPanel(data. ACPanelPK);
		}

		internal int PurgeByBDBuilding(BusinessBase entity)
		{
			BDBuildingData data = (BDBuildingData) entity;
			if(data == null)
				return 0;

			return this._dal.DeleteByBDBuilding(data. BDBuildingPK);
		}

		internal int PurgeByACTimecode(BusinessBase entity)
		{
			ACTimecodeData data = (ACTimecodeData) entity;
			if(data == null)
				return 0;

			return this._dal.DeleteByACTimecode(data. ACTimecodePK);
		}

		internal int PurgeByACAccessLevel(BusinessBase entity)
		{
			ACAccessLevelData data = (ACAccessLevelData) entity;
			if(data == null)
				return 0;

			return this._dal.DeleteByACAccessLevel(data. ACAccessLevelPK);
		}

		protected override int InsertEntity(BusinessBase entity)
		{
			ACAccessLevelDetailData data = (ACAccessLevelDetailData) entity;
			if(data == null)
				return 0;

			return this._dal.Insert(data);
		}

		protected override int UpdateEntity(BusinessBase entity)
		{
			ACAccessLevelDetailData data = (ACAccessLevelDetailData) entity;
			if(data == null)
				return 0;

			return this._dal.Update(data);
		}

		protected override void UpdateChildren(BusinessBase entity)
		{
			ACAccessLevelDetailData data = (ACAccessLevelDetailData) entity;
			if(data == null)
				return;

		}

		internal Result GetRowVersion(ACAccessLevelDetailDataCollection list)
		{
			return base.GetRowVersion(list);
		}

		protected override Result GetRowVersion(BusinessBase entity)
		{
			ACAccessLevelDetailData data = (ACAccessLevelDetailData) entity;
			if(data == null || !data.IsDirty)
				return new Result(true);

			Result result = new Result(true);
			if (entity.IsDeleted)
			{
				result.Add(data.ObjectID, new byte[0]);
				return result;
			}

			if (entity.IsSelfDirty)
			{
				result.Add(data.ObjectID, this._dal.GetRowVersion( data.ACAccessLevelDetailPK));
			}
			return result;
		}

		public virtual ACAccessLevelDetailData GetByPK( System.Guid ACAccessLevelDetailPK)
		{
			if (base.IsTrusted)
			{
				return this.Processing(this._dal.GetByPK( ACAccessLevelDetailPK));
			}

			if (!base.IsAuthorizedSelect)
			{
				return null;
			}

			return this.Processing((ACAccessLevelDetailData) base.Filter(this._dal.GetByPK( ACAccessLevelDetailPK)));
		}

		protected virtual ACAccessLevelDetailData GetEntity(string sqlWhere, SqlParameter[] paras)
		{
			if (base.IsTrusted)
			{
				return this.Processing(this._dal.GetEntityBy(sqlWhere, paras));
			}

			if (!base.IsAuthorizedSelect)
			{
				return null;
			}

			return this.Processing((ACAccessLevelDetailData) base.Filter(this._dal.GetEntityBy(sqlWhere, paras)));
		}

		public virtual ACAccessLevelDetailDataCollection GetAll()
		{
			if (base.IsTrusted)
			{
				return this.Processing(this._dal.GetAll());
			}

			if (!base.IsAuthorizedSelect)
			{
				return new ACAccessLevelDetailDataCollection();
			}

			return this.Processing((ACAccessLevelDetailDataCollection) base.Filter(this._dal.GetAll()));
		}

		public ACAccessLevelDetailViewCollection GetViewAll()
		{
			return new ACAccessLevelDetailViewCollection(this.GetAll());
		}

		protected virtual ACAccessLevelDetailDataCollection GetCollection(string sqlWhere, SqlParameter[] paras)
		{
			if (base.IsTrusted)
			{
				return this.Processing(this._dal.GetCollectionBy(sqlWhere, paras));
			}

			if (!base.IsAuthorizedSelect)
			{
				return new ACAccessLevelDetailDataCollection();
			}

			 return this.Processing((ACAccessLevelDetailDataCollection) base.Filter(this._dal.GetCollectionBy(sqlWhere, paras)));
		}

		public virtual ACAccessLevelDetailDataCollection GetByACMainZone(System.Guid ACMainZonePK)
		{
			if (base.IsTrusted)
			{
				return this.Processing(this._dal.GetByACMainZone(ACMainZonePK));
			}

			if (!base.IsAuthorizedSelect)
			{
				return null;
			}

			return this.Processing((ACAccessLevelDetailDataCollection) base.Filter(this._dal.GetByACMainZone(ACMainZonePK)));
		}

		public ACAccessLevelDetailViewCollection GetViewByACMainZone(System.Guid ACMainZonePK)
		{
			return new ACAccessLevelDetailViewCollection(this.GetByACMainZone(ACMainZonePK));
		}

		public virtual ACAccessLevelDetailDataCollection GetByACTimecode(System.Guid ACTimecodePK)
		{
			if (base.IsTrusted)
			{
				return this.Processing(this._dal.GetByACTimecode(ACTimecodePK));
			}

			if (!base.IsAuthorizedSelect)
			{
				return null;
			}

			return this.Processing((ACAccessLevelDetailDataCollection) base.Filter(this._dal.GetByACTimecode(ACTimecodePK)));
		}

		public ACAccessLevelDetailViewCollection GetViewByACTimecode(System.Guid ACTimecodePK)
		{
			return new ACAccessLevelDetailViewCollection(this.GetByACTimecode(ACTimecodePK));
		}

		public virtual ACAccessLevelDetailDataCollection GetByACAccessLevel(System.Guid ACAccessLevelPK)
		{
			if (base.IsTrusted)
			{
				return this.Processing(this._dal.GetByACAccessLevel(ACAccessLevelPK));
			}

			if (!base.IsAuthorizedSelect)
			{
				return null;
			}

			return this.Processing((ACAccessLevelDetailDataCollection) base.Filter(this._dal.GetByACAccessLevel(ACAccessLevelPK)));
		}

		public ACAccessLevelDetailViewCollection GetViewByACAccessLevel(System.Guid ACAccessLevelPK)
		{
			return new ACAccessLevelDetailViewCollection(this.GetByACAccessLevel(ACAccessLevelPK));
		}

		protected virtual ACAccessLevelDetailData Processing(ACAccessLevelDetailData entity)
		{
			return entity;
		}

		protected virtual ACAccessLevelDetailDataCollection Processing(ACAccessLevelDetailDataCollection list)
		{
			ACAccessLevelDetailDataCollection retList = new ACAccessLevelDetailDataCollection();
			foreach(ACAccessLevelDetailData item in list)
			{
				ACAccessLevelDetailData data = this.Processing(item);
				if(data != null)
				{
					retList.Add(data);
				}
			}

			return retList;
		}

		public virtual Result Save(ACAccessLevelDetailData entity)
		{
			return base.Save(entity);
		}

		public virtual void SaveUnderTransaction(ACAccessLevelDetailData entity)
		{
			base.SaveUnderTransaction(entity);
		}

		public virtual Result Save(ACAccessLevelDetailDataCollection list)
		{
			return base.Save(list);
		}

		public virtual void SaveUnderTransaction(ACAccessLevelDetailDataCollection list)
		{
			base.SaveUnderTransaction(list);
		}


	}
	public abstract class UsrAccountBuildingMapDataServiceBase : ServiceBase
	{
		protected UsrAccountBuildingMapCRUD _dal;

		public UsrAccountBuildingMapDataServiceBase(string connectionString, SecurityToken token) : base(connectionString, token)
		{
			this._dal = new UsrAccountBuildingMapCRUD(connectionString);
			for (int i = 0; i < token.GetSortFields().Count; i++)
			{
				SortField field = token.GetSortFields()[i];
				this._dal.AddSortBy(field.FieldAlias, field.ASC);
			}
		}

		protected override string TableName
		{
			get
			{
				return "UsrAccountBuildingMap";
			}
		}


		protected override int DeleteEntity(BusinessBase entity)
		{
			UsrAccountBuildingMapData data = (UsrAccountBuildingMapData) entity;
			if(data == null)
				return 0;

			return this._dal.DeleteByPK( data.UsrAccountBuildingMapPK, data.RowVersion);
		}

		internal int DeleteByBDBuilding(BusinessBase entity)
		{
			BDBuildingData data = (BDBuildingData) entity;
			if(data == null)
				return 0;

			bool isLogDeleteEnabled = ServiceBase._DBLog.IsLogDeleteEnabled;
			bool isLinkDBDeleteEnabled = ServiceBase._DBLink.IsLinkDBDeleteEnabled;
			if (!isLogDeleteEnabled && !isLinkDBDeleteEnabled)
			{
				return this._dal.DeleteByBDBuilding(data. BDBuildingPK);
			}

			DataTable list = this._dal.GetLogByBDBuilding(data. BDBuildingPK);
			list.TableName = this._dal.TableName;
			int ret = this._dal.DeleteByBDBuilding(data. BDBuildingPK);
			if (isLogDeleteEnabled)
			{
				ServiceBase._DBLog.LogDelete(list, base.SecurityToken);
			}

			if (isLinkDBDeleteEnabled)
			{
				ServiceBase._DBLink.LinkDBDelete(list, base.TrustedToken);
			}

			return ret;
		}

		internal int DeleteByUsrAccount(BusinessBase entity)
		{
			UsrAccountData data = (UsrAccountData) entity;
			if(data == null)
				return 0;

			bool isLogDeleteEnabled = ServiceBase._DBLog.IsLogDeleteEnabled;
			bool isLinkDBDeleteEnabled = ServiceBase._DBLink.IsLinkDBDeleteEnabled;
			if (!isLogDeleteEnabled && !isLinkDBDeleteEnabled)
			{
				return this._dal.DeleteByUsrAccount(data. UsrAccountPK);
			}

			DataTable list = this._dal.GetLogByUsrAccount(data. UsrAccountPK);
			list.TableName = this._dal.TableName;
			int ret = this._dal.DeleteByUsrAccount(data. UsrAccountPK);
			if (isLogDeleteEnabled)
			{
				ServiceBase._DBLog.LogDelete(list, base.SecurityToken);
			}

			if (isLinkDBDeleteEnabled)
			{
				ServiceBase._DBLink.LinkDBDelete(list, base.TrustedToken);
			}

			return ret;
		}

		internal int DeleteByBDTenant(BusinessBase entity)
		{
			BDTenantData data = (BDTenantData) entity;
			if(data == null)
				return 0;

			bool isLogDeleteEnabled = ServiceBase._DBLog.IsLogDeleteEnabled;
			bool isLinkDBDeleteEnabled = ServiceBase._DBLink.IsLinkDBDeleteEnabled;
			if (!isLogDeleteEnabled && !isLinkDBDeleteEnabled)
			{
				return this._dal.DeleteByBDTenant(data. BDTenantPK);
			}

			DataTable list = this._dal.GetLogByBDTenant(data. BDTenantPK);
			list.TableName = this._dal.TableName;
			int ret = this._dal.DeleteByBDTenant(data. BDTenantPK);
			if (isLogDeleteEnabled)
			{
				ServiceBase._DBLog.LogDelete(list, base.SecurityToken);
			}

			if (isLinkDBDeleteEnabled)
			{
				ServiceBase._DBLink.LinkDBDelete(list, base.TrustedToken);
			}

			return ret;
		}

		internal int DeleteByUsrGroup(BusinessBase entity)
		{
			UsrGroupData data = (UsrGroupData) entity;
			if(data == null)
				return 0;

			bool isLogDeleteEnabled = ServiceBase._DBLog.IsLogDeleteEnabled;
			bool isLinkDBDeleteEnabled = ServiceBase._DBLink.IsLinkDBDeleteEnabled;
			if (!isLogDeleteEnabled && !isLinkDBDeleteEnabled)
			{
				return this._dal.DeleteByUsrGroup(data. UsrGroupPK);
			}

			DataTable list = this._dal.GetLogByUsrGroup(data. UsrGroupPK);
			list.TableName = this._dal.TableName;
			int ret = this._dal.DeleteByUsrGroup(data. UsrGroupPK);
			if (isLogDeleteEnabled)
			{
				ServiceBase._DBLog.LogDelete(list, base.SecurityToken);
			}

			if (isLinkDBDeleteEnabled)
			{
				ServiceBase._DBLink.LinkDBDelete(list, base.TrustedToken);
			}

			return ret;
		}

		public virtual Result Purge(UsrAccountBuildingMapData entity)
		{
			return base.Purge(entity);
		}

		protected override int PurgeEntity(BusinessBase entity)
		{
			UsrAccountBuildingMapData data = (UsrAccountBuildingMapData) entity;
			if(data == null)
				return 0;

			return this._dal.DeleteByPK( data.UsrAccountBuildingMapPK, data.RowVersion);
		}

		internal int PurgeByBDBuilding(BusinessBase entity)
		{
			BDBuildingData data = (BDBuildingData) entity;
			if(data == null)
				return 0;

			return this._dal.DeleteByBDBuilding(data. BDBuildingPK);
		}

		internal int PurgeByUsrAccount(BusinessBase entity)
		{
			UsrAccountData data = (UsrAccountData) entity;
			if(data == null)
				return 0;

			return this._dal.DeleteByUsrAccount(data. UsrAccountPK);
		}

		internal int PurgeByBDTenant(BusinessBase entity)
		{
			BDTenantData data = (BDTenantData) entity;
			if(data == null)
				return 0;

			return this._dal.DeleteByBDTenant(data. BDTenantPK);
		}

		internal int PurgeByUsrGroup(BusinessBase entity)
		{
			UsrGroupData data = (UsrGroupData) entity;
			if(data == null)
				return 0;

			return this._dal.DeleteByUsrGroup(data. UsrGroupPK);
		}

		protected override int InsertEntity(BusinessBase entity)
		{
			UsrAccountBuildingMapData data = (UsrAccountBuildingMapData) entity;
			if(data == null)
				return 0;

			return this._dal.Insert(data);
		}

		protected override int UpdateEntity(BusinessBase entity)
		{
			UsrAccountBuildingMapData data = (UsrAccountBuildingMapData) entity;
			if(data == null)
				return 0;

			return this._dal.Update(data);
		}

		protected override void UpdateChildren(BusinessBase entity)
		{
			UsrAccountBuildingMapData data = (UsrAccountBuildingMapData) entity;
			if(data == null)
				return;

		}

		internal Result GetRowVersion(UsrAccountBuildingMapDataCollection list)
		{
			return base.GetRowVersion(list);
		}

		protected override Result GetRowVersion(BusinessBase entity)
		{
			UsrAccountBuildingMapData data = (UsrAccountBuildingMapData) entity;
			if(data == null || !data.IsDirty)
				return new Result(true);

			Result result = new Result(true);
			if (entity.IsDeleted)
			{
				result.Add(data.ObjectID, new byte[0]);
				return result;
			}

			if (entity.IsSelfDirty)
			{
				result.Add(data.ObjectID, this._dal.GetRowVersion( data.UsrAccountBuildingMapPK));
			}
			return result;
		}

		public virtual UsrAccountBuildingMapData GetByPK( System.Guid UsrAccountBuildingMapPK)
		{
			if (base.IsTrusted)
			{
				return this.Processing(this._dal.GetByPK( UsrAccountBuildingMapPK));
			}

			if (!base.IsAuthorizedSelect)
			{
				return null;
			}

			return this.Processing((UsrAccountBuildingMapData) base.Filter(this._dal.GetByPK( UsrAccountBuildingMapPK)));
		}

		protected virtual UsrAccountBuildingMapData GetEntity(string sqlWhere, SqlParameter[] paras)
		{
			if (base.IsTrusted)
			{
				return this.Processing(this._dal.GetEntityBy(sqlWhere, paras));
			}

			if (!base.IsAuthorizedSelect)
			{
				return null;
			}

			return this.Processing((UsrAccountBuildingMapData) base.Filter(this._dal.GetEntityBy(sqlWhere, paras)));
		}

		public virtual UsrAccountBuildingMapDataCollection GetAll()
		{
			if (base.IsTrusted)
			{
				return this.Processing(this._dal.GetAll());
			}

			if (!base.IsAuthorizedSelect)
			{
				return new UsrAccountBuildingMapDataCollection();
			}

			return this.Processing((UsrAccountBuildingMapDataCollection) base.Filter(this._dal.GetAll()));
		}

		public UsrAccountBuildingMapViewCollection GetViewAll()
		{
			return new UsrAccountBuildingMapViewCollection(this.GetAll());
		}

		protected virtual UsrAccountBuildingMapDataCollection GetCollection(string sqlWhere, SqlParameter[] paras)
		{
			if (base.IsTrusted)
			{
				return this.Processing(this._dal.GetCollectionBy(sqlWhere, paras));
			}

			if (!base.IsAuthorizedSelect)
			{
				return new UsrAccountBuildingMapDataCollection();
			}

			 return this.Processing((UsrAccountBuildingMapDataCollection) base.Filter(this._dal.GetCollectionBy(sqlWhere, paras)));
		}

		public virtual UsrAccountBuildingMapDataCollection GetByBDBuilding(System.Guid BDBuildingPK)
		{
			if (base.IsTrusted)
			{
				return this.Processing(this._dal.GetByBDBuilding(BDBuildingPK));
			}

			if (!base.IsAuthorizedSelect)
			{
				return null;
			}

			return this.Processing((UsrAccountBuildingMapDataCollection) base.Filter(this._dal.GetByBDBuilding(BDBuildingPK)));
		}

		public UsrAccountBuildingMapViewCollection GetViewByBDBuilding(System.Guid BDBuildingPK)
		{
			return new UsrAccountBuildingMapViewCollection(this.GetByBDBuilding(BDBuildingPK));
		}

		public virtual UsrAccountBuildingMapDataCollection GetByUsrAccount(System.Guid UsrAccountPK)
		{
			if (base.IsTrusted)
			{
				return this.Processing(this._dal.GetByUsrAccount(UsrAccountPK));
			}

			if (!base.IsAuthorizedSelect)
			{
				return null;
			}

			return this.Processing((UsrAccountBuildingMapDataCollection) base.Filter(this._dal.GetByUsrAccount(UsrAccountPK)));
		}

		public UsrAccountBuildingMapViewCollection GetViewByUsrAccount(System.Guid UsrAccountPK)
		{
			return new UsrAccountBuildingMapViewCollection(this.GetByUsrAccount(UsrAccountPK));
		}

		protected virtual UsrAccountBuildingMapData Processing(UsrAccountBuildingMapData entity)
		{
			return entity;
		}

		protected virtual UsrAccountBuildingMapDataCollection Processing(UsrAccountBuildingMapDataCollection list)
		{
			UsrAccountBuildingMapDataCollection retList = new UsrAccountBuildingMapDataCollection();
			foreach(UsrAccountBuildingMapData item in list)
			{
				UsrAccountBuildingMapData data = this.Processing(item);
				if(data != null)
				{
					retList.Add(data);
				}
			}

			return retList;
		}

		public virtual Result Save(UsrAccountBuildingMapData entity)
		{
			return base.Save(entity);
		}

		public virtual void SaveUnderTransaction(UsrAccountBuildingMapData entity)
		{
			base.SaveUnderTransaction(entity);
		}

		public virtual Result Save(UsrAccountBuildingMapDataCollection list)
		{
			return base.Save(list);
		}

		public virtual void SaveUnderTransaction(UsrAccountBuildingMapDataCollection list)
		{
			base.SaveUnderTransaction(list);
		}


	}
	public abstract class BDBuildingDataServiceBase : ServiceBase
	{
		protected BDBuildingCRUD _dal;

		public BDBuildingDataServiceBase(string connectionString, SecurityToken token) : base(connectionString, token)
		{
			this._dal = new BDBuildingCRUD(connectionString);
			for (int i = 0; i < token.GetSortFields().Count; i++)
			{
				SortField field = token.GetSortFields()[i];
				this._dal.AddSortBy(field.FieldAlias, field.ASC);
			}
		}

		protected override string TableName
		{
			get
			{
				return "BDBuilding";
			}
		}

		protected abstract UsrAccountBuildingMapDataServiceBase GetUsrAccountBuildingMapDataServiceBase(SecurityToken token);
		protected abstract ACPanelDataServiceBase GetACPanelDataServiceBase(SecurityToken token);
		protected abstract BDTenantDataServiceBase GetBDTenantDataServiceBase(SecurityToken token);
		protected abstract BDBuildingHolidayMapDataServiceBase GetBDBuildingHolidayMapDataServiceBase(SecurityToken token);
		protected abstract ACIntervalDataServiceBase GetACIntervalDataServiceBase(SecurityToken token);
		protected abstract ACTimecodeDataServiceBase GetACTimecodeDataServiceBase(SecurityToken token);
		protected abstract ACAMFormatDataServiceBase GetACAMFormatDataServiceBase(SecurityToken token);
		protected abstract ACAccessLevelDataServiceBase GetACAccessLevelDataServiceBase(SecurityToken token);
		protected abstract ACCardHolderBuildingMapDataServiceBase GetACCardHolderBuildingMapDataServiceBase(SecurityToken token);

		protected override int DeleteEntity(BusinessBase entity)
		{
			BDBuildingData data = (BDBuildingData) entity;
			if(data == null)
				return 0;

			this.GetUsrAccountBuildingMapDataServiceBase(base.SecurityToken).DeleteByBDBuilding(data);
			this.GetACPanelDataServiceBase(base.SecurityToken).DeleteByBDBuilding(data);
			this.GetBDTenantDataServiceBase(base.SecurityToken).DeleteByBDBuilding(data);
			this.GetBDBuildingHolidayMapDataServiceBase(base.SecurityToken).DeleteByBDBuilding(data);
			this.GetACIntervalDataServiceBase(base.SecurityToken).DeleteByBDBuilding(data);
			this.GetACTimecodeDataServiceBase(base.SecurityToken).DeleteByBDBuilding(data);
			this.GetACAMFormatDataServiceBase(base.SecurityToken).DeleteByBDBuilding(data);
			this.GetACAccessLevelDataServiceBase(base.SecurityToken).DeleteByBDBuilding(data);
			this.GetACCardHolderBuildingMapDataServiceBase(base.SecurityToken).DeleteByBDBuilding(data);
			return this._dal.DeleteByPK( data.BDBuildingPK, data.RowVersion);
		}

		public virtual Result Purge(BDBuildingData entity)
		{
			return base.Purge(entity);
		}

		protected override int PurgeEntity(BusinessBase entity)
		{
			BDBuildingData data = (BDBuildingData) entity;
			if(data == null)
				return 0;

			this.GetUsrAccountBuildingMapDataServiceBase(base.SecurityToken).PurgeByBDBuilding(data);
			this.GetACPanelDataServiceBase(base.SecurityToken).PurgeByBDBuilding(data);
			this.GetBDTenantDataServiceBase(base.SecurityToken).PurgeByBDBuilding(data);
			this.GetBDBuildingHolidayMapDataServiceBase(base.SecurityToken).PurgeByBDBuilding(data);
			this.GetACIntervalDataServiceBase(base.SecurityToken).PurgeByBDBuilding(data);
			this.GetACTimecodeDataServiceBase(base.SecurityToken).PurgeByBDBuilding(data);
			this.GetACAMFormatDataServiceBase(base.SecurityToken).PurgeByBDBuilding(data);
			this.GetACAccessLevelDataServiceBase(base.SecurityToken).PurgeByBDBuilding(data);
			this.GetACCardHolderBuildingMapDataServiceBase(base.SecurityToken).PurgeByBDBuilding(data);
			return this._dal.DeleteByPK( data.BDBuildingPK, data.RowVersion);
		}

		protected override int InsertEntity(BusinessBase entity)
		{
			BDBuildingData data = (BDBuildingData) entity;
			if(data == null)
				return 0;

			return this._dal.Insert(data);
		}

		protected override int UpdateEntity(BusinessBase entity)
		{
			BDBuildingData data = (BDBuildingData) entity;
			if(data == null)
				return 0;

			return this._dal.Update(data);
		}

		protected override void UpdateChildren(BusinessBase entity)
		{
			BDBuildingData data = (BDBuildingData) entity;
			if(data == null)
				return;

			if (data.UsrAccountBuildingMapList != null)
			{
				 this.GetUsrAccountBuildingMapDataServiceBase(base.SecurityToken).SaveUnderTransaction(data.UsrAccountBuildingMapList);
			}
			if (data.ACPanelList != null)
			{
				 this.GetACPanelDataServiceBase(base.SecurityToken).SaveUnderTransaction(data.ACPanelList);
			}
			if (data.BDTenantList != null)
			{
				 this.GetBDTenantDataServiceBase(base.SecurityToken).SaveUnderTransaction(data.BDTenantList);
			}
			if (data.BDBuildingHolidayMapList != null)
			{
				 this.GetBDBuildingHolidayMapDataServiceBase(base.SecurityToken).SaveUnderTransaction(data.BDBuildingHolidayMapList);
			}
			if (data.ACIntervalList != null)
			{
				 this.GetACIntervalDataServiceBase(base.SecurityToken).SaveUnderTransaction(data.ACIntervalList);
			}
			if (data.ACTimecodeList != null)
			{
				 this.GetACTimecodeDataServiceBase(base.SecurityToken).SaveUnderTransaction(data.ACTimecodeList);
			}
			if (data.ACAMFormatList != null)
			{
				 this.GetACAMFormatDataServiceBase(base.SecurityToken).SaveUnderTransaction(data.ACAMFormatList);
			}
			if (data.ACAccessLevelList != null)
			{
				 this.GetACAccessLevelDataServiceBase(base.SecurityToken).SaveUnderTransaction(data.ACAccessLevelList);
			}
			if (data.ACCardHolderBuildingMapList != null)
			{
				 this.GetACCardHolderBuildingMapDataServiceBase(base.SecurityToken).SaveUnderTransaction(data.ACCardHolderBuildingMapList);
			}
		}

		internal Result GetRowVersion(BDBuildingDataCollection list)
		{
			return base.GetRowVersion(list);
		}

		protected override Result GetRowVersion(BusinessBase entity)
		{
			BDBuildingData data = (BDBuildingData) entity;
			if(data == null || !data.IsDirty)
				return new Result(true);

			Result result = new Result(true);
			if (entity.IsDeleted)
			{
				result.Add(data.ObjectID, new byte[0]);
				return result;
			}

			if (entity.IsSelfDirty)
			{
				result.Add(data.ObjectID, this._dal.GetRowVersion( data.BDBuildingPK));
			}
			if (data.UsrAccountBuildingMapList != null && data.UsrAccountBuildingMapList.Count > 0)
			{
				result.Add(this.GetUsrAccountBuildingMapDataServiceBase(base.SecurityToken).GetRowVersion(data.UsrAccountBuildingMapList));
			}
			if (data.ACPanelList != null && data.ACPanelList.Count > 0)
			{
				result.Add(this.GetACPanelDataServiceBase(base.SecurityToken).GetRowVersion(data.ACPanelList));
			}
			if (data.BDTenantList != null && data.BDTenantList.Count > 0)
			{
				result.Add(this.GetBDTenantDataServiceBase(base.SecurityToken).GetRowVersion(data.BDTenantList));
			}
			if (data.BDBuildingHolidayMapList != null && data.BDBuildingHolidayMapList.Count > 0)
			{
				result.Add(this.GetBDBuildingHolidayMapDataServiceBase(base.SecurityToken).GetRowVersion(data.BDBuildingHolidayMapList));
			}
			if (data.ACIntervalList != null && data.ACIntervalList.Count > 0)
			{
				result.Add(this.GetACIntervalDataServiceBase(base.SecurityToken).GetRowVersion(data.ACIntervalList));
			}
			if (data.ACTimecodeList != null && data.ACTimecodeList.Count > 0)
			{
				result.Add(this.GetACTimecodeDataServiceBase(base.SecurityToken).GetRowVersion(data.ACTimecodeList));
			}
			if (data.ACAMFormatList != null && data.ACAMFormatList.Count > 0)
			{
				result.Add(this.GetACAMFormatDataServiceBase(base.SecurityToken).GetRowVersion(data.ACAMFormatList));
			}
			if (data.ACAccessLevelList != null && data.ACAccessLevelList.Count > 0)
			{
				result.Add(this.GetACAccessLevelDataServiceBase(base.SecurityToken).GetRowVersion(data.ACAccessLevelList));
			}
			if (data.ACCardHolderBuildingMapList != null && data.ACCardHolderBuildingMapList.Count > 0)
			{
				result.Add(this.GetACCardHolderBuildingMapDataServiceBase(base.SecurityToken).GetRowVersion(data.ACCardHolderBuildingMapList));
			}
			return result;
		}

		public virtual BDBuildingData GetByPK( System.Guid BDBuildingPK)
		{
			if (base.IsTrusted)
			{
				return this.Processing(this._dal.GetByPK( BDBuildingPK));
			}

			if (!base.IsAuthorizedSelect)
			{
				return null;
			}

			return this.Processing((BDBuildingData) base.Filter(this._dal.GetByPK( BDBuildingPK)));
		}

		protected virtual BDBuildingData GetEntity(string sqlWhere, SqlParameter[] paras)
		{
			if (base.IsTrusted)
			{
				return this.Processing(this._dal.GetEntityBy(sqlWhere, paras));
			}

			if (!base.IsAuthorizedSelect)
			{
				return null;
			}

			return this.Processing((BDBuildingData) base.Filter(this._dal.GetEntityBy(sqlWhere, paras)));
		}

		public virtual BDBuildingDataCollection GetAll()
		{
			if (base.IsTrusted)
			{
				return this.Processing(this._dal.GetAll());
			}

			if (!base.IsAuthorizedSelect)
			{
				return new BDBuildingDataCollection();
			}

			return this.Processing((BDBuildingDataCollection) base.Filter(this._dal.GetAll()));
		}

		public BDBuildingViewCollection GetViewAll()
		{
			return new BDBuildingViewCollection(this.GetAll());
		}

		protected virtual BDBuildingDataCollection GetCollection(string sqlWhere, SqlParameter[] paras)
		{
			if (base.IsTrusted)
			{
				return this.Processing(this._dal.GetCollectionBy(sqlWhere, paras));
			}

			if (!base.IsAuthorizedSelect)
			{
				return new BDBuildingDataCollection();
			}

			 return this.Processing((BDBuildingDataCollection) base.Filter(this._dal.GetCollectionBy(sqlWhere, paras)));
		}

		protected virtual BDBuildingData Processing(BDBuildingData entity)
		{
			return entity;
		}

		protected virtual BDBuildingDataCollection Processing(BDBuildingDataCollection list)
		{
			BDBuildingDataCollection retList = new BDBuildingDataCollection();
			foreach(BDBuildingData item in list)
			{
				BDBuildingData data = this.Processing(item);
				if(data != null)
				{
					retList.Add(data);
				}
			}

			return retList;
		}

		public virtual Result Save(BDBuildingData entity)
		{
			return base.Save(entity);
		}

		public virtual void SaveUnderTransaction(BDBuildingData entity)
		{
			base.SaveUnderTransaction(entity);
		}

		public virtual Result Save(BDBuildingDataCollection list)
		{
			return base.Save(list);
		}

		public virtual void SaveUnderTransaction(BDBuildingDataCollection list)
		{
			base.SaveUnderTransaction(list);
		}


	}
	public abstract class BDTenantDataServiceBase : ServiceBase
	{
		protected BDTenantCRUD _dal;

		public BDTenantDataServiceBase(string connectionString, SecurityToken token) : base(connectionString, token)
		{
			this._dal = new BDTenantCRUD(connectionString);
			for (int i = 0; i < token.GetSortFields().Count; i++)
			{
				SortField field = token.GetSortFields()[i];
				this._dal.AddSortBy(field.FieldAlias, field.ASC);
			}
		}

		protected override string TableName
		{
			get
			{
				return "BDTenant";
			}
		}

		protected abstract UsrAccountTenantMapDataServiceBase GetUsrAccountTenantMapDataServiceBase(SecurityToken token);
		protected abstract UsrAccountDataServiceBase GetUsrAccountDataServiceBase(SecurityToken token);
		protected abstract ACFunctionCardDataServiceBase GetACFunctionCardDataServiceBase(SecurityToken token);
		protected abstract BDTenantHolidayMapDataServiceBase GetBDTenantHolidayMapDataServiceBase(SecurityToken token);
		protected abstract ACCardHolderDataServiceBase GetACCardHolderDataServiceBase(SecurityToken token);
		protected abstract BDVisitorDataServiceBase GetBDVisitorDataServiceBase(SecurityToken token);

		protected override int DeleteEntity(BusinessBase entity)
		{
			BDTenantData data = (BDTenantData) entity;
			if(data == null)
				return 0;

			this.GetUsrAccountTenantMapDataServiceBase(base.SecurityToken).DeleteByBDTenant(data);
			this.GetUsrAccountDataServiceBase(base.SecurityToken).DeleteByBDTenant(data);
			this.GetACFunctionCardDataServiceBase(base.SecurityToken).DeleteByBDTenant(data);
			this.GetBDTenantHolidayMapDataServiceBase(base.SecurityToken).DeleteByBDTenant(data);
			this.GetACCardHolderDataServiceBase(base.SecurityToken).DeleteByBDTenant(data);
			this.GetBDVisitorDataServiceBase(base.SecurityToken).DeleteByBDTenant(data);
			return this._dal.DeleteByPK( data.BDTenantPK, data.RowVersion);
		}

		internal int DeleteByBDBuilding(BusinessBase entity)
		{
			BDBuildingData data = (BDBuildingData) entity;
			if(data == null)
				return 0;

			this.GetUsrAccountTenantMapDataServiceBase(base.SecurityToken).DeleteByBDBuilding(entity);
			this.GetUsrAccountDataServiceBase(base.SecurityToken).DeleteByBDBuilding(entity);
			this.GetACFunctionCardDataServiceBase(base.SecurityToken).DeleteByBDBuilding(entity);
			this.GetBDTenantHolidayMapDataServiceBase(base.SecurityToken).DeleteByBDBuilding(entity);
			this.GetACCardHolderDataServiceBase(base.SecurityToken).DeleteByBDBuilding(entity);
			this.GetBDVisitorDataServiceBase(base.SecurityToken).DeleteByBDBuilding(entity);
			bool isLogDeleteEnabled = ServiceBase._DBLog.IsLogDeleteEnabled;
			bool isLinkDBDeleteEnabled = ServiceBase._DBLink.IsLinkDBDeleteEnabled;
			if (!isLogDeleteEnabled && !isLinkDBDeleteEnabled)
			{
				return this._dal.DeleteByBDBuilding(data. BDBuildingPK);
			}

			DataTable list = this._dal.GetLogByBDBuilding(data. BDBuildingPK);
			list.TableName = this._dal.TableName;
			int ret = this._dal.DeleteByBDBuilding(data. BDBuildingPK);
			if (isLogDeleteEnabled)
			{
				ServiceBase._DBLog.LogDelete(list, base.SecurityToken);
			}

			if (isLinkDBDeleteEnabled)
			{
				ServiceBase._DBLink.LinkDBDelete(list, base.TrustedToken);
			}

			return ret;
		}

		public virtual Result Purge(BDTenantData entity)
		{
			return base.Purge(entity);
		}

		protected override int PurgeEntity(BusinessBase entity)
		{
			BDTenantData data = (BDTenantData) entity;
			if(data == null)
				return 0;

			this.GetUsrAccountTenantMapDataServiceBase(base.SecurityToken).PurgeByBDTenant(data);
			this.GetUsrAccountDataServiceBase(base.SecurityToken).PurgeByBDTenant(data);
			this.GetACFunctionCardDataServiceBase(base.SecurityToken).PurgeByBDTenant(data);
			this.GetBDTenantHolidayMapDataServiceBase(base.SecurityToken).PurgeByBDTenant(data);
			this.GetACCardHolderDataServiceBase(base.SecurityToken).PurgeByBDTenant(data);
			this.GetBDVisitorDataServiceBase(base.SecurityToken).PurgeByBDTenant(data);
			return this._dal.DeleteByPK( data.BDTenantPK, data.RowVersion);
		}

		internal int PurgeByBDBuilding(BusinessBase entity)
		{
			BDBuildingData data = (BDBuildingData) entity;
			if(data == null)
				return 0;

			this.GetUsrAccountTenantMapDataServiceBase(base.SecurityToken).PurgeByBDBuilding(entity);
			this.GetUsrAccountDataServiceBase(base.SecurityToken).PurgeByBDBuilding(entity);
			this.GetACFunctionCardDataServiceBase(base.SecurityToken).PurgeByBDBuilding(entity);
			this.GetBDTenantHolidayMapDataServiceBase(base.SecurityToken).PurgeByBDBuilding(entity);
			this.GetACCardHolderDataServiceBase(base.SecurityToken).PurgeByBDBuilding(entity);
			this.GetBDVisitorDataServiceBase(base.SecurityToken).PurgeByBDBuilding(entity);
			return this._dal.DeleteByBDBuilding(data. BDBuildingPK);
		}

		protected override int InsertEntity(BusinessBase entity)
		{
			BDTenantData data = (BDTenantData) entity;
			if(data == null)
				return 0;

			return this._dal.Insert(data);
		}

		protected override int UpdateEntity(BusinessBase entity)
		{
			BDTenantData data = (BDTenantData) entity;
			if(data == null)
				return 0;

			return this._dal.Update(data);
		}

		protected override void UpdateChildren(BusinessBase entity)
		{
			BDTenantData data = (BDTenantData) entity;
			if(data == null)
				return;

			if (data.UsrAccountTenantMapList != null)
			{
				 this.GetUsrAccountTenantMapDataServiceBase(base.SecurityToken).SaveUnderTransaction(data.UsrAccountTenantMapList);
			}
			if (data.UsrAccountList != null)
			{
				 this.GetUsrAccountDataServiceBase(base.SecurityToken).SaveUnderTransaction(data.UsrAccountList);
			}
			if (data.ACFunctionCardList != null)
			{
				 this.GetACFunctionCardDataServiceBase(base.SecurityToken).SaveUnderTransaction(data.ACFunctionCardList);
			}
			if (data.BDTenantHolidayMapList != null)
			{
				 this.GetBDTenantHolidayMapDataServiceBase(base.SecurityToken).SaveUnderTransaction(data.BDTenantHolidayMapList);
			}
			if (data.ACCardHolderList != null)
			{
				 this.GetACCardHolderDataServiceBase(base.SecurityToken).SaveUnderTransaction(data.ACCardHolderList);
			}
			if (data.BDVisitorList != null)
			{
				 this.GetBDVisitorDataServiceBase(base.SecurityToken).SaveUnderTransaction(data.BDVisitorList);
			}
		}

		internal Result GetRowVersion(BDTenantDataCollection list)
		{
			return base.GetRowVersion(list);
		}

		protected override Result GetRowVersion(BusinessBase entity)
		{
			BDTenantData data = (BDTenantData) entity;
			if(data == null || !data.IsDirty)
				return new Result(true);

			Result result = new Result(true);
			if (entity.IsDeleted)
			{
				result.Add(data.ObjectID, new byte[0]);
				return result;
			}

			if (entity.IsSelfDirty)
			{
				result.Add(data.ObjectID, this._dal.GetRowVersion( data.BDTenantPK));
			}
			if (data.UsrAccountTenantMapList != null && data.UsrAccountTenantMapList.Count > 0)
			{
				result.Add(this.GetUsrAccountTenantMapDataServiceBase(base.SecurityToken).GetRowVersion(data.UsrAccountTenantMapList));
			}
			if (data.UsrAccountList != null && data.UsrAccountList.Count > 0)
			{
				result.Add(this.GetUsrAccountDataServiceBase(base.SecurityToken).GetRowVersion(data.UsrAccountList));
			}
			if (data.ACFunctionCardList != null && data.ACFunctionCardList.Count > 0)
			{
				result.Add(this.GetACFunctionCardDataServiceBase(base.SecurityToken).GetRowVersion(data.ACFunctionCardList));
			}
			if (data.BDTenantHolidayMapList != null && data.BDTenantHolidayMapList.Count > 0)
			{
				result.Add(this.GetBDTenantHolidayMapDataServiceBase(base.SecurityToken).GetRowVersion(data.BDTenantHolidayMapList));
			}
			if (data.ACCardHolderList != null && data.ACCardHolderList.Count > 0)
			{
				result.Add(this.GetACCardHolderDataServiceBase(base.SecurityToken).GetRowVersion(data.ACCardHolderList));
			}
			if (data.BDVisitorList != null && data.BDVisitorList.Count > 0)
			{
				result.Add(this.GetBDVisitorDataServiceBase(base.SecurityToken).GetRowVersion(data.BDVisitorList));
			}
			return result;
		}

		public virtual BDTenantData GetByPK( System.Guid BDTenantPK)
		{
			if (base.IsTrusted)
			{
				return this.Processing(this._dal.GetByPK( BDTenantPK));
			}

			if (!base.IsAuthorizedSelect)
			{
				return null;
			}

			return this.Processing((BDTenantData) base.Filter(this._dal.GetByPK( BDTenantPK)));
		}

		protected virtual BDTenantData GetEntity(string sqlWhere, SqlParameter[] paras)
		{
			if (base.IsTrusted)
			{
				return this.Processing(this._dal.GetEntityBy(sqlWhere, paras));
			}

			if (!base.IsAuthorizedSelect)
			{
				return null;
			}

			return this.Processing((BDTenantData) base.Filter(this._dal.GetEntityBy(sqlWhere, paras)));
		}

		public virtual BDTenantDataCollection GetAll()
		{
			if (base.IsTrusted)
			{
				return this.Processing(this._dal.GetAll());
			}

			if (!base.IsAuthorizedSelect)
			{
				return new BDTenantDataCollection();
			}

			return this.Processing((BDTenantDataCollection) base.Filter(this._dal.GetAll()));
		}

		public BDTenantViewCollection GetViewAll()
		{
			return new BDTenantViewCollection(this.GetAll());
		}

		protected virtual BDTenantDataCollection GetCollection(string sqlWhere, SqlParameter[] paras)
		{
			if (base.IsTrusted)
			{
				return this.Processing(this._dal.GetCollectionBy(sqlWhere, paras));
			}

			if (!base.IsAuthorizedSelect)
			{
				return new BDTenantDataCollection();
			}

			 return this.Processing((BDTenantDataCollection) base.Filter(this._dal.GetCollectionBy(sqlWhere, paras)));
		}

		public virtual BDTenantDataCollection GetByBDBuilding(System.Guid BDBuildingPK)
		{
			if (base.IsTrusted)
			{
				return this.Processing(this._dal.GetByBDBuilding(BDBuildingPK));
			}

			if (!base.IsAuthorizedSelect)
			{
				return null;
			}

			return this.Processing((BDTenantDataCollection) base.Filter(this._dal.GetByBDBuilding(BDBuildingPK)));
		}

		public BDTenantViewCollection GetViewByBDBuilding(System.Guid BDBuildingPK)
		{
			return new BDTenantViewCollection(this.GetByBDBuilding(BDBuildingPK));
		}

		protected virtual BDTenantData Processing(BDTenantData entity)
		{
			return entity;
		}

		protected virtual BDTenantDataCollection Processing(BDTenantDataCollection list)
		{
			BDTenantDataCollection retList = new BDTenantDataCollection();
			foreach(BDTenantData item in list)
			{
				BDTenantData data = this.Processing(item);
				if(data != null)
				{
					retList.Add(data);
				}
			}

			return retList;
		}

		public virtual Result Save(BDTenantData entity)
		{
			return base.Save(entity);
		}

		public virtual void SaveUnderTransaction(BDTenantData entity)
		{
			base.SaveUnderTransaction(entity);
		}

		public virtual Result Save(BDTenantDataCollection list)
		{
			return base.Save(list);
		}

		public virtual void SaveUnderTransaction(BDTenantDataCollection list)
		{
			base.SaveUnderTransaction(list);
		}


	}
	public abstract class UtilSettingCategoryDataServiceBase : ServiceBase
	{
		protected UtilSettingCategoryCRUD _dal;

		public UtilSettingCategoryDataServiceBase(string connectionString, SecurityToken token) : base(connectionString, token)
		{
			this._dal = new UtilSettingCategoryCRUD(connectionString);
			for (int i = 0; i < token.GetSortFields().Count; i++)
			{
				SortField field = token.GetSortFields()[i];
				this._dal.AddSortBy(field.FieldAlias, field.ASC);
			}
		}

		protected override string TableName
		{
			get
			{
				return "UtilSettingCategory";
			}
		}

		protected abstract UtilSettingDetailDataServiceBase GetUtilSettingDetailDataServiceBase(SecurityToken token);

		protected override int DeleteEntity(BusinessBase entity)
		{
			UtilSettingCategoryData data = (UtilSettingCategoryData) entity;
			if(data == null)
				return 0;

			this.GetUtilSettingDetailDataServiceBase(base.SecurityToken).DeleteByUtilSettingCategory(data);
			return this._dal.DeleteByPK( data.UtilSettingCategoryPK, data.RowVersion);
		}

		public virtual Result Purge(UtilSettingCategoryData entity)
		{
			return base.Purge(entity);
		}

		protected override int PurgeEntity(BusinessBase entity)
		{
			UtilSettingCategoryData data = (UtilSettingCategoryData) entity;
			if(data == null)
				return 0;

			this.GetUtilSettingDetailDataServiceBase(base.SecurityToken).PurgeByUtilSettingCategory(data);
			return this._dal.DeleteByPK( data.UtilSettingCategoryPK, data.RowVersion);
		}

		protected override int InsertEntity(BusinessBase entity)
		{
			UtilSettingCategoryData data = (UtilSettingCategoryData) entity;
			if(data == null)
				return 0;

			return this._dal.Insert(data);
		}

		protected override int UpdateEntity(BusinessBase entity)
		{
			UtilSettingCategoryData data = (UtilSettingCategoryData) entity;
			if(data == null)
				return 0;

			return this._dal.Update(data);
		}

		protected override void UpdateChildren(BusinessBase entity)
		{
			UtilSettingCategoryData data = (UtilSettingCategoryData) entity;
			if(data == null)
				return;

			if (data.UtilSettingDetailList != null)
			{
				 this.GetUtilSettingDetailDataServiceBase(base.SecurityToken).SaveUnderTransaction(data.UtilSettingDetailList);
			}
		}

		internal Result GetRowVersion(UtilSettingCategoryDataCollection list)
		{
			return base.GetRowVersion(list);
		}

		protected override Result GetRowVersion(BusinessBase entity)
		{
			UtilSettingCategoryData data = (UtilSettingCategoryData) entity;
			if(data == null || !data.IsDirty)
				return new Result(true);

			Result result = new Result(true);
			if (entity.IsDeleted)
			{
				result.Add(data.ObjectID, new byte[0]);
				return result;
			}

			if (entity.IsSelfDirty)
			{
				result.Add(data.ObjectID, this._dal.GetRowVersion( data.UtilSettingCategoryPK));
			}
			if (data.UtilSettingDetailList != null && data.UtilSettingDetailList.Count > 0)
			{
				result.Add(this.GetUtilSettingDetailDataServiceBase(base.SecurityToken).GetRowVersion(data.UtilSettingDetailList));
			}
			return result;
		}

		public virtual UtilSettingCategoryData GetByPK( System.Guid UtilSettingCategoryPK)
		{
			if (base.IsTrusted)
			{
				return this.Processing(this._dal.GetByPK( UtilSettingCategoryPK));
			}

			if (!base.IsAuthorizedSelect)
			{
				return null;
			}

			return this.Processing((UtilSettingCategoryData) base.Filter(this._dal.GetByPK( UtilSettingCategoryPK)));
		}

		protected virtual UtilSettingCategoryData GetEntity(string sqlWhere, SqlParameter[] paras)
		{
			if (base.IsTrusted)
			{
				return this.Processing(this._dal.GetEntityBy(sqlWhere, paras));
			}

			if (!base.IsAuthorizedSelect)
			{
				return null;
			}

			return this.Processing((UtilSettingCategoryData) base.Filter(this._dal.GetEntityBy(sqlWhere, paras)));
		}

		public virtual UtilSettingCategoryDataCollection GetAll()
		{
			if (base.IsTrusted)
			{
				return this.Processing(this._dal.GetAll());
			}

			if (!base.IsAuthorizedSelect)
			{
				return new UtilSettingCategoryDataCollection();
			}

			return this.Processing((UtilSettingCategoryDataCollection) base.Filter(this._dal.GetAll()));
		}

		public UtilSettingCategoryViewCollection GetViewAll()
		{
			return new UtilSettingCategoryViewCollection(this.GetAll());
		}

		protected virtual UtilSettingCategoryDataCollection GetCollection(string sqlWhere, SqlParameter[] paras)
		{
			if (base.IsTrusted)
			{
				return this.Processing(this._dal.GetCollectionBy(sqlWhere, paras));
			}

			if (!base.IsAuthorizedSelect)
			{
				return new UtilSettingCategoryDataCollection();
			}

			 return this.Processing((UtilSettingCategoryDataCollection) base.Filter(this._dal.GetCollectionBy(sqlWhere, paras)));
		}

		protected virtual UtilSettingCategoryData Processing(UtilSettingCategoryData entity)
		{
			return entity;
		}

		protected virtual UtilSettingCategoryDataCollection Processing(UtilSettingCategoryDataCollection list)
		{
			UtilSettingCategoryDataCollection retList = new UtilSettingCategoryDataCollection();
			foreach(UtilSettingCategoryData item in list)
			{
				UtilSettingCategoryData data = this.Processing(item);
				if(data != null)
				{
					retList.Add(data);
				}
			}

			return retList;
		}

		public virtual Result Save(UtilSettingCategoryData entity)
		{
			return base.Save(entity);
		}

		public virtual void SaveUnderTransaction(UtilSettingCategoryData entity)
		{
			base.SaveUnderTransaction(entity);
		}

		public virtual Result Save(UtilSettingCategoryDataCollection list)
		{
			return base.Save(list);
		}

		public virtual void SaveUnderTransaction(UtilSettingCategoryDataCollection list)
		{
			base.SaveUnderTransaction(list);
		}


	}
	public abstract class UtilSettingDetailDataServiceBase : ServiceBase
	{
		protected UtilSettingDetailCRUD _dal;

		public UtilSettingDetailDataServiceBase(string connectionString, SecurityToken token) : base(connectionString, token)
		{
			this._dal = new UtilSettingDetailCRUD(connectionString);
			for (int i = 0; i < token.GetSortFields().Count; i++)
			{
				SortField field = token.GetSortFields()[i];
				this._dal.AddSortBy(field.FieldAlias, field.ASC);
			}
		}

		protected override string TableName
		{
			get
			{
				return "UtilSettingDetail";
			}
		}


		protected override int DeleteEntity(BusinessBase entity)
		{
			UtilSettingDetailData data = (UtilSettingDetailData) entity;
			if(data == null)
				return 0;

			return this._dal.DeleteByPK( data.UtilSettingDetailPK, data.RowVersion);
		}

		internal int DeleteByUtilSettingCategory(BusinessBase entity)
		{
			UtilSettingCategoryData data = (UtilSettingCategoryData) entity;
			if(data == null)
				return 0;

			bool isLogDeleteEnabled = ServiceBase._DBLog.IsLogDeleteEnabled;
			bool isLinkDBDeleteEnabled = ServiceBase._DBLink.IsLinkDBDeleteEnabled;
			if (!isLogDeleteEnabled && !isLinkDBDeleteEnabled)
			{
				return this._dal.DeleteByUtilSettingCategory(data. UtilSettingCategoryPK);
			}

			DataTable list = this._dal.GetLogByUtilSettingCategory(data. UtilSettingCategoryPK);
			list.TableName = this._dal.TableName;
			int ret = this._dal.DeleteByUtilSettingCategory(data. UtilSettingCategoryPK);
			if (isLogDeleteEnabled)
			{
				ServiceBase._DBLog.LogDelete(list, base.SecurityToken);
			}

			if (isLinkDBDeleteEnabled)
			{
				ServiceBase._DBLink.LinkDBDelete(list, base.TrustedToken);
			}

			return ret;
		}

		public virtual Result Purge(UtilSettingDetailData entity)
		{
			return base.Purge(entity);
		}

		protected override int PurgeEntity(BusinessBase entity)
		{
			UtilSettingDetailData data = (UtilSettingDetailData) entity;
			if(data == null)
				return 0;

			return this._dal.DeleteByPK( data.UtilSettingDetailPK, data.RowVersion);
		}

		internal int PurgeByUtilSettingCategory(BusinessBase entity)
		{
			UtilSettingCategoryData data = (UtilSettingCategoryData) entity;
			if(data == null)
				return 0;

			return this._dal.DeleteByUtilSettingCategory(data. UtilSettingCategoryPK);
		}

		protected override int InsertEntity(BusinessBase entity)
		{
			UtilSettingDetailData data = (UtilSettingDetailData) entity;
			if(data == null)
				return 0;

			return this._dal.Insert(data);
		}

		protected override int UpdateEntity(BusinessBase entity)
		{
			UtilSettingDetailData data = (UtilSettingDetailData) entity;
			if(data == null)
				return 0;

			return this._dal.Update(data);
		}

		protected override void UpdateChildren(BusinessBase entity)
		{
			UtilSettingDetailData data = (UtilSettingDetailData) entity;
			if(data == null)
				return;

		}

		internal Result GetRowVersion(UtilSettingDetailDataCollection list)
		{
			return base.GetRowVersion(list);
		}

		protected override Result GetRowVersion(BusinessBase entity)
		{
			UtilSettingDetailData data = (UtilSettingDetailData) entity;
			if(data == null || !data.IsDirty)
				return new Result(true);

			Result result = new Result(true);
			if (entity.IsDeleted)
			{
				result.Add(data.ObjectID, new byte[0]);
				return result;
			}

			if (entity.IsSelfDirty)
			{
				result.Add(data.ObjectID, this._dal.GetRowVersion( data.UtilSettingDetailPK));
			}
			return result;
		}

		public virtual UtilSettingDetailData GetByPK( System.Guid UtilSettingDetailPK)
		{
			if (base.IsTrusted)
			{
				return this.Processing(this._dal.GetByPK( UtilSettingDetailPK));
			}

			if (!base.IsAuthorizedSelect)
			{
				return null;
			}

			return this.Processing((UtilSettingDetailData) base.Filter(this._dal.GetByPK( UtilSettingDetailPK)));
		}

		protected virtual UtilSettingDetailData GetEntity(string sqlWhere, SqlParameter[] paras)
		{
			if (base.IsTrusted)
			{
				return this.Processing(this._dal.GetEntityBy(sqlWhere, paras));
			}

			if (!base.IsAuthorizedSelect)
			{
				return null;
			}

			return this.Processing((UtilSettingDetailData) base.Filter(this._dal.GetEntityBy(sqlWhere, paras)));
		}

		public virtual UtilSettingDetailDataCollection GetAll()
		{
			if (base.IsTrusted)
			{
				return this.Processing(this._dal.GetAll());
			}

			if (!base.IsAuthorizedSelect)
			{
				return new UtilSettingDetailDataCollection();
			}

			return this.Processing((UtilSettingDetailDataCollection) base.Filter(this._dal.GetAll()));
		}

		public UtilSettingDetailViewCollection GetViewAll()
		{
			return new UtilSettingDetailViewCollection(this.GetAll());
		}

		protected virtual UtilSettingDetailDataCollection GetCollection(string sqlWhere, SqlParameter[] paras)
		{
			if (base.IsTrusted)
			{
				return this.Processing(this._dal.GetCollectionBy(sqlWhere, paras));
			}

			if (!base.IsAuthorizedSelect)
			{
				return new UtilSettingDetailDataCollection();
			}

			 return this.Processing((UtilSettingDetailDataCollection) base.Filter(this._dal.GetCollectionBy(sqlWhere, paras)));
		}

		public virtual UtilSettingDetailDataCollection GetByUtilSettingCategory(System.Guid UtilSettingCategoryPK)
		{
			if (base.IsTrusted)
			{
				return this.Processing(this._dal.GetByUtilSettingCategory(UtilSettingCategoryPK));
			}

			if (!base.IsAuthorizedSelect)
			{
				return null;
			}

			return this.Processing((UtilSettingDetailDataCollection) base.Filter(this._dal.GetByUtilSettingCategory(UtilSettingCategoryPK)));
		}

		public UtilSettingDetailViewCollection GetViewByUtilSettingCategory(System.Guid UtilSettingCategoryPK)
		{
			return new UtilSettingDetailViewCollection(this.GetByUtilSettingCategory(UtilSettingCategoryPK));
		}

		protected virtual UtilSettingDetailData Processing(UtilSettingDetailData entity)
		{
			return entity;
		}

		protected virtual UtilSettingDetailDataCollection Processing(UtilSettingDetailDataCollection list)
		{
			UtilSettingDetailDataCollection retList = new UtilSettingDetailDataCollection();
			foreach(UtilSettingDetailData item in list)
			{
				UtilSettingDetailData data = this.Processing(item);
				if(data != null)
				{
					retList.Add(data);
				}
			}

			return retList;
		}

		public virtual Result Save(UtilSettingDetailData entity)
		{
			return base.Save(entity);
		}

		public virtual void SaveUnderTransaction(UtilSettingDetailData entity)
		{
			base.SaveUnderTransaction(entity);
		}

		public virtual Result Save(UtilSettingDetailDataCollection list)
		{
			return base.Save(list);
		}

		public virtual void SaveUnderTransaction(UtilSettingDetailDataCollection list)
		{
			base.SaveUnderTransaction(list);
		}


	}
	public abstract class ACOutputGroupMainZoneMapDataServiceBase : ServiceBase
	{
		protected ACOutputGroupMainZoneMapCRUD _dal;

		public ACOutputGroupMainZoneMapDataServiceBase(string connectionString, SecurityToken token) : base(connectionString, token)
		{
			this._dal = new ACOutputGroupMainZoneMapCRUD(connectionString);
			for (int i = 0; i < token.GetSortFields().Count; i++)
			{
				SortField field = token.GetSortFields()[i];
				this._dal.AddSortBy(field.FieldAlias, field.ASC);
			}
		}

		protected override string TableName
		{
			get
			{
				return "ACOutputGroupMainZoneMap";
			}
		}


		protected override int DeleteEntity(BusinessBase entity)
		{
			ACOutputGroupMainZoneMapData data = (ACOutputGroupMainZoneMapData) entity;
			if(data == null)
				return 0;

			return this._dal.DeleteByPK( data.ACOutputGroupMainZoneMapPK, data.RowVersion);
		}

		internal int DeleteByACMainZone(BusinessBase entity)
		{
			ACMainZoneData data = (ACMainZoneData) entity;
			if(data == null)
				return 0;

			bool isLogDeleteEnabled = ServiceBase._DBLog.IsLogDeleteEnabled;
			bool isLinkDBDeleteEnabled = ServiceBase._DBLink.IsLinkDBDeleteEnabled;
			if (!isLogDeleteEnabled && !isLinkDBDeleteEnabled)
			{
				return this._dal.DeleteByACMainZone(data. ACMainZonePK);
			}

			DataTable list = this._dal.GetLogByACMainZone(data. ACMainZonePK);
			list.TableName = this._dal.TableName;
			int ret = this._dal.DeleteByACMainZone(data. ACMainZonePK);
			if (isLogDeleteEnabled)
			{
				ServiceBase._DBLog.LogDelete(list, base.SecurityToken);
			}

			if (isLinkDBDeleteEnabled)
			{
				ServiceBase._DBLink.LinkDBDelete(list, base.TrustedToken);
			}

			return ret;
		}

		internal int DeleteByACPanel(BusinessBase entity)
		{
			ACPanelData data = (ACPanelData) entity;
			if(data == null)
				return 0;

			bool isLogDeleteEnabled = ServiceBase._DBLog.IsLogDeleteEnabled;
			bool isLinkDBDeleteEnabled = ServiceBase._DBLink.IsLinkDBDeleteEnabled;
			if (!isLogDeleteEnabled && !isLinkDBDeleteEnabled)
			{
				return this._dal.DeleteByACPanel(data. ACPanelPK);
			}

			DataTable list = this._dal.GetLogByACPanel(data. ACPanelPK);
			list.TableName = this._dal.TableName;
			int ret = this._dal.DeleteByACPanel(data. ACPanelPK);
			if (isLogDeleteEnabled)
			{
				ServiceBase._DBLog.LogDelete(list, base.SecurityToken);
			}

			if (isLinkDBDeleteEnabled)
			{
				ServiceBase._DBLink.LinkDBDelete(list, base.TrustedToken);
			}

			return ret;
		}

		internal int DeleteByBDBuilding(BusinessBase entity)
		{
			BDBuildingData data = (BDBuildingData) entity;
			if(data == null)
				return 0;

			bool isLogDeleteEnabled = ServiceBase._DBLog.IsLogDeleteEnabled;
			bool isLinkDBDeleteEnabled = ServiceBase._DBLink.IsLinkDBDeleteEnabled;
			if (!isLogDeleteEnabled && !isLinkDBDeleteEnabled)
			{
				return this._dal.DeleteByBDBuilding(data. BDBuildingPK);
			}

			DataTable list = this._dal.GetLogByBDBuilding(data. BDBuildingPK);
			list.TableName = this._dal.TableName;
			int ret = this._dal.DeleteByBDBuilding(data. BDBuildingPK);
			if (isLogDeleteEnabled)
			{
				ServiceBase._DBLog.LogDelete(list, base.SecurityToken);
			}

			if (isLinkDBDeleteEnabled)
			{
				ServiceBase._DBLink.LinkDBDelete(list, base.TrustedToken);
			}

			return ret;
		}

		internal int DeleteByACOutputGroup(BusinessBase entity)
		{
			ACOutputGroupData data = (ACOutputGroupData) entity;
			if(data == null)
				return 0;

			bool isLogDeleteEnabled = ServiceBase._DBLog.IsLogDeleteEnabled;
			bool isLinkDBDeleteEnabled = ServiceBase._DBLink.IsLinkDBDeleteEnabled;
			if (!isLogDeleteEnabled && !isLinkDBDeleteEnabled)
			{
				return this._dal.DeleteByACOutputGroup(data. ACOutputGroupPK);
			}

			DataTable list = this._dal.GetLogByACOutputGroup(data. ACOutputGroupPK);
			list.TableName = this._dal.TableName;
			int ret = this._dal.DeleteByACOutputGroup(data. ACOutputGroupPK);
			if (isLogDeleteEnabled)
			{
				ServiceBase._DBLog.LogDelete(list, base.SecurityToken);
			}

			if (isLinkDBDeleteEnabled)
			{
				ServiceBase._DBLink.LinkDBDelete(list, base.TrustedToken);
			}

			return ret;
		}

		public virtual Result Purge(ACOutputGroupMainZoneMapData entity)
		{
			return base.Purge(entity);
		}

		protected override int PurgeEntity(BusinessBase entity)
		{
			ACOutputGroupMainZoneMapData data = (ACOutputGroupMainZoneMapData) entity;
			if(data == null)
				return 0;

			return this._dal.DeleteByPK( data.ACOutputGroupMainZoneMapPK, data.RowVersion);
		}

		internal int PurgeByACMainZone(BusinessBase entity)
		{
			ACMainZoneData data = (ACMainZoneData) entity;
			if(data == null)
				return 0;

			return this._dal.DeleteByACMainZone(data. ACMainZonePK);
		}

		internal int PurgeByACPanel(BusinessBase entity)
		{
			ACPanelData data = (ACPanelData) entity;
			if(data == null)
				return 0;

			return this._dal.DeleteByACPanel(data. ACPanelPK);
		}

		internal int PurgeByBDBuilding(BusinessBase entity)
		{
			BDBuildingData data = (BDBuildingData) entity;
			if(data == null)
				return 0;

			return this._dal.DeleteByBDBuilding(data. BDBuildingPK);
		}

		internal int PurgeByACOutputGroup(BusinessBase entity)
		{
			ACOutputGroupData data = (ACOutputGroupData) entity;
			if(data == null)
				return 0;

			return this._dal.DeleteByACOutputGroup(data. ACOutputGroupPK);
		}

		protected override int InsertEntity(BusinessBase entity)
		{
			ACOutputGroupMainZoneMapData data = (ACOutputGroupMainZoneMapData) entity;
			if(data == null)
				return 0;

			return this._dal.Insert(data);
		}

		protected override int UpdateEntity(BusinessBase entity)
		{
			ACOutputGroupMainZoneMapData data = (ACOutputGroupMainZoneMapData) entity;
			if(data == null)
				return 0;

			return this._dal.Update(data);
		}

		protected override void UpdateChildren(BusinessBase entity)
		{
			ACOutputGroupMainZoneMapData data = (ACOutputGroupMainZoneMapData) entity;
			if(data == null)
				return;

		}

		internal Result GetRowVersion(ACOutputGroupMainZoneMapDataCollection list)
		{
			return base.GetRowVersion(list);
		}

		protected override Result GetRowVersion(BusinessBase entity)
		{
			ACOutputGroupMainZoneMapData data = (ACOutputGroupMainZoneMapData) entity;
			if(data == null || !data.IsDirty)
				return new Result(true);

			Result result = new Result(true);
			if (entity.IsDeleted)
			{
				result.Add(data.ObjectID, new byte[0]);
				return result;
			}

			if (entity.IsSelfDirty)
			{
				result.Add(data.ObjectID, this._dal.GetRowVersion( data.ACOutputGroupMainZoneMapPK));
			}
			return result;
		}

		public virtual ACOutputGroupMainZoneMapData GetByPK( System.Guid ACOutputGroupMainZoneMapPK)
		{
			if (base.IsTrusted)
			{
				return this.Processing(this._dal.GetByPK( ACOutputGroupMainZoneMapPK));
			}

			if (!base.IsAuthorizedSelect)
			{
				return null;
			}

			return this.Processing((ACOutputGroupMainZoneMapData) base.Filter(this._dal.GetByPK( ACOutputGroupMainZoneMapPK)));
		}

		protected virtual ACOutputGroupMainZoneMapData GetEntity(string sqlWhere, SqlParameter[] paras)
		{
			if (base.IsTrusted)
			{
				return this.Processing(this._dal.GetEntityBy(sqlWhere, paras));
			}

			if (!base.IsAuthorizedSelect)
			{
				return null;
			}

			return this.Processing((ACOutputGroupMainZoneMapData) base.Filter(this._dal.GetEntityBy(sqlWhere, paras)));
		}

		public virtual ACOutputGroupMainZoneMapDataCollection GetAll()
		{
			if (base.IsTrusted)
			{
				return this.Processing(this._dal.GetAll());
			}

			if (!base.IsAuthorizedSelect)
			{
				return new ACOutputGroupMainZoneMapDataCollection();
			}

			return this.Processing((ACOutputGroupMainZoneMapDataCollection) base.Filter(this._dal.GetAll()));
		}

		public ACOutputGroupMainZoneMapViewCollection GetViewAll()
		{
			return new ACOutputGroupMainZoneMapViewCollection(this.GetAll());
		}

		protected virtual ACOutputGroupMainZoneMapDataCollection GetCollection(string sqlWhere, SqlParameter[] paras)
		{
			if (base.IsTrusted)
			{
				return this.Processing(this._dal.GetCollectionBy(sqlWhere, paras));
			}

			if (!base.IsAuthorizedSelect)
			{
				return new ACOutputGroupMainZoneMapDataCollection();
			}

			 return this.Processing((ACOutputGroupMainZoneMapDataCollection) base.Filter(this._dal.GetCollectionBy(sqlWhere, paras)));
		}

		public virtual ACOutputGroupMainZoneMapDataCollection GetByACMainZone(System.Guid ACMainZonePK)
		{
			if (base.IsTrusted)
			{
				return this.Processing(this._dal.GetByACMainZone(ACMainZonePK));
			}

			if (!base.IsAuthorizedSelect)
			{
				return null;
			}

			return this.Processing((ACOutputGroupMainZoneMapDataCollection) base.Filter(this._dal.GetByACMainZone(ACMainZonePK)));
		}

		public ACOutputGroupMainZoneMapViewCollection GetViewByACMainZone(System.Guid ACMainZonePK)
		{
			return new ACOutputGroupMainZoneMapViewCollection(this.GetByACMainZone(ACMainZonePK));
		}

		public virtual ACOutputGroupMainZoneMapDataCollection GetByACOutputGroup(System.Guid ACOutputGroupPK)
		{
			if (base.IsTrusted)
			{
				return this.Processing(this._dal.GetByACOutputGroup(ACOutputGroupPK));
			}

			if (!base.IsAuthorizedSelect)
			{
				return null;
			}

			return this.Processing((ACOutputGroupMainZoneMapDataCollection) base.Filter(this._dal.GetByACOutputGroup(ACOutputGroupPK)));
		}

		public ACOutputGroupMainZoneMapViewCollection GetViewByACOutputGroup(System.Guid ACOutputGroupPK)
		{
			return new ACOutputGroupMainZoneMapViewCollection(this.GetByACOutputGroup(ACOutputGroupPK));
		}

		protected virtual ACOutputGroupMainZoneMapData Processing(ACOutputGroupMainZoneMapData entity)
		{
			return entity;
		}

		protected virtual ACOutputGroupMainZoneMapDataCollection Processing(ACOutputGroupMainZoneMapDataCollection list)
		{
			ACOutputGroupMainZoneMapDataCollection retList = new ACOutputGroupMainZoneMapDataCollection();
			foreach(ACOutputGroupMainZoneMapData item in list)
			{
				ACOutputGroupMainZoneMapData data = this.Processing(item);
				if(data != null)
				{
					retList.Add(data);
				}
			}

			return retList;
		}

		public virtual Result Save(ACOutputGroupMainZoneMapData entity)
		{
			return base.Save(entity);
		}

		public virtual void SaveUnderTransaction(ACOutputGroupMainZoneMapData entity)
		{
			base.SaveUnderTransaction(entity);
		}

		public virtual Result Save(ACOutputGroupMainZoneMapDataCollection list)
		{
			return base.Save(list);
		}

		public virtual void SaveUnderTransaction(ACOutputGroupMainZoneMapDataCollection list)
		{
			base.SaveUnderTransaction(list);
		}


	}
	public abstract class ACCardHolderDataServiceBase : ServiceBase
	{
		protected ACCardHolderCRUD _dal;

		public ACCardHolderDataServiceBase(string connectionString, SecurityToken token) : base(connectionString, token)
		{
			this._dal = new ACCardHolderCRUD(connectionString);
			for (int i = 0; i < token.GetSortFields().Count; i++)
			{
				SortField field = token.GetSortFields()[i];
				this._dal.AddSortBy(field.FieldAlias, field.ASC);
			}
		}

		protected override string TableName
		{
			get
			{
				return "ACCardHolder";
			}
		}

		protected abstract ACCardHolderBuildingMapDataServiceBase GetACCardHolderBuildingMapDataServiceBase(SecurityToken token);

		protected override int DeleteEntity(BusinessBase entity)
		{
			ACCardHolderData data = (ACCardHolderData) entity;
			if(data == null)
				return 0;

			this.GetACCardHolderBuildingMapDataServiceBase(base.SecurityToken).DeleteByACCardHolder(data);
			return this._dal.DeleteByPK( data.ACCardHolderPK, data.RowVersion);
		}

		internal int DeleteByBDTenant(BusinessBase entity)
		{
			BDTenantData data = (BDTenantData) entity;
			if(data == null)
				return 0;

			this.GetACCardHolderBuildingMapDataServiceBase(base.SecurityToken).DeleteByBDTenant(entity);
			bool isLogDeleteEnabled = ServiceBase._DBLog.IsLogDeleteEnabled;
			bool isLinkDBDeleteEnabled = ServiceBase._DBLink.IsLinkDBDeleteEnabled;
			if (!isLogDeleteEnabled && !isLinkDBDeleteEnabled)
			{
				return this._dal.DeleteByBDTenant(data. BDTenantPK);
			}

			DataTable list = this._dal.GetLogByBDTenant(data. BDTenantPK);
			list.TableName = this._dal.TableName;
			int ret = this._dal.DeleteByBDTenant(data. BDTenantPK);
			if (isLogDeleteEnabled)
			{
				ServiceBase._DBLog.LogDelete(list, base.SecurityToken);
			}

			if (isLinkDBDeleteEnabled)
			{
				ServiceBase._DBLink.LinkDBDelete(list, base.TrustedToken);
			}

			return ret;
		}

		internal int DeleteByBDBuilding(BusinessBase entity)
		{
			BDBuildingData data = (BDBuildingData) entity;
			if(data == null)
				return 0;

			this.GetACCardHolderBuildingMapDataServiceBase(base.SecurityToken).DeleteByBDBuilding(entity);
			bool isLogDeleteEnabled = ServiceBase._DBLog.IsLogDeleteEnabled;
			bool isLinkDBDeleteEnabled = ServiceBase._DBLink.IsLinkDBDeleteEnabled;
			if (!isLogDeleteEnabled && !isLinkDBDeleteEnabled)
			{
				return this._dal.DeleteByBDBuilding(data. BDBuildingPK);
			}

			DataTable list = this._dal.GetLogByBDBuilding(data. BDBuildingPK);
			list.TableName = this._dal.TableName;
			int ret = this._dal.DeleteByBDBuilding(data. BDBuildingPK);
			if (isLogDeleteEnabled)
			{
				ServiceBase._DBLog.LogDelete(list, base.SecurityToken);
			}

			if (isLinkDBDeleteEnabled)
			{
				ServiceBase._DBLink.LinkDBDelete(list, base.TrustedToken);
			}

			return ret;
		}

		public virtual Result Purge(ACCardHolderData entity)
		{
			return base.Purge(entity);
		}

		protected override int PurgeEntity(BusinessBase entity)
		{
			ACCardHolderData data = (ACCardHolderData) entity;
			if(data == null)
				return 0;

			this.GetACCardHolderBuildingMapDataServiceBase(base.SecurityToken).PurgeByACCardHolder(data);
			return this._dal.DeleteByPK( data.ACCardHolderPK, data.RowVersion);
		}

		internal int PurgeByBDTenant(BusinessBase entity)
		{
			BDTenantData data = (BDTenantData) entity;
			if(data == null)
				return 0;

			this.GetACCardHolderBuildingMapDataServiceBase(base.SecurityToken).PurgeByBDTenant(entity);
			return this._dal.DeleteByBDTenant(data. BDTenantPK);
		}

		internal int PurgeByBDBuilding(BusinessBase entity)
		{
			BDBuildingData data = (BDBuildingData) entity;
			if(data == null)
				return 0;

			this.GetACCardHolderBuildingMapDataServiceBase(base.SecurityToken).PurgeByBDBuilding(entity);
			return this._dal.DeleteByBDBuilding(data. BDBuildingPK);
		}

		protected override int InsertEntity(BusinessBase entity)
		{
			ACCardHolderData data = (ACCardHolderData) entity;
			if(data == null)
				return 0;

			return this._dal.Insert(data);
		}

		protected override int UpdateEntity(BusinessBase entity)
		{
			ACCardHolderData data = (ACCardHolderData) entity;
			if(data == null)
				return 0;

			return this._dal.Update(data);
		}

		protected override void UpdateChildren(BusinessBase entity)
		{
			ACCardHolderData data = (ACCardHolderData) entity;
			if(data == null)
				return;

			if (data.ACCardHolderBuildingMapList != null)
			{
				 this.GetACCardHolderBuildingMapDataServiceBase(base.SecurityToken).SaveUnderTransaction(data.ACCardHolderBuildingMapList);
			}
		}

		internal Result GetRowVersion(ACCardHolderDataCollection list)
		{
			return base.GetRowVersion(list);
		}

		protected override Result GetRowVersion(BusinessBase entity)
		{
			ACCardHolderData data = (ACCardHolderData) entity;
			if(data == null || !data.IsDirty)
				return new Result(true);

			Result result = new Result(true);
			if (entity.IsDeleted)
			{
				result.Add(data.ObjectID, new byte[0]);
				return result;
			}

			if (entity.IsSelfDirty)
			{
				result.Add(data.ObjectID, this._dal.GetRowVersion( data.ACCardHolderPK));
			}
			if (data.ACCardHolderBuildingMapList != null && data.ACCardHolderBuildingMapList.Count > 0)
			{
				result.Add(this.GetACCardHolderBuildingMapDataServiceBase(base.SecurityToken).GetRowVersion(data.ACCardHolderBuildingMapList));
			}
			return result;
		}

		public virtual ACCardHolderData GetByPK( System.Guid ACCardHolderPK)
		{
			if (base.IsTrusted)
			{
				return this.Processing(this._dal.GetByPK( ACCardHolderPK));
			}

			if (!base.IsAuthorizedSelect)
			{
				return null;
			}

			return this.Processing((ACCardHolderData) base.Filter(this._dal.GetByPK( ACCardHolderPK)));
		}

		protected virtual ACCardHolderData GetEntity(string sqlWhere, SqlParameter[] paras)
		{
			if (base.IsTrusted)
			{
				return this.Processing(this._dal.GetEntityBy(sqlWhere, paras));
			}

			if (!base.IsAuthorizedSelect)
			{
				return null;
			}

			return this.Processing((ACCardHolderData) base.Filter(this._dal.GetEntityBy(sqlWhere, paras)));
		}

		public virtual ACCardHolderDataCollection GetAll()
		{
			if (base.IsTrusted)
			{
				return this.Processing(this._dal.GetAll());
			}

			if (!base.IsAuthorizedSelect)
			{
				return new ACCardHolderDataCollection();
			}

			return this.Processing((ACCardHolderDataCollection) base.Filter(this._dal.GetAll()));
		}

		public ACCardHolderViewCollection GetViewAll()
		{
			return new ACCardHolderViewCollection(this.GetAll());
		}

		protected virtual ACCardHolderDataCollection GetCollection(string sqlWhere, SqlParameter[] paras)
		{
			if (base.IsTrusted)
			{
				return this.Processing(this._dal.GetCollectionBy(sqlWhere, paras));
			}

			if (!base.IsAuthorizedSelect)
			{
				return new ACCardHolderDataCollection();
			}

			 return this.Processing((ACCardHolderDataCollection) base.Filter(this._dal.GetCollectionBy(sqlWhere, paras)));
		}

		public virtual ACCardHolderDataCollection GetByBDTenant(System.Guid BDTenantPK)
		{
			if (base.IsTrusted)
			{
				return this.Processing(this._dal.GetByBDTenant(BDTenantPK));
			}

			if (!base.IsAuthorizedSelect)
			{
				return null;
			}

			return this.Processing((ACCardHolderDataCollection) base.Filter(this._dal.GetByBDTenant(BDTenantPK)));
		}

		public ACCardHolderViewCollection GetViewByBDTenant(System.Guid BDTenantPK)
		{
			return new ACCardHolderViewCollection(this.GetByBDTenant(BDTenantPK));
		}

		protected virtual ACCardHolderData Processing(ACCardHolderData entity)
		{
			return entity;
		}

		protected virtual ACCardHolderDataCollection Processing(ACCardHolderDataCollection list)
		{
			ACCardHolderDataCollection retList = new ACCardHolderDataCollection();
			foreach(ACCardHolderData item in list)
			{
				ACCardHolderData data = this.Processing(item);
				if(data != null)
				{
					retList.Add(data);
				}
			}

			return retList;
		}

		public virtual Result Save(ACCardHolderData entity)
		{
			return base.Save(entity);
		}

		public virtual void SaveUnderTransaction(ACCardHolderData entity)
		{
			base.SaveUnderTransaction(entity);
		}

		public virtual Result Save(ACCardHolderDataCollection list)
		{
			return base.Save(list);
		}

		public virtual void SaveUnderTransaction(ACCardHolderDataCollection list)
		{
			base.SaveUnderTransaction(list);
		}


	}
	public abstract class ACMainZoneDataServiceBase : ServiceBase
	{
		protected ACMainZoneCRUD _dal;

		public ACMainZoneDataServiceBase(string connectionString, SecurityToken token) : base(connectionString, token)
		{
			this._dal = new ACMainZoneCRUD(connectionString);
			for (int i = 0; i < token.GetSortFields().Count; i++)
			{
				SortField field = token.GetSortFields()[i];
				this._dal.AddSortBy(field.FieldAlias, field.ASC);
			}
		}

		protected override string TableName
		{
			get
			{
				return "ACMainZone";
			}
		}

		protected abstract ACOutputGroupMainZoneMapDataServiceBase GetACOutputGroupMainZoneMapDataServiceBase(SecurityToken token);
		protected abstract ACAccessLevelDetailDataServiceBase GetACAccessLevelDetailDataServiceBase(SecurityToken token);

		protected override int DeleteEntity(BusinessBase entity)
		{
			ACMainZoneData data = (ACMainZoneData) entity;
			if(data == null)
				return 0;

			this.GetACOutputGroupMainZoneMapDataServiceBase(base.SecurityToken).DeleteByACMainZone(data);
			this.GetACAccessLevelDetailDataServiceBase(base.SecurityToken).DeleteByACMainZone(data);
			return this._dal.DeleteByPK( data.ACMainZonePK, data.RowVersion);
		}

		internal int DeleteByACPanel(BusinessBase entity)
		{
			ACPanelData data = (ACPanelData) entity;
			if(data == null)
				return 0;

			this.GetACOutputGroupMainZoneMapDataServiceBase(base.SecurityToken).DeleteByACPanel(entity);
			this.GetACAccessLevelDetailDataServiceBase(base.SecurityToken).DeleteByACPanel(entity);
			bool isLogDeleteEnabled = ServiceBase._DBLog.IsLogDeleteEnabled;
			bool isLinkDBDeleteEnabled = ServiceBase._DBLink.IsLinkDBDeleteEnabled;
			if (!isLogDeleteEnabled && !isLinkDBDeleteEnabled)
			{
				return this._dal.DeleteByACPanel(data. ACPanelPK);
			}

			DataTable list = this._dal.GetLogByACPanel(data. ACPanelPK);
			list.TableName = this._dal.TableName;
			int ret = this._dal.DeleteByACPanel(data. ACPanelPK);
			if (isLogDeleteEnabled)
			{
				ServiceBase._DBLog.LogDelete(list, base.SecurityToken);
			}

			if (isLinkDBDeleteEnabled)
			{
				ServiceBase._DBLink.LinkDBDelete(list, base.TrustedToken);
			}

			return ret;
		}

		internal int DeleteByBDBuilding(BusinessBase entity)
		{
			BDBuildingData data = (BDBuildingData) entity;
			if(data == null)
				return 0;

			this.GetACOutputGroupMainZoneMapDataServiceBase(base.SecurityToken).DeleteByBDBuilding(entity);
			this.GetACAccessLevelDetailDataServiceBase(base.SecurityToken).DeleteByBDBuilding(entity);
			bool isLogDeleteEnabled = ServiceBase._DBLog.IsLogDeleteEnabled;
			bool isLinkDBDeleteEnabled = ServiceBase._DBLink.IsLinkDBDeleteEnabled;
			if (!isLogDeleteEnabled && !isLinkDBDeleteEnabled)
			{
				return this._dal.DeleteByBDBuilding(data. BDBuildingPK);
			}

			DataTable list = this._dal.GetLogByBDBuilding(data. BDBuildingPK);
			list.TableName = this._dal.TableName;
			int ret = this._dal.DeleteByBDBuilding(data. BDBuildingPK);
			if (isLogDeleteEnabled)
			{
				ServiceBase._DBLog.LogDelete(list, base.SecurityToken);
			}

			if (isLinkDBDeleteEnabled)
			{
				ServiceBase._DBLink.LinkDBDelete(list, base.TrustedToken);
			}

			return ret;
		}

		public virtual Result Purge(ACMainZoneData entity)
		{
			return base.Purge(entity);
		}

		protected override int PurgeEntity(BusinessBase entity)
		{
			ACMainZoneData data = (ACMainZoneData) entity;
			if(data == null)
				return 0;

			this.GetACOutputGroupMainZoneMapDataServiceBase(base.SecurityToken).PurgeByACMainZone(data);
			this.GetACAccessLevelDetailDataServiceBase(base.SecurityToken).PurgeByACMainZone(data);
			return this._dal.DeleteByPK( data.ACMainZonePK, data.RowVersion);
		}

		internal int PurgeByACPanel(BusinessBase entity)
		{
			ACPanelData data = (ACPanelData) entity;
			if(data == null)
				return 0;

			this.GetACOutputGroupMainZoneMapDataServiceBase(base.SecurityToken).PurgeByACPanel(entity);
			this.GetACAccessLevelDetailDataServiceBase(base.SecurityToken).PurgeByACPanel(entity);
			return this._dal.DeleteByACPanel(data. ACPanelPK);
		}

		internal int PurgeByBDBuilding(BusinessBase entity)
		{
			BDBuildingData data = (BDBuildingData) entity;
			if(data == null)
				return 0;

			this.GetACOutputGroupMainZoneMapDataServiceBase(base.SecurityToken).PurgeByBDBuilding(entity);
			this.GetACAccessLevelDetailDataServiceBase(base.SecurityToken).PurgeByBDBuilding(entity);
			return this._dal.DeleteByBDBuilding(data. BDBuildingPK);
		}

		protected override int InsertEntity(BusinessBase entity)
		{
			ACMainZoneData data = (ACMainZoneData) entity;
			if(data == null)
				return 0;

			return this._dal.Insert(data);
		}

		protected override int UpdateEntity(BusinessBase entity)
		{
			ACMainZoneData data = (ACMainZoneData) entity;
			if(data == null)
				return 0;

			return this._dal.Update(data);
		}

		protected override void UpdateChildren(BusinessBase entity)
		{
			ACMainZoneData data = (ACMainZoneData) entity;
			if(data == null)
				return;

			if (data.ACOutputGroupMainZoneMapList != null)
			{
				 this.GetACOutputGroupMainZoneMapDataServiceBase(base.SecurityToken).SaveUnderTransaction(data.ACOutputGroupMainZoneMapList);
			}
			if (data.ACAccessLevelDetailList != null)
			{
				 this.GetACAccessLevelDetailDataServiceBase(base.SecurityToken).SaveUnderTransaction(data.ACAccessLevelDetailList);
			}
		}

		internal Result GetRowVersion(ACMainZoneDataCollection list)
		{
			return base.GetRowVersion(list);
		}

		protected override Result GetRowVersion(BusinessBase entity)
		{
			ACMainZoneData data = (ACMainZoneData) entity;
			if(data == null || !data.IsDirty)
				return new Result(true);

			Result result = new Result(true);
			if (entity.IsDeleted)
			{
				result.Add(data.ObjectID, new byte[0]);
				return result;
			}

			if (entity.IsSelfDirty)
			{
				result.Add(data.ObjectID, this._dal.GetRowVersion( data.ACMainZonePK));
			}
			if (data.ACOutputGroupMainZoneMapList != null && data.ACOutputGroupMainZoneMapList.Count > 0)
			{
				result.Add(this.GetACOutputGroupMainZoneMapDataServiceBase(base.SecurityToken).GetRowVersion(data.ACOutputGroupMainZoneMapList));
			}
			if (data.ACAccessLevelDetailList != null && data.ACAccessLevelDetailList.Count > 0)
			{
				result.Add(this.GetACAccessLevelDetailDataServiceBase(base.SecurityToken).GetRowVersion(data.ACAccessLevelDetailList));
			}
			return result;
		}

		public virtual ACMainZoneData GetByPK( System.Guid ACMainZonePK)
		{
			if (base.IsTrusted)
			{
				return this.Processing(this._dal.GetByPK( ACMainZonePK));
			}

			if (!base.IsAuthorizedSelect)
			{
				return null;
			}

			return this.Processing((ACMainZoneData) base.Filter(this._dal.GetByPK( ACMainZonePK)));
		}

		protected virtual ACMainZoneData GetEntity(string sqlWhere, SqlParameter[] paras)
		{
			if (base.IsTrusted)
			{
				return this.Processing(this._dal.GetEntityBy(sqlWhere, paras));
			}

			if (!base.IsAuthorizedSelect)
			{
				return null;
			}

			return this.Processing((ACMainZoneData) base.Filter(this._dal.GetEntityBy(sqlWhere, paras)));
		}

		public virtual ACMainZoneDataCollection GetAll()
		{
			if (base.IsTrusted)
			{
				return this.Processing(this._dal.GetAll());
			}

			if (!base.IsAuthorizedSelect)
			{
				return new ACMainZoneDataCollection();
			}

			return this.Processing((ACMainZoneDataCollection) base.Filter(this._dal.GetAll()));
		}

		public ACMainZoneViewCollection GetViewAll()
		{
			return new ACMainZoneViewCollection(this.GetAll());
		}

		protected virtual ACMainZoneDataCollection GetCollection(string sqlWhere, SqlParameter[] paras)
		{
			if (base.IsTrusted)
			{
				return this.Processing(this._dal.GetCollectionBy(sqlWhere, paras));
			}

			if (!base.IsAuthorizedSelect)
			{
				return new ACMainZoneDataCollection();
			}

			 return this.Processing((ACMainZoneDataCollection) base.Filter(this._dal.GetCollectionBy(sqlWhere, paras)));
		}

		public virtual ACMainZoneDataCollection GetByACPanel(System.Guid ACPanelPK)
		{
			if (base.IsTrusted)
			{
				return this.Processing(this._dal.GetByACPanel(ACPanelPK));
			}

			if (!base.IsAuthorizedSelect)
			{
				return null;
			}

			return this.Processing((ACMainZoneDataCollection) base.Filter(this._dal.GetByACPanel(ACPanelPK)));
		}

		public ACMainZoneViewCollection GetViewByACPanel(System.Guid ACPanelPK)
		{
			return new ACMainZoneViewCollection(this.GetByACPanel(ACPanelPK));
		}

		protected virtual ACMainZoneData Processing(ACMainZoneData entity)
		{
			return entity;
		}

		protected virtual ACMainZoneDataCollection Processing(ACMainZoneDataCollection list)
		{
			ACMainZoneDataCollection retList = new ACMainZoneDataCollection();
			foreach(ACMainZoneData item in list)
			{
				ACMainZoneData data = this.Processing(item);
				if(data != null)
				{
					retList.Add(data);
				}
			}

			return retList;
		}

		public virtual Result Save(ACMainZoneData entity)
		{
			return base.Save(entity);
		}

		public virtual void SaveUnderTransaction(ACMainZoneData entity)
		{
			base.SaveUnderTransaction(entity);
		}

		public virtual Result Save(ACMainZoneDataCollection list)
		{
			return base.Save(list);
		}

		public virtual void SaveUnderTransaction(ACMainZoneDataCollection list)
		{
			base.SaveUnderTransaction(list);
		}


	}
	public abstract class ACIntervalDataServiceBase : ServiceBase
	{
		protected ACIntervalCRUD _dal;

		public ACIntervalDataServiceBase(string connectionString, SecurityToken token) : base(connectionString, token)
		{
			this._dal = new ACIntervalCRUD(connectionString);
			for (int i = 0; i < token.GetSortFields().Count; i++)
			{
				SortField field = token.GetSortFields()[i];
				this._dal.AddSortBy(field.FieldAlias, field.ASC);
			}
		}

		protected override string TableName
		{
			get
			{
				return "ACInterval";
			}
		}

		protected abstract ACIntvalHolidayMapDataServiceBase GetACIntvalHolidayMapDataServiceBase(SecurityToken token);
		protected abstract ACTimecodeIntervalMapDataServiceBase GetACTimecodeIntervalMapDataServiceBase(SecurityToken token);

		protected override int DeleteEntity(BusinessBase entity)
		{
			ACIntervalData data = (ACIntervalData) entity;
			if(data == null)
				return 0;

			this.GetACIntvalHolidayMapDataServiceBase(base.SecurityToken).DeleteByACInterval(data);
			this.GetACTimecodeIntervalMapDataServiceBase(base.SecurityToken).DeleteByACInterval(data);
			return this._dal.DeleteByPK( data.ACIntervalPK, data.RowVersion);
		}

		internal int DeleteByBDBuilding(BusinessBase entity)
		{
			BDBuildingData data = (BDBuildingData) entity;
			if(data == null)
				return 0;

			this.GetACIntvalHolidayMapDataServiceBase(base.SecurityToken).DeleteByBDBuilding(entity);
			this.GetACTimecodeIntervalMapDataServiceBase(base.SecurityToken).DeleteByBDBuilding(entity);
			bool isLogDeleteEnabled = ServiceBase._DBLog.IsLogDeleteEnabled;
			bool isLinkDBDeleteEnabled = ServiceBase._DBLink.IsLinkDBDeleteEnabled;
			if (!isLogDeleteEnabled && !isLinkDBDeleteEnabled)
			{
				return this._dal.DeleteByBDBuilding(data. BDBuildingPK);
			}

			DataTable list = this._dal.GetLogByBDBuilding(data. BDBuildingPK);
			list.TableName = this._dal.TableName;
			int ret = this._dal.DeleteByBDBuilding(data. BDBuildingPK);
			if (isLogDeleteEnabled)
			{
				ServiceBase._DBLog.LogDelete(list, base.SecurityToken);
			}

			if (isLinkDBDeleteEnabled)
			{
				ServiceBase._DBLink.LinkDBDelete(list, base.TrustedToken);
			}

			return ret;
		}

		public virtual Result Purge(ACIntervalData entity)
		{
			return base.Purge(entity);
		}

		protected override int PurgeEntity(BusinessBase entity)
		{
			ACIntervalData data = (ACIntervalData) entity;
			if(data == null)
				return 0;

			this.GetACIntvalHolidayMapDataServiceBase(base.SecurityToken).PurgeByACInterval(data);
			this.GetACTimecodeIntervalMapDataServiceBase(base.SecurityToken).PurgeByACInterval(data);
			return this._dal.DeleteByPK( data.ACIntervalPK, data.RowVersion);
		}

		internal int PurgeByBDBuilding(BusinessBase entity)
		{
			BDBuildingData data = (BDBuildingData) entity;
			if(data == null)
				return 0;

			this.GetACIntvalHolidayMapDataServiceBase(base.SecurityToken).PurgeByBDBuilding(entity);
			this.GetACTimecodeIntervalMapDataServiceBase(base.SecurityToken).PurgeByBDBuilding(entity);
			return this._dal.DeleteByBDBuilding(data. BDBuildingPK);
		}

		protected override int InsertEntity(BusinessBase entity)
		{
			ACIntervalData data = (ACIntervalData) entity;
			if(data == null)
				return 0;

			return this._dal.Insert(data);
		}

		protected override int UpdateEntity(BusinessBase entity)
		{
			ACIntervalData data = (ACIntervalData) entity;
			if(data == null)
				return 0;

			return this._dal.Update(data);
		}

		protected override void UpdateChildren(BusinessBase entity)
		{
			ACIntervalData data = (ACIntervalData) entity;
			if(data == null)
				return;

			if (data.ACIntvalHolidayMapList != null)
			{
				 this.GetACIntvalHolidayMapDataServiceBase(base.SecurityToken).SaveUnderTransaction(data.ACIntvalHolidayMapList);
			}
			if (data.ACTimecodeIntervalMapList != null)
			{
				 this.GetACTimecodeIntervalMapDataServiceBase(base.SecurityToken).SaveUnderTransaction(data.ACTimecodeIntervalMapList);
			}
		}

		internal Result GetRowVersion(ACIntervalDataCollection list)
		{
			return base.GetRowVersion(list);
		}

		protected override Result GetRowVersion(BusinessBase entity)
		{
			ACIntervalData data = (ACIntervalData) entity;
			if(data == null || !data.IsDirty)
				return new Result(true);

			Result result = new Result(true);
			if (entity.IsDeleted)
			{
				result.Add(data.ObjectID, new byte[0]);
				return result;
			}

			if (entity.IsSelfDirty)
			{
				result.Add(data.ObjectID, this._dal.GetRowVersion( data.ACIntervalPK));
			}
			if (data.ACIntvalHolidayMapList != null && data.ACIntvalHolidayMapList.Count > 0)
			{
				result.Add(this.GetACIntvalHolidayMapDataServiceBase(base.SecurityToken).GetRowVersion(data.ACIntvalHolidayMapList));
			}
			if (data.ACTimecodeIntervalMapList != null && data.ACTimecodeIntervalMapList.Count > 0)
			{
				result.Add(this.GetACTimecodeIntervalMapDataServiceBase(base.SecurityToken).GetRowVersion(data.ACTimecodeIntervalMapList));
			}
			return result;
		}

		public virtual ACIntervalData GetByPK( System.Guid ACIntervalPK)
		{
			if (base.IsTrusted)
			{
				return this.Processing(this._dal.GetByPK( ACIntervalPK));
			}

			if (!base.IsAuthorizedSelect)
			{
				return null;
			}

			return this.Processing((ACIntervalData) base.Filter(this._dal.GetByPK( ACIntervalPK)));
		}

		protected virtual ACIntervalData GetEntity(string sqlWhere, SqlParameter[] paras)
		{
			if (base.IsTrusted)
			{
				return this.Processing(this._dal.GetEntityBy(sqlWhere, paras));
			}

			if (!base.IsAuthorizedSelect)
			{
				return null;
			}

			return this.Processing((ACIntervalData) base.Filter(this._dal.GetEntityBy(sqlWhere, paras)));
		}

		public virtual ACIntervalDataCollection GetAll()
		{
			if (base.IsTrusted)
			{
				return this.Processing(this._dal.GetAll());
			}

			if (!base.IsAuthorizedSelect)
			{
				return new ACIntervalDataCollection();
			}

			return this.Processing((ACIntervalDataCollection) base.Filter(this._dal.GetAll()));
		}

		public ACIntervalViewCollection GetViewAll()
		{
			return new ACIntervalViewCollection(this.GetAll());
		}

		protected virtual ACIntervalDataCollection GetCollection(string sqlWhere, SqlParameter[] paras)
		{
			if (base.IsTrusted)
			{
				return this.Processing(this._dal.GetCollectionBy(sqlWhere, paras));
			}

			if (!base.IsAuthorizedSelect)
			{
				return new ACIntervalDataCollection();
			}

			 return this.Processing((ACIntervalDataCollection) base.Filter(this._dal.GetCollectionBy(sqlWhere, paras)));
		}

		public virtual ACIntervalDataCollection GetByBDBuilding(System.Guid BDBuildingPK)
		{
			if (base.IsTrusted)
			{
				return this.Processing(this._dal.GetByBDBuilding(BDBuildingPK));
			}

			if (!base.IsAuthorizedSelect)
			{
				return null;
			}

			return this.Processing((ACIntervalDataCollection) base.Filter(this._dal.GetByBDBuilding(BDBuildingPK)));
		}

		public ACIntervalViewCollection GetViewByBDBuilding(System.Guid BDBuildingPK)
		{
			return new ACIntervalViewCollection(this.GetByBDBuilding(BDBuildingPK));
		}

		protected virtual ACIntervalData Processing(ACIntervalData entity)
		{
			return entity;
		}

		protected virtual ACIntervalDataCollection Processing(ACIntervalDataCollection list)
		{
			ACIntervalDataCollection retList = new ACIntervalDataCollection();
			foreach(ACIntervalData item in list)
			{
				ACIntervalData data = this.Processing(item);
				if(data != null)
				{
					retList.Add(data);
				}
			}

			return retList;
		}

		public virtual Result Save(ACIntervalData entity)
		{
			return base.Save(entity);
		}

		public virtual void SaveUnderTransaction(ACIntervalData entity)
		{
			base.SaveUnderTransaction(entity);
		}

		public virtual Result Save(ACIntervalDataCollection list)
		{
			return base.Save(list);
		}

		public virtual void SaveUnderTransaction(ACIntervalDataCollection list)
		{
			base.SaveUnderTransaction(list);
		}


	}
	public abstract class ACPanelHolidayMapDataServiceBase : ServiceBase
	{
		protected ACPanelHolidayMapCRUD _dal;

		public ACPanelHolidayMapDataServiceBase(string connectionString, SecurityToken token) : base(connectionString, token)
		{
			this._dal = new ACPanelHolidayMapCRUD(connectionString);
			for (int i = 0; i < token.GetSortFields().Count; i++)
			{
				SortField field = token.GetSortFields()[i];
				this._dal.AddSortBy(field.FieldAlias, field.ASC);
			}
		}

		protected override string TableName
		{
			get
			{
				return "ACPanelHolidayMap";
			}
		}


		protected override int DeleteEntity(BusinessBase entity)
		{
			ACPanelHolidayMapData data = (ACPanelHolidayMapData) entity;
			if(data == null)
				return 0;

			return this._dal.DeleteByPK( data.ACPanelHolidayMapPK, data.RowVersion);
		}

		internal int DeleteByUtilHoliday(BusinessBase entity)
		{
			UtilHolidayData data = (UtilHolidayData) entity;
			if(data == null)
				return 0;

			bool isLogDeleteEnabled = ServiceBase._DBLog.IsLogDeleteEnabled;
			bool isLinkDBDeleteEnabled = ServiceBase._DBLink.IsLinkDBDeleteEnabled;
			if (!isLogDeleteEnabled && !isLinkDBDeleteEnabled)
			{
				return this._dal.DeleteByUtilHoliday(data. UtilHolidayPK);
			}

			DataTable list = this._dal.GetLogByUtilHoliday(data. UtilHolidayPK);
			list.TableName = this._dal.TableName;
			int ret = this._dal.DeleteByUtilHoliday(data. UtilHolidayPK);
			if (isLogDeleteEnabled)
			{
				ServiceBase._DBLog.LogDelete(list, base.SecurityToken);
			}

			if (isLinkDBDeleteEnabled)
			{
				ServiceBase._DBLink.LinkDBDelete(list, base.TrustedToken);
			}

			return ret;
		}

		internal int DeleteByACPanel(BusinessBase entity)
		{
			ACPanelData data = (ACPanelData) entity;
			if(data == null)
				return 0;

			bool isLogDeleteEnabled = ServiceBase._DBLog.IsLogDeleteEnabled;
			bool isLinkDBDeleteEnabled = ServiceBase._DBLink.IsLinkDBDeleteEnabled;
			if (!isLogDeleteEnabled && !isLinkDBDeleteEnabled)
			{
				return this._dal.DeleteByACPanel(data. ACPanelPK);
			}

			DataTable list = this._dal.GetLogByACPanel(data. ACPanelPK);
			list.TableName = this._dal.TableName;
			int ret = this._dal.DeleteByACPanel(data. ACPanelPK);
			if (isLogDeleteEnabled)
			{
				ServiceBase._DBLog.LogDelete(list, base.SecurityToken);
			}

			if (isLinkDBDeleteEnabled)
			{
				ServiceBase._DBLink.LinkDBDelete(list, base.TrustedToken);
			}

			return ret;
		}

		internal int DeleteByBDBuilding(BusinessBase entity)
		{
			BDBuildingData data = (BDBuildingData) entity;
			if(data == null)
				return 0;

			bool isLogDeleteEnabled = ServiceBase._DBLog.IsLogDeleteEnabled;
			bool isLinkDBDeleteEnabled = ServiceBase._DBLink.IsLinkDBDeleteEnabled;
			if (!isLogDeleteEnabled && !isLinkDBDeleteEnabled)
			{
				return this._dal.DeleteByBDBuilding(data. BDBuildingPK);
			}

			DataTable list = this._dal.GetLogByBDBuilding(data. BDBuildingPK);
			list.TableName = this._dal.TableName;
			int ret = this._dal.DeleteByBDBuilding(data. BDBuildingPK);
			if (isLogDeleteEnabled)
			{
				ServiceBase._DBLog.LogDelete(list, base.SecurityToken);
			}

			if (isLinkDBDeleteEnabled)
			{
				ServiceBase._DBLink.LinkDBDelete(list, base.TrustedToken);
			}

			return ret;
		}

		public virtual Result Purge(ACPanelHolidayMapData entity)
		{
			return base.Purge(entity);
		}

		protected override int PurgeEntity(BusinessBase entity)
		{
			ACPanelHolidayMapData data = (ACPanelHolidayMapData) entity;
			if(data == null)
				return 0;

			return this._dal.DeleteByPK( data.ACPanelHolidayMapPK, data.RowVersion);
		}

		internal int PurgeByUtilHoliday(BusinessBase entity)
		{
			UtilHolidayData data = (UtilHolidayData) entity;
			if(data == null)
				return 0;

			return this._dal.DeleteByUtilHoliday(data. UtilHolidayPK);
		}

		internal int PurgeByACPanel(BusinessBase entity)
		{
			ACPanelData data = (ACPanelData) entity;
			if(data == null)
				return 0;

			return this._dal.DeleteByACPanel(data. ACPanelPK);
		}

		internal int PurgeByBDBuilding(BusinessBase entity)
		{
			BDBuildingData data = (BDBuildingData) entity;
			if(data == null)
				return 0;

			return this._dal.DeleteByBDBuilding(data. BDBuildingPK);
		}

		protected override int InsertEntity(BusinessBase entity)
		{
			ACPanelHolidayMapData data = (ACPanelHolidayMapData) entity;
			if(data == null)
				return 0;

			return this._dal.Insert(data);
		}

		protected override int UpdateEntity(BusinessBase entity)
		{
			ACPanelHolidayMapData data = (ACPanelHolidayMapData) entity;
			if(data == null)
				return 0;

			return this._dal.Update(data);
		}

		protected override void UpdateChildren(BusinessBase entity)
		{
			ACPanelHolidayMapData data = (ACPanelHolidayMapData) entity;
			if(data == null)
				return;

		}

		internal Result GetRowVersion(ACPanelHolidayMapDataCollection list)
		{
			return base.GetRowVersion(list);
		}

		protected override Result GetRowVersion(BusinessBase entity)
		{
			ACPanelHolidayMapData data = (ACPanelHolidayMapData) entity;
			if(data == null || !data.IsDirty)
				return new Result(true);

			Result result = new Result(true);
			if (entity.IsDeleted)
			{
				result.Add(data.ObjectID, new byte[0]);
				return result;
			}

			if (entity.IsSelfDirty)
			{
				result.Add(data.ObjectID, this._dal.GetRowVersion( data.ACPanelHolidayMapPK));
			}
			return result;
		}

		public virtual ACPanelHolidayMapData GetByPK( System.Guid ACPanelHolidayMapPK)
		{
			if (base.IsTrusted)
			{
				return this.Processing(this._dal.GetByPK( ACPanelHolidayMapPK));
			}

			if (!base.IsAuthorizedSelect)
			{
				return null;
			}

			return this.Processing((ACPanelHolidayMapData) base.Filter(this._dal.GetByPK( ACPanelHolidayMapPK)));
		}

		protected virtual ACPanelHolidayMapData GetEntity(string sqlWhere, SqlParameter[] paras)
		{
			if (base.IsTrusted)
			{
				return this.Processing(this._dal.GetEntityBy(sqlWhere, paras));
			}

			if (!base.IsAuthorizedSelect)
			{
				return null;
			}

			return this.Processing((ACPanelHolidayMapData) base.Filter(this._dal.GetEntityBy(sqlWhere, paras)));
		}

		public virtual ACPanelHolidayMapDataCollection GetAll()
		{
			if (base.IsTrusted)
			{
				return this.Processing(this._dal.GetAll());
			}

			if (!base.IsAuthorizedSelect)
			{
				return new ACPanelHolidayMapDataCollection();
			}

			return this.Processing((ACPanelHolidayMapDataCollection) base.Filter(this._dal.GetAll()));
		}

		public ACPanelHolidayMapViewCollection GetViewAll()
		{
			return new ACPanelHolidayMapViewCollection(this.GetAll());
		}

		protected virtual ACPanelHolidayMapDataCollection GetCollection(string sqlWhere, SqlParameter[] paras)
		{
			if (base.IsTrusted)
			{
				return this.Processing(this._dal.GetCollectionBy(sqlWhere, paras));
			}

			if (!base.IsAuthorizedSelect)
			{
				return new ACPanelHolidayMapDataCollection();
			}

			 return this.Processing((ACPanelHolidayMapDataCollection) base.Filter(this._dal.GetCollectionBy(sqlWhere, paras)));
		}

		public virtual ACPanelHolidayMapDataCollection GetByUtilHoliday(System.Guid UtilHolidayPK)
		{
			if (base.IsTrusted)
			{
				return this.Processing(this._dal.GetByUtilHoliday(UtilHolidayPK));
			}

			if (!base.IsAuthorizedSelect)
			{
				return null;
			}

			return this.Processing((ACPanelHolidayMapDataCollection) base.Filter(this._dal.GetByUtilHoliday(UtilHolidayPK)));
		}

		public ACPanelHolidayMapViewCollection GetViewByUtilHoliday(System.Guid UtilHolidayPK)
		{
			return new ACPanelHolidayMapViewCollection(this.GetByUtilHoliday(UtilHolidayPK));
		}

		public virtual ACPanelHolidayMapDataCollection GetByACPanel(System.Guid ACPanelPK)
		{
			if (base.IsTrusted)
			{
				return this.Processing(this._dal.GetByACPanel(ACPanelPK));
			}

			if (!base.IsAuthorizedSelect)
			{
				return null;
			}

			return this.Processing((ACPanelHolidayMapDataCollection) base.Filter(this._dal.GetByACPanel(ACPanelPK)));
		}

		public ACPanelHolidayMapViewCollection GetViewByACPanel(System.Guid ACPanelPK)
		{
			return new ACPanelHolidayMapViewCollection(this.GetByACPanel(ACPanelPK));
		}

		protected virtual ACPanelHolidayMapData Processing(ACPanelHolidayMapData entity)
		{
			return entity;
		}

		protected virtual ACPanelHolidayMapDataCollection Processing(ACPanelHolidayMapDataCollection list)
		{
			ACPanelHolidayMapDataCollection retList = new ACPanelHolidayMapDataCollection();
			foreach(ACPanelHolidayMapData item in list)
			{
				ACPanelHolidayMapData data = this.Processing(item);
				if(data != null)
				{
					retList.Add(data);
				}
			}

			return retList;
		}

		public virtual Result Save(ACPanelHolidayMapData entity)
		{
			return base.Save(entity);
		}

		public virtual void SaveUnderTransaction(ACPanelHolidayMapData entity)
		{
			base.SaveUnderTransaction(entity);
		}

		public virtual Result Save(ACPanelHolidayMapDataCollection list)
		{
			return base.Save(list);
		}

		public virtual void SaveUnderTransaction(ACPanelHolidayMapDataCollection list)
		{
			base.SaveUnderTransaction(list);
		}


	}
	public abstract class ACTimecodeDataServiceBase : ServiceBase
	{
		protected ACTimecodeCRUD _dal;

		public ACTimecodeDataServiceBase(string connectionString, SecurityToken token) : base(connectionString, token)
		{
			this._dal = new ACTimecodeCRUD(connectionString);
			for (int i = 0; i < token.GetSortFields().Count; i++)
			{
				SortField field = token.GetSortFields()[i];
				this._dal.AddSortBy(field.FieldAlias, field.ASC);
			}
		}

		protected override string TableName
		{
			get
			{
				return "ACTimecode";
			}
		}

		protected abstract ACAccessLevelDetailDataServiceBase GetACAccessLevelDetailDataServiceBase(SecurityToken token);
		protected abstract ACTimecodeIntervalMapDataServiceBase GetACTimecodeIntervalMapDataServiceBase(SecurityToken token);

		protected override int DeleteEntity(BusinessBase entity)
		{
			ACTimecodeData data = (ACTimecodeData) entity;
			if(data == null)
				return 0;

			this.GetACAccessLevelDetailDataServiceBase(base.SecurityToken).DeleteByACTimecode(data);
			this.GetACTimecodeIntervalMapDataServiceBase(base.SecurityToken).DeleteByACTimecode(data);
			return this._dal.DeleteByPK( data.ACTimecodePK, data.RowVersion);
		}

		internal int DeleteByBDBuilding(BusinessBase entity)
		{
			BDBuildingData data = (BDBuildingData) entity;
			if(data == null)
				return 0;

			this.GetACAccessLevelDetailDataServiceBase(base.SecurityToken).DeleteByBDBuilding(entity);
			this.GetACTimecodeIntervalMapDataServiceBase(base.SecurityToken).DeleteByBDBuilding(entity);
			bool isLogDeleteEnabled = ServiceBase._DBLog.IsLogDeleteEnabled;
			bool isLinkDBDeleteEnabled = ServiceBase._DBLink.IsLinkDBDeleteEnabled;
			if (!isLogDeleteEnabled && !isLinkDBDeleteEnabled)
			{
				return this._dal.DeleteByBDBuilding(data. BDBuildingPK);
			}

			DataTable list = this._dal.GetLogByBDBuilding(data. BDBuildingPK);
			list.TableName = this._dal.TableName;
			int ret = this._dal.DeleteByBDBuilding(data. BDBuildingPK);
			if (isLogDeleteEnabled)
			{
				ServiceBase._DBLog.LogDelete(list, base.SecurityToken);
			}

			if (isLinkDBDeleteEnabled)
			{
				ServiceBase._DBLink.LinkDBDelete(list, base.TrustedToken);
			}

			return ret;
		}

		public virtual Result Purge(ACTimecodeData entity)
		{
			return base.Purge(entity);
		}

		protected override int PurgeEntity(BusinessBase entity)
		{
			ACTimecodeData data = (ACTimecodeData) entity;
			if(data == null)
				return 0;

			this.GetACAccessLevelDetailDataServiceBase(base.SecurityToken).PurgeByACTimecode(data);
			this.GetACTimecodeIntervalMapDataServiceBase(base.SecurityToken).PurgeByACTimecode(data);
			return this._dal.DeleteByPK( data.ACTimecodePK, data.RowVersion);
		}

		internal int PurgeByBDBuilding(BusinessBase entity)
		{
			BDBuildingData data = (BDBuildingData) entity;
			if(data == null)
				return 0;

			this.GetACAccessLevelDetailDataServiceBase(base.SecurityToken).PurgeByBDBuilding(entity);
			this.GetACTimecodeIntervalMapDataServiceBase(base.SecurityToken).PurgeByBDBuilding(entity);
			return this._dal.DeleteByBDBuilding(data. BDBuildingPK);
		}

		protected override int InsertEntity(BusinessBase entity)
		{
			ACTimecodeData data = (ACTimecodeData) entity;
			if(data == null)
				return 0;

			return this._dal.Insert(data);
		}

		protected override int UpdateEntity(BusinessBase entity)
		{
			ACTimecodeData data = (ACTimecodeData) entity;
			if(data == null)
				return 0;

			return this._dal.Update(data);
		}

		protected override void UpdateChildren(BusinessBase entity)
		{
			ACTimecodeData data = (ACTimecodeData) entity;
			if(data == null)
				return;

			if (data.ACAccessLevelDetailList != null)
			{
				 this.GetACAccessLevelDetailDataServiceBase(base.SecurityToken).SaveUnderTransaction(data.ACAccessLevelDetailList);
			}
			if (data.ACTimecodeIntervalMapList != null)
			{
				 this.GetACTimecodeIntervalMapDataServiceBase(base.SecurityToken).SaveUnderTransaction(data.ACTimecodeIntervalMapList);
			}
		}

		internal Result GetRowVersion(ACTimecodeDataCollection list)
		{
			return base.GetRowVersion(list);
		}

		protected override Result GetRowVersion(BusinessBase entity)
		{
			ACTimecodeData data = (ACTimecodeData) entity;
			if(data == null || !data.IsDirty)
				return new Result(true);

			Result result = new Result(true);
			if (entity.IsDeleted)
			{
				result.Add(data.ObjectID, new byte[0]);
				return result;
			}

			if (entity.IsSelfDirty)
			{
				result.Add(data.ObjectID, this._dal.GetRowVersion( data.ACTimecodePK));
			}
			if (data.ACAccessLevelDetailList != null && data.ACAccessLevelDetailList.Count > 0)
			{
				result.Add(this.GetACAccessLevelDetailDataServiceBase(base.SecurityToken).GetRowVersion(data.ACAccessLevelDetailList));
			}
			if (data.ACTimecodeIntervalMapList != null && data.ACTimecodeIntervalMapList.Count > 0)
			{
				result.Add(this.GetACTimecodeIntervalMapDataServiceBase(base.SecurityToken).GetRowVersion(data.ACTimecodeIntervalMapList));
			}
			return result;
		}

		public virtual ACTimecodeData GetByPK( System.Guid ACTimecodePK)
		{
			if (base.IsTrusted)
			{
				return this.Processing(this._dal.GetByPK( ACTimecodePK));
			}

			if (!base.IsAuthorizedSelect)
			{
				return null;
			}

			return this.Processing((ACTimecodeData) base.Filter(this._dal.GetByPK( ACTimecodePK)));
		}

		protected virtual ACTimecodeData GetEntity(string sqlWhere, SqlParameter[] paras)
		{
			if (base.IsTrusted)
			{
				return this.Processing(this._dal.GetEntityBy(sqlWhere, paras));
			}

			if (!base.IsAuthorizedSelect)
			{
				return null;
			}

			return this.Processing((ACTimecodeData) base.Filter(this._dal.GetEntityBy(sqlWhere, paras)));
		}

		public virtual ACTimecodeDataCollection GetAll()
		{
			if (base.IsTrusted)
			{
				return this.Processing(this._dal.GetAll());
			}

			if (!base.IsAuthorizedSelect)
			{
				return new ACTimecodeDataCollection();
			}

			return this.Processing((ACTimecodeDataCollection) base.Filter(this._dal.GetAll()));
		}

		public ACTimecodeViewCollection GetViewAll()
		{
			return new ACTimecodeViewCollection(this.GetAll());
		}

		protected virtual ACTimecodeDataCollection GetCollection(string sqlWhere, SqlParameter[] paras)
		{
			if (base.IsTrusted)
			{
				return this.Processing(this._dal.GetCollectionBy(sqlWhere, paras));
			}

			if (!base.IsAuthorizedSelect)
			{
				return new ACTimecodeDataCollection();
			}

			 return this.Processing((ACTimecodeDataCollection) base.Filter(this._dal.GetCollectionBy(sqlWhere, paras)));
		}

		public virtual ACTimecodeDataCollection GetByBDBuilding(System.Guid BDBuildingPK)
		{
			if (base.IsTrusted)
			{
				return this.Processing(this._dal.GetByBDBuilding(BDBuildingPK));
			}

			if (!base.IsAuthorizedSelect)
			{
				return null;
			}

			return this.Processing((ACTimecodeDataCollection) base.Filter(this._dal.GetByBDBuilding(BDBuildingPK)));
		}

		public ACTimecodeViewCollection GetViewByBDBuilding(System.Guid BDBuildingPK)
		{
			return new ACTimecodeViewCollection(this.GetByBDBuilding(BDBuildingPK));
		}

		protected virtual ACTimecodeData Processing(ACTimecodeData entity)
		{
			return entity;
		}

		protected virtual ACTimecodeDataCollection Processing(ACTimecodeDataCollection list)
		{
			ACTimecodeDataCollection retList = new ACTimecodeDataCollection();
			foreach(ACTimecodeData item in list)
			{
				ACTimecodeData data = this.Processing(item);
				if(data != null)
				{
					retList.Add(data);
				}
			}

			return retList;
		}

		public virtual Result Save(ACTimecodeData entity)
		{
			return base.Save(entity);
		}

		public virtual void SaveUnderTransaction(ACTimecodeData entity)
		{
			base.SaveUnderTransaction(entity);
		}

		public virtual Result Save(ACTimecodeDataCollection list)
		{
			return base.Save(list);
		}

		public virtual void SaveUnderTransaction(ACTimecodeDataCollection list)
		{
			base.SaveUnderTransaction(list);
		}


	}
	public abstract class ACTimecodeIntervalMapDataServiceBase : ServiceBase
	{
		protected ACTimecodeIntervalMapCRUD _dal;

		public ACTimecodeIntervalMapDataServiceBase(string connectionString, SecurityToken token) : base(connectionString, token)
		{
			this._dal = new ACTimecodeIntervalMapCRUD(connectionString);
			for (int i = 0; i < token.GetSortFields().Count; i++)
			{
				SortField field = token.GetSortFields()[i];
				this._dal.AddSortBy(field.FieldAlias, field.ASC);
			}
		}

		protected override string TableName
		{
			get
			{
				return "ACTimecodeIntervalMap";
			}
		}


		protected override int DeleteEntity(BusinessBase entity)
		{
			ACTimecodeIntervalMapData data = (ACTimecodeIntervalMapData) entity;
			if(data == null)
				return 0;

			return this._dal.DeleteByPK( data.ACTimecodeIntervalMapPK, data.RowVersion);
		}

		internal int DeleteByACInterval(BusinessBase entity)
		{
			ACIntervalData data = (ACIntervalData) entity;
			if(data == null)
				return 0;

			bool isLogDeleteEnabled = ServiceBase._DBLog.IsLogDeleteEnabled;
			bool isLinkDBDeleteEnabled = ServiceBase._DBLink.IsLinkDBDeleteEnabled;
			if (!isLogDeleteEnabled && !isLinkDBDeleteEnabled)
			{
				return this._dal.DeleteByACInterval(data. ACIntervalPK);
			}

			DataTable list = this._dal.GetLogByACInterval(data. ACIntervalPK);
			list.TableName = this._dal.TableName;
			int ret = this._dal.DeleteByACInterval(data. ACIntervalPK);
			if (isLogDeleteEnabled)
			{
				ServiceBase._DBLog.LogDelete(list, base.SecurityToken);
			}

			if (isLinkDBDeleteEnabled)
			{
				ServiceBase._DBLink.LinkDBDelete(list, base.TrustedToken);
			}

			return ret;
		}

		internal int DeleteByBDBuilding(BusinessBase entity)
		{
			BDBuildingData data = (BDBuildingData) entity;
			if(data == null)
				return 0;

			bool isLogDeleteEnabled = ServiceBase._DBLog.IsLogDeleteEnabled;
			bool isLinkDBDeleteEnabled = ServiceBase._DBLink.IsLinkDBDeleteEnabled;
			if (!isLogDeleteEnabled && !isLinkDBDeleteEnabled)
			{
				return this._dal.DeleteByBDBuilding(data. BDBuildingPK);
			}

			DataTable list = this._dal.GetLogByBDBuilding(data. BDBuildingPK);
			list.TableName = this._dal.TableName;
			int ret = this._dal.DeleteByBDBuilding(data. BDBuildingPK);
			if (isLogDeleteEnabled)
			{
				ServiceBase._DBLog.LogDelete(list, base.SecurityToken);
			}

			if (isLinkDBDeleteEnabled)
			{
				ServiceBase._DBLink.LinkDBDelete(list, base.TrustedToken);
			}

			return ret;
		}

		internal int DeleteByACTimecode(BusinessBase entity)
		{
			ACTimecodeData data = (ACTimecodeData) entity;
			if(data == null)
				return 0;

			bool isLogDeleteEnabled = ServiceBase._DBLog.IsLogDeleteEnabled;
			bool isLinkDBDeleteEnabled = ServiceBase._DBLink.IsLinkDBDeleteEnabled;
			if (!isLogDeleteEnabled && !isLinkDBDeleteEnabled)
			{
				return this._dal.DeleteByACTimecode(data. ACTimecodePK);
			}

			DataTable list = this._dal.GetLogByACTimecode(data. ACTimecodePK);
			list.TableName = this._dal.TableName;
			int ret = this._dal.DeleteByACTimecode(data. ACTimecodePK);
			if (isLogDeleteEnabled)
			{
				ServiceBase._DBLog.LogDelete(list, base.SecurityToken);
			}

			if (isLinkDBDeleteEnabled)
			{
				ServiceBase._DBLink.LinkDBDelete(list, base.TrustedToken);
			}

			return ret;
		}

		public virtual Result Purge(ACTimecodeIntervalMapData entity)
		{
			return base.Purge(entity);
		}

		protected override int PurgeEntity(BusinessBase entity)
		{
			ACTimecodeIntervalMapData data = (ACTimecodeIntervalMapData) entity;
			if(data == null)
				return 0;

			return this._dal.DeleteByPK( data.ACTimecodeIntervalMapPK, data.RowVersion);
		}

		internal int PurgeByACInterval(BusinessBase entity)
		{
			ACIntervalData data = (ACIntervalData) entity;
			if(data == null)
				return 0;

			return this._dal.DeleteByACInterval(data. ACIntervalPK);
		}

		internal int PurgeByBDBuilding(BusinessBase entity)
		{
			BDBuildingData data = (BDBuildingData) entity;
			if(data == null)
				return 0;

			return this._dal.DeleteByBDBuilding(data. BDBuildingPK);
		}

		internal int PurgeByACTimecode(BusinessBase entity)
		{
			ACTimecodeData data = (ACTimecodeData) entity;
			if(data == null)
				return 0;

			return this._dal.DeleteByACTimecode(data. ACTimecodePK);
		}

		protected override int InsertEntity(BusinessBase entity)
		{
			ACTimecodeIntervalMapData data = (ACTimecodeIntervalMapData) entity;
			if(data == null)
				return 0;

			return this._dal.Insert(data);
		}

		protected override int UpdateEntity(BusinessBase entity)
		{
			ACTimecodeIntervalMapData data = (ACTimecodeIntervalMapData) entity;
			if(data == null)
				return 0;

			return this._dal.Update(data);
		}

		protected override void UpdateChildren(BusinessBase entity)
		{
			ACTimecodeIntervalMapData data = (ACTimecodeIntervalMapData) entity;
			if(data == null)
				return;

		}

		internal Result GetRowVersion(ACTimecodeIntervalMapDataCollection list)
		{
			return base.GetRowVersion(list);
		}

		protected override Result GetRowVersion(BusinessBase entity)
		{
			ACTimecodeIntervalMapData data = (ACTimecodeIntervalMapData) entity;
			if(data == null || !data.IsDirty)
				return new Result(true);

			Result result = new Result(true);
			if (entity.IsDeleted)
			{
				result.Add(data.ObjectID, new byte[0]);
				return result;
			}

			if (entity.IsSelfDirty)
			{
				result.Add(data.ObjectID, this._dal.GetRowVersion( data.ACTimecodeIntervalMapPK));
			}
			return result;
		}

		public virtual ACTimecodeIntervalMapData GetByPK( System.Guid ACTimecodeIntervalMapPK)
		{
			if (base.IsTrusted)
			{
				return this.Processing(this._dal.GetByPK( ACTimecodeIntervalMapPK));
			}

			if (!base.IsAuthorizedSelect)
			{
				return null;
			}

			return this.Processing((ACTimecodeIntervalMapData) base.Filter(this._dal.GetByPK( ACTimecodeIntervalMapPK)));
		}

		protected virtual ACTimecodeIntervalMapData GetEntity(string sqlWhere, SqlParameter[] paras)
		{
			if (base.IsTrusted)
			{
				return this.Processing(this._dal.GetEntityBy(sqlWhere, paras));
			}

			if (!base.IsAuthorizedSelect)
			{
				return null;
			}

			return this.Processing((ACTimecodeIntervalMapData) base.Filter(this._dal.GetEntityBy(sqlWhere, paras)));
		}

		public virtual ACTimecodeIntervalMapDataCollection GetAll()
		{
			if (base.IsTrusted)
			{
				return this.Processing(this._dal.GetAll());
			}

			if (!base.IsAuthorizedSelect)
			{
				return new ACTimecodeIntervalMapDataCollection();
			}

			return this.Processing((ACTimecodeIntervalMapDataCollection) base.Filter(this._dal.GetAll()));
		}

		public ACTimecodeIntervalMapViewCollection GetViewAll()
		{
			return new ACTimecodeIntervalMapViewCollection(this.GetAll());
		}

		protected virtual ACTimecodeIntervalMapDataCollection GetCollection(string sqlWhere, SqlParameter[] paras)
		{
			if (base.IsTrusted)
			{
				return this.Processing(this._dal.GetCollectionBy(sqlWhere, paras));
			}

			if (!base.IsAuthorizedSelect)
			{
				return new ACTimecodeIntervalMapDataCollection();
			}

			 return this.Processing((ACTimecodeIntervalMapDataCollection) base.Filter(this._dal.GetCollectionBy(sqlWhere, paras)));
		}

		public virtual ACTimecodeIntervalMapDataCollection GetByACInterval(System.Guid ACIntervalPK)
		{
			if (base.IsTrusted)
			{
				return this.Processing(this._dal.GetByACInterval(ACIntervalPK));
			}

			if (!base.IsAuthorizedSelect)
			{
				return null;
			}

			return this.Processing((ACTimecodeIntervalMapDataCollection) base.Filter(this._dal.GetByACInterval(ACIntervalPK)));
		}

		public ACTimecodeIntervalMapViewCollection GetViewByACInterval(System.Guid ACIntervalPK)
		{
			return new ACTimecodeIntervalMapViewCollection(this.GetByACInterval(ACIntervalPK));
		}

		public virtual ACTimecodeIntervalMapDataCollection GetByACTimecode(System.Guid ACTimecodePK)
		{
			if (base.IsTrusted)
			{
				return this.Processing(this._dal.GetByACTimecode(ACTimecodePK));
			}

			if (!base.IsAuthorizedSelect)
			{
				return null;
			}

			return this.Processing((ACTimecodeIntervalMapDataCollection) base.Filter(this._dal.GetByACTimecode(ACTimecodePK)));
		}

		public ACTimecodeIntervalMapViewCollection GetViewByACTimecode(System.Guid ACTimecodePK)
		{
			return new ACTimecodeIntervalMapViewCollection(this.GetByACTimecode(ACTimecodePK));
		}

		protected virtual ACTimecodeIntervalMapData Processing(ACTimecodeIntervalMapData entity)
		{
			return entity;
		}

		protected virtual ACTimecodeIntervalMapDataCollection Processing(ACTimecodeIntervalMapDataCollection list)
		{
			ACTimecodeIntervalMapDataCollection retList = new ACTimecodeIntervalMapDataCollection();
			foreach(ACTimecodeIntervalMapData item in list)
			{
				ACTimecodeIntervalMapData data = this.Processing(item);
				if(data != null)
				{
					retList.Add(data);
				}
			}

			return retList;
		}

		public virtual Result Save(ACTimecodeIntervalMapData entity)
		{
			return base.Save(entity);
		}

		public virtual void SaveUnderTransaction(ACTimecodeIntervalMapData entity)
		{
			base.SaveUnderTransaction(entity);
		}

		public virtual Result Save(ACTimecodeIntervalMapDataCollection list)
		{
			return base.Save(list);
		}

		public virtual void SaveUnderTransaction(ACTimecodeIntervalMapDataCollection list)
		{
			base.SaveUnderTransaction(list);
		}


	}
	public abstract class ACAMFormatDataServiceBase : ServiceBase
	{
		protected ACAMFormatCRUD _dal;

		public ACAMFormatDataServiceBase(string connectionString, SecurityToken token) : base(connectionString, token)
		{
			this._dal = new ACAMFormatCRUD(connectionString);
			for (int i = 0; i < token.GetSortFields().Count; i++)
			{
				SortField field = token.GetSortFields()[i];
				this._dal.AddSortBy(field.FieldAlias, field.ASC);
			}
		}

		protected override string TableName
		{
			get
			{
				return "ACAMFormat";
			}
		}


		protected override int DeleteEntity(BusinessBase entity)
		{
			ACAMFormatData data = (ACAMFormatData) entity;
			if(data == null)
				return 0;

			return this._dal.DeleteByPK( data.ACAMFormatPK, data.RowVersion);
		}

		internal int DeleteByBDBuilding(BusinessBase entity)
		{
			BDBuildingData data = (BDBuildingData) entity;
			if(data == null)
				return 0;

			bool isLogDeleteEnabled = ServiceBase._DBLog.IsLogDeleteEnabled;
			bool isLinkDBDeleteEnabled = ServiceBase._DBLink.IsLinkDBDeleteEnabled;
			if (!isLogDeleteEnabled && !isLinkDBDeleteEnabled)
			{
				return this._dal.DeleteByBDBuilding(data. BDBuildingPK);
			}

			DataTable list = this._dal.GetLogByBDBuilding(data. BDBuildingPK);
			list.TableName = this._dal.TableName;
			int ret = this._dal.DeleteByBDBuilding(data. BDBuildingPK);
			if (isLogDeleteEnabled)
			{
				ServiceBase._DBLog.LogDelete(list, base.SecurityToken);
			}

			if (isLinkDBDeleteEnabled)
			{
				ServiceBase._DBLink.LinkDBDelete(list, base.TrustedToken);
			}

			return ret;
		}

		public virtual Result Purge(ACAMFormatData entity)
		{
			return base.Purge(entity);
		}

		protected override int PurgeEntity(BusinessBase entity)
		{
			ACAMFormatData data = (ACAMFormatData) entity;
			if(data == null)
				return 0;

			return this._dal.DeleteByPK( data.ACAMFormatPK, data.RowVersion);
		}

		internal int PurgeByBDBuilding(BusinessBase entity)
		{
			BDBuildingData data = (BDBuildingData) entity;
			if(data == null)
				return 0;

			return this._dal.DeleteByBDBuilding(data. BDBuildingPK);
		}

		protected override int InsertEntity(BusinessBase entity)
		{
			ACAMFormatData data = (ACAMFormatData) entity;
			if(data == null)
				return 0;

			return this._dal.Insert(data);
		}

		protected override int UpdateEntity(BusinessBase entity)
		{
			ACAMFormatData data = (ACAMFormatData) entity;
			if(data == null)
				return 0;

			return this._dal.Update(data);
		}

		protected override void UpdateChildren(BusinessBase entity)
		{
			ACAMFormatData data = (ACAMFormatData) entity;
			if(data == null)
				return;

		}

		internal Result GetRowVersion(ACAMFormatDataCollection list)
		{
			return base.GetRowVersion(list);
		}

		protected override Result GetRowVersion(BusinessBase entity)
		{
			ACAMFormatData data = (ACAMFormatData) entity;
			if(data == null || !data.IsDirty)
				return new Result(true);

			Result result = new Result(true);
			if (entity.IsDeleted)
			{
				result.Add(data.ObjectID, new byte[0]);
				return result;
			}

			if (entity.IsSelfDirty)
			{
				result.Add(data.ObjectID, this._dal.GetRowVersion( data.ACAMFormatPK));
			}
			return result;
		}

		public virtual ACAMFormatData GetByPK( System.Guid ACAMFormatPK)
		{
			if (base.IsTrusted)
			{
				return this.Processing(this._dal.GetByPK( ACAMFormatPK));
			}

			if (!base.IsAuthorizedSelect)
			{
				return null;
			}

			return this.Processing((ACAMFormatData) base.Filter(this._dal.GetByPK( ACAMFormatPK)));
		}

		protected virtual ACAMFormatData GetEntity(string sqlWhere, SqlParameter[] paras)
		{
			if (base.IsTrusted)
			{
				return this.Processing(this._dal.GetEntityBy(sqlWhere, paras));
			}

			if (!base.IsAuthorizedSelect)
			{
				return null;
			}

			return this.Processing((ACAMFormatData) base.Filter(this._dal.GetEntityBy(sqlWhere, paras)));
		}

		public virtual ACAMFormatDataCollection GetAll()
		{
			if (base.IsTrusted)
			{
				return this.Processing(this._dal.GetAll());
			}

			if (!base.IsAuthorizedSelect)
			{
				return new ACAMFormatDataCollection();
			}

			return this.Processing((ACAMFormatDataCollection) base.Filter(this._dal.GetAll()));
		}

		public ACAMFormatViewCollection GetViewAll()
		{
			return new ACAMFormatViewCollection(this.GetAll());
		}

		protected virtual ACAMFormatDataCollection GetCollection(string sqlWhere, SqlParameter[] paras)
		{
			if (base.IsTrusted)
			{
				return this.Processing(this._dal.GetCollectionBy(sqlWhere, paras));
			}

			if (!base.IsAuthorizedSelect)
			{
				return new ACAMFormatDataCollection();
			}

			 return this.Processing((ACAMFormatDataCollection) base.Filter(this._dal.GetCollectionBy(sqlWhere, paras)));
		}

		public virtual ACAMFormatDataCollection GetByBDBuilding(System.Guid BDBuildingPK)
		{
			if (base.IsTrusted)
			{
				return this.Processing(this._dal.GetByBDBuilding(BDBuildingPK));
			}

			if (!base.IsAuthorizedSelect)
			{
				return null;
			}

			return this.Processing((ACAMFormatDataCollection) base.Filter(this._dal.GetByBDBuilding(BDBuildingPK)));
		}

		public ACAMFormatViewCollection GetViewByBDBuilding(System.Guid BDBuildingPK)
		{
			return new ACAMFormatViewCollection(this.GetByBDBuilding(BDBuildingPK));
		}

		protected virtual ACAMFormatData Processing(ACAMFormatData entity)
		{
			return entity;
		}

		protected virtual ACAMFormatDataCollection Processing(ACAMFormatDataCollection list)
		{
			ACAMFormatDataCollection retList = new ACAMFormatDataCollection();
			foreach(ACAMFormatData item in list)
			{
				ACAMFormatData data = this.Processing(item);
				if(data != null)
				{
					retList.Add(data);
				}
			}

			return retList;
		}

		public virtual Result Save(ACAMFormatData entity)
		{
			return base.Save(entity);
		}

		public virtual void SaveUnderTransaction(ACAMFormatData entity)
		{
			base.SaveUnderTransaction(entity);
		}

		public virtual Result Save(ACAMFormatDataCollection list)
		{
			return base.Save(list);
		}

		public virtual void SaveUnderTransaction(ACAMFormatDataCollection list)
		{
			base.SaveUnderTransaction(list);
		}


	}
	public abstract class BDBuildingHolidayMapDataServiceBase : ServiceBase
	{
		protected BDBuildingHolidayMapCRUD _dal;

		public BDBuildingHolidayMapDataServiceBase(string connectionString, SecurityToken token) : base(connectionString, token)
		{
			this._dal = new BDBuildingHolidayMapCRUD(connectionString);
			for (int i = 0; i < token.GetSortFields().Count; i++)
			{
				SortField field = token.GetSortFields()[i];
				this._dal.AddSortBy(field.FieldAlias, field.ASC);
			}
		}

		protected override string TableName
		{
			get
			{
				return "BDBuildingHolidayMap";
			}
		}


		protected override int DeleteEntity(BusinessBase entity)
		{
			BDBuildingHolidayMapData data = (BDBuildingHolidayMapData) entity;
			if(data == null)
				return 0;

			return this._dal.DeleteByPK( data.BDBuildingHolidayMapPK, data.RowVersion);
		}

		internal int DeleteByBDBuilding(BusinessBase entity)
		{
			BDBuildingData data = (BDBuildingData) entity;
			if(data == null)
				return 0;

			bool isLogDeleteEnabled = ServiceBase._DBLog.IsLogDeleteEnabled;
			bool isLinkDBDeleteEnabled = ServiceBase._DBLink.IsLinkDBDeleteEnabled;
			if (!isLogDeleteEnabled && !isLinkDBDeleteEnabled)
			{
				return this._dal.DeleteByBDBuilding(data. BDBuildingPK);
			}

			DataTable list = this._dal.GetLogByBDBuilding(data. BDBuildingPK);
			list.TableName = this._dal.TableName;
			int ret = this._dal.DeleteByBDBuilding(data. BDBuildingPK);
			if (isLogDeleteEnabled)
			{
				ServiceBase._DBLog.LogDelete(list, base.SecurityToken);
			}

			if (isLinkDBDeleteEnabled)
			{
				ServiceBase._DBLink.LinkDBDelete(list, base.TrustedToken);
			}

			return ret;
		}

		internal int DeleteByUtilHoliday(BusinessBase entity)
		{
			UtilHolidayData data = (UtilHolidayData) entity;
			if(data == null)
				return 0;

			bool isLogDeleteEnabled = ServiceBase._DBLog.IsLogDeleteEnabled;
			bool isLinkDBDeleteEnabled = ServiceBase._DBLink.IsLinkDBDeleteEnabled;
			if (!isLogDeleteEnabled && !isLinkDBDeleteEnabled)
			{
				return this._dal.DeleteByUtilHoliday(data. UtilHolidayPK);
			}

			DataTable list = this._dal.GetLogByUtilHoliday(data. UtilHolidayPK);
			list.TableName = this._dal.TableName;
			int ret = this._dal.DeleteByUtilHoliday(data. UtilHolidayPK);
			if (isLogDeleteEnabled)
			{
				ServiceBase._DBLog.LogDelete(list, base.SecurityToken);
			}

			if (isLinkDBDeleteEnabled)
			{
				ServiceBase._DBLink.LinkDBDelete(list, base.TrustedToken);
			}

			return ret;
		}

		public virtual Result Purge(BDBuildingHolidayMapData entity)
		{
			return base.Purge(entity);
		}

		protected override int PurgeEntity(BusinessBase entity)
		{
			BDBuildingHolidayMapData data = (BDBuildingHolidayMapData) entity;
			if(data == null)
				return 0;

			return this._dal.DeleteByPK( data.BDBuildingHolidayMapPK, data.RowVersion);
		}

		internal int PurgeByBDBuilding(BusinessBase entity)
		{
			BDBuildingData data = (BDBuildingData) entity;
			if(data == null)
				return 0;

			return this._dal.DeleteByBDBuilding(data. BDBuildingPK);
		}

		internal int PurgeByUtilHoliday(BusinessBase entity)
		{
			UtilHolidayData data = (UtilHolidayData) entity;
			if(data == null)
				return 0;

			return this._dal.DeleteByUtilHoliday(data. UtilHolidayPK);
		}

		protected override int InsertEntity(BusinessBase entity)
		{
			BDBuildingHolidayMapData data = (BDBuildingHolidayMapData) entity;
			if(data == null)
				return 0;

			return this._dal.Insert(data);
		}

		protected override int UpdateEntity(BusinessBase entity)
		{
			BDBuildingHolidayMapData data = (BDBuildingHolidayMapData) entity;
			if(data == null)
				return 0;

			return this._dal.Update(data);
		}

		protected override void UpdateChildren(BusinessBase entity)
		{
			BDBuildingHolidayMapData data = (BDBuildingHolidayMapData) entity;
			if(data == null)
				return;

		}

		internal Result GetRowVersion(BDBuildingHolidayMapDataCollection list)
		{
			return base.GetRowVersion(list);
		}

		protected override Result GetRowVersion(BusinessBase entity)
		{
			BDBuildingHolidayMapData data = (BDBuildingHolidayMapData) entity;
			if(data == null || !data.IsDirty)
				return new Result(true);

			Result result = new Result(true);
			if (entity.IsDeleted)
			{
				result.Add(data.ObjectID, new byte[0]);
				return result;
			}

			if (entity.IsSelfDirty)
			{
				result.Add(data.ObjectID, this._dal.GetRowVersion( data.BDBuildingHolidayMapPK));
			}
			return result;
		}

		public virtual BDBuildingHolidayMapData GetByPK( System.Guid BDBuildingHolidayMapPK)
		{
			if (base.IsTrusted)
			{
				return this.Processing(this._dal.GetByPK( BDBuildingHolidayMapPK));
			}

			if (!base.IsAuthorizedSelect)
			{
				return null;
			}

			return this.Processing((BDBuildingHolidayMapData) base.Filter(this._dal.GetByPK( BDBuildingHolidayMapPK)));
		}

		protected virtual BDBuildingHolidayMapData GetEntity(string sqlWhere, SqlParameter[] paras)
		{
			if (base.IsTrusted)
			{
				return this.Processing(this._dal.GetEntityBy(sqlWhere, paras));
			}

			if (!base.IsAuthorizedSelect)
			{
				return null;
			}

			return this.Processing((BDBuildingHolidayMapData) base.Filter(this._dal.GetEntityBy(sqlWhere, paras)));
		}

		public virtual BDBuildingHolidayMapDataCollection GetAll()
		{
			if (base.IsTrusted)
			{
				return this.Processing(this._dal.GetAll());
			}

			if (!base.IsAuthorizedSelect)
			{
				return new BDBuildingHolidayMapDataCollection();
			}

			return this.Processing((BDBuildingHolidayMapDataCollection) base.Filter(this._dal.GetAll()));
		}

		public BDBuildingHolidayMapViewCollection GetViewAll()
		{
			return new BDBuildingHolidayMapViewCollection(this.GetAll());
		}

		protected virtual BDBuildingHolidayMapDataCollection GetCollection(string sqlWhere, SqlParameter[] paras)
		{
			if (base.IsTrusted)
			{
				return this.Processing(this._dal.GetCollectionBy(sqlWhere, paras));
			}

			if (!base.IsAuthorizedSelect)
			{
				return new BDBuildingHolidayMapDataCollection();
			}

			 return this.Processing((BDBuildingHolidayMapDataCollection) base.Filter(this._dal.GetCollectionBy(sqlWhere, paras)));
		}

		public virtual BDBuildingHolidayMapDataCollection GetByBDBuilding(System.Guid BDBuildingPK)
		{
			if (base.IsTrusted)
			{
				return this.Processing(this._dal.GetByBDBuilding(BDBuildingPK));
			}

			if (!base.IsAuthorizedSelect)
			{
				return null;
			}

			return this.Processing((BDBuildingHolidayMapDataCollection) base.Filter(this._dal.GetByBDBuilding(BDBuildingPK)));
		}

		public BDBuildingHolidayMapViewCollection GetViewByBDBuilding(System.Guid BDBuildingPK)
		{
			return new BDBuildingHolidayMapViewCollection(this.GetByBDBuilding(BDBuildingPK));
		}

		public virtual BDBuildingHolidayMapDataCollection GetByUtilHoliday(System.Guid UtilHolidayPK)
		{
			if (base.IsTrusted)
			{
				return this.Processing(this._dal.GetByUtilHoliday(UtilHolidayPK));
			}

			if (!base.IsAuthorizedSelect)
			{
				return null;
			}

			return this.Processing((BDBuildingHolidayMapDataCollection) base.Filter(this._dal.GetByUtilHoliday(UtilHolidayPK)));
		}

		public BDBuildingHolidayMapViewCollection GetViewByUtilHoliday(System.Guid UtilHolidayPK)
		{
			return new BDBuildingHolidayMapViewCollection(this.GetByUtilHoliday(UtilHolidayPK));
		}

		protected virtual BDBuildingHolidayMapData Processing(BDBuildingHolidayMapData entity)
		{
			return entity;
		}

		protected virtual BDBuildingHolidayMapDataCollection Processing(BDBuildingHolidayMapDataCollection list)
		{
			BDBuildingHolidayMapDataCollection retList = new BDBuildingHolidayMapDataCollection();
			foreach(BDBuildingHolidayMapData item in list)
			{
				BDBuildingHolidayMapData data = this.Processing(item);
				if(data != null)
				{
					retList.Add(data);
				}
			}

			return retList;
		}

		public virtual Result Save(BDBuildingHolidayMapData entity)
		{
			return base.Save(entity);
		}

		public virtual void SaveUnderTransaction(BDBuildingHolidayMapData entity)
		{
			base.SaveUnderTransaction(entity);
		}

		public virtual Result Save(BDBuildingHolidayMapDataCollection list)
		{
			return base.Save(list);
		}

		public virtual void SaveUnderTransaction(BDBuildingHolidayMapDataCollection list)
		{
			base.SaveUnderTransaction(list);
		}


	}
	public abstract class ACOutputGroupDataServiceBase : ServiceBase
	{
		protected ACOutputGroupCRUD _dal;

		public ACOutputGroupDataServiceBase(string connectionString, SecurityToken token) : base(connectionString, token)
		{
			this._dal = new ACOutputGroupCRUD(connectionString);
			for (int i = 0; i < token.GetSortFields().Count; i++)
			{
				SortField field = token.GetSortFields()[i];
				this._dal.AddSortBy(field.FieldAlias, field.ASC);
			}
		}

		protected override string TableName
		{
			get
			{
				return "ACOutputGroup";
			}
		}

		protected abstract ACOutputGroupMainZoneMapDataServiceBase GetACOutputGroupMainZoneMapDataServiceBase(SecurityToken token);

		protected override int DeleteEntity(BusinessBase entity)
		{
			ACOutputGroupData data = (ACOutputGroupData) entity;
			if(data == null)
				return 0;

			this.GetACOutputGroupMainZoneMapDataServiceBase(base.SecurityToken).DeleteByACOutputGroup(data);
			return this._dal.DeleteByPK( data.ACOutputGroupPK, data.RowVersion);
		}

		internal int DeleteByACPanel(BusinessBase entity)
		{
			ACPanelData data = (ACPanelData) entity;
			if(data == null)
				return 0;

			this.GetACOutputGroupMainZoneMapDataServiceBase(base.SecurityToken).DeleteByACPanel(entity);
			bool isLogDeleteEnabled = ServiceBase._DBLog.IsLogDeleteEnabled;
			bool isLinkDBDeleteEnabled = ServiceBase._DBLink.IsLinkDBDeleteEnabled;
			if (!isLogDeleteEnabled && !isLinkDBDeleteEnabled)
			{
				return this._dal.DeleteByACPanel(data. ACPanelPK);
			}

			DataTable list = this._dal.GetLogByACPanel(data. ACPanelPK);
			list.TableName = this._dal.TableName;
			int ret = this._dal.DeleteByACPanel(data. ACPanelPK);
			if (isLogDeleteEnabled)
			{
				ServiceBase._DBLog.LogDelete(list, base.SecurityToken);
			}

			if (isLinkDBDeleteEnabled)
			{
				ServiceBase._DBLink.LinkDBDelete(list, base.TrustedToken);
			}

			return ret;
		}

		internal int DeleteByBDBuilding(BusinessBase entity)
		{
			BDBuildingData data = (BDBuildingData) entity;
			if(data == null)
				return 0;

			this.GetACOutputGroupMainZoneMapDataServiceBase(base.SecurityToken).DeleteByBDBuilding(entity);
			bool isLogDeleteEnabled = ServiceBase._DBLog.IsLogDeleteEnabled;
			bool isLinkDBDeleteEnabled = ServiceBase._DBLink.IsLinkDBDeleteEnabled;
			if (!isLogDeleteEnabled && !isLinkDBDeleteEnabled)
			{
				return this._dal.DeleteByBDBuilding(data. BDBuildingPK);
			}

			DataTable list = this._dal.GetLogByBDBuilding(data. BDBuildingPK);
			list.TableName = this._dal.TableName;
			int ret = this._dal.DeleteByBDBuilding(data. BDBuildingPK);
			if (isLogDeleteEnabled)
			{
				ServiceBase._DBLog.LogDelete(list, base.SecurityToken);
			}

			if (isLinkDBDeleteEnabled)
			{
				ServiceBase._DBLink.LinkDBDelete(list, base.TrustedToken);
			}

			return ret;
		}

		public virtual Result Purge(ACOutputGroupData entity)
		{
			return base.Purge(entity);
		}

		protected override int PurgeEntity(BusinessBase entity)
		{
			ACOutputGroupData data = (ACOutputGroupData) entity;
			if(data == null)
				return 0;

			this.GetACOutputGroupMainZoneMapDataServiceBase(base.SecurityToken).PurgeByACOutputGroup(data);
			return this._dal.DeleteByPK( data.ACOutputGroupPK, data.RowVersion);
		}

		internal int PurgeByACPanel(BusinessBase entity)
		{
			ACPanelData data = (ACPanelData) entity;
			if(data == null)
				return 0;

			this.GetACOutputGroupMainZoneMapDataServiceBase(base.SecurityToken).PurgeByACPanel(entity);
			return this._dal.DeleteByACPanel(data. ACPanelPK);
		}

		internal int PurgeByBDBuilding(BusinessBase entity)
		{
			BDBuildingData data = (BDBuildingData) entity;
			if(data == null)
				return 0;

			this.GetACOutputGroupMainZoneMapDataServiceBase(base.SecurityToken).PurgeByBDBuilding(entity);
			return this._dal.DeleteByBDBuilding(data. BDBuildingPK);
		}

		protected override int InsertEntity(BusinessBase entity)
		{
			ACOutputGroupData data = (ACOutputGroupData) entity;
			if(data == null)
				return 0;

			return this._dal.Insert(data);
		}

		protected override int UpdateEntity(BusinessBase entity)
		{
			ACOutputGroupData data = (ACOutputGroupData) entity;
			if(data == null)
				return 0;

			return this._dal.Update(data);
		}

		protected override void UpdateChildren(BusinessBase entity)
		{
			ACOutputGroupData data = (ACOutputGroupData) entity;
			if(data == null)
				return;

			if (data.ACOutputGroupMainZoneMapList != null)
			{
				 this.GetACOutputGroupMainZoneMapDataServiceBase(base.SecurityToken).SaveUnderTransaction(data.ACOutputGroupMainZoneMapList);
			}
		}

		internal Result GetRowVersion(ACOutputGroupDataCollection list)
		{
			return base.GetRowVersion(list);
		}

		protected override Result GetRowVersion(BusinessBase entity)
		{
			ACOutputGroupData data = (ACOutputGroupData) entity;
			if(data == null || !data.IsDirty)
				return new Result(true);

			Result result = new Result(true);
			if (entity.IsDeleted)
			{
				result.Add(data.ObjectID, new byte[0]);
				return result;
			}

			if (entity.IsSelfDirty)
			{
				result.Add(data.ObjectID, this._dal.GetRowVersion( data.ACOutputGroupPK));
			}
			if (data.ACOutputGroupMainZoneMapList != null && data.ACOutputGroupMainZoneMapList.Count > 0)
			{
				result.Add(this.GetACOutputGroupMainZoneMapDataServiceBase(base.SecurityToken).GetRowVersion(data.ACOutputGroupMainZoneMapList));
			}
			return result;
		}

		public virtual ACOutputGroupData GetByPK( System.Guid ACOutputGroupPK)
		{
			if (base.IsTrusted)
			{
				return this.Processing(this._dal.GetByPK( ACOutputGroupPK));
			}

			if (!base.IsAuthorizedSelect)
			{
				return null;
			}

			return this.Processing((ACOutputGroupData) base.Filter(this._dal.GetByPK( ACOutputGroupPK)));
		}

		protected virtual ACOutputGroupData GetEntity(string sqlWhere, SqlParameter[] paras)
		{
			if (base.IsTrusted)
			{
				return this.Processing(this._dal.GetEntityBy(sqlWhere, paras));
			}

			if (!base.IsAuthorizedSelect)
			{
				return null;
			}

			return this.Processing((ACOutputGroupData) base.Filter(this._dal.GetEntityBy(sqlWhere, paras)));
		}

		public virtual ACOutputGroupDataCollection GetAll()
		{
			if (base.IsTrusted)
			{
				return this.Processing(this._dal.GetAll());
			}

			if (!base.IsAuthorizedSelect)
			{
				return new ACOutputGroupDataCollection();
			}

			return this.Processing((ACOutputGroupDataCollection) base.Filter(this._dal.GetAll()));
		}

		public ACOutputGroupViewCollection GetViewAll()
		{
			return new ACOutputGroupViewCollection(this.GetAll());
		}

		protected virtual ACOutputGroupDataCollection GetCollection(string sqlWhere, SqlParameter[] paras)
		{
			if (base.IsTrusted)
			{
				return this.Processing(this._dal.GetCollectionBy(sqlWhere, paras));
			}

			if (!base.IsAuthorizedSelect)
			{
				return new ACOutputGroupDataCollection();
			}

			 return this.Processing((ACOutputGroupDataCollection) base.Filter(this._dal.GetCollectionBy(sqlWhere, paras)));
		}

		public virtual ACOutputGroupDataCollection GetByACPanel(System.Guid ACPanelPK)
		{
			if (base.IsTrusted)
			{
				return this.Processing(this._dal.GetByACPanel(ACPanelPK));
			}

			if (!base.IsAuthorizedSelect)
			{
				return null;
			}

			return this.Processing((ACOutputGroupDataCollection) base.Filter(this._dal.GetByACPanel(ACPanelPK)));
		}

		public ACOutputGroupViewCollection GetViewByACPanel(System.Guid ACPanelPK)
		{
			return new ACOutputGroupViewCollection(this.GetByACPanel(ACPanelPK));
		}

		protected virtual ACOutputGroupData Processing(ACOutputGroupData entity)
		{
			return entity;
		}

		protected virtual ACOutputGroupDataCollection Processing(ACOutputGroupDataCollection list)
		{
			ACOutputGroupDataCollection retList = new ACOutputGroupDataCollection();
			foreach(ACOutputGroupData item in list)
			{
				ACOutputGroupData data = this.Processing(item);
				if(data != null)
				{
					retList.Add(data);
				}
			}

			return retList;
		}

		public virtual Result Save(ACOutputGroupData entity)
		{
			return base.Save(entity);
		}

		public virtual void SaveUnderTransaction(ACOutputGroupData entity)
		{
			base.SaveUnderTransaction(entity);
		}

		public virtual Result Save(ACOutputGroupDataCollection list)
		{
			return base.Save(list);
		}

		public virtual void SaveUnderTransaction(ACOutputGroupDataCollection list)
		{
			base.SaveUnderTransaction(list);
		}


	}
	public abstract class BDTenantHolidayMapDataServiceBase : ServiceBase
	{
		protected BDTenantHolidayMapCRUD _dal;

		public BDTenantHolidayMapDataServiceBase(string connectionString, SecurityToken token) : base(connectionString, token)
		{
			this._dal = new BDTenantHolidayMapCRUD(connectionString);
			for (int i = 0; i < token.GetSortFields().Count; i++)
			{
				SortField field = token.GetSortFields()[i];
				this._dal.AddSortBy(field.FieldAlias, field.ASC);
			}
		}

		protected override string TableName
		{
			get
			{
				return "BDTenantHolidayMap";
			}
		}


		protected override int DeleteEntity(BusinessBase entity)
		{
			BDTenantHolidayMapData data = (BDTenantHolidayMapData) entity;
			if(data == null)
				return 0;

			return this._dal.DeleteByPK( data.BDTenantHolidayMapPK, data.RowVersion);
		}

		internal int DeleteByBDTenant(BusinessBase entity)
		{
			BDTenantData data = (BDTenantData) entity;
			if(data == null)
				return 0;

			bool isLogDeleteEnabled = ServiceBase._DBLog.IsLogDeleteEnabled;
			bool isLinkDBDeleteEnabled = ServiceBase._DBLink.IsLinkDBDeleteEnabled;
			if (!isLogDeleteEnabled && !isLinkDBDeleteEnabled)
			{
				return this._dal.DeleteByBDTenant(data. BDTenantPK);
			}

			DataTable list = this._dal.GetLogByBDTenant(data. BDTenantPK);
			list.TableName = this._dal.TableName;
			int ret = this._dal.DeleteByBDTenant(data. BDTenantPK);
			if (isLogDeleteEnabled)
			{
				ServiceBase._DBLog.LogDelete(list, base.SecurityToken);
			}

			if (isLinkDBDeleteEnabled)
			{
				ServiceBase._DBLink.LinkDBDelete(list, base.TrustedToken);
			}

			return ret;
		}

		internal int DeleteByBDBuilding(BusinessBase entity)
		{
			BDBuildingData data = (BDBuildingData) entity;
			if(data == null)
				return 0;

			bool isLogDeleteEnabled = ServiceBase._DBLog.IsLogDeleteEnabled;
			bool isLinkDBDeleteEnabled = ServiceBase._DBLink.IsLinkDBDeleteEnabled;
			if (!isLogDeleteEnabled && !isLinkDBDeleteEnabled)
			{
				return this._dal.DeleteByBDBuilding(data. BDBuildingPK);
			}

			DataTable list = this._dal.GetLogByBDBuilding(data. BDBuildingPK);
			list.TableName = this._dal.TableName;
			int ret = this._dal.DeleteByBDBuilding(data. BDBuildingPK);
			if (isLogDeleteEnabled)
			{
				ServiceBase._DBLog.LogDelete(list, base.SecurityToken);
			}

			if (isLinkDBDeleteEnabled)
			{
				ServiceBase._DBLink.LinkDBDelete(list, base.TrustedToken);
			}

			return ret;
		}

		internal int DeleteByUtilHoliday(BusinessBase entity)
		{
			UtilHolidayData data = (UtilHolidayData) entity;
			if(data == null)
				return 0;

			bool isLogDeleteEnabled = ServiceBase._DBLog.IsLogDeleteEnabled;
			bool isLinkDBDeleteEnabled = ServiceBase._DBLink.IsLinkDBDeleteEnabled;
			if (!isLogDeleteEnabled && !isLinkDBDeleteEnabled)
			{
				return this._dal.DeleteByUtilHoliday(data. UtilHolidayPK);
			}

			DataTable list = this._dal.GetLogByUtilHoliday(data. UtilHolidayPK);
			list.TableName = this._dal.TableName;
			int ret = this._dal.DeleteByUtilHoliday(data. UtilHolidayPK);
			if (isLogDeleteEnabled)
			{
				ServiceBase._DBLog.LogDelete(list, base.SecurityToken);
			}

			if (isLinkDBDeleteEnabled)
			{
				ServiceBase._DBLink.LinkDBDelete(list, base.TrustedToken);
			}

			return ret;
		}

		public virtual Result Purge(BDTenantHolidayMapData entity)
		{
			return base.Purge(entity);
		}

		protected override int PurgeEntity(BusinessBase entity)
		{
			BDTenantHolidayMapData data = (BDTenantHolidayMapData) entity;
			if(data == null)
				return 0;

			return this._dal.DeleteByPK( data.BDTenantHolidayMapPK, data.RowVersion);
		}

		internal int PurgeByBDTenant(BusinessBase entity)
		{
			BDTenantData data = (BDTenantData) entity;
			if(data == null)
				return 0;

			return this._dal.DeleteByBDTenant(data. BDTenantPK);
		}

		internal int PurgeByBDBuilding(BusinessBase entity)
		{
			BDBuildingData data = (BDBuildingData) entity;
			if(data == null)
				return 0;

			return this._dal.DeleteByBDBuilding(data. BDBuildingPK);
		}

		internal int PurgeByUtilHoliday(BusinessBase entity)
		{
			UtilHolidayData data = (UtilHolidayData) entity;
			if(data == null)
				return 0;

			return this._dal.DeleteByUtilHoliday(data. UtilHolidayPK);
		}

		protected override int InsertEntity(BusinessBase entity)
		{
			BDTenantHolidayMapData data = (BDTenantHolidayMapData) entity;
			if(data == null)
				return 0;

			return this._dal.Insert(data);
		}

		protected override int UpdateEntity(BusinessBase entity)
		{
			BDTenantHolidayMapData data = (BDTenantHolidayMapData) entity;
			if(data == null)
				return 0;

			return this._dal.Update(data);
		}

		protected override void UpdateChildren(BusinessBase entity)
		{
			BDTenantHolidayMapData data = (BDTenantHolidayMapData) entity;
			if(data == null)
				return;

		}

		internal Result GetRowVersion(BDTenantHolidayMapDataCollection list)
		{
			return base.GetRowVersion(list);
		}

		protected override Result GetRowVersion(BusinessBase entity)
		{
			BDTenantHolidayMapData data = (BDTenantHolidayMapData) entity;
			if(data == null || !data.IsDirty)
				return new Result(true);

			Result result = new Result(true);
			if (entity.IsDeleted)
			{
				result.Add(data.ObjectID, new byte[0]);
				return result;
			}

			if (entity.IsSelfDirty)
			{
				result.Add(data.ObjectID, this._dal.GetRowVersion( data.BDTenantHolidayMapPK));
			}
			return result;
		}

		public virtual BDTenantHolidayMapData GetByPK( System.Guid BDTenantHolidayMapPK)
		{
			if (base.IsTrusted)
			{
				return this.Processing(this._dal.GetByPK( BDTenantHolidayMapPK));
			}

			if (!base.IsAuthorizedSelect)
			{
				return null;
			}

			return this.Processing((BDTenantHolidayMapData) base.Filter(this._dal.GetByPK( BDTenantHolidayMapPK)));
		}

		protected virtual BDTenantHolidayMapData GetEntity(string sqlWhere, SqlParameter[] paras)
		{
			if (base.IsTrusted)
			{
				return this.Processing(this._dal.GetEntityBy(sqlWhere, paras));
			}

			if (!base.IsAuthorizedSelect)
			{
				return null;
			}

			return this.Processing((BDTenantHolidayMapData) base.Filter(this._dal.GetEntityBy(sqlWhere, paras)));
		}

		public virtual BDTenantHolidayMapDataCollection GetAll()
		{
			if (base.IsTrusted)
			{
				return this.Processing(this._dal.GetAll());
			}

			if (!base.IsAuthorizedSelect)
			{
				return new BDTenantHolidayMapDataCollection();
			}

			return this.Processing((BDTenantHolidayMapDataCollection) base.Filter(this._dal.GetAll()));
		}

		public BDTenantHolidayMapViewCollection GetViewAll()
		{
			return new BDTenantHolidayMapViewCollection(this.GetAll());
		}

		protected virtual BDTenantHolidayMapDataCollection GetCollection(string sqlWhere, SqlParameter[] paras)
		{
			if (base.IsTrusted)
			{
				return this.Processing(this._dal.GetCollectionBy(sqlWhere, paras));
			}

			if (!base.IsAuthorizedSelect)
			{
				return new BDTenantHolidayMapDataCollection();
			}

			 return this.Processing((BDTenantHolidayMapDataCollection) base.Filter(this._dal.GetCollectionBy(sqlWhere, paras)));
		}

		public virtual BDTenantHolidayMapDataCollection GetByBDTenant(System.Guid BDTenantPK)
		{
			if (base.IsTrusted)
			{
				return this.Processing(this._dal.GetByBDTenant(BDTenantPK));
			}

			if (!base.IsAuthorizedSelect)
			{
				return null;
			}

			return this.Processing((BDTenantHolidayMapDataCollection) base.Filter(this._dal.GetByBDTenant(BDTenantPK)));
		}

		public BDTenantHolidayMapViewCollection GetViewByBDTenant(System.Guid BDTenantPK)
		{
			return new BDTenantHolidayMapViewCollection(this.GetByBDTenant(BDTenantPK));
		}

		public virtual BDTenantHolidayMapDataCollection GetByUtilHoliday(System.Guid UtilHolidayPK)
		{
			if (base.IsTrusted)
			{
				return this.Processing(this._dal.GetByUtilHoliday(UtilHolidayPK));
			}

			if (!base.IsAuthorizedSelect)
			{
				return null;
			}

			return this.Processing((BDTenantHolidayMapDataCollection) base.Filter(this._dal.GetByUtilHoliday(UtilHolidayPK)));
		}

		public BDTenantHolidayMapViewCollection GetViewByUtilHoliday(System.Guid UtilHolidayPK)
		{
			return new BDTenantHolidayMapViewCollection(this.GetByUtilHoliday(UtilHolidayPK));
		}

		protected virtual BDTenantHolidayMapData Processing(BDTenantHolidayMapData entity)
		{
			return entity;
		}

		protected virtual BDTenantHolidayMapDataCollection Processing(BDTenantHolidayMapDataCollection list)
		{
			BDTenantHolidayMapDataCollection retList = new BDTenantHolidayMapDataCollection();
			foreach(BDTenantHolidayMapData item in list)
			{
				BDTenantHolidayMapData data = this.Processing(item);
				if(data != null)
				{
					retList.Add(data);
				}
			}

			return retList;
		}

		public virtual Result Save(BDTenantHolidayMapData entity)
		{
			return base.Save(entity);
		}

		public virtual void SaveUnderTransaction(BDTenantHolidayMapData entity)
		{
			base.SaveUnderTransaction(entity);
		}

		public virtual Result Save(BDTenantHolidayMapDataCollection list)
		{
			return base.Save(list);
		}

		public virtual void SaveUnderTransaction(BDTenantHolidayMapDataCollection list)
		{
			base.SaveUnderTransaction(list);
		}


	}
	public abstract class LogRowsCountDataServiceBase : ServiceBase
	{
		protected LogRowsCountCRUD _dal;

		public LogRowsCountDataServiceBase(string connectionString, SecurityToken token) : base(connectionString, token)
		{
			this._dal = new LogRowsCountCRUD(connectionString);
			for (int i = 0; i < token.GetSortFields().Count; i++)
			{
				SortField field = token.GetSortFields()[i];
				this._dal.AddSortBy(field.FieldAlias, field.ASC);
			}
		}

		protected override string TableName
		{
			get
			{
				return "LogRowsCount";
			}
		}


		protected override int DeleteEntity(BusinessBase entity)
		{
			LogRowsCountData data = (LogRowsCountData) entity;
			if(data == null)
				return 0;

			return this._dal.DeleteByPK( data.LogRowsCountPK, data.RowVersion);
		}

		public virtual Result Purge(LogRowsCountData entity)
		{
			return base.Purge(entity);
		}

		protected override int PurgeEntity(BusinessBase entity)
		{
			LogRowsCountData data = (LogRowsCountData) entity;
			if(data == null)
				return 0;

			return this._dal.DeleteByPK( data.LogRowsCountPK, data.RowVersion);
		}

		protected override int InsertEntity(BusinessBase entity)
		{
			LogRowsCountData data = (LogRowsCountData) entity;
			if(data == null)
				return 0;

			return this._dal.Insert(data);
		}

		protected override int UpdateEntity(BusinessBase entity)
		{
			LogRowsCountData data = (LogRowsCountData) entity;
			if(data == null)
				return 0;

			return this._dal.Update(data);
		}

		protected override void UpdateChildren(BusinessBase entity)
		{
			LogRowsCountData data = (LogRowsCountData) entity;
			if(data == null)
				return;

		}

		internal Result GetRowVersion(LogRowsCountDataCollection list)
		{
			return base.GetRowVersion(list);
		}

		protected override Result GetRowVersion(BusinessBase entity)
		{
			LogRowsCountData data = (LogRowsCountData) entity;
			if(data == null || !data.IsDirty)
				return new Result(true);

			Result result = new Result(true);
			if (entity.IsDeleted)
			{
				result.Add(data.ObjectID, new byte[0]);
				return result;
			}

			if (entity.IsSelfDirty)
			{
				result.Add(data.ObjectID, this._dal.GetRowVersion( data.LogRowsCountPK));
			}
			return result;
		}

		public virtual LogRowsCountData GetByPK( System.Guid LogRowsCountPK)
		{
			if (base.IsTrusted)
			{
				return this.Processing(this._dal.GetByPK( LogRowsCountPK));
			}

			if (!base.IsAuthorizedSelect)
			{
				return null;
			}

			return this.Processing((LogRowsCountData) base.Filter(this._dal.GetByPK( LogRowsCountPK)));
		}

		protected virtual LogRowsCountData GetEntity(string sqlWhere, SqlParameter[] paras)
		{
			if (base.IsTrusted)
			{
				return this.Processing(this._dal.GetEntityBy(sqlWhere, paras));
			}

			if (!base.IsAuthorizedSelect)
			{
				return null;
			}

			return this.Processing((LogRowsCountData) base.Filter(this._dal.GetEntityBy(sqlWhere, paras)));
		}

		public virtual LogRowsCountDataCollection GetAll()
		{
			if (base.IsTrusted)
			{
				return this.Processing(this._dal.GetAll());
			}

			if (!base.IsAuthorizedSelect)
			{
				return new LogRowsCountDataCollection();
			}

			return this.Processing((LogRowsCountDataCollection) base.Filter(this._dal.GetAll()));
		}

		public LogRowsCountViewCollection GetViewAll()
		{
			return new LogRowsCountViewCollection(this.GetAll());
		}

		protected virtual LogRowsCountDataCollection GetCollection(string sqlWhere, SqlParameter[] paras)
		{
			if (base.IsTrusted)
			{
				return this.Processing(this._dal.GetCollectionBy(sqlWhere, paras));
			}

			if (!base.IsAuthorizedSelect)
			{
				return new LogRowsCountDataCollection();
			}

			 return this.Processing((LogRowsCountDataCollection) base.Filter(this._dal.GetCollectionBy(sqlWhere, paras)));
		}

		protected virtual LogRowsCountData Processing(LogRowsCountData entity)
		{
			return entity;
		}

		protected virtual LogRowsCountDataCollection Processing(LogRowsCountDataCollection list)
		{
			LogRowsCountDataCollection retList = new LogRowsCountDataCollection();
			foreach(LogRowsCountData item in list)
			{
				LogRowsCountData data = this.Processing(item);
				if(data != null)
				{
					retList.Add(data);
				}
			}

			return retList;
		}

		public virtual Result Save(LogRowsCountData entity)
		{
			return base.Save(entity);
		}

		public virtual void SaveUnderTransaction(LogRowsCountData entity)
		{
			base.SaveUnderTransaction(entity);
		}

		public virtual Result Save(LogRowsCountDataCollection list)
		{
			return base.Save(list);
		}

		public virtual void SaveUnderTransaction(LogRowsCountDataCollection list)
		{
			base.SaveUnderTransaction(list);
		}


	}
	public abstract class ACInputGroupDataServiceBase : ServiceBase
	{
		protected ACInputGroupCRUD _dal;

		public ACInputGroupDataServiceBase(string connectionString, SecurityToken token) : base(connectionString, token)
		{
			this._dal = new ACInputGroupCRUD(connectionString);
			for (int i = 0; i < token.GetSortFields().Count; i++)
			{
				SortField field = token.GetSortFields()[i];
				this._dal.AddSortBy(field.FieldAlias, field.ASC);
			}
		}

		protected override string TableName
		{
			get
			{
				return "ACInputGroup";
			}
		}

		protected abstract ACInputGroupInputMapDataServiceBase GetACInputGroupInputMapDataServiceBase(SecurityToken token);

		protected override int DeleteEntity(BusinessBase entity)
		{
			ACInputGroupData data = (ACInputGroupData) entity;
			if(data == null)
				return 0;

			this.GetACInputGroupInputMapDataServiceBase(base.SecurityToken).DeleteByACInputGroup(data);
			return this._dal.DeleteByPK( data.ACInputGroupPK, data.RowVersion);
		}

		internal int DeleteByACPanel(BusinessBase entity)
		{
			ACPanelData data = (ACPanelData) entity;
			if(data == null)
				return 0;

			this.GetACInputGroupInputMapDataServiceBase(base.SecurityToken).DeleteByACPanel(entity);
			bool isLogDeleteEnabled = ServiceBase._DBLog.IsLogDeleteEnabled;
			bool isLinkDBDeleteEnabled = ServiceBase._DBLink.IsLinkDBDeleteEnabled;
			if (!isLogDeleteEnabled && !isLinkDBDeleteEnabled)
			{
				return this._dal.DeleteByACPanel(data. ACPanelPK);
			}

			DataTable list = this._dal.GetLogByACPanel(data. ACPanelPK);
			list.TableName = this._dal.TableName;
			int ret = this._dal.DeleteByACPanel(data. ACPanelPK);
			if (isLogDeleteEnabled)
			{
				ServiceBase._DBLog.LogDelete(list, base.SecurityToken);
			}

			if (isLinkDBDeleteEnabled)
			{
				ServiceBase._DBLink.LinkDBDelete(list, base.TrustedToken);
			}

			return ret;
		}

		internal int DeleteByBDBuilding(BusinessBase entity)
		{
			BDBuildingData data = (BDBuildingData) entity;
			if(data == null)
				return 0;

			this.GetACInputGroupInputMapDataServiceBase(base.SecurityToken).DeleteByBDBuilding(entity);
			bool isLogDeleteEnabled = ServiceBase._DBLog.IsLogDeleteEnabled;
			bool isLinkDBDeleteEnabled = ServiceBase._DBLink.IsLinkDBDeleteEnabled;
			if (!isLogDeleteEnabled && !isLinkDBDeleteEnabled)
			{
				return this._dal.DeleteByBDBuilding(data. BDBuildingPK);
			}

			DataTable list = this._dal.GetLogByBDBuilding(data. BDBuildingPK);
			list.TableName = this._dal.TableName;
			int ret = this._dal.DeleteByBDBuilding(data. BDBuildingPK);
			if (isLogDeleteEnabled)
			{
				ServiceBase._DBLog.LogDelete(list, base.SecurityToken);
			}

			if (isLinkDBDeleteEnabled)
			{
				ServiceBase._DBLink.LinkDBDelete(list, base.TrustedToken);
			}

			return ret;
		}

		public virtual Result Purge(ACInputGroupData entity)
		{
			return base.Purge(entity);
		}

		protected override int PurgeEntity(BusinessBase entity)
		{
			ACInputGroupData data = (ACInputGroupData) entity;
			if(data == null)
				return 0;

			this.GetACInputGroupInputMapDataServiceBase(base.SecurityToken).PurgeByACInputGroup(data);
			return this._dal.DeleteByPK( data.ACInputGroupPK, data.RowVersion);
		}

		internal int PurgeByACPanel(BusinessBase entity)
		{
			ACPanelData data = (ACPanelData) entity;
			if(data == null)
				return 0;

			this.GetACInputGroupInputMapDataServiceBase(base.SecurityToken).PurgeByACPanel(entity);
			return this._dal.DeleteByACPanel(data. ACPanelPK);
		}

		internal int PurgeByBDBuilding(BusinessBase entity)
		{
			BDBuildingData data = (BDBuildingData) entity;
			if(data == null)
				return 0;

			this.GetACInputGroupInputMapDataServiceBase(base.SecurityToken).PurgeByBDBuilding(entity);
			return this._dal.DeleteByBDBuilding(data. BDBuildingPK);
		}

		protected override int InsertEntity(BusinessBase entity)
		{
			ACInputGroupData data = (ACInputGroupData) entity;
			if(data == null)
				return 0;

			return this._dal.Insert(data);
		}

		protected override int UpdateEntity(BusinessBase entity)
		{
			ACInputGroupData data = (ACInputGroupData) entity;
			if(data == null)
				return 0;

			return this._dal.Update(data);
		}

		protected override void UpdateChildren(BusinessBase entity)
		{
			ACInputGroupData data = (ACInputGroupData) entity;
			if(data == null)
				return;

			if (data.ACInputGroupInputMapList != null)
			{
				 this.GetACInputGroupInputMapDataServiceBase(base.SecurityToken).SaveUnderTransaction(data.ACInputGroupInputMapList);
			}
		}

		internal Result GetRowVersion(ACInputGroupDataCollection list)
		{
			return base.GetRowVersion(list);
		}

		protected override Result GetRowVersion(BusinessBase entity)
		{
			ACInputGroupData data = (ACInputGroupData) entity;
			if(data == null || !data.IsDirty)
				return new Result(true);

			Result result = new Result(true);
			if (entity.IsDeleted)
			{
				result.Add(data.ObjectID, new byte[0]);
				return result;
			}

			if (entity.IsSelfDirty)
			{
				result.Add(data.ObjectID, this._dal.GetRowVersion( data.ACInputGroupPK));
			}
			if (data.ACInputGroupInputMapList != null && data.ACInputGroupInputMapList.Count > 0)
			{
				result.Add(this.GetACInputGroupInputMapDataServiceBase(base.SecurityToken).GetRowVersion(data.ACInputGroupInputMapList));
			}
			return result;
		}

		public virtual ACInputGroupData GetByPK( System.Guid ACInputGroupPK)
		{
			if (base.IsTrusted)
			{
				return this.Processing(this._dal.GetByPK( ACInputGroupPK));
			}

			if (!base.IsAuthorizedSelect)
			{
				return null;
			}

			return this.Processing((ACInputGroupData) base.Filter(this._dal.GetByPK( ACInputGroupPK)));
		}

		protected virtual ACInputGroupData GetEntity(string sqlWhere, SqlParameter[] paras)
		{
			if (base.IsTrusted)
			{
				return this.Processing(this._dal.GetEntityBy(sqlWhere, paras));
			}

			if (!base.IsAuthorizedSelect)
			{
				return null;
			}

			return this.Processing((ACInputGroupData) base.Filter(this._dal.GetEntityBy(sqlWhere, paras)));
		}

		public virtual ACInputGroupDataCollection GetAll()
		{
			if (base.IsTrusted)
			{
				return this.Processing(this._dal.GetAll());
			}

			if (!base.IsAuthorizedSelect)
			{
				return new ACInputGroupDataCollection();
			}

			return this.Processing((ACInputGroupDataCollection) base.Filter(this._dal.GetAll()));
		}

		public ACInputGroupViewCollection GetViewAll()
		{
			return new ACInputGroupViewCollection(this.GetAll());
		}

		protected virtual ACInputGroupDataCollection GetCollection(string sqlWhere, SqlParameter[] paras)
		{
			if (base.IsTrusted)
			{
				return this.Processing(this._dal.GetCollectionBy(sqlWhere, paras));
			}

			if (!base.IsAuthorizedSelect)
			{
				return new ACInputGroupDataCollection();
			}

			 return this.Processing((ACInputGroupDataCollection) base.Filter(this._dal.GetCollectionBy(sqlWhere, paras)));
		}

		public virtual ACInputGroupDataCollection GetByACPanel(System.Guid ACPanelPK)
		{
			if (base.IsTrusted)
			{
				return this.Processing(this._dal.GetByACPanel(ACPanelPK));
			}

			if (!base.IsAuthorizedSelect)
			{
				return null;
			}

			return this.Processing((ACInputGroupDataCollection) base.Filter(this._dal.GetByACPanel(ACPanelPK)));
		}

		public ACInputGroupViewCollection GetViewByACPanel(System.Guid ACPanelPK)
		{
			return new ACInputGroupViewCollection(this.GetByACPanel(ACPanelPK));
		}

		protected virtual ACInputGroupData Processing(ACInputGroupData entity)
		{
			return entity;
		}

		protected virtual ACInputGroupDataCollection Processing(ACInputGroupDataCollection list)
		{
			ACInputGroupDataCollection retList = new ACInputGroupDataCollection();
			foreach(ACInputGroupData item in list)
			{
				ACInputGroupData data = this.Processing(item);
				if(data != null)
				{
					retList.Add(data);
				}
			}

			return retList;
		}

		public virtual Result Save(ACInputGroupData entity)
		{
			return base.Save(entity);
		}

		public virtual void SaveUnderTransaction(ACInputGroupData entity)
		{
			base.SaveUnderTransaction(entity);
		}

		public virtual Result Save(ACInputGroupDataCollection list)
		{
			return base.Save(list);
		}

		public virtual void SaveUnderTransaction(ACInputGroupDataCollection list)
		{
			base.SaveUnderTransaction(list);
		}


	}
	public abstract class ACInputDataServiceBase : ServiceBase
	{
		protected ACInputCRUD _dal;

		public ACInputDataServiceBase(string connectionString, SecurityToken token) : base(connectionString, token)
		{
			this._dal = new ACInputCRUD(connectionString);
			for (int i = 0; i < token.GetSortFields().Count; i++)
			{
				SortField field = token.GetSortFields()[i];
				this._dal.AddSortBy(field.FieldAlias, field.ASC);
			}
		}

		protected override string TableName
		{
			get
			{
				return "ACInput";
			}
		}

		protected abstract ACInputGroupInputMapDataServiceBase GetACInputGroupInputMapDataServiceBase(SecurityToken token);

		protected override int DeleteEntity(BusinessBase entity)
		{
			ACInputData data = (ACInputData) entity;
			if(data == null)
				return 0;

			this.GetACInputGroupInputMapDataServiceBase(base.SecurityToken).DeleteByACInput(data);
			return this._dal.DeleteByPK( data.ACInputPK, data.RowVersion);
		}

		internal int DeleteByACPanel(BusinessBase entity)
		{
			ACPanelData data = (ACPanelData) entity;
			if(data == null)
				return 0;

			this.GetACInputGroupInputMapDataServiceBase(base.SecurityToken).DeleteByACPanel(entity);
			bool isLogDeleteEnabled = ServiceBase._DBLog.IsLogDeleteEnabled;
			bool isLinkDBDeleteEnabled = ServiceBase._DBLink.IsLinkDBDeleteEnabled;
			if (!isLogDeleteEnabled && !isLinkDBDeleteEnabled)
			{
				return this._dal.DeleteByACPanel(data. ACPanelPK);
			}

			DataTable list = this._dal.GetLogByACPanel(data. ACPanelPK);
			list.TableName = this._dal.TableName;
			int ret = this._dal.DeleteByACPanel(data. ACPanelPK);
			if (isLogDeleteEnabled)
			{
				ServiceBase._DBLog.LogDelete(list, base.SecurityToken);
			}

			if (isLinkDBDeleteEnabled)
			{
				ServiceBase._DBLink.LinkDBDelete(list, base.TrustedToken);
			}

			return ret;
		}

		internal int DeleteByBDBuilding(BusinessBase entity)
		{
			BDBuildingData data = (BDBuildingData) entity;
			if(data == null)
				return 0;

			this.GetACInputGroupInputMapDataServiceBase(base.SecurityToken).DeleteByBDBuilding(entity);
			bool isLogDeleteEnabled = ServiceBase._DBLog.IsLogDeleteEnabled;
			bool isLinkDBDeleteEnabled = ServiceBase._DBLink.IsLinkDBDeleteEnabled;
			if (!isLogDeleteEnabled && !isLinkDBDeleteEnabled)
			{
				return this._dal.DeleteByBDBuilding(data. BDBuildingPK);
			}

			DataTable list = this._dal.GetLogByBDBuilding(data. BDBuildingPK);
			list.TableName = this._dal.TableName;
			int ret = this._dal.DeleteByBDBuilding(data. BDBuildingPK);
			if (isLogDeleteEnabled)
			{
				ServiceBase._DBLog.LogDelete(list, base.SecurityToken);
			}

			if (isLinkDBDeleteEnabled)
			{
				ServiceBase._DBLink.LinkDBDelete(list, base.TrustedToken);
			}

			return ret;
		}

		public virtual Result Purge(ACInputData entity)
		{
			return base.Purge(entity);
		}

		protected override int PurgeEntity(BusinessBase entity)
		{
			ACInputData data = (ACInputData) entity;
			if(data == null)
				return 0;

			this.GetACInputGroupInputMapDataServiceBase(base.SecurityToken).PurgeByACInput(data);
			return this._dal.DeleteByPK( data.ACInputPK, data.RowVersion);
		}

		internal int PurgeByACPanel(BusinessBase entity)
		{
			ACPanelData data = (ACPanelData) entity;
			if(data == null)
				return 0;

			this.GetACInputGroupInputMapDataServiceBase(base.SecurityToken).PurgeByACPanel(entity);
			return this._dal.DeleteByACPanel(data. ACPanelPK);
		}

		internal int PurgeByBDBuilding(BusinessBase entity)
		{
			BDBuildingData data = (BDBuildingData) entity;
			if(data == null)
				return 0;

			this.GetACInputGroupInputMapDataServiceBase(base.SecurityToken).PurgeByBDBuilding(entity);
			return this._dal.DeleteByBDBuilding(data. BDBuildingPK);
		}

		protected override int InsertEntity(BusinessBase entity)
		{
			ACInputData data = (ACInputData) entity;
			if(data == null)
				return 0;

			return this._dal.Insert(data);
		}

		protected override int UpdateEntity(BusinessBase entity)
		{
			ACInputData data = (ACInputData) entity;
			if(data == null)
				return 0;

			return this._dal.Update(data);
		}

		protected override void UpdateChildren(BusinessBase entity)
		{
			ACInputData data = (ACInputData) entity;
			if(data == null)
				return;

			if (data.ACInputGroupInputMapList != null)
			{
				 this.GetACInputGroupInputMapDataServiceBase(base.SecurityToken).SaveUnderTransaction(data.ACInputGroupInputMapList);
			}
		}

		internal Result GetRowVersion(ACInputDataCollection list)
		{
			return base.GetRowVersion(list);
		}

		protected override Result GetRowVersion(BusinessBase entity)
		{
			ACInputData data = (ACInputData) entity;
			if(data == null || !data.IsDirty)
				return new Result(true);

			Result result = new Result(true);
			if (entity.IsDeleted)
			{
				result.Add(data.ObjectID, new byte[0]);
				return result;
			}

			if (entity.IsSelfDirty)
			{
				result.Add(data.ObjectID, this._dal.GetRowVersion( data.ACInputPK));
			}
			if (data.ACInputGroupInputMapList != null && data.ACInputGroupInputMapList.Count > 0)
			{
				result.Add(this.GetACInputGroupInputMapDataServiceBase(base.SecurityToken).GetRowVersion(data.ACInputGroupInputMapList));
			}
			return result;
		}

		public virtual ACInputData GetByPK( System.Guid ACInputPK)
		{
			if (base.IsTrusted)
			{
				return this.Processing(this._dal.GetByPK( ACInputPK));
			}

			if (!base.IsAuthorizedSelect)
			{
				return null;
			}

			return this.Processing((ACInputData) base.Filter(this._dal.GetByPK( ACInputPK)));
		}

		protected virtual ACInputData GetEntity(string sqlWhere, SqlParameter[] paras)
		{
			if (base.IsTrusted)
			{
				return this.Processing(this._dal.GetEntityBy(sqlWhere, paras));
			}

			if (!base.IsAuthorizedSelect)
			{
				return null;
			}

			return this.Processing((ACInputData) base.Filter(this._dal.GetEntityBy(sqlWhere, paras)));
		}

		public virtual ACInputDataCollection GetAll()
		{
			if (base.IsTrusted)
			{
				return this.Processing(this._dal.GetAll());
			}

			if (!base.IsAuthorizedSelect)
			{
				return new ACInputDataCollection();
			}

			return this.Processing((ACInputDataCollection) base.Filter(this._dal.GetAll()));
		}

		public ACInputViewCollection GetViewAll()
		{
			return new ACInputViewCollection(this.GetAll());
		}

		protected virtual ACInputDataCollection GetCollection(string sqlWhere, SqlParameter[] paras)
		{
			if (base.IsTrusted)
			{
				return this.Processing(this._dal.GetCollectionBy(sqlWhere, paras));
			}

			if (!base.IsAuthorizedSelect)
			{
				return new ACInputDataCollection();
			}

			 return this.Processing((ACInputDataCollection) base.Filter(this._dal.GetCollectionBy(sqlWhere, paras)));
		}

		public virtual ACInputDataCollection GetByACPanel(System.Guid ACPanelPK)
		{
			if (base.IsTrusted)
			{
				return this.Processing(this._dal.GetByACPanel(ACPanelPK));
			}

			if (!base.IsAuthorizedSelect)
			{
				return null;
			}

			return this.Processing((ACInputDataCollection) base.Filter(this._dal.GetByACPanel(ACPanelPK)));
		}

		public ACInputViewCollection GetViewByACPanel(System.Guid ACPanelPK)
		{
			return new ACInputViewCollection(this.GetByACPanel(ACPanelPK));
		}

		protected virtual ACInputData Processing(ACInputData entity)
		{
			return entity;
		}

		protected virtual ACInputDataCollection Processing(ACInputDataCollection list)
		{
			ACInputDataCollection retList = new ACInputDataCollection();
			foreach(ACInputData item in list)
			{
				ACInputData data = this.Processing(item);
				if(data != null)
				{
					retList.Add(data);
				}
			}

			return retList;
		}

		public virtual Result Save(ACInputData entity)
		{
			return base.Save(entity);
		}

		public virtual void SaveUnderTransaction(ACInputData entity)
		{
			base.SaveUnderTransaction(entity);
		}

		public virtual Result Save(ACInputDataCollection list)
		{
			return base.Save(list);
		}

		public virtual void SaveUnderTransaction(ACInputDataCollection list)
		{
			base.SaveUnderTransaction(list);
		}


	}
	public abstract class ACFunctionCardDataServiceBase : ServiceBase
	{
		protected ACFunctionCardCRUD _dal;

		public ACFunctionCardDataServiceBase(string connectionString, SecurityToken token) : base(connectionString, token)
		{
			this._dal = new ACFunctionCardCRUD(connectionString);
			for (int i = 0; i < token.GetSortFields().Count; i++)
			{
				SortField field = token.GetSortFields()[i];
				this._dal.AddSortBy(field.FieldAlias, field.ASC);
			}
		}

		protected override string TableName
		{
			get
			{
				return "ACFunctionCard";
			}
		}

		protected abstract ACPanelFunctionCardMapDataServiceBase GetACPanelFunctionCardMapDataServiceBase(SecurityToken token);

		protected override int DeleteEntity(BusinessBase entity)
		{
			ACFunctionCardData data = (ACFunctionCardData) entity;
			if(data == null)
				return 0;

			this.GetACPanelFunctionCardMapDataServiceBase(base.SecurityToken).DeleteByACFunctionCard(data);
			return this._dal.DeleteByPK( data.ACFunctionCardPK, data.RowVersion);
		}

		internal int DeleteByBDTenant(BusinessBase entity)
		{
			BDTenantData data = (BDTenantData) entity;
			if(data == null)
				return 0;

			this.GetACPanelFunctionCardMapDataServiceBase(base.SecurityToken).DeleteByBDTenant(entity);
			bool isLogDeleteEnabled = ServiceBase._DBLog.IsLogDeleteEnabled;
			bool isLinkDBDeleteEnabled = ServiceBase._DBLink.IsLinkDBDeleteEnabled;
			if (!isLogDeleteEnabled && !isLinkDBDeleteEnabled)
			{
				return this._dal.DeleteByBDTenant(data. BDTenantPK);
			}

			DataTable list = this._dal.GetLogByBDTenant(data. BDTenantPK);
			list.TableName = this._dal.TableName;
			int ret = this._dal.DeleteByBDTenant(data. BDTenantPK);
			if (isLogDeleteEnabled)
			{
				ServiceBase._DBLog.LogDelete(list, base.SecurityToken);
			}

			if (isLinkDBDeleteEnabled)
			{
				ServiceBase._DBLink.LinkDBDelete(list, base.TrustedToken);
			}

			return ret;
		}

		internal int DeleteByBDBuilding(BusinessBase entity)
		{
			BDBuildingData data = (BDBuildingData) entity;
			if(data == null)
				return 0;

			this.GetACPanelFunctionCardMapDataServiceBase(base.SecurityToken).DeleteByBDBuilding(entity);
			bool isLogDeleteEnabled = ServiceBase._DBLog.IsLogDeleteEnabled;
			bool isLinkDBDeleteEnabled = ServiceBase._DBLink.IsLinkDBDeleteEnabled;
			if (!isLogDeleteEnabled && !isLinkDBDeleteEnabled)
			{
				return this._dal.DeleteByBDBuilding(data. BDBuildingPK);
			}

			DataTable list = this._dal.GetLogByBDBuilding(data. BDBuildingPK);
			list.TableName = this._dal.TableName;
			int ret = this._dal.DeleteByBDBuilding(data. BDBuildingPK);
			if (isLogDeleteEnabled)
			{
				ServiceBase._DBLog.LogDelete(list, base.SecurityToken);
			}

			if (isLinkDBDeleteEnabled)
			{
				ServiceBase._DBLink.LinkDBDelete(list, base.TrustedToken);
			}

			return ret;
		}

		public virtual Result Purge(ACFunctionCardData entity)
		{
			return base.Purge(entity);
		}

		protected override int PurgeEntity(BusinessBase entity)
		{
			ACFunctionCardData data = (ACFunctionCardData) entity;
			if(data == null)
				return 0;

			this.GetACPanelFunctionCardMapDataServiceBase(base.SecurityToken).PurgeByACFunctionCard(data);
			return this._dal.DeleteByPK( data.ACFunctionCardPK, data.RowVersion);
		}

		internal int PurgeByBDTenant(BusinessBase entity)
		{
			BDTenantData data = (BDTenantData) entity;
			if(data == null)
				return 0;

			this.GetACPanelFunctionCardMapDataServiceBase(base.SecurityToken).PurgeByBDTenant(entity);
			return this._dal.DeleteByBDTenant(data. BDTenantPK);
		}

		internal int PurgeByBDBuilding(BusinessBase entity)
		{
			BDBuildingData data = (BDBuildingData) entity;
			if(data == null)
				return 0;

			this.GetACPanelFunctionCardMapDataServiceBase(base.SecurityToken).PurgeByBDBuilding(entity);
			return this._dal.DeleteByBDBuilding(data. BDBuildingPK);
		}

		protected override int InsertEntity(BusinessBase entity)
		{
			ACFunctionCardData data = (ACFunctionCardData) entity;
			if(data == null)
				return 0;

			return this._dal.Insert(data);
		}

		protected override int UpdateEntity(BusinessBase entity)
		{
			ACFunctionCardData data = (ACFunctionCardData) entity;
			if(data == null)
				return 0;

			return this._dal.Update(data);
		}

		protected override void UpdateChildren(BusinessBase entity)
		{
			ACFunctionCardData data = (ACFunctionCardData) entity;
			if(data == null)
				return;

			if (data.ACPanelFunctionCardMapList != null)
			{
				 this.GetACPanelFunctionCardMapDataServiceBase(base.SecurityToken).SaveUnderTransaction(data.ACPanelFunctionCardMapList);
			}
		}

		internal Result GetRowVersion(ACFunctionCardDataCollection list)
		{
			return base.GetRowVersion(list);
		}

		protected override Result GetRowVersion(BusinessBase entity)
		{
			ACFunctionCardData data = (ACFunctionCardData) entity;
			if(data == null || !data.IsDirty)
				return new Result(true);

			Result result = new Result(true);
			if (entity.IsDeleted)
			{
				result.Add(data.ObjectID, new byte[0]);
				return result;
			}

			if (entity.IsSelfDirty)
			{
				result.Add(data.ObjectID, this._dal.GetRowVersion( data.ACFunctionCardPK));
			}
			if (data.ACPanelFunctionCardMapList != null && data.ACPanelFunctionCardMapList.Count > 0)
			{
				result.Add(this.GetACPanelFunctionCardMapDataServiceBase(base.SecurityToken).GetRowVersion(data.ACPanelFunctionCardMapList));
			}
			return result;
		}

		public virtual ACFunctionCardData GetByPK( System.Guid ACFunctionCardPK)
		{
			if (base.IsTrusted)
			{
				return this.Processing(this._dal.GetByPK( ACFunctionCardPK));
			}

			if (!base.IsAuthorizedSelect)
			{
				return null;
			}

			return this.Processing((ACFunctionCardData) base.Filter(this._dal.GetByPK( ACFunctionCardPK)));
		}

		protected virtual ACFunctionCardData GetEntity(string sqlWhere, SqlParameter[] paras)
		{
			if (base.IsTrusted)
			{
				return this.Processing(this._dal.GetEntityBy(sqlWhere, paras));
			}

			if (!base.IsAuthorizedSelect)
			{
				return null;
			}

			return this.Processing((ACFunctionCardData) base.Filter(this._dal.GetEntityBy(sqlWhere, paras)));
		}

		public virtual ACFunctionCardDataCollection GetAll()
		{
			if (base.IsTrusted)
			{
				return this.Processing(this._dal.GetAll());
			}

			if (!base.IsAuthorizedSelect)
			{
				return new ACFunctionCardDataCollection();
			}

			return this.Processing((ACFunctionCardDataCollection) base.Filter(this._dal.GetAll()));
		}

		public ACFunctionCardViewCollection GetViewAll()
		{
			return new ACFunctionCardViewCollection(this.GetAll());
		}

		protected virtual ACFunctionCardDataCollection GetCollection(string sqlWhere, SqlParameter[] paras)
		{
			if (base.IsTrusted)
			{
				return this.Processing(this._dal.GetCollectionBy(sqlWhere, paras));
			}

			if (!base.IsAuthorizedSelect)
			{
				return new ACFunctionCardDataCollection();
			}

			 return this.Processing((ACFunctionCardDataCollection) base.Filter(this._dal.GetCollectionBy(sqlWhere, paras)));
		}

		public virtual ACFunctionCardDataCollection GetByBDTenant(System.Guid BDTenantPK)
		{
			if (base.IsTrusted)
			{
				return this.Processing(this._dal.GetByBDTenant(BDTenantPK));
			}

			if (!base.IsAuthorizedSelect)
			{
				return null;
			}

			return this.Processing((ACFunctionCardDataCollection) base.Filter(this._dal.GetByBDTenant(BDTenantPK)));
		}

		public ACFunctionCardViewCollection GetViewByBDTenant(System.Guid BDTenantPK)
		{
			return new ACFunctionCardViewCollection(this.GetByBDTenant(BDTenantPK));
		}

		protected virtual ACFunctionCardData Processing(ACFunctionCardData entity)
		{
			return entity;
		}

		protected virtual ACFunctionCardDataCollection Processing(ACFunctionCardDataCollection list)
		{
			ACFunctionCardDataCollection retList = new ACFunctionCardDataCollection();
			foreach(ACFunctionCardData item in list)
			{
				ACFunctionCardData data = this.Processing(item);
				if(data != null)
				{
					retList.Add(data);
				}
			}

			return retList;
		}

		public virtual Result Save(ACFunctionCardData entity)
		{
			return base.Save(entity);
		}

		public virtual void SaveUnderTransaction(ACFunctionCardData entity)
		{
			base.SaveUnderTransaction(entity);
		}

		public virtual Result Save(ACFunctionCardDataCollection list)
		{
			return base.Save(list);
		}

		public virtual void SaveUnderTransaction(ACFunctionCardDataCollection list)
		{
			base.SaveUnderTransaction(list);
		}


	}
	public abstract class ACAccessLevelDataServiceBase : ServiceBase
	{
		protected ACAccessLevelCRUD _dal;

		public ACAccessLevelDataServiceBase(string connectionString, SecurityToken token) : base(connectionString, token)
		{
			this._dal = new ACAccessLevelCRUD(connectionString);
			for (int i = 0; i < token.GetSortFields().Count; i++)
			{
				SortField field = token.GetSortFields()[i];
				this._dal.AddSortBy(field.FieldAlias, field.ASC);
			}
		}

		protected override string TableName
		{
			get
			{
				return "ACAccessLevel";
			}
		}

		protected abstract ACAccessLevelDetailDataServiceBase GetACAccessLevelDetailDataServiceBase(SecurityToken token);

		protected override int DeleteEntity(BusinessBase entity)
		{
			ACAccessLevelData data = (ACAccessLevelData) entity;
			if(data == null)
				return 0;

			this.GetACAccessLevelDetailDataServiceBase(base.SecurityToken).DeleteByACAccessLevel(data);
			return this._dal.DeleteByPK( data.ACAccessLevelPK, data.RowVersion);
		}

		internal int DeleteByBDBuilding(BusinessBase entity)
		{
			BDBuildingData data = (BDBuildingData) entity;
			if(data == null)
				return 0;

			this.GetACAccessLevelDetailDataServiceBase(base.SecurityToken).DeleteByBDBuilding(entity);
			bool isLogDeleteEnabled = ServiceBase._DBLog.IsLogDeleteEnabled;
			bool isLinkDBDeleteEnabled = ServiceBase._DBLink.IsLinkDBDeleteEnabled;
			if (!isLogDeleteEnabled && !isLinkDBDeleteEnabled)
			{
				return this._dal.DeleteByBDBuilding(data. BDBuildingPK);
			}

			DataTable list = this._dal.GetLogByBDBuilding(data. BDBuildingPK);
			list.TableName = this._dal.TableName;
			int ret = this._dal.DeleteByBDBuilding(data. BDBuildingPK);
			if (isLogDeleteEnabled)
			{
				ServiceBase._DBLog.LogDelete(list, base.SecurityToken);
			}

			if (isLinkDBDeleteEnabled)
			{
				ServiceBase._DBLink.LinkDBDelete(list, base.TrustedToken);
			}

			return ret;
		}

		public virtual Result Purge(ACAccessLevelData entity)
		{
			return base.Purge(entity);
		}

		protected override int PurgeEntity(BusinessBase entity)
		{
			ACAccessLevelData data = (ACAccessLevelData) entity;
			if(data == null)
				return 0;

			this.GetACAccessLevelDetailDataServiceBase(base.SecurityToken).PurgeByACAccessLevel(data);
			return this._dal.DeleteByPK( data.ACAccessLevelPK, data.RowVersion);
		}

		internal int PurgeByBDBuilding(BusinessBase entity)
		{
			BDBuildingData data = (BDBuildingData) entity;
			if(data == null)
				return 0;

			this.GetACAccessLevelDetailDataServiceBase(base.SecurityToken).PurgeByBDBuilding(entity);
			return this._dal.DeleteByBDBuilding(data. BDBuildingPK);
		}

		protected override int InsertEntity(BusinessBase entity)
		{
			ACAccessLevelData data = (ACAccessLevelData) entity;
			if(data == null)
				return 0;

			return this._dal.Insert(data);
		}

		protected override int UpdateEntity(BusinessBase entity)
		{
			ACAccessLevelData data = (ACAccessLevelData) entity;
			if(data == null)
				return 0;

			return this._dal.Update(data);
		}

		protected override void UpdateChildren(BusinessBase entity)
		{
			ACAccessLevelData data = (ACAccessLevelData) entity;
			if(data == null)
				return;

			if (data.ACAccessLevelDetailList != null)
			{
				 this.GetACAccessLevelDetailDataServiceBase(base.SecurityToken).SaveUnderTransaction(data.ACAccessLevelDetailList);
			}
		}

		internal Result GetRowVersion(ACAccessLevelDataCollection list)
		{
			return base.GetRowVersion(list);
		}

		protected override Result GetRowVersion(BusinessBase entity)
		{
			ACAccessLevelData data = (ACAccessLevelData) entity;
			if(data == null || !data.IsDirty)
				return new Result(true);

			Result result = new Result(true);
			if (entity.IsDeleted)
			{
				result.Add(data.ObjectID, new byte[0]);
				return result;
			}

			if (entity.IsSelfDirty)
			{
				result.Add(data.ObjectID, this._dal.GetRowVersion( data.ACAccessLevelPK));
			}
			if (data.ACAccessLevelDetailList != null && data.ACAccessLevelDetailList.Count > 0)
			{
				result.Add(this.GetACAccessLevelDetailDataServiceBase(base.SecurityToken).GetRowVersion(data.ACAccessLevelDetailList));
			}
			return result;
		}

		public virtual ACAccessLevelData GetByPK( System.Guid ACAccessLevelPK)
		{
			if (base.IsTrusted)
			{
				return this.Processing(this._dal.GetByPK( ACAccessLevelPK));
			}

			if (!base.IsAuthorizedSelect)
			{
				return null;
			}

			return this.Processing((ACAccessLevelData) base.Filter(this._dal.GetByPK( ACAccessLevelPK)));
		}

		protected virtual ACAccessLevelData GetEntity(string sqlWhere, SqlParameter[] paras)
		{
			if (base.IsTrusted)
			{
				return this.Processing(this._dal.GetEntityBy(sqlWhere, paras));
			}

			if (!base.IsAuthorizedSelect)
			{
				return null;
			}

			return this.Processing((ACAccessLevelData) base.Filter(this._dal.GetEntityBy(sqlWhere, paras)));
		}

		public virtual ACAccessLevelDataCollection GetAll()
		{
			if (base.IsTrusted)
			{
				return this.Processing(this._dal.GetAll());
			}

			if (!base.IsAuthorizedSelect)
			{
				return new ACAccessLevelDataCollection();
			}

			return this.Processing((ACAccessLevelDataCollection) base.Filter(this._dal.GetAll()));
		}

		public ACAccessLevelViewCollection GetViewAll()
		{
			return new ACAccessLevelViewCollection(this.GetAll());
		}

		protected virtual ACAccessLevelDataCollection GetCollection(string sqlWhere, SqlParameter[] paras)
		{
			if (base.IsTrusted)
			{
				return this.Processing(this._dal.GetCollectionBy(sqlWhere, paras));
			}

			if (!base.IsAuthorizedSelect)
			{
				return new ACAccessLevelDataCollection();
			}

			 return this.Processing((ACAccessLevelDataCollection) base.Filter(this._dal.GetCollectionBy(sqlWhere, paras)));
		}

		public virtual ACAccessLevelDataCollection GetByBDBuilding(System.Guid BDBuildingPK)
		{
			if (base.IsTrusted)
			{
				return this.Processing(this._dal.GetByBDBuilding(BDBuildingPK));
			}

			if (!base.IsAuthorizedSelect)
			{
				return null;
			}

			return this.Processing((ACAccessLevelDataCollection) base.Filter(this._dal.GetByBDBuilding(BDBuildingPK)));
		}

		public ACAccessLevelViewCollection GetViewByBDBuilding(System.Guid BDBuildingPK)
		{
			return new ACAccessLevelViewCollection(this.GetByBDBuilding(BDBuildingPK));
		}

		protected virtual ACAccessLevelData Processing(ACAccessLevelData entity)
		{
			return entity;
		}

		protected virtual ACAccessLevelDataCollection Processing(ACAccessLevelDataCollection list)
		{
			ACAccessLevelDataCollection retList = new ACAccessLevelDataCollection();
			foreach(ACAccessLevelData item in list)
			{
				ACAccessLevelData data = this.Processing(item);
				if(data != null)
				{
					retList.Add(data);
				}
			}

			return retList;
		}

		public virtual Result Save(ACAccessLevelData entity)
		{
			return base.Save(entity);
		}

		public virtual void SaveUnderTransaction(ACAccessLevelData entity)
		{
			base.SaveUnderTransaction(entity);
		}

		public virtual Result Save(ACAccessLevelDataCollection list)
		{
			return base.Save(list);
		}

		public virtual void SaveUnderTransaction(ACAccessLevelDataCollection list)
		{
			base.SaveUnderTransaction(list);
		}


	}
	public abstract class ACPanelFunctionCardMapDataServiceBase : ServiceBase
	{
		protected ACPanelFunctionCardMapCRUD _dal;

		public ACPanelFunctionCardMapDataServiceBase(string connectionString, SecurityToken token) : base(connectionString, token)
		{
			this._dal = new ACPanelFunctionCardMapCRUD(connectionString);
			for (int i = 0; i < token.GetSortFields().Count; i++)
			{
				SortField field = token.GetSortFields()[i];
				this._dal.AddSortBy(field.FieldAlias, field.ASC);
			}
		}

		protected override string TableName
		{
			get
			{
				return "ACPanelFunctionCardMap";
			}
		}


		protected override int DeleteEntity(BusinessBase entity)
		{
			ACPanelFunctionCardMapData data = (ACPanelFunctionCardMapData) entity;
			if(data == null)
				return 0;

			return this._dal.DeleteByPK( data.ACPanelFunctionCardMapPK, data.RowVersion);
		}

		internal int DeleteByACFunctionCard(BusinessBase entity)
		{
			ACFunctionCardData data = (ACFunctionCardData) entity;
			if(data == null)
				return 0;

			bool isLogDeleteEnabled = ServiceBase._DBLog.IsLogDeleteEnabled;
			bool isLinkDBDeleteEnabled = ServiceBase._DBLink.IsLinkDBDeleteEnabled;
			if (!isLogDeleteEnabled && !isLinkDBDeleteEnabled)
			{
				return this._dal.DeleteByACFunctionCard(data. ACFunctionCardPK);
			}

			DataTable list = this._dal.GetLogByACFunctionCard(data. ACFunctionCardPK);
			list.TableName = this._dal.TableName;
			int ret = this._dal.DeleteByACFunctionCard(data. ACFunctionCardPK);
			if (isLogDeleteEnabled)
			{
				ServiceBase._DBLog.LogDelete(list, base.SecurityToken);
			}

			if (isLinkDBDeleteEnabled)
			{
				ServiceBase._DBLink.LinkDBDelete(list, base.TrustedToken);
			}

			return ret;
		}

		internal int DeleteByBDTenant(BusinessBase entity)
		{
			BDTenantData data = (BDTenantData) entity;
			if(data == null)
				return 0;

			bool isLogDeleteEnabled = ServiceBase._DBLog.IsLogDeleteEnabled;
			bool isLinkDBDeleteEnabled = ServiceBase._DBLink.IsLinkDBDeleteEnabled;
			if (!isLogDeleteEnabled && !isLinkDBDeleteEnabled)
			{
				return this._dal.DeleteByBDTenant(data. BDTenantPK);
			}

			DataTable list = this._dal.GetLogByBDTenant(data. BDTenantPK);
			list.TableName = this._dal.TableName;
			int ret = this._dal.DeleteByBDTenant(data. BDTenantPK);
			if (isLogDeleteEnabled)
			{
				ServiceBase._DBLog.LogDelete(list, base.SecurityToken);
			}

			if (isLinkDBDeleteEnabled)
			{
				ServiceBase._DBLink.LinkDBDelete(list, base.TrustedToken);
			}

			return ret;
		}

		internal int DeleteByBDBuilding(BusinessBase entity)
		{
			BDBuildingData data = (BDBuildingData) entity;
			if(data == null)
				return 0;

			bool isLogDeleteEnabled = ServiceBase._DBLog.IsLogDeleteEnabled;
			bool isLinkDBDeleteEnabled = ServiceBase._DBLink.IsLinkDBDeleteEnabled;
			if (!isLogDeleteEnabled && !isLinkDBDeleteEnabled)
			{
				return this._dal.DeleteByBDBuilding(data. BDBuildingPK);
			}

			DataTable list = this._dal.GetLogByBDBuilding(data. BDBuildingPK);
			list.TableName = this._dal.TableName;
			int ret = this._dal.DeleteByBDBuilding(data. BDBuildingPK);
			if (isLogDeleteEnabled)
			{
				ServiceBase._DBLog.LogDelete(list, base.SecurityToken);
			}

			if (isLinkDBDeleteEnabled)
			{
				ServiceBase._DBLink.LinkDBDelete(list, base.TrustedToken);
			}

			return ret;
		}

		internal int DeleteByACPanel(BusinessBase entity)
		{
			ACPanelData data = (ACPanelData) entity;
			if(data == null)
				return 0;

			bool isLogDeleteEnabled = ServiceBase._DBLog.IsLogDeleteEnabled;
			bool isLinkDBDeleteEnabled = ServiceBase._DBLink.IsLinkDBDeleteEnabled;
			if (!isLogDeleteEnabled && !isLinkDBDeleteEnabled)
			{
				return this._dal.DeleteByACPanel(data. ACPanelPK);
			}

			DataTable list = this._dal.GetLogByACPanel(data. ACPanelPK);
			list.TableName = this._dal.TableName;
			int ret = this._dal.DeleteByACPanel(data. ACPanelPK);
			if (isLogDeleteEnabled)
			{
				ServiceBase._DBLog.LogDelete(list, base.SecurityToken);
			}

			if (isLinkDBDeleteEnabled)
			{
				ServiceBase._DBLink.LinkDBDelete(list, base.TrustedToken);
			}

			return ret;
		}

		public virtual Result Purge(ACPanelFunctionCardMapData entity)
		{
			return base.Purge(entity);
		}

		protected override int PurgeEntity(BusinessBase entity)
		{
			ACPanelFunctionCardMapData data = (ACPanelFunctionCardMapData) entity;
			if(data == null)
				return 0;

			return this._dal.DeleteByPK( data.ACPanelFunctionCardMapPK, data.RowVersion);
		}

		internal int PurgeByACFunctionCard(BusinessBase entity)
		{
			ACFunctionCardData data = (ACFunctionCardData) entity;
			if(data == null)
				return 0;

			return this._dal.DeleteByACFunctionCard(data. ACFunctionCardPK);
		}

		internal int PurgeByBDTenant(BusinessBase entity)
		{
			BDTenantData data = (BDTenantData) entity;
			if(data == null)
				return 0;

			return this._dal.DeleteByBDTenant(data. BDTenantPK);
		}

		internal int PurgeByBDBuilding(BusinessBase entity)
		{
			BDBuildingData data = (BDBuildingData) entity;
			if(data == null)
				return 0;

			return this._dal.DeleteByBDBuilding(data. BDBuildingPK);
		}

		internal int PurgeByACPanel(BusinessBase entity)
		{
			ACPanelData data = (ACPanelData) entity;
			if(data == null)
				return 0;

			return this._dal.DeleteByACPanel(data. ACPanelPK);
		}

		protected override int InsertEntity(BusinessBase entity)
		{
			ACPanelFunctionCardMapData data = (ACPanelFunctionCardMapData) entity;
			if(data == null)
				return 0;

			return this._dal.Insert(data);
		}

		protected override int UpdateEntity(BusinessBase entity)
		{
			ACPanelFunctionCardMapData data = (ACPanelFunctionCardMapData) entity;
			if(data == null)
				return 0;

			return this._dal.Update(data);
		}

		protected override void UpdateChildren(BusinessBase entity)
		{
			ACPanelFunctionCardMapData data = (ACPanelFunctionCardMapData) entity;
			if(data == null)
				return;

		}

		internal Result GetRowVersion(ACPanelFunctionCardMapDataCollection list)
		{
			return base.GetRowVersion(list);
		}

		protected override Result GetRowVersion(BusinessBase entity)
		{
			ACPanelFunctionCardMapData data = (ACPanelFunctionCardMapData) entity;
			if(data == null || !data.IsDirty)
				return new Result(true);

			Result result = new Result(true);
			if (entity.IsDeleted)
			{
				result.Add(data.ObjectID, new byte[0]);
				return result;
			}

			if (entity.IsSelfDirty)
			{
				result.Add(data.ObjectID, this._dal.GetRowVersion( data.ACPanelFunctionCardMapPK));
			}
			return result;
		}

		public virtual ACPanelFunctionCardMapData GetByPK( System.Guid ACPanelFunctionCardMapPK)
		{
			if (base.IsTrusted)
			{
				return this.Processing(this._dal.GetByPK( ACPanelFunctionCardMapPK));
			}

			if (!base.IsAuthorizedSelect)
			{
				return null;
			}

			return this.Processing((ACPanelFunctionCardMapData) base.Filter(this._dal.GetByPK( ACPanelFunctionCardMapPK)));
		}

		protected virtual ACPanelFunctionCardMapData GetEntity(string sqlWhere, SqlParameter[] paras)
		{
			if (base.IsTrusted)
			{
				return this.Processing(this._dal.GetEntityBy(sqlWhere, paras));
			}

			if (!base.IsAuthorizedSelect)
			{
				return null;
			}

			return this.Processing((ACPanelFunctionCardMapData) base.Filter(this._dal.GetEntityBy(sqlWhere, paras)));
		}

		public virtual ACPanelFunctionCardMapDataCollection GetAll()
		{
			if (base.IsTrusted)
			{
				return this.Processing(this._dal.GetAll());
			}

			if (!base.IsAuthorizedSelect)
			{
				return new ACPanelFunctionCardMapDataCollection();
			}

			return this.Processing((ACPanelFunctionCardMapDataCollection) base.Filter(this._dal.GetAll()));
		}

		public ACPanelFunctionCardMapViewCollection GetViewAll()
		{
			return new ACPanelFunctionCardMapViewCollection(this.GetAll());
		}

		protected virtual ACPanelFunctionCardMapDataCollection GetCollection(string sqlWhere, SqlParameter[] paras)
		{
			if (base.IsTrusted)
			{
				return this.Processing(this._dal.GetCollectionBy(sqlWhere, paras));
			}

			if (!base.IsAuthorizedSelect)
			{
				return new ACPanelFunctionCardMapDataCollection();
			}

			 return this.Processing((ACPanelFunctionCardMapDataCollection) base.Filter(this._dal.GetCollectionBy(sqlWhere, paras)));
		}

		public virtual ACPanelFunctionCardMapDataCollection GetByACFunctionCard(System.Guid ACFunctionCardPK)
		{
			if (base.IsTrusted)
			{
				return this.Processing(this._dal.GetByACFunctionCard(ACFunctionCardPK));
			}

			if (!base.IsAuthorizedSelect)
			{
				return null;
			}

			return this.Processing((ACPanelFunctionCardMapDataCollection) base.Filter(this._dal.GetByACFunctionCard(ACFunctionCardPK)));
		}

		public ACPanelFunctionCardMapViewCollection GetViewByACFunctionCard(System.Guid ACFunctionCardPK)
		{
			return new ACPanelFunctionCardMapViewCollection(this.GetByACFunctionCard(ACFunctionCardPK));
		}

		public virtual ACPanelFunctionCardMapDataCollection GetByACPanel(System.Guid ACPanelPK)
		{
			if (base.IsTrusted)
			{
				return this.Processing(this._dal.GetByACPanel(ACPanelPK));
			}

			if (!base.IsAuthorizedSelect)
			{
				return null;
			}

			return this.Processing((ACPanelFunctionCardMapDataCollection) base.Filter(this._dal.GetByACPanel(ACPanelPK)));
		}

		public ACPanelFunctionCardMapViewCollection GetViewByACPanel(System.Guid ACPanelPK)
		{
			return new ACPanelFunctionCardMapViewCollection(this.GetByACPanel(ACPanelPK));
		}

		protected virtual ACPanelFunctionCardMapData Processing(ACPanelFunctionCardMapData entity)
		{
			return entity;
		}

		protected virtual ACPanelFunctionCardMapDataCollection Processing(ACPanelFunctionCardMapDataCollection list)
		{
			ACPanelFunctionCardMapDataCollection retList = new ACPanelFunctionCardMapDataCollection();
			foreach(ACPanelFunctionCardMapData item in list)
			{
				ACPanelFunctionCardMapData data = this.Processing(item);
				if(data != null)
				{
					retList.Add(data);
				}
			}

			return retList;
		}

		public virtual Result Save(ACPanelFunctionCardMapData entity)
		{
			return base.Save(entity);
		}

		public virtual void SaveUnderTransaction(ACPanelFunctionCardMapData entity)
		{
			base.SaveUnderTransaction(entity);
		}

		public virtual Result Save(ACPanelFunctionCardMapDataCollection list)
		{
			return base.Save(list);
		}

		public virtual void SaveUnderTransaction(ACPanelFunctionCardMapDataCollection list)
		{
			base.SaveUnderTransaction(list);
		}


	}
	public abstract class UtilHolidayDataServiceBase : ServiceBase
	{
		protected UtilHolidayCRUD _dal;

		public UtilHolidayDataServiceBase(string connectionString, SecurityToken token) : base(connectionString, token)
		{
			this._dal = new UtilHolidayCRUD(connectionString);
			for (int i = 0; i < token.GetSortFields().Count; i++)
			{
				SortField field = token.GetSortFields()[i];
				this._dal.AddSortBy(field.FieldAlias, field.ASC);
			}
		}

		protected override string TableName
		{
			get
			{
				return "UtilHoliday";
			}
		}

		protected abstract ACIntvalHolidayMapDataServiceBase GetACIntvalHolidayMapDataServiceBase(SecurityToken token);
		protected abstract ACPanelHolidayMapDataServiceBase GetACPanelHolidayMapDataServiceBase(SecurityToken token);
		protected abstract BDBuildingHolidayMapDataServiceBase GetBDBuildingHolidayMapDataServiceBase(SecurityToken token);
		protected abstract BDTenantHolidayMapDataServiceBase GetBDTenantHolidayMapDataServiceBase(SecurityToken token);

		protected override int DeleteEntity(BusinessBase entity)
		{
			UtilHolidayData data = (UtilHolidayData) entity;
			if(data == null)
				return 0;

			this.GetACIntvalHolidayMapDataServiceBase(base.SecurityToken).DeleteByUtilHoliday(data);
			this.GetACPanelHolidayMapDataServiceBase(base.SecurityToken).DeleteByUtilHoliday(data);
			this.GetBDBuildingHolidayMapDataServiceBase(base.SecurityToken).DeleteByUtilHoliday(data);
			this.GetBDTenantHolidayMapDataServiceBase(base.SecurityToken).DeleteByUtilHoliday(data);
			return this._dal.DeleteByPK( data.UtilHolidayPK, data.RowVersion);
		}

		public virtual Result Purge(UtilHolidayData entity)
		{
			return base.Purge(entity);
		}

		protected override int PurgeEntity(BusinessBase entity)
		{
			UtilHolidayData data = (UtilHolidayData) entity;
			if(data == null)
				return 0;

			this.GetACIntvalHolidayMapDataServiceBase(base.SecurityToken).PurgeByUtilHoliday(data);
			this.GetACPanelHolidayMapDataServiceBase(base.SecurityToken).PurgeByUtilHoliday(data);
			this.GetBDBuildingHolidayMapDataServiceBase(base.SecurityToken).PurgeByUtilHoliday(data);
			this.GetBDTenantHolidayMapDataServiceBase(base.SecurityToken).PurgeByUtilHoliday(data);
			return this._dal.DeleteByPK( data.UtilHolidayPK, data.RowVersion);
		}

		protected override int InsertEntity(BusinessBase entity)
		{
			UtilHolidayData data = (UtilHolidayData) entity;
			if(data == null)
				return 0;

			return this._dal.Insert(data);
		}

		protected override int UpdateEntity(BusinessBase entity)
		{
			UtilHolidayData data = (UtilHolidayData) entity;
			if(data == null)
				return 0;

			return this._dal.Update(data);
		}

		protected override void UpdateChildren(BusinessBase entity)
		{
			UtilHolidayData data = (UtilHolidayData) entity;
			if(data == null)
				return;

			if (data.ACIntvalHolidayMapList != null)
			{
				 this.GetACIntvalHolidayMapDataServiceBase(base.SecurityToken).SaveUnderTransaction(data.ACIntvalHolidayMapList);
			}
			if (data.ACPanelHolidayMapList != null)
			{
				 this.GetACPanelHolidayMapDataServiceBase(base.SecurityToken).SaveUnderTransaction(data.ACPanelHolidayMapList);
			}
			if (data.BDBuildingHolidayMapList != null)
			{
				 this.GetBDBuildingHolidayMapDataServiceBase(base.SecurityToken).SaveUnderTransaction(data.BDBuildingHolidayMapList);
			}
			if (data.BDTenantHolidayMapList != null)
			{
				 this.GetBDTenantHolidayMapDataServiceBase(base.SecurityToken).SaveUnderTransaction(data.BDTenantHolidayMapList);
			}
		}

		internal Result GetRowVersion(UtilHolidayDataCollection list)
		{
			return base.GetRowVersion(list);
		}

		protected override Result GetRowVersion(BusinessBase entity)
		{
			UtilHolidayData data = (UtilHolidayData) entity;
			if(data == null || !data.IsDirty)
				return new Result(true);

			Result result = new Result(true);
			if (entity.IsDeleted)
			{
				result.Add(data.ObjectID, new byte[0]);
				return result;
			}

			if (entity.IsSelfDirty)
			{
				result.Add(data.ObjectID, this._dal.GetRowVersion( data.UtilHolidayPK));
			}
			if (data.ACIntvalHolidayMapList != null && data.ACIntvalHolidayMapList.Count > 0)
			{
				result.Add(this.GetACIntvalHolidayMapDataServiceBase(base.SecurityToken).GetRowVersion(data.ACIntvalHolidayMapList));
			}
			if (data.ACPanelHolidayMapList != null && data.ACPanelHolidayMapList.Count > 0)
			{
				result.Add(this.GetACPanelHolidayMapDataServiceBase(base.SecurityToken).GetRowVersion(data.ACPanelHolidayMapList));
			}
			if (data.BDBuildingHolidayMapList != null && data.BDBuildingHolidayMapList.Count > 0)
			{
				result.Add(this.GetBDBuildingHolidayMapDataServiceBase(base.SecurityToken).GetRowVersion(data.BDBuildingHolidayMapList));
			}
			if (data.BDTenantHolidayMapList != null && data.BDTenantHolidayMapList.Count > 0)
			{
				result.Add(this.GetBDTenantHolidayMapDataServiceBase(base.SecurityToken).GetRowVersion(data.BDTenantHolidayMapList));
			}
			return result;
		}

		public virtual UtilHolidayData GetByPK( System.Guid UtilHolidayPK)
		{
			if (base.IsTrusted)
			{
				return this.Processing(this._dal.GetByPK( UtilHolidayPK));
			}

			if (!base.IsAuthorizedSelect)
			{
				return null;
			}

			return this.Processing((UtilHolidayData) base.Filter(this._dal.GetByPK( UtilHolidayPK)));
		}

		protected virtual UtilHolidayData GetEntity(string sqlWhere, SqlParameter[] paras)
		{
			if (base.IsTrusted)
			{
				return this.Processing(this._dal.GetEntityBy(sqlWhere, paras));
			}

			if (!base.IsAuthorizedSelect)
			{
				return null;
			}

			return this.Processing((UtilHolidayData) base.Filter(this._dal.GetEntityBy(sqlWhere, paras)));
		}

		public virtual UtilHolidayDataCollection GetAll()
		{
			if (base.IsTrusted)
			{
				return this.Processing(this._dal.GetAll());
			}

			if (!base.IsAuthorizedSelect)
			{
				return new UtilHolidayDataCollection();
			}

			return this.Processing((UtilHolidayDataCollection) base.Filter(this._dal.GetAll()));
		}

		public UtilHolidayViewCollection GetViewAll()
		{
			return new UtilHolidayViewCollection(this.GetAll());
		}

		protected virtual UtilHolidayDataCollection GetCollection(string sqlWhere, SqlParameter[] paras)
		{
			if (base.IsTrusted)
			{
				return this.Processing(this._dal.GetCollectionBy(sqlWhere, paras));
			}

			if (!base.IsAuthorizedSelect)
			{
				return new UtilHolidayDataCollection();
			}

			 return this.Processing((UtilHolidayDataCollection) base.Filter(this._dal.GetCollectionBy(sqlWhere, paras)));
		}

		protected virtual UtilHolidayData Processing(UtilHolidayData entity)
		{
			return entity;
		}

		protected virtual UtilHolidayDataCollection Processing(UtilHolidayDataCollection list)
		{
			UtilHolidayDataCollection retList = new UtilHolidayDataCollection();
			foreach(UtilHolidayData item in list)
			{
				UtilHolidayData data = this.Processing(item);
				if(data != null)
				{
					retList.Add(data);
				}
			}

			return retList;
		}

		public virtual Result Save(UtilHolidayData entity)
		{
			return base.Save(entity);
		}

		public virtual void SaveUnderTransaction(UtilHolidayData entity)
		{
			base.SaveUnderTransaction(entity);
		}

		public virtual Result Save(UtilHolidayDataCollection list)
		{
			return base.Save(list);
		}

		public virtual void SaveUnderTransaction(UtilHolidayDataCollection list)
		{
			base.SaveUnderTransaction(list);
		}


	}
	public abstract class LogDBDeleteActivityDataServiceBase : ServiceBase
	{
		protected LogDBDeleteActivityCRUD _dal;

		public LogDBDeleteActivityDataServiceBase(string connectionString, SecurityToken token) : base(connectionString, token)
		{
			this._dal = new LogDBDeleteActivityCRUD(connectionString);
			for (int i = 0; i < token.GetSortFields().Count; i++)
			{
				SortField field = token.GetSortFields()[i];
				this._dal.AddSortBy(field.FieldAlias, field.ASC);
			}
		}

		protected override string TableName
		{
			get
			{
				return "LogDBDeleteActivity";
			}
		}


		protected override int DeleteEntity(BusinessBase entity)
		{
			LogDBDeleteActivityData data = (LogDBDeleteActivityData) entity;
			if(data == null)
				return 0;

			return this._dal.DeleteByPK( data.LogDBDeleteActivityPK, data.RowVersion);
		}

		public virtual Result Purge(LogDBDeleteActivityData entity)
		{
			return base.Purge(entity);
		}

		protected override int PurgeEntity(BusinessBase entity)
		{
			LogDBDeleteActivityData data = (LogDBDeleteActivityData) entity;
			if(data == null)
				return 0;

			return this._dal.DeleteByPK( data.LogDBDeleteActivityPK, data.RowVersion);
		}

		protected override int InsertEntity(BusinessBase entity)
		{
			LogDBDeleteActivityData data = (LogDBDeleteActivityData) entity;
			if(data == null)
				return 0;

			return this._dal.Insert(data);
		}

		protected override int UpdateEntity(BusinessBase entity)
		{
			LogDBDeleteActivityData data = (LogDBDeleteActivityData) entity;
			if(data == null)
				return 0;

			return this._dal.Update(data);
		}

		protected override void UpdateChildren(BusinessBase entity)
		{
			LogDBDeleteActivityData data = (LogDBDeleteActivityData) entity;
			if(data == null)
				return;

		}

		internal Result GetRowVersion(LogDBDeleteActivityDataCollection list)
		{
			return base.GetRowVersion(list);
		}

		protected override Result GetRowVersion(BusinessBase entity)
		{
			LogDBDeleteActivityData data = (LogDBDeleteActivityData) entity;
			if(data == null || !data.IsDirty)
				return new Result(true);

			Result result = new Result(true);
			if (entity.IsDeleted)
			{
				result.Add(data.ObjectID, new byte[0]);
				return result;
			}

			if (entity.IsSelfDirty)
			{
				result.Add(data.ObjectID, this._dal.GetRowVersion( data.LogDBDeleteActivityPK));
			}
			return result;
		}

		public virtual LogDBDeleteActivityData GetByPK( System.Guid LogDBDeleteActivityPK)
		{
			if (base.IsTrusted)
			{
				return this.Processing(this._dal.GetByPK( LogDBDeleteActivityPK));
			}

			if (!base.IsAuthorizedSelect)
			{
				return null;
			}

			return this.Processing((LogDBDeleteActivityData) base.Filter(this._dal.GetByPK( LogDBDeleteActivityPK)));
		}

		protected virtual LogDBDeleteActivityData GetEntity(string sqlWhere, SqlParameter[] paras)
		{
			if (base.IsTrusted)
			{
				return this.Processing(this._dal.GetEntityBy(sqlWhere, paras));
			}

			if (!base.IsAuthorizedSelect)
			{
				return null;
			}

			return this.Processing((LogDBDeleteActivityData) base.Filter(this._dal.GetEntityBy(sqlWhere, paras)));
		}

		public virtual LogDBDeleteActivityDataCollection GetAll()
		{
			if (base.IsTrusted)
			{
				return this.Processing(this._dal.GetAll());
			}

			if (!base.IsAuthorizedSelect)
			{
				return new LogDBDeleteActivityDataCollection();
			}

			return this.Processing((LogDBDeleteActivityDataCollection) base.Filter(this._dal.GetAll()));
		}

		public LogDBDeleteActivityViewCollection GetViewAll()
		{
			return new LogDBDeleteActivityViewCollection(this.GetAll());
		}

		protected virtual LogDBDeleteActivityDataCollection GetCollection(string sqlWhere, SqlParameter[] paras)
		{
			if (base.IsTrusted)
			{
				return this.Processing(this._dal.GetCollectionBy(sqlWhere, paras));
			}

			if (!base.IsAuthorizedSelect)
			{
				return new LogDBDeleteActivityDataCollection();
			}

			 return this.Processing((LogDBDeleteActivityDataCollection) base.Filter(this._dal.GetCollectionBy(sqlWhere, paras)));
		}

		protected virtual LogDBDeleteActivityData Processing(LogDBDeleteActivityData entity)
		{
			return entity;
		}

		protected virtual LogDBDeleteActivityDataCollection Processing(LogDBDeleteActivityDataCollection list)
		{
			LogDBDeleteActivityDataCollection retList = new LogDBDeleteActivityDataCollection();
			foreach(LogDBDeleteActivityData item in list)
			{
				LogDBDeleteActivityData data = this.Processing(item);
				if(data != null)
				{
					retList.Add(data);
				}
			}

			return retList;
		}

		public virtual Result Save(LogDBDeleteActivityData entity)
		{
			return base.Save(entity);
		}

		public virtual void SaveUnderTransaction(LogDBDeleteActivityData entity)
		{
			base.SaveUnderTransaction(entity);
		}

		public virtual Result Save(LogDBDeleteActivityDataCollection list)
		{
			return base.Save(list);
		}

		public virtual void SaveUnderTransaction(LogDBDeleteActivityDataCollection list)
		{
			base.SaveUnderTransaction(list);
		}


	}
	public abstract class UsrAccountDataServiceBase : ServiceBase
	{
		protected UsrAccountCRUD _dal;

		public UsrAccountDataServiceBase(string connectionString, SecurityToken token) : base(connectionString, token)
		{
			this._dal = new UsrAccountCRUD(connectionString);
			for (int i = 0; i < token.GetSortFields().Count; i++)
			{
				SortField field = token.GetSortFields()[i];
				this._dal.AddSortBy(field.FieldAlias, field.ASC);
			}
		}

		protected override string TableName
		{
			get
			{
				return "UsrAccount";
			}
		}

		protected abstract UsrAccountBuildingMapDataServiceBase GetUsrAccountBuildingMapDataServiceBase(SecurityToken token);
		protected abstract UsrAccountBRRuleDataServiceBase GetUsrAccountBRRuleDataServiceBase(SecurityToken token);
		protected abstract UsrAccountDBRuleDataServiceBase GetUsrAccountDBRuleDataServiceBase(SecurityToken token);
		protected abstract UsrAccountTenantMapDataServiceBase GetUsrAccountTenantMapDataServiceBase(SecurityToken token);

		protected override int DeleteEntity(BusinessBase entity)
		{
			UsrAccountData data = (UsrAccountData) entity;
			if(data == null)
				return 0;

			this.GetUsrAccountBuildingMapDataServiceBase(base.SecurityToken).DeleteByUsrAccount(data);
			this.GetUsrAccountBRRuleDataServiceBase(base.SecurityToken).DeleteByUsrAccount(data);
			this.GetUsrAccountDBRuleDataServiceBase(base.SecurityToken).DeleteByUsrAccount(data);
			this.GetUsrAccountTenantMapDataServiceBase(base.SecurityToken).DeleteByUsrAccount(data);
			return this._dal.DeleteByPK( data.UsrAccountPK, data.RowVersion);
		}

		internal int DeleteByBDTenant(BusinessBase entity)
		{
			BDTenantData data = (BDTenantData) entity;
			if(data == null)
				return 0;

			this.GetUsrAccountBuildingMapDataServiceBase(base.SecurityToken).DeleteByBDTenant(entity);
			this.GetUsrAccountBRRuleDataServiceBase(base.SecurityToken).DeleteByBDTenant(entity);
			this.GetUsrAccountDBRuleDataServiceBase(base.SecurityToken).DeleteByBDTenant(entity);
			this.GetUsrAccountTenantMapDataServiceBase(base.SecurityToken).DeleteByBDTenant(entity);
			bool isLogDeleteEnabled = ServiceBase._DBLog.IsLogDeleteEnabled;
			bool isLinkDBDeleteEnabled = ServiceBase._DBLink.IsLinkDBDeleteEnabled;
			if (!isLogDeleteEnabled && !isLinkDBDeleteEnabled)
			{
				return this._dal.DeleteByBDTenant(data. BDTenantPK);
			}

			DataTable list = this._dal.GetLogByBDTenant(data. BDTenantPK);
			list.TableName = this._dal.TableName;
			int ret = this._dal.DeleteByBDTenant(data. BDTenantPK);
			if (isLogDeleteEnabled)
			{
				ServiceBase._DBLog.LogDelete(list, base.SecurityToken);
			}

			if (isLinkDBDeleteEnabled)
			{
				ServiceBase._DBLink.LinkDBDelete(list, base.TrustedToken);
			}

			return ret;
		}

		internal int DeleteByBDBuilding(BusinessBase entity)
		{
			BDBuildingData data = (BDBuildingData) entity;
			if(data == null)
				return 0;

			this.GetUsrAccountBuildingMapDataServiceBase(base.SecurityToken).DeleteByBDBuilding(entity);
			this.GetUsrAccountBRRuleDataServiceBase(base.SecurityToken).DeleteByBDBuilding(entity);
			this.GetUsrAccountDBRuleDataServiceBase(base.SecurityToken).DeleteByBDBuilding(entity);
			this.GetUsrAccountTenantMapDataServiceBase(base.SecurityToken).DeleteByBDBuilding(entity);
			bool isLogDeleteEnabled = ServiceBase._DBLog.IsLogDeleteEnabled;
			bool isLinkDBDeleteEnabled = ServiceBase._DBLink.IsLinkDBDeleteEnabled;
			if (!isLogDeleteEnabled && !isLinkDBDeleteEnabled)
			{
				return this._dal.DeleteByBDBuilding(data. BDBuildingPK);
			}

			DataTable list = this._dal.GetLogByBDBuilding(data. BDBuildingPK);
			list.TableName = this._dal.TableName;
			int ret = this._dal.DeleteByBDBuilding(data. BDBuildingPK);
			if (isLogDeleteEnabled)
			{
				ServiceBase._DBLog.LogDelete(list, base.SecurityToken);
			}

			if (isLinkDBDeleteEnabled)
			{
				ServiceBase._DBLink.LinkDBDelete(list, base.TrustedToken);
			}

			return ret;
		}

		internal int DeleteByUsrGroup(BusinessBase entity)
		{
			UsrGroupData data = (UsrGroupData) entity;
			if(data == null)
				return 0;

			this.GetUsrAccountBuildingMapDataServiceBase(base.SecurityToken).DeleteByUsrGroup(entity);
			this.GetUsrAccountBRRuleDataServiceBase(base.SecurityToken).DeleteByUsrGroup(entity);
			this.GetUsrAccountDBRuleDataServiceBase(base.SecurityToken).DeleteByUsrGroup(entity);
			this.GetUsrAccountTenantMapDataServiceBase(base.SecurityToken).DeleteByUsrGroup(entity);
			bool isLogDeleteEnabled = ServiceBase._DBLog.IsLogDeleteEnabled;
			bool isLinkDBDeleteEnabled = ServiceBase._DBLink.IsLinkDBDeleteEnabled;
			if (!isLogDeleteEnabled && !isLinkDBDeleteEnabled)
			{
				return this._dal.DeleteByUsrGroup(data. UsrGroupPK);
			}

			DataTable list = this._dal.GetLogByUsrGroup(data. UsrGroupPK);
			list.TableName = this._dal.TableName;
			int ret = this._dal.DeleteByUsrGroup(data. UsrGroupPK);
			if (isLogDeleteEnabled)
			{
				ServiceBase._DBLog.LogDelete(list, base.SecurityToken);
			}

			if (isLinkDBDeleteEnabled)
			{
				ServiceBase._DBLink.LinkDBDelete(list, base.TrustedToken);
			}

			return ret;
		}

		public virtual Result Purge(UsrAccountData entity)
		{
			return base.Purge(entity);
		}

		protected override int PurgeEntity(BusinessBase entity)
		{
			UsrAccountData data = (UsrAccountData) entity;
			if(data == null)
				return 0;

			this.GetUsrAccountBuildingMapDataServiceBase(base.SecurityToken).PurgeByUsrAccount(data);
			this.GetUsrAccountBRRuleDataServiceBase(base.SecurityToken).PurgeByUsrAccount(data);
			this.GetUsrAccountDBRuleDataServiceBase(base.SecurityToken).PurgeByUsrAccount(data);
			this.GetUsrAccountTenantMapDataServiceBase(base.SecurityToken).PurgeByUsrAccount(data);
			return this._dal.DeleteByPK( data.UsrAccountPK, data.RowVersion);
		}

		internal int PurgeByBDTenant(BusinessBase entity)
		{
			BDTenantData data = (BDTenantData) entity;
			if(data == null)
				return 0;

			this.GetUsrAccountBuildingMapDataServiceBase(base.SecurityToken).PurgeByBDTenant(entity);
			this.GetUsrAccountBRRuleDataServiceBase(base.SecurityToken).PurgeByBDTenant(entity);
			this.GetUsrAccountDBRuleDataServiceBase(base.SecurityToken).PurgeByBDTenant(entity);
			this.GetUsrAccountTenantMapDataServiceBase(base.SecurityToken).PurgeByBDTenant(entity);
			return this._dal.DeleteByBDTenant(data. BDTenantPK);
		}

		internal int PurgeByBDBuilding(BusinessBase entity)
		{
			BDBuildingData data = (BDBuildingData) entity;
			if(data == null)
				return 0;

			this.GetUsrAccountBuildingMapDataServiceBase(base.SecurityToken).PurgeByBDBuilding(entity);
			this.GetUsrAccountBRRuleDataServiceBase(base.SecurityToken).PurgeByBDBuilding(entity);
			this.GetUsrAccountDBRuleDataServiceBase(base.SecurityToken).PurgeByBDBuilding(entity);
			this.GetUsrAccountTenantMapDataServiceBase(base.SecurityToken).PurgeByBDBuilding(entity);
			return this._dal.DeleteByBDBuilding(data. BDBuildingPK);
		}

		internal int PurgeByUsrGroup(BusinessBase entity)
		{
			UsrGroupData data = (UsrGroupData) entity;
			if(data == null)
				return 0;

			this.GetUsrAccountBuildingMapDataServiceBase(base.SecurityToken).PurgeByUsrGroup(entity);
			this.GetUsrAccountBRRuleDataServiceBase(base.SecurityToken).PurgeByUsrGroup(entity);
			this.GetUsrAccountDBRuleDataServiceBase(base.SecurityToken).PurgeByUsrGroup(entity);
			this.GetUsrAccountTenantMapDataServiceBase(base.SecurityToken).PurgeByUsrGroup(entity);
			return this._dal.DeleteByUsrGroup(data. UsrGroupPK);
		}

		protected override int InsertEntity(BusinessBase entity)
		{
			UsrAccountData data = (UsrAccountData) entity;
			if(data == null)
				return 0;

			return this._dal.Insert(data);
		}

		protected override int UpdateEntity(BusinessBase entity)
		{
			UsrAccountData data = (UsrAccountData) entity;
			if(data == null)
				return 0;

			return this._dal.Update(data);
		}

		protected override void UpdateChildren(BusinessBase entity)
		{
			UsrAccountData data = (UsrAccountData) entity;
			if(data == null)
				return;

			if (data.UsrAccountBuildingMapList != null)
			{
				 this.GetUsrAccountBuildingMapDataServiceBase(base.SecurityToken).SaveUnderTransaction(data.UsrAccountBuildingMapList);
			}
			if (data.UsrAccountBRRuleList != null)
			{
				 this.GetUsrAccountBRRuleDataServiceBase(base.SecurityToken).SaveUnderTransaction(data.UsrAccountBRRuleList);
			}
			if (data.UsrAccountDBRuleList != null)
			{
				 this.GetUsrAccountDBRuleDataServiceBase(base.SecurityToken).SaveUnderTransaction(data.UsrAccountDBRuleList);
			}
			if (data.UsrAccountTenantMapList != null)
			{
				 this.GetUsrAccountTenantMapDataServiceBase(base.SecurityToken).SaveUnderTransaction(data.UsrAccountTenantMapList);
			}
		}

		internal Result GetRowVersion(UsrAccountDataCollection list)
		{
			return base.GetRowVersion(list);
		}

		protected override Result GetRowVersion(BusinessBase entity)
		{
			UsrAccountData data = (UsrAccountData) entity;
			if(data == null || !data.IsDirty)
				return new Result(true);

			Result result = new Result(true);
			if (entity.IsDeleted)
			{
				result.Add(data.ObjectID, new byte[0]);
				return result;
			}

			if (entity.IsSelfDirty)
			{
				result.Add(data.ObjectID, this._dal.GetRowVersion( data.UsrAccountPK));
			}
			if (data.UsrAccountBuildingMapList != null && data.UsrAccountBuildingMapList.Count > 0)
			{
				result.Add(this.GetUsrAccountBuildingMapDataServiceBase(base.SecurityToken).GetRowVersion(data.UsrAccountBuildingMapList));
			}
			if (data.UsrAccountBRRuleList != null && data.UsrAccountBRRuleList.Count > 0)
			{
				result.Add(this.GetUsrAccountBRRuleDataServiceBase(base.SecurityToken).GetRowVersion(data.UsrAccountBRRuleList));
			}
			if (data.UsrAccountDBRuleList != null && data.UsrAccountDBRuleList.Count > 0)
			{
				result.Add(this.GetUsrAccountDBRuleDataServiceBase(base.SecurityToken).GetRowVersion(data.UsrAccountDBRuleList));
			}
			if (data.UsrAccountTenantMapList != null && data.UsrAccountTenantMapList.Count > 0)
			{
				result.Add(this.GetUsrAccountTenantMapDataServiceBase(base.SecurityToken).GetRowVersion(data.UsrAccountTenantMapList));
			}
			return result;
		}

		public virtual UsrAccountData GetByPK( System.Guid UsrAccountPK)
		{
			if (base.IsTrusted)
			{
				return this.Processing(this._dal.GetByPK( UsrAccountPK));
			}

			if (!base.IsAuthorizedSelect)
			{
				return null;
			}

			return this.Processing((UsrAccountData) base.Filter(this._dal.GetByPK( UsrAccountPK)));
		}

		protected virtual UsrAccountData GetEntity(string sqlWhere, SqlParameter[] paras)
		{
			if (base.IsTrusted)
			{
				return this.Processing(this._dal.GetEntityBy(sqlWhere, paras));
			}

			if (!base.IsAuthorizedSelect)
			{
				return null;
			}

			return this.Processing((UsrAccountData) base.Filter(this._dal.GetEntityBy(sqlWhere, paras)));
		}

		public virtual UsrAccountDataCollection GetAll()
		{
			if (base.IsTrusted)
			{
				return this.Processing(this._dal.GetAll());
			}

			if (!base.IsAuthorizedSelect)
			{
				return new UsrAccountDataCollection();
			}

			return this.Processing((UsrAccountDataCollection) base.Filter(this._dal.GetAll()));
		}

		public UsrAccountViewCollection GetViewAll()
		{
			return new UsrAccountViewCollection(this.GetAll());
		}

		protected virtual UsrAccountDataCollection GetCollection(string sqlWhere, SqlParameter[] paras)
		{
			if (base.IsTrusted)
			{
				return this.Processing(this._dal.GetCollectionBy(sqlWhere, paras));
			}

			if (!base.IsAuthorizedSelect)
			{
				return new UsrAccountDataCollection();
			}

			 return this.Processing((UsrAccountDataCollection) base.Filter(this._dal.GetCollectionBy(sqlWhere, paras)));
		}

		public virtual UsrAccountDataCollection GetByBDTenant(System.Guid BDTenantPK)
		{
			if (base.IsTrusted)
			{
				return this.Processing(this._dal.GetByBDTenant(BDTenantPK));
			}

			if (!base.IsAuthorizedSelect)
			{
				return null;
			}

			return this.Processing((UsrAccountDataCollection) base.Filter(this._dal.GetByBDTenant(BDTenantPK)));
		}

		public UsrAccountViewCollection GetViewByBDTenant(System.Guid BDTenantPK)
		{
			return new UsrAccountViewCollection(this.GetByBDTenant(BDTenantPK));
		}

		public virtual UsrAccountDataCollection GetByUsrGroup(System.Guid UsrGroupPK)
		{
			if (base.IsTrusted)
			{
				return this.Processing(this._dal.GetByUsrGroup(UsrGroupPK));
			}

			if (!base.IsAuthorizedSelect)
			{
				return null;
			}

			return this.Processing((UsrAccountDataCollection) base.Filter(this._dal.GetByUsrGroup(UsrGroupPK)));
		}

		public UsrAccountViewCollection GetViewByUsrGroup(System.Guid UsrGroupPK)
		{
			return new UsrAccountViewCollection(this.GetByUsrGroup(UsrGroupPK));
		}

		protected virtual UsrAccountData Processing(UsrAccountData entity)
		{
			return entity;
		}

		protected virtual UsrAccountDataCollection Processing(UsrAccountDataCollection list)
		{
			UsrAccountDataCollection retList = new UsrAccountDataCollection();
			foreach(UsrAccountData item in list)
			{
				UsrAccountData data = this.Processing(item);
				if(data != null)
				{
					retList.Add(data);
				}
			}

			return retList;
		}

		public virtual Result Save(UsrAccountData entity)
		{
			return base.Save(entity);
		}

		public virtual void SaveUnderTransaction(UsrAccountData entity)
		{
			base.SaveUnderTransaction(entity);
		}

		public virtual Result Save(UsrAccountDataCollection list)
		{
			return base.Save(list);
		}

		public virtual void SaveUnderTransaction(UsrAccountDataCollection list)
		{
			base.SaveUnderTransaction(list);
		}


	}
	public abstract class LogDBEditActivityDataServiceBase : ServiceBase
	{
		protected LogDBEditActivityCRUD _dal;

		public LogDBEditActivityDataServiceBase(string connectionString, SecurityToken token) : base(connectionString, token)
		{
			this._dal = new LogDBEditActivityCRUD(connectionString);
			for (int i = 0; i < token.GetSortFields().Count; i++)
			{
				SortField field = token.GetSortFields()[i];
				this._dal.AddSortBy(field.FieldAlias, field.ASC);
			}
		}

		protected override string TableName
		{
			get
			{
				return "LogDBEditActivity";
			}
		}


		protected override int DeleteEntity(BusinessBase entity)
		{
			LogDBEditActivityData data = (LogDBEditActivityData) entity;
			if(data == null)
				return 0;

			return this._dal.DeleteByPK( data.LogDBEditActivityPK, data.RowVersion);
		}

		public virtual Result Purge(LogDBEditActivityData entity)
		{
			return base.Purge(entity);
		}

		protected override int PurgeEntity(BusinessBase entity)
		{
			LogDBEditActivityData data = (LogDBEditActivityData) entity;
			if(data == null)
				return 0;

			return this._dal.DeleteByPK( data.LogDBEditActivityPK, data.RowVersion);
		}

		protected override int InsertEntity(BusinessBase entity)
		{
			LogDBEditActivityData data = (LogDBEditActivityData) entity;
			if(data == null)
				return 0;

			return this._dal.Insert(data);
		}

		protected override int UpdateEntity(BusinessBase entity)
		{
			LogDBEditActivityData data = (LogDBEditActivityData) entity;
			if(data == null)
				return 0;

			return this._dal.Update(data);
		}

		protected override void UpdateChildren(BusinessBase entity)
		{
			LogDBEditActivityData data = (LogDBEditActivityData) entity;
			if(data == null)
				return;

		}

		internal Result GetRowVersion(LogDBEditActivityDataCollection list)
		{
			return base.GetRowVersion(list);
		}

		protected override Result GetRowVersion(BusinessBase entity)
		{
			LogDBEditActivityData data = (LogDBEditActivityData) entity;
			if(data == null || !data.IsDirty)
				return new Result(true);

			Result result = new Result(true);
			if (entity.IsDeleted)
			{
				result.Add(data.ObjectID, new byte[0]);
				return result;
			}

			if (entity.IsSelfDirty)
			{
				result.Add(data.ObjectID, this._dal.GetRowVersion( data.LogDBEditActivityPK));
			}
			return result;
		}

		public virtual LogDBEditActivityData GetByPK( System.Guid LogDBEditActivityPK)
		{
			if (base.IsTrusted)
			{
				return this.Processing(this._dal.GetByPK( LogDBEditActivityPK));
			}

			if (!base.IsAuthorizedSelect)
			{
				return null;
			}

			return this.Processing((LogDBEditActivityData) base.Filter(this._dal.GetByPK( LogDBEditActivityPK)));
		}

		protected virtual LogDBEditActivityData GetEntity(string sqlWhere, SqlParameter[] paras)
		{
			if (base.IsTrusted)
			{
				return this.Processing(this._dal.GetEntityBy(sqlWhere, paras));
			}

			if (!base.IsAuthorizedSelect)
			{
				return null;
			}

			return this.Processing((LogDBEditActivityData) base.Filter(this._dal.GetEntityBy(sqlWhere, paras)));
		}

		public virtual LogDBEditActivityDataCollection GetAll()
		{
			if (base.IsTrusted)
			{
				return this.Processing(this._dal.GetAll());
			}

			if (!base.IsAuthorizedSelect)
			{
				return new LogDBEditActivityDataCollection();
			}

			return this.Processing((LogDBEditActivityDataCollection) base.Filter(this._dal.GetAll()));
		}

		public LogDBEditActivityViewCollection GetViewAll()
		{
			return new LogDBEditActivityViewCollection(this.GetAll());
		}

		protected virtual LogDBEditActivityDataCollection GetCollection(string sqlWhere, SqlParameter[] paras)
		{
			if (base.IsTrusted)
			{
				return this.Processing(this._dal.GetCollectionBy(sqlWhere, paras));
			}

			if (!base.IsAuthorizedSelect)
			{
				return new LogDBEditActivityDataCollection();
			}

			 return this.Processing((LogDBEditActivityDataCollection) base.Filter(this._dal.GetCollectionBy(sqlWhere, paras)));
		}

		protected virtual LogDBEditActivityData Processing(LogDBEditActivityData entity)
		{
			return entity;
		}

		protected virtual LogDBEditActivityDataCollection Processing(LogDBEditActivityDataCollection list)
		{
			LogDBEditActivityDataCollection retList = new LogDBEditActivityDataCollection();
			foreach(LogDBEditActivityData item in list)
			{
				LogDBEditActivityData data = this.Processing(item);
				if(data != null)
				{
					retList.Add(data);
				}
			}

			return retList;
		}

		public virtual Result Save(LogDBEditActivityData entity)
		{
			return base.Save(entity);
		}

		public virtual void SaveUnderTransaction(LogDBEditActivityData entity)
		{
			base.SaveUnderTransaction(entity);
		}

		public virtual Result Save(LogDBEditActivityDataCollection list)
		{
			return base.Save(list);
		}

		public virtual void SaveUnderTransaction(LogDBEditActivityDataCollection list)
		{
			base.SaveUnderTransaction(list);
		}


	}
	public abstract class ACMasterCardDataServiceBase : ServiceBase
	{
		protected ACMasterCardCRUD _dal;

		public ACMasterCardDataServiceBase(string connectionString, SecurityToken token) : base(connectionString, token)
		{
			this._dal = new ACMasterCardCRUD(connectionString);
			for (int i = 0; i < token.GetSortFields().Count; i++)
			{
				SortField field = token.GetSortFields()[i];
				this._dal.AddSortBy(field.FieldAlias, field.ASC);
			}
		}

		protected override string TableName
		{
			get
			{
				return "ACMasterCard";
			}
		}


		protected override int DeleteEntity(BusinessBase entity)
		{
			ACMasterCardData data = (ACMasterCardData) entity;
			if(data == null)
				return 0;

			return this._dal.DeleteByPK( data.ACMasterCardPK, data.RowVersion);
		}

		public virtual Result Purge(ACMasterCardData entity)
		{
			return base.Purge(entity);
		}

		protected override int PurgeEntity(BusinessBase entity)
		{
			ACMasterCardData data = (ACMasterCardData) entity;
			if(data == null)
				return 0;

			return this._dal.DeleteByPK( data.ACMasterCardPK, data.RowVersion);
		}

		protected override int InsertEntity(BusinessBase entity)
		{
			ACMasterCardData data = (ACMasterCardData) entity;
			if(data == null)
				return 0;

			return this._dal.Insert(data);
		}

		protected override int UpdateEntity(BusinessBase entity)
		{
			ACMasterCardData data = (ACMasterCardData) entity;
			if(data == null)
				return 0;

			return this._dal.Update(data);
		}

		protected override void UpdateChildren(BusinessBase entity)
		{
			ACMasterCardData data = (ACMasterCardData) entity;
			if(data == null)
				return;

		}

		internal Result GetRowVersion(ACMasterCardDataCollection list)
		{
			return base.GetRowVersion(list);
		}

		protected override Result GetRowVersion(BusinessBase entity)
		{
			ACMasterCardData data = (ACMasterCardData) entity;
			if(data == null || !data.IsDirty)
				return new Result(true);

			Result result = new Result(true);
			if (entity.IsDeleted)
			{
				result.Add(data.ObjectID, new byte[0]);
				return result;
			}

			if (entity.IsSelfDirty)
			{
				result.Add(data.ObjectID, this._dal.GetRowVersion( data.ACMasterCardPK));
			}
			return result;
		}

		public virtual ACMasterCardData GetByPK( System.Guid ACMasterCardPK)
		{
			if (base.IsTrusted)
			{
				return this.Processing(this._dal.GetByPK( ACMasterCardPK));
			}

			if (!base.IsAuthorizedSelect)
			{
				return null;
			}

			return this.Processing((ACMasterCardData) base.Filter(this._dal.GetByPK( ACMasterCardPK)));
		}

		protected virtual ACMasterCardData GetEntity(string sqlWhere, SqlParameter[] paras)
		{
			if (base.IsTrusted)
			{
				return this.Processing(this._dal.GetEntityBy(sqlWhere, paras));
			}

			if (!base.IsAuthorizedSelect)
			{
				return null;
			}

			return this.Processing((ACMasterCardData) base.Filter(this._dal.GetEntityBy(sqlWhere, paras)));
		}

		public virtual ACMasterCardDataCollection GetAll()
		{
			if (base.IsTrusted)
			{
				return this.Processing(this._dal.GetAll());
			}

			if (!base.IsAuthorizedSelect)
			{
				return new ACMasterCardDataCollection();
			}

			return this.Processing((ACMasterCardDataCollection) base.Filter(this._dal.GetAll()));
		}

		public ACMasterCardViewCollection GetViewAll()
		{
			return new ACMasterCardViewCollection(this.GetAll());
		}

		protected virtual ACMasterCardDataCollection GetCollection(string sqlWhere, SqlParameter[] paras)
		{
			if (base.IsTrusted)
			{
				return this.Processing(this._dal.GetCollectionBy(sqlWhere, paras));
			}

			if (!base.IsAuthorizedSelect)
			{
				return new ACMasterCardDataCollection();
			}

			 return this.Processing((ACMasterCardDataCollection) base.Filter(this._dal.GetCollectionBy(sqlWhere, paras)));
		}

		protected virtual ACMasterCardData Processing(ACMasterCardData entity)
		{
			return entity;
		}

		protected virtual ACMasterCardDataCollection Processing(ACMasterCardDataCollection list)
		{
			ACMasterCardDataCollection retList = new ACMasterCardDataCollection();
			foreach(ACMasterCardData item in list)
			{
				ACMasterCardData data = this.Processing(item);
				if(data != null)
				{
					retList.Add(data);
				}
			}

			return retList;
		}

		public virtual Result Save(ACMasterCardData entity)
		{
			return base.Save(entity);
		}

		public virtual void SaveUnderTransaction(ACMasterCardData entity)
		{
			base.SaveUnderTransaction(entity);
		}

		public virtual Result Save(ACMasterCardDataCollection list)
		{
			return base.Save(list);
		}

		public virtual void SaveUnderTransaction(ACMasterCardDataCollection list)
		{
			base.SaveUnderTransaction(list);
		}


	}
	public abstract class ACSupervisoryDataServiceBase : ServiceBase
	{
		protected ACSupervisoryCRUD _dal;

		public ACSupervisoryDataServiceBase(string connectionString, SecurityToken token) : base(connectionString, token)
		{
			this._dal = new ACSupervisoryCRUD(connectionString);
			for (int i = 0; i < token.GetSortFields().Count; i++)
			{
				SortField field = token.GetSortFields()[i];
				this._dal.AddSortBy(field.FieldAlias, field.ASC);
			}
		}

		protected override string TableName
		{
			get
			{
				return "ACSupervisory";
			}
		}


		protected override int DeleteEntity(BusinessBase entity)
		{
			ACSupervisoryData data = (ACSupervisoryData) entity;
			if(data == null)
				return 0;

			return this._dal.DeleteByPK( data.ACSupervisoryPK, data.RowVersion);
		}

		internal int DeleteByACPanel(BusinessBase entity)
		{
			ACPanelData data = (ACPanelData) entity;
			if(data == null)
				return 0;

			bool isLogDeleteEnabled = ServiceBase._DBLog.IsLogDeleteEnabled;
			bool isLinkDBDeleteEnabled = ServiceBase._DBLink.IsLinkDBDeleteEnabled;
			if (!isLogDeleteEnabled && !isLinkDBDeleteEnabled)
			{
				return this._dal.DeleteByACPanel(data. ACPanelPK);
			}

			DataTable list = this._dal.GetLogByACPanel(data. ACPanelPK);
			list.TableName = this._dal.TableName;
			int ret = this._dal.DeleteByACPanel(data. ACPanelPK);
			if (isLogDeleteEnabled)
			{
				ServiceBase._DBLog.LogDelete(list, base.SecurityToken);
			}

			if (isLinkDBDeleteEnabled)
			{
				ServiceBase._DBLink.LinkDBDelete(list, base.TrustedToken);
			}

			return ret;
		}

		internal int DeleteByBDBuilding(BusinessBase entity)
		{
			BDBuildingData data = (BDBuildingData) entity;
			if(data == null)
				return 0;

			bool isLogDeleteEnabled = ServiceBase._DBLog.IsLogDeleteEnabled;
			bool isLinkDBDeleteEnabled = ServiceBase._DBLink.IsLinkDBDeleteEnabled;
			if (!isLogDeleteEnabled && !isLinkDBDeleteEnabled)
			{
				return this._dal.DeleteByBDBuilding(data. BDBuildingPK);
			}

			DataTable list = this._dal.GetLogByBDBuilding(data. BDBuildingPK);
			list.TableName = this._dal.TableName;
			int ret = this._dal.DeleteByBDBuilding(data. BDBuildingPK);
			if (isLogDeleteEnabled)
			{
				ServiceBase._DBLog.LogDelete(list, base.SecurityToken);
			}

			if (isLinkDBDeleteEnabled)
			{
				ServiceBase._DBLink.LinkDBDelete(list, base.TrustedToken);
			}

			return ret;
		}

		public virtual Result Purge(ACSupervisoryData entity)
		{
			return base.Purge(entity);
		}

		protected override int PurgeEntity(BusinessBase entity)
		{
			ACSupervisoryData data = (ACSupervisoryData) entity;
			if(data == null)
				return 0;

			return this._dal.DeleteByPK( data.ACSupervisoryPK, data.RowVersion);
		}

		internal int PurgeByACPanel(BusinessBase entity)
		{
			ACPanelData data = (ACPanelData) entity;
			if(data == null)
				return 0;

			return this._dal.DeleteByACPanel(data. ACPanelPK);
		}

		internal int PurgeByBDBuilding(BusinessBase entity)
		{
			BDBuildingData data = (BDBuildingData) entity;
			if(data == null)
				return 0;

			return this._dal.DeleteByBDBuilding(data. BDBuildingPK);
		}

		protected override int InsertEntity(BusinessBase entity)
		{
			ACSupervisoryData data = (ACSupervisoryData) entity;
			if(data == null)
				return 0;

			return this._dal.Insert(data);
		}

		protected override int UpdateEntity(BusinessBase entity)
		{
			ACSupervisoryData data = (ACSupervisoryData) entity;
			if(data == null)
				return 0;

			return this._dal.Update(data);
		}

		protected override void UpdateChildren(BusinessBase entity)
		{
			ACSupervisoryData data = (ACSupervisoryData) entity;
			if(data == null)
				return;

		}

		internal Result GetRowVersion(ACSupervisoryDataCollection list)
		{
			return base.GetRowVersion(list);
		}

		protected override Result GetRowVersion(BusinessBase entity)
		{
			ACSupervisoryData data = (ACSupervisoryData) entity;
			if(data == null || !data.IsDirty)
				return new Result(true);

			Result result = new Result(true);
			if (entity.IsDeleted)
			{
				result.Add(data.ObjectID, new byte[0]);
				return result;
			}

			if (entity.IsSelfDirty)
			{
				result.Add(data.ObjectID, this._dal.GetRowVersion( data.ACSupervisoryPK));
			}
			return result;
		}

		public virtual ACSupervisoryData GetByPK( System.Guid ACSupervisoryPK)
		{
			if (base.IsTrusted)
			{
				return this.Processing(this._dal.GetByPK( ACSupervisoryPK));
			}

			if (!base.IsAuthorizedSelect)
			{
				return null;
			}

			return this.Processing((ACSupervisoryData) base.Filter(this._dal.GetByPK( ACSupervisoryPK)));
		}

		protected virtual ACSupervisoryData GetEntity(string sqlWhere, SqlParameter[] paras)
		{
			if (base.IsTrusted)
			{
				return this.Processing(this._dal.GetEntityBy(sqlWhere, paras));
			}

			if (!base.IsAuthorizedSelect)
			{
				return null;
			}

			return this.Processing((ACSupervisoryData) base.Filter(this._dal.GetEntityBy(sqlWhere, paras)));
		}

		public virtual ACSupervisoryDataCollection GetAll()
		{
			if (base.IsTrusted)
			{
				return this.Processing(this._dal.GetAll());
			}

			if (!base.IsAuthorizedSelect)
			{
				return new ACSupervisoryDataCollection();
			}

			return this.Processing((ACSupervisoryDataCollection) base.Filter(this._dal.GetAll()));
		}

		public ACSupervisoryViewCollection GetViewAll()
		{
			return new ACSupervisoryViewCollection(this.GetAll());
		}

		protected virtual ACSupervisoryDataCollection GetCollection(string sqlWhere, SqlParameter[] paras)
		{
			if (base.IsTrusted)
			{
				return this.Processing(this._dal.GetCollectionBy(sqlWhere, paras));
			}

			if (!base.IsAuthorizedSelect)
			{
				return new ACSupervisoryDataCollection();
			}

			 return this.Processing((ACSupervisoryDataCollection) base.Filter(this._dal.GetCollectionBy(sqlWhere, paras)));
		}

		public virtual ACSupervisoryDataCollection GetByACPanel(System.Guid ACPanelPK)
		{
			if (base.IsTrusted)
			{
				return this.Processing(this._dal.GetByACPanel(ACPanelPK));
			}

			if (!base.IsAuthorizedSelect)
			{
				return null;
			}

			return this.Processing((ACSupervisoryDataCollection) base.Filter(this._dal.GetByACPanel(ACPanelPK)));
		}

		public ACSupervisoryViewCollection GetViewByACPanel(System.Guid ACPanelPK)
		{
			return new ACSupervisoryViewCollection(this.GetByACPanel(ACPanelPK));
		}

		protected virtual ACSupervisoryData Processing(ACSupervisoryData entity)
		{
			return entity;
		}

		protected virtual ACSupervisoryDataCollection Processing(ACSupervisoryDataCollection list)
		{
			ACSupervisoryDataCollection retList = new ACSupervisoryDataCollection();
			foreach(ACSupervisoryData item in list)
			{
				ACSupervisoryData data = this.Processing(item);
				if(data != null)
				{
					retList.Add(data);
				}
			}

			return retList;
		}

		public virtual Result Save(ACSupervisoryData entity)
		{
			return base.Save(entity);
		}

		public virtual void SaveUnderTransaction(ACSupervisoryData entity)
		{
			base.SaveUnderTransaction(entity);
		}

		public virtual Result Save(ACSupervisoryDataCollection list)
		{
			return base.Save(list);
		}

		public virtual void SaveUnderTransaction(ACSupervisoryDataCollection list)
		{
			base.SaveUnderTransaction(list);
		}


	}
	public abstract class UsrGroupDataServiceBase : ServiceBase
	{
		protected UsrGroupCRUD _dal;

		public UsrGroupDataServiceBase(string connectionString, SecurityToken token) : base(connectionString, token)
		{
			this._dal = new UsrGroupCRUD(connectionString);
			for (int i = 0; i < token.GetSortFields().Count; i++)
			{
				SortField field = token.GetSortFields()[i];
				this._dal.AddSortBy(field.FieldAlias, field.ASC);
			}
		}

		protected override string TableName
		{
			get
			{
				return "UsrGroup";
			}
		}

		protected abstract UsrGroupDBRuleDataServiceBase GetUsrGroupDBRuleDataServiceBase(SecurityToken token);
		protected abstract UsrGroupBRRuleDataServiceBase GetUsrGroupBRRuleDataServiceBase(SecurityToken token);
		protected abstract UsrAccountDataServiceBase GetUsrAccountDataServiceBase(SecurityToken token);

		protected override int DeleteEntity(BusinessBase entity)
		{
			UsrGroupData data = (UsrGroupData) entity;
			if(data == null)
				return 0;

			this.GetUsrGroupDBRuleDataServiceBase(base.SecurityToken).DeleteByUsrGroup(data);
			this.GetUsrGroupBRRuleDataServiceBase(base.SecurityToken).DeleteByUsrGroup(data);
			this.GetUsrAccountDataServiceBase(base.SecurityToken).DeleteByUsrGroup(data);
			return this._dal.DeleteByPK( data.UsrGroupPK, data.RowVersion);
		}

		public virtual Result Purge(UsrGroupData entity)
		{
			return base.Purge(entity);
		}

		protected override int PurgeEntity(BusinessBase entity)
		{
			UsrGroupData data = (UsrGroupData) entity;
			if(data == null)
				return 0;

			this.GetUsrGroupDBRuleDataServiceBase(base.SecurityToken).PurgeByUsrGroup(data);
			this.GetUsrGroupBRRuleDataServiceBase(base.SecurityToken).PurgeByUsrGroup(data);
			this.GetUsrAccountDataServiceBase(base.SecurityToken).PurgeByUsrGroup(data);
			return this._dal.DeleteByPK( data.UsrGroupPK, data.RowVersion);
		}

		protected override int InsertEntity(BusinessBase entity)
		{
			UsrGroupData data = (UsrGroupData) entity;
			if(data == null)
				return 0;

			return this._dal.Insert(data);
		}

		protected override int UpdateEntity(BusinessBase entity)
		{
			UsrGroupData data = (UsrGroupData) entity;
			if(data == null)
				return 0;

			return this._dal.Update(data);
		}

		protected override void UpdateChildren(BusinessBase entity)
		{
			UsrGroupData data = (UsrGroupData) entity;
			if(data == null)
				return;

			if (data.UsrGroupDBRuleList != null)
			{
				 this.GetUsrGroupDBRuleDataServiceBase(base.SecurityToken).SaveUnderTransaction(data.UsrGroupDBRuleList);
			}
			if (data.UsrGroupBRRuleList != null)
			{
				 this.GetUsrGroupBRRuleDataServiceBase(base.SecurityToken).SaveUnderTransaction(data.UsrGroupBRRuleList);
			}
			if (data.UsrAccountList != null)
			{
				 this.GetUsrAccountDataServiceBase(base.SecurityToken).SaveUnderTransaction(data.UsrAccountList);
			}
		}

		internal Result GetRowVersion(UsrGroupDataCollection list)
		{
			return base.GetRowVersion(list);
		}

		protected override Result GetRowVersion(BusinessBase entity)
		{
			UsrGroupData data = (UsrGroupData) entity;
			if(data == null || !data.IsDirty)
				return new Result(true);

			Result result = new Result(true);
			if (entity.IsDeleted)
			{
				result.Add(data.ObjectID, new byte[0]);
				return result;
			}

			if (entity.IsSelfDirty)
			{
				result.Add(data.ObjectID, this._dal.GetRowVersion( data.UsrGroupPK));
			}
			if (data.UsrGroupDBRuleList != null && data.UsrGroupDBRuleList.Count > 0)
			{
				result.Add(this.GetUsrGroupDBRuleDataServiceBase(base.SecurityToken).GetRowVersion(data.UsrGroupDBRuleList));
			}
			if (data.UsrGroupBRRuleList != null && data.UsrGroupBRRuleList.Count > 0)
			{
				result.Add(this.GetUsrGroupBRRuleDataServiceBase(base.SecurityToken).GetRowVersion(data.UsrGroupBRRuleList));
			}
			if (data.UsrAccountList != null && data.UsrAccountList.Count > 0)
			{
				result.Add(this.GetUsrAccountDataServiceBase(base.SecurityToken).GetRowVersion(data.UsrAccountList));
			}
			return result;
		}

		public virtual UsrGroupData GetByPK( System.Guid UsrGroupPK)
		{
			if (base.IsTrusted)
			{
				return this.Processing(this._dal.GetByPK( UsrGroupPK));
			}

			if (!base.IsAuthorizedSelect)
			{
				return null;
			}

			return this.Processing((UsrGroupData) base.Filter(this._dal.GetByPK( UsrGroupPK)));
		}

		protected virtual UsrGroupData GetEntity(string sqlWhere, SqlParameter[] paras)
		{
			if (base.IsTrusted)
			{
				return this.Processing(this._dal.GetEntityBy(sqlWhere, paras));
			}

			if (!base.IsAuthorizedSelect)
			{
				return null;
			}

			return this.Processing((UsrGroupData) base.Filter(this._dal.GetEntityBy(sqlWhere, paras)));
		}

		public virtual UsrGroupDataCollection GetAll()
		{
			if (base.IsTrusted)
			{
				return this.Processing(this._dal.GetAll());
			}

			if (!base.IsAuthorizedSelect)
			{
				return new UsrGroupDataCollection();
			}

			return this.Processing((UsrGroupDataCollection) base.Filter(this._dal.GetAll()));
		}

		public UsrGroupViewCollection GetViewAll()
		{
			return new UsrGroupViewCollection(this.GetAll());
		}

		protected virtual UsrGroupDataCollection GetCollection(string sqlWhere, SqlParameter[] paras)
		{
			if (base.IsTrusted)
			{
				return this.Processing(this._dal.GetCollectionBy(sqlWhere, paras));
			}

			if (!base.IsAuthorizedSelect)
			{
				return new UsrGroupDataCollection();
			}

			 return this.Processing((UsrGroupDataCollection) base.Filter(this._dal.GetCollectionBy(sqlWhere, paras)));
		}

		protected virtual UsrGroupData Processing(UsrGroupData entity)
		{
			return entity;
		}

		protected virtual UsrGroupDataCollection Processing(UsrGroupDataCollection list)
		{
			UsrGroupDataCollection retList = new UsrGroupDataCollection();
			foreach(UsrGroupData item in list)
			{
				UsrGroupData data = this.Processing(item);
				if(data != null)
				{
					retList.Add(data);
				}
			}

			return retList;
		}

		public virtual Result Save(UsrGroupData entity)
		{
			return base.Save(entity);
		}

		public virtual void SaveUnderTransaction(UsrGroupData entity)
		{
			base.SaveUnderTransaction(entity);
		}

		public virtual Result Save(UsrGroupDataCollection list)
		{
			return base.Save(list);
		}

		public virtual void SaveUnderTransaction(UsrGroupDataCollection list)
		{
			base.SaveUnderTransaction(list);
		}


	}
	public abstract class ACCardHolderBuildingMapDataServiceBase : ServiceBase
	{
		protected ACCardHolderBuildingMapCRUD _dal;

		public ACCardHolderBuildingMapDataServiceBase(string connectionString, SecurityToken token) : base(connectionString, token)
		{
			this._dal = new ACCardHolderBuildingMapCRUD(connectionString);
			for (int i = 0; i < token.GetSortFields().Count; i++)
			{
				SortField field = token.GetSortFields()[i];
				this._dal.AddSortBy(field.FieldAlias, field.ASC);
			}
		}

		protected override string TableName
		{
			get
			{
				return "ACCardHolderBuildingMap";
			}
		}


		protected override int DeleteEntity(BusinessBase entity)
		{
			ACCardHolderBuildingMapData data = (ACCardHolderBuildingMapData) entity;
			if(data == null)
				return 0;

			return this._dal.DeleteByPK( data.ACCardHolderBuildingMapPK, data.RowVersion);
		}

		internal int DeleteByBDBuilding(BusinessBase entity)
		{
			BDBuildingData data = (BDBuildingData) entity;
			if(data == null)
				return 0;

			bool isLogDeleteEnabled = ServiceBase._DBLog.IsLogDeleteEnabled;
			bool isLinkDBDeleteEnabled = ServiceBase._DBLink.IsLinkDBDeleteEnabled;
			if (!isLogDeleteEnabled && !isLinkDBDeleteEnabled)
			{
				return this._dal.DeleteByBDBuilding(data. BDBuildingPK);
			}

			DataTable list = this._dal.GetLogByBDBuilding(data. BDBuildingPK);
			list.TableName = this._dal.TableName;
			int ret = this._dal.DeleteByBDBuilding(data. BDBuildingPK);
			if (isLogDeleteEnabled)
			{
				ServiceBase._DBLog.LogDelete(list, base.SecurityToken);
			}

			if (isLinkDBDeleteEnabled)
			{
				ServiceBase._DBLink.LinkDBDelete(list, base.TrustedToken);
			}

			return ret;
		}

		internal int DeleteByACCardHolder(BusinessBase entity)
		{
			ACCardHolderData data = (ACCardHolderData) entity;
			if(data == null)
				return 0;

			bool isLogDeleteEnabled = ServiceBase._DBLog.IsLogDeleteEnabled;
			bool isLinkDBDeleteEnabled = ServiceBase._DBLink.IsLinkDBDeleteEnabled;
			if (!isLogDeleteEnabled && !isLinkDBDeleteEnabled)
			{
				return this._dal.DeleteByACCardHolder(data. ACCardHolderPK);
			}

			DataTable list = this._dal.GetLogByACCardHolder(data. ACCardHolderPK);
			list.TableName = this._dal.TableName;
			int ret = this._dal.DeleteByACCardHolder(data. ACCardHolderPK);
			if (isLogDeleteEnabled)
			{
				ServiceBase._DBLog.LogDelete(list, base.SecurityToken);
			}

			if (isLinkDBDeleteEnabled)
			{
				ServiceBase._DBLink.LinkDBDelete(list, base.TrustedToken);
			}

			return ret;
		}

		internal int DeleteByBDTenant(BusinessBase entity)
		{
			BDTenantData data = (BDTenantData) entity;
			if(data == null)
				return 0;

			bool isLogDeleteEnabled = ServiceBase._DBLog.IsLogDeleteEnabled;
			bool isLinkDBDeleteEnabled = ServiceBase._DBLink.IsLinkDBDeleteEnabled;
			if (!isLogDeleteEnabled && !isLinkDBDeleteEnabled)
			{
				return this._dal.DeleteByBDTenant(data. BDTenantPK);
			}

			DataTable list = this._dal.GetLogByBDTenant(data. BDTenantPK);
			list.TableName = this._dal.TableName;
			int ret = this._dal.DeleteByBDTenant(data. BDTenantPK);
			if (isLogDeleteEnabled)
			{
				ServiceBase._DBLog.LogDelete(list, base.SecurityToken);
			}

			if (isLinkDBDeleteEnabled)
			{
				ServiceBase._DBLink.LinkDBDelete(list, base.TrustedToken);
			}

			return ret;
		}

		public virtual Result Purge(ACCardHolderBuildingMapData entity)
		{
			return base.Purge(entity);
		}

		protected override int PurgeEntity(BusinessBase entity)
		{
			ACCardHolderBuildingMapData data = (ACCardHolderBuildingMapData) entity;
			if(data == null)
				return 0;

			return this._dal.DeleteByPK( data.ACCardHolderBuildingMapPK, data.RowVersion);
		}

		internal int PurgeByBDBuilding(BusinessBase entity)
		{
			BDBuildingData data = (BDBuildingData) entity;
			if(data == null)
				return 0;

			return this._dal.DeleteByBDBuilding(data. BDBuildingPK);
		}

		internal int PurgeByACCardHolder(BusinessBase entity)
		{
			ACCardHolderData data = (ACCardHolderData) entity;
			if(data == null)
				return 0;

			return this._dal.DeleteByACCardHolder(data. ACCardHolderPK);
		}

		internal int PurgeByBDTenant(BusinessBase entity)
		{
			BDTenantData data = (BDTenantData) entity;
			if(data == null)
				return 0;

			return this._dal.DeleteByBDTenant(data. BDTenantPK);
		}

		protected override int InsertEntity(BusinessBase entity)
		{
			ACCardHolderBuildingMapData data = (ACCardHolderBuildingMapData) entity;
			if(data == null)
				return 0;

			return this._dal.Insert(data);
		}

		protected override int UpdateEntity(BusinessBase entity)
		{
			ACCardHolderBuildingMapData data = (ACCardHolderBuildingMapData) entity;
			if(data == null)
				return 0;

			return this._dal.Update(data);
		}

		protected override void UpdateChildren(BusinessBase entity)
		{
			ACCardHolderBuildingMapData data = (ACCardHolderBuildingMapData) entity;
			if(data == null)
				return;

		}

		internal Result GetRowVersion(ACCardHolderBuildingMapDataCollection list)
		{
			return base.GetRowVersion(list);
		}

		protected override Result GetRowVersion(BusinessBase entity)
		{
			ACCardHolderBuildingMapData data = (ACCardHolderBuildingMapData) entity;
			if(data == null || !data.IsDirty)
				return new Result(true);

			Result result = new Result(true);
			if (entity.IsDeleted)
			{
				result.Add(data.ObjectID, new byte[0]);
				return result;
			}

			if (entity.IsSelfDirty)
			{
				result.Add(data.ObjectID, this._dal.GetRowVersion( data.ACCardHolderBuildingMapPK));
			}
			return result;
		}

		public virtual ACCardHolderBuildingMapData GetByPK( System.Guid ACCardHolderBuildingMapPK)
		{
			if (base.IsTrusted)
			{
				return this.Processing(this._dal.GetByPK( ACCardHolderBuildingMapPK));
			}

			if (!base.IsAuthorizedSelect)
			{
				return null;
			}

			return this.Processing((ACCardHolderBuildingMapData) base.Filter(this._dal.GetByPK( ACCardHolderBuildingMapPK)));
		}

		protected virtual ACCardHolderBuildingMapData GetEntity(string sqlWhere, SqlParameter[] paras)
		{
			if (base.IsTrusted)
			{
				return this.Processing(this._dal.GetEntityBy(sqlWhere, paras));
			}

			if (!base.IsAuthorizedSelect)
			{
				return null;
			}

			return this.Processing((ACCardHolderBuildingMapData) base.Filter(this._dal.GetEntityBy(sqlWhere, paras)));
		}

		public virtual ACCardHolderBuildingMapDataCollection GetAll()
		{
			if (base.IsTrusted)
			{
				return this.Processing(this._dal.GetAll());
			}

			if (!base.IsAuthorizedSelect)
			{
				return new ACCardHolderBuildingMapDataCollection();
			}

			return this.Processing((ACCardHolderBuildingMapDataCollection) base.Filter(this._dal.GetAll()));
		}

		public ACCardHolderBuildingMapViewCollection GetViewAll()
		{
			return new ACCardHolderBuildingMapViewCollection(this.GetAll());
		}

		protected virtual ACCardHolderBuildingMapDataCollection GetCollection(string sqlWhere, SqlParameter[] paras)
		{
			if (base.IsTrusted)
			{
				return this.Processing(this._dal.GetCollectionBy(sqlWhere, paras));
			}

			if (!base.IsAuthorizedSelect)
			{
				return new ACCardHolderBuildingMapDataCollection();
			}

			 return this.Processing((ACCardHolderBuildingMapDataCollection) base.Filter(this._dal.GetCollectionBy(sqlWhere, paras)));
		}

		public virtual ACCardHolderBuildingMapDataCollection GetByBDBuilding(System.Guid BDBuildingPK)
		{
			if (base.IsTrusted)
			{
				return this.Processing(this._dal.GetByBDBuilding(BDBuildingPK));
			}

			if (!base.IsAuthorizedSelect)
			{
				return null;
			}

			return this.Processing((ACCardHolderBuildingMapDataCollection) base.Filter(this._dal.GetByBDBuilding(BDBuildingPK)));
		}

		public ACCardHolderBuildingMapViewCollection GetViewByBDBuilding(System.Guid BDBuildingPK)
		{
			return new ACCardHolderBuildingMapViewCollection(this.GetByBDBuilding(BDBuildingPK));
		}

		public virtual ACCardHolderBuildingMapDataCollection GetByACCardHolder(System.Guid ACCardHolderPK)
		{
			if (base.IsTrusted)
			{
				return this.Processing(this._dal.GetByACCardHolder(ACCardHolderPK));
			}

			if (!base.IsAuthorizedSelect)
			{
				return null;
			}

			return this.Processing((ACCardHolderBuildingMapDataCollection) base.Filter(this._dal.GetByACCardHolder(ACCardHolderPK)));
		}

		public ACCardHolderBuildingMapViewCollection GetViewByACCardHolder(System.Guid ACCardHolderPK)
		{
			return new ACCardHolderBuildingMapViewCollection(this.GetByACCardHolder(ACCardHolderPK));
		}

		protected virtual ACCardHolderBuildingMapData Processing(ACCardHolderBuildingMapData entity)
		{
			return entity;
		}

		protected virtual ACCardHolderBuildingMapDataCollection Processing(ACCardHolderBuildingMapDataCollection list)
		{
			ACCardHolderBuildingMapDataCollection retList = new ACCardHolderBuildingMapDataCollection();
			foreach(ACCardHolderBuildingMapData item in list)
			{
				ACCardHolderBuildingMapData data = this.Processing(item);
				if(data != null)
				{
					retList.Add(data);
				}
			}

			return retList;
		}

		public virtual Result Save(ACCardHolderBuildingMapData entity)
		{
			return base.Save(entity);
		}

		public virtual void SaveUnderTransaction(ACCardHolderBuildingMapData entity)
		{
			base.SaveUnderTransaction(entity);
		}

		public virtual Result Save(ACCardHolderBuildingMapDataCollection list)
		{
			return base.Save(list);
		}

		public virtual void SaveUnderTransaction(ACCardHolderBuildingMapDataCollection list)
		{
			base.SaveUnderTransaction(list);
		}


	}
	public abstract class BDVisitorDataServiceBase : ServiceBase
	{
		protected BDVisitorCRUD _dal;

		public BDVisitorDataServiceBase(string connectionString, SecurityToken token) : base(connectionString, token)
		{
			this._dal = new BDVisitorCRUD(connectionString);
			for (int i = 0; i < token.GetSortFields().Count; i++)
			{
				SortField field = token.GetSortFields()[i];
				this._dal.AddSortBy(field.FieldAlias, field.ASC);
			}
		}

		protected override string TableName
		{
			get
			{
				return "BDVisitor";
			}
		}


		protected override int DeleteEntity(BusinessBase entity)
		{
			BDVisitorData data = (BDVisitorData) entity;
			if(data == null)
				return 0;

			return this._dal.DeleteByPK( data.BDVisitorPK, data.RowVersion);
		}

		internal int DeleteByBDTenant(BusinessBase entity)
		{
			BDTenantData data = (BDTenantData) entity;
			if(data == null)
				return 0;

			bool isLogDeleteEnabled = ServiceBase._DBLog.IsLogDeleteEnabled;
			bool isLinkDBDeleteEnabled = ServiceBase._DBLink.IsLinkDBDeleteEnabled;
			if (!isLogDeleteEnabled && !isLinkDBDeleteEnabled)
			{
				return this._dal.DeleteByBDTenant(data. BDTenantPK);
			}

			DataTable list = this._dal.GetLogByBDTenant(data. BDTenantPK);
			list.TableName = this._dal.TableName;
			int ret = this._dal.DeleteByBDTenant(data. BDTenantPK);
			if (isLogDeleteEnabled)
			{
				ServiceBase._DBLog.LogDelete(list, base.SecurityToken);
			}

			if (isLinkDBDeleteEnabled)
			{
				ServiceBase._DBLink.LinkDBDelete(list, base.TrustedToken);
			}

			return ret;
		}

		internal int DeleteByBDBuilding(BusinessBase entity)
		{
			BDBuildingData data = (BDBuildingData) entity;
			if(data == null)
				return 0;

			bool isLogDeleteEnabled = ServiceBase._DBLog.IsLogDeleteEnabled;
			bool isLinkDBDeleteEnabled = ServiceBase._DBLink.IsLinkDBDeleteEnabled;
			if (!isLogDeleteEnabled && !isLinkDBDeleteEnabled)
			{
				return this._dal.DeleteByBDBuilding(data. BDBuildingPK);
			}

			DataTable list = this._dal.GetLogByBDBuilding(data. BDBuildingPK);
			list.TableName = this._dal.TableName;
			int ret = this._dal.DeleteByBDBuilding(data. BDBuildingPK);
			if (isLogDeleteEnabled)
			{
				ServiceBase._DBLog.LogDelete(list, base.SecurityToken);
			}

			if (isLinkDBDeleteEnabled)
			{
				ServiceBase._DBLink.LinkDBDelete(list, base.TrustedToken);
			}

			return ret;
		}

		public virtual Result Purge(BDVisitorData entity)
		{
			return base.Purge(entity);
		}

		protected override int PurgeEntity(BusinessBase entity)
		{
			BDVisitorData data = (BDVisitorData) entity;
			if(data == null)
				return 0;

			return this._dal.DeleteByPK( data.BDVisitorPK, data.RowVersion);
		}

		internal int PurgeByBDTenant(BusinessBase entity)
		{
			BDTenantData data = (BDTenantData) entity;
			if(data == null)
				return 0;

			return this._dal.DeleteByBDTenant(data. BDTenantPK);
		}

		internal int PurgeByBDBuilding(BusinessBase entity)
		{
			BDBuildingData data = (BDBuildingData) entity;
			if(data == null)
				return 0;

			return this._dal.DeleteByBDBuilding(data. BDBuildingPK);
		}

		protected override int InsertEntity(BusinessBase entity)
		{
			BDVisitorData data = (BDVisitorData) entity;
			if(data == null)
				return 0;

			return this._dal.Insert(data);
		}

		protected override int UpdateEntity(BusinessBase entity)
		{
			BDVisitorData data = (BDVisitorData) entity;
			if(data == null)
				return 0;

			return this._dal.Update(data);
		}

		protected override void UpdateChildren(BusinessBase entity)
		{
			BDVisitorData data = (BDVisitorData) entity;
			if(data == null)
				return;

		}

		internal Result GetRowVersion(BDVisitorDataCollection list)
		{
			return base.GetRowVersion(list);
		}

		protected override Result GetRowVersion(BusinessBase entity)
		{
			BDVisitorData data = (BDVisitorData) entity;
			if(data == null || !data.IsDirty)
				return new Result(true);

			Result result = new Result(true);
			if (entity.IsDeleted)
			{
				result.Add(data.ObjectID, new byte[0]);
				return result;
			}

			if (entity.IsSelfDirty)
			{
				result.Add(data.ObjectID, this._dal.GetRowVersion( data.BDVisitorPK));
			}
			return result;
		}

		public virtual BDVisitorData GetByPK( System.Guid BDVisitorPK)
		{
			if (base.IsTrusted)
			{
				return this.Processing(this._dal.GetByPK( BDVisitorPK));
			}

			if (!base.IsAuthorizedSelect)
			{
				return null;
			}

			return this.Processing((BDVisitorData) base.Filter(this._dal.GetByPK( BDVisitorPK)));
		}

		protected virtual BDVisitorData GetEntity(string sqlWhere, SqlParameter[] paras)
		{
			if (base.IsTrusted)
			{
				return this.Processing(this._dal.GetEntityBy(sqlWhere, paras));
			}

			if (!base.IsAuthorizedSelect)
			{
				return null;
			}

			return this.Processing((BDVisitorData) base.Filter(this._dal.GetEntityBy(sqlWhere, paras)));
		}

		public virtual BDVisitorDataCollection GetAll()
		{
			if (base.IsTrusted)
			{
				return this.Processing(this._dal.GetAll());
			}

			if (!base.IsAuthorizedSelect)
			{
				return new BDVisitorDataCollection();
			}

			return this.Processing((BDVisitorDataCollection) base.Filter(this._dal.GetAll()));
		}

		public BDVisitorViewCollection GetViewAll()
		{
			return new BDVisitorViewCollection(this.GetAll());
		}

		protected virtual BDVisitorDataCollection GetCollection(string sqlWhere, SqlParameter[] paras)
		{
			if (base.IsTrusted)
			{
				return this.Processing(this._dal.GetCollectionBy(sqlWhere, paras));
			}

			if (!base.IsAuthorizedSelect)
			{
				return new BDVisitorDataCollection();
			}

			 return this.Processing((BDVisitorDataCollection) base.Filter(this._dal.GetCollectionBy(sqlWhere, paras)));
		}

		public virtual BDVisitorDataCollection GetByBDTenant(System.Guid BDTenantPK)
		{
			if (base.IsTrusted)
			{
				return this.Processing(this._dal.GetByBDTenant(BDTenantPK));
			}

			if (!base.IsAuthorizedSelect)
			{
				return null;
			}

			return this.Processing((BDVisitorDataCollection) base.Filter(this._dal.GetByBDTenant(BDTenantPK)));
		}

		public BDVisitorViewCollection GetViewByBDTenant(System.Guid BDTenantPK)
		{
			return new BDVisitorViewCollection(this.GetByBDTenant(BDTenantPK));
		}

		protected virtual BDVisitorData Processing(BDVisitorData entity)
		{
			return entity;
		}

		protected virtual BDVisitorDataCollection Processing(BDVisitorDataCollection list)
		{
			BDVisitorDataCollection retList = new BDVisitorDataCollection();
			foreach(BDVisitorData item in list)
			{
				BDVisitorData data = this.Processing(item);
				if(data != null)
				{
					retList.Add(data);
				}
			}

			return retList;
		}

		public virtual Result Save(BDVisitorData entity)
		{
			return base.Save(entity);
		}

		public virtual void SaveUnderTransaction(BDVisitorData entity)
		{
			base.SaveUnderTransaction(entity);
		}

		public virtual Result Save(BDVisitorDataCollection list)
		{
			return base.Save(list);
		}

		public virtual void SaveUnderTransaction(BDVisitorDataCollection list)
		{
			base.SaveUnderTransaction(list);
		}


	}
	public abstract class UsrGroupDBRuleDataServiceBase : ServiceBase
	{
		protected UsrGroupDBRuleCRUD _dal;

		public UsrGroupDBRuleDataServiceBase(string connectionString, SecurityToken token) : base(connectionString, token)
		{
			this._dal = new UsrGroupDBRuleCRUD(connectionString);
			for (int i = 0; i < token.GetSortFields().Count; i++)
			{
				SortField field = token.GetSortFields()[i];
				this._dal.AddSortBy(field.FieldAlias, field.ASC);
			}
		}

		protected override string TableName
		{
			get
			{
				return "UsrGroupDBRule";
			}
		}


		protected override int DeleteEntity(BusinessBase entity)
		{
			UsrGroupDBRuleData data = (UsrGroupDBRuleData) entity;
			if(data == null)
				return 0;

			return this._dal.DeleteByPK( data.UsrGroupDBRulePK, data.RowVersion);
		}

		internal int DeleteByUsrGroup(BusinessBase entity)
		{
			UsrGroupData data = (UsrGroupData) entity;
			if(data == null)
				return 0;

			bool isLogDeleteEnabled = ServiceBase._DBLog.IsLogDeleteEnabled;
			bool isLinkDBDeleteEnabled = ServiceBase._DBLink.IsLinkDBDeleteEnabled;
			if (!isLogDeleteEnabled && !isLinkDBDeleteEnabled)
			{
				return this._dal.DeleteByUsrGroup(data. UsrGroupPK);
			}

			DataTable list = this._dal.GetLogByUsrGroup(data. UsrGroupPK);
			list.TableName = this._dal.TableName;
			int ret = this._dal.DeleteByUsrGroup(data. UsrGroupPK);
			if (isLogDeleteEnabled)
			{
				ServiceBase._DBLog.LogDelete(list, base.SecurityToken);
			}

			if (isLinkDBDeleteEnabled)
			{
				ServiceBase._DBLink.LinkDBDelete(list, base.TrustedToken);
			}

			return ret;
		}

		public virtual Result Purge(UsrGroupDBRuleData entity)
		{
			return base.Purge(entity);
		}

		protected override int PurgeEntity(BusinessBase entity)
		{
			UsrGroupDBRuleData data = (UsrGroupDBRuleData) entity;
			if(data == null)
				return 0;

			return this._dal.DeleteByPK( data.UsrGroupDBRulePK, data.RowVersion);
		}

		internal int PurgeByUsrGroup(BusinessBase entity)
		{
			UsrGroupData data = (UsrGroupData) entity;
			if(data == null)
				return 0;

			return this._dal.DeleteByUsrGroup(data. UsrGroupPK);
		}

		protected override int InsertEntity(BusinessBase entity)
		{
			UsrGroupDBRuleData data = (UsrGroupDBRuleData) entity;
			if(data == null)
				return 0;

			return this._dal.Insert(data);
		}

		protected override int UpdateEntity(BusinessBase entity)
		{
			UsrGroupDBRuleData data = (UsrGroupDBRuleData) entity;
			if(data == null)
				return 0;

			return this._dal.Update(data);
		}

		protected override void UpdateChildren(BusinessBase entity)
		{
			UsrGroupDBRuleData data = (UsrGroupDBRuleData) entity;
			if(data == null)
				return;

		}

		internal Result GetRowVersion(UsrGroupDBRuleDataCollection list)
		{
			return base.GetRowVersion(list);
		}

		protected override Result GetRowVersion(BusinessBase entity)
		{
			UsrGroupDBRuleData data = (UsrGroupDBRuleData) entity;
			if(data == null || !data.IsDirty)
				return new Result(true);

			Result result = new Result(true);
			if (entity.IsDeleted)
			{
				result.Add(data.ObjectID, new byte[0]);
				return result;
			}

			if (entity.IsSelfDirty)
			{
				result.Add(data.ObjectID, this._dal.GetRowVersion( data.UsrGroupDBRulePK));
			}
			return result;
		}

		public virtual UsrGroupDBRuleData GetByPK( System.Guid UsrGroupDBRulePK)
		{
			if (base.IsTrusted)
			{
				return this.Processing(this._dal.GetByPK( UsrGroupDBRulePK));
			}

			if (!base.IsAuthorizedSelect)
			{
				return null;
			}

			return this.Processing((UsrGroupDBRuleData) base.Filter(this._dal.GetByPK( UsrGroupDBRulePK)));
		}

		protected virtual UsrGroupDBRuleData GetEntity(string sqlWhere, SqlParameter[] paras)
		{
			if (base.IsTrusted)
			{
				return this.Processing(this._dal.GetEntityBy(sqlWhere, paras));
			}

			if (!base.IsAuthorizedSelect)
			{
				return null;
			}

			return this.Processing((UsrGroupDBRuleData) base.Filter(this._dal.GetEntityBy(sqlWhere, paras)));
		}

		public virtual UsrGroupDBRuleDataCollection GetAll()
		{
			if (base.IsTrusted)
			{
				return this.Processing(this._dal.GetAll());
			}

			if (!base.IsAuthorizedSelect)
			{
				return new UsrGroupDBRuleDataCollection();
			}

			return this.Processing((UsrGroupDBRuleDataCollection) base.Filter(this._dal.GetAll()));
		}

		public UsrGroupDBRuleViewCollection GetViewAll()
		{
			return new UsrGroupDBRuleViewCollection(this.GetAll());
		}

		protected virtual UsrGroupDBRuleDataCollection GetCollection(string sqlWhere, SqlParameter[] paras)
		{
			if (base.IsTrusted)
			{
				return this.Processing(this._dal.GetCollectionBy(sqlWhere, paras));
			}

			if (!base.IsAuthorizedSelect)
			{
				return new UsrGroupDBRuleDataCollection();
			}

			 return this.Processing((UsrGroupDBRuleDataCollection) base.Filter(this._dal.GetCollectionBy(sqlWhere, paras)));
		}

		public virtual UsrGroupDBRuleDataCollection GetByUsrGroup(System.Guid UsrGroupPK)
		{
			if (base.IsTrusted)
			{
				return this.Processing(this._dal.GetByUsrGroup(UsrGroupPK));
			}

			if (!base.IsAuthorizedSelect)
			{
				return null;
			}

			return this.Processing((UsrGroupDBRuleDataCollection) base.Filter(this._dal.GetByUsrGroup(UsrGroupPK)));
		}

		public UsrGroupDBRuleViewCollection GetViewByUsrGroup(System.Guid UsrGroupPK)
		{
			return new UsrGroupDBRuleViewCollection(this.GetByUsrGroup(UsrGroupPK));
		}

		protected virtual UsrGroupDBRuleData Processing(UsrGroupDBRuleData entity)
		{
			return entity;
		}

		protected virtual UsrGroupDBRuleDataCollection Processing(UsrGroupDBRuleDataCollection list)
		{
			UsrGroupDBRuleDataCollection retList = new UsrGroupDBRuleDataCollection();
			foreach(UsrGroupDBRuleData item in list)
			{
				UsrGroupDBRuleData data = this.Processing(item);
				if(data != null)
				{
					retList.Add(data);
				}
			}

			return retList;
		}

		public virtual Result Save(UsrGroupDBRuleData entity)
		{
			return base.Save(entity);
		}

		public virtual void SaveUnderTransaction(UsrGroupDBRuleData entity)
		{
			base.SaveUnderTransaction(entity);
		}

		public virtual Result Save(UsrGroupDBRuleDataCollection list)
		{
			return base.Save(list);
		}

		public virtual void SaveUnderTransaction(UsrGroupDBRuleDataCollection list)
		{
			base.SaveUnderTransaction(list);
		}


	}
	public abstract class ACPanelDataServiceBase : ServiceBase
	{
		protected ACPanelCRUD _dal;

		public ACPanelDataServiceBase(string connectionString, SecurityToken token) : base(connectionString, token)
		{
			this._dal = new ACPanelCRUD(connectionString);
			for (int i = 0; i < token.GetSortFields().Count; i++)
			{
				SortField field = token.GetSortFields()[i];
				this._dal.AddSortBy(field.FieldAlias, field.ASC);
			}
		}

		protected override string TableName
		{
			get
			{
				return "ACPanel";
			}
		}

		protected abstract ACInputDataServiceBase GetACInputDataServiceBase(SecurityToken token);
		protected abstract ACSupervisoryDataServiceBase GetACSupervisoryDataServiceBase(SecurityToken token);
		protected abstract ACPanelHolidayMapDataServiceBase GetACPanelHolidayMapDataServiceBase(SecurityToken token);
		protected abstract ACMainZoneDataServiceBase GetACMainZoneDataServiceBase(SecurityToken token);
		protected abstract ACPanelFunctionCardMapDataServiceBase GetACPanelFunctionCardMapDataServiceBase(SecurityToken token);
		protected abstract ACOutputGroupDataServiceBase GetACOutputGroupDataServiceBase(SecurityToken token);
		protected abstract ACInputGroupDataServiceBase GetACInputGroupDataServiceBase(SecurityToken token);

		protected override int DeleteEntity(BusinessBase entity)
		{
			ACPanelData data = (ACPanelData) entity;
			if(data == null)
				return 0;

			this.GetACInputDataServiceBase(base.SecurityToken).DeleteByACPanel(data);
			this.GetACSupervisoryDataServiceBase(base.SecurityToken).DeleteByACPanel(data);
			this.GetACPanelHolidayMapDataServiceBase(base.SecurityToken).DeleteByACPanel(data);
			this.GetACMainZoneDataServiceBase(base.SecurityToken).DeleteByACPanel(data);
			this.GetACPanelFunctionCardMapDataServiceBase(base.SecurityToken).DeleteByACPanel(data);
			this.GetACOutputGroupDataServiceBase(base.SecurityToken).DeleteByACPanel(data);
			this.GetACInputGroupDataServiceBase(base.SecurityToken).DeleteByACPanel(data);
			return this._dal.DeleteByPK( data.ACPanelPK, data.RowVersion);
		}

		internal int DeleteByBDBuilding(BusinessBase entity)
		{
			BDBuildingData data = (BDBuildingData) entity;
			if(data == null)
				return 0;

			this.GetACInputDataServiceBase(base.SecurityToken).DeleteByBDBuilding(entity);
			this.GetACSupervisoryDataServiceBase(base.SecurityToken).DeleteByBDBuilding(entity);
			this.GetACPanelHolidayMapDataServiceBase(base.SecurityToken).DeleteByBDBuilding(entity);
			this.GetACMainZoneDataServiceBase(base.SecurityToken).DeleteByBDBuilding(entity);
			this.GetACPanelFunctionCardMapDataServiceBase(base.SecurityToken).DeleteByBDBuilding(entity);
			this.GetACOutputGroupDataServiceBase(base.SecurityToken).DeleteByBDBuilding(entity);
			this.GetACInputGroupDataServiceBase(base.SecurityToken).DeleteByBDBuilding(entity);
			bool isLogDeleteEnabled = ServiceBase._DBLog.IsLogDeleteEnabled;
			bool isLinkDBDeleteEnabled = ServiceBase._DBLink.IsLinkDBDeleteEnabled;
			if (!isLogDeleteEnabled && !isLinkDBDeleteEnabled)
			{
				return this._dal.DeleteByBDBuilding(data. BDBuildingPK);
			}

			DataTable list = this._dal.GetLogByBDBuilding(data. BDBuildingPK);
			list.TableName = this._dal.TableName;
			int ret = this._dal.DeleteByBDBuilding(data. BDBuildingPK);
			if (isLogDeleteEnabled)
			{
				ServiceBase._DBLog.LogDelete(list, base.SecurityToken);
			}

			if (isLinkDBDeleteEnabled)
			{
				ServiceBase._DBLink.LinkDBDelete(list, base.TrustedToken);
			}

			return ret;
		}

		public virtual Result Purge(ACPanelData entity)
		{
			return base.Purge(entity);
		}

		protected override int PurgeEntity(BusinessBase entity)
		{
			ACPanelData data = (ACPanelData) entity;
			if(data == null)
				return 0;

			this.GetACInputDataServiceBase(base.SecurityToken).PurgeByACPanel(data);
			this.GetACSupervisoryDataServiceBase(base.SecurityToken).PurgeByACPanel(data);
			this.GetACPanelHolidayMapDataServiceBase(base.SecurityToken).PurgeByACPanel(data);
			this.GetACMainZoneDataServiceBase(base.SecurityToken).PurgeByACPanel(data);
			this.GetACPanelFunctionCardMapDataServiceBase(base.SecurityToken).PurgeByACPanel(data);
			this.GetACOutputGroupDataServiceBase(base.SecurityToken).PurgeByACPanel(data);
			this.GetACInputGroupDataServiceBase(base.SecurityToken).PurgeByACPanel(data);
			return this._dal.DeleteByPK( data.ACPanelPK, data.RowVersion);
		}

		internal int PurgeByBDBuilding(BusinessBase entity)
		{
			BDBuildingData data = (BDBuildingData) entity;
			if(data == null)
				return 0;

			this.GetACInputDataServiceBase(base.SecurityToken).PurgeByBDBuilding(entity);
			this.GetACSupervisoryDataServiceBase(base.SecurityToken).PurgeByBDBuilding(entity);
			this.GetACPanelHolidayMapDataServiceBase(base.SecurityToken).PurgeByBDBuilding(entity);
			this.GetACMainZoneDataServiceBase(base.SecurityToken).PurgeByBDBuilding(entity);
			this.GetACPanelFunctionCardMapDataServiceBase(base.SecurityToken).PurgeByBDBuilding(entity);
			this.GetACOutputGroupDataServiceBase(base.SecurityToken).PurgeByBDBuilding(entity);
			this.GetACInputGroupDataServiceBase(base.SecurityToken).PurgeByBDBuilding(entity);
			return this._dal.DeleteByBDBuilding(data. BDBuildingPK);
		}

		protected override int InsertEntity(BusinessBase entity)
		{
			ACPanelData data = (ACPanelData) entity;
			if(data == null)
				return 0;

			return this._dal.Insert(data);
		}

		protected override int UpdateEntity(BusinessBase entity)
		{
			ACPanelData data = (ACPanelData) entity;
			if(data == null)
				return 0;

			return this._dal.Update(data);
		}

		protected override void UpdateChildren(BusinessBase entity)
		{
			ACPanelData data = (ACPanelData) entity;
			if(data == null)
				return;

			if (data.ACInputList != null)
			{
				 this.GetACInputDataServiceBase(base.SecurityToken).SaveUnderTransaction(data.ACInputList);
			}
			if (data.ACSupervisoryList != null)
			{
				 this.GetACSupervisoryDataServiceBase(base.SecurityToken).SaveUnderTransaction(data.ACSupervisoryList);
			}
			if (data.ACPanelHolidayMapList != null)
			{
				 this.GetACPanelHolidayMapDataServiceBase(base.SecurityToken).SaveUnderTransaction(data.ACPanelHolidayMapList);
			}
			if (data.ACMainZoneList != null)
			{
				 this.GetACMainZoneDataServiceBase(base.SecurityToken).SaveUnderTransaction(data.ACMainZoneList);
			}
			if (data.ACPanelFunctionCardMapList != null)
			{
				 this.GetACPanelFunctionCardMapDataServiceBase(base.SecurityToken).SaveUnderTransaction(data.ACPanelFunctionCardMapList);
			}
			if (data.ACOutputGroupList != null)
			{
				 this.GetACOutputGroupDataServiceBase(base.SecurityToken).SaveUnderTransaction(data.ACOutputGroupList);
			}
			if (data.ACInputGroupList != null)
			{
				 this.GetACInputGroupDataServiceBase(base.SecurityToken).SaveUnderTransaction(data.ACInputGroupList);
			}
		}

		internal Result GetRowVersion(ACPanelDataCollection list)
		{
			return base.GetRowVersion(list);
		}

		protected override Result GetRowVersion(BusinessBase entity)
		{
			ACPanelData data = (ACPanelData) entity;
			if(data == null || !data.IsDirty)
				return new Result(true);

			Result result = new Result(true);
			if (entity.IsDeleted)
			{
				result.Add(data.ObjectID, new byte[0]);
				return result;
			}

			if (entity.IsSelfDirty)
			{
				result.Add(data.ObjectID, this._dal.GetRowVersion( data.ACPanelPK));
			}
			if (data.ACInputList != null && data.ACInputList.Count > 0)
			{
				result.Add(this.GetACInputDataServiceBase(base.SecurityToken).GetRowVersion(data.ACInputList));
			}
			if (data.ACSupervisoryList != null && data.ACSupervisoryList.Count > 0)
			{
				result.Add(this.GetACSupervisoryDataServiceBase(base.SecurityToken).GetRowVersion(data.ACSupervisoryList));
			}
			if (data.ACPanelHolidayMapList != null && data.ACPanelHolidayMapList.Count > 0)
			{
				result.Add(this.GetACPanelHolidayMapDataServiceBase(base.SecurityToken).GetRowVersion(data.ACPanelHolidayMapList));
			}
			if (data.ACMainZoneList != null && data.ACMainZoneList.Count > 0)
			{
				result.Add(this.GetACMainZoneDataServiceBase(base.SecurityToken).GetRowVersion(data.ACMainZoneList));
			}
			if (data.ACPanelFunctionCardMapList != null && data.ACPanelFunctionCardMapList.Count > 0)
			{
				result.Add(this.GetACPanelFunctionCardMapDataServiceBase(base.SecurityToken).GetRowVersion(data.ACPanelFunctionCardMapList));
			}
			if (data.ACOutputGroupList != null && data.ACOutputGroupList.Count > 0)
			{
				result.Add(this.GetACOutputGroupDataServiceBase(base.SecurityToken).GetRowVersion(data.ACOutputGroupList));
			}
			if (data.ACInputGroupList != null && data.ACInputGroupList.Count > 0)
			{
				result.Add(this.GetACInputGroupDataServiceBase(base.SecurityToken).GetRowVersion(data.ACInputGroupList));
			}
			return result;
		}

		public virtual ACPanelData GetByPK( System.Guid ACPanelPK)
		{
			if (base.IsTrusted)
			{
				return this.Processing(this._dal.GetByPK( ACPanelPK));
			}

			if (!base.IsAuthorizedSelect)
			{
				return null;
			}

			return this.Processing((ACPanelData) base.Filter(this._dal.GetByPK( ACPanelPK)));
		}

		protected virtual ACPanelData GetEntity(string sqlWhere, SqlParameter[] paras)
		{
			if (base.IsTrusted)
			{
				return this.Processing(this._dal.GetEntityBy(sqlWhere, paras));
			}

			if (!base.IsAuthorizedSelect)
			{
				return null;
			}

			return this.Processing((ACPanelData) base.Filter(this._dal.GetEntityBy(sqlWhere, paras)));
		}

		public virtual ACPanelDataCollection GetAll()
		{
			if (base.IsTrusted)
			{
				return this.Processing(this._dal.GetAll());
			}

			if (!base.IsAuthorizedSelect)
			{
				return new ACPanelDataCollection();
			}

			return this.Processing((ACPanelDataCollection) base.Filter(this._dal.GetAll()));
		}

		public ACPanelViewCollection GetViewAll()
		{
			return new ACPanelViewCollection(this.GetAll());
		}

		protected virtual ACPanelDataCollection GetCollection(string sqlWhere, SqlParameter[] paras)
		{
			if (base.IsTrusted)
			{
				return this.Processing(this._dal.GetCollectionBy(sqlWhere, paras));
			}

			if (!base.IsAuthorizedSelect)
			{
				return new ACPanelDataCollection();
			}

			 return this.Processing((ACPanelDataCollection) base.Filter(this._dal.GetCollectionBy(sqlWhere, paras)));
		}

		public virtual ACPanelDataCollection GetByBDBuilding(System.Guid BDBuildingPK)
		{
			if (base.IsTrusted)
			{
				return this.Processing(this._dal.GetByBDBuilding(BDBuildingPK));
			}

			if (!base.IsAuthorizedSelect)
			{
				return null;
			}

			return this.Processing((ACPanelDataCollection) base.Filter(this._dal.GetByBDBuilding(BDBuildingPK)));
		}

		public ACPanelViewCollection GetViewByBDBuilding(System.Guid BDBuildingPK)
		{
			return new ACPanelViewCollection(this.GetByBDBuilding(BDBuildingPK));
		}

		protected virtual ACPanelData Processing(ACPanelData entity)
		{
			return entity;
		}

		protected virtual ACPanelDataCollection Processing(ACPanelDataCollection list)
		{
			ACPanelDataCollection retList = new ACPanelDataCollection();
			foreach(ACPanelData item in list)
			{
				ACPanelData data = this.Processing(item);
				if(data != null)
				{
					retList.Add(data);
				}
			}

			return retList;
		}

		public virtual Result Save(ACPanelData entity)
		{
			return base.Save(entity);
		}

		public virtual void SaveUnderTransaction(ACPanelData entity)
		{
			base.SaveUnderTransaction(entity);
		}

		public virtual Result Save(ACPanelDataCollection list)
		{
			return base.Save(list);
		}

		public virtual void SaveUnderTransaction(ACPanelDataCollection list)
		{
			base.SaveUnderTransaction(list);
		}


	}
	public abstract class UsrAccountDBRuleDataServiceBase : ServiceBase
	{
		protected UsrAccountDBRuleCRUD _dal;

		public UsrAccountDBRuleDataServiceBase(string connectionString, SecurityToken token) : base(connectionString, token)
		{
			this._dal = new UsrAccountDBRuleCRUD(connectionString);
			for (int i = 0; i < token.GetSortFields().Count; i++)
			{
				SortField field = token.GetSortFields()[i];
				this._dal.AddSortBy(field.FieldAlias, field.ASC);
			}
		}

		protected override string TableName
		{
			get
			{
				return "UsrAccountDBRule";
			}
		}


		protected override int DeleteEntity(BusinessBase entity)
		{
			UsrAccountDBRuleData data = (UsrAccountDBRuleData) entity;
			if(data == null)
				return 0;

			return this._dal.DeleteByPK( data.UsrAccountDBRulePK, data.RowVersion);
		}

		internal int DeleteByUsrAccount(BusinessBase entity)
		{
			UsrAccountData data = (UsrAccountData) entity;
			if(data == null)
				return 0;

			bool isLogDeleteEnabled = ServiceBase._DBLog.IsLogDeleteEnabled;
			bool isLinkDBDeleteEnabled = ServiceBase._DBLink.IsLinkDBDeleteEnabled;
			if (!isLogDeleteEnabled && !isLinkDBDeleteEnabled)
			{
				return this._dal.DeleteByUsrAccount(data. UsrAccountPK);
			}

			DataTable list = this._dal.GetLogByUsrAccount(data. UsrAccountPK);
			list.TableName = this._dal.TableName;
			int ret = this._dal.DeleteByUsrAccount(data. UsrAccountPK);
			if (isLogDeleteEnabled)
			{
				ServiceBase._DBLog.LogDelete(list, base.SecurityToken);
			}

			if (isLinkDBDeleteEnabled)
			{
				ServiceBase._DBLink.LinkDBDelete(list, base.TrustedToken);
			}

			return ret;
		}

		internal int DeleteByBDTenant(BusinessBase entity)
		{
			BDTenantData data = (BDTenantData) entity;
			if(data == null)
				return 0;

			bool isLogDeleteEnabled = ServiceBase._DBLog.IsLogDeleteEnabled;
			bool isLinkDBDeleteEnabled = ServiceBase._DBLink.IsLinkDBDeleteEnabled;
			if (!isLogDeleteEnabled && !isLinkDBDeleteEnabled)
			{
				return this._dal.DeleteByBDTenant(data. BDTenantPK);
			}

			DataTable list = this._dal.GetLogByBDTenant(data. BDTenantPK);
			list.TableName = this._dal.TableName;
			int ret = this._dal.DeleteByBDTenant(data. BDTenantPK);
			if (isLogDeleteEnabled)
			{
				ServiceBase._DBLog.LogDelete(list, base.SecurityToken);
			}

			if (isLinkDBDeleteEnabled)
			{
				ServiceBase._DBLink.LinkDBDelete(list, base.TrustedToken);
			}

			return ret;
		}

		internal int DeleteByBDBuilding(BusinessBase entity)
		{
			BDBuildingData data = (BDBuildingData) entity;
			if(data == null)
				return 0;

			bool isLogDeleteEnabled = ServiceBase._DBLog.IsLogDeleteEnabled;
			bool isLinkDBDeleteEnabled = ServiceBase._DBLink.IsLinkDBDeleteEnabled;
			if (!isLogDeleteEnabled && !isLinkDBDeleteEnabled)
			{
				return this._dal.DeleteByBDBuilding(data. BDBuildingPK);
			}

			DataTable list = this._dal.GetLogByBDBuilding(data. BDBuildingPK);
			list.TableName = this._dal.TableName;
			int ret = this._dal.DeleteByBDBuilding(data. BDBuildingPK);
			if (isLogDeleteEnabled)
			{
				ServiceBase._DBLog.LogDelete(list, base.SecurityToken);
			}

			if (isLinkDBDeleteEnabled)
			{
				ServiceBase._DBLink.LinkDBDelete(list, base.TrustedToken);
			}

			return ret;
		}

		internal int DeleteByUsrGroup(BusinessBase entity)
		{
			UsrGroupData data = (UsrGroupData) entity;
			if(data == null)
				return 0;

			bool isLogDeleteEnabled = ServiceBase._DBLog.IsLogDeleteEnabled;
			bool isLinkDBDeleteEnabled = ServiceBase._DBLink.IsLinkDBDeleteEnabled;
			if (!isLogDeleteEnabled && !isLinkDBDeleteEnabled)
			{
				return this._dal.DeleteByUsrGroup(data. UsrGroupPK);
			}

			DataTable list = this._dal.GetLogByUsrGroup(data. UsrGroupPK);
			list.TableName = this._dal.TableName;
			int ret = this._dal.DeleteByUsrGroup(data. UsrGroupPK);
			if (isLogDeleteEnabled)
			{
				ServiceBase._DBLog.LogDelete(list, base.SecurityToken);
			}

			if (isLinkDBDeleteEnabled)
			{
				ServiceBase._DBLink.LinkDBDelete(list, base.TrustedToken);
			}

			return ret;
		}

		public virtual Result Purge(UsrAccountDBRuleData entity)
		{
			return base.Purge(entity);
		}

		protected override int PurgeEntity(BusinessBase entity)
		{
			UsrAccountDBRuleData data = (UsrAccountDBRuleData) entity;
			if(data == null)
				return 0;

			return this._dal.DeleteByPK( data.UsrAccountDBRulePK, data.RowVersion);
		}

		internal int PurgeByUsrAccount(BusinessBase entity)
		{
			UsrAccountData data = (UsrAccountData) entity;
			if(data == null)
				return 0;

			return this._dal.DeleteByUsrAccount(data. UsrAccountPK);
		}

		internal int PurgeByBDTenant(BusinessBase entity)
		{
			BDTenantData data = (BDTenantData) entity;
			if(data == null)
				return 0;

			return this._dal.DeleteByBDTenant(data. BDTenantPK);
		}

		internal int PurgeByBDBuilding(BusinessBase entity)
		{
			BDBuildingData data = (BDBuildingData) entity;
			if(data == null)
				return 0;

			return this._dal.DeleteByBDBuilding(data. BDBuildingPK);
		}

		internal int PurgeByUsrGroup(BusinessBase entity)
		{
			UsrGroupData data = (UsrGroupData) entity;
			if(data == null)
				return 0;

			return this._dal.DeleteByUsrGroup(data. UsrGroupPK);
		}

		protected override int InsertEntity(BusinessBase entity)
		{
			UsrAccountDBRuleData data = (UsrAccountDBRuleData) entity;
			if(data == null)
				return 0;

			return this._dal.Insert(data);
		}

		protected override int UpdateEntity(BusinessBase entity)
		{
			UsrAccountDBRuleData data = (UsrAccountDBRuleData) entity;
			if(data == null)
				return 0;

			return this._dal.Update(data);
		}

		protected override void UpdateChildren(BusinessBase entity)
		{
			UsrAccountDBRuleData data = (UsrAccountDBRuleData) entity;
			if(data == null)
				return;

		}

		internal Result GetRowVersion(UsrAccountDBRuleDataCollection list)
		{
			return base.GetRowVersion(list);
		}

		protected override Result GetRowVersion(BusinessBase entity)
		{
			UsrAccountDBRuleData data = (UsrAccountDBRuleData) entity;
			if(data == null || !data.IsDirty)
				return new Result(true);

			Result result = new Result(true);
			if (entity.IsDeleted)
			{
				result.Add(data.ObjectID, new byte[0]);
				return result;
			}

			if (entity.IsSelfDirty)
			{
				result.Add(data.ObjectID, this._dal.GetRowVersion( data.UsrAccountDBRulePK));
			}
			return result;
		}

		public virtual UsrAccountDBRuleData GetByPK( System.Guid UsrAccountDBRulePK)
		{
			if (base.IsTrusted)
			{
				return this.Processing(this._dal.GetByPK( UsrAccountDBRulePK));
			}

			if (!base.IsAuthorizedSelect)
			{
				return null;
			}

			return this.Processing((UsrAccountDBRuleData) base.Filter(this._dal.GetByPK( UsrAccountDBRulePK)));
		}

		protected virtual UsrAccountDBRuleData GetEntity(string sqlWhere, SqlParameter[] paras)
		{
			if (base.IsTrusted)
			{
				return this.Processing(this._dal.GetEntityBy(sqlWhere, paras));
			}

			if (!base.IsAuthorizedSelect)
			{
				return null;
			}

			return this.Processing((UsrAccountDBRuleData) base.Filter(this._dal.GetEntityBy(sqlWhere, paras)));
		}

		public virtual UsrAccountDBRuleDataCollection GetAll()
		{
			if (base.IsTrusted)
			{
				return this.Processing(this._dal.GetAll());
			}

			if (!base.IsAuthorizedSelect)
			{
				return new UsrAccountDBRuleDataCollection();
			}

			return this.Processing((UsrAccountDBRuleDataCollection) base.Filter(this._dal.GetAll()));
		}

		public UsrAccountDBRuleViewCollection GetViewAll()
		{
			return new UsrAccountDBRuleViewCollection(this.GetAll());
		}

		protected virtual UsrAccountDBRuleDataCollection GetCollection(string sqlWhere, SqlParameter[] paras)
		{
			if (base.IsTrusted)
			{
				return this.Processing(this._dal.GetCollectionBy(sqlWhere, paras));
			}

			if (!base.IsAuthorizedSelect)
			{
				return new UsrAccountDBRuleDataCollection();
			}

			 return this.Processing((UsrAccountDBRuleDataCollection) base.Filter(this._dal.GetCollectionBy(sqlWhere, paras)));
		}

		public virtual UsrAccountDBRuleDataCollection GetByUsrAccount(System.Guid UsrAccountPK)
		{
			if (base.IsTrusted)
			{
				return this.Processing(this._dal.GetByUsrAccount(UsrAccountPK));
			}

			if (!base.IsAuthorizedSelect)
			{
				return null;
			}

			return this.Processing((UsrAccountDBRuleDataCollection) base.Filter(this._dal.GetByUsrAccount(UsrAccountPK)));
		}

		public UsrAccountDBRuleViewCollection GetViewByUsrAccount(System.Guid UsrAccountPK)
		{
			return new UsrAccountDBRuleViewCollection(this.GetByUsrAccount(UsrAccountPK));
		}

		protected virtual UsrAccountDBRuleData Processing(UsrAccountDBRuleData entity)
		{
			return entity;
		}

		protected virtual UsrAccountDBRuleDataCollection Processing(UsrAccountDBRuleDataCollection list)
		{
			UsrAccountDBRuleDataCollection retList = new UsrAccountDBRuleDataCollection();
			foreach(UsrAccountDBRuleData item in list)
			{
				UsrAccountDBRuleData data = this.Processing(item);
				if(data != null)
				{
					retList.Add(data);
				}
			}

			return retList;
		}

		public virtual Result Save(UsrAccountDBRuleData entity)
		{
			return base.Save(entity);
		}

		public virtual void SaveUnderTransaction(UsrAccountDBRuleData entity)
		{
			base.SaveUnderTransaction(entity);
		}

		public virtual Result Save(UsrAccountDBRuleDataCollection list)
		{
			return base.Save(list);
		}

		public virtual void SaveUnderTransaction(UsrAccountDBRuleDataCollection list)
		{
			base.SaveUnderTransaction(list);
		}


	}
	public abstract class UsrGroupBRRuleDataServiceBase : ServiceBase
	{
		protected UsrGroupBRRuleCRUD _dal;

		public UsrGroupBRRuleDataServiceBase(string connectionString, SecurityToken token) : base(connectionString, token)
		{
			this._dal = new UsrGroupBRRuleCRUD(connectionString);
			for (int i = 0; i < token.GetSortFields().Count; i++)
			{
				SortField field = token.GetSortFields()[i];
				this._dal.AddSortBy(field.FieldAlias, field.ASC);
			}
		}

		protected override string TableName
		{
			get
			{
				return "UsrGroupBRRule";
			}
		}


		protected override int DeleteEntity(BusinessBase entity)
		{
			UsrGroupBRRuleData data = (UsrGroupBRRuleData) entity;
			if(data == null)
				return 0;

			return this._dal.DeleteByPK( data.UsrGroupBRRule, data.RowVersion);
		}

		internal int DeleteByUsrGroup(BusinessBase entity)
		{
			UsrGroupData data = (UsrGroupData) entity;
			if(data == null)
				return 0;

			bool isLogDeleteEnabled = ServiceBase._DBLog.IsLogDeleteEnabled;
			bool isLinkDBDeleteEnabled = ServiceBase._DBLink.IsLinkDBDeleteEnabled;
			if (!isLogDeleteEnabled && !isLinkDBDeleteEnabled)
			{
				return this._dal.DeleteByUsrGroup(data. UsrGroupPK);
			}

			DataTable list = this._dal.GetLogByUsrGroup(data. UsrGroupPK);
			list.TableName = this._dal.TableName;
			int ret = this._dal.DeleteByUsrGroup(data. UsrGroupPK);
			if (isLogDeleteEnabled)
			{
				ServiceBase._DBLog.LogDelete(list, base.SecurityToken);
			}

			if (isLinkDBDeleteEnabled)
			{
				ServiceBase._DBLink.LinkDBDelete(list, base.TrustedToken);
			}

			return ret;
		}

		public virtual Result Purge(UsrGroupBRRuleData entity)
		{
			return base.Purge(entity);
		}

		protected override int PurgeEntity(BusinessBase entity)
		{
			UsrGroupBRRuleData data = (UsrGroupBRRuleData) entity;
			if(data == null)
				return 0;

			return this._dal.DeleteByPK( data.UsrGroupBRRule, data.RowVersion);
		}

		internal int PurgeByUsrGroup(BusinessBase entity)
		{
			UsrGroupData data = (UsrGroupData) entity;
			if(data == null)
				return 0;

			return this._dal.DeleteByUsrGroup(data. UsrGroupPK);
		}

		protected override int InsertEntity(BusinessBase entity)
		{
			UsrGroupBRRuleData data = (UsrGroupBRRuleData) entity;
			if(data == null)
				return 0;

			return this._dal.Insert(data);
		}

		protected override int UpdateEntity(BusinessBase entity)
		{
			UsrGroupBRRuleData data = (UsrGroupBRRuleData) entity;
			if(data == null)
				return 0;

			return this._dal.Update(data);
		}

		protected override void UpdateChildren(BusinessBase entity)
		{
			UsrGroupBRRuleData data = (UsrGroupBRRuleData) entity;
			if(data == null)
				return;

		}

		internal Result GetRowVersion(UsrGroupBRRuleDataCollection list)
		{
			return base.GetRowVersion(list);
		}

		protected override Result GetRowVersion(BusinessBase entity)
		{
			UsrGroupBRRuleData data = (UsrGroupBRRuleData) entity;
			if(data == null || !data.IsDirty)
				return new Result(true);

			Result result = new Result(true);
			if (entity.IsDeleted)
			{
				result.Add(data.ObjectID, new byte[0]);
				return result;
			}

			if (entity.IsSelfDirty)
			{
				result.Add(data.ObjectID, this._dal.GetRowVersion( data.UsrGroupBRRule));
			}
			return result;
		}

		public virtual UsrGroupBRRuleData GetByPK( System.Guid UsrGroupBRRule)
		{
			if (base.IsTrusted)
			{
				return this.Processing(this._dal.GetByPK( UsrGroupBRRule));
			}

			if (!base.IsAuthorizedSelect)
			{
				return null;
			}

			return this.Processing((UsrGroupBRRuleData) base.Filter(this._dal.GetByPK( UsrGroupBRRule)));
		}

		protected virtual UsrGroupBRRuleData GetEntity(string sqlWhere, SqlParameter[] paras)
		{
			if (base.IsTrusted)
			{
				return this.Processing(this._dal.GetEntityBy(sqlWhere, paras));
			}

			if (!base.IsAuthorizedSelect)
			{
				return null;
			}

			return this.Processing((UsrGroupBRRuleData) base.Filter(this._dal.GetEntityBy(sqlWhere, paras)));
		}

		public virtual UsrGroupBRRuleDataCollection GetAll()
		{
			if (base.IsTrusted)
			{
				return this.Processing(this._dal.GetAll());
			}

			if (!base.IsAuthorizedSelect)
			{
				return new UsrGroupBRRuleDataCollection();
			}

			return this.Processing((UsrGroupBRRuleDataCollection) base.Filter(this._dal.GetAll()));
		}

		public UsrGroupBRRuleViewCollection GetViewAll()
		{
			return new UsrGroupBRRuleViewCollection(this.GetAll());
		}

		protected virtual UsrGroupBRRuleDataCollection GetCollection(string sqlWhere, SqlParameter[] paras)
		{
			if (base.IsTrusted)
			{
				return this.Processing(this._dal.GetCollectionBy(sqlWhere, paras));
			}

			if (!base.IsAuthorizedSelect)
			{
				return new UsrGroupBRRuleDataCollection();
			}

			 return this.Processing((UsrGroupBRRuleDataCollection) base.Filter(this._dal.GetCollectionBy(sqlWhere, paras)));
		}

		public virtual UsrGroupBRRuleDataCollection GetByUsrGroup(System.Guid UsrGroupPK)
		{
			if (base.IsTrusted)
			{
				return this.Processing(this._dal.GetByUsrGroup(UsrGroupPK));
			}

			if (!base.IsAuthorizedSelect)
			{
				return null;
			}

			return this.Processing((UsrGroupBRRuleDataCollection) base.Filter(this._dal.GetByUsrGroup(UsrGroupPK)));
		}

		public UsrGroupBRRuleViewCollection GetViewByUsrGroup(System.Guid UsrGroupPK)
		{
			return new UsrGroupBRRuleViewCollection(this.GetByUsrGroup(UsrGroupPK));
		}

		protected virtual UsrGroupBRRuleData Processing(UsrGroupBRRuleData entity)
		{
			return entity;
		}

		protected virtual UsrGroupBRRuleDataCollection Processing(UsrGroupBRRuleDataCollection list)
		{
			UsrGroupBRRuleDataCollection retList = new UsrGroupBRRuleDataCollection();
			foreach(UsrGroupBRRuleData item in list)
			{
				UsrGroupBRRuleData data = this.Processing(item);
				if(data != null)
				{
					retList.Add(data);
				}
			}

			return retList;
		}

		public virtual Result Save(UsrGroupBRRuleData entity)
		{
			return base.Save(entity);
		}

		public virtual void SaveUnderTransaction(UsrGroupBRRuleData entity)
		{
			base.SaveUnderTransaction(entity);
		}

		public virtual Result Save(UsrGroupBRRuleDataCollection list)
		{
			return base.Save(list);
		}

		public virtual void SaveUnderTransaction(UsrGroupBRRuleDataCollection list)
		{
			base.SaveUnderTransaction(list);
		}


	}
	public abstract class ACInputGroupInputMapDataServiceBase : ServiceBase
	{
		protected ACInputGroupInputMapCRUD _dal;

		public ACInputGroupInputMapDataServiceBase(string connectionString, SecurityToken token) : base(connectionString, token)
		{
			this._dal = new ACInputGroupInputMapCRUD(connectionString);
			for (int i = 0; i < token.GetSortFields().Count; i++)
			{
				SortField field = token.GetSortFields()[i];
				this._dal.AddSortBy(field.FieldAlias, field.ASC);
			}
		}

		protected override string TableName
		{
			get
			{
				return "ACInputGroupInputMap";
			}
		}


		protected override int DeleteEntity(BusinessBase entity)
		{
			ACInputGroupInputMapData data = (ACInputGroupInputMapData) entity;
			if(data == null)
				return 0;

			return this._dal.DeleteByPK( data.ACInputGroupInputMapPK, data.RowVersion);
		}

		internal int DeleteByACInputGroup(BusinessBase entity)
		{
			ACInputGroupData data = (ACInputGroupData) entity;
			if(data == null)
				return 0;

			bool isLogDeleteEnabled = ServiceBase._DBLog.IsLogDeleteEnabled;
			bool isLinkDBDeleteEnabled = ServiceBase._DBLink.IsLinkDBDeleteEnabled;
			if (!isLogDeleteEnabled && !isLinkDBDeleteEnabled)
			{
				return this._dal.DeleteByACInputGroup(data. ACInputGroupPK);
			}

			DataTable list = this._dal.GetLogByACInputGroup(data. ACInputGroupPK);
			list.TableName = this._dal.TableName;
			int ret = this._dal.DeleteByACInputGroup(data. ACInputGroupPK);
			if (isLogDeleteEnabled)
			{
				ServiceBase._DBLog.LogDelete(list, base.SecurityToken);
			}

			if (isLinkDBDeleteEnabled)
			{
				ServiceBase._DBLink.LinkDBDelete(list, base.TrustedToken);
			}

			return ret;
		}

		internal int DeleteByACPanel(BusinessBase entity)
		{
			ACPanelData data = (ACPanelData) entity;
			if(data == null)
				return 0;

			bool isLogDeleteEnabled = ServiceBase._DBLog.IsLogDeleteEnabled;
			bool isLinkDBDeleteEnabled = ServiceBase._DBLink.IsLinkDBDeleteEnabled;
			if (!isLogDeleteEnabled && !isLinkDBDeleteEnabled)
			{
				return this._dal.DeleteByACPanel(data. ACPanelPK);
			}

			DataTable list = this._dal.GetLogByACPanel(data. ACPanelPK);
			list.TableName = this._dal.TableName;
			int ret = this._dal.DeleteByACPanel(data. ACPanelPK);
			if (isLogDeleteEnabled)
			{
				ServiceBase._DBLog.LogDelete(list, base.SecurityToken);
			}

			if (isLinkDBDeleteEnabled)
			{
				ServiceBase._DBLink.LinkDBDelete(list, base.TrustedToken);
			}

			return ret;
		}

		internal int DeleteByBDBuilding(BusinessBase entity)
		{
			BDBuildingData data = (BDBuildingData) entity;
			if(data == null)
				return 0;

			bool isLogDeleteEnabled = ServiceBase._DBLog.IsLogDeleteEnabled;
			bool isLinkDBDeleteEnabled = ServiceBase._DBLink.IsLinkDBDeleteEnabled;
			if (!isLogDeleteEnabled && !isLinkDBDeleteEnabled)
			{
				return this._dal.DeleteByBDBuilding(data. BDBuildingPK);
			}

			DataTable list = this._dal.GetLogByBDBuilding(data. BDBuildingPK);
			list.TableName = this._dal.TableName;
			int ret = this._dal.DeleteByBDBuilding(data. BDBuildingPK);
			if (isLogDeleteEnabled)
			{
				ServiceBase._DBLog.LogDelete(list, base.SecurityToken);
			}

			if (isLinkDBDeleteEnabled)
			{
				ServiceBase._DBLink.LinkDBDelete(list, base.TrustedToken);
			}

			return ret;
		}

		internal int DeleteByACInput(BusinessBase entity)
		{
			ACInputData data = (ACInputData) entity;
			if(data == null)
				return 0;

			bool isLogDeleteEnabled = ServiceBase._DBLog.IsLogDeleteEnabled;
			bool isLinkDBDeleteEnabled = ServiceBase._DBLink.IsLinkDBDeleteEnabled;
			if (!isLogDeleteEnabled && !isLinkDBDeleteEnabled)
			{
				return this._dal.DeleteByACInput(data. ACInputPK);
			}

			DataTable list = this._dal.GetLogByACInput(data. ACInputPK);
			list.TableName = this._dal.TableName;
			int ret = this._dal.DeleteByACInput(data. ACInputPK);
			if (isLogDeleteEnabled)
			{
				ServiceBase._DBLog.LogDelete(list, base.SecurityToken);
			}

			if (isLinkDBDeleteEnabled)
			{
				ServiceBase._DBLink.LinkDBDelete(list, base.TrustedToken);
			}

			return ret;
		}

		public virtual Result Purge(ACInputGroupInputMapData entity)
		{
			return base.Purge(entity);
		}

		protected override int PurgeEntity(BusinessBase entity)
		{
			ACInputGroupInputMapData data = (ACInputGroupInputMapData) entity;
			if(data == null)
				return 0;

			return this._dal.DeleteByPK( data.ACInputGroupInputMapPK, data.RowVersion);
		}

		internal int PurgeByACInputGroup(BusinessBase entity)
		{
			ACInputGroupData data = (ACInputGroupData) entity;
			if(data == null)
				return 0;

			return this._dal.DeleteByACInputGroup(data. ACInputGroupPK);
		}

		internal int PurgeByACPanel(BusinessBase entity)
		{
			ACPanelData data = (ACPanelData) entity;
			if(data == null)
				return 0;

			return this._dal.DeleteByACPanel(data. ACPanelPK);
		}

		internal int PurgeByBDBuilding(BusinessBase entity)
		{
			BDBuildingData data = (BDBuildingData) entity;
			if(data == null)
				return 0;

			return this._dal.DeleteByBDBuilding(data. BDBuildingPK);
		}

		internal int PurgeByACInput(BusinessBase entity)
		{
			ACInputData data = (ACInputData) entity;
			if(data == null)
				return 0;

			return this._dal.DeleteByACInput(data. ACInputPK);
		}

		protected override int InsertEntity(BusinessBase entity)
		{
			ACInputGroupInputMapData data = (ACInputGroupInputMapData) entity;
			if(data == null)
				return 0;

			return this._dal.Insert(data);
		}

		protected override int UpdateEntity(BusinessBase entity)
		{
			ACInputGroupInputMapData data = (ACInputGroupInputMapData) entity;
			if(data == null)
				return 0;

			return this._dal.Update(data);
		}

		protected override void UpdateChildren(BusinessBase entity)
		{
			ACInputGroupInputMapData data = (ACInputGroupInputMapData) entity;
			if(data == null)
				return;

		}

		internal Result GetRowVersion(ACInputGroupInputMapDataCollection list)
		{
			return base.GetRowVersion(list);
		}

		protected override Result GetRowVersion(BusinessBase entity)
		{
			ACInputGroupInputMapData data = (ACInputGroupInputMapData) entity;
			if(data == null || !data.IsDirty)
				return new Result(true);

			Result result = new Result(true);
			if (entity.IsDeleted)
			{
				result.Add(data.ObjectID, new byte[0]);
				return result;
			}

			if (entity.IsSelfDirty)
			{
				result.Add(data.ObjectID, this._dal.GetRowVersion( data.ACInputGroupInputMapPK));
			}
			return result;
		}

		public virtual ACInputGroupInputMapData GetByPK( System.Guid ACInputGroupInputMapPK)
		{
			if (base.IsTrusted)
			{
				return this.Processing(this._dal.GetByPK( ACInputGroupInputMapPK));
			}

			if (!base.IsAuthorizedSelect)
			{
				return null;
			}

			return this.Processing((ACInputGroupInputMapData) base.Filter(this._dal.GetByPK( ACInputGroupInputMapPK)));
		}

		protected virtual ACInputGroupInputMapData GetEntity(string sqlWhere, SqlParameter[] paras)
		{
			if (base.IsTrusted)
			{
				return this.Processing(this._dal.GetEntityBy(sqlWhere, paras));
			}

			if (!base.IsAuthorizedSelect)
			{
				return null;
			}

			return this.Processing((ACInputGroupInputMapData) base.Filter(this._dal.GetEntityBy(sqlWhere, paras)));
		}

		public virtual ACInputGroupInputMapDataCollection GetAll()
		{
			if (base.IsTrusted)
			{
				return this.Processing(this._dal.GetAll());
			}

			if (!base.IsAuthorizedSelect)
			{
				return new ACInputGroupInputMapDataCollection();
			}

			return this.Processing((ACInputGroupInputMapDataCollection) base.Filter(this._dal.GetAll()));
		}

		public ACInputGroupInputMapViewCollection GetViewAll()
		{
			return new ACInputGroupInputMapViewCollection(this.GetAll());
		}

		protected virtual ACInputGroupInputMapDataCollection GetCollection(string sqlWhere, SqlParameter[] paras)
		{
			if (base.IsTrusted)
			{
				return this.Processing(this._dal.GetCollectionBy(sqlWhere, paras));
			}

			if (!base.IsAuthorizedSelect)
			{
				return new ACInputGroupInputMapDataCollection();
			}

			 return this.Processing((ACInputGroupInputMapDataCollection) base.Filter(this._dal.GetCollectionBy(sqlWhere, paras)));
		}

		public virtual ACInputGroupInputMapDataCollection GetByACInputGroup(System.Guid ACInputGroupPK)
		{
			if (base.IsTrusted)
			{
				return this.Processing(this._dal.GetByACInputGroup(ACInputGroupPK));
			}

			if (!base.IsAuthorizedSelect)
			{
				return null;
			}

			return this.Processing((ACInputGroupInputMapDataCollection) base.Filter(this._dal.GetByACInputGroup(ACInputGroupPK)));
		}

		public ACInputGroupInputMapViewCollection GetViewByACInputGroup(System.Guid ACInputGroupPK)
		{
			return new ACInputGroupInputMapViewCollection(this.GetByACInputGroup(ACInputGroupPK));
		}

		public virtual ACInputGroupInputMapDataCollection GetByACInput(System.Guid ACInputPK)
		{
			if (base.IsTrusted)
			{
				return this.Processing(this._dal.GetByACInput(ACInputPK));
			}

			if (!base.IsAuthorizedSelect)
			{
				return null;
			}

			return this.Processing((ACInputGroupInputMapDataCollection) base.Filter(this._dal.GetByACInput(ACInputPK)));
		}

		public ACInputGroupInputMapViewCollection GetViewByACInput(System.Guid ACInputPK)
		{
			return new ACInputGroupInputMapViewCollection(this.GetByACInput(ACInputPK));
		}

		protected virtual ACInputGroupInputMapData Processing(ACInputGroupInputMapData entity)
		{
			return entity;
		}

		protected virtual ACInputGroupInputMapDataCollection Processing(ACInputGroupInputMapDataCollection list)
		{
			ACInputGroupInputMapDataCollection retList = new ACInputGroupInputMapDataCollection();
			foreach(ACInputGroupInputMapData item in list)
			{
				ACInputGroupInputMapData data = this.Processing(item);
				if(data != null)
				{
					retList.Add(data);
				}
			}

			return retList;
		}

		public virtual Result Save(ACInputGroupInputMapData entity)
		{
			return base.Save(entity);
		}

		public virtual void SaveUnderTransaction(ACInputGroupInputMapData entity)
		{
			base.SaveUnderTransaction(entity);
		}

		public virtual Result Save(ACInputGroupInputMapDataCollection list)
		{
			return base.Save(list);
		}

		public virtual void SaveUnderTransaction(ACInputGroupInputMapDataCollection list)
		{
			base.SaveUnderTransaction(list);
		}


	}
	public abstract class UsrAccountBRRuleDataServiceBase : ServiceBase
	{
		protected UsrAccountBRRuleCRUD _dal;

		public UsrAccountBRRuleDataServiceBase(string connectionString, SecurityToken token) : base(connectionString, token)
		{
			this._dal = new UsrAccountBRRuleCRUD(connectionString);
			for (int i = 0; i < token.GetSortFields().Count; i++)
			{
				SortField field = token.GetSortFields()[i];
				this._dal.AddSortBy(field.FieldAlias, field.ASC);
			}
		}

		protected override string TableName
		{
			get
			{
				return "UsrAccountBRRule";
			}
		}


		protected override int DeleteEntity(BusinessBase entity)
		{
			UsrAccountBRRuleData data = (UsrAccountBRRuleData) entity;
			if(data == null)
				return 0;

			return this._dal.DeleteByPK( data.UsrAccountBRRulePK, data.RowVersion);
		}

		internal int DeleteByUsrAccount(BusinessBase entity)
		{
			UsrAccountData data = (UsrAccountData) entity;
			if(data == null)
				return 0;

			bool isLogDeleteEnabled = ServiceBase._DBLog.IsLogDeleteEnabled;
			bool isLinkDBDeleteEnabled = ServiceBase._DBLink.IsLinkDBDeleteEnabled;
			if (!isLogDeleteEnabled && !isLinkDBDeleteEnabled)
			{
				return this._dal.DeleteByUsrAccount(data. UsrAccountPK);
			}

			DataTable list = this._dal.GetLogByUsrAccount(data. UsrAccountPK);
			list.TableName = this._dal.TableName;
			int ret = this._dal.DeleteByUsrAccount(data. UsrAccountPK);
			if (isLogDeleteEnabled)
			{
				ServiceBase._DBLog.LogDelete(list, base.SecurityToken);
			}

			if (isLinkDBDeleteEnabled)
			{
				ServiceBase._DBLink.LinkDBDelete(list, base.TrustedToken);
			}

			return ret;
		}

		internal int DeleteByBDTenant(BusinessBase entity)
		{
			BDTenantData data = (BDTenantData) entity;
			if(data == null)
				return 0;

			bool isLogDeleteEnabled = ServiceBase._DBLog.IsLogDeleteEnabled;
			bool isLinkDBDeleteEnabled = ServiceBase._DBLink.IsLinkDBDeleteEnabled;
			if (!isLogDeleteEnabled && !isLinkDBDeleteEnabled)
			{
				return this._dal.DeleteByBDTenant(data. BDTenantPK);
			}

			DataTable list = this._dal.GetLogByBDTenant(data. BDTenantPK);
			list.TableName = this._dal.TableName;
			int ret = this._dal.DeleteByBDTenant(data. BDTenantPK);
			if (isLogDeleteEnabled)
			{
				ServiceBase._DBLog.LogDelete(list, base.SecurityToken);
			}

			if (isLinkDBDeleteEnabled)
			{
				ServiceBase._DBLink.LinkDBDelete(list, base.TrustedToken);
			}

			return ret;
		}

		internal int DeleteByBDBuilding(BusinessBase entity)
		{
			BDBuildingData data = (BDBuildingData) entity;
			if(data == null)
				return 0;

			bool isLogDeleteEnabled = ServiceBase._DBLog.IsLogDeleteEnabled;
			bool isLinkDBDeleteEnabled = ServiceBase._DBLink.IsLinkDBDeleteEnabled;
			if (!isLogDeleteEnabled && !isLinkDBDeleteEnabled)
			{
				return this._dal.DeleteByBDBuilding(data. BDBuildingPK);
			}

			DataTable list = this._dal.GetLogByBDBuilding(data. BDBuildingPK);
			list.TableName = this._dal.TableName;
			int ret = this._dal.DeleteByBDBuilding(data. BDBuildingPK);
			if (isLogDeleteEnabled)
			{
				ServiceBase._DBLog.LogDelete(list, base.SecurityToken);
			}

			if (isLinkDBDeleteEnabled)
			{
				ServiceBase._DBLink.LinkDBDelete(list, base.TrustedToken);
			}

			return ret;
		}

		internal int DeleteByUsrGroup(BusinessBase entity)
		{
			UsrGroupData data = (UsrGroupData) entity;
			if(data == null)
				return 0;

			bool isLogDeleteEnabled = ServiceBase._DBLog.IsLogDeleteEnabled;
			bool isLinkDBDeleteEnabled = ServiceBase._DBLink.IsLinkDBDeleteEnabled;
			if (!isLogDeleteEnabled && !isLinkDBDeleteEnabled)
			{
				return this._dal.DeleteByUsrGroup(data. UsrGroupPK);
			}

			DataTable list = this._dal.GetLogByUsrGroup(data. UsrGroupPK);
			list.TableName = this._dal.TableName;
			int ret = this._dal.DeleteByUsrGroup(data. UsrGroupPK);
			if (isLogDeleteEnabled)
			{
				ServiceBase._DBLog.LogDelete(list, base.SecurityToken);
			}

			if (isLinkDBDeleteEnabled)
			{
				ServiceBase._DBLink.LinkDBDelete(list, base.TrustedToken);
			}

			return ret;
		}

		public virtual Result Purge(UsrAccountBRRuleData entity)
		{
			return base.Purge(entity);
		}

		protected override int PurgeEntity(BusinessBase entity)
		{
			UsrAccountBRRuleData data = (UsrAccountBRRuleData) entity;
			if(data == null)
				return 0;

			return this._dal.DeleteByPK( data.UsrAccountBRRulePK, data.RowVersion);
		}

		internal int PurgeByUsrAccount(BusinessBase entity)
		{
			UsrAccountData data = (UsrAccountData) entity;
			if(data == null)
				return 0;

			return this._dal.DeleteByUsrAccount(data. UsrAccountPK);
		}

		internal int PurgeByBDTenant(BusinessBase entity)
		{
			BDTenantData data = (BDTenantData) entity;
			if(data == null)
				return 0;

			return this._dal.DeleteByBDTenant(data. BDTenantPK);
		}

		internal int PurgeByBDBuilding(BusinessBase entity)
		{
			BDBuildingData data = (BDBuildingData) entity;
			if(data == null)
				return 0;

			return this._dal.DeleteByBDBuilding(data. BDBuildingPK);
		}

		internal int PurgeByUsrGroup(BusinessBase entity)
		{
			UsrGroupData data = (UsrGroupData) entity;
			if(data == null)
				return 0;

			return this._dal.DeleteByUsrGroup(data. UsrGroupPK);
		}

		protected override int InsertEntity(BusinessBase entity)
		{
			UsrAccountBRRuleData data = (UsrAccountBRRuleData) entity;
			if(data == null)
				return 0;

			return this._dal.Insert(data);
		}

		protected override int UpdateEntity(BusinessBase entity)
		{
			UsrAccountBRRuleData data = (UsrAccountBRRuleData) entity;
			if(data == null)
				return 0;

			return this._dal.Update(data);
		}

		protected override void UpdateChildren(BusinessBase entity)
		{
			UsrAccountBRRuleData data = (UsrAccountBRRuleData) entity;
			if(data == null)
				return;

		}

		internal Result GetRowVersion(UsrAccountBRRuleDataCollection list)
		{
			return base.GetRowVersion(list);
		}

		protected override Result GetRowVersion(BusinessBase entity)
		{
			UsrAccountBRRuleData data = (UsrAccountBRRuleData) entity;
			if(data == null || !data.IsDirty)
				return new Result(true);

			Result result = new Result(true);
			if (entity.IsDeleted)
			{
				result.Add(data.ObjectID, new byte[0]);
				return result;
			}

			if (entity.IsSelfDirty)
			{
				result.Add(data.ObjectID, this._dal.GetRowVersion( data.UsrAccountBRRulePK));
			}
			return result;
		}

		public virtual UsrAccountBRRuleData GetByPK( System.Guid UsrAccountBRRulePK)
		{
			if (base.IsTrusted)
			{
				return this.Processing(this._dal.GetByPK( UsrAccountBRRulePK));
			}

			if (!base.IsAuthorizedSelect)
			{
				return null;
			}

			return this.Processing((UsrAccountBRRuleData) base.Filter(this._dal.GetByPK( UsrAccountBRRulePK)));
		}

		protected virtual UsrAccountBRRuleData GetEntity(string sqlWhere, SqlParameter[] paras)
		{
			if (base.IsTrusted)
			{
				return this.Processing(this._dal.GetEntityBy(sqlWhere, paras));
			}

			if (!base.IsAuthorizedSelect)
			{
				return null;
			}

			return this.Processing((UsrAccountBRRuleData) base.Filter(this._dal.GetEntityBy(sqlWhere, paras)));
		}

		public virtual UsrAccountBRRuleDataCollection GetAll()
		{
			if (base.IsTrusted)
			{
				return this.Processing(this._dal.GetAll());
			}

			if (!base.IsAuthorizedSelect)
			{
				return new UsrAccountBRRuleDataCollection();
			}

			return this.Processing((UsrAccountBRRuleDataCollection) base.Filter(this._dal.GetAll()));
		}

		public UsrAccountBRRuleViewCollection GetViewAll()
		{
			return new UsrAccountBRRuleViewCollection(this.GetAll());
		}

		protected virtual UsrAccountBRRuleDataCollection GetCollection(string sqlWhere, SqlParameter[] paras)
		{
			if (base.IsTrusted)
			{
				return this.Processing(this._dal.GetCollectionBy(sqlWhere, paras));
			}

			if (!base.IsAuthorizedSelect)
			{
				return new UsrAccountBRRuleDataCollection();
			}

			 return this.Processing((UsrAccountBRRuleDataCollection) base.Filter(this._dal.GetCollectionBy(sqlWhere, paras)));
		}

		public virtual UsrAccountBRRuleDataCollection GetByUsrAccount(System.Guid UsrAccountPK)
		{
			if (base.IsTrusted)
			{
				return this.Processing(this._dal.GetByUsrAccount(UsrAccountPK));
			}

			if (!base.IsAuthorizedSelect)
			{
				return null;
			}

			return this.Processing((UsrAccountBRRuleDataCollection) base.Filter(this._dal.GetByUsrAccount(UsrAccountPK)));
		}

		public UsrAccountBRRuleViewCollection GetViewByUsrAccount(System.Guid UsrAccountPK)
		{
			return new UsrAccountBRRuleViewCollection(this.GetByUsrAccount(UsrAccountPK));
		}

		protected virtual UsrAccountBRRuleData Processing(UsrAccountBRRuleData entity)
		{
			return entity;
		}

		protected virtual UsrAccountBRRuleDataCollection Processing(UsrAccountBRRuleDataCollection list)
		{
			UsrAccountBRRuleDataCollection retList = new UsrAccountBRRuleDataCollection();
			foreach(UsrAccountBRRuleData item in list)
			{
				UsrAccountBRRuleData data = this.Processing(item);
				if(data != null)
				{
					retList.Add(data);
				}
			}

			return retList;
		}

		public virtual Result Save(UsrAccountBRRuleData entity)
		{
			return base.Save(entity);
		}

		public virtual void SaveUnderTransaction(UsrAccountBRRuleData entity)
		{
			base.SaveUnderTransaction(entity);
		}

		public virtual Result Save(UsrAccountBRRuleDataCollection list)
		{
			return base.Save(list);
		}

		public virtual void SaveUnderTransaction(UsrAccountBRRuleDataCollection list)
		{
			base.SaveUnderTransaction(list);
		}


	}
	public abstract class UsrAccountTenantMapDataServiceBase : ServiceBase
	{
		protected UsrAccountTenantMapCRUD _dal;

		public UsrAccountTenantMapDataServiceBase(string connectionString, SecurityToken token) : base(connectionString, token)
		{
			this._dal = new UsrAccountTenantMapCRUD(connectionString);
			for (int i = 0; i < token.GetSortFields().Count; i++)
			{
				SortField field = token.GetSortFields()[i];
				this._dal.AddSortBy(field.FieldAlias, field.ASC);
			}
		}

		protected override string TableName
		{
			get
			{
				return "UsrAccountTenantMap";
			}
		}


		protected override int DeleteEntity(BusinessBase entity)
		{
			UsrAccountTenantMapData data = (UsrAccountTenantMapData) entity;
			if(data == null)
				return 0;

			return this._dal.DeleteByPK( data.UsrAccountTenantMapPK, data.RowVersion);
		}

		internal int DeleteByBDTenant(BusinessBase entity)
		{
			BDTenantData data = (BDTenantData) entity;
			if(data == null)
				return 0;

			bool isLogDeleteEnabled = ServiceBase._DBLog.IsLogDeleteEnabled;
			bool isLinkDBDeleteEnabled = ServiceBase._DBLink.IsLinkDBDeleteEnabled;
			if (!isLogDeleteEnabled && !isLinkDBDeleteEnabled)
			{
				return this._dal.DeleteByBDTenant(data. BDTenantPK);
			}

			DataTable list = this._dal.GetLogByBDTenant(data. BDTenantPK);
			list.TableName = this._dal.TableName;
			int ret = this._dal.DeleteByBDTenant(data. BDTenantPK);
			if (isLogDeleteEnabled)
			{
				ServiceBase._DBLog.LogDelete(list, base.SecurityToken);
			}

			if (isLinkDBDeleteEnabled)
			{
				ServiceBase._DBLink.LinkDBDelete(list, base.TrustedToken);
			}

			return ret;
		}

		internal int DeleteByBDBuilding(BusinessBase entity)
		{
			BDBuildingData data = (BDBuildingData) entity;
			if(data == null)
				return 0;

			bool isLogDeleteEnabled = ServiceBase._DBLog.IsLogDeleteEnabled;
			bool isLinkDBDeleteEnabled = ServiceBase._DBLink.IsLinkDBDeleteEnabled;
			if (!isLogDeleteEnabled && !isLinkDBDeleteEnabled)
			{
				return this._dal.DeleteByBDBuilding(data. BDBuildingPK);
			}

			DataTable list = this._dal.GetLogByBDBuilding(data. BDBuildingPK);
			list.TableName = this._dal.TableName;
			int ret = this._dal.DeleteByBDBuilding(data. BDBuildingPK);
			if (isLogDeleteEnabled)
			{
				ServiceBase._DBLog.LogDelete(list, base.SecurityToken);
			}

			if (isLinkDBDeleteEnabled)
			{
				ServiceBase._DBLink.LinkDBDelete(list, base.TrustedToken);
			}

			return ret;
		}

		internal int DeleteByUsrAccount(BusinessBase entity)
		{
			UsrAccountData data = (UsrAccountData) entity;
			if(data == null)
				return 0;

			bool isLogDeleteEnabled = ServiceBase._DBLog.IsLogDeleteEnabled;
			bool isLinkDBDeleteEnabled = ServiceBase._DBLink.IsLinkDBDeleteEnabled;
			if (!isLogDeleteEnabled && !isLinkDBDeleteEnabled)
			{
				return this._dal.DeleteByUsrAccount(data. UsrAccountPK);
			}

			DataTable list = this._dal.GetLogByUsrAccount(data. UsrAccountPK);
			list.TableName = this._dal.TableName;
			int ret = this._dal.DeleteByUsrAccount(data. UsrAccountPK);
			if (isLogDeleteEnabled)
			{
				ServiceBase._DBLog.LogDelete(list, base.SecurityToken);
			}

			if (isLinkDBDeleteEnabled)
			{
				ServiceBase._DBLink.LinkDBDelete(list, base.TrustedToken);
			}

			return ret;
		}

		internal int DeleteByUsrGroup(BusinessBase entity)
		{
			UsrGroupData data = (UsrGroupData) entity;
			if(data == null)
				return 0;

			bool isLogDeleteEnabled = ServiceBase._DBLog.IsLogDeleteEnabled;
			bool isLinkDBDeleteEnabled = ServiceBase._DBLink.IsLinkDBDeleteEnabled;
			if (!isLogDeleteEnabled && !isLinkDBDeleteEnabled)
			{
				return this._dal.DeleteByUsrGroup(data. UsrGroupPK);
			}

			DataTable list = this._dal.GetLogByUsrGroup(data. UsrGroupPK);
			list.TableName = this._dal.TableName;
			int ret = this._dal.DeleteByUsrGroup(data. UsrGroupPK);
			if (isLogDeleteEnabled)
			{
				ServiceBase._DBLog.LogDelete(list, base.SecurityToken);
			}

			if (isLinkDBDeleteEnabled)
			{
				ServiceBase._DBLink.LinkDBDelete(list, base.TrustedToken);
			}

			return ret;
		}

		public virtual Result Purge(UsrAccountTenantMapData entity)
		{
			return base.Purge(entity);
		}

		protected override int PurgeEntity(BusinessBase entity)
		{
			UsrAccountTenantMapData data = (UsrAccountTenantMapData) entity;
			if(data == null)
				return 0;

			return this._dal.DeleteByPK( data.UsrAccountTenantMapPK, data.RowVersion);
		}

		internal int PurgeByBDTenant(BusinessBase entity)
		{
			BDTenantData data = (BDTenantData) entity;
			if(data == null)
				return 0;

			return this._dal.DeleteByBDTenant(data. BDTenantPK);
		}

		internal int PurgeByBDBuilding(BusinessBase entity)
		{
			BDBuildingData data = (BDBuildingData) entity;
			if(data == null)
				return 0;

			return this._dal.DeleteByBDBuilding(data. BDBuildingPK);
		}

		internal int PurgeByUsrAccount(BusinessBase entity)
		{
			UsrAccountData data = (UsrAccountData) entity;
			if(data == null)
				return 0;

			return this._dal.DeleteByUsrAccount(data. UsrAccountPK);
		}

		internal int PurgeByUsrGroup(BusinessBase entity)
		{
			UsrGroupData data = (UsrGroupData) entity;
			if(data == null)
				return 0;

			return this._dal.DeleteByUsrGroup(data. UsrGroupPK);
		}

		protected override int InsertEntity(BusinessBase entity)
		{
			UsrAccountTenantMapData data = (UsrAccountTenantMapData) entity;
			if(data == null)
				return 0;

			return this._dal.Insert(data);
		}

		protected override int UpdateEntity(BusinessBase entity)
		{
			UsrAccountTenantMapData data = (UsrAccountTenantMapData) entity;
			if(data == null)
				return 0;

			return this._dal.Update(data);
		}

		protected override void UpdateChildren(BusinessBase entity)
		{
			UsrAccountTenantMapData data = (UsrAccountTenantMapData) entity;
			if(data == null)
				return;

		}

		internal Result GetRowVersion(UsrAccountTenantMapDataCollection list)
		{
			return base.GetRowVersion(list);
		}

		protected override Result GetRowVersion(BusinessBase entity)
		{
			UsrAccountTenantMapData data = (UsrAccountTenantMapData) entity;
			if(data == null || !data.IsDirty)
				return new Result(true);

			Result result = new Result(true);
			if (entity.IsDeleted)
			{
				result.Add(data.ObjectID, new byte[0]);
				return result;
			}

			if (entity.IsSelfDirty)
			{
				result.Add(data.ObjectID, this._dal.GetRowVersion( data.UsrAccountTenantMapPK));
			}
			return result;
		}

		public virtual UsrAccountTenantMapData GetByPK( System.Guid UsrAccountTenantMapPK)
		{
			if (base.IsTrusted)
			{
				return this.Processing(this._dal.GetByPK( UsrAccountTenantMapPK));
			}

			if (!base.IsAuthorizedSelect)
			{
				return null;
			}

			return this.Processing((UsrAccountTenantMapData) base.Filter(this._dal.GetByPK( UsrAccountTenantMapPK)));
		}

		protected virtual UsrAccountTenantMapData GetEntity(string sqlWhere, SqlParameter[] paras)
		{
			if (base.IsTrusted)
			{
				return this.Processing(this._dal.GetEntityBy(sqlWhere, paras));
			}

			if (!base.IsAuthorizedSelect)
			{
				return null;
			}

			return this.Processing((UsrAccountTenantMapData) base.Filter(this._dal.GetEntityBy(sqlWhere, paras)));
		}

		public virtual UsrAccountTenantMapDataCollection GetAll()
		{
			if (base.IsTrusted)
			{
				return this.Processing(this._dal.GetAll());
			}

			if (!base.IsAuthorizedSelect)
			{
				return new UsrAccountTenantMapDataCollection();
			}

			return this.Processing((UsrAccountTenantMapDataCollection) base.Filter(this._dal.GetAll()));
		}

		public UsrAccountTenantMapViewCollection GetViewAll()
		{
			return new UsrAccountTenantMapViewCollection(this.GetAll());
		}

		protected virtual UsrAccountTenantMapDataCollection GetCollection(string sqlWhere, SqlParameter[] paras)
		{
			if (base.IsTrusted)
			{
				return this.Processing(this._dal.GetCollectionBy(sqlWhere, paras));
			}

			if (!base.IsAuthorizedSelect)
			{
				return new UsrAccountTenantMapDataCollection();
			}

			 return this.Processing((UsrAccountTenantMapDataCollection) base.Filter(this._dal.GetCollectionBy(sqlWhere, paras)));
		}

		public virtual UsrAccountTenantMapDataCollection GetByBDTenant(System.Guid BDTenantPK)
		{
			if (base.IsTrusted)
			{
				return this.Processing(this._dal.GetByBDTenant(BDTenantPK));
			}

			if (!base.IsAuthorizedSelect)
			{
				return null;
			}

			return this.Processing((UsrAccountTenantMapDataCollection) base.Filter(this._dal.GetByBDTenant(BDTenantPK)));
		}

		public UsrAccountTenantMapViewCollection GetViewByBDTenant(System.Guid BDTenantPK)
		{
			return new UsrAccountTenantMapViewCollection(this.GetByBDTenant(BDTenantPK));
		}

		public virtual UsrAccountTenantMapDataCollection GetByUsrAccount(System.Guid UsrAccountPK)
		{
			if (base.IsTrusted)
			{
				return this.Processing(this._dal.GetByUsrAccount(UsrAccountPK));
			}

			if (!base.IsAuthorizedSelect)
			{
				return null;
			}

			return this.Processing((UsrAccountTenantMapDataCollection) base.Filter(this._dal.GetByUsrAccount(UsrAccountPK)));
		}

		public UsrAccountTenantMapViewCollection GetViewByUsrAccount(System.Guid UsrAccountPK)
		{
			return new UsrAccountTenantMapViewCollection(this.GetByUsrAccount(UsrAccountPK));
		}

		protected virtual UsrAccountTenantMapData Processing(UsrAccountTenantMapData entity)
		{
			return entity;
		}

		protected virtual UsrAccountTenantMapDataCollection Processing(UsrAccountTenantMapDataCollection list)
		{
			UsrAccountTenantMapDataCollection retList = new UsrAccountTenantMapDataCollection();
			foreach(UsrAccountTenantMapData item in list)
			{
				UsrAccountTenantMapData data = this.Processing(item);
				if(data != null)
				{
					retList.Add(data);
				}
			}

			return retList;
		}

		public virtual Result Save(UsrAccountTenantMapData entity)
		{
			return base.Save(entity);
		}

		public virtual void SaveUnderTransaction(UsrAccountTenantMapData entity)
		{
			base.SaveUnderTransaction(entity);
		}

		public virtual Result Save(UsrAccountTenantMapDataCollection list)
		{
			return base.Save(list);
		}

		public virtual void SaveUnderTransaction(UsrAccountTenantMapDataCollection list)
		{
			base.SaveUnderTransaction(list);
		}


	}
}
