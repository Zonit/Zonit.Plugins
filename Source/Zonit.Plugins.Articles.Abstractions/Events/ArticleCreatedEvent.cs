namespace Zonit.Plugins.Articles.Abstractions;

/// <summary>
/// Represents an event that occurs when an article is created.
/// </summary>
/// <remarks>This event contains information about the article's unique identifier and optional related entities,
/// such as the organization, project, or user associated with the article.</remarks>
public class ArticleCreatedEvent
{
    public required Guid Id { get; set; }
    public Guid? OrganizationId { get; set; }
    public Guid? ProjectId { get; set; }
    public Guid? UserId { get; set; }
}