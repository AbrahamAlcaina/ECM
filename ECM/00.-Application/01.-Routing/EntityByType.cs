// --------------------------------------------------------------------------------------------------------------------
// <copyright file="EntityByType.cs" company="Abraham Alcaina">
//   Abraham Alcaina
// </copyright>
// <summary>
//   The entity by type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace ECM.Application.Routing
{
    using ServiceStack.ServiceHost;

    /// <summary>
    ///     The entity by type.
    /// </summary>
    [Route("/api/ecm/files/client/{cid}/entity/{cuid}/filetype/{type}/")]
    public class EntityByType : ClientByType
    {
        #region Public Properties

        /// <summary>
        ///     Gets or sets the cuid.
        /// </summary>
        public string Cuid { get; set; }

        #endregion
    }
}