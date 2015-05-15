using System;
using System.Windows.Forms;
using Cheke.WinCtrl;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using W3000.ViewObj;
using W3000.Schema;
using W3000.Manager.FormSelect;
using W3000.Manager.GridDecorator;

namespace W3000.Manager.FormDetailEditor
{
	public partial class FormDetailACPanel : FormDetailEditorBase
	{
		private GridACInputDecorator _decorateACInput = null;
		private GridACSupervisoryDecorator _decorateACSupervisory = null;
		private GridACPanelHolidayMapDecorator _decorateACPanelHolidayMap = null;
		private GridACMainZoneDecorator _decorateACMainZone = null;
		private GridACPanelFunctionCardMapDecorator _decorateACPanelFunctionCardMap = null;
		private GridACOutputGroupDecorator _decorateACOutputGroup = null;
		private GridACInputGroupDecorator _decorateACInputGroup = null;

		public FormDetailACPanel()
		{
			InitializeComponent();
		}

		public FormDetailACPanel(string userid, ACPanel entity)
			: base(userid, entity)
		{
			InitializeComponent();
		}

		protected override void InitializeDecorator()
		{
			this._decorateACInput = new GridACInputDecorator(base.UserId, this.grdACInput);
			this._decorateACInput.Initialize();

			this._decorateACSupervisory = new GridACSupervisoryDecorator(base.UserId, this.grdACSupervisory);
			this._decorateACSupervisory.Initialize();

			this._decorateACPanelHolidayMap = new GridACPanelHolidayMapDecorator(base.UserId, this.grdACPanelHolidayMap);
			this._decorateACPanelHolidayMap.Initialize();

			this._decorateACMainZone = new GridACMainZoneDecorator(base.UserId, this.grdACMainZone);
			this._decorateACMainZone.Initialize();

			this._decorateACPanelFunctionCardMap = new GridACPanelFunctionCardMapDecorator(base.UserId, this.grdACPanelFunctionCardMap);
			this._decorateACPanelFunctionCardMap.Initialize();

			this._decorateACOutputGroup = new GridACOutputGroupDecorator(base.UserId, this.grdACOutputGroup);
			this._decorateACOutputGroup.Initialize();

			this._decorateACInputGroup = new GridACInputGroupDecorator(base.UserId, this.grdACInputGroup);
			this._decorateACInputGroup.Initialize();

		}

		private ACPanel ACPanel
		{
			get{ return base.Entity as ACPanel; }
		}

