// --------------------------------------------------------------------------------------------------------------------
// <copyright file="EntityByDates.cs" company="Abraham Alcaina">
//   Abraham Alcaina
// </copyright>
// <summary>
//   The entity by dates.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace ECM.Application.Routing
{
    using ServiceStack.ServiceHost;

    /// <summary>
    ///     The entity by dates.
    /// </summary>
    [Route("/api/ecm/files/client/{cid}/entity/{cuid}/from/{startdate}/to/{enddate}/")]
    public class EntityByDates : ClientByDates
    {
        #region Public Properties

        /// <summary>
        ///     Gets or sets the cuid.
        /// </summary>
        public string Cuid { get; set; }

        #endregion
    }
}