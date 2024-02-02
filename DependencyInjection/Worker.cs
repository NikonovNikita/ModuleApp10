namespace DependencyInjection
{
    internal class WorkerOne : IWorker
    {
        ILogger Logger {  get; }

        public WorkerOne(ILogger logger)
        {
            Logger = logger;
        }

        public void Work()
        {
            Logger.Event("Worker начал свою работу. . .");
            Thread.Sleep(2000);
            Logger.Event("\nWorker окончил свою работу");
        }
    }

    internal class WorkerTwo : IWorker
    {
        ILogger Logger { get; }
        public WorkerTwo(ILogger logger)
        {
            Logger = logger;
        }

        public void Work()
        {
            Logger.Event("Worker 2 начал свою работу. . .");
            Thread.Sleep(2000);
            Logger.Event("\nWorker 2 окончил свою работу");
        }
    }
}
