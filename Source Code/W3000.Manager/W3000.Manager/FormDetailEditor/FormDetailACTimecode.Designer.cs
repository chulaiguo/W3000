namespace W3000.Manager.FormDetailEditor
{
	public partial class FormDetailACTimecode
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
			this.txtTCID = new Cheke.WinCtrl.Common.TextEditEx();
			this.txtSummary = new Cheke.WinCtrl.Common.MemoEditEx();
			this.txtNotes = new Cheke.WinCtrl.Common.MemoEditEx();
			this.txtBDBuilding = new Cheke.WinCtrl.Common.ButtonEditEx();
			this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
			this.tabDetail = new DevExpress.XtraTab.XtraTabPage();
			this.tabACAccessLevelDetail = new DevExpress.XtraTab.XtraTabPage();
			this.grdACAccessLevelDetail = new DevExpress.XtraGrid.GridControl();
			this.grdACAccessLevelDetailView = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.tabACTimecodeIntervalMap = new DevExpress.XtraTab.XtraTabPage();
			this.grdACTimecodeIntervalMap = new DevExpress.XtraGrid.GridControl();
			this.grdACTimecodeIntervalMapView = new DevExpress.XtraGrid.Views.Grid.GridView();
			((System.ComponentModel.ISupportInitialize)(this.pnlButtons)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pnlContent)).BeginInit();
			this.pnlContent.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.txtTCID.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtSummary.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtNotes.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtBDBuilding.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.grdACAccessLevelDetail)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.grdACAccessLevelDetailView)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.grdACTimecodeIntervalMap)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.grdACTimecodeIntervalMapView)).BeginInit();
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
			this.tabDetail,this.tabACAccessLevelDetail,this.tabACTimecodeIntervalMap});
			this.xtraTabControl1.SelectedPageChanged += new DevExpress.XtraTab.TabPageChangedEventHandler(this.xtraTabControl1_SelectedPageChanged);
			//
			// tabDetail
			//
			this.tabDetail.Controls.Add(this.txtTCID);
			this.tabDetail.Controls.Add(this.txtSummary);
			this.tabDetail.Controls.Add(this.txtNotes);
			this.tabDetail.Controls.Add(this.txtBDBuilding);
			this.tabDetail.Name = "tabDetail";
			this.tabDetail.Text = "Detail";
			//
			// tabACAccessLevelDetail
			//
			this.tabACAccessLevelDetail.Controls.Add(this.grdACAccessLevelDetail);
			this.tabACAccessLevelDetail.Name = "tabACAccessLevelDetail";
			this.tabACAccessLevelDetail.Text = "ACAccessLevelDetail";
			this.tabACAccessLevelDetail.Enter += new System.EventHandler(this.tabACAccessLevelDetail_Enter);
			//
			// tabACTimecodeIntervalMap
			//
			this.tabACTimecodeIntervalMap.Controls.Add(this.grdACTimecodeIntervalMap);
			this.tabACTimecodeIntervalMap.Name = "tabACTimecodeIntervalMap";
			this.tabACTimecodeIntervalMap.Text = "ACTimecodeIntervalMap";
			this.tabACTimecodeIntervalMap.Enter += new System.EventHandler(this.tabACTimecodeIntervalMap_Enter);
			//
			// grdACAccessLevelDetail
			//
			this.grdACAccessLevelDetail.Dock = System.Windows.Forms.DockStyle.Fill;
			this.grdACAccessLevelDetail.MainView = this.grdACAccessLevelDetailView;
			this.grdACAccessLevelDetail.Name = "grdACAccessLevelDetail";
			this.grdACAccessLevelDetail.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {this.grdACAccessLevelDetailView});
			//
			// grdACAccessLevelDetailView
			//
			this.grdACAccessLevelDetailView.GridControl = this.grdACAccessLevelDetail;
			this.grdACAccessLevelDetailView.Name = "grdACAccessLevelDetailView";
			//
			// grdACTimecodeIntervalMap
			//
			this.grdACTimecodeIntervalMap.Dock = System.Windows.Forms.DockStyle.Fill;
			this.grdACTimecodeIntervalMap.MainView = this.grdACTimecodeIntervalMapView;
			this.grdACTimecodeIntervalMap.Name = "grdACTimecodeIntervalMap";
			this.grdACTimecodeIntervalMap.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {this.grdACTimecodeIntervalMapView});
			//
			// grdACTimecodeIntervalMapView
			//
			this.grdACTimecodeIntervalMapView.GridControl = this.grdACTimecodeIntervalMap;
			this.grdACTimecodeIntervalMapView.Name = "grdACTimecodeIntervalMapView";
			//
			// txtTCID
			//
			this.txtTCID.EditValue = "";
			this.txtTCID.Location = new System.Drawing.Point(5, 0);
			this.txtTCID.Name = "txtTCID";
			this.txtTCID.TabIndex = 0;
			this.txtTCID.Title = "TCID";
			this.txtTCID.Properties.Mask.EditMask = "n0";
			this.txtTCID.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
			this.txtTCID.Properties.Mask.UseMaskAsDisplayFormat = true;
			//
			// txtSummary
			//
			this.txtSummary.EditValue = "";
			this.txtSummary.Location = new System.Drawing.Point(5, 40);
			this.txtSummary.Name = "txtSummary";
			this.txtSummary.TabIndex = 1;
			this.txtSummary.Title = "Summary";
			//
			// txtNotes
			//
			this.txtNotes.EditValue = "";
			this.txtNotes.Location = new System.Drawing.Point(5, 200);
			this.txtNotes.Name = "txtNotes";
			this.txtNotes.TabIndex = 2;
			this.txtNotes.Title = "Notes";
			//
			// txtBDBuilding
			//
			this.txtBDBuilding.EditValue = "";
			this.txtBDBuilding.Location = new System.Drawing.Point(160, 0);
			this.txtBDBuilding.Name = "txtBDBuilding";
			this.txtBDBuilding.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] 
				{
					new DevExpress.XtraEditors.Controls.EditorButton()
				});
			this.txtBDBuilding.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
			this.txtBDBuilding.ReadOnly = false;
			this.txtBDBuilding.TabIndex = 3;
			this.txtBDBuilding.Title = "BDBuilding";
			this.txtBDBuilding.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.txtBDBuilding_ButtonClick);
			//
			// FormDetailACTimecode
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.Name = "FormDetailACTimecode";
			this.Text = "ACTimecode Detail";
			((System.ComponentModel.ISupportInitialize)(this.pnlButtons)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pnlContent)).EndInit();
			this.pnlContent.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.txtTCID.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtSummary.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtNotes.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtBDBuilding.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.grdACAccessLevelDetail)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.grdACAccessLevelDetailView)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.grdACTimecodeIntervalMap)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.grdACTimecodeIntervalMapView)).EndInit();
			this.ResumeLayout(false);
		}

		#endregion

		private Cheke.WinCtrl.Common.TextEditEx txtTCID;
		private Cheke.WinCtrl.Common.MemoEditEx txtSummary;
		private Cheke.WinCtrl.Common.MemoEditEx txtNotes;
		private Cheke.WinCtrl.Common.ButtonEditEx txtBDBuilding;
		private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
		private DevExpress.XtraTab.XtraTabPage tabDetail;
		private DevExpress.XtraTab.XtraTabPage tabACAccessLevelDetail;
		private DevExpress.XtraGrid.GridControl grdACAccessLevelDetail;
		private DevExpress.XtraGrid.Views.Grid.GridView grdACAccessLevelDetailView;
		private DevExpress.XtraTab.XtraTabPage tabACTimecodeIntervalMap;
		private DevExpress.XtraGrid.GridControl grdACTimecodeIntervalMap;
		private DevExpress.XtraGrid.Views.Grid.GridView grdACTimecodeIntervalMapView;
	}
}
