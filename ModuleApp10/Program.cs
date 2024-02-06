namespace FinalProject
{
    class Program
    {
        static ILogger Logger { get; set; }
        static void Main(string[] args)
        {
            Logger = new Logger();
            Calculator calculator = new Calculator(Logger);
            try
            {
                calculator.StartProcess();
            }
            catch (Exception ex) when (ex is DivideByZeroException)
            {
                Console.WriteLine(ex.Message);
            }
        }

        
    }
}