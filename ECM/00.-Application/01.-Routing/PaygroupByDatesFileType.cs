// --------------------------------------------------------------------------------------------------------------------
// <copyright file="PaygroupByDatesFileType.cs" company="Abraham Alcaina">
//   Abraham Alcaina
// </copyright>
// <summary>
//   The paygroup by dates file type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace ECM.Application.Routing
{
    using ServiceStack.ServiceHost;

    /// <summary>
    ///     The paygroup by dates file type.
    /// </summary>
    [Route(
        "/api/ecm/files/client/{cid}/entity/{cuid}/paygroup/{idPaygroup/from/{startdate}/to/{enddate}/filetype/{type}/")
    ]
    public class PaygroupByDatesFileType : EntityByDatesFileType
    {
        #region Public Properties

        /// <summary>
        ///     Gets or sets the id paygroup.
        /// </summary>
        public string IdPaygroup { get; set; }

        #endregion
    }
}