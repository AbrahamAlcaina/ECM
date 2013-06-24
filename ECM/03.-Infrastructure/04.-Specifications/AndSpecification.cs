// --------------------------------------------------------------------------------------------------------------------
// <copyright file="AndSpecification.cs" company="Abraham Alcaina">
//   Abraham Alcaina
// </copyright>
// <summary>
//   The and specification.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace ECM.Infrastructure
{
    using System;
    using System.Linq.Expressions;

    /// <summary>
    /// The and specification.
    /// </summary>
    /// <typeparam name="TEntity">
    /// </typeparam>
    public class AndSpecification<TEntity> : CompositeSpecification<TEntity>
    {
        #region Constructors and Destructors

        /// <summary>
        /// Initializes a new instance of the <see cref="AndSpecification{TEntity}"/> class.
        /// </summary>
        /// <param name="leftSide">
        /// The left side.
        /// </param>
        /// <param name="rightSide">
        /// The right side.
        /// </param>
        public AndSpecification(Specification<TEntity> leftSide, Specification<TEntity> rightSide)
            : base(leftSide, rightSide)
        {
        }

        #endregion

        #region Public Methods and Operators

        /// <summary>
        /// The and.
        /// </summary>
        /// <param name="specification">
        /// The specification.
        /// </param>
        /// <returns>
        /// The <see cref="AndSpecification"/>.
        /// </returns>
        public AndSpecification<TEntity> And(Specification<TEntity> specification)
        {
            return new AndSpecification<TEntity>(new Specification<TEntity>(this.IsSatisfiedBy()), specification);
        }

        /// <summary>
        ///     The is satisfied by.
        /// </summary>
        /// <returns>
        ///     The <see cref="Expression" />.
        /// </returns>
        public override Expression<Func<TEntity, bool>> IsSatisfiedBy()
        {
            InvocationExpression invokedExpr = Expression.Invoke(
                this.RightSide.Predicate, this.LeftSide.Predicate.Parameters);
            return Expression.Lambda<Func<TEntity, bool>>(
                Expression.AndAlso(this.RightSide.Predicate.Body, invokedExpr), this.LeftSide.Predicate.Parameters);
        }

        #endregion
    }
}