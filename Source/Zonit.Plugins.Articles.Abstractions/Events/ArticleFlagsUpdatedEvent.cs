namespace Zonit.Plugins.Articles.Abstractions;

/// <summary>
/// Represents an event that occurs when the flags of an article are updated.
/// </summary>
/// <remarks>This event is typically used to track changes to the flags associated with an article. The <see
/// cref="Id"/> property uniquely identifies the article whose flags were updated.</remarks>
public class ArticleFlagsUpdatedEvent
{
    public required Guid Id { get; set; }
}