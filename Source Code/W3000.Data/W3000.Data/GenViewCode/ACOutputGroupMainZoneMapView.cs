using System;

namespace W3000.Data
{
	[Serializable]
	public partial class ACOutputGroupMainZoneMapView
	{
		private System.Guid _aCOutputGroupMainZoneMapPK = Guid.Empty;
		private System.Guid _aCOutputGroupPK = Guid.Empty;
		private System.Guid _aCMainZonePK = Guid.Empty;
		//private System.DateTime _createdOn = new DateTime(1900, 1, 1);
		//private System.String _createdBy = string.Empty;
		//private System.DateTime _modifiedOn = new DateTime(1900, 1, 1);
		//private System.String _modifiedBy = string.Empty;
		private System.Byte _mainZoneID = 0;
		private System.Guid _aCPanelPK = Guid.Empty;
		private System.Byte _groupID = 0;

		public System.Guid ACOutputGroupMainZoneMapPK
		{
			get{ return this._aCOutputGroupMainZoneMapPK; }
			set{ this._aCOutputGroupMainZoneMapPK = value; }
		}

		public System.Guid ACOutputGroupPK
		{
			get{ return this._aCOutputGroupPK; }
			set{ this._aCOutputGroupPK = value; }
		}

		public System.Guid ACMainZonePK
		{
			get{ return this._aCMainZonePK; }
			set{ this._aCMainZonePK = value; }
		}

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

		public System.Byte GroupID
		{
			get{ return this._groupID; }
			set{ this._groupID = value; }
		}

		public ACOutputGroupMainZoneMapView()
		{
		}

		public ACOutputGroupMainZoneMapView(ACOutputGroupMainZoneMapData data)
		{
			this.ACOutputGroupMainZoneMapPK = data.ACOutputGroupMainZoneMapPK;
			this.ACOutputGroupPK = data.ACOutputGroupPK;
			this.ACMainZonePK = data.ACMainZonePK;
			//this.CreatedOn = data.CreatedOn;
			//this.CreatedBy = data.CreatedBy;
			//this.ModifiedOn = data.ModifiedOn;
			//this.ModifiedBy = data.ModifiedBy;
			this.MainZoneID = data.MainZoneID;
			this.ACPanelPK = data.ACPanelPK;
			this.GroupID = data.GroupID;
		}


		public ACOutputGroupMainZoneMapData ToACOutputGroupMainZoneMapData()
		{
			ACOutputGroupMainZoneMapData entity = new ACOutputGroupMainZoneMapData();
			entity.ACOutputGroupMainZoneMapPK = this.ACOutputGroupMainZoneMapPK;
			entity.ACOutputGroupPK = this.ACOutputGroupPK;
			entity.ACMainZonePK = this.ACMainZonePK;
			//entity.CreatedOn = this.CreatedOn;
			//entity.CreatedBy = this.CreatedBy;
			//entity.ModifiedOn = this.ModifiedOn;
			//entity.ModifiedBy = this.ModifiedBy;
			entity.MainZoneID = this.MainZoneID;
			entity.ACPanelPK = this.ACPanelPK;
			entity.GroupID = this.GroupID;

			return entity;
		}
	}
}
