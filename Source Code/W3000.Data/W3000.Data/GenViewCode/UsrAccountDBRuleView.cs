using System;

namespace W3000.Data
{
	[Serializable]
	public partial class UsrAccountDBRuleView
	{
		private System.Guid _usrAccountDBRulePK = Guid.Empty;
		private System.Guid _usrAccountPK = Guid.Empty;
		private System.Int32 _dBRuleID = 0;
		//private System.Boolean _selectable = false;
		//private System.Boolean _insertable = false;
		//private System.Boolean _editable = false;
		//private System.Boolean _deletable = false;
		//private System.DateTime _createdOn = new DateTime(1900, 1, 1);
		//private System.String _createdBy = string.Empty;
		//private System.DateTime _modifiedOn = new DateTime(1900, 1, 1);
		//private System.String _modifiedBy = string.Empty;
		private System.String _userID = string.Empty;

		public System.Guid UsrAccountDBRulePK
		{
			get{ return this._usrAccountDBRulePK; }
			set{ this._usrAccountDBRulePK = value; }
		}

		public System.Guid UsrAccountPK
		{
			get{ return this._usrAccountPK; }
			set{ this._usrAccountPK = value; }
		}

		public System.Int32 DBRuleID
		{
			get{ return this._dBRuleID; }
			set{ this._dBRuleID = value; }
		}

//		public System.Boolean Selectable
//		{
//			get{ return this._selectable; }
//			set{ this._selectable = value; }
//		}

//		public System.Boolean Insertable
//		{
//			get{ return this._insertable; }
//			set{ this._insertable = value; }
//		}

//		public System.Boolean Editable
//		{
//			get{ return this._editable; }
//			set{ this._editable = value; }
//		}

//		public System.Boolean Deletable
//		{
//			get{ return this._deletable; }
//			set{ this._deletable = value; }
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

		public System.String UserID
		{
			get{ return this._userID; }
			set{ this._userID = value; }
		}

		public UsrAccountDBRuleView()
		{
		}

		public UsrAccountDBRuleView(UsrAccountDBRuleData data)
		{
			this.UsrAccountDBRulePK = data.UsrAccountDBRulePK;
			this.UsrAccountPK = data.UsrAccountPK;
			this.DBRuleID = data.DBRuleID;
			//this.Selectable = data.Selectable;
			//this.Insertable = data.Insertable;
			//this.Editable = data.Editable;
			//this.Deletable = data.Deletable;
			//this.CreatedOn = data.CreatedOn;
			//this.CreatedBy = data.CreatedBy;
			//this.ModifiedOn = data.ModifiedOn;
			//this.ModifiedBy = data.ModifiedBy;
			this.UserID = data.UserID;
		}


		public UsrAccountDBRuleData ToUsrAccountDBRuleData()
		{
			UsrAccountDBRuleData entity = new UsrAccountDBRuleData();
			entity.UsrAccountDBRulePK = this.UsrAccountDBRulePK;
			entity.UsrAccountPK = this.UsrAccountPK;
			entity.DBRuleID = this.DBRuleID;
			//entity.Selectable = this.Selectable;
			//entity.Insertable = this.Insertable;
			//entity.Editable = this.Editable;
			//entity.Deletable = this.Deletable;
			//entity.CreatedOn = this.CreatedOn;
			//entity.CreatedBy = this.CreatedBy;
			//entity.ModifiedOn = this.ModifiedOn;
			//entity.ModifiedBy = this.ModifiedBy;
			entity.UserID = this.UserID;

			return entity;
		}
	}
}
