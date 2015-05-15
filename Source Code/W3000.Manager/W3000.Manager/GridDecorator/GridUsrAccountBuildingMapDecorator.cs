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
	public class GridUsrAccountBuildingMapDecorator : GridControlDecorator
	{
		private BDBuilding _bDBuilding = null;
		private UsrAccount _usrAccount = null;

		public GridUsrAccountBuildingMapDecorator(string userId, GridControl gridControl)
			: base(userId, gridControl)
		{
		}

		public BDBuilding BDBuilding
		{
			get { return this._bDBuilding; }
			set { this._bDBuilding = value; }
		}

		public UsrAccount UsrAccount
		{
			get { return this._usrAccount; }
			set { this._usrAccount = value; }
		}


		protected override void SetDisplayColumns(GridView view)
		{
			GridColumn colBuildingWide = new GridColumn();
			colBuildingWide.Caption = "BuildingWide";
			colBuildingWide.FieldName = UsrAccountBuildingMapSchema.BuildingWide;
			colBuildingWide.VisibleIndex = view.Columns.Count;
			view.Columns.Add(colBuildingWide);

			GridColumn colCreatedOn = new GridColumn();
			colCreatedOn.Caption = "CreatedOn";
			colCreatedOn.FieldName = UsrAccountBuildingMapSchema.CreatedOn;
			colCreatedOn.VisibleIndex = -1;
			colCreatedOn.OptionsColumn.ShowInCustomizationForm = false;
			colCreatedOn.DisplayFormat.FormatType = FormatType.DateTime;
			colCreatedOn.DisplayFormat.FormatString = "MM/dd/yyyy HH:mm:ss";
			view.Columns.Add(colCreatedOn);

			GridColumn colCreatedBy = new GridColumn();
			colCreatedBy.Caption = "CreatedBy";
			colCreatedBy.FieldName = UsrAccountBuildingMapSchema.CreatedBy;
			colCreatedBy.VisibleIndex = -1;
			colCreatedBy.OptionsColumn.ShowInCustomizationForm = false;
			view.Columns.Add(colCreatedBy);

			GridColumn colModifiedOn = new GridColumn();
			colModifiedOn.Caption = "ModifiedOn";
			colModifiedOn.FieldName = UsrAccountBuildingMapSchema.ModifiedOn;
			colModifiedOn.VisibleIndex = -1;
			colModifiedOn.OptionsColumn.ShowInCustomizationForm = false;
			colModifiedOn.DisplayFormat.FormatType = FormatType.DateTime;
			colModifiedOn.DisplayFormat.FormatString = "MM/dd/yyyy HH:mm:ss";
			view.Columns.Add(colModifiedOn);

			GridColumn colModifiedBy = new GridColumn();
			colModifiedBy.Caption = "ModifiedBy";
			colModifiedBy.FieldName = UsrAccountBuildingMapSchema.ModifiedBy;
			colModifiedBy.VisibleIndex = -1;
			colModifiedBy.OptionsColumn.ShowInCustomizationForm = false;
			view.Columns.Add(colModifiedBy);

			GridColumn colAccessTC = new GridColumn();
			colAccessTC.Caption = "AccessTC";
			colAccessTC.FieldName = UsrAccountBuildingMapSchema.AccessTC;
			colAccessTC.VisibleIndex = view.Columns.Count;
			colAccessTC.DisplayFormat.FormatType = FormatType.Numeric;
			colAccessTC.DisplayFormat.FormatString = "f0";
			view.Columns.Add(colAccessTC);

			GridColumn colPermission = new GridColumn();
			colPermission.Caption = "Permission";
			colPermission.FieldName = UsrAccountBuildingMapSchema.Permission;
			colPermission.VisibleIndex = view.Columns.Count;
			colPermission.DisplayFormat.FormatType = FormatType.Numeric;
			colPermission.DisplayFormat.FormatString = "f0";
			view.Columns.Add(colPermission);

			GridColumn colPrimary = new GridColumn();
			colPrimary.Caption = "Primary";
			colPrimary.FieldName = UsrAccountBuildingMapSchema.Primary;
			colPrimary.VisibleIndex = view.Columns.Count;
			view.Columns.Add(colPrimary);

			GridColumn colAddress1 = new GridColumn();
			colAddress1.Caption = "Address1";
			colAddress1.FieldName = UsrAccountBuildingMapSchema.Address1;
			colAddress1.OptionsColumn.AllowEdit = false;
			colAddress1.OptionsColumn.AllowFocus = false;
			colAddress1.VisibleIndex = view.Columns.Count;
			view.Columns.Add(colAddress1);

			GridColumn colBuildingID = new GridColumn();
			colBuildingID.Caption = "BuildingID";
			colBuildingID.FieldName = UsrAccountBuildingMapSchema.BuildingID;
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
			UsrAccountBuildingMapCollection list = view.DataSource as UsrAccountBuildingMapCollection;
			if (list == null)
				return;

			UsrAccountBuildingMap entity = view.GetRow(view.FocusedRowHandle) as UsrAccountBuildingMap;
			if (entity == null)
				return;

			FormDetailUsrAccountBuildingMap dlg = new FormDetailUsrAccountBuildingMap(base.UserId, entity.Clone() as UsrAccountBuildingMap, this.Editable);
			if (dlg.ShowDialog() == DialogResult.OK)
			{
				entity.CopyFrom(dlg.UsrAccountBuildingMap, true);

				view.CloseEditor();
				view.UpdateCurrentRow();
			}
		}

		protected override void NavigatorAppendClick(GridView view, NavigatorButtonClickEventArgs e)
		{
			e.Handled = true;
			UsrAccountBuildingMapCollection list = view.DataSource as UsrAccountBuildingMapCollection;
			if (list == null)
				return;

			if (this.BDBuilding != null)
			{
				SortedList<Guid, Guid> pkList = new SortedList<Guid, Guid>();
				foreach (UsrAccountBuildingMap item in list)
				{
					if (pkList.ContainsKey(item.UsrAccountPK))
						continue;

					pkList.Add(item.UsrAccountPK, item.UsrAccountPK);
				}

				FormSelectUsrAccount dlg = new FormSelectUsrAccount(base.UserId, pkList);
				if (dlg.ShowDialog() != DialogResult.OK)
					return;

				foreach (UsrAccount item in dlg.UsrAccountList)
				{
					UsrAccountBuildingMap entity = new UsrAccountBuildingMap();
					entity.CopyParent(item);
					entity.CopyParent(this.BDBuilding);
					list.Add(entity);
				}
			}
			else if (this.UsrAccount != null)
			{
				SortedList<Guid, Guid> pkList = new SortedList<Guid, Guid>();
				foreach (UsrAccountBuildingMap item in list)
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
					UsrAccountBuildingMap entity = new UsrAccountBuildingMap();
					entity.CopyParent(item);
					entity.CopyParent(this.UsrAccount);
					list.Add(entity);
				}
			}
		}
	}
}
