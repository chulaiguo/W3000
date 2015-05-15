namespace W3000.Manager.FormDetailEditor
{
	public partial class FormDetailACMasterCard
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
			this.txtSitecode = new Cheke.WinCtrl.Common.TextEditEx();
			this.txtEmbossed = new Cheke.WinCtrl.Common.TextEditEx();
			this.txtEncoded = new Cheke.WinCtrl.Common.TextEditEx();
			this.txtCardTypeID = new Cheke.WinCtrl.Common.TextEditEx();
			this.txtFirstName = new Cheke.WinCtrl.Common.TextEditEx();
			this.txtLastName = new Cheke.WinCtrl.Common.TextEditEx();
			this.chkFIPS = new Cheke.WinCtrl.Common.CheckEditEx();
			this.txtPin = new Cheke.WinCtrl.Common.TextEditEx();
			this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
			this.tabDetail = new DevExpress.XtraTab.XtraTabPage();
			((System.ComponentModel.ISupportInitialize)(this.pnlButtons)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pnlContent)).BeginInit();
			this.pnlContent.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.txtSitecode.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtEmbossed.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtEncoded.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtCardTypeID.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtFirstName.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtLastName.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.chkFIPS.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtPin.Properties)).BeginInit();
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
			this.tabDetail.Controls.Add(this.txtSitecode);
			this.tabDetail.Controls.Add(this.txtEmbossed);
			this.tabDetail.Controls.Add(this.txtEncoded);
			this.tabDetail.Controls.Add(this.txtCardTypeID);
			this.tabDetail.Controls.Add(this.txtFirstName);
			this.tabDetail.Controls.Add(this.txtLastName);
			this.tabDetail.Controls.Add(this.chkFIPS);
			this.tabDetail.Controls.Add(this.txtPin);
			this.tabDetail.Name = "tabDetail";
			this.tabDetail.Text = "Detail";
			//
			// txtSitecode
			//
			this.txtSitecode.EditValue = "";
			this.txtSitecode.Location = new System.Drawing.Point(5, 0);
			this.txtSitecode.Name = "txtSitecode";
			this.txtSitecode.TabIndex = 0;
			this.txtSitecode.Title = "Sitecode";
			this.txtSitecode.Properties.Mask.EditMask = "n0";
			this.txtSitecode.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
			this.txtSitecode.Properties.Mask.UseMaskAsDisplayFormat = true;
			//
			// txtEmbossed
			//
			this.txtEmbossed.EditValue = "";
			this.txtEmbossed.Location = new System.Drawing.Point(5, 40);
			this.txtEmbossed.Name = "txtEmbossed";
			this.txtEmbossed.TabIndex = 1;
			this.txtEmbossed.Title = "Embossed";
			this.txtEmbossed.Properties.Mask.EditMask = "n0";
			this.txtEmbossed.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
			this.txtEmbossed.Properties.Mask.UseMaskAsDisplayFormat = true;
			//
			// txtEncoded
			//
			this.txtEncoded.EditValue = "";
			this.txtEncoded.Location = new System.Drawing.Point(5, 80);
			this.txtEncoded.Name = "txtEncoded";
			this.txtEncoded.TabIndex = 2;
			this.txtEncoded.Title = "Encoded";
			this.txtEncoded.Properties.Mask.EditMask = "n0";
			this.txtEncoded.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
			this.txtEncoded.Properties.Mask.UseMaskAsDisplayFormat = true;
			//
			// txtCardTypeID
			//
			this.txtCardTypeID.EditValue = "";
			this.txtCardTypeID.Location = new System.Drawing.Point(5, 120);
			this.txtCardTypeID.Name = "txtCardTypeID";
			this.txtCardTypeID.TabIndex = 3;
			this.txtCardTypeID.Title = "CardTypeID";
			this.txtCardTypeID.Properties.Mask.EditMask = "n0";
			this.txtCardTypeID.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
			this.txtCardTypeID.Properties.Mask.UseMaskAsDisplayFormat = true;
			//
			// txtFirstName
			//
			this.txtFirstName.EditValue = "";
			this.txtFirstName.Location = new System.Drawing.Point(5, 160);
			this.txtFirstName.Name = "txtFirstName";
			this.txtFirstName.TabIndex = 4;
			this.txtFirstName.Title = "FirstName";
			//
			// txtLastName
			//
			this.txtLastName.EditValue = "";
			this.txtLastName.Location = new System.Drawing.Point(5, 200);
			this.txtLastName.Name = "txtLastName";
			this.txtLastName.TabIndex = 5;
			this.txtLastName.Title = "LastName";
			//
			// chkFIPS
			//
			this.chkFIPS.Location = new System.Drawing.Point(5, 256);
			this.chkFIPS.Name = "chkFIPS";
			this.chkFIPS.TabIndex = 6;
			this.chkFIPS.Properties.Caption = "FIPS";
			//
			// txtPin
			//
			this.txtPin.EditValue = "";
			this.txtPin.Location = new System.Drawing.Point(5, 280);
			this.txtPin.Name = "txtPin";
			this.txtPin.TabIndex = 7;
			this.txtPin.Title = "Pin";
			this.txtPin.Properties.Mask.EditMask = "n0";
			this.txtPin.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
			this.txtPin.Properties.Mask.UseMaskAsDisplayFormat = true;
			//
			// FormDetailACMasterCard
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.Name = "FormDetailACMasterCard";
			this.Text = "ACMasterCard Detail";
			((System.ComponentModel.ISupportInitialize)(this.pnlButtons)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pnlContent)).EndInit();
			this.pnlContent.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.txtSitecode.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtEmbossed.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtEncoded.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtCardTypeID.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtFirstName.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtLastName.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.chkFIPS.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtPin.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
			this.ResumeLayout(false);
		}

		#endregion

		private Cheke.WinCtrl.Common.TextEditEx txtSitecode;
		private Cheke.WinCtrl.Common.TextEditEx txtEmbossed;
		private Cheke.WinCtrl.Common.TextEditEx txtEncoded;
		private Cheke.WinCtrl.Common.TextEditEx txtCardTypeID;
		private Cheke.WinCtrl.Common.TextEditEx txtFirstName;
		private Cheke.WinCtrl.Common.TextEditEx txtLastName;
		private Cheke.WinCtrl.Common.CheckEditEx chkFIPS;
		private Cheke.WinCtrl.Common.TextEditEx txtPin;
		private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
		private DevExpress.XtraTab.XtraTabPage tabDetail;
	}
}
