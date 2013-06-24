// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ClientByType.cs" company="Abraham Alcaina">
//   Abraham Alcaina
// </copyright>
// <summary>
//   The client by type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace ECM.Application.Routing
{
    using ServiceStack.ServiceHost;

    /// <summary>
    ///     The client by type.
    /// </summary>
    [Route("/api/ecm/files/client/{cid}/filetype/{type}/")]
    public class ClientByType : FileByType
    {
        #region Public Properties

        /// <summary>
        ///     Gets or sets the cid.
        /// </summary>
        public string Cid { get; set; }

        #endregion
    }
}