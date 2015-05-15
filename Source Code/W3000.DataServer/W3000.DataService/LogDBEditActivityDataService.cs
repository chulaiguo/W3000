using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using W3000.Data;
using W3000.DataService.SplitTable;
using W3000.Schema;
using W3000.Utils;

namespace W3000.DataService
{
	public partial class LogDBEditActivityDataService
	{
        public override LogDBEditActivityData GetByPK(Guid aCHistoryPK)
        {
            throw new NotSupportedException("The operation is NOT supported by D3000.");
        }

        public override LogDBEditActivityDataCollection GetAll()
        {
            throw new NotSupportedException("The operation is NOT supported by D3000.");
        }

        private bool IsTableExist(string tableName)
        {
            string sql = string.Format("SELECT COUNT(*) FROM Information_Schema.Tables where TABLE_NAME='{0}'", tableName);
            object obj = this._dal.ExecuteScalar(sql, null);
            if (obj == null)
                return false;

            int count;
            if (!int.TryParse(obj.ToString(), out count))
            {
                return false;
            }

            return count > 0;
        }

        public LogDBEditActivityDataCollection GetByLogDateTime(DateTime begin, DateTime end)
        {
            LogDBEditActivityQuery query = new LogDBEditActivityQuery(base.SecurityToken, this._dal, begin, end);
            return query.GetBySqlWhere(string.Empty, null);
        }

        public LogDBEditActivityDataCollection GetByLogDateTime(DateTime begin, DateTime end, Guid recordPK)
        {
            string sql = string.Format(" [{0}].[{1}] = @{1} ",
               LogDBEditActivitySchema.TableAlias, LogDBEditActivitySchema.RecordPK);

            SqlParameter[] paras = new SqlParameter[1];
            paras[0] = new SqlParameter(string.Format("@{0}", LogDBEditActivitySchema.RecordPK), SqlDbType.UniqueIdentifier);
            paras[0].Value = recordPK;

            LogDBEditActivityQuery query = new LogDBEditActivityQuery(base.SecurityToken, this._dal, begin, end);
            return query.GetBySqlWhere(sql, paras);
        }

        public LogDBEditActivityDataCollection GetByLogDateTime(DateTime begin, DateTime end, string tableName)
        {
            string sql = string.Format(" [{0}].[{1}] = @{1} ",
               LogDBEditActivitySchema.TableAlias, LogDBEditActivitySchema.DBTableName);

            SqlParameter[] paras = new SqlParameter[1];
            paras[0] = new SqlParameter(string.Format("@{0}", LogDBEditActivitySchema.DBTableName), SqlDbType.VarChar);
            paras[0].Value = tableName;

            LogDBEditActivityQuery query = new LogDBEditActivityQuery(base.SecurityToken, this._dal, begin, end);
            return query.GetBySqlWhere(sql, paras);
        }

        public LogDBEditActivityDataCollection GetByDeleteRecords(DateTime begin, DateTime end, string tableName)
        {
            LogDBDeleteActivityDataService svr = DataServiceFactory.CreateLogDBDeleteActivityDataService(base.TrustedToken, true);
            LogDBDeleteActivityDataCollection list = svr.GetByLogDateTime(begin, end, tableName);

            LogDBEditActivityDataCollection retList = new LogDBEditActivityDataCollection();
            foreach (LogDBDeleteActivityData item in list)
            {
                LogDBEditActivityData entity = this.GetDeletedRecord(item.LastUpdated, item.RecordPK);
                if (entity != null)
                {
                    entity.LogDateTime = item.LogDateTime;
                    entity.ModifiedBy = item.ModifiedBy;
                    entity.AcceptChanges();
                    retList.Add(entity);
                }
            }

            return retList;
        }

        public LogDBEditActivityData GetDeletedRecord(DateTime lastUpdated, Guid recordPK)
        {
            string sql = string.Format(" WHERE  [{0}].[{1}] = @{1} ",
               LogDBEditActivitySchema.TableAlias, LogDBEditActivitySchema.RecordPK);

            SqlParameter[] paras = new SqlParameter[1];
            paras[0] = new SqlParameter(string.Format("@{0}", LogDBEditActivitySchema.RecordPK), SqlDbType.UniqueIdentifier);
            paras[0].Value = recordPK;

            string tableName = HelperLog.GetSplitByMonthTable(LogDBEditActivitySchema.TableName, lastUpdated.Year, lastUpdated.Month);
            if (!this.IsTableExist(tableName))
                return null;

            this._dal.TableName = tableName;
            this._dal.ClearSortBy();

            return this._dal.GetEntityBy(sql, paras);
        }
    }
}
