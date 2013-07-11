// --------------------------------------------------------------------------------------------------------------------
// <copyright file="FileByDatesFileTypeTest.cs" company="Abraham Alcaina">
//   Abraham Alcaina
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace ECM.Test._00._Application._01._Routing
{
    using System;

    using ECM.Application.Routing;

    using Xunit;
    using Xunit.Extensions;

    /// <summary>
    /// The file by dates file type test.
    /// </summary>
    public class FileByDatesFileTypeTest
    {
        #region Public Methods and Operators

        /// <summary>
        /// The to string works properly.
        /// </summary>
        /// <param name="type">
        /// The type.
        /// </param>
        /// <param name="startDate">
        /// The start date.
        /// </param>
        /// <param name="endDate">
        /// The end date.
        /// </param>
        /// <param name="expected">
        /// The expected.
        /// </param>
        [Theory]
        [InlineData("SRF", "2013/01/01", "2013/01/20", "File type 'SRF'. Received form 01/01/2013 to 20/01/2013")]
        public void ToStringWorksProperly(string type, string startDate, string endDate, string expected)
        {
            // arrange
            var sut = new FileByDatesFileType
                          {
                              FileType = type, 
                              StartDate = DateTime.Parse(startDate), 
                              EndDate = DateTime.Parse(endDate)
                          };

            // act
            string result = sut.ToString();

            // assert
            Assert.Equal(expected, result);
        }

        #endregion
    }
}