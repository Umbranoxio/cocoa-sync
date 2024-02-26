using System.Text.Json;

namespace CocoaSync.Data;

public class Config
{
    public List<string> PublisherIgnoreList { get; set; }
    public List<ProgramMapping> SelectedMappings { get; set; }
    public List<KnownMapping> KnownMappings { get; set; }

    public Config()
    {
        PublisherIgnoreList = new List<string>
        {
            "NVIDIA Corporation",
            "Microsoft Corporation",
            "Microsoft",
            "Python Software Foundation",
            "Oracle Corporation",
            "Adobe Inc",
            "Unknown",
            "Advanced Micro Devices, Inc.",
            "Realtek"
        };

        KnownMappings = new List<KnownMapping>
        {
            new KnownMapping { PackageName = "Notepad++", ChocolateyId = "notepadplusplus" },
        };

        SelectedMappings = new List<ProgramMapping>();
    }

    public static string GetDataPath()
    {
        string appDataPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
        string cocoaSyncPath = Path.Combine(appDataPath, "cocoa-sync");

        // Create the directory if it doesn't exist
        if (!Directory.Exists(cocoaSyncPath))
        {
            Directory.CreateDirectory(cocoaSyncPath);
        }

        return cocoaSyncPath;
    }

    private static string GetConfigFilePath()
    {
        string cocoaSyncPath = GetDataPath();
        string configFilePath = Path.Combine(cocoaSyncPath, "config.json");

        return configFilePath;
    }

    public static void SaveToJson(Config config)
    {
        string configFilePath = GetConfigFilePath();

        var json = JsonSerializer.Serialize(config, new JsonSerializerOptions { WriteIndented = true });
        File.WriteAllText(configFilePath, json);
    }

    public static Config Load()
    {
        string configFilePath = GetConfigFilePath();

        if (!File.Exists(configFilePath))
        {
            return SaveDefaultConfig();
        }

        var json = File.ReadAllText(configFilePath);
        var config = JsonSerializer.Deserialize<Config>(json);

        return config ?? SaveDefaultConfig();
    }

    private static Config SaveDefaultConfig()
    {
        var defaultConfig = new Config();
        SaveToJson(defaultConfig);
        return defaultConfig;
    }
}
