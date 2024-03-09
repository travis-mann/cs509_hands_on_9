namespace cs509_hands_on_9.AnimalFactory
{
    public enum Animals
    {
        Dog,
        Cat
    }
    
    public static class AnimalFactory
    {
        public static IAnimal Create(Animals a)
        {
            if (a == Animals.Dog)
            {
                return new Dog();
            }
            else if (a == Animals.Cat)
            {
                return new Cat();
            }
            else
            {
                throw new ArgumentException("Unknown animal specified");
            }
        }
    }

    public interface IAnimal
    {
        void speak();
    }

    internal class Dog : IAnimal
    {
        public void speak()
        {
            Console.WriteLine("woof");
        }
    }

    internal class Cat : IAnimal
    {
        public void speak()
        {
            Console.WriteLine("meow");
        }
    }
}
