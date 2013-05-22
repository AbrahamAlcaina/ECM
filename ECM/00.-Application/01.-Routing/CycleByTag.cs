using System;
using ServiceStack.ServiceHost;

namespace ECM.Application.Routing
{
    [Route("/api/ecm/files/client/{cid}/entity/{cuid}/paygroup/{idPaygroup/cycle/{idCycle}/tag/{tag1+...+tagn}/")]
    public class CycleByTag : PaygroupByTag
    {
        public Guid IdCycle { get; set; }
    }
}