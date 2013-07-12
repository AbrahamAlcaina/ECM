// --------------------------------------------------------------------------------------------------------------------
// <copyright file="FileServiceBaseTest.cs" company="Abraham Alcaina">
//   Abraham Alcaina
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace ECM.Test._00._Application._00._Services
{
    using System;
    using System.Collections.Generic;
    using System.Collections.Specialized;
    using System.Globalization;
    using System.Linq;
    using System.Linq.Expressions;
    using System.Net;
    using System.Web;
    using System.Web.Routing;

    using ECM.Application.Services;
    using ECM.Domain.Entities;
    using ECM.Infrastructure;

    using MongoRepository;

    using Moq;

    using ServiceStack.Common.Web;
    using ServiceStack.ServiceHost;

    using Xunit;

    /// <summary>
    ///     The file service base test.
    /// </summary>
    public class FileServiceBaseTest
    {
        #region Public Methods and Operators

        [Fact]
        public void CreateResponseForFilesByCriteriaWithOutElements()
        {
            // arrange
            const int NumberOfFiles = 0;
            var repositoryMock = new Mock<IRepository<File>>();
            var files = new List<File> { new File()};
            repositoryMock.SetupIQueryable( files.AsQueryable());
            var specficication = new Specification<File>(x => true);
            var file = new File();
            var sut = new FileServiceBase { Repository = repositoryMock.Object };

            // act
            var result = sut.CreateResponseForSingleFileByCriteria(file, specficication) as HttpResult;

            // assert
            //TODO REVIEW
            Assert.NotNull(result);
            Assert.Equal(result.StatusCode, HttpStatusCode.NotFound);
        }

        /// <summary>
        ///     The create response for single file by criteria.
        /// </summary>
        [Fact]
        public void CreateResponseForSingleFileByCriteriaWithOutRange()
        {
            // arrange
            const long NumberOfObjectInResponse = 3;
            Mock<IHttpRequest> mockedRequest;
            Mock<IHttpResponse> mockedResponse;
            var mockedRequestContext = MockedRequestContext(out mockedRequest, out mockedResponse);
            mockedRequest.Setup(x => x.Headers).Returns(new NameValueCollection { { "Content-Range", "3" } });
            var sut = new FileServiceBase { RequestContext = mockedRequestContext.Object };

            // act
            sut.InsertRangeInResponse(NumberOfObjectInResponse);

            // assert
            mockedResponse.Verify(
                x => x.AddHeader("Content-Range", NumberOfObjectInResponse.ToString(CultureInfo.InvariantCulture)));
        }

        /// <summary>
        ///     The create response for single file by criteria.
        /// </summary>
        [Fact]
        public void CreateResponseForSingleFileByCriteriaWithRange()
        {
            // arrange
            const long NumberOfObjectInResponse = 3;
            Mock<IHttpRequest> mockedRequest;
            Mock<IHttpResponse> mockedResponse;
            Mock<IRequestContext> mockedRequestContext = MockedRequestContext(out mockedRequest, out mockedResponse);
            var sut = new FileServiceBase { RequestContext = mockedRequestContext.Object };

            // act
            sut.InsertRangeInResponse(NumberOfObjectInResponse);

            // assert
            mockedResponse.Verify(
                x =>
                    x.AddHeader(
                        "Content-Range",
                        NumberOfObjectInResponse.ToString(CultureInfo.InvariantCulture) + "/10"));
        }

        #endregion

        #region Methods

        private static Mock<IRequestContext> MockedRequestContext(
            out Mock<IHttpRequest> mockedRequest,
            out Mock<IHttpResponse> mockedResponse)
        {
            mockedRequest = new Mock<IHttpRequest>();
            mockedResponse = new Mock<IHttpResponse>();
            var mockedRequestContext = new Mock<IRequestContext>();
            var mockedOriginalRequest = new Mock<HttpRequestBase>();
            var mockedOriginalRequestContext = new Mock<RequestContext>();

            mockedOriginalRequest.Setup(x => x.RequestContext).Returns(mockedOriginalRequestContext.Object);
            mockedRequest.Setup(x => x.OriginalRequest).Returns(mockedOriginalRequest.Object);
            mockedRequest.Setup(x => x.Headers).Returns(new NameValueCollection { { "Range", "10" } });
            mockedRequestContext.Setup(f => f.Get<IHttpResponse>()).Returns(mockedResponse.Object);
            mockedRequestContext.Setup(x => x.Get<IHttpRequest>()).Returns(mockedRequest.Object);
            return mockedRequestContext;
        }

        #endregion
    }
}