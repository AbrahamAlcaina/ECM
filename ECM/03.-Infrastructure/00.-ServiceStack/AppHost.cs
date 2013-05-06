using ECM.Application.Services;
using ECM.Domain.Entities;
using ECM.Infrastructure.Repositories;
using Funq;
using MongoRepository;
using ServiceStack.WebHost.Endpoints;

namespace ECM.Infrastructure.ServiceStack
{
    internal class AppHost : AppHostHttpListenerBase
    {
        public AppHost() : base("ECMongo", typeof (FileService).Assembly)
        {
        }

        public override void Configure(Container container)
        {
            container.RegisterAutoWiredAs<FileRepository, IRepository<File>>();
        }
    }
}