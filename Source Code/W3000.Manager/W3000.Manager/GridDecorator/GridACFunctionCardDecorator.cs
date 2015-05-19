using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using Cheke.WinCtrl.Decoration;
using W3000.ViewObj;
using W3000.Schema;
using W3000.Manager.FormSelect;
using W3000.Manager.FormDetailMap;
using W3000.Manager.FormDetailEditor;

namespace W3000.Manager.GridDecorator
{
	public class GridACFunctionCardDecorator : GridControlDecorator
	{
		private BDTenant _bDTenant = null;

		public GridACFunctionCardDecorator(string userId, GridControl gridControl)
			: base(userId, gridControl)
		{
		}

		public BDTenant BDTenant
		{
			get { return this._bDTenant; }
			set { this._bDTenant = value; }
		}


		protected override void SetDisplayColumns(GridView view)
		{
			GridColumn colSitecode = new GridColumn();
			colSitecode.Caption = "Sitecode";
			colSitecode.FieldName = ACFunctionCardSchema.Sitecode;
			colSitecode.VisibleIndex = view.Columns.Count;
			colSitecode.DisplayFormat.FormatType = FormatType.Numeric;
			colSitecode.DisplayFormat.FormatString = "f0";
			view.Columns.Add(colSitecode);

			GridColumn colEmbossed = new GridColumn();
			colEmbossed.Caption = "Embossed";
			colEmbossed.FieldName = ACFunctionCardSchema.Embossed;
			colEmbossed.VisibleIndex = view.Columns.Count;
			colEmbossed.DisplayFormat.FormatType = FormatType.Numeric;
			colEmbossed.DisplayFormat.FormatString = "f0";
			view.Columns.Add(colEmbossed);

			GridColumn colEncoded = new GridColumn();
			colEncoded.Caption = "Encoded";
			colEncoded.FieldName = ACFunctionCardSchema.Encoded;
			colEncoded.VisibleIndex = view.Columns.Count;
			colEncoded.DisplayFormat.FormatType = FormatType.Numeric;
			colEncoded.DisplayFormat.FormatString = "f0";
			view.Columns.Add(colEncoded);

			GridColumn colCardTypeID = new GridColumn();
			colCardTypeID.Caption = "CardTypeID";
			colCardTypeID.FieldName = ACFunctionCardSchema.CardTypeID;
			colCardTypeID.VisibleIndex = view.Columns.Count;
			colCardTypeID.DisplayFormat.FormatType = FormatType.Numeric;
			colCardTypeID.DisplayFormat.FormatString = "f0";
			view.Columns.Add(colCardTypeID);

			GridColumn colFunctionID = new GridColumn();
			colFunctionID.Caption = "FunctionID";
			colFunctionID.FieldName = ACFunctionCardSchema.FunctionID;
			colFunctionID.VisibleIndex = view.Columns.Count;
			colFunctionID.DisplayFormat.FormatType = FormatType.Numeric;
			colFunctionID.DisplayFormat.FormatString = "f0";
			view.Columns.Add(colFunctionID);

			GridColumn colFirstName = new GridColumn();
			colFirstName.Caption = "FirstName";
			colFirstName.FieldName = ACFunctionCardSchema.FirstName;
			colFirstName.VisibleIndex = view.Columns.Count;
			view.Columns.Add(colFirstName);

			GridColumn colLastName = new GridColumn();
			colLastName.Caption = "LastName";
			colLastName.FieldName = ACFunctionCardSchema.LastName;
			colLastName.VisibleIndex = view.Columns.Count;
			view.Columns.Add(colLastName);

			GridColumn colFIPS = new GridColumn();
			colFIPS.Caption = "FIPS";
			colFIPS.FieldName = ACFunctionCardSchema.FIPS;
			colFIPS.VisibleIndex = view.Columns.Count;
			view.Columns.Add(colFIPS);

			GridColumn colPin = new GridColumn();
			colPin.Caption = "Pin";
			colPin.FieldName = ACFunctionCardSchema.Pin;
			colPin.VisibleIndex = view.Columns.Count;
			colPin.DisplayFormat.FormatType = FormatType.Numeric;
			colPin.DisplayFormat.FormatString = "f0";
			view.Columns.Add(colPin);

			GridColumn colValidFrom = new GridColumn();
			colValidFrom.Caption = "ValidFrom";
			colValidFrom.FieldName = ACFunctionCardSchema.ValidFrom;
			colValidFrom.VisibleIndex = view.Columns.Count;
			colValidFrom.DisplayFormat.FormatType = FormatType.DateTime;
			colValidFrom.DisplayFormat.FormatString = "MM/dd/yyyy HH:mm:ss";
			view.Columns.Add(colValidFrom);

			GridColumn colValidThru = new GridColumn();
			colValidThru.Caption = "ValidThru";
			colValidThru.FieldName = ACFunctionCardSchema.ValidThru;
			colValidThru.VisibleIndex = view.Columns.Count;
			colValidThru.DisplayFormat.FormatType = FormatType.DateTime;
			colValidThru.DisplayFormat.FormatString = "MM/dd/yyyy HH:mm:ss";
			view.Columns.Add(colValidThru);

			GridColumn colCreatedOn = new GridColumn();
			colCreatedOn.Caption = "CreatedOn";
			colCreatedOn.FieldName = ACFunctionCardSchema.CreatedOn;
			colCreatedOn.VisibleIndex = -1;
			colCreatedOn.OptionsColumn.ShowInCustomizationForm = false;
			colCreatedOn.DisplayFormat.FormatType = FormatType.DateTime;
			colCreatedOn.DisplayFormat.FormatString = "MM/dd/yyyy HH:mm:ss";
			view.Columns.Add(colCreatedOn);

			GridColumn colCreatedBy = new GridColumn();
			colCreatedBy.Caption = "CreatedBy";
			colCreatedBy.FieldName = ACFunctionCardSchema.CreatedBy;
			colCreatedBy.VisibleIndex = -1;
			colCreatedBy.OptionsColumn.ShowInCustomizationForm = false;
			view.Columns.Add(colCreatedBy);

			GridColumn colModifiedOn = new GridColumn();
			colModifiedOn.Caption = "ModifiedOn";
			colModifiedOn.FieldName = ACFunctionCardSchema.ModifiedOn;
			colModifiedOn.VisibleIndex = -1;
			colModifiedOn.OptionsColumn.ShowInCustomizationForm = false;
			colModifiedOn.DisplayFormat.FormatType = FormatType.DateTime;
			colModifiedOn.DisplayFormat.FormatString = "MM/dd/yyyy HH:mm:ss";
			view.Columns.Add(colModifiedOn);

			GridColumn colModifiedBy = new GridColumn();
			colModifiedBy.Caption = "ModifiedBy";
			colModifiedBy.FieldName = ACFunctionCardSchema.ModifiedBy;
			colModifiedBy.VisibleIndex = -1;
			colModifiedBy.OptionsColumn.ShowInCustomizationForm = false;
			view.Columns.Add(colModifiedBy);

			GridColumn colTenant = new GridColumn();
			colTenant.Caption = "Tenant";
			colTenant.FieldName = ACFunctionCardSchema.Tenant;
			colTenant.OptionsColumn.AllowEdit = false;
			colTenant.OptionsColumn.AllowFocus = false;
			colTenant.VisibleIndex = view.Columns.Count;
			view.Columns.Add(colTenant);

			GridColumn colAddress1 = new GridColumn();
			colAddress1.Caption = "Address1";
			colAddress1.FieldName = ACFunctionCardSchema.Address1;
			colAddress1.OptionsColumn.AllowEdit = false;
			colAddress1.OptionsColumn.AllowFocus = false;
			colAddress1.VisibleIndex = view.Columns.Count;
			view.Columns.Add(colAddress1);

			GridColumn colBuildingID = new GridColumn();
			colBuildingID.Caption = "BuildingID";
			colBuildingID.FieldName = ACFunctionCardSchema.BuildingID;
			colBuildingID.OptionsColumn.AllowEdit = false;
			colBuildingID.OptionsColumn.AllowFocus = false;
			colBuildingID.VisibleIndex = view.Columns.Count;
			colBuildingID.DisplayFormat.FormatType = FormatType.Numeric;
			colBuildingID.DisplayFormat.FormatString = "f0";
			view.Columns.Add(colBuildingID);

			GridColumn colFullName = new GridColumn();
			colFullName.Caption = "FullName";
			colFullName.FieldName = ACFunctionCardSchema.FullName;
			colFullName.OptionsColumn.AllowEdit = false;
			colFullName.OptionsColumn.AllowFocus = false;
			colFullName.VisibleIndex = view.Columns.Count;
			view.Columns.Add(colFullName);

		}

		protected override void NavigatorEditClick(GridView view, NavigatorButtonClickEventArgs e)
		{
			e.Handled = true;
			ACFunctionCardCollection list = view.DataSource as ACFunctionCardCollection;
			if (list == null)
				return;

			ACFunctionCard entity = view.GetRow(view.FocusedRowHandle) as ACFunctionCard;
			if (entity == null)
				return;

			FormDetailACFunctionCard dlg = new FormDetailACFunctionCard(base.UserId, entity.Clone() as ACFunctionCard);
			dlg.ShowDialog();
		}

		protected override void NavigatorAppendClick(GridView view, NavigatorButtonClickEventArgs e)
		{
			e.Handled = true;
			ACFunctionCardCollection list = view.DataSource as ACFunctionCardCollection;
			if (list == null)
				return;

			ACFunctionCard entity = new ACFunctionCard();
			if (this.BDTenant != null)
			{
				entity.CopyParent(this.BDTenant);
			}

			FormDetailACFunctionCard dlg = new FormDetailACFunctionCard(base.UserId, entity);
			dlg.ShowDialog();
		}
	}
}
