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
	public class GridUsrGroupDecorator : GridControlDecorator
	{

		public GridUsrGroupDecorator(string userId, GridControl gridControl)
			: base(userId, gridControl)
		{
		}


		protected override void SetDisplayColumns(GridView view)
		{
			GridColumn colUsrGroupName = new GridColumn();
			colUsrGroupName.Caption = "UsrGroupName";
			colUsrGroupName.FieldName = UsrGroupSchema.UsrGroupName;
			colUsrGroupName.VisibleIndex = view.Columns.Count;
			view.Columns.Add(colUsrGroupName);

			GridColumn colDescription = new GridColumn();
			colDescription.Caption = "Description";
			colDescription.FieldName = UsrGroupSchema.Description;
			colDescription.VisibleIndex = view.Columns.Count;
			view.Columns.Add(colDescription);

			GridColumn colCreatedOn = new GridColumn();
			colCreatedOn.Caption = "CreatedOn";
			colCreatedOn.FieldName = UsrGroupSchema.CreatedOn;
			colCreatedOn.VisibleIndex = -1;
			colCreatedOn.OptionsColumn.ShowInCustomizationForm = false;
			colCreatedOn.DisplayFormat.FormatType = FormatType.DateTime;
			colCreatedOn.DisplayFormat.FormatString = "MM/dd/yyyy HH:mm:ss";
			view.Columns.Add(colCreatedOn);

			GridColumn colCreatedBy = new GridColumn();
			colCreatedBy.Caption = "CreatedBy";
			colCreatedBy.FieldName = UsrGroupSchema.CreatedBy;
			colCreatedBy.VisibleIndex = -1;
			colCreatedBy.OptionsColumn.ShowInCustomizationForm = false;
			view.Columns.Add(colCreatedBy);

			GridColumn colModifiedOn = new GridColumn();
			colModifiedOn.Caption = "ModifiedOn";
			colModifiedOn.FieldName = UsrGroupSchema.ModifiedOn;
			colModifiedOn.VisibleIndex = -1;
			colModifiedOn.OptionsColumn.ShowInCustomizationForm = false;
			colModifiedOn.DisplayFormat.FormatType = FormatType.DateTime;
			colModifiedOn.DisplayFormat.FormatString = "MM/dd/yyyy HH:mm:ss";
			view.Columns.Add(colModifiedOn);

			GridColumn colModifiedBy = new GridColumn();
			colModifiedBy.Caption = "ModifiedBy";
			colModifiedBy.FieldName = UsrGroupSchema.ModifiedBy;
			colModifiedBy.VisibleIndex = -1;
			colModifiedBy.OptionsColumn.ShowInCustomizationForm = false;
			view.Columns.Add(colModifiedBy);

		}

		protected override void NavigatorEditClick(GridView view, NavigatorButtonClickEventArgs e)
		{
			e.Handled = true;
			UsrGroupCollection list = view.DataSource as UsrGroupCollection;
			if (list == null)
				return;

			UsrGroup entity = view.GetRow(view.FocusedRowHandle) as UsrGroup;
			if (entity == null)
				return;

			FormDetailUsrGroup dlg = new FormDetailUsrGroup(base.UserId, entity.Clone() as UsrGroup);
			dlg.ShowDialog();
		}

		protected override void NavigatorAppendClick(GridView view, NavigatorButtonClickEventArgs e)
		{
			e.Handled = true;
			UsrGroupCollection list = view.DataSource as UsrGroupCollection;
			if (list == null)
				return;

			UsrGroup entity = new UsrGroup();

			FormDetailUsrGroup dlg = new FormDetailUsrGroup(base.UserId, entity);
			dlg.ShowDialog();
		}
	}
}
