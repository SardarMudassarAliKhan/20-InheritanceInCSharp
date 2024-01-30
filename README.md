Inheritance is a fundamental concept in object-oriented programming (OOP) where a class (known as a subclass or derived class) can inherit properties and behaviors (methods) from another class (known as a superclass or base class). This allows for code reuse and promotes a hierarchical relationship between classes.

In C#, you can implement inheritance using the ":" symbol followed by the name of the base class. Here's a simple example to illustrate:

```csharp
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
```

In this example, the class `Animal` is the base class, and the class `Dog` is the derived class. The `Dog` class inherits the `Eat()` and `Sleep()` methods from the `Animal` class, and it also has its own method `Bark()`. 

Through inheritance, the `Dog` class gains access to the behavior defined in the `Animal` class, allowing for code reuse and creating a logical hierarchy between different types of animals in this example.
