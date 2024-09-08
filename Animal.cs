
using System;

public class Animal
{
    public string Name { get; set; }

    public Animal(string name)
    {
        Name = name;
    }

    public virtual void Sound()
    {
        Console.WriteLine("The animal makes a sound.");
    }
}