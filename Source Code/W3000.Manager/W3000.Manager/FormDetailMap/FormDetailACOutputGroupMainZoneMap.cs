using Cheke.WinCtrl;
using W3000.ViewObj;
using W3000.Schema;

namespace W3000.Manager.FormDetailMap
{
	public partial class FormDetailACOutputGroupMainZoneMap : FormDetailMapBase
	{
		public FormDetailACOutputGroupMainZoneMap()
		{
			InitializeComponent();
		}

		public FormDetailACOutputGroupMainZoneMap(string userid, ACOutputGroupMainZoneMap entity, bool editable)
			: base(userid, entity, editable)
		{
			InitializeComponent();
		}

		public ACOutputGroupMainZoneMap ACOutputGroupMainZoneMap
		{
			get{ return base.Entity as ACOutputGroupMainZoneMap; }
		}

		protected override void DataBinding()
		{
			this.txtUnitID.BindingData(this.ACOutputGroupMainZoneMap, ACOutputGroupMainZoneMapSchema.UnitID);
			this.txtGroupID.BindingData(this.ACOutputGroupMainZoneMap, ACOutputGroupMainZoneMapSchema.GroupID);
		}

	}
}
