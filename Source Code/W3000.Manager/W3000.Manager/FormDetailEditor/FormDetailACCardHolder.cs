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
	public partial class FormDetailACCardHolder : FormDetailEditorBase
	{
		private GridACCardHolderBuildingMapDecorator _decorateACCardHolderBuildingMap = null;

		public FormDetailACCardHolder()
		{
			InitializeComponent();
		}

		public FormDetailACCardHolder(string userid, ACCardHolder entity)
			: base(userid, entity)
		{
			InitializeComponent();
		}

		protected override void InitializeDecorator()
		{
			this._decorateACCardHolderBuildingMap = new GridACCardHolderBuildingMapDecorator(base.UserId, this.grdACCardHolderBuildingMap);
			this._decorateACCardHolderBuildingMap.Initialize();

		}

		private ACCardHolder ACCardHolder
		{
			get{ return base.Entity as ACCardHolder; }
		}

		protected override void DataBindingEntity()
		{
			this.txtSitecode.BindingData(this.ACCardHolder, ACCardHolderSchema.Sitecode);
			this.txtEmbossed.BindingData(this.ACCardHolder, ACCardHolderSchema.Embossed);
			this.txtEncoded.BindingData(this.ACCardHolder, ACCardHolderSchema.Encoded);
			this.txtCardTypeID.BindingData(this.ACCardHolder, ACCardHolderSchema.CardTypeID);
			this.txtFirstName.BindingData(this.ACCardHolder, ACCardHolderSchema.FirstName);
			this.txtLastName.BindingData(this.ACCardHolder, ACCardHolderSchema.LastName);
			this.dateValidFrom.BindingData(this.ACCardHolder, ACCardHolderSchema.ValidFrom);
			this.dateValidThru.BindingData(this.ACCardHolder, ACCardHolderSchema.ValidThru);
			this.chkFIPS.BindingData(this.ACCardHolder, ACCardHolderSchema.FIPS);
			this.txtPin.BindingData(this.ACCardHolder, ACCardHolderSchema.Pin);
			this.txtNotes.BindingData(this.ACCardHolder, ACCardHolderSchema.Notes);
			this.txtEventNotifyEmail.BindingData(this.ACCardHolder, ACCardHolderSchema.EventNotifyEmail);
			this.chkFireWarden.BindingData(this.ACCardHolder, ACCardHolderSchema.FireWarden);
			this.txtCustInfo1.BindingData(this.ACCardHolder, ACCardHolderSchema.CustInfo1);
			this.txtCustInfo2.BindingData(this.ACCardHolder, ACCardHolderSchema.CustInfo2);
			this.txtCustInfo3.BindingData(this.ACCardHolder, ACCardHolderSchema.CustInfo3);
			this.txtCustInfo4.BindingData(this.ACCardHolder, ACCardHolderSchema.CustInfo4);
			this.txtCustInfo5.BindingData(this.ACCardHolder, ACCardHolderSchema.CustInfo5);
			this.txtCustInfo6.BindingData(this.ACCardHolder, ACCardHolderSchema.CustInfo6);
			this.txtCustInfo7.BindingData(this.ACCardHolder, ACCardHolderSchema.CustInfo7);
			this.txtCustInfo8.BindingData(this.ACCardHolder, ACCardHolderSchema.CustInfo8);

			this.txtBDTenant.Text = this.ACCardHolder.Tenant.ToString();
		}

		private void txtBDTenant_ButtonClick(object sender, ButtonPressedEventArgs e)
		{
			if (e.Button.Kind == ButtonPredefines.Delete)
			{
				if (this.ACCardHolder.BDTenantPK == Guid.Empty)
					return;

				if (DialogResult.Yes != base.ShowQuestion(string.Format("Are you sure you want to clear the {0}?", this.txtBDTenant.Title)))
					return;

				this.ACCardHolder.BDTenantPK = Guid.Empty;
				this.txtBDTenant.Text = string.Empty;
			}
			else
			{
				FormSelectBDTenant dlg = new FormSelectBDTenant(base.UserId);
				dlg.MultiSelect = false;
				if (dlg.ShowDialog() != System.Windows.Forms.DialogResult.OK)
					return;

				if (this.ACCardHolder.BDTenantPK == dlg.BDTenant.BDTenantPK)
					return;

				this.ACCardHolder.BDTenant = dlg.BDTenant;
				this.txtBDTenant.Text = dlg.BDTenant.Tenant.ToString();
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

		private void tabACCardHolderBuildingMap_Enter(object sender, System.EventArgs e)
		{
			if (this.tabACCardHolderBuildingMap.Tag == null)
			{
				if (this.ACCardHolder.IsNew)
				{
					this._decorateACCardHolderBuildingMap.DataSource = null;
					return;
				}

				this.tabACCardHolderBuildingMap.Tag = true;

				if (this.ACCardHolder.ACCardHolderBuildingMapList == null || base.IsRefreshData)
				{
					 this.ACCardHolder.ACCardHolderBuildingMapList = ACCardHolderBuildingMap.GetByACCardHolder(this.ACCardHolder.ACCardHolderPK);
				}

				this._decorateACCardHolderBuildingMap.ACCardHolder = this.ACCardHolder;
				this._decorateACCardHolderBuildingMap.DataSource = this.ACCardHolder.ACCardHolderBuildingMapList;
			}
		}

	}
}
