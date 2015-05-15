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
	public partial class FormDetailUsrGroupBRRule : FormDetailEditorBase
	{

		public FormDetailUsrGroupBRRule()
		{
			InitializeComponent();
		}

		public FormDetailUsrGroupBRRule(string userid, UsrGroupBRRule entity)
			: base(userid, entity)
		{
			InitializeComponent();
		}

		protected override void InitializeDecorator()
		{
		}

		private UsrGroupBRRule UsrGroupBRRule
		{
			get{ return base.Entity as UsrGroupBRRule; }
		}

		protected override void DataBindingEntity()
		{
			this.txtBRRuleID.BindingData(this.UsrGroupBRRule, UsrGroupBRRuleSchema.BRRuleID);
			this.chkDenied.BindingData(this.UsrGroupBRRule, UsrGroupBRRuleSchema.Denied);

			this.txtUsrGroup.Text = this.UsrGroupBRRule.UsrGroupName.ToString();
		}

		private void txtUsrGroup_ButtonClick(object sender, ButtonPressedEventArgs e)
		{
			if (e.Button.Kind == ButtonPredefines.Delete)
			{
				if (this.UsrGroupBRRule.UsrGroupPK == Guid.Empty)
					return;

				if (DialogResult.Yes != base.ShowQuestion(string.Format("Are you sure you want to clear the {0}?", this.txtUsrGroup.Title)))
					return;

				this.UsrGroupBRRule.UsrGroupPK = Guid.Empty;
				this.txtUsrGroup.Text = string.Empty;
			}
			else
			{
				FormSelectUsrGroup dlg = new FormSelectUsrGroup(base.UserId);
				dlg.MultiSelect = false;
				if (dlg.ShowDialog() != System.Windows.Forms.DialogResult.OK)
					return;

				if (this.UsrGroupBRRule.UsrGroupPK == dlg.UsrGroup.UsrGroupPK)
					return;

				this.UsrGroupBRRule.UsrGroup = dlg.UsrGroup;
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

	}
}
