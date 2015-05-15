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
	public partial class FormDetailUsrAccount : FormDetailEditorBase
	{
		private GridUsrAccountBuildingMapDecorator _decorateUsrAccountBuildingMap = null;
		private GridUsrAccountBRRuleDecorator _decorateUsrAccountBRRule = null;
		private GridUsrAccountDBRuleDecorator _decorateUsrAccountDBRule = null;
		private GridUsrAccountTenantMapDecorator _decorateUsrAccountTenantMap = null;

		public FormDetailUsrAccount()
		{
			InitializeComponent();
		}

		public FormDetailUsrAccount(string userid, UsrAccount entity)
			: base(userid, entity)
		{
			InitializeComponent();
		}

		protected override void InitializeDecorator()
		{
			this._decorateUsrAccountBuildingMap = new GridUsrAccountBuildingMapDecorator(base.UserId, this.grdUsrAccountBuildingMap);
			this._decorateUsrAccountBuildingMap.Initialize();

			this._decorateUsrAccountBRRule = new GridUsrAccountBRRuleDecorator(base.UserId, this.grdUsrAccountBRRule);
			this._decorateUsrAccountBRRule.Initialize();

			this._decorateUsrAccountDBRule = new GridUsrAccountDBRuleDecorator(base.UserId, this.grdUsrAccountDBRule);
			this._decorateUsrAccountDBRule.Initialize();

			this._decorateUsrAccountTenantMap = new GridUsrAccountTenantMapDecorator(base.UserId, this.grdUsrAccountTenantMap);
			this._decorateUsrAccountTenantMap.Initialize();

		}

		private UsrAccount UsrAccount
		{
			get{ return base.Entity as UsrAccount; }
		}

		protected override void DataBindingEntity()
		{
			this.txtUserID.BindingData(this.UsrAccount, UsrAccountSchema.UserID);
			this.chkIsAdmin.BindingData(this.UsrAccount, UsrAccountSchema.IsAdmin);
			this.chkIsCentral.BindingData(this.UsrAccount, UsrAccountSchema.IsCentral);
			this.txtFirstName.BindingData(this.UsrAccount, UsrAccountSchema.FirstName);
			this.txtLastName.BindingData(this.UsrAccount, UsrAccountSchema.LastName);
			this.datePwdExpireDate.BindingData(this.UsrAccount, UsrAccountSchema.PwdExpireDate);
			this.txtCellPhone.BindingData(this.UsrAccount, UsrAccountSchema.CellPhone);
			this.txtHomePhone.BindingData(this.UsrAccount, UsrAccountSchema.HomePhone);
			this.txtOfficePhone.BindingData(this.UsrAccount, UsrAccountSchema.OfficePhone);
			this.txtEmail.BindingData(this.UsrAccount, UsrAccountSchema.Email);
			this.dateLastLogin.BindingData(this.UsrAccount, UsrAccountSchema.LastLogin);
			this.txtTotalUsage.BindingData(this.UsrAccount, UsrAccountSchema.TotalUsage);
			this.txtStartScreen.BindingData(this.UsrAccount, UsrAccountSchema.StartScreen);
			this.txtPopupExtension.BindingData(this.UsrAccount, UsrAccountSchema.PopupExtension);

			this.txtBDTenant.Text = this.UsrAccount.Tenant.ToString();
			this.txtUsrGroup.Text = this.UsrAccount.UsrGroupName.ToString();
		}

		private void txtBDTenant_ButtonClick(object sender, ButtonPressedEventArgs e)
		{
			if (e.Button.Kind == ButtonPredefines.Delete)
			{
				if (this.UsrAccount.BDTenantPK == Guid.Empty)
					return;

				if (DialogResult.Yes != base.ShowQuestion(string.Format("Are you sure you want to clear the {0}?", this.txtBDTenant.Title)))
					return;

				this.UsrAccount.BDTenantPK = Guid.Empty;
				this.txtBDTenant.Text = string.Empty;
			}
			else
			{
				FormSelectBDTenant dlg = new FormSelectBDTenant(base.UserId);
				dlg.MultiSelect = false;
				if (dlg.ShowDialog() != System.Windows.Forms.DialogResult.OK)
					return;

				if (this.UsrAccount.BDTenantPK == dlg.BDTenant.BDTenantPK)
					return;

				this.UsrAccount.BDTenant = dlg.BDTenant;
				this.txtBDTenant.Text = dlg.BDTenant.Tenant.ToString();
			}
		}

		private void txtUsrGroup_ButtonClick(object sender, ButtonPressedEventArgs e)
		{
			if (e.Button.Kind == ButtonPredefines.Delete)
			{
				if (this.UsrAccount.UsrGroupPK == Guid.Empty)
					return;

				if (DialogResult.Yes != base.ShowQuestion(string.Format("Are you sure you want to clear the {0}?", this.txtUsrGroup.Title)))
					return;

				this.UsrAccount.UsrGroupPK = Guid.Empty;
				this.txtUsrGroup.Text = string.Empty;
			}
			else
			{
				FormSelectUsrGroup dlg = new FormSelectUsrGroup(base.UserId);
				dlg.MultiSelect = false;
				if (dlg.ShowDialog() != System.Windows.Forms.DialogResult.OK)
					return;

				if (this.UsrAccount.UsrGroupPK == dlg.UsrGroup.UsrGroupPK)
					return;

				this.UsrAccount.UsrGroup = dlg.UsrGroup;
				this.txtUsrGroup.Text = dlg.UsrGroup.UsrGroupName.ToString();
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

		private void tabUsrAccountBuildingMap_Enter(object sender, System.EventArgs e)
		{
			if (this.tabUsrAccountBuildingMap.Tag == null)
			{
				if (this.UsrAccount.IsNew)
				{
					this._decorateUsrAccountBuildingMap.DataSource = null;
					return;
				}

				this.tabUsrAccountBuildingMap.Tag = true;

				if (this.UsrAccount.UsrAccountBuildingMapList == null || base.IsRefreshData)
				{
					 this.UsrAccount.UsrAccountBuildingMapList = UsrAccountBuildingMap.GetByUsrAccount(this.UsrAccount.UsrAccountPK);
				}

				this._decorateUsrAccountBuildingMap.UsrAccount = this.UsrAccount;
				this._decorateUsrAccountBuildingMap.DataSource = this.UsrAccount.UsrAccountBuildingMapList;
			}
		}

		private void tabUsrAccountBRRule_Enter(object sender, System.EventArgs e)
		{
			if (this.tabUsrAccountBRRule.Tag == null)
			{
				if (this.UsrAccount.IsNew)
				{
					this._decorateUsrAccountBRRule.DataSource = null;
					return;
				}

				this.tabUsrAccountBRRule.Tag = true;

				if (this.UsrAccount.UsrAccountBRRuleList == null || base.IsRefreshData)
				{
					 this.UsrAccount.UsrAccountBRRuleList = UsrAccountBRRule.GetByUsrAccount(this.UsrAccount.UsrAccountPK);
				}

				this._decorateUsrAccountBRRule.UsrAccount = this.UsrAccount;
				this._decorateUsrAccountBRRule.DataSource = this.UsrAccount.UsrAccountBRRuleList;
			}
		}

		private void tabUsrAccountDBRule_Enter(object sender, System.EventArgs e)
		{
			if (this.tabUsrAccountDBRule.Tag == null)
			{
				if (this.UsrAccount.IsNew)
				{
					this._decorateUsrAccountDBRule.DataSource = null;
					return;
				}

				this.tabUsrAccountDBRule.Tag = true;

				if (this.UsrAccount.UsrAccountDBRuleList == null || base.IsRefreshData)
				{
					 this.UsrAccount.UsrAccountDBRuleList = UsrAccountDBRule.GetByUsrAccount(this.UsrAccount.UsrAccountPK);
				}

				this._decorateUsrAccountDBRule.UsrAccount = this.UsrAccount;
				this._decorateUsrAccountDBRule.DataSource = this.UsrAccount.UsrAccountDBRuleList;
			}
		}

		private void tabUsrAccountTenantMap_Enter(object sender, System.EventArgs e)
		{
			if (this.tabUsrAccountTenantMap.Tag == null)
			{
				if (this.UsrAccount.IsNew)
				{
					this._decorateUsrAccountTenantMap.DataSource = null;
					return;
				}

				this.tabUsrAccountTenantMap.Tag = true;

				if (this.UsrAccount.UsrAccountTenantMapList == null || base.IsRefreshData)
				{
					 this.UsrAccount.UsrAccountTenantMapList = UsrAccountTenantMap.GetByUsrAccount(this.UsrAccount.UsrAccountPK);
				}

				this._decorateUsrAccountTenantMap.UsrAccount = this.UsrAccount;
				this._decorateUsrAccountTenantMap.DataSource = this.UsrAccount.UsrAccountTenantMapList;
			}
		}

	}
}
