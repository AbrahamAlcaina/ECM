// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Partner.cs" company="Abraham Alcaina">
//   Abraham Alcaina
// </copyright>
// <summary>
//   The partner.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace ECM.Domain.Entities
{
    using System;

    /// <summary>
    ///     The partner.
    /// </summary>
    public class Partner
    {
        #region Public Properties

        /// <summary>
        ///     Gets or sets the lid.
        /// </summary>
        public string Lid { get; set; }

        /// <summary>
        ///     Gets or sets the partner id.
        /// </summary>
        public Guid PartnerId { get; set; }

        /// <summary>
        ///     Gets or sets the pay group.
        /// </summary>
        public string Paygroup { get; set; }

        /// <summary>
        ///     Gets or sets the pid.
        /// </summary>
        public string Pid { get; set; }

        #endregion
    }
}