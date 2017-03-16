using System;

namespace Task3.CUI
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
