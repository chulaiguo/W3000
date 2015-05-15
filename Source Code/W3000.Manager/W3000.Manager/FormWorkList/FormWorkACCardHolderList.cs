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
	public partial class FormWorkACCardHolderList : FormWorkListBase
	{
		private ACCardHolderCollection _list = null;
		private GridACCardHolderDecorator _decorator = null;

		public FormWorkACCardHolderList()
		{
			InitializeComponent();
		}

		public FormWorkACCardHolderList(string userid, Control parent)
			: base(userid, parent)
		{
			InitializeComponent();
		}

		protected override void InitializeDecorator()
		{
			this._decorator = new GridACCardHolderDecorator(base.UserId, this.gridControl1);
			this._decorator.Initialize();
		}

		protected override void InitializeForm()
		{
			base.InitializeForm();
			this.Caption = "ACCardHolder List";
			this.ShowImportButton = FormMain.Instance.HasAddNewPrivilege(ACCardHolderSchema.TableName);
		}

		protected override void DataBinding()
		{
			this.Cursor = Cursors.WaitCursor;
			this._list = ACCardHolder.GetAll();
			this._decorator.DataSource = this._list;
			this.Cursor = Cursors.Default;
		}

		protected override void ProcessImportData(BusinessCollectionBase src, BusinessCollectionBase imported, List<PropertyInfo> columnList)
		{
			ACCardHolderCollection importedList = imported as ACCardHolderCollection;
			if (importedList == null)
				return;

			ACCardHolderCollection srcList = src as ACCardHolderCollection;
			if (srcList == null)
				return;

			//BDTenant
			SortedList<string, BDTenant> bDTenantIndex = new SortedList<string, BDTenant>();
			//BDTenantViewCollection bDTenantViewList = BDTenant.GetViewAll();
			//BDTenantCollection bDTenantList = new BDTenantCollection();
			//bDTenantList.AddRange(bDTenantViewList);
			BDTenantCollection bDTenantList = BDTenant.GetAll();
			foreach (BDTenant item in bDTenantList)
			{
				string bDTenantKey = string.Format("{0}:{1}:{2}", item.Address1, item.BuildingID, item.Tenant);
				if (bDTenantIndex.ContainsKey(bDTenantKey))
					continue;

				bDTenantIndex.Add(bDTenantKey, item);
			}

			SortedList<string, ACCardHolder> srcIndex = new SortedList<string, ACCardHolder>();
			foreach (ACCardHolder item in srcList)
			{
				string aCCardHolderKey = string.Format("{0}:{1}:{2}:{3}:{4}:{5}", item.Sitecode, item.Embossed, item.CardTypeID, item.Sitecode, item.Encoded, item.CardTypeID);
				if (srcIndex.ContainsKey(aCCardHolderKey))
					continue;

				srcIndex.Add(aCCardHolderKey, item);
			}

			foreach (ACCardHolder item in importedList)
			{
				string aCCardHolderKey = string.Format("{0}:{1}:{2}:{3}:{4}:{5}", item.Sitecode, item.Embossed, item.CardTypeID, item.Sitecode, item.Encoded, item.CardTypeID);
				if (!srcIndex.ContainsKey(aCCardHolderKey))
				{
					//BDTenant
					string bDTenantKey = string.Format("{0}:{1}:{2}", item.Address1, item.BuildingID, item.Tenant);
					if(bDTenantIndex.ContainsKey(bDTenantKey))
					{
						item.BDTenant = bDTenantIndex[bDTenantKey];
					}

					srcIndex.Add(aCCardHolderKey, item);
					srcList.Add(item);
				}
				else
				{
					ACCardHolder srcEntity = srcIndex[aCCardHolderKey];

					//BDTenant
					string bDTenantKey = string.Format("{0}:{1}:{2}", item.Address1, item.BuildingID, item.Tenant);
					if(bDTenantIndex.ContainsKey(bDTenantKey))
					{
						srcEntity.BDTenant = bDTenantIndex[bDTenantKey];
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
