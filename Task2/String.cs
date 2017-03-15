using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    /// <summary>
    /// 
    /// </summary>
    public static class String
    {
        /// <summary>
        /// Concats the sort string.
        /// </summary>
        /// <param name="value1">The value1.</param>
        /// <param name="value2">The value2.</param>
        /// <returns></returns>
        public static string ConcatSortString(string value1, string value2)
        {
            return ConcatDistinctOrderBy(value1, value2);
        }

        /// <summary>
        /// Concats the distinct order by.
        /// </summary>
        /// <param name="value1">The value1.</param>
        /// <param name="value2">The value2.</param>
        /// <returns></returns>
        /// <exception cref="System.ArgumentNullException">
        /// value1
        /// or
        /// value2
        /// </exception>
        private static string ConcatDistinctOrderBy(string value1, string value2)
        {
            if (value1 == null)
                throw new ArgumentNullException(nameof(value1));

            if (value2 == null)
                throw new ArgumentNullException(nameof(value2));

            string value = System.String.Concat(value1, value2);
            string ca = new string(value.Where(c => (c >= 'a') && (c <= 'z')).Distinct().OrderBy(s => s).ToArray());
            return ca;
        }

    }
}
