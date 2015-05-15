using System;
using System.Collections;
using Cheke.BusinessEntity;

namespace W3000.Data
{
	[Serializable]
	public class ACIntvalHolidayMapViewCollection : CollectionBase
	{
		private CollectionBlock _block = new CollectionBlock();
		public ACIntvalHolidayMapViewCollection()
		{
		}

		public ACIntvalHolidayMapViewCollection(ACIntvalHolidayMapDataCollection list)
		{
			foreach (ACIntvalHolidayMapData item in list)
			{
				this.List.Add(new ACIntvalHolidayMapView(item));
			}
			this._block.Size = list.Block.Size;
			this._block.Index = list.Block.Index;
			this._block.Count = list.Block.Count;
			this._block.Records = list.Block.Records;
		}

		public CollectionBlock Block
		{
			get{ return this._block; }
		}

		public ACIntvalHolidayMapDataCollection ToACIntvalHolidayMapDataCollection()
		{
			ACIntvalHolidayMapDataCollection retList = new ACIntvalHolidayMapDataCollection();
			foreach (ACIntvalHolidayMapView item in base.List)
			{
				retList.Add(item.ToACIntvalHolidayMapData());
			}

			retList.AcceptChanges();
			return retList;
		}

		public void Add(ACIntvalHolidayMapView entity)
		{
			this.List.Add(entity);
		}

		public void Insert(int index, ACIntvalHolidayMapView entity)
		{
			this.List.Insert(index, entity);
		}

		public void Remove(ACIntvalHolidayMapView entity)
		{
			this.List.Remove(entity);
		}

		public void AddRange(ACIntvalHolidayMapViewCollection list)
		{
			foreach (ACIntvalHolidayMapView item in list)
			{
				this.List.Add(item);
			}
		}

		public ACIntvalHolidayMapView this[int index]
		{
			get{ return (ACIntvalHolidayMapView)base.List[index]; }
			set{ base.List[index] = value; }
		}

		public ACIntvalHolidayMapViewCollection SubCollection()
		{
			ACIntvalHolidayMapViewCollection retList = new ACIntvalHolidayMapViewCollection();
			if (this.Count <= this.Block.Size)
			{
				retList.AddRange(this);

				retList.Block.Size = this.Block.Size;
				retList.Block.Count = 1;
				retList.Block.Index = 0;
				retList.Block.Records = this.Count;
				return retList;
			}

			int start = this.Block.Index * this.Block.Size;
			int count = this.Block.Size;
			for (int i = start; i < (start + count); i++)
			{
				if (i >= this.Count)
					break;

				retList.Add(this[i]);
			}

			retList.Block.Size = this.Block.Size;
			retList.Block.Index = this.Block.Index;
			retList.Block.Count = (this.Count / this.Block.Size) + (this.Count % this.Block.Size == 0 ? 0 : 1);
			retList.Block.Records = this.Count;

			return retList;
		}
	}
	[Serializable]
	public class ACAccessLevelDetailViewCollection : CollectionBase
	{
		private CollectionBlock _block = new CollectionBlock();
		public ACAccessLevelDetailViewCollection()
		{
		}

		public ACAccessLevelDetailViewCollection(ACAccessLevelDetailDataCollection list)
		{
			foreach (ACAccessLevelDetailData item in list)
			{
				this.List.Add(new ACAccessLevelDetailView(item));
			}
			this._block.Size = list.Block.Size;
			this._block.Index = list.Block.Index;
			this._block.Count = list.Block.Count;
			this._block.Records = list.Block.Records;
		}

		public CollectionBlock Block
		{
			get{ return this._block; }
		}

		public ACAccessLevelDetailDataCollection ToACAccessLevelDetailDataCollection()
		{
			ACAccessLevelDetailDataCollection retList = new ACAccessLevelDetailDataCollection();
			foreach (ACAccessLevelDetailView item in base.List)
			{
				retList.Add(item.ToACAccessLevelDetailData());
			}

			retList.AcceptChanges();
			return retList;
		}

		public void Add(ACAccessLevelDetailView entity)
		{
			this.List.Add(entity);
		}

		public void Insert(int index, ACAccessLevelDetailView entity)
		{
			this.List.Insert(index, entity);
		}

		public void Remove(ACAccessLevelDetailView entity)
		{
			this.List.Remove(entity);
		}

		public void AddRange(ACAccessLevelDetailViewCollection list)
		{
			foreach (ACAccessLevelDetailView item in list)
			{
				this.List.Add(item);
			}
		}

		public ACAccessLevelDetailView this[int index]
		{
			get{ return (ACAccessLevelDetailView)base.List[index]; }
			set{ base.List[index] = value; }
		}

		public ACAccessLevelDetailViewCollection SubCollection()
		{
			ACAccessLevelDetailViewCollection retList = new ACAccessLevelDetailViewCollection();
			if (this.Count <= this.Block.Size)
			{
				retList.AddRange(this);

				retList.Block.Size = this.Block.Size;
				retList.Block.Count = 1;
				retList.Block.Index = 0;
				retList.Block.Records = this.Count;
				return retList;
			}

			int start = this.Block.Index * this.Block.Size;
			int count = this.Block.Size;
			for (int i = start; i < (start + count); i++)
			{
				if (i >= this.Count)
					break;

				retList.Add(this[i]);
			}

			retList.Block.Size = this.Block.Size;
			retList.Block.Index = this.Block.Index;
			retList.Block.Count = (this.Count / this.Block.Size) + (this.Count % this.Block.Size == 0 ? 0 : 1);
			retList.Block.Records = this.Count;

			return retList;
		}
	}
	[Serializable]
	public class UsrAccountBuildingMapViewCollection : CollectionBase
	{
		private CollectionBlock _block = new CollectionBlock();
		public UsrAccountBuildingMapViewCollection()
		{
		}

		public UsrAccountBuildingMapViewCollection(UsrAccountBuildingMapDataCollection list)
		{
			foreach (UsrAccountBuildingMapData item in list)
			{
				this.List.Add(new UsrAccountBuildingMapView(item));
			}
			this._block.Size = list.Block.Size;
			this._block.Index = list.Block.Index;
			this._block.Count = list.Block.Count;
			this._block.Records = list.Block.Records;
		}

		public CollectionBlock Block
		{
			get{ return this._block; }
		}

		public UsrAccountBuildingMapDataCollection ToUsrAccountBuildingMapDataCollection()
		{
			UsrAccountBuildingMapDataCollection retList = new UsrAccountBuildingMapDataCollection();
			foreach (UsrAccountBuildingMapView item in base.List)
			{
				retList.Add(item.ToUsrAccountBuildingMapData());
			}

			retList.AcceptChanges();
			return retList;
		}

		public void Add(UsrAccountBuildingMapView entity)
		{
			this.List.Add(entity);
		}

		public void Insert(int index, UsrAccountBuildingMapView entity)
		{
			this.List.Insert(index, entity);
		}

		public void Remove(UsrAccountBuildingMapView entity)
		{
			this.List.Remove(entity);
		}

		public void AddRange(UsrAccountBuildingMapViewCollection list)
		{
			foreach (UsrAccountBuildingMapView item in list)
			{
				this.List.Add(item);
			}
		}

		public UsrAccountBuildingMapView this[int index]
		{
			get{ return (UsrAccountBuildingMapView)base.List[index]; }
			set{ base.List[index] = value; }
		}

		public UsrAccountBuildingMapViewCollection SubCollection()
		{
			UsrAccountBuildingMapViewCollection retList = new UsrAccountBuildingMapViewCollection();
			if (this.Count <= this.Block.Size)
			{
				retList.AddRange(this);

				retList.Block.Size = this.Block.Size;
				retList.Block.Count = 1;
				retList.Block.Index = 0;
				retList.Block.Records = this.Count;
				return retList;
			}

			int start = this.Block.Index * this.Block.Size;
			int count = this.Block.Size;
			for (int i = start; i < (start + count); i++)
			{
				if (i >= this.Count)
					break;

				retList.Add(this[i]);
			}

			retList.Block.Size = this.Block.Size;
			retList.Block.Index = this.Block.Index;
			retList.Block.Count = (this.Count / this.Block.Size) + (this.Count % this.Block.Size == 0 ? 0 : 1);
			retList.Block.Records = this.Count;

			return retList;
		}
	}
	[Serializable]
	public class BDBuildingViewCollection : CollectionBase
	{
		private CollectionBlock _block = new CollectionBlock();
		public BDBuildingViewCollection()
		{
		}

		public BDBuildingViewCollection(BDBuildingDataCollection list)
		{
			foreach (BDBuildingData item in list)
			{
				this.List.Add(new BDBuildingView(item));
			}
			this._block.Size = list.Block.Size;
			this._block.Index = list.Block.Index;
			this._block.Count = list.Block.Count;
			this._block.Records = list.Block.Records;
		}

		public CollectionBlock Block
		{
			get{ return this._block; }
		}

		public BDBuildingDataCollection ToBDBuildingDataCollection()
		{
			BDBuildingDataCollection retList = new BDBuildingDataCollection();
			foreach (BDBuildingView item in base.List)
			{
				retList.Add(item.ToBDBuildingData());
			}

			retList.AcceptChanges();
			return retList;
		}

		public void Add(BDBuildingView entity)
		{
			this.List.Add(entity);
		}

		public void Insert(int index, BDBuildingView entity)
		{
			this.List.Insert(index, entity);
		}

		public void Remove(BDBuildingView entity)
		{
			this.List.Remove(entity);
		}

		public void AddRange(BDBuildingViewCollection list)
		{
			foreach (BDBuildingView item in list)
			{
				this.List.Add(item);
			}
		}

		public BDBuildingView this[int index]
		{
			get{ return (BDBuildingView)base.List[index]; }
			set{ base.List[index] = value; }
		}

		public BDBuildingViewCollection SubCollection()
		{
			BDBuildingViewCollection retList = new BDBuildingViewCollection();
			if (this.Count <= this.Block.Size)
			{
				retList.AddRange(this);

				retList.Block.Size = this.Block.Size;
				retList.Block.Count = 1;
				retList.Block.Index = 0;
				retList.Block.Records = this.Count;
				return retList;
			}

			int start = this.Block.Index * this.Block.Size;
			int count = this.Block.Size;
			for (int i = start; i < (start + count); i++)
			{
				if (i >= this.Count)
					break;

				retList.Add(this[i]);
			}

			retList.Block.Size = this.Block.Size;
			retList.Block.Index = this.Block.Index;
			retList.Block.Count = (this.Count / this.Block.Size) + (this.Count % this.Block.Size == 0 ? 0 : 1);
			retList.Block.Records = this.Count;

			return retList;
		}
	}
	[Serializable]
	public class BDTenantViewCollection : CollectionBase
	{
		private CollectionBlock _block = new CollectionBlock();
		public BDTenantViewCollection()
		{
		}

		public BDTenantViewCollection(BDTenantDataCollection list)
		{
			foreach (BDTenantData item in list)
			{
				this.List.Add(new BDTenantView(item));
			}
			this._block.Size = list.Block.Size;
			this._block.Index = list.Block.Index;
			this._block.Count = list.Block.Count;
			this._block.Records = list.Block.Records;
		}

		public CollectionBlock Block
		{
			get{ return this._block; }
		}

		public BDTenantDataCollection ToBDTenantDataCollection()
		{
			BDTenantDataCollection retList = new BDTenantDataCollection();
			foreach (BDTenantView item in base.List)
			{
				retList.Add(item.ToBDTenantData());
			}

			retList.AcceptChanges();
			return retList;
		}

		public void Add(BDTenantView entity)
		{
			this.List.Add(entity);
		}

		public void Insert(int index, BDTenantView entity)
		{
			this.List.Insert(index, entity);
		}

		public void Remove(BDTenantView entity)
		{
			this.List.Remove(entity);
		}

		public void AddRange(BDTenantViewCollection list)
		{
			foreach (BDTenantView item in list)
			{
				this.List.Add(item);
			}
		}

		public BDTenantView this[int index]
		{
			get{ return (BDTenantView)base.List[index]; }
			set{ base.List[index] = value; }
		}

		public BDTenantViewCollection SubCollection()
		{
			BDTenantViewCollection retList = new BDTenantViewCollection();
			if (this.Count <= this.Block.Size)
			{
				retList.AddRange(this);

				retList.Block.Size = this.Block.Size;
				retList.Block.Count = 1;
				retList.Block.Index = 0;
				retList.Block.Records = this.Count;
				return retList;
			}

			int start = this.Block.Index * this.Block.Size;
			int count = this.Block.Size;
			for (int i = start; i < (start + count); i++)
			{
				if (i >= this.Count)
					break;

				retList.Add(this[i]);
			}

			retList.Block.Size = this.Block.Size;
			retList.Block.Index = this.Block.Index;
			retList.Block.Count = (this.Count / this.Block.Size) + (this.Count % this.Block.Size == 0 ? 0 : 1);
			retList.Block.Records = this.Count;

			return retList;
		}
	}
	[Serializable]
	public class UtilSettingCategoryViewCollection : CollectionBase
	{
		private CollectionBlock _block = new CollectionBlock();
		public UtilSettingCategoryViewCollection()
		{
		}

