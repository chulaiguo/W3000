using System;
using Cheke;
using W3000.Data;
using W3000.BasicServiceWrapper;

namespace W3000.ViewObj
{
	public partial class ACAccessLevel
	{
		public static Cheke.BusinessEntity.Result Purge(W3000.Data.ACAccessLevelData entity)
		{
			return Purge(entity, Identity.Token);
		}

		public static Cheke.BusinessEntity.Result Purge(W3000.Data.ACAccessLevelData entity, SecurityToken token)
		{
			if(entity != null)
			{
				entity = new W3000.Data.ACAccessLevelData(entity);
			}

			Cheke.BusinessEntity.Result _result_ = ACAccessLevelWrapper.Purge(entity, token);
			if(_result_ == null)
				return null;

			return _result_;
		}

		public static Cheke.BusinessEntity.Result Save(W3000.Data.ACAccessLevelData entity)
		{
			return Save(entity, Identity.Token);
		}

		public static Cheke.BusinessEntity.Result Save(W3000.Data.ACAccessLevelData entity, SecurityToken token)
		{
			if(entity != null)
			{
				entity = new W3000.Data.ACAccessLevelData(entity);
			}

			Cheke.BusinessEntity.Result _result_ = ACAccessLevelWrapper.Save(entity, token);
			if(_result_ == null)
				return null;

			return _result_;
		}

		public static Cheke.BusinessEntity.Result Save(W3000.Data.ACAccessLevelDataCollection list)
		{
			return Save(list, Identity.Token);
		}

		public static Cheke.BusinessEntity.Result Save(W3000.Data.ACAccessLevelDataCollection list, SecurityToken token)
		{
			if(list != null)
			{
				list = new W3000.Data.ACAccessLevelDataCollection(list);
			}

			Cheke.BusinessEntity.Result _result_ = ACAccessLevelWrapper.Save(list, token);
			if(_result_ == null)
				return null;

			return _result_;
		}

		public static ACAccessLevelCollection GetByModifiedOn(System.DateTime begin,System.DateTime end)
		{
			return GetByModifiedOn(begin,end, Identity.Token);
		}

		public static ACAccessLevelCollection GetByModifiedOn(System.DateTime begin,System.DateTime end, SecurityToken token)
		{

			W3000.Data.ACAccessLevelDataCollection _result_ = ACAccessLevelWrapper.GetByModifiedOn(begin,end, token);
			if(_result_ == null)
				return null;

			return new ACAccessLevelCollection(_result_);
		}

		public static ACAccessLevelCollection GetByMappedACMainZone(System.Guid ACMainZonePK)
		{
			return GetByMappedACMainZone(ACMainZonePK, Identity.Token);
		}

		public static ACAccessLevelCollection GetByMappedACMainZone(System.Guid ACMainZonePK, SecurityToken token)
		{

			W3000.Data.ACAccessLevelDataCollection _result_ = ACAccessLevelWrapper.GetByMappedACMainZone(ACMainZonePK, token);
			if(_result_ == null)
				return null;

			return new ACAccessLevelCollection(_result_);
		}

		public static System.Int32 GetAllCount()
		{
			return GetAllCount( Identity.Token);
		}

		public static System.Int32 GetAllCount(SecurityToken token)
		{

			System.Int32 _result_ = ACAccessLevelWrapper.GetAllCount( token);
			return _result_;
		}

		public static ACAccessLevelCollection GetAllPage(System.Int32 pageIndex,System.Int32 pageSize)
		{
			return GetAllPage(pageIndex,pageSize, Identity.Token);
		}

		public static ACAccessLevelCollection GetAllPage(System.Int32 pageIndex,System.Int32 pageSize, SecurityToken token)
		{

			W3000.Data.ACAccessLevelDataCollection _result_ = ACAccessLevelWrapper.GetAllPage(pageIndex,pageSize, token);
			if(_result_ == null)
				return null;

			return new ACAccessLevelCollection(_result_);
		}

		public static ACAccessLevel GetByUK(System.Guid BDBuildingPK,System.Int16 AccessLevelID)
		{
			return GetByUK(BDBuildingPK,AccessLevelID, Identity.Token);
		}

		public static ACAccessLevel GetByUK(System.Guid BDBuildingPK,System.Int16 AccessLevelID, SecurityToken token)
		{

			W3000.Data.ACAccessLevelData _result_ = ACAccessLevelWrapper.GetByUK(BDBuildingPK,AccessLevelID, token);
			if(_result_ == null)
				return null;

			return new ACAccessLevel(_result_);
		}

		public static ACAccessLevel GetByPK(System.Guid ACAccessLevelPK)
		{
			return GetByPK(ACAccessLevelPK, Identity.Token);
		}

		public static ACAccessLevel GetByPK(System.Guid ACAccessLevelPK, SecurityToken token)
		{

			W3000.Data.ACAccessLevelData _result_ = ACAccessLevelWrapper.GetByPK(ACAccessLevelPK, token);
			if(_result_ == null)
				return null;

			return new ACAccessLevel(_result_);
		}

		public static ACAccessLevelCollection GetAll()
		{
			return GetAll( Identity.Token);
		}

		public static ACAccessLevelCollection GetAll(SecurityToken token)
		{

			W3000.Data.ACAccessLevelDataCollection _result_ = ACAccessLevelWrapper.GetAll( token);
			if(_result_ == null)
				return null;

			return new ACAccessLevelCollection(_result_);
		}

		public static W3000.Data.ACAccessLevelViewCollection GetViewAll()
		{
			return GetViewAll( Identity.Token);
		}

		public static W3000.Data.ACAccessLevelViewCollection GetViewAll(SecurityToken token)
		{

			W3000.Data.ACAccessLevelViewCollection _result_ = ACAccessLevelWrapper.GetViewAll( token);
			if(_result_ == null)
				return null;

			return _result_;
		}

		public static ACAccessLevelCollection GetByBDBuilding(System.Guid BDBuildingPK)
		{
			return GetByBDBuilding(BDBuildingPK, Identity.Token);
		}

		public static ACAccessLevelCollection GetByBDBuilding(System.Guid BDBuildingPK, SecurityToken token)
		{

			W3000.Data.ACAccessLevelDataCollection _result_ = ACAccessLevelWrapper.GetByBDBuilding(BDBuildingPK, token);
			if(_result_ == null)
				return null;

			return new ACAccessLevelCollection(_result_);
		}

		public static W3000.Data.ACAccessLevelViewCollection GetViewByBDBuilding(System.Guid BDBuildingPK)
		{
			return GetViewByBDBuilding(BDBuildingPK, Identity.Token);
		}

		public static W3000.Data.ACAccessLevelViewCollection GetViewByBDBuilding(System.Guid BDBuildingPK, SecurityToken token)
		{

			W3000.Data.ACAccessLevelViewCollection _result_ = ACAccessLevelWrapper.GetViewByBDBuilding(BDBuildingPK, token);
			if(_result_ == null)
				return null;

			return _result_;
		}

	}

	public partial class ACAccessLevelDetail
	{
		public static Cheke.BusinessEntity.Result Purge(W3000.Data.ACAccessLevelDetailData entity)
		{
			return Purge(entity, Identity.Token);
		}

		public static Cheke.BusinessEntity.Result Purge(W3000.Data.ACAccessLevelDetailData entity, SecurityToken token)
		{
			if(entity != null)
			{
				entity = new W3000.Data.ACAccessLevelDetailData(entity);
			}

			Cheke.BusinessEntity.Result _result_ = ACAccessLevelDetailWrapper.Purge(entity, token);
			if(_result_ == null)
				return null;

			return _result_;
		}

		public static Cheke.BusinessEntity.Result Save(W3000.Data.ACAccessLevelDetailData entity)
		{
			return Save(entity, Identity.Token);
		}

		public static Cheke.BusinessEntity.Result Save(W3000.Data.ACAccessLevelDetailData entity, SecurityToken token)
		{
			if(entity != null)
			{
				entity = new W3000.Data.ACAccessLevelDetailData(entity);
			}

			Cheke.BusinessEntity.Result _result_ = ACAccessLevelDetailWrapper.Save(entity, token);
			if(_result_ == null)
				return null;

			return _result_;
		}

		public static Cheke.BusinessEntity.Result Save(W3000.Data.ACAccessLevelDetailDataCollection list)
		{
			return Save(list, Identity.Token);
		}

		public static Cheke.BusinessEntity.Result Save(W3000.Data.ACAccessLevelDetailDataCollection list, SecurityToken token)
		{
			if(list != null)
			{
				list = new W3000.Data.ACAccessLevelDetailDataCollection(list);
			}

			Cheke.BusinessEntity.Result _result_ = ACAccessLevelDetailWrapper.Save(list, token);
			if(_result_ == null)
				return null;

			return _result_;
		}

		public static ACAccessLevelDetailCollection GetByModifiedOn(System.DateTime begin,System.DateTime end)
		{
			return GetByModifiedOn(begin,end, Identity.Token);
		}

		public static ACAccessLevelDetailCollection GetByModifiedOn(System.DateTime begin,System.DateTime end, SecurityToken token)
		{

			W3000.Data.ACAccessLevelDetailDataCollection _result_ = ACAccessLevelDetailWrapper.GetByModifiedOn(begin,end, token);
			if(_result_ == null)
				return null;

			return new ACAccessLevelDetailCollection(_result_);
		}

		public static System.Int32 GetAllCount()
		{
			return GetAllCount( Identity.Token);
		}

		public static System.Int32 GetAllCount(SecurityToken token)
		{

			System.Int32 _result_ = ACAccessLevelDetailWrapper.GetAllCount( token);
			return _result_;
		}

		public static ACAccessLevelDetailCollection GetAllPage(System.Int32 pageIndex,System.Int32 pageSize)
		{
			return GetAllPage(pageIndex,pageSize, Identity.Token);
		}

		public static ACAccessLevelDetailCollection GetAllPage(System.Int32 pageIndex,System.Int32 pageSize, SecurityToken token)
		{

			W3000.Data.ACAccessLevelDetailDataCollection _result_ = ACAccessLevelDetailWrapper.GetAllPage(pageIndex,pageSize, token);
			if(_result_ == null)
				return null;

			return new ACAccessLevelDetailCollection(_result_);
		}

		public static ACAccessLevelDetail GetByUK(System.Guid ACAccessLevelPK,System.Guid ACMainZonePK)
		{
			return GetByUK(ACAccessLevelPK,ACMainZonePK, Identity.Token);
		}

		public static ACAccessLevelDetail GetByUK(System.Guid ACAccessLevelPK,System.Guid ACMainZonePK, SecurityToken token)
		{

			W3000.Data.ACAccessLevelDetailData _result_ = ACAccessLevelDetailWrapper.GetByUK(ACAccessLevelPK,ACMainZonePK, token);
			if(_result_ == null)
				return null;

			return new ACAccessLevelDetail(_result_);
		}

		public static ACAccessLevelDetail GetByPK(System.Guid ACAccessLevelDetailPK)
		{
			return GetByPK(ACAccessLevelDetailPK, Identity.Token);
		}

		public static ACAccessLevelDetail GetByPK(System.Guid ACAccessLevelDetailPK, SecurityToken token)
		{

			W3000.Data.ACAccessLevelDetailData _result_ = ACAccessLevelDetailWrapper.GetByPK(ACAccessLevelDetailPK, token);
			if(_result_ == null)
				return null;

			return new ACAccessLevelDetail(_result_);
		}

		public static ACAccessLevelDetailCollection GetAll()
		{
			return GetAll( Identity.Token);
		}

		public static ACAccessLevelDetailCollection GetAll(SecurityToken token)
		{

			W3000.Data.ACAccessLevelDetailDataCollection _result_ = ACAccessLevelDetailWrapper.GetAll( token);
			if(_result_ == null)
				return null;

			return new ACAccessLevelDetailCollection(_result_);
		}

		public static W3000.Data.ACAccessLevelDetailViewCollection GetViewAll()
		{
			return GetViewAll( Identity.Token);
		}

		public static W3000.Data.ACAccessLevelDetailViewCollection GetViewAll(SecurityToken token)
		{

			W3000.Data.ACAccessLevelDetailViewCollection _result_ = ACAccessLevelDetailWrapper.GetViewAll( token);
			if(_result_ == null)
				return null;

			return _result_;
		}

		public static ACAccessLevelDetailCollection GetByACMainZone(System.Guid ACMainZonePK)
		{
			return GetByACMainZone(ACMainZonePK, Identity.Token);
		}

		public static ACAccessLevelDetailCollection GetByACMainZone(System.Guid ACMainZonePK, SecurityToken token)
		{

			W3000.Data.ACAccessLevelDetailDataCollection _result_ = ACAccessLevelDetailWrapper.GetByACMainZone(ACMainZonePK, token);
			if(_result_ == null)
				return null;

			return new ACAccessLevelDetailCollection(_result_);
		}

		public static W3000.Data.ACAccessLevelDetailViewCollection GetViewByACMainZone(System.Guid ACMainZonePK)
		{
			return GetViewByACMainZone(ACMainZonePK, Identity.Token);
		}

		public static W3000.Data.ACAccessLevelDetailViewCollection GetViewByACMainZone(System.Guid ACMainZonePK, SecurityToken token)
		{

			W3000.Data.ACAccessLevelDetailViewCollection _result_ = ACAccessLevelDetailWrapper.GetViewByACMainZone(ACMainZonePK, token);
			if(_result_ == null)
				return null;

			return _result_;
		}

		public static ACAccessLevelDetailCollection GetByACTimecode(System.Guid ACTimecodePK)
		{
			return GetByACTimecode(ACTimecodePK, Identity.Token);
		}

		public static ACAccessLevelDetailCollection GetByACTimecode(System.Guid ACTimecodePK, SecurityToken token)
		{

			W3000.Data.ACAccessLevelDetailDataCollection _result_ = ACAccessLevelDetailWrapper.GetByACTimecode(ACTimecodePK, token);
			if(_result_ == null)
				return null;

			return new ACAccessLevelDetailCollection(_result_);
		}

		public static W3000.Data.ACAccessLevelDetailViewCollection GetViewByACTimecode(System.Guid ACTimecodePK)
		{
			return GetViewByACTimecode(ACTimecodePK, Identity.Token);
		}

		public static W3000.Data.ACAccessLevelDetailViewCollection GetViewByACTimecode(System.Guid ACTimecodePK, SecurityToken token)
		{

			W3000.Data.ACAccessLevelDetailViewCollection _result_ = ACAccessLevelDetailWrapper.GetViewByACTimecode(ACTimecodePK, token);
			if(_result_ == null)
				return null;

			return _result_;
		}

		public static ACAccessLevelDetailCollection GetByACAccessLevel(System.Guid ACAccessLevelPK)
		{
			return GetByACAccessLevel(ACAccessLevelPK, Identity.Token);
		}

		public static ACAccessLevelDetailCollection GetByACAccessLevel(System.Guid ACAccessLevelPK, SecurityToken token)
		{

			W3000.Data.ACAccessLevelDetailDataCollection _result_ = ACAccessLevelDetailWrapper.GetByACAccessLevel(ACAccessLevelPK, token);
			if(_result_ == null)
				return null;

			return new ACAccessLevelDetailCollection(_result_);
		}

		public static W3000.Data.ACAccessLevelDetailViewCollection GetViewByACAccessLevel(System.Guid ACAccessLevelPK)
		{
			return GetViewByACAccessLevel(ACAccessLevelPK, Identity.Token);
		}

		public static W3000.Data.ACAccessLevelDetailViewCollection GetViewByACAccessLevel(System.Guid ACAccessLevelPK, SecurityToken token)
		{

			W3000.Data.ACAccessLevelDetailViewCollection _result_ = ACAccessLevelDetailWrapper.GetViewByACAccessLevel(ACAccessLevelPK, token);
			if(_result_ == null)
				return null;

			return _result_;
		}

	}

	public partial class ACAMFormat
	{
		public static Cheke.BusinessEntity.Result Purge(W3000.Data.ACAMFormatData entity)
		{
			return Purge(entity, Identity.Token);
		}

		public static Cheke.BusinessEntity.Result Purge(W3000.Data.ACAMFormatData entity, SecurityToken token)
		{
			if(entity != null)
			{
				entity = new W3000.Data.ACAMFormatData(entity);
			}

			Cheke.BusinessEntity.Result _result_ = ACAMFormatWrapper.Purge(entity, token);
			if(_result_ == null)
				return null;

			return _result_;
		}

		public static Cheke.BusinessEntity.Result Save(W3000.Data.ACAMFormatData entity)
		{
			return Save(entity, Identity.Token);
		}

		public static Cheke.BusinessEntity.Result Save(W3000.Data.ACAMFormatData entity, SecurityToken token)
		{
			if(entity != null)
			{
				entity = new W3000.Data.ACAMFormatData(entity);
			}

			Cheke.BusinessEntity.Result _result_ = ACAMFormatWrapper.Save(entity, token);
			if(_result_ == null)
				return null;

			return _result_;
		}

		public static Cheke.BusinessEntity.Result Save(W3000.Data.ACAMFormatDataCollection list)
		{
			return Save(list, Identity.Token);
		}

		public static Cheke.BusinessEntity.Result Save(W3000.Data.ACAMFormatDataCollection list, SecurityToken token)
		{
			if(list != null)
			{
				list = new W3000.Data.ACAMFormatDataCollection(list);
			}

			Cheke.BusinessEntity.Result _result_ = ACAMFormatWrapper.Save(list, token);
			if(_result_ == null)
				return null;

			return _result_;
		}

		public static ACAMFormatCollection GetByModifiedOn(System.DateTime begin,System.DateTime end)
		{
			return GetByModifiedOn(begin,end, Identity.Token);
		}

		public static ACAMFormatCollection GetByModifiedOn(System.DateTime begin,System.DateTime end, SecurityToken token)
		{

			W3000.Data.ACAMFormatDataCollection _result_ = ACAMFormatWrapper.GetByModifiedOn(begin,end, token);
			if(_result_ == null)
				return null;

			return new ACAMFormatCollection(_result_);
		}

		public static System.Int32 GetAllCount()
		{
			return GetAllCount( Identity.Token);
		}

		public static System.Int32 GetAllCount(SecurityToken token)
		{

			System.Int32 _result_ = ACAMFormatWrapper.GetAllCount( token);
			return _result_;
		}

		public static ACAMFormatCollection GetAllPage(System.Int32 pageIndex,System.Int32 pageSize)
		{
			return GetAllPage(pageIndex,pageSize, Identity.Token);
		}

		public static ACAMFormatCollection GetAllPage(System.Int32 pageIndex,System.Int32 pageSize, SecurityToken token)
		{

			W3000.Data.ACAMFormatDataCollection _result_ = ACAMFormatWrapper.GetAllPage(pageIndex,pageSize, token);
			if(_result_ == null)
				return null;

			return new ACAMFormatCollection(_result_);
		}

		public static ACAMFormat GetByUK(System.Guid BDBuildingPK,System.Int16 AMFID)
		{
			return GetByUK(BDBuildingPK,AMFID, Identity.Token);
		}

		public static ACAMFormat GetByUK(System.Guid BDBuildingPK,System.Int16 AMFID, SecurityToken token)
		{

			W3000.Data.ACAMFormatData _result_ = ACAMFormatWrapper.GetByUK(BDBuildingPK,AMFID, token);
			if(_result_ == null)
				return null;

			return new ACAMFormat(_result_);
		}

		public static ACAMFormat GetByPK(System.Guid ACAMFormatPK)
		{
			return GetByPK(ACAMFormatPK, Identity.Token);
		}

		public static ACAMFormat GetByPK(System.Guid ACAMFormatPK, SecurityToken token)
		{

			W3000.Data.ACAMFormatData _result_ = ACAMFormatWrapper.GetByPK(ACAMFormatPK, token);
			if(_result_ == null)
				return null;

			return new ACAMFormat(_result_);
		}

		public static ACAMFormatCollection GetAll()
		{
			return GetAll( Identity.Token);
		}

		public static ACAMFormatCollection GetAll(SecurityToken token)
		{

			W3000.Data.ACAMFormatDataCollection _result_ = ACAMFormatWrapper.GetAll( token);
			if(_result_ == null)
				return null;

			return new ACAMFormatCollection(_result_);
		}

		public static W3000.Data.ACAMFormatViewCollection GetViewAll()
		{
			return GetViewAll( Identity.Token);
		}

		public static W3000.Data.ACAMFormatViewCollection GetViewAll(SecurityToken token)
		{

			W3000.Data.ACAMFormatViewCollection _result_ = ACAMFormatWrapper.GetViewAll( token);
			if(_result_ == null)
				return null;

			return _result_;
		}

		public static ACAMFormatCollection GetByBDBuilding(System.Guid BDBuildingPK)
		{
			return GetByBDBuilding(BDBuildingPK, Identity.Token);
		}

		public static ACAMFormatCollection GetByBDBuilding(System.Guid BDBuildingPK, SecurityToken token)
		{

			W3000.Data.ACAMFormatDataCollection _result_ = ACAMFormatWrapper.GetByBDBuilding(BDBuildingPK, token);
			if(_result_ == null)
				return null;

			return new ACAMFormatCollection(_result_);
		}

		public static W3000.Data.ACAMFormatViewCollection GetViewByBDBuilding(System.Guid BDBuildingPK)
		{
			return GetViewByBDBuilding(BDBuildingPK, Identity.Token);
		}

		public static W3000.Data.ACAMFormatViewCollection GetViewByBDBuilding(System.Guid BDBuildingPK, SecurityToken token)
		{

			W3000.Data.ACAMFormatViewCollection _result_ = ACAMFormatWrapper.GetViewByBDBuilding(BDBuildingPK, token);
			if(_result_ == null)
				return null;

			return _result_;
		}

	}

	public partial class ACCardHolderBuildingMap
	{
		public static Cheke.BusinessEntity.Result Purge(W3000.Data.ACCardHolderBuildingMapData entity)
		{
			return Purge(entity, Identity.Token);
		}

		public static Cheke.BusinessEntity.Result Purge(W3000.Data.ACCardHolderBuildingMapData entity, SecurityToken token)
		{
			if(entity != null)
			{
				entity = new W3000.Data.ACCardHolderBuildingMapData(entity);
			}

			Cheke.BusinessEntity.Result _result_ = ACCardHolderBuildingMapWrapper.Purge(entity, token);
			if(_result_ == null)
				return null;

			return _result_;
		}

		public static Cheke.BusinessEntity.Result Save(W3000.Data.ACCardHolderBuildingMapData entity)
		{
			return Save(entity, Identity.Token);
		}

		public static Cheke.BusinessEntity.Result Save(W3000.Data.ACCardHolderBuildingMapData entity, SecurityToken token)
		{
			if(entity != null)
			{
				entity = new W3000.Data.ACCardHolderBuildingMapData(entity);
			}

			Cheke.BusinessEntity.Result _result_ = ACCardHolderBuildingMapWrapper.Save(entity, token);
			if(_result_ == null)
				return null;

			return _result_;
		}

		public static Cheke.BusinessEntity.Result Save(W3000.Data.ACCardHolderBuildingMapDataCollection list)
		{
			return Save(list, Identity.Token);
		}

		public static Cheke.BusinessEntity.Result Save(W3000.Data.ACCardHolderBuildingMapDataCollection list, SecurityToken token)
		{
			if(list != null)
			{
				list = new W3000.Data.ACCardHolderBuildingMapDataCollection(list);
			}

			Cheke.BusinessEntity.Result _result_ = ACCardHolderBuildingMapWrapper.Save(list, token);
			if(_result_ == null)
				return null;

			return _result_;
		}

		public static ACCardHolderBuildingMapCollection GetByModifiedOn(System.DateTime begin,System.DateTime end)
		{
			return GetByModifiedOn(begin,end, Identity.Token);
		}

		public static ACCardHolderBuildingMapCollection GetByModifiedOn(System.DateTime begin,System.DateTime end, SecurityToken token)
		{

			W3000.Data.ACCardHolderBuildingMapDataCollection _result_ = ACCardHolderBuildingMapWrapper.GetByModifiedOn(begin,end, token);
			if(_result_ == null)
				return null;

			return new ACCardHolderBuildingMapCollection(_result_);
		}

		public static System.Int32 GetAllCount()
		{
			return GetAllCount( Identity.Token);
		}

		public static System.Int32 GetAllCount(SecurityToken token)
		{

			System.Int32 _result_ = ACCardHolderBuildingMapWrapper.GetAllCount( token);
			return _result_;
		}

		public static ACCardHolderBuildingMapCollection GetAllPage(System.Int32 pageIndex,System.Int32 pageSize)
		{
			return GetAllPage(pageIndex,pageSize, Identity.Token);
		}

		public static ACCardHolderBuildingMapCollection GetAllPage(System.Int32 pageIndex,System.Int32 pageSize, SecurityToken token)
		{

			W3000.Data.ACCardHolderBuildingMapDataCollection _result_ = ACCardHolderBuildingMapWrapper.GetAllPage(pageIndex,pageSize, token);
			if(_result_ == null)
				return null;

			return new ACCardHolderBuildingMapCollection(_result_);
		}

		public static ACCardHolderBuildingMap GetByUK(System.Guid ACCardHolderPK,System.Guid BDBuildingPK)
		{
			return GetByUK(ACCardHolderPK,BDBuildingPK, Identity.Token);
		}

		public static ACCardHolderBuildingMap GetByUK(System.Guid ACCardHolderPK,System.Guid BDBuildingPK, SecurityToken token)
		{

			W3000.Data.ACCardHolderBuildingMapData _result_ = ACCardHolderBuildingMapWrapper.GetByUK(ACCardHolderPK,BDBuildingPK, token);
			if(_result_ == null)
				return null;

			return new ACCardHolderBuildingMap(_result_);
		}

		public static ACCardHolderBuildingMap GetByPK(System.Guid ACCardHolderBuildingMapPK)
		{
			return GetByPK(ACCardHolderBuildingMapPK, Identity.Token);
		}

		public static ACCardHolderBuildingMap GetByPK(System.Guid ACCardHolderBuildingMapPK, SecurityToken token)
		{

			W3000.Data.ACCardHolderBuildingMapData _result_ = ACCardHolderBuildingMapWrapper.GetByPK(ACCardHolderBuildingMapPK, token);
			if(_result_ == null)
				return null;

			return new ACCardHolderBuildingMap(_result_);
		}

		public static ACCardHolderBuildingMapCollection GetAll()
		{
			return GetAll( Identity.Token);
		}

		public static ACCardHolderBuildingMapCollection GetAll(SecurityToken token)
		{

			W3000.Data.ACCardHolderBuildingMapDataCollection _result_ = ACCardHolderBuildingMapWrapper.GetAll( token);
			if(_result_ == null)
				return null;

			return new ACCardHolderBuildingMapCollection(_result_);
		}

		public static W3000.Data.ACCardHolderBuildingMapViewCollection GetViewAll()
		{
			return GetViewAll( Identity.Token);
		}

		public static W3000.Data.ACCardHolderBuildingMapViewCollection GetViewAll(SecurityToken token)
		{

			W3000.Data.ACCardHolderBuildingMapViewCollection _result_ = ACCardHolderBuildingMapWrapper.GetViewAll( token);
			if(_result_ == null)
				return null;

			return _result_;
		}

		public static ACCardHolderBuildingMapCollection GetByBDBuilding(System.Guid BDBuildingPK)
		{
			return GetByBDBuilding(BDBuildingPK, Identity.Token);
		}

		public static ACCardHolderBuildingMapCollection GetByBDBuilding(System.Guid BDBuildingPK, SecurityToken token)
		{

			W3000.Data.ACCardHolderBuildingMapDataCollection _result_ = ACCardHolderBuildingMapWrapper.GetByBDBuilding(BDBuildingPK, token);
			if(_result_ == null)
				return null;

			return new ACCardHolderBuildingMapCollection(_result_);
		}

		public static W3000.Data.ACCardHolderBuildingMapViewCollection GetViewByBDBuilding(System.Guid BDBuildingPK)
		{
			return GetViewByBDBuilding(BDBuildingPK, Identity.Token);
		}

		public static W3000.Data.ACCardHolderBuildingMapViewCollection GetViewByBDBuilding(System.Guid BDBuildingPK, SecurityToken token)
		{

			W3000.Data.ACCardHolderBuildingMapViewCollection _result_ = ACCardHolderBuildingMapWrapper.GetViewByBDBuilding(BDBuildingPK, token);
			if(_result_ == null)
				return null;

			return _result_;
		}

		public static ACCardHolderBuildingMapCollection GetByACCardHolder(System.Guid ACCardHolderPK)
		{
			return GetByACCardHolder(ACCardHolderPK, Identity.Token);
		}

		public static ACCardHolderBuildingMapCollection GetByACCardHolder(System.Guid ACCardHolderPK, SecurityToken token)
		{

			W3000.Data.ACCardHolderBuildingMapDataCollection _result_ = ACCardHolderBuildingMapWrapper.GetByACCardHolder(ACCardHolderPK, token);
			if(_result_ == null)
				return null;

			return new ACCardHolderBuildingMapCollection(_result_);
		}

		public static W3000.Data.ACCardHolderBuildingMapViewCollection GetViewByACCardHolder(System.Guid ACCardHolderPK)
		{
			return GetViewByACCardHolder(ACCardHolderPK, Identity.Token);
		}

		public static W3000.Data.ACCardHolderBuildingMapViewCollection GetViewByACCardHolder(System.Guid ACCardHolderPK, SecurityToken token)
		{

			W3000.Data.ACCardHolderBuildingMapViewCollection _result_ = ACCardHolderBuildingMapWrapper.GetViewByACCardHolder(ACCardHolderPK, token);
			if(_result_ == null)
				return null;

			return _result_;
		}

	}

	public partial class ACCardHolder
	{
		public static Cheke.BusinessEntity.Result Purge(W3000.Data.ACCardHolderData entity)
		{
			return Purge(entity, Identity.Token);
		}

		public static Cheke.BusinessEntity.Result Purge(W3000.Data.ACCardHolderData entity, SecurityToken token)
		{
			if(entity != null)
			{
				entity = new W3000.Data.ACCardHolderData(entity);
			}

			Cheke.BusinessEntity.Result _result_ = ACCardHolderWrapper.Purge(entity, token);
			if(_result_ == null)
				return null;

			return _result_;
		}

		public static Cheke.BusinessEntity.Result Save(W3000.Data.ACCardHolderData entity)
		{
			return Save(entity, Identity.Token);
		}

		public static Cheke.BusinessEntity.Result Save(W3000.Data.ACCardHolderData entity, SecurityToken token)
		{
			if(entity != null)
			{
				entity = new W3000.Data.ACCardHolderData(entity);
			}

			Cheke.BusinessEntity.Result _result_ = ACCardHolderWrapper.Save(entity, token);
			if(_result_ == null)
				return null;

			return _result_;
		}

		public static Cheke.BusinessEntity.Result Save(W3000.Data.ACCardHolderDataCollection list)
		{
			return Save(list, Identity.Token);
		}

		public static Cheke.BusinessEntity.Result Save(W3000.Data.ACCardHolderDataCollection list, SecurityToken token)
		{
			if(list != null)
			{
				list = new W3000.Data.ACCardHolderDataCollection(list);
			}

			Cheke.BusinessEntity.Result _result_ = ACCardHolderWrapper.Save(list, token);
			if(_result_ == null)
				return null;

			return _result_;
		}

		public static ACCardHolderCollection GetByCriteria(W3000.Data.CriteriaACCardHolderView criteria)
		{
			return GetByCriteria(criteria, Identity.Token);
		}

		public static ACCardHolderCollection GetByCriteria(W3000.Data.CriteriaACCardHolderView criteria, SecurityToken token)
		{

			W3000.Data.ACCardHolderDataCollection _result_ = ACCardHolderWrapper.GetByCriteria(criteria, token);
			if(_result_ == null)
				return null;

			return new ACCardHolderCollection(_result_);
		}

		public static ACCardHolderCollection GetByCriteria(W3000.Data.CriteriaACCardHolderView criteria,System.Int32 pageIndex,System.Int32 pageSize)
		{
			return GetByCriteria(criteria,pageIndex,pageSize, Identity.Token);
		}

		public static ACCardHolderCollection GetByCriteria(W3000.Data.CriteriaACCardHolderView criteria,System.Int32 pageIndex,System.Int32 pageSize, SecurityToken token)
		{

			W3000.Data.ACCardHolderDataCollection _result_ = ACCardHolderWrapper.GetByCriteria(criteria,pageIndex,pageSize, token);
			if(_result_ == null)
				return null;

			return new ACCardHolderCollection(_result_);
		}

		public static System.Int32 GetCountByCriteria(W3000.Data.CriteriaACCardHolderView criteria)
		{
			return GetCountByCriteria(criteria, Identity.Token);
		}

		public static System.Int32 GetCountByCriteria(W3000.Data.CriteriaACCardHolderView criteria, SecurityToken token)
		{

			System.Int32 _result_ = ACCardHolderWrapper.GetCountByCriteria(criteria, token);
			return _result_;
		}

		public static ACCardHolderCollection GetByLikeFirstName(System.String FirstName)
		{
			return GetByLikeFirstName(FirstName, Identity.Token);
		}

		public static ACCardHolderCollection GetByLikeFirstName(System.String FirstName, SecurityToken token)
		{

			W3000.Data.ACCardHolderDataCollection _result_ = ACCardHolderWrapper.GetByLikeFirstName(FirstName, token);
			if(_result_ == null)
				return null;

			return new ACCardHolderCollection(_result_);
		}

		public static ACCardHolderCollection GetByLikeLastName(System.String LastName)
		{
			return GetByLikeLastName(LastName, Identity.Token);
		}

		public static ACCardHolderCollection GetByLikeLastName(System.String LastName, SecurityToken token)
		{

			W3000.Data.ACCardHolderDataCollection _result_ = ACCardHolderWrapper.GetByLikeLastName(LastName, token);
			if(_result_ == null)
				return null;

			return new ACCardHolderCollection(_result_);
		}

		public static ACCardHolderCollection GetByValidThru(System.DateTime begin,System.DateTime end)
		{
			return GetByValidThru(begin,end, Identity.Token);
		}

		public static ACCardHolderCollection GetByValidThru(System.DateTime begin,System.DateTime end, SecurityToken token)
		{

			W3000.Data.ACCardHolderDataCollection _result_ = ACCardHolderWrapper.GetByValidThru(begin,end, token);
			if(_result_ == null)
				return null;

			return new ACCardHolderCollection(_result_);
		}

		public static ACCardHolderCollection GetByModifiedOn(System.DateTime begin,System.DateTime end)
		{
			return GetByModifiedOn(begin,end, Identity.Token);
		}

		public static ACCardHolderCollection GetByModifiedOn(System.DateTime begin,System.DateTime end, SecurityToken token)
		{

			W3000.Data.ACCardHolderDataCollection _result_ = ACCardHolderWrapper.GetByModifiedOn(begin,end, token);
			if(_result_ == null)
				return null;

			return new ACCardHolderCollection(_result_);
		}

		public static ACCardHolderCollection GetByMappedBDBuilding(System.Guid BDBuildingPK)
		{
			return GetByMappedBDBuilding(BDBuildingPK, Identity.Token);
		}

		public static ACCardHolderCollection GetByMappedBDBuilding(System.Guid BDBuildingPK, SecurityToken token)
		{

			W3000.Data.ACCardHolderDataCollection _result_ = ACCardHolderWrapper.GetByMappedBDBuilding(BDBuildingPK, token);
			if(_result_ == null)
				return null;

			return new ACCardHolderCollection(_result_);
		}

		public static System.Int32 GetAllCount()
		{
			return GetAllCount( Identity.Token);
		}

		public static System.Int32 GetAllCount(SecurityToken token)
		{

			System.Int32 _result_ = ACCardHolderWrapper.GetAllCount( token);
			return _result_;
		}

		public static ACCardHolderCollection GetAllPage(System.Int32 pageIndex,System.Int32 pageSize)
		{
			return GetAllPage(pageIndex,pageSize, Identity.Token);
		}

