using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using Cheke;
using W3000.CRUD;
using W3000.Data;
using W3000.Schema;
using W3000.Utils;

namespace W3000.DataService.SplitTable
{
    internal class LogDBDeleteActivityQuery
    {
        private static readonly DateTime _BeginDate = new DateTime(2010, 1, 1, 0, 0, 0);

        private readonly SecurityToken _token = null;
        private readonly LogDBDeleteActivityCRUD _dal = null;
        private readonly DateTime _begin = DateTime.Now;
        private readonly DateTime _end = DateTime.Now;

        public LogDBDeleteActivityQuery(SecurityToken token, LogDBDeleteActivityCRUD dal, DateTime begin, DateTime end)
        {
            this._token = token;
            this._dal = dal;

            if (end > DateTime.Now)
                end = DateTime.Now;

            if (begin < _BeginDate)
                begin = _BeginDate;

            if (begin > end)
                begin = end;

            this._begin = begin;
            this._end = end;
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

        public LogDBDeleteActivityDataCollection GetBySqlWhere(string sqlWhere, SqlParameter[] paras)
        {
            int pageIndex = this._token.BlockIndex;
            int pageSize = this._token.BlockSize;
            
            return this.GetBySqlWhere(sqlWhere, paras, pageIndex, pageSize);
        }

        public LogDBDeleteActivityDataCollection GetBySqlWhere(string where, SqlParameter[] paras, int pageIndex, int pageSize)
        {
            if (pageIndex == -1)
            {
                pageIndex = 0;
                pageSize = 100000;
            }

            //sql
            List<SqlParameter> paraList = new List<SqlParameter>();
            string sqlWhere = this.GetSqlWhere(where, paraList);
            if (paras != null)
            {
                foreach (SqlParameter item in paras)
                {
                    paraList.Add(item);
                }
            }

            string sqlOrderBy = this.GetOrderBySql();

            Guid sessionID = this._token.TokenID;
            LogRowsCountDataService logBufferSvr = DataServiceFactory.CreateLogRowsCountDataService(this._token, true);
            LogRowsCountDataCollection logBufferList = logBufferSvr.GetBySessionID(sessionID);
            if (logBufferList.Count == 0)
            {
                this.InsertLogRowsCount(sessionID, sqlWhere, paraList);

                logBufferSvr = DataServiceFactory.CreateLogRowsCountDataService(this._token, true);
                logBufferList = logBufferSvr.GetBySessionID(sessionID);
            }

            LogDBDeleteActivityDataCollection retList = new LogDBDeleteActivityDataCollection();
            SortedList<string, LogRange> index = LogHelper.GetLogTables(logBufferList, pageIndex, pageSize);
            foreach (KeyValuePair<string, LogRange> pair in index)
            {
                StringBuilder builder = new StringBuilder();
                builder.Append("SELECT * FROM ( ");
                builder.AppendFormat("SELECT ROW_NUMBER() OVER({0}) as rowid, * FROM [{1}] as [{2}] WHERE {3} ",
                    sqlOrderBy, pair.Key, LogDBDeleteActivitySchema.TableAlias, sqlWhere);
                builder.Append(") T ");
                builder.AppendFormat("WHERE rowid BETWEEN {0} AND {1}", pair.Value.Begin, pair.Value.End);

                LogDBDeleteActivityCRUD crud = new LogDBDeleteActivityCRUD(this._dal.ConnectionString);
                retList.AddRange(crud.GetCollectionExBy(builder.ToString(), paraList.ToArray()));
            }

            //total count
            int totalCount = 0;
            foreach (LogRowsCountData item in logBufferList)
            {
                totalCount += item.RowsCount;
            }

            retList.Block.Index = pageIndex;
            retList.Block.Size = pageSize;
            if (retList.Count < pageSize)
            {
                retList.Block.Count = 1;
                retList.Block.Records = retList.Count;
            }
            else
            {
                retList.Block.Records = totalCount;

                int pageCount = (totalCount / pageSize) + (totalCount % pageSize == 0 ? 0 : 1);
                retList.Block.Count = pageCount;
            }

            return retList;
        }

        private void InsertLogRowsCount(Guid sessionID, string sqlWhere, List<SqlParameter> paraList)
        {
            int index = 0;
            SortedList<DateTime, DateTime> dateIndex = HelperLog.SplitByYear(this._begin, this._end);
            foreach (KeyValuePair<DateTime, DateTime> item in dateIndex)
            {
                string tableName = HelperLog.GetSplitByYearTable(LogDBDeleteActivitySchema.TableName, item.Key.Year);
                if (!this.IsTableExist(tableName))
                    continue;

                index++;
                int count = this.GetSelectCount(tableName, sqlWhere, paraList.ToArray());

                LogRowsCountData data = new LogRowsCountData();
                data.SessionID = sessionID;
                data.SessionDateTime = DateTime.Now;
                data.DBTableName = tableName;
                data.SequenceID = index;
                data.RowsCount = count;
                data.CreatedBy = this._token.UserId;
                data.CreatedOn = DateTime.Now;
                data.ModifiedBy = this._token.UserId;
                data.ModifiedOn = DateTime.Now;
                LogRowsCountCRUD logCRUD = new LogRowsCountCRUD(this._dal.ConnectionString);
                logCRUD.Insert(data);
            }
        }

        private int GetSelectCount(string tableName, string sqlWhere, SqlParameter[] paras)
        {
            string sql = string.Format("SELECT COUNT(*) FROM {0} as {1} WHERE {2}",
                 tableName, LogDBDeleteActivitySchema.TableAlias, sqlWhere);

            LogDBDeleteActivityCRUD crud = new LogDBDeleteActivityCRUD(this._dal.ConnectionString);
            object obj = crud.ExecuteScalar(sql, paras);
            if (obj == null)
                return 0;

            int count;
            if (!int.TryParse(obj.ToString(), out count))
            {
                return 0;
            }

            return count;
        }


        private string GetSqlWhere(string where, List<SqlParameter> paraList)
        {
            StringBuilder builder = new StringBuilder();
            string sqlDateTime = this.GetByDateTimeSql(this._begin, this._end, paraList);
            builder.Append(sqlDateTime);
            if (!string.IsNullOrEmpty(where))
            {
                builder.AppendFormat(" AND {0}", where);
            }

            return builder.ToString();
        }

        private string GetOrderBySql()
        {
            StringBuilder builder = new StringBuilder();
            builder.Append("ORDER BY ");
            SortFieldCollection list = this._token.GetSortFields();
            if (list.Count > 0)
            {
                int index = list.Count;
                foreach (SortField item in list)
                {
                    index--;

                    if (index <= 0)
                    {
                        builder.AppendFormat("[{0}] {1}", item.FieldAlias, item.ASC ? "ASC" : "DESC");
                    }
                    else
                    {
                        builder.AppendFormat("[{0}] {1}, ", item.FieldAlias, item.ASC ? "ASC" : "DESC");
                    }
                }
            }
            else
            {
                builder.AppendFormat("[{0}] ASC", LogDBDeleteActivitySchema.LogDateTime);
            }

            return builder.ToString();
        }

        private string GetByDateTimeSql(DateTime begin, DateTime end, List<SqlParameter> paraList)
        {
            string sql = string.Format(" [{0}].[{1}] >= @Min{1} AND [{0}].[{1}] <= @Max{1} ",
                LogDBDeleteActivitySchema.TableAlias, LogDBDeleteActivitySchema.LogDateTime);

            SqlParameter para = new SqlParameter(string.Format("@Min{0}", LogDBDeleteActivitySchema.LogDateTime), SqlDbType.DateTime);
            para.Value = begin;
            paraList.Add(para);

            para = new SqlParameter(string.Format("@Max{0}", LogDBDeleteActivitySchema.LogDateTime), SqlDbType.DateTime);
            para.Value = end;
            paraList.Add(para);

            return sql;
        }
    }
}
