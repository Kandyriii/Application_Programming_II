using System;
abstract class Shape
{
public abstract void Draw();
}
class Circle : Shape
{
public double Radius { get; set; }
public Circle(double radius)
{
Radius = radius;
}
public override void Draw()
{
Console.WriteLine($"Drawing a Circle with Radius: {Radius}");
}
}
class Square : Shape
{
public double SideLength { get; set; }
public Square(double sideLength)
{
SideLength = sideLength;
}
public override void Draw()
{
Console.WriteLine($"Drawing a Square with Side Length: {SideLength}");
}
}
class Program
{
static void Main(string[] args)
{
Shape myCircle = new Circle(5.5);
Shape mySquare = new Square(4.0);
myCircle.Draw();
mySquare.Draw();
}
}
