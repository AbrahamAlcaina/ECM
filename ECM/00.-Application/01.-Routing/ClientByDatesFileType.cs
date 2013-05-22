using ServiceStack.ServiceHost;

namespace ECM.Application.Routing
{
    [Route("/api/ecm/files/client/{cid}/from/{startdate}/to/{enddate}/filetype/{type}/")]
    public class ClientByDatesFileType: FileByDatesFileType
    {
        public string Cid { get; set; }
    }
}