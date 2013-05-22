using System;
using System.Collections.Generic;
using ECM.Domain.Entities;
using ServiceStack.ServiceHost;

namespace ECM.Application.Routing
{
    [Route("/api/ecm/files/",Verbs = "POST")]
    public class FileCreation
    {
        public Guid Id { get; set; }
        public string NameClient { get; set; }
        public string NamePartner { get; set; }
        public IEnumerable<Alias> Alias { get; set; }
        public FileType Type { get; set; }
        public IEnumerable<Comment> Comments { get; set; }
        public Client Client { get; set; }
        public Partner Partner { get; set; }
        public DateTime ReceptionDate { get; set; }
        public DateTime LastUpdateDate { get; set; }
        public IEnumerable<Status> Status { get; set; }
        public IEnumerable<string> Tags { get; set; }
        public string Hash { get; set; }
        public string Url { get; set; }
    }
}