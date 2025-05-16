namespace Zonit.Plugins.Articles.Abstractions;

/// <summary>
/// Represents an event that occurs when the permissions for an article are updated.
/// </summary>
/// <remarks>This event contains information about the article whose permissions were updated,  including its
/// unique identifier and the updated permission value.</remarks>
public class ArticlePermissionUpdatedEvent
{
    public required Guid Id { get; set; }
    public required string Permission { get; set; }
}
