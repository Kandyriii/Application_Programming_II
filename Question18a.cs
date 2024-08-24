using System;
using System.Collections.Generic;
interface IDrive
{
void Drive();
}
class Car : IDrive
{
public void Drive()
{
Console.WriteLine("Car is driving.");
}
}
class Bike : IDrive
{
public void Drive()
{
Console.WriteLine("Bike is driving.");
}
}
class Program
{
static void Main(string[] args)
{
List<IDrive> vehicles = new List<IDrive>
{
new Car(), new Bike()
};
foreach (var vehicle in vehicles)
{
vehicle.Drive();
}
}
}