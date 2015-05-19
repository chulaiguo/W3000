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
	public class GridACAMFormatDecorator : GridControlDecorator
	{
		private BDBuilding _bDBuilding = null;

		public GridACAMFormatDecorator(string userId, GridControl gridControl)
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
			GridColumn colAMFID = new GridColumn();
			colAMFID.Caption = "AMFID";
			colAMFID.FieldName = ACAMFormatSchema.AMFID;
			colAMFID.VisibleIndex = view.Columns.Count;
			colAMFID.DisplayFormat.FormatType = FormatType.Numeric;
			colAMFID.DisplayFormat.FormatString = "f0";
			view.Columns.Add(colAMFID);

			GridColumn colSummary = new GridColumn();
			colSummary.Caption = "Summary";
			colSummary.FieldName = ACAMFormatSchema.Summary;
			colSummary.VisibleIndex = view.Columns.Count;
			view.Columns.Add(colSummary);

			GridColumn colNotes = new GridColumn();
			colNotes.Caption = "Notes";
			colNotes.FieldName = ACAMFormatSchema.Notes;
			colNotes.VisibleIndex = view.Columns.Count;
			view.Columns.Add(colNotes);

			GridColumn colReportTC = new GridColumn();
			colReportTC.Caption = "ReportTC";
			colReportTC.FieldName = ACAMFormatSchema.ReportTC;
			colReportTC.VisibleIndex = view.Columns.Count;
			colReportTC.DisplayFormat.FormatType = FormatType.Numeric;
			colReportTC.DisplayFormat.FormatString = "f0";
			view.Columns.Add(colReportTC);

			GridColumn colAlarmTC = new GridColumn();
			colAlarmTC.Caption = "AlarmTC";
			colAlarmTC.FieldName = ACAMFormatSchema.AlarmTC;
			colAlarmTC.VisibleIndex = view.Columns.Count;
			colAlarmTC.DisplayFormat.FormatType = FormatType.Numeric;
			colAlarmTC.DisplayFormat.FormatString = "f0";
			view.Columns.Add(colAlarmTC);

			GridColumn colPreAlarmTC = new GridColumn();
			colPreAlarmTC.Caption = "PreAlarmTC";
			colPreAlarmTC.FieldName = ACAMFormatSchema.PreAlarmTC;
			colPreAlarmTC.VisibleIndex = view.Columns.Count;
			colPreAlarmTC.DisplayFormat.FormatType = FormatType.Numeric;
			colPreAlarmTC.DisplayFormat.FormatString = "f0";
			view.Columns.Add(colPreAlarmTC);

			GridColumn colCreatedOn = new GridColumn();
			colCreatedOn.Caption = "CreatedOn";
			colCreatedOn.FieldName = ACAMFormatSchema.CreatedOn;
			colCreatedOn.VisibleIndex = -1;
			colCreatedOn.OptionsColumn.ShowInCustomizationForm = false;
			colCreatedOn.DisplayFormat.FormatType = FormatType.DateTime;
			colCreatedOn.DisplayFormat.FormatString = "MM/dd/yyyy HH:mm:ss";
			view.Columns.Add(colCreatedOn);

			GridColumn colCreatedBy = new GridColumn();
			colCreatedBy.Caption = "CreatedBy";
			colCreatedBy.FieldName = ACAMFormatSchema.CreatedBy;
			colCreatedBy.VisibleIndex = -1;
			colCreatedBy.OptionsColumn.ShowInCustomizationForm = false;
			view.Columns.Add(colCreatedBy);

			GridColumn colModifiedOn = new GridColumn();
			colModifiedOn.Caption = "ModifiedOn";
			colModifiedOn.FieldName = ACAMFormatSchema.ModifiedOn;
			colModifiedOn.VisibleIndex = -1;
			colModifiedOn.OptionsColumn.ShowInCustomizationForm = false;
			colModifiedOn.DisplayFormat.FormatType = FormatType.DateTime;
			colModifiedOn.DisplayFormat.FormatString = "MM/dd/yyyy HH:mm:ss";
			view.Columns.Add(colModifiedOn);

			GridColumn colModifiedBy = new GridColumn();
			colModifiedBy.Caption = "ModifiedBy";
			colModifiedBy.FieldName = ACAMFormatSchema.ModifiedBy;
			colModifiedBy.VisibleIndex = -1;
			colModifiedBy.OptionsColumn.ShowInCustomizationForm = false;
			view.Columns.Add(colModifiedBy);

			GridColumn colAddress1 = new GridColumn();
			colAddress1.Caption = "Address1";
			colAddress1.FieldName = ACAMFormatSchema.Address1;
			colAddress1.OptionsColumn.AllowEdit = false;
			colAddress1.OptionsColumn.AllowFocus = false;
			colAddress1.VisibleIndex = view.Columns.Count;
			view.Columns.Add(colAddress1);

			GridColumn colBuildingID = new GridColumn();
			colBuildingID.Caption = "BuildingID";
			colBuildingID.FieldName = ACAMFormatSchema.BuildingID;
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
			ACAMFormatCollection list = view.DataSource as ACAMFormatCollection;
			if (list == null)
				return;

			ACAMFormat entity = view.GetRow(view.FocusedRowHandle) as ACAMFormat;
			if (entity == null)
				return;

			FormDetailACAMFormat dlg = new FormDetailACAMFormat(base.UserId, entity.Clone() as ACAMFormat);
			dlg.ShowDialog();
		}

		protected override void NavigatorAppendClick(GridView view, NavigatorButtonClickEventArgs e)
		{
			e.Handled = true;
			ACAMFormatCollection list = view.DataSource as ACAMFormatCollection;
			if (list == null)
				return;

			ACAMFormat entity = new ACAMFormat();
			if (this.BDBuilding != null)
			{
				entity.CopyParent(this.BDBuilding);
			}

			FormDetailACAMFormat dlg = new FormDetailACAMFormat(base.UserId, entity);
			dlg.ShowDialog();
		}
	}
}
