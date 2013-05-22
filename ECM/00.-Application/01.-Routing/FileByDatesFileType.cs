using System;
using ECM.Domain.Entities;
using ServiceStack.ServiceHost;

namespace ECM.Application.Routing
{
    [Route("/api/ecm/files/from/{startdate}/to/{enddate}/filetype/{type}/")]
    public class FileByDatesFileType : FileByDates
    {
<<<<<<< HEAD
        public FileType FileType { get; set; }
=======
        public string FileType { get; set; }
>>>>>>> Refactoring using Specifications

        public override string ToString()
        {
            return String.Format("File type '{0}'. Received form {1} to {2}",
                                 FileType, StartDate, EndDate);
        }
    }
}