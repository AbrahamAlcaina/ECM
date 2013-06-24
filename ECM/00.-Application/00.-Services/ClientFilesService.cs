// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ClientFilesService.cs" company="Abraham Alcaina">
//   Abraham Alcaina
// </copyright>
// <summary>
//   The client files service.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace ECM.Application.Services
{
    using ECM.Application.Routing;
    using ECM.Application.Specifications;
    using ECM.Domain.Entities;
    using ECM.Domain.Specifications;
    using ECM.Infrastructure;

    using Client = ECM.Application.Routing.Client;

    /// <summary>
    ///     The client files service.
    /// </summary>
    internal class ClientFilesService : FileServiceBase
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
        public object Get(Client request)
        {
            var criteria = new FindFileByClient(request.Cid);
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
        public object Get(ClientByType request)
        {
            AndSpecification<File> criteria = new FindFileByClient(request.Cid).And(new FindFileByType(request.Type));
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
        public object Get(ClientByTags request)
        {
            AndSpecification<File> criteria = new FindFileByClient(request.Cid).And(new FindFileByTags(request.Tags));
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
        public object Get(ClientByUpdatedDates request)
        {
            AndSpecification<File> criteria =
                new FindFileByClient(request.Cid).And(new FindFileByLastUpdateRange(request.StartDate, request.EndDate));
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
        public object Get(ClientByDatesFileType request)
        {
            AndSpecification<File> criteria =
                new FindFileByClient(request.Cid).And(
                    new FindFileByReceptionDateRange(request.StartDate, request.EndDate));
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
        public object Get(ClientByUpdatedDatesType request)
        {
            AndSpecification<File> criteria =
                new FindFileByClient(request.Cid).And(
                    new FindFileByReceptionDateRange(request.StartDate, request.EndDate))
                                                 .And(new FindFileByType(request.FileType));
            return this.CreateResponseForFilesByCriteria(request, criteria);
        }

        #endregion
    }
}