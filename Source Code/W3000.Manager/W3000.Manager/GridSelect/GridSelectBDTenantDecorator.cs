using W3000.Schema;
using Cheke.WinCtrl.Decoration;
using DevExpress.Data;
using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;

namespace W3000.Manager.GridSelect
{
	public class GridSelectBDTenantDecorator : GridControlDecorator
	{
		public GridSelectBDTenantDecorator(string userId, GridControl gridControl)
			: base(userId, gridControl)
		{
		}

		public override void Initialize()
		{
			base.Initialize();

			base.GridView.OptionsView.ShowGroupPanel = false;
			base.MenuController.MenuOptions.ShowHistoryMenu = false;
			base.MenuController.MenuOptions.ShowRefreshMenu = false;
		}

		protected override void SetDisplayColumns(GridView view)
		{
			GridColumn colTenant = new GridColumn();
			colTenant.Caption = "Tenant";
			colTenant.FieldName = BDTenantViewSchema.Tenant;
			colTenant.VisibleIndex = view.Columns.Count;
			colTenant.OptionsColumn.AllowEdit = false;
			colTenant.OptionsColumn.AllowFocus = false;
			view.Columns.Add(colTenant);

			GridColumn colSuite = new GridColumn();
			colSuite.Caption = "Suite";
			colSuite.FieldName = BDTenantViewSchema.Suite;
			colSuite.VisibleIndex = view.Columns.Count;
			colSuite.OptionsColumn.AllowEdit = false;
			colSuite.OptionsColumn.AllowFocus = false;
			view.Columns.Add(colSuite);

			GridColumn colAddress1 = new GridColumn();
			colAddress1.Caption = "Address1";
			colAddress1.FieldName = BDTenantViewSchema.Address1;
			colAddress1.VisibleIndex = view.Columns.Count;
			colAddress1.OptionsColumn.AllowEdit = false;
			colAddress1.OptionsColumn.AllowFocus = false;
			view.Columns.Add(colAddress1);

			GridColumn colBuildingID = new GridColumn();
			colBuildingID.Caption = "BuildingID";
			colBuildingID.FieldName = BDTenantViewSchema.BuildingID;
			colBuildingID.VisibleIndex = view.Columns.Count;
			colBuildingID.OptionsColumn.AllowEdit = false;
			colBuildingID.OptionsColumn.AllowFocus = false;
			view.Columns.Add(colBuildingID);

		}

		protected override void NavigatorEditClick(GridView view, NavigatorButtonClickEventArgs e)
		{
			e.Handled = true;
		}
	}
}
