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
	public class GridSelectACMainZoneDecorator : GridControlDecorator
	{
		public GridSelectACMainZoneDecorator(string userId, GridControl gridControl)
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
			GridColumn colMainZoneID = new GridColumn();
			colMainZoneID.Caption = "MainZoneID";
			colMainZoneID.FieldName = ACMainZoneViewSchema.MainZoneID;
			colMainZoneID.VisibleIndex = view.Columns.Count;
			colMainZoneID.OptionsColumn.AllowEdit = false;
			colMainZoneID.OptionsColumn.AllowFocus = false;
			view.Columns.Add(colMainZoneID);

			GridColumn colMainZoneTypeID = new GridColumn();
			colMainZoneTypeID.Caption = "MainZoneTypeID";
			colMainZoneTypeID.FieldName = ACMainZoneViewSchema.MainZoneTypeID;
			colMainZoneTypeID.VisibleIndex = view.Columns.Count;
			colMainZoneTypeID.OptionsColumn.AllowEdit = false;
			colMainZoneTypeID.OptionsColumn.AllowFocus = false;
			view.Columns.Add(colMainZoneTypeID);

			GridColumn colDescription = new GridColumn();
			colDescription.Caption = "Description";
			colDescription.FieldName = ACMainZoneViewSchema.Description;
			colDescription.VisibleIndex = view.Columns.Count;
			colDescription.OptionsColumn.AllowEdit = false;
			colDescription.OptionsColumn.AllowFocus = false;
			view.Columns.Add(colDescription);

			GridColumn colUnitID = new GridColumn();
			colUnitID.Caption = "UnitID";
			colUnitID.FieldName = ACMainZoneViewSchema.UnitID;
			colUnitID.VisibleIndex = view.Columns.Count;
			colUnitID.OptionsColumn.AllowEdit = false;
			colUnitID.OptionsColumn.AllowFocus = false;
			view.Columns.Add(colUnitID);

			GridColumn colAddress1 = new GridColumn();
			colAddress1.Caption = "Address1";
			colAddress1.FieldName = ACMainZoneViewSchema.Address1;
			colAddress1.VisibleIndex = view.Columns.Count;
			colAddress1.OptionsColumn.AllowEdit = false;
			colAddress1.OptionsColumn.AllowFocus = false;
			view.Columns.Add(colAddress1);

			GridColumn colBuildingID = new GridColumn();
			colBuildingID.Caption = "BuildingID";
			colBuildingID.FieldName = ACMainZoneViewSchema.BuildingID;
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
