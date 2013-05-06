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

            if (files.Count == 0)
                return new HttpResult
                    {
                        StatusCode = HttpStatusCode.NotFound,
                        Response = String.Format("File not found '{0}'", file.IdFile)
                    };

            if (files.Count > 1)
                return new HttpResult
                    {
                        StatusCode = HttpStatusCode.NotFound,
                        Response = String.Format("Too many files with id '{0}'", file.IdFile)
                    };

            return files.First();
        }
    }
}