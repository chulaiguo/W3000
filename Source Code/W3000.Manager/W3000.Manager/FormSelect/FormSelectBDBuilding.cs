using System;
using System.Collections.Generic;
using Cheke.WinCtrl;
using W3000.Data;
using W3000.ViewObj;
using W3000.Manager.GridSelect;
using W3000.Manager.FormDetailEditor;

namespace W3000.Manager.FormSelect
{
	public partial class FormSelectBDBuilding : FormSelectBase
	{
		private GridSelectBDBuildingDecorator _decorator = null;
		private readonly SortedList<Guid, Guid> _pkList = null;

		public FormSelectBDBuilding()
		{
			InitializeComponent();
		}

		public FormSelectBDBuilding(string userid)
			: base(userid)
		{
			InitializeComponent();
		}

		public FormSelectBDBuilding(string userid, SortedList<Guid, Guid> pkList)
			: base(userid)
		{
			InitializeComponent();

			this._pkList = pkList;
		}

		public BDBuilding BDBuilding
		{
			get{ return base.SelectedEntity as BDBuilding; }
		}

		public BDBuildingCollection BDBuildingList
		{
			get{ return base.SelectedList as BDBuildingCollection; }
		}

		protected override void InitializeDecorator()
		{
			this._decorator = new GridSelectBDBuildingDecorator(base.UserId, base.GridControl);
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
			BDBuilding entity = BDBuilding.GetByPK(this.BDBuilding.BDBuildingPK);
			if (entity == null)
			{
				base.ShowNoViewPrivilegeWarning();
				return;
			}

			FormDetailBDBuilding dlg = new FormDetailBDBuilding(base.UserId, entity);
			dlg.ShowDialog();
		}

		protected override void DataBinding()
		{
			this._decorator.DataSource = this.GetDataSource();
		}

		private BDBuildingCollection GetDataSource()
		{
			BDBuildingViewCollection list = this.GetOriginalDataSource();
			BDBuildingCollection retList = new BDBuildingCollection();
			foreach (BDBuildingView item in list)
			{
				if(this._pkList != null && this._pkList.ContainsKey(item.BDBuildingPK))
					continue;

				retList.Add(new BDBuilding(item.ToBDBuildingData()));
			}

			retList.AcceptChanges();
			return retList;
		}

		private BDBuildingViewCollection GetOriginalDataSource()
		{
			return BDBuilding.GetViewAll();
		}
	}
}
