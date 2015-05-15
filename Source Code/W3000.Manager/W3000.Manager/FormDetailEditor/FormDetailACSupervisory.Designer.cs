namespace W3000.Manager.FormDetailEditor
{
	public partial class FormDetailACSupervisory
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
			this.txtSupervisoryID = new Cheke.WinCtrl.Common.TextEditEx();
			this.txtDescription = new Cheke.WinCtrl.Common.TextEditEx();
			this.txtDebounce = new Cheke.WinCtrl.Common.TextEditEx();
			this.txtForceAMFormat = new Cheke.WinCtrl.Common.TextEditEx();
			this.chkExternal = new Cheke.WinCtrl.Common.CheckEditEx();
			this.txtNotes = new Cheke.WinCtrl.Common.MemoEditEx();
			this.txtPanelZoneID = new Cheke.WinCtrl.Common.TextEditEx();
			this.chkLocked = new Cheke.WinCtrl.Common.CheckEditEx();
			this.txtACPanel = new Cheke.WinCtrl.Common.ButtonEditEx();
			this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
			this.tabDetail = new DevExpress.XtraTab.XtraTabPage();
			((System.ComponentModel.ISupportInitialize)(this.pnlButtons)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pnlContent)).BeginInit();
			this.pnlContent.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.txtSupervisoryID.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtDescription.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtDebounce.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtForceAMFormat.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.chkExternal.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtNotes.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtPanelZoneID.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.chkLocked.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtACPanel.Properties)).BeginInit();
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
			this.tabDetail.Controls.Add(this.txtSupervisoryID);
			this.tabDetail.Controls.Add(this.txtDescription);
			this.tabDetail.Controls.Add(this.txtDebounce);
			this.tabDetail.Controls.Add(this.txtForceAMFormat);
			this.tabDetail.Controls.Add(this.chkExternal);
			this.tabDetail.Controls.Add(this.txtNotes);
			this.tabDetail.Controls.Add(this.txtPanelZoneID);
			this.tabDetail.Controls.Add(this.chkLocked);
			this.tabDetail.Controls.Add(this.txtACPanel);
			this.tabDetail.Name = "tabDetail";
			this.tabDetail.Text = "Detail";
			//
			// txtSupervisoryID
			//
			this.txtSupervisoryID.EditValue = "";
			this.txtSupervisoryID.Location = new System.Drawing.Point(5, 0);
			this.txtSupervisoryID.Name = "txtSupervisoryID";
			this.txtSupervisoryID.TabIndex = 0;
			this.txtSupervisoryID.Title = "SupervisoryID";
			this.txtSupervisoryID.Properties.Mask.EditMask = "n0";
			this.txtSupervisoryID.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
			this.txtSupervisoryID.Properties.Mask.UseMaskAsDisplayFormat = true;
			//
			// txtDescription
			//
			this.txtDescription.EditValue = "";
			this.txtDescription.Location = new System.Drawing.Point(5, 40);
			this.txtDescription.Name = "txtDescription";
			this.txtDescription.TabIndex = 1;
			this.txtDescription.Title = "Description";
			//
			// txtDebounce
			//
			this.txtDebounce.EditValue = "";
			this.txtDebounce.Location = new System.Drawing.Point(5, 80);
			this.txtDebounce.Name = "txtDebounce";
			this.txtDebounce.TabIndex = 2;
			this.txtDebounce.Title = "Debounce";
			this.txtDebounce.Properties.Mask.EditMask = "n0";
			this.txtDebounce.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
			this.txtDebounce.Properties.Mask.UseMaskAsDisplayFormat = true;
			//
			// txtForceAMFormat
			//
			this.txtForceAMFormat.EditValue = "";
			this.txtForceAMFormat.Location = new System.Drawing.Point(5, 120);
			this.txtForceAMFormat.Name = "txtForceAMFormat";
			this.txtForceAMFormat.TabIndex = 3;
			this.txtForceAMFormat.Title = "ForceAMFormat";
			this.txtForceAMFormat.Properties.Mask.EditMask = "n0";
			this.txtForceAMFormat.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
			this.txtForceAMFormat.Properties.Mask.UseMaskAsDisplayFormat = true;
			//
			// chkExternal
			//
			this.chkExternal.Location = new System.Drawing.Point(5, 176);
			this.chkExternal.Name = "chkExternal";
			this.chkExternal.TabIndex = 4;
			this.chkExternal.Properties.Caption = "External";
			//
			// txtNotes
			//
			this.txtNotes.EditValue = "";
			this.txtNotes.Location = new System.Drawing.Point(5, 200);
			this.txtNotes.Name = "txtNotes";
			this.txtNotes.TabIndex = 5;
			this.txtNotes.Title = "Notes";
			//
			// txtPanelZoneID
			//
			this.txtPanelZoneID.EditValue = "";
			this.txtPanelZoneID.Location = new System.Drawing.Point(160, 0);
			this.txtPanelZoneID.Name = "txtPanelZoneID";
			this.txtPanelZoneID.TabIndex = 6;
			this.txtPanelZoneID.Title = "PanelZoneID";
			this.txtPanelZoneID.Properties.Mask.EditMask = "n0";
			this.txtPanelZoneID.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
			this.txtPanelZoneID.Properties.Mask.UseMaskAsDisplayFormat = true;
			//
			// chkLocked
			//
			this.chkLocked.Location = new System.Drawing.Point(160, 56);
			this.chkLocked.Name = "chkLocked";
			this.chkLocked.TabIndex = 7;
			this.chkLocked.Properties.Caption = "Locked";
			//
			// txtACPanel
			//
			this.txtACPanel.EditValue = "";
			this.txtACPanel.Location = new System.Drawing.Point(160, 80);
			this.txtACPanel.Name = "txtACPanel";
			this.txtACPanel.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] 
				{
					new DevExpress.XtraEditors.Controls.EditorButton()
				});
			this.txtACPanel.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
			this.txtACPanel.ReadOnly = false;
			this.txtACPanel.TabIndex = 8;
			this.txtACPanel.Title = "ACPanel";
			this.txtACPanel.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.txtACPanel_ButtonClick);
			//
			// FormDetailACSupervisory
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.Name = "FormDetailACSupervisory";
			this.Text = "ACSupervisory Detail";
			((System.ComponentModel.ISupportInitialize)(this.pnlButtons)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pnlContent)).EndInit();
			this.pnlContent.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.txtSupervisoryID.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtDescription.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtDebounce.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtForceAMFormat.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.chkExternal.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtNotes.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtPanelZoneID.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.chkLocked.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtACPanel.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
			this.ResumeLayout(false);
		}

		#endregion

		private Cheke.WinCtrl.Common.TextEditEx txtSupervisoryID;
		private Cheke.WinCtrl.Common.TextEditEx txtDescription;
		private Cheke.WinCtrl.Common.TextEditEx txtDebounce;
		private Cheke.WinCtrl.Common.TextEditEx txtForceAMFormat;
		private Cheke.WinCtrl.Common.CheckEditEx chkExternal;
		private Cheke.WinCtrl.Common.MemoEditEx txtNotes;
		private Cheke.WinCtrl.Common.TextEditEx txtPanelZoneID;
		private Cheke.WinCtrl.Common.CheckEditEx chkLocked;
		private Cheke.WinCtrl.Common.ButtonEditEx txtACPanel;
		private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
		private DevExpress.XtraTab.XtraTabPage tabDetail;
	}
}
