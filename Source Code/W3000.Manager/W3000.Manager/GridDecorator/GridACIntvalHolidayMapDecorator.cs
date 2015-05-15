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
	public class GridACIntvalHolidayMapDecorator : GridControlDecorator
	{
		private ACInterval _aCInterval = null;
		private UtilHoliday _utilHoliday = null;

		public GridACIntvalHolidayMapDecorator(string userId, GridControl gridControl)
			: base(userId, gridControl)
		{
		}

		public ACInterval ACInterval
		{
			get { return this._aCInterval; }
			set { this._aCInterval = value; }
		}

		public UtilHoliday UtilHoliday
		{
			get { return this._utilHoliday; }
			set { this._utilHoliday = value; }
		}


		protected override void SetDisplayColumns(GridView view)
		{
			GridColumn colCreatedOn = new GridColumn();
			colCreatedOn.Caption = "CreatedOn";
			colCreatedOn.FieldName = ACIntvalHolidayMapSchema.CreatedOn;
			colCreatedOn.VisibleIndex = -1;
			colCreatedOn.OptionsColumn.ShowInCustomizationForm = false;
			colCreatedOn.DisplayFormat.FormatType = FormatType.DateTime;
			colCreatedOn.DisplayFormat.FormatString = "MM/dd/yyyy HH:mm:ss";
			view.Columns.Add(colCreatedOn);

			GridColumn colCreatedBy = new GridColumn();
			colCreatedBy.Caption = "CreatedBy";
			colCreatedBy.FieldName = ACIntvalHolidayMapSchema.CreatedBy;
			colCreatedBy.VisibleIndex = -1;
			colCreatedBy.OptionsColumn.ShowInCustomizationForm = false;
			view.Columns.Add(colCreatedBy);

			GridColumn colModifiedOn = new GridColumn();
			colModifiedOn.Caption = "ModifiedOn";
			colModifiedOn.FieldName = ACIntvalHolidayMapSchema.ModifiedOn;
			colModifiedOn.VisibleIndex = -1;
			colModifiedOn.OptionsColumn.ShowInCustomizationForm = false;
			colModifiedOn.DisplayFormat.FormatType = FormatType.DateTime;
			colModifiedOn.DisplayFormat.FormatString = "MM/dd/yyyy HH:mm:ss";
			view.Columns.Add(colModifiedOn);

			GridColumn colModifiedBy = new GridColumn();
			colModifiedBy.Caption = "ModifiedBy";
			colModifiedBy.FieldName = ACIntvalHolidayMapSchema.ModifiedBy;
			colModifiedBy.VisibleIndex = -1;
			colModifiedBy.OptionsColumn.ShowInCustomizationForm = false;
			view.Columns.Add(colModifiedBy);

			GridColumn colDate = new GridColumn();
			colDate.Caption = "Date";
			colDate.FieldName = ACIntvalHolidayMapSchema.Date;
			colDate.OptionsColumn.AllowEdit = false;
			colDate.OptionsColumn.AllowFocus = false;
			colDate.VisibleIndex = view.Columns.Count;
			colDate.DisplayFormat.FormatType = FormatType.DateTime;
			colDate.DisplayFormat.FormatString = "MM/dd/yyyy HH:mm:ss";
			view.Columns.Add(colDate);

			GridColumn colHoliday = new GridColumn();
			colHoliday.Caption = "Holiday";
			colHoliday.FieldName = ACIntvalHolidayMapSchema.Holiday;
			colHoliday.OptionsColumn.AllowEdit = false;
			colHoliday.OptionsColumn.AllowFocus = false;
			colHoliday.VisibleIndex = view.Columns.Count;
			view.Columns.Add(colHoliday);

		}

		protected override void NavigatorEditClick(GridView view, NavigatorButtonClickEventArgs e)
		{
			e.Handled = true;
			ACIntvalHolidayMapCollection list = view.DataSource as ACIntvalHolidayMapCollection;
			if (list == null)
				return;

			ACIntvalHolidayMap entity = view.GetRow(view.FocusedRowHandle) as ACIntvalHolidayMap;
			if (entity == null)
				return;

			FormDetailACIntvalHolidayMap dlg = new FormDetailACIntvalHolidayMap(base.UserId, entity.Clone() as ACIntvalHolidayMap, false);
			dlg.ShowDialog();
		}

		protected override void NavigatorAppendClick(GridView view, NavigatorButtonClickEventArgs e)
		{
			e.Handled = true;
			ACIntvalHolidayMapCollection list = view.DataSource as ACIntvalHolidayMapCollection;
			if (list == null)
				return;

			if (this.ACInterval != null)
			{
				SortedList<Guid, Guid> pkList = new SortedList<Guid, Guid>();
				foreach (ACIntvalHolidayMap item in list)
				{
					if (pkList.ContainsKey(item.UtilHolidayPK))
						continue;

					pkList.Add(item.UtilHolidayPK, item.UtilHolidayPK);
				}

				FormSelectUtilHoliday dlg = new FormSelectUtilHoliday(base.UserId, pkList);
				if (dlg.ShowDialog() != DialogResult.OK)
					return;

				foreach (UtilHoliday item in dlg.UtilHolidayList)
				{
					ACIntvalHolidayMap entity = new ACIntvalHolidayMap();
					entity.CopyParent(item);
					entity.CopyParent(this.ACInterval);
					list.Add(entity);
				}
			}
			else if (this.UtilHoliday != null)
			{
				SortedList<Guid, Guid> pkList = new SortedList<Guid, Guid>();
				foreach (ACIntvalHolidayMap item in list)
				{
					if (pkList.ContainsKey(item.ACIntervalPK))
						continue;

					pkList.Add(item.ACIntervalPK, item.ACIntervalPK);
				}

				FormSelectACInterval dlg = new FormSelectACInterval(base.UserId, pkList);
				if (dlg.ShowDialog() != DialogResult.OK)
					return;

				foreach (ACInterval item in dlg.ACIntervalList)
				{
					ACIntvalHolidayMap entity = new ACIntvalHolidayMap();
					entity.CopyParent(item);
					entity.CopyParent(this.UtilHoliday);
					list.Add(entity);
				}
			}
		}
	}
}
