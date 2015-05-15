using System;
using System.Windows.Forms;
using Cheke.WinCtrl;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using W3000.ViewObj;
using W3000.Schema;
using W3000.Manager.FormSelect;
using W3000.Manager.GridDecorator;

namespace W3000.Manager.FormDetailEditor
{
	public partial class FormDetailACMasterCard : FormDetailEditorBase
	{

		public FormDetailACMasterCard()
		{
			InitializeComponent();
		}

		public FormDetailACMasterCard(string userid, ACMasterCard entity)
			: base(userid, entity)
		{
			InitializeComponent();
		}

		protected override void InitializeDecorator()
		{
		}

		private ACMasterCard ACMasterCard
		{
			get{ return base.Entity as ACMasterCard; }
		}

		protected override void DataBindingEntity()
		{
			this.txtSitecode.BindingData(this.ACMasterCard, ACMasterCardSchema.Sitecode);
			this.txtEmbossed.BindingData(this.ACMasterCard, ACMasterCardSchema.Embossed);
			this.txtEncoded.BindingData(this.ACMasterCard, ACMasterCardSchema.Encoded);
			this.txtCardTypeID.BindingData(this.ACMasterCard, ACMasterCardSchema.CardTypeID);
			this.txtFirstName.BindingData(this.ACMasterCard, ACMasterCardSchema.FirstName);
			this.txtLastName.BindingData(this.ACMasterCard, ACMasterCardSchema.LastName);
			this.chkFIPS.BindingData(this.ACMasterCard, ACMasterCardSchema.FIPS);
			this.txtPin.BindingData(this.ACMasterCard, ACMasterCardSchema.Pin);

		}

		private void xtraTabControl1_SelectedPageChanged(object sender, DevExpress.XtraTab.TabPageChangedEventArgs e)
		{
			if (this.xtraTabControl1.SelectedTabPage == this.tabDetail)
			{
				this.ShowNewButton = true;
				this.ShowDeleteButton = true;
			}
			else
			{
				this.ShowNewButton = false;
				this.ShowDeleteButton = false;
			}

			this.xtraTabControl1.SelectedTabPage.Focus();
		}

	}
}
