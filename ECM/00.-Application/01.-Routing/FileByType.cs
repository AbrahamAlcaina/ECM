using ECM.Domain.Entities;
using ServiceStack.ServiceHost;

namespace ECM.Application.Routing
{
    [Route("/api/ecm/files/filetype/{type}/")]
    public class FileByType
    {
        public string Type { get; set; }

        public override string ToString()
        {
            return string.Format("Type: '{0}'", Type);
        }
    }
}