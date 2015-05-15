using System;

namespace W3000.Data
{
	[Serializable]
	public partial class ACAMFormatView
	{
		private System.Guid _aCAMFormatPK = Guid.Empty;
		private System.Guid _bDBuildingPK = Guid.Empty;
		private System.Int16 _aMFID = 0;
		private System.String _summary = string.Empty;
		//private System.String _notes = string.Empty;
		//private System.Int16 _reportTC = 0;
		//private System.Int16 _alarmTC = 0;
		//private System.Int16 _preAlarmTC = 0;
		//private System.DateTime _createdOn = new DateTime(1900, 1, 1);
		//private System.String _createdBy = string.Empty;
		//private System.DateTime _modifiedOn = new DateTime(1900, 1, 1);
		//private System.String _modifiedBy = string.Empty;

		public System.Guid ACAMFormatPK
		{
			get{ return this._aCAMFormatPK; }
			set{ this._aCAMFormatPK = value; }
		}

		public System.Guid BDBuildingPK
		{
			get{ return this._bDBuildingPK; }
			set{ this._bDBuildingPK = value; }
		}

		public System.Int16 AMFID
		{
			get{ return this._aMFID; }
			set{ this._aMFID = value; }
		}

		public System.String Summary
		{
			get{ return this._summary; }
			set{ this._summary = value; }
		}

//		public System.String Notes
//		{
//			get{ return this._notes; }
//			set{ this._notes = value; }
//		}

//		public System.Int16 ReportTC
//		{
//			get{ return this._reportTC; }
//			set{ this._reportTC = value; }
//		}

//		public System.Int16 AlarmTC
//		{
//			get{ return this._alarmTC; }
//			set{ this._alarmTC = value; }
//		}

//		public System.Int16 PreAlarmTC
//		{
//			get{ return this._preAlarmTC; }
//			set{ this._preAlarmTC = value; }
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

		public ACAMFormatView()
		{
		}

		public ACAMFormatView(ACAMFormatData data)
		{
			this.ACAMFormatPK = data.ACAMFormatPK;
			this.BDBuildingPK = data.BDBuildingPK;
			this.AMFID = data.AMFID;
			this.Summary = data.Summary;
			//this.Notes = data.Notes;
			//this.ReportTC = data.ReportTC;
			//this.AlarmTC = data.AlarmTC;
			//this.PreAlarmTC = data.PreAlarmTC;
			//this.CreatedOn = data.CreatedOn;
			//this.CreatedBy = data.CreatedBy;
			//this.ModifiedOn = data.ModifiedOn;
			//this.ModifiedBy = data.ModifiedBy;
		}


		public ACAMFormatData ToACAMFormatData()
		{
			ACAMFormatData entity = new ACAMFormatData();
			entity.ACAMFormatPK = this.ACAMFormatPK;
			entity.BDBuildingPK = this.BDBuildingPK;
			entity.AMFID = this.AMFID;
			entity.Summary = this.Summary;
			//entity.Notes = this.Notes;
			//entity.ReportTC = this.ReportTC;
			//entity.AlarmTC = this.AlarmTC;
			//entity.PreAlarmTC = this.PreAlarmTC;
			//entity.CreatedOn = this.CreatedOn;
			//entity.CreatedBy = this.CreatedBy;
			//entity.ModifiedOn = this.ModifiedOn;
			//entity.ModifiedBy = this.ModifiedBy;

			return entity;
		}
	}
}
