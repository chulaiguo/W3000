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
	public class GridBDBuildingHolidayMapDecorator : GridControlDecorator
	{
		private BDBuilding _bDBuilding = null;
		private UtilHoliday _utilHoliday = null;

		public GridBDBuildingHolidayMapDecorator(string userId, GridControl gridControl)
			: base(userId, gridControl)
		{
		}

		public BDBuilding BDBuilding
		{
			get { return this._bDBuilding; }
			set { this._bDBuilding = value; }
		}

		public UtilHoliday UtilHoliday
		{
			get { return this._utilHoliday; }
			set { this._utilHoliday = value; }
		}


		protected override void SetDisplayColumns(GridView view)
		{
			GridColumn colActionID = new GridColumn();
			colActionID.Caption = "ActionID";
			colActionID.FieldName = BDBuildingHolidayMapSchema.ActionID;
			colActionID.VisibleIndex = view.Columns.Count;
			colActionID.DisplayFormat.FormatType = FormatType.Numeric;
			colActionID.DisplayFormat.FormatString = "f0";
			view.Columns.Add(colActionID);

			GridColumn colNotes = new GridColumn();
			colNotes.Caption = "Notes";
			colNotes.FieldName = BDBuildingHolidayMapSchema.Notes;
			colNotes.VisibleIndex = view.Columns.Count;
			view.Columns.Add(colNotes);

			GridColumn colCreatedOn = new GridColumn();
			colCreatedOn.Caption = "CreatedOn";
			colCreatedOn.FieldName = BDBuildingHolidayMapSchema.CreatedOn;
			colCreatedOn.VisibleIndex = -1;
			colCreatedOn.OptionsColumn.ShowInCustomizationForm = false;
			colCreatedOn.DisplayFormat.FormatType = FormatType.DateTime;
			colCreatedOn.DisplayFormat.FormatString = "MM/dd/yyyy HH:mm:ss";
			view.Columns.Add(colCreatedOn);

			GridColumn colCreatedBy = new GridColumn();
			colCreatedBy.Caption = "CreatedBy";
			colCreatedBy.FieldName = BDBuildingHolidayMapSchema.CreatedBy;
			colCreatedBy.VisibleIndex = -1;
			colCreatedBy.OptionsColumn.ShowInCustomizationForm = false;
			view.Columns.Add(colCreatedBy);

			GridColumn colModifiedOn = new GridColumn();
			colModifiedOn.Caption = "ModifiedOn";
			colModifiedOn.FieldName = BDBuildingHolidayMapSchema.ModifiedOn;
			colModifiedOn.VisibleIndex = -1;
			colModifiedOn.OptionsColumn.ShowInCustomizationForm = false;
			colModifiedOn.DisplayFormat.FormatType = FormatType.DateTime;
			colModifiedOn.DisplayFormat.FormatString = "MM/dd/yyyy HH:mm:ss";
			view.Columns.Add(colModifiedOn);

			GridColumn colModifiedBy = new GridColumn();
			colModifiedBy.Caption = "ModifiedBy";
			colModifiedBy.FieldName = BDBuildingHolidayMapSchema.ModifiedBy;
			colModifiedBy.VisibleIndex = -1;
			colModifiedBy.OptionsColumn.ShowInCustomizationForm = false;
			view.Columns.Add(colModifiedBy);

			GridColumn colAddress1 = new GridColumn();
			colAddress1.Caption = "Address1";
			colAddress1.FieldName = BDBuildingHolidayMapSchema.Address1;
			colAddress1.OptionsColumn.AllowEdit = false;
			colAddress1.OptionsColumn.AllowFocus = false;
			colAddress1.VisibleIndex = view.Columns.Count;
			view.Columns.Add(colAddress1);

			GridColumn colBuildingID = new GridColumn();
			colBuildingID.Caption = "BuildingID";
			colBuildingID.FieldName = BDBuildingHolidayMapSchema.BuildingID;
			colBuildingID.OptionsColumn.AllowEdit = false;
			colBuildingID.OptionsColumn.AllowFocus = false;
			colBuildingID.VisibleIndex = view.Columns.Count;
			colBuildingID.DisplayFormat.FormatType = FormatType.Numeric;
			colBuildingID.DisplayFormat.FormatString = "f0";
			view.Columns.Add(colBuildingID);

			GridColumn colDate = new GridColumn();
			colDate.Caption = "Date";
			colDate.FieldName = BDBuildingHolidayMapSchema.Date;
			colDate.OptionsColumn.AllowEdit = false;
			colDate.OptionsColumn.AllowFocus = false;
			colDate.VisibleIndex = view.Columns.Count;
			colDate.DisplayFormat.FormatType = FormatType.DateTime;
			colDate.DisplayFormat.FormatString = "MM/dd/yyyy HH:mm:ss";
			view.Columns.Add(colDate);

			GridColumn colHoliday = new GridColumn();
			colHoliday.Caption = "Holiday";
			colHoliday.FieldName = BDBuildingHolidayMapSchema.Holiday;
			colHoliday.OptionsColumn.AllowEdit = false;
			colHoliday.OptionsColumn.AllowFocus = false;
			colHoliday.VisibleIndex = view.Columns.Count;
			view.Columns.Add(colHoliday);

		}

		protected override void NavigatorEditClick(GridView view, NavigatorButtonClickEventArgs e)
		{
			e.Handled = true;
			BDBuildingHolidayMapCollection list = view.DataSource as BDBuildingHolidayMapCollection;
			if (list == null)
				return;

			BDBuildingHolidayMap entity = view.GetRow(view.FocusedRowHandle) as BDBuildingHolidayMap;
			if (entity == null)
				return;

			FormDetailBDBuildingHolidayMap dlg = new FormDetailBDBuildingHolidayMap(base.UserId, entity.Clone() as BDBuildingHolidayMap, this.Editable);
			if (dlg.ShowDialog() == DialogResult.OK)
			{
				entity.CopyFrom(dlg.BDBuildingHolidayMap, true);

				view.CloseEditor();
				view.UpdateCurrentRow();
			}
		}

		protected override void NavigatorAppendClick(GridView view, NavigatorButtonClickEventArgs e)
		{
			e.Handled = true;
			BDBuildingHolidayMapCollection list = view.DataSource as BDBuildingHolidayMapCollection;
			if (list == null)
				return;

			if (this.BDBuilding != null)
			{
				SortedList<Guid, Guid> pkList = new SortedList<Guid, Guid>();
				foreach (BDBuildingHolidayMap item in list)
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
					BDBuildingHolidayMap entity = new BDBuildingHolidayMap();
					entity.CopyParent(item);
					entity.CopyParent(this.BDBuilding);
					list.Add(entity);
				}
			}
			else if (this.UtilHoliday != null)
			{
				SortedList<Guid, Guid> pkList = new SortedList<Guid, Guid>();
				foreach (BDBuildingHolidayMap item in list)
				{
					if (pkList.ContainsKey(item.BDBuildingPK))
						continue;

					pkList.Add(item.BDBuildingPK, item.BDBuildingPK);
				}

				FormSelectBDBuilding dlg = new FormSelectBDBuilding(base.UserId, pkList);
				if (dlg.ShowDialog() != DialogResult.OK)
					return;

				foreach (BDBuilding item in dlg.BDBuildingList)
				{
					BDBuildingHolidayMap entity = new BDBuildingHolidayMap();
					entity.CopyParent(item);
					entity.CopyParent(this.UtilHoliday);
					list.Add(entity);
				}
			}
		}
	}
}
