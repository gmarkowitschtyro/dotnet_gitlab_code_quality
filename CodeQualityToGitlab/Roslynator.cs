namespace CodeQualityToGitlab;

using System.Xml.Serialization;

[XmlRoot(ElementName = "Diagnostic")]
public class Diagnostic
{
    [XmlAttribute(AttributeName = "Id")]
    public string Id { get; set; } = null!;

    [XmlAttribute(AttributeName = "Title")]
    public string Title { get; set; } = null!;

    [XmlAttribute(AttributeName = "Count")]
    public string Count { get; set; } = null!;

    [XmlElement(ElementName = "Severity")]
    public string Severity { get; set; } = null!;

    [XmlElement(ElementName = "Message")]
    public string Message { get; set; } = null!;

    [XmlElement(ElementName = "FilePath")]
    public string? FilePath { get; set; }

    [XmlElement(ElementName = "Location")]
    public Location? Location { get; set; }
}

[XmlRoot(ElementName = "Summary")]
public class Summary
{
    [XmlElement(ElementName = "Diagnostic")]
    public List<Diagnostic> Diagnostic { get; set; } = new();
}

[XmlRoot(ElementName = "Location")]
public class Location
{
    [XmlAttribute(AttributeName = "Line")]
    public string Line { get; set; } = null!;

    [XmlAttribute(AttributeName = "Character")]
    public string Character { get; set; } = null!;
}

[XmlRoot(ElementName = "Diagnostics")]
public class Diagnostics
{
    [XmlElement(ElementName = "Diagnostic")]
    public List<Diagnostic> Diagnostic { get; set; } = new();
}

[XmlRoot(ElementName = "Project")]
public class Project
{
    [XmlElement(ElementName = "Diagnostics")]
    public Diagnostics Diagnostics { get; set; } = null!;

    [XmlAttribute(AttributeName = "Name")]
    public string Name { get; set; } = null!;

    [XmlAttribute(AttributeName = "FilePath")]
    public string FilePath { get; set; } = null!;
}

[XmlRoot(ElementName = "Projects")]
public class Projects
{
    [XmlElement(ElementName = "Project")]
    public List<Project> Project { get; set; } = new();
}

[XmlRoot(ElementName = "CodeAnalysis")]
public class CodeAnalysis
{
    [XmlElement(ElementName = "Summary")]
    public Summary Summary { get; set; } = null!;

    [XmlElement(ElementName = "Projects")]
    public Projects Projects { get; set; } = null!;
}

[XmlRoot(ElementName = "Roslynator")]
public class Roslynator
{
    [XmlElement(ElementName = "CodeAnalysis")]
    public CodeAnalysis CodeAnalysis { get; set; } = null!;
}
