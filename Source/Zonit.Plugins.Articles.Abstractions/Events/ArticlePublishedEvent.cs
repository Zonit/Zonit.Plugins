namespace Zonit.Plugins.Articles.Abstractions;

/// <summary>
/// Represents an event that occurs when an article is published.
/// </summary>
/// <remarks>This event contains the unique identifier and content of the published article. It can be used to
/// notify subscribers or trigger workflows related to article publication.</remarks>
public class ArticlePublishedEvent
{
    public required Guid Id { get; set; }
    public required string Content { get; set; }
}