using System;
using System.Collections.Generic;
using Cheke.WinCtrl;
using W3000.Data;
using W3000.ViewObj;
using W3000.Manager.GridSelect;
using W3000.Manager.FormDetailEditor;

namespace W3000.Manager.FormSelect
{
	public partial class FormSelectACInput : FormSelectBase
	{
		private GridSelectACInputDecorator _decorator = null;
		private readonly SortedList<Guid, Guid> _pkList = null;

		public FormSelectACInput()
		{
			InitializeComponent();
		}

		public FormSelectACInput(string userid)
			: base(userid)
		{
			InitializeComponent();
		}

		public FormSelectACInput(string userid, SortedList<Guid, Guid> pkList)
			: base(userid)
		{
			InitializeComponent();

			this._pkList = pkList;
		}

		public ACInput ACInput
		{
			get{ return base.SelectedEntity as ACInput; }
		}

		public ACInputCollection ACInputList
		{
			get{ return base.SelectedList as ACInputCollection; }
		}

		protected override void InitializeDecorator()
		{
			this._decorator = new GridSelectACInputDecorator(base.UserId, base.GridControl);
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
			ACInput entity = ACInput.GetByPK(this.ACInput.ACInputPK);
			if (entity == null)
			{
				base.ShowNoViewPrivilegeWarning();
				return;
			}

			FormDetailACInput dlg = new FormDetailACInput(base.UserId, entity);
			dlg.ShowDialog();
		}

		protected override void DataBinding()
		{
			this._decorator.DataSource = this.GetDataSource();
		}

		private ACInputCollection GetDataSource()
		{
			ACInputViewCollection list = this.GetOriginalDataSource();
			ACInputCollection retList = new ACInputCollection();
			foreach (ACInputView item in list)
			{
				if(this._pkList != null && this._pkList.ContainsKey(item.ACInputPK))
					continue;

				retList.Add(new ACInput(item.ToACInputData()));
			}

			retList.AcceptChanges();
			return retList;
		}

		private ACInputViewCollection GetOriginalDataSource()
		{
			return ACInput.GetViewAll();
		}
	}
}
