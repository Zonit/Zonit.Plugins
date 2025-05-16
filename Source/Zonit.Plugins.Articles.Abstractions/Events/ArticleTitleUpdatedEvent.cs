namespace Zonit.Plugins.Articles.Abstractions;

/// <summary>
/// Represents an event that occurs when the title of an article is updated.
/// </summary>
/// <remarks>This event contains the unique identifier of the article and its updated title. It can be used to
/// track changes to article titles in a system.</remarks>
public class ArticleTitleUpdatedEvent
{
    public required Guid Id { get; set; }
    public required string Title { get; set; }
}