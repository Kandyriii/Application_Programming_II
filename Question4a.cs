using System;
class DataTypeDemo
{
static void Main(string[] args)
{
int a = 10;
int b = a;
Console.WriteLine($"Value Type: a={a}, b={b} (b is a copy of a)");
string[] array1 = { "Hello", "World" };
string[] array2 = array1;
Console.WriteLine($"Reference Type: array1==array2:
{Object.ReferenceEquals(array1, array2)}");
array2[0] = "Hi";
Console.WriteLine($"Updated array1[0]: {array1[0]}"); // Reflects change in
array2 because they reference the same memory
}
}