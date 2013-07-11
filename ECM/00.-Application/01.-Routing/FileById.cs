// --------------------------------------------------------------------------------------------------------------------
// <copyright file="FileById.cs" company="Abraham Alcaina">
//   Abraham Alcaina
// </copyright>
// <summary>
//   The file by id.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace ECM.Application.Routing
{
    using System;

    using ServiceStack.ServiceHost;

    /// <summary>
    ///     The file by id.
    /// </summary>
    [Route("/api/ecm/files/{idFile}/")]
    public class FileById
    {
        #region Public Properties

        /// <summary>
        ///     Gets or sets the id file.
        /// </summary>
        public Guid IdFile { get; set; }

        #endregion

        #region Public Methods and Operators

        /// <summary>
        ///     The to string.
        /// </summary>
        /// <returns>
        ///     The <see cref="string" />.
        /// </returns>
        public override string ToString()
        {
            return this.IdFile == default(Guid) ? "Id null" : string.Format("Id: '{0}'", this.IdFile);
        }

        #endregion
    }
}