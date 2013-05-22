using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using ServiceStack.Common.Web;

namespace ECM.Application.Services
{
    public class Service : ServiceStack.ServiceInterface.Service 
    {
        public static object FileNotFound(object target)
        {
            return new HttpResult
            {
                StatusCode = HttpStatusCode.NotFound,
                Response = String.Format("File not found '{0}'", target)
            };
        }

        public static object TooManyFiles(object target)
        {
            return new HttpResult
            {
                StatusCode = HttpStatusCode.NotFound,
                Response = String.Format("Too many files with id '{0}'", target)
            };
        }
    }
}
