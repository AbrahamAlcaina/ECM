using ServiceStack.ServiceHost;

namespace ECM.Application.Routing
{
    [Route("/api/ecm/files/client/{cid}/entity/{cuid}/paygroup/{idPaygroup/from/{startdate}/to/{enddate}/")]
    public class PaygroupByDates : EntityByDates
    {
        public string IdPaygroup { get; set; }
    }
}