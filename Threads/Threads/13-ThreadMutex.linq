<Query Kind="Program" />

/*
What is Mutex?
Mutex in C# also works likes a lock i.e. acquired an exclusive lock on a shared resource from concurrent access, but it works across multiple processes. 
As we already discussed exclusive locking is basically used to ensure that at any given point of time, only one thread can enter into the critical section.

The Mutex class provides the WaitOne() method which we need to call to lock the resource and similarly it provides ReleaseMutex() which is used to unlock the resource. 
Note that a Mutex can only be released from the same thread which obtained it.
*/
namespace MutexDemo
{
    class Program
    {   
        private static Mutex mutex = new Mutex();

        static void Main(string[] args)
        {
            //Create multiple threads to understand Mutex
            for (int i = 1; i <= 5; i++)
            {
                Thread threadObject = new Thread(MutexDemo);
                threadObject.Name = "Thread " + i;
                threadObject.Start();
            }
         //   Console.ReadKey();
        }

        //Method to implement syncronization using Mutex  
        static void MutexDemo()
        {
            Console.WriteLine(Thread.CurrentThread.Name + " Wants to Enter Critical Section for processing");
            try
            {
                //Blocks the current thread until the current WaitOne method receives a signal.  
                //Wait until it is safe to enter. 
                mutex.WaitOne();  
                Console.WriteLine("Success: " + Thread.CurrentThread.Name + " is Processing now");
                Thread.Sleep(2000);
                Console.WriteLine("Exit: " + Thread.CurrentThread.Name + " is Completed its task");
            }
            finally
            {
                //Call the ReleaseMutex method to unblock so that other threads
                //that are trying to gain ownership of the mutex.  
                mutex.ReleaseMutex();
            }
        }
    }
}