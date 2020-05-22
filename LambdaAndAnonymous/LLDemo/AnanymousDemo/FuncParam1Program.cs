using System;
using System.Collections.Generic;
using System.Text;

namespace AnanymousDemo
{

    class FuncParam1Program
    {
        // Func<in T, out TResult>
        public static void ApplyFunction(int ix, Func<int, string> func)
        {
            Console.WriteLine(func(ix));
        }


         // Func<out TResult> Delegate
        public static void ApplyFunctionOut(Func<string> func)
        {
            Console.WriteLine(func());
        }
        public static void Main()
        {
            Func<int, string> sevenTimes = (i) => (i * 7).ToString();
            ApplyFunction(8, sevenTimes);

            ApplyFunction(9, (i) => { return (i * 13).ToString(); });
            //    ApplyFunctionOut(() => { return "This is a lambda expression"; });

        }
    }
}
