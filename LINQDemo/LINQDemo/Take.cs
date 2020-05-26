using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQDemo
{
    class Take
    {
        public static void TakeTester()
        {
            //Take - Simple
            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            var first3Numbers = numbers.Take(3); //Take is a method in the System.Linq namespace that allows you to get the first several elements from a sequence
            Console.WriteLine("First 3 numbers:");
            foreach (var n in first3Numbers)
            {
                Console.WriteLine(n);
            }
            Console.ReadLine();
        }
    }
}
