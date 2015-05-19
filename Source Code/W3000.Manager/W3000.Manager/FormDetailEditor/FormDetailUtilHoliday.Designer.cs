namespace W3000.Manager.FormDetailEditor
{
	public partial class FormDetailUtilHoliday
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
			this.txtCountryID = new Cheke.WinCtrl.Common.TextEditEx();
			this.txtHoliday = new Cheke.WinCtrl.Common.TextEditEx();
			this.dateDate = new Cheke.WinCtrl.Common.DateEditEx();
			this.chkMajor = new Cheke.WinCtrl.Common.CheckEditEx();
			this.chkFederal = new Cheke.WinCtrl.Common.CheckEditEx();
			this.chkDefault = new Cheke.WinCtrl.Common.CheckEditEx();
			this.txtActionID = new Cheke.WinCtrl.Common.TextEditEx();
			this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
			this.tabDetail = new DevExpress.XtraTab.XtraTabPage();
			this.tabBDTenantHolidayMap = new DevExpress.XtraTab.XtraTabPage();
			this.grdBDTenantHolidayMap = new DevExpress.XtraGrid.GridControl();
			this.grdBDTenantHolidayMapView = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.tabBDBuildingHolidayMap = new DevExpress.XtraTab.XtraTabPage();
			this.grdBDBuildingHolidayMap = new DevExpress.XtraGrid.GridControl();
			this.grdBDBuildingHolidayMapView = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.tabACPanelHolidayMap = new DevExpress.XtraTab.XtraTabPage();
			this.grdACPanelHolidayMap = new DevExpress.XtraGrid.GridControl();
			this.grdACPanelHolidayMapView = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.tabACIntvalHolidayMap = new DevExpress.XtraTab.XtraTabPage();
			this.grdACIntvalHolidayMap = new DevExpress.XtraGrid.GridControl();
			this.grdACIntvalHolidayMapView = new DevExpress.XtraGrid.Views.Grid.GridView();
			((System.ComponentModel.ISupportInitialize)(this.pnlButtons)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pnlContent)).BeginInit();
			this.pnlContent.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.txtCountryID.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtHoliday.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dateDate.Properties.VistaTimeProperties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dateDate.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.chkMajor.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.chkFederal.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.chkDefault.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtActionID.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.grdBDTenantHolidayMap)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.grdBDTenantHolidayMapView)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.grdBDBuildingHolidayMap)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.grdBDBuildingHolidayMapView)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.grdACPanelHolidayMap)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.grdACPanelHolidayMapView)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.grdACIntvalHolidayMap)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.grdACIntvalHolidayMapView)).BeginInit();
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
			this.tabDetail,this.tabBDTenantHolidayMap,this.tabBDBuildingHolidayMap,this.tabACPanelHolidayMap,this.tabACIntvalHolidayMap});
			this.xtraTabControl1.SelectedPageChanged += new DevExpress.XtraTab.TabPageChangedEventHandler(this.xtraTabControl1_SelectedPageChanged);
			//
			// tabDetail
			//
			this.tabDetail.Controls.Add(this.txtCountryID);
			this.tabDetail.Controls.Add(this.txtHoliday);
			this.tabDetail.Controls.Add(this.dateDate);
			this.tabDetail.Controls.Add(this.chkMajor);
			this.tabDetail.Controls.Add(this.chkFederal);
			this.tabDetail.Controls.Add(this.chkDefault);
			this.tabDetail.Controls.Add(this.txtActionID);
			this.tabDetail.Name = "tabDetail";
			this.tabDetail.Text = "Detail";
			//
			// tabBDTenantHolidayMap
			//
			this.tabBDTenantHolidayMap.Controls.Add(this.grdBDTenantHolidayMap);
			this.tabBDTenantHolidayMap.Name = "tabBDTenantHolidayMap";
			this.tabBDTenantHolidayMap.Text = "BDTenantHolidayMap";
			this.tabBDTenantHolidayMap.Enter += new System.EventHandler(this.tabBDTenantHolidayMap_Enter);
			//
			// tabBDBuildingHolidayMap
			//
			this.tabBDBuildingHolidayMap.Controls.Add(this.grdBDBuildingHolidayMap);
			this.tabBDBuildingHolidayMap.Name = "tabBDBuildingHolidayMap";
			this.tabBDBuildingHolidayMap.Text = "BDBuildingHolidayMap";
			this.tabBDBuildingHolidayMap.Enter += new System.EventHandler(this.tabBDBuildingHolidayMap_Enter);
			//
			// tabACPanelHolidayMap
			//
			this.tabACPanelHolidayMap.Controls.Add(this.grdACPanelHolidayMap);
			this.tabACPanelHolidayMap.Name = "tabACPanelHolidayMap";
			this.tabACPanelHolidayMap.Text = "ACPanelHolidayMap";
			this.tabACPanelHolidayMap.Enter += new System.EventHandler(this.tabACPanelHolidayMap_Enter);
			//
			// tabACIntvalHolidayMap
			//
			this.tabACIntvalHolidayMap.Controls.Add(this.grdACIntvalHolidayMap);
			this.tabACIntvalHolidayMap.Name = "tabACIntvalHolidayMap";
			this.tabACIntvalHolidayMap.Text = "ACIntvalHolidayMap";
			this.tabACIntvalHolidayMap.Enter += new System.EventHandler(this.tabACIntvalHolidayMap_Enter);
			//
			// grdBDTenantHolidayMap
			//
			this.grdBDTenantHolidayMap.Dock = System.Windows.Forms.DockStyle.Fill;
			this.grdBDTenantHolidayMap.MainView = this.grdBDTenantHolidayMapView;
			this.grdBDTenantHolidayMap.Name = "grdBDTenantHolidayMap";
			this.grdBDTenantHolidayMap.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {this.grdBDTenantHolidayMapView});
			//
			// grdBDTenantHolidayMapView
			//
			this.grdBDTenantHolidayMapView.GridControl = this.grdBDTenantHolidayMap;
			this.grdBDTenantHolidayMapView.Name = "grdBDTenantHolidayMapView";
			//
			// grdBDBuildingHolidayMap
			//
			this.grdBDBuildingHolidayMap.Dock = System.Windows.Forms.DockStyle.Fill;
			this.grdBDBuildingHolidayMap.MainView = this.grdBDBuildingHolidayMapView;
			this.grdBDBuildingHolidayMap.Name = "grdBDBuildingHolidayMap";
			this.grdBDBuildingHolidayMap.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {this.grdBDBuildingHolidayMapView});
			//
			// grdBDBuildingHolidayMapView
			//
			this.grdBDBuildingHolidayMapView.GridControl = this.grdBDBuildingHolidayMap;
			this.grdBDBuildingHolidayMapView.Name = "grdBDBuildingHolidayMapView";
			//
			// grdACPanelHolidayMap
			//
			this.grdACPanelHolidayMap.Dock = System.Windows.Forms.DockStyle.Fill;
			this.grdACPanelHolidayMap.MainView = this.grdACPanelHolidayMapView;
			this.grdACPanelHolidayMap.Name = "grdACPanelHolidayMap";
			this.grdACPanelHolidayMap.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {this.grdACPanelHolidayMapView});
			//
			// grdACPanelHolidayMapView
			//
			this.grdACPanelHolidayMapView.GridControl = this.grdACPanelHolidayMap;
			this.grdACPanelHolidayMapView.Name = "grdACPanelHolidayMapView";
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
			// txtCountryID
			//
			this.txtCountryID.EditValue = "";
			this.txtCountryID.Location = new System.Drawing.Point(5, 0);
			this.txtCountryID.Name = "txtCountryID";
			this.txtCountryID.TabIndex = 0;
			this.txtCountryID.Title = "CountryID";
			this.txtCountryID.Properties.Mask.EditMask = "n0";
			this.txtCountryID.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
			this.txtCountryID.Properties.Mask.UseMaskAsDisplayFormat = true;
			//
			// txtHoliday
			//
			this.txtHoliday.EditValue = "";
			this.txtHoliday.Location = new System.Drawing.Point(5, 40);
			this.txtHoliday.Name = "txtHoliday";
			this.txtHoliday.TabIndex = 1;
			this.txtHoliday.Title = "Holiday";
			//
			// dateDate
			//
			this.dateDate.EditValue =  new System.DateTime(2015, 1, 1, 0, 0, 0, 0);
			this.dateDate.Location = new System.Drawing.Point(5, 80);
			this.dateDate.Name = "dateDate";
			this.dateDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[]
				{
					new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)
				});
			this.dateDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[]
				{
					new DevExpress.XtraEditors.Controls.EditorButton()
				});
			this.dateDate.TabIndex = 2;
			this.dateDate.Title = "Date";
			//
			// chkMajor
			//
			this.chkMajor.Location = new System.Drawing.Point(5, 136);
			this.chkMajor.Name = "chkMajor";
			this.chkMajor.TabIndex = 3;
			this.chkMajor.Properties.Caption = "Major";
			//
			// chkFederal
			//
			this.chkFederal.Location = new System.Drawing.Point(5, 176);
			this.chkFederal.Name = "chkFederal";
			this.chkFederal.TabIndex = 4;
			this.chkFederal.Properties.Caption = "Federal";
			//
			// chkDefault
			//
			this.chkDefault.Location = new System.Drawing.Point(5, 216);
			this.chkDefault.Name = "chkDefault";
			this.chkDefault.TabIndex = 5;
			this.chkDefault.Properties.Caption = "Default";
			//
			// txtActionID
			//
			this.txtActionID.EditValue = "";
			this.txtActionID.Location = new System.Drawing.Point(5, 240);
			this.txtActionID.Name = "txtActionID";
			this.txtActionID.TabIndex = 6;
			this.txtActionID.Title = "ActionID";
			this.txtActionID.Properties.Mask.EditMask = "n0";
			this.txtActionID.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
			this.txtActionID.Properties.Mask.UseMaskAsDisplayFormat = true;
			//
			// FormDetailUtilHoliday
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.Name = "FormDetailUtilHoliday";
			this.Text = "UtilHoliday Detail";
			((System.ComponentModel.ISupportInitialize)(this.pnlButtons)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pnlContent)).EndInit();
			this.pnlContent.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.txtCountryID.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtHoliday.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dateDate.Properties.VistaTimeProperties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dateDate.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.chkMajor.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.chkFederal.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.chkDefault.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtActionID.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.grdBDTenantHolidayMap)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.grdBDTenantHolidayMapView)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.grdBDBuildingHolidayMap)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.grdBDBuildingHolidayMapView)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.grdACPanelHolidayMap)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.grdACPanelHolidayMapView)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.grdACIntvalHolidayMap)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.grdACIntvalHolidayMapView)).EndInit();
			this.ResumeLayout(false);
		}

		#endregion

		private Cheke.WinCtrl.Common.TextEditEx txtCountryID;
		private Cheke.WinCtrl.Common.TextEditEx txtHoliday;
		private Cheke.WinCtrl.Common.DateEditEx dateDate;
		private Cheke.WinCtrl.Common.CheckEditEx chkMajor;
		private Cheke.WinCtrl.Common.CheckEditEx chkFederal;
		private Cheke.WinCtrl.Common.CheckEditEx chkDefault;
		private Cheke.WinCtrl.Common.TextEditEx txtActionID;
		private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
		private DevExpress.XtraTab.XtraTabPage tabDetail;
		private DevExpress.XtraTab.XtraTabPage tabBDTenantHolidayMap;
		private DevExpress.XtraGrid.GridControl grdBDTenantHolidayMap;
		private DevExpress.XtraGrid.Views.Grid.GridView grdBDTenantHolidayMapView;
		private DevExpress.XtraTab.XtraTabPage tabBDBuildingHolidayMap;
		private DevExpress.XtraGrid.GridControl grdBDBuildingHolidayMap;
		private DevExpress.XtraGrid.Views.Grid.GridView grdBDBuildingHolidayMapView;
		private DevExpress.XtraTab.XtraTabPage tabACPanelHolidayMap;
		private DevExpress.XtraGrid.GridControl grdACPanelHolidayMap;
		private DevExpress.XtraGrid.Views.Grid.GridView grdACPanelHolidayMapView;
		private DevExpress.XtraTab.XtraTabPage tabACIntvalHolidayMap;
		private DevExpress.XtraGrid.GridControl grdACIntvalHolidayMap;
		private DevExpress.XtraGrid.Views.Grid.GridView grdACIntvalHolidayMapView;
	}
}
