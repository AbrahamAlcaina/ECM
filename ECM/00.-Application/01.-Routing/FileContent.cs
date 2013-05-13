using ServiceStack.ServiceHost;

namespace ECM.Application.Routing
{
    [Route("/api/ecm/files/{idFile}/content/")]
    public class FileContent : FileRequest {}
}