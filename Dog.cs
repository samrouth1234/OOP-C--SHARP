using System;

public class Dog : Animal
{
    public Dog(string name) : base(name) { }

    public override void Sound()
    {
        Console.WriteLine("The dog barks.");
    }
}
