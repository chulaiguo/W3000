using System.Collections;
using System.Configuration;
using Cheke;
using Cheke.BusinessService;
using Cheke.Log;
using W3000.CRUD;
using W3000.Data;
using W3000.Schema;
using W3000.Utils;

namespace W3000.Permission
{
    public sealed class Permission : IPermission
    {
        private static readonly ApplicationLog _SysLog = new ApplicationLog();
        private static readonly string _ConnectionString = ConfigurationManager.AppSettings["DB:W3000"];

        public TablePermission GetPermission(SecurityToken token, string table)
        {
            UsrAccountData admin = token.UserAccount as UsrAccountData;
            if (admin == null)
            {
                _SysLog.WriteDebug("The current user is not a valid user, access denied.");
                return new TablePermission(false, false, false, false);
            }

            if (this.IsLogTable(table))
            {
                return new TablePermission(true, true, true, true);
            }

            if (token.Permissions == null)
            {
                token.Permissions = new Hashtable();

                //personal permission
                UsrAccountDBRuleCRUD dal = new UsrAccountDBRuleCRUD(_ConnectionString);
                UsrAccountDBRuleDataCollection list = dal.GetByUsrAccount(admin.UsrAccountPK);
                foreach (UsrAccountDBRuleData item in list)
                {
                    DBRuleConstant rule = DBRuleConstant.FindByID(item.DBRuleID);
                    if(rule == null)
                        continue;

                    TablePermission entity = new TablePermission(item.Insertable, item.Selectable, item.Editable, item.Deletable);
                    token.Permissions.Add(rule.TableName, entity);
                }

                //group permission
                UsrGroupDBRuleCRUD dalGroup = new UsrGroupDBRuleCRUD(_ConnectionString);
                UsrGroupDBRuleDataCollection listGroup = dalGroup.GetByUsrGroup(admin.UsrGroupPK);
                foreach (UsrGroupDBRuleData item in listGroup)
                {
                    DBRuleConstant rule = DBRuleConstant.FindByID(item.DBRuleID);
                    if (rule == null)
                        continue;

                    if (token.Permissions.ContainsKey(rule.TableName))
                        continue;

                    TablePermission entity = new TablePermission(item.Insertable, item.Selectable, item.Editable, item.Deletable);
                    token.Permissions.Add(rule.TableName, entity);
                }
            }

            TablePermission permission = token.Permissions[table] as TablePermission;
            if (permission == null)
            {
                _SysLog.WriteDebug("The table name is not listed in the permission hashtable, accessed denied.");
                return new TablePermission(false, false, false, false);
            }

            return permission;
        }

        private bool IsLogTable(string tableName)
        {
            if (tableName.StartsWith("Log"))
                return true;

            if (tableName == UtilSettingCategorySchema.TableName
                || tableName == UtilSettingDetailSchema.TableName)
                return true;

            return false;
        }
    }
}