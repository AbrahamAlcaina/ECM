using ECM.Domain.Entities;
using ECM.Infrastructure;

namespace ECM.Application.Specifications
{
    internal  class FindFileByClient : Specification<File>
    {
        public FindFileByClient(string cid) 
            : base (f => f.Client.Cid == cid){}
    }
}