using Cheke.WinCtrl;
using W3000.ViewObj;
using W3000.Schema;

namespace W3000.Manager.FormDetailMap
{
	public partial class FormDetailBDTenantHolidayMap : FormDetailMapBase
	{
		public FormDetailBDTenantHolidayMap()
		{
			InitializeComponent();
		}

		public FormDetailBDTenantHolidayMap(string userid, BDTenantHolidayMap entity, bool editable)
			: base(userid, entity, editable)
		{
			InitializeComponent();
		}

		public BDTenantHolidayMap BDTenantHolidayMap
		{
			get{ return base.Entity as BDTenantHolidayMap; }
		}

		protected override void DataBinding()
		{
			this.txtActionID.BindingData(this.BDTenantHolidayMap, BDTenantHolidayMapSchema.ActionID);
			this.txtNotes.BindingData(this.BDTenantHolidayMap, BDTenantHolidayMapSchema.Notes);
			this.txtAddress1.BindingData(this.BDTenantHolidayMap, BDTenantHolidayMapSchema.Address1);
			this.txtBuildingID.BindingData(this.BDTenantHolidayMap, BDTenantHolidayMapSchema.BuildingID);
			this.txtTenant.BindingData(this.BDTenantHolidayMap, BDTenantHolidayMapSchema.Tenant);
			this.txtHoliday.BindingData(this.BDTenantHolidayMap, BDTenantHolidayMapSchema.Holiday);
			this.dateDate.BindingData(this.BDTenantHolidayMap, BDTenantHolidayMapSchema.Date);
		}

	}
}
