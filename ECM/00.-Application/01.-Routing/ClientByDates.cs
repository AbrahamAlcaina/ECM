// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ClientByDates.cs" company="Abraham Alcaina">
//   Abraham Alcaina
// </copyright>
// <summary>
//   The client by dates.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace ECM.Application.Routing
{
    using ServiceStack.ServiceHost;

    /// <summary>
    ///     The client by dates.
    /// </summary>
    [Route("/api/ecm/files/client/{cid}/from/{startdate}/to/{enddate}/")]
    public class ClientByDates : FileByDates
    {
        #region Public Properties

        /// <summary>
        ///     Gets or sets the cid.
        /// </summary>
        public string Cid { get; set; }

        #endregion
    }
}