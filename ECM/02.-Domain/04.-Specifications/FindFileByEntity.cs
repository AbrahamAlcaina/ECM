// --------------------------------------------------------------------------------------------------------------------
// <copyright file="FindFileByEntity.cs" company="Abraham Alcaina">
//   Abraham Alcaina
// </copyright>
// <summary>
//   The find file by entity.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace ECM.Application.Specifications
{
    using ECM.Domain.Entities;
    using ECM.Infrastructure;

    /// <summary>
    ///     The find file by entity.
    /// </summary>
    internal class FindFileByEntity : Specification<File>
    {
        #region Constructors and Destructors

        /// <summary>
        /// Initializes a new instance of the <see cref="FindFileByEntity"/> class.
        /// </summary>
        /// <param name="cid">
        /// The cid.
        /// </param>
        /// <param name="cuid">
        /// The cuid.
        /// </param>
        public FindFileByEntity(string cid, string cuid)
            : base(f => f.Client.Cid == cid && f.Client.Cuid == cuid)
        {
        }

        #endregion
    }
}