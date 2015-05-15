using System.Collections.Generic;
using W3000.Utils;
using W3000.ViewObj;

namespace W3000.Manager.Utils
{
    internal class UserPermission
    {
        private readonly UsrAccount _user = null;
        private SortedList<int, DBPermission> _permissionList = null;
        private SortedList<int, BRPermission> _bizPermissionList = null;

        public UserPermission(UsrAccount user)
        {
            this._user = user;
            this.InitPermission();
            this.InitBizPermission();
        }

        private UsrAccount User
        {
            get { return _user; }
        }

        private void InitPermission()
        {
            this._permissionList = new SortedList<int, DBPermission>();

            //personal permission
            UsrAccountDBRuleCollection list = UsrAccountDBRule.GetByUsrAccount(this.User.UsrAccountPK);
            foreach (UsrAccountDBRule item in list)
            {
                if (this._permissionList.ContainsKey(item.DBRuleID))
                    continue;

                DBPermission entity = new DBPermission();
                entity.RuleID = item.DBRuleID;
                entity.Selectable = item.Selectable;
                entity.Editable = item.Editable;
                entity.Insertable = item.Insertable;
                entity.Deletable = item.Deletable;

                this._permissionList.Add(item.DBRuleID, entity);
            }

            //group permission
            UsrGroupDBRuleCollection groupList = UsrGroupDBRule.GetByUsrGroup(this.User.UsrGroupPK);
            foreach (UsrGroupDBRule item in groupList)
            {
                if (this._permissionList.ContainsKey(item.DBRuleID))
                    continue;

                DBPermission entity = new DBPermission();
                entity.RuleID = item.DBRuleID;
                entity.Selectable = item.Selectable;
                entity.Editable = item.Editable;
                entity.Insertable = item.Insertable;
                entity.Deletable = item.Deletable;

                this._permissionList.Add(item.DBRuleID, entity);
            }
        }

        private void InitBizPermission()
        {
            this._bizPermissionList = new SortedList<int, BRPermission>();

            //personal permission
            UsrAccountBRRuleCollection list = UsrAccountBRRule.GetByUsrAccount(this.User.UsrAccountPK);
            foreach (UsrAccountBRRule item in list)
            {
                if (this._bizPermissionList.ContainsKey(item.BRRuleID))
                    continue;

                BRPermission entity = new BRPermission();
                entity.RuleID = item.BRRuleID;
                entity.Denied = item.Denied;
                this._bizPermissionList.Add(item.BRRuleID, entity);
            }

            //group permission
            UsrGroupBRRuleCollection groupList = UsrGroupBRRule.GetByUsrGroup(this.User.UsrGroupPK);
            foreach (UsrGroupBRRule item in groupList)
            {
                if (this._bizPermissionList.ContainsKey(item.BRRuleID))
                    continue;

                BRPermission entity = new BRPermission();
                entity.RuleID = item.BRRuleID;
                entity.Denied = item.Denied;
                this._bizPermissionList.Add(item.BRRuleID, entity);
            }
        }

        public bool IsSupervisor
        {
            get
            {
                if (this.User.IsAdmin)
                    return true;

                return false;
            }
        }

        public bool IsCentral
        {
            get
            {
                if (this.User.IsAdmin)
                    return true;

                if (this.User.IsCentral)
                    return true;

                return false;
            }
        }

        public bool HasAddNewPrivilege(string tableName)
        {
            if (this.IsSupervisor)
                return true;

            DBRuleConstant rule = DBRuleConstant.FindByTableName(tableName);
            if (!this._permissionList.ContainsKey(rule.ID))
                return false;

            return this._permissionList[rule.ID].Insertable;
        }

        public bool HasEditPrivilege(string tableName)
        {
            if (this.IsSupervisor)
                return true;

            DBRuleConstant rule = DBRuleConstant.FindByTableName(tableName);
            if (!this._permissionList.ContainsKey(rule.ID))
                return false;

            return this._permissionList[rule.ID].Editable;
        }

        public bool HasDeletePrivilege(string tableName)
        {
            if (this.IsSupervisor)
                return true;

            DBRuleConstant rule = DBRuleConstant.FindByTableName(tableName);
            if (!this._permissionList.ContainsKey(rule.ID))
                return false;

            return this._permissionList[rule.ID].Deletable;
        }

        public bool IsPermissionAllowed(int ruleID)
        {
            if (this.IsSupervisor)
                return true;

            if (!this._bizPermissionList.ContainsKey(ruleID))
                return false;

            return !this._bizPermissionList[ruleID].Denied;
        }
    }

    public class DBPermission
    {
        private int _ruleID= 0;
        private bool _deletable = false;
        private bool _insertable = false;
        private bool _selectable = false;
        private bool _editable = false;

        public bool Deletable
        {
            get { return _deletable; }
            set { _deletable = value; }
        }

        public bool Insertable
        {
            get { return _insertable; }
            set { _insertable = value; }
        }

        public bool Selectable
        {
            get { return _selectable; }
            set { _selectable = value; }
        }

        public bool Editable
        {
            get { return _editable; }
            set { _editable = value; }
        }

        public int RuleID
        {
            get { return _ruleID; }
            set { _ruleID = value; }
        }
    }

    public class BRPermission
    {
        private int _ruleID = 0;
        private bool _denied = false;

        public int RuleID
        {
            get { return _ruleID; }
            set { _ruleID = value; }
        }

        public bool Denied
        {
            get { return _denied; }
            set { _denied = value; }
        }
    }
}