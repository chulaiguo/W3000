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
	public partial class FormWorkACIntervalList : FormWorkListBase
	{
		private ACIntervalCollection _list = null;
		private GridACIntervalDecorator _decorator = null;

		public FormWorkACIntervalList()
		{
			InitializeComponent();
		}

		public FormWorkACIntervalList(string userid, Control parent)
			: base(userid, parent)
		{
			InitializeComponent();
		}

		protected override void InitializeDecorator()
		{
			this._decorator = new GridACIntervalDecorator(base.UserId, this.gridControl1);
			this._decorator.Initialize();
		}

		protected override void InitializeForm()
		{
			base.InitializeForm();
			this.Caption = "ACInterval List";
			this.ShowImportButton = FormMain.Instance.HasAddNewPrivilege(ACIntervalSchema.TableName);
		}

		protected override void DataBinding()
		{
			this.Cursor = Cursors.WaitCursor;
			this._list = ACInterval.GetAll();
			this._decorator.DataSource = this._list;
			this.Cursor = Cursors.Default;
		}

		protected override void ProcessImportData(BusinessCollectionBase src, BusinessCollectionBase imported, List<PropertyInfo> columnList)
		{
			ACIntervalCollection importedList = imported as ACIntervalCollection;
			if (importedList == null)
				return;

			ACIntervalCollection srcList = src as ACIntervalCollection;
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

			SortedList<string, ACInterval> srcIndex = new SortedList<string, ACInterval>();
			foreach (ACInterval item in srcList)
			{
				string aCIntervalKey = string.Format("{0}:{1}:{2}", item.Address1, item.BuildingID, item.IVID);
				if (srcIndex.ContainsKey(aCIntervalKey))
					continue;

				srcIndex.Add(aCIntervalKey, item);
			}

			foreach (ACInterval item in importedList)
			{
				string aCIntervalKey = string.Format("{0}:{1}:{2}", item.Address1, item.BuildingID, item.IVID);
				if (!srcIndex.ContainsKey(aCIntervalKey))
				{
					//BDBuilding
					string bDBuildingKey = string.Format("{0}:{1}", item.Address1, item.BuildingID);
					if(bDBuildingIndex.ContainsKey(bDBuildingKey))
					{
						item.BDBuilding = bDBuildingIndex[bDBuildingKey];
					}

					srcIndex.Add(aCIntervalKey, item);
					srcList.Add(item);
				}
				else
				{
					ACInterval srcEntity = srcIndex[aCIntervalKey];

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
