using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQDemo
{
    class GroupBy
    {
        public static void GroupByTester()
        {
            //GroupBy
            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            var numberGroups =
                from n in numbers
                group n by n % 5 into g
                select new { Remainder = g.Key, Numbers = g };

            Console.WriteLine("Remainders");

            foreach (var g in numberGroups)
            {

                Console.WriteLine(g.Remainder);

            }

            Console.ReadLine();
        }
    }
}
