using System;

namespace W3000.Data
{
	[Serializable]
	public partial class ACIntvalHolidayMapView
	{
		private System.Guid _aCIntvalHolidayMapPK = Guid.Empty;
		private System.Guid _aCIntervalPK = Guid.Empty;
		private System.Guid _utilHolidayPK = Guid.Empty;
		//private System.DateTime _createdOn = new DateTime(1900, 1, 1);
		//private System.String _createdBy = string.Empty;
		//private System.DateTime _modifiedOn = new DateTime(1900, 1, 1);
		//private System.String _modifiedBy = string.Empty;
		private System.Guid _bDBuildingPK = Guid.Empty;
		private System.DateTime _date = new DateTime(1900, 1, 1);
		private System.String _holiday = string.Empty;

		public System.Guid ACIntvalHolidayMapPK
		{
			get{ return this._aCIntvalHolidayMapPK; }
			set{ this._aCIntvalHolidayMapPK = value; }
		}

		public System.Guid ACIntervalPK
		{
			get{ return this._aCIntervalPK; }
			set{ this._aCIntervalPK = value; }
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

		public ACIntvalHolidayMapView()
		{
		}

		public ACIntvalHolidayMapView(ACIntvalHolidayMapData data)
		{
			this.ACIntvalHolidayMapPK = data.ACIntvalHolidayMapPK;
			this.ACIntervalPK = data.ACIntervalPK;
			this.UtilHolidayPK = data.UtilHolidayPK;
			//this.CreatedOn = data.CreatedOn;
			//this.CreatedBy = data.CreatedBy;
			//this.ModifiedOn = data.ModifiedOn;
			//this.ModifiedBy = data.ModifiedBy;
			this.BDBuildingPK = data.BDBuildingPK;
			this.Date = data.Date;
			this.Holiday = data.Holiday;
		}


		public ACIntvalHolidayMapData ToACIntvalHolidayMapData()
		{
			ACIntvalHolidayMapData entity = new ACIntvalHolidayMapData();
			entity.ACIntvalHolidayMapPK = this.ACIntvalHolidayMapPK;
			entity.ACIntervalPK = this.ACIntervalPK;
			entity.UtilHolidayPK = this.UtilHolidayPK;
			//entity.CreatedOn = this.CreatedOn;
			//entity.CreatedBy = this.CreatedBy;
			//entity.ModifiedOn = this.ModifiedOn;
			//entity.ModifiedBy = this.ModifiedBy;
			entity.BDBuildingPK = this.BDBuildingPK;
			entity.Date = this.Date;
			entity.Holiday = this.Holiday;

			return entity;
		}
	}
}
