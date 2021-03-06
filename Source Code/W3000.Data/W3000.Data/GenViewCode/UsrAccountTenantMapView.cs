using System;

namespace W3000.Data
{
	[Serializable]
	public partial class UsrAccountTenantMapView
	{
		private System.Guid _usrAccountTenantMapPK = Guid.Empty;
		private System.Guid _usrAccountPK = Guid.Empty;
		private System.Guid _bDTenantPK = Guid.Empty;
		//private System.DateTime _createdOn = new DateTime(1900, 1, 1);
		//private System.String _createdBy = string.Empty;
		//private System.DateTime _modifiedOn = new DateTime(1900, 1, 1);
		//private System.String _modifiedBy = string.Empty;
		private System.String _tenant = string.Empty;
		private System.Guid _bDBuildingPK = Guid.Empty;
		private System.String _userID = string.Empty;
		private System.String _address1 = string.Empty;
		private System.Int32 _buildingID = 0;

		public System.Guid UsrAccountTenantMapPK
		{
			get{ return this._usrAccountTenantMapPK; }
			set{ this._usrAccountTenantMapPK = value; }
		}

		public System.Guid UsrAccountPK
		{
			get{ return this._usrAccountPK; }
			set{ this._usrAccountPK = value; }
		}

		public System.Guid BDTenantPK
		{
			get{ return this._bDTenantPK; }
			set{ this._bDTenantPK = value; }
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

		public System.String Tenant
		{
			get{ return this._tenant; }
			set{ this._tenant = value; }
		}

		public System.Guid BDBuildingPK
		{
			get{ return this._bDBuildingPK; }
			set{ this._bDBuildingPK = value; }
		}

		public System.String UserID
		{
			get{ return this._userID; }
			set{ this._userID = value; }
		}

		public System.String Address1
		{
			get{ return this._address1; }
			set{ this._address1 = value; }
		}

		public System.Int32 BuildingID
		{
			get{ return this._buildingID; }
			set{ this._buildingID = value; }
		}

		public UsrAccountTenantMapView()
		{
		}

		public UsrAccountTenantMapView(UsrAccountTenantMapData data)
		{
			this.UsrAccountTenantMapPK = data.UsrAccountTenantMapPK;
			this.UsrAccountPK = data.UsrAccountPK;
			this.BDTenantPK = data.BDTenantPK;
			//this.CreatedOn = data.CreatedOn;
			//this.CreatedBy = data.CreatedBy;
			//this.ModifiedOn = data.ModifiedOn;
			//this.ModifiedBy = data.ModifiedBy;
			this.Tenant = data.Tenant;
			this.BDBuildingPK = data.BDBuildingPK;
			this.UserID = data.UserID;
			this.Address1 = data.Address1;
			this.BuildingID = data.BuildingID;
		}


		public UsrAccountTenantMapData ToUsrAccountTenantMapData()
		{
			UsrAccountTenantMapData entity = new UsrAccountTenantMapData();
			entity.UsrAccountTenantMapPK = this.UsrAccountTenantMapPK;
			entity.UsrAccountPK = this.UsrAccountPK;
			entity.BDTenantPK = this.BDTenantPK;
			//entity.CreatedOn = this.CreatedOn;
			//entity.CreatedBy = this.CreatedBy;
			//entity.ModifiedOn = this.ModifiedOn;
			//entity.ModifiedBy = this.ModifiedBy;
			entity.Tenant = this.Tenant;
			entity.BDBuildingPK = this.BDBuildingPK;
			entity.UserID = this.UserID;
			entity.Address1 = this.Address1;
			entity.BuildingID = this.BuildingID;

			return entity;
		}
	}
}
