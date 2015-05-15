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
	public class GridACOutputGroupMainZoneMapDecorator : GridControlDecorator
	{
		private ACMainZone _aCMainZone = null;
		private ACOutputGroup _aCOutputGroup = null;

		public GridACOutputGroupMainZoneMapDecorator(string userId, GridControl gridControl)
			: base(userId, gridControl)
		{
		}

		public ACMainZone ACMainZone
		{
			get { return this._aCMainZone; }
			set { this._aCMainZone = value; }
		}

		public ACOutputGroup ACOutputGroup
		{
			get { return this._aCOutputGroup; }
			set { this._aCOutputGroup = value; }
		}


		protected override void SetDisplayColumns(GridView view)
		{
			GridColumn colCreatedOn = new GridColumn();
			colCreatedOn.Caption = "CreatedOn";
			colCreatedOn.FieldName = ACOutputGroupMainZoneMapSchema.CreatedOn;
			colCreatedOn.VisibleIndex = -1;
			colCreatedOn.OptionsColumn.ShowInCustomizationForm = false;
			colCreatedOn.DisplayFormat.FormatType = FormatType.DateTime;
			colCreatedOn.DisplayFormat.FormatString = "MM/dd/yyyy HH:mm:ss";
			view.Columns.Add(colCreatedOn);

			GridColumn colCreatedBy = new GridColumn();
			colCreatedBy.Caption = "CreatedBy";
			colCreatedBy.FieldName = ACOutputGroupMainZoneMapSchema.CreatedBy;
			colCreatedBy.VisibleIndex = -1;
			colCreatedBy.OptionsColumn.ShowInCustomizationForm = false;
			view.Columns.Add(colCreatedBy);

			GridColumn colModifiedOn = new GridColumn();
			colModifiedOn.Caption = "ModifiedOn";
			colModifiedOn.FieldName = ACOutputGroupMainZoneMapSchema.ModifiedOn;
			colModifiedOn.VisibleIndex = -1;
			colModifiedOn.OptionsColumn.ShowInCustomizationForm = false;
			colModifiedOn.DisplayFormat.FormatType = FormatType.DateTime;
			colModifiedOn.DisplayFormat.FormatString = "MM/dd/yyyy HH:mm:ss";
			view.Columns.Add(colModifiedOn);

			GridColumn colModifiedBy = new GridColumn();
			colModifiedBy.Caption = "ModifiedBy";
			colModifiedBy.FieldName = ACOutputGroupMainZoneMapSchema.ModifiedBy;
			colModifiedBy.VisibleIndex = -1;
			colModifiedBy.OptionsColumn.ShowInCustomizationForm = false;
			view.Columns.Add(colModifiedBy);

			GridColumn colMainZoneID = new GridColumn();
			colMainZoneID.Caption = "MainZoneID";
			colMainZoneID.FieldName = ACOutputGroupMainZoneMapSchema.MainZoneID;
			colMainZoneID.OptionsColumn.AllowEdit = false;
			colMainZoneID.OptionsColumn.AllowFocus = false;
			colMainZoneID.VisibleIndex = view.Columns.Count;
			colMainZoneID.DisplayFormat.FormatType = FormatType.Numeric;
			colMainZoneID.DisplayFormat.FormatString = "f0";
			view.Columns.Add(colMainZoneID);

			GridColumn colGroupID = new GridColumn();
			colGroupID.Caption = "GroupID";
			colGroupID.FieldName = ACOutputGroupMainZoneMapSchema.GroupID;
			colGroupID.OptionsColumn.AllowEdit = false;
			colGroupID.OptionsColumn.AllowFocus = false;
			colGroupID.VisibleIndex = view.Columns.Count;
			colGroupID.DisplayFormat.FormatType = FormatType.Numeric;
			colGroupID.DisplayFormat.FormatString = "f0";
			view.Columns.Add(colGroupID);

		}

		protected override void NavigatorEditClick(GridView view, NavigatorButtonClickEventArgs e)
		{
			e.Handled = true;
			ACOutputGroupMainZoneMapCollection list = view.DataSource as ACOutputGroupMainZoneMapCollection;
			if (list == null)
				return;

			ACOutputGroupMainZoneMap entity = view.GetRow(view.FocusedRowHandle) as ACOutputGroupMainZoneMap;
			if (entity == null)
				return;

			FormDetailACOutputGroupMainZoneMap dlg = new FormDetailACOutputGroupMainZoneMap(base.UserId, entity.Clone() as ACOutputGroupMainZoneMap, false);
			dlg.ShowDialog();
		}

		protected override void NavigatorAppendClick(GridView view, NavigatorButtonClickEventArgs e)
		{
			e.Handled = true;
			ACOutputGroupMainZoneMapCollection list = view.DataSource as ACOutputGroupMainZoneMapCollection;
			if (list == null)
				return;

			if (this.ACMainZone != null)
			{
				SortedList<Guid, Guid> pkList = new SortedList<Guid, Guid>();
				foreach (ACOutputGroupMainZoneMap item in list)
				{
					if (pkList.ContainsKey(item.ACOutputGroupPK))
						continue;

					pkList.Add(item.ACOutputGroupPK, item.ACOutputGroupPK);
				}

				FormSelectACOutputGroup dlg = new FormSelectACOutputGroup(base.UserId, pkList);
				if (dlg.ShowDialog() != DialogResult.OK)
					return;

				foreach (ACOutputGroup item in dlg.ACOutputGroupList)
				{
					ACOutputGroupMainZoneMap entity = new ACOutputGroupMainZoneMap();
					entity.CopyParent(item);
					entity.CopyParent(this.ACMainZone);
					list.Add(entity);
				}
			}
			else if (this.ACOutputGroup != null)
			{
				SortedList<Guid, Guid> pkList = new SortedList<Guid, Guid>();
				foreach (ACOutputGroupMainZoneMap item in list)
				{
					if (pkList.ContainsKey(item.ACMainZonePK))
						continue;

					pkList.Add(item.ACMainZonePK, item.ACMainZonePK);
				}

				FormSelectACMainZone dlg = new FormSelectACMainZone(base.UserId, pkList);
				if (dlg.ShowDialog() != DialogResult.OK)
					return;

				foreach (ACMainZone item in dlg.ACMainZoneList)
				{
					ACOutputGroupMainZoneMap entity = new ACOutputGroupMainZoneMap();
					entity.CopyParent(item);
					entity.CopyParent(this.ACOutputGroup);
					list.Add(entity);
				}
			}
		}
	}
}
