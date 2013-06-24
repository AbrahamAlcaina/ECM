// --------------------------------------------------------------------------------------------------------------------
// <copyright file="FindFileByType.cs" company="Abraham Alcaina">
//   Abraham Alcaina
// </copyright>
// <summary>
//   The find file by type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace ECM.Domain.Specifications
{
    using ECM.Domain.Entities;
    using ECM.Infrastructure;

    /// <summary>
    ///     The find file by type.
    /// </summary>
    internal class FindFileByType : Specification<File>
    {
        #region Constructors and Destructors

        /// <summary>
        /// Initializes a new instance of the <see cref="FindFileByType"/> class.
        /// </summary>
        /// <param name="type">
        /// The type.
        /// </param>
        public FindFileByType(string type)
            : base(f => f.Type.Id == type)
        {
        }

        #endregion
    }
}