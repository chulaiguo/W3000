namespace W3000.Manager.FormDetailEditor
{
	public partial class FormDetailACFunctionCard
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
			this.txtFunctionID = new Cheke.WinCtrl.Common.TextEditEx();
			this.txtFirstName = new Cheke.WinCtrl.Common.TextEditEx();
			this.txtLastName = new Cheke.WinCtrl.Common.TextEditEx();
			this.chkFIPS = new Cheke.WinCtrl.Common.CheckEditEx();
			this.txtPin = new Cheke.WinCtrl.Common.TextEditEx();
			this.dateValidFrom = new Cheke.WinCtrl.Common.DateEditEx();
			this.dateValidThru = new Cheke.WinCtrl.Common.DateEditEx();
			this.txtBDTenant = new Cheke.WinCtrl.Common.ButtonEditEx();
			this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
			this.tabDetail = new DevExpress.XtraTab.XtraTabPage();
			this.tabACPanelFunctionCardMap = new DevExpress.XtraTab.XtraTabPage();
			this.grdACPanelFunctionCardMap = new DevExpress.XtraGrid.GridControl();
			this.grdACPanelFunctionCardMapView = new DevExpress.XtraGrid.Views.Grid.GridView();
			((System.ComponentModel.ISupportInitialize)(this.pnlButtons)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pnlContent)).BeginInit();
			this.pnlContent.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.txtSitecode.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtEmbossed.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtEncoded.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtCardTypeID.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtFunctionID.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtFirstName.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtLastName.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.chkFIPS.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtPin.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dateValidFrom.Properties.VistaTimeProperties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dateValidFrom.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dateValidThru.Properties.VistaTimeProperties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dateValidThru.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtBDTenant.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.grdACPanelFunctionCardMap)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.grdACPanelFunctionCardMapView)).BeginInit();
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
			this.tabDetail,this.tabACPanelFunctionCardMap});
			this.xtraTabControl1.SelectedPageChanged += new DevExpress.XtraTab.TabPageChangedEventHandler(this.xtraTabControl1_SelectedPageChanged);
			//
			// tabDetail
			//
			this.tabDetail.Controls.Add(this.txtSitecode);
			this.tabDetail.Controls.Add(this.txtEmbossed);
			this.tabDetail.Controls.Add(this.txtEncoded);
			this.tabDetail.Controls.Add(this.txtCardTypeID);
			this.tabDetail.Controls.Add(this.txtFunctionID);
			this.tabDetail.Controls.Add(this.txtFirstName);
			this.tabDetail.Controls.Add(this.txtLastName);
			this.tabDetail.Controls.Add(this.chkFIPS);
			this.tabDetail.Controls.Add(this.txtPin);
			this.tabDetail.Controls.Add(this.dateValidFrom);
			this.tabDetail.Controls.Add(this.dateValidThru);
			this.tabDetail.Controls.Add(this.txtBDTenant);
			this.tabDetail.Name = "tabDetail";
			this.tabDetail.Text = "Detail";
			//
			// tabACPanelFunctionCardMap
			//
			this.tabACPanelFunctionCardMap.Controls.Add(this.grdACPanelFunctionCardMap);
			this.tabACPanelFunctionCardMap.Name = "tabACPanelFunctionCardMap";
			this.tabACPanelFunctionCardMap.Text = "ACPanelFunctionCardMap";
			this.tabACPanelFunctionCardMap.Enter += new System.EventHandler(this.tabACPanelFunctionCardMap_Enter);
			//
			// grdACPanelFunctionCardMap
			//
			this.grdACPanelFunctionCardMap.Dock = System.Windows.Forms.DockStyle.Fill;
			this.grdACPanelFunctionCardMap.MainView = this.grdACPanelFunctionCardMapView;
			this.grdACPanelFunctionCardMap.Name = "grdACPanelFunctionCardMap";
			this.grdACPanelFunctionCardMap.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {this.grdACPanelFunctionCardMapView});
			//
			// grdACPanelFunctionCardMapView
			//
			this.grdACPanelFunctionCardMapView.GridControl = this.grdACPanelFunctionCardMap;
			this.grdACPanelFunctionCardMapView.Name = "grdACPanelFunctionCardMapView";
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
			// txtFunctionID
			//
			this.txtFunctionID.EditValue = "";
			this.txtFunctionID.Location = new System.Drawing.Point(5, 160);
			this.txtFunctionID.Name = "txtFunctionID";
			this.txtFunctionID.TabIndex = 4;
			this.txtFunctionID.Title = "FunctionID";
			this.txtFunctionID.Properties.Mask.EditMask = "n0";
			this.txtFunctionID.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
			this.txtFunctionID.Properties.Mask.UseMaskAsDisplayFormat = true;
			//
			// txtFirstName
			//
			this.txtFirstName.EditValue = "";
			this.txtFirstName.Location = new System.Drawing.Point(5, 200);
			this.txtFirstName.Name = "txtFirstName";
			this.txtFirstName.TabIndex = 5;
			this.txtFirstName.Title = "FirstName";
			//
			// txtLastName
			//
			this.txtLastName.EditValue = "";
			this.txtLastName.Location = new System.Drawing.Point(5, 240);
			this.txtLastName.Name = "txtLastName";
			this.txtLastName.TabIndex = 6;
			this.txtLastName.Title = "LastName";
			//
			// chkFIPS
			//
			this.chkFIPS.Location = new System.Drawing.Point(5, 296);
			this.chkFIPS.Name = "chkFIPS";
			this.chkFIPS.TabIndex = 7;
			this.chkFIPS.Properties.Caption = "FIPS";
			//
			// txtPin
			//
			this.txtPin.EditValue = "";
			this.txtPin.Location = new System.Drawing.Point(160, 0);
			this.txtPin.Name = "txtPin";
			this.txtPin.TabIndex = 8;
			this.txtPin.Title = "Pin";
			this.txtPin.Properties.Mask.EditMask = "n0";
			this.txtPin.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
			this.txtPin.Properties.Mask.UseMaskAsDisplayFormat = true;
			//
			// dateValidFrom
			//
			this.dateValidFrom.EditValue =  new System.DateTime(2015, 1, 1, 0, 0, 0, 0);
			this.dateValidFrom.Location = new System.Drawing.Point(160, 40);
			this.dateValidFrom.Name = "dateValidFrom";
			this.dateValidFrom.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[]
				{
					new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)
				});
			this.dateValidFrom.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[]
				{
					new DevExpress.XtraEditors.Controls.EditorButton()
				});
			this.dateValidFrom.TabIndex = 9;
			this.dateValidFrom.Title = "ValidFrom";
			//
			// dateValidThru
			//
			this.dateValidThru.EditValue =  new System.DateTime(2015, 1, 1, 0, 0, 0, 0);
			this.dateValidThru.Location = new System.Drawing.Point(160, 80);
			this.dateValidThru.Name = "dateValidThru";
			this.dateValidThru.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[]
				{
					new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)
				});
			this.dateValidThru.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[]
				{
					new DevExpress.XtraEditors.Controls.EditorButton()
				});
			this.dateValidThru.TabIndex = 10;
			this.dateValidThru.Title = "ValidThru";
			//
			// txtBDTenant
			//
			this.txtBDTenant.EditValue = "";
			this.txtBDTenant.Location = new System.Drawing.Point(160, 120);
			this.txtBDTenant.Name = "txtBDTenant";
			this.txtBDTenant.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] 
				{
					new DevExpress.XtraEditors.Controls.EditorButton()
				});
			this.txtBDTenant.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
			this.txtBDTenant.ReadOnly = false;
			this.txtBDTenant.TabIndex = 11;
			this.txtBDTenant.Title = "BDTenant";
			this.txtBDTenant.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.txtBDTenant_ButtonClick);
			//
			// FormDetailACFunctionCard
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.Name = "FormDetailACFunctionCard";
			this.Text = "ACFunctionCard Detail";
			((System.ComponentModel.ISupportInitialize)(this.pnlButtons)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pnlContent)).EndInit();
			this.pnlContent.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.txtSitecode.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtEmbossed.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtEncoded.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtCardTypeID.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtFunctionID.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtFirstName.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtLastName.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.chkFIPS.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtPin.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dateValidFrom.Properties.VistaTimeProperties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dateValidFrom.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dateValidThru.Properties.VistaTimeProperties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dateValidThru.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtBDTenant.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.grdACPanelFunctionCardMap)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.grdACPanelFunctionCardMapView)).EndInit();
			this.ResumeLayout(false);
		}

		#endregion

		private Cheke.WinCtrl.Common.TextEditEx txtSitecode;
		private Cheke.WinCtrl.Common.TextEditEx txtEmbossed;
		private Cheke.WinCtrl.Common.TextEditEx txtEncoded;
		private Cheke.WinCtrl.Common.TextEditEx txtCardTypeID;
		private Cheke.WinCtrl.Common.TextEditEx txtFunctionID;
		private Cheke.WinCtrl.Common.TextEditEx txtFirstName;
		private Cheke.WinCtrl.Common.TextEditEx txtLastName;
		private Cheke.WinCtrl.Common.CheckEditEx chkFIPS;
		private Cheke.WinCtrl.Common.TextEditEx txtPin;
		private Cheke.WinCtrl.Common.DateEditEx dateValidFrom;
		private Cheke.WinCtrl.Common.DateEditEx dateValidThru;
		private Cheke.WinCtrl.Common.ButtonEditEx txtBDTenant;
		private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
		private DevExpress.XtraTab.XtraTabPage tabDetail;
		private DevExpress.XtraTab.XtraTabPage tabACPanelFunctionCardMap;
		private DevExpress.XtraGrid.GridControl grdACPanelFunctionCardMap;
		private DevExpress.XtraGrid.Views.Grid.GridView grdACPanelFunctionCardMapView;
	}
}
