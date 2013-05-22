using System;
using ServiceStack.ServiceHost;

namespace ECM.Application.Routing
{
    [Route("/api/ecm/files/client/{cid}/entity/{cuid}/paygroup/{idPaygroup/cycle/{idCycle}/lastupdatefrom/{startdate}/to/{enddate}/")]
    public class CycleByUpdatedDates: PaygroupByUpdatedDates
    {
        public Guid IdCycle { get; set; }
    }
}