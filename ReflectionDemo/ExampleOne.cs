using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionDemo
{
    class ExampleOne
    {

        public static void Execute()
        {
            Type m1;
            m1 = typeof(int); // should be System.Int32
            Console.WriteLine(m1.Name + " " + m1.FullName);

            m1 = typeof(System.Int32);
            Console.WriteLine(m1.Name + " " + m1.FullName);

            m1 = typeof(ExampleOne);
            Console.WriteLine(m1.Name + " " + m1.FullName);
        }

        public static void Execute2()
        {
            Type m1 = typeof(ExampleOne);
            MemberInfo[] n;

            n = m1.GetMembers();
            Console.WriteLine(n.Length);
            foreach (MemberInfo a in n)
            {
                Console.WriteLine(a.Name); // lists out all the possible functions for the type ExampleOne
            }

            foreach (MethodInfo a in m1.GetMethods())
            {
                object[] b = a.GetCustomAttributes(true);
                foreach (Attribute c in b)
                {
                    Console.WriteLine(c);
                }
            }

        }
    }
}
