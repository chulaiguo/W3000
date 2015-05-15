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
	public partial class FormDetailACMainZone : FormDetailEditorBase
	{
		private GridACOutputGroupMainZoneMapDecorator _decorateACOutputGroupMainZoneMap = null;
		private GridACAccessLevelDetailDecorator _decorateACAccessLevelDetail = null;

		public FormDetailACMainZone()
		{
			InitializeComponent();
		}

		public FormDetailACMainZone(string userid, ACMainZone entity)
			: base(userid, entity)
		{
			InitializeComponent();
		}

		protected override void InitializeDecorator()
		{
			this._decorateACOutputGroupMainZoneMap = new GridACOutputGroupMainZoneMapDecorator(base.UserId, this.grdACOutputGroupMainZoneMap);
			this._decorateACOutputGroupMainZoneMap.Initialize();

			this._decorateACAccessLevelDetail = new GridACAccessLevelDetailDecorator(base.UserId, this.grdACAccessLevelDetail);
			this._decorateACAccessLevelDetail.Initialize();

		}

		private ACMainZone ACMainZone
		{
			get{ return base.Entity as ACMainZone; }
		}

		protected override void DataBindingEntity()
		{
			this.txtMainZoneID.BindingData(this.ACMainZone, ACMainZoneSchema.MainZoneID);
			this.txtMainZoneTypeID.BindingData(this.ACMainZone, ACMainZoneSchema.MainZoneTypeID);
			this.txtDescription.BindingData(this.ACMainZone, ACMainZoneSchema.Description);
			this.txtReaderName.BindingData(this.ACMainZone, ACMainZoneSchema.ReaderName);
			this.txtReaderTypeID.BindingData(this.ACMainZone, ACMainZoneSchema.ReaderTypeID);
			this.chkReverseColor.BindingData(this.ACMainZone, ACMainZoneSchema.ReverseColor);
			this.txtOutputGroup.BindingData(this.ACMainZone, ACMainZoneSchema.OutputGroup);
			this.chkNeedPin.BindingData(this.ACMainZone, ACMainZoneSchema.NeedPin);
			this.txtAntiPassback.BindingData(this.ACMainZone, ACMainZoneSchema.AntiPassback);
			this.chkSoftAntiPassback.BindingData(this.ACMainZone, ACMainZoneSchema.SoftAntiPassback);
			this.txtUnlockTimecode.BindingData(this.ACMainZone, ACMainZoneSchema.UnlockTimecode);
			this.chkUnlockOn1stRead.BindingData(this.ACMainZone, ACMainZoneSchema.UnlockOn1stRead);
			this.chkRexShuntOnly.BindingData(this.ACMainZone, ACMainZoneSchema.RexShuntOnly);
			this.txtPulseTime.BindingData(this.ACMainZone, ACMainZoneSchema.PulseTime);
			this.chkRelockByTimeout.BindingData(this.ACMainZone, ACMainZoneSchema.RelockByTimeout);
			this.txtForceAMFormat.BindingData(this.ACMainZone, ACMainZoneSchema.ForceAMFormat);
			this.txtPropAMFFormat.BindingData(this.ACMainZone, ACMainZoneSchema.PropAMFFormat);
			this.txtDebounce.BindingData(this.ACMainZone, ACMainZoneSchema.Debounce);
			this.txtAllowOpenTime.BindingData(this.ACMainZone, ACMainZoneSchema.AllowOpenTime);
			this.chkNoPreAlarm.BindingData(this.ACMainZone, ACMainZoneSchema.NoPreAlarm);
			this.txtPostPreAlarm.BindingData(this.ACMainZone, ACMainZoneSchema.PostPreAlarm);
			this.txtPostDuration.BindingData(this.ACMainZone, ACMainZoneSchema.PostDuration);
			this.txtNotes.BindingData(this.ACMainZone, ACMainZoneSchema.Notes);
			this.txtEventNotifyEmail.BindingData(this.ACMainZone, ACMainZoneSchema.EventNotifyEmail);
			this.chkIsPulsed.BindingData(this.ACMainZone, ACMainZoneSchema.IsPulsed);
			this.chkAlwaysToMAS.BindingData(this.ACMainZone, ACMainZoneSchema.AlwaysToMAS);
			this.chkCommentBeforePulse.BindingData(this.ACMainZone, ACMainZoneSchema.CommentBeforePulse);
			this.chkDegrade.BindingData(this.ACMainZone, ACMainZoneSchema.Degrade);
			this.txtReaderPassMode.BindingData(this.ACMainZone, ACMainZoneSchema.ReaderPassMode);
			this.txtPanelZoneID.BindingData(this.ACMainZone, ACMainZoneSchema.PanelZoneID);
			this.txtLockTypeID.BindingData(this.ACMainZone, ACMainZoneSchema.LockTypeID);
			this.chkLocked.BindingData(this.ACMainZone, ACMainZoneSchema.Locked);
			this.txtInputGroup.BindingData(this.ACMainZone, ACMainZoneSchema.InputGroup);
			this.txtUnlockTempTC.BindingData(this.ACMainZone, ACMainZoneSchema.UnlockTempTC);
			this.dateUnlockTempBegin.BindingData(this.ACMainZone, ACMainZoneSchema.UnlockTempBegin);
			this.dateUnlockTempEnd.BindingData(this.ACMainZone, ACMainZoneSchema.UnlockTempEnd);

			this.txtACPanel.Text = this.ACMainZone.UnitID.ToString();
		}

		private void txtACPanel_ButtonClick(object sender, ButtonPressedEventArgs e)
		{
			if (e.Button.Kind == ButtonPredefines.Delete)
			{
				if (this.ACMainZone.ACPanelPK == Guid.Empty)
					return;

				if (DialogResult.Yes != base.ShowQuestion(string.Format("Are you sure you want to clear the {0}?", this.txtACPanel.Title)))
					return;

				this.ACMainZone.ACPanelPK = Guid.Empty;
				this.txtACPanel.Text = string.Empty;
			}
			else
			{
				FormSelectACPanel dlg = new FormSelectACPanel(base.UserId);
				dlg.MultiSelect = false;
				if (dlg.ShowDialog() != System.Windows.Forms.DialogResult.OK)
					return;

				if (this.ACMainZone.ACPanelPK == dlg.ACPanel.ACPanelPK)
					return;

				this.ACMainZone.ACPanel = dlg.ACPanel;
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
				if (this.ACMainZone.IsNew)
				{
					this._decorateACOutputGroupMainZoneMap.DataSource = null;
					return;
				}

				this.tabACOutputGroupMainZoneMap.Tag = true;

				if (this.ACMainZone.ACOutputGroupMainZoneMapList == null || base.IsRefreshData)
				{
					 this.ACMainZone.ACOutputGroupMainZoneMapList = ACOutputGroupMainZoneMap.GetByACMainZone(this.ACMainZone.ACMainZonePK);
				}

				this._decorateACOutputGroupMainZoneMap.ACMainZone = this.ACMainZone;
				this._decorateACOutputGroupMainZoneMap.DataSource = this.ACMainZone.ACOutputGroupMainZoneMapList;
			}
		}

		private void tabACAccessLevelDetail_Enter(object sender, System.EventArgs e)
		{
			if (this.tabACAccessLevelDetail.Tag == null)
			{
				if (this.ACMainZone.IsNew)
				{
					this._decorateACAccessLevelDetail.DataSource = null;
					return;
				}

				this.tabACAccessLevelDetail.Tag = true;

				if (this.ACMainZone.ACAccessLevelDetailList == null || base.IsRefreshData)
				{
					 this.ACMainZone.ACAccessLevelDetailList = ACAccessLevelDetail.GetByACMainZone(this.ACMainZone.ACMainZonePK);
				}

				this._decorateACAccessLevelDetail.ACMainZone = this.ACMainZone;
				this._decorateACAccessLevelDetail.DataSource = this.ACMainZone.ACAccessLevelDetailList;
			}
		}

	}
}
