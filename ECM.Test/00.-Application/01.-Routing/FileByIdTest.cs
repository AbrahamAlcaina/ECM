using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECM.Test._00._Application._01._Routing
{
    using ECM.Application.Routing;

    using Xunit;

    public class FileByIdTest
    {
        [Fact]
        public void ToStringWithNullParameter()
        {
            // arrange
            var sut = new FileById();

            // act 
            var result = sut.ToString();

            // assert
            Assert.Equal("Id null", result);
        }

        [Fact]
        public void ToStringWithValue()
        {
            // arrange 
            var id = Guid.NewGuid();
            var sut = new FileById { IdFile = id };

            // act 
            var result = sut.ToString();

            // assert
            Assert.Equal(string.Format("Id: '{0}'", id), result);
        }
    }
}
