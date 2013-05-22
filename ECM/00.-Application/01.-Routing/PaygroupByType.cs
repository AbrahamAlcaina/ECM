using ServiceStack.ServiceHost;

namespace ECM.Application.Routing
{
    [Route("/api/ecm/files/client/{cid}/entity/{cuid}/paygroup/{idPaygroup/filetype/{type}/")]
    public class PaygroupByType: EntityByType
    {
        public string IdPaygroup { get; set; }
    }
}