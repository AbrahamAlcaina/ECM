﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Mode.cs" company="Abraham Alcaina">
//   Abraham Alcaina
// </copyright>
// <summary>
//   The mode.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace ECM.Domain.Entities
{
    /// <summary>
    ///     The mode.
    /// </summary>
    public enum Mode
    {
        /// <summary>
        ///     The development.
        /// </summary>
        Development, 

        /// <summary>
        ///     The test.
        /// </summary>
        Test, 

        /// <summary>
        ///     The quality assurance.
        /// </summary>
        QualityAssurance, 

        /// <summary>
        ///     The production.
        /// </summary>
        Production
    }
}