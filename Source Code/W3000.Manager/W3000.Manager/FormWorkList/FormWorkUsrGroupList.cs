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
	public partial class FormWorkUsrGroupList : FormWorkListBase
	{
		private UsrGroupCollection _list = null;
		private GridUsrGroupDecorator _decorator = null;

		public FormWorkUsrGroupList()
		{
			InitializeComponent();
		}

		public FormWorkUsrGroupList(string userid, Control parent)
			: base(userid, parent)
		{
			InitializeComponent();
		}

		protected override void InitializeDecorator()
		{
			this._decorator = new GridUsrGroupDecorator(base.UserId, this.gridControl1);
			this._decorator.Initialize();
		}

		protected override void InitializeForm()
		{
			base.InitializeForm();
			this.Caption = "UsrGroup List";
			this.ShowImportButton = FormMain.Instance.HasAddNewPrivilege(UsrGroupSchema.TableName);
		}

		protected override void DataBinding()
		{
			this.Cursor = Cursors.WaitCursor;
			this._list = UsrGroup.GetAll();
			this._decorator.DataSource = this._list;
			this.Cursor = Cursors.Default;
		}

		protected override void ProcessImportData(BusinessCollectionBase src, BusinessCollectionBase imported, List<PropertyInfo> columnList)
		{
			UsrGroupCollection importedList = imported as UsrGroupCollection;
			if (importedList == null)
				return;

			UsrGroupCollection srcList = src as UsrGroupCollection;
			if (srcList == null)
				return;

			SortedList<string, UsrGroup> srcIndex = new SortedList<string, UsrGroup>();
			foreach (UsrGroup item in srcList)
			{
				string usrGroupKey = string.Format("{0}", item.UsrGroupName);
				if (srcIndex.ContainsKey(usrGroupKey))
					continue;

				srcIndex.Add(usrGroupKey, item);
			}

			foreach (UsrGroup item in importedList)
			{
				string usrGroupKey = string.Format("{0}", item.UsrGroupName);
				if (!srcIndex.ContainsKey(usrGroupKey))
				{
					srcIndex.Add(usrGroupKey, item);
					srcList.Add(item);
				}
				else
				{
					UsrGroup srcEntity = srcIndex[usrGroupKey];

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
