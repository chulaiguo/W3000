using System;

namespace W3000.Data
{
	[Serializable]
	public partial class UsrAccountBRRuleView
	{
		private System.Guid _usrAccountBRRulePK = Guid.Empty;
		private System.Guid _usrAccountPK = Guid.Empty;
		private System.Int32 _bRRuleID = 0;
		//private System.Boolean _denied = false;
		//private System.DateTime _createdOn = new DateTime(1900, 1, 1);
		//private System.String _createdBy = string.Empty;
		//private System.DateTime _modifiedOn = new DateTime(1900, 1, 1);
		//private System.String _modifiedBy = string.Empty;
		private System.String _userID = string.Empty;

		public System.Guid UsrAccountBRRulePK
		{
			get{ return this._usrAccountBRRulePK; }
			set{ this._usrAccountBRRulePK = value; }
		}

		public System.Guid UsrAccountPK
		{
			get{ return this._usrAccountPK; }
			set{ this._usrAccountPK = value; }
		}

		public System.Int32 BRRuleID
		{
			get{ return this._bRRuleID; }
			set{ this._bRRuleID = value; }
		}

//		public System.Boolean Denied
//		{
//			get{ return this._denied; }
//			set{ this._denied = value; }
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

		public UsrAccountBRRuleView()
		{
		}

		public UsrAccountBRRuleView(UsrAccountBRRuleData data)
		{
			this.UsrAccountBRRulePK = data.UsrAccountBRRulePK;
			this.UsrAccountPK = data.UsrAccountPK;
			this.BRRuleID = data.BRRuleID;
			//this.Denied = data.Denied;
			//this.CreatedOn = data.CreatedOn;
			//this.CreatedBy = data.CreatedBy;
			//this.ModifiedOn = data.ModifiedOn;
			//this.ModifiedBy = data.ModifiedBy;
			this.UserID = data.UserID;
		}


		public UsrAccountBRRuleData ToUsrAccountBRRuleData()
		{
			UsrAccountBRRuleData entity = new UsrAccountBRRuleData();
			entity.UsrAccountBRRulePK = this.UsrAccountBRRulePK;
			entity.UsrAccountPK = this.UsrAccountPK;
			entity.BRRuleID = this.BRRuleID;
			//entity.Denied = this.Denied;
			//entity.CreatedOn = this.CreatedOn;
			//entity.CreatedBy = this.CreatedBy;
			//entity.ModifiedOn = this.ModifiedOn;
			//entity.ModifiedBy = this.ModifiedBy;
			entity.UserID = this.UserID;

			return entity;
		}
	}
}
