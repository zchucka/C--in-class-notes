<Query Kind="Program" />

namespace threadingSemaphore
{
class SemaphoreExample
    {
        static Thread[] threads = new Thread[10];
		// Create a semaphore that can satisfy up to three
        // concurrent requests. Use an initial count of zero,
        // so that the entire semaphore count is initially
        // owned by the main program thread.
        static Semaphore sem = new Semaphore(2, 3);//Initializes a new instance of the Semaphore class,specifying the maximum number of concurrent entries and optionallyreserving some entries.
        static void C_Semaphore()
        {
            Console.WriteLine("{0} is waiting in line...", Thread.CurrentThread.Name);
            sem.WaitOne();
            Console.WriteLine("{0} enters the C_Semaphore!", Thread.CurrentThread.Name);
            Thread.Sleep(300);
            Console.WriteLine("{0} is leaving the C_Semaphore", Thread.CurrentThread.Name);
            sem.Release();
        }
       static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                threads[i] = new Thread(C_Semaphore);
                threads[i].Name = "thread_" + i;
                threads[i].Start();
            }
         //  Console.Read();
         }
    }
}