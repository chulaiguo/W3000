using System;

namespace W3000.Data
{
	[Serializable]
	public partial class ACPanelFunctionCardMapView
	{
		private System.Guid _aCPanelFunctionCardMapPK = Guid.Empty;
		private System.Guid _aCPanelPK = Guid.Empty;
		private System.Guid _aCFunctionCardPK = Guid.Empty;
		//private System.DateTime _createdOn = new DateTime(1900, 1, 1);
		//private System.String _createdBy = string.Empty;
		//private System.DateTime _modifiedOn = new DateTime(1900, 1, 1);
		//private System.String _modifiedBy = string.Empty;
		private System.Int32 _cardTypeID = 0;
		private System.Int32 _encoded = 0;
		private System.Int32 _embossed = 0;
		private System.Int32 _sitecode = 0;
		private System.Guid _bDBuildingPK = Guid.Empty;
		private System.Int32 _unitID = 0;

		public System.Guid ACPanelFunctionCardMapPK
		{
			get{ return this._aCPanelFunctionCardMapPK; }
			set{ this._aCPanelFunctionCardMapPK = value; }
		}

		public System.Guid ACPanelPK
		{
			get{ return this._aCPanelPK; }
			set{ this._aCPanelPK = value; }
		}

		public System.Guid ACFunctionCardPK
		{
			get{ return this._aCFunctionCardPK; }
			set{ this._aCFunctionCardPK = value; }
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

		public System.Int32 CardTypeID
		{
			get{ return this._cardTypeID; }
			set{ this._cardTypeID = value; }
		}

		public System.Int32 Encoded
		{
			get{ return this._encoded; }
			set{ this._encoded = value; }
		}

		public System.Int32 Embossed
		{
			get{ return this._embossed; }
			set{ this._embossed = value; }
		}

		public System.Int32 Sitecode
		{
			get{ return this._sitecode; }
			set{ this._sitecode = value; }
		}

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

		public ACPanelFunctionCardMapView()
		{
		}

		public ACPanelFunctionCardMapView(ACPanelFunctionCardMapData data)
		{
			this.ACPanelFunctionCardMapPK = data.ACPanelFunctionCardMapPK;
			this.ACPanelPK = data.ACPanelPK;
			this.ACFunctionCardPK = data.ACFunctionCardPK;
			//this.CreatedOn = data.CreatedOn;
			//this.CreatedBy = data.CreatedBy;
			//this.ModifiedOn = data.ModifiedOn;
			//this.ModifiedBy = data.ModifiedBy;
			this.CardTypeID = data.CardTypeID;
			this.Encoded = data.Encoded;
			this.Embossed = data.Embossed;
			this.Sitecode = data.Sitecode;
			this.BDBuildingPK = data.BDBuildingPK;
			this.UnitID = data.UnitID;
		}


		public ACPanelFunctionCardMapData ToACPanelFunctionCardMapData()
		{
			ACPanelFunctionCardMapData entity = new ACPanelFunctionCardMapData();
			entity.ACPanelFunctionCardMapPK = this.ACPanelFunctionCardMapPK;
			entity.ACPanelPK = this.ACPanelPK;
			entity.ACFunctionCardPK = this.ACFunctionCardPK;
			//entity.CreatedOn = this.CreatedOn;
			//entity.CreatedBy = this.CreatedBy;
			//entity.ModifiedOn = this.ModifiedOn;
			//entity.ModifiedBy = this.ModifiedBy;
			entity.CardTypeID = this.CardTypeID;
			entity.Encoded = this.Encoded;
			entity.Embossed = this.Embossed;
			entity.Sitecode = this.Sitecode;
			entity.BDBuildingPK = this.BDBuildingPK;
			entity.UnitID = this.UnitID;

			return entity;
		}
	}
}
