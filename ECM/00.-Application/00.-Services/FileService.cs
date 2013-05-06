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