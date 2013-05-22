using ServiceStack.ServiceHost;

namespace ECM.Application.Routing
{
    [Route("/api/ecm/files/client/{cid}/tag/{tag1+...+tagn}/")]
    public class ClientByTags: FileByTags
    {
        public string Cid { get; set; }
    }
}