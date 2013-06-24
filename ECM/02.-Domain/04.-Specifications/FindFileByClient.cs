// --------------------------------------------------------------------------------------------------------------------
// <copyright file="FindFileByClient.cs" company="Abraham Alcaina">
//   Abraham Alcaina
// </copyright>
// <summary>
//   The find file by client.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace ECM.Application.Specifications
{
    using ECM.Domain.Entities;
    using ECM.Infrastructure;

    /// <summary>
    ///     The find file by client.
    /// </summary>
    internal class FindFileByClient : Specification<File>
    {
        #region Constructors and Destructors

        /// <summary>
        /// Initializes a new instance of the <see cref="FindFileByClient"/> class.
        /// </summary>
        /// <param name="cid">
        /// The cid.
        /// </param>
        public FindFileByClient(string cid)
            : base(f => f.Client.Cid == cid)
        {
        }

        #endregion
    }
}