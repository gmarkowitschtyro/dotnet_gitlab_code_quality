namespace CodeQualityToGitlab;

public class CodeQuality
{
    public string Description { get; set; } = null!;
    public string Fingerprint { get; set; } = null!;
    public Severity Severity { get; set; } 
    public LocationCq Location { get; set; } = null!;
}

public class LocationCq
{
    public string Path { get; set; } = null!;
    public Lines Lines { get; set; } = null!;
}

public class Lines
{
    public int Begin { get; set; }
}

public enum Severity
{
    info,
    minor,
    major,
    critical,
    blocker
}
