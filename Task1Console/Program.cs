using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1;

namespace Task1Console
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { -1, 50, -50, 1, 1 };

            int? index = Task1.Array.FindMiddleIndex(array);
            Console.WriteLine(index);
        }
    }
}
