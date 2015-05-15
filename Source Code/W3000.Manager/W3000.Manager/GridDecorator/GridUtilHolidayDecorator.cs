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
	public class GridUtilHolidayDecorator : GridControlDecorator
	{

		public GridUtilHolidayDecorator(string userId, GridControl gridControl)
			: base(userId, gridControl)
		{
		}


		protected override void SetDisplayColumns(GridView view)
		{
			GridColumn colCountryID = new GridColumn();
			colCountryID.Caption = "CountryID";
			colCountryID.FieldName = UtilHolidaySchema.CountryID;
			colCountryID.VisibleIndex = view.Columns.Count;
			colCountryID.DisplayFormat.FormatType = FormatType.Numeric;
			colCountryID.DisplayFormat.FormatString = "f0";
			view.Columns.Add(colCountryID);

			GridColumn colHoliday = new GridColumn();
			colHoliday.Caption = "Holiday";
			colHoliday.FieldName = UtilHolidaySchema.Holiday;
			colHoliday.VisibleIndex = view.Columns.Count;
			view.Columns.Add(colHoliday);

			GridColumn colDate = new GridColumn();
			colDate.Caption = "Date";
			colDate.FieldName = UtilHolidaySchema.Date;
			colDate.VisibleIndex = view.Columns.Count;
			colDate.DisplayFormat.FormatType = FormatType.DateTime;
			colDate.DisplayFormat.FormatString = "MM/dd/yyyy HH:mm:ss";
			view.Columns.Add(colDate);

			GridColumn colMajor = new GridColumn();
			colMajor.Caption = "Major";
			colMajor.FieldName = UtilHolidaySchema.Major;
			colMajor.VisibleIndex = view.Columns.Count;
			view.Columns.Add(colMajor);

			GridColumn colFederal = new GridColumn();
			colFederal.Caption = "Federal";
			colFederal.FieldName = UtilHolidaySchema.Federal;
			colFederal.VisibleIndex = view.Columns.Count;
			view.Columns.Add(colFederal);

			GridColumn colCreatedOn = new GridColumn();
			colCreatedOn.Caption = "CreatedOn";
			colCreatedOn.FieldName = UtilHolidaySchema.CreatedOn;
			colCreatedOn.VisibleIndex = -1;
			colCreatedOn.OptionsColumn.ShowInCustomizationForm = false;
			colCreatedOn.DisplayFormat.FormatType = FormatType.DateTime;
			colCreatedOn.DisplayFormat.FormatString = "MM/dd/yyyy HH:mm:ss";
			view.Columns.Add(colCreatedOn);

			GridColumn colCreatedBy = new GridColumn();
			colCreatedBy.Caption = "CreatedBy";
			colCreatedBy.FieldName = UtilHolidaySchema.CreatedBy;
			colCreatedBy.VisibleIndex = -1;
			colCreatedBy.OptionsColumn.ShowInCustomizationForm = false;
			view.Columns.Add(colCreatedBy);

			GridColumn colModifiedOn = new GridColumn();
			colModifiedOn.Caption = "ModifiedOn";
			colModifiedOn.FieldName = UtilHolidaySchema.ModifiedOn;
			colModifiedOn.VisibleIndex = -1;
			colModifiedOn.OptionsColumn.ShowInCustomizationForm = false;
			colModifiedOn.DisplayFormat.FormatType = FormatType.DateTime;
			colModifiedOn.DisplayFormat.FormatString = "MM/dd/yyyy HH:mm:ss";
			view.Columns.Add(colModifiedOn);

			GridColumn colModifiedBy = new GridColumn();
			colModifiedBy.Caption = "ModifiedBy";
			colModifiedBy.FieldName = UtilHolidaySchema.ModifiedBy;
			colModifiedBy.VisibleIndex = -1;
			colModifiedBy.OptionsColumn.ShowInCustomizationForm = false;
			view.Columns.Add(colModifiedBy);

			GridColumn colDefault = new GridColumn();
			colDefault.Caption = "Default";
			colDefault.FieldName = UtilHolidaySchema.Default;
			colDefault.VisibleIndex = view.Columns.Count;
			view.Columns.Add(colDefault);

			GridColumn colActionID = new GridColumn();
			colActionID.Caption = "ActionID";
			colActionID.FieldName = UtilHolidaySchema.ActionID;
			colActionID.VisibleIndex = view.Columns.Count;
			colActionID.DisplayFormat.FormatType = FormatType.Numeric;
			colActionID.DisplayFormat.FormatString = "f0";
			view.Columns.Add(colActionID);

		}

		protected override void NavigatorEditClick(GridView view, NavigatorButtonClickEventArgs e)
		{
			e.Handled = true;
			UtilHolidayCollection list = view.DataSource as UtilHolidayCollection;
			if (list == null)
				return;

			UtilHoliday entity = view.GetRow(view.FocusedRowHandle) as UtilHoliday;
			if (entity == null)
				return;

			FormDetailUtilHoliday dlg = new FormDetailUtilHoliday(base.UserId, entity.Clone() as UtilHoliday);
			dlg.ShowDialog();
		}

		protected override void NavigatorAppendClick(GridView view, NavigatorButtonClickEventArgs e)
		{
			e.Handled = true;
			UtilHolidayCollection list = view.DataSource as UtilHolidayCollection;
			if (list == null)
				return;

			UtilHoliday entity = new UtilHoliday();

			FormDetailUtilHoliday dlg = new FormDetailUtilHoliday(base.UserId, entity);
			dlg.ShowDialog();
		}
	}
}
