using System;

namespace W3000.Data
{
	[Serializable]
	public partial class ACPanelHolidayMapView
	{
		private System.Guid _aCPanelHolidayMapPK = Guid.Empty;
		private System.Guid _aCPanelPK = Guid.Empty;
		private System.Guid _utilHolidayPK = Guid.Empty;
		//private System.DateTime _createdOn = new DateTime(1900, 1, 1);
		//private System.String _createdBy = string.Empty;
		//private System.DateTime _modifiedOn = new DateTime(1900, 1, 1);
		//private System.String _modifiedBy = string.Empty;
		private System.DateTime _date = new DateTime(1900, 1, 1);
		private System.String _holiday = string.Empty;
		private System.Guid _bDBuildingPK = Guid.Empty;
		private System.Int32 _unitID = 0;

		public System.Guid ACPanelHolidayMapPK
		{
			get{ return this._aCPanelHolidayMapPK; }
			set{ this._aCPanelHolidayMapPK = value; }
		}

		public System.Guid ACPanelPK
		{
			get{ return this._aCPanelPK; }
			set{ this._aCPanelPK = value; }
		}

		public System.Guid UtilHolidayPK
		{
			get{ return this._utilHolidayPK; }
			set{ this._utilHolidayPK = value; }
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

		public System.Guid BDBuildingPK
		{
			get{ return this._bDBuildingPK; }
			set{ this._bDBuildingPK = value; }
		}

		public System.Int32 UnitID
		{
			get{ return this._unitID; }
			set{ this._unitID = value; }
		}

		public ACPanelHolidayMapView()
		{
		}

		public ACPanelHolidayMapView(ACPanelHolidayMapData data)
		{
			this.ACPanelHolidayMapPK = data.ACPanelHolidayMapPK;
			this.ACPanelPK = data.ACPanelPK;
			this.UtilHolidayPK = data.UtilHolidayPK;
			//this.CreatedOn = data.CreatedOn;
			//this.CreatedBy = data.CreatedBy;
			//this.ModifiedOn = data.ModifiedOn;
			//this.ModifiedBy = data.ModifiedBy;
			this.Date = data.Date;
			this.Holiday = data.Holiday;
			this.BDBuildingPK = data.BDBuildingPK;
			this.UnitID = data.UnitID;
		}


		public ACPanelHolidayMapData ToACPanelHolidayMapData()
		{
			ACPanelHolidayMapData entity = new ACPanelHolidayMapData();
			entity.ACPanelHolidayMapPK = this.ACPanelHolidayMapPK;
			entity.ACPanelPK = this.ACPanelPK;
			entity.UtilHolidayPK = this.UtilHolidayPK;
			//entity.CreatedOn = this.CreatedOn;
			//entity.CreatedBy = this.CreatedBy;
			//entity.ModifiedOn = this.ModifiedOn;
			//entity.ModifiedBy = this.ModifiedBy;
			entity.Date = this.Date;
			entity.Holiday = this.Holiday;
			entity.BDBuildingPK = this.BDBuildingPK;
			entity.UnitID = this.UnitID;

			return entity;
		}
	}
}
