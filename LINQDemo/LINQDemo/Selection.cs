using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Data.SqlTypes;

namespace LINQDemo
{
    class Selection
    {
        public static void SelectionTest()
        {
            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            // querying on the array (similar to how it would work on a table)
            var lowNums =
                from n in numbers
                select n;

            Console.WriteLine("Numbers are:");
            foreach (var x in lowNums)
            {
                Console.WriteLine(x);
            }

            Console.WriteLine(lowNums.GetType());
            Console.WriteLine(numbers.GetType());
            Console.ReadLine();
        }
    }
}
