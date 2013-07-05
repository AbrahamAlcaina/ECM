// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IEnumerable.cs" company="Abraham Alcaina">
//   Abraham Alcaina
// </copyright>
// <summary>
//   The enumerable extensions.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace System
{
    using System.Collections.Generic;

    /// <summary>
    ///     The enumerable extensions.
    /// </summary>
    internal static class EnumerableExtensions
    {
        #region Public Methods and Operators

        /// <summary>
        /// The for each.
        /// </summary>
        /// <param name="enumeration">
        /// The enumeration.
        /// </param>
        /// <param name="action">
        /// The action.
        /// </param>
        /// <typeparam name="T">
        /// </typeparam>
        public static void ForEach<T>(this IEnumerable<T> enumeration, Action<T> action)
        {
            foreach (T item in enumeration)
            {
                action(item);
            }
        }

        #endregion
    }
}