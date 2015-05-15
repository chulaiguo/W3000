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
	public class GridACInputGroupInputMapDecorator : GridControlDecorator
	{
		private ACInputGroup _aCInputGroup = null;
		private ACInput _aCInput = null;

		public GridACInputGroupInputMapDecorator(string userId, GridControl gridControl)
			: base(userId, gridControl)
		{
		}

		public ACInputGroup ACInputGroup
		{
			get { return this._aCInputGroup; }
			set { this._aCInputGroup = value; }
		}

		public ACInput ACInput
		{
			get { return this._aCInput; }
			set { this._aCInput = value; }
		}


		protected override void SetDisplayColumns(GridView view)
		{
			GridColumn colCreatedOn = new GridColumn();
			colCreatedOn.Caption = "CreatedOn";
			colCreatedOn.FieldName = ACInputGroupInputMapSchema.CreatedOn;
			colCreatedOn.VisibleIndex = -1;
			colCreatedOn.OptionsColumn.ShowInCustomizationForm = false;
			colCreatedOn.DisplayFormat.FormatType = FormatType.DateTime;
			colCreatedOn.DisplayFormat.FormatString = "MM/dd/yyyy HH:mm:ss";
			view.Columns.Add(colCreatedOn);

			GridColumn colCreatedBy = new GridColumn();
			colCreatedBy.Caption = "CreatedBy";
			colCreatedBy.FieldName = ACInputGroupInputMapSchema.CreatedBy;
			colCreatedBy.VisibleIndex = -1;
			colCreatedBy.OptionsColumn.ShowInCustomizationForm = false;
			view.Columns.Add(colCreatedBy);

			GridColumn colModifiedOn = new GridColumn();
			colModifiedOn.Caption = "ModifiedOn";
			colModifiedOn.FieldName = ACInputGroupInputMapSchema.ModifiedOn;
			colModifiedOn.VisibleIndex = -1;
			colModifiedOn.OptionsColumn.ShowInCustomizationForm = false;
			colModifiedOn.DisplayFormat.FormatType = FormatType.DateTime;
			colModifiedOn.DisplayFormat.FormatString = "MM/dd/yyyy HH:mm:ss";
			view.Columns.Add(colModifiedOn);

			GridColumn colModifiedBy = new GridColumn();
			colModifiedBy.Caption = "ModifiedBy";
			colModifiedBy.FieldName = ACInputGroupInputMapSchema.ModifiedBy;
			colModifiedBy.VisibleIndex = -1;
			colModifiedBy.OptionsColumn.ShowInCustomizationForm = false;
			view.Columns.Add(colModifiedBy);

			GridColumn colGroupID = new GridColumn();
			colGroupID.Caption = "GroupID";
			colGroupID.FieldName = ACInputGroupInputMapSchema.GroupID;
			colGroupID.OptionsColumn.AllowEdit = false;
			colGroupID.OptionsColumn.AllowFocus = false;
			colGroupID.VisibleIndex = view.Columns.Count;
			colGroupID.DisplayFormat.FormatType = FormatType.Numeric;
			colGroupID.DisplayFormat.FormatString = "f0";
			view.Columns.Add(colGroupID);

			GridColumn colInputID = new GridColumn();
			colInputID.Caption = "InputID";
			colInputID.FieldName = ACInputGroupInputMapSchema.InputID;
			colInputID.OptionsColumn.AllowEdit = false;
			colInputID.OptionsColumn.AllowFocus = false;
			colInputID.VisibleIndex = view.Columns.Count;
			colInputID.DisplayFormat.FormatType = FormatType.Numeric;
			colInputID.DisplayFormat.FormatString = "f0";
			view.Columns.Add(colInputID);

		}

		protected override void NavigatorEditClick(GridView view, NavigatorButtonClickEventArgs e)
		{
			e.Handled = true;
			ACInputGroupInputMapCollection list = view.DataSource as ACInputGroupInputMapCollection;
			if (list == null)
				return;

			ACInputGroupInputMap entity = view.GetRow(view.FocusedRowHandle) as ACInputGroupInputMap;
			if (entity == null)
				return;

			FormDetailACInputGroupInputMap dlg = new FormDetailACInputGroupInputMap(base.UserId, entity.Clone() as ACInputGroupInputMap, false);
			dlg.ShowDialog();
		}

		protected override void NavigatorAppendClick(GridView view, NavigatorButtonClickEventArgs e)
		{
			e.Handled = true;
			ACInputGroupInputMapCollection list = view.DataSource as ACInputGroupInputMapCollection;
			if (list == null)
				return;

			if (this.ACInputGroup != null)
			{
				SortedList<Guid, Guid> pkList = new SortedList<Guid, Guid>();
				foreach (ACInputGroupInputMap item in list)
				{
					if (pkList.ContainsKey(item.ACInputPK))
						continue;

					pkList.Add(item.ACInputPK, item.ACInputPK);
				}

				FormSelectACInput dlg = new FormSelectACInput(base.UserId, pkList);
				if (dlg.ShowDialog() != DialogResult.OK)
					return;

				foreach (ACInput item in dlg.ACInputList)
				{
					ACInputGroupInputMap entity = new ACInputGroupInputMap();
					entity.CopyParent(item);
					entity.CopyParent(this.ACInputGroup);
					list.Add(entity);
				}
			}
			else if (this.ACInput != null)
			{
				SortedList<Guid, Guid> pkList = new SortedList<Guid, Guid>();
				foreach (ACInputGroupInputMap item in list)
				{
					if (pkList.ContainsKey(item.ACInputGroupPK))
						continue;

					pkList.Add(item.ACInputGroupPK, item.ACInputGroupPK);
				}

				FormSelectACInputGroup dlg = new FormSelectACInputGroup(base.UserId, pkList);
				if (dlg.ShowDialog() != DialogResult.OK)
					return;

				foreach (ACInputGroup item in dlg.ACInputGroupList)
				{
					ACInputGroupInputMap entity = new ACInputGroupInputMap();
					entity.CopyParent(item);
					entity.CopyParent(this.ACInput);
					list.Add(entity);
				}
			}
		}
	}
}
