using ServiceStack.ServiceHost;

namespace ECM.Application.Routing
{
    [Route("/api/ecm/files/client/{cid}/entity/{cuid}/from/{startdate}/to/{enddate}/")]
    public class EntityByDates: ClientByDates
    {
        public string Cuid { get; set; }
    }
}