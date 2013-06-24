// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Cycle.cs" company="Abraham Alcaina">
//   Abraham Alcaina
// </copyright>
// <summary>
//   The cycle.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace ECM.Application.Routing
{
    using System;

    using ServiceStack.ServiceHost;

    /// <summary>
    ///     The cycle.
    /// </summary>
    [Route("/api/ecm/files/client/{cid}/entity/{cuid}/paygroup/{idPaygroup/cycle/{idCycle}/")]
    public class Cycle : Paygroup
    {
        #region Public Properties

        /// <summary>
        ///     Gets or sets the id cycle.
        /// </summary>
        public Guid IdCycle { get; set; }

        #endregion
    }
}