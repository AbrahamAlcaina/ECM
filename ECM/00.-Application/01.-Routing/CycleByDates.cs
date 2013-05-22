using System;
using ServiceStack.ServiceHost;

namespace ECM.Application.Routing
{
    [Route("/api/ecm/files/client/{cid}/entity/{cuid}/paygroup/{idPaygroup/cycle/{idCycle}/from/{startdate}/to/{enddate}/")]
    public class CycleByDates: PaygroupByDates
    {
        public Guid IdCycle { get; set; }
    }
}