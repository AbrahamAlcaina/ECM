using ServiceStack.ServiceHost;

namespace ECM.Application.Routing
{
    [Route("/api/ecm/files/{idFile}/content/")]
<<<<<<< HEAD
    public class FileContent : FileRequest {}
=======
    public class FileContent : FileById {}
>>>>>>> Refactoring using Specifications
}