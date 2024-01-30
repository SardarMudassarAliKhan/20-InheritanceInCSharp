using System;

// Base class
class Animal
{
    public void Eat()
    {
        Console.WriteLine("Animal is eating.");
    }

    public void Sleep()
    {
        Console.WriteLine("Animal is sleeping.");
    }
}

// Derived class (inherits from Animal)
class Dog : Animal
{
    public void Bark()
    {
        Console.WriteLine("Dog is barking.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Creating an instance of Dog
        Dog myDog = new Dog();

        // Accessing methods from the base class
        myDog.Eat();  // Output: Animal is eating.
        myDog.Sleep(); // Output: Animal is sleeping.

        // Accessing method from the derived class
        myDog.Bark(); // Output: Dog is barking.
    }
}
