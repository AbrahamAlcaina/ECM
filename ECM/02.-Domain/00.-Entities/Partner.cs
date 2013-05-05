using System;

namespace ECM.Domain.Entities
{
    public class Partner
    {
        public Guid PartnerId { get; set; }
        public string Pid { get; set; }
        public string Lid { get; set; }
        public string Paygroup { get; set; }
    }
}