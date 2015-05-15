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
	public partial class FormDetailUsrAccountBRRule : FormDetailEditorBase
	{

		public FormDetailUsrAccountBRRule()
		{
			InitializeComponent();
		}

		public FormDetailUsrAccountBRRule(string userid, UsrAccountBRRule entity)
			: base(userid, entity)
		{
			InitializeComponent();
		}

		protected override void InitializeDecorator()
		{
		}

		private UsrAccountBRRule UsrAccountBRRule
		{
			get{ return base.Entity as UsrAccountBRRule; }
		}

		protected override void DataBindingEntity()
		{
			this.txtBRRuleID.BindingData(this.UsrAccountBRRule, UsrAccountBRRuleSchema.BRRuleID);
			this.chkDenied.BindingData(this.UsrAccountBRRule, UsrAccountBRRuleSchema.Denied);

			this.txtUsrAccount.Text = this.UsrAccountBRRule.UserID.ToString();
		}

		private void txtUsrAccount_ButtonClick(object sender, ButtonPressedEventArgs e)
		{
			if (e.Button.Kind == ButtonPredefines.Delete)
			{
				if (this.UsrAccountBRRule.UsrAccountPK == Guid.Empty)
					return;

				if (DialogResult.Yes != base.ShowQuestion(string.Format("Are you sure you want to clear the {0}?", this.txtUsrAccount.Title)))
					return;

				this.UsrAccountBRRule.UsrAccountPK = Guid.Empty;
				this.txtUsrAccount.Text = string.Empty;
			}
			else
			{
				FormSelectUsrAccount dlg = new FormSelectUsrAccount(base.UserId);
				dlg.MultiSelect = false;
				if (dlg.ShowDialog() != System.Windows.Forms.DialogResult.OK)
					return;

				if (this.UsrAccountBRRule.UsrAccountPK == dlg.UsrAccount.UsrAccountPK)
					return;

				this.UsrAccountBRRule.UsrAccount = dlg.UsrAccount;
				this.txtUsrAccount.Text = dlg.UsrAccount.UserID.ToString();
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

	}
}
