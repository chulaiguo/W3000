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
	public partial class FormWorkACTimecodeList : FormWorkListBase
	{
		private ACTimecodeCollection _list = null;
		private GridACTimecodeDecorator _decorator = null;

		public FormWorkACTimecodeList()
		{
			InitializeComponent();
		}

		public FormWorkACTimecodeList(string userid, Control parent)
			: base(userid, parent)
		{
			InitializeComponent();
		}

		protected override void InitializeDecorator()
		{
			this._decorator = new GridACTimecodeDecorator(base.UserId, this.gridControl1);
			this._decorator.Initialize();
		}

		protected override void InitializeForm()
		{
			base.InitializeForm();
			this.Caption = "ACTimecode List";
			this.ShowImportButton = FormMain.Instance.HasAddNewPrivilege(ACTimecodeSchema.TableName);
		}

		protected override void DataBinding()
		{
			this.Cursor = Cursors.WaitCursor;
			this._list = ACTimecode.GetAll();
			this._decorator.DataSource = this._list;
			this.Cursor = Cursors.Default;
		}

		protected override void ProcessImportData(BusinessCollectionBase src, BusinessCollectionBase imported, List<PropertyInfo> columnList)
		{
			ACTimecodeCollection importedList = imported as ACTimecodeCollection;
			if (importedList == null)
				return;

			ACTimecodeCollection srcList = src as ACTimecodeCollection;
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

			SortedList<string, ACTimecode> srcIndex = new SortedList<string, ACTimecode>();
			foreach (ACTimecode item in srcList)
			{
				string aCTimecodeKey = string.Format("{0}:{1}:{2}", item.Address1, item.BuildingID, item.TCID);
				if (srcIndex.ContainsKey(aCTimecodeKey))
					continue;

				srcIndex.Add(aCTimecodeKey, item);
			}

			foreach (ACTimecode item in importedList)
			{
				string aCTimecodeKey = string.Format("{0}:{1}:{2}", item.Address1, item.BuildingID, item.TCID);
				if (!srcIndex.ContainsKey(aCTimecodeKey))
				{
					//BDBuilding
					string bDBuildingKey = string.Format("{0}:{1}", item.Address1, item.BuildingID);
					if(bDBuildingIndex.ContainsKey(bDBuildingKey))
					{
						item.BDBuilding = bDBuildingIndex[bDBuildingKey];
					}

					srcIndex.Add(aCTimecodeKey, item);
					srcList.Add(item);
				}
				else
				{
					ACTimecode srcEntity = srcIndex[aCTimecodeKey];

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
