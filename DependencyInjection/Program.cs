namespace DependencyInjection
{
    class Program
    {
        static ILogger Logger { get; set; }
        static void Main()
        {
            Logger = new Logger();
            
            var workerOne = new WorkerOne(Logger);
            var workerTwo = new WorkerTwo(Logger);

            workerOne.Work();
            workerTwo.Work();
        }
    }
}
