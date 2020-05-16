using System;
using System.Collections.Generic;
using System.Text;

namespace DelegateDemo
{

    //Subscribers
    public class SendViaMobile
    {
        public void sendMessage(string msg)
        {
            Console.WriteLine("Send to Mobile" + msg);
        }
        public void Subscribe(Publisher pub)
        {
            pub.publishmsg += sendMessage;
           // pub.publishmsg = null;
        }
    }
    public class SendViaEmail
    {
        public void sendEmail(string msg)
        {
            Console.WriteLine("Send to EMail" + msg);
        }
        public void Subscribe(Publisher pub)
        {
            pub.publishmsg += sendEmail;
         //   pub.publishmsg = null;
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
    class PublisherSubscriberModel
    {
        public static void ExecuteMain()
        {
            Publisher publisher = new Publisher();

            SendViaEmail SE = new SendViaEmail();
            SendViaMobile SM = new SendViaMobile();


            //Subscribing for Mobile notifications
            SM.Subscribe(publisher);

            //Emails are not subscribed so it wont receive notifications via Email
            SE.Subscribe(publisher);

            //Invoking the delegate Only Mobile will receive notifications.
            publisher.PublishMessage("\tHello You Have New Notifications");
        }

    }
}
