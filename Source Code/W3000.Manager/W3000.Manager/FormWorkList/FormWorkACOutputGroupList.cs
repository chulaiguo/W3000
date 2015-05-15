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
	public partial class FormWorkACOutputGroupList : FormWorkListBase
	{
		private ACOutputGroupCollection _list = null;
		private GridACOutputGroupDecorator _decorator = null;

		public FormWorkACOutputGroupList()
		{
			InitializeComponent();
		}

		public FormWorkACOutputGroupList(string userid, Control parent)
			: base(userid, parent)
		{
			InitializeComponent();
		}

		protected override void InitializeDecorator()
		{
			this._decorator = new GridACOutputGroupDecorator(base.UserId, this.gridControl1);
			this._decorator.Initialize();
		}

		protected override void InitializeForm()
		{
			base.InitializeForm();
			this.Caption = "ACOutputGroup List";
			this.ShowImportButton = FormMain.Instance.HasAddNewPrivilege(ACOutputGroupSchema.TableName);
		}

		protected override void DataBinding()
		{
			this.Cursor = Cursors.WaitCursor;
			this._list = ACOutputGroup.GetAll();
			this._decorator.DataSource = this._list;
			this.Cursor = Cursors.Default;
		}

		protected override void ProcessImportData(BusinessCollectionBase src, BusinessCollectionBase imported, List<PropertyInfo> columnList)
		{
			ACOutputGroupCollection importedList = imported as ACOutputGroupCollection;
			if (importedList == null)
				return;

			ACOutputGroupCollection srcList = src as ACOutputGroupCollection;
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

			SortedList<string, ACOutputGroup> srcIndex = new SortedList<string, ACOutputGroup>();
			foreach (ACOutputGroup item in srcList)
			{
				string aCOutputGroupKey = string.Format("{0}:{1}", item.UnitID, item.GroupID);
				if (srcIndex.ContainsKey(aCOutputGroupKey))
					continue;

				srcIndex.Add(aCOutputGroupKey, item);
			}

			foreach (ACOutputGroup item in importedList)
			{
				string aCOutputGroupKey = string.Format("{0}:{1}", item.UnitID, item.GroupID);
				if (!srcIndex.ContainsKey(aCOutputGroupKey))
				{
					//ACPanel
					string aCPanelKey = string.Format("{0}", item.UnitID);
					if(aCPanelIndex.ContainsKey(aCPanelKey))
					{
						item.ACPanel = aCPanelIndex[aCPanelKey];
					}

					srcIndex.Add(aCOutputGroupKey, item);
					srcList.Add(item);
				}
				else
				{
					ACOutputGroup srcEntity = srcIndex[aCOutputGroupKey];

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
