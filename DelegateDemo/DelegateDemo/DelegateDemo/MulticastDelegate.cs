using System;
/*
 *Purpose Of Multicast Delegate in C#:
So where we  can use multicast delegates in our daily projects.
Everyone will have Facebook account rite. 
Whenever we get any notifications we will be receiving SMS and as well as emails.
Facebook will publish notifications and we will receive notifications to Mobile and Email.
This is like publisher and subscriber Model.
*/
/*
 * The Code is easy to Understand I declared two Subscribers “SendViaEmail” and “SendViaSMS”. 
 * And in publisher class I declared one Delegate which takes string parameter and returns void.
   And For invoking delegate I wrote one more method called “PublishMethod”  
   (You will understand why I wrote this method at the end of this post)
 * */

namespace MulticastDelegate
{

    //Subscribers
    public class SendViaMobile
    {
        public void sendMessage(string msg)
        {
            Console.WriteLine("Send to mobile" + msg);
        }
    }
    public class SendViaEmail
    {
        public void sendEmail(string msg)
        {
            Console.WriteLine("Send to email" + msg);
        }
    }

    //Publisher
    public class Publisher
    {
        //Declare Delegate
        public delegate void PublishMessageDel(string msg);

        //Define Delegate
        public PublishMessageDel publishmsg = null;
        //Method used to Invoke Delegate
        public void PublishMessage(string message)
        {
            //Invoke Delegate
            publishmsg.Invoke(message);
        }
    }

   
    class Program
    {
      
        public static void ExecuteMain()
        {
           /* Example obj = new Example();
            // 2. Instantiation
            MyDelagate multicastdel = new MyDelagate(obj.Sum);
            multicastdel += new MyDelagate(obj.Difference);

            // 3. Invocation
            multicastdel(50, 20);*/

            Publisher publisher = new Publisher();

            SendViaEmail SE = new SendViaEmail();
            SendViaMobile SM = new SendViaMobile();

            publisher.publishmsg += SE.sendEmail;
            publisher.publishmsg += SM.sendMessage;

            publisher.PublishMessage(" you have new notifications");
        }
    }
/*
    //1. Declaration
    public delegate void MyDelagate(int a, int b);
    public class Example
    {
        // methods to be assigned and called by delegate
        public void Sum(int a, int b)
        {
            Console.WriteLine("Sum of integers is = " + (a + b));
        }

        public void Difference(int a, int b)
        {
            Console.WriteLine("Difference of integer is = " + (a - b));
        }
    }
    */
}