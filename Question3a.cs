using System;
using System.IO;
class Library
{
static void Main(string[] args)
{
string filePath = "books.txt";
File.WriteAllText(filePath, "Book1\nBook2\nBook3");
string content = File.ReadAllText(filePath);
Console.WriteLine("Books List:\n" + content);
File.AppendAllText(filePath, "Book4\n");
string updatedContent = File.ReadAllText(filePath);
Console.WriteLine("Updated Books List:\n" + updatedContent);
}
}