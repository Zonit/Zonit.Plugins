namespace Zonit.Plugins.Articles.Abstractions.Events;

/// <summary>
/// Represents an event triggered when an article is created.
/// </summary>
/// <remarks>This event contains information about the article creation, including its unique identifier and
/// optional associations with an organization, project, or user.</remarks>
public class ArticleCreateEvent
{
    public Guid Id { get; set; }
    public Guid? OrganizationId { get; set; }
    public Guid? ProjectId { get; set; }
    public Guid? UserId { get; set; }
}
