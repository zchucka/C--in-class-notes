using System;
using System.Collections.Generic;
using System.Text;

namespace Generics
{

    /*
     * Generic Methods and Generic Classes
        Generic method type parameter hides the type parameter of Generic classes. 
        CLR will not issue any warnings or errors, when we use the same type parameter name with both generic method and generic class.
        In the above generic method example, we have taken the same type parameter name which is used by generic class. 
        In the main method, we have passed the <int> type argument in the Helper class. In the method, we have passed the <string> argument.
     * */
    class Class_Method_Generic
    {
        static void Main(string[] args)
        {
            Helper<int> helper = new Helper<int>();
            helper.Method<string>("Hello");

            //Result:
            // Hello
        }
    }
    public class Helper<T>
    {
        public void Method<T>(T input)
        {
            Console.WriteLine(input);   //Result Hello
        }
    }


}
