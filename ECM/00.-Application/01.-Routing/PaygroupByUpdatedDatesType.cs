using ServiceStack.ServiceHost;

namespace ECM.Application.Routing
{
    [Route("/api/ecm/files/client/{cid}/entity/{cuid}/paygroup/{idPaygroup/lastupdatefrom/{startdate}/to/{enddate}/filetype/{type}/")]
    public class PaygroupByUpdatedDatesType: EntityByUpdatedDatesType
    {
        public string IdPaygroup { get; set; }
    }
}