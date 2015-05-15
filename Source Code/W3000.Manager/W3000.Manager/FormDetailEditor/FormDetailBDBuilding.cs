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
	public partial class FormDetailBDBuilding : FormDetailEditorBase
	{
		private GridUsrAccountBuildingMapDecorator _decorateUsrAccountBuildingMap = null;
		private GridACPanelDecorator _decorateACPanel = null;
		private GridBDTenantDecorator _decorateBDTenant = null;
		private GridBDBuildingHolidayMapDecorator _decorateBDBuildingHolidayMap = null;
		private GridACIntervalDecorator _decorateACInterval = null;
		private GridACTimecodeDecorator _decorateACTimecode = null;
		private GridACAMFormatDecorator _decorateACAMFormat = null;
		private GridACAccessLevelDecorator _decorateACAccessLevel = null;
		private GridACCardHolderBuildingMapDecorator _decorateACCardHolderBuildingMap = null;

		public FormDetailBDBuilding()
		{
			InitializeComponent();
		}

		public FormDetailBDBuilding(string userid, BDBuilding entity)
			: base(userid, entity)
		{
			InitializeComponent();
		}

		protected override void InitializeDecorator()
		{
			this._decorateUsrAccountBuildingMap = new GridUsrAccountBuildingMapDecorator(base.UserId, this.grdUsrAccountBuildingMap);
			this._decorateUsrAccountBuildingMap.Initialize();

			this._decorateACPanel = new GridACPanelDecorator(base.UserId, this.grdACPanel);
			this._decorateACPanel.Initialize();

			this._decorateBDTenant = new GridBDTenantDecorator(base.UserId, this.grdBDTenant);
			this._decorateBDTenant.Initialize();

			this._decorateBDBuildingHolidayMap = new GridBDBuildingHolidayMapDecorator(base.UserId, this.grdBDBuildingHolidayMap);
			this._decorateBDBuildingHolidayMap.Initialize();

			this._decorateACInterval = new GridACIntervalDecorator(base.UserId, this.grdACInterval);
			this._decorateACInterval.Initialize();

			this._decorateACTimecode = new GridACTimecodeDecorator(base.UserId, this.grdACTimecode);
			this._decorateACTimecode.Initialize();

			this._decorateACAMFormat = new GridACAMFormatDecorator(base.UserId, this.grdACAMFormat);
			this._decorateACAMFormat.Initialize();

			this._decorateACAccessLevel = new GridACAccessLevelDecorator(base.UserId, this.grdACAccessLevel);
			this._decorateACAccessLevel.Initialize();

			this._decorateACCardHolderBuildingMap = new GridACCardHolderBuildingMapDecorator(base.UserId, this.grdACCardHolderBuildingMap);
			this._decorateACCardHolderBuildingMap.Initialize();

		}

		private BDBuilding BDBuilding
		{
			get{ return base.Entity as BDBuilding; }
		}

		protected override void DataBindingEntity()
		{
			this.txtBuildingID.BindingData(this.BDBuilding, BDBuildingSchema.BuildingID);
			this.txtBuildingName.BindingData(this.BDBuilding, BDBuildingSchema.BuildingName);
			this.txtAddress1.BindingData(this.BDBuilding, BDBuildingSchema.Address1);
			this.txtStreetNumb.BindingData(this.BDBuilding, BDBuildingSchema.StreetNumb);
			this.txtStreetName.BindingData(this.BDBuilding, BDBuildingSchema.StreetName);
			this.txtAddress2.BindingData(this.BDBuilding, BDBuildingSchema.Address2);
			this.txtCity.BindingData(this.BDBuilding, BDBuildingSchema.City);
			this.txtState.BindingData(this.BDBuilding, BDBuildingSchema.State);
			this.txtZipcode.BindingData(this.BDBuilding, BDBuildingSchema.Zipcode);
			this.txtCounty.BindingData(this.BDBuilding, BDBuildingSchema.County);
			this.txtTimezoneID.BindingData(this.BDBuilding, BDBuildingSchema.TimezoneID);
			this.chkFederal.BindingData(this.BDBuilding, BDBuildingSchema.Federal);
			this.txtPhone.BindingData(this.BDBuilding, BDBuildingSchema.Phone);
			this.txtFax.BindingData(this.BDBuilding, BDBuildingSchema.Fax);
			this.txtBldgNotes.BindingData(this.BDBuilding, BDBuildingSchema.BldgNotes);
			this.txtCardNotes.BindingData(this.BDBuilding, BDBuildingSchema.CardNotes);
			this.txtElevTrapNotes.BindingData(this.BDBuilding, BDBuildingSchema.ElevTrapNotes);
			this.txtVisitorNotes.BindingData(this.BDBuilding, BDBuildingSchema.VisitorNotes);
			this.txtSystemTypeID.BindingData(this.BDBuilding, BDBuildingSchema.SystemTypeID);
			this.txtCountryID.BindingData(this.BDBuilding, BDBuildingSchema.CountryID);
			this.txtVisitorSiteCode.BindingData(this.BDBuilding, BDBuildingSchema.VisitorSiteCode);
			this.txtWinUITypeID.BindingData(this.BDBuilding, BDBuildingSchema.WinUITypeID);
			this.dateLastExportParkingTag.BindingData(this.BDBuilding, BDBuildingSchema.LastExportParkingTag);
			this.txtAutoIssueNotifyEmail.BindingData(this.BDBuilding, BDBuildingSchema.AutoIssueNotifyEmail);
			this.txtCardKeyMode.BindingData(this.BDBuilding, BDBuildingSchema.CardKeyMode);
			this.txtAccessLevelMode.BindingData(this.BDBuilding, BDBuildingSchema.AccessLevelMode);
			this.chkHotClient.BindingData(this.BDBuilding, BDBuildingSchema.HotClient);
			this.dateHotExpire.BindingData(this.BDBuilding, BDBuildingSchema.HotExpire);

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

		private void tabUsrAccountBuildingMap_Enter(object sender, System.EventArgs e)
		{
			if (this.tabUsrAccountBuildingMap.Tag == null)
			{
				if (this.BDBuilding.IsNew)
				{
					this._decorateUsrAccountBuildingMap.DataSource = null;
					return;
				}

				this.tabUsrAccountBuildingMap.Tag = true;

				if (this.BDBuilding.UsrAccountBuildingMapList == null || base.IsRefreshData)
				{
					 this.BDBuilding.UsrAccountBuildingMapList = UsrAccountBuildingMap.GetByBDBuilding(this.BDBuilding.BDBuildingPK);
				}

				this._decorateUsrAccountBuildingMap.BDBuilding = this.BDBuilding;
				this._decorateUsrAccountBuildingMap.DataSource = this.BDBuilding.UsrAccountBuildingMapList;
			}
		}

		private void tabACPanel_Enter(object sender, System.EventArgs e)
		{
			if (this.tabACPanel.Tag == null)
			{
				if (this.BDBuilding.IsNew)
				{
					this._decorateACPanel.DataSource = null;
					return;
				}

				this.tabACPanel.Tag = true;

				if (this.BDBuilding.ACPanelList == null || base.IsRefreshData)
				{
					 this.BDBuilding.ACPanelList = ACPanel.GetByBDBuilding(this.BDBuilding.BDBuildingPK);
				}

				this._decorateACPanel.BDBuilding = this.BDBuilding;
				this._decorateACPanel.DataSource = this.BDBuilding.ACPanelList;
			}
		}

		private void tabBDTenant_Enter(object sender, System.EventArgs e)
		{
			if (this.tabBDTenant.Tag == null)
			{
				if (this.BDBuilding.IsNew)
				{
					this._decorateBDTenant.DataSource = null;
					return;
				}

				this.tabBDTenant.Tag = true;

				if (this.BDBuilding.BDTenantList == null || base.IsRefreshData)
				{
					 this.BDBuilding.BDTenantList = BDTenant.GetByBDBuilding(this.BDBuilding.BDBuildingPK);
				}

				this._decorateBDTenant.BDBuilding = this.BDBuilding;
				this._decorateBDTenant.DataSource = this.BDBuilding.BDTenantList;
			}
		}

		private void tabBDBuildingHolidayMap_Enter(object sender, System.EventArgs e)
		{
			if (this.tabBDBuildingHolidayMap.Tag == null)
			{
				if (this.BDBuilding.IsNew)
				{
					this._decorateBDBuildingHolidayMap.DataSource = null;
					return;
				}

				this.tabBDBuildingHolidayMap.Tag = true;

				if (this.BDBuilding.BDBuildingHolidayMapList == null || base.IsRefreshData)
				{
					 this.BDBuilding.BDBuildingHolidayMapList = BDBuildingHolidayMap.GetByBDBuilding(this.BDBuilding.BDBuildingPK);
				}

				this._decorateBDBuildingHolidayMap.BDBuilding = this.BDBuilding;
				this._decorateBDBuildingHolidayMap.DataSource = this.BDBuilding.BDBuildingHolidayMapList;
			}
		}

		private void tabACInterval_Enter(object sender, System.EventArgs e)
		{
			if (this.tabACInterval.Tag == null)
			{
				if (this.BDBuilding.IsNew)
				{
					this._decorateACInterval.DataSource = null;
					return;
				}

				this.tabACInterval.Tag = true;

				if (this.BDBuilding.ACIntervalList == null || base.IsRefreshData)
				{
					 this.BDBuilding.ACIntervalList = ACInterval.GetByBDBuilding(this.BDBuilding.BDBuildingPK);
				}

				this._decorateACInterval.BDBuilding = this.BDBuilding;
				this._decorateACInterval.DataSource = this.BDBuilding.ACIntervalList;
			}
		}

		private void tabACTimecode_Enter(object sender, System.EventArgs e)
		{
			if (this.tabACTimecode.Tag == null)
			{
				if (this.BDBuilding.IsNew)
				{
					this._decorateACTimecode.DataSource = null;
					return;
				}

				this.tabACTimecode.Tag = true;

				if (this.BDBuilding.ACTimecodeList == null || base.IsRefreshData)
				{
					 this.BDBuilding.ACTimecodeList = ACTimecode.GetByBDBuilding(this.BDBuilding.BDBuildingPK);
				}

				this._decorateACTimecode.BDBuilding = this.BDBuilding;
				this._decorateACTimecode.DataSource = this.BDBuilding.ACTimecodeList;
			}
		}

		private void tabACAMFormat_Enter(object sender, System.EventArgs e)
		{
			if (this.tabACAMFormat.Tag == null)
			{
				if (this.BDBuilding.IsNew)
				{
					this._decorateACAMFormat.DataSource = null;
					return;
				}

				this.tabACAMFormat.Tag = true;

				if (this.BDBuilding.ACAMFormatList == null || base.IsRefreshData)
				{
					 this.BDBuilding.ACAMFormatList = ACAMFormat.GetByBDBuilding(this.BDBuilding.BDBuildingPK);
				}

				this._decorateACAMFormat.BDBuilding = this.BDBuilding;
				this._decorateACAMFormat.DataSource = this.BDBuilding.ACAMFormatList;
			}
		}

		private void tabACAccessLevel_Enter(object sender, System.EventArgs e)
		{
			if (this.tabACAccessLevel.Tag == null)
			{
				if (this.BDBuilding.IsNew)
				{
					this._decorateACAccessLevel.DataSource = null;
					return;
				}

				this.tabACAccessLevel.Tag = true;

				if (this.BDBuilding.ACAccessLevelList == null || base.IsRefreshData)
				{
					 this.BDBuilding.ACAccessLevelList = ACAccessLevel.GetByBDBuilding(this.BDBuilding.BDBuildingPK);
				}

				this._decorateACAccessLevel.BDBuilding = this.BDBuilding;
				this._decorateACAccessLevel.DataSource = this.BDBuilding.ACAccessLevelList;
			}
		}

		private void tabACCardHolderBuildingMap_Enter(object sender, System.EventArgs e)
		{
			if (this.tabACCardHolderBuildingMap.Tag == null)
			{
				if (this.BDBuilding.IsNew)
				{
					this._decorateACCardHolderBuildingMap.DataSource = null;
					return;
				}

				this.tabACCardHolderBuildingMap.Tag = true;

				if (this.BDBuilding.ACCardHolderBuildingMapList == null || base.IsRefreshData)
				{
					 this.BDBuilding.ACCardHolderBuildingMapList = ACCardHolderBuildingMap.GetByBDBuilding(this.BDBuilding.BDBuildingPK);
				}

				this._decorateACCardHolderBuildingMap.BDBuilding = this.BDBuilding;
				this._decorateACCardHolderBuildingMap.DataSource = this.BDBuilding.ACCardHolderBuildingMapList;
			}
		}

	}
}
