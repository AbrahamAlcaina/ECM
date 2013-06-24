// --------------------------------------------------------------------------------------------------------------------
// <copyright file="EntityByDatesFileType.cs" company="Abraham Alcaina">
//   Abraham Alcaina
// </copyright>
// <summary>
//   The entity by dates file type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace ECM.Application.Routing
{
    using ServiceStack.ServiceHost;

    /// <summary>
    ///     The entity by dates file type.
    /// </summary>
    [Route("/api/ecm/files/client/{cid}/entity/{cuid}/from/{startdate}/to/{enddate}/filetype/{type}/")]
    public class EntityByDatesFileType : ClientByDatesFileType
    {
        #region Public Properties

        /// <summary>
        ///     Gets or sets the cuid.
        /// </summary>
        public string Cuid { get; set; }

        #endregion
    }
}