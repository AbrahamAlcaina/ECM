// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ISpecification.cs" company="Abraham Alcaina">
//   Abraham Alcaina
// </copyright>
// <summary>
//   The Specification interface.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace ECM.Infrastructure
{
    using System;
    using System.Linq.Expressions;

    /// <summary>
    /// The Specification interface.
    /// </summary>
    /// <typeparam name="TEntity">
    /// </typeparam>
    public interface ISpecification<TEntity>
    {
        #region Public Methods and Operators

        /// <summary>
        ///     The is satisfied by.
        /// </summary>
        /// <returns>
        ///     The <see cref="Expression" />.
        /// </returns>
        Expression<Func<TEntity, bool>> IsSatisfiedBy();

        #endregion
    }
}