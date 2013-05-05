using ECM.Application.Services;
using ECM.Domain.Entities;
using Funq;
using ServiceStack.Common.Utils;
using ServiceStack.Configuration;
using ServiceStack.WebHost.Endpoints;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECM.Infrastructure.ServiceStack
{
    class AppHost : AppHostHttpListenerBase 
    {
        public AppHost() : base("ECMongo", typeof(FileService).Assembly)
        {
        }

        public override void Configure(Container container)
        {
            Routes
                .Add<File>("/File/{id}");
        }
    }
}
