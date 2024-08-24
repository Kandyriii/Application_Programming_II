using System;
class Person
{
private string name;
private int age;
public string Name
{
get { return name; }
set { name = value; }
}
public int Age
{
get { return age; }
set
{
if (value >= 0)
age = value;
else
Console.WriteLine("Age cannot be negative.");
}
}
static void Main(string[] args)
{
Person person = new Person();
person.Name = "John";
person.Age = 25;
Console.WriteLine($"{person.Name}, Age: {person.Age}");
person.Age = 5;
}
}