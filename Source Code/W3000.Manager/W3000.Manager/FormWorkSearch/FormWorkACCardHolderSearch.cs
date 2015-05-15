using System;
using System.Windows.Forms;
using Cheke.WinCtrl;
using W3000.Schema;
using W3000.ViewObj;
using W3000.Manager.GridDecorator;

namespace W3000.Manager.FormWorkSearch
{
	public partial class FormWorkACCardHolderSearch : FormWorkSearchBase
	{
		private ACCardHolderCollection _list = null;
		private GridACCardHolderDecorator _decorator = null;

		public FormWorkACCardHolderSearch()
		{
			InitializeComponent();
		}

		public FormWorkACCardHolderSearch(string userId, Control parent)
			: base(userId, parent)
		{
			InitializeComponent();
		}

		protected override void InitializeDecorator()
		{
			this._decorator = new GridACCardHolderDecorator(base.UserId, base.GridControl);
			this._decorator.Initialize();
		}

		protected override void InitializeForm()
		{
			base.InitializeForm();
			this.Caption = "ACCardHolder Search";
			this.ShowImportButton = FormMain.Instance.HasAddNewPrivilege(ACCardHolderSchema.TableName);
		}

		protected override void DataBinding()
		{
			//this._list = ACCardHolder.Search(...);
			this._list = ACCardHolder.GetAll();//for test

			this._decorator.DataSource = this._list;
		}

		private void btnSearch_Click(object sender, EventArgs e)
		{
			base.Search();
		}
	}
}
