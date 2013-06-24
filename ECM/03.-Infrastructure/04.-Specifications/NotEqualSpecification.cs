// --------------------------------------------------------------------------------------------------------------------
// <copyright file="NotEqualSpecification.cs" company="Abraham Alcaina">
//   Abraham Alcaina
// </copyright>
// <summary>
//   The not equal specification.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace ECM.Infrastructure
{
    using System;
    using System.Linq.Expressions;

    /// <summary>
    /// The not equal specification.
    /// </summary>
    /// <typeparam name="TEntity">
    /// </typeparam>
    public class NotEqualSpecification<TEntity> : CompositeSpecification<TEntity>
    {
        #region Constructors and Destructors

        /// <summary>
        /// Initializes a new instance of the <see cref="NotEqualSpecification{TEntity}"/> class.
        /// </summary>
        /// <param name="leftSide">
        /// The left side.
        /// </param>
        /// <param name="rightSide">
        /// The right side.
        /// </param>
        public NotEqualSpecification(Specification<TEntity> leftSide, Specification<TEntity> rightSide)
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
            return
                Expression.Lambda<Func<TEntity, bool>>(
                    Expression.NotEqual(this.RightSide.Predicate.Body, invokedExpr), this.LeftSide.Predicate.Parameters);
        }

        #endregion
    }
}