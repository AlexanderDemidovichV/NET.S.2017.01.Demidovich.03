using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using Task1;

namespace Task1.NUnitTests
{
    [TestFixture]
    public class ArrayHandlerNUnitTests
    {
        [TestCase(new[] { 1, 2, 3, 4, 3, 2, 1 }, ExpectedResult = 3)]
        [TestCase(new[] { 1, 100, 50, -51, 1, 1 }, ExpectedResult = 1)]
        [TestCase(new[] { 1, 1, 0, 0, 0, 1, 1 }, ExpectedResult = 2)]
        [TestCase(new[] { 1, 2, 3, 4, 5, 2, 1 }, ExpectedResult = -1)]
        [TestCase(new[] { 1, 1, 1, 1 }, ExpectedResult = -1)]

        [Test]
        public int FindIndexTests(int[] array)
        {
            return ArrayHandler.FindMiddleIndex(array);
        }
    }
}
