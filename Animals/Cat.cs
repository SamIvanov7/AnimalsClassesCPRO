using System;

public class Cat : IAnimal
{
    public string Name { get; set; }
    public string OwnerName { get; set; }
    public int Age { get; set; }

    public Cat() { }

    public Cat(string name, string ownerName, int age)
    {
        Name = name;
        OwnerName = ownerName;
        Age = age;
    }

    public void SayHello() => Console.WriteLine("Meow!");
}