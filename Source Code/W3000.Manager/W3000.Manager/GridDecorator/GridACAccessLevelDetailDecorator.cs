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
	public class GridACAccessLevelDetailDecorator : GridControlDecorator
	{
		private ACMainZone _aCMainZone = null;
		private ACTimecode _aCTimecode = null;
		private ACAccessLevel _aCAccessLevel = null;

		public GridACAccessLevelDetailDecorator(string userId, GridControl gridControl)
			: base(userId, gridControl)
		{
		}

		public ACMainZone ACMainZone
		{
			get { return this._aCMainZone; }
			set { this._aCMainZone = value; }
		}

		public ACTimecode ACTimecode
		{
			get { return this._aCTimecode; }
			set { this._aCTimecode = value; }
		}

		public ACAccessLevel ACAccessLevel
		{
			get { return this._aCAccessLevel; }
			set { this._aCAccessLevel = value; }
		}


		protected override void SetDisplayColumns(GridView view)
		{
			GridColumn colCreatedOn = new GridColumn();
			colCreatedOn.Caption = "CreatedOn";
			colCreatedOn.FieldName = ACAccessLevelDetailSchema.CreatedOn;
			colCreatedOn.VisibleIndex = -1;
			colCreatedOn.OptionsColumn.ShowInCustomizationForm = false;
			colCreatedOn.DisplayFormat.FormatType = FormatType.DateTime;
			colCreatedOn.DisplayFormat.FormatString = "MM/dd/yyyy HH:mm:ss";
			view.Columns.Add(colCreatedOn);

			GridColumn colCreatedBy = new GridColumn();
			colCreatedBy.Caption = "CreatedBy";
			colCreatedBy.FieldName = ACAccessLevelDetailSchema.CreatedBy;
			colCreatedBy.VisibleIndex = -1;
			colCreatedBy.OptionsColumn.ShowInCustomizationForm = false;
			view.Columns.Add(colCreatedBy);

			GridColumn colModifiedOn = new GridColumn();
			colModifiedOn.Caption = "ModifiedOn";
			colModifiedOn.FieldName = ACAccessLevelDetailSchema.ModifiedOn;
			colModifiedOn.VisibleIndex = -1;
			colModifiedOn.OptionsColumn.ShowInCustomizationForm = false;
			colModifiedOn.DisplayFormat.FormatType = FormatType.DateTime;
			colModifiedOn.DisplayFormat.FormatString = "MM/dd/yyyy HH:mm:ss";
			view.Columns.Add(colModifiedOn);

			GridColumn colModifiedBy = new GridColumn();
			colModifiedBy.Caption = "ModifiedBy";
			colModifiedBy.FieldName = ACAccessLevelDetailSchema.ModifiedBy;
			colModifiedBy.VisibleIndex = -1;
			colModifiedBy.OptionsColumn.ShowInCustomizationForm = false;
			view.Columns.Add(colModifiedBy);

			GridColumn colMainZoneDescription = new GridColumn();
			colMainZoneDescription.Caption = "MainZoneDescription";
			colMainZoneDescription.FieldName = ACAccessLevelDetailSchema.MainZoneDescription;
			colMainZoneDescription.OptionsColumn.AllowEdit = false;
			colMainZoneDescription.OptionsColumn.AllowFocus = false;
			colMainZoneDescription.VisibleIndex = view.Columns.Count;
			view.Columns.Add(colMainZoneDescription);

			GridColumn colMainZoneID = new GridColumn();
			colMainZoneID.Caption = "MainZoneID";
			colMainZoneID.FieldName = ACAccessLevelDetailSchema.MainZoneID;
			colMainZoneID.OptionsColumn.AllowEdit = false;
			colMainZoneID.OptionsColumn.AllowFocus = false;
			colMainZoneID.VisibleIndex = view.Columns.Count;
			colMainZoneID.DisplayFormat.FormatType = FormatType.Numeric;
			colMainZoneID.DisplayFormat.FormatString = "f0";
			view.Columns.Add(colMainZoneID);

			GridColumn colTimecodeSummary = new GridColumn();
			colTimecodeSummary.Caption = "TimecodeSummary";
			colTimecodeSummary.FieldName = ACAccessLevelDetailSchema.TimecodeSummary;
			colTimecodeSummary.OptionsColumn.AllowEdit = false;
			colTimecodeSummary.OptionsColumn.AllowFocus = false;
			colTimecodeSummary.VisibleIndex = view.Columns.Count;
			view.Columns.Add(colTimecodeSummary);

			GridColumn colTCID = new GridColumn();
			colTCID.Caption = "TCID";
			colTCID.FieldName = ACAccessLevelDetailSchema.TCID;
			colTCID.OptionsColumn.AllowEdit = false;
			colTCID.OptionsColumn.AllowFocus = false;
			colTCID.VisibleIndex = view.Columns.Count;
			colTCID.DisplayFormat.FormatType = FormatType.Numeric;
			colTCID.DisplayFormat.FormatString = "f0";
			view.Columns.Add(colTCID);

			GridColumn colALSummary = new GridColumn();
			colALSummary.Caption = "ALSummary";
			colALSummary.FieldName = ACAccessLevelDetailSchema.ALSummary;
			colALSummary.OptionsColumn.AllowEdit = false;
			colALSummary.OptionsColumn.AllowFocus = false;
			colALSummary.VisibleIndex = view.Columns.Count;
			view.Columns.Add(colALSummary);

			GridColumn colAccessLevelID = new GridColumn();
			colAccessLevelID.Caption = "AccessLevelID";
			colAccessLevelID.FieldName = ACAccessLevelDetailSchema.AccessLevelID;
			colAccessLevelID.OptionsColumn.AllowEdit = false;
			colAccessLevelID.OptionsColumn.AllowFocus = false;
			colAccessLevelID.VisibleIndex = view.Columns.Count;
			colAccessLevelID.DisplayFormat.FormatType = FormatType.Numeric;
			colAccessLevelID.DisplayFormat.FormatString = "f0";
			view.Columns.Add(colAccessLevelID);

            //GridColumn colMainZoneDescription = new GridColumn();
            //colMainZoneDescription.Caption = "MainZoneDescription";
            //colMainZoneDescription.FieldName = ACAccessLevelDetailSchema.MainZoneDescription;
            //colMainZoneDescription.OptionsColumn.AllowEdit = false;
            //colMainZoneDescription.OptionsColumn.AllowFocus = false;
            //colMainZoneDescription.VisibleIndex = view.Columns.Count;
            //view.Columns.Add(colMainZoneDescription);

            //GridColumn colTimecodeSummary = new GridColumn();
            //colTimecodeSummary.Caption = "TimecodeSummary";
            //colTimecodeSummary.FieldName = ACAccessLevelDetailSchema.TimecodeSummary;
            //colTimecodeSummary.OptionsColumn.AllowEdit = false;
            //colTimecodeSummary.OptionsColumn.AllowFocus = false;
            //colTimecodeSummary.VisibleIndex = view.Columns.Count;
            //view.Columns.Add(colTimecodeSummary);

            //GridColumn colALSummary = new GridColumn();
            //colALSummary.Caption = "ALSummary";
            //colALSummary.FieldName = ACAccessLevelDetailSchema.ALSummary;
            //colALSummary.OptionsColumn.AllowEdit = false;
            //colALSummary.OptionsColumn.AllowFocus = false;
            //colALSummary.VisibleIndex = view.Columns.Count;
            //view.Columns.Add(colALSummary);

		}

		protected override void NavigatorEditClick(GridView view, NavigatorButtonClickEventArgs e)
		{
			e.Handled = true;
			ACAccessLevelDetailCollection list = view.DataSource as ACAccessLevelDetailCollection;
			if (list == null)
				return;

			ACAccessLevelDetail entity = view.GetRow(view.FocusedRowHandle) as ACAccessLevelDetail;
			if (entity == null)
				return;

			FormDetailACAccessLevelDetail dlg = new FormDetailACAccessLevelDetail(base.UserId, entity.Clone() as ACAccessLevelDetail, false);
			dlg.ShowDialog();
		}

		protected override void NavigatorAppendClick(GridView view, NavigatorButtonClickEventArgs e)
		{
			e.Handled = true;
			ACAccessLevelDetailCollection list = view.DataSource as ACAccessLevelDetailCollection;
			if (list == null)
				return;

		}
	}
}
