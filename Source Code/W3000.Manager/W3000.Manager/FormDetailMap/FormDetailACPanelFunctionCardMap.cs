using Cheke.WinCtrl;
using W3000.ViewObj;
using W3000.Schema;

namespace W3000.Manager.FormDetailMap
{
	public partial class FormDetailACPanelFunctionCardMap : FormDetailMapBase
	{
		public FormDetailACPanelFunctionCardMap()
		{
			InitializeComponent();
		}

		public FormDetailACPanelFunctionCardMap(string userid, ACPanelFunctionCardMap entity, bool editable)
			: base(userid, entity, editable)
		{
			InitializeComponent();
		}

		public ACPanelFunctionCardMap ACPanelFunctionCardMap
		{
			get{ return base.Entity as ACPanelFunctionCardMap; }
		}

		protected override void DataBinding()
		{
			this.txtSitecode.BindingData(this.ACPanelFunctionCardMap, ACPanelFunctionCardMapSchema.Sitecode);
			this.txtEmbossed.BindingData(this.ACPanelFunctionCardMap, ACPanelFunctionCardMapSchema.Embossed);
			this.txtCardTypeID.BindingData(this.ACPanelFunctionCardMap, ACPanelFunctionCardMapSchema.CardTypeID);
			this.txtEncoded.BindingData(this.ACPanelFunctionCardMap, ACPanelFunctionCardMapSchema.Encoded);
			this.txtUnitID.BindingData(this.ACPanelFunctionCardMap, ACPanelFunctionCardMapSchema.UnitID);
		}

	}
}
