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
	public class GridUsrAccountDecorator : GridControlDecorator
	{
		private BDTenant _bDTenant = null;
		private UsrGroup _usrGroup = null;

		public GridUsrAccountDecorator(string userId, GridControl gridControl)
			: base(userId, gridControl)
		{
		}

		public BDTenant BDTenant
		{
			get { return this._bDTenant; }
			set { this._bDTenant = value; }
		}

		public UsrGroup UsrGroup
		{
			get { return this._usrGroup; }
			set { this._usrGroup = value; }
		}


		protected override void SetDisplayColumns(GridView view)
		{
			GridColumn colUserID = new GridColumn();
			colUserID.Caption = "UserID";
			colUserID.FieldName = UsrAccountSchema.UserID;
			colUserID.VisibleIndex = view.Columns.Count;
			view.Columns.Add(colUserID);

			GridColumn colIsAdmin = new GridColumn();
			colIsAdmin.Caption = "IsAdmin";
			colIsAdmin.FieldName = UsrAccountSchema.IsAdmin;
			colIsAdmin.VisibleIndex = view.Columns.Count;
			view.Columns.Add(colIsAdmin);

			GridColumn colIsCentral = new GridColumn();
			colIsCentral.Caption = "IsCentral";
			colIsCentral.FieldName = UsrAccountSchema.IsCentral;
			colIsCentral.VisibleIndex = view.Columns.Count;
			view.Columns.Add(colIsCentral);

			GridColumn colFirstName = new GridColumn();
			colFirstName.Caption = "FirstName";
			colFirstName.FieldName = UsrAccountSchema.FirstName;
			colFirstName.VisibleIndex = view.Columns.Count;
			view.Columns.Add(colFirstName);

			GridColumn colLastName = new GridColumn();
			colLastName.Caption = "LastName";
			colLastName.FieldName = UsrAccountSchema.LastName;
			colLastName.VisibleIndex = view.Columns.Count;
			view.Columns.Add(colLastName);

			GridColumn colPassword = new GridColumn();
			colPassword.Caption = "Password";
			colPassword.FieldName = UsrAccountSchema.Password;
			colPassword.VisibleIndex = view.Columns.Count;
			view.Columns.Add(colPassword);

			GridColumn colPwdExpireDate = new GridColumn();
			colPwdExpireDate.Caption = "PwdExpireDate";
			colPwdExpireDate.FieldName = UsrAccountSchema.PwdExpireDate;
			colPwdExpireDate.VisibleIndex = view.Columns.Count;
			colPwdExpireDate.DisplayFormat.FormatType = FormatType.DateTime;
			colPwdExpireDate.DisplayFormat.FormatString = "MM/dd/yyyy HH:mm:ss";
			view.Columns.Add(colPwdExpireDate);

			GridColumn colCellPhone = new GridColumn();
			colCellPhone.Caption = "CellPhone";
			colCellPhone.FieldName = UsrAccountSchema.CellPhone;
			colCellPhone.VisibleIndex = view.Columns.Count;
			view.Columns.Add(colCellPhone);

			GridColumn colHomePhone = new GridColumn();
			colHomePhone.Caption = "HomePhone";
			colHomePhone.FieldName = UsrAccountSchema.HomePhone;
			colHomePhone.VisibleIndex = view.Columns.Count;
			view.Columns.Add(colHomePhone);

			GridColumn colOfficePhone = new GridColumn();
			colOfficePhone.Caption = "OfficePhone";
			colOfficePhone.FieldName = UsrAccountSchema.OfficePhone;
			colOfficePhone.VisibleIndex = view.Columns.Count;
			view.Columns.Add(colOfficePhone);

			GridColumn colEmail = new GridColumn();
			colEmail.Caption = "Email";
			colEmail.FieldName = UsrAccountSchema.Email;
			colEmail.VisibleIndex = view.Columns.Count;
			view.Columns.Add(colEmail);

			GridColumn colLastLogin = new GridColumn();
			colLastLogin.Caption = "LastLogin";
			colLastLogin.FieldName = UsrAccountSchema.LastLogin;
			colLastLogin.VisibleIndex = view.Columns.Count;
			colLastLogin.DisplayFormat.FormatType = FormatType.DateTime;
			colLastLogin.DisplayFormat.FormatString = "MM/dd/yyyy HH:mm:ss";
			view.Columns.Add(colLastLogin);

			GridColumn colTotalUsage = new GridColumn();
			colTotalUsage.Caption = "TotalUsage";
			colTotalUsage.FieldName = UsrAccountSchema.TotalUsage;
			colTotalUsage.VisibleIndex = view.Columns.Count;
			colTotalUsage.DisplayFormat.FormatType = FormatType.Numeric;
			colTotalUsage.DisplayFormat.FormatString = "f0";
			view.Columns.Add(colTotalUsage);

			GridColumn colStartScreen = new GridColumn();
			colStartScreen.Caption = "StartScreen";
			colStartScreen.FieldName = UsrAccountSchema.StartScreen;
			colStartScreen.VisibleIndex = view.Columns.Count;
			view.Columns.Add(colStartScreen);

			GridColumn colPopupExtension = new GridColumn();
			colPopupExtension.Caption = "PopupExtension";
			colPopupExtension.FieldName = UsrAccountSchema.PopupExtension;
			colPopupExtension.VisibleIndex = view.Columns.Count;
			colPopupExtension.DisplayFormat.FormatType = FormatType.Numeric;
			colPopupExtension.DisplayFormat.FormatString = "f0";
			view.Columns.Add(colPopupExtension);

			GridColumn colCreatedOn = new GridColumn();
			colCreatedOn.Caption = "CreatedOn";
			colCreatedOn.FieldName = UsrAccountSchema.CreatedOn;
			colCreatedOn.VisibleIndex = -1;
			colCreatedOn.OptionsColumn.ShowInCustomizationForm = false;
			colCreatedOn.DisplayFormat.FormatType = FormatType.DateTime;
			colCreatedOn.DisplayFormat.FormatString = "MM/dd/yyyy HH:mm:ss";
			view.Columns.Add(colCreatedOn);

			GridColumn colCreatedBy = new GridColumn();
			colCreatedBy.Caption = "CreatedBy";
			colCreatedBy.FieldName = UsrAccountSchema.CreatedBy;
			colCreatedBy.VisibleIndex = -1;
			colCreatedBy.OptionsColumn.ShowInCustomizationForm = false;
			view.Columns.Add(colCreatedBy);

			GridColumn colModifiedOn = new GridColumn();
			colModifiedOn.Caption = "ModifiedOn";
			colModifiedOn.FieldName = UsrAccountSchema.ModifiedOn;
			colModifiedOn.VisibleIndex = -1;
			colModifiedOn.OptionsColumn.ShowInCustomizationForm = false;
			colModifiedOn.DisplayFormat.FormatType = FormatType.DateTime;
			colModifiedOn.DisplayFormat.FormatString = "MM/dd/yyyy HH:mm:ss";
			view.Columns.Add(colModifiedOn);

			GridColumn colModifiedBy = new GridColumn();
			colModifiedBy.Caption = "ModifiedBy";
			colModifiedBy.FieldName = UsrAccountSchema.ModifiedBy;
			colModifiedBy.VisibleIndex = -1;
			colModifiedBy.OptionsColumn.ShowInCustomizationForm = false;
			view.Columns.Add(colModifiedBy);

		}

		protected override void NavigatorEditClick(GridView view, NavigatorButtonClickEventArgs e)
		{
			e.Handled = true;
			UsrAccountCollection list = view.DataSource as UsrAccountCollection;
			if (list == null)
				return;

			UsrAccount entity = view.GetRow(view.FocusedRowHandle) as UsrAccount;
			if (entity == null)
				return;

			FormDetailUsrAccount dlg = new FormDetailUsrAccount(base.UserId, entity.Clone() as UsrAccount);
			dlg.ShowDialog();
		}

		protected override void NavigatorAppendClick(GridView view, NavigatorButtonClickEventArgs e)
		{
			e.Handled = true;
			UsrAccountCollection list = view.DataSource as UsrAccountCollection;
			if (list == null)
				return;

			UsrAccount entity = new UsrAccount();
			if (this.BDTenant != null)
			{
				entity.CopyParent(this.BDTenant);
			}
			if (this.UsrGroup != null)
			{
				entity.CopyParent(this.UsrGroup);
			}

			FormDetailUsrAccount dlg = new FormDetailUsrAccount(base.UserId, entity);
			dlg.ShowDialog();
		}
	}
}
