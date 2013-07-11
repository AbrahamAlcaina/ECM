// --------------------------------------------------------------------------------------------------------------------
// <copyright file="MappingsTest.cs" company="Abraham Alcaina">
//   Abraham Alcaina
// </copyright>
// <summary>
//   The mappings test.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace ECM.Test.Application.Mapping
{
    using ECM.Application.Mapping;
    using ECM.Application.Routing;
    using ECM.Domain.Entities;

    using Xunit;

    /// <summary>
    ///     The mappings test.
    /// </summary>
    public class MappingsTest
    {
        #region Public Methods and Operators

        /// <summary>
        ///     The file type mapping.
        /// </summary>
        [Fact]
        public void FileTypeMapping()
        {
            // arrange
            var fileByTypeRequest = new FileByTypeRequest { Type = "SRF" };

            // act 
            FileType result = fileByTypeRequest.ToDto();

            // assert
            Assert.Equal(fileByTypeRequest.Type, result.Id);
        }

        #endregion
    }
}