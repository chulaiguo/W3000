using System;
using System.Collections.Generic;
using Cheke.WinCtrl;
using W3000.Data;
using W3000.ViewObj;
using W3000.Manager.GridSelect;
using W3000.Manager.FormDetailEditor;

namespace W3000.Manager.FormSelect
{
	public partial class FormSelectUsrAccount : FormSelectBase
	{
		private GridSelectUsrAccountDecorator _decorator = null;
		private readonly SortedList<Guid, Guid> _pkList = null;

		public FormSelectUsrAccount()
		{
			InitializeComponent();
		}

		public FormSelectUsrAccount(string userid)
			: base(userid)
		{
			InitializeComponent();
		}

		public FormSelectUsrAccount(string userid, SortedList<Guid, Guid> pkList)
			: base(userid)
		{
			InitializeComponent();

			this._pkList = pkList;
		}

		public UsrAccount UsrAccount
		{
			get{ return base.SelectedEntity as UsrAccount; }
		}

		public UsrAccountCollection UsrAccountList
		{
			get{ return base.SelectedList as UsrAccountCollection; }
		}

		protected override void InitializeDecorator()
		{
			this._decorator = new GridSelectUsrAccountDecorator(base.UserId, base.GridControl);
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
			UsrAccount entity = UsrAccount.GetByPK(this.UsrAccount.UsrAccountPK);
			if (entity == null)
			{
				base.ShowNoViewPrivilegeWarning();
				return;
			}

			FormDetailUsrAccount dlg = new FormDetailUsrAccount(base.UserId, entity);
			dlg.ShowDialog();
		}

		protected override void DataBinding()
		{
			this._decorator.DataSource = this.GetDataSource();
		}

		private UsrAccountCollection GetDataSource()
		{
			UsrAccountViewCollection list = this.GetOriginalDataSource();
			UsrAccountCollection retList = new UsrAccountCollection();
			foreach (UsrAccountView item in list)
			{
				if(this._pkList != null && this._pkList.ContainsKey(item.UsrAccountPK))
					continue;

				retList.Add(new UsrAccount(item.ToUsrAccountData()));
			}

			retList.AcceptChanges();
			return retList;
		}

		private UsrAccountViewCollection GetOriginalDataSource()
		{
			return UsrAccount.GetViewAll();
		}
	}
}
