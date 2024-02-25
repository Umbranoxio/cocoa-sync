#pragma warning disable CA1416

using Microsoft.Win32;
using System.Text.RegularExpressions;
using System.Xml.Serialization;
using CocoaSync.Data;

namespace CocoaSync;

public class ProgramSearcher
{
    private readonly HttpClient _httpClient;
    private readonly List<string> _publisherIgnoreList;
    private readonly Logger _logger = new Logger("main.log");
    private readonly Config _config;

    public ProgramSearcher(List<string> publisherIgnoreList, Logger logger, Config config)
    {
        _httpClient = new HttpClient();
        _publisherIgnoreList = publisherIgnoreList;
        _logger = logger;
        _config = config;
    }

    internal async Task<List<ProgramMapping>> GetMappings()
    {
        var mappings = new List<ProgramMapping>();

        var installedPrograms = GetInstalledPrograms();

        foreach (var program in installedPrograms)
        {
            if (IsPublisherIgnored(program.Publisher))
            {
                continue;
            }

            try
            {
                var chocolateyId = await GetPackageId(program.Name);
                mappings.Add(new ProgramMapping { InstalledProgram = program, ChocolateyId = chocolateyId });
            }
            catch (Exception ex)
            {
                _logger.Log($"Failed to find package id for {program.Name}: {ex.Message}");
            }
        }

        return mappings;
    }

    private bool IsPublisherIgnored(string? publisher)
    {
        if (publisher == null) return true;
        return _publisherIgnoreList.Contains(publisher);
    }

    public async Task<string> GetPackageId(string? packageName)
    {
        if (packageName == null)
        {
            throw new ArgumentNullException(nameof(packageName));
        }

        var knownMapping = _config.KnownMappings.FirstOrDefault(m => m.PackageName == packageName);
        if (knownMapping != null && knownMapping.ChocolateyId != null)
        {
            return knownMapping.ChocolateyId;
        }

        string result = await _httpClient.GetStringAsync($"https://community.chocolatey.org/api/v2/Search()?$filter=IsLatestVersion&$skip=0&$top=30&searchTerm='{packageName}'&targetFramework=''&includePrerelease=false");
        Feed? feed = DeserializeXml(result);

        if (feed?.Entry == null || feed.Entry.Count == 0)
        {
            throw new Exception($"No entries found for {packageName}");
        }

        var entry = feed.Entry[0];
        var urlInfo = Regex.Match(entry.Id ?? "", @"Id='(.*?)',Version='(.*?)'");

        if (!urlInfo.Success)
        {
            throw new Exception("Failed to get version information");
        }

        var id = urlInfo.Groups[1].Value;

        if (entry.Properties?.IsApproved?.Text != "true" || entry.Properties?.IsLatestVersion?.Text != "true")
        {
            throw new Exception("Package not approved or not the latest version");
        }

        return id;
    }

    internal Feed? DeserializeXml(string xml)
    {
        XmlSerializer serializer = new XmlSerializer(typeof(Feed));
        using (StringReader reader = new StringReader(xml))
        {
            return (Feed?)serializer.Deserialize(reader);
        }
    }

    internal List<InstalledProgram> GetInstalledPrograms()
    {
        var result = new List<InstalledProgram>();
        string[] registryKeys = new string[]
        {
            @"SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall",
            @"SOFTWARE\Wow6432Node\Microsoft\Windows\CurrentVersion\Uninstall"
        };

        foreach (var registryKey in registryKeys)
        {
            result.AddRange(GetProgramsFromRegistryKey(Registry.LocalMachine, registryKey));
            result.AddRange(GetProgramsFromRegistryKey(Registry.CurrentUser, registryKey));
        }

        return result;
    }

    internal List<InstalledProgram> GetProgramsFromRegistryKey(RegistryKey baseKey, string registryKey)
    {
        var result = new List<InstalledProgram>();

        using (RegistryKey? key = baseKey.OpenSubKey(registryKey))
        {
            if (key == null)
            {
                return result;
            }

            foreach (string subkeyName in key.GetSubKeyNames())
            {
                using (RegistryKey? subkey = key.OpenSubKey(subkeyName))
                {
                    if (subkey?.GetValue("DisplayName") != null)
                    {
                        string? name = RemoveExtraInfo(subkey.GetValue("DisplayName")?.ToString() ?? null);
                        string? publisher = subkey.GetValue("Publisher")?.ToString() ?? null;
                        string? version = subkey.GetValue("DisplayVersion")?.ToString() ?? null;
                        string? installDate = subkey.GetValue("InstallDate")?.ToString() ?? null;
                        result.Add(new InstalledProgram { Name = name, Publisher = publisher, Version = version, InstallDate = installDate });
                    }
                }
            }
        }

        return result;
    }

    internal readonly Regex removeExtraInfoRegex = new Regex(@"\s*\b(version|v|V)?\s*\d+(\.\d+)*\b|\s*\((.*?)\)\s*");
    internal string? RemoveExtraInfo(string? name)
    {
        if (name == null) { return null; }
        string cleanedSoftware = removeExtraInfoRegex.Replace(name, string.Empty);
        return cleanedSoftware;
    }
}
