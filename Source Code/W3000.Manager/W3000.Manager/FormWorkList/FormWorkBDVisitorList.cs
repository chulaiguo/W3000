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
	public partial class FormWorkBDVisitorList : FormWorkListBase
	{
		private BDVisitorCollection _list = null;
		private GridBDVisitorDecorator _decorator = null;

		public FormWorkBDVisitorList()
		{
			InitializeComponent();
		}

		public FormWorkBDVisitorList(string userid, Control parent)
			: base(userid, parent)
		{
			InitializeComponent();
		}

		protected override void InitializeDecorator()
		{
			this._decorator = new GridBDVisitorDecorator(base.UserId, this.gridControl1);
			this._decorator.Initialize();
		}

		protected override void InitializeForm()
		{
			base.InitializeForm();
			this.Caption = "BDVisitor List";
			this.ShowImportButton = FormMain.Instance.HasAddNewPrivilege(BDVisitorSchema.TableName);
		}

		protected override void DataBinding()
		{
			this.Cursor = Cursors.WaitCursor;
			this._list = BDVisitor.GetAll();
			this._decorator.DataSource = this._list;
			this.Cursor = Cursors.Default;
		}

		//protected override void ProcessImportData(BusinessCollectionBase src, BusinessCollectionBase imported, List<PropertyInfo> columnList)
		//{
			//BDVisitorCollection importedList = imported as BDVisitorCollection;
			//if (importedList == null)
				//return;

			//BDVisitorCollection srcList = src as BDVisitorCollection;
			//if (srcList == null)
				//return;

			//BDTenant
			//SortedList<string, BDTenant> bDTenantIndex = new SortedList<string, BDTenant>();
			////BDTenantViewCollection bDTenantViewList = BDTenant.GetViewAll();
			////BDTenantCollection bDTenantList = new BDTenantCollection();
			////bDTenantList.AddRange(bDTenantViewList);
			//BDTenantCollection bDTenantList = BDTenant.GetAll();
			//foreach (BDTenant item in bDTenantList)
			//{
				//string bDTenantKey = string.Format("{0}:{1}:{2}", item.Address1, item.BuildingID, item.Tenant);
				//if (bDTenantIndex.ContainsKey(bDTenantKey))
					//continue;

				//bDTenantIndex.Add(bDTenantKey, item);
			//}

			//SortedList<string, BDVisitor> srcIndex = new SortedList<string, BDVisitor>();
			//foreach (BDVisitor item in srcList)
			//{
				//string bDVisitorKey = string.Format("{0}", item.XXX)
				//if (srcIndex.ContainsKey(bDVisitorKey))
					//continue;

				//srcIndex.Add(bDVisitorKey, item);
			//}

			//foreach (BDVisitor item in importedList)
			//{
				//string bDVisitorKey = string.Format("{0}", item.XXX)
				//if (!srcIndex.ContainsKey(bDVisitorKey))
				//{
					////BDTenant
					//string bDTenantKey = string.Format("{0}:{1}:{2}", item.Address1, item.BuildingID, item.Tenant);
					//if(bDTenantIndex.ContainsKey(bDTenantKey))
					//{
						//item.BDTenant = bDTenantIndex[bDTenantKey];
					//}

					//srcIndex.Add(bDVisitorKey, item);
					//srcList.Add(item);
				//}
				//else
				//{
					//BDVisitor srcEntity = srcIndex[bDVisitorKey];

					////BDTenant
					//string bDTenantKey = string.Format("{0}:{1}:{2}", item.Address1, item.BuildingID, item.Tenant);
					//if(bDTenantIndex.ContainsKey(bDTenantKey))
					//{
						//srcEntity.BDTenant = bDTenantIndex[bDTenantKey];
					//}

					//foreach (PropertyInfo property in columnList)
					//{
						//object obj = property.GetValue(item, null);
						//if (obj == null)
							//continue;

						//property.SetValue(srcEntity, obj, null);
					//}
				//}
			//}
		//}

	}
}
