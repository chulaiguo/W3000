using System;
using System.Reflection;
using Cheke.BusinessEntity;
using Cheke.WinCtrl.Decoration;
using W3000.ViewObj;
using DevExpress.XtraGrid;

namespace W3000.Manager.FormLog
{
    internal static class LogHelper
    {
        public static BusinessBase GetEntityFromDB(BusinessBase entity)
        {
            MethodInfo method = GetByPKMethod(entity);
            if (method == null)
                return null;

            object[] paras = new object[]{ new Guid(entity.PKString)};
            return method.Invoke(null, paras) as BusinessBase;
        }

        private static MethodInfo GetByPKMethod(BusinessBase entity)
        {
            MethodInfo[] list = entity.GetType().GetMethods(BindingFlags.Static | BindingFlags.Public);
            foreach (MethodInfo item in list)
            {
                if (item.Name != "GetByPK")
                    continue;

                if (item.GetParameters().Length == 1)
                    return item;
            }

            return null;
        }

        public static GridControlDecorator CreateDecorator(string userId, string tableName,  GridControl grdCtrl)
        {
            string typeName = string.Format("W3000.Manager.GridDecorator.Grid{0}Decorator, W3000.Manager, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", tableName);
            Type type = Type.GetType(typeName);
            if (type == null)
                return null;

            return Activator.CreateInstance(type, new object[] { userId, grdCtrl }) as GridControlDecorator;
        }

        public static BusinessCollectionBase Log2BusinessCollection(string tableName, LogDBEditActivityCollection list)
        {
            Type entityType = Type.GetType(string.Format("W3000.ViewObj.{0}, W3000.ViewObj, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", tableName));
            if (entityType == null)
                return null;

            Type collectionType = Type.GetType(string.Format("W3000.ViewObj.{0}Collection, W3000.ViewObj, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", tableName));
            if (collectionType == null)
                return null;

            BusinessCollectionBase retList = Activator.CreateInstance(collectionType) as BusinessCollectionBase;
            if(retList == null)
                return null;

            foreach (LogDBEditActivity log in list)
            {
                BusinessBase entity = Activator.CreateInstance(entityType) as BusinessBase;
                if(entity == null)
                    continue;

                entity.Deserialize(log.RecordDetail);
                entity.ModifiedOn = log.LogDateTime;
                entity.ModifiedBy = log.ModifiedBy;
                entity.AcceptChanges();
                retList.Add(entity);
            }

            return retList;
        }
    }
}
