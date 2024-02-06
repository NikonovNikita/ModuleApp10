namespace FinalProject
{
    internal class Logger : ILogger
    {
        public void ColorTheException(Exception ex)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(ex.Message);
            Console.ForegroundColor = ConsoleColor.White;
        }

        public void Event(string eventText)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(eventText);
        }

        public void ShowResult(double value)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Результат операции: {value}");
        }
    }
}
