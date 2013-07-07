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
            var parameterExpression = LeftSide.Predicate.Parameters[0];
            var visitor = new SubstitutionExpressionVisitor();
            visitor.Substitution[this.RightSide.Predicate.Parameters[0]] = parameterExpression;

            Expression body = Expression.NotEqual(LeftSide.Predicate.Body, visitor.Visit(this.RightSide.Predicate.Body));
            return Expression.Lambda<Func<TEntity, bool>>(body, parameterExpression);
        }

        #endregion
    }
}