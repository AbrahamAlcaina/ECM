// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Client.cs" company="Abraham Alcaina">
//   Abraham Alcaina
// </copyright>
// <summary>
//   The client.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace ECM.Application.Routing
{
    using ServiceStack.ServiceHost;

    /// <summary>
    ///     The client.
    /// </summary>
    [Route("/api/ecm/files/client/{cid}/")]
    public class Client
    {
        #region Public Properties

        /// <summary>
        ///     Gets or sets the cid.
        /// </summary>
        public string Cid { get; set; }

        #endregion
    }
}