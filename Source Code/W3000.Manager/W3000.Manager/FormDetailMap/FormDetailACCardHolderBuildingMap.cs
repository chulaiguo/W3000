using Cheke.WinCtrl;
using W3000.ViewObj;
using W3000.Schema;

namespace W3000.Manager.FormDetailMap
{
	public partial class FormDetailACCardHolderBuildingMap : FormDetailMapBase
	{
		public FormDetailACCardHolderBuildingMap()
		{
			InitializeComponent();
		}

		public FormDetailACCardHolderBuildingMap(string userid, ACCardHolderBuildingMap entity, bool editable)
			: base(userid, entity, editable)
		{
			InitializeComponent();
		}

		public ACCardHolderBuildingMap ACCardHolderBuildingMap
		{
			get{ return base.Entity as ACCardHolderBuildingMap; }
		}

		protected override void DataBinding()
		{
			this.txtAL1st.BindingData(this.ACCardHolderBuildingMap, ACCardHolderBuildingMapSchema.AL1st);
			this.txtAL2nd.BindingData(this.ACCardHolderBuildingMap, ACCardHolderBuildingMapSchema.AL2nd);
			this.txtAddress1.BindingData(this.ACCardHolderBuildingMap, ACCardHolderBuildingMapSchema.Address1);
			this.txtBuildingID.BindingData(this.ACCardHolderBuildingMap, ACCardHolderBuildingMapSchema.BuildingID);
			this.txtSitecode.BindingData(this.ACCardHolderBuildingMap, ACCardHolderBuildingMapSchema.Sitecode);
			this.txtEmbossed.BindingData(this.ACCardHolderBuildingMap, ACCardHolderBuildingMapSchema.Embossed);
			this.txtCardTypeID.BindingData(this.ACCardHolderBuildingMap, ACCardHolderBuildingMapSchema.CardTypeID);
			this.txtEncoded.BindingData(this.ACCardHolderBuildingMap, ACCardHolderBuildingMapSchema.Encoded);
		}

	}
}
