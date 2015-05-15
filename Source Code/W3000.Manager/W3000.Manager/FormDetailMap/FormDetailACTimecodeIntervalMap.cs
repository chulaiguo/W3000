using Cheke.WinCtrl;
using W3000.ViewObj;
using W3000.Schema;

namespace W3000.Manager.FormDetailMap
{
	public partial class FormDetailACTimecodeIntervalMap : FormDetailMapBase
	{
		public FormDetailACTimecodeIntervalMap()
		{
			InitializeComponent();
		}

		public FormDetailACTimecodeIntervalMap(string userid, ACTimecodeIntervalMap entity, bool editable)
			: base(userid, entity, editable)
		{
			InitializeComponent();
		}

		public ACTimecodeIntervalMap ACTimecodeIntervalMap
		{
			get{ return base.Entity as ACTimecodeIntervalMap; }
		}

		protected override void DataBinding()
		{
			this.txtAddress1.BindingData(this.ACTimecodeIntervalMap, ACTimecodeIntervalMapSchema.Address1);
			this.txtBuildingID.BindingData(this.ACTimecodeIntervalMap, ACTimecodeIntervalMapSchema.BuildingID);
			this.txtIVID.BindingData(this.ACTimecodeIntervalMap, ACTimecodeIntervalMapSchema.IVID);
			this.txtTCID.BindingData(this.ACTimecodeIntervalMap, ACTimecodeIntervalMapSchema.TCID);
		}

	}
}