		public UtilSettingCategoryViewCollection(UtilSettingCategoryDataCollection list)
		{
			foreach (UtilSettingCategoryData item in list)
			{
				this.List.Add(new UtilSettingCategoryView(item));
			}
			this._block.Size = list.Block.Size;
			this._block.Index = list.Block.Index;
			this._block.Count = list.Block.Count;
			this._block.Records = list.Block.Records;
		}

		public CollectionBlock Block
		{
			get{ return this._block; }
		}

		public UtilSettingCategoryDataCollection ToUtilSettingCategoryDataCollection()
		{
			UtilSettingCategoryDataCollection retList = new UtilSettingCategoryDataCollection();
			foreach (UtilSettingCategoryView item in base.List)
			{
				retList.Add(item.ToUtilSettingCategoryData());
			}

			retList.AcceptChanges();
			return retList;
		}

		public void Add(UtilSettingCategoryView entity)
		{
			this.List.Add(entity);
		}

		public void Insert(int index, UtilSettingCategoryView entity)
		{
			this.List.Insert(index, entity);
		}

		public void Remove(UtilSettingCategoryView entity)
		{
			this.List.Remove(entity);
		}

		public void AddRange(UtilSettingCategoryViewCollection list)
		{
			foreach (UtilSettingCategoryView item in list)
			{
				this.List.Add(item);
			}
		}

		public UtilSettingCategoryView this[int index]
		{
			get{ return (UtilSettingCategoryView)base.List[index]; }
			set{ base.List[index] = value; }
		}

		public UtilSettingCategoryViewCollection SubCollection()
		{
			UtilSettingCategoryViewCollection retList = new UtilSettingCategoryViewCollection();
			if (this.Count <= this.Block.Size)
			{
				retList.AddRange(this);

				retList.Block.Size = this.Block.Size;
				retList.Block.Count = 1;
				retList.Block.Index = 0;
				retList.Block.Records = this.Count;
				return retList;
			}

			int start = this.Block.Index * this.Block.Size;
			int count = this.Block.Size;
			for (int i = start; i < (start + count); i++)
			{
				if (i >= this.Count)
					break;

				retList.Add(this[i]);
			}

			retList.Block.Size = this.Block.Size;
			retList.Block.Index = this.Block.Index;
			retList.Block.Count = (this.Count / this.Block.Size) + (this.Count % this.Block.Size == 0 ? 0 : 1);
			retList.Block.Records = this.Count;

			return retList;
		}
	}
	[Serializable]
	public class UtilSettingDetailViewCollection : CollectionBase
	{
		private CollectionBlock _block = new CollectionBlock();
		public UtilSettingDetailViewCollection()
		{
		}

		public UtilSettingDetailViewCollection(UtilSettingDetailDataCollection list)
		{
			foreach (UtilSettingDetailData item in list)
			{
				this.List.Add(new UtilSettingDetailView(item));
			}
			this._block.Size = list.Block.Size;
			this._block.Index = list.Block.Index;
			this._block.Count = list.Block.Count;
			this._block.Records = list.Block.Records;
		}

		public CollectionBlock Block
		{
			get{ return this._block; }
		}

		public UtilSettingDetailDataCollection ToUtilSettingDetailDataCollection()
		{
			UtilSettingDetailDataCollection retList = new UtilSettingDetailDataCollection();
			foreach (UtilSettingDetailView item in base.List)
			{
				retList.Add(item.ToUtilSettingDetailData());
			}

			retList.AcceptChanges();
			return retList;
		}

		public void Add(UtilSettingDetailView entity)
		{
			this.List.Add(entity);
		}

		public void Insert(int index, UtilSettingDetailView entity)
		{
			this.List.Insert(index, entity);
		}

		public void Remove(UtilSettingDetailView entity)
		{
			this.List.Remove(entity);
		}

		public void AddRange(UtilSettingDetailViewCollection list)
		{
			foreach (UtilSettingDetailView item in list)
			{
				this.List.Add(item);
			}
		}

		public UtilSettingDetailView this[int index]
		{
			get{ return (UtilSettingDetailView)base.List[index]; }
			set{ base.List[index] = value; }
		}

		public UtilSettingDetailViewCollection SubCollection()
		{
			UtilSettingDetailViewCollection retList = new UtilSettingDetailViewCollection();
			if (this.Count <= this.Block.Size)
			{
				retList.AddRange(this);

				retList.Block.Size = this.Block.Size;
				retList.Block.Count = 1;
				retList.Block.Index = 0;
				retList.Block.Records = this.Count;
				return retList;
			}

			int start = this.Block.Index * this.Block.Size;
			int count = this.Block.Size;
			for (int i = start; i < (start + count); i++)
			{
				if (i >= this.Count)
					break;

				retList.Add(this[i]);
			}

			retList.Block.Size = this.Block.Size;
			retList.Block.Index = this.Block.Index;
			retList.Block.Count = (this.Count / this.Block.Size) + (this.Count % this.Block.Size == 0 ? 0 : 1);
			retList.Block.Records = this.Count;

			return retList;
		}
	}
	[Serializable]
	public class ACOutputGroupMainZoneMapViewCollection : CollectionBase
	{
		private CollectionBlock _block = new CollectionBlock();
		public ACOutputGroupMainZoneMapViewCollection()
		{
		}

		public ACOutputGroupMainZoneMapViewCollection(ACOutputGroupMainZoneMapDataCollection list)
		{
			foreach (ACOutputGroupMainZoneMapData item in list)
			{
				this.List.Add(new ACOutputGroupMainZoneMapView(item));
			}
			this._block.Size = list.Block.Size;
			this._block.Index = list.Block.Index;
			this._block.Count = list.Block.Count;
			this._block.Records = list.Block.Records;
		}

		public CollectionBlock Block
		{
			get{ return this._block; }
		}

		public ACOutputGroupMainZoneMapDataCollection ToACOutputGroupMainZoneMapDataCollection()
		{
			ACOutputGroupMainZoneMapDataCollection retList = new ACOutputGroupMainZoneMapDataCollection();
			foreach (ACOutputGroupMainZoneMapView item in base.List)
			{
				retList.Add(item.ToACOutputGroupMainZoneMapData());
			}

			retList.AcceptChanges();
			return retList;
		}

		public void Add(ACOutputGroupMainZoneMapView entity)
		{
			this.List.Add(entity);
		}

		public void Insert(int index, ACOutputGroupMainZoneMapView entity)
		{
			this.List.Insert(index, entity);
		}

		public void Remove(ACOutputGroupMainZoneMapView entity)
		{
			this.List.Remove(entity);
		}

		public void AddRange(ACOutputGroupMainZoneMapViewCollection list)
		{
			foreach (ACOutputGroupMainZoneMapView item in list)
			{
				this.List.Add(item);
			}
		}

		public ACOutputGroupMainZoneMapView this[int index]
		{
			get{ return (ACOutputGroupMainZoneMapView)base.List[index]; }
			set{ base.List[index] = value; }
		}

		public ACOutputGroupMainZoneMapViewCollection SubCollection()
		{
			ACOutputGroupMainZoneMapViewCollection retList = new ACOutputGroupMainZoneMapViewCollection();
			if (this.Count <= this.Block.Size)
			{
				retList.AddRange(this);

				retList.Block.Size = this.Block.Size;
				retList.Block.Count = 1;
				retList.Block.Index = 0;
				retList.Block.Records = this.Count;
				return retList;
			}

			int start = this.Block.Index * this.Block.Size;
			int count = this.Block.Size;
			for (int i = start; i < (start + count); i++)
			{
				if (i >= this.Count)
					break;

				retList.Add(this[i]);
			}

			retList.Block.Size = this.Block.Size;
			retList.Block.Index = this.Block.Index;
			retList.Block.Count = (this.Count / this.Block.Size) + (this.Count % this.Block.Size == 0 ? 0 : 1);
			retList.Block.Records = this.Count;

			return retList;
		}
	}
	[Serializable]
	public class ACCardHolderViewCollection : CollectionBase
	{
		private CollectionBlock _block = new CollectionBlock();
		public ACCardHolderViewCollection()
		{
		}

		public ACCardHolderViewCollection(ACCardHolderDataCollection list)
		{
			foreach (ACCardHolderData item in list)
			{
				this.List.Add(new ACCardHolderView(item));
			}
			this._block.Size = list.Block.Size;
			this._block.Index = list.Block.Index;
			this._block.Count = list.Block.Count;
			this._block.Records = list.Block.Records;
		}

		public CollectionBlock Block
		{
			get{ return this._block; }
		}

		public ACCardHolderDataCollection ToACCardHolderDataCollection()
		{
			ACCardHolderDataCollection retList = new ACCardHolderDataCollection();
			foreach (ACCardHolderView item in base.List)
			{
				retList.Add(item.ToACCardHolderData());
			}

			retList.AcceptChanges();
			return retList;
		}

		public void Add(ACCardHolderView entity)
		{
			this.List.Add(entity);
		}

		public void Insert(int index, ACCardHolderView entity)
		{
			this.List.Insert(index, entity);
		}

		public void Remove(ACCardHolderView entity)
		{
			this.List.Remove(entity);
		}

		public void AddRange(ACCardHolderViewCollection list)
		{
			foreach (ACCardHolderView item in list)
			{
				this.List.Add(item);
			}
		}

		public ACCardHolderView this[int index]
		{
			get{ return (ACCardHolderView)base.List[index]; }
			set{ base.List[index] = value; }
		}

		public ACCardHolderViewCollection SubCollection()
		{
			ACCardHolderViewCollection retList = new ACCardHolderViewCollection();
			if (this.Count <= this.Block.Size)
			{
				retList.AddRange(this);

				retList.Block.Size = this.Block.Size;
				retList.Block.Count = 1;
				retList.Block.Index = 0;
				retList.Block.Records = this.Count;
				return retList;
			}

			int start = this.Block.Index * this.Block.Size;
			int count = this.Block.Size;
			for (int i = start; i < (start + count); i++)
			{
				if (i >= this.Count)
					break;

				retList.Add(this[i]);
			}

			retList.Block.Size = this.Block.Size;
			retList.Block.Index = this.Block.Index;
			retList.Block.Count = (this.Count / this.Block.Size) + (this.Count % this.Block.Size == 0 ? 0 : 1);
			retList.Block.Records = this.Count;

			return retList;
		}
	}
	[Serializable]
	public class ACMainZoneViewCollection : CollectionBase
	{
		private CollectionBlock _block = new CollectionBlock();
		public ACMainZoneViewCollection()
		{
		}

		public ACMainZoneViewCollection(ACMainZoneDataCollection list)
		{
			foreach (ACMainZoneData item in list)
			{
				this.List.Add(new ACMainZoneView(item));
			}
			this._block.Size = list.Block.Size;
			this._block.Index = list.Block.Index;
			this._block.Count = list.Block.Count;
			this._block.Records = list.Block.Records;
		}

		public CollectionBlock Block
		{
			get{ return this._block; }
		}

		public ACMainZoneDataCollection ToACMainZoneDataCollection()
		{
			ACMainZoneDataCollection retList = new ACMainZoneDataCollection();
			foreach (ACMainZoneView item in base.List)
			{
				retList.Add(item.ToACMainZoneData());
			}

			retList.AcceptChanges();
			return retList;
		}

		public void Add(ACMainZoneView entity)
		{
			this.List.Add(entity);
		}

		public void Insert(int index, ACMainZoneView entity)
		{
			this.List.Insert(index, entity);
		}

		public void Remove(ACMainZoneView entity)
		{
			this.List.Remove(entity);
		}

		public void AddRange(ACMainZoneViewCollection list)
		{
			foreach (ACMainZoneView item in list)
			{
				this.List.Add(item);
			}
		}

		public ACMainZoneView this[int index]
		{
			get{ return (ACMainZoneView)base.List[index]; }
			set{ base.List[index] = value; }
		}

		public ACMainZoneViewCollection SubCollection()
		{
			ACMainZoneViewCollection retList = new ACMainZoneViewCollection();
			if (this.Count <= this.Block.Size)
			{
				retList.AddRange(this);

				retList.Block.Size = this.Block.Size;
				retList.Block.Count = 1;
				retList.Block.Index = 0;
				retList.Block.Records = this.Count;
				return retList;
			}

			int start = this.Block.Index * this.Block.Size;
			int count = this.Block.Size;
			for (int i = start; i < (start + count); i++)
			{
				if (i >= this.Count)
					break;

				retList.Add(this[i]);
			}

			retList.Block.Size = this.Block.Size;
			retList.Block.Index = this.Block.Index;
			retList.Block.Count = (this.Count / this.Block.Size) + (this.Count % this.Block.Size == 0 ? 0 : 1);
			retList.Block.Records = this.Count;

			return retList;
		}
	}
	[Serializable]
	public class ACIntervalViewCollection : CollectionBase
	{
		private CollectionBlock _block = new CollectionBlock();
		public ACIntervalViewCollection()
		{
		}

