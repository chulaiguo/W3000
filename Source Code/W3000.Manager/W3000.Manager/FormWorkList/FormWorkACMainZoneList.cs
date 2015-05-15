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
	public partial class FormWorkACMainZoneList : FormWorkListBase
	{
		private ACMainZoneCollection _list = null;
		private GridACMainZoneDecorator _decorator = null;

		public FormWorkACMainZoneList()
		{
			InitializeComponent();
		}

		public FormWorkACMainZoneList(string userid, Control parent)
			: base(userid, parent)
		{
			InitializeComponent();
		}

		protected override void InitializeDecorator()
		{
			this._decorator = new GridACMainZoneDecorator(base.UserId, this.gridControl1);
			this._decorator.Initialize();
		}

		protected override void InitializeForm()
		{
			base.InitializeForm();
			this.Caption = "ACMainZone List";
			this.ShowImportButton = FormMain.Instance.HasAddNewPrivilege(ACMainZoneSchema.TableName);
		}

		protected override void DataBinding()
		{
			this.Cursor = Cursors.WaitCursor;
			this._list = ACMainZone.GetAll();
			this._decorator.DataSource = this._list;
			this.Cursor = Cursors.Default;
		}

		protected override void ProcessImportData(BusinessCollectionBase src, BusinessCollectionBase imported, List<PropertyInfo> columnList)
		{
			ACMainZoneCollection importedList = imported as ACMainZoneCollection;
			if (importedList == null)
				return;

			ACMainZoneCollection srcList = src as ACMainZoneCollection;
			if (srcList == null)
				return;

			//ACPanel
			SortedList<string, ACPanel> aCPanelIndex = new SortedList<string, ACPanel>();
			//ACPanelViewCollection aCPanelViewList = ACPanel.GetViewAll();
			//ACPanelCollection aCPanelList = new ACPanelCollection();
			//aCPanelList.AddRange(aCPanelViewList);
			ACPanelCollection aCPanelList = ACPanel.GetAll();
			foreach (ACPanel item in aCPanelList)
			{
				string aCPanelKey = string.Format("{0}", item.UnitID);
				if (aCPanelIndex.ContainsKey(aCPanelKey))
					continue;

				aCPanelIndex.Add(aCPanelKey, item);
			}

			SortedList<string, ACMainZone> srcIndex = new SortedList<string, ACMainZone>();
			foreach (ACMainZone item in srcList)
			{
				string aCMainZoneKey = string.Format("{0}:{1}", item.UnitID, item.PanelZoneID);
				if (srcIndex.ContainsKey(aCMainZoneKey))
					continue;

				srcIndex.Add(aCMainZoneKey, item);
			}

			foreach (ACMainZone item in importedList)
			{
				string aCMainZoneKey = string.Format("{0}:{1}", item.UnitID, item.PanelZoneID);
				if (!srcIndex.ContainsKey(aCMainZoneKey))
				{
					//ACPanel
					string aCPanelKey = string.Format("{0}", item.UnitID);
					if(aCPanelIndex.ContainsKey(aCPanelKey))
					{
						item.ACPanel = aCPanelIndex[aCPanelKey];
					}

					srcIndex.Add(aCMainZoneKey, item);
					srcList.Add(item);
				}
				else
				{
					ACMainZone srcEntity = srcIndex[aCMainZoneKey];

					//ACPanel
					string aCPanelKey = string.Format("{0}", item.UnitID);
					if(aCPanelIndex.ContainsKey(aCPanelKey))
					{
						srcEntity.ACPanel = aCPanelIndex[aCPanelKey];
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
