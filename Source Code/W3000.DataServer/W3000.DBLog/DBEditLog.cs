using System;
using System.Configuration;
using System.Data;
using Cheke;
using Cheke.BusinessEntity;
using Cheke.BusinessService;
using W3000.CRUD;
using W3000.Data;
using W3000.Schema;
using W3000.Utils;

namespace W3000.DBLog
{
    public class DBEditLog : IDBEditLog
    {
        #region IDBEditLog Members

        public bool IsLogInsertEnabled
        {
            get { return true; }
        }

        public int LogInsert(BusinessBase entity, SecurityToken token)
        {
            if (this.IsLogTable(entity.TableName))
                return 1;

            LogDBEditActivityData log = this.CreateEditLog(entity, token.UserId, "Insert");
            return this.GetEditDAL(DateTime.Now).Insert(log);
        }


        public bool IsLogUpdateEnabled
        {
            get { return true; }
        }

        public int LogUpdate(BusinessBase entity, SecurityToken token)
        {
            if (this.IsLogTable(entity.TableName))
                return 1;

            LogDBEditActivityData log = this.CreateEditLog(entity, token.UserId, "Update");
            return this.GetEditDAL(DateTime.Now).Insert(log);
        }

        private LogDBEditActivityData CreateEditLog(BusinessBase entity, string userid, string action)
        {
            LogDBEditActivityData log = new LogDBEditActivityData();

            log.LogDateTime = DateTime.Now;
            log.DBTableName = entity.TableName;
            log.Category = action;
            log.RecordPK = new Guid(entity.PKString);
            log.RecordDetail = entity.Serialize();
            log.CreatedOn = DateTime.Now;
            log.CreatedBy = userid;
            log.ModifiedOn = DateTime.Now;
            log.ModifiedBy = userid;

            return log;
        }

        private LogDBEditActivityCRUD GetEditDAL(DateTime date)
        {
            LogDBEditActivityCRUD dal = new LogDBEditActivityCRUD(ConfigurationManager.AppSettings["DB:W3000"]);
            dal.TableName = HelperLog.GetSplitByMonthTable(LogDBEditActivitySchema.TableName, date.Year, date.Month);
            return dal;
        }

        #endregion

        #region IDBDeleteLog Members

        public bool IsLogDeleteEnabled
        {
            get { return true; }
        }

        public int LogDelete(BusinessBase entity, SecurityToken token)
        {
            DateTime now = DateTime.Now;
            if (this.IsLogTable(entity.TableName))
                return 1;

            LogDBDeleteActivityData log = new LogDBDeleteActivityData();
            log.LogDateTime = now;
            log.DBTableName = entity.TableName;
            log.RecordPK = new Guid(entity.PKString);
            log.LastUpdated = entity.ModifiedOn;
            log.CreatedOn = now;
            log.CreatedBy = token.UserId;
            log.ModifiedOn = now;
            log.ModifiedBy = token.UserId;
            return this.GetDeleteDAL(now).Insert(log);
        }

        public int LogDelete(DataTable table, SecurityToken token)
        {
            if (this.IsLogTable(table.TableName))
                return 1;

            if(table.Columns.Count < 2)
                return 1;

            foreach (DataRow row in table.Rows)
            {
                var recordPK = new Guid(row[0].ToString());
                var lastUpdate = DateTime.Parse(row[1].ToString());

                LogDBDeleteActivityData log = new LogDBDeleteActivityData();
                log.LogDateTime = DateTime.Now;
                log.DBTableName = table.TableName;
                log.RecordPK = recordPK;
                log.LastUpdated = lastUpdate;
                log.CreatedOn = DateTime.Now;
                log.CreatedBy = token.UserId;
                log.ModifiedOn = DateTime.Now;
                log.ModifiedBy = token.UserId;

                int ret = this.GetDeleteDAL(DateTime.Now).Insert(log);
                if (ret != 1)
                {
                    throw new DBConcurrencyException(string.Format("Loging deleted data failed({0}).", table.TableName));
                }
            }

            return 1;
        }

        private LogDBDeleteActivityCRUD GetDeleteDAL(DateTime date)
        {
            LogDBDeleteActivityCRUD dal = new LogDBDeleteActivityCRUD(ConfigurationManager.AppSettings["DB:W3000"]);
            dal.TableName = HelperLog.GetSplitByYearTable(LogDBDeleteActivitySchema.TableName, date.Year);
            return dal;
        }

        #endregion

        #region Helper functions
        private bool IsLogTable(string tableName)
        {
            if (tableName.StartsWith("Log"))
                return true;

            return false;
        }
        #endregion
    }
}
