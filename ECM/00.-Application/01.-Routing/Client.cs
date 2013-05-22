using ServiceStack.ServiceHost;

namespace ECM.Application.Routing
{
    [Route("/api/ecm/files/client/{cid}/")]
    public class Client
    {
        public string Cid { get; set; }
    }
}