// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Alias.cs" company="Abraham Alcaina">
//   Abraham Alcaina
// </copyright>
// <summary>
//   The alias.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace ECM.Domain.Entities
{
    /// <summary>
    ///     The alias.
    /// </summary>
    public class Alias
    {
        #region Public Properties

        /// <summary>
        ///     Gets or sets the client.
        /// </summary>
        public Client Client { get; set; }

        /// <summary>
        ///     Gets or sets the name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        ///     Gets or sets the partner.
        /// </summary>
        public Partner Partner { get; set; }

        #endregion
    }
}