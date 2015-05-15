using System;
using System.Data;
using System.Data.SqlClient;
using W3000.Data;
using W3000.DataService.SplitTable;
using W3000.Schema;
using W3000.Utils;

namespace W3000.DataService
{
	public partial class LogDBDeleteActivityDataService
	{
        public override LogDBDeleteActivityData GetByPK(Guid aCHistoryPK)
        {
            throw new NotSupportedException("The operation is NOT supported by D3000.");
        }

        public override LogDBDeleteActivityDataCollection GetAll()
        {
            throw new NotSupportedException("The operation is NOT supported by D3000.");
        }

        public LogDBDeleteActivityDataCollection GetByLogDateTime(DateTime begin, DateTime end)
        {
            LogDBDeleteActivityQuery query = new LogDBDeleteActivityQuery(base.SecurityToken, this._dal, begin, end);
            return query.GetBySqlWhere(string.Empty, null);
        }

        public LogDBDeleteActivityDataCollection GetByLogDateTime(DateTime begin, DateTime end, string tableName)
        {
            string where = string.Format(" WHERE [{0}].[{1}] >= @Min{1} AND [{0}].[{1}] <= @Max{1} AND [{0}].[{2}] = @{2} ",
               LogDBDeleteActivitySchema.TableAlias, LogDBDeleteActivitySchema.LogDateTime,
               LogDBDeleteActivitySchema.DBTableName);

            SqlParameter[] paras = new SqlParameter[3];
            paras[0] = new SqlParameter(string.Format("@Min{0}", LogDBDeleteActivitySchema.LogDateTime), SqlDbType.DateTime);
            paras[0].Value = begin;
            paras[1] = new SqlParameter(string.Format("@Max{0}", LogDBDeleteActivitySchema.LogDateTime), SqlDbType.DateTime);
            paras[1].Value = end;
            paras[2] = new SqlParameter(string.Format("@{0}", LogDBDeleteActivitySchema.DBTableName), SqlDbType.VarChar);
            paras[2].Value = tableName;

            LogDBDeleteActivityDataCollection retList = new LogDBDeleteActivityDataCollection();
            for (int i = begin.Year; i <= end.Year; i++)
            {
                string logTable = HelperLog.GetSplitByYearTable(LogDBDeleteActivitySchema.TableName, i);
                if(!this.IsTableExist(logTable))
                    continue;

                string sql = string.Format("SELECT * FROM [{0}] as [{1}] {2}",
                    logTable, LogDBDeleteActivitySchema.TableAlias, where);

                retList.AddRange(this._dal.GetCollectionExBy(sql, paras));
            }

            return retList;
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
	}
}
