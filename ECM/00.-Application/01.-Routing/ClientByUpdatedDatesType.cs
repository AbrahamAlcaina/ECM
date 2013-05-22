using ServiceStack.ServiceHost;

namespace ECM.Application.Routing
{
    [Route("/api/ecm/files/client/{cid}/lastupdatefrom/{startdate}/to/{enddate}/filetype/{type}/")]
    public class ClientByUpdatedDatesType : FileByUpdatedDatesType
    {
        public string  Cid { get; set; }
    }
}