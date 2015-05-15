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
	public class GridACPanelHolidayMapDecorator : GridControlDecorator
	{
		private UtilHoliday _utilHoliday = null;
		private ACPanel _aCPanel = null;

		public GridACPanelHolidayMapDecorator(string userId, GridControl gridControl)
			: base(userId, gridControl)
		{
		}

		public UtilHoliday UtilHoliday
		{
			get { return this._utilHoliday; }
			set { this._utilHoliday = value; }
		}

		public ACPanel ACPanel
		{
			get { return this._aCPanel; }
			set { this._aCPanel = value; }
		}


		protected override void SetDisplayColumns(GridView view)
		{
			GridColumn colCreatedOn = new GridColumn();
			colCreatedOn.Caption = "CreatedOn";
			colCreatedOn.FieldName = ACPanelHolidayMapSchema.CreatedOn;
			colCreatedOn.VisibleIndex = -1;
			colCreatedOn.OptionsColumn.ShowInCustomizationForm = false;
			colCreatedOn.DisplayFormat.FormatType = FormatType.DateTime;
			colCreatedOn.DisplayFormat.FormatString = "MM/dd/yyyy HH:mm:ss";
			view.Columns.Add(colCreatedOn);

			GridColumn colCreatedBy = new GridColumn();
			colCreatedBy.Caption = "CreatedBy";
			colCreatedBy.FieldName = ACPanelHolidayMapSchema.CreatedBy;
			colCreatedBy.VisibleIndex = -1;
			colCreatedBy.OptionsColumn.ShowInCustomizationForm = false;
			view.Columns.Add(colCreatedBy);

			GridColumn colModifiedOn = new GridColumn();
			colModifiedOn.Caption = "ModifiedOn";
			colModifiedOn.FieldName = ACPanelHolidayMapSchema.ModifiedOn;
			colModifiedOn.VisibleIndex = -1;
			colModifiedOn.OptionsColumn.ShowInCustomizationForm = false;
			colModifiedOn.DisplayFormat.FormatType = FormatType.DateTime;
			colModifiedOn.DisplayFormat.FormatString = "MM/dd/yyyy HH:mm:ss";
			view.Columns.Add(colModifiedOn);

			GridColumn colModifiedBy = new GridColumn();
			colModifiedBy.Caption = "ModifiedBy";
			colModifiedBy.FieldName = ACPanelHolidayMapSchema.ModifiedBy;
			colModifiedBy.VisibleIndex = -1;
			colModifiedBy.OptionsColumn.ShowInCustomizationForm = false;
			view.Columns.Add(colModifiedBy);

			GridColumn colDate = new GridColumn();
			colDate.Caption = "Date";
			colDate.FieldName = ACPanelHolidayMapSchema.Date;
			colDate.OptionsColumn.AllowEdit = false;
			colDate.OptionsColumn.AllowFocus = false;
			colDate.VisibleIndex = view.Columns.Count;
			colDate.DisplayFormat.FormatType = FormatType.DateTime;
			colDate.DisplayFormat.FormatString = "MM/dd/yyyy HH:mm:ss";
			view.Columns.Add(colDate);

			GridColumn colHoliday = new GridColumn();
			colHoliday.Caption = "Holiday";
			colHoliday.FieldName = ACPanelHolidayMapSchema.Holiday;
			colHoliday.OptionsColumn.AllowEdit = false;
			colHoliday.OptionsColumn.AllowFocus = false;
			colHoliday.VisibleIndex = view.Columns.Count;
			view.Columns.Add(colHoliday);

			GridColumn colUnitID = new GridColumn();
			colUnitID.Caption = "UnitID";
			colUnitID.FieldName = ACPanelHolidayMapSchema.UnitID;
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
			ACPanelHolidayMapCollection list = view.DataSource as ACPanelHolidayMapCollection;
			if (list == null)
				return;

			ACPanelHolidayMap entity = view.GetRow(view.FocusedRowHandle) as ACPanelHolidayMap;
			if (entity == null)
				return;

			FormDetailACPanelHolidayMap dlg = new FormDetailACPanelHolidayMap(base.UserId, entity.Clone() as ACPanelHolidayMap, false);
			dlg.ShowDialog();
		}

		protected override void NavigatorAppendClick(GridView view, NavigatorButtonClickEventArgs e)
		{
			e.Handled = true;
			ACPanelHolidayMapCollection list = view.DataSource as ACPanelHolidayMapCollection;
			if (list == null)
				return;

			if (this.UtilHoliday != null)
			{
				SortedList<Guid, Guid> pkList = new SortedList<Guid, Guid>();
				foreach (ACPanelHolidayMap item in list)
				{
					if (pkList.ContainsKey(item.ACPanelPK))
						continue;

					pkList.Add(item.ACPanelPK, item.ACPanelPK);
				}

				FormSelectACPanel dlg = new FormSelectACPanel(base.UserId, pkList);
				if (dlg.ShowDialog() != DialogResult.OK)
					return;

				foreach (ACPanel item in dlg.ACPanelList)
				{
					ACPanelHolidayMap entity = new ACPanelHolidayMap();
					entity.CopyParent(item);
					entity.CopyParent(this.UtilHoliday);
					list.Add(entity);
				}
			}
			else if (this.ACPanel != null)
			{
				SortedList<Guid, Guid> pkList = new SortedList<Guid, Guid>();
				foreach (ACPanelHolidayMap item in list)
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
					ACPanelHolidayMap entity = new ACPanelHolidayMap();
					entity.CopyParent(item);
					entity.CopyParent(this.ACPanel);
					list.Add(entity);
				}
			}
		}
	}
}
