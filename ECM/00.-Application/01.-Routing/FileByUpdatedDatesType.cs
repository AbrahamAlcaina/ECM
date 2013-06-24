// --------------------------------------------------------------------------------------------------------------------
// <copyright file="FileByUpdatedDatesType.cs" company="Abraham Alcaina">
//   Abraham Alcaina
// </copyright>
// <summary>
//   The file by updated dates type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace ECM.Application.Routing
{
    using ServiceStack.ServiceHost;

    /// <summary>
    ///     The file by updated dates type.
    /// </summary>
    [Route("/api/ecm/files/lastupdatefrom/{startdate}/to/{enddate}/filetype/{type}/")]
    public class FileByUpdatedDatesType : FileByUpdatedDates
    {
        #region Public Properties

        /// <summary>
        ///     Gets or sets the file type.
        /// </summary>
        public string FileType { get; set; }

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
            return string.Format(
                "File type '{0}'. Updated form {1} to {2}", this.FileType, this.StartDate, this.EndDate);
        }

        #endregion
    }
}