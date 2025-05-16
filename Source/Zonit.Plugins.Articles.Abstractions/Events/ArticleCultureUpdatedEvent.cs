namespace Zonit.Plugins.Articles.Abstractions;

/// <summary>
/// Represents an event that occurs when the culture of an article is updated.
/// </summary>
/// <remarks>This event contains the unique identifier of the article and the updated culture. It can be used to
/// track or respond to changes in the culture associated with an article.</remarks>
public class ArticleCultureUpdatedEvent
{
    public required Guid Id { get; set; }
    public required string Culture { get; set; }
}