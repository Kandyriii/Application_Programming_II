using System;
class Product
{
public string Name;
public double Price;
public Product()
{
Name = "Unknown";
Price = 0.0;
}
public Product(string name, double price)
{
Name = name;
Price = price;
}
static void Main(string[] args)
{
Product product1 = new Product();
Console.WriteLine(product1.Name + " " + product1.Price);
Product product2 = new Product("Laptop", 1500);
Console.WriteLine(product2.Name + " " + product2.Price);
}
}