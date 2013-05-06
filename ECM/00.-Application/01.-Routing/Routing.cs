using System;
using System.Collections.Generic;
using ECM.Domain.Entities;
using ServiceStack.ServiceHost;

namespace ECM.Application.Routing
{
    [Route("/api/ecm/files/{idFile}/")]
    internal class FileRequest
    {
        public Guid IdFile { get; set; }
    }

    [Route("/api/ecm/files/filetype/{type}/")]
    internal class FileByTypeRequest
    {
        public FileType Type { get; set; }
    }
    
    [Route("/api/ecm/files/tags/{listTags*}/")]
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
   
    //[Route("api/ecm/files/chid/{idFile}/")]
    //[Route("api/ecm/files/{idFile}/content/")]
    //[Route("api/ecm/files/alias/{aliasName}/")]
    //[Route("api/ecm/files/tag/{tag1+...+tagn}/")]
    //[Route("api/ecm/files/from/{startdate}/to/{enddate}/")]
    //[Route("api/ecm/files/lastupdatefrom/{startdate}/to/{enddate}/")]
    //[Route("api/ecm/files/from/{startdate}/to/{enddate}/filetype/{type}/")]
    //[Route("api/ecm/files/lastupdatefrom/{startdate}/to/{enddate}/filetype/{type}/")]
}