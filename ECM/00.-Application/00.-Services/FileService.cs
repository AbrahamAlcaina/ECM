using System;
using ECM.Domain.Entities;
using ServiceStack.ServiceInterface;

namespace ECM.Application.Services
{
    internal class FileService : Service
    {
        public object Get(File file)
        {
            return new ArgumentException();
        }
    }
}