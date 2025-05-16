namespace Zonit.Plugins.Articles.Abstractions;

/// <summary>
/// Represents an event that occurs when an image is added to an article.
/// </summary>
/// <remarks>This event contains information about the article, the image being added, and its associated
/// metadata.</remarks>
public class ArticleImageAddedEvent
{
    public required Guid ArticleId { get; set; }
    public required Guid ImageName { get; set; }
    public required byte[] Image { get; set; }
    public required string Type { get; set; }
}