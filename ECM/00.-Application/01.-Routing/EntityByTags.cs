using ServiceStack.ServiceHost;

namespace ECM.Application.Routing
{
    [Route("/api/ecm/files/client/{cid}/entity/{cuid}/tag/{tag1+...+tagn}/")]
    public class EntityByTags:ClientByTags
    {
        public string Cuid { get; set; }
    }
}