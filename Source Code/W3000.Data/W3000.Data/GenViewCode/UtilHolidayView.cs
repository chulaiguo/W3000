using System;

namespace W3000.Data
{
	[Serializable]
	public partial class UtilHolidayView
	{
		private System.Guid _utilHolidayPK = Guid.Empty;
		private System.Int32 _countryID = 0;
		private System.String _holiday = string.Empty;
		private System.DateTime _date = new DateTime(1900, 1, 1);
		//private System.Boolean _major = false;
		//private System.Boolean _federal = false;
		//private System.DateTime _createdOn = new DateTime(1900, 1, 1);
		//private System.String _createdBy = string.Empty;
		//private System.DateTime _modifiedOn = new DateTime(1900, 1, 1);
		//private System.String _modifiedBy = string.Empty;
		//private System.Boolean _default = false;
		//private System.Int32 _actionID = 0;

		public System.Guid UtilHolidayPK
		{
			get{ return this._utilHolidayPK; }
			set{ this._utilHolidayPK = value; }
		}

		public System.Int32 CountryID
		{
			get{ return this._countryID; }
			set{ this._countryID = value; }
		}

		public System.String Holiday
		{
			get{ return this._holiday; }
			set{ this._holiday = value; }
		}

		public System.DateTime Date
		{
			get{ return this._date.ToLocalTime(); }
			set{ this._date = value.ToUniversalTime(); }
		}

//		public System.Boolean Major
//		{
//			get{ return this._major; }
//			set{ this._major = value; }
//		}

//		public System.Boolean Federal
//		{
//			get{ return this._federal; }
//			set{ this._federal = value; }
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

//		public System.Boolean Default
//		{
//			get{ return this._default; }
//			set{ this._default = value; }
//		}

//		public System.Int32 ActionID
//		{
//			get{ return this._actionID; }
//			set{ this._actionID = value; }
//		}

		public UtilHolidayView()
		{
		}

		public UtilHolidayView(UtilHolidayData data)
		{
			this.UtilHolidayPK = data.UtilHolidayPK;
			this.CountryID = data.CountryID;
			this.Holiday = data.Holiday;
			this.Date = data.Date;
			//this.Major = data.Major;
			//this.Federal = data.Federal;
			//this.CreatedOn = data.CreatedOn;
			//this.CreatedBy = data.CreatedBy;
			//this.ModifiedOn = data.ModifiedOn;
			//this.ModifiedBy = data.ModifiedBy;
			//this.Default = data.Default;
			//this.ActionID = data.ActionID;
		}


		public UtilHolidayData ToUtilHolidayData()
		{
			UtilHolidayData entity = new UtilHolidayData();
			entity.UtilHolidayPK = this.UtilHolidayPK;
			entity.CountryID = this.CountryID;
			entity.Holiday = this.Holiday;
			entity.Date = this.Date;
			//entity.Major = this.Major;
			//entity.Federal = this.Federal;
			//entity.CreatedOn = this.CreatedOn;
			//entity.CreatedBy = this.CreatedBy;
			//entity.ModifiedOn = this.ModifiedOn;
			//entity.ModifiedBy = this.ModifiedBy;
			//entity.Default = this.Default;
			//entity.ActionID = this.ActionID;

			return entity;
		}
	}
}
