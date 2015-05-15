using System;

namespace W3000.Data
{
	[Serializable]
	public partial class ACTimecodeView
	{
		private System.Guid _aCTimecodePK = Guid.Empty;
		private System.Guid _bDBuildingPK = Guid.Empty;
		private System.Int16 _tCID = 0;
		private System.String _summary = string.Empty;
		//private System.String _notes = string.Empty;
		//private System.DateTime _createdOn = new DateTime(1900, 1, 1);
		//private System.String _createdBy = string.Empty;
		//private System.DateTime _modifiedOn = new DateTime(1900, 1, 1);
		//private System.String _modifiedBy = string.Empty;
		private System.String _address1 = string.Empty;
		private System.Int32 _buildingID = 0;

		public System.Guid ACTimecodePK
		{
			get{ return this._aCTimecodePK; }
			set{ this._aCTimecodePK = value; }
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

		public System.String Summary
		{
			get{ return this._summary; }
			set{ this._summary = value; }
		}

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

		public ACTimecodeView()
		{
		}

		public ACTimecodeView(ACTimecodeData data)
		{
			this.ACTimecodePK = data.ACTimecodePK;
			this.BDBuildingPK = data.BDBuildingPK;
			this.TCID = data.TCID;
			this.Summary = data.Summary;
			//this.Notes = data.Notes;
			//this.CreatedOn = data.CreatedOn;
			//this.CreatedBy = data.CreatedBy;
			//this.ModifiedOn = data.ModifiedOn;
			//this.ModifiedBy = data.ModifiedBy;
			this.Address1 = data.Address1;
			this.BuildingID = data.BuildingID;
		}


		public ACTimecodeData ToACTimecodeData()
		{
			ACTimecodeData entity = new ACTimecodeData();
			entity.ACTimecodePK = this.ACTimecodePK;
			entity.BDBuildingPK = this.BDBuildingPK;
			entity.TCID = this.TCID;
			entity.Summary = this.Summary;
			//entity.Notes = this.Notes;
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
