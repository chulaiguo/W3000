using Cheke.WinCtrl;
using W3000.ViewObj;
using W3000.Schema;

namespace W3000.Manager.FormDetailMap
{
	public partial class FormDetailACInputGroupInputMap : FormDetailMapBase
	{
		public FormDetailACInputGroupInputMap()
		{
			InitializeComponent();
		}

		public FormDetailACInputGroupInputMap(string userid, ACInputGroupInputMap entity, bool editable)
			: base(userid, entity, editable)
		{
			InitializeComponent();
		}

		public ACInputGroupInputMap ACInputGroupInputMap
		{
			get{ return base.Entity as ACInputGroupInputMap; }
		}

		protected override void DataBinding()
		{
			this.txtUnitID.BindingData(this.ACInputGroupInputMap, ACInputGroupInputMapSchema.UnitID);
			this.txtGroupID.BindingData(this.ACInputGroupInputMap, ACInputGroupInputMapSchema.GroupID);
		}

	}
}
