namespace W3000.Manager.FormDetailEditor
{
	public partial class FormDetailACInterval
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
			this.txtIVID = new Cheke.WinCtrl.Common.TextEditEx();
			this.txtBegin = new Cheke.WinCtrl.Common.TextEditEx();
			this.txtEnd = new Cheke.WinCtrl.Common.TextEditEx();
			this.chkSun = new Cheke.WinCtrl.Common.CheckEditEx();
			this.chkMon = new Cheke.WinCtrl.Common.CheckEditEx();
			this.chkTue = new Cheke.WinCtrl.Common.CheckEditEx();
			this.chkWed = new Cheke.WinCtrl.Common.CheckEditEx();
			this.chkThu = new Cheke.WinCtrl.Common.CheckEditEx();
			this.chkFri = new Cheke.WinCtrl.Common.CheckEditEx();
			this.chkSat = new Cheke.WinCtrl.Common.CheckEditEx();
			this.chkHol = new Cheke.WinCtrl.Common.CheckEditEx();
			this.txtBDBuilding = new Cheke.WinCtrl.Common.ButtonEditEx();
			this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
			this.tabDetail = new DevExpress.XtraTab.XtraTabPage();
			this.tabACIntvalHolidayMap = new DevExpress.XtraTab.XtraTabPage();
			this.grdACIntvalHolidayMap = new DevExpress.XtraGrid.GridControl();
			this.grdACIntvalHolidayMapView = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.tabACTimecodeIntervalMap = new DevExpress.XtraTab.XtraTabPage();
			this.grdACTimecodeIntervalMap = new DevExpress.XtraGrid.GridControl();
			this.grdACTimecodeIntervalMapView = new DevExpress.XtraGrid.Views.Grid.GridView();
			((System.ComponentModel.ISupportInitialize)(this.pnlButtons)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pnlContent)).BeginInit();
			this.pnlContent.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.txtIVID.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtBegin.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtEnd.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.chkSun.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.chkMon.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.chkTue.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.chkWed.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.chkThu.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.chkFri.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.chkSat.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.chkHol.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtBDBuilding.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.grdACIntvalHolidayMap)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.grdACIntvalHolidayMapView)).BeginInit();
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
			this.tabDetail,this.tabACIntvalHolidayMap,this.tabACTimecodeIntervalMap});
			this.xtraTabControl1.SelectedPageChanged += new DevExpress.XtraTab.TabPageChangedEventHandler(this.xtraTabControl1_SelectedPageChanged);
			//
			// tabDetail
			//
			this.tabDetail.Controls.Add(this.txtIVID);
			this.tabDetail.Controls.Add(this.txtBegin);
			this.tabDetail.Controls.Add(this.txtEnd);
			this.tabDetail.Controls.Add(this.chkSun);
			this.tabDetail.Controls.Add(this.chkMon);
			this.tabDetail.Controls.Add(this.chkTue);
			this.tabDetail.Controls.Add(this.chkWed);
			this.tabDetail.Controls.Add(this.chkThu);
			this.tabDetail.Controls.Add(this.chkFri);
			this.tabDetail.Controls.Add(this.chkSat);
			this.tabDetail.Controls.Add(this.chkHol);
			this.tabDetail.Controls.Add(this.txtBDBuilding);
			this.tabDetail.Name = "tabDetail";
			this.tabDetail.Text = "Detail";
			//
			// tabACIntvalHolidayMap
			//
			this.tabACIntvalHolidayMap.Controls.Add(this.grdACIntvalHolidayMap);
			this.tabACIntvalHolidayMap.Name = "tabACIntvalHolidayMap";
			this.tabACIntvalHolidayMap.Text = "ACIntvalHolidayMap";
			this.tabACIntvalHolidayMap.Enter += new System.EventHandler(this.tabACIntvalHolidayMap_Enter);
			//
			// tabACTimecodeIntervalMap
			//
			this.tabACTimecodeIntervalMap.Controls.Add(this.grdACTimecodeIntervalMap);
			this.tabACTimecodeIntervalMap.Name = "tabACTimecodeIntervalMap";
			this.tabACTimecodeIntervalMap.Text = "ACTimecodeIntervalMap";
			this.tabACTimecodeIntervalMap.Enter += new System.EventHandler(this.tabACTimecodeIntervalMap_Enter);
			//
			// grdACIntvalHolidayMap
			//
			this.grdACIntvalHolidayMap.Dock = System.Windows.Forms.DockStyle.Fill;
			this.grdACIntvalHolidayMap.MainView = this.grdACIntvalHolidayMapView;
			this.grdACIntvalHolidayMap.Name = "grdACIntvalHolidayMap";
			this.grdACIntvalHolidayMap.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {this.grdACIntvalHolidayMapView});
			//
			// grdACIntvalHolidayMapView
			//
			this.grdACIntvalHolidayMapView.GridControl = this.grdACIntvalHolidayMap;
			this.grdACIntvalHolidayMapView.Name = "grdACIntvalHolidayMapView";
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
			// txtIVID
			//
			this.txtIVID.EditValue = "";
			this.txtIVID.Location = new System.Drawing.Point(5, 0);
			this.txtIVID.Name = "txtIVID";
			this.txtIVID.TabIndex = 0;
			this.txtIVID.Title = "IVID";
			this.txtIVID.Properties.Mask.EditMask = "n0";
			this.txtIVID.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
			this.txtIVID.Properties.Mask.UseMaskAsDisplayFormat = true;
			//
			// txtBegin
			//
			this.txtBegin.EditValue = "";
			this.txtBegin.Location = new System.Drawing.Point(5, 40);
			this.txtBegin.Name = "txtBegin";
			this.txtBegin.TabIndex = 1;
			this.txtBegin.Title = "Begin";
			//
			// txtEnd
			//
			this.txtEnd.EditValue = "";
			this.txtEnd.Location = new System.Drawing.Point(5, 80);
			this.txtEnd.Name = "txtEnd";
			this.txtEnd.TabIndex = 2;
			this.txtEnd.Title = "End";
			//
			// chkSun
			//
			this.chkSun.Location = new System.Drawing.Point(5, 136);
			this.chkSun.Name = "chkSun";
			this.chkSun.TabIndex = 3;
			this.chkSun.Properties.Caption = "Sun";
			//
			// chkMon
			//
			this.chkMon.Location = new System.Drawing.Point(5, 176);
			this.chkMon.Name = "chkMon";
			this.chkMon.TabIndex = 4;
			this.chkMon.Properties.Caption = "Mon";
			//
			// chkTue
			//
			this.chkTue.Location = new System.Drawing.Point(5, 216);
			this.chkTue.Name = "chkTue";
			this.chkTue.TabIndex = 5;
			this.chkTue.Properties.Caption = "Tue";
			//
			// chkWed
			//
			this.chkWed.Location = new System.Drawing.Point(5, 256);
			this.chkWed.Name = "chkWed";
			this.chkWed.TabIndex = 6;
			this.chkWed.Properties.Caption = "Wed";
			//
			// chkThu
			//
			this.chkThu.Location = new System.Drawing.Point(5, 296);
			this.chkThu.Name = "chkThu";
			this.chkThu.TabIndex = 7;
			this.chkThu.Properties.Caption = "Thu";
			//
			// chkFri
			//
			this.chkFri.Location = new System.Drawing.Point(160, 16);
			this.chkFri.Name = "chkFri";
			this.chkFri.TabIndex = 8;
			this.chkFri.Properties.Caption = "Fri";
			//
			// chkSat
			//
			this.chkSat.Location = new System.Drawing.Point(160, 56);
			this.chkSat.Name = "chkSat";
			this.chkSat.TabIndex = 9;
			this.chkSat.Properties.Caption = "Sat";
			//
			// chkHol
			//
			this.chkHol.Location = new System.Drawing.Point(160, 96);
			this.chkHol.Name = "chkHol";
			this.chkHol.TabIndex = 10;
			this.chkHol.Properties.Caption = "Hol";
			//
			// txtBDBuilding
			//
			this.txtBDBuilding.EditValue = "";
			this.txtBDBuilding.Location = new System.Drawing.Point(160, 120);
			this.txtBDBuilding.Name = "txtBDBuilding";
			this.txtBDBuilding.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] 
				{
					new DevExpress.XtraEditors.Controls.EditorButton()
				});
			this.txtBDBuilding.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
			this.txtBDBuilding.ReadOnly = false;
			this.txtBDBuilding.TabIndex = 11;
			this.txtBDBuilding.Title = "BDBuilding";
			this.txtBDBuilding.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.txtBDBuilding_ButtonClick);
			//
			// FormDetailACInterval
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.Name = "FormDetailACInterval";
			this.Text = "ACInterval Detail";
			((System.ComponentModel.ISupportInitialize)(this.pnlButtons)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pnlContent)).EndInit();
			this.pnlContent.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.txtIVID.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtBegin.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtEnd.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.chkSun.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.chkMon.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.chkTue.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.chkWed.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.chkThu.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.chkFri.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.chkSat.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.chkHol.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtBDBuilding.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.grdACIntvalHolidayMap)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.grdACIntvalHolidayMapView)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.grdACTimecodeIntervalMap)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.grdACTimecodeIntervalMapView)).EndInit();
			this.ResumeLayout(false);
		}

		#endregion

		private Cheke.WinCtrl.Common.TextEditEx txtIVID;
		private Cheke.WinCtrl.Common.TextEditEx txtBegin;
		private Cheke.WinCtrl.Common.TextEditEx txtEnd;
		private Cheke.WinCtrl.Common.CheckEditEx chkSun;
		private Cheke.WinCtrl.Common.CheckEditEx chkMon;
		private Cheke.WinCtrl.Common.CheckEditEx chkTue;
		private Cheke.WinCtrl.Common.CheckEditEx chkWed;
		private Cheke.WinCtrl.Common.CheckEditEx chkThu;
		private Cheke.WinCtrl.Common.CheckEditEx chkFri;
		private Cheke.WinCtrl.Common.CheckEditEx chkSat;
		private Cheke.WinCtrl.Common.CheckEditEx chkHol;
		private Cheke.WinCtrl.Common.ButtonEditEx txtBDBuilding;
		private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
		private DevExpress.XtraTab.XtraTabPage tabDetail;
		private DevExpress.XtraTab.XtraTabPage tabACIntvalHolidayMap;
		private DevExpress.XtraGrid.GridControl grdACIntvalHolidayMap;
		private DevExpress.XtraGrid.Views.Grid.GridView grdACIntvalHolidayMapView;
		private DevExpress.XtraTab.XtraTabPage tabACTimecodeIntervalMap;
		private DevExpress.XtraGrid.GridControl grdACTimecodeIntervalMap;
		private DevExpress.XtraGrid.Views.Grid.GridView grdACTimecodeIntervalMapView;
	}
}
