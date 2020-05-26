using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadingDemo
{
    class ThreadEx
    {
        public static void test()
        {
            System.Threading.Thread t = new System.Threading.Thread(WriteX);
            t.Start();

            for (int i = 0; i < 1000; i++)
            {
                Console.WriteLine("i");
            }
        }

        static void WriteX()
        {
            for (int i = 0; i < 1000; i++)
            {
                Console.WriteLine("x");
            }
        }
    }
}
