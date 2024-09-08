
public class Program
{
    public static void Main(string[] args)
    {
        Animal myAnimal = new Animal("Animal");
        // Polymorphism  
        Animal myDog = new Dog("Dog");
        Animal myCat = new Cat("Cat");

        myAnimal.Sound();
        myDog.Sound();
        myCat.Sound();
    }
}
