using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using ECM.Application.Routing;
using ECM.Domain.Entities;
using MongoRepository;
using ServiceStack.Common.Web;
using ServiceStack.ServiceInterface;

namespace ECM.Application.Services
{
    internal class FileService : Service
    {
        public IRepository<File> Repository { get; set; }

        public object Get(FileRequest file)
        {
            List<File> files = Repository.All(f => f.FileId == file.IdFile).ToList();
            if (files.Count == 0) return FileNotFound(file.IdFile);
            return files.Count > 1 ? TooManyFiles(file.IdFile) : files.First();
        }

        public object Get(FileByTypeRequest type)
        {
            List<File> files = Repository.All(f => f.Type == type.Type).ToList();
            return files.Count == 0 ? FileNotFound(type.Type) : files;
        }

        public object Get(FileByTagsRequest tags)
        {
            List<File> files = Repository.All(f => f.Tags.Any(t => tags.Tags.Contains(t))).ToList();
            return files.Count == 0 ? FileNotFound(tags) : files;
        }

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
        {
            var fileResponse = file.ToResponseDto<File>();
            Repository.Add(fileResponse);
            return fileResponse;
        }

        private static object FileNotFound(object idFile)
        {
            return new HttpResult
                {
                    StatusCode = HttpStatusCode.NotFound,
                    Response = String.Format("File not found '{0}'", idFile)
                };
        }

        private static object TooManyFiles(object idFile)
        {
            return new HttpResult
                {
                    StatusCode = HttpStatusCode.NotFound,
                    Response = String.Format("Too many files with id '{0}'", idFile)
                };
        }
    }
}