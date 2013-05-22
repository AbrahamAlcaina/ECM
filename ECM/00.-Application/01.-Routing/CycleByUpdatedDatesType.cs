using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceStack.ServiceHost;

namespace ECM.Application.Routing
{
    [Route("/api/ecm/files/client/{cid}/entity/{cuid}/paygroup/{idPaygroup/cycle/{idCycle}/lastupdatefrom/{startdate}/to/{enddate}/filetype/{type}/")]
    public class CycleByUpdatedDatesType : PaygroupByUpdatedDatesType
    {
        public Guid IdCycle { get; set; }
    }
    
}
