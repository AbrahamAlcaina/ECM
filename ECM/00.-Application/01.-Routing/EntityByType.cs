using ServiceStack.ServiceHost;

namespace ECM.Application.Routing
{
    [Route("/api/ecm/files/client/{cid}/entity/{cuid}/filetype/{type}/")]
    public class EntityByType : ClientByType
    {
        public string Cuid { get; set; }
    }
}