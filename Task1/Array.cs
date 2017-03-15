using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    /// <summary>
    /// 
    /// </summary>
    public static class Array
    {
        #region Public Methods
        /// <summary>
        /// Finds the index of the middle.
        /// </summary>
        /// <param name="array">The array.</param>
        /// <returns></returns>
        public static int? FindMiddleIndex(int[] array)
        {
            return FindIndex(array);
        }

        #endregion

        #region Private Methods
        /// <summary>
        /// Finds the index.
        /// </summary>
        /// <param name="array">The array.</param>
        /// <returns></returns>
        /// <exception cref="System.ArgumentNullException">array</exception>
        private static int? FindIndex(int[] array)
        {
            if (array == null)
                throw new ArgumentNullException(nameof(array));

            for (int i = 0; i < array.Length; i++)
            {
                if (array.Take(i).Sum() == array.Skip(i + 1).Sum())
                    return i;
            }

            return null;
        }

        #endregion
    }
}
