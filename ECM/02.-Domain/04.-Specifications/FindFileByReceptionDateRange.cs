using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ECM.Domain.Entities;
using ECM.Infrastructure;

namespace ECM.Domain.Specifications
{
    internal class FindFileByReceptionDateRange: Specification<File>
    {
        public FindFileByReceptionDateRange(DateTime startDate, DateTime endDate) 
            : base(f => f.ReceptionDate >= startDate && f.ReceptionDate <= endDate) { }
    }
}
