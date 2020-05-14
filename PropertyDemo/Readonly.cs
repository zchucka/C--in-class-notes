using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.Text;

namespace PropertyDemo
{
    class Readonly
    {
        int f1 = 10;
        public int ff // read only that allows us to change internally
        {
            get
            {
                System.Console.WriteLine("in get");
                return f1;
            }
        }

        public static void ReadonlyMain()
        {
            Readonly a = new Readonly();

            int gg = a.ff + 9;
            Console.WriteLine(gg);
        }
    }

    
}
