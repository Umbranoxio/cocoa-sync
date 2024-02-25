using CocoaSync.Data;
using Spectre.Console;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Text;
using System.Security.Principal;

namespace CocoaSync;

public class Program
{
    static void Main()
    {
        IntitialChecks();
        var mappings = SearchForPrograms();

        if (mappings != null)
        {
            DisplayFoundPrograms(mappings);
            var selectedMappings = PromptForProgramSelection(mappings);
            InstallSelectedPrograms(selectedMappings);
        }
        Console.ReadKey();
    }

    static void IntitialChecks()
    {
        Console.Title = "Cocoa Sync";
        Console.OutputEncoding = Encoding.UTF8;
        if (!RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
        {
            Console.WriteLine("This application is only supported on Windows.");
            Console.ReadKey();
            Environment.Exit(1);
        }
        using (WindowsIdentity identity = WindowsIdentity.GetCurrent())
        {
            WindowsPrincipal principal = new WindowsPrincipal(identity);
            bool isElevated = principal.IsInRole(WindowsBuiltInRole.Administrator);

            if (!isElevated)
            {
                Console.WriteLine("This application requires elevated permissions to run. Please run as administrator.");
                Console.ReadKey();
                Environment.Exit(1);
            }
        }
    }

    static List<ProgramMapping>? SearchForPrograms()
    {
        var searcher = new ProgramSearcher();
        List<ProgramMapping>? mappings = null;

        AnsiConsole.Status()
            .Spinner(Spinner.Known.Dots12)
            .Start("Searching for locally installed programs on chocolatey!...", ctx =>
            {
                mappings = searcher.GetMappings().Result;
            });

        return mappings;
    }

    static void DisplayFoundPrograms(List<ProgramMapping> mappings)
    {
        AnsiConsole.MarkupLine($"[green]Found {mappings.Count} potential matches on chocolatey![/]");
        AnsiConsole.WriteLine("Format: (Locally Installed Program) -> (Chcolatey Id)");
        AnsiConsole.WriteLine("");
    }

    static IEnumerable<ProgramMapping> PromptForProgramSelection(List<ProgramMapping> mappings)
    {
        var prompt = new MultiSelectionPrompt<ProgramMapping>()
            .Title("Please select the programs you wish to upgrade to chocolatey!")
            .UseConverter(mapping => mapping.InstalledProgram != null
            ? $"({mapping.InstalledProgram.Name ?? ""}{(mapping.InstalledProgram.Version != null ? " - " + mapping.InstalledProgram.Version : string.Empty)}) -> ({mapping.ChocolateyId})"
            : $"(Unknown Program) -> ({mapping.ChocolateyId})")
            .AddChoices(mappings);

        return AnsiConsole.Prompt(prompt);
    }

    static void InstallSelectedPrograms(IEnumerable<ProgramMapping> selectedMappings)
    {
        if (!Directory.Exists("logs"))
        {
            Directory.CreateDirectory("logs");
        }

        foreach (var mapping in selectedMappings)
        {
            InstallProgram(mapping);
        }
    }

    static void InstallProgram(ProgramMapping mapping)
    {
        var startInfo = new ProcessStartInfo
        {
            FileName = "cmd.exe",
            Arguments = $"/c choco install {mapping.ChocolateyId} -y",
            UseShellExecute = false,
            RedirectStandardOutput = true,
            CreateNoWindow = true
        };

        using (var process = Process.Start(startInfo))
        {
            if (process == null)
            {
                AnsiConsole.MarkupLine($"[red]Failed to install {mapping.ChocolateyId}. Failed to create process.[/]");
                return;
            }

            AnsiConsole.Status()
                .Spinner(Spinner.Known.Dots12)
                .Start($"Installing {mapping.ChocolateyId}...", ctx =>
                {
                    if (mapping.ChocolateyId != null)
                    {
                        LogProcessOutput(process, mapping.ChocolateyId);
                        HandleProcessCompletion(process, mapping.ChocolateyId);
                    }
                });
        }
    }

    static void LogProcessOutput(Process process, string chocolateyId)
    {
        // Create a new log file with the Chocolatey ID as the name
        using (var logFile = new StreamWriter(Path.Combine("logs", $"{chocolateyId}.log")))
        {
            // Read the output from the process and write it to the log file
            while (!process.StandardOutput.EndOfStream)
            {
                var line = process.StandardOutput.ReadLine();
                logFile.WriteLine(line);
            }
        }
    }

    static void HandleProcessCompletion(Process process, string chocolateyId)
    {
        process.WaitForExit();

        if (process.ExitCode == 0)
        {
            AnsiConsole.MarkupLine($"[green]Successfully installed {chocolateyId}![/]");
        }
        else
        {
            AnsiConsole.MarkupLine($"[red]Failed to install {chocolateyId}.[/]");
        }
    }
}
