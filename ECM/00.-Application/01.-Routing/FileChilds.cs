// --------------------------------------------------------------------------------------------------------------------
// <copyright file="FileChilds.cs" company="Abraham Alcaina">
//   Abraham Alcaina
// </copyright>
// <summary>
//   The file childs.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace ECM.Application.Routing
{
    using ServiceStack.ServiceHost;

    /// <summary>
    ///     The file childs.
    /// </summary>
    [Route("/api/ecm/files/chid/{idFile}/")]
    public class FileChilds : FileRequest
    {
    }
}