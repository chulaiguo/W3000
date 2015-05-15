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
	public partial class FormWorkACAccessLevelList : FormWorkListBase
	{
		private ACAccessLevelCollection _list = null;
		private GridACAccessLevelDecorator _decorator = null;

		public FormWorkACAccessLevelList()
		{
			InitializeComponent();
		}

		public FormWorkACAccessLevelList(string userid, Control parent)
			: base(userid, parent)
		{
			InitializeComponent();
		}

		protected override void InitializeDecorator()
		{
			this._decorator = new GridACAccessLevelDecorator(base.UserId, this.gridControl1);
			this._decorator.Initialize();
		}

		protected override void InitializeForm()
		{
			base.InitializeForm();
			this.Caption = "ACAccessLevel List";
			this.ShowImportButton = FormMain.Instance.HasAddNewPrivilege(ACAccessLevelSchema.TableName);
		}

		protected override void DataBinding()
		{
			this.Cursor = Cursors.WaitCursor;
			this._list = ACAccessLevel.GetAll();
			this._decorator.DataSource = this._list;
			this.Cursor = Cursors.Default;
		}

		protected override void ProcessImportData(BusinessCollectionBase src, BusinessCollectionBase imported, List<PropertyInfo> columnList)
		{
			ACAccessLevelCollection importedList = imported as ACAccessLevelCollection;
			if (importedList == null)
				return;

			ACAccessLevelCollection srcList = src as ACAccessLevelCollection;
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

			SortedList<string, ACAccessLevel> srcIndex = new SortedList<string, ACAccessLevel>();
			foreach (ACAccessLevel item in srcList)
			{
				string aCAccessLevelKey = string.Format("{0}:{1}:{2}", item.Address1, item.BuildingID, item.AccessLevelID);
				if (srcIndex.ContainsKey(aCAccessLevelKey))
					continue;

				srcIndex.Add(aCAccessLevelKey, item);
			}

			foreach (ACAccessLevel item in importedList)
			{
				string aCAccessLevelKey = string.Format("{0}:{1}:{2}", item.Address1, item.BuildingID, item.AccessLevelID);
				if (!srcIndex.ContainsKey(aCAccessLevelKey))
				{
					//BDBuilding
					string bDBuildingKey = string.Format("{0}:{1}", item.Address1, item.BuildingID);
					if(bDBuildingIndex.ContainsKey(bDBuildingKey))
					{
						item.BDBuilding = bDBuildingIndex[bDBuildingKey];
					}

					srcIndex.Add(aCAccessLevelKey, item);
					srcList.Add(item);
				}
				else
				{
					ACAccessLevel srcEntity = srcIndex[aCAccessLevelKey];

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
