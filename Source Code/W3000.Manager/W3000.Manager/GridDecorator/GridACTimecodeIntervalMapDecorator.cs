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
	public class GridACTimecodeIntervalMapDecorator : GridControlDecorator
	{
		private ACInterval _aCInterval = null;
		private ACTimecode _aCTimecode = null;

		public GridACTimecodeIntervalMapDecorator(string userId, GridControl gridControl)
			: base(userId, gridControl)
		{
		}

		public ACInterval ACInterval
		{
			get { return this._aCInterval; }
			set { this._aCInterval = value; }
		}

		public ACTimecode ACTimecode
		{
			get { return this._aCTimecode; }
			set { this._aCTimecode = value; }
		}


		protected override void SetDisplayColumns(GridView view)
		{
			GridColumn colCreatedOn = new GridColumn();
			colCreatedOn.Caption = "CreatedOn";
			colCreatedOn.FieldName = ACTimecodeIntervalMapSchema.CreatedOn;
			colCreatedOn.VisibleIndex = -1;
			colCreatedOn.OptionsColumn.ShowInCustomizationForm = false;
			colCreatedOn.DisplayFormat.FormatType = FormatType.DateTime;
			colCreatedOn.DisplayFormat.FormatString = "MM/dd/yyyy HH:mm:ss";
			view.Columns.Add(colCreatedOn);

			GridColumn colCreatedBy = new GridColumn();
			colCreatedBy.Caption = "CreatedBy";
			colCreatedBy.FieldName = ACTimecodeIntervalMapSchema.CreatedBy;
			colCreatedBy.VisibleIndex = -1;
			colCreatedBy.OptionsColumn.ShowInCustomizationForm = false;
			view.Columns.Add(colCreatedBy);

			GridColumn colModifiedOn = new GridColumn();
			colModifiedOn.Caption = "ModifiedOn";
			colModifiedOn.FieldName = ACTimecodeIntervalMapSchema.ModifiedOn;
			colModifiedOn.VisibleIndex = -1;
			colModifiedOn.OptionsColumn.ShowInCustomizationForm = false;
			colModifiedOn.DisplayFormat.FormatType = FormatType.DateTime;
			colModifiedOn.DisplayFormat.FormatString = "MM/dd/yyyy HH:mm:ss";
			view.Columns.Add(colModifiedOn);

			GridColumn colModifiedBy = new GridColumn();
			colModifiedBy.Caption = "ModifiedBy";
			colModifiedBy.FieldName = ACTimecodeIntervalMapSchema.ModifiedBy;
			colModifiedBy.VisibleIndex = -1;
			colModifiedBy.OptionsColumn.ShowInCustomizationForm = false;
			view.Columns.Add(colModifiedBy);

			GridColumn colEnd = new GridColumn();
			colEnd.Caption = "End";
			colEnd.FieldName = ACTimecodeIntervalMapSchema.End;
			colEnd.OptionsColumn.AllowEdit = false;
			colEnd.OptionsColumn.AllowFocus = false;
			colEnd.VisibleIndex = view.Columns.Count;
			view.Columns.Add(colEnd);

			GridColumn colBegin = new GridColumn();
			colBegin.Caption = "Begin";
			colBegin.FieldName = ACTimecodeIntervalMapSchema.Begin;
			colBegin.OptionsColumn.AllowEdit = false;
			colBegin.OptionsColumn.AllowFocus = false;
			colBegin.VisibleIndex = view.Columns.Count;
			view.Columns.Add(colBegin);

			GridColumn colIVID = new GridColumn();
			colIVID.Caption = "IVID";
			colIVID.FieldName = ACTimecodeIntervalMapSchema.IVID;
			colIVID.OptionsColumn.AllowEdit = false;
			colIVID.OptionsColumn.AllowFocus = false;
			colIVID.VisibleIndex = view.Columns.Count;
			colIVID.DisplayFormat.FormatType = FormatType.Numeric;
			colIVID.DisplayFormat.FormatString = "f0";
			view.Columns.Add(colIVID);

			GridColumn colTCID = new GridColumn();
			colTCID.Caption = "TCID";
			colTCID.FieldName = ACTimecodeIntervalMapSchema.TCID;
			colTCID.OptionsColumn.AllowEdit = false;
			colTCID.OptionsColumn.AllowFocus = false;
			colTCID.VisibleIndex = view.Columns.Count;
			colTCID.DisplayFormat.FormatType = FormatType.Numeric;
			colTCID.DisplayFormat.FormatString = "f0";
			view.Columns.Add(colTCID);

		}

		protected override void NavigatorEditClick(GridView view, NavigatorButtonClickEventArgs e)
		{
			e.Handled = true;
			ACTimecodeIntervalMapCollection list = view.DataSource as ACTimecodeIntervalMapCollection;
			if (list == null)
				return;

			ACTimecodeIntervalMap entity = view.GetRow(view.FocusedRowHandle) as ACTimecodeIntervalMap;
			if (entity == null)
				return;

			FormDetailACTimecodeIntervalMap dlg = new FormDetailACTimecodeIntervalMap(base.UserId, entity.Clone() as ACTimecodeIntervalMap, false);
			dlg.ShowDialog();
		}

		protected override void NavigatorAppendClick(GridView view, NavigatorButtonClickEventArgs e)
		{
			e.Handled = true;
			ACTimecodeIntervalMapCollection list = view.DataSource as ACTimecodeIntervalMapCollection;
			if (list == null)
				return;

			if (this.ACInterval != null)
			{
				SortedList<Guid, Guid> pkList = new SortedList<Guid, Guid>();
				foreach (ACTimecodeIntervalMap item in list)
				{
					if (pkList.ContainsKey(item.ACTimecodePK))
						continue;

					pkList.Add(item.ACTimecodePK, item.ACTimecodePK);
				}

				FormSelectACTimecode dlg = new FormSelectACTimecode(base.UserId, pkList);
				if (dlg.ShowDialog() != DialogResult.OK)
					return;

				foreach (ACTimecode item in dlg.ACTimecodeList)
				{
					ACTimecodeIntervalMap entity = new ACTimecodeIntervalMap();
					entity.CopyParent(item);
					entity.CopyParent(this.ACInterval);
					list.Add(entity);
				}
			}
			else if (this.ACTimecode != null)
			{
				SortedList<Guid, Guid> pkList = new SortedList<Guid, Guid>();
				foreach (ACTimecodeIntervalMap item in list)
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
					ACTimecodeIntervalMap entity = new ACTimecodeIntervalMap();
					entity.CopyParent(item);
					entity.CopyParent(this.ACTimecode);
					list.Add(entity);
				}
			}
		}
	}
}
