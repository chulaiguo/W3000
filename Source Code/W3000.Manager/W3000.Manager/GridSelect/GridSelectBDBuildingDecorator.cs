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
	public class GridSelectBDBuildingDecorator : GridControlDecorator
	{
		public GridSelectBDBuildingDecorator(string userId, GridControl gridControl)
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
			GridColumn colBuildingID = new GridColumn();
			colBuildingID.Caption = "BuildingID";
			colBuildingID.FieldName = BDBuildingViewSchema.BuildingID;
			colBuildingID.VisibleIndex = view.Columns.Count;
			colBuildingID.OptionsColumn.AllowEdit = false;
			colBuildingID.OptionsColumn.AllowFocus = false;
			view.Columns.Add(colBuildingID);

			GridColumn colAddress1 = new GridColumn();
			colAddress1.Caption = "Address1";
			colAddress1.FieldName = BDBuildingViewSchema.Address1;
			colAddress1.VisibleIndex = view.Columns.Count;
			colAddress1.OptionsColumn.AllowEdit = false;
			colAddress1.OptionsColumn.AllowFocus = false;
			view.Columns.Add(colAddress1);

			GridColumn colCity = new GridColumn();
			colCity.Caption = "City";
			colCity.FieldName = BDBuildingViewSchema.City;
			colCity.VisibleIndex = view.Columns.Count;
			colCity.OptionsColumn.AllowEdit = false;
			colCity.OptionsColumn.AllowFocus = false;
			view.Columns.Add(colCity);

			GridColumn colState = new GridColumn();
			colState.Caption = "State";
			colState.FieldName = BDBuildingViewSchema.State;
			colState.VisibleIndex = view.Columns.Count;
			colState.OptionsColumn.AllowEdit = false;
			colState.OptionsColumn.AllowFocus = false;
			view.Columns.Add(colState);

			GridColumn colZipcode = new GridColumn();
			colZipcode.Caption = "Zipcode";
			colZipcode.FieldName = BDBuildingViewSchema.Zipcode;
			colZipcode.VisibleIndex = view.Columns.Count;
			colZipcode.OptionsColumn.AllowEdit = false;
			colZipcode.OptionsColumn.AllowFocus = false;
			view.Columns.Add(colZipcode);

			GridColumn colCountryID = new GridColumn();
			colCountryID.Caption = "CountryID";
			colCountryID.FieldName = BDBuildingViewSchema.CountryID;
			colCountryID.VisibleIndex = view.Columns.Count;
			colCountryID.OptionsColumn.AllowEdit = false;
			colCountryID.OptionsColumn.AllowFocus = false;
			view.Columns.Add(colCountryID);

		}

		protected override void NavigatorEditClick(GridView view, NavigatorButtonClickEventArgs e)
		{
			e.Handled = true;
		}
	}
}
