using System;

namespace W3000.Data
{
	[Serializable]
	public partial class UsrAccountView
	{
		private System.Guid _usrAccountPK = Guid.Empty;
		private System.String _userID = string.Empty;
		//private System.Boolean _isAdmin = false;
		//private System.Boolean _isCentral = false;
		//private System.String _firstName = string.Empty;
		//private System.String _lastName = string.Empty;
		//private System.String _password = string.Empty;
		//private System.DateTime _pwdExpireDate = new DateTime(1900, 1, 1);
		//private System.Guid _usrGroupPK = Guid.Empty;
		//private System.Guid _bDTenantPK = Guid.Empty;
		//private System.String _cellPhone = string.Empty;
		//private System.String _homePhone = string.Empty;
		//private System.String _officePhone = string.Empty;
		//private System.String _email = string.Empty;
		//private System.DateTime _lastLogin = new DateTime(1900, 1, 1);
		//private System.Int32 _totalUsage = 0;
		//private System.String _startScreen = string.Empty;
		//private System.Int32 _popupExtension = 0;
		//private System.DateTime _createdOn = new DateTime(1900, 1, 1);
		//private System.String _createdBy = string.Empty;
		//private System.DateTime _modifiedOn = new DateTime(1900, 1, 1);
		//private System.String _modifiedBy = string.Empty;
		private System.String _suite = string.Empty;
		private System.String _tenant = string.Empty;
		private System.Guid _bDBuildingPK = Guid.Empty;
		private System.String _usrGroupName = string.Empty;
		private System.String _address1 = string.Empty;
		private System.Int32 _buildingID = 0;

		public System.Guid UsrAccountPK
		{
			get{ return this._usrAccountPK; }
			set{ this._usrAccountPK = value; }
		}

		public System.String UserID
		{
			get{ return this._userID; }
			set{ this._userID = value; }
		}

//		public System.Boolean IsAdmin
//		{
//			get{ return this._isAdmin; }
//			set{ this._isAdmin = value; }
//		}

//		public System.Boolean IsCentral
//		{
//			get{ return this._isCentral; }
//			set{ this._isCentral = value; }
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

//		public System.String Password
//		{
//			get{ return this._password; }
//			set{ this._password = value; }
//		}

//		public System.DateTime PwdExpireDate
//		{
//			get{ return this._pwdExpireDate.ToLocalTime(); }
//			set{ this._pwdExpireDate = value.ToUniversalTime(); }
//		}

//		public System.Guid UsrGroupPK
//		{
//			get{ return this._usrGroupPK; }
//			set{ this._usrGroupPK = value; }
//		}

//		public System.Guid BDTenantPK
//		{
//			get{ return this._bDTenantPK; }
//			set{ this._bDTenantPK = value; }
//		}

//		public System.String CellPhone
//		{
//			get{ return this._cellPhone; }
//			set{ this._cellPhone = value; }
//		}

//		public System.String HomePhone
//		{
//			get{ return this._homePhone; }
//			set{ this._homePhone = value; }
//		}

//		public System.String OfficePhone
//		{
//			get{ return this._officePhone; }
//			set{ this._officePhone = value; }
//		}

//		public System.String Email
//		{
//			get{ return this._email; }
//			set{ this._email = value; }
//		}

//		public System.DateTime LastLogin
//		{
//			get{ return this._lastLogin.ToLocalTime(); }
//			set{ this._lastLogin = value.ToUniversalTime(); }
//		}

//		public System.Int32 TotalUsage
//		{
//			get{ return this._totalUsage; }
//			set{ this._totalUsage = value; }
//		}

//		public System.String StartScreen
//		{
//			get{ return this._startScreen; }
//			set{ this._startScreen = value; }
//		}

//		public System.Int32 PopupExtension
//		{
//			get{ return this._popupExtension; }
//			set{ this._popupExtension = value; }
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

		public System.String Suite
		{
			get{ return this._suite; }
			set{ this._suite = value; }
		}

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

		public System.String UsrGroupName
		{
			get{ return this._usrGroupName; }
			set{ this._usrGroupName = value; }
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

		public UsrAccountView()
		{
		}

		public UsrAccountView(UsrAccountData data)
		{
			this.UsrAccountPK = data.UsrAccountPK;
			this.UserID = data.UserID;
			//this.IsAdmin = data.IsAdmin;
			//this.IsCentral = data.IsCentral;
			//this.FirstName = data.FirstName;
			//this.LastName = data.LastName;
			//this.Password = data.Password;
			//this.PwdExpireDate = data.PwdExpireDate;
			//this.UsrGroupPK = data.UsrGroupPK;
			//this.BDTenantPK = data.BDTenantPK;
			//this.CellPhone = data.CellPhone;
			//this.HomePhone = data.HomePhone;
			//this.OfficePhone = data.OfficePhone;
			//this.Email = data.Email;
			//this.LastLogin = data.LastLogin;
			//this.TotalUsage = data.TotalUsage;
			//this.StartScreen = data.StartScreen;
			//this.PopupExtension = data.PopupExtension;
			//this.CreatedOn = data.CreatedOn;
			//this.CreatedBy = data.CreatedBy;
			//this.ModifiedOn = data.ModifiedOn;
			//this.ModifiedBy = data.ModifiedBy;
			this.Suite = data.Suite;
			this.Tenant = data.Tenant;
			this.BDBuildingPK = data.BDBuildingPK;
			this.UsrGroupName = data.UsrGroupName;
			this.Address1 = data.Address1;
			this.BuildingID = data.BuildingID;
		}


		public UsrAccountData ToUsrAccountData()
		{
			UsrAccountData entity = new UsrAccountData();
			entity.UsrAccountPK = this.UsrAccountPK;
			entity.UserID = this.UserID;
			//entity.IsAdmin = this.IsAdmin;
			//entity.IsCentral = this.IsCentral;
			//entity.FirstName = this.FirstName;
			//entity.LastName = this.LastName;
			//entity.Password = this.Password;
			//entity.PwdExpireDate = this.PwdExpireDate;
			//entity.UsrGroupPK = this.UsrGroupPK;
			//entity.BDTenantPK = this.BDTenantPK;
			//entity.CellPhone = this.CellPhone;
			//entity.HomePhone = this.HomePhone;
			//entity.OfficePhone = this.OfficePhone;
			//entity.Email = this.Email;
			//entity.LastLogin = this.LastLogin;
			//entity.TotalUsage = this.TotalUsage;
			//entity.StartScreen = this.StartScreen;
			//entity.PopupExtension = this.PopupExtension;
			//entity.CreatedOn = this.CreatedOn;
			//entity.CreatedBy = this.CreatedBy;
			//entity.ModifiedOn = this.ModifiedOn;
			//entity.ModifiedBy = this.ModifiedBy;
			entity.Suite = this.Suite;
			entity.Tenant = this.Tenant;
			entity.BDBuildingPK = this.BDBuildingPK;
			entity.UsrGroupName = this.UsrGroupName;
			entity.Address1 = this.Address1;
			entity.BuildingID = this.BuildingID;

			return entity;
		}
	}
}
