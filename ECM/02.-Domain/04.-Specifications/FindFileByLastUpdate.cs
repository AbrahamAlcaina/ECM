using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ECM.Domain.Entities;
using ECM.Infrastructure;

namespace ECM.Domain.Specifications
{
    internal class FindFileByLastUpdateRange: Specification<File>
    {
        public FindFileByLastUpdateRange(DateTime startDate, DateTime endDate) : 
            base(f => f.LastUpdateTime >= startDate && f.LastUpdateTime <= endDate) { }
    }
}
