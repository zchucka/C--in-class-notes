using System;
using System.Collections.Generic;
using System.Text;

namespace PropertyDemo
{
    class Readwrite
    {
        int f1;
        public int ff
        {
            get
            {
                System.Console.WriteLine("in get");
                return f1;
            }
            set
            {
                Console.WriteLine("in set " + value);
                f1 = value;
            }
        }

        public static void readWriteMain()
        {
            Readwrite rwObj = new Readwrite();
            rwObj.ff = 20;

            Console.WriteLine(rwObj.ff);
        }
    }
}
