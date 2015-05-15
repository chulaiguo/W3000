using Cheke.WinCtrl;
using W3000.ViewObj;
using W3000.Schema;

namespace W3000.Manager.FormDetailMap
{
	public partial class FormDetailUsrAccountTenantMap : FormDetailMapBase
	{
		public FormDetailUsrAccountTenantMap()
		{
			InitializeComponent();
		}

		public FormDetailUsrAccountTenantMap(string userid, UsrAccountTenantMap entity, bool editable)
			: base(userid, entity, editable)
		{
			InitializeComponent();
		}

		public UsrAccountTenantMap UsrAccountTenantMap
		{
			get{ return base.Entity as UsrAccountTenantMap; }
		}

		protected override void DataBinding()
		{
			this.txtAddress1.BindingData(this.UsrAccountTenantMap, UsrAccountTenantMapSchema.Address1);
			this.txtBuildingID.BindingData(this.UsrAccountTenantMap, UsrAccountTenantMapSchema.BuildingID);
			this.txtTenant.BindingData(this.UsrAccountTenantMap, UsrAccountTenantMapSchema.Tenant);
			this.txtUserID.BindingData(this.UsrAccountTenantMap, UsrAccountTenantMapSchema.UserID);
		}

	}
}
