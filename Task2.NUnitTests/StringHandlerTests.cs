using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Task2.NUnitTests
{
    class StringHandlerTests
    {
        [TestCase("xyaabbbccccdefww", "xxxxyyyyabklmopq", Result = "abcdefklmopqwxy")]
        [TestCase("abcdefghijklmnopqrstuvwxyz", "abcdefghijklmnopqrstuvwxyz", Result = "abcdefghijklmnopqrstuvwxyz")]
        public static string testFindMiddleIndex(string str0, string str1)
        {
            return StringHandler.ConcatSortStrings(str0, str1);
        }

    }
}
