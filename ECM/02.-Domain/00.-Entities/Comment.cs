using System;

namespace ECM.Domain.Entities
{
    public class Comment
    {
        public Guid Id { get; set; }
        public DateTime Date { get; set; }
        public string User { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
    }
}