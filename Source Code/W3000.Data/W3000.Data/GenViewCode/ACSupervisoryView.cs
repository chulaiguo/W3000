using System;

namespace W3000.Data
{
	[Serializable]
	public partial class ACSupervisoryView
	{
		private System.Guid _aCSupervisoryPK = Guid.Empty;
		private System.Guid _aCPanelPK = Guid.Empty;
		private System.Byte _supervisoryID = 0;
		private System.String _description = string.Empty;
		//private System.Int16 _debounce = 0;
		//private System.Int16 _forceAMFormat = 0;
		//private System.Boolean _external = false;
		//private System.String _notes = string.Empty;
		//private System.DateTime _createdOn = new DateTime(1900, 1, 1);
		//private System.String _createdBy = string.Empty;
		//private System.DateTime _modifiedOn = new DateTime(1900, 1, 1);
		//private System.String _modifiedBy = string.Empty;
		private System.Byte _panelZoneID = 0;
		//private System.Boolean _locked = false;
		private System.Guid _bDBuildingPK = Guid.Empty;
		private System.Int32 _unitID = 0;
		private System.String _address1 = string.Empty;
		private System.Int32 _buildingID = 0;

		public System.Guid ACSupervisoryPK
		{
			get{ return this._aCSupervisoryPK; }
			set{ this._aCSupervisoryPK = value; }
		}

		public System.Guid ACPanelPK
		{
			get{ return this._aCPanelPK; }
			set{ this._aCPanelPK = value; }
		}

		public System.Byte SupervisoryID
		{
			get{ return this._supervisoryID; }
			set{ this._supervisoryID = value; }
		}

		public System.String Description
		{
			get{ return this._description; }
			set{ this._description = value; }
		}

//		public System.Int16 Debounce
//		{
//			get{ return this._debounce; }
//			set{ this._debounce = value; }
//		}

//		public System.Int16 ForceAMFormat
//		{
//			get{ return this._forceAMFormat; }
//			set{ this._forceAMFormat = value; }
//		}

//		public System.Boolean External
//		{
//			get{ return this._external; }
//			set{ this._external = value; }
//		}

//		public System.String Notes
//		{
//			get{ return this._notes; }
//			set{ this._notes = value; }
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

		public System.Byte PanelZoneID
		{
			get{ return this._panelZoneID; }
			set{ this._panelZoneID = value; }
		}

//		public System.Boolean Locked
//		{
//			get{ return this._locked; }
//			set{ this._locked = value; }
//		}

		public System.Guid BDBuildingPK
		{
			get{ return this._bDBuildingPK; }
			set{ this._bDBuildingPK = value; }
		}

		public System.Int32 UnitID
		{
			get{ return this._unitID; }
			set{ this._unitID = value; }
		}

		public System.String Address1
		{
			get{ return this._address1; }
			set{ this._address1 = value; }
		}

		public System.Int32 BuildingID
		{
			get{ return this._buildingID; }
			set{ this._buildingID = value; }
		}

		public ACSupervisoryView()
		{
		}

		public ACSupervisoryView(ACSupervisoryData data)
		{
			this.ACSupervisoryPK = data.ACSupervisoryPK;
			this.ACPanelPK = data.ACPanelPK;
			this.SupervisoryID = data.SupervisoryID;
			this.Description = data.Description;
			//this.Debounce = data.Debounce;
			//this.ForceAMFormat = data.ForceAMFormat;
			//this.External = data.External;
			//this.Notes = data.Notes;
			//this.CreatedOn = data.CreatedOn;
			//this.CreatedBy = data.CreatedBy;
			//this.ModifiedOn = data.ModifiedOn;
			//this.ModifiedBy = data.ModifiedBy;
			this.PanelZoneID = data.PanelZoneID;
			//this.Locked = data.Locked;
			this.BDBuildingPK = data.BDBuildingPK;
			this.UnitID = data.UnitID;
			this.Address1 = data.Address1;
			this.BuildingID = data.BuildingID;
		}


		public ACSupervisoryData ToACSupervisoryData()
		{
			ACSupervisoryData entity = new ACSupervisoryData();
			entity.ACSupervisoryPK = this.ACSupervisoryPK;
			entity.ACPanelPK = this.ACPanelPK;
			entity.SupervisoryID = this.SupervisoryID;
			entity.Description = this.Description;
			//entity.Debounce = this.Debounce;
			//entity.ForceAMFormat = this.ForceAMFormat;
			//entity.External = this.External;
			//entity.Notes = this.Notes;
			//entity.CreatedOn = this.CreatedOn;
			//entity.CreatedBy = this.CreatedBy;
			//entity.ModifiedOn = this.ModifiedOn;
			//entity.ModifiedBy = this.ModifiedBy;
			entity.PanelZoneID = this.PanelZoneID;
			//entity.Locked = this.Locked;
			entity.BDBuildingPK = this.BDBuildingPK;
			entity.UnitID = this.UnitID;
			entity.Address1 = this.Address1;
			entity.BuildingID = this.BuildingID;

			return entity;
		}
	}
}
