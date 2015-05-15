using System;
using System.Collections.Generic;
using Cheke.WinCtrl;
using W3000.Data;
using W3000.ViewObj;
using W3000.Manager.GridSelect;
using W3000.Manager.FormDetailEditor;

namespace W3000.Manager.FormSelect
{
	public partial class FormSelectUtilHoliday : FormSelectBase
	{
		private GridSelectUtilHolidayDecorator _decorator = null;
		private readonly SortedList<Guid, Guid> _pkList = null;

		public FormSelectUtilHoliday()
		{
			InitializeComponent();
		}

		public FormSelectUtilHoliday(string userid)
			: base(userid)
		{
			InitializeComponent();
		}

		public FormSelectUtilHoliday(string userid, SortedList<Guid, Guid> pkList)
			: base(userid)
		{
			InitializeComponent();

			this._pkList = pkList;
		}

		public UtilHoliday UtilHoliday
		{
			get{ return base.SelectedEntity as UtilHoliday; }
		}

		public UtilHolidayCollection UtilHolidayList
		{
			get{ return base.SelectedList as UtilHolidayCollection; }
		}

		protected override void InitializeDecorator()
		{
			this._decorator = new GridSelectUtilHolidayDecorator(base.UserId, base.GridControl);
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
			UtilHoliday entity = UtilHoliday.GetByPK(this.UtilHoliday.UtilHolidayPK);
			if (entity == null)
			{
				base.ShowNoViewPrivilegeWarning();
				return;
			}

			FormDetailUtilHoliday dlg = new FormDetailUtilHoliday(base.UserId, entity);
			dlg.ShowDialog();
		}

		protected override void DataBinding()
		{
			this._decorator.DataSource = this.GetDataSource();
		}

		private UtilHolidayCollection GetDataSource()
		{
			UtilHolidayViewCollection list = this.GetOriginalDataSource();
			UtilHolidayCollection retList = new UtilHolidayCollection();
			foreach (UtilHolidayView item in list)
			{
				if(this._pkList != null && this._pkList.ContainsKey(item.UtilHolidayPK))
					continue;

				retList.Add(new UtilHoliday(item.ToUtilHolidayData()));
			}

			retList.AcceptChanges();
			return retList;
		}

		private UtilHolidayViewCollection GetOriginalDataSource()
		{
			return UtilHoliday.GetViewAll();
		}
	}
}
