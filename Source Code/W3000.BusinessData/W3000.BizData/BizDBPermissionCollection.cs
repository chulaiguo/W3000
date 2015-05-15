using System;
using System.Collections;

namespace W3000.BizData
{
    [Serializable]
    public class BizDBPermissionCollection : CollectionBase
    {
        public void Add(BizDBPermission entity)
        {
            this.List.Add(entity);
        }

        public void Insert(int index, BizDBPermission entity)
        {
            this.List.Insert(index, entity);
        }

        public void Remove(BizDBPermission entity)
        {
            this.List.Remove(entity);
        }

        public BizDBPermission this[int index]
        {
            get { return (BizDBPermission)base.List[index]; }
            set { { base.List[index] = value; } }
        }

        public BizDBPermission FindByID(int ruleID)
        {
            foreach (BizDBPermission item in this.List)
            {
                if (item.RuleID != ruleID)
                    continue;

                return item;
            }

            return null;
        }

        public BizDBPermission FindByTableName(string tableName)
        {
            foreach (BizDBPermission item in this.List)
            {
                if (String.Compare(item.TableName, tableName, StringComparison.OrdinalIgnoreCase) != 0)
                    continue;

                return item;
            }

            return null;
        }

        public bool HasAddNewPrivilege(int ruleID)
        {
            BizDBPermission entity = this.FindByID(ruleID);
            return entity != null && entity.Insertable;
        }

        public bool HasEditPrivilege(int ruleID)
        {
            BizDBPermission entity = this.FindByID(ruleID);
            return entity != null && entity.Editable;
        }

        public bool HasDeletePrivilege(int ruleID)
        {
            BizDBPermission entity = this.FindByID(ruleID);
            return entity != null && entity.Deletable;
        }

        public bool HasAddNewPrivilege(string tableName)
        {
            BizDBPermission entity = this.FindByTableName(tableName);
            return entity != null && entity.Insertable;
        }

        public bool HasEditPrivilege(string tableName)
        {
            BizDBPermission entity = this.FindByTableName(tableName);
            return entity != null && entity.Editable;
        }

        public bool HasDeletePrivilege(string tableName)
        {
            BizDBPermission entity = this.FindByTableName(tableName);
            return entity != null && entity.Deletable;
        }
    }
}
