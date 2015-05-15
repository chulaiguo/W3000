using System;

namespace W3000.Data
{
	[Serializable]
	public partial class LogDBEditActivityView
	{
		private System.Guid _logDBEditActivityPK = Guid.Empty;
		private System.DateTime _logDateTime = new DateTime(1900, 1, 1);
		private System.String _dBTableName = string.Empty;
		//private System.Guid _recordPK = Guid.Empty;
		//private System.String _category = string.Empty;
		//private System.DateTime _createdOn = new DateTime(1900, 1, 1);
		//private System.String _createdBy = string.Empty;
		//private System.DateTime _modifiedOn = new DateTime(1900, 1, 1);
		//private System.String _modifiedBy = string.Empty;

		public System.Guid LogDBEditActivityPK
		{
			get{ return this._logDBEditActivityPK; }
			set{ this._logDBEditActivityPK = value; }
		}

		public System.DateTime LogDateTime
		{
			get{ return this._logDateTime.ToLocalTime(); }
			set{ this._logDateTime = value.ToUniversalTime(); }
		}

		public System.String DBTableName
		{
			get{ return this._dBTableName; }
			set{ this._dBTableName = value; }
		}

//		public System.Guid RecordPK
//		{
//			get{ return this._recordPK; }
//			set{ this._recordPK = value; }
//		}

//		public System.String Category
//		{
//			get{ return this._category; }
//			set{ this._category = value; }
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

		public LogDBEditActivityView()
		{
		}

		public LogDBEditActivityView(LogDBEditActivityData data)
		{
			this.LogDBEditActivityPK = data.LogDBEditActivityPK;
			this.LogDateTime = data.LogDateTime;
			this.DBTableName = data.DBTableName;
			//this.RecordPK = data.RecordPK;
			//this.Category = data.Category;
			//this.CreatedOn = data.CreatedOn;
			//this.CreatedBy = data.CreatedBy;
			//this.ModifiedOn = data.ModifiedOn;
			//this.ModifiedBy = data.ModifiedBy;
		}


		public LogDBEditActivityData ToLogDBEditActivityData()
		{
			LogDBEditActivityData entity = new LogDBEditActivityData();
			entity.LogDBEditActivityPK = this.LogDBEditActivityPK;
			entity.LogDateTime = this.LogDateTime;
			entity.DBTableName = this.DBTableName;
			//entity.RecordPK = this.RecordPK;
			//entity.Category = this.Category;
			//entity.CreatedOn = this.CreatedOn;
			//entity.CreatedBy = this.CreatedBy;
			//entity.ModifiedOn = this.ModifiedOn;
			//entity.ModifiedBy = this.ModifiedBy;

			return entity;
		}
	}
}
