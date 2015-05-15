namespace W3000.Manager.FormDetailEditor
{
	public partial class FormDetailACCardHolder
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
			this.dateValidFrom = new Cheke.WinCtrl.Common.DateEditEx();
			this.dateValidThru = new Cheke.WinCtrl.Common.DateEditEx();
			this.chkFIPS = new Cheke.WinCtrl.Common.CheckEditEx();
			this.txtPin = new Cheke.WinCtrl.Common.TextEditEx();
			this.txtNotes = new Cheke.WinCtrl.Common.MemoEditEx();
			this.txtEventNotifyEmail = new Cheke.WinCtrl.Common.MemoEditEx();
			this.chkFireWarden = new Cheke.WinCtrl.Common.CheckEditEx();
			this.txtCustInfo1 = new Cheke.WinCtrl.Common.TextEditEx();
			this.txtCustInfo2 = new Cheke.WinCtrl.Common.TextEditEx();
			this.txtCustInfo3 = new Cheke.WinCtrl.Common.TextEditEx();
			this.txtCustInfo4 = new Cheke.WinCtrl.Common.TextEditEx();
			this.txtCustInfo5 = new Cheke.WinCtrl.Common.TextEditEx();
			this.txtCustInfo6 = new Cheke.WinCtrl.Common.TextEditEx();
			this.txtCustInfo7 = new Cheke.WinCtrl.Common.TextEditEx();
			this.txtCustInfo8 = new Cheke.WinCtrl.Common.TextEditEx();
			this.txtBDTenant = new Cheke.WinCtrl.Common.ButtonEditEx();
			this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
			this.tabDetail = new DevExpress.XtraTab.XtraTabPage();
			this.tabACCardHolderBuildingMap = new DevExpress.XtraTab.XtraTabPage();
			this.grdACCardHolderBuildingMap = new DevExpress.XtraGrid.GridControl();
			this.grdACCardHolderBuildingMapView = new DevExpress.XtraGrid.Views.Grid.GridView();
			((System.ComponentModel.ISupportInitialize)(this.pnlButtons)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pnlContent)).BeginInit();
			this.pnlContent.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.txtSitecode.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtEmbossed.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtEncoded.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtCardTypeID.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtFirstName.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtLastName.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dateValidFrom.Properties.VistaTimeProperties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dateValidFrom.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dateValidThru.Properties.VistaTimeProperties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dateValidThru.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.chkFIPS.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtPin.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtNotes.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtEventNotifyEmail.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.chkFireWarden.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtCustInfo1.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtCustInfo2.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtCustInfo3.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtCustInfo4.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtCustInfo5.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtCustInfo6.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtCustInfo7.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtCustInfo8.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtBDTenant.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.grdACCardHolderBuildingMap)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.grdACCardHolderBuildingMapView)).BeginInit();
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
			this.tabDetail,this.tabACCardHolderBuildingMap});
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
			this.tabDetail.Controls.Add(this.dateValidFrom);
			this.tabDetail.Controls.Add(this.dateValidThru);
			this.tabDetail.Controls.Add(this.chkFIPS);
			this.tabDetail.Controls.Add(this.txtPin);
			this.tabDetail.Controls.Add(this.txtNotes);
			this.tabDetail.Controls.Add(this.txtEventNotifyEmail);
			this.tabDetail.Controls.Add(this.chkFireWarden);
			this.tabDetail.Controls.Add(this.txtCustInfo1);
			this.tabDetail.Controls.Add(this.txtCustInfo2);
			this.tabDetail.Controls.Add(this.txtCustInfo3);
			this.tabDetail.Controls.Add(this.txtCustInfo4);
			this.tabDetail.Controls.Add(this.txtCustInfo5);
			this.tabDetail.Controls.Add(this.txtCustInfo6);
			this.tabDetail.Controls.Add(this.txtCustInfo7);
			this.tabDetail.Controls.Add(this.txtCustInfo8);
			this.tabDetail.Controls.Add(this.txtBDTenant);
			this.tabDetail.Name = "tabDetail";
			this.tabDetail.Text = "Detail";
			//
			// tabACCardHolderBuildingMap
			//
			this.tabACCardHolderBuildingMap.Controls.Add(this.grdACCardHolderBuildingMap);
			this.tabACCardHolderBuildingMap.Name = "tabACCardHolderBuildingMap";
			this.tabACCardHolderBuildingMap.Text = "ACCardHolderBuildingMap";
			this.tabACCardHolderBuildingMap.Enter += new System.EventHandler(this.tabACCardHolderBuildingMap_Enter);
			//
			// grdACCardHolderBuildingMap
			//
			this.grdACCardHolderBuildingMap.Dock = System.Windows.Forms.DockStyle.Fill;
			this.grdACCardHolderBuildingMap.MainView = this.grdACCardHolderBuildingMapView;
			this.grdACCardHolderBuildingMap.Name = "grdACCardHolderBuildingMap";
			this.grdACCardHolderBuildingMap.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {this.grdACCardHolderBuildingMapView});
			//
			// grdACCardHolderBuildingMapView
			//
			this.grdACCardHolderBuildingMapView.GridControl = this.grdACCardHolderBuildingMap;
			this.grdACCardHolderBuildingMapView.Name = "grdACCardHolderBuildingMapView";
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
			// chkFIPS
			//
			this.chkFIPS.Location = new System.Drawing.Point(160, 16);
			this.chkFIPS.Name = "chkFIPS";
			this.chkFIPS.TabIndex = 8;
			this.chkFIPS.Properties.Caption = "FIPS";
			//
			// txtPin
			//
			this.txtPin.EditValue = "";
			this.txtPin.Location = new System.Drawing.Point(160, 40);
			this.txtPin.Name = "txtPin";
			this.txtPin.TabIndex = 9;
			this.txtPin.Title = "Pin";
			this.txtPin.Properties.Mask.EditMask = "n0";
			this.txtPin.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
			this.txtPin.Properties.Mask.UseMaskAsDisplayFormat = true;
			//
			// txtNotes
			//
			this.txtNotes.EditValue = "";
			this.txtNotes.Location = new System.Drawing.Point(160, 80);
			this.txtNotes.Name = "txtNotes";
			this.txtNotes.TabIndex = 10;
			this.txtNotes.Title = "Notes";
			//
			// txtEventNotifyEmail
			//
			this.txtEventNotifyEmail.EditValue = "";
			this.txtEventNotifyEmail.Location = new System.Drawing.Point(160, 240);
			this.txtEventNotifyEmail.Name = "txtEventNotifyEmail";
			this.txtEventNotifyEmail.TabIndex = 11;
			this.txtEventNotifyEmail.Title = "EventNotifyEmail";
			//
			// chkFireWarden
			//
			this.chkFireWarden.Location = new System.Drawing.Point(315, 16);
			this.chkFireWarden.Name = "chkFireWarden";
			this.chkFireWarden.TabIndex = 12;
			this.chkFireWarden.Properties.Caption = "FireWarden";
			//
			// txtCustInfo1
			//
			this.txtCustInfo1.EditValue = "";
			this.txtCustInfo1.Location = new System.Drawing.Point(315, 40);
			this.txtCustInfo1.Name = "txtCustInfo1";
			this.txtCustInfo1.TabIndex = 13;
			this.txtCustInfo1.Title = "CustInfo1";
			//
			// txtCustInfo2
			//
			this.txtCustInfo2.EditValue = "";
			this.txtCustInfo2.Location = new System.Drawing.Point(315, 80);
			this.txtCustInfo2.Name = "txtCustInfo2";
			this.txtCustInfo2.TabIndex = 14;
			this.txtCustInfo2.Title = "CustInfo2";
			//
			// txtCustInfo3
			//
			this.txtCustInfo3.EditValue = "";
			this.txtCustInfo3.Location = new System.Drawing.Point(315, 120);
			this.txtCustInfo3.Name = "txtCustInfo3";
			this.txtCustInfo3.TabIndex = 15;
			this.txtCustInfo3.Title = "CustInfo3";
			//
			// txtCustInfo4
			//
			this.txtCustInfo4.EditValue = "";
			this.txtCustInfo4.Location = new System.Drawing.Point(315, 160);
			this.txtCustInfo4.Name = "txtCustInfo4";
			this.txtCustInfo4.TabIndex = 16;
			this.txtCustInfo4.Title = "CustInfo4";
			//
			// txtCustInfo5
			//
			this.txtCustInfo5.EditValue = "";
			this.txtCustInfo5.Location = new System.Drawing.Point(315, 200);
			this.txtCustInfo5.Name = "txtCustInfo5";
			this.txtCustInfo5.TabIndex = 17;
			this.txtCustInfo5.Title = "CustInfo5";
			//
			// txtCustInfo6
			//
			this.txtCustInfo6.EditValue = "";
			this.txtCustInfo6.Location = new System.Drawing.Point(315, 240);
			this.txtCustInfo6.Name = "txtCustInfo6";
			this.txtCustInfo6.TabIndex = 18;
			this.txtCustInfo6.Title = "CustInfo6";
			//
			// txtCustInfo7
			//
			this.txtCustInfo7.EditValue = "";
			this.txtCustInfo7.Location = new System.Drawing.Point(315, 280);
			this.txtCustInfo7.Name = "txtCustInfo7";
			this.txtCustInfo7.TabIndex = 19;
			this.txtCustInfo7.Title = "CustInfo7";
			//
			// txtCustInfo8
			//
			this.txtCustInfo8.EditValue = "";
			this.txtCustInfo8.Location = new System.Drawing.Point(470, 0);
			this.txtCustInfo8.Name = "txtCustInfo8";
			this.txtCustInfo8.TabIndex = 20;
			this.txtCustInfo8.Title = "CustInfo8";
			//
			// txtBDTenant
			//
			this.txtBDTenant.EditValue = "";
			this.txtBDTenant.Location = new System.Drawing.Point(470, 40);
			this.txtBDTenant.Name = "txtBDTenant";
			this.txtBDTenant.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] 
				{
					new DevExpress.XtraEditors.Controls.EditorButton()
				});
			this.txtBDTenant.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
			this.txtBDTenant.ReadOnly = false;
			this.txtBDTenant.TabIndex = 21;
			this.txtBDTenant.Title = "BDTenant";
			this.txtBDTenant.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.txtBDTenant_ButtonClick);
			//
			// FormDetailACCardHolder
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.Name = "FormDetailACCardHolder";
			this.Text = "ACCardHolder Detail";
			((System.ComponentModel.ISupportInitialize)(this.pnlButtons)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pnlContent)).EndInit();
			this.pnlContent.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.txtSitecode.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtEmbossed.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtEncoded.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtCardTypeID.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtFirstName.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtLastName.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dateValidFrom.Properties.VistaTimeProperties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dateValidFrom.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dateValidThru.Properties.VistaTimeProperties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dateValidThru.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.chkFIPS.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtPin.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtNotes.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtEventNotifyEmail.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.chkFireWarden.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtCustInfo1.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtCustInfo2.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtCustInfo3.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtCustInfo4.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtCustInfo5.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtCustInfo6.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtCustInfo7.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtCustInfo8.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtBDTenant.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.grdACCardHolderBuildingMap)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.grdACCardHolderBuildingMapView)).EndInit();
			this.ResumeLayout(false);
		}

		#endregion

		private Cheke.WinCtrl.Common.TextEditEx txtSitecode;
		private Cheke.WinCtrl.Common.TextEditEx txtEmbossed;
		private Cheke.WinCtrl.Common.TextEditEx txtEncoded;
		private Cheke.WinCtrl.Common.TextEditEx txtCardTypeID;
		private Cheke.WinCtrl.Common.TextEditEx txtFirstName;
		private Cheke.WinCtrl.Common.TextEditEx txtLastName;
		private Cheke.WinCtrl.Common.DateEditEx dateValidFrom;
		private Cheke.WinCtrl.Common.DateEditEx dateValidThru;
		private Cheke.WinCtrl.Common.CheckEditEx chkFIPS;
		private Cheke.WinCtrl.Common.TextEditEx txtPin;
		private Cheke.WinCtrl.Common.MemoEditEx txtNotes;
		private Cheke.WinCtrl.Common.MemoEditEx txtEventNotifyEmail;
		private Cheke.WinCtrl.Common.CheckEditEx chkFireWarden;
		private Cheke.WinCtrl.Common.TextEditEx txtCustInfo1;
		private Cheke.WinCtrl.Common.TextEditEx txtCustInfo2;
		private Cheke.WinCtrl.Common.TextEditEx txtCustInfo3;
		private Cheke.WinCtrl.Common.TextEditEx txtCustInfo4;
		private Cheke.WinCtrl.Common.TextEditEx txtCustInfo5;
		private Cheke.WinCtrl.Common.TextEditEx txtCustInfo6;
		private Cheke.WinCtrl.Common.TextEditEx txtCustInfo7;
		private Cheke.WinCtrl.Common.TextEditEx txtCustInfo8;
		private Cheke.WinCtrl.Common.ButtonEditEx txtBDTenant;
		private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
		private DevExpress.XtraTab.XtraTabPage tabDetail;
		private DevExpress.XtraTab.XtraTabPage tabACCardHolderBuildingMap;
		private DevExpress.XtraGrid.GridControl grdACCardHolderBuildingMap;
		private DevExpress.XtraGrid.Views.Grid.GridView grdACCardHolderBuildingMapView;
	}
}
