// --------------------------------------------------------------------------------------------------------------------
// <copyright file="FindFileByTypeTest.cs" company="Abraham Alcaina">
//   Abraham Alcaina
// </copyright>
// <summary>
//   
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace ECM.Test._02._Domain._04._Specifications
{
    using ECM.Domain.Entities;
    using ECM.Domain.Specifications;

    using Xunit;
    using Xunit.Extensions;

    /// <summary>
    /// The find by client test.
    /// </summary>
    public class FindFileByTypeTest
    {
        /// <summary>
        /// The id to found.
        /// </summary>
        private const string IdToFound = "SLL";

        /// <summary>
        /// The find by client theory.
        /// </summary>
        /// <param name="idFile">
        /// The id client.
        /// </param>
        /// <param name="match">
        /// Is it match with criteria?
        /// </param>
        [Theory]
        [InlineData("WrongFileType", false)]
        [InlineData(IdToFound, true)]
        public void FindByClientTheory(string idFile, bool match)
        {
            // arrange
            var file = new File { Type = new FileType { Id = idFile } };
            var sut = new FindFileByType(IdToFound);

            // assert
            Assert.Equal(match, sut.IsSatisfiedBy().Compile().Invoke(file));
        }
    }
}