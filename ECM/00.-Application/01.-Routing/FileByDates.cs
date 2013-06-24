// --------------------------------------------------------------------------------------------------------------------
// <copyright file="FileByDates.cs" company="Abraham Alcaina">
//   Abraham Alcaina
// </copyright>
// <summary>
//   The file by dates.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace ECM.Application.Routing
{
    using System;

    using ServiceStack.ServiceHost;

    /// <summary>
    ///     The file by dates.
    /// </summary>
    [Route("/api/ecm/files/from/{startdate}/to/{enddate}/")]
    public class FileByDates
    {
        #region Public Properties

        /// <summary>
        ///     Gets or sets the end date.
        /// </summary>
        public DateTime EndDate { get; set; }

        /// <summary>
        ///     Gets or sets the start date.
        /// </summary>
        public DateTime StartDate { get; set; }

        #endregion
    }
}