// --------------------------------------------------------------------------------------------------------------------
// <copyright file="EntityByTags.cs" company="Abraham Alcaina">
//   Abraham Alcaina
// </copyright>
// <summary>
//   The entity by tags.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace ECM.Application.Routing
{
    using ServiceStack.ServiceHost;

    /// <summary>
    ///     The entity by tags.
    /// </summary>
    [Route("/api/ecm/files/client/{cid}/entity/{cuid}/tag/{tag1+...+tagn}/")]
    public class EntityByTags : ClientByTags
    {
        #region Public Properties

        /// <summary>
        ///     Gets or sets the cuid.
        /// </summary>
        public string Cuid { get; set; }

        #endregion
    }
}