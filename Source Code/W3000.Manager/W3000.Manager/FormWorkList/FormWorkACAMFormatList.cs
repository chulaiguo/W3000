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
	public partial class FormWorkACAMFormatList : FormWorkListBase
	{
		private ACAMFormatCollection _list = null;
		private GridACAMFormatDecorator _decorator = null;

		public FormWorkACAMFormatList()
		{
			InitializeComponent();
		}

		public FormWorkACAMFormatList(string userid, Control parent)
			: base(userid, parent)
		{
			InitializeComponent();
		}

		protected override void InitializeDecorator()
		{
			this._decorator = new GridACAMFormatDecorator(base.UserId, this.gridControl1);
			this._decorator.Initialize();
		}

		protected override void InitializeForm()
		{
			base.InitializeForm();
			this.Caption = "ACAMFormat List";
			this.ShowImportButton = FormMain.Instance.HasAddNewPrivilege(ACAMFormatSchema.TableName);
		}

		protected override void DataBinding()
		{
			this.Cursor = Cursors.WaitCursor;
			this._list = ACAMFormat.GetAll();
			this._decorator.DataSource = this._list;
			this.Cursor = Cursors.Default;
		}

		protected override void ProcessImportData(BusinessCollectionBase src, BusinessCollectionBase imported, List<PropertyInfo> columnList)
		{
			ACAMFormatCollection importedList = imported as ACAMFormatCollection;
			if (importedList == null)
				return;

			ACAMFormatCollection srcList = src as ACAMFormatCollection;
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

			SortedList<string, ACAMFormat> srcIndex = new SortedList<string, ACAMFormat>();
			foreach (ACAMFormat item in srcList)
			{
				string aCAMFormatKey = string.Format("{0}:{1}:{2}", item.Address1, item.BuildingID, item.AMFID);
				if (srcIndex.ContainsKey(aCAMFormatKey))
					continue;

				srcIndex.Add(aCAMFormatKey, item);
			}

			foreach (ACAMFormat item in importedList)
			{
				string aCAMFormatKey = string.Format("{0}:{1}:{2}", item.Address1, item.BuildingID, item.AMFID);
				if (!srcIndex.ContainsKey(aCAMFormatKey))
				{
					//BDBuilding
					string bDBuildingKey = string.Format("{0}:{1}", item.Address1, item.BuildingID);
					if(bDBuildingIndex.ContainsKey(bDBuildingKey))
					{
						item.BDBuilding = bDBuildingIndex[bDBuildingKey];
					}

					srcIndex.Add(aCAMFormatKey, item);
					srcList.Add(item);
				}
				else
				{
					ACAMFormat srcEntity = srcIndex[aCAMFormatKey];

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
