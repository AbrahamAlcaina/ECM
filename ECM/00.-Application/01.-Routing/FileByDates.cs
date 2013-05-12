using System;
using ServiceStack.ServiceHost;

namespace ECM.Application.Routing
{
    [Route("api/ecm/files/from/{startdate}/to/{enddate}/")]
    public class  FileByDates
    {
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}