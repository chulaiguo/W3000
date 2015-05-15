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
	public partial class FormDetailACInput : FormDetailEditorBase
	{
		private GridACInputGroupInputMapDecorator _decorateACInputGroupInputMap = null;

		public FormDetailACInput()
		{
			InitializeComponent();
		}

		public FormDetailACInput(string userid, ACInput entity)
			: base(userid, entity)
		{
			InitializeComponent();
		}

		protected override void InitializeDecorator()
		{
			this._decorateACInputGroupInputMap = new GridACInputGroupInputMapDecorator(base.UserId, this.grdACInputGroupInputMap);
			this._decorateACInputGroupInputMap.Initialize();

		}

		private ACInput ACInput
		{
			get{ return base.Entity as ACInput; }
		}

		protected override void DataBindingEntity()
		{
			this.txtInputID.BindingData(this.ACInput, ACInputSchema.InputID);
			this.txtDescription.BindingData(this.ACInput, ACInputSchema.Description);
			this.txtDebounce.BindingData(this.ACInput, ACInputSchema.Debounce);
			this.chkReverse.BindingData(this.ACInput, ACInputSchema.Reverse);
			this.txtForceAMFormat.BindingData(this.ACInput, ACInputSchema.ForceAMFormat);
			this.chkOffOnRestore.BindingData(this.ACInput, ACInputSchema.OffOnRestore);
			this.chkExternal.BindingData(this.ACInput, ACInputSchema.External);
			this.txtNotes.BindingData(this.ACInput, ACInputSchema.Notes);
			this.chkAlwaysToMAS.BindingData(this.ACInput, ACInputSchema.AlwaysToMAS);
			this.txtPanelZoneID.BindingData(this.ACInput, ACInputSchema.PanelZoneID);
			this.chkLocked.BindingData(this.ACInput, ACInputSchema.Locked);

			this.txtACPanel.Text = this.ACInput.UnitID.ToString();
		}

		private void txtACPanel_ButtonClick(object sender, ButtonPressedEventArgs e)
		{
			if (e.Button.Kind == ButtonPredefines.Delete)
			{
				if (this.ACInput.ACPanelPK == Guid.Empty)
					return;

				if (DialogResult.Yes != base.ShowQuestion(string.Format("Are you sure you want to clear the {0}?", this.txtACPanel.Title)))
					return;

				this.ACInput.ACPanelPK = Guid.Empty;
				this.txtACPanel.Text = string.Empty;
			}
			else
			{
				FormSelectACPanel dlg = new FormSelectACPanel(base.UserId);
				dlg.MultiSelect = false;
				if (dlg.ShowDialog() != System.Windows.Forms.DialogResult.OK)
					return;

				if (this.ACInput.ACPanelPK == dlg.ACPanel.ACPanelPK)
					return;

				this.ACInput.ACPanel = dlg.ACPanel;
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

		private void tabACInputGroupInputMap_Enter(object sender, System.EventArgs e)
		{
			if (this.tabACInputGroupInputMap.Tag == null)
			{
				if (this.ACInput.IsNew)
				{
					this._decorateACInputGroupInputMap.DataSource = null;
					return;
				}

				this.tabACInputGroupInputMap.Tag = true;

				if (this.ACInput.ACInputGroupInputMapList == null || base.IsRefreshData)
				{
					 this.ACInput.ACInputGroupInputMapList = ACInputGroupInputMap.GetByACInput(this.ACInput.ACInputPK);
				}

				this._decorateACInputGroupInputMap.ACInput = this.ACInput;
				this._decorateACInputGroupInputMap.DataSource = this.ACInput.ACInputGroupInputMapList;
			}
		}

	}
}
