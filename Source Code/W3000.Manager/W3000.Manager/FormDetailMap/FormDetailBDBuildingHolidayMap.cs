using Cheke.WinCtrl;
using W3000.ViewObj;
using W3000.Schema;

namespace W3000.Manager.FormDetailMap
{
	public partial class FormDetailBDBuildingHolidayMap : FormDetailMapBase
	{
		public FormDetailBDBuildingHolidayMap()
		{
			InitializeComponent();
		}

		public FormDetailBDBuildingHolidayMap(string userid, BDBuildingHolidayMap entity, bool editable)
			: base(userid, entity, editable)
		{
			InitializeComponent();
		}

		public BDBuildingHolidayMap BDBuildingHolidayMap
		{
			get{ return base.Entity as BDBuildingHolidayMap; }
		}

		protected override void DataBinding()
		{
			this.txtActionID.BindingData(this.BDBuildingHolidayMap, BDBuildingHolidayMapSchema.ActionID);
			this.txtNotes.BindingData(this.BDBuildingHolidayMap, BDBuildingHolidayMapSchema.Notes);
			this.txtAddress1.BindingData(this.BDBuildingHolidayMap, BDBuildingHolidayMapSchema.Address1);
			this.txtBuildingID.BindingData(this.BDBuildingHolidayMap, BDBuildingHolidayMapSchema.BuildingID);
			this.txtHoliday.BindingData(this.BDBuildingHolidayMap, BDBuildingHolidayMapSchema.Holiday);
			this.dateDate.BindingData(this.BDBuildingHolidayMap, BDBuildingHolidayMapSchema.Date);
		}

	}
}
