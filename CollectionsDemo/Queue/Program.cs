using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //  QueueDemo.QueueGeneric.QueueGenericMain
           // QueueActivities();
            ReportStackAndQueueResult();
            Console.ReadKey();
        }

        public static void QueueActivities()
        {
            Queue<string> numbers = new Queue<string>();
            numbers.Enqueue("one");
            numbers.Enqueue("two");
            numbers.Enqueue("three");
            numbers.Enqueue("four");
            numbers.Enqueue("five");

            // A queue can be enumerated without disturbing its contents.
            foreach (string number in numbers)
            {
                Console.WriteLine(number);
            }

            Console.WriteLine("\nDequeuing '{0}'", numbers.Dequeue());
            Console.WriteLine("Peek at next item to dequeue: {0}",
                numbers.Peek());
            Console.WriteLine("Dequeuing '{0}'", numbers.Dequeue());

            // Create a copy of the queue, using the ToArray method and the
            // constructor that accepts an IEnumerable<T>.
            Queue<string> queueCopy = new Queue<string>(numbers.ToArray());

            Console.WriteLine("\nContents of the first copy:");
            foreach (string number in queueCopy)
            {
                Console.WriteLine(number);
            }

            // Create an array twice the size of the queue and copy the
            // elements of the queue, starting at the middle of the 
            // array. 
            string[] array2 = new string[numbers.Count * 2];
            numbers.CopyTo(array2, numbers.Count);

            // Create a second queue, using the constructor that accepts an
            // IEnumerable(Of T).
            Queue<string> queueCopy2 = new Queue<string>(array2);

            Console.WriteLine("\nContents of the second copy, with duplicates and nulls:");
            foreach (string number in queueCopy2)
            {
                Console.WriteLine(number);
            }

            Console.WriteLine("\nqueueCopy.Contains(\"four\") = {0}",
                queueCopy.Contains("four"));

            Console.WriteLine("\nqueueCopy.Clear()");
            queueCopy.Clear();
            Console.WriteLine("\nqueueCopy.Count = {0}", queueCopy.Count);
        }

        public static Queue<string> GetTestQueue()
        {
            var q = new Queue<string>();
            q.Enqueue("Hallo");
            q.Enqueue("Welt");
            q.Enqueue("!");

            return q;
        }

        public static void ReportStackAndQueueResult()
        {
            var testQ = GetTestQueue();
            var testS = GetTestStack();

            Console.WriteLine("\nQueue-Behaviour: (FIFO)\n-----------------------");
            foreach (var i in testQ)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("\nStack-Behaviour: (LIFO)\n-----------------------");
            foreach (var i in testS)
            {
                Console.WriteLine(i);
            }
        }
        public static Stack<string> GetTestStack()
        {
            var s = new Stack<string>();
            s.Push("Hallo");
            s.Push("Welt");
            s.Push("!");

            return s;
        }
    }
}
