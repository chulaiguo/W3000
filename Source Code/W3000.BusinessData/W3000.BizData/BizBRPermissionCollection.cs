using System;
using System.Collections;

namespace W3000.BizData
{
    [Serializable]
    public class BizBRPermissionCollection : CollectionBase
    {
        public void Add(BizBRPermission entity)
        {
            this.List.Add(entity);
        }

        public void Insert(int index, BizBRPermission entity)
        {
            this.List.Insert(index, entity);
        }

        public void Remove(BizBRPermission entity)
        {
            this.List.Remove(entity);
        }

        public BizBRPermission this[int index]
        {
            get { return (BizBRPermission)base.List[index]; }
            set { { base.List[index] = value; } }
        }

        public BizBRPermission FindByID(int ruleID)
        {
            foreach (BizBRPermission item in this.List)
            {
                if (item.RuleID != ruleID)
                    continue;

                return item;
            }

            return null;
        }

        public bool IsPermissionAllowed(int ruleID)
        {
            BizBRPermission entity = this.FindByID(ruleID);
            return entity != null && !entity.Denied;
        }

        public bool IsPermissionDenied(int ruleID)
        {
            BizBRPermission entity = this.FindByID(ruleID);
            return entity != null && entity.Denied;
        }
    }
}
