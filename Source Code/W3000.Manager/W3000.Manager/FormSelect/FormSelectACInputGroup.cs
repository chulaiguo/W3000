using System;
using System.Collections.Generic;
using Cheke.WinCtrl;
using W3000.Data;
using W3000.ViewObj;
using W3000.Manager.GridSelect;
using W3000.Manager.FormDetailEditor;

namespace W3000.Manager.FormSelect
{
	public partial class FormSelectACInputGroup : FormSelectBase
	{
		private GridSelectACInputGroupDecorator _decorator = null;
		private readonly SortedList<Guid, Guid> _pkList = null;

		public FormSelectACInputGroup()
		{
			InitializeComponent();
		}

		public FormSelectACInputGroup(string userid)
			: base(userid)
		{
			InitializeComponent();
		}

		public FormSelectACInputGroup(string userid, SortedList<Guid, Guid> pkList)
			: base(userid)
		{
			InitializeComponent();

			this._pkList = pkList;
		}

		public ACInputGroup ACInputGroup
		{
			get{ return base.SelectedEntity as ACInputGroup; }
		}

		public ACInputGroupCollection ACInputGroupList
		{
			get{ return base.SelectedList as ACInputGroupCollection; }
		}

		protected override void InitializeDecorator()
		{
			this._decorator = new GridSelectACInputGroupDecorator(base.UserId, base.GridControl);
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
			ACInputGroup entity = ACInputGroup.GetByPK(this.ACInputGroup.ACInputGroupPK);
			if (entity == null)
			{
				base.ShowNoViewPrivilegeWarning();
				return;
			}

			FormDetailACInputGroup dlg = new FormDetailACInputGroup(base.UserId, entity);
			dlg.ShowDialog();
		}

		protected override void DataBinding()
		{
			this._decorator.DataSource = this.GetDataSource();
		}

		private ACInputGroupCollection GetDataSource()
		{
			ACInputGroupViewCollection list = this.GetOriginalDataSource();
			ACInputGroupCollection retList = new ACInputGroupCollection();
			foreach (ACInputGroupView item in list)
			{
				if(this._pkList != null && this._pkList.ContainsKey(item.ACInputGroupPK))
					continue;

				retList.Add(new ACInputGroup(item.ToACInputGroupData()));
			}

			retList.AcceptChanges();
			return retList;
		}

		private ACInputGroupViewCollection GetOriginalDataSource()
		{
			return ACInputGroup.GetViewAll();
		}
	}
}
