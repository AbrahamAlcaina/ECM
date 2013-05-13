using ECM.Domain.Entities;
using ServiceStack.ServiceHost;

namespace ECM.Application.Routing
{
    [Route("/api/ecm/files/filetype/{type}/")]
    public class FileByTypeRequest
    {
        public string Type { get; set; }
    }
}