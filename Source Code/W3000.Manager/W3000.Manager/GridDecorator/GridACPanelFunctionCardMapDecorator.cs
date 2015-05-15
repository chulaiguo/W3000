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
	public class GridACPanelFunctionCardMapDecorator : GridControlDecorator
	{
		private ACFunctionCard _aCFunctionCard = null;
		private ACPanel _aCPanel = null;

		public GridACPanelFunctionCardMapDecorator(string userId, GridControl gridControl)
			: base(userId, gridControl)
		{
		}

		public ACFunctionCard ACFunctionCard
		{
			get { return this._aCFunctionCard; }
			set { this._aCFunctionCard = value; }
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
			colCreatedOn.FieldName = ACPanelFunctionCardMapSchema.CreatedOn;
			colCreatedOn.VisibleIndex = -1;
			colCreatedOn.OptionsColumn.ShowInCustomizationForm = false;
			colCreatedOn.DisplayFormat.FormatType = FormatType.DateTime;
			colCreatedOn.DisplayFormat.FormatString = "MM/dd/yyyy HH:mm:ss";
			view.Columns.Add(colCreatedOn);

			GridColumn colCreatedBy = new GridColumn();
			colCreatedBy.Caption = "CreatedBy";
			colCreatedBy.FieldName = ACPanelFunctionCardMapSchema.CreatedBy;
			colCreatedBy.VisibleIndex = -1;
			colCreatedBy.OptionsColumn.ShowInCustomizationForm = false;
			view.Columns.Add(colCreatedBy);

			GridColumn colModifiedOn = new GridColumn();
			colModifiedOn.Caption = "ModifiedOn";
			colModifiedOn.FieldName = ACPanelFunctionCardMapSchema.ModifiedOn;
			colModifiedOn.VisibleIndex = -1;
			colModifiedOn.OptionsColumn.ShowInCustomizationForm = false;
			colModifiedOn.DisplayFormat.FormatType = FormatType.DateTime;
			colModifiedOn.DisplayFormat.FormatString = "MM/dd/yyyy HH:mm:ss";
			view.Columns.Add(colModifiedOn);

			GridColumn colModifiedBy = new GridColumn();
			colModifiedBy.Caption = "ModifiedBy";
			colModifiedBy.FieldName = ACPanelFunctionCardMapSchema.ModifiedBy;
			colModifiedBy.VisibleIndex = -1;
			colModifiedBy.OptionsColumn.ShowInCustomizationForm = false;
			view.Columns.Add(colModifiedBy);

			GridColumn colEncoded = new GridColumn();
			colEncoded.Caption = "Encoded";
			colEncoded.FieldName = ACPanelFunctionCardMapSchema.Encoded;
			colEncoded.OptionsColumn.AllowEdit = false;
			colEncoded.OptionsColumn.AllowFocus = false;
			colEncoded.VisibleIndex = view.Columns.Count;
			colEncoded.DisplayFormat.FormatType = FormatType.Numeric;
			colEncoded.DisplayFormat.FormatString = "f0";
			view.Columns.Add(colEncoded);

			GridColumn colEmbossed = new GridColumn();
			colEmbossed.Caption = "Embossed";
			colEmbossed.FieldName = ACPanelFunctionCardMapSchema.Embossed;
			colEmbossed.OptionsColumn.AllowEdit = false;
			colEmbossed.OptionsColumn.AllowFocus = false;
			colEmbossed.VisibleIndex = view.Columns.Count;
			colEmbossed.DisplayFormat.FormatType = FormatType.Numeric;
			colEmbossed.DisplayFormat.FormatString = "f0";
			view.Columns.Add(colEmbossed);

			GridColumn colSitecode = new GridColumn();
			colSitecode.Caption = "Sitecode";
			colSitecode.FieldName = ACPanelFunctionCardMapSchema.Sitecode;
			colSitecode.OptionsColumn.AllowEdit = false;
			colSitecode.OptionsColumn.AllowFocus = false;
			colSitecode.VisibleIndex = view.Columns.Count;
			colSitecode.DisplayFormat.FormatType = FormatType.Numeric;
			colSitecode.DisplayFormat.FormatString = "f0";
			view.Columns.Add(colSitecode);

			GridColumn colUnitID = new GridColumn();
			colUnitID.Caption = "UnitID";
			colUnitID.FieldName = ACPanelFunctionCardMapSchema.UnitID;
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
			ACPanelFunctionCardMapCollection list = view.DataSource as ACPanelFunctionCardMapCollection;
			if (list == null)
				return;

			ACPanelFunctionCardMap entity = view.GetRow(view.FocusedRowHandle) as ACPanelFunctionCardMap;
			if (entity == null)
				return;

			FormDetailACPanelFunctionCardMap dlg = new FormDetailACPanelFunctionCardMap(base.UserId, entity.Clone() as ACPanelFunctionCardMap, false);
			dlg.ShowDialog();
		}

		protected override void NavigatorAppendClick(GridView view, NavigatorButtonClickEventArgs e)
		{
			e.Handled = true;
			ACPanelFunctionCardMapCollection list = view.DataSource as ACPanelFunctionCardMapCollection;
			if (list == null)
				return;

			if (this.ACFunctionCard != null)
			{
				SortedList<Guid, Guid> pkList = new SortedList<Guid, Guid>();
				foreach (ACPanelFunctionCardMap item in list)
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
					ACPanelFunctionCardMap entity = new ACPanelFunctionCardMap();
					entity.CopyParent(item);
					entity.CopyParent(this.ACFunctionCard);
					list.Add(entity);
				}
			}
			else if (this.ACPanel != null)
			{
				SortedList<Guid, Guid> pkList = new SortedList<Guid, Guid>();
				foreach (ACPanelFunctionCardMap item in list)
				{
					if (pkList.ContainsKey(item.ACFunctionCardPK))
						continue;

					pkList.Add(item.ACFunctionCardPK, item.ACFunctionCardPK);
				}

				FormSelectACFunctionCard dlg = new FormSelectACFunctionCard(base.UserId, pkList);
				if (dlg.ShowDialog() != DialogResult.OK)
					return;

				foreach (ACFunctionCard item in dlg.ACFunctionCardList)
				{
					ACPanelFunctionCardMap entity = new ACPanelFunctionCardMap();
					entity.CopyParent(item);
					entity.CopyParent(this.ACPanel);
					list.Add(entity);
				}
			}
		}
	}
}
