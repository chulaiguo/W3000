using System;
using System.Data;
using System.Data.SqlClient;
using W3000.Data;
using W3000.Schema;

namespace W3000.DataService
{
    public partial class LogRowsCountDataService
    {
        public LogRowsCountDataCollection GetBySessionID(Guid SessionID)
        {
            string sql = string.Format(" WHERE [{0}].[{1}] = @{1}", 
                LogRowsCountSchema.TableAlias, LogRowsCountSchema.SessionID);

            SqlParameter[] paras = new SqlParameter[1];
            paras[0] = new SqlParameter(string.Format("@{0}", LogRowsCountSchema.SessionID), SqlDbType.UniqueIdentifier);
            paras[0].Value = SessionID;
           
            return this.GetCollection(sql, paras);
        }

        public int DeleteBySessionDateTime(DateTime begin, DateTime end)
        {
            string sql = string.Format("DELETE FROM [{0}] WHERE [{1}] >= @Min{1} AND [{1}] <= @Max{1}", 
                LogRowsCountSchema.TableName, LogRowsCountSchema.SessionDateTime);

            SqlParameter[] paras = new SqlParameter[2];
            paras[0] = new SqlParameter(string.Format("@Min{0}", LogRowsCountSchema.SessionDateTime), SqlDbType.DateTime);
            paras[0].Value = begin;
            paras[1] = new SqlParameter(string.Format("@Max{0}", LogRowsCountSchema.SessionDateTime), SqlDbType.DateTime);
            paras[1].Value = end;

            return this._dal.ExecuteNonQuery(sql, paras);
        }
    }
}
