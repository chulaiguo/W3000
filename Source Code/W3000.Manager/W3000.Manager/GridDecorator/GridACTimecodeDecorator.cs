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
	public class GridACTimecodeDecorator : GridControlDecorator
	{
		private BDBuilding _bDBuilding = null;

		public GridACTimecodeDecorator(string userId, GridControl gridControl)
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
			GridColumn colTCID = new GridColumn();
			colTCID.Caption = "TCID";
			colTCID.FieldName = ACTimecodeSchema.TCID;
			colTCID.VisibleIndex = view.Columns.Count;
			colTCID.DisplayFormat.FormatType = FormatType.Numeric;
			colTCID.DisplayFormat.FormatString = "f0";
			view.Columns.Add(colTCID);

			GridColumn colSummary = new GridColumn();
			colSummary.Caption = "Summary";
			colSummary.FieldName = ACTimecodeSchema.Summary;
			colSummary.VisibleIndex = view.Columns.Count;
			view.Columns.Add(colSummary);

			GridColumn colNotes = new GridColumn();
			colNotes.Caption = "Notes";
			colNotes.FieldName = ACTimecodeSchema.Notes;
			colNotes.VisibleIndex = view.Columns.Count;
			view.Columns.Add(colNotes);

			GridColumn colCreatedOn = new GridColumn();
			colCreatedOn.Caption = "CreatedOn";
			colCreatedOn.FieldName = ACTimecodeSchema.CreatedOn;
			colCreatedOn.VisibleIndex = -1;
			colCreatedOn.OptionsColumn.ShowInCustomizationForm = false;
			colCreatedOn.DisplayFormat.FormatType = FormatType.DateTime;
			colCreatedOn.DisplayFormat.FormatString = "MM/dd/yyyy HH:mm:ss";
			view.Columns.Add(colCreatedOn);

			GridColumn colCreatedBy = new GridColumn();
			colCreatedBy.Caption = "CreatedBy";
			colCreatedBy.FieldName = ACTimecodeSchema.CreatedBy;
			colCreatedBy.VisibleIndex = -1;
			colCreatedBy.OptionsColumn.ShowInCustomizationForm = false;
			view.Columns.Add(colCreatedBy);

			GridColumn colModifiedOn = new GridColumn();
			colModifiedOn.Caption = "ModifiedOn";
			colModifiedOn.FieldName = ACTimecodeSchema.ModifiedOn;
			colModifiedOn.VisibleIndex = -1;
			colModifiedOn.OptionsColumn.ShowInCustomizationForm = false;
			colModifiedOn.DisplayFormat.FormatType = FormatType.DateTime;
			colModifiedOn.DisplayFormat.FormatString = "MM/dd/yyyy HH:mm:ss";
			view.Columns.Add(colModifiedOn);

			GridColumn colModifiedBy = new GridColumn();
			colModifiedBy.Caption = "ModifiedBy";
			colModifiedBy.FieldName = ACTimecodeSchema.ModifiedBy;
			colModifiedBy.VisibleIndex = -1;
			colModifiedBy.OptionsColumn.ShowInCustomizationForm = false;
			view.Columns.Add(colModifiedBy);

			GridColumn colAddress1 = new GridColumn();
			colAddress1.Caption = "Address1";
			colAddress1.FieldName = ACTimecodeSchema.Address1;
			colAddress1.OptionsColumn.AllowEdit = false;
			colAddress1.OptionsColumn.AllowFocus = false;
			colAddress1.VisibleIndex = view.Columns.Count;
			view.Columns.Add(colAddress1);

			GridColumn colBuildingID = new GridColumn();
			colBuildingID.Caption = "BuildingID";
			colBuildingID.FieldName = ACTimecodeSchema.BuildingID;
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
			ACTimecodeCollection list = view.DataSource as ACTimecodeCollection;
			if (list == null)
				return;

			ACTimecode entity = view.GetRow(view.FocusedRowHandle) as ACTimecode;
			if (entity == null)
				return;

			FormDetailACTimecode dlg = new FormDetailACTimecode(base.UserId, entity.Clone() as ACTimecode);
			dlg.ShowDialog();
		}

		protected override void NavigatorAppendClick(GridView view, NavigatorButtonClickEventArgs e)
		{
			e.Handled = true;
			ACTimecodeCollection list = view.DataSource as ACTimecodeCollection;
			if (list == null)
				return;

			ACTimecode entity = new ACTimecode();
			if (this.BDBuilding != null)
			{
				entity.CopyParent(this.BDBuilding);
			}

			FormDetailACTimecode dlg = new FormDetailACTimecode(base.UserId, entity);
			dlg.ShowDialog();
		}
	}
}
