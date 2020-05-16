using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace AsynchDelegate
{
    public class AsynchDelegate
    {
        delegate string AsynchDel();
        public static void AsynchDelegateMain()
        {
            AsynchDel delegateObj = LargeTask;
            delegateObj.BeginInvoke(new AsyncCallback(CallBackLargeTask), delegateObj);
            Console.WriteLine("New task is started!");
            Console.Read();
        }
        public static void CallBackLargeTask(IAsyncResult asyncResult)
        {
            AsynchDel doLargeTask = (AsynchDel)asyncResult.AsyncState;
            string message = doLargeTask.EndInvoke(asyncResult);
            Console.WriteLine(message);
        }
        public static string LargeTask()
        {
            Thread.Sleep(3000);
            return "success";
        }
    }
}
