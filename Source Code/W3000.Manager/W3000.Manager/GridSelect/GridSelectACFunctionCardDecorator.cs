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
	public class GridSelectACFunctionCardDecorator : GridControlDecorator
	{
		public GridSelectACFunctionCardDecorator(string userId, GridControl gridControl)
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
			GridColumn colSitecode = new GridColumn();
			colSitecode.Caption = "Sitecode";
			colSitecode.FieldName = ACFunctionCardViewSchema.Sitecode;
			colSitecode.VisibleIndex = view.Columns.Count;
			colSitecode.OptionsColumn.AllowEdit = false;
			colSitecode.OptionsColumn.AllowFocus = false;
			view.Columns.Add(colSitecode);

			GridColumn colEmbossed = new GridColumn();
			colEmbossed.Caption = "Embossed";
			colEmbossed.FieldName = ACFunctionCardViewSchema.Embossed;
			colEmbossed.VisibleIndex = view.Columns.Count;
			colEmbossed.OptionsColumn.AllowEdit = false;
			colEmbossed.OptionsColumn.AllowFocus = false;
			view.Columns.Add(colEmbossed);

			GridColumn colEncoded = new GridColumn();
			colEncoded.Caption = "Encoded";
			colEncoded.FieldName = ACFunctionCardViewSchema.Encoded;
			colEncoded.VisibleIndex = view.Columns.Count;
			colEncoded.OptionsColumn.AllowEdit = false;
			colEncoded.OptionsColumn.AllowFocus = false;
			view.Columns.Add(colEncoded);

			GridColumn colCardTypeID = new GridColumn();
			colCardTypeID.Caption = "CardTypeID";
			colCardTypeID.FieldName = ACFunctionCardViewSchema.CardTypeID;
			colCardTypeID.VisibleIndex = view.Columns.Count;
			colCardTypeID.OptionsColumn.AllowEdit = false;
			colCardTypeID.OptionsColumn.AllowFocus = false;
			view.Columns.Add(colCardTypeID);

			GridColumn colTenant = new GridColumn();
			colTenant.Caption = "Tenant";
			colTenant.FieldName = ACFunctionCardViewSchema.Tenant;
			colTenant.VisibleIndex = view.Columns.Count;
			colTenant.OptionsColumn.AllowEdit = false;
			colTenant.OptionsColumn.AllowFocus = false;
			view.Columns.Add(colTenant);

		}

		protected override void NavigatorEditClick(GridView view, NavigatorButtonClickEventArgs e)
		{
			e.Handled = true;
		}
	}
}
