using System;
using System.Collections.Generic;
using Cheke.WinCtrl;
using W3000.Data;
using W3000.ViewObj;
using W3000.Manager.GridSelect;
using W3000.Manager.FormDetailEditor;

namespace W3000.Manager.FormSelect
{
	public partial class FormSelectUsrGroup : FormSelectBase
	{
		private GridSelectUsrGroupDecorator _decorator = null;
		private readonly SortedList<Guid, Guid> _pkList = null;

		public FormSelectUsrGroup()
		{
			InitializeComponent();
		}

		public FormSelectUsrGroup(string userid)
			: base(userid)
		{
			InitializeComponent();
		}

		public FormSelectUsrGroup(string userid, SortedList<Guid, Guid> pkList)
			: base(userid)
		{
			InitializeComponent();

			this._pkList = pkList;
		}

		public UsrGroup UsrGroup
		{
			get{ return base.SelectedEntity as UsrGroup; }
		}

		public UsrGroupCollection UsrGroupList
		{
			get{ return base.SelectedList as UsrGroupCollection; }
		}

		protected override void InitializeDecorator()
		{
			this._decorator = new GridSelectUsrGroupDecorator(base.UserId, base.GridControl);
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
			UsrGroup entity = UsrGroup.GetByPK(this.UsrGroup.UsrGroupPK);
			if (entity == null)
			{
				base.ShowNoViewPrivilegeWarning();
				return;
			}

			FormDetailUsrGroup dlg = new FormDetailUsrGroup(base.UserId, entity);
			dlg.ShowDialog();
		}

		protected override void DataBinding()
		{
			this._decorator.DataSource = this.GetDataSource();
		}

		private UsrGroupCollection GetDataSource()
		{
			UsrGroupViewCollection list = this.GetOriginalDataSource();
			UsrGroupCollection retList = new UsrGroupCollection();
			foreach (UsrGroupView item in list)
			{
				if(this._pkList != null && this._pkList.ContainsKey(item.UsrGroupPK))
					continue;

				retList.Add(new UsrGroup(item.ToUsrGroupData()));
			}

			retList.AcceptChanges();
			return retList;
		}

		private UsrGroupViewCollection GetOriginalDataSource()
		{
			return UsrGroup.GetViewAll();
		}
	}
}