		protected override void DataBindingEntity()
		{
			this.txtUnitID.BindingData(this.ACPanel, ACPanelSchema.UnitID);
			this.txtSerialNumber.BindingData(this.ACPanel, ACPanelSchema.SerialNumber);
			this.txtPanelName.BindingData(this.ACPanel, ACPanelSchema.PanelName);
			this.txtBufferSize.BindingData(this.ACPanel, ACPanelSchema.BufferSize);
			this.chkDialUp.BindingData(this.ACPanel, ACPanelSchema.DialUp);
			this.txtUnitPhone.BindingData(this.ACPanel, ACPanelSchema.UnitPhone);
			this.txtUnitPhoneCallerID.BindingData(this.ACPanel, ACPanelSchema.UnitPhoneCallerID);
			this.txtUnitExt.BindingData(this.ACPanel, ACPanelSchema.UnitExt);
			this.chkLongDistance.BindingData(this.ACPanel, ACPanelSchema.LongDistance);
			this.txtModemInitString.BindingData(this.ACPanel, ACPanelSchema.ModemInitString);
			this.txtBaudRate.BindingData(this.ACPanel, ACPanelSchema.BaudRate);
			this.txtHistoryPhone.BindingData(this.ACPanel, ACPanelSchema.HistoryPhone);
			this.txtAlarmPhone1.BindingData(this.ACPanel, ACPanelSchema.AlarmPhone1);
			this.txtAlarmPhone2.BindingData(this.ACPanel, ACPanelSchema.AlarmPhone2);
			this.txtDialingPrefixPanel.BindingData(this.ACPanel, ACPanelSchema.DialingPrefixPanel);
			this.txtDialingSuffixPanel.BindingData(this.ACPanel, ACPanelSchema.DialingSuffixPanel);
			this.chkDialOutEnabled.BindingData(this.ACPanel, ACPanelSchema.DialOutEnabled);
			this.chkDayLightSaving.BindingData(this.ACPanel, ACPanelSchema.DayLightSaving);
			this.chkOnSiteMonitor.BindingData(this.ACPanel, ACPanelSchema.OnSiteMonitor);
			this.txtCentralDelay.BindingData(this.ACPanel, ACPanelSchema.CentralDelay);
			this.txtElevPulse.BindingData(this.ACPanel, ACPanelSchema.ElevPulse);
			this.txtPanelTypeID.BindingData(this.ACPanel, ACPanelSchema.PanelTypeID);
			this.txtUnbufferTC.BindingData(this.ACPanel, ACPanelSchema.UnbufferTC);
			this.txtMandatoryUnbufferTC.BindingData(this.ACPanel, ACPanelSchema.MandatoryUnbufferTC);
			this.txtSwingerCount.BindingData(this.ACPanel, ACPanelSchema.SwingerCount);
			this.txtSwingerTime.BindingData(this.ACPanel, ACPanelSchema.SwingerTime);
			this.txtLoopNumb.BindingData(this.ACPanel, ACPanelSchema.LoopNumb);
			this.txtPortNumb.BindingData(this.ACPanel, ACPanelSchema.PortNumb);
			this.txtNotes.BindingData(this.ACPanel, ACPanelSchema.Notes);
			this.chkTrouble.BindingData(this.ACPanel, ACPanelSchema.Trouble);
			this.chkNoVersionCheck.BindingData(this.ACPanel, ACPanelSchema.NoVersionCheck);
			this.txtDBSyncSeconds.BindingData(this.ACPanel, ACPanelSchema.DBSyncSeconds);
			this.txtDBSaveMinutes.BindingData(this.ACPanel, ACPanelSchema.DBSaveMinutes);
			this.chkIsE150.BindingData(this.ACPanel, ACPanelSchema.IsE150);
			this.txtGroupID.BindingData(this.ACPanel, ACPanelSchema.GroupID);
			this.chkNoAutoDownload.BindingData(this.ACPanel, ACPanelSchema.NoAutoDownload);
			this.dateNoAutoDownloadStart.BindingData(this.ACPanel, ACPanelSchema.NoAutoDownloadStart);
			this.chkLocked.BindingData(this.ACPanel, ACPanelSchema.Locked);
			this.chkInDebug.BindingData(this.ACPanel, ACPanelSchema.InDebug);

			this.txtBDBuilding.Text = this.ACPanel.Address1.ToString();
		}

		private void txtBDBuilding_ButtonClick(object sender, ButtonPressedEventArgs e)
		{
			if (e.Button.Kind == ButtonPredefines.Delete)
			{
				if (this.ACPanel.BDBuildingPK == Guid.Empty)
					return;

				if (DialogResult.Yes != base.ShowQuestion(string.Format("Are you sure you want to clear the {0}?", this.txtBDBuilding.Title)))
					return;

				this.ACPanel.BDBuildingPK = Guid.Empty;
				this.txtBDBuilding.Text = string.Empty;
			}
			else
			{
				FormSelectBDBuilding dlg = new FormSelectBDBuilding(base.UserId);
				dlg.MultiSelect = false;
				if (dlg.ShowDialog() != System.Windows.Forms.DialogResult.OK)
					return;

				if (this.ACPanel.BDBuildingPK == dlg.BDBuilding.BDBuildingPK)
					return;

				this.ACPanel.BDBuilding = dlg.BDBuilding;
				this.txtBDBuilding.Text = dlg.BDBuilding.Address1.ToString();
			}
		}

		private void xtraTabControl1_SelectedPageChanged(object sender, DevExpress.XtraTab.TabPageChangedEventArgs e)
		{
			if (this.xtraTabControl1.SelectedTabPage == this.tabDetail)
			{
				this.ShowNewButton = true;
				this.ShowDeleteButton = true;
			}
			else
			{
				this.ShowNewButton = false;
				this.ShowDeleteButton = false;
			}

			this.xtraTabControl1.SelectedTabPage.Focus();
		}

		private void tabACInput_Enter(object sender, System.EventArgs e)
		{
			if (this.tabACInput.Tag == null)
			{
				if (this.ACPanel.IsNew)
				{
					this._decorateACInput.DataSource = null;
					return;
				}

				this.tabACInput.Tag = true;

				if (this.ACPanel.ACInputList == null || base.IsRefreshData)
				{
					 this.ACPanel.ACInputList = ACInput.GetByACPanel(this.ACPanel.ACPanelPK);
				}

				this._decorateACInput.ACPanel = this.ACPanel;
				this._decorateACInput.DataSource = this.ACPanel.ACInputList;
			}
		}

