namespace Zonit.Plugins.Articles.Abstractions.Events;

public class ArticleDraftUpdatedEvent
{
    public Guid Id { get; set; }
    public string Content { get; set; } = string.Empty;
    public Guid? UserId { get; set; }
}
