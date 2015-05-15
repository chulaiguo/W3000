using System.IO;
using System.ServiceModel;
using System.ServiceModel.Web;

namespace W3000.IJsonService
{
    [ServiceContract(Namespace = "http://chekeit.com/JsonService/")]
	public interface IServiceFactory
    {
        [OperationContract]
        [WebGet(UriTemplate = "/GetCurrentTime", ResponseFormat = WebMessageFormat.Json)]
        string GetCurrentTime();

        [OperationContract]
        [WebGet(UriTemplate = "/GetBuildingList", ResponseFormat = WebMessageFormat.Json)]
        string GetBuildingList();

        [OperationContract]
        [WebGet(UriTemplate = "/GetBuildingByPK?BDBuildingPK={BDBuildingPK}", ResponseFormat = WebMessageFormat.Json)]
        string GetBuildingByPK(string BDBuildingPK);

        [OperationContract]
        [WebGet(UriTemplate = "/GetCardHolderPhoto?ACCardHolderPK={ACCardHolderPK}")]
        Stream GetCardHolderPhoto(string ACCardHolderPK);
    }
}
