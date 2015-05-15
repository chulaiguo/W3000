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
	public class GridBDBuildingDecorator : GridControlDecorator
	{

		public GridBDBuildingDecorator(string userId, GridControl gridControl)
			: base(userId, gridControl)
		{
		}


		protected override void SetDisplayColumns(GridView view)
		{
			GridColumn colBuildingID = new GridColumn();
			colBuildingID.Caption = "BuildingID";
			colBuildingID.FieldName = BDBuildingSchema.BuildingID;
			colBuildingID.VisibleIndex = view.Columns.Count;
			colBuildingID.DisplayFormat.FormatType = FormatType.Numeric;
			colBuildingID.DisplayFormat.FormatString = "f0";
			view.Columns.Add(colBuildingID);

			GridColumn colBuildingName = new GridColumn();
			colBuildingName.Caption = "BuildingName";
			colBuildingName.FieldName = BDBuildingSchema.BuildingName;
			colBuildingName.VisibleIndex = view.Columns.Count;
			view.Columns.Add(colBuildingName);

			GridColumn colAddress1 = new GridColumn();
			colAddress1.Caption = "Address1";
			colAddress1.FieldName = BDBuildingSchema.Address1;
			colAddress1.VisibleIndex = view.Columns.Count;
			view.Columns.Add(colAddress1);

			GridColumn colStreetNumb = new GridColumn();
			colStreetNumb.Caption = "StreetNumb";
			colStreetNumb.FieldName = BDBuildingSchema.StreetNumb;
			colStreetNumb.VisibleIndex = view.Columns.Count;
			view.Columns.Add(colStreetNumb);

			GridColumn colStreetName = new GridColumn();
			colStreetName.Caption = "StreetName";
			colStreetName.FieldName = BDBuildingSchema.StreetName;
			colStreetName.VisibleIndex = view.Columns.Count;
			view.Columns.Add(colStreetName);

			GridColumn colAddress2 = new GridColumn();
			colAddress2.Caption = "Address2";
			colAddress2.FieldName = BDBuildingSchema.Address2;
			colAddress2.VisibleIndex = view.Columns.Count;
			view.Columns.Add(colAddress2);

			GridColumn colCity = new GridColumn();
			colCity.Caption = "City";
			colCity.FieldName = BDBuildingSchema.City;
			colCity.VisibleIndex = view.Columns.Count;
			view.Columns.Add(colCity);

			GridColumn colState = new GridColumn();
			colState.Caption = "State";
			colState.FieldName = BDBuildingSchema.State;
			colState.VisibleIndex = view.Columns.Count;
			view.Columns.Add(colState);

			GridColumn colZipcode = new GridColumn();
			colZipcode.Caption = "Zipcode";
			colZipcode.FieldName = BDBuildingSchema.Zipcode;
			colZipcode.VisibleIndex = view.Columns.Count;
			view.Columns.Add(colZipcode);

			GridColumn colCounty = new GridColumn();
			colCounty.Caption = "County";
			colCounty.FieldName = BDBuildingSchema.County;
			colCounty.VisibleIndex = view.Columns.Count;
			view.Columns.Add(colCounty);

			GridColumn colTimezoneID = new GridColumn();
			colTimezoneID.Caption = "TimezoneID";
			colTimezoneID.FieldName = BDBuildingSchema.TimezoneID;
			colTimezoneID.VisibleIndex = view.Columns.Count;
			colTimezoneID.DisplayFormat.FormatType = FormatType.Numeric;
			colTimezoneID.DisplayFormat.FormatString = "f0";
			view.Columns.Add(colTimezoneID);

			GridColumn colFederal = new GridColumn();
			colFederal.Caption = "Federal";
			colFederal.FieldName = BDBuildingSchema.Federal;
			colFederal.VisibleIndex = view.Columns.Count;
			view.Columns.Add(colFederal);

			GridColumn colPhone = new GridColumn();
			colPhone.Caption = "Phone";
			colPhone.FieldName = BDBuildingSchema.Phone;
			colPhone.VisibleIndex = view.Columns.Count;
			view.Columns.Add(colPhone);

			GridColumn colFax = new GridColumn();
			colFax.Caption = "Fax";
			colFax.FieldName = BDBuildingSchema.Fax;
			colFax.VisibleIndex = view.Columns.Count;
			view.Columns.Add(colFax);

			GridColumn colBldgNotes = new GridColumn();
			colBldgNotes.Caption = "BldgNotes";
			colBldgNotes.FieldName = BDBuildingSchema.BldgNotes;
			colBldgNotes.VisibleIndex = view.Columns.Count;
			view.Columns.Add(colBldgNotes);

			GridColumn colCardNotes = new GridColumn();
			colCardNotes.Caption = "CardNotes";
			colCardNotes.FieldName = BDBuildingSchema.CardNotes;
			colCardNotes.VisibleIndex = view.Columns.Count;
			view.Columns.Add(colCardNotes);

			GridColumn colElevTrapNotes = new GridColumn();
			colElevTrapNotes.Caption = "ElevTrapNotes";
			colElevTrapNotes.FieldName = BDBuildingSchema.ElevTrapNotes;
			colElevTrapNotes.VisibleIndex = view.Columns.Count;
			view.Columns.Add(colElevTrapNotes);

			GridColumn colVisitorNotes = new GridColumn();
			colVisitorNotes.Caption = "VisitorNotes";
			colVisitorNotes.FieldName = BDBuildingSchema.VisitorNotes;
			colVisitorNotes.VisibleIndex = view.Columns.Count;
			view.Columns.Add(colVisitorNotes);

			GridColumn colSystemTypeID = new GridColumn();
			colSystemTypeID.Caption = "SystemTypeID";
			colSystemTypeID.FieldName = BDBuildingSchema.SystemTypeID;
			colSystemTypeID.VisibleIndex = view.Columns.Count;
			colSystemTypeID.DisplayFormat.FormatType = FormatType.Numeric;
			colSystemTypeID.DisplayFormat.FormatString = "f0";
			view.Columns.Add(colSystemTypeID);

			GridColumn colCountryID = new GridColumn();
			colCountryID.Caption = "CountryID";
			colCountryID.FieldName = BDBuildingSchema.CountryID;
			colCountryID.VisibleIndex = view.Columns.Count;
			colCountryID.DisplayFormat.FormatType = FormatType.Numeric;
			colCountryID.DisplayFormat.FormatString = "f0";
			view.Columns.Add(colCountryID);

			GridColumn colCreatedOn = new GridColumn();
			colCreatedOn.Caption = "CreatedOn";
			colCreatedOn.FieldName = BDBuildingSchema.CreatedOn;
			colCreatedOn.VisibleIndex = -1;
			colCreatedOn.OptionsColumn.ShowInCustomizationForm = false;
			colCreatedOn.DisplayFormat.FormatType = FormatType.DateTime;
			colCreatedOn.DisplayFormat.FormatString = "MM/dd/yyyy HH:mm:ss";
			view.Columns.Add(colCreatedOn);

			GridColumn colCreatedBy = new GridColumn();
			colCreatedBy.Caption = "CreatedBy";
			colCreatedBy.FieldName = BDBuildingSchema.CreatedBy;
			colCreatedBy.VisibleIndex = -1;
			colCreatedBy.OptionsColumn.ShowInCustomizationForm = false;
			view.Columns.Add(colCreatedBy);

			GridColumn colModifiedOn = new GridColumn();
			colModifiedOn.Caption = "ModifiedOn";
			colModifiedOn.FieldName = BDBuildingSchema.ModifiedOn;
			colModifiedOn.VisibleIndex = -1;
			colModifiedOn.OptionsColumn.ShowInCustomizationForm = false;
			colModifiedOn.DisplayFormat.FormatType = FormatType.DateTime;
			colModifiedOn.DisplayFormat.FormatString = "MM/dd/yyyy HH:mm:ss";
			view.Columns.Add(colModifiedOn);

			GridColumn colModifiedBy = new GridColumn();
			colModifiedBy.Caption = "ModifiedBy";
			colModifiedBy.FieldName = BDBuildingSchema.ModifiedBy;
			colModifiedBy.VisibleIndex = -1;
			colModifiedBy.OptionsColumn.ShowInCustomizationForm = false;
			view.Columns.Add(colModifiedBy);

			GridColumn colVisitorSiteCode = new GridColumn();
			colVisitorSiteCode.Caption = "VisitorSiteCode";
			colVisitorSiteCode.FieldName = BDBuildingSchema.VisitorSiteCode;
			colVisitorSiteCode.VisibleIndex = view.Columns.Count;
			colVisitorSiteCode.DisplayFormat.FormatType = FormatType.Numeric;
			colVisitorSiteCode.DisplayFormat.FormatString = "f0";
			view.Columns.Add(colVisitorSiteCode);

			GridColumn colWinUITypeID = new GridColumn();
			colWinUITypeID.Caption = "WinUITypeID";
			colWinUITypeID.FieldName = BDBuildingSchema.WinUITypeID;
			colWinUITypeID.VisibleIndex = view.Columns.Count;
			colWinUITypeID.DisplayFormat.FormatType = FormatType.Numeric;
			colWinUITypeID.DisplayFormat.FormatString = "f0";
			view.Columns.Add(colWinUITypeID);

			GridColumn colLastExportParkingTag = new GridColumn();
			colLastExportParkingTag.Caption = "LastExportParkingTag";
			colLastExportParkingTag.FieldName = BDBuildingSchema.LastExportParkingTag;
			colLastExportParkingTag.VisibleIndex = view.Columns.Count;
			colLastExportParkingTag.DisplayFormat.FormatType = FormatType.DateTime;
			colLastExportParkingTag.DisplayFormat.FormatString = "MM/dd/yyyy HH:mm:ss";
			view.Columns.Add(colLastExportParkingTag);

			GridColumn colAutoIssueNotifyEmail = new GridColumn();
			colAutoIssueNotifyEmail.Caption = "AutoIssueNotifyEmail";
			colAutoIssueNotifyEmail.FieldName = BDBuildingSchema.AutoIssueNotifyEmail;
			colAutoIssueNotifyEmail.VisibleIndex = view.Columns.Count;
			view.Columns.Add(colAutoIssueNotifyEmail);

			GridColumn colCardKeyMode = new GridColumn();
			colCardKeyMode.Caption = "CardKeyMode";
			colCardKeyMode.FieldName = BDBuildingSchema.CardKeyMode;
			colCardKeyMode.VisibleIndex = view.Columns.Count;
			colCardKeyMode.DisplayFormat.FormatType = FormatType.Numeric;
			colCardKeyMode.DisplayFormat.FormatString = "f0";
			view.Columns.Add(colCardKeyMode);

			GridColumn colAccessLevelMode = new GridColumn();
			colAccessLevelMode.Caption = "AccessLevelMode";
			colAccessLevelMode.FieldName = BDBuildingSchema.AccessLevelMode;
			colAccessLevelMode.VisibleIndex = view.Columns.Count;
			view.Columns.Add(colAccessLevelMode);

			GridColumn colHotClient = new GridColumn();
			colHotClient.Caption = "HotClient";
			colHotClient.FieldName = BDBuildingSchema.HotClient;
			colHotClient.VisibleIndex = view.Columns.Count;
			view.Columns.Add(colHotClient);

			GridColumn colHotExpire = new GridColumn();
			colHotExpire.Caption = "HotExpire";
			colHotExpire.FieldName = BDBuildingSchema.HotExpire;
			colHotExpire.VisibleIndex = view.Columns.Count;
			colHotExpire.DisplayFormat.FormatType = FormatType.DateTime;
			colHotExpire.DisplayFormat.FormatString = "MM/dd/yyyy HH:mm:ss";
			view.Columns.Add(colHotExpire);

		}

		protected override void NavigatorEditClick(GridView view, NavigatorButtonClickEventArgs e)
		{
			e.Handled = true;
			BDBuildingCollection list = view.DataSource as BDBuildingCollection;
			if (list == null)
				return;

			BDBuilding entity = view.GetRow(view.FocusedRowHandle) as BDBuilding;
			if (entity == null)
				return;

			FormDetailBDBuilding dlg = new FormDetailBDBuilding(base.UserId, entity.Clone() as BDBuilding);
			dlg.ShowDialog();
		}

		protected override void NavigatorAppendClick(GridView view, NavigatorButtonClickEventArgs e)
		{
			e.Handled = true;
			BDBuildingCollection list = view.DataSource as BDBuildingCollection;
			if (list == null)
				return;

			BDBuilding entity = new BDBuilding();

			FormDetailBDBuilding dlg = new FormDetailBDBuilding(base.UserId, entity);
			dlg.ShowDialog();
		}
	}
}
