using System.Xml.Serialization;

namespace CocoaSync.Data;

[XmlRoot(ElementName = "title", Namespace = "http://www.w3.org/2005/Atom")]
public class Title
{
    [XmlAttribute(AttributeName = "type")]
    public string? Type { get; set; }
    [XmlText]
    public string? Text { get; set; }
}

[XmlRoot(ElementName = "link", Namespace = "http://www.w3.org/2005/Atom")]
public class Link
{
    [XmlAttribute(AttributeName = "rel")]
    public string? Rel { get; set; }
    [XmlAttribute(AttributeName = "title")]
    public string? Title { get; set; }
    [XmlAttribute(AttributeName = "href")]
    public string? Href { get; set; }
}

[XmlRoot(ElementName = "summary", Namespace = "http://www.w3.org/2005/Atom")]
public class Summary
{
    [XmlAttribute(AttributeName = "type")]
    public string? Type { get; set; }
    [XmlText]
    public string? Text { get; set; }
}

[XmlRoot(ElementName = "author", Namespace = "http://www.w3.org/2005/Atom")]
public class Author
{
    [XmlElement(ElementName = "name", Namespace = "http://www.w3.org/2005/Atom")]
    public string? Name { get; set; }
}

[XmlRoot(ElementName = "category", Namespace = "http://www.w3.org/2005/Atom")]
public class Category
{
    [XmlAttribute(AttributeName = "term")]
    public string? Term { get; set; }
    [XmlAttribute(AttributeName = "scheme")]
    public string? Scheme { get; set; }
}

[XmlRoot(ElementName = "content", Namespace = "http://www.w3.org/2005/Atom")]
public class Content
{
    [XmlAttribute(AttributeName = "type")]
    public string? Type { get; set; }
    [XmlAttribute(AttributeName = "src")]
    public string? Src { get; set; }
}

[XmlRoot(ElementName = "Tags", Namespace = "http://schemas.microsoft.com/ado/2007/08/dataservices")]
public class Tags
{
    [XmlAttribute(AttributeName = "space", Namespace = "http://www.w3.org/XML/1998/namespace")]
    public string? Space { get; set; }
    [XmlText]
    public string? Text { get; set; }
}

[XmlRoot(ElementName = "Created", Namespace = "http://schemas.microsoft.com/ado/2007/08/dataservices")]
public class Created
{
    [XmlAttribute(AttributeName = "type", Namespace = "http://schemas.microsoft.com/ado/2007/08/dataservices/metadata")]
    public string? Type { get; set; }
    [XmlText]
    public string? Text { get; set; }
}

[XmlRoot(ElementName = "DownloadCount", Namespace = "http://schemas.microsoft.com/ado/2007/08/dataservices")]
public class DownloadCount
{
    [XmlAttribute(AttributeName = "type", Namespace = "http://schemas.microsoft.com/ado/2007/08/dataservices/metadata")]
    public string? Type { get; set; }
    [XmlText]
    public string? Text { get; set; }
}

[XmlRoot(ElementName = "VersionDownloadCount", Namespace = "http://schemas.microsoft.com/ado/2007/08/dataservices")]
public class VersionDownloadCount
{
    [XmlAttribute(AttributeName = "type", Namespace = "http://schemas.microsoft.com/ado/2007/08/dataservices/metadata")]
    public string? Type { get; set; }
    [XmlText]
    public string? Text { get; set; }
}

[XmlRoot(ElementName = "IsLatestVersion", Namespace = "http://schemas.microsoft.com/ado/2007/08/dataservices")]
public class IsLatestVersion
{
    [XmlAttribute(AttributeName = "type", Namespace = "http://schemas.microsoft.com/ado/2007/08/dataservices/metadata")]
    public string? Type { get; set; }
    [XmlText]
    public string? Text { get; set; }
}

