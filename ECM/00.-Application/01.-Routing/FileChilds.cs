using ServiceStack.ServiceHost;

namespace ECM.Application.Routing
{
    [Route("/api/ecm/files/chid/{idFile}/")]
    public class FileChilds : FileRequest {}
}