using System;
using System.Collections;

namespace QueueDemo
{
    class SamplesQueue
    {
        public static void SamplesQueueMain()
        {

            // Creates and initializes a new Queue.
            System.Collections.Queue myQ = new System.Collections.Queue();
            
            myQ.Enqueue("Hello");
            myQ.Enqueue("World");
            myQ.Enqueue("!");

            // Displays the properties and values of the Queue.
            Console.WriteLine("myQ");
            Console.WriteLine("\tCount:    {0}", myQ.Count);
            Console.Write("\tValues:");
            PrintValues(myQ);
        }

        public static void PrintValues(IEnumerable myCollection)
        {
            foreach (Object obj in myCollection)
                Console.Write("    {0}", obj);
            Console.WriteLine();
        }
    }
}
