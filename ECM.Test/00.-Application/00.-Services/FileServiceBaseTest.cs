namespace ECM.Test._00._Application._00._Services
{
    using System.Web;
    using System.Web.Routing;

    using ECM.Application.Services;

    using Moq;

    using ServiceStack.Common;
    using ServiceStack.ServiceHost;

    using Xunit;

    public class FileServiceBaseTest
    {
        #region Public Methods and Operators

        [Fact]
        public void CreateResponseForSingleFileByCriteria()
        {
            // arrange
            const long NumberOfObjectInResponse = 3;
            var mockedRequestContext = this.MockedRequestContext();

            var sut = new FileServiceBase { RequestContext = mockedRequestContext.Object };

            // act
            sut.InsertRangeInResponse(NumberOfObjectInResponse);

            // assert
            // TODO Inject http request and define the assert.
        }

        private Mock<IRequestContext> MockedRequestContext()
        {
            var mockedRequestContext = new Mock<IRequestContext>();
            var mockedHttpRequest = new Mock<IHttpRequest>();
            var mockedOriginalRequest = new Mock<HttpRequestBase>();
            var mockedOriginalRequestContext = new Mock<RequestContext>();

            mockedOriginalRequest.Setup(x => x.RequestContext).Returns(mockedOriginalRequestContext.Object);
            mockedHttpRequest.Setup(x => x.OriginalRequest).Returns(mockedOriginalRequest.Object);

            mockedRequestContext.Setup(x => x.Get<IHttpRequest>()).Returns(mockedHttpRequest.Object);

            
            return mockedRequestContext;
        }

        #endregion
    }
}