using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        
        Parrot parrot = new Parrot("Polly", "Alice", 5);
        Fish fish = new Fish("Goldie", "Bob", 2);
        Cat cat = new Cat("Whiskers", "Carol", 3);
        Horse horse = new Horse("Spirit", "Dave", 7);

        
        List<IAnimal> animals = new List<IAnimal> { parrot, fish, cat, horse };

        
        foreach (var animal in animals)
        {
            Console.WriteLine($"Animal: {animal.Name}, Owner: {animal.OwnerName}, Age: {animal.Age}");
            animal.SayHello();
        }
    }
}
