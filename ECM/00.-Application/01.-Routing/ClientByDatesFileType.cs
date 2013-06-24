// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ClientByDatesFileType.cs" company="Abraham Alcaina">
//   Abraham Alcaina
// </copyright>
// <summary>
//   The client by dates file type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace ECM.Application.Routing
{
    using ServiceStack.ServiceHost;

    /// <summary>
    ///     The client by dates file type.
    /// </summary>
    [Route("/api/ecm/files/client/{cid}/from/{startdate}/to/{enddate}/filetype/{type}/")]
    public class ClientByDatesFileType : FileByDatesFileType
    {
        #region Public Properties

        /// <summary>
        ///     Gets or sets the cid.
        /// </summary>
        public string Cid { get; set; }

        #endregion
    }
}