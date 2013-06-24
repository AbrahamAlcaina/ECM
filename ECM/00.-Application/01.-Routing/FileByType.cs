// --------------------------------------------------------------------------------------------------------------------
// <copyright file="FileByType.cs" company="Abraham Alcaina">
//   Abraham Alcaina
// </copyright>
// <summary>
//   The file by type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace ECM.Application.Routing
{
    using ServiceStack.ServiceHost;

    /// <summary>
    ///     The file by type.
    /// </summary>
    [Route("/api/ecm/files/filetype/{type}/")]
    public class FileByType
    {
        #region Public Properties

        /// <summary>
        ///     Gets or sets the type.
        /// </summary>
        public string Type { get; set; }

        #endregion

        #region Public Methods and Operators

        /// <summary>
        ///     The to string.
        /// </summary>
        /// <returns>
        ///     The <see cref="string" />.
        /// </returns>
        public override string ToString()
        {
            return string.Format("Type: '{0}'", this.Type);
        }

        #endregion
    }
}