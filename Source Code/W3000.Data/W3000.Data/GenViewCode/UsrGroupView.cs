using System;

namespace W3000.Data
{
	[Serializable]
	public partial class UsrGroupView
	{
		private System.Guid _usrGroupPK = Guid.Empty;
		private System.String _usrGroupName = string.Empty;
		//private System.String _description = string.Empty;
		//private System.DateTime _createdOn = new DateTime(1900, 1, 1);
		//private System.String _createdBy = string.Empty;
		//private System.DateTime _modifiedOn = new DateTime(1900, 1, 1);
		//private System.String _modifiedBy = string.Empty;

		public System.Guid UsrGroupPK
		{
			get{ return this._usrGroupPK; }
			set{ this._usrGroupPK = value; }
		}

		public System.String UsrGroupName
		{
			get{ return this._usrGroupName; }
			set{ this._usrGroupName = value; }
		}

//		public System.String Description
//		{
//			get{ return this._description; }
//			set{ this._description = value; }
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

		public UsrGroupView()
		{
		}

		public UsrGroupView(UsrGroupData data)
		{
			this.UsrGroupPK = data.UsrGroupPK;
			this.UsrGroupName = data.UsrGroupName;
			//this.Description = data.Description;
			//this.CreatedOn = data.CreatedOn;
			//this.CreatedBy = data.CreatedBy;
			//this.ModifiedOn = data.ModifiedOn;
			//this.ModifiedBy = data.ModifiedBy;
		}


		public UsrGroupData ToUsrGroupData()
		{
			UsrGroupData entity = new UsrGroupData();
			entity.UsrGroupPK = this.UsrGroupPK;
			entity.UsrGroupName = this.UsrGroupName;
			//entity.Description = this.Description;
			//entity.CreatedOn = this.CreatedOn;
			//entity.CreatedBy = this.CreatedBy;
			//entity.ModifiedOn = this.ModifiedOn;
			//entity.ModifiedBy = this.ModifiedBy;

			return entity;
		}
	}
}
