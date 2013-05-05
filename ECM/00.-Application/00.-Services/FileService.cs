using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ECM.Domain.Entities;
using ServiceStack.ServiceInterface;

namespace ECM.Application.Services
{
    class FileService : Service
    {
        public object Get(File file)
        {
            return new ArgumentException();
        }
    }
}
