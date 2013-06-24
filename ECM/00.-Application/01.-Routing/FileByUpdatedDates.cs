// --------------------------------------------------------------------------------------------------------------------
// <copyright file="FileByUpdatedDates.cs" company="Abraham Alcaina">
//   Abraham Alcaina
// </copyright>
// <summary>
//   The file by updated dates.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace ECM.Application.Routing
{
    using System;

    using ServiceStack.ServiceHost;

    /// <summary>
    ///     The file by updated dates.
    /// </summary>
    [Route("/api/ecm/files/lastupdatefrom/{startdate}/to/{enddate}/")]
    public class FileByUpdatedDates
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