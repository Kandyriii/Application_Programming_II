using System;
using System.Collections.Generic;
using System.Linq;
class Program
{
static (int min, int max) FindMinMax(List<int> numbers)
{
if (numbers == null || numbers.Count == 0)
{
return (0, 0);
}
int min = numbers.Min();
int max = numbers.Max();
return (min, max);
}
static void Main(string[] args)
{
List<int> numbers = new List<int> { 3, 7, 1, 9, 4 };
var result = FindMinMax(numbers);
Console.WriteLine($"Min: {result.min}, Max: {result.max}");
}
}