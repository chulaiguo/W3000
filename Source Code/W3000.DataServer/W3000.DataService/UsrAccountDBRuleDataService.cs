using System;
using System.Data;
using System.Data.SqlClient;
using Cheke;
using W3000.CRUD;
using W3000.Data;
using W3000.Schema;
using W3000.Utils;

namespace W3000.DataService
{
    public partial class UsrAccountDBRuleDataService
    {
        internal static bool CanViewTable(SecurityToken token, string tableName, string connectionString)
        {
            if (token.IsAnonymous || token.IsTrusted)
                return true;

            UsrAccountData user = token.UserAccount as UsrAccountData;
            if (user == null)
                return false;

            DBRuleConstant rule = DBRuleConstant.FindByTableName(tableName);
            if (rule == null)
                return false;

            if (CanViewTableByUser(user.UsrAccountPK, rule.ID, connectionString))
                return true;

            if (CanViewTableByUserGroup(user.UsrGroupPK, rule.ID, connectionString))
                return true;

            return false;
        }

        private static bool CanViewTableByUser(Guid UsrAccountPK, int DBRuleID, string connectionString)
        {
            if (UsrAccountPK == Guid.Empty)
                return false;

            string sql = string.Format(
                "SELECT COUNT(*) FROM [{0}] WHERE [{1}] = @{1} AND [{2}] = @{2} AND [{3}] = @{3}",
                UsrAccountDBRuleSchema.TableName, UsrAccountDBRuleSchema.UsrAccountPK,
                UsrAccountDBRuleSchema.DBRuleID, UsrAccountDBRuleSchema.Selectable);

            SqlParameter[] paras = new SqlParameter[3];
            paras[0] = new SqlParameter(string.Format("@{0}", UsrAccountDBRuleSchema.UsrAccountPK), SqlDbType.UniqueIdentifier);
            paras[0].Value = UsrAccountPK;
            paras[1] = new SqlParameter(string.Format("@{0}", UsrAccountDBRuleSchema.DBRuleID), SqlDbType.Int);
            paras[1].Value = DBRuleID;
            paras[2] = new SqlParameter(string.Format("@{0}", UsrAccountDBRuleSchema.Selectable), SqlDbType.Bit);
            paras[2].Value = true;

            UsrAccountDBRuleCRUD dal = new UsrAccountDBRuleCRUD(connectionString);
            object obj = dal.ExecuteScalar(sql, paras);
            if (obj == null)
                return false;

            return obj.ToString() != "0";
        }

        private static bool CanViewTableByUserGroup(Guid UsrGroupPK, int DBRuleID, string connectionString)
        {
            if (UsrGroupPK == Guid.Empty)
                return false;

            string sql = string.Format(
                "SELECT COUNT(*) FROM [{0}] WHERE [{1}] = @{1} AND [{2}] = @{2} AND [{3}] = @{3}",
                UsrGroupDBRuleSchema.TableName, UsrGroupDBRuleSchema.UsrGroupPK,
                UsrGroupDBRuleSchema.DBRuleID, UsrGroupDBRuleSchema.Selectable);

            SqlParameter[] paras = new SqlParameter[3];
            paras[0] = new SqlParameter(string.Format("@{0}", UsrGroupDBRuleSchema.UsrGroupPK), SqlDbType.UniqueIdentifier);
            paras[0].Value = UsrGroupPK;
            paras[1] = new SqlParameter(string.Format("@{0}", UsrGroupDBRuleSchema.DBRuleID), SqlDbType.Int);
            paras[1].Value = DBRuleID;
            paras[2] = new SqlParameter(string.Format("@{0}", UsrGroupDBRuleSchema.Selectable), SqlDbType.Bit);
            paras[2].Value = true;

            UsrGroupDBRuleCRUD dal = new UsrGroupDBRuleCRUD(connectionString);
            object obj = dal.ExecuteScalar(sql, paras);
            if (obj == null)
                return false;

            return obj.ToString() != "0";
        }
    }
}