		public static ACCardHolderCollection GetAllPage(System.Int32 pageIndex,System.Int32 pageSize, SecurityToken token)
		{

			W3000.Data.ACCardHolderDataCollection _result_ = ACCardHolderWrapper.GetAllPage(pageIndex,pageSize, token);
			if(_result_ == null)
				return null;

			return new ACCardHolderCollection(_result_);
		}

		public static ACCardHolder GetByUK(System.Int32 Sitecode,System.Int32 Embossed,System.Int32 CardTypeID)
		{
			return GetByUK(Sitecode,Embossed,CardTypeID, Identity.Token);
		}

		public static ACCardHolder GetByUK(System.Int32 Sitecode,System.Int32 Embossed,System.Int32 CardTypeID, SecurityToken token)
		{

			W3000.Data.ACCardHolderData _result_ = ACCardHolderWrapper.GetByUK(Sitecode,Embossed,CardTypeID, token);
			if(_result_ == null)
				return null;

			return new ACCardHolder(_result_);
		}

		public static ACCardHolder GetByUK1(System.Int32 Sitecode,System.Int32 Encoded,System.Int32 CardTypeID)
		{
			return GetByUK1(Sitecode,Encoded,CardTypeID, Identity.Token);
		}

		public static ACCardHolder GetByUK1(System.Int32 Sitecode,System.Int32 Encoded,System.Int32 CardTypeID, SecurityToken token)
		{

			W3000.Data.ACCardHolderData _result_ = ACCardHolderWrapper.GetByUK1(Sitecode,Encoded,CardTypeID, token);
			if(_result_ == null)
				return null;

			return new ACCardHolder(_result_);
		}

		public static ACCardHolder GetByPK(System.Guid ACCardHolderPK)
		{
			return GetByPK(ACCardHolderPK, Identity.Token);
		}

		public static ACCardHolder GetByPK(System.Guid ACCardHolderPK, SecurityToken token)
		{

			W3000.Data.ACCardHolderData _result_ = ACCardHolderWrapper.GetByPK(ACCardHolderPK, token);
			if(_result_ == null)
				return null;

			return new ACCardHolder(_result_);
		}

		public static ACCardHolderCollection GetAll()
		{
			return GetAll( Identity.Token);
		}

		public static ACCardHolderCollection GetAll(SecurityToken token)
		{

			W3000.Data.ACCardHolderDataCollection _result_ = ACCardHolderWrapper.GetAll( token);
			if(_result_ == null)
				return null;

			return new ACCardHolderCollection(_result_);
		}

		public static W3000.Data.ACCardHolderViewCollection GetViewAll()
		{
			return GetViewAll( Identity.Token);
		}

		public static W3000.Data.ACCardHolderViewCollection GetViewAll(SecurityToken token)
		{

			W3000.Data.ACCardHolderViewCollection _result_ = ACCardHolderWrapper.GetViewAll( token);
			if(_result_ == null)
				return null;

			return _result_;
		}

		public static ACCardHolderCollection GetByBDTenant(System.Guid BDTenantPK)
		{
			return GetByBDTenant(BDTenantPK, Identity.Token);
		}

		public static ACCardHolderCollection GetByBDTenant(System.Guid BDTenantPK, SecurityToken token)
		{

			W3000.Data.ACCardHolderDataCollection _result_ = ACCardHolderWrapper.GetByBDTenant(BDTenantPK, token);
			if(_result_ == null)
				return null;

			return new ACCardHolderCollection(_result_);
		}

		public static W3000.Data.ACCardHolderViewCollection GetViewByBDTenant(System.Guid BDTenantPK)
		{
			return GetViewByBDTenant(BDTenantPK, Identity.Token);
		}

		public static W3000.Data.ACCardHolderViewCollection GetViewByBDTenant(System.Guid BDTenantPK, SecurityToken token)
		{

			W3000.Data.ACCardHolderViewCollection _result_ = ACCardHolderWrapper.GetViewByBDTenant(BDTenantPK, token);
			if(_result_ == null)
				return null;

			return _result_;
		}

	}

	public partial class ACFunctionCard
	{
		public static Cheke.BusinessEntity.Result Purge(W3000.Data.ACFunctionCardData entity)
		{
			return Purge(entity, Identity.Token);
		}

		public static Cheke.BusinessEntity.Result Purge(W3000.Data.ACFunctionCardData entity, SecurityToken token)
		{
			if(entity != null)
			{
				entity = new W3000.Data.ACFunctionCardData(entity);
			}

			Cheke.BusinessEntity.Result _result_ = ACFunctionCardWrapper.Purge(entity, token);
			if(_result_ == null)
				return null;

			return _result_;
		}

		public static Cheke.BusinessEntity.Result Save(W3000.Data.ACFunctionCardData entity)
		{
			return Save(entity, Identity.Token);
		}

		public static Cheke.BusinessEntity.Result Save(W3000.Data.ACFunctionCardData entity, SecurityToken token)
		{
			if(entity != null)
			{
				entity = new W3000.Data.ACFunctionCardData(entity);
			}

			Cheke.BusinessEntity.Result _result_ = ACFunctionCardWrapper.Save(entity, token);
			if(_result_ == null)
				return null;

			return _result_;
		}

		public static Cheke.BusinessEntity.Result Save(W3000.Data.ACFunctionCardDataCollection list)
		{
			return Save(list, Identity.Token);
		}

		public static Cheke.BusinessEntity.Result Save(W3000.Data.ACFunctionCardDataCollection list, SecurityToken token)
		{
			if(list != null)
			{
				list = new W3000.Data.ACFunctionCardDataCollection(list);
			}

			Cheke.BusinessEntity.Result _result_ = ACFunctionCardWrapper.Save(list, token);
			if(_result_ == null)
				return null;

			return _result_;
		}

		public static ACFunctionCardCollection GetByLikeFirstName(System.String FirstName)
		{
			return GetByLikeFirstName(FirstName, Identity.Token);
		}

		public static ACFunctionCardCollection GetByLikeFirstName(System.String FirstName, SecurityToken token)
		{

			W3000.Data.ACFunctionCardDataCollection _result_ = ACFunctionCardWrapper.GetByLikeFirstName(FirstName, token);
			if(_result_ == null)
				return null;

			return new ACFunctionCardCollection(_result_);
		}

		public static ACFunctionCardCollection GetByLikeLastName(System.String LastName)
		{
			return GetByLikeLastName(LastName, Identity.Token);
		}

		public static ACFunctionCardCollection GetByLikeLastName(System.String LastName, SecurityToken token)
		{

			W3000.Data.ACFunctionCardDataCollection _result_ = ACFunctionCardWrapper.GetByLikeLastName(LastName, token);
			if(_result_ == null)
				return null;

			return new ACFunctionCardCollection(_result_);
		}

		public static ACFunctionCardCollection GetByCardTypeID(System.Int32 CardTypeID)
		{
			return GetByCardTypeID(CardTypeID, Identity.Token);
		}

		public static ACFunctionCardCollection GetByCardTypeID(System.Int32 CardTypeID, SecurityToken token)
		{

			W3000.Data.ACFunctionCardDataCollection _result_ = ACFunctionCardWrapper.GetByCardTypeID(CardTypeID, token);
			if(_result_ == null)
				return null;

			return new ACFunctionCardCollection(_result_);
		}

		public static ACFunctionCardCollection GetByModifiedOn(System.DateTime begin,System.DateTime end)
		{
			return GetByModifiedOn(begin,end, Identity.Token);
		}

		public static ACFunctionCardCollection GetByModifiedOn(System.DateTime begin,System.DateTime end, SecurityToken token)
		{

			W3000.Data.ACFunctionCardDataCollection _result_ = ACFunctionCardWrapper.GetByModifiedOn(begin,end, token);
			if(_result_ == null)
				return null;

			return new ACFunctionCardCollection(_result_);
		}

		public static ACFunctionCardCollection GetByMappedACPanel(System.Guid ACPanelPK)
		{
			return GetByMappedACPanel(ACPanelPK, Identity.Token);
		}

		public static ACFunctionCardCollection GetByMappedACPanel(System.Guid ACPanelPK, SecurityToken token)
		{

			W3000.Data.ACFunctionCardDataCollection _result_ = ACFunctionCardWrapper.GetByMappedACPanel(ACPanelPK, token);
			if(_result_ == null)
				return null;

			return new ACFunctionCardCollection(_result_);
		}

		public static System.Int32 GetAllCount()
		{
			return GetAllCount( Identity.Token);
		}

		public static System.Int32 GetAllCount(SecurityToken token)
		{

			System.Int32 _result_ = ACFunctionCardWrapper.GetAllCount( token);
			return _result_;
		}

		public static ACFunctionCardCollection GetAllPage(System.Int32 pageIndex,System.Int32 pageSize)
		{
			return GetAllPage(pageIndex,pageSize, Identity.Token);
		}

		public static ACFunctionCardCollection GetAllPage(System.Int32 pageIndex,System.Int32 pageSize, SecurityToken token)
		{

			W3000.Data.ACFunctionCardDataCollection _result_ = ACFunctionCardWrapper.GetAllPage(pageIndex,pageSize, token);
			if(_result_ == null)
				return null;

			return new ACFunctionCardCollection(_result_);
		}

		public static ACFunctionCard GetByUK(System.Int32 Sitecode,System.Int32 Embossed,System.Int32 CardTypeID)
		{
			return GetByUK(Sitecode,Embossed,CardTypeID, Identity.Token);
		}

		public static ACFunctionCard GetByUK(System.Int32 Sitecode,System.Int32 Embossed,System.Int32 CardTypeID, SecurityToken token)
		{

			W3000.Data.ACFunctionCardData _result_ = ACFunctionCardWrapper.GetByUK(Sitecode,Embossed,CardTypeID, token);
			if(_result_ == null)
				return null;

			return new ACFunctionCard(_result_);
		}

		public static ACFunctionCard GetByUK1(System.Int32 Sitecode,System.Int32 Encoded,System.Int32 CardTypeID)
		{
			return GetByUK1(Sitecode,Encoded,CardTypeID, Identity.Token);
		}

		public static ACFunctionCard GetByUK1(System.Int32 Sitecode,System.Int32 Encoded,System.Int32 CardTypeID, SecurityToken token)
		{

			W3000.Data.ACFunctionCardData _result_ = ACFunctionCardWrapper.GetByUK1(Sitecode,Encoded,CardTypeID, token);
			if(_result_ == null)
				return null;

			return new ACFunctionCard(_result_);
		}

		public static ACFunctionCard GetByPK(System.Guid ACFunctionCardPK)
		{
			return GetByPK(ACFunctionCardPK, Identity.Token);
		}

		public static ACFunctionCard GetByPK(System.Guid ACFunctionCardPK, SecurityToken token)
		{

			W3000.Data.ACFunctionCardData _result_ = ACFunctionCardWrapper.GetByPK(ACFunctionCardPK, token);
			if(_result_ == null)
				return null;

			return new ACFunctionCard(_result_);
		}

		public static ACFunctionCardCollection GetAll()
		{
			return GetAll( Identity.Token);
		}

		public static ACFunctionCardCollection GetAll(SecurityToken token)
		{

			W3000.Data.ACFunctionCardDataCollection _result_ = ACFunctionCardWrapper.GetAll( token);
			if(_result_ == null)
				return null;

			return new ACFunctionCardCollection(_result_);
		}

		public static W3000.Data.ACFunctionCardViewCollection GetViewAll()
		{
			return GetViewAll( Identity.Token);
		}

		public static W3000.Data.ACFunctionCardViewCollection GetViewAll(SecurityToken token)
		{

			W3000.Data.ACFunctionCardViewCollection _result_ = ACFunctionCardWrapper.GetViewAll( token);
			if(_result_ == null)
				return null;

			return _result_;
		}

		public static ACFunctionCardCollection GetByBDTenant(System.Guid BDTenantPK)
		{
			return GetByBDTenant(BDTenantPK, Identity.Token);
		}

		public static ACFunctionCardCollection GetByBDTenant(System.Guid BDTenantPK, SecurityToken token)
		{

			W3000.Data.ACFunctionCardDataCollection _result_ = ACFunctionCardWrapper.GetByBDTenant(BDTenantPK, token);
			if(_result_ == null)
				return null;

			return new ACFunctionCardCollection(_result_);
		}

		public static W3000.Data.ACFunctionCardViewCollection GetViewByBDTenant(System.Guid BDTenantPK)
		{
			return GetViewByBDTenant(BDTenantPK, Identity.Token);
		}

		public static W3000.Data.ACFunctionCardViewCollection GetViewByBDTenant(System.Guid BDTenantPK, SecurityToken token)
		{

			W3000.Data.ACFunctionCardViewCollection _result_ = ACFunctionCardWrapper.GetViewByBDTenant(BDTenantPK, token);
			if(_result_ == null)
				return null;

			return _result_;
		}

	}

	public partial class ACInput
	{
		public static Cheke.BusinessEntity.Result Purge(W3000.Data.ACInputData entity)
		{
			return Purge(entity, Identity.Token);
		}

		public static Cheke.BusinessEntity.Result Purge(W3000.Data.ACInputData entity, SecurityToken token)
		{
			if(entity != null)
			{
				entity = new W3000.Data.ACInputData(entity);
			}

			Cheke.BusinessEntity.Result _result_ = ACInputWrapper.Purge(entity, token);
			if(_result_ == null)
				return null;

			return _result_;
		}

		public static Cheke.BusinessEntity.Result Save(W3000.Data.ACInputData entity)
		{
			return Save(entity, Identity.Token);
		}

		public static Cheke.BusinessEntity.Result Save(W3000.Data.ACInputData entity, SecurityToken token)
		{
			if(entity != null)
			{
				entity = new W3000.Data.ACInputData(entity);
			}

			Cheke.BusinessEntity.Result _result_ = ACInputWrapper.Save(entity, token);
			if(_result_ == null)
				return null;

			return _result_;
		}

		public static Cheke.BusinessEntity.Result Save(W3000.Data.ACInputDataCollection list)
		{
			return Save(list, Identity.Token);
		}

		public static Cheke.BusinessEntity.Result Save(W3000.Data.ACInputDataCollection list, SecurityToken token)
		{
			if(list != null)
			{
				list = new W3000.Data.ACInputDataCollection(list);
			}

			Cheke.BusinessEntity.Result _result_ = ACInputWrapper.Save(list, token);
			if(_result_ == null)
				return null;

			return _result_;
		}

		public static ACInputCollection GetByModifiedOn(System.DateTime begin,System.DateTime end)
		{
			return GetByModifiedOn(begin,end, Identity.Token);
		}

		public static ACInputCollection GetByModifiedOn(System.DateTime begin,System.DateTime end, SecurityToken token)
		{

			W3000.Data.ACInputDataCollection _result_ = ACInputWrapper.GetByModifiedOn(begin,end, token);
			if(_result_ == null)
				return null;

			return new ACInputCollection(_result_);
		}

		public static ACInputCollection GetByMappedACInputGroup(System.Guid ACInputGroupPK)
		{
			return GetByMappedACInputGroup(ACInputGroupPK, Identity.Token);
		}

		public static ACInputCollection GetByMappedACInputGroup(System.Guid ACInputGroupPK, SecurityToken token)
		{

			W3000.Data.ACInputDataCollection _result_ = ACInputWrapper.GetByMappedACInputGroup(ACInputGroupPK, token);
			if(_result_ == null)
				return null;

			return new ACInputCollection(_result_);
		}

		public static System.Int32 GetAllCount()
		{
			return GetAllCount( Identity.Token);
		}

		public static System.Int32 GetAllCount(SecurityToken token)
		{

			System.Int32 _result_ = ACInputWrapper.GetAllCount( token);
			return _result_;
		}

		public static ACInputCollection GetAllPage(System.Int32 pageIndex,System.Int32 pageSize)
		{
			return GetAllPage(pageIndex,pageSize, Identity.Token);
		}

		public static ACInputCollection GetAllPage(System.Int32 pageIndex,System.Int32 pageSize, SecurityToken token)
		{

			W3000.Data.ACInputDataCollection _result_ = ACInputWrapper.GetAllPage(pageIndex,pageSize, token);
			if(_result_ == null)
				return null;

			return new ACInputCollection(_result_);
		}

		public static ACInput GetByUK(System.Guid ACPanelPK,System.Byte PanelZoneID)
		{
			return GetByUK(ACPanelPK,PanelZoneID, Identity.Token);
		}

		public static ACInput GetByUK(System.Guid ACPanelPK,System.Byte PanelZoneID, SecurityToken token)
		{

			W3000.Data.ACInputData _result_ = ACInputWrapper.GetByUK(ACPanelPK,PanelZoneID, token);
			if(_result_ == null)
				return null;

			return new ACInput(_result_);
		}

		public static ACInput GetByPK(System.Guid ACInputPK)
		{
			return GetByPK(ACInputPK, Identity.Token);
		}

		public static ACInput GetByPK(System.Guid ACInputPK, SecurityToken token)
		{

			W3000.Data.ACInputData _result_ = ACInputWrapper.GetByPK(ACInputPK, token);
			if(_result_ == null)
				return null;

			return new ACInput(_result_);
		}

		public static ACInputCollection GetAll()
		{
			return GetAll( Identity.Token);
		}

		public static ACInputCollection GetAll(SecurityToken token)
		{

			W3000.Data.ACInputDataCollection _result_ = ACInputWrapper.GetAll( token);
			if(_result_ == null)
				return null;

			return new ACInputCollection(_result_);
		}

		public static W3000.Data.ACInputViewCollection GetViewAll()
		{
			return GetViewAll( Identity.Token);
		}

		public static W3000.Data.ACInputViewCollection GetViewAll(SecurityToken token)
		{

			W3000.Data.ACInputViewCollection _result_ = ACInputWrapper.GetViewAll( token);
			if(_result_ == null)
				return null;

			return _result_;
		}

		public static ACInputCollection GetByACPanel(System.Guid ACPanelPK)
		{
			return GetByACPanel(ACPanelPK, Identity.Token);
		}

		public static ACInputCollection GetByACPanel(System.Guid ACPanelPK, SecurityToken token)
		{

			W3000.Data.ACInputDataCollection _result_ = ACInputWrapper.GetByACPanel(ACPanelPK, token);
			if(_result_ == null)
				return null;

			return new ACInputCollection(_result_);
		}

		public static W3000.Data.ACInputViewCollection GetViewByACPanel(System.Guid ACPanelPK)
		{
			return GetViewByACPanel(ACPanelPK, Identity.Token);
		}

		public static W3000.Data.ACInputViewCollection GetViewByACPanel(System.Guid ACPanelPK, SecurityToken token)
		{

			W3000.Data.ACInputViewCollection _result_ = ACInputWrapper.GetViewByACPanel(ACPanelPK, token);
			if(_result_ == null)
				return null;

			return _result_;
		}

	}

	public partial class ACInputGroup
	{
		public static Cheke.BusinessEntity.Result Purge(W3000.Data.ACInputGroupData entity)
		{
			return Purge(entity, Identity.Token);
		}

		public static Cheke.BusinessEntity.Result Purge(W3000.Data.ACInputGroupData entity, SecurityToken token)
		{
			if(entity != null)
			{
				entity = new W3000.Data.ACInputGroupData(entity);
			}

			Cheke.BusinessEntity.Result _result_ = ACInputGroupWrapper.Purge(entity, token);
			if(_result_ == null)
				return null;

			return _result_;
		}

		public static Cheke.BusinessEntity.Result Save(W3000.Data.ACInputGroupData entity)
		{
			return Save(entity, Identity.Token);
		}

		public static Cheke.BusinessEntity.Result Save(W3000.Data.ACInputGroupData entity, SecurityToken token)
		{
			if(entity != null)
			{
				entity = new W3000.Data.ACInputGroupData(entity);
			}

			Cheke.BusinessEntity.Result _result_ = ACInputGroupWrapper.Save(entity, token);
			if(_result_ == null)
				return null;

			return _result_;
		}

		public static Cheke.BusinessEntity.Result Save(W3000.Data.ACInputGroupDataCollection list)
		{
			return Save(list, Identity.Token);
		}

		public static Cheke.BusinessEntity.Result Save(W3000.Data.ACInputGroupDataCollection list, SecurityToken token)
		{
			if(list != null)
			{
				list = new W3000.Data.ACInputGroupDataCollection(list);
			}

			Cheke.BusinessEntity.Result _result_ = ACInputGroupWrapper.Save(list, token);
			if(_result_ == null)
				return null;

			return _result_;
		}

		public static ACInputGroupCollection GetByModifiedOn(System.DateTime begin,System.DateTime end)
		{
			return GetByModifiedOn(begin,end, Identity.Token);
		}

		public static ACInputGroupCollection GetByModifiedOn(System.DateTime begin,System.DateTime end, SecurityToken token)
		{

			W3000.Data.ACInputGroupDataCollection _result_ = ACInputGroupWrapper.GetByModifiedOn(begin,end, token);
			if(_result_ == null)
				return null;

			return new ACInputGroupCollection(_result_);
		}

		public static ACInputGroupCollection GetByMappedACInput(System.Guid ACInputPK)
		{
			return GetByMappedACInput(ACInputPK, Identity.Token);
		}

		public static ACInputGroupCollection GetByMappedACInput(System.Guid ACInputPK, SecurityToken token)
		{

			W3000.Data.ACInputGroupDataCollection _result_ = ACInputGroupWrapper.GetByMappedACInput(ACInputPK, token);
			if(_result_ == null)
				return null;

			return new ACInputGroupCollection(_result_);
		}

		public static System.Int32 GetAllCount()
		{
			return GetAllCount( Identity.Token);
		}

		public static System.Int32 GetAllCount(SecurityToken token)
		{

			System.Int32 _result_ = ACInputGroupWrapper.GetAllCount( token);
			return _result_;
		}

		public static ACInputGroupCollection GetAllPage(System.Int32 pageIndex,System.Int32 pageSize)
		{
			return GetAllPage(pageIndex,pageSize, Identity.Token);
		}

		public static ACInputGroupCollection GetAllPage(System.Int32 pageIndex,System.Int32 pageSize, SecurityToken token)
		{

			W3000.Data.ACInputGroupDataCollection _result_ = ACInputGroupWrapper.GetAllPage(pageIndex,pageSize, token);
			if(_result_ == null)
				return null;

			return new ACInputGroupCollection(_result_);
		}

		public static ACInputGroup GetByUK(System.Guid ACPanelPK,System.Byte GroupID)
		{
			return GetByUK(ACPanelPK,GroupID, Identity.Token);
		}

		public static ACInputGroup GetByUK(System.Guid ACPanelPK,System.Byte GroupID, SecurityToken token)
		{

			W3000.Data.ACInputGroupData _result_ = ACInputGroupWrapper.GetByUK(ACPanelPK,GroupID, token);
			if(_result_ == null)
				return null;

			return new ACInputGroup(_result_);
		}

		public static ACInputGroup GetByPK(System.Guid ACInputGroupPK)
		{
			return GetByPK(ACInputGroupPK, Identity.Token);
		}

		public static ACInputGroup GetByPK(System.Guid ACInputGroupPK, SecurityToken token)
		{

			W3000.Data.ACInputGroupData _result_ = ACInputGroupWrapper.GetByPK(ACInputGroupPK, token);
			if(_result_ == null)
				return null;

			return new ACInputGroup(_result_);
		}

		public static ACInputGroupCollection GetAll()
		{
			return GetAll( Identity.Token);
		}

		public static ACInputGroupCollection GetAll(SecurityToken token)
		{

			W3000.Data.ACInputGroupDataCollection _result_ = ACInputGroupWrapper.GetAll( token);
			if(_result_ == null)
				return null;

			return new ACInputGroupCollection(_result_);
		}

		public static W3000.Data.ACInputGroupViewCollection GetViewAll()
		{
			return GetViewAll( Identity.Token);
		}

		public static W3000.Data.ACInputGroupViewCollection GetViewAll(SecurityToken token)
		{

			W3000.Data.ACInputGroupViewCollection _result_ = ACInputGroupWrapper.GetViewAll( token);
			if(_result_ == null)
				return null;

			return _result_;
		}

		public static ACInputGroupCollection GetByACPanel(System.Guid ACPanelPK)
		{
			return GetByACPanel(ACPanelPK, Identity.Token);
		}

		public static ACInputGroupCollection GetByACPanel(System.Guid ACPanelPK, SecurityToken token)
		{

			W3000.Data.ACInputGroupDataCollection _result_ = ACInputGroupWrapper.GetByACPanel(ACPanelPK, token);
			if(_result_ == null)
				return null;

			return new ACInputGroupCollection(_result_);
		}

		public static W3000.Data.ACInputGroupViewCollection GetViewByACPanel(System.Guid ACPanelPK)
		{
			return GetViewByACPanel(ACPanelPK, Identity.Token);
		}

		public static W3000.Data.ACInputGroupViewCollection GetViewByACPanel(System.Guid ACPanelPK, SecurityToken token)
		{

			W3000.Data.ACInputGroupViewCollection _result_ = ACInputGroupWrapper.GetViewByACPanel(ACPanelPK, token);
			if(_result_ == null)
				return null;

			return _result_;
		}

	}

	public partial class ACInputGroupInputMap
	{
		public static Cheke.BusinessEntity.Result Purge(W3000.Data.ACInputGroupInputMapData entity)
		{
			return Purge(entity, Identity.Token);
		}

		public static Cheke.BusinessEntity.Result Purge(W3000.Data.ACInputGroupInputMapData entity, SecurityToken token)
		{
			if(entity != null)
			{
				entity = new W3000.Data.ACInputGroupInputMapData(entity);
			}

			Cheke.BusinessEntity.Result _result_ = ACInputGroupInputMapWrapper.Purge(entity, token);
			if(_result_ == null)
				return null;

			return _result_;
		}

		public static Cheke.BusinessEntity.Result Save(W3000.Data.ACInputGroupInputMapData entity)
		{
			return Save(entity, Identity.Token);
		}

		public static Cheke.BusinessEntity.Result Save(W3000.Data.ACInputGroupInputMapData entity, SecurityToken token)
		{
			if(entity != null)
			{
				entity = new W3000.Data.ACInputGroupInputMapData(entity);
			}

			Cheke.BusinessEntity.Result _result_ = ACInputGroupInputMapWrapper.Save(entity, token);
			if(_result_ == null)
				return null;

			return _result_;
		}

		public static Cheke.BusinessEntity.Result Save(W3000.Data.ACInputGroupInputMapDataCollection list)
		{
			return Save(list, Identity.Token);
		}

		public static Cheke.BusinessEntity.Result Save(W3000.Data.ACInputGroupInputMapDataCollection list, SecurityToken token)
		{
			if(list != null)
			{
				list = new W3000.Data.ACInputGroupInputMapDataCollection(list);
			}

			Cheke.BusinessEntity.Result _result_ = ACInputGroupInputMapWrapper.Save(list, token);
			if(_result_ == null)
				return null;

			return _result_;
		}

		public static ACInputGroupInputMapCollection GetByModifiedOn(System.DateTime begin,System.DateTime end)
		{
			return GetByModifiedOn(begin,end, Identity.Token);
		}

		public static ACInputGroupInputMapCollection GetByModifiedOn(System.DateTime begin,System.DateTime end, SecurityToken token)
		{

			W3000.Data.ACInputGroupInputMapDataCollection _result_ = ACInputGroupInputMapWrapper.GetByModifiedOn(begin,end, token);
			if(_result_ == null)
				return null;

			return new ACInputGroupInputMapCollection(_result_);
		}

		public static System.Int32 GetAllCount()
		{
			return GetAllCount( Identity.Token);
		}

		public static System.Int32 GetAllCount(SecurityToken token)
		{

			System.Int32 _result_ = ACInputGroupInputMapWrapper.GetAllCount( token);
			return _result_;
		}

		public static ACInputGroupInputMapCollection GetAllPage(System.Int32 pageIndex,System.Int32 pageSize)
		{
			return GetAllPage(pageIndex,pageSize, Identity.Token);
		}

		public static ACInputGroupInputMapCollection GetAllPage(System.Int32 pageIndex,System.Int32 pageSize, SecurityToken token)
		{

			W3000.Data.ACInputGroupInputMapDataCollection _result_ = ACInputGroupInputMapWrapper.GetAllPage(pageIndex,pageSize, token);
			if(_result_ == null)
				return null;

			return new ACInputGroupInputMapCollection(_result_);
		}

		public static ACInputGroupInputMap GetByUK(System.Guid ACInputGroupPK,System.Guid ACInputPK)
		{
			return GetByUK(ACInputGroupPK,ACInputPK, Identity.Token);
		}

		public static ACInputGroupInputMap GetByUK(System.Guid ACInputGroupPK,System.Guid ACInputPK, SecurityToken token)
		{

			W3000.Data.ACInputGroupInputMapData _result_ = ACInputGroupInputMapWrapper.GetByUK(ACInputGroupPK,ACInputPK, token);
			if(_result_ == null)
				return null;

			return new ACInputGroupInputMap(_result_);
		}

		public static ACInputGroupInputMap GetByPK(System.Guid ACInputGroupInputMapPK)
		{
			return GetByPK(ACInputGroupInputMapPK, Identity.Token);
		}

		public static ACInputGroupInputMap GetByPK(System.Guid ACInputGroupInputMapPK, SecurityToken token)
		{

			W3000.Data.ACInputGroupInputMapData _result_ = ACInputGroupInputMapWrapper.GetByPK(ACInputGroupInputMapPK, token);
			if(_result_ == null)
				return null;

			return new ACInputGroupInputMap(_result_);
		}

		public static ACInputGroupInputMapCollection GetAll()
		{
			return GetAll( Identity.Token);
		}

		public static ACInputGroupInputMapCollection GetAll(SecurityToken token)
		{

			W3000.Data.ACInputGroupInputMapDataCollection _result_ = ACInputGroupInputMapWrapper.GetAll( token);
			if(_result_ == null)
				return null;

			return new ACInputGroupInputMapCollection(_result_);
		}

		public static W3000.Data.ACInputGroupInputMapViewCollection GetViewAll()
		{
			return GetViewAll( Identity.Token);
		}

		public static W3000.Data.ACInputGroupInputMapViewCollection GetViewAll(SecurityToken token)
		{

			W3000.Data.ACInputGroupInputMapViewCollection _result_ = ACInputGroupInputMapWrapper.GetViewAll( token);
			if(_result_ == null)
				return null;

			return _result_;
		}

		public static ACInputGroupInputMapCollection GetByACInputGroup(System.Guid ACInputGroupPK)
		{
			return GetByACInputGroup(ACInputGroupPK, Identity.Token);
		}

		public static ACInputGroupInputMapCollection GetByACInputGroup(System.Guid ACInputGroupPK, SecurityToken token)
		{

			W3000.Data.ACInputGroupInputMapDataCollection _result_ = ACInputGroupInputMapWrapper.GetByACInputGroup(ACInputGroupPK, token);
			if(_result_ == null)
				return null;

			return new ACInputGroupInputMapCollection(_result_);
		}

		public static W3000.Data.ACInputGroupInputMapViewCollection GetViewByACInputGroup(System.Guid ACInputGroupPK)
		{
			return GetViewByACInputGroup(ACInputGroupPK, Identity.Token);
		}

		public static W3000.Data.ACInputGroupInputMapViewCollection GetViewByACInputGroup(System.Guid ACInputGroupPK, SecurityToken token)
		{

			W3000.Data.ACInputGroupInputMapViewCollection _result_ = ACInputGroupInputMapWrapper.GetViewByACInputGroup(ACInputGroupPK, token);
			if(_result_ == null)
				return null;

			return _result_;
		}

		public static ACInputGroupInputMapCollection GetByACInput(System.Guid ACInputPK)
		{
			return GetByACInput(ACInputPK, Identity.Token);
		}

		public static ACInputGroupInputMapCollection GetByACInput(System.Guid ACInputPK, SecurityToken token)
		{

			W3000.Data.ACInputGroupInputMapDataCollection _result_ = ACInputGroupInputMapWrapper.GetByACInput(ACInputPK, token);
			if(_result_ == null)
				return null;

			return new ACInputGroupInputMapCollection(_result_);
		}

		public static W3000.Data.ACInputGroupInputMapViewCollection GetViewByACInput(System.Guid ACInputPK)
		{
			return GetViewByACInput(ACInputPK, Identity.Token);
		}

		public static W3000.Data.ACInputGroupInputMapViewCollection GetViewByACInput(System.Guid ACInputPK, SecurityToken token)
		{

			W3000.Data.ACInputGroupInputMapViewCollection _result_ = ACInputGroupInputMapWrapper.GetViewByACInput(ACInputPK, token);
			if(_result_ == null)
				return null;

			return _result_;
		}

	}

	public partial class ACInterval
	{
		public static Cheke.BusinessEntity.Result Purge(W3000.Data.ACIntervalData entity)
		{
			return Purge(entity, Identity.Token);
		}

		public static Cheke.BusinessEntity.Result Purge(W3000.Data.ACIntervalData entity, SecurityToken token)
		{
			if(entity != null)
			{
				entity = new W3000.Data.ACIntervalData(entity);
			}

			Cheke.BusinessEntity.Result _result_ = ACIntervalWrapper.Purge(entity, token);
			if(_result_ == null)
				return null;

			return _result_;
		}

		public static Cheke.BusinessEntity.Result Save(W3000.Data.ACIntervalData entity)
		{
			return Save(entity, Identity.Token);
		}

		public static Cheke.BusinessEntity.Result Save(W3000.Data.ACIntervalData entity, SecurityToken token)
		{
			if(entity != null)
			{
				entity = new W3000.Data.ACIntervalData(entity);
			}

			Cheke.BusinessEntity.Result _result_ = ACIntervalWrapper.Save(entity, token);
			if(_result_ == null)
				return null;

			return _result_;
		}

		public static Cheke.BusinessEntity.Result Save(W3000.Data.ACIntervalDataCollection list)
		{
			return Save(list, Identity.Token);
		}

		public static Cheke.BusinessEntity.Result Save(W3000.Data.ACIntervalDataCollection list, SecurityToken token)
		{
			if(list != null)
			{
				list = new W3000.Data.ACIntervalDataCollection(list);
			}

			Cheke.BusinessEntity.Result _result_ = ACIntervalWrapper.Save(list, token);
			if(_result_ == null)
				return null;

			return _result_;
		}

		public static ACIntervalCollection GetByModifiedOn(System.DateTime begin,System.DateTime end)
		{
			return GetByModifiedOn(begin,end, Identity.Token);
		}

		public static ACIntervalCollection GetByModifiedOn(System.DateTime begin,System.DateTime end, SecurityToken token)
		{

			W3000.Data.ACIntervalDataCollection _result_ = ACIntervalWrapper.GetByModifiedOn(begin,end, token);
			if(_result_ == null)
				return null;

			return new ACIntervalCollection(_result_);
		}

		public static ACIntervalCollection GetByMappedUtilHoliday(System.Guid UtilHolidayPK)
		{
			return GetByMappedUtilHoliday(UtilHolidayPK, Identity.Token);
		}

		public static ACIntervalCollection GetByMappedUtilHoliday(System.Guid UtilHolidayPK, SecurityToken token)
		{

			W3000.Data.ACIntervalDataCollection _result_ = ACIntervalWrapper.GetByMappedUtilHoliday(UtilHolidayPK, token);
			if(_result_ == null)
				return null;

			return new ACIntervalCollection(_result_);
		}

		public static ACIntervalCollection GetByMappedACTimecode(System.Guid ACTimecodePK)
		{
			return GetByMappedACTimecode(ACTimecodePK, Identity.Token);
		}

		public static ACIntervalCollection GetByMappedACTimecode(System.Guid ACTimecodePK, SecurityToken token)
		{

			W3000.Data.ACIntervalDataCollection _result_ = ACIntervalWrapper.GetByMappedACTimecode(ACTimecodePK, token);
			if(_result_ == null)
				return null;

			return new ACIntervalCollection(_result_);
		}

		public static System.Int32 GetAllCount()
		{
			return GetAllCount( Identity.Token);
		}

		public static System.Int32 GetAllCount(SecurityToken token)
		{

			System.Int32 _result_ = ACIntervalWrapper.GetAllCount( token);
			return _result_;
		}

		public static ACIntervalCollection GetAllPage(System.Int32 pageIndex,System.Int32 pageSize)
		{
			return GetAllPage(pageIndex,pageSize, Identity.Token);
		}

