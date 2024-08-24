using System;
class TrianglePattern
{
static void Main(string[] args)
{
int n = 5;
for (int i = 1; i <= n; i++)
{
for (int j = 1; j <= i; j++)
Console.Write("");
Console.WriteLine();
}
Console.WriteLine(); // Separator
for (int i = n; i >= 1; i)
{
for (int j = 1; j <= i; j++)
Console.Write("");
Console.WriteLine();
}
}
}
