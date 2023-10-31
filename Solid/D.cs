#region Not Dependency Inversion Principle
public class NotLogger
{
    private DbLogger _dbLogger;
    private FileLogger _fileLogger;

    public NotLogger()
    {
        _dbLogger = new DbLogger();
        _fileLogger = new FileLogger();
    }

    public void LogToDatabase(string message)
    {
        _dbLogger.Log(message);
    }

    public void LogToFile(string message)
    {
        _fileLogger.Log(message);
    }
}

#endregion

#region Dependency Inversion Principle
public class Logger
{
    ILogger _logger;

    public Logger(ILogger logger)
    {
        _logger = logger;
    }

    public void Log(string message)
    {
        _logger.Log(message);
    }
}

#endregion
