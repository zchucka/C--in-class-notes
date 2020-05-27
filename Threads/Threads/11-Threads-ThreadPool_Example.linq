<Query Kind="Program" />

public class Program
{
	public static void Main()
	{
		
		ThreadPool.QueueUserWorkItem((e) => Foo());
		ThreadPool.QueueUserWorkItem((e) => Foo());
		ThreadPool.QueueUserWorkItem((e) => Foo());
		ThreadPool.QueueUserWorkItem((e) => Foo());
		
		Thread.Sleep(6000);
		
		ThreadPool.QueueUserWorkItem(new Program().testThread1);
        ThreadPool.QueueUserWorkItem(new Program().testThread2);
			
	}
	
	public static void Foo() {
		
	    var cnt = 4;
		var s = string.Format("asdasdasd {0}", cnt);
		lock (string.Intern(s)) {
		    Console.WriteLine("Enter to lock");
			Thread.Sleep(1000);
			Console.WriteLine("Exit from lock");
		}
		
	}
	
	
	 public void testThread1(Object threadContext)
        {
            //executing in thread
            int count = 0;
            while (count++ < 5)
            {
                Console.WriteLine("Thread 1 Executed "+count+" times");
                Thread.Sleep(100);
            }
        }
 
        public void testThread2(Object threadContext)
        {
            //executing in thread
            int count = 0;
            while (count++ < 5)
            {
                Console.WriteLine("Thread 2 Executed " + count + " times");
                Thread.Sleep(100);
            }
        }
}
