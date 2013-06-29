// --------------------------------------------------------------------------------------------------------------------
// <copyright file="FindByClientTest.cs" company="Abraham Alcaina">
//   Abraham Alcaina
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace ECM.Test._02._Domain._04._Specifications
{
    using ECM.Application.Specifications;
    using ECM.Domain.Entities;

    using Xunit;
    using Xunit.Extensions;

    /// <summary>
    /// The find by client test.
    /// </summary>
    public class FindByClientTest
    {
        /// <summary>
        /// The id to found.
        /// </summary>
        private const string IdToFound = "000000";

        /// <summary>
        /// The find by client theory.
        /// </summary>
        /// <param name="idClient">
        /// The id client.
        /// </param>
        /// <param name="match">
        /// Is it match with criteria?
        /// </param>
        [Theory]
        [InlineData("IdToNoMatchWithCriteria", false)]
        [InlineData(IdToFound, true)]
        public void FindByClientTheory(string idClient, bool match)
        {
            // arrange
            var file = new File { Client = new Client { Cid = idClient } };
            var sut = new FindFileByClient(IdToFound);

            // assert
            Assert.Equal(match, sut.IsSatisfiedBy().Compile().Invoke(file));
        }
    }
}