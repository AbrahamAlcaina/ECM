namespace ECM.Infrastructure
{
    using System;
    using System.Linq.Expressions;


    public interface ISpecification<TEntity>
    {
        #region Public Methods and Operators

        Expression<Func<TEntity, bool>> IsSatisfiedBy();

        #endregion
    }
}