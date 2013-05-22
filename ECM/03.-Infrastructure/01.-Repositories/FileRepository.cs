using System;
using System.Linq.Expressions;
using System.Linq;
using ECM.Domain.Entities;
using MongoRepository;

namespace ECM.Infrastructure.Repositories
{
    internal class FileRepository : MongoRepository<File>, IFileRepository
    {
        public long Count(Expression<Func<File, bool>> criteria)
        {
            return All(criteria).Count();
        }
    }
}