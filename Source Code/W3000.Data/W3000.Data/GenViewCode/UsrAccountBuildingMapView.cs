using System;

namespace W3000.Data
{
	[Serializable]
	public partial class UsrAccountBuildingMapView
	{
		private System.Guid _usrAccountBuildingMapPK = Guid.Empty;
		private System.Guid _usrAccountPK = Guid.Empty;
		private System.Guid _bDBuildingPK = Guid.Empty;
		//private System.Boolean _buildingWide = false;
		//private System.DateTime _createdOn = new DateTime(1900, 1, 1);
		//private System.String _createdBy = string.Empty;
		//private System.DateTime _modifiedOn = new DateTime(1900, 1, 1);
		//private System.String _modifiedBy = string.Empty;
		//private System.Int16 _accessTC = 0;
		//private System.Int32 _permission = 0;
		//private System.Boolean _primary = false;
		private System.String _address1 = string.Empty;
		private System.Int32 _buildingID = 0;
		private System.String _userID = string.Empty;

		public System.Guid UsrAccountBuildingMapPK
		{
			get{ return this._usrAccountBuildingMapPK; }
			set{ this._usrAccountBuildingMapPK = value; }
		}

		public System.Guid UsrAccountPK
		{
			get{ return this._usrAccountPK; }
			set{ this._usrAccountPK = value; }
		}

		public System.Guid BDBuildingPK
		{
			get{ return this._bDBuildingPK; }
			set{ this._bDBuildingPK = value; }
		}

//		public System.Boolean BuildingWide
//		{
//			get{ return this._buildingWide; }
//			set{ this._buildingWide = value; }
//		}

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

//		public System.Int16 AccessTC
//		{
//			get{ return this._accessTC; }
//			set{ this._accessTC = value; }
//		}

//		public System.Int32 Permission
//		{
//			get{ return this._permission; }
//			set{ this._permission = value; }
//		}

//		public System.Boolean Primary
//		{
//			get{ return this._primary; }
//			set{ this._primary = value; }
//		}

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

		public System.String UserID
		{
			get{ return this._userID; }
			set{ this._userID = value; }
		}

		public UsrAccountBuildingMapView()
		{
		}

		public UsrAccountBuildingMapView(UsrAccountBuildingMapData data)
		{
			this.UsrAccountBuildingMapPK = data.UsrAccountBuildingMapPK;
			this.UsrAccountPK = data.UsrAccountPK;
			this.BDBuildingPK = data.BDBuildingPK;
			//this.BuildingWide = data.BuildingWide;
			//this.CreatedOn = data.CreatedOn;
			//this.CreatedBy = data.CreatedBy;
			//this.ModifiedOn = data.ModifiedOn;
			//this.ModifiedBy = data.ModifiedBy;
			//this.AccessTC = data.AccessTC;
			//this.Permission = data.Permission;
			//this.Primary = data.Primary;
			this.Address1 = data.Address1;
			this.BuildingID = data.BuildingID;
			this.UserID = data.UserID;
		}


		public UsrAccountBuildingMapData ToUsrAccountBuildingMapData()
		{
			UsrAccountBuildingMapData entity = new UsrAccountBuildingMapData();
			entity.UsrAccountBuildingMapPK = this.UsrAccountBuildingMapPK;
			entity.UsrAccountPK = this.UsrAccountPK;
			entity.BDBuildingPK = this.BDBuildingPK;
			//entity.BuildingWide = this.BuildingWide;
			//entity.CreatedOn = this.CreatedOn;
			//entity.CreatedBy = this.CreatedBy;
			//entity.ModifiedOn = this.ModifiedOn;
			//entity.ModifiedBy = this.ModifiedBy;
			//entity.AccessTC = this.AccessTC;
			//entity.Permission = this.Permission;
			//entity.Primary = this.Primary;
			entity.Address1 = this.Address1;
			entity.BuildingID = this.BuildingID;
			entity.UserID = this.UserID;

			return entity;
		}
	}
}
