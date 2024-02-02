namespace DependencyInjection
{
    internal class Logger : ILogger
    {
        public void Error(string message)
        {
            Console.WriteLine(message);
        }

        public void Event(string message)
        {
            Console.WriteLine(message);
        }
    }
}
