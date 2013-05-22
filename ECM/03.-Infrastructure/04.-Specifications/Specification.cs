using System;
using System.Linq.Expressions;

namespace ECM.Infrastructure
{
    
    public class Specification<TEntity> : ISpecification<TEntity>
    {
        #region Fields

        internal readonly Expression<Func<TEntity, bool>> Predicate;

        #endregion

        #region Constructors and Destructors

        public Specification(Expression<Func<TEntity, bool>> predicate)
        {
            Predicate = predicate;
        }

        #endregion

        #region Public Methods and Operators

        public Expression<Func<TEntity, bool>> IsSatisfiedBy()
        {
            return Predicate;
        }

        public AndSpecification<TEntity> And(Specification<TEntity> specification)
        {
            return new AndSpecification<TEntity>(this, specification);
        }

        public AndSpecification<TEntity> And(Expression<Func<TEntity,bool>> criteria)
        {
            return new AndSpecification<TEntity>(this, new Specification<TEntity>(criteria));
        }

        public NotEqualSpecification<TEntity> Not(Specification<TEntity> specification)
        {
            return new NotEqualSpecification<TEntity>(this, specification);
        }

        public NotEqualSpecification<TEntity> Not(Expression<Func<TEntity,bool>> criteria)
        {
            return new NotEqualSpecification<TEntity>(this, new Specification<TEntity>(criteria));
        }

        public OrSpecification<TEntity> Or(Specification<TEntity> specification)
        {
            return new OrSpecification<TEntity>(this, specification);
        }

        public OrSpecification<TEntity> Or(Expression<Func<TEntity,bool>> criteria)
        {
            return new OrSpecification<TEntity>(this, new Specification<TEntity>(criteria));
        }
        #endregion
    }
}