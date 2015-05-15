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
	public partial class FormWorkACMasterCardList : FormWorkListBase
	{
		private ACMasterCardCollection _list = null;
		private GridACMasterCardDecorator _decorator = null;

		public FormWorkACMasterCardList()
		{
			InitializeComponent();
		}

		public FormWorkACMasterCardList(string userid, Control parent)
			: base(userid, parent)
		{
			InitializeComponent();
		}

		protected override void InitializeDecorator()
		{
			this._decorator = new GridACMasterCardDecorator(base.UserId, this.gridControl1);
			this._decorator.Initialize();
		}

		protected override void InitializeForm()
		{
			base.InitializeForm();
			this.Caption = "ACMasterCard List";
			this.ShowImportButton = FormMain.Instance.HasAddNewPrivilege(ACMasterCardSchema.TableName);
		}

		protected override void DataBinding()
		{
			this.Cursor = Cursors.WaitCursor;
			this._list = ACMasterCard.GetAll();
			this._decorator.DataSource = this._list;
			this.Cursor = Cursors.Default;
		}

		protected override void ProcessImportData(BusinessCollectionBase src, BusinessCollectionBase imported, List<PropertyInfo> columnList)
		{
			ACMasterCardCollection importedList = imported as ACMasterCardCollection;
			if (importedList == null)
				return;

			ACMasterCardCollection srcList = src as ACMasterCardCollection;
			if (srcList == null)
				return;

			SortedList<string, ACMasterCard> srcIndex = new SortedList<string, ACMasterCard>();
			foreach (ACMasterCard item in srcList)
			{
				string aCMasterCardKey = string.Format("{0}:{1}:{2}:{3}:{4}:{5}", item.Sitecode, item.Embossed, item.CardTypeID, item.Sitecode, item.Encoded, item.CardTypeID);
				if (srcIndex.ContainsKey(aCMasterCardKey))
					continue;

				srcIndex.Add(aCMasterCardKey, item);
			}

			foreach (ACMasterCard item in importedList)
			{
				string aCMasterCardKey = string.Format("{0}:{1}:{2}:{3}:{4}:{5}", item.Sitecode, item.Embossed, item.CardTypeID, item.Sitecode, item.Encoded, item.CardTypeID);
				if (!srcIndex.ContainsKey(aCMasterCardKey))
				{
					srcIndex.Add(aCMasterCardKey, item);
					srcList.Add(item);
				}
				else
				{
					ACMasterCard srcEntity = srcIndex[aCMasterCardKey];

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
