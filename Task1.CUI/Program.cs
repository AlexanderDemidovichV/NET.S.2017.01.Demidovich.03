using System;

namespace Task1.CUI
{
    class Program
    {
        static void Main(string[] args)
        {
            testSearchMiddleIndex(new int[] { 1, 2, 3, 4, 3, 2, 1 });
            testSearchMiddleIndex(new int[] { 1, 100, 50, -51, 1, 1 });
            testSearchMiddleIndex(new int[] { 1, 1, 0, 0, 1, 1 });
            Console.ReadLine();
        }

        static private void testSearchMiddleIndex(int[] array)
        {
            Console.WriteLine(ArrayHandler.FindMiddleIndex(array));
        }
    }
}
