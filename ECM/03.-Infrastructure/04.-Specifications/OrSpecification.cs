// --------------------------------------------------------------------------------------------------------------------
// <copyright file="OrSpecification.cs" company="Abraham Alcaina">
//   Abraham Alcaina
// </copyright>
// <summary>
//   The or specification.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace ECM.Infrastructure
{
    using System;
    using System.Linq.Expressions;

    /// <summary>
    /// The or specification.
    /// </summary>
    /// <typeparam name="TEntity">
    /// </typeparam>
    public class OrSpecification<TEntity> : CompositeSpecification<TEntity>
    {
        #region Constructors and Destructors

        /// <summary>
        /// Initializes a new instance of the <see cref="OrSpecification{TEntity}"/> class.
        /// </summary>
        /// <param name="leftSide">
        /// The left side.
        /// </param>
        /// <param name="rightSide">
        /// The right side.
        /// </param>
        public OrSpecification(Specification<TEntity> leftSide, Specification<TEntity> rightSide)
            : base(leftSide, rightSide)
        {
        }

        #endregion

        #region Public Methods and Operators

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
                Expression.OrElse(this.RightSide.Predicate.Body, invokedExpr), this.LeftSide.Predicate.Parameters);
        }

        /// <summary>
        /// The or.
        /// </summary>
        /// <param name="specification">
        /// The specification.
        /// </param>
        /// <returns>
        /// The <see cref="OrSpecification"/>.
        /// </returns>
        public OrSpecification<TEntity> Or(Specification<TEntity> specification)
        {
            return new OrSpecification<TEntity>(new Specification<TEntity>(this.IsSatisfiedBy()), specification);
        }

        #endregion
    }
}