		public ACIntervalViewCollection(ACIntervalDataCollection list)
		{
			foreach (ACIntervalData item in list)
			{
				this.List.Add(new ACIntervalView(item));
			}
			this._block.Size = list.Block.Size;
			this._block.Index = list.Block.Index;
			this._block.Count = list.Block.Count;
			this._block.Records = list.Block.Records;
		}

		public CollectionBlock Block
		{
			get{ return this._block; }
		}

		public ACIntervalDataCollection ToACIntervalDataCollection()
		{
			ACIntervalDataCollection retList = new ACIntervalDataCollection();
			foreach (ACIntervalView item in base.List)
			{
				retList.Add(item.ToACIntervalData());
			}

			retList.AcceptChanges();
			return retList;
		}

		public void Add(ACIntervalView entity)
		{
			this.List.Add(entity);
		}

		public void Insert(int index, ACIntervalView entity)
		{
			this.List.Insert(index, entity);
		}

		public void Remove(ACIntervalView entity)
		{
			this.List.Remove(entity);
		}

		public void AddRange(ACIntervalViewCollection list)
		{
			foreach (ACIntervalView item in list)
			{
				this.List.Add(item);
			}
		}

		public ACIntervalView this[int index]
		{
			get{ return (ACIntervalView)base.List[index]; }
			set{ base.List[index] = value; }
		}

		public ACIntervalViewCollection SubCollection()
		{
			ACIntervalViewCollection retList = new ACIntervalViewCollection();
			if (this.Count <= this.Block.Size)
			{
				retList.AddRange(this);

				retList.Block.Size = this.Block.Size;
				retList.Block.Count = 1;
				retList.Block.Index = 0;
				retList.Block.Records = this.Count;
				return retList;
			}

			int start = this.Block.Index * this.Block.Size;
			int count = this.Block.Size;
			for (int i = start; i < (start + count); i++)
			{
				if (i >= this.Count)
					break;

				retList.Add(this[i]);
			}

			retList.Block.Size = this.Block.Size;
			retList.Block.Index = this.Block.Index;
			retList.Block.Count = (this.Count / this.Block.Size) + (this.Count % this.Block.Size == 0 ? 0 : 1);
			retList.Block.Records = this.Count;

			return retList;
		}
	}
	[Serializable]
	public class ACPanelHolidayMapViewCollection : CollectionBase
	{
		private CollectionBlock _block = new CollectionBlock();
		public ACPanelHolidayMapViewCollection()
		{
		}

		public ACPanelHolidayMapViewCollection(ACPanelHolidayMapDataCollection list)
		{
			foreach (ACPanelHolidayMapData item in list)
			{
				this.List.Add(new ACPanelHolidayMapView(item));
			}
			this._block.Size = list.Block.Size;
			this._block.Index = list.Block.Index;
			this._block.Count = list.Block.Count;
			this._block.Records = list.Block.Records;
		}

		public CollectionBlock Block
		{
			get{ return this._block; }
		}

		public ACPanelHolidayMapDataCollection ToACPanelHolidayMapDataCollection()
		{
			ACPanelHolidayMapDataCollection retList = new ACPanelHolidayMapDataCollection();
			foreach (ACPanelHolidayMapView item in base.List)
			{
				retList.Add(item.ToACPanelHolidayMapData());
			}

			retList.AcceptChanges();
			return retList;
		}

		public void Add(ACPanelHolidayMapView entity)
		{
			this.List.Add(entity);
		}

		public void Insert(int index, ACPanelHolidayMapView entity)
		{
			this.List.Insert(index, entity);
		}

		public void Remove(ACPanelHolidayMapView entity)
		{
			this.List.Remove(entity);
		}

		public void AddRange(ACPanelHolidayMapViewCollection list)
		{
			foreach (ACPanelHolidayMapView item in list)
			{
				this.List.Add(item);
			}
		}

		public ACPanelHolidayMapView this[int index]
		{
			get{ return (ACPanelHolidayMapView)base.List[index]; }
			set{ base.List[index] = value; }
		}

		public ACPanelHolidayMapViewCollection SubCollection()
		{
			ACPanelHolidayMapViewCollection retList = new ACPanelHolidayMapViewCollection();
			if (this.Count <= this.Block.Size)
			{
				retList.AddRange(this);

				retList.Block.Size = this.Block.Size;
				retList.Block.Count = 1;
				retList.Block.Index = 0;
				retList.Block.Records = this.Count;
				return retList;
			}

			int start = this.Block.Index * this.Block.Size;
			int count = this.Block.Size;
			for (int i = start; i < (start + count); i++)
			{
				if (i >= this.Count)
					break;

				retList.Add(this[i]);
			}

			retList.Block.Size = this.Block.Size;
			retList.Block.Index = this.Block.Index;
			retList.Block.Count = (this.Count / this.Block.Size) + (this.Count % this.Block.Size == 0 ? 0 : 1);
			retList.Block.Records = this.Count;

			return retList;
		}
	}
	[Serializable]
	public class ACTimecodeViewCollection : CollectionBase
	{
		private CollectionBlock _block = new CollectionBlock();
		public ACTimecodeViewCollection()
		{
		}

		public ACTimecodeViewCollection(ACTimecodeDataCollection list)
		{
			foreach (ACTimecodeData item in list)
			{
				this.List.Add(new ACTimecodeView(item));
			}
			this._block.Size = list.Block.Size;
			this._block.Index = list.Block.Index;
			this._block.Count = list.Block.Count;
			this._block.Records = list.Block.Records;
		}

		public CollectionBlock Block
		{
			get{ return this._block; }
		}

		public ACTimecodeDataCollection ToACTimecodeDataCollection()
		{
			ACTimecodeDataCollection retList = new ACTimecodeDataCollection();
			foreach (ACTimecodeView item in base.List)
			{
				retList.Add(item.ToACTimecodeData());
			}

			retList.AcceptChanges();
			return retList;
		}

		public void Add(ACTimecodeView entity)
		{
			this.List.Add(entity);
		}

		public void Insert(int index, ACTimecodeView entity)
		{
			this.List.Insert(index, entity);
		}

		public void Remove(ACTimecodeView entity)
		{
			this.List.Remove(entity);
		}

		public void AddRange(ACTimecodeViewCollection list)
		{
			foreach (ACTimecodeView item in list)
			{
				this.List.Add(item);
			}
		}

		public ACTimecodeView this[int index]
		{
			get{ return (ACTimecodeView)base.List[index]; }
			set{ base.List[index] = value; }
		}

		public ACTimecodeViewCollection SubCollection()
		{
			ACTimecodeViewCollection retList = new ACTimecodeViewCollection();
			if (this.Count <= this.Block.Size)
			{
				retList.AddRange(this);

				retList.Block.Size = this.Block.Size;
				retList.Block.Count = 1;
				retList.Block.Index = 0;
				retList.Block.Records = this.Count;
				return retList;
			}

			int start = this.Block.Index * this.Block.Size;
			int count = this.Block.Size;
			for (int i = start; i < (start + count); i++)
			{
				if (i >= this.Count)
					break;

				retList.Add(this[i]);
			}

			retList.Block.Size = this.Block.Size;
			retList.Block.Index = this.Block.Index;
			retList.Block.Count = (this.Count / this.Block.Size) + (this.Count % this.Block.Size == 0 ? 0 : 1);
			retList.Block.Records = this.Count;

			return retList;
		}
	}
	[Serializable]
	public class ACTimecodeIntervalMapViewCollection : CollectionBase
	{
		private CollectionBlock _block = new CollectionBlock();
		public ACTimecodeIntervalMapViewCollection()
		{
		}

		public ACTimecodeIntervalMapViewCollection(ACTimecodeIntervalMapDataCollection list)
		{
			foreach (ACTimecodeIntervalMapData item in list)
			{
				this.List.Add(new ACTimecodeIntervalMapView(item));
			}
			this._block.Size = list.Block.Size;
			this._block.Index = list.Block.Index;
			this._block.Count = list.Block.Count;
			this._block.Records = list.Block.Records;
		}

		public CollectionBlock Block
		{
			get{ return this._block; }
		}

		public ACTimecodeIntervalMapDataCollection ToACTimecodeIntervalMapDataCollection()
		{
			ACTimecodeIntervalMapDataCollection retList = new ACTimecodeIntervalMapDataCollection();
			foreach (ACTimecodeIntervalMapView item in base.List)
			{
				retList.Add(item.ToACTimecodeIntervalMapData());
			}

			retList.AcceptChanges();
			return retList;
		}

		public void Add(ACTimecodeIntervalMapView entity)
		{
			this.List.Add(entity);
		}

		public void Insert(int index, ACTimecodeIntervalMapView entity)
		{
			this.List.Insert(index, entity);
		}

		public void Remove(ACTimecodeIntervalMapView entity)
		{
			this.List.Remove(entity);
		}

		public void AddRange(ACTimecodeIntervalMapViewCollection list)
		{
			foreach (ACTimecodeIntervalMapView item in list)
			{
				this.List.Add(item);
			}
		}

		public ACTimecodeIntervalMapView this[int index]
		{
			get{ return (ACTimecodeIntervalMapView)base.List[index]; }
			set{ base.List[index] = value; }
		}

		public ACTimecodeIntervalMapViewCollection SubCollection()
		{
			ACTimecodeIntervalMapViewCollection retList = new ACTimecodeIntervalMapViewCollection();
			if (this.Count <= this.Block.Size)
			{
				retList.AddRange(this);

				retList.Block.Size = this.Block.Size;
				retList.Block.Count = 1;
				retList.Block.Index = 0;
				retList.Block.Records = this.Count;
				return retList;
			}

			int start = this.Block.Index * this.Block.Size;
			int count = this.Block.Size;
			for (int i = start; i < (start + count); i++)
			{
				if (i >= this.Count)
					break;

				retList.Add(this[i]);
			}

			retList.Block.Size = this.Block.Size;
			retList.Block.Index = this.Block.Index;
			retList.Block.Count = (this.Count / this.Block.Size) + (this.Count % this.Block.Size == 0 ? 0 : 1);
			retList.Block.Records = this.Count;

			return retList;
		}
	}
	[Serializable]
	public class ACAMFormatViewCollection : CollectionBase
	{
		private CollectionBlock _block = new CollectionBlock();
		public ACAMFormatViewCollection()
		{
		}

		public ACAMFormatViewCollection(ACAMFormatDataCollection list)
		{
			foreach (ACAMFormatData item in list)
			{
				this.List.Add(new ACAMFormatView(item));
			}
			this._block.Size = list.Block.Size;
			this._block.Index = list.Block.Index;
			this._block.Count = list.Block.Count;
			this._block.Records = list.Block.Records;
		}

		public CollectionBlock Block
		{
			get{ return this._block; }
		}

		public ACAMFormatDataCollection ToACAMFormatDataCollection()
		{
			ACAMFormatDataCollection retList = new ACAMFormatDataCollection();
			foreach (ACAMFormatView item in base.List)
			{
				retList.Add(item.ToACAMFormatData());
			}

			retList.AcceptChanges();
			return retList;
		}

		public void Add(ACAMFormatView entity)
		{
			this.List.Add(entity);
		}

		public void Insert(int index, ACAMFormatView entity)
		{
			this.List.Insert(index, entity);
		}

		public void Remove(ACAMFormatView entity)
		{
			this.List.Remove(entity);
		}

		public void AddRange(ACAMFormatViewCollection list)
		{
			foreach (ACAMFormatView item in list)
			{
				this.List.Add(item);
			}
		}

		public ACAMFormatView this[int index]
		{
			get{ return (ACAMFormatView)base.List[index]; }
			set{ base.List[index] = value; }
		}

		public ACAMFormatViewCollection SubCollection()
		{
			ACAMFormatViewCollection retList = new ACAMFormatViewCollection();
			if (this.Count <= this.Block.Size)
			{
				retList.AddRange(this);

				retList.Block.Size = this.Block.Size;
				retList.Block.Count = 1;
				retList.Block.Index = 0;
				retList.Block.Records = this.Count;
				return retList;
			}

			int start = this.Block.Index * this.Block.Size;
			int count = this.Block.Size;
			for (int i = start; i < (start + count); i++)
			{
				if (i >= this.Count)
					break;

				retList.Add(this[i]);
			}

			retList.Block.Size = this.Block.Size;
			retList.Block.Index = this.Block.Index;
			retList.Block.Count = (this.Count / this.Block.Size) + (this.Count % this.Block.Size == 0 ? 0 : 1);
			retList.Block.Records = this.Count;

			return retList;
		}
	}
	[Serializable]
	public class BDBuildingHolidayMapViewCollection : CollectionBase
	{
		private CollectionBlock _block = new CollectionBlock();
		public BDBuildingHolidayMapViewCollection()
		{
		}

