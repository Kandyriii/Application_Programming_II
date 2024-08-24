using System;
interface IDrive
{
void Drive();
}
class Vehicle : IDrive
{
public virtual void Drive()
{
Console.WriteLine("Vehicle is driving.");
}
}
class Car : Vehicle
{
public override void Drive()
{
Console.WriteLine("Car is driving.");
}
}
class Bike : Vehicle
{
public override void Drive()
{
Console.WriteLine("Bike is driving.");
}
}
class Program
{
static void Main(string[] args)
{
IDrive myCar = new Car();
IDrive myBike = new Bike();
myCar.Drive();
myBike.Drive();
}
}