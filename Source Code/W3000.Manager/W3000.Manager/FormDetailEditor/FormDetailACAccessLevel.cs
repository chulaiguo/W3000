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
	public partial class FormDetailACAccessLevel : FormDetailEditorBase
	{
		private GridACAccessLevelDetailDecorator _decorateACAccessLevelDetail = null;

		public FormDetailACAccessLevel()
		{
			InitializeComponent();
		}

		public FormDetailACAccessLevel(string userid, ACAccessLevel entity)
			: base(userid, entity)
		{
			InitializeComponent();
		}

		protected override void InitializeDecorator()
		{
			this._decorateACAccessLevelDetail = new GridACAccessLevelDetailDecorator(base.UserId, this.grdACAccessLevelDetail);
			this._decorateACAccessLevelDetail.Initialize();

		}

		private ACAccessLevel ACAccessLevel
		{
			get{ return base.Entity as ACAccessLevel; }
		}

		protected override void DataBindingEntity()
		{
			this.txtAccessLevelID.BindingData(this.ACAccessLevel, ACAccessLevelSchema.AccessLevelID);
			this.txtSummary.BindingData(this.ACAccessLevel, ACAccessLevelSchema.Summary);
			this.chkAsAL2.BindingData(this.ACAccessLevel, ACAccessLevelSchema.AsAL2);
			this.txtNotes.BindingData(this.ACAccessLevel, ACAccessLevelSchema.Notes);

			this.txtBDBuilding.Text = this.ACAccessLevel.Address1.ToString();
		}

		private void txtBDBuilding_ButtonClick(object sender, ButtonPressedEventArgs e)
		{
			if (e.Button.Kind == ButtonPredefines.Delete)
			{
				if (this.ACAccessLevel.BDBuildingPK == Guid.Empty)
					return;

				if (DialogResult.Yes != base.ShowQuestion(string.Format("Are you sure you want to clear the {0}?", this.txtBDBuilding.Title)))
					return;

				this.ACAccessLevel.BDBuildingPK = Guid.Empty;
				this.txtBDBuilding.Text = string.Empty;
			}
			else
			{
				FormSelectBDBuilding dlg = new FormSelectBDBuilding(base.UserId);
				dlg.MultiSelect = false;
				if (dlg.ShowDialog() != System.Windows.Forms.DialogResult.OK)
					return;

				if (this.ACAccessLevel.BDBuildingPK == dlg.BDBuilding.BDBuildingPK)
					return;

				this.ACAccessLevel.BDBuilding = dlg.BDBuilding;
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

		private void tabACAccessLevelDetail_Enter(object sender, System.EventArgs e)
		{
			if (this.tabACAccessLevelDetail.Tag == null)
			{
				if (this.ACAccessLevel.IsNew)
				{
					this._decorateACAccessLevelDetail.DataSource = null;
					return;
				}

				this.tabACAccessLevelDetail.Tag = true;

				if (this.ACAccessLevel.ACAccessLevelDetailList == null || base.IsRefreshData)
				{
					 this.ACAccessLevel.ACAccessLevelDetailList = ACAccessLevelDetail.GetByACAccessLevel(this.ACAccessLevel.ACAccessLevelPK);
				}

				this._decorateACAccessLevelDetail.ACAccessLevel = this.ACAccessLevel;
				this._decorateACAccessLevelDetail.DataSource = this.ACAccessLevel.ACAccessLevelDetailList;
			}
		}

	}
}
