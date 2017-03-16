using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task3;

namespace Task3Console
{
    class Program
    {
        static void Main(string[] args)
        {
            testBinaryInsertionIntegerIntoInteger(8, 15, 0, 0);
            testBinaryInsertionIntegerIntoInteger(0, 15, 30, 30);
            testBinaryInsertionIntegerIntoInteger(0, 15, 0, 30);
            testBinaryInsertionIntegerIntoInteger(15, -15, 0, 4);
            testBinaryInsertionIntegerIntoInteger(15, int.MaxValue, 3, 5);

            Console.ReadLine();
        }

        private static void testBinaryInsertionIntegerIntoInteger(int number1, int number2, int startIndex, int endIndex)
        {
            Console.WriteLine(BinaryInsertion.BinaryInsertionIntegerIntoInteger(number1, number2, startIndex, endIndex));
        }
    }
}
