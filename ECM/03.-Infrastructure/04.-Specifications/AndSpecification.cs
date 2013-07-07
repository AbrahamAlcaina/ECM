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
            var parameterExpression = this.LeftSide.Predicate.Parameters[0];
            var visitor = new SubstitutionExpressionVisitor();
            visitor.Substitution[this.RightSide.Predicate.Parameters[0]] = parameterExpression;

            Expression body = Expression.AndAlso(
                this.LeftSide.Predicate.Body, visitor.Visit(this.RightSide.Predicate.Body));
            return Expression.Lambda<Func<TEntity, bool>>(body, parameterExpression);
        }

        #endregion
    }
}