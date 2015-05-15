using Cheke.WinCtrl;
using W3000.ViewObj;
using W3000.Schema;

namespace W3000.Manager.FormDetailMap
{
	public partial class FormDetailACPanelHolidayMap : FormDetailMapBase
	{
		public FormDetailACPanelHolidayMap()
		{
			InitializeComponent();
		}

		public FormDetailACPanelHolidayMap(string userid, ACPanelHolidayMap entity, bool editable)
			: base(userid, entity, editable)
		{
			InitializeComponent();
		}

		public ACPanelHolidayMap ACPanelHolidayMap
		{
			get{ return base.Entity as ACPanelHolidayMap; }
		}

		protected override void DataBinding()
		{
			this.txtCountryID.BindingData(this.ACPanelHolidayMap, ACPanelHolidayMapSchema.CountryID);
			this.txtHoliday.BindingData(this.ACPanelHolidayMap, ACPanelHolidayMapSchema.Holiday);
			this.dateDate.BindingData(this.ACPanelHolidayMap, ACPanelHolidayMapSchema.Date);
			this.txtUnitID.BindingData(this.ACPanelHolidayMap, ACPanelHolidayMapSchema.UnitID);
		}

	}
}
