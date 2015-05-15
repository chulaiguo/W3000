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
	public partial class FormDetailACInterval : FormDetailEditorBase
	{
		private GridACIntvalHolidayMapDecorator _decorateACIntvalHolidayMap = null;
		private GridACTimecodeIntervalMapDecorator _decorateACTimecodeIntervalMap = null;

		public FormDetailACInterval()
		{
			InitializeComponent();
		}

		public FormDetailACInterval(string userid, ACInterval entity)
			: base(userid, entity)
		{
			InitializeComponent();
		}

		protected override void InitializeDecorator()
		{
			this._decorateACIntvalHolidayMap = new GridACIntvalHolidayMapDecorator(base.UserId, this.grdACIntvalHolidayMap);
			this._decorateACIntvalHolidayMap.Initialize();

			this._decorateACTimecodeIntervalMap = new GridACTimecodeIntervalMapDecorator(base.UserId, this.grdACTimecodeIntervalMap);
			this._decorateACTimecodeIntervalMap.Initialize();

		}

		private ACInterval ACInterval
		{
			get{ return base.Entity as ACInterval; }
		}

		protected override void DataBindingEntity()
		{
			this.txtIVID.BindingData(this.ACInterval, ACIntervalSchema.IVID);
			this.txtBegin.BindingData(this.ACInterval, ACIntervalSchema.Begin);
			this.txtEnd.BindingData(this.ACInterval, ACIntervalSchema.End);
			this.chkSun.BindingData(this.ACInterval, ACIntervalSchema.Sun);
			this.chkMon.BindingData(this.ACInterval, ACIntervalSchema.Mon);
			this.chkTue.BindingData(this.ACInterval, ACIntervalSchema.Tue);
			this.chkWed.BindingData(this.ACInterval, ACIntervalSchema.Wed);
			this.chkThu.BindingData(this.ACInterval, ACIntervalSchema.Thu);
			this.chkFri.BindingData(this.ACInterval, ACIntervalSchema.Fri);
			this.chkSat.BindingData(this.ACInterval, ACIntervalSchema.Sat);
			this.chkHol.BindingData(this.ACInterval, ACIntervalSchema.Hol);

			this.txtBDBuilding.Text = this.ACInterval.Address1.ToString();
		}

		private void txtBDBuilding_ButtonClick(object sender, ButtonPressedEventArgs e)
		{
			if (e.Button.Kind == ButtonPredefines.Delete)
			{
				if (this.ACInterval.BDBuildingPK == Guid.Empty)
					return;

				if (DialogResult.Yes != base.ShowQuestion(string.Format("Are you sure you want to clear the {0}?", this.txtBDBuilding.Title)))
					return;

				this.ACInterval.BDBuildingPK = Guid.Empty;
				this.txtBDBuilding.Text = string.Empty;
			}
			else
			{
				FormSelectBDBuilding dlg = new FormSelectBDBuilding(base.UserId);
				dlg.MultiSelect = false;
				if (dlg.ShowDialog() != System.Windows.Forms.DialogResult.OK)
					return;

				if (this.ACInterval.BDBuildingPK == dlg.BDBuilding.BDBuildingPK)
					return;

				this.ACInterval.BDBuilding = dlg.BDBuilding;
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

		private void tabACIntvalHolidayMap_Enter(object sender, System.EventArgs e)
		{
			if (this.tabACIntvalHolidayMap.Tag == null)
			{
				if (this.ACInterval.IsNew)
				{
					this._decorateACIntvalHolidayMap.DataSource = null;
					return;
				}

				this.tabACIntvalHolidayMap.Tag = true;

				if (this.ACInterval.ACIntvalHolidayMapList == null || base.IsRefreshData)
				{
					 this.ACInterval.ACIntvalHolidayMapList = ACIntvalHolidayMap.GetByACInterval(this.ACInterval.ACIntervalPK);
				}

				this._decorateACIntvalHolidayMap.ACInterval = this.ACInterval;
				this._decorateACIntvalHolidayMap.DataSource = this.ACInterval.ACIntvalHolidayMapList;
			}
		}

		private void tabACTimecodeIntervalMap_Enter(object sender, System.EventArgs e)
		{
			if (this.tabACTimecodeIntervalMap.Tag == null)
			{
				if (this.ACInterval.IsNew)
				{
					this._decorateACTimecodeIntervalMap.DataSource = null;
					return;
				}

				this.tabACTimecodeIntervalMap.Tag = true;

				if (this.ACInterval.ACTimecodeIntervalMapList == null || base.IsRefreshData)
				{
					 this.ACInterval.ACTimecodeIntervalMapList = ACTimecodeIntervalMap.GetByACInterval(this.ACInterval.ACIntervalPK);
				}

				this._decorateACTimecodeIntervalMap.ACInterval = this.ACInterval;
				this._decorateACTimecodeIntervalMap.DataSource = this.ACInterval.ACTimecodeIntervalMapList;
			}
		}

	}
}
