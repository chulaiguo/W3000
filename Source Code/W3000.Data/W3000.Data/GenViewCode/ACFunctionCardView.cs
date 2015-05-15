using System;

namespace W3000.Data
{
	[Serializable]
	public partial class ACFunctionCardView
	{
		private System.Guid _aCFunctionCardPK = Guid.Empty;
		private System.Int32 _sitecode = 0;
		private System.Int32 _embossed = 0;
		private System.Int32 _encoded = 0;
		private System.Int32 _cardTypeID = 0;
		private System.Guid _bDTenantPK = Guid.Empty;
		//private System.Int32 _functionID = 0;
		//private System.String _firstName = string.Empty;
		//private System.String _lastName = string.Empty;
		//private System.Boolean _fIPS = false;
		//private System.Int32 _pin = 0;
		//private System.DateTime _validFrom = new DateTime(1900, 1, 1);
		//private System.DateTime _validThru = new DateTime(1900, 1, 1);
		//private System.DateTime _createdOn = new DateTime(1900, 1, 1);
		//private System.String _createdBy = string.Empty;
		//private System.DateTime _modifiedOn = new DateTime(1900, 1, 1);
		//private System.String _modifiedBy = string.Empty;
		private System.String _tenant = string.Empty;
		private System.Guid _bDBuildingPK = Guid.Empty;

		public System.Guid ACFunctionCardPK
		{
			get{ return this._aCFunctionCardPK; }
			set{ this._aCFunctionCardPK = value; }
		}

		public System.Int32 Sitecode
		{
			get{ return this._sitecode; }
			set{ this._sitecode = value; }
		}

		public System.Int32 Embossed
		{
			get{ return this._embossed; }
			set{ this._embossed = value; }
		}

		public System.Int32 Encoded
		{
			get{ return this._encoded; }
			set{ this._encoded = value; }
		}

		public System.Int32 CardTypeID
		{
			get{ return this._cardTypeID; }
			set{ this._cardTypeID = value; }
		}

		public System.Guid BDTenantPK
		{
			get{ return this._bDTenantPK; }
			set{ this._bDTenantPK = value; }
		}

//		public System.Int32 FunctionID
//		{
//			get{ return this._functionID; }
//			set{ this._functionID = value; }
//		}

//		public System.String FirstName
//		{
//			get{ return this._firstName; }
//			set{ this._firstName = value; }
//		}

//		public System.String LastName
//		{
//			get{ return this._lastName; }
//			set{ this._lastName = value; }
//		}

//		public System.Boolean FIPS
//		{
//			get{ return this._fIPS; }
//			set{ this._fIPS = value; }
//		}

//		public System.Int32 Pin
//		{
//			get{ return this._pin; }
//			set{ this._pin = value; }
//		}

//		public System.DateTime ValidFrom
//		{
//			get{ return this._validFrom.ToLocalTime(); }
//			set{ this._validFrom = value.ToUniversalTime(); }
//		}

//		public System.DateTime ValidThru
//		{
//			get{ return this._validThru.ToLocalTime(); }
//			set{ this._validThru = value.ToUniversalTime(); }
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

		public ACFunctionCardView()
		{
		}

		public ACFunctionCardView(ACFunctionCardData data)
		{
			this.ACFunctionCardPK = data.ACFunctionCardPK;
			this.Sitecode = data.Sitecode;
			this.Embossed = data.Embossed;
			this.Encoded = data.Encoded;
			this.CardTypeID = data.CardTypeID;
			this.BDTenantPK = data.BDTenantPK;
			//this.FunctionID = data.FunctionID;
			//this.FirstName = data.FirstName;
			//this.LastName = data.LastName;
			//this.FIPS = data.FIPS;
			//this.Pin = data.Pin;
			//this.ValidFrom = data.ValidFrom;
			//this.ValidThru = data.ValidThru;
			//this.CreatedOn = data.CreatedOn;
			//this.CreatedBy = data.CreatedBy;
			//this.ModifiedOn = data.ModifiedOn;
			//this.ModifiedBy = data.ModifiedBy;
			this.Tenant = data.Tenant;
			this.BDBuildingPK = data.BDBuildingPK;
		}


		public ACFunctionCardData ToACFunctionCardData()
		{
			ACFunctionCardData entity = new ACFunctionCardData();
			entity.ACFunctionCardPK = this.ACFunctionCardPK;
			entity.Sitecode = this.Sitecode;
			entity.Embossed = this.Embossed;
			entity.Encoded = this.Encoded;
			entity.CardTypeID = this.CardTypeID;
			entity.BDTenantPK = this.BDTenantPK;
			//entity.FunctionID = this.FunctionID;
			//entity.FirstName = this.FirstName;
			//entity.LastName = this.LastName;
			//entity.FIPS = this.FIPS;
			//entity.Pin = this.Pin;
			//entity.ValidFrom = this.ValidFrom;
			//entity.ValidThru = this.ValidThru;
			//entity.CreatedOn = this.CreatedOn;
			//entity.CreatedBy = this.CreatedBy;
			//entity.ModifiedOn = this.ModifiedOn;
			//entity.ModifiedBy = this.ModifiedBy;
			entity.Tenant = this.Tenant;
			entity.BDBuildingPK = this.BDBuildingPK;

			return entity;
		}
	}
}
