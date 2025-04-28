using System;
class Program
{
    static void Main(string[] args)
    {
        var mockLoger = new MockLoger();
        Application app = new Application(mockLoger);
        app.Run();
        Console.WriteLine("Logged messages: ");
        foreach (var message in mockLoger.Messages)
        {
            Console.WriteLine("- "+message);
        }
    }
}

public interface ILoger
{
    void Log(string message);
    
}

public class MockLoger : ILoger
{
    public List<string>Messages = new List<string>();
    public void Log(string message)
    {
        Messages.Add(message);
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