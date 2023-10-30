public class DbLogger : ILogger
{
    public void Log(string message)
    {
        Console.WriteLine($"DbLogger: {message}");
    }
}
