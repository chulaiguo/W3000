using System;
using System.Collections.Generic;
using Cheke.WinCtrl;
using W3000.Data;
using W3000.ViewObj;
using W3000.Manager.GridSelect;
using W3000.Manager.FormDetailEditor;

namespace W3000.Manager.FormSelect
{
	public partial class FormSelectACFunctionCard : FormSelectBase
	{
		private GridSelectACFunctionCardDecorator _decorator = null;
		private readonly SortedList<Guid, Guid> _pkList = null;

		public FormSelectACFunctionCard()
		{
			InitializeComponent();
		}

		public FormSelectACFunctionCard(string userid)
			: base(userid)
		{
			InitializeComponent();
		}

		public FormSelectACFunctionCard(string userid, SortedList<Guid, Guid> pkList)
			: base(userid)
		{
			InitializeComponent();

			this._pkList = pkList;
		}

		public ACFunctionCard ACFunctionCard
		{
			get{ return base.SelectedEntity as ACFunctionCard; }
		}

		public ACFunctionCardCollection ACFunctionCardList
		{
			get{ return base.SelectedList as ACFunctionCardCollection; }
		}

		protected override void InitializeDecorator()
		{
			this._decorator = new GridSelectACFunctionCardDecorator(base.UserId, base.GridControl);
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
			ACFunctionCard entity = ACFunctionCard.GetByPK(this.ACFunctionCard.ACFunctionCardPK);
			if (entity == null)
			{
				base.ShowNoViewPrivilegeWarning();
				return;
			}

			FormDetailACFunctionCard dlg = new FormDetailACFunctionCard(base.UserId, entity);
			dlg.ShowDialog();
		}

		protected override void DataBinding()
		{
			this._decorator.DataSource = this.GetDataSource();
		}

		private ACFunctionCardCollection GetDataSource()
		{
			ACFunctionCardViewCollection list = this.GetOriginalDataSource();
			ACFunctionCardCollection retList = new ACFunctionCardCollection();
			foreach (ACFunctionCardView item in list)
			{
				if(this._pkList != null && this._pkList.ContainsKey(item.ACFunctionCardPK))
					continue;

				retList.Add(new ACFunctionCard(item.ToACFunctionCardData()));
			}

			retList.AcceptChanges();
			return retList;
		}

		private ACFunctionCardViewCollection GetOriginalDataSource()
		{
			return ACFunctionCard.GetViewAll();
		}
	}
}
