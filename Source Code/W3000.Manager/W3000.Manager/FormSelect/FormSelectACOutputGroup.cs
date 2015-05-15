using System;
using System.Collections.Generic;
using Cheke.WinCtrl;
using W3000.Data;
using W3000.ViewObj;
using W3000.Manager.GridSelect;
using W3000.Manager.FormDetailEditor;

namespace W3000.Manager.FormSelect
{
	public partial class FormSelectACOutputGroup : FormSelectBase
	{
		private GridSelectACOutputGroupDecorator _decorator = null;
		private readonly SortedList<Guid, Guid> _pkList = null;

		public FormSelectACOutputGroup()
		{
			InitializeComponent();
		}

		public FormSelectACOutputGroup(string userid)
			: base(userid)
		{
			InitializeComponent();
		}

		public FormSelectACOutputGroup(string userid, SortedList<Guid, Guid> pkList)
			: base(userid)
		{
			InitializeComponent();

			this._pkList = pkList;
		}

		public ACOutputGroup ACOutputGroup
		{
			get{ return base.SelectedEntity as ACOutputGroup; }
		}

		public ACOutputGroupCollection ACOutputGroupList
		{
			get{ return base.SelectedList as ACOutputGroupCollection; }
		}

		protected override void InitializeDecorator()
		{
			this._decorator = new GridSelectACOutputGroupDecorator(base.UserId, base.GridControl);
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
			ACOutputGroup entity = ACOutputGroup.GetByPK(this.ACOutputGroup.ACOutputGroupPK);
			if (entity == null)
			{
				base.ShowNoViewPrivilegeWarning();
				return;
			}

			FormDetailACOutputGroup dlg = new FormDetailACOutputGroup(base.UserId, entity);
			dlg.ShowDialog();
		}

		protected override void DataBinding()
		{
			this._decorator.DataSource = this.GetDataSource();
		}

		private ACOutputGroupCollection GetDataSource()
		{
			ACOutputGroupViewCollection list = this.GetOriginalDataSource();
			ACOutputGroupCollection retList = new ACOutputGroupCollection();
			foreach (ACOutputGroupView item in list)
			{
				if(this._pkList != null && this._pkList.ContainsKey(item.ACOutputGroupPK))
					continue;

				retList.Add(new ACOutputGroup(item.ToACOutputGroupData()));
			}

			retList.AcceptChanges();
			return retList;
		}

		private ACOutputGroupViewCollection GetOriginalDataSource()
		{
			return ACOutputGroup.GetViewAll();
		}
	}
}
