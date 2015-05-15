using System;

namespace W3000.Data
{
	[Serializable]
	public partial class BDTenantView
	{
		private System.Guid _bDTenantPK = Guid.Empty;
		private System.Guid _bDBuildingPK = Guid.Empty;
		private System.String _tenant = string.Empty;
		private System.String _suite = string.Empty;
		//private System.String _phone = string.Empty;
		//private System.String _fax = string.Empty;
		//private System.Boolean _blocked = false;
		//private System.Boolean _federal = false;
		//private System.String _tentNotes = string.Empty;
		//private System.String _cardNotes = string.Empty;
		//private System.String _visitorNotes = string.Empty;
		//private System.Boolean _isManagement = false;
		//private System.String _type = string.Empty;
		//private System.Boolean _noRecycleCard = false;
		//private System.Int32 _systemTypeID = 0;
		//private System.DateTime _createdOn = new DateTime(1900, 1, 1);
		//private System.String _createdBy = string.Empty;
		//private System.DateTime _modifiedOn = new DateTime(1900, 1, 1);
		//private System.String _modifiedBy = string.Empty;
		//private System.String _parkingAccount = string.Empty;
		//private System.String _custInfo1 = string.Empty;
		//private System.String _custInfo2 = string.Empty;
		//private System.String _custInfo3 = string.Empty;
		//private System.String _custInfo4 = string.Empty;
		//private System.String _custInfo5 = string.Empty;
		//private System.String _custInfo6 = string.Empty;
		//private System.String _custInfo7 = string.Empty;
		//private System.String _custInfo8 = string.Empty;
		//private System.Boolean _delExpiredCard = false;
		//private System.Boolean _hotClient = false;
		//private System.DateTime _hotExpire = new DateTime(1900, 1, 1);
		//private System.String _email = string.Empty;
		private System.String _address1 = string.Empty;
		private System.Int32 _buildingID = 0;

		public System.Guid BDTenantPK
		{
			get{ return this._bDTenantPK; }
			set{ this._bDTenantPK = value; }
		}

		public System.Guid BDBuildingPK
		{
			get{ return this._bDBuildingPK; }
			set{ this._bDBuildingPK = value; }
		}

		public System.String Tenant
		{
			get{ return this._tenant; }
			set{ this._tenant = value; }
		}

		public System.String Suite
		{
			get{ return this._suite; }
			set{ this._suite = value; }
		}

//		public System.String Phone
//		{
//			get{ return this._phone; }
//			set{ this._phone = value; }
//		}

//		public System.String Fax
//		{
//			get{ return this._fax; }
//			set{ this._fax = value; }
//		}

//		public System.Boolean Blocked
//		{
//			get{ return this._blocked; }
//			set{ this._blocked = value; }
//		}

//		public System.Boolean Federal
//		{
//			get{ return this._federal; }
//			set{ this._federal = value; }
//		}

//		public System.String TentNotes
//		{
//			get{ return this._tentNotes; }
//			set{ this._tentNotes = value; }
//		}

//		public System.String CardNotes
//		{
//			get{ return this._cardNotes; }
//			set{ this._cardNotes = value; }
//		}

//		public System.String VisitorNotes
//		{
//			get{ return this._visitorNotes; }
//			set{ this._visitorNotes = value; }
//		}

//		public System.Boolean IsManagement
//		{
//			get{ return this._isManagement; }
//			set{ this._isManagement = value; }
//		}

//		public System.String Type
//		{
//			get{ return this._type; }
//			set{ this._type = value; }
//		}

//		public System.Boolean NoRecycleCard
//		{
//			get{ return this._noRecycleCard; }
//			set{ this._noRecycleCard = value; }
//		}

//		public System.Int32 SystemTypeID
//		{
//			get{ return this._systemTypeID; }
//			set{ this._systemTypeID = value; }
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

//		public System.String ParkingAccount
//		{
//			get{ return this._parkingAccount; }
//			set{ this._parkingAccount = value; }
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

//		public System.Boolean DelExpiredCard
//		{
//			get{ return this._delExpiredCard; }
//			set{ this._delExpiredCard = value; }
//		}

//		public System.Boolean HotClient
//		{
//			get{ return this._hotClient; }
//			set{ this._hotClient = value; }
//		}

//		public System.DateTime HotExpire
//		{
//			get{ return this._hotExpire.ToLocalTime(); }
//			set{ this._hotExpire = value.ToUniversalTime(); }
//		}

//		public System.String Email
//		{
//			get{ return this._email; }
//			set{ this._email = value; }
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

