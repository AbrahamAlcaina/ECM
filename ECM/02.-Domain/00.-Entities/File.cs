// --------------------------------------------------------------------------------------------------------------------
// <copyright file="File.cs" company="Abraham Alcaina">
//   Abraham Alcaina
// </copyright>
// <summary>
//   The file.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace ECM.Domain.Entities
{
    using System;
    using System.Collections.Generic;

    using MongoRepository;

    /// <summary>
    ///     The file.
    /// </summary>
    public class File : Entity
    {
        #region Public Properties

        /// <summary>
        ///     Gets or sets the aliases.
        /// </summary>
        public IEnumerable<Alias> Aliases { get; set; }

        /// <summary>
        ///     Gets or sets the client.
        /// </summary>
        public Client Client { get; set; }

        /// <summary>
        ///     Gets or sets the client name.
        /// </summary>
        public string ClientName { get; set; }

        /// <summary>
        ///     Gets or sets the comments.
        /// </summary>
        public IEnumerable<Comment> Comments { get; set; }

        /// <summary>
        ///     Gets or sets the file id.
        /// </summary>
        public Guid FileId { get; set; }

        /// <summary>
        ///     Gets or sets the hash.
        /// </summary>
        public object Hash { get; set; }

        /// <summary>
        ///     Gets or sets the last update time.
        /// </summary>
        public DateTime LastUpdateTime { get; set; }

        /// <summary>
        ///     Gets or sets the mode.
        /// </summary>
        public Mode Mode { get; set; }

        /// <summary>
        ///     Gets or sets the parent id.
        /// </summary>
        public Guid ParentId { get; set; }

        /// <summary>
        ///     Gets or sets the partner.
        /// </summary>
        public Partner Partner { get; set; }

        /// <summary>
        ///     Gets or sets the partner name.
        /// </summary>
        public string PartnerName { get; set; }

        /// <summary>
        ///     Gets or sets the reception date.
        /// </summary>
        public DateTime ReceptionDate { get; set; }

        /// <summary>
        ///     Gets or sets the statuses.
        /// </summary>
        public IEnumerable<Status> Statuses { get; set; }

        /// <summary>
        ///     Gets or sets the tags.
        /// </summary>
        public IEnumerable<string> Tags { get; set; }

        /// <summary>
        ///     Gets or sets the type.
        /// </summary>
        public FileType Type { get; set; }

        #endregion
    }
}