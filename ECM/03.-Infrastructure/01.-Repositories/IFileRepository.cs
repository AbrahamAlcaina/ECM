using System;
using System.Linq.Expressions;
using ECM.Domain.Entities;
using MongoRepository;

namespace ECM.Infrastructure.Repositories
{
    internal interface IFileRepository : IRepository<File>
    {
        long Count(Expression<Func<File, bool>> criteria);
    }
}