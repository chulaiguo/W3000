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
	public partial class FormWorkUsrAccountList : FormWorkListBase
	{
		private UsrAccountCollection _list = null;
		private GridUsrAccountDecorator _decorator = null;

		public FormWorkUsrAccountList()
		{
			InitializeComponent();
		}

		public FormWorkUsrAccountList(string userid, Control parent)
			: base(userid, parent)
		{
			InitializeComponent();
		}

		protected override void InitializeDecorator()
		{
			this._decorator = new GridUsrAccountDecorator(base.UserId, this.gridControl1);
			this._decorator.Initialize();
		}

		protected override void InitializeForm()
		{
			base.InitializeForm();
			this.Caption = "UsrAccount List";
			this.ShowImportButton = FormMain.Instance.HasAddNewPrivilege(UsrAccountSchema.TableName);
		}

		protected override void DataBinding()
		{
			this.Cursor = Cursors.WaitCursor;
			this._list = UsrAccount.GetAll();
			this._decorator.DataSource = this._list;
			this.Cursor = Cursors.Default;
		}
	}
}
