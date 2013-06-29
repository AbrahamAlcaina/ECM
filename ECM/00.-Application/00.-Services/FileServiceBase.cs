// --------------------------------------------------------------------------------------------------------------------
// <copyright file="FileServiceBase.cs" company="Abraham Alcaina">
//   Abraham Alcaina
// </copyright>
// <summary>
//   The file service base.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace ECM.Application.Services
{
    using System.Globalization;

    using ECM.Domain.Entities;
    using ECM.Infrastructure;

    using MongoRepository;
    using System.Linq;
    /// <summary>
    ///     The file service base.
    /// </summary>
    internal class FileServiceBase : Service
    {
        #region Properties

        /// <summary>
        ///     Gets or sets the repository.
        /// </summary>
        protected IRepository<File> Repository { get; set; }

        #endregion

        #region Methods

        /// <summary>
        /// Create a response for single file by criteria.
        /// </summary>
        /// <param name="file">
        /// The file.
        /// </param>
        /// <param name="criteria">
        /// The criteria.
        /// </param>
        /// <returns>
        /// The <see cref="object"/>.
        /// </returns>
        protected virtual object CreateResponseForSingleFileByCriteria(object file, ISpecification<File> criteria)
        {
            long count = this.Repository.Count(criteria.IsSatisfiedBy());
            this.InsertRangeInResponse(count);
            if (count == 0)
            {
                return this.FileNotFound(file);
            }

            return count > 1 ? this.TooManyFiles(file) : this.Repository.GetSingle(criteria.IsSatisfiedBy());
        }

        /// <summary>
        /// The create response for files by criteria.
        /// </summary>
        /// <param name="file">
        /// The file.
        /// </param>
        /// <param name="criteria">
        /// The criteria.
        /// </param>
        /// <returns>
        /// The <see cref="object"/>.
        /// </returns>
        protected virtual object CreateResponseForFilesByCriteria(object file, ISpecification<File> criteria)
        {
            long count = this.Repository.Count(criteria.IsSatisfiedBy());
            this.InsertRangeInResponse(count);
            return count == 0 ? this.FileNotFound(file) : this.Repository.Where(criteria.IsSatisfiedBy());
        }

        /// <summary>
        /// The insert range in response.
        /// </summary>
        /// <param name="count">
        /// The count.
        /// </param>
        protected virtual void InsertRangeInResponse(long count)
        {
            var range = this.Request.Headers["Range"];
            if (string.IsNullOrEmpty(range))
            {
                this.Response.AddHeader("Content-Range", count.ToString(CultureInfo.InvariantCulture));
            }
            else
            {
                this.Response.AddHeader("Content-Range", range + "/" + count);
            }
        }

        #endregion
    }
}