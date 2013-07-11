// --------------------------------------------------------------------------------------------------------------------
// <copyright file="FileByTypeTest.cs" company="Abraham Alcaina">
//   Abraham Alcaina
// </copyright>
// --------------------------------------------------------------------------------------------------------------------
namespace ECM.Test._00._Application._01._Routing
{
    using ECM.Application.Routing;

    using Xunit;

    /// <summary>
    ///     The file by type test.
    /// </summary>
    public class FileByTypeTest
    {
        #region Public Methods and Operators

        /// <summary>
        ///     The to string with null parameter.
        /// </summary>
        [Fact]
        public void ToStringWithNullParameter()
        {
            // arrange
            var sut = new FileByType();

            // act 
            string result = sut.ToString();

            // assert
            Assert.Equal("Type null", result);
        }

        /// <summary>
        ///     The to string with value.
        /// </summary>
        [Fact]
        public void ToStringWithValue()
        {
            // arrange             
            const string Type = "SRF";
            var sut = new FileByType { Type = Type };

            // act 
            string result = sut.ToString();

            // assert
            Assert.Equal(string.Format("Type: '{0}'", Type), result);
        }

        #endregion
    }
}