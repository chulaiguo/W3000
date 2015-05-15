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
	public partial class FormDetailBDVisitor : FormDetailEditorBase
	{

		public FormDetailBDVisitor()
		{
			InitializeComponent();
		}

		public FormDetailBDVisitor(string userid, BDVisitor entity)
			: base(userid, entity)
		{
			InitializeComponent();
		}

		protected override void InitializeDecorator()
		{
		}

		private BDVisitor BDVisitor
		{
			get{ return base.Entity as BDVisitor; }
		}

		protected override void DataBindingEntity()
		{
			this.txtFirstName.BindingData(this.BDVisitor, BDVisitorSchema.FirstName);
			this.txtLastName.BindingData(this.BDVisitor, BDVisitorSchema.LastName);
			this.txtAuthorizedBy.BindingData(this.BDVisitor, BDVisitorSchema.AuthorizedBy);
			this.txtAuthorizedArea.BindingData(this.BDVisitor, BDVisitorSchema.AuthorizedArea);
			this.txtAuthorEmail.BindingData(this.BDVisitor, BDVisitorSchema.AuthorEmail);
			this.chkEmailNotify.BindingData(this.BDVisitor, BDVisitorSchema.EmailNotify);
			this.dateValidFrom.BindingData(this.BDVisitor, BDVisitorSchema.ValidFrom);
			this.dateValidThru.BindingData(this.BDVisitor, BDVisitorSchema.ValidThru);
			this.txtSpecial.BindingData(this.BDVisitor, BDVisitorSchema.Special);
			this.txtBegin.BindingData(this.BDVisitor, BDVisitorSchema.Begin);
			this.txtEnd.BindingData(this.BDVisitor, BDVisitorSchema.End);
			this.txtSiteCode.BindingData(this.BDVisitor, BDVisitorSchema.SiteCode);
			this.txtEncoded.BindingData(this.BDVisitor, BDVisitorSchema.Encoded);
			this.chkScheduled.BindingData(this.BDVisitor, BDVisitorSchema.Scheduled);
			this.dateArrivedTime.BindingData(this.BDVisitor, BDVisitorSchema.ArrivedTime);
			this.txtTurnstileAccess.BindingData(this.BDVisitor, BDVisitorSchema.TurnstileAccess);
			this.chkBadgePrinted.BindingData(this.BDVisitor, BDVisitorSchema.BadgePrinted);

			this.txtBDTenant.Text = this.BDVisitor.Tenant.ToString();
		}

		private void txtBDTenant_ButtonClick(object sender, ButtonPressedEventArgs e)
		{
			if (e.Button.Kind == ButtonPredefines.Delete)
			{
				if (this.BDVisitor.BDTenantPK == Guid.Empty)
					return;

				if (DialogResult.Yes != base.ShowQuestion(string.Format("Are you sure you want to clear the {0}?", this.txtBDTenant.Title)))
					return;

				this.BDVisitor.BDTenantPK = Guid.Empty;
				this.txtBDTenant.Text = string.Empty;
			}
			else
			{
				FormSelectBDTenant dlg = new FormSelectBDTenant(base.UserId);
				dlg.MultiSelect = false;
				if (dlg.ShowDialog() != System.Windows.Forms.DialogResult.OK)
					return;

				if (this.BDVisitor.BDTenantPK == dlg.BDTenant.BDTenantPK)
					return;

				this.BDVisitor.BDTenant = dlg.BDTenant;
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

	}
}
