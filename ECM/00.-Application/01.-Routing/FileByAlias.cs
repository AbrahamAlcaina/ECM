using ServiceStack.ServiceHost;

namespace ECM.Application.Routing
{
    [Route("/api/ecm/files/alias/{aliasName}/")]
    public class FileByAlias
    {
        public string AliasName { get; set; }
    }
}