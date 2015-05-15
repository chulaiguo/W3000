using Cheke.WinCtrl;
using W3000.ViewObj;
using W3000.Schema;

namespace W3000.Manager.FormDetailMap
{
	public partial class FormDetailUsrAccountBuildingMap : FormDetailMapBase
	{
		public FormDetailUsrAccountBuildingMap()
		{
			InitializeComponent();
		}

		public FormDetailUsrAccountBuildingMap(string userid, UsrAccountBuildingMap entity, bool editable)
			: base(userid, entity, editable)
		{
			InitializeComponent();
		}

		public UsrAccountBuildingMap UsrAccountBuildingMap
		{
			get{ return base.Entity as UsrAccountBuildingMap; }
		}

		protected override void DataBinding()
		{
			this.chkBuildingWide.BindingData(this.UsrAccountBuildingMap, UsrAccountBuildingMapSchema.BuildingWide);
			this.txtAccessTC.BindingData(this.UsrAccountBuildingMap, UsrAccountBuildingMapSchema.AccessTC);
			this.txtPermission.BindingData(this.UsrAccountBuildingMap, UsrAccountBuildingMapSchema.Permission);
			this.chkPrimary.BindingData(this.UsrAccountBuildingMap, UsrAccountBuildingMapSchema.Primary);
			this.txtAddress1.BindingData(this.UsrAccountBuildingMap, UsrAccountBuildingMapSchema.Address1);
			this.txtBuildingID.BindingData(this.UsrAccountBuildingMap, UsrAccountBuildingMapSchema.BuildingID);
			this.txtUserID.BindingData(this.UsrAccountBuildingMap, UsrAccountBuildingMapSchema.UserID);
		}

	}
}
