using Cheke.WinCtrl;
using W3000.ViewObj;
using W3000.Schema;

namespace W3000.Manager.FormDetailMap
{
	public partial class FormDetailACIntvalHolidayMap : FormDetailMapBase
	{
		public FormDetailACIntvalHolidayMap()
		{
			InitializeComponent();
		}

		public FormDetailACIntvalHolidayMap(string userid, ACIntvalHolidayMap entity, bool editable)
			: base(userid, entity, editable)
		{
			InitializeComponent();
		}

		public ACIntvalHolidayMap ACIntvalHolidayMap
		{
			get{ return base.Entity as ACIntvalHolidayMap; }
		}

		protected override void DataBinding()
		{
			this.txtAddress1.BindingData(this.ACIntvalHolidayMap, ACIntvalHolidayMapSchema.Address1);
			this.txtBuildingID.BindingData(this.ACIntvalHolidayMap, ACIntvalHolidayMapSchema.BuildingID);
			this.txtIVID.BindingData(this.ACIntvalHolidayMap, ACIntvalHolidayMapSchema.IVID);
			this.txtHoliday.BindingData(this.ACIntvalHolidayMap, ACIntvalHolidayMapSchema.Holiday);
			this.dateDate.BindingData(this.ACIntvalHolidayMap, ACIntvalHolidayMapSchema.Date);
		}

	}
}
