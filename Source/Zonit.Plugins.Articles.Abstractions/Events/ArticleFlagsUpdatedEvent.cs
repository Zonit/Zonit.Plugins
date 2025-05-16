namespace Zonit.Plugins.Articles.Abstractions;

/// <summary>
/// Represents an event that occurs when the flags of an article are updated.
/// </summary>
/// <remarks>This event contains the unique identifier of the article and the updated set of flags.</remarks>
public class ArticleFlagsUpdatedEvent
{
    public required Guid Id { get; set; }
    public required string[] Flags { get; set; }
}