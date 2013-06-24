// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CycleByType.cs" company="Abraham Alcaina">
//   Abraham Alcaina
// </copyright>
// <summary>
//   The cycle by type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace ECM.Application.Routing
{
    using System;

    using ServiceStack.ServiceHost;

    /// <summary>
    ///     The cycle by type.
    /// </summary>
    [Route("/api/ecm/files/client/{cid}/entity/{cuid}/paygroup/{idPaygroup/cycle/{idCycle}/filetype/{type}/")]
    public class CycleByType : PaygroupByType
    {
        #region Public Properties

        /// <summary>
        ///     Gets or sets the id cycle.
        /// </summary>
        public Guid IdCycle { get; set; }

        #endregion
    }
}