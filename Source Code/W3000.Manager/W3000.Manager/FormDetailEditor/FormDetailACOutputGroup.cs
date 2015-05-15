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
	public partial class FormDetailACOutputGroup : FormDetailEditorBase
	{
		private GridACOutputGroupMainZoneMapDecorator _decorateACOutputGroupMainZoneMap = null;

		public FormDetailACOutputGroup()
		{
			InitializeComponent();
		}

		public FormDetailACOutputGroup(string userid, ACOutputGroup entity)
			: base(userid, entity)
		{
			InitializeComponent();
		}

		protected override void InitializeDecorator()
		{
			this._decorateACOutputGroupMainZoneMap = new GridACOutputGroupMainZoneMapDecorator(base.UserId, this.grdACOutputGroupMainZoneMap);
			this._decorateACOutputGroupMainZoneMap.Initialize();

		}

		private ACOutputGroup ACOutputGroup
		{
			get{ return base.Entity as ACOutputGroup; }
		}

		protected override void DataBindingEntity()
		{
			this.txtGroupID.BindingData(this.ACOutputGroup, ACOutputGroupSchema.GroupID);
			this.txtSummary.BindingData(this.ACOutputGroup, ACOutputGroupSchema.Summary);

			this.txtACPanel.Text = this.ACOutputGroup.UnitID.ToString();
		}

		private void txtACPanel_ButtonClick(object sender, ButtonPressedEventArgs e)
		{
			if (e.Button.Kind == ButtonPredefines.Delete)
			{
				if (this.ACOutputGroup.ACPanelPK == Guid.Empty)
					return;

				if (DialogResult.Yes != base.ShowQuestion(string.Format("Are you sure you want to clear the {0}?", this.txtACPanel.Title)))
					return;

				this.ACOutputGroup.ACPanelPK = Guid.Empty;
				this.txtACPanel.Text = string.Empty;
			}
			else
			{
				FormSelectACPanel dlg = new FormSelectACPanel(base.UserId);
				dlg.MultiSelect = false;
				if (dlg.ShowDialog() != System.Windows.Forms.DialogResult.OK)
					return;

				if (this.ACOutputGroup.ACPanelPK == dlg.ACPanel.ACPanelPK)
					return;

				this.ACOutputGroup.ACPanel = dlg.ACPanel;
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

		private void tabACOutputGroupMainZoneMap_Enter(object sender, System.EventArgs e)
		{
			if (this.tabACOutputGroupMainZoneMap.Tag == null)
			{
				if (this.ACOutputGroup.IsNew)
				{
					this._decorateACOutputGroupMainZoneMap.DataSource = null;
					return;
				}

				this.tabACOutputGroupMainZoneMap.Tag = true;

				if (this.ACOutputGroup.ACOutputGroupMainZoneMapList == null || base.IsRefreshData)
				{
					 this.ACOutputGroup.ACOutputGroupMainZoneMapList = ACOutputGroupMainZoneMap.GetByACOutputGroup(this.ACOutputGroup.ACOutputGroupPK);
				}

				this._decorateACOutputGroupMainZoneMap.ACOutputGroup = this.ACOutputGroup;
				this._decorateACOutputGroupMainZoneMap.DataSource = this.ACOutputGroup.ACOutputGroupMainZoneMapList;
			}
		}

	}
}
