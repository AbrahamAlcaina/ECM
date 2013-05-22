using System;
using ServiceStack.ServiceHost;

namespace ECM.Application.Routing
{
    [Route("/api/ecm/files/client/{cid}/entity/{cuid}/paygroup/{idPaygroup/cycle/{idCycle}/filetype/{type}/")]
    public class CycleByType : PaygroupByType
    {
        public Guid IdCycle { get; set; }
    }
}