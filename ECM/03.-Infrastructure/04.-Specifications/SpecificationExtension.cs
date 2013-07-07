// --------------------------------------------------------------------------------------------------------------------
// <copyright file="SpecificationExtension.cs" company="Abraham Alcaina">
//   Abraham Alcaina
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace ECM.Infrastructure
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Linq.Expressions;

    /// <summary>
    /// The specification extensions.
    /// </summary>
    public static class SpecificationExtensions
    {
        #region Public Methods and Operators

        /// <summary>
        /// The apply and operator.
        /// </summary>
        /// <param name="rules">
        /// The rules.
        /// </param>
        /// <typeparam name="T">
        /// Subject type of expression
        /// </typeparam>
        /// <returns>
        /// The
        ///     <see>
        ///         <cref>ISpecification</cref>
        ///     </see>
        ///     return a aggregated and specifications.
        /// </returns>
        public static ISpecification<T> ApplyAndOperator<T>(this IEnumerable<ISpecification<T>> rules)
        {
            if (rules == null)
            {
                throw new ArgumentNullException("rules");
            }

            ISpecification<T> acumulate = default(ISpecification<T>);
            foreach (var specification in rules.Where(specification => specification != null))
            {
                if (acumulate == null)
                {
                    acumulate = specification;
                    continue;
                }

                Expression<Func<T, bool>> leftSide = acumulate.IsSatisfiedBy();
                Expression<Func<T, bool>> rightSide = specification.IsSatisfiedBy();
                ParameterExpression parameterExpression = leftSide.Parameters[0];
                var visitor = new SubstitutionExpressionVisitor();
                visitor.Substitution[rightSide.Parameters[0]] = parameterExpression;

                Expression body = Expression.AndAlso(leftSide.Body, visitor.Visit(rightSide.Body));
                acumulate = new Specification<T>(Expression.Lambda<Func<T, bool>>(body, parameterExpression));
            }

            return acumulate;
        }

        /// <summary>
        /// The apply or operator.
        /// </summary>
        /// <param name="rules">
        /// The rules.
        /// </param>
        /// <typeparam name="T">
        /// Subject type of expression
        /// </typeparam>
        /// <returns>
        /// The
        ///     <see>
        ///         <cref>ISpecification</cref>
        ///     </see>
        ///     return a aggregated of OR specifications.
        /// </returns>
        public static ISpecification<T> ApplyOrOperator<T>(this IEnumerable<ISpecification<T>> rules)
        {
            if (rules == null)
            {
                throw new ArgumentNullException("rules");
            }

            ISpecification<T> acumulate = default(ISpecification<T>);
            foreach (var specification in rules.Where(specification => specification != null))
            {
                if (acumulate == null)
                {
                    acumulate = specification;
                    continue;
                }

                Expression<Func<T, bool>> leftSide = acumulate.IsSatisfiedBy();
                Expression<Func<T, bool>> rightSide = specification.IsSatisfiedBy();
                ParameterExpression parameterExpression = leftSide.Parameters[0];
                var visitor = new SubstitutionExpressionVisitor();
                visitor.Substitution[rightSide.Parameters[0]] = parameterExpression;

                Expression body = Expression.OrElse(leftSide.Body, visitor.Visit(rightSide.Body));
                acumulate = new Specification<T>(Expression.Lambda<Func<T, bool>>(body, parameterExpression));
            }

            return acumulate;
        }

        #endregion
    }
}