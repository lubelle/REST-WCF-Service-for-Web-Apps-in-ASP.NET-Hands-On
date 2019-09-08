using System.ServiceModel;
using System.ServiceModel.Activation;
using System.ServiceModel.Web;

namespace SuperHeroDB.Service
{
    [ServiceContract(Namespace = "")]
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
    public class SuperHeroService
    {
        // To use HTTP GET, add [WebGet] attribute. (Default ResponseFormat is WebMessageFormat.Json)
        // To create an operation that returns XML,
        //      add [WebGet(ResponseFormat = WebMessageFormat.Xml)],
        //      add include the following line in the operation body:
        //      WebOperationContext.Current.OutgoingResponse.ContentType = "text/xml";

        //[OperationContract]
        [OperationContract, WebGet(ResponseFormat = WebMessageFormat.Json)]
        public string DoWork()
        {
            return "This is the SuperHeroDB service!";
        }

        // Add more operations here and mark them with [OperationContract]
    }
}
