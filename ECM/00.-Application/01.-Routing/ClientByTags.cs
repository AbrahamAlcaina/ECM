// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ClientByTags.cs" company="Abraham Alcaina">
//   Abraham Alcaina
// </copyright>
// <summary>
//   The client by tags.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace ECM.Application.Routing
{
    using ServiceStack.ServiceHost;

    /// <summary>
    ///     The client by tags.
    /// </summary>
    [Route("/api/ecm/files/client/{cid}/tag/{tag1+...+tagn}/")]
    public class ClientByTags : FileByTags
    {
        #region Public Properties

        /// <summary>
        ///     Gets or sets the cid.
        /// </summary>
        public string Cid { get; set; }

        #endregion
    }
}