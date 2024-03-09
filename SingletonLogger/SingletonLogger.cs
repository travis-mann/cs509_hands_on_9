using cs509_hands_on_9.SingletonLogger;

class SingletonLogger
{
    private static SingletonLogger? instance = null;
    private static readonly object locker = new();

    private SingletonLogger()
    {

    }

    public static SingletonLogger Instance()
    {
        // thread safe singleton implementation
        if (instance == null)
        {
            lock (locker)
            {
                if (instance == null)
                {
                    instance = new SingletonLogger();
                }
            }
        }
        return instance;
    }

    public void Log(ILogLevel LogLevel, string message)
    {
        Console.ForegroundColor = LogLevel.Color;
        Console.WriteLine($"{LogLevel.Name}: {message}");
        Console.ResetColor();
        LogLevel.AfterEffect();
    }
}