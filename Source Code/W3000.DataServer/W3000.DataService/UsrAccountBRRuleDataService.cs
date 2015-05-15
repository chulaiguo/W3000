using System;
using System.Data;
using System.Data.SqlClient;
using W3000.Data;
using W3000.Schema;

namespace W3000.DataService
{
    public partial class UsrAccountBRRuleDataService
    {
        public UsrAccountBRRuleData GetByBRRuleID(int BRRuleID, string userID)
        {
            string sqlBRRuleID = string.Format(" WHERE [{0}].[{1}] = @{1}",
              UsrAccountBRRuleSchema.TableAlias, UsrAccountBRRuleSchema.BRRuleID);

            string sqlUserID = string.Format(" AND [{0}].[{1}] IN (SELECT [{2}] FROM [{3}] WHERE [{4}] = @{4})",
              UsrAccountBRRuleSchema.TableAlias, UsrAccountBRRuleSchema.UsrAccountPK,
              UsrAccountSchema.UsrAccountPK, UsrAccountSchema.TableName, UsrAccountSchema.UserID);

            SqlParameter[] paras = new SqlParameter[2];
            paras[0] = new SqlParameter(string.Format("@{0}", UsrAccountBRRuleSchema.BRRuleID), SqlDbType.Int);
            paras[0].Value = BRRuleID;
            paras[1] = new SqlParameter(string.Format("@{0}", UsrAccountSchema.UserID), SqlDbType.VarChar);
            paras[1].Value = userID;

            return this.GetEntity(sqlBRRuleID + sqlUserID, paras);
        }

        public UsrAccountBRRuleData GetByBRRuleID(int BRRuleID, Guid UsrAccountPK)
        {
            string sql = string.Format(" WHERE [{0}].[{1}] = @{1} AND [{0}].[{2}] = @{2}",
              UsrAccountBRRuleSchema.TableAlias, UsrAccountBRRuleSchema.BRRuleID, UsrAccountBRRuleSchema.UsrAccountPK);

            SqlParameter[] paras = new SqlParameter[2];
            paras[0] = new SqlParameter(string.Format("@{0}", UsrAccountBRRuleSchema.BRRuleID), SqlDbType.Int);
            paras[0].Value = BRRuleID;
            paras[1] = new SqlParameter(string.Format("@{0}", UsrAccountBRRuleSchema.UsrAccountPK), SqlDbType.UniqueIdentifier);
            paras[1].Value = UsrAccountPK;

            return this.GetEntity(sql, paras);
        }
    }
}
