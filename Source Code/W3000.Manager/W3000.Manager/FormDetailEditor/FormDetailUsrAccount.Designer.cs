namespace W3000.Manager.FormDetailEditor
{
	public partial class FormDetailUsrAccount
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
			this.txtUserID = new Cheke.WinCtrl.Common.TextEditEx();
			this.chkIsAdmin = new Cheke.WinCtrl.Common.CheckEditEx();
			this.chkIsCentral = new Cheke.WinCtrl.Common.CheckEditEx();
			this.txtFirstName = new Cheke.WinCtrl.Common.TextEditEx();
			this.txtLastName = new Cheke.WinCtrl.Common.TextEditEx();
			this.datePwdExpireDate = new Cheke.WinCtrl.Common.DateEditEx();
			this.txtCellPhone = new Cheke.WinCtrl.Common.TextEditEx();
			this.txtHomePhone = new Cheke.WinCtrl.Common.TextEditEx();
			this.txtOfficePhone = new Cheke.WinCtrl.Common.TextEditEx();
			this.txtEmail = new Cheke.WinCtrl.Common.TextEditEx();
			this.dateLastLogin = new Cheke.WinCtrl.Common.DateEditEx();
			this.txtTotalUsage = new Cheke.WinCtrl.Common.TextEditEx();
			this.txtStartScreen = new Cheke.WinCtrl.Common.MemoEditEx();
			this.txtPopupExtension = new Cheke.WinCtrl.Common.TextEditEx();
			this.txtBDTenant = new Cheke.WinCtrl.Common.ButtonEditEx();
			this.txtUsrGroup = new Cheke.WinCtrl.Common.ButtonEditEx();
			this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
			this.tabDetail = new DevExpress.XtraTab.XtraTabPage();
			this.tabUsrAccountBuildingMap = new DevExpress.XtraTab.XtraTabPage();
			this.grdUsrAccountBuildingMap = new DevExpress.XtraGrid.GridControl();
			this.grdUsrAccountBuildingMapView = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.tabUsrAccountBRRule = new DevExpress.XtraTab.XtraTabPage();
			this.grdUsrAccountBRRule = new DevExpress.XtraGrid.GridControl();
			this.grdUsrAccountBRRuleView = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.tabUsrAccountDBRule = new DevExpress.XtraTab.XtraTabPage();
			this.grdUsrAccountDBRule = new DevExpress.XtraGrid.GridControl();
			this.grdUsrAccountDBRuleView = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.tabUsrAccountTenantMap = new DevExpress.XtraTab.XtraTabPage();
			this.grdUsrAccountTenantMap = new DevExpress.XtraGrid.GridControl();
			this.grdUsrAccountTenantMapView = new DevExpress.XtraGrid.Views.Grid.GridView();
			((System.ComponentModel.ISupportInitialize)(this.pnlButtons)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pnlContent)).BeginInit();
			this.pnlContent.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.txtUserID.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.chkIsAdmin.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.chkIsCentral.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtFirstName.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtLastName.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.datePwdExpireDate.Properties.VistaTimeProperties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.datePwdExpireDate.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtCellPhone.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtHomePhone.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtOfficePhone.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtEmail.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dateLastLogin.Properties.VistaTimeProperties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dateLastLogin.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtTotalUsage.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtStartScreen.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtPopupExtension.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtBDTenant.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtUsrGroup.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.grdUsrAccountBuildingMap)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.grdUsrAccountBuildingMapView)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.grdUsrAccountBRRule)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.grdUsrAccountBRRuleView)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.grdUsrAccountDBRule)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.grdUsrAccountDBRuleView)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.grdUsrAccountTenantMap)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.grdUsrAccountTenantMapView)).BeginInit();
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
			this.tabDetail,this.tabUsrAccountBuildingMap,this.tabUsrAccountBRRule,this.tabUsrAccountDBRule,this.tabUsrAccountTenantMap});
			this.xtraTabControl1.SelectedPageChanged += new DevExpress.XtraTab.TabPageChangedEventHandler(this.xtraTabControl1_SelectedPageChanged);
			//
			// tabDetail
			//
			this.tabDetail.Controls.Add(this.txtUserID);
			this.tabDetail.Controls.Add(this.chkIsAdmin);
			this.tabDetail.Controls.Add(this.chkIsCentral);
			this.tabDetail.Controls.Add(this.txtFirstName);
			this.tabDetail.Controls.Add(this.txtLastName);
			this.tabDetail.Controls.Add(this.datePwdExpireDate);
			this.tabDetail.Controls.Add(this.txtCellPhone);
			this.tabDetail.Controls.Add(this.txtHomePhone);
			this.tabDetail.Controls.Add(this.txtOfficePhone);
			this.tabDetail.Controls.Add(this.txtEmail);
			this.tabDetail.Controls.Add(this.dateLastLogin);
			this.tabDetail.Controls.Add(this.txtTotalUsage);
			this.tabDetail.Controls.Add(this.txtStartScreen);
			this.tabDetail.Controls.Add(this.txtPopupExtension);
			this.tabDetail.Controls.Add(this.txtBDTenant);
			this.tabDetail.Controls.Add(this.txtUsrGroup);
			this.tabDetail.Name = "tabDetail";
			this.tabDetail.Text = "Detail";
			//
			// tabUsrAccountBuildingMap
			//
			this.tabUsrAccountBuildingMap.Controls.Add(this.grdUsrAccountBuildingMap);
			this.tabUsrAccountBuildingMap.Name = "tabUsrAccountBuildingMap";
			this.tabUsrAccountBuildingMap.Text = "UsrAccountBuildingMap";
			this.tabUsrAccountBuildingMap.Enter += new System.EventHandler(this.tabUsrAccountBuildingMap_Enter);
			//
			// tabUsrAccountBRRule
			//
			this.tabUsrAccountBRRule.Controls.Add(this.grdUsrAccountBRRule);
			this.tabUsrAccountBRRule.Name = "tabUsrAccountBRRule";
			this.tabUsrAccountBRRule.Text = "UsrAccountBRRule";
			this.tabUsrAccountBRRule.Enter += new System.EventHandler(this.tabUsrAccountBRRule_Enter);
			//
			// tabUsrAccountDBRule
			//
			this.tabUsrAccountDBRule.Controls.Add(this.grdUsrAccountDBRule);
			this.tabUsrAccountDBRule.Name = "tabUsrAccountDBRule";
			this.tabUsrAccountDBRule.Text = "UsrAccountDBRule";
			this.tabUsrAccountDBRule.Enter += new System.EventHandler(this.tabUsrAccountDBRule_Enter);
			//
			// tabUsrAccountTenantMap
			//
			this.tabUsrAccountTenantMap.Controls.Add(this.grdUsrAccountTenantMap);
			this.tabUsrAccountTenantMap.Name = "tabUsrAccountTenantMap";
			this.tabUsrAccountTenantMap.Text = "UsrAccountTenantMap";
			this.tabUsrAccountTenantMap.Enter += new System.EventHandler(this.tabUsrAccountTenantMap_Enter);
			//
			// grdUsrAccountBuildingMap
			//
			this.grdUsrAccountBuildingMap.Dock = System.Windows.Forms.DockStyle.Fill;
			this.grdUsrAccountBuildingMap.MainView = this.grdUsrAccountBuildingMapView;
			this.grdUsrAccountBuildingMap.Name = "grdUsrAccountBuildingMap";
			this.grdUsrAccountBuildingMap.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {this.grdUsrAccountBuildingMapView});
			//
			// grdUsrAccountBuildingMapView
			//
			this.grdUsrAccountBuildingMapView.GridControl = this.grdUsrAccountBuildingMap;
			this.grdUsrAccountBuildingMapView.Name = "grdUsrAccountBuildingMapView";
			//
			// grdUsrAccountBRRule
			//
			this.grdUsrAccountBRRule.Dock = System.Windows.Forms.DockStyle.Fill;
			this.grdUsrAccountBRRule.MainView = this.grdUsrAccountBRRuleView;
			this.grdUsrAccountBRRule.Name = "grdUsrAccountBRRule";
			this.grdUsrAccountBRRule.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {this.grdUsrAccountBRRuleView});
			//
			// grdUsrAccountBRRuleView
			//
			this.grdUsrAccountBRRuleView.GridControl = this.grdUsrAccountBRRule;
			this.grdUsrAccountBRRuleView.Name = "grdUsrAccountBRRuleView";
			//
			// grdUsrAccountDBRule
			//
			this.grdUsrAccountDBRule.Dock = System.Windows.Forms.DockStyle.Fill;
			this.grdUsrAccountDBRule.MainView = this.grdUsrAccountDBRuleView;
			this.grdUsrAccountDBRule.Name = "grdUsrAccountDBRule";
			this.grdUsrAccountDBRule.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {this.grdUsrAccountDBRuleView});
			//
			// grdUsrAccountDBRuleView
			//
			this.grdUsrAccountDBRuleView.GridControl = this.grdUsrAccountDBRule;
			this.grdUsrAccountDBRuleView.Name = "grdUsrAccountDBRuleView";
			//
			// grdUsrAccountTenantMap
			//
			this.grdUsrAccountTenantMap.Dock = System.Windows.Forms.DockStyle.Fill;
			this.grdUsrAccountTenantMap.MainView = this.grdUsrAccountTenantMapView;
			this.grdUsrAccountTenantMap.Name = "grdUsrAccountTenantMap";
			this.grdUsrAccountTenantMap.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {this.grdUsrAccountTenantMapView});
			//
			// grdUsrAccountTenantMapView
			//
			this.grdUsrAccountTenantMapView.GridControl = this.grdUsrAccountTenantMap;
			this.grdUsrAccountTenantMapView.Name = "grdUsrAccountTenantMapView";
			//
			// txtUserID
			//
			this.txtUserID.EditValue = "";
			this.txtUserID.Location = new System.Drawing.Point(5, 0);
			this.txtUserID.Name = "txtUserID";
			this.txtUserID.TabIndex = 0;
			this.txtUserID.Title = "UserID";
			//
			// chkIsAdmin
			//
			this.chkIsAdmin.Location = new System.Drawing.Point(5, 56);
			this.chkIsAdmin.Name = "chkIsAdmin";
			this.chkIsAdmin.TabIndex = 1;
			this.chkIsAdmin.Properties.Caption = "IsAdmin";
			//
			// chkIsCentral
			//
			this.chkIsCentral.Location = new System.Drawing.Point(5, 96);
			this.chkIsCentral.Name = "chkIsCentral";
			this.chkIsCentral.TabIndex = 2;
			this.chkIsCentral.Properties.Caption = "IsCentral";
			//
			// txtFirstName
			//
			this.txtFirstName.EditValue = "";
			this.txtFirstName.Location = new System.Drawing.Point(5, 120);
			this.txtFirstName.Name = "txtFirstName";
			this.txtFirstName.TabIndex = 3;
			this.txtFirstName.Title = "FirstName";
			//
			// txtLastName
			//
			this.txtLastName.EditValue = "";
			this.txtLastName.Location = new System.Drawing.Point(5, 160);
			this.txtLastName.Name = "txtLastName";
			this.txtLastName.TabIndex = 4;
			this.txtLastName.Title = "LastName";
			//
			// datePwdExpireDate
			//
			this.datePwdExpireDate.EditValue =  new System.DateTime(2015, 1, 1, 0, 0, 0, 0);
			this.datePwdExpireDate.Location = new System.Drawing.Point(5, 200);
			this.datePwdExpireDate.Name = "datePwdExpireDate";
			this.datePwdExpireDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[]
				{
					new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)
				});
			this.datePwdExpireDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[]
				{
					new DevExpress.XtraEditors.Controls.EditorButton()
				});
			this.datePwdExpireDate.TabIndex = 5;
			this.datePwdExpireDate.Title = "PwdExpireDate";
			//
			// txtCellPhone
			//
			this.txtCellPhone.EditValue = "";
			this.txtCellPhone.Location = new System.Drawing.Point(5, 240);
			this.txtCellPhone.Name = "txtCellPhone";
			this.txtCellPhone.TabIndex = 6;
			this.txtCellPhone.Title = "CellPhone";
			//
			// txtHomePhone
			//
			this.txtHomePhone.EditValue = "";
			this.txtHomePhone.Location = new System.Drawing.Point(5, 280);
			this.txtHomePhone.Name = "txtHomePhone";
			this.txtHomePhone.TabIndex = 7;
			this.txtHomePhone.Title = "HomePhone";
			//
			// txtOfficePhone
			//
			this.txtOfficePhone.EditValue = "";
			this.txtOfficePhone.Location = new System.Drawing.Point(160, 0);
			this.txtOfficePhone.Name = "txtOfficePhone";
			this.txtOfficePhone.TabIndex = 8;
			this.txtOfficePhone.Title = "OfficePhone";
			//
			// txtEmail
			//
			this.txtEmail.EditValue = "";
			this.txtEmail.Location = new System.Drawing.Point(160, 40);
			this.txtEmail.Name = "txtEmail";
			this.txtEmail.TabIndex = 9;
			this.txtEmail.Title = "Email";
			//
			// dateLastLogin
			//
			this.dateLastLogin.EditValue =  new System.DateTime(2015, 1, 1, 0, 0, 0, 0);
			this.dateLastLogin.Location = new System.Drawing.Point(160, 80);
			this.dateLastLogin.Name = "dateLastLogin";
			this.dateLastLogin.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[]
				{
					new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)
				});
			this.dateLastLogin.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[]
				{
					new DevExpress.XtraEditors.Controls.EditorButton()
				});
			this.dateLastLogin.TabIndex = 10;
			this.dateLastLogin.Title = "LastLogin";
			//
			// txtTotalUsage
			//
			this.txtTotalUsage.EditValue = "";
			this.txtTotalUsage.Location = new System.Drawing.Point(160, 120);
			this.txtTotalUsage.Name = "txtTotalUsage";
			this.txtTotalUsage.TabIndex = 11;
			this.txtTotalUsage.Title = "TotalUsage";
			this.txtTotalUsage.Properties.Mask.EditMask = "n0";
			this.txtTotalUsage.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
			this.txtTotalUsage.Properties.Mask.UseMaskAsDisplayFormat = true;
			//
			// txtStartScreen
			//
			this.txtStartScreen.EditValue = "";
			this.txtStartScreen.Location = new System.Drawing.Point(160, 160);
			this.txtStartScreen.Name = "txtStartScreen";
			this.txtStartScreen.TabIndex = 12;
			this.txtStartScreen.Title = "StartScreen";
			//
			// txtPopupExtension
			//
			this.txtPopupExtension.EditValue = "";
			this.txtPopupExtension.Location = new System.Drawing.Point(315, 0);
			this.txtPopupExtension.Name = "txtPopupExtension";
			this.txtPopupExtension.TabIndex = 13;
			this.txtPopupExtension.Title = "PopupExtension";
			this.txtPopupExtension.Properties.Mask.EditMask = "n0";
			this.txtPopupExtension.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
			this.txtPopupExtension.Properties.Mask.UseMaskAsDisplayFormat = true;
			//
			// txtBDTenant
			//
			this.txtBDTenant.EditValue = "";
			this.txtBDTenant.Location = new System.Drawing.Point(315, 40);
			this.txtBDTenant.Name = "txtBDTenant";
			this.txtBDTenant.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] 
				{
					new DevExpress.XtraEditors.Controls.EditorButton()
				});
			this.txtBDTenant.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
			this.txtBDTenant.ReadOnly = false;
			this.txtBDTenant.TabIndex = 14;
			this.txtBDTenant.Title = "BDTenant";
			this.txtBDTenant.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.txtBDTenant_ButtonClick);
			//
			// txtUsrGroup
			//
			this.txtUsrGroup.EditValue = "";
			this.txtUsrGroup.Location = new System.Drawing.Point(315, 80);
			this.txtUsrGroup.Name = "txtUsrGroup";
			this.txtUsrGroup.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] 
				{
					new DevExpress.XtraEditors.Controls.EditorButton()
				});
			this.txtUsrGroup.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
			this.txtUsrGroup.ReadOnly = false;
			this.txtUsrGroup.TabIndex = 15;
			this.txtUsrGroup.Title = "UsrGroup";
			this.txtUsrGroup.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.txtUsrGroup_ButtonClick);
			//
			// FormDetailUsrAccount
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.Name = "FormDetailUsrAccount";
			this.Text = "UsrAccount Detail";
			((System.ComponentModel.ISupportInitialize)(this.pnlButtons)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pnlContent)).EndInit();
			this.pnlContent.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.txtUserID.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.chkIsAdmin.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.chkIsCentral.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtFirstName.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtLastName.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.datePwdExpireDate.Properties.VistaTimeProperties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.datePwdExpireDate.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtCellPhone.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtHomePhone.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtOfficePhone.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtEmail.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dateLastLogin.Properties.VistaTimeProperties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dateLastLogin.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtTotalUsage.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtStartScreen.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtPopupExtension.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtBDTenant.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtUsrGroup.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.grdUsrAccountBuildingMap)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.grdUsrAccountBuildingMapView)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.grdUsrAccountBRRule)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.grdUsrAccountBRRuleView)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.grdUsrAccountDBRule)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.grdUsrAccountDBRuleView)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.grdUsrAccountTenantMap)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.grdUsrAccountTenantMapView)).EndInit();
			this.ResumeLayout(false);
		}

		#endregion

		private Cheke.WinCtrl.Common.TextEditEx txtUserID;
		private Cheke.WinCtrl.Common.CheckEditEx chkIsAdmin;
		private Cheke.WinCtrl.Common.CheckEditEx chkIsCentral;
		private Cheke.WinCtrl.Common.TextEditEx txtFirstName;
		private Cheke.WinCtrl.Common.TextEditEx txtLastName;
		private Cheke.WinCtrl.Common.DateEditEx datePwdExpireDate;
		private Cheke.WinCtrl.Common.TextEditEx txtCellPhone;
		private Cheke.WinCtrl.Common.TextEditEx txtHomePhone;
		private Cheke.WinCtrl.Common.TextEditEx txtOfficePhone;
		private Cheke.WinCtrl.Common.TextEditEx txtEmail;
		private Cheke.WinCtrl.Common.DateEditEx dateLastLogin;
		private Cheke.WinCtrl.Common.TextEditEx txtTotalUsage;
		private Cheke.WinCtrl.Common.MemoEditEx txtStartScreen;
		private Cheke.WinCtrl.Common.TextEditEx txtPopupExtension;
		private Cheke.WinCtrl.Common.ButtonEditEx txtBDTenant;
		private Cheke.WinCtrl.Common.ButtonEditEx txtUsrGroup;
		private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
		private DevExpress.XtraTab.XtraTabPage tabDetail;
		private DevExpress.XtraTab.XtraTabPage tabUsrAccountBuildingMap;
		private DevExpress.XtraGrid.GridControl grdUsrAccountBuildingMap;
		private DevExpress.XtraGrid.Views.Grid.GridView grdUsrAccountBuildingMapView;
		private DevExpress.XtraTab.XtraTabPage tabUsrAccountBRRule;
		private DevExpress.XtraGrid.GridControl grdUsrAccountBRRule;
		private DevExpress.XtraGrid.Views.Grid.GridView grdUsrAccountBRRuleView;
		private DevExpress.XtraTab.XtraTabPage tabUsrAccountDBRule;
		private DevExpress.XtraGrid.GridControl grdUsrAccountDBRule;
		private DevExpress.XtraGrid.Views.Grid.GridView grdUsrAccountDBRuleView;
		private DevExpress.XtraTab.XtraTabPage tabUsrAccountTenantMap;
		private DevExpress.XtraGrid.GridControl grdUsrAccountTenantMap;
		private DevExpress.XtraGrid.Views.Grid.GridView grdUsrAccountTenantMapView;
	}
}
