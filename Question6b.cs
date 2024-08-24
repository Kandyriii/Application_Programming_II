using System;
enum Color
{
Red, Green, Blue
}
class Shape
{
public class Circle
{
public Color CircleColor { get; set; }
public Circle(Color color)
{
CircleColor = color;
}
public void DisplayColor()
{
Console.WriteLine("Circle color: " + CircleColor);
}
}
static void Main(string[] args)
{
Circle circle = new Circle(Color.Green);
circle.DisplayColor();
}
}