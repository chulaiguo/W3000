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
	public partial class FormWorkACInputList : FormWorkListBase
	{
		private ACInputCollection _list = null;
		private GridACInputDecorator _decorator = null;

		public FormWorkACInputList()
		{
			InitializeComponent();
		}

		public FormWorkACInputList(string userid, Control parent)
			: base(userid, parent)
		{
			InitializeComponent();
		}

		protected override void InitializeDecorator()
		{
			this._decorator = new GridACInputDecorator(base.UserId, this.gridControl1);
			this._decorator.Initialize();
		}

		protected override void InitializeForm()
		{
			base.InitializeForm();
			this.Caption = "ACInput List";
			this.ShowImportButton = FormMain.Instance.HasAddNewPrivilege(ACInputSchema.TableName);
		}

		protected override void DataBinding()
		{
			this.Cursor = Cursors.WaitCursor;
			this._list = ACInput.GetAll();
			this._decorator.DataSource = this._list;
			this.Cursor = Cursors.Default;
		}

		protected override void ProcessImportData(BusinessCollectionBase src, BusinessCollectionBase imported, List<PropertyInfo> columnList)
		{
			ACInputCollection importedList = imported as ACInputCollection;
			if (importedList == null)
				return;

			ACInputCollection srcList = src as ACInputCollection;
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

			SortedList<string, ACInput> srcIndex = new SortedList<string, ACInput>();
			foreach (ACInput item in srcList)
			{
				string aCInputKey = string.Format("{0}:{1}", item.UnitID, item.PanelZoneID);
				if (srcIndex.ContainsKey(aCInputKey))
					continue;

				srcIndex.Add(aCInputKey, item);
			}

			foreach (ACInput item in importedList)
			{
				string aCInputKey = string.Format("{0}:{1}", item.UnitID, item.PanelZoneID);
				if (!srcIndex.ContainsKey(aCInputKey))
				{
					//ACPanel
					string aCPanelKey = string.Format("{0}", item.UnitID);
					if(aCPanelIndex.ContainsKey(aCPanelKey))
					{
						item.ACPanel = aCPanelIndex[aCPanelKey];
					}

					srcIndex.Add(aCInputKey, item);
					srcList.Add(item);
				}
				else
				{
					ACInput srcEntity = srcIndex[aCInputKey];

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
