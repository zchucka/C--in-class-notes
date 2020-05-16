using System;
using System.Collections.Generic;
using System.Text;

namespace DelegateDemo
{
    class SingleCastDelegateNoReturn
    {
        public delegate void TestDelegate(String message);
        public void display(string message)
        {
            Console.WriteLine("{0} is the display message.", message);
        }
    }
    class DelegateNoReturns
    {
        public static void ExecuteMain()
        {
            SingleCastDelegateNoReturn testdelegate = new SingleCastDelegateNoReturn();
            SingleCastDelegateNoReturn.TestDelegate TD1 = new SingleCastDelegateNoReturn.TestDelegate(testdelegate.display);
            TD1("Hello");
        }
    }
}