		public BDBuildingHolidayMapViewCollection(BDBuildingHolidayMapDataCollection list)
		{
			foreach (BDBuildingHolidayMapData item in list)
			{
				this.List.Add(new BDBuildingHolidayMapView(item));
			}
			this._block.Size = list.Block.Size;
			this._block.Index = list.Block.Index;
			this._block.Count = list.Block.Count;
			this._block.Records = list.Block.Records;
		}

		public CollectionBlock Block
		{
			get{ return this._block; }
		}

		public BDBuildingHolidayMapDataCollection ToBDBuildingHolidayMapDataCollection()
		{
			BDBuildingHolidayMapDataCollection retList = new BDBuildingHolidayMapDataCollection();
			foreach (BDBuildingHolidayMapView item in base.List)
			{
				retList.Add(item.ToBDBuildingHolidayMapData());
			}

			retList.AcceptChanges();
			return retList;
		}

		public void Add(BDBuildingHolidayMapView entity)
		{
			this.List.Add(entity);
		}

		public void Insert(int index, BDBuildingHolidayMapView entity)
		{
			this.List.Insert(index, entity);
		}

		public void Remove(BDBuildingHolidayMapView entity)
		{
			this.List.Remove(entity);
		}

		public void AddRange(BDBuildingHolidayMapViewCollection list)
		{
			foreach (BDBuildingHolidayMapView item in list)
			{
				this.List.Add(item);
			}
		}

		public BDBuildingHolidayMapView this[int index]
		{
			get{ return (BDBuildingHolidayMapView)base.List[index]; }
			set{ base.List[index] = value; }
		}

		public BDBuildingHolidayMapViewCollection SubCollection()
		{
			BDBuildingHolidayMapViewCollection retList = new BDBuildingHolidayMapViewCollection();
			if (this.Count <= this.Block.Size)
			{
				retList.AddRange(this);

				retList.Block.Size = this.Block.Size;
				retList.Block.Count = 1;
				retList.Block.Index = 0;
				retList.Block.Records = this.Count;
				return retList;
			}

			int start = this.Block.Index * this.Block.Size;
			int count = this.Block.Size;
			for (int i = start; i < (start + count); i++)
			{
				if (i >= this.Count)
					break;

				retList.Add(this[i]);
			}

			retList.Block.Size = this.Block.Size;
			retList.Block.Index = this.Block.Index;
			retList.Block.Count = (this.Count / this.Block.Size) + (this.Count % this.Block.Size == 0 ? 0 : 1);
			retList.Block.Records = this.Count;

			return retList;
		}
	}
	[Serializable]
	public class ACOutputGroupViewCollection : CollectionBase
	{
		private CollectionBlock _block = new CollectionBlock();
		public ACOutputGroupViewCollection()
		{
		}

		public ACOutputGroupViewCollection(ACOutputGroupDataCollection list)
		{
			foreach (ACOutputGroupData item in list)
			{
				this.List.Add(new ACOutputGroupView(item));
			}
			this._block.Size = list.Block.Size;
			this._block.Index = list.Block.Index;
			this._block.Count = list.Block.Count;
			this._block.Records = list.Block.Records;
		}

		public CollectionBlock Block
		{
			get{ return this._block; }
		}

		public ACOutputGroupDataCollection ToACOutputGroupDataCollection()
		{
			ACOutputGroupDataCollection retList = new ACOutputGroupDataCollection();
			foreach (ACOutputGroupView item in base.List)
			{
				retList.Add(item.ToACOutputGroupData());
			}

			retList.AcceptChanges();
			return retList;
		}

		public void Add(ACOutputGroupView entity)
		{
			this.List.Add(entity);
		}

		public void Insert(int index, ACOutputGroupView entity)
		{
			this.List.Insert(index, entity);
		}

		public void Remove(ACOutputGroupView entity)
		{
			this.List.Remove(entity);
		}

		public void AddRange(ACOutputGroupViewCollection list)
		{
			foreach (ACOutputGroupView item in list)
			{
				this.List.Add(item);
			}
		}

		public ACOutputGroupView this[int index]
		{
			get{ return (ACOutputGroupView)base.List[index]; }
			set{ base.List[index] = value; }
		}

		public ACOutputGroupViewCollection SubCollection()
		{
			ACOutputGroupViewCollection retList = new ACOutputGroupViewCollection();
			if (this.Count <= this.Block.Size)
			{
				retList.AddRange(this);

				retList.Block.Size = this.Block.Size;
				retList.Block.Count = 1;
				retList.Block.Index = 0;
				retList.Block.Records = this.Count;
				return retList;
			}

			int start = this.Block.Index * this.Block.Size;
			int count = this.Block.Size;
			for (int i = start; i < (start + count); i++)
			{
				if (i >= this.Count)
					break;

				retList.Add(this[i]);
			}

			retList.Block.Size = this.Block.Size;
			retList.Block.Index = this.Block.Index;
			retList.Block.Count = (this.Count / this.Block.Size) + (this.Count % this.Block.Size == 0 ? 0 : 1);
			retList.Block.Records = this.Count;

			return retList;
		}
	}
	[Serializable]
	public class BDTenantHolidayMapViewCollection : CollectionBase
	{
		private CollectionBlock _block = new CollectionBlock();
		public BDTenantHolidayMapViewCollection()
		{
		}

		public BDTenantHolidayMapViewCollection(BDTenantHolidayMapDataCollection list)
		{
			foreach (BDTenantHolidayMapData item in list)
			{
				this.List.Add(new BDTenantHolidayMapView(item));
			}
			this._block.Size = list.Block.Size;
			this._block.Index = list.Block.Index;
			this._block.Count = list.Block.Count;
			this._block.Records = list.Block.Records;
		}

		public CollectionBlock Block
		{
			get{ return this._block; }
		}

		public BDTenantHolidayMapDataCollection ToBDTenantHolidayMapDataCollection()
		{
			BDTenantHolidayMapDataCollection retList = new BDTenantHolidayMapDataCollection();
			foreach (BDTenantHolidayMapView item in base.List)
			{
				retList.Add(item.ToBDTenantHolidayMapData());
			}

			retList.AcceptChanges();
			return retList;
		}

		public void Add(BDTenantHolidayMapView entity)
		{
			this.List.Add(entity);
		}

		public void Insert(int index, BDTenantHolidayMapView entity)
		{
			this.List.Insert(index, entity);
		}

		public void Remove(BDTenantHolidayMapView entity)
		{
			this.List.Remove(entity);
		}

		public void AddRange(BDTenantHolidayMapViewCollection list)
		{
			foreach (BDTenantHolidayMapView item in list)
			{
				this.List.Add(item);
			}
		}

		public BDTenantHolidayMapView this[int index]
		{
			get{ return (BDTenantHolidayMapView)base.List[index]; }
			set{ base.List[index] = value; }
		}

		public BDTenantHolidayMapViewCollection SubCollection()
		{
			BDTenantHolidayMapViewCollection retList = new BDTenantHolidayMapViewCollection();
			if (this.Count <= this.Block.Size)
			{
				retList.AddRange(this);

				retList.Block.Size = this.Block.Size;
				retList.Block.Count = 1;
				retList.Block.Index = 0;
				retList.Block.Records = this.Count;
				return retList;
			}

			int start = this.Block.Index * this.Block.Size;
			int count = this.Block.Size;
			for (int i = start; i < (start + count); i++)
			{
				if (i >= this.Count)
					break;

				retList.Add(this[i]);
			}

			retList.Block.Size = this.Block.Size;
			retList.Block.Index = this.Block.Index;
			retList.Block.Count = (this.Count / this.Block.Size) + (this.Count % this.Block.Size == 0 ? 0 : 1);
			retList.Block.Records = this.Count;

			return retList;
		}
	}
	[Serializable]
	public class LogRowsCountViewCollection : CollectionBase
	{
		private CollectionBlock _block = new CollectionBlock();
		public LogRowsCountViewCollection()
		{
		}

		public LogRowsCountViewCollection(LogRowsCountDataCollection list)
		{
			foreach (LogRowsCountData item in list)
			{
				this.List.Add(new LogRowsCountView(item));
			}
			this._block.Size = list.Block.Size;
			this._block.Index = list.Block.Index;
			this._block.Count = list.Block.Count;
			this._block.Records = list.Block.Records;
		}

		public CollectionBlock Block
		{
			get{ return this._block; }
		}

		public LogRowsCountDataCollection ToLogRowsCountDataCollection()
		{
			LogRowsCountDataCollection retList = new LogRowsCountDataCollection();
			foreach (LogRowsCountView item in base.List)
			{
				retList.Add(item.ToLogRowsCountData());
			}

			retList.AcceptChanges();
			return retList;
		}

		public void Add(LogRowsCountView entity)
		{
			this.List.Add(entity);
		}

		public void Insert(int index, LogRowsCountView entity)
		{
			this.List.Insert(index, entity);
		}

		public void Remove(LogRowsCountView entity)
		{
			this.List.Remove(entity);
		}

		public void AddRange(LogRowsCountViewCollection list)
		{
			foreach (LogRowsCountView item in list)
			{
				this.List.Add(item);
			}
		}

		public LogRowsCountView this[int index]
		{
			get{ return (LogRowsCountView)base.List[index]; }
			set{ base.List[index] = value; }
		}

		public LogRowsCountViewCollection SubCollection()
		{
			LogRowsCountViewCollection retList = new LogRowsCountViewCollection();
			if (this.Count <= this.Block.Size)
			{
				retList.AddRange(this);

				retList.Block.Size = this.Block.Size;
				retList.Block.Count = 1;
				retList.Block.Index = 0;
				retList.Block.Records = this.Count;
				return retList;
			}

			int start = this.Block.Index * this.Block.Size;
			int count = this.Block.Size;
			for (int i = start; i < (start + count); i++)
			{
				if (i >= this.Count)
					break;

				retList.Add(this[i]);
			}

			retList.Block.Size = this.Block.Size;
			retList.Block.Index = this.Block.Index;
			retList.Block.Count = (this.Count / this.Block.Size) + (this.Count % this.Block.Size == 0 ? 0 : 1);
			retList.Block.Records = this.Count;

			return retList;
		}
	}
	[Serializable]
	public class ACInputGroupViewCollection : CollectionBase
	{
		private CollectionBlock _block = new CollectionBlock();
		public ACInputGroupViewCollection()
		{
		}

		public ACInputGroupViewCollection(ACInputGroupDataCollection list)
		{
			foreach (ACInputGroupData item in list)
			{
				this.List.Add(new ACInputGroupView(item));
			}
			this._block.Size = list.Block.Size;
			this._block.Index = list.Block.Index;
			this._block.Count = list.Block.Count;
			this._block.Records = list.Block.Records;
		}

		public CollectionBlock Block
		{
			get{ return this._block; }
		}

		public ACInputGroupDataCollection ToACInputGroupDataCollection()
		{
			ACInputGroupDataCollection retList = new ACInputGroupDataCollection();
			foreach (ACInputGroupView item in base.List)
			{
				retList.Add(item.ToACInputGroupData());
			}

			retList.AcceptChanges();
			return retList;
		}

		public void Add(ACInputGroupView entity)
		{
			this.List.Add(entity);
		}

		public void Insert(int index, ACInputGroupView entity)
		{
			this.List.Insert(index, entity);
		}

		public void Remove(ACInputGroupView entity)
		{
			this.List.Remove(entity);
		}

		public void AddRange(ACInputGroupViewCollection list)
		{
			foreach (ACInputGroupView item in list)
			{
				this.List.Add(item);
			}
		}

		public ACInputGroupView this[int index]
		{
			get{ return (ACInputGroupView)base.List[index]; }
			set{ base.List[index] = value; }
		}

		public ACInputGroupViewCollection SubCollection()
		{
			ACInputGroupViewCollection retList = new ACInputGroupViewCollection();
			if (this.Count <= this.Block.Size)
			{
				retList.AddRange(this);

				retList.Block.Size = this.Block.Size;
				retList.Block.Count = 1;
				retList.Block.Index = 0;
				retList.Block.Records = this.Count;
				return retList;
			}

			int start = this.Block.Index * this.Block.Size;
			int count = this.Block.Size;
			for (int i = start; i < (start + count); i++)
			{
				if (i >= this.Count)
					break;

				retList.Add(this[i]);
			}

			retList.Block.Size = this.Block.Size;
			retList.Block.Index = this.Block.Index;
			retList.Block.Count = (this.Count / this.Block.Size) + (this.Count % this.Block.Size == 0 ? 0 : 1);
			retList.Block.Records = this.Count;

			return retList;
		}
	}
	[Serializable]
	public class ACInputViewCollection : CollectionBase
	{
		private CollectionBlock _block = new CollectionBlock();
		public ACInputViewCollection()
		{
		}

