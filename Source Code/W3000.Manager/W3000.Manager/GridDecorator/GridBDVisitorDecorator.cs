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
	public class GridBDVisitorDecorator : GridControlDecorator
	{
		private BDTenant _bDTenant = null;

		public GridBDVisitorDecorator(string userId, GridControl gridControl)
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
			GridColumn colFirstName = new GridColumn();
			colFirstName.Caption = "FirstName";
			colFirstName.FieldName = BDVisitorSchema.FirstName;
			colFirstName.VisibleIndex = view.Columns.Count;
			view.Columns.Add(colFirstName);

			GridColumn colLastName = new GridColumn();
			colLastName.Caption = "LastName";
			colLastName.FieldName = BDVisitorSchema.LastName;
			colLastName.VisibleIndex = view.Columns.Count;
			view.Columns.Add(colLastName);

			GridColumn colAuthorizedBy = new GridColumn();
			colAuthorizedBy.Caption = "AuthorizedBy";
			colAuthorizedBy.FieldName = BDVisitorSchema.AuthorizedBy;
			colAuthorizedBy.VisibleIndex = view.Columns.Count;
			view.Columns.Add(colAuthorizedBy);

			GridColumn colAuthorizedArea = new GridColumn();
			colAuthorizedArea.Caption = "AuthorizedArea";
			colAuthorizedArea.FieldName = BDVisitorSchema.AuthorizedArea;
			colAuthorizedArea.VisibleIndex = view.Columns.Count;
			view.Columns.Add(colAuthorizedArea);

			GridColumn colAuthorEmail = new GridColumn();
			colAuthorEmail.Caption = "AuthorEmail";
			colAuthorEmail.FieldName = BDVisitorSchema.AuthorEmail;
			colAuthorEmail.VisibleIndex = view.Columns.Count;
			view.Columns.Add(colAuthorEmail);

			GridColumn colEmailNotify = new GridColumn();
			colEmailNotify.Caption = "EmailNotify";
			colEmailNotify.FieldName = BDVisitorSchema.EmailNotify;
			colEmailNotify.VisibleIndex = view.Columns.Count;
			view.Columns.Add(colEmailNotify);

			GridColumn colValidFrom = new GridColumn();
			colValidFrom.Caption = "ValidFrom";
			colValidFrom.FieldName = BDVisitorSchema.ValidFrom;
			colValidFrom.VisibleIndex = view.Columns.Count;
			colValidFrom.DisplayFormat.FormatType = FormatType.DateTime;
			colValidFrom.DisplayFormat.FormatString = "MM/dd/yyyy HH:mm:ss";
			view.Columns.Add(colValidFrom);

			GridColumn colValidThru = new GridColumn();
			colValidThru.Caption = "ValidThru";
			colValidThru.FieldName = BDVisitorSchema.ValidThru;
			colValidThru.VisibleIndex = view.Columns.Count;
			colValidThru.DisplayFormat.FormatType = FormatType.DateTime;
			colValidThru.DisplayFormat.FormatString = "MM/dd/yyyy HH:mm:ss";
			view.Columns.Add(colValidThru);

			GridColumn colPassword = new GridColumn();
			colPassword.Caption = "Password";
			colPassword.FieldName = BDVisitorSchema.Password;
			colPassword.VisibleIndex = view.Columns.Count;
			view.Columns.Add(colPassword);

			GridColumn colSpecial = new GridColumn();
			colSpecial.Caption = "Special";
			colSpecial.FieldName = BDVisitorSchema.Special;
			colSpecial.VisibleIndex = view.Columns.Count;
			view.Columns.Add(colSpecial);

			GridColumn colBegin = new GridColumn();
			colBegin.Caption = "Begin";
			colBegin.FieldName = BDVisitorSchema.Begin;
			colBegin.VisibleIndex = view.Columns.Count;
			view.Columns.Add(colBegin);

			GridColumn colEnd = new GridColumn();
			colEnd.Caption = "End";
			colEnd.FieldName = BDVisitorSchema.End;
			colEnd.VisibleIndex = view.Columns.Count;
			view.Columns.Add(colEnd);

			GridColumn colSiteCode = new GridColumn();
			colSiteCode.Caption = "SiteCode";
			colSiteCode.FieldName = BDVisitorSchema.SiteCode;
			colSiteCode.VisibleIndex = view.Columns.Count;
			colSiteCode.DisplayFormat.FormatType = FormatType.Numeric;
			colSiteCode.DisplayFormat.FormatString = "f0";
			view.Columns.Add(colSiteCode);

			GridColumn colEncoded = new GridColumn();
			colEncoded.Caption = "Encoded";
			colEncoded.FieldName = BDVisitorSchema.Encoded;
			colEncoded.VisibleIndex = view.Columns.Count;
			colEncoded.DisplayFormat.FormatType = FormatType.Numeric;
			colEncoded.DisplayFormat.FormatString = "f0";
			view.Columns.Add(colEncoded);

			GridColumn colScheduled = new GridColumn();
			colScheduled.Caption = "Scheduled";
			colScheduled.FieldName = BDVisitorSchema.Scheduled;
			colScheduled.VisibleIndex = view.Columns.Count;
			view.Columns.Add(colScheduled);

			GridColumn colArrivedTime = new GridColumn();
			colArrivedTime.Caption = "ArrivedTime";
			colArrivedTime.FieldName = BDVisitorSchema.ArrivedTime;
			colArrivedTime.VisibleIndex = view.Columns.Count;
			colArrivedTime.DisplayFormat.FormatType = FormatType.DateTime;
			colArrivedTime.DisplayFormat.FormatString = "MM/dd/yyyy HH:mm:ss";
			view.Columns.Add(colArrivedTime);

			GridColumn colTurnstileAccess = new GridColumn();
			colTurnstileAccess.Caption = "TurnstileAccess";
			colTurnstileAccess.FieldName = BDVisitorSchema.TurnstileAccess;
			colTurnstileAccess.VisibleIndex = view.Columns.Count;
			view.Columns.Add(colTurnstileAccess);

			GridColumn colBadgePrinted = new GridColumn();
			colBadgePrinted.Caption = "BadgePrinted";
			colBadgePrinted.FieldName = BDVisitorSchema.BadgePrinted;
			colBadgePrinted.VisibleIndex = view.Columns.Count;
			view.Columns.Add(colBadgePrinted);

			GridColumn colCreatedOn = new GridColumn();
			colCreatedOn.Caption = "CreatedOn";
			colCreatedOn.FieldName = BDVisitorSchema.CreatedOn;
			colCreatedOn.VisibleIndex = -1;
			colCreatedOn.OptionsColumn.ShowInCustomizationForm = false;
			colCreatedOn.DisplayFormat.FormatType = FormatType.DateTime;
			colCreatedOn.DisplayFormat.FormatString = "MM/dd/yyyy HH:mm:ss";
			view.Columns.Add(colCreatedOn);

			GridColumn colCreatedBy = new GridColumn();
			colCreatedBy.Caption = "CreatedBy";
			colCreatedBy.FieldName = BDVisitorSchema.CreatedBy;
			colCreatedBy.VisibleIndex = -1;
			colCreatedBy.OptionsColumn.ShowInCustomizationForm = false;
			view.Columns.Add(colCreatedBy);

			GridColumn colModifiedOn = new GridColumn();
			colModifiedOn.Caption = "ModifiedOn";
			colModifiedOn.FieldName = BDVisitorSchema.ModifiedOn;
			colModifiedOn.VisibleIndex = -1;
			colModifiedOn.OptionsColumn.ShowInCustomizationForm = false;
			colModifiedOn.DisplayFormat.FormatType = FormatType.DateTime;
			colModifiedOn.DisplayFormat.FormatString = "MM/dd/yyyy HH:mm:ss";
			view.Columns.Add(colModifiedOn);

			GridColumn colModifiedBy = new GridColumn();
			colModifiedBy.Caption = "ModifiedBy";
			colModifiedBy.FieldName = BDVisitorSchema.ModifiedBy;
			colModifiedBy.VisibleIndex = -1;
			colModifiedBy.OptionsColumn.ShowInCustomizationForm = false;
			view.Columns.Add(colModifiedBy);

			GridColumn colTenant = new GridColumn();
			colTenant.Caption = "Tenant";
			colTenant.FieldName = BDVisitorSchema.Tenant;
			colTenant.OptionsColumn.AllowEdit = false;
			colTenant.OptionsColumn.AllowFocus = false;
			colTenant.VisibleIndex = view.Columns.Count;
			view.Columns.Add(colTenant);

			GridColumn colAddress1 = new GridColumn();
			colAddress1.Caption = "Address1";
			colAddress1.FieldName = BDVisitorSchema.Address1;
			colAddress1.OptionsColumn.AllowEdit = false;
			colAddress1.OptionsColumn.AllowFocus = false;
			colAddress1.VisibleIndex = view.Columns.Count;
			view.Columns.Add(colAddress1);

			GridColumn colBuildingID = new GridColumn();
			colBuildingID.Caption = "BuildingID";
			colBuildingID.FieldName = BDVisitorSchema.BuildingID;
			colBuildingID.OptionsColumn.AllowEdit = false;
			colBuildingID.OptionsColumn.AllowFocus = false;
			colBuildingID.VisibleIndex = view.Columns.Count;
			colBuildingID.DisplayFormat.FormatType = FormatType.Numeric;
			colBuildingID.DisplayFormat.FormatString = "f0";
			view.Columns.Add(colBuildingID);

		}

		protected override void NavigatorEditClick(GridView view, NavigatorButtonClickEventArgs e)
		{
			e.Handled = true;
			BDVisitorCollection list = view.DataSource as BDVisitorCollection;
			if (list == null)
				return;

			BDVisitor entity = view.GetRow(view.FocusedRowHandle) as BDVisitor;
			if (entity == null)
				return;

			FormDetailBDVisitor dlg = new FormDetailBDVisitor(base.UserId, entity.Clone() as BDVisitor);
			dlg.ShowDialog();
		}

		protected override void NavigatorAppendClick(GridView view, NavigatorButtonClickEventArgs e)
		{
			e.Handled = true;
			BDVisitorCollection list = view.DataSource as BDVisitorCollection;
			if (list == null)
				return;

			BDVisitor entity = new BDVisitor();
			if (this.BDTenant != null)
			{
				entity.CopyParent(this.BDTenant);
			}

			FormDetailBDVisitor dlg = new FormDetailBDVisitor(base.UserId, entity);
			dlg.ShowDialog();
		}
	}
}
