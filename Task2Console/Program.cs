using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task2;

namespace Task2CUI
{
    class Program
    {
        static void Main(string[] args)
        {
            testConcatSortStrings("xyaabbbccccdefww", "xxxxyyyyabklmopq");
            testConcatSortStrings("abcdefghijklmnopqrstuvwxyz", "abcdefghijklmnopqrstuvwxyz");

            Console.ReadLine();
        }

        private static void testConcatSortStrings(string a, string b)
        {
            Console.WriteLine(StringHandler.ConcatSortStrings(a, b));
        }
    }
}
