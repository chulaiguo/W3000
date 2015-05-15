namespace W3000.Manager.FormDetailEditor
{
	public partial class FormDetailUsrGroup
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.txtUsrGroupName = new Cheke.WinCtrl.Common.TextEditEx();
			this.txtDescription = new Cheke.WinCtrl.Common.MemoEditEx();
			this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
			this.tabDetail = new DevExpress.XtraTab.XtraTabPage();
			this.tabUsrGroupDBRule = new DevExpress.XtraTab.XtraTabPage();
			this.grdUsrGroupDBRule = new DevExpress.XtraGrid.GridControl();
			this.grdUsrGroupDBRuleView = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.tabUsrGroupBRRule = new DevExpress.XtraTab.XtraTabPage();
			this.grdUsrGroupBRRule = new DevExpress.XtraGrid.GridControl();
			this.grdUsrGroupBRRuleView = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.tabUsrAccount = new DevExpress.XtraTab.XtraTabPage();
			this.grdUsrAccount = new DevExpress.XtraGrid.GridControl();
			this.grdUsrAccountView = new DevExpress.XtraGrid.Views.Grid.GridView();
			((System.ComponentModel.ISupportInitialize)(this.pnlButtons)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pnlContent)).BeginInit();
			this.pnlContent.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.txtUsrGroupName.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtDescription.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.grdUsrGroupDBRule)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.grdUsrGroupDBRuleView)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.grdUsrGroupBRRule)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.grdUsrGroupBRRuleView)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.grdUsrAccount)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.grdUsrAccountView)).BeginInit();
			this.SuspendLayout();
			//
			// pnlContent
			//
			this.pnlContent.Controls.Add(this.xtraTabControl1);
			//
			// xtraTabControl1
			//
			this.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.xtraTabControl1.Name = "xtraTabControl1";
			this.xtraTabControl1.SelectedTabPage = this.tabDetail;
			this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
			this.tabDetail,this.tabUsrGroupDBRule,this.tabUsrGroupBRRule,this.tabUsrAccount});
			this.xtraTabControl1.SelectedPageChanged += new DevExpress.XtraTab.TabPageChangedEventHandler(this.xtraTabControl1_SelectedPageChanged);
			//
			// tabDetail
			//
			this.tabDetail.Controls.Add(this.txtUsrGroupName);
			this.tabDetail.Controls.Add(this.txtDescription);
			this.tabDetail.Name = "tabDetail";
			this.tabDetail.Text = "Detail";
			//
			// tabUsrGroupDBRule
			//
			this.tabUsrGroupDBRule.Controls.Add(this.grdUsrGroupDBRule);
			this.tabUsrGroupDBRule.Name = "tabUsrGroupDBRule";
			this.tabUsrGroupDBRule.Text = "UsrGroupDBRule";
			this.tabUsrGroupDBRule.Enter += new System.EventHandler(this.tabUsrGroupDBRule_Enter);
			//
			// tabUsrGroupBRRule
			//
			this.tabUsrGroupBRRule.Controls.Add(this.grdUsrGroupBRRule);
			this.tabUsrGroupBRRule.Name = "tabUsrGroupBRRule";
			this.tabUsrGroupBRRule.Text = "UsrGroupBRRule";
			this.tabUsrGroupBRRule.Enter += new System.EventHandler(this.tabUsrGroupBRRule_Enter);
			//
			// tabUsrAccount
			//
			this.tabUsrAccount.Controls.Add(this.grdUsrAccount);
			this.tabUsrAccount.Name = "tabUsrAccount";
			this.tabUsrAccount.Text = "UsrAccount";
			this.tabUsrAccount.Enter += new System.EventHandler(this.tabUsrAccount_Enter);
			//
			// grdUsrGroupDBRule
			//
			this.grdUsrGroupDBRule.Dock = System.Windows.Forms.DockStyle.Fill;
			this.grdUsrGroupDBRule.MainView = this.grdUsrGroupDBRuleView;
			this.grdUsrGroupDBRule.Name = "grdUsrGroupDBRule";
			this.grdUsrGroupDBRule.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {this.grdUsrGroupDBRuleView});
			//
			// grdUsrGroupDBRuleView
			//
			this.grdUsrGroupDBRuleView.GridControl = this.grdUsrGroupDBRule;
			this.grdUsrGroupDBRuleView.Name = "grdUsrGroupDBRuleView";
			//
			// grdUsrGroupBRRule
			//
			this.grdUsrGroupBRRule.Dock = System.Windows.Forms.DockStyle.Fill;
			this.grdUsrGroupBRRule.MainView = this.grdUsrGroupBRRuleView;
			this.grdUsrGroupBRRule.Name = "grdUsrGroupBRRule";
			this.grdUsrGroupBRRule.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {this.grdUsrGroupBRRuleView});
			//
			// grdUsrGroupBRRuleView
			//
			this.grdUsrGroupBRRuleView.GridControl = this.grdUsrGroupBRRule;
			this.grdUsrGroupBRRuleView.Name = "grdUsrGroupBRRuleView";
			//
			// grdUsrAccount
			//
			this.grdUsrAccount.Dock = System.Windows.Forms.DockStyle.Fill;
			this.grdUsrAccount.MainView = this.grdUsrAccountView;
			this.grdUsrAccount.Name = "grdUsrAccount";
			this.grdUsrAccount.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {this.grdUsrAccountView});
			//
			// grdUsrAccountView
			//
			this.grdUsrAccountView.GridControl = this.grdUsrAccount;
			this.grdUsrAccountView.Name = "grdUsrAccountView";
			//
			// txtUsrGroupName
			//
			this.txtUsrGroupName.EditValue = "";
			this.txtUsrGroupName.Location = new System.Drawing.Point(5, 0);
			this.txtUsrGroupName.Name = "txtUsrGroupName";
			this.txtUsrGroupName.TabIndex = 0;
			this.txtUsrGroupName.Title = "UsrGroupName";
			//
			// txtDescription
			//
			this.txtDescription.EditValue = "";
			this.txtDescription.Location = new System.Drawing.Point(5, 40);
			this.txtDescription.Name = "txtDescription";
			this.txtDescription.TabIndex = 1;
			this.txtDescription.Title = "Description";
			//
			// FormDetailUsrGroup
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.Name = "FormDetailUsrGroup";
			this.Text = "UsrGroup Detail";
			((System.ComponentModel.ISupportInitialize)(this.pnlButtons)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pnlContent)).EndInit();
			this.pnlContent.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.txtUsrGroupName.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtDescription.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.grdUsrGroupDBRule)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.grdUsrGroupDBRuleView)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.grdUsrGroupBRRule)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.grdUsrGroupBRRuleView)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.grdUsrAccount)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.grdUsrAccountView)).EndInit();
			this.ResumeLayout(false);
		}

		#endregion

		private Cheke.WinCtrl.Common.TextEditEx txtUsrGroupName;
		private Cheke.WinCtrl.Common.MemoEditEx txtDescription;
		private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
		private DevExpress.XtraTab.XtraTabPage tabDetail;
		private DevExpress.XtraTab.XtraTabPage tabUsrGroupDBRule;
		private DevExpress.XtraGrid.GridControl grdUsrGroupDBRule;
		private DevExpress.XtraGrid.Views.Grid.GridView grdUsrGroupDBRuleView;
		private DevExpress.XtraTab.XtraTabPage tabUsrGroupBRRule;
		private DevExpress.XtraGrid.GridControl grdUsrGroupBRRule;
		private DevExpress.XtraGrid.Views.Grid.GridView grdUsrGroupBRRuleView;
		private DevExpress.XtraTab.XtraTabPage tabUsrAccount;
		private DevExpress.XtraGrid.GridControl grdUsrAccount;
		private DevExpress.XtraGrid.Views.Grid.GridView grdUsrAccountView;
	}
}
