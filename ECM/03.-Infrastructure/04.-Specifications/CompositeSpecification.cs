// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CompositeSpecification.cs" company="Abraham Alcaina">
//   Abraham Alcaina
// </copyright>
// <summary>
//   The composite specification.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace ECM.Infrastructure
{
    using System;
    using System.Linq.Expressions;

    /// <summary>
    /// The composite specification.
    /// </summary>
    /// <typeparam name="TEntity">
    /// </typeparam>
    public abstract class CompositeSpecification<TEntity> : ISpecification<TEntity>
    {
        #region Fields

        /// <summary>
        ///     The left side.
        /// </summary>
        protected readonly Specification<TEntity> LeftSide;

        /// <summary>
        ///     The right side.
        /// </summary>
        protected readonly Specification<TEntity> RightSide;

        #endregion

        #region Constructors and Destructors

        /// <summary>
        /// Initializes a new instance of the <see cref="CompositeSpecification{TEntity}"/> class.
        /// </summary>
        /// <param name="leftSide">
        /// The left side.
        /// </param>
        /// <param name="rightSide">
        /// The right side.
        /// </param>
        protected CompositeSpecification(Specification<TEntity> leftSide, Specification<TEntity> rightSide)
        {
            this.LeftSide = leftSide;
            this.RightSide = rightSide;
        }

        #endregion

        #region Public Methods and Operators

        /// <summary>
        ///     The is satisfied by.
        /// </summary>
        /// <returns>
        ///     The <see cref="Expression" />.
        /// </returns>
        public abstract Expression<Func<TEntity, bool>> IsSatisfiedBy();

        #endregion
    }
}