// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CycleByTag.cs" company="Abraham Alcaina">
//   Abraham Alcaina
// </copyright>
// <summary>
//   The cycle by tag.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace ECM.Application.Routing
{
    using System;

    using ServiceStack.ServiceHost;

    /// <summary>
    ///     The cycle by tag.
    /// </summary>
    [Route("/api/ecm/files/client/{cid}/entity/{cuid}/paygroup/{idPaygroup/cycle/{idCycle}/tag/{tag1+...+tagn}/")]
    public class CycleByTag : PaygroupByTag
    {
        #region Public Properties

        /// <summary>
        ///     Gets or sets the id cycle.
        /// </summary>
        public Guid IdCycle { get; set; }

        #endregion
    }
}