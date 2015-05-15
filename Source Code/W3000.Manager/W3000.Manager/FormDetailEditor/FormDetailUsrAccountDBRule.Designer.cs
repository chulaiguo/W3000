namespace W3000.Manager.FormDetailEditor
{
	public partial class FormDetailUsrAccountDBRule
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
			this.txtDBRuleID = new Cheke.WinCtrl.Common.TextEditEx();
			this.chkSelectable = new Cheke.WinCtrl.Common.CheckEditEx();
			this.chkInsertable = new Cheke.WinCtrl.Common.CheckEditEx();
			this.chkEditable = new Cheke.WinCtrl.Common.CheckEditEx();
			this.chkDeletable = new Cheke.WinCtrl.Common.CheckEditEx();
			this.txtUsrAccount = new Cheke.WinCtrl.Common.ButtonEditEx();
			this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
			this.tabDetail = new DevExpress.XtraTab.XtraTabPage();
			((System.ComponentModel.ISupportInitialize)(this.pnlButtons)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pnlContent)).BeginInit();
			this.pnlContent.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.txtDBRuleID.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.chkSelectable.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.chkInsertable.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.chkEditable.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.chkDeletable.Properties)).BeginInit();
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
			this.tabDetail.Controls.Add(this.txtDBRuleID);
			this.tabDetail.Controls.Add(this.chkSelectable);
			this.tabDetail.Controls.Add(this.chkInsertable);
			this.tabDetail.Controls.Add(this.chkEditable);
			this.tabDetail.Controls.Add(this.chkDeletable);
			this.tabDetail.Controls.Add(this.txtUsrAccount);
			this.tabDetail.Name = "tabDetail";
			this.tabDetail.Text = "Detail";
			//
			// txtDBRuleID
			//
			this.txtDBRuleID.EditValue = "";
			this.txtDBRuleID.Location = new System.Drawing.Point(5, 0);
			this.txtDBRuleID.Name = "txtDBRuleID";
			this.txtDBRuleID.TabIndex = 0;
			this.txtDBRuleID.Title = "DBRuleID";
			this.txtDBRuleID.Properties.Mask.EditMask = "n0";
			this.txtDBRuleID.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
			this.txtDBRuleID.Properties.Mask.UseMaskAsDisplayFormat = true;
			//
			// chkSelectable
			//
			this.chkSelectable.Location = new System.Drawing.Point(5, 56);
			this.chkSelectable.Name = "chkSelectable";
			this.chkSelectable.TabIndex = 1;
			this.chkSelectable.Properties.Caption = "Selectable";
			//
			// chkInsertable
			//
			this.chkInsertable.Location = new System.Drawing.Point(5, 96);
			this.chkInsertable.Name = "chkInsertable";
			this.chkInsertable.TabIndex = 2;
			this.chkInsertable.Properties.Caption = "Insertable";
			//
			// chkEditable
			//
			this.chkEditable.Location = new System.Drawing.Point(5, 136);
			this.chkEditable.Name = "chkEditable";
			this.chkEditable.TabIndex = 3;
			this.chkEditable.Properties.Caption = "Editable";
			//
			// chkDeletable
			//
			this.chkDeletable.Location = new System.Drawing.Point(5, 176);
			this.chkDeletable.Name = "chkDeletable";
			this.chkDeletable.TabIndex = 4;
			this.chkDeletable.Properties.Caption = "Deletable";
			//
			// txtUsrAccount
			//
			this.txtUsrAccount.EditValue = "";
			this.txtUsrAccount.Location = new System.Drawing.Point(5, 200);
			this.txtUsrAccount.Name = "txtUsrAccount";
			this.txtUsrAccount.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] 
				{
					new DevExpress.XtraEditors.Controls.EditorButton()
				});
			this.txtUsrAccount.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
			this.txtUsrAccount.ReadOnly = false;
			this.txtUsrAccount.TabIndex = 5;
			this.txtUsrAccount.Title = "UsrAccount";
			this.txtUsrAccount.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.txtUsrAccount_ButtonClick);
			//
			// FormDetailUsrAccountDBRule
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.Name = "FormDetailUsrAccountDBRule";
			this.Text = "UsrAccountDBRule Detail";
			((System.ComponentModel.ISupportInitialize)(this.pnlButtons)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pnlContent)).EndInit();
			this.pnlContent.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.txtDBRuleID.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.chkSelectable.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.chkInsertable.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.chkEditable.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.chkDeletable.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtUsrAccount.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
			this.ResumeLayout(false);
		}

		#endregion

		private Cheke.WinCtrl.Common.TextEditEx txtDBRuleID;
		private Cheke.WinCtrl.Common.CheckEditEx chkSelectable;
		private Cheke.WinCtrl.Common.CheckEditEx chkInsertable;
		private Cheke.WinCtrl.Common.CheckEditEx chkEditable;
		private Cheke.WinCtrl.Common.CheckEditEx chkDeletable;
		private Cheke.WinCtrl.Common.ButtonEditEx txtUsrAccount;
		private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
		private DevExpress.XtraTab.XtraTabPage tabDetail;
	}
}
