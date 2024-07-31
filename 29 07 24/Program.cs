using System;

public interface IWorker
{
    void Work();
}

public interface IHumanWorker : IWorker
{
    void Eat();
}

public class HumanWorker : IHumanWorker
{
    public void Work()
    {
        Console.WriteLine("Human working...");
    }

    public void Eat()
    {
        Console.WriteLine("Human eating...");
    }
}

public class RobotWorker : IWorker
{
    public void Work()
    {
        Console.WriteLine("Robot working...");
    }
}

public class WorkManager
{
    private readonly IWorker _worker;

    public WorkManager(IWorker worker)
    {
        _worker = worker;
    }

    public void ManageWork()
    {
        _worker.Work();
    }
}

class Program
{
    static void Main(string[] args)
    {
        IWorker humanWorker = new HumanWorker();
        IWorker robotWorker = new RobotWorker();

        WorkManager humanManager = new WorkManager(humanWorker);
        WorkManager robotManager = new WorkManager(robotWorker);

        humanManager.ManageWork();
        robotManager.ManageWork();
    }
}
