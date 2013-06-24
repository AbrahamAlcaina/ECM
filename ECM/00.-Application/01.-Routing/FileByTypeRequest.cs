// --------------------------------------------------------------------------------------------------------------------
// <copyright file="FileByTypeRequest.cs" company="Abraham Alcaina">
//   Abraham Alcaina
// </copyright>
// <summary>
//   The file by type request.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace ECM.Application.Routing
{
    using ServiceStack.ServiceHost;

    /// <summary>
    ///     The file by type request.
    /// </summary>
    [Route("/api/ecm/files/filetype/{type}/")]
    public class FileByTypeRequest
    {
        #region Public Properties

        /// <summary>
        ///     Gets or sets the type.
        /// </summary>
        public string Type { get; set; }

        #endregion
    }
}