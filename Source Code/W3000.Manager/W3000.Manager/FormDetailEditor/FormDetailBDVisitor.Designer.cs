namespace W3000.Manager.FormDetailEditor
{
	public partial class FormDetailBDVisitor
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
			this.txtFirstName = new Cheke.WinCtrl.Common.TextEditEx();
			this.txtLastName = new Cheke.WinCtrl.Common.TextEditEx();
			this.txtAuthorizedBy = new Cheke.WinCtrl.Common.TextEditEx();
			this.txtAuthorizedArea = new Cheke.WinCtrl.Common.TextEditEx();
			this.txtAuthorEmail = new Cheke.WinCtrl.Common.TextEditEx();
			this.chkEmailNotify = new Cheke.WinCtrl.Common.CheckEditEx();
			this.dateValidFrom = new Cheke.WinCtrl.Common.DateEditEx();
			this.dateValidThru = new Cheke.WinCtrl.Common.DateEditEx();
			this.txtSpecial = new Cheke.WinCtrl.Common.MemoEditEx();
			this.txtBegin = new Cheke.WinCtrl.Common.TextEditEx();
			this.txtEnd = new Cheke.WinCtrl.Common.TextEditEx();
			this.txtSiteCode = new Cheke.WinCtrl.Common.TextEditEx();
			this.txtEncoded = new Cheke.WinCtrl.Common.TextEditEx();
			this.chkScheduled = new Cheke.WinCtrl.Common.CheckEditEx();
			this.dateArrivedTime = new Cheke.WinCtrl.Common.DateEditEx();
			this.txtTurnstileAccess = new Cheke.WinCtrl.Common.TextEditEx();
			this.chkBadgePrinted = new Cheke.WinCtrl.Common.CheckEditEx();
			this.txtBDTenant = new Cheke.WinCtrl.Common.ButtonEditEx();
			this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
			this.tabDetail = new DevExpress.XtraTab.XtraTabPage();
			((System.ComponentModel.ISupportInitialize)(this.pnlButtons)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pnlContent)).BeginInit();
			this.pnlContent.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.txtFirstName.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtLastName.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtAuthorizedBy.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtAuthorizedArea.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtAuthorEmail.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.chkEmailNotify.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dateValidFrom.Properties.VistaTimeProperties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dateValidFrom.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dateValidThru.Properties.VistaTimeProperties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dateValidThru.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtSpecial.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtBegin.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtEnd.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtSiteCode.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtEncoded.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.chkScheduled.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dateArrivedTime.Properties.VistaTimeProperties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dateArrivedTime.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtTurnstileAccess.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.chkBadgePrinted.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtBDTenant.Properties)).BeginInit();
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
			this.tabDetail.Controls.Add(this.txtFirstName);
			this.tabDetail.Controls.Add(this.txtLastName);
			this.tabDetail.Controls.Add(this.txtAuthorizedBy);
			this.tabDetail.Controls.Add(this.txtAuthorizedArea);
			this.tabDetail.Controls.Add(this.txtAuthorEmail);
			this.tabDetail.Controls.Add(this.chkEmailNotify);
			this.tabDetail.Controls.Add(this.dateValidFrom);
			this.tabDetail.Controls.Add(this.dateValidThru);
			this.tabDetail.Controls.Add(this.txtSpecial);
			this.tabDetail.Controls.Add(this.txtBegin);
			this.tabDetail.Controls.Add(this.txtEnd);
			this.tabDetail.Controls.Add(this.txtSiteCode);
			this.tabDetail.Controls.Add(this.txtEncoded);
			this.tabDetail.Controls.Add(this.chkScheduled);
			this.tabDetail.Controls.Add(this.dateArrivedTime);
			this.tabDetail.Controls.Add(this.txtTurnstileAccess);
			this.tabDetail.Controls.Add(this.chkBadgePrinted);
			this.tabDetail.Controls.Add(this.txtBDTenant);
			this.tabDetail.Name = "tabDetail";
			this.tabDetail.Text = "Detail";
			//
			// txtFirstName
			//
			this.txtFirstName.EditValue = "";
			this.txtFirstName.Location = new System.Drawing.Point(5, 0);
			this.txtFirstName.Name = "txtFirstName";
			this.txtFirstName.TabIndex = 0;
			this.txtFirstName.Title = "FirstName";
			//
			// txtLastName
			//
			this.txtLastName.EditValue = "";
			this.txtLastName.Location = new System.Drawing.Point(5, 40);
			this.txtLastName.Name = "txtLastName";
			this.txtLastName.TabIndex = 1;
			this.txtLastName.Title = "LastName";
			//
			// txtAuthorizedBy
			//
			this.txtAuthorizedBy.EditValue = "";
			this.txtAuthorizedBy.Location = new System.Drawing.Point(5, 80);
			this.txtAuthorizedBy.Name = "txtAuthorizedBy";
			this.txtAuthorizedBy.TabIndex = 2;
			this.txtAuthorizedBy.Title = "AuthorizedBy";
			//
			// txtAuthorizedArea
			//
			this.txtAuthorizedArea.EditValue = "";
			this.txtAuthorizedArea.Location = new System.Drawing.Point(5, 120);
			this.txtAuthorizedArea.Name = "txtAuthorizedArea";
			this.txtAuthorizedArea.TabIndex = 3;
			this.txtAuthorizedArea.Title = "AuthorizedArea";
			//
			// txtAuthorEmail
			//
			this.txtAuthorEmail.EditValue = "";
			this.txtAuthorEmail.Location = new System.Drawing.Point(5, 160);
			this.txtAuthorEmail.Name = "txtAuthorEmail";
			this.txtAuthorEmail.TabIndex = 4;
			this.txtAuthorEmail.Title = "AuthorEmail";
			//
			// chkEmailNotify
			//
			this.chkEmailNotify.Location = new System.Drawing.Point(5, 216);
			this.chkEmailNotify.Name = "chkEmailNotify";
			this.chkEmailNotify.TabIndex = 5;
			this.chkEmailNotify.Properties.Caption = "EmailNotify";
			//
			// dateValidFrom
			//
			this.dateValidFrom.EditValue =  new System.DateTime(2015, 1, 1, 0, 0, 0, 0);
			this.dateValidFrom.Location = new System.Drawing.Point(5, 240);
			this.dateValidFrom.Name = "dateValidFrom";
			this.dateValidFrom.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[]
				{
					new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)
				});
			this.dateValidFrom.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[]
				{
					new DevExpress.XtraEditors.Controls.EditorButton()
				});
			this.dateValidFrom.TabIndex = 6;
			this.dateValidFrom.Title = "ValidFrom";
			//
			// dateValidThru
			//
			this.dateValidThru.EditValue =  new System.DateTime(2015, 1, 1, 0, 0, 0, 0);
			this.dateValidThru.Location = new System.Drawing.Point(5, 280);
			this.dateValidThru.Name = "dateValidThru";
			this.dateValidThru.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[]
				{
					new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)
				});
			this.dateValidThru.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[]
				{
					new DevExpress.XtraEditors.Controls.EditorButton()
				});
			this.dateValidThru.TabIndex = 7;
			this.dateValidThru.Title = "ValidThru";
			//
			// txtSpecial
			//
			this.txtSpecial.EditValue = "";
			this.txtSpecial.Location = new System.Drawing.Point(160, 0);
			this.txtSpecial.Name = "txtSpecial";
			this.txtSpecial.TabIndex = 8;
			this.txtSpecial.Title = "Special";
			//
			// txtBegin
			//
			this.txtBegin.EditValue = "";
			this.txtBegin.Location = new System.Drawing.Point(160, 160);
			this.txtBegin.Name = "txtBegin";
			this.txtBegin.TabIndex = 9;
			this.txtBegin.Title = "Begin";
			//
			// txtEnd
			//
			this.txtEnd.EditValue = "";
			this.txtEnd.Location = new System.Drawing.Point(160, 200);
			this.txtEnd.Name = "txtEnd";
			this.txtEnd.TabIndex = 10;
			this.txtEnd.Title = "End";
			//
			// txtSiteCode
			//
			this.txtSiteCode.EditValue = "";
			this.txtSiteCode.Location = new System.Drawing.Point(160, 240);
			this.txtSiteCode.Name = "txtSiteCode";
			this.txtSiteCode.TabIndex = 11;
			this.txtSiteCode.Title = "SiteCode";
			this.txtSiteCode.Properties.Mask.EditMask = "n0";
			this.txtSiteCode.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
			this.txtSiteCode.Properties.Mask.UseMaskAsDisplayFormat = true;
			//
			// txtEncoded
			//
			this.txtEncoded.EditValue = "";
			this.txtEncoded.Location = new System.Drawing.Point(160, 280);
			this.txtEncoded.Name = "txtEncoded";
			this.txtEncoded.TabIndex = 12;
			this.txtEncoded.Title = "Encoded";
			this.txtEncoded.Properties.Mask.EditMask = "n0";
			this.txtEncoded.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
			this.txtEncoded.Properties.Mask.UseMaskAsDisplayFormat = true;
			//
			// chkScheduled
			//
			this.chkScheduled.Location = new System.Drawing.Point(315, 16);
			this.chkScheduled.Name = "chkScheduled";
			this.chkScheduled.TabIndex = 13;
			this.chkScheduled.Properties.Caption = "Scheduled";
			//
			// dateArrivedTime
			//
			this.dateArrivedTime.EditValue =  new System.DateTime(2015, 1, 1, 0, 0, 0, 0);
			this.dateArrivedTime.Location = new System.Drawing.Point(315, 40);
			this.dateArrivedTime.Name = "dateArrivedTime";
			this.dateArrivedTime.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[]
				{
					new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)
				});
			this.dateArrivedTime.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[]
				{
					new DevExpress.XtraEditors.Controls.EditorButton()
				});
			this.dateArrivedTime.TabIndex = 14;
			this.dateArrivedTime.Title = "ArrivedTime";
			//
			// txtTurnstileAccess
			//
			this.txtTurnstileAccess.EditValue = "";
			this.txtTurnstileAccess.Location = new System.Drawing.Point(315, 80);
			this.txtTurnstileAccess.Name = "txtTurnstileAccess";
			this.txtTurnstileAccess.TabIndex = 15;
			this.txtTurnstileAccess.Title = "TurnstileAccess";
			//
			// chkBadgePrinted
			//
			this.chkBadgePrinted.Location = new System.Drawing.Point(315, 136);
			this.chkBadgePrinted.Name = "chkBadgePrinted";
			this.chkBadgePrinted.TabIndex = 16;
			this.chkBadgePrinted.Properties.Caption = "BadgePrinted";
			//
			// txtBDTenant
			//
			this.txtBDTenant.EditValue = "";
			this.txtBDTenant.Location = new System.Drawing.Point(315, 160);
			this.txtBDTenant.Name = "txtBDTenant";
			this.txtBDTenant.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] 
				{
					new DevExpress.XtraEditors.Controls.EditorButton()
				});
			this.txtBDTenant.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
			this.txtBDTenant.ReadOnly = false;
			this.txtBDTenant.TabIndex = 17;
			this.txtBDTenant.Title = "BDTenant";
			this.txtBDTenant.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.txtBDTenant_ButtonClick);
			//
			// FormDetailBDVisitor
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.Name = "FormDetailBDVisitor";
			this.Text = "BDVisitor Detail";
			((System.ComponentModel.ISupportInitialize)(this.pnlButtons)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pnlContent)).EndInit();
			this.pnlContent.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.txtFirstName.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtLastName.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtAuthorizedBy.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtAuthorizedArea.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtAuthorEmail.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.chkEmailNotify.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dateValidFrom.Properties.VistaTimeProperties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dateValidFrom.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dateValidThru.Properties.VistaTimeProperties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dateValidThru.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtSpecial.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtBegin.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtEnd.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtSiteCode.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtEncoded.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.chkScheduled.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dateArrivedTime.Properties.VistaTimeProperties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dateArrivedTime.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtTurnstileAccess.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.chkBadgePrinted.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtBDTenant.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
			this.ResumeLayout(false);
		}

		#endregion

		private Cheke.WinCtrl.Common.TextEditEx txtFirstName;
		private Cheke.WinCtrl.Common.TextEditEx txtLastName;
		private Cheke.WinCtrl.Common.TextEditEx txtAuthorizedBy;
		private Cheke.WinCtrl.Common.TextEditEx txtAuthorizedArea;
		private Cheke.WinCtrl.Common.TextEditEx txtAuthorEmail;
		private Cheke.WinCtrl.Common.CheckEditEx chkEmailNotify;
		private Cheke.WinCtrl.Common.DateEditEx dateValidFrom;
		private Cheke.WinCtrl.Common.DateEditEx dateValidThru;
		private Cheke.WinCtrl.Common.MemoEditEx txtSpecial;
		private Cheke.WinCtrl.Common.TextEditEx txtBegin;
		private Cheke.WinCtrl.Common.TextEditEx txtEnd;
		private Cheke.WinCtrl.Common.TextEditEx txtSiteCode;
		private Cheke.WinCtrl.Common.TextEditEx txtEncoded;
		private Cheke.WinCtrl.Common.CheckEditEx chkScheduled;
		private Cheke.WinCtrl.Common.DateEditEx dateArrivedTime;
		private Cheke.WinCtrl.Common.TextEditEx txtTurnstileAccess;
		private Cheke.WinCtrl.Common.CheckEditEx chkBadgePrinted;
		private Cheke.WinCtrl.Common.ButtonEditEx txtBDTenant;
		private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
		private DevExpress.XtraTab.XtraTabPage tabDetail;
	}
}
