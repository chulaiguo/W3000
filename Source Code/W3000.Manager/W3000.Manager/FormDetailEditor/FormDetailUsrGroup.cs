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
	public partial class FormDetailUsrGroup : FormDetailEditorBase
	{
		private GridUsrGroupDBRuleDecorator _decorateUsrGroupDBRule = null;
		private GridUsrGroupBRRuleDecorator _decorateUsrGroupBRRule = null;
		private GridUsrAccountDecorator _decorateUsrAccount = null;

		public FormDetailUsrGroup()
		{
			InitializeComponent();
		}

		public FormDetailUsrGroup(string userid, UsrGroup entity)
			: base(userid, entity)
		{
			InitializeComponent();
		}

		protected override void InitializeDecorator()
		{
			this._decorateUsrGroupDBRule = new GridUsrGroupDBRuleDecorator(base.UserId, this.grdUsrGroupDBRule);
			this._decorateUsrGroupDBRule.Initialize();

			this._decorateUsrGroupBRRule = new GridUsrGroupBRRuleDecorator(base.UserId, this.grdUsrGroupBRRule);
			this._decorateUsrGroupBRRule.Initialize();

			this._decorateUsrAccount = new GridUsrAccountDecorator(base.UserId, this.grdUsrAccount);
			this._decorateUsrAccount.Initialize();

		}

		private UsrGroup UsrGroup
		{
			get{ return base.Entity as UsrGroup; }
		}

		protected override void DataBindingEntity()
		{
			this.txtUsrGroupName.BindingData(this.UsrGroup, UsrGroupSchema.UsrGroupName);
			this.txtDescription.BindingData(this.UsrGroup, UsrGroupSchema.Description);

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

		private void tabUsrGroupDBRule_Enter(object sender, System.EventArgs e)
		{
			if (this.tabUsrGroupDBRule.Tag == null)
			{
				if (this.UsrGroup.IsNew)
				{
					this._decorateUsrGroupDBRule.DataSource = null;
					return;
				}

				this.tabUsrGroupDBRule.Tag = true;

				if (this.UsrGroup.UsrGroupDBRuleList == null || base.IsRefreshData)
				{
					 this.UsrGroup.UsrGroupDBRuleList = UsrGroupDBRule.GetByUsrGroup(this.UsrGroup.UsrGroupPK);
				}

				this._decorateUsrGroupDBRule.UsrGroup = this.UsrGroup;
				this._decorateUsrGroupDBRule.DataSource = this.UsrGroup.UsrGroupDBRuleList;
			}
		}

		private void tabUsrGroupBRRule_Enter(object sender, System.EventArgs e)
		{
			if (this.tabUsrGroupBRRule.Tag == null)
			{
				if (this.UsrGroup.IsNew)
				{
					this._decorateUsrGroupBRRule.DataSource = null;
					return;
				}

				this.tabUsrGroupBRRule.Tag = true;

				if (this.UsrGroup.UsrGroupBRRuleList == null || base.IsRefreshData)
				{
					 this.UsrGroup.UsrGroupBRRuleList = UsrGroupBRRule.GetByUsrGroup(this.UsrGroup.UsrGroupPK);
				}

				this._decorateUsrGroupBRRule.UsrGroup = this.UsrGroup;
				this._decorateUsrGroupBRRule.DataSource = this.UsrGroup.UsrGroupBRRuleList;
			}
		}

		private void tabUsrAccount_Enter(object sender, System.EventArgs e)
		{
			if (this.tabUsrAccount.Tag == null)
			{
				if (this.UsrGroup.IsNew)
				{
					this._decorateUsrAccount.DataSource = null;
					return;
				}

				this.tabUsrAccount.Tag = true;

				if (this.UsrGroup.UsrAccountList == null || base.IsRefreshData)
				{
					 this.UsrGroup.UsrAccountList = UsrAccount.GetByUsrGroup(this.UsrGroup.UsrGroupPK);
				}

				this._decorateUsrAccount.UsrGroup = this.UsrGroup;
				this._decorateUsrAccount.DataSource = this.UsrGroup.UsrAccountList;
			}
		}

	}
}
