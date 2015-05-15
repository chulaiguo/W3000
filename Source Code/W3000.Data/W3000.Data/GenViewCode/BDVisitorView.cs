using System;

namespace W3000.Data
{
	[Serializable]
	public partial class BDVisitorView
	{
		private System.Guid _bDVisitorPK = Guid.Empty;
		private System.Guid _bDTenantPK = Guid.Empty;
		//private System.String _firstName = string.Empty;
		//private System.String _lastName = string.Empty;
		//private System.String _authorizedBy = string.Empty;
		//private System.String _authorizedArea = string.Empty;
		//private System.String _authorEmail = string.Empty;
		//private System.Boolean _emailNotify = false;
		//private System.DateTime _validFrom = new DateTime(1900, 1, 1);
		//private System.DateTime _validThru = new DateTime(1900, 1, 1);
		//private System.String _password = string.Empty;
		//private System.String _special = string.Empty;
		//private System.String _begin = string.Empty;
		//private System.String _end = string.Empty;
		//private System.Int32 _siteCode = 0;
		//private System.Int32 _encoded = 0;
		//private System.Boolean _scheduled = false;
		//private System.DateTime _arrivedTime = new DateTime(1900, 1, 1);
		//private System.Int64 _turnstileAccess = 0;
		//private System.Boolean _badgePrinted = false;
		//private System.DateTime _createdOn = new DateTime(1900, 1, 1);
		//private System.String _createdBy = string.Empty;
		//private System.DateTime _modifiedOn = new DateTime(1900, 1, 1);
		//private System.String _modifiedBy = string.Empty;
		private System.String _tenant = string.Empty;
		private System.Guid _bDBuildingPK = Guid.Empty;
		private System.String _address1 = string.Empty;
		private System.Int32 _buildingID = 0;

		public System.Guid BDVisitorPK
		{
			get{ return this._bDVisitorPK; }
			set{ this._bDVisitorPK = value; }
		}

		public System.Guid BDTenantPK
		{
			get{ return this._bDTenantPK; }
			set{ this._bDTenantPK = value; }
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

//		public System.String AuthorizedBy
//		{
//			get{ return this._authorizedBy; }
//			set{ this._authorizedBy = value; }
//		}

//		public System.String AuthorizedArea
//		{
//			get{ return this._authorizedArea; }
//			set{ this._authorizedArea = value; }
//		}

//		public System.String AuthorEmail
//		{
//			get{ return this._authorEmail; }
//			set{ this._authorEmail = value; }
//		}

//		public System.Boolean EmailNotify
//		{
//			get{ return this._emailNotify; }
//			set{ this._emailNotify = value; }
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

//		public System.String Password
//		{
//			get{ return this._password; }
//			set{ this._password = value; }
//		}

//		public System.String Special
//		{
//			get{ return this._special; }
//			set{ this._special = value; }
//		}

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

//		public System.Int32 SiteCode
//		{
//			get{ return this._siteCode; }
//			set{ this._siteCode = value; }
//		}

//		public System.Int32 Encoded
//		{
//			get{ return this._encoded; }
//			set{ this._encoded = value; }
//		}

//		public System.Boolean Scheduled
//		{
//			get{ return this._scheduled; }
//			set{ this._scheduled = value; }
//		}

//		public System.DateTime ArrivedTime
//		{
//			get{ return this._arrivedTime.ToLocalTime(); }
//			set{ this._arrivedTime = value.ToUniversalTime(); }
//		}

//		public System.Int64 TurnstileAccess
//		{
//			get{ return this._turnstileAccess; }
//			set{ this._turnstileAccess = value; }
//		}

//		public System.Boolean BadgePrinted
//		{
//			get{ return this._badgePrinted; }
//			set{ this._badgePrinted = value; }
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

		public BDVisitorView()
		{
		}

		public BDVisitorView(BDVisitorData data)
		{
			this.BDVisitorPK = data.BDVisitorPK;
			this.BDTenantPK = data.BDTenantPK;
			//this.FirstName = data.FirstName;
			//this.LastName = data.LastName;
			//this.AuthorizedBy = data.AuthorizedBy;
			//this.AuthorizedArea = data.AuthorizedArea;
			//this.AuthorEmail = data.AuthorEmail;
			//this.EmailNotify = data.EmailNotify;
			//this.ValidFrom = data.ValidFrom;
			//this.ValidThru = data.ValidThru;
			//this.Password = data.Password;
			//this.Special = data.Special;
			//this.Begin = data.Begin;
			//this.End = data.End;
			//this.SiteCode = data.SiteCode;
			//this.Encoded = data.Encoded;
			//this.Scheduled = data.Scheduled;
			//this.ArrivedTime = data.ArrivedTime;
			//this.TurnstileAccess = data.TurnstileAccess;
			//this.BadgePrinted = data.BadgePrinted;
			//this.CreatedOn = data.CreatedOn;
			//this.CreatedBy = data.CreatedBy;
			//this.ModifiedOn = data.ModifiedOn;
			//this.ModifiedBy = data.ModifiedBy;
			this.Tenant = data.Tenant;
			this.BDBuildingPK = data.BDBuildingPK;
			this.Address1 = data.Address1;
			this.BuildingID = data.BuildingID;
		}


		public BDVisitorData ToBDVisitorData()
		{
			BDVisitorData entity = new BDVisitorData();
			entity.BDVisitorPK = this.BDVisitorPK;
			entity.BDTenantPK = this.BDTenantPK;
			//entity.FirstName = this.FirstName;
			//entity.LastName = this.LastName;
			//entity.AuthorizedBy = this.AuthorizedBy;
			//entity.AuthorizedArea = this.AuthorizedArea;
			//entity.AuthorEmail = this.AuthorEmail;
			//entity.EmailNotify = this.EmailNotify;
			//entity.ValidFrom = this.ValidFrom;
			//entity.ValidThru = this.ValidThru;
			//entity.Password = this.Password;
			//entity.Special = this.Special;
			//entity.Begin = this.Begin;
			//entity.End = this.End;
			//entity.SiteCode = this.SiteCode;
			//entity.Encoded = this.Encoded;
			//entity.Scheduled = this.Scheduled;
			//entity.ArrivedTime = this.ArrivedTime;
			//entity.TurnstileAccess = this.TurnstileAccess;
			//entity.BadgePrinted = this.BadgePrinted;
			//entity.CreatedOn = this.CreatedOn;
			//entity.CreatedBy = this.CreatedBy;
			//entity.ModifiedOn = this.ModifiedOn;
			//entity.ModifiedBy = this.ModifiedBy;
			entity.Tenant = this.Tenant;
			entity.BDBuildingPK = this.BDBuildingPK;
			entity.Address1 = this.Address1;
			entity.BuildingID = this.BuildingID;

			return entity;
		}
	}
}
