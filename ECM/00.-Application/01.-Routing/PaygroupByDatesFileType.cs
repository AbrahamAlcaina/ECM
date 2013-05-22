using ServiceStack.ServiceHost;

namespace ECM.Application.Routing
{
    [Route("/api/ecm/files/client/{cid}/entity/{cuid}/paygroup/{idPaygroup/from/{startdate}/to/{enddate}/filetype/{type}/")]
    public class PaygroupByDatesFileType: EntityByDatesFileType
    {
        public string IdPaygroup { get; set; }
    }
}