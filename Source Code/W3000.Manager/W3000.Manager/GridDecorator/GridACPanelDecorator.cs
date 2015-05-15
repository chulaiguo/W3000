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
	public class GridACPanelDecorator : GridControlDecorator
	{
		private BDBuilding _bDBuilding = null;

		public GridACPanelDecorator(string userId, GridControl gridControl)
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
			GridColumn colUnitID = new GridColumn();
			colUnitID.Caption = "UnitID";
			colUnitID.FieldName = ACPanelSchema.UnitID;
			colUnitID.VisibleIndex = view.Columns.Count;
			colUnitID.DisplayFormat.FormatType = FormatType.Numeric;
			colUnitID.DisplayFormat.FormatString = "f0";
			view.Columns.Add(colUnitID);

			GridColumn colSerialNumber = new GridColumn();
			colSerialNumber.Caption = "SerialNumber";
			colSerialNumber.FieldName = ACPanelSchema.SerialNumber;
			colSerialNumber.VisibleIndex = view.Columns.Count;
			view.Columns.Add(colSerialNumber);

			GridColumn colPanelName = new GridColumn();
			colPanelName.Caption = "PanelName";
			colPanelName.FieldName = ACPanelSchema.PanelName;
			colPanelName.VisibleIndex = view.Columns.Count;
			view.Columns.Add(colPanelName);

			GridColumn colBufferSize = new GridColumn();
			colBufferSize.Caption = "BufferSize";
			colBufferSize.FieldName = ACPanelSchema.BufferSize;
			colBufferSize.VisibleIndex = view.Columns.Count;
			colBufferSize.DisplayFormat.FormatType = FormatType.Numeric;
			colBufferSize.DisplayFormat.FormatString = "f0";
			view.Columns.Add(colBufferSize);

			GridColumn colDialUp = new GridColumn();
			colDialUp.Caption = "DialUp";
			colDialUp.FieldName = ACPanelSchema.DialUp;
			colDialUp.VisibleIndex = view.Columns.Count;
			view.Columns.Add(colDialUp);

			GridColumn colUnitPhone = new GridColumn();
			colUnitPhone.Caption = "UnitPhone";
			colUnitPhone.FieldName = ACPanelSchema.UnitPhone;
			colUnitPhone.VisibleIndex = view.Columns.Count;
			view.Columns.Add(colUnitPhone);

			GridColumn colUnitPhoneCallerID = new GridColumn();
			colUnitPhoneCallerID.Caption = "UnitPhoneCallerID";
			colUnitPhoneCallerID.FieldName = ACPanelSchema.UnitPhoneCallerID;
			colUnitPhoneCallerID.VisibleIndex = view.Columns.Count;
			view.Columns.Add(colUnitPhoneCallerID);

			GridColumn colUnitExt = new GridColumn();
			colUnitExt.Caption = "UnitExt";
			colUnitExt.FieldName = ACPanelSchema.UnitExt;
			colUnitExt.VisibleIndex = view.Columns.Count;
			view.Columns.Add(colUnitExt);

			GridColumn colLongDistance = new GridColumn();
			colLongDistance.Caption = "LongDistance";
			colLongDistance.FieldName = ACPanelSchema.LongDistance;
			colLongDistance.VisibleIndex = view.Columns.Count;
			view.Columns.Add(colLongDistance);

			GridColumn colModemInitString = new GridColumn();
			colModemInitString.Caption = "ModemInitString";
			colModemInitString.FieldName = ACPanelSchema.ModemInitString;
			colModemInitString.VisibleIndex = view.Columns.Count;
			view.Columns.Add(colModemInitString);

			GridColumn colBaudRate = new GridColumn();
			colBaudRate.Caption = "BaudRate";
			colBaudRate.FieldName = ACPanelSchema.BaudRate;
			colBaudRate.VisibleIndex = view.Columns.Count;
			colBaudRate.DisplayFormat.FormatType = FormatType.Numeric;
			colBaudRate.DisplayFormat.FormatString = "f0";
			view.Columns.Add(colBaudRate);

			GridColumn colHistoryPhone = new GridColumn();
			colHistoryPhone.Caption = "HistoryPhone";
			colHistoryPhone.FieldName = ACPanelSchema.HistoryPhone;
			colHistoryPhone.VisibleIndex = view.Columns.Count;
			view.Columns.Add(colHistoryPhone);

			GridColumn colAlarmPhone1 = new GridColumn();
			colAlarmPhone1.Caption = "AlarmPhone1";
			colAlarmPhone1.FieldName = ACPanelSchema.AlarmPhone1;
			colAlarmPhone1.VisibleIndex = view.Columns.Count;
			view.Columns.Add(colAlarmPhone1);

			GridColumn colAlarmPhone2 = new GridColumn();
			colAlarmPhone2.Caption = "AlarmPhone2";
			colAlarmPhone2.FieldName = ACPanelSchema.AlarmPhone2;
			colAlarmPhone2.VisibleIndex = view.Columns.Count;
			view.Columns.Add(colAlarmPhone2);

			GridColumn colDialingPrefixPanel = new GridColumn();
			colDialingPrefixPanel.Caption = "DialingPrefixPanel";
			colDialingPrefixPanel.FieldName = ACPanelSchema.DialingPrefixPanel;
			colDialingPrefixPanel.VisibleIndex = view.Columns.Count;
			view.Columns.Add(colDialingPrefixPanel);

			GridColumn colDialingSuffixPanel = new GridColumn();
			colDialingSuffixPanel.Caption = "DialingSuffixPanel";
			colDialingSuffixPanel.FieldName = ACPanelSchema.DialingSuffixPanel;
			colDialingSuffixPanel.VisibleIndex = view.Columns.Count;
			view.Columns.Add(colDialingSuffixPanel);

			GridColumn colDialOutEnabled = new GridColumn();
			colDialOutEnabled.Caption = "DialOutEnabled";
			colDialOutEnabled.FieldName = ACPanelSchema.DialOutEnabled;
			colDialOutEnabled.VisibleIndex = view.Columns.Count;
			view.Columns.Add(colDialOutEnabled);

			GridColumn colDayLightSaving = new GridColumn();
			colDayLightSaving.Caption = "DayLightSaving";
			colDayLightSaving.FieldName = ACPanelSchema.DayLightSaving;
			colDayLightSaving.VisibleIndex = view.Columns.Count;
			view.Columns.Add(colDayLightSaving);

			GridColumn colOnSiteMonitor = new GridColumn();
			colOnSiteMonitor.Caption = "OnSiteMonitor";
			colOnSiteMonitor.FieldName = ACPanelSchema.OnSiteMonitor;
			colOnSiteMonitor.VisibleIndex = view.Columns.Count;
			view.Columns.Add(colOnSiteMonitor);

			GridColumn colCentralDelay = new GridColumn();
			colCentralDelay.Caption = "CentralDelay";
			colCentralDelay.FieldName = ACPanelSchema.CentralDelay;
			colCentralDelay.VisibleIndex = view.Columns.Count;
			colCentralDelay.DisplayFormat.FormatType = FormatType.Numeric;
			colCentralDelay.DisplayFormat.FormatString = "f0";
			view.Columns.Add(colCentralDelay);

			GridColumn colElevPulse = new GridColumn();
			colElevPulse.Caption = "ElevPulse";
			colElevPulse.FieldName = ACPanelSchema.ElevPulse;
			colElevPulse.VisibleIndex = view.Columns.Count;
			colElevPulse.DisplayFormat.FormatType = FormatType.Numeric;
			colElevPulse.DisplayFormat.FormatString = "f0";
			view.Columns.Add(colElevPulse);

			GridColumn colPanelTypeID = new GridColumn();
			colPanelTypeID.Caption = "PanelTypeID";
			colPanelTypeID.FieldName = ACPanelSchema.PanelTypeID;
			colPanelTypeID.VisibleIndex = view.Columns.Count;
			colPanelTypeID.DisplayFormat.FormatType = FormatType.Numeric;
			colPanelTypeID.DisplayFormat.FormatString = "f0";
			view.Columns.Add(colPanelTypeID);

			GridColumn colUnbufferTC = new GridColumn();
			colUnbufferTC.Caption = "UnbufferTC";
			colUnbufferTC.FieldName = ACPanelSchema.UnbufferTC;
			colUnbufferTC.VisibleIndex = view.Columns.Count;
			colUnbufferTC.DisplayFormat.FormatType = FormatType.Numeric;
			colUnbufferTC.DisplayFormat.FormatString = "f0";
			view.Columns.Add(colUnbufferTC);

			GridColumn colMandatoryUnbufferTC = new GridColumn();
			colMandatoryUnbufferTC.Caption = "MandatoryUnbufferTC";
			colMandatoryUnbufferTC.FieldName = ACPanelSchema.MandatoryUnbufferTC;
			colMandatoryUnbufferTC.VisibleIndex = view.Columns.Count;
			colMandatoryUnbufferTC.DisplayFormat.FormatType = FormatType.Numeric;
			colMandatoryUnbufferTC.DisplayFormat.FormatString = "f0";
			view.Columns.Add(colMandatoryUnbufferTC);

			GridColumn colSwingerCount = new GridColumn();
			colSwingerCount.Caption = "SwingerCount";
			colSwingerCount.FieldName = ACPanelSchema.SwingerCount;
			colSwingerCount.VisibleIndex = view.Columns.Count;
			colSwingerCount.DisplayFormat.FormatType = FormatType.Numeric;
			colSwingerCount.DisplayFormat.FormatString = "f0";
			view.Columns.Add(colSwingerCount);

			GridColumn colSwingerTime = new GridColumn();
			colSwingerTime.Caption = "SwingerTime";
			colSwingerTime.FieldName = ACPanelSchema.SwingerTime;
			colSwingerTime.VisibleIndex = view.Columns.Count;
			colSwingerTime.DisplayFormat.FormatType = FormatType.Numeric;
			colSwingerTime.DisplayFormat.FormatString = "f0";
			view.Columns.Add(colSwingerTime);

			GridColumn colLoopNumb = new GridColumn();
			colLoopNumb.Caption = "LoopNumb";
			colLoopNumb.FieldName = ACPanelSchema.LoopNumb;
			colLoopNumb.VisibleIndex = view.Columns.Count;
			colLoopNumb.DisplayFormat.FormatType = FormatType.Numeric;
			colLoopNumb.DisplayFormat.FormatString = "f0";
			view.Columns.Add(colLoopNumb);

			GridColumn colPortNumb = new GridColumn();
			colPortNumb.Caption = "PortNumb";
			colPortNumb.FieldName = ACPanelSchema.PortNumb;
			colPortNumb.VisibleIndex = view.Columns.Count;
			colPortNumb.DisplayFormat.FormatType = FormatType.Numeric;
			colPortNumb.DisplayFormat.FormatString = "f0";
			view.Columns.Add(colPortNumb);

			GridColumn colNotes = new GridColumn();
			colNotes.Caption = "Notes";
			colNotes.FieldName = ACPanelSchema.Notes;
			colNotes.VisibleIndex = view.Columns.Count;
			view.Columns.Add(colNotes);

			GridColumn colTrouble = new GridColumn();
			colTrouble.Caption = "Trouble";
			colTrouble.FieldName = ACPanelSchema.Trouble;
			colTrouble.VisibleIndex = view.Columns.Count;
			view.Columns.Add(colTrouble);

			GridColumn colNoVersionCheck = new GridColumn();
			colNoVersionCheck.Caption = "NoVersionCheck";
			colNoVersionCheck.FieldName = ACPanelSchema.NoVersionCheck;
			colNoVersionCheck.VisibleIndex = view.Columns.Count;
			view.Columns.Add(colNoVersionCheck);

			GridColumn colCreatedOn = new GridColumn();
			colCreatedOn.Caption = "CreatedOn";
			colCreatedOn.FieldName = ACPanelSchema.CreatedOn;
			colCreatedOn.VisibleIndex = -1;
			colCreatedOn.OptionsColumn.ShowInCustomizationForm = false;
			colCreatedOn.DisplayFormat.FormatType = FormatType.DateTime;
			colCreatedOn.DisplayFormat.FormatString = "MM/dd/yyyy HH:mm:ss";
			view.Columns.Add(colCreatedOn);

			GridColumn colCreatedBy = new GridColumn();
			colCreatedBy.Caption = "CreatedBy";
			colCreatedBy.FieldName = ACPanelSchema.CreatedBy;
			colCreatedBy.VisibleIndex = -1;
			colCreatedBy.OptionsColumn.ShowInCustomizationForm = false;
			view.Columns.Add(colCreatedBy);

			GridColumn colModifiedOn = new GridColumn();
			colModifiedOn.Caption = "ModifiedOn";
			colModifiedOn.FieldName = ACPanelSchema.ModifiedOn;
			colModifiedOn.VisibleIndex = -1;
			colModifiedOn.OptionsColumn.ShowInCustomizationForm = false;
			colModifiedOn.DisplayFormat.FormatType = FormatType.DateTime;
			colModifiedOn.DisplayFormat.FormatString = "MM/dd/yyyy HH:mm:ss";
			view.Columns.Add(colModifiedOn);

			GridColumn colModifiedBy = new GridColumn();
			colModifiedBy.Caption = "ModifiedBy";
			colModifiedBy.FieldName = ACPanelSchema.ModifiedBy;
			colModifiedBy.VisibleIndex = -1;
			colModifiedBy.OptionsColumn.ShowInCustomizationForm = false;
			view.Columns.Add(colModifiedBy);

			GridColumn colDBSyncSeconds = new GridColumn();
			colDBSyncSeconds.Caption = "DBSyncSeconds";
			colDBSyncSeconds.FieldName = ACPanelSchema.DBSyncSeconds;
			colDBSyncSeconds.VisibleIndex = view.Columns.Count;
			colDBSyncSeconds.DisplayFormat.FormatType = FormatType.Numeric;
			colDBSyncSeconds.DisplayFormat.FormatString = "f0";
			view.Columns.Add(colDBSyncSeconds);

			GridColumn colDBSaveMinutes = new GridColumn();
			colDBSaveMinutes.Caption = "DBSaveMinutes";
			colDBSaveMinutes.FieldName = ACPanelSchema.DBSaveMinutes;
			colDBSaveMinutes.VisibleIndex = view.Columns.Count;
			colDBSaveMinutes.DisplayFormat.FormatType = FormatType.Numeric;
			colDBSaveMinutes.DisplayFormat.FormatString = "f0";
			view.Columns.Add(colDBSaveMinutes);

			GridColumn colIsE150 = new GridColumn();
			colIsE150.Caption = "IsE150";
			colIsE150.FieldName = ACPanelSchema.IsE150;
			colIsE150.VisibleIndex = view.Columns.Count;
			view.Columns.Add(colIsE150);

			GridColumn colGroupID = new GridColumn();
			colGroupID.Caption = "GroupID";
			colGroupID.FieldName = ACPanelSchema.GroupID;
			colGroupID.VisibleIndex = view.Columns.Count;
			colGroupID.DisplayFormat.FormatType = FormatType.Numeric;
			colGroupID.DisplayFormat.FormatString = "f0";
			view.Columns.Add(colGroupID);

			GridColumn colNoAutoDownload = new GridColumn();
			colNoAutoDownload.Caption = "NoAutoDownload";
			colNoAutoDownload.FieldName = ACPanelSchema.NoAutoDownload;
			colNoAutoDownload.VisibleIndex = view.Columns.Count;
			view.Columns.Add(colNoAutoDownload);

			GridColumn colNoAutoDownloadStart = new GridColumn();
			colNoAutoDownloadStart.Caption = "NoAutoDownloadStart";
			colNoAutoDownloadStart.FieldName = ACPanelSchema.NoAutoDownloadStart;
			colNoAutoDownloadStart.VisibleIndex = view.Columns.Count;
			colNoAutoDownloadStart.DisplayFormat.FormatType = FormatType.DateTime;
			colNoAutoDownloadStart.DisplayFormat.FormatString = "MM/dd/yyyy HH:mm:ss";
			view.Columns.Add(colNoAutoDownloadStart);

			GridColumn colLocked = new GridColumn();
			colLocked.Caption = "Locked";
			colLocked.FieldName = ACPanelSchema.Locked;
			colLocked.VisibleIndex = view.Columns.Count;
			view.Columns.Add(colLocked);

			GridColumn colInDebug = new GridColumn();
			colInDebug.Caption = "InDebug";
			colInDebug.FieldName = ACPanelSchema.InDebug;
			colInDebug.VisibleIndex = view.Columns.Count;
			view.Columns.Add(colInDebug);

			GridColumn colAddress1 = new GridColumn();
			colAddress1.Caption = "Address1";
			colAddress1.FieldName = ACPanelSchema.Address1;
			colAddress1.OptionsColumn.AllowEdit = false;
			colAddress1.OptionsColumn.AllowFocus = false;
			colAddress1.VisibleIndex = view.Columns.Count;
			view.Columns.Add(colAddress1);

			GridColumn colBuildingID = new GridColumn();
			colBuildingID.Caption = "BuildingID";
			colBuildingID.FieldName = ACPanelSchema.BuildingID;
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
			ACPanelCollection list = view.DataSource as ACPanelCollection;
			if (list == null)
				return;

			ACPanel entity = view.GetRow(view.FocusedRowHandle) as ACPanel;
			if (entity == null)
				return;

			FormDetailACPanel dlg = new FormDetailACPanel(base.UserId, entity.Clone() as ACPanel);
			dlg.ShowDialog();
		}

		protected override void NavigatorAppendClick(GridView view, NavigatorButtonClickEventArgs e)
		{
			e.Handled = true;
			ACPanelCollection list = view.DataSource as ACPanelCollection;
			if (list == null)
				return;

			ACPanel entity = new ACPanel();
			if (this.BDBuilding != null)
			{
				entity.CopyParent(this.BDBuilding);
			}

			FormDetailACPanel dlg = new FormDetailACPanel(base.UserId, entity);
			dlg.ShowDialog();
		}
	}
}
