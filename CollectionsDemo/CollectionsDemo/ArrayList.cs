using System;
using System.Collections;

using System.Text;

namespace CollectionsDemo
{
    class MyArrayList 
    {
        static void MyArrayListMain(string[] args)
        {
            ArrayList a1 = new ArrayList();
            a1.Add(1);
            a1.Add("Example");
            a1.Add(true);

            Console.WriteLine(a1[0]);
            Console.WriteLine(a1[1]);
            Console.WriteLine(a1[2]);
            Console.ReadKey();
        }
    }
}
