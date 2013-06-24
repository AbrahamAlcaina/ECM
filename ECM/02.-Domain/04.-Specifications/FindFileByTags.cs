// --------------------------------------------------------------------------------------------------------------------
// <copyright file="FindFileByTags.cs" company="Abraham Alcaina">
//   Abraham Alcaina
// </copyright>
// <summary>
//   The find file by tags.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace ECM.Domain.Specifications
{
    using System.Collections.Generic;
    using System.Linq;

    using ECM.Domain.Entities;
    using ECM.Infrastructure;

    /// <summary>
    ///     The find file by tags.
    /// </summary>
    internal class FindFileByTags : Specification<File>
    {
        #region Constructors and Destructors

        /// <summary>
        /// Initializes a new instance of the <see cref="FindFileByTags"/> class.
        /// </summary>
        /// <param name="tags">
        /// The tags.
        /// </param>
        public FindFileByTags(ICollection<string> tags)
            : base(f => f.Tags.Any(tags.Contains))
        {
        }

        #endregion
    }
}