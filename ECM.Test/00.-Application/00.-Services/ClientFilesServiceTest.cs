// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ClientFilesServiceTest.cs" company="Abraham Alcaina">
//   Abraham Alcaina
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace ECM.Test._00._Application._00._Services
{
    using ECM.Application.Routing;
    using ECM.Application.Services;

    using Moq;

    using Xunit;

    /// <summary>
    /// The client files service test.
    /// </summary>
    public class ClientFilesServiceTest
    {
        /// <summary>
        /// Test get with a null client.
        /// </summary>
        [Fact]
        public void GetWithNullClient()
        {
            // arrange 
            var sut = new Mock<ClientFilesService>();
            var request = new Client();

            // act
            var result = sut.Object.Get(request);

            // assert
            Assert.Null(result);
        }
    }
}