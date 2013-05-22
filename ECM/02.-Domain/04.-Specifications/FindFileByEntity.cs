using ECM.Domain.Entities;
using ECM.Infrastructure;

namespace ECM.Application.Specifications
{
    internal  class FindFileByEntity : Specification<File>
    {
        public  FindFileByEntity(string cid, string cuid) 
            : base (f => f.Client.Cid == cid && f.Client.Cuid == cuid){}
    }
}