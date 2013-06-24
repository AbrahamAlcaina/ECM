// --------------------------------------------------------------------------------------------------------------------
// <copyright file="PaygroupByDates.cs" company="Abraham Alcaina">
//   Abraham Alcaina
// </copyright>
// <summary>
//   The paygroup by dates.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace ECM.Application.Routing
{
    using ServiceStack.ServiceHost;

    /// <summary>
    ///     The paygroup by dates.
    /// </summary>
    [Route("/api/ecm/files/client/{cid}/entity/{cuid}/paygroup/{idPaygroup/from/{startdate}/to/{enddate}/")]
    public class PaygroupByDates : EntityByDates
    {
        #region Public Properties

        /// <summary>
        ///     Gets or sets the id paygroup.
        /// </summary>
        public string IdPaygroup { get; set; }

        #endregion
    }
}