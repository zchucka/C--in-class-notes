using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQDemo
{
    class AggregateFuncs
    {
        public static void AggregateFuncsTester()
        {
            ////Count
            int[] factors = { 2, 2, 3, 5, 5 };

            int uniqueFactors = factors.Distinct().Count();

            Console.WriteLine("There are {0} unique factors", uniqueFactors);
            Console.ReadLine();

            //Sum
            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            double numSum = numbers.Sum();

            Console.WriteLine("The sum of the numbers is {0}.", numSum);
            Console.ReadLine();

            //Min
            int[] numbers1 = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            int minNum = numbers1.Min();
            Console.WriteLine("The minimum number is {0}.", minNum);
            Console.ReadLine();


            //Max         
            int maxNum = numbers.Max();
            Console.WriteLine("The maximum number is {0}.", maxNum);
            Console.ReadLine();

            //Average         
            double averageNum = numbers.Average();
            Console.WriteLine("The average number is {0}.", averageNum);
            Console.ReadLine();
        }
    }
}
