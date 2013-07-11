// --------------------------------------------------------------------------------------------------------------------
// <copyright file="FindByClientTest.cs" company="Abraham Alcaina">
//   Abraham Alcaina
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace ECM.Test._02._Domain._04._Specifications
{
    using System;

    using ECM.Domain.Entities;
    using ECM.Domain.Specifications;

    using Xunit;
    using Xunit.Extensions;

    /// <summary>
    /// The find by client test.
    /// </summary>
    public class FindByIdTest
    {
        /// <summary>
        /// The id to found.
        /// </summary>
        private const string IdToFound = "8EC498A8-474D-4B71-B5EE-1E49EE60B89E";


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
        [InlineData("7FD7D929-CF88-4E0A-A730-6E9B8118D44A", false)]
        [InlineData(IdToFound, true)]
        public void FindByClientTheory(string idFile, bool match)
        {
            // arrange
            var file = new File { FileId = new Guid(idFile) };
            var sut = new FindFileById(new Guid(IdToFound));

            // assert
            Assert.Equal(match, sut.IsSatisfiedBy().Compile().Invoke(file));
        }
    }
}