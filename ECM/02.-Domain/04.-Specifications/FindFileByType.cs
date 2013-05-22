using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ECM.Domain.Entities;
using ECM.Infrastructure;

namespace ECM.Domain.Specifications
{
    internal class FindFileByType : Specification<File>
    {
        public FindFileByType(string type): base (f=> f.Type.Id == type){}
    }
}
