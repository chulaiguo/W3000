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
	public class GridSelectACAMFormatDecorator : GridControlDecorator
	{
		public GridSelectACAMFormatDecorator(string userId, GridControl gridControl)
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
			GridColumn colAMFID = new GridColumn();
			colAMFID.Caption = "AMFID";
			colAMFID.FieldName = ACAMFormatViewSchema.AMFID;
			colAMFID.VisibleIndex = view.Columns.Count;
			colAMFID.OptionsColumn.AllowEdit = false;
			colAMFID.OptionsColumn.AllowFocus = false;
			view.Columns.Add(colAMFID);

			GridColumn colSummary = new GridColumn();
			colSummary.Caption = "Summary";
			colSummary.FieldName = ACAMFormatViewSchema.Summary;
			colSummary.VisibleIndex = view.Columns.Count;
			colSummary.OptionsColumn.AllowEdit = false;
			colSummary.OptionsColumn.AllowFocus = false;
			view.Columns.Add(colSummary);

		}

		protected override void NavigatorEditClick(GridView view, NavigatorButtonClickEventArgs e)
		{
			e.Handled = true;
		}
	}
}
