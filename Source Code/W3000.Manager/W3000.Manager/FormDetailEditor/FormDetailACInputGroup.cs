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
	public partial class FormDetailACInputGroup : FormDetailEditorBase
	{
		private GridACInputGroupInputMapDecorator _decorateACInputGroupInputMap = null;

		public FormDetailACInputGroup()
		{
			InitializeComponent();
		}

		public FormDetailACInputGroup(string userid, ACInputGroup entity)
			: base(userid, entity)
		{
			InitializeComponent();
		}

		protected override void InitializeDecorator()
		{
			this._decorateACInputGroupInputMap = new GridACInputGroupInputMapDecorator(base.UserId, this.grdACInputGroupInputMap);
			this._decorateACInputGroupInputMap.Initialize();

		}

		private ACInputGroup ACInputGroup
		{
			get{ return base.Entity as ACInputGroup; }
		}

		protected override void DataBindingEntity()
		{
			this.txtGroupID.BindingData(this.ACInputGroup, ACInputGroupSchema.GroupID);
			this.txtSummary.BindingData(this.ACInputGroup, ACInputGroupSchema.Summary);

			this.txtACPanel.Text = this.ACInputGroup.UnitID.ToString();
		}

		private void txtACPanel_ButtonClick(object sender, ButtonPressedEventArgs e)
		{
			if (e.Button.Kind == ButtonPredefines.Delete)
			{
				if (this.ACInputGroup.ACPanelPK == Guid.Empty)
					return;

				if (DialogResult.Yes != base.ShowQuestion(string.Format("Are you sure you want to clear the {0}?", this.txtACPanel.Title)))
					return;

				this.ACInputGroup.ACPanelPK = Guid.Empty;
				this.txtACPanel.Text = string.Empty;
			}
			else
			{
				FormSelectACPanel dlg = new FormSelectACPanel(base.UserId);
				dlg.MultiSelect = false;
				if (dlg.ShowDialog() != System.Windows.Forms.DialogResult.OK)
					return;

				if (this.ACInputGroup.ACPanelPK == dlg.ACPanel.ACPanelPK)
					return;

				this.ACInputGroup.ACPanel = dlg.ACPanel;
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
				if (this.ACInputGroup.IsNew)
				{
					this._decorateACInputGroupInputMap.DataSource = null;
					return;
				}

				this.tabACInputGroupInputMap.Tag = true;

				if (this.ACInputGroup.ACInputGroupInputMapList == null || base.IsRefreshData)
				{
					 this.ACInputGroup.ACInputGroupInputMapList = ACInputGroupInputMap.GetByACInputGroup(this.ACInputGroup.ACInputGroupPK);
				}

				this._decorateACInputGroupInputMap.ACInputGroup = this.ACInputGroup;
				this._decorateACInputGroupInputMap.DataSource = this.ACInputGroup.ACInputGroupInputMapList;
			}
		}

	}
}
