using cs509_hands_on_9.SingletonLogger;
using cs509_hands_on_9.AnimalFactory;

// Animal factor
IAnimal Dog = AnimalFactory.Create(Animals.Dog);
Dog.speak();
IAnimal Cat = AnimalFactory.Create(Animals.Cat);
Cat.speak();

// Singleton logger implementation
SingletonLogger SL = SingletonLogger.Instance();
SL.Log(LogLevel.Comment, "Singleton logger comment!");
SL.Log(LogLevel.Warning, "Singleton logger warning!");

// Static logger implementation
StaticLogger.Log(LogLevel.Comment, "Static logger comment!");
StaticLogger.Log(LogLevel.Warning, "Static logger warning!");

// Error logging exits the program
SL.Log(LogLevel.Error, "Singleton logger error!");
StaticLogger.Log(LogLevel.Error, "Static logger error! You'll never see this because the previous error exited the program!");
