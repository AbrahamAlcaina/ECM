// --------------------------------------------------------------------------------------------------------------------
// <copyright file="FileByTags.cs" company="Abraham Alcaina">
//   Abraham Alcaina
// </copyright>
// <summary>
//   The file by tags.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace ECM.Application.Routing
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    using ServiceStack.ServiceHost;

    /// <summary>
    ///     The file by tags.
    /// </summary>
    [Route("/api/ecm/files/tags/{listTags*}/")]
    public class FileByTags
    {
        #region Fields

        /// <summary>
        ///     The _list tags.
        /// </summary>
        private string _listTags;

        #endregion

        #region Constructors and Destructors

        /// <summary>
        ///     Initializes a new instance of the <see cref="FileByTags" /> class.
        /// </summary>
        public FileByTags()
        {
            this.Tags = new List<string>();
        }

        #endregion

        #region Public Properties

        /// <summary>
        ///     Gets or sets the list tags.
        /// </summary>
        public string ListTags
        {
            get
            {
                return this._listTags;
            }

            set
            {
                this._listTags = value;
                foreach (
                    string tag in
                        this._listTags.Split('+').Where(tag => !string.IsNullOrEmpty(tag.Replace("+", string.Empty))))
                {
                    this.Tags.Add(tag.Replace("+", string.Empty));
                }
            }
        }

        /// <summary>
        ///     Gets or sets the tags.
        /// </summary>
        public IList<string> Tags { get; set; }

        #endregion

        #region Public Methods and Operators

        /// <summary>
        ///     The to string.
        /// </summary>
        /// <returns>
        ///     The <see cref="string" />.
        /// </returns>
        public override string ToString()
        {
            if (this.Tags.Count == 0)
            {
                return string.Empty;
            }

            var result = new StringBuilder();
            foreach (string tag in this.Tags)
            {
                result.Append(tag).Append(", ");
            }

            return result.Remove(result.Length - 2, 2).ToString();
        }

        #endregion
    }
}