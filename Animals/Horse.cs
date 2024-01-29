using System;

public class Horse : IAnimal
{
    public string Name { get; set; }
    public string OwnerName { get; set; }
    public int Age { get; set; }

    public Horse() { }

    public Horse(string name, string ownerName, int age)
    {
        Name = name;
        OwnerName = ownerName;
        Age = age;
    }

    public void SayHello() => Console.WriteLine("Neigh!");
}