using System;

namespace W3000.Data
{
	[Serializable]
	public partial class BDBuildingHolidayMapView
	{
		private System.Guid _bDBuildingHolidayMapPK = Guid.Empty;
		private System.Guid _bDBuildingPK = Guid.Empty;
		private System.Guid _utilHolidayPK = Guid.Empty;
		//private System.Int32 _actionID = 0;
		//private System.String _notes = string.Empty;
		//private System.DateTime _createdOn = new DateTime(1900, 1, 1);
		//private System.String _createdBy = string.Empty;
		//private System.DateTime _modifiedOn = new DateTime(1900, 1, 1);
		//private System.String _modifiedBy = string.Empty;
		private System.String _address1 = string.Empty;
		private System.Int32 _buildingID = 0;
		private System.DateTime _date = new DateTime(1900, 1, 1);
		private System.String _holiday = string.Empty;

		public System.Guid BDBuildingHolidayMapPK
		{
			get{ return this._bDBuildingHolidayMapPK; }
			set{ this._bDBuildingHolidayMapPK = value; }
		}

		public System.Guid BDBuildingPK
		{
			get{ return this._bDBuildingPK; }
			set{ this._bDBuildingPK = value; }
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

		public BDBuildingHolidayMapView()
		{
		}

		public BDBuildingHolidayMapView(BDBuildingHolidayMapData data)
		{
			this.BDBuildingHolidayMapPK = data.BDBuildingHolidayMapPK;
			this.BDBuildingPK = data.BDBuildingPK;
			this.UtilHolidayPK = data.UtilHolidayPK;
			//this.ActionID = data.ActionID;
			//this.Notes = data.Notes;
			//this.CreatedOn = data.CreatedOn;
			//this.CreatedBy = data.CreatedBy;
			//this.ModifiedOn = data.ModifiedOn;
			//this.ModifiedBy = data.ModifiedBy;
			this.Address1 = data.Address1;
			this.BuildingID = data.BuildingID;
			this.Date = data.Date;
			this.Holiday = data.Holiday;
		}


		public BDBuildingHolidayMapData ToBDBuildingHolidayMapData()
		{
			BDBuildingHolidayMapData entity = new BDBuildingHolidayMapData();
			entity.BDBuildingHolidayMapPK = this.BDBuildingHolidayMapPK;
			entity.BDBuildingPK = this.BDBuildingPK;
			entity.UtilHolidayPK = this.UtilHolidayPK;
			//entity.ActionID = this.ActionID;
			//entity.Notes = this.Notes;
			//entity.CreatedOn = this.CreatedOn;
			//entity.CreatedBy = this.CreatedBy;
			//entity.ModifiedOn = this.ModifiedOn;
			//entity.ModifiedBy = this.ModifiedBy;
			entity.Address1 = this.Address1;
			entity.BuildingID = this.BuildingID;
			entity.Date = this.Date;
			entity.Holiday = this.Holiday;

			return entity;
		}
	}
}
