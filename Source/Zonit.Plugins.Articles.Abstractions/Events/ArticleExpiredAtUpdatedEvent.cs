namespace Zonit.Plugins.Articles.Abstractions;

/// <summary>
/// Represents an event that occurs when the expiration date of an article is updated.
/// </summary>
/// <remarks>This event is typically used to notify subscribers about changes to the expiration date of an
/// article.</remarks>
public class ArticleExpiredAtUpdatedEvent
{
    public required Guid Id { get; set; }
    public required DateTime ExpiresAt { get; set; }
}