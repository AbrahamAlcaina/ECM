using ServiceStack.ServiceHost;

namespace ECM.Application.Routing
{
    [Route("/api/ecm/files/client/{cid}/from/{startdate}/to/{enddate}/")]
    public class ClientByDates : FileByDates
    {
        public string Cid { get; set; }
    }
}