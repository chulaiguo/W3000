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
	public partial class FormWorkUsrAccountList : FormWorkListBase
	{
		private UsrAccountCollection _list = null;
		private GridUsrAccountDecorator _decorator = null;

		public FormWorkUsrAccountList()
		{
			InitializeComponent();
		}

		public FormWorkUsrAccountList(string userid, Control parent)
			: base(userid, parent)
		{
			InitializeComponent();
		}

		protected override void InitializeDecorator()
		{
			this._decorator = new GridUsrAccountDecorator(base.UserId, this.gridControl1);
			this._decorator.Initialize();
		}

		protected override void InitializeForm()
		{
			base.InitializeForm();
			this.Caption = "UsrAccount List";
			this.ShowImportButton = FormMain.Instance.HasAddNewPrivilege(UsrAccountSchema.TableName);
		}

		protected override void DataBinding()
		{
			this.Cursor = Cursors.WaitCursor;
			this._list = UsrAccount.GetAll();
			this._decorator.DataSource = this._list;
			this.Cursor = Cursors.Default;
		}

		protected override void ProcessImportData(BusinessCollectionBase src, BusinessCollectionBase imported, List<PropertyInfo> columnList)
		{
			UsrAccountCollection importedList = imported as UsrAccountCollection;
			if (importedList == null)
				return;

			UsrAccountCollection srcList = src as UsrAccountCollection;
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

			//UsrGroup
			SortedList<string, UsrGroup> usrGroupIndex = new SortedList<string, UsrGroup>();
			//UsrGroupViewCollection usrGroupViewList = UsrGroup.GetViewAll();
			//UsrGroupCollection usrGroupList = new UsrGroupCollection();
			//usrGroupList.AddRange(usrGroupViewList);
			UsrGroupCollection usrGroupList = UsrGroup.GetAll();
			foreach (UsrGroup item in usrGroupList)
			{
				string usrGroupKey = string.Format("{0}", item.UsrGroupName);
				if (usrGroupIndex.ContainsKey(usrGroupKey))
					continue;

				usrGroupIndex.Add(usrGroupKey, item);
			}

			SortedList<string, UsrAccount> srcIndex = new SortedList<string, UsrAccount>();
			foreach (UsrAccount item in srcList)
			{
				string usrAccountKey = string.Format("{0}", item.UserID);
				if (srcIndex.ContainsKey(usrAccountKey))
					continue;

				srcIndex.Add(usrAccountKey, item);
			}

			foreach (UsrAccount item in importedList)
			{
				string usrAccountKey = string.Format("{0}", item.UserID);
				if (!srcIndex.ContainsKey(usrAccountKey))
				{
					//BDTenant
					string bDTenantKey = string.Format("{0}:{1}:{2}", item.Address1, item.BuildingID, item.Tenant);
					if(bDTenantIndex.ContainsKey(bDTenantKey))
					{
						item.BDTenant = bDTenantIndex[bDTenantKey];
					}

					//UsrGroup
					string usrGroupKey = string.Format("{0}", item.UsrGroupName);
					if(usrGroupIndex.ContainsKey(usrGroupKey))
					{
						item.UsrGroup = usrGroupIndex[usrGroupKey];
					}

					srcIndex.Add(usrAccountKey, item);
					srcList.Add(item);
				}
				else
				{
					UsrAccount srcEntity = srcIndex[usrAccountKey];

					//BDTenant
					string bDTenantKey = string.Format("{0}:{1}:{2}", item.Address1, item.BuildingID, item.Tenant);
					if(bDTenantIndex.ContainsKey(bDTenantKey))
					{
						srcEntity.BDTenant = bDTenantIndex[bDTenantKey];
					}

					//UsrGroup
					string usrGroupKey = string.Format("{0}", item.UsrGroupName);
					if(usrGroupIndex.ContainsKey(usrGroupKey))
					{
						srcEntity.UsrGroup = usrGroupIndex[usrGroupKey];
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
