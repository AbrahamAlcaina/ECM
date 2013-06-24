// --------------------------------------------------------------------------------------------------------------------
// <copyright file="FileByTagsRequestTest.cs" company="Abraham Alcaina">
//   Abraham Alcaina
// </copyright>
// <summary>
//   The file by tags request test.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace ECM.Test.Application.Routing
{
    using ECM.Application.Routing;

    using Xunit;
    using Xunit.Extensions;

    /// <summary>
    ///     The file by tags request test.
    /// </summary>
    public class FileByTagsRequestTest
    {
        #region Public Methods and Operators

        /// <summary>
        /// The to string one value.
        /// </summary>
        /// <param name="listTag">
        /// The list tag.
        /// </param>
        /// <param name="expected">
        /// The expected.
        /// </param>
        [Theory]
        [InlineData("Tag", "Tag")]
        [InlineData("", "")]
        [InlineData("Tag1+Tag2", "Tag1, Tag2")]
        [InlineData("Tag1+Tag2+", "Tag1, Tag2")]
        [InlineData("+Tag1+Tag2", "Tag1, Tag2")]
        [InlineData("+Tag1+Tag2+", "Tag1, Tag2")]
        public void ToStringOneValue(string listTag, string expected)
        {
            // arrange 
            var sut = new FileByTagsRequest { ListTags = listTag };

            // act 
            string result = sut.ToString();

            // assert
            Assert.Equal(expected, result);
        }

        #endregion
    }
}