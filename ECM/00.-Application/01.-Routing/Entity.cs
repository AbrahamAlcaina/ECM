using ServiceStack.ServiceHost;

namespace ECM.Application.Routing
{
    [Route("/api/ecm/files/client/{cid}/entity/{cuid}/")]
    public class Entity : Client
    {
        public string  Cuid { get; set; }
    }
}