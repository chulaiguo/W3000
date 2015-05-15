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
	public partial class FormDetailACFunctionCard : FormDetailEditorBase
	{
		private GridACPanelFunctionCardMapDecorator _decorateACPanelFunctionCardMap = null;

		public FormDetailACFunctionCard()
		{
			InitializeComponent();
		}

		public FormDetailACFunctionCard(string userid, ACFunctionCard entity)
			: base(userid, entity)
		{
			InitializeComponent();
		}

		protected override void InitializeDecorator()
		{
			this._decorateACPanelFunctionCardMap = new GridACPanelFunctionCardMapDecorator(base.UserId, this.grdACPanelFunctionCardMap);
			this._decorateACPanelFunctionCardMap.Initialize();

		}

		private ACFunctionCard ACFunctionCard
		{
			get{ return base.Entity as ACFunctionCard; }
		}

		protected override void DataBindingEntity()
		{
			this.txtSitecode.BindingData(this.ACFunctionCard, ACFunctionCardSchema.Sitecode);
			this.txtEmbossed.BindingData(this.ACFunctionCard, ACFunctionCardSchema.Embossed);
			this.txtEncoded.BindingData(this.ACFunctionCard, ACFunctionCardSchema.Encoded);
			this.txtCardTypeID.BindingData(this.ACFunctionCard, ACFunctionCardSchema.CardTypeID);
			this.txtFunctionID.BindingData(this.ACFunctionCard, ACFunctionCardSchema.FunctionID);
			this.txtFirstName.BindingData(this.ACFunctionCard, ACFunctionCardSchema.FirstName);
			this.txtLastName.BindingData(this.ACFunctionCard, ACFunctionCardSchema.LastName);
			this.chkFIPS.BindingData(this.ACFunctionCard, ACFunctionCardSchema.FIPS);
			this.txtPin.BindingData(this.ACFunctionCard, ACFunctionCardSchema.Pin);
			this.dateValidFrom.BindingData(this.ACFunctionCard, ACFunctionCardSchema.ValidFrom);
			this.dateValidThru.BindingData(this.ACFunctionCard, ACFunctionCardSchema.ValidThru);

			this.txtBDTenant.Text = this.ACFunctionCard.Tenant.ToString();
		}

		private void txtBDTenant_ButtonClick(object sender, ButtonPressedEventArgs e)
		{
			if (e.Button.Kind == ButtonPredefines.Delete)
			{
				if (this.ACFunctionCard.BDTenantPK == Guid.Empty)
					return;

				if (DialogResult.Yes != base.ShowQuestion(string.Format("Are you sure you want to clear the {0}?", this.txtBDTenant.Title)))
					return;

				this.ACFunctionCard.BDTenantPK = Guid.Empty;
				this.txtBDTenant.Text = string.Empty;
			}
			else
			{
				FormSelectBDTenant dlg = new FormSelectBDTenant(base.UserId);
				dlg.MultiSelect = false;
				if (dlg.ShowDialog() != System.Windows.Forms.DialogResult.OK)
					return;

				if (this.ACFunctionCard.BDTenantPK == dlg.BDTenant.BDTenantPK)
					return;

				this.ACFunctionCard.BDTenant = dlg.BDTenant;
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

		private void tabACPanelFunctionCardMap_Enter(object sender, System.EventArgs e)
		{
			if (this.tabACPanelFunctionCardMap.Tag == null)
			{
				if (this.ACFunctionCard.IsNew)
				{
					this._decorateACPanelFunctionCardMap.DataSource = null;
					return;
				}

				this.tabACPanelFunctionCardMap.Tag = true;

				if (this.ACFunctionCard.ACPanelFunctionCardMapList == null || base.IsRefreshData)
				{
					 this.ACFunctionCard.ACPanelFunctionCardMapList = ACPanelFunctionCardMap.GetByACFunctionCard(this.ACFunctionCard.ACFunctionCardPK);
				}

				this._decorateACPanelFunctionCardMap.ACFunctionCard = this.ACFunctionCard;
				this._decorateACPanelFunctionCardMap.DataSource = this.ACFunctionCard.ACPanelFunctionCardMapList;
			}
		}

	}
}
