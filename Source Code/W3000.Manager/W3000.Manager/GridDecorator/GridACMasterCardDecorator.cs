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
	public class GridACMasterCardDecorator : GridControlDecorator
	{

		public GridACMasterCardDecorator(string userId, GridControl gridControl)
			: base(userId, gridControl)
		{
		}


		protected override void SetDisplayColumns(GridView view)
		{
			GridColumn colSitecode = new GridColumn();
			colSitecode.Caption = "Sitecode";
			colSitecode.FieldName = ACMasterCardSchema.Sitecode;
			colSitecode.VisibleIndex = view.Columns.Count;
			colSitecode.DisplayFormat.FormatType = FormatType.Numeric;
			colSitecode.DisplayFormat.FormatString = "f0";
			view.Columns.Add(colSitecode);

			GridColumn colEmbossed = new GridColumn();
			colEmbossed.Caption = "Embossed";
			colEmbossed.FieldName = ACMasterCardSchema.Embossed;
			colEmbossed.VisibleIndex = view.Columns.Count;
			colEmbossed.DisplayFormat.FormatType = FormatType.Numeric;
			colEmbossed.DisplayFormat.FormatString = "f0";
			view.Columns.Add(colEmbossed);

			GridColumn colEncoded = new GridColumn();
			colEncoded.Caption = "Encoded";
			colEncoded.FieldName = ACMasterCardSchema.Encoded;
			colEncoded.VisibleIndex = view.Columns.Count;
			colEncoded.DisplayFormat.FormatType = FormatType.Numeric;
			colEncoded.DisplayFormat.FormatString = "f0";
			view.Columns.Add(colEncoded);

			GridColumn colCardTypeID = new GridColumn();
			colCardTypeID.Caption = "CardTypeID";
			colCardTypeID.FieldName = ACMasterCardSchema.CardTypeID;
			colCardTypeID.VisibleIndex = view.Columns.Count;
			colCardTypeID.DisplayFormat.FormatType = FormatType.Numeric;
			colCardTypeID.DisplayFormat.FormatString = "f0";
			view.Columns.Add(colCardTypeID);

			GridColumn colFirstName = new GridColumn();
			colFirstName.Caption = "FirstName";
			colFirstName.FieldName = ACMasterCardSchema.FirstName;
			colFirstName.VisibleIndex = view.Columns.Count;
			view.Columns.Add(colFirstName);

			GridColumn colLastName = new GridColumn();
			colLastName.Caption = "LastName";
			colLastName.FieldName = ACMasterCardSchema.LastName;
			colLastName.VisibleIndex = view.Columns.Count;
			view.Columns.Add(colLastName);

			GridColumn colFIPS = new GridColumn();
			colFIPS.Caption = "FIPS";
			colFIPS.FieldName = ACMasterCardSchema.FIPS;
			colFIPS.VisibleIndex = view.Columns.Count;
			view.Columns.Add(colFIPS);

			GridColumn colPin = new GridColumn();
			colPin.Caption = "Pin";
			colPin.FieldName = ACMasterCardSchema.Pin;
			colPin.VisibleIndex = view.Columns.Count;
			colPin.DisplayFormat.FormatType = FormatType.Numeric;
			colPin.DisplayFormat.FormatString = "f0";
			view.Columns.Add(colPin);

			GridColumn colCreatedOn = new GridColumn();
			colCreatedOn.Caption = "CreatedOn";
			colCreatedOn.FieldName = ACMasterCardSchema.CreatedOn;
			colCreatedOn.VisibleIndex = -1;
			colCreatedOn.OptionsColumn.ShowInCustomizationForm = false;
			colCreatedOn.DisplayFormat.FormatType = FormatType.DateTime;
			colCreatedOn.DisplayFormat.FormatString = "MM/dd/yyyy HH:mm:ss";
			view.Columns.Add(colCreatedOn);

			GridColumn colCreatedBy = new GridColumn();
			colCreatedBy.Caption = "CreatedBy";
			colCreatedBy.FieldName = ACMasterCardSchema.CreatedBy;
			colCreatedBy.VisibleIndex = -1;
			colCreatedBy.OptionsColumn.ShowInCustomizationForm = false;
			view.Columns.Add(colCreatedBy);

			GridColumn colModifiedOn = new GridColumn();
			colModifiedOn.Caption = "ModifiedOn";
			colModifiedOn.FieldName = ACMasterCardSchema.ModifiedOn;
			colModifiedOn.VisibleIndex = -1;
			colModifiedOn.OptionsColumn.ShowInCustomizationForm = false;
			colModifiedOn.DisplayFormat.FormatType = FormatType.DateTime;
			colModifiedOn.DisplayFormat.FormatString = "MM/dd/yyyy HH:mm:ss";
			view.Columns.Add(colModifiedOn);

			GridColumn colModifiedBy = new GridColumn();
			colModifiedBy.Caption = "ModifiedBy";
			colModifiedBy.FieldName = ACMasterCardSchema.ModifiedBy;
			colModifiedBy.VisibleIndex = -1;
			colModifiedBy.OptionsColumn.ShowInCustomizationForm = false;
			view.Columns.Add(colModifiedBy);

		}

		protected override void NavigatorEditClick(GridView view, NavigatorButtonClickEventArgs e)
		{
			e.Handled = true;
			ACMasterCardCollection list = view.DataSource as ACMasterCardCollection;
			if (list == null)
				return;

			ACMasterCard entity = view.GetRow(view.FocusedRowHandle) as ACMasterCard;
			if (entity == null)
				return;

			FormDetailACMasterCard dlg = new FormDetailACMasterCard(base.UserId, entity.Clone() as ACMasterCard);
			dlg.ShowDialog();
		}

		protected override void NavigatorAppendClick(GridView view, NavigatorButtonClickEventArgs e)
		{
			e.Handled = true;
			ACMasterCardCollection list = view.DataSource as ACMasterCardCollection;
			if (list == null)
				return;

			ACMasterCard entity = new ACMasterCard();

			FormDetailACMasterCard dlg = new FormDetailACMasterCard(base.UserId, entity);
			dlg.ShowDialog();
		}
	}
}
