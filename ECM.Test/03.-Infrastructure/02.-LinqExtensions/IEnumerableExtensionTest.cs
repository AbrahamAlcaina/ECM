// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IEnumerableExtensionTest.cs" company="Abraham Alcaina">
//   Abraham Alcaina
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace ECM.Test._03._Infrastructure._02._LinqExtensions
{
    using System.Collections.Generic;

    using Xunit;

    /// <summary>
    /// The enumerable extension test.
    /// </summary>
    public class EnumerableExtensionTest
    {
        #region Public Methods and Operators

        /// <summary>
        /// The for each test.
        /// </summary>
        [Fact]
        public void ForEachTest()
        {
            // arrange
            var list = new List<int> { 1, 2, 3 };
            int result = 0;

            // act
            list.ForEach(i => result += i);

            // assert
            Assert.Equal(6, result);
        }

        #endregion
    }
}