using System;

public class Fish : IAnimal
{
    public string Name { get; set; }
    public string OwnerName { get; set; }
    public int Age { get; set; }

    public Fish() { }

    public Fish(string name, string ownerName, int age)
    {
        Name = name;
        OwnerName = ownerName;
        Age = age;
    }

    public void SayHello() => Console.WriteLine("Blub blub!");
}