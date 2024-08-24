using System;
class Calculator
{
static void Main(string[] args)
{
int[] numbers = { 10, 20, 30, 40, 50 };
double average = CalculateAverage(numbers);
Console.WriteLine("Average: " + average);
}
static double CalculateAverage(int[] numbers)
{
if (numbers.Length == 0)
return 0;
int sum = 0;
foreach (int number in numbers)
{
sum += number;
}
return (double)sum / numbers.Length;
}
}