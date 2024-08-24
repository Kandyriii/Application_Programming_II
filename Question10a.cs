using System;
using System.IO;
class FileProcessor
{
static void Main(string[] args)
{
string inputFile = "input.txt";
string outputFile = "output.txt";
string keyword = "filter";
using (StreamReader reader = new StreamReader(inputFile))
using (StreamWriter writer = new StreamWriter(outputFile))
{
string line;
while ((line = reader.ReadLine()) != null)
{
if (line.Contains(keyword) && line.Length > 20)
{
writer.WriteLine(line);
}
}
}
Console.WriteLine("File processing complete.");
}
}