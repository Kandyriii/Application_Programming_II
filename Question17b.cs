using System;
enum DaysOfWeek
{
Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday
}
class Program
{
static void Main(string[] args)
{
DaysOfWeek today = DaysOfWeek.Saturday;
switch (today)
{
case DaysOfWeek.Saturday:
case DaysOfWeek.Sunday:
Console.WriteLine("It's the weekend!");
break;
default:
Console.WriteLine("It's a weekday.");
break;
}
}
}