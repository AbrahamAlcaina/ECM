﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="FileByUpdatedDatesTypeTest.cs" company="Abraham Alcaina">
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
    /// The file by updated dates type test.
    /// </summary>
    public class FileByUpdatedDatesTypeTest
    {
        /// <summary>
        /// The to string.
        /// </summary>
        /// <param name="type">
        /// The type.
        /// </param>
        /// <param name="startDate">
        /// The start Date.
        /// </param>
        /// <param name="endDate">
        /// The end Date.
        /// </param>
        /// <param name="expected">Expected result for the test</param>
        [Theory]
        [InlineData("SRF", "2013/01/01", "2013/01/20", "File type 'SRF'. Updated form 01/01/2013 to 20/01/2013")]
        public void ToStringWorksProperly(string type, string startDate, string endDate, string expected)
        {
            // arrange
            var sut = new FileByUpdatedDatesType
                          {
                              FileType = type,
                              StartDate = DateTime.Parse(startDate),
                              EndDate = DateTime.Parse(endDate)
                          };

            // act
            var result = sut.ToString();

            // assert
            Assert.Equal(expected, result); 
        }
    }
}