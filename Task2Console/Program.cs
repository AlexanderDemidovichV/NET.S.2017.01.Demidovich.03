using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task2;

namespace Task2Console
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = "abcdefghijklmnopqrstuvwxyz";
            string b = "abcdefghijklmnopqrstuvwxyz";
            Console.WriteLine(Task2.String.ConcatSortString(a, b));
        }
    }
}
