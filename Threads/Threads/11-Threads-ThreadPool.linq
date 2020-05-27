<Query Kind="Program">
  <Namespace>System.Threading.Tasks</Namespace>
</Query>

//using System.Threading.Tasks;
//You can enter the thread pool easily using the Task classes in the Task Parallel Library.
static void Main()    // The Task class is in System.Threading.Tasks
{
  Task.Factory.StartNew (Go); //To use the nongeneric Task class, call Task.Factory.StartNew, passing in a delegate of the target method
}
 
static void Go()
{
  Console.WriteLine ("Hello from the thread pool!");
}