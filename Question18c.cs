using System;
using System.Collections.Generic;
abstract class Animal
{
public abstract void MakeSound();
}
class Dog : Animal
{
public override void MakeSound()
{
Console.WriteLine("Dog barks.");
}
}
class Cat : Animal
{
public override void MakeSound()
{
Console.WriteLine("Cat meows.");
}
}
class Program
{
static void Main(string[] args)
{
List<Animal> animals = new List<Animal>
{
new Dog(), new Cat()
};
foreach (var animal in animals)
{
animal.MakeSound();
}
}
}