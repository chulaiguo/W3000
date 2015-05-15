using System;

namespace W3000.Data
{
	[Serializable]
	public partial class ACIntervalView
	{
		private System.Guid _aCIntervalPK = Guid.Empty;
		private System.Guid _bDBuildingPK = Guid.Empty;
		private System.Int16 _iVID = 0;
		//private System.String _begin = string.Empty;
		//private System.String _end = string.Empty;
		//private System.Boolean _sun = false;
		//private System.Boolean _mon = false;
		//private System.Boolean _tue = false;
		//private System.Boolean _wed = false;
		//private System.Boolean _thu = false;
		//private System.Boolean _fri = false;
		//private System.Boolean _sat = false;
		//private System.Boolean _hol = false;
		//private System.DateTime _createdOn = new DateTime(1900, 1, 1);
		//private System.String _createdBy = string.Empty;
		//private System.DateTime _modifiedOn = new DateTime(1900, 1, 1);
		//private System.String _modifiedBy = string.Empty;
		private System.String _address1 = string.Empty;
		private System.Int32 _buildingID = 0;

		public System.Guid ACIntervalPK
		{
			get{ return this._aCIntervalPK; }
			set{ this._aCIntervalPK = value; }
		}

		public System.Guid BDBuildingPK
		{
			get{ return this._bDBuildingPK; }
			set{ this._bDBuildingPK = value; }
		}

		public System.Int16 IVID
		{
			get{ return this._iVID; }
			set{ this._iVID = value; }
		}

//		public System.String Begin
//		{
//			get{ return this._begin; }
//			set{ this._begin = value; }
//		}

//		public System.String End
//		{
//			get{ return this._end; }
//			set{ this._end = value; }
//		}

//		public System.Boolean Sun
//		{
//			get{ return this._sun; }
//			set{ this._sun = value; }
//		}

//		public System.Boolean Mon
//		{
//			get{ return this._mon; }
//			set{ this._mon = value; }
//		}

//		public System.Boolean Tue
//		{
//			get{ return this._tue; }
//			set{ this._tue = value; }
//		}

//		public System.Boolean Wed
//		{
//			get{ return this._wed; }
//			set{ this._wed = value; }
//		}

//		public System.Boolean Thu
//		{
//			get{ return this._thu; }
//			set{ this._thu = value; }
//		}

//		public System.Boolean Fri
//		{
//			get{ return this._fri; }
//			set{ this._fri = value; }
//		}

//		public System.Boolean Sat
//		{
//			get{ return this._sat; }
//			set{ this._sat = value; }
//		}

//		public System.Boolean Hol
//		{
//			get{ return this._hol; }
//			set{ this._hol = value; }
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

		public ACIntervalView()
		{
		}

		public ACIntervalView(ACIntervalData data)
		{
			this.ACIntervalPK = data.ACIntervalPK;
			this.BDBuildingPK = data.BDBuildingPK;
			this.IVID = data.IVID;
			//this.Begin = data.Begin;
			//this.End = data.End;
			//this.Sun = data.Sun;
			//this.Mon = data.Mon;
			//this.Tue = data.Tue;
			//this.Wed = data.Wed;
			//this.Thu = data.Thu;
			//this.Fri = data.Fri;
			//this.Sat = data.Sat;
			//this.Hol = data.Hol;
			//this.CreatedOn = data.CreatedOn;
			//this.CreatedBy = data.CreatedBy;
			//this.ModifiedOn = data.ModifiedOn;
			//this.ModifiedBy = data.ModifiedBy;
			this.Address1 = data.Address1;
			this.BuildingID = data.BuildingID;
		}


		public ACIntervalData ToACIntervalData()
		{
			ACIntervalData entity = new ACIntervalData();
			entity.ACIntervalPK = this.ACIntervalPK;
			entity.BDBuildingPK = this.BDBuildingPK;
			entity.IVID = this.IVID;
			//entity.Begin = this.Begin;
			//entity.End = this.End;
			//entity.Sun = this.Sun;
			//entity.Mon = this.Mon;
			//entity.Tue = this.Tue;
			//entity.Wed = this.Wed;
			//entity.Thu = this.Thu;
			//entity.Fri = this.Fri;
			//entity.Sat = this.Sat;
			//entity.Hol = this.Hol;
			//entity.CreatedOn = this.CreatedOn;
			//entity.CreatedBy = this.CreatedBy;
			//entity.ModifiedOn = this.ModifiedOn;
			//entity.ModifiedBy = this.ModifiedBy;
			entity.Address1 = this.Address1;
			entity.BuildingID = this.BuildingID;

			return entity;
		}
	}
}