		public ACInputViewCollection(ACInputDataCollection list)
		{
			foreach (ACInputData item in list)
			{
				this.List.Add(new ACInputView(item));
			}
			this._block.Size = list.Block.Size;
			this._block.Index = list.Block.Index;
			this._block.Count = list.Block.Count;
			this._block.Records = list.Block.Records;
		}

		public CollectionBlock Block
		{
			get{ return this._block; }
		}

		public ACInputDataCollection ToACInputDataCollection()
		{
			ACInputDataCollection retList = new ACInputDataCollection();
			foreach (ACInputView item in base.List)
			{
				retList.Add(item.ToACInputData());
			}

			retList.AcceptChanges();
			return retList;
		}

		public void Add(ACInputView entity)
		{
			this.List.Add(entity);
		}

		public void Insert(int index, ACInputView entity)
		{
			this.List.Insert(index, entity);
		}

		public void Remove(ACInputView entity)
		{
			this.List.Remove(entity);
		}

		public void AddRange(ACInputViewCollection list)
		{
			foreach (ACInputView item in list)
			{
				this.List.Add(item);
			}
		}

		public ACInputView this[int index]
		{
			get{ return (ACInputView)base.List[index]; }
			set{ base.List[index] = value; }
		}

		public ACInputViewCollection SubCollection()
		{
			ACInputViewCollection retList = new ACInputViewCollection();
			if (this.Count <= this.Block.Size)
			{
				retList.AddRange(this);

				retList.Block.Size = this.Block.Size;
				retList.Block.Count = 1;
				retList.Block.Index = 0;
				retList.Block.Records = this.Count;
				return retList;
			}

			int start = this.Block.Index * this.Block.Size;
			int count = this.Block.Size;
			for (int i = start; i < (start + count); i++)
			{
				if (i >= this.Count)
					break;

				retList.Add(this[i]);
			}

			retList.Block.Size = this.Block.Size;
			retList.Block.Index = this.Block.Index;
			retList.Block.Count = (this.Count / this.Block.Size) + (this.Count % this.Block.Size == 0 ? 0 : 1);
			retList.Block.Records = this.Count;

			return retList;
		}
	}
	[Serializable]
	public class ACFunctionCardViewCollection : CollectionBase
	{
		private CollectionBlock _block = new CollectionBlock();
		public ACFunctionCardViewCollection()
		{
		}

		public ACFunctionCardViewCollection(ACFunctionCardDataCollection list)
		{
			foreach (ACFunctionCardData item in list)
			{
				this.List.Add(new ACFunctionCardView(item));
			}
			this._block.Size = list.Block.Size;
			this._block.Index = list.Block.Index;
			this._block.Count = list.Block.Count;
			this._block.Records = list.Block.Records;
		}

		public CollectionBlock Block
		{
			get{ return this._block; }
		}

		public ACFunctionCardDataCollection ToACFunctionCardDataCollection()
		{
			ACFunctionCardDataCollection retList = new ACFunctionCardDataCollection();
			foreach (ACFunctionCardView item in base.List)
			{
				retList.Add(item.ToACFunctionCardData());
			}

			retList.AcceptChanges();
			return retList;
		}

		public void Add(ACFunctionCardView entity)
		{
			this.List.Add(entity);
		}

		public void Insert(int index, ACFunctionCardView entity)
		{
			this.List.Insert(index, entity);
		}

		public void Remove(ACFunctionCardView entity)
		{
			this.List.Remove(entity);
		}

		public void AddRange(ACFunctionCardViewCollection list)
		{
			foreach (ACFunctionCardView item in list)
			{
				this.List.Add(item);
			}
		}

		public ACFunctionCardView this[int index]
		{
			get{ return (ACFunctionCardView)base.List[index]; }
			set{ base.List[index] = value; }
		}

		public ACFunctionCardViewCollection SubCollection()
		{
			ACFunctionCardViewCollection retList = new ACFunctionCardViewCollection();
			if (this.Count <= this.Block.Size)
			{
				retList.AddRange(this);

				retList.Block.Size = this.Block.Size;
				retList.Block.Count = 1;
				retList.Block.Index = 0;
				retList.Block.Records = this.Count;
				return retList;
			}

			int start = this.Block.Index * this.Block.Size;
			int count = this.Block.Size;
			for (int i = start; i < (start + count); i++)
			{
				if (i >= this.Count)
					break;

				retList.Add(this[i]);
			}

			retList.Block.Size = this.Block.Size;
			retList.Block.Index = this.Block.Index;
			retList.Block.Count = (this.Count / this.Block.Size) + (this.Count % this.Block.Size == 0 ? 0 : 1);
			retList.Block.Records = this.Count;

			return retList;
		}
	}
	[Serializable]
	public class ACAccessLevelViewCollection : CollectionBase
	{
		private CollectionBlock _block = new CollectionBlock();
		public ACAccessLevelViewCollection()
		{
		}

		public ACAccessLevelViewCollection(ACAccessLevelDataCollection list)
		{
			foreach (ACAccessLevelData item in list)
			{
				this.List.Add(new ACAccessLevelView(item));
			}
			this._block.Size = list.Block.Size;
			this._block.Index = list.Block.Index;
			this._block.Count = list.Block.Count;
			this._block.Records = list.Block.Records;
		}

		public CollectionBlock Block
		{
			get{ return this._block; }
		}

		public ACAccessLevelDataCollection ToACAccessLevelDataCollection()
		{
			ACAccessLevelDataCollection retList = new ACAccessLevelDataCollection();
			foreach (ACAccessLevelView item in base.List)
			{
				retList.Add(item.ToACAccessLevelData());
			}

			retList.AcceptChanges();
			return retList;
		}

		public void Add(ACAccessLevelView entity)
		{
			this.List.Add(entity);
		}

		public void Insert(int index, ACAccessLevelView entity)
		{
			this.List.Insert(index, entity);
		}

		public void Remove(ACAccessLevelView entity)
		{
			this.List.Remove(entity);
		}

		public void AddRange(ACAccessLevelViewCollection list)
		{
			foreach (ACAccessLevelView item in list)
			{
				this.List.Add(item);
			}
		}

		public ACAccessLevelView this[int index]
		{
			get{ return (ACAccessLevelView)base.List[index]; }
			set{ base.List[index] = value; }
		}

		public ACAccessLevelViewCollection SubCollection()
		{
			ACAccessLevelViewCollection retList = new ACAccessLevelViewCollection();
			if (this.Count <= this.Block.Size)
			{
				retList.AddRange(this);

				retList.Block.Size = this.Block.Size;
				retList.Block.Count = 1;
				retList.Block.Index = 0;
				retList.Block.Records = this.Count;
				return retList;
			}

			int start = this.Block.Index * this.Block.Size;
			int count = this.Block.Size;
			for (int i = start; i < (start + count); i++)
			{
				if (i >= this.Count)
					break;

				retList.Add(this[i]);
			}

			retList.Block.Size = this.Block.Size;
			retList.Block.Index = this.Block.Index;
			retList.Block.Count = (this.Count / this.Block.Size) + (this.Count % this.Block.Size == 0 ? 0 : 1);
			retList.Block.Records = this.Count;

			return retList;
		}
	}
	[Serializable]
	public class ACPanelFunctionCardMapViewCollection : CollectionBase
	{
		private CollectionBlock _block = new CollectionBlock();
		public ACPanelFunctionCardMapViewCollection()
		{
		}

		public ACPanelFunctionCardMapViewCollection(ACPanelFunctionCardMapDataCollection list)
		{
			foreach (ACPanelFunctionCardMapData item in list)
			{
				this.List.Add(new ACPanelFunctionCardMapView(item));
			}
			this._block.Size = list.Block.Size;
			this._block.Index = list.Block.Index;
			this._block.Count = list.Block.Count;
			this._block.Records = list.Block.Records;
		}

		public CollectionBlock Block
		{
			get{ return this._block; }
		}

		public ACPanelFunctionCardMapDataCollection ToACPanelFunctionCardMapDataCollection()
		{
			ACPanelFunctionCardMapDataCollection retList = new ACPanelFunctionCardMapDataCollection();
			foreach (ACPanelFunctionCardMapView item in base.List)
			{
				retList.Add(item.ToACPanelFunctionCardMapData());
			}

			retList.AcceptChanges();
			return retList;
		}

		public void Add(ACPanelFunctionCardMapView entity)
		{
			this.List.Add(entity);
		}

		public void Insert(int index, ACPanelFunctionCardMapView entity)
		{
			this.List.Insert(index, entity);
		}

		public void Remove(ACPanelFunctionCardMapView entity)
		{
			this.List.Remove(entity);
		}

		public void AddRange(ACPanelFunctionCardMapViewCollection list)
		{
			foreach (ACPanelFunctionCardMapView item in list)
			{
				this.List.Add(item);
			}
		}

		public ACPanelFunctionCardMapView this[int index]
		{
			get{ return (ACPanelFunctionCardMapView)base.List[index]; }
			set{ base.List[index] = value; }
		}

		public ACPanelFunctionCardMapViewCollection SubCollection()
		{
			ACPanelFunctionCardMapViewCollection retList = new ACPanelFunctionCardMapViewCollection();
			if (this.Count <= this.Block.Size)
			{
				retList.AddRange(this);

				retList.Block.Size = this.Block.Size;
				retList.Block.Count = 1;
				retList.Block.Index = 0;
				retList.Block.Records = this.Count;
				return retList;
			}

			int start = this.Block.Index * this.Block.Size;
			int count = this.Block.Size;
			for (int i = start; i < (start + count); i++)
			{
				if (i >= this.Count)
					break;

				retList.Add(this[i]);
			}

			retList.Block.Size = this.Block.Size;
			retList.Block.Index = this.Block.Index;
			retList.Block.Count = (this.Count / this.Block.Size) + (this.Count % this.Block.Size == 0 ? 0 : 1);
			retList.Block.Records = this.Count;

			return retList;
		}
	}
	[Serializable]
	public class UtilHolidayViewCollection : CollectionBase
	{
		private CollectionBlock _block = new CollectionBlock();
		public UtilHolidayViewCollection()
		{
		}

		public UtilHolidayViewCollection(UtilHolidayDataCollection list)
		{
			foreach (UtilHolidayData item in list)
			{
				this.List.Add(new UtilHolidayView(item));
			}
			this._block.Size = list.Block.Size;
			this._block.Index = list.Block.Index;
			this._block.Count = list.Block.Count;
			this._block.Records = list.Block.Records;
		}

		public CollectionBlock Block
		{
			get{ return this._block; }
		}

		public UtilHolidayDataCollection ToUtilHolidayDataCollection()
		{
			UtilHolidayDataCollection retList = new UtilHolidayDataCollection();
			foreach (UtilHolidayView item in base.List)
			{
				retList.Add(item.ToUtilHolidayData());
			}

			retList.AcceptChanges();
			return retList;
		}

		public void Add(UtilHolidayView entity)
		{
			this.List.Add(entity);
		}

		public void Insert(int index, UtilHolidayView entity)
		{
			this.List.Insert(index, entity);
		}

		public void Remove(UtilHolidayView entity)
		{
			this.List.Remove(entity);
		}

		public void AddRange(UtilHolidayViewCollection list)
		{
			foreach (UtilHolidayView item in list)
			{
				this.List.Add(item);
			}
		}

		public UtilHolidayView this[int index]
		{
			get{ return (UtilHolidayView)base.List[index]; }
			set{ base.List[index] = value; }
		}

		public UtilHolidayViewCollection SubCollection()
		{
			UtilHolidayViewCollection retList = new UtilHolidayViewCollection();
			if (this.Count <= this.Block.Size)
			{
				retList.AddRange(this);

				retList.Block.Size = this.Block.Size;
				retList.Block.Count = 1;
				retList.Block.Index = 0;
				retList.Block.Records = this.Count;
				return retList;
			}

			int start = this.Block.Index * this.Block.Size;
			int count = this.Block.Size;
			for (int i = start; i < (start + count); i++)
			{
				if (i >= this.Count)
					break;

				retList.Add(this[i]);
			}

			retList.Block.Size = this.Block.Size;
			retList.Block.Index = this.Block.Index;
			retList.Block.Count = (this.Count / this.Block.Size) + (this.Count % this.Block.Size == 0 ? 0 : 1);
			retList.Block.Records = this.Count;

			return retList;
		}
	}
	[Serializable]
	public class LogDBDeleteActivityViewCollection : CollectionBase
	{
		private CollectionBlock _block = new CollectionBlock();
		public LogDBDeleteActivityViewCollection()
		{
		}

