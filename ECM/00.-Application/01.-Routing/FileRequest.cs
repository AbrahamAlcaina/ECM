// --------------------------------------------------------------------------------------------------------------------
// <copyright file="FileRequest.cs" company="Abraham Alcaina">
//   Abraham Alcaina
// </copyright>
// <summary>
//   The file request.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace ECM.Application.Routing
{
    using System;

    using ServiceStack.ServiceHost;

    /// <summary>
    ///     The file request.
    /// </summary>
    [Route("/api/ecm/files/{idFile}/")]
    public class FileRequest
    {
        #region Public Properties

        /// <summary>
        ///     Gets or sets the id file.
        /// </summary>
        public Guid IdFile { get; set; }

        #endregion
    }
}