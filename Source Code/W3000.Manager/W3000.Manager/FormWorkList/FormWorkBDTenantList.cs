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
	public partial class FormWorkBDTenantList : FormWorkListBase
	{
		private BDTenantCollection _list = null;
		private GridBDTenantDecorator _decorator = null;

		public FormWorkBDTenantList()
		{
			InitializeComponent();
		}

		public FormWorkBDTenantList(string userid, Control parent)
			: base(userid, parent)
		{
			InitializeComponent();
		}

		protected override void InitializeDecorator()
		{
			this._decorator = new GridBDTenantDecorator(base.UserId, this.gridControl1);
			this._decorator.Initialize();
		}

		protected override void InitializeForm()
		{
			base.InitializeForm();
			this.Caption = "BDTenant List";
			this.ShowImportButton = FormMain.Instance.HasAddNewPrivilege(BDTenantSchema.TableName);
		}

		protected override void DataBinding()
		{
			this.Cursor = Cursors.WaitCursor;
			this._list = BDTenant.GetAll();
			this._decorator.DataSource = this._list;
			this.Cursor = Cursors.Default;
		}

		protected override void ProcessImportData(BusinessCollectionBase src, BusinessCollectionBase imported, List<PropertyInfo> columnList)
		{
			BDTenantCollection importedList = imported as BDTenantCollection;
			if (importedList == null)
				return;

			BDTenantCollection srcList = src as BDTenantCollection;
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

			SortedList<string, BDTenant> srcIndex = new SortedList<string, BDTenant>();
			foreach (BDTenant item in srcList)
			{
				string bDTenantKey = string.Format("{0}:{1}:{2}", item.Address1, item.BuildingID, item.Tenant);
				if (srcIndex.ContainsKey(bDTenantKey))
					continue;

				srcIndex.Add(bDTenantKey, item);
			}

			foreach (BDTenant item in importedList)
			{
				string bDTenantKey = string.Format("{0}:{1}:{2}", item.Address1, item.BuildingID, item.Tenant);
				if (!srcIndex.ContainsKey(bDTenantKey))
				{
					//BDBuilding
					string bDBuildingKey = string.Format("{0}:{1}", item.Address1, item.BuildingID);
					if(bDBuildingIndex.ContainsKey(bDBuildingKey))
					{
						item.BDBuilding = bDBuildingIndex[bDBuildingKey];
					}

					srcIndex.Add(bDTenantKey, item);
					srcList.Add(item);
				}
				else
				{
					BDTenant srcEntity = srcIndex[bDTenantKey];

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
