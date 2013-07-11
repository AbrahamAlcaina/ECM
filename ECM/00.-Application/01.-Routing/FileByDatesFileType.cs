// --------------------------------------------------------------------------------------------------------------------
// <copyright file="FileByDatesFileType.cs" company="Abraham Alcaina">
//   Abraham Alcaina
// </copyright>
// <summary>
//   The file by dates file type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace ECM.Application.Routing
{
    using ServiceStack.ServiceHost;

    /// <summary>
    ///     The file by dates file type.
    /// </summary>
    [Route("/api/ecm/files/from/{startdate}/to/{enddate}/filetype/{type}/")]
    public class FileByDatesFileType : FileByDates
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
                "File type '{0}'. Received form {1} to {2}", this.FileType, this.StartDate.ToShortDateString(), this.EndDate.ToShortDateString());
        }

        #endregion
    }
}