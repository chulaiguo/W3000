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
	public partial class FormWorkACFunctionCardList : FormWorkListBase
	{
		private ACFunctionCardCollection _list = null;
		private GridACFunctionCardDecorator _decorator = null;

		public FormWorkACFunctionCardList()
		{
			InitializeComponent();
		}

		public FormWorkACFunctionCardList(string userid, Control parent)
			: base(userid, parent)
		{
			InitializeComponent();
		}

		protected override void InitializeDecorator()
		{
			this._decorator = new GridACFunctionCardDecorator(base.UserId, this.gridControl1);
			this._decorator.Initialize();
		}

		protected override void InitializeForm()
		{
			base.InitializeForm();
			this.Caption = "ACFunctionCard List";
			this.ShowImportButton = FormMain.Instance.HasAddNewPrivilege(ACFunctionCardSchema.TableName);
		}

		protected override void DataBinding()
		{
			this.Cursor = Cursors.WaitCursor;
			this._list = ACFunctionCard.GetAll();
			this._decorator.DataSource = this._list;
			this.Cursor = Cursors.Default;
		}

		protected override void ProcessImportData(BusinessCollectionBase src, BusinessCollectionBase imported, List<PropertyInfo> columnList)
		{
			ACFunctionCardCollection importedList = imported as ACFunctionCardCollection;
			if (importedList == null)
				return;

			ACFunctionCardCollection srcList = src as ACFunctionCardCollection;
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

			SortedList<string, ACFunctionCard> srcIndex = new SortedList<string, ACFunctionCard>();
			foreach (ACFunctionCard item in srcList)
			{
				string aCFunctionCardKey = string.Format("{0}:{1}:{2}:{3}:{4}:{5}", item.Sitecode, item.Embossed, item.CardTypeID, item.Sitecode, item.Encoded, item.CardTypeID);
				if (srcIndex.ContainsKey(aCFunctionCardKey))
					continue;

				srcIndex.Add(aCFunctionCardKey, item);
			}

			foreach (ACFunctionCard item in importedList)
			{
				string aCFunctionCardKey = string.Format("{0}:{1}:{2}:{3}:{4}:{5}", item.Sitecode, item.Embossed, item.CardTypeID, item.Sitecode, item.Encoded, item.CardTypeID);
				if (!srcIndex.ContainsKey(aCFunctionCardKey))
				{
					//BDTenant
					string bDTenantKey = string.Format("{0}:{1}:{2}", item.Address1, item.BuildingID, item.Tenant);
					if(bDTenantIndex.ContainsKey(bDTenantKey))
					{
						item.BDTenant = bDTenantIndex[bDTenantKey];
					}

					srcIndex.Add(aCFunctionCardKey, item);
					srcList.Add(item);
				}
				else
				{
					ACFunctionCard srcEntity = srcIndex[aCFunctionCardKey];

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
