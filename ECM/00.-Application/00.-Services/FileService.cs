using System;
using System.Linq;
using System.Linq.Expressions;
using System.Net;
using ECM.Application.Mapping;
using ECM.Application.Routing;
using ECM.Application.Specifications;
using ECM.Domain.Entities;
using ECM.Domain.Specifications;
using ECM.Infrastructure;
using ServiceStack.Common.Web;

namespace ECM.Application.Services
{
    internal class FileService : FileServiceBase
    {
        public object Get(FileById request)
        {
            var criteria = new FindFileById(request.IdFile);
            return CreateReponseForSingleFileByCriteria(request, criteria);
        }

        public object Get(FileByType request)
        {
            var criteria = new FindFileByType(request.Type); 
            return CreateResponseForFilesByCriteria(request, criteria);
        }

        public object Get(FileByTags request)
        {
<<<<<<< HEAD
            var fileType = type.ToDto();
            List<File> files = Repository.All(f => f.Type == fileType).ToList();
            return files.Count == 0 ? FileNotFound(type.Type) : files;
=======
            var criteria = new FindFileByTags(request.Tags);
            return CreateResponseForFilesByCriteria(request, criteria);
>>>>>>> Refactoring using Specifications
        }

        public object Get(FileChilds request)
        {
            var criteria = new Specification<File>(f => f.ParentId == request.IdFile);
            return CreateResponseForFilesByCriteria(request, criteria);
        }

<<<<<<< HEAD
        public object Get(FileChilds file)
        {
            var files = Repository.All(f => f.ParentId == file.IdFile).ToList();
            return files.Count == 0 ? FileNotFound(file.IdFile) : files;
        }

        public object Get(FileByUpdatedDates file)
        {
            var files = Repository.All(f => f.LastUpdateTime >= file.StartDate && f.LastUpdateTime <= file.EndDate).ToList();
            return files.Count == 0 ? FileNotFound(file) : files;
        }

        public object Get(FileByDatesFileType file)
        {
            var files = Repository.All(f => f.Type == file.FileType && 
                f.ReceptionDate >= file.StartDate &&  f.ReceptionDate <= file.EndDate).ToList();
            return files.Count == 0 ? FileNotFound(file) : files;
        }

        public object Get(FileByUpdatedDatesType file)
        {
            var files = Repository.All(f => f.Type == file.FileType &&
                                            f.LastUpdateTime >= file.StartDate && f.LastUpdateTime <= file.EndDate)
                                  .ToList();
            return files.Count == 0 ? FileNotFound(file) : files;
        }

        public object Post(FileCreationRequest file)
=======
        public object Get(FileByUpdatedDates request)
>>>>>>> Refactoring using Specifications
        {
            var criteria = new FindFileByLastUpdateRange(request.StartDate, request.EndDate);
            return CreateResponseForFilesByCriteria(request, criteria);
        }

        public object Get(FileByDatesFileType request)
        {
            var criteria = new FindFileByReceptionDateRange(request.StartDate, request.EndDate)
                .And(new FindFileByType(request.FileType));
            return CreateResponseForFilesByCriteria(request, criteria);
        }

        public object Get(FileByUpdatedDatesType request)
        {
            var criteria = new FindFileByLastUpdateRange(request.StartDate, request.EndDate)
                .And(new FindFileByType(request.FileType));
            return CreateResponseForFilesByCriteria(request, criteria);
        }

        public object Post(FileCreation file)
        {
            var fileResponse = file.ToResponseDto<File>();
            Repository.Add(fileResponse);
            return fileResponse;
        }
    }
}