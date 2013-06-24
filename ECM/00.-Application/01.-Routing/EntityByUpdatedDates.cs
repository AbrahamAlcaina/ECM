// --------------------------------------------------------------------------------------------------------------------
// <copyright file="EntityByUpdatedDates.cs" company="Abraham Alcaina">
//   Abraham Alcaina
// </copyright>
// <summary>
//   The entity by updated dates.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace ECM.Application.Routing
{
    using ServiceStack.ServiceHost;

    /// <summary>
    ///     The entity by updated dates.
    /// </summary>
    [Route("/api/ecm/files/client/{cid}/entity/{cuid}/lastupdatefrom/{startdate}/to/{enddate}/")]
    public class EntityByUpdatedDates : ClientByUpdatedDates
    {
        #region Public Properties

        /// <summary>
        ///     Gets or sets the cuid.
        /// </summary>
        public string Cuid { get; set; }

        #endregion
    }
}