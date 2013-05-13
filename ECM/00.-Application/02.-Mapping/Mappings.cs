using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ECM.Application.Routing;
using ECM.Domain.Entities;
using ServiceStack.Common;

namespace ECM.Application.Mapping
{
    static class Mappings
    {
        public static FileType ToDto(this FileByTypeRequest file)
        {
            var result = file.TranslateTo<FileType>();
            result.Id = file.Type;
            return result;
        }
    }
}
