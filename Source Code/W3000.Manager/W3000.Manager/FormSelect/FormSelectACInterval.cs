using System;
using System.Collections.Generic;
using Cheke.WinCtrl;
using W3000.Data;
using W3000.ViewObj;
using W3000.Manager.GridSelect;
using W3000.Manager.FormDetailEditor;

namespace W3000.Manager.FormSelect
{
	public partial class FormSelectACInterval : FormSelectBase
	{
		private GridSelectACIntervalDecorator _decorator = null;
		private readonly SortedList<Guid, Guid> _pkList = null;

		public FormSelectACInterval()
		{
			InitializeComponent();
		}

		public FormSelectACInterval(string userid)
			: base(userid)
		{
			InitializeComponent();
		}

		public FormSelectACInterval(string userid, SortedList<Guid, Guid> pkList)
			: base(userid)
		{
			InitializeComponent();

			this._pkList = pkList;
		}

		public ACInterval ACInterval
		{
			get{ return base.SelectedEntity as ACInterval; }
		}

		public ACIntervalCollection ACIntervalList
		{
			get{ return base.SelectedList as ACIntervalCollection; }
		}

		protected override void InitializeDecorator()
		{
			this._decorator = new GridSelectACIntervalDecorator(base.UserId, base.GridControl);
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
			ACInterval entity = ACInterval.GetByPK(this.ACInterval.ACIntervalPK);
			if (entity == null)
			{
				base.ShowNoViewPrivilegeWarning();
				return;
			}

			FormDetailACInterval dlg = new FormDetailACInterval(base.UserId, entity);
			dlg.ShowDialog();
		}

		protected override void DataBinding()
		{
			this._decorator.DataSource = this.GetDataSource();
		}

		private ACIntervalCollection GetDataSource()
		{
			ACIntervalViewCollection list = this.GetOriginalDataSource();
			ACIntervalCollection retList = new ACIntervalCollection();
			foreach (ACIntervalView item in list)
			{
				if(this._pkList != null && this._pkList.ContainsKey(item.ACIntervalPK))
					continue;

				retList.Add(new ACInterval(item.ToACIntervalData()));
			}

			retList.AcceptChanges();
			return retList;
		}

		private ACIntervalViewCollection GetOriginalDataSource()
		{
			return ACInterval.GetViewAll();
		}
	}
}