		public BDTenantView()
		{
		}

		public BDTenantView(BDTenantData data)
		{
			this.BDTenantPK = data.BDTenantPK;
			this.BDBuildingPK = data.BDBuildingPK;
			this.Tenant = data.Tenant;
			this.Suite = data.Suite;
			//this.Phone = data.Phone;
			//this.Fax = data.Fax;
			//this.Blocked = data.Blocked;
			//this.Federal = data.Federal;
			//this.TentNotes = data.TentNotes;
			//this.CardNotes = data.CardNotes;
			//this.VisitorNotes = data.VisitorNotes;
			//this.IsManagement = data.IsManagement;
			//this.Type = data.Type;
			//this.NoRecycleCard = data.NoRecycleCard;
			//this.SystemTypeID = data.SystemTypeID;
			//this.CreatedOn = data.CreatedOn;
			//this.CreatedBy = data.CreatedBy;
			//this.ModifiedOn = data.ModifiedOn;
			//this.ModifiedBy = data.ModifiedBy;
			//this.ParkingAccount = data.ParkingAccount;
			//this.CustInfo1 = data.CustInfo1;
			//this.CustInfo2 = data.CustInfo2;
			//this.CustInfo3 = data.CustInfo3;
			//this.CustInfo4 = data.CustInfo4;
			//this.CustInfo5 = data.CustInfo5;
			//this.CustInfo6 = data.CustInfo6;
			//this.CustInfo7 = data.CustInfo7;
			//this.CustInfo8 = data.CustInfo8;
			//this.DelExpiredCard = data.DelExpiredCard;
			//this.HotClient = data.HotClient;
			//this.HotExpire = data.HotExpire;
			//this.Email = data.Email;
			this.Address1 = data.Address1;
			this.BuildingID = data.BuildingID;
		}


		public BDTenantData ToBDTenantData()
		{
			BDTenantData entity = new BDTenantData();
			entity.BDTenantPK = this.BDTenantPK;
			entity.BDBuildingPK = this.BDBuildingPK;
			entity.Tenant = this.Tenant;
			entity.Suite = this.Suite;
			//entity.Phone = this.Phone;
			//entity.Fax = this.Fax;
			//entity.Blocked = this.Blocked;
			//entity.Federal = this.Federal;
			//entity.TentNotes = this.TentNotes;
			//entity.CardNotes = this.CardNotes;
			//entity.VisitorNotes = this.VisitorNotes;
			//entity.IsManagement = this.IsManagement;
			//entity.Type = this.Type;
			//entity.NoRecycleCard = this.NoRecycleCard;
			//entity.SystemTypeID = this.SystemTypeID;
			//entity.CreatedOn = this.CreatedOn;
			//entity.CreatedBy = this.CreatedBy;
			//entity.ModifiedOn = this.ModifiedOn;
			//entity.ModifiedBy = this.ModifiedBy;
			//entity.ParkingAccount = this.ParkingAccount;
			//entity.CustInfo1 = this.CustInfo1;
			//entity.CustInfo2 = this.CustInfo2;
			//entity.CustInfo3 = this.CustInfo3;
			//entity.CustInfo4 = this.CustInfo4;
			//entity.CustInfo5 = this.CustInfo5;
			//entity.CustInfo6 = this.CustInfo6;
			//entity.CustInfo7 = this.CustInfo7;
			//entity.CustInfo8 = this.CustInfo8;
			//entity.DelExpiredCard = this.DelExpiredCard;
			//entity.HotClient = this.HotClient;
			//entity.HotExpire = this.HotExpire;
			//entity.Email = this.Email;
			entity.Address1 = this.Address1;
			entity.BuildingID = this.BuildingID;

			return entity;
		}
	}
}
