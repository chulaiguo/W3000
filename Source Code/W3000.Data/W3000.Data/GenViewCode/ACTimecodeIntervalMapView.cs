using System;

namespace W3000.Data
{
	[Serializable]
	public partial class ACTimecodeIntervalMapView
	{
		private System.Guid _aCTimecodeIntervalMapPK = Guid.Empty;
		private System.Guid _aCTimecodePK = Guid.Empty;
		private System.Guid _aCIntervalPK = Guid.Empty;
		//private System.DateTime _createdOn = new DateTime(1900, 1, 1);
		//private System.String _createdBy = string.Empty;
		//private System.DateTime _modifiedOn = new DateTime(1900, 1, 1);
		//private System.String _modifiedBy = string.Empty;
		//private System.String _end = string.Empty;
		//private System.String _begin = string.Empty;
		private System.Int16 _iVID = 0;
		private System.Guid _bDBuildingPK = Guid.Empty;
		private System.Int16 _tCID = 0;

		public System.Guid ACTimecodeIntervalMapPK
		{
			get{ return this._aCTimecodeIntervalMapPK; }
			set{ this._aCTimecodeIntervalMapPK = value; }
		}

		public System.Guid ACTimecodePK
		{
			get{ return this._aCTimecodePK; }
			set{ this._aCTimecodePK = value; }
		}

		public System.Guid ACIntervalPK
		{
			get{ return this._aCIntervalPK; }
			set{ this._aCIntervalPK = value; }
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

//		public System.String End
//		{
//			get{ return this._end; }
//			set{ this._end = value; }
//		}

//		public System.String Begin
//		{
//			get{ return this._begin; }
//			set{ this._begin = value; }
//		}

		public System.Int16 IVID
		{
			get{ return this._iVID; }
			set{ this._iVID = value; }
		}

		public System.Guid BDBuildingPK
		{
			get{ return this._bDBuildingPK; }
			set{ this._bDBuildingPK = value; }
		}

		public System.Int16 TCID
		{
			get{ return this._tCID; }
			set{ this._tCID = value; }
		}

		public ACTimecodeIntervalMapView()
		{
		}

		public ACTimecodeIntervalMapView(ACTimecodeIntervalMapData data)
		{
			this.ACTimecodeIntervalMapPK = data.ACTimecodeIntervalMapPK;
			this.ACTimecodePK = data.ACTimecodePK;
			this.ACIntervalPK = data.ACIntervalPK;
			//this.CreatedOn = data.CreatedOn;
			//this.CreatedBy = data.CreatedBy;
			//this.ModifiedOn = data.ModifiedOn;
			//this.ModifiedBy = data.ModifiedBy;
			//this.End = data.End;
			//this.Begin = data.Begin;
			this.IVID = data.IVID;
			this.BDBuildingPK = data.BDBuildingPK;
			this.TCID = data.TCID;
		}


		public ACTimecodeIntervalMapData ToACTimecodeIntervalMapData()
		{
			ACTimecodeIntervalMapData entity = new ACTimecodeIntervalMapData();
			entity.ACTimecodeIntervalMapPK = this.ACTimecodeIntervalMapPK;
			entity.ACTimecodePK = this.ACTimecodePK;
			entity.ACIntervalPK = this.ACIntervalPK;
			//entity.CreatedOn = this.CreatedOn;
			//entity.CreatedBy = this.CreatedBy;
			//entity.ModifiedOn = this.ModifiedOn;
			//entity.ModifiedBy = this.ModifiedBy;
			//entity.End = this.End;
			//entity.Begin = this.Begin;
			entity.IVID = this.IVID;
			entity.BDBuildingPK = this.BDBuildingPK;
			entity.TCID = this.TCID;

			return entity;
		}
	}
}
