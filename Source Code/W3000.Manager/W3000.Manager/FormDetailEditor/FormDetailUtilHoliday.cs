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
	public partial class FormDetailUtilHoliday : FormDetailEditorBase
	{
		private GridACIntvalHolidayMapDecorator _decorateACIntvalHolidayMap = null;
		private GridACPanelHolidayMapDecorator _decorateACPanelHolidayMap = null;
		private GridBDBuildingHolidayMapDecorator _decorateBDBuildingHolidayMap = null;
		private GridBDTenantHolidayMapDecorator _decorateBDTenantHolidayMap = null;

		public FormDetailUtilHoliday()
		{
			InitializeComponent();
		}

		public FormDetailUtilHoliday(string userid, UtilHoliday entity)
			: base(userid, entity)
		{
			InitializeComponent();
		}

		protected override void InitializeDecorator()
		{
			this._decorateACIntvalHolidayMap = new GridACIntvalHolidayMapDecorator(base.UserId, this.grdACIntvalHolidayMap);
			this._decorateACIntvalHolidayMap.Initialize();

			this._decorateACPanelHolidayMap = new GridACPanelHolidayMapDecorator(base.UserId, this.grdACPanelHolidayMap);
			this._decorateACPanelHolidayMap.Initialize();

			this._decorateBDBuildingHolidayMap = new GridBDBuildingHolidayMapDecorator(base.UserId, this.grdBDBuildingHolidayMap);
			this._decorateBDBuildingHolidayMap.Initialize();

			this._decorateBDTenantHolidayMap = new GridBDTenantHolidayMapDecorator(base.UserId, this.grdBDTenantHolidayMap);
			this._decorateBDTenantHolidayMap.Initialize();

		}

		private UtilHoliday UtilHoliday
		{
			get{ return base.Entity as UtilHoliday; }
		}

		protected override void DataBindingEntity()
		{
			this.txtCountryID.BindingData(this.UtilHoliday, UtilHolidaySchema.CountryID);
			this.txtHoliday.BindingData(this.UtilHoliday, UtilHolidaySchema.Holiday);
			this.dateDate.BindingData(this.UtilHoliday, UtilHolidaySchema.Date);
			this.chkMajor.BindingData(this.UtilHoliday, UtilHolidaySchema.Major);
			this.chkFederal.BindingData(this.UtilHoliday, UtilHolidaySchema.Federal);
			this.chkDefault.BindingData(this.UtilHoliday, UtilHolidaySchema.Default);
			this.txtActionID.BindingData(this.UtilHoliday, UtilHolidaySchema.ActionID);

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

		private void tabACIntvalHolidayMap_Enter(object sender, System.EventArgs e)
		{
			if (this.tabACIntvalHolidayMap.Tag == null)
			{
				if (this.UtilHoliday.IsNew)
				{
					this._decorateACIntvalHolidayMap.DataSource = null;
					return;
				}

				this.tabACIntvalHolidayMap.Tag = true;

				if (this.UtilHoliday.ACIntvalHolidayMapList == null || base.IsRefreshData)
				{
					 this.UtilHoliday.ACIntvalHolidayMapList = ACIntvalHolidayMap.GetByUtilHoliday(this.UtilHoliday.UtilHolidayPK);
				}

				this._decorateACIntvalHolidayMap.UtilHoliday = this.UtilHoliday;
				this._decorateACIntvalHolidayMap.DataSource = this.UtilHoliday.ACIntvalHolidayMapList;
			}
		}

		private void tabACPanelHolidayMap_Enter(object sender, System.EventArgs e)
		{
			if (this.tabACPanelHolidayMap.Tag == null)
			{
				if (this.UtilHoliday.IsNew)
				{
					this._decorateACPanelHolidayMap.DataSource = null;
					return;
				}

				this.tabACPanelHolidayMap.Tag = true;

				if (this.UtilHoliday.ACPanelHolidayMapList == null || base.IsRefreshData)
				{
					 this.UtilHoliday.ACPanelHolidayMapList = ACPanelHolidayMap.GetByUtilHoliday(this.UtilHoliday.UtilHolidayPK);
				}

				this._decorateACPanelHolidayMap.UtilHoliday = this.UtilHoliday;
				this._decorateACPanelHolidayMap.DataSource = this.UtilHoliday.ACPanelHolidayMapList;
			}
		}

		private void tabBDBuildingHolidayMap_Enter(object sender, System.EventArgs e)
		{
			if (this.tabBDBuildingHolidayMap.Tag == null)
			{
				if (this.UtilHoliday.IsNew)
				{
					this._decorateBDBuildingHolidayMap.DataSource = null;
					return;
				}

				this.tabBDBuildingHolidayMap.Tag = true;

				if (this.UtilHoliday.BDBuildingHolidayMapList == null || base.IsRefreshData)
				{
					 this.UtilHoliday.BDBuildingHolidayMapList = BDBuildingHolidayMap.GetByUtilHoliday(this.UtilHoliday.UtilHolidayPK);
				}

				this._decorateBDBuildingHolidayMap.UtilHoliday = this.UtilHoliday;
				this._decorateBDBuildingHolidayMap.DataSource = this.UtilHoliday.BDBuildingHolidayMapList;
			}
		}

		private void tabBDTenantHolidayMap_Enter(object sender, System.EventArgs e)
		{
			if (this.tabBDTenantHolidayMap.Tag == null)
			{
				if (this.UtilHoliday.IsNew)
				{
					this._decorateBDTenantHolidayMap.DataSource = null;
					return;
				}

				this.tabBDTenantHolidayMap.Tag = true;

				if (this.UtilHoliday.BDTenantHolidayMapList == null || base.IsRefreshData)
				{
					 this.UtilHoliday.BDTenantHolidayMapList = BDTenantHolidayMap.GetByUtilHoliday(this.UtilHoliday.UtilHolidayPK);
				}

				this._decorateBDTenantHolidayMap.UtilHoliday = this.UtilHoliday;
				this._decorateBDTenantHolidayMap.DataSource = this.UtilHoliday.BDTenantHolidayMapList;
			}
		}

	}
}
