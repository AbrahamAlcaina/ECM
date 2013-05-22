using ServiceStack.ServiceHost;

namespace ECM.Application.Routing
{
    [Route("/api/ecm/files/client/{cid}/entity/{cuid}/paygroup/{idPaygroup/lastupdatefrom/{startdate}/to/{enddate}/")]
    public class PaygroupByUpdatedDates: EntityByUpdatedDates
    {
        public string IdPaygroup { get; set; }
    }
}