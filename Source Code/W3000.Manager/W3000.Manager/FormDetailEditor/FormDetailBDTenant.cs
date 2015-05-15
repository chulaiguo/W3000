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
	public partial class FormDetailBDTenant : FormDetailEditorBase
	{
		private GridUsrAccountTenantMapDecorator _decorateUsrAccountTenantMap = null;
		private GridUsrAccountDecorator _decorateUsrAccount = null;
		private GridACFunctionCardDecorator _decorateACFunctionCard = null;
		private GridBDTenantHolidayMapDecorator _decorateBDTenantHolidayMap = null;
		private GridACCardHolderDecorator _decorateACCardHolder = null;
		private GridBDVisitorDecorator _decorateBDVisitor = null;

		public FormDetailBDTenant()
		{
			InitializeComponent();
		}

		public FormDetailBDTenant(string userid, BDTenant entity)
			: base(userid, entity)
		{
			InitializeComponent();
		}

		protected override void InitializeDecorator()
		{
			this._decorateUsrAccountTenantMap = new GridUsrAccountTenantMapDecorator(base.UserId, this.grdUsrAccountTenantMap);
			this._decorateUsrAccountTenantMap.Initialize();

			this._decorateUsrAccount = new GridUsrAccountDecorator(base.UserId, this.grdUsrAccount);
			this._decorateUsrAccount.Initialize();

			this._decorateACFunctionCard = new GridACFunctionCardDecorator(base.UserId, this.grdACFunctionCard);
			this._decorateACFunctionCard.Initialize();

			this._decorateBDTenantHolidayMap = new GridBDTenantHolidayMapDecorator(base.UserId, this.grdBDTenantHolidayMap);
			this._decorateBDTenantHolidayMap.Initialize();

			this._decorateACCardHolder = new GridACCardHolderDecorator(base.UserId, this.grdACCardHolder);
			this._decorateACCardHolder.Initialize();

			this._decorateBDVisitor = new GridBDVisitorDecorator(base.UserId, this.grdBDVisitor);
			this._decorateBDVisitor.Initialize();

		}

		private BDTenant BDTenant
		{
			get{ return base.Entity as BDTenant; }
		}

		protected override void DataBindingEntity()
		{
			this.txtTenant.BindingData(this.BDTenant, BDTenantSchema.Tenant);
			this.txtSuite.BindingData(this.BDTenant, BDTenantSchema.Suite);
			this.txtPhone.BindingData(this.BDTenant, BDTenantSchema.Phone);
			this.txtFax.BindingData(this.BDTenant, BDTenantSchema.Fax);
			this.chkBlocked.BindingData(this.BDTenant, BDTenantSchema.Blocked);
			this.chkFederal.BindingData(this.BDTenant, BDTenantSchema.Federal);
			this.txtTentNotes.BindingData(this.BDTenant, BDTenantSchema.TentNotes);
			this.txtCardNotes.BindingData(this.BDTenant, BDTenantSchema.CardNotes);
			this.txtVisitorNotes.BindingData(this.BDTenant, BDTenantSchema.VisitorNotes);
			this.chkIsManagement.BindingData(this.BDTenant, BDTenantSchema.IsManagement);
			this.txtType.BindingData(this.BDTenant, BDTenantSchema.Type);
			this.chkNoRecycleCard.BindingData(this.BDTenant, BDTenantSchema.NoRecycleCard);
			this.txtSystemTypeID.BindingData(this.BDTenant, BDTenantSchema.SystemTypeID);
			this.txtParkingAccount.BindingData(this.BDTenant, BDTenantSchema.ParkingAccount);
			this.txtCustInfo1.BindingData(this.BDTenant, BDTenantSchema.CustInfo1);
			this.txtCustInfo2.BindingData(this.BDTenant, BDTenantSchema.CustInfo2);
			this.txtCustInfo3.BindingData(this.BDTenant, BDTenantSchema.CustInfo3);
			this.txtCustInfo4.BindingData(this.BDTenant, BDTenantSchema.CustInfo4);
			this.txtCustInfo5.BindingData(this.BDTenant, BDTenantSchema.CustInfo5);
			this.txtCustInfo6.BindingData(this.BDTenant, BDTenantSchema.CustInfo6);
			this.txtCustInfo7.BindingData(this.BDTenant, BDTenantSchema.CustInfo7);
			this.txtCustInfo8.BindingData(this.BDTenant, BDTenantSchema.CustInfo8);
			this.chkDelExpiredCard.BindingData(this.BDTenant, BDTenantSchema.DelExpiredCard);
			this.chkHotClient.BindingData(this.BDTenant, BDTenantSchema.HotClient);
			this.dateHotExpire.BindingData(this.BDTenant, BDTenantSchema.HotExpire);
			this.txtEmail.BindingData(this.BDTenant, BDTenantSchema.Email);

			this.txtBDBuilding.Text = this.BDTenant.Address1.ToString();
		}

		private void txtBDBuilding_ButtonClick(object sender, ButtonPressedEventArgs e)
		{
			if (e.Button.Kind == ButtonPredefines.Delete)
			{
				if (this.BDTenant.BDBuildingPK == Guid.Empty)
					return;

				if (DialogResult.Yes != base.ShowQuestion(string.Format("Are you sure you want to clear the {0}?", this.txtBDBuilding.Title)))
					return;

				this.BDTenant.BDBuildingPK = Guid.Empty;
				this.txtBDBuilding.Text = string.Empty;
			}
			else
			{
				FormSelectBDBuilding dlg = new FormSelectBDBuilding(base.UserId);
				dlg.MultiSelect = false;
				if (dlg.ShowDialog() != System.Windows.Forms.DialogResult.OK)
					return;

				if (this.BDTenant.BDBuildingPK == dlg.BDBuilding.BDBuildingPK)
					return;

				this.BDTenant.BDBuilding = dlg.BDBuilding;
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

		private void tabUsrAccountTenantMap_Enter(object sender, System.EventArgs e)
		{
			if (this.tabUsrAccountTenantMap.Tag == null)
			{
				if (this.BDTenant.IsNew)
				{
					this._decorateUsrAccountTenantMap.DataSource = null;
					return;
				}

				this.tabUsrAccountTenantMap.Tag = true;

				if (this.BDTenant.UsrAccountTenantMapList == null || base.IsRefreshData)
				{
					 this.BDTenant.UsrAccountTenantMapList = UsrAccountTenantMap.GetByBDTenant(this.BDTenant.BDTenantPK);
				}

				this._decorateUsrAccountTenantMap.BDTenant = this.BDTenant;
				this._decorateUsrAccountTenantMap.DataSource = this.BDTenant.UsrAccountTenantMapList;
			}
		}

		private void tabUsrAccount_Enter(object sender, System.EventArgs e)
		{
			if (this.tabUsrAccount.Tag == null)
			{
				if (this.BDTenant.IsNew)
				{
					this._decorateUsrAccount.DataSource = null;
					return;
				}

				this.tabUsrAccount.Tag = true;

				if (this.BDTenant.UsrAccountList == null || base.IsRefreshData)
				{
					 this.BDTenant.UsrAccountList = UsrAccount.GetByBDTenant(this.BDTenant.BDTenantPK);
				}

				this._decorateUsrAccount.BDTenant = this.BDTenant;
				this._decorateUsrAccount.DataSource = this.BDTenant.UsrAccountList;
			}
		}

		private void tabACFunctionCard_Enter(object sender, System.EventArgs e)
		{
			if (this.tabACFunctionCard.Tag == null)
			{
				if (this.BDTenant.IsNew)
				{
					this._decorateACFunctionCard.DataSource = null;
					return;
				}

				this.tabACFunctionCard.Tag = true;

				if (this.BDTenant.ACFunctionCardList == null || base.IsRefreshData)
				{
					 this.BDTenant.ACFunctionCardList = ACFunctionCard.GetByBDTenant(this.BDTenant.BDTenantPK);
				}

				this._decorateACFunctionCard.BDTenant = this.BDTenant;
				this._decorateACFunctionCard.DataSource = this.BDTenant.ACFunctionCardList;
			}
		}

		private void tabBDTenantHolidayMap_Enter(object sender, System.EventArgs e)
		{
			if (this.tabBDTenantHolidayMap.Tag == null)
			{
				if (this.BDTenant.IsNew)
				{
					this._decorateBDTenantHolidayMap.DataSource = null;
					return;
				}

				this.tabBDTenantHolidayMap.Tag = true;

				if (this.BDTenant.BDTenantHolidayMapList == null || base.IsRefreshData)
				{
					 this.BDTenant.BDTenantHolidayMapList = BDTenantHolidayMap.GetByBDTenant(this.BDTenant.BDTenantPK);
				}

				this._decorateBDTenantHolidayMap.BDTenant = this.BDTenant;
				this._decorateBDTenantHolidayMap.DataSource = this.BDTenant.BDTenantHolidayMapList;
			}
		}

		private void tabACCardHolder_Enter(object sender, System.EventArgs e)
		{
			if (this.tabACCardHolder.Tag == null)
			{
				if (this.BDTenant.IsNew)
				{
					this._decorateACCardHolder.DataSource = null;
					return;
				}

				this.tabACCardHolder.Tag = true;

				if (this.BDTenant.ACCardHolderList == null || base.IsRefreshData)
				{
					 this.BDTenant.ACCardHolderList = ACCardHolder.GetByBDTenant(this.BDTenant.BDTenantPK);
				}

				this._decorateACCardHolder.BDTenant = this.BDTenant;
				this._decorateACCardHolder.DataSource = this.BDTenant.ACCardHolderList;
			}
		}

		private void tabBDVisitor_Enter(object sender, System.EventArgs e)
		{
			if (this.tabBDVisitor.Tag == null)
			{
				if (this.BDTenant.IsNew)
				{
					this._decorateBDVisitor.DataSource = null;
					return;
				}

				this.tabBDVisitor.Tag = true;

				if (this.BDTenant.BDVisitorList == null || base.IsRefreshData)
				{
					 this.BDTenant.BDVisitorList = BDVisitor.GetByBDTenant(this.BDTenant.BDTenantPK);
				}

				this._decorateBDVisitor.BDTenant = this.BDTenant;
				this._decorateBDVisitor.DataSource = this.BDTenant.BDVisitorList;
			}
		}

	}
}
