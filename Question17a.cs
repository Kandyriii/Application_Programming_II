using System;
using System.Collections.Generic;
class Program
{
static void Main(string[] args)
{
HashSet<int> uniqueNumbers = new HashSet<int>();
int sum = 0;
while (true)
{
Console.Write("Enter an integer (negative to stop): ");
int number = int.Parse(Console.ReadLine());
if (number < 0) break;
if (uniqueNumbers.Add(number))
{
sum += number;
}
}
Console.WriteLine($"Sum of unique numbers: {sum}");
}
}