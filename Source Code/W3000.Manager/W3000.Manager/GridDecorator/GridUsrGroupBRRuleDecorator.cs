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
	public class GridUsrGroupBRRuleDecorator : GridControlDecorator
	{
		private UsrGroup _usrGroup = null;

		public GridUsrGroupBRRuleDecorator(string userId, GridControl gridControl)
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
			GridColumn colBRRuleID = new GridColumn();
			colBRRuleID.Caption = "BRRuleID";
			colBRRuleID.FieldName = UsrGroupBRRuleSchema.BRRuleID;
			colBRRuleID.VisibleIndex = view.Columns.Count;
			colBRRuleID.DisplayFormat.FormatType = FormatType.Numeric;
			colBRRuleID.DisplayFormat.FormatString = "f0";
			view.Columns.Add(colBRRuleID);

			GridColumn colDenied = new GridColumn();
			colDenied.Caption = "Denied";
			colDenied.FieldName = UsrGroupBRRuleSchema.Denied;
			colDenied.VisibleIndex = view.Columns.Count;
			view.Columns.Add(colDenied);

			GridColumn colCreatedOn = new GridColumn();
			colCreatedOn.Caption = "CreatedOn";
			colCreatedOn.FieldName = UsrGroupBRRuleSchema.CreatedOn;
			colCreatedOn.VisibleIndex = -1;
			colCreatedOn.OptionsColumn.ShowInCustomizationForm = false;
			colCreatedOn.DisplayFormat.FormatType = FormatType.DateTime;
			colCreatedOn.DisplayFormat.FormatString = "MM/dd/yyyy HH:mm:ss";
			view.Columns.Add(colCreatedOn);

			GridColumn colCreatedBy = new GridColumn();
			colCreatedBy.Caption = "CreatedBy";
			colCreatedBy.FieldName = UsrGroupBRRuleSchema.CreatedBy;
			colCreatedBy.VisibleIndex = -1;
			colCreatedBy.OptionsColumn.ShowInCustomizationForm = false;
			view.Columns.Add(colCreatedBy);

			GridColumn colModifiedOn = new GridColumn();
			colModifiedOn.Caption = "ModifiedOn";
			colModifiedOn.FieldName = UsrGroupBRRuleSchema.ModifiedOn;
			colModifiedOn.VisibleIndex = -1;
			colModifiedOn.OptionsColumn.ShowInCustomizationForm = false;
			colModifiedOn.DisplayFormat.FormatType = FormatType.DateTime;
			colModifiedOn.DisplayFormat.FormatString = "MM/dd/yyyy HH:mm:ss";
			view.Columns.Add(colModifiedOn);

			GridColumn colModifiedBy = new GridColumn();
			colModifiedBy.Caption = "ModifiedBy";
			colModifiedBy.FieldName = UsrGroupBRRuleSchema.ModifiedBy;
			colModifiedBy.VisibleIndex = -1;
			colModifiedBy.OptionsColumn.ShowInCustomizationForm = false;
			view.Columns.Add(colModifiedBy);

			GridColumn colUsrGroupName = new GridColumn();
			colUsrGroupName.Caption = "UsrGroupName";
			colUsrGroupName.FieldName = UsrGroupBRRuleSchema.UsrGroupName;
			colUsrGroupName.OptionsColumn.AllowEdit = false;
			colUsrGroupName.OptionsColumn.AllowFocus = false;
			colUsrGroupName.VisibleIndex = view.Columns.Count;
			view.Columns.Add(colUsrGroupName);

		}

		protected override void NavigatorEditClick(GridView view, NavigatorButtonClickEventArgs e)
		{
			e.Handled = true;
			UsrGroupBRRuleCollection list = view.DataSource as UsrGroupBRRuleCollection;
			if (list == null)
				return;

			UsrGroupBRRule entity = view.GetRow(view.FocusedRowHandle) as UsrGroupBRRule;
			if (entity == null)
				return;

			FormDetailUsrGroupBRRule dlg = new FormDetailUsrGroupBRRule(base.UserId, entity.Clone() as UsrGroupBRRule);
			dlg.ShowDialog();
		}

		protected override void NavigatorAppendClick(GridView view, NavigatorButtonClickEventArgs e)
		{
			e.Handled = true;
			UsrGroupBRRuleCollection list = view.DataSource as UsrGroupBRRuleCollection;
			if (list == null)
				return;

			UsrGroupBRRule entity = new UsrGroupBRRule();
			if (this.UsrGroup != null)
			{
				entity.CopyParent(this.UsrGroup);
			}

			FormDetailUsrGroupBRRule dlg = new FormDetailUsrGroupBRRule(base.UserId, entity);
			dlg.ShowDialog();
		}
	}
}
