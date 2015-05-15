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
	public partial class FormDetailACTimecode : FormDetailEditorBase
	{
		private GridACAccessLevelDetailDecorator _decorateACAccessLevelDetail = null;
		private GridACTimecodeIntervalMapDecorator _decorateACTimecodeIntervalMap = null;

		public FormDetailACTimecode()
		{
			InitializeComponent();
		}

		public FormDetailACTimecode(string userid, ACTimecode entity)
			: base(userid, entity)
		{
			InitializeComponent();
		}

		protected override void InitializeDecorator()
		{
			this._decorateACAccessLevelDetail = new GridACAccessLevelDetailDecorator(base.UserId, this.grdACAccessLevelDetail);
			this._decorateACAccessLevelDetail.Initialize();

			this._decorateACTimecodeIntervalMap = new GridACTimecodeIntervalMapDecorator(base.UserId, this.grdACTimecodeIntervalMap);
			this._decorateACTimecodeIntervalMap.Initialize();

		}

		private ACTimecode ACTimecode
		{
			get{ return base.Entity as ACTimecode; }
		}

		protected override void DataBindingEntity()
		{
			this.txtTCID.BindingData(this.ACTimecode, ACTimecodeSchema.TCID);
			this.txtSummary.BindingData(this.ACTimecode, ACTimecodeSchema.Summary);
			this.txtNotes.BindingData(this.ACTimecode, ACTimecodeSchema.Notes);

			this.txtBDBuilding.Text = this.ACTimecode.Address1.ToString();
		}

		private void txtBDBuilding_ButtonClick(object sender, ButtonPressedEventArgs e)
		{
			if (e.Button.Kind == ButtonPredefines.Delete)
			{
				if (this.ACTimecode.BDBuildingPK == Guid.Empty)
					return;

				if (DialogResult.Yes != base.ShowQuestion(string.Format("Are you sure you want to clear the {0}?", this.txtBDBuilding.Title)))
					return;

				this.ACTimecode.BDBuildingPK = Guid.Empty;
				this.txtBDBuilding.Text = string.Empty;
			}
			else
			{
				FormSelectBDBuilding dlg = new FormSelectBDBuilding(base.UserId);
				dlg.MultiSelect = false;
				if (dlg.ShowDialog() != System.Windows.Forms.DialogResult.OK)
					return;

				if (this.ACTimecode.BDBuildingPK == dlg.BDBuilding.BDBuildingPK)
					return;

				this.ACTimecode.BDBuilding = dlg.BDBuilding;
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
				if (this.ACTimecode.IsNew)
				{
					this._decorateACAccessLevelDetail.DataSource = null;
					return;
				}

				this.tabACAccessLevelDetail.Tag = true;

				if (this.ACTimecode.ACAccessLevelDetailList == null || base.IsRefreshData)
				{
					 this.ACTimecode.ACAccessLevelDetailList = ACAccessLevelDetail.GetByACTimecode(this.ACTimecode.ACTimecodePK);
				}

				this._decorateACAccessLevelDetail.ACTimecode = this.ACTimecode;
				this._decorateACAccessLevelDetail.DataSource = this.ACTimecode.ACAccessLevelDetailList;
			}
		}

		private void tabACTimecodeIntervalMap_Enter(object sender, System.EventArgs e)
		{
			if (this.tabACTimecodeIntervalMap.Tag == null)
			{
				if (this.ACTimecode.IsNew)
				{
					this._decorateACTimecodeIntervalMap.DataSource = null;
					return;
				}

				this.tabACTimecodeIntervalMap.Tag = true;

				if (this.ACTimecode.ACTimecodeIntervalMapList == null || base.IsRefreshData)
				{
					 this.ACTimecode.ACTimecodeIntervalMapList = ACTimecodeIntervalMap.GetByACTimecode(this.ACTimecode.ACTimecodePK);
				}

				this._decorateACTimecodeIntervalMap.ACTimecode = this.ACTimecode;
				this._decorateACTimecodeIntervalMap.DataSource = this.ACTimecode.ACTimecodeIntervalMapList;
			}
		}

	}
}
