namespace Zonit.Plugins.Articles.Abstractions.Events;

public class ArticlePermissionUpdatedEvent
{
    public Guid Id { get; set; }
    public string Permission { get; set; } = string.Empty;
}
