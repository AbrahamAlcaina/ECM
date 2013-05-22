using ServiceStack.ServiceHost;

namespace ECM.Application.Routing
{
    [Route("/api/ecm/files/client/{cid}/entity/{cuid}/paygroup/{idpaygroup}/")]
    public class Paygroup : Entity
    {
        public string IdPaygroup { get; set; }
    }
}