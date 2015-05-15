using System;

namespace W3000.Data
{
	[Serializable]
	public partial class UsrGroupBRRuleView
	{
		private System.Guid _usrGroupBRRule = Guid.Empty;
		private System.Guid _usrGroupPK = Guid.Empty;
		private System.Int32 _bRRuleID = 0;
		//private System.Boolean _denied = false;
		//private System.DateTime _createdOn = new DateTime(1900, 1, 1);
		//private System.String _createdBy = string.Empty;
		//private System.DateTime _modifiedOn = new DateTime(1900, 1, 1);
		//private System.String _modifiedBy = string.Empty;
		private System.String _usrGroupName = string.Empty;

		public System.Guid UsrGroupBRRule
		{
			get{ return this._usrGroupBRRule; }
			set{ this._usrGroupBRRule = value; }
		}

		public System.Guid UsrGroupPK
		{
			get{ return this._usrGroupPK; }
			set{ this._usrGroupPK = value; }
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

		public System.String UsrGroupName
		{
			get{ return this._usrGroupName; }
			set{ this._usrGroupName = value; }
		}

		public UsrGroupBRRuleView()
		{
		}

		public UsrGroupBRRuleView(UsrGroupBRRuleData data)
		{
			this.UsrGroupBRRule = data.UsrGroupBRRule;
			this.UsrGroupPK = data.UsrGroupPK;
			this.BRRuleID = data.BRRuleID;
			//this.Denied = data.Denied;
			//this.CreatedOn = data.CreatedOn;
			//this.CreatedBy = data.CreatedBy;
			//this.ModifiedOn = data.ModifiedOn;
			//this.ModifiedBy = data.ModifiedBy;
			this.UsrGroupName = data.UsrGroupName;
		}


		public UsrGroupBRRuleData ToUsrGroupBRRuleData()
		{
			UsrGroupBRRuleData entity = new UsrGroupBRRuleData();
			entity.UsrGroupBRRule = this.UsrGroupBRRule;
			entity.UsrGroupPK = this.UsrGroupPK;
			entity.BRRuleID = this.BRRuleID;
			//entity.Denied = this.Denied;
			//entity.CreatedOn = this.CreatedOn;
			//entity.CreatedBy = this.CreatedBy;
			//entity.ModifiedOn = this.ModifiedOn;
			//entity.ModifiedBy = this.ModifiedBy;
			entity.UsrGroupName = this.UsrGroupName;

			return entity;
		}
	}
}