		public static ACIntervalCollection GetAllPage(System.Int32 pageIndex,System.Int32 pageSize, SecurityToken token)
		{

			W3000.Data.ACIntervalDataCollection _result_ = ACIntervalWrapper.GetAllPage(pageIndex,pageSize, token);
			if(_result_ == null)
				return null;

			return new ACIntervalCollection(_result_);
		}

		public static ACInterval GetByUK(System.Guid BDBuildingPK,System.Int16 IVID)
		{
			return GetByUK(BDBuildingPK,IVID, Identity.Token);
		}

		public static ACInterval GetByUK(System.Guid BDBuildingPK,System.Int16 IVID, SecurityToken token)
		{

			W3000.Data.ACIntervalData _result_ = ACIntervalWrapper.GetByUK(BDBuildingPK,IVID, token);
			if(_result_ == null)
				return null;

			return new ACInterval(_result_);
		}

		public static ACInterval GetByPK(System.Guid ACIntervalPK)
		{
			return GetByPK(ACIntervalPK, Identity.Token);
		}

		public static ACInterval GetByPK(System.Guid ACIntervalPK, SecurityToken token)
		{

			W3000.Data.ACIntervalData _result_ = ACIntervalWrapper.GetByPK(ACIntervalPK, token);
			if(_result_ == null)
				return null;

			return new ACInterval(_result_);
		}

		public static ACIntervalCollection GetAll()
		{
			return GetAll( Identity.Token);
		}

		public static ACIntervalCollection GetAll(SecurityToken token)
		{

			W3000.Data.ACIntervalDataCollection _result_ = ACIntervalWrapper.GetAll( token);
			if(_result_ == null)
				return null;

			return new ACIntervalCollection(_result_);
		}

		public static W3000.Data.ACIntervalViewCollection GetViewAll()
		{
			return GetViewAll( Identity.Token);
		}

		public static W3000.Data.ACIntervalViewCollection GetViewAll(SecurityToken token)
		{

			W3000.Data.ACIntervalViewCollection _result_ = ACIntervalWrapper.GetViewAll( token);
			if(_result_ == null)
				return null;

			return _result_;
		}

		public static ACIntervalCollection GetByBDBuilding(System.Guid BDBuildingPK)
		{
			return GetByBDBuilding(BDBuildingPK, Identity.Token);
		}

		public static ACIntervalCollection GetByBDBuilding(System.Guid BDBuildingPK, SecurityToken token)
		{

			W3000.Data.ACIntervalDataCollection _result_ = ACIntervalWrapper.GetByBDBuilding(BDBuildingPK, token);
			if(_result_ == null)
				return null;

			return new ACIntervalCollection(_result_);
		}

		public static W3000.Data.ACIntervalViewCollection GetViewByBDBuilding(System.Guid BDBuildingPK)
		{
			return GetViewByBDBuilding(BDBuildingPK, Identity.Token);
		}

		public static W3000.Data.ACIntervalViewCollection GetViewByBDBuilding(System.Guid BDBuildingPK, SecurityToken token)
		{

			W3000.Data.ACIntervalViewCollection _result_ = ACIntervalWrapper.GetViewByBDBuilding(BDBuildingPK, token);
			if(_result_ == null)
				return null;

			return _result_;
		}

	}

	public partial class ACIntvalHolidayMap
	{
		public static Cheke.BusinessEntity.Result Purge(W3000.Data.ACIntvalHolidayMapData entity)
		{
			return Purge(entity, Identity.Token);
		}

		public static Cheke.BusinessEntity.Result Purge(W3000.Data.ACIntvalHolidayMapData entity, SecurityToken token)
		{
			if(entity != null)
			{
				entity = new W3000.Data.ACIntvalHolidayMapData(entity);
			}

			Cheke.BusinessEntity.Result _result_ = ACIntvalHolidayMapWrapper.Purge(entity, token);
			if(_result_ == null)
				return null;

			return _result_;
		}

		public static Cheke.BusinessEntity.Result Save(W3000.Data.ACIntvalHolidayMapData entity)
		{
			return Save(entity, Identity.Token);
		}

		public static Cheke.BusinessEntity.Result Save(W3000.Data.ACIntvalHolidayMapData entity, SecurityToken token)
		{
			if(entity != null)
			{
				entity = new W3000.Data.ACIntvalHolidayMapData(entity);
			}

			Cheke.BusinessEntity.Result _result_ = ACIntvalHolidayMapWrapper.Save(entity, token);
			if(_result_ == null)
				return null;

			return _result_;
		}

		public static Cheke.BusinessEntity.Result Save(W3000.Data.ACIntvalHolidayMapDataCollection list)
		{
			return Save(list, Identity.Token);
		}

		public static Cheke.BusinessEntity.Result Save(W3000.Data.ACIntvalHolidayMapDataCollection list, SecurityToken token)
		{
			if(list != null)
			{
				list = new W3000.Data.ACIntvalHolidayMapDataCollection(list);
			}

			Cheke.BusinessEntity.Result _result_ = ACIntvalHolidayMapWrapper.Save(list, token);
			if(_result_ == null)
				return null;

			return _result_;
		}

		public static ACIntvalHolidayMapCollection GetByModifiedOn(System.DateTime begin,System.DateTime end)
		{
			return GetByModifiedOn(begin,end, Identity.Token);
		}

		public static ACIntvalHolidayMapCollection GetByModifiedOn(System.DateTime begin,System.DateTime end, SecurityToken token)
		{

			W3000.Data.ACIntvalHolidayMapDataCollection _result_ = ACIntvalHolidayMapWrapper.GetByModifiedOn(begin,end, token);
			if(_result_ == null)
				return null;

			return new ACIntvalHolidayMapCollection(_result_);
		}

		public static System.Int32 GetAllCount()
		{
			return GetAllCount( Identity.Token);
		}

		public static System.Int32 GetAllCount(SecurityToken token)
		{

			System.Int32 _result_ = ACIntvalHolidayMapWrapper.GetAllCount( token);
			return _result_;
		}

		public static ACIntvalHolidayMapCollection GetAllPage(System.Int32 pageIndex,System.Int32 pageSize)
		{
			return GetAllPage(pageIndex,pageSize, Identity.Token);
		}

		public static ACIntvalHolidayMapCollection GetAllPage(System.Int32 pageIndex,System.Int32 pageSize, SecurityToken token)
		{

			W3000.Data.ACIntvalHolidayMapDataCollection _result_ = ACIntvalHolidayMapWrapper.GetAllPage(pageIndex,pageSize, token);
			if(_result_ == null)
				return null;

			return new ACIntvalHolidayMapCollection(_result_);
		}

		public static ACIntvalHolidayMap GetByUK(System.Guid ACIntervalPK,System.Guid UtilHolidayPK)
		{
			return GetByUK(ACIntervalPK,UtilHolidayPK, Identity.Token);
		}

		public static ACIntvalHolidayMap GetByUK(System.Guid ACIntervalPK,System.Guid UtilHolidayPK, SecurityToken token)
		{

			W3000.Data.ACIntvalHolidayMapData _result_ = ACIntvalHolidayMapWrapper.GetByUK(ACIntervalPK,UtilHolidayPK, token);
			if(_result_ == null)
				return null;

			return new ACIntvalHolidayMap(_result_);
		}

		public static ACIntvalHolidayMap GetByPK(System.Guid ACIntvalHolidayMapPK)
		{
			return GetByPK(ACIntvalHolidayMapPK, Identity.Token);
		}

		public static ACIntvalHolidayMap GetByPK(System.Guid ACIntvalHolidayMapPK, SecurityToken token)
		{

			W3000.Data.ACIntvalHolidayMapData _result_ = ACIntvalHolidayMapWrapper.GetByPK(ACIntvalHolidayMapPK, token);
			if(_result_ == null)
				return null;

			return new ACIntvalHolidayMap(_result_);
		}

		public static ACIntvalHolidayMapCollection GetAll()
		{
			return GetAll( Identity.Token);
		}

		public static ACIntvalHolidayMapCollection GetAll(SecurityToken token)
		{

			W3000.Data.ACIntvalHolidayMapDataCollection _result_ = ACIntvalHolidayMapWrapper.GetAll( token);
			if(_result_ == null)
				return null;

			return new ACIntvalHolidayMapCollection(_result_);
		}

		public static W3000.Data.ACIntvalHolidayMapViewCollection GetViewAll()
		{
			return GetViewAll( Identity.Token);
		}

		public static W3000.Data.ACIntvalHolidayMapViewCollection GetViewAll(SecurityToken token)
		{

			W3000.Data.ACIntvalHolidayMapViewCollection _result_ = ACIntvalHolidayMapWrapper.GetViewAll( token);
			if(_result_ == null)
				return null;

			return _result_;
		}

		public static ACIntvalHolidayMapCollection GetByACInterval(System.Guid ACIntervalPK)
		{
			return GetByACInterval(ACIntervalPK, Identity.Token);
		}

		public static ACIntvalHolidayMapCollection GetByACInterval(System.Guid ACIntervalPK, SecurityToken token)
		{

			W3000.Data.ACIntvalHolidayMapDataCollection _result_ = ACIntvalHolidayMapWrapper.GetByACInterval(ACIntervalPK, token);
			if(_result_ == null)
				return null;

			return new ACIntvalHolidayMapCollection(_result_);
		}

		public static W3000.Data.ACIntvalHolidayMapViewCollection GetViewByACInterval(System.Guid ACIntervalPK)
		{
			return GetViewByACInterval(ACIntervalPK, Identity.Token);
		}

		public static W3000.Data.ACIntvalHolidayMapViewCollection GetViewByACInterval(System.Guid ACIntervalPK, SecurityToken token)
		{

			W3000.Data.ACIntvalHolidayMapViewCollection _result_ = ACIntvalHolidayMapWrapper.GetViewByACInterval(ACIntervalPK, token);
			if(_result_ == null)
				return null;

			return _result_;
		}

		public static ACIntvalHolidayMapCollection GetByUtilHoliday(System.Guid UtilHolidayPK)
		{
			return GetByUtilHoliday(UtilHolidayPK, Identity.Token);
		}

		public static ACIntvalHolidayMapCollection GetByUtilHoliday(System.Guid UtilHolidayPK, SecurityToken token)
		{

			W3000.Data.ACIntvalHolidayMapDataCollection _result_ = ACIntvalHolidayMapWrapper.GetByUtilHoliday(UtilHolidayPK, token);
			if(_result_ == null)
				return null;

			return new ACIntvalHolidayMapCollection(_result_);
		}

		public static W3000.Data.ACIntvalHolidayMapViewCollection GetViewByUtilHoliday(System.Guid UtilHolidayPK)
		{
			return GetViewByUtilHoliday(UtilHolidayPK, Identity.Token);
		}

		public static W3000.Data.ACIntvalHolidayMapViewCollection GetViewByUtilHoliday(System.Guid UtilHolidayPK, SecurityToken token)
		{

			W3000.Data.ACIntvalHolidayMapViewCollection _result_ = ACIntvalHolidayMapWrapper.GetViewByUtilHoliday(UtilHolidayPK, token);
			if(_result_ == null)
				return null;

			return _result_;
		}

	}

	public partial class ACMainZone
	{
		public static Cheke.BusinessEntity.Result Purge(W3000.Data.ACMainZoneData entity)
		{
			return Purge(entity, Identity.Token);
		}

		public static Cheke.BusinessEntity.Result Purge(W3000.Data.ACMainZoneData entity, SecurityToken token)
		{
			if(entity != null)
			{
				entity = new W3000.Data.ACMainZoneData(entity);
			}

			Cheke.BusinessEntity.Result _result_ = ACMainZoneWrapper.Purge(entity, token);
			if(_result_ == null)
				return null;

			return _result_;
		}

		public static Cheke.BusinessEntity.Result Save(W3000.Data.ACMainZoneData entity)
		{
			return Save(entity, Identity.Token);
		}

		public static Cheke.BusinessEntity.Result Save(W3000.Data.ACMainZoneData entity, SecurityToken token)
		{
			if(entity != null)
			{
				entity = new W3000.Data.ACMainZoneData(entity);
			}

			Cheke.BusinessEntity.Result _result_ = ACMainZoneWrapper.Save(entity, token);
			if(_result_ == null)
				return null;

			return _result_;
		}

		public static Cheke.BusinessEntity.Result Save(W3000.Data.ACMainZoneDataCollection list)
		{
			return Save(list, Identity.Token);
		}

		public static Cheke.BusinessEntity.Result Save(W3000.Data.ACMainZoneDataCollection list, SecurityToken token)
		{
			if(list != null)
			{
				list = new W3000.Data.ACMainZoneDataCollection(list);
			}

			Cheke.BusinessEntity.Result _result_ = ACMainZoneWrapper.Save(list, token);
			if(_result_ == null)
				return null;

			return _result_;
		}

		public static ACMainZoneCollection GetByReaderTypeID(System.Int32 ReaderTypeID)
		{
			return GetByReaderTypeID(ReaderTypeID, Identity.Token);
		}

		public static ACMainZoneCollection GetByReaderTypeID(System.Int32 ReaderTypeID, SecurityToken token)
		{

			W3000.Data.ACMainZoneDataCollection _result_ = ACMainZoneWrapper.GetByReaderTypeID(ReaderTypeID, token);
			if(_result_ == null)
				return null;

			return new ACMainZoneCollection(_result_);
		}

		public static ACMainZoneCollection GetByMainZoneTypeID(System.Int32 MainZoneTypeID)
		{
			return GetByMainZoneTypeID(MainZoneTypeID, Identity.Token);
		}

		public static ACMainZoneCollection GetByMainZoneTypeID(System.Int32 MainZoneTypeID, SecurityToken token)
		{

			W3000.Data.ACMainZoneDataCollection _result_ = ACMainZoneWrapper.GetByMainZoneTypeID(MainZoneTypeID, token);
			if(_result_ == null)
				return null;

			return new ACMainZoneCollection(_result_);
		}

		public static ACMainZoneCollection GetByModifiedOn(System.DateTime begin,System.DateTime end)
		{
			return GetByModifiedOn(begin,end, Identity.Token);
		}

		public static ACMainZoneCollection GetByModifiedOn(System.DateTime begin,System.DateTime end, SecurityToken token)
		{

			W3000.Data.ACMainZoneDataCollection _result_ = ACMainZoneWrapper.GetByModifiedOn(begin,end, token);
			if(_result_ == null)
				return null;

			return new ACMainZoneCollection(_result_);
		}

		public static ACMainZoneCollection GetByMappedACOutputGroup(System.Guid ACOutputGroupPK)
		{
			return GetByMappedACOutputGroup(ACOutputGroupPK, Identity.Token);
		}

		public static ACMainZoneCollection GetByMappedACOutputGroup(System.Guid ACOutputGroupPK, SecurityToken token)
		{

			W3000.Data.ACMainZoneDataCollection _result_ = ACMainZoneWrapper.GetByMappedACOutputGroup(ACOutputGroupPK, token);
			if(_result_ == null)
				return null;

			return new ACMainZoneCollection(_result_);
		}

		public static ACMainZoneCollection GetByMappedACTimecode(System.Guid ACTimecodePK)
		{
			return GetByMappedACTimecode(ACTimecodePK, Identity.Token);
		}

		public static ACMainZoneCollection GetByMappedACTimecode(System.Guid ACTimecodePK, SecurityToken token)
		{

			W3000.Data.ACMainZoneDataCollection _result_ = ACMainZoneWrapper.GetByMappedACTimecode(ACTimecodePK, token);
			if(_result_ == null)
				return null;

			return new ACMainZoneCollection(_result_);
		}

		public static System.Int32 GetAllCount()
		{
			return GetAllCount( Identity.Token);
		}

		public static System.Int32 GetAllCount(SecurityToken token)
		{

			System.Int32 _result_ = ACMainZoneWrapper.GetAllCount( token);
			return _result_;
		}

		public static ACMainZoneCollection GetAllPage(System.Int32 pageIndex,System.Int32 pageSize)
		{
			return GetAllPage(pageIndex,pageSize, Identity.Token);
		}

		public static ACMainZoneCollection GetAllPage(System.Int32 pageIndex,System.Int32 pageSize, SecurityToken token)
		{

			W3000.Data.ACMainZoneDataCollection _result_ = ACMainZoneWrapper.GetAllPage(pageIndex,pageSize, token);
			if(_result_ == null)
				return null;

			return new ACMainZoneCollection(_result_);
		}

		public static ACMainZone GetByUK(System.Guid ACPanelPK,System.Byte PanelZoneID)
		{
			return GetByUK(ACPanelPK,PanelZoneID, Identity.Token);
		}

		public static ACMainZone GetByUK(System.Guid ACPanelPK,System.Byte PanelZoneID, SecurityToken token)
		{

			W3000.Data.ACMainZoneData _result_ = ACMainZoneWrapper.GetByUK(ACPanelPK,PanelZoneID, token);
			if(_result_ == null)
				return null;

			return new ACMainZone(_result_);
		}

		public static ACMainZone GetByPK(System.Guid ACMainZonePK)
		{
			return GetByPK(ACMainZonePK, Identity.Token);
		}

		public static ACMainZone GetByPK(System.Guid ACMainZonePK, SecurityToken token)
		{

			W3000.Data.ACMainZoneData _result_ = ACMainZoneWrapper.GetByPK(ACMainZonePK, token);
			if(_result_ == null)
				return null;

			return new ACMainZone(_result_);
		}

		public static ACMainZoneCollection GetAll()
		{
			return GetAll( Identity.Token);
		}

		public static ACMainZoneCollection GetAll(SecurityToken token)
		{

			W3000.Data.ACMainZoneDataCollection _result_ = ACMainZoneWrapper.GetAll( token);
			if(_result_ == null)
				return null;

			return new ACMainZoneCollection(_result_);
		}

		public static W3000.Data.ACMainZoneViewCollection GetViewAll()
		{
			return GetViewAll( Identity.Token);
		}

		public static W3000.Data.ACMainZoneViewCollection GetViewAll(SecurityToken token)
		{

			W3000.Data.ACMainZoneViewCollection _result_ = ACMainZoneWrapper.GetViewAll( token);
			if(_result_ == null)
				return null;

			return _result_;
		}

		public static ACMainZoneCollection GetByACPanel(System.Guid ACPanelPK)
		{
			return GetByACPanel(ACPanelPK, Identity.Token);
		}

		public static ACMainZoneCollection GetByACPanel(System.Guid ACPanelPK, SecurityToken token)
		{

			W3000.Data.ACMainZoneDataCollection _result_ = ACMainZoneWrapper.GetByACPanel(ACPanelPK, token);
			if(_result_ == null)
				return null;

			return new ACMainZoneCollection(_result_);
		}

		public static W3000.Data.ACMainZoneViewCollection GetViewByACPanel(System.Guid ACPanelPK)
		{
			return GetViewByACPanel(ACPanelPK, Identity.Token);
		}

		public static W3000.Data.ACMainZoneViewCollection GetViewByACPanel(System.Guid ACPanelPK, SecurityToken token)
		{

			W3000.Data.ACMainZoneViewCollection _result_ = ACMainZoneWrapper.GetViewByACPanel(ACPanelPK, token);
			if(_result_ == null)
				return null;

			return _result_;
		}

	}

	public partial class ACMasterCard
	{
		public static Cheke.BusinessEntity.Result Purge(W3000.Data.ACMasterCardData entity)
		{
			return Purge(entity, Identity.Token);
		}

		public static Cheke.BusinessEntity.Result Purge(W3000.Data.ACMasterCardData entity, SecurityToken token)
		{
			if(entity != null)
			{
				entity = new W3000.Data.ACMasterCardData(entity);
			}

			Cheke.BusinessEntity.Result _result_ = ACMasterCardWrapper.Purge(entity, token);
			if(_result_ == null)
				return null;

			return _result_;
		}

		public static Cheke.BusinessEntity.Result Save(W3000.Data.ACMasterCardData entity)
		{
			return Save(entity, Identity.Token);
		}

		public static Cheke.BusinessEntity.Result Save(W3000.Data.ACMasterCardData entity, SecurityToken token)
		{
			if(entity != null)
			{
				entity = new W3000.Data.ACMasterCardData(entity);
			}

			Cheke.BusinessEntity.Result _result_ = ACMasterCardWrapper.Save(entity, token);
			if(_result_ == null)
				return null;

			return _result_;
		}

		public static Cheke.BusinessEntity.Result Save(W3000.Data.ACMasterCardDataCollection list)
		{
			return Save(list, Identity.Token);
		}

		public static Cheke.BusinessEntity.Result Save(W3000.Data.ACMasterCardDataCollection list, SecurityToken token)
		{
			if(list != null)
			{
				list = new W3000.Data.ACMasterCardDataCollection(list);
			}

			Cheke.BusinessEntity.Result _result_ = ACMasterCardWrapper.Save(list, token);
			if(_result_ == null)
				return null;

			return _result_;
		}

		public static ACMasterCardCollection GetByCardTypeID(System.Int32 CardTypeID)
		{
			return GetByCardTypeID(CardTypeID, Identity.Token);
		}

		public static ACMasterCardCollection GetByCardTypeID(System.Int32 CardTypeID, SecurityToken token)
		{

			W3000.Data.ACMasterCardDataCollection _result_ = ACMasterCardWrapper.GetByCardTypeID(CardTypeID, token);
			if(_result_ == null)
				return null;

			return new ACMasterCardCollection(_result_);
		}

		public static ACMasterCardCollection GetByLikeFirstName(System.String FirstName)
		{
			return GetByLikeFirstName(FirstName, Identity.Token);
		}

		public static ACMasterCardCollection GetByLikeFirstName(System.String FirstName, SecurityToken token)
		{

			W3000.Data.ACMasterCardDataCollection _result_ = ACMasterCardWrapper.GetByLikeFirstName(FirstName, token);
			if(_result_ == null)
				return null;

			return new ACMasterCardCollection(_result_);
		}

		public static ACMasterCardCollection GetByLikeLastName(System.String LastName)
		{
			return GetByLikeLastName(LastName, Identity.Token);
		}

		public static ACMasterCardCollection GetByLikeLastName(System.String LastName, SecurityToken token)
		{

			W3000.Data.ACMasterCardDataCollection _result_ = ACMasterCardWrapper.GetByLikeLastName(LastName, token);
			if(_result_ == null)
				return null;

			return new ACMasterCardCollection(_result_);
		}

		public static ACMasterCardCollection GetByModifiedOn(System.DateTime begin,System.DateTime end)
		{
			return GetByModifiedOn(begin,end, Identity.Token);
		}

		public static ACMasterCardCollection GetByModifiedOn(System.DateTime begin,System.DateTime end, SecurityToken token)
		{

			W3000.Data.ACMasterCardDataCollection _result_ = ACMasterCardWrapper.GetByModifiedOn(begin,end, token);
			if(_result_ == null)
				return null;

			return new ACMasterCardCollection(_result_);
		}

		public static System.Int32 GetAllCount()
		{
			return GetAllCount( Identity.Token);
		}

		public static System.Int32 GetAllCount(SecurityToken token)
		{

			System.Int32 _result_ = ACMasterCardWrapper.GetAllCount( token);
			return _result_;
		}

		public static ACMasterCardCollection GetAllPage(System.Int32 pageIndex,System.Int32 pageSize)
		{
			return GetAllPage(pageIndex,pageSize, Identity.Token);
		}

		public static ACMasterCardCollection GetAllPage(System.Int32 pageIndex,System.Int32 pageSize, SecurityToken token)
		{

			W3000.Data.ACMasterCardDataCollection _result_ = ACMasterCardWrapper.GetAllPage(pageIndex,pageSize, token);
			if(_result_ == null)
				return null;

			return new ACMasterCardCollection(_result_);
		}

		public static ACMasterCard GetByUK(System.Int32 Sitecode,System.Int32 Embossed,System.Int32 CardTypeID)
		{
			return GetByUK(Sitecode,Embossed,CardTypeID, Identity.Token);
		}

		public static ACMasterCard GetByUK(System.Int32 Sitecode,System.Int32 Embossed,System.Int32 CardTypeID, SecurityToken token)
		{

			W3000.Data.ACMasterCardData _result_ = ACMasterCardWrapper.GetByUK(Sitecode,Embossed,CardTypeID, token);
			if(_result_ == null)
				return null;

			return new ACMasterCard(_result_);
		}

		public static ACMasterCard GetByUK1(System.Int32 Sitecode,System.Int32 Encoded,System.Int32 CardTypeID)
		{
			return GetByUK1(Sitecode,Encoded,CardTypeID, Identity.Token);
		}

		public static ACMasterCard GetByUK1(System.Int32 Sitecode,System.Int32 Encoded,System.Int32 CardTypeID, SecurityToken token)
		{

			W3000.Data.ACMasterCardData _result_ = ACMasterCardWrapper.GetByUK1(Sitecode,Encoded,CardTypeID, token);
			if(_result_ == null)
				return null;

			return new ACMasterCard(_result_);
		}

		public static ACMasterCard GetByPK(System.Guid ACMasterCardPK)
		{
			return GetByPK(ACMasterCardPK, Identity.Token);
		}

		public static ACMasterCard GetByPK(System.Guid ACMasterCardPK, SecurityToken token)
		{

			W3000.Data.ACMasterCardData _result_ = ACMasterCardWrapper.GetByPK(ACMasterCardPK, token);
			if(_result_ == null)
				return null;

			return new ACMasterCard(_result_);
		}

		public static ACMasterCardCollection GetAll()
		{
			return GetAll( Identity.Token);
		}

		public static ACMasterCardCollection GetAll(SecurityToken token)
		{

			W3000.Data.ACMasterCardDataCollection _result_ = ACMasterCardWrapper.GetAll( token);
			if(_result_ == null)
				return null;

			return new ACMasterCardCollection(_result_);
		}

		public static W3000.Data.ACMasterCardViewCollection GetViewAll()
		{
			return GetViewAll( Identity.Token);
		}

		public static W3000.Data.ACMasterCardViewCollection GetViewAll(SecurityToken token)
		{

			W3000.Data.ACMasterCardViewCollection _result_ = ACMasterCardWrapper.GetViewAll( token);
			if(_result_ == null)
				return null;

			return _result_;
		}

	}

	public partial class ACOutputGroup
	{
		public static Cheke.BusinessEntity.Result Purge(W3000.Data.ACOutputGroupData entity)
		{
			return Purge(entity, Identity.Token);
		}

		public static Cheke.BusinessEntity.Result Purge(W3000.Data.ACOutputGroupData entity, SecurityToken token)
		{
			if(entity != null)
			{
				entity = new W3000.Data.ACOutputGroupData(entity);
			}

			Cheke.BusinessEntity.Result _result_ = ACOutputGroupWrapper.Purge(entity, token);
			if(_result_ == null)
				return null;

			return _result_;
		}

		public static Cheke.BusinessEntity.Result Save(W3000.Data.ACOutputGroupData entity)
		{
			return Save(entity, Identity.Token);
		}

		public static Cheke.BusinessEntity.Result Save(W3000.Data.ACOutputGroupData entity, SecurityToken token)
		{
			if(entity != null)
			{
				entity = new W3000.Data.ACOutputGroupData(entity);
			}

			Cheke.BusinessEntity.Result _result_ = ACOutputGroupWrapper.Save(entity, token);
			if(_result_ == null)
				return null;

			return _result_;
		}

		public static Cheke.BusinessEntity.Result Save(W3000.Data.ACOutputGroupDataCollection list)
		{
			return Save(list, Identity.Token);
		}

		public static Cheke.BusinessEntity.Result Save(W3000.Data.ACOutputGroupDataCollection list, SecurityToken token)
		{
			if(list != null)
			{
				list = new W3000.Data.ACOutputGroupDataCollection(list);
			}

			Cheke.BusinessEntity.Result _result_ = ACOutputGroupWrapper.Save(list, token);
			if(_result_ == null)
				return null;

			return _result_;
		}

		public static ACOutputGroupCollection GetByModifiedOn(System.DateTime begin,System.DateTime end)
		{
			return GetByModifiedOn(begin,end, Identity.Token);
		}

		public static ACOutputGroupCollection GetByModifiedOn(System.DateTime begin,System.DateTime end, SecurityToken token)
		{

			W3000.Data.ACOutputGroupDataCollection _result_ = ACOutputGroupWrapper.GetByModifiedOn(begin,end, token);
			if(_result_ == null)
				return null;

			return new ACOutputGroupCollection(_result_);
		}

		public static ACOutputGroupCollection GetByMappedACMainZone(System.Guid ACMainZonePK)
		{
			return GetByMappedACMainZone(ACMainZonePK, Identity.Token);
		}

		public static ACOutputGroupCollection GetByMappedACMainZone(System.Guid ACMainZonePK, SecurityToken token)
		{

			W3000.Data.ACOutputGroupDataCollection _result_ = ACOutputGroupWrapper.GetByMappedACMainZone(ACMainZonePK, token);
			if(_result_ == null)
				return null;

			return new ACOutputGroupCollection(_result_);
		}

		public static System.Int32 GetAllCount()
		{
			return GetAllCount( Identity.Token);
		}

		public static System.Int32 GetAllCount(SecurityToken token)
		{

			System.Int32 _result_ = ACOutputGroupWrapper.GetAllCount( token);
			return _result_;
		}

		public static ACOutputGroupCollection GetAllPage(System.Int32 pageIndex,System.Int32 pageSize)
		{
			return GetAllPage(pageIndex,pageSize, Identity.Token);
		}

		public static ACOutputGroupCollection GetAllPage(System.Int32 pageIndex,System.Int32 pageSize, SecurityToken token)
		{

			W3000.Data.ACOutputGroupDataCollection _result_ = ACOutputGroupWrapper.GetAllPage(pageIndex,pageSize, token);
			if(_result_ == null)
				return null;

			return new ACOutputGroupCollection(_result_);
		}

		public static ACOutputGroup GetByUK(System.Guid ACPanelPK,System.Byte GroupID)
		{
			return GetByUK(ACPanelPK,GroupID, Identity.Token);
		}

		public static ACOutputGroup GetByUK(System.Guid ACPanelPK,System.Byte GroupID, SecurityToken token)
		{

			W3000.Data.ACOutputGroupData _result_ = ACOutputGroupWrapper.GetByUK(ACPanelPK,GroupID, token);
			if(_result_ == null)
				return null;

			return new ACOutputGroup(_result_);
		}

		public static ACOutputGroup GetByPK(System.Guid ACOutputGroupPK)
		{
			return GetByPK(ACOutputGroupPK, Identity.Token);
		}

		public static ACOutputGroup GetByPK(System.Guid ACOutputGroupPK, SecurityToken token)
		{

			W3000.Data.ACOutputGroupData _result_ = ACOutputGroupWrapper.GetByPK(ACOutputGroupPK, token);
			if(_result_ == null)
				return null;

			return new ACOutputGroup(_result_);
		}

		public static ACOutputGroupCollection GetAll()
		{
			return GetAll( Identity.Token);
		}

		public static ACOutputGroupCollection GetAll(SecurityToken token)
		{

			W3000.Data.ACOutputGroupDataCollection _result_ = ACOutputGroupWrapper.GetAll( token);
			if(_result_ == null)
				return null;

			return new ACOutputGroupCollection(_result_);
		}

		public static W3000.Data.ACOutputGroupViewCollection GetViewAll()
		{
			return GetViewAll( Identity.Token);
		}

		public static W3000.Data.ACOutputGroupViewCollection GetViewAll(SecurityToken token)
		{

			W3000.Data.ACOutputGroupViewCollection _result_ = ACOutputGroupWrapper.GetViewAll( token);
			if(_result_ == null)
				return null;

			return _result_;
		}

		public static ACOutputGroupCollection GetByACPanel(System.Guid ACPanelPK)
		{
			return GetByACPanel(ACPanelPK, Identity.Token);
		}

		public static ACOutputGroupCollection GetByACPanel(System.Guid ACPanelPK, SecurityToken token)
		{

			W3000.Data.ACOutputGroupDataCollection _result_ = ACOutputGroupWrapper.GetByACPanel(ACPanelPK, token);
			if(_result_ == null)
				return null;

			return new ACOutputGroupCollection(_result_);
		}

		public static W3000.Data.ACOutputGroupViewCollection GetViewByACPanel(System.Guid ACPanelPK)
		{
			return GetViewByACPanel(ACPanelPK, Identity.Token);
		}

		public static W3000.Data.ACOutputGroupViewCollection GetViewByACPanel(System.Guid ACPanelPK, SecurityToken token)
		{

			W3000.Data.ACOutputGroupViewCollection _result_ = ACOutputGroupWrapper.GetViewByACPanel(ACPanelPK, token);
			if(_result_ == null)
				return null;

			return _result_;
		}

	}

	public partial class ACOutputGroupMainZoneMap
	{
		public static Cheke.BusinessEntity.Result Purge(W3000.Data.ACOutputGroupMainZoneMapData entity)
		{
			return Purge(entity, Identity.Token);
		}

		public static Cheke.BusinessEntity.Result Purge(W3000.Data.ACOutputGroupMainZoneMapData entity, SecurityToken token)
		{
			if(entity != null)
			{
				entity = new W3000.Data.ACOutputGroupMainZoneMapData(entity);
			}

			Cheke.BusinessEntity.Result _result_ = ACOutputGroupMainZoneMapWrapper.Purge(entity, token);
			if(_result_ == null)
				return null;

			return _result_;
		}

		public static Cheke.BusinessEntity.Result Save(W3000.Data.ACOutputGroupMainZoneMapData entity)
		{
			return Save(entity, Identity.Token);
		}

		public static Cheke.BusinessEntity.Result Save(W3000.Data.ACOutputGroupMainZoneMapData entity, SecurityToken token)
		{
			if(entity != null)
			{
				entity = new W3000.Data.ACOutputGroupMainZoneMapData(entity);
			}

			Cheke.BusinessEntity.Result _result_ = ACOutputGroupMainZoneMapWrapper.Save(entity, token);
			if(_result_ == null)
				return null;

			return _result_;
		}

		public static Cheke.BusinessEntity.Result Save(W3000.Data.ACOutputGroupMainZoneMapDataCollection list)
		{
			return Save(list, Identity.Token);
		}

		public static Cheke.BusinessEntity.Result Save(W3000.Data.ACOutputGroupMainZoneMapDataCollection list, SecurityToken token)
		{
			if(list != null)
			{
				list = new W3000.Data.ACOutputGroupMainZoneMapDataCollection(list);
			}

			Cheke.BusinessEntity.Result _result_ = ACOutputGroupMainZoneMapWrapper.Save(list, token);
			if(_result_ == null)
				return null;

			return _result_;
		}

		public static ACOutputGroupMainZoneMapCollection GetByModifiedOn(System.DateTime begin,System.DateTime end)
		{
			return GetByModifiedOn(begin,end, Identity.Token);
		}

		public static ACOutputGroupMainZoneMapCollection GetByModifiedOn(System.DateTime begin,System.DateTime end, SecurityToken token)
		{

			W3000.Data.ACOutputGroupMainZoneMapDataCollection _result_ = ACOutputGroupMainZoneMapWrapper.GetByModifiedOn(begin,end, token);
			if(_result_ == null)
				return null;

			return new ACOutputGroupMainZoneMapCollection(_result_);
		}

		public static System.Int32 GetAllCount()
		{
			return GetAllCount( Identity.Token);
		}

		public static System.Int32 GetAllCount(SecurityToken token)
		{

			System.Int32 _result_ = ACOutputGroupMainZoneMapWrapper.GetAllCount( token);
			return _result_;
		}

		public static ACOutputGroupMainZoneMapCollection GetAllPage(System.Int32 pageIndex,System.Int32 pageSize)
		{
			return GetAllPage(pageIndex,pageSize, Identity.Token);
		}

		public static ACOutputGroupMainZoneMapCollection GetAllPage(System.Int32 pageIndex,System.Int32 pageSize, SecurityToken token)
		{

			W3000.Data.ACOutputGroupMainZoneMapDataCollection _result_ = ACOutputGroupMainZoneMapWrapper.GetAllPage(pageIndex,pageSize, token);
			if(_result_ == null)
				return null;

			return new ACOutputGroupMainZoneMapCollection(_result_);
		}

