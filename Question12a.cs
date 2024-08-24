using System;
using System.Collections.Generic;
class BankQueue
{
static void Main(string[] args)
{
Queue<string> regularQueue = new Queue<string>();
Queue<string> vipQueue = new Queue<string>();
regularQueue.Enqueue("Customer 1");
regularQueue.Enqueue("Customer 2");
vipQueue.Enqueue("VIP 1");
regularQueue.Enqueue("Customer 3");
vipQueue.Enqueue("VIP 2");
Console.WriteLine("Serving customers:");
while (vipQueue.Count > 0 || regularQueue.Count > 0)
{
if (vipQueue.Count > 0)
Console.WriteLine(vipQueue.Dequeue() + " (VIP)");
else if (regularQueue.Count > 0)
Console.WriteLine(regularQueue.Dequeue());
}
}
}