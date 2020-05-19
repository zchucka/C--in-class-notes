using System;
using System.Collections.Generic;
using System.Text;

namespace Generics
{

    public class Check
    {
        public bool Compare(int a, int b)
        {
            if (a == b)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }

    public class Check<REPLACEDATATYPE>
    {
        public bool Compare(REPLACEDATATYPE a, REPLACEDATATYPE b)
        {
            if (a.Equals(b))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
    class Compare
    {
        static void Main(string[] args)
        {
            Check<int> objCheck = new Check<int>();
            bool result = objCheck.Compare(1, 4);
            Console.Write(result);


            Check<string> objCheck1 = new Check<string>();
            bool result1 = objCheck1.Compare("Hi", "Hi");
            Console.Write(result1);

        }
    }
}
