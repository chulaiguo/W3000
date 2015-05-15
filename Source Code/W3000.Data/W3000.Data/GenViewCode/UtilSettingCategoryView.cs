using System;

namespace W3000.Data
{
	[Serializable]
	public partial class UtilSettingCategoryView
	{
		private System.Guid _utilSettingCategoryPK = Guid.Empty;
		private System.Int32 _settingCategoryID = 0;
		private System.String _settingCategory = string.Empty;
		private System.String _instanceName = string.Empty;
		//private System.DateTime _createdOn = new DateTime(1900, 1, 1);
		//private System.String _createdBy = string.Empty;
		//private System.DateTime _modifiedOn = new DateTime(1900, 1, 1);
		//private System.String _modifiedBy = string.Empty;
		//private System.Guid _bDBuildingPK = Guid.Empty;

		public System.Guid UtilSettingCategoryPK
		{
			get{ return this._utilSettingCategoryPK; }
			set{ this._utilSettingCategoryPK = value; }
		}

		public System.Int32 SettingCategoryID
		{
			get{ return this._settingCategoryID; }
			set{ this._settingCategoryID = value; }
		}

		public System.String SettingCategory
		{
			get{ return this._settingCategory; }
			set{ this._settingCategory = value; }
		}

		public System.String InstanceName
		{
			get{ return this._instanceName; }
			set{ this._instanceName = value; }
		}

//		public System.DateTime CreatedOn
//		{
//			get{ return this._createdOn.ToLocalTime(); }
//			set{ this._createdOn = value.ToUniversalTime(); }
//		}

//		public System.String CreatedBy
//		{
//			get{ return this._createdBy; }
//			set{ this._createdBy = value; }
//		}

//		public System.DateTime ModifiedOn
//		{
//			get{ return this._modifiedOn.ToLocalTime(); }
//			set{ this._modifiedOn = value.ToUniversalTime(); }
//		}

//		public System.String ModifiedBy
//		{
//			get{ return this._modifiedBy; }
//			set{ this._modifiedBy = value; }
//		}

//		public System.Guid BDBuildingPK
//		{
//			get{ return this._bDBuildingPK; }
//			set{ this._bDBuildingPK = value; }
//		}

		public UtilSettingCategoryView()
		{
		}

		public UtilSettingCategoryView(UtilSettingCategoryData data)
		{
			this.UtilSettingCategoryPK = data.UtilSettingCategoryPK;
			this.SettingCategoryID = data.SettingCategoryID;
			this.SettingCategory = data.SettingCategory;
			this.InstanceName = data.InstanceName;
			//this.CreatedOn = data.CreatedOn;
			//this.CreatedBy = data.CreatedBy;
			//this.ModifiedOn = data.ModifiedOn;
			//this.ModifiedBy = data.ModifiedBy;
			//this.BDBuildingPK = data.BDBuildingPK;
		}


		public UtilSettingCategoryData ToUtilSettingCategoryData()
		{
			UtilSettingCategoryData entity = new UtilSettingCategoryData();
			entity.UtilSettingCategoryPK = this.UtilSettingCategoryPK;
			entity.SettingCategoryID = this.SettingCategoryID;
			entity.SettingCategory = this.SettingCategory;
			entity.InstanceName = this.InstanceName;
			//entity.CreatedOn = this.CreatedOn;
			//entity.CreatedBy = this.CreatedBy;
			//entity.ModifiedOn = this.ModifiedOn;
			//entity.ModifiedBy = this.ModifiedBy;
			//entity.BDBuildingPK = this.BDBuildingPK;

			return entity;
		}
	}
}
