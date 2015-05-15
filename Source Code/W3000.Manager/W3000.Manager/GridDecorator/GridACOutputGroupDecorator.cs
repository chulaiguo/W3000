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
	public class GridACOutputGroupDecorator : GridControlDecorator
	{
		private ACPanel _aCPanel = null;

		public GridACOutputGroupDecorator(string userId, GridControl gridControl)
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
			colGroupID.FieldName = ACOutputGroupSchema.GroupID;
			colGroupID.VisibleIndex = view.Columns.Count;
			colGroupID.DisplayFormat.FormatType = FormatType.Numeric;
			colGroupID.DisplayFormat.FormatString = "f0";
			view.Columns.Add(colGroupID);

			GridColumn colSummary = new GridColumn();
			colSummary.Caption = "Summary";
			colSummary.FieldName = ACOutputGroupSchema.Summary;
			colSummary.VisibleIndex = view.Columns.Count;
			view.Columns.Add(colSummary);

			GridColumn colCreatedOn = new GridColumn();
			colCreatedOn.Caption = "CreatedOn";
			colCreatedOn.FieldName = ACOutputGroupSchema.CreatedOn;
			colCreatedOn.VisibleIndex = -1;
			colCreatedOn.OptionsColumn.ShowInCustomizationForm = false;
			colCreatedOn.DisplayFormat.FormatType = FormatType.DateTime;
			colCreatedOn.DisplayFormat.FormatString = "MM/dd/yyyy HH:mm:ss";
			view.Columns.Add(colCreatedOn);

			GridColumn colCreatedBy = new GridColumn();
			colCreatedBy.Caption = "CreatedBy";
			colCreatedBy.FieldName = ACOutputGroupSchema.CreatedBy;
			colCreatedBy.VisibleIndex = -1;
			colCreatedBy.OptionsColumn.ShowInCustomizationForm = false;
			view.Columns.Add(colCreatedBy);

			GridColumn colModifiedOn = new GridColumn();
			colModifiedOn.Caption = "ModifiedOn";
			colModifiedOn.FieldName = ACOutputGroupSchema.ModifiedOn;
			colModifiedOn.VisibleIndex = -1;
			colModifiedOn.OptionsColumn.ShowInCustomizationForm = false;
			colModifiedOn.DisplayFormat.FormatType = FormatType.DateTime;
			colModifiedOn.DisplayFormat.FormatString = "MM/dd/yyyy HH:mm:ss";
			view.Columns.Add(colModifiedOn);

			GridColumn colModifiedBy = new GridColumn();
			colModifiedBy.Caption = "ModifiedBy";
			colModifiedBy.FieldName = ACOutputGroupSchema.ModifiedBy;
			colModifiedBy.VisibleIndex = -1;
			colModifiedBy.OptionsColumn.ShowInCustomizationForm = false;
			view.Columns.Add(colModifiedBy);

			GridColumn colUnitID = new GridColumn();
			colUnitID.Caption = "UnitID";
			colUnitID.FieldName = ACOutputGroupSchema.UnitID;
			colUnitID.OptionsColumn.AllowEdit = false;
			colUnitID.OptionsColumn.AllowFocus = false;
			colUnitID.VisibleIndex = view.Columns.Count;
			colUnitID.DisplayFormat.FormatType = FormatType.Numeric;
			colUnitID.DisplayFormat.FormatString = "f0";
			view.Columns.Add(colUnitID);

			GridColumn colAddress1 = new GridColumn();
			colAddress1.Caption = "Address1";
			colAddress1.FieldName = ACOutputGroupSchema.Address1;
			colAddress1.OptionsColumn.AllowEdit = false;
			colAddress1.OptionsColumn.AllowFocus = false;
			colAddress1.VisibleIndex = view.Columns.Count;
			view.Columns.Add(colAddress1);

			GridColumn colBuildingID = new GridColumn();
			colBuildingID.Caption = "BuildingID";
			colBuildingID.FieldName = ACOutputGroupSchema.BuildingID;
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
			ACOutputGroupCollection list = view.DataSource as ACOutputGroupCollection;
			if (list == null)
				return;

			ACOutputGroup entity = view.GetRow(view.FocusedRowHandle) as ACOutputGroup;
			if (entity == null)
				return;

			FormDetailACOutputGroup dlg = new FormDetailACOutputGroup(base.UserId, entity.Clone() as ACOutputGroup);
			dlg.ShowDialog();
		}

		protected override void NavigatorAppendClick(GridView view, NavigatorButtonClickEventArgs e)
		{
			e.Handled = true;
			ACOutputGroupCollection list = view.DataSource as ACOutputGroupCollection;
			if (list == null)
				return;

			ACOutputGroup entity = new ACOutputGroup();
			if (this.ACPanel != null)
			{
				entity.CopyParent(this.ACPanel);
			}

			FormDetailACOutputGroup dlg = new FormDetailACOutputGroup(base.UserId, entity);
			dlg.ShowDialog();
		}
	}
}
