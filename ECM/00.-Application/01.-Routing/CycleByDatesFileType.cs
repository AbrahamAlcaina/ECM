using System;
using ServiceStack.ServiceHost;

namespace ECM.Application.Routing
{
    [Route("/api/ecm/files/client/{cid}/entity/{cuid}/paygroup/{idPaygroup/cycle/{idCycle}/from/{startdate}/to/{enddate}/filetype/{type}/")]
    public class CycleByDatesFileType : PaygroupByDatesFileType
    {
        public Guid IdCycle { get; set; }
    }
}