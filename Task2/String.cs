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
        public static string ConcatSortString(string value)
        {
            return ConcatSort(value);
        }

        private static string ConcatSort(string value)
        {
            if (value == null)
                throw new ArgumentNullException(nameof(value));
            return null;
        }
    }
}
