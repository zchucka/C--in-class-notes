using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQDemo
{
    class OrderBy
    {
        public static void OrderByTester()
        {
            ////OrderBy
            string[] words = { "cherry", "apple", "blueberry" };

            var sortedWords =
                from w in words
                orderby w
                select w;

            Console.WriteLine("The sorted list of words:");
            foreach (var w in sortedWords)
            {
                Console.WriteLine(w);
            }


            //descending
            double[] doubles = { 1.7, 2.3, 1.9, 4.1, 2.9 };

            var sortedDoubles =
                from d in doubles
                orderby d descending
                select d;

            Console.WriteLine("The doubles from highest to lowest:");
            foreach (var d in sortedDoubles)
            {
                Console.WriteLine(d);
            }
            Console.ReadLine();
        }
    }
}
