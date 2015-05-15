using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Windows.Forms;
using Cheke;
using Cheke.BusinessEntity;
using Cheke.WinCtrl;
using Cheke.WinCtrl.Decoration;
using W3000.ViewObj;
using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;

namespace W3000.Manager.FormLog
{
    public partial class FormDeleteHistory : FormBase
    {
        private ProgressBarControl _progressBar = null;

        private readonly GridControlDecorator _decorator = null;
        private readonly DateTime _from = DateTime.MinValue;
        private readonly DateTime _to = DateTime.MinValue;

        private string _tableName = string.Empty;
        private GridControlDecorator _decoratorHistory = null;
        private readonly LogDBEditActivityCollection _list = new LogDBEditActivityCollection();

        public FormDeleteHistory()
        {
            InitializeComponent();
        }

        public FormDeleteHistory(GridControlDecorator decorator, DateTime from, DateTime to)
            : base(decorator.UserId)
        {
            InitializeComponent();

            this._decorator = decorator;

            this._from = from;
            this._to = to;
        }

        protected override void InitializeForm()
        {
            base.InitializeForm();

            GridView view = this._decorator.GridControl.FocusedView as GridView;
            if (view == null)
                return;

            BusinessCollectionBase list = view.DataSource as BusinessCollectionBase;
            if (list == null)
                return;

            this._tableName = list.GetItemType().Name;

            this._decoratorHistory = LogHelper.CreateDecorator(base.UserId, this._tableName, this.gridControl1);
            if (this._decoratorHistory == null)
                return;

            this._decoratorHistory.Initialize();
            this.CopyDecoratorParent();
            this._decoratorHistory.Editable = false;
            this._decoratorHistory.IsHistoryView = true;
            this._decoratorHistory.MenuController.MenuOptions.ShowHistoryMenu = false;
            this.gridView1.OptionsSelection.MultiSelect = true;
            this.SetColumns(view);

            this.DataBinding();
        }

        private void SetColumns(GridView view)
        {
            SortedList<int, ArrayList> sortedList = new SortedList<int, ArrayList>();
            foreach (GridColumn item in view.Columns)
            {
                if (!item.OptionsColumn.ShowInCustomizationForm)
                    continue;

                if (!sortedList.ContainsKey(item.VisibleIndex))
                {
                    sortedList.Add(item.VisibleIndex, new ArrayList());
                }

                sortedList[item.VisibleIndex].Add(item);
            }

            this.gridView1.Columns.Clear();
            foreach (KeyValuePair<int, ArrayList> pair in sortedList)
            {
                foreach (object obj in pair.Value)
                {
                    GridColumn srcColumn = obj as GridColumn;
                    if (srcColumn == null)
                        continue;

                    GridColumn col = new GridColumn();
                    col.Caption = srcColumn.Caption;
                    col.FieldName = srcColumn.FieldName;
                    col.Width = srcColumn.Width;
                    col.VisibleIndex = pair.Key;
                    this.gridView1.Columns.Add(col);
                }
            }

            GridColumn colModifiedOn = new GridColumn();
            colModifiedOn.Caption = "DeletedOn";
            colModifiedOn.FieldName = "ModifiedOn";
            colModifiedOn.VisibleIndex = this.gridView1.Columns.Count;
            colModifiedOn.Width = 120;
            colModifiedOn.DisplayFormat.FormatType = FormatType.DateTime;
            colModifiedOn.DisplayFormat.FormatString = "MM/dd/yyyy HH:mm:ss";
            this.gridView1.Columns.Add(colModifiedOn);

            GridColumn colModifiedBy = new GridColumn();
            colModifiedBy.Caption = "DeletedBy";
            colModifiedBy.FieldName = "ModifiedBy";
            colModifiedBy.VisibleIndex = this.gridView1.Columns.Count;
            this.gridView1.Columns.Add(colModifiedBy);
        }

