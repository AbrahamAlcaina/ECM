using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ECM.Application.Routing;
using ECM.Application.Specifications;
using ECM.Domain.Entities;
using ECM.Domain.Specifications;
using ECM.Infrastructure;
using Client = ECM.Application.Routing.Client;

namespace ECM.Application.Services
{
    class ClientFilesService : FileServiceBase
    {
        public object Get(Client request)
        {
            var criteria = new FindFileByClient(request.Cid);
            return CreateResponseForFilesByCriteria(request, criteria);
        }

        public object Get(ClientByType request)
        {
            var criteria = new FindFileByClient(request.Cid)
                .And(new FindFileByType(request.Type));
            return CreateResponseForFilesByCriteria(request, criteria);
        }

        public object Get(ClientByTags request)
        {
            var criteria = new FindFileByClient(request.Cid)
                .And(new FindFileByTags(request.Tags));
            return CreateResponseForFilesByCriteria(request, criteria);
        }

        public object Get(ClientByUpdatedDates request)
        {
            var criteria = new FindFileByClient(request.Cid)
                .And(new FindFileByLastUpdateRange(request.StartDate, request.EndDate)); 
            return CreateResponseForFilesByCriteria(request, criteria);
        }

        public object Get(ClientByDatesFileType request)
        {
            var criteria = new FindFileByClient(request.Cid)
                .And(new FindFileByReceptionDateRange(request.StartDate, request.EndDate)); 
            return CreateResponseForFilesByCriteria(request, criteria);
        }

        public object Get(ClientByUpdatedDatesType request)
        {
            var criteria = new FindFileByClient(request.Cid)
                .And(new FindFileByReceptionDateRange(request.StartDate, request.EndDate))
                .And(new FindFileByType(request.FileType )); 
            return CreateResponseForFilesByCriteria(request, criteria);
        }
    }
}
