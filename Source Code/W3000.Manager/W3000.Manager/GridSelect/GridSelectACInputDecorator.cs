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
	public class GridSelectACInputDecorator : GridControlDecorator
	{
		public GridSelectACInputDecorator(string userId, GridControl gridControl)
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
			GridColumn colInputID = new GridColumn();
			colInputID.Caption = "InputID";
			colInputID.FieldName = ACInputViewSchema.InputID;
			colInputID.VisibleIndex = view.Columns.Count;
			colInputID.OptionsColumn.AllowEdit = false;
			colInputID.OptionsColumn.AllowFocus = false;
			view.Columns.Add(colInputID);

			GridColumn colDescription = new GridColumn();
			colDescription.Caption = "Description";
			colDescription.FieldName = ACInputViewSchema.Description;
			colDescription.VisibleIndex = view.Columns.Count;
			colDescription.OptionsColumn.AllowEdit = false;
			colDescription.OptionsColumn.AllowFocus = false;
			view.Columns.Add(colDescription);

			GridColumn colPanelZoneID = new GridColumn();
			colPanelZoneID.Caption = "PanelZoneID";
			colPanelZoneID.FieldName = ACInputViewSchema.PanelZoneID;
			colPanelZoneID.VisibleIndex = view.Columns.Count;
			colPanelZoneID.OptionsColumn.AllowEdit = false;
			colPanelZoneID.OptionsColumn.AllowFocus = false;
			view.Columns.Add(colPanelZoneID);

			GridColumn colUnitID = new GridColumn();
			colUnitID.Caption = "UnitID";
			colUnitID.FieldName = ACInputViewSchema.UnitID;
			colUnitID.VisibleIndex = view.Columns.Count;
			colUnitID.OptionsColumn.AllowEdit = false;
			colUnitID.OptionsColumn.AllowFocus = false;
			view.Columns.Add(colUnitID);

			GridColumn colAddress1 = new GridColumn();
			colAddress1.Caption = "Address1";
			colAddress1.FieldName = ACInputViewSchema.Address1;
			colAddress1.VisibleIndex = view.Columns.Count;
			colAddress1.OptionsColumn.AllowEdit = false;
			colAddress1.OptionsColumn.AllowFocus = false;
			view.Columns.Add(colAddress1);

			GridColumn colBuildingID = new GridColumn();
			colBuildingID.Caption = "BuildingID";
			colBuildingID.FieldName = ACInputViewSchema.BuildingID;
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
