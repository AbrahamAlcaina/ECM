// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Comment.cs" company="Abraham Alcaina">
//   Abraham Alcaina
// </copyright>
// <summary>
//   The comment.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace ECM.Domain.Entities
{
    using System;

    /// <summary>
    ///     The comment.
    /// </summary>
    public class Comment
    {
        #region Public Properties

        /// <summary>
        ///     Gets or sets the body.
        /// </summary>
        public string Body { get; set; }

        /// <summary>
        ///     Gets or sets the date.
        /// </summary>
        public DateTime Date { get; set; }

        /// <summary>
        ///     Gets or sets the id.
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        ///     Gets or sets the subject.
        /// </summary>
        public string Subject { get; set; }

        /// <summary>
        ///     Gets or sets the user.
        /// </summary>
        public string User { get; set; }

        #endregion
    }
}