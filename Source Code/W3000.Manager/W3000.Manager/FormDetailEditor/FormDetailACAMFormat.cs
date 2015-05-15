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
	public partial class FormDetailACAMFormat : FormDetailEditorBase
	{

		public FormDetailACAMFormat()
		{
			InitializeComponent();
		}

		public FormDetailACAMFormat(string userid, ACAMFormat entity)
			: base(userid, entity)
		{
			InitializeComponent();
		}

		protected override void InitializeDecorator()
		{
		}

		private ACAMFormat ACAMFormat
		{
			get{ return base.Entity as ACAMFormat; }
		}

		protected override void DataBindingEntity()
		{
			this.txtAMFID.BindingData(this.ACAMFormat, ACAMFormatSchema.AMFID);
			this.txtSummary.BindingData(this.ACAMFormat, ACAMFormatSchema.Summary);
			this.txtNotes.BindingData(this.ACAMFormat, ACAMFormatSchema.Notes);
			this.txtReportTC.BindingData(this.ACAMFormat, ACAMFormatSchema.ReportTC);
			this.txtAlarmTC.BindingData(this.ACAMFormat, ACAMFormatSchema.AlarmTC);
			this.txtPreAlarmTC.BindingData(this.ACAMFormat, ACAMFormatSchema.PreAlarmTC);

			this.txtBDBuilding.Text = this.ACAMFormat.Address1.ToString();
		}

		private void txtBDBuilding_ButtonClick(object sender, ButtonPressedEventArgs e)
		{
			if (e.Button.Kind == ButtonPredefines.Delete)
			{
				if (this.ACAMFormat.BDBuildingPK == Guid.Empty)
					return;

				if (DialogResult.Yes != base.ShowQuestion(string.Format("Are you sure you want to clear the {0}?", this.txtBDBuilding.Title)))
					return;

				this.ACAMFormat.BDBuildingPK = Guid.Empty;
				this.txtBDBuilding.Text = string.Empty;
			}
			else
			{
				FormSelectBDBuilding dlg = new FormSelectBDBuilding(base.UserId);
				dlg.MultiSelect = false;
				if (dlg.ShowDialog() != System.Windows.Forms.DialogResult.OK)
					return;

				if (this.ACAMFormat.BDBuildingPK == dlg.BDBuilding.BDBuildingPK)
					return;

				this.ACAMFormat.BDBuilding = dlg.BDBuilding;
				this.txtBDBuilding.Text = dlg.BDBuilding.Address1.ToString();
			}
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
