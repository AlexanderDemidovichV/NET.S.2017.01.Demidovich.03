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
            int a = BinaryInsertion.BinaryInsertionIntegerIntoInteger(15, int.MaxValue, 3, 5);
            Console.WriteLine(a);
        }
    }
}
