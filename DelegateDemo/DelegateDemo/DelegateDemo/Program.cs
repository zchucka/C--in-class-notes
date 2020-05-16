using System;
/// <summary>
/// https://itnext.io/delegates-anonymous-methods-and-lambda-expressions-5ea4e56bbd05
/// </summary>
namespace DelegateDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            /*  DelegateNoReturns.ExecuteMain();
              DelegateNoParams.ExecuteMain();
              SingleCast.ExecuteMain();
              MulticastDelegate.Program.ExecuteMain();
              Multicast_Delegates.MultiTestDeleGate.ExecuteMain();*/
            // AsynchronusDelegate.ExecuteMain();

            // 1. SimpleDelegate
           //SimpleDelegate.ExecuteMain();
             //2. WhyDelegate
           /* string[] arg = new string[3];
            arg[0] = "1"; // tells us which operation we are doing
            arg[1] = "3"; // tells us our first and second ints we are doing them on
            arg[2] = "4";

            Client.ExecuteMain(arg);  */

            //3. Why not one delegate for many methods?
          // MulticastDelegate.Program.ExecuteMain();

            //4. look like Publisher/Subscriber Model.
            /*But the problem with the above code is it’s more over like “Master and Slave model”.
             * That means You are not subscribed to Mobile notifications but still Facebook sending notifications to your mobile.
               In the above code subscribers do not have rights to decline notifications.
               Publisher only sending notifications irrespective of subscriber interests.
               This is not ideal Publisher/Subscriber Model.
               First Subscribers has to subscribe for notification then only it should receive notifications.
            */
            //PublisherSubscriberModel.ExecuteMain(); 

            /* //5. Events
             * Enable pub.publishmsg = null; in mobile subscriber then email subscriber won't recv notification eventhough he 
             * has subscribed. That means we are violating Encapsulation principle
             * So What is the solution?
                We should not expose delegate to subscribe (In that case it will become Master Slave Model)
                If we expose also we should not give permissions to subscriber to change or invoke delegate.
                That means it should only assign some methods or functions to Delegate.
                The Second solution seems to be good right. That’s how Events Came into Picture.
             */
           DelegateAndEventsSystem.Program.ExecuteMain();


            //6. AsynchDelegate
            // AsynchDelegate.AsynchDelegate.AsynchDelegateMain();
        }
    }
}
