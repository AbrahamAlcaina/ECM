// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IFileRepository.cs" company="Abraham Alcaina">
//   Abraham Alcaina
// </copyright>
// <summary>
//   The FileRepository interface.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace ECM.Infrastructure.Repositories
{
    using System;
    using System.Linq.Expressions;

    using ECM.Domain.Entities;

    using MongoRepository;

    /// <summary>
    ///     The FileRepository interface.
    /// </summary>
    internal interface IFileRepository : IRepository<File>
    {
        #region Public Methods and Operators

        /// <summary>
        /// The count.
        /// </summary>
        /// <param name="criteria">
        /// The criteria.
        /// </param>
        /// <returns>
        /// The <see cref="long"/>.
        /// </returns>
        long Count(Expression<Func<File, bool>> criteria);

        #endregion
    }
}