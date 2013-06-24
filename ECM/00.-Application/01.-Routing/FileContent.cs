// --------------------------------------------------------------------------------------------------------------------
// <copyright file="FileContent.cs" company="Abraham Alcaina">
//   Abraham Alcaina
// </copyright>
// <summary>
//   The file content.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace ECM.Application.Routing
{
    using ServiceStack.ServiceHost;

    /// <summary>
    ///     The file content.
    /// </summary>
    [Route("/api/ecm/files/{idFile}/content/")]
    public class FileContent : FileById
    {
    }
}