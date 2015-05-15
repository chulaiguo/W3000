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
	public class GridUsrAccountBRRuleDecorator : GridControlDecorator
	{
		private UsrAccount _usrAccount = null;

		public GridUsrAccountBRRuleDecorator(string userId, GridControl gridControl)
			: base(userId, gridControl)
		{
		}

		public UsrAccount UsrAccount
		{
			get { return this._usrAccount; }
			set { this._usrAccount = value; }
		}


		protected override void SetDisplayColumns(GridView view)
		{
			GridColumn colBRRuleID = new GridColumn();
			colBRRuleID.Caption = "BRRuleID";
			colBRRuleID.FieldName = UsrAccountBRRuleSchema.BRRuleID;
			colBRRuleID.VisibleIndex = view.Columns.Count;
			colBRRuleID.DisplayFormat.FormatType = FormatType.Numeric;
			colBRRuleID.DisplayFormat.FormatString = "f0";
			view.Columns.Add(colBRRuleID);

			GridColumn colDenied = new GridColumn();
			colDenied.Caption = "Denied";
			colDenied.FieldName = UsrAccountBRRuleSchema.Denied;
			colDenied.VisibleIndex = view.Columns.Count;
			view.Columns.Add(colDenied);

			GridColumn colCreatedOn = new GridColumn();
			colCreatedOn.Caption = "CreatedOn";
			colCreatedOn.FieldName = UsrAccountBRRuleSchema.CreatedOn;
			colCreatedOn.VisibleIndex = -1;
			colCreatedOn.OptionsColumn.ShowInCustomizationForm = false;
			colCreatedOn.DisplayFormat.FormatType = FormatType.DateTime;
			colCreatedOn.DisplayFormat.FormatString = "MM/dd/yyyy HH:mm:ss";
			view.Columns.Add(colCreatedOn);

			GridColumn colCreatedBy = new GridColumn();
			colCreatedBy.Caption = "CreatedBy";
			colCreatedBy.FieldName = UsrAccountBRRuleSchema.CreatedBy;
			colCreatedBy.VisibleIndex = -1;
			colCreatedBy.OptionsColumn.ShowInCustomizationForm = false;
			view.Columns.Add(colCreatedBy);

			GridColumn colModifiedOn = new GridColumn();
			colModifiedOn.Caption = "ModifiedOn";
			colModifiedOn.FieldName = UsrAccountBRRuleSchema.ModifiedOn;
			colModifiedOn.VisibleIndex = -1;
			colModifiedOn.OptionsColumn.ShowInCustomizationForm = false;
			colModifiedOn.DisplayFormat.FormatType = FormatType.DateTime;
			colModifiedOn.DisplayFormat.FormatString = "MM/dd/yyyy HH:mm:ss";
			view.Columns.Add(colModifiedOn);

			GridColumn colModifiedBy = new GridColumn();
			colModifiedBy.Caption = "ModifiedBy";
			colModifiedBy.FieldName = UsrAccountBRRuleSchema.ModifiedBy;
			colModifiedBy.VisibleIndex = -1;
			colModifiedBy.OptionsColumn.ShowInCustomizationForm = false;
			view.Columns.Add(colModifiedBy);

			GridColumn colUserID = new GridColumn();
			colUserID.Caption = "UserID";
			colUserID.FieldName = UsrAccountBRRuleSchema.UserID;
			colUserID.OptionsColumn.AllowEdit = false;
			colUserID.OptionsColumn.AllowFocus = false;
			colUserID.VisibleIndex = view.Columns.Count;
			view.Columns.Add(colUserID);

		}

		protected override void NavigatorEditClick(GridView view, NavigatorButtonClickEventArgs e)
		{
			e.Handled = true;
			UsrAccountBRRuleCollection list = view.DataSource as UsrAccountBRRuleCollection;
			if (list == null)
				return;

			UsrAccountBRRule entity = view.GetRow(view.FocusedRowHandle) as UsrAccountBRRule;
			if (entity == null)
				return;

			FormDetailUsrAccountBRRule dlg = new FormDetailUsrAccountBRRule(base.UserId, entity.Clone() as UsrAccountBRRule);
			dlg.ShowDialog();
		}

		protected override void NavigatorAppendClick(GridView view, NavigatorButtonClickEventArgs e)
		{
			e.Handled = true;
			UsrAccountBRRuleCollection list = view.DataSource as UsrAccountBRRuleCollection;
			if (list == null)
				return;

			UsrAccountBRRule entity = new UsrAccountBRRule();
			if (this.UsrAccount != null)
			{
				entity.CopyParent(this.UsrAccount);
			}

			FormDetailUsrAccountBRRule dlg = new FormDetailUsrAccountBRRule(base.UserId, entity);
			dlg.ShowDialog();
		}
	}
}
