// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Specification.cs" company="Abraham Alcaina">
//   Abraham Alcaina
// </copyright>
// <summary>
//   The specification.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace ECM.Infrastructure
{
    using System;
    using System.Linq.Expressions;

    /// <summary>
    /// The specification.
    /// </summary>
    /// <typeparam name="TEntity">
    /// </typeparam>
    public class Specification<TEntity> : ISpecification<TEntity>
    {
        #region Fields

        /// <summary>
        ///     The predicate.
        /// </summary>
        internal readonly Expression<Func<TEntity, bool>> Predicate;

        #endregion

        #region Constructors and Destructors

        /// <summary>
        /// Initializes a new instance of the <see cref="Specification{TEntity}"/> class.
        /// </summary>
        /// <param name="predicate">
        /// The predicate.
        /// </param>
        public Specification(Expression<Func<TEntity, bool>> predicate)
        {
            this.Predicate = predicate;
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
            return new AndSpecification<TEntity>(this, specification);
        }

        /// <summary>
        /// The and.
        /// </summary>
        /// <param name="criteria">
        /// The criteria.
        /// </param>
        /// <returns>
        /// The <see cref="AndSpecification"/>.
        /// </returns>
        public AndSpecification<TEntity> And(Expression<Func<TEntity, bool>> criteria)
        {
            return new AndSpecification<TEntity>(this, new Specification<TEntity>(criteria));
        }

        /// <summary>
        ///     The is satisfied by.
        /// </summary>
        /// <returns>
        ///     The <see cref="Expression" />.
        /// </returns>
        public Expression<Func<TEntity, bool>> IsSatisfiedBy()
        {
            return this.Predicate;
        }

        /// <summary>
        /// The not.
        /// </summary>
        /// <param name="specification">
        /// The specification.
        /// </param>
        /// <returns>
        /// The <see cref="NotEqualSpecification"/>.
        /// </returns>
        public NotEqualSpecification<TEntity> Not(Specification<TEntity> specification)
        {
            return new NotEqualSpecification<TEntity>(this, specification);
        }

        /// <summary>
        /// The not.
        /// </summary>
        /// <param name="criteria">
        /// The criteria.
        /// </param>
        /// <returns>
        /// The <see cref="NotEqualSpecification"/>.
        /// </returns>
        public NotEqualSpecification<TEntity> Not(Expression<Func<TEntity, bool>> criteria)
        {
            return new NotEqualSpecification<TEntity>(this, new Specification<TEntity>(criteria));
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
            return new OrSpecification<TEntity>(this, specification);
        }

        /// <summary>
        /// The or.
        /// </summary>
        /// <param name="criteria">
        /// The criteria.
        /// </param>
        /// <returns>
        /// The <see cref="OrSpecification"/>.
        /// </returns>
        public OrSpecification<TEntity> Or(Expression<Func<TEntity, bool>> criteria)
        {
            return new OrSpecification<TEntity>(this, new Specification<TEntity>(criteria));
        }

        #endregion
    }
}