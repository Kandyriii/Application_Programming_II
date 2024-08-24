using System;
class ArraySum
{
static int SumJaggedArray(int[][] jaggedArray)
{
int sum = 0;
foreach (int[] array in jaggedArray)
{
foreach (int value in array)
{
sum += value;
}
}
return sum;
}
static void Main(string[] args)
{
int[][] jaggedArray = new int[][]
{
new int[] { 1, 2, 3 }, new int[] { 4, 5 }, new int[] { 6, 7, 8, 9 }
};
int sum = SumJaggedArray(jaggedArray);
Console.WriteLine("Sum of all elements: " + sum);
}
}