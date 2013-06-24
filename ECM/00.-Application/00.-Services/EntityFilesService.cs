// --------------------------------------------------------------------------------------------------------------------
// <copyright file="EntityFilesService.cs" company="Abraham Alcaina">
//   Abraham Alcaina
// </copyright>
// <summary>
//   The entity files service.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace ECM.Application.Services
{
    using ECM.Application.Routing;
    using ECM.Application.Specifications;
    using ECM.Domain.Entities;
    using ECM.Domain.Specifications;
    using ECM.Infrastructure;

    /// <summary>
    ///     The entity files service.
    /// </summary>
    internal class EntityFilesService : FileServiceBase
    {
        #region Public Methods and Operators

        /// <summary>
        /// The get.
        /// </summary>
        /// <param name="request">
        /// The request.
        /// </param>
        /// <returns>
        /// The <see cref="object"/>.
        /// </returns>
        public object Get(Entity request)
        {
            var criteria = new FindFileByEntity(request.Cid, request.Cuid);
            return this.CreateResponseForFilesByCriteria(request, criteria);
        }

        /// <summary>
        /// The get.
        /// </summary>
        /// <param name="request">
        /// The request.
        /// </param>
        /// <returns>
        /// The <see cref="object"/>.
        /// </returns>
        public object Get(EntityByType request)
        {
            AndSpecification<File> criteria =
                new FindFileByEntity(request.Cid, request.Cuid).And(new FindFileByType(request.Type));
            return this.CreateResponseForFilesByCriteria(request, criteria);
        }

        /// <summary>
        /// The get.
        /// </summary>
        /// <param name="request">
        /// The request.
        /// </param>
        /// <returns>
        /// The <see cref="object"/>.
        /// </returns>
        public object Get(EntityByTags request)
        {
            AndSpecification<File> criteria =
                new FindFileByEntity(request.Cid, request.Cuid).And(new FindFileByTags(request.Tags));
            return this.CreateResponseForFilesByCriteria(request, criteria);
        }

        /// <summary>
        /// The get.
        /// </summary>
        /// <param name="request">
        /// The request.
        /// </param>
        /// <returns>
        /// The <see cref="object"/>.
        /// </returns>
        public object Get(EntityByUpdatedDates request)
        {
            AndSpecification<File> criteria =
                new FindFileByEntity(request.Cid, request.Cuid).And(
                    new FindFileByLastUpdateRange(request.StartDate, request.EndDate));
            return this.CreateResponseForFilesByCriteria(request, criteria);
        }

        /// <summary>
        /// The get.
        /// </summary>
        /// <param name="request">
        /// The request.
        /// </param>
        /// <returns>
        /// The <see cref="object"/>.
        /// </returns>
        public object Get(EntityByDatesFileType request)
        {
            AndSpecification<File> criteria =
                new FindFileByEntity(request.Cid, request.Cuid).And(
                    new FindFileByReceptionDateRange(request.StartDate, request.EndDate))
                                                               .And(new FindFileByType(request.FileType));
            return this.CreateResponseForFilesByCriteria(request, criteria);
        }

        /// <summary>
        /// The get.
        /// </summary>
        /// <param name="request">
        /// The request.
        /// </param>
        /// <returns>
        /// The <see cref="object"/>.
        /// </returns>
        public object Get(EntityByUpdatedDatesType request)
        {
            AndSpecification<File> criteria =
                new FindFileByEntity(request.Cid, request.Cuid).And(
                    new FindFileByLastUpdateRange(request.StartDate, request.EndDate))
                                                               .And(new FindFileByType(request.FileType));
            return this.CreateResponseForFilesByCriteria(request, criteria);
        }

        #endregion
    }
}