namespace W3000.Manager.FormDetailEditor
{
	public partial class FormDetailUsrAccountBRRule
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
			this.txtBRRuleID = new Cheke.WinCtrl.Common.TextEditEx();
			this.chkDenied = new Cheke.WinCtrl.Common.CheckEditEx();
			this.txtUsrAccount = new Cheke.WinCtrl.Common.ButtonEditEx();
			this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
			this.tabDetail = new DevExpress.XtraTab.XtraTabPage();
			((System.ComponentModel.ISupportInitialize)(this.pnlButtons)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pnlContent)).BeginInit();
			this.pnlContent.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.txtBRRuleID.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.chkDenied.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtUsrAccount.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
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
			this.tabDetail});
			this.xtraTabControl1.SelectedPageChanged += new DevExpress.XtraTab.TabPageChangedEventHandler(this.xtraTabControl1_SelectedPageChanged);
			//
			// tabDetail
			//
			this.tabDetail.Controls.Add(this.txtBRRuleID);
			this.tabDetail.Controls.Add(this.chkDenied);
			this.tabDetail.Controls.Add(this.txtUsrAccount);
			this.tabDetail.Name = "tabDetail";
			this.tabDetail.Text = "Detail";
			//
			// txtBRRuleID
			//
			this.txtBRRuleID.EditValue = "";
			this.txtBRRuleID.Location = new System.Drawing.Point(5, 0);
			this.txtBRRuleID.Name = "txtBRRuleID";
			this.txtBRRuleID.TabIndex = 0;
			this.txtBRRuleID.Title = "BRRuleID";
			this.txtBRRuleID.Properties.Mask.EditMask = "n0";
			this.txtBRRuleID.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
			this.txtBRRuleID.Properties.Mask.UseMaskAsDisplayFormat = true;
			//
			// chkDenied
			//
			this.chkDenied.Location = new System.Drawing.Point(5, 56);
			this.chkDenied.Name = "chkDenied";
			this.chkDenied.TabIndex = 1;
			this.chkDenied.Properties.Caption = "Denied";
			//
			// txtUsrAccount
			//
			this.txtUsrAccount.EditValue = "";
			this.txtUsrAccount.Location = new System.Drawing.Point(5, 80);
			this.txtUsrAccount.Name = "txtUsrAccount";
			this.txtUsrAccount.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] 
				{
					new DevExpress.XtraEditors.Controls.EditorButton()
				});
			this.txtUsrAccount.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
			this.txtUsrAccount.ReadOnly = false;
			this.txtUsrAccount.TabIndex = 2;
			this.txtUsrAccount.Title = "UsrAccount";
			this.txtUsrAccount.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.txtUsrAccount_ButtonClick);
			//
			// FormDetailUsrAccountBRRule
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.Name = "FormDetailUsrAccountBRRule";
			this.Text = "UsrAccountBRRule Detail";
			((System.ComponentModel.ISupportInitialize)(this.pnlButtons)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pnlContent)).EndInit();
			this.pnlContent.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.txtBRRuleID.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.chkDenied.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtUsrAccount.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
			this.ResumeLayout(false);
		}

		#endregion

		private Cheke.WinCtrl.Common.TextEditEx txtBRRuleID;
		private Cheke.WinCtrl.Common.CheckEditEx chkDenied;
		private Cheke.WinCtrl.Common.ButtonEditEx txtUsrAccount;
		private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
		private DevExpress.XtraTab.XtraTabPage tabDetail;
	}
}
