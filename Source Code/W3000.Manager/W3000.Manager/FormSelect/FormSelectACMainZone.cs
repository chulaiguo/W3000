using System;
using System.Collections.Generic;
using Cheke.WinCtrl;
using W3000.Data;
using W3000.ViewObj;
using W3000.Manager.GridSelect;
using W3000.Manager.FormDetailEditor;

namespace W3000.Manager.FormSelect
{
	public partial class FormSelectACMainZone : FormSelectBase
	{
		private GridSelectACMainZoneDecorator _decorator = null;
		private readonly SortedList<Guid, Guid> _pkList = null;

		public FormSelectACMainZone()
		{
			InitializeComponent();
		}

		public FormSelectACMainZone(string userid)
			: base(userid)
		{
			InitializeComponent();
		}

		public FormSelectACMainZone(string userid, SortedList<Guid, Guid> pkList)
			: base(userid)
		{
			InitializeComponent();

			this._pkList = pkList;
		}

		public ACMainZone ACMainZone
		{
			get{ return base.SelectedEntity as ACMainZone; }
		}

		public ACMainZoneCollection ACMainZoneList
		{
			get{ return base.SelectedList as ACMainZoneCollection; }
		}

		protected override void InitializeDecorator()
		{
			this._decorator = new GridSelectACMainZoneDecorator(base.UserId, base.GridControl);
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
			ACMainZone entity = ACMainZone.GetByPK(this.ACMainZone.ACMainZonePK);
			if (entity == null)
			{
				base.ShowNoViewPrivilegeWarning();
				return;
			}

			FormDetailACMainZone dlg = new FormDetailACMainZone(base.UserId, entity);
			dlg.ShowDialog();
		}

		protected override void DataBinding()
		{
			this._decorator.DataSource = this.GetDataSource();
		}

		private ACMainZoneCollection GetDataSource()
		{
			ACMainZoneViewCollection list = this.GetOriginalDataSource();
			ACMainZoneCollection retList = new ACMainZoneCollection();
			foreach (ACMainZoneView item in list)
			{
				if(this._pkList != null && this._pkList.ContainsKey(item.ACMainZonePK))
					continue;

				retList.Add(new ACMainZone(item.ToACMainZoneData()));
			}

			retList.AcceptChanges();
			return retList;
		}

		private ACMainZoneViewCollection GetOriginalDataSource()
		{
			return ACMainZone.GetViewAll();
		}
	}
}
