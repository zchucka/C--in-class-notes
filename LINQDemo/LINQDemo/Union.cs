using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQDemo
{
    class Union
    {
        public static void UnionTester()
        {
            //Union
            int[] numbersA = { 0, 2, 4, 5, 6, 8, 9 };
            int[] numbersB = { 1, 3, 5, 7, 8 };

            var uniqueNumbers = numbersA.Union(numbersB);

            Console.WriteLine("Unique numbers from both arrays:");
            foreach (var n in uniqueNumbers)
            {
                Console.WriteLine(n);
            }
            Console.ReadLine();

        }
    }
}
