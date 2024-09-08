using System;

public class Cat : Animal
{
    public Cat(string name) : base(name) { }

    public override void Sound()
    {
        Console.WriteLine("The cat meows.");
    }
}
