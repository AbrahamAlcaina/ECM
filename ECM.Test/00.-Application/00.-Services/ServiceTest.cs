namespace ECM.Test._00._Application._00._Services
{
    using System.Net;

    using ECM.Application.Services;

    using ServiceStack.Common.Web;

    using Xunit;

    public class ServiceTest
    {
        #region Public Methods and Operators

        [Fact]
        public void FileNotFoundWithNullObject()
        {
            // arrange 
            var sut = new Service();

            // act 
            var result = sut.FileNotFound(null) as HttpResult;

            // assert
            Assert.NotNull(result);
            Assert.Equal(HttpStatusCode.NotFound, result.StatusCode);
            Assert.Equal("File not found ''", result.Response);
        }

        [Fact]
        public void FileNotFoundWorksProperly()
        {
            // arrange
            var sut = new Service();
            const string Parameter = "IdFile '123'";

            // act
            var result = sut.FileNotFound(Parameter) as HttpResult;

            // assert
            Assert.NotNull(result);
            Assert.Equal(HttpStatusCode.NotFound, result.StatusCode);
            Assert.Equal(string.Format("File not found '{0}'", Parameter), result.Response);
        }

        [Fact]
        public void TooManyFilesNullObject()
        {
            // arrange 
            var sut = new Service();
            
            // act 
            var result = sut.TooManyFiles(null) as HttpResult;

            // assert
            Assert.NotNull(result);
            Assert.Equal(HttpStatusCode.NotFound, result.StatusCode);
            Assert.Equal("Too many files with id ''", result.Response);
        }

        [Fact]
        public void TooManyFilesWorksProperly()
        {
            // arrange
            var sut = new Service();
            const string Parameter = "IdFile '123'";

            // act
            var result = sut.TooManyFiles(Parameter) as HttpResult;

            // assert
            Assert.NotNull(result);
            Assert.Equal(HttpStatusCode.NotFound, result.StatusCode);
            Assert.Equal(string.Format("Too many files with id '{0}'", Parameter), result.Response);
        }

        #endregion
    }
}