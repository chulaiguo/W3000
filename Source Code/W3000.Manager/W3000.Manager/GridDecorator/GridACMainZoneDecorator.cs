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
	public class GridACMainZoneDecorator : GridControlDecorator
	{
		private ACPanel _aCPanel = null;

		public GridACMainZoneDecorator(string userId, GridControl gridControl)
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
			GridColumn colMainZoneID = new GridColumn();
			colMainZoneID.Caption = "MainZoneID";
			colMainZoneID.FieldName = ACMainZoneSchema.MainZoneID;
			colMainZoneID.VisibleIndex = view.Columns.Count;
			colMainZoneID.DisplayFormat.FormatType = FormatType.Numeric;
			colMainZoneID.DisplayFormat.FormatString = "f0";
			view.Columns.Add(colMainZoneID);

			GridColumn colMainZoneTypeID = new GridColumn();
			colMainZoneTypeID.Caption = "MainZoneTypeID";
			colMainZoneTypeID.FieldName = ACMainZoneSchema.MainZoneTypeID;
			colMainZoneTypeID.VisibleIndex = view.Columns.Count;
			colMainZoneTypeID.DisplayFormat.FormatType = FormatType.Numeric;
			colMainZoneTypeID.DisplayFormat.FormatString = "f0";
			view.Columns.Add(colMainZoneTypeID);

			GridColumn colDescription = new GridColumn();
			colDescription.Caption = "Description";
			colDescription.FieldName = ACMainZoneSchema.Description;
			colDescription.VisibleIndex = view.Columns.Count;
			view.Columns.Add(colDescription);

			GridColumn colReaderName = new GridColumn();
			colReaderName.Caption = "ReaderName";
			colReaderName.FieldName = ACMainZoneSchema.ReaderName;
			colReaderName.VisibleIndex = view.Columns.Count;
			view.Columns.Add(colReaderName);

			GridColumn colReaderTypeID = new GridColumn();
			colReaderTypeID.Caption = "ReaderTypeID";
			colReaderTypeID.FieldName = ACMainZoneSchema.ReaderTypeID;
			colReaderTypeID.VisibleIndex = view.Columns.Count;
			colReaderTypeID.DisplayFormat.FormatType = FormatType.Numeric;
			colReaderTypeID.DisplayFormat.FormatString = "f0";
			view.Columns.Add(colReaderTypeID);

			GridColumn colReverseColor = new GridColumn();
			colReverseColor.Caption = "ReverseColor";
			colReverseColor.FieldName = ACMainZoneSchema.ReverseColor;
			colReverseColor.VisibleIndex = view.Columns.Count;
			view.Columns.Add(colReverseColor);

			GridColumn colOutputGroup = new GridColumn();
			colOutputGroup.Caption = "OutputGroup";
			colOutputGroup.FieldName = ACMainZoneSchema.OutputGroup;
			colOutputGroup.VisibleIndex = view.Columns.Count;
			colOutputGroup.DisplayFormat.FormatType = FormatType.Numeric;
			colOutputGroup.DisplayFormat.FormatString = "f0";
			view.Columns.Add(colOutputGroup);

			GridColumn colNeedPin = new GridColumn();
			colNeedPin.Caption = "NeedPin";
			colNeedPin.FieldName = ACMainZoneSchema.NeedPin;
			colNeedPin.VisibleIndex = view.Columns.Count;
			view.Columns.Add(colNeedPin);

			GridColumn colAntiPassback = new GridColumn();
			colAntiPassback.Caption = "AntiPassback";
			colAntiPassback.FieldName = ACMainZoneSchema.AntiPassback;
			colAntiPassback.VisibleIndex = view.Columns.Count;
			view.Columns.Add(colAntiPassback);

			GridColumn colSoftAntiPassback = new GridColumn();
			colSoftAntiPassback.Caption = "SoftAntiPassback";
			colSoftAntiPassback.FieldName = ACMainZoneSchema.SoftAntiPassback;
			colSoftAntiPassback.VisibleIndex = view.Columns.Count;
			view.Columns.Add(colSoftAntiPassback);

			GridColumn colUnlockTimecode = new GridColumn();
			colUnlockTimecode.Caption = "UnlockTimecode";
			colUnlockTimecode.FieldName = ACMainZoneSchema.UnlockTimecode;
			colUnlockTimecode.VisibleIndex = view.Columns.Count;
			colUnlockTimecode.DisplayFormat.FormatType = FormatType.Numeric;
			colUnlockTimecode.DisplayFormat.FormatString = "f0";
			view.Columns.Add(colUnlockTimecode);

			GridColumn colUnlockOn1stRead = new GridColumn();
			colUnlockOn1stRead.Caption = "UnlockOn1stRead";
			colUnlockOn1stRead.FieldName = ACMainZoneSchema.UnlockOn1stRead;
			colUnlockOn1stRead.VisibleIndex = view.Columns.Count;
			view.Columns.Add(colUnlockOn1stRead);

			GridColumn colRexShuntOnly = new GridColumn();
			colRexShuntOnly.Caption = "RexShuntOnly";
			colRexShuntOnly.FieldName = ACMainZoneSchema.RexShuntOnly;
			colRexShuntOnly.VisibleIndex = view.Columns.Count;
			view.Columns.Add(colRexShuntOnly);

			GridColumn colPulseTime = new GridColumn();
			colPulseTime.Caption = "PulseTime";
			colPulseTime.FieldName = ACMainZoneSchema.PulseTime;
			colPulseTime.VisibleIndex = view.Columns.Count;
			colPulseTime.DisplayFormat.FormatType = FormatType.Numeric;
			colPulseTime.DisplayFormat.FormatString = "f0";
			view.Columns.Add(colPulseTime);

			GridColumn colRelockByTimeout = new GridColumn();
			colRelockByTimeout.Caption = "RelockByTimeout";
			colRelockByTimeout.FieldName = ACMainZoneSchema.RelockByTimeout;
			colRelockByTimeout.VisibleIndex = view.Columns.Count;
			view.Columns.Add(colRelockByTimeout);

			GridColumn colForceAMFormat = new GridColumn();
			colForceAMFormat.Caption = "ForceAMFormat";
			colForceAMFormat.FieldName = ACMainZoneSchema.ForceAMFormat;
			colForceAMFormat.VisibleIndex = view.Columns.Count;
			colForceAMFormat.DisplayFormat.FormatType = FormatType.Numeric;
			colForceAMFormat.DisplayFormat.FormatString = "f0";
			view.Columns.Add(colForceAMFormat);

			GridColumn colPropAMFFormat = new GridColumn();
			colPropAMFFormat.Caption = "PropAMFFormat";
			colPropAMFFormat.FieldName = ACMainZoneSchema.PropAMFFormat;
			colPropAMFFormat.VisibleIndex = view.Columns.Count;
			colPropAMFFormat.DisplayFormat.FormatType = FormatType.Numeric;
			colPropAMFFormat.DisplayFormat.FormatString = "f0";
			view.Columns.Add(colPropAMFFormat);

			GridColumn colDebounce = new GridColumn();
			colDebounce.Caption = "Debounce";
			colDebounce.FieldName = ACMainZoneSchema.Debounce;
			colDebounce.VisibleIndex = view.Columns.Count;
			colDebounce.DisplayFormat.FormatType = FormatType.Numeric;
			colDebounce.DisplayFormat.FormatString = "f0";
			view.Columns.Add(colDebounce);

			GridColumn colAllowOpenTime = new GridColumn();
			colAllowOpenTime.Caption = "AllowOpenTime";
			colAllowOpenTime.FieldName = ACMainZoneSchema.AllowOpenTime;
			colAllowOpenTime.VisibleIndex = view.Columns.Count;
			colAllowOpenTime.DisplayFormat.FormatType = FormatType.Numeric;
			colAllowOpenTime.DisplayFormat.FormatString = "f0";
			view.Columns.Add(colAllowOpenTime);

			GridColumn colNoPreAlarm = new GridColumn();
			colNoPreAlarm.Caption = "NoPreAlarm";
			colNoPreAlarm.FieldName = ACMainZoneSchema.NoPreAlarm;
			colNoPreAlarm.VisibleIndex = view.Columns.Count;
			view.Columns.Add(colNoPreAlarm);

			GridColumn colPostPreAlarm = new GridColumn();
			colPostPreAlarm.Caption = "PostPreAlarm";
			colPostPreAlarm.FieldName = ACMainZoneSchema.PostPreAlarm;
			colPostPreAlarm.VisibleIndex = view.Columns.Count;
			view.Columns.Add(colPostPreAlarm);

			GridColumn colPostDuration = new GridColumn();
			colPostDuration.Caption = "PostDuration";
			colPostDuration.FieldName = ACMainZoneSchema.PostDuration;
			colPostDuration.VisibleIndex = view.Columns.Count;
			colPostDuration.DisplayFormat.FormatType = FormatType.Numeric;
			colPostDuration.DisplayFormat.FormatString = "f0";
			view.Columns.Add(colPostDuration);

			GridColumn colNotes = new GridColumn();
			colNotes.Caption = "Notes";
			colNotes.FieldName = ACMainZoneSchema.Notes;
			colNotes.VisibleIndex = view.Columns.Count;
			view.Columns.Add(colNotes);

			GridColumn colEventNotifyEmail = new GridColumn();
			colEventNotifyEmail.Caption = "EventNotifyEmail";
			colEventNotifyEmail.FieldName = ACMainZoneSchema.EventNotifyEmail;
			colEventNotifyEmail.VisibleIndex = view.Columns.Count;
			view.Columns.Add(colEventNotifyEmail);

			GridColumn colIsPulsed = new GridColumn();
			colIsPulsed.Caption = "IsPulsed";
			colIsPulsed.FieldName = ACMainZoneSchema.IsPulsed;
			colIsPulsed.VisibleIndex = view.Columns.Count;
			view.Columns.Add(colIsPulsed);

			GridColumn colAlwaysToMAS = new GridColumn();
			colAlwaysToMAS.Caption = "AlwaysToMAS";
			colAlwaysToMAS.FieldName = ACMainZoneSchema.AlwaysToMAS;
			colAlwaysToMAS.VisibleIndex = view.Columns.Count;
			view.Columns.Add(colAlwaysToMAS);

			GridColumn colCommentBeforePulse = new GridColumn();
			colCommentBeforePulse.Caption = "CommentBeforePulse";
			colCommentBeforePulse.FieldName = ACMainZoneSchema.CommentBeforePulse;
			colCommentBeforePulse.VisibleIndex = view.Columns.Count;
			view.Columns.Add(colCommentBeforePulse);

			GridColumn colCreatedOn = new GridColumn();
			colCreatedOn.Caption = "CreatedOn";
			colCreatedOn.FieldName = ACMainZoneSchema.CreatedOn;
			colCreatedOn.VisibleIndex = -1;
			colCreatedOn.OptionsColumn.ShowInCustomizationForm = false;
			colCreatedOn.DisplayFormat.FormatType = FormatType.DateTime;
			colCreatedOn.DisplayFormat.FormatString = "MM/dd/yyyy HH:mm:ss";
			view.Columns.Add(colCreatedOn);

			GridColumn colCreatedBy = new GridColumn();
			colCreatedBy.Caption = "CreatedBy";
			colCreatedBy.FieldName = ACMainZoneSchema.CreatedBy;
			colCreatedBy.VisibleIndex = -1;
			colCreatedBy.OptionsColumn.ShowInCustomizationForm = false;
			view.Columns.Add(colCreatedBy);

			GridColumn colModifiedOn = new GridColumn();
			colModifiedOn.Caption = "ModifiedOn";
			colModifiedOn.FieldName = ACMainZoneSchema.ModifiedOn;
			colModifiedOn.VisibleIndex = -1;
			colModifiedOn.OptionsColumn.ShowInCustomizationForm = false;
			colModifiedOn.DisplayFormat.FormatType = FormatType.DateTime;
			colModifiedOn.DisplayFormat.FormatString = "MM/dd/yyyy HH:mm:ss";
			view.Columns.Add(colModifiedOn);

			GridColumn colModifiedBy = new GridColumn();
			colModifiedBy.Caption = "ModifiedBy";
			colModifiedBy.FieldName = ACMainZoneSchema.ModifiedBy;
			colModifiedBy.VisibleIndex = -1;
			colModifiedBy.OptionsColumn.ShowInCustomizationForm = false;
			view.Columns.Add(colModifiedBy);

			GridColumn colDegrade = new GridColumn();
			colDegrade.Caption = "Degrade";
			colDegrade.FieldName = ACMainZoneSchema.Degrade;
			colDegrade.VisibleIndex = view.Columns.Count;
			view.Columns.Add(colDegrade);

			GridColumn colReaderPassMode = new GridColumn();
			colReaderPassMode.Caption = "ReaderPassMode";
			colReaderPassMode.FieldName = ACMainZoneSchema.ReaderPassMode;
			colReaderPassMode.VisibleIndex = view.Columns.Count;
			view.Columns.Add(colReaderPassMode);

			GridColumn colPanelZoneID = new GridColumn();
			colPanelZoneID.Caption = "PanelZoneID";
			colPanelZoneID.FieldName = ACMainZoneSchema.PanelZoneID;
			colPanelZoneID.VisibleIndex = view.Columns.Count;
			colPanelZoneID.DisplayFormat.FormatType = FormatType.Numeric;
			colPanelZoneID.DisplayFormat.FormatString = "f0";
			view.Columns.Add(colPanelZoneID);

			GridColumn colLockTypeID = new GridColumn();
			colLockTypeID.Caption = "LockTypeID";
			colLockTypeID.FieldName = ACMainZoneSchema.LockTypeID;
			colLockTypeID.VisibleIndex = view.Columns.Count;
			colLockTypeID.DisplayFormat.FormatType = FormatType.Numeric;
			colLockTypeID.DisplayFormat.FormatString = "f0";
			view.Columns.Add(colLockTypeID);

			GridColumn colLocked = new GridColumn();
			colLocked.Caption = "Locked";
			colLocked.FieldName = ACMainZoneSchema.Locked;
			colLocked.VisibleIndex = view.Columns.Count;
			view.Columns.Add(colLocked);

			GridColumn colInputGroup = new GridColumn();
			colInputGroup.Caption = "InputGroup";
			colInputGroup.FieldName = ACMainZoneSchema.InputGroup;
			colInputGroup.VisibleIndex = view.Columns.Count;
			colInputGroup.DisplayFormat.FormatType = FormatType.Numeric;
			colInputGroup.DisplayFormat.FormatString = "f0";
			view.Columns.Add(colInputGroup);

			GridColumn colUnlockTempTC = new GridColumn();
			colUnlockTempTC.Caption = "UnlockTempTC";
			colUnlockTempTC.FieldName = ACMainZoneSchema.UnlockTempTC;
			colUnlockTempTC.VisibleIndex = view.Columns.Count;
			colUnlockTempTC.DisplayFormat.FormatType = FormatType.Numeric;
			colUnlockTempTC.DisplayFormat.FormatString = "f0";
			view.Columns.Add(colUnlockTempTC);

			GridColumn colUnlockTempBegin = new GridColumn();
			colUnlockTempBegin.Caption = "UnlockTempBegin";
			colUnlockTempBegin.FieldName = ACMainZoneSchema.UnlockTempBegin;
			colUnlockTempBegin.VisibleIndex = view.Columns.Count;
			colUnlockTempBegin.DisplayFormat.FormatType = FormatType.DateTime;
			colUnlockTempBegin.DisplayFormat.FormatString = "MM/dd/yyyy HH:mm:ss";
			view.Columns.Add(colUnlockTempBegin);

			GridColumn colUnlockTempEnd = new GridColumn();
			colUnlockTempEnd.Caption = "UnlockTempEnd";
			colUnlockTempEnd.FieldName = ACMainZoneSchema.UnlockTempEnd;
			colUnlockTempEnd.VisibleIndex = view.Columns.Count;
			colUnlockTempEnd.DisplayFormat.FormatType = FormatType.DateTime;
			colUnlockTempEnd.DisplayFormat.FormatString = "MM/dd/yyyy HH:mm:ss";
			view.Columns.Add(colUnlockTempEnd);

			GridColumn colUnitID = new GridColumn();
			colUnitID.Caption = "UnitID";
			colUnitID.FieldName = ACMainZoneSchema.UnitID;
			colUnitID.OptionsColumn.AllowEdit = false;
			colUnitID.OptionsColumn.AllowFocus = false;
			colUnitID.VisibleIndex = view.Columns.Count;
			colUnitID.DisplayFormat.FormatType = FormatType.Numeric;
			colUnitID.DisplayFormat.FormatString = "f0";
			view.Columns.Add(colUnitID);

			GridColumn colAddress1 = new GridColumn();
			colAddress1.Caption = "Address1";
			colAddress1.FieldName = ACMainZoneSchema.Address1;
			colAddress1.OptionsColumn.AllowEdit = false;
			colAddress1.OptionsColumn.AllowFocus = false;
			colAddress1.VisibleIndex = view.Columns.Count;
			view.Columns.Add(colAddress1);

			GridColumn colBuildingID = new GridColumn();
			colBuildingID.Caption = "BuildingID";
			colBuildingID.FieldName = ACMainZoneSchema.BuildingID;
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
			ACMainZoneCollection list = view.DataSource as ACMainZoneCollection;
			if (list == null)
				return;

			ACMainZone entity = view.GetRow(view.FocusedRowHandle) as ACMainZone;
			if (entity == null)
				return;

			FormDetailACMainZone dlg = new FormDetailACMainZone(base.UserId, entity.Clone() as ACMainZone);
			dlg.ShowDialog();
		}

		protected override void NavigatorAppendClick(GridView view, NavigatorButtonClickEventArgs e)
		{
			e.Handled = true;
			ACMainZoneCollection list = view.DataSource as ACMainZoneCollection;
			if (list == null)
				return;

			ACMainZone entity = new ACMainZone();
			if (this.ACPanel != null)
			{
				entity.CopyParent(this.ACPanel);
			}

			FormDetailACMainZone dlg = new FormDetailACMainZone(base.UserId, entity);
			dlg.ShowDialog();
		}
	}
}
