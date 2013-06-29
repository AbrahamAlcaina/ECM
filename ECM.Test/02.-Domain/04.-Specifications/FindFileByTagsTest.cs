// --------------------------------------------------------------------------------------------------------------------
// <copyright file="FindFileByTagsTest.cs" company="Abraham Alcaina">
//   Abraham Alcaina
// </copyright>
// --------------------------------------------------------------------------------------------------------------------
namespace ECM.Test._02._Domain._04._Specifications
{
    using System.Collections.Generic;

    using ECM.Domain.Entities;
    using ECM.Domain.Specifications;

    using Xunit;
    using Xunit.Extensions;

    /// <summary>
    ///     The find by client test.
    /// </summary>
    public class FindFileByTagsTest
    {
        #region Constants

        /// <summary>
        ///     The id to found.
        /// </summary>
        private const string TagToFound = "Payroll";

        #endregion

        #region Public Methods and Operators

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
        [InlineData("WrongTag", false)]
        [InlineData(TagToFound, true)]
        public void FindByClientTheory(string idFile, bool match)
        {
            // arrange
            var file = new File { Tags = new List<string> { TagToFound } };
            var sut = new FindFileByTags(new List<string> { idFile });

            // assert
            Assert.Equal(match, sut.IsSatisfiedBy().Compile().Invoke(file));
        }

        #endregion
    }
}