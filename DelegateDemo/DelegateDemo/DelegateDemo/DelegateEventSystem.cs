using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DelegateAndEventsSystem
{
    public class SendViaMobile
    {
        private void sendMessage(string msg)
        {
            Console.WriteLine("Send to Mobile:" + msg);
        }

        public void Subscribe(Publisher pub)
        {
            pub.publishevent += sendMessage;

            /*That means we cannot invoke or change the delegate event in outside classes other than Publisher Class.
             * Events are invoked in within the class itself.Outside classes do not have access to invoke the Delegate Event.
               It can appear only on left hand side of += or -= that means only appending or removing allowed No assignment.
               That means Event will hide the sensitive data of Delegate and exposes necessary data to outside world.
               This is the ideal example of Encapsulation principle in OOPS.
             * */
            //pub.publishevent = null;
            //pub.publishevent("Hello I called from Subscriber");
        }


    }
    public class SendViaEmail
    {

        public void sendEmail(string msg)
        {
            Console.WriteLine("Send to EMail:" + msg);
        }
        public void Subscribe(Publisher pub)
        {
            pub.publishevent += sendEmail;
        }
    }

    public class Publisher
    {
        public delegate void PublishMessageDel(string msg);
        public event PublishMessageDel publishevent = null;
        /*
         * PublishMessage() method in Publisher class. 
         * This method will invoke the delegate event internally. 
         * The outside classed can call PublishMessage() method to invoke delegate.
         * */
        public void PublishMessage(string message)
        {
            publishevent(message);

        }
    }
    class Program
    {
       public static void ExecuteMain()
        {
            Publisher publisher = new Publisher();
            SendViaMobile SM = new SendViaMobile();
            SendViaEmail SE = new SendViaEmail();
            SE.Subscribe(publisher);
            SM.Subscribe(publisher);
            publisher.PublishMessage("Hello Multicast Delegate");
        }
    }
}
