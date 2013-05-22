using ServiceStack.ServiceHost;

namespace ECM.Application.Routing
{
    [Route("/api/ecm/files/client/{cid}/filetype/{type}/")]
    public class ClientByType : FileByType
    {
        public string Cid { get; set; }
    }
}