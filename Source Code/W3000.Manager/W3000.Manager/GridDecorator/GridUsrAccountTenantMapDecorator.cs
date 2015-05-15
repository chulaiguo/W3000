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
	public class GridUsrAccountTenantMapDecorator : GridControlDecorator
	{
		private BDTenant _bDTenant = null;
		private UsrAccount _usrAccount = null;

		public GridUsrAccountTenantMapDecorator(string userId, GridControl gridControl)
			: base(userId, gridControl)
		{
		}

		public BDTenant BDTenant
		{
			get { return this._bDTenant; }
			set { this._bDTenant = value; }
		}

		public UsrAccount UsrAccount
		{
			get { return this._usrAccount; }
			set { this._usrAccount = value; }
		}


		protected override void SetDisplayColumns(GridView view)
		{
			GridColumn colCreatedOn = new GridColumn();
			colCreatedOn.Caption = "CreatedOn";
			colCreatedOn.FieldName = UsrAccountTenantMapSchema.CreatedOn;
			colCreatedOn.VisibleIndex = -1;
			colCreatedOn.OptionsColumn.ShowInCustomizationForm = false;
			colCreatedOn.DisplayFormat.FormatType = FormatType.DateTime;
			colCreatedOn.DisplayFormat.FormatString = "MM/dd/yyyy HH:mm:ss";
			view.Columns.Add(colCreatedOn);

			GridColumn colCreatedBy = new GridColumn();
			colCreatedBy.Caption = "CreatedBy";
			colCreatedBy.FieldName = UsrAccountTenantMapSchema.CreatedBy;
			colCreatedBy.VisibleIndex = -1;
			colCreatedBy.OptionsColumn.ShowInCustomizationForm = false;
			view.Columns.Add(colCreatedBy);

			GridColumn colModifiedOn = new GridColumn();
			colModifiedOn.Caption = "ModifiedOn";
			colModifiedOn.FieldName = UsrAccountTenantMapSchema.ModifiedOn;
			colModifiedOn.VisibleIndex = -1;
			colModifiedOn.OptionsColumn.ShowInCustomizationForm = false;
			colModifiedOn.DisplayFormat.FormatType = FormatType.DateTime;
			colModifiedOn.DisplayFormat.FormatString = "MM/dd/yyyy HH:mm:ss";
			view.Columns.Add(colModifiedOn);

			GridColumn colModifiedBy = new GridColumn();
			colModifiedBy.Caption = "ModifiedBy";
			colModifiedBy.FieldName = UsrAccountTenantMapSchema.ModifiedBy;
			colModifiedBy.VisibleIndex = -1;
			colModifiedBy.OptionsColumn.ShowInCustomizationForm = false;
			view.Columns.Add(colModifiedBy);

			GridColumn colTenant = new GridColumn();
			colTenant.Caption = "Tenant";
			colTenant.FieldName = UsrAccountTenantMapSchema.Tenant;
			colTenant.OptionsColumn.AllowEdit = false;
			colTenant.OptionsColumn.AllowFocus = false;
			colTenant.VisibleIndex = view.Columns.Count;
			view.Columns.Add(colTenant);

		}

		protected override void NavigatorEditClick(GridView view, NavigatorButtonClickEventArgs e)
		{
			e.Handled = true;
			UsrAccountTenantMapCollection list = view.DataSource as UsrAccountTenantMapCollection;
			if (list == null)
				return;

			UsrAccountTenantMap entity = view.GetRow(view.FocusedRowHandle) as UsrAccountTenantMap;
			if (entity == null)
				return;

			FormDetailUsrAccountTenantMap dlg = new FormDetailUsrAccountTenantMap(base.UserId, entity.Clone() as UsrAccountTenantMap, false);
			dlg.ShowDialog();
		}

		protected override void NavigatorAppendClick(GridView view, NavigatorButtonClickEventArgs e)
		{
			e.Handled = true;
			UsrAccountTenantMapCollection list = view.DataSource as UsrAccountTenantMapCollection;
			if (list == null)
				return;

			if (this.BDTenant != null)
			{
				SortedList<Guid, Guid> pkList = new SortedList<Guid, Guid>();
				foreach (UsrAccountTenantMap item in list)
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
					UsrAccountTenantMap entity = new UsrAccountTenantMap();
					entity.CopyParent(item);
					entity.CopyParent(this.BDTenant);
					list.Add(entity);
				}
			}
			else if (this.UsrAccount != null)
			{
				SortedList<Guid, Guid> pkList = new SortedList<Guid, Guid>();
				foreach (UsrAccountTenantMap item in list)
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
					UsrAccountTenantMap entity = new UsrAccountTenantMap();
					entity.CopyParent(item);
					entity.CopyParent(this.UsrAccount);
					list.Add(entity);
				}
			}
		}
	}
}
