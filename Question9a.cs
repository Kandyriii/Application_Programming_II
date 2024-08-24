using System;
using System.Threading;
class ThreadExample
{
static int counter = 0;
static object lockObject = new object();
static void IncrementCounter()
{
for (int i = 0; i < 10; i++)
{
lock (lockObject)
{
counter++;
Console.WriteLine($"Counter: {counter}");
}
Thread.Sleep(100);
}
}
static void Main(string[] args)
{
Thread thread = new Thread(IncrementCounter);
thread.Start();
thread.Join();
Console.WriteLine("Thread has finished execution.");
}
}