// --------------------------------------------------------------------------------------------------------------------
// <copyright file="FileService.cs" company="Abraham Alcaina">
//   Abraham Alcaina
// </copyright>
// <summary>
//   The file service.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace ECM.Application.Services
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using ECM.Application.Routing;
    using ECM.Domain.Entities;
    using ECM.Domain.Specifications;
    using ECM.Infrastructure;

    using ServiceStack.Common.Web;

    /// <summary>
    ///     The file service.
    /// </summary>
    internal class FileService : FileServiceBase
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
        public object Get(FileById request)
        {
            var criteria = new FindFileById(request.IdFile);
            return this.CreateResponseForSingleFileByCriteria(request, criteria);
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
        public object Get(FileByType request)
        {
            var criteria = new FindFileByType(request.Type);
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
        public object Get(FileByTags request)
        {
            var criteria = new FindFileByTags(request.Tags);
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
        public object Get(FileChilds request)
        {
            var criteria = new Specification<File>(f => f.ParentId == request.IdFile);
            return this.CreateResponseForFilesByCriteria(request, criteria);
        }

        /// <summary>
        /// The get.
        /// </summary>
        /// <param name="file">
        /// The file.
        /// </param>
        /// <returns>
        /// The <see cref="object"/>.
        /// </returns>
        public object Get(FileByUpdatedDates file)
        {
            List<File> files =
                this.Repository.All(f => f.LastUpdateTime >= file.StartDate && f.LastUpdateTime <= file.EndDate)
                    .ToList();
            return files.Count == 0 ? FileNotFound(file) : files;
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
        public object Get(FileByDatesFileType request)
        {
            AndSpecification<File> criteria =
                new FindFileByReceptionDateRange(request.StartDate, request.EndDate).And(
                    new FindFileByType(request.FileType));
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
        public object Get(FileByUpdatedDatesType request)
        {
            AndSpecification<File> criteria =
                new FindFileByLastUpdateRange(request.StartDate, request.EndDate).And(
                    new FindFileByType(request.FileType));
            return this.CreateResponseForFilesByCriteria(request, criteria);
        }

        /// <summary>
        /// The post.
        /// </summary>
        /// <param name="file">
        /// The file.
        /// </param>
        /// <returns>
        /// The <see cref="object"/>.
        /// </returns>
        public object Post(FileCreationRequest file)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// The post.
        /// </summary>
        /// <param name="file">
        /// The file.
        /// </param>
        /// <returns>
        /// The <see cref="object"/>.
        /// </returns>
        public object Post(FileCreation file)
        {
            var fileResponse = file.ToResponseDto<File>();
            this.Repository.Add(fileResponse);
            return fileResponse;
        }

        #endregion
    }
}