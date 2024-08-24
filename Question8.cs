using System;
class NumberCheck
{
static void Main(string[] args)
{
Console.Write("Enter an integer: ");
int number = int.Parse(Console.ReadLine());
if (number > 0)
Console.WriteLine("Positive");
else if (number < 0)
Console.WriteLine("Negative");
else
Console.WriteLine("Zero");
if (number % 2 == 0)
Console.WriteLine("Even");
else
Console.WriteLine("Odd");
}
}