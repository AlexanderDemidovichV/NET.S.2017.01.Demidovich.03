using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    /// <summary>
    /// Provides methods for arrays.
    /// </summary>
    public static class ArrayHandler
    {
        #region Public Methods

        /// <summary>
        /// Searches for the index in the array, where the sum of left elements
        /// equals to the sum of right elements and returns the index of its first occurrence in a one-dimensional array.
        /// </summary>
        /// <param name="array">The one-dimensional array to search.</param>
        /// <returns>The index of the first occurrence of value in array, if found; otherwise, the lower bound of the array minus 1.</returns>
        public static int FindMiddleIndex(int[] array)
        {
            return FindIndex(array);
        }

        #endregion

        #region Private Methods

        /// <summary>
        /// Searches for the index in the array, where the sum of left elements
        /// equals to the sum of right elements and returns the index of its first occurrence in a one-dimensional array.
        /// </summary>
        /// <param name="array">The one-dimensional array to search.
        /// </param>
        /// <returns>The index of the first occurrence of value in array, if found; otherwise, the lower bound of the array minus 1.</returns>
        /// <exception cref="System.ArgumentNullException">array is null.</exception>
        private static int FindIndex(int[] array)
        {
            if (array == null)
                throw new ArgumentNullException(nameof(array));

            for (int i = 0; i < array.Length; i++)
            {
                if (array.Take(i).Sum() == array.Skip(i + 1).Sum())
                    return i;
            }

            return -1;
        }

        #endregion
    }
}
