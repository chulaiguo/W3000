using System;
using Cheke.WinCtrl;

namespace W3000.Manager.FormMisc
{
    public partial class FormFatalError : FormMiscBase
    {
        private readonly Exception _ex = null;

        public FormFatalError()
        {
            InitializeComponent();
        }

        public FormFatalError(Exception ex)
        {
            InitializeComponent();

            this._ex = ex;
        }

        protected override void InitializeForm()
        {
            base.InitializeForm();

            this.btnReport.Visible = this._ex != null;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            FormSendEmail dlg = new FormSendEmail(FormMain.Instance.UserId, this._ex);
            dlg.ShowDialog();
        }
    }
}