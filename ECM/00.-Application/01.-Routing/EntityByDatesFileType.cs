using ServiceStack.ServiceHost;

namespace ECM.Application.Routing
{
    [Route("/api/ecm/files/client/{cid}/entity/{cuid}/from/{startdate}/to/{enddate}/filetype/{type}/")]
    public class EntityByDatesFileType: ClientByDatesFileType
    {
        public string Cuid { get; set; }
    }
}