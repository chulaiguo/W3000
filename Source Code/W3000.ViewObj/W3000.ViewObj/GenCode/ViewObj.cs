using System;
using System.Data;
using System.Text;
using Cheke;
using Cheke.BusinessEntity;
using W3000.Data;
using W3000.BasicServiceWrapper;

namespace W3000.ViewObj
{
	[Serializable]
	public partial class ACIntvalHolidayMap :  ACIntvalHolidayMapData, Cheke.BusinessEntity.IPersist
	{
		#region Constructors
		public ACIntvalHolidayMap()
		{
		}

		public ACIntvalHolidayMap(ACIntvalHolidayMapData data)
			:base(data)
		{
		}
		#endregion

		#region Parents
		public virtual ACInterval ACInterval
		{
			get
			{
				ACInterval parent = new ACInterval();
				parent.ACIntervalPK = this.ACIntervalPK;
				parent.End = this.End;
				parent.Begin = this.Begin;
				parent.IVID = this.IVID;
				parent.BDBuildingPK = this.BDBuildingPK;
				return parent;
			}
			set
			{
				if(value == null)
					return;

				this.ACIntervalPK = value.ACIntervalPK;
				this.End = value.End;
				this.Begin = value.Begin;
				this.IVID = value.IVID;
				this.BDBuildingPK = value.BDBuildingPK;
			}
		}

		public virtual BDBuilding BDBuilding
		{
			get
			{
				BDBuilding parent = new BDBuilding();
				parent.BDBuildingPK = this.BDBuildingPK;
				parent.Address1 = this.Address1;
				parent.BuildingID = this.BuildingID;
				return parent;
			}
			set
			{
				if(value == null)
					return;

				this.BDBuildingPK = value.BDBuildingPK;
				this.Address1 = value.Address1;
				this.BuildingID = value.BuildingID;
			}
		}

		public virtual UtilHoliday UtilHoliday
		{
			get
			{
				UtilHoliday parent = new UtilHoliday();
				parent.UtilHolidayPK = this.UtilHolidayPK;
				parent.Date = this.Date;
				parent.Holiday = this.Holiday;
				return parent;
			}
			set
			{
				if(value == null)
					return;

				this.UtilHolidayPK = value.UtilHolidayPK;
				this.Date = value.Date;
				this.Holiday = value.Holiday;
			}
		}

		#endregion

		#region Children
		#endregion

		public virtual Cheke.BusinessEntity.Result Save(SecurityToken token)
		{
			if (!this.IsDirty)
			{
				return new Result(true);
			}

			ACIntvalHolidayMapData item = new ACIntvalHolidayMapData(this);
			item.GetChanges();
			return ACIntvalHolidayMapWrapper.Save(item, token);
		}

		public virtual Cheke.BusinessEntity.Result Save()
		{
			return this.Save(Cheke.Identity.Token);
		}

	}
	[Serializable]
	public partial class ACAccessLevelDetail :  ACAccessLevelDetailData, Cheke.BusinessEntity.IPersist
	{
		#region Constructors
		public ACAccessLevelDetail()
		{
		}

		public ACAccessLevelDetail(ACAccessLevelDetailData data)
			:base(data)
		{
		}
		#endregion

		#region Parents
		public virtual ACAccessLevel ACAccessLevel
		{
			get
			{
				ACAccessLevel parent = new ACAccessLevel();
				parent.ACAccessLevelPK = this.ACAccessLevelPK;
				parent.Summary = this.ALSummary;
				parent.AccessLevelID = this.AccessLevelID;
				parent.BDBuildingPK = this.BDBuildingPK;
				return parent;
			}
			set
			{
				if(value == null)
					return;

				this.ACAccessLevelPK = value.ACAccessLevelPK;
				this.ALSummary = value.Summary;
				this.AccessLevelID = value.AccessLevelID;
				this.BDBuildingPK = value.BDBuildingPK;
			}
		}

		public virtual ACMainZone ACMainZone
		{
			get
			{
				ACMainZone parent = new ACMainZone();
				parent.ACMainZonePK = this.ACMainZonePK;
				parent.Description = this.MainZoneDescription;
				parent.MainZoneID = this.MainZoneID;
				parent.ACPanelPK = this.ACPanelPK;
				return parent;
			}
			set
			{
				if(value == null)
					return;

				this.ACMainZonePK = value.ACMainZonePK;
				this.MainZoneDescription = value.Description;
				this.MainZoneID = value.MainZoneID;
				this.ACPanelPK = value.ACPanelPK;
			}
		}

		public virtual ACPanel ACPanel
		{
			get
			{
				ACPanel parent = new ACPanel();
				parent.ACPanelPK = this.ACPanelPK;
				parent.UnitID = this.UnitID;
				return parent;
			}
			set
			{
				if(value == null)
					return;

				this.ACPanelPK = value.ACPanelPK;
				this.UnitID = value.UnitID;
			}
		}

		public virtual ACTimecode ACTimecode
		{
			get
			{
				ACTimecode parent = new ACTimecode();
				parent.ACTimecodePK = this.ACTimecodePK;
				parent.Summary = this.TimecodeSummary;
				parent.TCID = this.TCID;
				return parent;
			}
			set
			{
				if(value == null)
					return;

				this.ACTimecodePK = value.ACTimecodePK;
				this.TimecodeSummary = value.Summary;
				this.TCID = value.TCID;
			}
		}

		public virtual BDBuilding BDBuilding
		{
			get
			{
				BDBuilding parent = new BDBuilding();
				parent.BDBuildingPK = this.BDBuildingPK;
				parent.Address1 = this.Address1;
				parent.BuildingID = this.BuildingID;
				return parent;
			}
			set
			{
				if(value == null)
					return;

				this.BDBuildingPK = value.BDBuildingPK;
				this.Address1 = value.Address1;
				this.BuildingID = value.BuildingID;
			}
		}

		#endregion

		#region Children
		#endregion

		public virtual Cheke.BusinessEntity.Result Save(SecurityToken token)
		{
			if (!this.IsDirty)
			{
				return new Result(true);
			}

			ACAccessLevelDetailData item = new ACAccessLevelDetailData(this);
			item.GetChanges();
			return ACAccessLevelDetailWrapper.Save(item, token);
		}

		public virtual Cheke.BusinessEntity.Result Save()
		{
			return this.Save(Cheke.Identity.Token);
		}

	}
	[Serializable]
	public partial class UsrAccountBuildingMap :  UsrAccountBuildingMapData, Cheke.BusinessEntity.IPersist
	{
		#region Constructors
		public UsrAccountBuildingMap()
		{
		}

		public UsrAccountBuildingMap(UsrAccountBuildingMapData data)
			:base(data)
		{
		}
		#endregion

		#region Parents
		public virtual BDBuilding BDBuilding
		{
			get
			{
				BDBuilding parent = new BDBuilding();
				parent.BDBuildingPK = this.BDBuildingPK;
				parent.Address1 = this.Address1;
				parent.BuildingID = this.BuildingID;
				return parent;
			}
			set
			{
				if(value == null)
					return;

				this.BDBuildingPK = value.BDBuildingPK;
				this.Address1 = value.Address1;
				this.BuildingID = value.BuildingID;
			}
		}

		public virtual UsrAccount UsrAccount
		{
			get
			{
				UsrAccount parent = new UsrAccount();
				parent.UsrAccountPK = this.UsrAccountPK;
				parent.UserID = this.UserID;
				return parent;
			}
			set
			{
				if(value == null)
					return;

				this.UsrAccountPK = value.UsrAccountPK;
				this.UserID = value.UserID;
			}
		}

		#endregion

		#region Children
		#endregion

		public virtual Cheke.BusinessEntity.Result Save(SecurityToken token)
		{
			if (!this.IsDirty)
			{
				return new Result(true);
			}

			UsrAccountBuildingMapData item = new UsrAccountBuildingMapData(this);
			item.GetChanges();
			return UsrAccountBuildingMapWrapper.Save(item, token);
		}

		public virtual Cheke.BusinessEntity.Result Save()
		{
			return this.Save(Cheke.Identity.Token);
		}

	}
	[Serializable]
	public partial class BDBuilding :  BDBuildingData, Cheke.BusinessEntity.IPersist
	{
		#region Constructors
		public BDBuilding()
		{
		}

		public BDBuilding(BDBuildingData data)
			:base(data)
		{
		}
		#endregion

		#region Parents
		#endregion

		#region Children
		public new virtual UsrAccountBuildingMapCollection UsrAccountBuildingMapList
		{
			get
			{
				return ((UsrAccountBuildingMapCollection)(base.UsrAccountBuildingMapList));
			}
			set
			{
				base.UsrAccountBuildingMapList = value;
			}
		}

		public new virtual ACPanelCollection ACPanelList
		{
			get
			{
				return ((ACPanelCollection)(base.ACPanelList));
			}
			set
			{
				base.ACPanelList = value;
			}
		}

		public new virtual BDTenantCollection BDTenantList
		{
			get
			{
				return ((BDTenantCollection)(base.BDTenantList));
			}
			set
			{
				base.BDTenantList = value;
			}
		}

		public new virtual BDBuildingHolidayMapCollection BDBuildingHolidayMapList
		{
			get
			{
				return ((BDBuildingHolidayMapCollection)(base.BDBuildingHolidayMapList));
			}
			set
			{
				base.BDBuildingHolidayMapList = value;
			}
		}

		public new virtual ACIntervalCollection ACIntervalList
		{
			get
			{
				return ((ACIntervalCollection)(base.ACIntervalList));
			}
			set
			{
				base.ACIntervalList = value;
			}
		}

		public new virtual ACTimecodeCollection ACTimecodeList
		{
			get
			{
				return ((ACTimecodeCollection)(base.ACTimecodeList));
			}
			set
			{
				base.ACTimecodeList = value;
			}
		}

		public new virtual ACAMFormatCollection ACAMFormatList
		{
			get
			{
				return ((ACAMFormatCollection)(base.ACAMFormatList));
			}
			set
			{
				base.ACAMFormatList = value;
			}
		}

		public new virtual ACAccessLevelCollection ACAccessLevelList
		{
			get
			{
				return ((ACAccessLevelCollection)(base.ACAccessLevelList));
			}
			set
			{
				base.ACAccessLevelList = value;
			}
		}

		public new virtual ACCardHolderBuildingMapCollection ACCardHolderBuildingMapList
		{
			get
			{
				return ((ACCardHolderBuildingMapCollection)(base.ACCardHolderBuildingMapList));
			}
			set
			{
				base.ACCardHolderBuildingMapList = value;
			}
		}

		#endregion

		protected override void CloneChildren(BusinessBase entity)
		{
			BDBuildingData data = entity as BDBuildingData;
			if (data == null)
				return;

			if (data.UsrAccountBuildingMapList != null)
			{
				this.UsrAccountBuildingMapList = new UsrAccountBuildingMapCollection(data.UsrAccountBuildingMapList);
			}
			if (data.ACPanelList != null)
			{
				this.ACPanelList = new ACPanelCollection(data.ACPanelList);
			}
			if (data.BDTenantList != null)
			{
				this.BDTenantList = new BDTenantCollection(data.BDTenantList);
			}
			if (data.BDBuildingHolidayMapList != null)
			{
				this.BDBuildingHolidayMapList = new BDBuildingHolidayMapCollection(data.BDBuildingHolidayMapList);
			}
			if (data.ACIntervalList != null)
			{
				this.ACIntervalList = new ACIntervalCollection(data.ACIntervalList);
			}
			if (data.ACTimecodeList != null)
			{
				this.ACTimecodeList = new ACTimecodeCollection(data.ACTimecodeList);
			}
			if (data.ACAMFormatList != null)
			{
				this.ACAMFormatList = new ACAMFormatCollection(data.ACAMFormatList);
			}
			if (data.ACAccessLevelList != null)
			{
				this.ACAccessLevelList = new ACAccessLevelCollection(data.ACAccessLevelList);
			}
			if (data.ACCardHolderBuildingMapList != null)
			{
				this.ACCardHolderBuildingMapList = new ACCardHolderBuildingMapCollection(data.ACCardHolderBuildingMapList);
			}
		}

		public virtual Cheke.BusinessEntity.Result Save(SecurityToken token)
		{
			if (!this.IsDirty)
			{
				return new Result(true);
			}

			BDBuildingData item = new BDBuildingData(this);
			item.GetChanges();
			return BDBuildingWrapper.Save(item, token);
		}

		public virtual Cheke.BusinessEntity.Result Save()
		{
			return this.Save(Cheke.Identity.Token);
		}

	}
	[Serializable]
	public partial class BDTenant :  BDTenantData, Cheke.BusinessEntity.IPersist
	{
		#region Constructors
		public BDTenant()
		{
		}

		public BDTenant(BDTenantData data)
			:base(data)
		{
		}
		#endregion

		#region Parents
		public virtual BDBuilding BDBuilding
		{
			get
			{
				BDBuilding parent = new BDBuilding();
				parent.BDBuildingPK = this.BDBuildingPK;
				parent.Address1 = this.Address1;
				parent.BuildingID = this.BuildingID;
				return parent;
			}
			set
			{
				if(value == null)
					return;

				this.BDBuildingPK = value.BDBuildingPK;
				this.Address1 = value.Address1;
				this.BuildingID = value.BuildingID;
			}
		}

		#endregion

		#region Children
		public new virtual UsrAccountTenantMapCollection UsrAccountTenantMapList
		{
			get
			{
				return ((UsrAccountTenantMapCollection)(base.UsrAccountTenantMapList));
			}
			set
			{
				base.UsrAccountTenantMapList = value;
			}
		}

		public new virtual UsrAccountCollection UsrAccountList
		{
			get
			{
				return ((UsrAccountCollection)(base.UsrAccountList));
			}
			set
			{
				base.UsrAccountList = value;
			}
		}

		public new virtual ACFunctionCardCollection ACFunctionCardList
		{
			get
			{
				return ((ACFunctionCardCollection)(base.ACFunctionCardList));
			}
			set
			{
				base.ACFunctionCardList = value;
			}
		}

		public new virtual BDTenantHolidayMapCollection BDTenantHolidayMapList
		{
			get
			{
				return ((BDTenantHolidayMapCollection)(base.BDTenantHolidayMapList));
			}
			set
			{
				base.BDTenantHolidayMapList = value;
			}
		}

		public new virtual ACCardHolderCollection ACCardHolderList
		{
			get
			{
				return ((ACCardHolderCollection)(base.ACCardHolderList));
			}
			set
			{
				base.ACCardHolderList = value;
			}
		}

		public new virtual BDVisitorCollection BDVisitorList
		{
			get
			{
				return ((BDVisitorCollection)(base.BDVisitorList));
			}
			set
			{
				base.BDVisitorList = value;
			}
		}

		#endregion

		protected override void CloneChildren(BusinessBase entity)
		{
			BDTenantData data = entity as BDTenantData;
			if (data == null)
				return;

			if (data.UsrAccountTenantMapList != null)
			{
				this.UsrAccountTenantMapList = new UsrAccountTenantMapCollection(data.UsrAccountTenantMapList);
			}
			if (data.UsrAccountList != null)
			{
				this.UsrAccountList = new UsrAccountCollection(data.UsrAccountList);
			}
			if (data.ACFunctionCardList != null)
			{
				this.ACFunctionCardList = new ACFunctionCardCollection(data.ACFunctionCardList);
			}
			if (data.BDTenantHolidayMapList != null)
			{
				this.BDTenantHolidayMapList = new BDTenantHolidayMapCollection(data.BDTenantHolidayMapList);
			}
			if (data.ACCardHolderList != null)
			{
				this.ACCardHolderList = new ACCardHolderCollection(data.ACCardHolderList);
			}
			if (data.BDVisitorList != null)
			{
				this.BDVisitorList = new BDVisitorCollection(data.BDVisitorList);
			}
		}

		public virtual Cheke.BusinessEntity.Result Save(SecurityToken token)
		{
			if (!this.IsDirty)
			{
				return new Result(true);
			}

			BDTenantData item = new BDTenantData(this);
			item.GetChanges();
			return BDTenantWrapper.Save(item, token);
		}

		public virtual Cheke.BusinessEntity.Result Save()
		{
			return this.Save(Cheke.Identity.Token);
		}

	}
	[Serializable]
	public partial class UtilSettingCategory :  UtilSettingCategoryData, Cheke.BusinessEntity.IPersist
	{
		#region Constructors
		public UtilSettingCategory()
		{
		}

		public UtilSettingCategory(UtilSettingCategoryData data)
			:base(data)
		{
		}
		#endregion

		#region Parents
		#endregion

		#region Children
		public new virtual UtilSettingDetailCollection UtilSettingDetailList
		{
			get
			{
				return ((UtilSettingDetailCollection)(base.UtilSettingDetailList));
			}
			set
			{
				base.UtilSettingDetailList = value;
			}
		}

		#endregion

		protected override void CloneChildren(BusinessBase entity)
		{
			UtilSettingCategoryData data = entity as UtilSettingCategoryData;
			if (data == null)
				return;

			if (data.UtilSettingDetailList != null)
			{
				this.UtilSettingDetailList = new UtilSettingDetailCollection(data.UtilSettingDetailList);
			}
		}

		public virtual Cheke.BusinessEntity.Result Save(SecurityToken token)
		{
			if (!this.IsDirty)
			{
				return new Result(true);
			}

			UtilSettingCategoryData item = new UtilSettingCategoryData(this);
			item.GetChanges();
			return UtilSettingCategoryWrapper.Save(item, token);
		}

		public virtual Cheke.BusinessEntity.Result Save()
		{
			return this.Save(Cheke.Identity.Token);
		}

	}
	[Serializable]
	public partial class UtilSettingDetail :  UtilSettingDetailData, Cheke.BusinessEntity.IPersist
	{
		#region Constructors
		public UtilSettingDetail()
		{
		}

		public UtilSettingDetail(UtilSettingDetailData data)
			:base(data)
		{
		}
		#endregion

		#region Parents
		public virtual UtilSettingCategory UtilSettingCategory
		{
			get
			{
				UtilSettingCategory parent = new UtilSettingCategory();
				parent.UtilSettingCategoryPK = this.UtilSettingCategoryPK;
				parent.SettingCategory = this.SettingCategory;
				parent.SettingCategoryID = this.SettingCategoryID;
				return parent;
			}
			set
			{
				if(value == null)
					return;

				this.UtilSettingCategoryPK = value.UtilSettingCategoryPK;
				this.SettingCategory = value.SettingCategory;
				this.SettingCategoryID = value.SettingCategoryID;
			}
		}

		#endregion

		#region Children
		#endregion

		public virtual Cheke.BusinessEntity.Result Save(SecurityToken token)
		{
			if (!this.IsDirty)
			{
				return new Result(true);
			}

			UtilSettingDetailData item = new UtilSettingDetailData(this);
			item.GetChanges();
			return UtilSettingDetailWrapper.Save(item, token);
		}

		public virtual Cheke.BusinessEntity.Result Save()
		{
			return this.Save(Cheke.Identity.Token);
		}

	}
	[Serializable]
	public partial class ACOutputGroupMainZoneMap :  ACOutputGroupMainZoneMapData, Cheke.BusinessEntity.IPersist
	{
		#region Constructors
		public ACOutputGroupMainZoneMap()
		{
		}

		public ACOutputGroupMainZoneMap(ACOutputGroupMainZoneMapData data)
			:base(data)
		{
		}
		#endregion

		#region Parents
		public virtual ACMainZone ACMainZone
		{
			get
			{
				ACMainZone parent = new ACMainZone();
				parent.ACMainZonePK = this.ACMainZonePK;
				parent.MainZoneID = this.MainZoneID;
				parent.ACPanelPK = this.ACPanelPK;
				return parent;
			}
			set
			{
				if(value == null)
					return;

				this.ACMainZonePK = value.ACMainZonePK;
				this.MainZoneID = value.MainZoneID;
				this.ACPanelPK = value.ACPanelPK;
			}
		}

		public virtual ACOutputGroup ACOutputGroup
		{
			get
			{
				ACOutputGroup parent = new ACOutputGroup();
				parent.ACOutputGroupPK = this.ACOutputGroupPK;
				parent.GroupID = this.GroupID;
				return parent;
			}
			set
			{
				if(value == null)
					return;

				this.ACOutputGroupPK = value.ACOutputGroupPK;
				this.GroupID = value.GroupID;
			}
		}

		public virtual ACPanel ACPanel
		{
			get
			{
				ACPanel parent = new ACPanel();
				parent.ACPanelPK = this.ACPanelPK;
				parent.UnitID = this.UnitID;
				return parent;
			}
			set
			{
				if(value == null)
					return;

				this.ACPanelPK = value.ACPanelPK;
				this.UnitID = value.UnitID;
			}
		}

		public virtual BDBuilding BDBuilding
		{
			get
			{
				BDBuilding parent = new BDBuilding();
				parent.BDBuildingPK = this.BDBuildingPK;
				parent.Address1 = this.Address1;
				parent.BuildingID = this.BuildingID;
				return parent;
			}
			set
			{
				if(value == null)
					return;

				this.BDBuildingPK = value.BDBuildingPK;
				this.Address1 = value.Address1;
				this.BuildingID = value.BuildingID;
			}
		}

		#endregion

		#region Children
		#endregion

		public virtual Cheke.BusinessEntity.Result Save(SecurityToken token)
		{
			if (!this.IsDirty)
			{
				return new Result(true);
			}

			ACOutputGroupMainZoneMapData item = new ACOutputGroupMainZoneMapData(this);
			item.GetChanges();
			return ACOutputGroupMainZoneMapWrapper.Save(item, token);
		}

		public virtual Cheke.BusinessEntity.Result Save()
		{
			return this.Save(Cheke.Identity.Token);
		}

	}
	[Serializable]
	public partial class ACCardHolder :  ACCardHolderData, Cheke.BusinessEntity.IPersist
	{
		#region Constructors
		public ACCardHolder()
		{
		}

		public ACCardHolder(ACCardHolderData data)
			:base(data)
		{
		}
		#endregion

		#region Parents
		public virtual BDBuilding BDBuilding
		{
			get
			{
				BDBuilding parent = new BDBuilding();
				parent.BDBuildingPK = this.BDBuildingPK;
				parent.Address1 = this.Address1;
				parent.BuildingID = this.BuildingID;
				return parent;
			}
			set
			{
				if(value == null)
					return;

				this.BDBuildingPK = value.BDBuildingPK;
				this.Address1 = value.Address1;
				this.BuildingID = value.BuildingID;
			}
		}

