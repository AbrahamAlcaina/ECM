// --------------------------------------------------------------------------------------------------------------------
// <copyright file="FileCreationRequest.cs" company="Abraham Alcaina">
//   Abraham Alcaina
// </copyright>
// <summary>
//   The file creation request.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace ECM.Application.Routing
{
    using System;
    using System.Collections.Generic;

    using ECM.Domain.Entities;

    using ServiceStack.ServiceHost;

    /// <summary>
    ///     The file creation request.
    /// </summary>
    [Route("/api/ecm/files/", Verbs = "POST")]
    public class FileCreationRequest
    {
        #region Public Properties

        /// <summary>
        ///     Gets or sets the alias.
        /// </summary>
        public IEnumerable<Alias> Alias { get; set; }

        /// <summary>
        ///     Gets or sets the client.
        /// </summary>
        public Client Client { get; set; }

        /// <summary>
        ///     Gets or sets the comments.
        /// </summary>
        public IEnumerable<Comment> Comments { get; set; }

        /// <summary>
        ///     Gets or sets the hash.
        /// </summary>
        public string Hash { get; set; }

        /// <summary>
        ///     Gets or sets the id.
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        ///     Gets or sets the last update date.
        /// </summary>
        public DateTime LastUpdateDate { get; set; }

        /// <summary>
        ///     Gets or sets the name client.
        /// </summary>
        public string NameClient { get; set; }

        /// <summary>
        ///     Gets or sets the name partner.
        /// </summary>
        public string NamePartner { get; set; }

        /// <summary>
        ///     Gets or sets the partner.
        /// </summary>
        public Partner Partner { get; set; }

        /// <summary>
        ///     Gets or sets the reception date.
        /// </summary>
        public DateTime ReceptionDate { get; set; }

        /// <summary>
        ///     Gets or sets the status.
        /// </summary>
        public IEnumerable<Status> Status { get; set; }

        /// <summary>
        ///     Gets or sets the tags.
        /// </summary>
        public IEnumerable<string> Tags { get; set; }

        /// <summary>
        ///     Gets or sets the type.
        /// </summary>
        public FileType Type { get; set; }

        /// <summary>
        ///     Gets or sets the url.
        /// </summary>
        public string Url { get; set; }

        #endregion
    }
}