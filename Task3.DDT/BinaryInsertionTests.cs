using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Task3.DDT
{
    [TestClass()]
    public class BinaryInsertionTests
    {
        public TestContext TestContext { get; set; }

        [DataSource(
            "Microsoft.VisualStudio.TestTools.DataSource.XML",
            "|DataDirectory|\\Tests.xml",
            "TestCase",
            DataAccessMethod.Sequential)]
        [DeploymentItem("Task3.DDT\\Tests.xml")]
        [TestMethod]
        public void BinaryInsertionTestMethod()
        {

            var expected = Convert.ToString(TestContext.DataRow["ExpectedResult"]);

            var actual = Convert.ToString(BinaryInsertion.BinaryInsertionIntegerIntoInteger(
                Convert.ToInt32(TestContext.DataRow["number1"]),
                Convert.ToInt32(TestContext.DataRow["number2"]),
                Convert.ToByte(TestContext.DataRow["startIndex"]),
                Convert.ToByte(TestContext.DataRow["endIndex"])));

            Assert.AreEqual(expected, actual);
        }
    }
}
