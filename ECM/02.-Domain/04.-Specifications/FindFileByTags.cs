using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ECM.Domain.Entities;
using ECM.Infrastructure;

namespace ECM.Domain.Specifications
{
    internal class FindFileByTags: Specification<File>
    {
        public  FindFileByTags (ICollection<string> tags): base(f => f.Tags.Any(tags.Contains)){}
    }
}
