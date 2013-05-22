using ServiceStack.ServiceHost;

namespace ECM.Application.Routing
{
    [Route("/api/ecm/files/client/{cid}/entity/{cuid}/lastupdatefrom/{startdate}/to/{enddate}/filetype/{type}/")]
    public class EntityByUpdatedDatesType : ClientByUpdatedDatesType
    {
        public string Cuid { get; set; }
    }
}