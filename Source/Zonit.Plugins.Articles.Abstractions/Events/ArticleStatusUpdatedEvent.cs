namespace Zonit.Plugins.Articles.Abstractions;

/// <summary>
/// Represents an event that occurs when the status of an article is updated.
/// </summary>
/// <remarks>This event contains information about the article's unique identifier and its updated status. It can
/// be used to track changes to article statuses in a system.</remarks>
public class ArticleStatusUpdatedEvent
{
    public required Guid Id { get; set; }
    public required string Status { get; set; }
}