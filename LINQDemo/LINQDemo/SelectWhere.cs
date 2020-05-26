using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQDemo
{
    class SelectWhere
    {
        public static void SelectWhereTester()
        {
            // With Where condition
            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            var lowNums =
                from n in numbers
                where n < 5
                select n;

            Console.WriteLine("Numbers <5:");
            foreach (var x in lowNums)
            {
                Console.WriteLine(x);
            }

            Console.ReadLine();
        }
    }
}
