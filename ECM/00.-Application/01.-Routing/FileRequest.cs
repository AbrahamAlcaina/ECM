using System;
using ServiceStack.ServiceHost;

namespace ECM.Application.Routing
{
    [Route("/api/ecm/files/{idFile}/")]
    public class FileRequest
    {
        public Guid IdFile { get; set; }
    }
}