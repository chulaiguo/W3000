using System;
using System.IO;
using System.ServiceModel;
using System.Text;
using W3000.BasicServiceWrapper;
using W3000.Data;
using W3000.IJsonService;
using W3000.Schema;

namespace W3000.JsonService
{
    [ServiceBehavior(Namespace = "http://chekeit.com/JsonService/")]
    public class ServiceFactory : ServiceBase, IServiceFactory
    {
        public string GetCurrentTime()
        {
            return this.DateTimeToString(DateTime.Now);
        }

        public string GetBuildingList()
        {
            BDBuildingDataCollection list = BDBuildingWrapper.GetAll(base.Token);
            if (list.Count == 0)
            {
                return string.Empty;
            }

            StringBuilder retList = new StringBuilder();
            retList.Append("{\"" + BDBuildingSchema.TableAlias + "\":[");        
            for (int i = 0; i < list.Count; i++)
            {
                BDBuildingData item = list[i];
                retList.Append("{");

                retList.AppendFormat("\"{0}\": \"{1}\",", BDBuildingSchema.BDBuildingPK, item.BDBuildingPK);
                retList.AppendFormat("\"{0}\": \"{1}\",", BDBuildingSchema.BuildingID, item.BuildingID);
                retList.AppendFormat("\"{0}\": \"{1}\"", BDBuildingSchema.Address1, item.Address1);
                
                retList.Append("}");
                if (i < list.Count - 1)
                {
                    retList.Append(",");
                }
            }
            retList.Append("]}");

            return retList.ToString();
        }

        public string GetBuildingByPK(string BDBuildingPK)
        {
            BDBuildingData item = BDBuildingWrapper.GetByPK(new Guid(BDBuildingPK), base.Token);
            if (item == null)
            {
                return string.Empty;
            }

            StringBuilder retList = new StringBuilder();
            retList.Append("{");
            retList.AppendFormat("\"{0}\": \"{1}\",", BDBuildingSchema.BDBuildingPK, item.BDBuildingPK);
            retList.AppendFormat("\"{0}\": \"{1}\",", BDBuildingSchema.BuildingID, item.BuildingID);
            retList.AppendFormat("\"{0}\": \"{1}\"", BDBuildingSchema.Address1, item.Address1);
            retList.Append("}");

            return retList.ToString();
        }

        public Stream GetCardHolderPhoto(string ACCardHolderPK)
        {
            ACCardHolderData data = ACCardHolderWrapper.GetByPK(new Guid(ACCardHolderPK), base.Token);
            if (data == null || data.Photo == null)
                return null;

            MemoryStream stream = new MemoryStream(data.Photo);
            stream.Position = 0;
            return stream;
        }

        #region Helper functions
        private string DateTimeToString(DateTime date)
        {
            return string.Format("{0:yyyyMMddHHmmss}", date);
        }
        #endregion
    }
}