		public static ACOutputGroupMainZoneMap GetByUK(System.Guid ACOutputGroupPK,System.Guid ACMainZonePK)
		{
			return GetByUK(ACOutputGroupPK,ACMainZonePK, Identity.Token);
		}

		public static ACOutputGroupMainZoneMap GetByUK(System.Guid ACOutputGroupPK,System.Guid ACMainZonePK, SecurityToken token)
		{

			W3000.Data.ACOutputGroupMainZoneMapData _result_ = ACOutputGroupMainZoneMapWrapper.GetByUK(ACOutputGroupPK,ACMainZonePK, token);
			if(_result_ == null)
				return null;

			return new ACOutputGroupMainZoneMap(_result_);
		}

		public static ACOutputGroupMainZoneMap GetByPK(System.Guid ACOutputGroupMainZoneMapPK)
		{
			return GetByPK(ACOutputGroupMainZoneMapPK, Identity.Token);
		}

		public static ACOutputGroupMainZoneMap GetByPK(System.Guid ACOutputGroupMainZoneMapPK, SecurityToken token)
		{

			W3000.Data.ACOutputGroupMainZoneMapData _result_ = ACOutputGroupMainZoneMapWrapper.GetByPK(ACOutputGroupMainZoneMapPK, token);
			if(_result_ == null)
				return null;

			return new ACOutputGroupMainZoneMap(_result_);
		}

		public static ACOutputGroupMainZoneMapCollection GetAll()
		{
			return GetAll( Identity.Token);
		}

		public static ACOutputGroupMainZoneMapCollection GetAll(SecurityToken token)
		{

			W3000.Data.ACOutputGroupMainZoneMapDataCollection _result_ = ACOutputGroupMainZoneMapWrapper.GetAll( token);
			if(_result_ == null)
				return null;

			return new ACOutputGroupMainZoneMapCollection(_result_);
		}

		public static W3000.Data.ACOutputGroupMainZoneMapViewCollection GetViewAll()
		{
			return GetViewAll( Identity.Token);
		}

		public static W3000.Data.ACOutputGroupMainZoneMapViewCollection GetViewAll(SecurityToken token)
		{

			W3000.Data.ACOutputGroupMainZoneMapViewCollection _result_ = ACOutputGroupMainZoneMapWrapper.GetViewAll( token);
			if(_result_ == null)
				return null;

			return _result_;
		}

		public static ACOutputGroupMainZoneMapCollection GetByACMainZone(System.Guid ACMainZonePK)
		{
			return GetByACMainZone(ACMainZonePK, Identity.Token);
		}

		public static ACOutputGroupMainZoneMapCollection GetByACMainZone(System.Guid ACMainZonePK, SecurityToken token)
		{

			W3000.Data.ACOutputGroupMainZoneMapDataCollection _result_ = ACOutputGroupMainZoneMapWrapper.GetByACMainZone(ACMainZonePK, token);
			if(_result_ == null)
				return null;

			return new ACOutputGroupMainZoneMapCollection(_result_);
		}

		public static W3000.Data.ACOutputGroupMainZoneMapViewCollection GetViewByACMainZone(System.Guid ACMainZonePK)
		{
			return GetViewByACMainZone(ACMainZonePK, Identity.Token);
		}

		public static W3000.Data.ACOutputGroupMainZoneMapViewCollection GetViewByACMainZone(System.Guid ACMainZonePK, SecurityToken token)
		{

			W3000.Data.ACOutputGroupMainZoneMapViewCollection _result_ = ACOutputGroupMainZoneMapWrapper.GetViewByACMainZone(ACMainZonePK, token);
			if(_result_ == null)
				return null;

			return _result_;
		}

		public static ACOutputGroupMainZoneMapCollection GetByACOutputGroup(System.Guid ACOutputGroupPK)
		{
			return GetByACOutputGroup(ACOutputGroupPK, Identity.Token);
		}

		public static ACOutputGroupMainZoneMapCollection GetByACOutputGroup(System.Guid ACOutputGroupPK, SecurityToken token)
		{

			W3000.Data.ACOutputGroupMainZoneMapDataCollection _result_ = ACOutputGroupMainZoneMapWrapper.GetByACOutputGroup(ACOutputGroupPK, token);
			if(_result_ == null)
				return null;

			return new ACOutputGroupMainZoneMapCollection(_result_);
		}

		public static W3000.Data.ACOutputGroupMainZoneMapViewCollection GetViewByACOutputGroup(System.Guid ACOutputGroupPK)
		{
			return GetViewByACOutputGroup(ACOutputGroupPK, Identity.Token);
		}

		public static W3000.Data.ACOutputGroupMainZoneMapViewCollection GetViewByACOutputGroup(System.Guid ACOutputGroupPK, SecurityToken token)
		{

			W3000.Data.ACOutputGroupMainZoneMapViewCollection _result_ = ACOutputGroupMainZoneMapWrapper.GetViewByACOutputGroup(ACOutputGroupPK, token);
			if(_result_ == null)
				return null;

			return _result_;
		}

	}

	public partial class ACPanel
	{
		public static Cheke.BusinessEntity.Result Purge(W3000.Data.ACPanelData entity)
		{
			return Purge(entity, Identity.Token);
		}

		public static Cheke.BusinessEntity.Result Purge(W3000.Data.ACPanelData entity, SecurityToken token)
		{
			if(entity != null)
			{
				entity = new W3000.Data.ACPanelData(entity);
			}

			Cheke.BusinessEntity.Result _result_ = ACPanelWrapper.Purge(entity, token);
			if(_result_ == null)
				return null;

			return _result_;
		}

		public static Cheke.BusinessEntity.Result Save(W3000.Data.ACPanelData entity)
		{
			return Save(entity, Identity.Token);
		}

		public static Cheke.BusinessEntity.Result Save(W3000.Data.ACPanelData entity, SecurityToken token)
		{
			if(entity != null)
			{
				entity = new W3000.Data.ACPanelData(entity);
			}

			Cheke.BusinessEntity.Result _result_ = ACPanelWrapper.Save(entity, token);
			if(_result_ == null)
				return null;

			return _result_;
		}

		public static Cheke.BusinessEntity.Result Save(W3000.Data.ACPanelDataCollection list)
		{
			return Save(list, Identity.Token);
		}

		public static Cheke.BusinessEntity.Result Save(W3000.Data.ACPanelDataCollection list, SecurityToken token)
		{
			if(list != null)
			{
				list = new W3000.Data.ACPanelDataCollection(list);
			}

			Cheke.BusinessEntity.Result _result_ = ACPanelWrapper.Save(list, token);
			if(_result_ == null)
				return null;

			return _result_;
		}

		public static ACPanelCollection GetByPanelTypeID(System.Int32 PanelTypeID)
		{
			return GetByPanelTypeID(PanelTypeID, Identity.Token);
		}

		public static ACPanelCollection GetByPanelTypeID(System.Int32 PanelTypeID, SecurityToken token)
		{

			W3000.Data.ACPanelDataCollection _result_ = ACPanelWrapper.GetByPanelTypeID(PanelTypeID, token);
			if(_result_ == null)
				return null;

			return new ACPanelCollection(_result_);
		}

		public static ACPanelCollection GetByLikeUnitPhone(System.String UnitPhone)
		{
			return GetByLikeUnitPhone(UnitPhone, Identity.Token);
		}

		public static ACPanelCollection GetByLikeUnitPhone(System.String UnitPhone, SecurityToken token)
		{

			W3000.Data.ACPanelDataCollection _result_ = ACPanelWrapper.GetByLikeUnitPhone(UnitPhone, token);
			if(_result_ == null)
				return null;

			return new ACPanelCollection(_result_);
		}

		public static ACPanelCollection GetByLikeUnitPhoneCallerID(System.String UnitPhoneCallerID)
		{
			return GetByLikeUnitPhoneCallerID(UnitPhoneCallerID, Identity.Token);
		}

		public static ACPanelCollection GetByLikeUnitPhoneCallerID(System.String UnitPhoneCallerID, SecurityToken token)
		{

			W3000.Data.ACPanelDataCollection _result_ = ACPanelWrapper.GetByLikeUnitPhoneCallerID(UnitPhoneCallerID, token);
			if(_result_ == null)
				return null;

			return new ACPanelCollection(_result_);
		}

		public static ACPanelCollection GetByModifiedOn(System.DateTime begin,System.DateTime end)
		{
			return GetByModifiedOn(begin,end, Identity.Token);
		}

		public static ACPanelCollection GetByModifiedOn(System.DateTime begin,System.DateTime end, SecurityToken token)
		{

			W3000.Data.ACPanelDataCollection _result_ = ACPanelWrapper.GetByModifiedOn(begin,end, token);
			if(_result_ == null)
				return null;

			return new ACPanelCollection(_result_);
		}

		public static ACPanelCollection GetByMappedUtilHoliday(System.Guid UtilHolidayPK)
		{
			return GetByMappedUtilHoliday(UtilHolidayPK, Identity.Token);
		}

		public static ACPanelCollection GetByMappedUtilHoliday(System.Guid UtilHolidayPK, SecurityToken token)
		{

			W3000.Data.ACPanelDataCollection _result_ = ACPanelWrapper.GetByMappedUtilHoliday(UtilHolidayPK, token);
			if(_result_ == null)
				return null;

			return new ACPanelCollection(_result_);
		}

		public static ACPanelCollection GetByMappedACFunctionCard(System.Guid ACFunctionCardPK)
		{
			return GetByMappedACFunctionCard(ACFunctionCardPK, Identity.Token);
		}

		public static ACPanelCollection GetByMappedACFunctionCard(System.Guid ACFunctionCardPK, SecurityToken token)
		{

			W3000.Data.ACPanelDataCollection _result_ = ACPanelWrapper.GetByMappedACFunctionCard(ACFunctionCardPK, token);
			if(_result_ == null)
				return null;

			return new ACPanelCollection(_result_);
		}

		public static System.Int32 GetAllCount()
		{
			return GetAllCount( Identity.Token);
		}

		public static System.Int32 GetAllCount(SecurityToken token)
		{

			System.Int32 _result_ = ACPanelWrapper.GetAllCount( token);
			return _result_;
		}

		public static ACPanelCollection GetAllPage(System.Int32 pageIndex,System.Int32 pageSize)
		{
			return GetAllPage(pageIndex,pageSize, Identity.Token);
		}

		public static ACPanelCollection GetAllPage(System.Int32 pageIndex,System.Int32 pageSize, SecurityToken token)
		{

			W3000.Data.ACPanelDataCollection _result_ = ACPanelWrapper.GetAllPage(pageIndex,pageSize, token);
			if(_result_ == null)
				return null;

			return new ACPanelCollection(_result_);
		}

		public static ACPanel GetByUnitID(System.Int32 UnitID)
		{
			return GetByUnitID(UnitID, Identity.Token);
		}

		public static ACPanel GetByUnitID(System.Int32 UnitID, SecurityToken token)
		{

			W3000.Data.ACPanelData _result_ = ACPanelWrapper.GetByUnitID(UnitID, token);
			if(_result_ == null)
				return null;

			return new ACPanel(_result_);
		}

		public static ACPanel GetByPK(System.Guid ACPanelPK)
		{
			return GetByPK(ACPanelPK, Identity.Token);
		}

		public static ACPanel GetByPK(System.Guid ACPanelPK, SecurityToken token)
		{

			W3000.Data.ACPanelData _result_ = ACPanelWrapper.GetByPK(ACPanelPK, token);
			if(_result_ == null)
				return null;

			return new ACPanel(_result_);
		}

		public static ACPanelCollection GetAll()
		{
			return GetAll( Identity.Token);
		}

		public static ACPanelCollection GetAll(SecurityToken token)
		{

			W3000.Data.ACPanelDataCollection _result_ = ACPanelWrapper.GetAll( token);
			if(_result_ == null)
				return null;

			return new ACPanelCollection(_result_);
		}

		public static W3000.Data.ACPanelViewCollection GetViewAll()
		{
			return GetViewAll( Identity.Token);
		}

		public static W3000.Data.ACPanelViewCollection GetViewAll(SecurityToken token)
		{

			W3000.Data.ACPanelViewCollection _result_ = ACPanelWrapper.GetViewAll( token);
			if(_result_ == null)
				return null;

			return _result_;
		}

		public static ACPanelCollection GetByBDBuilding(System.Guid BDBuildingPK)
		{
			return GetByBDBuilding(BDBuildingPK, Identity.Token);
		}

		public static ACPanelCollection GetByBDBuilding(System.Guid BDBuildingPK, SecurityToken token)
		{

			W3000.Data.ACPanelDataCollection _result_ = ACPanelWrapper.GetByBDBuilding(BDBuildingPK, token);
			if(_result_ == null)
				return null;

			return new ACPanelCollection(_result_);
		}

		public static W3000.Data.ACPanelViewCollection GetViewByBDBuilding(System.Guid BDBuildingPK)
		{
			return GetViewByBDBuilding(BDBuildingPK, Identity.Token);
		}

		public static W3000.Data.ACPanelViewCollection GetViewByBDBuilding(System.Guid BDBuildingPK, SecurityToken token)
		{

			W3000.Data.ACPanelViewCollection _result_ = ACPanelWrapper.GetViewByBDBuilding(BDBuildingPK, token);
			if(_result_ == null)
				return null;

			return _result_;
		}

	}

	public partial class ACPanelFunctionCardMap
	{
		public static Cheke.BusinessEntity.Result Purge(W3000.Data.ACPanelFunctionCardMapData entity)
		{
			return Purge(entity, Identity.Token);
		}

		public static Cheke.BusinessEntity.Result Purge(W3000.Data.ACPanelFunctionCardMapData entity, SecurityToken token)
		{
			if(entity != null)
			{
				entity = new W3000.Data.ACPanelFunctionCardMapData(entity);
			}

			Cheke.BusinessEntity.Result _result_ = ACPanelFunctionCardMapWrapper.Purge(entity, token);
			if(_result_ == null)
				return null;

			return _result_;
		}

		public static Cheke.BusinessEntity.Result Save(W3000.Data.ACPanelFunctionCardMapData entity)
		{
			return Save(entity, Identity.Token);
		}

		public static Cheke.BusinessEntity.Result Save(W3000.Data.ACPanelFunctionCardMapData entity, SecurityToken token)
		{
			if(entity != null)
			{
				entity = new W3000.Data.ACPanelFunctionCardMapData(entity);
			}

			Cheke.BusinessEntity.Result _result_ = ACPanelFunctionCardMapWrapper.Save(entity, token);
			if(_result_ == null)
				return null;

			return _result_;
		}

		public static Cheke.BusinessEntity.Result Save(W3000.Data.ACPanelFunctionCardMapDataCollection list)
		{
			return Save(list, Identity.Token);
		}

		public static Cheke.BusinessEntity.Result Save(W3000.Data.ACPanelFunctionCardMapDataCollection list, SecurityToken token)
		{
			if(list != null)
			{
				list = new W3000.Data.ACPanelFunctionCardMapDataCollection(list);
			}

			Cheke.BusinessEntity.Result _result_ = ACPanelFunctionCardMapWrapper.Save(list, token);
			if(_result_ == null)
				return null;

			return _result_;
		}

		public static ACPanelFunctionCardMapCollection GetByModifiedOn(System.DateTime begin,System.DateTime end)
		{
			return GetByModifiedOn(begin,end, Identity.Token);
		}

		public static ACPanelFunctionCardMapCollection GetByModifiedOn(System.DateTime begin,System.DateTime end, SecurityToken token)
		{

			W3000.Data.ACPanelFunctionCardMapDataCollection _result_ = ACPanelFunctionCardMapWrapper.GetByModifiedOn(begin,end, token);
			if(_result_ == null)
				return null;

			return new ACPanelFunctionCardMapCollection(_result_);
		}

		public static System.Int32 GetAllCount()
		{
			return GetAllCount( Identity.Token);
		}

		public static System.Int32 GetAllCount(SecurityToken token)
		{

			System.Int32 _result_ = ACPanelFunctionCardMapWrapper.GetAllCount( token);
			return _result_;
		}

		public static ACPanelFunctionCardMapCollection GetAllPage(System.Int32 pageIndex,System.Int32 pageSize)
		{
			return GetAllPage(pageIndex,pageSize, Identity.Token);
		}

		public static ACPanelFunctionCardMapCollection GetAllPage(System.Int32 pageIndex,System.Int32 pageSize, SecurityToken token)
		{

			W3000.Data.ACPanelFunctionCardMapDataCollection _result_ = ACPanelFunctionCardMapWrapper.GetAllPage(pageIndex,pageSize, token);
			if(_result_ == null)
				return null;

			return new ACPanelFunctionCardMapCollection(_result_);
		}

		public static ACPanelFunctionCardMap GetByUK(System.Guid ACPanelPK,System.Guid ACFunctionCardPK)
		{
			return GetByUK(ACPanelPK,ACFunctionCardPK, Identity.Token);
		}

		public static ACPanelFunctionCardMap GetByUK(System.Guid ACPanelPK,System.Guid ACFunctionCardPK, SecurityToken token)
		{

			W3000.Data.ACPanelFunctionCardMapData _result_ = ACPanelFunctionCardMapWrapper.GetByUK(ACPanelPK,ACFunctionCardPK, token);
			if(_result_ == null)
				return null;

			return new ACPanelFunctionCardMap(_result_);
		}

		public static ACPanelFunctionCardMap GetByPK(System.Guid ACPanelFunctionCardMapPK)
		{
			return GetByPK(ACPanelFunctionCardMapPK, Identity.Token);
		}

		public static ACPanelFunctionCardMap GetByPK(System.Guid ACPanelFunctionCardMapPK, SecurityToken token)
		{

			W3000.Data.ACPanelFunctionCardMapData _result_ = ACPanelFunctionCardMapWrapper.GetByPK(ACPanelFunctionCardMapPK, token);
			if(_result_ == null)
				return null;

			return new ACPanelFunctionCardMap(_result_);
		}

		public static ACPanelFunctionCardMapCollection GetAll()
		{
			return GetAll( Identity.Token);
		}

		public static ACPanelFunctionCardMapCollection GetAll(SecurityToken token)
		{

			W3000.Data.ACPanelFunctionCardMapDataCollection _result_ = ACPanelFunctionCardMapWrapper.GetAll( token);
			if(_result_ == null)
				return null;

			return new ACPanelFunctionCardMapCollection(_result_);
		}

		public static W3000.Data.ACPanelFunctionCardMapViewCollection GetViewAll()
		{
			return GetViewAll( Identity.Token);
		}

		public static W3000.Data.ACPanelFunctionCardMapViewCollection GetViewAll(SecurityToken token)
		{

			W3000.Data.ACPanelFunctionCardMapViewCollection _result_ = ACPanelFunctionCardMapWrapper.GetViewAll( token);
			if(_result_ == null)
				return null;

			return _result_;
		}

		public static ACPanelFunctionCardMapCollection GetByACFunctionCard(System.Guid ACFunctionCardPK)
		{
			return GetByACFunctionCard(ACFunctionCardPK, Identity.Token);
		}

		public static ACPanelFunctionCardMapCollection GetByACFunctionCard(System.Guid ACFunctionCardPK, SecurityToken token)
		{

			W3000.Data.ACPanelFunctionCardMapDataCollection _result_ = ACPanelFunctionCardMapWrapper.GetByACFunctionCard(ACFunctionCardPK, token);
			if(_result_ == null)
				return null;

			return new ACPanelFunctionCardMapCollection(_result_);
		}

		public static W3000.Data.ACPanelFunctionCardMapViewCollection GetViewByACFunctionCard(System.Guid ACFunctionCardPK)
		{
			return GetViewByACFunctionCard(ACFunctionCardPK, Identity.Token);
		}

		public static W3000.Data.ACPanelFunctionCardMapViewCollection GetViewByACFunctionCard(System.Guid ACFunctionCardPK, SecurityToken token)
		{

			W3000.Data.ACPanelFunctionCardMapViewCollection _result_ = ACPanelFunctionCardMapWrapper.GetViewByACFunctionCard(ACFunctionCardPK, token);
			if(_result_ == null)
				return null;

			return _result_;
		}

		public static ACPanelFunctionCardMapCollection GetByACPanel(System.Guid ACPanelPK)
		{
			return GetByACPanel(ACPanelPK, Identity.Token);
		}

		public static ACPanelFunctionCardMapCollection GetByACPanel(System.Guid ACPanelPK, SecurityToken token)
		{

			W3000.Data.ACPanelFunctionCardMapDataCollection _result_ = ACPanelFunctionCardMapWrapper.GetByACPanel(ACPanelPK, token);
			if(_result_ == null)
				return null;

			return new ACPanelFunctionCardMapCollection(_result_);
		}

		public static W3000.Data.ACPanelFunctionCardMapViewCollection GetViewByACPanel(System.Guid ACPanelPK)
		{
			return GetViewByACPanel(ACPanelPK, Identity.Token);
		}

		public static W3000.Data.ACPanelFunctionCardMapViewCollection GetViewByACPanel(System.Guid ACPanelPK, SecurityToken token)
		{

			W3000.Data.ACPanelFunctionCardMapViewCollection _result_ = ACPanelFunctionCardMapWrapper.GetViewByACPanel(ACPanelPK, token);
			if(_result_ == null)
				return null;

			return _result_;
		}

	}

	public partial class ACPanelHolidayMap
	{
		public static Cheke.BusinessEntity.Result Purge(W3000.Data.ACPanelHolidayMapData entity)
		{
			return Purge(entity, Identity.Token);
		}

		public static Cheke.BusinessEntity.Result Purge(W3000.Data.ACPanelHolidayMapData entity, SecurityToken token)
		{
			if(entity != null)
			{
				entity = new W3000.Data.ACPanelHolidayMapData(entity);
			}

			Cheke.BusinessEntity.Result _result_ = ACPanelHolidayMapWrapper.Purge(entity, token);
			if(_result_ == null)
				return null;

			return _result_;
		}

		public static Cheke.BusinessEntity.Result Save(W3000.Data.ACPanelHolidayMapData entity)
		{
			return Save(entity, Identity.Token);
		}

		public static Cheke.BusinessEntity.Result Save(W3000.Data.ACPanelHolidayMapData entity, SecurityToken token)
		{
			if(entity != null)
			{
				entity = new W3000.Data.ACPanelHolidayMapData(entity);
			}

			Cheke.BusinessEntity.Result _result_ = ACPanelHolidayMapWrapper.Save(entity, token);
			if(_result_ == null)
				return null;

			return _result_;
		}

		public static Cheke.BusinessEntity.Result Save(W3000.Data.ACPanelHolidayMapDataCollection list)
		{
			return Save(list, Identity.Token);
		}

		public static Cheke.BusinessEntity.Result Save(W3000.Data.ACPanelHolidayMapDataCollection list, SecurityToken token)
		{
			if(list != null)
			{
				list = new W3000.Data.ACPanelHolidayMapDataCollection(list);
			}

			Cheke.BusinessEntity.Result _result_ = ACPanelHolidayMapWrapper.Save(list, token);
			if(_result_ == null)
				return null;

			return _result_;
		}

		public static ACPanelHolidayMapCollection GetByModifiedOn(System.DateTime begin,System.DateTime end)
		{
			return GetByModifiedOn(begin,end, Identity.Token);
		}

		public static ACPanelHolidayMapCollection GetByModifiedOn(System.DateTime begin,System.DateTime end, SecurityToken token)
		{

			W3000.Data.ACPanelHolidayMapDataCollection _result_ = ACPanelHolidayMapWrapper.GetByModifiedOn(begin,end, token);
			if(_result_ == null)
				return null;

			return new ACPanelHolidayMapCollection(_result_);
		}

		public static System.Int32 GetAllCount()
		{
			return GetAllCount( Identity.Token);
		}

		public static System.Int32 GetAllCount(SecurityToken token)
		{

			System.Int32 _result_ = ACPanelHolidayMapWrapper.GetAllCount( token);
			return _result_;
		}

		public static ACPanelHolidayMapCollection GetAllPage(System.Int32 pageIndex,System.Int32 pageSize)
		{
			return GetAllPage(pageIndex,pageSize, Identity.Token);
		}

		public static ACPanelHolidayMapCollection GetAllPage(System.Int32 pageIndex,System.Int32 pageSize, SecurityToken token)
		{

			W3000.Data.ACPanelHolidayMapDataCollection _result_ = ACPanelHolidayMapWrapper.GetAllPage(pageIndex,pageSize, token);
			if(_result_ == null)
				return null;

			return new ACPanelHolidayMapCollection(_result_);
		}

		public static ACPanelHolidayMap GetByUK(System.Guid ACPanelPK,System.Guid UtilHolidayPK)
		{
			return GetByUK(ACPanelPK,UtilHolidayPK, Identity.Token);
		}

		public static ACPanelHolidayMap GetByUK(System.Guid ACPanelPK,System.Guid UtilHolidayPK, SecurityToken token)
		{

			W3000.Data.ACPanelHolidayMapData _result_ = ACPanelHolidayMapWrapper.GetByUK(ACPanelPK,UtilHolidayPK, token);
			if(_result_ == null)
				return null;

			return new ACPanelHolidayMap(_result_);
		}

		public static ACPanelHolidayMap GetByPK(System.Guid ACPanelHolidayMapPK)
		{
			return GetByPK(ACPanelHolidayMapPK, Identity.Token);
		}

		public static ACPanelHolidayMap GetByPK(System.Guid ACPanelHolidayMapPK, SecurityToken token)
		{

			W3000.Data.ACPanelHolidayMapData _result_ = ACPanelHolidayMapWrapper.GetByPK(ACPanelHolidayMapPK, token);
			if(_result_ == null)
				return null;

			return new ACPanelHolidayMap(_result_);
		}

		public static ACPanelHolidayMapCollection GetAll()
		{
			return GetAll( Identity.Token);
		}

		public static ACPanelHolidayMapCollection GetAll(SecurityToken token)
		{

			W3000.Data.ACPanelHolidayMapDataCollection _result_ = ACPanelHolidayMapWrapper.GetAll( token);
			if(_result_ == null)
				return null;

			return new ACPanelHolidayMapCollection(_result_);
		}

		public static W3000.Data.ACPanelHolidayMapViewCollection GetViewAll()
		{
			return GetViewAll( Identity.Token);
		}

		public static W3000.Data.ACPanelHolidayMapViewCollection GetViewAll(SecurityToken token)
		{

			W3000.Data.ACPanelHolidayMapViewCollection _result_ = ACPanelHolidayMapWrapper.GetViewAll( token);
			if(_result_ == null)
				return null;

			return _result_;
		}

		public static ACPanelHolidayMapCollection GetByUtilHoliday(System.Guid UtilHolidayPK)
		{
			return GetByUtilHoliday(UtilHolidayPK, Identity.Token);
		}

		public static ACPanelHolidayMapCollection GetByUtilHoliday(System.Guid UtilHolidayPK, SecurityToken token)
		{

			W3000.Data.ACPanelHolidayMapDataCollection _result_ = ACPanelHolidayMapWrapper.GetByUtilHoliday(UtilHolidayPK, token);
			if(_result_ == null)
				return null;

			return new ACPanelHolidayMapCollection(_result_);
		}

		public static W3000.Data.ACPanelHolidayMapViewCollection GetViewByUtilHoliday(System.Guid UtilHolidayPK)
		{
			return GetViewByUtilHoliday(UtilHolidayPK, Identity.Token);
		}

		public static W3000.Data.ACPanelHolidayMapViewCollection GetViewByUtilHoliday(System.Guid UtilHolidayPK, SecurityToken token)
		{

			W3000.Data.ACPanelHolidayMapViewCollection _result_ = ACPanelHolidayMapWrapper.GetViewByUtilHoliday(UtilHolidayPK, token);
			if(_result_ == null)
				return null;

			return _result_;
		}

		public static ACPanelHolidayMapCollection GetByACPanel(System.Guid ACPanelPK)
		{
			return GetByACPanel(ACPanelPK, Identity.Token);
		}

		public static ACPanelHolidayMapCollection GetByACPanel(System.Guid ACPanelPK, SecurityToken token)
		{

			W3000.Data.ACPanelHolidayMapDataCollection _result_ = ACPanelHolidayMapWrapper.GetByACPanel(ACPanelPK, token);
			if(_result_ == null)
				return null;

			return new ACPanelHolidayMapCollection(_result_);
		}

		public static W3000.Data.ACPanelHolidayMapViewCollection GetViewByACPanel(System.Guid ACPanelPK)
		{
			return GetViewByACPanel(ACPanelPK, Identity.Token);
		}

		public static W3000.Data.ACPanelHolidayMapViewCollection GetViewByACPanel(System.Guid ACPanelPK, SecurityToken token)
		{

			W3000.Data.ACPanelHolidayMapViewCollection _result_ = ACPanelHolidayMapWrapper.GetViewByACPanel(ACPanelPK, token);
			if(_result_ == null)
				return null;

			return _result_;
		}

	}

	public partial class ACSupervisory
	{
		public static Cheke.BusinessEntity.Result Purge(W3000.Data.ACSupervisoryData entity)
		{
			return Purge(entity, Identity.Token);
		}

		public static Cheke.BusinessEntity.Result Purge(W3000.Data.ACSupervisoryData entity, SecurityToken token)
		{
			if(entity != null)
			{
				entity = new W3000.Data.ACSupervisoryData(entity);
			}

			Cheke.BusinessEntity.Result _result_ = ACSupervisoryWrapper.Purge(entity, token);
			if(_result_ == null)
				return null;

			return _result_;
		}

		public static Cheke.BusinessEntity.Result Save(W3000.Data.ACSupervisoryData entity)
		{
			return Save(entity, Identity.Token);
		}

		public static Cheke.BusinessEntity.Result Save(W3000.Data.ACSupervisoryData entity, SecurityToken token)
		{
			if(entity != null)
			{
				entity = new W3000.Data.ACSupervisoryData(entity);
			}

			Cheke.BusinessEntity.Result _result_ = ACSupervisoryWrapper.Save(entity, token);
			if(_result_ == null)
				return null;

			return _result_;
		}

		public static Cheke.BusinessEntity.Result Save(W3000.Data.ACSupervisoryDataCollection list)
		{
			return Save(list, Identity.Token);
		}

		public static Cheke.BusinessEntity.Result Save(W3000.Data.ACSupervisoryDataCollection list, SecurityToken token)
		{
			if(list != null)
			{
				list = new W3000.Data.ACSupervisoryDataCollection(list);
			}

			Cheke.BusinessEntity.Result _result_ = ACSupervisoryWrapper.Save(list, token);
			if(_result_ == null)
				return null;

			return _result_;
		}

		public static ACSupervisoryCollection GetByModifiedOn(System.DateTime begin,System.DateTime end)
		{
			return GetByModifiedOn(begin,end, Identity.Token);
		}

		public static ACSupervisoryCollection GetByModifiedOn(System.DateTime begin,System.DateTime end, SecurityToken token)
		{

			W3000.Data.ACSupervisoryDataCollection _result_ = ACSupervisoryWrapper.GetByModifiedOn(begin,end, token);
			if(_result_ == null)
				return null;

			return new ACSupervisoryCollection(_result_);
		}

		public static System.Int32 GetAllCount()
		{
			return GetAllCount( Identity.Token);
		}

		public static System.Int32 GetAllCount(SecurityToken token)
		{

			System.Int32 _result_ = ACSupervisoryWrapper.GetAllCount( token);
			return _result_;
		}

		public static ACSupervisoryCollection GetAllPage(System.Int32 pageIndex,System.Int32 pageSize)
		{
			return GetAllPage(pageIndex,pageSize, Identity.Token);
		}

		public static ACSupervisoryCollection GetAllPage(System.Int32 pageIndex,System.Int32 pageSize, SecurityToken token)
		{

			W3000.Data.ACSupervisoryDataCollection _result_ = ACSupervisoryWrapper.GetAllPage(pageIndex,pageSize, token);
			if(_result_ == null)
				return null;

			return new ACSupervisoryCollection(_result_);
		}

		public static ACSupervisory GetByUK(System.Guid ACPanelPK,System.Byte PanelZoneID)
		{
			return GetByUK(ACPanelPK,PanelZoneID, Identity.Token);
		}

		public static ACSupervisory GetByUK(System.Guid ACPanelPK,System.Byte PanelZoneID, SecurityToken token)
		{

			W3000.Data.ACSupervisoryData _result_ = ACSupervisoryWrapper.GetByUK(ACPanelPK,PanelZoneID, token);
			if(_result_ == null)
				return null;

			return new ACSupervisory(_result_);
		}

		public static ACSupervisory GetByPK(System.Guid ACSupervisoryPK)
		{
			return GetByPK(ACSupervisoryPK, Identity.Token);
		}

		public static ACSupervisory GetByPK(System.Guid ACSupervisoryPK, SecurityToken token)
		{

			W3000.Data.ACSupervisoryData _result_ = ACSupervisoryWrapper.GetByPK(ACSupervisoryPK, token);
			if(_result_ == null)
				return null;

			return new ACSupervisory(_result_);
		}

		public static ACSupervisoryCollection GetAll()
		{
			return GetAll( Identity.Token);
		}

		public static ACSupervisoryCollection GetAll(SecurityToken token)
		{

			W3000.Data.ACSupervisoryDataCollection _result_ = ACSupervisoryWrapper.GetAll( token);
			if(_result_ == null)
				return null;

			return new ACSupervisoryCollection(_result_);
		}

		public static W3000.Data.ACSupervisoryViewCollection GetViewAll()
		{
			return GetViewAll( Identity.Token);
		}

		public static W3000.Data.ACSupervisoryViewCollection GetViewAll(SecurityToken token)
		{

			W3000.Data.ACSupervisoryViewCollection _result_ = ACSupervisoryWrapper.GetViewAll( token);
			if(_result_ == null)
				return null;

			return _result_;
		}

		public static ACSupervisoryCollection GetByACPanel(System.Guid ACPanelPK)
		{
			return GetByACPanel(ACPanelPK, Identity.Token);
		}

		public static ACSupervisoryCollection GetByACPanel(System.Guid ACPanelPK, SecurityToken token)
		{

			W3000.Data.ACSupervisoryDataCollection _result_ = ACSupervisoryWrapper.GetByACPanel(ACPanelPK, token);
			if(_result_ == null)
				return null;

			return new ACSupervisoryCollection(_result_);
		}

		public static W3000.Data.ACSupervisoryViewCollection GetViewByACPanel(System.Guid ACPanelPK)
		{
			return GetViewByACPanel(ACPanelPK, Identity.Token);
		}

		public static W3000.Data.ACSupervisoryViewCollection GetViewByACPanel(System.Guid ACPanelPK, SecurityToken token)
		{

			W3000.Data.ACSupervisoryViewCollection _result_ = ACSupervisoryWrapper.GetViewByACPanel(ACPanelPK, token);
			if(_result_ == null)
				return null;

			return _result_;
		}

	}

	public partial class ACTimecode
	{
		public static Cheke.BusinessEntity.Result Purge(W3000.Data.ACTimecodeData entity)
		{
			return Purge(entity, Identity.Token);
		}

		public static Cheke.BusinessEntity.Result Purge(W3000.Data.ACTimecodeData entity, SecurityToken token)
		{
			if(entity != null)
			{
				entity = new W3000.Data.ACTimecodeData(entity);
			}

			Cheke.BusinessEntity.Result _result_ = ACTimecodeWrapper.Purge(entity, token);
			if(_result_ == null)
				return null;

			return _result_;
		}

		public static Cheke.BusinessEntity.Result Save(W3000.Data.ACTimecodeData entity)
		{
			return Save(entity, Identity.Token);
		}

		public static Cheke.BusinessEntity.Result Save(W3000.Data.ACTimecodeData entity, SecurityToken token)
		{
			if(entity != null)
			{
				entity = new W3000.Data.ACTimecodeData(entity);
			}

			Cheke.BusinessEntity.Result _result_ = ACTimecodeWrapper.Save(entity, token);
			if(_result_ == null)
				return null;

			return _result_;
		}

		public static Cheke.BusinessEntity.Result Save(W3000.Data.ACTimecodeDataCollection list)
		{
			return Save(list, Identity.Token);
		}

