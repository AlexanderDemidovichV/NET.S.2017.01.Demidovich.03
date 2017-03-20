using NUnit.Framework;

namespace Task2.NUnitTests
{
    class StringHandlerTests
    {
        [TestCase("xyaabbbccccdefww", "xxxxyyyyabklmopq", Result = "abcdefklmopqwxy")]
        [TestCase("abcdefghijklmnopqrstuvwxyz", "abcdefghijklmnopqrstuvwxyz", Result = "abcdefghijklmnopqrstuvwxyz")]
        public static string TestFindMiddleIndex(string str0, string str1)
        {
            return StringHandler.ConcatSortStrings(str0, str1);
        }

    }
}
