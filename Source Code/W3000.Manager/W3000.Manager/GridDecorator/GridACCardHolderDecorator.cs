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
	public class GridACCardHolderDecorator : GridControlDecorator
	{
		private BDTenant _bDTenant = null;

		public GridACCardHolderDecorator(string userId, GridControl gridControl)
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
			colSitecode.FieldName = ACCardHolderSchema.Sitecode;
			colSitecode.VisibleIndex = view.Columns.Count;
			colSitecode.DisplayFormat.FormatType = FormatType.Numeric;
			colSitecode.DisplayFormat.FormatString = "f0";
			view.Columns.Add(colSitecode);

			GridColumn colEmbossed = new GridColumn();
			colEmbossed.Caption = "Embossed";
			colEmbossed.FieldName = ACCardHolderSchema.Embossed;
			colEmbossed.VisibleIndex = view.Columns.Count;
			colEmbossed.DisplayFormat.FormatType = FormatType.Numeric;
			colEmbossed.DisplayFormat.FormatString = "f0";
			view.Columns.Add(colEmbossed);

			GridColumn colEncoded = new GridColumn();
			colEncoded.Caption = "Encoded";
			colEncoded.FieldName = ACCardHolderSchema.Encoded;
			colEncoded.VisibleIndex = view.Columns.Count;
			colEncoded.DisplayFormat.FormatType = FormatType.Numeric;
			colEncoded.DisplayFormat.FormatString = "f0";
			view.Columns.Add(colEncoded);

			GridColumn colCardTypeID = new GridColumn();
			colCardTypeID.Caption = "CardTypeID";
			colCardTypeID.FieldName = ACCardHolderSchema.CardTypeID;
			colCardTypeID.VisibleIndex = view.Columns.Count;
			colCardTypeID.DisplayFormat.FormatType = FormatType.Numeric;
			colCardTypeID.DisplayFormat.FormatString = "f0";
			view.Columns.Add(colCardTypeID);

			GridColumn colFirstName = new GridColumn();
			colFirstName.Caption = "FirstName";
			colFirstName.FieldName = ACCardHolderSchema.FirstName;
			colFirstName.VisibleIndex = view.Columns.Count;
			view.Columns.Add(colFirstName);

			GridColumn colLastName = new GridColumn();
			colLastName.Caption = "LastName";
			colLastName.FieldName = ACCardHolderSchema.LastName;
			colLastName.VisibleIndex = view.Columns.Count;
			view.Columns.Add(colLastName);

			GridColumn colValidFrom = new GridColumn();
			colValidFrom.Caption = "ValidFrom";
			colValidFrom.FieldName = ACCardHolderSchema.ValidFrom;
			colValidFrom.VisibleIndex = view.Columns.Count;
			colValidFrom.DisplayFormat.FormatType = FormatType.DateTime;
			colValidFrom.DisplayFormat.FormatString = "MM/dd/yyyy HH:mm:ss";
			view.Columns.Add(colValidFrom);

			GridColumn colValidThru = new GridColumn();
			colValidThru.Caption = "ValidThru";
			colValidThru.FieldName = ACCardHolderSchema.ValidThru;
			colValidThru.VisibleIndex = view.Columns.Count;
			colValidThru.DisplayFormat.FormatType = FormatType.DateTime;
			colValidThru.DisplayFormat.FormatString = "MM/dd/yyyy HH:mm:ss";
			view.Columns.Add(colValidThru);

			GridColumn colFIPS = new GridColumn();
			colFIPS.Caption = "FIPS";
			colFIPS.FieldName = ACCardHolderSchema.FIPS;
			colFIPS.VisibleIndex = view.Columns.Count;
			view.Columns.Add(colFIPS);

			GridColumn colPin = new GridColumn();
			colPin.Caption = "Pin";
			colPin.FieldName = ACCardHolderSchema.Pin;
			colPin.VisibleIndex = view.Columns.Count;
			colPin.DisplayFormat.FormatType = FormatType.Numeric;
			colPin.DisplayFormat.FormatString = "f0";
			view.Columns.Add(colPin);

			GridColumn colNotes = new GridColumn();
			colNotes.Caption = "Notes";
			colNotes.FieldName = ACCardHolderSchema.Notes;
			colNotes.VisibleIndex = view.Columns.Count;
			view.Columns.Add(colNotes);

			GridColumn colEventNotifyEmail = new GridColumn();
			colEventNotifyEmail.Caption = "EventNotifyEmail";
			colEventNotifyEmail.FieldName = ACCardHolderSchema.EventNotifyEmail;
			colEventNotifyEmail.VisibleIndex = view.Columns.Count;
			view.Columns.Add(colEventNotifyEmail);

			GridColumn colFireWarden = new GridColumn();
			colFireWarden.Caption = "FireWarden";
			colFireWarden.FieldName = ACCardHolderSchema.FireWarden;
			colFireWarden.VisibleIndex = view.Columns.Count;
			view.Columns.Add(colFireWarden);

			GridColumn colCustInfo1 = new GridColumn();
			colCustInfo1.Caption = "CustInfo1";
			colCustInfo1.FieldName = ACCardHolderSchema.CustInfo1;
			colCustInfo1.VisibleIndex = view.Columns.Count;
			view.Columns.Add(colCustInfo1);

			GridColumn colCustInfo2 = new GridColumn();
			colCustInfo2.Caption = "CustInfo2";
			colCustInfo2.FieldName = ACCardHolderSchema.CustInfo2;
			colCustInfo2.VisibleIndex = view.Columns.Count;
			view.Columns.Add(colCustInfo2);

			GridColumn colCustInfo3 = new GridColumn();
			colCustInfo3.Caption = "CustInfo3";
			colCustInfo3.FieldName = ACCardHolderSchema.CustInfo3;
			colCustInfo3.VisibleIndex = view.Columns.Count;
			view.Columns.Add(colCustInfo3);

			GridColumn colCustInfo4 = new GridColumn();
			colCustInfo4.Caption = "CustInfo4";
			colCustInfo4.FieldName = ACCardHolderSchema.CustInfo4;
			colCustInfo4.VisibleIndex = view.Columns.Count;
			view.Columns.Add(colCustInfo4);

			GridColumn colCustInfo5 = new GridColumn();
			colCustInfo5.Caption = "CustInfo5";
			colCustInfo5.FieldName = ACCardHolderSchema.CustInfo5;
			colCustInfo5.VisibleIndex = view.Columns.Count;
			view.Columns.Add(colCustInfo5);

			GridColumn colCustInfo6 = new GridColumn();
			colCustInfo6.Caption = "CustInfo6";
			colCustInfo6.FieldName = ACCardHolderSchema.CustInfo6;
			colCustInfo6.VisibleIndex = view.Columns.Count;
			view.Columns.Add(colCustInfo6);

			GridColumn colCustInfo7 = new GridColumn();
			colCustInfo7.Caption = "CustInfo7";
			colCustInfo7.FieldName = ACCardHolderSchema.CustInfo7;
			colCustInfo7.VisibleIndex = view.Columns.Count;
			view.Columns.Add(colCustInfo7);

			GridColumn colCustInfo8 = new GridColumn();
			colCustInfo8.Caption = "CustInfo8";
			colCustInfo8.FieldName = ACCardHolderSchema.CustInfo8;
			colCustInfo8.VisibleIndex = view.Columns.Count;
			view.Columns.Add(colCustInfo8);

			GridColumn colCreatedOn = new GridColumn();
			colCreatedOn.Caption = "CreatedOn";
			colCreatedOn.FieldName = ACCardHolderSchema.CreatedOn;
			colCreatedOn.VisibleIndex = -1;
			colCreatedOn.OptionsColumn.ShowInCustomizationForm = false;
			colCreatedOn.DisplayFormat.FormatType = FormatType.DateTime;
			colCreatedOn.DisplayFormat.FormatString = "MM/dd/yyyy HH:mm:ss";
			view.Columns.Add(colCreatedOn);

			GridColumn colCreatedBy = new GridColumn();
			colCreatedBy.Caption = "CreatedBy";
			colCreatedBy.FieldName = ACCardHolderSchema.CreatedBy;
			colCreatedBy.VisibleIndex = -1;
			colCreatedBy.OptionsColumn.ShowInCustomizationForm = false;
			view.Columns.Add(colCreatedBy);

			GridColumn colModifiedOn = new GridColumn();
			colModifiedOn.Caption = "ModifiedOn";
			colModifiedOn.FieldName = ACCardHolderSchema.ModifiedOn;
			colModifiedOn.VisibleIndex = -1;
			colModifiedOn.OptionsColumn.ShowInCustomizationForm = false;
			colModifiedOn.DisplayFormat.FormatType = FormatType.DateTime;
			colModifiedOn.DisplayFormat.FormatString = "MM/dd/yyyy HH:mm:ss";
			view.Columns.Add(colModifiedOn);

			GridColumn colModifiedBy = new GridColumn();
			colModifiedBy.Caption = "ModifiedBy";
			colModifiedBy.FieldName = ACCardHolderSchema.ModifiedBy;
			colModifiedBy.VisibleIndex = -1;
			colModifiedBy.OptionsColumn.ShowInCustomizationForm = false;
			view.Columns.Add(colModifiedBy);

			GridColumn colTenant = new GridColumn();
			colTenant.Caption = "Tenant";
			colTenant.FieldName = ACCardHolderSchema.Tenant;
			colTenant.OptionsColumn.AllowEdit = false;
			colTenant.OptionsColumn.AllowFocus = false;
			colTenant.VisibleIndex = view.Columns.Count;
			view.Columns.Add(colTenant);

		}

		protected override void NavigatorEditClick(GridView view, NavigatorButtonClickEventArgs e)
		{
			e.Handled = true;
			ACCardHolderCollection list = view.DataSource as ACCardHolderCollection;
			if (list == null)
				return;

			ACCardHolder entity = view.GetRow(view.FocusedRowHandle) as ACCardHolder;
			if (entity == null)
				return;

			FormDetailACCardHolder dlg = new FormDetailACCardHolder(base.UserId, entity.Clone() as ACCardHolder);
			dlg.ShowDialog();
		}

		protected override void NavigatorAppendClick(GridView view, NavigatorButtonClickEventArgs e)
		{
			e.Handled = true;
			ACCardHolderCollection list = view.DataSource as ACCardHolderCollection;
			if (list == null)
				return;

			ACCardHolder entity = new ACCardHolder();
			if (this.BDTenant != null)
			{
				entity.CopyParent(this.BDTenant);
			}

			FormDetailACCardHolder dlg = new FormDetailACCardHolder(base.UserId, entity);
			dlg.ShowDialog();
		}
	}
}
