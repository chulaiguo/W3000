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
	public partial class FormWorkUtilHolidayList : FormWorkListBase
	{
		private UtilHolidayCollection _list = null;
		private GridUtilHolidayDecorator _decorator = null;

		public FormWorkUtilHolidayList()
		{
			InitializeComponent();
		}

		public FormWorkUtilHolidayList(string userid, Control parent)
			: base(userid, parent)
		{
			InitializeComponent();
		}

		protected override void InitializeDecorator()
		{
			this._decorator = new GridUtilHolidayDecorator(base.UserId, this.gridControl1);
			this._decorator.Initialize();
		}

		protected override void InitializeForm()
		{
			base.InitializeForm();
			this.Caption = "UtilHoliday List";
			this.ShowImportButton = FormMain.Instance.HasAddNewPrivilege(UtilHolidaySchema.TableName);
		}

		protected override void DataBinding()
		{
			this.Cursor = Cursors.WaitCursor;
			this._list = UtilHoliday.GetAll();
			this._decorator.DataSource = this._list;
			this.Cursor = Cursors.Default;
		}

		protected override void ProcessImportData(BusinessCollectionBase src, BusinessCollectionBase imported, List<PropertyInfo> columnList)
		{
			UtilHolidayCollection importedList = imported as UtilHolidayCollection;
			if (importedList == null)
				return;

			UtilHolidayCollection srcList = src as UtilHolidayCollection;
			if (srcList == null)
				return;

			SortedList<string, UtilHoliday> srcIndex = new SortedList<string, UtilHoliday>();
			foreach (UtilHoliday item in srcList)
			{
				string utilHolidayKey = string.Format("{0}:{1}:{2}:{3}", item.CountryID, item.Holiday, item.Date, item.CountryID);
				if (srcIndex.ContainsKey(utilHolidayKey))
					continue;

				srcIndex.Add(utilHolidayKey, item);
			}

			foreach (UtilHoliday item in importedList)
			{
				string utilHolidayKey = string.Format("{0}:{1}:{2}:{3}", item.CountryID, item.Holiday, item.Date, item.CountryID);
				if (!srcIndex.ContainsKey(utilHolidayKey))
				{
					srcIndex.Add(utilHolidayKey, item);
					srcList.Add(item);
				}
				else
				{
					UtilHoliday srcEntity = srcIndex[utilHolidayKey];

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
