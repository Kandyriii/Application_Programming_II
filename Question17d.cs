using System;
using System.Collections.Generic;
class Program
{
static void Main(string[] args)
{
Dictionary<int, string> studentGrades = new Dictionary<int, string>();
studentGrades.Add(101, "A");
studentGrades.Add(102, "B");
studentGrades.Add(103, "C");
foreach (var student in studentGrades)
{
Console.WriteLine($"Student ID: {student.Key}, Grade: {student.Value}");
}
}
}