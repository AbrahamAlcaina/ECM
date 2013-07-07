// --------------------------------------------------------------------------------------------------------------------
// <copyright file="AppHostTest.cs" company="Abraham Alcaina">
//   Abraham Alcaina
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace ECM.Test._03._Infrastructure
{
    using ECM.Domain.Entities;
    using ECM.Infrastructure.Repositories;
    using ECM.Infrastructure.ServiceStack;

    using MongoRepository;

    using ServiceStack.WebHost.Endpoints;

    using Xunit;

    /// <summary>
    /// The app host test.
    /// </summary>
    public class AppHostTest
    {
        /// <summary>
        /// Test register types in container.
        /// </summary>
        [Fact]
        public void TypesRegisterInContainer()
        {
            // arrange
            var sut = new AppHost();

            // act
            var result = sut.Container.Resolve<IRepository<File>>();
            
            // assert
            Assert.NotNull(result);
            Assert.IsType<FileRepository>(result);
        }
    }
}