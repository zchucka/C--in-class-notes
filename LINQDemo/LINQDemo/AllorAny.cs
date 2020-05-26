using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQDemo
{
    class AllorAny
    {
        public static void AllorAnyTester()
        {
            ////All
            int[] numberso = { 1, 11, 3, 19, 41, 65, 19 };

            bool onlyOdd = numberso.All(n => n % 2 == 1); // returns true if all ints are odd

            Console.WriteLine("The list contains only odd numbers: {0}", onlyOdd);

            //any
            IEnumerable<string> strings = new List<string> { "one", "two", "three" };
            bool anyResult = strings.Any(val => val.Contains("e"));
            Console.WriteLine(anyResult);

            Console.ReadLine();
        }
    }
}