		public static Cheke.BusinessEntity.Result Save(W3000.Data.ACTimecodeDataCollection list, SecurityToken token)
		{
			if(list != null)
			{
				list = new W3000.Data.ACTimecodeDataCollection(list);
			}

			Cheke.BusinessEntity.Result _result_ = ACTimecodeWrapper.Save(list, token);
			if(_result_ == null)
				return null;

			return _result_;
		}

		public static ACTimecodeCollection GetByModifiedOn(System.DateTime begin,System.DateTime end)
		{
			return GetByModifiedOn(begin,end, Identity.Token);
		}

		public static ACTimecodeCollection GetByModifiedOn(System.DateTime begin,System.DateTime end, SecurityToken token)
		{

			W3000.Data.ACTimecodeDataCollection _result_ = ACTimecodeWrapper.GetByModifiedOn(begin,end, token);
			if(_result_ == null)
				return null;

			return new ACTimecodeCollection(_result_);
		}

		public static ACTimecodeCollection GetByMappedACMainZone(System.Guid ACMainZonePK)
		{
			return GetByMappedACMainZone(ACMainZonePK, Identity.Token);
		}

		public static ACTimecodeCollection GetByMappedACMainZone(System.Guid ACMainZonePK, SecurityToken token)
		{

			W3000.Data.ACTimecodeDataCollection _result_ = ACTimecodeWrapper.GetByMappedACMainZone(ACMainZonePK, token);
			if(_result_ == null)
				return null;

			return new ACTimecodeCollection(_result_);
		}

		public static ACTimecodeCollection GetByMappedACInterval(System.Guid ACIntervalPK)
		{
			return GetByMappedACInterval(ACIntervalPK, Identity.Token);
		}

		public static ACTimecodeCollection GetByMappedACInterval(System.Guid ACIntervalPK, SecurityToken token)
		{

			W3000.Data.ACTimecodeDataCollection _result_ = ACTimecodeWrapper.GetByMappedACInterval(ACIntervalPK, token);
			if(_result_ == null)
				return null;

			return new ACTimecodeCollection(_result_);
		}

		public static System.Int32 GetAllCount()
		{
			return GetAllCount( Identity.Token);
		}

		public static System.Int32 GetAllCount(SecurityToken token)
		{

			System.Int32 _result_ = ACTimecodeWrapper.GetAllCount( token);
			return _result_;
		}

		public static ACTimecodeCollection GetAllPage(System.Int32 pageIndex,System.Int32 pageSize)
		{
			return GetAllPage(pageIndex,pageSize, Identity.Token);
		}

		public static ACTimecodeCollection GetAllPage(System.Int32 pageIndex,System.Int32 pageSize, SecurityToken token)
		{

			W3000.Data.ACTimecodeDataCollection _result_ = ACTimecodeWrapper.GetAllPage(pageIndex,pageSize, token);
			if(_result_ == null)
				return null;

			return new ACTimecodeCollection(_result_);
		}

		public static ACTimecode GetByUK(System.Guid BDBuildingPK,System.Int16 TCID)
		{
			return GetByUK(BDBuildingPK,TCID, Identity.Token);
		}

		public static ACTimecode GetByUK(System.Guid BDBuildingPK,System.Int16 TCID, SecurityToken token)
		{

			W3000.Data.ACTimecodeData _result_ = ACTimecodeWrapper.GetByUK(BDBuildingPK,TCID, token);
			if(_result_ == null)
				return null;

			return new ACTimecode(_result_);
		}

		public static ACTimecode GetByPK(System.Guid ACTimecodePK)
		{
			return GetByPK(ACTimecodePK, Identity.Token);
		}

		public static ACTimecode GetByPK(System.Guid ACTimecodePK, SecurityToken token)
		{

			W3000.Data.ACTimecodeData _result_ = ACTimecodeWrapper.GetByPK(ACTimecodePK, token);
			if(_result_ == null)
				return null;

			return new ACTimecode(_result_);
		}

		public static ACTimecodeCollection GetAll()
		{
			return GetAll( Identity.Token);
		}

		public static ACTimecodeCollection GetAll(SecurityToken token)
		{

			W3000.Data.ACTimecodeDataCollection _result_ = ACTimecodeWrapper.GetAll( token);
			if(_result_ == null)
				return null;

			return new ACTimecodeCollection(_result_);
		}

		public static W3000.Data.ACTimecodeViewCollection GetViewAll()
		{
			return GetViewAll( Identity.Token);
		}

		public static W3000.Data.ACTimecodeViewCollection GetViewAll(SecurityToken token)
		{

			W3000.Data.ACTimecodeViewCollection _result_ = ACTimecodeWrapper.GetViewAll( token);
			if(_result_ == null)
				return null;

			return _result_;
		}

		public static ACTimecodeCollection GetByBDBuilding(System.Guid BDBuildingPK)
		{
			return GetByBDBuilding(BDBuildingPK, Identity.Token);
		}

		public static ACTimecodeCollection GetByBDBuilding(System.Guid BDBuildingPK, SecurityToken token)
		{

			W3000.Data.ACTimecodeDataCollection _result_ = ACTimecodeWrapper.GetByBDBuilding(BDBuildingPK, token);
			if(_result_ == null)
				return null;

			return new ACTimecodeCollection(_result_);
		}

		public static W3000.Data.ACTimecodeViewCollection GetViewByBDBuilding(System.Guid BDBuildingPK)
		{
			return GetViewByBDBuilding(BDBuildingPK, Identity.Token);
		}

		public static W3000.Data.ACTimecodeViewCollection GetViewByBDBuilding(System.Guid BDBuildingPK, SecurityToken token)
		{

			W3000.Data.ACTimecodeViewCollection _result_ = ACTimecodeWrapper.GetViewByBDBuilding(BDBuildingPK, token);
			if(_result_ == null)
				return null;

			return _result_;
		}

	}

	public partial class ACTimecodeIntervalMap
	{
		public static Cheke.BusinessEntity.Result Purge(W3000.Data.ACTimecodeIntervalMapData entity)
		{
			return Purge(entity, Identity.Token);
		}

		public static Cheke.BusinessEntity.Result Purge(W3000.Data.ACTimecodeIntervalMapData entity, SecurityToken token)
		{
			if(entity != null)
			{
				entity = new W3000.Data.ACTimecodeIntervalMapData(entity);
			}

			Cheke.BusinessEntity.Result _result_ = ACTimecodeIntervalMapWrapper.Purge(entity, token);
			if(_result_ == null)
				return null;

			return _result_;
		}

		public static Cheke.BusinessEntity.Result Save(W3000.Data.ACTimecodeIntervalMapData entity)
		{
			return Save(entity, Identity.Token);
		}

		public static Cheke.BusinessEntity.Result Save(W3000.Data.ACTimecodeIntervalMapData entity, SecurityToken token)
		{
			if(entity != null)
			{
				entity = new W3000.Data.ACTimecodeIntervalMapData(entity);
			}

			Cheke.BusinessEntity.Result _result_ = ACTimecodeIntervalMapWrapper.Save(entity, token);
			if(_result_ == null)
				return null;

			return _result_;
		}

		public static Cheke.BusinessEntity.Result Save(W3000.Data.ACTimecodeIntervalMapDataCollection list)
		{
			return Save(list, Identity.Token);
		}

		public static Cheke.BusinessEntity.Result Save(W3000.Data.ACTimecodeIntervalMapDataCollection list, SecurityToken token)
		{
			if(list != null)
			{
				list = new W3000.Data.ACTimecodeIntervalMapDataCollection(list);
			}

			Cheke.BusinessEntity.Result _result_ = ACTimecodeIntervalMapWrapper.Save(list, token);
			if(_result_ == null)
				return null;

			return _result_;
		}

		public static ACTimecodeIntervalMapCollection GetByModifiedOn(System.DateTime begin,System.DateTime end)
		{
			return GetByModifiedOn(begin,end, Identity.Token);
		}

		public static ACTimecodeIntervalMapCollection GetByModifiedOn(System.DateTime begin,System.DateTime end, SecurityToken token)
		{

			W3000.Data.ACTimecodeIntervalMapDataCollection _result_ = ACTimecodeIntervalMapWrapper.GetByModifiedOn(begin,end, token);
			if(_result_ == null)
				return null;

			return new ACTimecodeIntervalMapCollection(_result_);
		}

		public static System.Int32 GetAllCount()
		{
			return GetAllCount( Identity.Token);
		}

		public static System.Int32 GetAllCount(SecurityToken token)
		{

			System.Int32 _result_ = ACTimecodeIntervalMapWrapper.GetAllCount( token);
			return _result_;
		}

		public static ACTimecodeIntervalMapCollection GetAllPage(System.Int32 pageIndex,System.Int32 pageSize)
		{
			return GetAllPage(pageIndex,pageSize, Identity.Token);
		}

		public static ACTimecodeIntervalMapCollection GetAllPage(System.Int32 pageIndex,System.Int32 pageSize, SecurityToken token)
		{

			W3000.Data.ACTimecodeIntervalMapDataCollection _result_ = ACTimecodeIntervalMapWrapper.GetAllPage(pageIndex,pageSize, token);
			if(_result_ == null)
				return null;

			return new ACTimecodeIntervalMapCollection(_result_);
		}

		public static ACTimecodeIntervalMap GetByUK(System.Guid ACTimecodePK,System.Guid ACIntervalPK)
		{
			return GetByUK(ACTimecodePK,ACIntervalPK, Identity.Token);
		}

		public static ACTimecodeIntervalMap GetByUK(System.Guid ACTimecodePK,System.Guid ACIntervalPK, SecurityToken token)
		{

			W3000.Data.ACTimecodeIntervalMapData _result_ = ACTimecodeIntervalMapWrapper.GetByUK(ACTimecodePK,ACIntervalPK, token);
			if(_result_ == null)
				return null;

			return new ACTimecodeIntervalMap(_result_);
		}

		public static ACTimecodeIntervalMap GetByPK(System.Guid ACTimecodeIntervalMapPK)
		{
			return GetByPK(ACTimecodeIntervalMapPK, Identity.Token);
		}

		public static ACTimecodeIntervalMap GetByPK(System.Guid ACTimecodeIntervalMapPK, SecurityToken token)
		{

			W3000.Data.ACTimecodeIntervalMapData _result_ = ACTimecodeIntervalMapWrapper.GetByPK(ACTimecodeIntervalMapPK, token);
			if(_result_ == null)
				return null;

			return new ACTimecodeIntervalMap(_result_);
		}

		public static ACTimecodeIntervalMapCollection GetAll()
		{
			return GetAll( Identity.Token);
		}

		public static ACTimecodeIntervalMapCollection GetAll(SecurityToken token)
		{

			W3000.Data.ACTimecodeIntervalMapDataCollection _result_ = ACTimecodeIntervalMapWrapper.GetAll( token);
			if(_result_ == null)
				return null;

			return new ACTimecodeIntervalMapCollection(_result_);
		}

		public static W3000.Data.ACTimecodeIntervalMapViewCollection GetViewAll()
		{
			return GetViewAll( Identity.Token);
		}

		public static W3000.Data.ACTimecodeIntervalMapViewCollection GetViewAll(SecurityToken token)
		{

			W3000.Data.ACTimecodeIntervalMapViewCollection _result_ = ACTimecodeIntervalMapWrapper.GetViewAll( token);
			if(_result_ == null)
				return null;

			return _result_;
		}

		public static ACTimecodeIntervalMapCollection GetByACInterval(System.Guid ACIntervalPK)
		{
			return GetByACInterval(ACIntervalPK, Identity.Token);
		}

		public static ACTimecodeIntervalMapCollection GetByACInterval(System.Guid ACIntervalPK, SecurityToken token)
		{

			W3000.Data.ACTimecodeIntervalMapDataCollection _result_ = ACTimecodeIntervalMapWrapper.GetByACInterval(ACIntervalPK, token);
			if(_result_ == null)
				return null;

			return new ACTimecodeIntervalMapCollection(_result_);
		}

		public static W3000.Data.ACTimecodeIntervalMapViewCollection GetViewByACInterval(System.Guid ACIntervalPK)
		{
			return GetViewByACInterval(ACIntervalPK, Identity.Token);
		}

		public static W3000.Data.ACTimecodeIntervalMapViewCollection GetViewByACInterval(System.Guid ACIntervalPK, SecurityToken token)
		{

			W3000.Data.ACTimecodeIntervalMapViewCollection _result_ = ACTimecodeIntervalMapWrapper.GetViewByACInterval(ACIntervalPK, token);
			if(_result_ == null)
				return null;

			return _result_;
		}

		public static ACTimecodeIntervalMapCollection GetByACTimecode(System.Guid ACTimecodePK)
		{
			return GetByACTimecode(ACTimecodePK, Identity.Token);
		}

		public static ACTimecodeIntervalMapCollection GetByACTimecode(System.Guid ACTimecodePK, SecurityToken token)
		{

			W3000.Data.ACTimecodeIntervalMapDataCollection _result_ = ACTimecodeIntervalMapWrapper.GetByACTimecode(ACTimecodePK, token);
			if(_result_ == null)
				return null;

			return new ACTimecodeIntervalMapCollection(_result_);
		}

		public static W3000.Data.ACTimecodeIntervalMapViewCollection GetViewByACTimecode(System.Guid ACTimecodePK)
		{
			return GetViewByACTimecode(ACTimecodePK, Identity.Token);
		}

		public static W3000.Data.ACTimecodeIntervalMapViewCollection GetViewByACTimecode(System.Guid ACTimecodePK, SecurityToken token)
		{

			W3000.Data.ACTimecodeIntervalMapViewCollection _result_ = ACTimecodeIntervalMapWrapper.GetViewByACTimecode(ACTimecodePK, token);
			if(_result_ == null)
				return null;

			return _result_;
		}

	}

	public partial class BDBuilding
	{
		public static Cheke.BusinessEntity.Result Purge(W3000.Data.BDBuildingData entity)
		{
			return Purge(entity, Identity.Token);
		}

		public static Cheke.BusinessEntity.Result Purge(W3000.Data.BDBuildingData entity, SecurityToken token)
		{
			if(entity != null)
			{
				entity = new W3000.Data.BDBuildingData(entity);
			}

			Cheke.BusinessEntity.Result _result_ = BDBuildingWrapper.Purge(entity, token);
			if(_result_ == null)
				return null;

			return _result_;
		}

		public static Cheke.BusinessEntity.Result Save(W3000.Data.BDBuildingData entity)
		{
			return Save(entity, Identity.Token);
		}

		public static Cheke.BusinessEntity.Result Save(W3000.Data.BDBuildingData entity, SecurityToken token)
		{
			if(entity != null)
			{
				entity = new W3000.Data.BDBuildingData(entity);
			}

			Cheke.BusinessEntity.Result _result_ = BDBuildingWrapper.Save(entity, token);
			if(_result_ == null)
				return null;

			return _result_;
		}

		public static Cheke.BusinessEntity.Result Save(W3000.Data.BDBuildingDataCollection list)
		{
			return Save(list, Identity.Token);
		}

		public static Cheke.BusinessEntity.Result Save(W3000.Data.BDBuildingDataCollection list, SecurityToken token)
		{
			if(list != null)
			{
				list = new W3000.Data.BDBuildingDataCollection(list);
			}

			Cheke.BusinessEntity.Result _result_ = BDBuildingWrapper.Save(list, token);
			if(_result_ == null)
				return null;

			return _result_;
		}

		public static BDBuildingCollection GetByCriteria(W3000.Data.CriteriaBDBuildingView criteria)
		{
			return GetByCriteria(criteria, Identity.Token);
		}

		public static BDBuildingCollection GetByCriteria(W3000.Data.CriteriaBDBuildingView criteria, SecurityToken token)
		{

			W3000.Data.BDBuildingDataCollection _result_ = BDBuildingWrapper.GetByCriteria(criteria, token);
			if(_result_ == null)
				return null;

			return new BDBuildingCollection(_result_);
		}

		public static BDBuildingCollection GetByCriteria(W3000.Data.CriteriaBDBuildingView criteria,System.Int32 pageIndex,System.Int32 pageSize)
		{
			return GetByCriteria(criteria,pageIndex,pageSize, Identity.Token);
		}

		public static BDBuildingCollection GetByCriteria(W3000.Data.CriteriaBDBuildingView criteria,System.Int32 pageIndex,System.Int32 pageSize, SecurityToken token)
		{

			W3000.Data.BDBuildingDataCollection _result_ = BDBuildingWrapper.GetByCriteria(criteria,pageIndex,pageSize, token);
			if(_result_ == null)
				return null;

			return new BDBuildingCollection(_result_);
		}

		public static System.Int32 GetCountByCriteria(W3000.Data.CriteriaBDBuildingView criteria)
		{
			return GetCountByCriteria(criteria, Identity.Token);
		}

		public static System.Int32 GetCountByCriteria(W3000.Data.CriteriaBDBuildingView criteria, SecurityToken token)
		{

			System.Int32 _result_ = BDBuildingWrapper.GetCountByCriteria(criteria, token);
			return _result_;
		}

		public static BDBuildingCollection GetBySystemTypeID(System.Int32 SystemTypeID)
		{
			return GetBySystemTypeID(SystemTypeID, Identity.Token);
		}

		public static BDBuildingCollection GetBySystemTypeID(System.Int32 SystemTypeID, SecurityToken token)
		{

			W3000.Data.BDBuildingDataCollection _result_ = BDBuildingWrapper.GetBySystemTypeID(SystemTypeID, token);
			if(_result_ == null)
				return null;

			return new BDBuildingCollection(_result_);
		}

		public static BDBuildingCollection GetByCountryID(System.Int32 CountryID)
		{
			return GetByCountryID(CountryID, Identity.Token);
		}

		public static BDBuildingCollection GetByCountryID(System.Int32 CountryID, SecurityToken token)
		{

			W3000.Data.BDBuildingDataCollection _result_ = BDBuildingWrapper.GetByCountryID(CountryID, token);
			if(_result_ == null)
				return null;

			return new BDBuildingCollection(_result_);
		}

		public static BDBuildingCollection GetByLikeStreetNumb(System.String StreetNumb)
		{
			return GetByLikeStreetNumb(StreetNumb, Identity.Token);
		}

		public static BDBuildingCollection GetByLikeStreetNumb(System.String StreetNumb, SecurityToken token)
		{

			W3000.Data.BDBuildingDataCollection _result_ = BDBuildingWrapper.GetByLikeStreetNumb(StreetNumb, token);
			if(_result_ == null)
				return null;

			return new BDBuildingCollection(_result_);
		}

		public static BDBuildingCollection GetByLikeStreetName(System.String StreetName)
		{
			return GetByLikeStreetName(StreetName, Identity.Token);
		}

		public static BDBuildingCollection GetByLikeStreetName(System.String StreetName, SecurityToken token)
		{

			W3000.Data.BDBuildingDataCollection _result_ = BDBuildingWrapper.GetByLikeStreetName(StreetName, token);
			if(_result_ == null)
				return null;

			return new BDBuildingCollection(_result_);
		}

		public static BDBuildingCollection GetByMappedUsrAccount(System.Guid UsrAccountPK)
		{
			return GetByMappedUsrAccount(UsrAccountPK, Identity.Token);
		}

		public static BDBuildingCollection GetByMappedUsrAccount(System.Guid UsrAccountPK, SecurityToken token)
		{

			W3000.Data.BDBuildingDataCollection _result_ = BDBuildingWrapper.GetByMappedUsrAccount(UsrAccountPK, token);
			if(_result_ == null)
				return null;

			return new BDBuildingCollection(_result_);
		}

		public static BDBuildingCollection GetByMappedUtilHoliday(System.Guid UtilHolidayPK)
		{
			return GetByMappedUtilHoliday(UtilHolidayPK, Identity.Token);
		}

		public static BDBuildingCollection GetByMappedUtilHoliday(System.Guid UtilHolidayPK, SecurityToken token)
		{

			W3000.Data.BDBuildingDataCollection _result_ = BDBuildingWrapper.GetByMappedUtilHoliday(UtilHolidayPK, token);
			if(_result_ == null)
				return null;

			return new BDBuildingCollection(_result_);
		}

		public static BDBuildingCollection GetByMappedACCardHolder(System.Guid ACCardHolderPK)
		{
			return GetByMappedACCardHolder(ACCardHolderPK, Identity.Token);
		}

		public static BDBuildingCollection GetByMappedACCardHolder(System.Guid ACCardHolderPK, SecurityToken token)
		{

			W3000.Data.BDBuildingDataCollection _result_ = BDBuildingWrapper.GetByMappedACCardHolder(ACCardHolderPK, token);
			if(_result_ == null)
				return null;

			return new BDBuildingCollection(_result_);
		}

		public static System.Int32 GetAllCount()
		{
			return GetAllCount( Identity.Token);
		}

		public static System.Int32 GetAllCount(SecurityToken token)
		{

			System.Int32 _result_ = BDBuildingWrapper.GetAllCount( token);
			return _result_;
		}

		public static BDBuildingCollection GetAllPage(System.Int32 pageIndex,System.Int32 pageSize)
		{
			return GetAllPage(pageIndex,pageSize, Identity.Token);
		}

		public static BDBuildingCollection GetAllPage(System.Int32 pageIndex,System.Int32 pageSize, SecurityToken token)
		{

			W3000.Data.BDBuildingDataCollection _result_ = BDBuildingWrapper.GetAllPage(pageIndex,pageSize, token);
			if(_result_ == null)
				return null;

			return new BDBuildingCollection(_result_);
		}

		public static BDBuilding GetByAddress1(System.String Address1)
		{
			return GetByAddress1(Address1, Identity.Token);
		}

		public static BDBuilding GetByAddress1(System.String Address1, SecurityToken token)
		{

			W3000.Data.BDBuildingData _result_ = BDBuildingWrapper.GetByAddress1(Address1, token);
			if(_result_ == null)
				return null;

			return new BDBuilding(_result_);
		}

		public static BDBuilding GetByBuildingID(System.Int32 BuildingID)
		{
			return GetByBuildingID(BuildingID, Identity.Token);
		}

		public static BDBuilding GetByBuildingID(System.Int32 BuildingID, SecurityToken token)
		{

			W3000.Data.BDBuildingData _result_ = BDBuildingWrapper.GetByBuildingID(BuildingID, token);
			if(_result_ == null)
				return null;

			return new BDBuilding(_result_);
		}

		public static BDBuilding GetByPK(System.Guid BDBuildingPK)
		{
			return GetByPK(BDBuildingPK, Identity.Token);
		}

		public static BDBuilding GetByPK(System.Guid BDBuildingPK, SecurityToken token)
		{

			W3000.Data.BDBuildingData _result_ = BDBuildingWrapper.GetByPK(BDBuildingPK, token);
			if(_result_ == null)
				return null;

			return new BDBuilding(_result_);
		}

		public static BDBuildingCollection GetAll()
		{
			return GetAll( Identity.Token);
		}

		public static BDBuildingCollection GetAll(SecurityToken token)
		{

			W3000.Data.BDBuildingDataCollection _result_ = BDBuildingWrapper.GetAll( token);
			if(_result_ == null)
				return null;

			return new BDBuildingCollection(_result_);
		}

		public static W3000.Data.BDBuildingViewCollection GetViewAll()
		{
			return GetViewAll( Identity.Token);
		}

		public static W3000.Data.BDBuildingViewCollection GetViewAll(SecurityToken token)
		{

			W3000.Data.BDBuildingViewCollection _result_ = BDBuildingWrapper.GetViewAll( token);
			if(_result_ == null)
				return null;

			return _result_;
		}

	}

	public partial class BDBuildingHolidayMap
	{
		public static Cheke.BusinessEntity.Result Purge(W3000.Data.BDBuildingHolidayMapData entity)
		{
			return Purge(entity, Identity.Token);
		}

		public static Cheke.BusinessEntity.Result Purge(W3000.Data.BDBuildingHolidayMapData entity, SecurityToken token)
		{
			if(entity != null)
			{
				entity = new W3000.Data.BDBuildingHolidayMapData(entity);
			}

			Cheke.BusinessEntity.Result _result_ = BDBuildingHolidayMapWrapper.Purge(entity, token);
			if(_result_ == null)
				return null;

			return _result_;
		}

		public static Cheke.BusinessEntity.Result Save(W3000.Data.BDBuildingHolidayMapData entity)
		{
			return Save(entity, Identity.Token);
		}

		public static Cheke.BusinessEntity.Result Save(W3000.Data.BDBuildingHolidayMapData entity, SecurityToken token)
		{
			if(entity != null)
			{
				entity = new W3000.Data.BDBuildingHolidayMapData(entity);
			}

			Cheke.BusinessEntity.Result _result_ = BDBuildingHolidayMapWrapper.Save(entity, token);
			if(_result_ == null)
				return null;

			return _result_;
		}

		public static Cheke.BusinessEntity.Result Save(W3000.Data.BDBuildingHolidayMapDataCollection list)
		{
			return Save(list, Identity.Token);
		}

		public static Cheke.BusinessEntity.Result Save(W3000.Data.BDBuildingHolidayMapDataCollection list, SecurityToken token)
		{
			if(list != null)
			{
				list = new W3000.Data.BDBuildingHolidayMapDataCollection(list);
			}

			Cheke.BusinessEntity.Result _result_ = BDBuildingHolidayMapWrapper.Save(list, token);
			if(_result_ == null)
				return null;

			return _result_;
		}

		public static System.Int32 GetAllCount()
		{
			return GetAllCount( Identity.Token);
		}

		public static System.Int32 GetAllCount(SecurityToken token)
		{

			System.Int32 _result_ = BDBuildingHolidayMapWrapper.GetAllCount( token);
			return _result_;
		}

		public static BDBuildingHolidayMapCollection GetAllPage(System.Int32 pageIndex,System.Int32 pageSize)
		{
			return GetAllPage(pageIndex,pageSize, Identity.Token);
		}

		public static BDBuildingHolidayMapCollection GetAllPage(System.Int32 pageIndex,System.Int32 pageSize, SecurityToken token)
		{

			W3000.Data.BDBuildingHolidayMapDataCollection _result_ = BDBuildingHolidayMapWrapper.GetAllPage(pageIndex,pageSize, token);
			if(_result_ == null)
				return null;

			return new BDBuildingHolidayMapCollection(_result_);
		}

		public static BDBuildingHolidayMap GetByUK(System.Guid BDBuildingPK,System.Guid UtilHolidayPK)
		{
			return GetByUK(BDBuildingPK,UtilHolidayPK, Identity.Token);
		}

		public static BDBuildingHolidayMap GetByUK(System.Guid BDBuildingPK,System.Guid UtilHolidayPK, SecurityToken token)
		{

			W3000.Data.BDBuildingHolidayMapData _result_ = BDBuildingHolidayMapWrapper.GetByUK(BDBuildingPK,UtilHolidayPK, token);
			if(_result_ == null)
				return null;

			return new BDBuildingHolidayMap(_result_);
		}

		public static BDBuildingHolidayMap GetByPK(System.Guid BDBuildingHolidayMapPK)
		{
			return GetByPK(BDBuildingHolidayMapPK, Identity.Token);
		}

		public static BDBuildingHolidayMap GetByPK(System.Guid BDBuildingHolidayMapPK, SecurityToken token)
		{

			W3000.Data.BDBuildingHolidayMapData _result_ = BDBuildingHolidayMapWrapper.GetByPK(BDBuildingHolidayMapPK, token);
			if(_result_ == null)
				return null;

			return new BDBuildingHolidayMap(_result_);
		}

		public static BDBuildingHolidayMapCollection GetAll()
		{
			return GetAll( Identity.Token);
		}

		public static BDBuildingHolidayMapCollection GetAll(SecurityToken token)
		{

			W3000.Data.BDBuildingHolidayMapDataCollection _result_ = BDBuildingHolidayMapWrapper.GetAll( token);
			if(_result_ == null)
				return null;

			return new BDBuildingHolidayMapCollection(_result_);
		}

		public static W3000.Data.BDBuildingHolidayMapViewCollection GetViewAll()
		{
			return GetViewAll( Identity.Token);
		}

		public static W3000.Data.BDBuildingHolidayMapViewCollection GetViewAll(SecurityToken token)
		{

			W3000.Data.BDBuildingHolidayMapViewCollection _result_ = BDBuildingHolidayMapWrapper.GetViewAll( token);
			if(_result_ == null)
				return null;

			return _result_;
		}

		public static BDBuildingHolidayMapCollection GetByBDBuilding(System.Guid BDBuildingPK)
		{
			return GetByBDBuilding(BDBuildingPK, Identity.Token);
		}

		public static BDBuildingHolidayMapCollection GetByBDBuilding(System.Guid BDBuildingPK, SecurityToken token)
		{

			W3000.Data.BDBuildingHolidayMapDataCollection _result_ = BDBuildingHolidayMapWrapper.GetByBDBuilding(BDBuildingPK, token);
			if(_result_ == null)
				return null;

			return new BDBuildingHolidayMapCollection(_result_);
		}

		public static W3000.Data.BDBuildingHolidayMapViewCollection GetViewByBDBuilding(System.Guid BDBuildingPK)
		{
			return GetViewByBDBuilding(BDBuildingPK, Identity.Token);
		}

		public static W3000.Data.BDBuildingHolidayMapViewCollection GetViewByBDBuilding(System.Guid BDBuildingPK, SecurityToken token)
		{

			W3000.Data.BDBuildingHolidayMapViewCollection _result_ = BDBuildingHolidayMapWrapper.GetViewByBDBuilding(BDBuildingPK, token);
			if(_result_ == null)
				return null;

			return _result_;
		}

		public static BDBuildingHolidayMapCollection GetByUtilHoliday(System.Guid UtilHolidayPK)
		{
			return GetByUtilHoliday(UtilHolidayPK, Identity.Token);
		}

		public static BDBuildingHolidayMapCollection GetByUtilHoliday(System.Guid UtilHolidayPK, SecurityToken token)
		{

			W3000.Data.BDBuildingHolidayMapDataCollection _result_ = BDBuildingHolidayMapWrapper.GetByUtilHoliday(UtilHolidayPK, token);
			if(_result_ == null)
				return null;

			return new BDBuildingHolidayMapCollection(_result_);
		}

		public static W3000.Data.BDBuildingHolidayMapViewCollection GetViewByUtilHoliday(System.Guid UtilHolidayPK)
		{
			return GetViewByUtilHoliday(UtilHolidayPK, Identity.Token);
		}

		public static W3000.Data.BDBuildingHolidayMapViewCollection GetViewByUtilHoliday(System.Guid UtilHolidayPK, SecurityToken token)
		{

			W3000.Data.BDBuildingHolidayMapViewCollection _result_ = BDBuildingHolidayMapWrapper.GetViewByUtilHoliday(UtilHolidayPK, token);
			if(_result_ == null)
				return null;

			return _result_;
		}

	}

	public partial class BDTenant
	{
		public static Cheke.BusinessEntity.Result Purge(W3000.Data.BDTenantData entity)
		{
			return Purge(entity, Identity.Token);
		}

		public static Cheke.BusinessEntity.Result Purge(W3000.Data.BDTenantData entity, SecurityToken token)
		{
			if(entity != null)
			{
				entity = new W3000.Data.BDTenantData(entity);
			}

			Cheke.BusinessEntity.Result _result_ = BDTenantWrapper.Purge(entity, token);
			if(_result_ == null)
				return null;

			return _result_;
		}

		public static Cheke.BusinessEntity.Result Save(W3000.Data.BDTenantData entity)
		{
			return Save(entity, Identity.Token);
		}

		public static Cheke.BusinessEntity.Result Save(W3000.Data.BDTenantData entity, SecurityToken token)
		{
			if(entity != null)
			{
				entity = new W3000.Data.BDTenantData(entity);
			}

			Cheke.BusinessEntity.Result _result_ = BDTenantWrapper.Save(entity, token);
			if(_result_ == null)
				return null;

			return _result_;
		}

		public static Cheke.BusinessEntity.Result Save(W3000.Data.BDTenantDataCollection list)
		{
			return Save(list, Identity.Token);
		}

		public static Cheke.BusinessEntity.Result Save(W3000.Data.BDTenantDataCollection list, SecurityToken token)
		{
			if(list != null)
			{
				list = new W3000.Data.BDTenantDataCollection(list);
			}

			Cheke.BusinessEntity.Result _result_ = BDTenantWrapper.Save(list, token);
			if(_result_ == null)
				return null;

			return _result_;
		}

		public static BDTenantCollection GetBySystemTypeID(System.Int32 SystemTypeID)
		{
			return GetBySystemTypeID(SystemTypeID, Identity.Token);
		}

		public static BDTenantCollection GetBySystemTypeID(System.Int32 SystemTypeID, SecurityToken token)
		{

			W3000.Data.BDTenantDataCollection _result_ = BDTenantWrapper.GetBySystemTypeID(SystemTypeID, token);
			if(_result_ == null)
				return null;

			return new BDTenantCollection(_result_);
		}

		public static BDTenantCollection GetByModifiedOn(System.DateTime begin,System.DateTime end)
		{
			return GetByModifiedOn(begin,end, Identity.Token);
		}

		public static BDTenantCollection GetByModifiedOn(System.DateTime begin,System.DateTime end, SecurityToken token)
		{

			W3000.Data.BDTenantDataCollection _result_ = BDTenantWrapper.GetByModifiedOn(begin,end, token);
			if(_result_ == null)
				return null;

			return new BDTenantCollection(_result_);
		}

		public static BDTenantCollection GetByMappedUsrAccount(System.Guid UsrAccountPK)
		{
			return GetByMappedUsrAccount(UsrAccountPK, Identity.Token);
		}

		public static BDTenantCollection GetByMappedUsrAccount(System.Guid UsrAccountPK, SecurityToken token)
		{

			W3000.Data.BDTenantDataCollection _result_ = BDTenantWrapper.GetByMappedUsrAccount(UsrAccountPK, token);
			if(_result_ == null)
				return null;

			return new BDTenantCollection(_result_);
		}

		public static BDTenantCollection GetByMappedUtilHoliday(System.Guid UtilHolidayPK)
		{
			return GetByMappedUtilHoliday(UtilHolidayPK, Identity.Token);
		}

		public static BDTenantCollection GetByMappedUtilHoliday(System.Guid UtilHolidayPK, SecurityToken token)
		{

			W3000.Data.BDTenantDataCollection _result_ = BDTenantWrapper.GetByMappedUtilHoliday(UtilHolidayPK, token);
			if(_result_ == null)
				return null;

			return new BDTenantCollection(_result_);
		}

		public static System.Int32 GetAllCount()
		{
			return GetAllCount( Identity.Token);
		}

		public static System.Int32 GetAllCount(SecurityToken token)
		{

			System.Int32 _result_ = BDTenantWrapper.GetAllCount( token);
			return _result_;
		}

		public static BDTenantCollection GetAllPage(System.Int32 pageIndex,System.Int32 pageSize)
		{
			return GetAllPage(pageIndex,pageSize, Identity.Token);
		}

		public static BDTenantCollection GetAllPage(System.Int32 pageIndex,System.Int32 pageSize, SecurityToken token)
		{

			W3000.Data.BDTenantDataCollection _result_ = BDTenantWrapper.GetAllPage(pageIndex,pageSize, token);
			if(_result_ == null)
				return null;

			return new BDTenantCollection(_result_);
		}

		public static BDTenant GetByUK(System.Guid BDBuildingPK,System.String Tenant)
		{
			return GetByUK(BDBuildingPK,Tenant, Identity.Token);
		}

		public static BDTenant GetByUK(System.Guid BDBuildingPK,System.String Tenant, SecurityToken token)
		{

			W3000.Data.BDTenantData _result_ = BDTenantWrapper.GetByUK(BDBuildingPK,Tenant, token);
			if(_result_ == null)
				return null;

			return new BDTenant(_result_);
		}

		public static BDTenant GetByPK(System.Guid BDTenantPK)
		{
			return GetByPK(BDTenantPK, Identity.Token);
		}

		public static BDTenant GetByPK(System.Guid BDTenantPK, SecurityToken token)
		{

			W3000.Data.BDTenantData _result_ = BDTenantWrapper.GetByPK(BDTenantPK, token);
			if(_result_ == null)
				return null;

			return new BDTenant(_result_);
		}

