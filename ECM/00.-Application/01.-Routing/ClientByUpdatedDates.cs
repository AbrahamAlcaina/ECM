using ServiceStack.ServiceHost;

namespace ECM.Application.Routing
{
    [Route("/api/ecm/files/client/{cid}/lastupdatefrom/{startdate}/to/{enddate}/")]
    public class ClientByUpdatedDates : FileByUpdatedDates
    {
        public string Cid { get; set; }
    }
}