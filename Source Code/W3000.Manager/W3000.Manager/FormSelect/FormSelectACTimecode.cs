using System;
using System.Collections.Generic;
using Cheke.WinCtrl;
using W3000.Data;
using W3000.ViewObj;
using W3000.Manager.GridSelect;
using W3000.Manager.FormDetailEditor;

namespace W3000.Manager.FormSelect
{
	public partial class FormSelectACTimecode : FormSelectBase
	{
		private GridSelectACTimecodeDecorator _decorator = null;
		private readonly SortedList<Guid, Guid> _pkList = null;

		public FormSelectACTimecode()
		{
			InitializeComponent();
		}

		public FormSelectACTimecode(string userid)
			: base(userid)
		{
			InitializeComponent();
		}

		public FormSelectACTimecode(string userid, SortedList<Guid, Guid> pkList)
			: base(userid)
		{
			InitializeComponent();

			this._pkList = pkList;
		}

		public ACTimecode ACTimecode
		{
			get{ return base.SelectedEntity as ACTimecode; }
		}

		public ACTimecodeCollection ACTimecodeList
		{
			get{ return base.SelectedList as ACTimecodeCollection; }
		}

		protected override void InitializeDecorator()
		{
			this._decorator = new GridSelectACTimecodeDecorator(base.UserId, base.GridControl);
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
			ACTimecode entity = ACTimecode.GetByPK(this.ACTimecode.ACTimecodePK);
			if (entity == null)
			{
				base.ShowNoViewPrivilegeWarning();
				return;
			}

			FormDetailACTimecode dlg = new FormDetailACTimecode(base.UserId, entity);
			dlg.ShowDialog();
		}

		protected override void DataBinding()
		{
			this._decorator.DataSource = this.GetDataSource();
		}

		private ACTimecodeCollection GetDataSource()
		{
			ACTimecodeViewCollection list = this.GetOriginalDataSource();
			ACTimecodeCollection retList = new ACTimecodeCollection();
			foreach (ACTimecodeView item in list)
			{
				if(this._pkList != null && this._pkList.ContainsKey(item.ACTimecodePK))
					continue;

				retList.Add(new ACTimecode(item.ToACTimecodeData()));
			}

			retList.AcceptChanges();
			return retList;
		}

		private ACTimecodeViewCollection GetOriginalDataSource()
		{
			return ACTimecode.GetViewAll();
		}
	}
}