		public static BDTenantCollection GetAll()
		{
			return GetAll( Identity.Token);
		}

		public static BDTenantCollection GetAll(SecurityToken token)
		{

			W3000.Data.BDTenantDataCollection _result_ = BDTenantWrapper.GetAll( token);
			if(_result_ == null)
				return null;

			return new BDTenantCollection(_result_);
		}

		public static W3000.Data.BDTenantViewCollection GetViewAll()
		{
			return GetViewAll( Identity.Token);
		}

		public static W3000.Data.BDTenantViewCollection GetViewAll(SecurityToken token)
		{

			W3000.Data.BDTenantViewCollection _result_ = BDTenantWrapper.GetViewAll( token);
			if(_result_ == null)
				return null;

			return _result_;
		}

		public static BDTenantCollection GetByBDBuilding(System.Guid BDBuildingPK)
		{
			return GetByBDBuilding(BDBuildingPK, Identity.Token);
		}

		public static BDTenantCollection GetByBDBuilding(System.Guid BDBuildingPK, SecurityToken token)
		{

			W3000.Data.BDTenantDataCollection _result_ = BDTenantWrapper.GetByBDBuilding(BDBuildingPK, token);
			if(_result_ == null)
				return null;

			return new BDTenantCollection(_result_);
		}

		public static W3000.Data.BDTenantViewCollection GetViewByBDBuilding(System.Guid BDBuildingPK)
		{
			return GetViewByBDBuilding(BDBuildingPK, Identity.Token);
		}

		public static W3000.Data.BDTenantViewCollection GetViewByBDBuilding(System.Guid BDBuildingPK, SecurityToken token)
		{

			W3000.Data.BDTenantViewCollection _result_ = BDTenantWrapper.GetViewByBDBuilding(BDBuildingPK, token);
			if(_result_ == null)
				return null;

			return _result_;
		}

	}

	public partial class BDTenantHolidayMap
	{
		public static Cheke.BusinessEntity.Result Purge(W3000.Data.BDTenantHolidayMapData entity)
		{
			return Purge(entity, Identity.Token);
		}

		public static Cheke.BusinessEntity.Result Purge(W3000.Data.BDTenantHolidayMapData entity, SecurityToken token)
		{
			if(entity != null)
			{
				entity = new W3000.Data.BDTenantHolidayMapData(entity);
			}

			Cheke.BusinessEntity.Result _result_ = BDTenantHolidayMapWrapper.Purge(entity, token);
			if(_result_ == null)
				return null;

			return _result_;
		}

		public static Cheke.BusinessEntity.Result Save(W3000.Data.BDTenantHolidayMapData entity)
		{
			return Save(entity, Identity.Token);
		}

		public static Cheke.BusinessEntity.Result Save(W3000.Data.BDTenantHolidayMapData entity, SecurityToken token)
		{
			if(entity != null)
			{
				entity = new W3000.Data.BDTenantHolidayMapData(entity);
			}

			Cheke.BusinessEntity.Result _result_ = BDTenantHolidayMapWrapper.Save(entity, token);
			if(_result_ == null)
				return null;

			return _result_;
		}

		public static Cheke.BusinessEntity.Result Save(W3000.Data.BDTenantHolidayMapDataCollection list)
		{
			return Save(list, Identity.Token);
		}

		public static Cheke.BusinessEntity.Result Save(W3000.Data.BDTenantHolidayMapDataCollection list, SecurityToken token)
		{
			if(list != null)
			{
				list = new W3000.Data.BDTenantHolidayMapDataCollection(list);
			}

			Cheke.BusinessEntity.Result _result_ = BDTenantHolidayMapWrapper.Save(list, token);
			if(_result_ == null)
				return null;

			return _result_;
		}

		public static System.Int32 GetAllCount()
		{
			return GetAllCount( Identity.Token);
		}

		public static System.Int32 GetAllCount(SecurityToken token)
		{

			System.Int32 _result_ = BDTenantHolidayMapWrapper.GetAllCount( token);
			return _result_;
		}

		public static BDTenantHolidayMapCollection GetAllPage(System.Int32 pageIndex,System.Int32 pageSize)
		{
			return GetAllPage(pageIndex,pageSize, Identity.Token);
		}

		public static BDTenantHolidayMapCollection GetAllPage(System.Int32 pageIndex,System.Int32 pageSize, SecurityToken token)
		{

			W3000.Data.BDTenantHolidayMapDataCollection _result_ = BDTenantHolidayMapWrapper.GetAllPage(pageIndex,pageSize, token);
			if(_result_ == null)
				return null;

			return new BDTenantHolidayMapCollection(_result_);
		}

		public static BDTenantHolidayMap GetByUK(System.Guid BDTenantPK,System.Guid UtilHolidayPK)
		{
			return GetByUK(BDTenantPK,UtilHolidayPK, Identity.Token);
		}

		public static BDTenantHolidayMap GetByUK(System.Guid BDTenantPK,System.Guid UtilHolidayPK, SecurityToken token)
		{

			W3000.Data.BDTenantHolidayMapData _result_ = BDTenantHolidayMapWrapper.GetByUK(BDTenantPK,UtilHolidayPK, token);
			if(_result_ == null)
				return null;

			return new BDTenantHolidayMap(_result_);
		}

		public static BDTenantHolidayMap GetByPK(System.Guid BDTenantHolidayMapPK)
		{
			return GetByPK(BDTenantHolidayMapPK, Identity.Token);
		}

		public static BDTenantHolidayMap GetByPK(System.Guid BDTenantHolidayMapPK, SecurityToken token)
		{

			W3000.Data.BDTenantHolidayMapData _result_ = BDTenantHolidayMapWrapper.GetByPK(BDTenantHolidayMapPK, token);
			if(_result_ == null)
				return null;

			return new BDTenantHolidayMap(_result_);
		}

		public static BDTenantHolidayMapCollection GetAll()
		{
			return GetAll( Identity.Token);
		}

		public static BDTenantHolidayMapCollection GetAll(SecurityToken token)
		{

			W3000.Data.BDTenantHolidayMapDataCollection _result_ = BDTenantHolidayMapWrapper.GetAll( token);
			if(_result_ == null)
				return null;

			return new BDTenantHolidayMapCollection(_result_);
		}

		public static W3000.Data.BDTenantHolidayMapViewCollection GetViewAll()
		{
			return GetViewAll( Identity.Token);
		}

		public static W3000.Data.BDTenantHolidayMapViewCollection GetViewAll(SecurityToken token)
		{

			W3000.Data.BDTenantHolidayMapViewCollection _result_ = BDTenantHolidayMapWrapper.GetViewAll( token);
			if(_result_ == null)
				return null;

			return _result_;
		}

		public static BDTenantHolidayMapCollection GetByBDTenant(System.Guid BDTenantPK)
		{
			return GetByBDTenant(BDTenantPK, Identity.Token);
		}

		public static BDTenantHolidayMapCollection GetByBDTenant(System.Guid BDTenantPK, SecurityToken token)
		{

			W3000.Data.BDTenantHolidayMapDataCollection _result_ = BDTenantHolidayMapWrapper.GetByBDTenant(BDTenantPK, token);
			if(_result_ == null)
				return null;

			return new BDTenantHolidayMapCollection(_result_);
		}

		public static W3000.Data.BDTenantHolidayMapViewCollection GetViewByBDTenant(System.Guid BDTenantPK)
		{
			return GetViewByBDTenant(BDTenantPK, Identity.Token);
		}

		public static W3000.Data.BDTenantHolidayMapViewCollection GetViewByBDTenant(System.Guid BDTenantPK, SecurityToken token)
		{

			W3000.Data.BDTenantHolidayMapViewCollection _result_ = BDTenantHolidayMapWrapper.GetViewByBDTenant(BDTenantPK, token);
			if(_result_ == null)
				return null;

			return _result_;
		}

		public static BDTenantHolidayMapCollection GetByUtilHoliday(System.Guid UtilHolidayPK)
		{
			return GetByUtilHoliday(UtilHolidayPK, Identity.Token);
		}

		public static BDTenantHolidayMapCollection GetByUtilHoliday(System.Guid UtilHolidayPK, SecurityToken token)
		{

			W3000.Data.BDTenantHolidayMapDataCollection _result_ = BDTenantHolidayMapWrapper.GetByUtilHoliday(UtilHolidayPK, token);
			if(_result_ == null)
				return null;

			return new BDTenantHolidayMapCollection(_result_);
		}

		public static W3000.Data.BDTenantHolidayMapViewCollection GetViewByUtilHoliday(System.Guid UtilHolidayPK)
		{
			return GetViewByUtilHoliday(UtilHolidayPK, Identity.Token);
		}

		public static W3000.Data.BDTenantHolidayMapViewCollection GetViewByUtilHoliday(System.Guid UtilHolidayPK, SecurityToken token)
		{

			W3000.Data.BDTenantHolidayMapViewCollection _result_ = BDTenantHolidayMapWrapper.GetViewByUtilHoliday(UtilHolidayPK, token);
			if(_result_ == null)
				return null;

			return _result_;
		}

	}

	public partial class BDVisitor
	{
		public static Cheke.BusinessEntity.Result Purge(W3000.Data.BDVisitorData entity)
		{
			return Purge(entity, Identity.Token);
		}

		public static Cheke.BusinessEntity.Result Purge(W3000.Data.BDVisitorData entity, SecurityToken token)
		{
			if(entity != null)
			{
				entity = new W3000.Data.BDVisitorData(entity);
			}

			Cheke.BusinessEntity.Result _result_ = BDVisitorWrapper.Purge(entity, token);
			if(_result_ == null)
				return null;

			return _result_;
		}

		public static Cheke.BusinessEntity.Result Save(W3000.Data.BDVisitorData entity)
		{
			return Save(entity, Identity.Token);
		}

		public static Cheke.BusinessEntity.Result Save(W3000.Data.BDVisitorData entity, SecurityToken token)
		{
			if(entity != null)
			{
				entity = new W3000.Data.BDVisitorData(entity);
			}

			Cheke.BusinessEntity.Result _result_ = BDVisitorWrapper.Save(entity, token);
			if(_result_ == null)
				return null;

			return _result_;
		}

		public static Cheke.BusinessEntity.Result Save(W3000.Data.BDVisitorDataCollection list)
		{
			return Save(list, Identity.Token);
		}

		public static Cheke.BusinessEntity.Result Save(W3000.Data.BDVisitorDataCollection list, SecurityToken token)
		{
			if(list != null)
			{
				list = new W3000.Data.BDVisitorDataCollection(list);
			}

			Cheke.BusinessEntity.Result _result_ = BDVisitorWrapper.Save(list, token);
			if(_result_ == null)
				return null;

			return _result_;
		}

		public static BDVisitorCollection GetByValidThru(System.DateTime begin,System.DateTime end)
		{
			return GetByValidThru(begin,end, Identity.Token);
		}

		public static BDVisitorCollection GetByValidThru(System.DateTime begin,System.DateTime end, SecurityToken token)
		{

			W3000.Data.BDVisitorDataCollection _result_ = BDVisitorWrapper.GetByValidThru(begin,end, token);
			if(_result_ == null)
				return null;

			return new BDVisitorCollection(_result_);
		}

		public static BDVisitorCollection GetByLikeLastName(System.String LastName)
		{
			return GetByLikeLastName(LastName, Identity.Token);
		}

		public static BDVisitorCollection GetByLikeLastName(System.String LastName, SecurityToken token)
		{

			W3000.Data.BDVisitorDataCollection _result_ = BDVisitorWrapper.GetByLikeLastName(LastName, token);
			if(_result_ == null)
				return null;

			return new BDVisitorCollection(_result_);
		}

		public static BDVisitorCollection GetByModifiedOn(System.DateTime begin,System.DateTime end)
		{
			return GetByModifiedOn(begin,end, Identity.Token);
		}

		public static BDVisitorCollection GetByModifiedOn(System.DateTime begin,System.DateTime end, SecurityToken token)
		{

			W3000.Data.BDVisitorDataCollection _result_ = BDVisitorWrapper.GetByModifiedOn(begin,end, token);
			if(_result_ == null)
				return null;

			return new BDVisitorCollection(_result_);
		}

		public static System.Int32 GetAllCount()
		{
			return GetAllCount( Identity.Token);
		}

		public static System.Int32 GetAllCount(SecurityToken token)
		{

			System.Int32 _result_ = BDVisitorWrapper.GetAllCount( token);
			return _result_;
		}

		public static BDVisitorCollection GetAllPage(System.Int32 pageIndex,System.Int32 pageSize)
		{
			return GetAllPage(pageIndex,pageSize, Identity.Token);
		}

		public static BDVisitorCollection GetAllPage(System.Int32 pageIndex,System.Int32 pageSize, SecurityToken token)
		{

			W3000.Data.BDVisitorDataCollection _result_ = BDVisitorWrapper.GetAllPage(pageIndex,pageSize, token);
			if(_result_ == null)
				return null;

			return new BDVisitorCollection(_result_);
		}

		public static BDVisitor GetByPK(System.Guid BDVisitorPK)
		{
			return GetByPK(BDVisitorPK, Identity.Token);
		}

		public static BDVisitor GetByPK(System.Guid BDVisitorPK, SecurityToken token)
		{

			W3000.Data.BDVisitorData _result_ = BDVisitorWrapper.GetByPK(BDVisitorPK, token);
			if(_result_ == null)
				return null;

			return new BDVisitor(_result_);
		}

		public static BDVisitorCollection GetAll()
		{
			return GetAll( Identity.Token);
		}

		public static BDVisitorCollection GetAll(SecurityToken token)
		{

			W3000.Data.BDVisitorDataCollection _result_ = BDVisitorWrapper.GetAll( token);
			if(_result_ == null)
				return null;

			return new BDVisitorCollection(_result_);
		}

		public static W3000.Data.BDVisitorViewCollection GetViewAll()
		{
			return GetViewAll( Identity.Token);
		}

		public static W3000.Data.BDVisitorViewCollection GetViewAll(SecurityToken token)
		{

			W3000.Data.BDVisitorViewCollection _result_ = BDVisitorWrapper.GetViewAll( token);
			if(_result_ == null)
				return null;

			return _result_;
		}

		public static BDVisitorCollection GetByBDTenant(System.Guid BDTenantPK)
		{
			return GetByBDTenant(BDTenantPK, Identity.Token);
		}

		public static BDVisitorCollection GetByBDTenant(System.Guid BDTenantPK, SecurityToken token)
		{

			W3000.Data.BDVisitorDataCollection _result_ = BDVisitorWrapper.GetByBDTenant(BDTenantPK, token);
			if(_result_ == null)
				return null;

			return new BDVisitorCollection(_result_);
		}

		public static W3000.Data.BDVisitorViewCollection GetViewByBDTenant(System.Guid BDTenantPK)
		{
			return GetViewByBDTenant(BDTenantPK, Identity.Token);
		}

		public static W3000.Data.BDVisitorViewCollection GetViewByBDTenant(System.Guid BDTenantPK, SecurityToken token)
		{

			W3000.Data.BDVisitorViewCollection _result_ = BDVisitorWrapper.GetViewByBDTenant(BDTenantPK, token);
			if(_result_ == null)
				return null;

			return _result_;
		}

	}

	public partial class LogDBDeleteActivity
	{
		public static Cheke.BusinessEntity.Result Purge(W3000.Data.LogDBDeleteActivityData entity)
		{
			return Purge(entity, Identity.Token);
		}

		public static Cheke.BusinessEntity.Result Purge(W3000.Data.LogDBDeleteActivityData entity, SecurityToken token)
		{
			if(entity != null)
			{
				entity = new W3000.Data.LogDBDeleteActivityData(entity);
			}

			Cheke.BusinessEntity.Result _result_ = LogDBDeleteActivityWrapper.Purge(entity, token);
			if(_result_ == null)
				return null;

			return _result_;
		}

		public static Cheke.BusinessEntity.Result Save(W3000.Data.LogDBDeleteActivityData entity)
		{
			return Save(entity, Identity.Token);
		}

		public static Cheke.BusinessEntity.Result Save(W3000.Data.LogDBDeleteActivityData entity, SecurityToken token)
		{
			if(entity != null)
			{
				entity = new W3000.Data.LogDBDeleteActivityData(entity);
			}

			Cheke.BusinessEntity.Result _result_ = LogDBDeleteActivityWrapper.Save(entity, token);
			if(_result_ == null)
				return null;

			return _result_;
		}

		public static Cheke.BusinessEntity.Result Save(W3000.Data.LogDBDeleteActivityDataCollection list)
		{
			return Save(list, Identity.Token);
		}

		public static Cheke.BusinessEntity.Result Save(W3000.Data.LogDBDeleteActivityDataCollection list, SecurityToken token)
		{
			if(list != null)
			{
				list = new W3000.Data.LogDBDeleteActivityDataCollection(list);
			}

			Cheke.BusinessEntity.Result _result_ = LogDBDeleteActivityWrapper.Save(list, token);
			if(_result_ == null)
				return null;

			return _result_;
		}

		public static LogDBDeleteActivityCollection GetByLogDateTime(System.DateTime begin,System.DateTime end)
		{
			return GetByLogDateTime(begin,end, Identity.Token);
		}

		public static LogDBDeleteActivityCollection GetByLogDateTime(System.DateTime begin,System.DateTime end, SecurityToken token)
		{

			W3000.Data.LogDBDeleteActivityDataCollection _result_ = LogDBDeleteActivityWrapper.GetByLogDateTime(begin,end, token);
			if(_result_ == null)
				return null;

			return new LogDBDeleteActivityCollection(_result_);
		}

		public static LogDBDeleteActivityCollection GetByLogDateTime(System.DateTime begin,System.DateTime end,System.String tableName)
		{
			return GetByLogDateTime(begin,end,tableName, Identity.Token);
		}

		public static LogDBDeleteActivityCollection GetByLogDateTime(System.DateTime begin,System.DateTime end,System.String tableName, SecurityToken token)
		{

			W3000.Data.LogDBDeleteActivityDataCollection _result_ = LogDBDeleteActivityWrapper.GetByLogDateTime(begin,end,tableName, token);
			if(_result_ == null)
				return null;

			return new LogDBDeleteActivityCollection(_result_);
		}

		public static LogDBDeleteActivity GetByPK(System.Guid LogDBDeleteActivityPK)
		{
			return GetByPK(LogDBDeleteActivityPK, Identity.Token);
		}

		public static LogDBDeleteActivity GetByPK(System.Guid LogDBDeleteActivityPK, SecurityToken token)
		{

			W3000.Data.LogDBDeleteActivityData _result_ = LogDBDeleteActivityWrapper.GetByPK(LogDBDeleteActivityPK, token);
			if(_result_ == null)
				return null;

			return new LogDBDeleteActivity(_result_);
		}

		public static LogDBDeleteActivityCollection GetAll()
		{
			return GetAll( Identity.Token);
		}

		public static LogDBDeleteActivityCollection GetAll(SecurityToken token)
		{

			W3000.Data.LogDBDeleteActivityDataCollection _result_ = LogDBDeleteActivityWrapper.GetAll( token);
			if(_result_ == null)
				return null;

			return new LogDBDeleteActivityCollection(_result_);
		}

		public static W3000.Data.LogDBDeleteActivityViewCollection GetViewAll()
		{
			return GetViewAll( Identity.Token);
		}

		public static W3000.Data.LogDBDeleteActivityViewCollection GetViewAll(SecurityToken token)
		{

			W3000.Data.LogDBDeleteActivityViewCollection _result_ = LogDBDeleteActivityWrapper.GetViewAll( token);
			if(_result_ == null)
				return null;

			return _result_;
		}

	}

	public partial class LogDBEditActivity
	{
		public static Cheke.BusinessEntity.Result Purge(W3000.Data.LogDBEditActivityData entity)
		{
			return Purge(entity, Identity.Token);
		}

		public static Cheke.BusinessEntity.Result Purge(W3000.Data.LogDBEditActivityData entity, SecurityToken token)
		{
			if(entity != null)
			{
				entity = new W3000.Data.LogDBEditActivityData(entity);
			}

			Cheke.BusinessEntity.Result _result_ = LogDBEditActivityWrapper.Purge(entity, token);
			if(_result_ == null)
				return null;

			return _result_;
		}

		public static Cheke.BusinessEntity.Result Save(W3000.Data.LogDBEditActivityData entity)
		{
			return Save(entity, Identity.Token);
		}

		public static Cheke.BusinessEntity.Result Save(W3000.Data.LogDBEditActivityData entity, SecurityToken token)
		{
			if(entity != null)
			{
				entity = new W3000.Data.LogDBEditActivityData(entity);
			}

			Cheke.BusinessEntity.Result _result_ = LogDBEditActivityWrapper.Save(entity, token);
			if(_result_ == null)
				return null;

			return _result_;
		}

		public static Cheke.BusinessEntity.Result Save(W3000.Data.LogDBEditActivityDataCollection list)
		{
			return Save(list, Identity.Token);
		}

		public static Cheke.BusinessEntity.Result Save(W3000.Data.LogDBEditActivityDataCollection list, SecurityToken token)
		{
			if(list != null)
			{
				list = new W3000.Data.LogDBEditActivityDataCollection(list);
			}

			Cheke.BusinessEntity.Result _result_ = LogDBEditActivityWrapper.Save(list, token);
			if(_result_ == null)
				return null;

			return _result_;
		}

		public static LogDBEditActivityCollection GetByLogDateTime(System.DateTime begin,System.DateTime end)
		{
			return GetByLogDateTime(begin,end, Identity.Token);
		}

		public static LogDBEditActivityCollection GetByLogDateTime(System.DateTime begin,System.DateTime end, SecurityToken token)
		{

			W3000.Data.LogDBEditActivityDataCollection _result_ = LogDBEditActivityWrapper.GetByLogDateTime(begin,end, token);
			if(_result_ == null)
				return null;

			return new LogDBEditActivityCollection(_result_);
		}

		public static LogDBEditActivityCollection GetByLogDateTime(System.DateTime begin,System.DateTime end,System.Guid recordPK)
		{
			return GetByLogDateTime(begin,end,recordPK, Identity.Token);
		}

		public static LogDBEditActivityCollection GetByLogDateTime(System.DateTime begin,System.DateTime end,System.Guid recordPK, SecurityToken token)
		{

			W3000.Data.LogDBEditActivityDataCollection _result_ = LogDBEditActivityWrapper.GetByLogDateTime(begin,end,recordPK, token);
			if(_result_ == null)
				return null;

			return new LogDBEditActivityCollection(_result_);
		}

		public static LogDBEditActivityCollection GetByLogDateTime(System.DateTime begin,System.DateTime end,System.String tableName)
		{
			return GetByLogDateTime(begin,end,tableName, Identity.Token);
		}

		public static LogDBEditActivityCollection GetByLogDateTime(System.DateTime begin,System.DateTime end,System.String tableName, SecurityToken token)
		{

			W3000.Data.LogDBEditActivityDataCollection _result_ = LogDBEditActivityWrapper.GetByLogDateTime(begin,end,tableName, token);
			if(_result_ == null)
				return null;

			return new LogDBEditActivityCollection(_result_);
		}

		public static LogDBEditActivityCollection GetByDeleteRecords(System.DateTime begin,System.DateTime end,System.String tableName)
		{
			return GetByDeleteRecords(begin,end,tableName, Identity.Token);
		}

		public static LogDBEditActivityCollection GetByDeleteRecords(System.DateTime begin,System.DateTime end,System.String tableName, SecurityToken token)
		{

			W3000.Data.LogDBEditActivityDataCollection _result_ = LogDBEditActivityWrapper.GetByDeleteRecords(begin,end,tableName, token);
			if(_result_ == null)
				return null;

			return new LogDBEditActivityCollection(_result_);
		}

		public static LogDBEditActivity GetDeletedRecord(System.DateTime lastUpdated,System.Guid recordPK)
		{
			return GetDeletedRecord(lastUpdated,recordPK, Identity.Token);
		}

		public static LogDBEditActivity GetDeletedRecord(System.DateTime lastUpdated,System.Guid recordPK, SecurityToken token)
		{

			W3000.Data.LogDBEditActivityData _result_ = LogDBEditActivityWrapper.GetDeletedRecord(lastUpdated,recordPK, token);
			if(_result_ == null)
				return null;

			return new LogDBEditActivity(_result_);
		}

		public static LogDBEditActivity GetByPK(System.Guid LogDBEditActivityPK)
		{
			return GetByPK(LogDBEditActivityPK, Identity.Token);
		}

		public static LogDBEditActivity GetByPK(System.Guid LogDBEditActivityPK, SecurityToken token)
		{

			W3000.Data.LogDBEditActivityData _result_ = LogDBEditActivityWrapper.GetByPK(LogDBEditActivityPK, token);
			if(_result_ == null)
				return null;

			return new LogDBEditActivity(_result_);
		}

		public static LogDBEditActivityCollection GetAll()
		{
			return GetAll( Identity.Token);
		}

		public static LogDBEditActivityCollection GetAll(SecurityToken token)
		{

			W3000.Data.LogDBEditActivityDataCollection _result_ = LogDBEditActivityWrapper.GetAll( token);
			if(_result_ == null)
				return null;

			return new LogDBEditActivityCollection(_result_);
		}

		public static W3000.Data.LogDBEditActivityViewCollection GetViewAll()
		{
			return GetViewAll( Identity.Token);
		}

		public static W3000.Data.LogDBEditActivityViewCollection GetViewAll(SecurityToken token)
		{

			W3000.Data.LogDBEditActivityViewCollection _result_ = LogDBEditActivityWrapper.GetViewAll( token);
			if(_result_ == null)
				return null;

			return _result_;
		}

	}

	public partial class LogRowsCount
	{
		public static Cheke.BusinessEntity.Result Purge(W3000.Data.LogRowsCountData entity)
		{
			return Purge(entity, Identity.Token);
		}

		public static Cheke.BusinessEntity.Result Purge(W3000.Data.LogRowsCountData entity, SecurityToken token)
		{
			if(entity != null)
			{
				entity = new W3000.Data.LogRowsCountData(entity);
			}

			Cheke.BusinessEntity.Result _result_ = LogRowsCountWrapper.Purge(entity, token);
			if(_result_ == null)
				return null;

			return _result_;
		}

		public static Cheke.BusinessEntity.Result Save(W3000.Data.LogRowsCountData entity)
		{
			return Save(entity, Identity.Token);
		}

		public static Cheke.BusinessEntity.Result Save(W3000.Data.LogRowsCountData entity, SecurityToken token)
		{
			if(entity != null)
			{
				entity = new W3000.Data.LogRowsCountData(entity);
			}

			Cheke.BusinessEntity.Result _result_ = LogRowsCountWrapper.Save(entity, token);
			if(_result_ == null)
				return null;

			return _result_;
		}

		public static Cheke.BusinessEntity.Result Save(W3000.Data.LogRowsCountDataCollection list)
		{
			return Save(list, Identity.Token);
		}

		public static Cheke.BusinessEntity.Result Save(W3000.Data.LogRowsCountDataCollection list, SecurityToken token)
		{
			if(list != null)
			{
				list = new W3000.Data.LogRowsCountDataCollection(list);
			}

			Cheke.BusinessEntity.Result _result_ = LogRowsCountWrapper.Save(list, token);
			if(_result_ == null)
				return null;

			return _result_;
		}

		public static LogRowsCountCollection GetBySessionDateTime(System.DateTime begin,System.DateTime end)
		{
			return GetBySessionDateTime(begin,end, Identity.Token);
		}

		public static LogRowsCountCollection GetBySessionDateTime(System.DateTime begin,System.DateTime end, SecurityToken token)
		{

			W3000.Data.LogRowsCountDataCollection _result_ = LogRowsCountWrapper.GetBySessionDateTime(begin,end, token);
			if(_result_ == null)
				return null;

			return new LogRowsCountCollection(_result_);
		}

		public static LogRowsCountCollection GetBySessionID(System.Guid SessionID)
		{
			return GetBySessionID(SessionID, Identity.Token);
		}

		public static LogRowsCountCollection GetBySessionID(System.Guid SessionID, SecurityToken token)
		{

			W3000.Data.LogRowsCountDataCollection _result_ = LogRowsCountWrapper.GetBySessionID(SessionID, token);
			if(_result_ == null)
				return null;

			return new LogRowsCountCollection(_result_);
		}

		public static System.Int32 DeleteBySessionDateTime(System.DateTime begin,System.DateTime end)
		{
			return DeleteBySessionDateTime(begin,end, Identity.Token);
		}

		public static System.Int32 DeleteBySessionDateTime(System.DateTime begin,System.DateTime end, SecurityToken token)
		{

			System.Int32 _result_ = LogRowsCountWrapper.DeleteBySessionDateTime(begin,end, token);
			return _result_;
		}

		public static LogRowsCount GetByPK(System.Guid LogRowsCountPK)
		{
			return GetByPK(LogRowsCountPK, Identity.Token);
		}

		public static LogRowsCount GetByPK(System.Guid LogRowsCountPK, SecurityToken token)
		{

			W3000.Data.LogRowsCountData _result_ = LogRowsCountWrapper.GetByPK(LogRowsCountPK, token);
			if(_result_ == null)
				return null;

			return new LogRowsCount(_result_);
		}

		public static LogRowsCountCollection GetAll()
		{
			return GetAll( Identity.Token);
		}

		public static LogRowsCountCollection GetAll(SecurityToken token)
		{

			W3000.Data.LogRowsCountDataCollection _result_ = LogRowsCountWrapper.GetAll( token);
			if(_result_ == null)
				return null;

			return new LogRowsCountCollection(_result_);
		}

		public static W3000.Data.LogRowsCountViewCollection GetViewAll()
		{
			return GetViewAll( Identity.Token);
		}

		public static W3000.Data.LogRowsCountViewCollection GetViewAll(SecurityToken token)
		{

			W3000.Data.LogRowsCountViewCollection _result_ = LogRowsCountWrapper.GetViewAll( token);
			if(_result_ == null)
				return null;

			return _result_;
		}

	}

	public partial class UsrAccountBRRule
	{
		public static Cheke.BusinessEntity.Result Purge(W3000.Data.UsrAccountBRRuleData entity)
		{
			return Purge(entity, Identity.Token);
		}

		public static Cheke.BusinessEntity.Result Purge(W3000.Data.UsrAccountBRRuleData entity, SecurityToken token)
		{
			if(entity != null)
			{
				entity = new W3000.Data.UsrAccountBRRuleData(entity);
			}

			Cheke.BusinessEntity.Result _result_ = UsrAccountBRRuleWrapper.Purge(entity, token);
			if(_result_ == null)
				return null;

			return _result_;
		}

		public static Cheke.BusinessEntity.Result Save(W3000.Data.UsrAccountBRRuleData entity)
		{
			return Save(entity, Identity.Token);
		}

		public static Cheke.BusinessEntity.Result Save(W3000.Data.UsrAccountBRRuleData entity, SecurityToken token)
		{
			if(entity != null)
			{
				entity = new W3000.Data.UsrAccountBRRuleData(entity);
			}

			Cheke.BusinessEntity.Result _result_ = UsrAccountBRRuleWrapper.Save(entity, token);
			if(_result_ == null)
				return null;

			return _result_;
		}

		public static Cheke.BusinessEntity.Result Save(W3000.Data.UsrAccountBRRuleDataCollection list)
		{
			return Save(list, Identity.Token);
		}

		public static Cheke.BusinessEntity.Result Save(W3000.Data.UsrAccountBRRuleDataCollection list, SecurityToken token)
		{
			if(list != null)
			{
				list = new W3000.Data.UsrAccountBRRuleDataCollection(list);
			}

			Cheke.BusinessEntity.Result _result_ = UsrAccountBRRuleWrapper.Save(list, token);
			if(_result_ == null)
				return null;

			return _result_;
		}

		public static UsrAccountBRRuleCollection GetByBRRuleID(System.Int32 BRRuleID)
		{
			return GetByBRRuleID(BRRuleID, Identity.Token);
		}

		public static UsrAccountBRRuleCollection GetByBRRuleID(System.Int32 BRRuleID, SecurityToken token)
		{

			W3000.Data.UsrAccountBRRuleDataCollection _result_ = UsrAccountBRRuleWrapper.GetByBRRuleID(BRRuleID, token);
			if(_result_ == null)
				return null;

			return new UsrAccountBRRuleCollection(_result_);
		}

		public static System.Int32 GetAllCount()
		{
			return GetAllCount( Identity.Token);
		}

		public static System.Int32 GetAllCount(SecurityToken token)
		{

			System.Int32 _result_ = UsrAccountBRRuleWrapper.GetAllCount( token);
			return _result_;
		}

		public static UsrAccountBRRuleCollection GetAllPage(System.Int32 pageIndex,System.Int32 pageSize)
		{
			return GetAllPage(pageIndex,pageSize, Identity.Token);
		}

		public static UsrAccountBRRuleCollection GetAllPage(System.Int32 pageIndex,System.Int32 pageSize, SecurityToken token)
		{

			W3000.Data.UsrAccountBRRuleDataCollection _result_ = UsrAccountBRRuleWrapper.GetAllPage(pageIndex,pageSize, token);
			if(_result_ == null)
				return null;

			return new UsrAccountBRRuleCollection(_result_);
		}

		public static UsrAccountBRRule GetByUK(System.Guid UsrAccountPK,System.Int32 BRRuleID)
		{
			return GetByUK(UsrAccountPK,BRRuleID, Identity.Token);
		}

		public static UsrAccountBRRule GetByUK(System.Guid UsrAccountPK,System.Int32 BRRuleID, SecurityToken token)
		{

			W3000.Data.UsrAccountBRRuleData _result_ = UsrAccountBRRuleWrapper.GetByUK(UsrAccountPK,BRRuleID, token);
			if(_result_ == null)
				return null;

			return new UsrAccountBRRule(_result_);
		}

		public static UsrAccountBRRule GetByBRRuleID(System.Int32 BRRuleID,System.String userID)
		{
			return GetByBRRuleID(BRRuleID,userID, Identity.Token);
		}

		public static UsrAccountBRRule GetByBRRuleID(System.Int32 BRRuleID,System.String userID, SecurityToken token)
		{

			W3000.Data.UsrAccountBRRuleData _result_ = UsrAccountBRRuleWrapper.GetByBRRuleID(BRRuleID,userID, token);
			if(_result_ == null)
				return null;

			return new UsrAccountBRRule(_result_);
		}

		public static UsrAccountBRRule GetByBRRuleID(System.Int32 BRRuleID,System.Guid UsrAccountPK)
		{
			return GetByBRRuleID(BRRuleID,UsrAccountPK, Identity.Token);
		}

		public static UsrAccountBRRule GetByBRRuleID(System.Int32 BRRuleID,System.Guid UsrAccountPK, SecurityToken token)
		{

			W3000.Data.UsrAccountBRRuleData _result_ = UsrAccountBRRuleWrapper.GetByBRRuleID(BRRuleID,UsrAccountPK, token);
			if(_result_ == null)
				return null;

			return new UsrAccountBRRule(_result_);
		}

		public static UsrAccountBRRule GetByPK(System.Guid UsrAccountBRRulePK)
		{
			return GetByPK(UsrAccountBRRulePK, Identity.Token);
		}

		public static UsrAccountBRRule GetByPK(System.Guid UsrAccountBRRulePK, SecurityToken token)
		{

			W3000.Data.UsrAccountBRRuleData _result_ = UsrAccountBRRuleWrapper.GetByPK(UsrAccountBRRulePK, token);
			if(_result_ == null)
				return null;

			return new UsrAccountBRRule(_result_);
		}

		public static UsrAccountBRRuleCollection GetAll()
		{
			return GetAll( Identity.Token);
		}

		public static UsrAccountBRRuleCollection GetAll(SecurityToken token)
		{

			W3000.Data.UsrAccountBRRuleDataCollection _result_ = UsrAccountBRRuleWrapper.GetAll( token);
			if(_result_ == null)
				return null;

			return new UsrAccountBRRuleCollection(_result_);
		}

		public static W3000.Data.UsrAccountBRRuleViewCollection GetViewAll()
		{
			return GetViewAll( Identity.Token);
		}