		public LogDBDeleteActivityViewCollection(LogDBDeleteActivityDataCollection list)
		{
			foreach (LogDBDeleteActivityData item in list)
			{
				this.List.Add(new LogDBDeleteActivityView(item));
			}
			this._block.Size = list.Block.Size;
			this._block.Index = list.Block.Index;
			this._block.Count = list.Block.Count;
			this._block.Records = list.Block.Records;
		}

		public CollectionBlock Block
		{
			get{ return this._block; }
		}

		public LogDBDeleteActivityDataCollection ToLogDBDeleteActivityDataCollection()
		{
			LogDBDeleteActivityDataCollection retList = new LogDBDeleteActivityDataCollection();
			foreach (LogDBDeleteActivityView item in base.List)
			{
				retList.Add(item.ToLogDBDeleteActivityData());
			}

			retList.AcceptChanges();
			return retList;
		}

		public void Add(LogDBDeleteActivityView entity)
		{
			this.List.Add(entity);
		}

		public void Insert(int index, LogDBDeleteActivityView entity)
		{
			this.List.Insert(index, entity);
		}

		public void Remove(LogDBDeleteActivityView entity)
		{
			this.List.Remove(entity);
		}

		public void AddRange(LogDBDeleteActivityViewCollection list)
		{
			foreach (LogDBDeleteActivityView item in list)
			{
				this.List.Add(item);
			}
		}

		public LogDBDeleteActivityView this[int index]
		{
			get{ return (LogDBDeleteActivityView)base.List[index]; }
			set{ base.List[index] = value; }
		}

		public LogDBDeleteActivityViewCollection SubCollection()
		{
			LogDBDeleteActivityViewCollection retList = new LogDBDeleteActivityViewCollection();
			if (this.Count <= this.Block.Size)
			{
				retList.AddRange(this);

				retList.Block.Size = this.Block.Size;
				retList.Block.Count = 1;
				retList.Block.Index = 0;
				retList.Block.Records = this.Count;
				return retList;
			}

			int start = this.Block.Index * this.Block.Size;
			int count = this.Block.Size;
			for (int i = start; i < (start + count); i++)
			{
				if (i >= this.Count)
					break;

				retList.Add(this[i]);
			}

			retList.Block.Size = this.Block.Size;
			retList.Block.Index = this.Block.Index;
			retList.Block.Count = (this.Count / this.Block.Size) + (this.Count % this.Block.Size == 0 ? 0 : 1);
			retList.Block.Records = this.Count;

			return retList;
		}
	}
	[Serializable]
	public class UsrAccountViewCollection : CollectionBase
	{
		private CollectionBlock _block = new CollectionBlock();
		public UsrAccountViewCollection()
		{
		}

		public UsrAccountViewCollection(UsrAccountDataCollection list)
		{
			foreach (UsrAccountData item in list)
			{
				this.List.Add(new UsrAccountView(item));
			}
			this._block.Size = list.Block.Size;
			this._block.Index = list.Block.Index;
			this._block.Count = list.Block.Count;
			this._block.Records = list.Block.Records;
		}

		public CollectionBlock Block
		{
			get{ return this._block; }
		}

		public UsrAccountDataCollection ToUsrAccountDataCollection()
		{
			UsrAccountDataCollection retList = new UsrAccountDataCollection();
			foreach (UsrAccountView item in base.List)
			{
				retList.Add(item.ToUsrAccountData());
			}

			retList.AcceptChanges();
			return retList;
		}

		public void Add(UsrAccountView entity)
		{
			this.List.Add(entity);
		}

		public void Insert(int index, UsrAccountView entity)
		{
			this.List.Insert(index, entity);
		}

		public void Remove(UsrAccountView entity)
		{
			this.List.Remove(entity);
		}

		public void AddRange(UsrAccountViewCollection list)
		{
			foreach (UsrAccountView item in list)
			{
				this.List.Add(item);
			}
		}

		public UsrAccountView this[int index]
		{
			get{ return (UsrAccountView)base.List[index]; }
			set{ base.List[index] = value; }
		}

		public UsrAccountViewCollection SubCollection()
		{
			UsrAccountViewCollection retList = new UsrAccountViewCollection();
			if (this.Count <= this.Block.Size)
			{
				retList.AddRange(this);

				retList.Block.Size = this.Block.Size;
				retList.Block.Count = 1;
				retList.Block.Index = 0;
				retList.Block.Records = this.Count;
				return retList;
			}

			int start = this.Block.Index * this.Block.Size;
			int count = this.Block.Size;
			for (int i = start; i < (start + count); i++)
			{
				if (i >= this.Count)
					break;

				retList.Add(this[i]);
			}

			retList.Block.Size = this.Block.Size;
			retList.Block.Index = this.Block.Index;
			retList.Block.Count = (this.Count / this.Block.Size) + (this.Count % this.Block.Size == 0 ? 0 : 1);
			retList.Block.Records = this.Count;

			return retList;
		}
	}
	[Serializable]
	public class LogDBEditActivityViewCollection : CollectionBase
	{
		private CollectionBlock _block = new CollectionBlock();
		public LogDBEditActivityViewCollection()
		{
		}

		public LogDBEditActivityViewCollection(LogDBEditActivityDataCollection list)
		{
			foreach (LogDBEditActivityData item in list)
			{
				this.List.Add(new LogDBEditActivityView(item));
			}
			this._block.Size = list.Block.Size;
			this._block.Index = list.Block.Index;
			this._block.Count = list.Block.Count;
			this._block.Records = list.Block.Records;
		}

		public CollectionBlock Block
		{
			get{ return this._block; }
		}

		public LogDBEditActivityDataCollection ToLogDBEditActivityDataCollection()
		{
			LogDBEditActivityDataCollection retList = new LogDBEditActivityDataCollection();
			foreach (LogDBEditActivityView item in base.List)
			{
				retList.Add(item.ToLogDBEditActivityData());
			}

			retList.AcceptChanges();
			return retList;
		}

		public void Add(LogDBEditActivityView entity)
		{
			this.List.Add(entity);
		}

		public void Insert(int index, LogDBEditActivityView entity)
		{
			this.List.Insert(index, entity);
		}

		public void Remove(LogDBEditActivityView entity)
		{
			this.List.Remove(entity);
		}

		public void AddRange(LogDBEditActivityViewCollection list)
		{
			foreach (LogDBEditActivityView item in list)
			{
				this.List.Add(item);
			}
		}

		public LogDBEditActivityView this[int index]
		{
			get{ return (LogDBEditActivityView)base.List[index]; }
			set{ base.List[index] = value; }
		}

		public LogDBEditActivityViewCollection SubCollection()
		{
			LogDBEditActivityViewCollection retList = new LogDBEditActivityViewCollection();
			if (this.Count <= this.Block.Size)
			{
				retList.AddRange(this);

				retList.Block.Size = this.Block.Size;
				retList.Block.Count = 1;
				retList.Block.Index = 0;
				retList.Block.Records = this.Count;
				return retList;
			}

			int start = this.Block.Index * this.Block.Size;
			int count = this.Block.Size;
			for (int i = start; i < (start + count); i++)
			{
				if (i >= this.Count)
					break;

				retList.Add(this[i]);
			}

			retList.Block.Size = this.Block.Size;
			retList.Block.Index = this.Block.Index;
			retList.Block.Count = (this.Count / this.Block.Size) + (this.Count % this.Block.Size == 0 ? 0 : 1);
			retList.Block.Records = this.Count;

			return retList;
		}
	}
	[Serializable]
	public class ACMasterCardViewCollection : CollectionBase
	{
		private CollectionBlock _block = new CollectionBlock();
		public ACMasterCardViewCollection()
		{
		}

		public ACMasterCardViewCollection(ACMasterCardDataCollection list)
		{
			foreach (ACMasterCardData item in list)
			{
				this.List.Add(new ACMasterCardView(item));
			}
			this._block.Size = list.Block.Size;
			this._block.Index = list.Block.Index;
			this._block.Count = list.Block.Count;
			this._block.Records = list.Block.Records;
		}

		public CollectionBlock Block
		{
			get{ return this._block; }
		}

		public ACMasterCardDataCollection ToACMasterCardDataCollection()
		{
			ACMasterCardDataCollection retList = new ACMasterCardDataCollection();
			foreach (ACMasterCardView item in base.List)
			{
				retList.Add(item.ToACMasterCardData());
			}

			retList.AcceptChanges();
			return retList;
		}

		public void Add(ACMasterCardView entity)
		{
			this.List.Add(entity);
		}

		public void Insert(int index, ACMasterCardView entity)
		{
			this.List.Insert(index, entity);
		}

		public void Remove(ACMasterCardView entity)
		{
			this.List.Remove(entity);
		}

		public void AddRange(ACMasterCardViewCollection list)
		{
			foreach (ACMasterCardView item in list)
			{
				this.List.Add(item);
			}
		}

		public ACMasterCardView this[int index]
		{
			get{ return (ACMasterCardView)base.List[index]; }
			set{ base.List[index] = value; }
		}

		public ACMasterCardViewCollection SubCollection()
		{
			ACMasterCardViewCollection retList = new ACMasterCardViewCollection();
			if (this.Count <= this.Block.Size)
			{
				retList.AddRange(this);

				retList.Block.Size = this.Block.Size;
				retList.Block.Count = 1;
				retList.Block.Index = 0;
				retList.Block.Records = this.Count;
				return retList;
			}

			int start = this.Block.Index * this.Block.Size;
			int count = this.Block.Size;
			for (int i = start; i < (start + count); i++)
			{
				if (i >= this.Count)
					break;

				retList.Add(this[i]);
			}

			retList.Block.Size = this.Block.Size;
			retList.Block.Index = this.Block.Index;
			retList.Block.Count = (this.Count / this.Block.Size) + (this.Count % this.Block.Size == 0 ? 0 : 1);
			retList.Block.Records = this.Count;

			return retList;
		}
	}
	[Serializable]
	public class ACSupervisoryViewCollection : CollectionBase
	{
		private CollectionBlock _block = new CollectionBlock();
		public ACSupervisoryViewCollection()
		{
		}

		public ACSupervisoryViewCollection(ACSupervisoryDataCollection list)
		{
			foreach (ACSupervisoryData item in list)
			{
				this.List.Add(new ACSupervisoryView(item));
			}
			this._block.Size = list.Block.Size;
			this._block.Index = list.Block.Index;
			this._block.Count = list.Block.Count;
			this._block.Records = list.Block.Records;
		}

		public CollectionBlock Block
		{
			get{ return this._block; }
		}

		public ACSupervisoryDataCollection ToACSupervisoryDataCollection()
		{
			ACSupervisoryDataCollection retList = new ACSupervisoryDataCollection();
			foreach (ACSupervisoryView item in base.List)
			{
				retList.Add(item.ToACSupervisoryData());
			}

			retList.AcceptChanges();
			return retList;
		}

		public void Add(ACSupervisoryView entity)
		{
			this.List.Add(entity);
		}

		public void Insert(int index, ACSupervisoryView entity)
		{
			this.List.Insert(index, entity);
		}

		public void Remove(ACSupervisoryView entity)
		{
			this.List.Remove(entity);
		}

		public void AddRange(ACSupervisoryViewCollection list)
		{
			foreach (ACSupervisoryView item in list)
			{
				this.List.Add(item);
			}
		}

		public ACSupervisoryView this[int index]
		{
			get{ return (ACSupervisoryView)base.List[index]; }
			set{ base.List[index] = value; }
		}

		public ACSupervisoryViewCollection SubCollection()
		{
			ACSupervisoryViewCollection retList = new ACSupervisoryViewCollection();
			if (this.Count <= this.Block.Size)
			{
				retList.AddRange(this);

				retList.Block.Size = this.Block.Size;
				retList.Block.Count = 1;
				retList.Block.Index = 0;
				retList.Block.Records = this.Count;
				return retList;
			}

			int start = this.Block.Index * this.Block.Size;
			int count = this.Block.Size;
			for (int i = start; i < (start + count); i++)
			{
				if (i >= this.Count)
					break;

				retList.Add(this[i]);
			}

			retList.Block.Size = this.Block.Size;
			retList.Block.Index = this.Block.Index;
			retList.Block.Count = (this.Count / this.Block.Size) + (this.Count % this.Block.Size == 0 ? 0 : 1);
			retList.Block.Records = this.Count;

			return retList;
		}
	}
	[Serializable]
	public class UsrGroupViewCollection : CollectionBase
	{
		private CollectionBlock _block = new CollectionBlock();
		public UsrGroupViewCollection()
		{
		}

