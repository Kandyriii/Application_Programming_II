using System;
class Animal
{
public virtual void Speak()
{
Console.WriteLine("Animal speaks.");
}
}
class Dog : Animal
{
public override void Speak()
{
Console.WriteLine("Dog barks.");
}
}
class Cat : Animal
{
public override void Speak()
{
Console.WriteLine("Cat meows.");
}
}
class Bird : Animal
{
public override void Speak()
{
Console.WriteLine("Bird chirps.");
}
}
class Program
{
static void Main(string[] args)
{
Animal myDog = new Dog();
Animal myCat = new Cat();
Animal myBird = new Bird();
myDog.Speak();
myCat.Speak();
myBird.Speak();
}
}