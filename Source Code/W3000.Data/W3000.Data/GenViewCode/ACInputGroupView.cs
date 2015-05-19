using System;

namespace W3000.Data
{
	[Serializable]
	public partial class ACInputGroupView
	{
		private System.Guid _aCInputGroupPK = Guid.Empty;
		private System.Guid _aCPanelPK = Guid.Empty;
		private System.Byte _groupID = 0;
		private System.String _summary = string.Empty;
		//private System.DateTime _createdOn = new DateTime(1900, 1, 1);
		//private System.String _createdBy = string.Empty;
		//private System.DateTime _modifiedOn = new DateTime(1900, 1, 1);
		//private System.String _modifiedBy = string.Empty;
		private System.Guid _bDBuildingPK = Guid.Empty;
		private System.Int32 _unitID = 0;
		private System.String _address1 = string.Empty;
		private System.Int32 _buildingID = 0;

		public System.Guid ACInputGroupPK
		{
			get{ return this._aCInputGroupPK; }
			set{ this._aCInputGroupPK = value; }
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

		public System.String Summary
		{
			get{ return this._summary; }
			set{ this._summary = value; }
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

		public ACInputGroupView()
		{
		}

		public ACInputGroupView(ACInputGroupData data)
		{
			this.ACInputGroupPK = data.ACInputGroupPK;
			this.ACPanelPK = data.ACPanelPK;
			this.GroupID = data.GroupID;
			this.Summary = data.Summary;
			//this.CreatedOn = data.CreatedOn;
			//this.CreatedBy = data.CreatedBy;
			//this.ModifiedOn = data.ModifiedOn;
			//this.ModifiedBy = data.ModifiedBy;
			this.BDBuildingPK = data.BDBuildingPK;
			this.UnitID = data.UnitID;
			this.Address1 = data.Address1;
			this.BuildingID = data.BuildingID;
		}


		public ACInputGroupData ToACInputGroupData()
		{
			ACInputGroupData entity = new ACInputGroupData();
			entity.ACInputGroupPK = this.ACInputGroupPK;
			entity.ACPanelPK = this.ACPanelPK;
			entity.GroupID = this.GroupID;
			entity.Summary = this.Summary;
			//entity.CreatedOn = this.CreatedOn;
			//entity.CreatedBy = this.CreatedBy;
			//entity.ModifiedOn = this.ModifiedOn;
			//entity.ModifiedBy = this.ModifiedBy;
			entity.BDBuildingPK = this.BDBuildingPK;
			entity.UnitID = this.UnitID;
			entity.Address1 = this.Address1;
			entity.BuildingID = this.BuildingID;

			return entity;
		}
	}
}