        private void CopyDecoratorParent()
        {
            FieldInfo[] list = this._decorator.GetType().GetFields(BindingFlags.GetField | BindingFlags.NonPublic
                | BindingFlags.Instance | BindingFlags.DeclaredOnly);
            foreach (FieldInfo info in list)
            {
                if (!info.FieldType.IsSubclassOf(typeof(BusinessBase)))
                    continue;

                object obj = info.GetValue(this._decorator);
                if (obj == null)
                    continue;

                info.SetValue(this._decoratorHistory, obj);
            }
        }

        public override void RefrshGridViewData(GridView view)
        {
            this.DataBinding();
        }

        private void DataBinding()
        {
            if (this._decoratorHistory == null)
                return;

            SecurityToken token = SecurityToken.CreatePagesToken(Identity.Token, 0, 1000, Guid.NewGuid());
            LogDBDeleteActivityCollection list = LogDBDeleteActivity.GetByLogDateTime(this._from, this._to, this._tableName, token);
            if (list.Count == 0)
                return;

            this.pnlButtons.Enabled = false;
            if (this._progressBar == null)
            {
                this._progressBar = new ProgressBarControl();
                this.Controls.Add(this._progressBar);
                this._progressBar.Size = new System.Drawing.Size(500, 35);
                int x = (this.Width - this._progressBar.Width) / 2;
                int y = (this.Height - this._progressBar.Height) / 2;
                this._progressBar.Location = new System.Drawing.Point(x, y);
                this._progressBar.Properties.PercentView = true;
                this._progressBar.Properties.ShowTitle = true;
                this._progressBar.BringToFront();
            }

            this._progressBar.Visible = true;
            this._progressBar.EditValue = 0;
            this._progressBar.Properties.Minimum = 0;
            this._progressBar.Properties.Maximum = list.Count;
            this._progressBar.Properties.Step = 1;

            this.backgroundWorker1.RunWorkerAsync(list);          
        }

        private void backgroundWorker1_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            LogDBDeleteActivityCollection list = e.Argument as LogDBDeleteActivityCollection;
            if (list == null)
                return;

            foreach (LogDBDeleteActivity item in list)
            {
                this.backgroundWorker1.ReportProgress(0);

                LogDBEditActivity data = LogDBEditActivity.GetDeletedRecord(item.LastUpdated, item.RecordPK);
                if (data == null)
                    continue;

                data.LogDateTime = item.LogDateTime;
                data.ModifiedBy = item.ModifiedBy;
                data.AcceptChanges();
                this._list.Add(data);
            }
        }

        private void backgroundWorker1_ProgressChanged(object sender, System.ComponentModel.ProgressChangedEventArgs e)
        {
            this._progressBar.PerformStep();
            this._progressBar.Update();
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            this._progressBar.Visible = false;
            this.pnlButtons.Enabled = true;

            BusinessCollectionBase dataSource = LogHelper.Log2BusinessCollection(this._tableName, this._list);
            dataSource.AcceptChanges();

            dataSource = this._decoratorHistory.FilterDeleteEvents(dataSource);
            this._decoratorHistory.DataSource = dataSource;
            this.btnRollback.Enabled = dataSource.Count > 0;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRollback_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes != base.ShowQuestion("Are you sure you want to rollback this record?"))
                return;

            BusinessBase entity = this.gridView1.GetRow(this.gridView1.FocusedRowHandle) as BusinessBase;
            if (entity == null)
                return;

            BusinessBase data = FormEditHistory.Rollback(entity);
            if (data == null)
                return;

            Result result = base.SaveItem(data);
            if (!result.OK)
                return;

            BusinessCollectionBase dataSource = this._decoratorHistory.DataSource as BusinessCollectionBase;
            if (dataSource != null)
            {
                dataSource.Remove(entity);
            }
            base.ShowMessage("The rollback operation has been completed successfully");
        }
    }
}