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
	public partial class FormWorkBDBuildingList : FormWorkListBase
	{
		private BDBuildingCollection _list = null;
		private GridBDBuildingDecorator _decorator = null;

		public FormWorkBDBuildingList()
		{
			InitializeComponent();
		}

		public FormWorkBDBuildingList(string userid, Control parent)
			: base(userid, parent)
		{
			InitializeComponent();
		}

		protected override void InitializeDecorator()
		{
			this._decorator = new GridBDBuildingDecorator(base.UserId, this.gridControl1);
			this._decorator.Initialize();
		}

		protected override void InitializeForm()
		{
			base.InitializeForm();
			this.Caption = "BDBuilding List";
			this.ShowImportButton = FormMain.Instance.HasAddNewPrivilege(BDBuildingSchema.TableName);
		}

		protected override void DataBinding()
		{
			this.Cursor = Cursors.WaitCursor;
			this._list = BDBuilding.GetAll();
			this._decorator.DataSource = this._list;
			this.Cursor = Cursors.Default;
		}

		protected override void ProcessImportData(BusinessCollectionBase src, BusinessCollectionBase imported, List<PropertyInfo> columnList)
		{
			BDBuildingCollection importedList = imported as BDBuildingCollection;
			if (importedList == null)
				return;

			BDBuildingCollection srcList = src as BDBuildingCollection;
			if (srcList == null)
				return;

			SortedList<string, BDBuilding> srcIndex = new SortedList<string, BDBuilding>();
			foreach (BDBuilding item in srcList)
			{
				string bDBuildingKey = string.Format("{0}:{1}", item.Address1, item.BuildingID);
				if (srcIndex.ContainsKey(bDBuildingKey))
					continue;

				srcIndex.Add(bDBuildingKey, item);
			}

			foreach (BDBuilding item in importedList)
			{
				string bDBuildingKey = string.Format("{0}:{1}", item.Address1, item.BuildingID);
				if (!srcIndex.ContainsKey(bDBuildingKey))
				{
					srcIndex.Add(bDBuildingKey, item);
					srcList.Add(item);
				}
				else
				{
					BDBuilding srcEntity = srcIndex[bDBuildingKey];

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
