using System;
class Program
{
    static void Main(string[] args)
    {
        ILoger logger = new ConsoleLoger();
        Application app = new Application(logger);
        app.Run();
    }
}

public interface ILoger
{
    void Log(string message);
}

public class ConsoleLoger : ILoger
{
    public void Log(string message)
    {
        Console.WriteLine($"[LOG]:{message}");
    }
}

public class Application
{
    private readonly ILoger _loger;

    public Application(ILoger loger)
    {
        _loger = loger;
    }

    public void Run()
    {
        _loger.Log("App is running");
    }
}