		public virtual BDTenant BDTenant
		{
			get
			{
				BDTenant parent = new BDTenant();
				parent.BDTenantPK = this.BDTenantPK;
				parent.Suite = this.Suite;
				parent.Tenant = this.Tenant;
				parent.BDBuildingPK = this.BDBuildingPK;
				return parent;
			}
			set
			{
				if(value == null)
					return;

				this.BDTenantPK = value.BDTenantPK;
				this.Suite = value.Suite;
				this.Tenant = value.Tenant;
				this.BDBuildingPK = value.BDBuildingPK;
			}
		}

		#endregion

		#region Children
		public new virtual ACCardHolderBuildingMapCollection ACCardHolderBuildingMapList
		{
			get
			{
				return ((ACCardHolderBuildingMapCollection)(base.ACCardHolderBuildingMapList));
			}
			set
			{
				base.ACCardHolderBuildingMapList = value;
			}
		}

		#endregion

		protected override void CloneChildren(BusinessBase entity)
		{
			ACCardHolderData data = entity as ACCardHolderData;
			if (data == null)
				return;

			if (data.ACCardHolderBuildingMapList != null)
			{
				this.ACCardHolderBuildingMapList = new ACCardHolderBuildingMapCollection(data.ACCardHolderBuildingMapList);
			}
		}

		public virtual Cheke.BusinessEntity.Result Save(SecurityToken token)
		{
			if (!this.IsDirty)
			{
				return new Result(true);
			}

			ACCardHolderData item = new ACCardHolderData(this);
			item.GetChanges();
			return ACCardHolderWrapper.Save(item, token);
		}

		public virtual Cheke.BusinessEntity.Result Save()
		{
			return this.Save(Cheke.Identity.Token);
		}

	}
	[Serializable]
	public partial class ACMainZone :  ACMainZoneData, Cheke.BusinessEntity.IPersist
	{
		#region Constructors
		public ACMainZone()
		{
		}

		public ACMainZone(ACMainZoneData data)
			:base(data)
		{
		}
		#endregion

		#region Parents
		public virtual ACPanel ACPanel
		{
			get
			{
				ACPanel parent = new ACPanel();
				parent.ACPanelPK = this.ACPanelPK;
				parent.BDBuildingPK = this.BDBuildingPK;
				parent.UnitID = this.UnitID;
				return parent;
			}
			set
			{
				if(value == null)
					return;

				this.ACPanelPK = value.ACPanelPK;
				this.BDBuildingPK = value.BDBuildingPK;
				this.UnitID = value.UnitID;
			}
		}

		public virtual BDBuilding BDBuilding
		{
			get
			{
				BDBuilding parent = new BDBuilding();
				parent.BDBuildingPK = this.BDBuildingPK;
				parent.Address1 = this.Address1;
				parent.BuildingID = this.BuildingID;
				return parent;
			}
			set
			{
				if(value == null)
					return;

				this.BDBuildingPK = value.BDBuildingPK;
				this.Address1 = value.Address1;
				this.BuildingID = value.BuildingID;
			}
		}

		#endregion

		#region Children
		public new virtual ACOutputGroupMainZoneMapCollection ACOutputGroupMainZoneMapList
		{
			get
			{
				return ((ACOutputGroupMainZoneMapCollection)(base.ACOutputGroupMainZoneMapList));
			}
			set
			{
				base.ACOutputGroupMainZoneMapList = value;
			}
		}

		public new virtual ACAccessLevelDetailCollection ACAccessLevelDetailList
		{
			get
			{
				return ((ACAccessLevelDetailCollection)(base.ACAccessLevelDetailList));
			}
			set
			{
				base.ACAccessLevelDetailList = value;
			}
		}

		#endregion

		protected override void CloneChildren(BusinessBase entity)
		{
			ACMainZoneData data = entity as ACMainZoneData;
			if (data == null)
				return;

			if (data.ACOutputGroupMainZoneMapList != null)
			{
				this.ACOutputGroupMainZoneMapList = new ACOutputGroupMainZoneMapCollection(data.ACOutputGroupMainZoneMapList);
			}
			if (data.ACAccessLevelDetailList != null)
			{
				this.ACAccessLevelDetailList = new ACAccessLevelDetailCollection(data.ACAccessLevelDetailList);
			}
		}

		public virtual Cheke.BusinessEntity.Result Save(SecurityToken token)
		{
			if (!this.IsDirty)
			{
				return new Result(true);
			}

			ACMainZoneData item = new ACMainZoneData(this);
			item.GetChanges();
			return ACMainZoneWrapper.Save(item, token);
		}

		public virtual Cheke.BusinessEntity.Result Save()
		{
			return this.Save(Cheke.Identity.Token);
		}

	}
	[Serializable]
	public partial class ACInterval :  ACIntervalData, Cheke.BusinessEntity.IPersist
	{
		#region Constructors
		public ACInterval()
		{
		}

		public ACInterval(ACIntervalData data)
			:base(data)
		{
		}
		#endregion

		#region Parents
		public virtual BDBuilding BDBuilding
		{
			get
			{
				BDBuilding parent = new BDBuilding();
				parent.BDBuildingPK = this.BDBuildingPK;
				parent.Address1 = this.Address1;
				parent.BuildingID = this.BuildingID;
				return parent;
			}
			set
			{
				if(value == null)
					return;

				this.BDBuildingPK = value.BDBuildingPK;
				this.Address1 = value.Address1;
				this.BuildingID = value.BuildingID;
			}
		}

		#endregion

		#region Children
		public new virtual ACIntvalHolidayMapCollection ACIntvalHolidayMapList
		{
			get
			{
				return ((ACIntvalHolidayMapCollection)(base.ACIntvalHolidayMapList));
			}
			set
			{
				base.ACIntvalHolidayMapList = value;
			}
		}

		public new virtual ACTimecodeIntervalMapCollection ACTimecodeIntervalMapList
		{
			get
			{
				return ((ACTimecodeIntervalMapCollection)(base.ACTimecodeIntervalMapList));
			}
			set
			{
				base.ACTimecodeIntervalMapList = value;
			}
		}

		#endregion

		protected override void CloneChildren(BusinessBase entity)
		{
			ACIntervalData data = entity as ACIntervalData;
			if (data == null)
				return;

			if (data.ACIntvalHolidayMapList != null)
			{
				this.ACIntvalHolidayMapList = new ACIntvalHolidayMapCollection(data.ACIntvalHolidayMapList);
			}
			if (data.ACTimecodeIntervalMapList != null)
			{
				this.ACTimecodeIntervalMapList = new ACTimecodeIntervalMapCollection(data.ACTimecodeIntervalMapList);
			}
		}

		public virtual Cheke.BusinessEntity.Result Save(SecurityToken token)
		{
			if (!this.IsDirty)
			{
				return new Result(true);
			}

			ACIntervalData item = new ACIntervalData(this);
			item.GetChanges();
			return ACIntervalWrapper.Save(item, token);
		}

		public virtual Cheke.BusinessEntity.Result Save()
		{
			return this.Save(Cheke.Identity.Token);
		}

	}
	[Serializable]
	public partial class ACPanelHolidayMap :  ACPanelHolidayMapData, Cheke.BusinessEntity.IPersist
	{
		#region Constructors
		public ACPanelHolidayMap()
		{
		}

		public ACPanelHolidayMap(ACPanelHolidayMapData data)
			:base(data)
		{
		}
		#endregion

		#region Parents
		public virtual ACPanel ACPanel
		{
			get
			{
				ACPanel parent = new ACPanel();
				parent.ACPanelPK = this.ACPanelPK;
				parent.BDBuildingPK = this.BDBuildingPK;
				parent.UnitID = this.UnitID;
				return parent;
			}
			set
			{
				if(value == null)
					return;

				this.ACPanelPK = value.ACPanelPK;
				this.BDBuildingPK = value.BDBuildingPK;
				this.UnitID = value.UnitID;
			}
		}

		public virtual BDBuilding BDBuilding
		{
			get
			{
				BDBuilding parent = new BDBuilding();
				parent.BDBuildingPK = this.BDBuildingPK;
				parent.Address1 = this.Address1;
				parent.BuildingID = this.BuildingID;
				return parent;
			}
			set
			{
				if(value == null)
					return;

				this.BDBuildingPK = value.BDBuildingPK;
				this.Address1 = value.Address1;
				this.BuildingID = value.BuildingID;
			}
		}

		public virtual UtilHoliday UtilHoliday
		{
			get
			{
				UtilHoliday parent = new UtilHoliday();
				parent.UtilHolidayPK = this.UtilHolidayPK;
				parent.Date = this.Date;
				parent.Holiday = this.Holiday;
				return parent;
			}
			set
			{
				if(value == null)
					return;

				this.UtilHolidayPK = value.UtilHolidayPK;
				this.Date = value.Date;
				this.Holiday = value.Holiday;
			}
		}

		#endregion

		#region Children
		#endregion

		public virtual Cheke.BusinessEntity.Result Save(SecurityToken token)
		{
			if (!this.IsDirty)
			{
				return new Result(true);
			}

			ACPanelHolidayMapData item = new ACPanelHolidayMapData(this);
			item.GetChanges();
			return ACPanelHolidayMapWrapper.Save(item, token);
		}

		public virtual Cheke.BusinessEntity.Result Save()
		{
			return this.Save(Cheke.Identity.Token);
		}

	}
	[Serializable]
	public partial class ACTimecode :  ACTimecodeData, Cheke.BusinessEntity.IPersist
	{
		#region Constructors
		public ACTimecode()
		{
		}

		public ACTimecode(ACTimecodeData data)
			:base(data)
		{
		}
		#endregion

		#region Parents
		public virtual BDBuilding BDBuilding
		{
			get
			{
				BDBuilding parent = new BDBuilding();
				parent.BDBuildingPK = this.BDBuildingPK;
				parent.Address1 = this.Address1;
				parent.BuildingID = this.BuildingID;
				return parent;
			}
			set
			{
				if(value == null)
					return;

				this.BDBuildingPK = value.BDBuildingPK;
				this.Address1 = value.Address1;
				this.BuildingID = value.BuildingID;
			}
		}

		#endregion

		#region Children
		public new virtual ACAccessLevelDetailCollection ACAccessLevelDetailList
		{
			get
			{
				return ((ACAccessLevelDetailCollection)(base.ACAccessLevelDetailList));
			}
			set
			{
				base.ACAccessLevelDetailList = value;
			}
		}

		public new virtual ACTimecodeIntervalMapCollection ACTimecodeIntervalMapList
		{
			get
			{
				return ((ACTimecodeIntervalMapCollection)(base.ACTimecodeIntervalMapList));
			}
			set
			{
				base.ACTimecodeIntervalMapList = value;
			}
		}

		#endregion

		protected override void CloneChildren(BusinessBase entity)
		{
			ACTimecodeData data = entity as ACTimecodeData;
			if (data == null)
				return;

			if (data.ACAccessLevelDetailList != null)
			{
				this.ACAccessLevelDetailList = new ACAccessLevelDetailCollection(data.ACAccessLevelDetailList);
			}
			if (data.ACTimecodeIntervalMapList != null)
			{
				this.ACTimecodeIntervalMapList = new ACTimecodeIntervalMapCollection(data.ACTimecodeIntervalMapList);
			}
		}

		public virtual Cheke.BusinessEntity.Result Save(SecurityToken token)
		{
			if (!this.IsDirty)
			{
				return new Result(true);
			}

			ACTimecodeData item = new ACTimecodeData(this);
			item.GetChanges();
			return ACTimecodeWrapper.Save(item, token);
		}

		public virtual Cheke.BusinessEntity.Result Save()
		{
			return this.Save(Cheke.Identity.Token);
		}

	}
	[Serializable]
	public partial class ACTimecodeIntervalMap :  ACTimecodeIntervalMapData, Cheke.BusinessEntity.IPersist
	{
		#region Constructors
		public ACTimecodeIntervalMap()
		{
		}

		public ACTimecodeIntervalMap(ACTimecodeIntervalMapData data)
			:base(data)
		{
		}
		#endregion

		#region Parents
		public virtual ACInterval ACInterval
		{
			get
			{
				ACInterval parent = new ACInterval();
				parent.ACIntervalPK = this.ACIntervalPK;
				parent.End = this.End;
				parent.Begin = this.Begin;
				parent.IVID = this.IVID;
				return parent;
			}
			set
			{
				if(value == null)
					return;

				this.ACIntervalPK = value.ACIntervalPK;
				this.End = value.End;
				this.Begin = value.Begin;
				this.IVID = value.IVID;
			}
		}

		public virtual ACTimecode ACTimecode
		{
			get
			{
				ACTimecode parent = new ACTimecode();
				parent.ACTimecodePK = this.ACTimecodePK;
				parent.TCID = this.TCID;
				parent.BDBuildingPK = this.BDBuildingPK;
				return parent;
			}
			set
			{
				if(value == null)
					return;

				this.ACTimecodePK = value.ACTimecodePK;
				this.TCID = value.TCID;
				this.BDBuildingPK = value.BDBuildingPK;
			}
		}

		public virtual BDBuilding BDBuilding
		{
			get
			{
				BDBuilding parent = new BDBuilding();
				parent.BDBuildingPK = this.BDBuildingPK;
				parent.Address1 = this.Address1;
				parent.BuildingID = this.BuildingID;
				return parent;
			}
			set
			{
				if(value == null)
					return;

				this.BDBuildingPK = value.BDBuildingPK;
				this.Address1 = value.Address1;
				this.BuildingID = value.BuildingID;
			}
		}

		#endregion

		#region Children
		#endregion

		public virtual Cheke.BusinessEntity.Result Save(SecurityToken token)
		{
			if (!this.IsDirty)
			{
				return new Result(true);
			}

			ACTimecodeIntervalMapData item = new ACTimecodeIntervalMapData(this);
			item.GetChanges();
			return ACTimecodeIntervalMapWrapper.Save(item, token);
		}

		public virtual Cheke.BusinessEntity.Result Save()
		{
			return this.Save(Cheke.Identity.Token);
		}

	}
	[Serializable]
	public partial class ACAMFormat :  ACAMFormatData, Cheke.BusinessEntity.IPersist
	{
		#region Constructors
		public ACAMFormat()
		{
		}

		public ACAMFormat(ACAMFormatData data)
			:base(data)
		{
		}
		#endregion

		#region Parents
		public virtual BDBuilding BDBuilding
		{
			get
			{
				BDBuilding parent = new BDBuilding();
				parent.BDBuildingPK = this.BDBuildingPK;
				parent.Address1 = this.Address1;
				parent.BuildingID = this.BuildingID;
				return parent;
			}
			set
			{
				if(value == null)
					return;

				this.BDBuildingPK = value.BDBuildingPK;
				this.Address1 = value.Address1;
				this.BuildingID = value.BuildingID;
			}
		}

		#endregion

		#region Children
		#endregion

		public virtual Cheke.BusinessEntity.Result Save(SecurityToken token)
		{
			if (!this.IsDirty)
			{
				return new Result(true);
			}

			ACAMFormatData item = new ACAMFormatData(this);
			item.GetChanges();
			return ACAMFormatWrapper.Save(item, token);
		}

		public virtual Cheke.BusinessEntity.Result Save()
		{
			return this.Save(Cheke.Identity.Token);
		}

	}
	[Serializable]
	public partial class BDBuildingHolidayMap :  BDBuildingHolidayMapData, Cheke.BusinessEntity.IPersist
	{
		#region Constructors
		public BDBuildingHolidayMap()
		{
		}

		public BDBuildingHolidayMap(BDBuildingHolidayMapData data)
			:base(data)
		{
		}
		#endregion

		#region Parents
		public virtual BDBuilding BDBuilding
		{
			get
			{
				BDBuilding parent = new BDBuilding();
				parent.BDBuildingPK = this.BDBuildingPK;
				parent.Address1 = this.Address1;
				parent.BuildingID = this.BuildingID;
				return parent;
			}
			set
			{
				if(value == null)
					return;

				this.BDBuildingPK = value.BDBuildingPK;
				this.Address1 = value.Address1;
				this.BuildingID = value.BuildingID;
			}
		}

		public virtual UtilHoliday UtilHoliday
		{
			get
			{
				UtilHoliday parent = new UtilHoliday();
				parent.UtilHolidayPK = this.UtilHolidayPK;
				parent.Date = this.Date;
				parent.Holiday = this.Holiday;
				return parent;
			}
			set
			{
				if(value == null)
					return;

				this.UtilHolidayPK = value.UtilHolidayPK;
				this.Date = value.Date;
				this.Holiday = value.Holiday;
			}
		}

		#endregion

		#region Children
		#endregion

		public virtual Cheke.BusinessEntity.Result Save(SecurityToken token)
		{
			if (!this.IsDirty)
			{
				return new Result(true);
			}

			BDBuildingHolidayMapData item = new BDBuildingHolidayMapData(this);
			item.GetChanges();
			return BDBuildingHolidayMapWrapper.Save(item, token);
		}

		public virtual Cheke.BusinessEntity.Result Save()
		{
			return this.Save(Cheke.Identity.Token);
		}

	}
	[Serializable]
	public partial class ACOutputGroup :  ACOutputGroupData, Cheke.BusinessEntity.IPersist
	{
		#region Constructors
		public ACOutputGroup()
		{
		}

		public ACOutputGroup(ACOutputGroupData data)
			:base(data)
		{
		}
		#endregion

		#region Parents
		public virtual ACPanel ACPanel
		{
			get
			{
				ACPanel parent = new ACPanel();
				parent.ACPanelPK = this.ACPanelPK;
				parent.BDBuildingPK = this.BDBuildingPK;
				parent.UnitID = this.UnitID;
				return parent;
			}
			set
			{
				if(value == null)
					return;

				this.ACPanelPK = value.ACPanelPK;
				this.BDBuildingPK = value.BDBuildingPK;
				this.UnitID = value.UnitID;
			}
		}

		public virtual BDBuilding BDBuilding
		{
			get
			{
				BDBuilding parent = new BDBuilding();
				parent.BDBuildingPK = this.BDBuildingPK;
				parent.Address1 = this.Address1;
				parent.BuildingID = this.BuildingID;
				return parent;
			}
			set
			{
				if(value == null)
					return;

				this.BDBuildingPK = value.BDBuildingPK;
				this.Address1 = value.Address1;
				this.BuildingID = value.BuildingID;
			}
		}

		#endregion

		#region Children
		public new virtual ACOutputGroupMainZoneMapCollection ACOutputGroupMainZoneMapList
		{
			get
			{
				return ((ACOutputGroupMainZoneMapCollection)(base.ACOutputGroupMainZoneMapList));
			}
			set
			{
				base.ACOutputGroupMainZoneMapList = value;
			}
		}

		#endregion

		protected override void CloneChildren(BusinessBase entity)
		{
			ACOutputGroupData data = entity as ACOutputGroupData;
			if (data == null)
				return;

			if (data.ACOutputGroupMainZoneMapList != null)
			{
				this.ACOutputGroupMainZoneMapList = new ACOutputGroupMainZoneMapCollection(data.ACOutputGroupMainZoneMapList);
			}
		}

		public virtual Cheke.BusinessEntity.Result Save(SecurityToken token)
		{
			if (!this.IsDirty)
			{
				return new Result(true);
			}

			ACOutputGroupData item = new ACOutputGroupData(this);
			item.GetChanges();
			return ACOutputGroupWrapper.Save(item, token);
		}

		public virtual Cheke.BusinessEntity.Result Save()
		{
			return this.Save(Cheke.Identity.Token);
		}

	}
	[Serializable]
	public partial class BDTenantHolidayMap :  BDTenantHolidayMapData, Cheke.BusinessEntity.IPersist
	{
		#region Constructors
		public BDTenantHolidayMap()
		{
		}

		public BDTenantHolidayMap(BDTenantHolidayMapData data)
			:base(data)
		{
		}
		#endregion

		#region Parents
		public virtual BDBuilding BDBuilding
		{
			get
			{
				BDBuilding parent = new BDBuilding();
				parent.BDBuildingPK = this.BDBuildingPK;
				parent.Address1 = this.Address1;
				parent.BuildingID = this.BuildingID;
				return parent;
			}
			set
			{
				if(value == null)
					return;

				this.BDBuildingPK = value.BDBuildingPK;
				this.Address1 = value.Address1;
				this.BuildingID = value.BuildingID;
			}
		}

		public virtual BDTenant BDTenant
		{
			get
			{
				BDTenant parent = new BDTenant();
				parent.BDTenantPK = this.BDTenantPK;
				parent.Tenant = this.Tenant;
				parent.BDBuildingPK = this.BDBuildingPK;
				return parent;
			}
			set
			{
				if(value == null)
					return;

				this.BDTenantPK = value.BDTenantPK;
				this.Tenant = value.Tenant;
				this.BDBuildingPK = value.BDBuildingPK;
			}
		}

		public virtual UtilHoliday UtilHoliday
		{
			get
			{
				UtilHoliday parent = new UtilHoliday();
				parent.UtilHolidayPK = this.UtilHolidayPK;
				parent.Date = this.Date;
				parent.Holiday = this.Holiday;
				return parent;
			}
			set
			{
				if(value == null)
					return;

				this.UtilHolidayPK = value.UtilHolidayPK;
				this.Date = value.Date;
				this.Holiday = value.Holiday;
			}
		}

		#endregion

		#region Children
		#endregion

		public virtual Cheke.BusinessEntity.Result Save(SecurityToken token)
		{
			if (!this.IsDirty)
			{
				return new Result(true);
			}

			BDTenantHolidayMapData item = new BDTenantHolidayMapData(this);
			item.GetChanges();
			return BDTenantHolidayMapWrapper.Save(item, token);
		}

		public virtual Cheke.BusinessEntity.Result Save()
		{
			return this.Save(Cheke.Identity.Token);
		}

	}
	[Serializable]
	public partial class LogRowsCount :  LogRowsCountData, Cheke.BusinessEntity.IPersist
	{
		#region Constructors
		public LogRowsCount()
		{
		}

		public LogRowsCount(LogRowsCountData data)
			:base(data)
		{
		}
		#endregion

		#region Parents
		#endregion

		#region Children
		#endregion

		public virtual Cheke.BusinessEntity.Result Save(SecurityToken token)
		{
			if (!this.IsDirty)
			{
				return new Result(true);
			}

			LogRowsCountData item = new LogRowsCountData(this);
			item.GetChanges();
			return LogRowsCountWrapper.Save(item, token);
		}

