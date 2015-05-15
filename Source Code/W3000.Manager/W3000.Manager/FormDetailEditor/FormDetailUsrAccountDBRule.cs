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
	public partial class FormDetailUsrAccountDBRule : FormDetailEditorBase
	{

		public FormDetailUsrAccountDBRule()
		{
			InitializeComponent();
		}

		public FormDetailUsrAccountDBRule(string userid, UsrAccountDBRule entity)
			: base(userid, entity)
		{
			InitializeComponent();
		}

		protected override void InitializeDecorator()
		{
		}

		private UsrAccountDBRule UsrAccountDBRule
		{
			get{ return base.Entity as UsrAccountDBRule; }
		}

		protected override void DataBindingEntity()
		{
			this.txtDBRuleID.BindingData(this.UsrAccountDBRule, UsrAccountDBRuleSchema.DBRuleID);
			this.chkSelectable.BindingData(this.UsrAccountDBRule, UsrAccountDBRuleSchema.Selectable);
			this.chkInsertable.BindingData(this.UsrAccountDBRule, UsrAccountDBRuleSchema.Insertable);
			this.chkEditable.BindingData(this.UsrAccountDBRule, UsrAccountDBRuleSchema.Editable);
			this.chkDeletable.BindingData(this.UsrAccountDBRule, UsrAccountDBRuleSchema.Deletable);

			this.txtUsrAccount.Text = this.UsrAccountDBRule.UserID.ToString();
		}

		private void txtUsrAccount_ButtonClick(object sender, ButtonPressedEventArgs e)
		{
			if (e.Button.Kind == ButtonPredefines.Delete)
			{
				if (this.UsrAccountDBRule.UsrAccountPK == Guid.Empty)
					return;

				if (DialogResult.Yes != base.ShowQuestion(string.Format("Are you sure you want to clear the {0}?", this.txtUsrAccount.Title)))
					return;

				this.UsrAccountDBRule.UsrAccountPK = Guid.Empty;
				this.txtUsrAccount.Text = string.Empty;
			}
			else
			{
				FormSelectUsrAccount dlg = new FormSelectUsrAccount(base.UserId);
				dlg.MultiSelect = false;
				if (dlg.ShowDialog() != System.Windows.Forms.DialogResult.OK)
					return;

				if (this.UsrAccountDBRule.UsrAccountPK == dlg.UsrAccount.UsrAccountPK)
					return;

				this.UsrAccountDBRule.UsrAccount = dlg.UsrAccount;
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
