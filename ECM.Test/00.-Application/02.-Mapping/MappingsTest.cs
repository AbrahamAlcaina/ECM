using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ECM.Application.Routing;
using ECM.Application.Mapping;
using Xunit;

namespace ECM.Test.Application.Mapping
{
    class MappingsTest
    {
        [Fact]
        public void FileTypeMapping()
        {
            // arrange
            var fileByTypeRequest = new FileByTypeRequest
                {
                    Type = "SRF"
                };

            // act 
            var result = fileByTypeRequest.ToDto();

            // assert
            Assert.Equal(fileByTypeRequest.Type, result.Id);
        }
    }
}
