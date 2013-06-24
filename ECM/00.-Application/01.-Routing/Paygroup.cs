// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Paygroup.cs" company="Abraham Alcaina">
//   Abraham Alcaina
// </copyright>
// <summary>
//   The paygroup.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace ECM.Application.Routing
{
    using ServiceStack.ServiceHost;

    /// <summary>
    ///     The paygroup.
    /// </summary>
    [Route("/api/ecm/files/client/{cid}/entity/{cuid}/paygroup/{idpaygroup}/")]
    public class Paygroup : Entity
    {
        #region Public Properties

        /// <summary>
        ///     Gets or sets the id paygroup.
        /// </summary>
        public string IdPaygroup { get; set; }

        #endregion
    }
}