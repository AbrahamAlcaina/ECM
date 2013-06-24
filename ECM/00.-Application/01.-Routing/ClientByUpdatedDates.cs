// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ClientByUpdatedDates.cs" company="Abraham Alcaina">
//   Abraham Alcaina
// </copyright>
// <summary>
//   The client by updated dates.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace ECM.Application.Routing
{
    using ServiceStack.ServiceHost;

    /// <summary>
    ///     The client by updated dates.
    /// </summary>
    [Route("/api/ecm/files/client/{cid}/lastupdatefrom/{startdate}/to/{enddate}/")]
    public class ClientByUpdatedDates : FileByUpdatedDates
    {
        #region Public Properties

        /// <summary>
        ///     Gets or sets the cid.
        /// </summary>
        public string Cid { get; set; }

        #endregion
    }
}