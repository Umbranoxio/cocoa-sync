using CocoaSync.Data;
using Spectre.Console;

namespace CocoaSync;
public class Logger
{
    private string logFilePath;

    public Logger(string logFileName)
    {
        string baseDirectory = Config.GetDataPath();
        string logsDirectory = Path.Combine(baseDirectory, "logs");

        // Create the logs directory if it doesn't exist
        if (!Directory.Exists(logsDirectory))
        {
            Directory.CreateDirectory(logsDirectory);
        }

        this.logFilePath = Path.Combine(logsDirectory, logFileName);
    }

    public void Log(string? message, bool printToConsole = false)
    {
        string timestamp = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff");
        string logMessage = $"[{timestamp}] {message}";

        using (var logFile = new StreamWriter(this.logFilePath, append: true))
        {
            logFile.WriteLine(logMessage);
        }
        if (printToConsole && message != null)
        {
            AnsiConsole.MarkupLine(message);
        }
    }
}