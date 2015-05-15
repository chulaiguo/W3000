using System;
using System.Collections.Generic;
using Cheke.WinCtrl;
using W3000.Data;
using W3000.ViewObj;
using W3000.Manager.GridSelect;
using W3000.Manager.FormDetailEditor;

namespace W3000.Manager.FormSelect
{
	public partial class FormSelectACPanel : FormSelectBase
	{
		private GridSelectACPanelDecorator _decorator = null;
		private readonly SortedList<Guid, Guid> _pkList = null;

		public FormSelectACPanel()
		{
			InitializeComponent();
		}

		public FormSelectACPanel(string userid)
			: base(userid)
		{
			InitializeComponent();
		}

		public FormSelectACPanel(string userid, SortedList<Guid, Guid> pkList)
			: base(userid)
		{
			InitializeComponent();

			this._pkList = pkList;
		}

		public ACPanel ACPanel
		{
			get{ return base.SelectedEntity as ACPanel; }
		}

		public ACPanelCollection ACPanelList
		{
			get{ return base.SelectedList as ACPanelCollection; }
		}

		protected override void InitializeDecorator()
		{
			this._decorator = new GridSelectACPanelDecorator(base.UserId, base.GridControl);
			this._decorator.Initialize();
			this._decorator.Editable = false;
		}

		protected override void InitializeForm()
		{
			base.InitializeForm();
			this.DataBinding();
		}

		protected override void ShowDetail()
		{
			ACPanel entity = ACPanel.GetByPK(this.ACPanel.ACPanelPK);
			if (entity == null)
			{
				base.ShowNoViewPrivilegeWarning();
				return;
			}

			FormDetailACPanel dlg = new FormDetailACPanel(base.UserId, entity);
			dlg.ShowDialog();
		}

		protected override void DataBinding()
		{
			this._decorator.DataSource = this.GetDataSource();
		}

		private ACPanelCollection GetDataSource()
		{
			ACPanelViewCollection list = this.GetOriginalDataSource();
			ACPanelCollection retList = new ACPanelCollection();
			foreach (ACPanelView item in list)
			{
				if(this._pkList != null && this._pkList.ContainsKey(item.ACPanelPK))
					continue;

				retList.Add(new ACPanel(item.ToACPanelData()));
			}

			retList.AcceptChanges();
			return retList;
		}

		private ACPanelViewCollection GetOriginalDataSource()
		{
			return ACPanel.GetViewAll();
		}
	}
}
