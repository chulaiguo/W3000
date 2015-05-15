using System;
using System.Collections.Generic;
using Cheke.WinCtrl;
using W3000.Data;
using W3000.ViewObj;
using W3000.Manager.GridSelect;
using W3000.Manager.FormDetailEditor;

namespace W3000.Manager.FormSelect
{
	public partial class FormSelectACAMFormat : FormSelectBase
	{
		private GridSelectACAMFormatDecorator _decorator = null;
		private readonly SortedList<Guid, Guid> _pkList = null;

		public FormSelectACAMFormat()
		{
			InitializeComponent();
		}

		public FormSelectACAMFormat(string userid)
			: base(userid)
		{
			InitializeComponent();
		}

		public FormSelectACAMFormat(string userid, SortedList<Guid, Guid> pkList)
			: base(userid)
		{
			InitializeComponent();

			this._pkList = pkList;
		}

		public ACAMFormat ACAMFormat
		{
			get{ return base.SelectedEntity as ACAMFormat; }
		}

		public ACAMFormatCollection ACAMFormatList
		{
			get{ return base.SelectedList as ACAMFormatCollection; }
		}

		protected override void InitializeDecorator()
		{
			this._decorator = new GridSelectACAMFormatDecorator(base.UserId, base.GridControl);
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
			ACAMFormat entity = ACAMFormat.GetByPK(this.ACAMFormat.ACAMFormatPK);
			if (entity == null)
			{
				base.ShowNoViewPrivilegeWarning();
				return;
			}

			FormDetailACAMFormat dlg = new FormDetailACAMFormat(base.UserId, entity);
			dlg.ShowDialog();
		}

		protected override void DataBinding()
		{
			this._decorator.DataSource = this.GetDataSource();
		}

		private ACAMFormatCollection GetDataSource()
		{
			ACAMFormatViewCollection list = this.GetOriginalDataSource();
			ACAMFormatCollection retList = new ACAMFormatCollection();
			foreach (ACAMFormatView item in list)
			{
				if(this._pkList != null && this._pkList.ContainsKey(item.ACAMFormatPK))
					continue;

				retList.Add(new ACAMFormat(item.ToACAMFormatData()));
			}

			retList.AcceptChanges();
			return retList;
		}

		private ACAMFormatViewCollection GetOriginalDataSource()
		{
			return ACAMFormat.GetViewAll();
		}
	}
}
