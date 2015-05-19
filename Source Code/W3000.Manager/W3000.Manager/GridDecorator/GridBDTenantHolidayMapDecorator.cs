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
	public class GridBDTenantHolidayMapDecorator : GridControlDecorator
	{
		private BDTenant _bDTenant = null;
		private UtilHoliday _utilHoliday = null;

		public GridBDTenantHolidayMapDecorator(string userId, GridControl gridControl)
			: base(userId, gridControl)
		{
		}

		public BDTenant BDTenant
		{
			get { return this._bDTenant; }
			set { this._bDTenant = value; }
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
			colActionID.FieldName = BDTenantHolidayMapSchema.ActionID;
			colActionID.VisibleIndex = view.Columns.Count;
			colActionID.DisplayFormat.FormatType = FormatType.Numeric;
			colActionID.DisplayFormat.FormatString = "f0";
			view.Columns.Add(colActionID);

			GridColumn colNotes = new GridColumn();
			colNotes.Caption = "Notes";
			colNotes.FieldName = BDTenantHolidayMapSchema.Notes;
			colNotes.VisibleIndex = view.Columns.Count;
			view.Columns.Add(colNotes);

			GridColumn colCreatedOn = new GridColumn();
			colCreatedOn.Caption = "CreatedOn";
			colCreatedOn.FieldName = BDTenantHolidayMapSchema.CreatedOn;
			colCreatedOn.VisibleIndex = -1;
			colCreatedOn.OptionsColumn.ShowInCustomizationForm = false;
			colCreatedOn.DisplayFormat.FormatType = FormatType.DateTime;
			colCreatedOn.DisplayFormat.FormatString = "MM/dd/yyyy HH:mm:ss";
			view.Columns.Add(colCreatedOn);

			GridColumn colCreatedBy = new GridColumn();
			colCreatedBy.Caption = "CreatedBy";
			colCreatedBy.FieldName = BDTenantHolidayMapSchema.CreatedBy;
			colCreatedBy.VisibleIndex = -1;
			colCreatedBy.OptionsColumn.ShowInCustomizationForm = false;
			view.Columns.Add(colCreatedBy);

			GridColumn colModifiedOn = new GridColumn();
			colModifiedOn.Caption = "ModifiedOn";
			colModifiedOn.FieldName = BDTenantHolidayMapSchema.ModifiedOn;
			colModifiedOn.VisibleIndex = -1;
			colModifiedOn.OptionsColumn.ShowInCustomizationForm = false;
			colModifiedOn.DisplayFormat.FormatType = FormatType.DateTime;
			colModifiedOn.DisplayFormat.FormatString = "MM/dd/yyyy HH:mm:ss";
			view.Columns.Add(colModifiedOn);

			GridColumn colModifiedBy = new GridColumn();
			colModifiedBy.Caption = "ModifiedBy";
			colModifiedBy.FieldName = BDTenantHolidayMapSchema.ModifiedBy;
			colModifiedBy.VisibleIndex = -1;
			colModifiedBy.OptionsColumn.ShowInCustomizationForm = false;
			view.Columns.Add(colModifiedBy);

			GridColumn colTenant = new GridColumn();
			colTenant.Caption = "Tenant";
			colTenant.FieldName = BDTenantHolidayMapSchema.Tenant;
			colTenant.OptionsColumn.AllowEdit = false;
			colTenant.OptionsColumn.AllowFocus = false;
			colTenant.VisibleIndex = view.Columns.Count;
			view.Columns.Add(colTenant);

			GridColumn colDate = new GridColumn();
			colDate.Caption = "Date";
			colDate.FieldName = BDTenantHolidayMapSchema.Date;
			colDate.OptionsColumn.AllowEdit = false;
			colDate.OptionsColumn.AllowFocus = false;
			colDate.VisibleIndex = view.Columns.Count;
			colDate.DisplayFormat.FormatType = FormatType.DateTime;
			colDate.DisplayFormat.FormatString = "MM/dd/yyyy HH:mm:ss";
			view.Columns.Add(colDate);

			GridColumn colHoliday = new GridColumn();
			colHoliday.Caption = "Holiday";
			colHoliday.FieldName = BDTenantHolidayMapSchema.Holiday;
			colHoliday.OptionsColumn.AllowEdit = false;
			colHoliday.OptionsColumn.AllowFocus = false;
			colHoliday.VisibleIndex = view.Columns.Count;
			view.Columns.Add(colHoliday);

			GridColumn colAddress1 = new GridColumn();
			colAddress1.Caption = "Address1";
			colAddress1.FieldName = BDTenantHolidayMapSchema.Address1;
			colAddress1.OptionsColumn.AllowEdit = false;
			colAddress1.OptionsColumn.AllowFocus = false;
			colAddress1.VisibleIndex = view.Columns.Count;
			view.Columns.Add(colAddress1);

			GridColumn colBuildingID = new GridColumn();
			colBuildingID.Caption = "BuildingID";
			colBuildingID.FieldName = BDTenantHolidayMapSchema.BuildingID;
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
			BDTenantHolidayMapCollection list = view.DataSource as BDTenantHolidayMapCollection;
			if (list == null)
				return;

			BDTenantHolidayMap entity = view.GetRow(view.FocusedRowHandle) as BDTenantHolidayMap;
			if (entity == null)
				return;

			FormDetailBDTenantHolidayMap dlg = new FormDetailBDTenantHolidayMap(base.UserId, entity.Clone() as BDTenantHolidayMap, this.Editable);
			if (dlg.ShowDialog() == DialogResult.OK)
			{
				entity.CopyFrom(dlg.BDTenantHolidayMap, true);

				view.CloseEditor();
				view.UpdateCurrentRow();
			}
		}

		protected override void NavigatorAppendClick(GridView view, NavigatorButtonClickEventArgs e)
		{
			e.Handled = true;
			BDTenantHolidayMapCollection list = view.DataSource as BDTenantHolidayMapCollection;
			if (list == null)
				return;

			if (this.BDTenant != null)
			{
				SortedList<Guid, Guid> pkList = new SortedList<Guid, Guid>();
				foreach (BDTenantHolidayMap item in list)
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
					BDTenantHolidayMap entity = new BDTenantHolidayMap();
					entity.CopyParent(item);
					entity.CopyParent(this.BDTenant);
					list.Add(entity);
				}
			}
			else if (this.UtilHoliday != null)
			{
				SortedList<Guid, Guid> pkList = new SortedList<Guid, Guid>();
				foreach (BDTenantHolidayMap item in list)
				{
					if (pkList.ContainsKey(item.BDTenantPK))
						continue;

					pkList.Add(item.BDTenantPK, item.BDTenantPK);
				}

				FormSelectBDTenant dlg = new FormSelectBDTenant(base.UserId, pkList);
				if (dlg.ShowDialog() != DialogResult.OK)
					return;

				foreach (BDTenant item in dlg.BDTenantList)
				{
					BDTenantHolidayMap entity = new BDTenantHolidayMap();
					entity.CopyParent(item);
					entity.CopyParent(this.UtilHoliday);
					list.Add(entity);
				}
			}
		}
	}
}
