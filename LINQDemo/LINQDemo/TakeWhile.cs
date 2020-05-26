using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQDemo
{
    class TakeWhile
    {
        public static void TakeWhileTester()
        {
            //TakeWhile - Simple
            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            var firstNumbersLessThan6 = numbers.TakeWhile(n => n < 6); //TakeWhile. TakeWhile returns elements while a Predicate matches. The Predicate returns true or false. When it returns false, TakeWhile returns. TakeWhile operates from the beginning of an IEnumerable collection.

            Console.WriteLine("First numbers less than 6:");
            foreach (var n in firstNumbersLessThan6)
            {
                Console.WriteLine(n);
            }
            Console.ReadLine();
        }
    }
}
