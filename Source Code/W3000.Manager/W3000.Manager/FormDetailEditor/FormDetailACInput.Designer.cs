namespace W3000.Manager.FormDetailEditor
{
	public partial class FormDetailACInput
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
			this.txtInputID = new Cheke.WinCtrl.Common.TextEditEx();
			this.txtDescription = new Cheke.WinCtrl.Common.TextEditEx();
			this.txtDebounce = new Cheke.WinCtrl.Common.TextEditEx();
			this.chkReverse = new Cheke.WinCtrl.Common.CheckEditEx();
			this.txtForceAMFormat = new Cheke.WinCtrl.Common.TextEditEx();
			this.chkOffOnRestore = new Cheke.WinCtrl.Common.CheckEditEx();
			this.chkExternal = new Cheke.WinCtrl.Common.CheckEditEx();
			this.txtNotes = new Cheke.WinCtrl.Common.MemoEditEx();
			this.chkAlwaysToMAS = new Cheke.WinCtrl.Common.CheckEditEx();
			this.txtPanelZoneID = new Cheke.WinCtrl.Common.TextEditEx();
			this.chkLocked = new Cheke.WinCtrl.Common.CheckEditEx();
			this.txtACPanel = new Cheke.WinCtrl.Common.ButtonEditEx();
			this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
			this.tabDetail = new DevExpress.XtraTab.XtraTabPage();
			this.tabACInputGroupInputMap = new DevExpress.XtraTab.XtraTabPage();
			this.grdACInputGroupInputMap = new DevExpress.XtraGrid.GridControl();
			this.grdACInputGroupInputMapView = new DevExpress.XtraGrid.Views.Grid.GridView();
			((System.ComponentModel.ISupportInitialize)(this.pnlButtons)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pnlContent)).BeginInit();
			this.pnlContent.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.txtInputID.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtDescription.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtDebounce.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.chkReverse.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtForceAMFormat.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.chkOffOnRestore.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.chkExternal.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtNotes.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.chkAlwaysToMAS.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtPanelZoneID.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.chkLocked.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtACPanel.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.grdACInputGroupInputMap)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.grdACInputGroupInputMapView)).BeginInit();
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
			this.tabDetail,this.tabACInputGroupInputMap});
			this.xtraTabControl1.SelectedPageChanged += new DevExpress.XtraTab.TabPageChangedEventHandler(this.xtraTabControl1_SelectedPageChanged);
			//
			// tabDetail
			//
			this.tabDetail.Controls.Add(this.txtInputID);
			this.tabDetail.Controls.Add(this.txtDescription);
			this.tabDetail.Controls.Add(this.txtDebounce);
			this.tabDetail.Controls.Add(this.chkReverse);
			this.tabDetail.Controls.Add(this.txtForceAMFormat);
			this.tabDetail.Controls.Add(this.chkOffOnRestore);
			this.tabDetail.Controls.Add(this.chkExternal);
			this.tabDetail.Controls.Add(this.txtNotes);
			this.tabDetail.Controls.Add(this.chkAlwaysToMAS);
			this.tabDetail.Controls.Add(this.txtPanelZoneID);
			this.tabDetail.Controls.Add(this.chkLocked);
			this.tabDetail.Controls.Add(this.txtACPanel);
			this.tabDetail.Name = "tabDetail";
			this.tabDetail.Text = "Detail";
			//
			// tabACInputGroupInputMap
			//
			this.tabACInputGroupInputMap.Controls.Add(this.grdACInputGroupInputMap);
			this.tabACInputGroupInputMap.Name = "tabACInputGroupInputMap";
			this.tabACInputGroupInputMap.Text = "ACInputGroupInputMap";
			this.tabACInputGroupInputMap.Enter += new System.EventHandler(this.tabACInputGroupInputMap_Enter);
			//
			// grdACInputGroupInputMap
			//
			this.grdACInputGroupInputMap.Dock = System.Windows.Forms.DockStyle.Fill;
			this.grdACInputGroupInputMap.MainView = this.grdACInputGroupInputMapView;
			this.grdACInputGroupInputMap.Name = "grdACInputGroupInputMap";
			this.grdACInputGroupInputMap.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {this.grdACInputGroupInputMapView});
			//
			// grdACInputGroupInputMapView
			//
			this.grdACInputGroupInputMapView.GridControl = this.grdACInputGroupInputMap;
			this.grdACInputGroupInputMapView.Name = "grdACInputGroupInputMapView";
			//
			// txtInputID
			//
			this.txtInputID.EditValue = "";
			this.txtInputID.Location = new System.Drawing.Point(5, 0);
			this.txtInputID.Name = "txtInputID";
			this.txtInputID.TabIndex = 0;
			this.txtInputID.Title = "InputID";
			this.txtInputID.Properties.Mask.EditMask = "n0";
			this.txtInputID.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
			this.txtInputID.Properties.Mask.UseMaskAsDisplayFormat = true;
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
			// chkReverse
			//
			this.chkReverse.Location = new System.Drawing.Point(5, 136);
			this.chkReverse.Name = "chkReverse";
			this.chkReverse.TabIndex = 3;
			this.chkReverse.Properties.Caption = "Reverse";
			//
			// txtForceAMFormat
			//
			this.txtForceAMFormat.EditValue = "";
			this.txtForceAMFormat.Location = new System.Drawing.Point(5, 160);
			this.txtForceAMFormat.Name = "txtForceAMFormat";
			this.txtForceAMFormat.TabIndex = 4;
			this.txtForceAMFormat.Title = "ForceAMFormat";
			this.txtForceAMFormat.Properties.Mask.EditMask = "n0";
			this.txtForceAMFormat.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
			this.txtForceAMFormat.Properties.Mask.UseMaskAsDisplayFormat = true;
			//
			// chkOffOnRestore
			//
			this.chkOffOnRestore.Location = new System.Drawing.Point(5, 216);
			this.chkOffOnRestore.Name = "chkOffOnRestore";
			this.chkOffOnRestore.TabIndex = 5;
			this.chkOffOnRestore.Properties.Caption = "OffOnRestore";
			//
			// chkExternal
			//
			this.chkExternal.Location = new System.Drawing.Point(5, 256);
			this.chkExternal.Name = "chkExternal";
			this.chkExternal.TabIndex = 6;
			this.chkExternal.Properties.Caption = "External";
			//
			// txtNotes
			//
			this.txtNotes.EditValue = "";
			this.txtNotes.Location = new System.Drawing.Point(5, 280);
			this.txtNotes.Name = "txtNotes";
			this.txtNotes.TabIndex = 7;
			this.txtNotes.Title = "Notes";
			//
			// chkAlwaysToMAS
			//
			this.chkAlwaysToMAS.Location = new System.Drawing.Point(160, 16);
			this.chkAlwaysToMAS.Name = "chkAlwaysToMAS";
			this.chkAlwaysToMAS.TabIndex = 8;
			this.chkAlwaysToMAS.Properties.Caption = "AlwaysToMAS";
			//
			// txtPanelZoneID
			//
			this.txtPanelZoneID.EditValue = "";
			this.txtPanelZoneID.Location = new System.Drawing.Point(160, 40);
			this.txtPanelZoneID.Name = "txtPanelZoneID";
			this.txtPanelZoneID.TabIndex = 9;
			this.txtPanelZoneID.Title = "PanelZoneID";
			this.txtPanelZoneID.Properties.Mask.EditMask = "n0";
			this.txtPanelZoneID.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
			this.txtPanelZoneID.Properties.Mask.UseMaskAsDisplayFormat = true;
			//
			// chkLocked
			//
			this.chkLocked.Location = new System.Drawing.Point(160, 96);
			this.chkLocked.Name = "chkLocked";
			this.chkLocked.TabIndex = 10;
			this.chkLocked.Properties.Caption = "Locked";
			//
			// txtACPanel
			//
			this.txtACPanel.EditValue = "";
			this.txtACPanel.Location = new System.Drawing.Point(160, 120);
			this.txtACPanel.Name = "txtACPanel";
			this.txtACPanel.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] 
				{
					new DevExpress.XtraEditors.Controls.EditorButton()
				});
			this.txtACPanel.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
			this.txtACPanel.ReadOnly = false;
			this.txtACPanel.TabIndex = 11;
			this.txtACPanel.Title = "ACPanel";
			this.txtACPanel.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.txtACPanel_ButtonClick);
			//
			// FormDetailACInput
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.Name = "FormDetailACInput";
			this.Text = "ACInput Detail";
			((System.ComponentModel.ISupportInitialize)(this.pnlButtons)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pnlContent)).EndInit();
			this.pnlContent.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.txtInputID.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtDescription.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtDebounce.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.chkReverse.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtForceAMFormat.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.chkOffOnRestore.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.chkExternal.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtNotes.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.chkAlwaysToMAS.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtPanelZoneID.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.chkLocked.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtACPanel.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.grdACInputGroupInputMap)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.grdACInputGroupInputMapView)).EndInit();
			this.ResumeLayout(false);
		}

		#endregion

		private Cheke.WinCtrl.Common.TextEditEx txtInputID;
		private Cheke.WinCtrl.Common.TextEditEx txtDescription;
		private Cheke.WinCtrl.Common.TextEditEx txtDebounce;
		private Cheke.WinCtrl.Common.CheckEditEx chkReverse;
		private Cheke.WinCtrl.Common.TextEditEx txtForceAMFormat;
		private Cheke.WinCtrl.Common.CheckEditEx chkOffOnRestore;
		private Cheke.WinCtrl.Common.CheckEditEx chkExternal;
		private Cheke.WinCtrl.Common.MemoEditEx txtNotes;
		private Cheke.WinCtrl.Common.CheckEditEx chkAlwaysToMAS;
		private Cheke.WinCtrl.Common.TextEditEx txtPanelZoneID;
		private Cheke.WinCtrl.Common.CheckEditEx chkLocked;
		private Cheke.WinCtrl.Common.ButtonEditEx txtACPanel;
		private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
		private DevExpress.XtraTab.XtraTabPage tabDetail;
		private DevExpress.XtraTab.XtraTabPage tabACInputGroupInputMap;
		private DevExpress.XtraGrid.GridControl grdACInputGroupInputMap;
		private DevExpress.XtraGrid.Views.Grid.GridView grdACInputGroupInputMapView;
	}
}
