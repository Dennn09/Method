using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace latihanoverloadmethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Numbers number = new Numbers();

            Console.WriteLine("Minimum #1: {0}", number.FindMinimum(2, 5));
            Console.WriteLine("Minimum #2: {0}", number.FindMinimum(8, 1, 4));
            Console.WriteLine();
            Console.WriteLine("Maximum #1: {0}", number.FindMaximum(9, 5));
            Console.WriteLine("Maximum #2: {0}", number.FindMaximum(2, 3, 7));

            Console.ReadKey();
        }
    }
}