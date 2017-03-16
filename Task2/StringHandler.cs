using System;
using System.Linq;

namespace Task2
{
    /// <summary>
    /// Provides methods for strings.
    /// </summary>
    public static class StringHandler
    {
        #region Public Methods

        /// <summary>
        /// Concatenates and sorts two strings excluding duplicate symbols. 
        /// </summary>
        /// <param name="str0">The first string to concatenate. Allow chars in [a-z].</param>
        /// <param name="str1">The second string to concatenate. Allow chars in [a-z].</param>
        /// <returns>A sorted string that contains distinct elements from the source strings.</returns>
        public static string ConcatSortStrings(string str0, string str1)
        {
            return ConcatDistinctOrderBy(str0, str1);
        }

        #endregion


        #region Private Methods

        /// <summary>
        /// Concatenates and sorts two strings excluding duplicate symbols. Allow chars in [a-z].
        /// </summary>
        /// <param name="str0">The first string to concatenate. Allow chars in [a-z].</param>
        /// <param name="str1">The second string to concatenate. Allow chars in [a-z].</param>
        /// <returns>A sorted string that contains distinct elements from the source strings.</returns>
        /// <exception cref="System.ArgumentNullException">
        /// value1 or value2 is null or empty
        /// </exception>
        private static string ConcatDistinctOrderBy(string str0, string str1)
        {
            if (string.IsNullOrEmpty(str0))
                throw new ArgumentNullException(nameof(str0));

            if (string.IsNullOrEmpty(str1))
                throw new ArgumentNullException(nameof(str1));

            return new string((str0 + str1).Where(c => (c >= 'a') && (c <= 'z')).Distinct().OrderBy(s => s).ToArray()); 
        }

        #endregion
    }
}
