using System;
using System.Collections.Generic;
using System.Text;

namespace PropertyDemo
{
    abstract class AbstractProperty
    {
        public abstract int i
        {
            get;
            set;
        }
    }

    class yyy : AbstractProperty // inherits our abstract class and override int
    {
        int i2;
        public override int i
        {
            get
            {
                System.Console.WriteLine("get");
                return i2;
            }
            set
            {
                System.Console.WriteLine("set " + value);
                i2 = value;
            }
        }
    }

    class AbstractExample
    {
        public static void ExampleMain()
        {
            yyy a = new yyy();
            a.i = 100;
            System.Console.WriteLine(a.i);
        }
    }

}
