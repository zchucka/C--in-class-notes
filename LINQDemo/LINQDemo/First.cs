using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQDemo
{
    class First
    {
        public static void FirstTester()
        {
            ///First
            string[] strings = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            string startsWithO = strings.First();
            Console.WriteLine(startsWithO);

            //First with condition
            string startsWith1 = strings.First(s => s[0] == 'o');
            Console.WriteLine("A string starting with 'o': {0}", startsWith1);
            Console.ReadLine();
        }
    }
}
