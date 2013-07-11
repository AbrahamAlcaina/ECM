// --------------------------------------------------------------------------------------------------------------------
// <copyright file="FileServiceBaseTest.cs" company="Abraham Alcaina">
//   Abraham Alcaina
// </copyright>
// --------------------------------------------------------------------------------------------------------------------
namespace ECM.Test._00._Application._00._Services
{
    using System.Collections.Specialized;
    using System.Globalization;
    using System.Web;
    using System.Web.Routing;

    using ECM.Application.Services;

    using Moq;

    using ServiceStack.ServiceHost;

    using Xunit;

    /// <summary>
    ///     The file service base test.
    /// </summary>
    public class FileServiceBaseTest
    {
        #region Public Methods and Operators

        /// <summary>
        ///     The create response for single file by criteria.
        /// </summary>
        [Fact]
        public void CreateResponseForSingleFileByCriteriaWithRange()
        {
            // arrange
            const long NumberOfObjectInResponse = 3;
            var mockedRequestContext = new Mock<IRequestContext>();
            var mockedHttpRequest = new Mock<IHttpRequest>();
            var mockedOriginalRequest = new Mock<HttpRequestBase>();
            var mockedOriginalRequestContext = new Mock<RequestContext>();
            var mockedResponse = new Mock<IHttpResponse>();

            mockedOriginalRequest.Setup(x => x.RequestContext).Returns(mockedOriginalRequestContext.Object);
            mockedHttpRequest.Setup(x => x.OriginalRequest).Returns(mockedOriginalRequest.Object);
            mockedHttpRequest.Setup(x => x.Headers).Returns(new NameValueCollection { { "Range", "10" } });
            mockedRequestContext.Setup(f => f.Get<IHttpResponse>()).Returns(mockedResponse.Object);
            mockedRequestContext.Setup(x => x.Get<IHttpRequest>()).Returns(mockedHttpRequest.Object);
            var sut = new FileServiceBase { RequestContext = mockedRequestContext.Object };

            // act
            sut.InsertRangeInResponse(NumberOfObjectInResponse);

            // assert
            mockedResponse.Verify(
                x => x.AddHeader("Content-Range", NumberOfObjectInResponse.ToString(CultureInfo.InvariantCulture) + "/10"));
        }


        /// <summary>
        ///     The create response for single file by criteria.
        /// </summary>
        [Fact]
        public void CreateResponseForSingleFileByCriteriaWithOutRange()
        {
            // arrange
            const long NumberOfObjectInResponse = 3;
            var mockedRequestContext = new Mock<IRequestContext>();
            var mockedHttpRequest = new Mock<IHttpRequest>();
            var mockedOriginalRequest = new Mock<HttpRequestBase>();
            var mockedOriginalRequestContext = new Mock<RequestContext>();
            var mockedResponse = new Mock<IHttpResponse>();

            mockedOriginalRequest.Setup(x => x.RequestContext).Returns(mockedOriginalRequestContext.Object);
            mockedHttpRequest.Setup(x => x.OriginalRequest).Returns(mockedOriginalRequest.Object);
            mockedHttpRequest.Setup(x => x.Headers).Returns(new NameValueCollection { { "Otro", "3" } });
            mockedRequestContext.Setup(f => f.Get<IHttpResponse>()).Returns(mockedResponse.Object);
            mockedRequestContext.Setup(x => x.Get<IHttpRequest>()).Returns(mockedHttpRequest.Object);
            var sut = new FileServiceBase { RequestContext = mockedRequestContext.Object };

            // act
            sut.InsertRangeInResponse(NumberOfObjectInResponse);

            // assert
            mockedResponse.Verify(
                x => x.AddHeader("Content-Range", NumberOfObjectInResponse.ToString(CultureInfo.InvariantCulture)));
        }

        #endregion

        #region Methods
        #endregion
    }
}