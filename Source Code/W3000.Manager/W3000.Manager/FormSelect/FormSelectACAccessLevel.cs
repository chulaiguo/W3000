using System;
using System.Collections.Generic;
using Cheke.WinCtrl;
using W3000.Data;
using W3000.ViewObj;
using W3000.Manager.GridSelect;
using W3000.Manager.FormDetailEditor;

namespace W3000.Manager.FormSelect
{
	public partial class FormSelectACAccessLevel : FormSelectBase
	{
		private GridSelectACAccessLevelDecorator _decorator = null;
		private readonly SortedList<Guid, Guid> _pkList = null;

		public FormSelectACAccessLevel()
		{
			InitializeComponent();
		}

		public FormSelectACAccessLevel(string userid)
			: base(userid)
		{
			InitializeComponent();
		}

		public FormSelectACAccessLevel(string userid, SortedList<Guid, Guid> pkList)
			: base(userid)
		{
			InitializeComponent();

			this._pkList = pkList;
		}

		public ACAccessLevel ACAccessLevel
		{
			get{ return base.SelectedEntity as ACAccessLevel; }
		}

		public ACAccessLevelCollection ACAccessLevelList
		{
			get{ return base.SelectedList as ACAccessLevelCollection; }
		}

		protected override void InitializeDecorator()
		{
			this._decorator = new GridSelectACAccessLevelDecorator(base.UserId, base.GridControl);
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
			ACAccessLevel entity = ACAccessLevel.GetByPK(this.ACAccessLevel.ACAccessLevelPK);
			if (entity == null)
			{
				base.ShowNoViewPrivilegeWarning();
				return;
			}

			FormDetailACAccessLevel dlg = new FormDetailACAccessLevel(base.UserId, entity);
			dlg.ShowDialog();
		}

		protected override void DataBinding()
		{
			this._decorator.DataSource = this.GetDataSource();
		}

		private ACAccessLevelCollection GetDataSource()
		{
			ACAccessLevelViewCollection list = this.GetOriginalDataSource();
			ACAccessLevelCollection retList = new ACAccessLevelCollection();
			foreach (ACAccessLevelView item in list)
			{
				if(this._pkList != null && this._pkList.ContainsKey(item.ACAccessLevelPK))
					continue;

				retList.Add(new ACAccessLevel(item.ToACAccessLevelData()));
			}

			retList.AcceptChanges();
			return retList;
		}

		private ACAccessLevelViewCollection GetOriginalDataSource()
		{
			return ACAccessLevel.GetViewAll();
		}
	}
}
