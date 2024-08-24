using System;
class ListManager
{
static void Main(string[] args)
{
int[] numbers = { 1, 2, 3 };
try
{
try
{
Console.WriteLine(numbers[5]);
}
catch (IndexOutOfRangeException ex)
{
Console.WriteLine("Index out of range: " + ex.Message);
}
int number = int.Parse("invalid");
}
catch (FormatException ex)
{
Console.WriteLine("Format error: " + ex.Message);
}
finally
{
Console.WriteLine("Operation completed.");
}
}
}