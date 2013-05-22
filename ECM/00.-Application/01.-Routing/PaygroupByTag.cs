using ServiceStack.ServiceHost;

namespace ECM.Application.Routing
{
    [Route("/api/ecm/files/client/{cid}/entity/{cuid}/paygroup/{idPaygroup/tag/{tag1+...+tagn}/")]
    public class PaygroupByTag: EntityByTags
    {
        public string IdPaygroup { get; set; }
    }
}