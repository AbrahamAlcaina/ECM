using System.Collections.Generic;
using System.Linq;
using System.Text;
using ServiceStack.ServiceHost;

namespace ECM.Application.Routing
{
    [Route("/api/ecm/files/tags/{listTags*}/")]
    public  class FileByTagsRequest
    {
        private string _listTags;

        public string ListTags
        {
            get { return _listTags; }
            set
            {
                _listTags = value;
                foreach (var tag in _listTags.Split('+')
                                             .Where(tag => !string.IsNullOrEmpty(tag.Replace("+", ""))))
                {
                    Tags.Add(tag.Replace("+",""));
                }
            }
        }

        public IList<string> Tags { get; set; }

        public override string ToString()
        {
            if (Tags.Count == 0)
                return string.Empty;

            var result = new StringBuilder();
            foreach (var tag in Tags)
            {
                result.Append(tag).Append(", ");
            }
            return result
                .Remove(result.Length - 2, 2)
                .ToString();
        }

        public FileByTagsRequest()
        {
            Tags = new List<string>();
        }
    }
}