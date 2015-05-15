using Cheke.WinCtrl;
using W3000.ViewObj;
using W3000.Schema;

namespace W3000.Manager.FormDetailMap
{
	public partial class FormDetailACAccessLevelDetail : FormDetailMapBase
	{
		public FormDetailACAccessLevelDetail()
		{
			InitializeComponent();
		}

		public FormDetailACAccessLevelDetail(string userid, ACAccessLevelDetail entity, bool editable)
			: base(userid, entity, editable)
		{
			InitializeComponent();
		}

		public ACAccessLevelDetail ACAccessLevelDetail
		{
			get{ return base.Entity as ACAccessLevelDetail; }
		}

		protected override void DataBinding()
		{
			this.txtUnitID.BindingData(this.ACAccessLevelDetail, ACAccessLevelDetailSchema.UnitID);
			this.txtPanelZoneID.BindingData(this.ACAccessLevelDetail, ACAccessLevelDetailSchema.PanelZoneID);
			this.txtAddress1.BindingData(this.ACAccessLevelDetail, ACAccessLevelDetailSchema.Address1);
			this.txtBuildingID.BindingData(this.ACAccessLevelDetail, ACAccessLevelDetailSchema.BuildingID);
			this.txtTCID.BindingData(this.ACAccessLevelDetail, ACAccessLevelDetailSchema.TCID);
			this.txtAccessLevelID.BindingData(this.ACAccessLevelDetail, ACAccessLevelDetailSchema.AccessLevelID);
		}

	}
}
