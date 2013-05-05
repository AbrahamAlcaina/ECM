using System;
using System.Collections.Generic;
using MongoRepository;

namespace ECM.Domain.Entities
{
    public class File : Entity
    {
        public string ClientName { get; set; }
        public string PartnerName { get; set; }
        public DateTime ReceptionDate { get; set; }
        public DateTime LastUpdateTime { get; set; }
        public object Hash { get; set; }
        public Mode Mode { get; set; }
        public FileType Type { get; set; }
        public IEnumerable<Comment> Comments { get; set; }
        public Client Client { get; set; }
        public Partner Partner { get; set; }
        public Guid ParentId { get; set; }
        public IEnumerable<Status> Statuses { get; set; }
        public IEnumerable<string> Tags { get; set; }
        public IEnumerable<Alias> Aliases { get; set; }
    }
}