		public virtual Cheke.BusinessEntity.Result Save()
		{
			return this.Save(Cheke.Identity.Token);
		}

	}
	[Serializable]
	public partial class ACInputGroup :  ACInputGroupData, Cheke.BusinessEntity.IPersist
	{
		#region Constructors
		public ACInputGroup()
		{
		}

		public ACInputGroup(ACInputGroupData data)
			:base(data)
		{
		}
		#endregion

		#region Parents
		public virtual ACPanel ACPanel
		{
			get
			{
				ACPanel parent = new ACPanel();
				parent.ACPanelPK = this.ACPanelPK;
				parent.BDBuildingPK = this.BDBuildingPK;
				parent.UnitID = this.UnitID;
				return parent;
			}
			set
			{
				if(value == null)
					return;

				this.ACPanelPK = value.ACPanelPK;
				this.BDBuildingPK = value.BDBuildingPK;
				this.UnitID = value.UnitID;
			}
		}

		public virtual BDBuilding BDBuilding
		{
			get
			{
				BDBuilding parent = new BDBuilding();
				parent.BDBuildingPK = this.BDBuildingPK;
				parent.Address1 = this.Address1;
				parent.BuildingID = this.BuildingID;
				return parent;
			}
			set
			{
				if(value == null)
					return;

				this.BDBuildingPK = value.BDBuildingPK;
				this.Address1 = value.Address1;
				this.BuildingID = value.BuildingID;
			}
		}

		#endregion

		#region Children
		public new virtual ACInputGroupInputMapCollection ACInputGroupInputMapList
		{
			get
			{
				return ((ACInputGroupInputMapCollection)(base.ACInputGroupInputMapList));
			}
			set
			{
				base.ACInputGroupInputMapList = value;
			}
		}

		#endregion

		protected override void CloneChildren(BusinessBase entity)
		{
			ACInputGroupData data = entity as ACInputGroupData;
			if (data == null)
				return;

			if (data.ACInputGroupInputMapList != null)
			{
				this.ACInputGroupInputMapList = new ACInputGroupInputMapCollection(data.ACInputGroupInputMapList);
			}
		}

		public virtual Cheke.BusinessEntity.Result Save(SecurityToken token)
		{
			if (!this.IsDirty)
			{
				return new Result(true);
			}

			ACInputGroupData item = new ACInputGroupData(this);
			item.GetChanges();
			return ACInputGroupWrapper.Save(item, token);
		}

		public virtual Cheke.BusinessEntity.Result Save()
		{
			return this.Save(Cheke.Identity.Token);
		}

	}
	[Serializable]
	public partial class ACInput :  ACInputData, Cheke.BusinessEntity.IPersist
	{
		#region Constructors
		public ACInput()
		{
		}

		public ACInput(ACInputData data)
			:base(data)
		{
		}
		#endregion

		#region Parents
		public virtual ACPanel ACPanel
		{
			get
			{
				ACPanel parent = new ACPanel();
				parent.ACPanelPK = this.ACPanelPK;
				parent.BDBuildingPK = this.BDBuildingPK;
				parent.UnitID = this.UnitID;
				return parent;
			}
			set
			{
				if(value == null)
					return;

				this.ACPanelPK = value.ACPanelPK;
				this.BDBuildingPK = value.BDBuildingPK;
				this.UnitID = value.UnitID;
			}
		}

		public virtual BDBuilding BDBuilding
		{
			get
			{
				BDBuilding parent = new BDBuilding();
				parent.BDBuildingPK = this.BDBuildingPK;
				parent.Address1 = this.Address1;
				parent.BuildingID = this.BuildingID;
				return parent;
			}
			set
			{
				if(value == null)
					return;

				this.BDBuildingPK = value.BDBuildingPK;
				this.Address1 = value.Address1;
				this.BuildingID = value.BuildingID;
			}
		}

		#endregion

		#region Children
		public new virtual ACInputGroupInputMapCollection ACInputGroupInputMapList
		{
			get
			{
				return ((ACInputGroupInputMapCollection)(base.ACInputGroupInputMapList));
			}
			set
			{
				base.ACInputGroupInputMapList = value;
			}
		}

		#endregion

		protected override void CloneChildren(BusinessBase entity)
		{
			ACInputData data = entity as ACInputData;
			if (data == null)
				return;

			if (data.ACInputGroupInputMapList != null)
			{
				this.ACInputGroupInputMapList = new ACInputGroupInputMapCollection(data.ACInputGroupInputMapList);
			}
		}

		public virtual Cheke.BusinessEntity.Result Save(SecurityToken token)
		{
			if (!this.IsDirty)
			{
				return new Result(true);
			}

			ACInputData item = new ACInputData(this);
			item.GetChanges();
			return ACInputWrapper.Save(item, token);
		}

		public virtual Cheke.BusinessEntity.Result Save()
		{
			return this.Save(Cheke.Identity.Token);
		}

	}
	[Serializable]
	public partial class ACFunctionCard :  ACFunctionCardData, Cheke.BusinessEntity.IPersist
	{
		#region Constructors
		public ACFunctionCard()
		{
		}

		public ACFunctionCard(ACFunctionCardData data)
			:base(data)
		{
		}
		#endregion

		#region Parents
		public virtual BDBuilding BDBuilding
		{
			get
			{
				BDBuilding parent = new BDBuilding();
				parent.BDBuildingPK = this.BDBuildingPK;
				parent.Address1 = this.Address1;
				parent.BuildingID = this.BuildingID;
				return parent;
			}
			set
			{
				if(value == null)
					return;

				this.BDBuildingPK = value.BDBuildingPK;
				this.Address1 = value.Address1;
				this.BuildingID = value.BuildingID;
			}
		}

		public virtual BDTenant BDTenant
		{
			get
			{
				BDTenant parent = new BDTenant();
				parent.BDTenantPK = this.BDTenantPK;
				parent.Suite = this.Suite;
				parent.Tenant = this.Tenant;
				parent.BDBuildingPK = this.BDBuildingPK;
				return parent;
			}
			set
			{
				if(value == null)
					return;

				this.BDTenantPK = value.BDTenantPK;
				this.Suite = value.Suite;
				this.Tenant = value.Tenant;
				this.BDBuildingPK = value.BDBuildingPK;
			}
		}

		#endregion

		#region Children
		public new virtual ACPanelFunctionCardMapCollection ACPanelFunctionCardMapList
		{
			get
			{
				return ((ACPanelFunctionCardMapCollection)(base.ACPanelFunctionCardMapList));
			}
			set
			{
				base.ACPanelFunctionCardMapList = value;
			}
		}

		#endregion

		protected override void CloneChildren(BusinessBase entity)
		{
			ACFunctionCardData data = entity as ACFunctionCardData;
			if (data == null)
				return;

			if (data.ACPanelFunctionCardMapList != null)
			{
				this.ACPanelFunctionCardMapList = new ACPanelFunctionCardMapCollection(data.ACPanelFunctionCardMapList);
			}
		}

		public virtual Cheke.BusinessEntity.Result Save(SecurityToken token)
		{
			if (!this.IsDirty)
			{
				return new Result(true);
			}

			ACFunctionCardData item = new ACFunctionCardData(this);
			item.GetChanges();
			return ACFunctionCardWrapper.Save(item, token);
		}

		public virtual Cheke.BusinessEntity.Result Save()
		{
			return this.Save(Cheke.Identity.Token);
		}

	}
	[Serializable]
	public partial class UtilHoliday :  UtilHolidayData, Cheke.BusinessEntity.IPersist
	{
		#region Constructors
		public UtilHoliday()
		{
		}

		public UtilHoliday(UtilHolidayData data)
			:base(data)
		{
		}
		#endregion

		#region Parents
		#endregion

		#region Children
		public new virtual BDTenantHolidayMapCollection BDTenantHolidayMapList
		{
			get
			{
				return ((BDTenantHolidayMapCollection)(base.BDTenantHolidayMapList));
			}
			set
			{
				base.BDTenantHolidayMapList = value;
			}
		}

		public new virtual BDBuildingHolidayMapCollection BDBuildingHolidayMapList
		{
			get
			{
				return ((BDBuildingHolidayMapCollection)(base.BDBuildingHolidayMapList));
			}
			set
			{
				base.BDBuildingHolidayMapList = value;
			}
		}

		public new virtual ACPanelHolidayMapCollection ACPanelHolidayMapList
		{
			get
			{
				return ((ACPanelHolidayMapCollection)(base.ACPanelHolidayMapList));
			}
			set
			{
				base.ACPanelHolidayMapList = value;
			}
		}

		public new virtual ACIntvalHolidayMapCollection ACIntvalHolidayMapList
		{
			get
			{
				return ((ACIntvalHolidayMapCollection)(base.ACIntvalHolidayMapList));
			}
			set
			{
				base.ACIntvalHolidayMapList = value;
			}
		}

		#endregion

		protected override void CloneChildren(BusinessBase entity)
		{
			UtilHolidayData data = entity as UtilHolidayData;
			if (data == null)
				return;

			if (data.BDTenantHolidayMapList != null)
			{
				this.BDTenantHolidayMapList = new BDTenantHolidayMapCollection(data.BDTenantHolidayMapList);
			}
			if (data.BDBuildingHolidayMapList != null)
			{
				this.BDBuildingHolidayMapList = new BDBuildingHolidayMapCollection(data.BDBuildingHolidayMapList);
			}
			if (data.ACPanelHolidayMapList != null)
			{
				this.ACPanelHolidayMapList = new ACPanelHolidayMapCollection(data.ACPanelHolidayMapList);
			}
			if (data.ACIntvalHolidayMapList != null)
			{
				this.ACIntvalHolidayMapList = new ACIntvalHolidayMapCollection(data.ACIntvalHolidayMapList);
			}
		}

		public virtual Cheke.BusinessEntity.Result Save(SecurityToken token)
		{
			if (!this.IsDirty)
			{
				return new Result(true);
			}

			UtilHolidayData item = new UtilHolidayData(this);
			item.GetChanges();
			return UtilHolidayWrapper.Save(item, token);
		}

		public virtual Cheke.BusinessEntity.Result Save()
		{
			return this.Save(Cheke.Identity.Token);
		}

	}
	[Serializable]
	public partial class ACAccessLevel :  ACAccessLevelData, Cheke.BusinessEntity.IPersist
	{
		#region Constructors
		public ACAccessLevel()
		{
		}

		public ACAccessLevel(ACAccessLevelData data)
			:base(data)
		{
		}
		#endregion

		#region Parents
		public virtual BDBuilding BDBuilding
		{
			get
			{
				BDBuilding parent = new BDBuilding();
				parent.BDBuildingPK = this.BDBuildingPK;
				parent.Address1 = this.Address1;
				parent.BuildingID = this.BuildingID;
				return parent;
			}
			set
			{
				if(value == null)
					return;

				this.BDBuildingPK = value.BDBuildingPK;
				this.Address1 = value.Address1;
				this.BuildingID = value.BuildingID;
			}
		}

		#endregion

		#region Children
		public new virtual ACAccessLevelDetailCollection ACAccessLevelDetailList
		{
			get
			{
				return ((ACAccessLevelDetailCollection)(base.ACAccessLevelDetailList));
			}
			set
			{
				base.ACAccessLevelDetailList = value;
			}
		}

		#endregion

		protected override void CloneChildren(BusinessBase entity)
		{
			ACAccessLevelData data = entity as ACAccessLevelData;
			if (data == null)
				return;

			if (data.ACAccessLevelDetailList != null)
			{
				this.ACAccessLevelDetailList = new ACAccessLevelDetailCollection(data.ACAccessLevelDetailList);
			}
		}

		public virtual Cheke.BusinessEntity.Result Save(SecurityToken token)
		{
			if (!this.IsDirty)
			{
				return new Result(true);
			}

			ACAccessLevelData item = new ACAccessLevelData(this);
			item.GetChanges();
			return ACAccessLevelWrapper.Save(item, token);
		}

		public virtual Cheke.BusinessEntity.Result Save()
		{
			return this.Save(Cheke.Identity.Token);
		}

	}
	[Serializable]
	public partial class ACPanelFunctionCardMap :  ACPanelFunctionCardMapData, Cheke.BusinessEntity.IPersist
	{
		#region Constructors
		public ACPanelFunctionCardMap()
		{
		}

		public ACPanelFunctionCardMap(ACPanelFunctionCardMapData data)
			:base(data)
		{
		}
		#endregion

		#region Parents
		public virtual ACFunctionCard ACFunctionCard
		{
			get
			{
				ACFunctionCard parent = new ACFunctionCard();
				parent.ACFunctionCardPK = this.ACFunctionCardPK;
				parent.CardTypeID = this.CardTypeID;
				parent.Encoded = this.Encoded;
				parent.Embossed = this.Embossed;
				parent.Sitecode = this.Sitecode;
				return parent;
			}
			set
			{
				if(value == null)
					return;

				this.ACFunctionCardPK = value.ACFunctionCardPK;
				this.CardTypeID = value.CardTypeID;
				this.Encoded = value.Encoded;
				this.Embossed = value.Embossed;
				this.Sitecode = value.Sitecode;
			}
		}

		public virtual ACPanel ACPanel
		{
			get
			{
				ACPanel parent = new ACPanel();
				parent.ACPanelPK = this.ACPanelPK;
				parent.BDBuildingPK = this.BDBuildingPK;
				parent.UnitID = this.UnitID;
				return parent;
			}
			set
			{
				if(value == null)
					return;

				this.ACPanelPK = value.ACPanelPK;
				this.BDBuildingPK = value.BDBuildingPK;
				this.UnitID = value.UnitID;
			}
		}

		public virtual BDBuilding BDBuilding
		{
			get
			{
				BDBuilding parent = new BDBuilding();
				parent.BDBuildingPK = this.BDBuildingPK;
				parent.Address1 = this.Address1;
				parent.BuildingID = this.BuildingID;
				return parent;
			}
			set
			{
				if(value == null)
					return;

				this.BDBuildingPK = value.BDBuildingPK;
				this.Address1 = value.Address1;
				this.BuildingID = value.BuildingID;
			}
		}

		#endregion

		#region Children
		#endregion

		public virtual Cheke.BusinessEntity.Result Save(SecurityToken token)
		{
			if (!this.IsDirty)
			{
				return new Result(true);
			}

			ACPanelFunctionCardMapData item = new ACPanelFunctionCardMapData(this);
			item.GetChanges();
			return ACPanelFunctionCardMapWrapper.Save(item, token);
		}

		public virtual Cheke.BusinessEntity.Result Save()
		{
			return this.Save(Cheke.Identity.Token);
		}

	}
	[Serializable]
	public partial class LogDBDeleteActivity :  LogDBDeleteActivityData, Cheke.BusinessEntity.IPersist
	{
		#region Constructors
		public LogDBDeleteActivity()
		{
		}

		public LogDBDeleteActivity(LogDBDeleteActivityData data)
			:base(data)
		{
		}
		#endregion

		#region Parents
		#endregion

		#region Children
		#endregion

		public virtual Cheke.BusinessEntity.Result Save(SecurityToken token)
		{
			if (!this.IsDirty)
			{
				return new Result(true);
			}

			LogDBDeleteActivityData item = new LogDBDeleteActivityData(this);
			item.GetChanges();
			return LogDBDeleteActivityWrapper.Save(item, token);
		}

		public virtual Cheke.BusinessEntity.Result Save()
		{
			return this.Save(Cheke.Identity.Token);
		}

	}
	[Serializable]
	public partial class UsrAccount :  UsrAccountData, Cheke.BusinessEntity.IPersist
	{
		#region Constructors
		public UsrAccount()
		{
		}

		public UsrAccount(UsrAccountData data)
			:base(data)
		{
		}
		#endregion

		#region Parents
		public virtual BDBuilding BDBuilding
		{
			get
			{
				BDBuilding parent = new BDBuilding();
				parent.BDBuildingPK = this.BDBuildingPK;
				parent.Address1 = this.Address1;
				parent.BuildingID = this.BuildingID;
				return parent;
			}
			set
			{
				if(value == null)
					return;

				this.BDBuildingPK = value.BDBuildingPK;
				this.Address1 = value.Address1;
				this.BuildingID = value.BuildingID;
			}
		}

		public virtual BDTenant BDTenant
		{
			get
			{
				BDTenant parent = new BDTenant();
				parent.BDTenantPK = this.BDTenantPK;
				parent.Suite = this.Suite;
				parent.Tenant = this.Tenant;
				parent.BDBuildingPK = this.BDBuildingPK;
				return parent;
			}
			set
			{
				if(value == null)
					return;

				this.BDTenantPK = value.BDTenantPK;
				this.Suite = value.Suite;
				this.Tenant = value.Tenant;
				this.BDBuildingPK = value.BDBuildingPK;
			}
		}

		public virtual UsrGroup UsrGroup
		{
			get
			{
				UsrGroup parent = new UsrGroup();
				parent.UsrGroupPK = this.UsrGroupPK;
				parent.UsrGroupName = this.UsrGroupName;
				return parent;
			}
			set
			{
				if(value == null)
					return;

				this.UsrGroupPK = value.UsrGroupPK;
				this.UsrGroupName = value.UsrGroupName;
			}
		}

		#endregion

		#region Children
		public new virtual UsrAccountBuildingMapCollection UsrAccountBuildingMapList
		{
			get
			{
				return ((UsrAccountBuildingMapCollection)(base.UsrAccountBuildingMapList));
			}
			set
			{
				base.UsrAccountBuildingMapList = value;
			}
		}

		public new virtual UsrAccountBRRuleCollection UsrAccountBRRuleList
		{
			get
			{
				return ((UsrAccountBRRuleCollection)(base.UsrAccountBRRuleList));
			}
			set
			{
				base.UsrAccountBRRuleList = value;
			}
		}

		public new virtual UsrAccountDBRuleCollection UsrAccountDBRuleList
		{
			get
			{
				return ((UsrAccountDBRuleCollection)(base.UsrAccountDBRuleList));
			}
			set
			{
				base.UsrAccountDBRuleList = value;
			}
		}

		public new virtual UsrAccountTenantMapCollection UsrAccountTenantMapList
		{
			get
			{
				return ((UsrAccountTenantMapCollection)(base.UsrAccountTenantMapList));
			}
			set
			{
				base.UsrAccountTenantMapList = value;
			}
		}

		#endregion

		protected override void CloneChildren(BusinessBase entity)
		{
			UsrAccountData data = entity as UsrAccountData;
			if (data == null)
				return;

			if (data.UsrAccountBuildingMapList != null)
			{
				this.UsrAccountBuildingMapList = new UsrAccountBuildingMapCollection(data.UsrAccountBuildingMapList);
			}
			if (data.UsrAccountBRRuleList != null)
			{
				this.UsrAccountBRRuleList = new UsrAccountBRRuleCollection(data.UsrAccountBRRuleList);
			}
			if (data.UsrAccountDBRuleList != null)
			{
				this.UsrAccountDBRuleList = new UsrAccountDBRuleCollection(data.UsrAccountDBRuleList);
			}
			if (data.UsrAccountTenantMapList != null)
			{
				this.UsrAccountTenantMapList = new UsrAccountTenantMapCollection(data.UsrAccountTenantMapList);
			}
		}

		public virtual Cheke.BusinessEntity.Result Save(SecurityToken token)
		{
			if (!this.IsDirty)
			{
				return new Result(true);
			}

			UsrAccountData item = new UsrAccountData(this);
			item.GetChanges();
			return UsrAccountWrapper.Save(item, token);
		}

		public virtual Cheke.BusinessEntity.Result Save()
		{
			return this.Save(Cheke.Identity.Token);
		}

	}
	[Serializable]
	public partial class LogDBEditActivity :  LogDBEditActivityData, Cheke.BusinessEntity.IPersist
	{
		#region Constructors
		public LogDBEditActivity()
		{
		}

		public LogDBEditActivity(LogDBEditActivityData data)
			:base(data)
		{
		}
		#endregion

		#region Parents
		#endregion

		#region Children
		#endregion

		public virtual Cheke.BusinessEntity.Result Save(SecurityToken token)
		{
			if (!this.IsDirty)
			{
				return new Result(true);
			}

			LogDBEditActivityData item = new LogDBEditActivityData(this);
			item.GetChanges();
			return LogDBEditActivityWrapper.Save(item, token);
		}

		public virtual Cheke.BusinessEntity.Result Save()
		{
			return this.Save(Cheke.Identity.Token);
		}

	}
	[Serializable]
	public partial class ACMasterCard :  ACMasterCardData, Cheke.BusinessEntity.IPersist
	{
		#region Constructors
		public ACMasterCard()
		{
		}

		public ACMasterCard(ACMasterCardData data)
			:base(data)
		{
		}
		#endregion

		#region Parents
		#endregion

		#region Children
		#endregion

		public virtual Cheke.BusinessEntity.Result Save(SecurityToken token)
		{
			if (!this.IsDirty)
			{
				return new Result(true);
			}

			ACMasterCardData item = new ACMasterCardData(this);
			item.GetChanges();
			return ACMasterCardWrapper.Save(item, token);
		}

		public virtual Cheke.BusinessEntity.Result Save()
		{
			return this.Save(Cheke.Identity.Token);
		}

	}
	[Serializable]
	public partial class ACSupervisory :  ACSupervisoryData, Cheke.BusinessEntity.IPersist
	{
		#region Constructors
		public ACSupervisory()
		{
		}

		public ACSupervisory(ACSupervisoryData data)
			:base(data)
		{
		}
		#endregion

		#region Parents
		public virtual ACPanel ACPanel
		{
			get
			{
				ACPanel parent = new ACPanel();
				parent.ACPanelPK = this.ACPanelPK;
				parent.BDBuildingPK = this.BDBuildingPK;
				parent.UnitID = this.UnitID;
				return parent;
			}
			set
			{
				if(value == null)
					return;

				this.ACPanelPK = value.ACPanelPK;
				this.BDBuildingPK = value.BDBuildingPK;
				this.UnitID = value.UnitID;
			}
		}

		public virtual BDBuilding BDBuilding
		{
			get
			{
				BDBuilding parent = new BDBuilding();
				parent.BDBuildingPK = this.BDBuildingPK;
				parent.Address1 = this.Address1;
				parent.BuildingID = this.BuildingID;
				return parent;
			}
			set
			{
				if(value == null)
					return;

				this.BDBuildingPK = value.BDBuildingPK;
				this.Address1 = value.Address1;
				this.BuildingID = value.BuildingID;
			}
		}

		#endregion

		#region Children
		#endregion