[XmlRoot(ElementName = "IsAbsoluteLatestVersion", Namespace = "http://schemas.microsoft.com/ado/2007/08/dataservices")]
public class IsAbsoluteLatestVersion
{
    [XmlAttribute(AttributeName = "type", Namespace = "http://schemas.microsoft.com/ado/2007/08/dataservices/metadata")]
    public string? Type { get; set; }
    [XmlText]
    public string? Text { get; set; }
}

[XmlRoot(ElementName = "IsPrerelease", Namespace = "http://schemas.microsoft.com/ado/2007/08/dataservices")]
public class IsPrerelease
{
    [XmlAttribute(AttributeName = "type", Namespace = "http://schemas.microsoft.com/ado/2007/08/dataservices/metadata")]
    public string? Type { get; set; }
    [XmlText]
    public string? Text { get; set; }
}

[XmlRoot(ElementName = "Published", Namespace = "http://schemas.microsoft.com/ado/2007/08/dataservices")]
public class Published
{
    [XmlAttribute(AttributeName = "type", Namespace = "http://schemas.microsoft.com/ado/2007/08/dataservices/metadata")]
    public string? Type { get; set; }
    [XmlText]
    public string? Text { get; set; }
}

[XmlRoot(ElementName = "RequireLicenseAcceptance", Namespace = "http://schemas.microsoft.com/ado/2007/08/dataservices")]
public class RequireLicenseAcceptance
{
    [XmlAttribute(AttributeName = "type", Namespace = "http://schemas.microsoft.com/ado/2007/08/dataservices/metadata")]
    public string? Type { get; set; }
    [XmlText]
    public string? Text { get; set; }
}

[XmlRoot(ElementName = "PackageSize", Namespace = "http://schemas.microsoft.com/ado/2007/08/dataservices")]
public class PackageSize
{
    [XmlAttribute(AttributeName = "type", Namespace = "http://schemas.microsoft.com/ado/2007/08/dataservices/metadata")]
    public string? Type { get; set; }
    [XmlText]
    public string? Text { get; set; }
}

[XmlRoot(ElementName = "IsApproved", Namespace = "http://schemas.microsoft.com/ado/2007/08/dataservices")]
public class IsApproved
{
    [XmlAttribute(AttributeName = "type", Namespace = "http://schemas.microsoft.com/ado/2007/08/dataservices/metadata")]
    public string? Type { get; set; }
    [XmlText]
    public string? Text { get; set; }
}

[XmlRoot(ElementName = "PackageTestResultStatusDate", Namespace = "http://schemas.microsoft.com/ado/2007/08/dataservices")]
public class PackageTestResultStatusDate
{
    [XmlAttribute(AttributeName = "type", Namespace = "http://schemas.microsoft.com/ado/2007/08/dataservices/metadata")]
    public string? Type { get; set; }
    [XmlText]
    public string? Text { get; set; }
    [XmlAttribute(AttributeName = "null", Namespace = "http://schemas.microsoft.com/ado/2007/08/dataservices/metadata")]
    public string? Null { get; set; }
}

[XmlRoot(ElementName = "PackageValidationResultDate", Namespace = "http://schemas.microsoft.com/ado/2007/08/dataservices")]
public class PackageValidationResultDate
{
    [XmlAttribute(AttributeName = "type", Namespace = "http://schemas.microsoft.com/ado/2007/08/dataservices/metadata")]
    public string? Type { get; set; }
    [XmlText]
    public string? Text { get; set; }
    [XmlAttribute(AttributeName = "null", Namespace = "http://schemas.microsoft.com/ado/2007/08/dataservices/metadata")]
    public string? Null { get; set; }
}

[XmlRoot(ElementName = "PackageCleanupResultDate", Namespace = "http://schemas.microsoft.com/ado/2007/08/dataservices")]
public class PackageCleanupResultDate
{
    [XmlAttribute(AttributeName = "type", Namespace = "http://schemas.microsoft.com/ado/2007/08/dataservices/metadata")]
    public string? Type { get; set; }
    [XmlAttribute(AttributeName = "null", Namespace = "http://schemas.microsoft.com/ado/2007/08/dataservices/metadata")]
    public string? Null { get; set; }
}

