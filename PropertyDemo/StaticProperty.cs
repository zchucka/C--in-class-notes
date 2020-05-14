using System;
using System.Collections.Generic;
using System.Text;

namespace PropertyDemo
{
    class StaticProperty
    {
        static int i2;
        public static int i
        {
            get
            {
                return i2;
            }
            set
            {
                i2 = value;
            }
        }

        public static void staticPropertyMain()
        {
            i = 10;
            Console.WriteLine(i);
        }
    }
}