		public virtual Cheke.BusinessEntity.Result Save(SecurityToken token)
		{
			if (!this.IsDirty)
			{
				return new Result(true);
			}

			ACSupervisoryData item = new ACSupervisoryData(this);
			item.GetChanges();
			return ACSupervisoryWrapper.Save(item, token);
		}

		public virtual Cheke.BusinessEntity.Result Save()
		{
			return this.Save(Cheke.Identity.Token);
		}

	}
	[Serializable]
	public partial class UsrGroup :  UsrGroupData, Cheke.BusinessEntity.IPersist
	{
		#region Constructors
		public UsrGroup()
		{
		}

		public UsrGroup(UsrGroupData data)
			:base(data)
		{
		}
		#endregion

		#region Parents
		#endregion

		#region Children
		public new virtual UsrGroupDBRuleCollection UsrGroupDBRuleList
		{
			get
			{
				return ((UsrGroupDBRuleCollection)(base.UsrGroupDBRuleList));
			}
			set
			{
				base.UsrGroupDBRuleList = value;
			}
		}

		public new virtual UsrGroupBRRuleCollection UsrGroupBRRuleList
		{
			get
			{
				return ((UsrGroupBRRuleCollection)(base.UsrGroupBRRuleList));
			}
			set
			{
				base.UsrGroupBRRuleList = value;
			}
		}

		public new virtual UsrAccountCollection UsrAccountList
		{
			get
			{
				return ((UsrAccountCollection)(base.UsrAccountList));
			}
			set
			{
				base.UsrAccountList = value;
			}
		}

		#endregion

		protected override void CloneChildren(BusinessBase entity)
		{
			UsrGroupData data = entity as UsrGroupData;
			if (data == null)
				return;

			if (data.UsrGroupDBRuleList != null)
			{
				this.UsrGroupDBRuleList = new UsrGroupDBRuleCollection(data.UsrGroupDBRuleList);
			}
			if (data.UsrGroupBRRuleList != null)
			{
				this.UsrGroupBRRuleList = new UsrGroupBRRuleCollection(data.UsrGroupBRRuleList);
			}
			if (data.UsrAccountList != null)
			{
				this.UsrAccountList = new UsrAccountCollection(data.UsrAccountList);
			}
		}

		public virtual Cheke.BusinessEntity.Result Save(SecurityToken token)
		{
			if (!this.IsDirty)
			{
				return new Result(true);
			}

			UsrGroupData item = new UsrGroupData(this);
			item.GetChanges();
			return UsrGroupWrapper.Save(item, token);
		}

		public virtual Cheke.BusinessEntity.Result Save()
		{
			return this.Save(Cheke.Identity.Token);
		}

	}
	[Serializable]
	public partial class ACCardHolderBuildingMap :  ACCardHolderBuildingMapData, Cheke.BusinessEntity.IPersist
	{
		#region Constructors
		public ACCardHolderBuildingMap()
		{
		}

		public ACCardHolderBuildingMap(ACCardHolderBuildingMapData data)
			:base(data)
		{
		}
		#endregion

		#region Parents
		public virtual ACCardHolder ACCardHolder
		{
			get
			{
				ACCardHolder parent = new ACCardHolder();
				parent.ACCardHolderPK = this.ACCardHolderPK;
				parent.LastName = this.LastName;
				parent.FirstName = this.FirstName;
				parent.CardTypeID = this.CardTypeID;
				parent.Encoded = this.Encoded;
				parent.Embossed = this.Embossed;
				parent.Sitecode = this.Sitecode;
				return parent;
			}
			set
			{
				if(value == null)
					return;

				this.ACCardHolderPK = value.ACCardHolderPK;
				this.LastName = value.LastName;
				this.FirstName = value.FirstName;
				this.CardTypeID = value.CardTypeID;
				this.Encoded = value.Encoded;
				this.Embossed = value.Embossed;
				this.Sitecode = value.Sitecode;
			}
		}

		public virtual BDBuilding BDBuilding
		{
			get
			{
				BDBuilding parent = new BDBuilding();
				parent.BDBuildingPK = this.BDBuildingPK;
				parent.Address1 = this.Address1;
				parent.BuildingID = this.BuildingID;
				return parent;
			}
			set
			{
				if(value == null)
					return;

				this.BDBuildingPK = value.BDBuildingPK;
				this.Address1 = value.Address1;
				this.BuildingID = value.BuildingID;
			}
		}

		#endregion

		#region Children
		#endregion

		public virtual Cheke.BusinessEntity.Result Save(SecurityToken token)
		{
			if (!this.IsDirty)
			{
				return new Result(true);
			}

			ACCardHolderBuildingMapData item = new ACCardHolderBuildingMapData(this);
			item.GetChanges();
			return ACCardHolderBuildingMapWrapper.Save(item, token);
		}

		public virtual Cheke.BusinessEntity.Result Save()
		{
			return this.Save(Cheke.Identity.Token);
		}

	}
	[Serializable]
	public partial class BDVisitor :  BDVisitorData, Cheke.BusinessEntity.IPersist
	{
		#region Constructors
		public BDVisitor()
		{
		}

		public BDVisitor(BDVisitorData data)
			:base(data)
		{
		}
		#endregion

		#region Parents
		public virtual BDBuilding BDBuilding
		{
			get
			{
				BDBuilding parent = new BDBuilding();
				parent.BDBuildingPK = this.BDBuildingPK;
				parent.Address1 = this.Address1;
				parent.BuildingID = this.BuildingID;
				return parent;
			}
			set
			{
				if(value == null)
					return;

				this.BDBuildingPK = value.BDBuildingPK;
				this.Address1 = value.Address1;
				this.BuildingID = value.BuildingID;
			}
		}

		public virtual BDTenant BDTenant
		{
			get
			{
				BDTenant parent = new BDTenant();
				parent.BDTenantPK = this.BDTenantPK;
				parent.Suite = this.Suite;
				parent.Tenant = this.Tenant;
				parent.BDBuildingPK = this.BDBuildingPK;
				return parent;
			}
			set
			{
				if(value == null)
					return;

				this.BDTenantPK = value.BDTenantPK;
				this.Suite = value.Suite;
				this.Tenant = value.Tenant;
				this.BDBuildingPK = value.BDBuildingPK;
			}
		}

		#endregion

		#region Children
		#endregion

		public virtual Cheke.BusinessEntity.Result Save(SecurityToken token)
		{
			if (!this.IsDirty)
			{
				return new Result(true);
			}

			BDVisitorData item = new BDVisitorData(this);
			item.GetChanges();
			return BDVisitorWrapper.Save(item, token);
		}

		public virtual Cheke.BusinessEntity.Result Save()
		{
			return this.Save(Cheke.Identity.Token);
		}

	}
	[Serializable]
	public partial class UsrGroupDBRule :  UsrGroupDBRuleData, Cheke.BusinessEntity.IPersist
	{
		#region Constructors
		public UsrGroupDBRule()
		{
		}

		public UsrGroupDBRule(UsrGroupDBRuleData data)
			:base(data)
		{
		}
		#endregion

		#region Parents
		public virtual UsrGroup UsrGroup
		{
			get
			{
				UsrGroup parent = new UsrGroup();
				parent.UsrGroupPK = this.UsrGroupPK;
				parent.UsrGroupName = this.UsrGroupName;
				return parent;
			}
			set
			{
				if(value == null)
					return;

				this.UsrGroupPK = value.UsrGroupPK;
				this.UsrGroupName = value.UsrGroupName;
			}
		}

		#endregion

		#region Children
		#endregion

		public virtual Cheke.BusinessEntity.Result Save(SecurityToken token)
		{
			if (!this.IsDirty)
			{
				return new Result(true);
			}

			UsrGroupDBRuleData item = new UsrGroupDBRuleData(this);
			item.GetChanges();
			return UsrGroupDBRuleWrapper.Save(item, token);
		}

		public virtual Cheke.BusinessEntity.Result Save()
		{
			return this.Save(Cheke.Identity.Token);
		}

	}
	[Serializable]
	public partial class ACPanel :  ACPanelData, Cheke.BusinessEntity.IPersist
	{
		#region Constructors
		public ACPanel()
		{
		}

		public ACPanel(ACPanelData data)
			:base(data)
		{
		}
		#endregion

		#region Parents
		public virtual BDBuilding BDBuilding
		{
			get
			{
				BDBuilding parent = new BDBuilding();
				parent.BDBuildingPK = this.BDBuildingPK;
				parent.Address1 = this.Address1;
				parent.BuildingID = this.BuildingID;
				return parent;
			}
			set
			{
				if(value == null)
					return;

				this.BDBuildingPK = value.BDBuildingPK;
				this.Address1 = value.Address1;
				this.BuildingID = value.BuildingID;
			}
		}

		#endregion

		#region Children
		public new virtual ACInputCollection ACInputList
		{
			get
			{
				return ((ACInputCollection)(base.ACInputList));
			}
			set
			{
				base.ACInputList = value;
			}
		}

		public new virtual ACSupervisoryCollection ACSupervisoryList
		{
			get
			{
				return ((ACSupervisoryCollection)(base.ACSupervisoryList));
			}
			set
			{
				base.ACSupervisoryList = value;
			}
		}

		public new virtual ACPanelHolidayMapCollection ACPanelHolidayMapList
		{
			get
			{
				return ((ACPanelHolidayMapCollection)(base.ACPanelHolidayMapList));
			}
			set
			{
				base.ACPanelHolidayMapList = value;
			}
		}

		public new virtual ACMainZoneCollection ACMainZoneList
		{
			get
			{
				return ((ACMainZoneCollection)(base.ACMainZoneList));
			}
			set
			{
				base.ACMainZoneList = value;
			}
		}

		public new virtual ACPanelFunctionCardMapCollection ACPanelFunctionCardMapList
		{
			get
			{
				return ((ACPanelFunctionCardMapCollection)(base.ACPanelFunctionCardMapList));
			}
			set
			{
				base.ACPanelFunctionCardMapList = value;
			}
		}

		public new virtual ACOutputGroupCollection ACOutputGroupList
		{
			get
			{
				return ((ACOutputGroupCollection)(base.ACOutputGroupList));
			}
			set
			{
				base.ACOutputGroupList = value;
			}
		}

		public new virtual ACInputGroupCollection ACInputGroupList
		{
			get
			{
				return ((ACInputGroupCollection)(base.ACInputGroupList));
			}
			set
			{
				base.ACInputGroupList = value;
			}
		}

		#endregion

		protected override void CloneChildren(BusinessBase entity)
		{
			ACPanelData data = entity as ACPanelData;
			if (data == null)
				return;

			if (data.ACInputList != null)
			{
				this.ACInputList = new ACInputCollection(data.ACInputList);
			}
			if (data.ACSupervisoryList != null)
			{
				this.ACSupervisoryList = new ACSupervisoryCollection(data.ACSupervisoryList);
			}
			if (data.ACPanelHolidayMapList != null)
			{
				this.ACPanelHolidayMapList = new ACPanelHolidayMapCollection(data.ACPanelHolidayMapList);
			}
			if (data.ACMainZoneList != null)
			{
				this.ACMainZoneList = new ACMainZoneCollection(data.ACMainZoneList);
			}
			if (data.ACPanelFunctionCardMapList != null)
			{
				this.ACPanelFunctionCardMapList = new ACPanelFunctionCardMapCollection(data.ACPanelFunctionCardMapList);
			}
			if (data.ACOutputGroupList != null)
			{
				this.ACOutputGroupList = new ACOutputGroupCollection(data.ACOutputGroupList);
			}
			if (data.ACInputGroupList != null)
			{
				this.ACInputGroupList = new ACInputGroupCollection(data.ACInputGroupList);
			}
		}

		public virtual Cheke.BusinessEntity.Result Save(SecurityToken token)
		{
			if (!this.IsDirty)
			{
				return new Result(true);
			}

			ACPanelData item = new ACPanelData(this);
			item.GetChanges();
			return ACPanelWrapper.Save(item, token);
		}

		public virtual Cheke.BusinessEntity.Result Save()
		{
			return this.Save(Cheke.Identity.Token);
		}

	}
	[Serializable]
	public partial class UsrAccountDBRule :  UsrAccountDBRuleData, Cheke.BusinessEntity.IPersist
	{
		#region Constructors
		public UsrAccountDBRule()
		{
		}

		public UsrAccountDBRule(UsrAccountDBRuleData data)
			:base(data)
		{
		}
		#endregion

		#region Parents
		public virtual UsrAccount UsrAccount
		{
			get
			{
				UsrAccount parent = new UsrAccount();
				parent.UsrAccountPK = this.UsrAccountPK;
				parent.UserID = this.UserID;
				return parent;
			}
			set
			{
				if(value == null)
					return;

				this.UsrAccountPK = value.UsrAccountPK;
				this.UserID = value.UserID;
			}
		}

		#endregion

		#region Children
		#endregion

		public virtual Cheke.BusinessEntity.Result Save(SecurityToken token)
		{
			if (!this.IsDirty)
			{
				return new Result(true);
			}

			UsrAccountDBRuleData item = new UsrAccountDBRuleData(this);
			item.GetChanges();
			return UsrAccountDBRuleWrapper.Save(item, token);
		}

		public virtual Cheke.BusinessEntity.Result Save()
		{
			return this.Save(Cheke.Identity.Token);
		}

	}
	[Serializable]
	public partial class UsrGroupBRRule :  UsrGroupBRRuleData, Cheke.BusinessEntity.IPersist
	{
		#region Constructors
		public UsrGroupBRRule()
		{
		}

		public UsrGroupBRRule(UsrGroupBRRuleData data)
			:base(data)
		{
		}
		#endregion

		#region Parents
		public virtual UsrGroup UsrGroup
		{
			get
			{
				UsrGroup parent = new UsrGroup();
				parent.UsrGroupPK = this.UsrGroupPK;
				parent.UsrGroupName = this.UsrGroupName;
				return parent;
			}
			set
			{
				if(value == null)
					return;

				this.UsrGroupPK = value.UsrGroupPK;
				this.UsrGroupName = value.UsrGroupName;
			}
		}

		#endregion

		#region Children
		#endregion

		public virtual Cheke.BusinessEntity.Result Save(SecurityToken token)
		{
			if (!this.IsDirty)
			{
				return new Result(true);
			}

			UsrGroupBRRuleData item = new UsrGroupBRRuleData(this);
			item.GetChanges();
			return UsrGroupBRRuleWrapper.Save(item, token);
		}

		public virtual Cheke.BusinessEntity.Result Save()
		{
			return this.Save(Cheke.Identity.Token);
		}

	}
	[Serializable]
	public partial class ACInputGroupInputMap :  ACInputGroupInputMapData, Cheke.BusinessEntity.IPersist
	{
		#region Constructors
		public ACInputGroupInputMap()
		{
		}

		public ACInputGroupInputMap(ACInputGroupInputMapData data)
			:base(data)
		{
		}
		#endregion

		#region Parents
		public virtual ACInput ACInput
		{
			get
			{
				ACInput parent = new ACInput();
				parent.ACInputPK = this.ACInputPK;
				parent.InputID = this.InputID;
				return parent;
			}
			set
			{
				if(value == null)
					return;

				this.ACInputPK = value.ACInputPK;
				this.InputID = value.InputID;
			}
		}

		public virtual ACInputGroup ACInputGroup
		{
			get
			{
				ACInputGroup parent = new ACInputGroup();
				parent.ACInputGroupPK = this.ACInputGroupPK;
				parent.GroupID = this.GroupID;
				parent.ACPanelPK = this.ACPanelPK;
				return parent;
			}
			set
			{
				if(value == null)
					return;

				this.ACInputGroupPK = value.ACInputGroupPK;
				this.GroupID = value.GroupID;
				this.ACPanelPK = value.ACPanelPK;
			}
		}

		public virtual ACPanel ACPanel
		{
			get
			{
				ACPanel parent = new ACPanel();
				parent.ACPanelPK = this.ACPanelPK;
				parent.UnitID = this.UnitID;
				return parent;
			}
			set
			{
				if(value == null)
					return;

				this.ACPanelPK = value.ACPanelPK;
				this.UnitID = value.UnitID;
			}
		}

		public virtual BDBuilding BDBuilding
		{
			get
			{
				BDBuilding parent = new BDBuilding();
				parent.BDBuildingPK = this.BDBuildingPK;
				parent.Address1 = this.Address1;
				parent.BuildingID = this.BuildingID;
				return parent;
			}
			set
			{
				if(value == null)
					return;

				this.BDBuildingPK = value.BDBuildingPK;
				this.Address1 = value.Address1;
				this.BuildingID = value.BuildingID;
			}
		}

		#endregion

		#region Children
		#endregion

		public virtual Cheke.BusinessEntity.Result Save(SecurityToken token)
		{
			if (!this.IsDirty)
			{
				return new Result(true);
			}

			ACInputGroupInputMapData item = new ACInputGroupInputMapData(this);
			item.GetChanges();
			return ACInputGroupInputMapWrapper.Save(item, token);
		}

		public virtual Cheke.BusinessEntity.Result Save()
		{
			return this.Save(Cheke.Identity.Token);
		}

	}
	[Serializable]
	public partial class UsrAccountBRRule :  UsrAccountBRRuleData, Cheke.BusinessEntity.IPersist
	{
		#region Constructors
		public UsrAccountBRRule()
		{
		}

		public UsrAccountBRRule(UsrAccountBRRuleData data)
			:base(data)
		{
		}
		#endregion

		#region Parents
		public virtual UsrAccount UsrAccount
		{
			get
			{
				UsrAccount parent = new UsrAccount();
				parent.UsrAccountPK = this.UsrAccountPK;
				parent.UserID = this.UserID;
				return parent;
			}
			set
			{
				if(value == null)
					return;

				this.UsrAccountPK = value.UsrAccountPK;
				this.UserID = value.UserID;
			}
		}

		#endregion

		#region Children
		#endregion

		public virtual Cheke.BusinessEntity.Result Save(SecurityToken token)
		{
			if (!this.IsDirty)
			{
				return new Result(true);
			}

			UsrAccountBRRuleData item = new UsrAccountBRRuleData(this);
			item.GetChanges();
			return UsrAccountBRRuleWrapper.Save(item, token);
		}

		public virtual Cheke.BusinessEntity.Result Save()
		{
			return this.Save(Cheke.Identity.Token);
		}

	}
	[Serializable]
	public partial class UsrAccountTenantMap :  UsrAccountTenantMapData, Cheke.BusinessEntity.IPersist
	{
		#region Constructors
		public UsrAccountTenantMap()
		{
		}

		public UsrAccountTenantMap(UsrAccountTenantMapData data)
			:base(data)
		{
		}
		#endregion

		#region Parents
		public virtual BDBuilding BDBuilding
		{
			get
			{
				BDBuilding parent = new BDBuilding();
				parent.BDBuildingPK = this.BDBuildingPK;
				parent.Address1 = this.Address1;
				parent.BuildingID = this.BuildingID;
				return parent;
			}
			set
			{
				if(value == null)
					return;

				this.BDBuildingPK = value.BDBuildingPK;
				this.Address1 = value.Address1;
				this.BuildingID = value.BuildingID;
			}
		}

		public virtual BDTenant BDTenant
		{
			get
			{
				BDTenant parent = new BDTenant();
				parent.BDTenantPK = this.BDTenantPK;
				parent.Tenant = this.Tenant;
				parent.BDBuildingPK = this.BDBuildingPK;
				return parent;
			}
			set
			{
				if(value == null)
					return;

				this.BDTenantPK = value.BDTenantPK;
				this.Tenant = value.Tenant;
				this.BDBuildingPK = value.BDBuildingPK;
			}
		}

		public virtual UsrAccount UsrAccount
		{
			get
			{
				UsrAccount parent = new UsrAccount();
				parent.UsrAccountPK = this.UsrAccountPK;
				parent.UserID = this.UserID;
				return parent;
			}
			set
			{
				if(value == null)
					return;

				this.UsrAccountPK = value.UsrAccountPK;
				this.UserID = value.UserID;
			}
		}

		#endregion

		#region Children
		#endregion

		public virtual Cheke.BusinessEntity.Result Save(SecurityToken token)
		{
			if (!this.IsDirty)
			{
				return new Result(true);
			}

			UsrAccountTenantMapData item = new UsrAccountTenantMapData(this);
			item.GetChanges();
			return UsrAccountTenantMapWrapper.Save(item, token);
		}

		public virtual Cheke.BusinessEntity.Result Save()
		{
			return this.Save(Cheke.Identity.Token);
		}

	}
	[Serializable]
	public class ACIntvalHolidayMapCollection : ACIntvalHolidayMapDataCollection, Cheke.BusinessEntity.IPersist
	{
		#region Constructors
		public ACIntvalHolidayMapCollection()
		{
			base._itemType = typeof(ACIntvalHolidayMap);
		}

		public ACIntvalHolidayMapCollection(ACIntvalHolidayMapDataCollection list)
		{
			base._itemType = typeof(ACIntvalHolidayMap);
			foreach(ACIntvalHolidayMapData item in list)
			{
				this.Add(new ACIntvalHolidayMap(item));
			}

			System.Collections.ArrayList deletedList = list.GetDeletedList();
			foreach(ACIntvalHolidayMapData item in deletedList)
			{
				ACIntvalHolidayMap entity = new ACIntvalHolidayMap(item);
				this.Add(entity);
				this.Remove(entity);
			}
		}

		#endregion

		public void Add(ACIntvalHolidayMap obj)
		{
			base.List.Add(obj);
		}

		public void AddRange(ACIntvalHolidayMapCollection list)
		{
			foreach(ACIntvalHolidayMap item in list)
			{
				this.Add(item);
			}
		}

		public void Remove(ACIntvalHolidayMap obj)
		{
			base.List.Remove(obj);
		}

		public void Insert(int index, ACIntvalHolidayMap obj)
		{
			 base.List.Insert(index, obj);
		}

		public bool Contains(ACIntvalHolidayMap item)
		{
			foreach (ACIntvalHolidayMap data in base.List)
			{
				if (data.Equals(item))
				{
					 return true;
				}
			}
			return false;
		}

		public bool ContainsDeleted(ACIntvalHolidayMap item)
		{
			foreach (ACIntvalHolidayMap data in  this._deletedList)
			{
				if (data.Equals(item))
				{
					 return true;
				}
			}
			return false;
		}

		public new ACIntvalHolidayMap this[int index]
		{
			get
			{
				return (ACIntvalHolidayMap) base.List[index];
			}
			set
			{
				base.List[index] = value;
			}
		}

