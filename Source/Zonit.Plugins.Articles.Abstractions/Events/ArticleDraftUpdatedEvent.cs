namespace Zonit.Plugins.Articles.Abstractions;

/// <summary>
/// Represents an event that occurs when an article draft is updated.
/// </summary>
/// <remarks>This event contains information about the updated draft, including its unique identifier,  the
/// updated content, and optionally the identifier of the user who performed the update.</remarks>
public class ArticleDraftUpdatedEvent
{
    public required Guid Id { get; set; }
    public required string Content { get; set; }
    public Guid? UserId { get; set; }
}