		public static W3000.Data.UsrAccountBRRuleViewCollection GetViewAll(SecurityToken token)
		{

			W3000.Data.UsrAccountBRRuleViewCollection _result_ = UsrAccountBRRuleWrapper.GetViewAll( token);
			if(_result_ == null)
				return null;

			return _result_;
		}

		public static UsrAccountBRRuleCollection GetByUsrAccount(System.Guid UsrAccountPK)
		{
			return GetByUsrAccount(UsrAccountPK, Identity.Token);
		}

		public static UsrAccountBRRuleCollection GetByUsrAccount(System.Guid UsrAccountPK, SecurityToken token)
		{

			W3000.Data.UsrAccountBRRuleDataCollection _result_ = UsrAccountBRRuleWrapper.GetByUsrAccount(UsrAccountPK, token);
			if(_result_ == null)
				return null;

			return new UsrAccountBRRuleCollection(_result_);
		}

		public static W3000.Data.UsrAccountBRRuleViewCollection GetViewByUsrAccount(System.Guid UsrAccountPK)
		{
			return GetViewByUsrAccount(UsrAccountPK, Identity.Token);
		}

		public static W3000.Data.UsrAccountBRRuleViewCollection GetViewByUsrAccount(System.Guid UsrAccountPK, SecurityToken token)
		{

			W3000.Data.UsrAccountBRRuleViewCollection _result_ = UsrAccountBRRuleWrapper.GetViewByUsrAccount(UsrAccountPK, token);
			if(_result_ == null)
				return null;

			return _result_;
		}

	}

	public partial class UsrAccountBuildingMap
	{
		public static Cheke.BusinessEntity.Result Purge(W3000.Data.UsrAccountBuildingMapData entity)
		{
			return Purge(entity, Identity.Token);
		}

		public static Cheke.BusinessEntity.Result Purge(W3000.Data.UsrAccountBuildingMapData entity, SecurityToken token)
		{
			if(entity != null)
			{
				entity = new W3000.Data.UsrAccountBuildingMapData(entity);
			}

			Cheke.BusinessEntity.Result _result_ = UsrAccountBuildingMapWrapper.Purge(entity, token);
			if(_result_ == null)
				return null;

			return _result_;
		}

		public static Cheke.BusinessEntity.Result Save(W3000.Data.UsrAccountBuildingMapData entity)
		{
			return Save(entity, Identity.Token);
		}

		public static Cheke.BusinessEntity.Result Save(W3000.Data.UsrAccountBuildingMapData entity, SecurityToken token)
		{
			if(entity != null)
			{
				entity = new W3000.Data.UsrAccountBuildingMapData(entity);
			}

			Cheke.BusinessEntity.Result _result_ = UsrAccountBuildingMapWrapper.Save(entity, token);
			if(_result_ == null)
				return null;

			return _result_;
		}

		public static Cheke.BusinessEntity.Result Save(W3000.Data.UsrAccountBuildingMapDataCollection list)
		{
			return Save(list, Identity.Token);
		}

		public static Cheke.BusinessEntity.Result Save(W3000.Data.UsrAccountBuildingMapDataCollection list, SecurityToken token)
		{
			if(list != null)
			{
				list = new W3000.Data.UsrAccountBuildingMapDataCollection(list);
			}

			Cheke.BusinessEntity.Result _result_ = UsrAccountBuildingMapWrapper.Save(list, token);
			if(_result_ == null)
				return null;

			return _result_;
		}

		public static UsrAccountBuildingMapCollection GetByModifiedOn(System.DateTime begin,System.DateTime end)
		{
			return GetByModifiedOn(begin,end, Identity.Token);
		}

		public static UsrAccountBuildingMapCollection GetByModifiedOn(System.DateTime begin,System.DateTime end, SecurityToken token)
		{

			W3000.Data.UsrAccountBuildingMapDataCollection _result_ = UsrAccountBuildingMapWrapper.GetByModifiedOn(begin,end, token);
			if(_result_ == null)
				return null;

			return new UsrAccountBuildingMapCollection(_result_);
		}

		public static System.Int32 GetAllCount()
		{
			return GetAllCount( Identity.Token);
		}

		public static System.Int32 GetAllCount(SecurityToken token)
		{

			System.Int32 _result_ = UsrAccountBuildingMapWrapper.GetAllCount( token);
			return _result_;
		}

		public static UsrAccountBuildingMapCollection GetAllPage(System.Int32 pageIndex,System.Int32 pageSize)
		{
			return GetAllPage(pageIndex,pageSize, Identity.Token);
		}

		public static UsrAccountBuildingMapCollection GetAllPage(System.Int32 pageIndex,System.Int32 pageSize, SecurityToken token)
		{

			W3000.Data.UsrAccountBuildingMapDataCollection _result_ = UsrAccountBuildingMapWrapper.GetAllPage(pageIndex,pageSize, token);
			if(_result_ == null)
				return null;

			return new UsrAccountBuildingMapCollection(_result_);
		}

		public static UsrAccountBuildingMap GetByUK(System.Guid UsrAccountPK,System.Guid BDBuildingPK)
		{
			return GetByUK(UsrAccountPK,BDBuildingPK, Identity.Token);
		}

		public static UsrAccountBuildingMap GetByUK(System.Guid UsrAccountPK,System.Guid BDBuildingPK, SecurityToken token)
		{

			W3000.Data.UsrAccountBuildingMapData _result_ = UsrAccountBuildingMapWrapper.GetByUK(UsrAccountPK,BDBuildingPK, token);
			if(_result_ == null)
				return null;

			return new UsrAccountBuildingMap(_result_);
		}

		public static UsrAccountBuildingMap GetByPK(System.Guid UsrAccountBuildingMapPK)
		{
			return GetByPK(UsrAccountBuildingMapPK, Identity.Token);
		}

		public static UsrAccountBuildingMap GetByPK(System.Guid UsrAccountBuildingMapPK, SecurityToken token)
		{

			W3000.Data.UsrAccountBuildingMapData _result_ = UsrAccountBuildingMapWrapper.GetByPK(UsrAccountBuildingMapPK, token);
			if(_result_ == null)
				return null;

			return new UsrAccountBuildingMap(_result_);
		}

		public static UsrAccountBuildingMapCollection GetAll()
		{
			return GetAll( Identity.Token);
		}

		public static UsrAccountBuildingMapCollection GetAll(SecurityToken token)
		{

			W3000.Data.UsrAccountBuildingMapDataCollection _result_ = UsrAccountBuildingMapWrapper.GetAll( token);
			if(_result_ == null)
				return null;

			return new UsrAccountBuildingMapCollection(_result_);
		}

		public static W3000.Data.UsrAccountBuildingMapViewCollection GetViewAll()
		{
			return GetViewAll( Identity.Token);
		}

		public static W3000.Data.UsrAccountBuildingMapViewCollection GetViewAll(SecurityToken token)
		{

			W3000.Data.UsrAccountBuildingMapViewCollection _result_ = UsrAccountBuildingMapWrapper.GetViewAll( token);
			if(_result_ == null)
				return null;

			return _result_;
		}

		public static UsrAccountBuildingMapCollection GetByBDBuilding(System.Guid BDBuildingPK)
		{
			return GetByBDBuilding(BDBuildingPK, Identity.Token);
		}

		public static UsrAccountBuildingMapCollection GetByBDBuilding(System.Guid BDBuildingPK, SecurityToken token)
		{

			W3000.Data.UsrAccountBuildingMapDataCollection _result_ = UsrAccountBuildingMapWrapper.GetByBDBuilding(BDBuildingPK, token);
			if(_result_ == null)
				return null;

			return new UsrAccountBuildingMapCollection(_result_);
		}

		public static W3000.Data.UsrAccountBuildingMapViewCollection GetViewByBDBuilding(System.Guid BDBuildingPK)
		{
			return GetViewByBDBuilding(BDBuildingPK, Identity.Token);
		}

		public static W3000.Data.UsrAccountBuildingMapViewCollection GetViewByBDBuilding(System.Guid BDBuildingPK, SecurityToken token)
		{

			W3000.Data.UsrAccountBuildingMapViewCollection _result_ = UsrAccountBuildingMapWrapper.GetViewByBDBuilding(BDBuildingPK, token);
			if(_result_ == null)
				return null;

			return _result_;
		}

		public static UsrAccountBuildingMapCollection GetByUsrAccount(System.Guid UsrAccountPK)
		{
			return GetByUsrAccount(UsrAccountPK, Identity.Token);
		}

		public static UsrAccountBuildingMapCollection GetByUsrAccount(System.Guid UsrAccountPK, SecurityToken token)
		{

			W3000.Data.UsrAccountBuildingMapDataCollection _result_ = UsrAccountBuildingMapWrapper.GetByUsrAccount(UsrAccountPK, token);
			if(_result_ == null)
				return null;

			return new UsrAccountBuildingMapCollection(_result_);
		}

		public static W3000.Data.UsrAccountBuildingMapViewCollection GetViewByUsrAccount(System.Guid UsrAccountPK)
		{
			return GetViewByUsrAccount(UsrAccountPK, Identity.Token);
		}

		public static W3000.Data.UsrAccountBuildingMapViewCollection GetViewByUsrAccount(System.Guid UsrAccountPK, SecurityToken token)
		{

			W3000.Data.UsrAccountBuildingMapViewCollection _result_ = UsrAccountBuildingMapWrapper.GetViewByUsrAccount(UsrAccountPK, token);
			if(_result_ == null)
				return null;

			return _result_;
		}

	}

	public partial class UsrAccount
	{
		public static Cheke.BusinessEntity.Result Purge(W3000.Data.UsrAccountData entity)
		{
			return Purge(entity, Identity.Token);
		}

		public static Cheke.BusinessEntity.Result Purge(W3000.Data.UsrAccountData entity, SecurityToken token)
		{
			if(entity != null)
			{
				entity = new W3000.Data.UsrAccountData(entity);
			}

			Cheke.BusinessEntity.Result _result_ = UsrAccountWrapper.Purge(entity, token);
			if(_result_ == null)
				return null;

			return _result_;
		}

		public static Cheke.BusinessEntity.Result Save(W3000.Data.UsrAccountData entity)
		{
			return Save(entity, Identity.Token);
		}

		public static Cheke.BusinessEntity.Result Save(W3000.Data.UsrAccountData entity, SecurityToken token)
		{
			if(entity != null)
			{
				entity = new W3000.Data.UsrAccountData(entity);
			}

			Cheke.BusinessEntity.Result _result_ = UsrAccountWrapper.Save(entity, token);
			if(_result_ == null)
				return null;

			return _result_;
		}

		public static Cheke.BusinessEntity.Result Save(W3000.Data.UsrAccountDataCollection list)
		{
			return Save(list, Identity.Token);
		}

		public static Cheke.BusinessEntity.Result Save(W3000.Data.UsrAccountDataCollection list, SecurityToken token)
		{
			if(list != null)
			{
				list = new W3000.Data.UsrAccountDataCollection(list);
			}

			Cheke.BusinessEntity.Result _result_ = UsrAccountWrapper.Save(list, token);
			if(_result_ == null)
				return null;

			return _result_;
		}

		public static UsrAccountCollection GetByMappedBDBuilding(System.Guid BDBuildingPK)
		{
			return GetByMappedBDBuilding(BDBuildingPK, Identity.Token);
		}

		public static UsrAccountCollection GetByMappedBDBuilding(System.Guid BDBuildingPK, SecurityToken token)
		{

			W3000.Data.UsrAccountDataCollection _result_ = UsrAccountWrapper.GetByMappedBDBuilding(BDBuildingPK, token);
			if(_result_ == null)
				return null;

			return new UsrAccountCollection(_result_);
		}

		public static UsrAccountCollection GetByMappedBDTenant(System.Guid BDTenantPK)
		{
			return GetByMappedBDTenant(BDTenantPK, Identity.Token);
		}

		public static UsrAccountCollection GetByMappedBDTenant(System.Guid BDTenantPK, SecurityToken token)
		{

			W3000.Data.UsrAccountDataCollection _result_ = UsrAccountWrapper.GetByMappedBDTenant(BDTenantPK, token);
			if(_result_ == null)
				return null;

			return new UsrAccountCollection(_result_);
		}

		public static System.Int32 GetAllCount()
		{
			return GetAllCount( Identity.Token);
		}

		public static System.Int32 GetAllCount(SecurityToken token)
		{

			System.Int32 _result_ = UsrAccountWrapper.GetAllCount( token);
			return _result_;
		}

		public static UsrAccountCollection GetAllPage(System.Int32 pageIndex,System.Int32 pageSize)
		{
			return GetAllPage(pageIndex,pageSize, Identity.Token);
		}

		public static UsrAccountCollection GetAllPage(System.Int32 pageIndex,System.Int32 pageSize, SecurityToken token)
		{

			W3000.Data.UsrAccountDataCollection _result_ = UsrAccountWrapper.GetAllPage(pageIndex,pageSize, token);
			if(_result_ == null)
				return null;

			return new UsrAccountCollection(_result_);
		}

		public static UsrAccount GetByUserID(System.String UserID)
		{
			return GetByUserID(UserID, Identity.Token);
		}

		public static UsrAccount GetByUserID(System.String UserID, SecurityToken token)
		{

			W3000.Data.UsrAccountData _result_ = UsrAccountWrapper.GetByUserID(UserID, token);
			if(_result_ == null)
				return null;

			return new UsrAccount(_result_);
		}

		public static UsrAccountCollection GetByUsrGroupName(System.String UsrGroupName)
		{
			return GetByUsrGroupName(UsrGroupName, Identity.Token);
		}

		public static UsrAccountCollection GetByUsrGroupName(System.String UsrGroupName, SecurityToken token)
		{

			W3000.Data.UsrAccountDataCollection _result_ = UsrAccountWrapper.GetByUsrGroupName(UsrGroupName, token);
			if(_result_ == null)
				return null;

			return new UsrAccountCollection(_result_);
		}

		public static UsrAccountCollection GetCentralUser()
		{
			return GetCentralUser( Identity.Token);
		}

		public static UsrAccountCollection GetCentralUser(SecurityToken token)
		{

			W3000.Data.UsrAccountDataCollection _result_ = UsrAccountWrapper.GetCentralUser( token);
			if(_result_ == null)
				return null;

			return new UsrAccountCollection(_result_);
		}

		public static UsrAccountCollection GetWebUser()
		{
			return GetWebUser( Identity.Token);
		}

		public static UsrAccountCollection GetWebUser(SecurityToken token)
		{

			W3000.Data.UsrAccountDataCollection _result_ = UsrAccountWrapper.GetWebUser( token);
			if(_result_ == null)
				return null;

			return new UsrAccountCollection(_result_);
		}

		public static UsrAccountCollection GetByModifiedOn(System.Boolean IsCentral,System.DateTime begin,System.DateTime end)
		{
			return GetByModifiedOn(IsCentral,begin,end, Identity.Token);
		}

		public static UsrAccountCollection GetByModifiedOn(System.Boolean IsCentral,System.DateTime begin,System.DateTime end, SecurityToken token)
		{

			W3000.Data.UsrAccountDataCollection _result_ = UsrAccountWrapper.GetByModifiedOn(IsCentral,begin,end, token);
			if(_result_ == null)
				return null;

			return new UsrAccountCollection(_result_);
		}

		public static System.Boolean IsTableExist(System.String tableName)
		{
			return IsTableExist(tableName, Identity.Token);
		}

		public static System.Boolean IsTableExist(System.String tableName, SecurityToken token)
		{

			System.Boolean _result_ = UsrAccountWrapper.IsTableExist(tableName, token);
			return _result_;
		}

		public static System.String ExecuteNonQuery(System.String sql)
		{
			return ExecuteNonQuery(sql, Identity.Token);
		}

		public static System.String ExecuteNonQuery(System.String sql, SecurityToken token)
		{

			System.String _result_ = UsrAccountWrapper.ExecuteNonQuery(sql, token);
			if(_result_ == null)
				return null;

			return _result_;
		}

		public static System.String ExecuteScalar(System.String sql)
		{
			return ExecuteScalar(sql, Identity.Token);
		}

		public static System.String ExecuteScalar(System.String sql, SecurityToken token)
		{

			System.String _result_ = UsrAccountWrapper.ExecuteScalar(sql, token);
			if(_result_ == null)
				return null;

			return _result_;
		}

		public static System.Data.DataTable ExecuteDataTable(System.String sql)
		{
			return ExecuteDataTable(sql, Identity.Token);
		}

		public static System.Data.DataTable ExecuteDataTable(System.String sql, SecurityToken token)
		{

			System.Data.DataTable _result_ = UsrAccountWrapper.ExecuteDataTable(sql, token);
			if(_result_ == null)
				return null;

			return _result_;
		}

		public static UsrAccount GetByPK(System.Guid UsrAccountPK)
		{
			return GetByPK(UsrAccountPK, Identity.Token);
		}

		public static UsrAccount GetByPK(System.Guid UsrAccountPK, SecurityToken token)
		{

			W3000.Data.UsrAccountData _result_ = UsrAccountWrapper.GetByPK(UsrAccountPK, token);
			if(_result_ == null)
				return null;

			return new UsrAccount(_result_);
		}

		public static UsrAccountCollection GetAll()
		{
			return GetAll( Identity.Token);
		}

		public static UsrAccountCollection GetAll(SecurityToken token)
		{

			W3000.Data.UsrAccountDataCollection _result_ = UsrAccountWrapper.GetAll( token);
			if(_result_ == null)
				return null;

			return new UsrAccountCollection(_result_);
		}

		public static W3000.Data.UsrAccountViewCollection GetViewAll()
		{
			return GetViewAll( Identity.Token);
		}

		public static W3000.Data.UsrAccountViewCollection GetViewAll(SecurityToken token)
		{

			W3000.Data.UsrAccountViewCollection _result_ = UsrAccountWrapper.GetViewAll( token);
			if(_result_ == null)
				return null;

			return _result_;
		}

		public static UsrAccountCollection GetByBDTenant(System.Guid BDTenantPK)
		{
			return GetByBDTenant(BDTenantPK, Identity.Token);
		}

		public static UsrAccountCollection GetByBDTenant(System.Guid BDTenantPK, SecurityToken token)
		{

			W3000.Data.UsrAccountDataCollection _result_ = UsrAccountWrapper.GetByBDTenant(BDTenantPK, token);
			if(_result_ == null)
				return null;

			return new UsrAccountCollection(_result_);
		}

		public static W3000.Data.UsrAccountViewCollection GetViewByBDTenant(System.Guid BDTenantPK)
		{
			return GetViewByBDTenant(BDTenantPK, Identity.Token);
		}

		public static W3000.Data.UsrAccountViewCollection GetViewByBDTenant(System.Guid BDTenantPK, SecurityToken token)
		{

			W3000.Data.UsrAccountViewCollection _result_ = UsrAccountWrapper.GetViewByBDTenant(BDTenantPK, token);
			if(_result_ == null)
				return null;

			return _result_;
		}

		public static UsrAccountCollection GetByUsrGroup(System.Guid UsrGroupPK)
		{
			return GetByUsrGroup(UsrGroupPK, Identity.Token);
		}

		public static UsrAccountCollection GetByUsrGroup(System.Guid UsrGroupPK, SecurityToken token)
		{

			W3000.Data.UsrAccountDataCollection _result_ = UsrAccountWrapper.GetByUsrGroup(UsrGroupPK, token);
			if(_result_ == null)
				return null;

			return new UsrAccountCollection(_result_);
		}

		public static W3000.Data.UsrAccountViewCollection GetViewByUsrGroup(System.Guid UsrGroupPK)
		{
			return GetViewByUsrGroup(UsrGroupPK, Identity.Token);
		}

		public static W3000.Data.UsrAccountViewCollection GetViewByUsrGroup(System.Guid UsrGroupPK, SecurityToken token)
		{

			W3000.Data.UsrAccountViewCollection _result_ = UsrAccountWrapper.GetViewByUsrGroup(UsrGroupPK, token);
			if(_result_ == null)
				return null;

			return _result_;
		}

	}

	public partial class UsrAccountDBRule
	{
		public static Cheke.BusinessEntity.Result Purge(W3000.Data.UsrAccountDBRuleData entity)
		{
			return Purge(entity, Identity.Token);
		}

		public static Cheke.BusinessEntity.Result Purge(W3000.Data.UsrAccountDBRuleData entity, SecurityToken token)
		{
			if(entity != null)
			{
				entity = new W3000.Data.UsrAccountDBRuleData(entity);
			}

			Cheke.BusinessEntity.Result _result_ = UsrAccountDBRuleWrapper.Purge(entity, token);
			if(_result_ == null)
				return null;

			return _result_;
		}

		public static Cheke.BusinessEntity.Result Save(W3000.Data.UsrAccountDBRuleData entity)
		{
			return Save(entity, Identity.Token);
		}

		public static Cheke.BusinessEntity.Result Save(W3000.Data.UsrAccountDBRuleData entity, SecurityToken token)
		{
			if(entity != null)
			{
				entity = new W3000.Data.UsrAccountDBRuleData(entity);
			}

			Cheke.BusinessEntity.Result _result_ = UsrAccountDBRuleWrapper.Save(entity, token);
			if(_result_ == null)
				return null;

			return _result_;
		}

		public static Cheke.BusinessEntity.Result Save(W3000.Data.UsrAccountDBRuleDataCollection list)
		{
			return Save(list, Identity.Token);
		}

		public static Cheke.BusinessEntity.Result Save(W3000.Data.UsrAccountDBRuleDataCollection list, SecurityToken token)
		{
			if(list != null)
			{
				list = new W3000.Data.UsrAccountDBRuleDataCollection(list);
			}

			Cheke.BusinessEntity.Result _result_ = UsrAccountDBRuleWrapper.Save(list, token);
			if(_result_ == null)
				return null;

			return _result_;
		}

		public static UsrAccountDBRuleCollection GetByDBRuleID(System.Int32 DBRuleID)
		{
			return GetByDBRuleID(DBRuleID, Identity.Token);
		}

		public static UsrAccountDBRuleCollection GetByDBRuleID(System.Int32 DBRuleID, SecurityToken token)
		{

			W3000.Data.UsrAccountDBRuleDataCollection _result_ = UsrAccountDBRuleWrapper.GetByDBRuleID(DBRuleID, token);
			if(_result_ == null)
				return null;

			return new UsrAccountDBRuleCollection(_result_);
		}

		public static System.Int32 GetAllCount()
		{
			return GetAllCount( Identity.Token);
		}

		public static System.Int32 GetAllCount(SecurityToken token)
		{

			System.Int32 _result_ = UsrAccountDBRuleWrapper.GetAllCount( token);
			return _result_;
		}

		public static UsrAccountDBRuleCollection GetAllPage(System.Int32 pageIndex,System.Int32 pageSize)
		{
			return GetAllPage(pageIndex,pageSize, Identity.Token);
		}

		public static UsrAccountDBRuleCollection GetAllPage(System.Int32 pageIndex,System.Int32 pageSize, SecurityToken token)
		{

			W3000.Data.UsrAccountDBRuleDataCollection _result_ = UsrAccountDBRuleWrapper.GetAllPage(pageIndex,pageSize, token);
			if(_result_ == null)
				return null;

			return new UsrAccountDBRuleCollection(_result_);
		}

		public static UsrAccountDBRule GetByUK(System.Guid UsrAccountPK,System.Int32 DBRuleID)
		{
			return GetByUK(UsrAccountPK,DBRuleID, Identity.Token);
		}

		public static UsrAccountDBRule GetByUK(System.Guid UsrAccountPK,System.Int32 DBRuleID, SecurityToken token)
		{

			W3000.Data.UsrAccountDBRuleData _result_ = UsrAccountDBRuleWrapper.GetByUK(UsrAccountPK,DBRuleID, token);
			if(_result_ == null)
				return null;

			return new UsrAccountDBRule(_result_);
		}

		public static UsrAccountDBRule GetByPK(System.Guid UsrAccountDBRulePK)
		{
			return GetByPK(UsrAccountDBRulePK, Identity.Token);
		}

		public static UsrAccountDBRule GetByPK(System.Guid UsrAccountDBRulePK, SecurityToken token)
		{

			W3000.Data.UsrAccountDBRuleData _result_ = UsrAccountDBRuleWrapper.GetByPK(UsrAccountDBRulePK, token);
			if(_result_ == null)
				return null;

			return new UsrAccountDBRule(_result_);
		}

		public static UsrAccountDBRuleCollection GetAll()
		{
			return GetAll( Identity.Token);
		}

		public static UsrAccountDBRuleCollection GetAll(SecurityToken token)
		{

			W3000.Data.UsrAccountDBRuleDataCollection _result_ = UsrAccountDBRuleWrapper.GetAll( token);
			if(_result_ == null)
				return null;

			return new UsrAccountDBRuleCollection(_result_);
		}

		public static W3000.Data.UsrAccountDBRuleViewCollection GetViewAll()
		{
			return GetViewAll( Identity.Token);
		}

		public static W3000.Data.UsrAccountDBRuleViewCollection GetViewAll(SecurityToken token)
		{

			W3000.Data.UsrAccountDBRuleViewCollection _result_ = UsrAccountDBRuleWrapper.GetViewAll( token);
			if(_result_ == null)
				return null;

			return _result_;
		}

		public static UsrAccountDBRuleCollection GetByUsrAccount(System.Guid UsrAccountPK)
		{
			return GetByUsrAccount(UsrAccountPK, Identity.Token);
		}

		public static UsrAccountDBRuleCollection GetByUsrAccount(System.Guid UsrAccountPK, SecurityToken token)
		{

			W3000.Data.UsrAccountDBRuleDataCollection _result_ = UsrAccountDBRuleWrapper.GetByUsrAccount(UsrAccountPK, token);
			if(_result_ == null)
				return null;

			return new UsrAccountDBRuleCollection(_result_);
		}

		public static W3000.Data.UsrAccountDBRuleViewCollection GetViewByUsrAccount(System.Guid UsrAccountPK)
		{
			return GetViewByUsrAccount(UsrAccountPK, Identity.Token);
		}

		public static W3000.Data.UsrAccountDBRuleViewCollection GetViewByUsrAccount(System.Guid UsrAccountPK, SecurityToken token)
		{

			W3000.Data.UsrAccountDBRuleViewCollection _result_ = UsrAccountDBRuleWrapper.GetViewByUsrAccount(UsrAccountPK, token);
			if(_result_ == null)
				return null;

			return _result_;
		}

	}

	public partial class UsrAccountTenantMap
	{
		public static Cheke.BusinessEntity.Result Purge(W3000.Data.UsrAccountTenantMapData entity)
		{
			return Purge(entity, Identity.Token);
		}

		public static Cheke.BusinessEntity.Result Purge(W3000.Data.UsrAccountTenantMapData entity, SecurityToken token)
		{
			if(entity != null)
			{
				entity = new W3000.Data.UsrAccountTenantMapData(entity);
			}

			Cheke.BusinessEntity.Result _result_ = UsrAccountTenantMapWrapper.Purge(entity, token);
			if(_result_ == null)
				return null;

			return _result_;
		}

		public static Cheke.BusinessEntity.Result Save(W3000.Data.UsrAccountTenantMapData entity)
		{
			return Save(entity, Identity.Token);
		}

		public static Cheke.BusinessEntity.Result Save(W3000.Data.UsrAccountTenantMapData entity, SecurityToken token)
		{
			if(entity != null)
			{
				entity = new W3000.Data.UsrAccountTenantMapData(entity);
			}

			Cheke.BusinessEntity.Result _result_ = UsrAccountTenantMapWrapper.Save(entity, token);
			if(_result_ == null)
				return null;

			return _result_;
		}

		public static Cheke.BusinessEntity.Result Save(W3000.Data.UsrAccountTenantMapDataCollection list)
		{
			return Save(list, Identity.Token);
		}

		public static Cheke.BusinessEntity.Result Save(W3000.Data.UsrAccountTenantMapDataCollection list, SecurityToken token)
		{
			if(list != null)
			{
				list = new W3000.Data.UsrAccountTenantMapDataCollection(list);
			}

			Cheke.BusinessEntity.Result _result_ = UsrAccountTenantMapWrapper.Save(list, token);
			if(_result_ == null)
				return null;

			return _result_;
		}

		public static UsrAccountTenantMapCollection GetByModifiedOn(System.DateTime begin,System.DateTime end)
		{
			return GetByModifiedOn(begin,end, Identity.Token);
		}

		public static UsrAccountTenantMapCollection GetByModifiedOn(System.DateTime begin,System.DateTime end, SecurityToken token)
		{

			W3000.Data.UsrAccountTenantMapDataCollection _result_ = UsrAccountTenantMapWrapper.GetByModifiedOn(begin,end, token);
			if(_result_ == null)
				return null;

			return new UsrAccountTenantMapCollection(_result_);
		}

		public static System.Int32 GetAllCount()
		{
			return GetAllCount( Identity.Token);
		}

		public static System.Int32 GetAllCount(SecurityToken token)
		{

			System.Int32 _result_ = UsrAccountTenantMapWrapper.GetAllCount( token);
			return _result_;
		}

		public static UsrAccountTenantMapCollection GetAllPage(System.Int32 pageIndex,System.Int32 pageSize)
		{
			return GetAllPage(pageIndex,pageSize, Identity.Token);
		}

		public static UsrAccountTenantMapCollection GetAllPage(System.Int32 pageIndex,System.Int32 pageSize, SecurityToken token)
		{

			W3000.Data.UsrAccountTenantMapDataCollection _result_ = UsrAccountTenantMapWrapper.GetAllPage(pageIndex,pageSize, token);
			if(_result_ == null)
				return null;

			return new UsrAccountTenantMapCollection(_result_);
		}

		public static UsrAccountTenantMap GetByUK(System.Guid UsrAccountPK,System.Guid BDTenantPK)
		{
			return GetByUK(UsrAccountPK,BDTenantPK, Identity.Token);
		}

		public static UsrAccountTenantMap GetByUK(System.Guid UsrAccountPK,System.Guid BDTenantPK, SecurityToken token)
		{

			W3000.Data.UsrAccountTenantMapData _result_ = UsrAccountTenantMapWrapper.GetByUK(UsrAccountPK,BDTenantPK, token);
			if(_result_ == null)
				return null;

			return new UsrAccountTenantMap(_result_);
		}

		public static UsrAccountTenantMap GetByPK(System.Guid UsrAccountTenantMapPK)
		{
			return GetByPK(UsrAccountTenantMapPK, Identity.Token);
		}

		public static UsrAccountTenantMap GetByPK(System.Guid UsrAccountTenantMapPK, SecurityToken token)
		{

			W3000.Data.UsrAccountTenantMapData _result_ = UsrAccountTenantMapWrapper.GetByPK(UsrAccountTenantMapPK, token);
			if(_result_ == null)
				return null;

			return new UsrAccountTenantMap(_result_);
		}

		public static UsrAccountTenantMapCollection GetAll()
		{
			return GetAll( Identity.Token);
		}

		public static UsrAccountTenantMapCollection GetAll(SecurityToken token)
		{

			W3000.Data.UsrAccountTenantMapDataCollection _result_ = UsrAccountTenantMapWrapper.GetAll( token);
			if(_result_ == null)
				return null;

			return new UsrAccountTenantMapCollection(_result_);
		}

		public static W3000.Data.UsrAccountTenantMapViewCollection GetViewAll()
		{
			return GetViewAll( Identity.Token);
		}

		public static W3000.Data.UsrAccountTenantMapViewCollection GetViewAll(SecurityToken token)
		{

			W3000.Data.UsrAccountTenantMapViewCollection _result_ = UsrAccountTenantMapWrapper.GetViewAll( token);
			if(_result_ == null)
				return null;

			return _result_;
		}

		public static UsrAccountTenantMapCollection GetByBDTenant(System.Guid BDTenantPK)
		{
			return GetByBDTenant(BDTenantPK, Identity.Token);
		}

		public static UsrAccountTenantMapCollection GetByBDTenant(System.Guid BDTenantPK, SecurityToken token)
		{

			W3000.Data.UsrAccountTenantMapDataCollection _result_ = UsrAccountTenantMapWrapper.GetByBDTenant(BDTenantPK, token);
			if(_result_ == null)
				return null;

			return new UsrAccountTenantMapCollection(_result_);
		}

		public static W3000.Data.UsrAccountTenantMapViewCollection GetViewByBDTenant(System.Guid BDTenantPK)
		{
			return GetViewByBDTenant(BDTenantPK, Identity.Token);
		}

		public static W3000.Data.UsrAccountTenantMapViewCollection GetViewByBDTenant(System.Guid BDTenantPK, SecurityToken token)
		{

			W3000.Data.UsrAccountTenantMapViewCollection _result_ = UsrAccountTenantMapWrapper.GetViewByBDTenant(BDTenantPK, token);
			if(_result_ == null)
				return null;

			return _result_;
		}

		public static UsrAccountTenantMapCollection GetByUsrAccount(System.Guid UsrAccountPK)
		{
			return GetByUsrAccount(UsrAccountPK, Identity.Token);
		}

		public static UsrAccountTenantMapCollection GetByUsrAccount(System.Guid UsrAccountPK, SecurityToken token)
		{

			W3000.Data.UsrAccountTenantMapDataCollection _result_ = UsrAccountTenantMapWrapper.GetByUsrAccount(UsrAccountPK, token);
			if(_result_ == null)
				return null;

			return new UsrAccountTenantMapCollection(_result_);
		}

		public static W3000.Data.UsrAccountTenantMapViewCollection GetViewByUsrAccount(System.Guid UsrAccountPK)
		{
			return GetViewByUsrAccount(UsrAccountPK, Identity.Token);
		}

		public static W3000.Data.UsrAccountTenantMapViewCollection GetViewByUsrAccount(System.Guid UsrAccountPK, SecurityToken token)
		{

			W3000.Data.UsrAccountTenantMapViewCollection _result_ = UsrAccountTenantMapWrapper.GetViewByUsrAccount(UsrAccountPK, token);
			if(_result_ == null)
				return null;

			return _result_;
		}

	}

	public partial class UsrGroupBRRule
	{
		public static Cheke.BusinessEntity.Result Purge(W3000.Data.UsrGroupBRRuleData entity)
		{
			return Purge(entity, Identity.Token);
		}

		public static Cheke.BusinessEntity.Result Purge(W3000.Data.UsrGroupBRRuleData entity, SecurityToken token)
		{
			if(entity != null)
			{
				entity = new W3000.Data.UsrGroupBRRuleData(entity);
			}

			Cheke.BusinessEntity.Result _result_ = UsrGroupBRRuleWrapper.Purge(entity, token);
			if(_result_ == null)
				return null;

			return _result_;
		}

		public static Cheke.BusinessEntity.Result Save(W3000.Data.UsrGroupBRRuleData entity)
		{
			return Save(entity, Identity.Token);
		}

		public static Cheke.BusinessEntity.Result Save(W3000.Data.UsrGroupBRRuleData entity, SecurityToken token)
		{
			if(entity != null)
			{
				entity = new W3000.Data.UsrGroupBRRuleData(entity);
			}

			Cheke.BusinessEntity.Result _result_ = UsrGroupBRRuleWrapper.Save(entity, token);
			if(_result_ == null)
				return null;

			return _result_;
		}

		public static Cheke.BusinessEntity.Result Save(W3000.Data.UsrGroupBRRuleDataCollection list)
		{
			return Save(list, Identity.Token);
		}

		public static Cheke.BusinessEntity.Result Save(W3000.Data.UsrGroupBRRuleDataCollection list, SecurityToken token)
		{
			if(list != null)
			{
				list = new W3000.Data.UsrGroupBRRuleDataCollection(list);
			}

			Cheke.BusinessEntity.Result _result_ = UsrGroupBRRuleWrapper.Save(list, token);
			if(_result_ == null)
				return null;

			return _result_;
		}

		public static UsrGroupBRRuleCollection GetByBRRuleID(System.Int32 BRRuleID)
		{
			return GetByBRRuleID(BRRuleID, Identity.Token);
		}

