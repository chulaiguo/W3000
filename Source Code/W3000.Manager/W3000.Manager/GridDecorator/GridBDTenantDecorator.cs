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
	public class GridBDTenantDecorator : GridControlDecorator
	{
		private BDBuilding _bDBuilding = null;

		public GridBDTenantDecorator(string userId, GridControl gridControl)
			: base(userId, gridControl)
		{
		}

		public BDBuilding BDBuilding
		{
			get { return this._bDBuilding; }
			set { this._bDBuilding = value; }
		}


		protected override void SetDisplayColumns(GridView view)
		{
			GridColumn colTenant = new GridColumn();
			colTenant.Caption = "Tenant";
			colTenant.FieldName = BDTenantSchema.Tenant;
			colTenant.VisibleIndex = view.Columns.Count;
			view.Columns.Add(colTenant);

			GridColumn colSuite = new GridColumn();
			colSuite.Caption = "Suite";
			colSuite.FieldName = BDTenantSchema.Suite;
			colSuite.VisibleIndex = view.Columns.Count;
			view.Columns.Add(colSuite);

			GridColumn colPhone = new GridColumn();
			colPhone.Caption = "Phone";
			colPhone.FieldName = BDTenantSchema.Phone;
			colPhone.VisibleIndex = view.Columns.Count;
			view.Columns.Add(colPhone);

			GridColumn colFax = new GridColumn();
			colFax.Caption = "Fax";
			colFax.FieldName = BDTenantSchema.Fax;
			colFax.VisibleIndex = view.Columns.Count;
			view.Columns.Add(colFax);

			GridColumn colBlocked = new GridColumn();
			colBlocked.Caption = "Blocked";
			colBlocked.FieldName = BDTenantSchema.Blocked;
			colBlocked.VisibleIndex = view.Columns.Count;
			view.Columns.Add(colBlocked);

			GridColumn colFederal = new GridColumn();
			colFederal.Caption = "Federal";
			colFederal.FieldName = BDTenantSchema.Federal;
			colFederal.VisibleIndex = view.Columns.Count;
			view.Columns.Add(colFederal);

			GridColumn colTentNotes = new GridColumn();
			colTentNotes.Caption = "TentNotes";
			colTentNotes.FieldName = BDTenantSchema.TentNotes;
			colTentNotes.VisibleIndex = view.Columns.Count;
			view.Columns.Add(colTentNotes);

			GridColumn colCardNotes = new GridColumn();
			colCardNotes.Caption = "CardNotes";
			colCardNotes.FieldName = BDTenantSchema.CardNotes;
			colCardNotes.VisibleIndex = view.Columns.Count;
			view.Columns.Add(colCardNotes);

			GridColumn colVisitorNotes = new GridColumn();
			colVisitorNotes.Caption = "VisitorNotes";
			colVisitorNotes.FieldName = BDTenantSchema.VisitorNotes;
			colVisitorNotes.VisibleIndex = view.Columns.Count;
			view.Columns.Add(colVisitorNotes);

			GridColumn colIsManagement = new GridColumn();
			colIsManagement.Caption = "IsManagement";
			colIsManagement.FieldName = BDTenantSchema.IsManagement;
			colIsManagement.VisibleIndex = view.Columns.Count;
			view.Columns.Add(colIsManagement);

			GridColumn colType = new GridColumn();
			colType.Caption = "Type";
			colType.FieldName = BDTenantSchema.Type;
			colType.VisibleIndex = view.Columns.Count;
			view.Columns.Add(colType);

			GridColumn colNoRecycleCard = new GridColumn();
			colNoRecycleCard.Caption = "NoRecycleCard";
			colNoRecycleCard.FieldName = BDTenantSchema.NoRecycleCard;
			colNoRecycleCard.VisibleIndex = view.Columns.Count;
			view.Columns.Add(colNoRecycleCard);

			GridColumn colSystemTypeID = new GridColumn();
			colSystemTypeID.Caption = "SystemTypeID";
			colSystemTypeID.FieldName = BDTenantSchema.SystemTypeID;
			colSystemTypeID.VisibleIndex = view.Columns.Count;
			colSystemTypeID.DisplayFormat.FormatType = FormatType.Numeric;
			colSystemTypeID.DisplayFormat.FormatString = "f0";
			view.Columns.Add(colSystemTypeID);

			GridColumn colCreatedOn = new GridColumn();
			colCreatedOn.Caption = "CreatedOn";
			colCreatedOn.FieldName = BDTenantSchema.CreatedOn;
			colCreatedOn.VisibleIndex = -1;
			colCreatedOn.OptionsColumn.ShowInCustomizationForm = false;
			colCreatedOn.DisplayFormat.FormatType = FormatType.DateTime;
			colCreatedOn.DisplayFormat.FormatString = "MM/dd/yyyy HH:mm:ss";
			view.Columns.Add(colCreatedOn);

			GridColumn colCreatedBy = new GridColumn();
			colCreatedBy.Caption = "CreatedBy";
			colCreatedBy.FieldName = BDTenantSchema.CreatedBy;
			colCreatedBy.VisibleIndex = -1;
			colCreatedBy.OptionsColumn.ShowInCustomizationForm = false;
			view.Columns.Add(colCreatedBy);

			GridColumn colModifiedOn = new GridColumn();
			colModifiedOn.Caption = "ModifiedOn";
			colModifiedOn.FieldName = BDTenantSchema.ModifiedOn;
			colModifiedOn.VisibleIndex = -1;
			colModifiedOn.OptionsColumn.ShowInCustomizationForm = false;
			colModifiedOn.DisplayFormat.FormatType = FormatType.DateTime;
			colModifiedOn.DisplayFormat.FormatString = "MM/dd/yyyy HH:mm:ss";
			view.Columns.Add(colModifiedOn);

			GridColumn colModifiedBy = new GridColumn();
			colModifiedBy.Caption = "ModifiedBy";
			colModifiedBy.FieldName = BDTenantSchema.ModifiedBy;
			colModifiedBy.VisibleIndex = -1;
			colModifiedBy.OptionsColumn.ShowInCustomizationForm = false;
			view.Columns.Add(colModifiedBy);

			GridColumn colParkingAccount = new GridColumn();
			colParkingAccount.Caption = "ParkingAccount";
			colParkingAccount.FieldName = BDTenantSchema.ParkingAccount;
			colParkingAccount.VisibleIndex = view.Columns.Count;
			view.Columns.Add(colParkingAccount);

			GridColumn colCustInfo1 = new GridColumn();
			colCustInfo1.Caption = "CustInfo1";
			colCustInfo1.FieldName = BDTenantSchema.CustInfo1;
			colCustInfo1.VisibleIndex = view.Columns.Count;
			view.Columns.Add(colCustInfo1);

			GridColumn colCustInfo2 = new GridColumn();
			colCustInfo2.Caption = "CustInfo2";
			colCustInfo2.FieldName = BDTenantSchema.CustInfo2;
			colCustInfo2.VisibleIndex = view.Columns.Count;
			view.Columns.Add(colCustInfo2);

			GridColumn colCustInfo3 = new GridColumn();
			colCustInfo3.Caption = "CustInfo3";
			colCustInfo3.FieldName = BDTenantSchema.CustInfo3;
			colCustInfo3.VisibleIndex = view.Columns.Count;
			view.Columns.Add(colCustInfo3);

			GridColumn colCustInfo4 = new GridColumn();
			colCustInfo4.Caption = "CustInfo4";
			colCustInfo4.FieldName = BDTenantSchema.CustInfo4;
			colCustInfo4.VisibleIndex = view.Columns.Count;
			view.Columns.Add(colCustInfo4);

			GridColumn colCustInfo5 = new GridColumn();
			colCustInfo5.Caption = "CustInfo5";
			colCustInfo5.FieldName = BDTenantSchema.CustInfo5;
			colCustInfo5.VisibleIndex = view.Columns.Count;
			view.Columns.Add(colCustInfo5);

			GridColumn colCustInfo6 = new GridColumn();
			colCustInfo6.Caption = "CustInfo6";
			colCustInfo6.FieldName = BDTenantSchema.CustInfo6;
			colCustInfo6.VisibleIndex = view.Columns.Count;
			view.Columns.Add(colCustInfo6);

			GridColumn colCustInfo7 = new GridColumn();
			colCustInfo7.Caption = "CustInfo7";
			colCustInfo7.FieldName = BDTenantSchema.CustInfo7;
			colCustInfo7.VisibleIndex = view.Columns.Count;
			view.Columns.Add(colCustInfo7);

			GridColumn colCustInfo8 = new GridColumn();
			colCustInfo8.Caption = "CustInfo8";
			colCustInfo8.FieldName = BDTenantSchema.CustInfo8;
			colCustInfo8.VisibleIndex = view.Columns.Count;
			view.Columns.Add(colCustInfo8);

			GridColumn colDelExpiredCard = new GridColumn();
			colDelExpiredCard.Caption = "DelExpiredCard";
			colDelExpiredCard.FieldName = BDTenantSchema.DelExpiredCard;
			colDelExpiredCard.VisibleIndex = view.Columns.Count;
			view.Columns.Add(colDelExpiredCard);

			GridColumn colHotClient = new GridColumn();
			colHotClient.Caption = "HotClient";
			colHotClient.FieldName = BDTenantSchema.HotClient;
			colHotClient.VisibleIndex = view.Columns.Count;
			view.Columns.Add(colHotClient);

			GridColumn colHotExpire = new GridColumn();
			colHotExpire.Caption = "HotExpire";
			colHotExpire.FieldName = BDTenantSchema.HotExpire;
			colHotExpire.VisibleIndex = view.Columns.Count;
			colHotExpire.DisplayFormat.FormatType = FormatType.DateTime;
			colHotExpire.DisplayFormat.FormatString = "MM/dd/yyyy HH:mm:ss";
			view.Columns.Add(colHotExpire);

			GridColumn colEmail = new GridColumn();
			colEmail.Caption = "Email";
			colEmail.FieldName = BDTenantSchema.Email;
			colEmail.VisibleIndex = view.Columns.Count;
			view.Columns.Add(colEmail);

			GridColumn colAddress1 = new GridColumn();
			colAddress1.Caption = "Address1";
			colAddress1.FieldName = BDTenantSchema.Address1;
			colAddress1.OptionsColumn.AllowEdit = false;
			colAddress1.OptionsColumn.AllowFocus = false;
			colAddress1.VisibleIndex = view.Columns.Count;
			view.Columns.Add(colAddress1);

			GridColumn colBuildingID = new GridColumn();
			colBuildingID.Caption = "BuildingID";
			colBuildingID.FieldName = BDTenantSchema.BuildingID;
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
			BDTenantCollection list = view.DataSource as BDTenantCollection;
			if (list == null)
				return;

			BDTenant entity = view.GetRow(view.FocusedRowHandle) as BDTenant;
			if (entity == null)
				return;

			FormDetailBDTenant dlg = new FormDetailBDTenant(base.UserId, entity.Clone() as BDTenant);
			dlg.ShowDialog();
		}

		protected override void NavigatorAppendClick(GridView view, NavigatorButtonClickEventArgs e)
		{
			e.Handled = true;
			BDTenantCollection list = view.DataSource as BDTenantCollection;
			if (list == null)
				return;

			BDTenant entity = new BDTenant();
			if (this.BDBuilding != null)
			{
				entity.CopyParent(this.BDBuilding);
			}

			FormDetailBDTenant dlg = new FormDetailBDTenant(base.UserId, entity);
			dlg.ShowDialog();
		}
	}
}
