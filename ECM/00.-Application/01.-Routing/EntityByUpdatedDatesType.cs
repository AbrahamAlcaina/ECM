// --------------------------------------------------------------------------------------------------------------------
// <copyright file="EntityByUpdatedDatesType.cs" company="Abraham Alcaina">
//   Abraham Alcaina
// </copyright>
// <summary>
//   The entity by updated dates type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace ECM.Application.Routing
{
    using ServiceStack.ServiceHost;

    /// <summary>
    ///     The entity by updated dates type.
    /// </summary>
    [Route("/api/ecm/files/client/{cid}/entity/{cuid}/lastupdatefrom/{startdate}/to/{enddate}/filetype/{type}/")]
    public class EntityByUpdatedDatesType : ClientByUpdatedDatesType
    {
        #region Public Properties

        /// <summary>
        ///     Gets or sets the cuid.
        /// </summary>
        public string Cuid { get; set; }

        #endregion
    }
}