[XmlRoot(ElementName = "PackageReviewedDate", Namespace = "http://schemas.microsoft.com/ado/2007/08/dataservices")]
public class PackageReviewedDate
{
    [XmlAttribute(AttributeName = "type", Namespace = "http://schemas.microsoft.com/ado/2007/08/dataservices/metadata")]
    public string? Type { get; set; }
    [XmlText]
    public string? Text { get; set; }
    [XmlAttribute(AttributeName = "null", Namespace = "http://schemas.microsoft.com/ado/2007/08/dataservices/metadata")]
    public string? Null { get; set; }
}

[XmlRoot(ElementName = "PackageApprovedDate", Namespace = "http://schemas.microsoft.com/ado/2007/08/dataservices")]
public class PackageApprovedDate
{
    [XmlAttribute(AttributeName = "type", Namespace = "http://schemas.microsoft.com/ado/2007/08/dataservices/metadata")]
    public string? Type { get; set; }
    [XmlText]
    public string? Text { get; set; }
    [XmlAttribute(AttributeName = "null", Namespace = "http://schemas.microsoft.com/ado/2007/08/dataservices/metadata")]
    public string? Null { get; set; }
}

[XmlRoot(ElementName = "IsDownloadCacheAvailable", Namespace = "http://schemas.microsoft.com/ado/2007/08/dataservices")]
public class IsDownloadCacheAvailable
{
    [XmlAttribute(AttributeName = "type", Namespace = "http://schemas.microsoft.com/ado/2007/08/dataservices/metadata")]
    public string? Type { get; set; }
    [XmlText]
    public string? Text { get; set; }
}

[XmlRoot(ElementName = "DownloadCacheDate", Namespace = "http://schemas.microsoft.com/ado/2007/08/dataservices")]
public class DownloadCacheDate
{
    [XmlAttribute(AttributeName = "type", Namespace = "http://schemas.microsoft.com/ado/2007/08/dataservices/metadata")]
    public string? Type { get; set; }
    [XmlText]
    public string? Text { get; set; }
    [XmlAttribute(AttributeName = "null", Namespace = "http://schemas.microsoft.com/ado/2007/08/dataservices/metadata")]
    public string? Null { get; set; }
}

[XmlRoot(ElementName = "PackageScanResultDate", Namespace = "http://schemas.microsoft.com/ado/2007/08/dataservices")]
public class PackageScanResultDate
{
    [XmlAttribute(AttributeName = "type", Namespace = "http://schemas.microsoft.com/ado/2007/08/dataservices/metadata")]
    public string? Type { get; set; }
    [XmlText]
    public string? Text { get; set; }
}

