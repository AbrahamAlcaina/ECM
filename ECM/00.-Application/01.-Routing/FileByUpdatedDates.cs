using System;
using ServiceStack.ServiceHost;

namespace ECM.Application.Routing
{
    [Route("/api/ecm/files/lastupdatefrom/{startdate}/to/{enddate}/")]
    public class FileByUpdatedDates
    {
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}