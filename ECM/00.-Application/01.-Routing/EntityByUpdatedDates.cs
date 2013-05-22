using ServiceStack.ServiceHost;

namespace ECM.Application.Routing
{
    [Route("/api/ecm/files/client/{cid}/entity/{cuid}/lastupdatefrom/{startdate}/to/{enddate}/")]
    public class EntityByUpdatedDates: ClientByUpdatedDates
    {
        public string Cuid { get; set; }
    }
}