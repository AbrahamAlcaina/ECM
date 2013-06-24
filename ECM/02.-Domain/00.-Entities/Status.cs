// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Status.cs" company="Abraham Alcaina">
//   Abraham Alcaina
// </copyright>
// <summary>
//   The status.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace ECM.Domain.Entities
{
    using System;

    /// <summary>
    ///     The status.
    /// </summary>
    public class Status
    {
        #region Public Properties

        /// <summary>
        ///     Gets or sets the date.
        /// </summary>
        public DateTime Date { get; set; }

        /// <summary>
        ///     Gets or sets the file event.
        /// </summary>
        public string FileEvent { get; set; }

        #endregion
    }
}