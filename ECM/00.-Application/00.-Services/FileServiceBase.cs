using System.Globalization;
using ECM.Domain.Entities;
using ECM.Infrastructure;
using ECM.Infrastructure.Repositories;

namespace ECM.Application.Services
{

    internal class FileServiceBase : Service
    {
        protected IFileRepository Repository { get; set; }

        protected void InsertRangeInResponse(long count)
        {
            var range = base.Request.Headers["Range"];
            if (string.IsNullOrEmpty(range))
            {
                base.Response.AddHeader("Content-Range", count.ToString(CultureInfo.InvariantCulture));
            }
            else
            {
                base.Response.AddHeader("Content-Range", range + "/" + count);    
            }
        }

        protected object CreateResponseForFilesByCriteria(object file, ISpecification<File> criteria)
        {
            var count = Repository.Count(criteria.IsSatisfiedBy());
            InsertRangeInResponse(count);
            return count == 0 ? FileNotFound(file) : Repository.All(criteria.IsSatisfiedBy());
        }

        protected object CreateReponseForSingleFileByCriteria(object file, ISpecification<File> criteria)
        {
            var count = Repository.Count(criteria.IsSatisfiedBy());
            InsertRangeInResponse(count);
            if (count == 0) return FileNotFound(file);
            return count > 1 ? TooManyFiles(file) : Repository.GetSingle(criteria.IsSatisfiedBy());
        }
    }
}