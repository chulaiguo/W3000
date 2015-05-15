using System;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using Cheke;
using W3000.CRUD;
using W3000.Data;
using W3000.Schema;

namespace W3000.DataService
{
	public partial class UsrAccountDataService
	{
        public UsrAccountDataCollection GetByUsrGroupName(string UsrGroupName)
        {
            string sql = string.Format(" WHERE [{0}].[{1}] IN (SELECT [{2}] FROM [{3}] WHERE [{4}] = @{4})",
              UsrAccountSchema.TableAlias, UsrAccountSchema.UsrGroupPK,
              UsrGroupSchema.UsrGroupPK, UsrGroupSchema.TableName, UsrGroupSchema.UsrGroupName);

            SqlParameter[] paras = new SqlParameter[1];
            paras[0] = new SqlParameter(string.Format("@{0}", UsrGroupSchema.UsrGroupName), SqlDbType.VarChar);
            paras[0].Value = UsrGroupName;

            return this.GetCollection(sql, paras);
        }

        public UsrAccountDataCollection GetCentralUser()
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendFormat(" WHERE [{0}].[{1}] = @{1}",
              UsrAccountSchema.TableAlias, UsrAccountSchema.IsCentral);

            SqlParameter[] paras = new SqlParameter[1];
            paras[0] = new SqlParameter(string.Format("@{0}", UsrAccountSchema.IsCentral), SqlDbType.Bit);
            paras[0].Value = true;
          
            return this.GetCollection(builder.ToString(), paras);
        }

        public UsrAccountDataCollection GetWebUser()
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendFormat(" WHERE [{0}].[{1}] = @{1}",
              UsrAccountSchema.TableAlias, UsrAccountSchema.IsCentral);

            SqlParameter[] paras = new SqlParameter[1];
            paras[0] = new SqlParameter(string.Format("@{0}", UsrAccountSchema.IsCentral), SqlDbType.Bit);
            paras[0].Value = false;

            return this.GetCollection(builder.ToString(), paras);
        }

        public UsrAccountDataCollection GetByModifiedOn(bool IsCentral, DateTime begin, DateTime end)
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendFormat(" WHERE [{0}].[{1}] = @{1}",
              UsrAccountSchema.TableAlias, UsrAccountSchema.IsCentral);

            builder.AppendFormat(" AND [{0}].[{1}] >= @Min{1} AND [{0}].[{1}] <= @Max{1}",
                UsrAccountSchema.TableAlias, UsrAccountSchema.ModifiedOn);

            SqlParameter[] paras = new SqlParameter[3];
            paras[0] = new SqlParameter(string.Format("@{0}", UsrAccountSchema.IsCentral), SqlDbType.Bit);
            paras[0].Value = IsCentral;
            paras[1] = new SqlParameter(string.Format("@Min{0}", UsrAccountSchema.ModifiedOn), SqlDbType.DateTime);
            paras[1].Value = begin;
            paras[2] = new SqlParameter(string.Format("@Max{0}", UsrAccountSchema.ModifiedOn), SqlDbType.DateTime);
            paras[2].Value = end;

            this._dal.ClearSortBy();
            this._dal.AddSortBy(UsrAccountSchema.ModifiedOn, true);
            return this.GetCollection(builder.ToString(), paras);
        }

    

        internal static bool HasBRPermission(UsrAccountData user, int ruleID, SecurityToken token)
        {
            UsrAccountBRRuleDataService userSvr = DataServiceFactory.CreateUsrAccountBRRuleDataService(token, true);
            UsrAccountBRRuleData userRule = userSvr.GetByBRRuleID(ruleID, user.UsrAccountPK);
            if (userRule != null)
            {
                return !userRule.Denied;
            }

            UsrGroupBRRuleDataService groupSvr = DataServiceFactory.CreateUsrGroupBRRuleDataService(token, true);
            UsrGroupBRRuleData groupRule = groupSvr.GetByBRRuleID(ruleID, user.UsrGroupPK);
            if (groupRule != null)
            {
                return !groupRule.Denied;
            }

            return false;
        }

        public bool IsTableExist(string tableName)
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

        public string ExecuteNonQuery(string sql)
        {
            try
            {
                int ret = this._dal.ExecuteNonQuery(sql, null);
                return ret.ToString();
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public string ExecuteScalar(string sql)
        {
            try
            {
                object ret = this._dal.ExecuteScalar(sql, null);
                return ret.ToString();
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public DataTable ExecuteDataTable(string sql)
        {
            DataTable table;
            try
            {
                table = this._dal.ExecuteDataTable(sql, null);
            }
            catch (Exception ex)
            {
                table = new DataTable("Exception");
                table.Columns.Add("Message", typeof(string));

                DataRow row = table.NewRow();
                row[0] = ex.Message;
                table.Rows.Add(row);
            }

            return table;
        }

        internal static UsrAccountData GetByUserID(String userID, string connectionString)
        {
            string sqlUserID = string.Format(" WHERE  [{0}].[{1}] = @{1}", UsrAccountSchema.TableAlias, UsrAccountSchema.UserID);

            SqlParameter[] paras = new SqlParameter[1];
            paras[0] = new SqlParameter(string.Format("@{0}", UsrAccountSchema.UserID), SqlDbType.VarChar);
            paras[0].Value = userID;

            UsrAccountCRUD dal = new UsrAccountCRUD(connectionString);
            return dal.GetEntityBy(sqlUserID, paras);
        }
	}
}