		public virtual Cheke.BusinessEntity.Result Save(SecurityToken token)
		{
			if (!this.IsDirty)
			{
				return new Result(true);
			}

			ACIntvalHolidayMapDataCollection list = new ACIntvalHolidayMapDataCollection(this);
			list.GetChanges();
			return ACIntvalHolidayMapWrapper.Save(list, token);
		}

		public virtual Cheke.BusinessEntity.Result Save()
		{
			return this.Save(Cheke.Identity.Token);
		}

	}
	[Serializable]
	public class ACAccessLevelDetailCollection : ACAccessLevelDetailDataCollection, Cheke.BusinessEntity.IPersist
	{
		#region Constructors
		public ACAccessLevelDetailCollection()
		{
			base._itemType = typeof(ACAccessLevelDetail);
		}

		public ACAccessLevelDetailCollection(ACAccessLevelDetailDataCollection list)
		{
			base._itemType = typeof(ACAccessLevelDetail);
			foreach(ACAccessLevelDetailData item in list)
			{
				this.Add(new ACAccessLevelDetail(item));
			}

			System.Collections.ArrayList deletedList = list.GetDeletedList();
			foreach(ACAccessLevelDetailData item in deletedList)
			{
				ACAccessLevelDetail entity = new ACAccessLevelDetail(item);
				this.Add(entity);
				this.Remove(entity);
			}
		}

		#endregion

		public void Add(ACAccessLevelDetail obj)
		{
			base.List.Add(obj);
		}

		public void AddRange(ACAccessLevelDetailCollection list)
		{
			foreach(ACAccessLevelDetail item in list)
			{
				this.Add(item);
			}
		}

		public void Remove(ACAccessLevelDetail obj)
		{
			base.List.Remove(obj);
		}

		public void Insert(int index, ACAccessLevelDetail obj)
		{
			 base.List.Insert(index, obj);
		}

		public bool Contains(ACAccessLevelDetail item)
		{
			foreach (ACAccessLevelDetail data in base.List)
			{
				if (data.Equals(item))
				{
					 return true;
				}
			}
			return false;
		}

		public bool ContainsDeleted(ACAccessLevelDetail item)
		{
			foreach (ACAccessLevelDetail data in  this._deletedList)
			{
				if (data.Equals(item))
				{
					 return true;
				}
			}
			return false;
		}

		public new ACAccessLevelDetail this[int index]
		{
			get
			{
				return (ACAccessLevelDetail) base.List[index];
			}
			set
			{
				base.List[index] = value;
			}
		}

		public virtual Cheke.BusinessEntity.Result Save(SecurityToken token)
		{
			if (!this.IsDirty)
			{
				return new Result(true);
			}

			ACAccessLevelDetailDataCollection list = new ACAccessLevelDetailDataCollection(this);
			list.GetChanges();
			return ACAccessLevelDetailWrapper.Save(list, token);
		}

		public virtual Cheke.BusinessEntity.Result Save()
		{
			return this.Save(Cheke.Identity.Token);
		}

	}
	[Serializable]
	public class UsrAccountBuildingMapCollection : UsrAccountBuildingMapDataCollection, Cheke.BusinessEntity.IPersist
	{
		#region Constructors
		public UsrAccountBuildingMapCollection()
		{
			base._itemType = typeof(UsrAccountBuildingMap);
		}

		public UsrAccountBuildingMapCollection(UsrAccountBuildingMapDataCollection list)
		{
			base._itemType = typeof(UsrAccountBuildingMap);
			foreach(UsrAccountBuildingMapData item in list)
			{
				this.Add(new UsrAccountBuildingMap(item));
			}

			System.Collections.ArrayList deletedList = list.GetDeletedList();
			foreach(UsrAccountBuildingMapData item in deletedList)
			{
				UsrAccountBuildingMap entity = new UsrAccountBuildingMap(item);
				this.Add(entity);
				this.Remove(entity);
			}
		}

		#endregion

		public void Add(UsrAccountBuildingMap obj)
		{
			base.List.Add(obj);
		}

		public void AddRange(UsrAccountBuildingMapCollection list)
		{
			foreach(UsrAccountBuildingMap item in list)
			{
				this.Add(item);
			}
		}

		public void Remove(UsrAccountBuildingMap obj)
		{
			base.List.Remove(obj);
		}

		public void Insert(int index, UsrAccountBuildingMap obj)
		{
			 base.List.Insert(index, obj);
		}

		public bool Contains(UsrAccountBuildingMap item)
		{
			foreach (UsrAccountBuildingMap data in base.List)
			{
				if (data.Equals(item))
				{
					 return true;
				}
			}
			return false;
		}

		public bool ContainsDeleted(UsrAccountBuildingMap item)
		{
			foreach (UsrAccountBuildingMap data in  this._deletedList)
			{
				if (data.Equals(item))
				{
					 return true;
				}
			}
			return false;
		}

		public new UsrAccountBuildingMap this[int index]
		{
			get
			{
				return (UsrAccountBuildingMap) base.List[index];
			}
			set
			{
				base.List[index] = value;
			}
		}

		public virtual Cheke.BusinessEntity.Result Save(SecurityToken token)
		{
			if (!this.IsDirty)
			{
				return new Result(true);
			}

			UsrAccountBuildingMapDataCollection list = new UsrAccountBuildingMapDataCollection(this);
			list.GetChanges();
			return UsrAccountBuildingMapWrapper.Save(list, token);
		}

		public virtual Cheke.BusinessEntity.Result Save()
		{
			return this.Save(Cheke.Identity.Token);
		}

	}
	[Serializable]
	public class BDBuildingCollection : BDBuildingDataCollection, Cheke.BusinessEntity.IPersist
	{
		#region Constructors
		public BDBuildingCollection()
		{
			base._itemType = typeof(BDBuilding);
		}

		public BDBuildingCollection(BDBuildingDataCollection list)
		{
			base._itemType = typeof(BDBuilding);
			foreach(BDBuildingData item in list)
			{
				this.Add(new BDBuilding(item));
			}

			System.Collections.ArrayList deletedList = list.GetDeletedList();
			foreach(BDBuildingData item in deletedList)
			{
				BDBuilding entity = new BDBuilding(item);
				this.Add(entity);
				this.Remove(entity);
			}
		}

		#endregion

		public void Add(BDBuilding obj)
		{
			base.List.Add(obj);
		}

		public void AddRange(BDBuildingCollection list)
		{
			foreach(BDBuilding item in list)
			{
				this.Add(item);
			}
		}

		public void Remove(BDBuilding obj)
		{
			base.List.Remove(obj);
		}

		public void Insert(int index, BDBuilding obj)
		{
			 base.List.Insert(index, obj);
		}

		public bool Contains(BDBuilding item)
		{
			foreach (BDBuilding data in base.List)
			{
				if (data.Equals(item))
				{
					 return true;
				}
			}
			return false;
		}

		public bool ContainsDeleted(BDBuilding item)
		{
			foreach (BDBuilding data in  this._deletedList)
			{
				if (data.Equals(item))
				{
					 return true;
				}
			}
			return false;
		}

		public new BDBuilding this[int index]
		{
			get
			{
				return (BDBuilding) base.List[index];
			}
			set
			{
				base.List[index] = value;
			}
		}

		public virtual Cheke.BusinessEntity.Result Save(SecurityToken token)
		{
			if (!this.IsDirty)
			{
				return new Result(true);
			}

			BDBuildingDataCollection list = new BDBuildingDataCollection(this);
			list.GetChanges();
			return BDBuildingWrapper.Save(list, token);
		}

		public virtual Cheke.BusinessEntity.Result Save()
		{
			return this.Save(Cheke.Identity.Token);
		}

	}
	[Serializable]
	public class BDTenantCollection : BDTenantDataCollection, Cheke.BusinessEntity.IPersist
	{
		#region Constructors
		public BDTenantCollection()
		{
			base._itemType = typeof(BDTenant);
		}

		public BDTenantCollection(BDTenantDataCollection list)
		{
			base._itemType = typeof(BDTenant);
			foreach(BDTenantData item in list)
			{
				this.Add(new BDTenant(item));
			}

			System.Collections.ArrayList deletedList = list.GetDeletedList();
			foreach(BDTenantData item in deletedList)
			{
				BDTenant entity = new BDTenant(item);
				this.Add(entity);
				this.Remove(entity);
			}
		}

		#endregion

		public void Add(BDTenant obj)
		{
			base.List.Add(obj);
		}

		public void AddRange(BDTenantCollection list)
		{
			foreach(BDTenant item in list)
			{
				this.Add(item);
			}
		}

		public void Remove(BDTenant obj)
		{
			base.List.Remove(obj);
		}

		public void Insert(int index, BDTenant obj)
		{
			 base.List.Insert(index, obj);
		}

		public bool Contains(BDTenant item)
		{
			foreach (BDTenant data in base.List)
			{
				if (data.Equals(item))
				{
					 return true;
				}
			}
			return false;
		}

		public bool ContainsDeleted(BDTenant item)
		{
			foreach (BDTenant data in  this._deletedList)
			{
				if (data.Equals(item))
				{
					 return true;
				}
			}
			return false;
		}

		public new BDTenant this[int index]
		{
			get
			{
				return (BDTenant) base.List[index];
			}
			set
			{
				base.List[index] = value;
			}
		}

		public virtual Cheke.BusinessEntity.Result Save(SecurityToken token)
		{
			if (!this.IsDirty)
			{
				return new Result(true);
			}

			BDTenantDataCollection list = new BDTenantDataCollection(this);
			list.GetChanges();
			return BDTenantWrapper.Save(list, token);
		}

		public virtual Cheke.BusinessEntity.Result Save()
		{
			return this.Save(Cheke.Identity.Token);
		}

	}
	[Serializable]
	public class UtilSettingCategoryCollection : UtilSettingCategoryDataCollection, Cheke.BusinessEntity.IPersist
	{
		#region Constructors
		public UtilSettingCategoryCollection()
		{
			base._itemType = typeof(UtilSettingCategory);
		}

		public UtilSettingCategoryCollection(UtilSettingCategoryDataCollection list)
		{
			base._itemType = typeof(UtilSettingCategory);
			foreach(UtilSettingCategoryData item in list)
			{
				this.Add(new UtilSettingCategory(item));
			}

			System.Collections.ArrayList deletedList = list.GetDeletedList();
			foreach(UtilSettingCategoryData item in deletedList)
			{
				UtilSettingCategory entity = new UtilSettingCategory(item);
				this.Add(entity);
				this.Remove(entity);
			}
		}

		#endregion

		public void Add(UtilSettingCategory obj)
		{
			base.List.Add(obj);
		}

		public void AddRange(UtilSettingCategoryCollection list)
		{
			foreach(UtilSettingCategory item in list)
			{
				this.Add(item);
			}
		}

		public void Remove(UtilSettingCategory obj)
		{
			base.List.Remove(obj);
		}

		public void Insert(int index, UtilSettingCategory obj)
		{
			 base.List.Insert(index, obj);
		}

		public bool Contains(UtilSettingCategory item)
		{
			foreach (UtilSettingCategory data in base.List)
			{
				if (data.Equals(item))
				{
					 return true;
				}
			}
			return false;
		}

		public bool ContainsDeleted(UtilSettingCategory item)
		{
			foreach (UtilSettingCategory data in  this._deletedList)
			{
				if (data.Equals(item))
				{
					 return true;
				}
			}
			return false;
		}

		public new UtilSettingCategory this[int index]
		{
			get
			{
				return (UtilSettingCategory) base.List[index];
			}
			set
			{
				base.List[index] = value;
			}
		}

		public virtual Cheke.BusinessEntity.Result Save(SecurityToken token)
		{
			if (!this.IsDirty)
			{
				return new Result(true);
			}

			UtilSettingCategoryDataCollection list = new UtilSettingCategoryDataCollection(this);
			list.GetChanges();
			return UtilSettingCategoryWrapper.Save(list, token);
		}

		public virtual Cheke.BusinessEntity.Result Save()
		{
			return this.Save(Cheke.Identity.Token);
		}

	}
	[Serializable]
	public class UtilSettingDetailCollection : UtilSettingDetailDataCollection, Cheke.BusinessEntity.IPersist
	{
		#region Constructors
		public UtilSettingDetailCollection()
		{
			base._itemType = typeof(UtilSettingDetail);
		}

		public UtilSettingDetailCollection(UtilSettingDetailDataCollection list)
		{
			base._itemType = typeof(UtilSettingDetail);
			foreach(UtilSettingDetailData item in list)
			{
				this.Add(new UtilSettingDetail(item));
			}

			System.Collections.ArrayList deletedList = list.GetDeletedList();
			foreach(UtilSettingDetailData item in deletedList)
			{
				UtilSettingDetail entity = new UtilSettingDetail(item);
				this.Add(entity);
				this.Remove(entity);
			}
		}

		#endregion

		public void Add(UtilSettingDetail obj)
		{
			base.List.Add(obj);
		}

		public void AddRange(UtilSettingDetailCollection list)
		{
			foreach(UtilSettingDetail item in list)
			{
				this.Add(item);
			}
		}

		public void Remove(UtilSettingDetail obj)
		{
			base.List.Remove(obj);
		}

		public void Insert(int index, UtilSettingDetail obj)
		{
			 base.List.Insert(index, obj);
		}

		public bool Contains(UtilSettingDetail item)
		{
			foreach (UtilSettingDetail data in base.List)
			{
				if (data.Equals(item))
				{
					 return true;
				}
			}
			return false;
		}

		public bool ContainsDeleted(UtilSettingDetail item)
		{
			foreach (UtilSettingDetail data in  this._deletedList)
			{
				if (data.Equals(item))
				{
					 return true;
				}
			}
			return false;
		}

		public new UtilSettingDetail this[int index]
		{
			get
			{
				return (UtilSettingDetail) base.List[index];
			}
			set
			{
				base.List[index] = value;
			}
		}

		public virtual Cheke.BusinessEntity.Result Save(SecurityToken token)
		{
			if (!this.IsDirty)
			{
				return new Result(true);
			}

			UtilSettingDetailDataCollection list = new UtilSettingDetailDataCollection(this);
			list.GetChanges();
			return UtilSettingDetailWrapper.Save(list, token);
		}

		public virtual Cheke.BusinessEntity.Result Save()
		{
			return this.Save(Cheke.Identity.Token);
		}

	}
	[Serializable]
	public class ACOutputGroupMainZoneMapCollection : ACOutputGroupMainZoneMapDataCollection, Cheke.BusinessEntity.IPersist
	{
		#region Constructors
		public ACOutputGroupMainZoneMapCollection()
		{
			base._itemType = typeof(ACOutputGroupMainZoneMap);
		}

		public ACOutputGroupMainZoneMapCollection(ACOutputGroupMainZoneMapDataCollection list)
		{
			base._itemType = typeof(ACOutputGroupMainZoneMap);
			foreach(ACOutputGroupMainZoneMapData item in list)
			{
				this.Add(new ACOutputGroupMainZoneMap(item));
			}

			System.Collections.ArrayList deletedList = list.GetDeletedList();
			foreach(ACOutputGroupMainZoneMapData item in deletedList)
			{
				ACOutputGroupMainZoneMap entity = new ACOutputGroupMainZoneMap(item);
				this.Add(entity);
				this.Remove(entity);
			}
		}

		#endregion

		public void Add(ACOutputGroupMainZoneMap obj)
		{
			base.List.Add(obj);
		}

		public void AddRange(ACOutputGroupMainZoneMapCollection list)
		{
			foreach(ACOutputGroupMainZoneMap item in list)
			{
				this.Add(item);
			}
		}

		public void Remove(ACOutputGroupMainZoneMap obj)
		{
			base.List.Remove(obj);
		}

		public void Insert(int index, ACOutputGroupMainZoneMap obj)
		{
			 base.List.Insert(index, obj);
		}

		public bool Contains(ACOutputGroupMainZoneMap item)
		{
			foreach (ACOutputGroupMainZoneMap data in base.List)
			{
				if (data.Equals(item))
				{
					 return true;
				}
			}
			return false;
		}

		public bool ContainsDeleted(ACOutputGroupMainZoneMap item)
		{
			foreach (ACOutputGroupMainZoneMap data in  this._deletedList)
			{
				if (data.Equals(item))
				{
					 return true;
				}
			}
			return false;
		}

		public new ACOutputGroupMainZoneMap this[int index]
		{
			get
			{
				return (ACOutputGroupMainZoneMap) base.List[index];
			}
			set
			{
				base.List[index] = value;
			}
		}

		public virtual Cheke.BusinessEntity.Result Save(SecurityToken token)
		{
			if (!this.IsDirty)
			{
				return new Result(true);
			}

			ACOutputGroupMainZoneMapDataCollection list = new ACOutputGroupMainZoneMapDataCollection(this);
			list.GetChanges();
			return ACOutputGroupMainZoneMapWrapper.Save(list, token);
		}

		public virtual Cheke.BusinessEntity.Result Save()
		{
			return this.Save(Cheke.Identity.Token);
		}

	}
	[Serializable]
	public class ACCardHolderCollection : ACCardHolderDataCollection, Cheke.BusinessEntity.IPersist
	{
		#region Constructors
		public ACCardHolderCollection()
		{
			base._itemType = typeof(ACCardHolder);
		}

		public ACCardHolderCollection(ACCardHolderDataCollection list)
		{
			base._itemType = typeof(ACCardHolder);
			foreach(ACCardHolderData item in list)
			{
				this.Add(new ACCardHolder(item));
			}

			System.Collections.ArrayList deletedList = list.GetDeletedList();
			foreach(ACCardHolderData item in deletedList)
			{
				ACCardHolder entity = new ACCardHolder(item);
				this.Add(entity);
				this.Remove(entity);
			}
		}

		#endregion

		public void Add(ACCardHolder obj)
		{
			base.List.Add(obj);
		}

		public void AddRange(ACCardHolderCollection list)
		{
			foreach(ACCardHolder item in list)
			{
				this.Add(item);
			}
		}

		public void Remove(ACCardHolder obj)
		{
			base.List.Remove(obj);
		}

		public void Insert(int index, ACCardHolder obj)
		{
			 base.List.Insert(index, obj);
		}

		public bool Contains(ACCardHolder item)
		{
			foreach (ACCardHolder data in base.List)
			{
				if (data.Equals(item))
				{
					 return true;
				}
			}
			return false;
		}

		public bool ContainsDeleted(ACCardHolder item)
		{
			foreach (ACCardHolder data in  this._deletedList)
			{
				if (data.Equals(item))
				{
					 return true;
				}
			}
			return false;
		}

		public new ACCardHolder this[int index]
		{
			get
			{
				return (ACCardHolder) base.List[index];
			}
			set
			{
				base.List[index] = value;
			}
		}

		public virtual Cheke.BusinessEntity.Result Save(SecurityToken token)
		{
			if (!this.IsDirty)
			{
				return new Result(true);
			}

			ACCardHolderDataCollection list = new ACCardHolderDataCollection(this);
			list.GetChanges();
			return ACCardHolderWrapper.Save(list, token);
		}

		public virtual Cheke.BusinessEntity.Result Save()
		{
			return this.Save(Cheke.Identity.Token);
		}

	}
	[Serializable]
	public class ACMainZoneCollection : ACMainZoneDataCollection, Cheke.BusinessEntity.IPersist
	{
		#region Constructors
		public ACMainZoneCollection()
		{
			base._itemType = typeof(ACMainZone);
		}

		public ACMainZoneCollection(ACMainZoneDataCollection list)
		{
			base._itemType = typeof(ACMainZone);
			foreach(ACMainZoneData item in list)
			{
				this.Add(new ACMainZone(item));
			}

			System.Collections.ArrayList deletedList = list.GetDeletedList();
			foreach(ACMainZoneData item in deletedList)
			{
				ACMainZone entity = new ACMainZone(item);
				this.Add(entity);
				this.Remove(entity);
			}
		}

		#endregion

		public void Add(ACMainZone obj)
		{
			base.List.Add(obj);
		}

		public void AddRange(ACMainZoneCollection list)
		{
			foreach(ACMainZone item in list)
			{
				this.Add(item);
			}
		}

		public void Remove(ACMainZone obj)
		{
			base.List.Remove(obj);
		}

		public void Insert(int index, ACMainZone obj)
		{
			 base.List.Insert(index, obj);
		}

		public bool Contains(ACMainZone item)
		{
			foreach (ACMainZone data in base.List)
			{
				if (data.Equals(item))
				{
					 return true;
				}
			}
			return false;
		}

		public bool ContainsDeleted(ACMainZone item)
		{
			foreach (ACMainZone data in  this._deletedList)
			{
				if (data.Equals(item))
				{
					 return true;
				}
			}
			return false;
		}

		public new ACMainZone this[int index]
		{
			get
			{
				return (ACMainZone) base.List[index];
			}
			set
			{
				base.List[index] = value;
			}
		}

		public virtual Cheke.BusinessEntity.Result Save(SecurityToken token)
		{
			if (!this.IsDirty)
			{
				return new Result(true);
			}

			ACMainZoneDataCollection list = new ACMainZoneDataCollection(this);
			list.GetChanges();
			return ACMainZoneWrapper.Save(list, token);
		}

		public virtual Cheke.BusinessEntity.Result Save()
		{
			return this.Save(Cheke.Identity.Token);
		}

	}
	[Serializable]
	public class ACIntervalCollection : ACIntervalDataCollection, Cheke.BusinessEntity.IPersist
	{
		#region Constructors
		public ACIntervalCollection()
		{
			base._itemType = typeof(ACInterval);
		}

		public ACIntervalCollection(ACIntervalDataCollection list)
		{
			base._itemType = typeof(ACInterval);
			foreach(ACIntervalData item in list)
			{
				this.Add(new ACInterval(item));
			}

			System.Collections.ArrayList deletedList = list.GetDeletedList();
			foreach(ACIntervalData item in deletedList)
			{
				ACInterval entity = new ACInterval(item);
				this.Add(entity);
				this.Remove(entity);
			}
		}

		#endregion

		public void Add(ACInterval obj)
		{
			base.List.Add(obj);
		}

		public void AddRange(ACIntervalCollection list)
		{
			foreach(ACInterval item in list)
			{
				this.Add(item);
			}
		}

		public void Remove(ACInterval obj)
		{
			base.List.Remove(obj);
		}

		public void Insert(int index, ACInterval obj)
		{
			 base.List.Insert(index, obj);
		}

		public bool Contains(ACInterval item)
		{
			foreach (ACInterval data in base.List)
			{
				if (data.Equals(item))
				{
					 return true;
				}
			}
			return false;
		}