[XmlRoot(ElementName = "properties", Namespace = "http://schemas.microsoft.com/ado/2007/08/dataservices/metadata")]
public class Properties
{
    [XmlElement(ElementName = "Version", Namespace = "http://schemas.microsoft.com/ado/2007/08/dataservices")]
    public string? Version { get; set; }
    [XmlElement(ElementName = "Title", Namespace = "http://schemas.microsoft.com/ado/2007/08/dataservices")]
    public string? Title { get; set; }
    [XmlElement(ElementName = "Description", Namespace = "http://schemas.microsoft.com/ado/2007/08/dataservices")]
    public string? Description { get; set; }
    [XmlElement(ElementName = "Tags", Namespace = "http://schemas.microsoft.com/ado/2007/08/dataservices")]
    public Tags? Tags { get; set; }
    [XmlElement(ElementName = "Copyright", Namespace = "http://schemas.microsoft.com/ado/2007/08/dataservices")]
    public string? Copyright { get; set; }
    [XmlElement(ElementName = "Created", Namespace = "http://schemas.microsoft.com/ado/2007/08/dataservices")]
    public Created? Created { get; set; }
    [XmlElement(ElementName = "Dependencies", Namespace = "http://schemas.microsoft.com/ado/2007/08/dataservices")]
    public string? Dependencies { get; set; }
    [XmlElement(ElementName = "DownloadCount", Namespace = "http://schemas.microsoft.com/ado/2007/08/dataservices")]
    public DownloadCount? DownloadCount { get; set; }
    [XmlElement(ElementName = "VersionDownloadCount", Namespace = "http://schemas.microsoft.com/ado/2007/08/dataservices")]
    public VersionDownloadCount? VersionDownloadCount { get; set; }
    [XmlElement(ElementName = "GalleryDetailsUrl", Namespace = "http://schemas.microsoft.com/ado/2007/08/dataservices")]
    public string? GalleryDetailsUrl { get; set; }
    [XmlElement(ElementName = "ReportAbuseUrl", Namespace = "http://schemas.microsoft.com/ado/2007/08/dataservices")]
    public string? ReportAbuseUrl { get; set; }
    [XmlElement(ElementName = "IconUrl", Namespace = "http://schemas.microsoft.com/ado/2007/08/dataservices")]
    public string? IconUrl { get; set; }
    [XmlElement(ElementName = "IsLatestVersion", Namespace = "http://schemas.microsoft.com/ado/2007/08/dataservices")]
    public IsLatestVersion? IsLatestVersion { get; set; }
    [XmlElement(ElementName = "IsAbsoluteLatestVersion", Namespace = "http://schemas.microsoft.com/ado/2007/08/dataservices")]
    public IsAbsoluteLatestVersion? IsAbsoluteLatestVersion { get; set; }
    [XmlElement(ElementName = "IsPrerelease", Namespace = "http://schemas.microsoft.com/ado/2007/08/dataservices")]
    public IsPrerelease? IsPrerelease { get; set; }
    [XmlElement(ElementName = "Language", Namespace = "http://schemas.microsoft.com/ado/2007/08/dataservices")]
    public string? Language { get; set; }
    [XmlElement(ElementName = "Published", Namespace = "http://schemas.microsoft.com/ado/2007/08/dataservices")]
    public Published? Published { get; set; }
    [XmlElement(ElementName = "LicenseUrl", Namespace = "http://schemas.microsoft.com/ado/2007/08/dataservices")]
    public string? LicenseUrl { get; set; }
    [XmlElement(ElementName = "RequireLicenseAcceptance", Namespace = "http://schemas.microsoft.com/ado/2007/08/dataservices")]
    public RequireLicenseAcceptance? RequireLicenseAcceptance { get; set; }
    [XmlElement(ElementName = "PackageHash", Namespace = "http://schemas.microsoft.com/ado/2007/08/dataservices")]
    public string? PackageHash { get; set; }
    [XmlElement(ElementName = "PackageHashAlgorithm", Namespace = "http://schemas.microsoft.com/ado/2007/08/dataservices")]
    public string? PackageHashAlgorithm { get; set; }
    [XmlElement(ElementName = "PackageSize", Namespace = "http://schemas.microsoft.com/ado/2007/08/dataservices")]
    public PackageSize? PackageSize { get; set; }
    [XmlElement(ElementName = "ProjectUrl", Namespace = "http://schemas.microsoft.com/ado/2007/08/dataservices")]
    public string? ProjectUrl { get; set; }
    [XmlElement(ElementName = "ReleaseNotes", Namespace = "http://schemas.microsoft.com/ado/2007/08/dataservices")]
    public string? ReleaseNotes { get; set; }
    [XmlElement(ElementName = "ProjectSourceUrl", Namespace = "http://schemas.microsoft.com/ado/2007/08/dataservices")]
    public string? ProjectSourceUrl { get; set; }
    [XmlElement(ElementName = "PackageSourceUrl", Namespace = "http://schemas.microsoft.com/ado/2007/08/dataservices")]
    public string? PackageSourceUrl { get; set; }
    [XmlElement(ElementName = "DocsUrl", Namespace = "http://schemas.microsoft.com/ado/2007/08/dataservices")]
    public string? DocsUrl { get; set; }
    [XmlElement(ElementName = "MailingListUrl", Namespace = "http://schemas.microsoft.com/ado/2007/08/dataservices")]
    public string? MailingListUrl { get; set; }
    [XmlElement(ElementName = "BugTrackerUrl", Namespace = "http://schemas.microsoft.com/ado/2007/08/dataservices")]
    public string? BugTrackerUrl { get; set; }
    [XmlElement(ElementName = "IsApproved", Namespace = "http://schemas.microsoft.com/ado/2007/08/dataservices")]
    public IsApproved? IsApproved { get; set; }
    [XmlElement(ElementName = "PackageStatus", Namespace = "http://schemas.microsoft.com/ado/2007/08/dataservices")]
    public string? PackageStatus { get; set; }
    [XmlElement(ElementName = "PackageSubmittedStatus", Namespace = "http://schemas.microsoft.com/ado/2007/08/dataservices")]
    public string? PackageSubmittedStatus { get; set; }
    [XmlElement(ElementName = "PackageTestResultUrl", Namespace = "http://schemas.microsoft.com/ado/2007/08/dataservices")]
    public string? PackageTestResultUrl { get; set; }
    [XmlElement(ElementName = "PackageTestResultStatus", Namespace = "http://schemas.microsoft.com/ado/2007/08/dataservices")]
    public string? PackageTestResultStatus { get; set; }
    [XmlElement(ElementName = "PackageTestResultStatusDate", Namespace = "http://schemas.microsoft.com/ado/2007/08/dataservices")]
    public PackageTestResultStatusDate? PackageTestResultStatusDate { get; set; }
    [XmlElement(ElementName = "PackageValidationResultStatus", Namespace = "http://schemas.microsoft.com/ado/2007/08/dataservices")]
    public string? PackageValidationResultStatus { get; set; }
    [XmlElement(ElementName = "PackageValidationResultDate", Namespace = "http://schemas.microsoft.com/ado/2007/08/dataservices")]
    public PackageValidationResultDate? PackageValidationResultDate { get; set; }
    [XmlElement(ElementName = "PackageCleanupResultDate", Namespace = "http://schemas.microsoft.com/ado/2007/08/dataservices")]
    public PackageCleanupResultDate? PackageCleanupResultDate { get; set; }
    [XmlElement(ElementName = "PackageReviewedDate", Namespace = "http://schemas.microsoft.com/ado/2007/08/dataservices")]
    public PackageReviewedDate? PackageReviewedDate { get; set; }
    [XmlElement(ElementName = "PackageApprovedDate", Namespace = "http://schemas.microsoft.com/ado/2007/08/dataservices")]
    public PackageApprovedDate? PackageApprovedDate { get; set; }
    [XmlElement(ElementName = "PackageReviewer", Namespace = "http://schemas.microsoft.com/ado/2007/08/dataservices")]
    public string? PackageReviewer { get; set; }
    [XmlElement(ElementName = "IsDownloadCacheAvailable", Namespace = "http://schemas.microsoft.com/ado/2007/08/dataservices")]
    public IsDownloadCacheAvailable? IsDownloadCacheAvailable { get; set; }
    [XmlElement(ElementName = "DownloadCacheStatus", Namespace = "http://schemas.microsoft.com/ado/2007/08/dataservices")]
    public string? DownloadCacheStatus { get; set; }
    [XmlElement(ElementName = "DownloadCacheDate", Namespace = "http://schemas.microsoft.com/ado/2007/08/dataservices")]
    public DownloadCacheDate? DownloadCacheDate { get; set; }
    [XmlElement(ElementName = "DownloadCache", Namespace = "http://schemas.microsoft.com/ado/2007/08/dataservices")]
    public string? DownloadCache { get; set; }
    [XmlElement(ElementName = "PackageScanStatus", Namespace = "http://schemas.microsoft.com/ado/2007/08/dataservices")]
    public string? PackageScanStatus { get; set; }
    [XmlElement(ElementName = "PackageScanResultDate", Namespace = "http://schemas.microsoft.com/ado/2007/08/dataservices")]
    public PackageScanResultDate? PackageScanResultDate { get; set; }
    [XmlElement(ElementName = "PackageScanFlagResult", Namespace = "http://schemas.microsoft.com/ado/2007/08/dataservices")]
    public string? PackageScanFlagResult { get; set; }
    [XmlAttribute(AttributeName = "m", Namespace = "http://www.w3.org/2000/xmlns/")]
    public string? M { get; set; }
    [XmlAttribute(AttributeName = "d", Namespace = "http://www.w3.org/2000/xmlns/")]
    public string? D { get; set; }
}

