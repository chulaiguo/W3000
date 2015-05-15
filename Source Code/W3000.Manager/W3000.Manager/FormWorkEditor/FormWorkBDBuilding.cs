using System;
using System.Windows.Forms;
using DevExpress.XtraTab;
using Cheke.WinCtrl;
using W3000.ViewObj;
using W3000.Schema;

namespace W3000.Manager.FormWorkEditor
{
	public partial class FormWorkBDBuilding : FormWorkEditorBase
	{

		public FormWorkBDBuilding()
		{
			InitializeComponent();
		}

		public FormWorkBDBuilding(string userId, Control parent, BDBuilding entity)
			: base(userId, parent, entity)
		{
			InitializeComponent();
		}

		private BDBuilding BDBuilding
		{
			get{ return base.Entity as BDBuilding; }
		}

		protected override void UpdateUI(bool isDirty)
		{
			base.UpdateUI(isDirty);

			if (this.BDBuilding.IsNew)
			{
				this.Caption = string.Format("New BDBuilding Created At {0}", DateTime.Now.ToLongTimeString());
			}
			else
			{
				this.Caption = "BDBuilding";//BDBuildingSchema.XXX
			}
		}

		private void xtraTabControl1_SelectedPageChanged(object sender, TabPageChangedEventArgs e)
		{
			if (e.Page == this.tabBDBuilding)
			{
				this.ShowDeleteButton = true;
				this.ShowNewButton = true;
			}
			else
			{
				this.ShowDeleteButton = false;
				this.ShowNewButton = false;
			}

			this.DataBinding();
		}

		private void tabBDBuilding_Enter(object sender, EventArgs e)
		{
			if (this.tabBDBuilding.Tag == null)
			{
				this.tabBDBuilding.Tag = true;

				this.txtBuildingID.BindingData(this.BDBuilding, BDBuildingSchema.BuildingID);
				this.txtBuildingName.BindingData(this.BDBuilding, BDBuildingSchema.BuildingName);
				this.txtAddress1.BindingData(this.BDBuilding, BDBuildingSchema.Address1);
				this.txtStreetNumb.BindingData(this.BDBuilding, BDBuildingSchema.StreetNumb);
				this.txtStreetName.BindingData(this.BDBuilding, BDBuildingSchema.StreetName);
				this.txtAddress2.BindingData(this.BDBuilding, BDBuildingSchema.Address2);
				this.txtCity.BindingData(this.BDBuilding, BDBuildingSchema.City);
				this.txtState.BindingData(this.BDBuilding, BDBuildingSchema.State);
				this.txtZipcode.BindingData(this.BDBuilding, BDBuildingSchema.Zipcode);
				this.txtCounty.BindingData(this.BDBuilding, BDBuildingSchema.County);
				this.txtTimezoneID.BindingData(this.BDBuilding, BDBuildingSchema.TimezoneID);
				this.chkFederal.BindingData(this.BDBuilding, BDBuildingSchema.Federal);
				this.txtPhone.BindingData(this.BDBuilding, BDBuildingSchema.Phone);
				this.txtFax.BindingData(this.BDBuilding, BDBuildingSchema.Fax);
				this.txtBldgNotes.BindingData(this.BDBuilding, BDBuildingSchema.BldgNotes);
				this.txtCardNotes.BindingData(this.BDBuilding, BDBuildingSchema.CardNotes);
				this.txtElevTrapNotes.BindingData(this.BDBuilding, BDBuildingSchema.ElevTrapNotes);
				this.txtVisitorNotes.BindingData(this.BDBuilding, BDBuildingSchema.VisitorNotes);
				this.txtSystemTypeID.BindingData(this.BDBuilding, BDBuildingSchema.SystemTypeID);
				this.txtCountryID.BindingData(this.BDBuilding, BDBuildingSchema.CountryID);
				this.txtVisitorSiteCode.BindingData(this.BDBuilding, BDBuildingSchema.VisitorSiteCode);
				this.txtWinUITypeID.BindingData(this.BDBuilding, BDBuildingSchema.WinUITypeID);
				this.dateLastExportParkingTag.BindingData(this.BDBuilding, BDBuildingSchema.LastExportParkingTag);
				this.txtAutoIssueNotifyEmail.BindingData(this.BDBuilding, BDBuildingSchema.AutoIssueNotifyEmail);
				this.txtCardKeyMode.BindingData(this.BDBuilding, BDBuildingSchema.CardKeyMode);
				this.txtAccessLevelMode.BindingData(this.BDBuilding, BDBuildingSchema.AccessLevelMode);
				this.chkHotClient.BindingData(this.BDBuilding, BDBuildingSchema.HotClient);
				this.dateHotExpire.BindingData(this.BDBuilding, BDBuildingSchema.HotExpire);

			}
		}

	}
}
