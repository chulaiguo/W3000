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
	public class GridSelectUsrGroupDecorator : GridControlDecorator
	{
		public GridSelectUsrGroupDecorator(string userId, GridControl gridControl)
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
			GridColumn colUsrGroupName = new GridColumn();
			colUsrGroupName.Caption = "UsrGroupName";
			colUsrGroupName.FieldName = UsrGroupViewSchema.UsrGroupName;
			colUsrGroupName.VisibleIndex = view.Columns.Count;
			colUsrGroupName.OptionsColumn.AllowEdit = false;
			colUsrGroupName.OptionsColumn.AllowFocus = false;
			view.Columns.Add(colUsrGroupName);

		}

		protected override void NavigatorEditClick(GridView view, NavigatorButtonClickEventArgs e)
		{
			e.Handled = true;
		}
	}
}