		public UsrGroupViewCollection(UsrGroupDataCollection list)
		{
			foreach (UsrGroupData item in list)
			{
				this.List.Add(new UsrGroupView(item));
			}
			this._block.Size = list.Block.Size;
			this._block.Index = list.Block.Index;
			this._block.Count = list.Block.Count;
			this._block.Records = list.Block.Records;
		}

		public CollectionBlock Block
		{
			get{ return this._block; }
		}

		public UsrGroupDataCollection ToUsrGroupDataCollection()
		{
			UsrGroupDataCollection retList = new UsrGroupDataCollection();
			foreach (UsrGroupView item in base.List)
			{
				retList.Add(item.ToUsrGroupData());
			}

			retList.AcceptChanges();
			return retList;
		}

		public void Add(UsrGroupView entity)
		{
			this.List.Add(entity);
		}

		public void Insert(int index, UsrGroupView entity)
		{
			this.List.Insert(index, entity);
		}

		public void Remove(UsrGroupView entity)
		{
			this.List.Remove(entity);
		}

		public void AddRange(UsrGroupViewCollection list)
		{
			foreach (UsrGroupView item in list)
			{
				this.List.Add(item);
			}
		}

		public UsrGroupView this[int index]
		{
			get{ return (UsrGroupView)base.List[index]; }
			set{ base.List[index] = value; }
		}

		public UsrGroupViewCollection SubCollection()
		{
			UsrGroupViewCollection retList = new UsrGroupViewCollection();
			if (this.Count <= this.Block.Size)
			{
				retList.AddRange(this);

				retList.Block.Size = this.Block.Size;
				retList.Block.Count = 1;
				retList.Block.Index = 0;
				retList.Block.Records = this.Count;
				return retList;
			}

			int start = this.Block.Index * this.Block.Size;
			int count = this.Block.Size;
			for (int i = start; i < (start + count); i++)
			{
				if (i >= this.Count)
					break;

				retList.Add(this[i]);
			}

			retList.Block.Size = this.Block.Size;
			retList.Block.Index = this.Block.Index;
			retList.Block.Count = (this.Count / this.Block.Size) + (this.Count % this.Block.Size == 0 ? 0 : 1);
			retList.Block.Records = this.Count;

			return retList;
		}
	}
	[Serializable]
	public class ACCardHolderBuildingMapViewCollection : CollectionBase
	{
		private CollectionBlock _block = new CollectionBlock();
		public ACCardHolderBuildingMapViewCollection()
		{
		}

		public ACCardHolderBuildingMapViewCollection(ACCardHolderBuildingMapDataCollection list)
		{
			foreach (ACCardHolderBuildingMapData item in list)
			{
				this.List.Add(new ACCardHolderBuildingMapView(item));
			}
			this._block.Size = list.Block.Size;
			this._block.Index = list.Block.Index;
			this._block.Count = list.Block.Count;
			this._block.Records = list.Block.Records;
		}

		public CollectionBlock Block
		{
			get{ return this._block; }
		}

		public ACCardHolderBuildingMapDataCollection ToACCardHolderBuildingMapDataCollection()
		{
			ACCardHolderBuildingMapDataCollection retList = new ACCardHolderBuildingMapDataCollection();
			foreach (ACCardHolderBuildingMapView item in base.List)
			{
				retList.Add(item.ToACCardHolderBuildingMapData());
			}

			retList.AcceptChanges();
			return retList;
		}

		public void Add(ACCardHolderBuildingMapView entity)
		{
			this.List.Add(entity);
		}

		public void Insert(int index, ACCardHolderBuildingMapView entity)
		{
			this.List.Insert(index, entity);
		}

		public void Remove(ACCardHolderBuildingMapView entity)
		{
			this.List.Remove(entity);
		}

		public void AddRange(ACCardHolderBuildingMapViewCollection list)
		{
			foreach (ACCardHolderBuildingMapView item in list)
			{
				this.List.Add(item);
			}
		}

		public ACCardHolderBuildingMapView this[int index]
		{
			get{ return (ACCardHolderBuildingMapView)base.List[index]; }
			set{ base.List[index] = value; }
		}

		public ACCardHolderBuildingMapViewCollection SubCollection()
		{
			ACCardHolderBuildingMapViewCollection retList = new ACCardHolderBuildingMapViewCollection();
			if (this.Count <= this.Block.Size)
			{
				retList.AddRange(this);

				retList.Block.Size = this.Block.Size;
				retList.Block.Count = 1;
				retList.Block.Index = 0;
				retList.Block.Records = this.Count;
				return retList;
			}

			int start = this.Block.Index * this.Block.Size;
			int count = this.Block.Size;
			for (int i = start; i < (start + count); i++)
			{
				if (i >= this.Count)
					break;

				retList.Add(this[i]);
			}

			retList.Block.Size = this.Block.Size;
			retList.Block.Index = this.Block.Index;
			retList.Block.Count = (this.Count / this.Block.Size) + (this.Count % this.Block.Size == 0 ? 0 : 1);
			retList.Block.Records = this.Count;

			return retList;
		}
	}
	[Serializable]
	public class BDVisitorViewCollection : CollectionBase
	{
		private CollectionBlock _block = new CollectionBlock();
		public BDVisitorViewCollection()
		{
		}

		public BDVisitorViewCollection(BDVisitorDataCollection list)
		{
			foreach (BDVisitorData item in list)
			{
				this.List.Add(new BDVisitorView(item));
			}
			this._block.Size = list.Block.Size;
			this._block.Index = list.Block.Index;
			this._block.Count = list.Block.Count;
			this._block.Records = list.Block.Records;
		}

		public CollectionBlock Block
		{
			get{ return this._block; }
		}

		public BDVisitorDataCollection ToBDVisitorDataCollection()
		{
			BDVisitorDataCollection retList = new BDVisitorDataCollection();
			foreach (BDVisitorView item in base.List)
			{
				retList.Add(item.ToBDVisitorData());
			}

			retList.AcceptChanges();
			return retList;
		}

		public void Add(BDVisitorView entity)
		{
			this.List.Add(entity);
		}

		public void Insert(int index, BDVisitorView entity)
		{
			this.List.Insert(index, entity);
		}

		public void Remove(BDVisitorView entity)
		{
			this.List.Remove(entity);
		}

		public void AddRange(BDVisitorViewCollection list)
		{
			foreach (BDVisitorView item in list)
			{
				this.List.Add(item);
			}
		}

		public BDVisitorView this[int index]
		{
			get{ return (BDVisitorView)base.List[index]; }
			set{ base.List[index] = value; }
		}

		public BDVisitorViewCollection SubCollection()
		{
			BDVisitorViewCollection retList = new BDVisitorViewCollection();
			if (this.Count <= this.Block.Size)
			{
				retList.AddRange(this);

				retList.Block.Size = this.Block.Size;
				retList.Block.Count = 1;
				retList.Block.Index = 0;
				retList.Block.Records = this.Count;
				return retList;
			}

			int start = this.Block.Index * this.Block.Size;
			int count = this.Block.Size;
			for (int i = start; i < (start + count); i++)
			{
				if (i >= this.Count)
					break;

				retList.Add(this[i]);
			}

			retList.Block.Size = this.Block.Size;
			retList.Block.Index = this.Block.Index;
			retList.Block.Count = (this.Count / this.Block.Size) + (this.Count % this.Block.Size == 0 ? 0 : 1);
			retList.Block.Records = this.Count;

			return retList;
		}
	}
	[Serializable]
	public class UsrGroupDBRuleViewCollection : CollectionBase
	{
		private CollectionBlock _block = new CollectionBlock();
		public UsrGroupDBRuleViewCollection()
		{
		}

		public UsrGroupDBRuleViewCollection(UsrGroupDBRuleDataCollection list)
		{
			foreach (UsrGroupDBRuleData item in list)
			{
				this.List.Add(new UsrGroupDBRuleView(item));
			}
			this._block.Size = list.Block.Size;
			this._block.Index = list.Block.Index;
			this._block.Count = list.Block.Count;
			this._block.Records = list.Block.Records;
		}

		public CollectionBlock Block
		{
			get{ return this._block; }
		}

		public UsrGroupDBRuleDataCollection ToUsrGroupDBRuleDataCollection()
		{
			UsrGroupDBRuleDataCollection retList = new UsrGroupDBRuleDataCollection();
			foreach (UsrGroupDBRuleView item in base.List)
			{
				retList.Add(item.ToUsrGroupDBRuleData());
			}

			retList.AcceptChanges();
			return retList;
		}

		public void Add(UsrGroupDBRuleView entity)
		{
			this.List.Add(entity);
		}

		public void Insert(int index, UsrGroupDBRuleView entity)
		{
			this.List.Insert(index, entity);
		}

		public void Remove(UsrGroupDBRuleView entity)
		{
			this.List.Remove(entity);
		}

		public void AddRange(UsrGroupDBRuleViewCollection list)
		{
			foreach (UsrGroupDBRuleView item in list)
			{
				this.List.Add(item);
			}
		}

		public UsrGroupDBRuleView this[int index]
		{
			get{ return (UsrGroupDBRuleView)base.List[index]; }
			set{ base.List[index] = value; }
		}

		public UsrGroupDBRuleViewCollection SubCollection()
		{
			UsrGroupDBRuleViewCollection retList = new UsrGroupDBRuleViewCollection();
			if (this.Count <= this.Block.Size)
			{
				retList.AddRange(this);

				retList.Block.Size = this.Block.Size;
				retList.Block.Count = 1;
				retList.Block.Index = 0;
				retList.Block.Records = this.Count;
				return retList;
			}

			int start = this.Block.Index * this.Block.Size;
			int count = this.Block.Size;
			for (int i = start; i < (start + count); i++)
			{
				if (i >= this.Count)
					break;

				retList.Add(this[i]);
			}

			retList.Block.Size = this.Block.Size;
			retList.Block.Index = this.Block.Index;
			retList.Block.Count = (this.Count / this.Block.Size) + (this.Count % this.Block.Size == 0 ? 0 : 1);
			retList.Block.Records = this.Count;

			return retList;
		}
	}
	[Serializable]
	public class ACPanelViewCollection : CollectionBase
	{
		private CollectionBlock _block = new CollectionBlock();
		public ACPanelViewCollection()
		{
		}

		public ACPanelViewCollection(ACPanelDataCollection list)
		{
			foreach (ACPanelData item in list)
			{
				this.List.Add(new ACPanelView(item));
			}
			this._block.Size = list.Block.Size;
			this._block.Index = list.Block.Index;
			this._block.Count = list.Block.Count;
			this._block.Records = list.Block.Records;
		}

		public CollectionBlock Block
		{
			get{ return this._block; }
		}

		public ACPanelDataCollection ToACPanelDataCollection()
		{
			ACPanelDataCollection retList = new ACPanelDataCollection();
			foreach (ACPanelView item in base.List)
			{
				retList.Add(item.ToACPanelData());
			}

			retList.AcceptChanges();
			return retList;
		}

		public void Add(ACPanelView entity)
		{
			this.List.Add(entity);
		}

		public void Insert(int index, ACPanelView entity)
		{
			this.List.Insert(index, entity);
		}

		public void Remove(ACPanelView entity)
		{
			this.List.Remove(entity);
		}

		public void AddRange(ACPanelViewCollection list)
		{
			foreach (ACPanelView item in list)
			{
				this.List.Add(item);
			}
		}

		public ACPanelView this[int index]
		{
			get{ return (ACPanelView)base.List[index]; }
			set{ base.List[index] = value; }
		}

		public ACPanelViewCollection SubCollection()
		{
			ACPanelViewCollection retList = new ACPanelViewCollection();
			if (this.Count <= this.Block.Size)
			{
				retList.AddRange(this);

				retList.Block.Size = this.Block.Size;
				retList.Block.Count = 1;
				retList.Block.Index = 0;
				retList.Block.Records = this.Count;
				return retList;
			}

			int start = this.Block.Index * this.Block.Size;
			int count = this.Block.Size;
			for (int i = start; i < (start + count); i++)
			{
				if (i >= this.Count)
					break;

				retList.Add(this[i]);
			}

			retList.Block.Size = this.Block.Size;
			retList.Block.Index = this.Block.Index;
			retList.Block.Count = (this.Count / this.Block.Size) + (this.Count % this.Block.Size == 0 ? 0 : 1);
			retList.Block.Records = this.Count;

			return retList;
		}
	}
	[Serializable]
	public class UsrAccountDBRuleViewCollection : CollectionBase
	{
		private CollectionBlock _block = new CollectionBlock();
		public UsrAccountDBRuleViewCollection()
		{
		}

		public UsrAccountDBRuleViewCollection(UsrAccountDBRuleDataCollection list)
		{
			foreach (UsrAccountDBRuleData item in list)
			{
				this.List.Add(new UsrAccountDBRuleView(item));
			}
			this._block.Size = list.Block.Size;
			this._block.Index = list.Block.Index;
			this._block.Count = list.Block.Count;
			this._block.Records = list.Block.Records;
		}

