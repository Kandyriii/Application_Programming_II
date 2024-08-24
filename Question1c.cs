using System;
class Employee
{
public string Name;
public int ID;
public string Department;
public double Salary;
public Employee(string name, int id)
{
Name = name;
ID = id;
Department = "Unknown";
Salary = 0.0;
}
public Employee(string name, int id, string department, double salary)
{
Name = name;
ID = id;
Department = department;
Salary = salary;
}
static void Main(string[] args)
{
Employee emp1 = new Employee("Alice", 101);
Console.WriteLine($"{emp1.Name}, ID: {emp1.ID}, Dept: {emp1.Department}, Salary: {emp1.Salary}");
Employee emp2 = new Employee("Bob", 102, "HR", 50000);
Console.WriteLine($"{emp2.Name}, ID: {emp2.ID}, Dept: {emp2.Department}, Salary: {emp2.Salary}");
}
}