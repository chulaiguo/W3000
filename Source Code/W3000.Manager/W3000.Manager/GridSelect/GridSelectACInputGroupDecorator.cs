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
	public class GridSelectACInputGroupDecorator : GridControlDecorator
	{
		public GridSelectACInputGroupDecorator(string userId, GridControl gridControl)
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
			GridColumn colGroupID = new GridColumn();
			colGroupID.Caption = "GroupID";
			colGroupID.FieldName = ACInputGroupViewSchema.GroupID;
			colGroupID.VisibleIndex = view.Columns.Count;
			colGroupID.OptionsColumn.AllowEdit = false;
			colGroupID.OptionsColumn.AllowFocus = false;
			view.Columns.Add(colGroupID);

			GridColumn colSummary = new GridColumn();
			colSummary.Caption = "Summary";
			colSummary.FieldName = ACInputGroupViewSchema.Summary;
			colSummary.VisibleIndex = view.Columns.Count;
			colSummary.OptionsColumn.AllowEdit = false;
			colSummary.OptionsColumn.AllowFocus = false;
			view.Columns.Add(colSummary);

			GridColumn colUnitID = new GridColumn();
			colUnitID.Caption = "UnitID";
			colUnitID.FieldName = ACInputGroupViewSchema.UnitID;
			colUnitID.VisibleIndex = view.Columns.Count;
			colUnitID.OptionsColumn.AllowEdit = false;
			colUnitID.OptionsColumn.AllowFocus = false;
			view.Columns.Add(colUnitID);

		}

		protected override void NavigatorEditClick(GridView view, NavigatorButtonClickEventArgs e)
		{
			e.Handled = true;
		}
	}
}
