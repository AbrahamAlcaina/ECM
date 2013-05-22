<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ECM.Application.Routing;
=======
﻿using ECM.Application.Routing;
>>>>>>> Refactoring using Specifications
using ECM.Domain.Entities;
using ServiceStack.Common;

namespace ECM.Application.Mapping
{
    static class Mappings
    {
<<<<<<< HEAD
        public static FileType ToDto(this FileByTypeRequest file)
=======
        public static FileType ToDto(this FileByType file)
>>>>>>> Refactoring using Specifications
        {
            var result = file.TranslateTo<FileType>();
            result.Id = file.Type;
            return result;
        }
    }
}