		public bool ContainsDeleted(ACInterval item)
		{
			foreach (ACInterval data in  this._deletedList)
			{
				if (data.Equals(item))
				{
					 return true;
				}
			}
			return false;
		}

		public new ACInterval this[int index]
		{
			get
			{
				return (ACInterval) base.List[index];
			}
			set
			{
				base.List[index] = value;
			}
		}

		public virtual Cheke.BusinessEntity.Result Save(SecurityToken token)
		{
			if (!this.IsDirty)
			{
				return new Result(true);
			}

			ACIntervalDataCollection list = new ACIntervalDataCollection(this);
			list.GetChanges();
			return ACIntervalWrapper.Save(list, token);
		}

		public virtual Cheke.BusinessEntity.Result Save()
		{
			return this.Save(Cheke.Identity.Token);
		}

	}
	[Serializable]
	public class ACPanelHolidayMapCollection : ACPanelHolidayMapDataCollection, Cheke.BusinessEntity.IPersist
	{
		#region Constructors
		public ACPanelHolidayMapCollection()
		{
			base._itemType = typeof(ACPanelHolidayMap);
		}

		public ACPanelHolidayMapCollection(ACPanelHolidayMapDataCollection list)
		{
			base._itemType = typeof(ACPanelHolidayMap);
			foreach(ACPanelHolidayMapData item in list)
			{
				this.Add(new ACPanelHolidayMap(item));
			}

			System.Collections.ArrayList deletedList = list.GetDeletedList();
			foreach(ACPanelHolidayMapData item in deletedList)
			{
				ACPanelHolidayMap entity = new ACPanelHolidayMap(item);
				this.Add(entity);
				this.Remove(entity);
			}
		}

		#endregion

		public void Add(ACPanelHolidayMap obj)
		{
			base.List.Add(obj);
		}

		public void AddRange(ACPanelHolidayMapCollection list)
		{
			foreach(ACPanelHolidayMap item in list)
			{
				this.Add(item);
			}
		}

		public void Remove(ACPanelHolidayMap obj)
		{
			base.List.Remove(obj);
		}

		public void Insert(int index, ACPanelHolidayMap obj)
		{
			 base.List.Insert(index, obj);
		}

		public bool Contains(ACPanelHolidayMap item)
		{
			foreach (ACPanelHolidayMap data in base.List)
			{
				if (data.Equals(item))
				{
					 return true;
				}
			}
			return false;
		}

		public bool ContainsDeleted(ACPanelHolidayMap item)
		{
			foreach (ACPanelHolidayMap data in  this._deletedList)
			{
				if (data.Equals(item))
				{
					 return true;
				}
			}
			return false;
		}

		public new ACPanelHolidayMap this[int index]
		{
			get
			{
				return (ACPanelHolidayMap) base.List[index];
			}
			set
			{
				base.List[index] = value;
			}
		}

		public virtual Cheke.BusinessEntity.Result Save(SecurityToken token)
		{
			if (!this.IsDirty)
			{
				return new Result(true);
			}

			ACPanelHolidayMapDataCollection list = new ACPanelHolidayMapDataCollection(this);
			list.GetChanges();
			return ACPanelHolidayMapWrapper.Save(list, token);
		}

		public virtual Cheke.BusinessEntity.Result Save()
		{
			return this.Save(Cheke.Identity.Token);
		}

	}
	[Serializable]
	public class ACTimecodeCollection : ACTimecodeDataCollection, Cheke.BusinessEntity.IPersist
	{
		#region Constructors
		public ACTimecodeCollection()
		{
			base._itemType = typeof(ACTimecode);
		}

		public ACTimecodeCollection(ACTimecodeDataCollection list)
		{
			base._itemType = typeof(ACTimecode);
			foreach(ACTimecodeData item in list)
			{
				this.Add(new ACTimecode(item));
			}

			System.Collections.ArrayList deletedList = list.GetDeletedList();
			foreach(ACTimecodeData item in deletedList)
			{
				ACTimecode entity = new ACTimecode(item);
				this.Add(entity);
				this.Remove(entity);
			}
		}

		#endregion

		public void Add(ACTimecode obj)
		{
			base.List.Add(obj);
		}

		public void AddRange(ACTimecodeCollection list)
		{
			foreach(ACTimecode item in list)
			{
				this.Add(item);
			}
		}

		public void Remove(ACTimecode obj)
		{
			base.List.Remove(obj);
		}

		public void Insert(int index, ACTimecode obj)
		{
			 base.List.Insert(index, obj);
		}

		public bool Contains(ACTimecode item)
		{
			foreach (ACTimecode data in base.List)
			{
				if (data.Equals(item))
				{
					 return true;
				}
			}
			return false;
		}

		public bool ContainsDeleted(ACTimecode item)
		{
			foreach (ACTimecode data in  this._deletedList)
			{
				if (data.Equals(item))
				{
					 return true;
				}
			}
			return false;
		}

		public new ACTimecode this[int index]
		{
			get
			{
				return (ACTimecode) base.List[index];
			}
			set
			{
				base.List[index] = value;
			}
		}

		public virtual Cheke.BusinessEntity.Result Save(SecurityToken token)
		{
			if (!this.IsDirty)
			{
				return new Result(true);
			}

			ACTimecodeDataCollection list = new ACTimecodeDataCollection(this);
			list.GetChanges();
			return ACTimecodeWrapper.Save(list, token);
		}

		public virtual Cheke.BusinessEntity.Result Save()
		{
			return this.Save(Cheke.Identity.Token);
		}

	}
	[Serializable]
	public class ACTimecodeIntervalMapCollection : ACTimecodeIntervalMapDataCollection, Cheke.BusinessEntity.IPersist
	{
		#region Constructors
		public ACTimecodeIntervalMapCollection()
		{
			base._itemType = typeof(ACTimecodeIntervalMap);
		}

		public ACTimecodeIntervalMapCollection(ACTimecodeIntervalMapDataCollection list)
		{
			base._itemType = typeof(ACTimecodeIntervalMap);
			foreach(ACTimecodeIntervalMapData item in list)
			{
				this.Add(new ACTimecodeIntervalMap(item));
			}

			System.Collections.ArrayList deletedList = list.GetDeletedList();
			foreach(ACTimecodeIntervalMapData item in deletedList)
			{
				ACTimecodeIntervalMap entity = new ACTimecodeIntervalMap(item);
				this.Add(entity);
				this.Remove(entity);
			}
		}

		#endregion

		public void Add(ACTimecodeIntervalMap obj)
		{
			base.List.Add(obj);
		}

		public void AddRange(ACTimecodeIntervalMapCollection list)
		{
			foreach(ACTimecodeIntervalMap item in list)
			{
				this.Add(item);
			}
		}

		public void Remove(ACTimecodeIntervalMap obj)
		{
			base.List.Remove(obj);
		}

		public void Insert(int index, ACTimecodeIntervalMap obj)
		{
			 base.List.Insert(index, obj);
		}

		public bool Contains(ACTimecodeIntervalMap item)
		{
			foreach (ACTimecodeIntervalMap data in base.List)
			{
				if (data.Equals(item))
				{
					 return true;
				}
			}
			return false;
		}

		public bool ContainsDeleted(ACTimecodeIntervalMap item)
		{
			foreach (ACTimecodeIntervalMap data in  this._deletedList)
			{
				if (data.Equals(item))
				{
					 return true;
				}
			}
			return false;
		}

		public new ACTimecodeIntervalMap this[int index]
		{
			get
			{
				return (ACTimecodeIntervalMap) base.List[index];
			}
			set
			{
				base.List[index] = value;
			}
		}

		public virtual Cheke.BusinessEntity.Result Save(SecurityToken token)
		{
			if (!this.IsDirty)
			{
				return new Result(true);
			}

			ACTimecodeIntervalMapDataCollection list = new ACTimecodeIntervalMapDataCollection(this);
			list.GetChanges();
			return ACTimecodeIntervalMapWrapper.Save(list, token);
		}

		public virtual Cheke.BusinessEntity.Result Save()
		{
			return this.Save(Cheke.Identity.Token);
		}

	}
	[Serializable]
	public class ACAMFormatCollection : ACAMFormatDataCollection, Cheke.BusinessEntity.IPersist
	{
		#region Constructors
		public ACAMFormatCollection()
		{
			base._itemType = typeof(ACAMFormat);
		}

		public ACAMFormatCollection(ACAMFormatDataCollection list)
		{
			base._itemType = typeof(ACAMFormat);
			foreach(ACAMFormatData item in list)
			{
				this.Add(new ACAMFormat(item));
			}

			System.Collections.ArrayList deletedList = list.GetDeletedList();
			foreach(ACAMFormatData item in deletedList)
			{
				ACAMFormat entity = new ACAMFormat(item);
				this.Add(entity);
				this.Remove(entity);
			}
		}

		#endregion

		public void Add(ACAMFormat obj)
		{
			base.List.Add(obj);
		}

		public void AddRange(ACAMFormatCollection list)
		{
			foreach(ACAMFormat item in list)
			{
				this.Add(item);
			}
		}

		public void Remove(ACAMFormat obj)
		{
			base.List.Remove(obj);
		}

		public void Insert(int index, ACAMFormat obj)
		{
			 base.List.Insert(index, obj);
		}

		public bool Contains(ACAMFormat item)
		{
			foreach (ACAMFormat data in base.List)
			{
				if (data.Equals(item))
				{
					 return true;
				}
			}
			return false;
		}

		public bool ContainsDeleted(ACAMFormat item)
		{
			foreach (ACAMFormat data in  this._deletedList)
			{
				if (data.Equals(item))
				{
					 return true;
				}
			}
			return false;
		}

		public new ACAMFormat this[int index]
		{
			get
			{
				return (ACAMFormat) base.List[index];
			}
			set
			{
				base.List[index] = value;
			}
		}

		public virtual Cheke.BusinessEntity.Result Save(SecurityToken token)
		{
			if (!this.IsDirty)
			{
				return new Result(true);
			}

			ACAMFormatDataCollection list = new ACAMFormatDataCollection(this);
			list.GetChanges();
			return ACAMFormatWrapper.Save(list, token);
		}

		public virtual Cheke.BusinessEntity.Result Save()
		{
			return this.Save(Cheke.Identity.Token);
		}

	}
	[Serializable]
	public class BDBuildingHolidayMapCollection : BDBuildingHolidayMapDataCollection, Cheke.BusinessEntity.IPersist
	{
		#region Constructors
		public BDBuildingHolidayMapCollection()
		{
			base._itemType = typeof(BDBuildingHolidayMap);
		}

		public BDBuildingHolidayMapCollection(BDBuildingHolidayMapDataCollection list)
		{
			base._itemType = typeof(BDBuildingHolidayMap);
			foreach(BDBuildingHolidayMapData item in list)
			{
				this.Add(new BDBuildingHolidayMap(item));
			}

			System.Collections.ArrayList deletedList = list.GetDeletedList();
			foreach(BDBuildingHolidayMapData item in deletedList)
			{
				BDBuildingHolidayMap entity = new BDBuildingHolidayMap(item);
				this.Add(entity);
				this.Remove(entity);
			}
		}

		#endregion

		public void Add(BDBuildingHolidayMap obj)
		{
			base.List.Add(obj);
		}

		public void AddRange(BDBuildingHolidayMapCollection list)
		{
			foreach(BDBuildingHolidayMap item in list)
			{
				this.Add(item);
			}
		}

		public void Remove(BDBuildingHolidayMap obj)
		{
			base.List.Remove(obj);
		}

		public void Insert(int index, BDBuildingHolidayMap obj)
		{
			 base.List.Insert(index, obj);
		}

		public bool Contains(BDBuildingHolidayMap item)
		{
			foreach (BDBuildingHolidayMap data in base.List)
			{
				if (data.Equals(item))
				{
					 return true;
				}
			}
			return false;
		}

		public bool ContainsDeleted(BDBuildingHolidayMap item)
		{
			foreach (BDBuildingHolidayMap data in  this._deletedList)
			{
				if (data.Equals(item))
				{
					 return true;
				}
			}
			return false;
		}

		public new BDBuildingHolidayMap this[int index]
		{
			get
			{
				return (BDBuildingHolidayMap) base.List[index];
			}
			set
			{
				base.List[index] = value;
			}
		}

		public virtual Cheke.BusinessEntity.Result Save(SecurityToken token)
		{
			if (!this.IsDirty)
			{
				return new Result(true);
			}

			BDBuildingHolidayMapDataCollection list = new BDBuildingHolidayMapDataCollection(this);
			list.GetChanges();
			return BDBuildingHolidayMapWrapper.Save(list, token);
		}

		public virtual Cheke.BusinessEntity.Result Save()
		{
			return this.Save(Cheke.Identity.Token);
		}

	}
	[Serializable]
	public class ACOutputGroupCollection : ACOutputGroupDataCollection, Cheke.BusinessEntity.IPersist
	{
		#region Constructors
		public ACOutputGroupCollection()
		{
			base._itemType = typeof(ACOutputGroup);
		}

		public ACOutputGroupCollection(ACOutputGroupDataCollection list)
		{
			base._itemType = typeof(ACOutputGroup);
			foreach(ACOutputGroupData item in list)
			{
				this.Add(new ACOutputGroup(item));
			}

			System.Collections.ArrayList deletedList = list.GetDeletedList();
			foreach(ACOutputGroupData item in deletedList)
			{
				ACOutputGroup entity = new ACOutputGroup(item);
				this.Add(entity);
				this.Remove(entity);
			}
		}

		#endregion

		public void Add(ACOutputGroup obj)
		{
			base.List.Add(obj);
		}

		public void AddRange(ACOutputGroupCollection list)
		{
			foreach(ACOutputGroup item in list)
			{
				this.Add(item);
			}
		}

		public void Remove(ACOutputGroup obj)
		{
			base.List.Remove(obj);
		}

		public void Insert(int index, ACOutputGroup obj)
		{
			 base.List.Insert(index, obj);
		}

		public bool Contains(ACOutputGroup item)
		{
			foreach (ACOutputGroup data in base.List)
			{
				if (data.Equals(item))
				{
					 return true;
				}
			}
			return false;
		}

		public bool ContainsDeleted(ACOutputGroup item)
		{
			foreach (ACOutputGroup data in  this._deletedList)
			{
				if (data.Equals(item))
				{
					 return true;
				}
			}
			return false;
		}

		public new ACOutputGroup this[int index]
		{
			get
			{
				return (ACOutputGroup) base.List[index];
			}
			set
			{
				base.List[index] = value;
			}
		}

		public virtual Cheke.BusinessEntity.Result Save(SecurityToken token)
		{
			if (!this.IsDirty)
			{
				return new Result(true);
			}

			ACOutputGroupDataCollection list = new ACOutputGroupDataCollection(this);
			list.GetChanges();
			return ACOutputGroupWrapper.Save(list, token);
		}

		public virtual Cheke.BusinessEntity.Result Save()
		{
			return this.Save(Cheke.Identity.Token);
		}

	}
	[Serializable]
	public class BDTenantHolidayMapCollection : BDTenantHolidayMapDataCollection, Cheke.BusinessEntity.IPersist
	{
		#region Constructors
		public BDTenantHolidayMapCollection()
		{
			base._itemType = typeof(BDTenantHolidayMap);
		}

		public BDTenantHolidayMapCollection(BDTenantHolidayMapDataCollection list)
		{
			base._itemType = typeof(BDTenantHolidayMap);
			foreach(BDTenantHolidayMapData item in list)
			{
				this.Add(new BDTenantHolidayMap(item));
			}

			System.Collections.ArrayList deletedList = list.GetDeletedList();
			foreach(BDTenantHolidayMapData item in deletedList)
			{
				BDTenantHolidayMap entity = new BDTenantHolidayMap(item);
				this.Add(entity);
				this.Remove(entity);
			}
		}

		#endregion

		public void Add(BDTenantHolidayMap obj)
		{
			base.List.Add(obj);
		}

		public void AddRange(BDTenantHolidayMapCollection list)
		{
			foreach(BDTenantHolidayMap item in list)
			{
				this.Add(item);
			}
		}

		public void Remove(BDTenantHolidayMap obj)
		{
			base.List.Remove(obj);
		}

		public void Insert(int index, BDTenantHolidayMap obj)
		{
			 base.List.Insert(index, obj);
		}

		public bool Contains(BDTenantHolidayMap item)
		{
			foreach (BDTenantHolidayMap data in base.List)
			{
				if (data.Equals(item))
				{
					 return true;
				}
			}
			return false;
		}

		public bool ContainsDeleted(BDTenantHolidayMap item)
		{
			foreach (BDTenantHolidayMap data in  this._deletedList)
			{
				if (data.Equals(item))
				{
					 return true;
				}
			}
			return false;
		}

		public new BDTenantHolidayMap this[int index]
		{
			get
			{
				return (BDTenantHolidayMap) base.List[index];
			}
			set
			{
				base.List[index] = value;
			}
		}

		public virtual Cheke.BusinessEntity.Result Save(SecurityToken token)
		{
			if (!this.IsDirty)
			{
				return new Result(true);
			}

			BDTenantHolidayMapDataCollection list = new BDTenantHolidayMapDataCollection(this);
			list.GetChanges();
			return BDTenantHolidayMapWrapper.Save(list, token);
		}

		public virtual Cheke.BusinessEntity.Result Save()
		{
			return this.Save(Cheke.Identity.Token);
		}

	}
	[Serializable]
	public class LogRowsCountCollection : LogRowsCountDataCollection, Cheke.BusinessEntity.IPersist
	{
		#region Constructors
		public LogRowsCountCollection()
		{
			base._itemType = typeof(LogRowsCount);
		}

		public LogRowsCountCollection(LogRowsCountDataCollection list)
		{
			base._itemType = typeof(LogRowsCount);
			foreach(LogRowsCountData item in list)
			{
				this.Add(new LogRowsCount(item));
			}

			System.Collections.ArrayList deletedList = list.GetDeletedList();
			foreach(LogRowsCountData item in deletedList)
			{
				LogRowsCount entity = new LogRowsCount(item);
				this.Add(entity);
				this.Remove(entity);
			}
		}

		#endregion

		public void Add(LogRowsCount obj)
		{
			base.List.Add(obj);
		}

		public void AddRange(LogRowsCountCollection list)
		{
			foreach(LogRowsCount item in list)
			{
				this.Add(item);
			}
		}

		public void Remove(LogRowsCount obj)
		{
			base.List.Remove(obj);
		}

		public void Insert(int index, LogRowsCount obj)
		{
			 base.List.Insert(index, obj);
		}

		public bool Contains(LogRowsCount item)
		{
			foreach (LogRowsCount data in base.List)
			{
				if (data.Equals(item))
				{
					 return true;
				}
			}
			return false;
		}

		public bool ContainsDeleted(LogRowsCount item)
		{
			foreach (LogRowsCount data in  this._deletedList)
			{
				if (data.Equals(item))
				{
					 return true;
				}
			}
			return false;
		}

		public new LogRowsCount this[int index]
		{
			get
			{
				return (LogRowsCount) base.List[index];
			}
			set
			{
				base.List[index] = value;
			}
		}

		public virtual Cheke.BusinessEntity.Result Save(SecurityToken token)
		{
			if (!this.IsDirty)
			{
				return new Result(true);
			}

			LogRowsCountDataCollection list = new LogRowsCountDataCollection(this);
			list.GetChanges();
			return LogRowsCountWrapper.Save(list, token);
		}

		public virtual Cheke.BusinessEntity.Result Save()
		{
			return this.Save(Cheke.Identity.Token);
		}

	}
	[Serializable]
	public class ACInputGroupCollection : ACInputGroupDataCollection, Cheke.BusinessEntity.IPersist
	{
		#region Constructors
		public ACInputGroupCollection()
		{
			base._itemType = typeof(ACInputGroup);
		}

		public ACInputGroupCollection(ACInputGroupDataCollection list)
		{
			base._itemType = typeof(ACInputGroup);
			foreach(ACInputGroupData item in list)
			{
				this.Add(new ACInputGroup(item));
			}

			System.Collections.ArrayList deletedList = list.GetDeletedList();
			foreach(ACInputGroupData item in deletedList)
			{
				ACInputGroup entity = new ACInputGroup(item);
				this.Add(entity);
				this.Remove(entity);
			}
		}

		#endregion

		public void Add(ACInputGroup obj)
		{
			base.List.Add(obj);
		}

		public void AddRange(ACInputGroupCollection list)
		{
			foreach(ACInputGroup item in list)
			{
				this.Add(item);
			}
		}

		public void Remove(ACInputGroup obj)
		{
			base.List.Remove(obj);
		}

		public void Insert(int index, ACInputGroup obj)
		{
			 base.List.Insert(index, obj);
		}

		public bool Contains(ACInputGroup item)
		{
			foreach (ACInputGroup data in base.List)
			{
				if (data.Equals(item))
				{
					 return true;
				}
			}
			return false;
		}

		public bool ContainsDeleted(ACInputGroup item)
		{
			foreach (ACInputGroup data in  this._deletedList)
			{
				if (data.Equals(item))
				{
					 return true;
				}
			}
			return false;
		}

		public new ACInputGroup this[int index]
		{
			get
			{
				return (ACInputGroup) base.List[index];
			}
			set
			{
				base.List[index] = value;
			}
		}

		public virtual Cheke.BusinessEntity.Result Save(SecurityToken token)
		{
			if (!this.IsDirty)
			{
				return new Result(true);
			}

			ACInputGroupDataCollection list = new ACInputGroupDataCollection(this);
			list.GetChanges();
			return ACInputGroupWrapper.Save(list, token);
		}

		public virtual Cheke.BusinessEntity.Result Save()
		{
			return this.Save(Cheke.Identity.Token);
		}

	}
	[Serializable]
	public class ACInputCollection : ACInputDataCollection, Cheke.BusinessEntity.IPersist
	{
		#region Constructors
		public ACInputCollection()
		{
			base._itemType = typeof(ACInput);
		}

		public ACInputCollection(ACInputDataCollection list)
		{
			base._itemType = typeof(ACInput);
			foreach(ACInputData item in list)
			{
				this.Add(new ACInput(item));
			}

			System.Collections.ArrayList deletedList = list.GetDeletedList();
			foreach(ACInputData item in deletedList)
			{
				ACInput entity = new ACInput(item);
				this.Add(entity);
				this.Remove(entity);
			}
		}

		#endregion

		public void Add(ACInput obj)
		{
			base.List.Add(obj);
		}

		public void AddRange(ACInputCollection list)
		{
			foreach(ACInput item in list)
			{
				this.Add(item);
			}
		}

