// --------------------------------------------------------------------------------------------------------------------
// <copyright file="PaygroupByTag.cs" company="Abraham Alcaina">
//   Abraham Alcaina
// </copyright>
// <summary>
//   The paygroup by tag.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace ECM.Application.Routing
{
    using ServiceStack.ServiceHost;

    /// <summary>
    ///     The paygroup by tag.
    /// </summary>
    [Route("/api/ecm/files/client/{cid}/entity/{cuid}/paygroup/{idPaygroup/tag/{tag1+...+tagn}/")]
    public class PaygroupByTag : EntityByTags
    {
        #region Public Properties

        /// <summary>
        ///     Gets or sets the id paygroup.
        /// </summary>
        public string IdPaygroup { get; set; }

        #endregion
    }
}