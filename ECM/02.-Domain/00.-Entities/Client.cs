// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Client.cs" company="Abraham Alcaina">
//   Abraham Alcaina
// </copyright>
// <summary>
//   The client.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace ECM.Domain.Entities
{
    /// <summary>
    ///     The client.
    /// </summary>
    public class Client
    {
        #region Public Properties

        /// <summary>
        ///     Gets or sets the cid.
        /// </summary>
        public string Cid { get; set; }

        /// <summary>
        ///     Gets or sets the cuid.
        /// </summary>
        public string Cuid { get; set; }

        /// <summary>
        ///     Gets or sets the paygroup.
        /// </summary>
        public string Paygroup { get; set; }

        #endregion
    }
}