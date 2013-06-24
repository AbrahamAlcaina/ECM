// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Service.cs" company="Abraham Alcaina">
//   Abraham Alcaina
// </copyright>
// <summary>
//   The service.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace ECM.Application.Services
{
    using System.Net;

    using ServiceStack.Common.Web;

    /// <summary>
    ///     Base service for the application
    /// </summary>
    public class Service : ServiceStack.ServiceInterface.Service
    {
        #region Public Methods and Operators

        /// <summary>
        /// The file not found.
        /// </summary>
        /// <param name="target">
        /// The target.
        /// </param>
        /// <returns>
        /// The <see cref="object"/>.
        /// </returns>
        public object FileNotFound(object target)
        {
            return new HttpResult
                       {
                           StatusCode = HttpStatusCode.NotFound, 
                           Response = string.Format("File not found '{0}'", target)
                       };
        }

        /// <summary>
        /// The too many files.
        /// </summary>
        /// <param name="target">
        /// The target.
        /// </param>
        /// <returns>
        /// The <see cref="object"/>.
        /// </returns>
        public object TooManyFiles(object target)
        {
            return new HttpResult
                       {
                           StatusCode = HttpStatusCode.NotFound, 
                           Response = string.Format("Too many files with id '{0}'", target)
                       };
        }

        #endregion
    }
}