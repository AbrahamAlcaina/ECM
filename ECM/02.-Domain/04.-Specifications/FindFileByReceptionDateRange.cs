// --------------------------------------------------------------------------------------------------------------------
// <copyright file="FindFileByReceptionDateRange.cs" company="Abraham Alcaina">
//   Abraham Alcaina
// </copyright>
// <summary>
//   The find file by reception date range.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace ECM.Domain.Specifications
{
    using System;

    using ECM.Domain.Entities;
    using ECM.Infrastructure;

    /// <summary>
    ///     The find file by reception date range.
    /// </summary>
    internal class FindFileByReceptionDateRange : Specification<File>
    {
        #region Constructors and Destructors

        /// <summary>
        /// Initializes a new instance of the <see cref="FindFileByReceptionDateRange"/> class.
        /// </summary>
        /// <param name="startDate">
        /// The start date.
        /// </param>
        /// <param name="endDate">
        /// The end date.
        /// </param>
        public FindFileByReceptionDateRange(DateTime startDate, DateTime endDate)
            : base(f => f.ReceptionDate >= startDate && f.ReceptionDate <= endDate)
        {
        }

        #endregion
    }
}