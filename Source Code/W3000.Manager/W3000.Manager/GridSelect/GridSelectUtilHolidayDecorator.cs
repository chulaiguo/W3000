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
	public class GridSelectUtilHolidayDecorator : GridControlDecorator
	{
		public GridSelectUtilHolidayDecorator(string userId, GridControl gridControl)
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
			GridColumn colCountryID = new GridColumn();
			colCountryID.Caption = "CountryID";
			colCountryID.FieldName = UtilHolidayViewSchema.CountryID;
			colCountryID.VisibleIndex = view.Columns.Count;
			colCountryID.OptionsColumn.AllowEdit = false;
			colCountryID.OptionsColumn.AllowFocus = false;
			view.Columns.Add(colCountryID);

			GridColumn colHoliday = new GridColumn();
			colHoliday.Caption = "Holiday";
			colHoliday.FieldName = UtilHolidayViewSchema.Holiday;
			colHoliday.VisibleIndex = view.Columns.Count;
			colHoliday.OptionsColumn.AllowEdit = false;
			colHoliday.OptionsColumn.AllowFocus = false;
			view.Columns.Add(colHoliday);

			GridColumn colDate = new GridColumn();
			colDate.Caption = "Date";
			colDate.FieldName = UtilHolidayViewSchema.Date;
			colDate.VisibleIndex = view.Columns.Count;
			colDate.OptionsColumn.AllowEdit = false;
			colDate.OptionsColumn.AllowFocus = false;
			view.Columns.Add(colDate);

		}

		protected override void NavigatorEditClick(GridView view, NavigatorButtonClickEventArgs e)
		{
			e.Handled = true;
		}
	}
}
