using System;
using System.Data;
using System.IO;
using System.Windows.Forms;
using Cheke.WinCtrl;
using Cheke.WinCtrl.Login;
using DevExpress.XtraBars;
using DevExpress.XtraNavBar;
using W3000.Manager.FormWorkList;
using W3000.ViewObj;

namespace W3000.Manager
{
	public partial class FormMain : FormMainBase
	{
		private static FormMain _Instance = null;
        private UsrAccount _user = null;

		public FormMain()
		{
			InitializeComponent();
		}

		public FormMain(string userid)
			: base(userid)
		{
			InitializeComponent();
			_Instance = this;
		}

		protected override Control WorkArea
		{
			get { return this.splitContainerMain.Panel2; }
		}

		internal static FormMain Instance
		{
			get { return _Instance; }
		}
        internal UsrAccount User
        {
            get { return this._user; }
        }

	    protected override void InitializeForm()
	    {
	        base.InitializeForm();

	        this._user = UsrAccount.GetByUserID(base.UserId);
	        if (this._user == null)
	        {
	            this.Enabled = false;
	        }
	    }

        #region Excel
        public override DataSet LoadFromExcel(string fileName)
        {
            byte[] data = File.ReadAllBytes(fileName);
            return BizExcel.LoadIntoDataSet(data, true);
        }
        #endregion

	    #region menu Windows
		private void menuWindowsList_GetItemData(object sender, EventArgs e)
		{
			this.menuWindowsList.Strings.Clear();

			foreach (Form item in Application.OpenForms)
			{
				if (item.Parent == this.WorkArea)
				{
					this.menuWindowsList.Strings.Add(item.Text);
					if (this.WorkArea.Controls.GetChildIndex(item) == 0)
					{
						this.menuWindowsList.ItemIndex = this.menuWindowsList.Strings.Count - 1;
					}
				}
			}
		}
		private void menuWindowsList_ListItemClick(object sender, ListItemClickEventArgs e)
		{
			foreach (Form item in Application.OpenForms)
			{
				if (item.Text == this.menuWindowsList.Strings[e.Index])
				{
					item.BringToFront();
				}
			}
		}
		#endregion

		#region menu File
		private void menuFileClose_ItemClick(object sender, ItemClickEventArgs e)
		{
			base.CloseTopMostChild();
		}
		private void menuFileCloseAll_ItemClick(object sender, ItemClickEventArgs e)
		{
			base.CloseAllChildren();
		}
		private void menuExit_ItemClick(object sender, ItemClickEventArgs e)
		{
			this.Close();
		}
		#endregion

		#region menu Dictionary
	
		private void menuUtilHoliday_ItemClick(object sender, ItemClickEventArgs e)
		{
			base.ShowChildForm(typeof (FormWorkUtilHolidayList));
		}

		#endregion

		#region menu Tools
		private void menuChangePassword_ItemClick(object sender, ItemClickEventArgs e)
		{
			FormChangePassword dlg = new FormChangePassword(base.UserId, new LoginService());
			dlg.ShowDialog();
		}

		private void menuWhoAmI_ItemClick(object sender, ItemClickEventArgs e)
		{
			base.ShowMessage(string.Format("I am {0}.", base.UserId));
		}

		private void menuUserAccount_ItemClick(object sender, ItemClickEventArgs e)
		{
			//base.ShowChildForm(typeof (FormWorkUsrAccountList));
		}
		#endregion

		#region menu Help
		private void menuAbout_ItemClick(object sender, ItemClickEventArgs e)
		{
			FormAboutBox dlg = new FormAboutBox();
			dlg.ShowDialog();
		}
		#endregion

		#region General
		
		private void nbiBDBuilding_LinkClicked(object sender, NavBarLinkEventArgs e)
		{
			base.ShowChildForm(typeof (FormWorkBDBuildingList));
		}
		private void nbiBDTenant_LinkClicked(object sender, NavBarLinkEventArgs e)
		{
			base.ShowChildForm(typeof (FormWorkBDTenantList));
		}
		
		private void nbiACCardHolder_LinkClicked(object sender, NavBarLinkEventArgs e)
		{
			base.ShowChildForm(typeof (FormWorkACCardHolderList));
		}
		private void nbiACMainZone_LinkClicked(object sender, NavBarLinkEventArgs e)
		{
			base.ShowChildForm(typeof (FormWorkACMainZoneList));
		}
		private void nbiACInterval_LinkClicked(object sender, NavBarLinkEventArgs e)
		{
			base.ShowChildForm(typeof (FormWorkACIntervalList));
		}
		
		private void nbiACTimecode_LinkClicked(object sender, NavBarLinkEventArgs e)
		{
			base.ShowChildForm(typeof (FormWorkACTimecodeList));
		}
		
		private void nbiACAMFormat_LinkClicked(object sender, NavBarLinkEventArgs e)
		{
			base.ShowChildForm(typeof (FormWorkACAMFormatList));
		}
		
		private void nbiACOutputGroup_LinkClicked(object sender, NavBarLinkEventArgs e)
		{
			base.ShowChildForm(typeof (FormWorkACOutputGroupList));
		}
		
		private void nbiACInputGroup_LinkClicked(object sender, NavBarLinkEventArgs e)
		{
			base.ShowChildForm(typeof (FormWorkACInputGroupList));
		}
		private void nbiACInput_LinkClicked(object sender, NavBarLinkEventArgs e)
		{
			base.ShowChildForm(typeof (FormWorkACInputList));
		}
		private void nbiACFunctionCard_LinkClicked(object sender, NavBarLinkEventArgs e)
		{
			base.ShowChildForm(typeof (FormWorkACFunctionCardList));
		}
		private void nbiACAccessLevel_LinkClicked(object sender, NavBarLinkEventArgs e)
		{
			base.ShowChildForm(typeof (FormWorkACAccessLevelList));
		}
		
		private void nbiUtilHoliday_LinkClicked(object sender, NavBarLinkEventArgs e)
		{
			base.ShowChildForm(typeof (FormWorkUtilHolidayList));
		}
		
		private void nbiUsrAccount_LinkClicked(object sender, NavBarLinkEventArgs e)
		{
			base.ShowChildForm(typeof (FormWorkUsrAccountList));
		}
		
		private void nbiACMasterCard_LinkClicked(object sender, NavBarLinkEventArgs e)
		{
			base.ShowChildForm(typeof (FormWorkACMasterCardList));
		}
		private void nbiACSupervisory_LinkClicked(object sender, NavBarLinkEventArgs e)
		{
			base.ShowChildForm(typeof (FormWorkACSupervisoryList));
		}
		private void nbiUsrGroup_LinkClicked(object sender, NavBarLinkEventArgs e)
		{
			base.ShowChildForm(typeof (FormWorkUsrGroupList));
		}
	
		private void nbiBDVisitor_LinkClicked(object sender, NavBarLinkEventArgs e)
		{
			base.ShowChildForm(typeof (FormWorkBDVisitorList));
		}
		
		private void nbiACPanel_LinkClicked(object sender, NavBarLinkEventArgs e)
		{
			base.ShowChildForm(typeof (FormWorkACPanelList));
		}
		
		#endregion
	}
}
