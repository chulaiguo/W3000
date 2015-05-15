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
	public class GridACInputDecorator : GridControlDecorator
	{
		private ACPanel _aCPanel = null;

		public GridACInputDecorator(string userId, GridControl gridControl)
			: base(userId, gridControl)
		{
		}

		public ACPanel ACPanel
		{
			get { return this._aCPanel; }
			set { this._aCPanel = value; }
		}


		protected override void SetDisplayColumns(GridView view)
		{
			GridColumn colInputID = new GridColumn();
			colInputID.Caption = "InputID";
			colInputID.FieldName = ACInputSchema.InputID;
			colInputID.VisibleIndex = view.Columns.Count;
			colInputID.DisplayFormat.FormatType = FormatType.Numeric;
			colInputID.DisplayFormat.FormatString = "f0";
			view.Columns.Add(colInputID);

			GridColumn colDescription = new GridColumn();
			colDescription.Caption = "Description";
			colDescription.FieldName = ACInputSchema.Description;
			colDescription.VisibleIndex = view.Columns.Count;
			view.Columns.Add(colDescription);

			GridColumn colDebounce = new GridColumn();
			colDebounce.Caption = "Debounce";
			colDebounce.FieldName = ACInputSchema.Debounce;
			colDebounce.VisibleIndex = view.Columns.Count;
			colDebounce.DisplayFormat.FormatType = FormatType.Numeric;
			colDebounce.DisplayFormat.FormatString = "f0";
			view.Columns.Add(colDebounce);

			GridColumn colReverse = new GridColumn();
			colReverse.Caption = "Reverse";
			colReverse.FieldName = ACInputSchema.Reverse;
			colReverse.VisibleIndex = view.Columns.Count;
			view.Columns.Add(colReverse);

			GridColumn colForceAMFormat = new GridColumn();
			colForceAMFormat.Caption = "ForceAMFormat";
			colForceAMFormat.FieldName = ACInputSchema.ForceAMFormat;
			colForceAMFormat.VisibleIndex = view.Columns.Count;
			colForceAMFormat.DisplayFormat.FormatType = FormatType.Numeric;
			colForceAMFormat.DisplayFormat.FormatString = "f0";
			view.Columns.Add(colForceAMFormat);

			GridColumn colOffOnRestore = new GridColumn();
			colOffOnRestore.Caption = "OffOnRestore";
			colOffOnRestore.FieldName = ACInputSchema.OffOnRestore;
			colOffOnRestore.VisibleIndex = view.Columns.Count;
			view.Columns.Add(colOffOnRestore);

			GridColumn colExternal = new GridColumn();
			colExternal.Caption = "External";
			colExternal.FieldName = ACInputSchema.External;
			colExternal.VisibleIndex = view.Columns.Count;
			view.Columns.Add(colExternal);

			GridColumn colNotes = new GridColumn();
			colNotes.Caption = "Notes";
			colNotes.FieldName = ACInputSchema.Notes;
			colNotes.VisibleIndex = view.Columns.Count;
			view.Columns.Add(colNotes);

			GridColumn colCreatedOn = new GridColumn();
			colCreatedOn.Caption = "CreatedOn";
			colCreatedOn.FieldName = ACInputSchema.CreatedOn;
			colCreatedOn.VisibleIndex = -1;
			colCreatedOn.OptionsColumn.ShowInCustomizationForm = false;
			colCreatedOn.DisplayFormat.FormatType = FormatType.DateTime;
			colCreatedOn.DisplayFormat.FormatString = "MM/dd/yyyy HH:mm:ss";
			view.Columns.Add(colCreatedOn);

			GridColumn colCreatedBy = new GridColumn();
			colCreatedBy.Caption = "CreatedBy";
			colCreatedBy.FieldName = ACInputSchema.CreatedBy;
			colCreatedBy.VisibleIndex = -1;
			colCreatedBy.OptionsColumn.ShowInCustomizationForm = false;
			view.Columns.Add(colCreatedBy);

			GridColumn colModifiedOn = new GridColumn();
			colModifiedOn.Caption = "ModifiedOn";
			colModifiedOn.FieldName = ACInputSchema.ModifiedOn;
			colModifiedOn.VisibleIndex = -1;
			colModifiedOn.OptionsColumn.ShowInCustomizationForm = false;
			colModifiedOn.DisplayFormat.FormatType = FormatType.DateTime;
			colModifiedOn.DisplayFormat.FormatString = "MM/dd/yyyy HH:mm:ss";
			view.Columns.Add(colModifiedOn);

			GridColumn colModifiedBy = new GridColumn();
			colModifiedBy.Caption = "ModifiedBy";
			colModifiedBy.FieldName = ACInputSchema.ModifiedBy;
			colModifiedBy.VisibleIndex = -1;
			colModifiedBy.OptionsColumn.ShowInCustomizationForm = false;
			view.Columns.Add(colModifiedBy);

			GridColumn colAlwaysToMAS = new GridColumn();
			colAlwaysToMAS.Caption = "AlwaysToMAS";
			colAlwaysToMAS.FieldName = ACInputSchema.AlwaysToMAS;
			colAlwaysToMAS.VisibleIndex = view.Columns.Count;
			view.Columns.Add(colAlwaysToMAS);

			GridColumn colPanelZoneID = new GridColumn();
			colPanelZoneID.Caption = "PanelZoneID";
			colPanelZoneID.FieldName = ACInputSchema.PanelZoneID;
			colPanelZoneID.VisibleIndex = view.Columns.Count;
			colPanelZoneID.DisplayFormat.FormatType = FormatType.Numeric;
			colPanelZoneID.DisplayFormat.FormatString = "f0";
			view.Columns.Add(colPanelZoneID);

			GridColumn colLocked = new GridColumn();
			colLocked.Caption = "Locked";
			colLocked.FieldName = ACInputSchema.Locked;
			colLocked.VisibleIndex = view.Columns.Count;
			view.Columns.Add(colLocked);

			GridColumn colUnitID = new GridColumn();
			colUnitID.Caption = "UnitID";
			colUnitID.FieldName = ACInputSchema.UnitID;
			colUnitID.OptionsColumn.AllowEdit = false;
			colUnitID.OptionsColumn.AllowFocus = false;
			colUnitID.VisibleIndex = view.Columns.Count;
			colUnitID.DisplayFormat.FormatType = FormatType.Numeric;
			colUnitID.DisplayFormat.FormatString = "f0";
			view.Columns.Add(colUnitID);

			GridColumn colAddress1 = new GridColumn();
			colAddress1.Caption = "Address1";
			colAddress1.FieldName = ACInputSchema.Address1;
			colAddress1.OptionsColumn.AllowEdit = false;
			colAddress1.OptionsColumn.AllowFocus = false;
			colAddress1.VisibleIndex = view.Columns.Count;
			view.Columns.Add(colAddress1);

			GridColumn colBuildingID = new GridColumn();
			colBuildingID.Caption = "BuildingID";
			colBuildingID.FieldName = ACInputSchema.BuildingID;
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
			ACInputCollection list = view.DataSource as ACInputCollection;
			if (list == null)
				return;

			ACInput entity = view.GetRow(view.FocusedRowHandle) as ACInput;
			if (entity == null)
				return;

			FormDetailACInput dlg = new FormDetailACInput(base.UserId, entity.Clone() as ACInput);
			dlg.ShowDialog();
		}

		protected override void NavigatorAppendClick(GridView view, NavigatorButtonClickEventArgs e)
		{
			e.Handled = true;
			ACInputCollection list = view.DataSource as ACInputCollection;
			if (list == null)
				return;

			ACInput entity = new ACInput();
			if (this.ACPanel != null)
			{
				entity.CopyParent(this.ACPanel);
			}

			FormDetailACInput dlg = new FormDetailACInput(base.UserId, entity);
			dlg.ShowDialog();
		}
	}
}
