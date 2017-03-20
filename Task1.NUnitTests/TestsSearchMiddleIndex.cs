using NUnit.Framework;

namespace Task1.NUnitTests
{
    class TestsSearchMiddleIndex
    {
        [TestCase(new[] { 1, 2, 3, 4, 3, 2, 1 }, Result = 3)]
        [TestCase(new[] { 1, 100, 50, -51, 1, 1 }, Result = 1)]
        [TestCase(new[] { 1, 1, 0, 0, 1, 1 }, Result = 2)]
        [TestCase(new[] { 1, 1, 1, 1 }, Result = -1)]
        public static int TestFindMiddleIndex(int[] array)
        {
            return ArrayHandler.FindMiddleIndex(array);
        }
    }
}
