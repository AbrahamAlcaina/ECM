using System;
using System.Collections.Generic;
using ECM.Domain.Entities;
using ServiceStack.ServiceHost;

namespace ECM.Application.Routing
{
    [Route("/api/ecm/files/{idFile}/", Verbs = "GET")]
    internal class FileRequest
    {
        public Guid IdFile { get; set; }
        public FileType Type { get; set; }
    }

   [Route("/api/ecm/files/filetype/{type}/", Verbs = "GET")]
    internal class FileByTypeRequest
    {
        public FileType Type { get; set; }
    }

    [Route("/api/ecm/files/tags/{listTags*}/", Verbs = "GET")]
    internal  class FileByTagsRequest
    {
        private string _listTags;

        public string ListTags
        {
            get { return _listTags; }
            set { 
                _listTags = value;
                foreach (var tag in _listTags.Split('+'))
                {
                    Tags.Add(tag.Replace("+",""));
                }
            }
        }

        public IList<string> Tags { get; set; }
    }

    [Route("/api/ecm/files/",Verbs = "POST")]
    internal class FileCreationRequest
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
   
    //[Route("api/ecm/files/chid/{idFile}/")]
    //[Route("api/ecm/files/{idFile}/content/")]
    //[Route("api/ecm/files/alias/{aliasName}/")]
    //[Route("api/ecm/files/tag/{tag1+...+tagn}/")]
    //[Route("api/ecm/files/from/{startdate}/to/{enddate}/")]
    //[Route("api/ecm/files/lastupdatefrom/{startdate}/to/{enddate}/")]
    //[Route("api/ecm/files/from/{startdate}/to/{enddate}/filetype/{type}/")]
    //[Route("api/ecm/files/lastupdatefrom/{startdate}/to/{enddate}/filetype/{type}/")]
}