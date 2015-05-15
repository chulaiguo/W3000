using System;
using System.Collections.Generic;
using Cheke.WinCtrl;
using W3000.Data;
using W3000.ViewObj;
using W3000.Manager.GridSelect;
using W3000.Manager.FormDetailEditor;

namespace W3000.Manager.FormSelect
{
	public partial class FormSelectBDTenant : FormSelectBase
	{
		private GridSelectBDTenantDecorator _decorator = null;
		private readonly SortedList<Guid, Guid> _pkList = null;

		public FormSelectBDTenant()
		{
			InitializeComponent();
		}

		public FormSelectBDTenant(string userid)
			: base(userid)
		{
			InitializeComponent();
		}

		public FormSelectBDTenant(string userid, SortedList<Guid, Guid> pkList)
			: base(userid)
		{
			InitializeComponent();

			this._pkList = pkList;
		}

		public BDTenant BDTenant
		{
			get{ return base.SelectedEntity as BDTenant; }
		}

		public BDTenantCollection BDTenantList
		{
			get{ return base.SelectedList as BDTenantCollection; }
		}

		protected override void InitializeDecorator()
		{
			this._decorator = new GridSelectBDTenantDecorator(base.UserId, base.GridControl);
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
			BDTenant entity = BDTenant.GetByPK(this.BDTenant.BDTenantPK);
			if (entity == null)
			{
				base.ShowNoViewPrivilegeWarning();
				return;
			}

			FormDetailBDTenant dlg = new FormDetailBDTenant(base.UserId, entity);
			dlg.ShowDialog();
		}

		protected override void DataBinding()
		{
			this._decorator.DataSource = this.GetDataSource();
		}

		private BDTenantCollection GetDataSource()
		{
			BDTenantViewCollection list = this.GetOriginalDataSource();
			BDTenantCollection retList = new BDTenantCollection();
			foreach (BDTenantView item in list)
			{
				if(this._pkList != null && this._pkList.ContainsKey(item.BDTenantPK))
					continue;

				retList.Add(new BDTenant(item.ToBDTenantData()));
			}

			retList.AcceptChanges();
			return retList;
		}

		private BDTenantViewCollection GetOriginalDataSource()
		{
			return BDTenant.GetViewAll();
		}
	}
}
