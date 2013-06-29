// --------------------------------------------------------------------------------------------------------------------
// <copyright file="FileRepository.cs" company="Abraham Alcaina">
//   Abraham Alcaina
// </copyright>
// <summary>
//   The file repository.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace ECM.Infrastructure.Repositories
{
    using System;
    using System.Linq;
    using System.Linq.Expressions;

    using ECM.Domain.Entities;

    using MongoRepository;

    /// <summary>
    ///     The file repository.
    /// </summary>
    internal class FileRepository : MongoRepository<File>
    {

    }
}