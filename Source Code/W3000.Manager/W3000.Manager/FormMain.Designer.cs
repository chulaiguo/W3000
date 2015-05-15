namespace W3000.Manager
{
	public partial class FormMain
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
			this.components = new System.ComponentModel.Container();
			this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
			this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
			this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
			this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
			this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
			this.barMainMenu = new DevExpress.XtraBars.Bar();
			this.menuFile = new DevExpress.XtraBars.BarSubItem();
			this.menuFileCloseAll = new DevExpress.XtraBars.BarButtonItem();
			this.menuFileClose = new DevExpress.XtraBars.BarButtonItem();
			this.menuExit = new DevExpress.XtraBars.BarButtonItem();
			this.menuDictionary = new DevExpress.XtraBars.BarSubItem();
			this.menuUtilHoliday = new DevExpress.XtraBars.BarButtonItem();
			this.menuTools = new DevExpress.XtraBars.BarSubItem();
			this.menuChangePassword = new DevExpress.XtraBars.BarButtonItem();
			this.menuWhoAmI = new DevExpress.XtraBars.BarButtonItem();
			this.menuUserAccount = new DevExpress.XtraBars.BarButtonItem();
			this.menuWindow = new DevExpress.XtraBars.BarSubItem();
			this.menuWindowsList = new DevExpress.XtraBars.BarListItem();
			this.menuHelp = new DevExpress.XtraBars.BarSubItem();
			this.menuAbout = new DevExpress.XtraBars.BarButtonItem();
			this.barStatus = new DevExpress.XtraBars.Bar();
			this.splitContainerMain = new DevExpress.XtraEditors.SplitContainerControl();
			this.navBarLeft = new DevExpress.XtraNavBar.NavBarControl();
			this.imgLarge = new System.Windows.Forms.ImageList(this.components);
			this.imgSmall = new System.Windows.Forms.ImageList(this.components);
			this.nbgGeneral = new DevExpress.XtraNavBar.NavBarGroup();
			this.nbiBDBuilding = new DevExpress.XtraNavBar.NavBarItem();
			this.nbiBDTenant = new DevExpress.XtraNavBar.NavBarItem();
			this.nbiACCardHolder = new DevExpress.XtraNavBar.NavBarItem();
			this.nbiACMainZone = new DevExpress.XtraNavBar.NavBarItem();
			this.nbiACInterval = new DevExpress.XtraNavBar.NavBarItem();
			this.nbiACTimecode = new DevExpress.XtraNavBar.NavBarItem();
			this.nbiACAMFormat = new DevExpress.XtraNavBar.NavBarItem();
			this.nbiACOutputGroup = new DevExpress.XtraNavBar.NavBarItem();
			this.nbiACInputGroup = new DevExpress.XtraNavBar.NavBarItem();
			this.nbiACInput = new DevExpress.XtraNavBar.NavBarItem();
			this.nbiACFunctionCard = new DevExpress.XtraNavBar.NavBarItem();
			this.nbiACAccessLevel = new DevExpress.XtraNavBar.NavBarItem();
			this.nbiUtilHoliday = new DevExpress.XtraNavBar.NavBarItem();
			this.nbiUsrAccount = new DevExpress.XtraNavBar.NavBarItem();
			this.nbiACMasterCard = new DevExpress.XtraNavBar.NavBarItem();
			this.nbiACSupervisory = new DevExpress.XtraNavBar.NavBarItem();
			this.nbiUsrGroup = new DevExpress.XtraNavBar.NavBarItem();
			this.nbiBDVisitor = new DevExpress.XtraNavBar.NavBarItem();
			this.nbiACPanel = new DevExpress.XtraNavBar.NavBarItem();
			((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).BeginInit();
			this.splitContainerMain.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.navBarLeft)).BeginInit();
			this.SuspendLayout();
			//
			// barManager1
			//
			this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
			this.barMainMenu,
			this.barStatus});
			this.barManager1.DockControls.Add(this.barDockControlTop);
			this.barManager1.DockControls.Add(this.barDockControlBottom);
			this.barManager1.DockControls.Add(this.barDockControlLeft);
			this.barManager1.DockControls.Add(this.barDockControlRight);
			this.barManager1.Form = this;
			this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
			this.menuFile,
			this.menuFileClose,
			this.menuFileCloseAll,
			this.menuExit,
			this.menuDictionary,
			this.menuUtilHoliday,
			this.menuTools,
			this.menuChangePassword,
			this.menuWhoAmI,
			this.menuUserAccount,
			this.menuWindow,
			this.menuWindowsList,
			this.menuHelp,
			this.menuAbout});
			this.barManager1.MainMenu = this.barMainMenu;
			this.barManager1.MaxItemId = 45;
			this.barManager1.StatusBar = this.barStatus;
			//
			// barMainMenu
			//
			this.barMainMenu.BarName = "MainBar";
			this.barMainMenu.DockCol = 0;
			this.barMainMenu.DockRow = 0;
			this.barMainMenu.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
			this.barMainMenu.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
			new DevExpress.XtraBars.LinkPersistInfo(this.menuFile),
			new DevExpress.XtraBars.LinkPersistInfo(this.menuDictionary),
			new DevExpress.XtraBars.LinkPersistInfo(this.menuTools),
			new DevExpress.XtraBars.LinkPersistInfo(this.menuWindow),
			new DevExpress.XtraBars.LinkPersistInfo(this.menuHelp)});
			this.barMainMenu.OptionsBar.MultiLine = true;
			this.barMainMenu.OptionsBar.UseWholeRow = true;
			this.barMainMenu.Text = "MainBar";
			//
			// menuFile
			//
			this.menuFile.Caption = "&File";
			this.menuFile.Id = 0;
			this.menuFile.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
			new DevExpress.XtraBars.LinkPersistInfo(this.menuFileCloseAll),
			new DevExpress.XtraBars.LinkPersistInfo(this.menuFileClose),
			new DevExpress.XtraBars.LinkPersistInfo(this.menuExit, true)});
			this.menuFile.Name = "menuFile";
			//
			// menuFileCloseAll
			//
			this.menuFileCloseAll.Caption = "Close &All";
			this.menuFileCloseAll.Id = 1;
			this.menuFileCloseAll.Name = "menuFileCloseAll";
			this.menuFileCloseAll.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.menuFileCloseAll_ItemClick);
			//
			// menuFileClose
			//
			this.menuFileClose.Caption = "&Close";
			this.menuFileClose.Id = 2;
			this.menuFileClose.Name = "menuFileClose";
			this.menuFileClose.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.menuFileClose_ItemClick);
			//
			// menuExit
			//
			this.menuExit.Caption = "&Exit";
			this.menuExit.Id = 3;
			this.menuExit.Name = "menuExit";
			this.menuExit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.menuExit_ItemClick);
			//
			// menuDictionary
			//
			this.menuDictionary.Caption = "&Dictionary";
			this.menuDictionary.Id = 4;
			this.menuDictionary.Name = "menuDictionary";
			//
			// menuUtilHoliday
			//
			this.menuUtilHoliday.Caption = "UtilHoliday";
			this.menuUtilHoliday.Id = 7;
			this.menuUtilHoliday.Name = "menuUtilHoliday";
			this.menuUtilHoliday.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.menuUtilHoliday_ItemClick);
			this.menuDictionary.LinksPersistInfo.Add(new DevExpress.XtraBars.LinkPersistInfo(this.menuUtilHoliday));
			//
			// menuTools
			//
			this.menuTools.Caption = "&Tools";
			this.menuTools.Id = 8;
			this.menuTools.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
			new DevExpress.XtraBars.LinkPersistInfo(this.menuChangePassword),
			new DevExpress.XtraBars.LinkPersistInfo(this.menuWhoAmI),
			new DevExpress.XtraBars.LinkPersistInfo(this.menuUserAccount, true)});
			this.menuTools.Name = "menuTools";
			//
			// menuChangePassword
			//
			this.menuChangePassword.Caption = "&Change Password...";
			this.menuChangePassword.Id = 9;
			this.menuChangePassword.Name = "menuChangePassword";
			this.menuChangePassword.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.menuChangePassword_ItemClick);
			//
			// menuWhoAmI
			//
			this.menuWhoAmI.Caption = "&Who Am I...";
			this.menuWhoAmI.Id = 10;
			this.menuWhoAmI.Name = "menuWhoAmI";
			this.menuWhoAmI.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.menuWhoAmI_ItemClick);
			//
			// menuUserAccount
			//
			this.menuUserAccount.Caption = "&User Account";
			this.menuUserAccount.Id = 11;
			this.menuUserAccount.Name = "menuUserAccount";
			this.menuUserAccount.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.menuUserAccount_ItemClick);
			//
			// menuWindow
			//
			this.menuWindow.Caption = "&Window";
			this.menuWindow.Id = 12;
			this.menuWindow.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
			new DevExpress.XtraBars.LinkPersistInfo(this.menuWindowsList)});
			this.menuWindow.Name = "menuWindow";
			//
			// menuWindowsList
			//
			this.menuWindowsList.Caption = "&WindowsList";
			this.menuWindowsList.Id = 13;
			this.menuWindowsList.Name = "menuWindowsList";
			this.menuWindowsList.ShowChecks = true;
			this.menuWindowsList.ShowNumbers = true;
			this.menuWindowsList.ListItemClick += new DevExpress.XtraBars.ListItemClickEventHandler(this.menuWindowsList_ListItemClick);
			this.menuWindowsList.GetItemData += new System.EventHandler(this.menuWindowsList_GetItemData);
			//
			// menuHelp
			//
			this.menuHelp.Caption = "&Help";
			this.menuHelp.Id = 14;
			this.menuHelp.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
			new DevExpress.XtraBars.LinkPersistInfo(this.menuAbout)});
			this.menuHelp.Name = "menuHelp";
			//
			// menuAbout
			//
			this.menuAbout.Caption = "&About";
			this.menuAbout.Id = 15;
			this.menuAbout.Name = "menuAbout";
			this.menuAbout.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.menuAbout_ItemClick);
			//
			// barStatus
			//
			this.barStatus.BarName = "Status";
			this.barStatus.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
			this.barStatus.DockCol = 0;
			this.barStatus.DockRow = 0;
			this.barStatus.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
			this.barStatus.OptionsBar.AllowQuickCustomization = false;
			this.barStatus.OptionsBar.DrawDragBorder = false;
			this.barStatus.OptionsBar.UseWholeRow = true;
			this.barStatus.Text = "Status";
			//
			// splitContainerMain
			//
			this.splitContainerMain.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainerMain.Location = new System.Drawing.Point(0, 24);
			this.splitContainerMain.Name = "splitContainerMain";
			this.splitContainerMain.Panel1.Controls.Add(this.navBarLeft);
			this.splitContainerMain.Panel1.Text = "Panel1";
			this.splitContainerMain.Panel2.Text = "Panel2";
			this.splitContainerMain.Size = new System.Drawing.Size(741, 501);
			this.splitContainerMain.SplitterPosition = 160;
			this.splitContainerMain.TabIndex = 4;
			this.splitContainerMain.Text = "splitContainerControl1";
			//
			// navBarLeft
			//
			this.navBarLeft.ActiveGroup = this.nbgGeneral;
			this.navBarLeft.Dock = System.Windows.Forms.DockStyle.Fill;
			this.navBarLeft.Groups.AddRange(new DevExpress.XtraNavBar.NavBarGroup[] {
			this.nbgGeneral});
			this.navBarLeft.Items.AddRange(new DevExpress.XtraNavBar.NavBarItem[] {
			this.nbiBDBuilding
			,this.nbiBDTenant
			,this.nbiACCardHolder
			,this.nbiACMainZone
			,this.nbiACInterval
			,this.nbiACTimecode
			,this.nbiACAMFormat
			,this.nbiACOutputGroup
			,this.nbiACInputGroup
			,this.nbiACInput
			,this.nbiACFunctionCard
			,this.nbiACAccessLevel
			,this.nbiUtilHoliday
			,this.nbiUsrAccount
			,this.nbiACMasterCard
			,this.nbiACSupervisory
			,this.nbiUsrGroup
			,this.nbiBDVisitor
			,this.nbiACPanel
			});
			this.navBarLeft.LargeImages = this.imgLarge;
			this.navBarLeft.Location = new System.Drawing.Point(0, 0);
			this.navBarLeft.Name = "navBarLeft";
			this.navBarLeft.OptionsNavPane.ExpandedWidth = 156;
			this.navBarLeft.OptionsNavPane.ShowExpandButton = false;
			this.navBarLeft.PaintStyleKind = DevExpress.XtraNavBar.NavBarViewKind.NavigationPane;
			this.navBarLeft.Size = new System.Drawing.Size(156, 497);
			this.navBarLeft.SmallImages = this.imgSmall;
			this.navBarLeft.TabIndex = 0;
			this.navBarLeft.Text = "navBarControl1";
			this.navBarLeft.View = new DevExpress.XtraNavBar.ViewInfo.SkinNavigationPaneViewInfoRegistrator();
			//
			// imgLarge
			//
			this.imgLarge.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
			this.imgLarge.ImageSize = new System.Drawing.Size(16, 16);
			this.imgLarge.TransparentColor = System.Drawing.Color.Transparent;
			//
			// imgSmall
			//
			this.imgSmall.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
			this.imgSmall.ImageSize = new System.Drawing.Size(16, 16);
			this.imgSmall.TransparentColor = System.Drawing.Color.Transparent;
			//
			// nbgGeneral
			//
			this.nbgGeneral.Caption = "General";
			this.nbgGeneral.Expanded = true;
			this.nbgGeneral.Name = "nbgGeneral";
			this.nbgGeneral.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
			 new DevExpress.XtraNavBar.NavBarItemLink(this.nbiBDBuilding)
			,new DevExpress.XtraNavBar.NavBarItemLink(this.nbiBDTenant)
			,new DevExpress.XtraNavBar.NavBarItemLink(this.nbiACCardHolder)
			,new DevExpress.XtraNavBar.NavBarItemLink(this.nbiACMainZone)
			,new DevExpress.XtraNavBar.NavBarItemLink(this.nbiACInterval)
			,new DevExpress.XtraNavBar.NavBarItemLink(this.nbiACTimecode)
			,new DevExpress.XtraNavBar.NavBarItemLink(this.nbiACAMFormat)
			,new DevExpress.XtraNavBar.NavBarItemLink(this.nbiACOutputGroup)
			,new DevExpress.XtraNavBar.NavBarItemLink(this.nbiACInputGroup)
			,new DevExpress.XtraNavBar.NavBarItemLink(this.nbiACInput)
			,new DevExpress.XtraNavBar.NavBarItemLink(this.nbiACFunctionCard)
			,new DevExpress.XtraNavBar.NavBarItemLink(this.nbiACAccessLevel)
			,new DevExpress.XtraNavBar.NavBarItemLink(this.nbiUtilHoliday)
			,new DevExpress.XtraNavBar.NavBarItemLink(this.nbiUsrAccount)
			,new DevExpress.XtraNavBar.NavBarItemLink(this.nbiACMasterCard)
			,new DevExpress.XtraNavBar.NavBarItemLink(this.nbiACSupervisory)
			,new DevExpress.XtraNavBar.NavBarItemLink(this.nbiUsrGroup)
			,new DevExpress.XtraNavBar.NavBarItemLink(this.nbiBDVisitor)
			,new DevExpress.XtraNavBar.NavBarItemLink(this.nbiACPanel)
			});
            //
            // nbiBDBuilding
			//
			this.nbiBDBuilding.Caption = "BDBuilding";
			this.nbiBDBuilding.Name = "nbiBDBuilding";
			this.nbiBDBuilding.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.nbiBDBuilding_LinkClicked);
			//
			// nbiBDTenant
			//
			this.nbiBDTenant.Caption = "BDTenant";
			this.nbiBDTenant.Name = "nbiBDTenant";
			this.nbiBDTenant.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.nbiBDTenant_LinkClicked);
			//
			// nbiACCardHolder
			//
			this.nbiACCardHolder.Caption = "ACCardHolder";
			this.nbiACCardHolder.Name = "nbiACCardHolder";
			this.nbiACCardHolder.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.nbiACCardHolder_LinkClicked);
			//
			// nbiACMainZone
			//
			this.nbiACMainZone.Caption = "ACMainZone";
			this.nbiACMainZone.Name = "nbiACMainZone";
			this.nbiACMainZone.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.nbiACMainZone_LinkClicked);
			//
			// nbiACInterval
			//
			this.nbiACInterval.Caption = "ACInterval";
			this.nbiACInterval.Name = "nbiACInterval";
			this.nbiACInterval.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.nbiACInterval_LinkClicked);
			//
			// nbiACTimecode
			//
			this.nbiACTimecode.Caption = "ACTimecode";
			this.nbiACTimecode.Name = "nbiACTimecode";
			this.nbiACTimecode.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.nbiACTimecode_LinkClicked);
			//
			// nbiACAMFormat
			//
			this.nbiACAMFormat.Caption = "ACAMFormat";
			this.nbiACAMFormat.Name = "nbiACAMFormat";
			this.nbiACAMFormat.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.nbiACAMFormat_LinkClicked);
			//
			// nbiACOutputGroup
			//
			this.nbiACOutputGroup.Caption = "ACOutputGroup";
			this.nbiACOutputGroup.Name = "nbiACOutputGroup";
			this.nbiACOutputGroup.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.nbiACOutputGroup_LinkClicked);
			//
			// nbiACInputGroup
			//
			this.nbiACInputGroup.Caption = "ACInputGroup";
			this.nbiACInputGroup.Name = "nbiACInputGroup";
			this.nbiACInputGroup.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.nbiACInputGroup_LinkClicked);
			//
			// nbiACInput
			//
			this.nbiACInput.Caption = "ACInput";
			this.nbiACInput.Name = "nbiACInput";
			this.nbiACInput.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.nbiACInput_LinkClicked);
			//
			// nbiACFunctionCard
			//
			this.nbiACFunctionCard.Caption = "ACFunctionCard";
			this.nbiACFunctionCard.Name = "nbiACFunctionCard";
			this.nbiACFunctionCard.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.nbiACFunctionCard_LinkClicked);
			//
			// nbiACAccessLevel
			//
			this.nbiACAccessLevel.Caption = "ACAccessLevel";
			this.nbiACAccessLevel.Name = "nbiACAccessLevel";
			this.nbiACAccessLevel.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.nbiACAccessLevel_LinkClicked);
			//
			// nbiUtilHoliday
			//
			this.nbiUtilHoliday.Caption = "UtilHoliday";
			this.nbiUtilHoliday.Name = "nbiUtilHoliday";
			this.nbiUtilHoliday.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.nbiUtilHoliday_LinkClicked);
			//
			// nbiUsrAccount
			//
			this.nbiUsrAccount.Caption = "UsrAccount";
			this.nbiUsrAccount.Name = "nbiUsrAccount";
			this.nbiUsrAccount.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.nbiUsrAccount_LinkClicked);
			//
			// nbiACMasterCard
			//
			this.nbiACMasterCard.Caption = "ACMasterCard";
			this.nbiACMasterCard.Name = "nbiACMasterCard";
			this.nbiACMasterCard.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.nbiACMasterCard_LinkClicked);
			//
			// nbiACSupervisory
			//
			this.nbiACSupervisory.Caption = "ACSupervisory";
			this.nbiACSupervisory.Name = "nbiACSupervisory";
			this.nbiACSupervisory.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.nbiACSupervisory_LinkClicked);
			//
			// nbiUsrGroup
			//
			this.nbiUsrGroup.Caption = "UsrGroup";
			this.nbiUsrGroup.Name = "nbiUsrGroup";
			this.nbiUsrGroup.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.nbiUsrGroup_LinkClicked);
			//
			// nbiBDVisitor
			//
			this.nbiBDVisitor.Caption = "BDVisitor";
			this.nbiBDVisitor.Name = "nbiBDVisitor";
			this.nbiBDVisitor.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.nbiBDVisitor_LinkClicked);
			//
			// nbiACPanel
			//
			this.nbiACPanel.Caption = "ACPanel";
			this.nbiACPanel.Name = "nbiACPanel";
			this.nbiACPanel.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.nbiACPanel_LinkClicked);
			//
			// FormMain
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.ClientSize = new System.Drawing.Size(741, 547);
			this.Controls.Add(this.splitContainerMain);
			this.Controls.Add(this.barDockControlLeft);
			this.Controls.Add(this.barDockControlRight);
			this.Controls.Add(this.barDockControlBottom);
			this.Controls.Add(this.barDockControlTop);
			this.Name = "FormMain";
			this.Text = "Manager";
			((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).EndInit();
			this.splitContainerMain.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.navBarLeft)).EndInit();
			this.ResumeLayout(false);
		}

		#endregion

		private DevExpress.XtraBars.BarManager barManager1;
		private DevExpress.XtraBars.BarDockControl barDockControlTop;
		private DevExpress.XtraBars.BarDockControl barDockControlBottom;
		private DevExpress.XtraBars.BarDockControl barDockControlLeft;
		private DevExpress.XtraBars.BarDockControl barDockControlRight;
		private DevExpress.XtraBars.Bar barMainMenu;
		private DevExpress.XtraBars.Bar barStatus;

		private DevExpress.XtraEditors.SplitContainerControl splitContainerMain;
		private DevExpress.XtraNavBar.NavBarControl navBarLeft;
		private DevExpress.XtraBars.BarSubItem menuFile;
		private DevExpress.XtraBars.BarButtonItem menuFileClose;
		private DevExpress.XtraBars.BarButtonItem menuFileCloseAll;
		private DevExpress.XtraBars.BarButtonItem menuExit;
		private DevExpress.XtraBars.BarSubItem menuDictionary;
		private DevExpress.XtraBars.BarButtonItem menuUtilHoliday;
		private DevExpress.XtraBars.BarSubItem menuTools;
		private DevExpress.XtraBars.BarButtonItem menuChangePassword;
		private DevExpress.XtraBars.BarButtonItem menuWhoAmI;
		private DevExpress.XtraBars.BarButtonItem menuUserAccount;
		private DevExpress.XtraBars.BarSubItem menuWindow;
		private DevExpress.XtraBars.BarListItem menuWindowsList;
		private DevExpress.XtraBars.BarSubItem menuHelp;
		private DevExpress.XtraBars.BarButtonItem menuAbout;
		private System.Windows.Forms.ImageList imgSmall;
		private System.Windows.Forms.ImageList imgLarge;
		private DevExpress.XtraNavBar.NavBarGroup nbgGeneral;

		private DevExpress.XtraNavBar.NavBarItem nbiBDBuilding;
		private DevExpress.XtraNavBar.NavBarItem nbiBDTenant;
		private DevExpress.XtraNavBar.NavBarItem nbiACCardHolder;
		private DevExpress.XtraNavBar.NavBarItem nbiACMainZone;
		private DevExpress.XtraNavBar.NavBarItem nbiACInterval;
		private DevExpress.XtraNavBar.NavBarItem nbiACTimecode;
		private DevExpress.XtraNavBar.NavBarItem nbiACAMFormat;
		private DevExpress.XtraNavBar.NavBarItem nbiACOutputGroup;
		private DevExpress.XtraNavBar.NavBarItem nbiACInputGroup;
		private DevExpress.XtraNavBar.NavBarItem nbiACInput;
		private DevExpress.XtraNavBar.NavBarItem nbiACFunctionCard;
		private DevExpress.XtraNavBar.NavBarItem nbiACAccessLevel;
		private DevExpress.XtraNavBar.NavBarItem nbiUtilHoliday;
		private DevExpress.XtraNavBar.NavBarItem nbiUsrAccount;
		private DevExpress.XtraNavBar.NavBarItem nbiACMasterCard;
		private DevExpress.XtraNavBar.NavBarItem nbiACSupervisory;
		private DevExpress.XtraNavBar.NavBarItem nbiUsrGroup;
		private DevExpress.XtraNavBar.NavBarItem nbiBDVisitor;
		private DevExpress.XtraNavBar.NavBarItem nbiACPanel;
	}
}
