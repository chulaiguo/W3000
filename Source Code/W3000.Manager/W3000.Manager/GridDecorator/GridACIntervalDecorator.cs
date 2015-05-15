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
	public class GridACIntervalDecorator : GridControlDecorator
	{
		private BDBuilding _bDBuilding = null;

		public GridACIntervalDecorator(string userId, GridControl gridControl)
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
			GridColumn colIVID = new GridColumn();
			colIVID.Caption = "IVID";
			colIVID.FieldName = ACIntervalSchema.IVID;
			colIVID.VisibleIndex = view.Columns.Count;
			colIVID.DisplayFormat.FormatType = FormatType.Numeric;
			colIVID.DisplayFormat.FormatString = "f0";
			view.Columns.Add(colIVID);

			GridColumn colBegin = new GridColumn();
			colBegin.Caption = "Begin";
			colBegin.FieldName = ACIntervalSchema.Begin;
			colBegin.VisibleIndex = view.Columns.Count;
			view.Columns.Add(colBegin);

			GridColumn colEnd = new GridColumn();
			colEnd.Caption = "End";
			colEnd.FieldName = ACIntervalSchema.End;
			colEnd.VisibleIndex = view.Columns.Count;
			view.Columns.Add(colEnd);

			GridColumn colSun = new GridColumn();
			colSun.Caption = "Sun";
			colSun.FieldName = ACIntervalSchema.Sun;
			colSun.VisibleIndex = view.Columns.Count;
			view.Columns.Add(colSun);

			GridColumn colMon = new GridColumn();
			colMon.Caption = "Mon";
			colMon.FieldName = ACIntervalSchema.Mon;
			colMon.VisibleIndex = view.Columns.Count;
			view.Columns.Add(colMon);

			GridColumn colTue = new GridColumn();
			colTue.Caption = "Tue";
			colTue.FieldName = ACIntervalSchema.Tue;
			colTue.VisibleIndex = view.Columns.Count;
			view.Columns.Add(colTue);

			GridColumn colWed = new GridColumn();
			colWed.Caption = "Wed";
			colWed.FieldName = ACIntervalSchema.Wed;
			colWed.VisibleIndex = view.Columns.Count;
			view.Columns.Add(colWed);

			GridColumn colThu = new GridColumn();
			colThu.Caption = "Thu";
			colThu.FieldName = ACIntervalSchema.Thu;
			colThu.VisibleIndex = view.Columns.Count;
			view.Columns.Add(colThu);

			GridColumn colFri = new GridColumn();
			colFri.Caption = "Fri";
			colFri.FieldName = ACIntervalSchema.Fri;
			colFri.VisibleIndex = view.Columns.Count;
			view.Columns.Add(colFri);

			GridColumn colSat = new GridColumn();
			colSat.Caption = "Sat";
			colSat.FieldName = ACIntervalSchema.Sat;
			colSat.VisibleIndex = view.Columns.Count;
			view.Columns.Add(colSat);

			GridColumn colHol = new GridColumn();
			colHol.Caption = "Hol";
			colHol.FieldName = ACIntervalSchema.Hol;
			colHol.VisibleIndex = view.Columns.Count;
			view.Columns.Add(colHol);

			GridColumn colCreatedOn = new GridColumn();
			colCreatedOn.Caption = "CreatedOn";
			colCreatedOn.FieldName = ACIntervalSchema.CreatedOn;
			colCreatedOn.VisibleIndex = -1;
			colCreatedOn.OptionsColumn.ShowInCustomizationForm = false;
			colCreatedOn.DisplayFormat.FormatType = FormatType.DateTime;
			colCreatedOn.DisplayFormat.FormatString = "MM/dd/yyyy HH:mm:ss";
			view.Columns.Add(colCreatedOn);

			GridColumn colCreatedBy = new GridColumn();
			colCreatedBy.Caption = "CreatedBy";
			colCreatedBy.FieldName = ACIntervalSchema.CreatedBy;
			colCreatedBy.VisibleIndex = -1;
			colCreatedBy.OptionsColumn.ShowInCustomizationForm = false;
			view.Columns.Add(colCreatedBy);

			GridColumn colModifiedOn = new GridColumn();
			colModifiedOn.Caption = "ModifiedOn";
			colModifiedOn.FieldName = ACIntervalSchema.ModifiedOn;
			colModifiedOn.VisibleIndex = -1;
			colModifiedOn.OptionsColumn.ShowInCustomizationForm = false;
			colModifiedOn.DisplayFormat.FormatType = FormatType.DateTime;
			colModifiedOn.DisplayFormat.FormatString = "MM/dd/yyyy HH:mm:ss";
			view.Columns.Add(colModifiedOn);

			GridColumn colModifiedBy = new GridColumn();
			colModifiedBy.Caption = "ModifiedBy";
			colModifiedBy.FieldName = ACIntervalSchema.ModifiedBy;
			colModifiedBy.VisibleIndex = -1;
			colModifiedBy.OptionsColumn.ShowInCustomizationForm = false;
			view.Columns.Add(colModifiedBy);

			GridColumn colAddress1 = new GridColumn();
			colAddress1.Caption = "Address1";
			colAddress1.FieldName = ACIntervalSchema.Address1;
			colAddress1.OptionsColumn.AllowEdit = false;
			colAddress1.OptionsColumn.AllowFocus = false;
			colAddress1.VisibleIndex = view.Columns.Count;
			view.Columns.Add(colAddress1);

			GridColumn colBuildingID = new GridColumn();
			colBuildingID.Caption = "BuildingID";
			colBuildingID.FieldName = ACIntervalSchema.BuildingID;
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
			ACIntervalCollection list = view.DataSource as ACIntervalCollection;
			if (list == null)
				return;

			ACInterval entity = view.GetRow(view.FocusedRowHandle) as ACInterval;
			if (entity == null)
				return;

			FormDetailACInterval dlg = new FormDetailACInterval(base.UserId, entity.Clone() as ACInterval);
			dlg.ShowDialog();
		}

		protected override void NavigatorAppendClick(GridView view, NavigatorButtonClickEventArgs e)
		{
			e.Handled = true;
			ACIntervalCollection list = view.DataSource as ACIntervalCollection;
			if (list == null)
				return;

			ACInterval entity = new ACInterval();
			if (this.BDBuilding != null)
			{
				entity.CopyParent(this.BDBuilding);
			}

			FormDetailACInterval dlg = new FormDetailACInterval(base.UserId, entity);
			dlg.ShowDialog();
		}
	}
}