[XmlRoot(ElementName = "entry", Namespace = "http://www.w3.org/2005/Atom")]
public class Entry
{
    [XmlElement(ElementName = "id", Namespace = "http://www.w3.org/2005/Atom")]
    public string? Id { get; set; }
    [XmlElement(ElementName = "title", Namespace = "http://www.w3.org/2005/Atom")]
    public Title? Title { get; set; }
    [XmlElement(ElementName = "summary", Namespace = "http://www.w3.org/2005/Atom")]
    public Summary? Summary { get; set; }
    [XmlElement(ElementName = "updated", Namespace = "http://www.w3.org/2005/Atom")]
    public string? Updated { get; set; }
    [XmlElement(ElementName = "author", Namespace = "http://www.w3.org/2005/Atom")]
    public Author? Author { get; set; }
    [XmlElement(ElementName = "link", Namespace = "http://www.w3.org/2005/Atom")]
    public List<Link>? Link { get; set; }
    [XmlElement(ElementName = "category", Namespace = "http://www.w3.org/2005/Atom")]
    public Category? Category { get; set; }
    [XmlElement(ElementName = "content", Namespace = "http://www.w3.org/2005/Atom")]
    public Content? Content { get; set; }
    [XmlElement(ElementName = "properties", Namespace = "http://schemas.microsoft.com/ado/2007/08/dataservices/metadata")]
    public Properties? Properties { get; set; }
}

