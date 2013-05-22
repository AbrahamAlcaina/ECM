using System;
using ServiceStack.ServiceHost;

namespace ECM.Application.Routing
{
    [Route("/api/ecm/files/{idFile}/")]
    public class FileById
    {
        public Guid IdFile { get; set; }

        public override string ToString()
        {
            return String.Format("Id: '{0}'", IdFile);
        }
    }
}