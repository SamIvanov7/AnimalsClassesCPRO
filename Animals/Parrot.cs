using System;


public class Parrot : IAnimal
{
    public string Name { get; set; }
    public string OwnerName { get; set; }
    public int Age { get; set; }

    public Parrot() { }

    public Parrot(string name, string ownerName, int age)
    {
        Name = name;
        OwnerName = ownerName;
        Age = age;
    }

    public void SayHello()
    {
        Console.WriteLine("Squawk!");
    }
}