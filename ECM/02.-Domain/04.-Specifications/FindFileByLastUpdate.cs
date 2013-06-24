// --------------------------------------------------------------------------------------------------------------------
// <copyright file="FindFileByLastUpdate.cs" company="Abraham Alcaina">
//   Abraham Alcaina
// </copyright>
// <summary>
//   The find file by last update range.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace ECM.Domain.Specifications
{
    using System;

    using ECM.Domain.Entities;
    using ECM.Infrastructure;

    /// <summary>
    ///     The find file by last update range.
    /// </summary>
    internal class FindFileByLastUpdateRange : Specification<File>
    {
        #region Constructors and Destructors

        /// <summary>
        /// Initializes a new instance of the <see cref="FindFileByLastUpdateRange"/> class.
        /// </summary>
        /// <param name="startDate">
        /// The start date.
        /// </param>
        /// <param name="endDate">
        /// The end date.
        /// </param>
        public FindFileByLastUpdateRange(DateTime startDate, DateTime endDate)
            : base(f => f.LastUpdateTime >= startDate && f.LastUpdateTime <= endDate)
        {
        }

        #endregion
    }
}