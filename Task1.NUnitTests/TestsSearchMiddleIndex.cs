using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Task1;

namespace Task1.NUnitTests
{
    class TestsSearchMiddleIndex
    {
        [TestCase(new int[] { 1, 2, 3, 4, 3, 2, 1 }, Result = 3)]
        [TestCase(new int[] { 1, 100, 50, -51, 1, 1 }, Result = 1)]
        [TestCase(new int[] { 1, 1, 0, 0, 1, 1 }, Result = 2)]
        public static int testFindMiddleIndex(int[] array)
        {
            return Task1.ArrayHandler.FindMiddleIndex(array);
        }
    }
}
