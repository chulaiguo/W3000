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
	public partial class FormDetailACSupervisory : FormDetailEditorBase
	{

		public FormDetailACSupervisory()
		{
			InitializeComponent();
		}

		public FormDetailACSupervisory(string userid, ACSupervisory entity)
			: base(userid, entity)
		{
			InitializeComponent();
		}

		protected override void InitializeDecorator()
		{
		}

		private ACSupervisory ACSupervisory
		{
			get{ return base.Entity as ACSupervisory; }
		}

		protected override void DataBindingEntity()
		{
			this.txtSupervisoryID.BindingData(this.ACSupervisory, ACSupervisorySchema.SupervisoryID);
			this.txtDescription.BindingData(this.ACSupervisory, ACSupervisorySchema.Description);
			this.txtDebounce.BindingData(this.ACSupervisory, ACSupervisorySchema.Debounce);
			this.txtForceAMFormat.BindingData(this.ACSupervisory, ACSupervisorySchema.ForceAMFormat);
			this.chkExternal.BindingData(this.ACSupervisory, ACSupervisorySchema.External);
			this.txtNotes.BindingData(this.ACSupervisory, ACSupervisorySchema.Notes);
			this.txtPanelZoneID.BindingData(this.ACSupervisory, ACSupervisorySchema.PanelZoneID);
			this.chkLocked.BindingData(this.ACSupervisory, ACSupervisorySchema.Locked);

			this.txtACPanel.Text = this.ACSupervisory.UnitID.ToString();
		}

		private void txtACPanel_ButtonClick(object sender, ButtonPressedEventArgs e)
		{
			if (e.Button.Kind == ButtonPredefines.Delete)
			{
				if (this.ACSupervisory.ACPanelPK == Guid.Empty)
					return;

				if (DialogResult.Yes != base.ShowQuestion(string.Format("Are you sure you want to clear the {0}?", this.txtACPanel.Title)))
					return;

				this.ACSupervisory.ACPanelPK = Guid.Empty;
				this.txtACPanel.Text = string.Empty;
			}
			else
			{
				FormSelectACPanel dlg = new FormSelectACPanel(base.UserId);
				dlg.MultiSelect = false;
				if (dlg.ShowDialog() != System.Windows.Forms.DialogResult.OK)
					return;

				if (this.ACSupervisory.ACPanelPK == dlg.ACPanel.ACPanelPK)
					return;

				this.ACSupervisory.ACPanel = dlg.ACPanel;
				this.txtACPanel.Text = dlg.ACPanel.UnitID.ToString();
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
