using System;

namespace W3000.Data
{
	[Serializable]
	public partial class ACAccessLevelDetailView
	{
		private System.Guid _aCAccessLevelDetailPK = Guid.Empty;
		private System.Guid _aCAccessLevelPK = Guid.Empty;
		private System.Guid _aCMainZonePK = Guid.Empty;
		private System.Guid _aCTimecodePK = Guid.Empty;
		//private System.Guid _fromACAccessLevelPK = Guid.Empty;
		//private System.DateTime _createdOn = new DateTime(1900, 1, 1);
		//private System.String _createdBy = string.Empty;
		//private System.DateTime _modifiedOn = new DateTime(1900, 1, 1);
		//private System.String _modifiedBy = string.Empty;
		//private System.String _mainZoneDescription = string.Empty;
		private System.Byte _mainZoneID = 0;
		private System.Guid _aCPanelPK = Guid.Empty;
		//private System.String _timecodeSummary = string.Empty;
		private System.Int16 _tCID = 0;
		//private System.String _aLSummary = string.Empty;
		private System.Int16 _accessLevelID = 0;
		private System.Guid _bDBuildingPK = Guid.Empty;

		public System.Guid ACAccessLevelDetailPK
		{
			get{ return this._aCAccessLevelDetailPK; }
			set{ this._aCAccessLevelDetailPK = value; }
		}

		public System.Guid ACAccessLevelPK
		{
			get{ return this._aCAccessLevelPK; }
			set{ this._aCAccessLevelPK = value; }
		}

		public System.Guid ACMainZonePK
		{
			get{ return this._aCMainZonePK; }
			set{ this._aCMainZonePK = value; }
		}

		public System.Guid ACTimecodePK
		{
			get{ return this._aCTimecodePK; }
			set{ this._aCTimecodePK = value; }
		}

//		public System.Guid FromACAccessLevelPK
//		{
//			get{ return this._fromACAccessLevelPK; }
//			set{ this._fromACAccessLevelPK = value; }
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

//		public System.String MainZoneDescription
//		{
//			get{ return this._mainZoneDescription; }
//			set{ this._mainZoneDescription = value; }
//		}

		public System.Byte MainZoneID
		{
			get{ return this._mainZoneID; }
			set{ this._mainZoneID = value; }
		}

		public System.Guid ACPanelPK
		{
			get{ return this._aCPanelPK; }
			set{ this._aCPanelPK = value; }
		}

//		public System.String TimecodeSummary
//		{
//			get{ return this._timecodeSummary; }
//			set{ this._timecodeSummary = value; }
//		}

		public System.Int16 TCID
		{
			get{ return this._tCID; }
			set{ this._tCID = value; }
		}

//		public System.String ALSummary
//		{
//			get{ return this._aLSummary; }
//			set{ this._aLSummary = value; }
//		}

		public System.Int16 AccessLevelID
		{
			get{ return this._accessLevelID; }
			set{ this._accessLevelID = value; }
		}

		public System.Guid BDBuildingPK
		{
			get{ return this._bDBuildingPK; }
			set{ this._bDBuildingPK = value; }
		}

		public ACAccessLevelDetailView()
		{
		}

		public ACAccessLevelDetailView(ACAccessLevelDetailData data)
		{
			this.ACAccessLevelDetailPK = data.ACAccessLevelDetailPK;
			this.ACAccessLevelPK = data.ACAccessLevelPK;
			this.ACMainZonePK = data.ACMainZonePK;
			this.ACTimecodePK = data.ACTimecodePK;
			//this.FromACAccessLevelPK = data.FromACAccessLevelPK;
			//this.CreatedOn = data.CreatedOn;
			//this.CreatedBy = data.CreatedBy;
			//this.ModifiedOn = data.ModifiedOn;
			//this.ModifiedBy = data.ModifiedBy;
			//this.MainZoneDescription = data.MainZoneDescription;
			this.MainZoneID = data.MainZoneID;
			this.ACPanelPK = data.ACPanelPK;
			//this.TimecodeSummary = data.TimecodeSummary;
			this.TCID = data.TCID;
			//this.ALSummary = data.ALSummary;
			this.AccessLevelID = data.AccessLevelID;
			this.BDBuildingPK = data.BDBuildingPK;
		}


		public ACAccessLevelDetailData ToACAccessLevelDetailData()
		{
			ACAccessLevelDetailData entity = new ACAccessLevelDetailData();
			entity.ACAccessLevelDetailPK = this.ACAccessLevelDetailPK;
			entity.ACAccessLevelPK = this.ACAccessLevelPK;
			entity.ACMainZonePK = this.ACMainZonePK;
			entity.ACTimecodePK = this.ACTimecodePK;
			//entity.FromACAccessLevelPK = this.FromACAccessLevelPK;
			//entity.CreatedOn = this.CreatedOn;
			//entity.CreatedBy = this.CreatedBy;
			//entity.ModifiedOn = this.ModifiedOn;
			//entity.ModifiedBy = this.ModifiedBy;
			//entity.MainZoneDescription = this.MainZoneDescription;
			entity.MainZoneID = this.MainZoneID;
			entity.ACPanelPK = this.ACPanelPK;
			//entity.TimecodeSummary = this.TimecodeSummary;
			entity.TCID = this.TCID;
			//entity.ALSummary = this.ALSummary;
			entity.AccessLevelID = this.AccessLevelID;
			entity.BDBuildingPK = this.BDBuildingPK;

			return entity;
		}
	}
}