		public void Remove(ACInput obj)
		{
			base.List.Remove(obj);
		}

		public void Insert(int index, ACInput obj)
		{
			 base.List.Insert(index, obj);
		}

		public bool Contains(ACInput item)
		{
			foreach (ACInput data in base.List)
			{
				if (data.Equals(item))
				{
					 return true;
				}
			}
			return false;
		}

		public bool ContainsDeleted(ACInput item)
		{
			foreach (ACInput data in  this._deletedList)
			{
				if (data.Equals(item))
				{
					 return true;
				}
			}
			return false;
		}

		public new ACInput this[int index]
		{
			get
			{
				return (ACInput) base.List[index];
			}
			set
			{
				base.List[index] = value;
			}
		}

		public virtual Cheke.BusinessEntity.Result Save(SecurityToken token)
		{
			if (!this.IsDirty)
			{
				return new Result(true);
			}

			ACInputDataCollection list = new ACInputDataCollection(this);
			list.GetChanges();
			return ACInputWrapper.Save(list, token);
		}

		public virtual Cheke.BusinessEntity.Result Save()
		{
			return this.Save(Cheke.Identity.Token);
		}

	}
	[Serializable]
	public class ACFunctionCardCollection : ACFunctionCardDataCollection, Cheke.BusinessEntity.IPersist
	{
		#region Constructors
		public ACFunctionCardCollection()
		{
			base._itemType = typeof(ACFunctionCard);
		}

		public ACFunctionCardCollection(ACFunctionCardDataCollection list)
		{
			base._itemType = typeof(ACFunctionCard);
			foreach(ACFunctionCardData item in list)
			{
				this.Add(new ACFunctionCard(item));
			}

			System.Collections.ArrayList deletedList = list.GetDeletedList();
			foreach(ACFunctionCardData item in deletedList)
			{
				ACFunctionCard entity = new ACFunctionCard(item);
				this.Add(entity);
				this.Remove(entity);
			}
		}

		#endregion

		public void Add(ACFunctionCard obj)
		{
			base.List.Add(obj);
		}

		public void AddRange(ACFunctionCardCollection list)
		{
			foreach(ACFunctionCard item in list)
			{
				this.Add(item);
			}
		}

		public void Remove(ACFunctionCard obj)
		{
			base.List.Remove(obj);
		}

		public void Insert(int index, ACFunctionCard obj)
		{
			 base.List.Insert(index, obj);
		}

		public bool Contains(ACFunctionCard item)
		{
			foreach (ACFunctionCard data in base.List)
			{
				if (data.Equals(item))
				{
					 return true;
				}
			}
			return false;
		}

		public bool ContainsDeleted(ACFunctionCard item)
		{
			foreach (ACFunctionCard data in  this._deletedList)
			{
				if (data.Equals(item))
				{
					 return true;
				}
			}
			return false;
		}

		public new ACFunctionCard this[int index]
		{
			get
			{
				return (ACFunctionCard) base.List[index];
			}
			set
			{
				base.List[index] = value;
			}
		}

		public virtual Cheke.BusinessEntity.Result Save(SecurityToken token)
		{
			if (!this.IsDirty)
			{
				return new Result(true);
			}

			ACFunctionCardDataCollection list = new ACFunctionCardDataCollection(this);
			list.GetChanges();
			return ACFunctionCardWrapper.Save(list, token);
		}

		public virtual Cheke.BusinessEntity.Result Save()
		{
			return this.Save(Cheke.Identity.Token);
		}

	}
	[Serializable]
	public class UtilHolidayCollection : UtilHolidayDataCollection, Cheke.BusinessEntity.IPersist
	{
		#region Constructors
		public UtilHolidayCollection()
		{
			base._itemType = typeof(UtilHoliday);
		}

		public UtilHolidayCollection(UtilHolidayDataCollection list)
		{
			base._itemType = typeof(UtilHoliday);
			foreach(UtilHolidayData item in list)
			{
				this.Add(new UtilHoliday(item));
			}

			System.Collections.ArrayList deletedList = list.GetDeletedList();
			foreach(UtilHolidayData item in deletedList)
			{
				UtilHoliday entity = new UtilHoliday(item);
				this.Add(entity);
				this.Remove(entity);
			}
		}

		#endregion

		public void Add(UtilHoliday obj)
		{
			base.List.Add(obj);
		}

		public void AddRange(UtilHolidayCollection list)
		{
			foreach(UtilHoliday item in list)
			{
				this.Add(item);
			}
		}

		public void Remove(UtilHoliday obj)
		{
			base.List.Remove(obj);
		}

		public void Insert(int index, UtilHoliday obj)
		{
			 base.List.Insert(index, obj);
		}

		public bool Contains(UtilHoliday item)
		{
			foreach (UtilHoliday data in base.List)
			{
				if (data.Equals(item))
				{
					 return true;
				}
			}
			return false;
		}

		public bool ContainsDeleted(UtilHoliday item)
		{
			foreach (UtilHoliday data in  this._deletedList)
			{
				if (data.Equals(item))
				{
					 return true;
				}
			}
			return false;
		}

		public new UtilHoliday this[int index]
		{
			get
			{
				return (UtilHoliday) base.List[index];
			}
			set
			{
				base.List[index] = value;
			}
		}

		public virtual Cheke.BusinessEntity.Result Save(SecurityToken token)
		{
			if (!this.IsDirty)
			{
				return new Result(true);
			}

			UtilHolidayDataCollection list = new UtilHolidayDataCollection(this);
			list.GetChanges();
			return UtilHolidayWrapper.Save(list, token);
		}

		public virtual Cheke.BusinessEntity.Result Save()
		{
			return this.Save(Cheke.Identity.Token);
		}

	}
	[Serializable]
	public class ACAccessLevelCollection : ACAccessLevelDataCollection, Cheke.BusinessEntity.IPersist
	{
		#region Constructors
		public ACAccessLevelCollection()
		{
			base._itemType = typeof(ACAccessLevel);
		}

		public ACAccessLevelCollection(ACAccessLevelDataCollection list)
		{
			base._itemType = typeof(ACAccessLevel);
			foreach(ACAccessLevelData item in list)
			{
				this.Add(new ACAccessLevel(item));
			}

			System.Collections.ArrayList deletedList = list.GetDeletedList();
			foreach(ACAccessLevelData item in deletedList)
			{
				ACAccessLevel entity = new ACAccessLevel(item);
				this.Add(entity);
				this.Remove(entity);
			}
		}

		#endregion

		public void Add(ACAccessLevel obj)
		{
			base.List.Add(obj);
		}

		public void AddRange(ACAccessLevelCollection list)
		{
			foreach(ACAccessLevel item in list)
			{
				this.Add(item);
			}
		}

		public void Remove(ACAccessLevel obj)
		{
			base.List.Remove(obj);
		}

		public void Insert(int index, ACAccessLevel obj)
		{
			 base.List.Insert(index, obj);
		}

		public bool Contains(ACAccessLevel item)
		{
			foreach (ACAccessLevel data in base.List)
			{
				if (data.Equals(item))
				{
					 return true;
				}
			}
			return false;
		}

		public bool ContainsDeleted(ACAccessLevel item)
		{
			foreach (ACAccessLevel data in  this._deletedList)
			{
				if (data.Equals(item))
				{
					 return true;
				}
			}
			return false;
		}

		public new ACAccessLevel this[int index]
		{
			get
			{
				return (ACAccessLevel) base.List[index];
			}
			set
			{
				base.List[index] = value;
			}
		}

		public virtual Cheke.BusinessEntity.Result Save(SecurityToken token)
		{
			if (!this.IsDirty)
			{
				return new Result(true);
			}

			ACAccessLevelDataCollection list = new ACAccessLevelDataCollection(this);
			list.GetChanges();
			return ACAccessLevelWrapper.Save(list, token);
		}

		public virtual Cheke.BusinessEntity.Result Save()
		{
			return this.Save(Cheke.Identity.Token);
		}

	}
	[Serializable]
	public class ACPanelFunctionCardMapCollection : ACPanelFunctionCardMapDataCollection, Cheke.BusinessEntity.IPersist
	{
		#region Constructors
		public ACPanelFunctionCardMapCollection()
		{
			base._itemType = typeof(ACPanelFunctionCardMap);
		}

		public ACPanelFunctionCardMapCollection(ACPanelFunctionCardMapDataCollection list)
		{
			base._itemType = typeof(ACPanelFunctionCardMap);
			foreach(ACPanelFunctionCardMapData item in list)
			{
				this.Add(new ACPanelFunctionCardMap(item));
			}

			System.Collections.ArrayList deletedList = list.GetDeletedList();
			foreach(ACPanelFunctionCardMapData item in deletedList)
			{
				ACPanelFunctionCardMap entity = new ACPanelFunctionCardMap(item);
				this.Add(entity);
				this.Remove(entity);
			}
		}

		#endregion

		public void Add(ACPanelFunctionCardMap obj)
		{
			base.List.Add(obj);
		}

		public void AddRange(ACPanelFunctionCardMapCollection list)
		{
			foreach(ACPanelFunctionCardMap item in list)
			{
				this.Add(item);
			}
		}

		public void Remove(ACPanelFunctionCardMap obj)
		{
			base.List.Remove(obj);
		}

		public void Insert(int index, ACPanelFunctionCardMap obj)
		{
			 base.List.Insert(index, obj);
		}

		public bool Contains(ACPanelFunctionCardMap item)
		{
			foreach (ACPanelFunctionCardMap data in base.List)
			{
				if (data.Equals(item))
				{
					 return true;
				}
			}
			return false;
		}

		public bool ContainsDeleted(ACPanelFunctionCardMap item)
		{
			foreach (ACPanelFunctionCardMap data in  this._deletedList)
			{
				if (data.Equals(item))
				{
					 return true;
				}
			}
			return false;
		}

		public new ACPanelFunctionCardMap this[int index]
		{
			get
			{
				return (ACPanelFunctionCardMap) base.List[index];
			}
			set
			{
				base.List[index] = value;
			}
		}

		public virtual Cheke.BusinessEntity.Result Save(SecurityToken token)
		{
			if (!this.IsDirty)
			{
				return new Result(true);
			}

			ACPanelFunctionCardMapDataCollection list = new ACPanelFunctionCardMapDataCollection(this);
			list.GetChanges();
			return ACPanelFunctionCardMapWrapper.Save(list, token);
		}

		public virtual Cheke.BusinessEntity.Result Save()
		{
			return this.Save(Cheke.Identity.Token);
		}

	}
	[Serializable]
	public class LogDBDeleteActivityCollection : LogDBDeleteActivityDataCollection, Cheke.BusinessEntity.IPersist
	{
		#region Constructors
		public LogDBDeleteActivityCollection()
		{
			base._itemType = typeof(LogDBDeleteActivity);
		}

		public LogDBDeleteActivityCollection(LogDBDeleteActivityDataCollection list)
		{
			base._itemType = typeof(LogDBDeleteActivity);
			foreach(LogDBDeleteActivityData item in list)
			{
				this.Add(new LogDBDeleteActivity(item));
			}

			System.Collections.ArrayList deletedList = list.GetDeletedList();
			foreach(LogDBDeleteActivityData item in deletedList)
			{
				LogDBDeleteActivity entity = new LogDBDeleteActivity(item);
				this.Add(entity);
				this.Remove(entity);
			}
		}

		#endregion

		public void Add(LogDBDeleteActivity obj)
		{
			base.List.Add(obj);
		}

		public void AddRange(LogDBDeleteActivityCollection list)
		{
			foreach(LogDBDeleteActivity item in list)
			{
				this.Add(item);
			}
		}

		public void Remove(LogDBDeleteActivity obj)
		{
			base.List.Remove(obj);
		}

		public void Insert(int index, LogDBDeleteActivity obj)
		{
			 base.List.Insert(index, obj);
		}

		public bool Contains(LogDBDeleteActivity item)
		{
			foreach (LogDBDeleteActivity data in base.List)
			{
				if (data.Equals(item))
				{
					 return true;
				}
			}
			return false;
		}

		public bool ContainsDeleted(LogDBDeleteActivity item)
		{
			foreach (LogDBDeleteActivity data in  this._deletedList)
			{
				if (data.Equals(item))
				{
					 return true;
				}
			}
			return false;
		}

		public new LogDBDeleteActivity this[int index]
		{
			get
			{
				return (LogDBDeleteActivity) base.List[index];
			}
			set
			{
				base.List[index] = value;
			}
		}

		public virtual Cheke.BusinessEntity.Result Save(SecurityToken token)
		{
			if (!this.IsDirty)
			{
				return new Result(true);
			}

			LogDBDeleteActivityDataCollection list = new LogDBDeleteActivityDataCollection(this);
			list.GetChanges();
			return LogDBDeleteActivityWrapper.Save(list, token);
		}

		public virtual Cheke.BusinessEntity.Result Save()
		{
			return this.Save(Cheke.Identity.Token);
		}

	}
	[Serializable]
	public class UsrAccountCollection : UsrAccountDataCollection, Cheke.BusinessEntity.IPersist
	{
		#region Constructors
		public UsrAccountCollection()
		{
			base._itemType = typeof(UsrAccount);
		}

		public UsrAccountCollection(UsrAccountDataCollection list)
		{
			base._itemType = typeof(UsrAccount);
			foreach(UsrAccountData item in list)
			{
				this.Add(new UsrAccount(item));
			}

			System.Collections.ArrayList deletedList = list.GetDeletedList();
			foreach(UsrAccountData item in deletedList)
			{
				UsrAccount entity = new UsrAccount(item);
				this.Add(entity);
				this.Remove(entity);
			}
		}

		#endregion

		public void Add(UsrAccount obj)
		{
			base.List.Add(obj);
		}

		public void AddRange(UsrAccountCollection list)
		{
			foreach(UsrAccount item in list)
			{
				this.Add(item);
			}
		}

		public void Remove(UsrAccount obj)
		{
			base.List.Remove(obj);
		}

		public void Insert(int index, UsrAccount obj)
		{
			 base.List.Insert(index, obj);
		}

		public bool Contains(UsrAccount item)
		{
			foreach (UsrAccount data in base.List)
			{
				if (data.Equals(item))
				{
					 return true;
				}
			}
			return false;
		}

		public bool ContainsDeleted(UsrAccount item)
		{
			foreach (UsrAccount data in  this._deletedList)
			{
				if (data.Equals(item))
				{
					 return true;
				}
			}
			return false;
		}

		public new UsrAccount this[int index]
		{
			get
			{
				return (UsrAccount) base.List[index];
			}
			set
			{
				base.List[index] = value;
			}
		}

		public virtual Cheke.BusinessEntity.Result Save(SecurityToken token)
		{
			if (!this.IsDirty)
			{
				return new Result(true);
			}

			UsrAccountDataCollection list = new UsrAccountDataCollection(this);
			list.GetChanges();
			return UsrAccountWrapper.Save(list, token);
		}

		public virtual Cheke.BusinessEntity.Result Save()
		{
			return this.Save(Cheke.Identity.Token);
		}

	}
	[Serializable]
	public class LogDBEditActivityCollection : LogDBEditActivityDataCollection, Cheke.BusinessEntity.IPersist
	{
		#region Constructors
		public LogDBEditActivityCollection()
		{
			base._itemType = typeof(LogDBEditActivity);
		}

		public LogDBEditActivityCollection(LogDBEditActivityDataCollection list)
		{
			base._itemType = typeof(LogDBEditActivity);
			foreach(LogDBEditActivityData item in list)
			{
				this.Add(new LogDBEditActivity(item));
			}

			System.Collections.ArrayList deletedList = list.GetDeletedList();
			foreach(LogDBEditActivityData item in deletedList)
			{
				LogDBEditActivity entity = new LogDBEditActivity(item);
				this.Add(entity);
				this.Remove(entity);
			}
		}

		#endregion

		public void Add(LogDBEditActivity obj)
		{
			base.List.Add(obj);
		}

		public void AddRange(LogDBEditActivityCollection list)
		{
			foreach(LogDBEditActivity item in list)
			{
				this.Add(item);
			}
		}

		public void Remove(LogDBEditActivity obj)
		{
			base.List.Remove(obj);
		}

		public void Insert(int index, LogDBEditActivity obj)
		{
			 base.List.Insert(index, obj);
		}

		public bool Contains(LogDBEditActivity item)
		{
			foreach (LogDBEditActivity data in base.List)
			{
				if (data.Equals(item))
				{
					 return true;
				}
			}
			return false;
		}

		public bool ContainsDeleted(LogDBEditActivity item)
		{
			foreach (LogDBEditActivity data in  this._deletedList)
			{
				if (data.Equals(item))
				{
					 return true;
				}
			}
			return false;
		}

		public new LogDBEditActivity this[int index]
		{
			get
			{
				return (LogDBEditActivity) base.List[index];
			}
			set
			{
				base.List[index] = value;
			}
		}

		public virtual Cheke.BusinessEntity.Result Save(SecurityToken token)
		{
			if (!this.IsDirty)
			{
				return new Result(true);
			}

			LogDBEditActivityDataCollection list = new LogDBEditActivityDataCollection(this);
			list.GetChanges();
			return LogDBEditActivityWrapper.Save(list, token);
		}

		public virtual Cheke.BusinessEntity.Result Save()
		{
			return this.Save(Cheke.Identity.Token);
		}

	}
	[Serializable]
	public class ACMasterCardCollection : ACMasterCardDataCollection, Cheke.BusinessEntity.IPersist
	{
		#region Constructors
		public ACMasterCardCollection()
		{
			base._itemType = typeof(ACMasterCard);
		}

		public ACMasterCardCollection(ACMasterCardDataCollection list)
		{
			base._itemType = typeof(ACMasterCard);
			foreach(ACMasterCardData item in list)
			{
				this.Add(new ACMasterCard(item));
			}

			System.Collections.ArrayList deletedList = list.GetDeletedList();
			foreach(ACMasterCardData item in deletedList)
			{
				ACMasterCard entity = new ACMasterCard(item);
				this.Add(entity);
				this.Remove(entity);
			}
		}

		#endregion

		public void Add(ACMasterCard obj)
		{
			base.List.Add(obj);
		}

		public void AddRange(ACMasterCardCollection list)
		{
			foreach(ACMasterCard item in list)
			{
				this.Add(item);
			}
		}

		public void Remove(ACMasterCard obj)
		{
			base.List.Remove(obj);
		}

		public void Insert(int index, ACMasterCard obj)
		{
			 base.List.Insert(index, obj);
		}

		public bool Contains(ACMasterCard item)
		{
			foreach (ACMasterCard data in base.List)
			{
				if (data.Equals(item))
				{
					 return true;
				}
			}
			return false;
		}

		public bool ContainsDeleted(ACMasterCard item)
		{
			foreach (ACMasterCard data in  this._deletedList)
			{
				if (data.Equals(item))
				{
					 return true;
				}
			}
			return false;
		}

		public new ACMasterCard this[int index]
		{
			get
			{
				return (ACMasterCard) base.List[index];
			}
			set
			{
				base.List[index] = value;
			}
		}

		public virtual Cheke.BusinessEntity.Result Save(SecurityToken token)
		{
			if (!this.IsDirty)
			{
				return new Result(true);
			}

			ACMasterCardDataCollection list = new ACMasterCardDataCollection(this);
			list.GetChanges();
			return ACMasterCardWrapper.Save(list, token);
		}

		public virtual Cheke.BusinessEntity.Result Save()
		{
			return this.Save(Cheke.Identity.Token);
		}

	}
	[Serializable]
	public class ACSupervisoryCollection : ACSupervisoryDataCollection, Cheke.BusinessEntity.IPersist
	{
		#region Constructors
		public ACSupervisoryCollection()
		{
			base._itemType = typeof(ACSupervisory);
		}

		public ACSupervisoryCollection(ACSupervisoryDataCollection list)
		{
			base._itemType = typeof(ACSupervisory);
			foreach(ACSupervisoryData item in list)
			{
				this.Add(new ACSupervisory(item));
			}

			System.Collections.ArrayList deletedList = list.GetDeletedList();
			foreach(ACSupervisoryData item in deletedList)
			{
				ACSupervisory entity = new ACSupervisory(item);
				this.Add(entity);
				this.Remove(entity);
			}
		}

		#endregion

		public void Add(ACSupervisory obj)
		{
			base.List.Add(obj);
		}

		public void AddRange(ACSupervisoryCollection list)
		{
			foreach(ACSupervisory item in list)
			{
				this.Add(item);
			}
		}

		public void Remove(ACSupervisory obj)
		{
			base.List.Remove(obj);
		}

		public void Insert(int index, ACSupervisory obj)
		{
			 base.List.Insert(index, obj);
		}

		public bool Contains(ACSupervisory item)
		{
			foreach (ACSupervisory data in base.List)
			{
				if (data.Equals(item))
				{
					 return true;
				}
			}
			return false;
		}

		public bool ContainsDeleted(ACSupervisory item)
		{
			foreach (ACSupervisory data in  this._deletedList)
			{
				if (data.Equals(item))
				{
					 return true;
				}
			}
			return false;
		}

		public new ACSupervisory this[int index]
		{
			get
			{
				return (ACSupervisory) base.List[index];
			}
			set
			{
				base.List[index] = value;
			}
		}

		public virtual Cheke.BusinessEntity.Result Save(SecurityToken token)
		{
			if (!this.IsDirty)
			{
				return new Result(true);
			}

			ACSupervisoryDataCollection list = new ACSupervisoryDataCollection(this);
			list.GetChanges();
			return ACSupervisoryWrapper.Save(list, token);
		}

		public virtual Cheke.BusinessEntity.Result Save()
		{
			return this.Save(Cheke.Identity.Token);
		}

	}
	[Serializable]
	public class UsrGroupCollection : UsrGroupDataCollection, Cheke.BusinessEntity.IPersist
	{
		#region Constructors
		public UsrGroupCollection()
		{
			base._itemType = typeof(UsrGroup);
		}

		public UsrGroupCollection(UsrGroupDataCollection list)
		{
			base._itemType = typeof(UsrGroup);
			foreach(UsrGroupData item in list)
			{
				this.Add(new UsrGroup(item));
			}

			System.Collections.ArrayList deletedList = list.GetDeletedList();
			foreach(UsrGroupData item in deletedList)
			{
				UsrGroup entity = new UsrGroup(item);
				this.Add(entity);
				this.Remove(entity);
			}
		}

		#endregion

		public void Add(UsrGroup obj)
		{
			base.List.Add(obj);
		}

