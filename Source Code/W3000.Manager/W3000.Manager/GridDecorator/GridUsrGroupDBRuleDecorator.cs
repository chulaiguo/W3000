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
	public class GridUsrGroupDBRuleDecorator : GridControlDecorator
	{
		private UsrGroup _usrGroup = null;

		public GridUsrGroupDBRuleDecorator(string userId, GridControl gridControl)
			: base(userId, gridControl)
		{
		}

		public UsrGroup UsrGroup
		{
			get { return this._usrGroup; }
			set { this._usrGroup = value; }
		}


		protected override void SetDisplayColumns(GridView view)
		{
			GridColumn colDBRuleID = new GridColumn();
			colDBRuleID.Caption = "DBRuleID";
			colDBRuleID.FieldName = UsrGroupDBRuleSchema.DBRuleID;
			colDBRuleID.VisibleIndex = view.Columns.Count;
			colDBRuleID.DisplayFormat.FormatType = FormatType.Numeric;
			colDBRuleID.DisplayFormat.FormatString = "f0";
			view.Columns.Add(colDBRuleID);

			GridColumn colSelectable = new GridColumn();
			colSelectable.Caption = "Selectable";
			colSelectable.FieldName = UsrGroupDBRuleSchema.Selectable;
			colSelectable.VisibleIndex = view.Columns.Count;
			view.Columns.Add(colSelectable);

			GridColumn colInsertable = new GridColumn();
			colInsertable.Caption = "Insertable";
			colInsertable.FieldName = UsrGroupDBRuleSchema.Insertable;
			colInsertable.VisibleIndex = view.Columns.Count;
			view.Columns.Add(colInsertable);

			GridColumn colEditable = new GridColumn();
			colEditable.Caption = "Editable";
			colEditable.FieldName = UsrGroupDBRuleSchema.Editable;
			colEditable.VisibleIndex = view.Columns.Count;
			view.Columns.Add(colEditable);

			GridColumn colDeletable = new GridColumn();
			colDeletable.Caption = "Deletable";
			colDeletable.FieldName = UsrGroupDBRuleSchema.Deletable;
			colDeletable.VisibleIndex = view.Columns.Count;
			view.Columns.Add(colDeletable);

			GridColumn colCreatedOn = new GridColumn();
			colCreatedOn.Caption = "CreatedOn";
			colCreatedOn.FieldName = UsrGroupDBRuleSchema.CreatedOn;
			colCreatedOn.VisibleIndex = -1;
			colCreatedOn.OptionsColumn.ShowInCustomizationForm = false;
			colCreatedOn.DisplayFormat.FormatType = FormatType.DateTime;
			colCreatedOn.DisplayFormat.FormatString = "MM/dd/yyyy HH:mm:ss";
			view.Columns.Add(colCreatedOn);

			GridColumn colCreatedBy = new GridColumn();
			colCreatedBy.Caption = "CreatedBy";
			colCreatedBy.FieldName = UsrGroupDBRuleSchema.CreatedBy;
			colCreatedBy.VisibleIndex = -1;
			colCreatedBy.OptionsColumn.ShowInCustomizationForm = false;
			view.Columns.Add(colCreatedBy);

			GridColumn colModifiedOn = new GridColumn();
			colModifiedOn.Caption = "ModifiedOn";
			colModifiedOn.FieldName = UsrGroupDBRuleSchema.ModifiedOn;
			colModifiedOn.VisibleIndex = -1;
			colModifiedOn.OptionsColumn.ShowInCustomizationForm = false;
			colModifiedOn.DisplayFormat.FormatType = FormatType.DateTime;
			colModifiedOn.DisplayFormat.FormatString = "MM/dd/yyyy HH:mm:ss";
			view.Columns.Add(colModifiedOn);

			GridColumn colModifiedBy = new GridColumn();
			colModifiedBy.Caption = "ModifiedBy";
			colModifiedBy.FieldName = UsrGroupDBRuleSchema.ModifiedBy;
			colModifiedBy.VisibleIndex = -1;
			colModifiedBy.OptionsColumn.ShowInCustomizationForm = false;
			view.Columns.Add(colModifiedBy);

			GridColumn colUsrGroupName = new GridColumn();
			colUsrGroupName.Caption = "UsrGroupName";
			colUsrGroupName.FieldName = UsrGroupDBRuleSchema.UsrGroupName;
			colUsrGroupName.OptionsColumn.AllowEdit = false;
			colUsrGroupName.OptionsColumn.AllowFocus = false;
			colUsrGroupName.VisibleIndex = view.Columns.Count;
			view.Columns.Add(colUsrGroupName);

		}

		protected override void NavigatorEditClick(GridView view, NavigatorButtonClickEventArgs e)
		{
			e.Handled = true;
			UsrGroupDBRuleCollection list = view.DataSource as UsrGroupDBRuleCollection;
			if (list == null)
				return;

			UsrGroupDBRule entity = view.GetRow(view.FocusedRowHandle) as UsrGroupDBRule;
			if (entity == null)
				return;

			FormDetailUsrGroupDBRule dlg = new FormDetailUsrGroupDBRule(base.UserId, entity.Clone() as UsrGroupDBRule);
			dlg.ShowDialog();
		}

		protected override void NavigatorAppendClick(GridView view, NavigatorButtonClickEventArgs e)
		{
			e.Handled = true;
			UsrGroupDBRuleCollection list = view.DataSource as UsrGroupDBRuleCollection;
			if (list == null)
				return;

			UsrGroupDBRule entity = new UsrGroupDBRule();
			if (this.UsrGroup != null)
			{
				entity.CopyParent(this.UsrGroup);
			}

			FormDetailUsrGroupDBRule dlg = new FormDetailUsrGroupDBRule(base.UserId, entity);
			dlg.ShowDialog();
		}
	}
}
