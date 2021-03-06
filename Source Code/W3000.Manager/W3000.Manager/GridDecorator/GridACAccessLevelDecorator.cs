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
	public class GridACAccessLevelDecorator : GridControlDecorator
	{
		private BDBuilding _bDBuilding = null;

		public GridACAccessLevelDecorator(string userId, GridControl gridControl)
			: base(userId, gridControl)
		{
		}

		public BDBuilding BDBuilding
		{
			get { return this._bDBuilding; }
			set { this._bDBuilding = value; }
		}


		protected override void SetDisplayColumns(GridView view)
		{
			GridColumn colAccessLevelID = new GridColumn();
			colAccessLevelID.Caption = "AccessLevelID";
			colAccessLevelID.FieldName = ACAccessLevelSchema.AccessLevelID;
			colAccessLevelID.VisibleIndex = view.Columns.Count;
			colAccessLevelID.DisplayFormat.FormatType = FormatType.Numeric;
			colAccessLevelID.DisplayFormat.FormatString = "f0";
			view.Columns.Add(colAccessLevelID);

			GridColumn colSummary = new GridColumn();
			colSummary.Caption = "Summary";
			colSummary.FieldName = ACAccessLevelSchema.Summary;
			colSummary.VisibleIndex = view.Columns.Count;
			view.Columns.Add(colSummary);

			GridColumn colAsAL2 = new GridColumn();
			colAsAL2.Caption = "AsAL2";
			colAsAL2.FieldName = ACAccessLevelSchema.AsAL2;
			colAsAL2.VisibleIndex = view.Columns.Count;
			view.Columns.Add(colAsAL2);

			GridColumn colNotes = new GridColumn();
			colNotes.Caption = "Notes";
			colNotes.FieldName = ACAccessLevelSchema.Notes;
			colNotes.VisibleIndex = view.Columns.Count;
			view.Columns.Add(colNotes);

			GridColumn colCreatedOn = new GridColumn();
			colCreatedOn.Caption = "CreatedOn";
			colCreatedOn.FieldName = ACAccessLevelSchema.CreatedOn;
			colCreatedOn.VisibleIndex = -1;
			colCreatedOn.OptionsColumn.ShowInCustomizationForm = false;
			colCreatedOn.DisplayFormat.FormatType = FormatType.DateTime;
			colCreatedOn.DisplayFormat.FormatString = "MM/dd/yyyy HH:mm:ss";
			view.Columns.Add(colCreatedOn);

			GridColumn colCreatedBy = new GridColumn();
			colCreatedBy.Caption = "CreatedBy";
			colCreatedBy.FieldName = ACAccessLevelSchema.CreatedBy;
			colCreatedBy.VisibleIndex = -1;
			colCreatedBy.OptionsColumn.ShowInCustomizationForm = false;
			view.Columns.Add(colCreatedBy);

			GridColumn colModifiedOn = new GridColumn();
			colModifiedOn.Caption = "ModifiedOn";
			colModifiedOn.FieldName = ACAccessLevelSchema.ModifiedOn;
			colModifiedOn.VisibleIndex = -1;
			colModifiedOn.OptionsColumn.ShowInCustomizationForm = false;
			colModifiedOn.DisplayFormat.FormatType = FormatType.DateTime;
			colModifiedOn.DisplayFormat.FormatString = "MM/dd/yyyy HH:mm:ss";
			view.Columns.Add(colModifiedOn);

			GridColumn colModifiedBy = new GridColumn();
			colModifiedBy.Caption = "ModifiedBy";
			colModifiedBy.FieldName = ACAccessLevelSchema.ModifiedBy;
			colModifiedBy.VisibleIndex = -1;
			colModifiedBy.OptionsColumn.ShowInCustomizationForm = false;
			view.Columns.Add(colModifiedBy);

			GridColumn colAddress1 = new GridColumn();
			colAddress1.Caption = "Address1";
			colAddress1.FieldName = ACAccessLevelSchema.Address1;
			colAddress1.OptionsColumn.AllowEdit = false;
			colAddress1.OptionsColumn.AllowFocus = false;
			colAddress1.VisibleIndex = view.Columns.Count;
			view.Columns.Add(colAddress1);

			GridColumn colBuildingID = new GridColumn();
			colBuildingID.Caption = "BuildingID";
			colBuildingID.FieldName = ACAccessLevelSchema.BuildingID;
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
			ACAccessLevelCollection list = view.DataSource as ACAccessLevelCollection;
			if (list == null)
				return;

			ACAccessLevel entity = view.GetRow(view.FocusedRowHandle) as ACAccessLevel;
			if (entity == null)
				return;

			FormDetailACAccessLevel dlg = new FormDetailACAccessLevel(base.UserId, entity.Clone() as ACAccessLevel);
			dlg.ShowDialog();
		}

		protected override void NavigatorAppendClick(GridView view, NavigatorButtonClickEventArgs e)
		{
			e.Handled = true;
			ACAccessLevelCollection list = view.DataSource as ACAccessLevelCollection;
			if (list == null)
				return;

			ACAccessLevel entity = new ACAccessLevel();
			if (this.BDBuilding != null)
			{
				entity.CopyParent(this.BDBuilding);
			}

			FormDetailACAccessLevel dlg = new FormDetailACAccessLevel(base.UserId, entity);
			dlg.ShowDialog();
		}
	}
}
