using System;

namespace W3000.Data
{
	[Serializable]
	public partial class ACMasterCardView
	{
		private System.Guid _aCMasterCardPK = Guid.Empty;
		private System.Int32 _sitecode = 0;
		private System.Int32 _embossed = 0;
		private System.Int32 _encoded = 0;
		private System.Int32 _cardTypeID = 0;
		//private System.String _firstName = string.Empty;
		//private System.String _lastName = string.Empty;
		//private System.Boolean _fIPS = false;
		//private System.Int32 _pin = 0;
		//private System.DateTime _createdOn = new DateTime(1900, 1, 1);
		//private System.String _createdBy = string.Empty;
		//private System.DateTime _modifiedOn = new DateTime(1900, 1, 1);
		//private System.String _modifiedBy = string.Empty;

		public System.Guid ACMasterCardPK
		{
			get{ return this._aCMasterCardPK; }
			set{ this._aCMasterCardPK = value; }
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

		public ACMasterCardView()
		{
		}

		public ACMasterCardView(ACMasterCardData data)
		{
			this.ACMasterCardPK = data.ACMasterCardPK;
			this.Sitecode = data.Sitecode;
			this.Embossed = data.Embossed;
			this.Encoded = data.Encoded;
			this.CardTypeID = data.CardTypeID;
			//this.FirstName = data.FirstName;
			//this.LastName = data.LastName;
			//this.FIPS = data.FIPS;
			//this.Pin = data.Pin;
			//this.CreatedOn = data.CreatedOn;
			//this.CreatedBy = data.CreatedBy;
			//this.ModifiedOn = data.ModifiedOn;
			//this.ModifiedBy = data.ModifiedBy;
		}


		public ACMasterCardData ToACMasterCardData()
		{
			ACMasterCardData entity = new ACMasterCardData();
			entity.ACMasterCardPK = this.ACMasterCardPK;
			entity.Sitecode = this.Sitecode;
			entity.Embossed = this.Embossed;
			entity.Encoded = this.Encoded;
			entity.CardTypeID = this.CardTypeID;
			//entity.FirstName = this.FirstName;
			//entity.LastName = this.LastName;
			//entity.FIPS = this.FIPS;
			//entity.Pin = this.Pin;
			//entity.CreatedOn = this.CreatedOn;
			//entity.CreatedBy = this.CreatedBy;
			//entity.ModifiedOn = this.ModifiedOn;
			//entity.ModifiedBy = this.ModifiedBy;

			return entity;
		}
	}
}
