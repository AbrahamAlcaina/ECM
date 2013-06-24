// --------------------------------------------------------------------------------------------------------------------
// <copyright file="FileByAlias.cs" company="Abraham Alcaina">
//   Abraham Alcaina
// </copyright>
// <summary>
//   The file by alias.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace ECM.Application.Routing
{
    using ServiceStack.ServiceHost;

    /// <summary>
    ///     The file by alias.
    /// </summary>
    [Route("/api/ecm/files/alias/{aliasName}/")]
    public class FileByAlias
    {
        #region Public Properties

        /// <summary>
        ///     Gets or sets the alias name.
        /// </summary>
        public string AliasName { get; set; }

        #endregion
    }
}