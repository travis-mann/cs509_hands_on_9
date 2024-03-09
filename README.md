# CS 509 Hands-On 9

Note: Run Program.cs to test the singleton logger, static logger and animal factory
1. Singleton logger implementation in SingletonLogger/SingletonLogger.cs
2. Static logger implementation in SingletonLogger/StaticLogger.cs
3. Animal factory implementation in AnimalFactory/Animal.cs

## Assignment:

Implement a console logger using the singleton design pattern. Your logger should have three levels of reporting,
1. Comment
2. Warning
3. Error

ex. Log(Error, "divide by zero") OR Log(Error, exception.message) will output on the console "Error: divide by zero" or "Error exception occurred some message" and the program will stop. For comments and warnings the program will not stop, however the color of an error message will be red and a warning message will be yellow. Next, re-implement the logger using only static (no singleton). Do you like the singleton or static only (no singleton) way to implement a logger?

For the given pseudocode:

```C#
interface IAnimal
{
    void speak();
}

class Dog : IAnimal
{
    void speak()
    {
        print "woof"
    }
}

class Cat: IAnimal
{
    void speak()
    {
        print "meow"
    }
}
```

Implement a factory in order to create Dog and Cat Objects. Which factory style did you choose and why?

 

Upload all your source code to github.