		private void tabACSupervisory_Enter(object sender, System.EventArgs e)
		{
			if (this.tabACSupervisory.Tag == null)
			{
				if (this.ACPanel.IsNew)
				{
					this._decorateACSupervisory.DataSource = null;
					return;
				}

				this.tabACSupervisory.Tag = true;

				if (this.ACPanel.ACSupervisoryList == null || base.IsRefreshData)
				{
					 this.ACPanel.ACSupervisoryList = ACSupervisory.GetByACPanel(this.ACPanel.ACPanelPK);
				}

				this._decorateACSupervisory.ACPanel = this.ACPanel;
				this._decorateACSupervisory.DataSource = this.ACPanel.ACSupervisoryList;
			}
		}

		private void tabACPanelHolidayMap_Enter(object sender, System.EventArgs e)
		{
			if (this.tabACPanelHolidayMap.Tag == null)
			{
				if (this.ACPanel.IsNew)
				{
					this._decorateACPanelHolidayMap.DataSource = null;
					return;
				}

				this.tabACPanelHolidayMap.Tag = true;

				if (this.ACPanel.ACPanelHolidayMapList == null || base.IsRefreshData)
				{
					 this.ACPanel.ACPanelHolidayMapList = ACPanelHolidayMap.GetByACPanel(this.ACPanel.ACPanelPK);
				}

				this._decorateACPanelHolidayMap.ACPanel = this.ACPanel;
				this._decorateACPanelHolidayMap.DataSource = this.ACPanel.ACPanelHolidayMapList;
			}
		}

		private void tabACMainZone_Enter(object sender, System.EventArgs e)
		{
			if (this.tabACMainZone.Tag == null)
			{
				if (this.ACPanel.IsNew)
				{
					this._decorateACMainZone.DataSource = null;
					return;
				}

				this.tabACMainZone.Tag = true;

				if (this.ACPanel.ACMainZoneList == null || base.IsRefreshData)
				{
					 this.ACPanel.ACMainZoneList = ACMainZone.GetByACPanel(this.ACPanel.ACPanelPK);
				}

				this._decorateACMainZone.ACPanel = this.ACPanel;
				this._decorateACMainZone.DataSource = this.ACPanel.ACMainZoneList;
			}
		}

		private void tabACPanelFunctionCardMap_Enter(object sender, System.EventArgs e)
		{
			if (this.tabACPanelFunctionCardMap.Tag == null)
			{
				if (this.ACPanel.IsNew)
				{
					this._decorateACPanelFunctionCardMap.DataSource = null;
					return;
				}

				this.tabACPanelFunctionCardMap.Tag = true;

				if (this.ACPanel.ACPanelFunctionCardMapList == null || base.IsRefreshData)
				{
					 this.ACPanel.ACPanelFunctionCardMapList = ACPanelFunctionCardMap.GetByACPanel(this.ACPanel.ACPanelPK);
				}

				this._decorateACPanelFunctionCardMap.ACPanel = this.ACPanel;
				this._decorateACPanelFunctionCardMap.DataSource = this.ACPanel.ACPanelFunctionCardMapList;
			}
		}

		private void tabACOutputGroup_Enter(object sender, System.EventArgs e)
		{
			if (this.tabACOutputGroup.Tag == null)
			{
				if (this.ACPanel.IsNew)
				{
					this._decorateACOutputGroup.DataSource = null;
					return;
				}

				this.tabACOutputGroup.Tag = true;

				if (this.ACPanel.ACOutputGroupList == null || base.IsRefreshData)
				{
					 this.ACPanel.ACOutputGroupList = ACOutputGroup.GetByACPanel(this.ACPanel.ACPanelPK);
				}

				this._decorateACOutputGroup.ACPanel = this.ACPanel;
				this._decorateACOutputGroup.DataSource = this.ACPanel.ACOutputGroupList;
			}
		}

		private void tabACInputGroup_Enter(object sender, System.EventArgs e)
		{
			if (this.tabACInputGroup.Tag == null)
			{
				if (this.ACPanel.IsNew)
				{
					this._decorateACInputGroup.DataSource = null;
					return;
				}

				this.tabACInputGroup.Tag = true;

				if (this.ACPanel.ACInputGroupList == null || base.IsRefreshData)
				{
					 this.ACPanel.ACInputGroupList = ACInputGroup.GetByACPanel(this.ACPanel.ACPanelPK);
				}

				this._decorateACInputGroup.ACPanel = this.ACPanel;
				this._decorateACInputGroup.DataSource = this.ACPanel.ACInputGroupList;
			}
		}

	}
}
