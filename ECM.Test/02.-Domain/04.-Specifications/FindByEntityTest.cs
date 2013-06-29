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
    public class FindByEntityTest
    {
        /// <summary>
        /// The id to found.
        /// </summary>
        private const string IdClientToFound = "200000";

        /// <summary>
        /// The id entity to found.
        /// </summary>
        private const string IdEntityToFound = "100000";

        /// <summary>
        /// The find by entity theory.
        /// </summary>
        /// <param name="idClient">
        /// The id client.
        /// </param>
        /// <param name="idEntity">
        /// The id entity.
        /// </param>
        /// <param name="match">
        /// The match.
        /// </param>
        [Theory]
        [InlineData("IdClientWrong", "IdEntityWrong", false)]
        [InlineData(IdClientToFound, "IdEntityWrong", false)]
        [InlineData("IdClientWrong", IdEntityToFound, false)]
        [InlineData(IdClientToFound, IdEntityToFound, true)]
        public void FindByEntityTheory(string idClient, string idEntity, bool match)
        {
            // arrange
            var file = new File { Client = new Client { Cid = idClient, Cuid = idEntity } };
            var sut = new FindFileByEntity(IdClientToFound, IdEntityToFound);

            // assert
            Assert.Equal(match, sut.IsSatisfiedBy().Compile().Invoke(file));
        }
    }
}