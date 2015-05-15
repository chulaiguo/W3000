namespace W3000.Manager.FormDetailEditor
{
	public partial class FormDetailACOutputGroup
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
			this.txtGroupID = new Cheke.WinCtrl.Common.TextEditEx();
			this.txtSummary = new Cheke.WinCtrl.Common.MemoEditEx();
			this.txtACPanel = new Cheke.WinCtrl.Common.ButtonEditEx();
			this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
			this.tabDetail = new DevExpress.XtraTab.XtraTabPage();
			this.tabACOutputGroupMainZoneMap = new DevExpress.XtraTab.XtraTabPage();
			this.grdACOutputGroupMainZoneMap = new DevExpress.XtraGrid.GridControl();
			this.grdACOutputGroupMainZoneMapView = new DevExpress.XtraGrid.Views.Grid.GridView();
			((System.ComponentModel.ISupportInitialize)(this.pnlButtons)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pnlContent)).BeginInit();
			this.pnlContent.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.txtGroupID.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtSummary.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtACPanel.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.grdACOutputGroupMainZoneMap)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.grdACOutputGroupMainZoneMapView)).BeginInit();
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
			this.tabDetail,this.tabACOutputGroupMainZoneMap});
			this.xtraTabControl1.SelectedPageChanged += new DevExpress.XtraTab.TabPageChangedEventHandler(this.xtraTabControl1_SelectedPageChanged);
			//
			// tabDetail
			//
			this.tabDetail.Controls.Add(this.txtGroupID);
			this.tabDetail.Controls.Add(this.txtSummary);
			this.tabDetail.Controls.Add(this.txtACPanel);
			this.tabDetail.Name = "tabDetail";
			this.tabDetail.Text = "Detail";
			//
			// tabACOutputGroupMainZoneMap
			//
			this.tabACOutputGroupMainZoneMap.Controls.Add(this.grdACOutputGroupMainZoneMap);
			this.tabACOutputGroupMainZoneMap.Name = "tabACOutputGroupMainZoneMap";
			this.tabACOutputGroupMainZoneMap.Text = "ACOutputGroupMainZoneMap";
			this.tabACOutputGroupMainZoneMap.Enter += new System.EventHandler(this.tabACOutputGroupMainZoneMap_Enter);
			//
			// grdACOutputGroupMainZoneMap
			//
			this.grdACOutputGroupMainZoneMap.Dock = System.Windows.Forms.DockStyle.Fill;
			this.grdACOutputGroupMainZoneMap.MainView = this.grdACOutputGroupMainZoneMapView;
			this.grdACOutputGroupMainZoneMap.Name = "grdACOutputGroupMainZoneMap";
			this.grdACOutputGroupMainZoneMap.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {this.grdACOutputGroupMainZoneMapView});
			//
			// grdACOutputGroupMainZoneMapView
			//
			this.grdACOutputGroupMainZoneMapView.GridControl = this.grdACOutputGroupMainZoneMap;
			this.grdACOutputGroupMainZoneMapView.Name = "grdACOutputGroupMainZoneMapView";
			//
			// txtGroupID
			//
			this.txtGroupID.EditValue = "";
			this.txtGroupID.Location = new System.Drawing.Point(5, 0);
			this.txtGroupID.Name = "txtGroupID";
			this.txtGroupID.TabIndex = 0;
			this.txtGroupID.Title = "GroupID";
			this.txtGroupID.Properties.Mask.EditMask = "n0";
			this.txtGroupID.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
			this.txtGroupID.Properties.Mask.UseMaskAsDisplayFormat = true;
			//
			// txtSummary
			//
			this.txtSummary.EditValue = "";
			this.txtSummary.Location = new System.Drawing.Point(5, 40);
			this.txtSummary.Name = "txtSummary";
			this.txtSummary.TabIndex = 1;
			this.txtSummary.Title = "Summary";
			//
			// txtACPanel
			//
			this.txtACPanel.EditValue = "";
			this.txtACPanel.Location = new System.Drawing.Point(5, 200);
			this.txtACPanel.Name = "txtACPanel";
			this.txtACPanel.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] 
				{
					new DevExpress.XtraEditors.Controls.EditorButton()
				});
			this.txtACPanel.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
			this.txtACPanel.ReadOnly = false;
			this.txtACPanel.TabIndex = 2;
			this.txtACPanel.Title = "ACPanel";
			this.txtACPanel.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.txtACPanel_ButtonClick);
			//
			// FormDetailACOutputGroup
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.Name = "FormDetailACOutputGroup";
			this.Text = "ACOutputGroup Detail";
			((System.ComponentModel.ISupportInitialize)(this.pnlButtons)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pnlContent)).EndInit();
			this.pnlContent.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.txtGroupID.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtSummary.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtACPanel.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.grdACOutputGroupMainZoneMap)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.grdACOutputGroupMainZoneMapView)).EndInit();
			this.ResumeLayout(false);
		}

		#endregion

		private Cheke.WinCtrl.Common.TextEditEx txtGroupID;
		private Cheke.WinCtrl.Common.MemoEditEx txtSummary;
		private Cheke.WinCtrl.Common.ButtonEditEx txtACPanel;
		private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
		private DevExpress.XtraTab.XtraTabPage tabDetail;
		private DevExpress.XtraTab.XtraTabPage tabACOutputGroupMainZoneMap;
		private DevExpress.XtraGrid.GridControl grdACOutputGroupMainZoneMap;
		private DevExpress.XtraGrid.Views.Grid.GridView grdACOutputGroupMainZoneMapView;
	}
}
