<Query Kind="Program" />

/*using System;
using System.Threading;*/

/*The semaphore class works similar to the Mutex class but lets you set a limit on how many threads have access to a critical section. 
It's often described as a nightclub (the semaphore) where the visitors (threads) stands in a queue outside the nightclub waiting for someone
to leave in order to gain entrance.*/
public class LockStatement 
{ 
//The SemaphoreSlim class represents a lightweight, fast semaphore that can be used for waiting within a single process when wait times are expected to be very short.
	static SemaphoreSlim _sem = new SemaphoreSlim (3); // Capacity of 3 
	
	public static void Main()
	{	
		//Console.Clear();
		for (int i = 1; i <= 8; i++) new Thread (Enter).Start (i); 
	}
	
	static void Enter (object id)
	{
		var id_ = (int) id;
		
		Console.WriteLine (id_ + " wants to enter");

		_sem.Wait();
		
		Console.WriteLine (id_ + " is in!"); // Only three threads
		
		Thread.Sleep(1000 * id_); // can be here at
		
		Console.WriteLine (id_ + " is leaving"); // a time.
		
		_sem.Release();
	}
}