		public CollectionBlock Block
		{
			get{ return this._block; }
		}

		public UsrAccountDBRuleDataCollection ToUsrAccountDBRuleDataCollection()
		{
			UsrAccountDBRuleDataCollection retList = new UsrAccountDBRuleDataCollection();
			foreach (UsrAccountDBRuleView item in base.List)
			{
				retList.Add(item.ToUsrAccountDBRuleData());
			}

			retList.AcceptChanges();
			return retList;
		}

		public void Add(UsrAccountDBRuleView entity)
		{
			this.List.Add(entity);
		}

		public void Insert(int index, UsrAccountDBRuleView entity)
		{
			this.List.Insert(index, entity);
		}

		public void Remove(UsrAccountDBRuleView entity)
		{
			this.List.Remove(entity);
		}

		public void AddRange(UsrAccountDBRuleViewCollection list)
		{
			foreach (UsrAccountDBRuleView item in list)
			{
				this.List.Add(item);
			}
		}

		public UsrAccountDBRuleView this[int index]
		{
			get{ return (UsrAccountDBRuleView)base.List[index]; }
			set{ base.List[index] = value; }
		}

		public UsrAccountDBRuleViewCollection SubCollection()
		{
			UsrAccountDBRuleViewCollection retList = new UsrAccountDBRuleViewCollection();
			if (this.Count <= this.Block.Size)
			{
				retList.AddRange(this);

				retList.Block.Size = this.Block.Size;
				retList.Block.Count = 1;
				retList.Block.Index = 0;
				retList.Block.Records = this.Count;
				return retList;
			}

			int start = this.Block.Index * this.Block.Size;
			int count = this.Block.Size;
			for (int i = start; i < (start + count); i++)
			{
				if (i >= this.Count)
					break;

				retList.Add(this[i]);
			}

			retList.Block.Size = this.Block.Size;
			retList.Block.Index = this.Block.Index;
			retList.Block.Count = (this.Count / this.Block.Size) + (this.Count % this.Block.Size == 0 ? 0 : 1);
			retList.Block.Records = this.Count;

			return retList;
		}
	}
	[Serializable]
	public class UsrGroupBRRuleViewCollection : CollectionBase
	{
		private CollectionBlock _block = new CollectionBlock();
		public UsrGroupBRRuleViewCollection()
		{
		}

		public UsrGroupBRRuleViewCollection(UsrGroupBRRuleDataCollection list)
		{
			foreach (UsrGroupBRRuleData item in list)
			{
				this.List.Add(new UsrGroupBRRuleView(item));
			}
			this._block.Size = list.Block.Size;
			this._block.Index = list.Block.Index;
			this._block.Count = list.Block.Count;
			this._block.Records = list.Block.Records;
		}

		public CollectionBlock Block
		{
			get{ return this._block; }
		}

		public UsrGroupBRRuleDataCollection ToUsrGroupBRRuleDataCollection()
		{
			UsrGroupBRRuleDataCollection retList = new UsrGroupBRRuleDataCollection();
			foreach (UsrGroupBRRuleView item in base.List)
			{
				retList.Add(item.ToUsrGroupBRRuleData());
			}

			retList.AcceptChanges();
			return retList;
		}

		public void Add(UsrGroupBRRuleView entity)
		{
			this.List.Add(entity);
		}

		public void Insert(int index, UsrGroupBRRuleView entity)
		{
			this.List.Insert(index, entity);
		}

		public void Remove(UsrGroupBRRuleView entity)
		{
			this.List.Remove(entity);
		}

		public void AddRange(UsrGroupBRRuleViewCollection list)
		{
			foreach (UsrGroupBRRuleView item in list)
			{
				this.List.Add(item);
			}
		}

		public UsrGroupBRRuleView this[int index]
		{
			get{ return (UsrGroupBRRuleView)base.List[index]; }
			set{ base.List[index] = value; }
		}

		public UsrGroupBRRuleViewCollection SubCollection()
		{
			UsrGroupBRRuleViewCollection retList = new UsrGroupBRRuleViewCollection();
			if (this.Count <= this.Block.Size)
			{
				retList.AddRange(this);

				retList.Block.Size = this.Block.Size;
				retList.Block.Count = 1;
				retList.Block.Index = 0;
				retList.Block.Records = this.Count;
				return retList;
			}

			int start = this.Block.Index * this.Block.Size;
			int count = this.Block.Size;
			for (int i = start; i < (start + count); i++)
			{
				if (i >= this.Count)
					break;

				retList.Add(this[i]);
			}

			retList.Block.Size = this.Block.Size;
			retList.Block.Index = this.Block.Index;
			retList.Block.Count = (this.Count / this.Block.Size) + (this.Count % this.Block.Size == 0 ? 0 : 1);
			retList.Block.Records = this.Count;

			return retList;
		}
	}
	[Serializable]
	public class ACInputGroupInputMapViewCollection : CollectionBase
	{
		private CollectionBlock _block = new CollectionBlock();
		public ACInputGroupInputMapViewCollection()
		{
		}

		public ACInputGroupInputMapViewCollection(ACInputGroupInputMapDataCollection list)
		{
			foreach (ACInputGroupInputMapData item in list)
			{
				this.List.Add(new ACInputGroupInputMapView(item));
			}
			this._block.Size = list.Block.Size;
			this._block.Index = list.Block.Index;
			this._block.Count = list.Block.Count;
			this._block.Records = list.Block.Records;
		}

		public CollectionBlock Block
		{
			get{ return this._block; }
		}

		public ACInputGroupInputMapDataCollection ToACInputGroupInputMapDataCollection()
		{
			ACInputGroupInputMapDataCollection retList = new ACInputGroupInputMapDataCollection();
			foreach (ACInputGroupInputMapView item in base.List)
			{
				retList.Add(item.ToACInputGroupInputMapData());
			}

			retList.AcceptChanges();
			return retList;
		}

		public void Add(ACInputGroupInputMapView entity)
		{
			this.List.Add(entity);
		}

		public void Insert(int index, ACInputGroupInputMapView entity)
		{
			this.List.Insert(index, entity);
		}

		public void Remove(ACInputGroupInputMapView entity)
		{
			this.List.Remove(entity);
		}

		public void AddRange(ACInputGroupInputMapViewCollection list)
		{
			foreach (ACInputGroupInputMapView item in list)
			{
				this.List.Add(item);
			}
		}

		public ACInputGroupInputMapView this[int index]
		{
			get{ return (ACInputGroupInputMapView)base.List[index]; }
			set{ base.List[index] = value; }
		}

		public ACInputGroupInputMapViewCollection SubCollection()
		{
			ACInputGroupInputMapViewCollection retList = new ACInputGroupInputMapViewCollection();
			if (this.Count <= this.Block.Size)
			{
				retList.AddRange(this);

				retList.Block.Size = this.Block.Size;
				retList.Block.Count = 1;
				retList.Block.Index = 0;
				retList.Block.Records = this.Count;
				return retList;
			}

			int start = this.Block.Index * this.Block.Size;
			int count = this.Block.Size;
			for (int i = start; i < (start + count); i++)
			{
				if (i >= this.Count)
					break;

				retList.Add(this[i]);
			}

			retList.Block.Size = this.Block.Size;
			retList.Block.Index = this.Block.Index;
			retList.Block.Count = (this.Count / this.Block.Size) + (this.Count % this.Block.Size == 0 ? 0 : 1);
			retList.Block.Records = this.Count;

			return retList;
		}
	}
	[Serializable]
	public class UsrAccountBRRuleViewCollection : CollectionBase
	{
		private CollectionBlock _block = new CollectionBlock();
		public UsrAccountBRRuleViewCollection()
		{
		}

		public UsrAccountBRRuleViewCollection(UsrAccountBRRuleDataCollection list)
		{
			foreach (UsrAccountBRRuleData item in list)
			{
				this.List.Add(new UsrAccountBRRuleView(item));
			}
			this._block.Size = list.Block.Size;
			this._block.Index = list.Block.Index;
			this._block.Count = list.Block.Count;
			this._block.Records = list.Block.Records;
		}

		public CollectionBlock Block
		{
			get{ return this._block; }
		}

		public UsrAccountBRRuleDataCollection ToUsrAccountBRRuleDataCollection()
		{
			UsrAccountBRRuleDataCollection retList = new UsrAccountBRRuleDataCollection();
			foreach (UsrAccountBRRuleView item in base.List)
			{
				retList.Add(item.ToUsrAccountBRRuleData());
			}

			retList.AcceptChanges();
			return retList;
		}

		public void Add(UsrAccountBRRuleView entity)
		{
			this.List.Add(entity);
		}

		public void Insert(int index, UsrAccountBRRuleView entity)
		{
			this.List.Insert(index, entity);
		}

		public void Remove(UsrAccountBRRuleView entity)
		{
			this.List.Remove(entity);
		}

		public void AddRange(UsrAccountBRRuleViewCollection list)
		{
			foreach (UsrAccountBRRuleView item in list)
			{
				this.List.Add(item);
			}
		}

		public UsrAccountBRRuleView this[int index]
		{
			get{ return (UsrAccountBRRuleView)base.List[index]; }
			set{ base.List[index] = value; }
		}

		public UsrAccountBRRuleViewCollection SubCollection()
		{
			UsrAccountBRRuleViewCollection retList = new UsrAccountBRRuleViewCollection();
			if (this.Count <= this.Block.Size)
			{
				retList.AddRange(this);

				retList.Block.Size = this.Block.Size;
				retList.Block.Count = 1;
				retList.Block.Index = 0;
				retList.Block.Records = this.Count;
				return retList;
			}

			int start = this.Block.Index * this.Block.Size;
			int count = this.Block.Size;
			for (int i = start; i < (start + count); i++)
			{
				if (i >= this.Count)
					break;

				retList.Add(this[i]);
			}

			retList.Block.Size = this.Block.Size;
			retList.Block.Index = this.Block.Index;
			retList.Block.Count = (this.Count / this.Block.Size) + (this.Count % this.Block.Size == 0 ? 0 : 1);
			retList.Block.Records = this.Count;

			return retList;
		}
	}
	[Serializable]
	public class UsrAccountTenantMapViewCollection : CollectionBase
	{
		private CollectionBlock _block = new CollectionBlock();
		public UsrAccountTenantMapViewCollection()
		{
		}

		public UsrAccountTenantMapViewCollection(UsrAccountTenantMapDataCollection list)
		{
			foreach (UsrAccountTenantMapData item in list)
			{
				this.List.Add(new UsrAccountTenantMapView(item));
			}
			this._block.Size = list.Block.Size;
			this._block.Index = list.Block.Index;
			this._block.Count = list.Block.Count;
			this._block.Records = list.Block.Records;
		}

		public CollectionBlock Block
		{
			get{ return this._block; }
		}

		public UsrAccountTenantMapDataCollection ToUsrAccountTenantMapDataCollection()
		{
			UsrAccountTenantMapDataCollection retList = new UsrAccountTenantMapDataCollection();
			foreach (UsrAccountTenantMapView item in base.List)
			{
				retList.Add(item.ToUsrAccountTenantMapData());
			}

			retList.AcceptChanges();
			return retList;
		}

		public void Add(UsrAccountTenantMapView entity)
		{
			this.List.Add(entity);
		}

		public void Insert(int index, UsrAccountTenantMapView entity)
		{
			this.List.Insert(index, entity);
		}

		public void Remove(UsrAccountTenantMapView entity)
		{
			this.List.Remove(entity);
		}

		public void AddRange(UsrAccountTenantMapViewCollection list)
		{
			foreach (UsrAccountTenantMapView item in list)
			{
				this.List.Add(item);
			}
		}

		public UsrAccountTenantMapView this[int index]
		{
			get{ return (UsrAccountTenantMapView)base.List[index]; }
			set{ base.List[index] = value; }
		}

		public UsrAccountTenantMapViewCollection SubCollection()
		{
			UsrAccountTenantMapViewCollection retList = new UsrAccountTenantMapViewCollection();
			if (this.Count <= this.Block.Size)
			{
				retList.AddRange(this);

				retList.Block.Size = this.Block.Size;
				retList.Block.Count = 1;
				retList.Block.Index = 0;
				retList.Block.Records = this.Count;
				return retList;
			}

			int start = this.Block.Index * this.Block.Size;
			int count = this.Block.Size;
			for (int i = start; i < (start + count); i++)
			{
				if (i >= this.Count)
					break;

				retList.Add(this[i]);
			}

			retList.Block.Size = this.Block.Size;
			retList.Block.Index = this.Block.Index;
			retList.Block.Count = (this.Count / this.Block.Size) + (this.Count % this.Block.Size == 0 ? 0 : 1);
			retList.Block.Records = this.Count;

			return retList;
		}
	}
}
