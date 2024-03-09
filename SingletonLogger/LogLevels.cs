namespace cs509_hands_on_9.SingletonLogger
{
    public static class LogLevel
    {
        public static readonly CommentLevel Comment = new();
        public static readonly WarningLevel Warning = new();
        public static readonly ErrorLevel Error = new();

    }

    public interface ILogLevel
    {
        ConsoleColor Color { get; }
        string Name { get; }

        void AfterEffect();

    }

    public class CommentLevel : ILogLevel
    {
        public ConsoleColor Color { get; } = ConsoleColor.White;
        public string Name { get; } = "Comment";

        // "For comments and warnings the program will not stop"
        public void AfterEffect() { }
    }

    public class WarningLevel : ILogLevel
    {
        // "a warning message will be yellow"
        public ConsoleColor Color { get; } = ConsoleColor.Yellow;
        public string Name { get; } = "Warning";

        // "For comments and warnings the program will not stop"
        public void AfterEffect() { }
    }

    public class ErrorLevel : ILogLevel
    {
        // "the color of an error message will be red"
        public ConsoleColor Color { get; } = ConsoleColor.Red;
        public string Name { get; } = "Error";

        public void AfterEffect()
        {
            // "ex. Log(Error, "divide by zero") OR Log(Error, exception.message) will output on the console "Error: divide by zero" or "Error exception occurred some message" and the program will stop."
            Environment.Exit(0);
        }
    }
}
