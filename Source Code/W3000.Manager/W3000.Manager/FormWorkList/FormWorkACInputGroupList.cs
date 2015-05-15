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
	public partial class FormWorkACInputGroupList : FormWorkListBase
	{
		private ACInputGroupCollection _list = null;
		private GridACInputGroupDecorator _decorator = null;

		public FormWorkACInputGroupList()
		{
			InitializeComponent();
		}

		public FormWorkACInputGroupList(string userid, Control parent)
			: base(userid, parent)
		{
			InitializeComponent();
		}

		protected override void InitializeDecorator()
		{
			this._decorator = new GridACInputGroupDecorator(base.UserId, this.gridControl1);
			this._decorator.Initialize();
		}

		protected override void InitializeForm()
		{
			base.InitializeForm();
			this.Caption = "ACInputGroup List";
			this.ShowImportButton = FormMain.Instance.HasAddNewPrivilege(ACInputGroupSchema.TableName);
		}

		protected override void DataBinding()
		{
			this.Cursor = Cursors.WaitCursor;
			this._list = ACInputGroup.GetAll();
			this._decorator.DataSource = this._list;
			this.Cursor = Cursors.Default;
		}

		protected override void ProcessImportData(BusinessCollectionBase src, BusinessCollectionBase imported, List<PropertyInfo> columnList)
		{
			ACInputGroupCollection importedList = imported as ACInputGroupCollection;
			if (importedList == null)
				return;

			ACInputGroupCollection srcList = src as ACInputGroupCollection;
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

			SortedList<string, ACInputGroup> srcIndex = new SortedList<string, ACInputGroup>();
			foreach (ACInputGroup item in srcList)
			{
				string aCInputGroupKey = string.Format("{0}:{1}", item.UnitID, item.GroupID);
				if (srcIndex.ContainsKey(aCInputGroupKey))
					continue;

				srcIndex.Add(aCInputGroupKey, item);
			}

			foreach (ACInputGroup item in importedList)
			{
				string aCInputGroupKey = string.Format("{0}:{1}", item.UnitID, item.GroupID);
				if (!srcIndex.ContainsKey(aCInputGroupKey))
				{
					//ACPanel
					string aCPanelKey = string.Format("{0}", item.UnitID);
					if(aCPanelIndex.ContainsKey(aCPanelKey))
					{
						item.ACPanel = aCPanelIndex[aCPanelKey];
					}

					srcIndex.Add(aCInputGroupKey, item);
					srcList.Add(item);
				}
				else
				{
					ACInputGroup srcEntity = srcIndex[aCInputGroupKey];

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
