using System;

namespace W3000.Data
{
	[Serializable]
	public partial class ACInputView
	{
		private System.Guid _aCInputPK = Guid.Empty;
		private System.Guid _aCPanelPK = Guid.Empty;
		private System.Byte _inputID = 0;
		private System.String _description = string.Empty;
		//private System.Int16 _debounce = 0;
		//private System.Boolean _reverse = false;
		//private System.Int16 _forceAMFormat = 0;
		//private System.Boolean _offOnRestore = false;
		//private System.Boolean _external = false;
		//private System.String _notes = string.Empty;
		//private System.DateTime _createdOn = new DateTime(1900, 1, 1);
		//private System.String _createdBy = string.Empty;
		//private System.DateTime _modifiedOn = new DateTime(1900, 1, 1);
		//private System.String _modifiedBy = string.Empty;
		//private System.Boolean _alwaysToMAS = false;
		//private System.Byte _panelZoneID = 0;
		//private System.Boolean _locked = false;
		private System.Guid _bDBuildingPK = Guid.Empty;
		private System.Int32 _unitID = 0;
		private System.String _address1 = string.Empty;
		private System.Int32 _buildingID = 0;

		public System.Guid ACInputPK
		{
			get{ return this._aCInputPK; }
			set{ this._aCInputPK = value; }
		}

		public System.Guid ACPanelPK
		{
			get{ return this._aCPanelPK; }
			set{ this._aCPanelPK = value; }
		}

		public System.Byte InputID
		{
			get{ return this._inputID; }
			set{ this._inputID = value; }
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

//		public System.Boolean Reverse
//		{
//			get{ return this._reverse; }
//			set{ this._reverse = value; }
//		}

//		public System.Int16 ForceAMFormat
//		{
//			get{ return this._forceAMFormat; }
//			set{ this._forceAMFormat = value; }
//		}

//		public System.Boolean OffOnRestore
//		{
//			get{ return this._offOnRestore; }
//			set{ this._offOnRestore = value; }
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

//		public System.Boolean AlwaysToMAS
//		{
//			get{ return this._alwaysToMAS; }
//			set{ this._alwaysToMAS = value; }
//		}

//		public System.Byte PanelZoneID
//		{
//			get{ return this._panelZoneID; }
//			set{ this._panelZoneID = value; }
//		}

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

		public ACInputView()
		{
		}

		public ACInputView(ACInputData data)
		{
			this.ACInputPK = data.ACInputPK;
			this.ACPanelPK = data.ACPanelPK;
			this.InputID = data.InputID;
			this.Description = data.Description;
			//this.Debounce = data.Debounce;
			//this.Reverse = data.Reverse;
			//this.ForceAMFormat = data.ForceAMFormat;
			//this.OffOnRestore = data.OffOnRestore;
			//this.External = data.External;
			//this.Notes = data.Notes;
			//this.CreatedOn = data.CreatedOn;
			//this.CreatedBy = data.CreatedBy;
			//this.ModifiedOn = data.ModifiedOn;
			//this.ModifiedBy = data.ModifiedBy;
			//this.AlwaysToMAS = data.AlwaysToMAS;
			//this.PanelZoneID = data.PanelZoneID;
			//this.Locked = data.Locked;
			this.BDBuildingPK = data.BDBuildingPK;
			this.UnitID = data.UnitID;
			this.Address1 = data.Address1;
			this.BuildingID = data.BuildingID;
		}


		public ACInputData ToACInputData()
		{
			ACInputData entity = new ACInputData();
			entity.ACInputPK = this.ACInputPK;
			entity.ACPanelPK = this.ACPanelPK;
			entity.InputID = this.InputID;
			entity.Description = this.Description;
			//entity.Debounce = this.Debounce;
			//entity.Reverse = this.Reverse;
			//entity.ForceAMFormat = this.ForceAMFormat;
			//entity.OffOnRestore = this.OffOnRestore;
			//entity.External = this.External;
			//entity.Notes = this.Notes;
			//entity.CreatedOn = this.CreatedOn;
			//entity.CreatedBy = this.CreatedBy;
			//entity.ModifiedOn = this.ModifiedOn;
			//entity.ModifiedBy = this.ModifiedBy;
			//entity.AlwaysToMAS = this.AlwaysToMAS;
			//entity.PanelZoneID = this.PanelZoneID;
			//entity.Locked = this.Locked;
			entity.BDBuildingPK = this.BDBuildingPK;
			entity.UnitID = this.UnitID;
			entity.Address1 = this.Address1;
			entity.BuildingID = this.BuildingID;

			return entity;
		}
	}
}
