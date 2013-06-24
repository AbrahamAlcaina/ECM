// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Entity.cs" company="Abraham Alcaina">
//   Abraham Alcaina
// </copyright>
// <summary>
//   The entity.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace ECM.Application.Routing
{
    using ServiceStack.ServiceHost;

    /// <summary>
    ///     The entity.
    /// </summary>
    [Route("/api/ecm/files/client/{cid}/entity/{cuid}/")]
    public class Entity : Client
    {
        #region Public Properties

        /// <summary>
        ///     Gets or sets the cuid.
        /// </summary>
        public string Cuid { get; set; }

        #endregion
    }
}