		public void AddRange(UsrGroupCollection list)
		{
			foreach(UsrGroup item in list)
			{
				this.Add(item);
			}
		}

		public void Remove(UsrGroup obj)
		{
			base.List.Remove(obj);
		}

		public void Insert(int index, UsrGroup obj)
		{
			 base.List.Insert(index, obj);
		}

		public bool Contains(UsrGroup item)
		{
			foreach (UsrGroup data in base.List)
			{
				if (data.Equals(item))
				{
					 return true;
				}
			}
			return false;
		}

		public bool ContainsDeleted(UsrGroup item)
		{
			foreach (UsrGroup data in  this._deletedList)
			{
				if (data.Equals(item))
				{
					 return true;
				}
			}
			return false;
		}

		public new UsrGroup this[int index]
		{
			get
			{
				return (UsrGroup) base.List[index];
			}
			set
			{
				base.List[index] = value;
			}
		}

		public virtual Cheke.BusinessEntity.Result Save(SecurityToken token)
		{
			if (!this.IsDirty)
			{
				return new Result(true);
			}

			UsrGroupDataCollection list = new UsrGroupDataCollection(this);
			list.GetChanges();
			return UsrGroupWrapper.Save(list, token);
		}

		public virtual Cheke.BusinessEntity.Result Save()
		{
			return this.Save(Cheke.Identity.Token);
		}

	}
	[Serializable]
	public class ACCardHolderBuildingMapCollection : ACCardHolderBuildingMapDataCollection, Cheke.BusinessEntity.IPersist
	{
		#region Constructors
		public ACCardHolderBuildingMapCollection()
		{
			base._itemType = typeof(ACCardHolderBuildingMap);
		}

		public ACCardHolderBuildingMapCollection(ACCardHolderBuildingMapDataCollection list)
		{
			base._itemType = typeof(ACCardHolderBuildingMap);
			foreach(ACCardHolderBuildingMapData item in list)
			{
				this.Add(new ACCardHolderBuildingMap(item));
			}

			System.Collections.ArrayList deletedList = list.GetDeletedList();
			foreach(ACCardHolderBuildingMapData item in deletedList)
			{
				ACCardHolderBuildingMap entity = new ACCardHolderBuildingMap(item);
				this.Add(entity);
				this.Remove(entity);
			}
		}

		#endregion

		public void Add(ACCardHolderBuildingMap obj)
		{
			base.List.Add(obj);
		}

		public void AddRange(ACCardHolderBuildingMapCollection list)
		{
			foreach(ACCardHolderBuildingMap item in list)
			{
				this.Add(item);
			}
		}

		public void Remove(ACCardHolderBuildingMap obj)
		{
			base.List.Remove(obj);
		}

		public void Insert(int index, ACCardHolderBuildingMap obj)
		{
			 base.List.Insert(index, obj);
		}

		public bool Contains(ACCardHolderBuildingMap item)
		{
			foreach (ACCardHolderBuildingMap data in base.List)
			{
				if (data.Equals(item))
				{
					 return true;
				}
			}
			return false;
		}

		public bool ContainsDeleted(ACCardHolderBuildingMap item)
		{
			foreach (ACCardHolderBuildingMap data in  this._deletedList)
			{
				if (data.Equals(item))
				{
					 return true;
				}
			}
			return false;
		}

		public new ACCardHolderBuildingMap this[int index]
		{
			get
			{
				return (ACCardHolderBuildingMap) base.List[index];
			}
			set
			{
				base.List[index] = value;
			}
		}

		public virtual Cheke.BusinessEntity.Result Save(SecurityToken token)
		{
			if (!this.IsDirty)
			{
				return new Result(true);
			}

			ACCardHolderBuildingMapDataCollection list = new ACCardHolderBuildingMapDataCollection(this);
			list.GetChanges();
			return ACCardHolderBuildingMapWrapper.Save(list, token);
		}

		public virtual Cheke.BusinessEntity.Result Save()
		{
			return this.Save(Cheke.Identity.Token);
		}

	}
	[Serializable]
	public class BDVisitorCollection : BDVisitorDataCollection, Cheke.BusinessEntity.IPersist
	{
		#region Constructors
		public BDVisitorCollection()
		{
			base._itemType = typeof(BDVisitor);
		}

		public BDVisitorCollection(BDVisitorDataCollection list)
		{
			base._itemType = typeof(BDVisitor);
			foreach(BDVisitorData item in list)
			{
				this.Add(new BDVisitor(item));
			}

			System.Collections.ArrayList deletedList = list.GetDeletedList();
			foreach(BDVisitorData item in deletedList)
			{
				BDVisitor entity = new BDVisitor(item);
				this.Add(entity);
				this.Remove(entity);
			}
		}

		#endregion

		public void Add(BDVisitor obj)
		{
			base.List.Add(obj);
		}

		public void AddRange(BDVisitorCollection list)
		{
			foreach(BDVisitor item in list)
			{
				this.Add(item);
			}
		}

		public void Remove(BDVisitor obj)
		{
			base.List.Remove(obj);
		}

		public void Insert(int index, BDVisitor obj)
		{
			 base.List.Insert(index, obj);
		}

		public bool Contains(BDVisitor item)
		{
			foreach (BDVisitor data in base.List)
			{
				if (data.Equals(item))
				{
					 return true;
				}
			}
			return false;
		}

		public bool ContainsDeleted(BDVisitor item)
		{
			foreach (BDVisitor data in  this._deletedList)
			{
				if (data.Equals(item))
				{
					 return true;
				}
			}
			return false;
		}

		public new BDVisitor this[int index]
		{
			get
			{
				return (BDVisitor) base.List[index];
			}
			set
			{
				base.List[index] = value;
			}
		}

		public virtual Cheke.BusinessEntity.Result Save(SecurityToken token)
		{
			if (!this.IsDirty)
			{
				return new Result(true);
			}

			BDVisitorDataCollection list = new BDVisitorDataCollection(this);
			list.GetChanges();
			return BDVisitorWrapper.Save(list, token);
		}

		public virtual Cheke.BusinessEntity.Result Save()
		{
			return this.Save(Cheke.Identity.Token);
		}

	}
	[Serializable]
	public class UsrGroupDBRuleCollection : UsrGroupDBRuleDataCollection, Cheke.BusinessEntity.IPersist
	{
		#region Constructors
		public UsrGroupDBRuleCollection()
		{
			base._itemType = typeof(UsrGroupDBRule);
		}

		public UsrGroupDBRuleCollection(UsrGroupDBRuleDataCollection list)
		{
			base._itemType = typeof(UsrGroupDBRule);
			foreach(UsrGroupDBRuleData item in list)
			{
				this.Add(new UsrGroupDBRule(item));
			}

			System.Collections.ArrayList deletedList = list.GetDeletedList();
			foreach(UsrGroupDBRuleData item in deletedList)
			{
				UsrGroupDBRule entity = new UsrGroupDBRule(item);
				this.Add(entity);
				this.Remove(entity);
			}
		}

		#endregion

		public void Add(UsrGroupDBRule obj)
		{
			base.List.Add(obj);
		}

		public void AddRange(UsrGroupDBRuleCollection list)
		{
			foreach(UsrGroupDBRule item in list)
			{
				this.Add(item);
			}
		}

		public void Remove(UsrGroupDBRule obj)
		{
			base.List.Remove(obj);
		}

		public void Insert(int index, UsrGroupDBRule obj)
		{
			 base.List.Insert(index, obj);
		}

		public bool Contains(UsrGroupDBRule item)
		{
			foreach (UsrGroupDBRule data in base.List)
			{
				if (data.Equals(item))
				{
					 return true;
				}
			}
			return false;
		}

		public bool ContainsDeleted(UsrGroupDBRule item)
		{
			foreach (UsrGroupDBRule data in  this._deletedList)
			{
				if (data.Equals(item))
				{
					 return true;
				}
			}
			return false;
		}

		public new UsrGroupDBRule this[int index]
		{
			get
			{
				return (UsrGroupDBRule) base.List[index];
			}
			set
			{
				base.List[index] = value;
			}
		}

		public virtual Cheke.BusinessEntity.Result Save(SecurityToken token)
		{
			if (!this.IsDirty)
			{
				return new Result(true);
			}

			UsrGroupDBRuleDataCollection list = new UsrGroupDBRuleDataCollection(this);
			list.GetChanges();
			return UsrGroupDBRuleWrapper.Save(list, token);
		}

		public virtual Cheke.BusinessEntity.Result Save()
		{
			return this.Save(Cheke.Identity.Token);
		}

	}
	[Serializable]
	public class ACPanelCollection : ACPanelDataCollection, Cheke.BusinessEntity.IPersist
	{
		#region Constructors
		public ACPanelCollection()
		{
			base._itemType = typeof(ACPanel);
		}

		public ACPanelCollection(ACPanelDataCollection list)
		{
			base._itemType = typeof(ACPanel);
			foreach(ACPanelData item in list)
			{
				this.Add(new ACPanel(item));
			}

			System.Collections.ArrayList deletedList = list.GetDeletedList();
			foreach(ACPanelData item in deletedList)
			{
				ACPanel entity = new ACPanel(item);
				this.Add(entity);
				this.Remove(entity);
			}
		}

		#endregion

		public void Add(ACPanel obj)
		{
			base.List.Add(obj);
		}

		public void AddRange(ACPanelCollection list)
		{
			foreach(ACPanel item in list)
			{
				this.Add(item);
			}
		}

		public void Remove(ACPanel obj)
		{
			base.List.Remove(obj);
		}

		public void Insert(int index, ACPanel obj)
		{
			 base.List.Insert(index, obj);
		}

		public bool Contains(ACPanel item)
		{
			foreach (ACPanel data in base.List)
			{
				if (data.Equals(item))
				{
					 return true;
				}
			}
			return false;
		}

		public bool ContainsDeleted(ACPanel item)
		{
			foreach (ACPanel data in  this._deletedList)
			{
				if (data.Equals(item))
				{
					 return true;
				}
			}
			return false;
		}

		public new ACPanel this[int index]
		{
			get
			{
				return (ACPanel) base.List[index];
			}
			set
			{
				base.List[index] = value;
			}
		}

		public virtual Cheke.BusinessEntity.Result Save(SecurityToken token)
		{
			if (!this.IsDirty)
			{
				return new Result(true);
			}

			ACPanelDataCollection list = new ACPanelDataCollection(this);
			list.GetChanges();
			return ACPanelWrapper.Save(list, token);
		}

		public virtual Cheke.BusinessEntity.Result Save()
		{
			return this.Save(Cheke.Identity.Token);
		}

	}
	[Serializable]
	public class UsrAccountDBRuleCollection : UsrAccountDBRuleDataCollection, Cheke.BusinessEntity.IPersist
	{
		#region Constructors
		public UsrAccountDBRuleCollection()
		{
			base._itemType = typeof(UsrAccountDBRule);
		}

		public UsrAccountDBRuleCollection(UsrAccountDBRuleDataCollection list)
		{
			base._itemType = typeof(UsrAccountDBRule);
			foreach(UsrAccountDBRuleData item in list)
			{
				this.Add(new UsrAccountDBRule(item));
			}

			System.Collections.ArrayList deletedList = list.GetDeletedList();
			foreach(UsrAccountDBRuleData item in deletedList)
			{
				UsrAccountDBRule entity = new UsrAccountDBRule(item);
				this.Add(entity);
				this.Remove(entity);
			}
		}

		#endregion

		public void Add(UsrAccountDBRule obj)
		{
			base.List.Add(obj);
		}

		public void AddRange(UsrAccountDBRuleCollection list)
		{
			foreach(UsrAccountDBRule item in list)
			{
				this.Add(item);
			}
		}

		public void Remove(UsrAccountDBRule obj)
		{
			base.List.Remove(obj);
		}

		public void Insert(int index, UsrAccountDBRule obj)
		{
			 base.List.Insert(index, obj);
		}

		public bool Contains(UsrAccountDBRule item)
		{
			foreach (UsrAccountDBRule data in base.List)
			{
				if (data.Equals(item))
				{
					 return true;
				}
			}
			return false;
		}

		public bool ContainsDeleted(UsrAccountDBRule item)
		{
			foreach (UsrAccountDBRule data in  this._deletedList)
			{
				if (data.Equals(item))
				{
					 return true;
				}
			}
			return false;
		}

		public new UsrAccountDBRule this[int index]
		{
			get
			{
				return (UsrAccountDBRule) base.List[index];
			}
			set
			{
				base.List[index] = value;
			}
		}

		public virtual Cheke.BusinessEntity.Result Save(SecurityToken token)
		{
			if (!this.IsDirty)
			{
				return new Result(true);
			}

			UsrAccountDBRuleDataCollection list = new UsrAccountDBRuleDataCollection(this);
			list.GetChanges();
			return UsrAccountDBRuleWrapper.Save(list, token);
		}

		public virtual Cheke.BusinessEntity.Result Save()
		{
			return this.Save(Cheke.Identity.Token);
		}

	}
	[Serializable]
	public class UsrGroupBRRuleCollection : UsrGroupBRRuleDataCollection, Cheke.BusinessEntity.IPersist
	{
		#region Constructors
		public UsrGroupBRRuleCollection()
		{
			base._itemType = typeof(UsrGroupBRRule);
		}

		public UsrGroupBRRuleCollection(UsrGroupBRRuleDataCollection list)
		{
			base._itemType = typeof(UsrGroupBRRule);
			foreach(UsrGroupBRRuleData item in list)
			{
				this.Add(new UsrGroupBRRule(item));
			}

			System.Collections.ArrayList deletedList = list.GetDeletedList();
			foreach(UsrGroupBRRuleData item in deletedList)
			{
				UsrGroupBRRule entity = new UsrGroupBRRule(item);
				this.Add(entity);
				this.Remove(entity);
			}
		}

		#endregion

		public void Add(UsrGroupBRRule obj)
		{
			base.List.Add(obj);
		}

		public void AddRange(UsrGroupBRRuleCollection list)
		{
			foreach(UsrGroupBRRule item in list)
			{
				this.Add(item);
			}
		}

		public void Remove(UsrGroupBRRule obj)
		{
			base.List.Remove(obj);
		}

		public void Insert(int index, UsrGroupBRRule obj)
		{
			 base.List.Insert(index, obj);
		}

		public bool Contains(UsrGroupBRRule item)
		{
			foreach (UsrGroupBRRule data in base.List)
			{
				if (data.Equals(item))
				{
					 return true;
				}
			}
			return false;
		}

		public bool ContainsDeleted(UsrGroupBRRule item)
		{
			foreach (UsrGroupBRRule data in  this._deletedList)
			{
				if (data.Equals(item))
				{
					 return true;
				}
			}
			return false;
		}

		public new UsrGroupBRRule this[int index]
		{
			get
			{
				return (UsrGroupBRRule) base.List[index];
			}
			set
			{
				base.List[index] = value;
			}
		}

		public virtual Cheke.BusinessEntity.Result Save(SecurityToken token)
		{
			if (!this.IsDirty)
			{
				return new Result(true);
			}

			UsrGroupBRRuleDataCollection list = new UsrGroupBRRuleDataCollection(this);
			list.GetChanges();
			return UsrGroupBRRuleWrapper.Save(list, token);
		}

		public virtual Cheke.BusinessEntity.Result Save()
		{
			return this.Save(Cheke.Identity.Token);
		}

	}
	[Serializable]
	public class ACInputGroupInputMapCollection : ACInputGroupInputMapDataCollection, Cheke.BusinessEntity.IPersist
	{
		#region Constructors
		public ACInputGroupInputMapCollection()
		{
			base._itemType = typeof(ACInputGroupInputMap);
		}

		public ACInputGroupInputMapCollection(ACInputGroupInputMapDataCollection list)
		{
			base._itemType = typeof(ACInputGroupInputMap);
			foreach(ACInputGroupInputMapData item in list)
			{
				this.Add(new ACInputGroupInputMap(item));
			}

			System.Collections.ArrayList deletedList = list.GetDeletedList();
			foreach(ACInputGroupInputMapData item in deletedList)
			{
				ACInputGroupInputMap entity = new ACInputGroupInputMap(item);
				this.Add(entity);
				this.Remove(entity);
			}
		}

		#endregion

		public void Add(ACInputGroupInputMap obj)
		{
			base.List.Add(obj);
		}

		public void AddRange(ACInputGroupInputMapCollection list)
		{
			foreach(ACInputGroupInputMap item in list)
			{
				this.Add(item);
			}
		}

		public void Remove(ACInputGroupInputMap obj)
		{
			base.List.Remove(obj);
		}

		public void Insert(int index, ACInputGroupInputMap obj)
		{
			 base.List.Insert(index, obj);
		}

		public bool Contains(ACInputGroupInputMap item)
		{
			foreach (ACInputGroupInputMap data in base.List)
			{
				if (data.Equals(item))
				{
					 return true;
				}
			}
			return false;
		}

		public bool ContainsDeleted(ACInputGroupInputMap item)
		{
			foreach (ACInputGroupInputMap data in  this._deletedList)
			{
				if (data.Equals(item))
				{
					 return true;
				}
			}
			return false;
		}

		public new ACInputGroupInputMap this[int index]
		{
			get
			{
				return (ACInputGroupInputMap) base.List[index];
			}
			set
			{
				base.List[index] = value;
			}
		}

		public virtual Cheke.BusinessEntity.Result Save(SecurityToken token)
		{
			if (!this.IsDirty)
			{
				return new Result(true);
			}

			ACInputGroupInputMapDataCollection list = new ACInputGroupInputMapDataCollection(this);
			list.GetChanges();
			return ACInputGroupInputMapWrapper.Save(list, token);
		}

		public virtual Cheke.BusinessEntity.Result Save()
		{
			return this.Save(Cheke.Identity.Token);
		}

	}
	[Serializable]
	public class UsrAccountBRRuleCollection : UsrAccountBRRuleDataCollection, Cheke.BusinessEntity.IPersist
	{
		#region Constructors
		public UsrAccountBRRuleCollection()
		{
			base._itemType = typeof(UsrAccountBRRule);
		}

		public UsrAccountBRRuleCollection(UsrAccountBRRuleDataCollection list)
		{
			base._itemType = typeof(UsrAccountBRRule);
			foreach(UsrAccountBRRuleData item in list)
			{
				this.Add(new UsrAccountBRRule(item));
			}

			System.Collections.ArrayList deletedList = list.GetDeletedList();
			foreach(UsrAccountBRRuleData item in deletedList)
			{
				UsrAccountBRRule entity = new UsrAccountBRRule(item);
				this.Add(entity);
				this.Remove(entity);
			}
		}

		#endregion

		public void Add(UsrAccountBRRule obj)
		{
			base.List.Add(obj);
		}

		public void AddRange(UsrAccountBRRuleCollection list)
		{
			foreach(UsrAccountBRRule item in list)
			{
				this.Add(item);
			}
		}

		public void Remove(UsrAccountBRRule obj)
		{
			base.List.Remove(obj);
		}

		public void Insert(int index, UsrAccountBRRule obj)
		{
			 base.List.Insert(index, obj);
		}

		public bool Contains(UsrAccountBRRule item)
		{
			foreach (UsrAccountBRRule data in base.List)
			{
				if (data.Equals(item))
				{
					 return true;
				}
			}
			return false;
		}

		public bool ContainsDeleted(UsrAccountBRRule item)
		{
			foreach (UsrAccountBRRule data in  this._deletedList)
			{
				if (data.Equals(item))
				{
					 return true;
				}
			}
			return false;
		}

		public new UsrAccountBRRule this[int index]
		{
			get
			{
				return (UsrAccountBRRule) base.List[index];
			}
			set
			{
				base.List[index] = value;
			}
		}

		public virtual Cheke.BusinessEntity.Result Save(SecurityToken token)
		{
			if (!this.IsDirty)
			{
				return new Result(true);
			}

			UsrAccountBRRuleDataCollection list = new UsrAccountBRRuleDataCollection(this);
			list.GetChanges();
			return UsrAccountBRRuleWrapper.Save(list, token);
		}

		public virtual Cheke.BusinessEntity.Result Save()
		{
			return this.Save(Cheke.Identity.Token);
		}

	}
	[Serializable]
	public class UsrAccountTenantMapCollection : UsrAccountTenantMapDataCollection, Cheke.BusinessEntity.IPersist
	{
		#region Constructors
		public UsrAccountTenantMapCollection()
		{
			base._itemType = typeof(UsrAccountTenantMap);
		}

		public UsrAccountTenantMapCollection(UsrAccountTenantMapDataCollection list)
		{
			base._itemType = typeof(UsrAccountTenantMap);
			foreach(UsrAccountTenantMapData item in list)
			{
				this.Add(new UsrAccountTenantMap(item));
			}

			System.Collections.ArrayList deletedList = list.GetDeletedList();
			foreach(UsrAccountTenantMapData item in deletedList)
			{
				UsrAccountTenantMap entity = new UsrAccountTenantMap(item);
				this.Add(entity);
				this.Remove(entity);
			}
		}

		#endregion

		public void Add(UsrAccountTenantMap obj)
		{
			base.List.Add(obj);
		}

		public void AddRange(UsrAccountTenantMapCollection list)
		{
			foreach(UsrAccountTenantMap item in list)
			{
				this.Add(item);
			}
		}

		public void Remove(UsrAccountTenantMap obj)
		{
			base.List.Remove(obj);
		}

		public void Insert(int index, UsrAccountTenantMap obj)
		{
			 base.List.Insert(index, obj);
		}

		public bool Contains(UsrAccountTenantMap item)
		{
			foreach (UsrAccountTenantMap data in base.List)
			{
				if (data.Equals(item))
				{
					 return true;
				}
			}
			return false;
		}

		public bool ContainsDeleted(UsrAccountTenantMap item)
		{
			foreach (UsrAccountTenantMap data in  this._deletedList)
			{
				if (data.Equals(item))
				{
					 return true;
				}
			}
			return false;
		}

		public new UsrAccountTenantMap this[int index]
		{
			get
			{
				return (UsrAccountTenantMap) base.List[index];
			}
			set
			{
				base.List[index] = value;
			}
		}

		public virtual Cheke.BusinessEntity.Result Save(SecurityToken token)
		{
			if (!this.IsDirty)
			{
				return new Result(true);
			}

			UsrAccountTenantMapDataCollection list = new UsrAccountTenantMapDataCollection(this);
			list.GetChanges();
			return UsrAccountTenantMapWrapper.Save(list, token);
		}

		public virtual Cheke.BusinessEntity.Result Save()
		{
			return this.Save(Cheke.Identity.Token);
		}

	}
}