[XmlRoot(ElementName = "feed", Namespace = "http://www.w3.org/2005/Atom")]
public class Feed
{
    [XmlElement(ElementName = "title", Namespace = "http://www.w3.org/2005/Atom")]
    public Title? Title { get; set; }
    [XmlElement(ElementName = "id", Namespace = "http://www.w3.org/2005/Atom")]
    public string? Id { get; set; }
    [XmlElement(ElementName = "updated", Namespace = "http://www.w3.org/2005/Atom")]
    public string? Updated { get; set; }
    [XmlElement(ElementName = "link", Namespace = "http://www.w3.org/2005/Atom")]
    public Link? Link { get; set; }
    [XmlElement(ElementName = "entry", Namespace = "http://www.w3.org/2005/Atom")]
    public List<Entry>? Entry { get; set; }
    [XmlAttribute(AttributeName = "base", Namespace = "http://www.w3.org/XML/1998/namespace")]
    public string? Base { get; set; }
    [XmlAttribute(AttributeName = "d", Namespace = "http://www.w3.org/2000/xmlns/")]
    public string? D { get; set; }
    [XmlAttribute(AttributeName = "m", Namespace = "http://www.w3.org/2000/xmlns/")]
    public string? M { get; set; }
    [XmlAttribute(AttributeName = "xmlns")]
    public string? Xmlns { get; set; }
}
