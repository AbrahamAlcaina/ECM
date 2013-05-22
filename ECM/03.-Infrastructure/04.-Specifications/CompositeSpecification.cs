using System;
using System.Linq.Expressions;

namespace ECM.Infrastructure
{
    public abstract class CompositeSpecification<TEntity> : ISpecification<TEntity>
    {
        #region Fields

        protected readonly Specification<TEntity> LeftSide;

        protected readonly Specification<TEntity> RightSide;

        #endregion

        #region Constructors and Destructors

        protected CompositeSpecification(Specification<TEntity> leftSide, Specification<TEntity> rightSide)
        {
            LeftSide = leftSide;
            RightSide = rightSide;
        }

        #endregion

        #region Public Methods and Operators

        public abstract Expression<Func<TEntity, bool>> IsSatisfiedBy();
        
        #endregion
    }
}