using System;
using Newtonsoft.Json;
class Program
{
class Address
{
public string Street { get; set; }
public string City { get; set; }
}
class Person
{
public string Name { get; set; }
public int Age { get; set; }
public Address Address { get; set; }
}
static void Main(string[] args)
{
Person person = new Person
{
Name = "John", Age = 30, Address = new Address { Street = "123 Main St", City = "Anytown" }
};
string json = JsonConvert.SerializeObject(person, Formatting.Indented);
Console.WriteLine("Serialized JSON:\n" + json);
Person deserializedPerson = JsonConvert.DeserializeObject<Person>(json);
Console.WriteLine($"\nDeserialized Person:\nName: {deserializedPerson.Name}, Age: {deserializedPerson.Age}, Street: {deserializedPerson.Address.Street}, City:
{deserializedPerson.Address.City}");
}
}