using System;
using System.Data;
using System.Data.SqlClient;
using W3000.Data;
using W3000.Schema;

namespace W3000.DataService
{
    public partial class UsrGroupBRRuleDataService
    {
        public UsrGroupBRRuleData GetByBRRuleID(int BRRuleID, string UsrGroupName)
        {
            string sqlBRRuleID = string.Format(" WHERE [{0}].[{1}] = @{1}",
              UsrGroupBRRuleSchema.TableAlias, UsrGroupBRRuleSchema.BRRuleID);

            string sqlUserID = string.Format(" AND [{0}].[{1}] IN (SELECT [{2}] FROM [{3}] WHERE [{4}] = @{4})",
              UsrGroupBRRuleSchema.TableAlias, UsrGroupBRRuleSchema.UsrGroupPK,
              UsrGroupSchema.UsrGroupPK, UsrGroupSchema.TableName, UsrGroupSchema.UsrGroupName);

            SqlParameter[] paras = new SqlParameter[2];
            paras[0] = new SqlParameter(string.Format("@{0}", UsrGroupBRRuleSchema.BRRuleID), SqlDbType.Int);
            paras[0].Value = BRRuleID;
            paras[1] = new SqlParameter(string.Format("@{0}", UsrGroupSchema.UsrGroupName), SqlDbType.VarChar);
            paras[1].Value = UsrGroupName;

            return this.GetEntity(sqlBRRuleID + sqlUserID, paras);
        }

        public UsrGroupBRRuleData GetByBRRuleID(int BRRuleID, Guid UsrGroupPK)
        {
            string sql = string.Format(" WHERE [{0}].[{1}] = @{1} AND [{0}].[{2}] = @{2}",
              UsrGroupBRRuleSchema.TableAlias, UsrGroupBRRuleSchema.BRRuleID, UsrGroupBRRuleSchema.UsrGroupPK);

            SqlParameter[] paras = new SqlParameter[2];
            paras[0] = new SqlParameter(string.Format("@{0}", UsrGroupBRRuleSchema.BRRuleID), SqlDbType.Int);
            paras[0].Value = BRRuleID;
            paras[1] = new SqlParameter(string.Format("@{0}", UsrGroupBRRuleSchema.UsrGroupPK), SqlDbType.UniqueIdentifier);
            paras[1].Value = UsrGroupPK;

            return this.GetEntity(sql, paras);
        }
    }
}
