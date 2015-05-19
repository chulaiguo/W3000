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
	public class GridACCardHolderBuildingMapDecorator : GridControlDecorator
	{
		private BDBuilding _bDBuilding = null;
		private ACCardHolder _aCCardHolder = null;

		public GridACCardHolderBuildingMapDecorator(string userId, GridControl gridControl)
			: base(userId, gridControl)
		{
		}

		public BDBuilding BDBuilding
		{
			get { return this._bDBuilding; }
			set { this._bDBuilding = value; }
		}

		public ACCardHolder ACCardHolder
		{
			get { return this._aCCardHolder; }
			set { this._aCCardHolder = value; }
		}


		protected override void SetDisplayColumns(GridView view)
		{
			GridColumn colAL1st = new GridColumn();
			colAL1st.Caption = "AL1st";
			colAL1st.FieldName = ACCardHolderBuildingMapSchema.AL1st;
			colAL1st.VisibleIndex = view.Columns.Count;
			colAL1st.DisplayFormat.FormatType = FormatType.Numeric;
			colAL1st.DisplayFormat.FormatString = "f0";
			view.Columns.Add(colAL1st);

			GridColumn colAL2nd = new GridColumn();
			colAL2nd.Caption = "AL2nd";
			colAL2nd.FieldName = ACCardHolderBuildingMapSchema.AL2nd;
			colAL2nd.VisibleIndex = view.Columns.Count;
			colAL2nd.DisplayFormat.FormatType = FormatType.Numeric;
			colAL2nd.DisplayFormat.FormatString = "f0";
			view.Columns.Add(colAL2nd);

			GridColumn colCreatedOn = new GridColumn();
			colCreatedOn.Caption = "CreatedOn";
			colCreatedOn.FieldName = ACCardHolderBuildingMapSchema.CreatedOn;
			colCreatedOn.VisibleIndex = -1;
			colCreatedOn.OptionsColumn.ShowInCustomizationForm = false;
			colCreatedOn.DisplayFormat.FormatType = FormatType.DateTime;
			colCreatedOn.DisplayFormat.FormatString = "MM/dd/yyyy HH:mm:ss";
			view.Columns.Add(colCreatedOn);

			GridColumn colCreatedBy = new GridColumn();
			colCreatedBy.Caption = "CreatedBy";
			colCreatedBy.FieldName = ACCardHolderBuildingMapSchema.CreatedBy;
			colCreatedBy.VisibleIndex = -1;
			colCreatedBy.OptionsColumn.ShowInCustomizationForm = false;
			view.Columns.Add(colCreatedBy);

			GridColumn colModifiedOn = new GridColumn();
			colModifiedOn.Caption = "ModifiedOn";
			colModifiedOn.FieldName = ACCardHolderBuildingMapSchema.ModifiedOn;
			colModifiedOn.VisibleIndex = -1;
			colModifiedOn.OptionsColumn.ShowInCustomizationForm = false;
			colModifiedOn.DisplayFormat.FormatType = FormatType.DateTime;
			colModifiedOn.DisplayFormat.FormatString = "MM/dd/yyyy HH:mm:ss";
			view.Columns.Add(colModifiedOn);

			GridColumn colModifiedBy = new GridColumn();
			colModifiedBy.Caption = "ModifiedBy";
			colModifiedBy.FieldName = ACCardHolderBuildingMapSchema.ModifiedBy;
			colModifiedBy.VisibleIndex = -1;
			colModifiedBy.OptionsColumn.ShowInCustomizationForm = false;
			view.Columns.Add(colModifiedBy);

			GridColumn colAddress1 = new GridColumn();
			colAddress1.Caption = "Address1";
			colAddress1.FieldName = ACCardHolderBuildingMapSchema.Address1;
			colAddress1.OptionsColumn.AllowEdit = false;
			colAddress1.OptionsColumn.AllowFocus = false;
			colAddress1.VisibleIndex = view.Columns.Count;
			view.Columns.Add(colAddress1);

			GridColumn colBuildingID = new GridColumn();
			colBuildingID.Caption = "BuildingID";
			colBuildingID.FieldName = ACCardHolderBuildingMapSchema.BuildingID;
			colBuildingID.OptionsColumn.AllowEdit = false;
			colBuildingID.OptionsColumn.AllowFocus = false;
			colBuildingID.VisibleIndex = view.Columns.Count;
			colBuildingID.DisplayFormat.FormatType = FormatType.Numeric;
			colBuildingID.DisplayFormat.FormatString = "f0";
			view.Columns.Add(colBuildingID);

			GridColumn colLastName = new GridColumn();
			colLastName.Caption = "LastName";
			colLastName.FieldName = ACCardHolderBuildingMapSchema.LastName;
			colLastName.OptionsColumn.AllowEdit = false;
			colLastName.OptionsColumn.AllowFocus = false;
			colLastName.VisibleIndex = view.Columns.Count;
			view.Columns.Add(colLastName);

			GridColumn colFirstName = new GridColumn();
			colFirstName.Caption = "FirstName";
			colFirstName.FieldName = ACCardHolderBuildingMapSchema.FirstName;
			colFirstName.OptionsColumn.AllowEdit = false;
			colFirstName.OptionsColumn.AllowFocus = false;
			colFirstName.VisibleIndex = view.Columns.Count;
			view.Columns.Add(colFirstName);

			GridColumn colCardTypeID = new GridColumn();
			colCardTypeID.Caption = "CardTypeID";
			colCardTypeID.FieldName = ACCardHolderBuildingMapSchema.CardTypeID;
			colCardTypeID.OptionsColumn.AllowEdit = false;
			colCardTypeID.OptionsColumn.AllowFocus = false;
			colCardTypeID.VisibleIndex = view.Columns.Count;
			colCardTypeID.DisplayFormat.FormatType = FormatType.Numeric;
			colCardTypeID.DisplayFormat.FormatString = "f0";
			view.Columns.Add(colCardTypeID);

			GridColumn colEncoded = new GridColumn();
			colEncoded.Caption = "Encoded";
			colEncoded.FieldName = ACCardHolderBuildingMapSchema.Encoded;
			colEncoded.OptionsColumn.AllowEdit = false;
			colEncoded.OptionsColumn.AllowFocus = false;
			colEncoded.VisibleIndex = view.Columns.Count;
			colEncoded.DisplayFormat.FormatType = FormatType.Numeric;
			colEncoded.DisplayFormat.FormatString = "f0";
			view.Columns.Add(colEncoded);

			GridColumn colEmbossed = new GridColumn();
			colEmbossed.Caption = "Embossed";
			colEmbossed.FieldName = ACCardHolderBuildingMapSchema.Embossed;
			colEmbossed.OptionsColumn.AllowEdit = false;
			colEmbossed.OptionsColumn.AllowFocus = false;
			colEmbossed.VisibleIndex = view.Columns.Count;
			colEmbossed.DisplayFormat.FormatType = FormatType.Numeric;
			colEmbossed.DisplayFormat.FormatString = "f0";
			view.Columns.Add(colEmbossed);

			GridColumn colSitecode = new GridColumn();
			colSitecode.Caption = "Sitecode";
			colSitecode.FieldName = ACCardHolderBuildingMapSchema.Sitecode;
			colSitecode.OptionsColumn.AllowEdit = false;
			colSitecode.OptionsColumn.AllowFocus = false;
			colSitecode.VisibleIndex = view.Columns.Count;
			colSitecode.DisplayFormat.FormatType = FormatType.Numeric;
			colSitecode.DisplayFormat.FormatString = "f0";
			view.Columns.Add(colSitecode);

			GridColumn colFullName = new GridColumn();
			colFullName.Caption = "FullName";
			colFullName.FieldName = ACCardHolderBuildingMapSchema.FullName;
			colFullName.OptionsColumn.AllowEdit = false;
			colFullName.OptionsColumn.AllowFocus = false;
			colFullName.VisibleIndex = view.Columns.Count;
			view.Columns.Add(colFullName);

		}

		protected override void NavigatorEditClick(GridView view, NavigatorButtonClickEventArgs e)
		{
			e.Handled = true;
			ACCardHolderBuildingMapCollection list = view.DataSource as ACCardHolderBuildingMapCollection;
			if (list == null)
				return;

			ACCardHolderBuildingMap entity = view.GetRow(view.FocusedRowHandle) as ACCardHolderBuildingMap;
			if (entity == null)
				return;

			FormDetailACCardHolderBuildingMap dlg = new FormDetailACCardHolderBuildingMap(base.UserId, entity.Clone() as ACCardHolderBuildingMap, this.Editable);
			if (dlg.ShowDialog() == DialogResult.OK)
			{
				entity.CopyFrom(dlg.ACCardHolderBuildingMap, true);

				view.CloseEditor();
				view.UpdateCurrentRow();
			}
		}

		protected override void NavigatorAppendClick(GridView view, NavigatorButtonClickEventArgs e)
		{
			e.Handled = true;
			ACCardHolderBuildingMapCollection list = view.DataSource as ACCardHolderBuildingMapCollection;
			if (list == null)
				return;

			if (this.BDBuilding != null)
			{
				SortedList<Guid, Guid> pkList = new SortedList<Guid, Guid>();
				foreach (ACCardHolderBuildingMap item in list)
				{
					if (pkList.ContainsKey(item.ACCardHolderPK))
						continue;

					pkList.Add(item.ACCardHolderPK, item.ACCardHolderPK);
				}

				FormSelectACCardHolder dlg = new FormSelectACCardHolder(base.UserId, pkList);
				if (dlg.ShowDialog() != DialogResult.OK)
					return;

				foreach (ACCardHolder item in dlg.ACCardHolderList)
				{
					ACCardHolderBuildingMap entity = new ACCardHolderBuildingMap();
					entity.CopyParent(item);
					entity.CopyParent(this.BDBuilding);
					list.Add(entity);
				}
			}
			else if (this.ACCardHolder != null)
			{
				SortedList<Guid, Guid> pkList = new SortedList<Guid, Guid>();
				foreach (ACCardHolderBuildingMap item in list)
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
					ACCardHolderBuildingMap entity = new ACCardHolderBuildingMap();
					entity.CopyParent(item);
					entity.CopyParent(this.ACCardHolder);
					list.Add(entity);
				}
			}
		}
	}
}
