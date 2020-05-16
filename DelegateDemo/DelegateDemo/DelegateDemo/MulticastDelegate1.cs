using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multicast_Delegates
{
    class TestDeleGate
    {
        public delegate void ShowMessage(string s);
        public void message1(string msg)
        {
            Console.WriteLine("1st Message is : {0}", msg);
        }
        public void message2(string msg)
        {
            Console.WriteLine("2nd Message is : {0}", msg);
        }
        public void message3(string msg)
        {
            Console.WriteLine("3rd Message is : {0}", msg);
        }
    }
    class MultiTestDeleGate
    {
        public static void ExecuteMain()
        {
            TestDeleGate td = new TestDeleGate();
            TestDeleGate.ShowMessage message = null;
            message += new TestDeleGate.ShowMessage(td.message1);
            message += new TestDeleGate.ShowMessage(td.message2);
            message += new TestDeleGate.ShowMessage(td.message3);
            message("Hello Multicast Delegates"); //Print Delegates 1 to 3
            message -= new TestDeleGate.ShowMessage(td.message2);
            Console.WriteLine("----------------------");
            message("Message 2 Removed"); //Print Delegates 1 and 3
            Console.ReadKey();
        }
    }
}