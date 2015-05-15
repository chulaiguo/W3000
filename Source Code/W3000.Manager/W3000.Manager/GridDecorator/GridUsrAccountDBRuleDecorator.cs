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
	public class GridUsrAccountDBRuleDecorator : GridControlDecorator
	{
		private UsrAccount _usrAccount = null;

		public GridUsrAccountDBRuleDecorator(string userId, GridControl gridControl)
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
			GridColumn colDBRuleID = new GridColumn();
			colDBRuleID.Caption = "DBRuleID";
			colDBRuleID.FieldName = UsrAccountDBRuleSchema.DBRuleID;
			colDBRuleID.VisibleIndex = view.Columns.Count;
			colDBRuleID.DisplayFormat.FormatType = FormatType.Numeric;
			colDBRuleID.DisplayFormat.FormatString = "f0";
			view.Columns.Add(colDBRuleID);

			GridColumn colSelectable = new GridColumn();
			colSelectable.Caption = "Selectable";
			colSelectable.FieldName = UsrAccountDBRuleSchema.Selectable;
			colSelectable.VisibleIndex = view.Columns.Count;
			view.Columns.Add(colSelectable);

			GridColumn colInsertable = new GridColumn();
			colInsertable.Caption = "Insertable";
			colInsertable.FieldName = UsrAccountDBRuleSchema.Insertable;
			colInsertable.VisibleIndex = view.Columns.Count;
			view.Columns.Add(colInsertable);

			GridColumn colEditable = new GridColumn();
			colEditable.Caption = "Editable";
			colEditable.FieldName = UsrAccountDBRuleSchema.Editable;
			colEditable.VisibleIndex = view.Columns.Count;
			view.Columns.Add(colEditable);

			GridColumn colDeletable = new GridColumn();
			colDeletable.Caption = "Deletable";
			colDeletable.FieldName = UsrAccountDBRuleSchema.Deletable;
			colDeletable.VisibleIndex = view.Columns.Count;
			view.Columns.Add(colDeletable);

			GridColumn colCreatedOn = new GridColumn();
			colCreatedOn.Caption = "CreatedOn";
			colCreatedOn.FieldName = UsrAccountDBRuleSchema.CreatedOn;
			colCreatedOn.VisibleIndex = -1;
			colCreatedOn.OptionsColumn.ShowInCustomizationForm = false;
			colCreatedOn.DisplayFormat.FormatType = FormatType.DateTime;
			colCreatedOn.DisplayFormat.FormatString = "MM/dd/yyyy HH:mm:ss";
			view.Columns.Add(colCreatedOn);

			GridColumn colCreatedBy = new GridColumn();
			colCreatedBy.Caption = "CreatedBy";
			colCreatedBy.FieldName = UsrAccountDBRuleSchema.CreatedBy;
			colCreatedBy.VisibleIndex = -1;
			colCreatedBy.OptionsColumn.ShowInCustomizationForm = false;
			view.Columns.Add(colCreatedBy);

			GridColumn colModifiedOn = new GridColumn();
			colModifiedOn.Caption = "ModifiedOn";
			colModifiedOn.FieldName = UsrAccountDBRuleSchema.ModifiedOn;
			colModifiedOn.VisibleIndex = -1;
			colModifiedOn.OptionsColumn.ShowInCustomizationForm = false;
			colModifiedOn.DisplayFormat.FormatType = FormatType.DateTime;
			colModifiedOn.DisplayFormat.FormatString = "MM/dd/yyyy HH:mm:ss";
			view.Columns.Add(colModifiedOn);

			GridColumn colModifiedBy = new GridColumn();
			colModifiedBy.Caption = "ModifiedBy";
			colModifiedBy.FieldName = UsrAccountDBRuleSchema.ModifiedBy;
			colModifiedBy.VisibleIndex = -1;
			colModifiedBy.OptionsColumn.ShowInCustomizationForm = false;
			view.Columns.Add(colModifiedBy);

			GridColumn colUserID = new GridColumn();
			colUserID.Caption = "UserID";
			colUserID.FieldName = UsrAccountDBRuleSchema.UserID;
			colUserID.OptionsColumn.AllowEdit = false;
			colUserID.OptionsColumn.AllowFocus = false;
			colUserID.VisibleIndex = view.Columns.Count;
			view.Columns.Add(colUserID);

		}

		protected override void NavigatorEditClick(GridView view, NavigatorButtonClickEventArgs e)
		{
			e.Handled = true;
			UsrAccountDBRuleCollection list = view.DataSource as UsrAccountDBRuleCollection;
			if (list == null)
				return;

			UsrAccountDBRule entity = view.GetRow(view.FocusedRowHandle) as UsrAccountDBRule;
			if (entity == null)
				return;

			FormDetailUsrAccountDBRule dlg = new FormDetailUsrAccountDBRule(base.UserId, entity.Clone() as UsrAccountDBRule);
			dlg.ShowDialog();
		}

		protected override void NavigatorAppendClick(GridView view, NavigatorButtonClickEventArgs e)
		{
			e.Handled = true;
			UsrAccountDBRuleCollection list = view.DataSource as UsrAccountDBRuleCollection;
			if (list == null)
				return;

			UsrAccountDBRule entity = new UsrAccountDBRule();
			if (this.UsrAccount != null)
			{
				entity.CopyParent(this.UsrAccount);
			}

			FormDetailUsrAccountDBRule dlg = new FormDetailUsrAccountDBRule(base.UserId, entity);
			dlg.ShowDialog();
		}
	}
}
