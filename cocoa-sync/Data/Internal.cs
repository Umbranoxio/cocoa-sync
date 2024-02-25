namespace CocoaSync.Data
{
    public class ProgramMapping
    {
        public InstalledProgram? InstalledProgram { get; set; }
        public string? ChocolateyId { get; set; }
    }

    public class InstalledProgram
    {
        public string? Name { get; set; }
        public string? Publisher { get; set; }
        public string? Version { get; set; }
        public string? InstallDate { get; set; }
    }
}
