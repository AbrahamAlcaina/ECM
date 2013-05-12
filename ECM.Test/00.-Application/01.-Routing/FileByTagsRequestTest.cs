using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ECM.Application.Routing;
using Xunit;
using Xunit.Extensions;

namespace ECM.Test.Application.Routing
{
    public class FileByTagsRequestTest
    {
        [Theory]
        [InlineData("Tag", "Tag")]
        [InlineData("", "")]
        [InlineData("Tag1+Tag2","Tag1, Tag2")]
        [InlineData("Tag1+Tag2+", "Tag1, Tag2")]
        [InlineData("+Tag1+Tag2", "Tag1, Tag2")]
        [InlineData("+Tag1+Tag2+", "Tag1, Tag2")]
        public void ToStringOneValue(string listTag, string expected)
        {
            // arrange 
            var sut = new FileByTagsRequest {ListTags = listTag};

            // act 
            var result = sut.ToString();

            // assert
            Assert.Equal(expected, result);
        }
    }
}
