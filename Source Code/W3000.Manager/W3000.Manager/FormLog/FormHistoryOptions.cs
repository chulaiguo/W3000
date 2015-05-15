using System;
using Cheke.WinCtrl;
using Cheke.WinCtrl.Decoration;

namespace W3000.Manager.FormLog
{
    public partial class FormHistoryOptions : FormBase
    {
        private readonly bool _isDeleteEvents = false;
        private readonly GridControlDecorator _decorator = null;

        public FormHistoryOptions()
        {
            InitializeComponent();
        }

        public FormHistoryOptions(GridControlDecorator decorator, bool isDeleteEvents)
            : base(decorator.UserId)
        {
            InitializeComponent();

            this._decorator = decorator;
            this._isDeleteEvents = isDeleteEvents;
        }

        protected override void InitializeForm()
        {
            base.InitializeForm();

            DateTime now = FormMain.Instance.Now;
            DateTime begin = now.AddMonths(-1);
            this.dateFrom.DateTime = new DateTime(begin.Year, begin.Month, begin.Day, 0, 0, 0, 0);
            this.dateTo.DateTime = new DateTime(now.Year, now.Month, now.Day, 23, 59, 59, 999);
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            if(!this._isDeleteEvents)
            {
                FormEditHistory dlg = new FormEditHistory(this._decorator, this.dateFrom.DateTime, this.dateTo.DateTime);
                dlg.ShowDialog();
            }
            else
            {
                FormDeleteHistory dlg = new FormDeleteHistory(this._decorator, this.dateFrom.DateTime, this.dateTo.DateTime);
                dlg.ShowDialog();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}