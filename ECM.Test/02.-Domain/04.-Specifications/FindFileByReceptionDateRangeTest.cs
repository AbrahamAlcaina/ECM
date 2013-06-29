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
    public class FindFileByReceptionDateRangeTest
    {
        /// <summary>
        /// The id to found.
        /// </summary>
        private const string DateUpdated = "2012/12/31";

        /// <summary>
        /// The find by client theory.
        /// </summary>
        /// <param name="initialDate">
        /// The initial date.
        /// </param>
        /// <param name="finalDate">
        /// The final date.
        /// </param>
        /// <param name="match">
        /// The match.
        /// </param>
        [Theory]
        [InlineData("2012/01/01", "2012/02/28", false)]
        [InlineData("2013/01/02", "2013/02/28", false)]
        [InlineData("2012/01/02", "2013/02/28", true)]
        [InlineData("2012/12/31", "2013/02/28", true)]
        [InlineData("2012/12/30", "2012/12/31", true)]
        [InlineData("2012/12/31", "2012/12/30", false)]
        [InlineData("2012/12/31", "2012/12/30", false)]
        public void FindByClientTheory(string initialDate, string finalDate, bool match)
        {
            // arrange
            var file = new File { ReceptionDate = DateTime.Parse(DateUpdated) };
            var sut = new FindFileByReceptionDateRange(DateTime.Parse(initialDate), DateTime.Parse(finalDate));

            // assert
            Assert.Equal(match, sut.IsSatisfiedBy().Compile().Invoke(file));
        }
    }
}