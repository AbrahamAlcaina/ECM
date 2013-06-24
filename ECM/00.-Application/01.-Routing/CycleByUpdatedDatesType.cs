// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CycleByUpdatedDatesType.cs" company="Abraham Alcaina">
//   Abraham Alcaina
// </copyright>
// <summary>
//   The cycle by updated dates type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace ECM.Application.Routing
{
    using System;

    using ServiceStack.ServiceHost;

    /// <summary>
    ///     The cycle by updated dates type.
    /// </summary>
    [Route(
        "/api/ecm/files/client/{cid}/entity/{cuid}/paygroup/{idPaygroup/cycle/{idCycle}/lastupdatefrom/{startdate}/to/{enddate}/filetype/{type}/"
        )]
    public class CycleByUpdatedDatesType : PaygroupByUpdatedDatesType
    {
        #region Public Properties

        /// <summary>
        ///     Gets or sets the id cycle.
        /// </summary>
        public Guid IdCycle { get; set; }

        #endregion
    }
}