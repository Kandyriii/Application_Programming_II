using System;
class FactorialGenerator
{
static void Main(string[] args)
{
Console.Write("Enter a number: ");
int number = int.Parse(Console.ReadLine());
int factorial = 1;
for (int i = 1; i <= number; i++)
{
if (i % 2 != 0)
factorial = i;
}
Console.WriteLine($"Factorial of {number} (odd numbers only): {factorial}");
}
}