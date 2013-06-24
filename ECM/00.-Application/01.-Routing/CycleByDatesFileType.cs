// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CycleByDatesFileType.cs" company="Abraham Alcaina">
//   Abraham Alcaina
// </copyright>
// <summary>
//   The cycle by dates file type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace ECM.Application.Routing
{
    using System;

    using ServiceStack.ServiceHost;

    /// <summary>
    ///     The cycle by dates file type.
    /// </summary>
    [Route(
        "/api/ecm/files/client/{cid}/entity/{cuid}/paygroup/{idPaygroup/cycle/{idCycle}/from/{startdate}/to/{enddate}/filetype/{type}/"
        )]
    public class CycleByDatesFileType : PaygroupByDatesFileType
    {
        #region Public Properties

        /// <summary>
        ///     Gets or sets the id cycle.
        /// </summary>
        public Guid IdCycle { get; set; }

        #endregion
    }
}