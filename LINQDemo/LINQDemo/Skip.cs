using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQDemo
{
    class Skip
    {
        public static void SkipTester()
        {
            //Skip - Simple
            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            var allButFirst4Numbers = numbers.Skip(4); //ignore items in a sequence until either a certain number are passed, or until a certain condition becomes false.
            Console.WriteLine("All but first 4 numbers:");
            foreach (var n in allButFirst4Numbers)
            {
                Console.WriteLine(n);
            }
            Console.ReadLine();
        }
    }
}