		public static UsrGroupBRRuleCollection GetByBRRuleID(System.Int32 BRRuleID, SecurityToken token)
		{

			W3000.Data.UsrGroupBRRuleDataCollection _result_ = UsrGroupBRRuleWrapper.GetByBRRuleID(BRRuleID, token);
			if(_result_ == null)
				return null;

			return new UsrGroupBRRuleCollection(_result_);
		}

		public static System.Int32 GetAllCount()
		{
			return GetAllCount( Identity.Token);
		}

		public static System.Int32 GetAllCount(SecurityToken token)
		{

			System.Int32 _result_ = UsrGroupBRRuleWrapper.GetAllCount( token);
			return _result_;
		}

		public static UsrGroupBRRuleCollection GetAllPage(System.Int32 pageIndex,System.Int32 pageSize)
		{
			return GetAllPage(pageIndex,pageSize, Identity.Token);
		}

		public static UsrGroupBRRuleCollection GetAllPage(System.Int32 pageIndex,System.Int32 pageSize, SecurityToken token)
		{

			W3000.Data.UsrGroupBRRuleDataCollection _result_ = UsrGroupBRRuleWrapper.GetAllPage(pageIndex,pageSize, token);
			if(_result_ == null)
				return null;

			return new UsrGroupBRRuleCollection(_result_);
		}

		public static UsrGroupBRRule GetByUK(System.Guid UsrGroupPK,System.Int32 BRRuleID)
		{
			return GetByUK(UsrGroupPK,BRRuleID, Identity.Token);
		}

		public static UsrGroupBRRule GetByUK(System.Guid UsrGroupPK,System.Int32 BRRuleID, SecurityToken token)
		{

			W3000.Data.UsrGroupBRRuleData _result_ = UsrGroupBRRuleWrapper.GetByUK(UsrGroupPK,BRRuleID, token);
			if(_result_ == null)
				return null;

			return new UsrGroupBRRule(_result_);
		}

		public static UsrGroupBRRule GetByBRRuleID(System.Int32 BRRuleID,System.String UsrGroupName)
		{
			return GetByBRRuleID(BRRuleID,UsrGroupName, Identity.Token);
		}

		public static UsrGroupBRRule GetByBRRuleID(System.Int32 BRRuleID,System.String UsrGroupName, SecurityToken token)
		{

			W3000.Data.UsrGroupBRRuleData _result_ = UsrGroupBRRuleWrapper.GetByBRRuleID(BRRuleID,UsrGroupName, token);
			if(_result_ == null)
				return null;

			return new UsrGroupBRRule(_result_);
		}

		public static UsrGroupBRRule GetByBRRuleID(System.Int32 BRRuleID,System.Guid UsrGroupPK)
		{
			return GetByBRRuleID(BRRuleID,UsrGroupPK, Identity.Token);
		}

		public static UsrGroupBRRule GetByBRRuleID(System.Int32 BRRuleID,System.Guid UsrGroupPK, SecurityToken token)
		{

			W3000.Data.UsrGroupBRRuleData _result_ = UsrGroupBRRuleWrapper.GetByBRRuleID(BRRuleID,UsrGroupPK, token);
			if(_result_ == null)
				return null;

			return new UsrGroupBRRule(_result_);
		}

		public static UsrGroupBRRule GetByPK(System.Guid UsrGroupBRRule)
		{
			return GetByPK(UsrGroupBRRule, Identity.Token);
		}

		public static UsrGroupBRRule GetByPK(System.Guid UsrGroupBRRule, SecurityToken token)
		{

			W3000.Data.UsrGroupBRRuleData _result_ = UsrGroupBRRuleWrapper.GetByPK(UsrGroupBRRule, token);
			if(_result_ == null)
				return null;

			return new UsrGroupBRRule(_result_);
		}

		public static UsrGroupBRRuleCollection GetAll()
		{
			return GetAll( Identity.Token);
		}

		public static UsrGroupBRRuleCollection GetAll(SecurityToken token)
		{

			W3000.Data.UsrGroupBRRuleDataCollection _result_ = UsrGroupBRRuleWrapper.GetAll( token);
			if(_result_ == null)
				return null;

			return new UsrGroupBRRuleCollection(_result_);
		}

		public static W3000.Data.UsrGroupBRRuleViewCollection GetViewAll()
		{
			return GetViewAll( Identity.Token);
		}

		public static W3000.Data.UsrGroupBRRuleViewCollection GetViewAll(SecurityToken token)
		{

			W3000.Data.UsrGroupBRRuleViewCollection _result_ = UsrGroupBRRuleWrapper.GetViewAll( token);
			if(_result_ == null)
				return null;

			return _result_;
		}

		public static UsrGroupBRRuleCollection GetByUsrGroup(System.Guid UsrGroupPK)
		{
			return GetByUsrGroup(UsrGroupPK, Identity.Token);
		}

		public static UsrGroupBRRuleCollection GetByUsrGroup(System.Guid UsrGroupPK, SecurityToken token)
		{

			W3000.Data.UsrGroupBRRuleDataCollection _result_ = UsrGroupBRRuleWrapper.GetByUsrGroup(UsrGroupPK, token);
			if(_result_ == null)
				return null;

			return new UsrGroupBRRuleCollection(_result_);
		}

		public static W3000.Data.UsrGroupBRRuleViewCollection GetViewByUsrGroup(System.Guid UsrGroupPK)
		{
			return GetViewByUsrGroup(UsrGroupPK, Identity.Token);
		}

		public static W3000.Data.UsrGroupBRRuleViewCollection GetViewByUsrGroup(System.Guid UsrGroupPK, SecurityToken token)
		{

			W3000.Data.UsrGroupBRRuleViewCollection _result_ = UsrGroupBRRuleWrapper.GetViewByUsrGroup(UsrGroupPK, token);
			if(_result_ == null)
				return null;

			return _result_;
		}

	}

	public partial class UsrGroup
	{
		public static Cheke.BusinessEntity.Result Purge(W3000.Data.UsrGroupData entity)
		{
			return Purge(entity, Identity.Token);
		}

		public static Cheke.BusinessEntity.Result Purge(W3000.Data.UsrGroupData entity, SecurityToken token)
		{
			if(entity != null)
			{
				entity = new W3000.Data.UsrGroupData(entity);
			}

			Cheke.BusinessEntity.Result _result_ = UsrGroupWrapper.Purge(entity, token);
			if(_result_ == null)
				return null;

			return _result_;
		}

		public static Cheke.BusinessEntity.Result Save(W3000.Data.UsrGroupData entity)
		{
			return Save(entity, Identity.Token);
		}

		public static Cheke.BusinessEntity.Result Save(W3000.Data.UsrGroupData entity, SecurityToken token)
		{
			if(entity != null)
			{
				entity = new W3000.Data.UsrGroupData(entity);
			}

			Cheke.BusinessEntity.Result _result_ = UsrGroupWrapper.Save(entity, token);
			if(_result_ == null)
				return null;

			return _result_;
		}

		public static Cheke.BusinessEntity.Result Save(W3000.Data.UsrGroupDataCollection list)
		{
			return Save(list, Identity.Token);
		}

		public static Cheke.BusinessEntity.Result Save(W3000.Data.UsrGroupDataCollection list, SecurityToken token)
		{
			if(list != null)
			{
				list = new W3000.Data.UsrGroupDataCollection(list);
			}

			Cheke.BusinessEntity.Result _result_ = UsrGroupWrapper.Save(list, token);
			if(_result_ == null)
				return null;

			return _result_;
		}

		public static System.Int32 GetAllCount()
		{
			return GetAllCount( Identity.Token);
		}

		public static System.Int32 GetAllCount(SecurityToken token)
		{

			System.Int32 _result_ = UsrGroupWrapper.GetAllCount( token);
			return _result_;
		}

		public static UsrGroupCollection GetAllPage(System.Int32 pageIndex,System.Int32 pageSize)
		{
			return GetAllPage(pageIndex,pageSize, Identity.Token);
		}

		public static UsrGroupCollection GetAllPage(System.Int32 pageIndex,System.Int32 pageSize, SecurityToken token)
		{

			W3000.Data.UsrGroupDataCollection _result_ = UsrGroupWrapper.GetAllPage(pageIndex,pageSize, token);
			if(_result_ == null)
				return null;

			return new UsrGroupCollection(_result_);
		}

		public static UsrGroup GetByUsrGroupName(System.String UsrGroupName)
		{
			return GetByUsrGroupName(UsrGroupName, Identity.Token);
		}

		public static UsrGroup GetByUsrGroupName(System.String UsrGroupName, SecurityToken token)
		{

			W3000.Data.UsrGroupData _result_ = UsrGroupWrapper.GetByUsrGroupName(UsrGroupName, token);
			if(_result_ == null)
				return null;

			return new UsrGroup(_result_);
		}

		public static UsrGroup GetByPK(System.Guid UsrGroupPK)
		{
			return GetByPK(UsrGroupPK, Identity.Token);
		}

		public static UsrGroup GetByPK(System.Guid UsrGroupPK, SecurityToken token)
		{

			W3000.Data.UsrGroupData _result_ = UsrGroupWrapper.GetByPK(UsrGroupPK, token);
			if(_result_ == null)
				return null;

			return new UsrGroup(_result_);
		}

		public static UsrGroupCollection GetAll()
		{
			return GetAll( Identity.Token);
		}

		public static UsrGroupCollection GetAll(SecurityToken token)
		{

			W3000.Data.UsrGroupDataCollection _result_ = UsrGroupWrapper.GetAll( token);
			if(_result_ == null)
				return null;

			return new UsrGroupCollection(_result_);
		}

		public static W3000.Data.UsrGroupViewCollection GetViewAll()
		{
			return GetViewAll( Identity.Token);
		}

		public static W3000.Data.UsrGroupViewCollection GetViewAll(SecurityToken token)
		{

			W3000.Data.UsrGroupViewCollection _result_ = UsrGroupWrapper.GetViewAll( token);
			if(_result_ == null)
				return null;

			return _result_;
		}

	}

	public partial class UsrGroupDBRule
	{
		public static Cheke.BusinessEntity.Result Purge(W3000.Data.UsrGroupDBRuleData entity)
		{
			return Purge(entity, Identity.Token);
		}

		public static Cheke.BusinessEntity.Result Purge(W3000.Data.UsrGroupDBRuleData entity, SecurityToken token)
		{
			if(entity != null)
			{
				entity = new W3000.Data.UsrGroupDBRuleData(entity);
			}

			Cheke.BusinessEntity.Result _result_ = UsrGroupDBRuleWrapper.Purge(entity, token);
			if(_result_ == null)
				return null;

			return _result_;
		}

		public static Cheke.BusinessEntity.Result Save(W3000.Data.UsrGroupDBRuleData entity)
		{
			return Save(entity, Identity.Token);
		}

		public static Cheke.BusinessEntity.Result Save(W3000.Data.UsrGroupDBRuleData entity, SecurityToken token)
		{
			if(entity != null)
			{
				entity = new W3000.Data.UsrGroupDBRuleData(entity);
			}

			Cheke.BusinessEntity.Result _result_ = UsrGroupDBRuleWrapper.Save(entity, token);
			if(_result_ == null)
				return null;

			return _result_;
		}

		public static Cheke.BusinessEntity.Result Save(W3000.Data.UsrGroupDBRuleDataCollection list)
		{
			return Save(list, Identity.Token);
		}

		public static Cheke.BusinessEntity.Result Save(W3000.Data.UsrGroupDBRuleDataCollection list, SecurityToken token)
		{
			if(list != null)
			{
				list = new W3000.Data.UsrGroupDBRuleDataCollection(list);
			}

			Cheke.BusinessEntity.Result _result_ = UsrGroupDBRuleWrapper.Save(list, token);
			if(_result_ == null)
				return null;

			return _result_;
		}

		public static UsrGroupDBRuleCollection GetByDBRuleID(System.Int32 DBRuleID)
		{
			return GetByDBRuleID(DBRuleID, Identity.Token);
		}

		public static UsrGroupDBRuleCollection GetByDBRuleID(System.Int32 DBRuleID, SecurityToken token)
		{

			W3000.Data.UsrGroupDBRuleDataCollection _result_ = UsrGroupDBRuleWrapper.GetByDBRuleID(DBRuleID, token);
			if(_result_ == null)
				return null;

			return new UsrGroupDBRuleCollection(_result_);
		}

		public static System.Int32 GetAllCount()
		{
			return GetAllCount( Identity.Token);
		}

		public static System.Int32 GetAllCount(SecurityToken token)
		{

			System.Int32 _result_ = UsrGroupDBRuleWrapper.GetAllCount( token);
			return _result_;
		}

		public static UsrGroupDBRuleCollection GetAllPage(System.Int32 pageIndex,System.Int32 pageSize)
		{
			return GetAllPage(pageIndex,pageSize, Identity.Token);
		}

		public static UsrGroupDBRuleCollection GetAllPage(System.Int32 pageIndex,System.Int32 pageSize, SecurityToken token)
		{

			W3000.Data.UsrGroupDBRuleDataCollection _result_ = UsrGroupDBRuleWrapper.GetAllPage(pageIndex,pageSize, token);
			if(_result_ == null)
				return null;

			return new UsrGroupDBRuleCollection(_result_);
		}

		public static UsrGroupDBRule GetByUK(System.Guid UsrGroupPK,System.Int32 DBRuleID)
		{
			return GetByUK(UsrGroupPK,DBRuleID, Identity.Token);
		}

		public static UsrGroupDBRule GetByUK(System.Guid UsrGroupPK,System.Int32 DBRuleID, SecurityToken token)
		{

			W3000.Data.UsrGroupDBRuleData _result_ = UsrGroupDBRuleWrapper.GetByUK(UsrGroupPK,DBRuleID, token);
			if(_result_ == null)
				return null;

			return new UsrGroupDBRule(_result_);
		}

		public static UsrGroupDBRule GetByPK(System.Guid UsrGroupDBRulePK)
		{
			return GetByPK(UsrGroupDBRulePK, Identity.Token);
		}

		public static UsrGroupDBRule GetByPK(System.Guid UsrGroupDBRulePK, SecurityToken token)
		{

			W3000.Data.UsrGroupDBRuleData _result_ = UsrGroupDBRuleWrapper.GetByPK(UsrGroupDBRulePK, token);
			if(_result_ == null)
				return null;

			return new UsrGroupDBRule(_result_);
		}

		public static UsrGroupDBRuleCollection GetAll()
		{
			return GetAll( Identity.Token);
		}

		public static UsrGroupDBRuleCollection GetAll(SecurityToken token)
		{

			W3000.Data.UsrGroupDBRuleDataCollection _result_ = UsrGroupDBRuleWrapper.GetAll( token);
			if(_result_ == null)
				return null;

			return new UsrGroupDBRuleCollection(_result_);
		}

		public static W3000.Data.UsrGroupDBRuleViewCollection GetViewAll()
		{
			return GetViewAll( Identity.Token);
		}

		public static W3000.Data.UsrGroupDBRuleViewCollection GetViewAll(SecurityToken token)
		{

			W3000.Data.UsrGroupDBRuleViewCollection _result_ = UsrGroupDBRuleWrapper.GetViewAll( token);
			if(_result_ == null)
				return null;

			return _result_;
		}

		public static UsrGroupDBRuleCollection GetByUsrGroup(System.Guid UsrGroupPK)
		{
			return GetByUsrGroup(UsrGroupPK, Identity.Token);
		}

		public static UsrGroupDBRuleCollection GetByUsrGroup(System.Guid UsrGroupPK, SecurityToken token)
		{

			W3000.Data.UsrGroupDBRuleDataCollection _result_ = UsrGroupDBRuleWrapper.GetByUsrGroup(UsrGroupPK, token);
			if(_result_ == null)
				return null;

			return new UsrGroupDBRuleCollection(_result_);
		}

		public static W3000.Data.UsrGroupDBRuleViewCollection GetViewByUsrGroup(System.Guid UsrGroupPK)
		{
			return GetViewByUsrGroup(UsrGroupPK, Identity.Token);
		}

		public static W3000.Data.UsrGroupDBRuleViewCollection GetViewByUsrGroup(System.Guid UsrGroupPK, SecurityToken token)
		{

			W3000.Data.UsrGroupDBRuleViewCollection _result_ = UsrGroupDBRuleWrapper.GetViewByUsrGroup(UsrGroupPK, token);
			if(_result_ == null)
				return null;

			return _result_;
		}

	}

	public partial class UtilHoliday
	{
		public static Cheke.BusinessEntity.Result Purge(W3000.Data.UtilHolidayData entity)
		{
			return Purge(entity, Identity.Token);
		}

		public static Cheke.BusinessEntity.Result Purge(W3000.Data.UtilHolidayData entity, SecurityToken token)
		{
			if(entity != null)
			{
				entity = new W3000.Data.UtilHolidayData(entity);
			}

			Cheke.BusinessEntity.Result _result_ = UtilHolidayWrapper.Purge(entity, token);
			if(_result_ == null)
				return null;

			return _result_;
		}

		public static Cheke.BusinessEntity.Result Save(W3000.Data.UtilHolidayData entity)
		{
			return Save(entity, Identity.Token);
		}

		public static Cheke.BusinessEntity.Result Save(W3000.Data.UtilHolidayData entity, SecurityToken token)
		{
			if(entity != null)
			{
				entity = new W3000.Data.UtilHolidayData(entity);
			}

			Cheke.BusinessEntity.Result _result_ = UtilHolidayWrapper.Save(entity, token);
			if(_result_ == null)
				return null;

			return _result_;
		}

		public static Cheke.BusinessEntity.Result Save(W3000.Data.UtilHolidayDataCollection list)
		{
			return Save(list, Identity.Token);
		}

		public static Cheke.BusinessEntity.Result Save(W3000.Data.UtilHolidayDataCollection list, SecurityToken token)
		{
			if(list != null)
			{
				list = new W3000.Data.UtilHolidayDataCollection(list);
			}

			Cheke.BusinessEntity.Result _result_ = UtilHolidayWrapper.Save(list, token);
			if(_result_ == null)
				return null;

			return _result_;
		}

		public static UtilHolidayCollection GetByCountryID(System.Int32 CountryID)
		{
			return GetByCountryID(CountryID, Identity.Token);
		}

		public static UtilHolidayCollection GetByCountryID(System.Int32 CountryID, SecurityToken token)
		{

			W3000.Data.UtilHolidayDataCollection _result_ = UtilHolidayWrapper.GetByCountryID(CountryID, token);
			if(_result_ == null)
				return null;

			return new UtilHolidayCollection(_result_);
		}

		public static UtilHolidayCollection GetByModifiedOn(System.DateTime begin,System.DateTime end)
		{
			return GetByModifiedOn(begin,end, Identity.Token);
		}

		public static UtilHolidayCollection GetByModifiedOn(System.DateTime begin,System.DateTime end, SecurityToken token)
		{

			W3000.Data.UtilHolidayDataCollection _result_ = UtilHolidayWrapper.GetByModifiedOn(begin,end, token);
			if(_result_ == null)
				return null;

			return new UtilHolidayCollection(_result_);
		}

		public static UtilHolidayCollection GetByMappedACInterval(System.Guid ACIntervalPK)
		{
			return GetByMappedACInterval(ACIntervalPK, Identity.Token);
		}

		public static UtilHolidayCollection GetByMappedACInterval(System.Guid ACIntervalPK, SecurityToken token)
		{

			W3000.Data.UtilHolidayDataCollection _result_ = UtilHolidayWrapper.GetByMappedACInterval(ACIntervalPK, token);
			if(_result_ == null)
				return null;

			return new UtilHolidayCollection(_result_);
		}

		public static UtilHolidayCollection GetByMappedACPanel(System.Guid ACPanelPK)
		{
			return GetByMappedACPanel(ACPanelPK, Identity.Token);
		}

		public static UtilHolidayCollection GetByMappedACPanel(System.Guid ACPanelPK, SecurityToken token)
		{

			W3000.Data.UtilHolidayDataCollection _result_ = UtilHolidayWrapper.GetByMappedACPanel(ACPanelPK, token);
			if(_result_ == null)
				return null;

			return new UtilHolidayCollection(_result_);
		}

		public static UtilHolidayCollection GetByMappedBDBuilding(System.Guid BDBuildingPK)
		{
			return GetByMappedBDBuilding(BDBuildingPK, Identity.Token);
		}

		public static UtilHolidayCollection GetByMappedBDBuilding(System.Guid BDBuildingPK, SecurityToken token)
		{

			W3000.Data.UtilHolidayDataCollection _result_ = UtilHolidayWrapper.GetByMappedBDBuilding(BDBuildingPK, token);
			if(_result_ == null)
				return null;

			return new UtilHolidayCollection(_result_);
		}

		public static UtilHolidayCollection GetByMappedBDTenant(System.Guid BDTenantPK)
		{
			return GetByMappedBDTenant(BDTenantPK, Identity.Token);
		}

		public static UtilHolidayCollection GetByMappedBDTenant(System.Guid BDTenantPK, SecurityToken token)
		{

			W3000.Data.UtilHolidayDataCollection _result_ = UtilHolidayWrapper.GetByMappedBDTenant(BDTenantPK, token);
			if(_result_ == null)
				return null;

			return new UtilHolidayCollection(_result_);
		}

		public static System.Int32 GetAllCount()
		{
			return GetAllCount( Identity.Token);
		}

		public static System.Int32 GetAllCount(SecurityToken token)
		{

			System.Int32 _result_ = UtilHolidayWrapper.GetAllCount( token);
			return _result_;
		}

		public static UtilHolidayCollection GetAllPage(System.Int32 pageIndex,System.Int32 pageSize)
		{
			return GetAllPage(pageIndex,pageSize, Identity.Token);
		}

		public static UtilHolidayCollection GetAllPage(System.Int32 pageIndex,System.Int32 pageSize, SecurityToken token)
		{

			W3000.Data.UtilHolidayDataCollection _result_ = UtilHolidayWrapper.GetAllPage(pageIndex,pageSize, token);
			if(_result_ == null)
				return null;

			return new UtilHolidayCollection(_result_);
		}

		public static UtilHoliday GetByUK(System.Int32 CountryID,System.String Holiday)
		{
			return GetByUK(CountryID,Holiday, Identity.Token);
		}

		public static UtilHoliday GetByUK(System.Int32 CountryID,System.String Holiday, SecurityToken token)
		{

			W3000.Data.UtilHolidayData _result_ = UtilHolidayWrapper.GetByUK(CountryID,Holiday, token);
			if(_result_ == null)
				return null;

			return new UtilHoliday(_result_);
		}

		public static UtilHoliday GetByUK1(System.DateTime Date,System.Int32 CountryID)
		{
			return GetByUK1(Date,CountryID, Identity.Token);
		}

		public static UtilHoliday GetByUK1(System.DateTime Date,System.Int32 CountryID, SecurityToken token)
		{

			W3000.Data.UtilHolidayData _result_ = UtilHolidayWrapper.GetByUK1(Date,CountryID, token);
			if(_result_ == null)
				return null;

			return new UtilHoliday(_result_);
		}

		public static UtilHoliday GetByPK(System.Guid UtilHolidayPK)
		{
			return GetByPK(UtilHolidayPK, Identity.Token);
		}

		public static UtilHoliday GetByPK(System.Guid UtilHolidayPK, SecurityToken token)
		{

			W3000.Data.UtilHolidayData _result_ = UtilHolidayWrapper.GetByPK(UtilHolidayPK, token);
			if(_result_ == null)
				return null;

			return new UtilHoliday(_result_);
		}

		public static UtilHolidayCollection GetAll()
		{
			return GetAll( Identity.Token);
		}

		public static UtilHolidayCollection GetAll(SecurityToken token)
		{

			W3000.Data.UtilHolidayDataCollection _result_ = UtilHolidayWrapper.GetAll( token);
			if(_result_ == null)
				return null;

			return new UtilHolidayCollection(_result_);
		}

		public static W3000.Data.UtilHolidayViewCollection GetViewAll()
		{
			return GetViewAll( Identity.Token);
		}

		public static W3000.Data.UtilHolidayViewCollection GetViewAll(SecurityToken token)
		{

			W3000.Data.UtilHolidayViewCollection _result_ = UtilHolidayWrapper.GetViewAll( token);
			if(_result_ == null)
				return null;

			return _result_;
		}

	}

	public partial class UtilSettingCategory
	{
		public static Cheke.BusinessEntity.Result Purge(W3000.Data.UtilSettingCategoryData entity)
		{
			return Purge(entity, Identity.Token);
		}

		public static Cheke.BusinessEntity.Result Purge(W3000.Data.UtilSettingCategoryData entity, SecurityToken token)
		{
			if(entity != null)
			{
				entity = new W3000.Data.UtilSettingCategoryData(entity);
			}

			Cheke.BusinessEntity.Result _result_ = UtilSettingCategoryWrapper.Purge(entity, token);
			if(_result_ == null)
				return null;

			return _result_;
		}

		public static Cheke.BusinessEntity.Result Save(W3000.Data.UtilSettingCategoryData entity)
		{
			return Save(entity, Identity.Token);
		}

		public static Cheke.BusinessEntity.Result Save(W3000.Data.UtilSettingCategoryData entity, SecurityToken token)
		{
			if(entity != null)
			{
				entity = new W3000.Data.UtilSettingCategoryData(entity);
			}

			Cheke.BusinessEntity.Result _result_ = UtilSettingCategoryWrapper.Save(entity, token);
			if(_result_ == null)
				return null;

			return _result_;
		}

		public static Cheke.BusinessEntity.Result Save(W3000.Data.UtilSettingCategoryDataCollection list)
		{
			return Save(list, Identity.Token);
		}

		public static Cheke.BusinessEntity.Result Save(W3000.Data.UtilSettingCategoryDataCollection list, SecurityToken token)
		{
			if(list != null)
			{
				list = new W3000.Data.UtilSettingCategoryDataCollection(list);
			}

			Cheke.BusinessEntity.Result _result_ = UtilSettingCategoryWrapper.Save(list, token);
			if(_result_ == null)
				return null;

			return _result_;
		}

		public static UtilSettingCategoryCollection GetBySettingCategoryID(System.Int32 SettingCategoryID)
		{
			return GetBySettingCategoryID(SettingCategoryID, Identity.Token);
		}

		public static UtilSettingCategoryCollection GetBySettingCategoryID(System.Int32 SettingCategoryID, SecurityToken token)
		{

			W3000.Data.UtilSettingCategoryDataCollection _result_ = UtilSettingCategoryWrapper.GetBySettingCategoryID(SettingCategoryID, token);
			if(_result_ == null)
				return null;

			return new UtilSettingCategoryCollection(_result_);
		}

		public static UtilSettingCategoryCollection GetByModifiedOn(System.DateTime begin,System.DateTime end)
		{
			return GetByModifiedOn(begin,end, Identity.Token);
		}

		public static UtilSettingCategoryCollection GetByModifiedOn(System.DateTime begin,System.DateTime end, SecurityToken token)
		{

			W3000.Data.UtilSettingCategoryDataCollection _result_ = UtilSettingCategoryWrapper.GetByModifiedOn(begin,end, token);
			if(_result_ == null)
				return null;

			return new UtilSettingCategoryCollection(_result_);
		}

		public static System.Int32 GetAllCount()
		{
			return GetAllCount( Identity.Token);
		}

		public static System.Int32 GetAllCount(SecurityToken token)
		{

			System.Int32 _result_ = UtilSettingCategoryWrapper.GetAllCount( token);
			return _result_;
		}

		public static UtilSettingCategoryCollection GetAllPage(System.Int32 pageIndex,System.Int32 pageSize)
		{
			return GetAllPage(pageIndex,pageSize, Identity.Token);
		}

		public static UtilSettingCategoryCollection GetAllPage(System.Int32 pageIndex,System.Int32 pageSize, SecurityToken token)
		{

			W3000.Data.UtilSettingCategoryDataCollection _result_ = UtilSettingCategoryWrapper.GetAllPage(pageIndex,pageSize, token);
			if(_result_ == null)
				return null;

			return new UtilSettingCategoryCollection(_result_);
		}

		public static UtilSettingCategory GetByUK(System.Int32 SettingCategoryID,System.String InstanceName)
		{
			return GetByUK(SettingCategoryID,InstanceName, Identity.Token);
		}

		public static UtilSettingCategory GetByUK(System.Int32 SettingCategoryID,System.String InstanceName, SecurityToken token)
		{

			W3000.Data.UtilSettingCategoryData _result_ = UtilSettingCategoryWrapper.GetByUK(SettingCategoryID,InstanceName, token);
			if(_result_ == null)
				return null;

			return new UtilSettingCategory(_result_);
		}

		public static UtilSettingCategory GetByPK(System.Guid UtilSettingCategoryPK)
		{
			return GetByPK(UtilSettingCategoryPK, Identity.Token);
		}

		public static UtilSettingCategory GetByPK(System.Guid UtilSettingCategoryPK, SecurityToken token)
		{

			W3000.Data.UtilSettingCategoryData _result_ = UtilSettingCategoryWrapper.GetByPK(UtilSettingCategoryPK, token);
			if(_result_ == null)
				return null;

			return new UtilSettingCategory(_result_);
		}

		public static UtilSettingCategoryCollection GetAll()
		{
			return GetAll( Identity.Token);
		}

		public static UtilSettingCategoryCollection GetAll(SecurityToken token)
		{

			W3000.Data.UtilSettingCategoryDataCollection _result_ = UtilSettingCategoryWrapper.GetAll( token);
			if(_result_ == null)
				return null;

			return new UtilSettingCategoryCollection(_result_);
		}

		public static W3000.Data.UtilSettingCategoryViewCollection GetViewAll()
		{
			return GetViewAll( Identity.Token);
		}

		public static W3000.Data.UtilSettingCategoryViewCollection GetViewAll(SecurityToken token)
		{

			W3000.Data.UtilSettingCategoryViewCollection _result_ = UtilSettingCategoryWrapper.GetViewAll( token);
			if(_result_ == null)
				return null;

			return _result_;
		}

	}

	public partial class UtilSettingDetail
	{
		public static Cheke.BusinessEntity.Result Purge(W3000.Data.UtilSettingDetailData entity)
		{
			return Purge(entity, Identity.Token);
		}

		public static Cheke.BusinessEntity.Result Purge(W3000.Data.UtilSettingDetailData entity, SecurityToken token)
		{
			if(entity != null)
			{
				entity = new W3000.Data.UtilSettingDetailData(entity);
			}

			Cheke.BusinessEntity.Result _result_ = UtilSettingDetailWrapper.Purge(entity, token);
			if(_result_ == null)
				return null;

			return _result_;
		}

		public static Cheke.BusinessEntity.Result Save(W3000.Data.UtilSettingDetailData entity)
		{
			return Save(entity, Identity.Token);
		}

		public static Cheke.BusinessEntity.Result Save(W3000.Data.UtilSettingDetailData entity, SecurityToken token)
		{
			if(entity != null)
			{
				entity = new W3000.Data.UtilSettingDetailData(entity);
			}

			Cheke.BusinessEntity.Result _result_ = UtilSettingDetailWrapper.Save(entity, token);
			if(_result_ == null)
				return null;

			return _result_;
		}

		public static Cheke.BusinessEntity.Result Save(W3000.Data.UtilSettingDetailDataCollection list)
		{
			return Save(list, Identity.Token);
		}

		public static Cheke.BusinessEntity.Result Save(W3000.Data.UtilSettingDetailDataCollection list, SecurityToken token)
		{
			if(list != null)
			{
				list = new W3000.Data.UtilSettingDetailDataCollection(list);
			}

			Cheke.BusinessEntity.Result _result_ = UtilSettingDetailWrapper.Save(list, token);
			if(_result_ == null)
				return null;

			return _result_;
		}

		public static UtilSettingDetailCollection GetByModifiedOn(System.DateTime begin,System.DateTime end)
		{
			return GetByModifiedOn(begin,end, Identity.Token);
		}

		public static UtilSettingDetailCollection GetByModifiedOn(System.DateTime begin,System.DateTime end, SecurityToken token)
		{

			W3000.Data.UtilSettingDetailDataCollection _result_ = UtilSettingDetailWrapper.GetByModifiedOn(begin,end, token);
			if(_result_ == null)
				return null;

			return new UtilSettingDetailCollection(_result_);
		}

		public static System.Int32 GetAllCount()
		{
			return GetAllCount( Identity.Token);
		}

		public static System.Int32 GetAllCount(SecurityToken token)
		{

			System.Int32 _result_ = UtilSettingDetailWrapper.GetAllCount( token);
			return _result_;
		}

		public static UtilSettingDetailCollection GetAllPage(System.Int32 pageIndex,System.Int32 pageSize)
		{
			return GetAllPage(pageIndex,pageSize, Identity.Token);
		}

		public static UtilSettingDetailCollection GetAllPage(System.Int32 pageIndex,System.Int32 pageSize, SecurityToken token)
		{

			W3000.Data.UtilSettingDetailDataCollection _result_ = UtilSettingDetailWrapper.GetAllPage(pageIndex,pageSize, token);
			if(_result_ == null)
				return null;

			return new UtilSettingDetailCollection(_result_);
		}

		public static UtilSettingDetail GetByUK(System.Guid UtilSettingCategoryPK,System.String FieldName)
		{
			return GetByUK(UtilSettingCategoryPK,FieldName, Identity.Token);
		}

		public static UtilSettingDetail GetByUK(System.Guid UtilSettingCategoryPK,System.String FieldName, SecurityToken token)
		{

			W3000.Data.UtilSettingDetailData _result_ = UtilSettingDetailWrapper.GetByUK(UtilSettingCategoryPK,FieldName, token);
			if(_result_ == null)
				return null;

			return new UtilSettingDetail(_result_);
		}

		public static UtilSettingDetail GetByPK(System.Guid UtilSettingDetailPK)
		{
			return GetByPK(UtilSettingDetailPK, Identity.Token);
		}

		public static UtilSettingDetail GetByPK(System.Guid UtilSettingDetailPK, SecurityToken token)
		{

			W3000.Data.UtilSettingDetailData _result_ = UtilSettingDetailWrapper.GetByPK(UtilSettingDetailPK, token);
			if(_result_ == null)
				return null;

			return new UtilSettingDetail(_result_);
		}

		public static UtilSettingDetailCollection GetAll()
		{
			return GetAll( Identity.Token);
		}

		public static UtilSettingDetailCollection GetAll(SecurityToken token)
		{

			W3000.Data.UtilSettingDetailDataCollection _result_ = UtilSettingDetailWrapper.GetAll( token);
			if(_result_ == null)
				return null;

			return new UtilSettingDetailCollection(_result_);
		}

		public static W3000.Data.UtilSettingDetailViewCollection GetViewAll()
		{
			return GetViewAll( Identity.Token);
		}

		public static W3000.Data.UtilSettingDetailViewCollection GetViewAll(SecurityToken token)
		{

			W3000.Data.UtilSettingDetailViewCollection _result_ = UtilSettingDetailWrapper.GetViewAll( token);
			if(_result_ == null)
				return null;

			return _result_;
		}

		public static UtilSettingDetailCollection GetByUtilSettingCategory(System.Guid UtilSettingCategoryPK)
		{
			return GetByUtilSettingCategory(UtilSettingCategoryPK, Identity.Token);
		}

		public static UtilSettingDetailCollection GetByUtilSettingCategory(System.Guid UtilSettingCategoryPK, SecurityToken token)
		{

			W3000.Data.UtilSettingDetailDataCollection _result_ = UtilSettingDetailWrapper.GetByUtilSettingCategory(UtilSettingCategoryPK, token);
			if(_result_ == null)
				return null;

			return new UtilSettingDetailCollection(_result_);
		}

		public static W3000.Data.UtilSettingDetailViewCollection GetViewByUtilSettingCategory(System.Guid UtilSettingCategoryPK)
		{
			return GetViewByUtilSettingCategory(UtilSettingCategoryPK, Identity.Token);
		}

		public static W3000.Data.UtilSettingDetailViewCollection GetViewByUtilSettingCategory(System.Guid UtilSettingCategoryPK, SecurityToken token)
		{

			W3000.Data.UtilSettingDetailViewCollection _result_ = UtilSettingDetailWrapper.GetViewByUtilSettingCategory(UtilSettingCategoryPK, token);
			if(_result_ == null)
				return null;

			return _result_;
		}

	}

}
