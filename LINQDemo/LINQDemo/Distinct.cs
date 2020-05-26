using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQDemo
{
    class Distinct
    {
        public static void DistinctTester()
        {
            //Distinct
            int[] factors = { 2, 2, 3, 5, 5 };

            var uniqueFactors = factors.Distinct();

            Console.WriteLine("factors:");
            foreach (var f in uniqueFactors)
            {
                Console.WriteLine(f);
            }
            Console.ReadLine();
        }
    }
}
