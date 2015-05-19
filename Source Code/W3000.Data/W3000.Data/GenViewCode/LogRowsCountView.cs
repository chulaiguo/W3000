using System;

namespace W3000.Data
{
	[Serializable]
	public partial class LogRowsCountView
	{
		private System.Guid _logRowsCountPK = Guid.Empty;
		private System.Guid _sessionID = Guid.Empty;
		private System.DateTime _sessionDateTime = new DateTime(1900, 1, 1);
		//private System.String _dBTableName = string.Empty;
		//private System.Int32 _sequenceID = 0;
		//private System.Int32 _rowsCount = 0;
		//private System.DateTime _createdOn = new DateTime(1900, 1, 1);
		//private System.String _createdBy = string.Empty;
		//private System.DateTime _modifiedOn = new DateTime(1900, 1, 1);
		//private System.String _modifiedBy = string.Empty;

		public System.Guid LogRowsCountPK
		{
			get{ return this._logRowsCountPK; }
			set{ this._logRowsCountPK = value; }
		}

		public System.Guid SessionID
		{
			get{ return this._sessionID; }
			set{ this._sessionID = value; }
		}

		public System.DateTime SessionDateTime
		{
			get{ return this._sessionDateTime.ToLocalTime(); }
			set{ this._sessionDateTime = value.ToUniversalTime(); }
		}

//		public System.String DBTableName
//		{
//			get{ return this._dBTableName; }
//			set{ this._dBTableName = value; }
//		}

//		public System.Int32 SequenceID
//		{
//			get{ return this._sequenceID; }
//			set{ this._sequenceID = value; }
//		}

//		public System.Int32 RowsCount
//		{
//			get{ return this._rowsCount; }
//			set{ this._rowsCount = value; }
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

		public LogRowsCountView()
		{
		}

		public LogRowsCountView(LogRowsCountData data)
		{
			this.LogRowsCountPK = data.LogRowsCountPK;
			this.SessionID = data.SessionID;
			this.SessionDateTime = data.SessionDateTime;
			//this.DBTableName = data.DBTableName;
			//this.SequenceID = data.SequenceID;
			//this.RowsCount = data.RowsCount;
			//this.CreatedOn = data.CreatedOn;
			//this.CreatedBy = data.CreatedBy;
			//this.ModifiedOn = data.ModifiedOn;
			//this.ModifiedBy = data.ModifiedBy;
		}


		public LogRowsCountData ToLogRowsCountData()
		{
			LogRowsCountData entity = new LogRowsCountData();
			entity.LogRowsCountPK = this.LogRowsCountPK;
			entity.SessionID = this.SessionID;
			entity.SessionDateTime = this.SessionDateTime;
			//entity.DBTableName = this.DBTableName;
			//entity.SequenceID = this.SequenceID;
			//entity.RowsCount = this.RowsCount;
			//entity.CreatedOn = this.CreatedOn;
			//entity.CreatedBy = this.CreatedBy;
			//entity.ModifiedOn = this.ModifiedOn;
			//entity.ModifiedBy = this.ModifiedBy;

			return entity;
		}
	}
}
