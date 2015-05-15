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
	public class GridACInputGroupDecorator : GridControlDecorator
	{
		private ACPanel _aCPanel = null;

		public GridACInputGroupDecorator(string userId, GridControl gridControl)
			: base(userId, gridControl)
		{
		}

		public ACPanel ACPanel
		{
			get { return this._aCPanel; }
			set { this._aCPanel = value; }
		}


		protected override void SetDisplayColumns(GridView view)
		{
			GridColumn colGroupID = new GridColumn();
			colGroupID.Caption = "GroupID";
			colGroupID.FieldName = ACInputGroupSchema.GroupID;
			colGroupID.VisibleIndex = view.Columns.Count;
			colGroupID.DisplayFormat.FormatType = FormatType.Numeric;
			colGroupID.DisplayFormat.FormatString = "f0";
			view.Columns.Add(colGroupID);

			GridColumn colSummary = new GridColumn();
			colSummary.Caption = "Summary";
			colSummary.FieldName = ACInputGroupSchema.Summary;
			colSummary.VisibleIndex = view.Columns.Count;
			view.Columns.Add(colSummary);

			GridColumn colCreatedOn = new GridColumn();
			colCreatedOn.Caption = "CreatedOn";
			colCreatedOn.FieldName = ACInputGroupSchema.CreatedOn;
			colCreatedOn.VisibleIndex = -1;
			colCreatedOn.OptionsColumn.ShowInCustomizationForm = false;
			colCreatedOn.DisplayFormat.FormatType = FormatType.DateTime;
			colCreatedOn.DisplayFormat.FormatString = "MM/dd/yyyy HH:mm:ss";
			view.Columns.Add(colCreatedOn);

			GridColumn colCreatedBy = new GridColumn();
			colCreatedBy.Caption = "CreatedBy";
			colCreatedBy.FieldName = ACInputGroupSchema.CreatedBy;
			colCreatedBy.VisibleIndex = -1;
			colCreatedBy.OptionsColumn.ShowInCustomizationForm = false;
			view.Columns.Add(colCreatedBy);

			GridColumn colModifiedOn = new GridColumn();
			colModifiedOn.Caption = "ModifiedOn";
			colModifiedOn.FieldName = ACInputGroupSchema.ModifiedOn;
			colModifiedOn.VisibleIndex = -1;
			colModifiedOn.OptionsColumn.ShowInCustomizationForm = false;
			colModifiedOn.DisplayFormat.FormatType = FormatType.DateTime;
			colModifiedOn.DisplayFormat.FormatString = "MM/dd/yyyy HH:mm:ss";
			view.Columns.Add(colModifiedOn);

			GridColumn colModifiedBy = new GridColumn();
			colModifiedBy.Caption = "ModifiedBy";
			colModifiedBy.FieldName = ACInputGroupSchema.ModifiedBy;
			colModifiedBy.VisibleIndex = -1;
			colModifiedBy.OptionsColumn.ShowInCustomizationForm = false;
			view.Columns.Add(colModifiedBy);

			GridColumn colUnitID = new GridColumn();
			colUnitID.Caption = "UnitID";
			colUnitID.FieldName = ACInputGroupSchema.UnitID;
			colUnitID.OptionsColumn.AllowEdit = false;
			colUnitID.OptionsColumn.AllowFocus = false;
			colUnitID.VisibleIndex = view.Columns.Count;
			colUnitID.DisplayFormat.FormatType = FormatType.Numeric;
			colUnitID.DisplayFormat.FormatString = "f0";
			view.Columns.Add(colUnitID);

		}

		protected override void NavigatorEditClick(GridView view, NavigatorButtonClickEventArgs e)
		{
			e.Handled = true;
			ACInputGroupCollection list = view.DataSource as ACInputGroupCollection;
			if (list == null)
				return;

			ACInputGroup entity = view.GetRow(view.FocusedRowHandle) as ACInputGroup;
			if (entity == null)
				return;

			FormDetailACInputGroup dlg = new FormDetailACInputGroup(base.UserId, entity.Clone() as ACInputGroup);
			dlg.ShowDialog();
		}

		protected override void NavigatorAppendClick(GridView view, NavigatorButtonClickEventArgs e)
		{
			e.Handled = true;
			ACInputGroupCollection list = view.DataSource as ACInputGroupCollection;
			if (list == null)
				return;

			ACInputGroup entity = new ACInputGroup();
			if (this.ACPanel != null)
			{
				entity.CopyParent(this.ACPanel);
			}

			FormDetailACInputGroup dlg = new FormDetailACInputGroup(base.UserId, entity);
			dlg.ShowDialog();
		}
	}
}
