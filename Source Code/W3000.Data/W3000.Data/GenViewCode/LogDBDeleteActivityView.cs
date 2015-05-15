using System;

namespace W3000.Data
{
	[Serializable]
	public partial class LogDBDeleteActivityView
	{
		private System.Guid _logDBDeleteActivityPK = Guid.Empty;
		private System.DateTime _logDateTime = new DateTime(1900, 1, 1);
		private System.String _dBTableName = string.Empty;
		//private System.Guid _recordPK = Guid.Empty;
		//private System.DateTime _lastUpdated = new DateTime(1900, 1, 1);
		//private System.DateTime _createdOn = new DateTime(1900, 1, 1);
		//private System.String _createdBy = string.Empty;
		//private System.DateTime _modifiedOn = new DateTime(1900, 1, 1);
		//private System.String _modifiedBy = string.Empty;

		public System.Guid LogDBDeleteActivityPK
		{
			get{ return this._logDBDeleteActivityPK; }
			set{ this._logDBDeleteActivityPK = value; }
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

//		public System.DateTime LastUpdated
//		{
//			get{ return this._lastUpdated.ToLocalTime(); }
//			set{ this._lastUpdated = value.ToUniversalTime(); }
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

		public LogDBDeleteActivityView()
		{
		}

		public LogDBDeleteActivityView(LogDBDeleteActivityData data)
		{
			this.LogDBDeleteActivityPK = data.LogDBDeleteActivityPK;
			this.LogDateTime = data.LogDateTime;
			this.DBTableName = data.DBTableName;
			//this.RecordPK = data.RecordPK;
			//this.LastUpdated = data.LastUpdated;
			//this.CreatedOn = data.CreatedOn;
			//this.CreatedBy = data.CreatedBy;
			//this.ModifiedOn = data.ModifiedOn;
			//this.ModifiedBy = data.ModifiedBy;
		}


		public LogDBDeleteActivityData ToLogDBDeleteActivityData()
		{
			LogDBDeleteActivityData entity = new LogDBDeleteActivityData();
			entity.LogDBDeleteActivityPK = this.LogDBDeleteActivityPK;
			entity.LogDateTime = this.LogDateTime;
			entity.DBTableName = this.DBTableName;
			//entity.RecordPK = this.RecordPK;
			//entity.LastUpdated = this.LastUpdated;
			//entity.CreatedOn = this.CreatedOn;
			//entity.CreatedBy = this.CreatedBy;
			//entity.ModifiedOn = this.ModifiedOn;
			//entity.ModifiedBy = this.ModifiedBy;

			return entity;
		}
	}
}
