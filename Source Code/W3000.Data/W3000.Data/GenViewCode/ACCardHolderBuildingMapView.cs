using System;

namespace W3000.Data
{
	[Serializable]
	public partial class ACCardHolderBuildingMapView
	{
		private System.Guid _aCCardHolderBuildingMapPK = Guid.Empty;
		private System.Guid _aCCardHolderPK = Guid.Empty;
		private System.Guid _bDBuildingPK = Guid.Empty;
		//private System.Int16 _aL1st = 0;
		//private System.Int16 _aL2nd = 0;
		//private System.DateTime _createdOn = new DateTime(1900, 1, 1);
		//private System.String _createdBy = string.Empty;
		//private System.DateTime _modifiedOn = new DateTime(1900, 1, 1);
		//private System.String _modifiedBy = string.Empty;
		private System.String _address1 = string.Empty;
		private System.Int32 _buildingID = 0;
		//private System.String _lastName = string.Empty;
		//private System.String _firstName = string.Empty;
		private System.Int32 _encoded = 0;
		private System.Int32 _embossed = 0;
		private System.Int32 _sitecode = 0;

		public System.Guid ACCardHolderBuildingMapPK
		{
			get{ return this._aCCardHolderBuildingMapPK; }
			set{ this._aCCardHolderBuildingMapPK = value; }
		}

		public System.Guid ACCardHolderPK
		{
			get{ return this._aCCardHolderPK; }
			set{ this._aCCardHolderPK = value; }
		}

		public System.Guid BDBuildingPK
		{
			get{ return this._bDBuildingPK; }
			set{ this._bDBuildingPK = value; }
		}

//		public System.Int16 AL1st
//		{
//			get{ return this._aL1st; }
//			set{ this._aL1st = value; }
//		}

//		public System.Int16 AL2nd
//		{
//			get{ return this._aL2nd; }
//			set{ this._aL2nd = value; }
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

//		public System.String LastName
//		{
//			get{ return this._lastName; }
//			set{ this._lastName = value; }
//		}

//		public System.String FirstName
//		{
//			get{ return this._firstName; }
//			set{ this._firstName = value; }
//		}

		public System.Int32 Encoded
		{
			get{ return this._encoded; }
			set{ this._encoded = value; }
		}

		public System.Int32 Embossed
		{
			get{ return this._embossed; }
			set{ this._embossed = value; }
		}

		public System.Int32 Sitecode
		{
			get{ return this._sitecode; }
			set{ this._sitecode = value; }
		}

		public ACCardHolderBuildingMapView()
		{
		}

		public ACCardHolderBuildingMapView(ACCardHolderBuildingMapData data)
		{
			this.ACCardHolderBuildingMapPK = data.ACCardHolderBuildingMapPK;
			this.ACCardHolderPK = data.ACCardHolderPK;
			this.BDBuildingPK = data.BDBuildingPK;
			//this.AL1st = data.AL1st;
			//this.AL2nd = data.AL2nd;
			//this.CreatedOn = data.CreatedOn;
			//this.CreatedBy = data.CreatedBy;
			//this.ModifiedOn = data.ModifiedOn;
			//this.ModifiedBy = data.ModifiedBy;
			this.Address1 = data.Address1;
			this.BuildingID = data.BuildingID;
			//this.LastName = data.LastName;
			//this.FirstName = data.FirstName;
			this.Encoded = data.Encoded;
			this.Embossed = data.Embossed;
			this.Sitecode = data.Sitecode;
		}


		public ACCardHolderBuildingMapData ToACCardHolderBuildingMapData()
		{
			ACCardHolderBuildingMapData entity = new ACCardHolderBuildingMapData();
			entity.ACCardHolderBuildingMapPK = this.ACCardHolderBuildingMapPK;
			entity.ACCardHolderPK = this.ACCardHolderPK;
			entity.BDBuildingPK = this.BDBuildingPK;
			//entity.AL1st = this.AL1st;
			//entity.AL2nd = this.AL2nd;
			//entity.CreatedOn = this.CreatedOn;
			//entity.CreatedBy = this.CreatedBy;
			//entity.ModifiedOn = this.ModifiedOn;
			//entity.ModifiedBy = this.ModifiedBy;
			entity.Address1 = this.Address1;
			entity.BuildingID = this.BuildingID;
			//entity.LastName = this.LastName;
			//entity.FirstName = this.FirstName;
			entity.Encoded = this.Encoded;
			entity.Embossed = this.Embossed;
			entity.Sitecode = this.Sitecode;

			return entity;
		}
	}
}
