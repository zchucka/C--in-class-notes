using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQDemo
{
    class FirstOrDefault
    {
        public static void FirstOrDefaultTester()
        {
            //FirstOrDefault
            int[] numbers = { 1, 2, 3 };
            int firstNumOrDefault = numbers.FirstOrDefault();
            Console.WriteLine(firstNumOrDefault);
            Console.ReadLine();
        }
    }
}
