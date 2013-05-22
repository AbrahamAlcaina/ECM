using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ECM.Domain.Entities;
using ECM.Infrastructure;

namespace ECM.Domain.Specifications
{
    class FindFileById : Specification<File>
    {
        public FindFileById(Guid idFile): base (f => f.FileId == idFile){}
    }
}
