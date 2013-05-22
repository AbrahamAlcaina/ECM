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
using Entity = ECM.Application.Routing.Entity;

namespace ECM.Application.Services
{
    class EntityFilesService : FileServiceBase
    {
        public object Get(Entity request)
        {
            var criteria = new FindFileByEntity(request.Cid, request.Cuid);
            return CreateResponseForFilesByCriteria(request, criteria);
        }

        public object Get(EntityByType request)
        {
            var criteria = new FindFileByEntity(request.Cid, request.Cuid)
                .And(new FindFileByType(request.Type));
            return CreateResponseForFilesByCriteria(request, criteria);
        }

        public object Get(EntityByTags request)
        {
            var criteria = new FindFileByEntity(request.Cid, request.Cuid)
                .And(new FindFileByTags(request.Tags));
            return CreateResponseForFilesByCriteria(request, criteria);
        }

        public object Get(EntityByUpdatedDates request)
        {
            var criteria = new FindFileByEntity(request.Cid, request.Cuid)
                .And(new FindFileByLastUpdateRange(request.StartDate, request.EndDate));
            return CreateResponseForFilesByCriteria(request, criteria);
        }

        public object Get(EntityByDatesFileType request)
        {
            var criteria = new FindFileByEntity(request.Cid, request.Cuid)
                .And(new FindFileByReceptionDateRange(request.StartDate, request.EndDate))
                .And(new FindFileByType(request.FileType));
            return CreateResponseForFilesByCriteria(request, criteria);
        }

        public object Get(EntityByUpdatedDatesType request)
        {
            var criteria = new FindFileByEntity(request.Cid, request.Cuid)
                .And(new FindFileByLastUpdateRange(request.StartDate, request.EndDate))
                .And(new FindFileByType(request.FileType));
            return CreateResponseForFilesByCriteria(request, criteria);
        }
    }
}
