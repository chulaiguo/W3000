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
	public partial class FormWorkACSupervisoryList : FormWorkListBase
	{
		private ACSupervisoryCollection _list = null;
		private GridACSupervisoryDecorator _decorator = null;

		public FormWorkACSupervisoryList()
		{
			InitializeComponent();
		}

		public FormWorkACSupervisoryList(string userid, Control parent)
			: base(userid, parent)
		{
			InitializeComponent();
		}

		protected override void InitializeDecorator()
		{
			this._decorator = new GridACSupervisoryDecorator(base.UserId, this.gridControl1);
			this._decorator.Initialize();
		}

		protected override void InitializeForm()
		{
			base.InitializeForm();
			this.Caption = "ACSupervisory List";
			this.ShowImportButton = FormMain.Instance.HasAddNewPrivilege(ACSupervisorySchema.TableName);
		}

		protected override void DataBinding()
		{
			this.Cursor = Cursors.WaitCursor;
			this._list = ACSupervisory.GetAll();
			this._decorator.DataSource = this._list;
			this.Cursor = Cursors.Default;
		}

		protected override void ProcessImportData(BusinessCollectionBase src, BusinessCollectionBase imported, List<PropertyInfo> columnList)
		{
			ACSupervisoryCollection importedList = imported as ACSupervisoryCollection;
			if (importedList == null)
				return;

			ACSupervisoryCollection srcList = src as ACSupervisoryCollection;
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

			SortedList<string, ACSupervisory> srcIndex = new SortedList<string, ACSupervisory>();
			foreach (ACSupervisory item in srcList)
			{
				string aCSupervisoryKey = string.Format("{0}:{1}", item.UnitID, item.PanelZoneID);
				if (srcIndex.ContainsKey(aCSupervisoryKey))
					continue;

				srcIndex.Add(aCSupervisoryKey, item);
			}

			foreach (ACSupervisory item in importedList)
			{
				string aCSupervisoryKey = string.Format("{0}:{1}", item.UnitID, item.PanelZoneID);
				if (!srcIndex.ContainsKey(aCSupervisoryKey))
				{
					//ACPanel
					string aCPanelKey = string.Format("{0}", item.UnitID);
					if(aCPanelIndex.ContainsKey(aCPanelKey))
					{
						item.ACPanel = aCPanelIndex[aCPanelKey];
					}

					srcIndex.Add(aCSupervisoryKey, item);
					srcList.Add(item);
				}
				else
				{
					ACSupervisory srcEntity = srcIndex[aCSupervisoryKey];

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
