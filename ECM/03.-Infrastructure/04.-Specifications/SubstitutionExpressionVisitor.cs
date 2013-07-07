// --------------------------------------------------------------------------------------------------------------------
// <copyright file="SubstitutionExpressionVisitor.cs" company="Abraham Alcaina">
//   Abraham Alcaina
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace ECM.Infrastructure
{
    using System.Collections.Generic;
    using System.Linq.Expressions;

    /// <summary>
    ///     The substitution expression visitor.
    /// </summary>
    internal class SubstitutionExpressionVisitor : ExpressionVisitor
    {
        #region Fields

        /// <summary>
        ///     The substitution.
        /// </summary>
        private readonly Dictionary<Expression, Expression> substitution;

        #endregion

        #region Constructors and Destructors

        /// <summary>
        ///     Initializes a new instance of the <see cref="SubstitutionExpressionVisitor" /> class.
        /// </summary>
        public SubstitutionExpressionVisitor()
        {
            this.substitution = new Dictionary<Expression, Expression>();
        }

        #endregion

        #region Public Properties

        /// <summary>
        ///     Gets the substitution.
        /// </summary>
        public Dictionary<Expression, Expression> Substitution
        {
            get
            {
                return this.substitution;
            }
        }

        #endregion

        #region Methods

        /// <summary>
        /// The visit parameter.
        /// </summary>
        /// <param name="node">
        /// The node.
        /// </param>
        /// <returns>
        /// The <see cref="Expression"/>.
        /// </returns>
        protected override Expression VisitParameter(ParameterExpression node)
        {
            Expression newValue;
            return this.Substitution.TryGetValue(node, out newValue) ? newValue : node;
        }

        #endregion
    }
}