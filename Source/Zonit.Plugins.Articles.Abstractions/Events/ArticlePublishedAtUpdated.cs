namespace Zonit.Plugins.Articles.Abstractions;

/// <summary>
/// Represents an event indicating that the publication date and time of an article has been updated.
/// </summary>
/// <remarks>This class is typically used to convey information about an article whose publication timestamp has
/// been modified.</remarks>
public class ArticlePublishedAtUpdated
{
    public required Guid Id { get; set; }
    public required DateTime PublishedAt { get; set; }
}