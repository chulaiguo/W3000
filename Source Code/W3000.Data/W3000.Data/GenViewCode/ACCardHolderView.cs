using System;

namespace W3000.Data
{
	[Serializable]
	public partial class ACCardHolderView
	{
		private System.Guid _aCCardHolderPK = Guid.Empty;
		private System.Int32 _sitecode = 0;
		private System.Int32 _embossed = 0;
		private System.Int32 _encoded = 0;
		private System.Int32 _cardTypeID = 0;
		//private System.String _firstName = string.Empty;
		//private System.String _lastName = string.Empty;
		//private System.DateTime _validFrom = new DateTime(1900, 1, 1);
		//private System.DateTime _validThru = new DateTime(1900, 1, 1);
		//private System.Boolean _fIPS = false;
		//private System.Int32 _pin = 0;
		private System.Guid _bDTenantPK = Guid.Empty;
		//private System.String _notes = string.Empty;
		//private System.String _eventNotifyEmail = string.Empty;
		//private System.Boolean _fireWarden = false;
		//private System.String _custInfo1 = string.Empty;
		//private System.String _custInfo2 = string.Empty;
		//private System.String _custInfo3 = string.Empty;
		//private System.String _custInfo4 = string.Empty;
		//private System.String _custInfo5 = string.Empty;
		//private System.String _custInfo6 = string.Empty;
		//private System.String _custInfo7 = string.Empty;
		//private System.String _custInfo8 = string.Empty;
		//private System.DateTime _createdOn = new DateTime(1900, 1, 1);
		//private System.String _createdBy = string.Empty;
		//private System.DateTime _modifiedOn = new DateTime(1900, 1, 1);
		//private System.String _modifiedBy = string.Empty;
		private System.String _tenant = string.Empty;
		private System.Guid _bDBuildingPK = Guid.Empty;

		public System.Guid ACCardHolderPK
		{
			get{ return this._aCCardHolderPK; }
			set{ this._aCCardHolderPK = value; }
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

		public System.Guid BDTenantPK
		{
			get{ return this._bDTenantPK; }
			set{ this._bDTenantPK = value; }
		}

//		public System.String Notes
//		{
//			get{ return this._notes; }
//			set{ this._notes = value; }
//		}

//		public System.String EventNotifyEmail
//		{
//			get{ return this._eventNotifyEmail; }
//			set{ this._eventNotifyEmail = value; }
//		}

//		public System.Boolean FireWarden
//		{
//			get{ return this._fireWarden; }
//			set{ this._fireWarden = value; }
//		}

//		public System.String CustInfo1
//		{
//			get{ return this._custInfo1; }
//			set{ this._custInfo1 = value; }
//		}

//		public System.String CustInfo2
//		{
//			get{ return this._custInfo2; }
//			set{ this._custInfo2 = value; }
//		}

//		public System.String CustInfo3
//		{
//			get{ return this._custInfo3; }
//			set{ this._custInfo3 = value; }
//		}

//		public System.String CustInfo4
//		{
//			get{ return this._custInfo4; }
//			set{ this._custInfo4 = value; }
//		}

//		public System.String CustInfo5
//		{
//			get{ return this._custInfo5; }
//			set{ this._custInfo5 = value; }
//		}

//		public System.String CustInfo6
//		{
//			get{ return this._custInfo6; }
//			set{ this._custInfo6 = value; }
//		}

//		public System.String CustInfo7
//		{
//			get{ return this._custInfo7; }
//			set{ this._custInfo7 = value; }
//		}

//		public System.String CustInfo8
//		{
//			get{ return this._custInfo8; }
//			set{ this._custInfo8 = value; }
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

		public ACCardHolderView()
		{
		}

		public ACCardHolderView(ACCardHolderData data)
		{
			this.ACCardHolderPK = data.ACCardHolderPK;
			this.Sitecode = data.Sitecode;
			this.Embossed = data.Embossed;
			this.Encoded = data.Encoded;
			this.CardTypeID = data.CardTypeID;
			//this.FirstName = data.FirstName;
			//this.LastName = data.LastName;
			//this.ValidFrom = data.ValidFrom;
			//this.ValidThru = data.ValidThru;
			//this.FIPS = data.FIPS;
			//this.Pin = data.Pin;
			this.BDTenantPK = data.BDTenantPK;
			//this.Notes = data.Notes;
			//this.EventNotifyEmail = data.EventNotifyEmail;
			//this.FireWarden = data.FireWarden;
			//this.CustInfo1 = data.CustInfo1;
			//this.CustInfo2 = data.CustInfo2;
			//this.CustInfo3 = data.CustInfo3;
			//this.CustInfo4 = data.CustInfo4;
			//this.CustInfo5 = data.CustInfo5;
			//this.CustInfo6 = data.CustInfo6;
			//this.CustInfo7 = data.CustInfo7;
			//this.CustInfo8 = data.CustInfo8;
			//this.CreatedOn = data.CreatedOn;
			//this.CreatedBy = data.CreatedBy;
			//this.ModifiedOn = data.ModifiedOn;
			//this.ModifiedBy = data.ModifiedBy;
			this.Tenant = data.Tenant;
			this.BDBuildingPK = data.BDBuildingPK;
		}


		public ACCardHolderData ToACCardHolderData()
		{
			ACCardHolderData entity = new ACCardHolderData();
			entity.ACCardHolderPK = this.ACCardHolderPK;
			entity.Sitecode = this.Sitecode;
			entity.Embossed = this.Embossed;
			entity.Encoded = this.Encoded;
			entity.CardTypeID = this.CardTypeID;
			//entity.FirstName = this.FirstName;
			//entity.LastName = this.LastName;
			//entity.ValidFrom = this.ValidFrom;
			//entity.ValidThru = this.ValidThru;
			//entity.FIPS = this.FIPS;
			//entity.Pin = this.Pin;
			entity.BDTenantPK = this.BDTenantPK;
			//entity.Notes = this.Notes;
			//entity.EventNotifyEmail = this.EventNotifyEmail;
			//entity.FireWarden = this.FireWarden;
			//entity.CustInfo1 = this.CustInfo1;
			//entity.CustInfo2 = this.CustInfo2;
			//entity.CustInfo3 = this.CustInfo3;
			//entity.CustInfo4 = this.CustInfo4;
			//entity.CustInfo5 = this.CustInfo5;
			//entity.CustInfo6 = this.CustInfo6;
			//entity.CustInfo7 = this.CustInfo7;
			//entity.CustInfo8 = this.CustInfo8;
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
