using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadingDemo
{
    class LifeCycle
    {
        public static void test()
        {
            new Thread(Go).Start();
            Go();
        }

        static void Go()
        {
            for (int cycles = 0; cycles < 5; cycles++)
            {
                Console.WriteLine("?");
            }
            Console.WriteLine("one call ends");
        }
    }
}
