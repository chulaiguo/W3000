using System;
using System.Collections.Generic;
using Cheke.WinCtrl;
using W3000.Data;
using W3000.ViewObj;
using W3000.Manager.GridSelect;
using W3000.Manager.FormDetailEditor;

namespace W3000.Manager.FormSelect
{
	public partial class FormSelectACCardHolder : FormSelectBase
	{
		private GridSelectACCardHolderDecorator _decorator = null;
		private readonly SortedList<Guid, Guid> _pkList = null;

		public FormSelectACCardHolder()
		{
			InitializeComponent();
		}

		public FormSelectACCardHolder(string userid)
			: base(userid)
		{
			InitializeComponent();
		}

		public FormSelectACCardHolder(string userid, SortedList<Guid, Guid> pkList)
			: base(userid)
		{
			InitializeComponent();

			this._pkList = pkList;
		}

		public ACCardHolder ACCardHolder
		{
			get{ return base.SelectedEntity as ACCardHolder; }
		}

		public ACCardHolderCollection ACCardHolderList
		{
			get{ return base.SelectedList as ACCardHolderCollection; }
		}

		protected override void InitializeDecorator()
		{
			this._decorator = new GridSelectACCardHolderDecorator(base.UserId, base.GridControl);
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
			ACCardHolder entity = ACCardHolder.GetByPK(this.ACCardHolder.ACCardHolderPK);
			if (entity == null)
			{
				base.ShowNoViewPrivilegeWarning();
				return;
			}

			FormDetailACCardHolder dlg = new FormDetailACCardHolder(base.UserId, entity);
			dlg.ShowDialog();
		}

		protected override void DataBinding()
		{
			this._decorator.DataSource = this.GetDataSource();
		}

		private ACCardHolderCollection GetDataSource()
		{
			ACCardHolderViewCollection list = this.GetOriginalDataSource();
			ACCardHolderCollection retList = new ACCardHolderCollection();
			foreach (ACCardHolderView item in list)
			{
				if(this._pkList != null && this._pkList.ContainsKey(item.ACCardHolderPK))
					continue;

				retList.Add(new ACCardHolder(item.ToACCardHolderData()));
			}

			retList.AcceptChanges();
			return retList;
		}

		private ACCardHolderViewCollection GetOriginalDataSource()
		{
			return ACCardHolder.GetViewAll();
		}
	}
}
