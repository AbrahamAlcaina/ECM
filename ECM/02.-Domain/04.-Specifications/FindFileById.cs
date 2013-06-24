// --------------------------------------------------------------------------------------------------------------------
// <copyright file="FindFileById.cs" company="Abraham Alcaina">
//   Abraham Alcaina
// </copyright>
// <summary>
//   The find file by id.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace ECM.Domain.Specifications
{
    using System;

    using ECM.Domain.Entities;
    using ECM.Infrastructure;

    /// <summary>
    ///     The find file by id.
    /// </summary>
    internal class FindFileById : Specification<File>
    {
        #region Constructors and Destructors

        /// <summary>
        /// Initializes a new instance of the <see cref="FindFileById"/> class.
        /// </summary>
        /// <param name="idFile">
        /// The id file.
        /// </param>
        public FindFileById(Guid idFile)
            : base(f => f.FileId == idFile)
        {
        }

        #endregion
    }
}