using System;
using System.Collections.Generic;
using Cheke.WinCtrl;
using W3000.Data;
using W3000.ViewObj;
using W3000.Manager.GridSelect;
using W3000.Manager.FormDetailEditor;

namespace W3000.Manager.FormSelect
{
	public partial class FormSelectACSupervisory : FormSelectBase
	{
		private GridSelectACSupervisoryDecorator _decorator = null;
		private readonly SortedList<Guid, Guid> _pkList = null;

		public FormSelectACSupervisory()
		{
			InitializeComponent();
		}

		public FormSelectACSupervisory(string userid)
			: base(userid)
		{
			InitializeComponent();
		}

		public FormSelectACSupervisory(string userid, SortedList<Guid, Guid> pkList)
			: base(userid)
		{
			InitializeComponent();

			this._pkList = pkList;
		}

		public ACSupervisory ACSupervisory
		{
			get{ return base.SelectedEntity as ACSupervisory; }
		}

		public ACSupervisoryCollection ACSupervisoryList
		{
			get{ return base.SelectedList as ACSupervisoryCollection; }
		}

		protected override void InitializeDecorator()
		{
			this._decorator = new GridSelectACSupervisoryDecorator(base.UserId, base.GridControl);
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
			ACSupervisory entity = ACSupervisory.GetByPK(this.ACSupervisory.ACSupervisoryPK);
			if (entity == null)
			{
				base.ShowNoViewPrivilegeWarning();
				return;
			}

			FormDetailACSupervisory dlg = new FormDetailACSupervisory(base.UserId, entity);
			dlg.ShowDialog();
		}

		protected override void DataBinding()
		{
			this._decorator.DataSource = this.GetDataSource();
		}

		private ACSupervisoryCollection GetDataSource()
		{
			ACSupervisoryViewCollection list = this.GetOriginalDataSource();
			ACSupervisoryCollection retList = new ACSupervisoryCollection();
			foreach (ACSupervisoryView item in list)
			{
				if(this._pkList != null && this._pkList.ContainsKey(item.ACSupervisoryPK))
					continue;

				retList.Add(new ACSupervisory(item.ToACSupervisoryData()));
			}

			retList.AcceptChanges();
			return retList;
		}

		private ACSupervisoryViewCollection GetOriginalDataSource()
		{
			return ACSupervisory.GetViewAll();
		}
	}
}
