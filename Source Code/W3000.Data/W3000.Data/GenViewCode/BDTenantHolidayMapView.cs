using System;

namespace W3000.Data
{
	[Serializable]
	public partial class BDTenantHolidayMapView
	{
		private System.Guid _bDTenantHolidayMapPK = Guid.Empty;
		private System.Guid _bDTenantPK = Guid.Empty;
		private System.Guid _utilHolidayPK = Guid.Empty;
		//private System.Int32 _actionID = 0;
		//private System.String _notes = string.Empty;
		//private System.DateTime _createdOn = new DateTime(1900, 1, 1);
		//private System.String _createdBy = string.Empty;
		//private System.DateTime _modifiedOn = new DateTime(1900, 1, 1);
		//private System.String _modifiedBy = string.Empty;
		private System.String _tenant = string.Empty;
		private System.Guid _bDBuildingPK = Guid.Empty;
		private System.DateTime _date = new DateTime(1900, 1, 1);
		private System.String _holiday = string.Empty;
		private System.String _address1 = string.Empty;
		private System.Int32 _buildingID = 0;

		public System.Guid BDTenantHolidayMapPK
		{
			get{ return this._bDTenantHolidayMapPK; }
			set{ this._bDTenantHolidayMapPK = value; }
		}

		public System.Guid BDTenantPK
		{
			get{ return this._bDTenantPK; }
			set{ this._bDTenantPK = value; }
		}

		public System.Guid UtilHolidayPK
		{
			get{ return this._utilHolidayPK; }
			set{ this._utilHolidayPK = value; }
		}

//		public System.Int32 ActionID
//		{
//			get{ return this._actionID; }
//			set{ this._actionID = value; }
//		}

//		public System.String Notes
//		{
//			get{ return this._notes; }
//			set{ this._notes = value; }
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

		public System.DateTime Date
		{
			get{ return this._date.ToLocalTime(); }
			set{ this._date = value.ToUniversalTime(); }
		}

		public System.String Holiday
		{
			get{ return this._holiday; }
			set{ this._holiday = value; }
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

		public BDTenantHolidayMapView()
		{
		}

		public BDTenantHolidayMapView(BDTenantHolidayMapData data)
		{
			this.BDTenantHolidayMapPK = data.BDTenantHolidayMapPK;
			this.BDTenantPK = data.BDTenantPK;
			this.UtilHolidayPK = data.UtilHolidayPK;
			//this.ActionID = data.ActionID;
			//this.Notes = data.Notes;
			//this.CreatedOn = data.CreatedOn;
			//this.CreatedBy = data.CreatedBy;
			//this.ModifiedOn = data.ModifiedOn;
			//this.ModifiedBy = data.ModifiedBy;
			this.Tenant = data.Tenant;
			this.BDBuildingPK = data.BDBuildingPK;
			this.Date = data.Date;
			this.Holiday = data.Holiday;
			this.Address1 = data.Address1;
			this.BuildingID = data.BuildingID;
		}


		public BDTenantHolidayMapData ToBDTenantHolidayMapData()
		{
			BDTenantHolidayMapData entity = new BDTenantHolidayMapData();
			entity.BDTenantHolidayMapPK = this.BDTenantHolidayMapPK;
			entity.BDTenantPK = this.BDTenantPK;
			entity.UtilHolidayPK = this.UtilHolidayPK;
			//entity.ActionID = this.ActionID;
			//entity.Notes = this.Notes;
			//entity.CreatedOn = this.CreatedOn;
			//entity.CreatedBy = this.CreatedBy;
			//entity.ModifiedOn = this.ModifiedOn;
			//entity.ModifiedBy = this.ModifiedBy;
			entity.Tenant = this.Tenant;
			entity.BDBuildingPK = this.BDBuildingPK;
			entity.Date = this.Date;
			entity.Holiday = this.Holiday;
			entity.Address1 = this.Address1;
			entity.BuildingID = this.BuildingID;

			return entity;
		}
	}
}
