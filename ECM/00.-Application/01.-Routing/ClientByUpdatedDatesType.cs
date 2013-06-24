// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ClientByUpdatedDatesType.cs" company="Abraham Alcaina">
//   Abraham Alcaina
// </copyright>
// <summary>
//   The client by updated dates type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace ECM.Application.Routing
{
    using ServiceStack.ServiceHost;

    /// <summary>
    ///     The client by updated dates type.
    /// </summary>
    [Route("/api/ecm/files/client/{cid}/lastupdatefrom/{startdate}/to/{enddate}/filetype/{type}/")]
    public class ClientByUpdatedDatesType : FileByUpdatedDatesType
    {
        #region Public Properties

        /// <summary>
        ///     Gets or sets the cid.
        /// </summary>
        public string Cid { get; set; }

        #endregion
    }
}