// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Mappings.cs" company="Abraham Alcaina">
//   Abraham Alcaina
// </copyright>
// <summary>
//   The mappings.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace ECM.Application.Mapping
{
    using ECM.Application.Routing;
    using ECM.Domain.Entities;

    using ServiceStack.Common;

    /// <summary>
    ///     The mappings.
    /// </summary>
    internal static class Mappings
    {
        #region Public Methods and Operators

        /// <summary>
        /// Transform a file to DTO.
        /// </summary>
        /// <param name="file">
        /// The file.
        /// </param>
        /// <returns>
        /// The <see cref="FileType"/>.
        /// </returns>
        public static FileType ToDto(this FileByTypeRequest file)
        {
            var result = file.TranslateTo<FileType>();
            result.Id = file.Type;
            return result;
        }

        #endregion
    }
}