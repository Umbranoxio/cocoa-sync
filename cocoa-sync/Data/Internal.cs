namespace CocoaSync.Data
{
    internal class ProgramMapping
    {
        internal InstalledProgram? InstalledProgram { get; set; }
        internal string? ChocolateyId { get; set; }
    }

    public class InstalledProgram
    {
        public string? Name { get; set; }
        public string? Publisher { get; set; }
        public string? Version { get; set; }
        public string? InstallDate { get; set; }
    }
}
