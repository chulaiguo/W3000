using System;
using System.Collections;
using System.Collections.Generic;
using System.Windows.Forms;
using Cheke;
using Cheke.BusinessEntity;
using Cheke.WinCtrl;
using Cheke.WinCtrl.Decoration;
using W3000.ViewObj;
using DevExpress.Utils;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;

namespace W3000.Manager.FormLog
{
    public partial class FormEditHistory : FormBase
    {
        private readonly GridControlDecorator _decorator = null;
        private readonly DateTime _from = DateTime.MinValue;
        private readonly DateTime _to = DateTime.MinValue;

        private BusinessBase _entity = null;
        private GridControlDecorator _decoratorHistory = null;

        public FormEditHistory()
        {
            InitializeComponent();
        }

        public FormEditHistory(GridControlDecorator decorator, DateTime from, DateTime to)
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

            this._entity = view.GetRow(view.FocusedRowHandle) as BusinessBase;
            if (this._entity == null)
                return;

            this._decoratorHistory = LogHelper.CreateDecorator(base.UserId, this._entity.TableName, this.gridControl1);
            if (this._decoratorHistory == null)
                return;

            this._decoratorHistory.Initialize();
            this._decoratorHistory.Editable = false;
            this._decoratorHistory.IsHistoryView = true;
            this._decoratorHistory.MenuController.MenuOptions.ShowHistoryMenu = false;
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
            colModifiedOn.Caption = "ModifiedOn";
            colModifiedOn.FieldName = "ModifiedOn";
            colModifiedOn.VisibleIndex = this.gridView1.Columns.Count;
            colModifiedOn.Width = 120;
            colModifiedOn.DisplayFormat.FormatType = FormatType.DateTime;
            colModifiedOn.DisplayFormat.FormatString = "MM/dd/yyyy HH:mm:ss";
            this.gridView1.Columns.Add(colModifiedOn);

            GridColumn colModifiedBy = new GridColumn();
            colModifiedBy.Caption = "ModifiedBy";
            colModifiedBy.FieldName = "ModifiedBy";
            colModifiedBy.VisibleIndex = this.gridView1.Columns.Count;
            this.gridView1.Columns.Add(colModifiedBy);

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
            LogDBEditActivityCollection list = LogDBEditActivity.GetByLogDateTime(this._from, this._to, new Guid(this._entity.PKString), token);
            if (list.Count == 0)
                return;

            BusinessCollectionBase dataSource = LogHelper.Log2BusinessCollection(this._entity.TableName, list);
            dataSource.AcceptChanges();
            this._decoratorHistory.DataSource = dataSource;
            this.btnRollback.Enabled = true;
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

            BusinessBase data = Rollback(entity);
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

        internal static BusinessBase Rollback(BusinessBase entity)
        {
            BusinessBase newEntity = LogHelper.GetEntityFromDB(entity);
            if (newEntity == null)
                return null;

            entity.RowVersion = newEntity.RowVersion;
            entity.AcceptChanges();
            entity.MarkDirty();

            return entity;
        }
    }
}