using System.Reflection;
using System.Collections.Generic;
using System.Windows.Forms;
using Cheke.BusinessEntity;
using Cheke.WinCtrl;
using W3000.Schema;
using W3000.Data;
using W3000.ViewObj;
using W3000.Manager.GridDecorator;

namespace W3000.Manager.FormWorkList
{
	public partial class FormWorkACPanelList : FormWorkListBase
	{
		private ACPanelCollection _list = null;
		private GridACPanelDecorator _decorator = null;

		public FormWorkACPanelList()
		{
			InitializeComponent();
		}

		public FormWorkACPanelList(string userid, Control parent)
			: base(userid, parent)
		{
			InitializeComponent();
		}

		protected override void InitializeDecorator()
		{
			this._decorator = new GridACPanelDecorator(base.UserId, this.gridControl1);
			this._decorator.Initialize();
		}

		protected override void InitializeForm()
		{
			base.InitializeForm();
			this.Caption = "ACPanel List";
			this.ShowImportButton = FormMain.Instance.HasAddNewPrivilege(ACPanelSchema.TableName);
		}

		protected override void DataBinding()
		{
			this.Cursor = Cursors.WaitCursor;
			this._list = ACPanel.GetAll();
			this._decorator.DataSource = this._list;
			this.Cursor = Cursors.Default;
		}

		protected override void ProcessImportData(BusinessCollectionBase src, BusinessCollectionBase imported, List<PropertyInfo> columnList)
		{
			ACPanelCollection importedList = imported as ACPanelCollection;
			if (importedList == null)
				return;

			ACPanelCollection srcList = src as ACPanelCollection;
			if (srcList == null)
				return;

			//BDBuilding
			SortedList<string, BDBuilding> bDBuildingIndex = new SortedList<string, BDBuilding>();
			//BDBuildingViewCollection bDBuildingViewList = BDBuilding.GetViewAll();
			//BDBuildingCollection bDBuildingList = new BDBuildingCollection();
			//bDBuildingList.AddRange(bDBuildingViewList);
			BDBuildingCollection bDBuildingList = BDBuilding.GetAll();
			foreach (BDBuilding item in bDBuildingList)
			{
				string bDBuildingKey = string.Format("{0}:{1}", item.Address1, item.BuildingID);
				if (bDBuildingIndex.ContainsKey(bDBuildingKey))
					continue;

				bDBuildingIndex.Add(bDBuildingKey, item);
			}

			SortedList<string, ACPanel> srcIndex = new SortedList<string, ACPanel>();
			foreach (ACPanel item in srcList)
			{
				string aCPanelKey = string.Format("{0}", item.UnitID);
				if (srcIndex.ContainsKey(aCPanelKey))
					continue;

				srcIndex.Add(aCPanelKey, item);
			}

			foreach (ACPanel item in importedList)
			{
				string aCPanelKey = string.Format("{0}", item.UnitID);
				if (!srcIndex.ContainsKey(aCPanelKey))
				{
					//BDBuilding
					string bDBuildingKey = string.Format("{0}:{1}", item.Address1, item.BuildingID);
					if(bDBuildingIndex.ContainsKey(bDBuildingKey))
					{
						item.BDBuilding = bDBuildingIndex[bDBuildingKey];
					}

					srcIndex.Add(aCPanelKey, item);
					srcList.Add(item);
				}
				else
				{
					ACPanel srcEntity = srcIndex[aCPanelKey];

					//BDBuilding
					string bDBuildingKey = string.Format("{0}:{1}", item.Address1, item.BuildingID);
					if(bDBuildingIndex.ContainsKey(bDBuildingKey))
					{
						srcEntity.BDBuilding = bDBuildingIndex[bDBuildingKey];
					}

					foreach (PropertyInfo property in columnList)
					{
						object obj = property.GetValue(item, null);
						if (obj == null)
							continue;

						property.SetValue(srcEntity, obj, null);
					}
				}
			}
		}

	}
}
