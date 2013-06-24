// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ProgramTest.cs" company="Abraham Alcaina">
//   Abraham Alcaina
// </copyright>
// <summary>
//   The program test.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace ECM.Test.Application
{
    using Xunit;

    /// <summary>
    ///     The program test.
    /// </summary>
    public class ProgramTest
    {
        #region Public Methods and Operators

        /// <summary>
        ///     The start up.
        /// </summary>
        [Fact]
        public void StartUp()
        {
            // arrange
            string[] args = { "http://localhost:80/" };

            // act
            Program.Main(args);

            // assert
        }

        #endregion
    }
}