// --------------------------------------------------------------------------------------------------------------------
// <copyright file="PaygroupByUpdatedDatesType.cs" company="Abraham Alcaina">
//   Abraham Alcaina
// </copyright>
// <summary>
//   The paygroup by updated dates type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace ECM.Application.Routing
{
    using ServiceStack.ServiceHost;

    /// <summary>
    ///     The paygroup by updated dates type.
    /// </summary>
    [Route(
        "/api/ecm/files/client/{cid}/entity/{cuid}/paygroup/{idPaygroup/lastupdatefrom/{startdate}/to/{enddate}/filetype/{type}/"
        )]
    public class PaygroupByUpdatedDatesType : EntityByUpdatedDatesType
    {
        #region Public Properties

        /// <summary>
        ///     Gets or sets the id paygroup.
        /// </summary>
        public string IdPaygroup { get; set; }

        #endregion
    }
}