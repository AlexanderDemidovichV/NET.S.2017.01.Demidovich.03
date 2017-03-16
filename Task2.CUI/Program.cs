using System;

namespace Task2.CUI
{
    class Program
    {
        static void Main(string[] args)
        {
            testConcatSortStrings("xyaabbbccccdefww", "xxxxyyyyabklmopq");
            testConcatSortStrings("abcdefghijklmnopqrstuvwxyz", "abcdefghijklmnopqrstuvwxyz");
            testConcatSortStrings("abcdfghfgwxyz", "sfsz");

            Console.ReadLine();
        }

        private static void testConcatSortStrings(string a, string b)
        {
            Console.WriteLine(StringHandler.ConcatSortStrings(a, b));
        }
    }
}
