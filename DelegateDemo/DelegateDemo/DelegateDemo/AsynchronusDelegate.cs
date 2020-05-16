using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace DelegateDemo
{
    delegate int someDelegate(int x);
    
    class AsynchronusDelegate
    {
        static int SquareNumber(int x)
        {
            Console.WriteLine("SquareNumber invoked. Processing...");
            Thread.Sleep(2000);
            return x * x;
        }
       public static void ExecuteMain()
        {
            someDelegate sd = SquareNumber;
            Console.WriteLine("Before SquareNumber method invoke.");
            IAsyncResult asynRes = sd.BeginInvoke(10, null, null);

            Console.WriteLine("After SquareNumber invoked.");
            int res = sd.EndInvoke(asynRes);
            Console.WriteLine(res);
            Console.ReadLine();
        }
    }
}
